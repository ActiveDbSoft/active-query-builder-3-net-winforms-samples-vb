'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.ComponentModel
Imports System.Text
Imports VistaDB.Diagnostic
Imports VistaDB.Provider


Partial Public Class VistaDB5ConnectionForm
    Inherits Form
    Public ConnectionString As String = ""


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub buttonBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonBrowse.Click
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            textboxDatabase.Text = openFileDialog1.FileName
        End If
    End Sub

    Private Sub buttonConnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonConnect.Click

        Dim builder As New VistaDBConnectionStringBuilder()

        builder.DataSource = textboxDatabase.Text
        builder.OpenMode = VistaDB.VistaDBDatabaseOpenMode.NonexclusiveReadOnly

        If textboxPassword.Text.Length > 0 Then
            builder.Password = textboxPassword.Text
        End If

        Me.ConnectionString = builder.ConnectionString
    End Sub
End Class
