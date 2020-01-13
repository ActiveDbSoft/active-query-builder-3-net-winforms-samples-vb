Imports ActiveQueryBuilder.View.WinForms.QueryView

Partial Class EditXMLConnectionForm
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
		Me.pnlTop = New System.Windows.Forms.Panel()
		Me.label3 = New System.Windows.Forms.Label()
		Me.cbSyntax = New System.Windows.Forms.ComboBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.tbConnectionName = New System.Windows.Forms.TextBox()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.openDialog = New System.Windows.Forms.OpenFileDialog()
		Me.pbSyntax = New ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar()
		Me.pnlFilePath = New System.Windows.Forms.Panel()
		Me.btnOpenDialog = New System.Windows.Forms.Button()
		Me.tbXmlPath = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.pnlTop.SuspendLayout()
		Me.pnlFilePath.SuspendLayout()
		Me.SuspendLayout()
		' 
		' pnlTop
		' 
		Me.pnlTop.BackColor = System.Drawing.Color.White
		Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlTop.Controls.Add(Me.label3)
		Me.pnlTop.Controls.Add(Me.cbSyntax)
		Me.pnlTop.Controls.Add(Me.label2)
		Me.pnlTop.Controls.Add(Me.tbConnectionName)
		Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlTop.Location = New System.Drawing.Point(0, 0)
		Me.pnlTop.Name = "pnlTop"
		Me.pnlTop.Padding = New System.Windows.Forms.Padding(6)
		Me.pnlTop.Size = New System.Drawing.Size(509, 68)
		Me.pnlTop.TabIndex = 10
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.label3.Location = New System.Drawing.Point(9, 39)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(47, 13)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Syntax"
		' 
		' cbSyntax
		' 
		Me.cbSyntax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbSyntax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbSyntax.FormattingEnabled = True
		Me.cbSyntax.Location = New System.Drawing.Point(120, 36)
		Me.cbSyntax.Name = "cbSyntax"
		Me.cbSyntax.Size = New System.Drawing.Size(378, 21)
		Me.cbSyntax.TabIndex = 4
		AddHandler Me.cbSyntax.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbSyntax_SelectedIndexChanged)
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.label2.Location = New System.Drawing.Point(9, 12)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(105, 13)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Connection Name"
		' 
		' tbConnectionName
		' 
		Me.tbConnectionName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tbConnectionName.Location = New System.Drawing.Point(120, 9)
		Me.tbConnectionName.Name = "tbConnectionName"
		Me.tbConnectionName.Size = New System.Drawing.Size(378, 20)
		Me.tbConnectionName.TabIndex = 0
		' 
		' btnOk
		' 
		Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnOk.Location = New System.Drawing.Point(338, 169)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(78, 23)
		Me.btnOk.TabIndex = 15
		Me.btnOk.Text = "OK"
		Me.btnOk.UseVisualStyleBackColor = True
		' 
		' btnCancel
		' 
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(421, 169)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(78, 23)
		Me.btnCancel.TabIndex = 16
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		' 
		' openDialog
		' 
		Me.openDialog.Filter = "XML files|*xml|All files|*.*"
		' 
		' pbSyntax
		' 
		Me.pbSyntax.AutoScroll = True
		Me.pbSyntax.Dock = System.Windows.Forms.DockStyle.Top
		Me.pbSyntax.InformationMessageHost = Nothing
		Me.pbSyntax.Location = New System.Drawing.Point(0, 68)
		Me.pbSyntax.Name = "pbSyntax"
		Me.pbSyntax.Size = New System.Drawing.Size(509, 50)
		Me.pbSyntax.TabIndex = 18
		' 
		' pnlFilePath
		' 
		Me.pnlFilePath.Controls.Add(Me.btnOpenDialog)
		Me.pnlFilePath.Controls.Add(Me.tbXmlPath)
		Me.pnlFilePath.Controls.Add(Me.label4)
		Me.pnlFilePath.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlFilePath.Location = New System.Drawing.Point(0, 118)
		Me.pnlFilePath.Name = "pnlFilePath"
		Me.pnlFilePath.Size = New System.Drawing.Size(509, 30)
		Me.pnlFilePath.TabIndex = 19
		' 
		' btnOpenDialog
		' 
		Me.btnOpenDialog.Location = New System.Drawing.Point(474, 5)
		Me.btnOpenDialog.Name = "btnOpenDialog"
		Me.btnOpenDialog.Size = New System.Drawing.Size(25, 22)
		Me.btnOpenDialog.TabIndex = 17
		Me.btnOpenDialog.Text = "..."
		Me.btnOpenDialog.UseVisualStyleBackColor = True
		AddHandler Me.btnOpenDialog.Click, New System.EventHandler(AddressOf Me.btnOpenDialog_Click)
		' 
		' tbXmlPath
		' 
		Me.tbXmlPath.Location = New System.Drawing.Point(121, 6)
		Me.tbXmlPath.Name = "tbXmlPath"
		Me.tbXmlPath.Size = New System.Drawing.Size(350, 20)
		Me.tbXmlPath.TabIndex = 16
		AddHandler Me.tbXmlPath.TextChanged, New System.EventHandler(AddressOf Me.tbXmlPath_TextChanged)
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(10, 9)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(72, 13)
		Me.label4.TabIndex = 15
		Me.label4.Text = "XML file path:"
		' 
		' EditXMLConnectionForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(509, 199)
		Me.Controls.Add(Me.pnlFilePath)
		Me.Controls.Add(Me.pbSyntax)
		Me.Controls.Add(Me.btnOk)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.pnlTop)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "EditXMLConnectionForm"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Edit XML Connection"
		Me.pnlTop.ResumeLayout(False)
		Me.pnlTop.PerformLayout()
		Me.pnlFilePath.ResumeLayout(False)
		Me.pnlFilePath.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private pnlTop As System.Windows.Forms.Panel
	Private label3 As System.Windows.Forms.Label
	Private cbSyntax As System.Windows.Forms.ComboBox
	Private label2 As System.Windows.Forms.Label
	Private tbConnectionName As System.Windows.Forms.TextBox
	Private btnOk As System.Windows.Forms.Button
	Private btnCancel As System.Windows.Forms.Button
	Private openDialog As System.Windows.Forms.OpenFileDialog
	Private pbSyntax As ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar
	Private pnlFilePath As System.Windows.Forms.Panel
	Private btnOpenDialog As System.Windows.Forms.Button
	Private tbXmlPath As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
End Class
