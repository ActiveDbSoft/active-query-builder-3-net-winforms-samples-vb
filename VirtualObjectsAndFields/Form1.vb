//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms


Partial Public Class Form1
    Inherits Form
    Private _errorPosition As Integer = -1
    Private _lastValidSql As String

    Private _errorPositionReal As Integer = -1
    Private _lastValidSqlReal As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        ' Set required syntax provider
        queryBuilder.SyntaxProvider = New MSSQLSyntaxProvider()

        Try
            ' Load metadata from XML file (for demonstration purposes)
            queryBuilder.MetadataLoadingOptions.OfflineMode = True
            queryBuilder.MetadataContainer.ImportFromXML("Northwind.xml")

            ' ===========================================================================
            ' CREATE VIRTUAL DATABASE OBJECTS AND FIELDS
            ' ===========================================================================

            queryBuilder.MetadataContainer.BeginUpdate()

            Dim o As MetadataObject
            Dim f As MetadataField

            ' Virtual fields for real object
            ' ===========================================================================

            o = queryBuilder.MetadataContainer.FindItem(Of MetadataObject)("Orders")
            Debug.Assert(o IsNot Nothing)

            ' first test field - simple expression
            f = o.AddField("_OrderId_plus_1")
            f.Expression = "orders.OrderId + 1"

            ' second test field - correlated sub-query
            f = o.AddField("_CustomerName")
            f.Expression = "(select c.CompanyName from Customers c where c.CustomerId = orders.CustomerId)"

            ' Virtual object (table) with virtual fields
            ' ===========================================================================

            ' find parent "dbo" node 
            Dim dboSchemaNode As MetadataNamespace = queryBuilder.MetadataContainer.FindItem(Of MetadataNamespace)("dbo", MetadataType.Namespaces)

            o = dboSchemaNode.AddTable("Orders_tbl")
            o.Expression = "Orders"

            ' first test field - simple expression
            f = o.AddField("_tbl_OrderId_plus_1")
            f.Expression = "Orders_tbl.OrderId + 1"

            ' second test field - correlated sub-query
            f = o.AddField("_tbl_CustomerName")
            f.Expression = "(select c.CompanyName from Customers c where c.CustomerId = Orders_tbl.CustomerId)"

            ' Virtual object (sub-query) with virtual fields
            ' ===========================================================================

            o = dboSchemaNode.AddTable("Orders_qry")
            o.Expression = "(select OrderId, CustomerId, OrderDate from Orders) as dummy_alias"

            ' first test field - simple expression
            f = o.AddField("_qry_OrderId_plus_1")
            f.Expression = "Orders_qry.OrderId + 1"

            ' second test field - correlated sub-query
            f = o.AddField("_qry_CustomerName")
            f.Expression = "(select c.CompanyName from Customers c where c.CustomerId = Orders_qry.CustomerId)"

            ' kick queryBuilder to initialize its metadata tree
            queryBuilder.InitializeDatabaseSchemaTree()

            queryBuilder.SQL = "SELECT dummy_alias._qry_OrderId_plus_1, dummy_alias._qry_CustomerName FROM Orders_qry dummy_alias"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            queryBuilder.MetadataContainer.EndUpdate()
        End Try

        MyBase.OnLoad(e)
    End Sub

    Private Sub queryBuilder_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs) Handles queryBuilder.SQLUpdated
        ' Text of SQL query has been updated.

        ' Hide error banner if any
        errorBox1.Show(Nothing, queryBuilder.SyntaxProvider)
        errorBoxReal.Show(Nothing, queryBuilder.SyntaxProvider)

        ' has ExpandVirtualFields and ExpandVirtualObjects properties turned off.
        ' Set the text of the first text box to the query text containing virtual objects.
        textBox1.Text = sqlFormattingOptions1.GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot)
        _lastValidSql = textBox1.Text
        'new SQLFormattingOptions(new SQLGenerationOptions
        '{
        '    ExpandVirtualObjects = false,
        '    ExpandVirtualFields = false
        '}).GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot);
        ' has ExpandVirtualFields and ExpandVirtualObjects properties turned on.
        ' Set the text of the second text box to the query text containing virtual objects expanded to theirs expressions.
        textBox2.Text = sqlFormattingOptions2.GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot)
        _lastValidSqlReal = textBox2.Text
    End Sub

    Private Sub textBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textBox1.Validating
        Try
            ' Update the query builder with manually edited query text:
            queryBuilder.SQL = textBox1.Text

            ' Hide error banner if any
            errorBox1.Show(Nothing, queryBuilder.SyntaxProvider)
        Catch ex As SQLParsingException
            ' Set caret to error position
            textBox1.SelectionStart = ex.ErrorPos.pos
            _errorPosition = textBox1.SelectionStart

            ' Show banner with error text
            errorBox1.Show(ex.Message, queryBuilder.SyntaxProvider)
        End Try
    End Sub

    Private Sub textBox2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textBox2.Validating
        Try
            ' Update the query builder with manually edited query text:
            queryBuilder.SQL = textBox2.Text

            ' Hide error banner if any
            errorBoxReal.Show(Nothing, queryBuilder.SyntaxProvider)
        Catch ex As SQLParsingException
            ' Set caret to error position
            textBox2.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            errorBoxReal.Show(ex.Message, queryBuilder.SyntaxProvider)
        End Try
    End Sub

    Private Sub editMetadataToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles editMetadataToolStripMenuItem.Click
        ' Open the metadata container editor
        QueryBuilder.EditMetadataContainer(queryBuilder.SQLContext)
    End Sub

    Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutToolStripMenuItem.Click
        QueryBuilder.ShowAboutDialog()
    End Sub

    Private Sub ErrorBox1_GoToErrorPosition(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.GoToErrorPosition
        If _errorPosition <> -1 Then
            textBox1.SelectionStart = _errorPosition
            textBox1.SelectionLength = 0
            textBox1.ScrollToCaret()
        End If

        textBox1.Focus()
    End Sub

    Private Sub ErrorBox1_RevertValidText(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.RevertValidText
        textBox1.Text = _lastValidSql
        textBox1.Focus()
    End Sub

    Private Sub ErrorBoxReal_GoToErrorPosition(ByVal sender As Object, ByVal e As EventArgs) Handles errorBoxReal.GoToErrorPosition
        If _errorPositionReal <> -1 Then
            textBox2.SelectionStart = _errorPositionReal
            textBox2.SelectionLength = 0
            textBox2.ScrollToCaret()
        End If

        textBox2.Focus()
    End Sub

    Private Sub ErrorBoxReal_RevertValidText(ByVal sender As Object, ByVal e As EventArgs) Handles errorBoxReal.RevertValidText
        textBox2.Text = _lastValidSqlReal
        textBox2.Focus()
    End Sub
End Class
