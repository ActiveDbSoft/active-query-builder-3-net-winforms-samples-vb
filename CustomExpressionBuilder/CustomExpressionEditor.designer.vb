Partial Class CustomExpressionEditor
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
		Me.btnOk = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.textBox = New System.Windows.Forms.TextBox()
		Me.panel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' panel1
		' 
		Me.panel1.Controls.Add(Me.btnOk)
		Me.panel1.Controls.Add(Me.btnCancel)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.panel1.Location = New System.Drawing.Point(12, 260)
		Me.panel1.Name = "panel1"
		Me.panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
		Me.panel1.Size = New System.Drawing.Size(364, 28)
		Me.panel1.TabIndex = 1
		' 
		' btnOk
		' 
		Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnOk.Location = New System.Drawing.Point(208, 5)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 23)
		Me.btnOk.TabIndex = 0
		Me.btnOk.Text = "OK"
		Me.btnOk.UseVisualStyleBackColor = True
		' 
		' btnCancel
		' 
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(289, 6)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 1
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		' 
		' textBox
		' 
		Me.textBox.Dock = System.Windows.Forms.DockStyle.Fill
		Me.textBox.Location = New System.Drawing.Point(12, 12)
		Me.textBox.Multiline = True
		Me.textBox.Name = "textBox"
		Me.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox.Size = New System.Drawing.Size(364, 248)
		Me.textBox.TabIndex = 0
		' 
		' CustomExpressionEditor
		' 
		Me.AcceptButton = Me.btnOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(388, 300)
		Me.Controls.Add(Me.textBox)
		Me.Controls.Add(Me.panel1)
		Me.Name = "CustomExpressionEditor"
		Me.Padding = New System.Windows.Forms.Padding(12)
		Me.Text = "Expression Editor"
		Me.panel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private panel1 As System.Windows.Forms.Panel
	Private btnOk As System.Windows.Forms.Button
	Private btnCancel As System.Windows.Forms.Button
	Public textBox As System.Windows.Forms.TextBox
End Class
