''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Threading


Friend NotInheritable Class Program
    Public Shared Connections As New ConnectionList()
    Public Shared XmlFiles As New ConnectionList()
    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    Private Sub New()
    End Sub
    <STAThread>
    Friend Shared Sub Main()
        ' Catch ungandled exceptions for debugging purposes
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException
        AddHandler Application.ThreadException, AddressOf Thread_UnhandledException

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub

    Private Shared Sub CurrentDomain_UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
        Dim exception As Exception = TryCast(e.ExceptionObject, Exception)
        If exception IsNot Nothing Then
            Dim exceptionDialog As New ThreadExceptionDialog(exception)
            If exceptionDialog.ShowDialog() = DialogResult.Abort Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Shared Sub Thread_UnhandledException(ByVal sender As Object, ByVal e As ThreadExceptionEventArgs)
        If e.Exception IsNot Nothing Then
            Dim exceptionDialog As New ThreadExceptionDialog(e.Exception)

            If exceptionDialog.ShowDialog() = DialogResult.Abort Then
                Application.Exit()
            End If
        End If
    End Sub
End Class
