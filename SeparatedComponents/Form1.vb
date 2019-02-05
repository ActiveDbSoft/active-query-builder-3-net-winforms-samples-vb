'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Protected Overrides Sub OnLoad(e As EventArgs)
		Try
			' Fill metadata container from the XML file (for demonstration purposes).
			sqlContext1.LoadingOptions.OfflineMode = True
			sqlContext1.MetadataContainer.ImportFromXML("Northwind.xml")

			databaseSchemaView1.InitializeDatabaseSchemaTree()

			sqlQuery1.SQL = "SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID," & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "[Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount" & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "  FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID" & vbCr & vbLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "  WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0"
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try

		MyBase.OnLoad(e)
	End Sub

	Private Sub refreshMetadataMenuItem_Click(sender As Object, e As EventArgs)
		' Force the query builder to refresh metadata from current connection
		' to refresh metadata, just clear MetadataContainer and reinitialize metadata tree

		If sqlContext1.MetadataProvider IsNot Nothing AndAlso sqlContext1.MetadataProvider.Connected Then
			sqlContext1.ClearMetadata()
			databaseSchemaView1.InitializeDatabaseSchemaTree()
		End If
	End Sub

	Private Sub editMetadataMenuItem_Click(sender As Object, e As EventArgs)
		' Open the metadata container editor

		QueryBuilder.EditMetadataContainer(sqlContext1, sqlContext1.LoadingOptions)
	End Sub

	Private Sub clearMetadataMenuItem_Click(sender As Object, e As EventArgs)
		' Clear the metadata

		If MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
			sqlContext1.ClearMetadata()
		End If
	End Sub

	Private Sub loadMetadataFromXMLMenuItem_Click(sender As Object, e As EventArgs)
		' Load metadata from XML file
		If openFileDialog.ShowDialog() = DialogResult.OK Then
			sqlContext1.LoadingOptions.OfflineMode = True
			sqlContext1.MetadataContainer.ImportFromXML(openFileDialog.FileName)
			databaseSchemaView1.InitializeDatabaseSchemaTree()
		End If
	End Sub

	Private Sub saveMetadataToXMLMenuItem_Click(sender As Object, e As EventArgs)
		' Save metadata to XML file
		saveFileDialog.FileName = "Metadata.xml"

		If saveFileDialog.ShowDialog() = DialogResult.OK Then
			sqlContext1.MetadataContainer.LoadAll(True)
			sqlContext1.MetadataContainer.ExportToXML(saveFileDialog.FileName)
		End If
	End Sub

	Private Sub aboutMenuItem_Click(sender As Object, e As EventArgs)
		QueryBuilder.ShowAboutDialog()
	End Sub

	Private Sub sqlQuery_SQLUpdated(sender As Object, e As EventArgs)
		' Handle the event raised by SQL Builder object that the text of SQL query is changed

		' Hide error banner if any
		ShowErrorBanner(sqlTextEditor1, "")

		' update the text box with formatted query text created with default formatting options
		sqlTextEditor1.Text = FormattedSQLBuilder.GetSQL(sqlQuery1.QueryRoot, New SQLFormattingOptions())
	End Sub

	Public Sub ResetQueryBuilder()
		sqlContext1.ClearMetadata()
		sqlContext1.MetadataProvider = Nothing
		sqlContext1.SyntaxProvider = Nothing
		sqlContext1.LoadingOptions.OfflineMode = False
	End Sub

	Private Sub sqlTextEditor1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
		Try
			' Update the query builder with manually edited query text:
			sqlQuery1.SQL = sqlTextEditor1.Text

			' Hide error banner if any
			ShowErrorBanner(sqlTextEditor1, "")
		Catch ex As SQLParsingException
			' Set caret to error position
			sqlTextEditor1.SelectionStart = ex.ErrorPos.pos

			' Show banner with error text
			ShowErrorBanner(sqlTextEditor1, ex.Message)
		End Try
	End Sub

	Private Sub queryStatisticsMenuItem_Click(sender As Object, e As EventArgs)
		Dim builder As New StringBuilder()

		Dim queryStatistics As QueryStatistics = sqlQuery1.QueryStatistics

		builder.Append("Used Objects (").Append(queryStatistics.UsedDatabaseObjects.Count).AppendLine("):")
		builder.AppendLine()

		For i As Integer = 0 To queryStatistics.UsedDatabaseObjects.Count - 1
			builder.AppendLine(queryStatistics.UsedDatabaseObjects(i).ObjectName.QualifiedName)
		Next

		builder.AppendLine().AppendLine()
		builder.Append("Used Columns (").Append(queryStatistics.UsedDatabaseObjectFields.Count).AppendLine("):")
		builder.AppendLine()

		For i As Integer = 0 To queryStatistics.UsedDatabaseObjectFields.Count - 1
			builder.AppendLine(queryStatistics.UsedDatabaseObjectFields(i).ObjectName.QualifiedName)
		Next

		builder.AppendLine().AppendLine()
		builder.Append("Output Expressions (").Append(queryStatistics.OutputColumns.Count).AppendLine("):")
		builder.AppendLine()

		For i As Integer = 0 To queryStatistics.OutputColumns.Count - 1
			builder.AppendLine(queryStatistics.OutputColumns(i).Expression)
		Next

		MessageBox.Show(builder.ToString())
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
