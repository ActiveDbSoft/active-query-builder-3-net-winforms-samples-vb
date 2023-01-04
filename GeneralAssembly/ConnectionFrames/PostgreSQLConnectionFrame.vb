''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2023 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports Npgsql

Namespace ConnectionFrames
    Public NotInheritable Partial Class PostgreSQLConnectionFrame
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
                tbHost.Text = "localhost"
                tbPort.Text = "5432"
                tbUserName.Text = "postgres"
            Else
                Me.ConnectionString = connectionString
            End If
        End Sub

        Public Function GetConnectionString() As String
            Try
                Dim builder As New NpgsqlConnectionStringBuilder()
                builder.ConnectionString = _connectionString

                builder.Host = tbHost.Text
                builder.Port = Convert.ToInt32(tbPort.Text)
                builder.Database = tbDatabase.Text
                builder.Username = tbUserName.Text
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
                    Dim builder As New NpgsqlConnectionStringBuilder()
                    builder.ConnectionString = _connectionString

                    tbHost.Text = builder.Host
                    tbPort.Text = builder.Port.ToString()
                    tbDatabase.Text = builder.Database
                    tbUserName.Text = builder.Username
                    'tbPassword.Text = builder.Password;

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
                Dim connection As New NpgsqlConnection(ConnectionString)
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
