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
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports Oracle.ManagedDataAccess.Client
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.WinForms
Imports FullFeaturedMdiDemo.Dailogs
Imports FullFeaturedMdiDemo.PropertiesForm
Imports MySql.Data.MySqlClient
Imports Npgsql
Imports Helpers = ActiveQueryBuilder.Core.Helpers

Partial Public Class MainForm
    Inherits Form
    Private _selectedConnection As ConnectionInfo
    Private _sqlContext As SQLContext
    Private ReadOnly _sqlFormattingOptions As SQLFormattingOptions
    Private ReadOnly _sqlGenerationOptions As SQLGenerationOptions

    Public Sub New()
        InitializeComponent()

        ' Options to present the formatted SQL query text to end-user
        ' Use names of virtual objects, do not replace them with appropriate derived tables
        _sqlFormattingOptions = New SQLFormattingOptions() With {
            .ExpandVirtualObjects = False
        }

        ' Options to generate the SQL query text for execution against a database server
        ' Replace virtual objects with derived tables
        _sqlGenerationOptions = New SQLGenerationOptions() With {
            .ExpandVirtualObjects = True
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

        ''CUT:PRO,STD{{
        ''DEMO WARNING
        Dim trialNoticePanel As New Panel() With {
                .AutoSize = True,
                .AutoSizeMode = AutoSizeMode.GrowAndShrink,
                .BackColor = Color.LightPink,
                .BorderStyle = BorderStyle.FixedSingle,
                .Dock = DockStyle.Top,
                .Padding = New Padding(6, 5, 3, 0)
                }

        Dim label As New Label() With {
                .AutoSize = True,
                .Margin = New Padding(0),
                .Text = "Generation of random aliases for the query output columns is the limitation of the trial version. The full version is free from this behavior.",
                .Dock = DockStyle.Fill,
                .UseCompatibleTextRendering = True
                }

        Dim buttonClose As PictureBox = New PictureBox() With {
                .SizeMode = PictureBoxSizeMode.AutoSize,
                .Cursor = Cursors.Hand
                }
        buttonClose.Image = Resources.cancel

        AddHandler buttonClose.Click, Sub(sender, args)
                                          Controls.Remove(trialNoticePanel)
                                      End Sub

        trialNoticePanel.Controls.Add(buttonClose)

        AddHandler trialNoticePanel.Resize, Sub(sender, args)
                                                buttonClose.Location = New Point(trialNoticePanel.Width - buttonClose.Width - 10, CType((trialNoticePanel.Height / 2 - buttonClose.Height / 2), Integer))
                                            End Sub

        trialNoticePanel.Controls.Add(label)
        Controls.Add(trialNoticePanel)

        Controls.SetChildIndex(trialNoticePanel, 2)

        ''}}CUT
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
        Using qualifiedName As SQLQualifiedName = metadataItem.GetSQLQualifiedName(Nothing, True)
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
        tsmiOfflineMode.Enabled = (ActiveMdiChild IsNot Nothing)
        tsmiOfflineMode.Checked = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).IsOfflineMode())
        tsmiRefreshMetadata.Enabled = (ActiveMdiChild IsNot Nothing)
        tsmiEditMetadata.Enabled = (ActiveMdiChild IsNot Nothing)
        tsmiClearMetadata.Enabled = (ActiveMdiChild IsNot Nothing)
        tsmiLoadMetadataFromXML.Enabled = (ActiveMdiChild IsNot Nothing)
        tsmiSaveMetadataToXML.Enabled = (ActiveMdiChild IsNot Nothing)

        addDerivedTableToolStripMenuItem.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanAddDerivedTable())
        addObjectToolStripMenuItem.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanAddObject())
        addUnionSubqueryToolStripMenuItem.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanAddUnionSubQuery())
        copyUnionSubwueryToolStripMenuItem.Enabled = (ActiveMdiChild IsNot Nothing AndAlso DirectCast(ActiveMdiChild, ChildForm).CanCopyUnionSubQuery())

        tsbEditMetadata.Enabled = _sqlContext IsNot Nothing AndAlso _sqlContext.MetadataContainer IsNot Nothing
    End Sub

    Private Sub tsbNew_Click(sender As Object, e As EventArgs) Handles tsbNew.Click
        tsmiNew_Click(sender, e)
    End Sub

    Private Sub InitializeSqlContext()
        Try
            Cursor = Cursors.WaitCursor

            Dim metadataProvaider As BaseMetadataProvider = Nothing

            ' create new SqlConnection object using the connections string from the connection form
            If Not _selectedConnection.IsXmlFile Then
                Select Case _selectedConnection.ConnectionType
                    Case ConnectionTypes.MSSQL
                        metadataProvaider = New MSSQLMetadataProvider() With {
                            .Connection = New SqlConnection(_selectedConnection.ConnectionString)
                        }
                        Exit Select
                    Case ConnectionTypes.MSAccess
                        metadataProvaider = New OLEDBMetadataProvider() With {
                            .Connection = New OleDbConnection(_selectedConnection.ConnectionString)
                        }
                        Exit Select
                    Case ConnectionTypes.Oracle
                        ' previous version of this demo uses deprecated System.Data.OracleClient
                        ' current version uses Oracle.ManagedDataAccess.Client which doesn't support "Integrated Security" setting
                        Dim updatedConnectionString As String = Regex.Replace(_selectedConnection.ConnectionString, "Integrated Security=.*?;", "")

                        metadataProvaider = New OracleNativeMetadataProvider() With {
                            .Connection = New OracleConnection(updatedConnectionString)
                        }
                        Exit Select
                    Case ConnectionTypes.MySQL
                        metadataProvaider = New MySQLMetadataProvider() With {
                            .Connection = New MySqlConnection(_selectedConnection.ConnectionString)
                        }
                        Exit Select
                    Case ConnectionTypes.PostgreSQL
                        metadataProvaider = New PostgreSQLMetadataProvider() With {
                            .Connection = New NpgsqlConnection(_selectedConnection.ConnectionString)
                        }
                        Exit Select
                    Case ConnectionTypes.OLEDB
                        metadataProvaider = New OLEDBMetadataProvider() With {
                            .Connection = New OleDbConnection(_selectedConnection.ConnectionString)
                        }
                        Exit Select
                    Case ConnectionTypes.ODBC
                        metadataProvaider = New ODBCMetadataProvider() With {
                            .Connection = New OdbcConnection(_selectedConnection.ConnectionString)
                        }
                        Exit Select
                    Case Else
                        Throw New ArgumentOutOfRangeException()
                End Select
            End If

            If _selectedConnection.IsXmlFile AndAlso _selectedConnection.SyntaxProvider Is Nothing Then
                _selectedConnection.CreateSyntaxByType()
            End If

            ' setup the query builder with metadata and syntax providers
            _sqlContext = New SQLContext() With {
                .MetadataProvider = metadataProvaider,
                .SyntaxProvider = _selectedConnection.SyntaxProvider
            }

            _sqlContext.MetadataContainer.LoadingOptions.OfflineMode = (metadataProvaider Is Nothing)

            If metadataProvaider Is Nothing Then
                _sqlContext.MetadataContainer.ImportFromXML(_selectedConnection.ConnectionString)
            End If
            CaptionConnection.Text = _selectedConnection.ConnectionName

            DBView.SQLContext = _sqlContext
            DBView.InitializeDatabaseSchemaTree()

            userQueriesView1.SQLContext = _sqlContext
            userQueriesView1.SQLQuery = New SQLQuery(_sqlContext)

            If Not String.IsNullOrEmpty(_selectedConnection.UserQueries) Then
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(_selectedConnection.UserQueries)

                Using reader As MemoryStream = New MemoryStream(bytes)
                    userQueriesView1.ImportFromXML(reader)
                End Using
            End If
        Finally
            Cursor = Cursors.[Default]
        End Try
    End Sub

    Private Sub tsmiNew_Click(sender As Object, e As EventArgs) Handles tsmiNew.Click
        Connect()
    End Sub

    Private Sub Connect()
        Using cf As New ConnectionForm()
            If cf.ShowDialog() = DialogResult.OK Then
                Try
                    Cursor = Cursors.WaitCursor
                    If _selectedConnection Is cf.SelectedConnection Then
                        Return
                    End If
                    For Each mdiChild As ChildForm In MdiChildren
                        mdiChild.Close()
                    Next
                    If MdiChildren.Length > 0 Then
                        Return
                    End If
                    _selectedConnection = cf.SelectedConnection
                    InitializeSqlContext()
                    If Not String.IsNullOrEmpty(_selectedConnection.UserQueries) Then
                        Dim bytes As Byte() = Encoding.UTF8.GetBytes(_selectedConnection.UserQueries)
                        Using reader As MemoryStream = New MemoryStream(bytes)
                            userQueriesView1.ImportFromXML(reader)
                        End Using
                    End If
                Finally
                    Cursor = Cursors.[Default]
                End Try
            End If
        End Using
    End Sub

    Private Sub tsmiOpen_Click(sender As Object, e As EventArgs) Handles tsmiOpen.Click
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
            f.QueryText = sb.ToString()
            f.FileSourcePath = openFileDialog1.FileName
            f.SqlSourceType = ChildForm.SourceType.File
            f.Show()
        End If
    End Sub

    Private Sub tsmiSave_Click(sender As Object, e As EventArgs) Handles tsmiSave.Click
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
    End Sub

    Private Sub tsbCascade_Click(sender As Object, e As EventArgs) Handles tsbCascade.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub tsbTileHorizontally_Click(sender As Object, e As EventArgs) Handles tsbTileHorizontally.Click
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub tsbTileVertically_Click(sender As Object, e As EventArgs) Handles tsbTileVertically.Click
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub tsmiParseQuery_Click(sender As Object, e As EventArgs) Handles tsmiParseQuery.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).ParseQuery()
        End If
    End Sub

    Private Sub tsmiBuildQuery_Click(sender As Object, e As EventArgs) Handles tsmiBuildQuery.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).ActivateBuildQueryTab()
        End If
    End Sub

    Private Sub tsmiRunQuery_Click(sender As Object, e As EventArgs) Handles tsmiRunQuery.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).ActivateRunQueryTab()
        End If
    End Sub

    Private Sub tsmiQueryStatistics_Click(sender As Object, e As EventArgs) Handles tsmiQueryStatistics.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).ShowQueryStatistics()
        End If
    End Sub

    Private Sub tsmiAbout_Click(sender As Object, e As EventArgs) Handles tsmiAbout.Click
        Using f As New AboutForm()
            f.ShowDialog()
        End Using
    End Sub

    Private Sub tsmiUndo_Click(sender As Object, e As EventArgs) Handles tsmiUndo.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).Undo()
        End If
    End Sub

    Private Sub tsmiRedo_Click(sender As Object, e As EventArgs) Handles tsmiRedo.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).Redo()
        End If
    End Sub

    Private Sub tsmiCut_Click(sender As Object, e As EventArgs) Handles tsmiCut.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).Cut()
        End If
    End Sub

    Private Sub tsmiCopy_Click(sender As Object, e As EventArgs) Handles tsmiCopy.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).Copy()
        End If
    End Sub

    Private Sub tsmiPaste_Click(sender As Object, e As EventArgs) Handles tsmiPaste.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).Paste()
        End If
    End Sub

    Private Sub tsmiSelectAll_Click(sender As Object, e As EventArgs) Handles tsmiSelectAll.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).SelectAll()
        End If
    End Sub

    Private Sub tsbOpen_Click(sender As Object, e As EventArgs) Handles tsbOpen.Click
        tsmiOpen_Click(sender, e)
    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        tsmiSave_Click(sender, e)
    End Sub

    Private Sub tsbAbout_Click(sender As Object, e As EventArgs) Handles tsbAbout.Click
        tsmiAbout_Click(sender, e)
    End Sub

    Private Sub tsbCut_Click(sender As Object, e As EventArgs) Handles tsbCut.Click
        tsmiCut_Click(sender, e)
    End Sub

    Private Sub tsbCopy_Click(sender As Object, e As EventArgs) Handles tsbCopy.Click
        tsmiCopy_Click(sender, e)
    End Sub

    Private Sub tsbPaste_Click(sender As Object, e As EventArgs) Handles tsbPaste.Click
        tsmiPaste_Click(sender, e)
    End Sub

    Private Sub tsmiOfflineMode_Click(sender As Object, e As EventArgs) Handles tsmiOfflineMode.Click
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

    Private Sub tsmiRefreshMetadata_Click(sender As Object, e As EventArgs) Handles tsmiRefreshMetadata.Click
        If ActiveMdiChild IsNot Nothing Then
            ' to refresh metadata, just clear already loaded items
            DirectCast(ActiveMdiChild, ChildForm).ClearMetadata()
            DirectCast(ActiveMdiChild, ChildForm).RefreshMetadata()
        End If
    End Sub

    Private Sub tsmiEditMetadata_Click(sender As Object, e As EventArgs) Handles tsmiEditMetadata.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).EditMetadata()
        End If
    End Sub

    Private Sub tsmiClearMetadata_Click(sender As Object, e As EventArgs) Handles tsmiClearMetadata.Click
        If ActiveMdiChild IsNot Nothing Then
            ' to refresh metadata, just clear already loaded items
            DirectCast(ActiveMdiChild, ChildForm).ClearMetadata()
        End If
    End Sub

    Private Sub tsmiLoadMetadataFromXML_Click(sender As Object, e As EventArgs) Handles tsmiLoadMetadataFromXML.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).LoadMetadataFromXml()
        End If
    End Sub

    Private Sub tsmiSaveMetadataToXML_Click(sender As Object, e As EventArgs) Handles tsmiSaveMetadataToXML.Click
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).SaveMetadataToXml()
        End If
    End Sub

    Private Sub tsmiLanguageAuto_Click(sender As Object, e As EventArgs) Handles tsmiLanguageAuto.Click
        Program.Settings.Language = "Auto"

        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).UpdateLanguage()
        End If
    End Sub

    Private Sub tsmiLanguageDefault_Click(sender As Object, e As EventArgs) Handles tsmiLanguageDefault.Click
        Program.Settings.Language = "Default"
        If ActiveMdiChild IsNot Nothing Then
            DirectCast(ActiveMdiChild, ChildForm).UpdateLanguage()
        End If
    End Sub

    Private Sub newQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles toolStripButtonNewQuery.Click, newQueryToolStripMenuItem1.Click
        CreateChildForm("New query").Show()
    End Sub

    Private Function CreateChildForm(Optional caption As String = Nothing) As ChildForm
        Dim childForm As New ChildForm(_sqlContext, _selectedConnection) With {
            .MdiParent = Me,
            .SqlFormattingOptions = _sqlFormattingOptions,
            .SqlGenerationOptions = _sqlGenerationOptions,
            .Text = If(String.IsNullOrEmpty(caption), "New query", caption)
        }
        AddHandler childForm.FormClosed, AddressOf ChildForm_FormClosed
        AddHandler childForm.SaveQueryEvent, AddressOf ChildForm_SaveQueryEvent
        AddHandler childForm.SaveAsInFileEvent, AddressOf ChildForm_SaveAsInFileEvent
        AddHandler childForm.SaveAsNewUserQueryEvent, AddressOf ChildForm_SaveAsNewUserQueryEvent
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
        Dim childForm1 As ChildForm = DirectCast(sender, ChildForm)
        Select Case childForm1.SqlSourceType
            ' as a new user query
            Case ChildForm.SourceType.[New]
                e.Cancel = Not SaveNewUserQuery(childForm1)
                Exit Select
            ' in a text file
            Case ChildForm.SourceType.File
                e.Cancel = Not SaveInFile(childForm1, False)
                Exit Select
            ' replacing an exising user query 
            Case ChildForm.SourceType.UserQuery
                e.Cancel = Not SaveUserQuery(childForm1)
                Exit Select
            Case Else
                Throw New ArgumentOutOfRangeException()
        End Select
    End Sub

    Private Shared Function SaveInFile(childForm1 As ChildForm, saveAs As Boolean) As Boolean
        If saveAs OrElse String.IsNullOrEmpty(childForm1.FileSourcePath) Then
            Dim saveFileDialog1 As New SaveFileDialog() With {
                .DefaultExt = "sql",
                .FileName = "query",
                .Filter = "SQL query files (*.sql)|*.sql|All files|*.*"
            }
            If saveFileDialog1.ShowDialog() <> DialogResult.OK Then
                Return False
            End If
            childForm1.SqlSourceType = ChildForm.SourceType.File
            childForm1.FileSourcePath = saveFileDialog1.FileName
        End If
        Using sw As New StreamWriter(childForm1.FileSourcePath)
            sw.Write(childForm1.FormattedQueryText)
        End Using
        Return True
    End Function

    Private Function SaveUserQuery(childForm As ChildForm) As Boolean
        If childForm.UserMetadataStructureItem Is Nothing Then
            Return False
        End If
        If Not ActiveQueryBuilder.Core.UserQueries.IsUserQueryExist(childForm.SqlQuery.SQLContext.MetadataContainer, childForm.UserMetadataStructureItem.MetadataItem.Name) Then
            Return False
        End If
        ActiveQueryBuilder.Core.UserQueries.SaveUserQuery(childForm.SqlQuery.SQLContext.MetadataContainer, childForm.UserMetadataStructureItem, childForm.SqlQuery.SQL, "")
        SaveSettings()
        Return True
    End Function

    Private Function SaveNewUserQuery(childWindow As ChildForm) As Boolean
        Dim node As MetadataStructureItem
        Dim title As String
        Do
            Dim window As New QueryNameForm()
            If window.ShowDialog() <> DialogResult.OK Then
                Return False
            End If
            title = window.QueryName
            If Not ActiveQueryBuilder.Core.UserQueries.IsUserQueryExist(childWindow.SqlQuery.SQLContext.MetadataContainer, title) Then
                Dim atItem As MetadataStructureItem = CType(If(userQueriesView1.SelectedItem, userQueriesView1.MetadataStructure), MetadataStructureItem)
                If Not ActiveQueryBuilder.Core.UserQueries.IsFolder(atItem) Then
                    atItem = atItem.Parent
                End If
                node = ActiveQueryBuilder.Core.UserQueries.AddUserQuery(childWindow.SqlQuery.SQLContext.MetadataContainer, atItem, title, childWindow.SqlQuery.SQL, CInt(DefaultImageListImageIndices.VirtualObject))
                Exit Do
            End If

            Dim path As String = userQueriesView1.GetPathAtUserQuery(title)
            Dim message As String = If(String.IsNullOrEmpty(path), "The same-named query already exists in the root folder.", String.Format("The same-named query already exists in the ""{0}"" folder.", path))


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

    Private Sub addDerivedTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addDerivedTableToolStripMenuItem.Click
        If ActiveMdiChild Is Nothing Then
            Return
        End If
        Dim form As ChildForm = DirectCast(ActiveMdiChild, ChildForm)
        form.AddDerivedTable()
    End Sub

    Private Sub addUnionSubqueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addUnionSubqueryToolStripMenuItem.Click
        If ActiveMdiChild Is Nothing Then
            Return
        End If
        Dim form As ChildForm = DirectCast(ActiveMdiChild, ChildForm)
        form.AddUnionSubQuery()
    End Sub

    Private Sub copyUnionSubwueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles copyUnionSubwueryToolStripMenuItem.Click
        If ActiveMdiChild Is Nothing Then
            Return
        End If
        Dim form As ChildForm = DirectCast(ActiveMdiChild, ChildForm)
        form.CopyUnionSubQuery()
    End Sub

    Private Sub addObjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles addObjectToolStripMenuItem.Click
        If ActiveMdiChild Is Nothing Then
            Return
        End If
        Dim form As ChildForm = DirectCast(ActiveMdiChild, ChildForm)
        form.AddObject()
    End Sub

    Private Sub queryPropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles queryPropertiesToolStripMenuItem.Click
        If ActiveMdiChild Is Nothing Then
            Return
        End If
        Dim form As ChildForm = DirectCast(ActiveMdiChild, ChildForm)
        form.PropertiesQuery()
    End Sub

    Private Sub propertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles propertiesToolStripMenuItem.Click
        Dim propWindow As QueryPropertiesForm = New QueryPropertiesForm(_sqlContext, _sqlFormattingOptions)
        propWindow.ShowDialog()
    End Sub

    Private Sub tsbEditMetadata_Click(sender As Object, e As EventArgs) Handles tsbEditMetadata.Click
        QueryBuilder.EditMetadataContainer(_sqlContext.MetadataContainer, _sqlContext.MetadataStructure, _sqlContext.MetadataContainer.LoadingOptions)
    End Sub

    Private Sub userQueriesView1_EditUserQuery(sender As Object, item As MetadataStructureItem)
        ' Opening the user query in a new query window.
        If item Is Nothing Then
            Return
        End If

        Dim childWindow As ChildForm = CreateChildForm(item.MetadataItem.Name)
        childWindow.UserMetadataStructureItem = item
        childWindow.SqlSourceType = ChildForm.SourceType.UserQuery
        childWindow.Show()
        childWindow.Activate()
        childWindow.QueryText = DirectCast(item.MetadataItem, MetadataObject).Expression.Trim("("c, ")"c)
    End Sub

    ' Closing the current query window on deleting the corresponding user query.
    Private Sub userQueriesView1_UserQueryItemRemoved(sender As Object, item As MetadataStructureItem)
        Dim childWindow As ChildForm = MdiChildren.OfType(Of ChildForm)().FirstOrDefault(Function(x) x.UserMetadataStructureItem Is item)
        If childWindow IsNot Nothing Then
            childWindow.Close()
        End If
        SaveSettings()
    End Sub

    Private Sub userQueriesView1_ErrorMessage(sender As Object, exception As Exception)
        MessageBox.Show(exception.Message, "UserQueries error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
    End Sub

    Private Sub userQueriesView1_UserQueryItemRenamed(sender As Object, node As MetadataStructureItem)
        SaveSettings()
    End Sub

    Private Sub userQueriesView1_SelectedItemChanged(sender As Object, item As MetadataStructureItem)
        toolStripExecuteUserQuery.Enabled = item IsNot Nothing AndAlso Not item.IsFolder()
    End Sub

    Private Sub userQueriesView1_ValidateItemContextMenu(sender As Object, item As MetadataStructureItem, ByRef menu As ICustomContextMenu)
        menu.InsertItem(2, "Copy SQL", AddressOf Execute_SqlExpression, False, True, Nothing,
            DirectCast(item.MetadataItem, MetadataObject).Expression)
    End Sub

    Private Shared Sub Execute_SqlExpression(sender As Object, eventArgs As EventArgs)
        Dim item As ICustomMenuItem = DirectCast(sender, ICustomMenuItem)

        Clipboard.SetText(item.Tag.ToString(), TextDataFormat.UnicodeText)

        Debug.WriteLine("SQL: {0}", item.Tag)
    End Sub

    Private Sub toolStripExecuteUserQuery_Click(sender As Object, e As EventArgs) Handles toolStripExecuteUserQuery.Click
        If userQueriesView1.SelectedItem Is Nothing Then
            Return
        End If

        Dim childWindow As ChildForm = CreateChildForm(userQueriesView1.SelectedItem.MetadataItem.Name)
        childWindow.UserMetadataStructureItem = userQueriesView1.SelectedItem
        childWindow.SqlSourceType = ChildForm.SourceType.UserQuery
        childWindow.Show()
        childWindow.Activate()
        childWindow.QueryText = DirectCast(userQueriesView1.SelectedItem.MetadataItem, MetadataObject).Expression.Trim("("c, ")"c)
        childWindow.OpenExecuteTab()
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
End Class
