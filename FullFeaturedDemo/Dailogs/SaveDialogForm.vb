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
	Public Partial Class SaveDialogForm
		Inherits Form
		Public Property Save() As Boolean
			Get
				Return m_Save
			End Get
			Set
				m_Save = Value
			End Set
		End Property
		Private m_Save As Boolean

		Public Sub New(nameQuery As String)
			InitializeComponent()

			label1.Text = String.Format("Save changes to the [{0}]?", nameQuery)
		End Sub

		Private Sub button1_Click(sender As Object, e As System.EventArgs)
			Save = True
		End Sub

		Private Sub button2_Click(sender As Object, e As System.EventArgs)
			Save = False
		End Sub
	End Class
End Namespace
