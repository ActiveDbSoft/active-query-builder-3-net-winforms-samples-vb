''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms


Partial Public Class Form1
    Inherits Form
    Private _lastValidText As String
    Private _lastValidTextReal As String
    Private _errorPosition As Integer = -1
    Private _errorPositionReal As Integer = -1
    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        ' set required syntax provider
        queryBuilder1.SyntaxProvider = New DB2SyntaxProvider()

        Try
            ' tune QueryBuilder to normalize tables/fields names mentioned in SQL queries
            ' when this setting is true QueryBuilder replaces all names to "canonical" names returned by the server's database schema
            ' when this setting is false QueryBuilder tries to preserve names as they are written in a query text
            ' to demonstrate AltNames feature turn this setting to true
            queryBuilder1.SQLFormattingOptions.ObjectNamesNormalization = True

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

    Private Sub queryBuilder_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs) Handles queryBuilder1.SQLUpdated
        ' Text of SQL query has been updated.

        ' To get the formatted query text with alternate object names just use FormattedSQL property
        textBox1.Text = queryBuilder1.FormattedSQL
        _lastValidText = textBox1.Text

        ' To get the query text, ready for execution on SQL server with real object names just use SQL property.
        textBox2.Text = queryBuilder1.SQL
        _lastValidTextReal = textBox2.Text

        ' The query text containing in SQL property is unformatted. If you need the formatted text, but with real object names, 
        ' do the following:
        '            SQLFormattingOptions formattingOptions = new SQLFormattingOptions();
        '            formattingOptions.Assign(queryBuilder1.SQLFormattingOptions); // copy actual formatting options from the QueryBuilder
        '            formattingOptions.UseAltNames = false; // disable alt names
        '            textBox2.Text = FormattedSQLBuilder.GetSQL(queryBuilder1.SQLQuery.QueryRoot, formattingOptions);
    End Sub

    Private Sub textBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textBox1.Validating
        Try
            ' Update the query builder with manually edited query text:
            queryBuilder1.SQL = textBox1.Text

            ' Hide error banner if any
            errorBox1.Show(Nothing, queryBuilder1.SyntaxProvider)
        Catch ex As SQLParsingException
            ' Set caret to error position
            textBox1.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            errorBox1.Show(ex.Message, queryBuilder1.SyntaxProvider)
            _errorPosition = ex.ErrorPos.pos
        End Try
    End Sub

    Private Sub textBox2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textBox2.Validating
        Try
            ' Update the query builder with manually edited query text:
            queryBuilder1.SQL = textBox2.Text

            ' Hide error banner if any
            errorBox2.Show(Nothing, queryBuilder1.SyntaxProvider)
        Catch ex As SQLParsingException
            ' Set caret to error position
            textBox2.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            errorBox2.Show(ex.Message, queryBuilder1.SyntaxProvider)
            _errorPositionReal = ex.ErrorPos.pos
        End Try
    End Sub

    Private Sub editMetadataToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles editMetadataToolStripMenuItem.Click
        ' Open the metadata container editor
        QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext)
    End Sub

    Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutToolStripMenuItem.Click
        QueryBuilder.ShowAboutDialog()
    End Sub

    Private Sub ErrorBox2_GoToErrorPosition(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox2.GoToErrorPosition
        If _errorPosition <> -1 Then
            textBox2.SelectionStart = _errorPositionReal
            textBox2.SelectionLength = 0
            textBox2.ScrollToCaret()
        End If

        textBox2.Focus()
    End Sub

    Private Sub ErrorBox2_RevertValidText(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox2.RevertValidText
        textBox2.Text = _lastValidTextReal
        textBox2.Focus()
    End Sub

    Private Sub ErrorBox1_GoToErrorPosition(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.GoToErrorPosition
        If _errorPosition <> -1 Then
            textBox1.SelectionStart = _errorPosition
            textBox1.SelectionLength = 0
            textBox1.ScrollToCaret()
        End If

        errorBox1.Visible = False
        textBox1.Focus()
    End Sub

    Private Sub ErrorBox1_RevertValidText(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.RevertValidText
        textBox1.Text = _lastValidText
        textBox1.Focus()
        errorBox1.Visible = False
    End Sub
End Class
