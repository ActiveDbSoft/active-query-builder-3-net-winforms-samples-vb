'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Data.OleDb
Imports System.Windows.Forms


Namespace ConnectionFrames
	Public NotInheritable Partial Class MSAccessConnectionFrame
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

			If [String].IsNullOrEmpty(connectionString__1) Then
				tbUserID.Text = "Admin"
			Else
				ConnectionString = connectionString__1
			End If
		End Sub

		Public Function GetConnectionString() As String
			Try
				Dim builder As New OleDbConnectionStringBuilder()
				builder.ConnectionString = _connectionString

				builder.Provider = "Microsoft.ACE.OLEDB.12.0"
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
