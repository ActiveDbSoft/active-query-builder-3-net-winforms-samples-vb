Imports System.Drawing
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.WinForms.ExpressionEditor

Partial Class ChildForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChildForm))
        Dim LinkPainterAccess1 As ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess = New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.toolStripPanel1 = New System.Windows.Forms.ToolStripPanel()
        Me.contextMenuStripForRichTextBox = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.imageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.pageQueryBuilder = New System.Windows.Forms.TabPage()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.QView = New ActiveQueryBuilder.View.WinForms.QueryView.QueryView()
        Me.addObjectDialog1 = New ActiveQueryBuilder.View.WinForms.QueryView.AddObjectDialog(Me.components)
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.dockManager1 = New ActiveQueryBuilder.View.WinForms.DockPanels.DockManager()
        Me.designPaneControl1 = New ActiveQueryBuilder.View.WinForms.QueryView.DesignPaneControl()
        Me.dockPanel1 = New ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel()
        Me.propertiesBar1 = New ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar()
        Me.dockPanel2 = New ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel()
        Me.subQueryNavBar1 = New ActiveQueryBuilder.View.WinForms.NavigationBar.SubQueryNavBar()
        Me.queryColumnListControl1 = New ActiveQueryBuilder.View.WinForms.QueryView.QueryColumnListControl()
        Me.expressionEditor1 = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor(Me.components)
        Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.labelSleepMode = New System.Windows.Forms.Label()
        Me.tabControl2 = New System.Windows.Forms.TabControl()
        Me.tabPageSQL = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ErrorBox1 = New FullFeaturedMdiDemo.Common.ErrorBox()
        Me.rtbQueryText = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor()
        Me.tabPageCurrentSubQuery = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.ErrorBoxCurrent = New FullFeaturedMdiDemo.Common.ErrorBox()
        Me.TextBoxCurrentSubQuerySql = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor()
        Me.tabPageFastResult = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.resultGrid2 = New FullFeaturedMdiDemo.Common.ResultGrid()
        Me.NavBar = New ActiveQueryBuilder.View.WinForms.NavigationBar.QueryNavigationBar()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbQueryProperties = New System.Windows.Forms.ToolStripButton()
        Me.tsbAddObject = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAddDerivedTable = New System.Windows.Forms.ToolStripButton()
        Me.tsbAddUnionSubquery = New System.Windows.Forms.ToolStripButton()
        Me.tsbCopyUnionSubquery = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbSaveInFile = New System.Windows.Forms.ToolStripButton()
        Me.tsbSaveNewUserQuery = New System.Windows.Forms.ToolStripButton()
        Me.pageQueryResult = New System.Windows.Forms.TabPage()
        Me.resultGrid1 = New FullFeaturedMdiDemo.Common.ResultGrid()
        Me.paginationPanel1 = New FullFeaturedMdiDemo.PaginationPanel()
        Me.CBuilder = New ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.miniToolStrip = New System.Windows.Forms.ToolStrip()
        Me.contextMenuStripForRichTextBox.SuspendLayout
        Me.tabControl1.SuspendLayout
        Me.pageQueryBuilder.SuspendLayout
        Me.panel1.SuspendLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer1.Panel1.SuspendLayout
        Me.splitContainer1.Panel2.SuspendLayout
        Me.splitContainer1.SuspendLayout
        CType(Me.QView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.QView.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).BeginInit
        Me.QView.SuspendLayout
        CType(Me.splitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer2.Panel1.SuspendLayout
        Me.splitContainer2.Panel2.SuspendLayout
        Me.splitContainer2.SuspendLayout
        CType(Me.dockManager1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.dockManager1.SuspendLayout
        Me.dockPanel1.SuspendLayout
        Me.dockPanel2.SuspendLayout
        CType(Me.queryColumnListControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tableLayoutPanel4.SuspendLayout
        Me.tabControl2.SuspendLayout
        Me.tabPageSQL.SuspendLayout
        Me.tableLayoutPanel1.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.tabPageCurrentSubQuery.SuspendLayout
        Me.tableLayoutPanel2.SuspendLayout
        Me.panel3.SuspendLayout
        Me.tabPageFastResult.SuspendLayout
        Me.tableLayoutPanel3.SuspendLayout
        Me.panel2.SuspendLayout
        Me.toolStrip1.SuspendLayout
        Me.pageQueryResult.SuspendLayout
        Me.statusStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'toolStripPanel1
        '
        Me.toolStripPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolStripPanel1.Location = New System.Drawing.Point(0, 0)
        Me.toolStripPanel1.Name = "toolStripPanel1"
        Me.toolStripPanel1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.toolStripPanel1.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.toolStripPanel1.Size = New System.Drawing.Size(880, 0)
        '
        'contextMenuStripForRichTextBox
        '
        Me.contextMenuStripForRichTextBox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiUndo, Me.tsmiRedo, Me.toolStripSeparator3, Me.tsmiCut, Me.tsmiCopy, Me.tsmiPaste, Me.toolStripSeparator4, Me.tsmiSelectAll})
        Me.contextMenuStripForRichTextBox.Name = "contextMenuStripForRichTextBox"
        Me.contextMenuStripForRichTextBox.Size = New System.Drawing.Size(145, 148)
        '
        'tsmiUndo
        '
        Me.tsmiUndo.Name = "tsmiUndo"
        Me.tsmiUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z),System.Windows.Forms.Keys)
        Me.tsmiUndo.Size = New System.Drawing.Size(144, 22)
        Me.tsmiUndo.Text = "&Undo"
        '
        'tsmiRedo
        '
        Me.tsmiRedo.Name = "tsmiRedo"
        Me.tsmiRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y),System.Windows.Forms.Keys)
        Me.tsmiRedo.Size = New System.Drawing.Size(144, 22)
        Me.tsmiRedo.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'tsmiCut
        '
        Me.tsmiCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiCut.Name = "tsmiCut"
        Me.tsmiCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X),System.Windows.Forms.Keys)
        Me.tsmiCut.Size = New System.Drawing.Size(144, 22)
        Me.tsmiCut.Text = "Cu&t"
        '
        'tsmiCopy
        '
        Me.tsmiCopy.Image = Global.FullFeaturedMdiDemo.Resources.page_copy
        Me.tsmiCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiCopy.Name = "tsmiCopy"
        Me.tsmiCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C),System.Windows.Forms.Keys)
        Me.tsmiCopy.Size = New System.Drawing.Size(144, 22)
        Me.tsmiCopy.Text = "&Copy"
        '
        'tsmiPaste
        '
        Me.tsmiPaste.Image = Global.FullFeaturedMdiDemo.Resources.page_paste
        Me.tsmiPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiPaste.Name = "tsmiPaste"
        Me.tsmiPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V),System.Windows.Forms.Keys)
        Me.tsmiPaste.Size = New System.Drawing.Size(144, 22)
        Me.tsmiPaste.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        'tsmiSelectAll
        '
        Me.tsmiSelectAll.Name = "tsmiSelectAll"
        Me.tsmiSelectAll.Size = New System.Drawing.Size(144, 22)
        Me.tsmiSelectAll.Text = "Select &All"
        '
        'imageList2
        '
        Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList2.Images.SetKeyName(0, "table.ico")
        Me.imageList2.Images.SetKeyName(1, "table_lightning.ico")
        Me.imageList2.Images.SetKeyName(2, "table_gear.ico")
        Me.imageList2.Images.SetKeyName(3, "table_sort.ico")
        Me.imageList2.Images.SetKeyName(4, "folder.ico")
        Me.imageList2.Images.SetKeyName(5, "table_multiple.ico")
        Me.imageList2.Images.SetKeyName(6, "database.ico")
        '
        'imageList3
        '
        Me.imageList3.ImageStream = CType(resources.GetObject("imageList3.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.imageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList3.Images.SetKeyName(0, "chart_organisation.ico")
        Me.imageList3.Images.SetKeyName(1, "folder_table.ico")
        Me.imageList3.Images.SetKeyName(2, "database_table.ico")
        Me.imageList3.Images.SetKeyName(3, "folder_bullet_green.ico")
        Me.imageList3.Images.SetKeyName(4, "bullet_green.ico")
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.pageQueryBuilder)
        Me.tabControl1.Controls.Add(Me.pageQueryResult)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.ImageList = Me.imageList1
        Me.tabControl1.ItemSize = New System.Drawing.Size(97, 23)
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(880, 635)
        Me.tabControl1.TabIndex = 3
        '
        'pageQueryBuilder
        '
        Me.pageQueryBuilder.Controls.Add(Me.panel1)
        Me.pageQueryBuilder.ImageIndex = 0
        Me.pageQueryBuilder.Location = New System.Drawing.Point(4, 27)
        Me.pageQueryBuilder.Name = "pageQueryBuilder"
        Me.pageQueryBuilder.Padding = New System.Windows.Forms.Padding(3)
        Me.pageQueryBuilder.Size = New System.Drawing.Size(872, 604)
        Me.pageQueryBuilder.TabIndex = 0
        Me.pageQueryBuilder.Text = "Query Builder"
        Me.pageQueryBuilder.UseVisualStyleBackColor = true
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.splitContainer1)
        Me.panel1.Controls.Add(Me.NavBar)
        Me.panel1.Controls.Add(Me.toolStrip1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(866, 598)
        Me.panel1.TabIndex = 0
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainer1.Location = New System.Drawing.Point(0, 65)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.QView)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.tableLayoutPanel4)
        Me.splitContainer1.Size = New System.Drawing.Size(866, 533)
        Me.splitContainer1.SplitterDistance = 302
        Me.splitContainer1.TabIndex = 4
        '
        'QView
        '
        Me.QView.ActiveUnionSubQuery = Nothing
        Me.QView.AddObjectDialog = Me.addObjectDialog1
        Me.QView.Controls.Add(Me.splitContainer2)
        Me.QView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QView.ExpressionEditor = Me.expressionEditor1
        Me.QView.Location = New System.Drawing.Point(0, 0)
        Me.QView.Name = "QView"
        Me.QView.Query = Nothing
        Me.QView.Size = New System.Drawing.Size(866, 302)
        '
        '
        '
        Me.QView.SQLGenerationOptions.ExpandVirtualFields = false
        Me.QView.SQLGenerationOptions.ExpandVirtualObjects = false
        Me.QView.TabIndex = 6
        '
        'addObjectDialog1
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
        Me.addObjectDialog1.Options.ImageIndices.VirtualObjectImageIndex = 0
        Me.addObjectDialog1.Options.Location = New System.Drawing.Point(0, 0)
        Me.addObjectDialog1.Options.Size = New System.Drawing.Size(430, 430)
        Me.addObjectDialog1.Options.SortingType = ActiveQueryBuilder.View.DatabaseSchemaView.ObjectsSortingType.Name
        Me.addObjectDialog1.Options.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.addObjectDialog1.QueryView = Me.QView
        '
        'splitContainer2
        '
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer2.Name = "splitContainer2"
        Me.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.Controls.Add(Me.dockManager1)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.queryColumnListControl1)
        Me.splitContainer2.Size = New System.Drawing.Size(866, 302)
        Me.splitContainer2.SplitterDistance = 215
        Me.splitContainer2.TabIndex = 0
        '
        'dockManager1
        '
        Me.dockManager1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dockManager1.Controls.Add(Me.designPaneControl1)
        Me.dockManager1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dockManager1.DockPanels.AddRange(New ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel() {Me.dockPanel1, Me.dockPanel2})
        Me.dockManager1.Location = New System.Drawing.Point(0, 0)
        Me.dockManager1.Name = "dockManager1"
        Me.dockManager1.Options.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(242,Byte),Integer), CType(CType(157,Byte),Integer))
        Me.dockManager1.Options.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black
        Me.dockManager1.Options.DockTabColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.dockManager1.Options.DockTabFontColor = System.Drawing.Color.White
        Me.dockManager1.Options.DockTabFontHoverColor = System.Drawing.Color.White
        Me.dockManager1.Options.DockTabHoverColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.dockManager1.Options.DockTabIndicatorColor = System.Drawing.Color.FromArgb(CType(CType(70,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(125,Byte),Integer))
        Me.dockManager1.Options.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(CType(CType(155,Byte),Integer), CType(CType(167,Byte),Integer), CType(CType(183,Byte),Integer))
        Me.dockManager1.Options.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(96,Byte),Integer), CType(CType(130,Byte),Integer))
        Me.dockManager1.Options.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White
        Me.dockManager1.Options.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dockManager1.Options.TabsStripBackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.dockManager1.Size = New System.Drawing.Size(866, 215)
        Me.dockManager1.TabIndex = 0
        '
        'designPaneControl1
        '
        Me.designPaneControl1.AllowDrop = true
        Me.designPaneControl1.AutoScroll = true
        Me.designPaneControl1.AutoScrollMargin = New System.Drawing.Size(20, 20)
        Me.designPaneControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.designPaneControl1.Location = New System.Drawing.Point(29, 0)
        Me.designPaneControl1.Name = "designPaneControl1"
        Me.designPaneControl1.Options.Background = System.Drawing.SystemColors.Window
        LinkPainterAccess1.LinkColor = System.Drawing.Color.Black
        LinkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black
        LinkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control
        LinkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark
        LinkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.designPaneControl1.Options.LinkPainterOptions = LinkPainterAccess1
        Me.designPaneControl1.Options.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.designPaneControl1.Size = New System.Drawing.Size(632, 213)
        Me.designPaneControl1.TabIndex = 1
        '
        'dockPanel1
        '
        Me.dockPanel1.AutoHide = false
        Me.dockPanel1.Controls.Add(Me.propertiesBar1)
        Me.dockPanel1.Docking = ActiveQueryBuilder.View.Docking.Right
        Me.dockPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.dockPanel1.Name = "dockPanel1"
        Me.dockPanel1.Size = New System.Drawing.Size(200, 213)
        Me.dockPanel1.TabIndex = 2
        Me.dockPanel1.TabStop = false
        Me.dockPanel1.Text = "Properties"
        '
        'propertiesBar1
        '
        Me.propertiesBar1.AutoScroll = true
        Me.propertiesBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propertiesBar1.InformationMessageHost = Me.QView
        Me.propertiesBar1.Location = New System.Drawing.Point(0, 21)
        Me.propertiesBar1.Name = "propertiesBar1"
        Me.propertiesBar1.Size = New System.Drawing.Size(199, 191)
        Me.propertiesBar1.TabIndex = 1
        '
        'dockPanel2
        '
        Me.dockPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dockPanel2.Controls.Add(Me.subQueryNavBar1)
        Me.dockPanel2.Docking = ActiveQueryBuilder.View.Docking.Left
        Me.dockPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.dockPanel2.Location = New System.Drawing.Point(630, 0)
        Me.dockPanel2.Name = "dockPanel2"
        Me.dockPanel2.Size = New System.Drawing.Size(200, 251)
        Me.dockPanel2.TabIndex = 3
        Me.dockPanel2.TabStop = false
        Me.dockPanel2.Text = "Sub-query structure"
        '
        'subQueryNavBar1
        '
        Me.subQueryNavBar1.AutoScroll = true
        Me.subQueryNavBar1.BackColor = System.Drawing.SystemColors.Window
        Me.subQueryNavBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subQueryNavBar1.Location = New System.Drawing.Point(0, 21)
        Me.subQueryNavBar1.Name = "subQueryNavBar1"
        Me.subQueryNavBar1.Options.CTEButtonBaseColor = System.Drawing.Color.Green
        Me.subQueryNavBar1.Options.Font = Nothing
        Me.subQueryNavBar1.Options.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
        Me.subQueryNavBar1.Options.RootQueryButtonBaseColor = System.Drawing.Color.Black
        Me.subQueryNavBar1.Options.SubQueryButtonBaseColor = System.Drawing.Color.Blue
        Me.subQueryNavBar1.Size = New System.Drawing.Size(196, 229)
        Me.subQueryNavBar1.TabIndex = 1
        '
        'queryColumnListControl1
        '
        Me.queryColumnListControl1.ActiveUnionSubQuery = Nothing
        Me.queryColumnListControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.queryColumnListControl1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.queryColumnListControl1.Location = New System.Drawing.Point(0, 0)
        Me.queryColumnListControl1.Name = "queryColumnListControl1"
        Me.queryColumnListControl1.Options.ColumnsOptions.AggregateColumn.Index = 5
        Me.queryColumnListControl1.Options.ColumnsOptions.AggregateColumn.Width = 90R
        Me.queryColumnListControl1.Options.ColumnsOptions.AliasColumn.Index = 2
        Me.queryColumnListControl1.Options.ColumnsOptions.AliasColumn.Width = 100R
        Me.queryColumnListControl1.Options.ColumnsOptions.ConditionTypeColumn.Index = 7
        Me.queryColumnListControl1.Options.ColumnsOptions.ConditionTypeColumn.Width = 70R
        Me.queryColumnListControl1.Options.ColumnsOptions.CriteriaColumn.Index = 8
        Me.queryColumnListControl1.Options.ColumnsOptions.CriteriaColumn.Width = 60R
        Me.queryColumnListControl1.Options.ColumnsOptions.CriteriaOrColumns.Index = 0
        Me.queryColumnListControl1.Options.ColumnsOptions.CriteriaOrColumns.Width = 60R
        Me.queryColumnListControl1.Options.ColumnsOptions.ExpressionColumn.Index = 1
        Me.queryColumnListControl1.Options.ColumnsOptions.ExpressionColumn.Width = 150R
        Me.queryColumnListControl1.Options.ColumnsOptions.GroupingColumn.Index = 6
        Me.queryColumnListControl1.Options.ColumnsOptions.GroupingColumn.Width = 80R
        Me.queryColumnListControl1.Options.ColumnsOptions.OutputColumn.Index = 0
        Me.queryColumnListControl1.Options.ColumnsOptions.OutputColumn.Width = 55R
        Me.queryColumnListControl1.Options.ColumnsOptions.SortOrderColumn.Index = 4
        Me.queryColumnListControl1.Options.ColumnsOptions.SortOrderColumn.Width = 90R
        Me.queryColumnListControl1.Options.ColumnsOptions.SortTypeColumn.Index = 3
        Me.queryColumnListControl1.Options.ColumnsOptions.SortTypeColumn.Width = 80R
        Me.queryColumnListControl1.Options.Font = Nothing
        Me.queryColumnListControl1.Options.InitialOrColumnsCount = 2
        Me.queryColumnListControl1.Options.NullOrderingInOrderBy = false
        Me.queryColumnListControl1.Options.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryColumnListControl1.Query = Nothing
        Me.queryColumnListControl1.SelectedItems = New Integer(-1) {}
        Me.queryColumnListControl1.Size = New System.Drawing.Size(866, 83)
        Me.queryColumnListControl1.TabIndex = 0
        '
        'expressionEditor1
        '
        Me.expressionEditor1.ActiveUnionSubQuery = Nothing
        Me.expressionEditor1.Options.CloseOnEscape = true
        Me.expressionEditor1.Expression = ""
        Me.expressionEditor1.TextEditorSqlOptions.SuggestionWindowSize = new Size(200,200)
        Me.expressionEditor1.TextEditorOptions.HighlightMatchingParentheses = ActiveQueryBuilder.View.ExpressionEditor.ParenthesesHighlighting.NoHighlight
        Me.expressionEditor1.TextEditorSqlOptions.KeepMetadataObjectsOnTopOfSuggestionList = true
        Me.expressionEditor1.TextEditorSqlOptions.LoadMetadataOnCodeCompletion = true
        Me.expressionEditor1.Options.SearchFields = false
        Me.expressionEditor1.SQLFormattingOptions = Nothing
        Me.expressionEditor1.TextEditorOptions.Font = New System.Drawing.Font("Courier New", 10!)
        '
        'tableLayoutPanel4
        '
        Me.tableLayoutPanel4.ColumnCount = 1
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel4.Controls.Add(Me.labelSleepMode, 0, 0)
        Me.tableLayoutPanel4.Controls.Add(Me.tabControl2, 0, 1)
        Me.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
        Me.tableLayoutPanel4.RowCount = 2
        Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel4.Size = New System.Drawing.Size(866, 227)
        Me.tableLayoutPanel4.TabIndex = 0
        '
        'labelSleepMode
        '
        Me.labelSleepMode.AutoSize = true
        Me.labelSleepMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.labelSleepMode.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelSleepMode.Location = New System.Drawing.Point(3, 0)
        Me.labelSleepMode.Name = "labelSleepMode"
        Me.labelSleepMode.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.labelSleepMode.Size = New System.Drawing.Size(860, 23)
        Me.labelSleepMode.TabIndex = 3
        Me.labelSleepMode.Text = "Unsupported SQL statement. Visual Query Builder has been disabled. Either type a "& _ 
    "SELECT statement or start building a query visually to turn this mode off"
        Me.labelSleepMode.Visible = false
        '
        'tabControl2
        '
        Me.tabControl2.Controls.Add(Me.tabPageSQL)
        Me.tabControl2.Controls.Add(Me.tabPageCurrentSubQuery)
        Me.tabControl2.Controls.Add(Me.tabPageFastResult)
        Me.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl2.Location = New System.Drawing.Point(3, 26)
        Me.tabControl2.Name = "tabControl2"
        Me.tabControl2.SelectedIndex = 0
        Me.tabControl2.Size = New System.Drawing.Size(860, 198)
        Me.tabControl2.TabIndex = 1
        '
        'tabPageSQL
        '
        Me.tabPageSQL.Controls.Add(Me.tableLayoutPanel1)
        Me.tabPageSQL.Location = New System.Drawing.Point(4, 22)
        Me.tabPageSQL.Name = "tabPageSQL"
        Me.tabPageSQL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageSQL.Size = New System.Drawing.Size(852, 172)
        Me.tabPageSQL.TabIndex = 0
        Me.tabPageSQL.Text = "SQL Query Text"
        Me.tabPageSQL.UseVisualStyleBackColor = true
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.Panel4, 0, 1)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(846, 166)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.BackColor = System.Drawing.Color.DarkCyan
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label1.Location = New System.Drawing.Point(3, 0)
        Me.label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.label1.Name = "label1"
        Me.label1.Padding = New System.Windows.Forms.Padding(5)
        Me.label1.Size = New System.Drawing.Size(182, 23)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Text of the entire SQL query."
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ErrorBox1)
        Me.Panel4.Controls.Add(Me.rtbQueryText)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 31)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(840, 132)
        Me.Panel4.TabIndex = 3
        '
        'ErrorBox1
        '
        Me.ErrorBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ErrorBox1.AutoSize = true
        Me.ErrorBox1.BackColor = System.Drawing.Color.LightPink
        Me.ErrorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorBox1.CurrentSyntaxProvider = Nothing
        Me.ErrorBox1.IsVisibleCheckSyntaxPanel = false
        Me.ErrorBox1.Location = New System.Drawing.Point(539, 59)
        Me.ErrorBox1.Name = "ErrorBox1"
        Me.ErrorBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.ErrorBox1.Size = New System.Drawing.Size(287, 61)
        Me.ErrorBox1.TabIndex = 3
        Me.ErrorBox1.Visible = false
        '
        'rtbQueryText
        '
        Me.rtbQueryText.Options.AcceptTabs = false
        Me.rtbQueryText.AllowShowSuggestionByMouse = false
        Me.rtbQueryText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbQueryText.CaretOffset = 0
        Me.rtbQueryText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbQueryText.Location = New System.Drawing.Point(0, 0)
        Me.rtbQueryText.Name = "rtbQueryText"
        Me.rtbQueryText.Options.Font = New System.Drawing.Font("Courier New", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.rtbQueryText.Options.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.rtbQueryText.Query = Nothing
        Me.rtbQueryText.QueryProvider = Nothing
        Me.rtbQueryText.SelectedText = ""
        Me.rtbQueryText.SelectionLength = 0
        Me.rtbQueryText.SelectionStart = 0
        Me.rtbQueryText.Size = New System.Drawing.Size(840, 132)
        Me.rtbQueryText.SQLContext = Nothing
        Me.rtbQueryText.SqlOptions.SuggestionWindowSize = New System.Drawing.Size(200, 200)
        Me.rtbQueryText.TabIndex = 2
        '
        'tabPageCurrentSubQuery
        '
        Me.tabPageCurrentSubQuery.Controls.Add(Me.tableLayoutPanel2)
        Me.tabPageCurrentSubQuery.Location = New System.Drawing.Point(4, 22)
        Me.tabPageCurrentSubQuery.Name = "tabPageCurrentSubQuery"
        Me.tabPageCurrentSubQuery.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageCurrentSubQuery.Size = New System.Drawing.Size(852, 172)
        Me.tabPageCurrentSubQuery.TabIndex = 1
        Me.tabPageCurrentSubQuery.Text = "Current SubQuery Text"
        Me.tabPageCurrentSubQuery.UseVisualStyleBackColor = true
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 1
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel2.Controls.Add(Me.label2, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.panel3, 0, 1)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 2
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(846, 166)
        Me.tableLayoutPanel2.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.BackColor = System.Drawing.Color.DarkCyan
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label2.Location = New System.Drawing.Point(3, 0)
        Me.label2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.label2.Name = "label2"
        Me.label2.Padding = New System.Windows.Forms.Padding(5)
        Me.label2.Size = New System.Drawing.Size(146, 23)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Current SubQuery Text"
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.ErrorBoxCurrent)
        Me.panel3.Controls.Add(Me.TextBoxCurrentSubQuerySql)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(3, 31)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(840, 132)
        Me.panel3.TabIndex = 3
        '
        'ErrorBoxCurrent
        '
        Me.ErrorBoxCurrent.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ErrorBoxCurrent.AutoSize = true
        Me.ErrorBoxCurrent.BackColor = System.Drawing.Color.LightPink
        Me.ErrorBoxCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorBoxCurrent.CurrentSyntaxProvider = Nothing
        Me.ErrorBoxCurrent.IsVisibleCheckSyntaxPanel = false
        Me.ErrorBoxCurrent.Location = New System.Drawing.Point(546, 61)
        Me.ErrorBoxCurrent.Name = "ErrorBoxCurrent"
        Me.ErrorBoxCurrent.Padding = New System.Windows.Forms.Padding(5)
        Me.ErrorBoxCurrent.Size = New System.Drawing.Size(287, 61)
        Me.ErrorBoxCurrent.TabIndex = 4
        Me.ErrorBoxCurrent.Visible = false
        '
        'TextBoxCurrentSubQuerySql
        '
        Me.TextBoxCurrentSubQuerySql.Options.AcceptTabs = false
        Me.TextBoxCurrentSubQuerySql.AllowShowSuggestionByMouse = false
        Me.TextBoxCurrentSubQuerySql.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxCurrentSubQuerySql.CaretOffset = 0
        Me.TextBoxCurrentSubQuerySql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCurrentSubQuerySql.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxCurrentSubQuerySql.Name = "TextBoxCurrentSubQuerySql"
        Me.TextBoxCurrentSubQuerySql.Options.Font = New System.Drawing.Font("Courier New", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TextBoxCurrentSubQuerySql.Options.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.TextBoxCurrentSubQuerySql.Query = Nothing
        Me.TextBoxCurrentSubQuerySql.QueryProvider = Nothing
        Me.TextBoxCurrentSubQuerySql.SelectedText = ""
        Me.TextBoxCurrentSubQuerySql.SelectionLength = 0
        Me.TextBoxCurrentSubQuerySql.SelectionStart = 0
        Me.TextBoxCurrentSubQuerySql.Size = New System.Drawing.Size(840, 132)
        Me.TextBoxCurrentSubQuerySql.SQLContext = Nothing
        Me.TextBoxCurrentSubQuerySql.SqlOptions.SuggestionWindowSize = New System.Drawing.Size(200, 200)
        Me.TextBoxCurrentSubQuerySql.TabIndex = 0
        '
        'tabPageFastResult
        '
        Me.tabPageFastResult.Controls.Add(Me.tableLayoutPanel3)
        Me.tabPageFastResult.Location = New System.Drawing.Point(4, 22)
        Me.tabPageFastResult.Name = "tabPageFastResult"
        Me.tabPageFastResult.Size = New System.Drawing.Size(852, 172)
        Me.tabPageFastResult.TabIndex = 2
        Me.tabPageFastResult.Text = "Current SubQuery Results Preview"
        Me.tabPageFastResult.UseVisualStyleBackColor = true
        '
        'tableLayoutPanel3
        '
        Me.tableLayoutPanel3.ColumnCount = 1
        Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel3.Controls.Add(Me.label3, 0, 0)
        Me.tableLayoutPanel3.Controls.Add(Me.panel2, 0, 1)
        Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
        Me.tableLayoutPanel3.RowCount = 2
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tableLayoutPanel3.Size = New System.Drawing.Size(852, 172)
        Me.tableLayoutPanel3.TabIndex = 1
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.BackColor = System.Drawing.Color.DarkCyan
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label3.Location = New System.Drawing.Point(6, 3)
        Me.label3.Margin = New System.Windows.Forms.Padding(6, 3, 3, 5)
        Me.label3.Name = "label3"
        Me.label3.Padding = New System.Windows.Forms.Padding(5)
        Me.label3.Size = New System.Drawing.Size(212, 23)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Current SubQuery Results Preview"
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.resultGrid2)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(3, 34)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(846, 135)
        Me.panel2.TabIndex = 3
        '
        'resultGrid2
        '
        Me.resultGrid2.AutoSize = true
        Me.resultGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resultGrid2.EnabledSortings = false
        Me.resultGrid2.Location = New System.Drawing.Point(0, 0)
        Me.resultGrid2.Name = "resultGrid2"
        Me.resultGrid2.QueryTransformer = Nothing
        Me.resultGrid2.Size = New System.Drawing.Size(846, 135)
        Me.resultGrid2.SqlQuery = Nothing
        Me.resultGrid2.TabIndex = 0
        '
        'NavBar
        '
        Me.NavBar.AutoSize = true
        Me.NavBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NavBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavBar.Location = New System.Drawing.Point(0, 25)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.Options.CTEButtonBaseColor = System.Drawing.Color.Green
        Me.NavBar.Options.DisableQueryNavigationBarPopup = false
        Me.NavBar.Options.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.NavBar.Options.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
        Me.NavBar.Options.RootQueryButtonBaseColor = System.Drawing.Color.Black
        Me.NavBar.Options.SubQueryButtonBaseColor = System.Drawing.Color.Blue
        Me.NavBar.Query = Nothing
        Me.NavBar.QueryView = Nothing
        Me.NavBar.Size = New System.Drawing.Size(866, 40)
        Me.NavBar.TabIndex = 3
        Me.NavBar.TabStop = false
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbQueryProperties, Me.tsbAddObject, Me.toolStripSeparator5, Me.tsbAddDerivedTable, Me.tsbAddUnionSubquery, Me.tsbCopyUnionSubquery, Me.toolStripSeparator1, Me.tsbSave, Me.tsbSaveInFile, Me.tsbSaveNewUserQuery})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(866, 25)
        Me.toolStrip1.Stretch = true
        Me.toolStrip1.TabIndex = 2
        '
        'tsbQueryProperties
        '
        Me.tsbQueryProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbQueryProperties.Image = Global.FullFeaturedMdiDemo.Resources.query_properties
        Me.tsbQueryProperties.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQueryProperties.Name = "tsbQueryProperties"
        Me.tsbQueryProperties.Size = New System.Drawing.Size(23, 22)
        Me.tsbQueryProperties.Text = "Properties"
        '
        'tsbAddObject
        '
        Me.tsbAddObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddObject.Image = Global.FullFeaturedMdiDemo.Resources.new_object
        Me.tsbAddObject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddObject.Name = "tsbAddObject"
        Me.tsbAddObject.Size = New System.Drawing.Size(23, 22)
        Me.tsbAddObject.Text = "Add Object"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAddDerivedTable
        '
        Me.tsbAddDerivedTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddDerivedTable.Image = Global.FullFeaturedMdiDemo.Resources.add_derived_table
        Me.tsbAddDerivedTable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddDerivedTable.Name = "tsbAddDerivedTable"
        Me.tsbAddDerivedTable.Size = New System.Drawing.Size(23, 22)
        Me.tsbAddDerivedTable.Text = "Add Derived Table"
        '
        'tsbAddUnionSubquery
        '
        Me.tsbAddUnionSubquery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddUnionSubquery.Image = Global.FullFeaturedMdiDemo.Resources.add_union_subquery
        Me.tsbAddUnionSubquery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddUnionSubquery.Name = "tsbAddUnionSubquery"
        Me.tsbAddUnionSubquery.Size = New System.Drawing.Size(23, 22)
        Me.tsbAddUnionSubquery.Text = "New union sub-query"
        '
        'tsbCopyUnionSubquery
        '
        Me.tsbCopyUnionSubquery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCopyUnionSubquery.Image = Global.FullFeaturedMdiDemo.Resources.copy_union_subquery
        Me.tsbCopyUnionSubquery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCopyUnionSubquery.Name = "tsbCopyUnionSubquery"
        Me.tsbCopyUnionSubquery.Size = New System.Drawing.Size(23, 22)
        Me.tsbCopyUnionSubquery.Text = "Copy Union Sub-query"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbSave
        '
        Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSave.Image = CType(resources.GetObject("tsbSave.Image"),System.Drawing.Image)
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(23, 22)
        Me.tsbSave.Text = "Save query into connection as..."
        '
        'tsbSaveInFile
        '
        Me.tsbSaveInFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSaveInFile.Image = Global.FullFeaturedMdiDemo.Resources.drive_disk
        Me.tsbSaveInFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSaveInFile.Name = "tsbSaveInFile"
        Me.tsbSaveInFile.Size = New System.Drawing.Size(23, 22)
        Me.tsbSaveInFile.Text = "Save query to file as..."
        '
        'tsbSaveNewUserQuery
        '
        Me.tsbSaveNewUserQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSaveNewUserQuery.Image = Global.FullFeaturedMdiDemo.Resources.database_save
        Me.tsbSaveNewUserQuery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSaveNewUserQuery.Name = "tsbSaveNewUserQuery"
        Me.tsbSaveNewUserQuery.Size = New System.Drawing.Size(23, 22)
        Me.tsbSaveNewUserQuery.Text = "Save the current query"
        '
        'pageQueryResult
        '
        Me.pageQueryResult.Controls.Add(Me.resultGrid1)
        Me.pageQueryResult.Controls.Add(Me.paginationPanel1)
        Me.pageQueryResult.Controls.Add(Me.CBuilder)
        Me.pageQueryResult.Controls.Add(Me.richTextBox1)
        Me.pageQueryResult.ImageIndex = 1
        Me.pageQueryResult.Location = New System.Drawing.Point(4, 27)
        Me.pageQueryResult.Name = "pageQueryResult"
        Me.pageQueryResult.Padding = New System.Windows.Forms.Padding(3)
        Me.pageQueryResult.Size = New System.Drawing.Size(872, 604)
        Me.pageQueryResult.TabIndex = 1
        Me.pageQueryResult.Text = "Query Result"
        Me.pageQueryResult.UseVisualStyleBackColor = true
        '
        'resultGrid1
        '
        Me.resultGrid1.AutoSize = true
        Me.resultGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resultGrid1.Location = New System.Drawing.Point(3, 54)
        Me.resultGrid1.Name = "resultGrid1"
        Me.resultGrid1.QueryTransformer = Nothing
        Me.resultGrid1.Size = New System.Drawing.Size(866, 426)
        Me.resultGrid1.SqlQuery = Nothing
        Me.resultGrid1.TabIndex = 4
        '
        'paginationPanel1
        '
        Me.paginationPanel1.CurrentPage = 0
        Me.paginationPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.paginationPanel1.IsSupportLimitCount = false
        Me.paginationPanel1.IsSupportLimitOffset = false
        Me.paginationPanel1.Location = New System.Drawing.Point(3, 480)
        Me.paginationPanel1.Name = "paginationPanel1"
        Me.paginationPanel1.PageSize = 0
        Me.paginationPanel1.RowsCount = 0
        Me.paginationPanel1.Size = New System.Drawing.Size(866, 29)
        Me.paginationPanel1.TabIndex = 3
        '
        'CBuilder
        '
        Me.CBuilder.AutoSize = true
        Me.CBuilder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CBuilder.Dock = System.Windows.Forms.DockStyle.Top
        Me.CBuilder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CBuilder.JunctionPostfix = Nothing
        Me.CBuilder.Location = New System.Drawing.Point(3, 3)
        Me.CBuilder.MinimumSize = New System.Drawing.Size(188, 51)
        Me.CBuilder.Name = "CBuilder"
        Me.CBuilder.QueryTransformer = Nothing
        Me.CBuilder.RootItemFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CBuilder.RootJunctionPrefix = Nothing
        Me.CBuilder.Size = New System.Drawing.Size(866, 51)
        Me.CBuilder.TabIndex = 1
        '
        'richTextBox1
        '
        Me.richTextBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.richTextBox1.Font = New System.Drawing.Font("Courier New", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.richTextBox1.Location = New System.Drawing.Point(3, 509)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.ReadOnly = true
        Me.richTextBox1.Size = New System.Drawing.Size(866, 92)
        Me.richTextBox1.TabIndex = 2
        Me.richTextBox1.Text = "SQL"
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "bricks.ico")
        Me.imageList1.Images.SetKeyName(1, "database_go.ico")
        '
        'statusStrip1
        '
        Me.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 635)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusStrip1.Size = New System.Drawing.Size(880, 22)
        Me.statusStrip1.TabIndex = 5
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(146, 17)
        Me.toolStripStatusLabel1.Text = "Query builder state: Active"
        Me.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AutoSize = false
        Me.miniToolStrip.CanOverflow = false
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.Location = New System.Drawing.Point(130, 3)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(866, 25)
        Me.miniToolStrip.Stretch = true
        Me.miniToolStrip.TabIndex = 0
        '
        'ChildForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 657)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.toolStripPanel1)
        Me.Controls.Add(Me.statusStrip1)
        Me.MinimumSize = New System.Drawing.Size(200, 200)
        Me.Name = "ChildForm"
        Me.Text = "ChildForm"
        Me.contextMenuStripForRichTextBox.ResumeLayout(false)
        Me.tabControl1.ResumeLayout(false)
        Me.pageQueryBuilder.ResumeLayout(false)
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        CType(Me.QView.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.QView,System.ComponentModel.ISupportInitialize).EndInit
        Me.QView.ResumeLayout(false)
        Me.QView.PerformLayout
        Me.splitContainer2.Panel1.ResumeLayout(false)
        Me.splitContainer2.Panel2.ResumeLayout(false)
        CType(Me.splitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer2.ResumeLayout(false)
        CType(Me.dockManager1,System.ComponentModel.ISupportInitialize).EndInit
        Me.dockManager1.ResumeLayout(false)
        Me.dockManager1.PerformLayout
        Me.dockPanel1.ResumeLayout(false)
        Me.dockPanel2.ResumeLayout(false)
        CType(Me.queryColumnListControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.tableLayoutPanel4.ResumeLayout(false)
        Me.tableLayoutPanel4.PerformLayout
        Me.tabControl2.ResumeLayout(false)
        Me.tabPageSQL.ResumeLayout(false)
        Me.tableLayoutPanel1.ResumeLayout(false)
        Me.tableLayoutPanel1.PerformLayout
        Me.Panel4.ResumeLayout(false)
        Me.Panel4.PerformLayout
        Me.tabPageCurrentSubQuery.ResumeLayout(false)
        Me.tableLayoutPanel2.ResumeLayout(false)
        Me.tableLayoutPanel2.PerformLayout
        Me.panel3.ResumeLayout(false)
        Me.panel3.PerformLayout
        Me.tabPageFastResult.ResumeLayout(false)
        Me.tableLayoutPanel3.ResumeLayout(false)
        Me.tableLayoutPanel3.PerformLayout
        Me.panel2.ResumeLayout(false)
        Me.panel2.PerformLayout
        Me.toolStrip1.ResumeLayout(false)
        Me.toolStrip1.PerformLayout
        Me.pageQueryResult.ResumeLayout(false)
        Me.pageQueryResult.PerformLayout
        Me.statusStrip1.ResumeLayout(false)
        Me.statusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

#End Region

    Private toolStripPanel1 As System.Windows.Forms.ToolStripPanel
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private pageQueryResult As System.Windows.Forms.TabPage
    Private imageList1 As System.Windows.Forms.ImageList
    Private imageList2 As System.Windows.Forms.ImageList
    Private imageList3 As System.Windows.Forms.ImageList
    Private WithEvents contextMenuStripForRichTextBox As System.Windows.Forms.ContextMenuStrip
    Private  WithEvents tsmiUndo As System.Windows.Forms.ToolStripMenuItem
    Private  WithEvents tsmiRedo As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsmiCut As System.Windows.Forms.ToolStripMenuItem
    Private  WithEvents tsmiCopy As System.Windows.Forms.ToolStripMenuItem
    Private  WithEvents tsmiPaste As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private  WithEvents tsmiSelectAll As System.Windows.Forms.ToolStripMenuItem
    Private statusStrip1 As System.Windows.Forms.StatusStrip
    Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Private pageQueryBuilder As System.Windows.Forms.TabPage
    Private CBuilder As ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder
    Private richTextBox1 As System.Windows.Forms.RichTextBox
    Private expressionEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor
    Private panel1 As System.Windows.Forms.Panel
    Private NavBar As ActiveQueryBuilder.View.WinForms.NavigationBar.QueryNavigationBar
    Private toolStrip1 As System.Windows.Forms.ToolStrip
    Private  WithEvents tsbQueryProperties As System.Windows.Forms.ToolStripButton
    Private  WithEvents tsbAddObject As System.Windows.Forms.ToolStripButton
    Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private  WithEvents tsbAddDerivedTable As System.Windows.Forms.ToolStripButton
    Private  WithEvents tsbAddUnionSubquery As System.Windows.Forms.ToolStripButton
    Private  WithEvents tsbCopyUnionSubquery As System.Windows.Forms.ToolStripButton
    Private miniToolStrip As System.Windows.Forms.ToolStrip
    Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private  WithEvents QView As ActiveQueryBuilder.View.WinForms.QueryView.QueryView
    Private splitContainer2 As System.Windows.Forms.SplitContainer
    Private dockManager1 As ActiveQueryBuilder.View.WinForms.DockPanels.DockManager
    Private designPaneControl1 As ActiveQueryBuilder.View.WinForms.QueryView.DesignPaneControl
    Private dockPanel1 As ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel
    Private propertiesBar1 As ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar
    Private queryColumnListControl1 As ActiveQueryBuilder.View.WinForms.QueryView.QueryColumnListControl
    Private addObjectDialog1 As ActiveQueryBuilder.View.WinForms.QueryView.AddObjectDialog
    Private dockPanel2 As ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel
    Private subQueryNavBar1 As ActiveQueryBuilder.View.WinForms.NavigationBar.SubQueryNavBar
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents  tsbSave As System.Windows.Forms.ToolStripButton
    Private  WithEvents tsbSaveInFile As System.Windows.Forms.ToolStripButton
    Private WithEvents  tsbSaveNewUserQuery As System.Windows.Forms.ToolStripButton
    Private  WithEvents paginationPanel1 As PaginationPanel
    Private WithEvents tabControl2 As System.Windows.Forms.TabControl
    Private tabPageSQL As System.Windows.Forms.TabPage
    Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private label1 As System.Windows.Forms.Label
    Private tabPageCurrentSubQuery As System.Windows.Forms.TabPage
    Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents TextBoxCurrentSubQuerySql As SqlTextEditor
    Private label2 As System.Windows.Forms.Label
    Private tabPageFastResult As System.Windows.Forms.TabPage
    Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Private label3 As System.Windows.Forms.Label
    Private panel2 As System.Windows.Forms.Panel
    Private panel3 As System.Windows.Forms.Panel
    Private tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Private labelSleepMode As System.Windows.Forms.Label
    Private WithEvents resultGrid2 As Common.ResultGrid
    Private WithEvents resultGrid1 As Common.ResultGrid
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ErrorBox1 As Common.ErrorBox
    Private WithEvents rtbQueryText As SqlTextEditor
    Friend WithEvents ErrorBoxCurrent As Common.ErrorBox
End Class
