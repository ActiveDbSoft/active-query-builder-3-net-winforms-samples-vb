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
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.EventHandlers.MetadataStructureItems
Imports ActiveQueryBuilder.View.WinForms
Imports FullFeaturedMdiDemo.Common
Imports FullFeaturedMdiDemo.Dailogs
Imports FullFeaturedMdiDemo.PropertiesForm
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports BuildInfo = ActiveQueryBuilder.Core.BuildInfo
Imports Helpers = ActiveQueryBuilder.Core.Helpers

Public Partial Class MainForm
	Inherits Form
	Private _selectedConnection As ConnectionInfo
	Private _sqlContext As SQLContext
	Private ReadOnly _sqlFormattingOptions As SQLFormattingOptions
	Private ReadOnly _sqlGenerationOptions As SQLGenerationOptions

	Private _options As Options

	Public Sub New()
		InitializeComponent()

		' Options to present the formatted SQL query text to end-user
		' Use names of virtual objects, do not replace them with appropriate derived tables
		_sqlFormattingOptions = New SQLFormattingOptions() With { _
			.ExpandVirtualObjects = False _
		}

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

		LoadLanguages()

		AddHandler SizeChanged, AddressOf MainForm_SizeChanged
		AddHandler LocationChanged, AddressOf MainForm_LocationChanged
		AddHandler MdiChildActivate, AddressOf MainForm_MdiChildActivate
		AddHandler Application.Idle, AddressOf Application_Idle
		AddHandler DBView.ItemDoubleClick, AddressOf DBView_ItemDoubleClick

		TryToLoadOptions()

		' DEMO WARNING

		If BuildInfo.GetEdition() = BuildInfo.Edition.Trial Then
			Dim trialNoticePanel As New Panel() With { _
				.AutoSize = True, _
				.AutoSizeMode = AutoSizeMode.GrowAndShrink, _
				.BackColor = Color.LightGreen, _
				.BorderStyle = BorderStyle.FixedSingle, _
				.Dock = DockStyle.Top, _
				.Padding = New Padding(6, 5, 3, 0) _
			}

			Dim label As New Label() With { _
				.AutoSize = True, _
				.Margin = New Padding(0), _
				.Text = "Generation of random aliases for the query output columns is the limitation of the trial version. The full version is free from this behavior.", _
				.Dock = DockStyle.Fill, _
				.UseCompatibleTextRendering = True _
			}

			Dim buttonClose As PictureBox = New PictureBox() With { _
				.Image = Resources.cancel, _
				.SizeMode = PictureBoxSizeMode.AutoSize, _
				.Cursor = Cursors.Hand _
			}
			AddHandler buttonClose.Click, Sub() Controls.Remove(trialNoticePanel)

			trialNoticePanel.Controls.Add(buttonClose)

			AddHandler trialNoticePanel.Resize, Sub() buttonClose.Location = New Point(trialNoticePanel.Width - buttonClose.Width - 10, trialNoticePanel.Height \ 2 - buttonClose.Height \ 2)

			trialNoticePanel.Controls.Add(label)
			Controls.Add(trialNoticePanel)

			Controls.SetChildIndex(trialNoticePanel, 2)

		End If
	End Sub

	Private Sub TryToLoadOptions()
		If String.IsNullOrEmpty(Program.Settings.Options) Then
			Return
		End If

		_options = New Options()
		_options.CreateDefaultOptions()
		Try
			_options.DeserializeFromString(Program.Settings.Options)
		Catch
			_options = Nothing
			Program.Settings.Options = String.Empty
		End Try
	End Sub

	Private Sub MainForm_MdiChildActivate(sender As Object, e As EventArgs)
		Dim childForm As ChildForm = TryCast(ActiveMdiChild, ChildForm)
		If childForm Is Nothing Then
			userQueriesView1.QueryView = Nothing
		Else
			userQueriesView1.QueryView = childForm.QueryView
			userQueriesView1.SQLQuery = childForm.SqlQuery
		End If
	End Sub

	Private Sub DBView_ItemDoubleClick(sender As Object, clickedItem As MetadataStructureItem)
		If clickedItem.MetadataItem Is Nothing Then
			Return
		End If

		' Adding a table to the currently active query.
		If (MetadataType.Objects And clickedItem.MetadataItem.Type) = 0 AndAlso (MetadataType.ObjectMetadata And clickedItem.MetadataItem.Type) = 0 Then
			Return
		End If
		If ActiveMdiChild Is Nothing Then
			Dim childWindow As ChildForm = CreateChildForm()
			If childWindow Is Nothing Then
				Return
			End If
			childWindow.Show()
			childWindow.Activate()
		End If
		Dim window As ChildForm = DirectCast(ActiveMdiChild, ChildForm)
		If window Is Nothing Then
			Return
		End If
		Dim metadataItem As MetadataItem = clickedItem.MetadataItem
		If metadataItem Is Nothing Then
			Return
		End If
		If (metadataItem.Type And MetadataType.Objects) <= 0 AndAlso metadataItem.Type <> MetadataType.Field Then
			Return
		End If
		Using qualifiedName = metadataItem.GetSQLQualifiedName(Nothing, True)
			window.QueryView.AddObjectToActiveUnionSubQuery(qualifiedName.GetSQL())
		End Using
	End Sub

	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing Then
			RemoveHandler Application.Idle, AddressOf Application_Idle
			RemoveHandler DBView.ItemDoubleClick, AddressOf DBView_ItemDoubleClick

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
		Helpers.Localizer.Language = DirectCast(currentItem.Tag, String)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).UpdateLanguage()
		End If
		currentItem.Checked = True
	End Sub

	Private Sub Application_Idle(sender As Object, e As EventArgs)
		tsmiSave.Enabled = (ActiveMdiChild IsNot Nothing)
		tsmiParseQuery.Enabled = (ActiveMdiChild IsNot Nothing)
		tsmiBuildQuery.Enabled = (ActiveMdiChild IsNot Nothing)
		tsmiRunQuery.Enabled = (ActiveMdiChild IsNot Nothing)
		tsmiQueryStatistics.Enabled = (ActiveMdiChild IsNot Nothing)
		toolStripButtonNewQuery.Enabled = InlineAssignHelper(newQueryToolStripMenuItem1.Enabled, (_sqlContext IsNot Nothing))
		tsmiUndo.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanUndo())
		tsmiRedo.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanRedo())
		tsmiCut.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanCut())
		tsmiCopy.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanCopy())
		tsmiPaste.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanPaste())
		tsmiSelectAll.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanSelectAll())
		tsbSave.Enabled = (ActiveMdiChild IsNot Nothing)
		tsbCascade.Enabled = (MdiChildren.Length > 0)
		tsbTileHorizontally.Enabled = (MdiChildren.Length > 0)
		tsbTileVertically.Enabled = (MdiChildren.Length > 0)
		tsbCut.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanCut())
		tsbCopy.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanCopy())
		tsbPaste.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanPaste())
		tsmiOfflineMode.Enabled = (_sqlContext IsNot Nothing)
		tsmiOfflineMode.Checked = (_sqlContext IsNot Nothing AndAlso _sqlContext.MetadataContainer.LoadingOptions.OfflineMode)
		tsmiRefreshMetadata.Enabled = (_sqlContext IsNot Nothing)
		tsmiEditMetadata.Enabled = (_sqlContext IsNot Nothing)
		tsmiClearMetadata.Enabled = (_sqlContext IsNot Nothing)
		tsmiLoadMetadataFromXML.Enabled = (_sqlContext IsNot Nothing)
		tsmiSaveMetadataToXML.Enabled = (_sqlContext IsNot Nothing)
		propertiesToolStripMenuItem.Enabled = (ActiveMdiChild IsNot Nothing)
		propertiesToolStripMenuItem.Text = If(propertiesToolStripMenuItem.Enabled, "Properties", "Properties (open a query to edit)")

		queryPropertiesToolStripMenuItem.Enabled = (ActiveMdiChild IsNot Nothing)

		addDerivedTableToolStripMenuItem.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanAddDerivedTable())
		addObjectToolStripMenuItem.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanAddObject())
		addUnionSubqueryToolStripMenuItem.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanAddUnionSubQuery())
		copyUnionSubwueryToolStripMenuItem.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanCopyUnionSubQuery())

		tsbEditMetadata.Enabled = _sqlContext IsNot Nothing AndAlso _sqlContext.MetadataContainer IsNot Nothing
	End Sub

	Private Sub tsbNew_Click(sender As Object, e As EventArgs)
		tsmiNew_Click(sender, e)
	End Sub

	Private Function InitializeSqlContext() As Boolean
		Try
			Cursor = Cursors.WaitCursor

			If _selectedConnection.IsXmlFile Then
				_sqlContext = New SQLContext() With { _
					.SyntaxProvider = _selectedConnection.ConnectionDescriptor.SyntaxProvider
				    }
                _sqlContext.LoadingOptions.OfflineMode = true
				Try
					_sqlContext.MetadataContainer.ImportFromXML(_selectedConnection.XMLPath)
				Catch e As Exception
					MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
					Return False
				End Try
			Else
				Try
					_sqlContext = _selectedConnection.ConnectionDescriptor.GetSqlContext()
				Catch e As Exception
					MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
					Return False
				End Try
			End If

			_sqlContext.LoadingOptions.Assign(_selectedConnection.ConnectionDescriptor.MetadataLoadingOptions)
			_sqlContext.MetadataStructure.Options.Assign(_selectedConnection.StructureOptions)

			DBView.SQLContext = _sqlContext
			DBView.InitializeDatabaseSchemaTree()

			If Not String.IsNullOrEmpty(_selectedConnection.MetadataStructure) Then
				_sqlContext.MetadataStructure.XML = _selectedConnection.MetadataStructure
				_sqlContext.MetadataStructure.Refresh()
			End If

			Dim favouritesItem As MetadataStructureItem= _sqlContext.MetadataStructure.FavouritesItem
			If favouritesItem IsNot Nothing Then
				AddHandler favouritesItem.UpdateEnded, AddressOf Favourites_Updated
			End If

			CaptionConnection.Text = _selectedConnection.Name

			userQueriesView1.SQLContext = _sqlContext
			userQueriesView1.SQLQuery = New SQLQuery(_sqlContext)

			If Not String.IsNullOrEmpty(_selectedConnection.UserQueries) Then
				Dim bytes As Byte() = Encoding.UTF8.GetBytes(_selectedConnection.UserQueries)

				Using reader = New MemoryStream(bytes)
					userQueriesView1.ImportFromXML(reader)
				End Using
			Else
				userQueriesView1.Initialize()
			End If
		Finally
			Cursor = Cursors.[Default]
		End Try

		Return True
	End Function

	Private Sub Favourites_Updated(sender As Object, eventArgs As EventArgs)
		SaveFavourites()
	End Sub

	Private Sub SaveFavourites()
		If _sqlContext IsNot Nothing AndAlso _selectedConnection IsNot Nothing Then
			_selectedConnection.MetadataStructure = _sqlContext.MetadataStructure.XML
		End If
	End Sub

	Private Sub tsmiNew_Click(sender As Object, e As EventArgs)
		Connect()
	End Sub

	Private Sub Connect()
		Using cf As New ConnectionForm()
			If cf.ShowDialog() = DialogResult.OK Then
				Try
					Cursor = Cursors.WaitCursor
					For Each mdiChild As Form In MdiChildren
						mdiChild.Close()
					Next
					If MdiChildren.Length > 0 Then
						Return
					End If

					_selectedConnection = cf.SelectedConnection
					Dim contextInitilized = InitializeSqlContext()
					If Not contextInitilized Then
						Return
					End If

					If Not String.IsNullOrEmpty(_selectedConnection.UserQueries) Then
						Dim bytes As Byte() = Encoding.UTF8.GetBytes(_selectedConnection.UserQueries)
						Using reader = New MemoryStream(bytes)
							userQueriesView1.ImportFromXML(reader)
						End Using
					End If
				Finally
					Cursor = Cursors.[Default]
				End Try
			End If
		End Using
	End Sub

	Private Sub tsmiOpen_Click(sender As Object, e As EventArgs)
		If openFileDialog1.ShowDialog() = DialogResult.OK Then
			Dim sb As New StringBuilder()
			Using sr As New StreamReader(openFileDialog1.FileName)
				Dim s As String
				While (InlineAssignHelper(s, sr.ReadLine())) IsNot Nothing
					sb.AppendLine(s)
				End While
			End Using
			If _selectedConnection Is Nothing Then
				Connect()
			End If
			If _selectedConnection Is Nothing Then
				Return
			End If
			Dim f As ChildForm = CreateChildForm(openFileDialog1.FileName)
			f.SqlEditorText = sb.ToString()
			f.FileSourcePath = openFileDialog1.FileName
			f.SqlSourceType = ChildForm.SourceType.File
			f.Show()
		End If
	End Sub

	Private Sub tsmiSave_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).Save(False)
		End If
	End Sub

	Private Sub tsmiExit_Click(sender As Object, e As EventArgs)
		Close()
	End Sub

	Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs)
		If WindowState <> FormWindowState.Maximized Then
			Program.Settings.WindowPlacement = Bounds
		End If
	End Sub

	Private Sub MainForm_SizeChanged(sender As Object, e As EventArgs)
		If Program.Settings.IsMaximized <> (WindowState = FormWindowState.Maximized) Then
			Program.Settings.IsMaximized = (WindowState = FormWindowState.Maximized)
		End If

		If Not Program.Settings.IsMaximized Then
			Program.Settings.WindowPlacement = Bounds
		End If
	End Sub

	Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs)
		SaveFavourites()
	End Sub

	Private Sub tsbCascade_Click(sender As Object, e As EventArgs)
		LayoutMdi(MdiLayout.Cascade)
	End Sub

	Private Sub tsbTileHorizontally_Click(sender As Object, e As EventArgs)
		LayoutMdi(MdiLayout.TileHorizontal)
	End Sub

	Private Sub tsbTileVertically_Click(sender As Object, e As EventArgs)
		LayoutMdi(MdiLayout.TileVertical)
	End Sub

	Private Sub tsmiParseQuery_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).ParseQuery()
		End If
	End Sub

	Private Sub tsmiBuildQuery_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).ActivateBuildQueryTab()
		End If
	End Sub

	Private Sub tsmiRunQuery_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).ActivateRunQueryTab()
		End If
	End Sub

	Private Sub tsmiQueryStatistics_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).ShowQueryStatistics()
		End If
	End Sub

	Private Sub tsmiAbout_Click(sender As Object, e As EventArgs)
		Using f As New AboutForm()
			f.ShowDialog()
		End Using
	End Sub

	Private Sub tsmiUndo_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).Undo()
		End If
	End Sub

	Private Sub tsmiRedo_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).Redo()
		End If
	End Sub

	Private Sub tsmiCut_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).Cut()
		End If
	End Sub

	Private Sub tsmiCopy_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).Copy()
		End If
	End Sub

	Private Sub tsmiPaste_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).Paste()
		End If
	End Sub

	Private Sub tsmiSelectAll_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).SelectAll()
		End If
	End Sub

	Private Sub tsbOpen_Click(sender As Object, e As EventArgs)
		tsmiOpen_Click(sender, e)
	End Sub

	Private Sub tsbSave_Click(sender As Object, e As EventArgs)
		tsmiSave_Click(sender, e)
	End Sub

	Private Sub tsbAbout_Click(sender As Object, e As EventArgs)
		tsmiAbout_Click(sender, e)
	End Sub

	Private Sub tsbCut_Click(sender As Object, e As EventArgs)
		tsmiCut_Click(sender, e)
	End Sub

	Private Sub tsbCopy_Click(sender As Object, e As EventArgs)
		tsmiCopy_Click(sender, e)
	End Sub

	Private Sub tsbPaste_Click(sender As Object, e As EventArgs)
		tsmiPaste_Click(sender, e)
	End Sub

	Private Sub tsmiOfflineMode_Click(sender As Object, e As EventArgs)
		If tsmiOfflineMode.Checked Then
			Try
				Cursor = Cursors.WaitCursor

				_sqlContext.MetadataContainer.LoadAll(True)
			Finally
				Cursor = Cursors.Arrow
			End Try
		End If

		_sqlContext.MetadataContainer.LoadingOptions.OfflineMode = tsmiOfflineMode.Checked
	End Sub

	Private Sub tsmiRefreshMetadata_Click(sender As Object, e As EventArgs)
		If _sqlContext.MetadataProvider Is Nothing OrElse Not _sqlContext.MetadataProvider.Connected Then
			Return
		End If

		' to refresh metadata, just clear already loaded items
		_sqlContext.MetadataContainer.Clear()
		_sqlContext.MetadataContainer.LoadAll(True)
		DBView.InitializeDatabaseSchemaTree()
	End Sub

	Private Sub tsmiEditMetadata_Click(sender As Object, e As EventArgs)
		If _sqlContext Is Nothing Then
			Return
		End If

		QueryBuilder.EditMetadataContainer(_sqlContext)
	End Sub

	Private Sub tsmiClearMetadata_Click(sender As Object, e As EventArgs)
		If _sqlContext Is Nothing Then
			Return
		End If
		_sqlContext.MetadataContainer.Clear()
	End Sub

	Private Sub tsmiLoadMetadataFromXML_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).LoadMetadataFromXml()
		End If
	End Sub

	Private Sub tsmiSaveMetadataToXML_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).SaveMetadataToXml()
		End If
	End Sub

	Private Sub tsmiLanguageAuto_Click(sender As Object, e As EventArgs)
		Program.Settings.Language = "Auto"
		Helpers.Localizer.Language = "Auto"
		Dim checkedItem As ToolStripMenuItem = languageToolStripMenuItem.DropDownItems.OfType(Of ToolStripMenuItem)().FirstOrDefault(Function(item) item.Checked)
		If checkedItem IsNot Nothing Then
			checkedItem.Checked = False
		End If

		tsmiLanguageAuto.Checked = True

		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).UpdateLanguage()
		End If
	End Sub

	Private Sub tsmiLanguageDefault_Click(sender As Object, e As EventArgs)
		Program.Settings.Language = "Default"
		Helpers.Localizer.Language = "Default"

		Dim checkedItem As ToolStripMenuItem = languageToolStripMenuItem.DropDownItems.OfType(Of ToolStripMenuItem)().FirstOrDefault(Function(item) item.Checked)
		If checkedItem IsNot Nothing Then
			checkedItem.Checked = False
		End If

		tsmiLanguageDefault.Checked = True

		If ActiveMdiChild IsNot Nothing Then
			DirectCast(ActiveMdiChild, ChildForm).UpdateLanguage()
		End If
	End Sub

	Private Sub newQueryToolStripMenuItem_Click(sender As Object, e As EventArgs)
		CreateChildForm("New query").Show()
	End Sub

	Private Function CreateChildForm(Optional caption As String = Nothing) As ChildForm
		Dim childForm As New ChildForm(_sqlContext, _selectedConnection) With { _
			.MdiParent = Me, _
			.SqlFormattingOptions = _sqlFormattingOptions, _
			.SqlGenerationOptions = _sqlGenerationOptions, _
			.Text = If(String.IsNullOrEmpty(caption), "New query", caption) _
		}
		AddHandler childForm.FormClosed, AddressOf ChildForm_FormClosed
		AddHandler childForm.SaveQueryEvent, AddressOf ChildForm_SaveQueryEvent
		AddHandler childForm.SaveAsInFileEvent, AddressOf ChildForm_SaveAsInFileEvent
		AddHandler childForm.SaveAsNewUserQueryEvent, AddressOf ChildForm_SaveAsNewUserQueryEvent

		If _options IsNot Nothing Then
			childForm.SetOptions(_options)
		End If

		Return childForm
	End Function

	Private Sub ChildForm_FormClosed(sender As Object, e As FormClosedEventArgs)
		Dim childForm As ChildForm = DirectCast(sender, ChildForm)
		RemoveHandler childForm.FormClosed, AddressOf ChildForm_FormClosed
		RemoveHandler childForm.SaveQueryEvent, AddressOf ChildForm_SaveQueryEvent
		RemoveHandler childForm.SaveAsInFileEvent, AddressOf ChildForm_SaveAsInFileEvent
		RemoveHandler childForm.SaveAsNewUserQueryEvent, AddressOf ChildForm_SaveAsNewUserQueryEvent
	End Sub

	Private Sub ChildForm_SaveAsNewUserQueryEvent(sender As Object, e As CancelEventArgs)
		Dim childForm As ChildForm = DirectCast(sender, ChildForm)
		e.Cancel = Not SaveNewUserQuery(childForm)
	End Sub

	Private Sub ChildForm_SaveAsInFileEvent(sender As Object, e As CancelEventArgs)
		e.Cancel = Not SaveInFile(DirectCast(sender, ChildForm), True)
	End Sub

	Private Sub ChildForm_SaveQueryEvent(sender As Object, e As CancelEventArgs)
		' Saving the current query
		Dim childForm__1 As ChildForm = DirectCast(sender, ChildForm)
		Select Case childForm__1.SqlSourceType
			' as a new user query
			Case ChildForm.SourceType.[New]
				e.Cancel = Not SaveNewUserQuery(childForm__1)
				Exit Select
			' in a text file
			Case ChildForm.SourceType.File
				e.Cancel = Not SaveInFile(childForm__1, False)
				Exit Select
			' replacing an exising user query 
			Case ChildForm.SourceType.UserQuery
				e.Cancel = Not SaveUserQuery(childForm__1)
				Exit Select
			Case Else
				Throw New ArgumentOutOfRangeException()
		End Select
	End Sub

	Private Shared Function SaveInFile(childForm__1 As ChildForm, saveAs As Boolean) As Boolean
		If saveAs OrElse String.IsNullOrEmpty(childForm__1.FileSourcePath) Then
			Dim saveFileDialog1 As New SaveFileDialog() With { _
				.DefaultExt = "sql", _
				.FileName = "query", _
				.Filter = "SQL query files (*.sql)|*.sql|All files|*.*" _
			}
			If saveFileDialog1.ShowDialog() <> DialogResult.OK Then
				Return False
			End If
			childForm__1.SqlSourceType = ChildForm.SourceType.File
			childForm__1.FileSourcePath = saveFileDialog1.FileName
		End If
		Using sw As New StreamWriter(childForm__1.FileSourcePath)
			sw.Write(childForm__1.FormattedQueryText)
		End Using
		Return True
	End Function

	Private Function SaveUserQuery(childForm As ChildForm) As Boolean
		If childForm.UserMetadataStructureItem Is Nothing Then
			Return False
		End If
		If Not UserQueries.IsUserQueryExist(childForm.SqlQuery.SQLContext.MetadataContainer, childForm.UserMetadataStructureItem.MetadataItem.Name) Then
			Return False
		End If
		UserQueries.SaveUserQuery(childForm.SqlQuery.SQLContext.MetadataContainer, childForm.UserMetadataStructureItem, childForm.FormattedQueryText, childForm.QueryView.LayoutSQL)
		SaveSettings()
		Return True
	End Function

	Private Function SaveNewUserQuery(childWindow As ChildForm) As Boolean
		If String.IsNullOrEmpty(childWindow.SqlQuery.SQL) Then
			MessageBox.Show("Nothing to save: SQL query is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
			Return False
		End If

		Dim node As MetadataStructureItem = Nothing
		Dim title As String
		Do
			Using window As New QueryNameForm()
				window.QueryName = childWindow.SqlQuery.SQLContext.MetadataContainer.GetUniqueItemName(MetadataType.UserQuery, Helpers.Localizer.GetString("strNewQuery", LocalizableConstantsUI.strNewQuery))

				If window.ShowDialog() <> DialogResult.OK Then
					Return False
				End If

				title = window.QueryName
			End Using

			If Not UserQueries.IsUserQueryExist(childWindow.SqlQuery.SQLContext.MetadataContainer, title) Then
				Dim atItem = If(userQueriesView1.SelectedItem, userQueriesView1.MetadataStructure)
				If Not UserQueries.IsFolder(atItem) Then
					atItem = atItem.Parent
				End If

				Try
					node = UserQueries.AddUserQuery(childWindow.SqlQuery.SQLContext.MetadataContainer, atItem, title, childWindow.FormattedQueryText, CInt(DefaultImageListImageIndices.VirtualObject), childWindow.QueryView.LayoutSQL)
				Catch e As Exception
					MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
					Return False
				End Try

				Exit Do
			End If

			Dim path = userQueriesView1.GetPathAtUserQuery(title)
			Dim message = If(String.IsNullOrEmpty(path), "The same-named query already exists in the root folder.", String.Format("The same-named query already exists in the ""{0}"" folder.", path))


			MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
		Loop While True
		childWindow.SqlSourceType = ChildForm.SourceType.UserQuery
		childWindow.FileSourcePath = title
		childWindow.Text = title
		childWindow.UserMetadataStructureItem = node
		SaveSettings()
		Return True
	End Function

	' Saving user queries to the connection settings
	Private Sub SaveSettings()
		Using stream As New MemoryStream()
			userQueriesView1.ExportToXML(stream)
			stream.Position = 0

			Using reader As New StreamReader(stream)
				_selectedConnection.UserQueries = reader.ReadToEnd()
			End Using
		End Using
		Properties.Settings.[Default].XmlFiles = Program.XmlFiles
		Properties.Settings.[Default].Connections = Program.Connections
		Properties.Settings.[Default].Save()
		userQueriesView1.QueryView = Nothing
	End Sub

	Private Sub addDerivedTableToolStripMenuItem_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild Is Nothing Then
			Return
		End If
		Dim form = DirectCast(ActiveMdiChild, ChildForm)
		form.AddDerivedTable()
	End Sub

	Private Sub addUnionSubqueryToolStripMenuItem_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild Is Nothing Then
			Return
		End If
		Dim form = DirectCast(ActiveMdiChild, ChildForm)
		form.AddUnionSubQuery()
	End Sub

	Private Sub copyUnionSubwueryToolStripMenuItem_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild Is Nothing Then
			Return
		End If
		Dim form = DirectCast(ActiveMdiChild, ChildForm)
		form.CopyUnionSubQuery()
	End Sub

	Private Sub addObjectToolStripMenuItem_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild Is Nothing Then
			Return
		End If
		Dim form = DirectCast(ActiveMdiChild, ChildForm)
		form.AddObject()
	End Sub

	Private Sub queryPropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs)
		If ActiveMdiChild Is Nothing Then
			Return
		End If
		Dim form = DirectCast(ActiveMdiChild, ChildForm)
		form.PropertiesQuery()
	End Sub

	Private Sub propertiesToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim childForm = TryCast(ActiveMdiChild, ChildForm)
		If childForm Is Nothing Then
			Return
		End If

		Dim propWindow = New QueryPropertiesForm(childForm, DBView)

		propWindow.ShowDialog()

		Dim options = childForm.GetOptions()
		_options = options

		For Each form As Form In MdiChildren
			Dim child = TryCast(form, ChildForm)
			child.SetOptions(options)
		Next
	End Sub

	Private Sub tsbEditMetadata_Click(sender As Object, e As EventArgs)
		QueryBuilder.EditMetadataContainer(_sqlContext)
	End Sub

	Private Sub userQueriesView1_EditUserQuery(sender As Object, e As MetadataStructureItemCancelEventArgs)
		' Opening the user query in a new query window.
		If e.MetadataStructureItem Is Nothing Then
			Return
		End If

		Dim childWindow As ChildForm = CreateChildForm(e.MetadataStructureItem.MetadataItem.Name)
		childWindow.UserMetadataStructureItem = e.MetadataStructureItem
		childWindow.SqlSourceType = ChildForm.SourceType.UserQuery
		childWindow.Show()
		childWindow.Activate()
		childWindow.QueryText = DirectCast(e.MetadataStructureItem.MetadataItem, MetadataObject).Expression
	End Sub

	' Closing the current query window on deleting the corresponding user query.
	Private Sub userQueriesView1_UserQueryItemRemoved(sender As Object, item As MetadataStructureItem)
		Dim childWindow = MdiChildren.OfType(Of ChildForm)().FirstOrDefault(Function(x) x.UserMetadataStructureItem Is item)
		If childWindow IsNot Nothing Then
			childWindow.Close()
		End If
		SaveSettings()
	End Sub

	Private Sub userQueriesView1_ErrorMessage(sender As Object, eventArgs As MetadataStructureItemErrorEventArgs)
		MessageBox.Show(eventArgs.Message, "UserQueries error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
	End Sub

	Private Sub userQueriesView1_UserQueryItemRenamed(sender As Object, e As MetadataStructureItemTextChangedEventArgs)
		SaveSettings()
	End Sub

	Private Sub userQueriesView1_ValidateItemContextMenu(sender As Object, e As MetadataStructureItemMenuEventArgs)
		If e.MetadataStructureItem.MetadataItem Is Nothing Then
			Return
		End If

		Dim metadataObject = TryCast(e.MetadataStructureItem.MetadataItem, MetadataObject)
		If metadataObject Is Nothing Then
			Return
		End If

		e.Menu.InsertItem(2, "Copy SQL", AddressOf Execute_SqlExpression, False, True, Nothing, _
			metadataObject.Expression)
	End Sub

	Private Shared Sub Execute_SqlExpression(sender As Object, eventArgs As EventArgs)
		Dim item = DirectCast(sender, ICustomMenuItem)

		Clipboard.SetText(item.Tag.ToString(), TextDataFormat.UnicodeText)

		Debug.WriteLine("SQL: {0}", item.Tag)
	End Sub

	Private Sub toolStripExecuteUserQuery_Click(sender As Object, e As EventArgs)
		If userQueriesView1.SelectedItem Is Nothing Then
			Return
		End If

		Dim childWindow = CreateChildForm(userQueriesView1.SelectedItem.MetadataItem.Name)
		childWindow.UserMetadataStructureItem = userQueriesView1.SelectedItem
		childWindow.SqlSourceType = ChildForm.SourceType.UserQuery
		childWindow.Show()
		childWindow.Activate()
		childWindow.QueryText = DirectCast(userQueriesView1.SelectedItem.MetadataItem, MetadataObject).Expression
		childWindow.OpenExecuteTab()
	End Sub

	Private Sub userQueriesView1_SelectedItemChanged(sender As Object, e As EventArgs)
		toolStripExecuteUserQuery.Enabled = userQueriesView1.SelectedItem IsNot Nothing AndAlso Not userQueriesView1.SelectedItem.IsFolder()
	End Sub

	Private Sub MainForm_Shown(sender As Object, e As EventArgs)
		Connect()
	End Sub
	Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
		target = value
		Return value
	End Function
End Class
