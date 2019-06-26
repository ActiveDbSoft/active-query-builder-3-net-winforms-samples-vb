'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Collections.ObjectModel
Imports System.Drawing
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core

Namespace Common
    Partial Friend Class ErrorBox
        Inherits UserControl

        Private _allowChangedSyntax As Boolean = True
        Public Event SyntaxProviderChanged As EventHandler
        Public Event GoToErrorPositionEvent As EventHandler
        Public Event RevertValidTextEvent As EventHandler
        Public Property CurrentSyntaxProvider As BaseSyntaxProvider
        Public ReadOnly Property SyntaxProviders As ObservableCollection(Of BaseSyntaxProvider)

        Public Property Message As String
            Get
                Return labelMessage.Text
            End Get
            Set(ByVal value As String)
                labelMessage.Text = value
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
            SyntaxProviders = New ObservableCollection(Of BaseSyntaxProvider)()
            AddHandler SyntaxProviders.CollectionChanged, AddressOf SyntaxProviders_CollectionChanged
        End Sub

        Public Sub SetSyntaxProvider(ByVal baseSyntaxProvider As BaseSyntaxProvider)
            CurrentSyntaxProvider = baseSyntaxProvider
            _allowChangedSyntax = False
            If CurrentSyntaxProvider IsNot Nothing Then comboBoxSyntaxProvider.Text = CurrentSyntaxProvider.ToString()
            _allowChangedSyntax = True
        End Sub

        Private Sub SyntaxProviders_CollectionChanged(ByVal sender As Object, ByVal e As System.Collections.Specialized.NotifyCollectionChangedEventArgs)
            comboBoxSyntaxProvider.Items.Clear()

            For Each baseSyntaxProvider As BaseSyntaxProvider In SyntaxProviders
                comboBoxSyntaxProvider.Items.Add(New ComboBoxItem(baseSyntaxProvider))
            Next
        End Sub

        Public Overloads Sub Dispose()
            RemoveHandler SyntaxProviders.CollectionChanged, AddressOf SyntaxProviders_CollectionChanged
            MyBase.Dispose()
        End Sub

        Protected Overridable Sub OnSyntaxProviderChanged()
            If Not _allowChangedSyntax Then Return
            CurrentSyntaxProvider = (CType(comboBoxSyntaxProvider.SelectedItem, ComboBoxItem)).SyntaxProvider
            RaiseEvent SyntaxProviderChanged(Me, EventArgs.Empty)
            
        End Sub

        Protected Overridable Sub OnGoToErrorPositionEvent()
            RaiseEvent GoToErrorPositionEvent(Me, EventArgs.Empty)
        End Sub

        Protected Overridable Sub OnRevertValidTextEvent()
            RaiseEvent RevertValidTextEvent(Me, EventArgs.Empty)
        End Sub

        Private Sub linkLabelGoTo_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabelGoTo.LinkClicked
            OnGoToErrorPositionEvent()
        End Sub

        Private Sub linkLabelRevert_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabelRevert.LinkClicked
            OnRevertValidTextEvent()
        End Sub

        Private Sub comboBoxSyntaxProvider_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxSyntaxProvider.SelectedIndexChanged
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

        Public Sub New()
        End Sub

        Public Sub New(ByVal provider As BaseSyntaxProvider)
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
            Set(ByVal value As Boolean)
                MyBase.AutoSize = value
            End Set
        End Property

        Private Sub resizeLabel()
            If _mGrowing Then Return

            Try
                _mGrowing = True
                Dim sz As Size = New Size(Me.Width, Int32.MaxValue)
                sz = TextRenderer.MeasureText(Me.Text, Me.Font, sz, TextFormatFlags.WordBreak)
                Me.Height = sz.Height
            Finally
                _mGrowing = False
            End Try
        End Sub

        Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
            MyBase.OnTextChanged(e)
            resizeLabel()
        End Sub

        Protected Overrides Sub OnFontChanged(ByVal e As EventArgs)
            MyBase.OnFontChanged(e)
            resizeLabel()
        End Sub

        Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
            MyBase.OnSizeChanged(e)
            resizeLabel()
        End Sub
    End Class

End Namespace
