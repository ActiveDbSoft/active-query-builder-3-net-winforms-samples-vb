'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Text
Imports ActiveQueryBuilder.Core


Partial Public Class Form1
    Private Sub DumpDataSourceInfo(stringBuilder As StringBuilder, dataSource As DataSource)
        ' write full sql fragment
        stringBuilder.AppendLine(dataSource.GetResultSQL())

        ' write alias
        stringBuilder.AppendLine("  alias: " & dataSource.Alias)

        ' write referenced MetadataObject (if any)
        If dataSource.MetadataObject IsNot Nothing Then
            stringBuilder.AppendLine("  ref: " & dataSource.MetadataObject.Name)
        End If

        ' write subquery (if datasource is actually a derived table)
        Dim dataSourceQuery = TryCast(dataSource, DataSourceQuery)
        If dataSourceQuery IsNot Nothing Then
            stringBuilder.AppendLine("  subquery sql: " & dataSourceQuery.GetResultSQL())
        End If

        ' write fields
        Dim fields = New StringBuilder()

        For Each field In dataSource.Metadata.Fields
            If fields.Length > 0 Then
                fields.Append(", ")
            End If

            fields.Append(field.Name)
        Next field

        stringBuilder.AppendLine("  fields (" & dataSource.Metadata.Count & "): " & fields.ToString())
    End Sub

    Private Sub DumpDataSourcesInfo(stringBuilder As StringBuilder, dataSources As IEnumerable(Of DataSource))
        For Each dataSource In dataSources
            If stringBuilder.Length > 0 Then
                stringBuilder.AppendLine()
            End If

            DumpDataSourceInfo(stringBuilder, dataSource)
        Next dataSource
    End Sub

    Public Sub DumpDataSourcesInfoFromUnionSubQuery(stringBuilder As StringBuilder, unionSubQuery As UnionSubQuery)
        Dim datasources = unionSubQuery.GetChildrenRecursive(Of DataSource)(False)
        DumpDataSourcesInfo(stringBuilder, datasources)
    End Sub
End Class
