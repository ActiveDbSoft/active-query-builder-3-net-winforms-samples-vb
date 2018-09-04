Imports ActiveQueryBuilder.View.QueryView

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.imageList16 = New System.Windows.Forms.ImageList(Me.components)
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.propertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imageList32 = New System.Windows.Forms.ImageList(Me.components)
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.menuStrip1.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imageList16
        '
        Me.imageList16.ImageStream = CType(resources.GetObject("imageList16.ImageStream"), System.Windows.Forms.ImageListStreamer)
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
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.propertiesToolStripMenuItem, Me.aboutToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuStrip1.Size = New System.Drawing.Size(793, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        '
        'propertiesToolStripMenuItem
        '
        Me.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem"
        Me.propertiesToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.aboutToolStripMenuItem.Text = "About..."
        '
        'imageList32
        '
        Me.imageList32.ImageStream = CType(resources.GetObject("imageList32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList32.TransparentColor = System.Drawing.Color.Magenta
        Me.imageList32.Images.SetKeyName(0, "0.bmp")
        Me.imageList32.Images.SetKeyName(1, "1.bmp")
        Me.imageList32.Images.SetKeyName(2, "2.bmp")
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
        Me.splitContainer1.Panel1.Controls.Add(Me.panel1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.textBox1)
        Me.splitContainer1.Size = New System.Drawing.Size(793, 506)
        Me.splitContainer1.SplitterDistance = 358
        Me.splitContainer1.TabIndex = 2
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.Info
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(793, 23)
        Me.panel1.TabIndex = 1
        '
        'label1
        '
        Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(793, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "To see the custom expression builder click ""..."" buttons in Expression and Criter" & _
    "ia column cells."
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'textBox1
        '
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.HideSelection = False
        Me.textBox1.Location = New System.Drawing.Point(0, 0)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox1.Size = New System.Drawing.Size(793, 144)
        Me.textBox1.TabIndex = 2
        '
        'queryBuilder
        '
        Me.queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.queryBuilder.DataSourceOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.queryBuilder.DataSourceOptions.MarkColumnOptions.PrimaryKeyIcon = CType(resources.GetObject("resource.PrimaryKeyIcon"), System.Drawing.Bitmap)
        Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.queryBuilder.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.queryBuilder.Location = New System.Drawing.Point(0, 23)
        Me.queryBuilder.MetadataStructureOptions.ProceduresFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.SynonymsFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.TablesFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.ViewsFolderText = Nothing
        Me.queryBuilder.Name = "queryBuilder"        
        Me.queryBuilder.Size = New System.Drawing.Size(793, 335)
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
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 530)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

	Private menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private imageList16 As System.Windows.Forms.ImageList
	Private imageList32 As System.Windows.Forms.ImageList
	Private propertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
	Private panel1 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
End Class

