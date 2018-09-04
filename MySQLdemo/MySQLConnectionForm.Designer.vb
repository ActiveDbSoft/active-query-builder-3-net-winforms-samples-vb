Partial Class MySQLConnectionForm
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
		Me.tbDatabase = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.tbPassword = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.buttonCancel = New System.Windows.Forms.Button()
		Me.buttonConnect = New System.Windows.Forms.Button()
		Me.tbServer = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.tbUser = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		' 
		' tbDatabase
		' 
		Me.tbDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbDatabase.Location = New System.Drawing.Point(62, 41)
		Me.tbDatabase.Name = "tbDatabase"
		Me.tbDatabase.Size = New System.Drawing.Size(227, 20)
		Me.tbDatabase.TabIndex = 1
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(3, 44)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(53, 13)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Database"
		' 
		' tbPassword
		' 
		Me.tbPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbPassword.Location = New System.Drawing.Point(62, 93)
		Me.tbPassword.Name = "tbPassword"
		Me.tbPassword.Size = New System.Drawing.Size(227, 20)
		Me.tbPassword.TabIndex = 3
		Me.tbPassword.UseSystemPasswordChar = True
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(3, 96)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(53, 13)
		Me.label2.TabIndex = 4
		Me.label2.Text = "Password"
		' 
		' openFileDialog1
		' 
		Me.openFileDialog1.DefaultExt = "vdb3"
		Me.openFileDialog1.FileName = "openFileDialog1"
		Me.openFileDialog1.Filter = "MySQL 3.0 files (*.vdb3)|*.vdb3|All files|*.*"
		' 
		' buttonCancel
		' 
		Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonCancel.Location = New System.Drawing.Point(214, 131)
		Me.buttonCancel.Name = "buttonCancel"
		Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
		Me.buttonCancel.TabIndex = 5
		Me.buttonCancel.Text = "Cancel"
		Me.buttonCancel.UseVisualStyleBackColor = True
		' 
		' buttonConnect
		' 
		Me.buttonConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.buttonConnect.Location = New System.Drawing.Point(133, 131)
		Me.buttonConnect.Name = "buttonConnect"
		Me.buttonConnect.Size = New System.Drawing.Size(75, 23)
		Me.buttonConnect.TabIndex = 4
		Me.buttonConnect.Text = "Connect"
		Me.buttonConnect.UseVisualStyleBackColor = True
		AddHandler Me.buttonConnect.Click, New System.EventHandler(AddressOf Me.buttonConnect_Click)
		' 
		' tbServer
		' 
		Me.tbServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbServer.Location = New System.Drawing.Point(62, 15)
		Me.tbServer.Name = "tbServer"
		Me.tbServer.Size = New System.Drawing.Size(227, 20)
		Me.tbServer.TabIndex = 0
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(3, 18)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(38, 13)
		Me.label3.TabIndex = 9
		Me.label3.Text = "Server"
		' 
		' tbUser
		' 
		Me.tbUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbUser.Location = New System.Drawing.Point(62, 67)
		Me.tbUser.Name = "tbUser"
		Me.tbUser.Size = New System.Drawing.Size(227, 20)
		Me.tbUser.TabIndex = 2
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(3, 70)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(29, 13)
		Me.label4.TabIndex = 11
		Me.label4.Text = "User"
		' 
		' MySQLConnectionForm
		' 
		Me.AcceptButton = Me.buttonConnect
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.buttonCancel
		Me.ClientSize = New System.Drawing.Size(301, 166)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.tbUser)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.tbServer)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.buttonConnect)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.tbPassword)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.tbDatabase)
		Me.Name = "MySQLConnectionForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Connect to MySQL database"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private tbDatabase As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private tbPassword As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private buttonCancel As System.Windows.Forms.Button
	Private buttonConnect As System.Windows.Forms.Button
	Private tbServer As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private tbUser As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
End Class
