'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
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

Imports FirebirdSql.Data.FirebirdClient


Public Partial Class FirebirdConnectionForm
	Inherits Form
	Public ConnectionString As String = ""


	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub buttonBrowse_Click(sender As Object, e As EventArgs)
		If openFileDialog1.ShowDialog() = DialogResult.OK Then
			textboxDatabase.Text = openFileDialog1.FileName
		End If
	End Sub

	Private Sub buttonConnect_Click(sender As Object, e As EventArgs)

		Dim builder As New FbConnectionStringBuilder()

		builder.DataSource = textboxServer.Text
		builder.Database = textboxDatabase.Text

		If textboxUser.Text.Length > 0 Then
			builder.UserID = textboxUser.Text
		End If

		If textboxPassword.Text.Length > 0 Then
			builder.Password = textboxPassword.Text
		End If

		Me.ConnectionString = builder.ConnectionString
	End Sub
End Class
