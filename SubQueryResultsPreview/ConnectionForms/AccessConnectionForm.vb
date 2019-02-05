'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Data.OleDb
Imports System.Windows.Forms

Public Partial Class AccessConnectionForm
	Inherits Form
	Public ConnectionString As String = ""

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub buttonConnect_Click(sender As Object, e As EventArgs)
		ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0"
		ConnectionString += ";Data Source=" & textboxDatabase.Text
		ConnectionString += ";User Id=" & textboxUserName.Text
		ConnectionString += ";Password="

		If textboxPassword.Text.Length > 0 Then
			ConnectionString += textboxPassword.Text & ";"
		End If

		' check the connection

		Using connection As New OleDbConnection(ConnectionString)
			Me.Cursor = Cursors.WaitCursor

			Try
				connection.Open()
			Catch ex As System.Exception
				MessageBox.Show(ex.Message, "Connection Failure.")
				Me.DialogResult = DialogResult.None
			Finally
				Me.Cursor = Cursors.[Default]
			End Try
		End Using
	End Sub

	Private Sub buttonBrowse_Click(sender As Object, e As EventArgs)
		If openFileDialog1.ShowDialog() = DialogResult.OK Then
			textboxDatabase.Text = openFileDialog1.FileName
		End If
	End Sub
End Class
