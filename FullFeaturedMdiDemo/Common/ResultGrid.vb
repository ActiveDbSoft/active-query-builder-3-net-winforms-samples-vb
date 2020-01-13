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
	Public Partial Class ResultGrid
		Inherits UserControl
		Public Class ParameterInfo
			Public Property Name() As String
				Get
					Return m_Name
				End Get
				Set
					m_Name = Value
				End Set
			End Property
			Private m_Name As String
			Public Property DataType() As DbType
				Get
					Return m_DataType
				End Get
				Set
					m_DataType = Value
				End Set
			End Property
			Private m_DataType As DbType
			Public Property Value() As Object
				Get
					Return m_Value
				End Get
				Set
					m_Value = Value
				End Set
			End Property
			Private m_Value As Object
		End Class

		Public ReadOnly ParamsCache As New List(Of ParameterInfo)()

		Public Event RowsLoaded As EventHandler

		Private _currentTextSql As String
		Private _needCancelOperation As Boolean
		Private _currentTask As Task(Of DataTable)
		Private _nextTask As Task(Of DataTable)

		Public Property QueryTransformer() As QueryTransformer
			Get
				Return m_QueryTransformer
			End Get
			Set
				m_QueryTransformer = Value
			End Set
		End Property
		Private m_QueryTransformer As QueryTransformer

		Public Property SqlQuery() As SQLQuery
			Get
				Return m_SqlQuery
			End Get
			Set
				m_SqlQuery = Value
			End Set
		End Property
		Private m_SqlQuery As SQLQuery

		<DefaultValue(True)> _
		Public Property EnabledSortings() As Boolean
			Get
				Return m_EnabledSortings
			End Get
			Set
				m_EnabledSortings = Value
			End Set
		End Property
		Private m_EnabledSortings As Boolean

		Public ReadOnly Property RowCount() As Integer
			Get
				Return dataGridView1.RowCount
			End Get
		End Property

		Public Sub New()
			EnabledSortings = True
			InitializeComponent()
		End Sub

		Public Sub FillDataGrid(sqlCommand As String, Optional force As Boolean = False)
			infoPanel1.Message = String.Empty
			bCancel.Enabled = True

			If (_currentTextSql = sqlCommand OrElse String.IsNullOrWhiteSpace(sqlCommand)) AndAlso Not force Then
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

		Public Function CreateSqlCommand(sqlCommand As String, sqlQuery As SQLQuery) As DbCommand
			Dim command As DbCommand = DirectCast(sqlQuery.SQLContext.MetadataProvider.Connection.CreateCommand(), DbCommand)
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
				Dim qpf = New QueryParametersForm(command)
				If qpf.ShowDialog() = DialogResult.OK Then
					SaveParamsToCache(command)
				Else
					Return Nothing
				End If
			End If

			Return command
		End Function

		Public Sub ClearParamsCache()
			ParamsCache.Clear()
		End Sub

		Private Sub SaveParamsToCache(command As DbCommand)
			ClearParamsCache()
			For Each parameter As DbParameter In command.Parameters
				If parameter.Value IsNot Nothing Then
					ParamsCache.Add(New ParameterInfo() With { _
						.Name = parameter.ParameterName, _
						.DataType = parameter.DbType, _
						.Value = parameter.Value _
					})
				End If
			Next
		End Sub

		Private Function ApplyParamsFromCache(command As DbCommand, query As SQLQuery) As Boolean
			Dim result = True
			For Each parameter As Parameter In query.QueryParameters
				Dim cached = ParamsCache.FirstOrDefault(Function(x) x.Name = parameter.FullName AndAlso x.DataType = parameter.DataType)

				Dim param = command.CreateParameter()
				param.ParameterName = parameter.FullName
				param.DbType = parameter.DataType
				If cached IsNot Nothing Then
					param.Value = cached.Value
				Else
					result = False
				End If

				command.Parameters.Add(param)
			Next

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
					Next
					While dbReader.Read() AndAlso Not _needCancelOperation
						Dim values As Object() = New Object(dbReader.FieldCount - 1) {}
						dbReader.GetValues(values)
						table.Rows.Add(values)
					End While

					Return table
				End Using
			Catch ex As Exception
				ParamsCache.Clear()
				ShowException(ex)
			End Try

			Return Nothing
		End Function

		Private _usedParamsPanel As Control
		Private Sub ShowUsedParams()
			HideUsedParams()

			_usedParamsPanel = New Panel() With { _
				.AutoSize = True, _
				.AutoSizeMode = AutoSizeMode.GrowAndShrink, _
				.BackColor = Color.LightGoldenrodYellow, _
				.BorderStyle = BorderStyle.FixedSingle, _
				.Dock = DockStyle.Top, _
				.Padding = New Padding(2, 2, 2, 2) _
			}

			Dim parameters = ParamsCache.[Select](Function(x) String.Format("{0} = {1}", x.Name, x.Value))
			Dim paramsString = "Used parameters: " & String.Join(", ", parameters)

			Dim label As New Label() With { _
				.AutoSize = True, _
				.Padding = New Padding(4, 3, 1, 0), _
				.Text = paramsString, _
				.Dock = DockStyle.Fill, _
				.UseCompatibleTextRendering = True _
			}

			Dim button As Button = New Button() With { _
				.Text = "Edit", _
				.Dock = DockStyle.Right, _
				.BackColor = SystemColors.Control, _
				.Margin = New Padding(5) _
			}

			AddHandler button.Click, AddressOf EditParamsButtonOnClick

			_usedParamsPanel.Controls.Add(button)
			_usedParamsPanel.Controls.Add(label)
			_usedParamsPanel.Visible = True
			Controls.Add(_usedParamsPanel)
		End Sub

		Private Sub EditParamsButtonOnClick(sender As Object, eventArgs As EventArgs)
			ParamsCache.Clear()
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

			If ParamsCache.Count <> 0 AndAlso dataGridView1.DataSource IsNot Nothing Then
				ShowUsedParams()
			Else
				HideUsedParams()
			End If

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
			Dim format As New StringFormat() With { _
				.LineAlignment = StringAlignment.Center _
			}
			e.Graphics.DrawString(sortIndex.ToString(), dataGridView1.Font, SystemBrushes.ControlText, New Rectangle(e.CellBounds.X + e.CellBounds.Width - 25, e.CellBounds.Y, 25, e.CellBounds.Height), format)
			e.Handled = True
		End Sub

		Private Sub dataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
			If Not EnabledSortings Then
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
