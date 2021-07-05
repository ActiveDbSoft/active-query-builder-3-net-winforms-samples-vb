Namespace Common
	Partial Public Class SqlErrorBox
		
		Private components As System.ComponentModel.IContainer = Nothing

		
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		
		Private Sub InitializeComponent()
			Me.labelMessage = New GrowLabel()
			Me.panelCheckSyntax = New Panel()
			Me.comboBoxSyntaxProvider = New ComboBox()
			Me.label2 = New Label()
			Me.linkLabelGoTo = New LinkLabel()
			Me.linkLabelRevert = New LinkLabel()
			Me.panelCheckSyntax.SuspendLayout()
			Me.SuspendLayout()
			' 
			' labelMessage
			' 
			Me.labelMessage.Dock = DockStyle.Top
			Me.labelMessage.Location = New Point(5, 5)
			Me.labelMessage.Name = "labelMessage"
			Me.labelMessage.Size = New Size(344, 13)
			Me.labelMessage.TabIndex = 0
			Me.labelMessage.Tag = ""
			Me.labelMessage.Text = "Some Text"
			' 
			' panelCheckSyntax
			' 
			Me.panelCheckSyntax.AutoSize = True
			Me.panelCheckSyntax.Controls.Add(Me.comboBoxSyntaxProvider)
			Me.panelCheckSyntax.Controls.Add(Me.label2)
			Me.panelCheckSyntax.Dock = DockStyle.Top
			Me.panelCheckSyntax.Location = New Point(5, 18)
			Me.panelCheckSyntax.Margin = New Padding(0)
			Me.panelCheckSyntax.Name = "panelCheckSyntax"
			Me.panelCheckSyntax.Padding = New Padding(0, 5, 0, 0)
			Me.panelCheckSyntax.Size = New Size(344, 26)
			Me.panelCheckSyntax.TabIndex = 1
			Me.panelCheckSyntax.Visible = False
			' 
			' comboBoxSyntaxProvider
			' 
			Me.comboBoxSyntaxProvider.DisplayMember = "DisplayString"
			Me.comboBoxSyntaxProvider.Dock = DockStyle.Top
			Me.comboBoxSyntaxProvider.DropDownStyle = ComboBoxStyle.DropDownList
			Me.comboBoxSyntaxProvider.FormattingEnabled = True
			Me.comboBoxSyntaxProvider.Location = New Point(74, 5)
			Me.comboBoxSyntaxProvider.Margin = New Padding(0)
			Me.comboBoxSyntaxProvider.Name = "comboBoxSyntaxProvider"
			Me.comboBoxSyntaxProvider.Size = New Size(270, 21)
			Me.comboBoxSyntaxProvider.TabIndex = 1
'			Me.comboBoxSyntaxProvider.SelectedValueChanged += New System.EventHandler(Me.comboBoxSyntaxProvider_SelectedValueChanged)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Dock = DockStyle.Left
			Me.label2.Location = New Point(0, 5)
			Me.label2.Margin = New Padding(0)
			Me.label2.Name = "label2"
			Me.label2.Padding = New Padding(0, 3, 0, 0)
			Me.label2.Size = New Size(74, 16)
			Me.label2.TabIndex = 0
			Me.label2.Text = "Check syntax:"
			Me.label2.TextAlign = ContentAlignment.MiddleLeft
			' 
			' linkLabelGoTo
			' 
			Me.linkLabelGoTo.AutoSize = True
			Me.linkLabelGoTo.Dock = DockStyle.Top
			Me.linkLabelGoTo.Location = New Point(5, 44)
			Me.linkLabelGoTo.Name = "linkLabelGoTo"
			Me.linkLabelGoTo.Padding = New Padding(0, 5, 0, 5)
			Me.linkLabelGoTo.Size = New Size(114, 23)
			Me.linkLabelGoTo.TabIndex = 2
			Me.linkLabelGoTo.TabStop = True
			Me.linkLabelGoTo.Text = "Go to the error position"
'			Me.linkLabelGoTo.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkLabelGoTo_LinkClicked)
			' 
			' linkLabelRevert
			' 
			Me.linkLabelRevert.AutoSize = True
			Me.linkLabelRevert.Dock = DockStyle.Top
			Me.linkLabelRevert.Location = New Point(5, 67)
			Me.linkLabelRevert.Name = "linkLabelRevert"
			Me.linkLabelRevert.Size = New Size(198, 13)
			Me.linkLabelRevert.TabIndex = 2
			Me.linkLabelRevert.TabStop = True
			Me.linkLabelRevert.Text = "Get back to the previous valid query text"
'			Me.linkLabelRevert.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkLabelRevert_LinkClicked)
			' 
			' ErrorBox
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoSize = True
			Me.BackColor = Color.LightPink
			Me.BorderStyle = BorderStyle.FixedSingle
			Me.Controls.Add(Me.linkLabelRevert)
			Me.Controls.Add(Me.linkLabelGoTo)
			Me.Controls.Add(Me.panelCheckSyntax)
			Me.Controls.Add(Me.labelMessage)
			Me.Name = "ErrorBox"
			Me.Padding = New Padding(5)
			Me.Size = New Size(354, 87)
			Me.panelCheckSyntax.ResumeLayout(False)
			Me.panelCheckSyntax.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		Private labelMessage As GrowLabel
		Private panelCheckSyntax As Panel
		Private WithEvents comboBoxSyntaxProvider As ComboBox
		Private label2 As Label
		Private WithEvents linkLabelGoTo As LinkLabel
		Private WithEvents linkLabelRevert As LinkLabel
	End Class
End Namespace
