''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2024 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports ActiveQueryBuilder.Core

Namespace PropertiesForm
    Partial Public Class MainQueryTab
        Inherits UserControl
        Public Property Options() As SQLFormattingOptions

        Public Sub New(options As SQLFormattingOptions)
            Me.Options = options

            InitializeComponent()
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
                Case KeywordFormat.UpperCase
                    cmbBoxKeyWordsCase.Text = "UpperCase"
                Case KeywordFormat.LowerCase
                    cmbBoxKeyWordsCase.Text = "LowerCase"
            End Select
        End Sub

        Private Sub chBxEnableWordWrap_CheckedChanged(sender As Object, e As EventArgs) Handles chBxEnableWordWrap.CheckedChanged
            If Not chBxEnableWordWrap.Checked Then
                Options.RightMargin = 0
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
