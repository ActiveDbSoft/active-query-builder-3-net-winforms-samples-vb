Namespace PropertiesForm
	Partial Class SqlGenerationPage
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.lblCasing = New System.Windows.Forms.Label()
			Me.cbObjectPrefixSkipping = New System.Windows.Forms.ComboBox()
			Me.cbQuoteAllIdentifiers = New System.Windows.Forms.CheckBox()
			Me.SuspendLayout()
			' 
			' lblCasing
			' 
			Me.lblCasing.Location = New System.Drawing.Point(3, 35)
			Me.lblCasing.Name = "lblCasing"
			Me.lblCasing.Size = New System.Drawing.Size(164, 17)
			Me.lblCasing.TabIndex = 10
			Me.lblCasing.Text = "Prefix skipping"
			Me.lblCasing.UseCompatibleTextRendering = True
			' 
			' cbObjectPrefixSkipping
			' 
			Me.cbObjectPrefixSkipping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbObjectPrefixSkipping.FormattingEnabled = True
			Me.cbObjectPrefixSkipping.Location = New System.Drawing.Point(195, 31)
			Me.cbObjectPrefixSkipping.Name = "cbObjectPrefixSkipping"
			Me.cbObjectPrefixSkipping.Size = New System.Drawing.Size(150, 21)
			Me.cbObjectPrefixSkipping.TabIndex = 9
			AddHandler Me.cbObjectPrefixSkipping.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbObjectPrefixSkipping_SelectedIndexChanged)
			' 
			' cbQuoteAllIdentifiers
			' 
			Me.cbQuoteAllIdentifiers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.cbQuoteAllIdentifiers.Location = New System.Drawing.Point(3, 3)
			Me.cbQuoteAllIdentifiers.Name = "cbQuoteAllIdentifiers"
			Me.cbQuoteAllIdentifiers.Size = New System.Drawing.Size(207, 26)
			Me.cbQuoteAllIdentifiers.TabIndex = 8
			Me.cbQuoteAllIdentifiers.Text = "Quote all identifiers"
			Me.cbQuoteAllIdentifiers.UseCompatibleTextRendering = True
			Me.cbQuoteAllIdentifiers.UseVisualStyleBackColor = True
			AddHandler Me.cbQuoteAllIdentifiers.CheckedChanged, New System.EventHandler(AddressOf Me.cbQuoteAllIdentifiers_CheckedChanged)
			' 
			' SqlGenerationPage
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.lblCasing)
			Me.Controls.Add(Me.cbObjectPrefixSkipping)
			Me.Controls.Add(Me.cbQuoteAllIdentifiers)
			Me.Name = "SqlGenerationPage"
			Me.Size = New System.Drawing.Size(357, 69)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lblCasing As System.Windows.Forms.Label
		Private cbObjectPrefixSkipping As System.Windows.Forms.ComboBox
		Private cbQuoteAllIdentifiers As System.Windows.Forms.CheckBox
	End Class
End Namespace
