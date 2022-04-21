''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2022 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Globalization
Imports System.IO
Imports ActiveQueryBuilder.Core.QueryTransformer
Imports Helpers = ActiveQueryBuilder.Core.Helpers
Imports BuildInfo = ActiveQueryBuilder.Core.BuildInfo
Imports GeneralAssembly.Forms.QueryInformationForms
Imports GeneralAssembly.Dailogs
Imports GeneralAssembly.QueryBuilderProperties
Imports GeneralAssembly.Forms

Partial Public Class MainForm
    Inherits Form
    Private _errorPosition As Integer = -1
    Private _lastValidSql As String

    Private _selectedConnection As ConnectionInfo
    Private ReadOnly _sqlFormattingOptions As SQLFormattingOptions

    Private _fileSourcePath As String
    Private _oldSql As String
    Private _noConnectionLabel As NoConnectionLabel

    Public Sub New()
        InitializeComponent()

        ' DEMO WARNING
        If BuildInfo.GetEdition() = BuildInfo.Edition.Trial Then
            Dim trialNoticePanel As Panel = New Panel With {.AutoSize = True, .AutoSizeMode = AutoSizeMode.GrowAndShrink, .BackColor = Color.LightGreen, .BorderStyle = BorderStyle.FixedSingle, .Dock = DockStyle.Top, .Padding = New Padding(6, 5, 3, 0)}

            Dim label As Label = New Label With {.AutoSize = True, .Margin = New Padding(0), .Text = "Generation of random aliases for the query output columns is the limitation of the trial version. The full version is free from this behavior.", .Dock = DockStyle.Fill, .UseCompatibleTextRendering = True}

            Dim buttonClose = New PictureBox With {.Image = My.Resources.cancel, .SizeMode = PictureBoxSizeMode.AutoSize, .Cursor = Cursors.Hand}
            AddHandler buttonClose.Click, Sub() Controls.Remove(trialNoticePanel)

            trialNoticePanel.Controls.Add(buttonClose)

            AddHandler trialNoticePanel.Resize, Sub() buttonClose.Location = New Point(trialNoticePanel.Width - buttonClose.Width - 10, trialNoticePanel.Height \ 2 - buttonClose.Height \ 2)

            trialNoticePanel.Controls.Add(label)
            Controls.Add(trialNoticePanel)

            Controls.SetChildIndex(trialNoticePanel, 2)
        End If

        ' Options to present the formatted SQL query text to end-user
        ' Use names of virtual objects, do not replace them with appropriate derived tables
        _sqlFormattingOptions = New SQLFormattingOptions()
        AddHandler _sqlFormattingOptions.Updated, AddressOf _sqlFormattingOptions_Updated

        ' Options to generate the SQL query text for execution against a database server
        ' Replace virtual objects with derived tables
        queryBuilder1.SQLGenerationOptions = New SQLGenerationOptions With {.ExpandVirtualObjects = True}

        If Program.Settings.WindowPlacement = Rectangle.Empty Then
            StartPosition = FormStartPosition.WindowsDefaultLocation
        Else
            Bounds = Program.Settings.WindowPlacement
        End If

        If Program.Settings.IsMaximized Then
            WindowState = FormWindowState.Maximized
        End If

        queryBuilder1.SyntaxProvider = New GenericSyntaxProvider()
        queryBuilder1.SQLQuery.QueryRoot.AllowSleepMode = True
        CBuilder.QueryTransformer = New QueryTransformer With {.Query = queryBuilder1.SQLQuery, .SQLGenerationOptions = _sqlFormattingOptions}
        AddHandler CBuilder.QueryTransformer.SQLUpdated, AddressOf CBuilder_SQLUpdated

        LoadLanguages()

        AddHandler queryBuilder1.SleepModeChanged, AddressOf SqlQuery_SleepModeChanged
        AddHandler queryBuilder1.QueryAwake, AddressOf SqlQuery_QueryAwake
        AddHandler SizeChanged, AddressOf MainForm_SizeChanged
        AddHandler LocationChanged, AddressOf MainForm_LocationChanged
        AddHandler Application.Idle, AddressOf Application_Idle
        UpdateLanguage()

        dataViewer.SqlQuery = queryBuilder1.SQLQuery
        dataViewer.QueryTransformer = CBuilder.QueryTransformer
    End Sub

    Public ReadOnly Property FormattedQueryText As String
        Get
            Return FormattedSQLBuilder.GetSQL(queryBuilder1.SQLQuery.QueryRoot, _sqlFormattingOptions)
        End Get
    End Property

    Private Sub LoadMetadataFromXml()
        Dim fileDialog As OpenFileDialog = New OpenFileDialog With {.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"}
        If fileDialog.ShowDialog() = DialogResult.OK Then
            queryBuilder1.MetadataContainer.LoadingOptions.OfflineMode = True
            queryBuilder1.MetadataContainer.ImportFromXML(fileDialog.FileName)
            queryBuilder1.InitializeDatabaseSchemaTree()
        End If
    End Sub

    Private Sub SaveMetadataToXml()
        Dim fileDialog As SaveFileDialog = New SaveFileDialog With {.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*", .FileName = "Metadata.xml"}
        If fileDialog.ShowDialog() = DialogResult.OK Then
            queryBuilder1.MetadataContainer.LoadAll(True)
            queryBuilder1.MetadataContainer.ExportToXML(fileDialog.FileName)
        End If
    End Sub

    Public Sub UpdateLanguage()
        queryBuilder1.Language = Program.Settings.Language
        tsbQueryProperties.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strEdit", "Properties")
        tsbAddObject.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAddObject", "Add object")
        tsbAddDerivedTable.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAddSubQuery", "Add derived table")
        tsbAddUnionSubquery.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strNewUnionSubQuery", "New union sub-query")
        tsbCopyUnionSubquery.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strCopyToNewUnionSubQuery", "Copy union sub-query")
    End Sub

    Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If (Not Equals(queryBuilder1.MetadataProvider, Nothing)) Then
                queryBuilder1.MetadataProvider.Connection.Close()
                RemoveHandler Application.Idle, AddressOf Application_Idle
                components?.Dispose()
            End If
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub LoadLanguages()
        For Each language As String In Helpers.Localizer.Languages
            Dim lang As String = language.ToLower()
            Dim menuItem As ToolStripItem
            If lang = "auto" Then
                menuItem = tsmiLanguageAuto
            ElseIf lang = "default" Then
                menuItem = tsmiLanguageDefault
            Else
                Dim culture As CultureInfo = CultureInfo.GetCultureInfo(lang)
                menuItem = languageToolStripMenuItem.DropDownItems.Add(culture.NativeName, Nothing, AddressOf Language_Click)
                menuItem.Tag = lang
            End If
            If String.Equals(TryCast(menuItem.Tag, String), Program.Settings.Language, StringComparison.OrdinalIgnoreCase) Then
                CType(menuItem, ToolStripMenuItem).Checked = True
            End If
        Next language
    End Sub

    Private Sub InitializeSqlContext()
        Try
            Cursor = Cursors.WaitCursor

            Dim metadataProvider As BaseMetadataProvider = Nothing
            Dim syntaxSyntaxProvider As BaseSyntaxProvider

            ' create new SqlConnection object using the connections string from the connection form
            If Not _selectedConnection.IsXmlFile Then
                syntaxSyntaxProvider = _selectedConnection.ConnectionDescriptor.SyntaxProvider
                metadataProvider = _selectedConnection.ConnectionDescriptor.MetadataProvider
            Else
                Select Case _selectedConnection.Type
                    Case ConnectionTypes.MSSQL
                        syntaxSyntaxProvider = New MSSQLSyntaxProvider()
                    Case ConnectionTypes.MSAccess
                        syntaxSyntaxProvider = New MSAccessSyntaxProvider()
                    Case ConnectionTypes.Oracle
                        syntaxSyntaxProvider = New OracleSyntaxProvider()
                    Case ConnectionTypes.MySQL
                        syntaxSyntaxProvider = New MySQLSyntaxProvider()
                    Case ConnectionTypes.PostgreSQL
                        syntaxSyntaxProvider = New PostgreSQLSyntaxProvider()
                    Case ConnectionTypes.OLEDB
                        syntaxSyntaxProvider = New SQL92SyntaxProvider()
                    Case ConnectionTypes.ODBC
                        syntaxSyntaxProvider = New SQL92SyntaxProvider()
                    Case Else
                        Throw New ArgumentOutOfRangeException()
                End Select
            End If

            ' setup the query builder with metadata and syntax providers
            queryBuilder1.SQLContext.MetadataContainer.Clear()
            queryBuilder1.MetadataProvider = metadataProvider
            queryBuilder1.SyntaxProvider = syntaxSyntaxProvider
            queryBuilder1.MetadataLoadingOptions.OfflineMode = metadataProvider Is Nothing

            If metadataProvider Is Nothing Then
                queryBuilder1.MetadataContainer.ImportFromXML(_selectedConnection.ConnectionString)
            End If

            ' Instruct the query builder to fill the database schema tree
            queryBuilder1.InitializeDatabaseSchemaTree()

            toolStripStatusLabel1.Text = "Query builder state: " & (If(queryBuilder1.SleepMode, "Inactive", "Active"))
            RepairImageLists()
            RefreshNoConnectionLabel()
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Public ReadOnly Property CanAddUnionSubQuery() As Boolean
        Get
            If queryBuilder1.ActiveUnionSubQuery IsNot Nothing AndAlso queryBuilder1.ActiveUnionSubQuery.QueryRoot.IsSubQuery Then
                Return queryBuilder1.SyntaxProvider.IsSupportSubQueryUnions()
            End If
            Return queryBuilder1.SyntaxProvider IsNot Nothing AndAlso queryBuilder1.SyntaxProvider.IsSupportUnions()
        End Get
    End Property

    Public ReadOnly Property CanCopyUnionSubQuery As Boolean
        Get
            Return CanAddUnionSubQuery
        End Get
    End Property

    Public ReadOnly Property CanAddDerivedTable() As Boolean
        Get
            If queryBuilder1.SyntaxProvider Is Nothing Then
                Return False
            End If
            If queryBuilder1.ActiveUnionSubQuery IsNot Nothing AndAlso queryBuilder1.ActiveUnionSubQuery.QueryRoot.IsMainQuery Then
                Return queryBuilder1.SyntaxProvider.IsSupportDerivedTables()
            End If
            Return queryBuilder1.SyntaxProvider IsNot Nothing AndAlso queryBuilder1.SyntaxProvider.IsSupportSubQueryDerivedTables()
        End Get
    End Property

    Private ReadOnly Property CanAddObject As Boolean
        Get
            Return queryBuilder1.AddObjectDialog IsNot Nothing
        End Get
    End Property

    ' Workaround for the old Microsoft's bug: ImageList damages the alpha channel of 32-bit ICO and PNG files.
    ' Clear all images from designed image lists and reload all images manually.
    Private Sub RepairImageLists()
        imageList1.Images.Clear()
        imageList1.Images.Add(My.Resources.bricks)
        imageList1.Images.Add(My.Resources.database_go)
    End Sub

    Private Sub Language_Click(sender As Object, e As EventArgs)
        Dim currentItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If currentItem Is Nothing OrElse Equals(currentItem.Tag, Helpers.Localizer.Language) Then
            Return
        End If
        Dim checkedItem As ToolStripMenuItem = languageToolStripMenuItem.DropDownItems.OfType(Of ToolStripMenuItem)().FirstOrDefault(Function(item) item.Checked)
        If checkedItem IsNot Nothing Then
            checkedItem.Checked = False
        End If
        Program.Settings.Language = CStr(currentItem.Tag)
        UpdateLanguage()
        currentItem.Checked = True
    End Sub

    Private Sub Application_Idle(sender As Object, e As EventArgs)
        tsmiParseQuery.Enabled = True
        tsmiUndo.Enabled = CanUndo
        tsmiRedo.Enabled = CanRedo
        tsmiCut.Enabled = CanCut
        tsmiCopy.Enabled = CanCopy
        tsmiPaste.Enabled = CanPaste
        tsmiSelectAll.Enabled = CanSelectAll
        tsbCut.Enabled = CanCut
        tsbCopy.Enabled = CanCopy
        tsbPaste.Enabled = CanPaste

        'editUserExpressionToolStripMenuItem.Enabled = queryBuilder1.SyntaxProvider != null;

        tsmiSave.Enabled = True
        tsmiBuildQuery.Enabled = True
        tsmiRunQuery.Enabled = True
        tsmiQueryStatistics.Enabled = True
        newQueryToolStripMenuItem1.Enabled = queryBuilder1.SQLContext IsNot Nothing
        toolStripButtonNewQuery.Enabled = newQueryToolStripMenuItem1.Enabled
        tsbQueryProperties.Enabled = queryBuilder1.SQLContext IsNot Nothing
        tsbSave.Enabled = queryBuilder1.SQLContext IsNot Nothing
        tsbAddObject.Enabled = queryBuilder1.SQLContext IsNot Nothing
        tsbSaveInFile.Enabled = queryBuilder1.SQLContext IsNot Nothing
        tabControl1.Enabled = queryBuilder1.SQLContext IsNot Nothing
        tsmiOfflineMode.Enabled = True
        tsmiOfflineMode.Checked = queryBuilder1.SQLContext Is Nothing OrElse queryBuilder1.MetadataContainer.LoadingOptions.OfflineMode
        tsmiRefreshMetadata.Enabled = True
        tsmiEditMetadata.Enabled = True
        tsmiClearMetadata.Enabled = True
        tsmiLoadMetadataFromXML.Enabled = True
        tsmiSaveMetadataToXML.Enabled = True

        addDerivedTableToolStripMenuItem.Enabled = CanAddDerivedTable
        addObjectToolStripMenuItem.Enabled = CanAddObject
        addUnionSubqueryToolStripMenuItem.Enabled = CanAddUnionSubQuery
        copyUnionSubwueryToolStripMenuItem.Enabled = CanCopyUnionSubQuery

        tsbEditMetadata.Enabled = queryBuilder1.SQLContext IsNot Nothing AndAlso queryBuilder1.MetadataContainer IsNot Nothing

        Dim supportsDerivedTable As Boolean = False
        Dim supportsUnion As Boolean = False

        If queryBuilder1.ActiveUnionSubQuery IsNot Nothing AndAlso queryBuilder1.SQLContext IsNot Nothing AndAlso queryBuilder1.SyntaxProvider IsNot Nothing Then
            supportsDerivedTable = If(queryBuilder1.ActiveUnionSubQuery.QueryRoot.IsMainQuery, queryBuilder1.SyntaxProvider.IsSupportDerivedTables(), queryBuilder1.SyntaxProvider.IsSupportSubQueryDerivedTables())
            supportsUnion = If(queryBuilder1.ActiveUnionSubQuery.QueryRoot.IsSubQuery, queryBuilder1.SyntaxProvider.IsSupportSubQueryUnions(), queryBuilder1.SyntaxProvider.IsSupportUnions())
        End If
        tsbAddDerivedTable.Enabled = supportsDerivedTable
        tsbAddUnionSubquery.Enabled = supportsUnion
        tsbCopyUnionSubquery.Enabled = supportsUnion
    End Sub

    Private Sub SqlQuery_QueryAwake(sender As QueryRoot, ByRef abort As Boolean)
        If MessageBox.Show("You had typed something that is not a SELECT statement in the text editor and continued with visual query building." & "Whatever the text in the editor is, it will be replaced with the SQL generated by the component. Is it right?", "Active Query Builder .NET Demo", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    Private Sub SqlQuery_SleepModeChanged(sender As Object, e As EventArgs)
        panelSleepMode.Visible = queryBuilder1.SleepMode
        toolStripStatusLabel1.Text = "Query builder state: " & (If(queryBuilder1.SleepMode, "Inactive", "Active"))
    End Sub

    Private Sub CBuilder_SQLUpdated(sender As Object, e As EventArgs)
        ' Handle the event raised by Criteria Builder object that the text of SQL query is changed
        ' update the text box
        If tabControl1.SelectedTab IsNot pageQueryResult Then
            Return
        End If
        Try
            Dim sql As String = CBuilder.SQL
            teResultSql.Text = sql
            ExecuteQuery(sql)
        Catch exception As Exception
            MessageBox.Show(exception.Message)
        End Try
    End Sub

    Private Sub tsmiNew_Click(sender As Object, e As EventArgs) Handles tsmiNew.Click, tsbNew.Click
        Dim query As String = queryBuilder1.SQL
        If Connect() Then
            Clear()
            queryBuilder1.SQL = query
        End If
    End Sub

    Private Function Connect() As Boolean
        queryBuilder1.QueryView.HideInformationMessage()

        Using cf As New ConnectionForm()
            If cf.ShowDialog() = DialogResult.OK Then
                Try
                    Cursor = Cursors.WaitCursor
                    _selectedConnection = cf.SelectedConnection
                    InitializeSqlContext()
                    Return True
                Finally
                    Cursor = Cursors.Default
                End Try
            End If
        End Using
        Return False
    End Function

    Private Sub tsmiOpen_Click(sender As Object, e As EventArgs) Handles tsmiOpen.Click, tsbOpen.Click
        ' open a saved query
        If Not TrySave() Then
            Return
        End If
        If (_selectedConnection Is Nothing AndAlso (Not Connect())) OrElse openFileDialog1.ShowDialog() <> DialogResult.OK Then
            Return
        End If
        Dim sb As New StringBuilder()
        Using sr As New StreamReader(openFileDialog1.FileName)
            Dim s As String
            s = sr.ReadLine()
            Do While s IsNot Nothing
                sb.AppendLine(s)
                s = sr.ReadLine()
            Loop
        End Using
        _fileSourcePath = openFileDialog1.FileName

        ' load query to the query builder by assigning its text to the SQL property
        queryBuilder1.SQL = sb.ToString()
        _oldSql = FormattedQueryText
    End Sub

    Private Sub tsmiSave_Click(sender As Object, e As EventArgs) Handles tsmiSave.Click, tsbSave.Click
        Dim path As String = SaveInFile(_fileSourcePath)
        If path IsNot Nothing Then
            _fileSourcePath = path
        End If
    End Sub

    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        Close()
    End Sub

    Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs)
        If WindowState <> FormWindowState.Maximized Then
            Program.Settings.WindowPlacement = Bounds
        End If
    End Sub

    Private Sub MainForm_SizeChanged(sender As Object, e As EventArgs)
        If Program.Settings.IsMaximized <> (WindowState = FormWindowState.Maximized) Then
            Program.Settings.IsMaximized = (WindowState = FormWindowState.Maximized)
        End If

        If Not Program.Settings.IsMaximized Then
            Program.Settings.WindowPlacement = Bounds
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not TrySave() Then
            e.Cancel = True
        End If
    End Sub

    Private Sub tsmiBuildQuery_Click(sender As Object, e As EventArgs) Handles tsmiBuildQuery.Click
        tabControl1.SelectTab(0)
        teSql.Focus()
    End Sub

    Private Sub tsmiRunQuery_Click(sender As Object, e As EventArgs) Handles tsmiRunQuery.Click
        tabControl1.SelectTab(1)
    End Sub

    Private Sub tsmiQueryStatistics_Click(sender As Object, e As EventArgs) Handles tsmiQueryStatistics.Click
        Dim qs As QueryStatistics = queryBuilder1.QueryStatistics

        Dim stats As String = "Used Objects (" & qs.UsedDatabaseObjects.Count & "):" & vbCrLf
        stats = qs.UsedDatabaseObjects.Aggregate(stats, Function(current, t) current + (vbCrLf & t.ObjectName.QualifiedName))

        stats &= vbCrLf & vbCrLf & "Used Columns (" & qs.UsedDatabaseObjectFields.Count & "):" & vbCrLf
        stats = qs.UsedDatabaseObjectFields.Aggregate(stats, Function(current, t) current + (vbCrLf & t.ObjectName.QualifiedName))

        stats &= vbCrLf & vbCrLf & "Output Expressions (" & qs.OutputColumns.Count & "):" & vbCrLf
        stats = qs.OutputColumns.Aggregate(stats, Function(current, t) current + (vbCrLf & t.Expression))

        Using f As New QueryStatisticsForm()
            f.textBox.Text = stats
            f.ShowDialog()
        End Using
    End Sub

    Private Sub tsmiAbout_Click(sender As Object, e As EventArgs) Handles tsmiAbout.Click, tsbAbout.Click
        Using f As New Forms.AboutForm()
            f.ShowDialog()
        End Using
    End Sub

    Public Sub Undo()
        teSql.Undo()
    End Sub

    Public Sub Redo()
        teSql.Undo()
    End Sub

    Public Sub Cut()
        teSql.Cut()
    End Sub

    Public Sub Copy()
        teSql.Copy()
    End Sub

    Public Sub Paste()
        teSql.Paste()
    End Sub

    Public Sub SelectAll()
        teSql.SelectAll()
    End Sub

    Public ReadOnly Property CanCopy() As Boolean
        Get
            If teSql.ContainsFocus Then
                If teSql.SelectionLength > 0 Then
                    Return True
                End If
            End If
            Return False
        End Get
    End Property

    Public ReadOnly Property CanCut() As Boolean
        Get
            If teSql.ContainsFocus Then
                If Not String.IsNullOrEmpty(teSql.SelectedText) Then
                    Return True
                End If
            End If
            Return False
        End Get
    End Property

    Public ReadOnly Property CanPaste() As Boolean
        Get
            If teSql.ContainsFocus Then
                Return Clipboard.ContainsText()
            End If
            Return False
        End Get
    End Property

    Public ReadOnly Property CanUndo() As Boolean
        Get
            If teSql.ContainsFocus Then
                Return teSql.CanUndo
            End If
            Return False
        End Get
    End Property

    Public ReadOnly Property CanRedo() As Boolean
        Get
            If teSql.ContainsFocus Then
                Return teSql.CanRedo
            End If
            Return False
        End Get
    End Property

    Public ReadOnly Property CanSelectAll() As Boolean
        Get
            Return teSql.ContainsFocus AndAlso teSql.TextLength > 0
        End Get
    End Property

    Private Sub tsmiUndo_Click(sender As Object, e As EventArgs) Handles tsmiUndo.Click
        Undo()
    End Sub

    Private Sub tsmiRedo_Click(sender As Object, e As EventArgs) Handles tsmiRedo.Click
        Redo()
    End Sub

    Private Sub tsmiCut_Click(sender As Object, e As EventArgs) Handles tsmiCut.Click, tsbCut.Click
        Cut()
    End Sub

    Private Sub tsmiCopy_Click(sender As Object, e As EventArgs) Handles tsmiCopy.Click, tsbCopy.Click
        Copy()
    End Sub

    Private Sub tsmiPaste_Click(sender As Object, e As EventArgs) Handles tsmiPaste.Click, tsbPaste.Click
        Paste()
    End Sub

    Private Sub tsmiSelectAll_Click(sender As Object, e As EventArgs) Handles tsmiSelectAll.Click
        SelectAll()
    End Sub

    Private Sub tsmiOfflineMode_Click(sender As Object, e As EventArgs) Handles tsmiOfflineMode.Click
        If tsmiOfflineMode.Checked Then
            Try
                Cursor = Cursors.WaitCursor

                queryBuilder1.MetadataContainer.LoadAll(True)
            Finally
                Cursor = Cursors.Arrow
            End Try
        End If

        queryBuilder1.MetadataContainer.LoadingOptions.OfflineMode = tsmiOfflineMode.Checked
    End Sub

    Private Sub tsmiRefreshMetadata_Click(sender As Object, e As EventArgs) Handles tsmiRefreshMetadata.Click
        If queryBuilder1.MetadataProvider IsNot Nothing AndAlso queryBuilder1.MetadataProvider.Connected Then
            ' Force the query builder to refresh metadata from current connection
            ' to refresh metadata, just clear MetadataContainer and reinitialize metadata tree
            queryBuilder1.MetadataContainer.Clear()
            queryBuilder1.InitializeDatabaseSchemaTree()
        End If
    End Sub

    Private Sub tsmiEditMetadata_Click(sender As Object, e As EventArgs) Handles tsmiEditMetadata.Click
        QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext)
    End Sub

    Private Sub tsmiClearMetadata_Click(sender As Object, e As EventArgs) Handles tsmiClearMetadata.Click
        queryBuilder1.MetadataContainer.Clear()
    End Sub

    Private Sub tsmiLoadMetadataFromXML_Click(sender As Object, e As EventArgs) Handles tsmiLoadMetadataFromXML.Click
        LoadMetadataFromXml()
    End Sub

    Private Sub tsmiSaveMetadataToXML_Click(sender As Object, e As EventArgs) Handles tsmiSaveMetadataToXML.Click
        SaveMetadataToXml()
    End Sub

    Private Sub tsmiLanguageAuto_Click(sender As Object, e As EventArgs) Handles tsmiLanguageAuto.Click
        Program.Settings.Language = "Auto"
        UpdateLanguage()
    End Sub

    Private Sub tsmiLanguageDefault_Click(sender As Object, e As EventArgs) Handles tsmiLanguageDefault.Click
        Program.Settings.Language = "Default"
        UpdateLanguage()
    End Sub

    Private Sub newQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles newQueryToolStripMenuItem1.Click, toolStripButtonNewQuery.Click
        Clear()
    End Sub

    Private Sub Clear()
        If Not TrySave() Then
            Return
        End If
        queryBuilder1.SQL = ""
        _oldSql = Nothing
        _fileSourcePath = Nothing
    End Sub

    Private Function TrySave() As Boolean
        If _oldSql IsNot Nothing AndAlso _oldSql <> FormattedQueryText Then
            Dim dialog As New SaveDialogForm(If(_fileSourcePath, "new file"))
            If dialog.ShowDialog() <> DialogResult.OK Then
                Return False
            End If
            If dialog.Save Then
                SaveInFile(_fileSourcePath)
            End If
        End If
        Return True
    End Function

    Private Function SaveInFile(path As String) As String
        ' Save the query text to file
        If path IsNot Nothing AndAlso FormattedQueryText = _oldSql Then
            Return path
        End If
        If String.IsNullOrEmpty(path) Then
            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog With {.DefaultExt = "sql", .FileName = "query", .Filter = "SQL query files (*.sql)|*.sql|All files|*.*"}
            If saveFileDialog.ShowDialog() <> DialogResult.OK Then
                Return path
            End If
            path = saveFileDialog.FileName
        End If
        Using sw As New StreamWriter(path)
            sw.Write(FormattedQueryText)
            _oldSql = FormattedQueryText
        End Using
        Return path
    End Function

    Private Sub addDerivedTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addDerivedTableToolStripMenuItem.Click
        tsbAddDerivedTable_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub tsbAddDerivedTable_Click(sender As Object, e As EventArgs) Handles tsbAddDerivedTable.Click
        Using TempUpdateRegion As UpdateRegion = New UpdateRegion(queryBuilder1.ActiveUnionSubQuery.FromClause)
            Dim sqlContext = queryBuilder1.ActiveUnionSubQuery.SQLContext

            Dim fq = New SQLFromQuery(sqlContext) With {.Alias = New SQLAliasObjectAlias(sqlContext) With {.Alias = queryBuilder1.ActiveUnionSubQuery.QueryRoot.CreateUniqueSubQueryName()}, .SubQuery = New SQLSubSelectStatement(sqlContext)}

            Dim sqse = New SQLSubQuerySelectExpression(sqlContext)
            fq.SubQuery.Add(sqse)
            sqse.SelectItems = New SQLSelectItems(sqlContext)
            sqse.From = New SQLFromClause(sqlContext)
            queryBuilder1.SQLQuery.AddObject(queryBuilder1.ActiveUnionSubQuery, fq, GetType(DataSourceQuery))
        End Using
    End Sub

    Private Sub tsbAddObject_Click(sender As Object, e As EventArgs) Handles addObjectToolStripMenuItem.Click, tsbAddObject.Click
        If queryBuilder1.AddObjectDialog IsNot Nothing Then
            queryBuilder1.AddObjectDialog.ShowModal()
        End If
    End Sub

    Private Sub tsbQueryProperties_Click(sender As Object, e As EventArgs) Handles queryPropertiesToolStripMenuItem.Click, tsbQueryProperties.Click
        queryBuilder1.ShowActiveUnionSubQueryProperties()
    End Sub

    Private Sub tsbCopyUnionSubquery_Click(sender As Object, e As EventArgs) Handles copyUnionSubwueryToolStripMenuItem.Click, tsbCopyUnionSubquery.Click
        ' add empty UnionSubQuery
        Dim usq As UnionSubQuery = queryBuilder1.ActiveUnionSubQuery.ParentGroup.Add()

        ' copy the content of existing union sub-query to a new one
        Dim usqAst As SQLSubQuerySelectExpression = queryBuilder1.ActiveUnionSubQuery.ResultQueryAST
        usqAst.RestoreColumnPrefixRecursive(True)

        Dim lCte As New List(Of SQLWithClauseItem)()
        Dim lFromObj As New List(Of SQLFromSource)()
        queryBuilder1.ActiveUnionSubQuery.GatherPrepareAndFixupContext(lCte, lFromObj, False)
        usqAst.PrepareAndFixupRecursive(lCte, lFromObj)

        usq.LoadFromAST(usqAst)
        queryBuilder1.ActiveUnionSubQuery = usq
    End Sub

    Private Sub addUnionSubQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addUnionSubqueryToolStripMenuItem.Click
        queryBuilder1.ActiveUnionSubQuery = queryBuilder1.ActiveUnionSubQuery.ParentGroup.Add()
    End Sub

    Private Sub propertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles propertiesToolStripMenuItem.Click
        Dim propWindow = New QueryBuilderPropertiesForm(queryBuilder1)
        propWindow.ShowDialog()
    End Sub

    Private Sub tsbEditMetadata_Click(sender As Object, e As EventArgs) Handles tsbEditMetadata.Click
        QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext)
    End Sub

    Private Sub tsbSaveInFile_Click(sender As Object, e As EventArgs) Handles tsmiSaveAs.Click, tsbSaveInFile.Click
        Dim path As String = SaveInFile(Nothing)
        If path IsNot Nothing Then
            _fileSourcePath = path
        End If
    End Sub

    Private Sub tsbAddUnionSubquery_Click(sender As Object, e As EventArgs) Handles tsbAddUnionSubquery.Click
        queryBuilder1.ActiveUnionSubQuery = queryBuilder1.ActiveUnionSubQuery.ParentGroup.Add()
    End Sub

    Private Sub queryBuilder1_SQLUpdated(sender As Object, e As EventArgs) Handles queryBuilder1.SQLUpdated
        errorBox1.Show(Nothing, queryBuilder1.SyntaxProvider)
        teSql.Text = If(queryBuilder1.SleepMode, queryBuilder1.SQL, FormattedQueryText)
        _lastValidSql = teSql.Text
    End Sub

    Private Sub _sqlFormattingOptions_Updated(sender As Object, e As EventArgs)
        teSql.Text = FormattedQueryText
    End Sub

    Private Sub contextMenuStripForRichTextBox_Opening(sender As Object, e As CancelEventArgs) Handles contextMenuStripForRichTextBox.Opening
        tsmiUndo.Enabled = CanUndo
        tsmiRedo.Enabled = CanRedo
        tsmiCut.Enabled = CanCut
        tsmiCopy.Enabled = CanCopy
        tsmiPaste.Enabled = CanPaste
        tsmiSelectAll.Enabled = CanSelectAll
    End Sub

    Private Sub teQbSql_Validating(sender As Object, e As CancelEventArgs) Handles teSql.Validating
        Try
            ' Update the query builder with manually edited query text:
            queryBuilder1.SQL = teSql.Text
            errorBox1.Show(Nothing, queryBuilder1.SyntaxProvider)
        Catch ex As SQLParsingException
            ' Set caret to error position
            teSql.SelectionStart = ex.ErrorPos.pos
            _errorPosition = teSql.SelectionStart

            ' Show banner with error text
            errorBox1.Show(ex.Message, queryBuilder1.SyntaxProvider)
        End Try
    End Sub

    Private Sub tsmiParseQuery_Click(sender As Object, e As EventArgs) Handles tsmiParseQuery.Click
        Try
            queryBuilder1.SQL = teSql.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RefreshNoConnectionLabel()
        If _selectedConnection IsNot Nothing Then
            If _noConnectionLabel IsNot Nothing Then
                RemoveHandler dataViewer.SizeChanged, AddressOf DataViewerSizeChanged
                _noConnectionLabel.Parent = Nothing
                _noConnectionLabel = Nothing
            End If
        ElseIf _noConnectionLabel Is Nothing Then
            _noConnectionLabel = New NoConnectionLabel()
            AddHandler dataViewer.SizeChanged, AddressOf DataViewerSizeChanged
            dataViewer.Controls.Add(_noConnectionLabel)
        End If
    End Sub

    Private Sub tabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tabControl1.Selecting
        ' Execute a query on switching to the Data tab
        If e.TabPage IsNot pageQueryResult Then
            Return
        End If

        CBuilder.Clear()

        teResultSql.Text = queryBuilder1.FormattedSQL
        ExecuteQuery(queryBuilder1.FormattedSQL)
        RefreshNoConnectionLabel()
    End Sub

    Private Sub ExecuteQuery(sql As String)
        dataViewer.FillDataGrid(sql)
    End Sub

    Private Sub DataViewerSizeChanged(sender As Object, e As EventArgs)
        Dim parent As Control = CType(sender, Control)
        Dim x As Integer = parent.Width \ 2 - _noConnectionLabel.Width \ 2
        Dim y As Integer = parent.Height \ 2 - _noConnectionLabel.Height \ 2
        _noConnectionLabel.Location = New Point(If(x > 0, x, 0), If(y > 0, y, 0))
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Connect()
    End Sub

    Private Sub errorBox1_GoToErrorPosition(sender As Object, e As EventArgs) Handles errorBox1.GoToErrorPosition
        If _errorPosition <> -1 Then
            teSql.SelectionStart = _errorPosition
            teSql.SelectionLength = 0
            teSql.ScrollToCaret()
        End If

        teSql.Focus()
    End Sub

    Private Sub errorBox1_RevertValidText(sender As Object, e As EventArgs) Handles errorBox1.RevertValidText
        teSql.Text = _lastValidSql
        teSql.Focus()
    End Sub

    Private Sub editUserExpressionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPredefinedConditionsToolStripMenuItem.Click
        Using form As EditUserPredefinedConditionForm = New EditUserPredefinedConditionForm()
            form.LoadUserConditions(queryBuilder1.QueryView)
            form.StartPosition = FormStartPosition.CenterParent
            form.ShowDialog(Me)
        End Using
    End Sub
End Class
