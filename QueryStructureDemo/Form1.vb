'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Text
Imports ActiveQueryBuilder.Core


Partial Public Class Form1
    Inherits Form
    Private Const CSampleSelect As String = "Select 1 as cid, Upper('2'), 3, 4 + 1, 5 + 2 IntExpression "

    Private Const CSampleSelectFromWhere As String = "Select c.CustomerId as cid, c.CompanyName, Upper(c.CompanyName), o.OrderId " & "From Customers c Inner Join Orders o On c.CustomerID = o.CustomerID Where o.OrderId > 0 and c.CustomerId < 10"

    Private Const CSampleSelectFromJoin As String = "Select c.CustomerId as cid, Upper(c.CompanyName), o.OrderId, " & " p.ProductName + 1, 2+2 IntExpression From Customers c Inner Join " & "Orders o On c.CustomerID = o.CustomerID Inner Join " & "[Order Details] od On o.OrderID = od.OrderID Inner Join " & "Products p On p.ProductID = od.ProductID "

    Private Const CSampleSelectFromJoinSubqueries As String = "Select c.CustomerId as cid, Upper(c.CompanyName), o.OrderId, " & "p.ProductName + 1, 2+2 IntExpression From Customers c Inner Join " & "Orders o On c.CustomerID = o.CustomerID Inner Join " & "[Order Details] od On o.OrderID = od.OrderID Inner Join " & "(select pr.ProductId, pr.ProductName from Products pr) p On p.ProductID = od.ProductID "

    Private Const CSampleUnions As String = "Select c.CustomerId as cid, Upper(c.CompanyName), o.OrderId, " & "p.ProductName + 1, 2+2 IntExpression From Customers c Inner Join " & "Orders o On c.CustomerID = o.CustomerID Inner Join " & "[Order Details] od On o.OrderID = od.OrderID Inner Join " & "(select pr.ProductId, pr.ProductName from Products pr) p " & "On p.ProductID = od.ProductID union all " & "(select 1,2,3,4,5 union all select 6,7,8,9,0) union all " & "select (select Null as ""Null"") as EmptyValue, " & "SecondColumn = 2, Lower('ThirdColumn') as ThirdColumn, 0 as ""Quoted Alias"", 2+2*2 "

    Public Sub New()
        InitializeComponent()

        ' set required syntax provider
        queryBuilder.SyntaxProvider = New MSSQLSyntaxProvider()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        ' Load sample database metadata from XML file
        Try
            queryBuilder.MetadataLoadingOptions.OfflineMode = True
            queryBuilder.MetadataContainer.ImportFromXML("Northwind.xml")
            queryBuilder.InitializeDatabaseSchemaTree()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ' load sample query
        queryBuilder.SQL = CSampleSelectFromWhere

        MyBase.OnLoad(e)
    End Sub

    Private Sub queryBuilder_SQLUpdated(sender As Object, e As EventArgs) Handles queryBuilder.SQLUpdated
        ' Hide error banner if any
        ShowErrorBanner(tbSQL, "")

        ' QueryBuilder generates new SQL query text. Show it to user.
        tbSQL.Text = queryBuilder.FormattedSQL

        ' update info for entire query
        UpdateQueryInfo()
    End Sub

    Private Sub btnSampleSelect_Click(sender As Object, e As EventArgs) Handles btnSampleSelect.Click
        queryBuilder.SQL = CSampleSelect
    End Sub

    Private Sub btnSampleSelectFromWhere_Click(sender As Object, e As EventArgs) Handles btnSampleSelectFromWhere.Click
        queryBuilder.SQL = CSampleSelectFromWhere
    End Sub

    Private Sub btnSampleSelectFromJoin_Click(sender As Object, e As EventArgs) Handles btnSampleSelectFromJoin.Click
        queryBuilder.SQL = CSampleSelectFromJoin
    End Sub

    Private Sub btnSampleSelectFromJoinSubqueries_Click(sender As Object, e As EventArgs) Handles btnSampleSelectFromJoinSubqueries.Click
        queryBuilder.SQL = CSampleSelectFromJoinSubqueries
    End Sub

    Private Sub btnSampleUnions_Click(sender As Object, e As EventArgs) Handles btnSampleUnions.Click
        queryBuilder.SQL = CSampleUnions
    End Sub

    Private Sub btnShowUnlinkedDatasourcesButton_Click(sender As Object, e As EventArgs) Handles btnShowUnlinkedDatasourcesButton.Click
        ' get active UnionSubQuery
        Dim unionSubQuery = queryBuilder.ActiveUnionSubQuery.ParentUnionSubQuery

        ' analize links and datasources
        Dim unlinkedDatasourcesInfo = GetUnlinkedDataSourcesFromUnionSubQuery(unionSubQuery)

        MessageBox.Show(unlinkedDatasourcesInfo)
    End Sub

    Private Sub queryBuilder_ActiveUnionSubQueryChanged(sender As Object, e As EventArgs) Handles queryBuilder.ActiveUnionSubQueryChanged
        If queryBuilder.ActiveUnionSubQuery Is Nothing Then
            Return
        End If
        ' update Query Structure information
        UpdateSubQueryStructureInfo()

        ' update DataSources information
        UpdateDataSourcesInfo()

        ' update Links information
        UpdateLinksInfo()

        ' and update Selected expressions information
        UpdateSelectedExpressionsInfo()
    End Sub

    Private Sub UpdateDataSourcesInfo()
        Dim unionSubQuery As UnionSubQuery = queryBuilder.ActiveUnionSubQuery
        Dim stringBuilder As New StringBuilder()

        DumpDataSourcesInfoFromUnionSubQuery(stringBuilder, unionSubQuery)

        tbDataSources.Text = stringBuilder.ToString()
    End Sub

    Private Sub UpdateLinksInfo()
        Dim unionSubQuery As UnionSubQuery = queryBuilder.ActiveUnionSubQuery
        Dim stringBuilder As New StringBuilder()

        DumpLinksInfoFromUnionSubQuery(stringBuilder, unionSubQuery)

        tbLinks.Text = stringBuilder.ToString()
    End Sub

    Private Sub UpdateQueryInfo()
        ' update Query Structure information
        UpdateQueryStatisticsInfo()

        ' and update SubQueries list
        UpdateQuerySubQueriesInfo()

        ' and update information for current SubQuery/UnionSubQuery
        UpdateSubQueryInfo()
    End Sub

    Private Sub UpdateQueryStatisticsInfo()
        Dim statistics As QueryStatistics = queryBuilder.QueryStatistics
        Dim stringBuilder As New StringBuilder()

        DumpQueryStatisticsInfo(stringBuilder, statistics)

        tbStatistics.Text = stringBuilder.ToString()
    End Sub

    Private Sub UpdateQuerySubQueriesInfo()
        Dim stringBuilder As New StringBuilder()

        DumpSubQueriesInfo(stringBuilder, queryBuilder)

        tbSubQueries.Text = stringBuilder.ToString()
    End Sub

    Private Sub UpdateSubQueryStructureInfo()
        Dim subQuery As SubQuery = queryBuilder.ActiveUnionSubQuery.ParentSubQuery
        Dim stringBuilder As New StringBuilder()

        DumpQueryStructureInfo(stringBuilder, subQuery)

        tbSubQueryStructure.Text = stringBuilder.ToString()
    End Sub

    Private Sub UpdateWhereInfo()
        Dim unionSubQuery As UnionSubQuery = queryBuilder.ActiveUnionSubQuery
        Dim stringBuilder As New StringBuilder()

        Dim unionSubQueryAst As SQLSubQuerySelectExpression = unionSubQuery.ResultQueryAST

        Try
            If unionSubQueryAst.Where IsNot Nothing Then
                DumpWhereInfo(stringBuilder, unionSubQueryAst.Where)
            End If
        Finally
            unionSubQueryAst.Dispose()
        End Try

        tbWhere.Text = stringBuilder.ToString()
    End Sub

    Private Sub UpdateSelectedExpressionsInfo()
        Dim unionSubQuery As UnionSubQuery = queryBuilder.ActiveUnionSubQuery
        Dim stringBuilder As New StringBuilder()

        DumpSelectedExpressionsInfoFromUnionSubQuery(stringBuilder, unionSubQuery)

        tbSelectedExpressions.Text = stringBuilder.ToString()
    End Sub

    Private Sub UpdateSubQueryInfo()
        ' update Query Structure information
        UpdateSubQueryStructureInfo()

        ' update DataSources information
        UpdateDataSourcesInfo()

        ' update Links information
        UpdateLinksInfo()

        ' update Selected Expressions information
        UpdateSelectedExpressionsInfo()

        ' and update WHERE clause information
        UpdateWhereInfo()
    End Sub

    Private Sub tbSQL_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbSQL.Validating
        Try
            ' Update the query builder with manually edited query text:
            queryBuilder.SQL = tbSQL.Text

            ' Hide error banner if any
            ShowErrorBanner(tbSQL, "")
        Catch ex As SQLParsingException
            ' Set caret to error position
            tbSQL.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            ShowErrorBanner(tbSQL, ex.Message)
        End Try
    End Sub

    Public Sub ShowErrorBanner(control As Control, text As String)
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
