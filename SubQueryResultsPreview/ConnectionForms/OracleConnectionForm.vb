'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Data.OracleClient
Imports System.Windows.Forms

Public Partial Class OracleConnectionForm
	Inherits Form
	Public ConnectionString As String = ""

	Public Sub New()
		InitializeComponent()

			'1 - Oracle Server Authentication
		comboBoxAuthentication.SelectedIndex = 1
	End Sub

	Private Sub comboBoxAuthentication_SelectedIndexChanged(sender As Object, e As EventArgs)
		If comboBoxAuthentication.SelectedIndex = 0 Then
			'Windows Authentication
			textBoxLogin.Enabled = False
			textBoxPassword.Enabled = False
		Else
			'Oracle Server Authentication
			textBoxLogin.Enabled = True
			textBoxPassword.Enabled = True
		End If
	End Sub

	Private Sub buttonConnect_Click(sender As Object, e As EventArgs)
		Dim builder As New OracleConnectionStringBuilder()

		builder.DataSource = textBoxServerName.Text

		If comboBoxAuthentication.SelectedIndex = 0 Then
			builder.IntegratedSecurity = True
		Else
			builder.IntegratedSecurity = False
			builder.UserID = textBoxLogin.Text
			builder.Password = textBoxPassword.Text
		End If

		' check the connection

		Using connection As New OracleConnection(builder.ConnectionString)
			Me.Cursor = Cursors.WaitCursor

			Try
				connection.Open()
				ConnectionString = builder.ConnectionString
			Catch ex As System.Exception
				MessageBox.Show(ex.Message, "Connection Failure.")
				Me.DialogResult = DialogResult.None
			Finally
				Me.Cursor = Cursors.[Default]
			End Try
		End Using
	End Sub
End Class
