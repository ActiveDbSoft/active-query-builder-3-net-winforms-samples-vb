''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2021 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Namespace Dailogs
	Partial Public Class SaveForm
		Inherits Form
		Public Property IsSave() As Boolean

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
			IsSave = True
		End Sub

		Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
			IsSave = False
		End Sub
	End Class
End Namespace
