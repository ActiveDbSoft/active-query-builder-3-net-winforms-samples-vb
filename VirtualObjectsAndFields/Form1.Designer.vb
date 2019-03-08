Partial Class Form1
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.imageList16 = New System.Windows.Forms.ImageList(Me.components)
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.editMetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.imageList32 = New System.Windows.Forms.ImageList(Me.components)
		Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
		Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.tabPage2 = New System.Windows.Forms.TabPage()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.sqlFormattingOptions1 = New ActiveQueryBuilder.Core.SQLFormattingOptions()
		Me.sqlFormattingOptions2 = New ActiveQueryBuilder.Core.SQLFormattingOptions()
		Me.menuStrip1.SuspendLayout()
		Me.splitContainer1.Panel1.SuspendLayout()
		Me.splitContainer1.Panel2.SuspendLayout()
		Me.splitContainer1.SuspendLayout()
		Me.tabControl1.SuspendLayout()
		Me.tabPage1.SuspendLayout()
		Me.tabPage2.SuspendLayout()
		Me.panel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' imageList16
		' 
		Me.imageList16.ImageStream = DirectCast(resources.GetObject("imageList16.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.imageList16.TransparentColor = System.Drawing.Color.Magenta
		Me.imageList16.Images.SetKeyName(0, "0.bmp")
		Me.imageList16.Images.SetKeyName(1, "1.bmp")
		Me.imageList16.Images.SetKeyName(2, "2.bmp")
		Me.imageList16.Images.SetKeyName(3, "3.bmp")
		Me.imageList16.Images.SetKeyName(4, "4.bmp")
		Me.imageList16.Images.SetKeyName(5, "5.bmp")
		Me.imageList16.Images.SetKeyName(6, "6.bmp")
		Me.imageList16.Images.SetKeyName(7, "7.bmp")
		Me.imageList16.Images.SetKeyName(8, "8.bmp")
		' 
		' menuStrip1
		' 
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.editMetadataToolStripMenuItem, Me.aboutToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
		Me.menuStrip1.Size = New System.Drawing.Size(793, 24)
		Me.menuStrip1.TabIndex = 1
		Me.menuStrip1.Text = "menuStrip1"
		' 
		' editMetadataToolStripMenuItem
		' 
		Me.editMetadataToolStripMenuItem.Name = "editMetadataToolStripMenuItem"
		Me.editMetadataToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
		Me.editMetadataToolStripMenuItem.Text = "Edit Metadata..."
		AddHandler Me.editMetadataToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.editMetadataToolStripMenuItem_Click)
		' 
		' aboutToolStripMenuItem
		' 
		Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
		Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
		Me.aboutToolStripMenuItem.Text = "About..."
		AddHandler Me.aboutToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.aboutToolStripMenuItem_Click)
		' 
		' imageList32
		' 
		Me.imageList32.ImageStream = DirectCast(resources.GetObject("imageList32.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.imageList32.TransparentColor = System.Drawing.Color.Magenta
		Me.imageList32.Images.SetKeyName(0, "0.bmp")
		Me.imageList32.Images.SetKeyName(1, "1.bmp")
		Me.imageList32.Images.SetKeyName(2, "2.bmp")
		' 
		' queryBuilder
		' 
		Me.queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.queryBuilder.DataSourceOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = DirectCast(resources.GetObject("resource.PrimaryKeyIcon"), System.Drawing.Bitmap)
		Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
		Me.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill
		Me.queryBuilder.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
		Me.queryBuilder.Location = New System.Drawing.Point(0, 0)
		Me.queryBuilder.MetadataStructureOptions.ProceduresFolderText = Nothing
		Me.queryBuilder.MetadataStructureOptions.SynonymsFolderText = Nothing
		Me.queryBuilder.MetadataStructureOptions.TablesFolderText = Nothing
		Me.queryBuilder.MetadataStructureOptions.ViewsFolderText = Nothing
		Me.queryBuilder.Name = "queryBuilder"
		Me.queryBuilder.Size = New System.Drawing.Size(793, 316)
		' 
		' 
		' 
		Me.queryBuilder.SQLFormattingOptions.ExpandVirtualFields = False
		Me.queryBuilder.SQLFormattingOptions.ExpandVirtualObjects = False
		' 
		' 
		' 
		Me.queryBuilder.SQLGenerationOptions.ExpandVirtualFields = True
		Me.queryBuilder.SQLGenerationOptions.ExpandVirtualObjects = True
		Me.queryBuilder.TabIndex = 0
        AddHandler Me.queryBuilder.SQLUpdated, New System.EventHandler(AddressOf Me.queryBuilder_SQLUpdated)
		' 
		' splitContainer1
		' 
		Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.splitContainer1.Location = New System.Drawing.Point(0, 83)
		Me.splitContainer1.Name = "splitContainer1"
		Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		' 
		' splitContainer1.Panel1
		' 
		Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
		' 
		' splitContainer1.Panel2
		' 
		Me.splitContainer1.Panel2.Controls.Add(Me.tabControl1)
		Me.splitContainer1.Size = New System.Drawing.Size(793, 447)
		Me.splitContainer1.SplitterDistance = 316
		Me.splitContainer1.TabIndex = 2
		' 
		' tabControl1
		' 
		Me.tabControl1.Controls.Add(Me.tabPage1)
		Me.tabControl1.Controls.Add(Me.tabPage2)
		Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabControl1.Location = New System.Drawing.Point(0, 0)
		Me.tabControl1.Multiline = True
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(793, 127)
		Me.tabControl1.TabIndex = 0
		' 
		' tabPage1
		' 
		Me.tabPage1.Controls.Add(Me.textBox1)
		Me.tabPage1.Location = New System.Drawing.Point(4, 22)
		Me.tabPage1.Name = "tabPage1"
		Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage1.Size = New System.Drawing.Size(785, 101)
		Me.tabPage1.TabIndex = 0
		Me.tabPage1.Text = "Query text with virtual objects and fields"
		Me.tabPage1.UseVisualStyleBackColor = True
		' 
		' textBox1
		' 
		Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.textBox1.HideSelection = False
		Me.textBox1.Location = New System.Drawing.Point(3, 3)
		Me.textBox1.Multiline = True
		Me.textBox1.Name = "textBox1"
		Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox1.Size = New System.Drawing.Size(779, 95)
		Me.textBox1.TabIndex = 1
		AddHandler Me.textBox1.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBox1_Validating)
		' 
		' tabPage2
		' 
		Me.tabPage2.Controls.Add(Me.textBox2)
		Me.tabPage2.Location = New System.Drawing.Point(4, 22)
		Me.tabPage2.Name = "tabPage2"
		Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage2.Size = New System.Drawing.Size(785, 101)
		Me.tabPage2.TabIndex = 1
		Me.tabPage2.Text = "Real query text with virtual objects expanded to their expressions"
		Me.tabPage2.UseVisualStyleBackColor = True
		' 
		' textBox2
		' 
		Me.textBox2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.textBox2.HideSelection = False
		Me.textBox2.Location = New System.Drawing.Point(3, 3)
		Me.textBox2.Multiline = True
		Me.textBox2.Name = "textBox2"
		Me.textBox2.[ReadOnly] = True
		Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox2.Size = New System.Drawing.Size(779, 95)
		Me.textBox2.TabIndex = 2
		AddHandler Me.textBox2.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBox2_Validating)
		' 
		' panel1
		' 
		Me.panel1.AutoSize = True
		Me.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.panel1.BackColor = System.Drawing.SystemColors.Info
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 24)
		Me.panel1.Name = "panel1"
		Me.panel1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 4)
		Me.panel1.Size = New System.Drawing.Size(793, 59)
		Me.panel1.TabIndex = 1
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.label1.Location = New System.Drawing.Point(2, 3)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(669, 52)
		Me.label1.TabIndex = 0
		Me.label1.Text = resources.GetString("label1.Text")
		' 
		' sqlFormattingOptions1
		' 
		Me.sqlFormattingOptions1.ExpandVirtualFields = False
		Me.sqlFormattingOptions1.ExpandVirtualObjects = False
		Me.sqlFormattingOptions1.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = False
		Me.sqlFormattingOptions1.ExpressionSubQueryFormat.MainPartsFromNewLine = False
		Me.sqlFormattingOptions1.KeywordFormat = ActiveQueryBuilder.Core.KeywordFormat.UpperCase
		' 
		' sqlFormattingOptions2
		' 
		Me.sqlFormattingOptions2.ExpandVirtualFields = True
		Me.sqlFormattingOptions2.ExpandVirtualObjects = True
		Me.sqlFormattingOptions2.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = False
		Me.sqlFormattingOptions2.ExpressionSubQueryFormat.MainPartsFromNewLine = False
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(793, 530)
		Me.Controls.Add(Me.splitContainer1)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.menuStrip1)
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "VirtualObjectsAndFields Demo"
		Me.menuStrip1.ResumeLayout(False)
		Me.menuStrip1.PerformLayout()
		Me.splitContainer1.Panel1.ResumeLayout(False)
		Me.splitContainer1.Panel2.ResumeLayout(False)
		Me.splitContainer1.ResumeLayout(False)
		Me.tabControl1.ResumeLayout(False)
		Me.tabPage1.ResumeLayout(False)
		Me.tabPage1.PerformLayout()
		Me.tabPage2.ResumeLayout(False)
		Me.tabPage2.PerformLayout()
		Me.panel1.ResumeLayout(False)
		Me.panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Private label1 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel

	#End Region

	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private imageList16 As System.Windows.Forms.ImageList
	Private imageList32 As System.Windows.Forms.ImageList
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private tabControl1 As System.Windows.Forms.TabControl
	Private tabPage1 As System.Windows.Forms.TabPage
	Private textBox1 As System.Windows.Forms.TextBox
	Private tabPage2 As System.Windows.Forms.TabPage
	Private textBox2 As System.Windows.Forms.TextBox
	Private editMetadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private sqlFormattingOptions1 As ActiveQueryBuilder.Core.SQLFormattingOptions
	Private sqlFormattingOptions2 As ActiveQueryBuilder.Core.SQLFormattingOptions
End Class

