Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim linkPainterAccess1 As New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.tabControl1 = New TabControl()
        Me.tabPageSQL = New TabPage()
        Me.sqlTextEditor1 = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor()
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.expressionEditor1 = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor(Me.components)
        Me.tabPageData = New TabPage()
        Me.genericSyntaxProvider1 = New ActiveQueryBuilder.Core.GenericSyntaxProvider(Me.components)
        Me.openFileDialog = New OpenFileDialog()
        Me.saveFileDialog = New SaveFileDialog()
        Me.mssqlSyntaxProvider1 = New ActiveQueryBuilder.Core.MSSQLSyntaxProvider(Me.components)
        Me.mssqlMetadataProvider1 = New ActiveQueryBuilder.Core.MSSQLMetadataProvider(Me.components)
        Me.oledbMetadataProvider1 = New ActiveQueryBuilder.Core.OLEDBMetadataProvider(Me.components)
        Me.oracleMetadataProvider1 = New ActiveQueryBuilder.Core.OracleNativeMetadataProvider(Me.components)
        Me.odbcMetadataProvider1 = New ActiveQueryBuilder.Core.ODBCMetadataProvider(Me.components)
        Me.oracleSyntaxProvider1 = New ActiveQueryBuilder.Core.OracleSyntaxProvider(Me.components)
        Me.msaccessSyntaxProvider1 = New ActiveQueryBuilder.Core.MSAccessSyntaxProvider(Me.components)
        Me.mainMenu1 = New MainMenu(Me.components)
        Me.menuItem1 = New MenuItem()
        Me.menuItem5 = New MenuItem()
        Me.menuItem2 = New MenuItem()
        Me.fillProgrammaticallyMenuItem = New MenuItem()
        Me.menuItem3 = New MenuItem()
        Me.refreshMetadataMenuItem = New MenuItem()
        Me.editMetadataMenuItem = New MenuItem()
        Me.clearMetadataMenuItem = New MenuItem()
        Me.menuItem4 = New MenuItem()
        Me.loadMetadataFromXMLMenuItem = New MenuItem()
        Me.saveMetadataToXMLMenuItem = New MenuItem()
        Me.queryStatisticsMenuItem = New MenuItem()
        Me.propertiesMenuItem = New MenuItem()
        Me.aboutMenuItem = New MenuItem()
        Me.panel1 = New Panel()
        Me.linkLabel1 = New LinkLabel()
        Me.splitContainer2 = New SplitContainer()
        Me.labelSleepMode = New Label()
        Me.errorBox1 = New Common.SqlErrorBox()
        Me.dataViewer1 = New DataViewerControl.DataViewer()
        Me.tabControl1.SuspendLayout()
        Me.tabPageSQL.SuspendLayout()
        CType(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageData.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Controls.Add(Me.tabPageSQL)
        Me.tabControl1.Controls.Add(Me.tabPageData)
        Me.tabControl1.Dock = DockStyle.Fill
        Me.tabControl1.Location = New Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New Size(901, 151)
        Me.tabControl1.TabIndex = 0
        '			Me.tabControl1.Selected += New System.Windows.Forms.TabControlEventHandler(Me.tabControl1_Selected)
        ' 
        ' tabPageSQL
        ' 
        Me.tabPageSQL.Controls.Add(Me.errorBox1)
        Me.tabPageSQL.Controls.Add(Me.sqlTextEditor1)
        Me.tabPageSQL.Location = New Point(4, 22)
        Me.tabPageSQL.Name = "tabPageSQL"
        Me.tabPageSQL.Padding = New Padding(3)
        Me.tabPageSQL.Size = New Size(893, 125)
        Me.tabPageSQL.TabIndex = 0
        Me.tabPageSQL.Text = "SQL"
        Me.tabPageSQL.UseVisualStyleBackColor = True
        ' 
        ' sqlTextEditor1
        ' 
        Me.sqlTextEditor1.AllowShowSuggestionByMouse = False
        Me.sqlTextEditor1.BackColor = Color.White
        Me.sqlTextEditor1.BorderStyle = BorderStyle.FixedSingle
        Me.sqlTextEditor1.Dock = DockStyle.Fill
        Me.sqlTextEditor1.Location = New Point(3, 3)
        Me.sqlTextEditor1.Name = "sqlTextEditor1"
        Me.sqlTextEditor1.Options.Font = New Font("Courier New", 9.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.sqlTextEditor1.Options.Padding = New Padding(5, 5, 0, 0)
        Me.sqlTextEditor1.QueryProvider = Me.queryBuilder1
        Me.sqlTextEditor1.Size = New Size(887, 119)
        Me.sqlTextEditor1.SqlOptions.SuggestionWindowSize = New Size(200, 200)
        Me.sqlTextEditor1.TabIndex = 1
        '			Me.sqlTextEditor1.Validating += New System.ComponentModel.CancelEventHandler(Me.sqlTextEditor1_Validating)
        ' 
        ' queryBuilder1
        ' 
        Me.queryBuilder1.AddObjectDialogOptions.Location = New Point(0, 0)
        Me.queryBuilder1.AddObjectDialogOptions.Size = New Size(400, 400)
        Me.queryBuilder1.AddObjectDialogOptions.StartPosition = FormStartPosition.CenterParent
        Me.queryBuilder1.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = False
        Me.queryBuilder1.BorderStyle = BorderStyle.None
        Me.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = False
        Me.queryBuilder1.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder1.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = Color.Black
        Me.queryBuilder1.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = (CType(resources.GetObject("resource.PrimaryKeyIcon"), Image))
        Me.queryBuilder1.DataSourceOptions.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.World)
        Me.queryBuilder1.DesignPaneOptions.Background = SystemColors.Window
        linkPainterAccess1.LinkColor = Color.Black
        linkPainterAccess1.LinkColorFocused = Color.Black
        linkPainterAccess1.MarkColor = SystemColors.Control
        linkPainterAccess1.MarkColorFocused = SystemColors.ControlDark
        linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder1.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1
        Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder1.Dock = DockStyle.Fill
        Me.queryBuilder1.ExpressionEditor = Me.expressionEditor1
        Me.queryBuilder1.Location = New Point(0, 0)
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewDock = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 201
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = True
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = True
        Me.queryBuilder1.PanesConfigurationOptions.QueryColumnsPaneHeight = 150
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = True
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = True
        Me.queryBuilder1.QueryColumnListOptions.AlternateRowColor = SystemColors.Highlight
        Me.queryBuilder1.QueryColumnListOptions.Font = New Font("Segoe UI", 8.25F)
        Me.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = False
        Me.queryBuilder1.QueryColumnListOptions.TextColor = SystemColors.ControlText
        Me.queryBuilder1.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder1.QueryNavBarOptions.ActionButtonBackColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.ActionButtonBorderColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.ActiveSubQueryItemBackColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.ActiveSubQueryItemBorderColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.AddCteCircleColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.AddUnionSubQueryCircleColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.BreadcrumbsBackgroundColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.CTEButtonBaseColor = Color.Green
        Me.queryBuilder1.QueryNavBarOptions.DisableQueryNavigationBarPopup = False
        Me.queryBuilder1.QueryNavBarOptions.DragIndicatorColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.DragIndicatorHoverColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Me.queryBuilder1.QueryNavBarOptions.ForeColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.GraphLineColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.GroupBackColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.GroupTextColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.OverflowButtonBaseColor = Color.DarkRed
        Me.queryBuilder1.QueryNavBarOptions.RootQueryButtonBaseColor = Color.Black
        Me.queryBuilder1.QueryNavBarOptions.SubQueryButtonBaseColor = Color.Blue
        Me.queryBuilder1.QueryNavBarOptions.SubQueryItemBackColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.SubQueryItemBorderColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.SubQueryMarkerColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.SubQueryPopupBackColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.TextHoverColor = Color.Empty
        Me.queryBuilder1.Size = New Size(901, 337)
        ' 
        ' 
        ' 
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DynamicIndents = False
        Me.queryBuilder1.SQLFormattingOptions.DynamicRightMargin = False
        Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = False
        Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = False
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = False
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = False
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        ' 
        ' 
        ' 
        Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = True
        Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = True
        Me.queryBuilder1.SQLGenerationOptions.UseAltNames = False
        Me.queryBuilder1.TabIndex = 6
        Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(157))))))
        Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionFontColor = Color.Black
        Me.queryBuilder1.VisualOptions.DockPanelBackColor = Color.Empty
        Me.queryBuilder1.VisualOptions.DockTabColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.queryBuilder1.VisualOptions.DockTabFontColor = Color.White
        Me.queryBuilder1.VisualOptions.DockTabFontHoverColor = Color.White
        Me.queryBuilder1.VisualOptions.DockTabHoverColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.queryBuilder1.VisualOptions.DockTabIndicatorColor = Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(125))))))
        Me.queryBuilder1.VisualOptions.DockTabIndicatorHoverColor = Color.FromArgb((CInt(Fix((CByte(155))))), (CInt(Fix((CByte(167))))), (CInt(Fix((CByte(183))))))
        Me.queryBuilder1.VisualOptions.InactiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(96))))), (CInt(Fix((CByte(130))))))
        Me.queryBuilder1.VisualOptions.InactiveDockPanelCaptionFontColor = Color.White
        Me.queryBuilder1.VisualOptions.TabFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Me.queryBuilder1.VisualOptions.TabsStripBackColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        '			Me.queryBuilder1.SleepModeChanged += New System.EventHandler(Me.queryBuilder1_SleepModeChanged)
        '			Me.queryBuilder1.QueryAwake += New ActiveQueryBuilder.Core.QueryAwakeEventHandler(Me.queryBuilder1_QueryAwake)
        '			Me.queryBuilder1.SQLUpdated += New System.EventHandler(Me.queryBuilder_SQLUpdated)
        ' 
        ' expressionEditor1
        ' 
        Me.expressionEditor1.BackColor = Color.White
        Me.expressionEditor1.TextColor = SystemColors.ControlText
        ' 
        ' tabPageData
        ' 
        Me.tabPageData.Controls.Add(Me.dataViewer1)
        Me.tabPageData.Location = New Point(4, 22)
        Me.tabPageData.Name = "tabPageData"
        Me.tabPageData.Padding = New Padding(3)
        Me.tabPageData.Size = New Size(893, 131)
        Me.tabPageData.TabIndex = 1
        Me.tabPageData.Text = "Data"
        Me.tabPageData.UseVisualStyleBackColor = True
        ' 
        ' genericSyntaxProvider1
        ' 
        Me.genericSyntaxProvider1.DetectServerVersion = False
        Me.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
        Me.genericSyntaxProvider1.OnCalcExpressionType = Nothing
        ' 
        ' openFileDialog
        ' 
        Me.openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        ' 
        ' saveFileDialog
        ' 
        Me.saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        ' 
        ' mssqlSyntaxProvider1
        ' 
        Me.mssqlSyntaxProvider1.DetectServerVersion = True
        Me.mssqlSyntaxProvider1.OnCalcExpressionType = Nothing
        ' 
        ' mssqlMetadataProvider1
        ' 
        Me.mssqlMetadataProvider1.Connection = Nothing
        ' 
        ' oledbMetadataProvider1
        ' 
        Me.oledbMetadataProvider1.Connection = Nothing
        ' 
        ' oracleMetadataProvider1
        ' 
        Me.oracleMetadataProvider1.Connection = Nothing
        ' 
        ' odbcMetadataProvider1
        ' 
        Me.odbcMetadataProvider1.Connection = Nothing
        ' 
        ' oracleSyntaxProvider1
        ' 
        Me.oracleSyntaxProvider1.DetectServerVersion = True
        Me.oracleSyntaxProvider1.OnCalcExpressionType = Nothing
        Me.oracleSyntaxProvider1.ServerVersion = ActiveQueryBuilder.Core.OracleServerVersion.Oracle18
        ' 
        ' msaccessSyntaxProvider1
        ' 
        Me.msaccessSyntaxProvider1.DetectServerVersion = False
        Me.msaccessSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
        Me.msaccessSyntaxProvider1.OnCalcExpressionType = Nothing
        ' 
        ' mainMenu1
        ' 
        Me.mainMenu1.MenuItems.AddRange(New MenuItem() {Me.menuItem1, Me.menuItem3, Me.queryStatisticsMenuItem, Me.propertiesMenuItem, Me.aboutMenuItem})
        ' 
        ' menuItem1
        ' 
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New MenuItem() {Me.menuItem5, Me.menuItem2, Me.fillProgrammaticallyMenuItem})
        Me.menuItem1.Text = "Connect"
        ' 
        ' menuItem5
        ' 
        Me.menuItem5.Index = 0
        Me.menuItem5.Text = "Connect..."
        '			Me.menuItem5.Click += New System.EventHandler(Me.menuItem5_Click)
        ' 
        ' menuItem2
        ' 
        Me.menuItem2.Index = 1
        Me.menuItem2.Text = "-"
        ' 
        ' fillProgrammaticallyMenuItem
        ' 
        Me.fillProgrammaticallyMenuItem.Index = 2
        Me.fillProgrammaticallyMenuItem.Text = "Fill the query builder programmatically"
        '			Me.fillProgrammaticallyMenuItem.Click += New System.EventHandler(Me.fillProgrammaticallyMenuItem_Click)
        ' 
        ' menuItem3
        ' 
        Me.menuItem3.Index = 1
        Me.menuItem3.MenuItems.AddRange(New MenuItem() {Me.refreshMetadataMenuItem, Me.editMetadataMenuItem, Me.clearMetadataMenuItem, Me.menuItem4, Me.loadMetadataFromXMLMenuItem, Me.saveMetadataToXMLMenuItem})
        Me.menuItem3.Text = "Metadata"
        ' 
        ' refreshMetadataMenuItem
        ' 
        Me.refreshMetadataMenuItem.Index = 0
        Me.refreshMetadataMenuItem.Text = "Refresh Metadata"
        '			Me.refreshMetadataMenuItem.Click += New System.EventHandler(Me.refreshMetadataMenuItem_Click)
        ' 
        ' editMetadataMenuItem
        ' 
        Me.editMetadataMenuItem.Index = 1
        Me.editMetadataMenuItem.Text = "Edit Metadata..."
        '			Me.editMetadataMenuItem.Click += New System.EventHandler(Me.editMetadataMenuItem_Click)
        ' 
        ' clearMetadataMenuItem
        ' 
        Me.clearMetadataMenuItem.Index = 2
        Me.clearMetadataMenuItem.Text = "Clear Metadata"
        '			Me.clearMetadataMenuItem.Click += New System.EventHandler(Me.clearMetadataMenuItem_Click)
        ' 
        ' menuItem4
        ' 
        Me.menuItem4.Index = 3
        Me.menuItem4.Text = "-"
        ' 
        ' loadMetadataFromXMLMenuItem
        ' 
        Me.loadMetadataFromXMLMenuItem.Index = 4
        Me.loadMetadataFromXMLMenuItem.Text = "Load Metadata from XML..."
        '			Me.loadMetadataFromXMLMenuItem.Click += New System.EventHandler(Me.loadMetadataFromXMLMenuItem_Click)
        ' 
        ' saveMetadataToXMLMenuItem
        ' 
        Me.saveMetadataToXMLMenuItem.Index = 5
        Me.saveMetadataToXMLMenuItem.Text = "Save Metadata to XML..."
        '			Me.saveMetadataToXMLMenuItem.Click += New System.EventHandler(Me.saveMetadataToXMLMenuItem_Click)
        ' 
        ' queryStatisticsMenuItem
        ' 
        Me.queryStatisticsMenuItem.Index = 2
        Me.queryStatisticsMenuItem.Text = "Query Statistics..."
        '			Me.queryStatisticsMenuItem.Click += New System.EventHandler(Me.queryStatisticsMenuItem_Click)
        ' 
        ' propertiesMenuItem
        ' 
        Me.propertiesMenuItem.Index = 3
        Me.propertiesMenuItem.Text = "Properties..."
        '			Me.propertiesMenuItem.Click += New System.EventHandler(Me.propertiesMenuItem_Click)
        ' 
        ' aboutMenuItem
        ' 
        Me.aboutMenuItem.Index = 4
        Me.aboutMenuItem.Text = "About..."
        '			Me.aboutMenuItem.Click += New System.EventHandler(Me.aboutMenuItem_Click)
        ' 
        ' panel1
        ' 
        Me.panel1.AutoSize = True
        Me.panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.panel1.BackColor = Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))))
        Me.panel1.BorderStyle = BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.linkLabel1)
        Me.panel1.Dock = DockStyle.Top
        Me.panel1.Location = New Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New Padding(6, 5, 3, 0)
        Me.panel1.Size = New Size(901, 37)
        Me.panel1.TabIndex = 3
        Me.panel1.Visible = False
        ' 
        ' linkLabel1
        ' 
        Me.linkLabel1.AutoEllipsis = True
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.Dock = DockStyle.Fill
        Me.linkLabel1.LinkArea = New LinkArea(269, 22)
        Me.linkLabel1.Location = New Point(6, 5)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New Size(773, 30)
        Me.linkLabel1.TabIndex = 0
        Me.linkLabel1.Text = resources.GetString("linkLabel1.Text")
        Me.linkLabel1.UseCompatibleTextRendering = True
        ' 
        ' splitContainer2
        ' 
        Me.splitContainer2.Dock = DockStyle.Fill
        Me.splitContainer2.Location = New Point(0, 37)
        Me.splitContainer2.Name = "splitContainer2"
        Me.splitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' splitContainer2.Panel1
        ' 
        Me.splitContainer2.Panel1.Controls.Add(Me.queryBuilder1)
        Me.splitContainer2.Panel1.Controls.Add(Me.labelSleepMode)
        ' 
        ' splitContainer2.Panel2
        ' 
        Me.splitContainer2.Panel2.Controls.Add(Me.tabControl1)
        Me.splitContainer2.Size = New Size(901, 530)
        Me.splitContainer2.SplitterDistance = 375
        Me.splitContainer2.TabIndex = 4
        ' 
        ' labelSleepMode
        ' 
        Me.labelSleepMode.AutoEllipsis = True
        Me.labelSleepMode.BackColor = Color.Bisque
        Me.labelSleepMode.BorderStyle = BorderStyle.FixedSingle
        Me.labelSleepMode.Dock = DockStyle.Bottom
        Me.labelSleepMode.Location = New Point(0, 337)
        Me.labelSleepMode.Margin = New Padding(5, 0, 5, 0)
        Me.labelSleepMode.Name = "labelSleepMode"
        Me.labelSleepMode.Padding = New Padding(10)
        Me.labelSleepMode.Size = New Size(901, 38)
        Me.labelSleepMode.TabIndex = 5
        Me.labelSleepMode.Text = "Unsupported SQL statement. Visual Query Builder has been disabled. Either type a " & "SELECT statement or start building a query visually to turn this mode off."
        Me.labelSleepMode.TextAlign = ContentAlignment.MiddleLeft
        Me.labelSleepMode.Visible = False
        ' 
        ' errorBox1
        ' 
        Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox1.AutoSize = True
        Me.errorBox1.BackColor = Color.LightPink
        Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = True
        Me.errorBox1.Location = New Point(531, 19)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New Padding(5)
        Me.errorBox1.Size = New Size(354, 100)
        Me.errorBox1.TabIndex = 2
        Me.errorBox1.Visible = False
        '			Me.errorBox1.GoToErrorPosition += New System.EventHandler(Me.errorBox1_GoToErrorPositionEvent)
        '			Me.errorBox1.RevertValidText += New System.EventHandler(Me.errorBox1_RevertValidTextEvent)
        '			Me.errorBox1.StyleChanged += New System.EventHandler(Me.errorBox1_SyntaxProviderChanged)
        ' 
        ' dataViewer1
        ' 
        Me.dataViewer1.AutoSize = True
        Me.dataViewer1.Dock = DockStyle.Fill
        Me.dataViewer1.Location = New Point(3, 3)
        Me.dataViewer1.Name = "dataViewer1"
        Me.dataViewer1.QueryTransformer = Nothing
        Me.dataViewer1.Size = New Size(887, 125)
        Me.dataViewer1.SqlQuery = Nothing
        Me.dataViewer1.TabIndex = 0
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(901, 567)
        Me.Controls.Add(Me.splitContainer2)
        Me.Controls.Add(Me.panel1)
        Me.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Active Query Builder for .NET WinForms Edition - Basic Demo (C#)"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPageSQL.ResumeLayout(False)
        Me.tabPageSQL.PerformLayout()
        CType(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageData.ResumeLayout(False)
        Me.tabPageData.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel2.ResumeLayout(False)
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents tabControl1 As TabControl
    Private tabPageSQL As TabPage
    Private tabPageData As TabPage
    Private openFileDialog As OpenFileDialog
    Private saveFileDialog As SaveFileDialog
    Private genericSyntaxProvider1 As ActiveQueryBuilder.Core.GenericSyntaxProvider
    Private mssqlSyntaxProvider1 As ActiveQueryBuilder.Core.MSSQLSyntaxProvider
    Private mssqlMetadataProvider1 As ActiveQueryBuilder.Core.MSSQLMetadataProvider
    Private oledbMetadataProvider1 As ActiveQueryBuilder.Core.OLEDBMetadataProvider
    Private oracleMetadataProvider1 As ActiveQueryBuilder.Core.OracleNativeMetadataProvider
    Private odbcMetadataProvider1 As ActiveQueryBuilder.Core.ODBCMetadataProvider
    Private oracleSyntaxProvider1 As ActiveQueryBuilder.Core.OracleSyntaxProvider
    Private msaccessSyntaxProvider1 As ActiveQueryBuilder.Core.MSAccessSyntaxProvider
    Private mainMenu1 As MainMenu
    Private menuItem1 As MenuItem
    Private menuItem2 As MenuItem
    Private WithEvents fillProgrammaticallyMenuItem As MenuItem
    Private menuItem3 As MenuItem
    Private WithEvents refreshMetadataMenuItem As MenuItem
    Private WithEvents editMetadataMenuItem As MenuItem
    Private WithEvents clearMetadataMenuItem As MenuItem
    Private menuItem4 As MenuItem
    Private WithEvents loadMetadataFromXMLMenuItem As MenuItem
    Private WithEvents saveMetadataToXMLMenuItem As MenuItem
    Private WithEvents propertiesMenuItem As MenuItem
    Private WithEvents aboutMenuItem As MenuItem
    Private WithEvents queryStatisticsMenuItem As MenuItem
    Private linkLabel1 As LinkLabel
    Private panel1 As Panel
    Private expressionEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor
    Private WithEvents menuItem5 As MenuItem
    Private WithEvents errorBox1 As Common.SqlErrorBox
    Private WithEvents sqlTextEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor
    Private splitContainer2 As SplitContainer
    Private WithEvents queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private labelSleepMode As Label
    Private dataViewer1 As DataViewerControl.DataViewer
End Class