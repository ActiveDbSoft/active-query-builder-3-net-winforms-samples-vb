''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2022 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports GeneralAssembly.Forms.QueryInformationForms
Imports GeneralAssembly.QueryBuilderProperties


Partial Public Class Form1
    Inherits Form
    Private _errorPosition As Integer = -1
    Private _lastValidSql As String

    Friend Enum ModeEditor
        Entire
        SubQuery
        Expression
    End Enum

    Private _mode As ModeEditor = ModeEditor.SubQuery
    Private _selectedConnection As ConnectionInfo

    Public Sub New()
        InitializeComponent()
        ' DEMO WARNING
        Dim trialNoticePanel As Panel = New Panel With {.AutoSize = True, .AutoSizeMode = AutoSizeMode.GrowAndShrink, .BackColor = Color.LightPink, .BorderStyle = BorderStyle.FixedSingle, .Dock = DockStyle.Top, .Padding = New Padding(6, 5, 3, 0)}

        Dim label As Label = New Label With {.AutoSize = True, .Margin = New Padding(0), .Text = "Generation of random aliases for the query output columns is the limitation of the trial version. The full version is free from this behavior.", .Dock = DockStyle.Fill, .UseCompatibleTextRendering = True}

        trialNoticePanel.Controls.Add(label)
        Controls.Add(trialNoticePanel)
        AddHandler Load, AddressOf Form1_Load
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler Load, AddressOf Form1_Load
        queryBuilder1.SyntaxProvider = genericSyntaxProvider1
        breadcrumbControl1.QueryView = queryBuilder1.QueryView

        'queryBuilder1.ActiveUnionSubQueryChanging += QueryBuilder1_ActiveUnionSubQueryChanging;
        AddHandler queryBuilder1.ActiveUnionSubQueryChanged, AddressOf QueryBuilder1_ActiveUnionSubQueryChanged
        AddHandler queryBuilder1.SQLUpdated, AddressOf QueryBuilder1_SQLUpdated
        AddHandler textBox1.Validating, AddressOf textBox1_Validating
        tsmiSubQuery.Checked = True
    End Sub

    Private Sub QueryBuilder1_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs)
        ApplyText()
    End Sub

    Private Sub QueryBuilder1_ActiveUnionSubQueryChanged(ByVal sender As Object, ByVal e As EventArgs)
        ApplyText()
    End Sub

    Private Sub QueryBuilder1_ActiveUnionSubQueryChanging(ByVal sender As Object, ByVal e As ActiveQueryBuilder.View.SubQueryChangingEventArgs)
        Dim sql As String = textBox1.Text.Trim()
        If String.IsNullOrEmpty(sql) Then
            Return
        End If
        Try
            Select Case _mode
                Case ModeEditor.Entire
                    queryBuilder1.SQLContext.ParseSelect(sql)
                Case ModeEditor.SubQuery
                    queryBuilder1.SQLContext.ParseSelect(sql)
                Case ModeEditor.Expression
                    queryBuilder1.SQLContext.ParseSelect(sql)
                Case Else
                    Throw New ArgumentOutOfRangeException()
            End Select
        Catch
            e.Abort = True
        End Try
    End Sub

    Private Sub ApplyText()
        Dim sqlFormattingOptions = queryBuilder1.SQLFormattingOptions
        Select Case _mode
            Case ModeEditor.Entire
                textBox1.Text = queryBuilder1.FormattedSQL
            Case ModeEditor.SubQuery
                If queryBuilder1.ActiveUnionSubQuery Is Nothing Then
                    Exit Select
                End If
                Dim subQuery = queryBuilder1.ActiveUnionSubQuery.ParentSubQuery
                textBox1.Text = FormattedSQLBuilder.GetSQL(subQuery, sqlFormattingOptions)
            Case ModeEditor.Expression
                If queryBuilder1.ActiveUnionSubQuery Is Nothing Then
                    Exit Select
                End If
                Dim unionSubQuery = queryBuilder1.ActiveUnionSubQuery
                textBox1.Text = FormattedSQLBuilder.GetSQL(unionSubQuery, sqlFormattingOptions)
            Case Else
                Throw New ArgumentOutOfRangeException()
        End Select
    End Sub

    Private Sub refreshMetadataMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles refreshMetadataMenuItem.Click
        ' Force the query builder to refresh metadata from current connection
        ' to refresh metadata, just clear MetadataContainer and reinitialize metadata tree

        If queryBuilder1.MetadataProvider IsNot Nothing AndAlso queryBuilder1.MetadataProvider.Connected Then
            queryBuilder1.ClearMetadata()
            queryBuilder1.InitializeDatabaseSchemaTree()
        End If
    End Sub

    Private Sub editMetadataMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles editMetadataMenuItem.Click
        ' Open the metadata container editor
        QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext)
    End Sub

    Private Sub clearMetadataMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles clearMetadataMenuItem.Click
        ' Clear the metadata
        If MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            queryBuilder1.ClearMetadata()
        End If
    End Sub

    Private Sub loadMetadataFromXMLMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loadMetadataFromXMLMenuItem.Click
        ' Load metadata from XML file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            queryBuilder1.MetadataLoadingOptions.OfflineMode = True
            queryBuilder1.MetadataContainer.ImportFromXML(openFileDialog.FileName)
            queryBuilder1.InitializeDatabaseSchemaTree()
        End If
    End Sub

    Private Sub saveMetadataToXMLMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveMetadataToXMLMenuItem.Click
        ' Save metadata to XML file
        saveFileDialog.FileName = "Metadata.xml"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            queryBuilder1.MetadataContainer.LoadAll(True)
            queryBuilder1.MetadataContainer.ExportToXML(saveFileDialog.FileName)
        End If
    End Sub

    Private Sub aboutMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutMenuItem.Click
        QueryBuilder.ShowAboutDialog()
    End Sub

    Private Sub queryBuilder_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs) Handles queryBuilder1.SQLUpdated
        ' Handle the event raised by SQL Builder object that the text of SQL query is changed

        ' Hide error banner if any
        errorBox1.Show(Nothing, queryBuilder1.SyntaxProvider)

        ' update the text box
        textBox1.Text = queryBuilder1.FormattedSQL
        _lastValidSql = textBox1.Text
    End Sub

    Public Sub ResetQueryBuilder()
        queryBuilder1.ClearMetadata()
        queryBuilder1.MetadataProvider = Nothing
        queryBuilder1.SyntaxProvider = Nothing
        queryBuilder1.MetadataLoadingOptions.OfflineMode = False
    End Sub


    Private Sub fillProgrammaticallyMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles fillProgrammaticallyMenuItem.Click
        ResetQueryBuilder()

        ' Fill the query builder metadata programmatically

        ' setup the query builder with metadata and syntax providers
        queryBuilder1.SyntaxProvider = genericSyntaxProvider1
        queryBuilder1.MetadataLoadingOptions.OfflineMode = True ' prevent querying obejects from database

        ' create database and schema
        Dim database As MetadataNamespace = queryBuilder1.MetadataContainer.AddDatabase("MyDB")
        database.Default = True
        Dim schema As MetadataNamespace = database.AddSchema("MySchema")
        schema.Default = True

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

        WarnAboutGenericSyntaxProvider() ' show warning (just for demonstration purposes)
    End Sub

    Private Sub textBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim text As String = textBox1.Text.Trim()

        queryBuilder1.BeginUpdate()
        Try
            If Not String.IsNullOrEmpty(text) Then
                queryBuilder1.SQLContext.ParseSelect(text)
            End If

            Select Case _mode
                Case ModeEditor.Entire
                    queryBuilder1.SQL = text
                Case ModeEditor.SubQuery
                    Dim subQuery = queryBuilder1.ActiveUnionSubQuery.ParentSubQuery
                    subQuery.SQL = text
                Case ModeEditor.Expression
                    Dim unionSubQuery = queryBuilder1.ActiveUnionSubQuery
                    unionSubQuery.SQL = text
                Case Else
                    Throw New ArgumentOutOfRangeException()
            End Select
            errorBox1.Show(Nothing, queryBuilder1.SyntaxProvider)
        Catch exception As SQLParsingException
            errorBox1.Show(exception.Message, queryBuilder1.SyntaxProvider)
            _errorPosition = exception.ErrorPos.pos
        Finally
            queryBuilder1.EndUpdate()
        End Try
    End Sub

    Private Sub tabControl1_Selected(ByVal sender As Object, ByVal e As TabControlEventArgs) Handles tabControl1.Selected
        ' Move the input focus to the query builder.
        ' This will fire Leave event in the text box and update the query builder
        ' with modified query text.
        queryBuilder1.Focus()
        Application.DoEvents()

        ' Try to execute the query using current database connection:

        If e.TabPage Is tabPageData Then
            dataGridView1.FillDataGrid(queryBuilder1.SQL)
        End If
    End Sub

    Private Sub propertiesMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles propertiesMenuItem.Click
        ' Show Properties form
        Using f As New QueryBuilderPropertiesForm(queryBuilder1)
            f.ShowDialog()
        End Using

        WarnAboutGenericSyntaxProvider() ' show warning (just for demonstration purposes)
    End Sub

    Private Sub queryStatisticsMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles queryStatisticsMenuItem.Click
        Dim queryStatistics As QueryStatistics = queryBuilder1.QueryStatistics
        Dim builder As New StringBuilder()

        builder.Append("Used Objects (").Append(queryStatistics.UsedDatabaseObjects.Count).AppendLine("):")
        builder.AppendLine()

        For i As Integer = 0 To queryStatistics.UsedDatabaseObjects.Count - 1
            builder.AppendLine(queryStatistics.UsedDatabaseObjects(i).ObjectName.QualifiedName)
        Next i

        builder.AppendLine().AppendLine()
        builder.Append("Used Columns (").Append(queryStatistics.UsedDatabaseObjectFields.Count).AppendLine("):")
        builder.AppendLine()

        For i As Integer = 0 To queryStatistics.UsedDatabaseObjectFields.Count - 1
            builder.AppendLine(queryStatistics.UsedDatabaseObjectFields(i).FullName.QualifiedName)
        Next i

        builder.AppendLine().AppendLine()
        builder.Append("Output Expressions (").Append(queryStatistics.OutputColumns.Count).AppendLine("):")
        builder.AppendLine()

        For i As Integer = 0 To queryStatistics.OutputColumns.Count - 1
            builder.AppendLine(queryStatistics.OutputColumns(i).Expression)
        Next i

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
            Dim timer As Timer = New Timer()
            AddHandler timer.Tick, AddressOf TimerEvent
            timer.Interval = 10000
            timer.Start()
        End If
    End Sub

    Private Sub TimerEvent(ByVal source As Object, ByVal args As EventArgs)
        panel1.Visible = False
        CType(source, Timer).Stop()
        CType(source, Timer).Dispose()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim location As New Point(button1.Location.X + button1.ClientRectangle.Width, button1.Location.Y)
        cmEditMode.Show(button1.PointToScreen(location))
    End Sub

    Private ReadOnly Property QueryHasError() As Boolean
        Get
            Return textBox1.Controls.Find("ErrorBanner", True).Any()
        End Get
    End Property

    Private Sub tsmiEntire_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiEntire.CheckedChanged
        Dim menuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        If QueryHasError Then
            RemoveHandler tsmiEntire.CheckedChanged, AddressOf tsmiEntire_CheckedChanged
            menuItem.Checked = Not menuItem.Checked
            AddHandler tsmiEntire.CheckedChanged, AddressOf tsmiEntire_CheckedChanged
            Return
        End If
        If Not menuItem.Checked Then
            Return
        End If
        tsmiSubQuery.Checked = False
        tsmiExpression.Checked = False
        _mode = ModeEditor.Entire
        ApplyText()
    End Sub

    Private Sub tsmiSubQuery_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiSubQuery.CheckedChanged

        Dim menuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        If QueryHasError Then
            RemoveHandler tsmiSubQuery.CheckedChanged, AddressOf tsmiSubQuery_CheckedChanged
            menuItem.Checked = Not menuItem.Checked
            AddHandler tsmiSubQuery.CheckedChanged, AddressOf tsmiSubQuery_CheckedChanged
            Return
        End If
        If Not menuItem.Checked Then
            Return
        End If
        tsmiEntire.Checked = False
        tsmiExpression.Checked = False
        _mode = ModeEditor.SubQuery
        ApplyText()
    End Sub

    Private Sub tsmiExpression_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tsmiExpression.CheckedChanged
        Dim menuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        If QueryHasError Then
            RemoveHandler tsmiExpression.CheckedChanged, AddressOf tsmiExpression_CheckedChanged
            menuItem.Checked = Not menuItem.Checked
            AddHandler tsmiExpression.CheckedChanged, AddressOf tsmiExpression_CheckedChanged
            Return
        End If
        If Not menuItem.Checked Then
            Return
        End If
        tsmiSubQuery.Checked = False
        tsmiEntire.Checked = False
        _mode = ModeEditor.Expression
        ApplyText()
    End Sub

    Private Sub errorBox1_GoToErrorPosition(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.GoToErrorPosition
        If _errorPosition <> -1 Then
            textBox1.SelectionStart = _errorPosition
            textBox1.SelectionLength = 0
            textBox1.ScrollToCaret()
        End If

        textBox1.Focus()
    End Sub

    Private Sub errorBox1_RevertValidText(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.RevertValidText
        textBox1.Text = _lastValidSql
        textBox1.Focus()
    End Sub

    Private Sub menuItemConnectTo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuItemConnectTo.Click
        Using connectionForm = New ConnectionForm()
            If connectionForm.ShowDialog() = DialogResult.OK Then
                Try
                    Dim context = connectionForm.Connection.GetSqlContext()
                    InitializeSqlContext(context)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "@Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub InitializeSqlContext(context As SQLContext)
        Try
            queryBuilder1.Clear()
            queryBuilder1.SQLContext.MetadataContainer.Clear()

            ' setup the query builder with metadata and syntax providers
            queryBuilder1.SQLContext.Assign(context)
            queryBuilder1.MetadataLoadingOptions.OfflineMode = context.MetadataProvider Is Nothing

            ' Instruct the query builder to fill the database schema tree
            queryBuilder1.InitializeDatabaseSchemaTree()
        Finally
            dataGridView1.SqlQuery = queryBuilder1.SQLQuery
        End Try
    End Sub
End Class
