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
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
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
		Me.CaptionConnection = New System.Windows.Forms.Label()
		Me.userQueriesView1 = New ActiveQueryBuilder.View.WinForms.UserQueries.UserQueriesView()
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.DBView = New ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView()
		Me.toolStripPanel1.SuspendLayout()
		Me.menuStrip1.SuspendLayout()
		Me.toolStrip1.SuspendLayout()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' toolStripStatusLabel1
		' 
		Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
		Me.toolStripStatusLabel1.Size = New System.Drawing.Size(109, 17)
		Me.toolStripStatusLabel1.Text = "toolStripStatusLabel1"
		' 
		' fileToolStripMenuItem
		' 
		Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
		Me.fileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
		Me.fileToolStripMenuItem.Text = "File"
		' 
		' BottomToolStripPanel
		' 
		Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
		Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
		Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
		Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
		' 
		' TopToolStripPanel
		' 
		Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
		Me.TopToolStripPanel.Name = "TopToolStripPanel"
		Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
		Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
		' 
		' RightToolStripPanel
		' 
		Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
		Me.RightToolStripPanel.Name = "RightToolStripPanel"
		Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
		Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
		' 
		' LeftToolStripPanel
		' 
		Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
		Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
		Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
		Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
		' 
		' ContentPanel
		' 
		Me.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.ContentPanel.Size = New System.Drawing.Size(792, 423)
		' 
		' toolStripPanel1
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
		' menuStrip1
		' 
		Me.menuStrip1.Dock = System.Windows.Forms.DockStyle.None
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem1, Me.editToolStripMenuItem, Me.tsmiQuery, Me.metadataToolStripMenuItem, Me.toolsToolStripMenuItem, Me.tsmiAbout})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(845, 24)
		Me.menuStrip1.TabIndex = 4
		Me.menuStrip1.Text = "Main Menu"
		' 
		' fileToolStripMenuItem1
		' 
		Me.fileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNew, Me.toolStripSeparator, Me.newQueryToolStripMenuItem1, Me.tsmiOpen, Me.tsmiSave, Me.toolStripSeparator1, _
			Me.tsmiExit})
		Me.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1"
		Me.fileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
		Me.fileToolStripMenuItem1.Text = "&File"
		' 
		' tsmiNew
		' 
		Me.tsmiNew.Image = Global.FullFeaturedMdiDemo.Resources.connect
		Me.tsmiNew.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsmiNew.Name = "tsmiNew"
		Me.tsmiNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.tsmiNew.Size = New System.Drawing.Size(171, 22)
		Me.tsmiNew.Text = "&Connect..."
		AddHandler Me.tsmiNew.Click, New System.EventHandler(AddressOf Me.tsmiNew_Click)
		' 
		' toolStripSeparator
		' 
		Me.toolStripSeparator.Name = "toolStripSeparator"
		Me.toolStripSeparator.Size = New System.Drawing.Size(168, 6)
		' 
		' newQueryToolStripMenuItem1
		' 
	    Me.newQueryToolStripMenuItem1.Image = Global.FullFeaturedMdiDemo.Resources.page_white
		Me.newQueryToolStripMenuItem1.Name = "newQueryToolStripMenuItem1"
		Me.newQueryToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
		Me.newQueryToolStripMenuItem1.Text = "New Query"
		AddHandler Me.newQueryToolStripMenuItem1.Click, New System.EventHandler(AddressOf Me.newQueryToolStripMenuItem_Click)
		' 
		' tsmiOpen
		' 
	    Me.tsmiOpen.Image = Global.FullFeaturedMdiDemo.Resources.folder_page
		Me.tsmiOpen.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsmiOpen.Name = "tsmiOpen"
		Me.tsmiOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.tsmiOpen.Size = New System.Drawing.Size(171, 22)
		Me.tsmiOpen.Text = "&Open"
		AddHandler Me.tsmiOpen.Click, New System.EventHandler(AddressOf Me.tsmiOpen_Click)
		' 
		' tsmiSave
		' 
	    Me.tsmiSave.Image = Global.FullFeaturedMdiDemo.Resources.disk
		Me.tsmiSave.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsmiSave.Name = "tsmiSave"
		Me.tsmiSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.tsmiSave.Size = New System.Drawing.Size(171, 22)
		Me.tsmiSave.Text = "&Save"
		AddHandler Me.tsmiSave.Click, New System.EventHandler(AddressOf Me.tsmiSave_Click)
		' 
		' toolStripSeparator1
		' 
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(168, 6)
		' 
		' tsmiExit
		' 
		Me.tsmiExit.Name = "tsmiExit"
		Me.tsmiExit.Size = New System.Drawing.Size(171, 22)
		Me.tsmiExit.Text = "E&xit"
		AddHandler Me.tsmiExit.Click, New System.EventHandler(AddressOf Me.tsmiExit_Click)
		' 
		' editToolStripMenuItem
		' 
		Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiUndo, Me.tsmiRedo, Me.toolStripSeparator3, Me.tsmiCut, Me.tsmiCopy, Me.tsmiPaste, _
			Me.toolStripSeparator4, Me.tsmiSelectAll})
		Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
		Me.editToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
		Me.editToolStripMenuItem.Text = "&Edit"
		' 
		' tsmiUndo
		' 
		Me.tsmiUndo.Name = "tsmiUndo"
		Me.tsmiUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
		Me.tsmiUndo.Size = New System.Drawing.Size(144, 22)
		Me.tsmiUndo.Text = "&Undo"
		AddHandler Me.tsmiUndo.Click, New System.EventHandler(AddressOf Me.tsmiUndo_Click)
		' 
		' tsmiRedo
		' 
		Me.tsmiRedo.Name = "tsmiRedo"
		Me.tsmiRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
		Me.tsmiRedo.Size = New System.Drawing.Size(144, 22)
		Me.tsmiRedo.Text = "&Redo"
		AddHandler Me.tsmiRedo.Click, New System.EventHandler(AddressOf Me.tsmiRedo_Click)
		' 
		' toolStripSeparator3
		' 
		Me.toolStripSeparator3.Name = "toolStripSeparator3"
		Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
		' 
		' tsmiCut
		' 
	    Me.tsmiCut.Image = Global.FullFeaturedMdiDemo.Resources.cut
		Me.tsmiCut.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsmiCut.Name = "tsmiCut"
		Me.tsmiCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
		Me.tsmiCut.Size = New System.Drawing.Size(144, 22)
		Me.tsmiCut.Text = "Cu&t"
		AddHandler Me.tsmiCut.Click, New System.EventHandler(AddressOf Me.tsmiCut_Click)
		' 
		' tsmiCopy
		' 
	    Me.tsmiCopy.Image = Global.FullFeaturedMdiDemo.Resources.page_copy
		Me.tsmiCopy.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsmiCopy.Name = "tsmiCopy"
		Me.tsmiCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
		Me.tsmiCopy.Size = New System.Drawing.Size(144, 22)
		Me.tsmiCopy.Text = "&Copy"
		AddHandler Me.tsmiCopy.Click, New System.EventHandler(AddressOf Me.tsmiCopy_Click)
		' 
		' tsmiPaste
		' 
	    Me.tsmiPaste.Image = Global.FullFeaturedMdiDemo.Resources.page_paste
		Me.tsmiPaste.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsmiPaste.Name = "tsmiPaste"
		Me.tsmiPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
		Me.tsmiPaste.Size = New System.Drawing.Size(144, 22)
		Me.tsmiPaste.Text = "&Paste"
		AddHandler Me.tsmiPaste.Click, New System.EventHandler(AddressOf Me.tsmiPaste_Click)
		' 
		' toolStripSeparator4
		' 
		Me.toolStripSeparator4.Name = "toolStripSeparator4"
		Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
		' 
		' tsmiSelectAll
		' 
		Me.tsmiSelectAll.Name = "tsmiSelectAll"
		Me.tsmiSelectAll.Size = New System.Drawing.Size(144, 22)
		Me.tsmiSelectAll.Text = "Select &All"
		AddHandler Me.tsmiSelectAll.Click, New System.EventHandler(AddressOf Me.tsmiSelectAll_Click)
		' 
		' tsmiQuery
		' 
		Me.tsmiQuery.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiParseQuery, Me.toolStripSeparator8, Me.tsmiBuildQuery, Me.tsmiRunQuery, Me.toolStripSeparator9, Me.addObjectToolStripMenuItem, _
			Me.addDerivedTableToolStripMenuItem, Me.addUnionSubqueryToolStripMenuItem, Me.copyUnionSubwueryToolStripMenuItem, Me.toolStripSeparator5, Me.tsmiQueryStatistics, Me.queryPropertiesToolStripMenuItem})
		Me.tsmiQuery.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.tsmiQuery.Name = "tsmiQuery"
		Me.tsmiQuery.Size = New System.Drawing.Size(53, 20)
		Me.tsmiQuery.Text = "&Query"
		' 
		' tsmiParseQuery
		' 
		Me.tsmiParseQuery.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.tsmiParseQuery.Name = "tsmiParseQuery"
		Me.tsmiParseQuery.ShortcutKeyDisplayString = ""
		Me.tsmiParseQuery.ShortcutKeys = System.Windows.Forms.Keys.F5
		Me.tsmiParseQuery.Size = New System.Drawing.Size(197, 22)
		Me.tsmiParseQuery.Text = "Parse Query"
		AddHandler Me.tsmiParseQuery.Click, New System.EventHandler(AddressOf Me.tsmiParseQuery_Click)
		' 
		' toolStripSeparator8
		' 
		Me.toolStripSeparator8.Name = "toolStripSeparator8"
		Me.toolStripSeparator8.Size = New System.Drawing.Size(194, 6)
		' 
		' tsmiBuildQuery
		' 
		Me.tsmiBuildQuery.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
	    Me.tsmiBuildQuery.Image = Global.FullFeaturedMdiDemo.Resources.bricks
		Me.tsmiBuildQuery.Name = "tsmiBuildQuery"
		Me.tsmiBuildQuery.ShortcutKeyDisplayString = ""
		Me.tsmiBuildQuery.ShortcutKeys = System.Windows.Forms.Keys.F9
		Me.tsmiBuildQuery.Size = New System.Drawing.Size(197, 22)
		Me.tsmiBuildQuery.Text = "Build Query"
		AddHandler Me.tsmiBuildQuery.Click, New System.EventHandler(AddressOf Me.tsmiBuildQuery_Click)
		' 
		' tsmiRunQuery
		' 
		Me.tsmiRunQuery.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
	    Me.tsmiRunQuery.Image = Global.FullFeaturedMdiDemo.Resources.database_go
		Me.tsmiRunQuery.Name = "tsmiRunQuery"
		Me.tsmiRunQuery.ShortcutKeyDisplayString = ""
		Me.tsmiRunQuery.ShortcutKeys = System.Windows.Forms.Keys.F10
		Me.tsmiRunQuery.Size = New System.Drawing.Size(197, 22)
		Me.tsmiRunQuery.Text = "Run Query"
		AddHandler Me.tsmiRunQuery.Click, New System.EventHandler(AddressOf Me.tsmiRunQuery_Click)
		' 
		' toolStripSeparator9
		' 
		Me.toolStripSeparator9.Name = "toolStripSeparator9"
		Me.toolStripSeparator9.Size = New System.Drawing.Size(194, 6)
		' 
		' addObjectToolStripMenuItem
		' 
		Me.addObjectToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
	    Me.addObjectToolStripMenuItem.Image = Global.FullFeaturedMdiDemo.Resources.new_object
		Me.addObjectToolStripMenuItem.Name = "addObjectToolStripMenuItem"
		Me.addObjectToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
		Me.addObjectToolStripMenuItem.Text = "Add Object"
		AddHandler Me.addObjectToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.addObjectToolStripMenuItem_Click)
		' 
		' addDerivedTableToolStripMenuItem
		' 
		Me.addDerivedTableToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
	    Me.addDerivedTableToolStripMenuItem.Image = Global.FullFeaturedMdiDemo.Resources.add_derived_table
		Me.addDerivedTableToolStripMenuItem.Name = "addDerivedTableToolStripMenuItem"
		Me.addDerivedTableToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
		Me.addDerivedTableToolStripMenuItem.Text = "Add Derived Table"
		AddHandler Me.addDerivedTableToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.addDerivedTableToolStripMenuItem_Click)
		' 
		' addUnionSubqueryToolStripMenuItem
		' 
		Me.addUnionSubqueryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
	    Me.addUnionSubqueryToolStripMenuItem.Image = Global.FullFeaturedMdiDemo.Resources.add_union_subquery
		Me.addUnionSubqueryToolStripMenuItem.Name = "addUnionSubqueryToolStripMenuItem"
		Me.addUnionSubqueryToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
		Me.addUnionSubqueryToolStripMenuItem.Text = "Add Union Sub-Query"
		AddHandler Me.addUnionSubqueryToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.addUnionSubqueryToolStripMenuItem_Click)
		' 
		' copyUnionSubwueryToolStripMenuItem
		' 
		Me.copyUnionSubwueryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
	    Me.copyUnionSubwueryToolStripMenuItem.Image = Global.FullFeaturedMdiDemo.Resources.copy_union_subquery
		Me.copyUnionSubwueryToolStripMenuItem.Name = "copyUnionSubwueryToolStripMenuItem"
		Me.copyUnionSubwueryToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
		Me.copyUnionSubwueryToolStripMenuItem.Text = "Copy Union Sub-Query"
		AddHandler Me.copyUnionSubwueryToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.copyUnionSubwueryToolStripMenuItem_Click)
		' 
		' toolStripSeparator5
		' 
		Me.toolStripSeparator5.Name = "toolStripSeparator5"
		Me.toolStripSeparator5.Size = New System.Drawing.Size(194, 6)
		' 
		' tsmiQueryStatistics
		' 
		Me.tsmiQueryStatistics.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.tsmiQueryStatistics.Name = "tsmiQueryStatistics"
		Me.tsmiQueryStatistics.ShortcutKeyDisplayString = ""
		Me.tsmiQueryStatistics.ShortcutKeys = System.Windows.Forms.Keys.F7
		Me.tsmiQueryStatistics.Size = New System.Drawing.Size(197, 22)
		Me.tsmiQueryStatistics.Text = "Query Statistics"
		AddHandler Me.tsmiQueryStatistics.Click, New System.EventHandler(AddressOf Me.tsmiQueryStatistics_Click)
		' 
		' queryPropertiesToolStripMenuItem
		' 
		Me.queryPropertiesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.queryPropertiesToolStripMenuItem.Name = "queryPropertiesToolStripMenuItem"
		Me.queryPropertiesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
		Me.queryPropertiesToolStripMenuItem.Text = "Query Properties"
		AddHandler Me.queryPropertiesToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.queryPropertiesToolStripMenuItem_Click)
		' 
		' metadataToolStripMenuItem
		' 
		Me.metadataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiOfflineMode, Me.toolStripSeparator11, Me.tsmiRefreshMetadata, Me.tsmiEditMetadata, Me.tsmiClearMetadata, Me.toolStripSeparator10, _
			Me.tsmiLoadMetadataFromXML, Me.tsmiSaveMetadataToXML})
		Me.metadataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.metadataToolStripMenuItem.Name = "metadataToolStripMenuItem"
		Me.metadataToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
		Me.metadataToolStripMenuItem.Text = "Metadata"
		' 
		' tsmiOfflineMode
		' 
		Me.tsmiOfflineMode.Font = New System.Drawing.Font("Segoe UI", 9F)
		Me.tsmiOfflineMode.Name = "tsmiOfflineMode"
		Me.tsmiOfflineMode.Size = New System.Drawing.Size(218, 22)
		Me.tsmiOfflineMode.Text = "Offline Mode"
		AddHandler Me.tsmiOfflineMode.Click, New System.EventHandler(AddressOf Me.tsmiOfflineMode_Click)
		' 
		' toolStripSeparator11
		' 
		Me.toolStripSeparator11.Name = "toolStripSeparator11"
		Me.toolStripSeparator11.Size = New System.Drawing.Size(215, 6)
		' 
		' tsmiRefreshMetadata
		' 
		Me.tsmiRefreshMetadata.Font = New System.Drawing.Font("Segoe UI", 9F)
		Me.tsmiRefreshMetadata.Name = "tsmiRefreshMetadata"
		Me.tsmiRefreshMetadata.Size = New System.Drawing.Size(218, 22)
		Me.tsmiRefreshMetadata.Text = "Refresh Metadata"
		AddHandler Me.tsmiRefreshMetadata.Click, New System.EventHandler(AddressOf Me.tsmiRefreshMetadata_Click)
		' 
		' tsmiEditMetadata
		' 
		Me.tsmiEditMetadata.Font = New System.Drawing.Font("Segoe UI", 9F)
		Me.tsmiEditMetadata.Name = "tsmiEditMetadata"
		Me.tsmiEditMetadata.Size = New System.Drawing.Size(218, 22)
		Me.tsmiEditMetadata.Text = "Edit Metadata"
		AddHandler Me.tsmiEditMetadata.Click, New System.EventHandler(AddressOf Me.tsmiEditMetadata_Click)
		' 
		' tsmiClearMetadata
		' 
		Me.tsmiClearMetadata.Font = New System.Drawing.Font("Segoe UI", 9F)
		Me.tsmiClearMetadata.Name = "tsmiClearMetadata"
		Me.tsmiClearMetadata.Size = New System.Drawing.Size(218, 22)
		Me.tsmiClearMetadata.Text = "Clear Metadata"
		AddHandler Me.tsmiClearMetadata.Click, New System.EventHandler(AddressOf Me.tsmiClearMetadata_Click)
		' 
		' toolStripSeparator10
		' 
		Me.toolStripSeparator10.Name = "toolStripSeparator10"
		Me.toolStripSeparator10.Size = New System.Drawing.Size(215, 6)
		' 
		' tsmiLoadMetadataFromXML
		' 
		Me.tsmiLoadMetadataFromXML.Font = New System.Drawing.Font("Segoe UI", 9F)
		Me.tsmiLoadMetadataFromXML.Name = "tsmiLoadMetadataFromXML"
		Me.tsmiLoadMetadataFromXML.Size = New System.Drawing.Size(218, 22)
		Me.tsmiLoadMetadataFromXML.Text = "Load Metadata from XML..."
		AddHandler Me.tsmiLoadMetadataFromXML.Click, New System.EventHandler(AddressOf Me.tsmiLoadMetadataFromXML_Click)
		' 
		' tsmiSaveMetadataToXML
		' 
		Me.tsmiSaveMetadataToXML.Font = New System.Drawing.Font("Segoe UI", 9F)
		Me.tsmiSaveMetadataToXML.Name = "tsmiSaveMetadataToXML"
		Me.tsmiSaveMetadataToXML.Size = New System.Drawing.Size(218, 22)
		Me.tsmiSaveMetadataToXML.Text = "Save Metadata to XML..."
		AddHandler Me.tsmiSaveMetadataToXML.Click, New System.EventHandler(AddressOf Me.tsmiSaveMetadataToXML_Click)
		' 
		' toolsToolStripMenuItem
		' 
		Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.languageToolStripMenuItem, Me.propertiesToolStripMenuItem})
		Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
		Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
		Me.toolsToolStripMenuItem.Text = "&Options"
		' 
		' languageToolStripMenuItem
		' 
		Me.languageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiLanguageAuto, Me.tsmiLanguageDefault, Me.toolStripSeparator12})
		Me.languageToolStripMenuItem.Name = "languageToolStripMenuItem"
		Me.languageToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
		Me.languageToolStripMenuItem.Text = "Language"
		' 
		' tsmiLanguageAuto
		' 
		Me.tsmiLanguageAuto.Name = "tsmiLanguageAuto"
		Me.tsmiLanguageAuto.Size = New System.Drawing.Size(161, 22)
		Me.tsmiLanguageAuto.Text = "Auto"
		AddHandler Me.tsmiLanguageAuto.Click, New System.EventHandler(AddressOf Me.tsmiLanguageAuto_Click)
		' 
		' tsmiLanguageDefault
		' 
		Me.tsmiLanguageDefault.Name = "tsmiLanguageDefault"
		Me.tsmiLanguageDefault.Size = New System.Drawing.Size(161, 22)
		Me.tsmiLanguageDefault.Text = "Default (English)"
		AddHandler Me.tsmiLanguageDefault.Click, New System.EventHandler(AddressOf Me.tsmiLanguageDefault_Click)
		' 
		' toolStripSeparator12
		' 
		Me.toolStripSeparator12.Name = "toolStripSeparator12"
		Me.toolStripSeparator12.Size = New System.Drawing.Size(158, 6)
		' 
		' propertiesToolStripMenuItem
		' 
		Me.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem"
		Me.propertiesToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
		Me.propertiesToolStripMenuItem.Text = "Properties"
		AddHandler Me.propertiesToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.propertiesToolStripMenuItem_Click)
		' 
		' tsmiAbout
		' 
		Me.tsmiAbout.Name = "tsmiAbout"
		Me.tsmiAbout.Size = New System.Drawing.Size(61, 20)
		Me.tsmiAbout.Text = "&About..."
		AddHandler Me.tsmiAbout.Click, New System.EventHandler(AddressOf Me.tsmiAbout_Click)
		' 
		' toolStrip1
		' 
		Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
		Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.toolStripButtonNewQuery, Me.tsbOpen, Me.tsbSave, Me.toolStripSeparator2, Me.tsbCut, _
			Me.tsbCopy, Me.tsbPaste, Me.toolStripExecuteUserQuery, Me.toolStripSeparator6, Me.tsbCascade, Me.tsbTileHorizontally, _
			Me.tsbTileVertically, Me.toolStripSeparator7, Me.tsbEditMetadata, Me.toolStripSeparator13, Me.tsbAbout})
		Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
		Me.toolStrip1.Name = "toolStrip1"
		Me.toolStrip1.Size = New System.Drawing.Size(845, 25)
		Me.toolStrip1.Stretch = True
		Me.toolStrip1.TabIndex = 5
		Me.toolStrip1.Text = "Main Toolbar"
		' 
		' tsbNew
		' 
		Me.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.tsbNew.Image =  Global.FullFeaturedMdiDemo.Resources.connect
		Me.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbNew.Name = "tsbNew"
		Me.tsbNew.Size = New System.Drawing.Size(23, 22)
		Me.tsbNew.Text = "Establish new connection..."
		AddHandler Me.tsbNew.Click, New System.EventHandler(AddressOf Me.tsbNew_Click)
		' 
		' toolStripButtonNewQuery
		' 
		Me.toolStripButtonNewQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.toolStripButtonNewQuery.Image = Global.FullFeaturedMdiDemo.Resources.page_white
		Me.toolStripButtonNewQuery.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripButtonNewQuery.Name = "toolStripButtonNewQuery"
		Me.toolStripButtonNewQuery.Size = New System.Drawing.Size(23, 22)
		Me.toolStripButtonNewQuery.Text = "Open new query window"
		AddHandler Me.toolStripButtonNewQuery.Click, New System.EventHandler(AddressOf Me.newQueryToolStripMenuItem_Click)
		' 
		' tsbOpen
		' 
		Me.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.tsbOpen.Image = Global.FullFeaturedMdiDemo.Resources.folder_page
		Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbOpen.Name = "tsbOpen"
		Me.tsbOpen.Size = New System.Drawing.Size(23, 22)
		Me.tsbOpen.Text = "Load query from file..."
		AddHandler Me.tsbOpen.Click, New System.EventHandler(AddressOf Me.tsbOpen_Click)
		' 
		' tsbSave
		' 
		Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.tsbSave.Image = Global.FullFeaturedMdiDemo.Resources.disk
		Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbSave.Name = "tsbSave"
		Me.tsbSave.Size = New System.Drawing.Size(23, 22)
		Me.tsbSave.Text = "Save the current query"
		AddHandler Me.tsbSave.Click, New System.EventHandler(AddressOf Me.tsbSave_Click)
		' 
		' toolStripSeparator2
		' 
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		' 
		' tsbCut
		' 
		Me.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.tsbCut.Image = Global.FullFeaturedMdiDemo.Resources.cut
		Me.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbCut.Name = "tsbCut"
		Me.tsbCut.Size = New System.Drawing.Size(23, 22)
		Me.tsbCut.Text = "Cut"
		AddHandler Me.tsbCut.Click, New System.EventHandler(AddressOf Me.tsbCut_Click)
		' 
		' tsbCopy
		' 
		Me.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.tsbCopy.Image = Global.FullFeaturedMdiDemo.Resources.page_copy
		Me.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbCopy.Name = "tsbCopy"
		Me.tsbCopy.Size = New System.Drawing.Size(23, 22)
		Me.tsbCopy.Text = "Copy"
		AddHandler Me.tsbCopy.Click, New System.EventHandler(AddressOf Me.tsbCopy_Click)
		' 
		' tsbPaste
		' 
		Me.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.tsbPaste.Image = Global.FullFeaturedMdiDemo.Resources.page_paste
		Me.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbPaste.Name = "tsbPaste"
		Me.tsbPaste.Size = New System.Drawing.Size(23, 22)
		Me.tsbPaste.Text = "Paste"
		AddHandler Me.tsbPaste.Click, New System.EventHandler(AddressOf Me.tsbPaste_Click)
		' 
		' toolStripExecuteUserQuery
		' 
		Me.toolStripExecuteUserQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.toolStripExecuteUserQuery.Enabled = False
	    Me.toolStripExecuteUserQuery.Image = Global.FullFeaturedMdiDemo.Resources.run
		Me.toolStripExecuteUserQuery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.toolStripExecuteUserQuery.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripExecuteUserQuery.Name = "toolStripExecuteUserQuery"
		Me.toolStripExecuteUserQuery.Size = New System.Drawing.Size(23, 22)
		Me.toolStripExecuteUserQuery.Text = "toolStripButton1"
		Me.toolStripExecuteUserQuery.ToolTipText = "Execute query"
		AddHandler Me.toolStripExecuteUserQuery.Click, New System.EventHandler(AddressOf Me.toolStripExecuteUserQuery_Click)
		' 
		' toolStripSeparator6
		' 
		Me.toolStripSeparator6.Name = "toolStripSeparator6"
		Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
		' 
		' tsbCascade
		' 
		Me.tsbCascade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.tsbCascade.Image = Global.FullFeaturedMdiDemo.Resources.application_cascade
		Me.tsbCascade.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbCascade.Name = "tsbCascade"
		Me.tsbCascade.Size = New System.Drawing.Size(23, 22)
		Me.tsbCascade.Text = "Cascade"
		AddHandler Me.tsbCascade.Click, New System.EventHandler(AddressOf Me.tsbCascade_Click)
		' 
		' tsbTileHorizontally
		' 
		Me.tsbTileHorizontally.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.tsbTileHorizontally.Image =Global.FullFeaturedMdiDemo. Resources.application_tile_horizontal
		Me.tsbTileHorizontally.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbTileHorizontally.Name = "tsbTileHorizontally"
		Me.tsbTileHorizontally.Size = New System.Drawing.Size(23, 22)
		Me.tsbTileHorizontally.Text = "Tile Horzontally"
		AddHandler Me.tsbTileHorizontally.Click, New System.EventHandler(AddressOf Me.tsbTileHorizontally_Click)
		' 
		' tsbTileVertically
		' 
		Me.tsbTileVertically.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.tsbTileVertically.Image = Global.FullFeaturedMdiDemo.Resources.application_tile_vertical
		Me.tsbTileVertically.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbTileVertically.Name = "tsbTileVertically"
		Me.tsbTileVertically.Size = New System.Drawing.Size(23, 22)
		Me.tsbTileVertically.Text = "Tile Vertically"
		AddHandler Me.tsbTileVertically.Click, New System.EventHandler(AddressOf Me.tsbTileVertically_Click)
		' 
		' toolStripSeparator7
		' 
		Me.toolStripSeparator7.Name = "toolStripSeparator7"
		Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 25)
		' 
		' tsbEditMetadata
		' 
		Me.tsbEditMetadata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.tsbEditMetadata.Image = Global.FullFeaturedMdiDemo.Resources.database_edit
		Me.tsbEditMetadata.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbEditMetadata.Name = "tsbEditMetadata"
		Me.tsbEditMetadata.Size = New System.Drawing.Size(23, 22)
		Me.tsbEditMetadata.Text = "Edit Metadata"
		AddHandler Me.tsbEditMetadata.Click, New System.EventHandler(AddressOf Me.tsbEditMetadata_Click)
		' 
		' toolStripSeparator13
		' 
		Me.toolStripSeparator13.Name = "toolStripSeparator13"
		Me.toolStripSeparator13.Size = New System.Drawing.Size(6, 25)
		' 
		' tsbAbout
		' 
		Me.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.tsbAbout.Image = Global.FullFeaturedMdiDemo.Resources.help
		Me.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbAbout.Name = "tsbAbout"
		Me.tsbAbout.Size = New System.Drawing.Size(23, 22)
		Me.tsbAbout.Text = "About..."
		AddHandler Me.tsbAbout.Click, New System.EventHandler(AddressOf Me.tsbAbout_Click)
		' 
		' toolStripPanel2
		' 
		Me.toolStripPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.toolStripPanel2.Location = New System.Drawing.Point(0, 589)
		Me.toolStripPanel2.Name = "toolStripPanel2"
		Me.toolStripPanel2.Orientation = System.Windows.Forms.Orientation.Horizontal
		Me.toolStripPanel2.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.toolStripPanel2.Size = New System.Drawing.Size(845, 0)
		' 
		' toolStripButton2
		' 
		Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
	    Me.toolStripButton2.Image = Global.FullFeaturedMdiDemo.Resources.page_white
		Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripButton2.Name = "toolStripButton2"
		Me.toolStripButton2.Size = New System.Drawing.Size(23, 22)
		Me.toolStripButton2.Text = "toolStripButton2"
		' 
		' toolStripButton3
		' 
		Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.toolStripButton3.Image = DirectCast(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
		Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripButton3.Name = "toolStripButton3"
		Me.toolStripButton3.Size = New System.Drawing.Size(23, 22)
		Me.toolStripButton3.Text = "toolStripButton3"
		' 
		' toolStripButton4
		' 
		Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.toolStripButton4.Image = DirectCast(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image)
		Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.toolStripButton4.Name = "toolStripButton4"
		Me.toolStripButton4.Size = New System.Drawing.Size(23, 22)
		Me.toolStripButton4.Text = "toolStripButton4"
		' 
		' openFileDialog1
		' 
		Me.openFileDialog1.DefaultExt = "sql"
		Me.openFileDialog1.Filter = "SQL query files (*.sql)|*.sql|All files|*.*"
		' 
		' saveFileDialog1
		' 
		Me.saveFileDialog1.DefaultExt = "sql"
		Me.saveFileDialog1.FileName = "query"
		Me.saveFileDialog1.Filter = "SQL query files (*.sql)|*.sql|All files|*.*"
		' 
		' CaptionConnection
		' 
		Me.CaptionConnection.AutoSize = True
		Me.CaptionConnection.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CaptionConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
		Me.CaptionConnection.Location = New System.Drawing.Point(3, 3)
		Me.CaptionConnection.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
		Me.CaptionConnection.Name = "CaptionConnection"
		Me.CaptionConnection.Padding = New System.Windows.Forms.Padding(10, 5, 0, 5)
		Me.CaptionConnection.Size = New System.Drawing.Size(194, 23)
		Me.CaptionConnection.TabIndex = 0
		Me.CaptionConnection.Text = "< No connection > "
		' 
		' userQueriesView1
		' 
		Me.userQueriesView1.AllowDrop = True
		Me.userQueriesView1.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.userQueriesView1.DisplaySaveButtons = False
		Me.userQueriesView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.userQueriesView1.FocusedItem = Nothing
		Me.userQueriesView1.Location = New System.Drawing.Point(3, 306)
		Me.userQueriesView1.Name = "userQueriesView1"
		Me.userQueriesView1.Size = New System.Drawing.Size(194, 231)
		Me.userQueriesView1.TabIndex = 7
		Me.userQueriesView1.Title = "Reusable Queries"
		AddHandler Me.userQueriesView1.SelectedItemChanged, New System.EventHandler(AddressOf Me.userQueriesView1_SelectedItemChanged)
		AddHandler Me.userQueriesView1.ErrorMessage, New ActiveQueryBuilder.View.EventHandlers.MetadataStructureItems.MetadataStructureItemErrorEventHandler(AddressOf Me.userQueriesView1_ErrorMessage)
		AddHandler Me.userQueriesView1.QueryRenamed, New ActiveQueryBuilder.View.EventHandlers.MetadataStructureItems.MetadataStructureItemTextChangedEventHandler(AddressOf Me.userQueriesView1_UserQueryItemRenamed)
		AddHandler Me.userQueriesView1.QueryRemoved, New ActiveQueryBuilder.View.MetadataStructureView.MetadataStructureItemEventHandler(AddressOf Me.userQueriesView1_UserQueryItemRemoved)
		AddHandler Me.userQueriesView1.QueryEdit, New ActiveQueryBuilder.View.EventHandlers.MetadataStructureItems.MetadataStructureItemCancelEventHandler(AddressOf Me.userQueriesView1_EditUserQuery)
		AddHandler Me.userQueriesView1.ValidateItemContextMenu, New ActiveQueryBuilder.View.EventHandlers.MetadataStructureItems.MetadataStructureItemMenuEventHandler(AddressOf Me.userQueriesView1_ValidateItemContextMenu)
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.ColumnCount = 1
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel1.Controls.Add(Me.userQueriesView1, 0, 2)
		Me.tableLayoutPanel1.Controls.Add(Me.CaptionConnection, 0, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.DBView, 0, 1)
		Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 49)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 3
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 237F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(200, 540)
		Me.tableLayoutPanel1.TabIndex = 3
		' 
		' DBView
		' 
		Me.DBView.BackColor = System.Drawing.SystemColors.Window
		Me.DBView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DBView.Location = New System.Drawing.Point(3, 29)
		Me.DBView.Name = "DBView"
		Me.DBView.Options.DrawTreeLines = False
		Me.DBView.Options.ImageList = Nothing
		Me.DBView.QueryView = Nothing
		Me.DBView.SelectedItems = New ActiveQueryBuilder.Core.MetadataStructureItem(-1) {}
		Me.DBView.Size = New System.Drawing.Size(194, 271)
		Me.DBView.SQLContext = Nothing
		Me.DBView.TabIndex = 8
		' 
		' MainForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(845, 589)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.Controls.Add(Me.toolStripPanel2)
		Me.Controls.Add(Me.toolStripPanel1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.menuStrip1
		Me.MinimumSize = New System.Drawing.Size(300, 300)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Active Query Builder for .NET WinForms Edition - Professional Full-featured demo " & "(C#)"
		AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.MainForm_FormClosing)
		AddHandler Me.Shown, New System.EventHandler(AddressOf Me.MainForm_Shown)
		Me.toolStripPanel1.ResumeLayout(False)
		Me.toolStripPanel1.PerformLayout()
		Me.menuStrip1.ResumeLayout(False)
		Me.menuStrip1.PerformLayout()
		Me.toolStrip1.ResumeLayout(False)
		Me.toolStrip1.PerformLayout()
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.tableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Private toolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
	Private tsmiLanguageDefault As System.Windows.Forms.ToolStripMenuItem
	Private tsmiLanguageAuto As System.Windows.Forms.ToolStripMenuItem
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
	Private tsmiNew As System.Windows.Forms.ToolStripMenuItem
	Private tsmiOpen As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator As System.Windows.Forms.ToolStripSeparator
	Private tsmiSave As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private tsmiExit As System.Windows.Forms.ToolStripMenuItem
	Private editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private tsmiUndo As System.Windows.Forms.ToolStripMenuItem
	Private tsmiRedo As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private tsmiCut As System.Windows.Forms.ToolStripMenuItem
	Private tsmiCopy As System.Windows.Forms.ToolStripMenuItem
	Private tsmiPaste As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Private tsmiSelectAll As System.Windows.Forms.ToolStripMenuItem
	Private toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private tsmiAbout As System.Windows.Forms.ToolStripMenuItem
	Private toolStrip1 As System.Windows.Forms.ToolStrip
	Private tsbNew As System.Windows.Forms.ToolStripButton
	Private toolStripPanel2 As System.Windows.Forms.ToolStripPanel
	Private tsbOpen As System.Windows.Forms.ToolStripButton
	Private tsbSave As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private tsbCut As System.Windows.Forms.ToolStripButton
	Private tsbCopy As System.Windows.Forms.ToolStripButton
	Private tsbPaste As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
	Private tsbCascade As System.Windows.Forms.ToolStripButton
	Private tsbTileHorizontally As System.Windows.Forms.ToolStripButton
	Private tsbTileVertically As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
	Private tsbAbout As System.Windows.Forms.ToolStripButton
	Private tsmiQuery As System.Windows.Forms.ToolStripMenuItem
	Private tsmiParseQuery As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
	Private tsmiBuildQuery As System.Windows.Forms.ToolStripMenuItem
	Private tsmiRunQuery As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
	Private tsmiQueryStatistics As System.Windows.Forms.ToolStripMenuItem
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private metadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private tsmiRefreshMetadata As System.Windows.Forms.ToolStripMenuItem
	Private tsmiEditMetadata As System.Windows.Forms.ToolStripMenuItem
	Private tsmiClearMetadata As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
	Private tsmiOfflineMode As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
	Private tsmiLoadMetadataFromXML As System.Windows.Forms.ToolStripMenuItem
	Private tsmiSaveMetadataToXML As System.Windows.Forms.ToolStripMenuItem
	Private addDerivedTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private addUnionSubqueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private copyUnionSubwueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private addObjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
	Private queryPropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private propertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private newQueryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripButtonNewQuery As System.Windows.Forms.ToolStripButton
	Private tsbEditMetadata As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
	Private toolStripExecuteUserQuery As System.Windows.Forms.ToolStripButton
	Private CaptionConnection As System.Windows.Forms.Label
	Private userQueriesView1 As ActiveQueryBuilder.View.WinForms.UserQueries.UserQueriesView
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Public DBView As ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView
End Class

