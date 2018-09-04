'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Drawing
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.QueryTransformer

Namespace Common
    Partial Public Class ResultGrid
        Inherits UserControl
        Public Event RowsLoaded As EventHandler

        Private _currentTextSql As String
        Private _needCancelOperation As Boolean
        Private _currentTask As Task(Of DataTable)
        Private _nextTask As Task(Of DataTable)

        Public Property QueryTransformer As QueryTransformer

        Public Property SqlQuery As SQLQuery

        <DefaultValue(True)>
        Public Property EnabledSortings As Boolean

        Public ReadOnly Property RowCount() As Integer
            Get
                Return dataGridView1.RowCount
            End Get
        End Property
        Public Sub New()
            EnabledSortings = True
            InitializeComponent()
        End Sub

        Public Sub FillDataGrid(sqlCommand As String)
            infoPanel1.Message = String.Empty
            bCancel.Enabled = True

            If _currentTextSql = sqlCommand OrElse String.IsNullOrWhiteSpace(sqlCommand) Then
                If Not String.IsNullOrWhiteSpace(sqlCommand) Then
                    Return
                End If

                dataGridView1.DataSource = Nothing
                OnRowsLoaded()
                Return
            End If

            _currentTextSql = sqlCommand

            dataGridView1.DataSource = Nothing

            Dim task As Task(Of DataTable) = New Task(Of DataTable)(Function() ExecuteSql(sqlCommand))

            If _currentTask Is Nothing Then
                _currentTask = task
                TryRunTask()
            Else
                _nextTask = task
                _needCancelOperation = True
            End If
        End Sub

        Public Sub Clear()
            dataGridView1.DataSource = Nothing
        End Sub

        Private Function ExecuteSql(sqlCommand As String) As DataTable
            If String.IsNullOrEmpty(sqlCommand) Then
                Return Nothing
            End If

            If SqlQuery.SQLContext.MetadataProvider Is Nothing Then
                Return Nothing
            End If

            If Not SqlQuery.SQLContext.MetadataProvider.Connected Then
                SqlQuery.SQLContext.MetadataProvider.Connect()
            End If

            Dim command As DbCommand = Helpers.CreateSqlCommand(sqlCommand, SqlQuery)

            Dim table As New DataTable("result")

            Try
                Using dbReader As DbDataReader = command.ExecuteReader()
                    For i As Integer = 0 To dbReader.FieldCount - 1
                        table.Columns.Add(dbReader.GetName(i))
                    Next
                    While dbReader.Read() AndAlso Not _needCancelOperation
                        Dim values As Object() = New Object(dbReader.FieldCount - 1) {}
                        dbReader.GetValues(values)
                        table.Rows.Add(values)
                    End While

                    Return table
                End Using
            Catch ex As Exception
                ShowException(ex)
            End Try

            Return Nothing
        End Function

        Private Sub TryRunTask()
            If _currentTask IsNot Nothing AndAlso (_currentTask.Status = TaskStatus.Running OrElse _currentTask.Status = TaskStatus.WaitingToRun) Then
                Return
            End If

            If _currentTask IsNot Nothing Then
                Invoke(DirectCast(Sub() pLoading.Visible = True, Action))

                _currentTask.ContinueWith(AddressOf TaskCompleted)

                Try
                    _currentTask.Start()
                Catch
                    _currentTask = Nothing
                End Try

                Return
            End If

            If _nextTask Is Nothing Then
                Return
            End If
            _currentTask = _nextTask
            _nextTask = Nothing

            TryRunTask()
        End Sub

        Private Sub TaskCompleted(obj As Task(Of DataTable))
            _currentTask = Nothing
            _needCancelOperation = False

            Invoke(DirectCast(Sub()
                                  dataGridView1.DataSource = obj.Result

                                  pLoading.Visible = _currentTask IsNot Nothing

                                  OnRowsLoaded()

                              End Sub, Action))
            TryRunTask()
        End Sub

        Private Sub ShowException(ex As Exception)
            Invoke(DirectCast(Sub() infoPanel1.Message = ex.Message, Action))
        End Sub

        Private Sub ButtonCancelExecutingSql_OnClick(sender As Object, e As EventArgs)
            If _currentTask Is Nothing OrElse _currentTask.Status <> TaskStatus.Running Then
                Return
            End If

            bCancel.Enabled = False
            _needCancelOperation = True
            _nextTask = Nothing
        End Sub

        Protected Overridable Sub OnRowsLoaded()
            For Each column As DataGridViewColumn In dataGridView1.Columns
                column.SortMode = If(EnabledSortings, DataGridViewColumnSortMode.Programmatic, DataGridViewColumnSortMode.NotSortable)
            Next
            RaiseEvent RowsLoaded(Me, EventArgs.Empty)
        End Sub

        Private Sub dataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)
            If e.RowIndex <> -1 OrElse e.ColumnIndex = -1 OrElse Not EnabledSortings Then
                Return
            End If

            Dim sorting As SortedColumn = QueryTransformer.Sortings.FirstOrDefault(Function(sort) sort.Column.OriginalName = dataGridView1.Columns(e.ColumnIndex).HeaderText)
            If sorting Is Nothing Then
                Return
            End If

            Select Case sorting.SortType
                Case ItemSortType.None
                    dataGridView1.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.None
                    Exit Select
                Case ItemSortType.Asc
                    dataGridView1.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending
                    Exit Select
                Case ItemSortType.Desc
                    dataGridView1.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
                    Exit Select
                Case Else
                    Throw New ArgumentOutOfRangeException()
            End Select

            e.Paint(e.ClipBounds, e.PaintParts)
            Dim sortIndex As Integer = QueryTransformer.Sortings.IndexOf(sorting) + 1
            Dim format As New StringFormat() With {
                .LineAlignment = StringAlignment.Center
            }
            e.Graphics.DrawString(sortIndex.ToString(), dataGridView1.Font, SystemBrushes.ControlText, New Rectangle(e.CellBounds.X + e.CellBounds.Width - 25, e.CellBounds.Y, 25, e.CellBounds.Height), format)
            e.Handled = True
        End Sub

        Private Sub dataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
            If Not EnabledSortings Then
                Return
            End If

            Dim nameColumn As String = dataGridView1.Columns(e.ColumnIndex).HeaderText
            Dim nativeColumnForSorting As DataGridViewColumn = dataGridView1.Columns(e.ColumnIndex)
            Dim currentDirectionSorting As SortOrder = nativeColumnForSorting.HeaderCell.SortGlyphDirection

            If ModifierKeys <> Keys.Control Then
                QueryTransformer.Sortings.Clear()
            End If

            Dim columnForSorting As OutputColumn = QueryTransformer.Columns.FindColumnByResultName(nameColumn)

            Select Case currentDirectionSorting
                Case SortOrder.Ascending
                    QueryTransformer.Sortings.Add(columnForSorting.Desc())
                    Exit Select
                Case SortOrder.Descending
                    QueryTransformer.Sortings.Remove(columnForSorting)
                    Exit Select
                Case SortOrder.None
                    QueryTransformer.Sortings.Add(columnForSorting.Asc())
                    Exit Select
                Case Else
                    Throw New ArgumentOutOfRangeException()
            End Select

            FillDataGrid(QueryTransformer.SQL)
        End Sub
    End Class
End Namespace
