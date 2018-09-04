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

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()

		' set syntax provider
		QBuilder.SyntaxProvider = New MSSQLSyntaxProvider() With { _
			.ServerVersion = MSSQLServerVersion.MSSQL2012 _
		}

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

	Private Sub queryBuilder1_SQLUpdated(sender As Object, e As EventArgs) Handles QBuilder.SQLUpdated
		' Update the text of SQL query when it's changed in the query builder.
		TextBoxSQL.Text = QBuilder.FormattedSQL
	End Sub

	''' <summary>
	''' The handler checks if the dragged field is a part of the primary key and denies dragging if it's not the case.
	''' </summary>
	Private Sub QBuilder_BeforeDatasourceFieldDrag(dataSource As DataSource, field As MetadataField, ByRef abort As Boolean) Handles QBuilder.BeforeDatasourceFieldDrag
		If CheckBoxBeforeDsFieldDrag.Checked <> True Then
			Return
		End If

		' deny dragging if a field isn't a part of the primary key
		If Not field.PrimaryKey Then
			TextBoxReport.Text = "OnBeforeDatasourceFieldDrag for field """ & Convert.ToString(field.Name) & " "" deny" & Environment.NewLine & TextBoxReport.Text
			abort = True
			Return
		End If

		TextBoxReport.Text = "OnBeforeDatasourceFieldDrag for field """ & Convert.ToString(field.Name) & " "" allow" & Environment.NewLine & TextBoxReport.Text
	End Sub

	''' <summary>
	''' Checking the feasibility of creating a link between the given fields.
	''' </summary>
	Private Sub QBuilder_LinkDragOver(fromDataSource As DataSource, fromField As MetadataField, toDataSource As DataSource, toField As MetadataField, correspondingMetadataForeignKey As MetadataForeignKey, ByRef abort As Boolean) Handles QBuilder.LinkDragOver
		If CheckBoxLinkDragOver.Checked <> True Then
			Return
		End If

		' Allow creation of links between fields of the same data type.
		If fromField.FieldType = toField.FieldType Then
			TextBoxReport.Text = "OnLinkDragOver from field """ & Convert.ToString(fromField.Name) & """ to field """ & Convert.ToString(toField.Name) & """ allow" & Environment.NewLine & TextBoxReport.Text
			Return
		End If

		TextBoxReport.Text = "OnLinkDragOver from field """ & Convert.ToString(fromField.Name) & """ to field """ & Convert.ToString(toField.Name) & """ deny" & Environment.NewLine & TextBoxReport.Text

		abort = True
	End Sub

	Private Sub TextBoxSQL_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxSQL.Validating
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

	Public Sub ShowErrorBanner(ByVal control As Control, ByVal text As String)
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
End Class
