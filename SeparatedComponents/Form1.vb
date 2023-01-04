''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2023 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Text
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms


Partial Public Class Form1
    Inherits Form
    Private _lastValidSql As String
    Private _errorPosition As Integer = -1

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        Try
            ' Fill metadata container from the XML file (for demonstration purposes).
            sqlContext1.LoadingOptions.OfflineMode = True
            sqlContext1.MetadataContainer.ImportFromXML("Northwind.xml")

            databaseSchemaView1.InitializeDatabaseSchemaTree()

            sqlQuery1.SQL = "SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID," & ControlChars.CrLf & "                                        [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount" & ControlChars.CrLf & "                                      FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID" & ControlChars.CrLf & "                                      WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0"
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
        errorBox1.Visible = False

        ' update the text box with formatted query text created with default formatting options
        If Equals(sqlQuery1.SQLContext, Nothing) Then Return
        textBox1.Text = FormattedSQLBuilder.GetSQL(sqlQuery1.QueryRoot, New SQLFormattingOptions())
        _lastValidSql = textBox1.Text
    End Sub

    Public Sub ResetQueryBuilder()
        sqlContext1.ClearMetadata()
        sqlContext1.MetadataProvider = Nothing
        sqlContext1.SyntaxProvider = Nothing
        sqlContext1.LoadingOptions.OfflineMode = False
    End Sub

    Private Sub textBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles textBox1.Validating
        Try
            ' Update the query builder with manually edited query text:
            sqlQuery1.SQL = textBox1.Text

            ' Hide error banner if any
            errorBox1.Visible = False
        Catch ex As SQLParsingException
            ' Set caret to error position
            textBox1.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            errorBox1.Show(ex.Message, sqlContext1.SyntaxProvider)
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
        Next i

        builder.AppendLine().AppendLine()
        builder.Append("Used Columns (").Append(queryStatistics.UsedDatabaseObjectFields.Count).AppendLine("):")
        builder.AppendLine()

        For i As Integer = 0 To queryStatistics.UsedDatabaseObjectFields.Count - 1
            builder.AppendLine(queryStatistics.UsedDatabaseObjectFields(i).FullName.QualifiedName)
        Next i

        builder.AppendLine().AppendLine()
        builder.Append("Output Expressions (").Append(queryStatistics.OutputColumns.Count).AppendLine("):")
        builder.AppendLine()

        For i As Integer = 0 To queryStatistics.OutputColumns.Count - 1
            builder.AppendLine(queryStatistics.OutputColumns(i).Expression)
        Next i

        MessageBox.Show(builder.ToString())
    End Sub

    Private Sub ErrorBox1_RevertValidTextEvent(sender As Object, e As EventArgs) Handles errorBox1.RevertValidText
        textBox1.Text = _lastValidSql
        textBox1.Focus()
    End Sub

    Private Sub ErrorBox1_GoToErrorPositionEvent(sender As Object, e As EventArgs) Handles errorBox1.GoToErrorPosition
        If _errorPosition <> -1 Then
            textBox1.SelectionStart = _errorPosition
            textBox1.SelectionLength = 0
            textBox1.ScrollToCaret()
        End If

        errorBox1.Visible = False
        textBox1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged
        errorBox1.Visible = False
    End Sub
End Class
