'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

'*******************************************************************
' This sample demonstrates using of various Query Builder events.
'
'*******************************************************************

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
			queryBuilder.SQL = "SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID," & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "[Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount" & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "  FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID" & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "  WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0"

			' Disable the automatic metadata structure creation
			queryBuilder.MetadataStructure.AllowChildAutoItems = False

			Dim filter As MetadataFilterItem

			' Create a top-level folder containing all objects
            Dim allObjects As MetadataStructureItem = New MetadataStructureItem() With {
                .Caption = "All objects",
                .ImageIndex = queryBuilder.DatabaseSchemaViewOptions.ImageIndices.FolderImageIndex
            }
            filter = allObjects.MetadataFilter.Add()
            filter.ObjectTypes = MetadataType.All
            queryBuilder.MetadataStructure.Items.Add(allObjects)

            ' Create "Favorites" folder
            Dim favorites As MetadataStructureItem = New MetadataStructureItem() With {
                .Caption = "Favorites",
                .ImageIndex = queryBuilder.DatabaseSchemaViewOptions.ImageIndices.FolderImageIndex
            }
            queryBuilder.MetadataStructure.Items.Add(favorites)


            ' Add some metadata objects to "Favorites" folder
            Dim metadataItem As MetadataItem = queryBuilder.MetadataContainer.FindItem(Of MetadataItem)("Orders")
            Dim item1 As MetadataStructureItem = New MetadataStructureItem() With {
                .MetadataItem = metadataItem
            }
            favorites.Items.Add(item1)

            metadataItem = queryBuilder.MetadataContainer.FindItem(Of MetadataItem)("Order Details")
            Dim item2 As MetadataStructureItem = New MetadataStructureItem() With {
                .MetadataItem = metadataItem
            }
            favorites.Items.Add(item2)

            ' Create folder with filter
            Dim filteredFolder As New MetadataStructureItem() With {
                .Caption = "Filtered by 'Prod%'",
                .ImageIndex = queryBuilder.DatabaseSchemaViewOptions.ImageIndices.FolderImageIndex
            }
            ' creates dynamic node
            filter = filteredFolder.MetadataFilter.Add()
            filter.ObjectTypes = MetadataType.Table Or MetadataType.View
            filter.[Object] = "Prod%"
            queryBuilder.MetadataStructure.Items.Add(filteredFolder)

            queryBuilder.InitializeDatabaseSchemaTree()
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

    Private Sub textBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
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

    Private Sub tsbMetadataEditor_Click(sender As Object, e As EventArgs)
        QueryBuilder.EditMetadataContainer(queryBuilder.SQLContext)
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
End Class
