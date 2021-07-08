''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2021 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports ActiveQueryBuilder.Core.QueryTransformer

Namespace DataViewerControl
    Partial Public Class DataViewer
        Inherits UserControl
        Public Class ParameterInfo
            Public Property Name() As String
            Public Property DataType() As DbType
            Public Property Value() As Object
        End Class

        Public Event RowsLoaded As EventHandler

        Private _currentTextSql As String
        Private _needCancelOperation As Boolean
        Private _currentTask As Task(Of DataTable)
        Private _nextTask As Task(Of DataTable)
        Private _queryTransformer As QueryTransformer
        Private _sqlQuery As SQLQuery

        Public Property QueryTransformer() As QueryTransformer
            Set(value As QueryTransformer)
                If _queryTransformer IsNot Nothing Then
                    RemoveHandler _queryTransformer.SQLUpdated, AddressOf QueryTransformerOnSqlUpdated
                End If
                _queryTransformer = value
                If _queryTransformer IsNot Nothing Then
                    AddHandler _queryTransformer.SQLUpdated, AddressOf QueryTransformerOnSqlUpdated
                End If
            End Set
            Get
                Return _queryTransformer
            End Get
        End Property

        Public Property SqlQuery() As SQLQuery
            Set(value As SQLQuery)
                _sqlQuery = value

                If _sqlQuery IsNot Nothing AndAlso QueryTransformer Is Nothing Then
                    QueryTransformer = New QueryTransformer With {.QueryProvider = SqlQuery}
                End If
            End Set
            Get
                Return _sqlQuery
            End Get
        End Property

        <DefaultValue(True)>
        Public Property EnabledSorting() As Boolean

        Public ReadOnly Property RowCount As Integer
            Get
                Return dataGridView1.RowCount
            End Get
        End Property

        Public Sub New()
            EnabledSorting = True
            InitializeComponent()
        End Sub

        Public Sub FillDataGrid(sqlCommand As String, Optional force As Boolean = False)
            infoPanel1.Message = String.Empty
            bCancel.Enabled = True

            If (_currentTextSql = sqlCommand OrElse String.IsNullOrWhiteSpace(sqlCommand)) AndAlso (Not force) Then
                If Not String.IsNullOrWhiteSpace(sqlCommand) Then
                    Return
                End If

                dataGridView1.DataSource = Nothing
                OnRowsLoaded()
                Return
            End If

            _currentTextSql = sqlCommand

            dataGridView1.DataSource = Nothing

            Dim task = New Task(Of DataTable)(Function() ExecuteSql(sqlCommand))

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

        Private Sub QueryTransformerOnSqlUpdated(sender As Object, e As EventArgs)
            RefreshPaginationPanel()
        End Sub

        Private Function CreateSqlCommand(sqlCommand As String, sqlQuery As SQLQuery) As DbCommand
            Dim command As DbCommand = CType(sqlQuery.SQLContext.MetadataProvider.Connection.CreateCommand(), DbCommand)
            command.CommandText = sqlCommand

            ' handle the query parameters
            If sqlQuery.QueryParameters.Count = 0 Then
                ClearParamsCache()
                Return command
            End If

            Dim allApllied = ApplyParamsFromCache(command, sqlQuery)
            If allApllied Then
                Return command
            Else
                Dim qpf = New Forms.QueryInformationForms.QueryParametersForm(command)
                If qpf.ShowDialog() = DialogResult.OK Then
                    SaveParamsToCache(command)
                Else
                    Return Nothing
                End If
            End If

            Return command
        End Function

        Public Sub ClearParamsCache()
            Misc.ParamsCache.Clear()
        End Sub

        Private Sub SaveParamsToCache(command As DbCommand)
            ClearParamsCache()
            For Each parameter As DbParameter In command.Parameters
                If parameter.Value IsNot Nothing Then
                    Misc.ParamsCache.Add(New ParameterInfo With {.Name = parameter.ParameterName, .DataType = parameter.DbType, .Value = parameter.Value})
                End If
            Next parameter
        End Sub

        Private Function ApplyParamsFromCache(command As DbCommand, query As SQLQuery) As Boolean
            Dim result = True
            For Each parameter In query.QueryParameters
                Dim cached = Misc.ParamsCache.FirstOrDefault(Function(x) x.Name = parameter.FullName AndAlso x.DataType = parameter.DataType)

                Dim param = command.CreateParameter()
                param.ParameterName = parameter.FullName
                param.DbType = parameter.DataType
                If cached IsNot Nothing Then
                    param.Value = cached.Value
                Else
                    result = False
                End If

                command.Parameters.Add(param)
            Next parameter

            Return result
        End Function

        Public Function ExecuteSql(sqlCommand As String) As DataTable
            If String.IsNullOrEmpty(sqlCommand) Then
                Return Nothing
            End If

            If SqlQuery.SQLContext.MetadataProvider Is Nothing Then
                Return Nothing
            End If

            If Not SqlQuery.SQLContext.MetadataProvider.Connected Then
                SqlQuery.SQLContext.MetadataProvider.Connect()
            End If

            If String.IsNullOrEmpty(sqlCommand) Then
                Return Nothing
            End If

            If Not SqlQuery.SQLContext.MetadataProvider.Connected Then
                SqlQuery.SQLContext.MetadataProvider.Connect()
            End If

            Dim command = CreateSqlCommand(sqlCommand, SqlQuery)
            If command Is Nothing Then
                Return Nothing
            End If

            Dim table As New DataTable("result")

            Try
                Using dbReader = command.ExecuteReader()
                    For i As Integer = 0 To dbReader.FieldCount - 1
                        table.Columns.Add(dbReader.GetName(i))
                    Next i

                    Do While dbReader.Read() AndAlso Not _needCancelOperation
                        Dim values(dbReader.FieldCount - 1) As Object
                        dbReader.GetValues(values)
                        table.Rows.Add(values)
                    Loop

                    Return table
                End Using
            Catch ex As Exception
                Misc.ParamsCache.Clear()
                ShowException(ex)
            End Try

            Return Nothing
        End Function

        Private _usedParamsPanel As Control
        Private Sub ShowUsedParams()
            HideUsedParams()

            _usedParamsPanel = New Panel With {.AutoSize = True, .AutoSizeMode = AutoSizeMode.GrowAndShrink, .BackColor = Color.LightGoldenrodYellow, .BorderStyle = BorderStyle.FixedSingle, .Dock = DockStyle.Top, .Padding = New Padding(2, 2, 2, 2)}

            Dim parameters = Misc.ParamsCache.Select(Function(x) String.Format("{0} = {1}", x.Name, x.Value))
            Dim paramsString = "Used parameters: " & String.Join(", ", parameters)

            Dim label As Label = New Label With {.AutoSize = True, .Padding = New Padding(4, 3, 1, 0), .Text = paramsString, .Dock = DockStyle.Fill, .UseCompatibleTextRendering = True}

            Dim button = New Button With {.Text = "Edit", .Dock = DockStyle.Right, .BackColor = SystemColors.Control, .Margin = New Padding(5)}

            AddHandler button.Click, AddressOf EditParamsButtonOnClick

            _usedParamsPanel.Controls.Add(button)
            _usedParamsPanel.Controls.Add(label)
            _usedParamsPanel.Visible = True
            Controls.Add(_usedParamsPanel)
        End Sub

        Private Sub EditParamsButtonOnClick(sender As Object, eventArgs As EventArgs)
            Misc.ParamsCache.Clear()
            FillDataGrid(_currentTextSql, True)
        End Sub

        Private Sub HideUsedParams()
            If _usedParamsPanel IsNot Nothing Then
                _usedParamsPanel.Visible = False
                If _usedParamsPanel.Parent IsNot Nothing Then
                    _usedParamsPanel.Parent.Controls.Remove(_usedParamsPanel)
                End If
                _usedParamsPanel.Dispose()
                _usedParamsPanel = Nothing
            End If
        End Sub

        Private Sub TryRunTask()
            If _currentTask IsNot Nothing AndAlso (_currentTask.Status = TaskStatus.Running OrElse _currentTask.Status = TaskStatus.WaitingToRun) Then
                Return
            End If

            If _currentTask IsNot Nothing Then
                Invoke(CType(Sub() pLoading.Visible = True, Action))

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
            Invoke(Sub()
                       dataGridView1.DataSource = obj.Result
                       If Misc.ParamsCache.Count <> 0 AndAlso dataGridView1.DataSource IsNot Nothing Then
                           ShowUsedParams()
                       Else
                           HideUsedParams()
                       End If
                       pLoading.Visible = _currentTask IsNot Nothing
                       OnRowsLoaded()
                   End Sub)

            TryRunTask()
        End Sub

        Private Sub ShowException(ex As Exception)
            Invoke(CType(Sub() infoPanel1.Message = ex.Message, Action))
        End Sub

        Private Sub ButtonCancelExecutingSql_OnClick(sender As Object, e As EventArgs) Handles bCancel.Click
            If _currentTask Is Nothing OrElse _currentTask.Status <> TaskStatus.Running Then
                Return
            End If

            bCancel.Enabled = False
            _needCancelOperation = True
            _nextTask = Nothing
        End Sub

        Protected Overridable Sub OnRowsLoaded()
            For Each column As DataGridViewColumn In dataGridView1.Columns
                column.SortMode = If(EnabledSorting, DataGridViewColumnSortMode.Programmatic, DataGridViewColumnSortMode.NotSortable)
            Next column
            RaiseEvent RowsLoaded(Me, EventArgs.Empty)
        End Sub

        Private Sub dataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dataGridView1.CellPainting
            If e.RowIndex <> -1 OrElse e.ColumnIndex = -1 OrElse (Not EnabledSorting) Then
                Return
            End If

            Dim sorting As SortedColumn = QueryTransformer.Sortings.FirstOrDefault(Function(sort) sort.Column.OriginalName = dataGridView1.Columns(e.ColumnIndex).HeaderText)
            If sorting Is Nothing Then
                Return
            End If

            Select Case sorting.SortType
                Case ItemSortType.None
                    dataGridView1.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.None
                Case ItemSortType.Asc
                    dataGridView1.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending
                Case ItemSortType.Desc
                    dataGridView1.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
                Case Else
                    Throw New ArgumentOutOfRangeException()
            End Select

            e.Paint(e.ClipBounds, e.PaintParts)
            Dim sortIndex As Integer = QueryTransformer.Sortings.IndexOf(sorting) + 1
            Dim format As StringFormat = New StringFormat With {.LineAlignment = StringAlignment.Center}
            e.Graphics.DrawString(sortIndex.ToString(), dataGridView1.Font, SystemBrushes.ControlText, New Rectangle(e.CellBounds.X + e.CellBounds.Width - 25, e.CellBounds.Y, 25, e.CellBounds.Height), format)
            e.Handled = True
        End Sub

        Private Sub dataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataGridView1.ColumnHeaderMouseClick
            If Not EnabledSorting Then
                Return
            End If

            Dim nameColumn = dataGridView1.Columns(e.ColumnIndex).HeaderText
            Dim nativeColumnForSorting = dataGridView1.Columns(e.ColumnIndex)
            Dim currentDirectionSorting = nativeColumnForSorting.HeaderCell.SortGlyphDirection

            If ModifierKeys <> Keys.Control Then
                QueryTransformer.Sortings.Clear()
            End If

            Dim columnForSorting = QueryTransformer.Columns.FindColumnByResultName(nameColumn)

            Select Case currentDirectionSorting
                Case SortOrder.Ascending
                    QueryTransformer.Sortings.Add(columnForSorting.Desc())
                Case SortOrder.Descending
                    QueryTransformer.Sortings.Remove(columnForSorting)
                Case SortOrder.None
                    QueryTransformer.Sortings.Add(columnForSorting.Asc())
                Case Else
                    Throw New ArgumentOutOfRangeException()
            End Select

            FillDataGrid(QueryTransformer.SQL)
        End Sub

        'private void RowsLoaded(object sender, EventArgs e)
        '{
        '    if (!paginationPanel1.Enabled)
        '        paginationPanel1.RowsCount = resultGrid1.RowCount;
        '}

        Private Sub paginationPanel1_EnabledPaginationChanged(sender As Object, e As EventArgs) Handles paginationPanel1.EnabledPaginationChanged
            ' Turn paging on and off

            If paginationPanel1.PaginationEnabled Then
                QueryTransformer.Take(paginationPanel1.PageSize.ToString())
            Else
                paginationPanel1.Clear()

                QueryTransformer.BeginUpdate()
                Try
                    QueryTransformer.Take("")
                    QueryTransformer.Skip("")
                Finally
                    QueryTransformer.EndUpdate()
                End Try
            End If
        End Sub


        Private Sub RefreshPaginationPanel()
            paginationPanel1.Visible = QueryTransformer.IsSupportLimitCount OrElse QueryTransformer.IsSupportLimitOffset
            paginationPanel1.IsSupportLimitCount = QueryTransformer.IsSupportLimitCount
            paginationPanel1.IsSupportLimitOffset = QueryTransformer.IsSupportLimitOffset
        End Sub

        Private Sub paginationPanel1_CurrentPageChanged(sender As Object, e As EventArgs) Handles paginationPanel1.CurrentPageChanged
            If paginationPanel1.CurrentPage = 1 Then
                QueryTransformer.Skip("")
                Return
            End If

            ' Setting the current page number
            QueryTransformer.Skip((paginationPanel1.PageSize * (paginationPanel1.CurrentPage - 1)).ToString())
        End Sub

        Private Sub paginationPanel1_PageSizeChanged(sender As Object, e As EventArgs) Handles paginationPanel1.PageSizeChanged
            ' Setting the number of records per page
            QueryTransformer.Take(paginationPanel1.PageSize.ToString())
            If paginationPanel1.CurrentPage > 1 Then
                QueryTransformer.Skip((paginationPanel1.PageSize * (paginationPanel1.CurrentPage - 1)).ToString())
            End If
        End Sub
    End Class
End Namespace
