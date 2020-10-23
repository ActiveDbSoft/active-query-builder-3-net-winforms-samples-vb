Namespace Reports
	Partial Public Class ActiveReportsForm
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
			Me.viewer1 = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
			Me.SuspendLayout()
			' 
			' viewer1
			' 
			Me.viewer1.CurrentPage = 0
			Me.viewer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.viewer1.Location = New System.Drawing.Point(0, 0)
			Me.viewer1.Name = "viewer1"
			Me.viewer1.PreviewPages = 0
			' 
			' 
			' 
			' 
			' 
			' 
			Me.viewer1.Sidebar.ParametersPanel.ContextMenu = Nothing
			Me.viewer1.Sidebar.ParametersPanel.Text = "Parameters"
			Me.viewer1.Sidebar.ParametersPanel.Width = 200
			' 
			' 
			' 
			Me.viewer1.Sidebar.SearchPanel.ContextMenu = Nothing
			Me.viewer1.Sidebar.SearchPanel.Text = "Search results"
			Me.viewer1.Sidebar.SearchPanel.Width = 200
			' 
			' 
			' 
			Me.viewer1.Sidebar.ThumbnailsPanel.ContextMenu = Nothing
			Me.viewer1.Sidebar.ThumbnailsPanel.Text = "Page thumbnails"
			Me.viewer1.Sidebar.ThumbnailsPanel.Width = 200
			Me.viewer1.Sidebar.ThumbnailsPanel.Zoom = 0.1R
			' 
			' 
			' 
			Me.viewer1.Sidebar.TocPanel.ContextMenu = Nothing
			Me.viewer1.Sidebar.TocPanel.Expanded = True
			Me.viewer1.Sidebar.TocPanel.Text = "Document map"
			Me.viewer1.Sidebar.TocPanel.Width = 200
			Me.viewer1.Sidebar.Width = 200
			Me.viewer1.Size = New System.Drawing.Size(800, 450)
			Me.viewer1.TabIndex = 0
			' 
			' ActiveReportsForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(800, 450)
			Me.Controls.Add(Me.viewer1)
			Me.Name = "ActiveReportsForm"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "ActiveReports"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.ActiveReportsForm_Load);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private viewer1 As GrapeCity.ActiveReports.Viewer.Win.Viewer
	End Class
End Namespace
