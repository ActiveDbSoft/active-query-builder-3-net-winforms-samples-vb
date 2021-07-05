//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//


Imports ActiveQueryBuilder.Core

Namespace OptionsControls
	Partial Public Class ExpressionsTab
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

		Public Sub LoadOptionsFromForm() Implements IOptionsLoader.LoadOptionsFromForm
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

			If radButStartLines.Checked Then
				If chBxUpperLvlLogicExprFromNewLines.Checked AndAlso (Not chBxStartAllLogicExprFromNewLines.Checked) Then
					SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.TopmostLogical
					SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.TopmostLogical
				End If
				If chBxUpperLvlLogicExprFromNewLines.Checked AndAlso chBxStartAllLogicExprFromNewLines.Checked Then
					SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.AllLogical
					SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.AllLogical
				End If
			End If

			If radButEndLines.Checked Then
				SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.None
				SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.None
			End If

			SelectFormat.WhereFormat.IndentNestedConditions = CInt(Fix(UpDownIndentForNestedConditions.Value))
			SelectFormat.HavingFormat.IndentNestedConditions = CInt(Fix(UpDownIndentForNestedConditions.Value))

			SelectFormat.FromClauseFormat.JoinConditionFormat.IndentNestedConditions = CInt(Fix(UpDownIndentForNestedConditions.Value))

			SelectFormat.ConditionalOperatorsFormat.NewLineBeforeWhen = chBxBranchConditionKeyWrdsFromNewLinesWhen.Checked

			SelectFormat.ConditionalOperatorsFormat.NewLineAfterWhen = chBxBranchConditionExprFromNewLines.Checked

			SelectFormat.ConditionalOperatorsFormat.NewLineBeforeThen = chBxResultKwrdsFromNewLinesThen.Checked

			SelectFormat.ConditionalOperatorsFormat.NewLineAfterThen = chBxBranchResultExprsFromNewLines.Checked

			SelectFormat.ConditionalOperatorsFormat.IndentBranch = CInt(Fix(UpDownBranchKeyWrdsIndent.Value))

			SelectFormat.ConditionalOperatorsFormat.IndentExpressions = CInt(Fix(UpDownExprsIndent.Value))
		End Sub

		Private Sub chBxUpperLvlLogicExprFromNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles chBxUpperLvlLogicExprFromNewLines.CheckedChanged
			Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
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

				FormattingOptions.NotifyUpdated()
			End Using
		End Sub

		Private Sub chBxStartAllLogicExprFromNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles chBxStartAllLogicExprFromNewLines.CheckedChanged
			Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
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
				FormattingOptions.NotifyUpdated()
			End Using
		End Sub

		Private Sub radButStartLines_CheckedChanged(sender As Object, e As EventArgs) Handles radButStartLines.CheckedChanged
			Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
				If radButStartLines.Checked Then
					If chBxUpperLvlLogicExprFromNewLines.Checked AndAlso (Not chBxStartAllLogicExprFromNewLines.Checked) Then
						SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.TopmostLogical
						SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.TopmostLogical
					End If
					If chBxUpperLvlLogicExprFromNewLines.Checked AndAlso chBxStartAllLogicExprFromNewLines.Checked Then
						SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.AllLogical
						SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.AllLogical
					End If
				End If
				FormattingOptions.NotifyUpdated()
			End Using
		End Sub

		Private Sub radButEndLines_CheckedChanged(sender As Object, e As EventArgs) Handles radButEndLines.CheckedChanged
			Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
				If radButEndLines.Checked Then
					SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.None
					SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.None
				End If
				FormattingOptions.NotifyUpdated()
			End Using
		End Sub

		Private Sub UpDownIndentForNestedConditions_ValueChanged(sender As Object, e As EventArgs) Handles UpDownIndentForNestedConditions.ValueChanged
			Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
				SelectFormat.WhereFormat.IndentNestedConditions = CInt(Fix(UpDownIndentForNestedConditions.Value))
				SelectFormat.HavingFormat.IndentNestedConditions = CInt(Fix(UpDownIndentForNestedConditions.Value))

				SelectFormat.FromClauseFormat.JoinConditionFormat.IndentNestedConditions = CInt(Fix(UpDownIndentForNestedConditions.Value))

				FormattingOptions.NotifyUpdated()
			End Using
		End Sub

		Private Sub chBxBranchConditionKeyWrdsFromNewLinesWhen_CheckedChanged(sender As Object, e As EventArgs) Handles chBxBranchConditionKeyWrdsFromNewLinesWhen.CheckedChanged
			Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
				SelectFormat.ConditionalOperatorsFormat.NewLineBeforeWhen = chBxBranchConditionKeyWrdsFromNewLinesWhen.Checked

				FormattingOptions.NotifyUpdated()
			End Using
		End Sub

		Private Sub chBxBranchConditionExprFromNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles chBxBranchConditionExprFromNewLines.CheckedChanged
			Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
				SelectFormat.ConditionalOperatorsFormat.NewLineAfterWhen = chBxBranchConditionExprFromNewLines.Checked

				FormattingOptions.NotifyUpdated()
			End Using
		End Sub

		Private Sub chBxResultKwrdsFromNewLinesThen_CheckedChanged(sender As Object, e As EventArgs) Handles chBxResultKwrdsFromNewLinesThen.CheckedChanged
			Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
				SelectFormat.ConditionalOperatorsFormat.NewLineBeforeThen = chBxResultKwrdsFromNewLinesThen.Checked

				FormattingOptions.NotifyUpdated()
			End Using
		End Sub

		Private Sub chBxBranchResultExprsFromNewLines_CheckedChanged(sender As Object, e As EventArgs) Handles chBxBranchResultExprsFromNewLines.CheckedChanged
			Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
				SelectFormat.ConditionalOperatorsFormat.NewLineAfterThen = chBxBranchResultExprsFromNewLines.Checked

				FormattingOptions.NotifyUpdated()
			End Using
		End Sub

		Private Sub UpDownBranchKeyWrdsIndent_ValueChanged(sender As Object, e As EventArgs) Handles UpDownBranchKeyWrdsIndent.ValueChanged
			Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
				SelectFormat.ConditionalOperatorsFormat.IndentBranch = CInt(Fix(UpDownBranchKeyWrdsIndent.Value))

				FormattingOptions.NotifyUpdated()
			End Using
		End Sub

		Private Sub UpDownExprsIndent_ValueChanged(sender As Object, e As EventArgs) Handles UpDownExprsIndent.ValueChanged
			Using TempUpdateRegion As UpdateRegion = New UpdateRegion(FormattingOptions)
				SelectFormat.ConditionalOperatorsFormat.IndentExpressions = CInt(Fix(UpDownExprsIndent.Value))

				FormattingOptions.NotifyUpdated()
			End Using
		End Sub
	End Class
End Namespace
