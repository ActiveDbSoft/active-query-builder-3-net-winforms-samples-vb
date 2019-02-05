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
	Private Shared Function GetLinkList(unionSubQuery As UnionSubQuery) As List(Of Link)
		Dim links = New List(Of Link)()

		unionSubQuery.FromClause.GetLinksRecursive(links)

		Return links
	End Function

	Private Sub DumpLinkInfo(stringBuilder As StringBuilder, link As Link)
		' write full sql fragment of link expression
		stringBuilder.AppendLine(link.LinkExpression.GetSQL(link.SQLContext.SQLGenerationOptionsForServer))

		' write information about left side of link
		stringBuilder.AppendLine("  left datasource: " & link.LeftDataSource.GetResultSQL())

		If link.LeftType = LinkSideType.Inner Then
			stringBuilder.AppendLine("  left type: Inner")
		Else
			stringBuilder.AppendLine("  left type: Outer")
		End If

		' write information about right side of link
		stringBuilder.AppendLine("  right datasource: " & link.RightDataSource.GetResultSQL())

		If link.RightType = LinkSideType.Inner Then
			stringBuilder.AppendLine("  lerightft type: Inner")
		Else
			stringBuilder.AppendLine("  right type: Outer")
		End If
	End Sub

	Private Sub DumpLinksInfo(stringBuilder As StringBuilder, links As IList(Of Link))
		For i As Integer = 0 To links.Count - 1
			If stringBuilder.Length > 0 Then
				stringBuilder.AppendLine()
			End If

			DumpLinkInfo(stringBuilder, links(i))
		Next
	End Sub

	Public Sub DumpLinksInfoFromUnionSubQuery(stringBuilder As StringBuilder, unionSubQuery As UnionSubQuery)
		DumpLinksInfo(stringBuilder, GetLinkList(unionSubQuery))
	End Sub
End Class
