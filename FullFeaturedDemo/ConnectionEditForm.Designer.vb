Partial Class ConnectionEditForm
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
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.rbODBC = New System.Windows.Forms.RadioButton()
		Me.rbOLEDB = New System.Windows.Forms.RadioButton()
		Me.rbPostrgeSQL = New System.Windows.Forms.RadioButton()
		Me.label1 = New System.Windows.Forms.Label()
		Me.rbMySQL = New System.Windows.Forms.RadioButton()
		Me.rbOracle = New System.Windows.Forms.RadioButton()
		Me.rbMSAccess = New System.Windows.Forms.RadioButton()
		Me.rbMSSQL = New System.Windows.Forms.RadioButton()
		Me.pnlFrames = New System.Windows.Forms.Panel()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.BoxSyntaxProvider = New System.Windows.Forms.ComboBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tbConnectionName = New System.Windows.Forms.TextBox()
		Me.BoxServerVersion = New System.Windows.Forms.ComboBox()
		Me.panel1.SuspendLayout()
		Me.panel2.SuspendLayout()
		Me.SuspendLayout()
		' 
		' panel1
		' 
		Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.panel1.BackColor = System.Drawing.Color.White
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.rbODBC)
		Me.panel1.Controls.Add(Me.rbOLEDB)
		Me.panel1.Controls.Add(Me.rbPostrgeSQL)
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Controls.Add(Me.rbMySQL)
		Me.panel1.Controls.Add(Me.rbOracle)
		Me.panel1.Controls.Add(Me.rbMSAccess)
		Me.panel1.Controls.Add(Me.rbMSSQL)
		Me.panel1.Location = New System.Drawing.Point(12, 12)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(159, 356)
		Me.panel1.TabIndex = 0
		' 
		' rbODBC
		' 
		Me.rbODBC.AutoSize = True
		Me.rbODBC.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.rbODBC.ForeColor = System.Drawing.Color.SteelBlue
		Me.rbODBC.Location = New System.Drawing.Point(10, 166)
		Me.rbODBC.Name = "rbODBC"
		Me.rbODBC.Size = New System.Drawing.Size(55, 17)
		Me.rbODBC.TabIndex = 8
		Me.rbODBC.Text = "ODBC"
		Me.rbODBC.UseVisualStyleBackColor = True
		' 
		' rbOLEDB
		' 
		Me.rbOLEDB.AutoSize = True
		Me.rbOLEDB.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.rbOLEDB.ForeColor = System.Drawing.Color.SteelBlue
		Me.rbOLEDB.Location = New System.Drawing.Point(10, 143)
		Me.rbOLEDB.Name = "rbOLEDB"
		Me.rbOLEDB.Size = New System.Drawing.Size(63, 17)
		Me.rbOLEDB.TabIndex = 7
		Me.rbOLEDB.Text = "OLE DB"
		Me.rbOLEDB.UseVisualStyleBackColor = True
		' 
		' rbPostrgeSQL
		' 
		Me.rbPostrgeSQL.AutoSize = True
		Me.rbPostrgeSQL.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.rbPostrgeSQL.ForeColor = System.Drawing.Color.SteelBlue
		Me.rbPostrgeSQL.Location = New System.Drawing.Point(10, 97)
		Me.rbPostrgeSQL.Name = "rbPostrgeSQL"
		Me.rbPostrgeSQL.Size = New System.Drawing.Size(90, 17)
		Me.rbPostrgeSQL.TabIndex = 5
		Me.rbPostrgeSQL.Text = "PostgreSQL"
		Me.rbPostrgeSQL.UseVisualStyleBackColor = True
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(10, 122)
		Me.label1.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(139, 13)
		Me.label1.TabIndex = 6
		Me.label1.Text = "--------------------------------------------"
		' 
		' rbMySQL
		' 
		Me.rbMySQL.AutoSize = True
		Me.rbMySQL.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.rbMySQL.ForeColor = System.Drawing.Color.SteelBlue
		Me.rbMySQL.Location = New System.Drawing.Point(10, 74)
		Me.rbMySQL.Name = "rbMySQL"
		Me.rbMySQL.Size = New System.Drawing.Size(63, 17)
		Me.rbMySQL.TabIndex = 3
		Me.rbMySQL.Text = "MySQL"
		Me.rbMySQL.UseVisualStyleBackColor = True
		' 
		' rbOracle
		' 
		Me.rbOracle.AutoSize = True
		Me.rbOracle.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.rbOracle.ForeColor = System.Drawing.Color.SteelBlue
		Me.rbOracle.Location = New System.Drawing.Point(10, 51)
		Me.rbOracle.Name = "rbOracle"
		Me.rbOracle.Size = New System.Drawing.Size(61, 17)
		Me.rbOracle.TabIndex = 2
		Me.rbOracle.Text = "Oracle"
		Me.rbOracle.UseVisualStyleBackColor = True
		' 
		' rbMSAccess
		' 
		Me.rbMSAccess.AutoSize = True
		Me.rbMSAccess.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.rbMSAccess.ForeColor = System.Drawing.Color.SteelBlue
		Me.rbMSAccess.Location = New System.Drawing.Point(10, 28)
		Me.rbMSAccess.Name = "rbMSAccess"
		Me.rbMSAccess.Size = New System.Drawing.Size(120, 17)
		Me.rbMSAccess.TabIndex = 1
		Me.rbMSAccess.Text = "Microsoft Access"
		Me.rbMSAccess.UseVisualStyleBackColor = True
		' 
		' rbMSSQL
		' 
		Me.rbMSSQL.AutoSize = True
		Me.rbMSSQL.Checked = True
		Me.rbMSSQL.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.rbMSSQL.ForeColor = System.Drawing.Color.SteelBlue
		Me.rbMSSQL.Location = New System.Drawing.Point(10, 5)
		Me.rbMSSQL.Margin = New System.Windows.Forms.Padding(10, 5, 10, 3)
		Me.rbMSSQL.Name = "rbMSSQL"
		Me.rbMSSQL.Size = New System.Drawing.Size(143, 17)
		Me.rbMSSQL.TabIndex = 0
		Me.rbMSSQL.TabStop = True
		Me.rbMSSQL.Text = "Microsoft SQL Server"
		Me.rbMSSQL.UseVisualStyleBackColor = True
		' 
		' pnlFrames
		' 
		Me.pnlFrames.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlFrames.BackColor = System.Drawing.Color.White
		Me.pnlFrames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlFrames.Location = New System.Drawing.Point(177, 110)
		Me.pnlFrames.Name = "pnlFrames"
		Me.pnlFrames.Padding = New System.Windows.Forms.Padding(6)
		Me.pnlFrames.Size = New System.Drawing.Size(364, 258)
		Me.pnlFrames.TabIndex = 2
		' 
		' btnOk
		' 
		Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnOk.Location = New System.Drawing.Point(385, 374)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 23)
		Me.btnOk.TabIndex = 3
		Me.btnOk.Text = "OK"
		Me.btnOk.UseVisualStyleBackColor = True
		' 
		' btnCancel
		' 
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(466, 374)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 4
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		' 
		' panel2
		' 
		Me.panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.panel2.BackColor = System.Drawing.Color.White
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.BoxSyntaxProvider)
		Me.panel2.Controls.Add(Me.label4)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.label2)
		Me.panel2.Controls.Add(Me.tbConnectionName)
		Me.panel2.Location = New System.Drawing.Point(177, 12)
		Me.panel2.Name = "panel2"
		Me.panel2.Padding = New System.Windows.Forms.Padding(6)
		Me.panel2.Size = New System.Drawing.Size(364, 92)
		Me.panel2.TabIndex = 1
		' 
		' BoxSyntaxProvider
		' 
		Me.BoxSyntaxProvider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.BoxSyntaxProvider.Enabled = False
		Me.BoxSyntaxProvider.FormattingEnabled = True
		Me.BoxSyntaxProvider.Location = New System.Drawing.Point(120, 36)
		Me.BoxSyntaxProvider.Name = "BoxSyntaxProvider"
		Me.BoxSyntaxProvider.Size = New System.Drawing.Size(233, 21)
		Me.BoxSyntaxProvider.TabIndex = 2
		AddHandler Me.BoxSyntaxProvider.SelectedIndexChanged, New System.EventHandler(AddressOf Me.BoxSyntaxProvider_SelectedIndexChanged)
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.label4.Location = New System.Drawing.Point(9, 66)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(77, 13)
		Me.label4.TabIndex = 1
		Me.label4.Text = "Server Version"
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.label3.Location = New System.Drawing.Point(9, 39)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(84, 13)
		Me.label3.TabIndex = 1
		Me.label3.Text = "Syntax Provider"
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.label2.Location = New System.Drawing.Point(9, 12)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(105, 13)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Connection Name"
		' 
		' tbConnectionName
		' 
		Me.tbConnectionName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbConnectionName.Location = New System.Drawing.Point(120, 9)
		Me.tbConnectionName.Name = "tbConnectionName"
		Me.tbConnectionName.Size = New System.Drawing.Size(233, 20)
		Me.tbConnectionName.TabIndex = 0
		' 
		' BoxServerVersion
		' 
		Me.BoxServerVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.BoxServerVersion.Enabled = False
		Me.BoxServerVersion.FormattingEnabled = True
		Me.BoxServerVersion.Location = New System.Drawing.Point(298, 76)
		Me.BoxServerVersion.Name = "BoxServerVersion"
		Me.BoxServerVersion.Size = New System.Drawing.Size(233, 21)
		Me.BoxServerVersion.TabIndex = 2
		AddHandler Me.BoxServerVersion.SelectedIndexChanged, New System.EventHandler(AddressOf Me.BoxServerVersion_SelectedIndexChanged)
		' 
		' ConnectionEditForm
		' 
		Me.AcceptButton = Me.btnOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(553, 409)
		Me.Controls.Add(Me.BoxServerVersion)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.btnOk)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.pnlFrames)
		Me.Controls.Add(Me.panel1)
		Me.MinimumSize = New System.Drawing.Size(480, 295)
		Me.Name = "ConnectionEditForm"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Add Connection"
		AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.ConnectionEditForm_FormClosing)
		Me.panel1.ResumeLayout(False)
		Me.panel1.PerformLayout()
		Me.panel2.ResumeLayout(False)
		Me.panel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private panel1 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private pnlFrames As System.Windows.Forms.Panel
	Private btnOk As System.Windows.Forms.Button
	Private btnCancel As System.Windows.Forms.Button
	Private rbMSAccess As System.Windows.Forms.RadioButton
	Private rbMSSQL As System.Windows.Forms.RadioButton
	Private rbODBC As System.Windows.Forms.RadioButton
	Private rbOLEDB As System.Windows.Forms.RadioButton
	Private rbPostrgeSQL As System.Windows.Forms.RadioButton
	Private rbMySQL As System.Windows.Forms.RadioButton
	Private rbOracle As System.Windows.Forms.RadioButton
	Private panel2 As System.Windows.Forms.Panel
	Private label2 As System.Windows.Forms.Label
	Private tbConnectionName As System.Windows.Forms.TextBox
	Private BoxSyntaxProvider As System.Windows.Forms.ComboBox
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private BoxServerVersion As System.Windows.Forms.ComboBox
End Class
