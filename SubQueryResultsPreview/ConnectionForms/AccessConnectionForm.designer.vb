Partial Class AccessConnectionForm
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
		Me.textboxDatabase = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.buttonConnect = New System.Windows.Forms.Button()
		Me.buttonCancel = New System.Windows.Forms.Button()
		Me.textboxUserName = New System.Windows.Forms.TextBox()
		Me.textboxPassword = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.buttonBrowse = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' textboxDatabase
		' 
		Me.textboxDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textboxDatabase.Location = New System.Drawing.Point(74, 12)
		Me.textboxDatabase.Name = "textboxDatabase"
		Me.textboxDatabase.Size = New System.Drawing.Size(248, 20)
		Me.textboxDatabase.TabIndex = 0
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(12, 15)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(56, 13)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Database:"
		' 
		' buttonConnect
		' 
		Me.buttonConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.buttonConnect.Location = New System.Drawing.Point(197, 108)
		Me.buttonConnect.Name = "buttonConnect"
		Me.buttonConnect.Size = New System.Drawing.Size(75, 23)
		Me.buttonConnect.TabIndex = 4
		Me.buttonConnect.Text = "Connect"
		Me.buttonConnect.UseVisualStyleBackColor = True
		AddHandler Me.buttonConnect.Click, New System.EventHandler(AddressOf Me.buttonConnect_Click)
		' 
		' buttonCancel
		' 
		Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonCancel.Location = New System.Drawing.Point(278, 108)
		Me.buttonCancel.Name = "buttonCancel"
		Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
		Me.buttonCancel.TabIndex = 5
		Me.buttonCancel.Text = "Cancel"
		Me.buttonCancel.UseVisualStyleBackColor = True
		' 
		' textboxUserName
		' 
		Me.textboxUserName.Location = New System.Drawing.Point(74, 38)
		Me.textboxUserName.Name = "textboxUserName"
		Me.textboxUserName.Size = New System.Drawing.Size(125, 20)
		Me.textboxUserName.TabIndex = 2
		Me.textboxUserName.Text = "Admin"
		' 
		' textboxPassword
		' 
		Me.textboxPassword.Location = New System.Drawing.Point(74, 64)
		Me.textboxPassword.Name = "textboxPassword"
		Me.textboxPassword.Size = New System.Drawing.Size(125, 20)
		Me.textboxPassword.TabIndex = 3
		Me.textboxPassword.UseSystemPasswordChar = True
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(12, 41)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(61, 13)
		Me.label3.TabIndex = 8
		Me.label3.Text = "User name:"
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(12, 67)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(56, 13)
		Me.label4.TabIndex = 9
		Me.label4.Text = "Password:"
		' 
		' openFileDialog1
		' 
		Me.openFileDialog1.DefaultExt = "mdb"
		Me.openFileDialog1.Filter = "Microsoft Access databases (*.accdb;*.mdb)|*.accdb;*.mdb|ACCDB databases (*.accdb" & ")|*.accdb|MDB databases (*.mdb)|*.mdb|All files|*.*"
		' 
		' buttonBrowse
		' 
		Me.buttonBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonBrowse.Location = New System.Drawing.Point(328, 10)
		Me.buttonBrowse.Name = "buttonBrowse"
		Me.buttonBrowse.Size = New System.Drawing.Size(25, 23)
		Me.buttonBrowse.TabIndex = 1
		Me.buttonBrowse.Text = "..."
		Me.buttonBrowse.UseVisualStyleBackColor = True
		AddHandler Me.buttonBrowse.Click, New System.EventHandler(AddressOf Me.buttonBrowse_Click)
		' 
		' AccessConnectionForm
		' 
		Me.AcceptButton = Me.buttonConnect
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.buttonCancel
		Me.ClientSize = New System.Drawing.Size(365, 143)
		Me.Controls.Add(Me.buttonBrowse)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.textboxPassword)
		Me.Controls.Add(Me.textboxUserName)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.buttonConnect)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textboxDatabase)
		Me.Name = "AccessConnectionForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Connect to Microsoft Access database"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private textboxDatabase As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private buttonConnect As System.Windows.Forms.Button
	Private buttonCancel As System.Windows.Forms.Button
	Private textboxUserName As System.Windows.Forms.TextBox
	Private textboxPassword As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private buttonBrowse As System.Windows.Forms.Button
End Class
