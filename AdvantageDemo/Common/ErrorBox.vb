'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core

Namespace Common
    Friend Partial Class ErrorBox
        Inherits UserControl

        Private _allowChangedSyntax As Boolean = True

        <Browsable(True)>
        Public Property IsVisibleCheckSyntaxPanel As Boolean
            Get
                Return panelCheckSyntax.Visible
            End Get
            Set
                panelCheckSyntax.Visible = Value
            End Set
        End Property

        Public Event SyntaxProviderChanged As EventHandler
        Public Event GoToErrorPosition As EventHandler
        Public Event RevertValidText As EventHandler
        Public Property CurrentSyntaxProvider As BaseSyntaxProvider

        Public Sub New()
            InitializeComponent()
            Visible = False
            comboBoxSyntaxProvider.Items.Clear()

            For Each baseSyntaxProvider As Type In Helpers.SyntaxProviderList
                Dim instance As BaseSyntaxProvider = TryCast(Activator.CreateInstance(baseSyntaxProvider), BaseSyntaxProvider)
                comboBoxSyntaxProvider.Items.Add(New ComboBoxItem(instance))
            Next
        End Sub

        Public Overloads Sub Show(message As String, baseSyntaxProvider As BaseSyntaxProvider)
            labelMessage.Text = message

            If String.IsNullOrEmpty(message) Then
                Visible = False
                Return
            End If

            Visible = True
            CurrentSyntaxProvider = baseSyntaxProvider
            _allowChangedSyntax = False
            If CurrentSyntaxProvider IsNot Nothing Then comboBoxSyntaxProvider.Text = CurrentSyntaxProvider.ToString()
            _allowChangedSyntax = True
        End Sub

        Protected Overridable Sub OnSyntaxProviderChanged()
            If Not _allowChangedSyntax Then Return
            CurrentSyntaxProvider = (CType(comboBoxSyntaxProvider.SelectedItem, ComboBoxItem)).SyntaxProvider
            RaiseEvent SyntaxProviderChanged(Me, EventArgs.Empty)
            Visible = False
        End Sub

        Protected Overridable Sub OnGoToErrorPositionEvent()
            RaiseEvent GoToErrorPosition(Me, EventArgs.Empty)
            Visible = False
        End Sub

        Protected Overridable Sub OnRevertValidTextEvent()
            RaiseEvent RevertValidText(Me, EventArgs.Empty)
            Visible = False
        End Sub

        Private Sub linkLabelGoTo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
            OnGoToErrorPositionEvent()
        End Sub

        Private Sub linkLabelRevert_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
            OnRevertValidTextEvent()
        End Sub

        Private Sub comboBoxSyntaxProvider_SelectedValueChanged(sender As Object, e As EventArgs)
            OnSyntaxProviderChanged()
        End Sub
    End Class

    Friend Class ComboBoxItem
        Public ReadOnly Property SyntaxProvider As BaseSyntaxProvider

        Public ReadOnly Property DisplayString As String
            Get
                Return SyntaxProvider.ToString()
            End Get
        End Property

        Public Sub New(provider As BaseSyntaxProvider)
            SyntaxProvider = provider
        End Sub
    End Class

    Friend Class GrowLabel
        Inherits Label

        Private _mGrowing As Boolean

        Public Sub New()
            AutoSize = False
        End Sub

        Public NotOverridable Overrides Property AutoSize As Boolean
            Get
                Return MyBase.AutoSize
            End Get
            Set
                MyBase.AutoSize = Value
            End Set
        End Property

        Private Sub ResizeLabel()
            If _mGrowing Then Return

            Try
                _mGrowing = True
                Dim sz As Size = New Size(Width, Integer.MaxValue)
                sz = TextRenderer.MeasureText(Text, Font, sz, TextFormatFlags.WordBreak)
                Height = sz.Height
            Finally
                _mGrowing = False
            End Try
        End Sub

        Protected Overrides Sub OnTextChanged(e As EventArgs)
            MyBase.OnTextChanged(e)
            resizeLabel()
        End Sub

        Protected Overrides Sub OnFontChanged(e As EventArgs)
            MyBase.OnFontChanged(e)
            resizeLabel()
        End Sub

        Protected Overrides Sub OnSizeChanged(e As EventArgs)
            MyBase.OnSizeChanged(e)
            resizeLabel()
        End Sub
    End Class
End Namespace
