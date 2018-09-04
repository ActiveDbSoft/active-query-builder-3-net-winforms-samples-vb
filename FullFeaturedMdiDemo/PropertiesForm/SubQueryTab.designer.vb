Namespace PropertiesForm
	Partial Class SubQueryTab
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
			Me.chBxSameFormatAsMainQuery = New System.Windows.Forms.CheckBox()
			Me.chBxSubQueriesFromNewLines = New System.Windows.Forms.CheckBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.UpDownSubQueryIndent = New System.Windows.Forms.NumericUpDown()
			Me.label1 = New System.Windows.Forms.Label()
			Me.groupBox1.SuspendLayout()
			DirectCast(Me.UpDownSubQueryIndent, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.groupBox1.Controls.Add(Me.chBxSameFormatAsMainQuery)
			Me.groupBox1.Controls.Add(Me.chBxSubQueriesFromNewLines)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.UpDownSubQueryIndent)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Location = New System.Drawing.Point(3, 3)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(754, 171)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Sub-queries format options"
			' 
			' chBxSameFormatAsMainQuery
			' 
			Me.chBxSameFormatAsMainQuery.AutoSize = True
			Me.chBxSameFormatAsMainQuery.Location = New System.Drawing.Point(9, 109)
			Me.chBxSameFormatAsMainQuery.Name = "chBxSameFormatAsMainQuery"
			Me.chBxSameFormatAsMainQuery.Size = New System.Drawing.Size(241, 17)
			Me.chBxSameFormatAsMainQuery.TabIndex = 4
			Me.chBxSameFormatAsMainQuery.Text = "Use the same formatting as for the main query"
			Me.chBxSameFormatAsMainQuery.UseVisualStyleBackColor = True
			AddHandler Me.chBxSameFormatAsMainQuery.CheckedChanged, New System.EventHandler(AddressOf Me.chBxSameFormatAsMainQuery_CheckedChanged)
			' 
			' chBxSubQueriesFromNewLines
			' 
			Me.chBxSubQueriesFromNewLines.AutoSize = True
			Me.chBxSubQueriesFromNewLines.Location = New System.Drawing.Point(9, 76)
			Me.chBxSubQueriesFromNewLines.Name = "chBxSubQueriesFromNewLines"
			Me.chBxSubQueriesFromNewLines.Size = New System.Drawing.Size(172, 17)
			Me.chBxSubQueriesFromNewLines.TabIndex = 3
			Me.chBxSubQueriesFromNewLines.Text = "Start subqueries from new lines"
			Me.chBxSubQueriesFromNewLines.UseVisualStyleBackColor = True
			AddHandler Me.chBxSubQueriesFromNewLines.CheckedChanged, New System.EventHandler(AddressOf Me.chBxSubQueriesFromNewLines_CheckedChanged)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Dock = System.Windows.Forms.DockStyle.Right
			Me.label2.Location = New System.Drawing.Point(508, 16)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(243, 26)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Sub-Queries format options determine the " & vbCr & vbLf & "layout of sub-queries used in expressi" & "ons of query."
			' 
			' UpDownSubQueryIndent
			' 
			Me.UpDownSubQueryIndent.Location = New System.Drawing.Point(143, 21)
			Me.UpDownSubQueryIndent.Name = "UpDownSubQueryIndent"
			Me.UpDownSubQueryIndent.Size = New System.Drawing.Size(80, 20)
			Me.UpDownSubQueryIndent.TabIndex = 1
			Me.UpDownSubQueryIndent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
			AddHandler Me.UpDownSubQueryIndent.ValueChanged, New System.EventHandler(AddressOf Me.UpDownSubQueryIndent_ValueChanged)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(6, 28)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(90, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Sub-query indent:"
			' 
			' SubQueryTab
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "SubQueryTab"
			Me.Size = New System.Drawing.Size(763, 180)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			DirectCast(Me.UpDownSubQueryIndent, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupBox1 As System.Windows.Forms.GroupBox
		Private chBxSameFormatAsMainQuery As System.Windows.Forms.CheckBox
		Private chBxSubQueriesFromNewLines As System.Windows.Forms.CheckBox
		Private label2 As System.Windows.Forms.Label
		Private UpDownSubQueryIndent As System.Windows.Forms.NumericUpDown
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace
