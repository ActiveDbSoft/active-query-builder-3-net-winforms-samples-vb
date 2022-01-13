


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
        Me.panel1 = New Panel()
        Me.cbRightPane = New CheckBox()
        Me.cbQueryColumnsPane = New CheckBox()
        Me.cbDesignPane = New CheckBox()
        Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
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
        ' imageList32
        ' 
        Me.imageList32.ImageStream = (CType(resources.GetObject("imageList32.ImageStream"), ImageListStreamer))
        Me.imageList32.TransparentColor = Color.Magenta
        Me.imageList32.Images.SetKeyName(0, "0.bmp")
        Me.imageList32.Images.SetKeyName(1, "1.bmp")
        Me.imageList32.Images.SetKeyName(2, "2.bmp")
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = SystemColors.Info
        Me.panel1.Controls.Add(Me.cbRightPane)
        Me.panel1.Controls.Add(Me.cbQueryColumnsPane)
        Me.panel1.Controls.Add(Me.cbDesignPane)
        Me.panel1.Dock = DockStyle.Top
        Me.panel1.Location = New Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New Size(793, 108)
        Me.panel1.TabIndex = 1
        ' 
        ' cbRightPane
        ' 
        Me.cbRightPane.Appearance = Appearance.Button
        Me.cbRightPane.Checked = True
        Me.cbRightPane.CheckState = CheckState.Checked
        Me.cbRightPane.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.cbRightPane.Location = New Point(492, 12)
        Me.cbRightPane.Name = "cbRightPane"
        Me.cbRightPane.Size = New Size(112, 86)
        Me.cbRightPane.TabIndex = 2
        Me.cbRightPane.Text = "Right Pane"
        Me.cbRightPane.TextAlign = ContentAlignment.MiddleCenter
        Me.cbRightPane.UseVisualStyleBackColor = True
'            Me.cbRightPane.CheckedChanged += New System.EventHandler(Me.cbRightPane_CheckedChanged)
        ' 
        ' cbQueryColumnsPane
        ' 
        Me.cbQueryColumnsPane.Appearance = Appearance.Button
        Me.cbQueryColumnsPane.Checked = True
        Me.cbQueryColumnsPane.CheckState = CheckState.Checked
        Me.cbQueryColumnsPane.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.cbQueryColumnsPane.Location = New Point(320, 58)
        Me.cbQueryColumnsPane.Name = "cbQueryColumnsPane"
        Me.cbQueryColumnsPane.Size = New Size(166, 40)
        Me.cbQueryColumnsPane.TabIndex = 3
        Me.cbQueryColumnsPane.Text = "Query Columns Pane"
        Me.cbQueryColumnsPane.TextAlign = ContentAlignment.MiddleCenter
        Me.cbQueryColumnsPane.UseVisualStyleBackColor = True
'            Me.cbQueryColumnsPane.CheckedChanged += New System.EventHandler(Me.cbQueryColumnsPane_CheckedChanged)
        ' 
        ' cbDesignPane
        ' 
        Me.cbDesignPane.Appearance = Appearance.Button
        Me.cbDesignPane.Checked = True
        Me.cbDesignPane.CheckState = CheckState.Checked
        Me.cbDesignPane.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.cbDesignPane.Location = New Point(320, 12)
        Me.cbDesignPane.Name = "cbDesignPane"
        Me.cbDesignPane.Size = New Size(166, 40)
        Me.cbDesignPane.TabIndex = 1
        Me.cbDesignPane.Text = "Design Pane"
        Me.cbDesignPane.TextAlign = ContentAlignment.MiddleCenter
        Me.cbDesignPane.UseVisualStyleBackColor = True
'            Me.cbDesignPane.CheckedChanged += New System.EventHandler(Me.cbDesignPane_CheckedChanged)
        ' 
        ' queryBuilder
        ' 
        Me.queryBuilder.BorderStyle = BorderStyle.FixedSingle
        Me.queryBuilder.DatabaseSchemaViewOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder.DataSourceOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = (CType(resources.GetObject("resource.PrimaryKeyIcon"), Bitmap))
        Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder.Dock = DockStyle.Fill
        Me.queryBuilder.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Me.queryBuilder.Location = New Point(0, 108)
        Me.queryBuilder.MetadataStructureOptions.ProceduresFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.SynonymsFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.TablesFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.ViewsFolderText = Nothing
        Me.queryBuilder.Name = "queryBuilder"
        Me.queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = (CType((ActiveQueryBuilder.View.QueryView.AffectedColumns.ExpressionColumn Or ActiveQueryBuilder.View.QueryView.AffectedColumns.ConditionColumns), ActiveQueryBuilder.View.QueryView.AffectedColumns))
        Me.queryBuilder.Size = New Size(793, 422)
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
        Me.queryBuilder.TabIndex = 3
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(793, 530)
        Me.Controls.Add(Me.queryBuilder)
        Me.Controls.Add(Me.panel1)
        Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private imageList16 As ImageList
    Private imageList32 As ImageList
    Private panel1 As Panel
    Private WithEvents cbDesignPane As CheckBox
    Private queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private WithEvents cbQueryColumnsPane As CheckBox
    Private WithEvents cbRightPane As CheckBox
End Class
