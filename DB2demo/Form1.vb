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
Imports IBM.Data.DB2


Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub connectMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs)
		' Connect to DB2 database

		' show the connection form
		Using f As New DB2ConnectionForm()
			If f.ShowDialog() = DialogResult.OK Then
				' create new SqlConnection object using the connections string from the connection form
				DB2MetadataProvider1.Connection = New DB2Connection(f.ConnectionString)

				' setup the query builder with metadata and syntax providers
				queryBuilder1.MetadataProvider = DB2MetadataProvider1
				queryBuilder1.SyntaxProvider = DB2SyntaxProvider1

				' kick the query builder to retrieve metadata from new connection
				queryBuilder1.InitializeDatabaseSchemaTree()
			End If
		End Using
	End Sub

	Private Sub refreshMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs)
		' Force the query builder to refresh metadata from current connection

		queryBuilder1.ClearMetadata()
		queryBuilder1.InitializeDatabaseSchemaTree()
	End Sub

	Private Sub editMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs)
		' Open the metadata container editor

	    QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext, queryBuilder1.MetadataLoadingOptions)
	End Sub

	Private Sub clearMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs)
		' Clear the metadata

		If MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
			queryBuilder1.ClearMetadata()
		End If
	End Sub

	Private Sub loadFromXMLToolStripMenuItem_Click(sender As Object, e As EventArgs)
		' Load metadata from XML file

		If openMetadataFileDialog.ShowDialog() = DialogResult.OK AndAlso openMetadataFileDialog.FileName <> "" Then
			queryBuilder1.MetadataContainer.ImportFromXML(openMetadataFileDialog.FileName)
		End If
	End Sub

	Private Sub saveToXMLToolStripMenuItem_Click(sender As Object, e As EventArgs)
		' Save metadata to XML file

		If saveMetadataFileDialog.ShowDialog() = DialogResult.OK AndAlso saveMetadataFileDialog.FileName <> "" Then
			queryBuilder1.MetadataContainer.ExportToXML(saveMetadataFileDialog.FileName)
		End If
	End Sub

	Private Sub aboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
		QueryBuilder.ShowAboutDialog()
	End Sub

	Private Sub queryBuilder1_SQLUpdated(sender As Object, e As EventArgs)
		' Handle the event raised by SQL builder object that the text of SQL query is changed

		' Hide error banner if any
		ShowErrorBanner(textBox1, "")

		' update the text box
		textBox1.Text = queryBuilder1.FormattedSQL
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

	Private Sub tabControl1_Selected(sender As Object, e As TabControlEventArgs)
		' Move the input focus to the query builder.
		' This will fire Leave event in the text box and update the query builder 
		' with modified query text.
		queryBuilder1.Focus()
		Application.DoEvents()


		' Try to execute the query using current database connection

		If e.TabPage Is tabPageData Then
			dataGridView1.DataSource = Nothing

			If queryBuilder1.MetadataProvider IsNot Nothing AndAlso queryBuilder1.MetadataProvider.Connected Then
				Dim command As DB2Command = DirectCast(queryBuilder1.MetadataProvider.Connection.CreateCommand(), DB2Command)
				command.CommandText = queryBuilder1.SQL

				' handle the query parameters
				If queryBuilder1.Parameters.Count > 0 Then
					For i As Integer = 0 To queryBuilder1.Parameters.Count - 1
						If Not command.Parameters.Contains(queryBuilder1.Parameters(i).FullName) Then
							Dim parameter As New DB2Parameter()
							parameter.ParameterName = queryBuilder1.Parameters(i).FullName
							parameter.DbType = queryBuilder1.Parameters(i).DataType
							command.Parameters.Add(parameter)
						End If
					Next

					Using qpf As New QueryParametersForm(command)
						qpf.ShowDialog()
					End Using
				End If

				Dim adapter As New DB2DataAdapter(command)
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

	Private Sub queryStatisticsMenuItem_Click(sender As Object, e As EventArgs)
		Dim stats As String = ""

		Dim qs As QueryStatistics = queryBuilder1.QueryStatistics

		stats = "Used Objects (" + qs.UsedDatabaseObjects.Count & "): "
		For i As Integer = 0 To qs.UsedDatabaseObjects.Count - 1
			stats += vbLf + qs.UsedDatabaseObjects(i).ObjectName.QualifiedName
		Next

		stats += (vbLf & vbLf & "Used Columns (") + qs.UsedDatabaseObjectFields.Count & "): "
		For i As Integer = 0 To qs.UsedDatabaseObjectFields.Count - 1
			stats += vbLf + qs.UsedDatabaseObjectFields(i).ObjectName.QualifiedName
		Next

		stats += (vbLf & vbLf & "Output Expressions (") + qs.OutputColumns.Count & "): "
		For i As Integer = 0 To qs.OutputColumns.Count - 1
			stats += vbLf + qs.OutputColumns(i).Expression
		Next

		MessageBox.Show(stats)
	End Sub

	Public Sub ShowErrorBanner(ByVal control As Control, ByVal text As String)
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
