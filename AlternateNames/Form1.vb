'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

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
		' set required syntax provider
		queryBuilder1.SyntaxProvider = New DB2SyntaxProvider()

		Try
			' Load demo metadata from XML file
			queryBuilder1.MetadataLoadingOptions.OfflineMode = True
			queryBuilder1.MetadataContainer.ImportFromXML("db2_sample_with_alt_names.xml")
			queryBuilder1.InitializeDatabaseSchemaTree()

			' set example query text
			queryBuilder1.SQL = "Select DEPARTMENT.DEPTNO, DEPARTMENT.DEPTNAME, DEPARTMENT.MGRNO From DEPARTMENT"
		Catch ex As QueryBuilderException
			MessageBox.Show(ex.Message)
		End Try

		MyBase.OnLoad(e)
	End Sub

	Private Sub queryBuilder_SQLUpdated(sender As Object, e As EventArgs)
		' Text of SQL query has been updated.

		' To get the formatted query text with alternate object names just use FormattedSQL property
		textBox1.Text = queryBuilder1.FormattedSQL

		' To get the query text, ready for execution on SQL server with real object names just use SQL property.
		textBox2.Text = queryBuilder1.SQL

		' The query text containing in SQL property is unformatted. If you need the formatted text, but with real object names, 
		' do the following:
		'			SQLFormattingOptions formattingOptions = new SQLFormattingOptions();
		'			formattingOptions.Assign(queryBuilder1.SQLFormattingOptions); // copy actual formatting options from the QueryBuilder
		'			formattingOptions.UseAltNames = false; // disable alt names
		'			textBox2.Text = FormattedSQLBuilder.GetSQL(queryBuilder1.SQLQuery.QueryRoot, formattingOptions);
	End Sub

	Private Sub textBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
		Try
			' Update the query builder with manually edited query text:
			queryBuilder1.SQL = textBox1.Text

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
			queryBuilder1.SQL = textBox2.Text

			' Hide error banner if any
			ShowErrorBanner(textBox2, "")
		Catch ex As SQLParsingException
			' Set caret to error position
			textBox2.SelectionStart = ex.ErrorPos.pos

			' Show banner with error text
			ShowErrorBanner(textBox2, ex.Message)
		End Try
	End Sub

	Private Sub editMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs)
		' Open the metadata container editor
		QueryBuilder.EditMetadataContainer(queryBuilder1.MetadataContainer, queryBuilder1.MetadataStructure, queryBuilder1.MetadataLoadingOptions)
	End Sub

	Private Sub aboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
		QueryBuilder.ShowAboutDialog()
	End Sub

	Public Sub ShowErrorBanner(control As Control, text As [String])
		' Destory banner if already showing
		If True Then
			Dim banners As Control() = control.Controls.Find("ErrorBanner", True)

			If banners.Length > 0 Then
				For Each banner As Control In banners
					banner.Dispose()
				Next
			End If
		End If

		' Show new banner if text is not empty
		If Not [String].IsNullOrEmpty(text) Then
			Dim label As New Label() With { _
				.Name = "ErrorBanner", _
				.Text = text, _
				.BorderStyle = BorderStyle.FixedSingle, _
				.BackColor = Color.LightPink, _
				.AutoSize = True, _
				.Visible = True _
			}

			control.Controls.Add(label)
			label.Location = New Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2)
			label.BringToFront()
			control.Focus()
		End If
	End Sub
End Class
