
Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim linkPainterAccess1 As New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tabControl1 = New TabControl()
        Me.tabPageSQL = New TabPage()
        Me.splitContainer1 = New SplitContainer()
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.errorBox1 = New Common.SqlErrorBox()
        Me.textBox1 = New TextBox()
        Me.panel2 = New Panel()
        Me.breadcrumbControl1 = New ActiveQueryBuilder.View.WinForms.NavigationBar.SubQueryBreadcrumbsBar()
        Me.panel3 = New Panel()
        Me.button1 = New Button()
        Me.tabPageData = New TabPage()
        Me.dataGridView1 = New DataViewerControl.DataViewer()
        Me.openFileDialog = New OpenFileDialog()
        Me.saveFileDialog = New SaveFileDialog()
        Me.mssqlMetadataProvider1 = New ActiveQueryBuilder.Core.MSSQLMetadataProvider(Me.components)
        Me.oledbMetadataProvider1 = New ActiveQueryBuilder.Core.OLEDBMetadataProvider(Me.components)
        Me.odbcMetadataProvider1 = New ActiveQueryBuilder.Core.ODBCMetadataProvider(Me.components)
        Me.mainMenu1 = New MainMenu(Me.components)
        Me.menuItem1 = New MenuItem()
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
        Me.genericSyntaxProvider1 = New ActiveQueryBuilder.Core.GenericSyntaxProvider(Me.components)
        Me.mssqlSyntaxProvider1 = New ActiveQueryBuilder.Core.MSSQLSyntaxProvider(Me.components)
        Me.oracleSyntaxProvider1 = New ActiveQueryBuilder.Core.OracleSyntaxProvider(Me.components)
        Me.msaccessSyntaxProvider1 = New ActiveQueryBuilder.Core.MSAccessSyntaxProvider(Me.components)
        Me.cmEditMode = New ContextMenuStrip(Me.components)
        Me.tsmiEntire = New ToolStripMenuItem()
        Me.tsmiSubQuery = New ToolStripMenuItem()
        Me.tsmiExpression = New ToolStripMenuItem()
        Me.menuItemConnectTo = New MenuItem()
        Me.tabControl1.SuspendLayout()
        Me.tabPageSQL.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.tabPageData.SuspendLayout()

        Me.panel1.SuspendLayout()
        Me.cmEditMode.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Controls.Add(Me.tabPageSQL)
        Me.tabControl1.Controls.Add(Me.tabPageData)
        Me.tabControl1.Dock = DockStyle.Fill
        Me.tabControl1.Location = New Point(0, 37)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New Size(884, 414)
        Me.tabControl1.TabIndex = 0
'			Me.tabControl1.Selected += New System.Windows.Forms.TabControlEventHandler(Me.tabControl1_Selected)
        ' 
        ' tabPageSQL
        ' 
        Me.tabPageSQL.Controls.Add(Me.splitContainer1)
        Me.tabPageSQL.Location = New Point(4, 22)
        Me.tabPageSQL.Name = "tabPageSQL"
        Me.tabPageSQL.Padding = New Padding(3)
        Me.tabPageSQL.Size = New Size(876, 388)
        Me.tabPageSQL.TabIndex = 0
        Me.tabPageSQL.Text = "SQL"
        Me.tabPageSQL.UseVisualStyleBackColor = True
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = DockStyle.Fill
        Me.splitContainer1.Location = New Point(3, 3)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder1)
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.Controls.Add(Me.errorBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.textBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.panel2)
        Me.splitContainer1.Size = New Size(870, 382)
        Me.splitContainer1.SplitterDistance = 268
        Me.splitContainer1.TabIndex = 0
        ' 
        ' queryBuilder1
        ' 
        Me.queryBuilder1.AddObjectDialogOptions.Location = New Point(0, 0)
        Me.queryBuilder1.AddObjectDialogOptions.Size = New Size(430, 430)
        Me.queryBuilder1.AddObjectDialogOptions.StartPosition = FormStartPosition.CenterScreen
        Me.queryBuilder1.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = False
        Me.queryBuilder1.BorderStyle = BorderStyle.None
        Me.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = False
        Me.queryBuilder1.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder1.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = Color.Black
        Me.queryBuilder1.DesignPaneOptions.Background = SystemColors.Window
        linkPainterAccess1.LinkColor = Color.Black
        linkPainterAccess1.LinkColorFocused = Color.Black
        linkPainterAccess1.MarkColor = SystemColors.Control
        linkPainterAccess1.MarkColorFocused = SystemColors.ControlDark
        linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder1.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1
        Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder1.Dock = DockStyle.Fill
        Me.queryBuilder1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.World)
        Me.queryBuilder1.Location = New Point(0, 0)
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewDock = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = False
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = True
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = True
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = True
        Me.queryBuilder1.QueryColumnListOptions.Font = Nothing
        Me.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = False
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
        Me.queryBuilder1.QueryNavBarOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
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
        Me.queryBuilder1.Size = New Size(870, 268)
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
'			Me.queryBuilder1.SQLUpdated += New System.EventHandler(Me.queryBuilder_SQLUpdated)
        ' 
        ' errorBox1
        ' 
        Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox1.AutoSize = True
        Me.errorBox1.BackColor = Color.LightPink
        Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = False
        Me.errorBox1.Location = New Point(547, 49)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New Padding(5)
        Me.errorBox1.Size = New Size(302, 61)
        Me.errorBox1.TabIndex = 2
        Me.errorBox1.Visible = False
'			Me.errorBox1.GoToErrorPosition += New System.EventHandler(Me.errorBox1_GoToErrorPosition)
'			Me.errorBox1.RevertValidText += New System.EventHandler(Me.errorBox1_RevertValidText)
        ' 
        ' textBox1
        ' 
        Me.textBox1.BorderStyle = BorderStyle.FixedSingle
        Me.textBox1.Dock = DockStyle.Fill
        Me.textBox1.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.textBox1.HideSelection = False
        Me.textBox1.Location = New Point(0, 26)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = ScrollBars.Both
        Me.textBox1.Size = New Size(870, 84)
        Me.textBox1.TabIndex = 0
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.breadcrumbControl1)
        Me.panel2.Controls.Add(Me.panel3)
        Me.panel2.Dock = DockStyle.Top
        Me.panel2.Location = New Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New Size(870, 26)
        Me.panel2.TabIndex = 1
        ' 
        ' breadcrumbControl1
        ' 
        Me.breadcrumbControl1.Dock = DockStyle.Fill
        Me.breadcrumbControl1.Location = New Point(28, 0)
        Me.breadcrumbControl1.Name = "breadcrumbControl1"
        Me.breadcrumbControl1.Options.ActionButtonBackColor = Color.Empty
        Me.breadcrumbControl1.Options.ActionButtonBorderColor = Color.Empty
        Me.breadcrumbControl1.Options.ActiveSubQueryItemBackColor = Color.Empty
        Me.breadcrumbControl1.Options.ActiveSubQueryItemBorderColor = Color.Empty
        Me.breadcrumbControl1.Options.AddCteCircleColor = Color.Empty
        Me.breadcrumbControl1.Options.AddUnionSubQueryCircleColor = Color.Empty
        Me.breadcrumbControl1.Options.BreadcrumbsBackgroundColor = Color.Empty
        Me.breadcrumbControl1.Options.CTEButtonBaseColor = Color.Green
        Me.breadcrumbControl1.Options.DragIndicatorColor = Color.Empty
        Me.breadcrumbControl1.Options.DragIndicatorHoverColor = Color.Empty
        Me.breadcrumbControl1.Options.Font = Nothing
        Me.breadcrumbControl1.Options.ForeColor = Color.Empty
        Me.breadcrumbControl1.Options.GraphLineColor = Color.Empty
        Me.breadcrumbControl1.Options.GroupBackColor = Color.Empty
        Me.breadcrumbControl1.Options.GroupTextColor = Color.Empty
        Me.breadcrumbControl1.Options.OverflowButtonBaseColor = Color.DarkRed
        Me.breadcrumbControl1.Options.RootQueryButtonBaseColor = Color.Black
        Me.breadcrumbControl1.Options.SubQueryButtonBaseColor = Color.Blue
        Me.breadcrumbControl1.Options.SubQueryItemBackColor = Color.Empty
        Me.breadcrumbControl1.Options.SubQueryItemBorderColor = Color.Empty
        Me.breadcrumbControl1.Options.SubQueryMarkerColor = Color.Empty
        Me.breadcrumbControl1.Options.TextHoverColor = Color.Empty
        Me.breadcrumbControl1.QueryView = Nothing
        Me.breadcrumbControl1.Size = New Size(842, 26)
        Me.breadcrumbControl1.TabIndex = 2
        ' 
        ' panel3
        ' 
        Me.panel3.AutoSize = True
        Me.panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.panel3.Controls.Add(Me.button1)
        Me.panel3.Dock = DockStyle.Left
        Me.panel3.Location = New Point(0, 0)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New Size(28, 26)
        Me.panel3.TabIndex = 1
        ' 
        ' button1
        ' 
        Me.button1.AutoSize = True
        Me.button1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.button1.Image = My.Resources.img
        Me.button1.Location = New Point(3, 3)
        Me.button1.Name = "button1"
        Me.button1.Size = New Size(22, 20)
        Me.button1.TabIndex = 0
        Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
        ' 
        ' tabPageData
        ' 
        Me.tabPageData.Controls.Add(Me.dataGridView1)
        Me.tabPageData.Location = New Point(4, 22)
        Me.tabPageData.Name = "tabPageData"
        Me.tabPageData.Padding = New Padding(3)
        Me.tabPageData.Size = New Size(876, 388)
        Me.tabPageData.TabIndex = 1
        Me.tabPageData.Text = "Data"
        Me.tabPageData.UseVisualStyleBackColor = True
        ' 
        ' dataGridView1
        ' 
        Me.dataGridView1.Dock = DockStyle.Fill
        Me.dataGridView1.Location = New Point(3, 3)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New Size(870, 382)
        Me.dataGridView1.TabIndex = 0
        ' 
        ' openFileDialog
        ' 
        Me.openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        ' 
        ' saveFileDialog
        ' 
        Me.saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        ' 
        ' mssqlMetadataProvider1
        ' 
        Me.mssqlMetadataProvider1.Connection = Nothing
        ' 
        ' oledbMetadataProvider1
        ' 
        Me.oledbMetadataProvider1.Connection = Nothing
        ' 
        ' odbcMetadataProvider1
        ' 
        Me.odbcMetadataProvider1.Connection = Nothing
        ' 
        ' mainMenu1
        ' 
        Me.mainMenu1.MenuItems.AddRange(New MenuItem() { Me.menuItem1, Me.menuItem3, Me.queryStatisticsMenuItem, Me.propertiesMenuItem, Me.aboutMenuItem})
        ' 
        ' menuItem1
        ' 
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New MenuItem() { Me.menuItemConnectTo, Me.menuItem2, Me.fillProgrammaticallyMenuItem})
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
'			Me.fillProgrammaticallyMenuItem.Click += New System.EventHandler(Me.fillProgrammaticallyMenuItem_Click)
        ' 
        ' menuItem3
        ' 
        Me.menuItem3.Index = 1
        Me.menuItem3.MenuItems.AddRange(New MenuItem() { Me.refreshMetadataMenuItem, Me.editMetadataMenuItem, Me.clearMetadataMenuItem, Me.menuItem4, Me.loadMetadataFromXMLMenuItem, Me.saveMetadataToXMLMenuItem})
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
        Me.panel1.Size = New Size(884, 37)
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
        ' genericSyntaxProvider1
        ' 
        Me.genericSyntaxProvider1.DetectServerVersion = False
        Me.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
        Me.genericSyntaxProvider1.OnCalcExpressionType = Nothing
        ' 
        ' mssqlSyntaxProvider1
        ' 
        Me.mssqlSyntaxProvider1.DetectServerVersion = True
        Me.mssqlSyntaxProvider1.OnCalcExpressionType = Nothing
        ' 
        ' oracleSyntaxProvider1
        ' 
        Me.oracleSyntaxProvider1.DetectServerVersion = True
        Me.oracleSyntaxProvider1.OnCalcExpressionType = Nothing
        Me.oracleSyntaxProvider1.ServerVersion = ActiveQueryBuilder.Core.OracleServerVersion.Oracle10
        ' 
        ' msaccessSyntaxProvider1
        ' 
        Me.msaccessSyntaxProvider1.DetectServerVersion = False
        Me.msaccessSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
        Me.msaccessSyntaxProvider1.OnCalcExpressionType = Nothing
        ' 
        ' cmEditMode
        ' 
        Me.cmEditMode.Items.AddRange(New ToolStripItem() { Me.tsmiEntire, Me.tsmiSubQuery, Me.tsmiExpression})
        Me.cmEditMode.Name = "contextMenuStrip1"
        Me.cmEditMode.Size = New Size(319, 70)
        ' 
        ' tsmiEntire
        ' 
        Me.tsmiEntire.CheckOnClick = True
        Me.tsmiEntire.Name = "tsmiEntire"
        Me.tsmiEntire.Size = New Size(318, 22)
        Me.tsmiEntire.Text = "Edit the entire SQL query text"
'			Me.tsmiEntire.CheckedChanged += New System.EventHandler(Me.tsmiEntire_CheckedChanged)
        ' 
        ' tsmiSubQuery
        ' 
        Me.tsmiSubQuery.CheckOnClick = True
        Me.tsmiSubQuery.Name = "tsmiSubQuery"
        Me.tsmiSubQuery.Size = New Size(318, 22)
        Me.tsmiSubQuery.Text = "Edit text of the current sub-Query"
'			Me.tsmiSubQuery.CheckedChanged += New System.EventHandler(Me.tsmiSubQuery_CheckedChanged)
        ' 
        ' tsmiExpression
        ' 
        Me.tsmiExpression.CheckOnClick = True
        Me.tsmiExpression.Name = "tsmiExpression"
        Me.tsmiExpression.Size = New Size(318, 22)
        Me.tsmiExpression.Text = "Edit text of the current SELECT Expression only"
'			Me.tsmiExpression.CheckedChanged += New System.EventHandler(Me.tsmiExpression_CheckedChanged)
        ' 
        ' menuItemConnectTo
        ' 
        Me.menuItemConnectTo.Index = 0
        Me.menuItemConnectTo.Text = "Connect to..."
'			Me.menuItemConnectTo.Click += New System.EventHandler(Me.menuItemConnectTo_Click)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(884, 451)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.panel1)
        Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Active Query Builder for .NET WinForms Edition - General Demo (C#)"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPageSQL.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        CType(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.tabPageData.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.cmEditMode.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents tabControl1 As TabControl
    Private tabPageSQL As TabPage
    Private tabPageData As TabPage
    Private splitContainer1 As SplitContainer
    Private textBox1 As TextBox
    Private dataGridView1 As DataViewerControl.DataViewer
    Private openFileDialog As OpenFileDialog
    Private saveFileDialog As SaveFileDialog
    Private genericSyntaxProvider1 As ActiveQueryBuilder.Core.GenericSyntaxProvider
    Private mssqlSyntaxProvider1 As ActiveQueryBuilder.Core.MSSQLSyntaxProvider
    Private mssqlMetadataProvider1 As ActiveQueryBuilder.Core.MSSQLMetadataProvider
    Private oledbMetadataProvider1 As ActiveQueryBuilder.Core.OLEDBMetadataProvider
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
    Private WithEvents queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private panel2 As Panel
    Private WithEvents button1 As Button
    Private panel3 As Panel
    Private breadcrumbControl1 As ActiveQueryBuilder.View.WinForms.NavigationBar.SubQueryBreadcrumbsBar
    Private cmEditMode As ContextMenuStrip
    Private WithEvents tsmiEntire As ToolStripMenuItem
    Private WithEvents tsmiSubQuery As ToolStripMenuItem
    Private WithEvents tsmiExpression As ToolStripMenuItem
    Private WithEvents errorBox1 As Common.SqlErrorBox
    Private WithEvents menuItemConnectTo As MenuItem
End Class