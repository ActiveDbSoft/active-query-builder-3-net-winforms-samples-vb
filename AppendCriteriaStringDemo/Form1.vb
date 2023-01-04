''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2023 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports ActiveQueryBuilder.Core


Partial Public Class Form1
    Inherits Form
    Private Const SampleSQL As String = "select Count(o.OrderId) " & "from Orders o " & "where 1 = 1 " & "Group By Count(o.CustomerId) " & "union all " & "select 1 " & "from Orders o " & "where 2 = 2"

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        ' don't query issue additional queries
        queryBuilder1.MetadataLoadingOptions.OfflineMode = True

        ' load sample query into internal query builder
        queryBuilder1.SQL = SampleSQL
    End Sub

    Private Sub queryBuilder1_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs) Handles queryBuilder1.SQLUpdated
        textBoxQuery.Text = queryBuilder1.FormattedSQL
    End Sub

    Private Sub buttonClearWhere_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonClearWhere.Click
        ' get reference to first UnionSubQuery of the Main query
        Dim usq As UnionSubQuery = queryBuilder1.SQLQuery.QueryRoot.FirstSelect()

        ClearWhere(usq)
    End Sub

    Private Sub buttonAppend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAppend.Click
        ' get reference to first UnionSubQuery of the Main query
        Dim usq As UnionSubQuery = queryBuilder1.SQLQuery.QueryRoot.FirstSelect()

        AppendWhere(usq, textBoxNewWhere.Text)
    End Sub

    Private Sub buttonReplaceWhere_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonReplaceWhere.Click
        ' get reference to first UnionSubQuery of the Main query
        Dim usq As UnionSubQuery = queryBuilder1.SQLQuery.QueryRoot.FirstSelect()

        ReplaceWhere(usq, textBoxNewWhere.Text)
    End Sub

    Private Sub buttonReplaceWhereAccess_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonReplaceWhereAccess.Click
        ' get reference to first UnionSubQuery of the Main query
        Dim usq As UnionSubQuery = queryBuilder1.SQLQuery.QueryRoot.FirstSelect()

        ReplaceWhereAccess(usq, textBoxNewWhereAccess.Text)
    End Sub

    Private Sub buttonReplaceWhereAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonReplaceWhereAll.Click
        ' get reference to the main query
        Dim query As SubQuery = queryBuilder1.SQLQuery.QueryRoot

        ReplaceWhereAll(query, textBoxNewWhereAccess.Text)
    End Sub

    Private Sub ClearWhere(ByVal unionSubQuery As UnionSubQuery)
        ' get reference to QueryColumnList
        Dim cl As QueryColumnList = unionSubQuery.QueryColumnList

        ' disable SQL updating for QueryBuilder
        queryBuilder1.BeginUpdate()

        Try
            ' clear old Where
            For i As Integer = 0 To cl.Count - 1
                Dim ci As QueryColumnListItem = cl(i)

                If ci.ConditionType = ConditionType.Where Then
                    ' clear all WHERE expressions in a row
                    For j As Integer = 0 To ci.ConditionCount - 1
                        ci.ConditionStrings(j) = ""
                    Next j
                End If
            Next i
        Finally
            queryBuilder1.EndUpdate()
        End Try
    End Sub

    Private Sub AppendWhere(ByVal unionSubQuery As UnionSubQuery, ByVal newWhereStr As String)
        Dim resultWhere As SQLExpressionAnd

        ' parse and prepare new WHERE expression
        Dim newWhere As SQLExpressionItem = ParseExpression(newWhereStr)

        ' if there are no new expression - nothing to do
        If newWhere Is Nothing Then
            Return
        End If

        ' extract old WHERE expression
        Dim oldWhere As SQLExpressionItem = unionSubQuery.QueryColumnList.GetConditionTree( { ConditionType.Where })

        ' normalize old WHERE expression
        If oldWhere IsNot Nothing Then
            oldWhere.RestoreColumnPrefixRecursive(True)
        End If

        ' simplify old WHERE expression
        If oldWhere IsNot Nothing Then
            ' if old WHERE is a collection of ORed or ANDed expressions
            ' with only one expression in the list - remove the external list
            Do While TypeOf oldWhere Is SQLExpressionLogicalCollection AndAlso (CType(oldWhere, SQLExpressionLogicalCollection)).Count = 1
                Using tmp As SQLExpressionLogicalCollection = CType(oldWhere, SQLExpressionLogicalCollection)
                    oldWhere = tmp.Extract(0)
                End Using
            Loop
        End If

        ' combine old and new WHERE expressions
        resultWhere = New SQLExpressionAnd(queryBuilder1.SQLContext)

        If oldWhere IsNot Nothing Then
            resultWhere.Add(oldWhere)
        End If

        resultWhere.Add(newWhere)

        ' fix up combined WHERE expression
        FixupExpression(unionSubQuery, resultWhere)

        ' defer SQL updates
        unionSubQuery.BeginUpdate()

        Try
            ' clear old WHERE expression
            ClearWhere(unionSubQuery)

            ' load new WHERE expression (if exists)
            unionSubQuery.QueryColumnList.LoadConditionFromAST(resultWhere, ConditionType.Where)
        Finally
            ' enable SQL updates
            unionSubQuery.EndUpdate()
        End Try
    End Sub

    Private Sub ReplaceWhere(ByVal unionSubQuery As UnionSubQuery, ByVal newWhereStr As String)
        ' parse and prepare new WHERE expression
        Dim newWhere As SQLExpressionItem = ParseExpression(newWhereStr)

        If newWhere IsNot Nothing Then
            FixupExpression(unionSubQuery, newWhere)
        End If

        ' defer SQL updates
        unionSubQuery.BeginUpdate()

        Try
            ' clear old WHERE expression
            ClearWhere(unionSubQuery)

            ' load new WHERE expression (if exists)
            If newWhere IsNot Nothing Then
                unionSubQuery.QueryColumnList.LoadConditionFromAST(newWhere, ConditionType.Where)
            End If
        Finally
            ' enable SQL updates
            unionSubQuery.EndUpdate()
        End Try
    End Sub

    Private Sub ReplaceWhereAccess(ByVal unionSubQuery As UnionSubQuery, ByVal newWhereStr As String)
        ' parse and prepare new WHERE expression
        Dim newWhere As SQLExpressionItem = ParseExpressionAccess(newWhereStr)

        If newWhere IsNot Nothing Then
            FixupExpression(unionSubQuery, newWhere)
            ConvertExpressionConstantsNotation(newWhere)
        End If

        ' defer SQL updates
        unionSubQuery.BeginUpdate()

        Try
            ' clear old WHERE expression
            ClearWhere(unionSubQuery)

            ' load new WHERE expression (if exists)
            If newWhere IsNot Nothing Then
                unionSubQuery.QueryColumnList.LoadConditionFromAST(newWhere, ConditionType.Where)
            End If
        Finally
            ' enable SQL updates
            unionSubQuery.EndUpdate()
        End Try
    End Sub

    Private Sub ReplaceWhereAll(ByVal subQuery As SubQuery, ByVal newWhere As String)
        ReplaceWhereInGroup(subQuery, newWhere)
    End Sub

    Private Sub ReplaceWhereInGroup(ByVal unionGroup As UnionGroup, ByVal newWhere As String)
        For i As Integer = 0 To unionGroup.Count - 1
            If TypeOf unionGroup(i) Is UnionGroup Then
                ReplaceWhereInGroup(CType(unionGroup(i), UnionGroup), newWhere)
            Else
                Debug.Assert(TypeOf unionGroup(i) Is UnionSubQuery)
                ReplaceWhereAccess(CType(unionGroup(i), UnionSubQuery), newWhere)
            End If
        Next i
    End Sub

    Private Sub FixupExpression(ByVal queryContext As QueryElement, ByVal expression As SQLExpressionItem)
        Debug.Assert(expression IsNot Nothing)

        Dim listCTE As New List(Of SQLWithClauseItem)()
        Dim listFromSources As New List(Of SQLFromSource)()

        ' fix up names in raw AST in given context
        queryContext.GatherPrepareAndFixupContext(listCTE, listFromSources, True)
        expression.PrepareAndFixupRecursive(listCTE, listFromSources)
    End Sub

    Private Function ParseExpression(ByVal expression As String) As SQLExpressionItem
        ' parse expression to get raw AST (Abstract Syntax Tree)
        Return queryBuilder1.SQLContext.ParseLogicalExpression(expression)
    End Function

    Private Function ParseExpressionAccess(ByVal expression As String) As SQLExpressionItem
        Dim accessSQLContext As New SQLContext()
        Dim accessExpression As SQLExpressionItem

        Try
            ' set up context class to use Access syntax
            accessSQLContext.SyntaxProvider = msAccessSyntaxProvider1

            accessExpression = accessSQLContext.ParseExpression(expression)

            Try
                ' clone parsed expression in our default context
                ' this converts identifiers quotation, but leave the same constants notation
                If accessExpression IsNot Nothing Then
                    Return accessExpression.Clone(queryBuilder1.SQLContext)
                Else
                    Return Nothing
                End If
            Finally
                If accessExpression IsNot Nothing Then
                    accessExpression.Dispose()
                End If
            End Try
        Finally
            accessSQLContext.Dispose()
        End Try
    End Function

    Private Sub ConvertExpressionConstantsNotation(ByVal expression As SQLExpressionItem)
        Debug.Assert(expression IsNot Nothing)

        Dim astNodes As New List(Of AstNodeBase)()

        ' get all children (and grand[grand...]children) AST nodes as a flat list
        expression.GetMyChildrenRecursive(astNodes)

        ' add expression node itself to AST nodes list
        ' (to check is the given expression is constant itself)
        astNodes.Add(expression)

        ' remove all items from the list except TSQLExpressionConstant
        For i As Integer = astNodes.Count - 1 To 0 Step -1
            If Not(TypeOf astNodes(i) Is SQLExpressionConstant) Then
                astNodes.RemoveAt(i)
            End If
        Next i

        ' for each item in the list
        For i As Integer = 0 To astNodes.Count - 1
            ConvertConstantNotation(CType(astNodes(i), SQLExpressionConstant))
        Next i
    End Sub

    ' internal procedure to convert single constant
    Private Sub ConvertConstantNotation(ByVal constant As SQLExpressionConstant)
        Dim oldString As String = constant.GetSQL()

        ' convert DATE representation
        If oldString.Length > 0 AndAlso oldString.Chars(0) = "#"c Then
            Dim newString As String = oldString.Replace("#"c, "'"c)
            constant.Clear()
            constant.AddString(newString)
        End If
    End Sub
End Class
