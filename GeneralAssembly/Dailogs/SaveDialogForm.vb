'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Namespace Dailogs
	Partial Public Class SaveDialogForm
		Inherits Form
		Public Property Save() As Boolean

		Public Sub New(nameQuery As String)
			InitializeComponent()

			label1.Text = String.Format("Save changes to the [{0}]?", nameQuery)
		End Sub

		Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
			Save = True
		End Sub

		Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
			Save = False
		End Sub
	End Class
End Namespace
