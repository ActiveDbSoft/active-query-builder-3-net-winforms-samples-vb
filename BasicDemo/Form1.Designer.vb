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
		Dim linkPainterAccess2 As New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
		Dim dataGridViewCellStyle7 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle8 As New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPageSQL = New System.Windows.Forms.TabPage()
		Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
		Me.expressionEditor1 = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor(Me.components)
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
		Me.menuItem5 = New System.Windows.Forms.MenuItem()
		Me.tabControl1.SuspendLayout()
		Me.tabPageSQL.SuspendLayout()
		DirectCast(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.splitContainer1.Panel1.SuspendLayout()
		Me.splitContainer1.Panel2.SuspendLayout()
		Me.splitContainer1.SuspendLayout()
		DirectCast(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tabPageData.SuspendLayout()
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tabControl1
		' 
		Me.tabControl1.Controls.Add(Me.tabPageSQL)
		Me.tabControl1.Controls.Add(Me.tabPageData)
		Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabControl1.Location = New System.Drawing.Point(0, 37)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(884, 538)
		Me.tabControl1.TabIndex = 0
		AddHandler Me.tabControl1.Selected, New System.Windows.Forms.TabControlEventHandler(AddressOf Me.tabControl1_Selected)
		' 
		' tabPageSQL
		' 
		Me.tabPageSQL.Controls.Add(Me.splitContainer1)
		Me.tabPageSQL.Location = New System.Drawing.Point(4, 22)
		Me.tabPageSQL.Name = "tabPageSQL"
		Me.tabPageSQL.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
		Me.tabPageSQL.Size = New System.Drawing.Size(876, 512)
		Me.tabPageSQL.TabIndex = 0
		Me.tabPageSQL.Text = "SQL"
		Me.tabPageSQL.UseVisualStyleBackColor = True
		' 
		' splitContainer1
		' 
		Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.splitContainer1.Location = New System.Drawing.Point(3, 3)
		Me.splitContainer1.Name = "splitContainer1"
		Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		' 
		' splitContainer1.Panel1
		' 
		Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder1)
		' 
		' splitContainer1.Panel2
		' 
		Me.splitContainer1.Panel2.Controls.Add(Me.sqlTextEditor1)
		Me.splitContainer1.Size = New System.Drawing.Size(870, 506)
		Me.splitContainer1.SplitterDistance = 355
		Me.splitContainer1.TabIndex = 0
		' 
		' queryBuilder1
		' 
		Me.queryBuilder1.AddObjectDialogOptions.Location = New System.Drawing.Point(0, 0)
		Me.queryBuilder1.AddObjectDialogOptions.Size = New System.Drawing.Size(400, 400)
		Me.queryBuilder1.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.queryBuilder1.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = False
		Me.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = False
		Me.queryBuilder1.DatabaseSchemaViewOptions.ImageList = Nothing
		Me.queryBuilder1.DesignPaneOptions.Background = System.Drawing.SystemColors.Window
		linkPainterAccess2.LinkColor = System.Drawing.Color.Black
		linkPainterAccess2.LinkColorFocused = System.Drawing.Color.Black
		linkPainterAccess2.MarkColor = System.Drawing.SystemColors.Control
		linkPainterAccess2.MarkColorFocused = System.Drawing.SystemColors.ControlDark
		linkPainterAccess2.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
		Me.queryBuilder1.DesignPaneOptions.LinkPainterOptions = linkPainterAccess2
		Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
		Me.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.queryBuilder1.ExpressionEditor = Me.expressionEditor1
		Me.queryBuilder1.Font = New System.Drawing.Font("Segoe UI", 8.25F)
		Me.queryBuilder1.Location = New System.Drawing.Point(0, 0)
		Me.queryBuilder1.MetadataStructureOptions.ProceduresFolderText = "Procedures"
		Me.queryBuilder1.MetadataStructureOptions.SynonymsFolderText = "Synonyms"
		Me.queryBuilder1.MetadataStructureOptions.TablesFolderText = "Tables"
		Me.queryBuilder1.MetadataStructureOptions.ViewsFolderText = "Views"
		Me.queryBuilder1.Name = "queryBuilder1"
		Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 201
		Me.queryBuilder1.PanesConfigurationOptions.DisableQueryNavigationBarPopup = False
		Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = True
		Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
		Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = True
		Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = True
		Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
		Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = True
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Caption = "Aggregate"
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Caption = "Column Name"
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Caption = "Criteria for"
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 70
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Caption = "Criteria"
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 60
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Caption = "Or..."
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Caption = "Expression"
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 150
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Caption = "Grouping"
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 80
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Caption = "Visible"
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Caption = "Sort Order"
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 90
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Caption = "Sort Type"
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3
		Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 80
		Me.queryBuilder1.QueryColumnListOptions.Font = New System.Drawing.Font("Segoe UI", 8.25F)
		Me.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2
		Me.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = False
		Me.queryBuilder1.QueryColumnListOptions.RowHeadersWidth = 15
		Me.queryBuilder1.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
		Me.queryBuilder1.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green
		Me.queryBuilder1.QueryNavBarOptions.DisableQueryNavigationBarPopup = False
		Me.queryBuilder1.QueryNavBarOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.queryBuilder1.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
		Me.queryBuilder1.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black
		Me.queryBuilder1.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue
		Me.queryBuilder1.Size = New System.Drawing.Size(870, 355)
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
		Me.queryBuilder1.TabIndex = 0
		Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(242)), CInt(CByte(157)))
		Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black
		Me.queryBuilder1.VisualOptions.DockTabColor = System.Drawing.Color.FromArgb(CInt(CByte(41)), CInt(CByte(57)), CInt(CByte(85)))
		Me.queryBuilder1.VisualOptions.DockTabFontColor = System.Drawing.Color.White
		Me.queryBuilder1.VisualOptions.DockTabFontHoverColor = System.Drawing.Color.White
		Me.queryBuilder1.VisualOptions.DockTabHoverColor = System.Drawing.Color.FromArgb(CInt(CByte(41)), CInt(CByte(57)), CInt(CByte(85)))
		Me.queryBuilder1.VisualOptions.DockTabIndicatorColor = System.Drawing.Color.FromArgb(CInt(CByte(70)), CInt(CByte(90)), CInt(CByte(125)))
		Me.queryBuilder1.VisualOptions.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(CInt(CByte(155)), CInt(CByte(167)), CInt(CByte(183)))
		Me.queryBuilder1.VisualOptions.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CInt(CByte(77)), CInt(CByte(96)), CInt(CByte(130)))
		Me.queryBuilder1.VisualOptions.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White
		Me.queryBuilder1.VisualOptions.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.queryBuilder1.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(CInt(CByte(41)), CInt(CByte(57)), CInt(CByte(85)))
		AddHandler Me.queryBuilder1.SQLUpdated, New System.EventHandler(AddressOf Me.queryBuilder_SQLUpdated)
		' 
		' expressionEditor1
		' 
		Me.expressionEditor1.CloseOnEscape = False
		Me.expressionEditor1.Expression = ""
		Me.expressionEditor1.Height = 0
		Me.expressionEditor1.KeepMetadataObjectsOnTopOfSuggestionList = True
		Me.expressionEditor1.TextEditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.expressionEditor1.Width = 0
		' 
		' sqlTextEditor1
		' 
		Me.sqlTextEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.sqlTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.sqlTextEditor1.Font = New System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.sqlTextEditor1.KeepMetadataObjectsOnTopOfSuggestionList = True
		Me.sqlTextEditor1.Location = New System.Drawing.Point(0, 0)
		Me.sqlTextEditor1.Name = "sqlTextEditor1"
		Me.sqlTextEditor1.QueryProvider = Me.queryBuilder1
		Me.sqlTextEditor1.Size = New System.Drawing.Size(870, 147)
		Me.sqlTextEditor1.SuggestionWindowSize = New System.Drawing.Size(200, 200)
		Me.sqlTextEditor1.TabIndex = 0
		AddHandler Me.sqlTextEditor1.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.sqlTextEditor1_Validating)
		' 
		' tabPageData
		' 
		Me.tabPageData.Controls.Add(Me.dataGridView1)
		Me.tabPageData.Location = New System.Drawing.Point(4, 22)
		Me.tabPageData.Name = "tabPageData"
		Me.tabPageData.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
		Me.tabPageData.Size = New System.Drawing.Size(876, 518)
		Me.tabPageData.TabIndex = 1
		Me.tabPageData.Text = "Data"
		Me.tabPageData.UseVisualStyleBackColor = True
		' 
		' dataGridView1
		' 
		Me.dataGridView1.AllowUserToAddRows = False
		Me.dataGridView1.AllowUserToDeleteRows = False
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8
		Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dataGridView1.Location = New System.Drawing.Point(3, 3)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.[ReadOnly] = True
		Me.dataGridView1.Size = New System.Drawing.Size(870, 512)
		Me.dataGridView1.TabIndex = 0
		' 
		' genericSyntaxProvider1
		' 
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
		Me.oracleSyntaxProvider1.OnCalcExpressionType = Nothing
		Me.oracleSyntaxProvider1.ServerVersion = ActiveQueryBuilder.Core.OracleServerVersion.Oracle10
		' 
		' msaccessSyntaxProvider1
		' 
		Me.msaccessSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
		Me.msaccessSyntaxProvider1.OnCalcExpressionType = Nothing
		' 
		' mainMenu1
		' 
		Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem3, Me.queryStatisticsMenuItem, Me.propertiesMenuItem, Me.aboutMenuItem})
		' 
		' menuItem1
		' 
		Me.menuItem1.Index = 0
		Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem5, Me.menuItem2, Me.fillProgrammaticallyMenuItem})
		Me.menuItem1.Text = "Connect"
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
		AddHandler Me.fillProgrammaticallyMenuItem.Click, New System.EventHandler(AddressOf Me.fillProgrammaticallyMenuItem_Click)
		' 
		' menuItem3
		' 
		Me.menuItem3.Index = 1
		Me.menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.refreshMetadataMenuItem, Me.editMetadataMenuItem, Me.clearMetadataMenuItem, Me.menuItem4, Me.loadMetadataFromXMLMenuItem, Me.saveMetadataToXMLMenuItem})
		Me.menuItem3.Text = "Metadata"
		' 
		' refreshMetadataMenuItem
		' 
		Me.refreshMetadataMenuItem.Index = 0
		Me.refreshMetadataMenuItem.Text = "Refresh Metadata"
		AddHandler Me.refreshMetadataMenuItem.Click, New System.EventHandler(AddressOf Me.refreshMetadataMenuItem_Click)
		' 
		' editMetadataMenuItem
		' 
		Me.editMetadataMenuItem.Index = 1
		Me.editMetadataMenuItem.Text = "Edit Metadata..."
		AddHandler Me.editMetadataMenuItem.Click, New System.EventHandler(AddressOf Me.editMetadataMenuItem_Click)
		' 
		' clearMetadataMenuItem
		' 
		Me.clearMetadataMenuItem.Index = 2
		Me.clearMetadataMenuItem.Text = "Clear Metadata"
		AddHandler Me.clearMetadataMenuItem.Click, New System.EventHandler(AddressOf Me.clearMetadataMenuItem_Click)
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
		AddHandler Me.loadMetadataFromXMLMenuItem.Click, New System.EventHandler(AddressOf Me.loadMetadataFromXMLMenuItem_Click)
		' 
		' saveMetadataToXMLMenuItem
		' 
		Me.saveMetadataToXMLMenuItem.Index = 5
		Me.saveMetadataToXMLMenuItem.Text = "Save Metadata to XML..."
		AddHandler Me.saveMetadataToXMLMenuItem.Click, New System.EventHandler(AddressOf Me.saveMetadataToXMLMenuItem_Click)
		' 
		' queryStatisticsMenuItem
		' 
		Me.queryStatisticsMenuItem.Index = 2
		Me.queryStatisticsMenuItem.Text = "Query Statistics..."
		AddHandler Me.queryStatisticsMenuItem.Click, New System.EventHandler(AddressOf Me.queryStatisticsMenuItem_Click)
		' 
		' propertiesMenuItem
		' 
		Me.propertiesMenuItem.Index = 3
		Me.propertiesMenuItem.Text = "Properties..."
		AddHandler Me.propertiesMenuItem.Click, New System.EventHandler(AddressOf Me.propertiesMenuItem_Click)
		' 
		' aboutMenuItem
		' 
		Me.aboutMenuItem.Index = 4
		Me.aboutMenuItem.Text = "About..."
		AddHandler Me.aboutMenuItem.Click, New System.EventHandler(AddressOf Me.aboutMenuItem_Click)
		' 
		' panel1
		' 
		Me.panel1.AutoSize = True
		Me.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panel1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(255)), CInt(CByte(192)))
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.linkLabel1)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Padding = New System.Windows.Forms.Padding(6, 5, 3, 0)
		Me.panel1.Size = New System.Drawing.Size(884, 37)
		Me.panel1.TabIndex = 3
		Me.panel1.Visible = False
		' 
		' linkLabel1
		' 
		Me.linkLabel1.AutoEllipsis = True
		Me.linkLabel1.AutoSize = True
		Me.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.linkLabel1.LinkArea = New System.Windows.Forms.LinkArea(269, 22)
		Me.linkLabel1.Location = New System.Drawing.Point(6, 5)
		Me.linkLabel1.Name = "linkLabel1"
		Me.linkLabel1.Size = New System.Drawing.Size(773, 30)
		Me.linkLabel1.TabIndex = 0
		Me.linkLabel1.Text = resources.GetString("linkLabel1.Text")
		Me.linkLabel1.UseCompatibleTextRendering = True
		' 
		' menuItem5
		' 
		Me.menuItem5.Index = 0
		Me.menuItem5.Text = "Connect..."
		AddHandler Me.menuItem5.Click, New System.EventHandler(AddressOf Me.menuItem5_Click)
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(884, 575)
		Me.Controls.Add(Me.tabControl1)
		Me.Controls.Add(Me.panel1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Menu = Me.mainMenu1
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Active Query Builder for .NET WinForms Edition - Basic Demo (C#)"
		Me.tabControl1.ResumeLayout(False)
		Me.tabPageSQL.ResumeLayout(False)
		Me.splitContainer1.Panel1.ResumeLayout(False)
		Me.splitContainer1.Panel2.ResumeLayout(False)
		DirectCast(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.splitContainer1.ResumeLayout(False)
		DirectCast(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tabPageData.ResumeLayout(False)
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panel1.ResumeLayout(False)
		Me.panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private tabControl1 As System.Windows.Forms.TabControl
	Private tabPageSQL As System.Windows.Forms.TabPage
	Private tabPageData As System.Windows.Forms.TabPage
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private sqlTextEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor
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
	Private mainMenu1 As System.Windows.Forms.MainMenu
	Private menuItem1 As System.Windows.Forms.MenuItem
	Private menuItem2 As System.Windows.Forms.MenuItem
	Private fillProgrammaticallyMenuItem As System.Windows.Forms.MenuItem
	Private menuItem3 As System.Windows.Forms.MenuItem
	Private refreshMetadataMenuItem As System.Windows.Forms.MenuItem
	Private editMetadataMenuItem As System.Windows.Forms.MenuItem
	Private clearMetadataMenuItem As System.Windows.Forms.MenuItem
	Private menuItem4 As System.Windows.Forms.MenuItem
	Private loadMetadataFromXMLMenuItem As System.Windows.Forms.MenuItem
	Private saveMetadataToXMLMenuItem As System.Windows.Forms.MenuItem
	Private propertiesMenuItem As System.Windows.Forms.MenuItem
	Private aboutMenuItem As System.Windows.Forms.MenuItem
	Private queryStatisticsMenuItem As System.Windows.Forms.MenuItem
	Private linkLabel1 As System.Windows.Forms.LinkLabel
	Private panel1 As System.Windows.Forms.Panel
	Private queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private expressionEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor
	Private menuItem5 As System.Windows.Forms.MenuItem
End Class
