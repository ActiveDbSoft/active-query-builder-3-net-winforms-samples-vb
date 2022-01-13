''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2022 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Stimulsoft.Base.Drawing
Imports Stimulsoft.Report
Imports Stimulsoft.Report.Components

Namespace Reports
    Partial Public Class StimulsoftForm
        Inherits Form

        Private Property DataTable() As DataTable
        Public Sub New(dataTable As DataTable)
            Me.DataTable = dataTable

            InitializeComponent()
        End Sub

        Private Sub StimulsoftForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Dim report As New StiReport()

            ' Add data to datastore
            report.RegData(DataTable)

            ' Fill dictionary
            report.Dictionary.Synchronize()

            Dim page = report.Pages(0)

            'Create HeaderBand
            Dim headerBand = New StiHeaderBand With {
                .Height = 0.5,
                .Name = "HeaderBand"
            }
            page.Components.Add(headerBand)

            'Create Databand
            Dim dataBand = New StiDataBand With {
                .DataSourceName = "result",
                .Height = 0.5,
                .Name = "DataBand"
            }
            page.Components.Add(dataBand)
            'INSTANT VB NOTE: The variable width was renamed since Visual Basic does not handle local variables named the same as class members well:
            Dim width_Renamed = CInt(page.Width) \ DataTable.Columns.Count
            For Each column As DataColumn In DataTable.Columns
                'Create text on header
                Dim headerText = New StiText(New RectangleD(0, 0, width_Renamed, 0.5)) With {
                        .Text = column.ColumnName,
                        .HorAlignment = StiTextHorAlignment.Center,
                        .Brush = New StiSolidBrush(Color.Gainsboro),
                        .Dockable = True,
                        .DockStyle = StiDockStyle.Left,
                        .CanShrink = True,
                        .CanGrow = True,
                        .VertAlignment = StiVertAlignment.Center
                        }

                headerBand.Components.Add(headerText)

                'Create text
                Dim dataText = New StiText(New RectangleD(0, 0, width_Renamed, 0.5)) With{
                        .Text = "{result." + column.ColumnName + "}",
                        .Dockable = true,
                        .DockStyle = StiDockStyle.Left,
                        .VertAlignment = StiVertAlignment.Center,
                        .CanShrink = true,
                        .CanGrow = true
                                                }
               
                dataBand.Components.Add(dataText)
            Next column

            stiViewerControl1.Report = report
            report.Compile()
            report.Render(True)
        End Sub

        Private Sub buttonDesigner_Click(sender As Object, e As System.EventArgs) Handles buttonDesigner.Click
            stiViewerControl1.Report.Design()
        End Sub
    End Class
End Namespace
