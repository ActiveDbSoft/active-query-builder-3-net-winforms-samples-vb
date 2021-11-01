Namespace OptionsControls
	Partial Public Class SubQueryTab
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
			Me.chBxSameFormatAsMainQuery = New CheckBox()
			Me.chBxSubQueriesFromNewLines = New CheckBox()
			Me.label2 = New Label()
			Me.UpDownSubQueryIndent = New NumericUpDown()
			Me.label1 = New Label()
			Me.groupBox1.SuspendLayout()
			CType(Me.UpDownSubQueryIndent, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.groupBox1.Controls.Add(Me.chBxSameFormatAsMainQuery)
			Me.groupBox1.Controls.Add(Me.chBxSubQueriesFromNewLines)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.UpDownSubQueryIndent)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Location = New Point(3, 3)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New Size(754, 171)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Sub-queries format options"
			' 
			' chBxSameFormatAsMainQuery
			' 
			Me.chBxSameFormatAsMainQuery.AutoSize = True
			Me.chBxSameFormatAsMainQuery.Location = New Point(9, 109)
			Me.chBxSameFormatAsMainQuery.Name = "chBxSameFormatAsMainQuery"
			Me.chBxSameFormatAsMainQuery.Size = New Size(241, 17)
			Me.chBxSameFormatAsMainQuery.TabIndex = 4
			Me.chBxSameFormatAsMainQuery.Text = "Use the same formatting as for the main query"
			Me.chBxSameFormatAsMainQuery.UseVisualStyleBackColor = True
'			Me.chBxSameFormatAsMainQuery.CheckedChanged += New System.EventHandler(Me.chBxSameFormatAsMainQuery_CheckedChanged)
			' 
			' chBxSubQueriesFromNewLines
			' 
			Me.chBxSubQueriesFromNewLines.AutoSize = True
			Me.chBxSubQueriesFromNewLines.Location = New Point(9, 76)
			Me.chBxSubQueriesFromNewLines.Name = "chBxSubQueriesFromNewLines"
			Me.chBxSubQueriesFromNewLines.Size = New Size(172, 17)
			Me.chBxSubQueriesFromNewLines.TabIndex = 3
			Me.chBxSubQueriesFromNewLines.Text = "Start subqueries from new lines"
			Me.chBxSubQueriesFromNewLines.UseVisualStyleBackColor = True
'			Me.chBxSubQueriesFromNewLines.CheckedChanged += New System.EventHandler(Me.chBxSubQueriesFromNewLines_CheckedChanged)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Dock = DockStyle.Right
			Me.label2.Location = New Point(311, 16)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(440, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Sub-Queries format options determine the layout of sub-queries used in expression" & "s of query."
			' 
			' UpDownSubQueryIndent
			' 
			Me.UpDownSubQueryIndent.Location = New Point(143, 21)
			Me.UpDownSubQueryIndent.Name = "UpDownSubQueryIndent"
			Me.UpDownSubQueryIndent.Size = New Size(80, 20)
			Me.UpDownSubQueryIndent.TabIndex = 1
			Me.UpDownSubQueryIndent.TextAlign = HorizontalAlignment.Right
'			Me.UpDownSubQueryIndent.ValueChanged += New System.EventHandler(Me.UpDownSubQueryIndent_ValueChanged)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New Point(6, 28)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(90, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Sub-query indent:"
			' 
			' SubQueryTab
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BorderStyle = BorderStyle.FixedSingle
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "SubQueryTab"
			Me.Size = New Size(763, 180)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.UpDownSubQueryIndent, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupBox1 As GroupBox
		Private WithEvents chBxSameFormatAsMainQuery As CheckBox
		Private WithEvents chBxSubQueriesFromNewLines As CheckBox
		Private label2 As Label
		Private WithEvents UpDownSubQueryIndent As NumericUpDown
		Private label1 As Label
	End Class
End Namespace
