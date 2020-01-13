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

Public Class ConnectionFrameBase
	Inherits UserControl
	Public Delegate Sub SyntaxProviderDetected(syntaxType As Type)

	Public Event OnSyntaxProviderDetected As SyntaxProviderDetected

	Public Overridable Sub SetServerType(serverType As String)

	End Sub

	Public Sub DoSyntaxDetected(syntaxType As Type)
		RaiseEvent OnSyntaxProviderDetected(syntaxType)
	End Sub

	Public Overridable Property ConnectionString() As String
		Get
			Return Nothing
		End Get
		Set
		End Set
	End Property

	Public Overridable Function TestConnection() As Boolean
		Return False
	End Function
End Class
