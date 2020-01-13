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
	Public Partial Class MainQueryTab
		Inherits UserControl
		Public Property Options() As SQLFormattingOptions
			Get
				Return m_Options
			End Get
			Set
				m_Options = Value
			End Set
		End Property
		Private m_Options As SQLFormattingOptions

		Public Sub New(options__1 As SQLFormattingOptions)
			InitializeComponent()
			Options = options__1

			LoadOptions()
		End Sub

		' Load options to form
		Public Sub LoadOptions()
			chBxEnableDynamicIndents.Checked = Options.DynamicIndents
			chBxEnableDynamicRightMargin.Checked = Options.DynamicRightMargin

			If Options.RightMargin > 0 Then
				chBxEnableWordWrap.Checked = False
				upDownMaxCharsInLine.Value = Options.RightMargin
			Else
				' no margin
				chBxEnableWordWrap.Checked = False
				upDownMaxCharsInLine.Value = 80
			End If
			chBxParenthesizeConditionsWithinAndOperators.Checked = Options.ParenthesizeANDGroups
			chBxParenthesizeEachSingleCondition.Checked = Options.ParenthesizeSingleCriterion

			Select Case Options.KeywordFormat
				Case KeywordFormat.FirstUpper
					cmbBoxKeyWordsCase.Text = "FirstUpper"
					Exit Select
				Case KeywordFormat.UpperCase
					cmbBoxKeyWordsCase.Text = "UpperCase"
					Exit Select
				Case KeywordFormat.LowerCase
					cmbBoxKeyWordsCase.Text = "LowerCase"
					Exit Select
			End Select
		End Sub

		Private Sub chBxEnableWordWrap_CheckedChanged(sender As Object, e As EventArgs)
			If Not chBxEnableWordWrap.Checked Then
				Options.RightMargin = 0
			Else
				Options.RightMargin = CInt(Math.Truncate(upDownMaxCharsInLine.Value))
			End If
		End Sub

		Private Sub chBxEnableDynamicIndents_CheckedChanged(sender As Object, e As EventArgs)
			Options.DynamicIndents = chBxEnableDynamicIndents.Checked
		End Sub

		Private Sub chBxEnableDynamicRightMargin_CheckedChanged(sender As Object, e As EventArgs)
			Options.DynamicRightMargin = chBxEnableDynamicRightMargin.Checked
		End Sub

		Private Sub chBxParenthesizeConditionsWithinAndOperators_CheckedChanged(sender As Object, e As EventArgs)
			Options.ParenthesizeANDGroups = chBxParenthesizeConditionsWithinAndOperators.Checked
		End Sub

		Private Sub chBxParenthesizeEachSingleCondition_CheckedChanged(sender As Object, e As EventArgs)
			Options.ParenthesizeSingleCriterion = chBxParenthesizeEachSingleCondition.Checked
		End Sub

		Private Sub upDownMaxCharsInLine_ValueChanged(sender As Object, e As EventArgs)
			If chBxEnableWordWrap.Checked Then
				Options.RightMargin = CInt(Math.Truncate(upDownMaxCharsInLine.Value))
			End If
		End Sub

		Private Sub cmbBoxKeyWordsCase_SelectedIndexChanged(sender As Object, e As EventArgs)
			Select Case cmbBoxKeyWordsCase.SelectedIndex
				Case 0
					Options.KeywordFormat = KeywordFormat.FirstUpper
					Exit Select
				Case 1
					Options.KeywordFormat = KeywordFormat.UpperCase
					Exit Select
				Case 2
					Options.KeywordFormat = KeywordFormat.LowerCase
					Exit Select
			End Select
		End Sub
	End Class
End Namespace
