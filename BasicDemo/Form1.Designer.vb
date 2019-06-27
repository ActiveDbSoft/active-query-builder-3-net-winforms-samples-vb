Imports System.Drawing
Imports ActiveQueryBuilder.View

Partial Class Form1
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
        Dim LinkPainterAccess1 As ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess = New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPageSQL = New System.Windows.Forms.TabPage()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.expressionEditor1 = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor(Me.components)
        Me.labelSleepMode = New System.Windows.Forms.Label()
        Me.sqlTextEditor1 = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor()
        Me.tabPageData = New System.Windows.Forms.TabPage()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.genericSyntaxProvider1 = New ActiveQueryBuilder.Core.GenericSyntaxProvider(Me.components)
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.mssqlSyntaxProvider1 = New ActiveQueryBuilder.Core.MSSQLSyntaxProvider(Me.components)
        Me.mssqlMetadataProvider1 = New ActiveQueryBuilder.Core.MSSQLMetadataProvider(Me.components)
        Me.oledbMetadataProvider1 = New ActiveQueryBuilder.Core.OLEDBMetadataProvider(Me.components)
        Me.oracleMetadataProvider1 = New ActiveQueryBuilder.Core.OracleNativeMetadataProvider(Me.components)
        Me.odbcMetadataProvider1 = New ActiveQueryBuilder.Core.ODBCMetadataProvider(Me.components)
        Me.oracleSyntaxProvider1 = New ActiveQueryBuilder.Core.OracleSyntaxProvider(Me.components)
        Me.msaccessSyntaxProvider1 = New ActiveQueryBuilder.Core.MSAccessSyntaxProvider(Me.components)
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.fillProgrammaticallyMenuItem = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.refreshMetadataMenuItem = New System.Windows.Forms.MenuItem()
        Me.editMetadataMenuItem = New System.Windows.Forms.MenuItem()
        Me.clearMetadataMenuItem = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.loadMetadataFromXMLMenuItem = New System.Windows.Forms.MenuItem()
        Me.saveMetadataToXMLMenuItem = New System.Windows.Forms.MenuItem()
        Me.queryStatisticsMenuItem = New System.Windows.Forms.MenuItem()
        Me.propertiesMenuItem = New System.Windows.Forms.MenuItem()
        Me.aboutMenuItem = New System.Windows.Forms.MenuItem()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ErrorBox1 = New BasicDemo.Common.ErrorBox()
        Me.tabControl1.SuspendLayout
        Me.tabPageSQL.SuspendLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer1.Panel1.SuspendLayout
        Me.splitContainer1.Panel2.SuspendLayout
        Me.splitContainer1.SuspendLayout
        CType(Me.queryBuilder1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder1.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder1.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPageData.SuspendLayout
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.panel1.SuspendLayout
        Me.SuspendLayout
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPageSQL)
        Me.tabControl1.Controls.Add(Me.tabPageData)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Location = New System.Drawing.Point(0, 37)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(884, 517)
        Me.tabControl1.TabIndex = 0
        '
        'tabPageSQL
        '
        Me.tabPageSQL.Controls.Add(Me.splitContainer1)
        Me.tabPageSQL.Location = New System.Drawing.Point(4, 22)
        Me.tabPageSQL.Name = "tabPageSQL"
        Me.tabPageSQL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageSQL.Size = New System.Drawing.Size(876, 491)
        Me.tabPageSQL.TabIndex = 0
        Me.tabPageSQL.Text = "SQL"
        Me.tabPageSQL.UseVisualStyleBackColor = true
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder1)
        Me.splitContainer1.Panel1.Controls.Add(Me.labelSleepMode)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.ErrorBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.sqlTextEditor1)
        Me.splitContainer1.Size = New System.Drawing.Size(870, 485)
        Me.splitContainer1.SplitterDistance = 340
        Me.splitContainer1.TabIndex = 0
        '
        'queryBuilder1
        '
        Me.queryBuilder1.AddObjectDialogOptions.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder1.AddObjectDialogOptions.Size = New System.Drawing.Size(400, 400)
        Me.queryBuilder1.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.queryBuilder1.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = false
        Me.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = false
        Me.queryBuilder1.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder1.DesignPaneOptions.Background = System.Drawing.SystemColors.Window
        LinkPainterAccess1.LinkColor = System.Drawing.Color.Black
        LinkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black
        LinkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control
        LinkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark
        LinkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder1.DesignPaneOptions.LinkPainterOptions = LinkPainterAccess1
        Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.queryBuilder1.ExpressionEditor = Me.expressionEditor1
        Me.queryBuilder1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.queryBuilder1.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 201
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = true
        Me.queryBuilder1.PanesConfigurationOptions.QueryColumnsPaneHeight = 126
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = true
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 140R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 200R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 250R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 100R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 100R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 60R
        Me.queryBuilder1.QueryColumnListOptions.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = false
        Me.queryBuilder1.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder1.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green
        Me.queryBuilder1.QueryNavBarOptions.DisableQueryNavigationBarPopup = false
        Me.queryBuilder1.QueryNavBarOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.queryBuilder1.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
        Me.queryBuilder1.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black
        Me.queryBuilder1.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue
        Me.queryBuilder1.Size = New System.Drawing.Size(870, 306)
        '
        '
        '
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DynamicIndents = false
        Me.queryBuilder1.SQLFormattingOptions.DynamicRightMargin = false
        Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = false
        Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = false
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = false
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        '
        '
        '
        Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = true
        Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = true
        Me.queryBuilder1.SQLGenerationOptions.UseAltNames = false
        Me.queryBuilder1.TabIndex = 4
        Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(242,Byte),Integer), CType(CType(157,Byte),Integer))
        Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black
        Me.queryBuilder1.VisualOptions.DockTabColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.queryBuilder1.VisualOptions.DockTabFontColor = System.Drawing.Color.White
        Me.queryBuilder1.VisualOptions.DockTabFontHoverColor = System.Drawing.Color.White
        Me.queryBuilder1.VisualOptions.DockTabHoverColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.queryBuilder1.VisualOptions.DockTabIndicatorColor = System.Drawing.Color.FromArgb(CType(CType(70,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(125,Byte),Integer))
        Me.queryBuilder1.VisualOptions.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(CType(CType(155,Byte),Integer), CType(CType(167,Byte),Integer), CType(CType(183,Byte),Integer))
        Me.queryBuilder1.VisualOptions.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(96,Byte),Integer), CType(CType(130,Byte),Integer))
        Me.queryBuilder1.VisualOptions.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White
        Me.queryBuilder1.VisualOptions.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.queryBuilder1.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        '
        'expressionEditor1
        '
        Me.expressionEditor1.ActiveUnionSubQuery = Nothing
        Me.expressionEditor1.CloseOnEscape = false
        Me.expressionEditor1.Expression = ""
        Me.expressionEditor1.Height = 0
        Me.expressionEditor1.HighlightMatchingParentheses = ActiveQueryBuilder.View.ExpressionEditor.ParenthesesHighlighting.NoHighlight
        Me.expressionEditor1.KeepMetadataObjectsOnTopOfSuggestionList = true
        Me.expressionEditor1.LoadMetadataOnCodeCompletion = true
        Me.expressionEditor1.SearchFields = false
        Me.expressionEditor1.TextEditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.expressionEditor1.Width = 0
        '
        'labelSleepMode
        '
        Me.labelSleepMode.AutoEllipsis = true
        Me.labelSleepMode.BackColor = System.Drawing.Color.Bisque
        Me.labelSleepMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelSleepMode.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.labelSleepMode.Location = New System.Drawing.Point(0, 306)
        Me.labelSleepMode.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.labelSleepMode.Name = "labelSleepMode"
        Me.labelSleepMode.Padding = New System.Windows.Forms.Padding(10)
        Me.labelSleepMode.Size = New System.Drawing.Size(870, 34)
        Me.labelSleepMode.TabIndex = 3
        Me.labelSleepMode.Text = "Unsupported SQL statement. Visual Query Builder has been disabled. Either type a "& _ 
    "SELECT statement or start building a query visually to turn this mode off."
        Me.labelSleepMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.labelSleepMode.Visible = false
        '
        'sqlTextEditor1
        '
        Me.sqlTextEditor1.AcceptTabs = false
        Me.sqlTextEditor1.AllowShowSuggestionByMouse = false
        Me.sqlTextEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sqlTextEditor1.CaretOffset = 0
        Me.sqlTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sqlTextEditor1.Location = New System.Drawing.Point(0, 0)
        Me.sqlTextEditor1.Name = "sqlTextEditor1"
        Me.sqlTextEditor1.Options.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.sqlTextEditor1.Padding = New System.Windows.Forms.Padding(0)
        Me.sqlTextEditor1.Query = Nothing
        Me.sqlTextEditor1.QueryProvider = Nothing
        Me.sqlTextEditor1.SelectedText = ""
        Me.sqlTextEditor1.SelectionLength = 0
        Me.sqlTextEditor1.SelectionStart = 0
        Me.sqlTextEditor1.Size = New System.Drawing.Size(870, 141)
        Me.sqlTextEditor1.SQLContext = Nothing
        Me.sqlTextEditor1.SqlOptions.SuggestionWindowSize = New System.Drawing.Size(200, 200)
        Me.sqlTextEditor1.SuggestionWindowSize = New System.Drawing.Size(200, 200)
        Me.sqlTextEditor1.TabIndex = 0
        '
        'tabPageData
        '
        Me.tabPageData.Controls.Add(Me.dataGridView1)
        Me.tabPageData.Location = New System.Drawing.Point(4, 22)
        Me.tabPageData.Name = "tabPageData"
        Me.tabPageData.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageData.Size = New System.Drawing.Size(876, 512)
        Me.tabPageData.TabIndex = 1
        Me.tabPageData.Text = "Data"
        Me.tabPageData.UseVisualStyleBackColor = true
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = false
        Me.dataGridView1.AllowUserToDeleteRows = false
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = true
        Me.dataGridView1.Size = New System.Drawing.Size(870, 506)
        Me.dataGridView1.TabIndex = 0
        '
        'genericSyntaxProvider1
        '
        Me.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
        Me.genericSyntaxProvider1.OnCalcExpressionType = Nothing
        '
        'openFileDialog
        '
        Me.openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        '
        'saveFileDialog
        '
        Me.saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        '
        'mssqlSyntaxProvider1
        '
        Me.mssqlSyntaxProvider1.OnCalcExpressionType = Nothing
        '
        'mssqlMetadataProvider1
        '
        Me.mssqlMetadataProvider1.Connection = Nothing
        '
        'oledbMetadataProvider1
        '
        Me.oledbMetadataProvider1.Connection = Nothing
        '
        'oracleMetadataProvider1
        '
        Me.oracleMetadataProvider1.Connection = Nothing
        '
        'odbcMetadataProvider1
        '
        Me.odbcMetadataProvider1.Connection = Nothing
        '
        'oracleSyntaxProvider1
        '
        Me.oracleSyntaxProvider1.OnCalcExpressionType = Nothing
        Me.oracleSyntaxProvider1.ServerVersion = ActiveQueryBuilder.Core.OracleServerVersion.Oracle10
        '
        'msaccessSyntaxProvider1
        '
        Me.msaccessSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
        Me.msaccessSyntaxProvider1.OnCalcExpressionType = Nothing
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem3, Me.queryStatisticsMenuItem, Me.propertiesMenuItem, Me.aboutMenuItem})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem5, Me.menuItem2, Me.fillProgrammaticallyMenuItem})
        Me.menuItem1.Text = "Connect"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 0
        Me.menuItem5.Text = "Connect..."
        '
        'menuItem2
        '
        Me.menuItem2.Index = 1
        Me.menuItem2.Text = "-"
        '
        'fillProgrammaticallyMenuItem
        '
        Me.fillProgrammaticallyMenuItem.Index = 2
        Me.fillProgrammaticallyMenuItem.Text = "Fill the query builder programmatically"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 1
        Me.menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.refreshMetadataMenuItem, Me.editMetadataMenuItem, Me.clearMetadataMenuItem, Me.menuItem4, Me.loadMetadataFromXMLMenuItem, Me.saveMetadataToXMLMenuItem})
        Me.menuItem3.Text = "Metadata"
        '
        'refreshMetadataMenuItem
        '
        Me.refreshMetadataMenuItem.Index = 0
        Me.refreshMetadataMenuItem.Text = "Refresh Metadata"
        '
        'editMetadataMenuItem
        '
        Me.editMetadataMenuItem.Index = 1
        Me.editMetadataMenuItem.Text = "Edit Metadata..."
        '
        'clearMetadataMenuItem
        '
        Me.clearMetadataMenuItem.Index = 2
        Me.clearMetadataMenuItem.Text = "Clear Metadata"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 3
        Me.menuItem4.Text = "-"
        '
        'loadMetadataFromXMLMenuItem
        '
        Me.loadMetadataFromXMLMenuItem.Index = 4
        Me.loadMetadataFromXMLMenuItem.Text = "Load Metadata from XML..."
        '
        'saveMetadataToXMLMenuItem
        '
        Me.saveMetadataToXMLMenuItem.Index = 5
        Me.saveMetadataToXMLMenuItem.Text = "Save Metadata to XML..."
        '
        'queryStatisticsMenuItem
        '
        Me.queryStatisticsMenuItem.Index = 2
        Me.queryStatisticsMenuItem.Text = "Query Statistics..."
        '
        'propertiesMenuItem
        '
        Me.propertiesMenuItem.Index = 3
        Me.propertiesMenuItem.Text = "Properties..."
        '
        'aboutMenuItem
        '
        Me.aboutMenuItem.Index = 4
        Me.aboutMenuItem.Text = "About..."
        '
        'panel1
        '
        Me.panel1.AutoSize = true
        Me.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.linkLabel1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(6, 5, 3, 0)
        Me.panel1.Size = New System.Drawing.Size(884, 37)
        Me.panel1.TabIndex = 3
        Me.panel1.Visible = false
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoEllipsis = true
        Me.linkLabel1.AutoSize = true
        Me.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.linkLabel1.LinkArea = New System.Windows.Forms.LinkArea(269, 22)
        Me.linkLabel1.Location = New System.Drawing.Point(6, 5)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(773, 30)
        Me.linkLabel1.TabIndex = 0
        Me.linkLabel1.Text = resources.GetString("linkLabel1.Text")
        Me.linkLabel1.UseCompatibleTextRendering = true
        '
        'ErrorBox1
        '
        Me.ErrorBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ErrorBox1.AutoSize = true
        Me.ErrorBox1.BackColor = System.Drawing.Color.LightPink
        Me.ErrorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorBox1.CurrentSyntaxProvider = Nothing
        Me.ErrorBox1.Location = New System.Drawing.Point(577, 36)
        Me.ErrorBox1.Message = "Some Text"
        Me.ErrorBox1.Name = "ErrorBox1"
        Me.ErrorBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.ErrorBox1.Size = New System.Drawing.Size(288, 100)
        Me.ErrorBox1.TabIndex = 1
        Me.ErrorBox1.Visible = false
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 554)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Active Query Builder for .NET WinForms Edition - Basic Demo (C#)"
        Me.tabControl1.ResumeLayout(false)
        Me.tabPageSQL.ResumeLayout(false)
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        Me.splitContainer1.Panel2.PerformLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        CType(Me.queryBuilder1.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder1.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder1,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPageData.ResumeLayout(false)
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

	#End Region

	Private WithEvents tabControl1 As System.Windows.Forms.TabControl
	Private tabPageSQL As System.Windows.Forms.TabPage
	Private tabPageData As System.Windows.Forms.TabPage
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private WithEvents sqlTextEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private openFileDialog As System.Windows.Forms.OpenFileDialog
	Private saveFileDialog As System.Windows.Forms.SaveFileDialog
	Private genericSyntaxProvider1 As ActiveQueryBuilder.Core.GenericSyntaxProvider
	Private mssqlSyntaxProvider1 As ActiveQueryBuilder.Core.MSSQLSyntaxProvider
	Private mssqlMetadataProvider1 As ActiveQueryBuilder.Core.MSSQLMetadataProvider
	Private oledbMetadataProvider1 As ActiveQueryBuilder.Core.OLEDBMetadataProvider
	Private oracleMetadataProvider1 As ActiveQueryBuilder.Core.OracleNativeMetadataProvider
	Private odbcMetadataProvider1 As ActiveQueryBuilder.Core.ODBCMetadataProvider
	Private oracleSyntaxProvider1 As ActiveQueryBuilder.Core.OracleSyntaxProvider
	Private msaccessSyntaxProvider1 As ActiveQueryBuilder.Core.MSAccessSyntaxProvider
	Private WithEvents mainMenu1 As System.Windows.Forms.MainMenu
	Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
	Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
	Private WithEvents fillProgrammaticallyMenuItem As System.Windows.Forms.MenuItem
	Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
	Private WithEvents refreshMetadataMenuItem As System.Windows.Forms.MenuItem
	Private WithEvents editMetadataMenuItem As System.Windows.Forms.MenuItem
	Private WithEvents clearMetadataMenuItem As System.Windows.Forms.MenuItem
	Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
	Private WithEvents loadMetadataFromXMLMenuItem As System.Windows.Forms.MenuItem
	Private WithEvents saveMetadataToXMLMenuItem As System.Windows.Forms.MenuItem
	Private WithEvents propertiesMenuItem As System.Windows.Forms.MenuItem
	Private WithEvents aboutMenuItem As System.Windows.Forms.MenuItem
	Private WithEvents queryStatisticsMenuItem As System.Windows.Forms.MenuItem
	Private linkLabel1 As System.Windows.Forms.LinkLabel
	Private panel1 As System.Windows.Forms.Panel
	Private expressionEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor
	Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents queryBuilder1 As WinForms.QueryBuilder
    Private WithEvents labelSleepMode As System.Windows.Forms.Label
    Friend WithEvents ErrorBox1 As Common.ErrorBox
End Class
