''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2024 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Text
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms


Partial Public Class Form1
    Private Sub DumpSubQueryInfo(stringBuilder As StringBuilder, index As Integer, subQuery As SubQuery)
        Dim sql As String = subQuery.GetResultSQL()

        stringBuilder.AppendLine(index & ": " & sql)
    End Sub

    Public Sub DumpSubQueriesInfo(stringBuilder As StringBuilder, queryBuilder As QueryBuilder)
        For i As Integer = 0 To queryBuilder.ActiveUnionSubQuery.QueryRoot.SubQueryCount - 1
            If stringBuilder.Length > 0 Then
                stringBuilder.AppendLine()
            End If

            DumpSubQueryInfo(stringBuilder, i, queryBuilder.ActiveUnionSubQuery.QueryRoot.SubQueries(i))
            DumpSubQueryStatistics(stringBuilder, queryBuilder.ActiveUnionSubQuery.QueryRoot.SubQueries(i))
        Next i
    End Sub

    Private Sub DumpSubQueryStatistics(stringBuilder As StringBuilder, subQuery As SubQuery)
        stringBuilder.AppendLine()
        stringBuilder.AppendLine("Subquery statistic:")
        Form1.DumpQueryStatisticsInfo(stringBuilder, subQuery.QueryStatistics)
    End Sub
End Class
