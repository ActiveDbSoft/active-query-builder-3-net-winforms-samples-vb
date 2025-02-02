''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Namespace ConnectionFrames
    Partial Public Class ConnectionStringEditForm
        Inherits Form
        Public Property ConnectionString() As String
            Get
                Return tbConnectionString.Text
            End Get
            Set(value As String)
                tbConnectionString.Text = value
                tbConnectionString.Modified = False
            End Set
        End Property

        Public ReadOnly Property Modified() As Boolean
            Get
                Return tbConnectionString.Modified
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
End Namespace
