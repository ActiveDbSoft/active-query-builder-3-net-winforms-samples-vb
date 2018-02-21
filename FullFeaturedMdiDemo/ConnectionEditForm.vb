'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Diagnostics
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core

Imports FullFeaturedMdiDemo.ConnectionFrames

Public Partial Class ConnectionEditForm
    Inherits Form

    Private ReadOnly _connectionInfo As ConnectionInfo

    Private _currentConnectionFrame As ConnectionFrameBase

    Public Sub New(ByVal connectionInfo As ConnectionInfo)
        InitializeComponent()
        Debug.Assert(connectionInfo IsNot Nothing)
        _connectionInfo = connectionInfo
        tbConnectionName.Text = connectionInfo.ConnectionName
        If Not String.IsNullOrEmpty(connectionInfo.ConnectionString) Then
            Text = "Edit Connection"
            If Not connectionInfo.IsXmlFile Then
                rbMSSQL.Enabled =(connectionInfo.ConnectionType = ConnectionTypes.MSSQL)
                rbMSAccess.Enabled =(connectionInfo.ConnectionType = ConnectionTypes.MSAccess)
                rbOracle.Enabled =(connectionInfo.ConnectionType = ConnectionTypes.Oracle)
                rbMySQL.Enabled =(connectionInfo.ConnectionType = ConnectionTypes.MySQL)
                rbPostrgeSQL.Enabled =(connectionInfo.ConnectionType = ConnectionTypes.PostgreSQL)
                rbOLEDB.Enabled =(connectionInfo.ConnectionType = ConnectionTypes.OLEDB)
                rbODBC.Enabled =(connectionInfo.ConnectionType = ConnectionTypes.ODBC)
            End If
        End If

        If connectionInfo.IsXmlFile Then
            rbOLEDB.Enabled = False
            rbODBC.Enabled = False
        End If

        rbMSSQL.Checked =(connectionInfo.ConnectionType = ConnectionTypes.MSSQL)
        rbMSAccess.Checked =(connectionInfo.ConnectionType = ConnectionTypes.MSAccess)
        rbOracle.Checked =(connectionInfo.ConnectionType = ConnectionTypes.Oracle)
        rbMySQL.Checked =(connectionInfo.ConnectionType = ConnectionTypes.MySQL)
        rbPostrgeSQL.Checked =(connectionInfo.ConnectionType = ConnectionTypes.PostgreSQL)
        rbOLEDB.Checked =(connectionInfo.ConnectionType = ConnectionTypes.OLEDB)
        rbODBC.Checked =(connectionInfo.ConnectionType = ConnectionTypes.ODBC)
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
            Select Case _connectionInfo.ConnectionType
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
    End Sub

    Private Sub ConnectionTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
        If(CType(sender, RadioButton)).Checked <> True Then Return
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

        If connectionType <> _connectionInfo.ConnectionType Then
            _connectionInfo.ConnectionType = connectionType
            If Not _connectionInfo.IsXmlFile Then
                SetActiveConnectionTypeFrame()
            End If
        End If

        Select Case _connectionInfo.ConnectionType
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

        FillSyntax()
    End Sub

    Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
        btnOk.Enabled =(tbConnectionName.Text.Length > 0)
    End Sub

    Private Sub ConnectionEditForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        If DialogResult = DialogResult.OK Then
            If _currentConnectionFrame IsNot Nothing AndAlso _currentConnectionFrame.TestConnection() Then
                _connectionInfo.ConnectionName = tbConnectionName.Text
                _connectionInfo.ConnectionString = _currentConnectionFrame.ConnectionString
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FillSyntax()
        BoxSyntaxProvider.Items.Clear()
        BoxServerVersion.Items.Clear()
        If Not String.IsNullOrEmpty(_connectionInfo.SyntaxProviderName) AndAlso _connectionInfo.SyntaxProvider Is Nothing Then
            BoxSyntaxProvider.Items.Add(_connectionInfo.SyntaxProviderName)
            BoxSyntaxProvider.SelectedItem = _connectionInfo.SyntaxProviderName
            Return
        End If

        If _connectionInfo.SyntaxProvider Is Nothing Then
            Select Case _connectionInfo.ConnectionType
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
    End Sub

    Private Sub FillVersions()
        BoxServerVersion.Items.Clear()
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
            Dim firebirdSyntaxProvider As FirebirdSyntaxProvider = CType(_connectionInfo.SyntaxProvider, FirebirdSyntaxProvider)
            Select Case firebirdSyntaxProvider.ServerVersion
                Case FirebirdVersion.Firebird10
                    BoxServerVersion.SelectedItem = "Firebird 1.0"
                Case FirebirdVersion.Firebird15
                    BoxServerVersion.SelectedItem = "Firebird 1.5"
                Case FirebirdVersion.Firebird20
                    BoxServerVersion.SelectedItem = "Firebird 2.0"
                Case FirebirdVersion.Firebird25
                    BoxServerVersion.SelectedItem = "Firebird 2.5"
            End Select
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is DB2SyntaxProvider Then
            BoxServerVersion.Enabled = False
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is InformixSyntaxProvider Then
            BoxServerVersion.Enabled = True
            BoxServerVersion.Items.Add("Informix 8")
            BoxServerVersion.Items.Add("Informix 9")
            BoxServerVersion.Items.Add("Informix 10")
            BoxServerVersion.Items.Add("Informix 11")
            Dim informixSyntaxProvider As InformixSyntaxProvider = CType(_connectionInfo.SyntaxProvider, InformixSyntaxProvider)
            Select Case informixSyntaxProvider.ServerVersion
                Case InformixVersion.DS8
                    BoxServerVersion.SelectedItem = "Informix 8"
                Case InformixVersion.DS9
                    BoxServerVersion.SelectedItem = "Informix 9"
                Case InformixVersion.DS10
                    BoxServerVersion.SelectedItem = "Informix 10"
                Case Else
                    BoxServerVersion.SelectedItem = "Informix 11"
            End Select
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSAccessSyntaxProvider Then
            BoxServerVersion.Enabled = True
            BoxServerVersion.Items.Add("MS Jet 3")
            BoxServerVersion.Items.Add("MS Jet 4")
            Dim accessSyntaxProvider = CType(_connectionInfo.SyntaxProvider, MSAccessSyntaxProvider)
            BoxServerVersion.SelectedItem = If(accessSyntaxProvider.ServerVersion = MSAccessServerVersion.MSJET3, "MS Jet 3", "MS Jet 4")
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSSQLSyntaxProvider Then
            BoxServerVersion.Enabled = True
            BoxServerVersion.Items.Add("Auto")
            BoxServerVersion.Items.Add("SQL Server 7")
            BoxServerVersion.Items.Add("SQL Server 2000")
            BoxServerVersion.Items.Add("SQL Server 2005")
            BoxServerVersion.Items.Add("SQL Server 2012")
            BoxServerVersion.Items.Add("SQL Server 2014")
            Dim mssqlSyntaxProvider As MSSQLSyntaxProvider = CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)
            Select Case mssqlSyntaxProvider.ServerVersion
                Case MSSQLServerVersion.MSSQL7
                    BoxServerVersion.SelectedItem = "SQL Server 7"
                Case MSSQLServerVersion.MSSQL2000
                    BoxServerVersion.SelectedItem = "SQL Server 2000"
                Case MSSQLServerVersion.MSSQL2005
                    BoxServerVersion.SelectedItem = "SQL Server 2005"
                Case MSSQLServerVersion.MSSQL2012
                    BoxServerVersion.SelectedItem = "SQL Server 2012"
                Case MSSQLServerVersion.MSSQL2014
                    BoxServerVersion.SelectedItem = "SQL Server 2014"
                Case Else
                    BoxServerVersion.SelectedItem = "Auto"
            End Select
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is MySQLSyntaxProvider Then
            BoxServerVersion.Enabled = True
            BoxServerVersion.Items.Add("3.0")
            BoxServerVersion.Items.Add("4.0")
            BoxServerVersion.Items.Add("5.0+")
            Dim mySqlSyntaxProvider As MySQLSyntaxProvider = CType(_connectionInfo.SyntaxProvider, MySQLSyntaxProvider)
            If mySqlSyntaxProvider.ServerVersionInt < 40000 Then
                BoxServerVersion.SelectedItem = "3.0"
            ElseIf mySqlSyntaxProvider.ServerVersionInt < 50000 Then
                BoxServerVersion.SelectedItem = "4.0"
            Else
                BoxServerVersion.SelectedItem = "5.0+"
            End If
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is OracleSyntaxProvider Then
            BoxServerVersion.Enabled = True
            BoxServerVersion.Items.Add("Oracle 7")
            BoxServerVersion.Items.Add("Oracle 8")
            BoxServerVersion.Items.Add("Oracle 9")
            BoxServerVersion.Items.Add("Oracle 10")
            BoxServerVersion.Items.Add("Oracle 11")
            BoxServerVersion.Items.Add("Oracle 12")
            Dim oracleSyntaxProvider As OracleSyntaxProvider = CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider)
            Select Case oracleSyntaxProvider.ServerVersion
                Case OracleServerVersion.Oracle7
                    BoxServerVersion.SelectedItem = "Oracle 7"
                Case OracleServerVersion.Oracle8
                    BoxServerVersion.SelectedItem = "Oracle 8"
                Case OracleServerVersion.Oracle9
                    BoxServerVersion.SelectedItem = "Oracle 9"
                Case OracleServerVersion.Oracle10
                    BoxServerVersion.SelectedItem = "Oracle 10"
                Case OracleServerVersion.Oracle11
                    BoxServerVersion.SelectedItem = "Oracle 11"
                Case Else
                    BoxServerVersion.SelectedItem = "Oracle 12"
            End Select
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is PostgreSQLSyntaxProvider Then
            BoxServerVersion.Enabled = False
            BoxServerVersion.Text = "Auto"
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is SQLiteSyntaxProvider Then
            BoxServerVersion.Enabled = False
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is SybaseSyntaxProvider Then
            BoxServerVersion.Enabled = True
            BoxServerVersion.Items.Add("ASE")
            BoxServerVersion.Items.Add("SQL Anywhere")
            BoxServerVersion.Items.Add("SAP IQ")
            Dim sybaseSyntaxProvider As SybaseSyntaxProvider = CType(_connectionInfo.SyntaxProvider, SybaseSyntaxProvider)
            Select Case sybaseSyntaxProvider.ServerVersion
                Case SybaseServerVersion.SybaseASE
                    BoxServerVersion.SelectedItem = "ASE"
                Case SybaseServerVersion.SybaseASA
                    BoxServerVersion.SelectedItem = "SQL Anywhere"
                Case SybaseServerVersion.SybaseIQ
                    BoxServerVersion.SelectedItem = "SAP IQ"
            End Select
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is VistaDBSyntaxProvider Then
            BoxServerVersion.Enabled = False
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is GenericSyntaxProvider Then
            BoxServerVersion.Enabled = False
        End If
    End Sub

    Private Sub BoxSyntaxProvider_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Select Case CStr(BoxSyntaxProvider.SelectedItem)
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

    Private Sub BoxServerVersion_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim selectedItem As String = CStr(BoxServerVersion.SelectedItem)
        If TypeOf _connectionInfo.SyntaxProvider Is FirebirdSyntaxProvider Then
            Dim firebirdSyntaxProvider As FirebirdSyntaxProvider = CType(_connectionInfo.SyntaxProvider, FirebirdSyntaxProvider)
            Select Case selectedItem
                Case "Firebird 1.0"
                    firebirdSyntaxProvider.ServerVersion = FirebirdVersion.Firebird10
                Case "Firebird 1.5"
                    firebirdSyntaxProvider.ServerVersion = FirebirdVersion.Firebird15
                Case "Firebird 2.0"
                    firebirdSyntaxProvider.ServerVersion = FirebirdVersion.Firebird20
                Case Else
                    firebirdSyntaxProvider.ServerVersion = FirebirdVersion.Firebird25
            End Select
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is InformixSyntaxProvider Then
            Dim informixSyntaxProvider As InformixSyntaxProvider = CType(_connectionInfo.SyntaxProvider, InformixSyntaxProvider)
            Select Case selectedItem
                Case "Informix 8"
                    informixSyntaxProvider.ServerVersion = InformixVersion.DS8
                Case "Informix 9"
                    informixSyntaxProvider.ServerVersion = InformixVersion.DS9
                Case "Informix 10"
                    informixSyntaxProvider.ServerVersion = InformixVersion.DS10
                Case Else
                    informixSyntaxProvider.ServerVersion = InformixVersion.DS11
            End Select
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSAccessSyntaxProvider Then
            Dim accessSyntaxProvider As MSAccessSyntaxProvider = CType(_connectionInfo.SyntaxProvider, MSAccessSyntaxProvider)
            accessSyntaxProvider.ServerVersion = If(selectedItem = "MS Jet 3", MSAccessServerVersion.MSJET3, MSAccessServerVersion.MSJET4)
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSSQLSyntaxProvider Then
            Dim mssqlSyntaxProvider As MSSQLSyntaxProvider = CType(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)
            Select Case selectedItem
                Case "SQL Server 7"
                    mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL7
                Case "SQL Server 2000"
                    mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL2000
                Case "SQL Server 2005"
                    mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL2005
                Case "SQL Server 2012"
                    mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL2012
                Case "SQL Server 2014"
                    mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL2014
                Case Else
                    mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.Auto
            End Select
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is MySQLSyntaxProvider Then
            Dim mySqlSyntaxProvider As MySQLSyntaxProvider = CType(_connectionInfo.SyntaxProvider, MySQLSyntaxProvider)
            Select Case selectedItem
                Case "3.0"
                    mySqlSyntaxProvider.ServerVersionInt = 39999
                Case "4.0"
                    mySqlSyntaxProvider.ServerVersionInt = 49999
                Case Else
                    mySqlSyntaxProvider.ServerVersionInt = 50000
            End Select
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is OracleSyntaxProvider Then
            Dim oracleSyntaxProvider As OracleSyntaxProvider = CType(_connectionInfo.SyntaxProvider, OracleSyntaxProvider)
            Select Case selectedItem
                Case "Oracle 7"
                    oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle7
                Case "Oracle 8"
                    oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle8
                Case "Oracle 9"
                    oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle9
                Case "Oracle 10"
                    oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle10
                Case "Oracle 11"
                    oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle11
                Case Else
                    oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle12
            End Select
        ElseIf TypeOf _connectionInfo.SyntaxProvider Is SybaseSyntaxProvider Then
            Dim sybaseSyntaxProvider As SybaseSyntaxProvider = CType(_connectionInfo.SyntaxProvider, SybaseSyntaxProvider)
            Select Case selectedItem
                Case "ASE"
                    sybaseSyntaxProvider.ServerVersion = SybaseServerVersion.SybaseASE
                Case "SAP IQ"
                    sybaseSyntaxProvider.ServerVersion = SybaseServerVersion.SybaseIQ
                Case Else
                    sybaseSyntaxProvider.ServerVersion = SybaseServerVersion.SybaseASA
            End Select
        End If
    End Sub
End Class
