Imports ActiveQueryBuilder.View.QueryView


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
        Me.menuStrip1 = New MenuStrip()
        Me.propertiesToolStripMenuItem = New ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New ToolStripMenuItem()
        Me.imageList32 = New ImageList(Me.components)
        Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.splitContainer1 = New SplitContainer()
        Me.panel1 = New Panel()
        Me.label1 = New Label()
        Me.textBox1 = New TextBox()
        Me.menuStrip1.SuspendLayout()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.panel1.SuspendLayout()
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
        ' menuStrip1
        ' 
        Me.menuStrip1.Items.AddRange(New ToolStripItem() { Me.propertiesToolStripMenuItem, Me.aboutToolStripMenuItem})
        Me.menuStrip1.Location = New Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.RenderMode = ToolStripRenderMode.System
        Me.menuStrip1.Size = New Size(793, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        ' 
        ' aboutToolStripMenuItem
        ' 
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New Size(61, 20)
        Me.aboutToolStripMenuItem.Text = "About..."
'            Me.aboutToolStripMenuItem.Click += New System.EventHandler(Me.aboutToolStripMenuItem_Click)
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
        Me.queryBuilder.Location = New Point(0, 23)
        Me.queryBuilder.MetadataStructureOptions.ProceduresFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.SynonymsFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.TablesFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.ViewsFolderText = Nothing
        Me.queryBuilder.Name = "queryBuilder"
        Me.queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = (CType((ActiveQueryBuilder.View.QueryView.AffectedColumns.ExpressionColumn Or ActiveQueryBuilder.View.QueryView.AffectedColumns.ConditionColumns), ActiveQueryBuilder.View.QueryView.AffectedColumns))
        Me.queryBuilder.Size = New Size(793, 335)
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
'            Me.queryBuilder.CustomExpressionBuilder += New ActiveQueryBuilder.View.QueryView.CustomExpressionBuilderEventHandler(Me.queryBuilder_CustomExpressionBuilder)
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = DockStyle.Fill
        Me.splitContainer1.Location = New Point(0, 24)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
        Me.splitContainer1.Panel1.Controls.Add(Me.panel1)
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.Controls.Add(Me.textBox1)
        Me.splitContainer1.Size = New Size(793, 506)
        Me.splitContainer1.SplitterDistance = 358
        Me.splitContainer1.TabIndex = 2
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = SystemColors.Info
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = DockStyle.Top
        Me.panel1.Location = New Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New Size(793, 23)
        Me.panel1.TabIndex = 1
        ' 
        ' label1
        ' 
        Me.label1.Dock = DockStyle.Fill
        Me.label1.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.label1.Location = New Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(793, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "To see the custom expression builder click ""..."" buttons in Expression and Criter" & "ia column cells."
        Me.label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' textBox1
        ' 
        Me.textBox1.Dock = DockStyle.Fill
        Me.textBox1.HideSelection = False
        Me.textBox1.Location = New Point(0, 0)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = ScrollBars.Both
        Me.textBox1.Size = New Size(793, 144)
        Me.textBox1.TabIndex = 2
'            Me.textBox1.Validating += New System.ComponentModel.CancelEventHandler(Me.textBox1_Validating)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(793, 530)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = FormWindowState.Maximized
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        Me.splitContainer1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private menuStrip1 As MenuStrip
    Private WithEvents aboutToolStripMenuItem As ToolStripMenuItem
    Private imageList16 As ImageList
    Private imageList32 As ImageList
    Private propertiesToolStripMenuItem As ToolStripMenuItem
    Private splitContainer1 As SplitContainer
    Private WithEvents queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private WithEvents textBox1 As TextBox
    Private panel1 As Panel
    Private label1 As Label
End Class
