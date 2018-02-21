Namespace ConnectionFrames
	NotInheritable Partial Class OracleConnectionFrame
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
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbUserID = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbDataSource = New System.Windows.Forms.TextBox()
        Me.btnEditConnectionString = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(3, 85)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 13)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Password:"
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(3, 59)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(36, 13)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Login:"
        '
        'tbPassword
        '
        Me.tbPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tbPassword.Location = New System.Drawing.Point(87, 82)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(130, 20)
        Me.tbPassword.TabIndex = 14
        Me.tbPassword.UseSystemPasswordChar = true
        '
        'tbUserID
        '
        Me.tbUserID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tbUserID.Location = New System.Drawing.Point(87, 56)
        Me.tbUserID.Name = "tbUserID"
        Me.tbUserID.Size = New System.Drawing.Size(130, 20)
        Me.tbUserID.TabIndex = 13
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(3, 6)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 13)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Server Name:"
        '
        'tbDataSource
        '
        Me.tbDataSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tbDataSource.Location = New System.Drawing.Point(87, 3)
        Me.tbDataSource.Name = "tbDataSource"
        Me.tbDataSource.Size = New System.Drawing.Size(130, 20)
        Me.tbDataSource.TabIndex = 10
        '
        'btnEditConnectionString
        '
        Me.btnEditConnectionString.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnEditConnectionString.Location = New System.Drawing.Point(84, 113)
        Me.btnEditConnectionString.Name = "btnEditConnectionString"
        Me.btnEditConnectionString.Size = New System.Drawing.Size(133, 23)
        Me.btnEditConnectionString.TabIndex = 24
        Me.btnEditConnectionString.Text = "Edit Connection String"
        Me.btnEditConnectionString.UseVisualStyleBackColor = true
        '
        'OracleConnectionFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnEditConnectionString)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUserID)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tbDataSource)
        Me.Name = "OracleConnectionFrame"
        Me.Size = New System.Drawing.Size(220, 139)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

		#End Region

		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private tbPassword As System.Windows.Forms.TextBox
		Private tbUserID As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private tbDataSource As System.Windows.Forms.TextBox
		Private btnEditConnectionString As System.Windows.Forms.Button

	End Class
End Namespace
