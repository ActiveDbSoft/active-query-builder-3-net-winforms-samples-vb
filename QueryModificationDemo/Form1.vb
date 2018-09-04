'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core

Partial Public Class Form1
    Inherits Form

    Private Const CustomersName as String = "Northwind.dbo.Customers"
    Private Const OrdersName as String = "Northwind.dbo.Orders"
    Private Const CustomersAlias As String = "c"
    private const OrdersAlias As String = "o"
    private const CustomersCompanyName As String = "CompanyName"
    private const CusomerId As String = "CustomerId"
    private const OrderDate As String = "OrderDate"

    Private _joinFieldName As SQLQualifiedName
    Private _companyNameFieldName As SQLQualifiedName
    Private _orderDateFieldName As SQLQualifiedName

    Private _customers As DataSource
    Private _orders As DataSource
    Private _companyName As QueryColumnListItem
    Private _orderDate As QueryColumnListItem

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)

        ' load metadata from XML file located in resource (for demonstration purposes)
        QueryBuilder1.MetadataContainer.LoadingOptions.OfflineMode = True
        QueryBuilder1.MetadataContainer.ImportFromXML("Northwind.xml")
        QueryBuilder1.InitializeDatabaseSchemaTree()
        '  AddHandler QueryBuilder1.SQLUpdated, SQLUpdated
        ' prepare parsed names
        _joinFieldName = QueryBuilder1.SQLContext.ParseQualifiedName(CusomerId)
        _companyNameFieldName = QueryBuilder1.SQLContext.ParseQualifiedName(CustomersCompanyName)
        _orderDateFieldName = QueryBuilder1.SQLContext.ParseQualifiedName(OrderDate)

        MyBase.OnLoad(e)
    End Sub

    Private Function IsTablePresentInQuery(unionSubQuery As UnionSubQuery, table As DataSource) As Boolean
        ' collect the list of datasources used in FROM
        Dim dataSources As New List(Of DataSource)()
        unionSubQuery.FromClause.GetDatasources(dataSources)

        ' check given table in list of all datasources
        Return dataSources.IndexOf(table) <> -1
    End Function

    Private Function IsQueryColumnListItemPresentInQuery(unionSubQuery As UnionSubQuery, item As QueryColumnListItem) As Boolean
        Return unionSubQuery.QueryColumnList.IndexOf(item) <> -1 And Not [String].IsNullOrEmpty(item.ExpressionString)
    End Function

    Private Function AddTable(unionSubQuery As UnionSubQuery, tableName As String, tableAlias As String) As DataSource
        Dim parsedName As SQLQualifiedName = QueryBuilder1.SQLContext.ParseQualifiedName(tableName)
        Dim parsedAlias As AstTokenIdentifier = QueryBuilder1.SQLContext.ParseIdentifier(tableAlias)

        Return queryBuilder1.QueryView.Query.AddObject(unionSubQuery, parsedName, parsedAlias)
    End Function

    Private Sub ClearConditionCells(unionSubQuery As UnionSubQuery, item As QueryColumnListItem)
        For i As Integer = 0 To unionSubQuery.QueryColumnList.GetMaxConditionCount() - 1
            item.ConditionStrings(i) = ""
        Next
    End Sub

    Private Function FindTableInQueryByName(unionSubQuery As UnionSubQuery, strName As String) As DataSource
        Dim foundDatasources As New List(Of DataSourceObject)()
        Dim parsedName As SQLQualifiedName = QueryBuilder1.SQLContext.ParseQualifiedName(strName)
        unionSubQuery.FromClause.FindTablesByDbName(parsedName, foundDatasources)

        ' if found more than one tables with given name in the query, use the first one
        Return If(foundDatasources.Count > 0, foundDatasources(0), Nothing)
    End Function

    Private Sub AddWhereCondition(columnList As QueryColumnList, whereListItem As QueryColumnListItem, condition As String)
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
        Next

        ' if there are no cells with "where" conditions, add condition to new column
        If Not whereFound Then
            whereListItem.ConditionStrings(columnList.GetMaxConditionCount()) = condition
        End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        QueryBuilder1.BeginUpdate()

        Try
            ' get the active SELECT
            Dim usq As UnionSubQuery = QueryBuilder1.ActiveUnionSubQuery

            '#Region "actualize stored references (if query is modified in GUI)"
            '#Region "actualize datasource references"
            ' if user removed previously added datasources then clear their references
            If _customers IsNot Nothing AndAlso Not IsTablePresentInQuery(usq, _customers) Then
                ' user removed this table in GUI
                _customers = Nothing
            End If

            If _orders IsNot Nothing AndAlso Not IsTablePresentInQuery(usq, _orders) Then
                ' user removed this table in GUI
                _orders = Nothing
            End If
            '#End Region

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
            '#End Region

            '#Region "process Customers table"
            If cbCustomers.Checked Then
                ' if we have no previously added Customers table, try to find one already added by the user
                If _customers Is Nothing Then
                    _customers = FindTableInQueryByName(usq, CustomersName)
                End If

                ' there is no Customers table in query, add it
                If _customers Is Nothing Then
                    _customers = AddTable(usq, CustomersName, CustomersAlias)
                End If

                '#Region "process CompanyName condition"
                If cbCompanyName.Enabled AndAlso cbCompanyName.Checked AndAlso Not [String].IsNullOrEmpty(tbCompanyName.Text) Then
                    ' if we have no previously added grid row for this condition, add it
                    If _companyName Is Nothing Then
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
                    '#End Region
                End If
            Else
                ' remove previously added datasource
                If _customers IsNot Nothing Then
                    _customers.Dispose()
                End If

                _customers = Nothing
            End If
            '#End Region

            '#Region "process Orders table"
            If cbOrders.Checked Then
                ' if we have no previosly added Orders table, try to find one already added by the user
                If _orders Is Nothing Then
                    _orders = FindTableInQueryByName(usq, OrdersName)
                End If

                ' there are no Orders table in query, add one
                If _orders Is Nothing Then
                    _orders = AddTable(usq, OrdersName, OrdersAlias)
                End If

                '#Region "link between Orders and Customers"
                ' we added Orders table,
                ' check if we have Customers table too,
                ' and if there are no joins between them, create such join
                Dim joinFieldNameStr As String = _joinFieldName.QualifiedName
                If _customers IsNot Nothing AndAlso usq.FromClause.FindLink(_orders, joinFieldNameStr, _customers, joinFieldNameStr) Is Nothing AndAlso usq.FromClause.FindLink(_customers, joinFieldNameStr, _orders, joinFieldNameStr) Is Nothing Then
                    QueryBuilder1.QueryView.Query.AddLink(_customers, _joinFieldName, _orders, _joinFieldName)
                End If
                '#End Region

                '#Region "process OrderDate condition"
                If cbOrderDate.Enabled AndAlso cbOrderDate.Checked AndAlso Not [String].IsNullOrEmpty(tbOrderDate.Text) Then
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
                    '#End Region
                End If
            Else
                If _orders IsNot Nothing Then
                    _orders.Dispose()
                    _orders = Nothing
                End If
                '#End Region
            End If
        Finally
            QueryBuilder1.EndUpdate()
        End Try
    End Sub

    Private Sub CollectCriteriaItemsWithWhereCondition(criteriaList As QueryColumnList, columnIndex As Integer, result As IList(Of QueryColumnListItem))
        result.Clear()

        For i As Integer = 0 To criteriaList.Count - 1
            If criteriaList(i).ConditionType = ConditionType.Where AndAlso criteriaList(i).ConditionCount > columnIndex AndAlso criteriaList(i).GetASTCondition(columnIndex) IsNot Nothing Then
                result.Add(criteriaList(i))
            End If
        Next
    End Sub

    Private Sub btnQueryCustomers_Click(sender As Object, e As EventArgs) Handles btnQueryCustomers.Click
        QueryBuilder1.SQL = "select * from Northwind.dbo.Customers c"
    End Sub

    Private Sub btnQueryOrders_Click(sender As Object, e As EventArgs) Handles btnQueryOrders.Click
        QueryBuilder1.SQL = "select * from Northwind.dbo.Orders o"
    End Sub

    Private Sub btnQueryCustomersOrders_Click(sender As Object, e As EventArgs) Handles btnQueryCustomersOrders.Click
        QueryBuilder1.SQL = "select * from Northwind.dbo.Customers c, Northwind.dbo.Orders o"
    End Sub

    Private Sub cbCompanyName_CheckedChanged(sender As Object, e As EventArgs) Handles cbCompanyName.CheckedChanged
        tbCompanyName.Enabled = cbCompanyName.Checked
    End Sub

    Private Sub cbCustomers_CheckedChanged(sender As Object, e As EventArgs) Handles cbCustomers.CheckedChanged
        cbCompanyName.Enabled = cbCustomers.Checked
        tbCompanyName.Enabled = (cbCompanyName.Checked AndAlso cbCustomers.Checked)
    End Sub

    Private Sub cbOrderDate_CheckedChanged(sender As Object, e As EventArgs) Handles cbOrderDate.CheckedChanged
        tbOrderDate.Enabled = cbOrderDate.Checked
    End Sub

    Private Sub cbOrders_CheckedChanged(sender As Object, e As EventArgs) Handles cbOrders.CheckedChanged
        cbOrderDate.Enabled = cbOrders.Checked
        tbOrderDate.Enabled = (cbOrderDate.Checked AndAlso cbOrders.Checked)
    End Sub

    Private Sub tbSQL_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbSQL.Validating
        Try
            ' Update the query builder with manually edited query text:
            QueryBuilder1.SQL = tbSQL.Text

            ' Hide error banner if any
            ShowErrorBanner(tbSQL, "")
        Catch ex As SQLParsingException
            ' Set caret to error position
            tbSQL.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            ShowErrorBanner(tbSQL, ex.Message)
        End Try
    End Sub

    Private Sub QueryBuilder1_SQLUpdated(sender As Object, e As EventArgs) Handles QueryBuilder1.SQLUpdated
        ' query text in the Query Builder has been updated

        ' Hide error banner if any
        ShowErrorBanner(tbSQL, "")

        tbSQL.Text = New FormattedSQLBuilder(New SQLFormattingOptions()).GetSQL(QueryBuilder1.QueryView.Query.QueryRoot)
    End Sub

    Public Sub ShowErrorBanner(ByVal control As Control, ByVal text As String)
		' Display error banner if passed text is not empty
        ' Destory banner if already showing
		If True Then
			Dim existBanner As Boolean = False
			Dim banners As Control() = control.Controls.Find("ErrorBanner", True)

			If banners.Length > 0 Then

				For Each banner As Control In banners

					If Equals(text, banner.Text) Then
						existBanner = True
						Continue For
					End If

					banner.Dispose()
				Next
			End If

			If existBanner Then Return
		End If

		' Show new banner if text is not empty
		If Not String.IsNullOrEmpty(text) Then
			Dim label As Label = New Label With {
				.Name = "ErrorBanner",
				.Text = text,
				.BorderStyle = BorderStyle.FixedSingle,
				.BackColor = Color.LightPink,
				.AutoSize = True,
				.Visible = True
			}
			control.Controls.Add(label)
			label.Location = New Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2)
			label.BringToFront()
			control.Focus()
		End If
	End Sub
End Class
