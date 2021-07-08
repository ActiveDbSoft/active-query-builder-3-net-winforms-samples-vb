''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2021 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Namespace ConnectionFrames
	Partial Public Class ConnectionEditForm
		Inherits Form
		Private ReadOnly _connectionInfo As ConnectionInfo
		Private _currentConnectionFrame As ConnectionFrameBase
        Private _isLockUpdate As Boolean

        Public Sub New(connectionInfo As ConnectionInfo)
			InitializeComponent()

			Debug.Assert(connectionInfo IsNot Nothing)

			_connectionInfo = connectionInfo
			tbConnectionName.Text = connectionInfo.Name

			If Not String.IsNullOrEmpty(connectionInfo.ConnectionString) Then
				Text = "Edit Connection"

				If Not connectionInfo.IsXmlFile Then
					rbMSSQL.Enabled = (connectionInfo.Type = ConnectionTypes.MSSQL)
					rbMSAccess.Enabled = (connectionInfo.Type = ConnectionTypes.MSAccess)
					rbOracle.Enabled = (connectionInfo.Type = ConnectionTypes.Oracle)
					rbMySQL.Enabled = (connectionInfo.Type = ConnectionTypes.MySQL)
					rbPostrgeSQL.Enabled = (connectionInfo.Type = ConnectionTypes.PostgreSQL)
					rbOLEDB.Enabled = (connectionInfo.Type = ConnectionTypes.OLEDB)
					rbODBC.Enabled = (connectionInfo.Type = ConnectionTypes.ODBC)
				End If
			End If

			If connectionInfo.IsXmlFile Then
				rbOLEDB.Enabled = False
				rbODBC.Enabled = False
			End If

			rbMSSQL.Checked = (connectionInfo.Type = ConnectionTypes.MSSQL)
			rbMSAccess.Checked = (connectionInfo.Type = ConnectionTypes.MSAccess)
			rbOracle.Checked = (connectionInfo.Type = ConnectionTypes.Oracle)
			rbMySQL.Checked = (connectionInfo.Type = ConnectionTypes.MySQL)
			rbPostrgeSQL.Checked = (connectionInfo.Type = ConnectionTypes.PostgreSQL)
			rbOLEDB.Checked = (connectionInfo.Type = ConnectionTypes.OLEDB)
			rbODBC.Checked = (connectionInfo.Type = ConnectionTypes.ODBC)

			SetActiveConnectionTypeFrame()

			AddHandler rbMSSQL.CheckedChanged, AddressOf ConnectionTypeChanged
			AddHandler rbMSAccess.CheckedChanged, AddressOf ConnectionTypeChanged
			AddHandler rbOracle.CheckedChanged, AddressOf ConnectionTypeChanged
			AddHandler rbMySQL.CheckedChanged, AddressOf ConnectionTypeChanged
			AddHandler rbPostrgeSQL.CheckedChanged, AddressOf ConnectionTypeChanged
			AddHandler rbOLEDB.CheckedChanged, AddressOf ConnectionTypeChanged
			AddHandler rbODBC.CheckedChanged, AddressOf ConnectionTypeChanged
			FillSyntax()
			AddHandler Application.Idle, AddressOf Application_Idle
		End Sub

		Private Sub SetActiveConnectionTypeFrame()
			If _currentConnectionFrame IsNot Nothing Then
				_currentConnectionFrame.Dispose()
				_currentConnectionFrame = Nothing
			End If

			If Not _connectionInfo.IsXmlFile Then
				Select Case _connectionInfo.Type
					Case ConnectionTypes.MSSQL
						_currentConnectionFrame = New MSSQLConnectionFrame(_connectionInfo.ConnectionString)
					Case ConnectionTypes.MSAccess
						_currentConnectionFrame = New MSAccessConnectionFrame(_connectionInfo.ConnectionString)
					Case ConnectionTypes.Oracle
						_currentConnectionFrame = New OracleConnectionFrame(_connectionInfo.ConnectionString)
					Case ConnectionTypes.MySQL
						_currentConnectionFrame = New MySQLConnectionFrame(_connectionInfo.ConnectionString)
					Case ConnectionTypes.PostgreSQL
						_currentConnectionFrame = New PostgreSQLConnectionFrame(_connectionInfo.ConnectionString)
					Case ConnectionTypes.OLEDB
						_currentConnectionFrame = New OLEDBConnectionFrame(_connectionInfo.ConnectionString)
					Case ConnectionTypes.ODBC
						_currentConnectionFrame = New ODBCConnectionFrame(_connectionInfo.ConnectionString)
				End Select
			Else
				_currentConnectionFrame = New XmlFileFrame(_connectionInfo.ConnectionString)
			End If

            If _currentConnectionFrame IsNot Nothing Then
                _currentConnectionFrame.Dock = DockStyle.Fill
                _currentConnectionFrame.Parent = pnlFrames
            End If

            BoxSyntaxProvider.Enabled = _connectionInfo.Type = ConnectionTypes.ODBC Or _connectionInfo.Type = ConnectionTypes.OLEDB
        End Sub

		Private Sub ConnectionTypeChanged(sender As Object, e As EventArgs)
            If (DirectCast(sender, RadioButton)).Checked <> True Then
                Return
            End If
            Dim connectionType As ConnectionTypes = ConnectionTypes.MSSQL
            If Equals(sender, rbMSSQL) Then
                connectionType = ConnectionTypes.MSSQL
            ElseIf Equals(sender, rbMSAccess) Then
                connectionType = ConnectionTypes.MSAccess
            ElseIf Equals(sender, rbOracle) Then
                connectionType = ConnectionTypes.Oracle
            ElseIf Equals(sender, rbMySQL) Then
                connectionType = ConnectionTypes.MySQL
            ElseIf Equals(sender, rbPostrgeSQL) Then
                connectionType = ConnectionTypes.PostgreSQL
            ElseIf Equals(sender, rbOLEDB) Then
                connectionType = ConnectionTypes.OLEDB
            ElseIf Equals(sender, rbODBC) Then
                connectionType = ConnectionTypes.ODBC
            End If
            If connectionType <> _connectionInfo.Type Then
                _connectionInfo.Type = connectionType
                If Not _connectionInfo.IsXmlFile Then
                    SetActiveConnectionTypeFrame()
                End If
            End If
            Select Case _connectionInfo.Type
                Case ConnectionTypes.MSSQL
                    _connectionInfo.SyntaxProvider = New MSSQLSyntaxProvider()
                    Exit Select
                Case ConnectionTypes.MSAccess
                    _connectionInfo.SyntaxProvider = New MSAccessSyntaxProvider()
                    Exit Select
                Case ConnectionTypes.Oracle
                    _connectionInfo.SyntaxProvider = New OracleSyntaxProvider()
                    Exit Select
                Case ConnectionTypes.MySQL
                    _connectionInfo.SyntaxProvider = New MySQLSyntaxProvider()
                    Exit Select
                Case ConnectionTypes.PostgreSQL
                    _connectionInfo.SyntaxProvider = New PostgreSQLSyntaxProvider()
                    Exit Select
                Case ConnectionTypes.OLEDB
                    _connectionInfo.SyntaxProvider = New SQL92SyntaxProvider()
                    Exit Select
                Case ConnectionTypes.ODBC
                    _connectionInfo.SyntaxProvider = New SQL92SyntaxProvider()
                    Exit Select
            End Select
            BoxSyntaxProvider.Enabled = _connectionInfo.Type = ConnectionTypes.ODBC OrElse _connectionInfo.Type = ConnectionTypes.OLEDB
            FillSyntax()
        End Sub

		Private Sub Application_Idle(sender As Object, e As EventArgs)
			btnOk.Enabled = (tbConnectionName.Text.Length > 0)
		End Sub

		Private Sub ConnectionEditForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
			If DialogResult = DialogResult.OK Then
                If _currentConnectionFrame IsNot Nothing AndAlso _currentConnectionFrame.TestConnection() Then
                    _connectionInfo.Name = tbConnectionName.Text
                    _connectionInfo.ConnectionString = _currentConnectionFrame.ConnectionString
                    If Not _connectionInfo.IsXmlFile Then
                        'previous version of this demo uses deprecated System.Data.OracleClient
                        ' current version uses Oracle.ManagedDataAccess.Client which doesn't support "Integrated Security" setting
                        If _connectionInfo.Type = ConnectionTypes.Oracle Then
                            _currentConnectionFrame.ConnectionString = Regex.Replace(_currentConnectionFrame.ConnectionString, "Integrated Security=.*?;", "")
                        End If

                        _connectionInfo.ConnectionDescriptor.ConnectionString = _currentConnectionFrame.ConnectionString
                    End If

                    e.Cancel = False
                Else
                    e.Cancel = True
				End If
			End If
		End Sub

        Private Sub FillSyntax()
            _isLockUpdate = True

            BoxSyntaxProvider.Items.Clear()
            BoxSyntaxProvider.SelectedItem = Nothing
            BoxSyntaxProvider.Text = String.Empty

            If (Not String.IsNullOrEmpty(_connectionInfo.SyntaxProviderName)) AndAlso _connectionInfo.SyntaxProvider Is Nothing Then
                BoxSyntaxProvider.Items.Add(_connectionInfo.ConnectionDescriptor.SyntaxProvider.ToString())
                BoxSyntaxProvider.SelectedItem = _connectionInfo.ConnectionDescriptor.SyntaxProvider.ToString()
                BoxSyntaxProvider.Text = _connectionInfo.ConnectionDescriptor.SyntaxProvider.ToString()
                Return
            End If

            If _connectionInfo.SyntaxProvider Is Nothing Then
                Select Case _connectionInfo.Type
                    Case ConnectionTypes.MSSQL
                        _connectionInfo.SyntaxProvider = New MSSQLSyntaxProvider()
                    Case ConnectionTypes.MSAccess
                        _connectionInfo.SyntaxProvider = New MSAccessSyntaxProvider()
                    Case ConnectionTypes.Oracle
                        _connectionInfo.SyntaxProvider = New OracleSyntaxProvider()
                    Case ConnectionTypes.MySQL
                        _connectionInfo.SyntaxProvider = New MySQLSyntaxProvider()
                    Case ConnectionTypes.PostgreSQL
                        _connectionInfo.SyntaxProvider = New PostgreSQLSyntaxProvider()
                    Case ConnectionTypes.OLEDB
                        _connectionInfo.SyntaxProvider = New SQL92SyntaxProvider()
                    Case ConnectionTypes.ODBC
                        _connectionInfo.SyntaxProvider = New SQL92SyntaxProvider()
                End Select
            End If

            If TypeOf _connectionInfo.SyntaxProvider Is SQL2003SyntaxProvider Then
                BoxSyntaxProvider.Items.Add("ANSI SQL-2003")
                BoxSyntaxProvider.SelectedItem = "ANSI SQL-2003"

                BoxSyntaxProvider.Items.Add("ANSI SQL-92")
                BoxSyntaxProvider.Items.Add("ANSI SQL-89")
                BoxSyntaxProvider.Items.Add("Firebird")
                BoxSyntaxProvider.Items.Add("IBM DB2")
                BoxSyntaxProvider.Items.Add("IBM Informix")
                BoxSyntaxProvider.Items.Add("Microsoft Access")
                BoxSyntaxProvider.Items.Add("Microsoft SQL Server")
                BoxSyntaxProvider.Items.Add("MySQL")
                BoxSyntaxProvider.Items.Add("Oracle")
                BoxSyntaxProvider.Items.Add("PostgreSQL")
                BoxSyntaxProvider.Items.Add("SQLite")
                BoxSyntaxProvider.Items.Add("Sybase")
                BoxSyntaxProvider.Items.Add("VistaDB")
                BoxSyntaxProvider.Items.Add("Universal")
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is SQL92SyntaxProvider Then
                BoxSyntaxProvider.Items.Add("ANSI SQL-92")
                BoxSyntaxProvider.SelectedItem = "ANSI SQL-92"

                BoxSyntaxProvider.Items.Add("ANSI SQL-2003")

                BoxSyntaxProvider.Items.Add("ANSI SQL-89")
                BoxSyntaxProvider.Items.Add("Firebird")
                BoxSyntaxProvider.Items.Add("IBM DB2")
                BoxSyntaxProvider.Items.Add("IBM Informix")
                BoxSyntaxProvider.Items.Add("Microsoft Access")
                BoxSyntaxProvider.Items.Add("Microsoft SQL Server")
                BoxSyntaxProvider.Items.Add("MySQL")
                BoxSyntaxProvider.Items.Add("Oracle")
                BoxSyntaxProvider.Items.Add("PostgreSQL")
                BoxSyntaxProvider.Items.Add("SQLite")
                BoxSyntaxProvider.Items.Add("Sybase")
                BoxSyntaxProvider.Items.Add("VistaDB")
                BoxSyntaxProvider.Items.Add("Universal")
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is SQL89SyntaxProvider Then
                BoxSyntaxProvider.Items.Add("ANSI SQL-89")
                BoxSyntaxProvider.SelectedItem = "ANSI SQL-89"

                BoxSyntaxProvider.Items.Add("ANSI SQL-2003")
                BoxSyntaxProvider.Items.Add("ANSI SQL-92")
                BoxSyntaxProvider.Items.Add("Firebird")
                BoxSyntaxProvider.Items.Add("IBM DB2")
                BoxSyntaxProvider.Items.Add("IBM Informix")
                BoxSyntaxProvider.Items.Add("Microsoft Access")
                BoxSyntaxProvider.Items.Add("Microsoft SQL Server")
                BoxSyntaxProvider.Items.Add("MySQL")
                BoxSyntaxProvider.Items.Add("Oracle")
                BoxSyntaxProvider.Items.Add("PostgreSQL")
                BoxSyntaxProvider.Items.Add("SQLite")
                BoxSyntaxProvider.Items.Add("Sybase")
                BoxSyntaxProvider.Items.Add("VistaDB")
                BoxSyntaxProvider.Items.Add("Universal")
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is FirebirdSyntaxProvider Then
                BoxSyntaxProvider.Items.Add("Firebird")
                BoxSyntaxProvider.SelectedItem = "Firebird"
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is DB2SyntaxProvider Then
                BoxSyntaxProvider.Items.Add("IBM DB2")
                BoxSyntaxProvider.SelectedItem = "IBM DB2"
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is InformixSyntaxProvider Then
                BoxSyntaxProvider.Items.Add("IBM Informix")
                BoxSyntaxProvider.SelectedItem = "IBM Informix"
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSAccessSyntaxProvider Then
                BoxSyntaxProvider.Items.Add("Microsoft Access")
                BoxSyntaxProvider.SelectedItem = "Microsoft Access"
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSSQLSyntaxProvider Then
                BoxSyntaxProvider.Items.Add("Microsoft SQL Server")
                BoxSyntaxProvider.SelectedItem = "Microsoft SQL Server"
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is MySQLSyntaxProvider Then
                BoxSyntaxProvider.Items.Add("MySQL")
                BoxSyntaxProvider.SelectedItem = "MySQL"
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is OracleSyntaxProvider Then
                BoxSyntaxProvider.Items.Add("Oracle")
                BoxSyntaxProvider.SelectedItem = "Oracle"
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is PostgreSQLSyntaxProvider Then
                BoxSyntaxProvider.Items.Add("PostgreSQL")
                BoxSyntaxProvider.SelectedItem = "PostgreSQL"
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is SQLiteSyntaxProvider Then
                BoxSyntaxProvider.Items.Add("SQLite")
                BoxSyntaxProvider.SelectedItem = "SQLite"
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is SybaseSyntaxProvider Then
                BoxSyntaxProvider.Items.Add("Sybase")
                BoxSyntaxProvider.SelectedItem = "Sybase"
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is VistaDBSyntaxProvider Then
                BoxSyntaxProvider.Items.Add("VistaDB")
                BoxSyntaxProvider.SelectedItem = "VistaDB"
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is GenericSyntaxProvider Then
                BoxSyntaxProvider.Items.Add("Universal")
                BoxSyntaxProvider.SelectedItem = "Universal"


                BoxSyntaxProvider.Items.Add("ANSI SQL-2003")
                BoxSyntaxProvider.Items.Add("ANSI SQL-92")
                BoxSyntaxProvider.Items.Add("ANSI SQL-89")
                BoxSyntaxProvider.Items.Add("Firebird")
                BoxSyntaxProvider.Items.Add("IBM DB2")
                BoxSyntaxProvider.Items.Add("IBM Informix")
                BoxSyntaxProvider.Items.Add("Microsoft Access")
                BoxSyntaxProvider.Items.Add("Microsoft SQL Server")
                BoxSyntaxProvider.Items.Add("MySQL")
                BoxSyntaxProvider.Items.Add("Oracle")
                BoxSyntaxProvider.Items.Add("PostgreSQL")
                BoxSyntaxProvider.Items.Add("SQLite")
                BoxSyntaxProvider.Items.Add("Sybase")
                BoxSyntaxProvider.Items.Add("VistaDB")
                BoxSyntaxProvider.Items.Add("Universal")
            End If


            FillVersions()

            _isLockUpdate = False
        End Sub

        Private Sub FillVersions()
            BoxServerVersion.Items.Clear()
            BoxServerVersion.SelectedItem = Nothing
            BoxServerVersion.Text = String.Empty

            If TypeOf _connectionInfo.SyntaxProvider Is SQL2003SyntaxProvider Then
                BoxServerVersion.Enabled = False
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is SQL92SyntaxProvider Then
                BoxServerVersion.Enabled = False
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is SQL89SyntaxProvider Then
                BoxServerVersion.Enabled = False
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is FirebirdSyntaxProvider Then
                BoxServerVersion.Enabled = True
                BoxServerVersion.Items.Add("Firebird 1.0")
                BoxServerVersion.Items.Add("Firebird 1.5")
                BoxServerVersion.Items.Add("Firebird 2.0")
                BoxServerVersion.Items.Add("Firebird 2.5")

                If (CType(_connectionInfo.SyntaxProvider, FirebirdSyntaxProvider)).ServerVersion = FirebirdVersion.Firebird10 Then
                    BoxServerVersion.SelectedItem = "Firebird 1.0"
                ElseIf (CType(_connectionInfo.SyntaxProvider, FirebirdSyntaxProvider)).ServerVersion = FirebirdVersion.Firebird15 Then
                    BoxServerVersion.SelectedItem = "Firebird 1.5"
                End If
                If (CType(_connectionInfo.SyntaxProvider, FirebirdSyntaxProvider)).ServerVersion = FirebirdVersion.Firebird20 Then
                    BoxServerVersion.SelectedItem = "Firebird 2.0"
                End If
                If (CType(_connectionInfo.SyntaxProvider, FirebirdSyntaxProvider)).ServerVersion = FirebirdVersion.Firebird25 Then
                    BoxServerVersion.SelectedItem = "Firebird 2.5"
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is DB2SyntaxProvider Then
                BoxServerVersion.Enabled = False
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is InformixSyntaxProvider Then
                BoxServerVersion.Enabled = True
                BoxServerVersion.Items.Add("Informix 8")
                BoxServerVersion.Items.Add("Informix 9")
                BoxServerVersion.Items.Add("Informix 10")

                If (CType(_connectionInfo.SyntaxProvider, InformixSyntaxProvider)).ServerVersion = InformixVersion.DS8 Then
                    BoxServerVersion.SelectedItem = "Informix 8"
                ElseIf (CType(_connectionInfo.SyntaxProvider, InformixSyntaxProvider)).ServerVersion = InformixVersion.DS9 Then
                    BoxServerVersion.SelectedItem = "Informix 9"
                End If
                If (CType(_connectionInfo.SyntaxProvider, InformixSyntaxProvider)).ServerVersion = InformixVersion.DS10 Then
                    BoxServerVersion.SelectedItem = "Informix 10"
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSAccessSyntaxProvider Then
                BoxServerVersion.Enabled = True
                BoxServerVersion.Items.Add("MS Jet 3")
                BoxServerVersion.Items.Add("MS Jet 4")

                If (CType(_connectionInfo.SyntaxProvider, MSAccessSyntaxProvider)).ServerVersion = MSAccessServerVersion.MSJET3 Then
                    BoxServerVersion.SelectedItem = "MS Jet 3"
                ElseIf (CType(_connectionInfo.SyntaxProvider, MSAccessSyntaxProvider)).ServerVersion = MSAccessServerVersion.MSJET4 Then
                    BoxServerVersion.SelectedItem = "MS Jet 4"
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSSQLSyntaxProvider Then
                BoxServerVersion.Enabled = True
                BoxServerVersion.Items.Add("Auto")
                BoxServerVersion.Items.Add("SQL Server 7")
                BoxServerVersion.Items.Add("SQL Server 2000")
                BoxServerVersion.Items.Add("SQL Server 2005")
                BoxServerVersion.Items.Add("SQL Server 2008")
                BoxServerVersion.Items.Add("SQL Server 2012")
                BoxServerVersion.Items.Add("SQL Server 2014")
                BoxServerVersion.Items.Add("SQL Server 2016")
                BoxServerVersion.Items.Add("SQL Server 2017")
                BoxServerVersion.Items.Add("SQL Server 2019")

                If (CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)).ServerVersion = MSSQLServerVersion.MSSQL7 Then
                    BoxServerVersion.SelectedItem = "SQL Server 7"
                ElseIf (CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)).ServerVersion = MSSQLServerVersion.MSSQL2000 Then
                    BoxServerVersion.SelectedItem = "SQL Server 2000"
                ElseIf (CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)).ServerVersion = MSSQLServerVersion.MSSQL2005 Then
                    BoxServerVersion.SelectedItem = "SQL Server 2005"
                ElseIf (CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)).ServerVersion = MSSQLServerVersion.MSSQL2008 Then
                    BoxServerVersion.SelectedItem = "SQL Server 2008"
                ElseIf (CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)).ServerVersion = MSSQLServerVersion.MSSQL2012 Then
                    BoxServerVersion.SelectedItem = "SQL Server 2012"
                ElseIf (CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)).ServerVersion = MSSQLServerVersion.MSSQL2014 Then
                    BoxServerVersion.SelectedItem = "SQL Server 2014"
                ElseIf (CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)).ServerVersion = MSSQLServerVersion.MSSQL2016 Then
                    BoxServerVersion.SelectedItem = "SQL Server 2016"
                ElseIf (CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)).ServerVersion = MSSQLServerVersion.MSSQL2017 Then
                    BoxServerVersion.SelectedItem = "SQL Server 2017"
                ElseIf (CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)).ServerVersion = MSSQLServerVersion.MSSQL2019 Then
                    BoxServerVersion.SelectedItem = "SQL Server 2019"
                Else
                    BoxServerVersion.SelectedItem = "Auto"
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is MySQLSyntaxProvider Then
                BoxServerVersion.Enabled = True
                BoxServerVersion.Items.Add("3.0")
                BoxServerVersion.Items.Add("4.0")
                BoxServerVersion.Items.Add("5.0")
                BoxServerVersion.Items.Add("8.0")

                If (CType(_connectionInfo.SyntaxProvider, MySQLSyntaxProvider)).ServerVersionInt < 40000 Then
                    BoxServerVersion.SelectedItem = "3.0"
                ElseIf (CType(_connectionInfo.SyntaxProvider, MySQLSyntaxProvider)).ServerVersionInt < 50000 Then
                    BoxServerVersion.SelectedItem = "4.0"
                ElseIf (CType(_connectionInfo.SyntaxProvider, MySQLSyntaxProvider)).ServerVersionInt < 80000 Then
                    BoxServerVersion.SelectedItem = "5.0"
                Else
                    BoxServerVersion.SelectedItem = "8.0"
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is OracleSyntaxProvider Then
                BoxServerVersion.Enabled = True
                BoxServerVersion.Items.Add("Oracle 7")
                BoxServerVersion.Items.Add("Oracle 8")
                BoxServerVersion.Items.Add("Oracle 9")
                BoxServerVersion.Items.Add("Oracle 10")
                BoxServerVersion.Items.Add("Oracle 11g")
                BoxServerVersion.Items.Add("Oracle 12c")
                BoxServerVersion.Items.Add("Oracle 18c")
                BoxServerVersion.Items.Add("Oracle 19c")

                If (CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider)).ServerVersion = OracleServerVersion.Oracle7 Then
                    BoxServerVersion.SelectedItem = "Oracle 7"
                ElseIf (CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider)).ServerVersion = OracleServerVersion.Oracle8 Then
                    BoxServerVersion.SelectedItem = "Oracle 8"
                ElseIf (CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider)).ServerVersion = OracleServerVersion.Oracle9 Then
                    BoxServerVersion.SelectedItem = "Oracle 9"
                ElseIf (CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider)).ServerVersion = OracleServerVersion.Oracle10 Then
                    BoxServerVersion.SelectedItem = "Oracle 10"
                ElseIf (CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider)).ServerVersion = OracleServerVersion.Oracle11 Then
                    BoxServerVersion.SelectedItem = "Oracle 11g"
                ElseIf (CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider)).ServerVersion = OracleServerVersion.Oracle12 Then
                    BoxServerVersion.SelectedItem = "Oracle 12c"
                ElseIf (CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider)).ServerVersion = OracleServerVersion.Oracle18 Then
                    BoxServerVersion.SelectedItem = "Oracle 18c"
                ElseIf (CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider)).ServerVersion = OracleServerVersion.Oracle19 Then
                    BoxServerVersion.SelectedItem = "Oracle 19c"
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is PostgreSQLSyntaxProvider Then
                BoxServerVersion.Enabled = False
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is SQLiteSyntaxProvider Then
                BoxServerVersion.Enabled = False
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is SybaseSyntaxProvider Then
                BoxServerVersion.Enabled = True
                BoxServerVersion.Items.Add("ASE")
                BoxServerVersion.Items.Add("SQL Anywhere")

                If (CType(_connectionInfo.SyntaxProvider, SybaseSyntaxProvider)).ServerVersion = SybaseServerVersion.SybaseASE Then
                    BoxServerVersion.SelectedItem = "ASE"
                ElseIf (CType(_connectionInfo.SyntaxProvider, SybaseSyntaxProvider)).ServerVersion = SybaseServerVersion.SybaseASA Then
                    BoxServerVersion.SelectedItem = "SQL Anywhere"
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is VistaDBSyntaxProvider Then
                BoxServerVersion.Enabled = False
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is GenericSyntaxProvider Then
                BoxServerVersion.Enabled = False
            End If
        End Sub

        Private Sub BoxSyntaxProvider_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxSyntaxProvider.SelectedIndexChanged
            If _isLockUpdate Then Return

            Select Case (CStr(BoxSyntaxProvider.SelectedItem))
                Case "ANSI SQL-2003"
                    _connectionInfo.SyntaxProvider = New SQL2003SyntaxProvider()
                Case "ANSI SQL-92"
                    _connectionInfo.SyntaxProvider = New SQL92SyntaxProvider()
                Case "ANSI SQL-89"
                    _connectionInfo.SyntaxProvider = New SQL89SyntaxProvider()
                Case "Firebird"
                    _connectionInfo.SyntaxProvider = New FirebirdSyntaxProvider()
                Case "IBM DB2"
                    _connectionInfo.SyntaxProvider = New DB2SyntaxProvider()
                Case "IBM Informix"
                    _connectionInfo.SyntaxProvider = New InformixSyntaxProvider()
                Case "Microsoft Access"
                    _connectionInfo.SyntaxProvider = New MSAccessSyntaxProvider()
                Case "Microsoft SQL Server"
                    _connectionInfo.SyntaxProvider = New MSSQLSyntaxProvider()
                Case "MySQL"
                    _connectionInfo.SyntaxProvider = New MySQLSyntaxProvider()
                Case "Oracle"
                    _connectionInfo.SyntaxProvider = New OracleSyntaxProvider()
                Case "PostgreSQL"
                    _connectionInfo.SyntaxProvider = New PostgreSQLSyntaxProvider()
                Case "SQLite"
                    _connectionInfo.SyntaxProvider = New SQLiteSyntaxProvider()
                Case "Sybase"
                    _connectionInfo.SyntaxProvider = New SybaseSyntaxProvider()
                Case "VistaDB"
                    _connectionInfo.SyntaxProvider = New VistaDBSyntaxProvider()
                Case "Universal"
                    _connectionInfo.SyntaxProvider = New GenericSyntaxProvider()
            End Select

            FillVersions()
        End Sub

        Private Sub BoxServerVersion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxServerVersion.SelectedIndexChanged
            If _isLockUpdate Then Return

            If TypeOf _connectionInfo.SyntaxProvider Is FirebirdSyntaxProvider Then
                If CStr(BoxServerVersion.SelectedItem) Is "Firebird 1.0" Then
                    CType(_connectionInfo.SyntaxProvider, FirebirdSyntaxProvider).ServerVersion = FirebirdVersion.Firebird10
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "Firebird 1.5" Then
                    CType(_connectionInfo.SyntaxProvider, FirebirdSyntaxProvider).ServerVersion = FirebirdVersion.Firebird15
                End If
                If CStr(BoxServerVersion.SelectedItem) Is "Firebird 2.0" Then
                    CType(_connectionInfo.SyntaxProvider, FirebirdSyntaxProvider).ServerVersion = FirebirdVersion.Firebird20
                End If
                If CStr(BoxServerVersion.SelectedItem) Is "Firebird 2.5" Then
                    CType(_connectionInfo.SyntaxProvider, FirebirdSyntaxProvider).ServerVersion = FirebirdVersion.Firebird25
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is InformixSyntaxProvider Then
                If CStr(BoxServerVersion.SelectedItem) Is "Informix 8" Then
                    CType(_connectionInfo.SyntaxProvider, InformixSyntaxProvider).ServerVersion = InformixVersion.DS8
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "Informix 9" Then
                    CType(_connectionInfo.SyntaxProvider, InformixSyntaxProvider).ServerVersion = InformixVersion.DS9
                End If
                If CStr(BoxServerVersion.SelectedItem) Is "Informix 10" Then
                    CType(_connectionInfo.SyntaxProvider, InformixSyntaxProvider).ServerVersion = InformixVersion.DS10
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSAccessSyntaxProvider Then
                If CStr(BoxServerVersion.SelectedItem) Is "MS Jet 3" Then
                    CType(_connectionInfo.SyntaxProvider, MSAccessSyntaxProvider).ServerVersion = MSAccessServerVersion.MSJET3
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "MS Jet 4" Then
                    CType(_connectionInfo.SyntaxProvider, MSAccessSyntaxProvider).ServerVersion = MSAccessServerVersion.MSJET4
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSSQLSyntaxProvider Then
                If CStr(BoxServerVersion.SelectedItem) Is "Auto" Then
                    CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider).ServerVersion = MSSQLServerVersion.Auto
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "SQL Server 7" Then
                    CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider).ServerVersion = MSSQLServerVersion.MSSQL7
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "SQL Server 2000" Then
                    CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider).ServerVersion = MSSQLServerVersion.MSSQL2000
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "SQL Server 2005" Then
                    CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider).ServerVersion = MSSQLServerVersion.MSSQL2005
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "SQL Server 2008" Then
                    CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider).ServerVersion = MSSQLServerVersion.MSSQL2008
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "SQL Server 2012" Then
                    CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider).ServerVersion = MSSQLServerVersion.MSSQL2012
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "SQL Server 2014" Then
                    CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider).ServerVersion = MSSQLServerVersion.MSSQL2014
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "SQL Server 2016" Then
                    CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider).ServerVersion = MSSQLServerVersion.MSSQL2016
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "SQL Server 2017" Then
                    CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider).ServerVersion = MSSQLServerVersion.MSSQL2017
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "SQL Server 2019" Then
                    CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider).ServerVersion = MSSQLServerVersion.MSSQL2019
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is MySQLSyntaxProvider Then
                If CStr(BoxServerVersion.SelectedItem) Is "3.0" Then
                    CType(_connectionInfo.SyntaxProvider, MySQLSyntaxProvider).ServerVersionInt = 39999
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "4.0" Then
                    CType(_connectionInfo.SyntaxProvider, MySQLSyntaxProvider).ServerVersionInt = 49999
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "5.0" Then
                    CType(_connectionInfo.SyntaxProvider, MySQLSyntaxProvider).ServerVersionInt = 50000
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "8.0" Then
                    CType(_connectionInfo.SyntaxProvider, MySQLSyntaxProvider).ServerVersionInt = 80012
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is OracleSyntaxProvider Then
                If CStr(BoxServerVersion.SelectedItem) Is "Oracle 7" Then
                    CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider).ServerVersion = OracleServerVersion.Oracle7
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "Oracle 8" Then
                    CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider).ServerVersion = OracleServerVersion.Oracle8
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "Oracle 9" Then
                    CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider).ServerVersion = OracleServerVersion.Oracle9
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "Oracle 10" Then
                    CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider).ServerVersion = OracleServerVersion.Oracle10
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "Oracle 11g" Then
                    CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider).ServerVersion = OracleServerVersion.Oracle11
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "Oracle 12c" Then
                    CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider).ServerVersion = OracleServerVersion.Oracle12
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "Oracle 18c" Then
                    CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider).ServerVersion = OracleServerVersion.Oracle18
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "Oracle 19c" Then
                    CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider).ServerVersion = OracleServerVersion.Oracle19
                End If
            ElseIf TypeOf _connectionInfo.SyntaxProvider Is SybaseSyntaxProvider Then
                If CStr(BoxServerVersion.SelectedItem) Is "ASE" Then
                    CType(_connectionInfo.SyntaxProvider, SybaseSyntaxProvider).ServerVersion = SybaseServerVersion.SybaseASE
                ElseIf CStr(BoxServerVersion.SelectedItem) Is "SQL Anywhere" Then
                    CType(_connectionInfo.SyntaxProvider, SybaseSyntaxProvider).ServerVersion = SybaseServerVersion.SybaseASA
                End If
            End If
        End Sub

    End Class
End Namespace
