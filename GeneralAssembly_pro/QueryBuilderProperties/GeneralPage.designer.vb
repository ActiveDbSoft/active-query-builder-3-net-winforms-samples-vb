Namespace QueryBuilderProperties
    Partial Friend Class GeneralPage
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing


        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.label12 = New Label()
            Me.updownRightMargin = New NumericUpDown()
            Me.cbWordWrap = New CheckBox()
            Me.comboKeywordsCasing = New ComboBox()
            Me.lblCasing = New Label()
            CType(Me.updownRightMargin, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' label12
            ' 
            Me.label12.Location = New Point(3, 35)
            Me.label12.Name = "label12"
            Me.label12.Size = New Size(164, 17)
            Me.label12.TabIndex = 5
            Me.label12.Text = "Maximum characters in line"
            Me.label12.UseCompatibleTextRendering = True
            ' 
            ' updownRightMargin
            ' 
            Me.updownRightMargin.Location = New Point(196, 33)
            Me.updownRightMargin.Maximum = New Decimal(New Integer() { 1000, 0, 0, 0})
            Me.updownRightMargin.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
            Me.updownRightMargin.Name = "updownRightMargin"
            Me.updownRightMargin.Size = New Size(45, 20)
            Me.updownRightMargin.TabIndex = 1
            Me.updownRightMargin.Value = New Decimal(New Integer() { 80, 0, 0, 0})
            ' 
            ' cbWordWrap
            ' 
            Me.cbWordWrap.CheckAlign = ContentAlignment.MiddleRight
            Me.cbWordWrap.Location = New Point(3, 3)
            Me.cbWordWrap.Name = "cbWordWrap"
            Me.cbWordWrap.Size = New Size(207, 26)
            Me.cbWordWrap.TabIndex = 0
            Me.cbWordWrap.Text = "Enable word wrap"
            Me.cbWordWrap.UseCompatibleTextRendering = True
            Me.cbWordWrap.UseVisualStyleBackColor = True
            ' 
            ' comboKeywordsCasing
            ' 
            Me.comboKeywordsCasing.DropDownStyle = ComboBoxStyle.DropDownList
            Me.comboKeywordsCasing.FormattingEnabled = True
            Me.comboKeywordsCasing.Location = New Point(196, 63)
            Me.comboKeywordsCasing.Name = "comboKeywordsCasing"
            Me.comboKeywordsCasing.Size = New Size(155, 21)
            Me.comboKeywordsCasing.TabIndex = 2
            ' 
            ' lblCasing
            ' 
            Me.lblCasing.Location = New Point(3, 66)
            Me.lblCasing.Name = "lblCasing"
            Me.lblCasing.Size = New Size(164, 17)
            Me.lblCasing.TabIndex = 7
            Me.lblCasing.Text = "Keywords casing"
            Me.lblCasing.UseCompatibleTextRendering = True
            ' 
            ' GeneralPage
            ' 
            Me.AutoScaleDimensions = New SizeF(6F, 13F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.lblCasing)
            Me.Controls.Add(Me.comboKeywordsCasing)
            Me.Controls.Add(Me.label12)
            Me.Controls.Add(Me.updownRightMargin)
            Me.Controls.Add(Me.cbWordWrap)
            Me.Name = "GeneralPage"
            Me.Size = New Size(380, 93)
            CType(Me.updownRightMargin, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private label12 As Label
        Private updownRightMargin As NumericUpDown
        Private cbWordWrap As CheckBox
        Private comboKeywordsCasing As ComboBox
        Private lblCasing As Label
    End Class
End Namespace
