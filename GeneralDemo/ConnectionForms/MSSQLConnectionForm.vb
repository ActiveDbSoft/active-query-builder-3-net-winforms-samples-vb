'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Partial Class MSSQLConnectionForm
	Inherits Form
	Public ConnectionString As String = ""

	Public Sub New()
		InitializeComponent()

		comboBoxAuthentication.SelectedIndex = 0
		'0 - Windows Authentication
		comboBoxDatabase.SelectedIndex = 0

		textBoxLogin.Enabled = False
		textBoxPassword.Enabled = False
	End Sub

	Private Sub comboBoxAuthentication_SelectedIndexChanged(sender As Object, e As EventArgs)
		If comboBoxAuthentication.SelectedIndex = 0 Then
			'Windows Authentication
			textBoxLogin.Enabled = False
			textBoxPassword.Enabled = False
		Else
			'SQL Server Authentication
			textBoxLogin.Enabled = True
			textBoxPassword.Enabled = True
		End If
	End Sub

	Private Sub comboBoxDatabase_DropDown(sender As Object, e As EventArgs)
		' Fill the drop down list with available database names

		Dim builder As New SqlConnectionStringBuilder()

		builder.DataSource = textBoxServerName.Text

		If comboBoxAuthentication.SelectedIndex = 0 Then
			builder.IntegratedSecurity = True
		Else
			builder.IntegratedSecurity = False
			builder.UserID = textBoxLogin.Text
			builder.Password = textBoxPassword.Text
		End If

		' try to connect
		Using connection As New SqlConnection(builder.ConnectionString)
			Me.Cursor = Cursors.WaitCursor

			Dim currentDatabase As String = comboBoxDatabase.SelectedItem.ToString()

			comboBoxDatabase.Items.Clear()
			comboBoxDatabase.Items.Add("<default>")
			comboBoxDatabase.SelectedIndex = 0

			Try
				connection.Open()

				' connected successfully
				' retrieve available databases

				Dim schemaTable As DataTable = connection.GetSchema("Databases")

				For Each r As DataRow In schemaTable.Rows
					comboBoxDatabase.Items.Add(r(0))
				Next

				comboBoxDatabase.SelectedItem = currentDatabase
			Catch ex As System.Exception
				MessageBox.Show(ex.Message, "Connection Failure.")
			Finally
				Me.Cursor = Cursors.[Default]
			End Try
		End Using
	End Sub

	Private Sub buttonConnect_Click(sender As Object, e As EventArgs)
		Dim builder As New SqlConnectionStringBuilder()

		builder.DataSource = textBoxServerName.Text

		If comboBoxAuthentication.SelectedIndex = 0 Then
			builder.IntegratedSecurity = True
		Else
			builder.IntegratedSecurity = False
			builder.UserID = textBoxLogin.Text
			builder.Password = textBoxPassword.Text
		End If

		If comboBoxDatabase.SelectedIndex > 0 Then
			builder.InitialCatalog = comboBoxDatabase.SelectedItem.ToString()
		End If

		' check the connection

		Using connection As New SqlConnection(builder.ConnectionString)
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
