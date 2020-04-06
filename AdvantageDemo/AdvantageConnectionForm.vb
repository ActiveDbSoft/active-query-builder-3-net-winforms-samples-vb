'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports Advantage.Data.Provider

Namespace AdvantageDemo
	Partial Public Class AdvantageConnectionForm
		Inherits Form
		Public Property ConnectionString() As String

		Public Sub New()
			InitializeComponent()

			cbServerType.SelectedItem = "local"
		End Sub

		Private Sub buttonBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonBrowse.Click
			If openFileDialog1.ShowDialog() = DialogResult.OK Then
				textboxDataSource.Text = openFileDialog1.FileName
			End If
		End Sub

		Private Sub buttonConnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonConnect.Click
			Dim builder As New AdsConnectionStringBuilder()

			builder.DataSource = textboxDataSource.Text
			builder.ServerType = cbServerType.SelectedItem.ToString()

			If textboxUser.Text.Length > 0 Then
				builder.UserID = textboxUser.Text
			End If

			If textboxPassword.Text.Length > 0 Then
				builder.Password = textboxPassword.Text
			End If

			ConnectionString = builder.ConnectionString
		End Sub
	End Class
End Namespace
