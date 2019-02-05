'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Protected Overrides Sub OnLoad(e As EventArgs)
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

	Private Sub queryBuilder_SQLUpdated(sender As Object, e As EventArgs)
		' Text of SQL query has been updated.

		' Hide error banner if any
		ShowErrorBanner(textBox1, "")
		ShowErrorBanner(textBox2, "")

		' has ExpandVirtualFields and ExpandVirtualObjects properties turned off.
		' Set the text of the first text box to the query text containing virtual objects.
		textBox1.Text = sqlFormattingOptions1.GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot)
		'new SQLFormattingOptions(new SQLGenerationOptions
		'{
		'    ExpandVirtualObjects = false,
		'    ExpandVirtualFields = false
		'}).GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot);
		' has ExpandVirtualFields and ExpandVirtualObjects properties turned on.
		' Set the text of the second text box to the query text containing virtual objects expanded to theirs expressions.
		textBox2.Text = sqlFormattingOptions2.GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot)
	End Sub

	Private Sub textBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
		Try
			' Update the query builder with manually edited query text:
			queryBuilder.SQL = textBox1.Text

			' Hide error banner if any
			ShowErrorBanner(textBox1, "")
		Catch ex As SQLParsingException
			' Set caret to error position
			textBox1.SelectionStart = ex.ErrorPos.pos

			' Show banner with error text
			ShowErrorBanner(textBox1, ex.Message)
		End Try
	End Sub

	Private Sub textBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
		Try
			' Update the query builder with manually edited query text:
			queryBuilder.SQL = textBox2.Text

			' Hide error banner if any
			ShowErrorBanner(textBox2, "")
		Catch ex As SQLParsingException
			' Set caret to error position
			textBox1.SelectionStart = ex.ErrorPos.pos

			' Show banner with error text
			ShowErrorBanner(textBox2, ex.Message)
		End Try
	End Sub

	Private Sub editMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs)
		' Open the metadata container editor
		QueryBuilder.EditMetadataContainer(queryBuilder.SQLContext, queryBuilder.MetadataLoadingOptions)
	End Sub

	Private Sub aboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
		QueryBuilder.ShowAboutDialog()
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
