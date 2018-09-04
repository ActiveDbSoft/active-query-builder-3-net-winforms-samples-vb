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

Namespace Dailogs
	Public Partial Class SaveAsForm
		Inherits Form
		Public Property SaveAsFile() As Boolean
			Get
				Return m_SaveAsFile
			End Get
			Set
				m_SaveAsFile = Value
			End Set
		End Property
		Private m_SaveAsFile As Boolean

		Public Sub New(nameQuery As String)
			InitializeComponent()

			label1.Text = String.Format("Save changes to the [{0}]?", nameQuery)
		End Sub

		Private Sub button1_Click(sender As Object, e As System.EventArgs)
			SaveAsFile = True
		End Sub

		Private Sub button2_Click(sender As Object, e As System.EventArgs)
			SaveAsFile = False
		End Sub
	End Class
End Namespace
