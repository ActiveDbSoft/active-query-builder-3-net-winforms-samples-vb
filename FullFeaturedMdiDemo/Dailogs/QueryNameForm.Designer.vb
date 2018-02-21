Namespace Dailogs
	Partial Class QueryNameForm
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(90, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Name user query:"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' button1
			' 
			Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.button1.Location = New System.Drawing.Point(62, 3)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(95, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "OK"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' button3
			' 
			Me.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.button3.Location = New System.Drawing.Point(163, 3)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(95, 23)
			Me.button3.TabIndex = 1
			Me.button3.Text = "Cancel"
			Me.button3.UseVisualStyleBackColor = True
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.button3)
			Me.panel1.Controls.Add(Me.button1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel1.Location = New System.Drawing.Point(0, 51)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(320, 29)
			Me.panel1.TabIndex = 2
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(12, 25)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(296, 20)
			Me.textBox1.TabIndex = 3
			Me.textBox1.Text = "New Query"
			' 
			' QueryNameForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSize = True
			Me.ClientSize = New System.Drawing.Size(320, 80)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.panel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "QueryNameForm"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Save"
			AddHandler Me.Shown, New System.EventHandler(AddressOf Me.QueryNameForm_Shown)
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private button1 As System.Windows.Forms.Button
		Private button3 As System.Windows.Forms.Button
		Private panel1 As System.Windows.Forms.Panel
		Private textBox1 As System.Windows.Forms.TextBox
	End Class
End Namespace
