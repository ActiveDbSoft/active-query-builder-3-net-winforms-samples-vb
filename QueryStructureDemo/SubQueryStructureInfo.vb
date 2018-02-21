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
Imports System.Diagnostics
Imports System.Text
Imports ActiveQueryBuilder.Core

Partial Class Form1
	Private Sub DumpUnionGroupInfo(stringBuilder As StringBuilder, indent As String, unionGroup As UnionGroup)
		Dim children As QueryBase() = GetUnionChildren(unionGroup)

		For Each child As QueryBase In children
			If stringBuilder.Length > 0 Then
				stringBuilder.AppendLine()
			End If

			If TypeOf child Is UnionSubQuery Then
				' UnionSubQuery is a leaf node of query structure.
				' It represent a single SELECT statement in the tree of unions
				DumpUnionSubQueryInfo(stringBuilder, indent, DirectCast(child, UnionSubQuery))
			Else
				' UnionGroup is a tree node.
				' It contains one or more leafs of other tree nodes.
				' It represent a root of the subquery of the union tree or a
				' parentheses in the union tree.
				Debug.Assert(TypeOf child Is UnionGroup)

				unionGroup = DirectCast(child, UnionGroup)

				stringBuilder.AppendLine(indent & Convert.ToString(unionGroup.UnionOperatorFull) & "group: [")
				DumpUnionGroupInfo(stringBuilder, indent & "    ", unionGroup)
				stringBuilder.AppendLine(indent & "]")
			End If
		Next
	End Sub

	Private Sub DumpUnionSubQueryInfo(stringBuilder As StringBuilder, indent As String, unionSubQuery As UnionSubQuery)
		Dim sql As String = unionSubQuery.GetResultSQL()

		stringBuilder.AppendLine(indent & Convert.ToString(unionSubQuery.UnionOperatorFull) & ": " & sql)
	End Sub

	Private Function GetUnionChildren(unionGroup As UnionGroup) As QueryBase()
		Dim result As New ArrayList()

		For i As Integer = 0 To unionGroup.Count - 1
			result.Add(unionGroup(i))
		Next

		Return DirectCast(result.ToArray(GetType(QueryBase)), QueryBase())
	End Function

	Public Sub DumpQueryStructureInfo(stringBuilder As StringBuilder, subQuery As SubQuery)
		DumpUnionGroupInfo(stringBuilder, "", subQuery)
	End Sub
End Class
