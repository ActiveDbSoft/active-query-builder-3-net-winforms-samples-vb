

Partial Public Class ChildForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ChildForm))
        Dim linkPainterAccess2 As New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.toolStripPanel1 = New ToolStripPanel()
        Me.contextMenuStripForRichTextBox = New ContextMenuStrip(Me.components)
        Me.tsmiUndo = New ToolStripMenuItem()
        Me.tsmiRedo = New ToolStripMenuItem()
        Me.toolStripSeparator3 = New ToolStripSeparator()
        Me.tsmiCut = New ToolStripMenuItem()
        Me.tsmiCopy = New ToolStripMenuItem()
        Me.tsmiPaste = New ToolStripMenuItem()
        Me.toolStripSeparator4 = New ToolStripSeparator()
        Me.tsmiSelectAll = New ToolStripMenuItem()
        Me.imageList2 = New ImageList(Me.components)
        Me.imageList3 = New ImageList(Me.components)
        Me.tabControl1 = New TabControl()
        Me.pageQueryBuilder = New TabPage()
        Me.panel1 = New Panel()
        Me.splitContainer1 = New SplitContainer()
        Me.QView = New ActiveQueryBuilder.View.WinForms.QueryView.QueryView()
        Me.addObjectDialog1 = New ActiveQueryBuilder.View.WinForms.QueryView.AddObjectDialog(Me.components)
        Me.splitContainer2 = New SplitContainer()
        Me.dockManager1 = New ActiveQueryBuilder.View.WinForms.DockPanels.DockManager()
        Me.designPaneControl1 = New ActiveQueryBuilder.View.WinForms.QueryView.DesignPaneControl()
        Me.dockPanel1 = New ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel()
        Me.propertiesBar1 = New ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar()
        Me.dockPanel2 = New ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel()
        Me.subQueryNavBar1 = New ActiveQueryBuilder.View.WinForms.NavigationBar.SubQueryNavBar()
        Me.queryColumnListControl1 = New ActiveQueryBuilder.View.WinForms.QueryView.QueryColumnListControl()
        Me.expressionEditor1 = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor(Me.components)
        Me.tableLayoutPanel4 = New TableLayoutPanel()
        Me.labelSleepMode = New Label()
        Me.tabControl2 = New TabControl()
        Me.tabPageSQL = New TabPage()
        Me.tableLayoutPanel1 = New TableLayoutPanel()
        Me.tabPageCurrentSubQuery = New TabPage()
        Me.tableLayoutPanel2 = New TableLayoutPanel()
        Me.panel3 = New Panel()
        Me.TextBoxCurrentSubQuerySql = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor()
        Me.tabPageFastResult = New TabPage()
        Me.tableLayoutPanel3 = New TableLayoutPanel()
        Me.panel2 = New Panel()
        Me.resultGrid2 = New DataViewerControl.DataViewer()
        Me.NavBar = New ActiveQueryBuilder.View.WinForms.NavigationBar.QueryNavigationBar()
        Me.toolStrip1 = New ToolStrip()
        Me.tsbQueryProperties = New ToolStripButton()
        Me.tsbAddObject = New ToolStripButton()
        Me.toolStripSeparator5 = New ToolStripSeparator()
        Me.tsbAddDerivedTable = New ToolStripButton()
        Me.tsbAddUnionSubquery = New ToolStripButton()
        Me.tsbCopyUnionSubquery = New ToolStripButton()
        Me.toolStripSeparator1 = New ToolStripSeparator()
        Me.tsbSave = New ToolStripButton()
        Me.tsbSaveInFile = New ToolStripButton()
        Me.tsbSaveNewUserQuery = New ToolStripButton()
        Me.pageQueryResult = New TabPage()
        Me.resultGrid1 = New DataViewerControl.DataViewer()
        Me.CBuilder = New ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder()
        Me.richTextBox1 = New RichTextBox()
        Me.imageList1 = New ImageList(Me.components)
        Me.statusStrip1 = New StatusStrip()
        Me.toolStripStatusLabel1 = New ToolStripStatusLabel()
        Me.miniToolStrip = New ToolStrip()
        Me.panel4 = New Panel()
        Me.rtbQueryText = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor()
        Me.errorBox1 = New Common.SqlErrorBox()
        Me.errorBoxCurrent = New Common.SqlErrorBox()
        Me.contextMenuStripForRichTextBox.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.pageQueryBuilder.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.QView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QView.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QView.SuspendLayout()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockManager1.SuspendLayout()
        Me.dockPanel1.SuspendLayout()
        Me.dockPanel2.SuspendLayout()
        CType(Me.queryColumnListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel4.SuspendLayout()
        Me.tabControl2.SuspendLayout()
        Me.tabPageSQL.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.tabPageCurrentSubQuery.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.tabPageFastResult.SuspendLayout()
        Me.tableLayoutPanel3.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.pageQueryResult.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' toolStripPanel1
        ' 
        Me.toolStripPanel1.Dock = DockStyle.Top
        Me.toolStripPanel1.Location = New Point(0, 0)
        Me.toolStripPanel1.Name = "toolStripPanel1"
        Me.toolStripPanel1.Orientation = Orientation.Horizontal
        Me.toolStripPanel1.RowMargin = New Padding(3, 0, 0, 0)
        Me.toolStripPanel1.Size = New Size(880, 0)
        ' 
        ' contextMenuStripForRichTextBox
        ' 
        Me.contextMenuStripForRichTextBox.Items.AddRange(New ToolStripItem() { Me.tsmiUndo, Me.tsmiRedo, Me.toolStripSeparator3, Me.tsmiCut, Me.tsmiCopy, Me.tsmiPaste, Me.toolStripSeparator4, Me.tsmiSelectAll})
        Me.contextMenuStripForRichTextBox.Name = "contextMenuStripForRichTextBox"
        Me.contextMenuStripForRichTextBox.Size = New Size(145, 148)
'			Me.contextMenuStripForRichTextBox.Opening += New System.ComponentModel.CancelEventHandler(Me.contextMenuStripForRichTextBox_Opening)
        ' 
        ' tsmiUndo
        ' 
        Me.tsmiUndo.Name = "tsmiUndo"
        Me.tsmiUndo.ShortcutKeys = (CType((Keys.Control Or Keys.Z), Keys))
        Me.tsmiUndo.Size = New Size(144, 22)
        Me.tsmiUndo.Text = "&Undo"
'			Me.tsmiUndo.Click += New System.EventHandler(Me.tsmiUndo_Click)
        ' 
        ' tsmiRedo
        ' 
        Me.tsmiRedo.Name = "tsmiRedo"
        Me.tsmiRedo.ShortcutKeys = (CType((Keys.Control Or Keys.Y), Keys))
        Me.tsmiRedo.Size = New Size(144, 22)
        Me.tsmiRedo.Text = "&Redo"
'			Me.tsmiRedo.Click += New System.EventHandler(Me.tsmiRedo_Click)
        ' 
        ' toolStripSeparator3
        ' 
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New Size(141, 6)
        ' 
        ' tsmiCut
        ' 
        Me.tsmiCut.Image = My.Resources.cut
        Me.tsmiCut.ImageTransparentColor = Color.Magenta
        Me.tsmiCut.Name = "tsmiCut"
        Me.tsmiCut.ShortcutKeys = (CType((Keys.Control Or Keys.X), Keys))
        Me.tsmiCut.Size = New Size(144, 22)
        Me.tsmiCut.Text = "Cu&t"
'			Me.tsmiCut.Click += New System.EventHandler(Me.tsmiCut_Click)
        ' 
        ' tsmiCopy
        ' 
        Me.tsmiCopy.Image = My.Resources.page_copy
        Me.tsmiCopy.ImageTransparentColor = Color.Magenta
        Me.tsmiCopy.Name = "tsmiCopy"
        Me.tsmiCopy.ShortcutKeys = (CType((Keys.Control Or Keys.C), Keys))
        Me.tsmiCopy.Size = New Size(144, 22)
        Me.tsmiCopy.Text = "&Copy"
'			Me.tsmiCopy.Click += New System.EventHandler(Me.tsmiCopy_Click)
        ' 
        ' tsmiPaste
        ' 
        Me.tsmiPaste.Image = My.Resources.page_paste
        Me.tsmiPaste.ImageTransparentColor = Color.Magenta
        Me.tsmiPaste.Name = "tsmiPaste"
        Me.tsmiPaste.ShortcutKeys = (CType((Keys.Control Or Keys.V), Keys))
        Me.tsmiPaste.Size = New Size(144, 22)
        Me.tsmiPaste.Text = "&Paste"
'			Me.tsmiPaste.Click += New System.EventHandler(Me.tsmiPaste_Click)
        ' 
        ' toolStripSeparator4
        ' 
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New Size(141, 6)
        ' 
        ' tsmiSelectAll
        ' 
        Me.tsmiSelectAll.Name = "tsmiSelectAll"
        Me.tsmiSelectAll.Size = New Size(144, 22)
        Me.tsmiSelectAll.Text = "Select &All"
'			Me.tsmiSelectAll.Click += New System.EventHandler(Me.tsmiSelectAll_Click)
        ' 
        ' imageList2
        ' 
        Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), ImageListStreamer))
        Me.imageList2.TransparentColor = Color.Transparent
        Me.imageList2.Images.SetKeyName(0, "table.ico")
        Me.imageList2.Images.SetKeyName(1, "table_lightning.ico")
        Me.imageList2.Images.SetKeyName(2, "table_gear.ico")
        Me.imageList2.Images.SetKeyName(3, "table_sort.ico")
        Me.imageList2.Images.SetKeyName(4, "folder.ico")
        Me.imageList2.Images.SetKeyName(5, "table_multiple.ico")
        Me.imageList2.Images.SetKeyName(6, "database.ico")
        ' 
        ' imageList3
        ' 
        Me.imageList3.ImageStream = (CType(resources.GetObject("imageList3.ImageStream"), ImageListStreamer))
        Me.imageList3.TransparentColor = Color.Transparent
        Me.imageList3.Images.SetKeyName(0, "chart_organisation.ico")
        Me.imageList3.Images.SetKeyName(1, "folder_table.ico")
        Me.imageList3.Images.SetKeyName(2, "database_table.ico")
        Me.imageList3.Images.SetKeyName(3, "folder_bullet_green.ico")
        Me.imageList3.Images.SetKeyName(4, "bullet_green.ico")
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Controls.Add(Me.pageQueryBuilder)
        Me.tabControl1.Controls.Add(Me.pageQueryResult)
        Me.tabControl1.Dock = DockStyle.Fill
        Me.tabControl1.ImageList = Me.imageList1
        Me.tabControl1.ItemSize = New Size(97, 23)
        Me.tabControl1.Location = New Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New Size(880, 635)
        Me.tabControl1.TabIndex = 3
'			Me.tabControl1.Selecting += New System.Windows.Forms.TabControlCancelEventHandler(Me.tabControl1_Selecting)
        ' 
        ' pageQueryBuilder
        ' 
        Me.pageQueryBuilder.Controls.Add(Me.panel1)
        Me.pageQueryBuilder.ImageIndex = 0
        Me.pageQueryBuilder.Location = New Point(4, 27)
        Me.pageQueryBuilder.Name = "pageQueryBuilder"
        Me.pageQueryBuilder.Padding = New Padding(3)
        Me.pageQueryBuilder.Size = New Size(872, 604)
        Me.pageQueryBuilder.TabIndex = 0
        Me.pageQueryBuilder.Text = "Query Builder"
        Me.pageQueryBuilder.UseVisualStyleBackColor = True
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.splitContainer1)
        Me.panel1.Controls.Add(Me.NavBar)
        Me.panel1.Controls.Add(Me.toolStrip1)
        Me.panel1.Dock = DockStyle.Fill
        Me.panel1.Location = New Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New Size(866, 598)
        Me.panel1.TabIndex = 0
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = DockStyle.Fill
        Me.splitContainer1.FixedPanel = FixedPanel.Panel2
        Me.splitContainer1.Location = New Point(0, 65)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.Controls.Add(Me.QView)
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.Controls.Add(Me.tableLayoutPanel4)
        Me.splitContainer1.Size = New Size(866, 533)
        Me.splitContainer1.SplitterDistance = 302
        Me.splitContainer1.TabIndex = 4
        ' 
        ' QView
        ' 
        Me.QView.ActiveUnionSubQuery = Nothing
        Me.QView.AddObjectDialog = Me.addObjectDialog1
        Me.QView.Controls.Add(Me.splitContainer2)
        Me.QView.Dock = DockStyle.Fill
        Me.QView.ExpressionEditor = Me.expressionEditor1
        Me.QView.Location = New Point(0, 0)
        Me.QView.Name = "QView"
        Me.QView.Query = Nothing
        Me.QView.Size = New Size(866, 302)
        ' 
        ' 
        ' 
        Me.QView.SQLGenerationOptions.ExpandVirtualFields = False
        Me.QView.SQLGenerationOptions.ExpandVirtualObjects = False
        Me.QView.TabIndex = 6
'			Me.QView.DataSourceAdding += New ActiveQueryBuilder.View.QueryView.DataSourceAddingEventHandler(Me.QView_DataSourceAdding)
        ' 
        ' addObjectDialog1
        ' 
        Me.addObjectDialog1.Options.ImageIndices.DatabaseImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.FieldImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.FilterImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.FolderImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.ForeignKeyImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.PackageImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.ParameterImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.PrimaryKeyImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.ServerImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.SystemProcedureImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.SystemSynonymImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.SystemTableImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.SystemViewImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.UserProcedureImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.UserSynonymImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.UserViewImageIndex = 0
        Me.addObjectDialog1.Options.ImageIndices.VirtualFieldImageIndex = 0
        Me.addObjectDialog1.Options.Location = New Point(0, 0)
        Me.addObjectDialog1.Options.Size = New Size(430, 430)
        Me.addObjectDialog1.Options.SortingType = ActiveQueryBuilder.View.DatabaseSchemaView.ObjectsSortingType.Name
        Me.addObjectDialog1.Options.StartPosition = FormStartPosition.Manual
        Me.addObjectDialog1.QueryView = Me.QView
        ' 
        ' splitContainer2
        ' 
        Me.splitContainer2.Dock = DockStyle.Fill
        Me.splitContainer2.Location = New Point(0, 0)
        Me.splitContainer2.Name = "splitContainer2"
        Me.splitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' splitContainer2.Panel1
        ' 
        Me.splitContainer2.Panel1.Controls.Add(Me.dockManager1)
        ' 
        ' splitContainer2.Panel2
        ' 
        Me.splitContainer2.Panel2.Controls.Add(Me.queryColumnListControl1)
        Me.splitContainer2.Size = New Size(866, 302)
        Me.splitContainer2.SplitterDistance = 215
        Me.splitContainer2.TabIndex = 0
        ' 
        ' dockManager1
        ' 
        Me.dockManager1.BorderStyle = BorderStyle.FixedSingle
        Me.dockManager1.Controls.Add(Me.designPaneControl1)
        Me.dockManager1.Dock = DockStyle.Fill
        Me.dockManager1.DockPanels.AddRange(New ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel() { Me.dockPanel1, Me.dockPanel2})
        Me.dockManager1.Location = New Point(0, 0)
        Me.dockManager1.Name = "dockManager1"
        Me.dockManager1.Options.ActiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(157))))))
        Me.dockManager1.Options.ActiveDockPanelCaptionFontColor = Color.Black
        Me.dockManager1.Options.DockTabColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.dockManager1.Options.DockTabFontColor = Color.White
        Me.dockManager1.Options.DockTabFontHoverColor = Color.White
        Me.dockManager1.Options.DockTabHoverColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.dockManager1.Options.DockTabIndicatorColor = Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(125))))))
        Me.dockManager1.Options.DockTabIndicatorHoverColor = Color.FromArgb((CInt(Fix((CByte(155))))), (CInt(Fix((CByte(167))))), (CInt(Fix((CByte(183))))))
        Me.dockManager1.Options.InactiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(96))))), (CInt(Fix((CByte(130))))))
        Me.dockManager1.Options.InactiveDockPanelCaptionFontColor = Color.White
        Me.dockManager1.Options.TabFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Me.dockManager1.Options.TabsStripBackColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.dockManager1.Size = New Size(866, 215)
        Me.dockManager1.TabIndex = 0
        ' 
        ' designPaneControl1
        ' 
        Me.designPaneControl1.AllowDrop = True
        Me.designPaneControl1.AutoScroll = True
        Me.designPaneControl1.AutoScrollMargin = New Size(20, 20)
        Me.designPaneControl1.Dock = DockStyle.Fill
        Me.designPaneControl1.Location = New Point(29, 0)
        Me.designPaneControl1.Name = "designPaneControl1"
        Me.designPaneControl1.Options.Background = SystemColors.Window
        linkPainterAccess2.LinkColor = Color.Black
        linkPainterAccess2.LinkColorFocused = Color.Black
        linkPainterAccess2.MarkColor = SystemColors.Control
        linkPainterAccess2.MarkColorFocused = SystemColors.ControlDark
        linkPainterAccess2.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.designPaneControl1.Options.LinkPainterOptions = linkPainterAccess2
        Me.designPaneControl1.Options.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.designPaneControl1.Size = New Size(632, 213)
        Me.designPaneControl1.TabIndex = 1
        ' 
        ' dockPanel1
        ' 
        Me.dockPanel1.AutoHide = False
        Me.dockPanel1.Controls.Add(Me.propertiesBar1)
        Me.dockPanel1.Docking = ActiveQueryBuilder.View.Docking.Right
        Me.dockPanel1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Me.dockPanel1.Location = New Point(0, 0)
        Me.dockPanel1.Name = "dockPanel1"
        Me.dockPanel1.Size = New Size(200, 213)
        Me.dockPanel1.TabIndex = 2
        Me.dockPanel1.TabStop = False
        Me.dockPanel1.Text = "Properties"
        ' 
        ' propertiesBar1
        ' 
        Me.propertiesBar1.AutoScroll = True
        Me.propertiesBar1.Dock = DockStyle.Fill
        Me.propertiesBar1.InformationMessageHost = Me.QView
        Me.propertiesBar1.Location = New Point(0, 21)
        Me.propertiesBar1.Name = "propertiesBar1"
        Me.propertiesBar1.Size = New Size(199, 191)
        Me.propertiesBar1.TabIndex = 1
        ' 
        ' dockPanel2
        ' 
        Me.dockPanel2.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Right), AnchorStyles))
        Me.dockPanel2.Controls.Add(Me.subQueryNavBar1)
        Me.dockPanel2.Docking = ActiveQueryBuilder.View.Docking.Left
        Me.dockPanel2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Me.dockPanel2.Location = New Point(630, 0)
        Me.dockPanel2.Name = "dockPanel2"
        Me.dockPanel2.Size = New Size(200, 251)
        Me.dockPanel2.TabIndex = 3
        Me.dockPanel2.TabStop = False
        Me.dockPanel2.Text = "Sub-query structure"
        ' 
        ' subQueryNavBar1
        ' 
        Me.subQueryNavBar1.AutoScroll = True
        Me.subQueryNavBar1.Dock = DockStyle.Fill
        Me.subQueryNavBar1.Location = New Point(0, 21)
        Me.subQueryNavBar1.Name = "subQueryNavBar1"
        Me.subQueryNavBar1.Options.CTEButtonBaseColor = Color.Green
        Me.subQueryNavBar1.Options.Font = Nothing
        Me.subQueryNavBar1.Options.OverflowButtonBaseColor = Color.DarkRed
        Me.subQueryNavBar1.Options.RootQueryButtonBaseColor = Color.Black
        Me.subQueryNavBar1.Options.SubQueryButtonBaseColor = Color.Blue
        Me.subQueryNavBar1.Size = New Size(196, 229)
        Me.subQueryNavBar1.TabIndex = 1
        ' 
        ' queryColumnListControl1
        ' 
        Me.queryColumnListControl1.Dock = DockStyle.Fill
        Me.queryColumnListControl1.ForeColor = SystemColors.WindowText
        Me.queryColumnListControl1.Location = New Point(0, 0)
        Me.queryColumnListControl1.Name = "queryColumnListControl1"
        Me.queryColumnListControl1.Options.ColumnsOptions.AggregateColumn.Index = 5
        Me.queryColumnListControl1.Options.ColumnsOptions.AggregateColumn.Width = 90R
        Me.queryColumnListControl1.Options.ColumnsOptions.AliasColumn.Index = 2
        Me.queryColumnListControl1.Options.ColumnsOptions.AliasColumn.Width = 100R
        Me.queryColumnListControl1.Options.ColumnsOptions.ConditionTypeColumn.Index = 7
        Me.queryColumnListControl1.Options.ColumnsOptions.ConditionTypeColumn.Width = 140R
        Me.queryColumnListControl1.Options.ColumnsOptions.CriteriaColumn.Index = 8
        Me.queryColumnListControl1.Options.ColumnsOptions.CriteriaColumn.Width = 200R
        Me.queryColumnListControl1.Options.ColumnsOptions.CriteriaOrColumns.Index = 0
        Me.queryColumnListControl1.Options.ColumnsOptions.CriteriaOrColumns.Width = 60R
        Me.queryColumnListControl1.Options.ColumnsOptions.ExpressionColumn.Index = 1
        Me.queryColumnListControl1.Options.ColumnsOptions.ExpressionColumn.Width = 250R
        Me.queryColumnListControl1.Options.ColumnsOptions.GroupingColumn.Index = 6
        Me.queryColumnListControl1.Options.ColumnsOptions.GroupingColumn.Width = 100R
        Me.queryColumnListControl1.Options.ColumnsOptions.OutputColumn.Index = 0
        Me.queryColumnListControl1.Options.ColumnsOptions.OutputColumn.Width = 55R
        Me.queryColumnListControl1.Options.ColumnsOptions.SortOrderColumn.Index = 4
        Me.queryColumnListControl1.Options.ColumnsOptions.SortOrderColumn.Width = 100R
        Me.queryColumnListControl1.Options.ColumnsOptions.SortTypeColumn.Index = 3
        Me.queryColumnListControl1.Options.ColumnsOptions.SortTypeColumn.Width = 60R
        Me.queryColumnListControl1.Options.Font = Nothing
        Me.queryColumnListControl1.Options.InitialOrColumnsCount = 2
        Me.queryColumnListControl1.Options.NullOrderingInOrderBy = False
        Me.queryColumnListControl1.Options.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryColumnListControl1.SelectedItems = New Integer(){}
        Me.queryColumnListControl1.Size = New Size(866, 83)
        Me.queryColumnListControl1.TabIndex = 0
        ' 
        ' expressionEditor1
        ' 
        Me.expressionEditor1.ActiveUnionSubQuery = Nothing
        Me.expressionEditor1.BackColor = Color.White
        Me.expressionEditor1.Expression = ""
        Me.expressionEditor1.SQLFormattingOptions = Nothing
        Me.expressionEditor1.TextColor = SystemColors.ControlText
        ' 
        ' tableLayoutPanel4
        ' 
        Me.tableLayoutPanel4.ColumnCount = 1
        Me.tableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel4.Controls.Add(Me.labelSleepMode, 0, 0)
        Me.tableLayoutPanel4.Controls.Add(Me.tabControl2, 0, 1)
        Me.tableLayoutPanel4.Dock = DockStyle.Fill
        Me.tableLayoutPanel4.Location = New Point(0, 0)
        Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
        Me.tableLayoutPanel4.RowCount = 2
        Me.tableLayoutPanel4.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel4.Size = New Size(866, 227)
        Me.tableLayoutPanel4.TabIndex = 0
        ' 
        ' labelSleepMode
        ' 
        Me.labelSleepMode.AutoSize = True
        Me.labelSleepMode.BackColor = Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(192))))))
        Me.labelSleepMode.Dock = DockStyle.Top
        Me.labelSleepMode.Location = New Point(3, 0)
        Me.labelSleepMode.Name = "labelSleepMode"
        Me.labelSleepMode.Padding = New Padding(0, 5, 5, 5)
        Me.labelSleepMode.Size = New Size(860, 23)
        Me.labelSleepMode.TabIndex = 3
        Me.labelSleepMode.Text = "Unsupported SQL statement. Visual Query Builder has been disabled. Either type a " & "SELECT statement or start building a query visually to turn this mode off"
        Me.labelSleepMode.Visible = False
        ' 
        ' tabControl2
        ' 
        Me.tabControl2.Controls.Add(Me.tabPageSQL)
        Me.tabControl2.Controls.Add(Me.tabPageCurrentSubQuery)
        Me.tabControl2.Controls.Add(Me.tabPageFastResult)
        Me.tabControl2.Dock = DockStyle.Fill
        Me.tabControl2.Location = New Point(3, 26)
        Me.tabControl2.Name = "tabControl2"
        Me.tabControl2.SelectedIndex = 0
        Me.tabControl2.Size = New Size(860, 198)
        Me.tabControl2.TabIndex = 1
'			Me.tabControl2.Selected += New System.Windows.Forms.TabControlEventHandler(Me.tabControl2_Selected)
        ' 
        ' tabPageSQL
        ' 
        Me.tabPageSQL.Controls.Add(Me.tableLayoutPanel1)
        Me.tabPageSQL.Location = New Point(4, 22)
        Me.tabPageSQL.Name = "tabPageSQL"
        Me.tabPageSQL.Padding = New Padding(3)
        Me.tabPageSQL.Size = New Size(852, 172)
        Me.tabPageSQL.TabIndex = 0
        Me.tabPageSQL.Text = "SQL Query Text"
        Me.tabPageSQL.UseVisualStyleBackColor = True
        ' 
        ' tableLayoutPanel1
        ' 
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel1.Controls.Add(Me.panel4, 0, 1)
        Me.tableLayoutPanel1.Dock = DockStyle.Fill
        Me.tableLayoutPanel1.Location = New Point(3, 3)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        Me.tableLayoutPanel1.Size = New Size(846, 166)
        Me.tableLayoutPanel1.TabIndex = 0
        ' 
        ' tabPageCurrentSubQuery
        ' 
        Me.tabPageCurrentSubQuery.Controls.Add(Me.tableLayoutPanel2)
        Me.tabPageCurrentSubQuery.Location = New Point(4, 22)
        Me.tabPageCurrentSubQuery.Name = "tabPageCurrentSubQuery"
        Me.tabPageCurrentSubQuery.Padding = New Padding(3)
        Me.tabPageCurrentSubQuery.Size = New Size(852, 172)
        Me.tabPageCurrentSubQuery.TabIndex = 1
        Me.tabPageCurrentSubQuery.Text = "Current SubQuery Text"
        Me.tabPageCurrentSubQuery.UseVisualStyleBackColor = True
        ' 
        ' tableLayoutPanel2
        ' 
        Me.tableLayoutPanel2.ColumnCount = 1
        Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel2.Controls.Add(Me.panel3, 0, 1)
        Me.tableLayoutPanel2.Dock = DockStyle.Fill
        Me.tableLayoutPanel2.Location = New Point(3, 3)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 2
        Me.tableLayoutPanel2.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        Me.tableLayoutPanel2.Size = New Size(846, 166)
        Me.tableLayoutPanel2.TabIndex = 1
        ' 
        ' panel3
        ' 
        Me.panel3.Controls.Add(Me.errorBoxCurrent)
        Me.panel3.Controls.Add(Me.TextBoxCurrentSubQuerySql)
        Me.panel3.Dock = DockStyle.Fill
        Me.panel3.Location = New Point(3, 3)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New Size(840, 160)
        Me.panel3.TabIndex = 3
        ' 
        ' TextBoxCurrentSubQuerySql
        ' 
        Me.TextBoxCurrentSubQuerySql.AllowShowSuggestionByMouse = False
        Me.TextBoxCurrentSubQuerySql.BorderStyle = BorderStyle.FixedSingle
        Me.TextBoxCurrentSubQuerySql.CaretOffset = 0
        Me.TextBoxCurrentSubQuerySql.Dock = DockStyle.Fill
        Me.TextBoxCurrentSubQuerySql.Location = New Point(0, 0)
        Me.TextBoxCurrentSubQuerySql.Margin = New Padding(4)
        Me.TextBoxCurrentSubQuerySql.Name = "TextBoxCurrentSubQuerySql"
        Me.TextBoxCurrentSubQuerySql.Options.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Me.TextBoxCurrentSubQuerySql.Options.Padding = New Padding(5, 5, 0, 0)
        Me.TextBoxCurrentSubQuerySql.Query = Nothing
        Me.TextBoxCurrentSubQuerySql.QueryProvider = Nothing
        Me.TextBoxCurrentSubQuerySql.SelectedText = ""
        Me.TextBoxCurrentSubQuerySql.SelectionLength = 0
        Me.TextBoxCurrentSubQuerySql.SelectionStart = 0
        Me.TextBoxCurrentSubQuerySql.Size = New Size(840, 160)
        Me.TextBoxCurrentSubQuerySql.SQLContext = Nothing
        Me.TextBoxCurrentSubQuerySql.SqlOptions.ShowSuggestionAfterCharCount = 0
        Me.TextBoxCurrentSubQuerySql.SqlOptions.SuggestionWindowSize = New Size(200, 200)
        Me.TextBoxCurrentSubQuerySql.TabIndex = 0
'			Me.TextBoxCurrentSubQuerySql.TextChanged += New System.EventHandler(Me.TextBoxCurrentSubQuerySql_TextChanged)
'			Me.TextBoxCurrentSubQuerySql.Validating += New System.ComponentModel.CancelEventHandler(Me.TextBoxCurrentSubQuerySql_Validating)
        ' 
        ' tabPageFastResult
        ' 
        Me.tabPageFastResult.Controls.Add(Me.tableLayoutPanel3)
        Me.tabPageFastResult.Location = New Point(4, 22)
        Me.tabPageFastResult.Name = "tabPageFastResult"
        Me.tabPageFastResult.Size = New Size(852, 172)
        Me.tabPageFastResult.TabIndex = 2
        Me.tabPageFastResult.Text = "Current SubQuery Results Preview"
        Me.tabPageFastResult.UseVisualStyleBackColor = True
        ' 
        ' tableLayoutPanel3
        ' 
        Me.tableLayoutPanel3.ColumnCount = 1
        Me.tableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel3.Controls.Add(Me.panel2, 0, 1)
        Me.tableLayoutPanel3.Dock = DockStyle.Fill
        Me.tableLayoutPanel3.Location = New Point(0, 0)
        Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
        Me.tableLayoutPanel3.RowCount = 2
        Me.tableLayoutPanel3.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        Me.tableLayoutPanel3.Size = New Size(852, 172)
        Me.tableLayoutPanel3.TabIndex = 1
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.resultGrid2)
        Me.panel2.Dock = DockStyle.Fill
        Me.panel2.Location = New Point(3, 3)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New Size(846, 166)
        Me.panel2.TabIndex = 3
        ' 
        ' resultGrid2
        ' 
        Me.resultGrid2.AutoSize = True
        Me.resultGrid2.Dock = DockStyle.Fill
        Me.resultGrid2.EnabledSorting = False
        Me.resultGrid2.Location = New Point(0, 0)
        Me.resultGrid2.Name = "resultGrid2"
        Me.resultGrid2.QueryTransformer = Nothing
        Me.resultGrid2.Size = New Size(846, 166)
        Me.resultGrid2.SqlQuery = Nothing
        Me.resultGrid2.TabIndex = 0
        ' 
        ' NavBar
        ' 
        Me.NavBar.AutoSize = True
        Me.NavBar.BorderStyle = BorderStyle.FixedSingle
        Me.NavBar.Dock = DockStyle.Top
        Me.NavBar.Location = New Point(0, 25)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.Options.CTEButtonBaseColor = Color.Green
        Me.NavBar.Options.DisableQueryNavigationBarPopup = False
        Me.NavBar.Options.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Me.NavBar.Options.OverflowButtonBaseColor = Color.DarkRed
        Me.NavBar.Options.RootQueryButtonBaseColor = Color.Black
        Me.NavBar.Options.SubQueryButtonBaseColor = Color.Blue
        Me.NavBar.Query = Nothing
        Me.NavBar.QueryView = Nothing
        Me.NavBar.Size = New Size(866, 40)
        Me.NavBar.TabIndex = 3
        Me.NavBar.TabStop = False
        ' 
        ' toolStrip1
        ' 
        Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.tsbQueryProperties, Me.tsbAddObject, Me.toolStripSeparator5, Me.tsbAddDerivedTable, Me.tsbAddUnionSubquery, Me.tsbCopyUnionSubquery, Me.toolStripSeparator1, Me.tsbSave, Me.tsbSaveInFile, Me.tsbSaveNewUserQuery})
        Me.toolStrip1.Location = New Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New Size(866, 25)
        Me.toolStrip1.Stretch = True
        Me.toolStrip1.TabIndex = 2
        ' 
        ' tsbQueryProperties
        ' 
        Me.tsbQueryProperties.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.tsbQueryProperties.Image = My.Resources.query_properties
        Me.tsbQueryProperties.ImageTransparentColor = Color.Magenta
        Me.tsbQueryProperties.Name = "tsbQueryProperties"
        Me.tsbQueryProperties.Size = New Size(23, 22)
        Me.tsbQueryProperties.Text = "Properties"
'			Me.tsbQueryProperties.Click += New System.EventHandler(Me.tsbQueryProperties_Click)
        ' 
        ' tsbAddObject
        ' 
        Me.tsbAddObject.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.tsbAddObject.Image = My.Resources.new_object
        Me.tsbAddObject.ImageTransparentColor = Color.Magenta
        Me.tsbAddObject.Name = "tsbAddObject"
        Me.tsbAddObject.Size = New Size(23, 22)
        Me.tsbAddObject.Text = "Add Object"
'			Me.tsbAddObject.Click += New System.EventHandler(Me.tsbAddObject_Click)
        ' 
        ' toolStripSeparator5
        ' 
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New Size(6, 25)
        ' 
        ' tsbAddDerivedTable
        ' 
        Me.tsbAddDerivedTable.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.tsbAddDerivedTable.Image = My.Resources.add_derived_table
        Me.tsbAddDerivedTable.ImageTransparentColor = Color.Magenta
        Me.tsbAddDerivedTable.Name = "tsbAddDerivedTable"
        Me.tsbAddDerivedTable.Size = New Size(23, 22)
        Me.tsbAddDerivedTable.Text = "Add Derived Table"
'			Me.tsbAddDerivedTable.Click += New System.EventHandler(Me.tsbAddDerivedTable_Click)
        ' 
        ' tsbAddUnionSubquery
        ' 
        Me.tsbAddUnionSubquery.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.tsbAddUnionSubquery.Image = My.Resources.add_union_subquery
        Me.tsbAddUnionSubquery.ImageTransparentColor = Color.Magenta
        Me.tsbAddUnionSubquery.Name = "tsbAddUnionSubquery"
        Me.tsbAddUnionSubquery.Size = New Size(23, 22)
        Me.tsbAddUnionSubquery.Text = "New union sub-query"
'			Me.tsbAddUnionSubquery.Click += New System.EventHandler(Me.tsbAddUnionSubquery_Click)
        ' 
        ' tsbCopyUnionSubquery
        ' 
        Me.tsbCopyUnionSubquery.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.tsbCopyUnionSubquery.Image = My.Resources.copy_union_subquery
        Me.tsbCopyUnionSubquery.ImageTransparentColor = Color.Magenta
        Me.tsbCopyUnionSubquery.Name = "tsbCopyUnionSubquery"
        Me.tsbCopyUnionSubquery.Size = New Size(23, 22)
        Me.tsbCopyUnionSubquery.Text = "Copy Union Sub-query"
'			Me.tsbCopyUnionSubquery.Click += New System.EventHandler(Me.tsbCopyUnionSubquery_Click)
        ' 
        ' toolStripSeparator1
        ' 
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' tsbSave
        ' 
        Me.tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.tsbSave.Image = My.Resources.disk
        Me.tsbSave.ImageTransparentColor = Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New Size(23, 22)
        Me.tsbSave.Text = "Save the current query"
        Me.tsbSave.ToolTipText = "Save the current query"
'			Me.tsbSave.Click += New System.EventHandler(Me.tsbSave_Click)
        ' 
        ' tsbSaveInFile
        ' 
        Me.tsbSaveInFile.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.tsbSaveInFile.Image = My.Resources.drive_disk
        Me.tsbSaveInFile.ImageTransparentColor = Color.Magenta
        Me.tsbSaveInFile.Name = "tsbSaveInFile"
        Me.tsbSaveInFile.Size = New Size(23, 22)
        Me.tsbSaveInFile.Text = "Save query to file as..."
'			Me.tsbSaveInFile.Click += New System.EventHandler(Me.tsbSaveInFile_Click)
        ' 
        ' tsbSaveNewUserQuery
        ' 
        Me.tsbSaveNewUserQuery.DisplayStyle = ToolStripItemDisplayStyle.Image
        Me.tsbSaveNewUserQuery.Image = My.Resources.database_save
        Me.tsbSaveNewUserQuery.ImageTransparentColor = Color.Magenta
        Me.tsbSaveNewUserQuery.Name = "tsbSaveNewUserQuery"
        Me.tsbSaveNewUserQuery.Size = New Size(23, 22)
        Me.tsbSaveNewUserQuery.Text = "Save query into connection as..."
'			Me.tsbSaveNewUserQuery.Click += New System.EventHandler(Me.tsbSaveNewUserQuery_Click)
        ' 
        ' pageQueryResult
        ' 
        Me.pageQueryResult.Controls.Add(Me.resultGrid1)
        Me.pageQueryResult.Controls.Add(Me.CBuilder)
        Me.pageQueryResult.Controls.Add(Me.richTextBox1)
        Me.pageQueryResult.ImageIndex = 1
        Me.pageQueryResult.Location = New Point(4, 27)
        Me.pageQueryResult.Name = "pageQueryResult"
        Me.pageQueryResult.Padding = New Padding(3)
        Me.pageQueryResult.Size = New Size(872, 604)
        Me.pageQueryResult.TabIndex = 1
        Me.pageQueryResult.Text = "Query Result"
        Me.pageQueryResult.UseVisualStyleBackColor = True
        ' 
        ' resultGrid1
        ' 
        Me.resultGrid1.AutoSize = True
        Me.resultGrid1.Dock = DockStyle.Fill
        Me.resultGrid1.Location = New Point(3, 54)
        Me.resultGrid1.Name = "resultGrid1"
        Me.resultGrid1.QueryTransformer = Nothing
        Me.resultGrid1.Size = New Size(866, 426)
        Me.resultGrid1.SqlQuery = Nothing
        Me.resultGrid1.TabIndex = 4

        ' 
        ' CBuilder
        ' 
        Me.CBuilder.AutoSize = True
        Me.CBuilder.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.CBuilder.Dock = DockStyle.Top
        Me.CBuilder.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.CBuilder.Location = New Point(3, 3)
        Me.CBuilder.MinimumSize = New Size(188, 51)
        Me.CBuilder.Name = "CBuilder"
        Me.CBuilder.QueryTransformer = Nothing
        Me.CBuilder.RootItemFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.CBuilder.RootJunctionPrefix = Nothing
        Me.CBuilder.Size = New Size(866, 51)
        Me.CBuilder.TabIndex = 1
        ' 
        ' richTextBox1
        ' 
        Me.richTextBox1.BackColor = Color.LemonChiffon
        Me.richTextBox1.Dock = DockStyle.Bottom
        Me.richTextBox1.Font = New Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.richTextBox1.Location = New Point(3, 509)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.ReadOnly = True
        Me.richTextBox1.Size = New Size(866, 92)
        Me.richTextBox1.TabIndex = 2
        Me.richTextBox1.Text = "SQL"
        ' 
        ' imageList1
        ' 
        Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
        Me.imageList1.TransparentColor = Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "bricks.ico")
        Me.imageList1.Images.SetKeyName(1, "database_go.ico")
        ' 
        ' statusStrip1
        ' 
        Me.statusStrip1.GripStyle = ToolStripGripStyle.Visible
        Me.statusStrip1.Items.AddRange(New ToolStripItem() { Me.toolStripStatusLabel1})
        Me.statusStrip1.Location = New Point(0, 635)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode
        Me.statusStrip1.Size = New Size(880, 22)
        Me.statusStrip1.TabIndex = 5
        ' 
        ' toolStripStatusLabel1
        ' 
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New Size(146, 17)
        Me.toolStripStatusLabel1.Text = "Query builder state: Active"
        Me.toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' miniToolStrip
        ' 
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.CanOverflow = False
        Me.miniToolStrip.Dock = DockStyle.None
        Me.miniToolStrip.GripStyle = ToolStripGripStyle.Hidden
        Me.miniToolStrip.Location = New Point(130, 3)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New Size(866, 25)
        Me.miniToolStrip.Stretch = True
        Me.miniToolStrip.TabIndex = 0
        ' 
        ' panel4
        ' 
        Me.panel4.Controls.Add(Me.errorBox1)
        Me.panel4.Controls.Add(Me.rtbQueryText)
        Me.panel4.Dock = DockStyle.Fill
        Me.panel4.Location = New Point(3, 3)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New Size(840, 160)
        Me.panel4.TabIndex = 0
        ' 
        ' rtbQueryText
        ' 
        Me.rtbQueryText.AllowShowSuggestionByMouse = False
        Me.rtbQueryText.BorderStyle = BorderStyle.FixedSingle
        Me.rtbQueryText.CaretOffset = 0
        Me.rtbQueryText.Dock = DockStyle.Fill
        Me.rtbQueryText.Location = New Point(0, 0)
        Me.rtbQueryText.Margin = New Padding(4)
        Me.rtbQueryText.Name = "rtbQueryText"
        Me.rtbQueryText.Options.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Me.rtbQueryText.Options.Padding = New Padding(5, 5, 0, 0)
        Me.rtbQueryText.Query = Nothing
        Me.rtbQueryText.QueryProvider = Nothing
        Me.rtbQueryText.SelectedText = ""
        Me.rtbQueryText.SelectionLength = 0
        Me.rtbQueryText.SelectionStart = 0
        Me.rtbQueryText.Size = New Size(840, 160)
        Me.rtbQueryText.SQLContext = Nothing
        Me.rtbQueryText.SqlOptions.ShowSuggestionAfterCharCount = 0
        Me.rtbQueryText.SqlOptions.SuggestionWindowSize = New Size(200, 200)
        Me.rtbQueryText.TabIndex = 2
'			Me.rtbQueryText.Validating += New System.ComponentModel.CancelEventHandler(Me.rtbQueryText_Validating)
        ' 
        ' errorBox1
        ' 
        Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox1.AutoSize = True
        Me.errorBox1.BackColor = Color.LightPink
        Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = False
        Me.errorBox1.Location = New Point(536, 96)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New Padding(5)
        Me.errorBox1.Size = New Size(290, 61)
        Me.errorBox1.TabIndex = 3
        Me.errorBox1.Visible = False
'			Me.errorBox1.GoToErrorPosition += New System.EventHandler(Me.errorBox1_GoToErrorPosition)
'			Me.errorBox1.RevertValidText += New System.EventHandler(Me.errorBox1_RevertValidText)
        ' 
        ' errorBoxCurrent
        ' 
        Me.errorBoxCurrent.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBoxCurrent.AutoSize = True
        Me.errorBoxCurrent.BackColor = Color.LightPink
        Me.errorBoxCurrent.BorderStyle = BorderStyle.FixedSingle
        Me.errorBoxCurrent.CurrentSyntaxProvider = Nothing
        Me.errorBoxCurrent.IsVisibleCheckSyntaxPanel = False
        Me.errorBoxCurrent.Location = New Point(492, 96)
        Me.errorBoxCurrent.Name = "errorBoxCurrent"
        Me.errorBoxCurrent.Padding = New Padding(5)
        Me.errorBoxCurrent.Size = New Size(334, 61)
        Me.errorBoxCurrent.TabIndex = 2
        Me.errorBoxCurrent.Visible = False
'			Me.errorBoxCurrent.GoToErrorPosition += New System.EventHandler(Me.errorBoxCurrent_GoToErrorPosition)
'			Me.errorBoxCurrent.RevertValidText += New System.EventHandler(Me.errorBoxCurrent_RevertValidText)
        ' 
        ' ChildForm
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(880, 657)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.toolStripPanel1)
        Me.Controls.Add(Me.statusStrip1)
        Me.MinimumSize = New Size(200, 200)
        Me.Name = "ChildForm"
        Me.Text = "ChildForm"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.ChildForm_FormClosing)
        Me.contextMenuStripForRichTextBox.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.pageQueryBuilder.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        CType(Me.QView.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QView.ResumeLayout(False)
        Me.QView.PerformLayout()
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel2.ResumeLayout(False)
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.ResumeLayout(False)
        CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockManager1.ResumeLayout(False)
        Me.dockManager1.PerformLayout()
        Me.dockPanel1.ResumeLayout(False)
        Me.dockPanel2.ResumeLayout(False)
        CType(Me.queryColumnListControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableLayoutPanel4.ResumeLayout(False)
        Me.tableLayoutPanel4.PerformLayout()
        Me.tabControl2.ResumeLayout(False)
        Me.tabPageSQL.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tabPageCurrentSubQuery.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.tabPageFastResult.ResumeLayout(False)
        Me.tableLayoutPanel3.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.pageQueryResult.ResumeLayout(False)
        Me.pageQueryResult.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.panel4.ResumeLayout(False)
        Me.panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private toolStripPanel1 As ToolStripPanel
    Private WithEvents tabControl1 As TabControl
    Private pageQueryResult As TabPage
    Private imageList1 As ImageList
    Private imageList2 As ImageList
    Private imageList3 As ImageList
    Private WithEvents contextMenuStripForRichTextBox As ContextMenuStrip
    Private WithEvents tsmiUndo As ToolStripMenuItem
    Private WithEvents tsmiRedo As ToolStripMenuItem
    Private toolStripSeparator3 As ToolStripSeparator
    Private WithEvents tsmiCut As ToolStripMenuItem
    Private WithEvents tsmiCopy As ToolStripMenuItem
    Private WithEvents tsmiPaste As ToolStripMenuItem
    Private toolStripSeparator4 As ToolStripSeparator
    Private WithEvents tsmiSelectAll As ToolStripMenuItem
    Private statusStrip1 As StatusStrip
    Private toolStripStatusLabel1 As ToolStripStatusLabel
    Private pageQueryBuilder As TabPage
    Private CBuilder As ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder
    Private richTextBox1 As RichTextBox
    Private expressionEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor
    Private panel1 As Panel
    Private NavBar As ActiveQueryBuilder.View.WinForms.NavigationBar.QueryNavigationBar
    Private toolStrip1 As ToolStrip
    Private WithEvents tsbQueryProperties As ToolStripButton
    Private WithEvents tsbAddObject As ToolStripButton
    Private toolStripSeparator5 As ToolStripSeparator
    Private WithEvents tsbAddDerivedTable As ToolStripButton
    Private WithEvents tsbAddUnionSubquery As ToolStripButton
    Private WithEvents tsbCopyUnionSubquery As ToolStripButton
    Private miniToolStrip As ToolStrip
    Private splitContainer1 As SplitContainer
    Private WithEvents QView As ActiveQueryBuilder.View.WinForms.QueryView.QueryView
    Private splitContainer2 As SplitContainer
    Private dockManager1 As ActiveQueryBuilder.View.WinForms.DockPanels.DockManager
    Private designPaneControl1 As ActiveQueryBuilder.View.WinForms.QueryView.DesignPaneControl
    Private dockPanel1 As ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel
    Private propertiesBar1 As ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar
    Private queryColumnListControl1 As ActiveQueryBuilder.View.WinForms.QueryView.QueryColumnListControl
    Private addObjectDialog1 As ActiveQueryBuilder.View.WinForms.QueryView.AddObjectDialog
    Private dockPanel2 As ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel
    Private subQueryNavBar1 As ActiveQueryBuilder.View.WinForms.NavigationBar.SubQueryNavBar
    Private toolStripSeparator1 As ToolStripSeparator
    Private WithEvents tsbSave As ToolStripButton
    Private WithEvents tsbSaveInFile As ToolStripButton
    Private WithEvents tsbSaveNewUserQuery As ToolStripButton
    Private WithEvents tabControl2 As TabControl
    Private tabPageSQL As TabPage
    Private tableLayoutPanel1 As TableLayoutPanel
    Private tabPageCurrentSubQuery As TabPage
    Private tableLayoutPanel2 As TableLayoutPanel
    Private WithEvents TextBoxCurrentSubQuerySql As ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor
    Private tabPageFastResult As TabPage
    Private tableLayoutPanel3 As TableLayoutPanel
    Private panel2 As Panel
    Private panel3 As Panel
    Private tableLayoutPanel4 As TableLayoutPanel
    Private labelSleepMode As Label
    Private resultGrid2 As DataViewerControl.DataViewer
    Private resultGrid1 As DataViewerControl.DataViewer
    Private panel4 As Panel
    Private WithEvents rtbQueryText As ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor
    Private WithEvents errorBox1 As Common.SqlErrorBox
    Private WithEvents errorBoxCurrent As Common.SqlErrorBox
End Class
