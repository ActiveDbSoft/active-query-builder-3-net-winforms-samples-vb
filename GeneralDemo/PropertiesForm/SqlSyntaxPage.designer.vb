Partial Class SqlSyntaxPage
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
		Me.cbQuoteAllIdentifiers = New System.Windows.Forms.CheckBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.textEndQuotationSymbol = New System.Windows.Forms.TextBox()
		Me.comboSqlDialect = New System.Windows.Forms.ComboBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.comboIdentCaseSens = New System.Windows.Forms.ComboBox()
		Me.textBeginQuotationSymbol = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		' 
		' cbQuoteAllIdentifiers
		' 
		Me.cbQuoteAllIdentifiers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cbQuoteAllIdentifiers.Location = New System.Drawing.Point(3, 114)
		Me.cbQuoteAllIdentifiers.Name = "cbQuoteAllIdentifiers"
		Me.cbQuoteAllIdentifiers.Size = New System.Drawing.Size(212, 21)
		Me.cbQuoteAllIdentifiers.TabIndex = 14
		Me.cbQuoteAllIdentifiers.Text = "Quote All Identifiers"
		Me.cbQuoteAllIdentifiers.UseCompatibleTextRendering = True
		Me.cbQuoteAllIdentifiers.UseVisualStyleBackColor = True
		' 
		' label5
		' 
		Me.label5.Location = New System.Drawing.Point(199, 86)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(66, 17)
		Me.label5.TabIndex = 13
		Me.label5.Text = "End:"
		Me.label5.UseCompatibleTextRendering = True
		' 
		' textEndQuotationSymbol
		' 
		Me.textEndQuotationSymbol.Location = New System.Drawing.Point(271, 83)
		Me.textEndQuotationSymbol.Name = "textEndQuotationSymbol"
		Me.textEndQuotationSymbol.[ReadOnly] = True
		Me.textEndQuotationSymbol.Size = New System.Drawing.Size(70, 20)
		Me.textEndQuotationSymbol.TabIndex = 18
		' 
		' comboSqlDialect
		' 
		Me.comboSqlDialect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comboSqlDialect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboSqlDialect.FormattingEnabled = True
		Me.comboSqlDialect.Location = New System.Drawing.Point(199, 3)
		Me.comboSqlDialect.Name = "comboSqlDialect"
		Me.comboSqlDialect.Size = New System.Drawing.Size(198, 21)
		Me.comboSqlDialect.TabIndex = 15
		' 
		' label4
		' 
		Me.label4.Location = New System.Drawing.Point(199, 60)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(66, 17)
		Me.label4.TabIndex = 9
		Me.label4.Text = "Start:"
		Me.label4.UseCompatibleTextRendering = True
		' 
		' label1
		' 
		Me.label1.Location = New System.Drawing.Point(3, 6)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(190, 17)
		Me.label1.TabIndex = 10
		Me.label1.Text = "SQL Dialect:"
		Me.label1.UseCompatibleTextRendering = True
		' 
		' label3
		' 
		Me.label3.Location = New System.Drawing.Point(3, 60)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(190, 17)
		Me.label3.TabIndex = 11
		Me.label3.Text = "Identifier Quotation Symbols:"
		Me.label3.UseCompatibleTextRendering = True
		' 
		' comboIdentCaseSens
		' 
		Me.comboIdentCaseSens.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comboIdentCaseSens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboIdentCaseSens.DropDownWidth = 300
		Me.comboIdentCaseSens.FormattingEnabled = True
		Me.comboIdentCaseSens.Location = New System.Drawing.Point(199, 30)
		Me.comboIdentCaseSens.Name = "comboIdentCaseSens"
		Me.comboIdentCaseSens.Size = New System.Drawing.Size(198, 21)
		Me.comboIdentCaseSens.TabIndex = 16
		' 
		' textBeginQuotationSymbol
		' 
		Me.textBeginQuotationSymbol.Location = New System.Drawing.Point(271, 57)
		Me.textBeginQuotationSymbol.Name = "textBeginQuotationSymbol"
		Me.textBeginQuotationSymbol.[ReadOnly] = True
		Me.textBeginQuotationSymbol.Size = New System.Drawing.Size(70, 20)
		Me.textBeginQuotationSymbol.TabIndex = 12
		' 
		' label2
		' 
		Me.label2.Location = New System.Drawing.Point(3, 33)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(190, 17)
		Me.label2.TabIndex = 17
		Me.label2.Text = "Identifiers Case Sensitivity:"
		Me.label2.UseCompatibleTextRendering = True
		' 
		' SqlSyntaxPage
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.cbQuoteAllIdentifiers)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.textEndQuotationSymbol)
		Me.Controls.Add(Me.comboSqlDialect)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.comboIdentCaseSens)
		Me.Controls.Add(Me.textBeginQuotationSymbol)
		Me.Controls.Add(Me.label2)
		Me.Name = "SqlSyntaxPage"
		Me.Size = New System.Drawing.Size(400, 146)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private cbQuoteAllIdentifiers As System.Windows.Forms.CheckBox
	Private label5 As System.Windows.Forms.Label
	Private textEndQuotationSymbol As System.Windows.Forms.TextBox
	Private comboSqlDialect As System.Windows.Forms.ComboBox
	Private label4 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private comboIdentCaseSens As System.Windows.Forms.ComboBox
	Private textBeginQuotationSymbol As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
End Class
