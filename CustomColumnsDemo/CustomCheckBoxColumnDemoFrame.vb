'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
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

Partial Public Class CustomCheckBoxColumnDemoFrame
    Inherits UserControl
    Private ReadOnly _customValuesProvider As New List(Of Boolean)()
    Private _customColumn As DataGridViewCheckBoxColumn

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
            _customValuesProvider.Add(Convert.ToBoolean(i Mod 2))
        Next
    End Sub

    Private Sub queryBuilder1_QueryElementControlCreated(queryElement As QueryElement, queryElementControl As IQueryElementControl)
        If TypeOf queryElementControl Is IQueryColumnListControl Then
            Dim queryColumnListControl As IQueryColumnListControl = DirectCast(queryElementControl, IQueryColumnListControl)
            Dim dataGridView As DataGridView = DirectCast(queryColumnListControl.DataGrid, DataGridView)

            ' Create custom column
            _customColumn?.Dispose()

            _customColumn = New DataGridViewCheckBoxColumn With {
                .Name = "CustomColumn",
                .HeaderText = "Custom Column",
                .Width = 100,
                .FlatStyle = FlatStyle.Standard,
                .ValueType = GetType(CheckState),
                .TrueValue = CheckState.Checked,
                .FalseValue = CheckState.Unchecked,
                .IndeterminateValue = CheckState.Indeterminate
                }
            _customColumn.HeaderCell.Style.Font = New Font("Tahoma", 8, FontStyle.Bold)

            ' Insert custom column to specified position
            dataGridView.Columns.Insert(2, _customColumn)

            ' Handle requierd events
            AddHandler dataGridView.CellBeginEdit, AddressOf DataGridView_CellBeginEdit
            AddHandler dataGridView.CellValueNeeded, AddressOf DataGridView_CellValueNeeded
            AddHandler dataGridView.CellValuePushed, AddressOf DataGridView_CellValuePushed
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
        End If
    End Sub

    ''' <summary>
    ''' This handler determines whether a custom column should be editable or not.
    ''' </summary>
    Private Sub DataGridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs)
        Dim dataGrid As DataGridView = CType(sender, DataGridView)
        If Not Equals(dataGrid.Columns(e.ColumnIndex), _customColumn) Then Return

        If e.RowIndex < DirectCast(sender, DataGridView).RowCount - 1 Then
            ' Make cell editable
            ' Set true if you need read-only cell.			
            e.Cancel = False
        End If
    End Sub

    ' This event handler allows you to display some custom value in you column
    Private Sub DataGridView_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs)
        Dim dataGrid As DataGridView = CType(sender, DataGridView)
        If Not Equals(dataGrid.Columns(e.ColumnIndex), _customColumn) Then Return

        If e.RowIndex < DirectCast(sender, DataGridView).RowCount - 1 Then
            ' Set cell value

            ' If you need to access to the low level data item, use the following:
            '				QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
            e.Value = _customValuesProvider(e.RowIndex)
        End If
    End Sub

    ' This event handler allows you to store modified cell value (if your column is editable)
    Private Sub DataGridView_CellValuePushed(sender As Object, e As DataGridViewCellValueEventArgs)
        Dim dataGrid As DataGridView = CType(sender, DataGridView)
        If Not Equals(dataGrid.Columns(e.ColumnIndex), _customColumn) Then Return
        ' Store new cell value

        ' If you need to access to the low level data item, use the following:
        '				QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
        _customValuesProvider(e.RowIndex) = (CType(e.Value, CheckState) = CheckState.Checked)

    End Sub
End Class
