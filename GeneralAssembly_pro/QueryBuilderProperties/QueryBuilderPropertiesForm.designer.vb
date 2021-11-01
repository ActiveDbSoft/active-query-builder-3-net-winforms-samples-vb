Namespace QueryBuilderProperties
	Partial Public Class QueryBuilderPropertiesForm
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
			Me.panelButtons = New Panel()
			Me.buttonApply = New Button()
			Me.buttonOk = New Button()
			Me.buttonCancel = New Button()
			Me.label17 = New Label()
			Me.numericUpDown6 = New NumericUpDown()
			Me.checkBox27 = New CheckBox()
			Me.checkBox28 = New CheckBox()
			Me.checkBox29 = New CheckBox()
			Me.label18 = New Label()
			Me.numericUpDown7 = New NumericUpDown()
			Me.checkBox30 = New CheckBox()
			Me.checkBox31 = New CheckBox()
			Me.checkBox32 = New CheckBox()
			Me.checkBox33 = New CheckBox()
			Me.checkBox34 = New CheckBox()
			Me.numericUpDown8 = New NumericUpDown()
			Me.label19 = New Label()
			Me.label20 = New Label()
			Me.numericUpDown9 = New NumericUpDown()
			Me.checkBox35 = New CheckBox()
			Me.checkBox36 = New CheckBox()
			Me.panel1 = New Panel()
			Me.panelPages = New Panel()
			Me.flowLayoutPanel1 = New FlowLayoutPanel()
			Me.labelNonVisual = New Label()
			Me.linkSqlSyntax = New LinkLabel()
			Me.linkOfflineMode = New LinkLabel()
			Me.labelVisual = New Label()
			Me.linkPanesVisibility = New LinkLabel()
			Me.linkMetadataTree = New LinkLabel()
			Me.linkMiscellaneous = New LinkLabel()
			Me.labelSqlBuilder = New Label()
			Me.linkGeneral = New LinkLabel()
			Me.linkMainQuery = New LinkLabel()
			Me.linkDerievedQueries = New LinkLabel()
			Me.linkExpressionSubqueries = New LinkLabel()
			Me.panelHeader = New Panel()
			Me.labelHeader = New Label()
			Me.pictureBox1 = New PictureBox()
			Me.panelButtons.SuspendLayout()
			CType(Me.numericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numericUpDown9, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.flowLayoutPanel1.SuspendLayout()
			Me.panelHeader.SuspendLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			'
			' panelButtons
			'
			Me.panelButtons.Controls.Add(Me.buttonApply)
			Me.panelButtons.Controls.Add(Me.buttonOk)
			Me.panelButtons.Controls.Add(Me.buttonCancel)
			Me.panelButtons.Dock = DockStyle.Bottom
			Me.panelButtons.Location = New Point(0, 438)
			Me.panelButtons.Name = "panelButtons"
			Me.panelButtons.Size = New Size(624, 39)
			Me.panelButtons.TabIndex = 2
			'
			' buttonApply
			'
			Me.buttonApply.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.buttonApply.Location = New Point(540, 4)
			Me.buttonApply.Name = "buttonApply"
			Me.buttonApply.Size = New Size(75, 23)
			Me.buttonApply.TabIndex = 2
			Me.buttonApply.Text = "Apply"
			Me.buttonApply.UseVisualStyleBackColor = True
'			Me.buttonApply.Click += New System.EventHandler(Me.buttonApply_Click)
			'
			' buttonOk
			'
			Me.buttonOk.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.buttonOk.DialogResult = DialogResult.OK
			Me.buttonOk.Location = New Point(378, 4)
			Me.buttonOk.Name = "buttonOk"
			Me.buttonOk.Size = New Size(75, 23)
			Me.buttonOk.TabIndex = 0
			Me.buttonOk.Text = "OK"
			Me.buttonOk.UseVisualStyleBackColor = True
'			Me.buttonOk.Click += New System.EventHandler(Me.buttonOk_Click)
			'
			' buttonCancel
			'
			Me.buttonCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.buttonCancel.DialogResult = DialogResult.Cancel
			Me.buttonCancel.Location = New Point(459, 4)
			Me.buttonCancel.Name = "buttonCancel"
			Me.buttonCancel.Size = New Size(75, 23)
			Me.buttonCancel.TabIndex = 1
			Me.buttonCancel.Text = "Cancel"
			Me.buttonCancel.UseVisualStyleBackColor = True
			'
			' label17
			'
			Me.label17.AutoSize = True
			Me.label17.Location = New Point(283, 20)
			Me.label17.Name = "label17"
			Me.label17.Size = New Size(127, 13)
			Me.label17.TabIndex = 5
			Me.label17.Text = "Nested conditions indent:"
			'
			' numericUpDown6
			'
			Me.numericUpDown6.Location = New Point(416, 18)
			Me.numericUpDown6.Name = "numericUpDown6"
			Me.numericUpDown6.Size = New Size(45, 20)
			Me.numericUpDown6.TabIndex = 5
			'
			' checkBox27
			'
			Me.checkBox27.AutoSize = True
			Me.checkBox27.Location = New Point(6, 42)
			Me.checkBox27.Name = "checkBox27"
			Me.checkBox27.Size = New Size(248, 17)
			Me.checkBox27.TabIndex = 2
			Me.checkBox27.Text = "Insert new line after the rest of logical operators"
			Me.checkBox27.UseVisualStyleBackColor = True
			'
			' checkBox28
			'
			Me.checkBox28.AutoSize = True
			Me.checkBox28.Location = New Point(6, 19)
			Me.checkBox28.Name = "checkBox28"
			Me.checkBox28.Size = New Size(238, 17)
			Me.checkBox28.TabIndex = 1
			Me.checkBox28.Text = "Insert new line after topmost logical operators"
			Me.checkBox28.UseVisualStyleBackColor = True
			'
			' checkBox29
			'
			Me.checkBox29.AutoSize = True
			Me.checkBox29.Location = New Point(6, 19)
			Me.checkBox29.Name = "checkBox29"
			Me.checkBox29.Size = New Size(212, 17)
			Me.checkBox29.TabIndex = 1
			Me.checkBox29.Text = "Insert new line after each group list item"
			Me.checkBox29.UseVisualStyleBackColor = True
			'
			' label18
			'
			Me.label18.AutoSize = True
			Me.label18.Location = New Point(283, 20)
			Me.label18.Name = "label18"
			Me.label18.Size = New Size(127, 13)
			Me.label18.TabIndex = 5
			Me.label18.Text = "Nested conditions indent:"
			'
			' numericUpDown7
			'
			Me.numericUpDown7.Location = New Point(416, 18)
			Me.numericUpDown7.Name = "numericUpDown7"
			Me.numericUpDown7.Size = New Size(45, 20)
			Me.numericUpDown7.TabIndex = 5
			'
			' checkBox30
			'
			Me.checkBox30.AutoSize = True
			Me.checkBox30.Location = New Point(6, 42)
			Me.checkBox30.Name = "checkBox30"
			Me.checkBox30.Size = New Size(248, 17)
			Me.checkBox30.TabIndex = 2
			Me.checkBox30.Text = "Insert new line after the rest of logical operators"
			Me.checkBox30.UseVisualStyleBackColor = True
			'
			' checkBox31
			'
			Me.checkBox31.AutoSize = True
			Me.checkBox31.Location = New Point(6, 19)
			Me.checkBox31.Name = "checkBox31"
			Me.checkBox31.Size = New Size(238, 17)
			Me.checkBox31.TabIndex = 1
			Me.checkBox31.Text = "Insert new line after topmost logical operators"
			Me.checkBox31.UseVisualStyleBackColor = True
			'
			' checkBox32
			'
			Me.checkBox32.AutoSize = True
			Me.checkBox32.Location = New Point(6, 42)
			Me.checkBox32.Name = "checkBox32"
			Me.checkBox32.Size = New Size(215, 17)
			Me.checkBox32.TabIndex = 2
			Me.checkBox32.Text = "Insert new line after each JOIN keyword"
			Me.checkBox32.UseVisualStyleBackColor = True
			'
			' checkBox33
			'
			Me.checkBox33.AutoSize = True
			Me.checkBox33.Location = New Point(6, 19)
			Me.checkBox33.Name = "checkBox33"
			Me.checkBox33.Size = New Size(229, 17)
			Me.checkBox33.TabIndex = 1
			Me.checkBox33.Text = "Insert new line after each datat source item"
			Me.checkBox33.UseVisualStyleBackColor = True
			'
			' checkBox34
			'
			Me.checkBox34.AutoSize = True
			Me.checkBox34.Location = New Point(6, 19)
			Me.checkBox34.Name = "checkBox34"
			Me.checkBox34.Size = New Size(213, 17)
			Me.checkBox34.TabIndex = 1
			Me.checkBox34.Text = "Insert new line after each select list item"
			Me.checkBox34.UseVisualStyleBackColor = True
			'
			' numericUpDown8
			'
			Me.numericUpDown8.Location = New Point(308, 44)
			Me.numericUpDown8.Name = "numericUpDown8"
			Me.numericUpDown8.Size = New Size(45, 20)
			Me.numericUpDown8.TabIndex = 4
			'
			' label19
			'
			Me.label19.AutoSize = True
			Me.label19.Location = New Point(228, 46)
			Me.label19.Name = "label19"
			Me.label19.Size = New Size(61, 13)
			Me.label19.TabIndex = 3
			Me.label19.Text = "Part indent:"
			'
			' label20
			'
			Me.label20.AutoSize = True
			Me.label20.Location = New Point(228, 20)
			Me.label20.Name = "label20"
			Me.label20.Size = New Size(72, 13)
			Me.label20.TabIndex = 1
			Me.label20.Text = "Global indent:"
			'
			' numericUpDown9
			'
			Me.numericUpDown9.Location = New Point(308, 18)
			Me.numericUpDown9.Name = "numericUpDown9"
			Me.numericUpDown9.Size = New Size(45, 20)
			Me.numericUpDown9.TabIndex = 1
			'
			' checkBox35
			'
			Me.checkBox35.AutoSize = True
			Me.checkBox35.Location = New Point(6, 45)
			Me.checkBox35.Name = "checkBox35"
			Me.checkBox35.Size = New Size(182, 17)
			Me.checkBox35.TabIndex = 2
			Me.checkBox35.Text = "Insert new line after part keyword"
			Me.checkBox35.UseVisualStyleBackColor = True
			'
			' checkBox36
			'
			Me.checkBox36.AutoSize = True
			Me.checkBox36.Location = New Point(6, 19)
			Me.checkBox36.Name = "checkBox36"
			Me.checkBox36.Size = New Size(136, 17)
			Me.checkBox36.TabIndex = 1
			Me.checkBox36.Text = "Start parts on new lines"
			Me.checkBox36.UseVisualStyleBackColor = True
			'
			' panel1
			'
			Me.panel1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.panel1.Controls.Add(Me.panelPages)
			Me.panel1.Controls.Add(Me.flowLayoutPanel1)
			Me.panel1.Controls.Add(Me.panelHeader)
			Me.panel1.Location = New Point(12, 12)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Size(600, 420)
			Me.panel1.TabIndex = 3
			'
			' panelPages
			'
			Me.panelPages.AutoScroll = True
			Me.panelPages.AutoSize = True
			Me.panelPages.AutoSizeMode = AutoSizeMode.GrowAndShrink
			Me.panelPages.BackColor = Color.White
			Me.panelPages.Dock = DockStyle.Fill
			Me.panelPages.Location = New Point(170, 60)
			Me.panelPages.Margin = New Padding(0)
			Me.panelPages.Name = "panelPages"
			Me.panelPages.Padding = New Padding(10, 10, 6, 6)
			Me.panelPages.Size = New Size(430, 360)
			Me.panelPages.TabIndex = 7
			'
			' flowLayoutPanel1
			'
			Me.flowLayoutPanel1.BackColor = Color.White
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
			Me.flowLayoutPanel1.Dock = DockStyle.Left
			Me.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown
			Me.flowLayoutPanel1.Location = New Point(0, 60)
			Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
			Me.flowLayoutPanel1.Padding = New Padding(0, 10, 0, 0)
			Me.flowLayoutPanel1.Size = New Size(170, 360)
			Me.flowLayoutPanel1.TabIndex = 6
'			Me.flowLayoutPanel1.Paint += New System.Windows.Forms.PaintEventHandler(Me.flowLayoutPanel1_Paint)
			'
			' labelNonVisual
			'
			Me.labelNonVisual.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.labelNonVisual.AutoSize = True
			Me.labelNonVisual.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.labelNonVisual.Location = New Point(0, 10)
			Me.labelNonVisual.Margin = New Padding(0)
			Me.labelNonVisual.Name = "labelNonVisual"
			Me.labelNonVisual.Padding = New Padding(10, 3, 3, 3)
			Me.labelNonVisual.Size = New Size(148, 24)
			Me.labelNonVisual.TabIndex = 0
			Me.labelNonVisual.Text = "Non-visual Options"
			Me.labelNonVisual.UseCompatibleTextRendering = True
			'
			' linkSqlSyntax
			'
			Me.linkSqlSyntax.AutoSize = True
			Me.linkSqlSyntax.ForeColor = Color.Black
			Me.linkSqlSyntax.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkSqlSyntax.LinkColor = Color.Black
			Me.linkSqlSyntax.Location = New Point(0, 34)
			Me.linkSqlSyntax.Margin = New Padding(0)
			Me.linkSqlSyntax.Name = "linkSqlSyntax"
			Me.linkSqlSyntax.Padding = New Padding(20, 3, 3, 3)
			Me.linkSqlSyntax.Size = New Size(87, 23)
			Me.linkSqlSyntax.TabIndex = 3
			Me.linkSqlSyntax.TabStop = True
			Me.linkSqlSyntax.Text = "SQL Syntax"
			Me.linkSqlSyntax.UseCompatibleTextRendering = True
			Me.linkSqlSyntax.VisitedLinkColor = Color.Black
'			Me.linkSqlSyntax.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu_LinkClicked)
			'
			' linkOfflineMode
			'
			Me.linkOfflineMode.AutoSize = True
			Me.linkOfflineMode.ForeColor = Color.Black
			Me.linkOfflineMode.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkOfflineMode.LinkColor = Color.Black
			Me.linkOfflineMode.Location = New Point(0, 57)
			Me.linkOfflineMode.Margin = New Padding(0)
			Me.linkOfflineMode.Name = "linkOfflineMode"
			Me.linkOfflineMode.Padding = New Padding(20, 3, 3, 3)
			Me.linkOfflineMode.Size = New Size(91, 23)
			Me.linkOfflineMode.TabIndex = 4
			Me.linkOfflineMode.TabStop = True
			Me.linkOfflineMode.Text = "Offline Mode"
			Me.linkOfflineMode.UseCompatibleTextRendering = True
			Me.linkOfflineMode.VisitedLinkColor = Color.Black
'			Me.linkOfflineMode.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu_LinkClicked)
			'
			' labelVisual
			'
			Me.labelVisual.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.labelVisual.AutoSize = True
			Me.labelVisual.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.labelVisual.Location = New Point(0, 80)
			Me.labelVisual.Margin = New Padding(0)
			Me.labelVisual.Name = "labelVisual"
			Me.labelVisual.Padding = New Padding(10, 3, 3, 3)
			Me.labelVisual.Size = New Size(148, 24)
			Me.labelVisual.TabIndex = 5
			Me.labelVisual.Text = "Visual Options"
			Me.labelVisual.UseCompatibleTextRendering = True
			'
			' linkPanesVisibility
			'
			Me.linkPanesVisibility.AutoSize = True
			Me.linkPanesVisibility.ForeColor = Color.Black
			Me.linkPanesVisibility.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkPanesVisibility.LinkColor = Color.Black
			Me.linkPanesVisibility.Location = New Point(0, 104)
			Me.linkPanesVisibility.Margin = New Padding(0)
			Me.linkPanesVisibility.Name = "linkPanesVisibility"
			Me.linkPanesVisibility.Padding = New Padding(20, 3, 3, 3)
			Me.linkPanesVisibility.Size = New Size(104, 23)
			Me.linkPanesVisibility.TabIndex = 6
			Me.linkPanesVisibility.TabStop = True
			Me.linkPanesVisibility.Text = "Panes Visibility"
			Me.linkPanesVisibility.UseCompatibleTextRendering = True
			Me.linkPanesVisibility.VisitedLinkColor = Color.Black
'			Me.linkPanesVisibility.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu_LinkClicked)
			'
			' linkMetadataTree
			'
			Me.linkMetadataTree.AutoSize = True
			Me.linkMetadataTree.ForeColor = Color.Black
			Me.linkMetadataTree.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkMetadataTree.LinkColor = Color.Black
			Me.linkMetadataTree.Location = New Point(0, 127)
			Me.linkMetadataTree.Margin = New Padding(0)
			Me.linkMetadataTree.Name = "linkMetadataTree"
			Me.linkMetadataTree.Padding = New Padding(20, 3, 3, 3)
			Me.linkMetadataTree.Size = New Size(148, 23)
			Me.linkMetadataTree.TabIndex = 8
			Me.linkMetadataTree.TabStop = True
			Me.linkMetadataTree.Text = "Database Schema View"
			Me.linkMetadataTree.UseCompatibleTextRendering = True
			Me.linkMetadataTree.VisitedLinkColor = Color.Black
'			Me.linkMetadataTree.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu_LinkClicked)
			'
			' linkMiscellaneous
			'
			Me.linkMiscellaneous.AutoSize = True
			Me.linkMiscellaneous.ForeColor = Color.Black
			Me.linkMiscellaneous.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkMiscellaneous.LinkColor = Color.Black
			Me.linkMiscellaneous.Location = New Point(0, 150)
			Me.linkMiscellaneous.Margin = New Padding(0)
			Me.linkMiscellaneous.Name = "linkMiscellaneous"
			Me.linkMiscellaneous.Padding = New Padding(20, 3, 3, 3)
			Me.linkMiscellaneous.Size = New Size(99, 23)
			Me.linkMiscellaneous.TabIndex = 9
			Me.linkMiscellaneous.TabStop = True
			Me.linkMiscellaneous.Text = "Miscellaneous"
			Me.linkMiscellaneous.UseCompatibleTextRendering = True
			Me.linkMiscellaneous.VisitedLinkColor = Color.Black
'			Me.linkMiscellaneous.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu_LinkClicked)
			'
			' labelSqlBuilder
			'
			Me.labelSqlBuilder.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.labelSqlBuilder.AutoSize = True
			Me.labelSqlBuilder.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.labelSqlBuilder.Location = New Point(0, 173)
			Me.labelSqlBuilder.Margin = New Padding(0)
			Me.labelSqlBuilder.Name = "labelSqlBuilder"
			Me.labelSqlBuilder.Padding = New Padding(10, 3, 3, 3)
			Me.labelSqlBuilder.Size = New Size(148, 24)
			Me.labelSqlBuilder.TabIndex = 10
			Me.labelSqlBuilder.Text = "SQL Builder Options"
			Me.labelSqlBuilder.UseCompatibleTextRendering = True
			'
			' linkGeneral
			'
			Me.linkGeneral.AutoSize = True
			Me.linkGeneral.ForeColor = Color.Black
			Me.linkGeneral.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkGeneral.LinkColor = Color.Black
			Me.linkGeneral.Location = New Point(0, 197)
			Me.linkGeneral.Margin = New Padding(0)
			Me.linkGeneral.Name = "linkGeneral"
			Me.linkGeneral.Padding = New Padding(20, 3, 3, 3)
			Me.linkGeneral.Size = New Size(68, 23)
			Me.linkGeneral.TabIndex = 11
			Me.linkGeneral.TabStop = True
			Me.linkGeneral.Text = "General"
			Me.linkGeneral.UseCompatibleTextRendering = True
			Me.linkGeneral.VisitedLinkColor = Color.Black
'			Me.linkGeneral.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu_LinkClicked)
			'
			' linkMainQuery
			'
			Me.linkMainQuery.AutoSize = True
			Me.linkMainQuery.ForeColor = Color.Black
			Me.linkMainQuery.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkMainQuery.LinkColor = Color.Black
			Me.linkMainQuery.Location = New Point(0, 220)
			Me.linkMainQuery.Margin = New Padding(0)
			Me.linkMainQuery.Name = "linkMainQuery"
			Me.linkMainQuery.Padding = New Padding(20, 3, 3, 3)
			Me.linkMainQuery.Size = New Size(86, 23)
			Me.linkMainQuery.TabIndex = 12
			Me.linkMainQuery.TabStop = True
			Me.linkMainQuery.Text = "Main Query"
			Me.linkMainQuery.UseCompatibleTextRendering = True
			Me.linkMainQuery.VisitedLinkColor = Color.Black
'			Me.linkMainQuery.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu_LinkClicked)
			'
			' linkDerievedQueries
			'
			Me.linkDerievedQueries.AutoSize = True
			Me.linkDerievedQueries.ForeColor = Color.Black
			Me.linkDerievedQueries.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkDerievedQueries.LinkColor = Color.Black
			Me.linkDerievedQueries.Location = New Point(0, 243)
			Me.linkDerievedQueries.Margin = New Padding(0)
			Me.linkDerievedQueries.Name = "linkDerievedQueries"
			Me.linkDerievedQueries.Padding = New Padding(20, 3, 3, 3)
			Me.linkDerievedQueries.Size = New Size(115, 23)
			Me.linkDerievedQueries.TabIndex = 13
			Me.linkDerievedQueries.TabStop = True
			Me.linkDerievedQueries.Text = "Derieved Queries"
			Me.linkDerievedQueries.UseCompatibleTextRendering = True
			Me.linkDerievedQueries.VisitedLinkColor = Color.Black
'			Me.linkDerievedQueries.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu_LinkClicked)
			'
			' linkExpressionSubqueries
			'
			Me.linkExpressionSubqueries.AutoSize = True
			Me.linkExpressionSubqueries.ForeColor = Color.Black
			Me.linkExpressionSubqueries.LinkBehavior = LinkBehavior.HoverUnderline
			Me.linkExpressionSubqueries.LinkColor = Color.Black
			Me.linkExpressionSubqueries.Location = New Point(0, 266)
			Me.linkExpressionSubqueries.Margin = New Padding(0)
			Me.linkExpressionSubqueries.Name = "linkExpressionSubqueries"
			Me.linkExpressionSubqueries.Padding = New Padding(20, 3, 3, 3)
			Me.linkExpressionSubqueries.Size = New Size(137, 23)
			Me.linkExpressionSubqueries.TabIndex = 14
			Me.linkExpressionSubqueries.TabStop = True
			Me.linkExpressionSubqueries.Text = "Expression Subqeries"
			Me.linkExpressionSubqueries.UseCompatibleTextRendering = True
			Me.linkExpressionSubqueries.VisitedLinkColor = Color.Black
'			Me.linkExpressionSubqueries.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.SideMenu_LinkClicked)
			'
			' panelHeader
			'
			Me.panelHeader.BackColor = Color.White
			Me.panelHeader.Controls.Add(Me.labelHeader)
			Me.panelHeader.Controls.Add(Me.pictureBox1)
			Me.panelHeader.Dock = DockStyle.Top
			Me.panelHeader.Location = New Point(0, 0)
			Me.panelHeader.Name = "panelHeader"
			Me.panelHeader.Size = New Size(600, 60)
			Me.panelHeader.TabIndex = 8
			'
			' labelHeader
			'
			Me.labelHeader.Dock = DockStyle.Fill
			Me.labelHeader.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.labelHeader.ForeColor = Color.CornflowerBlue
			Me.labelHeader.Location = New Point(0, 0)
			Me.labelHeader.Margin = New Padding(0)
			Me.labelHeader.Name = "labelHeader"
			Me.labelHeader.Padding = New Padding(10, 0, 0, 0)
			Me.labelHeader.Size = New Size(539, 60)
			Me.labelHeader.TabIndex = 1
			Me.labelHeader.Text = "Query Builder Properties"
			Me.labelHeader.TextAlign = ContentAlignment.MiddleLeft
			'
			' pictureBox1
			'
			Me.pictureBox1.Dock = DockStyle.Right
			Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), Image))
			Me.pictureBox1.Location = New Point(539, 0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Size(61, 60)
			Me.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			'
			' QueryBuilderPropertiesForm
			'
			Me.AcceptButton = Me.buttonOk
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.buttonCancel
			Me.ClientSize = New Size(624, 477)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.panelButtons)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "QueryBuilderPropertiesForm"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Query Builder Properties"
'			Me.Paint += New System.Windows.Forms.PaintEventHandler(Me.QueryBuilderPropertiesForm_Paint)
			Me.panelButtons.ResumeLayout(False)
			CType(Me.numericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numericUpDown9, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.flowLayoutPanel1.ResumeLayout(False)
			Me.flowLayoutPanel1.PerformLayout()
			Me.panelHeader.ResumeLayout(False)
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelButtons As Panel
		Private WithEvents buttonOk As Button
		Private buttonCancel As Button
		Private label17 As Label
		Private numericUpDown6 As NumericUpDown
		Private checkBox27 As CheckBox
		Private checkBox28 As CheckBox
		Private checkBox29 As CheckBox
		Private label18 As Label
		Private numericUpDown7 As NumericUpDown
		Private checkBox30 As CheckBox
		Private checkBox31 As CheckBox
		Private checkBox32 As CheckBox
		Private checkBox33 As CheckBox
		Private checkBox34 As CheckBox
		Private numericUpDown8 As NumericUpDown
		Private label19 As Label
		Private label20 As Label
		Private numericUpDown9 As NumericUpDown
		Private checkBox35 As CheckBox
		Private checkBox36 As CheckBox
		Private panel1 As Panel
		Private panelPages As Panel
		Private WithEvents flowLayoutPanel1 As FlowLayoutPanel
		Private panelHeader As Panel
		Private labelHeader As Label
		Private pictureBox1 As PictureBox
		Private labelNonVisual As Label
		Private WithEvents linkSqlSyntax As LinkLabel
		Private WithEvents linkOfflineMode As LinkLabel
		Private labelVisual As Label
		Private WithEvents linkPanesVisibility As LinkLabel
		Private WithEvents linkMetadataTree As LinkLabel
		Private WithEvents linkMiscellaneous As LinkLabel
		Private labelSqlBuilder As Label
		Private WithEvents linkGeneral As LinkLabel
		Private WithEvents linkMainQuery As LinkLabel
		Private WithEvents linkDerievedQueries As LinkLabel
		Private WithEvents linkExpressionSubqueries As LinkLabel
		Private WithEvents buttonApply As Button
	End Class
End Namespace