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
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
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

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        RemoveHandler Load, AddressOf Form1_Load

        _sqlContext = New SQLContext() With {
            .SyntaxProvider = New MSSQLSyntaxProvider() With {
                .ServerVersion = MSSQLServerVersion.MSSQL2012
            }
		}

        _sqlContext.MetadataContainer.LoadingOptions.OfflineMode = true
		_sqlContext.MetadataContainer.ImportFromXML("Northwind.xml")

        Dim sqlText As StringBuilder = New StringBuilder()
        sqlText.AppendLine("Select Categories.CategoryName,")
        sqlText.AppendLine("Products.QuantityPerUnit")
        sqlText.AppendLine("From Categories")
        sqlText.AppendLine("Inner Join Products On Categories.CategoryID = Products.CategoryID")

        _sqlQuery = New SQLQuery(_sqlContext)

        AddHandler _sqlQuery.SQLUpdated, AddressOf _sqlQuery_SQLUpdated

        _sqlQuery.SQL = sqlText.ToString()

        _queryTransformer = New QueryTransformer() With {
            .Query = _sqlQuery
        }

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
        For Each column As OutputColumn In _queryTransformer.Columns
            Dim columnSource as CustomColumn = New CustomColumn(column)
            ListBoxVisibleFields.Items.Add(columnSource)
            ListBoxVisibleFields.SetItemChecked(_queryTransformer.Columns.IndexOf(column), True)

            ComboBoxSortingColumns.Items.Add(columnSource)
            ComboBoxAggregateColumns.Items.Add(columnSource)

            ComboBoxWhereColumns.Items.Add(columnSource)
        Next

        CounterVisibleColumns.Text = ListBoxVisibleFields.CheckedIndices.Count.ToString()
    End Sub

    Private Sub _queryTransformer_SQLUpdated(sender As Object, e As EventArgs)
        ' Get the transformed SQL query text
        BoxResultSql.Text = _queryTransformer.SQL
    End Sub

    Private Sub _sqlQuery_SQLUpdated(sender As Object, e As EventArgs)
        BoxSourceSql.Text = New SQLFormattingOptions(New SQLGenerationOptions()).GetSQLBuilder().GetSQL(_sqlQuery.QueryRoot)
    End Sub

    Private Sub ListBoxVisibleFields_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ListBoxVisibleFields.ItemCheck
        Dim column As CustomColumn = DirectCast(ListBoxVisibleFields.Items(e.Index), CustomColumn)

        If column.Column.Visible = (e.NewValue = CheckState.Checked) Then
            Return
        End If

        column.Column.Visible = e.NewValue = CheckState.Checked

        CounterVisibleColumns.Text = _queryTransformer.Columns.Where(Function(item) item.Visible).Count().ToString()
    End Sub

    Private Sub ButtonLoad_Click(sender As Object, e As EventArgs) Handles ButtonLoad.Click
        ' Load a query and updating the form controls
        LoadData()
    End Sub

    Private Sub ButtonAddSorting_Click(sender As Object, e As EventArgs) Handles ButtonAddSorting.Click
        Dim column As OutputColumn = DirectCast(ComboBoxSortingColumns.SelectedItem, CustomColumn).Column
        If Not column.IsSupportSorting Then
            Return
        End If

        Dim sortedColumn As SortedColumn = Nothing
        Select Case ComboBoxSortings.SelectedItem.ToString()
            Case "Asc"
                sortedColumn = column.Asc()
                Exit Select
            Case "Desc"
                sortedColumn = column.Desc()
                Exit Select
        End Select

        Dim code As String = String.Format(vbTab & ".OrderBy(_queryTransformer.Columns[{0}], {1})", _queryTransformer.Columns.IndexOf(column), (ComboBoxSortings.SelectedItem.ToString() = "Asc").ToString().ToLower())

        ' Add sorting to the query - the sort order of original query will be overridden.
        _queryTransformer.OrderBy(sortedColumn)

        CounterSortings.Text = _queryTransformer.Sortings.Count.ToString()
        BoxResultSql.Text = _queryTransformer.SQL

        ClearFieldsSorting()
        _sourceCodeTransformer.Add(code)
    End Sub

    Private Sub ButtonClearSortings_Click(sender As Object, e As EventArgs) Handles ButtonClearSortings.Click
        ' Remove the added sortings from the query - the original sort order will be restored.
        _queryTransformer.Sortings.Clear()

        ClearFieldsSorting()

        CounterSortings.Text = _queryTransformer.Sortings.Count.ToString()

        For i As Int32 = 0 To _sourceCodeTransformer.Count - 1
            Dim line as String = _sourceCodeTransformer(i)
            If Not line.Contains("OrderBy") Then
                Continue For
            End If

            _sourceCodeTransformer.RemoveAt(i)
            i = 0
        Next
    End Sub

    Private Sub ButtonAddAggregate_Click(sender As Object, e As EventArgs) Handles ButtonAddAggregate.Click
        Dim column As OutputColumn = DirectCast(ComboBoxAggregateColumns.SelectedItem, CustomColumn).Column

        Dim aggregatedColumn As AggregatedColumn = Nothing
        Select Case ComboBoxAggregations.SelectedItem.ToString()
            Case "Count"
                aggregatedColumn = column.Count()
                Exit Select
            Case "Avg"
                aggregatedColumn = column.Avg()
                Exit Select
            Case "Sum"
                aggregatedColumn = column.Sum()
                Exit Select
            Case "Min"
                aggregatedColumn = column.Min()
                Exit Select
            Case "Max"
                aggregatedColumn = column.Max()
                Exit Select
        End Select
        Dim code As String = String.Format(vbTab & ".Select(_queryTransformer.Columns[{0}].{1}())", _queryTransformer.Columns.IndexOf(column), ComboBoxAggregations.SelectedItem)
        _sourceCodeTransformer.Add(code)

        ' Add an aggregate to the query - if any aggregates are added, all other columns will be removed from the query.
        _queryTransformer.Aggregations.Add(aggregatedColumn)
        CounterAggregations.Text = _queryTransformer.Aggregations.Count.ToString()

        ClearFieldsAggregate()
    End Sub

    Private Sub ButtonClearAggregates_Click(sender As Object, e As EventArgs) Handles ButtonClearAggregates.Click
        ' Clear all aggregates from the query - the columns of original query will be restored.
        ClearFieldsAggregate()
        _queryTransformer.Aggregations.Clear()
        CounterAggregations.Text = _queryTransformer.Aggregations.Count.ToString()

        For i As Int32 = 0 To _sourceCodeTransformer.Count - 1
            Dim line As String = _sourceCodeTransformer(i)
            If Not line.Contains("Select") Then
                Continue For
            End If

            _sourceCodeTransformer.RemoveAt(i)
            i = 0
        Next
    End Sub

    Private Sub ButtonAddWhere_Click(sender As Object, e As EventArgs) Handles ButtonAddWhere.Click
        Dim column As OutputColumn = DirectCast(ComboBoxWhereColumns.SelectedItem, CustomColumn).Column

        Dim indexColumn As Integer = _queryTransformer.Columns.IndexOf(column)

        Dim expression As String = ""

        Dim condition As FilterCondition = Nothing
        Select Case ComboBoxConditions.SelectedItem.ToString()
            Case "Equal"
                condition = column.Equal(TextBoxWhereValue.Text)
                expression = String.Format("Equal(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
            Case "Not Equal"
                condition = column.Not_Equal(TextBoxWhereValue.Text)
                expression = String.Format("Not_Equal(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
            Case "Greater"
                condition = column.Greater(TextBoxWhereValue.Text)
                expression = String.Format("Greater(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
            Case "GreaterEqual"
                condition = column.GreaterEqual(TextBoxWhereValue.Text)
                expression = String.Format("GreaterEqual(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
            Case "Not Grater"
                condition = column.Not_Greater(TextBoxWhereValue.Text)
                expression = String.Format("Not_Greater(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
            Case "Not GreaterEqual"
                condition = column.Not_GreaterEqual(TextBoxWhereValue.Text)
                expression = String.Format("Not_GreaterEqual(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
            Case "IsNull"
                condition = column.IsNull()
                expression = "IsNull()"
                Exit Select
            Case "Not IsNull"
                condition = column.Not_IsNull()
                expression = "Not_IsNull()"
                Exit Select
            Case "IsNotNull"
                condition = column.IsNotNull()
                expression = "IsNotNull()"
                Exit Select
            Case "Less"
                condition = column.Less(TextBoxWhereValue.Text)
                expression = String.Format("Less(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
            Case "LessEqual"
                condition = column.LessEqual(TextBoxWhereValue.Text)
                expression = String.Format("LessEqual(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
            Case "Not Less"
                condition = column.Not_Less(TextBoxWhereValue.Text)
                expression = String.Format("Not_Less(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
            Case "Not LessEqual"
                condition = column.Not_LessEqual(TextBoxWhereValue.Text)
                expression = String.Format("Not_LessEqual(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
            Case "In"
                condition = column.[In](TextBoxWhereValue.Text)
                expression = String.Format("In(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
            Case "Not In"
                condition = column.Not_In(TextBoxWhereValue.Text)
                expression = String.Format("Not_In(""{0}"")", TextBoxWhereValue.Text)

                Exit Select
            Case "Like"
                condition = column.[Like](TextBoxWhereValue.Text)
                expression = String.Format("Like(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
            Case "Not Like"
                condition = column.Not_Like(TextBoxWhereValue.Text)
                expression = String.Format("Not_Like(""{0}"")", TextBoxWhereValue.Text)
                Exit Select
        End Select

        ' Add new filter to the query - the filter will be added to the WHERE clause of original query.
        _queryTransformer.Filters.Add(condition)
        CounterFilters.Text = _queryTransformer.Filters.Count.ToString()

        ClearFieldsWhere()

        Dim text as String = String.Format(vbTab & ".Where(_queryTransformer.Columns[{0}].{1})", indexColumn, expression)

        _sourceCodeTransformer.Add(text)
    End Sub

    Private Sub ButtonClearWhere_Click(sender As Object, e As EventArgs) Handles ButtonClearWhere.Click
        ClearFieldsWhere()

        ' Remove all additional filters from query - the original WHERE clause will be restored.
        _queryTransformer.Filters.Clear()

        CounterFilters.Text = _queryTransformer.Filters.Count.ToString()

        For i As Int32 = 0 To _sourceCodeTransformer.Count - 1
            Dim line As String= _sourceCodeTransformer(i)
            If Not line.Contains("Where") Then
                Continue For
            End If

            _sourceCodeTransformer.RemoveAt(i)
            i = 0
        Next
    End Sub

    Private Sub ButtonCodeBehindShow_Click(sender As Object, e As EventArgs) Handles ButtonCodeBehindShow.Click
        Using formCode As CodeBehindForm = New CodeBehindForm()
            formCode.StartPosition = FormStartPosition.CenterParent
            Dim builder As StringBuilder = New StringBuilder()

            For Each line As String In _sourceCodeTransformer
                builder.AppendLine(line)
            Next

            formCode.TextContent = GetCodeBehind()
            formCode.ShowDialog(Me)
        End Using
    End Sub

    Private Function GetCodeBehind() As String
        Dim builder As StringBuilder = New StringBuilder()
        builder.AppendLine("_queryTransformer")

        For Each sorting As SortedColumn In _queryTransformer.Sortings
            Dim code As String= String.Format(vbTab & ".OrderBy(_queryTransformer.Columns[{0}], {1})", _queryTransformer.Columns.IndexOf(sorting.Column), (sorting.SortType = ItemSortType.Asc).ToString().ToLower(CultureInfo.CurrentCulture))
            builder.AppendLine(code)
        Next

        Dim reg As Regex = New Regex("([A-Z])\w+")
        For Each aggregation As AggregatedColumn In _queryTransformer.Aggregations
            Dim result as Match = reg.Match(aggregation.Expression)
            If Not result.Success Then
                Continue For
            End If

            Dim code as String = String.Format(vbTab & ".Select(_queryTransformer.Columns[{0}].{1}())", _queryTransformer.Columns.IndexOf(aggregation.Column), result.Value)
            builder.AppendLine(code)
        Next

        For Each filter As FilterColumnCondition In _queryTransformer.Filters

            Dim code as String = String.Format(vbTab & ".Where(""{0}"")", filter.Condition)
            builder.AppendLine(code)
        Next

        Return builder.ToString()
    End Function
End Class

Public Class CustomColumn
    Public Property Column As OutputColumn

    Public Sub New(column1 As OutputColumn)
        Column = column1
    End Sub

    Public Overrides Function ToString() As String
        Return Column.Column.Expression
    End Function
End Class
