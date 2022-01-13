''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2022 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System
Imports System.Data
Imports System.Windows.Forms
Imports FastReport
Imports FastReport.Utils

Namespace Reports
    Partial Public Class FastReportForm
        Inherits Form

        Private Property DataTable() As DataTable
        Private _report As Report

        Public Sub New(dataTable As DataTable)
            Me.DataTable = dataTable
            InitializeComponent()
        End Sub

        Private Sub buttonDesigner_Click(sender As Object, e As EventArgs) Handles buttonDesigner.Click
            _report.Design()
        End Sub

        Private Sub buttonReport_Click(sender As Object, e As EventArgs) Handles buttonReport.Click
            _report.Show()
        End Sub

        Private Sub FastReportForm_Load(sender As Object, e As EventArgs) Handles Me.Load
            Dim dataSet = New DataSet(DataTable.TableName)
            dataSet.Tables.Add(DataTable)
            _report = New Report()

            ' register all data tables and relations
            _report.RegisterData(dataSet)

            ' enable the "result" table to use it in the report
            _report.GetDataSource(DataTable.TableName).Enabled = True

            ' add report page
            Dim page As New ReportPage()
            _report.Pages.Add(page)
            ' always give names to objects you create. You can use CreateUniqueName method to do this;
            ' call it after the object is added to a report.
            page.CreateUniqueName()

            ' create title band
            page.ReportTitle = New ReportTitleBand With {.Height = Units.Centimeters * 1}

            page.ReportTitle.CreateUniqueName()

            ' create title text
            Dim titleText As TextObject = New TextObject With {
                .Bounds = New System.Drawing.RectangleF(Units.Centimeters * 5, 0, Units.Centimeters * 10, Units.Centimeters * 1),
                .Font = New System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold),
                .Text = "Report result",
                .HorzAlign = HorzAlign.Center,
                .Parent = page.ReportTitle
            }
            titleText.CreateUniqueName()

            ' create data band
            Dim dataBand As New DataBand()
            page.Bands.Add(dataBand)
            dataBand.CreateUniqueName()
            dataBand.DataSource = _report.GetDataSource(DataTable.TableName)
            dataBand.Height = Units.Centimeters * 0.5F
'INSTANT VB NOTE: The variable width was renamed since Visual Basic does not handle local variables named the same as class members well:
            Dim width_Renamed = page.PaperWidth / DataTable.Columns.Count

            For Each column As DataColumn In DataTable.Columns
                ' create two text objects with employee's name and birth date
                Dim empNameText As TextObject = New TextObject With {
                    .Bounds = New System.Drawing.RectangleF(0, 0, width_Renamed * Units.Millimeters, Units.Centimeters * 0.5F),
                    .Text = "[" & DataTable.TableName & "." & column.ColumnName & "]",
                    .Parent = dataBand,
                    .Dock = DockStyle.Left
                }
                empNameText.CreateUniqueName()
            Next column
        End Sub
    End Class
End Namespace
