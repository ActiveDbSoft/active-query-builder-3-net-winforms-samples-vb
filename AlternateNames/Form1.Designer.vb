Imports ActiveQueryBuilder.View.WinForms

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
		Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
		Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.tabPage2 = New System.Windows.Forms.TabPage()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.menuStrip1.SuspendLayout()
		Me.splitContainer1.Panel1.SuspendLayout()
		Me.splitContainer1.Panel2.SuspendLayout()
		Me.splitContainer1.SuspendLayout()
		Me.tabControl1.SuspendLayout()
		Me.tabPage1.SuspendLayout()
		Me.tabPage2.SuspendLayout()
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
		' queryBuilder1
		' 
		Me.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.queryBuilder1.DataSourceOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.queryBuilder1.DataSourceOptions.MarkColumnOptions.PrimaryKeyIcon = DirectCast(resources.GetObject("resource.PrimaryKeyIcon"), System.Drawing.Bitmap)
		Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
		Me.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.queryBuilder1.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
		Me.queryBuilder1.Location = New System.Drawing.Point(0, 0)
		Me.queryBuilder1.Name = "queryBuilder1"
		Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 250
		Me.queryBuilder1.Size = New System.Drawing.Size(793, 358)
		' 
		' 
		' 
		Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = False
		Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = False
		' 
		' 
		' 
		Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = True
		Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = True
		Me.queryBuilder1.TabIndex = 0
        AddHandler Me.queryBuilder1.SQLUpdated, AddressOf Me.queryBuilder_SQLUpdated
		' 
		' splitContainer1
		' 
		Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.splitContainer1.Location = New System.Drawing.Point(0, 24)
		Me.splitContainer1.Name = "splitContainer1"
		Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		' 
		' splitContainer1.Panel1
		' 
		Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder1)
		' 
		' splitContainer1.Panel2
		' 
		Me.splitContainer1.Panel2.Controls.Add(Me.tabControl1)
		Me.splitContainer1.Size = New System.Drawing.Size(793, 506)
		Me.splitContainer1.SplitterDistance = 358
		Me.splitContainer1.TabIndex = 2
		' 
		' tabControl1
		' 
		Me.tabControl1.Controls.Add(Me.tabPage1)
		Me.tabControl1.Controls.Add(Me.tabPage2)
		Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabControl1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.tabControl1.Location = New System.Drawing.Point(0, 0)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(793, 144)
		Me.tabControl1.TabIndex = 0
		' 
		' tabPage1
		' 
		Me.tabPage1.Controls.Add(Me.textBox1)
		Me.tabPage1.Location = New System.Drawing.Point(4, 22)
		Me.tabPage1.Name = "tabPage1"
		Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage1.Size = New System.Drawing.Size(785, 118)
		Me.tabPage1.TabIndex = 0
		Me.tabPage1.Text = "Query text with alternate object names"
		Me.tabPage1.UseVisualStyleBackColor = True
		' 
		' textBox1
		' 
		Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.textBox1.Font = New System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.textBox1.HideSelection = False
		Me.textBox1.Location = New System.Drawing.Point(3, 3)
		Me.textBox1.Multiline = True
		Me.textBox1.Name = "textBox1"
		Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox1.Size = New System.Drawing.Size(779, 112)
		Me.textBox1.TabIndex = 1
		AddHandler Me.textBox1.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBox1_Validating)
		' 
		' tabPage2
		' 
		Me.tabPage2.Controls.Add(Me.textBox2)
		Me.tabPage2.Location = New System.Drawing.Point(4, 22)
		Me.tabPage2.Name = "tabPage2"
		Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage2.Size = New System.Drawing.Size(785, 118)
		Me.tabPage2.TabIndex = 1
		Me.tabPage2.Text = "Query text with real object names"
		Me.tabPage2.UseVisualStyleBackColor = True
		' 
		' textBox2
		' 
		Me.textBox2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.textBox2.Font = New System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.textBox2.HideSelection = False
		Me.textBox2.Location = New System.Drawing.Point(3, 3)
		Me.textBox2.Multiline = True
		Me.textBox2.Name = "textBox2"
		Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox2.Size = New System.Drawing.Size(779, 112)
		Me.textBox2.TabIndex = 2
		AddHandler Me.textBox2.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBox2_Validating)
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(793, 530)
		Me.Controls.Add(Me.splitContainer1)
		Me.Controls.Add(Me.menuStrip1)
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "AlternateNames Demo"
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
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

#End Region

	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private imageList16 As System.Windows.Forms.ImageList
	Private imageList32 As System.Windows.Forms.ImageList
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private WithEvents queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private tabControl1 As System.Windows.Forms.TabControl
	Private tabPage1 As System.Windows.Forms.TabPage
	Private textBox1 As System.Windows.Forms.TextBox
	Private tabPage2 As System.Windows.Forms.TabPage
	Private textBox2 As System.Windows.Forms.TextBox
	Private editMetadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

