''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2024 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Data.Odbc

Namespace ConnectionFrames
    Public NotInheritable Partial Class ODBCConnectionFrame
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

            Me.ConnectionString = connectionString
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

            If Not String.IsNullOrEmpty(_connectionString) Then
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
