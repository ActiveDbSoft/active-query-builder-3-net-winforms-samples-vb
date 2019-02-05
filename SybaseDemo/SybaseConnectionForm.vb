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
Imports iAnywhere.Data.SQLAnywhere

Public Partial Class SybaseConnectionForm
	Inherits Form
	Public ConnectionString As String = ""


	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub buttonBrowse_Click(sender As Object, e As EventArgs)
		If openFileDialog1.ShowDialog() = DialogResult.OK Then
			textboxDatabaseFile.Text = openFileDialog1.FileName
		End If
	End Sub

	Private Sub buttonConnect_Click(sender As Object, e As EventArgs)
		Dim builder As New SAConnectionStringBuilder()

		builder.ServerName = textboxServerName.Text
		builder.DataSourceName = textboxDataSourceName.Text
		builder.DatabaseFile = textboxDatabaseFile.Text
		builder.UserID = textboxUser.Text
		builder.Password = textboxPassword.Text

		Me.ConnectionString = builder.ConnectionString
	End Sub
End Class
