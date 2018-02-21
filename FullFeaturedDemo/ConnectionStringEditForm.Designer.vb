Partial Class ConnectionStringEditForm
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
		Me.btnOk = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.tbConnectionString = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		' 
		' btnOk
		' 
		Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnOk.Location = New System.Drawing.Point(321, 337)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 23)
		Me.btnOk.TabIndex = 1
		Me.btnOk.Text = "OK"
		Me.btnOk.UseVisualStyleBackColor = True
		' 
		' btnCancel
		' 
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(402, 337)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 2
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		' 
		' tbConnectionString
		' 
		Me.tbConnectionString.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbConnectionString.Location = New System.Drawing.Point(12, 12)
		Me.tbConnectionString.Multiline = True
		Me.tbConnectionString.Name = "tbConnectionString"
		Me.tbConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.tbConnectionString.Size = New System.Drawing.Size(465, 319)
		Me.tbConnectionString.TabIndex = 0
		' 
		' ConnectionStringEditForm
		' 
		Me.AcceptButton = Me.btnOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(489, 372)
		Me.Controls.Add(Me.tbConnectionString)
		Me.Controls.Add(Me.btnOk)
		Me.Controls.Add(Me.btnCancel)
		Me.Name = "ConnectionStringEditForm"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Connection String"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private btnOk As System.Windows.Forms.Button
	Private btnCancel As System.Windows.Forms.Button
	Private tbConnectionString As System.Windows.Forms.TextBox
End Class
