Namespace OptionsControls
	Partial Public Class ExpressionsTab
		Private components As System.ComponentModel.IContainer = Nothing

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region ""

		Private Sub InitializeComponent()
			Me.groupBox1 = New GroupBox()
			Me.UpDownIndentForNestedConditions = New NumericUpDown()
			Me.radButEndLines = New RadioButton()
			Me.radButStartLines = New RadioButton()
			Me.label3 = New Label()
			Me.label2 = New Label()
			Me.label1 = New Label()
			Me.chBxStartAllLogicExprFromNewLines = New CheckBox()
			Me.chBxUpperLvlLogicExprFromNewLines = New CheckBox()
			Me.groupBox2 = New GroupBox()
			Me.UpDownExprsIndent = New NumericUpDown()
			Me.UpDownBranchKeyWrdsIndent = New NumericUpDown()
			Me.label5 = New Label()
			Me.label4 = New Label()
			Me.chBxBranchResultExprsFromNewLines = New CheckBox()
			Me.chBxResultKwrdsFromNewLinesThen = New CheckBox()
			Me.chBxBranchConditionExprFromNewLines = New CheckBox()
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen = New CheckBox()
			Me.groupBox1.SuspendLayout()
			CType(Me.UpDownIndentForNestedConditions, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox2.SuspendLayout()
			CType(Me.UpDownExprsIndent, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.UpDownBranchKeyWrdsIndent, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.groupBox1.Controls.Add(Me.UpDownIndentForNestedConditions)
			Me.groupBox1.Controls.Add(Me.radButEndLines)
			Me.groupBox1.Controls.Add(Me.radButStartLines)
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.chBxStartAllLogicExprFromNewLines)
			Me.groupBox1.Controls.Add(Me.chBxUpperLvlLogicExprFromNewLines)
			Me.groupBox1.Location = New Point(3, 3)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New Size(586, 134)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Logical expressions"
			' 
			' UpDownIndentForNestedConditions
			' 
			Me.UpDownIndentForNestedConditions.Location = New Point(194, 97)
			Me.UpDownIndentForNestedConditions.Name = "UpDownIndentForNestedConditions"
			Me.UpDownIndentForNestedConditions.Size = New Size(85, 20)
			Me.UpDownIndentForNestedConditions.TabIndex = 7
			Me.UpDownIndentForNestedConditions.TextAlign = HorizontalAlignment.Right
'			Me.UpDownIndentForNestedConditions.ValueChanged += New System.EventHandler(Me.UpDownIndentForNestedConditions_ValueChanged)
			' 
			' radButEndLines
			' 
			Me.radButEndLines.AutoSize = True
			Me.radButEndLines.Checked = True
			Me.radButEndLines.Location = New Point(241, 69)
			Me.radButEndLines.Name = "radButEndLines"
			Me.radButEndLines.Size = New Size(67, 17)
			Me.radButEndLines.TabIndex = 6
			Me.radButEndLines.TabStop = True
			Me.radButEndLines.Text = "end lines"
			Me.radButEndLines.UseVisualStyleBackColor = True
'			Me.radButEndLines.CheckedChanged += New System.EventHandler(Me.radButEndLines_CheckedChanged)
			' 
			' radButStartLines
			' 
			Me.radButStartLines.AutoSize = True
			Me.radButStartLines.Location = New Point(131, 69)
			Me.radButStartLines.Name = "radButStartLines"
			Me.radButStartLines.Size = New Size(69, 17)
			Me.radButStartLines.TabIndex = 5
			Me.radButStartLines.TabStop = True
			Me.radButStartLines.Text = "start lines"
			Me.radButStartLines.UseVisualStyleBackColor = True
'			Me.radButStartLines.CheckedChanged += New System.EventHandler(Me.radButStartLines_CheckedChanged)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Dock = DockStyle.Right
			Me.label3.Location = New Point(388, 16)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(195, 39)
			Me.label3.TabIndex = 4
			Me.label3.Text = "Layout of logical expressions in " & vbCrLf & "WHERE and HAVING clauses and join " & vbCrLf & "conditions" & " in the FROM part."
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New Point(6, 104)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(141, 13)
			Me.label2.TabIndex = 3
			Me.label2.Text = "Indent for nested conditions:"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New Point(6, 71)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(91, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Logical operators:"
			' 
			' chBxStartAllLogicExprFromNewLines
			' 
			Me.chBxStartAllLogicExprFromNewLines.AutoSize = True
			Me.chBxStartAllLogicExprFromNewLines.Location = New Point(6, 42)
			Me.chBxStartAllLogicExprFromNewLines.Name = "chBxStartAllLogicExprFromNewLines"
			Me.chBxStartAllLogicExprFromNewLines.Size = New Size(222, 17)
			Me.chBxStartAllLogicExprFromNewLines.TabIndex = 1
			Me.chBxStartAllLogicExprFromNewLines.Text = "Start all logical expressions from new lines"
			Me.chBxStartAllLogicExprFromNewLines.UseVisualStyleBackColor = True
'			Me.chBxStartAllLogicExprFromNewLines.CheckedChanged += New System.EventHandler(Me.chBxStartAllLogicExprFromNewLines_CheckedChanged)
			' 
			' chBxUpperLvlLogicExprFromNewLines
			' 
			Me.chBxUpperLvlLogicExprFromNewLines.AutoSize = True
			Me.chBxUpperLvlLogicExprFromNewLines.Checked = True
			Me.chBxUpperLvlLogicExprFromNewLines.CheckState = CheckState.Checked
			Me.chBxUpperLvlLogicExprFromNewLines.Location = New Point(6, 19)
			Me.chBxUpperLvlLogicExprFromNewLines.Name = "chBxUpperLvlLogicExprFromNewLines"
			Me.chBxUpperLvlLogicExprFromNewLines.Size = New Size(282, 17)
			Me.chBxUpperLvlLogicExprFromNewLines.TabIndex = 0
			Me.chBxUpperLvlLogicExprFromNewLines.Text = "Start the upper-level logical expressions from new lines"
			Me.chBxUpperLvlLogicExprFromNewLines.UseVisualStyleBackColor = True
'			Me.chBxUpperLvlLogicExprFromNewLines.CheckedChanged += New System.EventHandler(Me.chBxUpperLvlLogicExprFromNewLines_CheckedChanged)
			' 
			' groupBox2
			' 
			Me.groupBox2.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.groupBox2.Controls.Add(Me.UpDownExprsIndent)
			Me.groupBox2.Controls.Add(Me.UpDownBranchKeyWrdsIndent)
			Me.groupBox2.Controls.Add(Me.label5)
			Me.groupBox2.Controls.Add(Me.label4)
			Me.groupBox2.Controls.Add(Me.chBxBranchResultExprsFromNewLines)
			Me.groupBox2.Controls.Add(Me.chBxResultKwrdsFromNewLinesThen)
			Me.groupBox2.Controls.Add(Me.chBxBranchConditionExprFromNewLines)
			Me.groupBox2.Controls.Add(Me.chBxBranchConditionKeyWrdsFromNewLinesWhen)
			Me.groupBox2.Location = New Point(3, 143)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New Size(583, 172)
			Me.groupBox2.TabIndex = 1
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Conditional operators (IF, CASE)"
			' 
			' UpDownExprsIndent
			' 
			Me.UpDownExprsIndent.Location = New Point(156, 142)
			Me.UpDownExprsIndent.Name = "UpDownExprsIndent"
			Me.UpDownExprsIndent.Size = New Size(87, 20)
			Me.UpDownExprsIndent.TabIndex = 7
			Me.UpDownExprsIndent.TextAlign = HorizontalAlignment.Right
'			Me.UpDownExprsIndent.ValueChanged += New System.EventHandler(Me.UpDownExprsIndent_ValueChanged)
			' 
			' UpDownBranchKeyWrdsIndent
			' 
			Me.UpDownBranchKeyWrdsIndent.Location = New Point(156, 116)
			Me.UpDownBranchKeyWrdsIndent.Name = "UpDownBranchKeyWrdsIndent"
			Me.UpDownBranchKeyWrdsIndent.Size = New Size(87, 20)
			Me.UpDownBranchKeyWrdsIndent.TabIndex = 6
			Me.UpDownBranchKeyWrdsIndent.TextAlign = HorizontalAlignment.Right
'			Me.UpDownBranchKeyWrdsIndent.ValueChanged += New System.EventHandler(Me.UpDownBranchKeyWrdsIndent_ValueChanged)
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New Point(6, 148)
			Me.label5.Name = "label5"
			Me.label5.Size = New Size(98, 13)
			Me.label5.TabIndex = 5
			Me.label5.Text = "Expressions indent:"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New Point(6, 123)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(126, 13)
			Me.label4.TabIndex = 4
			Me.label4.Text = "Branch Keywords Indent:"
			' 
			' chBxBranchResultExprsFromNewLines
			' 
			Me.chBxBranchResultExprsFromNewLines.AutoSize = True
			Me.chBxBranchResultExprsFromNewLines.Location = New Point(9, 88)
			Me.chBxBranchResultExprsFromNewLines.Name = "chBxBranchResultExprsFromNewLines"
			Me.chBxBranchResultExprsFromNewLines.Size = New Size(216, 17)
			Me.chBxBranchResultExprsFromNewLines.TabIndex = 3
			Me.chBxBranchResultExprsFromNewLines.Text = "Branch reslut expressions from new lines"
			Me.chBxBranchResultExprsFromNewLines.UseVisualStyleBackColor = True
'			Me.chBxBranchResultExprsFromNewLines.CheckedChanged += New System.EventHandler(Me.chBxBranchResultExprsFromNewLines_CheckedChanged)
			' 
			' chBxResultKwrdsFromNewLinesThen
			' 
			Me.chBxResultKwrdsFromNewLinesThen.AutoSize = True
			Me.chBxResultKwrdsFromNewLinesThen.Location = New Point(9, 65)
			Me.chBxResultKwrdsFromNewLinesThen.Name = "chBxResultKwrdsFromNewLinesThen"
			Me.chBxResultKwrdsFromNewLinesThen.Size = New Size(278, 17)
			Me.chBxResultKwrdsFromNewLinesThen.TabIndex = 2
			Me.chBxResultKwrdsFromNewLinesThen.Text = "Branch result keywords from new lines (THEN, ELSE)"
			Me.chBxResultKwrdsFromNewLinesThen.UseVisualStyleBackColor = True
'			Me.chBxResultKwrdsFromNewLinesThen.CheckedChanged += New System.EventHandler(Me.chBxResultKwrdsFromNewLinesThen_CheckedChanged)
			' 
			' chBxBranchConditionExprFromNewLines
			' 
			Me.chBxBranchConditionExprFromNewLines.AutoSize = True
			Me.chBxBranchConditionExprFromNewLines.Location = New Point(9, 42)
			Me.chBxBranchConditionExprFromNewLines.Name = "chBxBranchConditionExprFromNewLines"
			Me.chBxBranchConditionExprFromNewLines.Size = New Size(234, 17)
			Me.chBxBranchConditionExprFromNewLines.TabIndex = 1
			Me.chBxBranchConditionExprFromNewLines.Text = "Branch condition expressions from new lines"
			Me.chBxBranchConditionExprFromNewLines.UseVisualStyleBackColor = True
'			Me.chBxBranchConditionExprFromNewLines.CheckedChanged += New System.EventHandler(Me.chBxBranchConditionExprFromNewLines_CheckedChanged)
			' 
			' chBxBranchConditionKeyWrdsFromNewLinesWhen
			' 
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.AutoSize = True
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.Location = New Point(9, 19)
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.Name = "chBxBranchConditionKeyWrdsFromNewLinesWhen"
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.Size = New Size(267, 17)
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.TabIndex = 0
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.Text = "Branch condition keywords from new lines (WHEN)"
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.UseVisualStyleBackColor = True
'			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.CheckedChanged += New System.EventHandler(Me.chBxBranchConditionKeyWrdsFromNewLinesWhen_CheckedChanged)
			' 
			' ExpressionsTab
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BorderStyle = BorderStyle.FixedSingle
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "ExpressionsTab"
			Me.Size = New Size(595, 324)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.UpDownIndentForNestedConditions, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			CType(Me.UpDownExprsIndent, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.UpDownBranchKeyWrdsIndent, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupBox1 As GroupBox
		Private WithEvents UpDownIndentForNestedConditions As NumericUpDown
		Private WithEvents radButEndLines As RadioButton
		Private WithEvents radButStartLines As RadioButton
		Private label3 As Label
		Private label2 As Label
		Private label1 As Label
		Private WithEvents chBxStartAllLogicExprFromNewLines As CheckBox
		Private WithEvents chBxUpperLvlLogicExprFromNewLines As CheckBox
		Private groupBox2 As GroupBox
		Private WithEvents UpDownExprsIndent As NumericUpDown
		Private WithEvents UpDownBranchKeyWrdsIndent As NumericUpDown
		Private label5 As Label
		Private label4 As Label
		Private WithEvents chBxBranchResultExprsFromNewLines As CheckBox
		Private WithEvents chBxResultKwrdsFromNewLinesThen As CheckBox
		Private WithEvents chBxBranchConditionExprFromNewLines As CheckBox
		Private WithEvents chBxBranchConditionKeyWrdsFromNewLinesWhen As CheckBox
	End Class
End Namespace
