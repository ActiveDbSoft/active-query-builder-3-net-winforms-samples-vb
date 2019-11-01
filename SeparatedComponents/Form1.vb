'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms

Partial Public Class Form1
    Inherits Form
    Dim _lastValidSql As String
    Dim _errorPosition As Integer

    Public Sub New()
        InitializeComponent()
        AddHandler sqltextEditor1.TextChanged, AddressOf SqlEditor_TextChanged
    End Sub

    Private Sub SqlEditor_TextChanged(sender As Object, e As EventArgs)
        ErrorBox1.Visible = False
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        Try
            ' Fill metadata container from the XML file (for demonstration purposes).
            sqlContext1.LoadingOptions.OfflineMode = True
            sqlContext1.MetadataContainer.ImportFromXML("Northwind.xml")

            databaseSchemaView1.InitializeDatabaseSchemaTree()

            sqlQuery1.SQL = "SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID," & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "[Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount" & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "  FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID" & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "  WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        MyBase.OnLoad(e)
    End Sub

    Private Sub refreshMetadataMenuItem_Click(sender As Object, e As EventArgs) Handles refreshMetadataMenuItem.Click
        ' Force the query builder to refresh metadata from current connection
        ' to refresh metadata, just clear MetadataContainer and reinitialize metadata tree

        If sqlContext1.MetadataProvider IsNot Nothing AndAlso sqlContext1.MetadataProvider.Connected Then
            sqlContext1.ClearMetadata()
            databaseSchemaView1.InitializeDatabaseSchemaTree()
        End If
    End Sub

    Private Sub editMetadataMenuItem_Click(sender As Object, e As EventArgs) Handles editMetadataMenuItem.Click
        ' Open the metadata container editor

        QueryBuilder.EditMetadataContainer(sqlContext1)
    End Sub

    Private Sub clearMetadataMenuItem_Click(sender As Object, e As EventArgs) Handles clearMetadataMenuItem.Click
        ' Clear the metadata

        If MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            sqlContext1.ClearMetadata()
        End If
    End Sub

    Private Sub loadMetadataFromXMLMenuItem_Click(sender As Object, e As EventArgs) Handles loadMetadataFromXMLMenuItem.Click
        ' Load metadata from XML file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            sqlContext1.LoadingOptions.OfflineMode = True
            sqlContext1.MetadataContainer.ImportFromXML(openFileDialog.FileName)
            databaseSchemaView1.InitializeDatabaseSchemaTree()
        End If
    End Sub

    Private Sub saveMetadataToXMLMenuItem_Click(sender As Object, e As EventArgs) Handles saveMetadataToXMLMenuItem.Click
        ' Save metadata to XML file
        saveFileDialog.FileName = "Metadata.xml"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            sqlContext1.MetadataContainer.LoadAll(True)
            sqlContext1.MetadataContainer.ExportToXML(saveFileDialog.FileName)
        End If
    End Sub

    Private Sub aboutMenuItem_Click(sender As Object, e As EventArgs) Handles aboutMenuItem.Click
        QueryBuilder.ShowAboutDialog()
    End Sub

    Private Sub sqlQuery_SQLUpdated(sender As Object, e As EventArgs) Handles sqlQuery1.SQLUpdated
        ' Handle the event raised by SQL Builder object that the text of SQL query is changed

        ' Hide error banner if any
        ErrorBox1.Visible = False

        ' update the text box with formatted query text created with default formatting options

        sqlTextEditor1.Text = sqlQuery1.SQL
        _lastValidSql = sqlQuery1.SQL
    End Sub

    Public Sub ResetQueryBuilder()
        sqlContext1.ClearMetadata()
        sqlContext1.MetadataProvider = Nothing
        sqlContext1.SyntaxProvider = Nothing
        sqlContext1.LoadingOptions.OfflineMode = False
    End Sub

    Private Sub sqlTextEditor1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sqlTextEditor1.Validating
        Try
            ' Update the query builder with manually edited query text:
            sqlQuery1.SQL = sqlTextEditor1.Text

            ' Hide error banner if any
            ErrorBox1.Visible = False
        Catch ex As SQLParsingException
            ' Set caret to error position
            sqlTextEditor1.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            ErrorBox1.Show(ex.Message, sqlContext1.SyntaxProvider)
            _errorPosition = ex.ErrorPos.pos
        End Try
    End Sub

    Private Sub queryStatisticsMenuItem_Click(sender As Object, e As EventArgs) Handles queryStatisticsMenuItem.Click
        Dim builder As New StringBuilder()

        Dim queryStatistics As QueryStatistics = sqlQuery1.QueryStatistics

        builder.Append("Used Objects (").Append(queryStatistics.UsedDatabaseObjects.Count).AppendLine("):")
        builder.AppendLine()

        For i As Integer = 0 To queryStatistics.UsedDatabaseObjects.Count - 1
            builder.AppendLine(queryStatistics.UsedDatabaseObjects(i).ObjectName.QualifiedName)
        Next

        builder.AppendLine().AppendLine()
        builder.Append("Used Columns (").Append(queryStatistics.UsedDatabaseObjectFields.Count).AppendLine("):")
        builder.AppendLine()

        For i As Integer = 0 To queryStatistics.UsedDatabaseObjectFields.Count - 1
            builder.AppendLine(queryStatistics.UsedDatabaseObjectFields(i).ObjectName.QualifiedName)
        Next

        builder.AppendLine().AppendLine()
        builder.Append("Output Expressions (").Append(queryStatistics.OutputColumns.Count).AppendLine("):")
        builder.AppendLine()

        For i As Integer = 0 To queryStatistics.OutputColumns.Count - 1
            builder.AppendLine(queryStatistics.OutputColumns(i).Expression)
        Next

        MessageBox.Show(builder.ToString())
    End Sub

    Private Sub ErrorBox1_RevertValidTextEvent(sender As Object, e As EventArgs) Handles ErrorBox1.RevertValidTextEvent
        sqlTextEditor1.Text = _lastValidSql
        sqlTextEditor1.Focus()
    End Sub

    Private Sub ErrorBox1_GoToErrorPositionEvent(sender As Object, e As EventArgs) Handles ErrorBox1.GoToErrorPositionEvent
        If _errorPosition <> -1 Then
            sqlTextEditor1.SelectionStart = _errorPosition
            sqlTextEditor1.SelectionLength = 0
            sqlTextEditor1.ScrollToPosition(_errorPosition)
        End If

        ErrorBox1.Visible = False
        sqlTextEditor1.Focus()
    End Sub
End Class
