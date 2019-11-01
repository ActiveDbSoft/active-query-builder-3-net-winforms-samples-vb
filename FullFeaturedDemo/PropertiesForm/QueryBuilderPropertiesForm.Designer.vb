Namespace PropertiesForm
	Partial Class QueryBuilderPropertiesForm
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(QueryBuilderPropertiesForm))
			Me.panelButtons = New System.Windows.Forms.Panel()
			Me.buttonApply = New System.Windows.Forms.Button()
			Me.buttonOk = New System.Windows.Forms.Button()
			Me.buttonCancel = New System.Windows.Forms.Button()
			Me.label17 = New System.Windows.Forms.Label()
			Me.numericUpDown6 = New System.Windows.Forms.NumericUpDown()
			Me.checkBox27 = New System.Windows.Forms.CheckBox()
			Me.checkBox28 = New System.Windows.Forms.CheckBox()
			Me.checkBox29 = New System.Windows.Forms.CheckBox()
			Me.label18 = New System.Windows.Forms.Label()
			Me.numericUpDown7 = New System.Windows.Forms.NumericUpDown()
			Me.checkBox30 = New System.Windows.Forms.CheckBox()
			Me.checkBox31 = New System.Windows.Forms.CheckBox()
			Me.checkBox32 = New System.Windows.Forms.CheckBox()
			Me.checkBox33 = New System.Windows.Forms.CheckBox()
			Me.checkBox34 = New System.Windows.Forms.CheckBox()
			Me.numericUpDown8 = New System.Windows.Forms.NumericUpDown()
			Me.label19 = New System.Windows.Forms.Label()
			Me.label20 = New System.Windows.Forms.Label()
			Me.numericUpDown9 = New System.Windows.Forms.NumericUpDown()
			Me.checkBox35 = New System.Windows.Forms.CheckBox()
			Me.checkBox36 = New System.Windows.Forms.CheckBox()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panelPages = New System.Windows.Forms.Panel()
			Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
			Me.labelNonVisual = New System.Windows.Forms.Label()
			Me.linkSqlSyntax = New System.Windows.Forms.LinkLabel()
			Me.linkOfflineMode = New System.Windows.Forms.LinkLabel()
			Me.labelVisual = New System.Windows.Forms.Label()
			Me.linkPanesVisibility = New System.Windows.Forms.LinkLabel()
			Me.linkMetadataTree = New System.Windows.Forms.LinkLabel()
			Me.linkMiscellaneous = New System.Windows.Forms.LinkLabel()
			Me.labelSqlBuilder = New System.Windows.Forms.Label()
			Me.linkGeneral = New System.Windows.Forms.LinkLabel()
			Me.linkMainQuery = New System.Windows.Forms.LinkLabel()
			Me.linkDerievedQueries = New System.Windows.Forms.LinkLabel()
			Me.linkExpressionSubqueries = New System.Windows.Forms.LinkLabel()
			Me.panelHeader = New System.Windows.Forms.Panel()
			Me.labelHeader = New System.Windows.Forms.Label()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.panelButtons.SuspendLayout()
			DirectCast(Me.numericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.numericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.numericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.numericUpDown9, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.flowLayoutPanel1.SuspendLayout()
			Me.panelHeader.SuspendLayout()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelButtons
			' 
			Me.panelButtons.Controls.Add(Me.buttonApply)
			Me.panelButtons.Controls.Add(Me.buttonOk)
			Me.panelButtons.Controls.Add(Me.buttonCancel)
			Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelButtons.Location = New System.Drawing.Point(0, 438)
			Me.panelButtons.Name = "panelButtons"
			Me.panelButtons.Size = New System.Drawing.Size(624, 39)
			Me.panelButtons.TabIndex = 2
			' 
			' buttonApply
			' 
			Me.buttonApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.buttonApply.Location = New System.Drawing.Point(540, 4)
			Me.buttonApply.Name = "buttonApply"
			Me.buttonApply.Size = New System.Drawing.Size(75, 23)
			Me.buttonApply.TabIndex = 2
			Me.buttonApply.Text = "Apply"
			Me.buttonApply.UseVisualStyleBackColor = True
			AddHandler Me.buttonApply.Click, New System.EventHandler(AddressOf Me.buttonApply_Click)
			' 
			' buttonOk
			' 
			Me.buttonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.buttonOk.Location = New System.Drawing.Point(378, 4)
			Me.buttonOk.Name = "buttonOk"
			Me.buttonOk.Size = New System.Drawing.Size(75, 23)
			Me.buttonOk.TabIndex = 0
			Me.buttonOk.Text = "OK"
			Me.buttonOk.UseVisualStyleBackColor = True
			AddHandler Me.buttonOk.Click, New System.EventHandler(AddressOf Me.buttonOk_Click)
			' 
			' buttonCancel
			' 
			Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.buttonCancel.Location = New System.Drawing.Point(459, 4)
			Me.buttonCancel.Name = "buttonCancel"
			Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
			Me.buttonCancel.TabIndex = 1
			Me.buttonCancel.Text = "Cancel"
			Me.buttonCancel.UseVisualStyleBackColor = True
			' 
			' label17
			' 
			Me.label17.AutoSize = True
			Me.label17.Location = New System.Drawing.Point(283, 20)
			Me.label17.Name = "label17"
			Me.label17.Size = New System.Drawing.Size(127, 13)
			Me.label17.TabIndex = 5
			Me.label17.Text = "Nested conditions indent:"
			' 
			' numericUpDown6
			' 
			Me.numericUpDown6.Location = New System.Drawing.Point(416, 18)
			Me.numericUpDown6.Name = "numericUpDown6"
			Me.numericUpDown6.Size = New System.Drawing.Size(45, 20)
			Me.numericUpDown6.TabIndex = 5
			' 
			' checkBox27
			' 
			Me.checkBox27.AutoSize = True
			Me.checkBox27.Location = New System.Drawing.Point(6, 42)
			Me.checkBox27.Name = "checkBox27"
			Me.checkBox27.Size = New System.Drawing.Size(248, 17)
			Me.checkBox27.TabIndex = 2
			Me.checkBox27.Text = "Insert new line after the rest of logical operators"
			Me.checkBox27.UseVisualStyleBackColor = True
			' 
			' checkBox28
			' 
			Me.checkBox28.AutoSize = True
			Me.checkBox28.Location = New System.Drawing.Point(6, 19)
			Me.checkBox28.Name = "checkBox28"
			Me.checkBox28.Size = New System.Drawing.Size(238, 17)
			Me.checkBox28.TabIndex = 1
			Me.checkBox28.Text = "Insert new line after topmost logical operators"
			Me.checkBox28.UseVisualStyleBackColor = True
			' 
			' checkBox29
			' 
			Me.checkBox29.AutoSize = True
			Me.checkBox29.Location = New System.Drawing.Point(6, 19)
			Me.checkBox29.Name = "checkBox29"
			Me.checkBox29.Size = New System.Drawing.Size(212, 17)
			Me.checkBox29.TabIndex = 1
			Me.checkBox29.Text = "Insert new line after each group list item"
			Me.checkBox29.UseVisualStyleBackColor = True
			' 
			' label18
			' 
			Me.label18.AutoSize = True
			Me.label18.Location = New System.Drawing.Point(283, 20)
			Me.label18.Name = "label18"
			Me.label18.Size = New System.Drawing.Size(127, 13)
			Me.label18.TabIndex = 5
			Me.label18.Text = "Nested conditions indent:"
			' 
			' numericUpDown7
			' 
			Me.numericUpDown7.Location = New System.Drawing.Point(416, 18)
			Me.numericUpDown7.Name = "numericUpDown7"
			Me.numericUpDown7.Size = New System.Drawing.Size(45, 20)
			Me.numericUpDown7.TabIndex = 5
			' 
			' checkBox30
			' 
			Me.checkBox30.AutoSize = True
			Me.checkBox30.Location = New System.Drawing.Point(6, 42)
			Me.checkBox30.Name = "checkBox30"
			Me.checkBox30.Size = New System.Drawing.Size(248, 17)
			Me.checkBox30.TabIndex = 2
			Me.checkBox30.Text = "Insert new line after the rest of logical operators"
			Me.checkBox30.UseVisualStyleBackColor = True
			' 
			' checkBox31
			' 
			Me.checkBox31.AutoSize = True
			Me.checkBox31.Location = New System.Drawing.Point(6, 19)
			Me.checkBox31.Name = "checkBox31"
			Me.checkBox31.Size = New System.Drawing.Size(238, 17)
			Me.checkBox31.TabIndex = 1
			Me.checkBox31.Text = "Insert new line after topmost logical operators"
			Me.checkBox31.UseVisualStyleBackColor = True
			' 
			' checkBox32
			' 
			Me.checkBox32.AutoSize = True
			Me.checkBox32.Location = New System.Drawing.Point(6, 42)
			Me.checkBox32.Name = "checkBox32"
			Me.checkBox32.Size = New System.Drawing.Size(215, 17)
			Me.checkBox32.TabIndex = 2
			Me.checkBox32.Text = "Insert new line after each JOIN keyword"
			Me.checkBox32.UseVisualStyleBackColor = True
			' 
			' checkBox33
			' 
			Me.checkBox33.AutoSize = True
			Me.checkBox33.Location = New System.Drawing.Point(6, 19)
			Me.checkBox33.Name = "checkBox33"
			Me.checkBox33.Size = New System.Drawing.Size(229, 17)
			Me.checkBox33.TabIndex = 1
			Me.checkBox33.Text = "Insert new line after each datat source item"
			Me.checkBox33.UseVisualStyleBackColor = True
			' 
			' checkBox34
			' 
			Me.checkBox34.AutoSize = True
			Me.checkBox34.Location = New System.Drawing.Point(6, 19)
			Me.checkBox34.Name = "checkBox34"
			Me.checkBox34.Size = New System.Drawing.Size(213, 17)
			Me.checkBox34.TabIndex = 1
			Me.checkBox34.Text = "Insert new line after each select list item"
			Me.checkBox34.UseVisualStyleBackColor = True
			' 
			' numericUpDown8
			' 
			Me.numericUpDown8.Location = New System.Drawing.Point(308, 44)
			Me.numericUpDown8.Name = "numericUpDown8"
			Me.numericUpDown8.Size = New System.Drawing.Size(45, 20)
			Me.numericUpDown8.TabIndex = 4
			' 
			' label19
			' 
			Me.label19.AutoSize = True
			Me.label19.Location = New System.Drawing.Point(228, 46)
			Me.label19.Name = "label19"
			Me.label19.Size = New System.Drawing.Size(61, 13)
			Me.label19.TabIndex = 3
			Me.label19.Text = "Part indent:"
			' 
			' label20
			' 
			Me.label20.AutoSize = True
			Me.label20.Location = New System.Drawing.Point(228, 20)
			Me.label20.Name = "label20"
			Me.label20.Size = New System.Drawing.Size(72, 13)
			Me.label20.TabIndex = 1
			Me.label20.Text = "Global indent:"
			' 
			' numericUpDown9
			' 
			Me.numericUpDown9.Location = New System.Drawing.Point(308, 18)
			Me.numericUpDown9.Name = "numericUpDown9"
			Me.numericUpDown9.Size = New System.Drawing.Size(45, 20)
			Me.numericUpDown9.TabIndex = 1
			' 
			' checkBox35
			' 
			Me.checkBox35.AutoSize = True
			Me.checkBox35.Location = New System.Drawing.Point(6, 45)
			Me.checkBox35.Name = "checkBox35"
			Me.checkBox35.Size = New System.Drawing.Size(182, 17)
			Me.checkBox35.TabIndex = 2
			Me.checkBox35.Text = "Insert new line after part keyword"
			Me.checkBox35.UseVisualStyleBackColor = True
			' 
			' checkBox36
			' 
			Me.checkBox36.AutoSize = True
			Me.checkBox36.Location = New System.Drawing.Point(6, 19)
			Me.checkBox36.Name = "checkBox36"
			Me.checkBox36.Size = New System.Drawing.Size(136, 17)
			Me.checkBox36.TabIndex = 1
			Me.checkBox36.Text = "Start parts on new lines"
			Me.checkBox36.UseVisualStyleBackColor = True
			' 
			' panel1
			' 
			Me.panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.panel1.Controls.Add(Me.panelPages)
			Me.panel1.Controls.Add(Me.flowLayoutPanel1)
			Me.panel1.Controls.Add(Me.panelHeader)
			Me.panel1.Location = New System.Drawing.Point(12, 12)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(600, 420)
			Me.panel1.TabIndex = 3
			' 
			' panelPages
			' 
			Me.panelPages.AutoScroll = True
			Me.panelPages.AutoSize = True
			Me.panelPages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.panelPages.BackColor = System.Drawing.Color.White
			Me.panelPages.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelPages.Location = New System.Drawing.Point(170, 60)
			Me.panelPages.Margin = New System.Windows.Forms.Padding(0)
			Me.panelPages.Name = "panelPages"
			Me.panelPages.Padding = New System.Windows.Forms.Padding(10, 10, 6, 6)
			Me.panelPages.Size = New System.Drawing.Size(430, 360)
			Me.panelPages.TabIndex = 7
			' 
			' flowLayoutPanel1
			' 
			Me.flowLayoutPanel1.BackColor = System.Drawing.Color.White
			Me.flowLayoutPanel1.Controls.Add(Me.labelNonVisual)
			Me.flowLayoutPanel1.Controls.Add(Me.linkSqlSyntax)
			Me.flowLayoutPanel1.Controls.Add(Me.linkOfflineMode)
			Me.flowLayoutPanel1.Controls.Add(Me.labelVisual)
			Me.flowLayoutPanel1.Controls.Add(Me.linkPanesVisibility)
			Me.flowLayoutPanel1.Controls.Add(Me.linkMetadataTree)
			Me.flowLayoutPanel1.Controls.Add(Me.linkMiscellaneous)
			Me.flowLayoutPanel1.Controls.Add(Me.labelSqlBuilder)
			Me.flowLayoutPanel1.Controls.Add(Me.linkGeneral)
			Me.flowLayoutPanel1.Controls.Add(Me.linkMainQuery)
			Me.flowLayoutPanel1.Controls.Add(Me.linkDerievedQueries)
			Me.flowLayoutPanel1.Controls.Add(Me.linkExpressionSubqueries)
			Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
			Me.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
			Me.flowLayoutPanel1.Location = New System.Drawing.Point(0, 60)
			Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
			Me.flowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
			Me.flowLayoutPanel1.Size = New System.Drawing.Size(170, 360)
			Me.flowLayoutPanel1.TabIndex = 6
			AddHandler Me.flowLayoutPanel1.Paint, New System.Windows.Forms.PaintEventHandler(AddressOf Me.flowLayoutPanel1_Paint)
			' 
			' labelNonVisual
			' 
			Me.labelNonVisual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.labelNonVisual.AutoSize = True
			Me.labelNonVisual.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
			Me.labelNonVisual.Location = New System.Drawing.Point(0, 10)
			Me.labelNonVisual.Margin = New System.Windows.Forms.Padding(0)
			Me.labelNonVisual.Name = "labelNonVisual"
			Me.labelNonVisual.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.labelNonVisual.Size = New System.Drawing.Size(148, 24)
			Me.labelNonVisual.TabIndex = 0
			Me.labelNonVisual.Text = "Non-visual Options"
			Me.labelNonVisual.UseCompatibleTextRendering = True
			' 
			' linkSqlSyntax
			' 
			Me.linkSqlSyntax.AutoSize = True
			Me.linkSqlSyntax.ForeColor = System.Drawing.Color.Black
			Me.linkSqlSyntax.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkSqlSyntax.LinkColor = System.Drawing.Color.Black
			Me.linkSqlSyntax.Location = New System.Drawing.Point(0, 34)
			Me.linkSqlSyntax.Margin = New System.Windows.Forms.Padding(0)
			Me.linkSqlSyntax.Name = "linkSqlSyntax"
			Me.linkSqlSyntax.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkSqlSyntax.Size = New System.Drawing.Size(87, 23)
			Me.linkSqlSyntax.TabIndex = 3
			Me.linkSqlSyntax.TabStop = True
			Me.linkSqlSyntax.Text = "SQL Syntax"
			Me.linkSqlSyntax.UseCompatibleTextRendering = True
			Me.linkSqlSyntax.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkSqlSyntax.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu_LinkClicked)
			' 
			' linkOfflineMode
			' 
			Me.linkOfflineMode.AutoSize = True
			Me.linkOfflineMode.ForeColor = System.Drawing.Color.Black
			Me.linkOfflineMode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkOfflineMode.LinkColor = System.Drawing.Color.Black
			Me.linkOfflineMode.Location = New System.Drawing.Point(0, 57)
			Me.linkOfflineMode.Margin = New System.Windows.Forms.Padding(0)
			Me.linkOfflineMode.Name = "linkOfflineMode"
			Me.linkOfflineMode.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkOfflineMode.Size = New System.Drawing.Size(91, 23)
			Me.linkOfflineMode.TabIndex = 4
			Me.linkOfflineMode.TabStop = True
			Me.linkOfflineMode.Text = "Offline Mode"
			Me.linkOfflineMode.UseCompatibleTextRendering = True
			Me.linkOfflineMode.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkOfflineMode.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu_LinkClicked)
			' 
			' labelVisual
			' 
			Me.labelVisual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.labelVisual.AutoSize = True
			Me.labelVisual.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
			Me.labelVisual.Location = New System.Drawing.Point(0, 80)
			Me.labelVisual.Margin = New System.Windows.Forms.Padding(0)
			Me.labelVisual.Name = "labelVisual"
			Me.labelVisual.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.labelVisual.Size = New System.Drawing.Size(148, 24)
			Me.labelVisual.TabIndex = 5
			Me.labelVisual.Text = "Visual Options"
			Me.labelVisual.UseCompatibleTextRendering = True
			' 
			' linkPanesVisibility
			' 
			Me.linkPanesVisibility.AutoSize = True
			Me.linkPanesVisibility.ForeColor = System.Drawing.Color.Black
			Me.linkPanesVisibility.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkPanesVisibility.LinkColor = System.Drawing.Color.Black
			Me.linkPanesVisibility.Location = New System.Drawing.Point(0, 104)
			Me.linkPanesVisibility.Margin = New System.Windows.Forms.Padding(0)
			Me.linkPanesVisibility.Name = "linkPanesVisibility"
			Me.linkPanesVisibility.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkPanesVisibility.Size = New System.Drawing.Size(104, 23)
			Me.linkPanesVisibility.TabIndex = 6
			Me.linkPanesVisibility.TabStop = True
			Me.linkPanesVisibility.Text = "Panes Visibility"
			Me.linkPanesVisibility.UseCompatibleTextRendering = True
			Me.linkPanesVisibility.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkPanesVisibility.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu_LinkClicked)
			' 
			' linkMetadataTree
			' 
			Me.linkMetadataTree.AutoSize = True
			Me.linkMetadataTree.ForeColor = System.Drawing.Color.Black
			Me.linkMetadataTree.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkMetadataTree.LinkColor = System.Drawing.Color.Black
			Me.linkMetadataTree.Location = New System.Drawing.Point(0, 127)
			Me.linkMetadataTree.Margin = New System.Windows.Forms.Padding(0)
			Me.linkMetadataTree.Name = "linkMetadataTree"
			Me.linkMetadataTree.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkMetadataTree.Size = New System.Drawing.Size(148, 23)
			Me.linkMetadataTree.TabIndex = 8
			Me.linkMetadataTree.TabStop = True
			Me.linkMetadataTree.Text = "Database Schema View"
			Me.linkMetadataTree.UseCompatibleTextRendering = True
			Me.linkMetadataTree.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkMetadataTree.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu_LinkClicked)
			' 
			' linkMiscellaneous
			' 
			Me.linkMiscellaneous.AutoSize = True
			Me.linkMiscellaneous.ForeColor = System.Drawing.Color.Black
			Me.linkMiscellaneous.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkMiscellaneous.LinkColor = System.Drawing.Color.Black
			Me.linkMiscellaneous.Location = New System.Drawing.Point(0, 150)
			Me.linkMiscellaneous.Margin = New System.Windows.Forms.Padding(0)
			Me.linkMiscellaneous.Name = "linkMiscellaneous"
			Me.linkMiscellaneous.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkMiscellaneous.Size = New System.Drawing.Size(99, 23)
			Me.linkMiscellaneous.TabIndex = 9
			Me.linkMiscellaneous.TabStop = True
			Me.linkMiscellaneous.Text = "Miscellaneous"
			Me.linkMiscellaneous.UseCompatibleTextRendering = True
			Me.linkMiscellaneous.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkMiscellaneous.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu_LinkClicked)
			' 
			' labelSqlBuilder
			' 
			Me.labelSqlBuilder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.labelSqlBuilder.AutoSize = True
			Me.labelSqlBuilder.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
			Me.labelSqlBuilder.Location = New System.Drawing.Point(0, 173)
			Me.labelSqlBuilder.Margin = New System.Windows.Forms.Padding(0)
			Me.labelSqlBuilder.Name = "labelSqlBuilder"
			Me.labelSqlBuilder.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.labelSqlBuilder.Size = New System.Drawing.Size(148, 24)
			Me.labelSqlBuilder.TabIndex = 10
			Me.labelSqlBuilder.Text = "SQL Builder Options"
			Me.labelSqlBuilder.UseCompatibleTextRendering = True
			' 
			' linkGeneral
			' 
			Me.linkGeneral.AutoSize = True
			Me.linkGeneral.ForeColor = System.Drawing.Color.Black
			Me.linkGeneral.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkGeneral.LinkColor = System.Drawing.Color.Black
			Me.linkGeneral.Location = New System.Drawing.Point(0, 197)
			Me.linkGeneral.Margin = New System.Windows.Forms.Padding(0)
			Me.linkGeneral.Name = "linkGeneral"
			Me.linkGeneral.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkGeneral.Size = New System.Drawing.Size(68, 23)
			Me.linkGeneral.TabIndex = 11
			Me.linkGeneral.TabStop = True
			Me.linkGeneral.Text = "General"
			Me.linkGeneral.UseCompatibleTextRendering = True
			Me.linkGeneral.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkGeneral.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu_LinkClicked)
			' 
			' linkMainQuery
			' 
			Me.linkMainQuery.AutoSize = True
			Me.linkMainQuery.ForeColor = System.Drawing.Color.Black
			Me.linkMainQuery.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkMainQuery.LinkColor = System.Drawing.Color.Black
			Me.linkMainQuery.Location = New System.Drawing.Point(0, 220)
			Me.linkMainQuery.Margin = New System.Windows.Forms.Padding(0)
			Me.linkMainQuery.Name = "linkMainQuery"
			Me.linkMainQuery.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkMainQuery.Size = New System.Drawing.Size(86, 23)
			Me.linkMainQuery.TabIndex = 12
			Me.linkMainQuery.TabStop = True
			Me.linkMainQuery.Text = "Main Query"
			Me.linkMainQuery.UseCompatibleTextRendering = True
			Me.linkMainQuery.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkMainQuery.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu_LinkClicked)
			' 
			' linkDerievedQueries
			' 
			Me.linkDerievedQueries.AutoSize = True
			Me.linkDerievedQueries.ForeColor = System.Drawing.Color.Black
			Me.linkDerievedQueries.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkDerievedQueries.LinkColor = System.Drawing.Color.Black
			Me.linkDerievedQueries.Location = New System.Drawing.Point(0, 243)
			Me.linkDerievedQueries.Margin = New System.Windows.Forms.Padding(0)
			Me.linkDerievedQueries.Name = "linkDerievedQueries"
			Me.linkDerievedQueries.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkDerievedQueries.Size = New System.Drawing.Size(115, 23)
			Me.linkDerievedQueries.TabIndex = 13
			Me.linkDerievedQueries.TabStop = True
			Me.linkDerievedQueries.Text = "Derieved Queries"
			Me.linkDerievedQueries.UseCompatibleTextRendering = True
			Me.linkDerievedQueries.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkDerievedQueries.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu_LinkClicked)
			' 
			' linkExpressionSubqueries
			' 
			Me.linkExpressionSubqueries.AutoSize = True
			Me.linkExpressionSubqueries.ForeColor = System.Drawing.Color.Black
			Me.linkExpressionSubqueries.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkExpressionSubqueries.LinkColor = System.Drawing.Color.Black
			Me.linkExpressionSubqueries.Location = New System.Drawing.Point(0, 266)
			Me.linkExpressionSubqueries.Margin = New System.Windows.Forms.Padding(0)
			Me.linkExpressionSubqueries.Name = "linkExpressionSubqueries"
			Me.linkExpressionSubqueries.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
			Me.linkExpressionSubqueries.Size = New System.Drawing.Size(137, 23)
			Me.linkExpressionSubqueries.TabIndex = 14
			Me.linkExpressionSubqueries.TabStop = True
			Me.linkExpressionSubqueries.Text = "Expression Subqeries"
			Me.linkExpressionSubqueries.UseCompatibleTextRendering = True
			Me.linkExpressionSubqueries.VisitedLinkColor = System.Drawing.Color.Black
			AddHandler Me.linkExpressionSubqueries.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.SideMenu_LinkClicked)
			' 
			' panelHeader
			' 
			Me.panelHeader.BackColor = System.Drawing.Color.White
			Me.panelHeader.Controls.Add(Me.labelHeader)
			Me.panelHeader.Controls.Add(Me.pictureBox1)
			Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelHeader.Location = New System.Drawing.Point(0, 0)
			Me.panelHeader.Name = "panelHeader"
			Me.panelHeader.Size = New System.Drawing.Size(600, 60)
			Me.panelHeader.TabIndex = 8
			' 
			' labelHeader
			' 
			Me.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelHeader.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
			Me.labelHeader.ForeColor = System.Drawing.Color.CornflowerBlue
			Me.labelHeader.Location = New System.Drawing.Point(0, 0)
			Me.labelHeader.Margin = New System.Windows.Forms.Padding(0)
			Me.labelHeader.Name = "labelHeader"
			Me.labelHeader.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.labelHeader.Size = New System.Drawing.Size(539, 60)
			Me.labelHeader.TabIndex = 1
			Me.labelHeader.Text = "Query Builder Properties"
			Me.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right
			Me.pictureBox1.Image = DirectCast(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
			Me.pictureBox1.Location = New System.Drawing.Point(539, 0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(61, 60)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' QueryBuilderPropertiesForm
			' 
			Me.AcceptButton = Me.buttonOk
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.buttonCancel
			Me.ClientSize = New System.Drawing.Size(624, 477)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.panelButtons)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "QueryBuilderPropertiesForm"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Query Builder Properties"
			AddHandler Me.Paint, New System.Windows.Forms.PaintEventHandler(AddressOf Me.QueryBuilderPropertiesForm_Paint)
			Me.panelButtons.ResumeLayout(False)
			DirectCast(Me.numericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.numericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.numericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.numericUpDown9, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.flowLayoutPanel1.ResumeLayout(False)
			Me.flowLayoutPanel1.PerformLayout()
			Me.panelHeader.ResumeLayout(False)
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelButtons As System.Windows.Forms.Panel
		Private buttonOk As System.Windows.Forms.Button
		Private buttonCancel As System.Windows.Forms.Button
		Private label17 As System.Windows.Forms.Label
		Private numericUpDown6 As System.Windows.Forms.NumericUpDown
		Private checkBox27 As System.Windows.Forms.CheckBox
		Private checkBox28 As System.Windows.Forms.CheckBox
		Private checkBox29 As System.Windows.Forms.CheckBox
		Private label18 As System.Windows.Forms.Label
		Private numericUpDown7 As System.Windows.Forms.NumericUpDown
		Private checkBox30 As System.Windows.Forms.CheckBox
		Private checkBox31 As System.Windows.Forms.CheckBox
		Private checkBox32 As System.Windows.Forms.CheckBox
		Private checkBox33 As System.Windows.Forms.CheckBox
		Private checkBox34 As System.Windows.Forms.CheckBox
		Private numericUpDown8 As System.Windows.Forms.NumericUpDown
		Private label19 As System.Windows.Forms.Label
		Private label20 As System.Windows.Forms.Label
		Private numericUpDown9 As System.Windows.Forms.NumericUpDown
		Private checkBox35 As System.Windows.Forms.CheckBox
		Private checkBox36 As System.Windows.Forms.CheckBox
		Private panel1 As System.Windows.Forms.Panel
		Private panelPages As System.Windows.Forms.Panel
		Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
		Private panelHeader As System.Windows.Forms.Panel
		Private labelHeader As System.Windows.Forms.Label
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private labelNonVisual As System.Windows.Forms.Label
		Private linkSqlSyntax As System.Windows.Forms.LinkLabel
		Private linkOfflineMode As System.Windows.Forms.LinkLabel
		Private labelVisual As System.Windows.Forms.Label
		Private linkPanesVisibility As System.Windows.Forms.LinkLabel
		Private linkMetadataTree As System.Windows.Forms.LinkLabel
		Private linkMiscellaneous As System.Windows.Forms.LinkLabel
		Private labelSqlBuilder As System.Windows.Forms.Label
		Private linkGeneral As System.Windows.Forms.LinkLabel
		Private linkMainQuery As System.Windows.Forms.LinkLabel
		Private linkDerievedQueries As System.Windows.Forms.LinkLabel
		Private linkExpressionSubqueries As System.Windows.Forms.LinkLabel
		Private buttonApply As System.Windows.Forms.Button
	End Class
End Namespace
