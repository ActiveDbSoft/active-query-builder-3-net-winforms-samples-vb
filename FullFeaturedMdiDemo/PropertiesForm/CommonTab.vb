'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core

Namespace PropertiesForm
	Public Partial Class CommonTab
		Inherits UserControl
		Public Property SelectFormat() As SQLBuilderSelectFormat
			Get
				Return m_SelectFormat
			End Get
			Set
				m_SelectFormat = Value
			End Set
		End Property
		Private m_SelectFormat As SQLBuilderSelectFormat
		Public Property FormattingOptions() As SQLFormattingOptions
			Get
				Return m_FormattingOptions
			End Get
			Set
				m_FormattingOptions = Value
			End Set
		End Property
		Private m_FormattingOptions As SQLFormattingOptions

		Public Sub New(formattingOptions__1 As SQLFormattingOptions, selectFormat__2 As SQLBuilderSelectFormat)
			InitializeComponent()
			SelectFormat = selectFormat__2
			FormattingOptions = formattingOptions__1

			LoadOptions()
		End Sub

		Public Sub LoadOptions()
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

		Private Sub chBxStartPartsFromNewLines_CheckedChanged(sender As Object, e As EventArgs)
			SelectFormat.MainPartsFromNewLine = chBxStartPartsFromNewLines.Checked
		End Sub

		Private Sub chBxInsertNewLineAfterPartKeywords_CheckedChanged(sender As Object, e As EventArgs)
			SelectFormat.NewLineAfterPartKeywords = chBxInsertNewLineAfterPartKeywords.Checked
		End Sub

		Private Sub upDownPartIndent_ValueChanged(sender As Object, e As EventArgs)
			SelectFormat.IndentInPart = CInt(Math.Truncate(upDownPartIndent.Value))
		End Sub

		Private Sub chBxStartSelectListItemsOnNewLines_CheckedChanged(sender As Object, e As EventArgs)
			SelectFormat.SelectListFormat.NewLineAfterItem = chBxStartSelectListItemsOnNewLines.Checked
		End Sub

		Private Sub radButNewLineBeforeComma_CheckedChanged(sender As Object, e As EventArgs)
			Using New UpdateRegion(FormattingOptions)
				SelectFormat.SelectListFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked
				SelectFormat.OrderByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked
				SelectFormat.GroupByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked
			End Using
		End Sub

		Private Sub radButNewLineAfterComma_CheckedChanged(sender As Object, e As EventArgs)
			Using New UpdateRegion(FormattingOptions)
				SelectFormat.SelectListFormat.NewLineAfterItem = radButNewLineAfterComma.Checked
				SelectFormat.OrderByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked
				SelectFormat.GroupByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked
			End Using
		End Sub

		Private Sub radButStartDataSourcesFromNewLines_CheckedChanged(sender As Object, e As EventArgs)
			SelectFormat.FromClauseFormat.NewLineAfterDatasource = radButStartDataSourcesFromNewLines.Checked
		End Sub

		Private Sub radButStartJoinKeywordsFromNewLines_CheckedChanged(sender As Object, e As EventArgs)
			SelectFormat.FromClauseFormat.NewLineAfterJoin = radButStartJoinKeywordsFromNewLines.Checked
		End Sub

		Private Sub chBxStartJoinConditionsOnNewLines_CheckedChanged(sender As Object, e As EventArgs)
			SelectFormat.FromClauseFormat.NewLineBeforeJoinExpression = chBxStartJoinConditionsOnNewLines.Checked
		End Sub
	End Class
End Namespace
