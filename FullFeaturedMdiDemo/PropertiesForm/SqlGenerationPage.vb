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

Namespace PropertiesForm
    Partial Public Class SqlGenerationPage
        Inherits UserControl
        Private ReadOnly _generationOptions As SQLGenerationOptions
        Private ReadOnly _formattingOptions As SQLFormattingOptions

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(generationOptions As SQLGenerationOptions, formattingOptions As SQLFormattingOptions)
            Me.New()
            _generationOptions = generationOptions
            _formattingOptions = formattingOptions

            For Each value In System.Enum.GetValues(_generationOptions.ObjectPrefixSkipping.GetType())
                cbObjectPrefixSkipping.Items.Add(value)
            Next value

            cbObjectPrefixSkipping.SelectedItem = _generationOptions.ObjectPrefixSkipping
            cbQuoteAllIdentifiers.Checked = _generationOptions.QuoteIdentifiers = IdentQuotation.All
        End Sub

        Private Sub cbQuoteAllIdentifiers_CheckedChanged(sender As Object, e As EventArgs) Handles cbQuoteAllIdentifiers.CheckedChanged
            _generationOptions.QuoteIdentifiers = If(cbQuoteAllIdentifiers.Checked, IdentQuotation.All, IdentQuotation.IfNeed)
            _formattingOptions.QuoteIdentifiers = If(cbQuoteAllIdentifiers.Checked, IdentQuotation.All, IdentQuotation.IfNeed)
        End Sub

        Private Sub cbObjectPrefixSkipping_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbObjectPrefixSkipping.SelectedIndexChanged
            _formattingOptions.ObjectPrefixSkipping = CType(cbObjectPrefixSkipping.SelectedItem, ObjectPrefixSkipping)
            _generationOptions.ObjectPrefixSkipping = CType(cbObjectPrefixSkipping.SelectedItem, ObjectPrefixSkipping)
        End Sub
    End Class
End Namespace
