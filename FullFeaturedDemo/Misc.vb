'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Collections
Imports System.Xml.Serialization
Imports ActiveQueryBuilder.Core

Public Enum ConnectionTypes
	MSSQL
	MSAccess
	Oracle
	MySQL
	PostgreSQL
	OLEDB
	ODBC
End Enum

<Serializable> _
<XmlInclude(GetType(ConnectionInfo))> _
Public Class ConnectionList
	<XmlElement(Type := GetType(ConnectionInfo))> _
	Private _connections As New ArrayList()

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
	Private _syntaxProvider As BaseSyntaxProvider
	Public Property ConnectionType() As ConnectionTypes
		Get
			Return m_ConnectionType
		End Get
		Set
			m_ConnectionType = Value
		End Set
	End Property
	Private m_ConnectionType As ConnectionTypes
	Public Property ConnectionName() As String
		Get
			Return m_ConnectionName
		End Get
		Set
			m_ConnectionName = Value
		End Set
	End Property
	Private m_ConnectionName As String
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
	Public Property CacheFile() As String
		Get
			Return m_CacheFile
		End Get
		Set
			m_CacheFile = Value
		End Set
	End Property
	Private m_CacheFile As String
	Public Property SyntaxProviderName() As String
		Get
			Return m_SyntaxProviderName
		End Get
		Set
			m_SyntaxProviderName = Value
		End Set
	End Property
	Private m_SyntaxProviderName As String
	Public Property UserQueries() As String
		Get
			Return m_UserQueries
		End Get
		Set
			m_UserQueries = Value
		End Set
	End Property
	Private m_UserQueries As String

	<XmlIgnore> _
	Public Property SyntaxProvider() As BaseSyntaxProvider
		Get
			Return _syntaxProvider
		End Get
		Set
			_syntaxProvider = value
			If _syntaxProvider IsNot Nothing Then
				SyntaxProviderName = _syntaxProvider.ToString()
			End If
		End Set
	End Property

	Public Sub New()
		ConnectionType = ConnectionTypes.MSSQL
		ConnectionName = Nothing
		ConnectionString = Nothing
		IsXmlFile = False
		CacheFile = Nothing
	End Sub

	Public Sub New(connectionType__1 As ConnectionTypes, connectionName__2 As String, connectionString__3 As String, isFromXml As Boolean, cacheFile__4 As String, userQueriesXml As String)
		ConnectionType = connectionType__1
		ConnectionName = connectionName__2
		ConnectionString = connectionString__3
		IsXmlFile = isFromXml
		CacheFile = cacheFile__4
		UserQueries = userQueriesXml
	End Sub

	Public Overrides Function Equals(obj As System.Object) As Boolean
		If obj IsNot Nothing AndAlso TypeOf obj Is ConnectionInfo Then
			If DirectCast(obj, ConnectionInfo).ConnectionType = Me.ConnectionType AndAlso DirectCast(obj, ConnectionInfo).ConnectionName = Me.ConnectionName AndAlso DirectCast(obj, ConnectionInfo).ConnectionString = Me.ConnectionString AndAlso DirectCast(obj, ConnectionInfo).IsXmlFile = Me.IsXmlFile Then
				Return True
			End If
		End If

		Return False
	End Function

	Public Overrides Function GetHashCode() As Integer
		Return MyBase.GetHashCode()
	End Function
End Class

Public Class Misc
End Class
