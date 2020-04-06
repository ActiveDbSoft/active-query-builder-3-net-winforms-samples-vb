	Partial Public Class NoConnectionLabel
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
			Me.label1 = New Label()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.BorderStyle = BorderStyle.FixedSingle
			Me.label1.Dock = DockStyle.Fill
			Me.label1.Location = New Point(0, 0)
			Me.label1.Name = "label1"
			Me.label1.Padding = New Padding(50, 10, 50, 10)
			Me.label1.Size = New Size(179, 35)
			Me.label1.TabIndex = 0
			Me.label1.Text = "No connection"
			' 
			' NoConnectionLabel
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoSize = True
			Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
			Me.Controls.Add(Me.label1)
			Me.Name = "NoConnectionLabel"
			Me.Size = New Size(179, 35)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As Label
	End Class
