Namespace Forms.QueryInformationForms
	Partial Public Class QueryStatisticsForm
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.textBox = New TextBox()
			Me.buttonOk = New Button()
			Me.SuspendLayout()
			' 
			' textBox
			' 
			Me.textBox.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.textBox.Location = New Point(12, 12)
			Me.textBox.Multiline = True
			Me.textBox.Name = "textBox"
			Me.textBox.ReadOnly = True
			Me.textBox.ScrollBars = ScrollBars.Both
			Me.textBox.Size = New Size(486, 380)
			Me.textBox.TabIndex = 3
			Me.textBox.WordWrap = False
			' 
			' buttonOk
			' 
			Me.buttonOk.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.buttonOk.DialogResult = DialogResult.OK
			Me.buttonOk.Location = New Point(423, 398)
			Me.buttonOk.Name = "buttonOk"
			Me.buttonOk.Size = New Size(75, 23)
			Me.buttonOk.TabIndex = 2
			Me.buttonOk.Text = "OK"
			Me.buttonOk.UseVisualStyleBackColor = True
			' 
			' QueryStatisticsForm
			' 
			Me.AcceptButton = Me.buttonOk
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.buttonOk
			Me.ClientSize = New Size(510, 433)
			Me.Controls.Add(Me.textBox)
			Me.Controls.Add(Me.buttonOk)
			Me.Name = "QueryStatisticsForm"
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Query Statistics"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Public textBox As TextBox
		Private buttonOk As Button
	End Class
End Namespace