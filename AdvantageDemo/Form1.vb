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

Imports Advantage.Data.Provider
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms


Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()

		' DEMO WARNING
        Dim trialNoticePanel As New Panel() With {
            .AutoSize = True,
            .AutoSizeMode = AutoSizeMode.GrowAndShrink,
            .BackColor = Color.LightPink,
            .BorderStyle = BorderStyle.FixedSingle,
            .Dock = DockStyle.Top,
            .Padding = New Padding(6, 5, 3, 0)
        }

        Dim label As New Label() With {
            .AutoSize = True,
            .Margin = New Padding(0),
            .Text = "Generation of random aliases for the query output columns is the limitation of the trial version. The full version is free from this behavior.",
            .Dock = DockStyle.Fill,
            .UseCompatibleTextRendering = True
        }

        trialNoticePanel.Controls.Add(label)
	    Controls.Add(trialNoticePanel)
    End Sub

    Private Sub connectMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Connect to Advantage database

        ' show the connection form
        Using f As New AdvantageConnectionForm()
            If f.ShowDialog() = DialogResult.OK Then
                ' create new SqlConnection object using the connections string from the connection form
                advantageMetadataProvider1.Connection = New AdsConnection(f.ConnectionString)

                ' setup the query builder with metadata and syntax providers
                queryBuilder.MetadataProvider = advantageMetadataProvider1
                queryBuilder.SyntaxProvider = advantageSyntaxProvider1

                ' kick the query builder to initialize its metadata tree
                queryBuilder.InitializeDatabaseSchemaTree()
            End If
        End Using
    End Sub

    Private Sub refreshMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Force the query builder to refresh metadata from current connection

        queryBuilder.ClearMetadata()
        queryBuilder.InitializeDatabaseSchemaTree()
    End Sub

    Private Sub editMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Open the metadata container editor

        QueryBuilder.EditMetadataContainer(queryBuilder.SQLContext, queryBuilder.MetadataLoadingOptions)
    End Sub

    Private Sub clearMetadataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Clear the metadata

        If MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            queryBuilder.ClearMetadata()
        End If
    End Sub

    Private Sub loadFromXMLToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Load metadata from XML file

        If openMetadataFileDialog.ShowDialog() = DialogResult.OK AndAlso openMetadataFileDialog.FileName <> "" Then
            queryBuilder.MetadataContainer.ImportFromXML(openMetadataFileDialog.FileName)
        End If
    End Sub

    Private Sub saveToXMLToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Save metadata to XML file

        If saveMetadataFileDialog.ShowDialog() = DialogResult.OK AndAlso saveMetadataFileDialog.FileName <> "" Then
            queryBuilder.MetadataContainer.ExportToXML(saveMetadataFileDialog.FileName)
        End If
    End Sub

    Private Sub aboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        QueryBuilder.ShowAboutDialog()
    End Sub

    Private Sub queryBuilder_SQLUpdated(sender As Object, e As EventArgs)
        ' Handle the event raised by QueryBuilder that the text of SQL query is changed

        ' Hide error banner if any
        ShowErrorBanner(textBox1, "")

        ' update the text box
        textBox1.Text = queryBuilder.FormattedSQL
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

    Private Sub tabControl1_Selected(sender As Object, e As TabControlEventArgs)
        ' Move the input focus to the query builder.
        ' This will fire Leave event in the text box and update the query builder 
        ' with modified query text.
        queryBuilder.Focus()
        Application.DoEvents()

        ' Try to execute the query using current database connection

        If e.TabPage Is tabPageData Then
            dataGridView1.DataSource = Nothing

            If queryBuilder.MetadataProvider IsNot Nothing AndAlso queryBuilder.MetadataProvider.Connected Then
                Dim command As AdsCommand = DirectCast(queryBuilder.MetadataProvider.Connection.CreateCommand(), AdsCommand)
                command.CommandText = queryBuilder.SQL

                ' handle the query parameters
                If queryBuilder.Parameters.Count > 0 Then
                    For i As Integer = 0 To queryBuilder.Parameters.Count - 1
                        If Not command.Parameters.Contains(queryBuilder.Parameters(i).FullName) Then
                            Dim parameter As New AdsParameter()
                            parameter.ParameterName = queryBuilder.Parameters(i).FullName
                            parameter.DbType = queryBuilder.Parameters(i).DataType
                            command.Parameters.Add(parameter)
                        End If
                    Next

                    Using qpf As New QueryParametersForm(command)
                        qpf.ShowDialog()
                    End Using
                End If

                Dim adapter As New AdsDataAdapter(command)
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

        Dim qs As QueryStatistics = queryBuilder.QueryStatistics

        stats = "Used Objects (" & qs.UsedDatabaseObjects.Count & "): "
        For i As Integer = 0 To qs.UsedDatabaseObjects.Count - 1
            stats += vbLf & qs.UsedDatabaseObjects(i).ObjectName.QualifiedName
        Next

        stats += vbLf & vbLf & "Used Columns (" & qs.UsedDatabaseObjectFields.Count & "): "
        For i As Integer = 0 To qs.UsedDatabaseObjectFields.Count - 1
            stats += vbLf & qs.UsedDatabaseObjectFields(i).ObjectName.QualifiedName
        Next

        stats += vbLf & vbLf & "Output Expressions (" & qs.OutputColumns.Count & "): "
        For i As Integer = 0 To qs.OutputColumns.Count - 1
            stats += vbLf & qs.OutputColumns(i).Expression
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
