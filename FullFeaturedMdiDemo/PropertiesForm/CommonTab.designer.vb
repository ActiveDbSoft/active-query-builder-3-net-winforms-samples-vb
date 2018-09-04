Namespace PropertiesForm
	Partial Class CommonTab
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
			Me.label2 = New System.Windows.Forms.Label()
			Me.upDownPartIndent = New System.Windows.Forms.NumericUpDown()
			Me.label1 = New System.Windows.Forms.Label()
			Me.chBxInsertNewLineAfterPartKeywords = New System.Windows.Forms.CheckBox()
			Me.chBxStartPartsFromNewLines = New System.Windows.Forms.CheckBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.radButNewLineAfterComma = New System.Windows.Forms.RadioButton()
			Me.radButNewLineBeforeComma = New System.Windows.Forms.RadioButton()
			Me.chBxStartSelectListItemsOnNewLines = New System.Windows.Forms.CheckBox()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.chBxStartJoinConditionsOnNewLines = New System.Windows.Forms.CheckBox()
			Me.radButStartJoinKeywordsFromNewLines = New System.Windows.Forms.RadioButton()
			Me.radButStartDataSourcesFromNewLines = New System.Windows.Forms.RadioButton()
			Me.groupBox1.SuspendLayout()
			DirectCast(Me.upDownPartIndent, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox2.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.upDownPartIndent)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.chBxInsertNewLineAfterPartKeywords)
			Me.groupBox1.Controls.Add(Me.chBxStartPartsFromNewLines)
			Me.groupBox1.Location = New System.Drawing.Point(3, 3)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(624, 121)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Common SQL format options"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Dock = System.Windows.Forms.DockStyle.Right
			Me.label2.Location = New System.Drawing.Point(431, 16)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(190, 52)
			Me.label2.TabIndex = 4
			Me.label2.Text = "These options determine layout of " & vbCr & vbLf & "general parts of the SELECT " & vbCr & vbLf & "statement (SELE" & "CT, FROM, WHERE, " & vbCr & vbLf & "HAVING, etc.)"
			' 
			' upDownPartIndent
			' 
			Me.upDownPartIndent.Location = New System.Drawing.Point(211, 81)
			Me.upDownPartIndent.Name = "upDownPartIndent"
			Me.upDownPartIndent.Size = New System.Drawing.Size(85, 20)
			Me.upDownPartIndent.TabIndex = 3
			Me.upDownPartIndent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			Me.upDownPartIndent.Value = New Decimal(New Integer() {2, 0, 0, 0})
			AddHandler Me.upDownPartIndent.ValueChanged, New System.EventHandler(AddressOf Me.upDownPartIndent_ValueChanged)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(30, 88)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(62, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Part Indent:"
			' 
			' chBxInsertNewLineAfterPartKeywords
			' 
			Me.chBxInsertNewLineAfterPartKeywords.AutoSize = True
			Me.chBxInsertNewLineAfterPartKeywords.Location = New System.Drawing.Point(11, 51)
			Me.chBxInsertNewLineAfterPartKeywords.Name = "chBxInsertNewLineAfterPartKeywords"
			Me.chBxInsertNewLineAfterPartKeywords.Size = New System.Drawing.Size(187, 17)
			Me.chBxInsertNewLineAfterPartKeywords.TabIndex = 1
			Me.chBxInsertNewLineAfterPartKeywords.Text = "Insert new line after part keywords"
			Me.chBxInsertNewLineAfterPartKeywords.UseVisualStyleBackColor = True
			AddHandler Me.chBxInsertNewLineAfterPartKeywords.CheckedChanged, New System.EventHandler(AddressOf Me.chBxInsertNewLineAfterPartKeywords_CheckedChanged)
			' 
			' chBxStartPartsFromNewLines
			' 
			Me.chBxStartPartsFromNewLines.AutoSize = True
			Me.chBxStartPartsFromNewLines.Checked = True
			Me.chBxStartPartsFromNewLines.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chBxStartPartsFromNewLines.Location = New System.Drawing.Point(11, 19)
			Me.chBxStartPartsFromNewLines.Name = "chBxStartPartsFromNewLines"
			Me.chBxStartPartsFromNewLines.Size = New System.Drawing.Size(144, 17)
			Me.chBxStartPartsFromNewLines.TabIndex = 0
			Me.chBxStartPartsFromNewLines.Text = "Start parts from new lines"
			Me.chBxStartPartsFromNewLines.UseVisualStyleBackColor = True
			AddHandler Me.chBxStartPartsFromNewLines.CheckedChanged, New System.EventHandler(AddressOf Me.chBxStartPartsFromNewLines_CheckedChanged)
			' 
			' groupBox2
			' 
			Me.groupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.groupBox2.Controls.Add(Me.label3)
			Me.groupBox2.Controls.Add(Me.radButNewLineAfterComma)
			Me.groupBox2.Controls.Add(Me.radButNewLineBeforeComma)
			Me.groupBox2.Controls.Add(Me.chBxStartSelectListItemsOnNewLines)
			Me.groupBox2.Location = New System.Drawing.Point(3, 130)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(624, 99)
			Me.groupBox2.TabIndex = 1
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Comma-separated lists"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Dock = System.Windows.Forms.DockStyle.Right
			Me.label3.Location = New System.Drawing.Point(426, 16)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(195, 26)
			Me.label3.TabIndex = 3
			Me.label3.Text = "Layout of items in SELECT, ORDER BY" & vbCr & vbLf & "and GROUP BY lists." & vbCr & vbLf
			' 
			' radButNewLineAfterComma
			' 
			Me.radButNewLineAfterComma.AutoSize = True
			Me.radButNewLineAfterComma.Checked = True
			Me.radButNewLineAfterComma.Location = New System.Drawing.Point(211, 60)
			Me.radButNewLineAfterComma.Name = "radButNewLineAfterComma"
			Me.radButNewLineAfterComma.Size = New System.Drawing.Size(127, 17)
			Me.radButNewLineAfterComma.TabIndex = 2
			Me.radButNewLineAfterComma.TabStop = True
			Me.radButNewLineAfterComma.Text = "New line after comma"
			Me.radButNewLineAfterComma.UseVisualStyleBackColor = True
			AddHandler Me.radButNewLineAfterComma.CheckedChanged, New System.EventHandler(AddressOf Me.radButNewLineAfterComma_CheckedChanged)
			' 
			' radButNewLineBeforeComma
			' 
			Me.radButNewLineBeforeComma.AutoSize = True
			Me.radButNewLineBeforeComma.Location = New System.Drawing.Point(11, 60)
			Me.radButNewLineBeforeComma.Name = "radButNewLineBeforeComma"
			Me.radButNewLineBeforeComma.Size = New System.Drawing.Size(136, 17)
			Me.radButNewLineBeforeComma.TabIndex = 1
			Me.radButNewLineBeforeComma.TabStop = True
			Me.radButNewLineBeforeComma.Text = "New line before comma"
			Me.radButNewLineBeforeComma.UseVisualStyleBackColor = True
			AddHandler Me.radButNewLineBeforeComma.CheckedChanged, New System.EventHandler(AddressOf Me.radButNewLineBeforeComma_CheckedChanged)
			' 
			' chBxStartSelectListItemsOnNewLines
			' 
			Me.chBxStartSelectListItemsOnNewLines.AutoSize = True
			Me.chBxStartSelectListItemsOnNewLines.Checked = True
			Me.chBxStartSelectListItemsOnNewLines.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chBxStartSelectListItemsOnNewLines.Location = New System.Drawing.Point(11, 28)
			Me.chBxStartSelectListItemsOnNewLines.Name = "chBxStartSelectListItemsOnNewLines"
			Me.chBxStartSelectListItemsOnNewLines.Size = New System.Drawing.Size(183, 17)
			Me.chBxStartSelectListItemsOnNewLines.TabIndex = 0
			Me.chBxStartSelectListItemsOnNewLines.Text = "Start select list items on new lines"
			Me.chBxStartSelectListItemsOnNewLines.UseVisualStyleBackColor = True
			AddHandler Me.chBxStartSelectListItemsOnNewLines.CheckedChanged, New System.EventHandler(AddressOf Me.chBxStartSelectListItemsOnNewLines_CheckedChanged)
			' 
			' groupBox3
			' 
			Me.groupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.groupBox3.Controls.Add(Me.label4)
			Me.groupBox3.Controls.Add(Me.chBxStartJoinConditionsOnNewLines)
			Me.groupBox3.Controls.Add(Me.radButStartJoinKeywordsFromNewLines)
			Me.groupBox3.Controls.Add(Me.radButStartDataSourcesFromNewLines)
			Me.groupBox3.Location = New System.Drawing.Point(3, 235)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(624, 91)
			Me.groupBox3.TabIndex = 2
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "From clause"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Dock = System.Windows.Forms.DockStyle.Right
			Me.label4.Location = New System.Drawing.Point(447, 16)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(174, 13)
			Me.label4.TabIndex = 3
			Me.label4.Text = "Layout of the FROM part the query." & vbCr & vbLf
			' 
			' chBxStartJoinConditionsOnNewLines
			' 
			Me.chBxStartJoinConditionsOnNewLines.AutoSize = True
			Me.chBxStartJoinConditionsOnNewLines.Location = New System.Drawing.Point(11, 66)
			Me.chBxStartJoinConditionsOnNewLines.Name = "chBxStartJoinConditionsOnNewLines"
			Me.chBxStartJoinConditionsOnNewLines.Size = New System.Drawing.Size(180, 17)
			Me.chBxStartJoinConditionsOnNewLines.TabIndex = 2
			Me.chBxStartJoinConditionsOnNewLines.Text = "Start join conditions on new lines"
			Me.chBxStartJoinConditionsOnNewLines.UseVisualStyleBackColor = True
			AddHandler Me.chBxStartJoinConditionsOnNewLines.CheckedChanged, New System.EventHandler(AddressOf Me.chBxStartJoinConditionsOnNewLines_CheckedChanged)
			' 
			' radButStartJoinKeywordsFromNewLines
			' 
			Me.radButStartJoinKeywordsFromNewLines.AutoSize = True
			Me.radButStartJoinKeywordsFromNewLines.Location = New System.Drawing.Point(11, 42)
			Me.radButStartJoinKeywordsFromNewLines.Name = "radButStartJoinKeywordsFromNewLines"
			Me.radButStartJoinKeywordsFromNewLines.Size = New System.Drawing.Size(202, 17)
			Me.radButStartJoinKeywordsFromNewLines.TabIndex = 1
			Me.radButStartJoinKeywordsFromNewLines.Text = "Start ""JOIN"" keywords from new lines"
			Me.radButStartJoinKeywordsFromNewLines.UseVisualStyleBackColor = True
			AddHandler Me.radButStartJoinKeywordsFromNewLines.CheckedChanged, New System.EventHandler(AddressOf Me.radButStartJoinKeywordsFromNewLines_CheckedChanged)
			' 
			' radButStartDataSourcesFromNewLines
			' 
			Me.radButStartDataSourcesFromNewLines.AutoSize = True
			Me.radButStartDataSourcesFromNewLines.Checked = True
			Me.radButStartDataSourcesFromNewLines.Location = New System.Drawing.Point(11, 19)
			Me.radButStartDataSourcesFromNewLines.Name = "radButStartDataSourcesFromNewLines"
			Me.radButStartDataSourcesFromNewLines.Size = New System.Drawing.Size(178, 17)
			Me.radButStartDataSourcesFromNewLines.TabIndex = 0
			Me.radButStartDataSourcesFromNewLines.TabStop = True
			Me.radButStartDataSourcesFromNewLines.Text = "Start datasources from new lines"
			Me.radButStartDataSourcesFromNewLines.UseVisualStyleBackColor = True
			AddHandler Me.radButStartDataSourcesFromNewLines.CheckedChanged, New System.EventHandler(AddressOf Me.radButStartDataSourcesFromNewLines_CheckedChanged)
			' 
			' CommonTab
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.Controls.Add(Me.groupBox3)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "CommonTab"
			Me.Size = New System.Drawing.Size(633, 352)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			DirectCast(Me.upDownPartIndent, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox3.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label2 As System.Windows.Forms.Label
		Private upDownPartIndent As System.Windows.Forms.NumericUpDown
		Private label1 As System.Windows.Forms.Label
		Private chBxInsertNewLineAfterPartKeywords As System.Windows.Forms.CheckBox
		Private chBxStartPartsFromNewLines As System.Windows.Forms.CheckBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private label3 As System.Windows.Forms.Label
		Private radButNewLineAfterComma As System.Windows.Forms.RadioButton
		Private radButNewLineBeforeComma As System.Windows.Forms.RadioButton
		Private chBxStartSelectListItemsOnNewLines As System.Windows.Forms.CheckBox
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private label4 As System.Windows.Forms.Label
		Private chBxStartJoinConditionsOnNewLines As System.Windows.Forms.CheckBox
		Private radButStartJoinKeywordsFromNewLines As System.Windows.Forms.RadioButton
		Private radButStartDataSourcesFromNewLines As System.Windows.Forms.RadioButton
	End Class
End Namespace
