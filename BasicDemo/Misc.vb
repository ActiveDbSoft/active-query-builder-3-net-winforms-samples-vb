'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Collections.Generic
Imports ActiveQueryBuilder.Core

Public Module Misc
    Public ReadOnly ConnectionDescriptorList As List(Of Type) = New List(Of Type) From {
        GetType(MSAccessConnectionDescriptor),
        GetType(ExcelConnectionDescriptor),
        GetType(MSSQLConnectionDescriptor),
        GetType(MSSQLCEConnectionDescriptor),
        GetType(MSSQLAzureConnectionDescriptor),
        GetType(MySQLConnectionDescriptor),
        GetType(OracleNativeConnectionDescriptor),
        GetType(PostgreSQLConnectionDescriptor),
        GetType(ODBCConnectionDescriptor),
        GetType(OLEDBConnectionDescriptor),
        GetType(SQLiteConnectionDescriptor),
        GetType(FirebirdConnectionDescriptor)
        }
    Public ReadOnly ConnectionDescriptorNames As List(Of String) = New List(Of String) From {
        "MS Access",
        "Excel",
        "MS SQL Server",
        "MS SQL Server Compact Edition",
        "MS SQL Server Azure",
        "MySQL",
        "Oracle Native",
        "PostgreSQL",
        "Generic ODBC Connection",
        "Generic OLEDB Connection",
        "SQLite",
        "Firebird"
        }
End Module
