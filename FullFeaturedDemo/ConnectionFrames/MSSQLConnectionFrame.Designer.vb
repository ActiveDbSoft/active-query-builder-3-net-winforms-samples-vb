Namespace ConnectionFrames
	NotInheritable Partial Class MSSQLConnectionFrame
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
			Me.label5 = New System.Windows.Forms.Label()
			Me.cmbInitialCatalog = New System.Windows.Forms.ComboBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.tbPassword = New System.Windows.Forms.TextBox()
			Me.tbUserID = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.cmbIntegratedSecurity = New System.Windows.Forms.ComboBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.tbDataSource = New System.Windows.Forms.TextBox()
			Me.btnEditConnectionString = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(3, 111)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(56, 13)
			Me.label5.TabIndex = 21
			Me.label5.Text = "Database:"
			' 
			' cmbInitialCatalog
			' 
			Me.cmbInitialCatalog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.cmbInitialCatalog.FormattingEnabled = True
			Me.cmbInitialCatalog.Items.AddRange(New Object() {"<default>"})
			Me.cmbInitialCatalog.Location = New System.Drawing.Point(87, 108)
			Me.cmbInitialCatalog.Name = "cmbInitialCatalog"
			Me.cmbInitialCatalog.Size = New System.Drawing.Size(145, 21)
			Me.cmbInitialCatalog.Sorted = True
			Me.cmbInitialCatalog.TabIndex = 20
			AddHandler Me.cmbInitialCatalog.DropDown, New System.EventHandler(AddressOf Me.cmbInitialCatalog_DropDown)
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(3, 85)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(56, 13)
			Me.label4.TabIndex = 19
			Me.label4.Text = "Password:"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(3, 59)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(36, 13)
			Me.label3.TabIndex = 18
			Me.label3.Text = "Login:"
			' 
			' tbPassword
			' 
			Me.tbPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbPassword.Location = New System.Drawing.Point(87, 82)
			Me.tbPassword.Name = "tbPassword"
			Me.tbPassword.Size = New System.Drawing.Size(145, 20)
			Me.tbPassword.TabIndex = 16
			Me.tbPassword.UseSystemPasswordChar = True
			' 
			' tbUserID
			' 
			Me.tbUserID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbUserID.Location = New System.Drawing.Point(87, 56)
			Me.tbUserID.Name = "tbUserID"
			Me.tbUserID.Size = New System.Drawing.Size(145, 20)
			Me.tbUserID.TabIndex = 15
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(3, 32)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(78, 13)
			Me.label2.TabIndex = 17
			Me.label2.Text = "Authentication:"
			' 
			' cmbIntegratedSecurity
			' 
			Me.cmbIntegratedSecurity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.cmbIntegratedSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbIntegratedSecurity.FormattingEnabled = True
			Me.cmbIntegratedSecurity.Items.AddRange(New Object() {"Windows Authentication", "SQL Server Authentication"})
			Me.cmbIntegratedSecurity.Location = New System.Drawing.Point(87, 29)
			Me.cmbIntegratedSecurity.Name = "cmbIntegratedSecurity"
			Me.cmbIntegratedSecurity.Size = New System.Drawing.Size(145, 21)
			Me.cmbIntegratedSecurity.TabIndex = 13
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(3, 6)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(41, 13)
			Me.label1.TabIndex = 14
			Me.label1.Text = "Server:"
			' 
			' tbDataSource
			' 
			Me.tbDataSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbDataSource.Location = New System.Drawing.Point(87, 3)
			Me.tbDataSource.Name = "tbDataSource"
			Me.tbDataSource.Size = New System.Drawing.Size(145, 20)
			Me.tbDataSource.TabIndex = 12
			' 
			' btnEditConnectionString
			' 
			Me.btnEditConnectionString.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.btnEditConnectionString.Location = New System.Drawing.Point(99, 143)
			Me.btnEditConnectionString.Name = "btnEditConnectionString"
			Me.btnEditConnectionString.Size = New System.Drawing.Size(133, 23)
			Me.btnEditConnectionString.TabIndex = 22
			Me.btnEditConnectionString.Text = "Edit Connection String"
			Me.btnEditConnectionString.UseVisualStyleBackColor = True
			AddHandler Me.btnEditConnectionString.Click, New System.EventHandler(AddressOf Me.btnEditConnectionString_Click)
			' 
			' MSSQLConnectionFrame
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.btnEditConnectionString)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.cmbInitialCatalog)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.tbPassword)
			Me.Controls.Add(Me.tbUserID)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.cmbIntegratedSecurity)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.tbDataSource)
			Me.Name = "MSSQLConnectionFrame"
			Me.Size = New System.Drawing.Size(235, 169)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label5 As System.Windows.Forms.Label
		Private cmbInitialCatalog As System.Windows.Forms.ComboBox
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private tbPassword As System.Windows.Forms.TextBox
		Private tbUserID As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private cmbIntegratedSecurity As System.Windows.Forms.ComboBox
		Private label1 As System.Windows.Forms.Label
		Private tbDataSource As System.Windows.Forms.TextBox
		Private btnEditConnectionString As System.Windows.Forms.Button
	End Class
End Namespace
