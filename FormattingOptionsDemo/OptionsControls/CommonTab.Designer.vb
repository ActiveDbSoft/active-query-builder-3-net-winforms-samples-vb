Namespace OptionsControls
	Partial Public Class CommonTab
		Private components As System.ComponentModel.IContainer = Nothing

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub InitializeComponent()
			Me.groupBox1 = New GroupBox()
			Me.label2 = New Label()
			Me.upDownPartIndent = New NumericUpDown()
			Me.label1 = New Label()
			Me.chBxInsertNewLineAfterPartKeywords = New CheckBox()
			Me.chBxStartPartsFromNewLines = New CheckBox()
			Me.groupBox2 = New GroupBox()
			Me.label3 = New Label()
			Me.radButNewLineAfterComma = New RadioButton()
			Me.radButNewLineBeforeComma = New RadioButton()
			Me.chBxStartSelectListItemsOnNewLines = New CheckBox()
			Me.groupBox3 = New GroupBox()
			Me.label4 = New Label()
			Me.chBxStartJoinConditionsOnNewLines = New CheckBox()
			Me.radButStartJoinKeywordsFromNewLines = New RadioButton()
			Me.radButStartDataSourcesFromNewLines = New RadioButton()
			Me.groupBox1.SuspendLayout()
			CType(Me.upDownPartIndent, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox2.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.upDownPartIndent)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.chBxInsertNewLineAfterPartKeywords)
			Me.groupBox1.Controls.Add(Me.chBxStartPartsFromNewLines)
			Me.groupBox1.Location = New Point(3, 3)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New Size(624, 121)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Common SQL format options"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Dock = DockStyle.Right
			Me.label2.Location = New Point(431, 16)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(190, 52)
			Me.label2.TabIndex = 4
			Me.label2.Text = "These options determine layout of " & vbCrLf & "general parts of the SELECT " & vbCrLf & "statement (SELE" & "CT, FROM, WHERE, " & vbCrLf & "HAVING, etc.)"
			' 
			' upDownPartIndent
			' 
			Me.upDownPartIndent.Location = New Point(211, 81)
			Me.upDownPartIndent.Name = "upDownPartIndent"
			Me.upDownPartIndent.Size = New Size(85, 20)
			Me.upDownPartIndent.TabIndex = 3
			Me.upDownPartIndent.TextAlign = HorizontalAlignment.Right
			Me.upDownPartIndent.Value = New Decimal(New Integer() { 2, 0, 0, 0})
'			Me.upDownPartIndent.ValueChanged += New System.EventHandler(Me.upDownPartIndent_ValueChanged)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New Point(30, 88)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(62, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Part Indent:"
			' 
			' chBxInsertNewLineAfterPartKeywords
			' 
			Me.chBxInsertNewLineAfterPartKeywords.AutoSize = True
			Me.chBxInsertNewLineAfterPartKeywords.Location = New Point(11, 51)
			Me.chBxInsertNewLineAfterPartKeywords.Name = "chBxInsertNewLineAfterPartKeywords"
			Me.chBxInsertNewLineAfterPartKeywords.Size = New Size(187, 17)
			Me.chBxInsertNewLineAfterPartKeywords.TabIndex = 1
			Me.chBxInsertNewLineAfterPartKeywords.Text = "Insert new line after part keywords"
			Me.chBxInsertNewLineAfterPartKeywords.UseVisualStyleBackColor = True
'			Me.chBxInsertNewLineAfterPartKeywords.CheckedChanged += New System.EventHandler(Me.chBxInsertNewLineAfterPartKeywords_CheckedChanged)
			' 
			' chBxStartPartsFromNewLines
			' 
			Me.chBxStartPartsFromNewLines.AutoSize = True
			Me.chBxStartPartsFromNewLines.Checked = True
			Me.chBxStartPartsFromNewLines.CheckState = CheckState.Checked
			Me.chBxStartPartsFromNewLines.Location = New Point(11, 19)
			Me.chBxStartPartsFromNewLines.Name = "chBxStartPartsFromNewLines"
			Me.chBxStartPartsFromNewLines.Size = New Size(144, 17)
			Me.chBxStartPartsFromNewLines.TabIndex = 0
			Me.chBxStartPartsFromNewLines.Text = "Start parts from new lines"
			Me.chBxStartPartsFromNewLines.UseVisualStyleBackColor = True
'			Me.chBxStartPartsFromNewLines.CheckedChanged += New System.EventHandler(Me.chBxStartPartsFromNewLines_CheckedChanged)
			' 
			' groupBox2
			' 
			Me.groupBox2.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.groupBox2.Controls.Add(Me.label3)
			Me.groupBox2.Controls.Add(Me.radButNewLineAfterComma)
			Me.groupBox2.Controls.Add(Me.radButNewLineBeforeComma)
			Me.groupBox2.Controls.Add(Me.chBxStartSelectListItemsOnNewLines)
			Me.groupBox2.Location = New Point(3, 130)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New Size(624, 99)
			Me.groupBox2.TabIndex = 1
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Comma-separated lists"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Dock = DockStyle.Right
			Me.label3.Location = New Point(426, 16)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(195, 26)
			Me.label3.TabIndex = 3
			Me.label3.Text = "Layout of items in SELECT, ORDER BY" & vbCrLf & "and GROUP BY lists." & vbCrLf
			' 
			' radButNewLineAfterComma
			' 
			Me.radButNewLineAfterComma.AutoSize = True
			Me.radButNewLineAfterComma.Checked = True
			Me.radButNewLineAfterComma.Location = New Point(211, 60)
			Me.radButNewLineAfterComma.Name = "radButNewLineAfterComma"
			Me.radButNewLineAfterComma.Size = New Size(127, 17)
			Me.radButNewLineAfterComma.TabIndex = 2
			Me.radButNewLineAfterComma.TabStop = True
			Me.radButNewLineAfterComma.Text = "New line after comma"
			Me.radButNewLineAfterComma.UseVisualStyleBackColor = True
'			Me.radButNewLineAfterComma.CheckedChanged += New System.EventHandler(Me.radButNewLineAfterComma_CheckedChanged)
			' 
			' radButNewLineBeforeComma
			' 
			Me.radButNewLineBeforeComma.AutoSize = True
			Me.radButNewLineBeforeComma.Location = New Point(11, 60)
			Me.radButNewLineBeforeComma.Name = "radButNewLineBeforeComma"
			Me.radButNewLineBeforeComma.Size = New Size(136, 17)
			Me.radButNewLineBeforeComma.TabIndex = 1
			Me.radButNewLineBeforeComma.TabStop = True
			Me.radButNewLineBeforeComma.Text = "New line before comma"
			Me.radButNewLineBeforeComma.UseVisualStyleBackColor = True
'			Me.radButNewLineBeforeComma.CheckedChanged += New System.EventHandler(Me.radButNewLineBeforeComma_CheckedChanged)
			' 
			' chBxStartSelectListItemsOnNewLines
			' 
			Me.chBxStartSelectListItemsOnNewLines.AutoSize = True
			Me.chBxStartSelectListItemsOnNewLines.Checked = True
			Me.chBxStartSelectListItemsOnNewLines.CheckState = CheckState.Checked
			Me.chBxStartSelectListItemsOnNewLines.Location = New Point(11, 28)
			Me.chBxStartSelectListItemsOnNewLines.Name = "chBxStartSelectListItemsOnNewLines"
			Me.chBxStartSelectListItemsOnNewLines.Size = New Size(183, 17)
			Me.chBxStartSelectListItemsOnNewLines.TabIndex = 0
			Me.chBxStartSelectListItemsOnNewLines.Text = "Start select list items on new lines"
			Me.chBxStartSelectListItemsOnNewLines.UseVisualStyleBackColor = True
'			Me.chBxStartSelectListItemsOnNewLines.CheckedChanged += New System.EventHandler(Me.chBxStartSelectListItemsOnNewLines_CheckedChanged)
			' 
			' groupBox3
			' 
			Me.groupBox3.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.groupBox3.Controls.Add(Me.label4)
			Me.groupBox3.Controls.Add(Me.chBxStartJoinConditionsOnNewLines)
			Me.groupBox3.Controls.Add(Me.radButStartJoinKeywordsFromNewLines)
			Me.groupBox3.Controls.Add(Me.radButStartDataSourcesFromNewLines)
			Me.groupBox3.Location = New Point(3, 235)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New Size(624, 91)
			Me.groupBox3.TabIndex = 2
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "From clause"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Dock = DockStyle.Right
			Me.label4.Location = New Point(447, 16)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(174, 13)
			Me.label4.TabIndex = 3
			Me.label4.Text = "Layout of the FROM part the query." & vbCrLf
			' 
			' chBxStartJoinConditionsOnNewLines
			' 
			Me.chBxStartJoinConditionsOnNewLines.AutoSize = True
			Me.chBxStartJoinConditionsOnNewLines.Location = New Point(11, 66)
			Me.chBxStartJoinConditionsOnNewLines.Name = "chBxStartJoinConditionsOnNewLines"
			Me.chBxStartJoinConditionsOnNewLines.Size = New Size(180, 17)
			Me.chBxStartJoinConditionsOnNewLines.TabIndex = 2
			Me.chBxStartJoinConditionsOnNewLines.Text = "Start join conditions on new lines"
			Me.chBxStartJoinConditionsOnNewLines.UseVisualStyleBackColor = True
'			Me.chBxStartJoinConditionsOnNewLines.CheckedChanged += New System.EventHandler(Me.chBxStartJoinConditionsOnNewLines_CheckedChanged)
			' 
			' radButStartJoinKeywordsFromNewLines
			' 
			Me.radButStartJoinKeywordsFromNewLines.AutoSize = True
			Me.radButStartJoinKeywordsFromNewLines.Location = New Point(11, 42)
			Me.radButStartJoinKeywordsFromNewLines.Name = "radButStartJoinKeywordsFromNewLines"
			Me.radButStartJoinKeywordsFromNewLines.Size = New Size(202, 17)
			Me.radButStartJoinKeywordsFromNewLines.TabIndex = 1
			Me.radButStartJoinKeywordsFromNewLines.Text = "Start ""JOIN"" keywords from new lines"
			Me.radButStartJoinKeywordsFromNewLines.UseVisualStyleBackColor = True
'			Me.radButStartJoinKeywordsFromNewLines.CheckedChanged += New System.EventHandler(Me.radButStartJoinKeywordsFromNewLines_CheckedChanged)
			' 
			' radButStartDataSourcesFromNewLines
			' 
			Me.radButStartDataSourcesFromNewLines.AutoSize = True
			Me.radButStartDataSourcesFromNewLines.Checked = True
			Me.radButStartDataSourcesFromNewLines.Location = New Point(11, 19)
			Me.radButStartDataSourcesFromNewLines.Name = "radButStartDataSourcesFromNewLines"
			Me.radButStartDataSourcesFromNewLines.Size = New Size(178, 17)
			Me.radButStartDataSourcesFromNewLines.TabIndex = 0
			Me.radButStartDataSourcesFromNewLines.TabStop = True
			Me.radButStartDataSourcesFromNewLines.Text = "Start datasources from new lines"
			Me.radButStartDataSourcesFromNewLines.UseVisualStyleBackColor = True
'			Me.radButStartDataSourcesFromNewLines.CheckedChanged += New System.EventHandler(Me.radButStartDataSourcesFromNewLines_CheckedChanged)
			' 
			' CommonTab
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = SystemColors.Control
			Me.BorderStyle = BorderStyle.FixedSingle
			Me.Controls.Add(Me.groupBox3)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "CommonTab"
			Me.Size = New Size(633, 352)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.upDownPartIndent, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox3.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		Private groupBox1 As GroupBox
		Private label2 As Label
		Private WithEvents upDownPartIndent As NumericUpDown
		Private label1 As Label
		Private WithEvents chBxInsertNewLineAfterPartKeywords As CheckBox
		Private WithEvents chBxStartPartsFromNewLines As CheckBox
		Private groupBox2 As GroupBox
		Private label3 As Label
		Private WithEvents radButNewLineAfterComma As RadioButton
		Private WithEvents radButNewLineBeforeComma As RadioButton
		Private WithEvents chBxStartSelectListItemsOnNewLines As CheckBox
		Private groupBox3 As GroupBox
		Private label4 As Label
		Private WithEvents chBxStartJoinConditionsOnNewLines As CheckBox
		Private WithEvents radButStartJoinKeywordsFromNewLines As RadioButton
		Private WithEvents radButStartDataSourcesFromNewLines As RadioButton
	End Class
End Namespace
