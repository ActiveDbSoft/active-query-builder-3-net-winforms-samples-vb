''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2021 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''


Imports ActiveQueryBuilder.Core

Partial Public Class Form1
    Inherits Form
    Private _joinFieldName As SQLQualifiedName
    Private _companyNameFieldName As SQLQualifiedName
    Private _orderDateFieldName As SQLQualifiedName

    Private _customers As DataSource
    Private _orders As DataSource
    Private _companyName As QueryColumnListItem
    Private _orderDate As QueryColumnListItem

    Private Const CustomersName As String = "Northwind.dbo.Customers"
    Private Const OrdersName As String = "Northwind.dbo.Orders"
    Private Const CustomersAlias As String = "c"
    Private Const OrdersAlias As String = "o"
    Private Const CustomersCompanyName As String = "CompanyName"
    Private Const CusomerId As String = "CustomerId"
    Private Const OrderDate As String = "OrderDate"

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        ' load metadata from XML file located in resource (for demonstration purposes)
        queryBuilder1.MetadataContainer.LoadingOptions.OfflineMode = True
        queryBuilder1.MetadataContainer.ImportFromXML("Northwind.xml")
        queryBuilder1.InitializeDatabaseSchemaTree()

        AddHandler queryBuilder1.SQLUpdated, AddressOf SqlUpdated

        'prepare parsed names
        _joinFieldName = queryBuilder1.SQLContext.ParseQualifiedName(CusomerId)
        _companyNameFieldName = queryBuilder1.SQLContext.ParseQualifiedName(CustomersCompanyName)
        _orderDateFieldName = queryBuilder1.SQLContext.ParseQualifiedName(OrderDate)

        MyBase.OnLoad(e)
    End Sub

    Private Function IsTablePresentInQuery(ByVal unionSubQuery As UnionSubQuery, ByVal table As DataSource) As Boolean
        ' collect the list of datasources used in FROM
        Dim dataSources = unionSubQuery.GetChildrenRecursive(Of DataSource)(False)

        ' check given table in list of all datasources
        Return dataSources.IndexOf(table) <> -1
    End Function

    Private Function IsQueryColumnListItemPresentInQuery(ByVal unionSubQuery As UnionSubQuery, ByVal item As QueryColumnListItem) As Boolean
        Return unionSubQuery.QueryColumnList.IndexOf(item) <> -1 AndAlso Not String.IsNullOrEmpty(item.ExpressionString)
    End Function

    Private Sub ClearConditionCells(ByVal unionSubQuery As UnionSubQuery, ByVal item As QueryColumnListItem)
        For i As Integer = 0 To unionSubQuery.QueryColumnList.GetMaxConditionCount() - 1
            item.ConditionStrings(i) = ""
        Next i
    End Sub

    Private Function AddTable(ByVal unionSubQuery As UnionSubQuery, ByVal name As String, ByVal [alias] As String) As DataSource
        Using parsedName = queryBuilder1.SQLContext.ParseQualifiedName(name)
            Using parsedAlias = queryBuilder1.SQLContext.ParseIdentifier([alias])
                Return queryBuilder1.QueryView.Query.AddObject(unionSubQuery, parsedName, parsedAlias)
            End Using
        End Using
    End Function

    Private Function FindTableInQueryByName(ByVal unionSubQuery As UnionSubQuery, ByVal name As String) As DataSource
        Dim foundDatasources As List(Of DataSourceObject)
        Using qualifiedName = queryBuilder1.SQLContext.ParseQualifiedName(name)
            foundDatasources = New List(Of DataSourceObject)()
            unionSubQuery.FromClause.FindTablesByDbName(qualifiedName, foundDatasources)
        End Using

        ' if found more than one tables with given name in the query, use the first one
        Return If(foundDatasources.Count > 0, foundDatasources(0), Nothing)
    End Function

    Private Sub AddWhereCondition(ByVal columnList As QueryColumnList, ByVal whereListItem As QueryColumnListItem, ByVal condition As String)
        Dim whereFound As Boolean = False

        ' GetMaxConditionCount: returns the number of non-empty criteria columns in the grid.
        For i As Integer = 0 To columnList.GetMaxConditionCount() - 1
            ' CollectCriteriaItemsWithWhereCondition:
            ' This function returns the list of conditions that were found in
            ' the i-th criteria column, applied to specific clause (WHERE or HAVING).
            ' Thus, this function collects all conditions joined with AND
            ' within one OR group (one grid column).
            Dim foundColumnItems As New List(Of QueryColumnListItem)()
            CollectCriteriaItemsWithWhereCondition(columnList, i, foundColumnItems)

            ' if found some conditions in i-th column, append condition to i-th column
            If foundColumnItems.Count > 0 Then
                whereListItem.ConditionStrings(i) = condition
                whereFound = True
            End If
        Next i

        ' if there are no cells with "where" conditions, add condition to new column
        If Not whereFound Then
            whereListItem.ConditionStrings(columnList.GetMaxConditionCount()) = condition
        End If
    End Sub

    Private Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApply.Click
        queryBuilder1.BeginUpdate()

        Try
            ' get the active SELECT

            Dim usq = queryBuilder1.ActiveUnionSubQuery

'				#Region "actualize stored references (if query is modified in GUI)"
'				#Region "actualize datasource references"
            ' if user removed previously added datasources then clear their references
            If _customers IsNot Nothing AndAlso (Not IsTablePresentInQuery(usq, _customers)) Then
                ' user removed this table in GUI
                _customers = Nothing
            End If

            If _orders IsNot Nothing AndAlso (Not IsTablePresentInQuery(usq, _orders)) Then
                ' user removed this table in GUI
                _orders = Nothing
            End If
'				#End Region

            ' clear CompanyName conditions
            If _companyName IsNot Nothing Then
                ' if user removed entire row OR cleared expression cell in GUI, clear the stored reference
                If Not IsQueryColumnListItemPresentInQuery(usq, _companyName) Then
                    _companyName = Nothing
                End If
            End If

            ' clear all condition cells for CompanyName row
            If _companyName IsNot Nothing Then
                ClearConditionCells(usq, _companyName)
            End If

            ' clear OrderDate conditions
            If _orderDate IsNot Nothing Then
                ' if user removed entire row OR cleared expression cell in GUI, clear the stored reference
                If Not IsQueryColumnListItemPresentInQuery(usq, _orderDate) Then
                    _orderDate = Nothing
                End If
            End If

            ' clear all condition cells for OrderDate row
            If _orderDate IsNot Nothing Then
                ClearConditionCells(usq, _orderDate)
            End If
'				#End Region

'				#Region "process Customers table"
            If cbCustomers.Checked Then
                ' if we have no previously added Customers table, try to find one already added by the user
                If _customers Is Nothing Then
                    _customers = FindTableInQueryByName(usq, CustomersName)
                End If

                ' there is no Customers table in query, add it
                If _customers Is Nothing Then
                    _customers = AddTable(usq, CustomersName, CustomersAlias)
                End If

'					#Region "process CompanyName condition"
                If cbCompanyName.Enabled AndAlso cbCompanyName.Checked AndAlso (Not String.IsNullOrEmpty(tbCompanyName.Text)) Then
                    ' if we have no previously added grid row for this condition, add it
                    If _companyName Is Nothing OrElse _companyName.IsDisposing Then
                        _companyName = usq.QueryColumnList.AddField(_customers, _companyNameFieldName.QualifiedName)
                        ' do not append it to the select list, use this row for conditions only
                        _companyName.Selected = False
                    End If

                    ' write condition from edit box to all needed grid cells
                    AddWhereCondition(usq.QueryColumnList, _companyName, tbCompanyName.Text)
                Else
                    ' remove previously added grid row
                    If _companyName IsNot Nothing Then
                        _companyName.Dispose()
                    End If

                    _companyName = Nothing
                End If
'					#End Region
            Else
                ' remove previously added datasource
                If _customers IsNot Nothing Then
                    _customers.Dispose()
                End If

                _customers = Nothing
            End If
'				#End Region

'				#Region "process Orders table"
            If cbOrders.Checked Then
                ' if we have no previosly added Orders table, try to find one already added by the user
                If _orders Is Nothing Then
                    _orders = FindTableInQueryByName(usq, OrdersName)
                End If

                ' there are no Orders table in query, add one
                If _orders Is Nothing Then
                    _orders = AddTable(usq, OrdersName, OrdersAlias)
                End If

'					#Region "link between Orders and Customers"
                ' we added Orders table,
                ' check if we have Customers table too,
                ' and if there are no joins between them, create such join
                Dim joinFieldNameStr As String = _joinFieldName.QualifiedName
                If _customers IsNot Nothing AndAlso usq.FromClause.FindLink(_orders, joinFieldNameStr, _customers, joinFieldNameStr) Is Nothing AndAlso usq.FromClause.FindLink(_customers, joinFieldNameStr, _orders, joinFieldNameStr) Is Nothing Then
                    queryBuilder1.QueryView.Query.AddLink(_customers, _joinFieldName, _orders, _joinFieldName)
                End If
'					#End Region

'					#Region "process OrderDate condition"
                If cbOrderDate.Enabled AndAlso cbOrderDate.Checked AndAlso (Not String.IsNullOrEmpty(tbOrderDate.Text)) Then
                    ' if we have no previously added grid row for this condition, add it
                    If _orderDate Is Nothing Then
                        _orderDate = usq.QueryColumnList.AddField(_orders, _orderDateFieldName.QualifiedName)
                        ' do not append it to the select list, use this row for conditions only
                        _orderDate.Selected = False
                    End If

                    ' write condition from edit box to all needed grid cells
                    AddWhereCondition(usq.QueryColumnList, _orderDate, tbOrderDate.Text)
                Else
                    ' remove prviously added grid row
                    If _orderDate IsNot Nothing Then
                        _orderDate.Dispose()
                    End If

                    _orderDate = Nothing
                End If
'					#End Region
            Else
                If _orders IsNot Nothing Then
                    _orders.Dispose()
                    _orders = Nothing
                End If
            End If
'				#End Region
        Finally
            queryBuilder1.EndUpdate()
        End Try
    End Sub

    Private Sub CollectCriteriaItemsWithWhereCondition(ByVal criteriaList As QueryColumnList, ByVal columnIndex As Integer, ByVal result As IList(Of QueryColumnListItem))
        result.Clear()

        For Each item In criteriaList
            If item.ConditionType = ConditionType.Where AndAlso item.ConditionCount > columnIndex AndAlso item.GetASTCondition(columnIndex) IsNot Nothing Then
                result.Add(item)
            End If
        Next item
    End Sub

    Private Sub btnQueryCustomers_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQueryCustomers.Click
        queryBuilder1.SQL = "select * from Northwind.dbo.Customers c"
    End Sub

    Private Sub btnQueryOrders_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQueryOrders.Click
        queryBuilder1.SQL = "select * from Northwind.dbo.Orders o"
    End Sub

    Private Sub btnQueryCustomersOrders_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQueryCustomersOrders.Click
        queryBuilder1.SQL = "select * from Northwind.dbo.Customers c, Northwind.dbo.Orders o"
    End Sub

    Private Sub cbCompanyName_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbCompanyName.CheckedChanged
        tbCompanyName.Enabled = cbCompanyName.Checked
    End Sub

    Private Sub cbCustomers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbCustomers.CheckedChanged
        cbCompanyName.Enabled = cbCustomers.Checked
        tbCompanyName.Enabled = (cbCompanyName.Checked AndAlso cbCustomers.Checked)
    End Sub

    Private Sub cbOrderDate_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbOrderDate.CheckedChanged
        tbOrderDate.Enabled = cbOrderDate.Checked
    End Sub

    Private Sub cbOrders_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbOrders.CheckedChanged
        cbOrderDate.Enabled = cbOrders.Checked
        tbOrderDate.Enabled = cbOrderDate.Checked AndAlso cbOrders.Checked
    End Sub

    Private Sub tbSQL_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tbSQL.Validating
        Try
            ' Update the query builder with manually edited query text:
            queryBuilder1.SQL = tbSQL.Text

            ' Hide error banner if any
            ShowErrorBanner(tbSQL, "")
        Catch ex As SQLParsingException
            ' Set caret to error position
            tbSQL.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            ShowErrorBanner(tbSQL, ex.Message)
        End Try
    End Sub

    Private Sub SqlUpdated(ByVal sender As Object, ByVal e As EventArgs)
        ' query text in the Query Builder has been updated

        ' Hide error banner if any
        ShowErrorBanner(tbSQL, "")

        tbSQL.Text = queryBuilder1.FormattedSQL
    End Sub

    Public Sub ShowErrorBanner(ByVal control As Control, ByVal text As String)
        ' Destory banner if already showing
        Dim existBanner As Boolean = False
        Dim banners() As Control = control.Controls.Find("ErrorBanner", True)

        If banners.Length > 0 Then
            For Each banner As Control In banners
                If Equals(text, banner.Text) Then
                    existBanner = True
                    Continue For
                End If
                banner.Dispose()
            Next banner
        End If

        If existBanner Then
            Return
        End If

        ' Show new banner if text is not empty
        If Not String.IsNullOrEmpty(text) Then
            Dim label As Label = New Label With {.Name = "ErrorBanner", .Text = text, .BorderStyle = BorderStyle.FixedSingle, .BackColor = Color.LightPink, .AutoSize = True, .Visible = True}

            control.Controls.Add(label)
            label.Location = New Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2)
            label.BringToFront()

            control.Focus()
        End If
    End Sub
End Class
