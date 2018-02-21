Partial Class MainForm
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
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCut = New System.Windows.Forms.ToolStripButton()
        Me.tsbCopy = New System.Windows.Forms.ToolStripButton()
        Me.tsbPaste = New System.Windows.Forms.ToolStripButton()
        Me.toolStripExecuteUserQuery = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCascade = New System.Windows.Forms.ToolStripButton()
        Me.tsbTileHorizontally = New System.Windows.Forms.ToolStripButton()
        Me.tsbTileVertically = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEditMetadata = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAbout = New System.Windows.Forms.ToolStripButton()
        Me.toolStripPanel2 = New System.Windows.Forms.ToolStripPanel()
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.userQueriesView1 = New ActiveQueryBuilder.View.WinForms.UserQueries.UserQueriesView()
        Me.CaptionConnection = New System.Windows.Forms.Label()
        Me.DBView = New ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView()
        Me.toolStripPanel1.SuspendLayout
        Me.menuStrip1.SuspendLayout
        Me.toolStrip1.SuspendLayout
        Me.tableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
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
        Me.toolStripPanel1.Size = New System.Drawing.Size(845, 49)
        '
        'menuStrip1
        '
        Me.menuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem1, Me.editToolStripMenuItem, Me.tsmiQuery, Me.metadataToolStripMenuItem, Me.toolsToolStripMenuItem, Me.tsmiAbout})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(845, 24)
        Me.menuStrip1.TabIndex = 4
        Me.menuStrip1.Text = "Main Menu"
        '
        'fileToolStripMenuItem1
        '
        Me.fileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNew, Me.toolStripSeparator, Me.newQueryToolStripMenuItem1, Me.tsmiOpen, Me.tsmiSave, Me.toolStripSeparator1, Me.tsmiExit})
        Me.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1"
        Me.fileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem1.Text = "&File"
        '
        'tsmiNew
        '
        Me.tsmiNew.Image = CType(resources.GetObject("tsmiNew.Image"),System.Drawing.Image)
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
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.toolStripButtonNewQuery, Me.tsbOpen, Me.tsbSave, Me.toolStripSeparator2, Me.tsbCut, Me.tsbCopy, Me.tsbPaste, Me.toolStripExecuteUserQuery, Me.toolStripSeparator6, Me.tsbCascade, Me.tsbTileHorizontally, Me.tsbTileVertically, Me.toolStripSeparator7, Me.tsbEditMetadata, Me.toolStripSeparator13, Me.tsbAbout})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(845, 25)
        Me.toolStrip1.Stretch = true
        Me.toolStrip1.TabIndex = 5
        Me.toolStrip1.Text = "Main Toolbar"
        '
        'tsbNew
        '
        Me.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNew.Image = CType(resources.GetObject("tsbNew.Image"),System.Drawing.Image)
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
        Me.toolStripButtonNewQuery.Text = "Open new query window"
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
        'toolStripExecuteUserQuery
        '
        Me.toolStripExecuteUserQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripExecuteUserQuery.Enabled = false
        Me.toolStripExecuteUserQuery.Image = Global.FullFeaturedMdiDemo.Resources.run
        Me.toolStripExecuteUserQuery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.toolStripExecuteUserQuery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripExecuteUserQuery.Name = "toolStripExecuteUserQuery"
        Me.toolStripExecuteUserQuery.Size = New System.Drawing.Size(23, 22)
        Me.toolStripExecuteUserQuery.Text = "toolStripButton1"
        Me.toolStripExecuteUserQuery.ToolTipText = "Execute query"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsbCascade
        '
        Me.tsbCascade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCascade.Image = CType(resources.GetObject("tsbCascade.Image"),System.Drawing.Image)
        Me.tsbCascade.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCascade.Name = "tsbCascade"
        Me.tsbCascade.Size = New System.Drawing.Size(23, 22)
        Me.tsbCascade.Text = "Cascade"
        '
        'tsbTileHorizontally
        '
        Me.tsbTileHorizontally.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTileHorizontally.Image = CType(resources.GetObject("tsbTileHorizontally.Image"),System.Drawing.Image)
        Me.tsbTileHorizontally.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTileHorizontally.Name = "tsbTileHorizontally"
        Me.tsbTileHorizontally.Size = New System.Drawing.Size(23, 22)
        Me.tsbTileHorizontally.Text = "Tile Horzontally"
        '
        'tsbTileVertically
        '
        Me.tsbTileVertically.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTileVertically.Image = CType(resources.GetObject("tsbTileVertically.Image"),System.Drawing.Image)
        Me.tsbTileVertically.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTileVertically.Name = "tsbTileVertically"
        Me.tsbTileVertically.Size = New System.Drawing.Size(23, 22)
        Me.tsbTileVertically.Text = "Tile Vertically"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 25)
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
        Me.toolStripPanel2.Location = New System.Drawing.Point(0, 589)
        Me.toolStripPanel2.Name = "toolStripPanel2"
        Me.toolStripPanel2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.toolStripPanel2.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.toolStripPanel2.Size = New System.Drawing.Size(845, 0)
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
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.Controls.Add(Me.userQueriesView1, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.CaptionConnection, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.DBView, 0, 1)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 49)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 237!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(200, 540)
        Me.tableLayoutPanel1.TabIndex = 3
        '
        'userQueriesView1
        '
        Me.userQueriesView1.AllowDrop = true
        Me.userQueriesView1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.userQueriesView1.DisplaySaveButtons = false
        Me.userQueriesView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userQueriesView1.Location = New System.Drawing.Point(3, 306)
        Me.userQueriesView1.Name = "userQueriesView1"
        Me.userQueriesView1.QueryView = Nothing
        Me.userQueriesView1.Size = New System.Drawing.Size(194, 231)
        Me.userQueriesView1.SQLContext = Nothing
        Me.userQueriesView1.SQLQuery = Nothing
        Me.userQueriesView1.TabIndex = 7
        Me.userQueriesView1.Title = "Reusable Queries"
        '
        'CaptionConnection
        '
        Me.CaptionConnection.AutoSize = true
        Me.CaptionConnection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CaptionConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CaptionConnection.Location = New System.Drawing.Point(3, 3)
        Me.CaptionConnection.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.CaptionConnection.Name = "CaptionConnection"
        Me.CaptionConnection.Padding = New System.Windows.Forms.Padding(10, 5, 0, 5)
        Me.CaptionConnection.Size = New System.Drawing.Size(194, 23)
        Me.CaptionConnection.TabIndex = 0
        Me.CaptionConnection.Text = "< No connection > "
        '
        'DBView
        '
        Me.DBView.AllowRenameNodes = false
        Me.DBView.BackColor = System.Drawing.Color.White
        Me.DBView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBView.FilterImageIndex = 14
        Me.DBView.Location = New System.Drawing.Point(3, 29)
        Me.DBView.MaxToolTipWidth = 300
        Me.DBView.Name = "DBView"
        Me.DBView.QueryView = Nothing
        Me.DBView.Size = New System.Drawing.Size(194, 271)
        Me.DBView.SQLContext = Nothing
        Me.DBView.TabIndex = 1
        Me.DBView.ViewMode = ActiveQueryBuilder.View.DatabaseSchemaView.ViewMode.Tree
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 589)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.toolStripPanel2)
        Me.Controls.Add(Me.toolStripPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.IsMdiContainer = true
        Me.MainMenuStrip = Me.menuStrip1
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Active Query Builder for .NET WinForms Edition - Professional Full-featured demo "& _ 
    "(VB)"
        Me.toolStripPanel1.ResumeLayout(false)
        Me.toolStripPanel1.PerformLayout
        Me.menuStrip1.ResumeLayout(false)
        Me.menuStrip1.PerformLayout
        Me.toolStrip1.ResumeLayout(false)
        Me.toolStrip1.PerformLayout
        Me.tableLayoutPanel1.ResumeLayout(false)
        Me.tableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
	Private toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiLanguageDefault As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiLanguageAuto As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents languageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

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
	Private WithEvents tsmiSave As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiExit As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiUndo As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiRedo As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiCut As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiCopy As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiPaste As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiSelectAll As System.Windows.Forms.ToolStripMenuItem
	Private toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiAbout As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
	Private WithEvents tsbNew As System.Windows.Forms.ToolStripButton
	Private toolStripPanel2 As System.Windows.Forms.ToolStripPanel
	Private WithEvents tsbOpen As System.Windows.Forms.ToolStripButton
	Private WithEvents tsbSave As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsbCut As System.Windows.Forms.ToolStripButton
	Private WithEvents tsbCopy As System.Windows.Forms.ToolStripButton
	Private WithEvents tsbPaste As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsbCascade As System.Windows.Forms.ToolStripButton
	Private WithEvents tsbTileHorizontally As System.Windows.Forms.ToolStripButton
	Private WithEvents tsbTileVertically As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsbAbout As System.Windows.Forms.ToolStripButton
	Private WithEvents tsmiQuery As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiParseQuery As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiBuildQuery As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiRunQuery As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiQueryStatistics As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private metadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiRefreshMetadata As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiEditMetadata As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiClearMetadata As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiOfflineMode As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents tsmiLoadMetadataFromXML As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tsmiSaveMetadataToXML As System.Windows.Forms.ToolStripMenuItem
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private CaptionConnection As System.Windows.Forms.Label
	Private WithEvents addDerivedTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents addUnionSubqueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents copyUnionSubwueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents addObjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents queryPropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents propertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents newQueryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents toolStripButtonNewQuery As System.Windows.Forms.ToolStripButton
	Private DBView As ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView
	Private WithEvents tsbEditMetadata As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
	Private userQueriesView1 As ActiveQueryBuilder.View.WinForms.UserQueries.UserQueriesView
	Private WithEvents toolStripExecuteUserQuery As System.Windows.Forms.ToolStripButton
End Class

