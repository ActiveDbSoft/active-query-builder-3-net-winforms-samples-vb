''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2021 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports GrapeCity.ActiveReports
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.Drawing
Imports Label = GrapeCity.ActiveReports.SectionReportModel.Label
Imports TextBox = GrapeCity.ActiveReports.SectionReportModel.TextBox

Namespace Reports
	Partial Public Class ActiveReportsForm
		Inherits Form

		Private _sectionReport As SectionReport
		Private Property DataTable() As DataTable
		Public Sub New(dataTable As DataTable)
			Me.DataTable = dataTable
			InitializeComponent()
		End Sub

		Private Sub ActiveReportsForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
			_sectionReport = New SectionReport With {.DataSource = DataTable}

			_sectionReport.Document.Printer.PrinterName = ""
			_sectionReport.PageSettings.Margins.Left = 0.1F
			_sectionReport.PageSettings.Margins.Right = 0.1F
			_sectionReport.PrintWidth = 15F

			_sectionReport.Sections.Add(SectionType.ReportHeader, "ReportHeader")
			_sectionReport.Sections.Add(SectionType.Detail, "Detail")
			_sectionReport.Sections.Add(SectionType.ReportFooter, "ReportFooter")

			Dim section1 = _sectionReport.Sections(1)
			section1.CanGrow = True
			section1.CanShrink = True

			Dim locationX As Single = 0

			For Each dataSetColumn As DataColumn In DataTable.Columns
				Dim labelHeader = New Label With {
					.Text = dataSetColumn.ColumnName,
					.Alignment = Document.Section.TextAlignment.Left,
					.Location = New PointF(locationX, 0.0F),
					.ShrinkToFit = False,
					.MinCondenseRate = 100,
					.BackColor = Color.Gainsboro,
					.Width = 2
				}
				_sectionReport.Sections(0).Controls.Add(labelHeader)

				Dim ctl = New TextBox With {
					.Name = dataSetColumn.ColumnName,
					.Text = dataSetColumn.ColumnName,
					.DataField = dataSetColumn.ColumnName,
					.Location = New PointF(locationX, 0.05F),
					.ShrinkToFit = False,
					.WrapMode = Document.Section.WrapMode.NoWrap,
					.CanShrink = False
				}


				ctl.Border.BottomStyle = BorderLineStyle.Dash

				_sectionReport.Sections(1).Controls.Add(ctl)

				locationX += ctl.Width
			Next dataSetColumn

			viewer1.LoadDocument(_sectionReport)
		End Sub
	End Class
End Namespace
