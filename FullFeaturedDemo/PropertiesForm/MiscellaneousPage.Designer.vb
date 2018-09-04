Partial Class MiscellaneousPage
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
		Me.label7 = New System.Windows.Forms.Label()
		Me.comboLinksStyle = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		' 
		' label7
		' 
		Me.label7.Location = New System.Drawing.Point(3, 6)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(192, 17)
		Me.label7.TabIndex = 8
		Me.label7.Text = "Diagram Links Style"
		Me.label7.UseCompatibleTextRendering = True
		' 
		' comboLinksStyle
		' 
		Me.comboLinksStyle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.comboLinksStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboLinksStyle.FormattingEnabled = True
		Me.comboLinksStyle.Location = New System.Drawing.Point(201, 3)
		Me.comboLinksStyle.Name = "comboLinksStyle"
		Me.comboLinksStyle.Size = New System.Drawing.Size(159, 21)
		Me.comboLinksStyle.TabIndex = 7
		' 
		' MiscellaneousPage
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.comboLinksStyle)
		Me.Name = "MiscellaneousPage"
		Me.Size = New System.Drawing.Size(363, 155)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private label7 As System.Windows.Forms.Label
	Private comboLinksStyle As System.Windows.Forms.ComboBox
End Class
