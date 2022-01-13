Namespace Forms
    Partial Public Class EditUserPredefinedConditionForm
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
            Me.ListBoxConditions = New System.Windows.Forms.ListBox()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.ButtonRevert = New System.Windows.Forms.Button()
            Me.buttonSave = New System.Windows.Forms.Button()
            Me.TextBoxExpression = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.TextBoxCaption = New System.Windows.Forms.TextBox()
            Me.CheckBoxIsNeedEdit = New System.Windows.Forms.CheckBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.CheckComboBoxDbTypes = New Common.CheckComboBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.LabelInformationSave = New System.Windows.Forms.Label()
            Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.buttonAdd = New System.Windows.Forms.Button()
            Me.buttonCopy = New System.Windows.Forms.Button()
            Me.buttonDelete = New System.Windows.Forms.Button()
            Me.buttonMoveUp = New System.Windows.Forms.Button()
            Me.buttonMoveDown = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.flowLayoutPanel1.SuspendLayout()
            Me.SuspendLayout
            '
            'ListBoxConditions
            '
            Me.ListBoxConditions.Dock = System.Windows.Forms.DockStyle.Left
            Me.ListBoxConditions.FormattingEnabled = True
            Me.ListBoxConditions.Location = New System.Drawing.Point(5, 5)
            Me.ListBoxConditions.Name = "ListBoxConditions"
            Me.ListBoxConditions.Size = New System.Drawing.Size(276, 423)
            Me.ListBoxConditions.TabIndex = 2
            '
            'tableLayoutPanel1
            '
            Me.tableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tableLayoutPanel1.AutoSize = True
            Me.tableLayoutPanel1.ColumnCount = 2
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel1.Controls.Add(Me.Panel1, 1, 4)
            Me.tableLayoutPanel1.Controls.Add(Me.TextBoxExpression, 1, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.label1, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.TextBoxCaption, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.CheckBoxIsNeedEdit, 1, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.label4, 0, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.CheckComboBoxDbTypes, 1, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.label2, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.LabelInformationSave, 0, 5)
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(312, 8)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 6
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(579, 221)
            Me.tableLayoutPanel1.TabIndex = 0
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.ButtonRevert)
            Me.Panel1.Controls.Add(Me.buttonSave)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(82, 165)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(494, 27)
            Me.Panel1.TabIndex = 7
            '
            'ButtonRevert
            '
            Me.ButtonRevert.Dock = System.Windows.Forms.DockStyle.Left
            Me.ButtonRevert.Enabled = False
            Me.ButtonRevert.Location = New System.Drawing.Point(98, 0)
            Me.ButtonRevert.Name = "ButtonRevert"
            Me.ButtonRevert.Size = New System.Drawing.Size(101, 27)
            Me.ButtonRevert.TabIndex = 6
            Me.ButtonRevert.Text = "Revert"
            Me.ButtonRevert.UseVisualStyleBackColor = True
            '
            'buttonSave
            '
            Me.buttonSave.Dock = System.Windows.Forms.DockStyle.Left
            Me.buttonSave.Enabled = False
            Me.buttonSave.Location = New System.Drawing.Point(0, 0)
            Me.buttonSave.Name = "buttonSave"
            Me.buttonSave.Size = New System.Drawing.Size(98, 27)
            Me.buttonSave.TabIndex = 0
            Me.buttonSave.Text = "Save"
            Me.buttonSave.UseVisualStyleBackColor = True
            '
            'TextBoxExpression
            '
            Me.TextBoxExpression.Dock = System.Windows.Forms.DockStyle.Top
            Me.TextBoxExpression.Location = New System.Drawing.Point(82, 29)
            Me.TextBoxExpression.Multiline = True
            Me.TextBoxExpression.Name = "TextBoxExpression"
            Me.TextBoxExpression.Size = New System.Drawing.Size(494, 80)
            Me.TextBoxExpression.TabIndex = 4
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label1.Location = New System.Drawing.Point(3, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(73, 26)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Caption"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TextBoxCaption
            '
            Me.TextBoxCaption.Dock = System.Windows.Forms.DockStyle.Top
            Me.TextBoxCaption.Location = New System.Drawing.Point(82, 3)
            Me.TextBoxCaption.Name = "TextBoxCaption"
            Me.TextBoxCaption.Size = New System.Drawing.Size(494, 20)
            Me.TextBoxCaption.TabIndex = 1
            '
            'CheckBoxIsNeedEdit
            '
            Me.CheckBoxIsNeedEdit.AutoSize = True
            Me.CheckBoxIsNeedEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CheckBoxIsNeedEdit.Location = New System.Drawing.Point(82, 115)
            Me.CheckBoxIsNeedEdit.Name = "CheckBoxIsNeedEdit"
            Me.CheckBoxIsNeedEdit.Size = New System.Drawing.Size(494, 17)
            Me.CheckBoxIsNeedEdit.TabIndex = 6
            Me.CheckBoxIsNeedEdit.Text = "Move focus to the newly added expression in the Query Columns grid for editing"
            Me.CheckBoxIsNeedEdit.UseVisualStyleBackColor = True
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label4.Location = New System.Drawing.Point(3, 135)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(73, 27)
            Me.label4.TabIndex = 3
            Me.label4.Text = "Apply to types"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'CheckComboBoxDbTypes
            '
            Me.CheckComboBoxDbTypes.Dock = System.Windows.Forms.DockStyle.Top
            Me.CheckComboBoxDbTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.CheckComboBoxDbTypes.DropDownHeight = 1
            Me.CheckComboBoxDbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CheckComboBoxDbTypes.DropDownWidth = 1
            Me.CheckComboBoxDbTypes.FormattingEnabled = True
            Me.CheckComboBoxDbTypes.IntegralHeight = False
            Me.CheckComboBoxDbTypes.Location = New System.Drawing.Point(82, 138)
            Me.CheckComboBoxDbTypes.Name = "CheckComboBoxDbTypes"
            Me.CheckComboBoxDbTypes.Size = New System.Drawing.Size(494, 21)
            Me.CheckComboBoxDbTypes.TabIndex = 5
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(3, 31)
            Me.label2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(51, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Condition"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LabelInformationSave
            '
            Me.LabelInformationSave.AutoSize = True
            Me.tableLayoutPanel1.SetColumnSpan(Me.LabelInformationSave, 2)
            Me.LabelInformationSave.Dock = System.Windows.Forms.DockStyle.Top
            Me.LabelInformationSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.LabelInformationSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.LabelInformationSave.Location = New System.Drawing.Point(3, 198)
            Me.LabelInformationSave.Margin = New System.Windows.Forms.Padding(3)
            Me.LabelInformationSave.Name = "LabelInformationSave"
            Me.LabelInformationSave.Size = New System.Drawing.Size(573, 13)
            Me.LabelInformationSave.TabIndex = 7
            Me.LabelInformationSave.Text = "Changes will not be saved unless you click the Save button."
            Me.LabelInformationSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.LabelInformationSave.Visible = False
            '
            'flowLayoutPanel1
            '
            Me.flowLayoutPanel1.AutoSize = True
            Me.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
            Me.flowLayoutPanel1.Controls.Add(Me.buttonAdd)
            Me.flowLayoutPanel1.Controls.Add(Me.buttonCopy)
            Me.flowLayoutPanel1.Controls.Add(Me.buttonDelete)
            Me.flowLayoutPanel1.Controls.Add(Me.buttonMoveUp)
            Me.flowLayoutPanel1.Controls.Add(Me.buttonMoveDown)
            Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.flowLayoutPanel1.Location = New System.Drawing.Point(281, 5)
            Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
            Me.flowLayoutPanel1.Size = New System.Drawing.Size(28, 423)
            Me.flowLayoutPanel1.TabIndex = 5
            '
            'buttonAdd
            '
            Me.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.buttonAdd.AutoSize = True
            Me.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.buttonAdd.Image = Global.GeneralAssembly.My.Resources.Resources.add
            Me.buttonAdd.Location = New System.Drawing.Point(3, 3)
            Me.buttonAdd.Name = "buttonAdd"
            Me.buttonAdd.Size = New System.Drawing.Size(22, 22)
            Me.buttonAdd.TabIndex = 0
            Me.buttonAdd.UseVisualStyleBackColor = True
            '
            'buttonCopy
            '
            Me.buttonCopy.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.buttonCopy.AutoSize = True
            Me.buttonCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.buttonCopy.Enabled = False
            Me.buttonCopy.Image = Global.GeneralAssembly.My.Resources.Resources.copy
            Me.buttonCopy.Location = New System.Drawing.Point(3, 31)
            Me.buttonCopy.Name = "buttonCopy"
            Me.buttonCopy.Size = New System.Drawing.Size(22, 22)
            Me.buttonCopy.TabIndex = 1
            Me.buttonCopy.UseVisualStyleBackColor = True
            '
            'buttonDelete
            '
            Me.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.buttonDelete.AutoSize = True
            Me.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.buttonDelete.Enabled = False
            Me.buttonDelete.Image = Global.GeneralAssembly.My.Resources.Resources.delete
            Me.buttonDelete.Location = New System.Drawing.Point(3, 59)
            Me.buttonDelete.Name = "buttonDelete"
            Me.buttonDelete.Size = New System.Drawing.Size(22, 22)
            Me.buttonDelete.TabIndex = 2
            Me.buttonDelete.UseVisualStyleBackColor = True
            '
            'buttonMoveUp
            '
            Me.buttonMoveUp.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.buttonMoveUp.AutoSize = True
            Me.buttonMoveUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.buttonMoveUp.Enabled = False
            Me.buttonMoveUp.Image = Global.GeneralAssembly.My.Resources.Resources.arrowUp
            Me.buttonMoveUp.Location = New System.Drawing.Point(4, 87)
            Me.buttonMoveUp.Name = "buttonMoveUp"
            Me.buttonMoveUp.Size = New System.Drawing.Size(20, 22)
            Me.buttonMoveUp.TabIndex = 3
            Me.buttonMoveUp.UseVisualStyleBackColor = True
            '
            'buttonMoveDown
            '
            Me.buttonMoveDown.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.buttonMoveDown.AutoSize = True
            Me.buttonMoveDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.buttonMoveDown.Enabled = False
            Me.buttonMoveDown.Image = Global.GeneralAssembly.My.Resources.Resources.arrowDown
            Me.buttonMoveDown.Location = New System.Drawing.Point(4, 115)
            Me.buttonMoveDown.Name = "buttonMoveDown"
            Me.buttonMoveDown.Size = New System.Drawing.Size(20, 22)
            Me.buttonMoveDown.TabIndex = 4
            Me.buttonMoveDown.UseVisualStyleBackColor = True
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(787, 402)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(101, 23)
            Me.button1.TabIndex = 6
            Me.button1.Text = "OK"
            Me.button1.UseVisualStyleBackColor = True
            '
            'EditUserPredefinedConditionForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(899, 433)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Controls.Add(Me.flowLayoutPanel1)
            Me.Controls.Add(Me.ListBoxConditions)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.Name = "EditUserPredefinedConditionForm"
            Me.Padding = New System.Windows.Forms.Padding(5)
            Me.ShowInTaskbar = False
            Me.Text = "Edit Predefined Conditions"
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.flowLayoutPanel1.ResumeLayout(False)
            Me.flowLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout

        End Sub

#End Region
        Private WithEvents ListBoxConditions As System.Windows.Forms.ListBox
        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Private WithEvents TextBoxExpression As System.Windows.Forms.TextBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents TextBoxCaption As System.Windows.Forms.TextBox
        Private label2 As System.Windows.Forms.Label
        Private WithEvents CheckBoxIsNeedEdit As System.Windows.Forms.CheckBox
        Private label4 As System.Windows.Forms.Label
        Private WithEvents CheckComboBoxDbTypes As Common.CheckComboBox
        Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Private WithEvents buttonAdd As System.Windows.Forms.Button
        Private WithEvents buttonCopy As System.Windows.Forms.Button
        Private WithEvents buttonDelete As System.Windows.Forms.Button
        Private WithEvents buttonMoveUp As System.Windows.Forms.Button
        Private WithEvents buttonMoveDown As System.Windows.Forms.Button
        Private WithEvents buttonSave As System.Windows.Forms.Button
        Private WithEvents button1 As System.Windows.Forms.Button
        Friend WithEvents LabelInformationSave As Label
        Private WithEvents ButtonRevert As Button
        Friend WithEvents Panel1 As Panel
    End Class
End Namespace
