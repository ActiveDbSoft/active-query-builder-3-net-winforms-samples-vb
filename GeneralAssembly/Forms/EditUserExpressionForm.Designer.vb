
	Partial Public Class EditUserExpressionForm
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
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxExpression = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TextBoxCaption = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.CheckComboBoxDbTypes = New Common.CheckComboBox()
        Me.CheckBoxIsNeedEdit = New System.Windows.Forms.CheckBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.ButtonClearForm = New System.Windows.Forms.Button()
        Me.ButtonAddExpression = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBoxExpressions = New System.Windows.Forms.ListBox()
        Me.ButtonRemoveExpression = New System.Windows.Forms.Button()
        Me.ButtonEditExpression = New System.Windows.Forms.Button()
        Me.tableLayoutPanel1.SuspendLayout
        Me.panel1.SuspendLayout
        Me.groupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.Controls.Add(Me.TextBoxExpression, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.TextBoxCaption, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.label2, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.label4, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.CheckComboBoxDbTypes, 1, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.CheckBoxIsNeedEdit, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 1, 4)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 5
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(503, 133)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'TextBoxExpression
        '
        Me.TextBoxExpression.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxExpression.Location = New System.Drawing.Point(80, 29)
        Me.TextBoxExpression.Name = "TextBoxExpression"
        Me.TextBoxExpression.Size = New System.Drawing.Size(420, 20)
        Me.TextBoxExpression.TabIndex = 4
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label1.Location = New System.Drawing.Point(3, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(71, 26)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Caption"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxCaption
        '
        Me.TextBoxCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxCaption.Location = New System.Drawing.Point(80, 3)
        Me.TextBoxCaption.Name = "TextBoxCaption"
        Me.TextBoxCaption.Size = New System.Drawing.Size(420, 20)
        Me.TextBoxCaption.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label2.Location = New System.Drawing.Point(3, 26)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(71, 26)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Expression"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label4.Location = New System.Drawing.Point(3, 75)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(71, 27)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Show only for"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckComboBoxDbTypes
        '
        Me.CheckComboBoxDbTypes.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckComboBoxDbTypes.DropDownHeight = 1
        Me.CheckComboBoxDbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CheckComboBoxDbTypes.DropDownWidth = 1
        Me.CheckComboBoxDbTypes.FormattingEnabled = true
        Me.CheckComboBoxDbTypes.IntegralHeight = false
        Me.CheckComboBoxDbTypes.Location = New System.Drawing.Point(80, 78)
        Me.CheckComboBoxDbTypes.Name = "CheckComboBoxDbTypes"
        Me.CheckComboBoxDbTypes.Size = New System.Drawing.Size(420, 21)
        Me.CheckComboBoxDbTypes.TabIndex = 5
        Me.CheckComboBoxDbTypes.Text = Nothing
        '
        'CheckBoxIsNeedEdit
        '
        Me.CheckBoxIsNeedEdit.AutoSize = true
        Me.tableLayoutPanel1.SetColumnSpan(Me.CheckBoxIsNeedEdit, 2)
        Me.CheckBoxIsNeedEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxIsNeedEdit.Location = New System.Drawing.Point(3, 55)
        Me.CheckBoxIsNeedEdit.Name = "CheckBoxIsNeedEdit"
        Me.CheckBoxIsNeedEdit.Size = New System.Drawing.Size(497, 17)
        Me.CheckBoxIsNeedEdit.TabIndex = 6
        Me.CheckBoxIsNeedEdit.Text = "Is need edit cell after inserting"
        Me.CheckBoxIsNeedEdit.UseVisualStyleBackColor = true
        '
        'panel1
        '
        Me.panel1.AutoSize = true
        Me.panel1.Controls.Add(Me.ButtonClearForm)
        Me.panel1.Controls.Add(Me.ButtonAddExpression)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(77, 102)
        Me.panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(426, 31)
        Me.panel1.TabIndex = 7
        '
        'ButtonClearForm
        '
        Me.ButtonClearForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonClearForm.Location = New System.Drawing.Point(267, 3)
        Me.ButtonClearForm.Name = "ButtonClearForm"
        Me.ButtonClearForm.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClearForm.TabIndex = 0
        Me.ButtonClearForm.Text = "Clear"
        Me.ButtonClearForm.UseVisualStyleBackColor = true
        '
        'ButtonAddExpression
        '
        Me.ButtonAddExpression.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonAddExpression.Location = New System.Drawing.Point(348, 3)
        Me.ButtonAddExpression.Name = "ButtonAddExpression"
        Me.ButtonAddExpression.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddExpression.TabIndex = 0
        Me.ButtonAddExpression.Text = "Add"
        Me.ButtonAddExpression.UseVisualStyleBackColor = true
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.tableLayoutPanel1)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupBox1.Location = New System.Drawing.Point(5, 5)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(509, 152)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = false
        '
        'ListBoxExpressions
        '
        Me.ListBoxExpressions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ListBoxExpressions.FormattingEnabled = true
        Me.ListBoxExpressions.Location = New System.Drawing.Point(5, 163)
        Me.ListBoxExpressions.Name = "ListBoxExpressions"
        Me.ListBoxExpressions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBoxExpressions.Size = New System.Drawing.Size(506, 290)
        Me.ListBoxExpressions.TabIndex = 2
        '
        'ButtonRemoveExpression
        '
        Me.ButtonRemoveExpression.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonRemoveExpression.Location = New System.Drawing.Point(332, 458)
        Me.ButtonRemoveExpression.Name = "ButtonRemoveExpression"
        Me.ButtonRemoveExpression.Size = New System.Drawing.Size(180, 23)
        Me.ButtonRemoveExpression.TabIndex = 3
        Me.ButtonRemoveExpression.Text = "Remove selected expressions"
        Me.ButtonRemoveExpression.UseVisualStyleBackColor = true
        '
        'ButtonEditExpression
        '
        Me.ButtonEditExpression.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonEditExpression.Location = New System.Drawing.Point(146, 457)
        Me.ButtonEditExpression.Name = "ButtonEditExpression"
        Me.ButtonEditExpression.Size = New System.Drawing.Size(180, 23)
        Me.ButtonEditExpression.TabIndex = 3
        Me.ButtonEditExpression.Text = "Edit selected expression"
        Me.ButtonEditExpression.UseVisualStyleBackColor = true
        '
        'EditUserExpressionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 488)
        Me.Controls.Add(Me.ButtonEditExpression)
        Me.Controls.Add(Me.ButtonRemoveExpression)
        Me.Controls.Add(Me.ListBoxExpressions)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "EditUserExpressionForm"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Edit User Expression"
        Me.tableLayoutPanel1.ResumeLayout(false)
        Me.tableLayoutPanel1.PerformLayout
        Me.panel1.ResumeLayout(false)
        Me.groupBox1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

		#End Region

		Private tableLayoutPanel1 As TableLayoutPanel
		Private TextBoxExpression As TextBox
		Private label1 As Label
		Private TextBoxCaption As TextBox
		Private label2 As Label
		Private label4 As Label
		Private CheckComboBoxDbTypes As Common.CheckComboBox
		Private CheckBoxIsNeedEdit As CheckBox
		Private panel1 As Panel
		Private WithEvents ButtonClearForm As Button
		Private WithEvents ButtonAddExpression As Button
		Private groupBox1 As GroupBox
		Private ListBoxExpressions As ListBox
		Private WithEvents ButtonRemoveExpression As Button
		Private WithEvents ButtonEditExpression As Button
	End Class
