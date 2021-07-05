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
Imports Advantage.Data.Provider
Imports AdvantageDemo
Imports GeneralAssembly.Forms.QueryInformationForms


Partial Public Class Form1
    Inherits Form
    Private _lastValidSql As String
    Private _errorPosition As Integer = -1

    Public Sub New()
        InitializeComponent()

        ' DEMO WARNING
        Dim trialNoticePanel As Panel = New Panel With {.AutoSize = True, .AutoSizeMode = AutoSizeMode.GrowAndShrink, .BackColor = Color.LightGreen, .BorderStyle = BorderStyle.FixedSingle, .Dock = DockStyle.Top, .Padding = New Padding(6, 5, 3, 0)}

        Dim label As Label = New Label With {.AutoSize = True, .Margin = New Padding(0), .Text = "Generation of random aliases for the query output columns is the limitation of the trial version. The full version is free from this behavior.", .Dock = DockStyle.Fill, .UseCompatibleTextRendering = True}

        trialNoticePanel.Controls.Add(label)
        Controls.Add(trialNoticePanel)
    End Sub

    Private Sub connectMetadataToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles connectMetadataToolStripMenuItem.Click
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

    Private Sub refreshMetadataToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles refreshMetadataToolStripMenuItem.Click
        ' Force the query builder to refresh metadata from current connection

        queryBuilder.ClearMetadata()
        queryBuilder.InitializeDatabaseSchemaTree()
    End Sub

    Private Sub editMetadataToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles editMetadataToolStripMenuItem.Click
        ' Open the metadata container editor

        QueryBuilder.EditMetadataContainer(queryBuilder.SQLContext)
    End Sub

    Private Sub clearMetadataToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles clearMetadataToolStripMenuItem.Click
        ' Clear the metadata

        If MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            queryBuilder.ClearMetadata()
        End If
    End Sub

    Private Sub loadFromXMLToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loadFromXMLToolStripMenuItem.Click
        ' Load metadata from XML file

        If openMetadataFileDialog.ShowDialog() = DialogResult.OK AndAlso openMetadataFileDialog.FileName <> "" Then
            queryBuilder.MetadataContainer.ImportFromXML(openMetadataFileDialog.FileName)
        End If
    End Sub

    Private Sub saveToXMLToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveToXMLToolStripMenuItem.Click
        ' Save metadata to XML file

        If saveMetadataFileDialog.ShowDialog() = DialogResult.OK AndAlso saveMetadataFileDialog.FileName <> "" Then
            queryBuilder.MetadataContainer.ExportToXML(saveMetadataFileDialog.FileName)
        End If
    End Sub

    Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutToolStripMenuItem.Click
        QueryBuilder.ShowAboutDialog()
    End Sub

    Private Sub queryBuilder_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs) Handles queryBuilder.SQLUpdated
        ' Handle the event raised by QueryBuilder that the text of SQL query is changed

        ' Hide error banner if any
        errorBox1.Show(Nothing, queryBuilder.SyntaxProvider)

        ' update the text box
        textBox1.Text = queryBuilder.FormattedSQL
        _lastValidSql = textBox1.Text
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

    Private Sub tabControl1_Selected(ByVal sender As Object, ByVal e As TabControlEventArgs) Handles tabControl1.Selected
        ' Move the input focus to the query builder.
        ' This will fire Leave event in the text box and update the query builder 
        ' with modified query text.
        queryBuilder.Focus()
        Application.DoEvents()

        ' Try to execute the query using current database connection

        If e.TabPage Is tabPageData Then
            dataGridView1.DataSource = Nothing

            If queryBuilder.MetadataProvider IsNot Nothing AndAlso queryBuilder.MetadataProvider.Connected Then
                Dim command As AdsCommand = CType(queryBuilder.MetadataProvider.Connection.CreateCommand(), AdsCommand)
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
                    Next i

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

    Private Sub queryStatisticsMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles queryStatisticsMenuItem.Click
        Dim stats As String = ""

        Dim qs As QueryStatistics = queryBuilder.QueryStatistics

        stats = "Used Objects (" & qs.UsedDatabaseObjects.Count & "): "
        For i As Integer = 0 To qs.UsedDatabaseObjects.Count - 1
            stats &= vbLf & qs.UsedDatabaseObjects(i).ObjectName.QualifiedName
        Next i

        stats &= vbLf & vbLf & "Used Columns (" & qs.UsedDatabaseObjectFields.Count & "): "
        For i As Integer = 0 To qs.UsedDatabaseObjectFields.Count - 1
            stats &= vbLf & qs.UsedDatabaseObjectFields(i).FullName.QualifiedName
        Next i

        stats &= vbLf & vbLf & "Output Expressions (" & qs.OutputColumns.Count & "): "
        For i As Integer = 0 To qs.OutputColumns.Count - 1
            stats &= vbLf & qs.OutputColumns(i).Expression
        Next i

        MessageBox.Show(stats)
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
        textBox1.Text = _lastValidSql
        textBox1.Focus()
    End Sub
End Class
