'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Collections
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports ActiveQueryBuilder.Core
Imports XmlSerializer = ActiveQueryBuilder.Core.Serialization.XmlSerializer

Public Enum ConnectionTypes
	MSSQL
	MSSQLCE
	MSSQLAzure
	MSAccess
	Oracle
	MySQL
	PostgreSQL
	OLEDB
	ODBC
	SQLite	
	Firebird
	Excel
End Enum

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

<Serializable> _
<XmlInclude(GetType(ConnectionInfo))> _
Public Class ConnectionList
	<XmlElement(Type := GetType(ConnectionInfo))> _
	Private _connections As New ArrayList()

	Public Sub SaveData()
		Dim xmlSerializer = New XmlSerializer()
		For Each connection As ConnectionInfo In _connections
			connection.ConnectionString = connection.ConnectionDescriptor.ConnectionString
			connection.LoadingOptions = xmlSerializer.Serialize(connection.ConnectionDescriptor.MetadataLoadingOptions)
			connection.SyntaxProviderState = xmlSerializer.SerializeObject(connection.ConnectionDescriptor.SyntaxProvider)
		Next
	End Sub

	Public Sub RemoveObsoleteConnectionInfos()
		Dim connectionsToRemove = New List(Of ConnectionInfo)()

		For Each connection As ConnectionInfo In _connections
			If connection.ConnectionDescriptor Is Nothing Then
				connectionsToRemove.Add(connection)
			End If
		Next

		For Each connection As ConnectionInfo In connectionsToRemove
			_connections.Remove(connection)
		Next
	End Sub

	Public Sub RestoreData()
		Dim xmlSerializer = New XmlSerializer()

		For Each connection As ConnectionInfo In _connections
			If connection.ConnectionDescriptor Is Nothing Then
				Continue For
			End If

            Try
    			connection.ConnectionDescriptor.ConnectionString = connection.ConnectionString
            Catch

            End Try

			If Not String.IsNullOrEmpty(connection.LoadingOptions) Then
				xmlSerializer.Deserialize(connection.LoadingOptions, connection.ConnectionDescriptor.MetadataLoadingOptions)
			End If

			If Not String.IsNullOrEmpty(connection.SyntaxProviderName) AndAlso connection.IsGenericConnection() Then
				connection.ConnectionDescriptor.SyntaxProvider = ConnectionInfo.GetSyntaxByName(connection.SyntaxProviderName)
			End If

			If Not String.IsNullOrEmpty(connection.SyntaxProviderState) Then
				xmlSerializer.DeserializeObject(connection.SyntaxProviderState, connection.ConnectionDescriptor.SyntaxProvider)
			End If
		Next
	End Sub

	Public Default ReadOnly Property Item(index As Integer) As ConnectionInfo
		Get
			Return DirectCast(_connections(index), ConnectionInfo)
		End Get
	End Property

	Public ReadOnly Property Count() As Integer
		Get
			Return _connections.Count
		End Get
	End Property

	Public Property Connections() As System.Collections.ArrayList
		Get
			Return _connections
		End Get
		Set
			_connections = value
		End Set
	End Property

	Public Sub Add(ci As ConnectionInfo)
		_connections.Add(ci)
	End Sub

	Public Sub Insert(index As Integer, ci As ConnectionInfo)
		_connections.Insert(index, ci)
	End Sub

	Public Sub Remove(ci As ConnectionInfo)
		_connections.Remove(ci)
	End Sub
End Class

<Serializable> _
Public Class ConnectionInfo
	Public Property Name() As String
		Get
			Return m_Name
		End Get
		Set
			m_Name = Value
		End Set
	End Property
	Private m_Name As String
	<XmlIgnore> _
	Public Property ConnectionDescriptor() As BaseConnectionDescriptor
		Get
			Return m_ConnectionDescriptor
		End Get
		Set
			m_ConnectionDescriptor = Value
		End Set
	End Property
	Private m_ConnectionDescriptor As BaseConnectionDescriptor
	Public Property ConnectionString() As String
		Get
			Return m_ConnectionString
		End Get
		Set
			m_ConnectionString = Value
		End Set
	End Property
	Private m_ConnectionString As String
	Public Property IsXmlFile() As Boolean
		Get
			Return m_IsXmlFile
		End Get
		Set
			m_IsXmlFile = Value
		End Set
	End Property
	Private m_IsXmlFile As Boolean
	Public Property XMLPath() As String
		Get
			Return m_XMLPath
		End Get
		Set
			m_XMLPath = Value
		End Set
	End Property
	Private m_XMLPath As String
	Public Property CacheFile() As String
		Get
			Return m_CacheFile
		End Get
		Set
			m_CacheFile = Value
		End Set
	End Property
	Private m_CacheFile As String
	Public Property UserQueries() As String
		Get
			Return m_UserQueries
		End Get
		Set
			m_UserQueries = Value
		End Set
	End Property
	Private m_UserQueries As String
	Public Property MetadataStructure() As String
		Get
			Return m_MetadataStructure
		End Get
		Set
			m_MetadataStructure = Value
		End Set
	End Property
	Private m_MetadataStructure As String
	Public Property LoadingOptions() As String
		Get
			Return m_LoadingOptions
		End Get
		Set
			m_LoadingOptions = Value
		End Set
	End Property
	Private m_LoadingOptions As String
	Public Property SyntaxProviderState() As String
		Get
			Return m_SyntaxProviderState
		End Get
		Set
			m_SyntaxProviderState = Value
		End Set
	End Property
	Private m_SyntaxProviderState As String
	Public Property SyntaxProviderName() As String
		Get
			Return m_SyntaxProviderName
		End Get
		Set
			m_SyntaxProviderName = Value
		End Set
	End Property
	Private m_SyntaxProviderName As String

	Public Function IsGenericConnection() As Boolean
		Return TypeOf ConnectionDescriptor Is OLEDBConnectionDescriptor OrElse TypeOf ConnectionDescriptor Is ODBCConnectionDescriptor
	End Function

	Public Shared Function GetSyntaxByName(name As String) As BaseSyntaxProvider
		For Each syntax As Type In Helpers.SyntaxProviderList
			If syntax.ToString() = name Then
				Return TryCast(Activator.CreateInstance(syntax), BaseSyntaxProvider)
			End If
		Next

		Return Nothing
	End Function

	Private _type As ConnectionTypes = ConnectionTypes.MSSQL

	Public Property Type() As ConnectionTypes
		Get
			Return _type
		End Get
		Set
			_type = value
			CreateConnectionByType()

			If Not String.IsNullOrEmpty(SyntaxProviderName) AndAlso IsGenericConnection() Then
				ConnectionDescriptor.SyntaxProvider = GetSyntaxByName(SyntaxProviderName)
			End If
		End Set
	End Property

	Public Sub New(descriptor As BaseConnectionDescriptor, name__1 As String, type__2 As ConnectionTypes, connectionString__3 As String)
		Name = name__1
		ConnectionDescriptor = descriptor
		Type = type__2
		ConnectionString = connectionString__3
		IsXmlFile = False
		ConnectionDescriptor.ConnectionString = connectionString__3
	End Sub

	Public Sub New(xmlPath__1 As String, name__2 As String, type__3 As ConnectionTypes)
		Name = name__2
		XMLPath = xmlPath__1
		Type = type__3
		IsXmlFile = True
		CreateConnectionByType()
	End Sub

	Public Sub New()
	End Sub

	Private Sub CreateConnectionByType()
		Select Case Type
			Case ConnectionTypes.MSAccess
				ConnectionDescriptor = New MSAccessConnectionDescriptor()
				Return
			Case ConnectionTypes.MSSQL
				ConnectionDescriptor = New MSSQLConnectionDescriptor()
				Return
			Case ConnectionTypes.MSSQLCE
				ConnectionDescriptor = New MSSQLCEConnectionDescriptor()
				Return
			Case ConnectionTypes.MSSQLAzure
				ConnectionDescriptor = New MSSQLAzureConnectionDescriptor()
				Return
			Case ConnectionTypes.MySQL
				ConnectionDescriptor = New MySQLConnectionDescriptor()
				Return
			Case ConnectionTypes.Oracle
				ConnectionDescriptor = New OracleNativeConnectionDescriptor()
				Return
			Case ConnectionTypes.PostgreSQL
				ConnectionDescriptor = New PostgreSQLConnectionDescriptor()
				Return
			Case ConnectionTypes.ODBC
				ConnectionDescriptor = New ODBCConnectionDescriptor()
				Return
			Case ConnectionTypes.OLEDB
				ConnectionDescriptor = New OLEDBConnectionDescriptor()
				Return
			Case ConnectionTypes.Firebird
				ConnectionDescriptor = New FirebirdConnectionDescriptor()
				Return
			Case ConnectionTypes.SQLite
				ConnectionDescriptor = New SQLiteConnectionDescriptor()
				Return
			Case ConnectionTypes.Excel
				ConnectionDescriptor = New ExcelConnectionDescriptor()
				Return				
		End Select
	End Sub

	Public Function GetConnectionType(descriptorType As Type) As ConnectionTypes
		If descriptorType Is GetType(MSAccessConnectionDescriptor) Then
			Return ConnectionTypes.MSAccess
		End If
		If descriptorType Is GetType(MSSQLConnectionDescriptor) Then
			Return ConnectionTypes.MSSQL
		End If
		If descriptorType Is GetType(MSSQLCEConnectionDescriptor) Then
			Return ConnectionTypes.MSSQLCE
		End If
		If descriptorType Is GetType(MSSQLAzureConnectionDescriptor) Then
			Return ConnectionTypes.MSSQLAzure
		End If
		If descriptorType Is GetType(MySQLConnectionDescriptor) Then
			Return ConnectionTypes.MySQL
		End If
		If descriptorType Is GetType(OracleNativeConnectionDescriptor) Then
			Return ConnectionTypes.Oracle
		End If
		If descriptorType Is GetType(ODBCConnectionDescriptor) Then
			Return ConnectionTypes.ODBC
		End If
		If descriptorType Is GetType(OLEDBConnectionDescriptor) Then
			Return ConnectionTypes.OLEDB
		End If
		If descriptorType Is GetType(FirebirdConnectionDescriptor) Then
			Return ConnectionTypes.Firebird
		End If
		If descriptorType Is GetType(SQLiteConnectionDescriptor) Then
			Return ConnectionTypes.SQLite
		End If
		If descriptorType Is GetType(ExcelConnectionDescriptor) Then
			Return ConnectionTypes.Excel
		End If
		If descriptorType Is GetType(PostgreSQLConnectionDescriptor) Then
			Return ConnectionTypes.PostgreSQL
		End If
		
		Return ConnectionTypes.MSSQL
	End Function

	Public Overrides Function Equals(obj As [Object]) As Boolean
		If obj IsNot Nothing AndAlso TypeOf obj Is ConnectionInfo Then
			If DirectCast(obj, ConnectionInfo).Type = Me.Type AndAlso DirectCast(obj, ConnectionInfo).Name = Me.Name AndAlso DirectCast(obj, ConnectionInfo).ConnectionString = Me.ConnectionString AndAlso DirectCast(obj, ConnectionInfo).IsXmlFile = Me.IsXmlFile Then
				Return True
			End If
		End If

		Return False
	End Function

	Public Overrides Function GetHashCode() As Integer
		Return MyBase.GetHashCode()
	End Function
End Class
