Namespace PropertiesForm
	Partial Class MainQueryTab
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
			Me.label5 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.chBxParenthesizeEachSingleCondition = New System.Windows.Forms.CheckBox()
			Me.chBxParenthesizeConditionsWithinAndOperators = New System.Windows.Forms.CheckBox()
			Me.chBxEnableDynamicRightMargin = New System.Windows.Forms.CheckBox()
			Me.chBxEnableDynamicIndents = New System.Windows.Forms.CheckBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.cmbBoxKeyWordsCase = New System.Windows.Forms.ComboBox()
			Me.upDownMaxCharsInLine = New System.Windows.Forms.NumericUpDown()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.chBxEnableWordWrap = New System.Windows.Forms.CheckBox()
			Me.groupBox1.SuspendLayout()
			DirectCast(Me.upDownMaxCharsInLine, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.groupBox1.Controls.Add(Me.label5)
			Me.groupBox1.Controls.Add(Me.label4)
			Me.groupBox1.Controls.Add(Me.chBxParenthesizeEachSingleCondition)
			Me.groupBox1.Controls.Add(Me.chBxParenthesizeConditionsWithinAndOperators)
			Me.groupBox1.Controls.Add(Me.chBxEnableDynamicRightMargin)
			Me.groupBox1.Controls.Add(Me.chBxEnableDynamicIndents)
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.cmbBoxKeyWordsCase)
			Me.groupBox1.Controls.Add(Me.upDownMaxCharsInLine)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.chBxEnableWordWrap)
			Me.groupBox1.Location = New System.Drawing.Point(3, 3)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(715, 390)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "General SQL Formatting options"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(259, 236)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(310, 39)
			Me.label5.TabIndex = 11
			Me.label5.Text = "Example:" & vbCr & vbLf & "(Condition1) AND (condition2) OR (Condition3) AND (Condition4)" & vbCr & vbLf & vbCr & vbLf
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(259, 194)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(298, 26)
			Me.label4.TabIndex = 10
			Me.label4.Text = "Example:" & vbCr & vbLf & "(Condition1 AND condition2) OR (Condition3 AND Condition4)" & vbCr & vbLf
			' 
			' chBxParenthesizeEachSingleCondition
			' 
			Me.chBxParenthesizeEachSingleCondition.AutoSize = True
			Me.chBxParenthesizeEachSingleCondition.Location = New System.Drawing.Point(6, 236)
			Me.chBxParenthesizeEachSingleCondition.Name = "chBxParenthesizeEachSingleCondition"
			Me.chBxParenthesizeEachSingleCondition.Size = New System.Drawing.Size(190, 17)
			Me.chBxParenthesizeEachSingleCondition.TabIndex = 9
			Me.chBxParenthesizeEachSingleCondition.Text = "Parenthesize each single condition"
			Me.chBxParenthesizeEachSingleCondition.UseVisualStyleBackColor = True
			AddHandler Me.chBxParenthesizeEachSingleCondition.CheckedChanged, New System.EventHandler(AddressOf Me.chBxParenthesizeEachSingleCondition_CheckedChanged)
			' 
			' chBxParenthesizeConditionsWithinAndOperators
			' 
			Me.chBxParenthesizeConditionsWithinAndOperators.AutoSize = True
			Me.chBxParenthesizeConditionsWithinAndOperators.Checked = True
			Me.chBxParenthesizeConditionsWithinAndOperators.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chBxParenthesizeConditionsWithinAndOperators.Location = New System.Drawing.Point(6, 194)
			Me.chBxParenthesizeConditionsWithinAndOperators.Name = "chBxParenthesizeConditionsWithinAndOperators"
			Me.chBxParenthesizeConditionsWithinAndOperators.Size = New System.Drawing.Size(241, 17)
			Me.chBxParenthesizeConditionsWithinAndOperators.TabIndex = 8
			Me.chBxParenthesizeConditionsWithinAndOperators.Text = "Parenthesize conditions within AND operators"
			Me.chBxParenthesizeConditionsWithinAndOperators.UseVisualStyleBackColor = True
			AddHandler Me.chBxParenthesizeConditionsWithinAndOperators.CheckedChanged, New System.EventHandler(AddressOf Me.chBxParenthesizeConditionsWithinAndOperators_CheckedChanged)
			' 
			' chBxEnableDynamicRightMargin
			' 
			Me.chBxEnableDynamicRightMargin.AutoSize = True
			Me.chBxEnableDynamicRightMargin.Location = New System.Drawing.Point(6, 159)
			Me.chBxEnableDynamicRightMargin.Name = "chBxEnableDynamicRightMargin"
			Me.chBxEnableDynamicRightMargin.Size = New System.Drawing.Size(158, 17)
			Me.chBxEnableDynamicRightMargin.TabIndex = 7
			Me.chBxEnableDynamicRightMargin.Text = "Enable dynamic right margin"
			Me.chBxEnableDynamicRightMargin.UseVisualStyleBackColor = True
			AddHandler Me.chBxEnableDynamicRightMargin.CheckedChanged, New System.EventHandler(AddressOf Me.chBxEnableDynamicRightMargin_CheckedChanged)
			' 
			' chBxEnableDynamicIndents
			' 
			Me.chBxEnableDynamicIndents.AutoSize = True
			Me.chBxEnableDynamicIndents.Location = New System.Drawing.Point(6, 125)
			Me.chBxEnableDynamicIndents.Name = "chBxEnableDynamicIndents"
			Me.chBxEnableDynamicIndents.Size = New System.Drawing.Size(138, 17)
			Me.chBxEnableDynamicIndents.TabIndex = 6
			Me.chBxEnableDynamicIndents.Text = "Enable dynamic indents"
			Me.chBxEnableDynamicIndents.UseVisualStyleBackColor = True
			AddHandler Me.chBxEnableDynamicIndents.CheckedChanged, New System.EventHandler(AddressOf Me.chBxEnableDynamicIndents_CheckedChanged)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Dock = System.Windows.Forms.DockStyle.Right
			Me.label3.Location = New System.Drawing.Point(351, 16)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(361, 13)
			Me.label3.TabIndex = 5
			Me.label3.Text = "These options affect on whole SQL query text (main query and sub-queries)"
			' 
			' cmbBoxKeyWordsCase
			' 
			Me.cmbBoxKeyWordsCase.FormattingEnabled = True
			Me.cmbBoxKeyWordsCase.Items.AddRange(New Object() {"First Upper", "UpperCase", "LowerCase"})
			Me.cmbBoxKeyWordsCase.Location = New System.Drawing.Point(171, 76)
			Me.cmbBoxKeyWordsCase.Name = "cmbBoxKeyWordsCase"
			Me.cmbBoxKeyWordsCase.Size = New System.Drawing.Size(120, 21)
			Me.cmbBoxKeyWordsCase.TabIndex = 4
			Me.cmbBoxKeyWordsCase.Text = "FirstUpper"
			AddHandler Me.cmbBoxKeyWordsCase.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cmbBoxKeyWordsCase_SelectedIndexChanged)
			' 
			' upDownMaxCharsInLine
			' 
			Me.upDownMaxCharsInLine.Location = New System.Drawing.Point(171, 45)
			Me.upDownMaxCharsInLine.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
			Me.upDownMaxCharsInLine.Name = "upDownMaxCharsInLine"
			Me.upDownMaxCharsInLine.Size = New System.Drawing.Size(120, 20)
			Me.upDownMaxCharsInLine.TabIndex = 3
			Me.upDownMaxCharsInLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Me.upDownMaxCharsInLine.Value = New Decimal(New Integer() {120, 0, 0, 0})
			AddHandler Me.upDownMaxCharsInLine.ValueChanged, New System.EventHandler(AddressOf Me.upDownMaxCharsInLine_ValueChanged)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(28, 76)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(82, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Keywords case:"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(28, 47)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(137, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Maximum characters in line:"
			' 
			' chBxEnableWordWrap
			' 
			Me.chBxEnableWordWrap.AutoSize = True
			Me.chBxEnableWordWrap.Checked = True
			Me.chBxEnableWordWrap.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chBxEnableWordWrap.Location = New System.Drawing.Point(6, 19)
			Me.chBxEnableWordWrap.Name = "chBxEnableWordWrap"
			Me.chBxEnableWordWrap.Size = New System.Drawing.Size(111, 17)
			Me.chBxEnableWordWrap.TabIndex = 0
			Me.chBxEnableWordWrap.Text = "Enable word wrap"
			Me.chBxEnableWordWrap.UseVisualStyleBackColor = True
			AddHandler Me.chBxEnableWordWrap.CheckedChanged, New System.EventHandler(AddressOf Me.chBxEnableWordWrap_CheckedChanged)
			' 
			' MainQueryTab
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "MainQueryTab"
			Me.Size = New System.Drawing.Size(728, 400)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			DirectCast(Me.upDownMaxCharsInLine, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label5 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private chBxParenthesizeEachSingleCondition As System.Windows.Forms.CheckBox
		Private chBxParenthesizeConditionsWithinAndOperators As System.Windows.Forms.CheckBox
		Private chBxEnableDynamicRightMargin As System.Windows.Forms.CheckBox
		Private chBxEnableDynamicIndents As System.Windows.Forms.CheckBox
		Private label3 As System.Windows.Forms.Label
		Private cmbBoxKeyWordsCase As System.Windows.Forms.ComboBox
		Private upDownMaxCharsInLine As System.Windows.Forms.NumericUpDown
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private chBxEnableWordWrap As System.Windows.Forms.CheckBox
	End Class
End Namespace
