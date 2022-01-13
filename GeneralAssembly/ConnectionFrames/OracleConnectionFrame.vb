''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2022 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports Oracle.ManagedDataAccess.Client

Namespace ConnectionFrames
    Public NotInheritable Partial Class OracleConnectionFrame
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
                cmbIntegratedSecurity.SelectedIndex = 0
                tbUserID.Enabled = False
                tbPassword.Enabled = False
            Else
                Me.ConnectionString = connectionString
            End If

            AddHandler cmbIntegratedSecurity.SelectedIndexChanged, AddressOf cmbIntegratedSecurity_SelectedIndexChanged
        End Sub

        Public Function GetConnectionString() As String
            Try
                Dim builder As New OracleConnectionStringBuilder()
                builder.ConnectionString = _connectionString

                builder.DataSource = tbDataSource.Text
                builder.UserID = If(cmbIntegratedSecurity.SelectedIndex = 0, "/", tbUserID.Text)

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
                    Dim builder As New OracleConnectionStringBuilder()
                    builder.ConnectionString = _connectionString

                    tbDataSource.Text = builder.DataSource
                    cmbIntegratedSecurity.SelectedIndex = If(builder.UserID = "/", 0, 1)
                    tbUserID.Text = builder.UserID
                    tbUserID.Enabled = (builder.UserID <> "/")
                    tbPassword.Text = builder.Password
                    tbPassword.Enabled = (builder.UserID <> "/")

                    _connectionString = builder.ConnectionString
                Catch
                End Try
            End If
        End Sub

        Private Sub cmbIntegratedSecurity_SelectedIndexChanged(sender As Object, e As EventArgs)
            tbUserID.Enabled = (cmbIntegratedSecurity.SelectedIndex = 1)
            tbPassword.Enabled = (cmbIntegratedSecurity.SelectedIndex = 1)
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
                Dim connection As New OracleConnection(ConnectionString)
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
