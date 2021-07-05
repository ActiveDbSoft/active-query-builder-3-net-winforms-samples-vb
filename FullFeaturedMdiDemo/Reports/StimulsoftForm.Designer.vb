Namespace Reports
	Partial Public Class StimulsoftForm
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
			Me.stiViewerControl1 = New Stimulsoft.Report.Viewer.StiViewerControl()
			Me.buttonDesigner = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' stiViewerControl1
			' 
			Me.stiViewerControl1.AllowDrop = True
			Me.stiViewerControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.stiViewerControl1.Location = New System.Drawing.Point(0, 0)
			Me.stiViewerControl1.Name = "stiViewerControl1"
			Me.stiViewerControl1.Report = Nothing
			Me.stiViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.stiViewerControl1.ShowZoom = True
			Me.stiViewerControl1.Size = New System.Drawing.Size(799, 409)
			Me.stiViewerControl1.TabIndex = 0
			' 
			' buttonDesigner
			' 
			Me.buttonDesigner.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonDesigner.AutoSize = True
			Me.buttonDesigner.Location = New System.Drawing.Point(644, 415)
			Me.buttonDesigner.Name = "buttonDesigner"
			Me.buttonDesigner.Size = New System.Drawing.Size(144, 23)
			Me.buttonDesigner.TabIndex = 1
			Me.buttonDesigner.Text = "Open designer"
			Me.buttonDesigner.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.buttonDesigner.Click += new System.EventHandler(this.buttonDesigner_Click);
			' 
			' StimulsoftForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(800, 450)
			Me.Controls.Add(Me.buttonDesigner)
			Me.Controls.Add(Me.stiViewerControl1)
			Me.Name = "StimulsoftForm"
			Me.Text = "StimulsoftForm"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.StimulsoftForm_Load);
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private stiViewerControl1 As Stimulsoft.Report.Viewer.StiViewerControl
		Private WithEvents buttonDesigner As System.Windows.Forms.Button
	End Class
End Namespace