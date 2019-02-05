'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Collections.Generic
Imports System.Text
Imports ActiveQueryBuilder.Core

Partial Class Form1
	Private Function GetDataSourceList(unionSubQuery As UnionSubQuery) As List(Of DataSource)
		Dim list = New List(Of DataSource)()

		unionSubQuery.FromClause.GetDatasourceByClass(list)

		Return list
	End Function

	Private Sub DumpDataSourceInfo(stringBuilder As StringBuilder, dataSource As DataSource)
		' write full sql fragment
		stringBuilder.AppendLine(dataSource.GetResultSQL())

		' write alias
		stringBuilder.AppendLine("  alias: " & Convert.ToString(dataSource.[Alias]))

		' write referenced MetadataObject (if any)
		If dataSource.MetadataObject IsNot Nothing Then
			stringBuilder.AppendLine("  ref: " & Convert.ToString(dataSource.MetadataObject.Name))
		End If

		' write subquery (if datasource is actually a derived table)
		If TypeOf dataSource Is DataSourceQuery Then
			stringBuilder.AppendLine("  subquery sql: " & DirectCast(dataSource, DataSourceQuery).GetResultSQL())
		End If

		' write fields
		Dim fields As String = [String].Empty

		For i As Integer = 0 To dataSource.Metadata.Count - 1
			If fields.Length > 0 Then
				fields += ", "
			End If

			fields += dataSource.Metadata(i).Name
		Next

		stringBuilder.AppendLine("  fields (" & Convert.ToString(dataSource.Metadata.Count) & "): " & fields)
	End Sub

	Private Sub DumpDataSourcesInfo(stringBuilder As StringBuilder, dataSources As List(Of DataSource))
		For i As Integer = 0 To dataSources.Count - 1
			If stringBuilder.Length > 0 Then
				stringBuilder.AppendLine()
			End If

			DumpDataSourceInfo(stringBuilder, dataSources(i))
		Next
	End Sub

	Public Sub DumpDataSourcesInfoFromUnionSubQuery(stringBuilder As StringBuilder, unionSubQuery As UnionSubQuery)
		DumpDataSourcesInfo(stringBuilder, GetDataSourceList(unionSubQuery))
	End Sub
End Class
