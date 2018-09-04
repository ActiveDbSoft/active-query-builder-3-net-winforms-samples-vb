Partial Class PaginationPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaginationPanel))
        Me.ceEnabled = New System.Windows.Forms.CheckBox()
        Me.tbCurrentPage = New System.Windows.Forms.TextBox()
        Me.tbPageSize = New System.Windows.Forms.TextBox()
        Me.labelPageSize = New System.Windows.Forms.Label()
        Me.labelCurrentPage = New System.Windows.Forms.Label()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.btnPrevPage = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'ceEnabled
        '
        Me.ceEnabled.AutoSize = true
        Me.ceEnabled.Location = New System.Drawing.Point(3, 7)
        Me.ceEnabled.Name = "ceEnabled"
        Me.ceEnabled.Size = New System.Drawing.Size(111, 17)
        Me.ceEnabled.TabIndex = 0
        Me.ceEnabled.Text = "Enable pagination"
        Me.ceEnabled.UseVisualStyleBackColor = true
        '
        'tbCurrentPage
        '
        Me.tbCurrentPage.Location = New System.Drawing.Point(158, 5)
        Me.tbCurrentPage.Name = "tbCurrentPage"
        Me.tbCurrentPage.ReadOnly = true
        Me.tbCurrentPage.Size = New System.Drawing.Size(81, 20)
        Me.tbCurrentPage.TabIndex = 1
        '
        'tbPageSize
        '
        Me.tbPageSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tbPageSize.Location = New System.Drawing.Point(376, 5)
        Me.tbPageSize.Name = "tbPageSize"
        Me.tbPageSize.ReadOnly = true
        Me.tbPageSize.Size = New System.Drawing.Size(57, 20)
        Me.tbPageSize.TabIndex = 1
        '
        'labelPageSize
        '
        Me.labelPageSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.labelPageSize.AutoSize = true
        Me.labelPageSize.Location = New System.Drawing.Point(317, 8)
        Me.labelPageSize.Name = "labelPageSize"
        Me.labelPageSize.Size = New System.Drawing.Size(53, 13)
        Me.labelPageSize.TabIndex = 4
        Me.labelPageSize.Text = "Page size"
        '
        'labelCurrentPage
        '
        Me.labelCurrentPage.AutoSize = true
        Me.labelCurrentPage.Location = New System.Drawing.Point(120, 8)
        Me.labelCurrentPage.Name = "labelCurrentPage"
        Me.labelCurrentPage.Size = New System.Drawing.Size(32, 13)
        Me.labelCurrentPage.TabIndex = 4
        Me.labelCurrentPage.Text = "Page"
        '
        'btnNextPage
        '
        Me.btnNextPage.Enabled = false
        Me.btnNextPage.Image = CType(resources.GetObject("btnNextPage.Image"),System.Drawing.Image)
        Me.btnNextPage.Location = New System.Drawing.Point(274, 3)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(23, 23)
        Me.btnNextPage.TabIndex = 3
        Me.btnNextPage.UseVisualStyleBackColor = true
        '
        'btnPrevPage
        '
        Me.btnPrevPage.Enabled = false
        Me.btnPrevPage.Image = CType(resources.GetObject("btnPrevPage.Image"),System.Drawing.Image)
        Me.btnPrevPage.Location = New System.Drawing.Point(245, 3)
        Me.btnPrevPage.Name = "btnPrevPage"
        Me.btnPrevPage.Size = New System.Drawing.Size(23, 23)
        Me.btnPrevPage.TabIndex = 2
        Me.btnPrevPage.UseVisualStyleBackColor = true
        '
        'PaginationPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.labelCurrentPage)
        Me.Controls.Add(Me.labelPageSize)
        Me.Controls.Add(Me.btnNextPage)
        Me.Controls.Add(Me.btnPrevPage)
        Me.Controls.Add(Me.tbPageSize)
        Me.Controls.Add(Me.tbCurrentPage)
        Me.Controls.Add(Me.ceEnabled)
        Me.Name = "PaginationPanel"
        Me.Size = New System.Drawing.Size(436, 29)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

	#End Region

	Private WithEvents ceEnabled As System.Windows.Forms.CheckBox
	Private WithEvents tbCurrentPage As System.Windows.Forms.TextBox
	Private WithEvents btnPrevPage As System.Windows.Forms.Button
	Private WithEvents btnNextPage As System.Windows.Forms.Button
	Private WithEvents tbPageSize As System.Windows.Forms.TextBox
	Private WithEvents labelPageSize As System.Windows.Forms.Label
	Private WithEvents labelCurrentPage As System.Windows.Forms.Label
End Class
