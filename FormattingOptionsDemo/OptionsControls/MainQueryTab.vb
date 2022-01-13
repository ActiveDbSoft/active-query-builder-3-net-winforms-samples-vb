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
    Partial Public Class MainQueryTab
        Inherits UserControl
        Implements IOptionsLoader
        Public Property Builder() As FormattedSQLBuilder
        Public Property Options() As SQLFormattingOptions

        Public Sub New(builder As FormattedSQLBuilder)
            Options = CType(builder.Options, SQLFormattingOptions)

            InitializeComponent()

            chBxEnableDynamicIndents.Checked = Options.DynamicIndents
            chBxEnableDynamicRightMargin.Checked = Options.DynamicRightMargin

            LoadOptionsOnForm()
        End Sub

        ' Load options to form
        Public Sub LoadOptionsOnForm() Implements IOptionsLoader.LoadOptionsOnForm
            upDownMaxCharsInLine.Value = Options.RightMargin
            chBxParenthesizeConditionsWithinAndOperators.Checked = Options.ParenthesizeANDGroups
            chBxParenthesizeEachSingleCondition.Checked = Options.ParenthesizeSingleCriterion

            Select Case Options.KeywordFormat
                Case KeywordFormat.FirstUpper
                    cmbBoxKeyWordsCase.Text = "FirstUpper"
                Case KeywordFormat.UpperCase
                    cmbBoxKeyWordsCase.Text = "UpperCase"
                Case KeywordFormat.LowerCase
                    cmbBoxKeyWordsCase.Text = "LowerCase"
            End Select
        End Sub
        ' Load options from form
        Public Sub LoadOptionsFromForm() Implements IOptionsLoader.LoadOptionsFromForm
            Options.DynamicIndents = chBxEnableDynamicIndents.Checked
            Options.DynamicRightMargin = chBxEnableDynamicRightMargin.Checked
            Options.ParenthesizeSingleCriterion = chBxParenthesizeEachSingleCondition.Checked
            Options.ParenthesizeANDGroups = chBxParenthesizeConditionsWithinAndOperators.Checked
            Options.RightMargin = CInt(Fix(upDownMaxCharsInLine.Value))

            Select Case cmbBoxKeyWordsCase.SelectedIndex
                Case 0
                    Options.KeywordFormat = KeywordFormat.FirstUpper
                Case 1
                    Options.KeywordFormat = KeywordFormat.UpperCase
                Case 2
                    Options.KeywordFormat = KeywordFormat.LowerCase
            End Select
        End Sub

        Private Sub chBxEnableWordWrap_CheckedChanged(sender As Object, e As EventArgs) Handles chBxEnableWordWrap.CheckedChanged
            If Not chBxEnableWordWrap.Checked Then
                Options.RightMargin = 80
            Else
                Options.RightMargin = CInt(Fix(upDownMaxCharsInLine.Value))
            End If
        End Sub

        Private Sub chBxEnableDynamicIndents_CheckedChanged(sender As Object, e As EventArgs) Handles chBxEnableDynamicIndents.CheckedChanged
            Options.DynamicIndents = chBxEnableDynamicIndents.Checked
        End Sub

        Private Sub chBxEnableDynamicRightMargin_CheckedChanged(sender As Object, e As EventArgs) Handles chBxEnableDynamicRightMargin.CheckedChanged
            Options.DynamicRightMargin = chBxEnableDynamicRightMargin.Checked
        End Sub

        Private Sub chBxParenthesizeConditionsWithinAndOperators_CheckedChanged(sender As Object, e As EventArgs) Handles chBxParenthesizeConditionsWithinAndOperators.CheckedChanged
            Options.ParenthesizeANDGroups = chBxParenthesizeConditionsWithinAndOperators.Checked
        End Sub

        Private Sub chBxParenthesizeEachSingleCondition_CheckedChanged(sender As Object, e As EventArgs) Handles chBxParenthesizeEachSingleCondition.CheckedChanged
            Options.ParenthesizeSingleCriterion = chBxParenthesizeEachSingleCondition.Checked
        End Sub

        Private Sub upDownMaxCharsInLine_ValueChanged(sender As Object, e As EventArgs) Handles upDownMaxCharsInLine.ValueChanged
            If chBxEnableWordWrap.Checked Then
                Options.RightMargin = CInt(Fix(upDownMaxCharsInLine.Value))
            End If
        End Sub

        Private Sub cmbBoxKeyWordsCase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBoxKeyWordsCase.SelectedIndexChanged
            Select Case cmbBoxKeyWordsCase.SelectedIndex
                Case 0
                    Options.KeywordFormat = KeywordFormat.FirstUpper
                Case 1
                    Options.KeywordFormat = KeywordFormat.UpperCase
                Case 2
                    Options.KeywordFormat = KeywordFormat.LowerCase
            End Select
        End Sub
    End Class
End Namespace
