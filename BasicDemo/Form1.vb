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
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports Oracle.ManagedDataAccess.Client
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms

Partial Public Class Form1
    Inherits Form
    Private _errorPosition As Integer = -1
    Private _lastValidSql As String

    Public Sub New()
        InitializeComponent()

        ' DEMO WARNING
        If ActiveQueryBuilder.Core.BuildInfo.GetEdition() = ActiveQueryBuilder.Core.BuildInfo.Edition.Trial Then
            Dim trialNoticePanel As New Panel() With {
                .AutoSize = True,
                .AutoSizeMode = AutoSizeMode.GrowAndShrink,
                .BackColor = Color.LightGreen,
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
        End If
        AddHandler Load, AddressOf Form1_Load

        sqlTextEditor1.ExpressionContext = queryBuilder1.ActiveUnionSubQuery

        AddHandler queryBuilder1.ActiveUnionSubQueryChanged, AddressOf ActiveUnionSubQueryChanged
    End Sub

    Private Sub ActiveUnionSubQueryChanged(sender As Object, e As EventArgs)
        sqlTextEditor1.ExpressionContext = queryBuilder1.ActiveUnionSubQuery
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        RemoveHandler Load, AddressOf Form1_Load
        queryBuilder1.SyntaxProvider = genericSyntaxProvider1
        queryBuilder1.SQLQuery.QueryRoot.AllowSleepMode = True
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
        QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext)
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

    Private Sub queryBuilder_SQLUpdated(sender As Object, e As EventArgs) Handles queryBuilder1.SQLUpdated
        ' Handle the event raised by SQL Builder object that the text of SQL query is changed

        ' Hide error banner if any
        ErrorBox1.Visible = false

        ' update the text box
        sqlTextEditor1.Text = queryBuilder1.FormattedSQL
        _lastValidSql = queryBuilder1.FormattedSQL
    End Sub

    Public Sub ResetQueryBuilder()
        queryBuilder1.ClearMetadata()
        queryBuilder1.MetadataProvider = Nothing
        queryBuilder1.SyntaxProvider = Nothing
        queryBuilder1.MetadataLoadingOptions.OfflineMode = False
    End Sub

    Private Sub ConnectionForm_Click(sender As Object, e As EventArgs) Handles menuItem5.Click
        ResetQueryBuilder()

        Using connectionForm As ConnectionForm = New ConnectionForm()
            If connectionForm.ShowDialog() = DialogResult.OK Then
                Dim context As SQLContext = connectionForm.Connection.GetSqlContext()
                queryBuilder1.SQLContext.Assign(context)
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
            ErrorBox1.Visible = False
        Catch ex As SQLParsingException
            ' Set caret to error position
            sqlTextEditor1.SelectionStart = ex.ErrorPos.pos
            _errorPosition = ex.ErrorPos.pos
            ' Show banner with error text
            ErrorBox1.Show(ex.Message, queryBuilder1.SyntaxProvider)
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

    Private Sub queryBuilder1_SleepModeChanged(sender As Object, e As EventArgs) Handles queryBuilder1.SleepModeChanged
        labelSleepMode.Visible = queryBuilder1.SleepMode
        tabPageData.Enabled = Not queryBuilder1.SleepMode
    End Sub

    Private Sub queryBuilder1_QueryAwake(sender As QueryRoot, ByRef abort As Boolean) Handles queryBuilder1.QueryAwake
        If MessageBox.Show("You had typed something that is not a SELECT statement in the text editor and continued with visual query building." & "Whatever the text in the editor is, it will be replaced with the SQL generated by the component. Is it right?", "Active Query Builder .NET Demo", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    Private Sub ErrorBox1_RevertValidTextEvent(sender As Object, e As EventArgs) Handles ErrorBox1.RevertValidText
        sqlTextEditor1.Text = _lastValidSql
        sqlTextEditor1.Focus()
        ErrorBox1.Visible = False
    End Sub

    Private Sub ErrorBox1_SyntaxProviderChanged(sender As Object, e As EventArgs) Handles ErrorBox1.SyntaxProviderChanged
        Dim oldSql As String = sqlTextEditor1.Text
        queryBuilder1.SyntaxProvider = ErrorBox1.CurrentSyntaxProvider
        sqlTextEditor1.Text = oldSql
        sqlTextEditor1.SelectionLength = 0
        ErrorBox1.Visible = False
        sqlTextEditor1.Focus()
    End Sub

    Private Sub ErrorBox1_GoToErrorPositionEvent(sender As Object, e As EventArgs) Handles ErrorBox1.GoToErrorPosition
        If (_errorPosition <> -1) Then

            sqlTextEditor1.SelectionStart = _errorPosition
            sqlTextEditor1.SelectionLength = 0
            sqlTextEditor1.ScrollToPosition(_errorPosition)
        End If

        ErrorBox1.Visible = False
        sqlTextEditor1.Focus()
    End Sub
End Class
