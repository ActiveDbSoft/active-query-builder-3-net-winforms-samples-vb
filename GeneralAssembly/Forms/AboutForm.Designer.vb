Namespace Forms
	Partial Public Class AboutForm
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
			Me.label1 = New Label()
			Me.lblQueryBuilderVersion = New Label()
			Me.label3 = New Label()
			Me.bClose = New Button()
			Me.linkHome = New LinkLabel()
			Me.linkLabel1 = New LinkLabel()
			Me.label4 = New Label()
			Me.lblDemoVersion = New Label()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Location = New Point(12, 32)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(143, 19)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Demo Application"
			' 
			' lblQueryBuilderVersion
			' 
			Me.lblQueryBuilderVersion.Location = New Point(164, 9)
			Me.lblQueryBuilderVersion.Name = "lblQueryBuilderVersion"
			Me.lblQueryBuilderVersion.Size = New Size(217, 13)
			Me.lblQueryBuilderVersion.TabIndex = 4
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New Point(12, 61)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(336, 13)
			Me.label3.TabIndex = 7
			Me.label3.Text = "Copyright � 2008-2021 Active Database Software. All rights reserved."
			' 
			' bClose
			' 
			Me.bClose.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.bClose.DialogResult = DialogResult.OK
			Me.bClose.Location = New Point(306, 119)
			Me.bClose.Name = "bClose"
			Me.bClose.Size = New Size(75, 23)
			Me.bClose.TabIndex = 2
			Me.bClose.Text = "Close"
			Me.bClose.UseVisualStyleBackColor = True
			' 
			' linkHome
			' 
			Me.linkHome.AutoSize = True
			Me.linkHome.Location = New Point(13, 82)
			Me.linkHome.Name = "linkHome"
			Me.linkHome.Size = New Size(143, 13)
			Me.linkHome.TabIndex = 0
			Me.linkHome.TabStop = True
			Me.linkHome.Text = "www.activequerybuilder.com"
'			Me.linkHome.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkHome_LinkClicked)
			' 
			' linkLabel1
			' 
			Me.linkLabel1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
			Me.linkLabel1.AutoSize = True
			Me.linkLabel1.ImageAlign = ContentAlignment.MiddleLeft
			Me.linkLabel1.Location = New Point(13, 124)
			Me.linkLabel1.Name = "linkLabel1"
			Me.linkLabel1.Size = New Size(190, 13)
			Me.linkLabel1.TabIndex = 1
			Me.linkLabel1.TabStop = True
			Me.linkLabel1.Text = "Icons by Mark James (famfamfam.com)"
			Me.linkLabel1.TextAlign = ContentAlignment.MiddleCenter
'			Me.linkLabel1.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkLabel1_LinkClicked)
			' 
			' label4
			' 
			Me.label4.Location = New Point(12, 9)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(143, 13)
			Me.label4.TabIndex = 12
			Me.label4.Text = "Active Query Builder .NET"
			' 
			' lblDemoVersion
			' 
			Me.lblDemoVersion.Location = New Point(164, 32)
			Me.lblDemoVersion.Name = "lblDemoVersion"
			Me.lblDemoVersion.Size = New Size(217, 13)
			Me.lblDemoVersion.TabIndex = 13
			' 
			' AboutForm
			' 
			Me.AcceptButton = Me.bClose
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(393, 154)
			Me.Controls.Add(Me.lblDemoVersion)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.linkLabel1)
			Me.Controls.Add(Me.linkHome)
			Me.Controls.Add(Me.bClose)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.lblQueryBuilderVersion)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = FormBorderStyle.FixedDialog
			Me.Name = "AboutForm"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "About Demo"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As Label
		Private lblQueryBuilderVersion As Label
		Private label3 As Label
		Private bClose As Button
		Private WithEvents linkHome As LinkLabel
		Private WithEvents linkLabel1 As LinkLabel
		Private label4 As Label
		Private lblDemoVersion As Label
	End Class
End Namespace
