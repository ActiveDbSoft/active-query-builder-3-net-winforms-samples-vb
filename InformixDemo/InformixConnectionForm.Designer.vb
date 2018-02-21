Partial Class InformixConnectionForm
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
		Me.buttonCancel = New System.Windows.Forms.Button()
		Me.buttonConnect = New System.Windows.Forms.Button()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.tbService = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.tbProtocol = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.tbHost = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.tbDatabaseLocale = New System.Windows.Forms.TextBox()
		Me.tbUser = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.tbServer = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tbPassword = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.tbDatabase = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		' 
		' buttonCancel
		' 
		Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonCancel.Location = New System.Drawing.Point(202, 232)
		Me.buttonCancel.Name = "buttonCancel"
		Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
		Me.buttonCancel.TabIndex = 9
		Me.buttonCancel.Text = "Cancel"
		Me.buttonCancel.UseVisualStyleBackColor = True
		' 
		' buttonConnect
		' 
		Me.buttonConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.buttonConnect.Location = New System.Drawing.Point(121, 232)
		Me.buttonConnect.Name = "buttonConnect"
		Me.buttonConnect.Size = New System.Drawing.Size(75, 23)
		Me.buttonConnect.TabIndex = 8
		Me.buttonConnect.Text = "Connect"
		Me.buttonConnect.UseVisualStyleBackColor = True
		AddHandler Me.buttonConnect.Click, New System.EventHandler(AddressOf Me.buttonConnect_Click)
		' 
		' label8
		' 
		Me.label8.Location = New System.Drawing.Point(7, 145)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(95, 13)
		Me.label8.TabIndex = 43
		Me.label8.Text = "Database Locale:"
		' 
		' label7
		' 
		Me.label7.Location = New System.Drawing.Point(7, 93)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(95, 13)
		Me.label7.TabIndex = 42
		Me.label7.Text = "Service:"
		' 
		' tbService
		' 
		Me.tbService.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbService.Location = New System.Drawing.Point(108, 90)
		Me.tbService.Name = "tbService"
		Me.tbService.Size = New System.Drawing.Size(169, 20)
		Me.tbService.TabIndex = 3
		' 
		' label6
		' 
		Me.label6.Location = New System.Drawing.Point(7, 67)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(95, 13)
		Me.label6.TabIndex = 41
		Me.label6.Text = "Protocol:"
		' 
		' tbProtocol
		' 
		Me.tbProtocol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbProtocol.Location = New System.Drawing.Point(108, 64)
		Me.tbProtocol.Name = "tbProtocol"
		Me.tbProtocol.Size = New System.Drawing.Size(169, 20)
		Me.tbProtocol.TabIndex = 2
		' 
		' label5
		' 
		Me.label5.Location = New System.Drawing.Point(7, 41)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(95, 13)
		Me.label5.TabIndex = 40
		Me.label5.Text = "Host:"
		' 
		' tbHost
		' 
		Me.tbHost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbHost.Location = New System.Drawing.Point(108, 38)
		Me.tbHost.Name = "tbHost"
		Me.tbHost.Size = New System.Drawing.Size(169, 20)
		Me.tbHost.TabIndex = 1
		' 
		' label4
		' 
		Me.label4.Location = New System.Drawing.Point(7, 171)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(95, 13)
		Me.label4.TabIndex = 39
		Me.label4.Text = "User:"
		' 
		' openFileDialog1
		' 
		Me.openFileDialog1.DefaultExt = "*.fdb"
		Me.openFileDialog1.Filter = "Firebird Databases (*.fdb)|*.fdb|All files|*.*"
		' 
		' tbDatabaseLocale
		' 
		Me.tbDatabaseLocale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbDatabaseLocale.Location = New System.Drawing.Point(108, 142)
		Me.tbDatabaseLocale.Name = "tbDatabaseLocale"
		Me.tbDatabaseLocale.Size = New System.Drawing.Size(169, 20)
		Me.tbDatabaseLocale.TabIndex = 5
		' 
		' tbUser
		' 
		Me.tbUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbUser.Location = New System.Drawing.Point(108, 168)
		Me.tbUser.Name = "tbUser"
		Me.tbUser.Size = New System.Drawing.Size(169, 20)
		Me.tbUser.TabIndex = 6
		' 
		' label3
		' 
		Me.label3.Location = New System.Drawing.Point(7, 15)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(95, 13)
		Me.label3.TabIndex = 38
		Me.label3.Text = "Server:"
		' 
		' tbServer
		' 
		Me.tbServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbServer.Location = New System.Drawing.Point(108, 12)
		Me.tbServer.Name = "tbServer"
		Me.tbServer.Size = New System.Drawing.Size(169, 20)
		Me.tbServer.TabIndex = 0
		' 
		' label2
		' 
		Me.label2.Location = New System.Drawing.Point(7, 197)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(95, 13)
		Me.label2.TabIndex = 37
		Me.label2.Text = "Password:"
		' 
		' tbPassword
		' 
		Me.tbPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbPassword.Location = New System.Drawing.Point(108, 194)
		Me.tbPassword.Name = "tbPassword"
		Me.tbPassword.Size = New System.Drawing.Size(169, 20)
		Me.tbPassword.TabIndex = 7
		Me.tbPassword.UseSystemPasswordChar = True
		' 
		' label1
		' 
		Me.label1.Location = New System.Drawing.Point(7, 119)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(95, 13)
		Me.label1.TabIndex = 36
		Me.label1.Text = "Database:"
		' 
		' tbDatabase
		' 
		Me.tbDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbDatabase.Location = New System.Drawing.Point(108, 116)
		Me.tbDatabase.Name = "tbDatabase"
		Me.tbDatabase.Size = New System.Drawing.Size(169, 20)
		Me.tbDatabase.TabIndex = 4
		' 
		' InformixConnectionForm
		' 
		Me.AcceptButton = Me.buttonConnect
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.buttonCancel
		Me.ClientSize = New System.Drawing.Size(289, 267)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.tbService)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.tbProtocol)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.tbHost)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.tbDatabaseLocale)
		Me.Controls.Add(Me.tbUser)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.tbServer)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.tbPassword)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.tbDatabase)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.buttonConnect)
		Me.Name = "InformixConnectionForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Connect to Informix database"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private buttonCancel As System.Windows.Forms.Button
	Private buttonConnect As System.Windows.Forms.Button
	Private label8 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private tbService As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private tbProtocol As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private tbHost As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private tbDatabaseLocale As System.Windows.Forms.TextBox
	Private tbUser As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private tbServer As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private tbPassword As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private tbDatabase As System.Windows.Forms.TextBox
End Class
