'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
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
    End Class
End Namespace
