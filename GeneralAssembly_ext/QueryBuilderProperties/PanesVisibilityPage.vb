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
Imports ActiveQueryBuilder.View.WinForms

Namespace QueryBuilderProperties
	<ToolboxItem(False)>
	Partial Friend Class PanesVisibilityPage
		Inherits UserControl
		Private _queryBuilder As QueryBuilder = Nothing
		Private _modified As Boolean = False


		Public Property Modified() As Boolean
			Get
				Return _modified
			End Get
			Set(value As Boolean)
				_modified = value
			End Set
		End Property


		Public Sub New(qb As QueryBuilder)
			_queryBuilder = qb

			InitializeComponent()

			cbShowDesignPane.Checked = _queryBuilder.PanesConfigurationOptions.DesignPaneVisible
			cbShowQueryColumnsPane.Checked = _queryBuilder.PanesConfigurationOptions.QueryColumnsPaneVisible
			cbShowDatabaseSchemaView.Checked = _queryBuilder.PanesConfigurationOptions.DatabaseSchemaViewVisible
			cbShowQueryNavigationBar.Checked = _queryBuilder.PanesConfigurationOptions.QueryNavigationBarVisible

			AddHandler cbShowDesignPane.CheckedChanged, AddressOf Changed
			AddHandler cbShowQueryColumnsPane.CheckedChanged, AddressOf Changed
			AddHandler cbShowDatabaseSchemaView.CheckedChanged, AddressOf Changed
			AddHandler cbShowQueryNavigationBar.CheckedChanged, AddressOf Changed
		End Sub

		Protected Overrides Overloads Sub Dispose(disposing As Boolean)
			RemoveHandler cbShowDesignPane.CheckedChanged, AddressOf Changed
			RemoveHandler cbShowQueryColumnsPane.CheckedChanged, AddressOf Changed
			RemoveHandler cbShowDatabaseSchemaView.CheckedChanged, AddressOf Changed
			RemoveHandler cbShowQueryNavigationBar.CheckedChanged, AddressOf Changed

			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If

			MyBase.Dispose(disposing)
		End Sub

		Private Sub Changed(sender As Object, e As EventArgs)
			If sender Is cbShowDesignPane Then
				If (Not cbShowDesignPane.Checked) AndAlso (Not cbShowQueryColumnsPane.Checked) Then
					cbShowQueryColumnsPane.Checked = True
				End If
			ElseIf sender Is cbShowQueryColumnsPane Then
				If (Not cbShowDesignPane.Checked) AndAlso (Not cbShowQueryColumnsPane.Checked) Then
					cbShowDesignPane.Checked = True
				End If
			End If

			Modified = True
		End Sub

		Public Sub ApplyChanges()
			If Modified Then
				_queryBuilder.PanesConfigurationOptions.BeginUpdate()

				Try
					_queryBuilder.PanesConfigurationOptions.DesignPaneVisible = cbShowDesignPane.Checked
					_queryBuilder.PanesConfigurationOptions.QueryColumnsPaneVisible = cbShowQueryColumnsPane.Checked
					_queryBuilder.PanesConfigurationOptions.DatabaseSchemaViewVisible = cbShowDatabaseSchemaView.Checked
					_queryBuilder.PanesConfigurationOptions.QueryNavigationBarVisible = cbShowQueryNavigationBar.Checked
				Finally
					_queryBuilder.PanesConfigurationOptions.EndUpdate()
				End Try
			End If
		End Sub
	End Class
End Namespace
