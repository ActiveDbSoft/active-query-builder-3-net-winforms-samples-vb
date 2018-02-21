'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.NavigationBar
Imports ActiveQueryBuilder.View.QueryView
Imports ActiveQueryBuilder.View.WinForms.QueryView

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

    Private Sub QBuilder_SQLUpdated(sender As Object, e As EventArgs) Handles QBuilder.SQLUpdated
        ' Update the text of SQL query when it's changed in the query builder.
        TextBoxSQL.Text = QBuilder.FormattedSQL
    End Sub

    Private Sub QBuilder_QueryElementControlCreated(owner As QueryElement, control As IQueryElementControl) Handles QBuilder.QueryElementControlCreated
        If QElementCreated.Checked <> True Then
            Return
        End If

        TextBoxReport.Text = "QueryElementControl Created """ & control.[GetType]().Name & """" & Environment.NewLine & TextBoxReport.Text

        If TypeOf control Is DataSourceControl Then
            Dim cont As DataSourceControl = DirectCast(control, DataSourceControl)
            AddHandler cont.FieldListDrawItem, AddressOf cont_FieldListDrawItem
        End If
    End Sub

    Private Sub cont_FieldListDrawItem(drawingContext As Object, rect As CRectangle, state As CDrawItemState, field As MetadataField, ByRef handled As Boolean)
        Dim context As Graphics = DirectCast(drawingContext, Graphics)
        If field Is Nothing OrElse Not field.PrimaryKey Then
            Return
        End If

        handled = True

        context.FillRectangle(Brushes.White, New Rectangle(New Point(rect.X, rect.Y), New Size(rect.Width, rect.Height)))

        If ((CDrawItemState.Selected And state)) <> 0 AndAlso (CDrawItemState.Focus And state) <> 0 Then
            context.FillRectangle(Brushes.DodgerBlue, New Rectangle(New Point(rect.X, rect.Y), New Size(rect.Width, rect.Height)))
            context.DrawRectangle(New Pen(Color.Black) With {
                .DashStyle = DashStyle.Dot
            }, New Rectangle(New Point(rect.X, rect.Y), New Size(rect.Width, rect.Height - 1)))
        Else
            If (CDrawItemState.Selected And state) <> 0 AndAlso (CDrawItemState.Focus And state) = 0 Then
                context.FillRectangle(Brushes.DodgerBlue, New Rectangle(New Point(rect.X, rect.Y), New Size(rect.Width, rect.Height)))
            End If
        End If

        Dim imageKey As Bitmap = DirectCast(QBuilder.DataSourceOptions.MarkColumnOptions.PrimaryKeyIcon, Bitmap)

        context.DrawImage(imageKey, New Point(rect.X + 3, rect.Y))

        Const textFormatFlags1 As TextFormatFlags = TextFormatFlags.NoClipping Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoPrefix

        Dim colorText As Color = If((CDrawItemState.Selected And state) <> 0, Color.White, Color.Gray)
        Dim font As Font = New Font(DefaultFont.FontFamily, DefaultFont.Size)
        Dim text As String = "(" & field.FieldTypeName & ") " & field.Name
        Dim textSize As Size = TextRenderer.MeasureText(text, font)

        TextRenderer.DrawText(context, text, font, New Rectangle(New Point(rect.X + imageKey.Width + 2, rect.Y), New Size(textSize.Width, rect.Height)), colorText, textFormatFlags1)
    End Sub

    Private Sub QBuilder_QueryElementControlDestroying(owner As QueryElement, control As IQueryElementControl) Handles QBuilder.QueryElementControlDestroying
        If QElementDestroying.Checked <> True Then
            Return
        End If
        TextBoxReport.Text = "QueryElementControl Destroying """ & control.GetType().Name & """" & Environment.NewLine & TextBoxReport.Text

        If Not (TypeOf control Is DataSourceControl) Then
            Return
        End If

        Dim cntr As DataSourceControl = DirectCast(control, DataSourceControl)
        RemoveHandler cntr.FieldListDrawItem, AddressOf cont_FieldListDrawItem
    End Sub

    ''' <summary>
    ''' ValidateContextMenu event allows to modify or hide any query builder context menu.
    ''' </summary>
    Private Sub QBuilder_ValidateContextMenu(sender As Object, queryelement As QueryElement, menu As ICustomContextMenu) Handles QBuilder.ValidateContextMenu
        If ValidateContextMenu.Checked <> True Then
            Return
        End If

        TextBoxReport.Text = "OnValidateContextMenu" & Environment.NewLine & TextBoxReport.Text
        ' Insert custom menu item to the top of any context menu
        menu.InsertItem(0, "Custom Item 1", AddressOf CustomItem1EventHandler)
        menu.InsertSeparator(1)
        ' separator
        If TypeOf queryelement Is Link Then
            ' Link context menu
            ' Add another item in the Link's menu
            menu.AddSeparator()
            ' separator
            menu.AddItem("Custom Item 2", AddressOf CustomItem2EventHandler)
        ElseIf TypeOf queryelement Is DataSourceObject Then
            ' Datasource context menu
        ElseIf TypeOf queryelement Is UnionSubQuery Then
            If TypeOf sender Is IDesignPaneControl Then
                ' diagram pane context menu
            ElseIf TypeOf sender Is NavigationPopupBase Then
            End If
        ElseIf TypeOf queryelement Is QueryColumnListItem Then
            ' QueryColumnListControl context menu
            menu.ClearItems()
        End If
    End Sub

    Private Sub QBuilder_CustomizeDataSourceCaption(dataSource As DataSource, ByRef caption As String) Handles QBuilder.CustomizeDataSourceCaption
        If CustomizeDataSourceCaption.Checked <> True Then
            Return
        End If

        TextBoxReport.Text = "CustomizeDataSourceCaption for """ & caption & """" & Environment.NewLine & TextBoxReport.Text
        caption = caption.ToUpper(CultureInfo.CurrentCulture)
    End Sub

    Private Sub TextBoxSQL_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxSQL.Validating
        ' Feed the text from text editor to the query builder when user exits the editor.
        Try
            ' Update the query builder with manually edited query text:
            QBuilder.SQL = TextBoxSQL.Text

            ' Hide error banner if any
            ShowErrorBanner(TextBoxSQL, "")
        Catch ex As SQLParsingException
            ' Set caret to error position
            TextBoxSQL.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            ShowErrorBanner(TextBoxSQL, ex.Message)
        End Try
    End Sub

    Private Shared Sub ShowErrorBanner(control As Control, text As String)
        ' Display error banner if passed text is not empty
        ' Destory banner if already showing
        If True Then
            Dim banners As Control() = control.Controls.Find("ErrorBanner", True)

            If banners.Length > 0 Then
                For Each banner As Control In banners
                    banner.Dispose()
                Next
            End If
        End If

        ' Show new banner if text is not empty
        If Not String.IsNullOrEmpty(text) Then
            Dim label As Label = New Label() With {
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

    Private Shared Sub CustomItem1EventHandler(sender As Object, e As EventArgs)
        MessageBox.Show("Custom Item 1")
    End Sub

    Private Shared Sub CustomItem2EventHandler(sender As Object, e As EventArgs)
        MessageBox.Show("Custom Item 2")
    End Sub

    Private Sub QBuilder_CustomizeDataSourceFieldList(dataSource As DataSource, fieldList As List(Of FieldListItemData))
        If CustomizeDataSourceFieldList.Checked <> True Then
            Return
        End If

        TextBoxReport.Text = "CustomizeDataSourceFieldList" & Environment.NewLine & TextBoxReport.Text

        Dim comparer As FieldComparerByName = New FieldComparerByName()
        fieldList.Sort(comparer)
    End Sub
End Class

Public Class FieldComparerByName
    Implements IComparer(Of FieldListItemData)
    Public Function Compare(x As FieldListItemData, y As FieldListItemData) As Integer Implements IComparer(Of FieldListItemData).Compare
        Return String.Compare(x.Name.ToLower(CultureInfo.CurrentCulture), y.Name.ToLower(CultureInfo.CurrentCulture), StringComparison.Ordinal)
    End Function
End Class
