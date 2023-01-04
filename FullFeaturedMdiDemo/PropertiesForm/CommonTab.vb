''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2023 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports ActiveQueryBuilder.Core

Namespace PropertiesForm
    Partial Public Class CommonTab
        Inherits UserControl
        Public Property SelectFormat() As SQLBuilderSelectFormat
        Public Property FormattingOptions() As SQLFormattingOptions

        Public Sub New(formattingOptions As SQLFormattingOptions, selectFormat As SQLBuilderSelectFormat)
            Me.SelectFormat = selectFormat
            Me.FormattingOptions = formattingOptions

            InitializeComponent()
            LoadOptions()
        End Sub

        Public Sub LoadOptions()
            chBxStartPartsFromNewLines.Checked = SelectFormat.MainPartsFromNewLine
            chBxInsertNewLineAfterPartKeywords.Checked = SelectFormat.NewLineAfterPartKeywords
            upDownPartIndent.Value = SelectFormat.IndentInPart
            chBxStartSelectListItemsOnNewLines.Checked = SelectFormat.SelectListFormat.NewLineAfterItem

            radButNewLineBeforeComma.Checked = SelectFormat.SelectListFormat.NewLineBeforeComma
            radButNewLineAfterComma.Checked = SelectFormat.SelectListFormat.NewLineAfterItem

            radButStartDataSourcesFromNewLines.Checked = SelectFormat.FromClauseFormat.NewLineAfterDatasource
            chBxStartJoinConditionsOnNewLines.Checked = SelectFormat.FromClauseFormat.NewLineBeforeJoinExpression
        End Sub

        Private Sub chBxStartPartsFromNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles chBxStartPartsFromNewLines.CheckedChanged
            SelectFormat.MainPartsFromNewLine = chBxStartPartsFromNewLines.Checked
        End Sub

        Private Sub chBxInsertNewLineAfterPartKeywords_CheckedChanged(sender As Object, e As EventArgs) Handles chBxInsertNewLineAfterPartKeywords.CheckedChanged
            SelectFormat.NewLineAfterPartKeywords = chBxInsertNewLineAfterPartKeywords.Checked
        End Sub

        Private Sub upDownPartIndent_ValueChanged(sender As Object, e As EventArgs) Handles upDownPartIndent.ValueChanged
            SelectFormat.IndentInPart = CInt(Fix(upDownPartIndent.Value))
        End Sub

        Private Sub chBxStartSelectListItemsOnNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles chBxStartSelectListItemsOnNewLines.CheckedChanged
            SelectFormat.SelectListFormat.NewLineAfterItem = chBxStartSelectListItemsOnNewLines.Checked
        End Sub

        Private Sub radButNewLineBeforeComma_CheckedChanged(sender As Object, e As EventArgs) Handles radButNewLineBeforeComma.CheckedChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.SelectListFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked
                SelectFormat.OrderByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked
                SelectFormat.GroupByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked
            End Using
        End Sub

        Private Sub radButNewLineAfterComma_CheckedChanged(sender As Object, e As EventArgs) Handles radButNewLineAfterComma.CheckedChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.SelectListFormat.NewLineAfterItem = radButNewLineAfterComma.Checked
                SelectFormat.OrderByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked
                SelectFormat.GroupByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked
            End Using
        End Sub

        Private Sub radButStartDataSourcesFromNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles radButStartDataSourcesFromNewLines.CheckedChanged
            SelectFormat.FromClauseFormat.NewLineAfterDatasource = radButStartDataSourcesFromNewLines.Checked
        End Sub

        Private Sub radButStartJoinKeywordsFromNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles radButStartJoinKeywordsFromNewLines.CheckedChanged
            SelectFormat.FromClauseFormat.NewLineAfterJoin = radButStartJoinKeywordsFromNewLines.Checked
        End Sub

        Private Sub chBxStartJoinConditionsOnNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles chBxStartJoinConditionsOnNewLines.CheckedChanged
            SelectFormat.FromClauseFormat.NewLineBeforeJoinExpression = chBxStartJoinConditionsOnNewLines.Checked
        End Sub
    End Class
End Namespace
