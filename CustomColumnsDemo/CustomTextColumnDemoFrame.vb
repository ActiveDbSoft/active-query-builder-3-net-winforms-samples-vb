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


Partial Public Class CustomTextColumnDemoFrame
    Inherits UserControl
    Private _customColumn As DataGridViewTextBoxColumn

    Private ReadOnly _dictionarySubQuery As New Dictionary(Of UnionSubQuery, Dictionary(Of QueryColumnListItem, String))()

    Public Sub New()
        InitializeComponent()
        AddHandler queryBuilder1.ActiveUnionSubQueryChanging, AddressOf QueryBuilder1_ActiveUnionSubQueryChanging
        AddHandler queryBuilder1.ActiveUnionSubQueryChanged, AddressOf QueryBuilder1_ActiveUnionSubQueryChanged
        AddHandler queryBuilder1.QueryColumnListItemChanging, AddressOf QueryBuilder1_QueryColumnListItemChanging

        ' Fill query builder with demo data
        queryBuilder1.SyntaxProvider = New MSSQLSyntaxProvider()
        queryBuilder1.MetadataLoadingOptions.OfflineMode = True
        queryBuilder1.MetadataContainer.ImportFromXML("Northwind.xml")
        queryBuilder1.InitializeDatabaseSchemaTree()

        queryBuilder1.SQL = "select OrderID, CustomerID, OrderDate from Orders"
    End Sub

    Private Sub QueryBuilder1_QueryColumnListItemChanging(ByVal queryColumnList As QueryColumnList, ByVal queryColumnListItem As QueryColumnListItem, ByVal [property] As QueryColumnListItemProperty, ByVal conditionIndex As Integer, ByVal oldValue As Object, ByRef newValue As Object, ByRef abort As Boolean)

    End Sub

    Private Shared Function CountCharacter(ByVal value As QueryColumnListItem) As String
        Return If(String.IsNullOrEmpty(value.ExpressionString), "Empty", $" Length {value.ExpressionString.Length}")
    End Function

    Private Sub QueryBuilder1_ActiveUnionSubQueryChanged(ByVal sender As Object, ByVal e As EventArgs)
        If queryBuilder1.ActiveUnionSubQuery Is Nothing Then
            Return
        End If

        Dim value = _dictionarySubQuery(queryBuilder1.ActiveUnionSubQuery)

        For Each listItem In queryBuilder1.ActiveUnionSubQuery.QueryColumnList
            If value.ContainsKey(listItem) Then
                value(listItem) = listItem.ExpressionString & CountCharacter(listItem)
                Continue For
            End If

            value.Add(listItem, listItem.ExpressionString & CountCharacter(listItem))
        Next listItem

        _dictionarySubQuery(queryBuilder1.ActiveUnionSubQuery) = value
    End Sub

    Private Sub QueryColumnListOnElementRemoving(ByVal sender As QueryElement, ByVal child As QueryElement)
        Dim queryColumnListItem = CType(child, QueryColumnListItem)
        RemoveHandler queryColumnListItem.Updated, AddressOf QueryColumnListItem_Updated

        If _dictionarySubQuery.ContainsKey(queryBuilder1.ActiveUnionSubQuery) Then
            If _dictionarySubQuery(queryBuilder1.ActiveUnionSubQuery).ContainsKey(queryColumnListItem) Then
                _dictionarySubQuery(queryBuilder1.ActiveUnionSubQuery).Remove(queryColumnListItem)
            End If
        Else
            For Each key In _dictionarySubQuery.Keys
                If Not _dictionarySubQuery(key).ContainsKey(queryColumnListItem) Then
                    Continue For
                End If

                _dictionarySubQuery(key).Remove(queryColumnListItem)
            Next key
        End If
    End Sub

    Private Sub QueryColumnList_ElementAdded(ByVal sender As QueryElement, ByVal child As QueryElement)
        Dim queryColumnListItem = CType(child, QueryColumnListItem)
        AddHandler queryColumnListItem.Updated, AddressOf QueryColumnListItem_Updated
    End Sub

    Private Sub QueryColumnListItem_Updated(ByVal sender As Object, ByVal e As EventArgs)
        Dim queryColumnListItem = CType(sender, QueryColumnListItem)
        If _dictionarySubQuery.ContainsKey(queryBuilder1.ActiveUnionSubQuery) Then
            Dim values = _dictionarySubQuery(queryBuilder1.ActiveUnionSubQuery)

            If values.ContainsKey(queryColumnListItem) Then
                values(queryColumnListItem) = queryColumnListItem.ExpressionString & CountCharacter(queryColumnListItem)
            Else
                values.Add(queryColumnListItem, queryColumnListItem.ExpressionString & CountCharacter(queryColumnListItem))
            End If
        Else
            _dictionarySubQuery.Add(queryBuilder1.ActiveUnionSubQuery, New Dictionary(Of QueryColumnListItem, String) From {{queryColumnListItem, queryColumnListItem.ExpressionString + queryColumnListItem.ExpressionString & CountCharacter(queryColumnListItem)}})
        End If
    End Sub

    Private Sub QueryBuilder1_ActiveUnionSubQueryChanging(ByVal sender As Object, ByVal e As ActiveQueryBuilder.View.SubQueryChangingEventArgs)
        If e.OldSubQuery IsNot Nothing AndAlso _dictionarySubQuery.ContainsKey(e.OldSubQuery) Then
            _dictionarySubQuery.Remove(e.OldSubQuery)
            RemoveHandler e.OldSubQuery.QueryColumnList.ElementAdded, AddressOf QueryColumnList_ElementAdded
            RemoveHandler e.OldSubQuery.QueryColumnList.ElementRemoving, AddressOf QueryColumnListOnElementRemoving
        End If

        If e.NewSubQuery Is Nothing OrElse _dictionarySubQuery.ContainsKey(e.NewSubQuery) Then
            Return
        End If

        AddHandler e.NewSubQuery.QueryColumnList.ElementAdded, AddressOf QueryColumnList_ElementAdded
        AddHandler e.NewSubQuery.QueryColumnList.ElementRemoving, AddressOf QueryColumnListOnElementRemoving


        _dictionarySubQuery.Add(e.NewSubQuery, New Dictionary(Of QueryColumnListItem, String)())
    End Sub

    Private Sub queryBuilder1_QueryElementControlCreated(ByVal queryElement As QueryElement, ByVal queryElementControl As IQueryElementControl) Handles queryBuilder1.QueryElementControlCreated
        If TypeOf queryElementControl Is IQueryColumnListControl Then
            Dim queryColumnListControl = CType(queryElementControl, IQueryColumnListControl)
            Dim dataGridView As DataGridView = CType(queryColumnListControl.DataGrid, DataGridView)

            _customColumn?.Dispose()

            ' Create custom column
            _customColumn = New DataGridViewTextBoxColumn With {.Name = "CustomColumn", .HeaderText = "Custom Column", .Width = 200, .ValueType = GetType(String)}
            _customColumn.HeaderCell.Style.Font = New Font("Tahoma", 8, FontStyle.Bold)

            ' Insert custom column to specified position
            dataGridView.Columns.Insert(2, _customColumn)

            ' Handle requierd events
            AddHandler dataGridView.CellBeginEdit, AddressOf DataGridView_CellBeginEdit
            AddHandler dataGridView.CellValueNeeded, AddressOf DataGridView_CellValueNeeded
            AddHandler dataGridView.CellValuePushed, AddressOf DataGridView_CellValuePushed
        End If
    End Sub

    Private Sub queryBuilder1_QueryElementControlDestroying(ByVal queryElement As QueryElement, ByVal queryElementControl As IQueryElementControl) Handles queryBuilder1.QueryElementControlDestroying
        If TypeOf queryElementControl Is IQueryColumnListControl Then
            Dim queryColumnListControl = CType(queryElementControl, IQueryColumnListControl)
            Dim dataGridView As DataGridView = CType(queryColumnListControl.DataGrid, DataGridView)

            ' remove event handlers to avoid memory leaking
            RemoveHandler dataGridView.CellBeginEdit, AddressOf DataGridView_CellBeginEdit
            RemoveHandler dataGridView.CellValueNeeded, AddressOf DataGridView_CellValueNeeded
            RemoveHandler dataGridView.CellValuePushed, AddressOf DataGridView_CellValuePushed
        End If
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

    ' This event handler allows you to display some custom value in you column
    Private Sub DataGridView_CellValueNeeded(ByVal sender As Object, ByVal e As DataGridViewCellValueEventArgs)
        Dim dataGrid = CType(sender, DataGridView)

        If dataGrid.Columns(e.ColumnIndex) IsNot _customColumn Then
            Return
        End If

        If e.RowIndex >= (CType(sender, DataGridView)).RowCount - 1 Then
            Return
        End If
        Dim data As Dictionary(Of QueryColumnListItem, String) = _dictionarySubQuery(queryBuilder1.ActiveUnionSubQuery)

        If Not data.ContainsKey(queryBuilder1.ActiveUnionSubQuery.QueryColumnList.Items(e.RowIndex)) Then
            Return
        End If

        ' Set cell value
        e.Value = data(queryBuilder1.ActiveUnionSubQuery.QueryColumnList.Items(e.RowIndex))

        ' If you need to access to the low level data item, use the following:
        'QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
    End Sub

    ' This event handler allows you to store modified cell value (if your column is editable)
    Private Sub DataGridView_CellValuePushed(ByVal sender As Object, ByVal e As DataGridViewCellValueEventArgs)
        Dim dataGrid = CType(sender, DataGridView)

        If dataGrid.Columns(e.ColumnIndex) IsNot _customColumn Then
            Return
        End If

        If e.RowIndex >= (CType(sender, DataGridView)).RowCount - 1 Then
            Return
        End If
        Dim data As Dictionary(Of QueryColumnListItem, String) = _dictionarySubQuery(queryBuilder1.ActiveUnionSubQuery)

        If data.ContainsKey(queryBuilder1.ActiveUnionSubQuery.QueryColumnList.Items(e.RowIndex)) Then
            ' Store new cell value
            data(queryBuilder1.ActiveUnionSubQuery.QueryColumnList.Items(e.RowIndex)) = CStr(e.Value)
        End If

        ' If you need to access to the low level data item, use the following:
        'QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
    End Sub
End Class
