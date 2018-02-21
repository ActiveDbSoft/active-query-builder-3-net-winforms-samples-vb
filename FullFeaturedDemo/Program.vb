'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Threading
Imports System.Windows.Forms
Imports FullFeaturedDemo.Properties

Friend NotInheritable Class Program
	Private Sub New()
	End Sub
	Public Shared Name As String = "Active Query Builder Demo"
	Public Shared Settings As New Settings()

	Public Shared Connections As New ConnectionList()
	Public Shared XmlFiles As New ConnectionList()

	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	<STAThread> _
	Friend Shared Sub Main()
		AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException
		AddHandler Application.ThreadException, AddressOf Thread_UnhandledException

		'if new version, import upgrade from previous version
		If Settings.CallUpgrade Then
			Settings.Upgrade()
			Settings.CallUpgrade = False
		End If

		If Program.Settings.Connections IsNot Nothing Then
			Connections = Program.Settings.Connections
		End If

		If Program.Settings.XmlFiles IsNot Nothing Then
			XmlFiles = Program.Settings.XmlFiles
		End If

		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Application.Run(New MainForm())

		Program.Settings.Connections = Connections
		Program.Settings.XmlFiles = XmlFiles
		Program.Settings.Save()
	End Sub

	Private Shared Sub CurrentDomain_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
		Dim exception As Exception = TryCast(e.ExceptionObject, Exception)
		If exception IsNot Nothing Then
			Dim exceptionDialog As New ThreadExceptionDialog(exception)
			If exceptionDialog.ShowDialog() = DialogResult.Abort Then
				Application.[Exit]()
			End If
		End If
	End Sub

	Private Shared Sub Thread_UnhandledException(sender As Object, e As ThreadExceptionEventArgs)
		Dim exception As Exception = e.Exception
		If exception IsNot Nothing Then
			Dim exceptionDialog As New ThreadExceptionDialog(exception)
			If exceptionDialog.ShowDialog() = DialogResult.Abort Then
				Application.[Exit]()
			End If
		End If
	End Sub
End Class
