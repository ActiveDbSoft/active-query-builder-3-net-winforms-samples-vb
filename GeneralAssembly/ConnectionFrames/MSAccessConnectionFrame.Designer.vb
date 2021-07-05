Namespace ConnectionFrames
	Public NotInheritable Partial Class MSAccessConnectionFrame
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
			Me.btnBrowse = New Button()
			Me.label4 = New Label()
			Me.label3 = New Label()
			Me.tbPassword = New TextBox()
			Me.tbUserID = New TextBox()
			Me.label1 = New Label()
			Me.tbDataSource = New TextBox()
			Me.openFileDialog1 = New OpenFileDialog()
			Me.btnEditConnectionString = New Button()
			Me.SuspendLayout()
			' 
			' btnBrowse
			' 
			Me.btnBrowse.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.btnBrowse.Location = New Point(235, 1)
			Me.btnBrowse.Name = "btnBrowse"
			Me.btnBrowse.Size = New Size(25, 23)
			Me.btnBrowse.TabIndex = 1
			Me.btnBrowse.Text = "..."
			Me.btnBrowse.UseVisualStyleBackColor = True
'			Me.btnBrowse.Click += New System.EventHandler(Me.btnBrowse_Click)
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New Point(3, 58)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(56, 13)
			Me.label4.TabIndex = 16
			Me.label4.Text = "Password:"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New Point(3, 32)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(32, 13)
			Me.label3.TabIndex = 15
			Me.label3.Text = "User:"
			' 
			' tbPassword
			' 
			Me.tbPassword.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.tbPassword.Location = New Point(65, 55)
			Me.tbPassword.Name = "tbPassword"
			Me.tbPassword.Size = New Size(164, 20)
			Me.tbPassword.TabIndex = 3
			Me.tbPassword.UseSystemPasswordChar = True
			' 
			' tbUserID
			' 
			Me.tbUserID.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.tbUserID.Location = New Point(65, 29)
			Me.tbUserID.Name = "tbUserID"
			Me.tbUserID.Size = New Size(164, 20)
			Me.tbUserID.TabIndex = 2
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New Point(3, 6)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(56, 13)
			Me.label1.TabIndex = 12
			Me.label1.Text = "Database:"
			' 
			' tbDataSource
			' 
			Me.tbDataSource.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.tbDataSource.Location = New Point(65, 3)
			Me.tbDataSource.Name = "tbDataSource"
			Me.tbDataSource.Size = New Size(164, 20)
			Me.tbDataSource.TabIndex = 0
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.DefaultExt = "mdb"
			Me.openFileDialog1.Filter = "Microsoft Access databases (*.accdb;*.mdb)|*.accdb;*.mdb|ACCDB databases (*.accdb" & ")|*.accdb|MDB databases (*.mdb)|*.mdb|All files|*.*"
			' 
			' btnEditConnectionString
			' 
			Me.btnEditConnectionString.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.btnEditConnectionString.Location = New Point(127, 86)
			Me.btnEditConnectionString.Name = "btnEditConnectionString"
			Me.btnEditConnectionString.Size = New Size(133, 23)
			Me.btnEditConnectionString.TabIndex = 23
			Me.btnEditConnectionString.Text = "Edit Connection String"
			Me.btnEditConnectionString.UseVisualStyleBackColor = True
'			Me.btnEditConnectionString.Click += New System.EventHandler(Me.btnEditConnectionString_Click)
			' 
			' MSAccessConnectionFrame
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.btnEditConnectionString)
			Me.Controls.Add(Me.btnBrowse)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.tbPassword)
			Me.Controls.Add(Me.tbUserID)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.tbDataSource)
			Me.Name = "MSAccessConnectionFrame"
			Me.Size = New Size(263, 112)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents btnBrowse As Button
		Private label4 As Label
		Private label3 As Label
		Private tbPassword As TextBox
		Private tbUserID As TextBox
		Private label1 As Label
		Private tbDataSource As TextBox
		Private openFileDialog1 As OpenFileDialog
		Private WithEvents btnEditConnectionString As Button
	End Class
End Namespace
