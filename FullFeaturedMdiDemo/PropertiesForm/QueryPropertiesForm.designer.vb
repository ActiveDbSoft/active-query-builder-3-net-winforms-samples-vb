Namespace PropertiesForm
	Partial Friend Class QueryPropertiesForm
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
			Me.panelButtons = New Panel()
			Me.buttonLoad = New Button()
			Me.buttonSave = New Button()
			Me.buttonCancel = New Button()
			Me.tabControl = New TabControl()
			Me.tabQueryBuilder = New TabPage()
			Me.panelQueryBuilder = New Panel()
			Me.panelPages1 = New Panel()
			Me.flowLayoutPanel1 = New FlowLayoutPanel()
			Me.linkSqlGeneration = New LinkLabel()
			Me.linkBehaviorOptions = New LinkLabel()
			Me.linkDatabaseSchemaView = New LinkLabel()
			Me.linkDesignPane = New LinkLabel()
			Me.linkVisualOptions = New LinkLabel()
			Me.linkAddObjectDialog = New LinkLabel()
			Me.linkDatasourceOptions = New LinkLabel()
			Me.linkQueryColumnList = New LinkLabel()
			Me.linkQueryNavBar = New LinkLabel()
			Me.linkQueryView = New LinkLabel()
			Me.lbExpressionEditor = New LinkLabel()
			Me.lbTextEditor = New LinkLabel()
			Me.lbTextEditorSql = New LinkLabel()
			Me.tabFormatting = New TabPage()
			Me.panelSqlFormatting = New Panel()
			Me.panelPages2 = New Panel()
			Me.flowLayoutPanel2 = New FlowLayoutPanel()
			Me.labelSqlFormatting = New Label()
			Me.linkMain = New LinkLabel()
			Me.linkMainCommon = New LinkLabel()
			Me.linkMainExpressions = New LinkLabel()
			Me.linkCte = New LinkLabel()
			Me.linkCteCommon = New LinkLabel()
			Me.linkCteExpressions = New LinkLabel()
			Me.linkDerived = New LinkLabel()
			Me.linkDerivedCommon = New LinkLabel()
			Me.linkDerivedExpressions = New LinkLabel()
			Me.linkExpression = New LinkLabel()
			Me.linkExpressionCommon = New LinkLabel()
			Me.linkExpressionExpressions = New LinkLabel()
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
			Me.panelButtons.Dock = DockStyle.Bottom
			Me.panelButtons.Location = New Point(0, 439)
			Me.panelButtons.Name = "panelButtons"
			Me.panelButtons.Size = New Size(781, 43)
			Me.panelButtons.TabIndex = 2
			' 
			' buttonLoad
			' 
			Me.buttonLoad.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
			Me.buttonLoad.Location = New Point(109, 10)
			Me.buttonLoad.Name = "buttonLoad"
			Me.buttonLoad.Size = New Size(96, 23)
			Me.buttonLoad.TabIndex = 3
			Me.buttonLoad.Text = "Import..."
			Me.buttonLoad.UseVisualStyleBackColor = True
'			Me.buttonLoad.Click += New System.EventHandler(Me.buttonLoad_Click)
			' 
			' buttonSave
			' 
			Me.buttonSave.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
			Me.buttonSave.Location = New Point(7, 10)
			Me.buttonSave.Name = "buttonSave"
			Me.buttonSave.Size = New Size(96, 23)
			Me.buttonSave.TabIndex = 2
			Me.buttonSave.Text = "Export..."
			Me.buttonSave.UseVisualStyleBackColor = True
'			Me.buttonSave.Click += New System.EventHandler(Me.buttonSave_Click)
			' 
			' buttonCancel
			' 
			Me.buttonCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.buttonCancel.DialogResult = DialogResult.OK
			Me.buttonCancel.Location = New Point(694, 10)
			Me.buttonCancel.Name = "buttonCancel"
			Me.buttonCancel.Size = New Size(75, 23)
			Me.buttonCancel.TabIndex = 1
			Me.buttonCancel.Text = "Close"
			Me.buttonCancel.UseVisualStyleBackColor = True
			' 
			' tabControl
			' 
			Me.tabControl.Controls.Add(Me.tabQueryBuilder)
			Me.tabControl.Controls.Add(Me.tabFormatting)
			Me.tabControl.Dock = DockStyle.Fill
			Me.tabControl.Location = New Point(0, 0)
			Me.tabControl.Name = "tabControl"
			Me.tabControl.SelectedIndex = 0
			Me.tabControl.Size = New Size(781, 439)
			Me.tabControl.TabIndex = 3
			' 
			' tabQueryBuilder
			' 
			Me.tabQueryBuilder.Controls.Add(Me.panelQueryBuilder)
			Me.tabQueryBuilder.Location = New Point(4, 22)
			Me.tabQueryBuilder.Name = "tabQueryBuilder"
			Me.tabQueryBuilder.Padding = New Padding(3)
			Me.tabQueryBuilder.Size = New Size(773, 413)
			Me.tabQueryBuilder.TabIndex = 0
			Me.tabQueryBuilder.Text = "QueryBuilder properties"
			Me.tabQueryBuilder.UseVisualStyleBackColor = True
			' 
			' panelQueryBuilder
			' 
			Me.panelQueryBuilder.Controls.Add(Me.panelPages1)
			Me.panelQueryBuilder.Controls.Add(Me.flowLayoutPanel1)
			Me.panelQueryBuilder.Dock = DockStyle.Fill
			Me.panelQueryBuilder.Location = New Point(3, 3)
			Me.panelQueryBuilder.Name = "panelQueryBuilder"
			Me.panelQueryBuilder.Size = New Size(767, 407)
			Me.panelQueryBuilder.TabIndex = 4
			' 
			' panelPages1
			' 
			Me.panelPages1.AutoScroll = True
			Me.panelPages1.AutoSize = True
			Me.panelPages1.AutoSizeMode = AutoSizeMode.GrowAndShrink
			Me.panelPages1.BackColor = Color.White
			Me.panelPages1.Dock = DockStyle.Fill
			Me.panelPages1.Location = New Point(170, 0)
			Me.panelPages1.Margin = New Padding(0)
			Me.panelPages1.Name = "panelPages1"
			Me.panelPages1.Padding = New Padding(10, 10, 6, 6)
			Me.panelPages1.Size = New Size(597, 407)
			Me.panelPages1.TabIndex = 7
			' 
			' flowLayoutPanel1
			' 
			Me.flowLayoutPanel1.AutoScroll = True
			Me.flowLayoutPanel1.BackColor = Color.White
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
			Me.flowLayoutPanel1.Dock = DockStyle.Left
			Me.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown
			Me.flowLayoutPanel1.Location = New Point(0, 0)
			Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
			Me.flowLayoutPanel1.Padding = New Padding(0, 10, 0, 0)
			Me.flowLayoutPanel1.Size = New Size(170, 407)
			Me.flowLayoutPanel1.TabIndex = 6
'			Me.flowLayoutPanel1.Paint += New System.Windows.Forms.PaintEventHandler(Me.flowLayoutPanel_Paint)
			' 
			' linkSqlGeneration
			' 
			Me.linkSqlGeneration.AutoSize = True
			Me.linkSqlGeneration.ForeColor = Color.Black
			Me.linkSqlGeneration.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkSqlGeneration.LinkColor = Color.Black
			Me.linkSqlGeneration.Location = New Point(0, 10)
			Me.linkSqlGeneration.Margin = New Padding(0)
			Me.linkSqlGeneration.Name = "linkSqlGeneration"
			Me.linkSqlGeneration.Padding = New Padding(10, 3, 3, 3)
			Me.linkSqlGeneration.Size = New Size(141, 23)
			Me.linkSqlGeneration.TabIndex = 28
			Me.linkSqlGeneration.TabStop = True
			Me.linkSqlGeneration.Text = "SQL Generation Options"
			Me.linkSqlGeneration.UseCompatibleTextRendering = True
			Me.linkSqlGeneration.VisitedLinkColor = Color.Black
'			Me.linkSqlGeneration.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' linkBehaviorOptions
			' 
			Me.linkBehaviorOptions.AutoSize = True
			Me.linkBehaviorOptions.ForeColor = Color.Black
			Me.linkBehaviorOptions.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkBehaviorOptions.LinkColor = Color.Black
			Me.linkBehaviorOptions.Location = New Point(0, 33)
			Me.linkBehaviorOptions.Margin = New Padding(0)
			Me.linkBehaviorOptions.Name = "linkBehaviorOptions"
			Me.linkBehaviorOptions.Padding = New Padding(10, 3, 3, 3)
			Me.linkBehaviorOptions.Size = New Size(104, 23)
			Me.linkBehaviorOptions.TabIndex = 15
			Me.linkBehaviorOptions.TabStop = True
			Me.linkBehaviorOptions.Text = "Behavior Options"
			Me.linkBehaviorOptions.UseCompatibleTextRendering = True
			Me.linkBehaviorOptions.VisitedLinkColor = Color.Black
'			Me.linkBehaviorOptions.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' linkDatabaseSchemaView
			' 
			Me.linkDatabaseSchemaView.AutoSize = True
			Me.linkDatabaseSchemaView.ForeColor = Color.Black
			Me.linkDatabaseSchemaView.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkDatabaseSchemaView.LinkColor = Color.Black
			Me.linkDatabaseSchemaView.Location = New Point(0, 56)
			Me.linkDatabaseSchemaView.Margin = New Padding(0)
			Me.linkDatabaseSchemaView.Name = "linkDatabaseSchemaView"
			Me.linkDatabaseSchemaView.Padding = New Padding(10, 3, 3, 3)
			Me.linkDatabaseSchemaView.Size = New Size(135, 36)
			Me.linkDatabaseSchemaView.TabIndex = 18
			Me.linkDatabaseSchemaView.TabStop = True
			Me.linkDatabaseSchemaView.Text = "DatabaseSchemaView Options"
			Me.linkDatabaseSchemaView.UseCompatibleTextRendering = True
			Me.linkDatabaseSchemaView.VisitedLinkColor = Color.Black
'			Me.linkDatabaseSchemaView.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' linkDesignPane
			' 
			Me.linkDesignPane.AutoSize = True
			Me.linkDesignPane.ForeColor = Color.Black
			Me.linkDesignPane.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkDesignPane.LinkColor = Color.Black
			Me.linkDesignPane.Location = New Point(0, 92)
			Me.linkDesignPane.Margin = New Padding(0)
			Me.linkDesignPane.Name = "linkDesignPane"
			Me.linkDesignPane.Padding = New Padding(10, 3, 3, 3)
			Me.linkDesignPane.Size = New Size(121, 23)
			Me.linkDesignPane.TabIndex = 19
			Me.linkDesignPane.TabStop = True
			Me.linkDesignPane.Text = "DesignPane Options"
			Me.linkDesignPane.UseCompatibleTextRendering = True
			Me.linkDesignPane.VisitedLinkColor = Color.Black
'			Me.linkDesignPane.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' linkVisualOptions
			' 
			Me.linkVisualOptions.AutoSize = True
			Me.linkVisualOptions.ForeColor = Color.Black
			Me.linkVisualOptions.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkVisualOptions.LinkColor = Color.Black
			Me.linkVisualOptions.Location = New Point(0, 115)
			Me.linkVisualOptions.Margin = New Padding(0)
			Me.linkVisualOptions.Name = "linkVisualOptions"
			Me.linkVisualOptions.Padding = New Padding(10, 3, 3, 3)
			Me.linkVisualOptions.Size = New Size(90, 23)
			Me.linkVisualOptions.TabIndex = 20
			Me.linkVisualOptions.TabStop = True
			Me.linkVisualOptions.Text = "Visual Options"
			Me.linkVisualOptions.UseCompatibleTextRendering = True
			Me.linkVisualOptions.VisitedLinkColor = Color.Black
'			Me.linkVisualOptions.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' linkAddObjectDialog
			' 
			Me.linkAddObjectDialog.AutoSize = True
			Me.linkAddObjectDialog.ForeColor = Color.Black
			Me.linkAddObjectDialog.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkAddObjectDialog.LinkColor = Color.Black
			Me.linkAddObjectDialog.Location = New Point(0, 138)
			Me.linkAddObjectDialog.Margin = New Padding(0)
			Me.linkAddObjectDialog.Name = "linkAddObjectDialog"
			Me.linkAddObjectDialog.Padding = New Padding(10, 3, 3, 3)
			Me.linkAddObjectDialog.Size = New Size(148, 23)
			Me.linkAddObjectDialog.TabIndex = 21
			Me.linkAddObjectDialog.TabStop = True
			Me.linkAddObjectDialog.Text = "AddObject Dialog Options"
			Me.linkAddObjectDialog.UseCompatibleTextRendering = True
			Me.linkAddObjectDialog.VisitedLinkColor = Color.Black
'			Me.linkAddObjectDialog.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' linkDatasourceOptions
			' 
			Me.linkDatasourceOptions.AutoSize = True
			Me.linkDatasourceOptions.ForeColor = Color.Black
			Me.linkDatasourceOptions.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkDatasourceOptions.LinkColor = Color.Black
			Me.linkDatasourceOptions.Location = New Point(0, 161)
			Me.linkDatasourceOptions.Margin = New Padding(0)
			Me.linkDatasourceOptions.Name = "linkDatasourceOptions"
			Me.linkDatasourceOptions.Padding = New Padding(10, 3, 3, 3)
			Me.linkDatasourceOptions.Size = New Size(117, 23)
			Me.linkDatasourceOptions.TabIndex = 22
			Me.linkDatasourceOptions.TabStop = True
			Me.linkDatasourceOptions.Text = "Datasource Options"
			Me.linkDatasourceOptions.UseCompatibleTextRendering = True
			Me.linkDatasourceOptions.VisitedLinkColor = Color.Black
'			Me.linkDatasourceOptions.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' linkQueryColumnList
			' 
			Me.linkQueryColumnList.AutoSize = True
			Me.linkQueryColumnList.ForeColor = Color.Black
			Me.linkQueryColumnList.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkQueryColumnList.LinkColor = Color.Black
			Me.linkQueryColumnList.Location = New Point(0, 184)
			Me.linkQueryColumnList.Margin = New Padding(0)
			Me.linkQueryColumnList.Name = "linkQueryColumnList"
			Me.linkQueryColumnList.Padding = New Padding(10, 3, 3, 3)
			Me.linkQueryColumnList.Size = New Size(153, 23)
			Me.linkQueryColumnList.TabIndex = 25
			Me.linkQueryColumnList.TabStop = True
			Me.linkQueryColumnList.Text = "QueryColumnsList Options"
			Me.linkQueryColumnList.UseCompatibleTextRendering = True
			Me.linkQueryColumnList.VisitedLinkColor = Color.Black
'			Me.linkQueryColumnList.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' linkQueryNavBar
			' 
			Me.linkQueryNavBar.AutoSize = True
			Me.linkQueryNavBar.ForeColor = Color.Black
			Me.linkQueryNavBar.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkQueryNavBar.LinkColor = Color.Black
			Me.linkQueryNavBar.Location = New Point(0, 207)
			Me.linkQueryNavBar.Margin = New Padding(0)
			Me.linkQueryNavBar.Name = "linkQueryNavBar"
			Me.linkQueryNavBar.Padding = New Padding(10, 3, 3, 3)
			Me.linkQueryNavBar.Size = New Size(128, 23)
			Me.linkQueryNavBar.TabIndex = 26
			Me.linkQueryNavBar.TabStop = True
			Me.linkQueryNavBar.Text = "QueryNavBar Options"
			Me.linkQueryNavBar.UseCompatibleTextRendering = True
			Me.linkQueryNavBar.VisitedLinkColor = Color.Black
'			Me.linkQueryNavBar.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' linkQueryView
			' 
			Me.linkQueryView.AutoSize = True
			Me.linkQueryView.ForeColor = Color.Black
			Me.linkQueryView.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkQueryView.LinkColor = Color.Black
			Me.linkQueryView.Location = New Point(0, 230)
			Me.linkQueryView.Margin = New Padding(0)
			Me.linkQueryView.Name = "linkQueryView"
			Me.linkQueryView.Padding = New Padding(10, 3, 3, 3)
			Me.linkQueryView.Size = New Size(127, 23)
			Me.linkQueryView.TabIndex = 27
			Me.linkQueryView.TabStop = True
			Me.linkQueryView.Text = "UserInterface Options"
			Me.linkQueryView.UseCompatibleTextRendering = True
			Me.linkQueryView.VisitedLinkColor = Color.Black
'			Me.linkQueryView.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' lbExpressionEditor
			' 
			Me.lbExpressionEditor.AutoSize = True
			Me.lbExpressionEditor.ForeColor = Color.Black
			Me.lbExpressionEditor.LinkBehavior = LinkBehavior.HoverUnderline
			Me.lbExpressionEditor.LinkColor = Color.Black
			Me.lbExpressionEditor.Location = New Point(0, 253)
			Me.lbExpressionEditor.Margin = New Padding(0)
			Me.lbExpressionEditor.Name = "lbExpressionEditor"
			Me.lbExpressionEditor.Padding = New Padding(10, 3, 3, 3)
			Me.lbExpressionEditor.Size = New Size(148, 23)
			Me.lbExpressionEditor.TabIndex = 29
			Me.lbExpressionEditor.TabStop = True
			Me.lbExpressionEditor.Text = "Expression Editor Options"
			Me.lbExpressionEditor.UseCompatibleTextRendering = True
			Me.lbExpressionEditor.VisitedLinkColor = Color.Black
'			Me.lbExpressionEditor.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' lbTextEditor
			' 
			Me.lbTextEditor.AutoSize = True
			Me.lbTextEditor.ForeColor = Color.Black
			Me.lbTextEditor.LinkBehavior = LinkBehavior.HoverUnderline
			Me.lbTextEditor.LinkColor = Color.Black
			Me.lbTextEditor.Location = New Point(0, 276)
			Me.lbTextEditor.Margin = New Padding(0)
			Me.lbTextEditor.Name = "lbTextEditor"
			Me.lbTextEditor.Padding = New Padding(10, 3, 3, 3)
			Me.lbTextEditor.Size = New Size(148, 23)
			Me.lbTextEditor.TabIndex = 30
			Me.lbTextEditor.TabStop = True
			Me.lbTextEditor.Text = "Text Editor Visual Options"
			Me.lbTextEditor.UseCompatibleTextRendering = True
			Me.lbTextEditor.VisitedLinkColor = Color.Black
'			Me.lbTextEditor.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' lbTextEditorSql
			' 
			Me.lbTextEditorSql.AutoSize = True
			Me.lbTextEditorSql.ForeColor = Color.Black
			Me.lbTextEditorSql.LinkBehavior = LinkBehavior.HoverUnderline
			Me.lbTextEditorSql.LinkColor = Color.Black
			Me.lbTextEditorSql.Location = New Point(0, 299)
			Me.lbTextEditorSql.Margin = New Padding(0)
			Me.lbTextEditorSql.Name = "lbTextEditorSql"
			Me.lbTextEditorSql.Padding = New Padding(10, 3, 3, 3)
			Me.lbTextEditorSql.Size = New Size(140, 23)
			Me.lbTextEditorSql.TabIndex = 31
			Me.lbTextEditorSql.TabStop = True
			Me.lbTextEditorSql.Text = "Text Editor SQL Options"
			Me.lbTextEditorSql.UseCompatibleTextRendering = True
			Me.lbTextEditorSql.VisitedLinkColor = Color.Black
'			Me.lbTextEditorSql.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu1_LinkClicked)
			' 
			' tabFormatting
			' 
			Me.tabFormatting.Controls.Add(Me.panelSqlFormatting)
			Me.tabFormatting.Location = New Point(4, 22)
			Me.tabFormatting.Name = "tabFormatting"
			Me.tabFormatting.Padding = New Padding(3)
			Me.tabFormatting.Size = New Size(716, 417)
			Me.tabFormatting.TabIndex = 1
			Me.tabFormatting.Text = "SQL Formatting properties"
			Me.tabFormatting.UseVisualStyleBackColor = True
			' 
			' panelSqlFormatting
			' 
			Me.panelSqlFormatting.Controls.Add(Me.panelPages2)
			Me.panelSqlFormatting.Controls.Add(Me.flowLayoutPanel2)
			Me.panelSqlFormatting.Dock = DockStyle.Fill
			Me.panelSqlFormatting.Location = New Point(3, 3)
			Me.panelSqlFormatting.Name = "panelSqlFormatting"
			Me.panelSqlFormatting.Size = New Size(710, 411)
			Me.panelSqlFormatting.TabIndex = 4
			' 
			' panelPages2
			' 
			Me.panelPages2.AutoScroll = True
			Me.panelPages2.AutoSize = True
			Me.panelPages2.AutoSizeMode = AutoSizeMode.GrowAndShrink
			Me.panelPages2.BackColor = Color.White
			Me.panelPages2.Dock = DockStyle.Fill
			Me.panelPages2.Location = New Point(170, 0)
			Me.panelPages2.Margin = New Padding(0)
			Me.panelPages2.Name = "panelPages2"
			Me.panelPages2.Padding = New Padding(10, 10, 6, 6)
			Me.panelPages2.Size = New Size(540, 411)
			Me.panelPages2.TabIndex = 7
			' 
			' flowLayoutPanel2
			' 
			Me.flowLayoutPanel2.BackColor = Color.White
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
			Me.flowLayoutPanel2.Dock = DockStyle.Left
			Me.flowLayoutPanel2.FlowDirection = FlowDirection.TopDown
			Me.flowLayoutPanel2.Location = New Point(0, 0)
			Me.flowLayoutPanel2.Name = "flowLayoutPanel2"
			Me.flowLayoutPanel2.Padding = New Padding(0, 10, 0, 0)
			Me.flowLayoutPanel2.Size = New Size(170, 411)
			Me.flowLayoutPanel2.TabIndex = 6
'			Me.flowLayoutPanel2.Paint += New System.Windows.Forms.PaintEventHandler(Me.flowLayoutPanel_Paint)
			' 
			' labelSqlFormatting
			' 
			Me.labelSqlFormatting.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.labelSqlFormatting.AutoSize = True
			Me.labelSqlFormatting.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.labelSqlFormatting.Location = New Point(0, 10)
			Me.labelSqlFormatting.Margin = New Padding(0)
			Me.labelSqlFormatting.Name = "labelSqlFormatting"
			Me.labelSqlFormatting.Padding = New Padding(10, 3, 3, 3)
			Me.labelSqlFormatting.Size = New Size(137, 24)
			Me.labelSqlFormatting.TabIndex = 10
			Me.labelSqlFormatting.Text = "SQL Options"
			Me.labelSqlFormatting.UseCompatibleTextRendering = True
			' 
			' linkMain
			' 
			Me.linkMain.AutoSize = True
			Me.linkMain.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.linkMain.ForeColor = Color.Black
			Me.linkMain.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkMain.LinkColor = Color.Black
			Me.linkMain.Location = New Point(0, 34)
			Me.linkMain.Margin = New Padding(0)
			Me.linkMain.Name = "linkMain"
			Me.linkMain.Padding = New Padding(20, 3, 3, 3)
			Me.linkMain.Size = New Size(85, 23)
			Me.linkMain.TabIndex = 26
			Me.linkMain.TabStop = True
			Me.linkMain.Text = "Main query"
			Me.linkMain.UseCompatibleTextRendering = True
			Me.linkMain.VisitedLinkColor = Color.Black
'			Me.linkMain.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu2_LinkClicked)
			' 
			' linkMainCommon
			' 
			Me.linkMainCommon.AutoSize = True
			Me.linkMainCommon.ForeColor = Color.Black
			Me.linkMainCommon.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkMainCommon.LinkColor = Color.Black
			Me.linkMainCommon.Location = New Point(0, 57)
			Me.linkMainCommon.Margin = New Padding(0)
			Me.linkMainCommon.Name = "linkMainCommon"
			Me.linkMainCommon.Padding = New Padding(20, 3, 3, 3)
			Me.linkMainCommon.Size = New Size(85, 23)
			Me.linkMainCommon.TabIndex = 27
			Me.linkMainCommon.TabStop = True
			Me.linkMainCommon.Text = "    Common"
			Me.linkMainCommon.UseCompatibleTextRendering = True
			Me.linkMainCommon.VisitedLinkColor = Color.Black
'			Me.linkMainCommon.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu2_LinkClicked)
			' 
			' linkMainExpressions
			' 
			Me.linkMainExpressions.AutoSize = True
			Me.linkMainExpressions.ForeColor = Color.Black
			Me.linkMainExpressions.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkMainExpressions.LinkColor = Color.Black
			Me.linkMainExpressions.Location = New Point(0, 80)
			Me.linkMainExpressions.Margin = New Padding(0)
			Me.linkMainExpressions.Name = "linkMainExpressions"
			Me.linkMainExpressions.Padding = New Padding(20, 3, 3, 3)
			Me.linkMainExpressions.Size = New Size(101, 23)
			Me.linkMainExpressions.TabIndex = 28
			Me.linkMainExpressions.TabStop = True
			Me.linkMainExpressions.Text = "    Expressions"
			Me.linkMainExpressions.UseCompatibleTextRendering = True
			Me.linkMainExpressions.VisitedLinkColor = Color.Black
'			Me.linkMainExpressions.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu2_LinkClicked)
			' 
			' linkCte
			' 
			Me.linkCte.AutoSize = True
			Me.linkCte.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.linkCte.ForeColor = Color.Black
			Me.linkCte.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkCte.LinkColor = Color.Black
			Me.linkCte.Location = New Point(0, 103)
			Me.linkCte.Margin = New Padding(0)
			Me.linkCte.Name = "linkCte"
			Me.linkCte.Padding = New Padding(20, 3, 3, 3)
			Me.linkCte.Size = New Size(83, 23)
			Me.linkCte.TabIndex = 29
			Me.linkCte.TabStop = True
			Me.linkCte.Text = "CTE query"
			Me.linkCte.UseCompatibleTextRendering = True
			Me.linkCte.VisitedLinkColor = Color.Black
'			Me.linkCte.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu2_LinkClicked)
			' 
			' linkCteCommon
			' 
			Me.linkCteCommon.AutoSize = True
			Me.linkCteCommon.ForeColor = Color.Black
			Me.linkCteCommon.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkCteCommon.LinkColor = Color.Black
			Me.linkCteCommon.Location = New Point(0, 126)
			Me.linkCteCommon.Margin = New Padding(0)
			Me.linkCteCommon.Name = "linkCteCommon"
			Me.linkCteCommon.Padding = New Padding(20, 3, 3, 3)
			Me.linkCteCommon.Size = New Size(85, 23)
			Me.linkCteCommon.TabIndex = 30
			Me.linkCteCommon.TabStop = True
			Me.linkCteCommon.Text = "    Common"
			Me.linkCteCommon.UseCompatibleTextRendering = True
			Me.linkCteCommon.VisitedLinkColor = Color.Black
'			Me.linkCteCommon.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu2_LinkClicked)
			' 
			' linkCteExpressions
			' 
			Me.linkCteExpressions.AutoSize = True
			Me.linkCteExpressions.ForeColor = Color.Black
			Me.linkCteExpressions.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkCteExpressions.LinkColor = Color.Black
			Me.linkCteExpressions.Location = New Point(0, 149)
			Me.linkCteExpressions.Margin = New Padding(0)
			Me.linkCteExpressions.Name = "linkCteExpressions"
			Me.linkCteExpressions.Padding = New Padding(20, 3, 3, 3)
			Me.linkCteExpressions.Size = New Size(101, 23)
			Me.linkCteExpressions.TabIndex = 31
			Me.linkCteExpressions.TabStop = True
			Me.linkCteExpressions.Text = "    Expressions"
			Me.linkCteExpressions.UseCompatibleTextRendering = True
			Me.linkCteExpressions.VisitedLinkColor = Color.Black
'			Me.linkCteExpressions.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu2_LinkClicked)
			' 
			' linkDerived
			' 
			Me.linkDerived.AutoSize = True
			Me.linkDerived.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.linkDerived.ForeColor = Color.Black
			Me.linkDerived.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkDerived.LinkColor = Color.Black
			Me.linkDerived.Location = New Point(0, 172)
			Me.linkDerived.Margin = New Padding(0)
			Me.linkDerived.Name = "linkDerived"
			Me.linkDerived.Padding = New Padding(20, 3, 3, 3)
			Me.linkDerived.Size = New Size(100, 23)
			Me.linkDerived.TabIndex = 32
			Me.linkDerived.TabStop = True
			Me.linkDerived.Text = "Derived query"
			Me.linkDerived.UseCompatibleTextRendering = True
			Me.linkDerived.VisitedLinkColor = Color.Black
'			Me.linkDerived.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu2_LinkClicked)
			' 
			' linkDerivedCommon
			' 
			Me.linkDerivedCommon.AutoSize = True
			Me.linkDerivedCommon.ForeColor = Color.Black
			Me.linkDerivedCommon.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkDerivedCommon.LinkColor = Color.Black
			Me.linkDerivedCommon.Location = New Point(0, 195)
			Me.linkDerivedCommon.Margin = New Padding(0)
			Me.linkDerivedCommon.Name = "linkDerivedCommon"
			Me.linkDerivedCommon.Padding = New Padding(20, 3, 3, 3)
			Me.linkDerivedCommon.Size = New Size(85, 23)
			Me.linkDerivedCommon.TabIndex = 33
			Me.linkDerivedCommon.TabStop = True
			Me.linkDerivedCommon.Text = "    Common"
			Me.linkDerivedCommon.UseCompatibleTextRendering = True
			Me.linkDerivedCommon.VisitedLinkColor = Color.Black
'			Me.linkDerivedCommon.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu2_LinkClicked)
			' 
			' linkDerivedExpressions
			' 
			Me.linkDerivedExpressions.AutoSize = True
			Me.linkDerivedExpressions.ForeColor = Color.Black
			Me.linkDerivedExpressions.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkDerivedExpressions.LinkColor = Color.Black
			Me.linkDerivedExpressions.Location = New Point(0, 218)
			Me.linkDerivedExpressions.Margin = New Padding(0)
			Me.linkDerivedExpressions.Name = "linkDerivedExpressions"
			Me.linkDerivedExpressions.Padding = New Padding(20, 3, 3, 3)
			Me.linkDerivedExpressions.Size = New Size(101, 23)
			Me.linkDerivedExpressions.TabIndex = 34
			Me.linkDerivedExpressions.TabStop = True
			Me.linkDerivedExpressions.Text = "    Expressions"
			Me.linkDerivedExpressions.UseCompatibleTextRendering = True
			Me.linkDerivedExpressions.VisitedLinkColor = Color.Black
'			Me.linkDerivedExpressions.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu2_LinkClicked)
			' 
			' linkExpression
			' 
			Me.linkExpression.AutoSize = True
			Me.linkExpression.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.linkExpression.ForeColor = Color.Black
			Me.linkExpression.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkExpression.LinkColor = Color.Black
			Me.linkExpression.Location = New Point(0, 241)
			Me.linkExpression.Margin = New Padding(0)
			Me.linkExpression.Name = "linkExpression"
			Me.linkExpression.Padding = New Padding(20, 3, 3, 3)
			Me.linkExpression.Size = New Size(137, 23)
			Me.linkExpression.TabIndex = 35
			Me.linkExpression.TabStop = True
			Me.linkExpression.Text = "Expression subquery"
			Me.linkExpression.UseCompatibleTextRendering = True
			Me.linkExpression.VisitedLinkColor = Color.Black
'			Me.linkExpression.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu2_LinkClicked)
			' 
			' linkExpressionCommon
			' 
			Me.linkExpressionCommon.AutoSize = True
			Me.linkExpressionCommon.ForeColor = Color.Black
			Me.linkExpressionCommon.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkExpressionCommon.LinkColor = Color.Black
			Me.linkExpressionCommon.Location = New Point(0, 264)
			Me.linkExpressionCommon.Margin = New Padding(0)
			Me.linkExpressionCommon.Name = "linkExpressionCommon"
			Me.linkExpressionCommon.Padding = New Padding(20, 3, 3, 3)
			Me.linkExpressionCommon.Size = New Size(85, 23)
			Me.linkExpressionCommon.TabIndex = 36
			Me.linkExpressionCommon.TabStop = True
			Me.linkExpressionCommon.Text = "    Common"
			Me.linkExpressionCommon.UseCompatibleTextRendering = True
			Me.linkExpressionCommon.VisitedLinkColor = Color.Black
'			Me.linkExpressionCommon.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu2_LinkClicked)
			' 
			' linkExpressionExpressions
			' 
			Me.linkExpressionExpressions.AutoSize = True
			Me.linkExpressionExpressions.ForeColor = Color.Black
			Me.linkExpressionExpressions.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkExpressionExpressions.LinkColor = Color.Black
			Me.linkExpressionExpressions.Location = New Point(0, 287)
			Me.linkExpressionExpressions.Margin = New Padding(0)
			Me.linkExpressionExpressions.Name = "linkExpressionExpressions"
			Me.linkExpressionExpressions.Padding = New Padding(20, 3, 3, 3)
			Me.linkExpressionExpressions.Size = New Size(101, 23)
			Me.linkExpressionExpressions.TabIndex = 37
			Me.linkExpressionExpressions.TabStop = True
			Me.linkExpressionExpressions.Text = "    Expressions"
			Me.linkExpressionExpressions.UseCompatibleTextRendering = True
			Me.linkExpressionExpressions.VisitedLinkColor = Color.Black
'			Me.linkExpressionExpressions.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu2_LinkClicked)
			' 
			' QueryPropertiesForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.buttonCancel
			Me.ClientSize = New Size(781, 482)
			Me.Controls.Add(Me.tabControl)
			Me.Controls.Add(Me.panelButtons)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "QueryPropertiesForm"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Properties"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.QueryPropertiesForm_FormClosing)
'			Me.Paint += New System.Windows.Forms.PaintEventHandler(Me.QueryBuilderPropertiesForm_Paint)
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

		Private panelButtons As Panel
		Private buttonCancel As Button
		Private tabControl As TabControl
		Private tabQueryBuilder As TabPage
		Private panelQueryBuilder As Panel
		Private panelPages1 As Panel
		Private WithEvents flowLayoutPanel1 As FlowLayoutPanel
		Private WithEvents linkBehaviorOptions As LinkLabel
		Private WithEvents linkDatabaseSchemaView As LinkLabel
		Private WithEvents linkDesignPane As LinkLabel
		Private WithEvents linkVisualOptions As LinkLabel
		Private WithEvents linkAddObjectDialog As LinkLabel
		Private WithEvents linkDatasourceOptions As LinkLabel
		Private WithEvents linkQueryColumnList As LinkLabel
		Private tabFormatting As TabPage
		Private panelSqlFormatting As Panel
		Private panelPages2 As Panel
		Private WithEvents flowLayoutPanel2 As FlowLayoutPanel
		Private labelSqlFormatting As Label
		Private WithEvents linkMain As LinkLabel
		Private WithEvents linkMainCommon As LinkLabel
		Private WithEvents linkMainExpressions As LinkLabel
		Private WithEvents linkCte As LinkLabel
		Private WithEvents linkCteCommon As LinkLabel
		Private WithEvents linkCteExpressions As LinkLabel
		Private WithEvents linkDerived As LinkLabel
		Private WithEvents linkDerivedCommon As LinkLabel
		Private WithEvents linkDerivedExpressions As LinkLabel
		Private WithEvents linkExpression As LinkLabel
		Private WithEvents linkExpressionCommon As LinkLabel
		Private WithEvents linkExpressionExpressions As LinkLabel
		Private WithEvents buttonSave As Button
		Private WithEvents buttonLoad As Button
		Private WithEvents linkQueryNavBar As LinkLabel
		Private WithEvents linkQueryView As LinkLabel
		Private WithEvents linkSqlGeneration As LinkLabel
		Private WithEvents lbExpressionEditor As LinkLabel
		Private WithEvents lbTextEditor As LinkLabel
		Private WithEvents lbTextEditorSql As LinkLabel
	End Class
End Namespace
