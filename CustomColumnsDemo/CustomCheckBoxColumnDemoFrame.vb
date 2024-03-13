''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2024 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

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
        Next i
    End Sub

    Private Sub queryBuilder1_QueryElementControlCreated(ByVal queryElement As QueryElement, ByVal queryElementControl As IQueryElementControl) Handles queryBuilder1.QueryElementControlCreated
        If TypeOf queryElementControl Is IQueryColumnListControl Then
            Dim queryColumnListControl As IQueryColumnListControl = CType(queryElementControl, IQueryColumnListControl)
            Dim dataGridView As DataGridView = CType(queryColumnListControl.DataGrid, DataGridView)

            _customColumn?.Dispose()

            ' Create custom column
            _customColumn = New DataGridViewCheckBoxColumn With {.Name = "CustomColumn", .HeaderText = "Custom Column", .Width = 100, .FlatStyle = FlatStyle.Standard, .ValueType = GetType(CheckState), .TrueValue = CheckState.Checked, .FalseValue = CheckState.Unchecked, .IndeterminateValue = CheckState.Indeterminate}

            _customColumn.HeaderCell.Style.Font = New Font("Tahoma", 8, FontStyle.Bold)

            ' Insert custom column to specified position
            dataGridView.Columns.Insert(2, _customColumn)

            ' Handle required events
            AddHandler dataGridView.CellBeginEdit, AddressOf DataGridView_CellBeginEdit
            AddHandler dataGridView.CellValueNeeded, AddressOf DataGridView_CellValueNeeded
            AddHandler dataGridView.CellValuePushed, AddressOf DataGridView_CellValuePushed
        End If
    End Sub

    Private Sub queryBuilder1_QueryElementControlDestroying(ByVal queryElement As QueryElement, ByVal queryElementControl As IQueryElementControl) Handles queryBuilder1.QueryElementControlDestroying
        If TypeOf queryElementControl Is IQueryColumnListControl Then
            Dim queryColumnListControl As IQueryColumnListControl = CType(queryElementControl, IQueryColumnListControl)
            Dim dataGridView As DataGridView = CType(queryColumnListControl.DataGrid, DataGridView)

            ' remove event handlers to avoid memory leaking
            RemoveHandler dataGridView.CellBeginEdit, AddressOf DataGridView_CellBeginEdit
            RemoveHandler dataGridView.CellValueNeeded, AddressOf DataGridView_CellValueNeeded
            RemoveHandler dataGridView.CellValuePushed, AddressOf DataGridView_CellValuePushed
        End If
    End Sub

    ''' <summary>
    ''' This handler determines whether a custom column should be editable or not.
    ''' </summary>
    Private Sub DataGridView_CellBeginEdit(ByVal sender As Object, ByVal e As DataGridViewCellCancelEventArgs)
        Dim dataGrid = CType(sender, DataGridView)

        If dataGrid.Columns(e.ColumnIndex) IsNot _customColumn Then
            Return
        End If

        If e.RowIndex < (CType(sender, DataGridView)).RowCount - 1 Then
            ' Make cell editable
            e.Cancel = False ' Set true if you need read-only cell.
        End If
    End Sub

    ' This event handler allows you to display some custom value in you column
    Private Sub DataGridView_CellValueNeeded(ByVal sender As Object, ByVal e As DataGridViewCellValueEventArgs)
        Dim dataGrid = CType(sender, DataGridView)

        If dataGrid.Columns(e.ColumnIndex) IsNot _customColumn Then
            Return
        End If

        If e.RowIndex < (CType(sender, DataGridView)).RowCount - 1 Then
            ' Set cell value
            e.Value = _customValuesProvider(e.RowIndex)

            ' If you need to access to the low level data item, use the following:
            ' QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
        End If
    End Sub

    ' This event handler allows you to store modified cell value (if your column is editable)
    Private Sub DataGridView_CellValuePushed(ByVal sender As Object, ByVal e As DataGridViewCellValueEventArgs)
        Dim dataGrid = CType(sender, DataGridView)

        If dataGrid.Columns(e.ColumnIndex) IsNot _customColumn Then
            Return
        End If

        ' Store new cell value
        _customValuesProvider(e.RowIndex) = (CType(e.Value, CheckState) = CheckState.Checked)

        ' If you need to access to the low level data item, use the following:
        ' QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
    End Sub
End Class
