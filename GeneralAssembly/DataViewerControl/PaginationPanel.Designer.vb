Namespace DataViewerControl
	Partial Public Class PaginationPanel
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
			Me.ceEnabled = New CheckBox()
			Me.tbCurrentPage = New TextBox()
			Me.tbPageSize = New TextBox()
			Me.labelPageSize = New Label()
			Me.labelCurrentPage = New Label()
			Me.btnNextPage = New Button()
			Me.btnPrevPage = New Button()
			Me.SuspendLayout()
			' 
			' ceEnabled
			' 
			Me.ceEnabled.AutoSize = True
			Me.ceEnabled.Location = New Point(3, 7)
			Me.ceEnabled.Name = "ceEnabled"
			Me.ceEnabled.Size = New Size(111, 17)
			Me.ceEnabled.TabIndex = 0
			Me.ceEnabled.Text = "Enable pagination"
			Me.ceEnabled.UseVisualStyleBackColor = True
'			Me.ceEnabled.CheckedChanged += New System.EventHandler(Me.ceEnabled_CheckedChanged)
			' 
			' tbCurrentPage
			' 
			Me.tbCurrentPage.Location = New Point(158, 5)
			Me.tbCurrentPage.Name = "tbCurrentPage"
			Me.tbCurrentPage.ReadOnly = True
			Me.tbCurrentPage.Size = New Size(81, 20)
			Me.tbCurrentPage.TabIndex = 1
'			Me.tbCurrentPage.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.tbPageSize_KeyDown)
'			Me.tbCurrentPage.Validating += New System.ComponentModel.CancelEventHandler(Me.intTextBox_Validating)
'			Me.tbCurrentPage.Validated += New System.EventHandler(Me.tbCurrentPage_Validated)
			' 
			' tbPageSize
			' 
			Me.tbPageSize.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.tbPageSize.Location = New Point(376, 5)
			Me.tbPageSize.Name = "tbPageSize"
			Me.tbPageSize.ReadOnly = True
			Me.tbPageSize.Size = New Size(57, 20)
			Me.tbPageSize.TabIndex = 1
'			Me.tbPageSize.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.tbPageSize_KeyDown)
'			Me.tbPageSize.Validating += New System.ComponentModel.CancelEventHandler(Me.intTextBox_Validating)
'			Me.tbPageSize.Validated += New System.EventHandler(Me.tbPageSize_Validated)
			' 
			' labelPageSize
			' 
			Me.labelPageSize.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.labelPageSize.AutoSize = True
			Me.labelPageSize.Location = New Point(317, 8)
			Me.labelPageSize.Name = "labelPageSize"
			Me.labelPageSize.Size = New Size(53, 13)
			Me.labelPageSize.TabIndex = 4
			Me.labelPageSize.Text = "Page size"
			' 
			' labelCurrentPage
			' 
			Me.labelCurrentPage.AutoSize = True
			Me.labelCurrentPage.Location = New Point(120, 8)
			Me.labelCurrentPage.Name = "labelCurrentPage"
			Me.labelCurrentPage.Size = New Size(32, 13)
			Me.labelCurrentPage.TabIndex = 4
			Me.labelCurrentPage.Text = "Page"
			' 
			' btnNextPage
			' 
			Me.btnNextPage.Enabled = False
			Me.btnNextPage.Image = My.Resources.arrow_right
			Me.btnNextPage.Location = New Point(274, 3)
			Me.btnNextPage.Name = "btnNextPage"
			Me.btnNextPage.Size = New Size(23, 23)
			Me.btnNextPage.TabIndex = 3
			Me.btnNextPage.UseVisualStyleBackColor = True
'			Me.btnNextPage.Click += New System.EventHandler(Me.btnNextPage_Click)
			' 
			' btnPrevPage
			' 
			Me.btnPrevPage.Enabled = False
			Me.btnPrevPage.Image = My.Resources.arrow_left
			Me.btnPrevPage.Location = New Point(245, 3)
			Me.btnPrevPage.Name = "btnPrevPage"
			Me.btnPrevPage.Size = New Size(23, 23)
			Me.btnPrevPage.TabIndex = 2
			Me.btnPrevPage.UseVisualStyleBackColor = True
'			Me.btnPrevPage.Click += New System.EventHandler(Me.btnPrevPage_Click)
			' 
			' PaginationPanel
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.labelCurrentPage)
			Me.Controls.Add(Me.labelPageSize)
			Me.Controls.Add(Me.btnNextPage)
			Me.Controls.Add(Me.btnPrevPage)
			Me.Controls.Add(Me.tbPageSize)
			Me.Controls.Add(Me.tbCurrentPage)
			Me.Controls.Add(Me.ceEnabled)
			Me.Name = "PaginationPanel"
			Me.Size = New Size(436, 29)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents ceEnabled As CheckBox
		Private WithEvents tbCurrentPage As TextBox
		Private WithEvents btnPrevPage As Button
		Private WithEvents btnNextPage As Button
		Private WithEvents tbPageSize As TextBox
		Private labelPageSize As Label
		Private labelCurrentPage As Label
	End Class
End Namespace
