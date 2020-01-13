Namespace PropertiesForm
	Partial Class QueryPropertiesForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
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
			Me.panelButtons = New System.Windows.Forms.Panel()
			Me.buttonLoad = New System.Windows.Forms.Button()
			Me.buttonSave = New System.Windows.Forms.Button()
			Me.buttonCancel = New System.Windows.Forms.Button()
			Me.tabControl = New System.Windows.Forms.TabControl()
			Me.tabQueryBuilder = New System.Windows.Forms.TabPage()
			Me.panelQueryBuilder = New System.Windows.Forms.Panel()
			Me.panelPages1 = New System.Windows.Forms.Panel()
			Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
			Me.linkSqlGeneration = New System.Windows.Forms.LinkLabel()
			Me.linkBehaviorOptions = New System.Windows.Forms.LinkLabel()
			Me.linkDatabaseSchemaView = New System.Windows.Forms.LinkLabel()
			Me.linkDesignPane = New System.Windows.Forms.LinkLabel()
			Me.linkVisualOptions = New System.Windows.Forms.LinkLabel()
			Me.linkAddObjectDialog = New System.Windows.Forms.LinkLabel()
			Me.linkDatasourceOptions = New System.Windows.Forms.LinkLabel()
			Me.linkQueryColumnList = New System.Windows.Forms.LinkLabel()
			Me.linkQueryNavBar = New System.Windows.Forms.LinkLabel()
			Me.linkQueryView = New System.Windows.Forms.LinkLabel()
			Me.lbExpressionEditor = New System.Windows.Forms.LinkLabel()
			Me.lbTextEditor = New System.Windows.Forms.LinkLabel()
			Me.lbTextEditorSql = New System.Windows.Forms.LinkLabel()
			Me.tabFormatting = New System.Windows.Forms.TabPage()
			Me.panelSqlFormatting = New System.Windows.Forms.Panel()
			Me.panelPages2 = New System.Windows.Forms.Panel()
			Me.flowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
			Me.labelSqlFormatting = New System.Windows.Forms.Label()
			Me.linkMain = New System.Windows.Forms.LinkLabel()
			Me.linkMainCommon = New System.Windows.Forms.LinkLabel()
			Me.linkMainExpressions = New System.Windows.Forms.LinkLabel()
			Me.linkCte = New System.Windows.Forms.LinkLabel()
			Me.linkCteCommon = New System.Windows.Forms.LinkLabel()
			Me.linkCteExpressions = New System.Windows.Forms.LinkLabel()
			Me.linkDerived = New System.Windows.Forms.LinkLabel()
			Me.linkDerivedCommon = New System.Windows.Forms.LinkLabel()
			Me.linkDerivedExpressions = New System.Windows.Forms.LinkLabel()
			Me.linkExpression = New System.Windows.Forms.LinkLabel()
			Me.linkExpressionCommon = New System.Windows.Forms.LinkLabel()
			Me.linkExpressionExpressions = New System.Windows.Forms.LinkLabel()
			Me.panelButtons.SuspendLayout()
			Me.tabControl.SuspendLayout()
			Me.tabQueryBuilder.SuspendLayout()
			Me.panelQueryBuilder.SuspendLayout()
			Me.flowLayoutPanel1.SuspendLayout()
			Me.tabFormatting.SuspendLayout()
			Me.panelSqlFormatting.SuspendLayout()
			Me.flowLayoutPanel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panelButtons
			' 
			Me.panelButtons.Controls.Add(Me.buttonLoad)
			Me.panelButtons.Controls.Add(Me.buttonSave)
			Me.panelButtons.Controls.Add(Me.buttonCancel)
			Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelButtons.Location = New System.Drawing.Point(0, 439)
			Me.panelButtons.Name = "panelButtons"
			Me.panelButtons.Size = New System.Drawing.Size(781, 43)
			Me.panelButtons.TabIndex = 2
			' 
			' buttonLoad
			' 
			Me.buttonLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
			Me.buttonLoad.Location = New System.Drawing.Point(109, 10)
			Me.buttonLoad.Name = "buttonLoad"
			Me.buttonLoad.Size = New System.Drawing.Size(96, 23)
			Me.buttonLoad.TabIndex = 3
			Me.buttonLoad.Text = "Import..."
			Me.buttonLoad.UseVisualStyleBackColor = True
			AddHandler Me.buttonLoad.Click, New System.EventHandler(AddressOf Me.buttonLoad_Click)
			' 
			' buttonSave
			' 
			Me.buttonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
			Me.buttonSave.Location = New System.Drawing.Point(7, 10)
			Me.buttonSave.Name = "buttonSave"
			Me.buttonSave.Size = New System.Drawing.Size(96, 23)
			Me.buttonSave.TabIndex = 2
			Me.buttonSave.Text = "Export..."
			Me.buttonSave.UseVisualStyleBackColor = True
			AddHandler Me.buttonSave.Click, New System.EventHandler(AddressOf Me.buttonSave_Click)
			' 
			' buttonCancel
			' 
			Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.buttonCancel.Location = New System.Drawing.Point(694, 10)
			Me.buttonCancel.Name = "buttonCancel"
			Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
			Me.buttonCancel.TabIndex = 1
			Me.buttonCancel.Text = "Close"
			Me.buttonCancel.UseVisualStyleBackColor = True
			' 
			' tabControl
			' 
			Me.tabControl.Controls.Add(Me.tabQueryBuilder)
			Me.tabControl.Controls.Add(Me.tabFormatting)
			Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabControl.Location = New System.Drawing.Point(0, 0)
			Me.tabControl.Name = "tabControl"
			Me.tabControl.SelectedIndex = 0
			Me.tabControl.Size = New System.Drawing.Size(781, 439)
			Me.tabControl.TabIndex = 3
			' 
			' tabQueryBuilder
			' 
			Me.tabQueryBuilder.Controls.Add(Me.panelQueryBuilder)
			Me.tabQueryBuilder.Location = New System.Drawing.Point(4, 22)
			Me.tabQueryBuilder.Name = "tabQueryBuilder"
			Me.tabQueryBuilder.Padding = New System.Windows.Forms.Padding(3)
			Me.tabQueryBuilder.Size = New System.Drawing.Size(773, 413)
			Me.tabQueryBuilder.TabIndex = 0
			Me.tabQueryBuilder.Text = "QueryBuilder properties"
			Me.tabQueryBuilder.UseVisualStyleBackColor = True
			' 
			' panelQueryBuilder
			' 
			Me.panelQueryBuilder.Controls.Add(Me.panelPages1)
			Me.panelQueryBuilder.Controls.Add(Me.flowLayoutPanel1)
			Me.panelQueryBuilder.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelQueryBuilder.Location = New System.Drawing.Point(3, 3)
			Me.panelQueryBuilder.Name = "panelQueryBuilder"
			Me.panelQueryBuilder.Size = New System.Drawing.Size(767, 407)
			Me.panelQueryBuilder.TabIndex = 4
			' 
			' panelPages1
			' 
			Me.panelPages1.AutoScroll = True
			Me.panelPages1.AutoSize = True
			Me.panelPages1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.panelPages1.BackColor = System.Drawing.Color.White
			Me.panelPages1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelPages1.Location = New System.Drawing.Point(170, 0)
			Me.panelPages1.Margin = New System.Windows.Forms.Padding(0)
			Me.panelPages1.Name = "panelPages1"
			Me.panelPages1.Padding = New System.Windows.Forms.Padding(10, 10, 6, 6)
			Me.panelPages1.Size = New System.Drawing.Size(597, 407)
			Me.panelPages1.TabIndex = 7
			' 
			' flowLayoutPanel1
			' 
			Me.flowLayoutPanel1.AutoScroll = True
			Me.flowLayoutPanel1.BackColor = System.Drawing.Color.White
			Me.flowLayoutPanel1.Controls.Add(Me.linkSqlGeneration)
			Me.flowLayoutPanel1.Controls.Add(Me.linkBehaviorOptions)
			Me.flowLayoutPanel1.Controls.Add(Me.linkDatabaseSchemaView)
			Me.flowLayoutPanel1.Controls.Add(Me.linkDesignPane)
			Me.flowLayoutPanel1.Controls.Add(Me.linkVisualOptions)
			Me.flowLayoutPanel1.Controls.Add(Me.linkAddObjectDialog)
			Me.flowLayoutPanel1.Controls.Add(Me.linkDatasourceOptions)
			Me.flowLayoutPanel1.Controls.Add(Me.linkQueryColumnList)
			Me.flowLayoutPanel1.Controls.Add(Me.linkQueryNavBar)
			Me.flowLayoutPanel1.Controls.Add(Me.linkQueryView)
			Me.flowLayoutPanel1.Controls.Add(Me.lbExpressionEditor)
			Me.flowLayoutPanel1.Controls.Add(Me.lbTextEditor)
			Me.flowLayoutPanel1.Controls.Add(Me.lbTextEditorSql)
			Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
			Me.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
			Me.flowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
			Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
			Me.flowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
			Me.flowLayoutPanel1.Size = New System.Drawing.Size(170, 407)
			Me.flowLayoutPanel1.TabIndex = 6
			AddHandler Me.flowLayoutPanel1.Paint, New System.Windows.Forms.PaintEventHandler(AddressOf Me.flowLayoutPanel_Paint)
			' 
			' linkSqlGeneration
			' 
			Me.linkSqlGeneration.AutoSize = True
			Me.linkSqlGeneration.ForeColor = System.Drawing.Color.Black
			Me.linkSqlGeneration.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkSqlGeneration.LinkColor = System.Drawing.Color.Black
			Me.linkSqlGeneration.Location = New System.Drawing.Point(0, 10)
			Me.linkSqlGeneration.Margin = New System.Windows.Forms.Padding(0)
			Me.linkSqlGeneration.Name = "linkSqlGeneration"
			Me.linkSqlGeneration.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.linkSqlGeneration.Size = New System.Drawing.Size(141, 23)
			Me.linkSqlGeneration.TabIndex = 28
			Me.linkSqlGeneration.TabStop = True
			Me.linkSqlGeneration.Text = "SQL Generation Options"
			Me.linkSqlGeneration.UseCompatibleTextRendering = True
			Me.linkSqlGeneration.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkSqlGeneration.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' linkBehaviorOptions
			' 
			Me.linkBehaviorOptions.AutoSize = True
			Me.linkBehaviorOptions.ForeColor = System.Drawing.Color.Black
			Me.linkBehaviorOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkBehaviorOptions.LinkColor = System.Drawing.Color.Black
			Me.linkBehaviorOptions.Location = New System.Drawing.Point(0, 33)
			Me.linkBehaviorOptions.Margin = New System.Windows.Forms.Padding(0)
			Me.linkBehaviorOptions.Name = "linkBehaviorOptions"
			Me.linkBehaviorOptions.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.linkBehaviorOptions.Size = New System.Drawing.Size(104, 23)
			Me.linkBehaviorOptions.TabIndex = 15
			Me.linkBehaviorOptions.TabStop = True
			Me.linkBehaviorOptions.Text = "Behavior Options"
			Me.linkBehaviorOptions.UseCompatibleTextRendering = True
			Me.linkBehaviorOptions.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkBehaviorOptions.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' linkDatabaseSchemaView
			' 
			Me.linkDatabaseSchemaView.AutoSize = True
			Me.linkDatabaseSchemaView.ForeColor = System.Drawing.Color.Black
			Me.linkDatabaseSchemaView.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkDatabaseSchemaView.LinkColor = System.Drawing.Color.Black
			Me.linkDatabaseSchemaView.Location = New System.Drawing.Point(0, 56)
			Me.linkDatabaseSchemaView.Margin = New System.Windows.Forms.Padding(0)
			Me.linkDatabaseSchemaView.Name = "linkDatabaseSchemaView"
			Me.linkDatabaseSchemaView.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.linkDatabaseSchemaView.Size = New System.Drawing.Size(135, 36)
			Me.linkDatabaseSchemaView.TabIndex = 18
			Me.linkDatabaseSchemaView.TabStop = True
			Me.linkDatabaseSchemaView.Text = "DatabaseSchemaView Options"
			Me.linkDatabaseSchemaView.UseCompatibleTextRendering = True
			Me.linkDatabaseSchemaView.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkDatabaseSchemaView.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' linkDesignPane
			' 
			Me.linkDesignPane.AutoSize = True
			Me.linkDesignPane.ForeColor = System.Drawing.Color.Black
			Me.linkDesignPane.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkDesignPane.LinkColor = System.Drawing.Color.Black
			Me.linkDesignPane.Location = New System.Drawing.Point(0, 92)
			Me.linkDesignPane.Margin = New System.Windows.Forms.Padding(0)
			Me.linkDesignPane.Name = "linkDesignPane"
			Me.linkDesignPane.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.linkDesignPane.Size = New System.Drawing.Size(121, 23)
			Me.linkDesignPane.TabIndex = 19
			Me.linkDesignPane.TabStop = True
			Me.linkDesignPane.Text = "DesignPane Options"
			Me.linkDesignPane.UseCompatibleTextRendering = True
			Me.linkDesignPane.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkDesignPane.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' linkVisualOptions
			' 
			Me.linkVisualOptions.AutoSize = True
			Me.linkVisualOptions.ForeColor = System.Drawing.Color.Black
			Me.linkVisualOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkVisualOptions.LinkColor = System.Drawing.Color.Black
			Me.linkVisualOptions.Location = New System.Drawing.Point(0, 115)
			Me.linkVisualOptions.Margin = New System.Windows.Forms.Padding(0)
			Me.linkVisualOptions.Name = "linkVisualOptions"
			Me.linkVisualOptions.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.linkVisualOptions.Size = New System.Drawing.Size(90, 23)
			Me.linkVisualOptions.TabIndex = 20
			Me.linkVisualOptions.TabStop = True
			Me.linkVisualOptions.Text = "Visual Options"
			Me.linkVisualOptions.UseCompatibleTextRendering = True
			Me.linkVisualOptions.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkVisualOptions.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' linkAddObjectDialog
			' 
			Me.linkAddObjectDialog.AutoSize = True
			Me.linkAddObjectDialog.ForeColor = System.Drawing.Color.Black
			Me.linkAddObjectDialog.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkAddObjectDialog.LinkColor = System.Drawing.Color.Black
			Me.linkAddObjectDialog.Location = New System.Drawing.Point(0, 138)
			Me.linkAddObjectDialog.Margin = New System.Windows.Forms.Padding(0)
			Me.linkAddObjectDialog.Name = "linkAddObjectDialog"
			Me.linkAddObjectDialog.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.linkAddObjectDialog.Size = New System.Drawing.Size(148, 23)
			Me.linkAddObjectDialog.TabIndex = 21
			Me.linkAddObjectDialog.TabStop = True
			Me.linkAddObjectDialog.Text = "AddObject Dialog Options"
			Me.linkAddObjectDialog.UseCompatibleTextRendering = True
			Me.linkAddObjectDialog.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkAddObjectDialog.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' linkDatasourceOptions
			' 
			Me.linkDatasourceOptions.AutoSize = True
			Me.linkDatasourceOptions.ForeColor = System.Drawing.Color.Black
			Me.linkDatasourceOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkDatasourceOptions.LinkColor = System.Drawing.Color.Black
			Me.linkDatasourceOptions.Location = New System.Drawing.Point(0, 161)
			Me.linkDatasourceOptions.Margin = New System.Windows.Forms.Padding(0)
			Me.linkDatasourceOptions.Name = "linkDatasourceOptions"
			Me.linkDatasourceOptions.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.linkDatasourceOptions.Size = New System.Drawing.Size(117, 23)
			Me.linkDatasourceOptions.TabIndex = 22
			Me.linkDatasourceOptions.TabStop = True
			Me.linkDatasourceOptions.Text = "Datasource Options"
			Me.linkDatasourceOptions.UseCompatibleTextRendering = True
			Me.linkDatasourceOptions.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkDatasourceOptions.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' linkQueryColumnList
			' 
			Me.linkQueryColumnList.AutoSize = True
			Me.linkQueryColumnList.ForeColor = System.Drawing.Color.Black
			Me.linkQueryColumnList.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkQueryColumnList.LinkColor = System.Drawing.Color.Black
			Me.linkQueryColumnList.Location = New System.Drawing.Point(0, 184)
			Me.linkQueryColumnList.Margin = New System.Windows.Forms.Padding(0)
			Me.linkQueryColumnList.Name = "linkQueryColumnList"
			Me.linkQueryColumnList.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.linkQueryColumnList.Size = New System.Drawing.Size(153, 23)
			Me.linkQueryColumnList.TabIndex = 25
			Me.linkQueryColumnList.TabStop = True
			Me.linkQueryColumnList.Text = "QueryColumnsList Options"
			Me.linkQueryColumnList.UseCompatibleTextRendering = True
			Me.linkQueryColumnList.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkQueryColumnList.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' linkQueryNavBar
			' 
			Me.linkQueryNavBar.AutoSize = True
			Me.linkQueryNavBar.ForeColor = System.Drawing.Color.Black
			Me.linkQueryNavBar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkQueryNavBar.LinkColor = System.Drawing.Color.Black
			Me.linkQueryNavBar.Location = New System.Drawing.Point(0, 207)
			Me.linkQueryNavBar.Margin = New System.Windows.Forms.Padding(0)
			Me.linkQueryNavBar.Name = "linkQueryNavBar"
			Me.linkQueryNavBar.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.linkQueryNavBar.Size = New System.Drawing.Size(128, 23)
			Me.linkQueryNavBar.TabIndex = 26
			Me.linkQueryNavBar.TabStop = True
			Me.linkQueryNavBar.Text = "QueryNavBar Options"
			Me.linkQueryNavBar.UseCompatibleTextRendering = True
			Me.linkQueryNavBar.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkQueryNavBar.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' linkQueryView
			' 
			Me.linkQueryView.AutoSize = True
			Me.linkQueryView.ForeColor = System.Drawing.Color.Black
			Me.linkQueryView.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkQueryView.LinkColor = System.Drawing.Color.Black
			Me.linkQueryView.Location = New System.Drawing.Point(0, 230)
			Me.linkQueryView.Margin = New System.Windows.Forms.Padding(0)
			Me.linkQueryView.Name = "linkQueryView"
			Me.linkQueryView.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.linkQueryView.Size = New System.Drawing.Size(127, 23)
			Me.linkQueryView.TabIndex = 27
			Me.linkQueryView.TabStop = True
			Me.linkQueryView.Text = "UserInterface Options"
			Me.linkQueryView.UseCompatibleTextRendering = True
			Me.linkQueryView.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkQueryView.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' lbExpressionEditor
			' 
			Me.lbExpressionEditor.AutoSize = True
			Me.lbExpressionEditor.ForeColor = System.Drawing.Color.Black
			Me.lbExpressionEditor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.lbExpressionEditor.LinkColor = System.Drawing.Color.Black
			Me.lbExpressionEditor.Location = New System.Drawing.Point(0, 253)
			Me.lbExpressionEditor.Margin = New System.Windows.Forms.Padding(0)
			Me.lbExpressionEditor.Name = "lbExpressionEditor"
			Me.lbExpressionEditor.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.lbExpressionEditor.Size = New System.Drawing.Size(148, 23)
			Me.lbExpressionEditor.TabIndex = 29
			Me.lbExpressionEditor.TabStop = True
			Me.lbExpressionEditor.Text = "Expression Editor Options"
			Me.lbExpressionEditor.UseCompatibleTextRendering = True
			Me.lbExpressionEditor.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.lbExpressionEditor.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' lbTextEditor
			' 
			Me.lbTextEditor.AutoSize = True
			Me.lbTextEditor.ForeColor = System.Drawing.Color.Black
			Me.lbTextEditor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.lbTextEditor.LinkColor = System.Drawing.Color.Black
			Me.lbTextEditor.Location = New System.Drawing.Point(0, 276)
			Me.lbTextEditor.Margin = New System.Windows.Forms.Padding(0)
			Me.lbTextEditor.Name = "lbTextEditor"
			Me.lbTextEditor.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.lbTextEditor.Size = New System.Drawing.Size(148, 23)
			Me.lbTextEditor.TabIndex = 30
			Me.lbTextEditor.TabStop = True
			Me.lbTextEditor.Text = "Text Editor Visual Options"
			Me.lbTextEditor.UseCompatibleTextRendering = True
			Me.lbTextEditor.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.lbTextEditor.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' lbTextEditorSql
			' 
			Me.lbTextEditorSql.AutoSize = True
			Me.lbTextEditorSql.ForeColor = System.Drawing.Color.Black
			Me.lbTextEditorSql.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.lbTextEditorSql.LinkColor = System.Drawing.Color.Black
			Me.lbTextEditorSql.Location = New System.Drawing.Point(0, 299)
			Me.lbTextEditorSql.Margin = New System.Windows.Forms.Padding(0)
			Me.lbTextEditorSql.Name = "lbTextEditorSql"
			Me.lbTextEditorSql.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.lbTextEditorSql.Size = New System.Drawing.Size(140, 23)
			Me.lbTextEditorSql.TabIndex = 31
			Me.lbTextEditorSql.TabStop = True
			Me.lbTextEditorSql.Text = "Text Editor SQL Options"
			Me.lbTextEditorSql.UseCompatibleTextRendering = True
			Me.lbTextEditorSql.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.lbTextEditorSql.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu1_LinkClicked)
			' 
			' tabFormatting
			' 
			Me.tabFormatting.Controls.Add(Me.panelSqlFormatting)
			Me.tabFormatting.Location = New System.Drawing.Point(4, 22)
			Me.tabFormatting.Name = "tabFormatting"
			Me.tabFormatting.Padding = New System.Windows.Forms.Padding(3)
			Me.tabFormatting.Size = New System.Drawing.Size(716, 417)
			Me.tabFormatting.TabIndex = 1
			Me.tabFormatting.Text = "SQL Formatting properties"
			Me.tabFormatting.UseVisualStyleBackColor = True
			' 
			' panelSqlFormatting
			' 
			Me.panelSqlFormatting.Controls.Add(Me.panelPages2)
			Me.panelSqlFormatting.Controls.Add(Me.flowLayoutPanel2)
			Me.panelSqlFormatting.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelSqlFormatting.Location = New System.Drawing.Point(3, 3)
			Me.panelSqlFormatting.Name = "panelSqlFormatting"
			Me.panelSqlFormatting.Size = New System.Drawing.Size(710, 411)
			Me.panelSqlFormatting.TabIndex = 4
			' 
			' panelPages2
			' 
			Me.panelPages2.AutoScroll = True
			Me.panelPages2.AutoSize = True
			Me.panelPages2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.panelPages2.BackColor = System.Drawing.Color.White
			Me.panelPages2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelPages2.Location = New System.Drawing.Point(170, 0)
			Me.panelPages2.Margin = New System.Windows.Forms.Padding(0)
			Me.panelPages2.Name = "panelPages2"
			Me.panelPages2.Padding = New System.Windows.Forms.Padding(10, 10, 6, 6)
			Me.panelPages2.Size = New System.Drawing.Size(540, 411)
			Me.panelPages2.TabIndex = 7
			' 
			' flowLayoutPanel2
			' 
			Me.flowLayoutPanel2.BackColor = System.Drawing.Color.White
			Me.flowLayoutPanel2.Controls.Add(Me.labelSqlFormatting)
			Me.flowLayoutPanel2.Controls.Add(Me.linkMain)
			Me.flowLayoutPanel2.Controls.Add(Me.linkMainCommon)
			Me.flowLayoutPanel2.Controls.Add(Me.linkMainExpressions)
			Me.flowLayoutPanel2.Controls.Add(Me.linkCte)
			Me.flowLayoutPanel2.Controls.Add(Me.linkCteCommon)
			Me.flowLayoutPanel2.Controls.Add(Me.linkCteExpressions)
			Me.flowLayoutPanel2.Controls.Add(Me.linkDerived)
			Me.flowLayoutPanel2.Controls.Add(Me.linkDerivedCommon)
			Me.flowLayoutPanel2.Controls.Add(Me.linkDerivedExpressions)
			Me.flowLayoutPanel2.Controls.Add(Me.linkExpression)
			Me.flowLayoutPanel2.Controls.Add(Me.linkExpressionCommon)
			Me.flowLayoutPanel2.Controls.Add(Me.linkExpressionExpressions)
			Me.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
			Me.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
			Me.flowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
			Me.flowLayoutPanel2.Name = "flowLayoutPanel2"
			Me.flowLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
			Me.flowLayoutPanel2.Size = New System.Drawing.Size(170, 411)
			Me.flowLayoutPanel2.TabIndex = 6
			AddHandler Me.flowLayoutPanel2.Paint, New System.Windows.Forms.PaintEventHandler(AddressOf Me.flowLayoutPanel_Paint)
			' 
			' labelSqlFormatting
			' 
			Me.labelSqlFormatting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.labelSqlFormatting.AutoSize = True
			Me.labelSqlFormatting.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
			Me.labelSqlFormatting.Location = New System.Drawing.Point(0, 10)
			Me.labelSqlFormatting.Margin = New System.Windows.Forms.Padding(0)
			Me.labelSqlFormatting.Name = "labelSqlFormatting"
			Me.labelSqlFormatting.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.labelSqlFormatting.Size = New System.Drawing.Size(137, 24)
			Me.labelSqlFormatting.TabIndex = 10
			Me.labelSqlFormatting.Text = "SQL Options"
			Me.labelSqlFormatting.UseCompatibleTextRendering = True
			' 
			' linkMain
			' 
			Me.linkMain.AutoSize = True
			Me.linkMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
			Me.linkMain.ForeColor = System.Drawing.Color.Black
			Me.linkMain.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkMain.LinkColor = System.Drawing.Color.Black
			Me.linkMain.Location = New System.Drawing.Point(0, 34)
			Me.linkMain.Margin = New System.Windows.Forms.Padding(0)
			Me.linkMain.Name = "linkMain"
			Me.linkMain.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkMain.Size = New System.Drawing.Size(85, 23)
			Me.linkMain.TabIndex = 26
			Me.linkMain.TabStop = True
			Me.linkMain.Text = "Main query"
			Me.linkMain.UseCompatibleTextRendering = True
			Me.linkMain.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkMain.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu2_LinkClicked)
			' 
			' linkMainCommon
			' 
			Me.linkMainCommon.AutoSize = True
			Me.linkMainCommon.ForeColor = System.Drawing.Color.Black
			Me.linkMainCommon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkMainCommon.LinkColor = System.Drawing.Color.Black
			Me.linkMainCommon.Location = New System.Drawing.Point(0, 57)
			Me.linkMainCommon.Margin = New System.Windows.Forms.Padding(0)
			Me.linkMainCommon.Name = "linkMainCommon"
			Me.linkMainCommon.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkMainCommon.Size = New System.Drawing.Size(85, 23)
			Me.linkMainCommon.TabIndex = 27
			Me.linkMainCommon.TabStop = True
			Me.linkMainCommon.Text = "    Common"
			Me.linkMainCommon.UseCompatibleTextRendering = True
			Me.linkMainCommon.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkMainCommon.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu2_LinkClicked)
			' 
			' linkMainExpressions
			' 
			Me.linkMainExpressions.AutoSize = True
			Me.linkMainExpressions.ForeColor = System.Drawing.Color.Black
			Me.linkMainExpressions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkMainExpressions.LinkColor = System.Drawing.Color.Black
			Me.linkMainExpressions.Location = New System.Drawing.Point(0, 80)
			Me.linkMainExpressions.Margin = New System.Windows.Forms.Padding(0)
			Me.linkMainExpressions.Name = "linkMainExpressions"
			Me.linkMainExpressions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkMainExpressions.Size = New System.Drawing.Size(101, 23)
			Me.linkMainExpressions.TabIndex = 28
			Me.linkMainExpressions.TabStop = True
			Me.linkMainExpressions.Text = "    Expressions"
			Me.linkMainExpressions.UseCompatibleTextRendering = True
			Me.linkMainExpressions.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkMainExpressions.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu2_LinkClicked)
			' 
			' linkCte
			' 
			Me.linkCte.AutoSize = True
			Me.linkCte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
			Me.linkCte.ForeColor = System.Drawing.Color.Black
			Me.linkCte.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkCte.LinkColor = System.Drawing.Color.Black
			Me.linkCte.Location = New System.Drawing.Point(0, 103)
			Me.linkCte.Margin = New System.Windows.Forms.Padding(0)
			Me.linkCte.Name = "linkCte"
			Me.linkCte.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkCte.Size = New System.Drawing.Size(83, 23)
			Me.linkCte.TabIndex = 29
			Me.linkCte.TabStop = True
			Me.linkCte.Text = "CTE query"
			Me.linkCte.UseCompatibleTextRendering = True
			Me.linkCte.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkCte.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu2_LinkClicked)
			' 
			' linkCteCommon
			' 
			Me.linkCteCommon.AutoSize = True
			Me.linkCteCommon.ForeColor = System.Drawing.Color.Black
			Me.linkCteCommon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkCteCommon.LinkColor = System.Drawing.Color.Black
			Me.linkCteCommon.Location = New System.Drawing.Point(0, 126)
			Me.linkCteCommon.Margin = New System.Windows.Forms.Padding(0)
			Me.linkCteCommon.Name = "linkCteCommon"
			Me.linkCteCommon.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkCteCommon.Size = New System.Drawing.Size(85, 23)
			Me.linkCteCommon.TabIndex = 30
			Me.linkCteCommon.TabStop = True
			Me.linkCteCommon.Text = "    Common"
			Me.linkCteCommon.UseCompatibleTextRendering = True
			Me.linkCteCommon.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkCteCommon.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu2_LinkClicked)
			' 
			' linkCteExpressions
			' 
			Me.linkCteExpressions.AutoSize = True
			Me.linkCteExpressions.ForeColor = System.Drawing.Color.Black
			Me.linkCteExpressions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkCteExpressions.LinkColor = System.Drawing.Color.Black
			Me.linkCteExpressions.Location = New System.Drawing.Point(0, 149)
			Me.linkCteExpressions.Margin = New System.Windows.Forms.Padding(0)
			Me.linkCteExpressions.Name = "linkCteExpressions"
			Me.linkCteExpressions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkCteExpressions.Size = New System.Drawing.Size(101, 23)
			Me.linkCteExpressions.TabIndex = 31
			Me.linkCteExpressions.TabStop = True
			Me.linkCteExpressions.Text = "    Expressions"
			Me.linkCteExpressions.UseCompatibleTextRendering = True
			Me.linkCteExpressions.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkCteExpressions.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu2_LinkClicked)
			' 
			' linkDerived
			' 
			Me.linkDerived.AutoSize = True
			Me.linkDerived.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
			Me.linkDerived.ForeColor = System.Drawing.Color.Black
			Me.linkDerived.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkDerived.LinkColor = System.Drawing.Color.Black
			Me.linkDerived.Location = New System.Drawing.Point(0, 172)
			Me.linkDerived.Margin = New System.Windows.Forms.Padding(0)
			Me.linkDerived.Name = "linkDerived"
			Me.linkDerived.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkDerived.Size = New System.Drawing.Size(100, 23)
			Me.linkDerived.TabIndex = 32
			Me.linkDerived.TabStop = True
			Me.linkDerived.Text = "Derived query"
			Me.linkDerived.UseCompatibleTextRendering = True
			Me.linkDerived.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkDerived.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu2_LinkClicked)
			' 
			' linkDerivedCommon
			' 
			Me.linkDerivedCommon.AutoSize = True
			Me.linkDerivedCommon.ForeColor = System.Drawing.Color.Black
			Me.linkDerivedCommon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkDerivedCommon.LinkColor = System.Drawing.Color.Black
			Me.linkDerivedCommon.Location = New System.Drawing.Point(0, 195)
			Me.linkDerivedCommon.Margin = New System.Windows.Forms.Padding(0)
			Me.linkDerivedCommon.Name = "linkDerivedCommon"
			Me.linkDerivedCommon.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkDerivedCommon.Size = New System.Drawing.Size(85, 23)
			Me.linkDerivedCommon.TabIndex = 33
			Me.linkDerivedCommon.TabStop = True
			Me.linkDerivedCommon.Text = "    Common"
			Me.linkDerivedCommon.UseCompatibleTextRendering = True
			Me.linkDerivedCommon.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkDerivedCommon.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu2_LinkClicked)
			' 
			' linkDerivedExpressions
			' 
			Me.linkDerivedExpressions.AutoSize = True
			Me.linkDerivedExpressions.ForeColor = System.Drawing.Color.Black
			Me.linkDerivedExpressions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkDerivedExpressions.LinkColor = System.Drawing.Color.Black
			Me.linkDerivedExpressions.Location = New System.Drawing.Point(0, 218)
			Me.linkDerivedExpressions.Margin = New System.Windows.Forms.Padding(0)
			Me.linkDerivedExpressions.Name = "linkDerivedExpressions"
			Me.linkDerivedExpressions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkDerivedExpressions.Size = New System.Drawing.Size(101, 23)
			Me.linkDerivedExpressions.TabIndex = 34
			Me.linkDerivedExpressions.TabStop = True
			Me.linkDerivedExpressions.Text = "    Expressions"
			Me.linkDerivedExpressions.UseCompatibleTextRendering = True
			Me.linkDerivedExpressions.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkDerivedExpressions.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu2_LinkClicked)
			' 
			' linkExpression
			' 
			Me.linkExpression.AutoSize = True
			Me.linkExpression.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
			Me.linkExpression.ForeColor = System.Drawing.Color.Black
			Me.linkExpression.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkExpression.LinkColor = System.Drawing.Color.Black
			Me.linkExpression.Location = New System.Drawing.Point(0, 241)
			Me.linkExpression.Margin = New System.Windows.Forms.Padding(0)
			Me.linkExpression.Name = "linkExpression"
			Me.linkExpression.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkExpression.Size = New System.Drawing.Size(137, 23)
			Me.linkExpression.TabIndex = 35
			Me.linkExpression.TabStop = True
			Me.linkExpression.Text = "Expression subquery"
			Me.linkExpression.UseCompatibleTextRendering = True
			Me.linkExpression.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkExpression.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu2_LinkClicked)
			' 
			' linkExpressionCommon
			' 
			Me.linkExpressionCommon.AutoSize = True
			Me.linkExpressionCommon.ForeColor = System.Drawing.Color.Black
			Me.linkExpressionCommon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkExpressionCommon.LinkColor = System.Drawing.Color.Black
			Me.linkExpressionCommon.Location = New System.Drawing.Point(0, 264)
			Me.linkExpressionCommon.Margin = New System.Windows.Forms.Padding(0)
			Me.linkExpressionCommon.Name = "linkExpressionCommon"
			Me.linkExpressionCommon.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkExpressionCommon.Size = New System.Drawing.Size(85, 23)
			Me.linkExpressionCommon.TabIndex = 36
			Me.linkExpressionCommon.TabStop = True
			Me.linkExpressionCommon.Text = "    Common"
			Me.linkExpressionCommon.UseCompatibleTextRendering = True
			Me.linkExpressionCommon.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkExpressionCommon.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu2_LinkClicked)
			' 
			' linkExpressionExpressions
			' 
			Me.linkExpressionExpressions.AutoSize = True
			Me.linkExpressionExpressions.ForeColor = System.Drawing.Color.Black
			Me.linkExpressionExpressions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkExpressionExpressions.LinkColor = System.Drawing.Color.Black
			Me.linkExpressionExpressions.Location = New System.Drawing.Point(0, 287)
			Me.linkExpressionExpressions.Margin = New System.Windows.Forms.Padding(0)
			Me.linkExpressionExpressions.Name = "linkExpressionExpressions"
			Me.linkExpressionExpressions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkExpressionExpressions.Size = New System.Drawing.Size(101, 23)
			Me.linkExpressionExpressions.TabIndex = 37
			Me.linkExpressionExpressions.TabStop = True
			Me.linkExpressionExpressions.Text = "    Expressions"
			Me.linkExpressionExpressions.UseCompatibleTextRendering = True
			Me.linkExpressionExpressions.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkExpressionExpressions.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu2_LinkClicked)
			' 
			' QueryPropertiesForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.buttonCancel
			Me.ClientSize = New System.Drawing.Size(781, 482)
			Me.Controls.Add(Me.tabControl)
			Me.Controls.Add(Me.panelButtons)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "QueryPropertiesForm"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Properties"
			AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.QueryPropertiesForm_FormClosing)
			AddHandler Me.Paint, New System.Windows.Forms.PaintEventHandler(AddressOf Me.QueryBuilderPropertiesForm_Paint)
			Me.panelButtons.ResumeLayout(False)
			Me.tabControl.ResumeLayout(False)
			Me.tabQueryBuilder.ResumeLayout(False)
			Me.panelQueryBuilder.ResumeLayout(False)
			Me.panelQueryBuilder.PerformLayout()
			Me.flowLayoutPanel1.ResumeLayout(False)
			Me.flowLayoutPanel1.PerformLayout()
			Me.tabFormatting.ResumeLayout(False)
			Me.panelSqlFormatting.ResumeLayout(False)
			Me.panelSqlFormatting.PerformLayout()
			Me.flowLayoutPanel2.ResumeLayout(False)
			Me.flowLayoutPanel2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelButtons As System.Windows.Forms.Panel
		Private buttonCancel As System.Windows.Forms.Button
		Private tabControl As System.Windows.Forms.TabControl
		Private tabQueryBuilder As System.Windows.Forms.TabPage
		Private panelQueryBuilder As System.Windows.Forms.Panel
		Private panelPages1 As System.Windows.Forms.Panel
		Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
		Private linkBehaviorOptions As System.Windows.Forms.LinkLabel
		Private linkDatabaseSchemaView As System.Windows.Forms.LinkLabel
		Private linkDesignPane As System.Windows.Forms.LinkLabel
		Private linkVisualOptions As System.Windows.Forms.LinkLabel
		Private linkAddObjectDialog As System.Windows.Forms.LinkLabel
		Private linkDatasourceOptions As System.Windows.Forms.LinkLabel
		Private linkQueryColumnList As System.Windows.Forms.LinkLabel
		Private tabFormatting As System.Windows.Forms.TabPage
		Private panelSqlFormatting As System.Windows.Forms.Panel
		Private panelPages2 As System.Windows.Forms.Panel
		Private flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
		Private labelSqlFormatting As System.Windows.Forms.Label
		Private linkMain As System.Windows.Forms.LinkLabel
		Private linkMainCommon As System.Windows.Forms.LinkLabel
		Private linkMainExpressions As System.Windows.Forms.LinkLabel
		Private linkCte As System.Windows.Forms.LinkLabel
		Private linkCteCommon As System.Windows.Forms.LinkLabel
		Private linkCteExpressions As System.Windows.Forms.LinkLabel
		Private linkDerived As System.Windows.Forms.LinkLabel
		Private linkDerivedCommon As System.Windows.Forms.LinkLabel
		Private linkDerivedExpressions As System.Windows.Forms.LinkLabel
		Private linkExpression As System.Windows.Forms.LinkLabel
		Private linkExpressionCommon As System.Windows.Forms.LinkLabel
		Private linkExpressionExpressions As System.Windows.Forms.LinkLabel
		Private buttonSave As System.Windows.Forms.Button
		Private buttonLoad As System.Windows.Forms.Button
		Private linkQueryNavBar As System.Windows.Forms.LinkLabel
		Private linkQueryView As System.Windows.Forms.LinkLabel
		Private linkSqlGeneration As System.Windows.Forms.LinkLabel
		Private lbExpressionEditor As System.Windows.Forms.LinkLabel
		Private lbTextEditor As System.Windows.Forms.LinkLabel
		Private lbTextEditorSql As System.Windows.Forms.LinkLabel
	End Class
End Namespace
