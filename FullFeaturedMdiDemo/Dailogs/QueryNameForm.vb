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

Namespace Dailogs
	Public Partial Class QueryNameForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Property QueryName() As String
			Get
				Return textBox1.Text
			End Get
			Set
				textBox1.Text = value
			End Set
		End Property

		Private Sub QueryNameForm_Shown(sender As Object, e As System.EventArgs)
			textBox1.SelectAll()
		End Sub
	End Class
End Namespace
