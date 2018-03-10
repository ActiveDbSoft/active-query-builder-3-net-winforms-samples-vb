'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Collections.Generic
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms


Namespace ConnectionFrames
	Public NotInheritable Partial Class MSAccessConnectionFrame
		Inherits ConnectionFrameBase
		Private _connectionString As String
		Private _serverType As String

		Private _knownAceProviders As New List(Of String)() From { _
			"Microsoft.ACE.OLEDB.16.0", _
			"Microsoft.ACE.OLEDB.15.0", _
			"Microsoft.ACE.OLEDB.14.0", _
			"Microsoft.ACE.OLEDB.12.0" _
		}

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

			If [String].IsNullOrEmpty(connectionString__1) Then
				tbUserID.Text = "Admin"
			Else
				ConnectionString = connectionString__1
			End If
		End Sub

		Public Overrides Sub SetServerType(serverType As String)
			_serverType = serverType
		End Sub

		Private Shared Function GetProvidersList() As List(Of String)
			Dim reader = OleDbEnumerator.GetRootEnumerator()
			Dim result = New List(Of String)()
			While reader.Read()
				For i As Integer = 0 To reader.FieldCount - 1
					If reader.GetName(i) = "SOURCES_NAME" Then
						result.Add(reader.GetValue(i).ToString())
					End If
				Next
			End While
			reader.Close()

			Return result
		End Function

		Private Function DetectProvider() As String
		    Dim providersList = GetProvidersList()
		    Dim provider = String.Empty

		    Dim ext = Path.GetExtension(tbDataSource.Text)
		    If ext = ".accdb" Then
		        For i As Integer = 0 To _knownAceProviders.Count - 1
		            If providersList.Contains(_knownAceProviders(i)) Then
		                provider = _knownAceProviders(i)
		                Exit For
		            End If
		        Next

		        If provider = String.Empty Then
		            provider = "Microsoft.ACE.OLEDB.12.0"
		        End If
		    ElseIf _serverType = "Access 97" Then
		        provider = "Microsoft.Jet.OLEDB.3.0"
		    ElseIf _serverType = "Access 2000 and newer" Then
		        For i As Integer = 0 To _knownAceProviders.Count - 1
		            If providersList.Contains(_knownAceProviders(i)) Then
		                provider = _knownAceProviders(i)
		                Exit For
		            End If
		        Next

		        If provider = String.Empty Then
		            provider = "Microsoft.Jet.OLEDB.4.0"
		        End If
		    End If

		    Return provider
		End Function

		Public Function GetConnectionString() As String
			Try
			    Dim builder As New OleDbConnectionStringBuilder()
			    builder.ConnectionString = _connectionString
			    builder.Provider = DetectProvider()
			    builder.DataSource = tbDataSource.Text
			    builder("User ID") = tbUserID.Text
			    builder("Password") = tbPassword.Text				

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

					tbDataSource.Text = builder.DataSource
					tbUserID.Text = builder("User ID").ToString()
					tbPassword.Text = builder("Password").ToString()

					_connectionString = builder.ConnectionString
				Catch
				End Try
			End If
		End Sub

		Private Sub btnBrowse_Click(sender As Object, e As EventArgs)
			If openFileDialog1.ShowDialog() = DialogResult.OK Then
				tbDataSource.Text = openFileDialog1.FileName
			End If
		End Sub

		Private Sub btnEditConnectionString_Click(sender As Object, e As EventArgs)
			Using csef As New ConnectionStringEditForm()
				csef.ConnectionString = Me.ConnectionString

				If csef.ShowDialog() = DialogResult.OK Then
					If csef.Modified Then
						Me.ConnectionString = csef.ConnectionString
					End If
				End If
			End Using
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
	End Class
End Namespace
