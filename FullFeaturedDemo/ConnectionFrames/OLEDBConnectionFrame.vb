﻿'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Data.OleDb
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core

Namespace ConnectionFrames
	Public NotInheritable Partial Class OLEDBConnectionFrame
		Inherits ConnectionFrameBase
		Private _connectionString As String

		Public Overrides Property ConnectionString() As String
			Get
				Return GetConnectionString()
			End Get
			Set
				SetConnectionString(value)
			End Set
		End Property

		Public Sub New(connectionString__1 As String)
			InitializeComponent()

			ConnectionString = connectionString__1
		End Sub

		Public Function GetConnectionString() As String
			Try
				Dim builder As New OleDbConnectionStringBuilder()
				builder.ConnectionString = tbConnectionString.Text
				_connectionString = builder.ConnectionString
			Catch
			End Try

			Return _connectionString
		End Function

		Public Sub SetConnectionString(value As String)
			_connectionString = value

			If Not [String].IsNullOrEmpty(_connectionString) Then
				Try
					Dim builder As New OleDbConnectionStringBuilder()
					builder.ConnectionString = _connectionString
					_connectionString = builder.ConnectionString
					tbConnectionString.Text = _connectionString
				Catch
				End Try
			End If
		End Sub

		Public Overrides Function TestConnection() As Boolean
			Cursor.Current = Cursors.WaitCursor

			Try
				Dim connection As New OleDbConnection(ConnectionString)
				connection.Open()
				connection.Close()
			Catch e As System.Exception
				MessageBox.Show(e.Message, Program.Name)
				Return False
			Finally
				Cursor.Current = Cursors.[Default]
			End Try

			Return True
		End Function

		Private Sub btnBuild_Click(sender As Object, e As EventArgs)
			' Using COM interop with the OLE DB Service Component to display the Data Link Properties dialog box.
			'
			' Add reference to the Primary Interop Assembly (PIA) for ADO provided in the file ADODB.DLL:
			' select adodb from the .NET tab in Visual Studio .NET's Add Reference Dialog. 
			' You'll also need a reference to the Microsoft OLE DB Service Component 1.0 Type Library 
			' from the COM tab in Visual Studio .NET's Add Reference Dialog.

			Try
				Dim dlg As New MSDASC.DataLinks()
				Dim adodbConnection As New ADODB.Connection()
				adodbConnection.ConnectionString = _connectionString
				Dim connection As Object = adodbConnection

				If dlg.PromptEdit(connection) Then
					_connectionString = adodbConnection.ConnectionString
					tbConnectionString.Text = _connectionString
				End If
			Catch exception As Exception
				MessageBox.Show("Failed to show OLEDB Data Link Properties dialog box." & vbLf & "Perhaps you have no required components installed or they are outdated." & vbLf & "Try to rebuild this demo from the source code." & vbLf & vbLf & exception.Message)
			End Try
		End Sub

		Private Sub btnTest_Click(sender As Object, e As EventArgs)
			Dim metadataProvider as New OLEDBMetadataProvider()
		    metadataProvider.Connection = New OleDbConnection(ConnectionString)
			Dim syntaxProviderType As Type = Nothing

			Try
				syntaxProviderType = Helpers.AutodetectSyntaxProvider(metadataProvider)
			Catch exception As Exception
				MessageBox.Show(exception.Message, Program.Name)
			End Try

			DoSyntaxDetected(syntaxProviderType)
		End Sub

		Private Sub tbConnectionString_TextChanged(sender As Object, e As EventArgs)
			btnTest.Enabled = tbConnectionString.Text <> String.Empty
		End Sub
	End Class
End Namespace