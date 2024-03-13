''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2024 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Globalization
Imports System.Text
Imports System.Text.RegularExpressions
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.QueryTransformer


Partial Public Class Form1
    Inherits Form

    Private _sqlContext As SQLContext
    Private _sqlQuery As SQLQuery
    Private _queryTransformer As QueryTransformer

    ' List of query output columns of the current SQL query used for turning their visibility on and off
    Private ReadOnly _sourceCodeTransformer As New List(Of String)()

    Public Sub New()
        InitializeComponent()
        AddHandler Load, AddressOf Form1_Load
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler Load, AddressOf Form1_Load

        _sqlContext = New SQLContext With {.SyntaxProvider = New MSSQLSyntaxProvider With {.ServerVersion = MSSQLServerVersion.MSSQL2012}}
        _sqlContext.LoadingOptions.OfflineMode = True
        _sqlContext.MetadataContainer.ImportFromXML("Northwind.xml")

        Dim sqlText = New StringBuilder()
        sqlText.AppendLine("Select Categories.CategoryName,")
        sqlText.AppendLine("Products.QuantityPerUnit")
        sqlText.AppendLine("From Categories")
        sqlText.AppendLine("Inner Join Products On Categories.CategoryID = Products.CategoryID")

        _sqlQuery = New SQLQuery(_sqlContext)

        AddHandler _sqlQuery.SQLUpdated, AddressOf _sqlQuery_SQLUpdated

        _sqlQuery.SQL = sqlText.ToString()

        _queryTransformer = New QueryTransformer With {.Query = _sqlQuery}

        AddHandler _queryTransformer.SQLUpdated, AddressOf _queryTransformer_SQLUpdated
        LoadData()
    End Sub

    Private Sub ClearFieldsSorting()
        ComboBoxSortingColumns.SelectedItem = Nothing
        ComboBoxSortings.SelectedItem = Nothing
    End Sub

    Private Sub ClearFieldsAggregate()
        ComboBoxAggregateColumns.SelectedItem = Nothing
        ComboBoxAggregations.SelectedItem = Nothing
    End Sub

    Private Sub ClearFieldsWhere()
        ComboBoxWhereColumns.SelectedItem = Nothing
        ComboBoxAggregations.SelectedItem = Nothing
        ComboBoxConditions.SelectedItem = Nothing
        TextBoxWhereValue.Text = String.Empty
    End Sub

    Private Sub LoadData()
        ' Clear the input fields
        ClearFieldsSorting()
        ClearFieldsAggregate()
        ClearFieldsWhere()

        ListBoxVisibleFields.Items.Clear()
        ComboBoxSortingColumns.Items.Clear()
        ComboBoxAggregateColumns.Items.Clear()
        ComboBoxWhereColumns.Items.Clear()

        _queryTransformer.Filters.Clear()
        _queryTransformer.Aggregations.Clear()
        _queryTransformer.Sortings.Clear()

        _sourceCodeTransformer.Clear()
        _sourceCodeTransformer.Add("_queryTransformer")

        ' Set counter values
        CounterSortings.Text = _queryTransformer.Sortings.Count.ToString()
        CounterAggregations.Text = _queryTransformer.Aggregations.Count.ToString()
        CounterFilters.Text = _queryTransformer.Filters.Count.ToString()

        ' Load a query into the SQLQuery object. 
        _sqlQuery.SQL = BoxSourceSql.Text

        ' Fill the list of output columns to be used as ItemsSource for a combobox
        For Each column In _queryTransformer.Columns
            Dim columnSource = New CustomColumn(column)
            ListBoxVisibleFields.Items.Add(columnSource)
            ListBoxVisibleFields.SetItemChecked(_queryTransformer.Columns.IndexOf(column), True)

            ComboBoxSortingColumns.Items.Add(columnSource)
            ComboBoxAggregateColumns.Items.Add(columnSource)
            ComboBoxWhereColumns.Items.Add(columnSource)

        Next column

        CounterVisibleColumns.Text = ListBoxVisibleFields.CheckedIndices.Count.ToString()
    End Sub

    Private Sub _queryTransformer_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs)
        ' Get the transformed SQL query text
        BoxResultSql.Text = _queryTransformer.SQL
    End Sub

    Private Sub _sqlQuery_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs)
        BoxSourceSql.Text = New SQLFormattingOptions(New SQLGenerationOptions()).GetSQLBuilder().GetSQL(_sqlQuery.QueryRoot)
    End Sub

    Private Sub ListBoxVisibleFields_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs) Handles ListBoxVisibleFields.ItemCheck
        Dim column = CType(ListBoxVisibleFields.Items(e.Index), CustomColumn)

        If column.Column.Visible = (e.NewValue = CheckState.Checked) Then
            Return
        End If

        column.Column.Visible = e.NewValue = CheckState.Checked

        Dim i = 0

        For Each outputColumn As OutputColumn In _queryTransformer.Columns
            If outputColumn.Visible Then i = i + 1
        Next

        CounterVisibleColumns.Text = i.ToString()
    End Sub

    Private Sub ButtonLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonLoad.Click
        ' Load a query and updating the form controls
        LoadData()
    End Sub

    Private Sub ButtonAddSorting_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAddSorting.Click
        Dim column = (CType(ComboBoxSortingColumns.SelectedItem, CustomColumn)).Column
        If Not column.IsSupportSorting Then
            Return
        End If

        Dim sortedColumn As SortedColumn = Nothing
        Select Case ComboBoxSortings.SelectedItem.ToString()
            Case "Asc"
                sortedColumn = column.Asc()
            Case "Desc"
                sortedColumn = column.Desc()
        End Select

        Dim text = String.Format(vbTab & ".OrderBy(_queryTransformer.Columns[{0}], {1})", _queryTransformer.Columns.IndexOf(column), (ComboBoxSortings.SelectedItem.ToString() = "Asc").ToString().ToLower())

        ' Add sorting to the query - the sort order of original query will be overridden.
        _queryTransformer.OrderBy(sortedColumn)

        CounterSortings.Text = _queryTransformer.Sortings.Count.ToString()
        BoxResultSql.Text = _queryTransformer.SQL

        ClearFieldsSorting()
        _sourceCodeTransformer.Add(text)
    End Sub

    Private Sub ButtonClearSortings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonClearSortings.Click
        ' Remove the added sortings from the query - the original sort order will be restored.
        _queryTransformer.Sortings.Clear()

        ClearFieldsSorting()

        CounterSortings.Text = _queryTransformer.Sortings.Count.ToString()

        Dim i = 0
        Do While i < _sourceCodeTransformer.Count
            Dim line = _sourceCodeTransformer(i)
            If Not line.Contains("OrderBy") Then
                i += 1
                Continue Do
            End If

            _sourceCodeTransformer.RemoveAt(i)
            i = 0
            i += 1
        Loop
    End Sub

    Private Sub ButtonAddAggregate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAddAggregate.Click
        Dim column = (CType(ComboBoxAggregateColumns.SelectedItem, CustomColumn)).Column

        Dim aggregatedColumn As AggregatedColumn = Nothing
        Select Case ComboBoxAggregations.SelectedItem.ToString()
            Case "Count"
                aggregatedColumn = column.Count()
            Case "Avg"
                aggregatedColumn = column.Avg()
            Case "Sum"
                aggregatedColumn = column.Sum()
            Case "Min"
                aggregatedColumn = column.Min()
            Case "Max"
                aggregatedColumn = column.Max()
        End Select
        Dim text = String.Format(vbTab & ".Select(_queryTransformer.Columns[{0}].{1}())", _queryTransformer.Columns.IndexOf(column), ComboBoxAggregations.SelectedItem)
        _sourceCodeTransformer.Add(text)

        ' Add an aggregate to the query - if any aggregates are added, all other columns will be removed from the query.
        _queryTransformer.Aggregations.Add(aggregatedColumn)
        CounterAggregations.Text = _queryTransformer.Aggregations.Count.ToString()

        ClearFieldsAggregate()
    End Sub

    Private Sub ButtonClearAggregates_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonClearAggregates.Click
        ' Clear all aggregates from the query - the columns of original query will be restored.
        ClearFieldsAggregate()
        _queryTransformer.Aggregations.Clear()
        CounterAggregations.Text = _queryTransformer.Aggregations.Count.ToString()

        Dim i = 0
        Do While i < _sourceCodeTransformer.Count
            Dim line = _sourceCodeTransformer(i)
            If Not line.Contains("Select") Then
                i += 1
                Continue Do
            End If

            _sourceCodeTransformer.RemoveAt(i)
            i = 0
            i += 1
        Loop
    End Sub

    Private Sub ButtonAddWhere_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonAddWhere.Click
        Dim column = (CType(ComboBoxWhereColumns.SelectedItem, CustomColumn)).Column

        Dim indexColumn = _queryTransformer.Columns.IndexOf(column)

        Dim expression = ""

        Dim condition As FilterCondition = Nothing
        Select Case ComboBoxConditions.SelectedItem.ToString()
            Case "Equal"
                condition = column.Equal(TextBoxWhereValue.Text)
                expression = String.Format("Equal(""{0}"")", TextBoxWhereValue.Text)
            Case "Not Equal"
                condition = column.Not_Equal(TextBoxWhereValue.Text)
                expression = String.Format("Not_Equal(""{0}"")", TextBoxWhereValue.Text)
            Case "Greater"
                condition = column.Greater(TextBoxWhereValue.Text)
                expression = String.Format("Greater(""{0}"")", TextBoxWhereValue.Text)
            Case "GreaterEqual"
                condition = column.GreaterEqual(TextBoxWhereValue.Text)
                expression = String.Format("GreaterEqual(""{0}"")", TextBoxWhereValue.Text)
            Case "Not Grater"
                condition = column.Not_Greater(TextBoxWhereValue.Text)
                expression = String.Format("Not_Greater(""{0}"")", TextBoxWhereValue.Text)
            Case "Not GreaterEqual"
                condition = column.Not_GreaterEqual(TextBoxWhereValue.Text)
                expression = String.Format("Not_GreaterEqual(""{0}"")", TextBoxWhereValue.Text)
            Case "IsNull"
                condition = column.IsNull()
                expression = "IsNull()"
            Case "Not IsNull"
                condition = column.Not_IsNull()
                expression = "Not_IsNull()"
            Case "IsNotNull"
                condition = column.IsNotNull()
                expression = "IsNotNull()"
            Case "Less"
                condition = column.Less(TextBoxWhereValue.Text)
                expression = String.Format("Less(""{0}"")", TextBoxWhereValue.Text)
            Case "LessEqual"
                condition = column.LessEqual(TextBoxWhereValue.Text)
                expression = String.Format("LessEqual(""{0}"")", TextBoxWhereValue.Text)
            Case "Not Less"
                condition = column.Not_Less(TextBoxWhereValue.Text)
                expression = String.Format("Not_Less(""{0}"")", TextBoxWhereValue.Text)
            Case "Not LessEqual"
                condition = column.Not_LessEqual(TextBoxWhereValue.Text)
                expression = String.Format("Not_LessEqual(""{0}"")", TextBoxWhereValue.Text)
            Case "In"
                condition = column.In(TextBoxWhereValue.Text)
                expression = String.Format("In(""{0}"")", TextBoxWhereValue.Text)
            Case "Not In"
                condition = column.Not_In(TextBoxWhereValue.Text)
                expression = String.Format("Not_In(""{0}"")", TextBoxWhereValue.Text)

            Case "Like"
                condition = column.Like(TextBoxWhereValue.Text)
                expression = String.Format("Like(""{0}"")", TextBoxWhereValue.Text)
            Case "Not Like"
                condition = column.Not_Like(TextBoxWhereValue.Text)
                expression = String.Format("Not_Like(""{0}"")", TextBoxWhereValue.Text)
        End Select

        ' Add new filter to the query - the filter will be added to the WHERE clause of original query.
        _queryTransformer.Filters.Add(condition)
        CounterFilters.Text = _queryTransformer.Filters.Count.ToString()

        ClearFieldsWhere()

        Dim text = String.Format(vbTab & ".Where(_queryTransformer.Columns[{0}].{1})", indexColumn, expression)

        _sourceCodeTransformer.Add(text)
    End Sub

    Private Sub ButtonClearWhere_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonClearWhere.Click
        ClearFieldsWhere()

        ' Remove all additional filters from query - the original WHERE clause will be restored.
        _queryTransformer.Filters.Clear()

        CounterFilters.Text = _queryTransformer.Filters.Count.ToString()

        Dim i = 0
        Do While i < _sourceCodeTransformer.Count
            Dim line = _sourceCodeTransformer(i)
            If Not line.Contains("Where") Then
                i += 1
                Continue Do
            End If

            _sourceCodeTransformer.RemoveAt(i)
            i = 0
            i += 1
        Loop
    End Sub

    Private Sub ButtonCodeBehindShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonCodeBehindShow.Click
        Using formCode = New CodeBehindForm()
            formCode.StartPosition = FormStartPosition.CenterParent
            Dim builder = New StringBuilder()

            For Each line In _sourceCodeTransformer
                builder.AppendLine(line)
            Next line

            formCode.TextContent = GetCodeBehind()
            formCode.ShowDialog(Me)
        End Using
    End Sub

    Private Function GetCodeBehind() As String
        Dim builder = New StringBuilder()
        builder.AppendLine("_queryTransformer")

        For Each sorting In _queryTransformer.Sortings
            Dim text = String.Format(vbTab & ".OrderBy(_queryTransformer.Columns[{0}], {1})", _queryTransformer.Columns.IndexOf(sorting.Column), (sorting.SortType = ItemSortType.Asc).ToString().ToLower(CultureInfo.CurrentCulture))
            builder.AppendLine(text)
        Next sorting

        Dim reg = New Regex("([A-Z])\w+")
        For Each aggregation In _queryTransformer.Aggregations
            Dim result = reg.Match(aggregation.Expression)
            If Not result.Success Then
                Continue For
            End If

            Dim text = String.Format(vbTab & ".Select(_queryTransformer.Columns[{0}].{1}())", _queryTransformer.Columns.IndexOf(aggregation.Column), result.Value)
            builder.AppendLine(text)
        Next aggregation

        For Each filter As FilterConditionJunction In _queryTransformer.Filters

            Dim text = String.Format(vbTab & ".Where(""{0}"")", filter.Condition)
            builder.AppendLine(text)
        Next filter

        Return builder.ToString()
    End Function
End Class

Public Class CustomColumn
    Private privateColumn As OutputColumn
    Public Property Column() As OutputColumn
        Get
            Return privateColumn
        End Get
        Private Set(ByVal value As OutputColumn)
            privateColumn = value
        End Set
    End Property

    Public Sub New(ByVal column As OutputColumn)
        Me.Column = column
    End Sub

    Public Overrides Function ToString() As String
        Return Column.Column.Expression
    End Function
End Class
