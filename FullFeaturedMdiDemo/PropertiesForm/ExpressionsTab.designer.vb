Namespace PropertiesForm
	Partial Class ExpressionsTab
		''' <summary> 
		''' Обязательная переменная конструктора.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Освободить все используемые ресурсы.
		''' </summary>
		''' <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Код, автоматически созданный конструктором компонентов"

		''' <summary> 
		''' Требуемый метод для поддержки конструктора — не изменяйте 
		''' содержимое этого метода с помощью редактора кода.
		''' </summary>
		Private Sub InitializeComponent()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.UpDownIndentForNestedConditions = New System.Windows.Forms.NumericUpDown()
			Me.radButEndLines = New System.Windows.Forms.RadioButton()
			Me.radButStartLines = New System.Windows.Forms.RadioButton()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.chBxStartAllLogicExprFromNewLines = New System.Windows.Forms.CheckBox()
			Me.chBxUpperLvlLogicExprFromNewLines = New System.Windows.Forms.CheckBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.UpDownExprsIndent = New System.Windows.Forms.NumericUpDown()
			Me.UpDownBranchKeyWrdsIndent = New System.Windows.Forms.NumericUpDown()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.chBxBranchResultExprsFromNewLines = New System.Windows.Forms.CheckBox()
			Me.chBxResultKwrdsFromNewLinesThen = New System.Windows.Forms.CheckBox()
			Me.chBxBranchConditionExprFromNewLines = New System.Windows.Forms.CheckBox()
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen = New System.Windows.Forms.CheckBox()
			Me.groupBox1.SuspendLayout()
			DirectCast(Me.UpDownIndentForNestedConditions, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox2.SuspendLayout()
			DirectCast(Me.UpDownExprsIndent, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.UpDownBranchKeyWrdsIndent, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.groupBox1.Controls.Add(Me.UpDownIndentForNestedConditions)
			Me.groupBox1.Controls.Add(Me.radButEndLines)
			Me.groupBox1.Controls.Add(Me.radButStartLines)
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.chBxStartAllLogicExprFromNewLines)
			Me.groupBox1.Controls.Add(Me.chBxUpperLvlLogicExprFromNewLines)
			Me.groupBox1.Location = New System.Drawing.Point(3, 3)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(586, 134)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Logical expressions"
			' 
			' UpDownIndentForNestedConditions
			' 
			Me.UpDownIndentForNestedConditions.Location = New System.Drawing.Point(194, 97)
			Me.UpDownIndentForNestedConditions.Name = "UpDownIndentForNestedConditions"
			Me.UpDownIndentForNestedConditions.Size = New System.Drawing.Size(85, 20)
			Me.UpDownIndentForNestedConditions.TabIndex = 7
			Me.UpDownIndentForNestedConditions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			AddHandler Me.UpDownIndentForNestedConditions.ValueChanged, New System.EventHandler(AddressOf Me.UpDownIndentForNestedConditions_ValueChanged)
			' 
			' radButEndLines
			' 
			Me.radButEndLines.AutoSize = True
			Me.radButEndLines.Checked = True
			Me.radButEndLines.Location = New System.Drawing.Point(241, 69)
			Me.radButEndLines.Name = "radButEndLines"
			Me.radButEndLines.Size = New System.Drawing.Size(67, 17)
			Me.radButEndLines.TabIndex = 6
			Me.radButEndLines.TabStop = True
			Me.radButEndLines.Text = "end lines"
			Me.radButEndLines.UseVisualStyleBackColor = True
			AddHandler Me.radButEndLines.CheckedChanged, New System.EventHandler(AddressOf Me.radButEndLines_CheckedChanged)
			' 
			' radButStartLines
			' 
			Me.radButStartLines.AutoSize = True
			Me.radButStartLines.Location = New System.Drawing.Point(131, 69)
			Me.radButStartLines.Name = "radButStartLines"
			Me.radButStartLines.Size = New System.Drawing.Size(69, 17)
			Me.radButStartLines.TabIndex = 5
			Me.radButStartLines.TabStop = True
			Me.radButStartLines.Text = "start lines"
			Me.radButStartLines.UseVisualStyleBackColor = True
			AddHandler Me.radButStartLines.CheckedChanged, New System.EventHandler(AddressOf Me.radButStartLines_CheckedChanged)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Dock = System.Windows.Forms.DockStyle.Right
			Me.label3.Location = New System.Drawing.Point(388, 16)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(195, 39)
			Me.label3.TabIndex = 4
			Me.label3.Text = "Layout of logical expressions in " & vbCr & vbLf & "WHERE and HAVING clauses and join " & vbCr & vbLf & "conditions" & " in the FROM part."
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(6, 104)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(141, 13)
			Me.label2.TabIndex = 3
			Me.label2.Text = "Indent for nested conditions:"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(6, 71)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(91, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Logical operators:"
			' 
			' chBxStartAllLogicExprFromNewLines
			' 
			Me.chBxStartAllLogicExprFromNewLines.AutoSize = True
			Me.chBxStartAllLogicExprFromNewLines.Location = New System.Drawing.Point(6, 42)
			Me.chBxStartAllLogicExprFromNewLines.Name = "chBxStartAllLogicExprFromNewLines"
			Me.chBxStartAllLogicExprFromNewLines.Size = New System.Drawing.Size(222, 17)
			Me.chBxStartAllLogicExprFromNewLines.TabIndex = 1
			Me.chBxStartAllLogicExprFromNewLines.Text = "Start all logical expressions from new lines"
			Me.chBxStartAllLogicExprFromNewLines.UseVisualStyleBackColor = True
			AddHandler Me.chBxStartAllLogicExprFromNewLines.CheckedChanged, New System.EventHandler(AddressOf Me.chBxStartAllLogicExprFromNewLines_CheckedChanged)
			' 
			' chBxUpperLvlLogicExprFromNewLines
			' 
			Me.chBxUpperLvlLogicExprFromNewLines.AutoSize = True
			Me.chBxUpperLvlLogicExprFromNewLines.Checked = True
			Me.chBxUpperLvlLogicExprFromNewLines.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chBxUpperLvlLogicExprFromNewLines.Location = New System.Drawing.Point(6, 19)
			Me.chBxUpperLvlLogicExprFromNewLines.Name = "chBxUpperLvlLogicExprFromNewLines"
			Me.chBxUpperLvlLogicExprFromNewLines.Size = New System.Drawing.Size(282, 17)
			Me.chBxUpperLvlLogicExprFromNewLines.TabIndex = 0
			Me.chBxUpperLvlLogicExprFromNewLines.Text = "Start the upper-level logical expressions from new lines"
			Me.chBxUpperLvlLogicExprFromNewLines.UseVisualStyleBackColor = True
			AddHandler Me.chBxUpperLvlLogicExprFromNewLines.CheckedChanged, New System.EventHandler(AddressOf Me.chBxUpperLvlLogicExprFromNewLines_CheckedChanged)
			' 
			' groupBox2
			' 
			Me.groupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.groupBox2.Controls.Add(Me.UpDownExprsIndent)
			Me.groupBox2.Controls.Add(Me.UpDownBranchKeyWrdsIndent)
			Me.groupBox2.Controls.Add(Me.label5)
			Me.groupBox2.Controls.Add(Me.label4)
			Me.groupBox2.Controls.Add(Me.chBxBranchResultExprsFromNewLines)
			Me.groupBox2.Controls.Add(Me.chBxResultKwrdsFromNewLinesThen)
			Me.groupBox2.Controls.Add(Me.chBxBranchConditionExprFromNewLines)
			Me.groupBox2.Controls.Add(Me.chBxBranchConditionKeyWrdsFromNewLinesWhen)
			Me.groupBox2.Location = New System.Drawing.Point(3, 143)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(583, 172)
			Me.groupBox2.TabIndex = 1
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Conditional operators (IF, CASE)"
			' 
			' UpDownExprsIndent
			' 
			Me.UpDownExprsIndent.Location = New System.Drawing.Point(156, 142)
			Me.UpDownExprsIndent.Name = "UpDownExprsIndent"
			Me.UpDownExprsIndent.Size = New System.Drawing.Size(87, 20)
			Me.UpDownExprsIndent.TabIndex = 7
			Me.UpDownExprsIndent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			AddHandler Me.UpDownExprsIndent.ValueChanged, New System.EventHandler(AddressOf Me.UpDownExprsIndent_ValueChanged)
			' 
			' UpDownBranchKeyWrdsIndent
			' 
			Me.UpDownBranchKeyWrdsIndent.Location = New System.Drawing.Point(156, 116)
			Me.UpDownBranchKeyWrdsIndent.Name = "UpDownBranchKeyWrdsIndent"
			Me.UpDownBranchKeyWrdsIndent.Size = New System.Drawing.Size(87, 20)
			Me.UpDownBranchKeyWrdsIndent.TabIndex = 6
			Me.UpDownBranchKeyWrdsIndent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			AddHandler Me.UpDownBranchKeyWrdsIndent.ValueChanged, New System.EventHandler(AddressOf Me.UpDownBranchKeyWrdsIndent_ValueChanged)
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(6, 148)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(98, 13)
			Me.label5.TabIndex = 5
			Me.label5.Text = "Expressions indent:"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(6, 123)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(126, 13)
			Me.label4.TabIndex = 4
			Me.label4.Text = "Branch Keywords Indent:"
			' 
			' chBxBranchResultExprsFromNewLines
			' 
			Me.chBxBranchResultExprsFromNewLines.AutoSize = True
			Me.chBxBranchResultExprsFromNewLines.Location = New System.Drawing.Point(9, 88)
			Me.chBxBranchResultExprsFromNewLines.Name = "chBxBranchResultExprsFromNewLines"
			Me.chBxBranchResultExprsFromNewLines.Size = New System.Drawing.Size(216, 17)
			Me.chBxBranchResultExprsFromNewLines.TabIndex = 3
			Me.chBxBranchResultExprsFromNewLines.Text = "Branch reslut expressions from new lines"
			Me.chBxBranchResultExprsFromNewLines.UseVisualStyleBackColor = True
			AddHandler Me.chBxBranchResultExprsFromNewLines.CheckedChanged, New System.EventHandler(AddressOf Me.chBxBranchResultExprsFromNewLines_CheckedChanged)
			' 
			' chBxResultKwrdsFromNewLinesThen
			' 
			Me.chBxResultKwrdsFromNewLinesThen.AutoSize = True
			Me.chBxResultKwrdsFromNewLinesThen.Location = New System.Drawing.Point(9, 65)
			Me.chBxResultKwrdsFromNewLinesThen.Name = "chBxResultKwrdsFromNewLinesThen"
			Me.chBxResultKwrdsFromNewLinesThen.Size = New System.Drawing.Size(278, 17)
			Me.chBxResultKwrdsFromNewLinesThen.TabIndex = 2
			Me.chBxResultKwrdsFromNewLinesThen.Text = "Branch result keywords from new lines (THEN, ELSE)"
			Me.chBxResultKwrdsFromNewLinesThen.UseVisualStyleBackColor = True
			AddHandler Me.chBxResultKwrdsFromNewLinesThen.CheckedChanged, New System.EventHandler(AddressOf Me.chBxResultKwrdsFromNewLinesThen_CheckedChanged)
			' 
			' chBxBranchConditionExprFromNewLines
			' 
			Me.chBxBranchConditionExprFromNewLines.AutoSize = True
			Me.chBxBranchConditionExprFromNewLines.Location = New System.Drawing.Point(9, 42)
			Me.chBxBranchConditionExprFromNewLines.Name = "chBxBranchConditionExprFromNewLines"
			Me.chBxBranchConditionExprFromNewLines.Size = New System.Drawing.Size(234, 17)
			Me.chBxBranchConditionExprFromNewLines.TabIndex = 1
			Me.chBxBranchConditionExprFromNewLines.Text = "Branch condition expressions from new lines"
			Me.chBxBranchConditionExprFromNewLines.UseVisualStyleBackColor = True
			AddHandler Me.chBxBranchConditionExprFromNewLines.CheckedChanged, New System.EventHandler(AddressOf Me.chBxBranchConditionExprFromNewLines_CheckedChanged)
			' 
			' chBxBranchConditionKeyWrdsFromNewLinesWhen
			' 
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.AutoSize = True
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.Location = New System.Drawing.Point(9, 19)
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.Name = "chBxBranchConditionKeyWrdsFromNewLinesWhen"
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.Size = New System.Drawing.Size(267, 17)
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.TabIndex = 0
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.Text = "Branch condition keywords from new lines (WHEN)"
			Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.UseVisualStyleBackColor = True
			AddHandler Me.chBxBranchConditionKeyWrdsFromNewLinesWhen.CheckedChanged, New System.EventHandler(AddressOf Me.chBxBranchConditionKeyWrdsFromNewLinesWhen_CheckedChanged)
			' 
			' ExpressionsTab
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "ExpressionsTab"
			Me.Size = New System.Drawing.Size(595, 324)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			DirectCast(Me.UpDownIndentForNestedConditions, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			DirectCast(Me.UpDownExprsIndent, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.UpDownBranchKeyWrdsIndent, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupBox1 As System.Windows.Forms.GroupBox
		Private UpDownIndentForNestedConditions As System.Windows.Forms.NumericUpDown
		Private radButEndLines As System.Windows.Forms.RadioButton
		Private radButStartLines As System.Windows.Forms.RadioButton
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private chBxStartAllLogicExprFromNewLines As System.Windows.Forms.CheckBox
		Private chBxUpperLvlLogicExprFromNewLines As System.Windows.Forms.CheckBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private UpDownExprsIndent As System.Windows.Forms.NumericUpDown
		Private UpDownBranchKeyWrdsIndent As System.Windows.Forms.NumericUpDown
		Private label5 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private chBxBranchResultExprsFromNewLines As System.Windows.Forms.CheckBox
		Private chBxResultKwrdsFromNewLinesThen As System.Windows.Forms.CheckBox
		Private chBxBranchConditionExprFromNewLines As System.Windows.Forms.CheckBox
		Private chBxBranchConditionKeyWrdsFromNewLinesWhen As System.Windows.Forms.CheckBox
	End Class
End Namespace
