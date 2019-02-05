'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports Oracle.ManagedDataAccess.Client
Imports System.Windows.Forms


Namespace ConnectionFrames
	Public NotInheritable Partial Class OracleConnectionFrame
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
				cmbIntegratedSecurity.SelectedIndex = 0
				tbUserID.Enabled = False
				tbPassword.Enabled = False
			Else
				ConnectionString = connectionString__1
			End If

			AddHandler cmbIntegratedSecurity.SelectedIndexChanged, AddressOf cmbIntegratedSecurity_SelectedIndexChanged
		End Sub

		Public Function GetConnectionString() As String
			Try
				Dim builder As New OracleConnectionStringBuilder()
				builder.ConnectionString = _connectionString

				builder.DataSource = tbDataSource.Text
				builder.UserID = If((cmbIntegratedSecurity.SelectedIndex = 0), "/", tbUserID.Text)
				builder.Password = tbPassword.Text

				_connectionString = builder.ConnectionString
			Catch
			End Try

			Return _connectionString
		End Function

		Public Sub SetConnectionString(value As String)
			_connectionString = value

			If Not [String].IsNullOrEmpty(_connectionString) Then
				Try
				    Dim builder As OracleConnectionStringBuilder = New OracleConnectionStringBuilder()
				    builder.ConnectionString = _connectionString
				    tbDataSource.Text = builder.DataSource
				    cmbIntegratedSecurity.SelectedIndex = If((builder.UserID Is "/"), 0, 1)
				    tbUserID.Text = builder.UserID
				    tbUserID.Enabled = (builder.UserID IsNot "/")
				    tbPassword.Text = builder.Password
				    tbPassword.Enabled = (builder.UserID IsNot "/")
				    _connectionString = builder.ConnectionString				    					
				Catch
				End Try
			End If
		End Sub

		Private Sub cmbIntegratedSecurity_SelectedIndexChanged(sender As Object, e As EventArgs)
			tbUserID.Enabled = (cmbIntegratedSecurity.SelectedIndex = 1)
			tbPassword.Enabled = (cmbIntegratedSecurity.SelectedIndex = 1)
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
				Dim connection As New OracleConnection(ConnectionString)
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
