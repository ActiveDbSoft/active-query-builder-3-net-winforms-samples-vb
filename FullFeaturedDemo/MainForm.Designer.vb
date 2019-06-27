

Partial Class MainForm
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of Me method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim LinkPainterAccess1 As ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess = New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
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
        Me.paginationPanel1 = New FullFeaturedDemo.PaginationPanel()
        Me.toolStripPanel2 = New System.Windows.Forms.ToolStripPanel()
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.pageQueryBuilder = New System.Windows.Forms.TabPage()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.toolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbQueryProperties = New System.Windows.Forms.ToolStripButton()
        Me.tsbAddObject = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAddDerivedTable = New System.Windows.Forms.ToolStripButton()
        Me.tsbAddUnionSubquery = New System.Windows.Forms.ToolStripButton()
        Me.tsbCopyUnionSubquery = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.teSql = New System.Windows.Forms.RichTextBox()
        Me.pageQueryResult = New System.Windows.Forms.TabPage()
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CBuilder = New ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder()
        Me.teResultSql = New System.Windows.Forms.RichTextBox()
        Me.contextMenuStripForRichTextBox = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.labelSleepMode = New System.Windows.Forms.Label()
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.toolStripPanel1.SuspendLayout
        Me.menuStrip1.SuspendLayout
        Me.toolStrip1.SuspendLayout
        Me.tabControl1.SuspendLayout
        Me.pageQueryBuilder.SuspendLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer1.Panel1.SuspendLayout
        Me.splitContainer1.Panel2.SuspendLayout
        Me.splitContainer1.SuspendLayout
        Me.panel1.SuspendLayout
        Me.toolStrip2.SuspendLayout
        Me.pageQueryResult.SuspendLayout
        CType(Me.splitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer2.Panel1.SuspendLayout
        Me.splitContainer2.Panel2.SuspendLayout
        Me.splitContainer2.SuspendLayout
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder1.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder1.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.toolStripPanel1.Size = New System.Drawing.Size(833, 49)
        '
        'menuStrip1
        '
        Me.menuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem1, Me.editToolStripMenuItem, Me.tsmiQuery, Me.metadataToolStripMenuItem, Me.toolsToolStripMenuItem, Me.tsmiAbout})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(833, 24)
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
        Me.tsmiSaveAs.Image = CType(resources.GetObject("tsmiSaveAs.Image"),System.Drawing.Image)
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
        Me.tsmiCopy.Image = CType(resources.GetObject("tsmiCopy.Image"),System.Drawing.Image)
        Me.tsmiCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiCopy.Name = "tsmiCopy"
        Me.tsmiCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C),System.Windows.Forms.Keys)
        Me.tsmiCopy.Size = New System.Drawing.Size(144, 22)
        Me.tsmiCopy.Text = "&Copy"
        '
        'tsmiPaste
        '
        Me.tsmiPaste.Image = CType(resources.GetObject("tsmiPaste.Image"),System.Drawing.Image)
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
        Me.addObjectToolStripMenuItem.Image = CType(resources.GetObject("addObjectToolStripMenuItem.Image"),System.Drawing.Image)
        Me.addObjectToolStripMenuItem.Name = "addObjectToolStripMenuItem"
        Me.addObjectToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.addObjectToolStripMenuItem.Text = "Add Object"
        '
        'addDerivedTableToolStripMenuItem
        '
        Me.addDerivedTableToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.addDerivedTableToolStripMenuItem.Image = CType(resources.GetObject("addDerivedTableToolStripMenuItem.Image"),System.Drawing.Image)
        Me.addDerivedTableToolStripMenuItem.Name = "addDerivedTableToolStripMenuItem"
        Me.addDerivedTableToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.addDerivedTableToolStripMenuItem.Text = "Add Derived Table"
        '
        'addUnionSubqueryToolStripMenuItem
        '
        Me.addUnionSubqueryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.addUnionSubqueryToolStripMenuItem.Image = CType(resources.GetObject("addUnionSubqueryToolStripMenuItem.Image"),System.Drawing.Image)
        Me.addUnionSubqueryToolStripMenuItem.Name = "addUnionSubqueryToolStripMenuItem"
        Me.addUnionSubqueryToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.addUnionSubqueryToolStripMenuItem.Text = "Add Union Sub-Query"
        '
        'copyUnionSubwueryToolStripMenuItem
        '
        Me.copyUnionSubwueryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.copyUnionSubwueryToolStripMenuItem.Image = CType(resources.GetObject("copyUnionSubwueryToolStripMenuItem.Image"),System.Drawing.Image)
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
        Me.toolStrip1.Size = New System.Drawing.Size(833, 25)
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
        Me.tsbSaveInFile.Image = CType(resources.GetObject("tsbSaveInFile.Image"),System.Drawing.Image)
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
        Me.tsbCopy.Image = CType(resources.GetObject("tsbCopy.Image"),System.Drawing.Image)
        Me.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCopy.Name = "tsbCopy"
        Me.tsbCopy.Size = New System.Drawing.Size(23, 22)
        Me.tsbCopy.Text = "Copy"
        '
        'tsbPaste
        '
        Me.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPaste.Image = CType(resources.GetObject("tsbPaste.Image"),System.Drawing.Image)
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
        'paginationPanel1
        '
        Me.paginationPanel1.CurrentPage = 1
        Me.paginationPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.paginationPanel1.IsSupportLimitCount = false
        Me.paginationPanel1.IsSupportLimitOffset = false
        Me.paginationPanel1.Location = New System.Drawing.Point(0, 379)
        Me.paginationPanel1.Name = "paginationPanel1"
        Me.paginationPanel1.PageSize = 10
        Me.paginationPanel1.RowsCount = 0
        Me.paginationPanel1.Size = New System.Drawing.Size(819, 29)
        Me.paginationPanel1.TabIndex = 3
        '
        'toolStripPanel2
        '
        Me.toolStripPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.toolStripPanel2.Location = New System.Drawing.Point(0, 589)
        Me.toolStripPanel2.Name = "toolStripPanel2"
        Me.toolStripPanel2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.toolStripPanel2.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.toolStripPanel2.Size = New System.Drawing.Size(833, 0)
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
        Me.tabControl1.Size = New System.Drawing.Size(833, 540)
        Me.tabControl1.TabIndex = 7
        '
        'pageQueryBuilder
        '
        Me.pageQueryBuilder.Controls.Add(Me.splitContainer1)
        Me.pageQueryBuilder.ImageIndex = 0
        Me.pageQueryBuilder.Location = New System.Drawing.Point(4, 27)
        Me.pageQueryBuilder.Name = "pageQueryBuilder"
        Me.pageQueryBuilder.Padding = New System.Windows.Forms.Padding(3)
        Me.pageQueryBuilder.Size = New System.Drawing.Size(825, 509)
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
        Me.splitContainer1.Panel2.Controls.Add(Me.teSql)
        Me.splitContainer1.Size = New System.Drawing.Size(819, 503)
        Me.splitContainer1.SplitterDistance = 408
        Me.splitContainer1.TabIndex = 1
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.queryBuilder1)
        Me.panel1.Controls.Add(Me.labelSleepMode)
        Me.panel1.Controls.Add(Me.toolStrip2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(819, 408)
        Me.panel1.TabIndex = 0
        '
        'toolStrip2
        '
        Me.toolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbQueryProperties, Me.tsbAddObject, Me.toolStripSeparator14, Me.tsbAddDerivedTable, Me.tsbAddUnionSubquery, Me.tsbCopyUnionSubquery, Me.toolStripSeparator15})
        Me.toolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip2.Name = "toolStrip2"
        Me.toolStrip2.Size = New System.Drawing.Size(819, 25)
        Me.toolStrip2.Stretch = true
        Me.toolStrip2.TabIndex = 2
        '
        'tsbQueryProperties
        '
        Me.tsbQueryProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbQueryProperties.Image = CType(resources.GetObject("tsbQueryProperties.Image"),System.Drawing.Image)
        Me.tsbQueryProperties.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQueryProperties.Name = "tsbQueryProperties"
        Me.tsbQueryProperties.Size = New System.Drawing.Size(23, 22)
        Me.tsbQueryProperties.Text = "Properties"
        '
        'tsbAddObject
        '
        Me.tsbAddObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddObject.Image = CType(resources.GetObject("tsbAddObject.Image"),System.Drawing.Image)
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
        Me.tsbAddDerivedTable.Image = CType(resources.GetObject("tsbAddDerivedTable.Image"),System.Drawing.Image)
        Me.tsbAddDerivedTable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddDerivedTable.Name = "tsbAddDerivedTable"
        Me.tsbAddDerivedTable.Size = New System.Drawing.Size(23, 22)
        Me.tsbAddDerivedTable.Text = "Add Derived Table"
        '
        'tsbAddUnionSubquery
        '
        Me.tsbAddUnionSubquery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddUnionSubquery.Image = CType(resources.GetObject("tsbAddUnionSubquery.Image"),System.Drawing.Image)
        Me.tsbAddUnionSubquery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddUnionSubquery.Name = "tsbAddUnionSubquery"
        Me.tsbAddUnionSubquery.Size = New System.Drawing.Size(23, 22)
        Me.tsbAddUnionSubquery.Text = "New union sub-query"
        '
        'tsbCopyUnionSubquery
        '
        Me.tsbCopyUnionSubquery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCopyUnionSubquery.Image = CType(resources.GetObject("tsbCopyUnionSubquery.Image"),System.Drawing.Image)
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
        'teSql
        '
        Me.teSql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.teSql.Font = New System.Drawing.Font("Courier New", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.teSql.Location = New System.Drawing.Point(0, 0)
        Me.teSql.Name = "teSql"
        Me.teSql.Size = New System.Drawing.Size(819, 91)
        Me.teSql.TabIndex = 0
        Me.teSql.Text = ""
        '
        'pageQueryResult
        '
        Me.pageQueryResult.Controls.Add(Me.splitContainer2)
        Me.pageQueryResult.ImageIndex = 1
        Me.pageQueryResult.Location = New System.Drawing.Point(4, 27)
        Me.pageQueryResult.Name = "pageQueryResult"
        Me.pageQueryResult.Padding = New System.Windows.Forms.Padding(3)
        Me.pageQueryResult.Size = New System.Drawing.Size(825, 509)
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
        Me.splitContainer2.Panel1.Controls.Add(Me.paginationPanel1)
        Me.splitContainer2.Panel1.Controls.Add(Me.dataGridView1)
        Me.splitContainer2.Panel1.Controls.Add(Me.CBuilder)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.teResultSql)
        Me.splitContainer2.Size = New System.Drawing.Size(819, 503)
        Me.splitContainer2.SplitterDistance = 408
        Me.splitContainer2.TabIndex = 0
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = false
        Me.dataGridView1.AllowUserToDeleteRows = false
        Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView1.Location = New System.Drawing.Point(0, 51)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = true
        Me.dataGridView1.Size = New System.Drawing.Size(819, 357)
        Me.dataGridView1.TabIndex = 0
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
        Me.CBuilder.Size = New System.Drawing.Size(819, 51)
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
        Me.teResultSql.Size = New System.Drawing.Size(819, 91)
        Me.teResultSql.TabIndex = 0
        Me.teResultSql.Text = ""
        '
        'contextMenuStripForRichTextBox
        '
        Me.contextMenuStripForRichTextBox.Name = "contextMenuStripForRichTextBox"
        Me.contextMenuStripForRichTextBox.Size = New System.Drawing.Size(61, 4)
        '
        'labelSleepMode
        '
        Me.labelSleepMode.AutoEllipsis = true
        Me.labelSleepMode.BackColor = System.Drawing.Color.Bisque
        Me.labelSleepMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelSleepMode.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.labelSleepMode.Location = New System.Drawing.Point(0, 374)
        Me.labelSleepMode.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.labelSleepMode.Name = "labelSleepMode"
        Me.labelSleepMode.Padding = New System.Windows.Forms.Padding(10)
        Me.labelSleepMode.Size = New System.Drawing.Size(819, 34)
        Me.labelSleepMode.TabIndex = 3
        Me.labelSleepMode.Text = "Unsupported SQL statement. Visual Query Builder has been disabled. Either type a "& _ 
    "SELECT statement or start building a query visually to turn this mode off."
        Me.labelSleepMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.labelSleepMode.Visible = false
        '
        'queryBuilder1
        '
        Me.queryBuilder1.AddObjectDialogOptions.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder1.AddObjectDialogOptions.Size = New System.Drawing.Size(430, 430)
        Me.queryBuilder1.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.queryBuilder1.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = false
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
        Me.queryBuilder1.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.queryBuilder1.Location = New System.Drawing.Point(0, 25)
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 168
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = true
        Me.queryBuilder1.PanesConfigurationOptions.QueryColumnsPaneHeight = 120
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = true
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 70R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 60R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 150R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 80R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 90R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 80R
        Me.queryBuilder1.QueryColumnListOptions.Font = Nothing
        Me.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = false
        Me.queryBuilder1.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder1.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green
        Me.queryBuilder1.QueryNavBarOptions.DisableQueryNavigationBarPopup = false
        Me.queryBuilder1.QueryNavBarOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryBuilder1.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
        Me.queryBuilder1.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black
        Me.queryBuilder1.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue
        Me.queryBuilder1.Size = New System.Drawing.Size(819, 349)
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
        Me.queryBuilder1.VisualOptions.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryBuilder1.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 589)
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
        Me.tabControl1.ResumeLayout(false)
        Me.pageQueryBuilder.ResumeLayout(false)
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        Me.toolStrip2.ResumeLayout(false)
        Me.toolStrip2.PerformLayout
        Me.pageQueryResult.ResumeLayout(false)
        Me.splitContainer2.Panel1.ResumeLayout(false)
        Me.splitContainer2.Panel1.PerformLayout
        Me.splitContainer2.Panel2.ResumeLayout(false)
        CType(Me.splitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer2.ResumeLayout(false)
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder1.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder1.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

	Private toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiLanguageDefault As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiLanguageAuto As System.Windows.Forms.ToolStripMenuItem
	Private languageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

	#End Region

	Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
	Private WithEvents tsmiNew As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiOpen As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator As System.Windows.Forms.ToolStripSeparator
	Private WithEvents  tsmiSave As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiExit As System.Windows.Forms.ToolStripMenuItem
	Private toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiAbout As System.Windows.Forms.ToolStripMenuItem
	Private toolStrip1 As System.Windows.Forms.ToolStrip
	Private WithEvents tsbNew As System.Windows.Forms.ToolStripButton
	Private toolStripPanel2 As System.Windows.Forms.ToolStripPanel
	Private WithEvents tsbOpen As System.Windows.Forms.ToolStripButton
	Private WithEvents tsbSave As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsbAbout As System.Windows.Forms.ToolStripButton
	Private WithEvents tsmiQuery As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiBuildQuery As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiRunQuery As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiQueryStatistics As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private WithEvents metadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiRefreshMetadata As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiEditMetadata As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiClearMetadata As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiOfflineMode As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiLoadMetadataFromXML As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiSaveMetadataToXML As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents addDerivedTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents addUnionSubqueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents copyUnionSubwueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents addObjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents queryPropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents propertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents newQueryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents toolStripButtonNewQuery As System.Windows.Forms.ToolStripButton
	Private WithEvents tsbEditMetadata As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tabControl1 As System.Windows.Forms.TabControl
	Private pageQueryBuilder As System.Windows.Forms.TabPage
	Private panel1 As System.Windows.Forms.Panel
	Private toolStrip2 As System.Windows.Forms.ToolStrip
	Private WithEvents tsbQueryProperties As System.Windows.Forms.ToolStripButton
	Private WithEvents tsbAddObject As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsbAddDerivedTable As System.Windows.Forms.ToolStripButton
	Private WithEvents tsbAddUnionSubquery As System.Windows.Forms.ToolStripButton
	Private WithEvents tsbCopyUnionSubquery As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsbSaveInFile As System.Windows.Forms.ToolStripButton
	Private pageQueryResult As System.Windows.Forms.TabPage
	Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
	Private WithEvents paginationPanel1 As PaginationPanel
	Private CBuilder As ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder
	Private imageList1 As System.Windows.Forms.ImageList
	Private imageList2 As System.Windows.Forms.ImageList
	Private imageList3 As System.Windows.Forms.ImageList
	Private WithEvents tsmiSaveAs As System.Windows.Forms.ToolStripMenuItem
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private splitContainer2 As System.Windows.Forms.SplitContainer
	Private WithEvents teSql As System.Windows.Forms.RichTextBox
	Private WithEvents teResultSql As System.Windows.Forms.RichTextBox
	Private WithEvents contextMenuStripForRichTextBox As System.Windows.Forms.ContextMenuStrip
	Private WithEvents tsmiParseQuery As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsbCut As System.Windows.Forms.ToolStripButton
	Private WithEvents tsbCopy As System.Windows.Forms.ToolStripButton
	Private WithEvents tsbPaste As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiUndo As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiRedo As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiCut As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiCopy As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiPaste As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiSelectAll As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private WithEvents labelSleepMode As System.Windows.Forms.Label
End Class
