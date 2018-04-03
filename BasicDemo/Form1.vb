﻿'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Data
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports Oracle.ManagedDataAccess.Client
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms

Partial Public Class Form1
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
        AddHandler Load, AddressOf Form1_Load
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        RemoveHandler Load, AddressOf Form1_Load
        queryBuilder1.SyntaxProvider = genericSyntaxProvider1
    End Sub

    Private Sub refreshMetadataMenuItem_Click(sender As Object, e As EventArgs) Handles refreshMetadataMenuItem.Click
        ' Force the query builder to refresh metadata from current connection
        ' to refresh metadata, just clear MetadataContainer and reinitialize metadata tree

        If queryBuilder1.MetadataProvider IsNot Nothing AndAlso queryBuilder1.MetadataProvider.Connected Then
            queryBuilder1.ClearMetadata()
            queryBuilder1.InitializeDatabaseSchemaTree()
        End If
    End Sub

    Private Sub editMetadataMenuItem_Click(sender As Object, e As EventArgs) Handles editMetadataMenuItem.Click
        ' Open the metadata container editor
        QueryBuilder.EditMetadataContainer(queryBuilder1.MetadataContainer, queryBuilder1.MetadataStructure, queryBuilder1.MetadataLoadingOptions)
    End Sub

    Private Sub clearMetadataMenuItem_Click(sender As Object, e As EventArgs) Handles clearMetadataMenuItem.Click
        ' Clear the metadata
        If MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            queryBuilder1.ClearMetadata()
        End If
    End Sub

    Private Sub loadMetadataFromXMLMenuItem_Click(sender As Object, e As EventArgs) Handles loadMetadataFromXMLMenuItem.Click
        ' Load metadata from XML file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            queryBuilder1.MetadataLoadingOptions.OfflineMode = True
            queryBuilder1.MetadataContainer.ImportFromXML(openFileDialog.FileName)
            queryBuilder1.InitializeDatabaseSchemaTree()
        End If
    End Sub

    Private Sub saveMetadataToXMLMenuItem_Click(sender As Object, e As EventArgs) Handles saveMetadataToXMLMenuItem.Click
        ' Save metadata to XML file
        saveFileDialog.FileName = "Metadata.xml"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            queryBuilder1.MetadataContainer.LoadAll(True)
            queryBuilder1.MetadataContainer.ExportToXML(saveFileDialog.FileName)
        End If
    End Sub

    Private Sub aboutMenuItem_Click(sender As Object, e As EventArgs) Handles aboutMenuItem.Click
        QueryBuilder.ShowAboutDialog()
    End Sub

    Private Sub queryBuilder_SQLUpdated(sender As Object, e As EventArgs)
        ' Handle the event raised by SQL Builder object that the text of SQL query is changed

        ' Hide error banner if any
        ShowErrorBanner(sqlTextEditor1, "")

        ' update the text box
        sqlTextEditor1.Text = queryBuilder1.FormattedSQL
    End Sub

    Public Sub ResetQueryBuilder()
        queryBuilder1.ClearMetadata()
        queryBuilder1.MetadataProvider = Nothing
        queryBuilder1.SyntaxProvider = Nothing
        queryBuilder1.MetadataLoadingOptions.OfflineMode = False
    End Sub

    Private Sub connectToMSSQLServerMenuItem_Click(sender As Object, e As EventArgs) Handles connectToMSSQLServerMenuItem.Click
        ResetQueryBuilder()

        ' Connect to MS SQL Server

        ' show the connection form
        Using f As New MSSQLConnectionForm()
            If f.ShowDialog() = DialogResult.OK Then
                ' create new SqlConnection object using the connections string from the connection form
                mssqlMetadataProvider1.Connection = New SqlConnection(f.ConnectionString)

                ' setup the query builder with metadata and syntax providers
                queryBuilder1.MetadataProvider = mssqlMetadataProvider1
                queryBuilder1.SyntaxProvider = mssqlSyntaxProvider1

                ' kick the query builder to fill metadata tree
                queryBuilder1.InitializeDatabaseSchemaTree()
            End If
        End Using
    End Sub

    Private Sub connectToOracleServerMenuItem_Click(sender As Object, e As EventArgs) Handles connectToOracleServerMenuItem.Click
        ResetQueryBuilder()

        ' Connect to Oracle Server.
        ' Connect using a metadata provider based on the native Oracle Data Provider for .NET (Oracle.DataAccess.Client).

        ' show the connection form
        Using f As New OracleConnectionForm()
            If f.ShowDialog() = DialogResult.OK Then
                ' create new OracleConnection object using the connections string from the connection form
                oracleMetadataProvider1.Connection = New OracleConnection(f.ConnectionString)

                ' setup the query builder with metadata and syntax providers
                queryBuilder1.MetadataProvider = oracleMetadataProvider1
                queryBuilder1.SyntaxProvider = oracleSyntaxProvider1

                ' kick the query builder to fill metadata tree
                queryBuilder1.InitializeDatabaseSchemaTree()
            End If
        End Using
    End Sub

    Private Sub connectToAccessDatabaseMenuItem_Click(sender As Object, e As EventArgs) Handles connectToAccessDatabaseMenuItem.Click
        ResetQueryBuilder()

        ' Connect to MS Access database using OLE DB provider

        ' show the connection form
        Using f As New AccessConnectionForm()
            If f.ShowDialog() = DialogResult.OK Then
                ' create new OleDbConnection object using the connections string from the connection form
                oledbMetadataProvider1.Connection = New OleDbConnection(f.ConnectionString)

                ' setup the query builder with metadata and syntax providers
                queryBuilder1.MetadataProvider = oledbMetadataProvider1
                queryBuilder1.SyntaxProvider = msaccessSyntaxProvider1

                ' kick the query builder to fill metadata tree
                queryBuilder1.InitializeDatabaseSchemaTree()
            End If
        End Using
    End Sub

    Private Sub connectOleDbMenuItem_Click(sender As Object, e As EventArgs) Handles connectOleDbMenuItem.Click
        ResetQueryBuilder()

        ' Connect to a database through the OLE DB provider

        ' show the connection form
        Using f As New OLEDBConnectionForm()
            If f.ShowDialog() = DialogResult.OK Then
                ' create new OleDbConnection object using the connections string from the connection form
                oledbMetadataProvider1.Connection = New OleDbConnection(f.ConnectionString)

                ' setup the query builder with metadata and syntax providers
                queryBuilder1.MetadataProvider = oledbMetadataProvider1
                queryBuilder1.SyntaxProvider = genericSyntaxProvider1

                ' kick the query builder to fill metadata tree
                queryBuilder1.InitializeDatabaseSchemaTree()

                ' show warning (just for demonstration purposes)
                WarnAboutGenericSyntaxProvider()
            End If
        End Using
    End Sub

    Private Sub connectODBCMenuItem_Click(sender As Object, e As EventArgs) Handles connectODBCMenuItem.Click
        ResetQueryBuilder()

        ' Connect to a database through the ODBC provider

        ' show the connection form
        Using f As New ODBCConnectionForm()
            If f.ShowDialog() = DialogResult.OK Then
                ' create new OdbcConnection object using the connections string from the connection form
                odbcMetadataProvider1.Connection = New OdbcConnection(f.ConnectionString)

                ' setup the query builder with metadata and syntax providers
                queryBuilder1.MetadataProvider = odbcMetadataProvider1
                queryBuilder1.SyntaxProvider = genericSyntaxProvider1

                ' kick the query builder to fill metadata tree
                queryBuilder1.InitializeDatabaseSchemaTree()

                ' show warning (just for demonstration purposes)
                WarnAboutGenericSyntaxProvider()
            End If
        End Using
    End Sub

    Private Sub fillProgrammaticallyMenuItem_Click(sender As Object, e As EventArgs) Handles fillProgrammaticallyMenuItem.Click
        ResetQueryBuilder()

        ' Fill the query builder metadata programmatically

        ' setup the query builder with metadata and syntax providers
        queryBuilder1.SyntaxProvider = genericSyntaxProvider1
        queryBuilder1.MetadataLoadingOptions.OfflineMode = True
        ' prevent querying obejects from database
        ' create database and schema
        Dim database As MetadataNamespace = queryBuilder1.MetadataContainer.AddDatabase("MyDB")
        database.[Default] = True
        Dim schema As MetadataNamespace = database.AddSchema("MySchema")
        schema.[Default] = True

        ' create table
        Dim tableOrders As MetadataObject = schema.AddTable("Orders")
        tableOrders.AddField("OrderID")
        tableOrders.AddField("OrderDate")
        tableOrders.AddField("CustomerID")
        tableOrders.AddField("ResellerID")

        ' create another table
        Dim tableCustomers As MetadataObject = schema.AddTable("Customers")
        tableCustomers.AddField("CustomerID")
        tableCustomers.AddField("CustomerName")
        tableCustomers.AddField("CustomerAddress")

        ' add a relation between these two tables
        Dim relation As MetadataForeignKey = tableCustomers.AddForeignKey("FK_CustomerID")
        relation.Fields.Add("CustomerID")
        relation.ReferencedObjectName = tableOrders.GetQualifiedName()
        relation.ReferencedFields.Add("CustomerID")

        'create view
        Dim viewResellers As MetadataObject = schema.AddView("Resellers")
        viewResellers.AddField("ResellerID")
        viewResellers.AddField("ResellerName")

        ' kick the query builder to fill metadata tree
        queryBuilder1.InitializeDatabaseSchemaTree()

        WarnAboutGenericSyntaxProvider()
        ' show warning (just for demonstration purposes)
    End Sub

    Private Sub sqlTextEditor1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sqlTextEditor1.Validating
        Try
            ' Update the query builder with manually edited query text:
            queryBuilder1.SQL = sqlTextEditor1.Text

            ' Hide error banner if any
            ShowErrorBanner(sqlTextEditor1, "")
        Catch ex As SQLParsingException
            ' Set caret to error position
            sqlTextEditor1.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            ShowErrorBanner(sqlTextEditor1, ex.Message)
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
                If TypeOf queryBuilder1.MetadataProvider Is MSSQLMetadataProvider Then
                    Dim command As SqlCommand = DirectCast(queryBuilder1.MetadataProvider.Connection.CreateCommand(), SqlCommand)
                    command.CommandText = queryBuilder1.SQL

                    ' handle the query parameters
                    If queryBuilder1.Parameters.Count > 0 Then
                        For i As Integer = 0 To queryBuilder1.Parameters.Count - 1
                            If Not command.Parameters.Contains(queryBuilder1.Parameters(i).FullName) Then
                                Dim parameter As New SqlParameter()
                                parameter.ParameterName = queryBuilder1.Parameters(i).FullName
                                parameter.DbType = queryBuilder1.Parameters(i).DataType
                                command.Parameters.Add(parameter)
                            End If
                        Next

                        Using qpf As New QueryParametersForm(command)
                            qpf.ShowDialog()
                        End Using
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataset As New DataSet()

                    Try
                        adapter.Fill(dataset, "QueryResult")
                        dataGridView1.DataSource = dataset.Tables("QueryResult")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "SQL query error")
                    End Try
                ElseIf TypeOf queryBuilder1.MetadataProvider Is OracleNativeMetadataProvider Then
                    Dim command As OracleCommand = DirectCast(queryBuilder1.MetadataProvider.Connection.CreateCommand(), OracleCommand)
                    command.CommandText = queryBuilder1.SQL

                    ' handle the query parameters
                    If queryBuilder1.Parameters.Count > 0 Then
                        For i As Integer = 0 To queryBuilder1.Parameters.Count - 1
                            If Not command.Parameters.Contains(queryBuilder1.Parameters(i).FullName) Then
                                Dim parameter As New OracleParameter()
                                parameter.ParameterName = queryBuilder1.Parameters(i).FullName
                                parameter.DbType = queryBuilder1.Parameters(i).DataType
                                command.Parameters.Add(parameter)
                            End If
                        Next

                        Using qpf As New QueryParametersForm(command)
                            qpf.ShowDialog()
                        End Using
                    End If

                    Dim adapter As New OracleDataAdapter(command)
                    Dim dataset As New DataSet()

                    Try
                        adapter.Fill(dataset, "QueryResult")
                        dataGridView1.DataSource = dataset.Tables("QueryResult")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "SQL query error")
                    End Try
                ElseIf TypeOf queryBuilder1.MetadataProvider Is OLEDBMetadataProvider Then
                    Dim command As OleDbCommand = DirectCast(queryBuilder1.MetadataProvider.Connection.CreateCommand(), OleDbCommand)
                    command.CommandText = queryBuilder1.SQL

                    ' handle the query parameters
                    If queryBuilder1.Parameters.Count > 0 Then
                        For i As Integer = 0 To queryBuilder1.Parameters.Count - 1
                            If Not command.Parameters.Contains(queryBuilder1.Parameters(i).FullName) Then
                                Dim parameter As New OleDbParameter()
                                parameter.ParameterName = queryBuilder1.Parameters(i).FullName
                                parameter.DbType = queryBuilder1.Parameters(i).DataType
                                command.Parameters.Add(parameter)
                            End If
                        Next

                        Using qpf As New QueryParametersForm(command)
                            qpf.ShowDialog()
                        End Using
                    End If

                    Dim adapter As New OleDbDataAdapter(command)
                    Dim dataset As New DataSet()

                    Try
                        adapter.Fill(dataset, "QueryResult")
                        dataGridView1.DataSource = dataset.Tables("QueryResult")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "SQL query error")
                    End Try
                ElseIf TypeOf queryBuilder1.MetadataProvider Is ODBCMetadataProvider Then
                    Dim command As OdbcCommand = DirectCast(queryBuilder1.MetadataProvider.Connection.CreateCommand(), OdbcCommand)
                    command.CommandText = queryBuilder1.SQL

                    ' handle the query parameters
                    If queryBuilder1.Parameters.Count > 0 Then
                        For i As Integer = 0 To queryBuilder1.Parameters.Count - 1
                            If Not command.Parameters.Contains(queryBuilder1.Parameters(i).FullName) Then
                                Dim parameter As New OdbcParameter()
                                parameter.ParameterName = queryBuilder1.Parameters(i).FullName
                                parameter.DbType = queryBuilder1.Parameters(i).DataType
                                command.Parameters.Add(parameter)
                            End If
                        Next

                        Using qpf As New QueryParametersForm(command)
                            qpf.ShowDialog()
                        End Using
                    End If

                    Dim adapter As New OdbcDataAdapter(command)
                    Dim dataset As New DataSet()

                    Try
                        adapter.Fill(dataset, "QueryResult")
                        dataGridView1.DataSource = dataset.Tables("QueryResult")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "SQL query error")
                    End Try
                End If

                ' enable sorting
                For Each column As DataGridViewColumn In dataGridView1.Columns
                    column.SortMode = DataGridViewColumnSortMode.Automatic
                Next
            End If
        End If
    End Sub

    Private Sub propertiesMenuItem_Click(sender As Object, e As EventArgs) Handles propertiesMenuItem.Click
        ' Show Properties form
        Using f As New QueryBuilderPropertiesForm(queryBuilder1)
            f.ShowDialog()
        End Using

        WarnAboutGenericSyntaxProvider()
        ' show warning (just for demonstration purposes)
    End Sub

    Private Sub queryStatisticsMenuItem_Click(sender As Object, e As EventArgs) Handles queryStatisticsMenuItem.Click
        Dim queryStatistics As QueryStatistics = queryBuilder1.QueryStatistics
        Dim builder As New StringBuilder()

        builder.Append("Used Objects (").Append(queryStatistics.UsedDatabaseObjects.Count).AppendLine("):")
        builder.AppendLine()

        For i As Integer = 0 To queryStatistics.UsedDatabaseObjects.Count - 1
            builder.AppendLine(queryStatistics.UsedDatabaseObjects(i).ObjectName.QualifiedName)
        Next

        builder.AppendLine().AppendLine()
        builder.Append("Used Columns (").Append(queryStatistics.UsedDatabaseObjectFields.Count).AppendLine("):")
        builder.AppendLine()

        For i As Integer = 0 To queryStatistics.UsedDatabaseObjectFields.Count - 1
            builder.AppendLine(queryStatistics.UsedDatabaseObjectFields(i).FullName.QualifiedName)
        Next

        builder.AppendLine().AppendLine()
        builder.Append("Output Expressions (").Append(queryStatistics.OutputColumns.Count).AppendLine("):")
        builder.AppendLine()

        For i As Integer = 0 To queryStatistics.OutputColumns.Count - 1
            builder.AppendLine(queryStatistics.OutputColumns(i).Expression)
        Next

        Using f As New QueryStatisticsForm()
            f.textBox.Text = builder.ToString()
            f.ShowDialog()
        End Using
    End Sub

    ' show warning (just for demonstration purposes)

    Private Sub WarnAboutGenericSyntaxProvider()
        If TypeOf queryBuilder1.SyntaxProvider Is GenericSyntaxProvider Then
            panel1.Visible = True

            ' setup the panel to hide automatically
            Dim timer As Timer = New System.Windows.Forms.Timer()
            AddHandler timer.Tick, AddressOf TimerEvent
            timer.Interval = 10000
            timer.Start()
        End If
    End Sub

    Private Sub TimerEvent(source As [Object], args As EventArgs)
        panel1.Visible = False
        DirectCast(source, Timer).[Stop]()
        DirectCast(source, Timer).Dispose()
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
            Dim label As New Label() With {
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