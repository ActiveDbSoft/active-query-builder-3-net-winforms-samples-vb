''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2021 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Data.SqlClient

Namespace ConnectionFrames
	Public NotInheritable Partial Class MSSQLConnectionFrame
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

			If String.IsNullOrEmpty(connectionString) Then
				tbDataSource.Text = "(local)"
				cmbIntegratedSecurity.SelectedIndex = 0
				tbUserID.Enabled = False
				tbPassword.Enabled = False
				cmbInitialCatalog.SelectedIndex = 0
			Else
				Me.ConnectionString = connectionString
			End If

			AddHandler cmbIntegratedSecurity.SelectedIndexChanged, AddressOf cmbIntegratedSecurity_SelectedIndexChanged
		End Sub

		Public Function GetConnectionString() As String
			Try
				Dim builder As New SqlConnectionStringBuilder()
				builder.ConnectionString = _connectionString

				builder.DataSource = tbDataSource.Text
				builder.IntegratedSecurity = If(cmbIntegratedSecurity.SelectedIndex = 0, True, False)
				builder.UserID = tbUserID.Text
				builder.Password = tbPassword.Text
				builder.InitialCatalog = If(cmbInitialCatalog.Text = "<default>", "", cmbInitialCatalog.Text)

				_connectionString = builder.ConnectionString
			Catch
			End Try

			Return _connectionString
		End Function

		Public Sub SetConnectionString(value As String)
			_connectionString = value

			If Not String.IsNullOrEmpty(_connectionString) Then
				Try
					Dim builder As New SqlConnectionStringBuilder()
					builder.ConnectionString = _connectionString

					tbDataSource.Text = builder.DataSource
					cmbIntegratedSecurity.SelectedIndex = If(builder.IntegratedSecurity, 0, 1)
					tbUserID.Text = builder.UserID
					tbUserID.Enabled = Not builder.IntegratedSecurity
					tbPassword.Text = builder.Password
					tbPassword.Enabled = Not builder.IntegratedSecurity
					cmbInitialCatalog.Text = builder.InitialCatalog

					_connectionString = builder.ConnectionString
				Catch
				End Try
			End If
		End Sub

		Private Sub cmbIntegratedSecurity_SelectedIndexChanged(sender As Object, e As EventArgs)
			tbUserID.Enabled = (cmbIntegratedSecurity.SelectedIndex = 1)
			tbPassword.Enabled = (cmbIntegratedSecurity.SelectedIndex = 1)
		End Sub

		Private Sub cmbInitialCatalog_DropDown(sender As Object, e As EventArgs) Handles cmbInitialCatalog.DropDown
			Using connection As New SqlConnection(Me.ConnectionString)
				Cursor.Current = Cursors.WaitCursor

				Dim currentDatabase As String = cmbInitialCatalog.Text

				cmbInitialCatalog.Items.Clear()
				cmbInitialCatalog.Items.Add("<default>")
				cmbInitialCatalog.SelectedIndex = 0

				Try
					connection.Open()

					Dim schemaTable As DataTable = connection.GetSchema("Databases")

					For Each r As DataRow In schemaTable.Rows
						cmbInitialCatalog.Items.Add(r(0))
					Next r

					cmbInitialCatalog.SelectedItem = Nothing
					cmbInitialCatalog.SelectedItem = currentDatabase

					If cmbInitialCatalog.SelectedItem Is Nothing Then
						cmbInitialCatalog.Text = currentDatabase
					End If
				Catch ex As Exception
					MessageBox.Show(ex.Message, "Connection Failure.")
				Finally
					Cursor.Current = Cursors.Default
				End Try
			End Using
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
				Dim connection As New SqlConnection(ConnectionString)
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
