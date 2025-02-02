''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''


Imports ActiveQueryBuilder.Core

Namespace OptionsControls
    Partial Public Class SubQueryTab
        Inherits UserControl
        Implements IOptionsLoader
        Public Property FormattingOptions() As SQLFormattingOptions
        Public Property SelectFormat() As SQLBuilderSelectFormat

        Public Sub New(formattingOptions As SQLFormattingOptions, Optional prefix As String = "Sub-Query")
            Me.FormattingOptions = formattingOptions
            InitializeComponent()

            If prefix = "Sub-Query" Then
                SelectFormat = formattingOptions.ExpressionSubQueryFormat
            End If

            If prefix = "Derived Tables" Then
                groupBox1.Text = "Derived tables format options"
                label1.Text = "Derived tables indent:"
                chBxSubQueriesFromNewLines.Text = "Start derived tables from new lines"
                label2.Text = "Derived Tables format options" & vbLf & "determine the layout of sub-queries" & vbLf & "used as data sources in the query."

                SelectFormat = formattingOptions.DerivedQueryFormat
            End If
            If prefix = "CTE" Then
                groupBox1.Text = "Common table expressions format options"
                label1.Text = "CTE indent:"
                chBxSubQueriesFromNewLines.Text = "Start CTE from new lines"
                label2.Text = "CTE format options" & vbLf & "determine the layout of sub-queries" & vbLf & "used above the main query in the with clause."

                SelectFormat = formattingOptions.CTESubQueryFormat
            End If
            LoadOptionsOnForm()
        End Sub

        Public Sub LoadOptionsOnForm() Implements IOptionsLoader.LoadOptionsOnForm
            UpDownSubQueryIndent.Value = SelectFormat.IndentInPart
            chBxSubQueriesFromNewLines.Checked = SelectFormat.SubQueryTextFromNewLine
        End Sub

        Public Sub LoadOptionsFromForm() Implements IOptionsLoader.LoadOptionsFromForm
            SelectFormat.IndentInPart = CInt(Fix(UpDownSubQueryIndent.Value))
            SelectFormat.SubQueryTextFromNewLine = chBxSubQueriesFromNewLines.Checked
        End Sub

        Private Sub UpDownSubQueryIndent_ValueChanged(sender As Object, e As EventArgs) Handles UpDownSubQueryIndent.ValueChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.IndentInPart = CInt(Fix(UpDownSubQueryIndent.Value))

                FormattingOptions.NotifyUpdated()
            End Using
        End Sub

        Private Sub chBxSubQueriesFromNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles chBxSubQueriesFromNewLines.CheckedChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.SubQueryTextFromNewLine = chBxSubQueriesFromNewLines.Checked

                FormattingOptions.NotifyUpdated()
            End Using
        End Sub

        Private Sub chBxSameFormatAsMainQuery_CheckedChanged(sender As Object, e As EventArgs) Handles chBxSameFormatAsMainQuery.CheckedChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.Assign(FormattingOptions.MainQueryFormat)

                FormattingOptions.NotifyUpdated()
            End Using
        End Sub
    End Class
End Namespace
