Namespace ConnectionFrames
	Public NotInheritable Partial Class OLEDBConnectionFrame
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
			Me.tbConnectionString = New TextBox()
			Me.label1 = New Label()
			Me.btnBuild = New Button()
			Me.SuspendLayout()
			' 
			' tbConnectionString
			' 
			Me.tbConnectionString.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.tbConnectionString.Location = New Point(3, 32)
			Me.tbConnectionString.Multiline = True
			Me.tbConnectionString.Name = "tbConnectionString"
			Me.tbConnectionString.ScrollBars = ScrollBars.Vertical
			Me.tbConnectionString.Size = New Size(281, 164)
			Me.tbConnectionString.TabIndex = 1
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New Point(3, 8)
			Me.label1.Margin = New Padding(3)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(122, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Enter Connection String:"
			' 
			' btnBuild
			' 
			Me.btnBuild.Location = New Point(197, 3)
			Me.btnBuild.Name = "btnBuild"
			Me.btnBuild.Size = New Size(87, 23)
			Me.btnBuild.TabIndex = 5
			Me.btnBuild.Text = "Build..."
			Me.btnBuild.UseVisualStyleBackColor = True
'			Me.btnBuild.Click += New System.EventHandler(Me.btnBuild_Click)
			' 
			' OLEDBConnectionFrame
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.btnBuild)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.tbConnectionString)
			Me.Name = "OLEDBConnectionFrame"
			Me.Size = New Size(287, 199)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private tbConnectionString As TextBox
		Private label1 As Label
		Private WithEvents btnBuild As Button
	End Class
End Namespace
