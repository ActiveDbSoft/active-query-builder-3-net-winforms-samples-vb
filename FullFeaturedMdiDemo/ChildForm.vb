'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms
Imports ActiveQueryBuilder.Core.QueryTransformer
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.WinForms.QueryView
Imports FullFeaturedMdiDemo.Common
Imports FullFeaturedMdiDemo.Dailogs
Imports Timer = System.Threading.Timer

Partial Public Class ChildForm
    Inherits Form
    Public Enum SourceType
        File
        [New]
        UserQuery
    End Enum

    Private ReadOnly _queryTransformerTop10 As QueryTransformer
    Private ReadOnly _timerForFastReuslt As Timer

    Private ReadOnly _sqlContext As SQLContext
    Private ReadOnly _connectionInfo As ConnectionInfo
    Private _sqlFormattingOptions As SQLFormattingOptions
    Private _sqlGenerationOptions As SQLGenerationOptions
    Private _noConnectionLabel As NoConnectionLabel

    Public Event SaveQueryEvent As CancelEventHandler
    Public Event SaveAsInFileEvent As CancelEventHandler
    Public Event SaveAsNewUserQueryEvent As CancelEventHandler

    Public Property SqlSourceType As SourceType

    Public Property FileSourcePath As String

    Public Property UserMetadataStructureItem As MetadataStructureItem

    Public ReadOnly Property QueryView() As QueryView
        Get
            Return QView
        End Get
    End Property

    Public Property SqlFormattingOptions() As SQLFormattingOptions
        Get
            Return _sqlFormattingOptions
        End Get
        Set
            _sqlFormattingOptions = Value
            AddHandler _sqlFormattingOptions.Updated, AddressOf _sqlFormattingOptions_Updated
            CBuilder.QueryTransformer.SQLGenerationOptions = _sqlFormattingOptions
        End Set
    End Property

    Public Property SqlGenerationOptions() As SQLGenerationOptions
        Get
            Return _sqlGenerationOptions
        End Get
        Set
            _sqlGenerationOptions = Value
        End Set
    End Property

    Public Property BehaviorOptions() As BehaviorOptions
        Get
            Return SqlQuery.BehaviorOptions
        End Get
        Set
            SqlQuery.BehaviorOptions = Value
        End Set
    End Property

    Public Property DesignPaneOptions() As DesignPaneOptions
        Get
            Return designPaneControl1.Options
        End Get
        Set
            designPaneControl1.Options = Value
        End Set
    End Property

    Public Property VisualOptions() As VisualOptions
        Get
            Return dockManager1.Options
        End Get
        Set
            dockManager1.Options = Value
        End Set
    End Property

    Public Property AddObjectDialogOptions() As AddObjectDialogOptions
        Get
            Return addObjectDialog1.Options
        End Get
        Set
            addObjectDialog1.Options = Value
        End Set
    End Property

    Public Property DataSourceOptions() As DataSourceOptions
        Get
            Return CType(designPaneControl1.DataSourceOptions, DataSourceOptions)
        End Get
        Set
            designPaneControl1.DataSourceOptions = Value
        End Set
    End Property

    Public Property MetadataLoadingOptions() As MetadataLoadingOptions
        Get
            Return _sqlContext.LoadingOptions
        End Get
        Set
            _sqlContext.LoadingOptions = Value
        End Set
    End Property

    Public Property MetadataStructureOptions() As MetadataStructureOptions
        Get
            Return _sqlContext.MetadataStructureOptions
        End Get
        Set
            _sqlContext.MetadataStructureOptions = Value
        End Set
    End Property

    Public Property QueryColumnListOptions() As QueryColumnListOptions
        Get
            Return queryColumnListControl1.Options
        End Get
        Set
            queryColumnListControl1.Options = Value
        End Set
    End Property

    Public Property QueryNavBarOptions() As QueryNavBarOptions
        Get
            Return NavBar.Options
        End Get
        Set
            NavBar.Options = Value
        End Set
    End Property

    Public Property UserInterfaceOptions() As UserInterfaceOptions
        Get
            Return QueryView.UserInterfaceOptions
        End Get
        Set
            QueryView.UserInterfaceOptions = Value
        End Set
    End Property

    Public Property SqlQuery As SQLQuery

    Public Property QueryText() As String
        Get
            Return SqlQuery.SQL
        End Get
        Set
            SqlQuery.SQL = Value
        End Set
    End Property

    Public ReadOnly Property FormattedQueryText() As String
        Get
            Return FormattedSQLBuilder.GetSQL(SqlQuery.QueryRoot, _sqlFormattingOptions)
        End Get
    End Property

    Public Sub New(sqlContext As SQLContext, connectionInfo As ConnectionInfo)
        _queryTransformerTop10 = New QueryTransformer()
        Debug.Assert(sqlContext IsNot Nothing)
        SqlSourceType = SourceType.[New]

        _sqlContext = sqlContext
        _connectionInfo = connectionInfo
        SqlQuery = New SQLQuery(_sqlContext)
        SqlQuery.QueryRoot.AllowSleepMode = True

        AddHandler SqlQuery.SQLUpdated, AddressOf query_SQLUpdated
        AddHandler SqlQuery.SleepModeChanged, AddressOf SqlQuery_SleepModeChanged
        AddHandler SqlQuery.QueryAwake, AddressOf SqlQuery_QueryAwake
        AddHandler _sqlContext.SyntaxProviderChanged, AddressOf _sqlContext_SyntaxProviderChanged
        _timerForFastReuslt = New Timer(AddressOf TimerForFastResult_Elapsed)

        InitializeComponent()

        CBuilder.QueryTransformer = New QueryTransformer() With {
            .Query = SqlQuery,
            .SQLGenerationOptions = _sqlGenerationOptions
        }
        AddHandler CBuilder.QueryTransformer.SQLUpdated, AddressOf CBuilder_SQLUpdated

        rtbQueryText.QueryProvider = SqlQuery
        TextBoxCurrentSubQuerySql.QueryProvider = SqlQuery

        rtbQueryText.ActiveUnionSubQuery = QView.ActiveUnionSubQuery
        TextBoxCurrentSubQuerySql.ActiveUnionSubQuery = QView.ActiveUnionSubQuery

        AddHandler QView.ActiveUnionSubQueryChanged, ActiveUnionSubQueryChanged

        resultGrid1.SqlQuery = SqlQuery
        resultGrid2.SqlQuery = SqlQuery
        resultGrid1.QueryTransformer = CBuilder.QueryTransformer

        QView.Query = SqlQuery
        NavBar.QueryView = QView
        NavBar.Query = SqlQuery

        RepairImageLists()
        toolStripStatusLabel1.Text = "Query builder state: " & (If((SqlQuery.SleepMode), "Inactive", "Active"))

        AddHandler Application.Idle, AddressOf Application_Idle

        ' load localized tooltips for some toolbar buttons
        tsbQueryProperties.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strEdit", "Properties")
        tsbAddObject.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAddObject", "Add object")
        tsbAddDerivedTable.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAddSubQuery", "Add derived table")
        tsbAddUnionSubquery.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strNewUnionSubQuery", "New union sub-query")
        tsbCopyUnionSubquery.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strCopyToNewUnionSubQuery", "Copy union sub-query")

        UpdateLanguage()
    End Sub

    Private Function ActiveUnionSubQueryChanged() As EventHandler
        rtbQueryText.ActiveUnionSubQuery = QView.ActiveUnionSubQuery
        TextBoxCurrentSubQuerySql.ActiveUnionSubQuery = QView.ActiveUnionSubQuery
    End Function

    Private Sub TimerForFastResult_Elapsed(state As Object)
        Invoke(DirectCast(Sub()
                              resultGrid2.QueryTransformer = _queryTransformerTop10
                              resultGrid2.FillDataGrid(_queryTransformerTop10.Take("10").SQL)

                          End Sub, Action))
    End Sub

    Private Sub _sqlContext_SyntaxProviderChanged(sender As Object, e As EventArgs)
        RefreshPaginationPanel()
    End Sub

    Private Sub RefreshPaginationPanel()
        paginationPanel1.Visible = CBuilder.QueryTransformer.IsSupportLimitCount OrElse CBuilder.QueryTransformer.IsSupportLimitOffset
        paginationPanel1.IsSupportLimitCount = CBuilder.QueryTransformer.IsSupportLimitCount
        paginationPanel1.IsSupportLimitOffset = CBuilder.QueryTransformer.IsSupportLimitOffset
    End Sub

    Private Sub ChildForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not Save(True)
    End Sub

    Public Function Save(showQuery As Boolean) As Boolean
        If SqlSourceType = SourceType.[New] Then
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

            If Not [String].IsNullOrEmpty(_connectionInfo.CacheFile) AndAlso File.Exists(_connectionInfo.CacheFile) Then
                Dim message As [String] = "Cached metadata is found." & vbCr & vbLf & "Do you want to load database structure from cache?"

                If MessageBox.Show(message, "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Cursor = Cursors.WaitCursor

                    Try
                        _sqlContext.MetadataContainer.ImportFromXML(_connectionInfo.CacheFile)
                    Catch ex As Exception
                        MessageBox.Show("Invalid cache file: " & vbLf & ex.Message)
                    Finally
                        Cursor = Cursors.[Default]
                    End Try

                    Return
                End If

                If MessageBox.Show("Delete cached data?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Try
                        File.Delete(_connectionInfo.CacheFile)
                        'ignore
                    Catch
                    End Try
                End If
            End If

            'load from database server

            Cursor = Cursors.WaitCursor

            Try
                Dim start As DateTime = DateTime.Now

                ' ask for caching
                If (DateTime.Now - start).Seconds > 60 Then
                    Dim message As [String] = "Do you want to cache the database structure to quicken further loading?"

                    If MessageBox.Show(message, "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        Dim dir As [String] = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\FullFeaturedMdiDemo\"
                        Dim cacheFile As [String] = dir & _connectionInfo.GetHashCode().ToString() & ".xml"

                        If Not Directory.Exists(dir) Then
                            Directory.CreateDirectory(dir)
                        End If

                        ' preload database databases/schemas/objects for export, but skip params/fields/foreign keys
                        _sqlContext.MetadataContainer.LoadAll(False)
                        _sqlContext.MetadataContainer.ExportToXML(cacheFile)
                        _connectionInfo.CacheFile = cacheFile
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Cursor = Cursors.[Default]
            End Try
        End If

        MyBase.OnLoad(e)
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            RemoveHandler Application.Idle, AddressOf Application_Idle

            If components IsNot Nothing Then
                components.Dispose()
            End If
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
            If Not [String].IsNullOrEmpty(rtbQueryText.SelectedText) Then
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

        Dim stats As String = "Used Objects (" & qs.UsedDatabaseObjects.Count & "):" & vbCr & vbLf
        stats = qs.UsedDatabaseObjects.Aggregate(stats, Function(current, t) current & (vbCr & vbLf & t.ObjectName.QualifiedName))

        stats += vbCr & vbLf & vbCr & vbLf & "Used Columns (" & qs.UsedDatabaseObjectFields.Count & "):" & vbCr & vbLf
        stats = qs.UsedDatabaseObjectFields.Aggregate(stats, Function(current, t) current & (vbCr & vbLf & t.ObjectName.QualifiedName))

        stats += vbCr & vbLf & vbCr & vbLf & "Output Expressions (" & qs.OutputColumns.Count & "):" & vbCr & vbLf
        stats = qs.OutputColumns.Aggregate(stats, Function(current, t) current & (vbCr & vbLf & t.Expression))

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
        If QView.AddObjectDialog IsNot Nothing Then
            QView.AddObjectDialog.ShowModal()
        End If
    End Sub

    Public Sub AddDerivedTable()
        Using New UpdateRegion(NavBar.ActiveUnionSubQuery.FromClause)
            Dim sqlContext As SQLContext = NavBar.ActiveUnionSubQuery.SQLContext

            Dim fq As SQLFromQuery = New SQLFromQuery(sqlContext) With {
                .[Alias] = New SQLAliasObjectAlias(sqlContext) With {
                    .[Alias] = NavBar.ActiveUnionSubQuery.QueryRoot.CreateUniqueSubQueryName()
                },
                .SubQuery = New SQLSubSelectStatement(sqlContext)
            }

            Dim sqse As SQLSubQuerySelectExpression = New SQLSubQuerySelectExpression(sqlContext)
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
        Dim usq As UnionSubQuery = QView.ActiveUnionSubQuery.ParentGroup.Add()

        ' copy content
        Dim usqAst As SQLSubQuerySelectExpression = QView.ActiveUnionSubQuery.ResultQueryAST
        usqAst.RestoreColumnPrefixRecursive(True)

        Dim lCte As List(Of SQLWithClauseItem) = New List(Of SQLWithClauseItem)()
        Dim lFromObj As List(Of SQLFromSource) = New List(Of SQLFromSource)()
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
        End If
    End Sub

    Public Sub EditMetadata()
        QueryBuilder.EditMetadataContainer(_sqlContext, _sqlContext.LoadingOptions)
    End Sub

    Public Sub ClearMetadata()
        _sqlContext.MetadataContainer.Clear()
    End Sub

    Public Sub LoadMetadataFromXml()
        Dim fileDialog As New OpenFileDialog() With {
            .Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        }

        If fileDialog.ShowDialog() = DialogResult.OK Then
            _sqlContext.MetadataContainer.LoadingOptions.OfflineMode = True
            _sqlContext.MetadataContainer.ImportFromXML(fileDialog.FileName)
        End If
    End Sub

    Public Sub SaveMetadataToXml()
        Dim fileDialog As New SaveFileDialog() With {
            .Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
            .FileName = "Metadata.xml"
        }
        If fileDialog.ShowDialog() = DialogResult.OK Then
            _sqlContext.MetadataContainer.LoadAll(True)
            _sqlContext.MetadataContainer.ExportToXML(fileDialog.FileName)
        End If
    End Sub

    Public Sub ShowErrorBanner(text As String)
        HideErrorBanner()
        _hasError = True
        Dim label As New Label() With {
            .Name = "ErrorBanner",
            .Text = text,
            .BorderStyle = BorderStyle.FixedSingle,
            .BackColor = Color.LightPink,
            .AutoSize = True,
            .Visible = True
        }
        rtbQueryText.Controls.Add(label)
        rtbQueryText.Controls.SetChildIndex(label, 0)
        label.Location = New Point(rtbQueryText.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2)
    End Sub

    Private Sub HideErrorBanner()
        For Each banner As Label In rtbQueryText.Controls.OfType(Of Label)().Where(Function(item) item.Name.StartsWith("ErrorBanner"))
            banner.Dispose()
        Next
        _hasError = False
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

        '  panelTextInfo.Height = SqlQuery.SleepMode ? 60 : 0;
        toolStripStatusLabel1.Text = "Query builder state: " & (If((SqlQuery.SleepMode), "Inactive", "Active"))
    End Sub

    ' Workaround for the old Microsoft's bug: ImageList damages the alpha channel of 32-bit ICO and PNG files.
    ' Clear all images from designed image lists and reload all images manually.
    Private Sub RepairImageLists()
        imageList1.Images.Clear()
        imageList1.Images.Add(Resources.bricks)
        imageList1.Images.Add(Resources.database_go)

        imageList2.Images.Clear()
        imageList2.Images.Add(Resources.table)
        imageList2.Images.Add(Resources.table_lightning)
        imageList2.Images.Add(Resources.table_gear)
        imageList2.Images.Add(Resources.table_sort)
        imageList2.Images.Add(Resources.folder)
        imageList2.Images.Add(Resources.table_multiple)
        imageList2.Images.Add(Resources.database)

        imageList3.Images.Clear()
        imageList3.Images.Add(Resources.chart_organisation)
        imageList3.Images.Add(Resources.folder_table)
        imageList3.Images.Add(Resources.database_table)
        imageList3.Images.Add(Resources.folder_bullet_green)
        imageList3.Images.Add(Resources.bullet_green)
    End Sub

    Private Sub query_SQLUpdated(sender As Object, e As EventArgs)
        HideErrorBanner()
        rtbQueryText.Text = If(SqlQuery.SleepMode, SqlQuery.SQL, FormattedQueryText)
        If _oldSql Is Nothing Then
            _oldSql = rtbQueryText.Text
        End If

        If QueryView.ActiveUnionSubQuery Is Nothing Or SqlQuery.SleepMode Then
            Return
        End If
        TextBoxCurrentSubQuerySql.Text = QueryView.ActiveUnionSubQuery.ParentSubQuery.GetResultSQL(_sqlFormattingOptions)
    End Sub

    Private Function IsRecursionLoopInQueryText(sql As String) As Boolean
        Using query as SQLQuery = _sqlContext.GetNewSqlQuery()
            query.QueryRoot.AllowSleepMode = True
            query.SQL = sql

            Return Not query.SleepMode AndAlso UserMetadataStructureItem IsNot Nothing AndAlso query.QueryStatistics.UsedDatabaseObjects.Any(Function(x) x.MetadataObject Is UserMetadataStructureItem.MetadataItem)
        End Using
    End Function

    Private Sub rtbQueryText_Validating(sender As Object, e As CancelEventArgs) Handles rtbQueryText.Validating
        ' We need to check that the new text doesn't have references to itself to avoid recursion on generating a query for the server.
        Try
            If IsRecursionLoopInQueryText(rtbQueryText.Text) Then
                Dim message As String = "Recursion loop in virtual objects definition detected for object:" & vbLf & UserMetadataStructureItem.MetadataItem.GetQualifiedNameSQL(Nothing, _sqlGenerationOptions)

                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                rtbQueryText.Text = FormattedQueryText
                Return
            End If
            ' Update the query builder with manually edited query text:
            SqlQuery.SQL = rtbQueryText.Text
            HideErrorBanner()
        Catch ex As SQLParsingException
            ' Set caret to error position
            rtbQueryText.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            ShowErrorBanner(ex.Message)
        End Try
    End Sub

    Private Sub Application_Idle(sender As Object, e As EventArgs)
        Dim supportsDerivedTable As Boolean = False
        Dim supportsUnion As Boolean = False

        If _sqlContext.SyntaxProvider IsNot Nothing Then
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

        RefreshPaginationPanel()
        paginationPanel1.Clear()

        CBuilder.QueryTransformer.BeginUpdate()
        Try
            CBuilder.QueryTransformer.Skip(String.Empty)
            CBuilder.QueryTransformer.Take(String.Empty)
            CBuilder.QueryTransformer.NotifyUpdated()
        Finally
            CBuilder.QueryTransformer.EndUpdate()
        End Try

        Dim sql As String = CBuilder.QueryTransformer.SQL

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

    Private Sub tsmiUndo_Click(sender As Object, e As EventArgs)
        Undo()
    End Sub

    Private Sub tsmiRedo_Click(sender As Object, e As EventArgs)
        Redo()
    End Sub

    Private Sub tsmiCut_Click(sender As Object, e As EventArgs)
        Cut()
    End Sub

    Private Sub tsmiCopy_Click(sender As Object, e As EventArgs)
        Copy()
    End Sub

    Private Sub tsmiPaste_Click(sender As Object, e As EventArgs)
        Paste()
    End Sub

    Private Sub tsmiSelectAll_Click(sender As Object, e As EventArgs)
        SelectAll()
    End Sub

    Friend Function IsOfflineMode() As Boolean
        Return _sqlContext.MetadataContainer.LoadingOptions.OfflineMode
    End Function

    Private Sub tsbQueryProperties_Click(sender As Object, e As EventArgs)
        PropertiesQuery()
    End Sub

    Private Sub tsbAddObject_Click(sender As Object, e As EventArgs)
        AddObject()
    End Sub

    Private Sub tsbAddDerivedTable_Click(sender As Object, e As EventArgs)
        AddDerivedTable()
    End Sub

    Private Sub tsbAddUnionSubquery_Click(sender As Object, e As EventArgs)
        AddUnionSubQuery()
    End Sub

    Private Sub tsbCopyUnionSubquery_Click(sender As Object, e As EventArgs)
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
            'ignore
        Catch
        End Try
    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs)
        SaveQuery()
    End Sub

    Private Sub tsbSaveInFile_Click(sender As Object, e As EventArgs)
        SaveInFile()
    End Sub

    Private Sub tsbSaveNewUserQuery_Click(sender As Object, e As EventArgs)
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

    Private Sub paginationPanel1_EnabledPaginationChanged(sender As Object, e As EventArgs)
        ' Turn paging on and off

        If paginationPanel1.PaginationEnabled Then
            CBuilder.QueryTransformer.Take(paginationPanel1.PageSize.ToString())
        Else
            paginationPanel1.Clear()

            CBuilder.QueryTransformer.BeginUpdate()
            Try
                CBuilder.QueryTransformer.Take("")
                CBuilder.QueryTransformer.Skip("")
            Finally
                CBuilder.QueryTransformer.EndUpdate()
            End Try
        End If
    End Sub

    Private Sub paginationPanel1_CurrentPageChanged(sender As Object, e As EventArgs)
        If paginationPanel1.CurrentPage = 1 Then
            CBuilder.QueryTransformer.Skip("")
            Return
        End If

        ' Setting the current page number
        CBuilder.QueryTransformer.Skip((paginationPanel1.PageSize * (paginationPanel1.CurrentPage - 1)).ToString())
    End Sub

    Private Sub paginationPanel1_PageSizeChanged(sender As Object, e As EventArgs)
        ' Setting the number of records per page
        CBuilder.QueryTransformer.Take(paginationPanel1.PageSize.ToString())
        If paginationPanel1.CurrentPage > 1 Then
            CBuilder.QueryTransformer.Skip((paginationPanel1.PageSize * (paginationPanel1.CurrentPage - 1)).ToString())
        End If
    End Sub

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
        Dim parent1 As Control = DirectCast(sender, Control)
        Dim x As Integer = parent1.Width \ 2 - _noConnectionLabel.Width \ 2
        Dim y As Integer = parent1.Height \ 2 - _noConnectionLabel.Height \ 2
        _noConnectionLabel.Location = New Point(If(x > 0, x, 0), If(y > 0, y, 0))
    End Sub

    ''' <summary>
    ''' Checking for loops on adding an object to the query
    ''' </summary>
    Private Sub QView_DataSourceAdding(fromObject As MetadataObject, ByRef abort As Boolean)
        If UserMetadataStructureItem Is Nothing Then
            Return
        End If

        If fromObject IsNot UserMetadataStructureItem.MetadataItem Then
            Return
        End If

        abort = True

        Dim message As String = "Recursion loop in virtual objects definition detected for object:" & vbLf & UserMetadataStructureItem.MetadataItem.GetQualifiedNameSQL(Nothing, _sqlGenerationOptions)

        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Public Sub OpenExecuteTab()
        tabControl1.SelectedIndex = 1
    End Sub

    Private Sub TextBoxCurrentSubQuerySql_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCurrentSubQuerySql.TextChanged
        If Not tabPageFastResult.Visible OrElse String.IsNullOrEmpty(TextBoxCurrentSubQuerySql.Text) OrElse QView.ActiveUnionSubQuery Is Nothing Then
            infoPanel.Message = ""
            Return
        End If

        FillFastViewDataGrid()
    End Sub

    Private Sub FillFastViewDataGrid()
        If tabControl2.SelectedTab IsNot tabPageFastResult Then
            Return
        End If

        Try
            _queryTransformerTop10.Query = New SQLQuery(QueryView.ActiveUnionSubQuery.ParentSubQuery.SQLContext) With {
                .SQL = QueryView.ActiveUnionSubQuery.ParentSubQuery.GetSqlForDataPreview()
            }

            _timerForFastReuslt.Change(400, Timeout.Infinite)
            'ignore
        Catch
        End Try
    End Sub

    Private Sub tabControl2_Selected(sender As Object, e As TabControlEventArgs) Handles tabControl2.Selected
        If e.Action = TabControlAction.Selected AndAlso e.TabPage Is tabPageFastResult Then
            FillFastViewDataGrid()
        End If
    End Sub

    Private Sub ShowException(exception As Exception, infoPanel As InfoPanel)
        Invoke(DirectCast(Sub() infoPanel.Message = exception.Message, Action))
    End Sub

    Private Sub TextBoxCurrentSubQuerySql_Validating(sender As Object, e As CancelEventArgs) Handles TextBoxCurrentSubQuerySql.Validating
        Try
            infoPanel.Message = ""
            QueryView.ActiveUnionSubQuery.ParentSubQuery.SQL = TextBoxCurrentSubQuerySql.Text
        Catch ex As Exception
            ShowException(ex, infoPanel)
        End Try
    End Sub

    Private Sub RowsLoaded(sender As Object, e As EventArgs) Handles resultGrid1.RowsLoaded
        If Not paginationPanel1.Enabled Then
            paginationPanel1.RowsCount = resultGrid1.RowCount
        End If
    End Sub
End Class
