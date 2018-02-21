Partial Class OLEDBConnectionForm
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
		Me.textBoxConnectionString = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.buttonCancel = New System.Windows.Forms.Button()
		Me.buttonConnect = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' textBoxConnectionString
		' 
		Me.textBoxConnectionString.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxConnectionString.Location = New System.Drawing.Point(12, 25)
		Me.textBoxConnectionString.Multiline = True
		Me.textBoxConnectionString.Name = "textBoxConnectionString"
		Me.textBoxConnectionString.Size = New System.Drawing.Size(261, 142)
		Me.textBoxConnectionString.TabIndex = 0
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(92, 13)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Connection string:"
		' 
		' buttonCancel
		' 
		Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonCancel.Location = New System.Drawing.Point(198, 173)
		Me.buttonCancel.Name = "buttonCancel"
		Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
		Me.buttonCancel.TabIndex = 2
		Me.buttonCancel.Text = "Cancel"
		Me.buttonCancel.UseVisualStyleBackColor = True
		' 
		' buttonConnect
		' 
		Me.buttonConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.buttonConnect.Location = New System.Drawing.Point(117, 173)
		Me.buttonConnect.Name = "buttonConnect"
		Me.buttonConnect.Size = New System.Drawing.Size(75, 23)
		Me.buttonConnect.TabIndex = 1
		Me.buttonConnect.Text = "Connect"
		Me.buttonConnect.UseVisualStyleBackColor = True
		AddHandler Me.buttonConnect.Click, New System.EventHandler(AddressOf Me.buttonConnect_Click)
		' 
		' OLEDBConnectionForm
		' 
		Me.AcceptButton = Me.buttonConnect
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.buttonCancel
		Me.ClientSize = New System.Drawing.Size(285, 208)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.buttonConnect)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textBoxConnectionString)
		Me.Name = "OLEDBConnectionForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "OLE DB Connection"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private textBoxConnectionString As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private buttonCancel As System.Windows.Forms.Button
	Private buttonConnect As System.Windows.Forms.Button
End Class
