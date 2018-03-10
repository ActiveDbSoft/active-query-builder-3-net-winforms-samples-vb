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

	Public Sub New(connectionInfo As ConnectionInfo)
		InitializeComponent()

		Debug.Assert(connectionInfo IsNot Nothing)

		_connectionInfo = connectionInfo
		tbConnectionName.Text = connectionInfo.ConnectionName

		If Not [String].IsNullOrEmpty(connectionInfo.ConnectionString) Then
			Text = "Edit Connection"

			If Not connectionInfo.IsXmlFile Then
				rbMSSQL.Enabled = (connectionInfo.ConnectionType = ConnectionTypes.MSSQL)
				rbMSAccess.Enabled = (connectionInfo.ConnectionType = ConnectionTypes.MSAccess)
				rbOracle.Enabled = (connectionInfo.ConnectionType = ConnectionTypes.Oracle)
				rbMySQL.Enabled = (connectionInfo.ConnectionType = ConnectionTypes.MySQL)
				rbPostrgeSQL.Enabled = (connectionInfo.ConnectionType = ConnectionTypes.PostgreSQL)
				rbOLEDB.Enabled = (connectionInfo.ConnectionType = ConnectionTypes.OLEDB)
				rbODBC.Enabled = (connectionInfo.ConnectionType = ConnectionTypes.ODBC)
				If connectionInfo.ConnectionType = ConnectionTypes.ODBC OrElse connectionInfo.ConnectionType = ConnectionTypes.OLEDB Then
					BoxSyntaxProvider.Enabled = True
				End If
			End If
		End If

		If connectionInfo.IsXmlFile Then
			rbOLEDB.Enabled = False
			rbODBC.Enabled = False
		End If

		rbMSSQL.Checked = (connectionInfo.ConnectionType = ConnectionTypes.MSSQL)
		rbMSAccess.Checked = (connectionInfo.ConnectionType = ConnectionTypes.MSAccess)
		rbOracle.Checked = (connectionInfo.ConnectionType = ConnectionTypes.Oracle)
		rbMySQL.Checked = (connectionInfo.ConnectionType = ConnectionTypes.MySQL)
		rbPostrgeSQL.Checked = (connectionInfo.ConnectionType = ConnectionTypes.PostgreSQL)
		rbOLEDB.Checked = (connectionInfo.ConnectionType = ConnectionTypes.OLEDB)
		rbODBC.Checked = (connectionInfo.ConnectionType = ConnectionTypes.ODBC)

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
			RemoveHandler _currentConnectionFrame.OnSyntaxProviderDetected, AddressOf CurrentConnectionFrame_SyntaxProviderDetected
			_currentConnectionFrame.Dispose()
			_currentConnectionFrame = Nothing
		End If

		If Not _connectionInfo.IsXmlFile Then
			Select Case _connectionInfo.ConnectionType
				Case ConnectionTypes.MSSQL
					_currentConnectionFrame = New MSSQLConnectionFrame(_connectionInfo.ConnectionString)
					Exit Select
				Case ConnectionTypes.MSAccess
					_currentConnectionFrame = New MSAccessConnectionFrame(_connectionInfo.ConnectionString)
					Exit Select
				Case ConnectionTypes.Oracle
					_currentConnectionFrame = New OracleConnectionFrame(_connectionInfo.ConnectionString)
					Exit Select
				Case ConnectionTypes.MySQL
					_currentConnectionFrame = New MySQLConnectionFrame(_connectionInfo.ConnectionString)
					Exit Select
				Case ConnectionTypes.PostgreSQL
					_currentConnectionFrame = New PostgreSQLConnectionFrame(_connectionInfo.ConnectionString)
					Exit Select
				Case ConnectionTypes.OLEDB
					_currentConnectionFrame = New OLEDBConnectionFrame(_connectionInfo.ConnectionString)
					Exit Select
				Case ConnectionTypes.ODBC
					_currentConnectionFrame = New ODBCConnectionFrame(_connectionInfo.ConnectionString)
					Exit Select
			End Select
		Else
			_currentConnectionFrame = New XmlFileFrame(_connectionInfo.ConnectionString)
		End If

		If _currentConnectionFrame IsNot Nothing Then
			_currentConnectionFrame.Dock = DockStyle.Fill
			_currentConnectionFrame.Parent = pnlFrames
			AddHandler _currentConnectionFrame.OnSyntaxProviderDetected, AddressOf CurrentConnectionFrame_SyntaxProviderDetected
		End If
	End Sub

	Private Sub CurrentConnectionFrame_SyntaxProviderDetected(syntaxType As Type)
		Dim syntaxProvider = TryCast(Activator.CreateInstance(syntaxType), BaseSyntaxProvider)
		BoxSyntaxProvider.SelectedItem = SyntaxToString(syntaxProvider)
		FillVersions()
	End Sub

	Private Sub ConnectionTypeChanged(sender As Object, e As EventArgs)
		If DirectCast(sender, RadioButton).Checked <> True Then
			Return
		End If

		Dim connectionType = ConnectionTypes.MSSQL
		BoxSyntaxProvider.Enabled = False

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
			BoxSyntaxProvider.Enabled = True
		ElseIf Equals(sender, rbODBC) Then
			connectionType = ConnectionTypes.ODBC
			BoxSyntaxProvider.Enabled = True
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

		FillSyntax()
	End Sub

	Private Sub Application_Idle(sender As Object, e As EventArgs)
		btnOk.Enabled = (tbConnectionName.Text.Length > 0)
	End Sub

	Private Sub ConnectionEditForm_FormClosing(sender As Object, e As FormClosingEventArgs)
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

	Private Function SyntaxToString(syntax As BaseSyntaxProvider) As String
		If TypeOf syntax Is SQL2003SyntaxProvider Then
			Return "ANSI SQL-2003"
		ElseIf TypeOf syntax Is SQL92SyntaxProvider Then
			Return "ANSI SQL-92"
		ElseIf TypeOf syntax Is SQL89SyntaxProvider Then
			Return "ANSI SQL-89"
		ElseIf TypeOf syntax Is FirebirdSyntaxProvider Then
			Return "Firebird"
		ElseIf TypeOf syntax Is DB2SyntaxProvider Then
			Return "IBM DB2"
		ElseIf TypeOf syntax Is InformixSyntaxProvider Then
			Return "IBM Informix"
		ElseIf TypeOf syntax Is MSAccessSyntaxProvider Then
			Return "Microsoft Access"
		ElseIf TypeOf syntax Is MSSQLSyntaxProvider Then
			Return "Microsoft SQL Server"
		ElseIf TypeOf syntax Is MySQLSyntaxProvider Then
			Return "MySQL"
		ElseIf TypeOf syntax Is OracleSyntaxProvider Then
			Return "Oracle"
		ElseIf TypeOf syntax Is PostgreSQLSyntaxProvider Then
			Return "PostgreSQL"
		ElseIf TypeOf syntax Is SQLiteSyntaxProvider Then
			Return "SQLite"
		ElseIf TypeOf syntax Is SybaseSyntaxProvider Then
			Return "Sybase"
		ElseIf TypeOf syntax Is VistaDBSyntaxProvider Then
			Return "VistaDB"
		ElseIf TypeOf syntax Is GenericSyntaxProvider Then
			Return "Universal"
		End If

		Return String.Empty
	End Function

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
		End If

		If _connectionInfo.ConnectionType = ConnectionTypes.ODBC OrElse _connectionInfo.ConnectionType = ConnectionTypes.OLEDB Then
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
			BoxSyntaxProvider.SelectedItem = SyntaxToString(_connectionInfo.SyntaxProvider)
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is SQL2003SyntaxProvider Then
			BoxSyntaxProvider.Items.Add(SyntaxToString(_connectionInfo.SyntaxProvider))
			BoxSyntaxProvider.SelectedItem = SyntaxToString(_connectionInfo.SyntaxProvider)

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
			BoxSyntaxProvider.Items.Add(SyntaxToString(_connectionInfo.SyntaxProvider))
			BoxSyntaxProvider.SelectedItem = SyntaxToString(_connectionInfo.SyntaxProvider)

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
			BoxSyntaxProvider.Items.Add(SyntaxToString(_connectionInfo.SyntaxProvider))
			BoxSyntaxProvider.SelectedItem = SyntaxToString(_connectionInfo.SyntaxProvider)

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
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is GenericSyntaxProvider Then
			BoxSyntaxProvider.Items.Add(SyntaxToString(_connectionInfo.SyntaxProvider))
			BoxSyntaxProvider.SelectedItem = SyntaxToString(_connectionInfo.SyntaxProvider)

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
		Else
			BoxSyntaxProvider.Items.Add(SyntaxToString(_connectionInfo.SyntaxProvider))
			BoxSyntaxProvider.SelectedItem = SyntaxToString(_connectionInfo.SyntaxProvider)
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

			Dim firebirdSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, FirebirdSyntaxProvider)

			Select Case firebirdSyntaxProvider.ServerVersion
				Case FirebirdVersion.Firebird10
					BoxServerVersion.SelectedItem = "Firebird 1.0"
					Exit Select
				Case FirebirdVersion.Firebird15
					BoxServerVersion.SelectedItem = "Firebird 1.5"
					Exit Select
				Case FirebirdVersion.Firebird20
					BoxServerVersion.SelectedItem = "Firebird 2.0"
					Exit Select
				Case FirebirdVersion.Firebird25
					BoxServerVersion.SelectedItem = "Firebird 2.5"
					Exit Select
			End Select
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is DB2SyntaxProvider Then
			BoxServerVersion.Enabled = False
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is InformixSyntaxProvider Then
			BoxServerVersion.Enabled = True
			BoxServerVersion.Items.Add("Informix 8")
			BoxServerVersion.Items.Add("Informix 9")
			BoxServerVersion.Items.Add("Informix 10")
			BoxServerVersion.Items.Add("Informix 11")

			Dim informixSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, InformixSyntaxProvider)

			Select Case informixSyntaxProvider.ServerVersion
				Case InformixVersion.DS8
					BoxServerVersion.SelectedItem = "Informix 8"
					Exit Select
				Case InformixVersion.DS9
					BoxServerVersion.SelectedItem = "Informix 9"
					Exit Select
				Case InformixVersion.DS10
					BoxServerVersion.SelectedItem = "Informix 10"
					Exit Select
				Case Else
					BoxServerVersion.SelectedItem = "Informix 11"
					Exit Select
			End Select
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSAccessSyntaxProvider Then
			BoxServerVersion.Enabled = True
			BoxServerVersion.Items.Add("Access 97")
			BoxServerVersion.Items.Add("Access 2000 and newer")

			Dim accessSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, MSAccessSyntaxProvider)

			BoxServerVersion.SelectedItem = If(accessSyntaxProvider.ServerVersion = MSAccessServerVersion.MSJET3, "Access 97", "Access 2000 and newer")
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSSQLSyntaxProvider Then
			BoxServerVersion.Enabled = True
			BoxServerVersion.Items.Add("Auto")
			BoxServerVersion.Items.Add("SQL Server 7")
			BoxServerVersion.Items.Add("SQL Server 2000")
			BoxServerVersion.Items.Add("SQL Server 2005")
			BoxServerVersion.Items.Add("SQL Server 2012")
			BoxServerVersion.Items.Add("SQL Server 2014")

			Dim mssqlSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)

			Select Case mssqlSyntaxProvider.ServerVersion
				Case MSSQLServerVersion.MSSQL7
					BoxServerVersion.SelectedItem = "SQL Server 7"
					Exit Select
				Case MSSQLServerVersion.MSSQL2000
					BoxServerVersion.SelectedItem = "SQL Server 2000"
					Exit Select
				Case MSSQLServerVersion.MSSQL2005
					BoxServerVersion.SelectedItem = "SQL Server 2005"
					Exit Select
				Case MSSQLServerVersion.MSSQL2012
					BoxServerVersion.SelectedItem = "SQL Server 2012"
					Exit Select
				Case MSSQLServerVersion.MSSQL2014
					BoxServerVersion.SelectedItem = "SQL Server 2014"
					Exit Select
				Case Else
					BoxServerVersion.SelectedItem = "Auto"
					Exit Select
			End Select
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is MySQLSyntaxProvider Then
			BoxServerVersion.Enabled = True
			BoxServerVersion.Items.Add("3.0")
			BoxServerVersion.Items.Add("4.0")
			BoxServerVersion.Items.Add("5.0+")

			Dim mySqlSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, MySQLSyntaxProvider)

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

			Dim oracleSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, OracleSyntaxProvider)

			Select Case oracleSyntaxProvider.ServerVersion
				Case OracleServerVersion.Oracle7
					BoxServerVersion.SelectedItem = "Oracle 7"
					Exit Select
				Case OracleServerVersion.Oracle8
					BoxServerVersion.SelectedItem = "Oracle 8"
					Exit Select
				Case OracleServerVersion.Oracle9
					BoxServerVersion.SelectedItem = "Oracle 9"
					Exit Select
				Case OracleServerVersion.Oracle10
					BoxServerVersion.SelectedItem = "Oracle 10"
					Exit Select
				Case OracleServerVersion.Oracle11
					BoxServerVersion.SelectedItem = "Oracle 11"
					Exit Select
				Case Else
					BoxServerVersion.SelectedItem = "Oracle 12"
					Exit Select
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

			Dim sybaseSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, SybaseSyntaxProvider)

			Select Case sybaseSyntaxProvider.ServerVersion
				Case SybaseServerVersion.SybaseASE
					BoxServerVersion.SelectedItem = "ASE"
					Exit Select
				Case SybaseServerVersion.SybaseASA
					BoxServerVersion.SelectedItem = "SQL Anywhere"
					Exit Select
				Case SybaseServerVersion.SybaseIQ
					BoxServerVersion.SelectedItem = "SAP IQ"
					Exit Select
			End Select
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is VistaDBSyntaxProvider Then
			BoxServerVersion.Enabled = False
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is GenericSyntaxProvider Then
			BoxServerVersion.Enabled = False
		End If
	End Sub

	Private Sub BoxSyntaxProvider_SelectedIndexChanged(sender As Object, e As EventArgs)
		Select Case DirectCast(BoxSyntaxProvider.SelectedItem, String)
			Case "ANSI SQL-2003"
				_connectionInfo.SyntaxProvider = New SQL2003SyntaxProvider()
				Exit Select
			Case "ANSI SQL-92"
				_connectionInfo.SyntaxProvider = New SQL92SyntaxProvider()
				Exit Select
			Case "ANSI SQL-89"
				_connectionInfo.SyntaxProvider = New SQL89SyntaxProvider()
				Exit Select
			Case "Firebird"
				_connectionInfo.SyntaxProvider = New FirebirdSyntaxProvider()
				Exit Select
			Case "IBM DB2"
				_connectionInfo.SyntaxProvider = New DB2SyntaxProvider()
				Exit Select
			Case "IBM Informix"
				_connectionInfo.SyntaxProvider = New InformixSyntaxProvider()
				Exit Select
			Case "Microsoft Access"
				_connectionInfo.SyntaxProvider = New MSAccessSyntaxProvider()
				Exit Select
			Case "Microsoft SQL Server"
				_connectionInfo.SyntaxProvider = New MSSQLSyntaxProvider()
				Exit Select
			Case "MySQL"
				_connectionInfo.SyntaxProvider = New MySQLSyntaxProvider()
				Exit Select
			Case "Oracle"
				_connectionInfo.SyntaxProvider = New OracleSyntaxProvider()
				Exit Select
			Case "PostgreSQL"
				_connectionInfo.SyntaxProvider = New PostgreSQLSyntaxProvider()
				Exit Select
			Case "SQLite"
				_connectionInfo.SyntaxProvider = New SQLiteSyntaxProvider()
				Exit Select
			Case "Sybase"
				_connectionInfo.SyntaxProvider = New SybaseSyntaxProvider()
				Exit Select
			Case "VistaDB"
				_connectionInfo.SyntaxProvider = New VistaDBSyntaxProvider()
				Exit Select
			Case "Universal"
				_connectionInfo.SyntaxProvider = New GenericSyntaxProvider()
				Exit Select
		End Select

		FillVersions()
	End Sub

	Private Sub BoxServerVersion_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim selectedItem = DirectCast(BoxServerVersion.SelectedItem, String)

		If TypeOf _connectionInfo.SyntaxProvider Is FirebirdSyntaxProvider Then
			Dim firebirdSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, FirebirdSyntaxProvider)

			Select Case selectedItem
				Case "Firebird 1.0"
					firebirdSyntaxProvider.ServerVersion = FirebirdVersion.Firebird10
					Exit Select
				Case "Firebird 1.5"
					firebirdSyntaxProvider.ServerVersion = FirebirdVersion.Firebird15
					Exit Select
				Case "Firebird 2.0"
					firebirdSyntaxProvider.ServerVersion = FirebirdVersion.Firebird20
					Exit Select
				Case Else
					firebirdSyntaxProvider.ServerVersion = FirebirdVersion.Firebird25
					Exit Select
			End Select
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is InformixSyntaxProvider Then
			Dim informixSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, InformixSyntaxProvider)

			Select Case selectedItem
				Case "Informix 8"
					informixSyntaxProvider.ServerVersion = InformixVersion.DS8
					Exit Select
				Case "Informix 9"
					informixSyntaxProvider.ServerVersion = InformixVersion.DS9
					Exit Select
				Case "Informix 10"
					informixSyntaxProvider.ServerVersion = InformixVersion.DS10
					Exit Select
				Case Else
					informixSyntaxProvider.ServerVersion = InformixVersion.DS11
					Exit Select
			End Select
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSAccessSyntaxProvider Then
			Dim accessSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, MSAccessSyntaxProvider)

			accessSyntaxProvider.ServerVersion = If(selectedItem = "Access 97", MSAccessServerVersion.MSJET3, MSAccessServerVersion.MSJET4)
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is MSSQLSyntaxProvider Then
			Dim mssqlSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, MSSQLSyntaxProvider)

			Select Case selectedItem
				Case "SQL Server 7"
					mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL7
					Exit Select
				Case "SQL Server 2000"
					mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL2000
					Exit Select
				Case "SQL Server 2005"
					mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL2005
					Exit Select
				Case "SQL Server 2012"
					mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL2012
					Exit Select
				Case "SQL Server 2014"
					mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL2014
					Exit Select
				Case Else
					mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.Auto
					Exit Select
			End Select
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is MySQLSyntaxProvider Then
			Dim mySqlSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, MySQLSyntaxProvider)

			Select Case selectedItem
				Case "3.0"
					mySqlSyntaxProvider.ServerVersionInt = 39999
					Exit Select
				Case "4.0"
					mySqlSyntaxProvider.ServerVersionInt = 49999
					Exit Select
				Case Else
					mySqlSyntaxProvider.ServerVersionInt = 50000
					Exit Select
			End Select
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is OracleSyntaxProvider Then
			Dim oracleSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, OracleSyntaxProvider)

			Select Case selectedItem
				Case "Oracle 7"
					oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle7
					Exit Select
				Case "Oracle 8"
					oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle8
					Exit Select
				Case "Oracle 9"
					oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle9
					Exit Select
				Case "Oracle 10"
					oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle10
					Exit Select
				Case "Oracle 11"
					oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle11
					Exit Select
				Case Else
					oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle12
					Exit Select
			End Select
		ElseIf TypeOf _connectionInfo.SyntaxProvider Is SybaseSyntaxProvider Then
			Dim sybaseSyntaxProvider = DirectCast(_connectionInfo.SyntaxProvider, SybaseSyntaxProvider)

			Select Case selectedItem
				Case "ASE"
					sybaseSyntaxProvider.ServerVersion = SybaseServerVersion.SybaseASE
					Exit Select
				Case "SAP IQ"
					sybaseSyntaxProvider.ServerVersion = SybaseServerVersion.SybaseIQ
					Exit Select
				Case Else
					sybaseSyntaxProvider.ServerVersion = SybaseServerVersion.SybaseASA
					Exit Select
			End Select
		End If

		_currentConnectionFrame.SetServerType(selectedItem)
	End Sub

End Class
