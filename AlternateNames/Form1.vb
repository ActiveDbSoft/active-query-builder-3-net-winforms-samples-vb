'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
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
    Private _lastValidSql As String
    Private _errorPosition As Integer = -1
    Private _lastValidSqlReal As String
    Private _errorPositionReal As Integer = -1

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

	Private Sub queryBuilder_SQLUpdated(sender As Object, e As EventArgs) Handles queryBuilder1.SQLUpdated, queryBuilder1.Click
		' Text of SQL query has been updated.

		' To get the formatted query text with alternate object names just use FormattedSQL property
		textBox1.Text = queryBuilder1.FormattedSQL
	    ErrorBox1.Show(Nothing, queryBuilder1.SyntaxProvider)
        _lastValidSql = queryBuilder1.FormattedSQL

		' To get the query text, ready for execution on SQL server with real object names just use SQL property.
		textBox2.Text = queryBuilder1.SQL
	    ErrorBoxReal.Show(Nothing, queryBuilder1.SyntaxProvider)
	    _lastValidSqlReal = queryBuilder1.SQL
		' The query text containing in SQL property is unformatted. If you need the formatted text, but with real object names, 
		' do the following:
		'			SQLFormattingOptions formattingOptions = new SQLFormattingOptions();
		'			formattingOptions.Assign(queryBuilder1.SQLFormattingOptions); // copy actual formatting options from the QueryBuilder
		'			formattingOptions.UseAltNames = false; // disable alt names
		'			textBox2.Text = FormattedSQLBuilder.GetSQL(queryBuilder1.SQLQuery.QueryRoot, formattingOptions);
	End Sub

	Private Sub textBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles textBox1.Validating
		Try
			' Update the query builder with manually edited query text:
			queryBuilder1.SQL = textBox1.Text

			' Hide error banner if any
			ErrorBox1.Show(Nothing, queryBuilder1.SyntaxProvider)
		Catch ex As SQLParsingException
			' Set caret to error position
			textBox1.SelectionStart = ex.ErrorPos.pos

			' Show banner with error text
		    ErrorBox1.Show(ex.Message, queryBuilder1.SyntaxProvider)
            _errorPosition = ex.ErrorPos.pos
		End Try
	End Sub

	Private Sub textBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles textBox2.Validating
		Try
			' Update the query builder with manually edited query text:
			queryBuilder1.SQL = textBox2.Text

			' Hide error banner if any
		    ErrorBoxReal.Show(Nothing, queryBuilder1.SyntaxProvider)
		Catch ex As SQLParsingException
			' Set caret to error position
			textBox2.SelectionStart = ex.ErrorPos.pos

			' Show banner with error text
		    ErrorBoxReal.Show(ex.Message, queryBuilder1.SyntaxProvider)
            _errorPositionReal = ex.ErrorPos.pos
		End Try
	End Sub

	Private Sub editMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles editMetadataToolStripMenuItem.Click
		' Open the metadata container editor
		QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext)
	End Sub

	Private Sub aboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles aboutToolStripMenuItem.Click
		QueryBuilder.ShowAboutDialog()
	End Sub


    Private Sub ErrorBox1_GoToErrorPosition(sender As Object, e As EventArgs) Handles ErrorBox1.GoToErrorPosition
        If _errorPosition <> -1 Then
            textBox1.SelectionStart = _errorPosition
            textBox1.SelectionLength = 0
            textBox1.ScrollToCaret()
        End If

        ErrorBox1.Visible = False
        textBox1.Focus()
    End Sub

    Private Sub ErrorBox1_RevertValidText(sender As Object, e As EventArgs) Handles ErrorBox1.RevertValidText
        textBox1.Text = _lastValidSql
        textBox1.Focus()
    End Sub

    Private Sub ErrorBoxReal_GoToErrorPosition(sender As Object, e As EventArgs) Handles ErrorBoxReal.GoToErrorPosition
        If _errorPosition <> -1 Then
            textBox2.SelectionStart = _errorPositionReal
            textBox2.SelectionLength = 0
            textBox2.ScrollToCaret()
        End If

        ErrorBoxReal.Visible = False
        textBox2.Focus()
    End Sub

    Private Sub ErrorBoxReal_RevertValidText(sender As Object, e As EventArgs) Handles ErrorBoxReal.RevertValidText
        textBox2.Text = _lastValidSqlReal
        textBox2.Focus()
    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged
        ErrorBox1.Visible = False
    End Sub

    Private Sub textBox2_TextChanged(sender As Object, e As EventArgs) Handles textBox2.TextChanged
        ErrorBoxReal.Visible = False
    End Sub
End Class
