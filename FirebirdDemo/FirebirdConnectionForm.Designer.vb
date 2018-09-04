Partial Class FirebirdConnectionForm
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
		Me.textboxServer = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.buttonBrowse = New System.Windows.Forms.Button()
		Me.textboxPassword = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.buttonCancel = New System.Windows.Forms.Button()
		Me.buttonConnect = New System.Windows.Forms.Button()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.textboxUser = New System.Windows.Forms.TextBox()
		Me.textboxDatabase = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		' 
		' textboxServer
		' 
		Me.textboxServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textboxServer.Location = New System.Drawing.Point(97, 12)
		Me.textboxServer.Name = "textboxServer"
		Me.textboxServer.Size = New System.Drawing.Size(220, 20)
		Me.textboxServer.TabIndex = 0
		Me.textboxServer.Text = "localhost"
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(3, 15)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(41, 13)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Server:"
		' 
		' buttonBrowse
		' 
		Me.buttonBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonBrowse.Location = New System.Drawing.Point(323, 36)
		Me.buttonBrowse.Name = "buttonBrowse"
		Me.buttonBrowse.Size = New System.Drawing.Size(24, 23)
		Me.buttonBrowse.TabIndex = 2
		Me.buttonBrowse.Text = "..."
		Me.buttonBrowse.UseVisualStyleBackColor = True
		AddHandler Me.buttonBrowse.Click, New System.EventHandler(AddressOf Me.buttonBrowse_Click)
		' 
		' textboxPassword
		' 
		Me.textboxPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textboxPassword.Location = New System.Drawing.Point(97, 90)
		Me.textboxPassword.Name = "textboxPassword"
		Me.textboxPassword.Size = New System.Drawing.Size(220, 20)
		Me.textboxPassword.TabIndex = 4
		Me.textboxPassword.UseSystemPasswordChar = True
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(3, 93)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(53, 13)
		Me.label2.TabIndex = 4
		Me.label2.Text = "Password"
		' 
		' openFileDialog1
		' 
		Me.openFileDialog1.DefaultExt = "*.fdb"
		Me.openFileDialog1.Filter = "Firebird Databases (*.fdb)|*.fdb|All Files|*.*"
		' 
		' buttonCancel
		' 
		Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonCancel.Location = New System.Drawing.Point(272, 134)
		Me.buttonCancel.Name = "buttonCancel"
		Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
		Me.buttonCancel.TabIndex = 6
		Me.buttonCancel.Text = "Cancel"
		Me.buttonCancel.UseVisualStyleBackColor = True
		' 
		' buttonConnect
		' 
		Me.buttonConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.buttonConnect.Location = New System.Drawing.Point(191, 134)
		Me.buttonConnect.Name = "buttonConnect"
		Me.buttonConnect.Size = New System.Drawing.Size(75, 23)
		Me.buttonConnect.TabIndex = 5
		Me.buttonConnect.Text = "Connect"
		Me.buttonConnect.UseVisualStyleBackColor = True
		AddHandler Me.buttonConnect.Click, New System.EventHandler(AddressOf Me.buttonConnect_Click)
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(3, 41)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(56, 13)
		Me.label3.TabIndex = 10
		Me.label3.Text = "Database:"
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(3, 67)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(32, 13)
		Me.label4.TabIndex = 13
		Me.label4.Text = "User:"
		' 
		' textboxUser
		' 
		Me.textboxUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textboxUser.Location = New System.Drawing.Point(97, 64)
		Me.textboxUser.Name = "textboxUser"
		Me.textboxUser.Size = New System.Drawing.Size(220, 20)
		Me.textboxUser.TabIndex = 3
		Me.textboxUser.Text = "SYSDBA"
		' 
		' textboxDatabase
		' 
		Me.textboxDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textboxDatabase.Location = New System.Drawing.Point(97, 38)
		Me.textboxDatabase.Name = "textboxDatabase"
		Me.textboxDatabase.Size = New System.Drawing.Size(220, 20)
		Me.textboxDatabase.TabIndex = 1
		' 
		' FirebirdConnectionForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(359, 169)
		Me.Controls.Add(Me.textboxDatabase)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.textboxUser)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.buttonConnect)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.textboxPassword)
		Me.Controls.Add(Me.buttonBrowse)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textboxServer)
		Me.Name = "FirebirdConnectionForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Connect to Firebird database"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private textboxServer As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private buttonBrowse As System.Windows.Forms.Button
	Private textboxPassword As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private buttonCancel As System.Windows.Forms.Button
	Private buttonConnect As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private textboxUser As System.Windows.Forms.TextBox
	Private textboxDatabase As System.Windows.Forms.TextBox
End Class
