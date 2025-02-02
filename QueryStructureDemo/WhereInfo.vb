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
    Private Sub DumpExpression(stringBuilder As StringBuilder, indent As String, expression As SQLExpressionItem)
        Const cIndentInc As String = "    "

        Dim newIndent As String = indent & cIndentInc

        If expression Is Nothing Then ' NULL reference protection
            stringBuilder.AppendLine(indent & "--nil--")
        ElseIf TypeOf expression Is SQLExpressionBrackets Then
            ' Expression is actually the brackets query structure node.
            ' Create the "brackets" tree node and load content of
            ' the brackets as children of the node.
            stringBuilder.AppendLine(indent & "()")
            DumpExpression(stringBuilder, newIndent, (CType(expression, SQLExpressionBrackets)).LExpression)
        ElseIf TypeOf expression Is SQLExpressionOr Then
            ' Expression is actually the "OR" query structure node.
            ' Create the "OR" tree node and load all items of
            ' the "OR" collection as children of the tree node.
            stringBuilder.AppendLine(indent & "OR")

            For i As Integer = 0 To (CType(expression, SQLExpressionOr)).Count - 1
                DumpExpression(stringBuilder, newIndent, (CType(expression, SQLExpressionOr))(i))
            Next i
        ElseIf TypeOf expression Is SQLExpressionAnd Then
            ' Expression is actually the "AND" query structure node.
            ' Create the "AND" tree node and load all items of
            ' the "AND" collection as children of the tree node.
            stringBuilder.AppendLine(indent & "AND")

            For i As Integer = 0 To (CType(expression, SQLExpressionAnd)).Count - 1
                DumpExpression(stringBuilder, newIndent, (CType(expression, SQLExpressionAnd))(i))
            Next i
        ElseIf TypeOf expression Is SQLExpressionNot Then
            ' Expression is actually the "NOT" query structure node.
            ' Create the "NOT" tree node and load content of
            ' the "NOT" operator as children of the tree node.
            stringBuilder.AppendLine(indent & "NOT")
            DumpExpression(stringBuilder, newIndent, (CType(expression, SQLExpressionNot)).LExpression)
        ElseIf TypeOf expression Is SQLExpressionOperatorBinary Then
            ' Expression is actually the "BINARY OPERATOR" query structure node.
            ' Create a tree node containing the operator value and
            ' two leaf nodes with the operator arguments.
            Dim s As String = (CType(expression, SQLExpressionOperatorBinary)).OperatorObj.OperatorName
            stringBuilder.AppendLine(indent & s)
            ' left argument of the binary operator
            DumpExpression(stringBuilder, newIndent, (CType(expression, SQLExpressionOperatorBinary)).LExpression)
            ' right argument of the binary operator
            DumpExpression(stringBuilder, newIndent, (CType(expression, SQLExpressionOperatorBinary)).RExpression)
        Else
            ' other type of AST nodes - out as a text
            Dim s As String = expression.GetSQL(expression.SQLContext.SQLGenerationOptionsForServer)
            stringBuilder.AppendLine(indent & s)
        End If
    End Sub

    Public Sub DumpWhereInfo(stringBuilder As StringBuilder, where As SQLExpressionItem)
        DumpExpression(stringBuilder, "", where)
    End Sub
End Class
