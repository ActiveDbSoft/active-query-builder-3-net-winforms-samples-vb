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

Namespace ConnectionFrames
	Public Partial Class XmlFileFrame
		Inherits ConnectionFrameBase
		Public Overrides Property ConnectionString() As String
			Get
				Return tbXmlFile.Text
			End Get
			Set
				tbXmlFile.Text = value
			End Set
		End Property

		Public Sub New(xmlFilePath As String)
			InitializeComponent()

			tbXmlFile.Text = xmlFilePath
		End Sub

		Public Overrides Function TestConnection() As Boolean
			If [String].IsNullOrEmpty(ConnectionString) Then
				MessageBox.Show("Invalid Xml file path.", Program.Name)

				Return False
			Else
				Return True
			End If
		End Function

		Private Sub btnLoadMetadata_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub btnBrowse_Click(sender As Object, e As EventArgs)
			openFileDialog1.FileName = ConnectionString

			If openFileDialog1.ShowDialog() = DialogResult.OK Then
				ConnectionString = openFileDialog1.FileName
			End If
		End Sub
	End Class
End Namespace
