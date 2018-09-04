Partial Class MSSQLConnectionForm
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
		Me.textBoxServerName = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.comboBoxAuthentication = New System.Windows.Forms.ComboBox()
		Me.buttonConnect = New System.Windows.Forms.Button()
		Me.buttonCancel = New System.Windows.Forms.Button()
		Me.label2 = New System.Windows.Forms.Label()
		Me.textBoxLogin = New System.Windows.Forms.TextBox()
		Me.textBoxPassword = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.comboBoxDatabase = New System.Windows.Forms.ComboBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		' 
		' textBoxServerName
		' 
		Me.textBoxServerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxServerName.Location = New System.Drawing.Point(127, 12)
		Me.textBoxServerName.Name = "textBoxServerName"
		Me.textBoxServerName.Size = New System.Drawing.Size(173, 20)
		Me.textBoxServerName.TabIndex = 0
		Me.textBoxServerName.Text = "(local)"
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(12, 15)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(72, 13)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Server Name:"
		' 
		' comboBoxAuthentication
		' 
		Me.comboBoxAuthentication.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comboBoxAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxAuthentication.FormattingEnabled = True
		Me.comboBoxAuthentication.Items.AddRange(New Object() {"Windows Authentication", "SQL Server Authentication"})
		Me.comboBoxAuthentication.Location = New System.Drawing.Point(127, 38)
		Me.comboBoxAuthentication.Name = "comboBoxAuthentication"
		Me.comboBoxAuthentication.Size = New System.Drawing.Size(173, 21)
		Me.comboBoxAuthentication.TabIndex = 1
		AddHandler Me.comboBoxAuthentication.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxAuthentication_SelectedIndexChanged)
		' 
		' buttonConnect
		' 
		Me.buttonConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.buttonConnect.Location = New System.Drawing.Point(144, 173)
		Me.buttonConnect.Name = "buttonConnect"
		Me.buttonConnect.Size = New System.Drawing.Size(75, 23)
		Me.buttonConnect.TabIndex = 5
		Me.buttonConnect.Text = "Connect"
		Me.buttonConnect.UseVisualStyleBackColor = True
		AddHandler Me.buttonConnect.Click, New System.EventHandler(AddressOf Me.buttonConnect_Click)
		' 
		' buttonCancel
		' 
		Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonCancel.Location = New System.Drawing.Point(225, 173)
		Me.buttonCancel.Name = "buttonCancel"
		Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
		Me.buttonCancel.TabIndex = 6
		Me.buttonCancel.Text = "Cancel"
		Me.buttonCancel.UseVisualStyleBackColor = True
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(12, 41)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(78, 13)
		Me.label2.TabIndex = 5
		Me.label2.Text = "Authentication:"
		' 
		' textBoxLogin
		' 
		Me.textBoxLogin.Location = New System.Drawing.Point(127, 65)
		Me.textBoxLogin.Name = "textBoxLogin"
		Me.textBoxLogin.Size = New System.Drawing.Size(125, 20)
		Me.textBoxLogin.TabIndex = 2
		' 
		' textBoxPassword
		' 
		Me.textBoxPassword.Location = New System.Drawing.Point(127, 91)
		Me.textBoxPassword.Name = "textBoxPassword"
		Me.textBoxPassword.Size = New System.Drawing.Size(125, 20)
		Me.textBoxPassword.TabIndex = 3
		Me.textBoxPassword.UseSystemPasswordChar = True
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(12, 68)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(36, 13)
		Me.label3.TabIndex = 8
		Me.label3.Text = "Login:"
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(12, 94)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(56, 13)
		Me.label4.TabIndex = 9
		Me.label4.Text = "Password:"
		' 
		' comboBoxDatabase
		' 
		Me.comboBoxDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comboBoxDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxDatabase.FormattingEnabled = True
		Me.comboBoxDatabase.Items.AddRange(New Object() {"<default>"})
		Me.comboBoxDatabase.Location = New System.Drawing.Point(127, 128)
		Me.comboBoxDatabase.Name = "comboBoxDatabase"
		Me.comboBoxDatabase.Size = New System.Drawing.Size(173, 21)
		Me.comboBoxDatabase.Sorted = True
		Me.comboBoxDatabase.TabIndex = 4
		AddHandler Me.comboBoxDatabase.DropDown, New System.EventHandler(AddressOf Me.comboBoxDatabase_DropDown)
		' 
		' label5
		' 
		Me.label5.AutoSize = True
		Me.label5.Location = New System.Drawing.Point(12, 131)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(109, 13)
		Me.label5.TabIndex = 11
		Me.label5.Text = "Connect to database:"
		' 
		' MSSQLConnectionForm
		' 
		Me.AcceptButton = Me.buttonConnect
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.buttonCancel
		Me.ClientSize = New System.Drawing.Size(312, 208)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.comboBoxDatabase)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.textBoxPassword)
		Me.Controls.Add(Me.textBoxLogin)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.buttonConnect)
		Me.Controls.Add(Me.comboBoxAuthentication)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textBoxServerName)
		Me.Name = "MSSQLConnectionForm"
		Me.Text = "Connect to MS SQL Server"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private textBoxServerName As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private comboBoxAuthentication As System.Windows.Forms.ComboBox
	Private buttonConnect As System.Windows.Forms.Button
	Private buttonCancel As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private textBoxLogin As System.Windows.Forms.TextBox
	Private textBoxPassword As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private comboBoxDatabase As System.Windows.Forms.ComboBox
	Private label5 As System.Windows.Forms.Label
End Class
