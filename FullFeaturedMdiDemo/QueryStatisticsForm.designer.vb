Partial Class QueryStatisticsForm
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
		Me.textBox = New System.Windows.Forms.TextBox()
		Me.buttonOk = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' textBox
		' 
		Me.textBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBox.Location = New System.Drawing.Point(12, 12)
		Me.textBox.Multiline = True
		Me.textBox.Name = "textBox"
		Me.textBox.[ReadOnly] = True
		Me.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox.Size = New System.Drawing.Size(486, 380)
		Me.textBox.TabIndex = 3
		Me.textBox.WordWrap = False
		' 
		' buttonOk
		' 
		Me.buttonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.buttonOk.Location = New System.Drawing.Point(423, 398)
		Me.buttonOk.Name = "buttonOk"
		Me.buttonOk.Size = New System.Drawing.Size(75, 23)
		Me.buttonOk.TabIndex = 2
		Me.buttonOk.Text = "OK"
		Me.buttonOk.UseVisualStyleBackColor = True
		' 
		' QueryStatisticsForm
		' 
		Me.AcceptButton = Me.buttonOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.buttonOk
		Me.ClientSize = New System.Drawing.Size(510, 433)
		Me.Controls.Add(Me.textBox)
		Me.Controls.Add(Me.buttonOk)
		Me.Name = "QueryStatisticsForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Query Statistics"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Public textBox As System.Windows.Forms.TextBox
	Private buttonOk As System.Windows.Forms.Button
End Class
