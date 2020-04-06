Namespace PropertiesForm
	Partial Public Class SqlGenerationPage
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
			Me.lblCasing = New Label()
			Me.cbObjectPrefixSkipping = New ComboBox()
			Me.cbQuoteAllIdentifiers = New CheckBox()
			Me.SuspendLayout()
			' 
			' lblCasing
			' 
			Me.lblCasing.Location = New Point(3, 35)
			Me.lblCasing.Name = "lblCasing"
			Me.lblCasing.Size = New Size(164, 17)
			Me.lblCasing.TabIndex = 10
			Me.lblCasing.Text = "Prefix skipping"
			Me.lblCasing.UseCompatibleTextRendering = True
			' 
			' cbObjectPrefixSkipping
			' 
			Me.cbObjectPrefixSkipping.DropDownStyle = ComboBoxStyle.DropDownList
			Me.cbObjectPrefixSkipping.FormattingEnabled = True
			Me.cbObjectPrefixSkipping.Location = New Point(195, 31)
			Me.cbObjectPrefixSkipping.Name = "cbObjectPrefixSkipping"
			Me.cbObjectPrefixSkipping.Size = New Size(150, 21)
			Me.cbObjectPrefixSkipping.TabIndex = 9
'			Me.cbObjectPrefixSkipping.SelectedIndexChanged += New System.EventHandler(Me.cbObjectPrefixSkipping_SelectedIndexChanged)
			' 
			' cbQuoteAllIdentifiers
			' 
			Me.cbQuoteAllIdentifiers.CheckAlign = ContentAlignment.MiddleRight
			Me.cbQuoteAllIdentifiers.Location = New Point(3, 3)
			Me.cbQuoteAllIdentifiers.Name = "cbQuoteAllIdentifiers"
			Me.cbQuoteAllIdentifiers.Size = New Size(207, 26)
			Me.cbQuoteAllIdentifiers.TabIndex = 8
			Me.cbQuoteAllIdentifiers.Text = "Quote all identifiers"
			Me.cbQuoteAllIdentifiers.UseCompatibleTextRendering = True
			Me.cbQuoteAllIdentifiers.UseVisualStyleBackColor = True
'			Me.cbQuoteAllIdentifiers.CheckedChanged += New System.EventHandler(Me.cbQuoteAllIdentifiers_CheckedChanged)
			' 
			' SqlGenerationPage
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.lblCasing)
			Me.Controls.Add(Me.cbObjectPrefixSkipping)
			Me.Controls.Add(Me.cbQuoteAllIdentifiers)
			Me.Name = "SqlGenerationPage"
			Me.Size = New Size(357, 69)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private lblCasing As Label
		Private WithEvents cbObjectPrefixSkipping As ComboBox
		Private WithEvents cbQuoteAllIdentifiers As CheckBox
	End Class
End Namespace
