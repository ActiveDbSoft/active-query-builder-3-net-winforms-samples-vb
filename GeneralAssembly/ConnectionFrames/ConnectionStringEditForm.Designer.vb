Namespace ConnectionFrames
	Partial Public Class ConnectionStringEditForm
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
			Me.btnOk = New Button()
			Me.btnCancel = New Button()
			Me.tbConnectionString = New TextBox()
			Me.SuspendLayout()
			' 
			' btnOk
			' 
			Me.btnOk.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.btnOk.DialogResult = DialogResult.OK
			Me.btnOk.Location = New Point(321, 337)
			Me.btnOk.Name = "btnOk"
			Me.btnOk.Size = New Size(75, 23)
			Me.btnOk.TabIndex = 1
			Me.btnOk.Text = "OK"
			Me.btnOk.UseVisualStyleBackColor = True
			' 
			' btnCancel
			' 
			Me.btnCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.btnCancel.DialogResult = DialogResult.Cancel
			Me.btnCancel.Location = New Point(402, 337)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(75, 23)
			Me.btnCancel.TabIndex = 2
			Me.btnCancel.Text = "Cancel"
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' tbConnectionString
			' 
			Me.tbConnectionString.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.tbConnectionString.Location = New Point(12, 12)
			Me.tbConnectionString.Multiline = True
			Me.tbConnectionString.Name = "tbConnectionString"
			Me.tbConnectionString.ScrollBars = ScrollBars.Both
			Me.tbConnectionString.Size = New Size(465, 319)
			Me.tbConnectionString.TabIndex = 0
			' 
			' ConnectionStringEditForm
			' 
			Me.AcceptButton = Me.btnOk
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Size(489, 372)
			Me.Controls.Add(Me.tbConnectionString)
			Me.Controls.Add(Me.btnOk)
			Me.Controls.Add(Me.btnCancel)
			Me.Name = "ConnectionStringEditForm"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Connection String"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private btnOk As Button
		Private btnCancel As Button
		Private tbConnectionString As TextBox
	End Class
End Namespace