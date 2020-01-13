﻿'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Data.Common
Imports System.Windows.Forms

Public Partial Class QueryParametersForm
	Inherits Form
	Private ReadOnly _command As DbCommand

	Public Sub New(command As DbCommand)
		_command = command

		InitializeComponent()

		For i As Integer = 0 To _command.Parameters.Count - 1
			Dim p As DbParameter = _command.Parameters(i)

			grid.Rows.Add()
			grid.Rows(i).Cells(0).Value = p.ParameterName
			grid.Rows(i).Cells(1).Value = p.DbType
			grid.Rows(i).Cells(2).Value = p.Value
		Next
	End Sub

	Private Sub buttonOk_Click(sender As Object, e As EventArgs)
		For i As Integer = 0 To _command.Parameters.Count - 1
			_command.Parameters(i).Value = grid.Rows(i).Cells(2).Value
		Next
	End Sub
End Class
