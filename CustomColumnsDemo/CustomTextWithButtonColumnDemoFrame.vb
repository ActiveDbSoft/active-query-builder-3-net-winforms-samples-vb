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
Imports System.Windows.Forms

Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.QueryView
Imports ActiveQueryBuilder.View.WinForms.QueryView

Public Partial Class CustomTextWithButtonColumnDemoFrame
	Inherits UserControl
	Private ReadOnly _customValuesProvider As New List(Of String)()

	Public Sub New()
		InitializeComponent()

		' Fill query builder with demo data
		queryBuilder1.SyntaxProvider = New MSSQLSyntaxProvider()
		queryBuilder1.MetadataLoadingOptions.OfflineMode = True
		queryBuilder1.MetadataContainer.ImportFromXML("Northwind.xml")
		queryBuilder1.InitializeDatabaseSchemaTree()
		queryBuilder1.SQL = "select OrderID, CustomerID, OrderDate from Orders"

		' Fill custom values source (for demo purposes)
		For i As Integer = 0 To 99
			_customValuesProvider.Add("Some Value " & i)
		Next
	End Sub

	Private Sub queryBuilder1_QueryElementControlCreated(queryElement As QueryElement, queryElementControl As IQueryElementControl)
		If TypeOf queryElementControl Is IQueryColumnListControl Then
			Dim queryColumnListControl As IQueryColumnListControl = DirectCast(queryElementControl, IQueryColumnListControl)
			Dim dataGridView As DataGridView = DirectCast(queryColumnListControl.DataGrid, DataGridView)

			' Create custom column
			Dim customColumn As New TextBoxWithButtonColumn()
			customColumn.Name = "CustomColumn"
			customColumn.HeaderText = "Custom Column"
			customColumn.Width = 200
			customColumn.ValueType = GetType(String)
			customColumn.HeaderCell.Style.Font = New Font("Tahoma", 8, FontStyle.Bold)
			customColumn.ShowButton = True

			' Insert custom column to specified position
			dataGridView.Columns.Insert(2, customColumn)

			' Handle requierd events
			AddHandler dataGridView.CellBeginEdit, AddressOf DataGridView_CellBeginEdit
			AddHandler dataGridView.CellValueNeeded, AddressOf DataGridView_CellValueNeeded
			AddHandler dataGridView.CellValuePushed, AddressOf DataGridView_CellValuePushed
			AddHandler dataGridView.EditingControlShowing, AddressOf DataGridView_EditingControlShowing
		End If
	End Sub

	Private Sub queryBuilder1_QueryElementControlDestroying(queryElement As QueryElement, queryElementControl As IQueryElementControl)
		If TypeOf queryElementControl Is IQueryColumnListControl Then
			Dim queryColumnListControl As IQueryColumnListControl = DirectCast(queryElementControl, IQueryColumnListControl)
			Dim dataGridView As DataGridView = DirectCast(queryColumnListControl.DataGrid, DataGridView)

			' remove event handlers to avoid memory leaking
			RemoveHandler dataGridView.CellBeginEdit, AddressOf DataGridView_CellBeginEdit
			RemoveHandler dataGridView.CellValueNeeded, AddressOf DataGridView_CellValueNeeded
			RemoveHandler dataGridView.CellValuePushed, AddressOf DataGridView_CellValuePushed
			RemoveHandler dataGridView.EditingControlShowing, AddressOf DataGridView_EditingControlShowing
		End If
	End Sub

	Private Sub DataGridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs)
		If e.ColumnIndex = 2 AndAlso e.RowIndex < DirectCast(sender, DataGridView).RowCount - 1 Then
			' Make cell editable
				' Set true if you need read-only cell.			
			e.Cancel = False
		End If
	End Sub

	' This event handler allows you to display some custom value in you column
	Private Sub DataGridView_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs)
		If e.ColumnIndex = 2 AndAlso e.RowIndex < DirectCast(sender, DataGridView).RowCount - 1 Then
			' Set cell value

				' If you need to access to the low level data item, use the following:
				'				QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
			e.Value = _customValuesProvider(e.RowIndex)
		End If
	End Sub

	' This event handler allows you to store modified cell value (if your column is editable)
	Private Sub DataGridView_CellValuePushed(sender As Object, e As DataGridViewCellValueEventArgs)
		If e.ColumnIndex = 2 Then
			' Store new cell value

				' If you need to access to the low level data item, use the following:
				'				QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
			_customValuesProvider(e.RowIndex) = DirectCast(e.Value, String)
		End If
	End Sub

	Private Sub DataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
		If TypeOf e.Control Is TextBoxWithButtonEditingControl Then
			' Handle the button click
			Dim twb As TextBoxWithButtonEditingControl = DirectCast(e.Control, TextBoxWithButtonEditingControl)
			RemoveHandler twb.ButtonClicked, AddressOf EditingControl_ButtonClicked
			' remove the handler added in previous event occurrence
			AddHandler twb.ButtonClicked, AddressOf EditingControl_ButtonClicked
		End If
	End Sub

	Private Sub EditingControl_ButtonClicked(sender As Object, e As EventArgs)
		Dim dataGridView As DataGridView = DirectCast(sender, TextBoxWithButtonEditingControl).EditingControlDataGridView

		' commit the editing before dispatching the click
		dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit)
		dataGridView.RefreshEdit()

		MessageBox.Show(String.Format("Button at row {0} clicked.", dataGridView.CurrentCell.RowIndex))

		' If you need to access to the low level data item, use the following:
		'			QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[dataGridView.CurrentCell.RowIndex];
	End Sub
End Class
