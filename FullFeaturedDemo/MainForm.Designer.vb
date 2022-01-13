    Partial Public Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim LinkPainterAccess2 As ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess = New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
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
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.pageQueryBuilder = New System.Windows.Forms.TabPage()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.panelSleepMode = New System.Windows.Forms.Label()
        Me.toolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbQueryProperties = New System.Windows.Forms.ToolStripButton()
        Me.tsbAddObject = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAddDerivedTable = New System.Windows.Forms.ToolStripButton()
        Me.tsbAddUnionSubquery = New System.Windows.Forms.ToolStripButton()
        Me.tsbCopyUnionSubquery = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.errorBox1 = New Common.SqlErrorBox()
        Me.teSql = New System.Windows.Forms.RichTextBox()
        Me.pageQueryResult = New System.Windows.Forms.TabPage()
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.dataViewer = New DataViewerControl.DataViewer()
        Me.CBuilder = New ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder()
        Me.teResultSql = New System.Windows.Forms.RichTextBox()
        Me.contextMenuStripForRichTextBox = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditPredefinedConditionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        CType(Me.queryBuilder1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder1.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder1.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).BeginInit
        Me.toolStrip2.SuspendLayout
        Me.pageQueryResult.SuspendLayout
        CType(Me.splitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer2.Panel1.SuspendLayout
        Me.splitContainer2.Panel2.SuspendLayout
        Me.splitContainer2.SuspendLayout
        Me.SuspendLayout
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "bricks.ico")
        Me.imageList1.Images.SetKeyName(1, "database_go.ico")
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
        Me.tsmiNew.Image = Global.My.Resources.Resources.connect
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
        Me.newQueryToolStripMenuItem1.Image = Global.My.Resources.Resources.page_white
        Me.newQueryToolStripMenuItem1.Name = "newQueryToolStripMenuItem1"
        Me.newQueryToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.newQueryToolStripMenuItem1.Text = "New Query"
        '
        'tsmiOpen
        '
        Me.tsmiOpen.Image = Global.My.Resources.Resources.folder_page
        Me.tsmiOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiOpen.Name = "tsmiOpen"
        Me.tsmiOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O),System.Windows.Forms.Keys)
        Me.tsmiOpen.Size = New System.Drawing.Size(171, 22)
        Me.tsmiOpen.Text = "&Open"
        '
        'tsmiSave
        '
        Me.tsmiSave.Image = Global.My.Resources.Resources.disk
        Me.tsmiSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiSave.Name = "tsmiSave"
        Me.tsmiSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
        Me.tsmiSave.Size = New System.Drawing.Size(171, 22)
        Me.tsmiSave.Text = "&Save"
        '
        'tsmiSaveAs
        '
        Me.tsmiSaveAs.Image = Global.My.Resources.Resources.drive_disk
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
        Me.tsmiCut.Image = Global.My.Resources.Resources.cut
        Me.tsmiCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiCut.Name = "tsmiCut"
        Me.tsmiCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X),System.Windows.Forms.Keys)
        Me.tsmiCut.Size = New System.Drawing.Size(144, 22)
        Me.tsmiCut.Text = "Cu&t"
        '
        'tsmiCopy
        '
        Me.tsmiCopy.Image = Global.My.Resources.Resources.page_copy
        Me.tsmiCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmiCopy.Name = "tsmiCopy"
        Me.tsmiCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C),System.Windows.Forms.Keys)
        Me.tsmiCopy.Size = New System.Drawing.Size(144, 22)
        Me.tsmiCopy.Text = "&Copy"
        '
        'tsmiPaste
        '
        Me.tsmiPaste.Image = Global.My.Resources.Resources.page_paste
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
        Me.tsmiBuildQuery.Image = Global.My.Resources.Resources.bricks
        Me.tsmiBuildQuery.Name = "tsmiBuildQuery"
        Me.tsmiBuildQuery.ShortcutKeyDisplayString = ""
        Me.tsmiBuildQuery.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.tsmiBuildQuery.Size = New System.Drawing.Size(197, 22)
        Me.tsmiBuildQuery.Text = "Build Query"
        '
        'tsmiRunQuery
        '
        Me.tsmiRunQuery.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tsmiRunQuery.Image = Global.My.Resources.Resources.database_go
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
        Me.addObjectToolStripMenuItem.Image = Global.My.Resources.Resources.new_object
        Me.addObjectToolStripMenuItem.Name = "addObjectToolStripMenuItem"
        Me.addObjectToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.addObjectToolStripMenuItem.Text = "Add Object"
        '
        'addDerivedTableToolStripMenuItem
        '
        Me.addDerivedTableToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.addDerivedTableToolStripMenuItem.Image = Global.My.Resources.Resources.add_derived_table
        Me.addDerivedTableToolStripMenuItem.Name = "addDerivedTableToolStripMenuItem"
        Me.addDerivedTableToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.addDerivedTableToolStripMenuItem.Text = "Add Derived Table"
        '
        'addUnionSubqueryToolStripMenuItem
        '
        Me.addUnionSubqueryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.addUnionSubqueryToolStripMenuItem.Image = Global.My.Resources.Resources.add_union_subquery
        Me.addUnionSubqueryToolStripMenuItem.Name = "addUnionSubqueryToolStripMenuItem"
        Me.addUnionSubqueryToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.addUnionSubqueryToolStripMenuItem.Text = "Add Union Sub-Query"
        '
        'copyUnionSubwueryToolStripMenuItem
        '
        Me.copyUnionSubwueryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.copyUnionSubwueryToolStripMenuItem.Image = Global.My.Resources.Resources.copy_union_subquery
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
        Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.languageToolStripMenuItem, Me.propertiesToolStripMenuItem, Me.EditPredefinedConditionsToolStripMenuItem})
        Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
        Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.toolsToolStripMenuItem.Text = "&Options"
        '
        'languageToolStripMenuItem
        '
        Me.languageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiLanguageAuto, Me.tsmiLanguageDefault, Me.toolStripSeparator12})
        Me.languageToolStripMenuItem.Name = "languageToolStripMenuItem"
        Me.languageToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
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
        Me.propertiesToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
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
        Me.tsbNew.Image = Global.My.Resources.Resources.connect
        Me.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNew.Name = "tsbNew"
        Me.tsbNew.Size = New System.Drawing.Size(23, 22)
        Me.tsbNew.Text = "Establish new connection..."
        '
        'toolStripButtonNewQuery
        '
        Me.toolStripButtonNewQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButtonNewQuery.Image = Global.My.Resources.Resources.page_white
        Me.toolStripButtonNewQuery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButtonNewQuery.Name = "toolStripButtonNewQuery"
        Me.toolStripButtonNewQuery.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButtonNewQuery.Text = "New Query"
        '
        'tsbOpen
        '
        Me.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbOpen.Image = Global.My.Resources.Resources.folder_page
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(23, 22)
        Me.tsbOpen.Text = "Load query from file..."
        '
        'tsbSave
        '
        Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSave.Image = Global.My.Resources.Resources.disk
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(23, 22)
        Me.tsbSave.Text = "Save the current query"
        '
        'tsbSaveInFile
        '
        Me.tsbSaveInFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSaveInFile.Image = Global.My.Resources.Resources.drive_disk
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
        Me.tsbCut.Image = Global.My.Resources.Resources.cut
        Me.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCut.Name = "tsbCut"
        Me.tsbCut.Size = New System.Drawing.Size(23, 22)
        Me.tsbCut.Text = "Cut"
        '
        'tsbCopy
        '
        Me.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCopy.Image = Global.My.Resources.Resources.page_copy
        Me.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCopy.Name = "tsbCopy"
        Me.tsbCopy.Size = New System.Drawing.Size(23, 22)
        Me.tsbCopy.Text = "Copy"
        '
        'tsbPaste
        '
        Me.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPaste.Image = Global.My.Resources.Resources.page_paste
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
        Me.tsbEditMetadata.Image = Global.My.Resources.Resources.database_edit
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
        Me.tsbAbout.Image = Global.My.Resources.Resources.help
        Me.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAbout.Name = "tsbAbout"
        Me.tsbAbout.Size = New System.Drawing.Size(23, 22)
        Me.tsbAbout.Text = "About..."
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
        Me.toolStripButton2.Image = Global.My.Resources.Resources.page_white
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
        Me.splitContainer1.Panel2.Controls.Add(Me.errorBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.teSql)
        Me.splitContainer1.Size = New System.Drawing.Size(819, 503)
        Me.splitContainer1.SplitterDistance = 408
        Me.splitContainer1.TabIndex = 1
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.queryBuilder1)
        Me.panel1.Controls.Add(Me.panelSleepMode)
        Me.panel1.Controls.Add(Me.toolStrip2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(819, 408)
        Me.panel1.TabIndex = 0
        '
        'queryBuilder1
        '
        Me.queryBuilder1.AddObjectDialogOptions.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder1.AddObjectDialogOptions.Size = New System.Drawing.Size(430, 430)
        Me.queryBuilder1.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.queryBuilder1.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = false
        Me.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = false
        Me.queryBuilder1.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder1.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = System.Drawing.Color.Black
        Me.queryBuilder1.DesignPaneOptions.Background = System.Drawing.SystemColors.Window
        LinkPainterAccess2.LinkColor = System.Drawing.Color.Black
        LinkPainterAccess2.LinkColorFocused = System.Drawing.Color.Black
        LinkPainterAccess2.MarkColor = System.Drawing.SystemColors.Control
        LinkPainterAccess2.MarkColorFocused = System.Drawing.SystemColors.ControlDark
        LinkPainterAccess2.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder1.DesignPaneOptions.LinkPainterOptions = LinkPainterAccess2
        Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.queryBuilder1.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.queryBuilder1.Location = New System.Drawing.Point(0, 25)
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewDock = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 168
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = true
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = true
        Me.queryBuilder1.QueryColumnListOptions.Font = Nothing
        Me.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = false
        Me.queryBuilder1.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder1.QueryNavBarOptions.ActionButtonBackColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.ActionButtonBorderColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.ActiveSubQueryItemBackColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.ActiveSubQueryItemBorderColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.AddCteCircleColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.AddUnionSubQueryCircleColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.BreadcrumbsBackgroundColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green
        Me.queryBuilder1.QueryNavBarOptions.DisableQueryNavigationBarPopup = false
        Me.queryBuilder1.QueryNavBarOptions.DragIndicatorColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.DragIndicatorHoverColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.queryBuilder1.QueryNavBarOptions.ForeColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.GraphLineColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.GroupBackColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.GroupTextColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
        Me.queryBuilder1.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black
        Me.queryBuilder1.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue
        Me.queryBuilder1.QueryNavBarOptions.SubQueryItemBackColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.SubQueryItemBorderColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.SubQueryMarkerColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.SubQueryPopupBackColor = System.Drawing.Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.TextHoverColor = System.Drawing.Color.Empty
        Me.queryBuilder1.Size = New System.Drawing.Size(819, 344)
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
        Me.queryBuilder1.VisualOptions.DockPanelBackColor = System.Drawing.Color.Empty
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
        'panelSleepMode
        '
        Me.panelSleepMode.BackColor = System.Drawing.Color.Bisque
        Me.panelSleepMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelSleepMode.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelSleepMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.panelSleepMode.Location = New System.Drawing.Point(0, 369)
        Me.panelSleepMode.Name = "panelSleepMode"
        Me.panelSleepMode.Padding = New System.Windows.Forms.Padding(10)
        Me.panelSleepMode.Size = New System.Drawing.Size(819, 39)
        Me.panelSleepMode.TabIndex = 3
        Me.panelSleepMode.Text = "Unsupported SQL statement. Visual Query Builder has been disabled. Either type a "& _ 
    "SELECT statement or start building a query visually to turn this mode off."
        Me.panelSleepMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.panelSleepMode.Visible = false
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
        Me.tsbQueryProperties.Image = Global.My.Resources.Resources.query_properties
        Me.tsbQueryProperties.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQueryProperties.Name = "tsbQueryProperties"
        Me.tsbQueryProperties.Size = New System.Drawing.Size(23, 22)
        Me.tsbQueryProperties.Text = "Properties"
        '
        'tsbAddObject
        '
        Me.tsbAddObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddObject.Image = Global.My.Resources.Resources.new_object
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
        Me.tsbAddDerivedTable.Image = Global.My.Resources.Resources.add_derived_table
        Me.tsbAddDerivedTable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddDerivedTable.Name = "tsbAddDerivedTable"
        Me.tsbAddDerivedTable.Size = New System.Drawing.Size(23, 22)
        Me.tsbAddDerivedTable.Text = "Add Derived Table"
        '
        'tsbAddUnionSubquery
        '
        Me.tsbAddUnionSubquery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddUnionSubquery.Image = Global.My.Resources.Resources.add_union_subquery
        Me.tsbAddUnionSubquery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddUnionSubquery.Name = "tsbAddUnionSubquery"
        Me.tsbAddUnionSubquery.Size = New System.Drawing.Size(23, 22)
        Me.tsbAddUnionSubquery.Text = "New union sub-query"
        '
        'tsbCopyUnionSubquery
        '
        Me.tsbCopyUnionSubquery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCopyUnionSubquery.Image = Global.My.Resources.Resources.copy_union_subquery
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
        'errorBox1
        '
        Me.errorBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.errorBox1.AutoSize = true
        Me.errorBox1.BackColor = System.Drawing.Color.LightPink
        Me.errorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = false
        Me.errorBox1.Location = New System.Drawing.Point(499, 25)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.errorBox1.Size = New System.Drawing.Size(315, 61)
        Me.errorBox1.TabIndex = 1
        Me.errorBox1.Visible = false
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
        Me.splitContainer2.Panel1.Controls.Add(Me.dataViewer)
        Me.splitContainer2.Panel1.Controls.Add(Me.CBuilder)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.teResultSql)
        Me.splitContainer2.Size = New System.Drawing.Size(819, 503)
        Me.splitContainer2.SplitterDistance = 408
        Me.splitContainer2.TabIndex = 0
        '
        'dataViewer
        '
        Me.dataViewer.AutoSize = true
        Me.dataViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataViewer.Location = New System.Drawing.Point(0, 51)
        Me.dataViewer.Name = "dataViewer"
        Me.dataViewer.QueryTransformer = Nothing
        Me.dataViewer.Size = New System.Drawing.Size(819, 357)
        Me.dataViewer.SqlQuery = Nothing
        Me.dataViewer.TabIndex = 0
        '
        'CBuilder
        '
        Me.CBuilder.AutoSize = true
        Me.CBuilder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CBuilder.Dock = System.Windows.Forms.DockStyle.Top
        Me.CBuilder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
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
        'EditPredefinedConditionsToolStripMenuItem
        '
        Me.EditPredefinedConditionsToolStripMenuItem.Name = "EditPredefinedConditionsToolStripMenuItem"
        Me.EditPredefinedConditionsToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.EditPredefinedConditionsToolStripMenuItem.Text = "Edit Predefined Conditions"
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
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
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
        Me.splitContainer1.Panel2.PerformLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        CType(Me.queryBuilder1.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder1.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder1,System.ComponentModel.ISupportInitialize).EndInit
        Me.toolStrip2.ResumeLayout(false)
        Me.toolStrip2.PerformLayout
        Me.pageQueryResult.ResumeLayout(false)
        Me.splitContainer2.Panel1.ResumeLayout(false)
        Me.splitContainer2.Panel1.PerformLayout
        Me.splitContainer2.Panel2.ResumeLayout(false)
        CType(Me.splitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer2.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

        Private toolStripSeparator12 As ToolStripSeparator
        Private WithEvents tsmiLanguageDefault As ToolStripMenuItem
        Private WithEvents tsmiLanguageAuto As ToolStripMenuItem
        Private languageToolStripMenuItem As ToolStripMenuItem

        #End Region

        Private toolStripStatusLabel1 As ToolStripStatusLabel
        Private fileToolStripMenuItem As ToolStripMenuItem
        Private toolStripButton2 As ToolStripButton
        Private toolStripButton3 As ToolStripButton
        Private toolStripButton4 As ToolStripButton
        Private BottomToolStripPanel As ToolStripPanel
        Private TopToolStripPanel As ToolStripPanel
        Private RightToolStripPanel As ToolStripPanel
        Private LeftToolStripPanel As ToolStripPanel
        Private ContentPanel As ToolStripContentPanel
        Private toolStripPanel1 As ToolStripPanel
        Private menuStrip1 As MenuStrip
        Private fileToolStripMenuItem1 As ToolStripMenuItem
        Private WithEvents tsmiNew As ToolStripMenuItem
        Private WithEvents tsmiOpen As ToolStripMenuItem
        Private toolStripSeparator As ToolStripSeparator
        Private WithEvents tsmiSave As ToolStripMenuItem
        Private toolStripSeparator1 As ToolStripSeparator
        Private WithEvents tsmiExit As ToolStripMenuItem
        Private toolsToolStripMenuItem As ToolStripMenuItem
        Private WithEvents tsmiAbout As ToolStripMenuItem
        Private toolStrip1 As ToolStrip
        Private WithEvents tsbNew As ToolStripButton
        Private toolStripPanel2 As ToolStripPanel
        Private WithEvents tsbOpen As ToolStripButton
        Private WithEvents tsbSave As ToolStripButton
        Private toolStripSeparator2 As ToolStripSeparator
        Private WithEvents tsbAbout As ToolStripButton
        Private tsmiQuery As ToolStripMenuItem
        Private WithEvents tsmiBuildQuery As ToolStripMenuItem
        Private WithEvents tsmiRunQuery As ToolStripMenuItem
        Private toolStripSeparator9 As ToolStripSeparator
        Private WithEvents tsmiQueryStatistics As ToolStripMenuItem
        Private openFileDialog1 As OpenFileDialog
        Private saveFileDialog1 As SaveFileDialog
        Private metadataToolStripMenuItem As ToolStripMenuItem
        Private WithEvents tsmiRefreshMetadata As ToolStripMenuItem
        Private WithEvents tsmiEditMetadata As ToolStripMenuItem
        Private WithEvents tsmiClearMetadata As ToolStripMenuItem
        Private toolStripSeparator10 As ToolStripSeparator
        Private WithEvents tsmiOfflineMode As ToolStripMenuItem
        Private toolStripSeparator11 As ToolStripSeparator
        Private WithEvents tsmiLoadMetadataFromXML As ToolStripMenuItem
        Private WithEvents tsmiSaveMetadataToXML As ToolStripMenuItem
        Private WithEvents addDerivedTableToolStripMenuItem As ToolStripMenuItem
        Private WithEvents addUnionSubqueryToolStripMenuItem As ToolStripMenuItem
        Private WithEvents copyUnionSubwueryToolStripMenuItem As ToolStripMenuItem
        Private WithEvents addObjectToolStripMenuItem As ToolStripMenuItem
        Private toolStripSeparator5 As ToolStripSeparator
        Private WithEvents queryPropertiesToolStripMenuItem As ToolStripMenuItem
        Private WithEvents propertiesToolStripMenuItem As ToolStripMenuItem
        Private WithEvents newQueryToolStripMenuItem1 As ToolStripMenuItem
        Private WithEvents toolStripButtonNewQuery As ToolStripButton
        Private WithEvents tsbEditMetadata As ToolStripButton
        Private toolStripSeparator13 As ToolStripSeparator
        Private WithEvents tabControl1 As TabControl
        Private pageQueryBuilder As TabPage
        Private panel1 As Panel
        Private toolStrip2 As ToolStrip
        Private WithEvents tsbQueryProperties As ToolStripButton
        Private WithEvents tsbAddObject As ToolStripButton
        Private toolStripSeparator14 As ToolStripSeparator
        Private WithEvents tsbAddDerivedTable As ToolStripButton
        Private WithEvents tsbAddUnionSubquery As ToolStripButton
        Private WithEvents tsbCopyUnionSubquery As ToolStripButton
        Private toolStripSeparator15 As ToolStripSeparator
        Private WithEvents tsbSaveInFile As ToolStripButton
        Private pageQueryResult As TabPage
        Private dataViewer As DataViewerControl.DataViewer
        Private CBuilder As ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder
        Private imageList1 As ImageList
        Private WithEvents tsmiSaveAs As ToolStripMenuItem
        Private splitContainer1 As SplitContainer
        Private splitContainer2 As SplitContainer
        Private WithEvents teSql As RichTextBox
        Private teResultSql As RichTextBox
        Private WithEvents contextMenuStripForRichTextBox As ContextMenuStrip
        Private WithEvents tsmiParseQuery As ToolStripMenuItem
        Private toolStripSeparator8 As ToolStripSeparator
        Private WithEvents tsbCut As ToolStripButton
        Private WithEvents tsbCopy As ToolStripButton
        Private WithEvents tsbPaste As ToolStripButton
        Private toolStripSeparator6 As ToolStripSeparator
        Private editToolStripMenuItem As ToolStripMenuItem
        Private WithEvents tsmiUndo As ToolStripMenuItem
        Private WithEvents tsmiRedo As ToolStripMenuItem
        Private toolStripSeparator3 As ToolStripSeparator
        Private WithEvents tsmiCut As ToolStripMenuItem
        Private WithEvents tsmiCopy As ToolStripMenuItem
        Private WithEvents tsmiPaste As ToolStripMenuItem
        Private toolStripSeparator4 As ToolStripSeparator
        Private WithEvents tsmiSelectAll As ToolStripMenuItem
        Private panelSleepMode As Label
        Private WithEvents queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
        Private WithEvents errorBox1 As Common.SqlErrorBox
    Friend WithEvents EditPredefinedConditionsToolStripMenuItem As ToolStripMenuItem
End Class
