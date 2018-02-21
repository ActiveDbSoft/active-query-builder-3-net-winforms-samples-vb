'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Windows.Forms

Imports Advantage.Data.Provider

Public Partial Class AdvantageConnectionForm
	Inherits Form
	Public Property ConnectionString() As String
		Get
			Return m_ConnectionString
		End Get
		Set
			m_ConnectionString = Value
		End Set
	End Property
	Private m_ConnectionString As String

	Public Sub New()
		InitializeComponent()

		cbServerType.SelectedItem = "local"
	End Sub

	Private Sub buttonBrowse_Click(sender As Object, e As EventArgs)
		If openFileDialog1.ShowDialog() = DialogResult.OK Then
			textboxDataSource.Text = openFileDialog1.FileName
		End If
	End Sub

	Private Sub buttonConnect_Click(sender As Object, e As EventArgs)
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
