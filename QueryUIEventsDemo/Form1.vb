'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Drawing
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.QueryView

Partial Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()

        ' set syntax provider
        QBuilder.SyntaxProvider = New MSSQLSyntaxProvider()

        ' Fill metadata container from the XML file. (For demonstration purposes.)
        Try
            QBuilder.MetadataLoadingOptions.OfflineMode = True
            QBuilder.MetadataContainer.ImportFromXML("Northwind.xml")
            QBuilder.InitializeDatabaseSchemaTree()
            QBuilder.SQL = "SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID," & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "[Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount" & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "  FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID" & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "  WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub QBuilder_DataSourceAdded(sender As SQLQuery, addedObject As DataSource) Handles QBuilder.DataSourceAdded
        If CbDataSourceAdded.Checked <> True Then
            Return
        End If
        AddRowToReport("DataSourceAdded. Object caption """ & addedObject.MetadataObject.Name & """")
    End Sub

    ''' <summary>
    ''' Prompts the user if he/she really wants to add an object to the query.
    ''' </summary>
    Private Sub QBuilder_DataSourceAdding(fromObject As MetadataObject, ByRef abort As Boolean) Handles QBuilder.DataSourceAdding
        If Not CbDataSourceAdding.Checked Then
            Return
        End If

        AddRowToReport("DataSourceAdding. Object caption """ & fromObject.Name & """")

        Dim nameInQuery As String = fromObject.Name
        Dim msg As String = "Do you want to add the object """ & nameInQuery & """ on the diagram pane?"

        If MessageBox.Show(msg, "DataSourceAdding event handler", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    ''' <summary>
    ''' Displays a prompt on deleting an object from the query.
    ''' </summary>
    Private Sub QBuilder_DataSourceDeleting(dataSource As DataSource, ByRef abort As Boolean) Handles QBuilder.DataSourceDeleting
        If CbDataSourceDeleting.Checked <> True Then
            Return
        End If
        Dim nameInQuery As String = dataSource.NameInQuery
        Dim msg As String = "Do you want to remove the object """ & nameInQuery & """ on the diagram pane?"

        If MessageBox.Show(msg, "DataSourceDeleting event handler", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    Private Sub QBuilder_DataSourceFieldAdded(dataSource As DataSource, field As MetadataField, queryColumnListItem As QueryColumnListItem, focusCondition As Boolean) Handles QBuilder.DataSourceFieldAdded
        If CbDataSourceFieldAdded.Checked <> True Then
            Return
        End If
        AddRowToReport("DataSourceFieldAdded """ & field.Name & """")
    End Sub

    '
    ' DatasourceFieldAdding event allows to prevent selecting of a field.
    '
    Private Sub QBuilder_DataSourceFieldAdding(dataSource As DataSource, field As MetadataField, ByRef abort As Boolean) Handles QBuilder.DataSourceFieldAdding
        If Not CbDataSourceFieldAdding.Checked Then
            Return
        End If

        AddRowToReport("DataSourceFieldAdding. Field name """ & field.Name & """")
        Dim msg As String = "Do you want to add the field """ & field.Name & """ to the query?"

        If MessageBox.Show(msg, "DatasourceFieldAdding event handler", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    Private Sub QBuilder_DatasourceFieldRemoved(dataSource As DataSource, field As MetadataField) Handles QBuilder.DatasourceFieldRemoved
        If CbDatasourceFieldRemoved.Checked <> True Then
            Return
        End If
        AddRowToReport("DatasourceFieldRemoved """ & field.Name & """")
    End Sub

    Private Sub QBuilder_DataSourceFieldRemoving(dataSource As DataSource, field As MetadataField, ByRef abort As Boolean) Handles QBuilder.DataSourceFieldRemoving
        If CbDataSourceFieldRemoving.Checked <> True Then
            Return
        End If
        AddRowToReport("DataSourceFieldRemoving removing field """ & field.Name & """ form """ & dataSource.NameInQuery & """")

        Dim nameInQuery As String = dataSource.NameInQuery
        Dim msg As String = "Do you want to uncheck field """ & field.Name & """ in the object """ & nameInQuery & """?"

        If MessageBox.Show(msg, "DataSourceFieldRemoving event handler", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    Private Sub QBuilder_QueryColumnListItemChanged(queryColumnList As QueryColumnList, queryColumnListItem As QueryColumnListItem, [property] As QueryColumnListItemProperty, conditionIndex As Integer, newValue As Object) Handles QBuilder.QueryColumnListItemChanged
        If CbQueryColumnListItemChanged.Checked <> True Then
            Return
        End If

        AddRowToReport("QueryColumnListItemChanged property """ & Convert.ToString([property]) & """ changed")
    End Sub

    '
    ' GridCellValueChanging event allows to prevent the cell value changing or modify the new cell value.
    ' Note: Some columns hide/unhide dynamically but this does not affect the column index in the event parameters -
    '       it includes hidden columns.
    ' private void queryBuilder1_GridCellValueChanging(UnionSubQuery unionSubQuery, QueryColumnList criteriaList, QueryColumnListItem criteriaItem, int column, int row, object oldValue, ref object newValue, ref bool abort)
    Private Sub QBuilder_QueryColumnListItemChanging(queryColumnList As QueryColumnList, queryColumnListItem As QueryColumnListItem, [property] As QueryColumnListItemProperty, conditionIndex As Integer, oldValue As Object, ByRef newValue As Object,
        ByRef abort As Boolean) Handles QBuilder.QueryColumnListItemChanging
        If Not CbQueryColumnListItemChanging.Checked Then
            Return
        End If

        AddRowToReport("QueryColumnListItemChanging. Changes column """ & Convert.ToString([property]) & """")

        If [property] = QueryColumnListItemProperty.Expression Then
            ' Prevent changes in the Expression column.
            abort = True
        ElseIf [property] = QueryColumnListItemProperty.[Alias] Then
            ' Alias column. Lets add the underscore char in the beginning of all aliases, for example.
            If newValue IsNot Nothing AndAlso TypeOf newValue Is String Then
                Dim s As String = DirectCast(newValue, String)

                If s.Length > 0 AndAlso Not s.StartsWith("_") Then
                    s = "_" & s
                    newValue = s
                End If
            End If
        End If
    End Sub

    Private Sub QBuilder_LinkChanged(link As Link) Handles QBuilder.LinkChanged
        If CbLinkChanged.Checked <> True Then
            Return
        End If
        Dim value As String = String.Format("LinkChanging. Changing the link between {0}.{1} and {2}.{3}", link.LeftDataSource.MetadataObject.Name, link.LeftField, link.RightDataSource.MetadataObject.Name, link.RightField)
        AddRowToReport(value)
    End Sub

    Private Sub QBuilder_LinkChanging(link As Link, ByRef abort As Boolean) Handles QBuilder.LinkChanging
        If CbLinkChanging.Checked = True Then
            AddRowToReport("""LinkChanging"" deny")

            'deny changing properties of the Link
            abort = True
            Return
        End If

        AddRowToReport("""LinkChanging"" allow")
    End Sub

    Private Sub QBuilder_LinkCreated(sender As SQLQuery, link As Link) Handles QBuilder.LinkCreated
        Dim value As String = String.Format("LinkCreated. Created the link between {0}.{1} and {2}.{3}", link.LeftDataSource.MetadataObject.Name, link.LeftField, link.RightDataSource.MetadataObject.Name, link.RightField)
        AddRowToReport(value)
    End Sub

    '
    ' LinkCreating event allows to prevent link creation
    '
    Private Sub QBuilder_LinkCreating(fromDataSource As DataSource, fromField As MetadataField, toDataSource As DataSource, toField As MetadataField, correspondingMetadataForeignKey As MetadataForeignKey, ByRef abort As Boolean) Handles QBuilder.LinkCreating
        If Not CbLinkCreating.Checked Then
            Return
        End If

        Dim value As String = String.Format("LinkCreating. Creating the link between {0}.{1} and {2}.{3}", fromDataSource.MetadataObject.Name, fromField.Name, toDataSource.MetadataObject.Name, toField.Name)
        AddRowToReport(value)

        Dim msg As String = [String].Format("Do you want to create the link between {0}.{1} and {2}.{3}?", fromDataSource.MetadataObject.Name, fromField.Name, toDataSource.MetadataObject.Name, toField.Name)

        If MessageBox.Show(msg, "LinkCreating event handler", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    '
    ' LinkDeleting event allows to prevent link deletion.
    '
    Private Sub QBuilder_LinkDeleting(link As Link, ByRef abort As Boolean) Handles QBuilder.LinkDeleting
        If Not CbLinkDeleting.Checked Then
            Return
        End If

        Dim value As String = [String].Format("LinkDeleting. Deleting the link between ""{2}.{0}"" and ""{3}.{1}""", link.LeftField, link.RightField, link.LeftDataSource.MetadataObject.Name, link.RightDataSource.MetadataObject.Name)
        AddRowToReport(value)

        Dim msg As String = [String].Format("Do you want to delete the link between ""{2}.{0}"" and ""{3}.{1}""", link.LeftField, link.RightField, link.LeftDataSource.MetadataObject.Name, link.RightDataSource.MetadataObject.Name)

        If MessageBox.Show(msg, "LinkDeleting event handler", MessageBoxButtons.YesNo) = DialogResult.No Then
            abort = True
        End If
    End Sub

    Private Sub QBuilder_SQLUpdated(sender As Object, e As EventArgs) Handles QBuilder.SQLUpdated
        ' Update the text of SQL query when it's changed in the query builder.
        TextBoxSQL.Text = QBuilder.FormattedSQL
    End Sub

    Public Sub ShowErrorBanner(ByVal control As Control, ByVal text As String)
		' Display error banner if passed text is not empty
        ' Destory banner if already showing
		If True Then
			Dim existBanner As Boolean = False
			Dim banners As Control() = control.Controls.Find("ErrorBanner", True)

			If banners.Length > 0 Then

				For Each banner As Control In banners

					If Equals(text, banner.Text) Then
						existBanner = True
						Continue For
					End If

					banner.Dispose()
				Next
			End If

			If existBanner Then Return
		End If

		' Show new banner if text is not empty
		If Not String.IsNullOrEmpty(text) Then
			Dim label As Label = New Label With {
				.Name = "ErrorBanner",
				.Text = text,
				.BorderStyle = BorderStyle.FixedSingle,
				.BackColor = Color.LightPink,
				.AutoSize = True,
				.Visible = True
			}
			control.Controls.Add(label)
			label.Location = New Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2)
			label.BringToFront()
			control.Focus()
		End If
	End Sub

    Private Sub AddRowToReport(value As String)
        TextBoxReport.Text = value & Environment.NewLine & TextBoxReport.Text
    End Sub

    Private Sub TextBoxSQL_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxSQL.Validating
        ' Feed the text from text editor to the query builder when user exits the editor.
        Try
            ' Update the query builder with manually edited query text:
            QBuilder.SQL = QBuilder.Text

            ' Hide error banner if any
            ShowErrorBanner(TextBoxSQL, "")
        Catch ex As SQLParsingException
            ' Set caret to error position
            TextBoxSQL.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            ShowErrorBanner(TextBoxSQL, ex.Message)
        End Try
    End Sub

    Private Sub QBuilder_QueryColumnListItemAdded(sender As Object, item As QueryColumnListItem) Handles QBuilder.QueryColumnListItemAdded
        Dim value As String = String.Format("QueryColumnListItemAdded. Added the [{0}]", item.ExpressionString)
        AddRowToReport(value)
    End Sub

    Private Sub QBuilder_QueryColumnListItemRemoving(sender As Object, item As QueryColumnListItem, ByRef abort As Boolean) Handles QBuilder.QueryColumnListItemRemoving
        If Not cbQueryColumnListItemRemoving.Checked Then
            Return
        End If

        Dim value As String = String.Format("QueryColumnListItemRemoving. Deleting the [{0}]", item.ExpressionString)
        AddRowToReport(value)

        Dim answer As DialogResult = MessageBox.Show(Me, "Do you want to delete the QueryColumnListItem [" & item.ExpressionString & "]", "QueryColumnListItemRemoving", MessageBoxButtons.YesNo)

        abort = answer = DialogResult.No
    End Sub
End Class
