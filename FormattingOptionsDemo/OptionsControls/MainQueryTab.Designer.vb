Namespace OptionsControls
    Partial Public Class MainQueryTab
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
            Me.label5 = New Label()
            Me.label4 = New Label()
            Me.chBxParenthesizeEachSingleCondition = New CheckBox()
            Me.chBxParenthesizeConditionsWithinAndOperators = New CheckBox()
            Me.chBxEnableDynamicRightMargin = New CheckBox()
            Me.chBxEnableDynamicIndents = New CheckBox()
            Me.label3 = New Label()
            Me.cmbBoxKeyWordsCase = New ComboBox()
            Me.upDownMaxCharsInLine = New NumericUpDown()
            Me.label2 = New Label()
            Me.label1 = New Label()
            Me.chBxEnableWordWrap = New CheckBox()
            Me.groupBox1.SuspendLayout()
            CType(Me.upDownMaxCharsInLine, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
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
            Me.groupBox1.Location = New Point(3, 3)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New Size(715, 390)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "General SQL Formatting options"
            ' 
            ' label5
            ' 
            Me.label5.AutoSize = True
            Me.label5.Location = New Point(259, 236)
            Me.label5.Name = "label5"
            Me.label5.Size = New Size(310, 39)
            Me.label5.TabIndex = 11
            Me.label5.Text = "Example:" & vbCrLf & "(Condition1) AND (condition2) OR (Condition3) AND (Condition4)" & vbCrLf & vbCrLf
            ' 
            ' label4
            ' 
            Me.label4.AutoSize = True
            Me.label4.Location = New Point(259, 194)
            Me.label4.Name = "label4"
            Me.label4.Size = New Size(298, 26)
            Me.label4.TabIndex = 10
            Me.label4.Text = "Example:" & vbCrLf & "(Condition1 AND condition2) OR (Condition3 AND Condition4)" & vbCrLf
            ' 
            ' chBxParenthesizeEachSingleCondition
            ' 
            Me.chBxParenthesizeEachSingleCondition.AutoSize = True
            Me.chBxParenthesizeEachSingleCondition.Location = New Point(6, 236)
            Me.chBxParenthesizeEachSingleCondition.Name = "chBxParenthesizeEachSingleCondition"
            Me.chBxParenthesizeEachSingleCondition.Size = New Size(190, 17)
            Me.chBxParenthesizeEachSingleCondition.TabIndex = 9
            Me.chBxParenthesizeEachSingleCondition.Text = "Parenthesize each single condition"
            Me.chBxParenthesizeEachSingleCondition.UseVisualStyleBackColor = True
'            Me.chBxParenthesizeEachSingleCondition.CheckedChanged += New System.EventHandler(Me.chBxParenthesizeEachSingleCondition_CheckedChanged)
            ' 
            ' chBxParenthesizeConditionsWithinAndOperators
            ' 
            Me.chBxParenthesizeConditionsWithinAndOperators.AutoSize = True
            Me.chBxParenthesizeConditionsWithinAndOperators.Checked = True
            Me.chBxParenthesizeConditionsWithinAndOperators.CheckState = CheckState.Checked
            Me.chBxParenthesizeConditionsWithinAndOperators.Location = New Point(6, 194)
            Me.chBxParenthesizeConditionsWithinAndOperators.Name = "chBxParenthesizeConditionsWithinAndOperators"
            Me.chBxParenthesizeConditionsWithinAndOperators.Size = New Size(241, 17)
            Me.chBxParenthesizeConditionsWithinAndOperators.TabIndex = 8
            Me.chBxParenthesizeConditionsWithinAndOperators.Text = "Parenthesize conditions within AND operators"
            Me.chBxParenthesizeConditionsWithinAndOperators.UseVisualStyleBackColor = True
'            Me.chBxParenthesizeConditionsWithinAndOperators.CheckedChanged += New System.EventHandler(Me.chBxParenthesizeConditionsWithinAndOperators_CheckedChanged)
            ' 
            ' chBxEnableDynamicRightMargin
            ' 
            Me.chBxEnableDynamicRightMargin.AutoSize = True
            Me.chBxEnableDynamicRightMargin.Location = New Point(6, 159)
            Me.chBxEnableDynamicRightMargin.Name = "chBxEnableDynamicRightMargin"
            Me.chBxEnableDynamicRightMargin.Size = New Size(158, 17)
            Me.chBxEnableDynamicRightMargin.TabIndex = 7
            Me.chBxEnableDynamicRightMargin.Text = "Enable dynamic right margin"
            Me.chBxEnableDynamicRightMargin.UseVisualStyleBackColor = True
'            Me.chBxEnableDynamicRightMargin.CheckedChanged += New System.EventHandler(Me.chBxEnableDynamicRightMargin_CheckedChanged)
            ' 
            ' chBxEnableDynamicIndents
            ' 
            Me.chBxEnableDynamicIndents.AutoSize = True
            Me.chBxEnableDynamicIndents.Location = New Point(6, 125)
            Me.chBxEnableDynamicIndents.Name = "chBxEnableDynamicIndents"
            Me.chBxEnableDynamicIndents.Size = New Size(138, 17)
            Me.chBxEnableDynamicIndents.TabIndex = 6
            Me.chBxEnableDynamicIndents.Text = "Enable dynamic indents"
            Me.chBxEnableDynamicIndents.UseVisualStyleBackColor = True
'            Me.chBxEnableDynamicIndents.CheckedChanged += New System.EventHandler(Me.chBxEnableDynamicIndents_CheckedChanged)
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Dock = DockStyle.Right
            Me.label3.Location = New Point(351, 16)
            Me.label3.Name = "label3"
            Me.label3.Size = New Size(361, 13)
            Me.label3.TabIndex = 5
            Me.label3.Text = "These options affect on whole SQL query text (main query and sub-queries)"
            ' 
            ' cmbBoxKeyWordsCase
            ' 
            Me.cmbBoxKeyWordsCase.FormattingEnabled = True
            Me.cmbBoxKeyWordsCase.Items.AddRange(New Object() { "First Upper", "UpperCase", "LowerCase"})
            Me.cmbBoxKeyWordsCase.Location = New Point(171, 76)
            Me.cmbBoxKeyWordsCase.Name = "cmbBoxKeyWordsCase"
            Me.cmbBoxKeyWordsCase.Size = New Size(120, 21)
            Me.cmbBoxKeyWordsCase.TabIndex = 4
            Me.cmbBoxKeyWordsCase.Text = "FirstUpper"
'            Me.cmbBoxKeyWordsCase.SelectedIndexChanged += New System.EventHandler(Me.cmbBoxKeyWordsCase_SelectedIndexChanged)
            ' 
            ' upDownMaxCharsInLine
            ' 
            Me.upDownMaxCharsInLine.Location = New Point(171, 45)
            Me.upDownMaxCharsInLine.Maximum = New Decimal(New Integer() { 1000, 0, 0, 0})
            Me.upDownMaxCharsInLine.Name = "upDownMaxCharsInLine"
            Me.upDownMaxCharsInLine.Size = New Size(120, 20)
            Me.upDownMaxCharsInLine.TabIndex = 3
            Me.upDownMaxCharsInLine.TextAlign = HorizontalAlignment.Right
            Me.upDownMaxCharsInLine.Value = New Decimal(New Integer() { 120, 0, 0, 0})
'            Me.upDownMaxCharsInLine.ValueChanged += New System.EventHandler(Me.upDownMaxCharsInLine_ValueChanged)
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New Point(28, 76)
            Me.label2.Name = "label2"
            Me.label2.Size = New Size(82, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Keywords case:"
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New Point(28, 47)
            Me.label1.Name = "label1"
            Me.label1.Size = New Size(137, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Maximum characters in line:"
            ' 
            ' chBxEnableWordWrap
            ' 
            Me.chBxEnableWordWrap.AutoSize = True
            Me.chBxEnableWordWrap.Checked = True
            Me.chBxEnableWordWrap.CheckState = CheckState.Checked
            Me.chBxEnableWordWrap.Location = New Point(6, 19)
            Me.chBxEnableWordWrap.Name = "chBxEnableWordWrap"
            Me.chBxEnableWordWrap.Size = New Size(111, 17)
            Me.chBxEnableWordWrap.TabIndex = 0
            Me.chBxEnableWordWrap.Text = "Enable word wrap"
            Me.chBxEnableWordWrap.UseVisualStyleBackColor = True
'            Me.chBxEnableWordWrap.CheckedChanged += New System.EventHandler(Me.chBxEnableWordWrap_CheckedChanged)
            ' 
            ' MainQueryTab
            ' 
            Me.AutoScaleDimensions = New SizeF(6F, 13F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BorderStyle = BorderStyle.FixedSingle
            Me.Controls.Add(Me.groupBox1)
            Me.Name = "MainQueryTab"
            Me.Size = New Size(728, 400)
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.upDownMaxCharsInLine, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private groupBox1 As GroupBox
        Private label5 As Label
        Private label4 As Label
        Private WithEvents chBxParenthesizeEachSingleCondition As CheckBox
        Private WithEvents chBxParenthesizeConditionsWithinAndOperators As CheckBox
        Private WithEvents chBxEnableDynamicRightMargin As CheckBox
        Private WithEvents chBxEnableDynamicIndents As CheckBox
        Private label3 As Label
        Private WithEvents cmbBoxKeyWordsCase As ComboBox
        Private WithEvents upDownMaxCharsInLine As NumericUpDown
        Private label2 As Label
        Private label1 As Label
        Private WithEvents chBxEnableWordWrap As CheckBox
    End Class
End Namespace
