Namespace Common
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ErrorBox
        Inherits System.Windows.Forms.UserControl

        'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Является обязательной для конструктора форм Windows Forms
        Private components As System.ComponentModel.IContainer

        'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
        'Для ее изменения используйте конструктор форм Windows Form.  
        'Не изменяйте ее в редакторе исходного кода.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
        Me.labelMessage = New BasicDemo.Common.GrowLabel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.comboBoxSyntaxProvider = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.linkLabelGoTo = New System.Windows.Forms.LinkLabel()
        Me.linkLabelRevert = New System.Windows.Forms.LinkLabel()
        Me.panel1.SuspendLayout
        Me.SuspendLayout
        '
        'labelMessage
        '
        Me.labelMessage.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelMessage.Location = New System.Drawing.Point(5, 5)
        Me.labelMessage.Name = "labelMessage"
        Me.labelMessage.Size = New System.Drawing.Size(368, 13)
        Me.labelMessage.TabIndex = 1
        Me.labelMessage.Tag = ""
        Me.labelMessage.Text = "Some Text"
        '
        'panel1
        '
        Me.panel1.AutoSize = true
        Me.panel1.Controls.Add(Me.comboBoxSyntaxProvider)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(5, 18)
        Me.panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.panel1.Size = New System.Drawing.Size(368, 26)
        Me.panel1.TabIndex = 2
        '
        'comboBoxSyntaxProvider
        '
        Me.comboBoxSyntaxProvider.DisplayMember = "DisplayString"
        Me.comboBoxSyntaxProvider.Dock = System.Windows.Forms.DockStyle.Top
        Me.comboBoxSyntaxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxSyntaxProvider.FormattingEnabled = true
        Me.comboBoxSyntaxProvider.Location = New System.Drawing.Point(74, 5)
        Me.comboBoxSyntaxProvider.Margin = New System.Windows.Forms.Padding(0)
        Me.comboBoxSyntaxProvider.Name = "comboBoxSyntaxProvider"
        Me.comboBoxSyntaxProvider.Size = New System.Drawing.Size(294, 21)
        Me.comboBoxSyntaxProvider.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.label2.Location = New System.Drawing.Point(0, 5)
        Me.label2.Margin = New System.Windows.Forms.Padding(0)
        Me.label2.Name = "label2"
        Me.label2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.label2.Size = New System.Drawing.Size(74, 16)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Check syntax:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'linkLabelGoTo
        '
        Me.linkLabelGoTo.AutoSize = true
        Me.linkLabelGoTo.Dock = System.Windows.Forms.DockStyle.Top
        Me.linkLabelGoTo.Location = New System.Drawing.Point(5, 44)
        Me.linkLabelGoTo.Name = "linkLabelGoTo"
        Me.linkLabelGoTo.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.linkLabelGoTo.Size = New System.Drawing.Size(114, 23)
        Me.linkLabelGoTo.TabIndex = 3
        Me.linkLabelGoTo.TabStop = true
        Me.linkLabelGoTo.Text = "Go to the error position"
        '
        'linkLabelRevert
        '
        Me.linkLabelRevert.AutoSize = true
        Me.linkLabelRevert.Dock = System.Windows.Forms.DockStyle.Top
        Me.linkLabelRevert.Location = New System.Drawing.Point(5, 67)
        Me.linkLabelRevert.Name = "linkLabelRevert"
        Me.linkLabelRevert.Size = New System.Drawing.Size(198, 13)
        Me.linkLabelRevert.TabIndex = 4
        Me.linkLabelRevert.TabStop = true
        Me.linkLabelRevert.Text = "Get back to the previous valid query text"
        '
        'ErrorBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.BackColor = System.Drawing.Color.LightPink
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.linkLabelRevert)
        Me.Controls.Add(Me.linkLabelGoTo)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.labelMessage)
        Me.Name = "ErrorBox"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(378, 85)
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

        Private WithEvents labelMessage As GrowLabel
        Private WithEvents panel1 As System.Windows.Forms.Panel
        Private WithEvents comboBoxSyntaxProvider As System.Windows.Forms.ComboBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents linkLabelGoTo As System.Windows.Forms.LinkLabel
        Private WithEvents linkLabelRevert As System.Windows.Forms.LinkLabel
    End Class
End NameSpace
