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


Partial Public Class Form1
    Private Sub DumpLinkInfo(stringBuilder As StringBuilder, link As Link)
        ' write full sql fragment of link expression
        stringBuilder.AppendLine(link.LinkExpression.GetSQL(link.SQLContext.SQLGenerationOptionsForServer))

        ' write information about left side of link
        stringBuilder.AppendLine("  left datasource: " & link.LeftDataSource.GetResultSQL())
        stringBuilder.AppendLine(If(link.LeftType = LinkSideType.Inner, "  left type: Inner", "  left type: Outer"))

        ' write information about right side of link
        stringBuilder.AppendLine("  right datasource: " & link.RightDataSource.GetResultSQL())
        stringBuilder.AppendLine(If(link.RightType = LinkSideType.Inner, "  right type: Inner", "  right type: Outer"))
    End Sub

    Private Sub DumpLinksInfo(stringBuilder As StringBuilder, links As IList(Of Link))
        For Each link In links
            ' append separator
            If stringBuilder.Length > 0 Then
                stringBuilder.AppendLine()
            End If

            DumpLinkInfo(stringBuilder, link)
        Next link
    End Sub

    Public Sub DumpLinksInfoFromUnionSubQuery(stringBuilder As StringBuilder, unionSubQuery As UnionSubQuery)
        Dim links = unionSubQuery.GetChildrenRecursive(Of Link)(False)
        DumpLinksInfo(stringBuilder, links)
    End Sub
End Class
