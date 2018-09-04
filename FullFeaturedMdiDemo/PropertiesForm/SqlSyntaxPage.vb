'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.ComponentModel
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core

Namespace PropertiesForm
	<ToolboxItem(False)> _
	Friend Partial Class SqlSyntaxPage
		Inherits UserControl
		Private ReadOnly _sqlContext As SQLContext

		Public Sub New(sqlContext As SQLContext)
			_sqlContext = sqlContext

			InitializeComponent()

			comboIdentCaseSens.Items.Add("All identifiers are case insensitive")
			comboIdentCaseSens.Items.Add("Quoted are sensitive, Unquoted are converted to uppercase")
			comboIdentCaseSens.Items.Add("Quoted are sensitive, Unquoted are converted to lowercase")

			comboSqlDialect.Items.Add("Auto")
			comboSqlDialect.Items.Add("ANSI SQL-2003")
			comboSqlDialect.Items.Add("ANSI SQL-89")
			comboSqlDialect.Items.Add("ANSI SQL-92")
			comboSqlDialect.Items.Add("Firebird 1.0")
			comboSqlDialect.Items.Add("Firebird 1.5")
			comboSqlDialect.Items.Add("Firebird 2.0")
			comboSqlDialect.Items.Add("Firebird 2.5")
			comboSqlDialect.Items.Add("IBM DB2")
			comboSqlDialect.Items.Add("IBM Informix 8")
			comboSqlDialect.Items.Add("IBM Informix 9")
			comboSqlDialect.Items.Add("IBM Informix 10")
			comboSqlDialect.Items.Add("MS Access 97 (MS Jet 3.0)")
			comboSqlDialect.Items.Add("MS Access 2000 (MS Jet 4.0)")
			comboSqlDialect.Items.Add("MS Access XP (MS Jet 4.0)")
			comboSqlDialect.Items.Add("MS Access 2003 (MS Jet 4.0)")
			comboSqlDialect.Items.Add("MS SQL Server 7")
			comboSqlDialect.Items.Add("MS SQL Server 2000")
			comboSqlDialect.Items.Add("MS SQL Server 2005")
			comboSqlDialect.Items.Add("MS SQL Server 2008")
			comboSqlDialect.Items.Add("MS SQL Server 2012")
			comboSqlDialect.Items.Add("MS SQL Server 2014")
			comboSqlDialect.Items.Add("MS SQL Server Compact Edition")
			comboSqlDialect.Items.Add("MySQL 3.xx")
			comboSqlDialect.Items.Add("MySQL 4.0")
			comboSqlDialect.Items.Add("MySQL 4.1")
			comboSqlDialect.Items.Add("MySQL 5.0")
			comboSqlDialect.Items.Add("Oracle 7")
			comboSqlDialect.Items.Add("Oracle 8")
			comboSqlDialect.Items.Add("Oracle 9")
			comboSqlDialect.Items.Add("Oracle 10")
			comboSqlDialect.Items.Add("Oracle 11")
			comboSqlDialect.Items.Add("PostgreSQL")
			comboSqlDialect.Items.Add("SQLite")
			comboSqlDialect.Items.Add("Sybase ASE")
			comboSqlDialect.Items.Add("Sybase SQL Anywhere")
			comboSqlDialect.Items.Add("Teradata")
			comboSqlDialect.Items.Add("VistaDB")
			comboSqlDialect.Items.Add("Generic")

			If TypeOf _sqlContext.SyntaxProvider Is SQL92SyntaxProvider Then
				comboSqlDialect.SelectedItem = "ANSI SQL-92"
			ElseIf TypeOf _sqlContext.SyntaxProvider Is AutoSyntaxProvider Then
				comboSqlDialect.SelectedItem = "Auto"
			ElseIf TypeOf _sqlContext.SyntaxProvider Is SQL89SyntaxProvider Then
				comboSqlDialect.SelectedItem = "ANSI SQL-89"
			ElseIf TypeOf _sqlContext.SyntaxProvider Is SQL2003SyntaxProvider Then
				comboSqlDialect.SelectedItem = "ANSI SQL-2003"
			ElseIf TypeOf _sqlContext.SyntaxProvider Is FirebirdSyntaxProvider Then
				Select Case DirectCast(_sqlContext.SyntaxProvider, FirebirdSyntaxProvider).ServerVersion
					Case FirebirdVersion.Firebird10
						comboSqlDialect.SelectedItem = "Firebird 1.0"
						Exit Select
					Case FirebirdVersion.Firebird15
						comboSqlDialect.SelectedItem = "Firebird 1.5"
						Exit Select
					Case FirebirdVersion.Firebird25
						comboSqlDialect.SelectedItem = "Firebird 2.5"
						Exit Select
					Case Else
						comboSqlDialect.SelectedItem = "Firebird 2.0"
						Exit Select
				End Select
			ElseIf TypeOf _sqlContext.SyntaxProvider Is DB2SyntaxProvider Then
				comboSqlDialect.SelectedItem = "IBM DB2"
			ElseIf TypeOf _sqlContext.SyntaxProvider Is InformixSyntaxProvider Then
				Select Case DirectCast(_sqlContext.SyntaxProvider, InformixSyntaxProvider).ServerVersion
					Case InformixVersion.DS8
						comboSqlDialect.SelectedItem = "IBM Informix 8"
						Exit Select
					Case InformixVersion.DS9
						comboSqlDialect.SelectedItem = "IBM Informix 9"
						Exit Select
					Case Else
						comboSqlDialect.SelectedItem = "IBM Informix 10"
						Exit Select
				End Select
			ElseIf TypeOf _sqlContext.SyntaxProvider Is MSAccessSyntaxProvider Then
				Select Case DirectCast(_sqlContext.SyntaxProvider, MSAccessSyntaxProvider).ServerVersion
					Case MSAccessServerVersion.MSJET3
						comboSqlDialect.SelectedItem = "MS Access 97 (MS Jet 3.0)"
						Exit Select
					Case MSAccessServerVersion.MSJET4
						comboSqlDialect.SelectedItem = "MS Access 2003 (MS Jet 4.0)"
						Exit Select
					Case Else
						comboSqlDialect.SelectedItem = "MS Access 2003 (MS Jet 4.0)"
						Exit Select
				End Select
			ElseIf TypeOf _sqlContext.SyntaxProvider Is MSSQLCESyntaxProvider Then
				comboSqlDialect.SelectedItem = "MS SQL Server Compact Edition"
			ElseIf TypeOf _sqlContext.SyntaxProvider Is MSSQLSyntaxProvider Then
				Select Case DirectCast(_sqlContext.SyntaxProvider, MSSQLSyntaxProvider).ServerVersion
					Case MSSQLServerVersion.MSSQL7
						comboSqlDialect.SelectedItem = "MS SQL Server 7"
						Exit Select
					Case MSSQLServerVersion.MSSQL2000
						comboSqlDialect.SelectedItem = "MS SQL Server 2000"
						Exit Select
					Case MSSQLServerVersion.MSSQL2005
						comboSqlDialect.SelectedItem = "MS SQL Server 2005"
						Exit Select
					Case MSSQLServerVersion.MSSQL2008
						comboSqlDialect.SelectedItem = "MS SQL Server 2008"
						Exit Select
					Case MSSQLServerVersion.MSSQL2012
						comboSqlDialect.SelectedItem = "MS SQL Server 2012"
						Exit Select
					Case MSSQLServerVersion.MSSQL2014
						comboSqlDialect.SelectedItem = "MS SQL Server 2014"
						Exit Select
					Case Else
						comboSqlDialect.SelectedItem = "MS SQL Server 7"
						Exit Select
				End Select
			ElseIf TypeOf _sqlContext.SyntaxProvider Is MySQLSyntaxProvider Then
				If DirectCast(_sqlContext.SyntaxProvider, MySQLSyntaxProvider).ServerVersionInt < 40000 Then
					comboSqlDialect.SelectedItem = "MySQL 3.xx"
				ElseIf DirectCast(_sqlContext.SyntaxProvider, MySQLSyntaxProvider).ServerVersionInt <= 40099 Then
					comboSqlDialect.SelectedItem = "MySQL 4.0"
				ElseIf DirectCast(_sqlContext.SyntaxProvider, MySQLSyntaxProvider).ServerVersionInt < 50000 Then
					comboSqlDialect.SelectedItem = "MySQL 4.1"
				Else
					comboSqlDialect.SelectedItem = "MySQL 5.0"
				End If
			ElseIf TypeOf _sqlContext.SyntaxProvider Is OracleSyntaxProvider Then
				Select Case DirectCast(_sqlContext.SyntaxProvider, OracleSyntaxProvider).ServerVersion
					Case OracleServerVersion.Oracle7
						comboSqlDialect.SelectedItem = "Oracle 7"
						Exit Select
					Case OracleServerVersion.Oracle8
						comboSqlDialect.SelectedItem = "Oracle 8"
						Exit Select
					Case OracleServerVersion.Oracle9
						comboSqlDialect.SelectedItem = "Oracle 9"
						Exit Select
					Case OracleServerVersion.Oracle10
						comboSqlDialect.SelectedItem = "Oracle 10"
						Exit Select
					Case OracleServerVersion.Oracle11
						comboSqlDialect.SelectedItem = "Oracle 11"
						Exit Select
					Case Else
						comboSqlDialect.SelectedItem = "Oracle 11"
						Exit Select
				End Select
			ElseIf TypeOf _sqlContext.SyntaxProvider Is PostgreSQLSyntaxProvider Then
				comboSqlDialect.SelectedItem = "PostgreSQL"
			ElseIf TypeOf _sqlContext.SyntaxProvider Is SQLiteSyntaxProvider Then
				comboSqlDialect.SelectedItem = "SQLite"
			ElseIf TypeOf _sqlContext.SyntaxProvider Is SybaseSyntaxProvider Then
				Select Case DirectCast(_sqlContext.SyntaxProvider, SybaseSyntaxProvider).ServerVersion
					Case SybaseServerVersion.SybaseASE
						comboSqlDialect.SelectedItem = "Sybase ASE"
						Exit Select
					Case SybaseServerVersion.SybaseASA
						comboSqlDialect.SelectedItem = "Sybase SQL Anywhere"
						Exit Select
					Case Else
						comboSqlDialect.SelectedItem = "Sybase SQL Anywhere"
						Exit Select
				End Select
			ElseIf TypeOf _sqlContext.SyntaxProvider Is TeradataSyntaxProvider Then
				comboSqlDialect.SelectedItem = "Teradata"
			ElseIf TypeOf _sqlContext.SyntaxProvider Is VistaDBSyntaxProvider Then
				comboSqlDialect.SelectedItem = "VistaDB"
			End If

			If TypeOf _sqlContext.SyntaxProvider Is GenericSyntaxProvider Then
				comboSqlDialect.SelectedItem = "Generic"
			End If

			If _sqlContext.SyntaxProvider IsNot Nothing Then
				comboIdentCaseSens.SelectedIndex = CInt(_sqlContext.SyntaxProvider.IdentCaseSens)
				textBeginQuotationSymbol.Text = _sqlContext.SyntaxProvider.QuoteBegin
				textEndQuotationSymbol.Text = _sqlContext.SyntaxProvider.QuoteEnd
			End If

			cbQuoteAllIdentifiers.Checked = _sqlContext.SQLGenerationOptionsForServer.QuoteIdentifiers = IdentQuotation.All

			AddHandler comboSqlDialect.SelectedIndexChanged, AddressOf comboSqlDialect_SelectedIndexChanged
			AddHandler comboIdentCaseSens.SelectedIndexChanged, AddressOf comboIdentCaseSens_SelectedIndexChanged
			AddHandler cbQuoteAllIdentifiers.CheckedChanged, AddressOf checkQuoteAllIdentifiers_CheckedChanged
		End Sub

		Protected Overrides Sub Dispose(disposing As Boolean)
			RemoveHandler comboSqlDialect.SelectedIndexChanged, AddressOf comboSqlDialect_SelectedIndexChanged
			RemoveHandler comboIdentCaseSens.SelectedIndexChanged, AddressOf comboIdentCaseSens_SelectedIndexChanged
			RemoveHandler cbQuoteAllIdentifiers.CheckedChanged, AddressOf checkQuoteAllIdentifiers_CheckedChanged

			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If

			MyBase.Dispose(disposing)
		End Sub

		Private Sub comboSqlDialect_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim syntaxProvider As BaseSyntaxProvider

			Select Case TryCast(comboSqlDialect.SelectedItem, String)
				Case "ANSI SQL-92"
					syntaxProvider = New SQL92SyntaxProvider()
					Exit Select
				Case "Auto"
					syntaxProvider = New AutoSyntaxProvider()
					Exit Select
				Case "ANSI SQL-89"
					syntaxProvider = New SQL89SyntaxProvider()
					Exit Select
				Case "ANSI SQL-2003"
					syntaxProvider = New SQL2003SyntaxProvider()
					Exit Select
				Case "Firebird 1.0"
					syntaxProvider = New FirebirdSyntaxProvider() With { _
						.ServerVersion = FirebirdVersion.Firebird10 _
					}
					Exit Select
				Case "Firebird 1.5"
					syntaxProvider = New FirebirdSyntaxProvider() With { _
						.ServerVersion = FirebirdVersion.Firebird15 _
					}
					Exit Select
				Case "Firebird 2.0"
					syntaxProvider = New FirebirdSyntaxProvider() With { _
						.ServerVersion = FirebirdVersion.Firebird20 _
					}
					Exit Select
				Case "Firebird 2.5"
					syntaxProvider = New FirebirdSyntaxProvider() With { _
						.ServerVersion = FirebirdVersion.Firebird25 _
					}
					Exit Select
				Case "IBM DB2"
					syntaxProvider = New DB2SyntaxProvider()
					Exit Select
				Case "IBM Informix 8"
					syntaxProvider = New InformixSyntaxProvider() With { _
						.ServerVersion = InformixVersion.DS8 _
					}
					Exit Select
				Case "IBM Informix 9"
					syntaxProvider = New InformixSyntaxProvider() With { _
						.ServerVersion = InformixVersion.DS9 _
					}
					Exit Select
				Case "IBM Informix 10"
					syntaxProvider = New InformixSyntaxProvider() With { _
						.ServerVersion = InformixVersion.DS10 _
					}
					Exit Select
				Case "MS Access 97 (MS Jet 3.0)"
					syntaxProvider = New MSAccessSyntaxProvider() With { _
						.ServerVersion = MSAccessServerVersion.MSJET3 _
					}
					Exit Select
				Case "MS Access 2000 (MS Jet 4.0)", "MS Access XP (MS Jet 4.0)", "MS Access 2003 (MS Jet 4.0)"
					syntaxProvider = New MSAccessSyntaxProvider() With { _
						.ServerVersion = MSAccessServerVersion.MSJET4 _
					}
					Exit Select
				Case "MS SQL Server 7"
					syntaxProvider = New MSSQLSyntaxProvider() With { _
						.ServerVersion = MSSQLServerVersion.MSSQL7 _
					}
					Exit Select
				Case "MS SQL Server 2000"
					syntaxProvider = New MSSQLSyntaxProvider() With { _
						.ServerVersion = MSSQLServerVersion.MSSQL2000 _
					}
					Exit Select
				Case "MS SQL Server 2005"
					syntaxProvider = New MSSQLSyntaxProvider() With { _
						.ServerVersion = MSSQLServerVersion.MSSQL2005 _
					}
					Exit Select
				Case "MS SQL Server 2008"
					syntaxProvider = New MSSQLSyntaxProvider() With { _
						.ServerVersion = MSSQLServerVersion.MSSQL2008 _
					}
					Exit Select
				Case "MS SQL Server 2012"
					syntaxProvider = New MSSQLSyntaxProvider() With { _
						.ServerVersion = MSSQLServerVersion.MSSQL2012 _
					}
					Exit Select
				Case "MS SQL Server 2014"
					syntaxProvider = New MSSQLSyntaxProvider() With { _
						.ServerVersion = MSSQLServerVersion.MSSQL2014 _
					}
					Exit Select
				Case "MS SQL Server Compact Edition"
					syntaxProvider = New MSSQLCESyntaxProvider()
					Exit Select
				Case "MySQL 3.xx"
					syntaxProvider = New MySQLSyntaxProvider() With { _
						.ServerVersionInt = 39999 _
					}
					Exit Select
				Case "MySQL 4.0"
					syntaxProvider = New MySQLSyntaxProvider() With { _
						.ServerVersionInt = 40099 _
					}
					Exit Select
				Case "MySQL 4.1"
					syntaxProvider = New MySQLSyntaxProvider() With { _
						.ServerVersionInt = 49999 _
					}
					Exit Select
				Case "MySQL 5.0"
					syntaxProvider = New MySQLSyntaxProvider() With { _
						.ServerVersionInt = 50000 _
					}
					Exit Select
				Case "Oracle 7"
					syntaxProvider = New OracleSyntaxProvider() With { _
						.ServerVersion = OracleServerVersion.Oracle7 _
					}
					Exit Select
				Case "Oracle 8"
					syntaxProvider = New OracleSyntaxProvider() With { _
						.ServerVersion = OracleServerVersion.Oracle8 _
					}
					Exit Select
				Case "Oracle 9"
					syntaxProvider = New OracleSyntaxProvider() With { _
						.ServerVersion = OracleServerVersion.Oracle9 _
					}
					Exit Select
				Case "Oracle 10"
					syntaxProvider = New OracleSyntaxProvider() With { _
						.ServerVersion = OracleServerVersion.Oracle10 _
					}
					Exit Select
				Case "Oracle 11"
					syntaxProvider = New OracleSyntaxProvider() With { _
						.ServerVersion = OracleServerVersion.Oracle11 _
					}
					Exit Select
				Case "PostgreSQL"
					syntaxProvider = New PostgreSQLSyntaxProvider()
					Exit Select
				Case "SQLite"
					syntaxProvider = New SQLiteSyntaxProvider()
					Exit Select
				Case "Sybase ASE"
					syntaxProvider = New SybaseSyntaxProvider() With { _
						.ServerVersion = SybaseServerVersion.SybaseASE _
					}
					Exit Select
				Case "Sybase SQL Anywhere"
					syntaxProvider = New SybaseSyntaxProvider() With { _
						.ServerVersion = SybaseServerVersion.SybaseASA _
					}
					Exit Select
				Case "Teradata"
					syntaxProvider = New TeradataSyntaxProvider()
					Exit Select
				Case "VistaDB"
					syntaxProvider = New VistaDBSyntaxProvider()
					Exit Select
				Case "Generic"
					syntaxProvider = New GenericSyntaxProvider()
					DirectCast(syntaxProvider, GenericSyntaxProvider).RedetectServer(_sqlContext)
					Exit Select
				Case Else
					syntaxProvider = New GenericSyntaxProvider()
					Exit Select
			End Select

			Dim oldSyntaxProvider = _sqlContext.SyntaxProvider
			_sqlContext.SyntaxProvider = syntaxProvider

			If oldSyntaxProvider IsNot Nothing Then
				oldSyntaxProvider.Dispose()
			End If

			' update IdentCaseSens flag
			comboIdentCaseSens.SelectedIndex = CInt(_sqlContext.SyntaxProvider.IdentCaseSens)
			' update quotation symbols
			textBeginQuotationSymbol.Text = _sqlContext.SyntaxProvider.QuoteBegin
			textEndQuotationSymbol.Text = _sqlContext.SyntaxProvider.QuoteEnd
		End Sub

		Private Sub comboIdentCaseSens_SelectedIndexChanged(sender As Object, e As EventArgs)
			_sqlContext.SyntaxProvider.IdentCaseSens = CType(comboIdentCaseSens.SelectedIndex, IdentCaseSensitivity)
			comboIdentCaseSens.SelectedIndex = CInt(_sqlContext.SyntaxProvider.IdentCaseSens)
		End Sub

		Private Sub checkQuoteAllIdentifiers_CheckedChanged(sender As Object, e As EventArgs)
			_sqlContext.SQLGenerationOptionsForServer.QuoteIdentifiers = If(cbQuoteAllIdentifiers.Checked, IdentQuotation.All, IdentQuotation.IfNeed)
		End Sub
	End Class
End Namespace
