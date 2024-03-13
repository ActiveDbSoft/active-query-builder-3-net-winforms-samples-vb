''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2024 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Text
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.PropertiesEditors
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.PropertiesEditors
Imports ActiveQueryBuilder.View.WinForms.Images
Imports ActiveQueryBuilder.View.WinForms.QueryView


Partial Public Class EditConnectionForm
    Inherits Form
    Private ReadOnly _connection As ConnectionInfo
    Private _isFilterPageInitialized As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(connection As ConnectionInfo)
        Me.New()
        pnlFilterInfo.InfoText = "1. Add unwanted objects to Exclude tab. Any other objects will be displayed." & vbCrLf & "2. Add the needed objects to Include tab. Only those objects will be displayed."

        pnlFilterInfo.Tooltip = "By adding a namespace (database, schema, etc.) you instruct to include or exclude all objects from this namespace." & vbCrLf & vbCrLf & "You can add the needed namespaces to the Include tab but exclude certain objects or nested namespaces by adding them to the Exclude tab at the same time."

        lbMenu.SelectedIndex = 0
        _connection = connection
        tbConnectionName.Text = connection.Name

        FillConnectionTypes()
        FillSyntaxTypes()

        cbConnectionType.SelectedItem = _connection.ConnectionDescriptor.GetDescription()
        UpdateConnectionPropertiesFrames()

        FillImageList()
    End Sub

    Private Sub FillImageList()
        imageList.Images.Add("Server", Metadata.Server.Value)
        imageList.Images.Add("Database", Metadata.Database.Value)
        imageList.Images.Add("Schema", Metadata.Schema.Value)
        imageList.Images.Add("Package", Metadata.Package.Value)
        imageList.Images.Add("Table", Metadata.UserTable.Value)
        imageList.Images.Add("View", Metadata.UserView.Value)
        imageList.Images.Add("Procedure", Metadata.UserProcedure.Value)
        imageList.Images.Add("Synonym", Metadata.UserSynonym.Value)
    End Sub

    Private Sub FillSyntaxTypes()
        For Each syntax As Type In ActiveQueryBuilder.Core.Helpers.SyntaxProviderList
            Dim instance = TryCast(Activator.CreateInstance(syntax), BaseSyntaxProvider)
            cbSyntax.Items.Add(instance.Description)
        Next syntax
    End Sub

    Private Sub FillConnectionTypes()
        For Each connectionDescriptorNames In Misc.ConnectionDescriptorNames
            cbConnectionType.Items.Add(connectionDescriptorNames)
        Next connectionDescriptorNames
    End Sub

    Private Sub tbConnectionName_TextChanged(sender As Object, e As EventArgs) Handles tbConnectionName.TextChanged
        _connection.Name = tbConnectionName.Text
    End Sub

    Private Sub cbConnectionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbConnectionType.SelectedIndexChanged
        Dim descriptorType = GetSelectedDescriptorType()
        If _connection.ConnectionDescriptor IsNot Nothing AndAlso _connection.ConnectionDescriptor.GetType() Is descriptorType Then
            Return
        End If

        _connection.ConnectionDescriptor = CreateConnectionDescriptor(descriptorType)

        If _connection.ConnectionDescriptor Is Nothing Then
            LockUI()
            Return
        Else
            UnlockUI()
        End If

        _connection.Type = _connection.GetConnectionType(descriptorType)

        UpdateConnectionPropertiesFrames()
    End Sub

    Private Sub LockUI()
        lbMenu.Enabled = False
        btnOk.Enabled = False

        RemoveConnectionPropertiesFrame()
        RemoveSyntaxFrame()
    End Sub

    Private Sub UnlockUI()
        lbMenu.Enabled = True
        btnOk.Enabled = True
    End Sub

    Private Sub UpdateConnectionPropertiesFrames()
        SetupSyntaxCombobox()
        RecreateConnectionFrame()
        RecreateSyntaxFrame()
        RecreateLoadingOptions()
        RecreateStructureOptions()
    End Sub

    Private Sub RecreateLoadingOptions()
        RecreateProperties(pbMetadataLoading, _connection.ConnectionDescriptor.MetadataLoadingOptions)
    End Sub

    Private Sub RecreateStructureOptions()
        RecreateProperties(pbStructureOptions, _connection.StructureOptions)
    End Sub

    Private Sub RecreateProperties(propertiesBar As PropertiesBar, properties As Object)
        propertiesBar.Controls.Clear()
        Dim container = PropertiesFactory.GetPropertiesContainer(properties)
        TryCast(propertiesBar, IPropertiesControl).SetProperties(container)
    End Sub

    Private Sub SetupSyntaxCombobox()
        If _connection.IsGenericConnection() Then
            pnlTop.Height = cbSyntax.Bottom + 8
            cbSyntax.SelectedItem = _connection.ConnectionDescriptor.SyntaxProvider.Description
        Else
            pnlTop.Height = cbConnectionType.Bottom + 8
        End If
    End Sub

    Private Function GetSelectedDescriptorType() As Type
        Return  Misc.ConnectionDescriptorList(cbConnectionType.SelectedIndex)
    End Function

    Private Function CreateConnectionDescriptor(type As Type) As BaseConnectionDescriptor
        Try
            Return TryCast(Activator.CreateInstance(type), BaseConnectionDescriptor)
        Catch e As Exception
            Dim message = If(e.InnerException IsNot Nothing, e.InnerException.Message, e.Message)
            MessageBox.Show(message & vbCrLf & " " & vbCrLf & "To fix this error you may need to install the appropriate database client software or " & vbCrLf & " re-compile the project from sources and add the needed assemblies to the References section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return Nothing
        End Try
    End Function

    Private Sub RecreateConnectionFrame()
        RemoveConnectionPropertiesFrame()
        ClearProperties(_connection.ConnectionDescriptor.MetadataProperties)
        Dim container = PropertiesFactory.GetPropertiesContainer(_connection.ConnectionDescriptor.MetadataProperties)
        TryCast(pbConnection, IPropertiesControl).SetProperties(container)
    End Sub

    Private Sub ClearProperties(properties As ObjectProperties)
        properties.GroupProperties.Clear()
        properties.PropertiesEditors.Clear()
    End Sub

    Private Sub RemoveConnectionPropertiesFrame()
        pbConnection.Controls.Clear()
    End Sub

    Private Sub RecreateSyntaxFrame()
        RemoveSyntaxFrame()
        Dim syntxProps = _connection.ConnectionDescriptor.SyntaxProperties
        If syntxProps Is Nothing Then
            pbSyntax.Height = 0
            Return
        End If

        ClearProperties(syntxProps)
        Dim container = PropertiesFactory.GetPropertiesContainer(syntxProps)
        TryCast(pbSyntax, IPropertiesControl).SetProperties(container)

        pbSyntax.Height = pbSyntax.Controls(0).Bottom + 5
    End Sub

    Private Sub RemoveSyntaxFrame()
        pbSyntax.Controls.Clear()
    End Sub

    Private Sub lbMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbMenu.SelectedIndexChanged
        Select Case lbMenu.SelectedIndex
            Case 0
                tcProperties.SelectedTab = tpConnection
            Case 1
                InitializeFilterPage()
            Case 2
                tcProperties.SelectedTab = tpMetadataLoading
            Case 3
                tcProperties.SelectedTab = tpStructureOptions
        End Select
    End Sub

    Private Sub InitializeFilterPage()
        If Not _isFilterPageInitialized Then
            Cursor = Cursors.WaitCursor
            Try
                databaseSchemaView1.SQLContext = _connection.ConnectionDescriptor.GetSqlContext()
                ClearFilters(databaseSchemaView1.SQLContext.LoadingOptions)
                databaseSchemaView1.InitializeDatabaseSchemaTree()
                LoadFilters()
                _isFilterPageInitialized = True
            Catch
                _isFilterPageInitialized = False
            Finally
                Cursor = Cursors.Default
            End Try
        End If

        tcProperties.SelectedTab = tpFilter
    End Sub

    Private Sub ClearFilters(options As MetadataLoadingOptions)
        options.ExcludeFilter.Objects.Clear()
        options.IncludeFilter.Objects.Clear()
        options.ExcludeFilter.Schemas.Clear()
        options.IncludeFilter.Schemas.Clear()
    End Sub

    Private Sub LoadFilters()
        LoadIncludeFilters()
        LoadExcludeFilters()
        UpdateTabFiltersCaption()
    End Sub

    Private Sub LoadIncludeFilters()
        Dim filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.IncludeFilter
        LoadFilterTo(filter, lvInclude)
    End Sub

    Private Sub LoadExcludeFilters()
        Dim filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.ExcludeFilter
        LoadFilterTo(filter, lvExclude)
    End Sub

    Private Sub LoadFilterTo(filter As MetadataSimpleFilter, listBox As ListView)
        Dim sqlContext = databaseSchemaView1.SQLContext

        For Each filterObject In filter.Objects
            Using parsedName = GetNameForSearch(sqlContext, filterObject)
                Dim item = FindItemByName(parsedName)
                If item IsNot Nothing Then
                    Dim listItem = listBox.Items.Add(item.NameFull, GetImageKeyByItem(item))
                    listItem.Tag = filterObject
                Else
                    Dim listItem = listBox.Items.Add(parsedName.GetQualifiedName(), GetImageKeyByItem(Nothing))
                    listItem.Tag = filterObject
                End If
            End Using
        Next filterObject

        For Each filterSchema In filter.Schemas
            Using parsedName = GetNameForSearch(sqlContext, filterSchema)
                Dim item = FindItemByName(parsedName)
                If item IsNot Nothing Then
                    Dim listItem = listBox.Items.Add(item.NameFull, GetImageKeyByItem(item))
                    listItem.Tag = filterSchema
                Else
                    Dim listItem = listBox.Items.Add(parsedName.GetQualifiedName(), GetImageKeyByItem(Nothing))
                    listItem.Tag = filterSchema
                End If
            End Using
        Next filterSchema
    End Sub

    Private Function GetNameForSearch(sqlContext As SQLContext, name As String) As SQLQualifiedName
        Return sqlContext.ParseQualifiedName(name.Replace(".%", "").Replace("%.", ""))
    End Function

    Private Function FindItemByName(name As SQLQualifiedName) As MetadataItem
        Return databaseSchemaView1.MetadataStructure.MetadataItem.FindItem(Of MetadataItem)(name)
    End Function

    Private Sub btnAddFilter_Click(sender As Object, e As EventArgs) Handles btnAddFilter.Click
        If tcFilters.SelectedTab Is tpInclude Then
            AddIncludeFilter(databaseSchemaView1.SelectedItems)
        ElseIf tcFilters.SelectedTab Is tpExclude Then
            AddExcludeFilter(databaseSchemaView1.SelectedItems)
        End If
    End Sub

    Private Sub AddIncludeFilter(items() As MetadataStructureItem)
        Dim filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.IncludeFilter
        For Each structureItem In items
            Dim metadataItem = structureItem.MetadataItem
            If metadataItem Is Nothing Then
                Continue For
            End If

            Dim filtrationName = GetObjectNameForFilter(metadataItem)
            If metadataItem.Type.IsNamespace() Then
                filter.Schemas.Add(filtrationName)
            ElseIf metadataItem.Type.IsObject() Then
                filter.Objects.Add(filtrationName)
            End If

            Dim listItem = lvInclude.Items.Add(metadataItem.NameFull, GetImageKeyByItem(metadataItem))
            listItem.Tag = filtrationName
        Next structureItem

        UpdateTabFiltersCaption()
    End Sub

    Private Sub AddExcludeFilter(items() As MetadataStructureItem)
        Dim filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.ExcludeFilter
        For Each structureItem In items
            Dim metadataItem = structureItem.MetadataItem
            If metadataItem Is Nothing Then
                Continue For
            End If

            Dim filtrationName = GetObjectNameForFilter(metadataItem)
            If metadataItem.Type.IsNamespace() Then
                filter.Schemas.Add(filtrationName)
            ElseIf metadataItem.Type.IsObject() Then
                filter.Objects.Add(filtrationName)
            End If

            Dim listItem = lvExclude.Items.Add(metadataItem.NameFull, GetImageKeyByItem(metadataItem))
            listItem.Tag = filtrationName
        Next structureItem

        UpdateTabFiltersCaption()
    End Sub

    Private Sub UpdateTabFiltersCaption()
        tpInclude.Text = "Include"
        If lvInclude.Items.Count <> 0 Then
            tpInclude.Text += String.Format(" ({0})", lvInclude.Items.Count)
        End If

        tpExclude.Text = "Exclude"
        If lvExclude.Items.Count <> 0 Then
            tpExclude.Text += String.Format(" ({0})", lvExclude.Items.Count)
        End If
    End Sub

    Private Function GetObjectNameForFilter(item As MetadataItem) As String
        If _connection.ConnectionDescriptor Is Nothing OrElse _connection.ConnectionDescriptor.SyntaxProvider Is Nothing Then
            Return String.Empty
        End If

        If item.Type.IsObject() Then
            Return item.NameFull
        End If

        Dim syntax = _connection.ConnectionDescriptor.SyntaxProvider
        Dim servers = syntax.IsSupportServers()
        Dim databases = syntax.IsSupportDatabases()
        Dim packages = syntax.IsSupportPackages()
        Dim schemas = syntax.IsSupportSchemas()

        Dim result = New StringBuilder()
        If servers Then
            result.Append(If(item.Server IsNot Nothing, """" & item.Server.Name & """", "%"))
        End If

        If databases Then
            If result.Length <> 0 Then
                result.Append(".")
            End If

            result.Append(If(item.Database IsNot Nothing, """" & item.Database.Name & """", "%"))
        End If

        If packages Then
            If result.Length <> 0 Then
                result.Append(".")
            End If

            result.Append(If(item.Package IsNot Nothing, """" & item.Package.Name & """", "%"))
        End If

        If schemas Then
            If result.Length <> 0 Then
                result.Append(".")
            End If

            result.Append(If(item.Schema IsNot Nothing, """" & item.Schema.Name & """", "%"))
        End If

        Return result.ToString()
    End Function

    Private Function GetImageKeyByItem(item As MetadataItem) As String
        If item Is Nothing Then
            Return String.Empty
        End If

        Select Case item.Type
            Case MetadataType.Server
                Return "Server"
            Case MetadataType.Database
                Return "Database"
            Case MetadataType.Schema
                Return "Schema"
            Case MetadataType.Package
                Return "Package"
            Case MetadataType.Table
                Return "Table"
            Case MetadataType.View
                Return "View"
            Case MetadataType.Procedure
                Return "Procedure"
            Case MetadataType.Synonym
                Return "Synonym"
            Case Else
                Return String.Empty
        End Select
    End Function

    Private Sub btnDeleteFilter_Click(sender As Object, e As EventArgs) Handles btnDeleteFilter.Click
        If tcFilters.SelectedTab Is tpInclude Then
            For Each selectedItem As ListViewItem In lvInclude.SelectedItems
                DeleteFilter(selectedItem)
            Next selectedItem
        ElseIf tcFilters.SelectedTab Is tpExclude Then
            For Each selectedItem As ListViewItem In lvExclude.SelectedItems
                DeleteFilter(selectedItem)
            Next selectedItem
        End If
    End Sub

    Private Sub DeleteFilter(item As ListViewItem)
        Dim filter As MetadataSimpleFilter = Nothing
        If tcFilters.SelectedTab Is tpInclude Then
            filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.IncludeFilter
        ElseIf tcFilters.SelectedTab Is tpExclude Then
            filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.ExcludeFilter
        End If

        If filter IsNot Nothing Then
            filter.Objects.Remove(TryCast(item.Tag, String))
            filter.Schemas.Remove(TryCast(item.Tag, String))
        End If

        If tcFilters.SelectedTab Is tpInclude Then
            lvInclude.Items.Remove(item)
        ElseIf tcFilters.SelectedTab Is tpExclude Then
            lvExclude.Items.Remove(item)
        End If

        UpdateTabFiltersCaption()
    End Sub

    Private Sub lbInclude_DragDrop(sender As Object, e As DragEventArgs) Handles lvInclude.DragDrop
        DropItems(e, True)
    End Sub

    Private Sub DropItems(e As DragEventArgs, toInclude As Boolean)
        Dim dragObject = TryCast(e.Data.GetData(e.Data.GetFormats()(0)), MetadataDragObject)
        If dragObject IsNot Nothing Then
            If toInclude Then
                AddIncludeFilter(dragObject.MetadataStructureItems.ToArray())
            Else
                AddExcludeFilter(dragObject.MetadataStructureItems.ToArray())
            End If
        End If
    End Sub

    Private Sub lbInclude_DragOver(sender As Object, e As DragEventArgs) Handles lvInclude.DragOver
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub lbExclude_DragOver(sender As Object, e As DragEventArgs) Handles lvExclude.DragOver
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub lbExclude_DragDrop(sender As Object, e As DragEventArgs) Handles lvExclude.DragDrop
        DropItems(e, False)
    End Sub

    Private Sub databaseSchemaView1_ItemDoubleClick(sender As Object, item As MetadataStructureItem) Handles databaseSchemaView1.ItemDoubleClick
        btnAddFilter_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub cbSyntax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSyntax.SelectedIndexChanged
        If Not _connection.IsGenericConnection() Then
            Return
        End If

        Dim syntaxType = GetSelectedSyntaxType()
        If _connection.ConnectionDescriptor.SyntaxProvider.GetType() Is syntaxType Then
            Return
        End If

        _connection.ConnectionDescriptor.SyntaxProvider = CreateSyntaxProvider(syntaxType)
        _connection.SyntaxProviderName = syntaxType.ToString()

        RecreateSyntaxFrame()
    End Sub

    Private Function GetSelectedSyntaxType() As Type
        Return ActiveQueryBuilder.Core.Helpers.SyntaxProviderList(cbSyntax.SelectedIndex)
    End Function

    Private Function CreateSyntaxProvider(type As Type) As BaseSyntaxProvider
        Return TryCast(Activator.CreateInstance(type), BaseSyntaxProvider)
    End Function

    Private Sub lvInclude_KeyDown(sender As Object, e As KeyEventArgs) Handles lvInclude.KeyDown
        If e.KeyCode = Keys.Delete Then
            btnDeleteFilter_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub lvExclude_KeyDown(sender As Object, e As KeyEventArgs) Handles lvExclude.KeyDown
        If e.KeyCode = Keys.Delete Then
            btnDeleteFilter_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs)

    End Sub
End Class
