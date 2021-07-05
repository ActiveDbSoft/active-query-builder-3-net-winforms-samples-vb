Namespace DataViewerControl
	Partial Public Class DataViewer
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
			Me.dataGridView1 = New DataGridView()
			Me.pLoading = New Panel()
			Me.bCancel = New Button()
			Me.label1 = New Label()
			Me.infoPanel1 = New DataViewerControl.InfoPanel()
			Me.paginationPanel1 = New DataViewerControl.PaginationPanel()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pLoading.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dataGridView1
			' 
			Me.dataGridView1.AllowUserToAddRows = False
			Me.dataGridView1.AllowUserToDeleteRows = False
			Me.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Dock = DockStyle.Fill
			Me.dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
			Me.dataGridView1.Location = New Point(0, 0)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.ReadOnly = True
			Me.dataGridView1.Size = New Size(620, 343)
			Me.dataGridView1.TabIndex = 0
'			Me.dataGridView1.CellPainting += New System.Windows.Forms.DataGridViewCellPaintingEventHandler(Me.dataGridView1_CellPainting)
'			Me.dataGridView1.ColumnHeaderMouseClick += New System.Windows.Forms.DataGridViewCellMouseEventHandler(Me.dataGridView1_ColumnHeaderMouseClick)
			' 
			' pLoading
			' 
			Me.pLoading.Anchor = AnchorStyles.None
			Me.pLoading.AutoSize = True
			Me.pLoading.AutoSizeMode = AutoSizeMode.GrowAndShrink
			Me.pLoading.BorderStyle = BorderStyle.FixedSingle
			Me.pLoading.Controls.Add(Me.bCancel)
			Me.pLoading.Controls.Add(Me.label1)
			Me.pLoading.Location = New Point(243, 135)
			Me.pLoading.Name = "pLoading"
			Me.pLoading.Padding = New Padding(10, 5, 10, 5)
			Me.pLoading.Size = New Size(128, 67)
			Me.pLoading.TabIndex = 1
			Me.pLoading.Visible = False
			' 
			' bCancel
			' 
			Me.bCancel.Location = New Point(27, 34)
			Me.bCancel.Name = "bCancel"
			Me.bCancel.Size = New Size(75, 23)
			Me.bCancel.TabIndex = 1
			Me.bCancel.Text = "Cancel"
			Me.bCancel.UseVisualStyleBackColor = True
'			Me.bCancel.Click += New System.EventHandler(Me.ButtonCancelExecutingSql_OnClick)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
			Me.label1.Location = New Point(14, 5)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(99, 22)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Loading..."
			' 
			' infoPanel1
			' 
			Me.infoPanel1.AutoSize = True
			Me.infoPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
			Me.infoPanel1.BackColor = Color.LightCoral
			Me.infoPanel1.Dock = DockStyle.Bottom
			Me.infoPanel1.Location = New Point(0, 306)
			Me.infoPanel1.Message = ""
			Me.infoPanel1.Name = "infoPanel1"
			Me.infoPanel1.Size = New Size(620, 37)
			Me.infoPanel1.TabIndex = 2
			Me.infoPanel1.Visible = False
			' 
			' paginationPanel1
			' 
			Me.paginationPanel1.CurrentPage = 0
			Me.paginationPanel1.Dock = DockStyle.Bottom
			Me.paginationPanel1.IsSupportLimitCount = True
			Me.paginationPanel1.IsSupportLimitOffset = True
			Me.paginationPanel1.Location = New Point(0, 314)
			Me.paginationPanel1.Name = "paginationPanel1"
			Me.paginationPanel1.PageSize = 10
			Me.paginationPanel1.RowsCount = 10
			Me.paginationPanel1.Size = New Size(620, 29)
			Me.paginationPanel1.TabIndex = 3
'			Me.paginationPanel1.EnabledPaginationChanged += New System.EventHandler(Me.paginationPanel1_EnabledPaginationChanged)
'			Me.paginationPanel1.CurrentPageChanged += New System.EventHandler(Me.paginationPanel1_CurrentPageChanged)
'			Me.paginationPanel1.PageSizeChanged += New System.EventHandler(Me.paginationPanel1_PageSizeChanged)
			' 
			' DataViewer
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoSize = True
			Me.Controls.Add(Me.paginationPanel1)
			Me.Controls.Add(Me.infoPanel1)
			Me.Controls.Add(Me.pLoading)
			Me.Controls.Add(Me.dataGridView1)
			Me.Name = "DataViewer"
			Me.Size = New Size(620, 343)
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pLoading.ResumeLayout(False)
			Me.pLoading.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents dataGridView1 As DataGridView
		Private pLoading As Panel
		Private WithEvents bCancel As Button
		Private label1 As Label
		Private infoPanel1 As InfoPanel
		Private WithEvents paginationPanel1 As PaginationPanel
	End Class
End Namespace
