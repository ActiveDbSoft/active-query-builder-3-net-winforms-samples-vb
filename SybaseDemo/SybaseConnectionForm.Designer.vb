Partial Class SybaseConnectionForm
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
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.buttonCancel = New System.Windows.Forms.Button()
		Me.buttonConnect = New System.Windows.Forms.Button()
		Me.label5 = New System.Windows.Forms.Label()
		Me.textboxDataSourceName = New System.Windows.Forms.TextBox()
		Me.buttonBrowse = New System.Windows.Forms.Button()
		Me.label4 = New System.Windows.Forms.Label()
		Me.textboxUser = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.textboxServerName = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.textboxPassword = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.textboxDatabaseFile = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		' 
		' openFileDialog1
		' 
		Me.openFileDialog1.DefaultExt = "*.fd"
		Me.openFileDialog1.Filter = "Sybase Database File (*.db)|*.db|All Files|*.*"
		' 
		' buttonCancel
		' 
		Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonCancel.Location = New System.Drawing.Point(210, 153)
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
		Me.buttonConnect.Location = New System.Drawing.Point(129, 153)
		Me.buttonConnect.Name = "buttonConnect"
		Me.buttonConnect.Size = New System.Drawing.Size(75, 23)
		Me.buttonConnect.TabIndex = 5
		Me.buttonConnect.Text = "Connect"
		Me.buttonConnect.UseVisualStyleBackColor = True
		AddHandler Me.buttonConnect.Click, New System.EventHandler(AddressOf Me.buttonConnect_Click)
		' 
		' label5
		' 
		Me.label5.Location = New System.Drawing.Point(13, 41)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(105, 13)
		Me.label5.TabIndex = 32
		Me.label5.Text = "Data Source Name:"
		' 
		' textboxDataSourceName
		' 
		Me.textboxDataSourceName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textboxDataSourceName.Location = New System.Drawing.Point(124, 38)
		Me.textboxDataSourceName.Name = "textboxDataSourceName"
		Me.textboxDataSourceName.Size = New System.Drawing.Size(131, 20)
		Me.textboxDataSourceName.TabIndex = 31
		' 
		' buttonBrowse
		' 
		Me.buttonBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonBrowse.Location = New System.Drawing.Point(261, 62)
		Me.buttonBrowse.Name = "buttonBrowse"
		Me.buttonBrowse.Size = New System.Drawing.Size(24, 22)
		Me.buttonBrowse.TabIndex = 24
		Me.buttonBrowse.Text = "..."
		Me.buttonBrowse.UseVisualStyleBackColor = True
		AddHandler Me.buttonBrowse.Click, New System.EventHandler(AddressOf Me.buttonBrowse_Click)
		' 
		' label4
		' 
		Me.label4.Location = New System.Drawing.Point(13, 93)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(105, 13)
		Me.label4.TabIndex = 30
		Me.label4.Text = "User:"
		' 
		' textboxUser
		' 
		Me.textboxUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textboxUser.Location = New System.Drawing.Point(124, 90)
		Me.textboxUser.Name = "textboxUser"
		Me.textboxUser.Size = New System.Drawing.Size(131, 20)
		Me.textboxUser.TabIndex = 25
		Me.textboxUser.Text = "DBA"
		' 
		' label3
		' 
		Me.label3.Location = New System.Drawing.Point(13, 15)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(105, 13)
		Me.label3.TabIndex = 29
		Me.label3.Text = "Server Name:"
		' 
		' textboxServerName
		' 
		Me.textboxServerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textboxServerName.Location = New System.Drawing.Point(124, 12)
		Me.textboxServerName.Name = "textboxServerName"
		Me.textboxServerName.Size = New System.Drawing.Size(131, 20)
		Me.textboxServerName.TabIndex = 22
		' 
		' label2
		' 
		Me.label2.Location = New System.Drawing.Point(13, 119)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(105, 13)
		Me.label2.TabIndex = 28
		Me.label2.Text = "Password:"
		' 
		' textboxPassword
		' 
		Me.textboxPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textboxPassword.Location = New System.Drawing.Point(124, 116)
		Me.textboxPassword.Name = "textboxPassword"
		Me.textboxPassword.Size = New System.Drawing.Size(131, 20)
		Me.textboxPassword.TabIndex = 26
		Me.textboxPassword.UseSystemPasswordChar = True
		' 
		' label1
		' 
		Me.label1.Location = New System.Drawing.Point(13, 67)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(105, 13)
		Me.label1.TabIndex = 27
		Me.label1.Text = "Database File:"
		' 
		' textboxDatabaseFile
		' 
		Me.textboxDatabaseFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textboxDatabaseFile.Location = New System.Drawing.Point(124, 64)
		Me.textboxDatabaseFile.Name = "textboxDatabaseFile"
		Me.textboxDatabaseFile.Size = New System.Drawing.Size(131, 20)
		Me.textboxDatabaseFile.TabIndex = 23
		' 
		' SybaseConnectionForm
		' 
		Me.AcceptButton = Me.buttonConnect
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.buttonCancel
		Me.ClientSize = New System.Drawing.Size(297, 188)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.textboxDataSourceName)
		Me.Controls.Add(Me.buttonBrowse)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.textboxUser)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.textboxServerName)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.textboxPassword)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textboxDatabaseFile)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.buttonConnect)
		Me.Name = "SybaseConnectionForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Connect to Sybase database"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private buttonCancel As System.Windows.Forms.Button
	Private buttonConnect As System.Windows.Forms.Button
	Private label5 As System.Windows.Forms.Label
	Private textboxDataSourceName As System.Windows.Forms.TextBox
	Private buttonBrowse As System.Windows.Forms.Button
	Private label4 As System.Windows.Forms.Label
	Private textboxUser As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private textboxServerName As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private textboxPassword As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private textboxDatabaseFile As System.Windows.Forms.TextBox
End Class
