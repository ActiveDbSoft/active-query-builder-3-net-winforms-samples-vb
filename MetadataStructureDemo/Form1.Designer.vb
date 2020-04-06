
Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.imageList16 = New ImageList(Me.components)
        Me.imageList32 = New ImageList(Me.components)
        Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.splitContainer1 = New SplitContainer()
        Me.toolStrip1 = New ToolStrip()
        Me.tsbMetadataEditor = New ToolStripButton()
        Me.textBox1 = New TextBox()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' imageList16
        ' 
        Me.imageList16.ImageStream = (CType(resources.GetObject("imageList16.ImageStream"), ImageListStreamer))
        Me.imageList16.TransparentColor = Color.Magenta
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
        Me.imageList32.ImageStream = (CType(resources.GetObject("imageList32.ImageStream"), ImageListStreamer))
        Me.imageList32.TransparentColor = Color.Magenta
        Me.imageList32.Images.SetKeyName(0, "0.bmp")
        Me.imageList32.Images.SetKeyName(1, "1.bmp")
        Me.imageList32.Images.SetKeyName(2, "2.bmp")
        ' 
        ' queryBuilder
        ' 
        Me.queryBuilder.BorderStyle = BorderStyle.FixedSingle
        Me.queryBuilder.DataSourceOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = (CType(resources.GetObject("resource.PrimaryKeyIcon"), Bitmap))
        Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder.Dock = DockStyle.Fill
        Me.queryBuilder.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Me.queryBuilder.Location = New Point(0, 25)
        Me.queryBuilder.Name = "queryBuilder"
        Me.queryBuilder.Size = New Size(977, 466)
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
'			Me.queryBuilder.SQLUpdated += New System.EventHandler(Me.queryBuilder_SQLUpdated)
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = DockStyle.Fill
        Me.splitContainer1.Location = New Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
        Me.splitContainer1.Panel1.Controls.Add(Me.toolStrip1)
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.Controls.Add(Me.textBox1)
        Me.splitContainer1.Size = New Size(977, 633)
        Me.splitContainer1.SplitterDistance = 491
        Me.splitContainer1.TabIndex = 2
        ' 
        ' toolStrip1
        ' 
        Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.tsbMetadataEditor})
        Me.toolStrip1.Location = New Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New Size(977, 25)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        ' 
        ' tsbMetadataEditor
        ' 
        Me.tsbMetadataEditor.Image = (CType(resources.GetObject("tsbMetadataEditor.Image"), Image))
        Me.tsbMetadataEditor.ImageTransparentColor = Color.Magenta
        Me.tsbMetadataEditor.Name = "tsbMetadataEditor"
        Me.tsbMetadataEditor.Size = New Size(100, 22)
        Me.tsbMetadataEditor.Text = "Edit Metadata"
'			Me.tsbMetadataEditor.Click += New System.EventHandler(Me.tsbMetadataEditor_Click)
        ' 
        ' textBox1
        ' 
        Me.textBox1.Dock = DockStyle.Fill
        Me.textBox1.HideSelection = False
        Me.textBox1.Location = New Point(0, 0)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = ScrollBars.Both
        Me.textBox1.Size = New Size(977, 138)
        Me.textBox1.TabIndex = 2
'			Me.textBox1.Validating += New System.ComponentModel.CancelEventHandler(Me.textBox1_Validating)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(977, 633)
        Me.Controls.Add(Me.splitContainer1)
        Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
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

    Private imageList16 As ImageList
    Private imageList32 As ImageList
    Private splitContainer1 As SplitContainer
    Private WithEvents queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private WithEvents textBox1 As TextBox
    Private toolStrip1 As ToolStrip
    Private WithEvents tsbMetadataEditor As ToolStripButton
End Class
