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

Public Partial Class CodeBehindForm
	Inherits Form
	Public Property TextContent() As String
		Get
			Return TextBoxCode.Text
		End Get
		Set
			TextBoxCode.Text = value
		End Set
	End Property

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub ButtonClose_Click(sender As Object, e As EventArgs)
		Close()
	End Sub
End Class
