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
	Public Partial Class SaveForm
		Inherits Form
		Public Property IsSave() As Boolean
			Get
				Return m_IsSave
			End Get
			Set
				m_IsSave = Value
			End Set
		End Property
		Private m_IsSave As Boolean

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(sender As Object, e As System.EventArgs)
			IsSave = True
		End Sub

		Private Sub button2_Click(sender As Object, e As System.EventArgs)
			IsSave = False
		End Sub
	End Class
End Namespace
