'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports Oracle.ManagedDataAccess.Client
Imports System.Windows.Forms

Public Partial Class OracleConnectionForm
	Inherits Form
	Public ConnectionString As String = ""

	Public Sub New()
		InitializeComponent()

		AddHandler buttonConnect.Click, New EventHandler(AddressOf buttonConnect_Click)
	End Sub

	Private Sub buttonConnect_Click(sender As Object, e As EventArgs)
		Dim builder As New OracleConnectionStringBuilder()

		builder.DataSource = textBoxServerName.Text

		builder.UserID = textBoxLogin.Text
		builder.Password = textBoxPassword.Text

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
