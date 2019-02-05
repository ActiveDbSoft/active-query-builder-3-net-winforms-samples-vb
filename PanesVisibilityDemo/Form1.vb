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

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub cbRightPane_CheckedChanged(sender As Object, e As EventArgs)
		queryBuilder.PanesConfigurationOptions.DatabaseSchemaViewVisible = cbRightPane.Checked
	End Sub

	Private Sub cbDesignPane_CheckedChanged(sender As Object, e As EventArgs)
		queryBuilder.PanesConfigurationOptions.DesignPaneVisible = cbDesignPane.Checked

		' Design Pane and Query Columns Pane can't be invisible both
		If Not cbDesignPane.Checked AndAlso Not cbQueryColumnsPane.Checked Then
			cbQueryColumnsPane.Checked = True
		End If
	End Sub

	Private Sub cbQueryColumnsPane_CheckedChanged(sender As Object, e As EventArgs)
		queryBuilder.PanesConfigurationOptions.QueryColumnsPaneVisible = cbQueryColumnsPane.Checked

		' Design Pane and Query Columns Pane can't be invisible both
		If Not cbDesignPane.Checked AndAlso Not cbQueryColumnsPane.Checked Then
			cbDesignPane.Checked = True
		End If
	End Sub
End Class
