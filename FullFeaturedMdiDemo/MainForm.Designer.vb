
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.toolStripStatusLabel1 = New ToolStripStatusLabel()
			Me.fileToolStripMenuItem = New ToolStripMenuItem()
			Me.BottomToolStripPanel = New ToolStripPanel()
			Me.TopToolStripPanel = New ToolStripPanel()
			Me.RightToolStripPanel = New ToolStripPanel()
			Me.LeftToolStripPanel = New ToolStripPanel()
			Me.ContentPanel = New ToolStripContentPanel()
			Me.toolStripPanel1 = New ToolStripPanel()
			Me.menuStrip1 = New MenuStrip()
			Me.fileToolStripMenuItem1 = New ToolStripMenuItem()
			Me.tsmiNew = New ToolStripMenuItem()
			Me.toolStripSeparator = New ToolStripSeparator()
			Me.newQueryToolStripMenuItem1 = New ToolStripMenuItem()
			Me.tsmiOpen = New ToolStripMenuItem()
			Me.tsmiSave = New ToolStripMenuItem()
			Me.toolStripSeparator1 = New ToolStripSeparator()
			Me.tsmiExit = New ToolStripMenuItem()
			Me.editToolStripMenuItem = New ToolStripMenuItem()
			Me.tsmiUndo = New ToolStripMenuItem()
			Me.tsmiRedo = New ToolStripMenuItem()
			Me.toolStripSeparator3 = New ToolStripSeparator()
			Me.tsmiCut = New ToolStripMenuItem()
			Me.tsmiCopy = New ToolStripMenuItem()
			Me.tsmiPaste = New ToolStripMenuItem()
			Me.toolStripSeparator4 = New ToolStripSeparator()
			Me.tsmiSelectAll = New ToolStripMenuItem()
			Me.tsmiQuery = New ToolStripMenuItem()
			Me.tsmiParseQuery = New ToolStripMenuItem()
			Me.toolStripSeparator8 = New ToolStripSeparator()
			Me.tsmiBuildQuery = New ToolStripMenuItem()
			Me.tsmiRunQuery = New ToolStripMenuItem()
			Me.toolStripSeparator9 = New ToolStripSeparator()
			Me.addObjectToolStripMenuItem = New ToolStripMenuItem()
			Me.addDerivedTableToolStripMenuItem = New ToolStripMenuItem()
			Me.addUnionSubqueryToolStripMenuItem = New ToolStripMenuItem()
			Me.copyUnionSubwueryToolStripMenuItem = New ToolStripMenuItem()
			Me.toolStripSeparator5 = New ToolStripSeparator()
			Me.tsmiQueryStatistics = New ToolStripMenuItem()
			Me.queryPropertiesToolStripMenuItem = New ToolStripMenuItem()
			Me.metadataToolStripMenuItem = New ToolStripMenuItem()
			Me.tsmiOfflineMode = New ToolStripMenuItem()
			Me.toolStripSeparator11 = New ToolStripSeparator()
			Me.tsmiRefreshMetadata = New ToolStripMenuItem()
			Me.tsmiEditMetadata = New ToolStripMenuItem()
			Me.tsmiClearMetadata = New ToolStripMenuItem()
			Me.toolStripSeparator10 = New ToolStripSeparator()
			Me.tsmiLoadMetadataFromXML = New ToolStripMenuItem()
			Me.tsmiSaveMetadataToXML = New ToolStripMenuItem()
			Me.toolsToolStripMenuItem = New ToolStripMenuItem()
			Me.languageToolStripMenuItem = New ToolStripMenuItem()
			Me.tsmiLanguageAuto = New ToolStripMenuItem()
			Me.tsmiLanguageDefault = New ToolStripMenuItem()
			Me.toolStripSeparator12 = New ToolStripSeparator()
			Me.propertiesToolStripMenuItem = New ToolStripMenuItem()
			Me.tsmiAbout = New ToolStripMenuItem()
			Me.toolStrip1 = New ToolStrip()
			Me.tsbNew = New ToolStripButton()
			Me.toolStripButtonNewQuery = New ToolStripButton()
			Me.tsbOpen = New ToolStripButton()
			Me.tsbSave = New ToolStripButton()
			Me.toolStripSeparator2 = New ToolStripSeparator()
			Me.tsbCut = New ToolStripButton()
			Me.tsbCopy = New ToolStripButton()
			Me.tsbPaste = New ToolStripButton()
			Me.toolStripExecuteUserQuery = New ToolStripButton()
			Me.toolStripSeparator6 = New ToolStripSeparator()
			Me.tsbCascade = New ToolStripButton()
			Me.tsbTileHorizontally = New ToolStripButton()
			Me.tsbTileVertically = New ToolStripButton()
			Me.toolStripSeparator7 = New ToolStripSeparator()
			Me.tsbEditMetadata = New ToolStripButton()
			Me.toolStripSeparator13 = New ToolStripSeparator()
			Me.tsbAbout = New ToolStripButton()
			Me.toolStripPanel2 = New ToolStripPanel()
			Me.toolStripButton2 = New ToolStripButton()
			Me.toolStripButton3 = New ToolStripButton()
			Me.toolStripButton4 = New ToolStripButton()
			Me.openFileDialog1 = New OpenFileDialog()
			Me.saveFileDialog1 = New SaveFileDialog()
			Me.CaptionConnection = New Label()
			Me.userQueriesView1 = New ActiveQueryBuilder.View.WinForms.UserQueries.UserQueriesView()
			Me.tableLayoutPanel1 = New TableLayoutPanel()
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
			Me.toolStripStatusLabel1.Size = New Size(109, 17)
			Me.toolStripStatusLabel1.Text = "toolStripStatusLabel1"
			' 
			' fileToolStripMenuItem
			' 
			Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
			Me.fileToolStripMenuItem.Size = New Size(35, 20)
			Me.fileToolStripMenuItem.Text = "File"
			' 
			' BottomToolStripPanel
			' 
			Me.BottomToolStripPanel.Location = New Point(0, 0)
			Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
			Me.BottomToolStripPanel.Orientation = Orientation.Horizontal
			Me.BottomToolStripPanel.RowMargin = New Padding(3, 0, 0, 0)
			Me.BottomToolStripPanel.Size = New Size(0, 0)
			' 
			' TopToolStripPanel
			' 
			Me.TopToolStripPanel.Location = New Point(0, 0)
			Me.TopToolStripPanel.Name = "TopToolStripPanel"
			Me.TopToolStripPanel.Orientation = Orientation.Horizontal
			Me.TopToolStripPanel.RowMargin = New Padding(3, 0, 0, 0)
			Me.TopToolStripPanel.Size = New Size(0, 0)
			' 
			' RightToolStripPanel
			' 
			Me.RightToolStripPanel.Location = New Point(0, 0)
			Me.RightToolStripPanel.Name = "RightToolStripPanel"
			Me.RightToolStripPanel.Orientation = Orientation.Horizontal
			Me.RightToolStripPanel.RowMargin = New Padding(3, 0, 0, 0)
			Me.RightToolStripPanel.Size = New Size(0, 0)
			' 
			' LeftToolStripPanel
			' 
			Me.LeftToolStripPanel.Location = New Point(0, 0)
			Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
			Me.LeftToolStripPanel.Orientation = Orientation.Horizontal
			Me.LeftToolStripPanel.RowMargin = New Padding(3, 0, 0, 0)
			Me.LeftToolStripPanel.Size = New Size(0, 0)
			' 
			' ContentPanel
			' 
			Me.ContentPanel.BorderStyle = BorderStyle.Fixed3D
			Me.ContentPanel.Size = New Size(792, 423)
			' 
			' toolStripPanel1
			' 
			Me.toolStripPanel1.Controls.Add(Me.menuStrip1)
			Me.toolStripPanel1.Controls.Add(Me.toolStrip1)
			Me.toolStripPanel1.Dock = DockStyle.Top
			Me.toolStripPanel1.Location = New Point(0, 0)
			Me.toolStripPanel1.Name = "toolStripPanel1"
			Me.toolStripPanel1.Orientation = Orientation.Horizontal
			Me.toolStripPanel1.RowMargin = New Padding(3, 0, 0, 0)
			Me.toolStripPanel1.Size = New Size(845, 49)
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Dock = DockStyle.None
			Me.menuStrip1.Items.AddRange(New ToolStripItem() { Me.fileToolStripMenuItem1, Me.editToolStripMenuItem, Me.tsmiQuery, Me.metadataToolStripMenuItem, Me.toolsToolStripMenuItem, Me.tsmiAbout})
			Me.menuStrip1.Location = New Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New Size(845, 24)
			Me.menuStrip1.TabIndex = 4
			Me.menuStrip1.Text = "Main Menu"
			' 
			' fileToolStripMenuItem1
			' 
			Me.fileToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() { Me.tsmiNew, Me.toolStripSeparator, Me.newQueryToolStripMenuItem1, Me.tsmiOpen, Me.tsmiSave, Me.toolStripSeparator1, Me.tsmiExit})
			Me.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1"
			Me.fileToolStripMenuItem1.Size = New Size(37, 20)
			Me.fileToolStripMenuItem1.Text = "&File"
			' 
			' tsmiNew
			' 
			Me.tsmiNew.Image = My.Resources.connect
			Me.tsmiNew.ImageTransparentColor = Color.Magenta
			Me.tsmiNew.Name = "tsmiNew"
			Me.tsmiNew.ShortcutKeys = (CType((Keys.Control Or Keys.N), Keys))
			Me.tsmiNew.Size = New Size(171, 22)
			Me.tsmiNew.Text = "&Connect..."
'			Me.tsmiNew.Click += New System.EventHandler(Me.tsmiNew_Click)
			' 
			' toolStripSeparator
			' 
			Me.toolStripSeparator.Name = "toolStripSeparator"
			Me.toolStripSeparator.Size = New Size(168, 6)
			' 
			' newQueryToolStripMenuItem1
			' 
			Me.newQueryToolStripMenuItem1.Image = My.Resources.page_white
			Me.newQueryToolStripMenuItem1.Name = "newQueryToolStripMenuItem1"
			Me.newQueryToolStripMenuItem1.Size = New Size(171, 22)
			Me.newQueryToolStripMenuItem1.Text = "New Query"
'			Me.newQueryToolStripMenuItem1.Click += New System.EventHandler(Me.newQueryToolStripMenuItem_Click)
			' 
			' tsmiOpen
			' 
			Me.tsmiOpen.Image = My.Resources.folder_page
			Me.tsmiOpen.ImageTransparentColor = Color.Magenta
			Me.tsmiOpen.Name = "tsmiOpen"
			Me.tsmiOpen.ShortcutKeys = (CType((Keys.Control Or Keys.O), Keys))
			Me.tsmiOpen.Size = New Size(171, 22)
			Me.tsmiOpen.Text = "&Open"
'			Me.tsmiOpen.Click += New System.EventHandler(Me.tsmiOpen_Click)
			' 
			' tsmiSave
			' 
			Me.tsmiSave.Image = My.Resources.disk
			Me.tsmiSave.ImageTransparentColor = Color.Magenta
			Me.tsmiSave.Name = "tsmiSave"
			Me.tsmiSave.ShortcutKeys = (CType((Keys.Control Or Keys.S), Keys))
			Me.tsmiSave.Size = New Size(171, 22)
			Me.tsmiSave.Text = "&Save"
'			Me.tsmiSave.Click += New System.EventHandler(Me.tsmiSave_Click)
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New Size(168, 6)
			' 
			' tsmiExit
			' 
			Me.tsmiExit.Name = "tsmiExit"
			Me.tsmiExit.Size = New Size(171, 22)
			Me.tsmiExit.Text = "E&xit"
'			Me.tsmiExit.Click += New System.EventHandler(Me.tsmiExit_Click)
			' 
			' editToolStripMenuItem
			' 
			Me.editToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.tsmiUndo, Me.tsmiRedo, Me.toolStripSeparator3, Me.tsmiCut, Me.tsmiCopy, Me.tsmiPaste, Me.toolStripSeparator4, Me.tsmiSelectAll})
			Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
			Me.editToolStripMenuItem.Size = New Size(39, 20)
			Me.editToolStripMenuItem.Text = "&Edit"
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
			' tsmiQuery
			' 
			Me.tsmiQuery.DropDownItems.AddRange(New ToolStripItem() { Me.tsmiParseQuery, Me.toolStripSeparator8, Me.tsmiBuildQuery, Me.tsmiRunQuery, Me.toolStripSeparator9, Me.addObjectToolStripMenuItem, Me.addDerivedTableToolStripMenuItem, Me.addUnionSubqueryToolStripMenuItem, Me.copyUnionSubwueryToolStripMenuItem, Me.toolStripSeparator5, Me.tsmiQueryStatistics, Me.queryPropertiesToolStripMenuItem})
			Me.tsmiQuery.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.tsmiQuery.Name = "tsmiQuery"
			Me.tsmiQuery.Size = New Size(53, 20)
			Me.tsmiQuery.Text = "&Query"
			' 
			' tsmiParseQuery
			' 
			Me.tsmiParseQuery.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.tsmiParseQuery.Name = "tsmiParseQuery"
			Me.tsmiParseQuery.ShortcutKeyDisplayString = ""
			Me.tsmiParseQuery.ShortcutKeys = Keys.F5
			Me.tsmiParseQuery.Size = New Size(197, 22)
			Me.tsmiParseQuery.Text = "Parse Query"
'			Me.tsmiParseQuery.Click += New System.EventHandler(Me.tsmiParseQuery_Click)
			' 
			' toolStripSeparator8
			' 
			Me.toolStripSeparator8.Name = "toolStripSeparator8"
			Me.toolStripSeparator8.Size = New Size(194, 6)
			' 
			' tsmiBuildQuery
			' 
			Me.tsmiBuildQuery.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.tsmiBuildQuery.Image = My.Resources.bricks
			Me.tsmiBuildQuery.Name = "tsmiBuildQuery"
			Me.tsmiBuildQuery.ShortcutKeyDisplayString = ""
			Me.tsmiBuildQuery.ShortcutKeys = Keys.F9
			Me.tsmiBuildQuery.Size = New Size(197, 22)
			Me.tsmiBuildQuery.Text = "Build Query"
'			Me.tsmiBuildQuery.Click += New System.EventHandler(Me.tsmiBuildQuery_Click)
			' 
			' tsmiRunQuery
			' 
			Me.tsmiRunQuery.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.tsmiRunQuery.Image = My.Resources.database_go
			Me.tsmiRunQuery.Name = "tsmiRunQuery"
			Me.tsmiRunQuery.ShortcutKeyDisplayString = ""
			Me.tsmiRunQuery.ShortcutKeys = Keys.F10
			Me.tsmiRunQuery.Size = New Size(197, 22)
			Me.tsmiRunQuery.Text = "Run Query"
'			Me.tsmiRunQuery.Click += New System.EventHandler(Me.tsmiRunQuery_Click)
			' 
			' toolStripSeparator9
			' 
			Me.toolStripSeparator9.Name = "toolStripSeparator9"
			Me.toolStripSeparator9.Size = New Size(194, 6)
			' 
			' addObjectToolStripMenuItem
			' 
			Me.addObjectToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.addObjectToolStripMenuItem.Image = My.Resources.new_object
			Me.addObjectToolStripMenuItem.Name = "addObjectToolStripMenuItem"
			Me.addObjectToolStripMenuItem.Size = New Size(197, 22)
			Me.addObjectToolStripMenuItem.Text = "Add Object"
'			Me.addObjectToolStripMenuItem.Click += New System.EventHandler(Me.addObjectToolStripMenuItem_Click)
			' 
			' addDerivedTableToolStripMenuItem
			' 
			Me.addDerivedTableToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.addDerivedTableToolStripMenuItem.Image = My.Resources.add_derived_table
			Me.addDerivedTableToolStripMenuItem.Name = "addDerivedTableToolStripMenuItem"
			Me.addDerivedTableToolStripMenuItem.Size = New Size(197, 22)
			Me.addDerivedTableToolStripMenuItem.Text = "Add Derived Table"
'			Me.addDerivedTableToolStripMenuItem.Click += New System.EventHandler(Me.addDerivedTableToolStripMenuItem_Click)
			' 
			' addUnionSubqueryToolStripMenuItem
			' 
			Me.addUnionSubqueryToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.addUnionSubqueryToolStripMenuItem.Image = My.Resources.add_union_subquery
			Me.addUnionSubqueryToolStripMenuItem.Name = "addUnionSubqueryToolStripMenuItem"
			Me.addUnionSubqueryToolStripMenuItem.Size = New Size(197, 22)
			Me.addUnionSubqueryToolStripMenuItem.Text = "Add Union Sub-Query"
'			Me.addUnionSubqueryToolStripMenuItem.Click += New System.EventHandler(Me.addUnionSubqueryToolStripMenuItem_Click)
			' 
			' copyUnionSubwueryToolStripMenuItem
			' 
			Me.copyUnionSubwueryToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.copyUnionSubwueryToolStripMenuItem.Image = My.Resources.copy_union_subquery
			Me.copyUnionSubwueryToolStripMenuItem.Name = "copyUnionSubwueryToolStripMenuItem"
			Me.copyUnionSubwueryToolStripMenuItem.Size = New Size(197, 22)
			Me.copyUnionSubwueryToolStripMenuItem.Text = "Copy Union Sub-Query"
'			Me.copyUnionSubwueryToolStripMenuItem.Click += New System.EventHandler(Me.copyUnionSubwueryToolStripMenuItem_Click)
			' 
			' toolStripSeparator5
			' 
			Me.toolStripSeparator5.Name = "toolStripSeparator5"
			Me.toolStripSeparator5.Size = New Size(194, 6)
			' 
			' tsmiQueryStatistics
			' 
			Me.tsmiQueryStatistics.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.tsmiQueryStatistics.Name = "tsmiQueryStatistics"
			Me.tsmiQueryStatistics.ShortcutKeyDisplayString = ""
			Me.tsmiQueryStatistics.ShortcutKeys = Keys.F7
			Me.tsmiQueryStatistics.Size = New Size(197, 22)
			Me.tsmiQueryStatistics.Text = "Query Statistics"
'			Me.tsmiQueryStatistics.Click += New System.EventHandler(Me.tsmiQueryStatistics_Click)
			' 
			' queryPropertiesToolStripMenuItem
			' 
			Me.queryPropertiesToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.queryPropertiesToolStripMenuItem.Name = "queryPropertiesToolStripMenuItem"
			Me.queryPropertiesToolStripMenuItem.Size = New Size(197, 22)
			Me.queryPropertiesToolStripMenuItem.Text = "Query Properties"
'			Me.queryPropertiesToolStripMenuItem.Click += New System.EventHandler(Me.queryPropertiesToolStripMenuItem_Click)
			' 
			' metadataToolStripMenuItem
			' 
			Me.metadataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.tsmiOfflineMode, Me.toolStripSeparator11, Me.tsmiRefreshMetadata, Me.tsmiEditMetadata, Me.tsmiClearMetadata, Me.toolStripSeparator10, Me.tsmiLoadMetadataFromXML, Me.tsmiSaveMetadataToXML})
			Me.metadataToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.metadataToolStripMenuItem.Name = "metadataToolStripMenuItem"
			Me.metadataToolStripMenuItem.Size = New Size(72, 20)
			Me.metadataToolStripMenuItem.Text = "Metadata"
			' 
			' tsmiOfflineMode
			' 
			Me.tsmiOfflineMode.Font = New Font("Segoe UI", 9F)
			Me.tsmiOfflineMode.Name = "tsmiOfflineMode"
			Me.tsmiOfflineMode.Size = New Size(218, 22)
			Me.tsmiOfflineMode.Text = "Offline Mode"
'			Me.tsmiOfflineMode.Click += New System.EventHandler(Me.tsmiOfflineMode_Click)
			' 
			' toolStripSeparator11
			' 
			Me.toolStripSeparator11.Name = "toolStripSeparator11"
			Me.toolStripSeparator11.Size = New Size(215, 6)
			' 
			' tsmiRefreshMetadata
			' 
			Me.tsmiRefreshMetadata.Font = New Font("Segoe UI", 9F)
			Me.tsmiRefreshMetadata.Name = "tsmiRefreshMetadata"
			Me.tsmiRefreshMetadata.Size = New Size(218, 22)
			Me.tsmiRefreshMetadata.Text = "Refresh Metadata"
'			Me.tsmiRefreshMetadata.Click += New System.EventHandler(Me.tsmiRefreshMetadata_Click)
			' 
			' tsmiEditMetadata
			' 
			Me.tsmiEditMetadata.Font = New Font("Segoe UI", 9F)
			Me.tsmiEditMetadata.Name = "tsmiEditMetadata"
			Me.tsmiEditMetadata.Size = New Size(218, 22)
			Me.tsmiEditMetadata.Text = "Edit Metadata"
'			Me.tsmiEditMetadata.Click += New System.EventHandler(Me.tsmiEditMetadata_Click)
			' 
			' tsmiClearMetadata
			' 
			Me.tsmiClearMetadata.Font = New Font("Segoe UI", 9F)
			Me.tsmiClearMetadata.Name = "tsmiClearMetadata"
			Me.tsmiClearMetadata.Size = New Size(218, 22)
			Me.tsmiClearMetadata.Text = "Clear Metadata"
'			Me.tsmiClearMetadata.Click += New System.EventHandler(Me.tsmiClearMetadata_Click)
			' 
			' toolStripSeparator10
			' 
			Me.toolStripSeparator10.Name = "toolStripSeparator10"
			Me.toolStripSeparator10.Size = New Size(215, 6)
			' 
			' tsmiLoadMetadataFromXML
			' 
			Me.tsmiLoadMetadataFromXML.Font = New Font("Segoe UI", 9F)
			Me.tsmiLoadMetadataFromXML.Name = "tsmiLoadMetadataFromXML"
			Me.tsmiLoadMetadataFromXML.Size = New Size(218, 22)
			Me.tsmiLoadMetadataFromXML.Text = "Load Metadata from XML..."
'			Me.tsmiLoadMetadataFromXML.Click += New System.EventHandler(Me.tsmiLoadMetadataFromXML_Click)
			' 
			' tsmiSaveMetadataToXML
			' 
			Me.tsmiSaveMetadataToXML.Font = New Font("Segoe UI", 9F)
			Me.tsmiSaveMetadataToXML.Name = "tsmiSaveMetadataToXML"
			Me.tsmiSaveMetadataToXML.Size = New Size(218, 22)
			Me.tsmiSaveMetadataToXML.Text = "Save Metadata to XML..."
'			Me.tsmiSaveMetadataToXML.Click += New System.EventHandler(Me.tsmiSaveMetadataToXML_Click)
			' 
			' toolsToolStripMenuItem
			' 
			Me.toolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.languageToolStripMenuItem, Me.propertiesToolStripMenuItem})
			Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
			Me.toolsToolStripMenuItem.Size = New Size(61, 20)
			Me.toolsToolStripMenuItem.Text = "&Options"
			' 
			' languageToolStripMenuItem
			' 
			Me.languageToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.tsmiLanguageAuto, Me.tsmiLanguageDefault, Me.toolStripSeparator12})
			Me.languageToolStripMenuItem.Name = "languageToolStripMenuItem"
			Me.languageToolStripMenuItem.Size = New Size(127, 22)
			Me.languageToolStripMenuItem.Text = "Language"
			' 
			' tsmiLanguageAuto
			' 
			Me.tsmiLanguageAuto.Name = "tsmiLanguageAuto"
			Me.tsmiLanguageAuto.Size = New Size(161, 22)
			Me.tsmiLanguageAuto.Text = "Auto"
'			Me.tsmiLanguageAuto.Click += New System.EventHandler(Me.tsmiLanguageAuto_Click)
			' 
			' tsmiLanguageDefault
			' 
			Me.tsmiLanguageDefault.Name = "tsmiLanguageDefault"
			Me.tsmiLanguageDefault.Size = New Size(161, 22)
			Me.tsmiLanguageDefault.Text = "Default (English)"
'			Me.tsmiLanguageDefault.Click += New System.EventHandler(Me.tsmiLanguageDefault_Click)
			' 
			' toolStripSeparator12
			' 
			Me.toolStripSeparator12.Name = "toolStripSeparator12"
			Me.toolStripSeparator12.Size = New Size(158, 6)
			' 
			' propertiesToolStripMenuItem
			' 
			Me.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem"
			Me.propertiesToolStripMenuItem.Size = New Size(127, 22)
			Me.propertiesToolStripMenuItem.Text = "Properties"
'			Me.propertiesToolStripMenuItem.Click += New System.EventHandler(Me.propertiesToolStripMenuItem_Click)
			' 
			' tsmiAbout
			' 
			Me.tsmiAbout.Name = "tsmiAbout"
			Me.tsmiAbout.Size = New Size(61, 20)
			Me.tsmiAbout.Text = "&About..."
'			Me.tsmiAbout.Click += New System.EventHandler(Me.tsmiAbout_Click)
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Dock = DockStyle.None
			Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.tsbNew, Me.toolStripButtonNewQuery, Me.tsbOpen, Me.tsbSave, Me.toolStripSeparator2, Me.tsbCut, Me.tsbCopy, Me.tsbPaste, Me.toolStripExecuteUserQuery, Me.toolStripSeparator6, Me.tsbCascade, Me.tsbTileHorizontally, Me.tsbTileVertically, Me.toolStripSeparator7, Me.tsbEditMetadata, Me.toolStripSeparator13, Me.tsbAbout})
			Me.toolStrip1.Location = New Point(0, 24)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New Size(845, 25)
			Me.toolStrip1.Stretch = True
			Me.toolStrip1.TabIndex = 5
			Me.toolStrip1.Text = "Main Toolbar"
			' 
			' tsbNew
			' 
			Me.tsbNew.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbNew.Image = My.Resources.connect
			Me.tsbNew.ImageTransparentColor = Color.Magenta
			Me.tsbNew.Name = "tsbNew"
			Me.tsbNew.Size = New Size(23, 22)
			Me.tsbNew.Text = "Establish new connection..."
'			Me.tsbNew.Click += New System.EventHandler(Me.tsbNew_Click)
			' 
			' toolStripButtonNewQuery
			' 
			Me.toolStripButtonNewQuery.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.toolStripButtonNewQuery.Image = My.Resources.page_white
			Me.toolStripButtonNewQuery.ImageTransparentColor = Color.Magenta
			Me.toolStripButtonNewQuery.Name = "toolStripButtonNewQuery"
			Me.toolStripButtonNewQuery.Size = New Size(23, 22)
			Me.toolStripButtonNewQuery.Text = "Open new query window"
'			Me.toolStripButtonNewQuery.Click += New System.EventHandler(Me.newQueryToolStripMenuItem_Click)
			' 
			' tsbOpen
			' 
			Me.tsbOpen.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbOpen.Image = My.Resources.folder_page
			Me.tsbOpen.ImageTransparentColor = Color.Magenta
			Me.tsbOpen.Name = "tsbOpen"
			Me.tsbOpen.Size = New Size(23, 22)
			Me.tsbOpen.Text = "Load query from file..."
'			Me.tsbOpen.Click += New System.EventHandler(Me.tsbOpen_Click)
			' 
			' tsbSave
			' 
			Me.tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbSave.Image = My.Resources.disk
			Me.tsbSave.ImageTransparentColor = Color.Magenta
			Me.tsbSave.Name = "tsbSave"
			Me.tsbSave.Size = New Size(23, 22)
			Me.tsbSave.Text = "Save the current query"
'			Me.tsbSave.Click += New System.EventHandler(Me.tsbSave_Click)
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New Size(6, 25)
			' 
			' tsbCut
			' 
			Me.tsbCut.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbCut.Image = My.Resources.cut
			Me.tsbCut.ImageTransparentColor = Color.Magenta
			Me.tsbCut.Name = "tsbCut"
			Me.tsbCut.Size = New Size(23, 22)
			Me.tsbCut.Text = "Cut"
'			Me.tsbCut.Click += New System.EventHandler(Me.tsbCut_Click)
			' 
			' tsbCopy
			' 
			Me.tsbCopy.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbCopy.Image = My.Resources.page_copy
			Me.tsbCopy.ImageTransparentColor = Color.Magenta
			Me.tsbCopy.Name = "tsbCopy"
			Me.tsbCopy.Size = New Size(23, 22)
			Me.tsbCopy.Text = "Copy"
'			Me.tsbCopy.Click += New System.EventHandler(Me.tsbCopy_Click)
			' 
			' tsbPaste
			' 
			Me.tsbPaste.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbPaste.Image = My.Resources.page_paste
			Me.tsbPaste.ImageTransparentColor = Color.Magenta
			Me.tsbPaste.Name = "tsbPaste"
			Me.tsbPaste.Size = New Size(23, 22)
			Me.tsbPaste.Text = "Paste"
'			Me.tsbPaste.Click += New System.EventHandler(Me.tsbPaste_Click)
			' 
			' toolStripExecuteUserQuery
			' 
			Me.toolStripExecuteUserQuery.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.toolStripExecuteUserQuery.Enabled = False
			Me.toolStripExecuteUserQuery.Image = My.Resources.run
			Me.toolStripExecuteUserQuery.ImageScaling = ToolStripItemImageScaling.None
			Me.toolStripExecuteUserQuery.ImageTransparentColor = Color.Magenta
			Me.toolStripExecuteUserQuery.Name = "toolStripExecuteUserQuery"
			Me.toolStripExecuteUserQuery.Size = New Size(23, 22)
			Me.toolStripExecuteUserQuery.Text = "toolStripButton1"
			Me.toolStripExecuteUserQuery.ToolTipText = "Execute query"
'			Me.toolStripExecuteUserQuery.Click += New System.EventHandler(Me.toolStripExecuteUserQuery_Click)
			' 
			' toolStripSeparator6
			' 
			Me.toolStripSeparator6.Name = "toolStripSeparator6"
			Me.toolStripSeparator6.Size = New Size(6, 25)
			' 
			' tsbCascade
			' 
			Me.tsbCascade.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbCascade.Image = My.Resources.application_cascade
			Me.tsbCascade.ImageTransparentColor = Color.Magenta
			Me.tsbCascade.Name = "tsbCascade"
			Me.tsbCascade.Size = New Size(23, 22)
			Me.tsbCascade.Text = "Cascade"
'			Me.tsbCascade.Click += New System.EventHandler(Me.tsbCascade_Click)
			' 
			' tsbTileHorizontally
			' 
			Me.tsbTileHorizontally.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbTileHorizontally.Image = My.Resources.application_tile_horizontal
			Me.tsbTileHorizontally.ImageTransparentColor = Color.Magenta
			Me.tsbTileHorizontally.Name = "tsbTileHorizontally"
			Me.tsbTileHorizontally.Size = New Size(23, 22)
			Me.tsbTileHorizontally.Text = "Tile Horzontally"
'			Me.tsbTileHorizontally.Click += New System.EventHandler(Me.tsbTileHorizontally_Click)
			' 
			' tsbTileVertically
			' 
			Me.tsbTileVertically.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbTileVertically.Image = My.Resources.application_tile_vertical
			Me.tsbTileVertically.ImageTransparentColor = Color.Magenta
			Me.tsbTileVertically.Name = "tsbTileVertically"
			Me.tsbTileVertically.Size = New Size(23, 22)
			Me.tsbTileVertically.Text = "Tile Vertically"
'			Me.tsbTileVertically.Click += New System.EventHandler(Me.tsbTileVertically_Click)
			' 
			' toolStripSeparator7
			' 
			Me.toolStripSeparator7.Name = "toolStripSeparator7"
			Me.toolStripSeparator7.Size = New Size(6, 25)
			' 
			' tsbEditMetadata
			' 
			Me.tsbEditMetadata.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbEditMetadata.Image = My.Resources.database_edit
			Me.tsbEditMetadata.ImageTransparentColor = Color.Magenta
			Me.tsbEditMetadata.Name = "tsbEditMetadata"
			Me.tsbEditMetadata.Size = New Size(23, 22)
			Me.tsbEditMetadata.Text = "Edit Metadata"
'			Me.tsbEditMetadata.Click += New System.EventHandler(Me.tsbEditMetadata_Click)
			' 
			' toolStripSeparator13
			' 
			Me.toolStripSeparator13.Name = "toolStripSeparator13"
			Me.toolStripSeparator13.Size = New Size(6, 25)
			' 
			' tsbAbout
			' 
			Me.tsbAbout.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbAbout.Image = My.Resources.help
			Me.tsbAbout.ImageTransparentColor = Color.Magenta
			Me.tsbAbout.Name = "tsbAbout"
			Me.tsbAbout.Size = New Size(23, 22)
			Me.tsbAbout.Text = "About..."
'			Me.tsbAbout.Click += New System.EventHandler(Me.tsbAbout_Click)
			' 
			' toolStripPanel2
			' 
			Me.toolStripPanel2.Dock = DockStyle.Bottom
			Me.toolStripPanel2.Location = New Point(0, 589)
			Me.toolStripPanel2.Name = "toolStripPanel2"
			Me.toolStripPanel2.Orientation = Orientation.Horizontal
			Me.toolStripPanel2.RowMargin = New Padding(3, 0, 0, 0)
			Me.toolStripPanel2.Size = New Size(845, 0)
			' 
			' toolStripButton2
			' 
			Me.toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.toolStripButton2.Image = My.Resources.page_white
			Me.toolStripButton2.ImageTransparentColor = Color.Magenta
			Me.toolStripButton2.Name = "toolStripButton2"
			Me.toolStripButton2.Size = New Size(23, 22)
			Me.toolStripButton2.Text = "toolStripButton2"
			' 
			' toolStripButton3
			' 
			Me.toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.toolStripButton3.Image = (CType(resources.GetObject("toolStripButton3.Image"), Image))
			Me.toolStripButton3.ImageTransparentColor = Color.Magenta
			Me.toolStripButton3.Name = "toolStripButton3"
			Me.toolStripButton3.Size = New Size(23, 22)
			Me.toolStripButton3.Text = "toolStripButton3"
			' 
			' toolStripButton4
			' 
			Me.toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.toolStripButton4.Image = (CType(resources.GetObject("toolStripButton4.Image"), Image))
			Me.toolStripButton4.ImageTransparentColor = Color.Magenta
			Me.toolStripButton4.Name = "toolStripButton4"
			Me.toolStripButton4.Size = New Size(23, 22)
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
			Me.CaptionConnection.Dock = DockStyle.Fill
			Me.CaptionConnection.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
			Me.CaptionConnection.Location = New Point(3, 3)
			Me.CaptionConnection.Margin = New Padding(3, 3, 3, 0)
			Me.CaptionConnection.Name = "CaptionConnection"
			Me.CaptionConnection.Padding = New Padding(10, 5, 0, 5)
			Me.CaptionConnection.Size = New Size(194, 23)
			Me.CaptionConnection.TabIndex = 0
			Me.CaptionConnection.Text = "< No connection > "
			' 
			' userQueriesView1
			' 
			Me.userQueriesView1.AllowDrop = True
			Me.userQueriesView1.BackColor = SystemColors.InactiveCaption
			Me.userQueriesView1.DisplaySaveButtons = False
			Me.userQueriesView1.Dock = DockStyle.Fill
			Me.userQueriesView1.FocusedItem = Nothing
			Me.userQueriesView1.Location = New Point(3, 306)
			Me.userQueriesView1.Name = "userQueriesView1"
			Me.userQueriesView1.Size = New Size(194, 231)
			Me.userQueriesView1.TabIndex = 7
			Me.userQueriesView1.Title = "Reusable Queries"
'			Me.userQueriesView1.SelectedItemChanged += New System.EventHandler(Me.userQueriesView1_SelectedItemChanged)
'			Me.userQueriesView1.ErrorMessage += New ActiveQueryBuilder.View.EventHandlers.MetadataStructureItems.MetadataStructureItemErrorEventHandler(Me.userQueriesView1_ErrorMessage)
'			Me.userQueriesView1.QueryRenamed += New ActiveQueryBuilder.View.EventHandlers.MetadataStructureItems.MetadataStructureItemTextChangedEventHandler(Me.userQueriesView1_UserQueryItemRenamed)
'			Me.userQueriesView1.QueryRemoved += New ActiveQueryBuilder.View.MetadataStructureView.MetadataStructureItemEventHandler(Me.userQueriesView1_UserQueryItemRemoved)
'			Me.userQueriesView1.QueryEdit += New ActiveQueryBuilder.View.EventHandlers.MetadataStructureItems.MetadataStructureItemCancelEventHandler(Me.userQueriesView1_EditUserQuery)
'			Me.userQueriesView1.ValidateItemContextMenu += New ActiveQueryBuilder.View.EventHandlers.MetadataStructureItems.MetadataStructureItemMenuEventHandler(Me.userQueriesView1_ValidateItemContextMenu)
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 1
			Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Controls.Add(Me.userQueriesView1, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.CaptionConnection, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.DBView, 0, 1)
			Me.tableLayoutPanel1.Dock = DockStyle.Left
			Me.tableLayoutPanel1.Location = New Point(0, 49)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 3
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle())
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
			Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 237F))
			Me.tableLayoutPanel1.Size = New Size(200, 540)
			Me.tableLayoutPanel1.TabIndex = 3
			' 
			' DBView
			' 
			Me.DBView.BackColor = SystemColors.Window
			Me.DBView.Dock = DockStyle.Fill
			Me.DBView.Location = New Point(3, 29)
			Me.DBView.Name = "DBView"
			Me.DBView.Options.DrawTreeLines = False
			Me.DBView.Options.ImageList = Nothing
			Me.DBView.QueryView = Nothing
			Me.DBView.SelectedItems = New ActiveQueryBuilder.Core.MetadataStructureItem(){}
			Me.DBView.Size = New Size(194, 271)
			Me.DBView.SQLContext = Nothing
			Me.DBView.TabIndex = 8
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(845, 589)
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Controls.Add(Me.toolStripPanel2)
			Me.Controls.Add(Me.toolStripPanel1)
			Me.Font = New Font("Microsoft Sans Serif", 8.25F)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.IsMdiContainer = True
			Me.MainMenuStrip = Me.menuStrip1
			Me.MinimumSize = New Size(300, 300)
			Me.Name = "MainForm"
			Me.StartPosition = FormStartPosition.Manual
			Me.Text = "Active Query Builder for .NET WinForms Edition - Professional Full-featured demo " & "(C#)"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.MainForm_FormClosing)
'			Me.Shown += New System.EventHandler(Me.MainForm_Shown)
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
		Private editToolStripMenuItem As ToolStripMenuItem
		Private WithEvents tsmiUndo As ToolStripMenuItem
		Private WithEvents tsmiRedo As ToolStripMenuItem
		Private toolStripSeparator3 As ToolStripSeparator
		Private WithEvents tsmiCut As ToolStripMenuItem
		Private WithEvents tsmiCopy As ToolStripMenuItem
		Private WithEvents tsmiPaste As ToolStripMenuItem
		Private toolStripSeparator4 As ToolStripSeparator
		Private WithEvents tsmiSelectAll As ToolStripMenuItem
		Private toolsToolStripMenuItem As ToolStripMenuItem
		Private WithEvents tsmiAbout As ToolStripMenuItem
		Private toolStrip1 As ToolStrip
		Private WithEvents tsbNew As ToolStripButton
		Private toolStripPanel2 As ToolStripPanel
		Private WithEvents tsbOpen As ToolStripButton
		Private WithEvents tsbSave As ToolStripButton
		Private toolStripSeparator2 As ToolStripSeparator
		Private WithEvents tsbCut As ToolStripButton
		Private WithEvents tsbCopy As ToolStripButton
		Private WithEvents tsbPaste As ToolStripButton
		Private toolStripSeparator6 As ToolStripSeparator
		Private WithEvents tsbCascade As ToolStripButton
		Private WithEvents tsbTileHorizontally As ToolStripButton
		Private WithEvents tsbTileVertically As ToolStripButton
		Private toolStripSeparator7 As ToolStripSeparator
		Private WithEvents tsbAbout As ToolStripButton
		Private tsmiQuery As ToolStripMenuItem
		Private WithEvents tsmiParseQuery As ToolStripMenuItem
		Private toolStripSeparator8 As ToolStripSeparator
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
		Private WithEvents toolStripExecuteUserQuery As ToolStripButton
		Private CaptionConnection As Label
		Private WithEvents userQueriesView1 As ActiveQueryBuilder.View.WinForms.UserQueries.UserQueriesView
		Private tableLayoutPanel1 As TableLayoutPanel
		Public DBView As ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView
	End Class
