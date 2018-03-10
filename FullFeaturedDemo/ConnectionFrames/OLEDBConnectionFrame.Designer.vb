Namespace ConnectionFrames
	NotInheritable Partial Class OLEDBConnectionFrame
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
			Me.btnBuild = New System.Windows.Forms.Button()
			Me.btnTest = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' tbConnectionString
			' 
			Me.tbConnectionString.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbConnectionString.Location = New System.Drawing.Point(3, 32)
			Me.tbConnectionString.Multiline = True
			Me.tbConnectionString.Name = "tbConnectionString"
			Me.tbConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
			Me.tbConnectionString.Size = New System.Drawing.Size(281, 136)
			Me.tbConnectionString.TabIndex = 1
			AddHandler Me.tbConnectionString.TextChanged, New System.EventHandler(AddressOf Me.tbConnectionString_TextChanged)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(3, 8)
			Me.label1.Margin = New System.Windows.Forms.Padding(3)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(122, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Enter Connection String:"
			' 
			' btnBuild
			' 
			Me.btnBuild.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.btnBuild.Location = New System.Drawing.Point(236, 3)
			Me.btnBuild.Name = "btnBuild"
			Me.btnBuild.Size = New System.Drawing.Size(48, 23)
			Me.btnBuild.TabIndex = 5
			Me.btnBuild.Text = "Build..."
			Me.btnBuild.UseVisualStyleBackColor = True
			AddHandler Me.btnBuild.Click, New System.EventHandler(AddressOf Me.btnBuild_Click)
			' 
			' btnTest
			' 
			Me.btnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.btnTest.Enabled = False
			Me.btnTest.Location = New System.Drawing.Point(86, 173)
			Me.btnTest.Name = "btnTest"
			Me.btnTest.Size = New System.Drawing.Size(198, 23)
			Me.btnTest.TabIndex = 6
			Me.btnTest.Text = "Test connection and detect syntax"
			Me.btnTest.UseVisualStyleBackColor = True
			AddHandler Me.btnTest.Click, New System.EventHandler(AddressOf Me.btnTest_Click)
			' 
			' OLEDBConnectionFrame
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.btnTest)
			Me.Controls.Add(Me.btnBuild)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.tbConnectionString)
			Me.Name = "OLEDBConnectionFrame"
			Me.Size = New System.Drawing.Size(287, 199)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private tbConnectionString As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private btnBuild As System.Windows.Forms.Button
		Private btnTest As System.Windows.Forms.Button
	End Class
End Namespace
