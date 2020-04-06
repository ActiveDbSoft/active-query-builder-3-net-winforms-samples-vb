'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.QueryView
Imports ActiveQueryBuilder.View.WinForms.QueryView


Partial Public Class CustomComobBoxWithButtonColumnDemoFrame
    Inherits UserControl
    Private ReadOnly _customValuesProvider As New List(Of String)()
    Private _customColumn As ComboBoxWithButtonColumn

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
        Next i
    End Sub

    Private Sub queryBuilder1_QueryElementControlCreated(ByVal queryElement As QueryElement, ByVal queryElementControl As IQueryElementControl) Handles queryBuilder1.QueryElementControlCreated
        If TypeOf queryElementControl Is IQueryColumnListControl Then
            Dim queryColumnListControl As IQueryColumnListControl = CType(queryElementControl, IQueryColumnListControl)
            Dim dataGridView As DataGridView = CType(queryColumnListControl.DataGrid, DataGridView)

            _customColumn?.Dispose()

            ' Create custom column
            _customColumn = New ComboBoxWithButtonColumn With {.Name = "CustomColumn", .HeaderText = "Custom Column", .Width = 200, .DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing, .ValueType = GetType(String)}

            _customColumn.HeaderCell.Style.Font = New Font("Tahoma", 8, FontStyle.Bold)
            _customColumn.ShowButton = True

            ' Insert custom column to specified position
            dataGridView.Columns.Insert(2, _customColumn)

            ' Handle requierd events
            AddHandler dataGridView.CellEnter, AddressOf DataGridView_CellEnter
            AddHandler dataGridView.CellLeave, AddressOf DataGridView_CellLeave
            AddHandler dataGridView.CellBeginEdit, AddressOf DataGridView_CellBeginEdit
            AddHandler dataGridView.CellValueNeeded, AddressOf DataGridView_CellValueNeeded
            AddHandler dataGridView.CellValuePushed, AddressOf DataGridView_CellValuePushed
            AddHandler dataGridView.EditingControlShowing, AddressOf DataGridView_EditingControlShowing
        End If
    End Sub

    Private Sub queryBuilder1_QueryElementControlDestroying(ByVal queryElement As QueryElement, ByVal queryElementControl As IQueryElementControl) Handles queryBuilder1.QueryElementControlDestroying
        If TypeOf queryElementControl Is IQueryColumnListControl Then
            Dim queryColumnListControl As IQueryColumnListControl = CType(queryElementControl, IQueryColumnListControl)
            Dim dataGridView As DataGridView =CType(queryColumnListControl.DataGrid, DataGridView)

            ' remove event handlers to avoid memory leaking
            RemoveHandler dataGridView.CellEnter, AddressOf DataGridView_CellEnter
            RemoveHandler dataGridView.CellLeave, AddressOf DataGridView_CellLeave
            RemoveHandler dataGridView.CellBeginEdit, AddressOf DataGridView_CellBeginEdit
            RemoveHandler dataGridView.CellValueNeeded, AddressOf DataGridView_CellValueNeeded
            RemoveHandler dataGridView.CellValuePushed, AddressOf DataGridView_CellValuePushed
            RemoveHandler dataGridView.EditingControlShowing, AddressOf DataGridView_EditingControlShowing
        End If
    End Sub

    Private Sub DataGridView_CellEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Dim dataGrid = CType(sender, DataGridView)

        If dataGrid.Columns(e.ColumnIndex) IsNot _customColumn Then
            Return
        End If
        ' Make the combobox visible when a cell got the focus
        Dim dataGridView As DataGridView = CType(sender, DataGridView)
        Dim comboBoxCell As DataGridViewComboBoxCell = CType(dataGridView(e.ColumnIndex, e.RowIndex), DataGridViewComboBoxCell)
        comboBoxCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
    End Sub

    Private Sub DataGridView_CellLeave(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Dim dataGrid = CType(sender, DataGridView)

        If dataGrid.Columns(e.ColumnIndex) IsNot _customColumn Then
            Return
        End If
        ' Make the combobox invisible when a cell lost the focus
        Dim dataGridView As DataGridView = CType(sender, DataGridView)
        Dim comboBoxCell As DataGridViewComboBoxCell = CType(dataGridView(e.ColumnIndex, e.RowIndex), DataGridViewComboBoxCell)
        comboBoxCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
    End Sub

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

    ' This event handler allows you to provide cell values for your column
    Private Sub DataGridView_CellValueNeeded(ByVal sender As Object, ByVal e As DataGridViewCellValueEventArgs)
        Dim dataGrid = CType(sender, DataGridView)

        If dataGrid.Columns(e.ColumnIndex) IsNot _customColumn Then
            Return
        End If

        If e.RowIndex < (CType(sender, DataGridView)).RowCount - 1 Then
            Dim dataGridView As DataGridView = CType(sender, DataGridView)

            ' Set cell value
            e.Value = _customValuesProvider(e.RowIndex)

            ' Ensure the comobox list contains the value, otherwise the combobox will not show it.
            Dim cb As DataGridViewComboBoxColumn = CType(dataGridView.Columns(2), DataGridViewComboBoxColumn)
            If Not cb.Items.Contains(e.Value) Then
                cb.Items.Add(e.Value)
            End If

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
        _customValuesProvider(e.RowIndex) = CStr(e.Value)

        ' If you need to access to the low level data item, use the following:
        ' QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];

    End Sub

    Private Sub DataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs)
        Dim dataGridView As DataGridView = CType(sender, DataGridView)
        Dim currentColumn As Integer = dataGridView.CurrentCell.ColumnIndex
        Dim currentRow As Integer = dataGridView.CurrentCell.RowIndex

        If dataGridView.CurrentCell.ColumnIndex = 2 AndAlso TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            Dim comboBox As DataGridViewComboBoxEditingControl = CType(e.Control, DataGridViewComboBoxEditingControl)
            comboBox.DropDownStyle = ComboBoxStyle.DropDown

            ' Fill the combobox dropdown list with possible values
            comboBox.Items.Clear()
            For i As Integer = 0 To 99
                comboBox.Items.Add("Some Value " & i)
            Next i

            ' Select current value
            comboBox.SelectedIndex = comboBox.FindStringExact(CStr(dataGridView(currentColumn, currentRow).Value))
        End If

        ' Handle the button click
        If TypeOf e.Control Is ComboBoxWithButtonEditingControl Then
            Dim twb As ComboBoxWithButtonEditingControl = CType(e.Control, ComboBoxWithButtonEditingControl)
            RemoveHandler twb.ButtonClicked, AddressOf EditingControlButtonClickedEventHandler ' remove the handler added in previous event occurrence
            AddHandler twb.ButtonClicked, AddressOf EditingControlButtonClickedEventHandler
        End If
    End Sub

    Private Sub EditingControlButtonClickedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
        Dim dataGridView As DataGridView = (CType(sender, ComboBoxWithButtonEditingControl)).EditingControlDataGridView

        ' commit the editing before dispatching the click
        dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit)
        dataGridView.RefreshEdit()

        MessageBox.Show("Button at row " & dataGridView.CurrentCell.RowIndex & " clicked.")

        ' If you need to access to the low level data item, use the following:
        ' QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[dataGridView.CurrentCell.RowIndex];
    End Sub
End Class
