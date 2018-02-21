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
		Me.imageList32 = New System.Windows.Forms.ImageList(Me.components)
		Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
		Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.tsbMetadataEditor = New System.Windows.Forms.ToolStripButton()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.splitContainer1.Panel1.SuspendLayout()
		Me.splitContainer1.Panel2.SuspendLayout()
		Me.splitContainer1.SuspendLayout()
		Me.toolStrip1.SuspendLayout()
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
		Me.queryBuilder.DataSourceOptions.MarkColumnOptions.PrimaryKeyIcon = DirectCast(resources.GetObject("resource.PrimaryKeyIcon"), System.Drawing.Bitmap)
		Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
		Me.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill
		Me.queryBuilder.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
		Me.queryBuilder.Location = New System.Drawing.Point(0, 25)
		Me.queryBuilder.Name = "queryBuilder"
		Me.queryBuilder.Size = New System.Drawing.Size(977, 466)
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
		Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.splitContainer1.Name = "splitContainer1"
		Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		' 
		' splitContainer1.Panel1
		' 
		Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
		Me.splitContainer1.Panel1.Controls.Add(Me.toolStrip1)
		' 
		' splitContainer1.Panel2
		' 
		Me.splitContainer1.Panel2.Controls.Add(Me.textBox1)
		Me.splitContainer1.Size = New System.Drawing.Size(977, 633)
		Me.splitContainer1.SplitterDistance = 491
		Me.splitContainer1.TabIndex = 2
		' 
		' toolStrip1
		' 
		Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbMetadataEditor})
		Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.toolStrip1.Name = "toolStrip1"
		Me.toolStrip1.Size = New System.Drawing.Size(977, 25)
		Me.toolStrip1.TabIndex = 1
		Me.toolStrip1.Text = "toolStrip1"
		' 
		' tsbMetadataEditor
		' 
		Me.tsbMetadataEditor.Image = DirectCast(resources.GetObject("tsbMetadataEditor.Image"), System.Drawing.Image)
		Me.tsbMetadataEditor.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbMetadataEditor.Name = "tsbMetadataEditor"
		Me.tsbMetadataEditor.Size = New System.Drawing.Size(100, 22)
		Me.tsbMetadataEditor.Text = "Edit Metadata"
		AddHandler Me.tsbMetadataEditor.Click, New System.EventHandler(AddressOf Me.tsbMetadataEditor_Click)
		' 
		' textBox1
		' 
		Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.textBox1.HideSelection = False
		Me.textBox1.Location = New System.Drawing.Point(0, 0)
		Me.textBox1.Multiline = True
		Me.textBox1.Name = "textBox1"
		Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox1.Size = New System.Drawing.Size(977, 138)
		Me.textBox1.TabIndex = 2
		AddHandler Me.textBox1.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBox1_Validating)
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(977, 633)
		Me.Controls.Add(Me.splitContainer1)
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.splitContainer1.Panel1.ResumeLayout(False)
		Me.splitContainer1.Panel1.PerformLayout()
		Me.splitContainer1.Panel2.ResumeLayout(False)
		Me.splitContainer1.Panel2.PerformLayout()
		Me.splitContainer1.ResumeLayout(False)
		Me.toolStrip1.ResumeLayout(False)
		Me.toolStrip1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private imageList16 As System.Windows.Forms.ImageList
	Private imageList32 As System.Windows.Forms.ImageList
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private textBox1 As System.Windows.Forms.TextBox
	Private toolStrip1 As System.Windows.Forms.ToolStrip
	Private tsbMetadataEditor As System.Windows.Forms.ToolStripButton
End Class

