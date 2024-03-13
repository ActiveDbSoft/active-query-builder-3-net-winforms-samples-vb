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


Partial Public Class Form1
    Inherits Form
    Private _lastValidSql As String
    Private _errorPosition As Integer = -1

    Public Sub New()
        InitializeComponent()

        ' set syntax provider
        QBuilder.SyntaxProvider = New MSSQLSyntaxProvider With {.ServerVersion = MSSQLServerVersion.MSSQL2012}

        ' Fill metadata container from the XML file. (For demonstration purposes.)
        Try
            QBuilder.MetadataLoadingOptions.OfflineMode = True
            QBuilder.MetadataContainer.ImportFromXML("Northwind.xml")
            QBuilder.InitializeDatabaseSchemaTree()

            QBuilder.SQL = "SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID," & ControlChars.CrLf & "                                        [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount" & ControlChars.CrLf & "                                      FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID" & ControlChars.CrLf & "                                      WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub queryBuilder1_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs) Handles QBuilder.SQLUpdated
        ' Update the text of SQL query when it's changed in the query builder.
        TextBoxSQL.Text = QBuilder.FormattedSQL
        _lastValidSql = TextBoxSQL.Text
    End Sub

    ''' <summary>
    ''' The handler checks if the dragged field is a part of the primary key and denies dragging if it's not the case.
    ''' </summary>
    Private Sub QBuilder_BeforeDatasourceFieldDrag(ByVal dataSource As DataSource, ByVal field As MetadataField, ByRef abort As Boolean) Handles QBuilder.BeforeDatasourceFieldDrag
        If CheckBoxBeforeDsFieldDrag.Checked <> True Then
            Return
        End If

        ' deny dragging if a field isn't a part of the primary key
        If Not field.PrimaryKey Then
            TextBoxReport.Text = "OnBeforeDatasourceFieldDrag for field """ & field.Name & " "" deny" & Environment.NewLine & TextBoxReport.Text
            abort = True
            Return
        End If

        TextBoxReport.Text = "OnBeforeDatasourceFieldDrag for field """ & field.Name & " "" allow" & Environment.NewLine & TextBoxReport.Text
    End Sub

    ''' <summary>
    ''' Checking the feasibility of creating a link between the given fields.
    ''' </summary>
    Private Sub QBuilder_LinkDragOver(ByVal fromDataSource As DataSource, ByVal fromField As MetadataField, ByVal toDataSource As DataSource, ByVal toField As MetadataField, ByVal correspondingMetadataForeignKey As MetadataForeignKey, ByRef abort As Boolean) Handles QBuilder.LinkDragOver
        If CheckBoxLinkDragOver.Checked <> True Then
            Return
        End If

        ' Allow creation of links between fields of the same data type.
        If fromField.FieldType = toField.FieldType Then
            TextBoxReport.Text = "OnLinkDragOver from field """ & fromField.Name & """ to field """ & toField.Name & """ allow" & Environment.NewLine & TextBoxReport.Text
            Return
        End If

        TextBoxReport.Text = "OnLinkDragOver from field """ & fromField.Name & """ to field """ & toField.Name & """ deny" & Environment.NewLine & TextBoxReport.Text

        abort = True
    End Sub

    Private Sub TextBoxSQL_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBoxSQL.Validating
        Try
            ' Update the query builder with manually edited query text:
            QBuilder.SQL = TextBoxSQL.Text

            ' Hide error banner if any
            errorBox1.Show(Nothing, QBuilder.SyntaxProvider)
        Catch ex As SQLParsingException
            ' Set caret to error position
            TextBoxSQL.SelectionStart = ex.ErrorPos.pos
            _errorPosition = TextBoxSQL.SelectionStart

            ' Show banner with error text
            errorBox1.Show(ex.Message, QBuilder.SyntaxProvider)
        End Try
    End Sub

    Private Sub ErrorBox1_RevertValidText(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.RevertValidText
        TextBoxSQL.Text = _lastValidSql
        TextBoxSQL.Focus()
    End Sub

    Private Sub ErrorBox1_GoToErrorPosition(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.GoToErrorPosition
        If _errorPosition <> -1 Then
            TextBoxSQL.SelectionStart = _errorPosition
            TextBoxSQL.SelectionLength = 0
            TextBoxSQL.ScrollToCaret()
        End If

        errorBox1.Visible = False
        TextBoxSQL.Focus()
    End Sub
End Class
