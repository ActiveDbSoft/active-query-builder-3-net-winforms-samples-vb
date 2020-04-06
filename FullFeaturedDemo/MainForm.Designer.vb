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
			Dim linkPainterAccess1 As New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
			Me.imageList1 = New ImageList(Me.components)
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
			Me.tsmiSaveAs = New ToolStripMenuItem()
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
			Me.tsbSaveInFile = New ToolStripButton()
			Me.toolStripSeparator2 = New ToolStripSeparator()
			Me.tsbCut = New ToolStripButton()
			Me.tsbCopy = New ToolStripButton()
			Me.tsbPaste = New ToolStripButton()
			Me.toolStripSeparator6 = New ToolStripSeparator()
			Me.tsbEditMetadata = New ToolStripButton()
			Me.toolStripSeparator13 = New ToolStripSeparator()
			Me.tsbAbout = New ToolStripButton()
			Me.toolStripPanel2 = New ToolStripPanel()
			Me.toolStripButton2 = New ToolStripButton()
			Me.toolStripButton3 = New ToolStripButton()
			Me.toolStripButton4 = New ToolStripButton()
			Me.openFileDialog1 = New OpenFileDialog()
			Me.saveFileDialog1 = New SaveFileDialog()
			Me.tabControl1 = New TabControl()
			Me.pageQueryBuilder = New TabPage()
			Me.splitContainer1 = New SplitContainer()
			Me.panel1 = New Panel()
			Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
			Me.panelSleepMode = New Label()
			Me.toolStrip2 = New ToolStrip()
			Me.tsbQueryProperties = New ToolStripButton()
			Me.tsbAddObject = New ToolStripButton()
			Me.toolStripSeparator14 = New ToolStripSeparator()
			Me.tsbAddDerivedTable = New ToolStripButton()
			Me.tsbAddUnionSubquery = New ToolStripButton()
			Me.tsbCopyUnionSubquery = New ToolStripButton()
			Me.toolStripSeparator15 = New ToolStripSeparator()
			Me.errorBox1 = New Common.SqlErrorBox()
			Me.teSql = New RichTextBox()
			Me.pageQueryResult = New TabPage()
			Me.splitContainer2 = New SplitContainer()
			Me.dataViewer = New DataViewerControl.DataViewer()
			Me.CBuilder = New ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder()
			Me.teResultSql = New RichTextBox()
			Me.contextMenuStripForRichTextBox = New ContextMenuStrip(Me.components)
			Me.toolStripPanel1.SuspendLayout()
			Me.menuStrip1.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.tabControl1.SuspendLayout()
			Me.pageQueryBuilder.SuspendLayout()
			CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			Me.panel1.SuspendLayout()
			CType(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolStrip2.SuspendLayout()
			Me.pageQueryResult.SuspendLayout()
			CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainer2.Panel1.SuspendLayout()
			Me.splitContainer2.Panel2.SuspendLayout()
			Me.splitContainer2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "bricks.ico")
			Me.imageList1.Images.SetKeyName(1, "database_go.ico")
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
			Me.toolStripPanel1.Size = New Size(833, 49)
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Dock = DockStyle.None
			Me.menuStrip1.Items.AddRange(New ToolStripItem() { Me.fileToolStripMenuItem1, Me.editToolStripMenuItem, Me.tsmiQuery, Me.metadataToolStripMenuItem, Me.toolsToolStripMenuItem, Me.tsmiAbout})
			Me.menuStrip1.Location = New Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New Size(833, 24)
			Me.menuStrip1.TabIndex = 4
			Me.menuStrip1.Text = "Main Menu"
			' 
			' fileToolStripMenuItem1
			' 
			Me.fileToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() { Me.tsmiNew, Me.toolStripSeparator, Me.newQueryToolStripMenuItem1, Me.tsmiOpen, Me.tsmiSave, Me.tsmiSaveAs, Me.toolStripSeparator1, Me.tsmiExit})
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
			' tsmiSaveAs
			' 
			Me.tsmiSaveAs.Image = My.Resources.drive_disk
			Me.tsmiSaveAs.Name = "tsmiSaveAs"
			Me.tsmiSaveAs.Size = New Size(171, 22)
			Me.tsmiSaveAs.Text = "Save As"
'			Me.tsmiSaveAs.Click += New System.EventHandler(Me.tsbSaveInFile_Click)
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
'			Me.addObjectToolStripMenuItem.Click += New System.EventHandler(Me.tsbAddObject_Click)
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
'			Me.addUnionSubqueryToolStripMenuItem.Click += New System.EventHandler(Me.addUnionSubQueryToolStripMenuItem_Click)
			' 
			' copyUnionSubwueryToolStripMenuItem
			' 
			Me.copyUnionSubwueryToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.copyUnionSubwueryToolStripMenuItem.Image = My.Resources.copy_union_subquery
			Me.copyUnionSubwueryToolStripMenuItem.Name = "copyUnionSubwueryToolStripMenuItem"
			Me.copyUnionSubwueryToolStripMenuItem.Size = New Size(197, 22)
			Me.copyUnionSubwueryToolStripMenuItem.Text = "Copy Union Sub-Query"
'			Me.copyUnionSubwueryToolStripMenuItem.Click += New System.EventHandler(Me.tsbCopyUnionSubquery_Click)
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
'			Me.queryPropertiesToolStripMenuItem.Click += New System.EventHandler(Me.tsbQueryProperties_Click)
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
			Me.languageToolStripMenuItem.Size = New Size(180, 22)
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
			Me.propertiesToolStripMenuItem.Size = New Size(180, 22)
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
			Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.tsbNew, Me.toolStripButtonNewQuery, Me.tsbOpen, Me.tsbSave, Me.tsbSaveInFile, Me.toolStripSeparator2, Me.tsbCut, Me.tsbCopy, Me.tsbPaste, Me.toolStripSeparator6, Me.tsbEditMetadata, Me.toolStripSeparator13, Me.tsbAbout})
			Me.toolStrip1.Location = New Point(0, 24)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New Size(833, 25)
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
'			Me.tsbNew.Click += New System.EventHandler(Me.tsmiNew_Click)
			' 
			' toolStripButtonNewQuery
			' 
			Me.toolStripButtonNewQuery.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.toolStripButtonNewQuery.Image = My.Resources.page_white
			Me.toolStripButtonNewQuery.ImageTransparentColor = Color.Magenta
			Me.toolStripButtonNewQuery.Name = "toolStripButtonNewQuery"
			Me.toolStripButtonNewQuery.Size = New Size(23, 22)
			Me.toolStripButtonNewQuery.Text = "New Query"
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
'			Me.tsbOpen.Click += New System.EventHandler(Me.tsmiOpen_Click)
			' 
			' tsbSave
			' 
			Me.tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbSave.Image = My.Resources.disk
			Me.tsbSave.ImageTransparentColor = Color.Magenta
			Me.tsbSave.Name = "tsbSave"
			Me.tsbSave.Size = New Size(23, 22)
			Me.tsbSave.Text = "Save the current query"
'			Me.tsbSave.Click += New System.EventHandler(Me.tsmiSave_Click)
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
'			Me.tsbCut.Click += New System.EventHandler(Me.tsmiCut_Click)
			' 
			' tsbCopy
			' 
			Me.tsbCopy.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbCopy.Image = My.Resources.page_copy
			Me.tsbCopy.ImageTransparentColor = Color.Magenta
			Me.tsbCopy.Name = "tsbCopy"
			Me.tsbCopy.Size = New Size(23, 22)
			Me.tsbCopy.Text = "Copy"
'			Me.tsbCopy.Click += New System.EventHandler(Me.tsmiCopy_Click)
			' 
			' tsbPaste
			' 
			Me.tsbPaste.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.tsbPaste.Image = My.Resources.page_paste
			Me.tsbPaste.ImageTransparentColor = Color.Magenta
			Me.tsbPaste.Name = "tsbPaste"
			Me.tsbPaste.Size = New Size(23, 22)
			Me.tsbPaste.Text = "Paste"
'			Me.tsbPaste.Click += New System.EventHandler(Me.tsmiPaste_Click)
			' 
			' toolStripSeparator6
			' 
			Me.toolStripSeparator6.Name = "toolStripSeparator6"
			Me.toolStripSeparator6.Size = New Size(6, 25)
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
'			Me.tsbAbout.Click += New System.EventHandler(Me.tsmiAbout_Click)
			' 
			' toolStripPanel2
			' 
			Me.toolStripPanel2.Dock = DockStyle.Bottom
			Me.toolStripPanel2.Location = New Point(0, 589)
			Me.toolStripPanel2.Name = "toolStripPanel2"
			Me.toolStripPanel2.Orientation = Orientation.Horizontal
			Me.toolStripPanel2.RowMargin = New Padding(3, 0, 0, 0)
			Me.toolStripPanel2.Size = New Size(833, 0)
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
			' tabControl1
			' 
			Me.tabControl1.Controls.Add(Me.pageQueryBuilder)
			Me.tabControl1.Controls.Add(Me.pageQueryResult)
			Me.tabControl1.Dock = DockStyle.Fill
			Me.tabControl1.ImageList = Me.imageList1
			Me.tabControl1.ItemSize = New Size(97, 23)
			Me.tabControl1.Location = New Point(0, 49)
			Me.tabControl1.Name = "tabControl1"
			Me.tabControl1.SelectedIndex = 0
			Me.tabControl1.Size = New Size(833, 540)
			Me.tabControl1.TabIndex = 7
'			Me.tabControl1.Selecting += New System.Windows.Forms.TabControlCancelEventHandler(Me.tabControl1_Selecting)
			' 
			' pageQueryBuilder
			' 
			Me.pageQueryBuilder.Controls.Add(Me.splitContainer1)
			Me.pageQueryBuilder.ImageIndex = 0
			Me.pageQueryBuilder.Location = New Point(4, 27)
			Me.pageQueryBuilder.Name = "pageQueryBuilder"
			Me.pageQueryBuilder.Padding = New Padding(3)
			Me.pageQueryBuilder.Size = New Size(825, 509)
			Me.pageQueryBuilder.TabIndex = 0
			Me.pageQueryBuilder.Text = "Query Builder"
			Me.pageQueryBuilder.UseVisualStyleBackColor = True
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = DockStyle.Fill
			Me.splitContainer1.FixedPanel = FixedPanel.Panel2
			Me.splitContainer1.Location = New Point(3, 3)
			Me.splitContainer1.Name = "splitContainer1"
			Me.splitContainer1.Orientation = Orientation.Horizontal
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.panel1)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.errorBox1)
			Me.splitContainer1.Panel2.Controls.Add(Me.teSql)
			Me.splitContainer1.Size = New Size(819, 503)
			Me.splitContainer1.SplitterDistance = 408
			Me.splitContainer1.TabIndex = 1
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.queryBuilder1)
			Me.panel1.Controls.Add(Me.panelSleepMode)
			Me.panel1.Controls.Add(Me.toolStrip2)
			Me.panel1.Dock = DockStyle.Fill
			Me.panel1.Location = New Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Size(819, 408)
			Me.panel1.TabIndex = 0
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
			Me.queryBuilder1.Location = New Point(0, 25)
			Me.queryBuilder1.Name = "queryBuilder1"
			Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewDock = ActiveQueryBuilder.View.SidePanelDockStyle.Left
			Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 168
			Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = True
			Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
			Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = True
			Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = True
			Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
			Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = True
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90R
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100R
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 140R
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 200R
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60R
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 250R
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 100R
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55R
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 100R
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3
			Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 60R
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
			Me.queryBuilder1.QueryNavBarOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
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
			Me.queryBuilder1.Size = New Size(819, 344)
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
			Me.queryBuilder1.TabIndex = 4
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
			Me.queryBuilder1.VisualOptions.TabFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.queryBuilder1.VisualOptions.TabsStripBackColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
'			Me.queryBuilder1.SQLUpdated += New System.EventHandler(Me.queryBuilder1_SQLUpdated)
			' 
			' panelSleepMode
			' 
			Me.panelSleepMode.BackColor = Color.Bisque
			Me.panelSleepMode.BorderStyle = BorderStyle.FixedSingle
			Me.panelSleepMode.Dock = DockStyle.Bottom
			Me.panelSleepMode.FlatStyle = FlatStyle.Flat
			Me.panelSleepMode.Location = New Point(0, 369)
			Me.panelSleepMode.Name = "panelSleepMode"
			Me.panelSleepMode.Padding = New Padding(10)
			Me.panelSleepMode.Size = New Size(819, 39)
			Me.panelSleepMode.TabIndex = 3
			Me.panelSleepMode.Text = "Unsupported SQL statement. Visual Query Builder has been disabled. Either type a " & "SELECT statement or start building a query visually to turn this mode off."
			Me.panelSleepMode.TextAlign = ContentAlignment.MiddleLeft
			Me.panelSleepMode.Visible = False
			' 
			' toolStrip2
			' 
			Me.toolStrip2.Items.AddRange(New ToolStripItem() { Me.tsbQueryProperties, Me.tsbAddObject, Me.toolStripSeparator14, Me.tsbAddDerivedTable, Me.tsbAddUnionSubquery, Me.tsbCopyUnionSubquery, Me.toolStripSeparator15})
			Me.toolStrip2.Location = New Point(0, 0)
			Me.toolStrip2.Name = "toolStrip2"
			Me.toolStrip2.Size = New Size(819, 25)
			Me.toolStrip2.Stretch = True
			Me.toolStrip2.TabIndex = 2
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
			' toolStripSeparator14
			' 
			Me.toolStripSeparator14.Name = "toolStripSeparator14"
			Me.toolStripSeparator14.Size = New Size(6, 25)
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
			' toolStripSeparator15
			' 
			Me.toolStripSeparator15.Name = "toolStripSeparator15"
			Me.toolStripSeparator15.Size = New Size(6, 25)
			' 
			' errorBox1
			' 
			Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.errorBox1.AutoSize = True
			Me.errorBox1.BackColor = Color.LightPink
			Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
			Me.errorBox1.CurrentSyntaxProvider = Nothing
			Me.errorBox1.IsVisibleCheckSyntaxPanel = False
			Me.errorBox1.Location = New Point(499, 25)
			Me.errorBox1.Name = "errorBox1"
			Me.errorBox1.Padding = New Padding(5)
			Me.errorBox1.Size = New Size(315, 61)
			Me.errorBox1.TabIndex = 1
			Me.errorBox1.Visible = False
'			Me.errorBox1.GoToErrorPosition += New System.EventHandler(Me.errorBox1_GoToErrorPosition)
'			Me.errorBox1.RevertValidText += New System.EventHandler(Me.errorBox1_RevertValidText)
			' 
			' teSql
			' 
			Me.teSql.Dock = DockStyle.Fill
			Me.teSql.Font = New Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.teSql.Location = New Point(0, 0)
			Me.teSql.Name = "teSql"
			Me.teSql.Size = New Size(819, 91)
			Me.teSql.TabIndex = 0
			Me.teSql.Text = ""
'			Me.teSql.Validating += New System.ComponentModel.CancelEventHandler(Me.teQbSql_Validating)
			' 
			' pageQueryResult
			' 
			Me.pageQueryResult.Controls.Add(Me.splitContainer2)
			Me.pageQueryResult.ImageIndex = 1
			Me.pageQueryResult.Location = New Point(4, 27)
			Me.pageQueryResult.Name = "pageQueryResult"
			Me.pageQueryResult.Padding = New Padding(3)
			Me.pageQueryResult.Size = New Size(825, 509)
			Me.pageQueryResult.TabIndex = 1
			Me.pageQueryResult.Text = "Query Result"
			Me.pageQueryResult.UseVisualStyleBackColor = True
			' 
			' splitContainer2
			' 
			Me.splitContainer2.Dock = DockStyle.Fill
			Me.splitContainer2.FixedPanel = FixedPanel.Panel2
			Me.splitContainer2.Location = New Point(3, 3)
			Me.splitContainer2.Name = "splitContainer2"
			Me.splitContainer2.Orientation = Orientation.Horizontal
			' 
			' splitContainer2.Panel1
			' 
			Me.splitContainer2.Panel1.Controls.Add(Me.dataViewer)
			Me.splitContainer2.Panel1.Controls.Add(Me.CBuilder)
			' 
			' splitContainer2.Panel2
			' 
			Me.splitContainer2.Panel2.Controls.Add(Me.teResultSql)
			Me.splitContainer2.Size = New Size(819, 503)
			Me.splitContainer2.SplitterDistance = 408
			Me.splitContainer2.TabIndex = 0
			' 
			' dataViewer
			' 
			Me.dataViewer.Dock = DockStyle.Fill
			Me.dataViewer.Location = New Point(0, 51)
			Me.dataViewer.Name = "dataViewer"
			Me.dataViewer.Size = New Size(819, 328)
			Me.dataViewer.TabIndex = 0
			' 
			' CBuilder
			' 
			Me.CBuilder.AutoSize = True
			Me.CBuilder.AutoSizeMode = AutoSizeMode.GrowAndShrink
			Me.CBuilder.Dock = DockStyle.Top
			Me.CBuilder.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.CBuilder.Location = New Point(0, 0)
			Me.CBuilder.MinimumSize = New Size(188, 51)
			Me.CBuilder.Name = "CBuilder"
			Me.CBuilder.QueryTransformer = Nothing
			Me.CBuilder.RootItemFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.CBuilder.RootJunctionPrefix = Nothing
			Me.CBuilder.Size = New Size(819, 51)
			Me.CBuilder.TabIndex = 1
			' 
			' teResultSql
			' 
			Me.teResultSql.BackColor = Color.LemonChiffon
			Me.teResultSql.Dock = DockStyle.Fill
			Me.teResultSql.Font = New Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.teResultSql.Location = New Point(0, 0)
			Me.teResultSql.Name = "teResultSql"
			Me.teResultSql.ReadOnly = True
			Me.teResultSql.Size = New Size(819, 91)
			Me.teResultSql.TabIndex = 0
			Me.teResultSql.Text = ""
			' 
			' contextMenuStripForRichTextBox
			' 
			Me.contextMenuStripForRichTextBox.Name = "contextMenuStripForRichTextBox"
			Me.contextMenuStripForRichTextBox.Size = New Size(61, 4)
'			Me.contextMenuStripForRichTextBox.Opening += New System.ComponentModel.CancelEventHandler(Me.contextMenuStripForRichTextBox_Opening)
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(833, 589)
			Me.Controls.Add(Me.tabControl1)
			Me.Controls.Add(Me.toolStripPanel2)
			Me.Controls.Add(Me.toolStripPanel1)
			Me.Font = New Font("Microsoft Sans Serif", 8.25F)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.IsMdiContainer = True
			Me.MainMenuStrip = Me.menuStrip1
			Me.MinimumSize = New Size(300, 300)
			Me.Name = "MainForm"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Active Query Builder for .NET WinForms Edition - Standard Full-featured demo (C#)" & ""
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.MainForm_FormClosing)
'			Me.Shown += New System.EventHandler(Me.MainForm_Shown)
			Me.toolStripPanel1.ResumeLayout(False)
			Me.toolStripPanel1.PerformLayout()
			Me.menuStrip1.ResumeLayout(False)
			Me.menuStrip1.PerformLayout()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.tabControl1.ResumeLayout(False)
			Me.pageQueryBuilder.ResumeLayout(False)
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.Panel2.PerformLayout()
			CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolStrip2.ResumeLayout(False)
			Me.toolStrip2.PerformLayout()
			Me.pageQueryResult.ResumeLayout(False)
			Me.splitContainer2.Panel1.ResumeLayout(False)
			Me.splitContainer2.Panel1.PerformLayout()
			Me.splitContainer2.Panel2.ResumeLayout(False)
			CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer2.ResumeLayout(False)
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
	End Class
