'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core

Namespace ConnectionFrames
	Public NotInheritable Partial Class ODBCConnectionFrame
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
				Dim builder As New OdbcConnectionStringBuilder()
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
					Dim builder As New OdbcConnectionStringBuilder()
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
				Dim connection As New OdbcConnection(ConnectionString)
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

		Private Sub btnTest_Click(sender As Object, e As EventArgs)
			Dim metadataProvider as New ODBCMetadataProvider()
		    metadataProvider.Connection = New OdbcConnection(ConnectionString)

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
