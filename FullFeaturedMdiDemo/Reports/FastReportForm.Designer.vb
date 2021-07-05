Namespace Reports
	Partial Public Class FastReportForm
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
			Me.buttonReport = New System.Windows.Forms.Button()
			Me.buttonDesigner = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' buttonReport
			' 
			Me.buttonReport.Dock = System.Windows.Forms.DockStyle.Top
			Me.buttonReport.Location = New System.Drawing.Point(10, 10)
			Me.buttonReport.Name = "buttonReport"
			Me.buttonReport.Size = New System.Drawing.Size(197, 23)
			Me.buttonReport.TabIndex = 0
			Me.buttonReport.Text = "Show report"
			Me.buttonReport.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
			' 
			' buttonDesigner
			' 
			Me.buttonDesigner.Dock = System.Windows.Forms.DockStyle.Top
			Me.buttonDesigner.Location = New System.Drawing.Point(10, 33)
			Me.buttonDesigner.Margin = New System.Windows.Forms.Padding(0)
			Me.buttonDesigner.Name = "buttonDesigner"
			Me.buttonDesigner.Size = New System.Drawing.Size(197, 23)
			Me.buttonDesigner.TabIndex = 0
			Me.buttonDesigner.Text = "Show designer"
			Me.buttonDesigner.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.buttonDesigner.Click += new System.EventHandler(this.buttonDesigner_Click);
			' 
			' FastReportForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(217, 63)
			Me.Controls.Add(Me.buttonDesigner)
			Me.Controls.Add(Me.buttonReport)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Name = "FastReportForm"
			Me.Padding = New System.Windows.Forms.Padding(10)
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "FastReport"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.FastReportForm_Load);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents buttonReport As System.Windows.Forms.Button
		Private WithEvents buttonDesigner As System.Windows.Forms.Button
	End Class
End Namespace