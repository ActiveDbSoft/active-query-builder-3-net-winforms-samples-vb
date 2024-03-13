''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2024 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View


Partial Public Class Form1
    Inherits Form
    Private _dragBoxFromMouseDown As Rectangle = Rectangle.Empty
    Private _errorPosition As Integer = -1
    Private _lastValidSql As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        ' Fill query builder with demo data
        queryBuilder1.SyntaxProvider = New MSSQLSyntaxProvider()
        queryBuilder1.MetadataLoadingOptions.OfflineMode = True
        queryBuilder1.MetadataContainer.ImportFromXML("Northwind.xml")
        queryBuilder1.InitializeDatabaseSchemaTree()

        MyBase.OnLoad(e)
    End Sub

    Private Sub queryBuilder1_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs) Handles queryBuilder1.SQLUpdated
        ' Handle the event raised by SQL Builder object that the text of SQL query is changed

        ' Hide error banner if any
        errorBox1.Show(Nothing, queryBuilder1.SyntaxProvider)

        ' update the text box
        textBox1.Text = queryBuilder1.FormattedSQL
        _lastValidSql = textBox1.Text
    End Sub

    Private Sub textBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textBox1.Validating
        Try
            ' Update the query builder with manually edited query text:
            queryBuilder1.SQL = textBox1.Text

            ' Hide error banner if any
            errorBox1.Show(Nothing, queryBuilder1.SyntaxProvider)
        Catch ex As SQLParsingException
            ' Set caret to error position
            textBox1.SelectionStart = ex.ErrorPos.pos
            _errorPosition = textBox1.SelectionStart

            ' Show banner with error text
            errorBox1.Show(ex.Message, queryBuilder1.SyntaxProvider)
        End Try
    End Sub

    Private Sub listBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBox1.MouseDown
        ' Prepare drag'n'drop:
        If listBox1.SelectedIndex <> -1 Then
            Dim r As Rectangle = listBox1.GetItemRectangle(listBox1.SelectedIndex)

            Dim dragSize As Size = SystemInformation.DragSize

            _dragBoxFromMouseDown = New Rectangle(New Point(e.X - (dragSize.Width \ 2), e.Y - (dragSize.Height \ 2)), dragSize)
        Else
            _dragBoxFromMouseDown = Rectangle.Empty
        End If
    End Sub

    Private Sub listBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBox1.MouseUp
        _dragBoxFromMouseDown = Rectangle.Empty
    End Sub

    Private Sub listBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBox1.MouseMove
        ' Do drag:

        If listBox1.SelectedIndex <> -1 Then
            If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
                If _dragBoxFromMouseDown <> Rectangle.Empty AndAlso (Not _dragBoxFromMouseDown.Contains(e.X, e.Y)) Then
                    Dim objectName As String = CStr(listBox1.SelectedItem)
                    Dim metadataObject As MetadataObject = queryBuilder1.MetadataContainer.FindItem(Of MetadataObject)(objectName)

                    If metadataObject IsNot Nothing Then
                        Dim dragObject As New MetadataDragObject()
                        dragObject.MetadataDragged.Add(metadataObject)

                        listBox1.DoDragDrop(dragObject, DragDropEffects.Copy)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub listBox1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles listBox1.DoubleClick
        ' Double click will add the object in automatic position:
        If listBox1.SelectedIndex <> -1 Then
            Dim objectName As String = CType(listBox1.SelectedItem, String)
            queryBuilder1.AddObjectToActiveUnionSubQuery(objectName)
        End If
    End Sub

    Private Sub ErrorBox1_RevertValidText(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.RevertValidText
        textBox1.Text = _lastValidSql
        textBox1.Focus()
    End Sub

    Private Sub ErrorBox1_GoToErrorPosition(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.GoToErrorPosition
        If _errorPosition <> -1 Then
            textBox1.SelectionStart = _errorPosition
            textBox1.SelectionLength = 0
            textBox1.ScrollToCaret()
        End If

        textBox1.Focus()
    End Sub
End Class
