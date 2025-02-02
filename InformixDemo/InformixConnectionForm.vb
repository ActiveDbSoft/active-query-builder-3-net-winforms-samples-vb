''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.ComponentModel
Imports System.Text
Imports IBM.Data.Informix


Partial Public Class InformixConnectionForm
    Inherits Form
    Public ConnectionString As String = ""


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub buttonConnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonConnect.Click
        Dim connectionString As String = String.Format("Server={0};Host={1};Protocol={2};Service={3};Database={4};Database Locale={5};User ID={6};Password={7};", tbServer.Text, tbHost.Text, tbProtocol.Text, tbService.Text, tbDatabase.Text, tbDatabaseLocale.Text, tbUser.Text, tbPassword.Text)

        Me.ConnectionString = connectionString
    End Sub
End Class
