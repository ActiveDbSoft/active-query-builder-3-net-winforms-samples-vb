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
Imports System.Windows.Forms
Imports ActiveQueryBuilder.View.QueryView
Imports ActiveQueryBuilder.View.WinForms

Namespace PropertiesForm
	<ToolboxItem(False)> _
	Friend Partial Class MiscellaneousPage
		Inherits UserControl
        Private ReadOnly _queryBuilder As QueryBuilder = Nothing

        Public Property Modified As Boolean = False

        Public Sub New(qb As QueryBuilder)
            _queryBuilder = qb

            InitializeComponent()

            comboLinksStyle.Items.Add("Simple style")
            comboLinksStyle.Items.Add("MS Access style")
            comboLinksStyle.Items.Add("SQL Server Enterprise Manager style")

            If _queryBuilder.DesignPaneOptions.LinkStyle = LinkStyle.Simple Then
                comboLinksStyle.SelectedIndex = 0
            ElseIf _queryBuilder.DesignPaneOptions.LinkStyle = LinkStyle.MSAccess Then
                comboLinksStyle.SelectedIndex = 1
            ElseIf _queryBuilder.DesignPaneOptions.LinkStyle = LinkStyle.MSSQL Then
                comboLinksStyle.SelectedIndex = 2
            End If

            AddHandler comboLinksStyle.SelectedIndexChanged, AddressOf Changed
        End Sub

        Protected Overrides Sub Dispose(disposing As Boolean)
			RemoveHandler comboLinksStyle.SelectedIndexChanged, AddressOf Changed

			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If

			MyBase.Dispose(disposing)
		End Sub

		Public Sub ApplyChanges()
			If Modified Then
				Select Case comboLinksStyle.SelectedIndex
					Case 0
						_queryBuilder.DesignPaneOptions.LinkStyle = LinkStyle.Simple
						Exit Select
					Case 2
						_queryBuilder.DesignPaneOptions.LinkStyle = LinkStyle.MSSQL
						Exit Select
					Case Else
						_queryBuilder.DesignPaneOptions.LinkStyle = LinkStyle.MSAccess
						Exit Select
				End Select
			End If
		End Sub

		Private Sub Changed(sender As Object, e As EventArgs)
			Modified = True
		End Sub
	End Class
End Namespace
