''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2021 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.NavigationBar
Imports ActiveQueryBuilder.View.QueryView
Imports ActiveQueryBuilder.View.WinForms.QueryView


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
            QBuilder.MetadataLoadingOptions.OfflineMode = True
            QBuilder.MetadataContainer.ImportFromXML("Northwind.xml")
            QBuilder.InitializeDatabaseSchemaTree()

            QBuilder.SQL = "SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID," & ControlChars.CrLf & "										[Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount" & ControlChars.CrLf & "									  FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID" & ControlChars.CrLf & "									  WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub QBuilder_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs) Handles QBuilder.SQLUpdated
        errorBox1.Show(Nothing, QBuilder.SyntaxProvider)
        ' Update the text of SQL query when it's changed in the query builder.
        TextBoxSQL.Text = QBuilder.FormattedSQL
        _lastValidSql = TextBoxSQL.Text
    End Sub

    Private Sub QBuilder_QueryElementControlCreated(ByVal owner As QueryElement, ByVal control As IQueryElementControl) Handles QBuilder.QueryElementControlCreated
        If QElementCreated.Checked <> True Then
            Return
        End If

        TextBoxReport.Text = "QueryElementControl Created """ & CType(control, Object).GetType().Name & """" & Environment.NewLine & TextBoxReport.Text

        If TypeOf control Is DataSourceControl Then
            Dim cont = CType(control, DataSourceControl)
            AddHandler cont.FieldListDrawItem, AddressOf cont_FieldListDrawItem
        End If
    End Sub

    Private Sub cont_FieldListDrawItem(ByVal drawingContext As Object, ByVal rect As CRectangle, ByVal state As CDrawItemState, ByVal field As MetadataField, ByRef handled As Boolean)
        Dim context = CType(drawingContext, Graphics)
        If field Is Nothing OrElse (Not field.PrimaryKey) Then
            Return
        End If

        handled = True

        context.FillRectangle(Brushes.White, New Rectangle(New Point(CInt(Fix(rect.X)), CInt(Fix(rect.Y))), New Size(CInt(Fix(rect.Width)), CInt(Fix(rect.Height)))))

        If ((CDrawItemState.Selected And state)) <> 0 AndAlso (CDrawItemState.Focus And state) <> 0 Then
            context.FillRectangle(Brushes.DodgerBlue, New Rectangle(New Point(CInt(Fix(rect.X)), CInt(Fix(rect.Y))), New Size(CInt(Fix(rect.Width)), CInt(Fix(rect.Height)))))
            context.DrawRectangle(New Pen(Color.Black) With {.DashStyle = DashStyle.Dot}, New Rectangle(New Point(CInt(Fix(rect.X)), CInt(Fix(rect.Y))), New Size(CInt(Fix(rect.Width)), CInt(Fix(rect.Height)) - 1)))
        Else
            If (CDrawItemState.Selected And state) <> 0 AndAlso (CDrawItemState.Focus And state) = 0 Then
                context.FillRectangle(Brushes.DodgerBlue, New Rectangle(New Point(CInt(Fix(rect.X)), CInt(Fix(rect.Y))), New Size(CInt(Fix(rect.Width)), CInt(Fix(rect.Height)))))
            End If
        End If

        Dim imageKey = CType(QBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon, Bitmap)

        context.DrawImage(imageKey, New Point(CInt(Fix(rect.X)) + 3, CInt(Fix(rect.Y))))

        Const textFormatFlags As TextFormatFlags = TextFormatFlags.NoClipping Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoPrefix

        Dim colorText = If((CDrawItemState.Selected And state) <> 0, Color.White, Color.Gray)
        Dim font = New Font(DefaultFont.FontFamily, DefaultFont.Size)
        Dim text = "(" & field.FieldTypeName & ") " & field.Name
        Dim textSize = TextRenderer.MeasureText(text, font)

        TextRenderer.DrawText(context, text, font, New Rectangle(New Point(CInt(Fix(rect.X)) + imageKey.Width + 2, CInt(Fix(rect.Y))), New Size(textSize.Width, CInt(Fix(rect.Height)))), colorText, textFormatFlags)
    End Sub

    Private Sub QBuilder_QueryElementControlDestroying(ByVal owner As QueryElement, ByVal control As IQueryElementControl) Handles QBuilder.QueryElementControlDestroying
        If QElementDestroying.Checked <> True Then
            Return
        End If
        TextBoxReport.Text = "QueryElementControl Destroying """ & CType(control, Object).GetType().Name & """" & Environment.NewLine & TextBoxReport.Text

        If Not(TypeOf control Is DataSourceControl) Then
            Return
        End If

        Dim cntr = CType(control, DataSourceControl)
        RemoveHandler cntr.FieldListDrawItem, AddressOf cont_FieldListDrawItem
    End Sub

    ''' <summary>
    ''' ValidateContextMenu event allows to modify or hide any query builder context menu.
    ''' </summary>
    Private Sub QBuilder_ValidateContextMenu(ByVal sender As Object, ByVal queryelement As QueryElement, ByVal menu As ICustomContextMenu) Handles QBuilder.ValidateContextMenu
        If ValidateContextMenu.Checked <> True Then
            Return
        End If

        TextBoxReport.Text = "OnValidateContextMenu" & Environment.NewLine & TextBoxReport.Text
        ' Insert custom menu item to the top of any context menu
        menu.InsertItem(0, "Custom Item 1", AddressOf CustomItem1EventHandler)
        menu.InsertSeparator(1) ' separator

        If TypeOf queryelement Is Link Then ' Link context menu
            ' Add another item in the Link's menu
            menu.AddSeparator() ' separator
            menu.AddItem("Custom Item 2", AddressOf CustomItem2EventHandler)
        ElseIf TypeOf queryelement Is DataSourceObject Then ' Datasource context menu
        ElseIf TypeOf queryelement Is UnionSubQuery Then
            If TypeOf sender Is IDesignPaneControl Then ' diagram pane context menu
            ElseIf TypeOf sender Is NavigationPopupBase Then
            End If
        ElseIf TypeOf queryelement Is QueryColumnListItem Then ' QueryColumnListControl context menu
            Dim queryColumnListItem = CType(queryelement, QueryColumnListItem)
            Dim point = QBuilder.QueryColumnListControl.PointToClient(New CPoint(MousePosition.X, MousePosition.Y))
            Dim queryColumnListHitTestInfo = QBuilder.QueryColumnListControl.HitTest(New CPoint(point.X, point.Y))

            Select Case queryColumnListHitTestInfo.ItemProperty
                Case QueryColumnListItemProperty.Expression
                    menu.AddSeparator()
                    Dim menuItemExpression = menu.AddSubMenu("Expression property")
                    menuItemExpression.AddItem("Show full SQL", AddressOf ExpressionColumnEventHandler, False, True, Nothing, queryColumnListItem.Expression.GetSQL())
                Case QueryColumnListItemProperty.Selected, QueryColumnListItemProperty.Alias, QueryColumnListItemProperty.SortType, QueryColumnListItemProperty.SortOrder, QueryColumnListItemProperty.Aggregate, QueryColumnListItemProperty.Grouping, QueryColumnListItemProperty.ConditionType, QueryColumnListItemProperty.Condition, QueryColumnListItemProperty.Custom
                    menu.AddSeparator()
                    menu.AddItem("Get info of current cell", Sub(o, args)
                        Dim message = $"Item property [{queryColumnListHitTestInfo.ItemProperty}]" & vbLf & "Item index[{queryColumnListHitTestInfo.ItemIndex}]" & vbLf & "Condition index[{queryColumnListHitTestInfo.ConditionIndex}]" & vbLf & "Is now here[{queryColumnListHitTestInfo.IsNowhere}]"
                        MessageBox.Show(Me, message, "Information")
                    End Sub)
                Case Else
                    Throw New ArgumentOutOfRangeException()
            End Select
        End If
    End Sub

    Private Sub ExpressionColumnEventHandler(ByVal o As Object, ByVal eventArgs As EventArgs)
        Dim menuItem = CType(o, ICustomMenuItem)

        MessageBox.Show(menuItem.Tag.ToString())
    End Sub

    Private Sub QBuilder_CustomizeDataSourceCaption(ByVal dataSource As DataSource, ByRef caption As String) Handles QBuilder.CustomizeDataSourceCaption
        If CustomizeDataSourceCaption.Checked <> True Then
            Return
        End If

        TextBoxReport.Text = "CustomizeDataSourceCaption for """ & caption & """" & Environment.NewLine & TextBoxReport.Text
        caption = caption.ToUpper(CultureInfo.CurrentCulture)
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

    Private Shared Sub CustomItem1EventHandler(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show("Custom Item 1")
    End Sub

    Private Shared Sub CustomItem2EventHandler(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show("Custom Item 2")
    End Sub

    Private Sub QBuilder_CustomizeDataSourceFieldList(ByVal dataSource As DataSource, ByVal fieldList As List(Of FieldListItemData)) Handles QBuilder.CustomizeDataSourceFieldList
        If CustomizeDataSourceFieldList.Checked <> True Then
            Return
        End If

        TextBoxReport.Text = "CustomizeDataSourceFieldList" & Environment.NewLine & TextBoxReport.Text

        Dim comparer = New FieldComparerByName()
        fieldList.Sort(comparer)
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

Public Class FieldComparerByName
    Implements IComparer(Of FieldListItemData)
    Public Function Compare(ByVal x As FieldListItemData, ByVal y As FieldListItemData) As Integer Implements IComparer(Of FieldListItemData).Compare
        Return String.Compare(x.Name.ToLower(CultureInfo.CurrentCulture), y.Name.ToLower(CultureInfo.CurrentCulture), StringComparison.Ordinal)
    End Function
End Class
