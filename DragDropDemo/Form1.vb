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
Imports ActiveQueryBuilder.View

Public Partial Class Form1
	Inherits Form
	Private _dragBoxFromMouseDown As Rectangle = Rectangle.Empty

	Public Sub New()
		InitializeComponent()
	End Sub

	Protected Overrides Sub OnLoad(e As EventArgs)
		' Fill query builder with demo data
		queryBuilder1.SyntaxProvider = New MSSQLSyntaxProvider()
		queryBuilder1.MetadataLoadingOptions.OfflineMode = True
		queryBuilder1.MetadataContainer.ImportFromXML("Northwind.xml")
		queryBuilder1.InitializeDatabaseSchemaTree()

		MyBase.OnLoad(e)
	End Sub

	Private Sub queryBuilder1_SQLUpdated(sender As Object, e As EventArgs)
		' Handle the event raised by SQL Builder object that the text of SQL query is changed

		' Hide error banner if any
		ShowErrorBanner(textBox1, "")

		' update the text box
		textBox1.Text = queryBuilder1.FormattedSQL
	End Sub

	Private Sub textBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
		Try
			' Update the query builder with manually edited query text:
			queryBuilder1.SQL = textBox1.Text

			' Hide error banner if any
			ShowErrorBanner(textBox1, "")
		Catch ex As SQLParsingException
			' Set caret to error position
			textBox1.SelectionStart = ex.ErrorPos.pos

			' Show banner with error text
			ShowErrorBanner(textBox1, ex.Message)
		End Try
	End Sub

	Private Sub listBox1_MouseDown(sender As Object, e As MouseEventArgs)
		' Prepare drag'n'drop:
		If listBox1.SelectedIndex <> -1 Then
			Dim r As Rectangle = listBox1.GetItemRectangle(listBox1.SelectedIndex)

			Dim dragSize As Size = SystemInformation.DragSize

			_dragBoxFromMouseDown = New Rectangle(New Point(e.X - (dragSize.Width \ 2), e.Y - (dragSize.Height \ 2)), dragSize)
		Else
			_dragBoxFromMouseDown = Rectangle.Empty
		End If
	End Sub

	Private Sub listBox1_MouseUp(sender As Object, e As MouseEventArgs)
		_dragBoxFromMouseDown = Rectangle.Empty
	End Sub

	Private Sub listBox1_MouseMove(sender As Object, e As MouseEventArgs)
		' Do drag:

		If listBox1.SelectedIndex <> -1 Then
			If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
				If _dragBoxFromMouseDown <> Rectangle.Empty AndAlso Not _dragBoxFromMouseDown.Contains(e.X, e.Y) Then
					Dim objectName As String = DirectCast(listBox1.SelectedItem, String)
					Dim metadataObject As MetadataObject = queryBuilder1.MetadataContainer.FindItem(Of MetadataObject)(objectName)

					If metadataObject IsNot Nothing Then
						Dim dragObject As New MetadataDragObject()
						dragObject.MetadataDragged.Add(metadataObject)

						listBox1.DoDragDrop(dragObject, DragDropEffects.Copy)
					End If
				End If
			End If
		End If
	End Sub

	Private Sub listBox1_DoubleClick(sender As Object, e As EventArgs)
		' Double click will add the object in automatic position:
		If listBox1.SelectedIndex <> -1 Then
			Dim objectName As [String] = DirectCast(listBox1.SelectedItem, [String])
			queryBuilder1.AddObjectToActiveUnionSubQuery(objectName)
		End If
	End Sub

	Public Sub ShowErrorBanner(ByVal control As Control, ByVal text As String)
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
