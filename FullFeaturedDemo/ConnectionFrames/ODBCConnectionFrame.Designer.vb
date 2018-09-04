Namespace ConnectionFrames
	NotInheritable Partial Class ODBCConnectionFrame
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
			Me.tbConnectionString = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' tbConnectionString
			' 
			Me.tbConnectionString.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbConnectionString.Location = New System.Drawing.Point(3, 22)
			Me.tbConnectionString.Multiline = True
			Me.tbConnectionString.Name = "tbConnectionString"
			Me.tbConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
			Me.tbConnectionString.Size = New System.Drawing.Size(281, 174)
			Me.tbConnectionString.TabIndex = 0
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(3, 3)
			Me.label1.Margin = New System.Windows.Forms.Padding(3)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(119, 13)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Enter connection string:"
			' 
			' ODBCConnectionFrame
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.tbConnectionString)
			Me.Name = "ODBCConnectionFrame"
			Me.Size = New System.Drawing.Size(287, 199)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private tbConnectionString As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label

	End Class
End Namespace
