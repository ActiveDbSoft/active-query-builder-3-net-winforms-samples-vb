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
        Me.labelNonVisual = New System.Windows.Forms.Label()
        Me.linkSqlSyntax = New System.Windows.Forms.LinkLabel()
        Me.linkOfflineMode = New System.Windows.Forms.LinkLabel()
        Me.labelVisual = New System.Windows.Forms.Label()
        Me.linkBehaviorOptions = New System.Windows.Forms.LinkLabel()
        Me.linkDatabaseSchemaView = New System.Windows.Forms.LinkLabel()
        Me.linkDesignPane = New System.Windows.Forms.LinkLabel()
        Me.linkVisualOptions = New System.Windows.Forms.LinkLabel()
        Me.linkAddObjectDialog = New System.Windows.Forms.LinkLabel()
        Me.linkDatasourceOptions = New System.Windows.Forms.LinkLabel()
        Me.linkMetadataLoadingOptions = New System.Windows.Forms.LinkLabel()
        Me.linkMetadataStructureOptions = New System.Windows.Forms.LinkLabel()
        Me.linkQueryColumnList = New System.Windows.Forms.LinkLabel()
        Me.LinkQueryNavBar = New System.Windows.Forms.LinkLabel()
        Me.LinkUserInterface = New System.Windows.Forms.LinkLabel()
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
        Me.panelButtons.SuspendLayout
        Me.tabControl.SuspendLayout
        Me.tabQueryBuilder.SuspendLayout
        Me.panelQueryBuilder.SuspendLayout
        Me.flowLayoutPanel1.SuspendLayout
        Me.tabFormatting.SuspendLayout
        Me.panelSqlFormatting.SuspendLayout
        Me.flowLayoutPanel2.SuspendLayout
        Me.SuspendLayout
        '
        'panelButtons
        '
        Me.panelButtons.Controls.Add(Me.buttonLoad)
        Me.panelButtons.Controls.Add(Me.buttonSave)
        Me.panelButtons.Controls.Add(Me.buttonCancel)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelButtons.Location = New System.Drawing.Point(0, 443)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(724, 39)
        Me.panelButtons.TabIndex = 2
        '
        'buttonLoad
        '
        Me.buttonLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.buttonLoad.Location = New System.Drawing.Point(114, 8)
        Me.buttonLoad.Name = "buttonLoad"
        Me.buttonLoad.Size = New System.Drawing.Size(96, 23)
        Me.buttonLoad.TabIndex = 3
        Me.buttonLoad.Text = "Load..."
        Me.buttonLoad.UseVisualStyleBackColor = true
        '
        'buttonSave
        '
        Me.buttonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.buttonSave.Location = New System.Drawing.Point(12, 8)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(96, 23)
        Me.buttonSave.TabIndex = 2
        Me.buttonSave.Text = "Save..."
        Me.buttonSave.UseVisualStyleBackColor = true
        '
        'buttonCancel
        '
        Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.buttonCancel.Location = New System.Drawing.Point(637, 6)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 1
        Me.buttonCancel.Text = "Close"
        Me.buttonCancel.UseVisualStyleBackColor = true
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabQueryBuilder)
        Me.tabControl.Controls.Add(Me.tabFormatting)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(724, 443)
        Me.tabControl.TabIndex = 3
        '
        'tabQueryBuilder
        '
        Me.tabQueryBuilder.Controls.Add(Me.panelQueryBuilder)
        Me.tabQueryBuilder.Location = New System.Drawing.Point(4, 22)
        Me.tabQueryBuilder.Name = "tabQueryBuilder"
        Me.tabQueryBuilder.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQueryBuilder.Size = New System.Drawing.Size(716, 417)
        Me.tabQueryBuilder.TabIndex = 0
        Me.tabQueryBuilder.Text = "QueryBuilder properties"
        Me.tabQueryBuilder.UseVisualStyleBackColor = true
        '
        'panelQueryBuilder
        '
        Me.panelQueryBuilder.Controls.Add(Me.panelPages1)
        Me.panelQueryBuilder.Controls.Add(Me.flowLayoutPanel1)
        Me.panelQueryBuilder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelQueryBuilder.Location = New System.Drawing.Point(3, 3)
        Me.panelQueryBuilder.Name = "panelQueryBuilder"
        Me.panelQueryBuilder.Size = New System.Drawing.Size(710, 411)
        Me.panelQueryBuilder.TabIndex = 4
        '
        'panelPages1
        '
        Me.panelPages1.AutoScroll = true
        Me.panelPages1.AutoSize = true
        Me.panelPages1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelPages1.BackColor = System.Drawing.Color.White
        Me.panelPages1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPages1.Location = New System.Drawing.Point(170, 0)
        Me.panelPages1.Margin = New System.Windows.Forms.Padding(0)
        Me.panelPages1.Name = "panelPages1"
        Me.panelPages1.Padding = New System.Windows.Forms.Padding(10, 10, 6, 6)
        Me.panelPages1.Size = New System.Drawing.Size(540, 411)
        Me.panelPages1.TabIndex = 7
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.AutoScroll = true
        Me.flowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.flowLayoutPanel1.Controls.Add(Me.labelNonVisual)
        Me.flowLayoutPanel1.Controls.Add(Me.linkSqlSyntax)
        Me.flowLayoutPanel1.Controls.Add(Me.linkOfflineMode)
        Me.flowLayoutPanel1.Controls.Add(Me.labelVisual)
        Me.flowLayoutPanel1.Controls.Add(Me.linkBehaviorOptions)
        Me.flowLayoutPanel1.Controls.Add(Me.linkDatabaseSchemaView)
        Me.flowLayoutPanel1.Controls.Add(Me.linkDesignPane)
        Me.flowLayoutPanel1.Controls.Add(Me.linkVisualOptions)
        Me.flowLayoutPanel1.Controls.Add(Me.linkAddObjectDialog)
        Me.flowLayoutPanel1.Controls.Add(Me.linkDatasourceOptions)
        Me.flowLayoutPanel1.Controls.Add(Me.linkMetadataLoadingOptions)
        Me.flowLayoutPanel1.Controls.Add(Me.linkMetadataStructureOptions)
        Me.flowLayoutPanel1.Controls.Add(Me.linkQueryColumnList)
        Me.flowLayoutPanel1.Controls.Add(Me.LinkQueryNavBar)
        Me.flowLayoutPanel1.Controls.Add(Me.LinkUserInterface)
        Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(170, 411)
        Me.flowLayoutPanel1.TabIndex = 6
        '
        'labelNonVisual
        '
        Me.labelNonVisual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labelNonVisual.AutoSize = true
        Me.labelNonVisual.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.labelNonVisual.Location = New System.Drawing.Point(0, 10)
        Me.labelNonVisual.Margin = New System.Windows.Forms.Padding(0)
        Me.labelNonVisual.Name = "labelNonVisual"
        Me.labelNonVisual.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.labelNonVisual.Size = New System.Drawing.Size(165, 24)
        Me.labelNonVisual.TabIndex = 0
        Me.labelNonVisual.Text = "Non-visual Options"
        Me.labelNonVisual.UseCompatibleTextRendering = true
        '
        'linkSqlSyntax
        '
        Me.linkSqlSyntax.AutoSize = true
        Me.linkSqlSyntax.ForeColor = System.Drawing.Color.Black
        Me.linkSqlSyntax.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkSqlSyntax.LinkColor = System.Drawing.Color.Black
        Me.linkSqlSyntax.Location = New System.Drawing.Point(0, 34)
        Me.linkSqlSyntax.Margin = New System.Windows.Forms.Padding(0)
        Me.linkSqlSyntax.Name = "linkSqlSyntax"
        Me.linkSqlSyntax.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkSqlSyntax.Size = New System.Drawing.Size(87, 23)
        Me.linkSqlSyntax.TabIndex = 3
        Me.linkSqlSyntax.TabStop = true
        Me.linkSqlSyntax.Text = "SQL Syntax"
        Me.linkSqlSyntax.UseCompatibleTextRendering = true
        Me.linkSqlSyntax.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkOfflineMode
        '
        Me.linkOfflineMode.AutoSize = true
        Me.linkOfflineMode.ForeColor = System.Drawing.Color.Black
        Me.linkOfflineMode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkOfflineMode.LinkColor = System.Drawing.Color.Black
        Me.linkOfflineMode.Location = New System.Drawing.Point(0, 57)
        Me.linkOfflineMode.Margin = New System.Windows.Forms.Padding(0)
        Me.linkOfflineMode.Name = "linkOfflineMode"
        Me.linkOfflineMode.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkOfflineMode.Size = New System.Drawing.Size(91, 23)
        Me.linkOfflineMode.TabIndex = 4
        Me.linkOfflineMode.TabStop = true
        Me.linkOfflineMode.Text = "Offline Mode"
        Me.linkOfflineMode.UseCompatibleTextRendering = true
        Me.linkOfflineMode.VisitedLinkColor = System.Drawing.Color.Black
        '
        'labelVisual
        '
        Me.labelVisual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labelVisual.AutoSize = true
        Me.labelVisual.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.labelVisual.Location = New System.Drawing.Point(0, 80)
        Me.labelVisual.Margin = New System.Windows.Forms.Padding(0)
        Me.labelVisual.Name = "labelVisual"
        Me.labelVisual.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.labelVisual.Size = New System.Drawing.Size(165, 24)
        Me.labelVisual.TabIndex = 16
        Me.labelVisual.Text = "New Options"
        Me.labelVisual.UseCompatibleTextRendering = true
        '
        'linkBehaviorOptions
        '
        Me.linkBehaviorOptions.AutoSize = true
        Me.linkBehaviorOptions.ForeColor = System.Drawing.Color.Black
        Me.linkBehaviorOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkBehaviorOptions.LinkColor = System.Drawing.Color.Black
        Me.linkBehaviorOptions.Location = New System.Drawing.Point(0, 104)
        Me.linkBehaviorOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.linkBehaviorOptions.Name = "linkBehaviorOptions"
        Me.linkBehaviorOptions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkBehaviorOptions.Size = New System.Drawing.Size(114, 23)
        Me.linkBehaviorOptions.TabIndex = 15
        Me.linkBehaviorOptions.TabStop = true
        Me.linkBehaviorOptions.Text = "Behavior Options"
        Me.linkBehaviorOptions.UseCompatibleTextRendering = true
        Me.linkBehaviorOptions.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkDatabaseSchemaView
        '
        Me.linkDatabaseSchemaView.AutoSize = true
        Me.linkDatabaseSchemaView.ForeColor = System.Drawing.Color.Black
        Me.linkDatabaseSchemaView.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkDatabaseSchemaView.LinkColor = System.Drawing.Color.Black
        Me.linkDatabaseSchemaView.Location = New System.Drawing.Point(0, 127)
        Me.linkDatabaseSchemaView.Margin = New System.Windows.Forms.Padding(0)
        Me.linkDatabaseSchemaView.Name = "linkDatabaseSchemaView"
        Me.linkDatabaseSchemaView.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkDatabaseSchemaView.Size = New System.Drawing.Size(145, 36)
        Me.linkDatabaseSchemaView.TabIndex = 18
        Me.linkDatabaseSchemaView.TabStop = true
        Me.linkDatabaseSchemaView.Text = "DatabaseSchemaView Options"
        Me.linkDatabaseSchemaView.UseCompatibleTextRendering = true
        Me.linkDatabaseSchemaView.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkDesignPane
        '
        Me.linkDesignPane.AutoSize = true
        Me.linkDesignPane.ForeColor = System.Drawing.Color.Black
        Me.linkDesignPane.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkDesignPane.LinkColor = System.Drawing.Color.Black
        Me.linkDesignPane.Location = New System.Drawing.Point(0, 163)
        Me.linkDesignPane.Margin = New System.Windows.Forms.Padding(0)
        Me.linkDesignPane.Name = "linkDesignPane"
        Me.linkDesignPane.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkDesignPane.Size = New System.Drawing.Size(131, 23)
        Me.linkDesignPane.TabIndex = 19
        Me.linkDesignPane.TabStop = true
        Me.linkDesignPane.Text = "DesignPane Options"
        Me.linkDesignPane.UseCompatibleTextRendering = true
        Me.linkDesignPane.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkVisualOptions
        '
        Me.linkVisualOptions.AutoSize = true
        Me.linkVisualOptions.ForeColor = System.Drawing.Color.Black
        Me.linkVisualOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkVisualOptions.LinkColor = System.Drawing.Color.Black
        Me.linkVisualOptions.Location = New System.Drawing.Point(0, 186)
        Me.linkVisualOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.linkVisualOptions.Name = "linkVisualOptions"
        Me.linkVisualOptions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkVisualOptions.Size = New System.Drawing.Size(100, 23)
        Me.linkVisualOptions.TabIndex = 20
        Me.linkVisualOptions.TabStop = true
        Me.linkVisualOptions.Text = "Visual Options"
        Me.linkVisualOptions.UseCompatibleTextRendering = true
        Me.linkVisualOptions.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkAddObjectDialog
        '
        Me.linkAddObjectDialog.AutoSize = true
        Me.linkAddObjectDialog.ForeColor = System.Drawing.Color.Black
        Me.linkAddObjectDialog.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkAddObjectDialog.LinkColor = System.Drawing.Color.Black
        Me.linkAddObjectDialog.Location = New System.Drawing.Point(0, 209)
        Me.linkAddObjectDialog.Margin = New System.Windows.Forms.Padding(0)
        Me.linkAddObjectDialog.Name = "linkAddObjectDialog"
        Me.linkAddObjectDialog.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkAddObjectDialog.Size = New System.Drawing.Size(158, 23)
        Me.linkAddObjectDialog.TabIndex = 21
        Me.linkAddObjectDialog.TabStop = true
        Me.linkAddObjectDialog.Text = "AddObject Dialog Options"
        Me.linkAddObjectDialog.UseCompatibleTextRendering = true
        Me.linkAddObjectDialog.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkDatasourceOptions
        '
        Me.linkDatasourceOptions.AutoSize = true
        Me.linkDatasourceOptions.ForeColor = System.Drawing.Color.Black
        Me.linkDatasourceOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkDatasourceOptions.LinkColor = System.Drawing.Color.Black
        Me.linkDatasourceOptions.Location = New System.Drawing.Point(0, 232)
        Me.linkDatasourceOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.linkDatasourceOptions.Name = "linkDatasourceOptions"
        Me.linkDatasourceOptions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkDatasourceOptions.Size = New System.Drawing.Size(127, 23)
        Me.linkDatasourceOptions.TabIndex = 22
        Me.linkDatasourceOptions.TabStop = true
        Me.linkDatasourceOptions.Text = "Datasource Options"
        Me.linkDatasourceOptions.UseCompatibleTextRendering = true
        Me.linkDatasourceOptions.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkMetadataLoadingOptions
        '
        Me.linkMetadataLoadingOptions.AutoSize = true
        Me.linkMetadataLoadingOptions.ForeColor = System.Drawing.Color.Black
        Me.linkMetadataLoadingOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkMetadataLoadingOptions.LinkColor = System.Drawing.Color.Black
        Me.linkMetadataLoadingOptions.Location = New System.Drawing.Point(0, 255)
        Me.linkMetadataLoadingOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.linkMetadataLoadingOptions.Name = "linkMetadataLoadingOptions"
        Me.linkMetadataLoadingOptions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkMetadataLoadingOptions.Size = New System.Drawing.Size(160, 23)
        Me.linkMetadataLoadingOptions.TabIndex = 23
        Me.linkMetadataLoadingOptions.TabStop = true
        Me.linkMetadataLoadingOptions.Text = "Metadata Loading Options"
        Me.linkMetadataLoadingOptions.UseCompatibleTextRendering = true
        Me.linkMetadataLoadingOptions.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkMetadataStructureOptions
        '
        Me.linkMetadataStructureOptions.AutoSize = true
        Me.linkMetadataStructureOptions.ForeColor = System.Drawing.Color.Black
        Me.linkMetadataStructureOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkMetadataStructureOptions.LinkColor = System.Drawing.Color.Black
        Me.linkMetadataStructureOptions.Location = New System.Drawing.Point(0, 278)
        Me.linkMetadataStructureOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.linkMetadataStructureOptions.Name = "linkMetadataStructureOptions"
        Me.linkMetadataStructureOptions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkMetadataStructureOptions.Size = New System.Drawing.Size(165, 23)
        Me.linkMetadataStructureOptions.TabIndex = 24
        Me.linkMetadataStructureOptions.TabStop = true
        Me.linkMetadataStructureOptions.Text = "Metadata Structure Options"
        Me.linkMetadataStructureOptions.UseCompatibleTextRendering = true
        Me.linkMetadataStructureOptions.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkQueryColumnList
        '
        Me.linkQueryColumnList.AutoSize = true
        Me.linkQueryColumnList.ForeColor = System.Drawing.Color.Black
        Me.linkQueryColumnList.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkQueryColumnList.LinkColor = System.Drawing.Color.Black
        Me.linkQueryColumnList.Location = New System.Drawing.Point(0, 301)
        Me.linkQueryColumnList.Margin = New System.Windows.Forms.Padding(0)
        Me.linkQueryColumnList.Name = "linkQueryColumnList"
        Me.linkQueryColumnList.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkQueryColumnList.Size = New System.Drawing.Size(163, 23)
        Me.linkQueryColumnList.TabIndex = 25
        Me.linkQueryColumnList.TabStop = true
        Me.linkQueryColumnList.Text = "QueryColumnsList Options"
        Me.linkQueryColumnList.UseCompatibleTextRendering = true
        Me.linkQueryColumnList.VisitedLinkColor = System.Drawing.Color.Black
        '
        'LinkQueryNavBar
        '
        Me.LinkQueryNavBar.AutoSize = true
        Me.LinkQueryNavBar.ForeColor = System.Drawing.Color.Black
        Me.LinkQueryNavBar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkQueryNavBar.LinkColor = System.Drawing.Color.Black
        Me.LinkQueryNavBar.Location = New System.Drawing.Point(0, 324)
        Me.LinkQueryNavBar.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkQueryNavBar.Name = "LinkQueryNavBar"
        Me.LinkQueryNavBar.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.LinkQueryNavBar.Size = New System.Drawing.Size(138, 23)
        Me.LinkQueryNavBar.TabIndex = 26
        Me.LinkQueryNavBar.TabStop = true
        Me.LinkQueryNavBar.Text = "QueryNavBar Options"
        Me.LinkQueryNavBar.UseCompatibleTextRendering = true
        Me.LinkQueryNavBar.VisitedLinkColor = System.Drawing.Color.Black
        '
        'LinkUserInterface
        '
        Me.LinkUserInterface.AutoSize = true
        Me.LinkUserInterface.ForeColor = System.Drawing.Color.Black
        Me.LinkUserInterface.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkUserInterface.LinkColor = System.Drawing.Color.Black
        Me.LinkUserInterface.Location = New System.Drawing.Point(0, 347)
        Me.LinkUserInterface.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkUserInterface.Name = "LinkUserInterface"
        Me.LinkUserInterface.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.LinkUserInterface.Size = New System.Drawing.Size(140, 23)
        Me.LinkUserInterface.TabIndex = 27
        Me.LinkUserInterface.TabStop = true
        Me.LinkUserInterface.Text = "User interface Options"
        Me.LinkUserInterface.UseCompatibleTextRendering = true
        Me.LinkUserInterface.VisitedLinkColor = System.Drawing.Color.Black
        '
        'tabFormatting
        '
        Me.tabFormatting.Controls.Add(Me.panelSqlFormatting)
        Me.tabFormatting.Location = New System.Drawing.Point(4, 22)
        Me.tabFormatting.Name = "tabFormatting"
        Me.tabFormatting.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFormatting.Size = New System.Drawing.Size(716, 417)
        Me.tabFormatting.TabIndex = 1
        Me.tabFormatting.Text = "SQL Formatting properties"
        Me.tabFormatting.UseVisualStyleBackColor = true
        '
        'panelSqlFormatting
        '
        Me.panelSqlFormatting.Controls.Add(Me.panelPages2)
        Me.panelSqlFormatting.Controls.Add(Me.flowLayoutPanel2)
        Me.panelSqlFormatting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSqlFormatting.Location = New System.Drawing.Point(3, 3)
        Me.panelSqlFormatting.Name = "panelSqlFormatting"
        Me.panelSqlFormatting.Size = New System.Drawing.Size(710, 411)
        Me.panelSqlFormatting.TabIndex = 4
        '
        'panelPages2
        '
        Me.panelPages2.AutoScroll = true
        Me.panelPages2.AutoSize = true
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
        'flowLayoutPanel2
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
        '
        'labelSqlFormatting
        '
        Me.labelSqlFormatting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labelSqlFormatting.AutoSize = true
        Me.labelSqlFormatting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.labelSqlFormatting.Location = New System.Drawing.Point(0, 10)
        Me.labelSqlFormatting.Margin = New System.Windows.Forms.Padding(0)
        Me.labelSqlFormatting.Name = "labelSqlFormatting"
        Me.labelSqlFormatting.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.labelSqlFormatting.Size = New System.Drawing.Size(137, 24)
        Me.labelSqlFormatting.TabIndex = 10
        Me.labelSqlFormatting.Text = "SQL Options"
        Me.labelSqlFormatting.UseCompatibleTextRendering = true
        '
        'linkMain
        '
        Me.linkMain.AutoSize = true
        Me.linkMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.linkMain.ForeColor = System.Drawing.Color.Black
        Me.linkMain.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkMain.LinkColor = System.Drawing.Color.Black
        Me.linkMain.Location = New System.Drawing.Point(0, 34)
        Me.linkMain.Margin = New System.Windows.Forms.Padding(0)
        Me.linkMain.Name = "linkMain"
        Me.linkMain.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkMain.Size = New System.Drawing.Size(85, 23)
        Me.linkMain.TabIndex = 26
        Me.linkMain.TabStop = true
        Me.linkMain.Text = "Main query"
        Me.linkMain.UseCompatibleTextRendering = true
        Me.linkMain.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkMainCommon
        '
        Me.linkMainCommon.AutoSize = true
        Me.linkMainCommon.ForeColor = System.Drawing.Color.Black
        Me.linkMainCommon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkMainCommon.LinkColor = System.Drawing.Color.Black
        Me.linkMainCommon.Location = New System.Drawing.Point(0, 57)
        Me.linkMainCommon.Margin = New System.Windows.Forms.Padding(0)
        Me.linkMainCommon.Name = "linkMainCommon"
        Me.linkMainCommon.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkMainCommon.Size = New System.Drawing.Size(85, 23)
        Me.linkMainCommon.TabIndex = 27
        Me.linkMainCommon.TabStop = true
        Me.linkMainCommon.Text = "    Common"
        Me.linkMainCommon.UseCompatibleTextRendering = true
        Me.linkMainCommon.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkMainExpressions
        '
        Me.linkMainExpressions.AutoSize = true
        Me.linkMainExpressions.ForeColor = System.Drawing.Color.Black
        Me.linkMainExpressions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkMainExpressions.LinkColor = System.Drawing.Color.Black
        Me.linkMainExpressions.Location = New System.Drawing.Point(0, 80)
        Me.linkMainExpressions.Margin = New System.Windows.Forms.Padding(0)
        Me.linkMainExpressions.Name = "linkMainExpressions"
        Me.linkMainExpressions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkMainExpressions.Size = New System.Drawing.Size(101, 23)
        Me.linkMainExpressions.TabIndex = 28
        Me.linkMainExpressions.TabStop = true
        Me.linkMainExpressions.Text = "    Expressions"
        Me.linkMainExpressions.UseCompatibleTextRendering = true
        Me.linkMainExpressions.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkCte
        '
        Me.linkCte.AutoSize = true
        Me.linkCte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.linkCte.ForeColor = System.Drawing.Color.Black
        Me.linkCte.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkCte.LinkColor = System.Drawing.Color.Black
        Me.linkCte.Location = New System.Drawing.Point(0, 103)
        Me.linkCte.Margin = New System.Windows.Forms.Padding(0)
        Me.linkCte.Name = "linkCte"
        Me.linkCte.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkCte.Size = New System.Drawing.Size(83, 23)
        Me.linkCte.TabIndex = 29
        Me.linkCte.TabStop = true
        Me.linkCte.Text = "CTE query"
        Me.linkCte.UseCompatibleTextRendering = true
        Me.linkCte.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkCteCommon
        '
        Me.linkCteCommon.AutoSize = true
        Me.linkCteCommon.ForeColor = System.Drawing.Color.Black
        Me.linkCteCommon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkCteCommon.LinkColor = System.Drawing.Color.Black
        Me.linkCteCommon.Location = New System.Drawing.Point(0, 126)
        Me.linkCteCommon.Margin = New System.Windows.Forms.Padding(0)
        Me.linkCteCommon.Name = "linkCteCommon"
        Me.linkCteCommon.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkCteCommon.Size = New System.Drawing.Size(85, 23)
        Me.linkCteCommon.TabIndex = 30
        Me.linkCteCommon.TabStop = true
        Me.linkCteCommon.Text = "    Common"
        Me.linkCteCommon.UseCompatibleTextRendering = true
        Me.linkCteCommon.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkCteExpressions
        '
        Me.linkCteExpressions.AutoSize = true
        Me.linkCteExpressions.ForeColor = System.Drawing.Color.Black
        Me.linkCteExpressions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkCteExpressions.LinkColor = System.Drawing.Color.Black
        Me.linkCteExpressions.Location = New System.Drawing.Point(0, 149)
        Me.linkCteExpressions.Margin = New System.Windows.Forms.Padding(0)
        Me.linkCteExpressions.Name = "linkCteExpressions"
        Me.linkCteExpressions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkCteExpressions.Size = New System.Drawing.Size(101, 23)
        Me.linkCteExpressions.TabIndex = 31
        Me.linkCteExpressions.TabStop = true
        Me.linkCteExpressions.Text = "    Expressions"
        Me.linkCteExpressions.UseCompatibleTextRendering = true
        Me.linkCteExpressions.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkDerived
        '
        Me.linkDerived.AutoSize = true
        Me.linkDerived.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.linkDerived.ForeColor = System.Drawing.Color.Black
        Me.linkDerived.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkDerived.LinkColor = System.Drawing.Color.Black
        Me.linkDerived.Location = New System.Drawing.Point(0, 172)
        Me.linkDerived.Margin = New System.Windows.Forms.Padding(0)
        Me.linkDerived.Name = "linkDerived"
        Me.linkDerived.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkDerived.Size = New System.Drawing.Size(100, 23)
        Me.linkDerived.TabIndex = 32
        Me.linkDerived.TabStop = true
        Me.linkDerived.Text = "Derived query"
        Me.linkDerived.UseCompatibleTextRendering = true
        Me.linkDerived.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkDerivedCommon
        '
        Me.linkDerivedCommon.AutoSize = true
        Me.linkDerivedCommon.ForeColor = System.Drawing.Color.Black
        Me.linkDerivedCommon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkDerivedCommon.LinkColor = System.Drawing.Color.Black
        Me.linkDerivedCommon.Location = New System.Drawing.Point(0, 195)
        Me.linkDerivedCommon.Margin = New System.Windows.Forms.Padding(0)
        Me.linkDerivedCommon.Name = "linkDerivedCommon"
        Me.linkDerivedCommon.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkDerivedCommon.Size = New System.Drawing.Size(85, 23)
        Me.linkDerivedCommon.TabIndex = 33
        Me.linkDerivedCommon.TabStop = true
        Me.linkDerivedCommon.Text = "    Common"
        Me.linkDerivedCommon.UseCompatibleTextRendering = true
        Me.linkDerivedCommon.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkDerivedExpressions
        '
        Me.linkDerivedExpressions.AutoSize = true
        Me.linkDerivedExpressions.ForeColor = System.Drawing.Color.Black
        Me.linkDerivedExpressions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkDerivedExpressions.LinkColor = System.Drawing.Color.Black
        Me.linkDerivedExpressions.Location = New System.Drawing.Point(0, 218)
        Me.linkDerivedExpressions.Margin = New System.Windows.Forms.Padding(0)
        Me.linkDerivedExpressions.Name = "linkDerivedExpressions"
        Me.linkDerivedExpressions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkDerivedExpressions.Size = New System.Drawing.Size(101, 23)
        Me.linkDerivedExpressions.TabIndex = 34
        Me.linkDerivedExpressions.TabStop = true
        Me.linkDerivedExpressions.Text = "    Expressions"
        Me.linkDerivedExpressions.UseCompatibleTextRendering = true
        Me.linkDerivedExpressions.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkExpression
        '
        Me.linkExpression.AutoSize = true
        Me.linkExpression.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.linkExpression.ForeColor = System.Drawing.Color.Black
        Me.linkExpression.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkExpression.LinkColor = System.Drawing.Color.Black
        Me.linkExpression.Location = New System.Drawing.Point(0, 241)
        Me.linkExpression.Margin = New System.Windows.Forms.Padding(0)
        Me.linkExpression.Name = "linkExpression"
        Me.linkExpression.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkExpression.Size = New System.Drawing.Size(137, 23)
        Me.linkExpression.TabIndex = 35
        Me.linkExpression.TabStop = true
        Me.linkExpression.Text = "Expression subquery"
        Me.linkExpression.UseCompatibleTextRendering = true
        Me.linkExpression.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkExpressionCommon
        '
        Me.linkExpressionCommon.AutoSize = true
        Me.linkExpressionCommon.ForeColor = System.Drawing.Color.Black
        Me.linkExpressionCommon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkExpressionCommon.LinkColor = System.Drawing.Color.Black
        Me.linkExpressionCommon.Location = New System.Drawing.Point(0, 264)
        Me.linkExpressionCommon.Margin = New System.Windows.Forms.Padding(0)
        Me.linkExpressionCommon.Name = "linkExpressionCommon"
        Me.linkExpressionCommon.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkExpressionCommon.Size = New System.Drawing.Size(85, 23)
        Me.linkExpressionCommon.TabIndex = 36
        Me.linkExpressionCommon.TabStop = true
        Me.linkExpressionCommon.Text = "    Common"
        Me.linkExpressionCommon.UseCompatibleTextRendering = true
        Me.linkExpressionCommon.VisitedLinkColor = System.Drawing.Color.Black
        '
        'linkExpressionExpressions
        '
        Me.linkExpressionExpressions.AutoSize = true
        Me.linkExpressionExpressions.ForeColor = System.Drawing.Color.Black
        Me.linkExpressionExpressions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkExpressionExpressions.LinkColor = System.Drawing.Color.Black
        Me.linkExpressionExpressions.Location = New System.Drawing.Point(0, 287)
        Me.linkExpressionExpressions.Margin = New System.Windows.Forms.Padding(0)
        Me.linkExpressionExpressions.Name = "linkExpressionExpressions"
        Me.linkExpressionExpressions.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.linkExpressionExpressions.Size = New System.Drawing.Size(101, 23)
        Me.linkExpressionExpressions.TabIndex = 37
        Me.linkExpressionExpressions.TabStop = true
        Me.linkExpressionExpressions.Text = "    Expressions"
        Me.linkExpressionExpressions.UseCompatibleTextRendering = true
        Me.linkExpressionExpressions.VisitedLinkColor = System.Drawing.Color.Black
        '
        'QueryPropertiesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(724, 482)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.panelButtons)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "QueryPropertiesForm"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Properties"
        Me.panelButtons.ResumeLayout(false)
        Me.tabControl.ResumeLayout(false)
        Me.tabQueryBuilder.ResumeLayout(false)
        Me.panelQueryBuilder.ResumeLayout(false)
        Me.panelQueryBuilder.PerformLayout
        Me.flowLayoutPanel1.ResumeLayout(false)
        Me.flowLayoutPanel1.PerformLayout
        Me.tabFormatting.ResumeLayout(false)
        Me.panelSqlFormatting.ResumeLayout(false)
        Me.panelSqlFormatting.PerformLayout
        Me.flowLayoutPanel2.ResumeLayout(false)
        Me.flowLayoutPanel2.PerformLayout
        Me.ResumeLayout(false)

End Sub

		#End Region

		Private panelButtons As System.Windows.Forms.Panel
		Private buttonCancel As System.Windows.Forms.Button
		Private tabControl As System.Windows.Forms.TabControl
		Private tabQueryBuilder As System.Windows.Forms.TabPage
		Private panelQueryBuilder As System.Windows.Forms.Panel
		Private panelPages1 As System.Windows.Forms.Panel
		Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
		Private labelNonVisual As System.Windows.Forms.Label
		Private WithEvents linkSqlSyntax As System.Windows.Forms.LinkLabel
		Private WithEvents linkOfflineMode As System.Windows.Forms.LinkLabel
		Private labelVisual As System.Windows.Forms.Label
		Private WithEvents linkBehaviorOptions As System.Windows.Forms.LinkLabel
		Private WithEvents linkDatabaseSchemaView As System.Windows.Forms.LinkLabel
		Private WithEvents linkDesignPane As System.Windows.Forms.LinkLabel
		Private WithEvents linkVisualOptions As System.Windows.Forms.LinkLabel
		Private WithEvents linkAddObjectDialog As System.Windows.Forms.LinkLabel
		Private WithEvents linkDatasourceOptions As System.Windows.Forms.LinkLabel
		Private WithEvents linkMetadataLoadingOptions As System.Windows.Forms.LinkLabel
		Private WithEvents linkMetadataStructureOptions As System.Windows.Forms.LinkLabel
		Private WithEvents linkQueryColumnList As System.Windows.Forms.LinkLabel
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
		Private WithEvents buttonSave As System.Windows.Forms.Button
		Private WithEvents buttonLoad As System.Windows.Forms.Button
        Private WithEvents LinkQueryNavBar As System.Windows.Forms.LinkLabel
        Private WithEvents LinkUserInterface As System.Windows.Forms.LinkLabel
    End Class
End Namespace
