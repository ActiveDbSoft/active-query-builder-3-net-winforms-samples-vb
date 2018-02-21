Namespace ConnectionFrames
	NotInheritable Partial Class MSAccessConnectionFrame
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
			Me.btnBrowse = New System.Windows.Forms.Button()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.tbPassword = New System.Windows.Forms.TextBox()
			Me.tbUserID = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.tbDataSource = New System.Windows.Forms.TextBox()
			Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
			Me.btnEditConnectionString = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' btnBrowse
			' 
			Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.btnBrowse.Location = New System.Drawing.Point(235, 1)
			Me.btnBrowse.Name = "btnBrowse"
			Me.btnBrowse.Size = New System.Drawing.Size(25, 23)
			Me.btnBrowse.TabIndex = 1
			Me.btnBrowse.Text = "..."
			Me.btnBrowse.UseVisualStyleBackColor = True
			AddHandler Me.btnBrowse.Click, New System.EventHandler(AddressOf Me.btnBrowse_Click)
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(3, 58)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(56, 13)
			Me.label4.TabIndex = 16
			Me.label4.Text = "Password:"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(3, 32)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(32, 13)
			Me.label3.TabIndex = 15
			Me.label3.Text = "User:"
			' 
			' tbPassword
			' 
			Me.tbPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbPassword.Location = New System.Drawing.Point(65, 55)
			Me.tbPassword.Name = "tbPassword"
			Me.tbPassword.Size = New System.Drawing.Size(164, 20)
			Me.tbPassword.TabIndex = 3
			Me.tbPassword.UseSystemPasswordChar = True
			' 
			' tbUserID
			' 
			Me.tbUserID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbUserID.Location = New System.Drawing.Point(65, 29)
			Me.tbUserID.Name = "tbUserID"
			Me.tbUserID.Size = New System.Drawing.Size(164, 20)
			Me.tbUserID.TabIndex = 2
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(3, 6)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(56, 13)
			Me.label1.TabIndex = 12
			Me.label1.Text = "Database:"
			' 
			' tbDataSource
			' 
			Me.tbDataSource.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbDataSource.Location = New System.Drawing.Point(65, 3)
			Me.tbDataSource.Name = "tbDataSource"
			Me.tbDataSource.Size = New System.Drawing.Size(164, 20)
			Me.tbDataSource.TabIndex = 0
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.DefaultExt = "mdb"
			Me.openFileDialog1.Filter = "Microsoft Access databases (*.accdb;*.mdb)|*.accdb;*.mdb|ACCDB databases (*.accdb" & ")|*.accdb|MDB databases (*.mdb)|*.mdb|All files|*.*"
			' 
			' btnEditConnectionString
			' 
			Me.btnEditConnectionString.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.btnEditConnectionString.Location = New System.Drawing.Point(127, 86)
			Me.btnEditConnectionString.Name = "btnEditConnectionString"
			Me.btnEditConnectionString.Size = New System.Drawing.Size(133, 23)
			Me.btnEditConnectionString.TabIndex = 23
			Me.btnEditConnectionString.Text = "Edit Connection String"
			Me.btnEditConnectionString.UseVisualStyleBackColor = True
			AddHandler Me.btnEditConnectionString.Click, New System.EventHandler(AddressOf Me.btnEditConnectionString_Click)
			' 
			' MSAccessConnectionFrame
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.btnEditConnectionString)
			Me.Controls.Add(Me.btnBrowse)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.tbPassword)
			Me.Controls.Add(Me.tbUserID)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.tbDataSource)
			Me.Name = "MSAccessConnectionFrame"
			Me.Size = New System.Drawing.Size(263, 112)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private btnBrowse As System.Windows.Forms.Button
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private tbPassword As System.Windows.Forms.TextBox
		Private tbUserID As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private tbDataSource As System.Windows.Forms.TextBox
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private btnEditConnectionString As System.Windows.Forms.Button
	End Class
End Namespace
