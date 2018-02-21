'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

'*******************************************************************
' * This sample forms demonstrates using of custom expression builder.
' * When implementing this in your project don't forget to set the
' * UseCustomExpressionBuilder property of the query builder to true.
' *******************************************************************


Imports System.Drawing
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Protected Overrides Sub OnLoad(e As EventArgs)
		' set syntax provider
		queryBuilder.SyntaxProvider = New MSSQLSyntaxProvider()

		' Fill metadata container from the XML file. (For demonstration purposes.)
		Try
			queryBuilder.MetadataLoadingOptions.OfflineMode = True
			queryBuilder.MetadataContainer.ImportFromXML("Northwind.xml")
			queryBuilder.InitializeDatabaseSchemaTree()
			AddHandler queryBuilder.SQLUpdated, AddressOf queryBuilder_SQLUpdated
			queryBuilder.SQL = "SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID," & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "[Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount" & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "  FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID" & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "  WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0"
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try

		MyBase.OnLoad(e)
	End Sub

	Private Sub queryBuilder_SQLUpdated(sender As Object, e As EventArgs)
		' Text of SQL query has been updated by the query builder.

		' Hide error banner if any
		ShowErrorBanner(textBox1, "")

		textBox1.Text = queryBuilder.FormattedSQL
	End Sub

    Private Sub textBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles textBox1.Validating
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
    Private Sub queryBuilder_CustomExpressionBuilder(queryColumnListItem As QueryColumnListItem, conditionIndex As Integer, expression As String) Handles queryBuilder.CustomExpressionBuilder
        Using f As New CustomExpressionEditor()
            f.textBox.Text = expression

            If f.ShowDialog() = DialogResult.OK Then
                ' Update the criteria list with new expression text.

                If conditionIndex > -1 Then
                    ' it's one of condition columns
                    queryColumnListItem.ConditionStrings(conditionIndex) = f.textBox.Text
                Else
                    ' it's the Expression column
                    queryColumnListItem.ExpressionString = f.textBox.Text
                End If
            End If
        End Using
    End Sub

	Public Sub ShowErrorBanner(control As Control, text As [String])
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
		If Not [String].IsNullOrEmpty(text) Then
            Dim label As New Label() With {
                .Name = "ErrorBanner",
                .Text = text,
                .BorderStyle = BorderStyle.FixedSingle,
                .BackColor = Color.LightPink,
                .AutoSize = True,
                .Visible = True
            }

			control.Controls.Add(label)
			label.Location = New Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2)
			control.Focus()
		End If
	End Sub

    Private Sub aboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles aboutToolStripMenuItem.Click
        queryBuilder.ShowAboutDialog()
    End Sub
End Class
