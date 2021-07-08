''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2021 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.QueryView


Partial Public Class Form1
    Inherits Form
    Private _errorPosition As Integer = -1
    Private _lastValidSql As String

    Public Sub New()
        InitializeComponent()

        ' set syntax provider
        QBuilder.SyntaxProvider = New MSSQLSyntaxProvider()

        ' Fill metadata container from the XML file. (For demonstration purposes.)
        Try
            QBuilder.SQLQuery.QueryRoot.AllowSleepMode = False
            QBuilder.MetadataLoadingOptions.OfflineMode = True
            QBuilder.MetadataContainer.ImportFromXML("Northwind.xml")
            QBuilder.InitializeDatabaseSchemaTree()
            QBuilder.SQL = "SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID," & ControlChars.CrLf & "										[Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount" & ControlChars.CrLf & "									  FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID" & ControlChars.CrLf & "									  WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub QBuilder_DataSourceAdded(ByVal sender As SQLQuery, ByVal addedObject As DataSource) Handles QBuilder.DataSourceAdded
        If CbDataSourceAdded.Checked <> True Then
            Return
        End If
        AddRowToReport("DataSourceAdded. Object caption """ & addedObject.MetadataObject.Name & """")
    End Sub

    ''' <summary>
    ''' Prompts the user if he/she really wants to add an object to the query.
    ''' </summary>
    Private Sub QBuilder_DataSourceAdding(ByVal fromObject As MetadataObject, ByRef abort As Boolean) Handles QBuilder.DataSourceAdding
        If Not CbDataSourceAdding.Checked Then
            Return
        End If

        AddRowToReport("DataSourceAdding. Object caption """ & fromObject.Name & """")

        Dim name = fromObject.Name
        Dim msg = "Do you want to add the object """ & name & """ on the diagram pane?"

        If MessageBox.Show(msg, "DataSourceAdding event handler", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    ''' <summary>
    ''' Displays a prompt on deleting an object from the query.
    ''' </summary>
    Private Sub QBuilder_DataSourceDeleting(ByVal dataSource As DataSource, ByRef abort As Boolean) Handles QBuilder.DataSourceDeleting
        If CbDataSourceDeleting.Checked <> True Then
            Return
        End If
        Dim name = dataSource.NameInQuery
        Dim msg = "Do you want to remove the object """ & name & """ on the diagram pane?"

        If MessageBox.Show(msg, "DataSourceDeleting event handler", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    Private Sub QBuilder_DataSourceFieldAdded(ByVal dataSource As DataSource, ByVal field As MetadataField, ByVal queryColumnListItem As QueryColumnListItem, ByVal focusCondition As Boolean) Handles QBuilder.DataSourceFieldAdded
        If CbDataSourceFieldAdded.Checked <> True Then
            Return
        End If
        Dim text = If(field Is Nothing, dataSource.NameInQuery & ".*", field.Name)
        AddRowToReport("DataSourceFieldAdded """ & text & """")
    End Sub

    '
    ' DatasourceFieldAdding event allows to prevent selecting of a field.
    '
    Private Sub QBuilder_DataSourceFieldAdding(ByVal dataSource As DataSource, ByVal field As MetadataField, ByRef abort As Boolean) Handles QBuilder.DataSourceFieldAdding
        If Not CbDataSourceFieldAdding.Checked Then
            Return
        End If

        Dim text = If(field Is Nothing, dataSource.NameInQuery & ".*", field.Name)

        AddRowToReport("DataSourceFieldAdding. Field name """ & text & """")
        Dim msg = "Do you want to add the field """ & text & """ to the query?"

        If MessageBox.Show(msg, "DatasourceFieldAdding event handler", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    Private Sub QBuilder_DatasourceFieldRemoved(ByVal dataSource As DataSource, ByVal field As MetadataField) Handles QBuilder.DatasourceFieldRemoved
        If CbDatasourceFieldRemoved.Checked <> True Then
            Return
        End If

        Dim text = If(field Is Nothing, dataSource.NameInQuery & ".*", field.Name)

        AddRowToReport("DatasourceFieldRemoved """ & text & """")
    End Sub

    Private Sub QBuilder_DataSourceFieldRemoving(ByVal dataSource As DataSource, ByVal field As MetadataField, ByRef abort As Boolean) Handles QBuilder.DataSourceFieldRemoving
        If CbDataSourceFieldRemoving.Checked <> True Then
            Return
        End If

        Dim text = If(field Is Nothing, dataSource.NameInQuery & ".*", field.Name)

        AddRowToReport("DataSourceFieldRemoving removing field """ & text & """ form """ & dataSource.NameInQuery & """")

        Dim name = dataSource.NameInQuery
        Dim msg = "Do you want to uncheck field """ & text & """ in the object """ & name & """?"

        If MessageBox.Show(msg, "DataSourceFieldRemoving event handler", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    Private Sub QBuilder_QueryColumnListItemChanged(ByVal queryColumnList As QueryColumnList, ByVal queryColumnListItem As QueryColumnListItem, ByVal [property] As QueryColumnListItemProperty, ByVal conditionIndex As Integer, ByVal newValue As Object) Handles QBuilder.QueryColumnListItemChanged
        If CbQueryColumnListItemChanged.Checked <> True Then
            Return
        End If

        AddRowToReport("QueryColumnListItemChanged property """ & [property] & """ changed")
    End Sub

    '
    ' GridCellValueChanging event allows to prevent the cell value changing or modify the new cell value.
    ' Note: Some columns hide/unhide dynamically but this does not affect the column index in the event parameters -
    '       it includes hidden columns.
    ' private void queryBuilder1_GridCellValueChanging(UnionSubQuery unionSubQuery, QueryColumnList criteriaList, QueryColumnListItem criteriaItem, int column, int row, object oldValue, ref object newValue, ref bool abort)
    Private Sub QBuilder_QueryColumnListItemChanging(ByVal queryColumnList As QueryColumnList, ByVal queryColumnListItem As QueryColumnListItem, ByVal [property] As QueryColumnListItemProperty, ByVal conditionIndex As Integer, ByVal oldValue As Object, ByRef newValue As Object, ByRef abort As Boolean) Handles QBuilder.QueryColumnListItemChanging
        If Not CbQueryColumnListItemChanging.Checked Then
            Return
        End If

        AddRowToReport("QueryColumnListItemChanging. Changes column """ & [property] & """")

        If [property] = QueryColumnListItemProperty.Expression Then ' Prevent changes in the Expression column.
            abort = True
        ElseIf [property] = QueryColumnListItemProperty.Alias Then ' Alias column. Lets add the underscore char in the beginning of all aliases, for example.
            If newValue IsNot Nothing AndAlso TypeOf newValue Is String Then
                Dim s = CStr(newValue)

                If s.Length > 0 AndAlso (Not s.StartsWith("_")) Then
                    s = "_" & s
                    newValue = s
                End If
            End If
        End If
    End Sub

    Private Sub QBuilder_LinkChanged(ByVal link As Link) Handles QBuilder.LinkChanged
        If CbLinkChanged.Checked <> True Then
            Return
        End If
        Dim value = String.Format("LinkChanging. Changing the link between {0}.{1} and {2}.{3}", link.LeftDataSource.MetadataObject.Name, link.LeftField, link.RightDataSource.MetadataObject.Name, link.RightField)
        AddRowToReport(value)
    End Sub

    Private Sub QBuilder_LinkChanging(ByVal link As Link, ByRef abort As Boolean) Handles QBuilder.LinkChanging
        If CbLinkChanging.Checked = True Then
            AddRowToReport("""LinkChanging"" deny")

            'deny changing properties of the Link
            abort = True
            Return
        End If

        AddRowToReport("""LinkChanging"" allow")
    End Sub

    Private Sub QBuilder_LinkCreated(ByVal sender As SQLQuery, ByVal link As Link) Handles QBuilder.LinkCreated
        Dim value = String.Format("LinkCreated. Created the link between {0}.{1} and {2}.{3}", link.LeftDataSource.MetadataObject.Name, link.LeftField, link.RightDataSource.MetadataObject.Name, link.RightField)
        AddRowToReport(value)
    End Sub

    '
    ' LinkCreating event allows to prevent link creation
    '
    Private Sub QBuilder_LinkCreating(ByVal fromDataSource As DataSource, ByVal fromField As MetadataField, ByVal toDataSource As DataSource, ByVal toField As MetadataField, ByVal correspondingMetadataForeignKey As MetadataForeignKey, ByRef abort As Boolean) Handles QBuilder.LinkCreating
        If Not CbLinkCreating.Checked Then
            Return
        End If

        Dim fromFieldText = If(fromField Is Nothing, fromDataSource.NameInQuery & ".*", fromDataSource.MetadataObject.Name & "." & fromField.Name)

        Dim toFieldText = If(fromField Is Nothing, toDataSource.NameInQuery & ".*", toDataSource.MetadataObject.Name & "." & toField.Name)

        Dim value = $"LinkCreating. Creating the link between {fromFieldText} and {toFieldText}"
        AddRowToReport(value)

        Dim msg = $"Do you want to create the link between {fromFieldText} and {toFieldText}?"

        If MessageBox.Show(msg, "LinkCreating event handler", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    '
    ' LinkDeleting event allows to prevent link deletion.
    '
    Private Sub QBuilder_LinkDeleting(ByVal link As Link, ByRef abort As Boolean) Handles QBuilder.LinkDeleting
        If Not CbLinkDeleting.Checked Then
            Return
        End If

        Dim value = String.Format("LinkDeleting. Deleting the link between ""{2}.{0}"" and ""{3}.{1}""", link.LeftField, link.RightField, link.LeftDataSource.MetadataObject.Name, link.RightDataSource.MetadataObject.Name)
        AddRowToReport(value)

        Dim msg As String = String.Format("Do you want to delete the link between ""{2}.{0}"" and ""{3}.{1}""", link.LeftField, link.RightField, link.LeftDataSource.MetadataObject.Name, link.RightDataSource.MetadataObject.Name)

        If MessageBox.Show(msg, "LinkDeleting event handler", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    Private Sub QBuilder_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs) Handles QBuilder.SQLUpdated
        ' Update the text of SQL query when it's changed in the query builder.
        TextBoxSQL.Text = QBuilder.FormattedSQL
        _lastValidSql = TextBoxSQL.Text

        errorBox1.Show(Nothing, QBuilder.SyntaxProvider)
    End Sub

    Private Sub AddRowToReport(ByVal value As String)
        TextBoxReport.Text = value & Environment.NewLine & TextBoxReport.Text
    End Sub

    Private Sub TextBoxSQL_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBoxSQL.Validating
        ' Feed the text from text editor to the query builder when user exits the editor.
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

    Private Sub QBuilder_QueryColumnListItemAdded(ByVal sender As Object, ByVal item As QueryColumnListItem) Handles QBuilder.QueryColumnListItemAdded
        Dim value = String.Format("QueryColumnListItemAdded. Added the [{0}]", item.ExpressionString)
        AddRowToReport(value)
    End Sub

    Private Sub QBuilder_QueryColumnListItemRemoving(ByVal sender As Object, ByVal item As QueryColumnListItem, ByRef abort As Boolean) Handles QBuilder.QueryColumnListItemRemoving
        If Not cbQueryColumnListItemRemoving.Checked Then
            Return
        End If

        Dim value = String.Format("QueryColumnListItemRemoving. Deleting the [{0}]", item.ExpressionString)
        AddRowToReport(value)

        Dim answer = MessageBox.Show(Me, "Do you want to delete the QueryColumnListItem [" & item.ExpressionString & "]", "QueryColumnListItemRemoving", MessageBoxButtons.YesNo)

        abort = answer = DialogResult.No
    End Sub

    Private Sub ErrorBox1_GoToErrorPosition(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.GoToErrorPosition
        If _errorPosition <> -1 Then
            TextBoxSQL.SelectionStart = _errorPosition
            TextBoxSQL.SelectionLength = 0
            TextBoxSQL.ScrollToCaret()
        End If

        TextBoxSQL.Focus()
    End Sub

    Private Sub ErrorBox1_RevertValidText(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.RevertValidText
        TextBoxSQL.Text = _lastValidSql
        TextBoxSQL.Focus()
    End Sub
End Class
