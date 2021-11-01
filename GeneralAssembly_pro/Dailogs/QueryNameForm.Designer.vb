Namespace Dailogs
	Partial Public Class QueryNameForm
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
			Me.button3 = New Button()
			Me.panel1 = New Panel()
			Me.textBox1 = New TextBox()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New Point(9, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(67, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Query name:"
			Me.label1.TextAlign = ContentAlignment.MiddleCenter
			' 
			' button1
			' 
			Me.button1.DialogResult = DialogResult.OK
			Me.button1.Location = New Point(62, 3)
			Me.button1.Name = "button1"
			Me.button1.Size = New Size(95, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "OK"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' button3
			' 
			Me.button3.DialogResult = DialogResult.Cancel
			Me.button3.Location = New Point(163, 3)
			Me.button3.Name = "button3"
			Me.button3.Size = New Size(95, 23)
			Me.button3.TabIndex = 1
			Me.button3.Text = "Cancel"
			Me.button3.UseVisualStyleBackColor = True
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.button3)
			Me.panel1.Controls.Add(Me.button1)
			Me.panel1.Dock = DockStyle.Bottom
			Me.panel1.Location = New Point(0, 51)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Size(320, 29)
			Me.panel1.TabIndex = 2
			' 
			' textBox1
			' 
			Me.textBox1.Location = New Point(12, 25)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New Size(296, 20)
			Me.textBox1.TabIndex = 3
			Me.textBox1.Text = "New Query"
			' 
			' QueryNameForm
			' 
			Me.AcceptButton = Me.button1
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoSize = True
			Me.CancelButton = Me.button3
			Me.ClientSize = New Size(320, 80)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.panel1)
			Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "QueryNameForm"
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Save as reusable query"
'			Me.Shown += New System.EventHandler(Me.QueryNameForm_Shown)
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As Label
		Private button1 As Button
		Private button3 As Button
		Private panel1 As Panel
		Private textBox1 As TextBox
	End Class
End Namespace