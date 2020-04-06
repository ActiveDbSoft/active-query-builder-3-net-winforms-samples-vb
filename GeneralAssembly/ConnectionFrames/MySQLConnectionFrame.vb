'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports MySql.Data.MySqlClient

Namespace ConnectionFrames
	Public NotInheritable Partial Class MySQLConnectionFrame
		Inherits ConnectionFrameBase
		Private _connectionString As String

		Public Overrides Property ConnectionString() As String
			Get
				Return GetConnectionString()
			End Get
			Set(value As String)
				SetConnectionString(value)
			End Set
		End Property

		Public Sub New(connectionString As String)
			InitializeComponent()

			If Not String.IsNullOrEmpty(connectionString) Then
				Me.ConnectionString = connectionString
			End If
		End Sub

		Public Function GetConnectionString() As String
			Try
				Dim builder As New MySqlConnectionStringBuilder()
				builder.ConnectionString = _connectionString

				builder.Server = tbServer.Text
				builder.Database = tbDatabase.Text
				builder.UserID = tbUserID.Text
				builder.Password = tbPassword.Text

				_connectionString = builder.ConnectionString
			Catch
			End Try

			Return _connectionString
		End Function

		Public Sub SetConnectionString(value As String)
			_connectionString = value

			If Not String.IsNullOrEmpty(_connectionString) Then
				Try
					Dim builder As New MySqlConnectionStringBuilder()
					builder.ConnectionString = _connectionString

					tbServer.Text = builder.Server
					tbDatabase.Text = builder.Database
					tbUserID.Text = builder.UserID
					tbPassword.Text = builder.Password

					_connectionString = builder.ConnectionString
				Catch
				End Try
			End If
		End Sub

		Private Sub btnEditConnectionString_Click(sender As Object, e As EventArgs) Handles btnEditConnectionString.Click
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
				Dim connection As New MySqlConnection(ConnectionString)
				connection.Open()
				connection.Close()
			Catch e As Exception
				MessageBox.Show(e.Message, "Demo project")
				Return False
			Finally
				Cursor.Current = Cursors.Default
			End Try

			Return True
		End Function
	End Class
End Namespace
