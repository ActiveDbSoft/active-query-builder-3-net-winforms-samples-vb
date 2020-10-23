'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System
Imports System.Windows.Forms
Imports FullFeaturedMdiDemo.Common

Namespace Common
	Partial Public Class CreateReportForm
		Inherits Form

		Public Property SelectedReportType() As ReportType?

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub rb_CheckedChanged(sender As Object, e As EventArgs) Handles rbActiveReport.CheckedChanged, rbStimulsoft.CheckedChanged, rbFastReport.CheckedChanged
			button1.Enabled = True
			If rbActiveReport.Checked Then
				SelectedReportType = ReportType.ActiveReports14
				Return
			End If

			If rbStimulsoft.Checked Then
				SelectedReportType = ReportType.Stimulsoft
				Return
			End If

			If rbFastReport.Checked Then
				SelectedReportType = ReportType.FastReport
			End If
		End Sub
	End Class
End Namespace
