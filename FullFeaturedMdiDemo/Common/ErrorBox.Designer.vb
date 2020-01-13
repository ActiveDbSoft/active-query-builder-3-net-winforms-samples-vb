Namespace Common
    Friend Partial Class ErrorBox
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.labelMessage = New GrowLabel()
            Me.panelCheckSyntax = New System.Windows.Forms.Panel()
            Me.comboBoxSyntaxProvider = New System.Windows.Forms.ComboBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.linkLabelGoTo = New System.Windows.Forms.LinkLabel()
            Me.linkLabelRevert = New System.Windows.Forms.LinkLabel()
            Me.panelCheckSyntax.SuspendLayout()
            Me.SuspendLayout()
            Me.labelMessage.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelMessage.Location = New System.Drawing.Point(5, 5)
            Me.labelMessage.Name = "labelMessage"
            Me.labelMessage.Size = New System.Drawing.Size(344, 13)
            Me.labelMessage.TabIndex = 0
            Me.labelMessage.Tag = ""
            Me.labelMessage.Text = "Some Text"
            Me.panelCheckSyntax.AutoSize = True
            Me.panelCheckSyntax.Controls.Add(Me.comboBoxSyntaxProvider)
            Me.panelCheckSyntax.Controls.Add(Me.label2)
            Me.panelCheckSyntax.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelCheckSyntax.Location = New System.Drawing.Point(5, 18)
            Me.panelCheckSyntax.Margin = New System.Windows.Forms.Padding(0)
            Me.panelCheckSyntax.Name = "panelCheckSyntax"
            Me.panelCheckSyntax.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.panelCheckSyntax.Size = New System.Drawing.Size(344, 26)
            Me.panelCheckSyntax.TabIndex = 1
            Me.panelCheckSyntax.Visible = False
            Me.comboBoxSyntaxProvider.DisplayMember = "DisplayString"
            Me.comboBoxSyntaxProvider.Dock = System.Windows.Forms.DockStyle.Top
            Me.comboBoxSyntaxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxSyntaxProvider.FormattingEnabled = True
            Me.comboBoxSyntaxProvider.Location = New System.Drawing.Point(74, 5)
            Me.comboBoxSyntaxProvider.Margin = New System.Windows.Forms.Padding(0)
            Me.comboBoxSyntaxProvider.Name = "comboBoxSyntaxProvider"
            Me.comboBoxSyntaxProvider.Size = New System.Drawing.Size(270, 21)
            Me.comboBoxSyntaxProvider.TabIndex = 1
            AddHandler Me.comboBoxSyntaxProvider.SelectedValueChanged, New System.EventHandler(AddressOf Me.comboBoxSyntaxProvider_SelectedValueChanged)
            Me.label2.AutoSize = True
            Me.label2.Dock = System.Windows.Forms.DockStyle.Left
            Me.label2.Location = New System.Drawing.Point(0, 5)
            Me.label2.Margin = New System.Windows.Forms.Padding(0)
            Me.label2.Name = "label2"
            Me.label2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
            Me.label2.Size = New System.Drawing.Size(74, 16)
            Me.label2.TabIndex = 0
            Me.label2.Text = "Check syntax:"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.linkLabelGoTo.AutoSize = True
            Me.linkLabelGoTo.Dock = System.Windows.Forms.DockStyle.Top
            Me.linkLabelGoTo.Location = New System.Drawing.Point(5, 44)
            Me.linkLabelGoTo.Name = "linkLabelGoTo"
            Me.linkLabelGoTo.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.linkLabelGoTo.Size = New System.Drawing.Size(114, 23)
            Me.linkLabelGoTo.TabIndex = 2
            Me.linkLabelGoTo.TabStop = True
            Me.linkLabelGoTo.Text = "Go to the error position"
            AddHandler Me.linkLabelGoTo.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.linkLabelGoTo_LinkClicked)
            Me.linkLabelRevert.AutoSize = True
            Me.linkLabelRevert.Dock = System.Windows.Forms.DockStyle.Top
            Me.linkLabelRevert.Location = New System.Drawing.Point(5, 67)
            Me.linkLabelRevert.Name = "linkLabelRevert"
            Me.linkLabelRevert.Size = New System.Drawing.Size(198, 13)
            Me.linkLabelRevert.TabIndex = 2
            Me.linkLabelRevert.TabStop = True
            Me.linkLabelRevert.Text = "Get back to the previous valid query text"
            AddHandler Me.linkLabelRevert.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf Me.linkLabelRevert_LinkClicked)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSize = True
            Me.BackColor = System.Drawing.Color.LightPink
            Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Controls.Add(Me.linkLabelRevert)
            Me.Controls.Add(Me.linkLabelGoTo)
            Me.Controls.Add(Me.panelCheckSyntax)
            Me.Controls.Add(Me.labelMessage)
            Me.Name = "ErrorBox"
            Me.Padding = New System.Windows.Forms.Padding(5)
            Me.Size = New System.Drawing.Size(354, 87)
            Me.panelCheckSyntax.ResumeLayout(False)
            Me.panelCheckSyntax.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private labelMessage As GrowLabel
        Private panelCheckSyntax As System.Windows.Forms.Panel
        Private comboBoxSyntaxProvider As System.Windows.Forms.ComboBox
        Private label2 As System.Windows.Forms.Label
        Private linkLabelGoTo As System.Windows.Forms.LinkLabel
        Private linkLabelRevert As System.Windows.Forms.LinkLabel
    End Class
End Namespace
