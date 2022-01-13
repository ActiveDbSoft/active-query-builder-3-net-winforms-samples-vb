''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2022 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Partial Public Class DB2ConnectionForm
    Inherits Form
    Public ConnectionString As String = ""


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub buttonConnect_Click(sender As Object, e As EventArgs) Handles buttonConnect.Click
        Dim builder As New DB2ConnectionStringBuilder()

        builder.Server = textboxServer.Text
        builder.Database = textboxDatabase.Text
        builder.UserID = textboxUser.Text

        If textboxPassword.Text.Length > 0 Then
            builder.Password = textboxPassword.Text
        End If

        Me.ConnectionString = builder.ConnectionString
    End Sub
End Class
