''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2021 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.ComponentModel
Imports System.Text
Imports Npgsql


Partial Public Class PostgreSQLConnectionForm
    Inherits Form
    Public ConnectionString As String = ""


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub buttonConnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonConnect.Click
        Dim connectionString As String = "Server=" & tbServer.Text & ";Port=" & tbPort.Text & ";Database=" & tbDatabase.Text & ";Userid=" & tbLogin.Text & ";Password=" & tbPassword.Text

        Me.ConnectionString = connectionString
    End Sub
End Class
