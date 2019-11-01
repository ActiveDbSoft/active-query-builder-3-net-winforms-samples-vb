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
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.imageList16 = New System.Windows.Forms.ImageList(Me.components)
		Me.imageList32 = New System.Windows.Forms.ImageList(Me.components)
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.cbRightPane = New System.Windows.Forms.CheckBox()
		Me.cbQueryColumnsPane = New System.Windows.Forms.CheckBox()
		Me.cbDesignPane = New System.Windows.Forms.CheckBox()
		Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
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
		' imageList32
		' 
		Me.imageList32.ImageStream = DirectCast(resources.GetObject("imageList32.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.imageList32.TransparentColor = System.Drawing.Color.Magenta
		Me.imageList32.Images.SetKeyName(0, "0.bmp")
		Me.imageList32.Images.SetKeyName(1, "1.bmp")
		Me.imageList32.Images.SetKeyName(2, "2.bmp")
		' 
		' panel1
		' 
		Me.panel1.BackColor = System.Drawing.SystemColors.Info
		Me.panel1.Controls.Add(Me.cbRightPane)
		Me.panel1.Controls.Add(Me.cbQueryColumnsPane)
		Me.panel1.Controls.Add(Me.cbDesignPane)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(793, 108)
		Me.panel1.TabIndex = 1
		' 
		' cbRightPane
		' 
		Me.cbRightPane.Appearance = System.Windows.Forms.Appearance.Button
		Me.cbRightPane.Checked = True
		Me.cbRightPane.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cbRightPane.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.cbRightPane.Location = New System.Drawing.Point(492, 12)
		Me.cbRightPane.Name = "cbRightPane"
		Me.cbRightPane.Size = New System.Drawing.Size(112, 86)
		Me.cbRightPane.TabIndex = 2
		Me.cbRightPane.Text = "Right Pane"
		Me.cbRightPane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cbRightPane.UseVisualStyleBackColor = True
		AddHandler Me.cbRightPane.CheckedChanged, New System.EventHandler(AddressOf Me.cbRightPane_CheckedChanged)
		' 
		' cbQueryColumnsPane
		' 
		Me.cbQueryColumnsPane.Appearance = System.Windows.Forms.Appearance.Button
		Me.cbQueryColumnsPane.Checked = True
		Me.cbQueryColumnsPane.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cbQueryColumnsPane.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.cbQueryColumnsPane.Location = New System.Drawing.Point(320, 58)
		Me.cbQueryColumnsPane.Name = "cbQueryColumnsPane"
		Me.cbQueryColumnsPane.Size = New System.Drawing.Size(166, 40)
		Me.cbQueryColumnsPane.TabIndex = 3
		Me.cbQueryColumnsPane.Text = "Query Columns Pane"
		Me.cbQueryColumnsPane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cbQueryColumnsPane.UseVisualStyleBackColor = True
		AddHandler Me.cbQueryColumnsPane.CheckedChanged, New System.EventHandler(AddressOf Me.cbQueryColumnsPane_CheckedChanged)
		' 
		' cbDesignPane
		' 
		Me.cbDesignPane.Appearance = System.Windows.Forms.Appearance.Button
		Me.cbDesignPane.Checked = True
		Me.cbDesignPane.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cbDesignPane.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.cbDesignPane.Location = New System.Drawing.Point(320, 12)
		Me.cbDesignPane.Name = "cbDesignPane"
		Me.cbDesignPane.Size = New System.Drawing.Size(166, 40)
		Me.cbDesignPane.TabIndex = 1
		Me.cbDesignPane.Text = "Design Pane"
		Me.cbDesignPane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cbDesignPane.UseVisualStyleBackColor = True
		AddHandler Me.cbDesignPane.CheckedChanged, New System.EventHandler(AddressOf Me.cbDesignPane_CheckedChanged)
		' 
		' queryBuilder
		' 
		Me.queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.queryBuilder.DatabaseSchemaViewOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.queryBuilder.DataSourceOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = DirectCast(resources.GetObject("resource.PrimaryKeyIcon"), System.Drawing.Bitmap)
		Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
		Me.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill
		Me.queryBuilder.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
		Me.queryBuilder.Location = New System.Drawing.Point(0, 108)
		Me.queryBuilder.MetadataStructureOptions.ProceduresFolderText = Nothing
		Me.queryBuilder.MetadataStructureOptions.SynonymsFolderText = Nothing
		Me.queryBuilder.MetadataStructureOptions.TablesFolderText = Nothing
		Me.queryBuilder.MetadataStructureOptions.ViewsFolderText = Nothing
		Me.queryBuilder.Name = "queryBuilder"
        Me.queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = (ActiveQueryBuilder.View.QueryView.AffectedColumns.ExpressionColumn Or ActiveQueryBuilder.View.QueryView.AffectedColumns.ConditionColumns)
        Me.queryBuilder.Size = New System.Drawing.Size(793, 422)
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
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(793, 530)
		Me.Controls.Add(Me.queryBuilder)
		Me.Controls.Add(Me.panel1)
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.panel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private imageList16 As System.Windows.Forms.ImageList
	Private imageList32 As System.Windows.Forms.ImageList
	Private panel1 As System.Windows.Forms.Panel
	Private cbDesignPane As System.Windows.Forms.CheckBox
	Private queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private cbQueryColumnsPane As System.Windows.Forms.CheckBox
	Private cbRightPane As System.Windows.Forms.CheckBox
End Class

