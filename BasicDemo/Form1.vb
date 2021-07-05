//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

Imports GeneralAssembly.Forms.QueryInformationForms
Imports GeneralAssembly.QueryBuilderProperties

Partial Public Class Form1
    Inherits Form
    Private _errorPosition As Integer = -1
    Private _lastValidSql As String

    Public Sub New()
        InitializeComponent()
        ' DEMO WARNING
        If ActiveQueryBuilder.Core.BuildInfo.GetEdition() = ActiveQueryBuilder.Core.BuildInfo.Edition.Trial Then
            Dim trialNoticePanel As Panel = New Panel With {.AutoSize = True, .AutoSizeMode = AutoSizeMode.GrowAndShrink, .BackColor = Color.LightGreen, .BorderStyle = BorderStyle.FixedSingle, .Dock = DockStyle.Top, .Padding = New Padding(6, 5, 3, 0)}

            Dim label As Label = New Label With {.AutoSize = True, .Margin = New Padding(0), .Text = "Generation of random aliases for the query output columns is the limitation of the trial version. The full version is free from this behavior.", .Dock = DockStyle.Fill, .UseCompatibleTextRendering = True}

            Dim buttonClose = New PictureBox With {.Image = GeneralAssembly.My.Resources.cancel, .SizeMode = PictureBoxSizeMode.AutoSize, .Cursor = Cursors.Hand}
            AddHandler buttonClose.Click, Sub() Controls.Remove(trialNoticePanel)

            trialNoticePanel.Controls.Add(buttonClose)

            AddHandler trialNoticePanel.Resize, Sub() buttonClose.Location = New Point(trialNoticePanel.Width - buttonClose.Width - 10, trialNoticePanel.Height \ 2 - buttonClose.Height \ 2)

            trialNoticePanel.Controls.Add(label)
            Controls.Add(trialNoticePanel)

            Controls.SetChildIndex(trialNoticePanel, 2)
        End If

        AddHandler Load, AddressOf Form1_Load
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, e As EventArgs)
        RemoveHandler Load, AddressOf Form1_Load
        queryBuilder1.SyntaxProvider = genericSyntaxProvider1
        queryBuilder1.SQLQuery.QueryRoot.AllowSleepMode = True
    End Sub

    Private Sub refreshMetadataMenuItem_Click(ByVal sender As Object, e As EventArgs) Handles refreshMetadataMenuItem.Click
        ' Force the query builder to refresh metadata from current connection
        ' to refresh metadata, just clear MetadataContainer and reinitialize metadata tree

        If queryBuilder1.MetadataProvider IsNot Nothing AndAlso queryBuilder1.MetadataProvider.Connected Then
            queryBuilder1.ClearMetadata()
            queryBuilder1.InitializeDatabaseSchemaTree()
        End If
    End Sub

    Private Sub editMetadataMenuItem_Click(ByVal sender As Object, e As EventArgs) Handles editMetadataMenuItem.Click
        ' Open the metadata container editor
        QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext)
    End Sub

    Private Sub clearMetadataMenuItem_Click(ByVal sender As Object, e As EventArgs) Handles clearMetadataMenuItem.Click
        ' Clear the metadata
        If MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            queryBuilder1.ClearMetadata()
        End If
    End Sub

    Private Sub loadMetadataFromXMLMenuItem_Click(ByVal sender As Object, e As EventArgs) Handles loadMetadataFromXMLMenuItem.Click
        ' Load metadata from XML file
        If openFileDialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If
        queryBuilder1.MetadataLoadingOptions.OfflineMode = True
        If queryBuilder1.SyntaxProvider Is Nothing Then
            queryBuilder1.SyntaxProvider = genericSyntaxProvider1
        End If
        queryBuilder1.MetadataContainer.ImportFromXML(openFileDialog.FileName)
        queryBuilder1.InitializeDatabaseSchemaTree()
    End Sub

    Private Sub saveMetadataToXMLMenuItem_Click(ByVal sender As Object, e As EventArgs) Handles saveMetadataToXMLMenuItem.Click
        ' Save metadata to XML file
        saveFileDialog.FileName = "Metadata.xml"

        If saveFileDialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        queryBuilder1.MetadataContainer.LoadAll(True)
        queryBuilder1.MetadataContainer.ExportToXML(saveFileDialog.FileName)
    End Sub

    Private Sub aboutMenuItem_Click(ByVal sender As Object, e As EventArgs) Handles aboutMenuItem.Click
        QueryBuilder.ShowAboutDialog()
    End Sub

    Private Sub queryBuilder_SQLUpdated(ByVal sender As Object, e As EventArgs) Handles queryBuilder1.SQLUpdated
        ' Handle the event raised by SQL Builder object that the text of SQL query is changed

        ' Hide error banner if any
        errorBox1.Show(Nothing, queryBuilder1.SyntaxProvider)

        ' update the text box
        textBox1.Text = queryBuilder1.FormattedSQL
        _lastValidSql = textBox1.Text

        ' Try to execute the query using current database connection:

        If tabControl1.SelectedTab Is tabPageData Then
            ExecuteQuery()
        End If
    End Sub

    Public Sub ResetQueryBuilder()
        queryBuilder1.ClearMetadata()
        queryBuilder1.MetadataProvider = Nothing
        queryBuilder1.SyntaxProvider = Nothing
        queryBuilder1.MetadataLoadingOptions.OfflineMode = False
    End Sub

    Private Sub fillProgrammaticallyMenuItem_Click(ByVal sender As Object, e As EventArgs) Handles fillProgrammaticallyMenuItem.Click
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

    Private Sub textBox1_Validating(ByVal sender As Object, e As System.ComponentModel.CancelEventArgs) Handles textBox1.Validating
        Try
            ' Update the query builder with manually edited query text:
            queryBuilder1.SQL = textBox1.Text

            ' Hide error banner if any
            errorBox1.Show(Nothing, queryBuilder1.SyntaxProvider)
        Catch ex As SQLParsingException
            ' Set caret to error position
            textBox1.SelectionStart = ex.ErrorPos.pos
            _errorPosition = ex.ErrorPos.pos

            ' Show banner with error text
            errorBox1.Show(ex.Message, queryBuilder1.SyntaxProvider)
        End Try
    End Sub

    Private Sub tabControl1_Selected(ByVal sender As Object, e As TabControlEventArgs) Handles tabControl1.Selected
        ' Move the input focus to the query builder.
        ' This will fire Leave event in the text box and update the query builder
        ' with modified query text.
        queryBuilder1.Focus()
        Application.DoEvents()

        ' Try to execute the query using current database connection:

        If e.TabPage Is tabPageData Then
            ExecuteQuery()
        End If
    End Sub

    Private Sub ExecuteQuery()
        dataGridView1.FillDataGrid(queryBuilder1.SQL)
    End Sub

    Private _selectedConnection As ConnectionInfo

    Private Sub propertiesMenuItem_Click(ByVal sender As Object, e As EventArgs) Handles propertiesMenuItem.Click
        ' Show Properties form
        Using f As New QueryBuilderPropertiesForm(queryBuilder1)
            f.ShowDialog()
        End Using

        WarnAboutGenericSyntaxProvider() ' show warning (just for demonstration purposes)
    End Sub

    Private Sub queryStatisticsMenuItem_Click(ByVal sender As Object, e As EventArgs) Handles queryStatisticsMenuItem.Click
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
            Dim timer As New Timer()
            AddHandler timer.Tick, AddressOf TimerEvent
            timer.Interval = 10000
            timer.Start()
        End If
    End Sub

    Private Sub TimerEvent(ByVal source As Object, args As EventArgs)
        panel1.Visible = False
        CType(source, Timer).Stop()
        CType(source, Timer).Dispose()
    End Sub

    Private Sub queryBuilder1_QueryAwake(ByVal sender As QueryRoot, ByRef abort As Boolean) Handles queryBuilder1.QueryAwake
        If MessageBox.Show("You had typed something that is not a SELECT statement in the text editor and continued with visual query building." & "Whatever the text in the editor is, it will be replaced with the SQL generated by the component. Is it right?", "Active Query Builder .NET Demo", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    Private Sub queryBuilder1_SleepModeChanged(ByVal sender As Object, e As EventArgs) Handles queryBuilder1.SleepModeChanged
        labelSleepMode.Visible = queryBuilder1.SleepMode
        tabPageData.Enabled = Not queryBuilder1.SleepMode
    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As Object, e As EventArgs) Handles textBox1.TextChanged
        errorBox1.Visible = False
    End Sub

    Private Sub errorBox1_SyntaxProviderChanged(ByVal sender As Object, e As EventArgs) Handles errorBox1.SyntaxProviderChanged
        Dim oldSql = textBox1.Text
        queryBuilder1.SyntaxProvider = errorBox1.CurrentSyntaxProvider
        textBox1.Text = oldSql
        textBox1.SelectionLength = 0
        errorBox1.Visible = False
        textBox1.Focus()
    End Sub

    Private Sub errorBox1_GoToErrorPositionEvent(ByVal sender As Object, e As EventArgs) Handles errorBox1.GoToErrorPosition
        If _errorPosition <> -1 Then
            textBox1.SelectionStart = _errorPosition
            textBox1.SelectionLength = 0
            textBox1.ScrollToCaret()
        End If

        textBox1.Focus()
    End Sub

    Private Sub errorBox1_RevertValidTextEvent(ByVal sender As Object, e As EventArgs) Handles errorBox1.RevertValidText
        textBox1.Text = _lastValidSql
        textBox1.Focus()
    End Sub

    Private Sub ConnectTo_Click(ByVal sender As Object, e As EventArgs) Handles menuItem5.Click
        Dim cf = New ConnectionForm() With {.Owner = Me}

        If cf.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        _selectedConnection = cf.SelectedConnection

        InitializeSqlContext()
    End Sub

    Private Sub InitializeSqlContext()
        Try
            queryBuilder1.Clear()

            Dim metadataProvider As BaseMetadataProvider = Nothing

            If _selectedConnection Is Nothing Then
                Return
            End If

            ' create new SqlConnection object using the connections string from the connection form
            If Not _selectedConnection.IsXmlFile Then
                metadataProvider = _selectedConnection.ConnectionDescriptor?.MetadataProvider
            End If

            ' setup the query builder with metadata and syntax providers
            queryBuilder1.SQLContext.MetadataContainer.Clear()
            queryBuilder1.MetadataProvider = metadataProvider
            queryBuilder1.SyntaxProvider = _selectedConnection.ConnectionDescriptor?.SyntaxProvider
            queryBuilder1.MetadataLoadingOptions.OfflineMode = metadataProvider Is Nothing

            If metadataProvider Is Nothing Then
                queryBuilder1.MetadataContainer.ImportFromXML(_selectedConnection.ConnectionString)
            End If

            ' Instruct the query builder to fill the database schema tree
            queryBuilder1.InitializeDatabaseSchemaTree()

        Finally

            dataGridView1.SqlQuery = queryBuilder1.SQLQuery
        End Try
    End Sub
End Class
