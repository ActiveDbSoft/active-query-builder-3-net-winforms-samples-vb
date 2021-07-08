''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2021 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

'''******************************************************************
''' * This sample forms demonstrates using of custom expression builder.
''' * When implementing this in your project don't forget to set the
''' * UseCustomExpressionBuilder property of the query builder to true.
''' *******************************************************************
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms

Partial Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        ' set syntax provider
        queryBuilder.SyntaxProvider = New MSSQLSyntaxProvider()

        ' Fill metadata container from the XML file. (For demonstration purposes.)
        Try
            queryBuilder.MetadataLoadingOptions.OfflineMode = True
            queryBuilder.MetadataContainer.ImportFromXML("Northwind.xml")
            queryBuilder.InitializeDatabaseSchemaTree()
            AddHandler queryBuilder.SQLUpdated, AddressOf queryBuilder_SQLUpdated
            queryBuilder.SQL = "SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID," & ControlChars.CrLf & "										[Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount" & ControlChars.CrLf & "									  FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID" & ControlChars.CrLf & "									  WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        MyBase.OnLoad(e)
    End Sub

    Private Sub queryBuilder_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs)
        ' Text of SQL query has been updated by the query builder.

        ' Hide error banner if any
        ShowErrorBanner(textBox1, "")

        textBox1.Text = queryBuilder.FormattedSQL
    End Sub

    Private Sub textBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textBox1.Validating
        Try
            ' Update the query builder with manually edited query text:
            queryBuilder.SQL = textBox1.Text

            ' Hide error banner if any
            ShowErrorBanner(textBox1, "")
        Catch ex As SQLParsingException
            ' Set caret to error position
            textBox1.SelectionStart = ex.ErrorPos.pos

            ' Show banner with error text
            ShowErrorBanner(textBox1, ex.Message)
        End Try
    End Sub


    Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutToolStripMenuItem.Click
        QueryBuilder.ShowAboutDialog()
    End Sub

    Private Sub queryBuilder_CustomExpressionBuilder(ByVal sender As Object, ByVal e As ActiveQueryBuilder.View.QueryView.ExpressionEditorParameters) Handles queryBuilder.CustomExpressionBuilder
        Using f As New CustomExpressionEditor()
            f.textBox.Text = e.OldExpression

            If f.ShowDialog() = DialogResult.OK Then
                ' Update the criteria list with new expression text.
                e.NewExpression = f.textBox.Text
            End If
        End Using
    End Sub

    Public Sub ShowErrorBanner(ByVal control As Control, ByVal text As String)
        ' Destory banner if already showing
        Dim existBanner As Boolean = False
        Dim banners() As Control = control.Controls.Find("ErrorBanner", True)

        If banners.Length > 0 Then
            For Each banner As Control In banners
                If Equals(text, banner.Text) Then
                    existBanner = True
                    Continue For
                End If
                banner.Dispose()
            Next banner
        End If

        If existBanner Then
            Return
        End If

        ' Show new banner if text is not empty
        If Not String.IsNullOrEmpty(text) Then
            Dim label As Label = New Label With {.Name = "ErrorBanner", .Text = text, .BorderStyle = BorderStyle.FixedSingle, .BackColor = Color.LightPink, .AutoSize = True, .Visible = True}

            control.Controls.Add(label)
            label.Location = New Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2)
            label.BringToFront()

            control.Focus()
        End If
    End Sub
End Class
