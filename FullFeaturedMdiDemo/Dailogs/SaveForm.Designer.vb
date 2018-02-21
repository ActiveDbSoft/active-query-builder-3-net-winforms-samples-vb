Namespace Dailogs
	Partial Class SaveForm
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
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label1.Location = New System.Drawing.Point(0, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(320, 41)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Save changes?"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' button1
			' 
			Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.button1.Location = New System.Drawing.Point(12, 3)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(95, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Save"
			Me.button1.UseVisualStyleBackColor = True
			AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.button2.Location = New System.Drawing.Point(113, 3)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(95, 23)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Don't save"
			Me.button2.UseVisualStyleBackColor = True
			AddHandler Me.button2.Click, New System.EventHandler(AddressOf Me.button2_Click)
			' 
			' button3
			' 
			Me.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.button3.Location = New System.Drawing.Point(213, 3)
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
			Me.panel1.Controls.Add(Me.button2)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel1.Location = New System.Drawing.Point(0, 41)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(320, 31)
			Me.panel1.TabIndex = 2
			' 
			' SaveForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSize = True
			Me.ClientSize = New System.Drawing.Size(320, 72)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.panel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "SaveForm"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Save"
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private button1 As System.Windows.Forms.Button
		Private button2 As System.Windows.Forms.Button
		Private button3 As System.Windows.Forms.Button
		Private panel1 As System.Windows.Forms.Panel
	End Class
End Namespace
