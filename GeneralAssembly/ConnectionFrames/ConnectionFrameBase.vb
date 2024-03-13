''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2024 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Namespace ConnectionFrames
    Public Class ConnectionFrameBase
        Inherits UserControl
        Public Overridable Property ConnectionString() As String
            Get
                Return Nothing
            End Get
            Set(value As String)
            End Set
        End Property

        Public Overridable Function TestConnection() As Boolean
            Return False
        End Function
    End Class
End Namespace
