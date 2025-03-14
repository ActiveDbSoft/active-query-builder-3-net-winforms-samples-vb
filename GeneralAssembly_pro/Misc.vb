''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports XmlSerializer = ActiveQueryBuilder.Core.Serialization.XmlSerializer
Imports GeneralAssembly.DataViewerControl

Public Class Misc
    Public Shared ReadOnly ParamsCache As List(Of DataViewer.ParameterInfo) = New List(Of DataViewer.ParameterInfo)()

    Public Shared Sub ClearParamsCache()
        ParamsCache.Clear()
    End Sub

    Private Shared Sub SaveParamsToCache(command As DbCommand)
        ClearParamsCache()

        For Each parameter As DbParameter In command.Parameters
            If parameter.Value IsNot Nothing Then ParamsCache.Add(New DataViewer.ParameterInfo With {
                .Name = parameter.ParameterName,
                .DataType = parameter.DbType,
                .Value = parameter.Value
            })
        Next
    End Sub

    Private Shared Function ApplyParamsFromCache(command As DbCommand, query As SQLQuery) As Boolean
        Dim result = True

        For Each parameter In query.QueryParameters
            Dim cached = ParamsCache.FirstOrDefault(Function(x) x.Name = parameter.FullName AndAlso x.DataType = parameter.DataType)
            Dim param = command.CreateParameter()
            param.ParameterName = parameter.FullName
            param.DbType = parameter.DataType

            If cached IsNot Nothing Then
                param.Value = cached.Value
            Else
                result = False
            End If

            command.Parameters.Add(param)
        Next

        Return result
    End Function

    Public Shared ReadOnly ConnectionDescriptorList As List(Of Type) = New List(Of Type) From {
        GetType(MSAccessConnectionDescriptor),
        GetType(ExcelConnectionDescriptor),
        GetType(MSSQLConnectionDescriptor),
        GetType(MSSQLAzureConnectionDescriptor),
        GetType(MySQLConnectionDescriptor),
        GetType(OracleNativeConnectionDescriptor),
        GetType(PostgreSQLConnectionDescriptor),
        GetType(ODBCConnectionDescriptor),
        GetType(OLEDBConnectionDescriptor),
        GetType(SQLiteConnectionDescriptor),
        GetType(FirebirdConnectionDescriptor),
        GetType(VistaDB5ConnectionDescriptor),
        GetType(DB2ConnectionDescriptor),
        GetType(AdvantageConnectionDescriptor),
        GetType(SybaseConnectionDescriptor),
        GetType(InformixConnectionDescriptor)
    }

    Public Shared ReadOnly ConnectionDescriptorNames As List(Of String) = New List(Of String) From {
        "MS Access",
        "Excel",
        "MS SQL Server",
        "MS SQL Server Azure",
        "MySQL",
        "Oracle Native",
        "PostgreSQL",
        "Generic ODBC Connection",
        "Generic OLEDB Connection",
        "SQLite",
        "Firebird",
        "VistaDB5",
        "DB2",
        "Advantage",
        "Sybase",
        "Informix"
    }
End Class

Public Enum ConnectionTypes
    MSAccess
    Excel
    MSSQL
    MSSQLAzure
    MySQL
    OracleNative
    PostgreSQL
    ODBC
    OLEDB
    SQLite
    Firebird
    VistaDB5
    DB2
    Advantage
    Sybase
    Informix
End Enum

<Serializable>
<XmlInclude(GetType(ConnectionInfo))>
Public Class ConnectionList
    <XmlElement(Type:=GetType(ConnectionInfo))>
    Private _connections As ArrayList = New ArrayList()

    Public Sub SaveData()
        Dim xmlSerializer = New XmlSerializer()

        For Each connection As ConnectionInfo In _connections
            connection.ConnectionString = connection.ConnectionDescriptor.ConnectionString
            connection.LoadingOptions = xmlSerializer.Serialize(connection.ConnectionDescriptor.MetadataLoadingOptions)
            connection.SyntaxProviderState = xmlSerializer.SerializeObject(connection.ConnectionDescriptor.SyntaxProvider)
            connection.StructureOptionsState = xmlSerializer.SerializeObject(connection.StructureOptions)
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
            If connection.ConnectionDescriptor Is Nothing Then Continue For
            connection.ConnectionDescriptor.ConnectionString = connection.ConnectionString

            If Not String.IsNullOrEmpty(connection.LoadingOptions) Then
                xmlSerializer.Deserialize(connection.LoadingOptions, connection.ConnectionDescriptor.MetadataLoadingOptions)
            End If

            If Not String.IsNullOrEmpty(connection.SyntaxProviderName) AndAlso connection.IsGenericConnection() Then
                connection.ConnectionDescriptor.SyntaxProvider = ConnectionInfo.GetSyntaxByName(connection.SyntaxProviderName)
            End If

            If Not String.IsNullOrEmpty(connection.SyntaxProviderState) Then
                xmlSerializer.DeserializeObject(connection.SyntaxProviderState, connection.ConnectionDescriptor.SyntaxProvider)
                connection.ConnectionDescriptor.RecreateSyntaxProperties()
            End If

            If Not String.IsNullOrEmpty(connection.StructureOptionsState) Then
                If connection.StructureOptions Is Nothing Then connection.StructureOptions = New MetadataStructureOptions()
                xmlSerializer.DeserializeObject(connection.StructureOptionsState, connection.StructureOptions)
            End If
        Next
    End Sub

    Default Public ReadOnly Property Item(index As Integer) As ConnectionInfo
        Get
            Return CType(_connections(index), ConnectionInfo)
        End Get
    End Property

    Public ReadOnly Property Count As Integer
        Get
            Return _connections.Count
        End Get
    End Property

    Public Property Connections As System.Collections.ArrayList
        Get
            Return _connections
        End Get
        Set(value As System.Collections.ArrayList)
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

<Serializable>
Public Class ConnectionInfo
    Public Property Name As String
    <XmlIgnore>
    Public Property ConnectionDescriptor As BaseConnectionDescriptor
    <XmlIgnore>
    Public Property StructureOptions As MetadataStructureOptions
    Public Property ConnectionString As String
    Public Property IsXmlFile As Boolean
    Public Property XMLPath As String
    Public Property CacheFile As String
    Public Property UserQueries As String
    Public Property MetadataStructure As String
    Public Property LoadingOptions As String
    Public Property StructureOptionsState As String
    Public Property SyntaxProviderState As String
    Public Property SyntaxProviderName As String

    Public Function IsGenericConnection() As Boolean
        Return TypeOf ConnectionDescriptor Is OLEDBConnectionDescriptor OrElse TypeOf ConnectionDescriptor Is ODBCConnectionDescriptor
    End Function

    Public Shared Function GetSyntaxByName(name As String) As BaseSyntaxProvider
        For Each syntax As Type In ActiveQueryBuilder.Core.Helpers.SyntaxProviderList

            If syntax.ToString() = name Then
                Return TryCast(Activator.CreateInstance(syntax), BaseSyntaxProvider)
            End If
        Next

        Return Nothing
    End Function

    Private _type As ConnectionTypes = ConnectionTypes.MSSQL

    Public Property Type As ConnectionTypes
        Get
            Return _type
        End Get
        Set
            _type = Value
            CreateConnectionByType()

            If Not String.IsNullOrEmpty(SyntaxProviderName) AndAlso IsGenericConnection() Then
                ConnectionDescriptor.SyntaxProvider = GetSyntaxByName(SyntaxProviderName)
            End If
        End Set
    End Property

    Public Sub New(descriptor As BaseConnectionDescriptor, name As String, typeConnection As ConnectionTypes, connectionString As String)
        Me.Name = name
        ConnectionDescriptor = descriptor
        Type = typeConnection
        connectionString = connectionString
        IsXmlFile = False
        ConnectionDescriptor.ConnectionString = connectionString
        StructureOptions = New MetadataStructureOptions() With {
            .AllowFavourites = True
        }
    End Sub

    Public Sub New(xmlPath As String, name As String, typeConnection As ConnectionTypes)
        Me.Name = name
        Me.XMLPath = xmlPath
        Type = typeConnection
        IsXmlFile = True
        StructureOptions = New MetadataStructureOptions With {
            .AllowFavourites = True
        }
        CreateConnectionByType()
    End Sub

    Public Sub New()
        StructureOptions = New MetadataStructureOptions With {
            .AllowFavourites = True
        }
    End Sub

    Private Sub CreateConnectionByType()
        Try

            Select Case Type
                Case ConnectionTypes.MSAccess
                    ConnectionDescriptor = New MSAccessConnectionDescriptor()
                    Return
                Case ConnectionTypes.MSSQL
                    ConnectionDescriptor = New MSSQLConnectionDescriptor()
                    Return
                Case ConnectionTypes.MSSQLAzure
                    ConnectionDescriptor = New MSSQLAzureConnectionDescriptor()
                    Return
                Case ConnectionTypes.MySQL
                    ConnectionDescriptor = New MySQLConnectionDescriptor()
                    Return
                Case ConnectionTypes.OracleNative
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
                Case ConnectionTypes.Advantage
                    ConnectionDescriptor = New AdvantageConnectionDescriptor()
                Case ConnectionTypes.Sybase
                    ConnectionDescriptor = New SybaseConnectionDescriptor()
                Case ConnectionTypes.VistaDB5
                    ConnectionDescriptor = New VistaDB5ConnectionDescriptor()
                Case ConnectionTypes.DB2
                    ConnectionDescriptor = New DB2ConnectionDescriptor()
                Case ConnectionTypes.Informix
                    ConnectionDescriptor = New InformixConnectionDescriptor()
                Case Else
                    Throw New ArgumentOutOfRangeException()
            End Select

        Catch
        End Try
    End Sub

    Public Function GetConnectionType(descriptorType As Type) As ConnectionTypes
        If descriptorType = GetType(MSAccessConnectionDescriptor) Then
            Return ConnectionTypes.MSAccess
        End If

        If descriptorType = GetType(ExcelConnectionDescriptor) Then
            Return ConnectionTypes.Excel
        End If

        If descriptorType = GetType(PostgreSQLConnectionDescriptor) Then
            Return ConnectionTypes.PostgreSQL
        End If

        If descriptorType = GetType(MSSQLConnectionDescriptor) Then
            Return ConnectionTypes.MSSQL
        End If

        If descriptorType = GetType(MSSQLAzureConnectionDescriptor) Then
            Return ConnectionTypes.MSSQLAzure
        End If

        If descriptorType = GetType(MySQLConnectionDescriptor) Then
            Return ConnectionTypes.MySQL
        End If

        If descriptorType = GetType(OracleNativeConnectionDescriptor) Then
            Return ConnectionTypes.OracleNative
        End If

        If descriptorType = GetType(ODBCConnectionDescriptor) Then
            Return ConnectionTypes.ODBC
        End If

        If descriptorType = GetType(OLEDBConnectionDescriptor) Then
            Return ConnectionTypes.OLEDB
        End If

        If descriptorType = GetType(FirebirdConnectionDescriptor) Then
            Return ConnectionTypes.Firebird
        End If

        If descriptorType = GetType(SQLiteConnectionDescriptor) Then
            Return ConnectionTypes.SQLite
        End If

        If descriptorType = GetType(AdvantageConnectionDescriptor) Then
            Return ConnectionTypes.Advantage
        End If

        If descriptorType = GetType(SybaseConnectionDescriptor) Then
            Return ConnectionTypes.Sybase
        End If

        If descriptorType = GetType(VistaDB5ConnectionDescriptor) Then
            Return ConnectionTypes.VistaDB5
        End If

        If descriptorType = GetType(DB2ConnectionDescriptor) Then
            Return ConnectionTypes.DB2
        End If

        If descriptorType = GetType(InformixConnectionDescriptor) Then
            Return ConnectionTypes.Informix
        End If

        Return ConnectionTypes.MSSQL
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If obj IsNot Nothing AndAlso TypeOf obj Is ConnectionInfo Then

            If (CType(obj, ConnectionInfo)).Type = Me.Type AndAlso (CType(obj, ConnectionInfo)).Name = Me.Name AndAlso (CType(obj, ConnectionInfo)).ConnectionString = Me.ConnectionString AndAlso (CType(obj, ConnectionInfo)).IsXmlFile = Me.IsXmlFile Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function
End Class
