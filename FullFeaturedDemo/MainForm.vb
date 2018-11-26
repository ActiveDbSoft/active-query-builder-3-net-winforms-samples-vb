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
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports Oracle.ManagedDataAccess.Client
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.QueryTransformer
Imports ActiveQueryBuilder.View.WinForms

Imports FullFeaturedDemo.Dailogs
Imports FullFeaturedDemo.PropertiesForm
Imports MySql.Data.MySqlClient
Imports Npgsql
Imports Helpers = ActiveQueryBuilder.Core.Helpers
Imports SortOrder = System.Windows.Forms.SortOrder

Public Partial Class MainForm
	Inherits Form
	Private _selectedConnection As ConnectionInfo
	Private ReadOnly _sqlFormattingOptions As SQLFormattingOptions
	Private ReadOnly _sqlGenerationOptions As SQLGenerationOptions
	Private _fileSourcePath As String
	Private _oldSql As String
	Private ReadOnly _sortedColumns As New Dictionary(Of String, SortOrder)()
	Private _hasError As Boolean
	Private _noConnectionLabel As NoConnectionLabel

	Public Sub New()
		InitializeComponent()

		' Options to present the formatted SQL query text to end-user
		' Use names of virtual objects, do not replace them with appropriate derived tables
		_sqlFormattingOptions = New SQLFormattingOptions()
		AddHandler _sqlFormattingOptions.Updated, AddressOf _sqlFormattingOptions_Updated

		' Options to generate the SQL query text for execution against a database server
		' Replace virtual objects with derived tables
		_sqlGenerationOptions = New SQLGenerationOptions() With { _
			.ExpandVirtualObjects = True _
		}

		If Program.Settings.WindowPlacement = Rectangle.Empty Then
			StartPosition = FormStartPosition.WindowsDefaultLocation
		Else
			Bounds = Program.Settings.WindowPlacement
		End If

		If Program.Settings.IsMaximized Then
			WindowState = FormWindowState.Maximized
		End If

		queryBuilder1.SyntaxProvider = New GenericSyntaxProvider()
		queryBuilder1.SQLQuery.QueryRoot.AllowSleepMode = True
		AddHandler queryBuilder1.SQLContext.SyntaxProviderChanged, AddressOf _sqlContext_SyntaxProviderChanged
		CBuilder.QueryTransformer = New QueryTransformer() With { _
			.Query = queryBuilder1.SQLQuery, _
			.SQLGenerationOptions = _sqlFormattingOptions _
		}
		AddHandler CBuilder.QueryTransformer.SQLUpdated, AddressOf CBuilder_SQLUpdated

		LoadLanguages()

		AddHandler queryBuilder1.SleepModeChanged, AddressOf SqlQuery_SleepModeChanged
		AddHandler queryBuilder1.QueryAwake, AddressOf SqlQuery_QueryAwake
		AddHandler SizeChanged, AddressOf MainForm_SizeChanged
		AddHandler LocationChanged, AddressOf MainForm_LocationChanged
		AddHandler Application.Idle, AddressOf Application_Idle
		UpdateLanguage()
	End Sub

	Public ReadOnly Property FormattedQueryText() As String
		Get
			Return FormattedSQLBuilder.GetSQL(queryBuilder1.SQLQuery.QueryRoot, _sqlFormattingOptions)
		End Get
	End Property

	Private Sub LoadMetadataFromXml()
		Dim fileDialog As New OpenFileDialog() With { _
			.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*" _
		}
		If fileDialog.ShowDialog() = DialogResult.OK Then
			queryBuilder1.MetadataContainer.LoadingOptions.OfflineMode = True
			queryBuilder1.MetadataContainer.ImportFromXML(fileDialog.FileName)
		End If
	End Sub

	Private Sub SaveMetadataToXml()
		Dim fileDialog As New SaveFileDialog() With { _
			.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*", _
			.FileName = "Metadata.xml" _
		}
		If fileDialog.ShowDialog() = DialogResult.OK Then
			queryBuilder1.MetadataContainer.LoadAll(True)
			queryBuilder1.MetadataContainer.ExportToXML(fileDialog.FileName)
		End If
	End Sub

	Public Sub UpdateLanguage()
		queryBuilder1.Language = Program.Settings.Language
		tsbQueryProperties.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strEdit", "Properties")
		tsbAddObject.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAddObject", "Add object")
		tsbAddDerivedTable.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAddSubQuery", "Add derived table")
		tsbAddUnionSubquery.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strNewUnionSubQuery", "New union sub-query")
		tsbCopyUnionSubquery.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strCopyToNewUnionSubQuery", "Copy union sub-query")
	End Sub

	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing Then
			' ReSharper disable once MergeSequentialChecks
			If queryBuilder1 IsNot Nothing AndAlso queryBuilder1.MetadataProvider IsNot Nothing AndAlso queryBuilder1.MetadataProvider.Connection IsNot Nothing Then
				queryBuilder1.MetadataProvider.Connection.Close()
			End If
			RemoveHandler Application.Idle, AddressOf Application_Idle
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If

		MyBase.Dispose(disposing)
	End Sub

	Private Sub LoadLanguages()
		For Each language As String In Helpers.Localizer.Languages
			Dim lang As String = language.ToLower()
			Dim menuItem As ToolStripItem
			If lang = "auto" Then
				menuItem = tsmiLanguageAuto
			ElseIf lang = "default" Then
				menuItem = tsmiLanguageDefault
			Else
				Dim culture As CultureInfo = CultureInfo.GetCultureInfo(lang)
				menuItem = languageToolStripMenuItem.DropDownItems.Add(culture.NativeName, Nothing, AddressOf Language_Click)
				menuItem.Tag = lang
			End If
			If String.Equals(TryCast(menuItem.Tag, String), Program.Settings.Language, StringComparison.OrdinalIgnoreCase) Then
				DirectCast(menuItem, ToolStripMenuItem).Checked = True
			End If
		Next
	End Sub

	Private Sub InitializeSqlContext()
		Try
			Cursor = Cursors.WaitCursor

			Dim metadataProvaider As BaseMetadataProvider = Nothing
			Dim syntaxSyntaxProvider As BaseSyntaxProvider

			' create new SqlConnection object using the connections string from the connection form
			If Not _selectedConnection.IsXmlFile Then
				Select Case _selectedConnection.ConnectionType
					Case ConnectionTypes.MSSQL
						syntaxSyntaxProvider = New MSSQLSyntaxProvider()
						metadataProvaider = New MSSQLMetadataProvider() With { _
							.Connection = New SqlConnection(_selectedConnection.ConnectionString) _
						}
						Exit Select
					Case ConnectionTypes.MSAccess
						syntaxSyntaxProvider = New MSAccessSyntaxProvider()
						metadataProvaider = New OLEDBMetadataProvider() With { _
							.Connection = New OleDbConnection(_selectedConnection.ConnectionString) _
						}
						Exit Select
					Case ConnectionTypes.Oracle
						syntaxSyntaxProvider = New OracleSyntaxProvider()
						metadataProvaider = New OracleNativeMetadataProvider() With { _
							.Connection = New OracleConnection(_selectedConnection.ConnectionString) _
						}
						Exit Select
					Case ConnectionTypes.MySQL
						syntaxSyntaxProvider = New MySQLSyntaxProvider()
						metadataProvaider = New MySQLMetadataProvider() With { _
							.Connection = New MySqlConnection(_selectedConnection.ConnectionString) _
						}
						Exit Select
					Case ConnectionTypes.PostgreSQL
						syntaxSyntaxProvider = New PostgreSQLSyntaxProvider()
						metadataProvaider = New MySQLMetadataProvider() With { _
							.Connection = New NpgsqlConnection(_selectedConnection.ConnectionString) _
						}
						Exit Select
					Case ConnectionTypes.OLEDB
						syntaxSyntaxProvider = New SQL92SyntaxProvider()
						metadataProvaider = New OLEDBMetadataProvider() With { _
							.Connection = New OleDbConnection(_selectedConnection.ConnectionString) _
						}
						Exit Select
					Case ConnectionTypes.ODBC
						syntaxSyntaxProvider = New SQL92SyntaxProvider()
						metadataProvaider = New ODBCMetadataProvider() With { _
							.Connection = New OdbcConnection(_selectedConnection.ConnectionString) _
						}
						Exit Select
					Case Else
						Throw New ArgumentOutOfRangeException()
				End Select
			Else
				Select Case _selectedConnection.ConnectionType
					Case ConnectionTypes.MSSQL
						syntaxSyntaxProvider = New MSSQLSyntaxProvider()
						Exit Select
					Case ConnectionTypes.MSAccess
						syntaxSyntaxProvider = New MSAccessSyntaxProvider()
						Exit Select
					Case ConnectionTypes.Oracle
						syntaxSyntaxProvider = New OracleSyntaxProvider()
						Exit Select
					Case ConnectionTypes.MySQL
						syntaxSyntaxProvider = New MySQLSyntaxProvider()
						Exit Select
					Case ConnectionTypes.PostgreSQL
						syntaxSyntaxProvider = New PostgreSQLSyntaxProvider()
						Exit Select
					Case ConnectionTypes.OLEDB
						syntaxSyntaxProvider = New SQL92SyntaxProvider()
						Exit Select
					Case ConnectionTypes.ODBC
						syntaxSyntaxProvider = New SQL92SyntaxProvider()
						Exit Select
					Case Else
						Throw New ArgumentOutOfRangeException()
				End Select
			End If

			' setup the query builder with metadata and syntax providers
			queryBuilder1.SQLContext.MetadataContainer.Clear()
			queryBuilder1.MetadataProvider = metadataProvaider
			queryBuilder1.SyntaxProvider = syntaxSyntaxProvider
			queryBuilder1.MetadataLoadingOptions.OfflineMode = metadataProvaider Is Nothing

			If metadataProvaider Is Nothing Then
				queryBuilder1.MetadataContainer.ImportFromXML(_selectedConnection.ConnectionString)
			End If

			' Instruct the query builder to fill the database schema tree
			queryBuilder1.InitializeDatabaseSchemaTree()

			toolStripStatusLabel1.Text = "Query builder state: " & (If(queryBuilder1.SleepMode, "Inactive", "Active"))
			RefreshNoConnectionLabel()
			If queryBuilder1.MetadataProvider IsNot Nothing Then
				' load from cache
				'load from database server
				Cursor = Cursors.WaitCursor

				Try
					Dim start As DateTime = DateTime.Now

					' ask for caching
					If (DateTime.Now - start).Seconds > 60 Then
						Dim message As String = "Do you want to cache the database structure to quicken further loading?"

						If MessageBox.Show(message, "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
							Dim dir As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\FullFeaturedDemo\"
							Dim cacheFile As String = dir & _selectedConnection.GetHashCode() & ".xml"

							If Not Directory.Exists(dir) Then
								Directory.CreateDirectory(dir)
							End If

							' preload database databases/schemas/objects for export, but skip params/fields/foreign keys
							queryBuilder1.MetadataContainer.LoadAll(False)
							queryBuilder1.MetadataContainer.ExportToXML(cacheFile)
							_selectedConnection.CacheFile = cacheFile
						End If
					End If
				Catch ex As Exception
					MessageBox.Show(ex.Message)
				Finally
					Cursor = Cursors.[Default]
				End Try
			End If
		Finally
			Cursor = Cursors.[Default]
		End Try
	End Sub

	Public ReadOnly Property CanShowProperties() As Boolean
		Get
			Return queryBuilder1.ActiveUnionSubQuery IsNot Nothing
		End Get
	End Property

	Public ReadOnly Property CanAddUnionSubQuery() As Boolean
		Get
			If queryBuilder1.ActiveUnionSubQuery IsNot Nothing AndAlso queryBuilder1.ActiveUnionSubQuery.QueryRoot.IsSubQuery Then
				Return queryBuilder1.SyntaxProvider.IsSupportSubQueryUnions()
			End If
			Return queryBuilder1.SyntaxProvider IsNot Nothing AndAlso queryBuilder1.SyntaxProvider.IsSupportUnions()
		End Get
	End Property

	Public ReadOnly Property CanCopyUnionSubQuery() As Boolean
		Get
			Return CanAddUnionSubQuery
		End Get
	End Property

	Public ReadOnly Property CanAddDerivedTable() As Boolean
		Get
			If queryBuilder1.SyntaxProvider Is Nothing Then
				Return False
			End If
			If queryBuilder1.ActiveUnionSubQuery IsNot Nothing AndAlso queryBuilder1.ActiveUnionSubQuery.QueryRoot.IsMainQuery Then
				Return queryBuilder1.SyntaxProvider.IsSupportDerivedTables()
			End If
			Return queryBuilder1.SyntaxProvider IsNot Nothing AndAlso queryBuilder1.SyntaxProvider.IsSupportSubQueryDerivedTables()
		End Get
	End Property

	Private ReadOnly Property CanAddObject() As Boolean
		Get
			Return queryBuilder1.AddObjectDialog IsNot Nothing
		End Get
	End Property

	Public Sub ShowErrorBanner(text As String)
		HideErrorBanner()
		_hasError = True
		Dim label As New Label() With { _
			.Name = "ErrorBanner", _
			.Text = text, _
			.BorderStyle = BorderStyle.FixedSingle, _
			.BackColor = Color.LightPink, _
			.AutoSize = True, _
			.Visible = True _
		}
		teSql.Controls.Add(label)
		teSql.Controls.SetChildIndex(label, 0)
		label.Location = New Point(teSql.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2)
	End Sub

	Private Sub HideErrorBanner()
		For Each banner As Label In teSql.Controls.OfType(Of Label)().Where(Function(item) item.Name.StartsWith("ErrorBanner"))
			banner.Dispose()
		Next
		_hasError = False
	End Sub

	Private Sub Language_Click(sender As Object, e As EventArgs)
		Dim currentItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
		If currentItem Is Nothing OrElse Equals(currentItem.Tag, Helpers.Localizer.Language) Then
			Return
		End If
		Dim checkedItem As ToolStripMenuItem = languageToolStripMenuItem.DropDownItems.OfType(Of ToolStripMenuItem)().FirstOrDefault(Function(item) item.Checked)
		If checkedItem IsNot Nothing Then
			checkedItem.Checked = False
		End If
		Program.Settings.Language = DirectCast(currentItem.Tag, String)
		UpdateLanguage()
		currentItem.Checked = True
	End Sub

	Private Sub Application_Idle(sender As Object, e As EventArgs)
		tsmiParseQuery.Enabled = True
		tsmiUndo.Enabled = CanUndo
		tsmiRedo.Enabled = CanRedo
		tsmiCut.Enabled = CanCut
		tsmiCopy.Enabled = CanCopy
		tsmiPaste.Enabled = CanPaste
		tsmiSelectAll.Enabled = CanSelectAll
		tsbCut.Enabled = CanCut
		tsbCopy.Enabled = CanCopy
		tsbPaste.Enabled = CanPaste

		tsmiSave.Enabled = True
		tsmiBuildQuery.Enabled = True
		tsmiRunQuery.Enabled = True
		tsmiQueryStatistics.Enabled = True
		toolStripButtonNewQuery.Enabled = InlineAssignHelper(newQueryToolStripMenuItem1.Enabled, queryBuilder1.SQLContext IsNot Nothing)
		tsbQueryProperties.Enabled = queryBuilder1.SQLContext IsNot Nothing
		tsbSave.Enabled = queryBuilder1.SQLContext IsNot Nothing
		tsbAddObject.Enabled = queryBuilder1.SQLContext IsNot Nothing
		tsbSaveInFile.Enabled = queryBuilder1.SQLContext IsNot Nothing
		tabControl1.Enabled = queryBuilder1.SQLContext IsNot Nothing
		tsmiOfflineMode.Enabled = True
		tsmiOfflineMode.Checked = queryBuilder1.SQLContext Is Nothing OrElse queryBuilder1.MetadataContainer.LoadingOptions.OfflineMode
		tsmiRefreshMetadata.Enabled = True
		tsmiEditMetadata.Enabled = True
		tsmiClearMetadata.Enabled = True
		tsmiLoadMetadataFromXML.Enabled = True
		tsmiSaveMetadataToXML.Enabled = True

		addDerivedTableToolStripMenuItem.Enabled = CanAddDerivedTable
		addObjectToolStripMenuItem.Enabled = CanAddObject
		addUnionSubqueryToolStripMenuItem.Enabled = CanAddUnionSubQuery
		copyUnionSubwueryToolStripMenuItem.Enabled = CanCopyUnionSubQuery

		tsbEditMetadata.Enabled = queryBuilder1.SQLContext IsNot Nothing AndAlso queryBuilder1.MetadataContainer IsNot Nothing

		Dim supportsDerivedTable As Boolean = False
		Dim supportsUnion As Boolean = False

		If queryBuilder1.ActiveUnionSubQuery IsNot Nothing AndAlso queryBuilder1.SQLContext IsNot Nothing AndAlso queryBuilder1.SyntaxProvider IsNot Nothing Then
			supportsDerivedTable = If(queryBuilder1.ActiveUnionSubQuery.QueryRoot.IsMainQuery, queryBuilder1.SyntaxProvider.IsSupportDerivedTables(), queryBuilder1.SyntaxProvider.IsSupportSubQueryDerivedTables())
			supportsUnion = If(queryBuilder1.ActiveUnionSubQuery.QueryRoot.IsSubQuery, queryBuilder1.SyntaxProvider.IsSupportSubQueryUnions(), queryBuilder1.SyntaxProvider.IsSupportUnions())
		End If
		tsbAddDerivedTable.Enabled = supportsDerivedTable
		tsbAddUnionSubquery.Enabled = supportsUnion
		tsbCopyUnionSubquery.Enabled = supportsUnion
	End Sub

	Private Sub SqlQuery_QueryAwake(sender As QueryRoot, ByRef abort As Boolean)
		If MessageBox.Show("You had typed something that is not a SELECT statement in the text editor and continued with visual query building." & "Whatever the text in the editor is, it will be replaced with the SQL generated by the component. Is it right?", "Active Query Builder .NET Demo", MessageBoxButtons.YesNo) = DialogResult.No Then
			abort = True
		End If
	End Sub

	Private Sub SqlQuery_SleepModeChanged(sender As Object, e As EventArgs)
		'  panelTextInfo.Height = SqlQuery.SleepMode ? 60 : 0;
		toolStripStatusLabel1.Text = "Query builder state: " & (If(queryBuilder1.SleepMode, "Inactive", "Active"))
	End Sub

	Private Sub CBuilder_SQLUpdated(sender As Object, e As EventArgs)
		' Handle the event raised by Criteria Builder object that the text of SQL query is changed
		' update the text box
		If tabControl1.SelectedTab IsNot pageQueryResult Then
			Return
		End If
		Try
			Dim sql As String = CBuilder.SQL
			teResultSql.Text = sql
			FillDataGrid(sql)
		Catch exception As Exception
			MessageBox.Show(exception.Message)
		End Try
	End Sub

	Private Sub DataGridView1_DataSourceChanged(sender As Object, e As EventArgs) Handles dataGridView1.DataSourceChanged 
		teResultSql.Text = CBuilder.SQL
	End Sub

	Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dataGridView1.CellPainting 
		If e.RowIndex <> -1 OrElse e.ColumnIndex = -1 Then
			Return
		End If
		Dim sorting As SortedColumn = CBuilder.QueryTransformer.Sortings.FirstOrDefault(Function(sort) sort.Column.OriginalName = dataGridView1.Columns(e.ColumnIndex).HeaderText)
		If sorting Is Nothing Then
			Return
		End If
		e.Paint(e.ClipBounds, e.PaintParts)
		Dim sortIndex As Integer = CBuilder.QueryTransformer.Sortings.IndexOf(sorting) + 1
		Dim format As New StringFormat() With { _
			.LineAlignment = StringAlignment.Center _
		}
		e.Graphics.DrawString(sortIndex.ToString(), dataGridView1.Font, SystemBrushes.ControlText, New Rectangle(e.CellBounds.X + e.CellBounds.Width - 25, e.CellBounds.Y, 25, e.CellBounds.Height), format)
		e.Handled = True
	End Sub

	Private Sub tsmiNew_Click(sender As Object, e As EventArgs) Handles tsmiNew.Click, tsbNew.Click  
		Dim query As String = queryBuilder1.SQL
		If Connect() Then
			Clear()
			queryBuilder1.SQL = query
		End If
	End Sub

	Private Function Connect() As Boolean
		Using cf As New ConnectionForm()
			If cf.ShowDialog() = DialogResult.OK Then
				Try
					Cursor = Cursors.WaitCursor
					_selectedConnection = cf.SelectedConnection
					InitializeSqlContext()
					Return True
				Finally
					Cursor = Cursors.[Default]
				End Try
			End If
		End Using
		Return False
	End Function

	Private Sub tsmiOpen_Click(sender As Object, e As EventArgs) Handles tsmiOpen.Click, tsbOpen.Click 
		' open a saved query
		If Not TrySave() Then
			Return
		End If
		If (_selectedConnection Is Nothing AndAlso Not Connect()) OrElse openFileDialog1.ShowDialog() <> DialogResult.OK Then
			Return
		End If
		Dim sb As New StringBuilder()
		Using sr As New StreamReader(openFileDialog1.FileName)
			Dim s As String
			While (InlineAssignHelper(s, sr.ReadLine())) IsNot Nothing
				sb.AppendLine(s)
			End While
		End Using
		_fileSourcePath = openFileDialog1.FileName

		' load query to the query builder by assigning its text to the SQL property
		queryBuilder1.SQL = sb.ToString()
		_oldSql = FormattedQueryText
	End Sub

	Private Sub tsmiSave_Click(sender As Object, e As EventArgs) Handles tsmiSave.Click, tsbSave.Click 
		Dim path As String = SaveInFile(_fileSourcePath)
		If path IsNot Nothing Then
			_fileSourcePath = path
		End If
	End Sub

	Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click 
		Close()
	End Sub

	Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs)
		If WindowState <> FormWindowState.Maximized Then
			Program.Settings.WindowPlacement = Bounds
		End If
	End Sub

	Private Sub _sqlContext_SyntaxProviderChanged(sender As Object, e As EventArgs)
		RefreshPaginationPanel()
	End Sub

	Private Sub MainForm_SizeChanged(sender As Object, e As EventArgs)
		If Program.Settings.IsMaximized <> (WindowState = FormWindowState.Maximized) Then
			Program.Settings.IsMaximized = (WindowState = FormWindowState.Maximized)
		End If

		If Not Program.Settings.IsMaximized Then
			Program.Settings.WindowPlacement = Bounds
		End If
	End Sub

	Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing 
		If Not TrySave() Then
			e.Cancel = True
		End If
	End Sub

	Private Sub tsmiBuildQuery_Click(sender As Object, e As EventArgs) Handles tsmiBuildQuery.Click 
		tabControl1.SelectTab(0)
		teSql.Focus()
	End Sub

	Private Sub tsmiRunQuery_Click(sender As Object, e As EventArgs) Handles tsmiRunQuery.Click 
		tabControl1.SelectTab(1)
	End Sub

	Private Sub tsmiQueryStatistics_Click(sender As Object, e As EventArgs) Handles tsmiQueryStatistics.Click 
		Dim qs As QueryStatistics = queryBuilder1.QueryStatistics

		Dim stats As String = "Used Objects (" & qs.UsedDatabaseObjects.Count & "):" & vbCr & vbLf
		stats = qs.UsedDatabaseObjects.Aggregate(stats, Function(current, t) current & (vbCr & vbLf & t.ObjectName.QualifiedName))

		stats += vbCr & vbLf & vbCr & vbLf & "Used Columns (" & qs.UsedDatabaseObjectFields.Count & "):" & vbCr & vbLf
		stats = qs.UsedDatabaseObjectFields.Aggregate(stats, Function(current, t) current & (vbCr & vbLf & t.ObjectName.QualifiedName))

		stats += vbCr & vbLf & vbCr & vbLf & "Output Expressions (" & qs.OutputColumns.Count & "):" & vbCr & vbLf
		stats = qs.OutputColumns.Aggregate(stats, Function(current, t) current & (vbCr & vbLf & t.Expression))

		Using f As New QueryStatisticsForm()
			f.textBox.Text = stats
			f.ShowDialog()
		End Using
	End Sub

	Private Sub tsmiAbout_Click(sender As Object, e As EventArgs) Handles tsmiAbout.Click, tsbAbout.Click 
		Using f As New AboutForm()
			f.ShowDialog()
		End Using
	End Sub

	Public Sub Undo()
		teSql.Undo()
	End Sub

	Public Sub Redo()
		teSql.Undo()
	End Sub

	Public Sub Cut()
		teSql.Cut()
	End Sub

	Public Sub Copy()
		teSql.Copy()
	End Sub

	Public Sub Paste()
		teSql.Paste()
	End Sub

	Public Sub SelectAll()
		teSql.SelectAll()
	End Sub

	Public ReadOnly Property CanCopy() As Boolean
		Get
			If teSql.ContainsFocus Then
				If teSql.SelectionLength > 0 Then
					Return True
				End If
			End If
			Return False
		End Get
	End Property

	Public ReadOnly Property CanCut() As Boolean
		Get
			If teSql.ContainsFocus Then
				If Not String.IsNullOrEmpty(teSql.SelectedText) Then
					Return True
				End If
			End If
			Return False
		End Get
	End Property

	Public ReadOnly Property CanPaste() As Boolean
		Get
			If teSql.ContainsFocus Then
				Return Clipboard.ContainsText()
			End If
			Return False
		End Get
	End Property

	Public ReadOnly Property CanUndo() As Boolean
		Get
			If teSql.ContainsFocus Then
				Return teSql.CanUndo
			End If
			Return False
		End Get
	End Property

	Public ReadOnly Property CanRedo() As Boolean
		Get
			If teSql.ContainsFocus Then
				Return teSql.CanRedo
			End If
			Return False
		End Get
	End Property

	Public ReadOnly Property CanSelectAll() As Boolean
		Get
			Return teSql.ContainsFocus AndAlso teSql.TextLength > 0
		End Get
	End Property

	Private Sub tsmiUndo_Click(sender As Object, e As EventArgs) Handles tsmiUndo.Click 
		Undo()
	End Sub

	Private Sub tsmiRedo_Click(sender As Object, e As EventArgs) Handles tsmiRedo.Click 
		Redo()
	End Sub

	Private Sub tsmiCut_Click(sender As Object, e As EventArgs) Handles tsmiCut.Click, tsbCut.Click 
		Cut()
	End Sub

	Private Sub tsmiCopy_Click(sender As Object, e As EventArgs) Handles tsmiCopy.Click, tsbCopy.Click 
		Copy()
	End Sub

	Private Sub tsmiPaste_Click(sender As Object, e As EventArgs) Handles tsmiPaste.Click, tsbPaste.Click 
		Paste()
	End Sub

	Private Sub tsmiSelectAll_Click(sender As Object, e As EventArgs) Handles tsmiSelectAll.Click 
		SelectAll()
	End Sub

	Private Sub tsmiOfflineMode_Click(sender As Object, e As EventArgs) Handles tsmiOfflineMode.Click 
		If tsmiOfflineMode.Checked Then
			Try
				Cursor = Cursors.WaitCursor

				queryBuilder1.MetadataContainer.LoadAll(True)
			Finally
				Cursor = Cursors.Arrow
			End Try
		End If

		queryBuilder1.MetadataContainer.LoadingOptions.OfflineMode = tsmiOfflineMode.Checked
	End Sub

	Private Sub tsmiRefreshMetadata_Click(sender As Object, e As EventArgs) Handles tsmiRefreshMetadata.Click 
		If queryBuilder1.MetadataProvider IsNot Nothing AndAlso queryBuilder1.MetadataProvider.Connected Then
			' Force the query builder to refresh metadata from current connection
			' to refresh metadata, just clear MetadataContainer and reinitialize metadata tree
			queryBuilder1.MetadataContainer.Clear()
			queryBuilder1.InitializeDatabaseSchemaTree()
		End If
	End Sub

	Private Sub tsmiEditMetadata_Click(sender As Object, e As EventArgs) Handles tsmiEditMetadata.Click 
		QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext, queryBuilder1.SQLContext.LoadingOptions)
	End Sub

	Private Sub tsmiClearMetadata_Click(sender As Object, e As EventArgs) Handles tsmiClearMetadata.Click 
		queryBuilder1.MetadataContainer.Clear()
	End Sub

	Private Sub tsmiLoadMetadataFromXML_Click(sender As Object, e As EventArgs) Handles tsmiLoadMetadataFromXML.Click 
		LoadMetadataFromXml()
	End Sub

	Private Sub tsmiSaveMetadataToXML_Click(sender As Object, e As EventArgs) Handles tsmiSaveMetadataToXML.Click 
		SaveMetadataToXml()
	End Sub

	Private Sub tsmiLanguageAuto_Click(sender As Object, e As EventArgs) Handles tsmiLanguageAuto.Click 
		Program.Settings.Language = "Auto"
		UpdateLanguage()
	End Sub

	Private Sub tsmiLanguageDefault_Click(sender As Object, e As EventArgs) Handles tsmiLanguageDefault.Click 
		Program.Settings.Language = "Default"
		UpdateLanguage()
	End Sub

	Private Sub newQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles toolStripButtonNewQuery.Click, newQueryToolStripMenuItem1.Click 
		Clear()
	End Sub

	Private Sub Clear()
		If Not TrySave() Then
			Return
		End If
		queryBuilder1.SQL = ""
		_oldSql = Nothing
		_fileSourcePath = Nothing
	End Sub

	Private Function TrySave() As Boolean
		If _oldSql IsNot Nothing AndAlso _oldSql <> FormattedQueryText Then
			Dim dialog As New SaveDialogForm(If(_fileSourcePath, "new file"))
			If dialog.ShowDialog() <> DialogResult.OK Then
				Return False
			End If
			If dialog.Save Then
				SaveInFile(_fileSourcePath)
			End If
		End If
		Return True
	End Function

	Private Sub RefreshPaginationPanel()
		paginationPanel1.Visible = CBuilder.QueryTransformer.IsSupportLimitCount OrElse CBuilder.QueryTransformer.IsSupportLimitOffset
		paginationPanel1.IsSupportLimitCount = CBuilder.QueryTransformer.IsSupportLimitCount
		paginationPanel1.IsSupportLimitOffset = CBuilder.QueryTransformer.IsSupportLimitOffset
	End Sub

	Private Function SaveInFile(path As String) As String
		' Save the query text to file
		If path IsNot Nothing AndAlso FormattedQueryText = _oldSql Then
			Return path
		End If
		If String.IsNullOrEmpty(path) Then
			Dim saveFileDialog As New SaveFileDialog() With { _
				.DefaultExt = "sql", _
				.FileName = "query", _
				.Filter = "SQL query files (*.sql)|*.sql|All files|*.*" _
			}
			If saveFileDialog.ShowDialog() <> DialogResult.OK Then
				Return path
			End If
			path = saveFileDialog.FileName
		End If
		Using sw As New StreamWriter(path)
			sw.Write(FormattedQueryText)
			_oldSql = FormattedQueryText
		End Using
		Return path
	End Function

	Private Sub addDerivedTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addDerivedTableToolStripMenuItem.Click 
		tsbAddDerivedTable_Click(Nothing, EventArgs.Empty)
	End Sub

	Private Sub tsbAddDerivedTable_Click(sender As Object, e As EventArgs) Handles tsbAddDerivedTable.Click
		Using New UpdateRegion(queryBuilder1.ActiveUnionSubQuery.FromClause)
			Dim sqlContext = queryBuilder1.ActiveUnionSubQuery.SQLContext

			Dim fq = New SQLFromQuery(sqlContext) With { _
				.[Alias] = New SQLAliasObjectAlias(sqlContext) With { _
					.[Alias] = queryBuilder1.ActiveUnionSubQuery.QueryRoot.CreateUniqueSubQueryName() _
				}, _
				.SubQuery = New SQLSubSelectStatement(sqlContext) _
			}

			Dim sqse = New SQLSubQuerySelectExpression(sqlContext)
			fq.SubQuery.Add(sqse)
			sqse.SelectItems = New SQLSelectItems(sqlContext)
			sqse.From = New SQLFromClause(sqlContext)
			queryBuilder1.SQLQuery.AddObject(queryBuilder1.ActiveUnionSubQuery, fq, GetType(DataSourceQuery))
		End Using
	End Sub

	Private Sub tsbAddObject_Click(sender As Object, e As EventArgs) Handles addObjectToolStripMenuItem.Click, tsbAddObject.Click 
		If queryBuilder1.AddObjectDialog IsNot Nothing Then
			queryBuilder1.AddObjectDialog.ShowModal()
		End If
	End Sub

	Private Sub tsbQueryProperties_Click(sender As Object, e As EventArgs) Handles queryPropertiesToolStripMenuItem.Click, tsbQueryProperties.Click 
		queryBuilder1.ShowActiveUnionSubQueryProperties()
	End Sub

	Private Sub tsbCopyUnionSubquery_Click(sender As Object, e As EventArgs) Handles copyUnionSubwueryToolStripMenuItem.Click, tsbCopyUnionSubquery.Click 
		' add empty UnionSubQuery
		Dim usq As UnionSubQuery = queryBuilder1.ActiveUnionSubQuery.ParentGroup.Add()

		' copy the content of existing union sub-query to a new one
		Dim usqAst As SQLSubQuerySelectExpression = queryBuilder1.ActiveUnionSubQuery.ResultQueryAST
		usqAst.RestoreColumnPrefixRecursive(True)

		Dim lCte As New List(Of SQLWithClauseItem)()
		Dim lFromObj As New List(Of SQLFromSource)()
		queryBuilder1.ActiveUnionSubQuery.GatherPrepareAndFixupContext(lCte, lFromObj, False)
		usqAst.PrepareAndFixupRecursive(lCte, lFromObj)

		usq.LoadFromAST(usqAst)
		queryBuilder1.ActiveUnionSubQuery = usq
	End Sub

	Private Sub addUnionSubqueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addUnionSubqueryToolStripMenuItem.Click 
		queryBuilder1.ActiveUnionSubQuery = queryBuilder1.ActiveUnionSubQuery.ParentGroup.Add()
	End Sub

	Private Sub propertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles propertiesToolStripMenuItem.Click
        Using f As New QueryBuilderPropertiesForm(queryBuilder1)
			f.ShowDialog()
		End Using
    End Sub

	Private Sub tsbEditMetadata_Click(sender As Object, e As EventArgs) Handles tsbEditMetadata.Click 
		QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext, queryBuilder1.SQLContext.LoadingOptions)
	End Sub

	Private Sub tsbSaveInFile_Click(sender As Object, e As EventArgs) Handles tsmiSaveAs.Click, tsbSaveInFile.Click 
		Dim path As String = SaveInFile(Nothing)
		If path IsNot Nothing Then
			_fileSourcePath = path
		End If
	End Sub

	Private Sub dataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataGridView1.ColumnHeaderMouseClick
		Dim nameColumn As String = dataGridView1.Columns(e.ColumnIndex).HeaderText
		If Not _sortedColumns.ContainsKey(nameColumn) Then
			_sortedColumns.Add(nameColumn, SortOrder.None)
		End If
		Dim columnForSorting As OutputColumn = CBuilder.QueryTransformer.Columns.FindColumnByResultName(nameColumn)
		If columnForSorting Is Nothing Then
			Return
		End If
		Dim newSortColumn As SortedColumn = Nothing
		Dim sortColumn As SortedColumn = CBuilder.QueryTransformer.Sortings.FirstOrDefault(Function(sorting) sorting.Column.ResultName = nameColumn)
		If sortColumn IsNot Nothing Then
			CBuilder.QueryTransformer.Sortings.Remove(sortColumn)
		End If
		Dim columnSource As DataGridViewColumn = dataGridView1.Columns(e.ColumnIndex)
		Select Case columnSource.HeaderCell.SortGlyphDirection
			Case SortOrder.Ascending
				_sortedColumns(nameColumn) = InlineAssignHelper(columnSource.HeaderCell.SortGlyphDirection, SortOrder.Descending)
				newSortColumn = columnForSorting.Descending()
				Exit Select
			Case SortOrder.Descending
				_sortedColumns(nameColumn) = InlineAssignHelper(columnSource.HeaderCell.SortGlyphDirection, SortOrder.None)
				Exit Select
			Case SortOrder.None
				_sortedColumns(nameColumn) = InlineAssignHelper(columnSource.HeaderCell.SortGlyphDirection, SortOrder.Ascending)
				newSortColumn = columnForSorting.Ascending()
				Exit Select
			Case Else
				Throw New ArgumentOutOfRangeException()
		End Select
		If newSortColumn IsNot Nothing Then
			CBuilder.QueryTransformer.Sortings.Add(newSortColumn)
		End If

		FillDataGrid(CBuilder.SQL)
	End Sub

	Private Function CreateSqlCommand(sqlCommand As String) As DbCommand
		Dim command As DbCommand = DirectCast(queryBuilder1.MetadataProvider.Connection.CreateCommand(), DbCommand)
		command.CommandText = sqlCommand
		' handle the query parameters
		If queryBuilder1.SQLQuery.QueryParameters.Count > 0 Then
			For Each p As Parameter In queryBuilder1.SQLQuery.QueryParameters.Where(Function(item) Not command.Parameters.Contains(item.FullName))
				Dim parameter As New SqlParameter() With { _
					.ParameterName = p.FullName, _
					.DbType = p.DataType _
				}
				command.Parameters.Add(parameter)
			Next
			Using qpf As New QueryParametersForm(command)
				qpf.ShowDialog()
			End Using
		End If
		Return command
	End Function

	Private Sub FillDataGrid(sqlCommand As String)
		dataGridView1.DataSource = Nothing
		If String.IsNullOrEmpty(sqlCommand) Then
			Return
		End If
		If queryBuilder1.MetadataProvider IsNot Nothing AndAlso queryBuilder1.MetadataProvider.Connected Then
			If TypeOf queryBuilder1.MetadataProvider Is MSSQLMetadataProvider Then
				Dim command As SqlCommand = DirectCast(CreateSqlCommand(sqlCommand), SqlCommand)
				Dim adapter As New SqlDataAdapter(command)
				Dim dataset As New DataSet()
				Try
					adapter.Fill(dataset, "QueryResult")
					dataGridView1.DataSource = dataset.Tables("QueryResult")
				Catch ex As Exception
					MessageBox.Show("SQL execution error: " & ex.Message, "SQL query error")
				End Try
			ElseIf TypeOf queryBuilder1.MetadataProvider Is OracleNativeMetadataProvider Then
				Dim command As OracleCommand = DirectCast(CreateSqlCommand(sqlCommand), OracleCommand)
				Dim adapter As New OracleDataAdapter(command)
				Dim dataset As New DataSet()
				Try
					adapter.Fill(dataset, "QueryResult")
					dataGridView1.DataSource = dataset.Tables("QueryResult")
				Catch ex As Exception
					MessageBox.Show("SQL execution error: " & ex.Message, "SQL query error")
				End Try
			ElseIf TypeOf queryBuilder1.MetadataProvider Is OLEDBMetadataProvider Then
				Dim command As OleDbCommand = DirectCast(CreateSqlCommand(sqlCommand), OleDbCommand)
				Dim adapter As New OleDbDataAdapter(command)
				Dim dataset As New DataSet()
				Try
					adapter.Fill(dataset, "QueryResult")
					dataGridView1.DataSource = dataset.Tables("QueryResult")
				Catch ex As Exception
					MessageBox.Show("SQL execution error: " & ex.Message, "SQL query error")
				End Try
			ElseIf TypeOf queryBuilder1.MetadataProvider Is ODBCMetadataProvider Then
				Dim command As OdbcCommand = DirectCast(CreateSqlCommand(sqlCommand), OdbcCommand)
				Dim adapter As New OdbcDataAdapter(command)
				Dim dataset As New DataSet()
				Try
					adapter.Fill(dataset, "QueryResult")
					dataGridView1.DataSource = dataset.Tables("QueryResult")
				Catch ex As Exception
					MessageBox.Show("SQL execution error: " & ex.Message, "SQL query error")
				End Try
			ElseIf TypeOf queryBuilder1.MetadataProvider Is MySQLMetadataProvider Then
				Dim command As MySqlCommand = DirectCast(CreateSqlCommand(sqlCommand), MySqlCommand)
				Dim adapter As New MySqlDataAdapter(command)
				Dim dataset As New DataSet()
				Try
					adapter.Fill(dataset, "QueryResult")
					dataGridView1.DataSource = dataset.Tables("QueryResult")
				Catch ex As Exception
					MessageBox.Show("SQL execution error: " & ex.Message, "SQL query error")
				End Try
			ElseIf TypeOf queryBuilder1.MetadataProvider Is PostgreSQLMetadataProvider Then
				Dim command As NpgsqlCommand = DirectCast(CreateSqlCommand(sqlCommand), NpgsqlCommand)
				Dim adapter As New NpgsqlDataAdapter(command)
				Dim dataset As New DataSet()
				Try
					adapter.Fill(dataset, "QueryResult")
					dataGridView1.DataSource = dataset.Tables("QueryResult")
				Catch ex As Exception
					MessageBox.Show("SQL execution error: " & ex.Message, "SQL query error")
				End Try
			End If
		End If
		For Each column As DataGridViewColumn In dataGridView1.Columns
			column.SortMode = DataGridViewColumnSortMode.Programmatic
			If _sortedColumns.ContainsKey(column.HeaderText) Then
				column.HeaderCell.SortGlyphDirection = _sortedColumns(column.HeaderText)
			End If
		Next
	End Sub

	Private Sub paginationPanel1_EnabledPaginationChanged(sender As Object, e As EventArgs) Handles paginationPanel1.EnabledPaginationChanged
		' Turn paging on and off
		If paginationPanel1.PaginationEnabled Then
			CBuilder.QueryTransformer.Take(paginationPanel1.PageSize.ToString())
		Else
			paginationPanel1.Clear()
			CBuilder.QueryTransformer.Take("")
			CBuilder.QueryTransformer.Skip("")
		End If
	End Sub

	Private Sub paginationPanel1_CurrentPageChanged(sender As Object, e As EventArgs) Handles paginationPanel1.CurrentPageChanged
		' Select next n records
		If paginationPanel1.CurrentPage = 1 Then
			CBuilder.QueryTransformer.Skip("")
			Return
		End If
		CBuilder.QueryTransformer.Skip((paginationPanel1.PageSize * (paginationPanel1.CurrentPage - 1)).ToString())
	End Sub

	Private Sub paginationPanel1_PageSizeChanged(sender As Object, e As EventArgs) Handles paginationPanel1.PageSizeChanged
		CBuilder.QueryTransformer.Take(paginationPanel1.PageSize.ToString())
		If paginationPanel1.CurrentPage > 1 Then
			CBuilder.QueryTransformer.Skip((paginationPanel1.PageSize * (paginationPanel1.CurrentPage - 1)).ToString())
		End If
	End Sub

	Private Sub tsbAddUnionSubquery_Click(sender As Object, e As EventArgs) Handles tsbAddUnionSubquery.Click
		queryBuilder1.ActiveUnionSubQuery = queryBuilder1.ActiveUnionSubQuery.ParentGroup.Add()
	End Sub

	Private Sub queryBuilder1_SQLUpdated(sender As Object, e As EventArgs) Handles queryBuilder1.SQLUpdated
		HideErrorBanner()
		teSql.Text = If(queryBuilder1.SleepMode, queryBuilder1.SQL, FormattedQueryText)
	End Sub

	Private Sub _sqlFormattingOptions_Updated(sender As Object, e As EventArgs)
		teSql.Text = FormattedQueryText
	End Sub

	Private Sub contextMenuStripForRichTextBox_Opening(sender As Object, e As CancelEventArgs)
		tsmiUndo.Enabled = CanUndo
		tsmiRedo.Enabled = CanRedo
		tsmiCut.Enabled = CanCut
		tsmiCopy.Enabled = CanCopy
		tsmiPaste.Enabled = CanPaste
		tsmiSelectAll.Enabled = CanSelectAll
	End Sub

	Private Sub teQbSql_Validating(sender As Object, e As CancelEventArgs) Handles teSql.Validating
		Try
			' Update the query builder with manually edited query text:
			queryBuilder1.SQL = teSql.Text
			HideErrorBanner()
		Catch ex As SQLParsingException
			' Set caret to error position
			teSql.SelectionStart = ex.ErrorPos.pos

			' Show banner with error text
			ShowErrorBanner(ex.Message)
		End Try
	End Sub

	Private Sub tsmiParseQuery_Click(sender As Object, e As EventArgs) Handles tsmiParseQuery.Click 
		Try
			queryBuilder1.SQL = teSql.Text
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub RefreshNoConnectionLabel()
		If _selectedConnection IsNot Nothing Then
			If _noConnectionLabel IsNot Nothing Then
				RemoveHandler dataGridView1.SizeChanged, AddressOf DataGridView1_SizeChanged
				_noConnectionLabel.Parent = Nothing
				_noConnectionLabel = Nothing
			End If
		ElseIf _noConnectionLabel Is Nothing Then
			_noConnectionLabel = New NoConnectionLabel()
			AddHandler dataGridView1.SizeChanged, AddressOf DataGridView1_SizeChanged
			dataGridView1.Controls.Add(_noConnectionLabel)
		End If
	End Sub

	Private Sub tabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tabControl1.Selecting
		' Execute a query on switching to the Data tab
		If e.TabPage IsNot pageQueryResult Then
			Return
		End If
		If _hasError Then
			e.Cancel = True
			Return
		End If
		RefreshPaginationPanel()
		paginationPanel1.Clear()
		CBuilder.QueryTransformer.Skip("")
		CBuilder.QueryTransformer.Take("")
		Dim sql = CBuilder.QueryTransformer.SQL
		teResultSql.Text = sql
		FillDataGrid(sql)
		paginationPanel1.RowsCount = dataGridView1.RowCount
		RefreshNoConnectionLabel()
	End Sub

	Private Sub DataGridView1_SizeChanged(sender As Object, e As EventArgs)
		Dim parent As Control = DirectCast(sender, Control)
		Dim x As Integer = parent.Width \ 2 - _noConnectionLabel.Width \ 2
		Dim y As Integer = parent.Height \ 2 - _noConnectionLabel.Height \ 2
		_noConnectionLabel.Location = New Point(If(x > 0, x, 0), If(y > 0, y, 0))
	End Sub
	Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
		target = value
		Return value
	End Function
End Class
