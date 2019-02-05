'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports Npgsql

Public Partial Class PostgreSQLConnectionForm
	Inherits Form
	Public ConnectionString As String = ""


	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub buttonConnect_Click(sender As Object, e As EventArgs)
		Dim connectionString As String = "Server=" & tbServer.Text & ";Port=" & tbPort.Text & ";Database=" & tbDatabase.Text & ";Userid=" & tbLogin.Text & ";Password=" & tbPassword.Text

		Me.ConnectionString = connectionString
	End Sub
End Class
