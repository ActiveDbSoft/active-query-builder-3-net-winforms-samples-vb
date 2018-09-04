Namespace ConnectionFrames
	NotInheritable Partial Class MySQLConnectionFrame
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
			Me.btnEditConnectionString = New System.Windows.Forms.Button()
			Me.label4 = New System.Windows.Forms.Label()
			Me.tbUserID = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.tbServer = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.tbPassword = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.tbDatabase = New System.Windows.Forms.TextBox()
			Me.SuspendLayout()
			' 
			' btnEditConnectionString
			' 
			Me.btnEditConnectionString.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.btnEditConnectionString.Location = New System.Drawing.Point(82, 117)
			Me.btnEditConnectionString.Name = "btnEditConnectionString"
			Me.btnEditConnectionString.Size = New System.Drawing.Size(133, 23)
			Me.btnEditConnectionString.TabIndex = 4
			Me.btnEditConnectionString.Text = "Edit Connection String"
			Me.btnEditConnectionString.UseVisualStyleBackColor = True
			AddHandler Me.btnEditConnectionString.Click, New System.EventHandler(AddressOf Me.btnEditConnectionString_Click)
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(3, 58)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(29, 13)
			Me.label4.TabIndex = 34
			Me.label4.Text = "User"
			' 
			' tbUserID
			' 
			Me.tbUserID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbUserID.Location = New System.Drawing.Point(62, 55)
			Me.tbUserID.Name = "tbUserID"
			Me.tbUserID.Size = New System.Drawing.Size(153, 20)
			Me.tbUserID.TabIndex = 2
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(3, 6)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(38, 13)
			Me.label3.TabIndex = 33
			Me.label3.Text = "Server"
			' 
			' tbServer
			' 
			Me.tbServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbServer.Location = New System.Drawing.Point(62, 3)
			Me.tbServer.Name = "tbServer"
			Me.tbServer.Size = New System.Drawing.Size(153, 20)
			Me.tbServer.TabIndex = 0
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(3, 84)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(53, 13)
			Me.label2.TabIndex = 32
			Me.label2.Text = "Password"
			' 
			' tbPassword
			' 
			Me.tbPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbPassword.Location = New System.Drawing.Point(62, 81)
			Me.tbPassword.Name = "tbPassword"
			Me.tbPassword.Size = New System.Drawing.Size(153, 20)
			Me.tbPassword.TabIndex = 3
			Me.tbPassword.UseSystemPasswordChar = True
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(3, 32)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(53, 13)
			Me.label1.TabIndex = 29
			Me.label1.Text = "Database"
			' 
			' tbDatabase
			' 
			Me.tbDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbDatabase.Location = New System.Drawing.Point(62, 29)
			Me.tbDatabase.Name = "tbDatabase"
			Me.tbDatabase.Size = New System.Drawing.Size(153, 20)
			Me.tbDatabase.TabIndex = 1
			' 
			' MySQLConnectionFrame
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.tbUserID)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.tbServer)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.tbPassword)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.tbDatabase)
			Me.Controls.Add(Me.btnEditConnectionString)
			Me.Name = "MySQLConnectionFrame"
			Me.Size = New System.Drawing.Size(218, 143)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private btnEditConnectionString As System.Windows.Forms.Button
		Private label4 As System.Windows.Forms.Label
		Private tbUserID As System.Windows.Forms.TextBox
		Private label3 As System.Windows.Forms.Label
		Private tbServer As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private tbPassword As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private tbDatabase As System.Windows.Forms.TextBox

	End Class
End Namespace
