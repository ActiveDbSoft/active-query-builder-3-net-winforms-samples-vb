﻿'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Threading
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms


Friend NotInheritable Class Program
		Public Shared Name As String = "Active Query Builder Demo"
		Public Shared Settings As New My.Settings()

		Public Shared Connections As New ConnectionList()
		Public Shared XmlFiles As New ConnectionList()

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
        <STAThread>
        Friend Shared Sub Main()
			AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException
			AddHandler Application.ThreadException, AddressOf Thread_UnhandledException

			Dim i = ControlFactory.Instance ' force call static constructor of control factory

			'if new version, import upgrade from previous version
			If Settings.CallUpgrade Then
				Settings.Upgrade()
				Settings.CallUpgrade = False
			End If

			If Program.Settings.Connections IsNot Nothing Then
				Connections = Settings.Connections
				Connections.RemoveObsoleteConnectionInfos()
				Connections.RestoreData()
			End If

			If Program.Settings.XmlFiles IsNot Nothing Then
				XmlFiles = Settings.XmlFiles
				XmlFiles.RemoveObsoleteConnectionInfos()
			End If

			Helpers.Localizer.Language = Settings.Language

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New MainForm())

			Connections.SaveData()

			Program.Settings.Connections = Connections
			Program.Settings.XmlFiles = XmlFiles
			Program.Settings.Save()
		End Sub

		Private Shared Sub CurrentDomain_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
			Dim exception As Exception = TryCast(e.ExceptionObject, Exception)
			If exception IsNot Nothing Then
				Dim exceptionDialog As New ThreadExceptionDialog(exception)
				If exceptionDialog.ShowDialog() = DialogResult.Abort Then
					Application.Exit()
				End If
			End If
		End Sub

		Private Shared Sub Thread_UnhandledException(sender As Object, e As ThreadExceptionEventArgs)
			Dim exception As Exception = e.Exception
			If exception Is Nothing Then
				Return
			End If

			Dim exceptionDialog = New ThreadExceptionDialog(exception)
			If exceptionDialog.ShowDialog() = DialogResult.Abort Then
				Application.Exit()
			End If
		End Sub
	End Class
