Namespace Common
	Partial Class ResultGrid
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.pLoading = New System.Windows.Forms.Panel()
			Me.bCancel = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.infoPanel1 = New FullFeaturedMdiDemo.Common.InfoPanel()
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pLoading.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dataGridView1
			' 
			Me.dataGridView1.AllowUserToAddRows = False
			Me.dataGridView1.AllowUserToDeleteRows = False
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
			Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.[ReadOnly] = True
			Me.dataGridView1.Size = New System.Drawing.Size(620, 343)
			Me.dataGridView1.TabIndex = 0
			AddHandler Me.dataGridView1.CellPainting, New System.Windows.Forms.DataGridViewCellPaintingEventHandler(AddressOf Me.dataGridView1_CellPainting)
			AddHandler Me.dataGridView1.ColumnHeaderMouseClick, New System.Windows.Forms.DataGridViewCellMouseEventHandler(AddressOf Me.dataGridView1_ColumnHeaderMouseClick)
			' 
			' pLoading
			' 
			Me.pLoading.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.pLoading.AutoSize = True
			Me.pLoading.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.pLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.pLoading.Controls.Add(Me.bCancel)
			Me.pLoading.Controls.Add(Me.label1)
			Me.pLoading.Location = New System.Drawing.Point(243, 135)
			Me.pLoading.Name = "pLoading"
			Me.pLoading.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
			Me.pLoading.Size = New System.Drawing.Size(128, 67)
			Me.pLoading.TabIndex = 1
			Me.pLoading.Visible = False
			' 
			' bCancel
			' 
			Me.bCancel.Location = New System.Drawing.Point(27, 34)
			Me.bCancel.Name = "bCancel"
			Me.bCancel.Size = New System.Drawing.Size(75, 23)
			Me.bCancel.TabIndex = 1
			Me.bCancel.Text = "Cancel"
			Me.bCancel.UseVisualStyleBackColor = True
			AddHandler Me.bCancel.Click, New System.EventHandler(AddressOf Me.ButtonCancelExecutingSql_OnClick)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
			Me.label1.Location = New System.Drawing.Point(14, 5)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(99, 22)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Loading..."
			' 
			' infoPanel1
			' 
			Me.infoPanel1.AutoSize = True
			Me.infoPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.infoPanel1.BackColor = System.Drawing.Color.LightCoral
			Me.infoPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.infoPanel1.Location = New System.Drawing.Point(0, 306)
			Me.infoPanel1.Message = ""
			Me.infoPanel1.Name = "infoPanel1"
			Me.infoPanel1.Size = New System.Drawing.Size(620, 37)
			Me.infoPanel1.TabIndex = 2
			Me.infoPanel1.Visible = False
			' 
			' ResultGrid
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSize = True
			Me.Controls.Add(Me.infoPanel1)
			Me.Controls.Add(Me.pLoading)
			Me.Controls.Add(Me.dataGridView1)
			Me.Name = "ResultGrid"
			Me.Size = New System.Drawing.Size(620, 343)
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pLoading.ResumeLayout(False)
			Me.pLoading.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private pLoading As System.Windows.Forms.Panel
		Private bCancel As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private infoPanel1 As InfoPanel
	End Class
End Namespace
