//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

Imports System.Collections
Imports System.Text
Imports ActiveQueryBuilder.Core


Partial Public Class Form1
    Private Sub GetUnlinkedDatsourcesRecursive(firstDataSource As DataSource, dataSources As IList(Of DataSource), links As IList(Of Link))
        ' Remove reached datasource from list of available datasources.
        dataSources.Remove(firstDataSource)

        For Each link In links
            ' If left end of the link is connected to firstDataSource,
            ' then link.RightDatasource is reachable.
            ' If it's still in dataSources list (not yet processed), process it recursivelly.
            If link.LeftDataSource Is firstDataSource AndAlso dataSources.IndexOf(link.RightDataSource) <> -1 Then
                GetUnlinkedDatsourcesRecursive(link.RightDataSource, dataSources, links)
                ' If right end of the link is connected to firstDataSource,
                ' then link.LeftDatasource is reachable.
                ' If it's still in dataSources list (not yet processed), process it recursivelly.
            ElseIf link.RightDataSource Is firstDataSource AndAlso dataSources.IndexOf(link.LeftDataSource) <> -1 Then
                GetUnlinkedDatsourcesRecursive(link.LeftDataSource, dataSources, links)
            End If
        Next link
    End Sub

    Public Function GetUnlinkedDataSourcesFromUnionSubQuery(unionSubQuery As UnionSubQuery) As String
        Dim dataSources = unionSubQuery.GetChildrenRecursive(Of DataSource)(False)

        ' Process trivial cases
        If dataSources.Count = 0 Then
            Return "There are no datasources in current UnionSubQuery!"
        End If

        If dataSources.Count = 1 Then
            Return "There are only one datasource in current UnionSubQuery!"
        End If

        Dim links = unionSubQuery.GetChildrenRecursive(Of Link)(False)

        ' The first DataSource is the initial point of reachability algorithm
        Dim firstDataSource As DataSource = dataSources(0)

        ' Remove all linked DataSources from dataSources list
        GetUnlinkedDatsourcesRecursive(firstDataSource, dataSources, links)

        ' Now dataSources list contains only DataSources unreachable from the firstDataSource

        If dataSources.Count = 0 Then
            Return "All DataSources in the query are connected!"
        End If

        ' Some DataSources are not reachable - show them in a message box
        Dim sb = New StringBuilder()

        For i As Integer = 0 To dataSources.Count - 1
            Dim dataSource = dataSources(i)
            sb.AppendLine((i + 1) & ": " & dataSource.GetResultSQL())
        Next i

        Return "The following DataSources are not reachable from the first DataSource:" & vbCrLf & sb.ToString()
    End Function
End Class
