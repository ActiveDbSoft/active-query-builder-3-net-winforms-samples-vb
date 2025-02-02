''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''


Partial Public Class CodeBehindForm
    Inherits Form
    Public Property TextContent() As String
        Set(ByVal value As String)
            TextBoxCode.Text = value
        End Set
        Get
            Return TextBoxCode.Text
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ButtonClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub
End Class
