''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2022 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''


Imports ActiveQueryBuilder.Core

Namespace OptionsControls
    Partial Public Class CommonTab
        Inherits UserControl
        Implements IOptionsLoader
        Public Property SelectFormat() As SQLBuilderSelectFormat
        Public Property FormattingOptions() As SQLFormattingOptions

        Public Sub New(formattingOptions As SQLFormattingOptions, selectFormat As SQLBuilderSelectFormat)
            Me.SelectFormat = selectFormat
            Me.FormattingOptions = formattingOptions

            InitializeComponent()
            LoadOptionsOnForm()
        End Sub

        Public Sub LoadOptionsOnForm() Implements IOptionsLoader.LoadOptionsOnForm
            chBxStartPartsFromNewLines.Checked = SelectFormat.MainPartsFromNewLine
            chBxInsertNewLineAfterPartKeywords.Checked = SelectFormat.NewLineAfterPartKeywords
            upDownPartIndent.Value = SelectFormat.IndentInPart
            chBxStartSelectListItemsOnNewLines.Checked = SelectFormat.SelectListFormat.NewLineAfterItem

            radButNewLineBeforeComma.Checked = SelectFormat.SelectListFormat.NewLineBeforeComma
            radButNewLineBeforeComma.Checked = SelectFormat.OrderByFormat.NewLineBeforeComma
            radButNewLineBeforeComma.Checked = SelectFormat.GroupByFormat.NewLineBeforeComma

            radButNewLineAfterComma.Checked = SelectFormat.SelectListFormat.NewLineAfterItem
            radButNewLineAfterComma.Checked = SelectFormat.OrderByFormat.NewLineAfterItem
            radButNewLineAfterComma.Checked = SelectFormat.GroupByFormat.NewLineAfterItem

            radButStartJoinKeywordsFromNewLines.Checked = SelectFormat.FromClauseFormat.NewLineAfterDatasource
            chBxStartJoinConditionsOnNewLines.Checked = SelectFormat.FromClauseFormat.NewLineBeforeJoinExpression
        End Sub

        Public Sub LoadOptionsFromForm() Implements IOptionsLoader.LoadOptionsFromForm
            SelectFormat.MainPartsFromNewLine = chBxStartPartsFromNewLines.Checked
            SelectFormat.NewLineAfterPartKeywords = chBxInsertNewLineAfterPartKeywords.Checked
            SelectFormat.IndentInPart = CInt(Fix(upDownPartIndent.Value))
            SelectFormat.SelectListFormat.NewLineAfterItem = chBxStartSelectListItemsOnNewLines.Checked

            SelectFormat.SelectListFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked
            SelectFormat.OrderByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked
            SelectFormat.GroupByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked

            SelectFormat.SelectListFormat.NewLineAfterItem = radButNewLineAfterComma.Checked
            SelectFormat.OrderByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked
            SelectFormat.GroupByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked

            SelectFormat.FromClauseFormat.NewLineAfterDatasource = radButStartJoinKeywordsFromNewLines.Checked
            SelectFormat.FromClauseFormat.NewLineBeforeJoinExpression = chBxStartJoinConditionsOnNewLines.Checked
        End Sub

        Private Sub chBxStartPartsFromNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles chBxStartPartsFromNewLines.CheckedChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.MainPartsFromNewLine = chBxStartPartsFromNewLines.Checked

                FormattingOptions.NotifyUpdated()
            End Using
        End Sub

        Private Sub chBxInsertNewLineAfterPartKeywords_CheckedChanged(sender As Object, e As EventArgs) Handles chBxInsertNewLineAfterPartKeywords.CheckedChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.NewLineAfterPartKeywords = chBxInsertNewLineAfterPartKeywords.Checked

                FormattingOptions.NotifyUpdated()
            End Using
        End Sub

        Private Sub upDownPartIndent_ValueChanged(sender As Object, e As EventArgs) Handles upDownPartIndent.ValueChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.IndentInPart = CInt(Fix(upDownPartIndent.Value))

                FormattingOptions.NotifyUpdated()
            End Using
        End Sub

        Private Sub chBxStartSelectListItemsOnNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles chBxStartSelectListItemsOnNewLines.CheckedChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.SelectListFormat.NewLineAfterItem = chBxStartSelectListItemsOnNewLines.Checked

                FormattingOptions.NotifyUpdated()
            End Using
        End Sub

        Private Sub radButNewLineBeforeComma_CheckedChanged(sender As Object, e As EventArgs) Handles radButNewLineBeforeComma.CheckedChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.SelectListFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked
                SelectFormat.OrderByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked
                SelectFormat.GroupByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked

                FormattingOptions.NotifyUpdated()
            End Using
        End Sub

        Private Sub radButNewLineAfterComma_CheckedChanged(sender As Object, e As EventArgs) Handles radButNewLineAfterComma.CheckedChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.SelectListFormat.NewLineAfterItem = radButNewLineAfterComma.Checked
                SelectFormat.OrderByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked
                SelectFormat.GroupByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked

                FormattingOptions.NotifyUpdated()
            End Using
        End Sub

        Private Sub radButStartDataSourcesFromNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles radButStartDataSourcesFromNewLines.CheckedChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.FromClauseFormat.NewLineAfterDatasource = radButStartDataSourcesFromNewLines.Checked

                FormattingOptions.NotifyUpdated()
            End Using
        End Sub

        Private Sub radButStartJoinKeywordsFromNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles radButStartJoinKeywordsFromNewLines.CheckedChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.FromClauseFormat.NewLineAfterJoin = radButStartJoinKeywordsFromNewLines.Checked

                FormattingOptions.NotifyUpdated()
            End Using
        End Sub

        Private Sub chBxStartJoinConditionsOnNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles chBxStartJoinConditionsOnNewLines.CheckedChanged
            Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
                SelectFormat.FromClauseFormat.NewLineBeforeJoinExpression = chBxStartJoinConditionsOnNewLines.Checked

                FormattingOptions.NotifyUpdated()
            End Using
        End Sub
    End Class
End Namespace
