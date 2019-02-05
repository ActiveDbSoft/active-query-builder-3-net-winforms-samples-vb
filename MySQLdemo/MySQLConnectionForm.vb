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
Imports MySql.Data.MySqlClient

Public Partial Class MySQLConnectionForm
	Inherits Form
	Public ConnectionString As String = ""


	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub buttonConnect_Click(sender As Object, e As EventArgs)
		Dim builder As New MySqlConnectionStringBuilder()

		builder.Server = tbServer.Text
		builder.Database = tbDatabase.Text
		builder.UserID = tbUser.Text
		'builder.UseOldSyntax = true;

		If tbPassword.Text.Length > 0 Then
			builder.Password = tbPassword.Text
		End If

		Me.ConnectionString = builder.ConnectionString
	End Sub
End Class
