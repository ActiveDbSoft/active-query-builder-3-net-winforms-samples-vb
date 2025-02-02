''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Text
Imports ActiveQueryBuilder.Core


Partial Public Class Form1
    Public Shared Sub DumpUsedObjectsInfo(stringBuilder As StringBuilder, usedObjects As StatisticsDatabaseObjectList)
        stringBuilder.AppendLine("Used Objects (" & usedObjects.Count & "):")

        For i As Integer = 0 To usedObjects.Count - 1
            stringBuilder.AppendLine(usedObjects(i).ObjectName.QualifiedName)
        Next i
    End Sub

    Public Shared Sub DumpUsedColumnsInfo(stringBuilder As StringBuilder, usedColumns As StatisticsFieldList)
        stringBuilder.AppendLine("Used Columns (" & usedColumns.Count & "):")

        For i As Integer = 0 To usedColumns.Count - 1
            stringBuilder.AppendLine(usedColumns(i).ObjectName.QualifiedName)
        Next i
    End Sub

    Public Shared Sub DumpOutputExpressionsInfo(stringBuilder As StringBuilder, outputExpressions As StatisticsOutputColumnList)
        stringBuilder.AppendLine("Output Expressions (" & outputExpressions.Count & "):")

        For i As Integer = 0 To outputExpressions.Count - 1
            stringBuilder.AppendLine(outputExpressions(i).Expression)
        Next i
    End Sub

    Public Shared Sub DumpQueryStatisticsInfo(stringBuilder As StringBuilder, queryStatistics As QueryStatistics)
        DumpUsedObjectsInfo(stringBuilder, queryStatistics.UsedDatabaseObjects)

        stringBuilder.AppendLine()
        DumpUsedColumnsInfo(stringBuilder, queryStatistics.UsedDatabaseObjectFields)

        stringBuilder.AppendLine()
        DumpOutputExpressionsInfo(stringBuilder, queryStatistics.OutputColumns)
    End Sub
End Class
