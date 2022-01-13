''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2022 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Collections
Imports System.Text
Imports ActiveQueryBuilder.Core


Partial Public Class Form1
    Private Sub DumpUnionGroupInfo(stringBuilder As StringBuilder, indent As String, unionGroup As UnionGroup)
        For Each child As QueryBase In unionGroup.Items
            If stringBuilder.Length > 0 Then
                stringBuilder.AppendLine()
            End If

            If TypeOf child Is UnionSubQuery Then
                ' UnionSubQuery is a leaf node of query structure.
                ' It represent a single SELECT statement in the tree of unions
                DumpUnionSubQueryInfo(stringBuilder, indent, CType(child, UnionSubQuery))
            Else
                ' UnionGroup is a tree node.
                ' It contains one or more leafs of other tree nodes.
                ' It represent a root of the subquery of the union tree or a
                ' parentheses in the union tree.
                Debug.Assert(TypeOf child Is UnionGroup)

                unionGroup = CType(child, UnionGroup)

                stringBuilder.AppendLine(indent & unionGroup.UnionOperatorFull & "group: [")
                DumpUnionGroupInfo(stringBuilder, indent & "    ", unionGroup)
                stringBuilder.AppendLine(indent & "]")
            End If
        Next child
    End Sub

    Private Sub DumpUnionSubQueryInfo(stringBuilder As StringBuilder, indent As String, unionSubQuery As UnionSubQuery)
        Dim sql As String = unionSubQuery.GetResultSQL()

        stringBuilder.AppendLine(indent & unionSubQuery.UnionOperatorFull & ": " & sql)
    End Sub

    Public Sub DumpQueryStructureInfo(stringBuilder As StringBuilder, subQuery As SubQuery)
        DumpUnionGroupInfo(stringBuilder, "", subQuery)
    End Sub
End Class
