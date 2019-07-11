'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms
Imports iAnywhere.Data.SQLAnywhere


Public Partial Class Form1
	Inherits Form
    Dim _lastValidSql As String
    Dim _errorPosition As Integer

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub connectMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles connectMetadataToolStripMenuItem.Click
		' Connect to Sybase database

		' show the connection form
		Using f As New SybaseConnectionForm()
			If f.ShowDialog() = DialogResult.OK Then
				' create new SqlConnection object using the connections string from the connection form
				sybaseMetadataProvider1.Connection = New SAConnection(f.ConnectionString)

				' setup the query builder with metadata and syntax providers
				queryBuilder1.MetadataProvider = sybaseMetadataProvider1
				queryBuilder1.SyntaxProvider = sybaseSyntaxProvider1

				' kick the query builder to retrieve metadata from new connection
				queryBuilder1.InitializeDatabaseSchemaTree()
			End If
		End Using
	End Sub

	Private Sub refreshMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles refreshMetadataToolStripMenuItem.Click
		' Force the query builder to refresh metadata from current connection

		queryBuilder1.ClearMetadata()
		queryBuilder1.InitializeDatabaseSchemaTree()
	End Sub

	Private Sub editMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles editMetadataToolStripMenuItem.Click
		' Open the metadata container editor

		QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext, queryBuilder1.MetadataLoadingOptions)
	End Sub

	Private Sub clearMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles clearMetadataToolStripMenuItem.Click
		' Clear the metadata

		If MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
			queryBuilder1.ClearMetadata()
		End If
	End Sub

	Private Sub loadFromXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles loadFromXMLToolStripMenuItem.Click
		' Load metadata from XML file

		If openMetadataFileDialog.ShowDialog() = DialogResult.OK AndAlso openMetadataFileDialog.FileName <> "" Then
			queryBuilder1.MetadataContainer.ImportFromXML(openMetadataFileDialog.FileName)
		End If
	End Sub

	Private Sub saveToXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles saveToXMLToolStripMenuItem.Click
		' Save metadata to XML file

		If saveMetadataFileDialog.ShowDialog() = DialogResult.OK AndAlso saveMetadataFileDialog.FileName <> "" Then
			queryBuilder1.MetadataContainer.ExportToXML(saveMetadataFileDialog.FileName)
		End If
	End Sub

	Private Sub aboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles aboutToolStripMenuItem.Click 
		QueryBuilder.ShowAboutDialog()
	End Sub

	Private Sub queryBuilder1_SQLUpdated(sender As Object, e As EventArgs) Handles queryBuilder1.SQLUpdated
		' Handle the event raised by SQL builder object that the text of SQL query is changed

		' Hide error banner if any
		ErrorBox1.Visible = False

		' update the text box
		textBox1.Text = queryBuilder1.FormattedSQL
        _lastValidSql = queryBuilder1.FormattedSQL
	End Sub

	Private Sub textBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles textBox1.Validating
		Try
			' Update the query builder with manually edited query text:
			queryBuilder1.SQL = textBox1.Text

			' Hide error banner if any
		    ErrorBox1.Visible = False
		Catch ex As SQLParsingException
			' Set caret to error position
			textBox1.SelectionStart = ex.ErrorPos.pos

			' Show banner with error text
			ErrorBox1.Show(ex.Message, queryBuilder1.SyntaxProvider)
            _errorPosition = ex.ErrorPos.pos
		End Try
	End Sub

	Private Sub tabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles tabControl1.Selected
		' Move the input focus to the query builder.
		' This will fire Leave event in the text box and update the query builder 
		' with modified query text.
		queryBuilder1.Focus()
		Application.DoEvents()

		' Try to execute the query using current database connection:

		If e.TabPage Is tabPageData Then
			dataGridView1.DataSource = Nothing

			If queryBuilder1.MetadataProvider IsNot Nothing AndAlso queryBuilder1.MetadataProvider.Connected Then
				Dim command As SACommand = DirectCast(queryBuilder1.MetadataProvider.Connection.CreateCommand(), SACommand)
				command.CommandText = queryBuilder1.SQL

				' handle the query parameters
				If queryBuilder1.Parameters.Count > 0 Then
					For i As Integer = 0 To queryBuilder1.Parameters.Count - 1
						If Not command.Parameters.Contains(queryBuilder1.Parameters(i).FullName) Then
							Dim parameter As New SAParameter()
							parameter.ParameterName = queryBuilder1.Parameters(i).FullName
							parameter.DbType = queryBuilder1.Parameters(i).DataType
							command.Parameters.Add(parameter)
						End If
					Next

					Using qpf As New QueryParametersForm(command)
						qpf.ShowDialog()
					End Using
				End If

				Dim adapter As New SADataAdapter(command)
				Dim dataset As New DataSet()

				Try
					adapter.Fill(dataset, "QueryResult")
					dataGridView1.DataSource = dataset.Tables("QueryResult")
				Catch ex As Exception
					MessageBox.Show(ex.Message, "SQL query error")
				End Try
			End If
		End If
	End Sub

    Private Sub ErrorBox1_RevertValidText(sender As Object, e As EventArgs) Handles ErrorBox1.RevertValidText
        textBox1.Text = _lastValidSql
        textBox1.Focus()
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged
        ErrorBox1.Visible = False
    End Sub
End Class
