''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2022 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core

Namespace ConsolidatedMetadataContainer
    Public Partial Class Form1
        Inherits Form

        ' list of connections, name -> innerContext
        Private ReadOnly _connections As Dictionary(Of String, SQLContext) = InitConnections()


        ' fill connections dictionary
        Private Shared Function InitConnections() As Dictionary(Of String, SQLContext)
            Dim result = New Dictionary(Of String, SQLContext)()

            ' first connection
            Dim innerXml = New SQLContext With {
                .SyntaxProvider = New MSSQLSyntaxProvider()
            }
            innerXml.MetadataContainer.ImportFromXML("northwind.xml")
            result.Add("xml", innerXml)

            ' second connection
            Dim innerMsSql = New SQLContext With {
                .SyntaxProvider = New MSSQLSyntaxProvider(),
                .MetadataProvider = New MSSQLMetadataProvider With {
                    .Connection = New SqlConnection("Server=sql2014;Database=AdventureWorks;User Id=sa;Password=********;")
                }
            }
            result.Add("live", innerMsSql)
            Return result
        End Function

        Public Sub New()
            InitializeComponent()

            ' sql editing events
            AddHandler queryBuilder.SQLUpdated, AddressOf QueryBuilderOnSqlUpdated
            AddHandler textSql.Validating, AddressOf TextSqlOnValidating

            ' add connections
            Dim metadataContainer = queryBuilder.MetadataContainer

            For Each connectionDescription In _connections
                Dim connectionName = connectionDescription.Key
                Dim innerContext = connectionDescription.Value
                metadataContainer.AddConnection(connectionName, innerContext)
            Next

            ' init metadata tree
            queryBuilder.InitializeDatabaseSchemaTree()
        End Sub

        Private Sub TextSqlOnValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            queryBuilder.FormattedSQL = textSql.Text
        End Sub

        Private Sub QueryBuilderOnSqlUpdated(ByVal sender As Object, ByVal e As EventArgs)
            textSql.Text = queryBuilder.FormattedSQL
        End Sub

        Private Sub ButtonStats_Click(sender As Object, e As EventArgs) Handles ButtonStats.Click
            Dim result As new StringBuilder()

            ' collect all subQueries
            Dim subQueries = queryBuilder.SQLQuery.QueryRoot.GetChildrenRecursive(Of SubQuery)(true)
            ' process main query also
            subQueries.Insert(0, queryBuilder.SQLQuery.QueryRoot)

            ' OR collect unionSubQueries (single SELECT expressions)
            'Dim subQueries = queryBuilder.SQLQuery.QueryRoot.GetChildrenRecursive(Of UnionSubQuery)(true);

            For Each subQuery As SubQuery In subQueries
                result.AppendLine()
                result.AppendLine("subQuery: " + subQuery.SQL)
                ' collect all dataSources in this subQuery
                Dim dataSources = subQuery.GetChildrenRecursive(Of DataSourceObject)(false)

                For Each dataSource As DataSourceObject In dataSources
                    result.AppendLine(dataSource.NameInQuery)

                    Dim metadataObject = dataSource.MetadataObject

                    ' metadataObject will be null in 2 cases:
                    ' 1. dataSource is CTE reference
                    If Not (dataSource.SubQueryCTE Is Nothing)
                        result.AppendLine("    CTE reference")
                        Continue For
                    End If
                    ' 2. no object with such name in MetadataContainer
                    if metadataObject is Nothing
                        Using fullName = new SQLQualifiedName(queryBuilder.SQLContext)
                            fullName.Assign(dataSource.DatabaseObject)
                            result.AppendLine("    no such object in DB: " + fullName.GetSQL(queryBuilder.SQLGenerationOptions))
                        End Using

                        Continue For 
                    End If

                    result.AppendLine("    object name: " + metadataObject.GetQualifiedNameSQL(Nothing, queryBuilder.SQLGenerationOptions))
                    result.AppendLine("    connection: " + metadataObject.Connection.Name)
                Next
            Next

            MessageBox.Show(result.ToString())
        End Sub
    End Class
End Namespace
