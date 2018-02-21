
Imports ActiveQueryBuilder.View.WinForms

Partial Class MainForm

    Private components As System.ComponentModel.IContainer = Nothing

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.imageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.toolStripPanel1 = New System.Windows.Forms.ToolStripPanel()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.newQueryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiQuery = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiParseQuery = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiBuildQuery = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRunQuery = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.addObjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addDerivedTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addUnionSubqueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyUnionSubwueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiQueryStatistics = New System.Windows.Forms.ToolStripMenuItem()
        Me.queryPropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.metadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOfflineMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiRefreshMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClearMetadata = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiLoadMetadataFromXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSaveMetadataToXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.languageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLanguageAuto = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLanguageDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.propertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbNew = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButtonNewQuery = New System.Windows.Forms.ToolStripButton()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbSaveInFile = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCut = New System.Windows.Forms.ToolStripButton()
        Me.tsbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tsbPaste = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEditMetadata = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAbout = New System.Windows.Forms.ToolStripButton()
        Me.toolStripPanel2 = New System.Windows.Forms.ToolStripPanel()
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.contextMenuStripForRichTextBox = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pageQueryResult = New System.Windows.Forms.TabPage()
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.resultGrid1 = New FullFeaturedDemo.Common.ResultGrid()
        Me.paginationPanel1 = New FullFeaturedDemo.PaginationPanel()
        Me.CBuilder = New ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder()
        Me.teResultSql = New System.Windows.Forms.RichTextBox()
        Me.pageQueryBuilder = New System.Windows.Forms.TabPage()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.toolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbQueryProperties = New System.Windows.Forms.ToolStripButton()
        Me.tsbAddObject = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAddDerivedTable = New System.Windows.Forms.ToolStripButton()
        Me.tsbAddUnionSubquery = New System.Windows.Forms.ToolStripButton()
        Me.tsbCopyUnionSubquery = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.labelSleepMode = New System.Windows.Forms.Label()
        Me.tabControl2 = New System.Windows.Forms.TabControl()
        Me.tabPageSQL = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.teSql = New System.Windows.Forms.RichTextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tabPageCurrentSubQuery = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.infoPanel2 = New FullFeaturedDemo.Common.InfoPanel()
        Me.TextBoxCurrentSubQuerySql = New System.Windows.Forms.RichTextBox()
        Me.tabPageFastResult = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.resultGrid2 = New FullFeaturedDemo.Common.ResultGrid()
        Me.miniToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.toolStripPanel1.SuspendLayout
        Me.menuStrip1.SuspendLayout
        Me.toolStrip1.SuspendLayout
        Me.pageQueryResult.SuspendLayout
        CType(Me.splitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer2.Panel1.SuspendLayout
        Me.splitContainer2.Panel2.SuspendLayout
        Me.splitContainer2.SuspendLayout
        Me.pageQueryBuilder.SuspendLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer1.Panel1.SuspendLayout
        Me.splitContainer1.Panel2.SuspendLayout
        Me.splitContainer1.SuspendLayout
        Me.panel1.SuspendLayout
        CType(Me.queryBuilder1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.toolStrip2.SuspendLayout
        Me.tableLayoutPanel4.SuspendLayout
        Me.tabControl2.SuspendLayout
        Me.tabPageSQL.SuspendLayout
        Me.tableLayoutPanel1.SuspendLayout
        Me.tabPageCurrentSubQuery.SuspendLayout
        Me.tableLayoutPanel2.SuspendLayout
        Me.panel3.SuspendLayout
        Me.tabPageFastResult.SuspendLayout
        Me.tableLayoutPanel3.SuspendLayout
        Me.panel2.SuspendLayout
        Me.tabControl1.SuspendLayout
        Me.SuspendLayout
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "bricks.ico")
        Me.imageList1.Images.SetKeyName(1, "database_go.ico")
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
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(109, 17)
        Me.toolStripStatusLabel1.Text = "toolStripStatusLabel1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ContentPanel.Size = New System.Drawing.Size(792, 423)
        '
        'toolStripPanel1
        '
        Me.toolStripPanel1.Controls.Add(Me.menuStrip1)
        Me.toolStripPanel1.Controls.Add(Me.toolStrip1)
        Me.toolStripPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolStripPanel1.Location = New System.Drawing.Point(0, 0)
        Me.toolStripPanel1.Name = "toolStripPanel1"
        Me.toolStripPanel1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.toolStripPanel1.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.toolStripPanel1.Size = New System.Drawing.Size(878, 49)
        '
        'menuStrip1
        '
        Me.menuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem1, Me.editToolStripMenuItem, Me.tsmiQuery, Me.metadataToolStripMenuItem, Me.toolsToolStripMenuItem, Me.tsmiAbout})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(878, 24)
        Me.menuStrip1.TabIndex = 4
        Me.menuStrip1.Text = "Main Menu"
        '
        'fileToolStripMenuItem1
        '
        Me.fileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNew, Me.toolStripSeparator, Me.newQueryToolStripMenuItem1, Me.tsmiOpen, Me.tsmiSave, Me.tsmiSaveAs, Me.toolStripSeparator1, Me.tsmiExit})
        Me.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1"
        Me.fileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem1.Text = "&File"
        '
        'tsmiNew
        '
        Me.tsmiNew.Image = Global.FullFeaturedDemo.Resources.connect1
        Me.tsmiNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiNew.Name = "tsmiNew"
        Me.tsmiNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N),System.Windows.Forms.Keys)
        Me.tsmiNew.Size = New System.Drawing.Size(171, 22)
        Me.tsmiNew.Text = "&Connect..."
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(168, 6)
        '
        'newQueryToolStripMenuItem1
        '
        Me.newQueryToolStripMenuItem1.Image = CType(resources.GetObject("newQueryToolStripMenuItem1.Image"),System.Drawing.Image)
        Me.newQueryToolStripMenuItem1.Name = "newQueryToolStripMenuItem1"
        Me.newQueryToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.newQueryToolStripMenuItem1.Text = "New Query"
        '
        'tsmiOpen
        '
        Me.tsmiOpen.Image = CType(resources.GetObject("tsmiOpen.Image"),System.Drawing.Image)
        Me.tsmiOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiOpen.Name = "tsmiOpen"
        Me.tsmiOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O),System.Windows.Forms.Keys)
        Me.tsmiOpen.Size = New System.Drawing.Size(171, 22)
        Me.tsmiOpen.Text = "&Open"
        '
        'tsmiSave
        '
        Me.tsmiSave.Image = CType(resources.GetObject("tsmiSave.Image"),System.Drawing.Image)
        Me.tsmiSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiSave.Name = "tsmiSave"
        Me.tsmiSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
        Me.tsmiSave.Size = New System.Drawing.Size(171, 22)
        Me.tsmiSave.Text = "&Save"
        '
        'tsmiSaveAs
        '
        Me.tsmiSaveAs.Image = Global.FullFeaturedDemo.Resources.drive_disk
        Me.tsmiSaveAs.Name = "tsmiSaveAs"
        Me.tsmiSaveAs.Size = New System.Drawing.Size(171, 22)
        Me.tsmiSaveAs.Text = "Save As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(171, 22)
        Me.tsmiExit.Text = "E&xit"
        '
        'editToolStripMenuItem
        '
        Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiUndo, Me.tsmiRedo, Me.toolStripSeparator3, Me.tsmiCut, Me.tsmiCopy, Me.tsmiPaste, Me.toolStripSeparator4, Me.tsmiSelectAll})
        Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
        Me.editToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.editToolStripMenuItem.Text = "&Edit"
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
        Me.tsmiCut.Image = CType(resources.GetObject("tsmiCut.Image"),System.Drawing.Image)
        Me.tsmiCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiCut.Name = "tsmiCut"
        Me.tsmiCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X),System.Windows.Forms.Keys)
        Me.tsmiCut.Size = New System.Drawing.Size(144, 22)
        Me.tsmiCut.Text = "Cu&t"
        '
        'tsmiCopy
        '
        Me.tsmiCopy.Image = Global.FullFeaturedDemo.Resources.page_copy
        Me.tsmiCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiCopy.Name = "tsmiCopy"
        Me.tsmiCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C),System.Windows.Forms.Keys)
        Me.tsmiCopy.Size = New System.Drawing.Size(144, 22)
        Me.tsmiCopy.Text = "&Copy"
        '
        'tsmiPaste
        '
        Me.tsmiPaste.Image = Global.FullFeaturedDemo.Resources.page_paste
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
        'tsmiQuery
        '
        Me.tsmiQuery.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiParseQuery, Me.toolStripSeparator8, Me.tsmiBuildQuery, Me.tsmiRunQuery, Me.toolStripSeparator9, Me.addObjectToolStripMenuItem, Me.addDerivedTableToolStripMenuItem, Me.addUnionSubqueryToolStripMenuItem, Me.copyUnionSubwueryToolStripMenuItem, Me.toolStripSeparator5, Me.tsmiQueryStatistics, Me.queryPropertiesToolStripMenuItem})
        Me.tsmiQuery.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsmiQuery.Name = "tsmiQuery"
        Me.tsmiQuery.Size = New System.Drawing.Size(53, 20)
        Me.tsmiQuery.Text = "&Query"
        '
        'tsmiParseQuery
        '
        Me.tsmiParseQuery.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsmiParseQuery.Name = "tsmiParseQuery"
        Me.tsmiParseQuery.ShortcutKeyDisplayString = ""
        Me.tsmiParseQuery.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.tsmiParseQuery.Size = New System.Drawing.Size(197, 22)
        Me.tsmiParseQuery.Text = "Parse Query"
        '
        'toolStripSeparator8
        '
        Me.toolStripSeparator8.Name = "toolStripSeparator8"
        Me.toolStripSeparator8.Size = New System.Drawing.Size(194, 6)
        '
        'tsmiBuildQuery
        '
        Me.tsmiBuildQuery.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsmiBuildQuery.Image = CType(resources.GetObject("tsmiBuildQuery.Image"),System.Drawing.Image)
        Me.tsmiBuildQuery.Name = "tsmiBuildQuery"
        Me.tsmiBuildQuery.ShortcutKeyDisplayString = ""
        Me.tsmiBuildQuery.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.tsmiBuildQuery.Size = New System.Drawing.Size(197, 22)
        Me.tsmiBuildQuery.Text = "Build Query"
        '
        'tsmiRunQuery
        '
        Me.tsmiRunQuery.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsmiRunQuery.Image = CType(resources.GetObject("tsmiRunQuery.Image"),System.Drawing.Image)
        Me.tsmiRunQuery.Name = "tsmiRunQuery"
        Me.tsmiRunQuery.ShortcutKeyDisplayString = ""
        Me.tsmiRunQuery.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.tsmiRunQuery.Size = New System.Drawing.Size(197, 22)
        Me.tsmiRunQuery.Text = "Run Query"
        '
        'toolStripSeparator9
        '
        Me.toolStripSeparator9.Name = "toolStripSeparator9"
        Me.toolStripSeparator9.Size = New System.Drawing.Size(194, 6)
        '
        'addObjectToolStripMenuItem
        '
        Me.addObjectToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.addObjectToolStripMenuItem.Image = Global.FullFeaturedDemo.Resources.new_object
        Me.addObjectToolStripMenuItem.Name = "addObjectToolStripMenuItem"
        Me.addObjectToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.addObjectToolStripMenuItem.Text = "Add Object"
        '
        'addDerivedTableToolStripMenuItem
        '
        Me.addDerivedTableToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.addDerivedTableToolStripMenuItem.Image = Global.FullFeaturedDemo.Resources.add_derived_table
        Me.addDerivedTableToolStripMenuItem.Name = "addDerivedTableToolStripMenuItem"
        Me.addDerivedTableToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.addDerivedTableToolStripMenuItem.Text = "Add Derived Table"
        '
        'addUnionSubqueryToolStripMenuItem
        '
        Me.addUnionSubqueryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.addUnionSubqueryToolStripMenuItem.Image = Global.FullFeaturedDemo.Resources.add_union_subquery
        Me.addUnionSubqueryToolStripMenuItem.Name = "addUnionSubqueryToolStripMenuItem"
        Me.addUnionSubqueryToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.addUnionSubqueryToolStripMenuItem.Text = "Add Union Sub-Query"
        '
        'copyUnionSubwueryToolStripMenuItem
        '
        Me.copyUnionSubwueryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.copyUnionSubwueryToolStripMenuItem.Image = Global.FullFeaturedDemo.Resources.copy_union_subquery
        Me.copyUnionSubwueryToolStripMenuItem.Name = "copyUnionSubwueryToolStripMenuItem"
        Me.copyUnionSubwueryToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.copyUnionSubwueryToolStripMenuItem.Text = "Copy Union Sub-Query"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(194, 6)
        '
        'tsmiQueryStatistics
        '
        Me.tsmiQueryStatistics.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsmiQueryStatistics.Name = "tsmiQueryStatistics"
        Me.tsmiQueryStatistics.ShortcutKeyDisplayString = ""
        Me.tsmiQueryStatistics.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.tsmiQueryStatistics.Size = New System.Drawing.Size(197, 22)
        Me.tsmiQueryStatistics.Text = "Query Statistics"
        '
        'queryPropertiesToolStripMenuItem
        '
        Me.queryPropertiesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryPropertiesToolStripMenuItem.Name = "queryPropertiesToolStripMenuItem"
        Me.queryPropertiesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.queryPropertiesToolStripMenuItem.Text = "Query Properties"
        '
        'metadataToolStripMenuItem
        '
        Me.metadataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiOfflineMode, Me.toolStripSeparator11, Me.tsmiRefreshMetadata, Me.tsmiEditMetadata, Me.tsmiClearMetadata, Me.toolStripSeparator10, Me.tsmiLoadMetadataFromXML, Me.tsmiSaveMetadataToXML})
        Me.metadataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.metadataToolStripMenuItem.Name = "metadataToolStripMenuItem"
        Me.metadataToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.metadataToolStripMenuItem.Text = "Metadata"
        '
        'tsmiOfflineMode
        '
        Me.tsmiOfflineMode.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.tsmiOfflineMode.Name = "tsmiOfflineMode"
        Me.tsmiOfflineMode.Size = New System.Drawing.Size(218, 22)
        Me.tsmiOfflineMode.Text = "Offline Mode"
        '
        'toolStripSeparator11
        '
        Me.toolStripSeparator11.Name = "toolStripSeparator11"
        Me.toolStripSeparator11.Size = New System.Drawing.Size(215, 6)
        '
        'tsmiRefreshMetadata
        '
        Me.tsmiRefreshMetadata.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.tsmiRefreshMetadata.Name = "tsmiRefreshMetadata"
        Me.tsmiRefreshMetadata.Size = New System.Drawing.Size(218, 22)
        Me.tsmiRefreshMetadata.Text = "Refresh Metadata"
        '
        'tsmiEditMetadata
        '
        Me.tsmiEditMetadata.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.tsmiEditMetadata.Name = "tsmiEditMetadata"
        Me.tsmiEditMetadata.Size = New System.Drawing.Size(218, 22)
        Me.tsmiEditMetadata.Text = "Edit Metadata"
        '
        'tsmiClearMetadata
        '
        Me.tsmiClearMetadata.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.tsmiClearMetadata.Name = "tsmiClearMetadata"
        Me.tsmiClearMetadata.Size = New System.Drawing.Size(218, 22)
        Me.tsmiClearMetadata.Text = "Clear Metadata"
        '
        'toolStripSeparator10
        '
        Me.toolStripSeparator10.Name = "toolStripSeparator10"
        Me.toolStripSeparator10.Size = New System.Drawing.Size(215, 6)
        '
        'tsmiLoadMetadataFromXML
        '
        Me.tsmiLoadMetadataFromXML.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.tsmiLoadMetadataFromXML.Name = "tsmiLoadMetadataFromXML"
        Me.tsmiLoadMetadataFromXML.Size = New System.Drawing.Size(218, 22)
        Me.tsmiLoadMetadataFromXML.Text = "Load Metadata from XML..."
        '
        'tsmiSaveMetadataToXML
        '
        Me.tsmiSaveMetadataToXML.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.tsmiSaveMetadataToXML.Name = "tsmiSaveMetadataToXML"
        Me.tsmiSaveMetadataToXML.Size = New System.Drawing.Size(218, 22)
        Me.tsmiSaveMetadataToXML.Text = "Save Metadata to XML..."
        '
        'toolsToolStripMenuItem
        '
        Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.languageToolStripMenuItem, Me.propertiesToolStripMenuItem})
        Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
        Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.toolsToolStripMenuItem.Text = "&Options"
        '
        'languageToolStripMenuItem
        '
        Me.languageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiLanguageAuto, Me.tsmiLanguageDefault, Me.toolStripSeparator12})
        Me.languageToolStripMenuItem.Name = "languageToolStripMenuItem"
        Me.languageToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.languageToolStripMenuItem.Text = "Language"
        '
        'tsmiLanguageAuto
        '
        Me.tsmiLanguageAuto.Name = "tsmiLanguageAuto"
        Me.tsmiLanguageAuto.Size = New System.Drawing.Size(161, 22)
        Me.tsmiLanguageAuto.Text = "Auto"
        '
        'tsmiLanguageDefault
        '
        Me.tsmiLanguageDefault.Name = "tsmiLanguageDefault"
        Me.tsmiLanguageDefault.Size = New System.Drawing.Size(161, 22)
        Me.tsmiLanguageDefault.Text = "Default (English)"
        '
        'toolStripSeparator12
        '
        Me.toolStripSeparator12.Name = "toolStripSeparator12"
        Me.toolStripSeparator12.Size = New System.Drawing.Size(158, 6)
        '
        'propertiesToolStripMenuItem
        '
        Me.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem"
        Me.propertiesToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.propertiesToolStripMenuItem.Text = "Properties"
        '
        'tsmiAbout
        '
        Me.tsmiAbout.Name = "tsmiAbout"
        Me.tsmiAbout.Size = New System.Drawing.Size(61, 20)
        Me.tsmiAbout.Text = "&About..."
        '
        'toolStrip1
        '
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.toolStripButtonNewQuery, Me.tsbOpen, Me.tsbSave, Me.tsbSaveInFile, Me.toolStripSeparator2, Me.tsbCut, Me.tsbCopy, Me.tsbPaste, Me.toolStripSeparator6, Me.tsbEditMetadata, Me.toolStripSeparator13, Me.tsbAbout})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(878, 25)
        Me.toolStrip1.Stretch = true
        Me.toolStrip1.TabIndex = 5
        Me.toolStrip1.Text = "Main Toolbar"
        '
        'tsbNew
        '
        Me.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNew.Image = Global.FullFeaturedDemo.Resources.connect1
        Me.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNew.Name = "tsbNew"
        Me.tsbNew.Size = New System.Drawing.Size(23, 22)
        Me.tsbNew.Text = "Establish new connection..."
        '
        'toolStripButtonNewQuery
        '
        Me.toolStripButtonNewQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButtonNewQuery.Image = CType(resources.GetObject("toolStripButtonNewQuery.Image"),System.Drawing.Image)
        Me.toolStripButtonNewQuery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButtonNewQuery.Name = "toolStripButtonNewQuery"
        Me.toolStripButtonNewQuery.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButtonNewQuery.Text = "New Query"
        '
        'tsbOpen
        '
        Me.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbOpen.Image = CType(resources.GetObject("tsbOpen.Image"),System.Drawing.Image)
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(23, 22)
        Me.tsbOpen.Text = "Load query from file..."
        '
        'tsbSave
        '
        Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSave.Image = CType(resources.GetObject("tsbSave.Image"),System.Drawing.Image)
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(23, 22)
        Me.tsbSave.Text = "Save the current query"
        '
        'tsbSaveInFile
        '
        Me.tsbSaveInFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSaveInFile.Image = Global.FullFeaturedDemo.Resources.drive_disk
        Me.tsbSaveInFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSaveInFile.Name = "tsbSaveInFile"
        Me.tsbSaveInFile.Size = New System.Drawing.Size(23, 22)
        Me.tsbSaveInFile.Text = "Save query to file as..."
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbCut
        '
        Me.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCut.Image = CType(resources.GetObject("tsbCut.Image"),System.Drawing.Image)
        Me.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCut.Name = "tsbCut"
        Me.tsbCut.Size = New System.Drawing.Size(23, 22)
        Me.tsbCut.Text = "Cut"
        '
        'tsbCopy
        '
        Me.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCopy.Image = Global.FullFeaturedDemo.Resources.page_copy
        Me.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCopy.Name = "tsbCopy"
        Me.tsbCopy.Size = New System.Drawing.Size(23, 22)
        Me.tsbCopy.Text = "Copy"
        '
        'tsbPaste
        '
        Me.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPaste.Image = Global.FullFeaturedDemo.Resources.page_paste
        Me.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPaste.Name = "tsbPaste"
        Me.tsbPaste.Size = New System.Drawing.Size(23, 22)
        Me.tsbPaste.Text = "Paste"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsbEditMetadata
        '
        Me.tsbEditMetadata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditMetadata.Image = CType(resources.GetObject("tsbEditMetadata.Image"),System.Drawing.Image)
        Me.tsbEditMetadata.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditMetadata.Name = "tsbEditMetadata"
        Me.tsbEditMetadata.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditMetadata.Text = "Edit Metadata"
        '
        'toolStripSeparator13
        '
        Me.toolStripSeparator13.Name = "toolStripSeparator13"
        Me.toolStripSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAbout
        '
        Me.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAbout.Image = CType(resources.GetObject("tsbAbout.Image"),System.Drawing.Image)
        Me.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAbout.Name = "tsbAbout"
        Me.tsbAbout.Size = New System.Drawing.Size(23, 22)
        Me.tsbAbout.Text = "About..."
        '
        'toolStripPanel2
        '
        Me.toolStripPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.toolStripPanel2.Location = New System.Drawing.Point(0, 664)
        Me.toolStripPanel2.Name = "toolStripPanel2"
        Me.toolStripPanel2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.toolStripPanel2.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.toolStripPanel2.Size = New System.Drawing.Size(878, 0)
        '
        'toolStripButton2
        '
        Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton2.Name = "toolStripButton2"
        Me.toolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButton2.Text = "toolStripButton2"
        '
        'toolStripButton3
        '
        Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"),System.Drawing.Image)
        Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton3.Name = "toolStripButton3"
        Me.toolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButton3.Text = "toolStripButton3"
        '
        'toolStripButton4
        '
        Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"),System.Drawing.Image)
        Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton4.Name = "toolStripButton4"
        Me.toolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButton4.Text = "toolStripButton4"
        '
        'openFileDialog1
        '
        Me.openFileDialog1.DefaultExt = "sql"
        Me.openFileDialog1.Filter = "SQL query files (*.sql)|*.sql|All files|*.*"
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.DefaultExt = "sql"
        Me.saveFileDialog1.FileName = "query"
        Me.saveFileDialog1.Filter = "SQL query files (*.sql)|*.sql|All files|*.*"
        '
        'contextMenuStripForRichTextBox
        '
        Me.contextMenuStripForRichTextBox.Name = "contextMenuStripForRichTextBox"
        Me.contextMenuStripForRichTextBox.Size = New System.Drawing.Size(61, 4)
        '
        'pageQueryResult
        '
        Me.pageQueryResult.Controls.Add(Me.splitContainer2)
        Me.pageQueryResult.ImageIndex = 1
        Me.pageQueryResult.Location = New System.Drawing.Point(4, 27)
        Me.pageQueryResult.Name = "pageQueryResult"
        Me.pageQueryResult.Padding = New System.Windows.Forms.Padding(3)
        Me.pageQueryResult.Size = New System.Drawing.Size(870, 584)
        Me.pageQueryResult.TabIndex = 1
        Me.pageQueryResult.Text = "Query Result"
        Me.pageQueryResult.UseVisualStyleBackColor = true
        '
        'splitContainer2
        '
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.splitContainer2.Name = "splitContainer2"
        Me.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.Controls.Add(Me.resultGrid1)
        Me.splitContainer2.Panel1.Controls.Add(Me.paginationPanel1)
        Me.splitContainer2.Panel1.Controls.Add(Me.CBuilder)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.teResultSql)
        Me.splitContainer2.Size = New System.Drawing.Size(864, 578)
        Me.splitContainer2.SplitterDistance = 483
        Me.splitContainer2.TabIndex = 0
        '
        'resultGrid1
        '
        Me.resultGrid1.AutoSize = true
        Me.resultGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resultGrid1.Location = New System.Drawing.Point(0, 51)
        Me.resultGrid1.Name = "resultGrid1"
        Me.resultGrid1.QueryTransformer = Nothing
        Me.resultGrid1.Size = New System.Drawing.Size(864, 403)
        Me.resultGrid1.SqlQuery = Nothing
        Me.resultGrid1.TabIndex = 6
        '
        'paginationPanel1
        '
        Me.paginationPanel1.CurrentPage = 1
        Me.paginationPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.paginationPanel1.IsSupportLimitCount = false
        Me.paginationPanel1.IsSupportLimitOffset = false
        Me.paginationPanel1.Location = New System.Drawing.Point(0, 454)
        Me.paginationPanel1.Name = "paginationPanel1"
        Me.paginationPanel1.PageSize = 10
        Me.paginationPanel1.RowsCount = 0
        Me.paginationPanel1.Size = New System.Drawing.Size(864, 29)
        Me.paginationPanel1.TabIndex = 3
        '
        'CBuilder
        '
        Me.CBuilder.AutoSize = true
        Me.CBuilder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CBuilder.Dock = System.Windows.Forms.DockStyle.Top
        Me.CBuilder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CBuilder.JunctionPostfix = Nothing
        Me.CBuilder.Location = New System.Drawing.Point(0, 0)
        Me.CBuilder.MinimumSize = New System.Drawing.Size(188, 51)
        Me.CBuilder.Name = "CBuilder"
        Me.CBuilder.QueryTransformer = Nothing
        Me.CBuilder.RootItemFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CBuilder.RootJunctionPrefix = Nothing
        Me.CBuilder.Size = New System.Drawing.Size(864, 51)
        Me.CBuilder.TabIndex = 1
        '
        'teResultSql
        '
        Me.teResultSql.BackColor = System.Drawing.Color.LemonChiffon
        Me.teResultSql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.teResultSql.Font = New System.Drawing.Font("Courier New", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.teResultSql.Location = New System.Drawing.Point(0, 0)
        Me.teResultSql.Name = "teResultSql"
        Me.teResultSql.ReadOnly = true
        Me.teResultSql.Size = New System.Drawing.Size(864, 91)
        Me.teResultSql.TabIndex = 0
        Me.teResultSql.Text = ""
        '
        'pageQueryBuilder
        '
        Me.pageQueryBuilder.Controls.Add(Me.splitContainer1)
        Me.pageQueryBuilder.ImageIndex = 0
        Me.pageQueryBuilder.Location = New System.Drawing.Point(4, 27)
        Me.pageQueryBuilder.Name = "pageQueryBuilder"
        Me.pageQueryBuilder.Padding = New System.Windows.Forms.Padding(3)
        Me.pageQueryBuilder.Size = New System.Drawing.Size(870, 584)
        Me.pageQueryBuilder.TabIndex = 0
        Me.pageQueryBuilder.Text = "Query Builder"
        Me.pageQueryBuilder.UseVisualStyleBackColor = true
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.panel1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.tableLayoutPanel4)
        Me.splitContainer1.Size = New System.Drawing.Size(864, 578)
        Me.splitContainer1.SplitterDistance = 381
        Me.splitContainer1.TabIndex = 1
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.queryBuilder1)
        Me.panel1.Controls.Add(Me.toolStrip2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(864, 381)
        Me.panel1.TabIndex = 0
        '
        'queryBuilder1
        '
        Me.queryBuilder1.AddObjectDialogOptions.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder1.AddObjectDialogOptions.Size = New System.Drawing.Size(400, 400)
        Me.queryBuilder1.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = false
        Me.queryBuilder1.DataSourceOptions.DefaultWidth = 210
        Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.queryBuilder1.Location = New System.Drawing.Point(0, 25)
        Me.queryBuilder1.MetadataLoadingOptions.ExcludeFilter.Types = ActiveQueryBuilder.Core.MetadataType.None
        Me.queryBuilder1.MetadataStructureOptions.ProceduresFolderText = "Procedures"
        Me.queryBuilder1.MetadataStructureOptions.SynonymsFolderText = "Synonyms"
        Me.queryBuilder1.MetadataStructureOptions.TablesFolderText = "Tables"
        Me.queryBuilder1.MetadataStructureOptions.ViewsFolderText = "Views"
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.PanesConfigurationOptions.DisableQueryNavigationBarPopup = false
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = true
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = true
        Me.queryBuilder1.QueryColumnListOptions.BackColor = System.Drawing.Color.Transparent
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 140
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 200
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 250
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 100
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 100
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 60
        Me.queryBuilder1.QueryColumnListOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = false
        Me.queryBuilder1.QueryColumnListOptions.RowHeadersWidth = 15
        Me.queryBuilder1.QueryColumnListOptions.TextColor = System.Drawing.SystemColors.ControlText
        Me.queryBuilder1.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder1.Size = New System.Drawing.Size(864, 356)
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
        Me.queryBuilder1.TabIndex = 3
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
        Me.queryBuilder1.VisualOptions.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryBuilder1.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        '
        'toolStrip2
        '
        Me.toolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbQueryProperties, Me.tsbAddObject, Me.toolStripSeparator14, Me.tsbAddDerivedTable, Me.tsbAddUnionSubquery, Me.tsbCopyUnionSubquery, Me.toolStripSeparator15})
        Me.toolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip2.Name = "toolStrip2"
        Me.toolStrip2.Size = New System.Drawing.Size(864, 25)
        Me.toolStrip2.Stretch = true
        Me.toolStrip2.TabIndex = 2
        '
        'tsbQueryProperties
        '
        Me.tsbQueryProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbQueryProperties.Image = Global.FullFeaturedDemo.Resources.query_properties
        Me.tsbQueryProperties.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQueryProperties.Name = "tsbQueryProperties"
        Me.tsbQueryProperties.Size = New System.Drawing.Size(23, 22)
        Me.tsbQueryProperties.Text = "Properties"
        '
        'tsbAddObject
        '
        Me.tsbAddObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddObject.Image = Global.FullFeaturedDemo.Resources.new_object
        Me.tsbAddObject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddObject.Name = "tsbAddObject"
        Me.tsbAddObject.Size = New System.Drawing.Size(23, 22)
        Me.tsbAddObject.Text = "Add Object"
        '
        'toolStripSeparator14
        '
        Me.toolStripSeparator14.Name = "toolStripSeparator14"
        Me.toolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAddDerivedTable
        '
        Me.tsbAddDerivedTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddDerivedTable.Image = Global.FullFeaturedDemo.Resources.add_derived_table
        Me.tsbAddDerivedTable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddDerivedTable.Name = "tsbAddDerivedTable"
        Me.tsbAddDerivedTable.Size = New System.Drawing.Size(23, 22)
        Me.tsbAddDerivedTable.Text = "Add Derived Table"
        '
        'tsbAddUnionSubquery
        '
        Me.tsbAddUnionSubquery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddUnionSubquery.Image = Global.FullFeaturedDemo.Resources.add_union_subquery
        Me.tsbAddUnionSubquery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddUnionSubquery.Name = "tsbAddUnionSubquery"
        Me.tsbAddUnionSubquery.Size = New System.Drawing.Size(23, 22)
        Me.tsbAddUnionSubquery.Text = "New union sub-query"
        '
        'tsbCopyUnionSubquery
        '
        Me.tsbCopyUnionSubquery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCopyUnionSubquery.Image = Global.FullFeaturedDemo.Resources.copy_union_subquery
        Me.tsbCopyUnionSubquery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCopyUnionSubquery.Name = "tsbCopyUnionSubquery"
        Me.tsbCopyUnionSubquery.Size = New System.Drawing.Size(23, 22)
        Me.tsbCopyUnionSubquery.Text = "Copy Union Sub-query"
        '
        'toolStripSeparator15
        '
        Me.toolStripSeparator15.Name = "toolStripSeparator15"
        Me.toolStripSeparator15.Size = New System.Drawing.Size(6, 25)
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
        Me.tableLayoutPanel4.Size = New System.Drawing.Size(864, 193)
        Me.tableLayoutPanel4.TabIndex = 1
        '
        'labelSleepMode
        '
        Me.labelSleepMode.AutoSize = true
        Me.labelSleepMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.labelSleepMode.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelSleepMode.Location = New System.Drawing.Point(3, 0)
        Me.labelSleepMode.Name = "labelSleepMode"
        Me.labelSleepMode.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.labelSleepMode.Size = New System.Drawing.Size(858, 23)
        Me.labelSleepMode.TabIndex = 2
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
        Me.tabControl2.Size = New System.Drawing.Size(858, 164)
        Me.tabControl2.TabIndex = 0
        '
        'tabPageSQL
        '
        Me.tabPageSQL.Controls.Add(Me.tableLayoutPanel1)
        Me.tabPageSQL.Location = New System.Drawing.Point(4, 22)
        Me.tabPageSQL.Name = "tabPageSQL"
        Me.tabPageSQL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageSQL.Size = New System.Drawing.Size(850, 138)
        Me.tabPageSQL.TabIndex = 0
        Me.tabPageSQL.Text = "SQL Query Text"
        Me.tabPageSQL.UseVisualStyleBackColor = true
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.Controls.Add(Me.teSql, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(844, 132)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'teSql
        '
        Me.teSql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.teSql.Font = New System.Drawing.Font("Courier New", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.teSql.Location = New System.Drawing.Point(3, 31)
        Me.teSql.Name = "teSql"
        Me.teSql.Size = New System.Drawing.Size(838, 98)
        Me.teSql.TabIndex = 0
        Me.teSql.Text = ""
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
        'tabPageCurrentSubQuery
        '
        Me.tabPageCurrentSubQuery.Controls.Add(Me.tableLayoutPanel2)
        Me.tabPageCurrentSubQuery.Location = New System.Drawing.Point(4, 22)
        Me.tabPageCurrentSubQuery.Name = "tabPageCurrentSubQuery"
        Me.tabPageCurrentSubQuery.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageCurrentSubQuery.Size = New System.Drawing.Size(850, 138)
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
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(844, 132)
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
        Me.panel3.Controls.Add(Me.infoPanel2)
        Me.panel3.Controls.Add(Me.TextBoxCurrentSubQuerySql)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(3, 31)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(838, 98)
        Me.panel3.TabIndex = 3
        '
        'infoPanel2
        '
        Me.infoPanel2.AutoSize = true
        Me.infoPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.infoPanel2.BackColor = System.Drawing.Color.LightCoral
        Me.infoPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.infoPanel2.Location = New System.Drawing.Point(0, 61)
        Me.infoPanel2.Message = "1212"
        Me.infoPanel2.Name = "infoPanel2"
        Me.infoPanel2.Size = New System.Drawing.Size(838, 37)
        Me.infoPanel2.TabIndex = 4
        Me.infoPanel2.Visible = false
        '
        'TextBoxCurrentSubQuerySql
        '
        Me.TextBoxCurrentSubQuerySql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCurrentSubQuerySql.Font = New System.Drawing.Font("Courier New", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.TextBoxCurrentSubQuerySql.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxCurrentSubQuerySql.Name = "TextBoxCurrentSubQuerySql"
        Me.TextBoxCurrentSubQuerySql.Size = New System.Drawing.Size(838, 98)
        Me.TextBoxCurrentSubQuerySql.TabIndex = 0
        Me.TextBoxCurrentSubQuerySql.Text = ""
        '
        'tabPageFastResult
        '
        Me.tabPageFastResult.Controls.Add(Me.tableLayoutPanel3)
        Me.tabPageFastResult.Location = New System.Drawing.Point(4, 22)
        Me.tabPageFastResult.Name = "tabPageFastResult"
        Me.tabPageFastResult.Size = New System.Drawing.Size(850, 138)
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
        Me.tableLayoutPanel3.Size = New System.Drawing.Size(850, 138)
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
        Me.panel2.Size = New System.Drawing.Size(844, 101)
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
        Me.resultGrid2.Size = New System.Drawing.Size(844, 101)
        Me.resultGrid2.SqlQuery = Nothing
        Me.resultGrid2.TabIndex = 0
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AccessibleName = "����� ������ ��������"
        Me.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.miniToolStrip.AutoSize = false
        Me.miniToolStrip.CanOverflow = false
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.Location = New System.Drawing.Point(136, 3)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(819, 25)
        Me.miniToolStrip.Stretch = true
        Me.miniToolStrip.TabIndex = 2
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.pageQueryBuilder)
        Me.tabControl1.Controls.Add(Me.pageQueryResult)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.ImageList = Me.imageList1
        Me.tabControl1.ItemSize = New System.Drawing.Size(97, 23)
        Me.tabControl1.Location = New System.Drawing.Point(0, 49)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(878, 615)
        Me.tabControl1.TabIndex = 7
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 664)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.toolStripPanel2)
        Me.Controls.Add(Me.toolStripPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.IsMdiContainer = true
        Me.MainMenuStrip = Me.menuStrip1
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Active Query Builder for .NET WinForms Edition - Standard Full-featured demo (C#)"& _ 
    ""
        Me.toolStripPanel1.ResumeLayout(false)
        Me.toolStripPanel1.PerformLayout
        Me.menuStrip1.ResumeLayout(false)
        Me.menuStrip1.PerformLayout
        Me.toolStrip1.ResumeLayout(false)
        Me.toolStrip1.PerformLayout
        Me.pageQueryResult.ResumeLayout(false)
        Me.splitContainer2.Panel1.ResumeLayout(false)
        Me.splitContainer2.Panel1.PerformLayout
        Me.splitContainer2.Panel2.ResumeLayout(false)
        CType(Me.splitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer2.ResumeLayout(false)
        Me.pageQueryBuilder.ResumeLayout(false)
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        CType(Me.queryBuilder1,System.ComponentModel.ISupportInitialize).EndInit
        Me.toolStrip2.ResumeLayout(false)
        Me.toolStrip2.PerformLayout
        Me.tableLayoutPanel4.ResumeLayout(false)
        Me.tableLayoutPanel4.PerformLayout
        Me.tabControl2.ResumeLayout(false)
        Me.tabPageSQL.ResumeLayout(false)
        Me.tableLayoutPanel1.ResumeLayout(false)
        Me.tableLayoutPanel1.PerformLayout
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
        Me.tabControl1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    WithEvents Private toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator

    WithEvents Private tsmiLanguageDefault As System.Windows.Forms.ToolStripMenuItem

    WithEvents  Private tsmiLanguageAuto As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private languageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel

    WithEvents  Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private toolStripButton2 As System.Windows.Forms.ToolStripButton

    Private toolStripButton3 As System.Windows.Forms.ToolStripButton

    Private toolStripButton4 As System.Windows.Forms.ToolStripButton

    Private BottomToolStripPanel As System.Windows.Forms.ToolStripPanel

    Private TopToolStripPanel As System.Windows.Forms.ToolStripPanel

    Private RightToolStripPanel As System.Windows.Forms.ToolStripPanel

    Private LeftToolStripPanel As System.Windows.Forms.ToolStripPanel

    Private ContentPanel As System.Windows.Forms.ToolStripContentPanel

    Private toolStripPanel1 As System.Windows.Forms.ToolStripPanel

    Private menuStrip1 As System.Windows.Forms.MenuStrip

    Private fileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private tsmiNew As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private tsmiOpen As System.Windows.Forms.ToolStripMenuItem

    Private toolStripSeparator As System.Windows.Forms.ToolStripSeparator

    WithEvents Private tsmiSave As System.Windows.Forms.ToolStripMenuItem

    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

    WithEvents  Private tsmiExit As System.Windows.Forms.ToolStripMenuItem

    Private toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private tsmiAbout As System.Windows.Forms.ToolStripMenuItem

    Private toolStrip1 As System.Windows.Forms.ToolStrip

    WithEvents Private tsbNew As System.Windows.Forms.ToolStripButton

    Private toolStripPanel2 As System.Windows.Forms.ToolStripPanel

    WithEvents Private tsbOpen As System.Windows.Forms.ToolStripButton

    WithEvents Private tsbSave As System.Windows.Forms.ToolStripButton

    Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

    WithEvents Private tsbAbout As System.Windows.Forms.ToolStripButton

    Private tsmiQuery As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private tsmiBuildQuery As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private tsmiRunQuery As System.Windows.Forms.ToolStripMenuItem

    Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator

    WithEvents Private tsmiQueryStatistics As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private openFileDialog1 As System.Windows.Forms.OpenFileDialog

    WithEvents Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog

    Private metadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    WithEvents  Private tsmiRefreshMetadata As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private tsmiEditMetadata As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private tsmiClearMetadata As System.Windows.Forms.ToolStripMenuItem

    Private toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator

    WithEvents Private tsmiOfflineMode As System.Windows.Forms.ToolStripMenuItem

    Private toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator

    WithEvents Private tsmiLoadMetadataFromXML As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private tsmiSaveMetadataToXML As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private addDerivedTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private addUnionSubqueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private copyUnionSubwueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private addObjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator

    WithEvents Private queryPropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private propertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private newQueryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private toolStripButtonNewQuery As System.Windows.Forms.ToolStripButton

    WithEvents Private tsbEditMetadata As System.Windows.Forms.ToolStripButton

    Private toolStripSeparator13 As System.Windows.Forms.ToolStripSeparator

    WithEvents Private tsbSaveInFile As System.Windows.Forms.ToolStripButton

    Private imageList1 As System.Windows.Forms.ImageList

    Private imageList2 As System.Windows.Forms.ImageList

    Private imageList3 As System.Windows.Forms.ImageList

    WithEvents Private tsmiSaveAs As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private contextMenuStripForRichTextBox As System.Windows.Forms.ContextMenuStrip

    WithEvents Private tsmiParseQuery As System.Windows.Forms.ToolStripMenuItem

    Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator

    WithEvents  Private tsbCut As System.Windows.Forms.ToolStripButton

    WithEvents Private tsbCopy As System.Windows.Forms.ToolStripButton

    WithEvents Private tsbPaste As System.Windows.Forms.ToolStripButton

    Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator

    WithEvents  Private editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private tsmiUndo As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private tsmiRedo As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

    WithEvents Private tsmiCut As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private tsmiCopy As System.Windows.Forms.ToolStripMenuItem

    WithEvents Private tsmiPaste As System.Windows.Forms.ToolStripMenuItem

    Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator

    WithEvents Private tsmiSelectAll As System.Windows.Forms.ToolStripMenuItem

    Private pageQueryResult As System.Windows.Forms.TabPage

    Private splitContainer2 As System.Windows.Forms.SplitContainer

    WithEvents Private paginationPanel1 As PaginationPanel

    Private CBuilder As ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder

    Private teResultSql As System.Windows.Forms.RichTextBox

    Private pageQueryBuilder As System.Windows.Forms.TabPage

    Private splitContainer1 As System.Windows.Forms.SplitContainer

    Private panel1 As System.Windows.Forms.Panel

    Private toolStrip2 As System.Windows.Forms.ToolStrip

    WithEvents Private tsbQueryProperties As System.Windows.Forms.ToolStripButton

    WithEvents Private tsbAddObject As System.Windows.Forms.ToolStripButton

    Private toolStripSeparator14 As System.Windows.Forms.ToolStripSeparator

    WithEvents Private tsbAddDerivedTable As System.Windows.Forms.ToolStripButton

    WithEvents Private tsbAddUnionSubquery As System.Windows.Forms.ToolStripButton

    WithEvents Private tsbCopyUnionSubquery As System.Windows.Forms.ToolStripButton

    Private toolStripSeparator15 As System.Windows.Forms.ToolStripSeparator

    WithEvents  Private teSql As System.Windows.Forms.RichTextBox

    Private miniToolStrip As System.Windows.Forms.ToolStrip

    WithEvents Private tabControl1 As System.Windows.Forms.TabControl

    WithEvents Private tabControl2 As System.Windows.Forms.TabControl

    WithEvents Private tabPageSQL As System.Windows.Forms.TabPage

    Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

    Private label1 As System.Windows.Forms.Label

    Private tabPageCurrentSubQuery As System.Windows.Forms.TabPage

    Private tabPageFastResult As System.Windows.Forms.TabPage

    Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel

    WithEvents Private TextBoxCurrentSubQuerySql As System.Windows.Forms.RichTextBox

    Private label2 As System.Windows.Forms.Label

    Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel

    Private label3 As System.Windows.Forms.Label

    Private panel2 As System.Windows.Forms.Panel

    WithEvents Private queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder

    Private panel3 As System.Windows.Forms.Panel

    WithEvents Private infoPanel2 As Common.InfoPanel

    Private tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel

    Private labelSleepMode As System.Windows.Forms.Label

    WithEvents Private resultGrid1 As Common.ResultGrid

    WithEvents Private resultGrid2 As Common.ResultGrid
End Class

