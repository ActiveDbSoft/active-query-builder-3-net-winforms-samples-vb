'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.ComponentModel
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.QueryTransformer
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.ExpressionEditor
Imports ActiveQueryBuilder.View.QueryView
Imports ActiveQueryBuilder.View.WinForms
Imports ActiveQueryBuilder.View.WinForms.ExpressionEditor
Imports ActiveQueryBuilder.View.WinForms.QueryView
Imports Common
Imports Dailogs
Imports Forms.QueryInformationForms
Imports FullFeaturedMdiDemo.Common
Imports Reports


Partial Public Class ChildForm
    Inherits Form
    Public Enum SourceType
        File
        [New]
        UserQuery
    End Enum

    Private _errorPosition As Integer = -1
    Private _lastValidSql As String

    Private _errorPositionCurrent As Integer = -1
    Private _lastValidSqlCurrent As String

    Private ReadOnly _queryTransformerTop10 As QueryTransformer
    Private ReadOnly _timerForFastResult As Timer

    Private ReadOnly _sqlContext As SQLContext
    Private ReadOnly _connectionInfo As ConnectionInfo
    Private _sqlFormattingOptions As SQLFormattingOptions
    Private _noConnectionLabel As NoConnectionLabel

    Public Event SaveQueryEvent As CancelEventHandler
    Public Event SaveAsInFileEvent As CancelEventHandler
    Public Event SaveAsNewUserQueryEvent As CancelEventHandler

    Public Property SqlSourceType() As SourceType
    Public Property FileSourcePath() As String
    Public Property UserMetadataStructureItem() As MetadataStructureItem

    Public ReadOnly Property QueryView As QueryView
        Get
            Return QView
        End Get
    End Property

    Public Property MetadataLoadingOptions() As MetadataLoadingOptions
        Get
            Return _sqlContext.LoadingOptions
        End Get
        Set(value As MetadataLoadingOptions)
            _sqlContext.LoadingOptions = value
        End Set
    End Property

    Public Property MetadataStructureOptions() As MetadataStructureOptions
        Get
            Return _sqlContext.MetadataStructureOptions
        End Get
        Set(value As MetadataStructureOptions)
            _sqlContext.MetadataStructureOptions = value
        End Set
    End Property

    Public Property SqlFormattingOptions() As SQLFormattingOptions
        Set(value As SQLFormattingOptions)
            If _sqlFormattingOptions IsNot Nothing Then
                RemoveHandler _sqlFormattingOptions.Updated, AddressOf _sqlFormattingOptions_Updated
            End If

            _sqlFormattingOptions = value

            If _sqlFormattingOptions IsNot Nothing Then
                AddHandler _sqlFormattingOptions.Updated, AddressOf _sqlFormattingOptions_Updated
            End If
            CBuilder.QueryTransformer.SQLGenerationOptions = _sqlFormattingOptions
        End Set
        Get
            Return _sqlFormattingOptions
        End Get
    End Property

    Public Property SqlGenerationOptions() As SQLGenerationOptions
        Get
            Return QueryView.SQLGenerationOptions
        End Get
        Set(value As SQLGenerationOptions)
            QueryView.SQLGenerationOptions = value
        End Set
    End Property

    Public Property BehaviorOptions() As BehaviorOptions
        Get
            Return SqlQuery.BehaviorOptions
        End Get
        Set(value As BehaviorOptions)
            SqlQuery.BehaviorOptions = value
        End Set
    End Property

    Public Property ExpressionEditorOptions() As ExpressionEditorOptions
        Get
            Return expressionEditor1.Options
        End Get
        Set(value As ExpressionEditorOptions)
            expressionEditor1.Options = value
        End Set
    End Property

    Public Property TextEditorOptions() As TextEditorOptions
        Get
            Return rtbQueryText.Options
        End Get
        Set(value As TextEditorOptions)
            expressionEditor1.TextEditorOptions = value
            rtbQueryText.Options = value
            TextBoxCurrentSubQuerySql.Options = value
        End Set
    End Property

    Public Property TextEditorSqlOptions() As SqlTextEditorOptions
        Get
            Return rtbQueryText.SqlOptions
        End Get
        Set(value As SqlTextEditorOptions)
            expressionEditor1.TextEditorSqlOptions = value
            rtbQueryText.SqlOptions = value
            TextBoxCurrentSubQuerySql.SqlOptions = value
        End Set
    End Property

    Public Property DataSourceOptions() As DataSourceOptions
        Get
            Return CType(designPaneControl1.DataSourceOptions, DataSourceOptions)
        End Get
        Set(value As DataSourceOptions)
            designPaneControl1.DataSourceOptions = value
        End Set
    End Property

    Public Property DesignPaneOptions() As DesignPaneOptions
        Get
            Return designPaneControl1.Options
        End Get
        Set(value As DesignPaneOptions)
            designPaneControl1.Options = value
        End Set
    End Property

    Public Property QueryNavBarOptions() As QueryNavBarOptions
        Get
            Return NavBar.Options
        End Get
        Set(value As QueryNavBarOptions)
            NavBar.Options.Assign(value)
            subQueryNavBar1.Options.Assign(CType(NavBar.Options, IQueryNavigationBarOptions))
        End Set
    End Property

    Public Property AddObjectDialogOptions() As AddObjectDialogOptions
        Get
            Return addObjectDialog1.Options
        End Get
        Set(value As AddObjectDialogOptions)
            addObjectDialog1.Options = value
        End Set
    End Property

    Public Property UserInterfaceOptions() As UserInterfaceOptions
        Get
            Return QView.UserInterfaceOptions
        End Get
        Set(value As UserInterfaceOptions)
            QView.UserInterfaceOptions = value
        End Set
    End Property

    Public Property VisualOptions() As VisualOptions
        Get
            Return dockManager1.Options
        End Get
        Set(value As VisualOptions)
            dockManager1.Options = value
        End Set
    End Property

    Public Property QueryColumnListOptions() As QueryColumnListOptions
        Get
            Return queryColumnListControl1.Options
        End Get
        Set(value As QueryColumnListOptions)
            queryColumnListControl1.Options = value
        End Set
    End Property

    Public ReadOnly Property SqlQuery() As SQLQuery

    Public ReadOnly Property MainForm As MainForm
        Get
            Return TryCast(MdiParent, MainForm)
        End Get
    End Property

    Public Function GetOptions() As Options
        Return New Options With {.AddObjectDialogOptions = AddObjectDialogOptions, .BehaviorOptions = BehaviorOptions, .DatabaseSchemaViewOptions = MainForm.DBView.Options, .DataSourceOptions = DataSourceOptions, .DesignPaneOptions = DesignPaneOptions, .ExpressionEditorOptions = ExpressionEditorOptions, .QueryColumnListOptions = QueryColumnListOptions, .QueryNavBarOptions = QueryNavBarOptions, .SqlFormattingOptions = SqlFormattingOptions, .SqlGenerationOptions = SqlGenerationOptions, .TextEditorOptions = TextEditorOptions, .TextEditorSqlOptions = TextEditorSqlOptions, .UserInterfaceOptions = UserInterfaceOptions, .VisualOptions = VisualOptions}
    End Function

    Public Sub SetOptions(options As Options)
        AddObjectDialogOptions.Assign(options.AddObjectDialogOptions)
        BehaviorOptions.Assign(options.BehaviorOptions)
        MainForm.DBView.Options.Assign(options.DatabaseSchemaViewOptions)
        DataSourceOptions.Assign(options.DataSourceOptions)
        DesignPaneOptions.Assign(options.DesignPaneOptions)
        ExpressionEditorOptions.Assign(options.ExpressionEditorOptions)
        QueryColumnListOptions.Assign(options.QueryColumnListOptions)
        QueryNavBarOptions.Assign(options.QueryNavBarOptions)
        SqlFormattingOptions.Assign(options.SqlFormattingOptions)
        SqlGenerationOptions.Assign(options.SqlGenerationOptions)
        TextEditorOptions.Assign(CType(options.TextEditorOptions, ITextEditorOptions))
        TextEditorSqlOptions.Assign(CType(options.TextEditorSqlOptions, ISqlTextEditorOptions))
        UserInterfaceOptions.Assign(options.UserInterfaceOptions)
        VisualOptions.Assign(options.VisualOptions)
    End Sub

    Public Property QueryText() As String
        Get
            Return SqlQuery.SQL
        End Get
        Set(value As String)
            SqlQuery.SQL = value
        End Set
    End Property

    Public Property SqlEditorText() As String
        Get
            Return rtbQueryText.Text
        End Get
        Set(value As String)
            rtbQueryText.Text = value
            rtbQueryText_Validating(Me, Nothing)
        End Set
    End Property

    Public ReadOnly Property FormattedQueryText As String
    get
        Return FormattedSQLBuilder.GetSQL(SqlQuery.QueryRoot, _sqlFormattingOptions)
    End Get

    End Property

    Public Sub New(sqlContext As SQLContext, connectionInfo As ConnectionInfo)
        InitializeComponent()

        _queryTransformerTop10 = New QueryTransformer()
        Debug.Assert(sqlContext IsNot Nothing)
        SqlSourceType = SourceType.New

        _sqlContext = sqlContext
        _connectionInfo = connectionInfo
        SqlQuery = New SQLQuery(_sqlContext)
        SqlQuery.QueryRoot.AllowSleepMode = True

        AddHandler SqlQuery.SleepModeChanged, AddressOf SqlQuery_SleepModeChanged
        AddHandler SqlQuery.QueryAwake, AddressOf SqlQuery_QueryAwake
        _timerForFastResult = New Timer(AddressOf TimerForFastResult_Elapsed)

        CBuilder.QueryTransformer = New QueryTransformer With {.Query = SqlQuery}
        SqlFormattingOptions = New SQLFormattingOptions()

        AddHandler CBuilder.QueryTransformer.SQLUpdated, AddressOf CBuilder_SQLUpdated

        rtbQueryText.QueryProvider = SqlQuery
        TextBoxCurrentSubQuerySql.QueryProvider = SqlQuery
        resultGrid1.SqlQuery = SqlQuery
        resultGrid2.SqlQuery = SqlQuery
        resultGrid1.QueryTransformer = CBuilder.QueryTransformer

        QView.Query = SqlQuery
        NavBar.QueryView = QView
        NavBar.Query = SqlQuery

        RepairImageLists()
        toolStripStatusLabel1.Text = "Query builder state: " & (If(SqlQuery.SleepMode, "Inactive", "Active"))

        AddHandler Application.Idle, AddressOf Application_Idle

        AddHandler SqlQuery.SQLUpdated, AddressOf query_SQLUpdated
        AddHandler QueryView.ActiveUnionSubQueryChanged, AddressOf QueryViewOnActiveUnionSubQueryChanged

        rtbQueryText.ExpressionContext = QView.ActiveUnionSubQuery
        TextBoxCurrentSubQuerySql.ExpressionContext = QView.ActiveUnionSubQuery
        AddHandler QueryNavBarOptions.Updated, AddressOf QueryNavBarOptions_Updated
    End Sub

    Private Sub QueryNavBarOptions_Updated(sender As Object, e As EventArgs)
        subQueryNavBar1.Options.Assign(CType(QueryNavBarOptions, IQueryNavigationBarOptions))
    End Sub

    Private Sub QueryViewOnActiveUnionSubQueryChanged(sender As Object, eventArgs As EventArgs)
        If QueryView.ActiveUnionSubQuery?.ParentSubQuery IsNot Nothing Then
            TextBoxCurrentSubQuerySql.Text = QueryView.ActiveUnionSubQuery.ParentSubQuery.GetResultSQL(_sqlFormattingOptions)
        End If

        rtbQueryText.ExpressionContext = QView.ActiveUnionSubQuery
        TextBoxCurrentSubQuerySql.ExpressionContext = QView.ActiveUnionSubQuery
    End Sub

    Private Sub TimerForFastResult_Elapsed(state As Object)
        Invoke(Sub()
            resultGrid2.QueryTransformer = _queryTransformerTop10
            resultGrid2.FillDataGrid(_queryTransformerTop10.Take("10").SQL)
        End Sub)
    End Sub

    Private Sub ChildForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not Save(True)
    End Sub

    Public Function Save(showQuery As Boolean) As Boolean
        If SqlSourceType = SourceType.New Then
            Dim dialog As New SaveAsForm(Text)
            Select Case dialog.ShowDialog()
                Case DialogResult.Cancel
                    Return False
                Case DialogResult.No
                    Return True
            End Select
            If dialog.SaveAsFile Then
                Return SaveInFile()
            End If
            Return SaveAsNewUserQuery()
        End If
        If _oldSql <> FormattedQueryText Then
            If showQuery Then
                Dim saveDialog As New SaveForm()
                If saveDialog.ShowDialog() <> DialogResult.OK Then
                    Return False
                End If
                If saveDialog.IsSave Then
                    Return SaveQuery()
                End If
            Else
                Return SaveQuery()
            End If
        End If
        Return True
    End Function

    Private _oldSql As String
    Private _hasError As Boolean

    Private Sub _sqlFormattingOptions_Updated(sender As Object, e As EventArgs)
        rtbQueryText.Text = FormattedQueryText
    End Sub

    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        If _sqlContext.MetadataProvider IsNot Nothing AndAlso _sqlContext.MetadataProvider.Connection IsNot Nothing Then
            _sqlContext.MetadataProvider.Connection.Close()
        End If

        MyBase.OnClosing(e)
    End Sub

    Protected Overrides Sub OnClosed(e As EventArgs)
        MyBase.OnClosed(e)

        Dispose()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        Application.DoEvents()

        ' Expand form to client rectangle of main form
        Dim mdiClient As MdiClient = MdiParent.Controls.OfType(Of MdiClient)().FirstOrDefault()

        If mdiClient Is Nothing Then
            Return
        End If

        Bounds = mdiClient.ClientRectangle

        If _sqlContext.MetadataProvider IsNot Nothing Then
            ' load from cache

            If (Not String.IsNullOrEmpty(_connectionInfo.CacheFile)) AndAlso File.Exists(_connectionInfo.CacheFile) Then
                Dim message As String = "Cached metadata is found." & ControlChars.CrLf & "Do you want to load database structure from cache?"

                If MessageBox.Show(message, "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Cursor = Cursors.WaitCursor

                    Try
                        _sqlContext.MetadataContainer.ImportFromXML(_connectionInfo.CacheFile)
                    Catch ex As Exception
                        MessageBox.Show("Invalid cache file: " & vbLf & ex.Message)
                    Finally
                        Cursor = Cursors.Default
                    End Try

                    Return
                End If

                If MessageBox.Show("Delete cached data?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Try
                        File.Delete(_connectionInfo.CacheFile)
                    Catch
                        'ignore
                    End Try
                End If
            End If

            'load from database server

            Cursor = Cursors.WaitCursor

            Try
                Dim start As Date = Date.Now

                ' ask for caching
                If (Date.Now.Subtract(start)).TotalSeconds > 60 Then
                    Dim message As String = "Do you want to cache the database structure to quicken further loading?"

                    If MessageBox.Show(message, "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        Dim dir As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\FullFeaturedMdiDemo\"
                        Dim cacheFile As String = dir & _connectionInfo.GetHashCode().ToString() & ".xml"

                        If Not Directory.Exists(dir) Then
                            Directory.CreateDirectory(dir)
                        End If

                        ' pre-load database databases/schemas/objects for export, but skip params/fields/foreign keys
                        _sqlContext.MetadataContainer.LoadAll(False)
                        _sqlContext.MetadataContainer.ExportToXML(cacheFile)
                        _connectionInfo.CacheFile = cacheFile
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Cursor = Cursors.Default
            End Try
        End If

        MyBase.OnLoad(e)
    End Sub

    Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            RemoveHandler Application.Idle, AddressOf Application_Idle

            components?.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Public Function CanCopy() As Boolean
        If rtbQueryText.ContainsFocus Then
            If rtbQueryText.SelectionLength > 0 Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Function CanCut() As Boolean
        If rtbQueryText.ContainsFocus Then
            If Not String.IsNullOrEmpty(rtbQueryText.SelectedText) Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Function CanPaste() As Boolean
        If rtbQueryText.ContainsFocus Then
            Return Clipboard.ContainsText()
        End If

        Return False
    End Function

    Public Function CanUndo() As Boolean
        If rtbQueryText.ContainsFocus Then
            Return rtbQueryText.CanUndo
        End If

        Return False
    End Function

    Public Function CanRedo() As Boolean
        If rtbQueryText.ContainsFocus Then
            Return rtbQueryText.CanRedo
        End If

        Return False
    End Function

    Public Function CanSelectAll() As Boolean
        Return (rtbQueryText.ContainsFocus AndAlso rtbQueryText.TextLength > 0)
    End Function

    Public Function CanShowProperties() As Boolean
        Return NavBar.ActiveUnionSubQuery IsNot Nothing
    End Function

    Public Function CanAddUnionSubQuery() As Boolean
        If NavBar.ActiveUnionSubQuery Is Nothing Then
            Return False
        End If

        If NavBar.ActiveUnionSubQuery.QueryRoot.IsSubQuery Then
            Return _sqlContext.SyntaxProvider.IsSupportSubQueryUnions()
        End If

        Return _sqlContext.SyntaxProvider.IsSupportUnions()
    End Function

    Public Function CanCopyUnionSubQuery() As Boolean
        Return CanAddUnionSubQuery()
    End Function

    Public Function CanAddDerivedTable() As Boolean
        If NavBar.ActiveSubQuery IsNot Nothing AndAlso NavBar.ActiveUnionSubQuery.QueryRoot.IsMainQuery Then
            Return _sqlContext.SyntaxProvider.IsSupportDerivedTables()
        End If

        Return _sqlContext.SyntaxProvider.IsSupportSubQueryDerivedTables()
    End Function

    Public Function CanAddObject() As Boolean
        Return QView.AddObjectDialog IsNot Nothing
    End Function

    Public Sub UpdateLanguage()
        QView.Language = Program.Settings.Language

        tsbQueryProperties.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strEdit", "Properties")
        tsbAddObject.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAddObject", "Add object")
        tsbAddDerivedTable.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAddSubQuery", "Add derived table")
        tsbAddUnionSubquery.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strNewUnionSubQuery", "New union sub-query")
        tsbCopyUnionSubquery.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strCopyToNewUnionSubQuery", "Copy union sub-query")

        dockPanelProperties.Text = ActiveQueryBuilder.Core.Helpers.Localizer.GetString(nameof(LocalizableConstantsUI.strProperties), LocalizableConstantsUI.strProperties)
        dockPanelSubquery.Text = ActiveQueryBuilder.Core.Helpers.Localizer.GetString("strSubQueryStructureBarCaption", LocalizableConstantsUI.strSubQueryStructureBarCaption)
    End Sub

    Public Sub ParseQuery()
        Try
            SqlQuery.SQL = rtbQueryText.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ActivateBuildQueryTab()
        tabControl1.SelectTab(0)
        rtbQueryText.Focus()
    End Sub

    Public Sub ActivateRunQueryTab()
        tabControl1.SelectTab(1)
    End Sub

    Public Sub ShowQueryStatistics()
        Dim qs As QueryStatistics = SqlQuery.QueryStatistics

        Dim stats = "Used Objects (" & qs.UsedDatabaseObjects.Count & "):" & vbCrLf
        stats = qs.UsedDatabaseObjects.Aggregate(stats, Function(current, t) current + (vbCrLf & t.ObjectName.QualifiedName))

        stats += vbCrLf & vbCrLf & "Used Columns (" & qs.UsedDatabaseObjectFields.Count & "):" & vbCrLf
        stats = qs.UsedDatabaseObjectFields.Aggregate(stats, Function(current, t) current + (vbCrLf & t.ObjectName.QualifiedName))

        stats += vbCrLf & vbCrLf & "Output Expressions (" & qs.OutputColumns.Count & "):" & vbCrLf
        stats = qs.OutputColumns.Aggregate(stats, Function(current, t) current + (vbCrLf & t.Expression))

        Using f As New QueryStatisticsForm()
            f.textBox.Text = stats
            f.ShowDialog()
        End Using
    End Sub

    Public Sub Undo()
        rtbQueryText.Undo()
    End Sub

    Public Sub Redo()
        rtbQueryText.Undo()
    End Sub

    Public Sub Cut()
        rtbQueryText.Cut()
    End Sub

    Public Sub Copy()
        rtbQueryText.Copy()
    End Sub

    Public Sub Paste()
        rtbQueryText.Paste()
    End Sub

    Public Sub SelectAll()
        rtbQueryText.SelectAll()
    End Sub

    Public Sub AddObject()
        QView.AddObjectDialog?.ShowModal()
    End Sub

    Public Sub AddDerivedTable()
        Using TempUpdateRegion As UpdateRegion = New UpdateRegion(NavBar.ActiveUnionSubQuery.FromClause)
            Dim sqlContext = NavBar.ActiveUnionSubQuery.SQLContext

            Dim fq = New SQLFromQuery(sqlContext) With {.Alias = New SQLAliasObjectAlias(sqlContext) With {.Alias = NavBar.ActiveUnionSubQuery.QueryRoot.CreateUniqueSubQueryName()}, .SubQuery = New SQLSubSelectStatement(sqlContext)}

            Dim sqse = New SQLSubQuerySelectExpression(sqlContext)
            fq.SubQuery.Add(sqse)
            sqse.SelectItems = New SQLSelectItems(sqlContext)
            sqse.From = New SQLFromClause(sqlContext)

            NavBar.Query.AddObject(NavBar.ActiveUnionSubQuery, fq, GetType(DataSourceQuery))
        End Using
    End Sub

    Public Sub AddUnionSubQuery()
        NavBar.ActiveUnionSubQuery = QView.ActiveUnionSubQuery.ParentGroup.Add()
    End Sub

    Public Sub CopyUnionSubQuery()
        ' add empty UnionSubQuery
        Dim usq = QView.ActiveUnionSubQuery.ParentGroup.Add()

        ' copy content
        Dim usqAst = QView.ActiveUnionSubQuery.ResultQueryAST
        usqAst.RestoreColumnPrefixRecursive(True)

        Dim lCte = New List(Of SQLWithClauseItem)()
        Dim lFromObj = New List(Of SQLFromSource)()
        QView.ActiveUnionSubQuery.GatherPrepareAndFixupContext(lCte, lFromObj, False)
        usqAst.PrepareAndFixupRecursive(lCte, lFromObj)

        usq.LoadFromAST(usqAst)
        NavBar.ActiveUnionSubQuery = usq
    End Sub

    Public Sub PropertiesQuery()
        QView.ShowActiveUnionSubQueryProperties()
    End Sub

    Public Sub RefreshMetadata()
        If _sqlContext.MetadataProvider IsNot Nothing AndAlso _sqlContext.MetadataProvider.Connected Then
            ' to refresh metadata, just clear already loaded items
            _sqlContext.MetadataContainer.Clear()
            _sqlContext.MetadataContainer.LoadAll(True)
        End If
    End Sub

    Public Sub EditMetadata()
        QueryBuilder.EditMetadataContainer(_sqlContext)
    End Sub

    Public Sub ClearMetadata()
        _sqlContext.MetadataContainer.Clear()
    End Sub

    Public Sub LoadMetadataFromXml()
        Dim fileDialog As OpenFileDialog = New OpenFileDialog With {.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"}

        If fileDialog.ShowDialog() = DialogResult.OK Then
            _sqlContext.MetadataContainer.LoadingOptions.OfflineMode = True
            _sqlContext.MetadataContainer.ImportFromXML(fileDialog.FileName)
        End If
    End Sub

    Public Sub SaveMetadataToXml()
        Dim fileDialog As SaveFileDialog = New SaveFileDialog With {.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*", .FileName = "Metadata.xml"}
        If fileDialog.ShowDialog() = DialogResult.OK Then
            _sqlContext.MetadataContainer.LoadAll(True)
            _sqlContext.MetadataContainer.ExportToXML(fileDialog.FileName)
        End If
    End Sub

    Private Sub SqlQuery_QueryAwake(sender As QueryRoot, ByRef abort As Boolean)
        If MessageBox.Show("You had typed something that is not a SELECT statement in the text editor and continued with visual query building." & "Whatever the text in the editor is, it will be replaced with the SQL generated by the component. Is it right?", "Active Query Builder .NET Demo", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    Private _tempTabCurrentSubquery As TabPage
    Private _tempTabPreviewResult As TabPage

    Private Sub SqlQuery_SleepModeChanged(sender As Object, e As EventArgs)
        labelSleepMode.Visible = SqlQuery.SleepMode

        If SqlQuery.SleepMode Then
            _tempTabCurrentSubquery = tabControl2.TabPages(1)
            _tempTabPreviewResult = tabControl2.TabPages(2)

            tabControl2.TabPages.Remove(_tempTabCurrentSubquery)
            tabControl2.TabPages.Remove(_tempTabPreviewResult)
        Else
            tabControl2.TabPages.Add(_tempTabCurrentSubquery)
            tabControl2.TabPages.Add(_tempTabPreviewResult)
        End If

        '  panelTextInfo.Height = SqlQuery.SleepMode ? 60 : 0
        toolStripStatusLabel1.Text = "Query builder state: " & (If(SqlQuery.SleepMode, "Inactive", "Active"))
    End Sub

    ' Workaround for the old Microsoft's bug: ImageList damages the alpha channel of 32-bit ICO and PNG files.
    ' Clear all images from designed image lists and reload all images manually.
    Private Sub RepairImageLists()
        imageList1.Images.Clear()
        imageList1.Images.Add(My.Resources.bricks)
        imageList1.Images.Add(My.Resources.database_go)

        imageList2.Images.Clear()
        imageList2.Images.Add(My.Resources.table)
        imageList2.Images.Add(My.Resources.table_lightning)
        imageList2.Images.Add(My.Resources.table_gear)
        imageList2.Images.Add(My.Resources.table_sort)
        imageList2.Images.Add(My.Resources.folder)
        imageList2.Images.Add(My.Resources.table_multiple)
        imageList2.Images.Add(My.Resources.database)

        imageList3.Images.Clear()
        imageList3.Images.Add(My.Resources.chart_organisation)
        imageList3.Images.Add(My.Resources.folder_table)
        imageList3.Images.Add(My.Resources.database_table)
        imageList3.Images.Add(My.Resources.folder_bullet_green)
        imageList3.Images.Add(My.Resources.bullet_green)
    End Sub

    Private Sub query_SQLUpdated(sender As Object, e As EventArgs)
        errorBox1.Show(Nothing, _sqlContext.SyntaxProvider)
        errorBoxCurrent.Show(Nothing, _sqlContext.SyntaxProvider)

        rtbQueryText.Text = If(SqlQuery.SleepMode, SqlQuery.SQL, FormattedQueryText)
        _lastValidSql = rtbQueryText.Text
        If _oldSql Is Nothing Then
            _oldSql = rtbQueryText.Text
        End If

        buttonGenerateReport.Enabled = Not String.IsNullOrEmpty(FormattedQueryText) AndAlso _sqlContext.MetadataProvider IsNot Nothing
        buttonExportExcel.Enabled = buttonGenerateReport.Enabled
        buttonExportCsv.Enabled = buttonExportExcel.Enabled

        If QueryView.ActiveUnionSubQuery Is Nothing OrElse SqlQuery.SleepMode Then
            Return
        End If
        TextBoxCurrentSubQuerySql.Text = QueryView.ActiveUnionSubQuery.ParentSubQuery.GetResultSQL(_sqlFormattingOptions)
        _lastValidSqlCurrent = TextBoxCurrentSubQuerySql.Text
        CheckParameters()
    End Sub

    Private Sub CheckParameters()
        If SqlHelpers.CheckParameters(_sqlContext.MetadataProvider, _sqlContext.SyntaxProvider, SqlQuery.QueryParameters) Then
            HideParametersErrorPanel()
        Else
            Dim acceptableFormats = SqlHelpers.GetAcceptableParametersFormats(_sqlContext.MetadataProvider, _sqlContext.SyntaxProvider)
            ShowParametersErrorPanel(acceptableFormats)
        End If
    End Sub

    Private _parametersErrorPanel As Control
    Private Sub ShowParametersErrorPanel(acceptableFormats As List(Of String))
        HideParametersErrorPanel()
        _parametersErrorPanel = New Panel With {.AutoSize = True, .AutoSizeMode = AutoSizeMode.GrowAndShrink, .BackColor = Color.LightPink, .BorderStyle = BorderStyle.FixedSingle, .Dock = DockStyle.Top, .Padding = New Padding(6, 5, 3, 0)}

        Dim formats = acceptableFormats.Select(Function(x)
                                                   Dim s = x.Replace("n", "<number>")
                                                   Return s.Replace("s", "<name>")
                                               End Function)

        Dim formatsString As String = String.Join(", ", formats)

        Dim label As Label = New Label With {.AutoSize = True, .Margin = New Padding(0), .Text = "Unsupported parameter notation detected. For this type of connection and database server use " & formatsString, .Dock = DockStyle.Fill, .UseCompatibleTextRendering = True}

        _parametersErrorPanel.Controls.Add(label)
        _parametersErrorPanel.Visible = True
        Controls.Add(_parametersErrorPanel)
    End Sub

    Private Sub HideParametersErrorPanel()
        If _parametersErrorPanel Is Nothing Then
            Return
        End If
        _parametersErrorPanel.Visible = False
        _parametersErrorPanel.Parent?.Controls.Remove(_parametersErrorPanel)
        _parametersErrorPanel.Dispose()
        _parametersErrorPanel = Nothing
    End Sub

    Private Function IsRecursionLoopInQueryText(sql As String) As Boolean
        Using query = _sqlContext.GetNewSqlQuery()
            query.QueryRoot.AllowSleepMode = True
            query.SQL = sql

            Return (Not query.SleepMode) AndAlso UserMetadataStructureItem IsNot Nothing AndAlso query.QueryStatistics.UsedDatabaseObjects.Any(Function(x as StatisticsDatabaseObject) Equals(x.MetadataObject, UserMetadataStructureItem.MetadataItem))
        End Using
    End Function

    Private Sub rtbQueryText_Validating(sender As Object, e As CancelEventArgs) Handles rtbQueryText.Validating
        ' We need to check that the new text doesn't have references to itself to avoid recursion on generating a query for the server.
        Try
            If IsRecursionLoopInQueryText(rtbQueryText.Text) Then
                Dim message = "Recursion loop in virtual objects definition detected for object:" & vbLf & UserMetadataStructureItem.MetadataItem.GetQualifiedNameSQL(Nothing, SqlGenerationOptions)

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                rtbQueryText.Text = FormattedQueryText
                Return
            End If
            ' Update the query builder with manually edited query text:
            SqlQuery.SQL = rtbQueryText.Text
            errorBox1.Show(Nothing, _sqlContext.SyntaxProvider)
        Catch ex As SQLParsingException
            ' Set caret to error position
            rtbQueryText.SelectionStart = ex.ErrorPos.pos
            _errorPosition = rtbQueryText.SelectionStart

            ' Show banner with error text
            errorBox1.Show(ex.Message, _sqlContext.SyntaxProvider)
        End Try
    End Sub

    Private Sub Application_Idle(sender As Object, e As EventArgs)
        Dim supportsDerivedTable As Boolean = False
        Dim supportsUnion As Boolean = False

        If _sqlContext.SyntaxProvider IsNot Nothing AndAlso NavBar.ActiveUnionSubQuery IsNot Nothing Then
            If NavBar.ActiveUnionSubQuery.QueryRoot.IsMainQuery Then
                supportsDerivedTable = _sqlContext.SyntaxProvider.IsSupportDerivedTables()
            Else
                supportsDerivedTable = _sqlContext.SyntaxProvider.IsSupportSubQueryDerivedTables()
            End If
            supportsUnion = If(NavBar.ActiveUnionSubQuery.QueryRoot.IsSubQuery, _sqlContext.SyntaxProvider.IsSupportSubQueryUnions(), _sqlContext.SyntaxProvider.IsSupportUnions())
        End If

        tsbAddDerivedTable.Enabled = supportsDerivedTable
        tsbAddUnionSubquery.Enabled = supportsUnion
        tsbCopyUnionSubquery.Enabled = supportsUnion
    End Sub

    Private Sub tabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tabControl1.Selecting
        ' Execute a query on switching to the Data tab
        If e.TabPage IsNot pageQueryResult OrElse SqlQuery.SleepMode Then
            Return
        End If
        If _hasError Then
            e.Cancel = True
            Return
        End If

        CBuilder.QueryTransformer.BeginUpdate()
        Try
            CBuilder.QueryTransformer.Skip(String.Empty)
            CBuilder.QueryTransformer.Take(String.Empty)
            CBuilder.QueryTransformer.NotifyUpdated()
        Finally
            CBuilder.QueryTransformer.EndUpdate()
        End Try

        Dim sql = CBuilder.QueryTransformer.SQL

        resultGrid1.FillDataGrid(sql)

        RefreshNoConnectionLabel()
    End Sub

    Private Sub contextMenuStripForRichTextBox_Opening(sender As Object, e As CancelEventArgs) Handles contextMenuStripForRichTextBox.Opening
        tsmiUndo.Enabled = CanUndo()
        tsmiRedo.Enabled = CanRedo()
        tsmiCut.Enabled = CanCut()
        tsmiCopy.Enabled = CanCopy()
        tsmiPaste.Enabled = CanPaste()
        tsmiSelectAll.Enabled = CanSelectAll()
    End Sub

    Private Sub tsmiUndo_Click(sender As Object, e As EventArgs) Handles tsmiUndo.Click
        Undo()
    End Sub

    Private Sub tsmiRedo_Click(sender As Object, e As EventArgs) Handles tsmiRedo.Click
        Redo()
    End Sub

    Private Sub tsmiCut_Click(sender As Object, e As EventArgs) Handles tsmiCut.Click
        Cut()
    End Sub

    Private Sub tsmiCopy_Click(sender As Object, e As EventArgs) Handles tsmiCopy.Click
        Copy()
    End Sub

    Private Sub tsmiPaste_Click(sender As Object, e As EventArgs) Handles tsmiPaste.Click
        Paste()
    End Sub

    Private Sub tsmiSelectAll_Click(sender As Object, e As EventArgs) Handles tsmiSelectAll.Click
        SelectAll()
    End Sub

    Friend Function IsOfflineMode() As Boolean
        Return _sqlContext.MetadataContainer.LoadingOptions.OfflineMode
    End Function

    Private Sub tsbQueryProperties_Click(sender As Object, e As EventArgs) Handles tsbQueryProperties.Click
        PropertiesQuery()
    End Sub

    Private Sub tsbAddObject_Click(sender As Object, e As EventArgs) Handles tsbAddObject.Click
        AddObject()
    End Sub

    Private Sub tsbAddDerivedTable_Click(sender As Object, e As EventArgs) Handles tsbAddDerivedTable.Click
        AddDerivedTable()
    End Sub

    Private Sub tsbAddUnionSubquery_Click(sender As Object, e As EventArgs) Handles tsbAddUnionSubquery.Click
        AddUnionSubQuery()
    End Sub

    Private Sub tsbCopyUnionSubquery_Click(sender As Object, e As EventArgs) Handles tsbCopyUnionSubquery.Click
        CopyUnionSubQuery()
    End Sub

    Private Sub CBuilder_SQLUpdated(sender As Object, e As EventArgs)
        If Disposing Then
            Return
        End If

        ' Handle the event raised by Criteria Builder object that the text of SQL query is changed
        ' update the text box
        If tabControl1.SelectedTab IsNot pageQueryResult Then
            Return
        End If
        Try
            Dim sql As String = CBuilder.SQL
            richTextBox1.Text = sql

            resultGrid1.FillDataGrid(sql)
        Catch
            'ignore
        End Try
    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        SaveQuery()
    End Sub

    Private Sub tsbSaveInFile_Click(sender As Object, e As EventArgs) Handles tsbSaveInFile.Click
        SaveInFile()
    End Sub

    Private Sub tsbSaveNewUserQuery_Click(sender As Object, e As EventArgs) Handles tsbSaveNewUserQuery.Click
        SaveAsNewUserQuery()
    End Sub

    Private Function SaveQuery() As Boolean
        Dim args As New CancelEventArgs()
        RaiseEvent SaveQueryEvent(Me, args)
        If Not args.Cancel Then
            _oldSql = FormattedQueryText
        End If
        Return Not args.Cancel
    End Function

    Private Function SaveAsNewUserQuery() As Boolean
        Dim args As New CancelEventArgs()
        RaiseEvent SaveAsNewUserQueryEvent(Me, args)
        If Not args.Cancel Then
            _oldSql = FormattedQueryText
            Text = FileSourcePath
        End If
        Return Not args.Cancel
    End Function

    Private Function SaveInFile() As Boolean
        Dim args As New CancelEventArgs()
        RaiseEvent SaveAsInFileEvent(Me, args)
        If Not args.Cancel Then
            _oldSql = FormattedQueryText
            Text = FileSourcePath
        End If
        Return Not args.Cancel
    End Function




    Private Sub RefreshNoConnectionLabel()
        If _connectionInfo IsNot Nothing Then
            If _noConnectionLabel IsNot Nothing Then
                RemoveHandler resultGrid1.SizeChanged, AddressOf DataGridView1_SizeChanged
                _noConnectionLabel.Parent = Nothing
                _noConnectionLabel = Nothing
            End If
        ElseIf _noConnectionLabel Is Nothing Then
            _noConnectionLabel = New NoConnectionLabel()
            AddHandler resultGrid1.SizeChanged, AddressOf DataGridView1_SizeChanged
            resultGrid1.Controls.Add(_noConnectionLabel)
        End If
    End Sub

    Private Sub DataGridView1_SizeChanged(sender As Object, e As EventArgs)
        Dim parent As Control = CType(sender, Control)
        Dim x As Integer = parent.Width \ 2 - _noConnectionLabel.Width \ 2
        Dim y As Integer = parent.Height \ 2 - _noConnectionLabel.Height \ 2
        _noConnectionLabel.Location = New Point(If(x > 0, x, 0), If(y > 0, y, 0))
    End Sub

    ''' <summary>
    ''' Checking for loops on adding an object to the query
    ''' </summary>
    Private Sub QView_DataSourceAdding(fromObject As MetadataObject, ByRef abort As Boolean) Handles QView.DataSourceAdding
        If UserMetadataStructureItem Is Nothing Then
            Return
        End If

        If fromObject IsNot UserMetadataStructureItem.MetadataItem Then
            Return
        End If

        abort = True

        Dim message = "Recursion loop in virtual objects definition detected for object:" & vbLf & UserMetadataStructureItem.MetadataItem.GetQualifiedNameSQL(Nothing, SqlGenerationOptions)

        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Public Sub OpenExecuteTab()
        tabControl1.SelectedIndex = 1
    End Sub

    Private Sub TextBoxCurrentSubQuerySql_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCurrentSubQuerySql.TextChanged
        If (Not tabPageFastResult.Visible) OrElse
           String.IsNullOrEmpty(TextBoxCurrentSubQuerySql.Text) OrElse 
           QView.ActiveUnionSubQuery Is Nothing Then
            errorBoxCurrent.Show(Nothing, _sqlContext?.SyntaxProvider)
            Return
        End If

        FillFastViewDataGrid()
    End Sub

    Private Sub FillFastViewDataGrid()
        If tabControl2.SelectedTab IsNot tabPageFastResult Then
            Return
        End If

        Try
            _queryTransformerTop10.Query = New SQLQuery(QueryView.ActiveUnionSubQuery.ParentSubQuery.SQLContext) With {.SQL = QueryView.ActiveUnionSubQuery.ParentSubQuery.GetSqlForDataPreview()}

            _timerForFastResult.Change(400, Timeout.Infinite)
        Catch
            'ignore
        End Try
    End Sub

    Private Sub tabControl2_Selected(sender As Object, e As TabControlEventArgs) Handles tabControl2.Selected
        If e.Action = TabControlAction.Selected AndAlso e.TabPage Is tabPageFastResult Then
            FillFastViewDataGrid()
        End If
    End Sub


    Private Sub TextBoxCurrentSubQuerySql_Validating(sender As Object, e As CancelEventArgs) Handles TextBoxCurrentSubQuerySql.Validating
        Try
            errorBoxCurrent.Show(Nothing, _sqlContext.SyntaxProvider)

            ' save active subquery
            Dim parent = QueryView.ActiveUnionSubQuery.ParentSubQuery
            Dim items = QueryView.ActiveUnionSubQuery.ParentSubQuery.GetUnionSubQueryList()
            Dim idx = items.IndexOf(QueryView.ActiveUnionSubQuery)

            QueryView.ActiveUnionSubQuery.ParentSubQuery.SQL = TextBoxCurrentSubQuerySql.Text

            ' restore active subquery
            items = parent.GetUnionSubQueryList()
            QueryView.ActiveUnionSubQuery = If(idx <> -1, items(idx), items.First())
        Catch ex As SQLParsingException
            errorBoxCurrent.Show(ex.Message, _sqlContext.SyntaxProvider)
            _errorPositionCurrent = ex.ErrorPos.pos
        End Try
    End Sub



    Private Sub errorBox1_RevertValidText(sender As Object, e As EventArgs) Handles errorBox1.RevertValidText
        rtbQueryText.Text = _lastValidSql
        rtbQueryText.Focus()
    End Sub

    Private Sub errorBox1_GoToErrorPosition(sender As Object, e As EventArgs) Handles errorBox1.GoToErrorPosition
        If _errorPosition <> -1 Then
            rtbQueryText.SelectionStart = _errorPosition
            rtbQueryText.SelectionLength = 0
            rtbQueryText.ScrollToPosition(_errorPosition)
        End If

        rtbQueryText.Focus()
    End Sub

    Private Sub errorBoxCurrent_GoToErrorPosition(sender As Object, e As EventArgs) Handles errorBoxCurrent.GoToErrorPosition
        If _errorPosition <> -1 Then
            TextBoxCurrentSubQuerySql.SelectionStart = _errorPositionCurrent
            TextBoxCurrentSubQuerySql.SelectionLength = 0
            TextBoxCurrentSubQuerySql.ScrollToPosition(_errorPositionCurrent)
        End If

        TextBoxCurrentSubQuerySql.Focus()
    End Sub

    Private Sub errorBoxCurrent_RevertValidText(sender As Object, e As EventArgs) Handles errorBoxCurrent.RevertValidText
        TextBoxCurrentSubQuerySql.Text = _lastValidSql
        TextBoxCurrentSubQuerySql.Focus()
    End Sub

    Private Sub CreateFastReport(ByVal dataTable As DataTable)
			If dataTable Is Nothing Then
				Throw New ArgumentException("Argument cannot be null or empty.", "DataTable")
			End If

			Dim reportWindow = New FastReportForm(dataTable) With {.Owner = Me}

			reportWindow.ShowDialog()
		End Sub

		Private Sub CreateStimulsoftReport(ByVal dataTable As DataTable)
			If dataTable Is Nothing Then
				Throw New ArgumentException("Argument cannot be null or empty.", "DataTable")
			End If

			Dim reportWindow = New StimulsoftForm(dataTable) With {.Owner = Me}

			reportWindow.ShowDialog()
		End Sub

		Private Sub CreateActiveReport(ByVal dataTable As DataTable)
			If dataTable Is Nothing Then
				Throw New ArgumentException("Argument cannot be null or empty.", "DataTable")
			End If

			Dim reportWindow = New ActiveReportsForm(dataTable) With {.Owner = Me}

			reportWindow.ShowDialog()
		End Sub

		Private Sub buttonGenerateReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonGenerateReport.Click
			Dim window = New CreateReportForm With {.Owner = Me}

			Dim result As DialogResult = window.ShowDialog()

			If result <> System.Windows.Forms.DialogResult.OK OrElse window.SelectedReportType Is Nothing Then
				Return
			End If
			Dim dataTable = SqlHelpers.GetDataTable(CBuilder.SQL, SqlQuery)

			Select Case window.SelectedReportType
				Case ReportType.ActiveReports14
					CreateActiveReport(dataTable)
				Case ReportType.Stimulsoft
					CreateStimulsoftReport(dataTable)
				Case ReportType.FastReport
					CreateFastReport(dataTable)
				Case Else
					Throw New ArgumentOutOfRangeException()
			End Select
		End Sub

		Private Sub buttonExportExcel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonExportExcel.Click
			Dim dt = SqlHelpers.GetDataTable(CBuilder.SQL, SqlQuery)

			Dim saveDialog = New SaveFileDialog With {
				.AddExtension = True,
				.DefaultExt = "xlsx",
				.FileName = "Export.xlsx"
			}
			If saveDialog.ShowDialog(Me) <> System.Windows.Forms.DialogResult.OK Then
				Return
			End If

			ExportHelpers.ExportToExcel(dt, saveDialog.FileName)
		End Sub

		Private Sub buttonExportCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonExportCsv.Click
			Dim saveDialog = New SaveFileDialog With {
				.AddExtension = True,
				.DefaultExt = "csv",
				.FileName = "Data.csv"
			}
			Dim result = saveDialog.ShowDialog(Me)
			If result <> System.Windows.Forms.DialogResult.OK Then
				Return
			End If

			Dim dt = SqlHelpers.GetDataTable(CBuilder.SQL, SqlQuery)
			ExportHelpers.ExportToCSV(dt, saveDialog.FileName)
		End Sub
End Class
