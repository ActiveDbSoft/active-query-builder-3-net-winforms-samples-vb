Namespace Dailogs
	Partial Public Class SaveAsForm
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
			Me.label1 = New Label()
			Me.button1 = New Button()
			Me.button2 = New Button()
			Me.button3 = New Button()
			Me.panel1 = New Panel()
			Me.button4 = New Button()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Dock = DockStyle.Fill
			Me.label1.Location = New Point(0, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(424, 37)
			Me.label1.TabIndex = 0
			Me.label1.TextAlign = ContentAlignment.MiddleCenter
			' 
			' button1
			' 
			Me.button1.DialogResult = DialogResult.OK
			Me.button1.Location = New Point(12, 5)
			Me.button1.Name = "button1"
			Me.button1.Size = New Size(92, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Save to file..."
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.DialogResult = DialogResult.OK
			Me.button2.Location = New Point(110, 5)
			Me.button2.Name = "button2"
			Me.button2.Size = New Size(119, 23)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Save as User Query"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' button3
			' 
			Me.button3.DialogResult = DialogResult.Cancel
			Me.button3.Location = New Point(337, 5)
			Me.button3.Name = "button3"
			Me.button3.Size = New Size(75, 23)
			Me.button3.TabIndex = 1
			Me.button3.Text = "Cancel"
			Me.button3.UseVisualStyleBackColor = True
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.button4)
			Me.panel1.Controls.Add(Me.button3)
			Me.panel1.Controls.Add(Me.button1)
			Me.panel1.Controls.Add(Me.button2)
			Me.panel1.Dock = DockStyle.Bottom
			Me.panel1.Location = New Point(0, 37)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Size(424, 37)
			Me.panel1.TabIndex = 2
			' 
			' button4
			' 
			Me.button4.DialogResult = DialogResult.No
			Me.button4.Location = New Point(235, 5)
			Me.button4.Name = "button4"
			Me.button4.Size = New Size(96, 23)
			Me.button4.TabIndex = 2
			Me.button4.Text = "Don't save"
			Me.button4.UseVisualStyleBackColor = True
			' 
			' SaveAsForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoSize = True
			Me.ClientSize = New Size(424, 74)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.panel1)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "SaveAsForm"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Save"
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private label1 As Label
		Private WithEvents button1 As Button
		Private WithEvents button2 As Button
		Private button3 As Button
		Private panel1 As Panel
		Private button4 As Button
	End Class
End Namespace