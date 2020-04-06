'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.ComponentModel

Namespace DataViewerControl
	Partial Public Class PaginationPanel
		Inherits UserControl
		Public Event EnabledPaginationChanged As EventHandler
		Public Event CurrentPageChanged As EventHandler
		Public Event PageSizeChanged As EventHandler

		Public Property IsSupportLimitCount() As Boolean
			Get
				Return tbPageSize.Visible
			End Get
			Set(value As Boolean)
				tbPageSize.Visible = value
				labelPageSize.Visible = value
			End Set
		End Property

		Public Property IsSupportLimitOffset() As Boolean
			Get
				Return tbCurrentPage.Visible
			End Get
			Set(value As Boolean)
				tbCurrentPage.Visible = value
				labelCurrentPage.Visible = value
				btnNextPage.Visible = value
				btnPrevPage.Visible = value
			End Set
		End Property

		Public Property PageSize() As Integer
			Get
				Dim value As Integer
				Return If(Integer.TryParse(tbPageSize.Text, value), value, 0)
			End Get
			Set(value As Integer)
				tbPageSize.Text = value.ToString()
			End Set
		End Property

		Public Property CurrentPage() As Integer
			Get
				Dim value As Integer
				Return If(Integer.TryParse(tbCurrentPage.Text, value), value, 0)
			End Get
			Set(value As Integer)
				tbCurrentPage.Text = value.ToString()
			End Set
		End Property

		<Browsable(False)>
		Public Property RowsCount() As Integer

		Public ReadOnly Property PaginationEnabled() As Boolean
			Get
				Return ceEnabled.Checked
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub Clear()
			ToggleEnabled(False)
			ceEnabled.Checked = False
			CurrentPage = 1
			PageSize = 10
		End Sub

		Private Sub ToggleEnabled(value As Boolean)
			tbCurrentPage.ReadOnly = Not value
			tbPageSize.ReadOnly = Not value
			btnNextPage.Enabled = value
			btnPrevPage.Enabled = value
		End Sub

		Private Sub intTextBox_Validating(sender As Object, e As CancelEventArgs) Handles tbCurrentPage.Validating, tbPageSize.Validating
			Dim tb As TextBox = TryCast(sender, TextBox)
			If tb Is Nothing Then
				Return
			End If
			Dim value As Integer
			If Not Integer.TryParse(tb.Text, value) Then
				e.Cancel = True
			End If
		End Sub

		Private Sub ceEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles ceEnabled.CheckedChanged
			ToggleEnabled(ceEnabled.Checked)
			RaiseEvent EnabledPaginationChanged(Me, e)
		End Sub

		Private Sub btnPrevPage_Click(sender As Object, e As EventArgs) Handles btnPrevPage.Click
			Dim currentPage As Integer = Me.CurrentPage
			If currentPage = 1 Then
				Return
			End If
			Me.CurrentPage = currentPage - 1
			RaiseEvent CurrentPageChanged(Me, e)
		End Sub

		Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
			Dim currentPage As Integer = Me.CurrentPage
			Me.CurrentPage = currentPage + 1
			RaiseEvent CurrentPageChanged(Me, e)
		End Sub

		Private Sub tbCurrentPage_Validated(sender As Object, e As EventArgs) Handles tbCurrentPage.Validated
			RaiseEvent CurrentPageChanged(Me, e)
		End Sub

		Private Sub tbPageSize_Validated(sender As Object, e As EventArgs) Handles tbPageSize.Validated
			RaiseEvent PageSizeChanged(Me, e)
		End Sub

		Private Sub tbPageSize_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCurrentPage.KeyDown, tbPageSize.KeyDown
			If e.KeyCode = Keys.Enter Then
				Validate()
			End If
		End Sub
	End Class
End Namespace
