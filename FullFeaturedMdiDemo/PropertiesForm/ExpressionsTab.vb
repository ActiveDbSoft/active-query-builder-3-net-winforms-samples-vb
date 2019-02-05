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
	Public Partial Class ExpressionsTab
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
			If SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical AndAlso SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical Then
				chBxUpperLvlLogicExprFromNewLines.Checked = True

				chBxStartAllLogicExprFromNewLines.Enabled = True
			End If
			If SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None AndAlso SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None Then
				chBxStartAllLogicExprFromNewLines.Checked = False
				chBxStartAllLogicExprFromNewLines.Enabled = False
			End If

			If SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical AndAlso SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical Then
				chBxStartAllLogicExprFromNewLines.Checked = True
				UpDownIndentForNestedConditions.Enabled = True
			Else
				If SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical AndAlso SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical Then
					chBxUpperLvlLogicExprFromNewLines.Checked = True
				End If
				If SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None AndAlso SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None Then
					UpDownIndentForNestedConditions.Enabled = False
				End If
			End If


			If SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.TopmostLogical AndAlso SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.TopmostLogical Then
			End If
			If SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.AllLogical AndAlso SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.AllLogical Then
				radButStartLines.Checked = True
				chBxUpperLvlLogicExprFromNewLines.Checked = True
				chBxStartAllLogicExprFromNewLines.Checked = True
			End If

			If SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.None AndAlso SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.None Then
				radButEndLines.Checked = True
			End If

			UpDownIndentForNestedConditions.Value = SelectFormat.WhereFormat.IndentNestedConditions
			UpDownIndentForNestedConditions.Value = SelectFormat.HavingFormat.IndentNestedConditions

			UpDownIndentForNestedConditions.Value = SelectFormat.FromClauseFormat.JoinConditionFormat.IndentNestedConditions
			chBxBranchConditionKeyWrdsFromNewLinesWhen.Checked = SelectFormat.ConditionalOperatorsFormat.NewLineBeforeWhen

			chBxBranchConditionExprFromNewLines.Checked = SelectFormat.ConditionalOperatorsFormat.NewLineAfterWhen

			chBxResultKwrdsFromNewLinesThen.Checked = SelectFormat.ConditionalOperatorsFormat.NewLineBeforeThen

			chBxBranchResultExprsFromNewLines.Checked = SelectFormat.ConditionalOperatorsFormat.NewLineAfterThen

			UpDownBranchKeyWrdsIndent.Value = SelectFormat.ConditionalOperatorsFormat.IndentBranch

			UpDownExprsIndent.Value = SelectFormat.ConditionalOperatorsFormat.IndentExpressions
		End Sub

		Private Sub chBxUpperLvlLogicExprFromNewLines_CheckedChanged(sender As Object, e As EventArgs)
			Using New UpdateRegion(FormattingOptions)
				If chBxUpperLvlLogicExprFromNewLines.Checked Then
					SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical
					SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical

					chBxStartAllLogicExprFromNewLines.Enabled = True
				Else
					SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None
					SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None

					chBxStartAllLogicExprFromNewLines.Checked = False
					chBxStartAllLogicExprFromNewLines.Enabled = False
				End If
			End Using
		End Sub

		Private Sub chBxStartAllLogicExprFromNewLines_CheckedChanged(sender As Object, e As EventArgs)
			Using New UpdateRegion(FormattingOptions)
				If chBxStartAllLogicExprFromNewLines.Checked Then
					SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical
					SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical

					UpDownIndentForNestedConditions.Enabled = True
				Else
					If chBxUpperLvlLogicExprFromNewLines.Checked Then
						SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical
						SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical
					Else
						SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None
						SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None
					End If

					UpDownIndentForNestedConditions.Enabled = False
				End If
			End Using
		End Sub

		Private Sub radButStartLines_CheckedChanged(sender As Object, e As EventArgs)
			Using New UpdateRegion(FormattingOptions)
				If radButStartLines.Checked Then
					If chBxUpperLvlLogicExprFromNewLines.Checked AndAlso Not chBxStartAllLogicExprFromNewLines.Checked Then
						SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.TopmostLogical
						SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.TopmostLogical
					End If
					If chBxUpperLvlLogicExprFromNewLines.Checked AndAlso chBxStartAllLogicExprFromNewLines.Checked Then
						SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.AllLogical
						SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.AllLogical
					End If
				End If
			End Using
		End Sub

		Private Sub radButEndLines_CheckedChanged(sender As Object, e As EventArgs)
			Using New UpdateRegion(FormattingOptions)
				If radButEndLines.Checked Then
					SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.None
					SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.None
				End If
			End Using
		End Sub

		Private Sub UpDownIndentForNestedConditions_ValueChanged(sender As Object, e As EventArgs)
			Using New UpdateRegion(FormattingOptions)
				SelectFormat.WhereFormat.IndentNestedConditions = CInt(Math.Truncate(UpDownIndentForNestedConditions.Value))
				SelectFormat.HavingFormat.IndentNestedConditions = CInt(Math.Truncate(UpDownIndentForNestedConditions.Value))

				SelectFormat.FromClauseFormat.JoinConditionFormat.IndentNestedConditions = CInt(Math.Truncate(UpDownIndentForNestedConditions.Value))
			End Using
		End Sub

		Private Sub chBxBranchConditionKeyWrdsFromNewLinesWhen_CheckedChanged(sender As Object, e As EventArgs)
			SelectFormat.ConditionalOperatorsFormat.NewLineBeforeWhen = chBxBranchConditionKeyWrdsFromNewLinesWhen.Checked
		End Sub

		Private Sub chBxBranchConditionExprFromNewLines_CheckedChanged(sender As Object, e As EventArgs)
			SelectFormat.ConditionalOperatorsFormat.NewLineAfterWhen = chBxBranchConditionExprFromNewLines.Checked
		End Sub

		Private Sub chBxResultKwrdsFromNewLinesThen_CheckedChanged(sender As Object, e As EventArgs)
			SelectFormat.ConditionalOperatorsFormat.NewLineBeforeThen = chBxResultKwrdsFromNewLinesThen.Checked
		End Sub

		Private Sub chBxBranchResultExprsFromNewLines_CheckedChanged(sender As Object, e As EventArgs)
			SelectFormat.ConditionalOperatorsFormat.NewLineAfterThen = chBxBranchResultExprsFromNewLines.Checked
		End Sub

		Private Sub UpDownBranchKeyWrdsIndent_ValueChanged(sender As Object, e As EventArgs)
			SelectFormat.ConditionalOperatorsFormat.IndentBranch = CInt(Math.Truncate(UpDownBranchKeyWrdsIndent.Value))
		End Sub

		Private Sub UpDownExprsIndent_ValueChanged(sender As Object, e As EventArgs)
			SelectFormat.ConditionalOperatorsFormat.IndentExpressions = CInt(Math.Truncate(UpDownExprsIndent.Value))
		End Sub
	End Class
End Namespace
