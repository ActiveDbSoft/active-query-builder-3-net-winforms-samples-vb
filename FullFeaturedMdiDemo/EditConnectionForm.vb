'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.PropertiesEditors
Imports ActiveQueryBuilder.Core.Serialization
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.PropertiesEditors
Imports ActiveQueryBuilder.View.WinForms.Images
Imports Helpers = ActiveQueryBuilder.Core.Helpers

Public Partial Class EditConnectionForm
	Inherits Form
	Private ReadOnly _connection As ConnectionInfo
	Private _isFilterPageInitialized As Boolean

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(connection As ConnectionInfo)
		Me.New()
		lbMenu.SelectedIndex = 0
		_connection = connection
		tbConnectionName.Text = connection.Name

		FillConnectionTypes()
		FillSyntaxTypes()

		cbConnectionType.SelectedItem = _connection.ConnectionDescriptor.GetDescription()
		UpdateConnectionPropertiesFrames()
		cbLoadFromDefaultDatabase.Visible = _connection.ConnectionDescriptor.SyntaxProvider.IsSupportDatabases()
		cbLoadFromDefaultDatabase.Checked = _connection.ConnectionDescriptor.MetadataLoadingOptions.LoadDefaultDatabaseOnly

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
		For Each syntax As Type In Helpers.SyntaxProviderList
			Dim instance = TryCast(Activator.CreateInstance(syntax), BaseSyntaxProvider)
			cbSyntax.Items.Add(instance.Description)
		Next
	End Sub

	Private Sub FillConnectionTypes()
		For Each descriptor As String In Misc.ConnectionDescriptorNames
			cbConnectionType.Items.Add(descriptor)
		Next
	End Sub

	Private Sub tbConnectionName_TextChanged(sender As Object, e As EventArgs)
		_connection.Name = tbConnectionName.Text
	End Sub

	Private Sub cbConnectionType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
	    Dim descriptorType = GetSelectedDescriptorType()

	    If _connection.ConnectionDescriptor IsNot Nothing AndAlso _connection.ConnectionDescriptor.[GetType]() Is descriptorType Then
	        Return
	    End If

	    _connection.ConnectionDescriptor = CreateConnectionDescriptor(descriptorType)

	    If _connection Is Nothing Then
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
	    cbLoadFromDefaultDatabase.Visible = False
	    RemoveConnectionPropertiesFrame()
	    RemoveSyntaxFrame()
	End Sub

	Private Sub UnlockUI()
	    lbMenu.Enabled = True
	    btnOk.Enabled = True
	    cbLoadFromDefaultDatabase.Visible = True
	End Sub

	Private Sub UpdateConnectionPropertiesFrames()
		SetupSyntaxCombobox()
		RecreateConnectionFrame()
		RecreateSyntaxFrame()
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
	    Return Misc.ConnectionDescriptorList(cbConnectionType.SelectedIndex)
	End Function

	Private Function CreateConnectionDescriptor(ByVal type As Type) As BaseConnectionDescriptor
	    Try
	        Return TryCast(Activator.CreateInstance(type), BaseConnectionDescriptor)
	    Catch e As Exception
	        Dim message as String = If(e.InnerException IsNot Nothing, e.InnerException.Message, e.Message)
	        MessageBox.Show(message & vbcrlf & "To fix this error you may need to install the appropriate database client software or 
                                       re-compile the project from sources and add the needed assemblies to the References section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
	        Return Nothing
	    End Try
	End Function

	Private Sub RecreateConnectionFrame()
		RemoveConnectionPropertiesFrame()
		ClearProperties(_connection.ConnectionDescriptor.MetadataProperties)
		Dim container = PropertiesFactory.GetPropertiesContainer(_connection.ConnectionDescriptor.MetadataProperties)
		TryCast(pbConnection, IPropertiesControl).SetProperties(container)
		cbLoadFromDefaultDatabase.Top = pbConnection.Controls(0).Bottom + 5
	End Sub

	Private Sub ClearProperties(properties As ObjectProperties)
		properties.GroupProperties.Clear()
		properties.PropertiesEditors.Clear()
	End Sub

	Private Sub RemoveConnectionPropertiesFrame()
		Dim container = TryCast(pbConnection.Controls.OfType(Of IPropertiesContainer)().FirstOrDefault(), Control)
		If container IsNot Nothing Then
			pbConnection.Controls.Remove(container)
		End If
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

		cbLoadFromDefaultDatabase.Visible = _connection.ConnectionDescriptor.SyntaxProvider.IsSupportDatabases()
		pbSyntax.Height = pbSyntax.Controls(0).Bottom + 5
	End Sub

	Private Sub RemoveSyntaxFrame()
		pbSyntax.Controls.Clear()
	End Sub

	Private Sub lbMenu_SelectedIndexChanged(sender As Object, e As EventArgs)
		Select Case lbMenu.SelectedIndex
			Case 0
				tcProperties.SelectedTab = tpConnection
				Exit Select
			Case 1
				InitializeFilterPage()
				Exit Select
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
				Cursor = Cursors.[Default]
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
		For Each filterObject As string In filter.Objects
			Dim item = FindItemByName(filterObject)
			listBox.Items.Add(filterObject, filterObject, GetImageKeyByItem(item))
		Next

		For Each filterSchema As string In filter.Schemas
			Dim item = FindItemByName(filterSchema)
			listBox.Items.Add(filterSchema, filterSchema, GetImageKeyByItem(item))
		Next
	End Sub

	Private Function FindItemByName(name As String) As MetadataItem
		Return databaseSchemaView1.MetadataStructure.MetadataItem.FindItem(Of MetadataItem)(name)
	End Function

	Private Sub cbLoadFromDefaultDatabase_CheckedChanged(sender As Object, e As EventArgs)
		_connection.ConnectionDescriptor.MetadataLoadingOptions.LoadDefaultDatabaseOnly = cbLoadFromDefaultDatabase.Checked
	End Sub

	Private Sub btnAddFilter_Click(sender As Object, e As EventArgs)
		If tcFilters.SelectedTab Is tpInclude Then
			AddIncludeFilter(databaseSchemaView1.SelectedItems)
		ElseIf tcFilters.SelectedTab Is tpExclude Then
			AddExcludeFilter(databaseSchemaView1.SelectedItems)
		End If
	End Sub

	Private Sub AddIncludeFilter(items As MetadataStructureItem())
		Dim filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.IncludeFilter
		For Each structureItem As MetadataStructureItem In items
			Dim metadataItem = structureItem.MetadataItem
			If metadataItem Is Nothing Then
				Continue For
			End If

			If metadataItem.Type.IsNamespace() Then
				filter.Schemas.Add(metadataItem.NameFull)
				lvInclude.Items.Add(metadataItem.NameFull, metadataItem.NameFull, GetImageKeyByItem(metadataItem))
			ElseIf metadataItem.Type.IsObject() Then
				filter.Objects.Add(metadataItem.NameFull)
				lvInclude.Items.Add(metadataItem.NameFull, metadataItem.NameFull, GetImageKeyByItem(metadataItem))
			End If
		Next
	End Sub

	Private Sub AddExcludeFilter(items As MetadataStructureItem())
		Dim filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.ExcludeFilter
		For Each structureItem As MetadataStructureItem In items
			Dim metadataItem = structureItem.MetadataItem
			If metadataItem Is Nothing Then
				Continue For
			End If

			If metadataItem.Type.IsNamespace() Then
				filter.Schemas.Add(metadataItem.NameFull)
				lvExclude.Items.Add(metadataItem.NameFull, GetImageKeyByItem(metadataItem))
			ElseIf metadataItem.Type.IsObject() Then
				filter.Objects.Add(metadataItem.NameFull)
				lvExclude.Items.Add(metadataItem.NameFull, GetImageKeyByItem(metadataItem))
			End If
		Next
	End Sub

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

	Private Sub btnDeleteFilter_Click(sender As Object, e As EventArgs)
		If tcFilters.SelectedTab Is tpInclude Then
			For Each selectedItem As ListViewItem In lvInclude.SelectedItems
				DeleteFilter(selectedItem.Text)
			Next
		ElseIf tcFilters.SelectedTab Is tpExclude Then
			For Each selectedItem As ListViewItem In lvExclude.SelectedItems
				DeleteFilter(selectedItem.Text)
			Next
		End If
	End Sub

	Private Sub DeleteFilter(itemName As String)
		Dim filter As MetadataSimpleFilter = Nothing
		If tcFilters.SelectedTab Is tpInclude Then
			filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.IncludeFilter
		ElseIf tcFilters.SelectedTab Is tpExclude Then
			filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.ExcludeFilter
		End If

		If filter IsNot Nothing Then
			filter.Objects.Remove(itemName)
			filter.Schemas.Remove(itemName)
		End If

		If tcFilters.SelectedTab Is tpInclude Then
			Dim items = lvInclude.Items.Find(itemName, False)
			If items.Length <> 0 Then
				lvInclude.Items.Remove(items(0))
			End If
		ElseIf tcFilters.SelectedTab Is tpExclude Then
			Dim items = lvExclude.Items.Find(itemName, False)
			If items.Length <> 0 Then
				lvExclude.Items.Remove(items(0))
			End If
		End If
	End Sub

	Private Sub lbInclude_DragDrop(sender As Object, e As DragEventArgs)
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

	Private Sub lbInclude_DragOver(sender As Object, e As DragEventArgs)
		e.Effect = DragDropEffects.All
	End Sub

	Private Sub lbExclude_DragOver(sender As Object, e As DragEventArgs)
		e.Effect = DragDropEffects.All
	End Sub

	Private Sub lbExclude_DragDrop(sender As Object, e As DragEventArgs)
		DropItems(e, False)
	End Sub

	Private Sub databaseSchemaView1_ItemDoubleClick(sender As Object, item As MetadataStructureItem)
		btnAddFilter_Click(Me, EventArgs.Empty)
	End Sub

	Private Sub cbSyntax_SelectedIndexChanged(sender As Object, e As EventArgs)
		If Not _connection.IsGenericConnection() Then
			Return
		End If

		Dim syntaxType = GetSelectedSyntaxType()
		If _connection.ConnectionDescriptor.SyntaxProvider.[GetType]() Is syntaxType Then
			Return
		End If

		_connection.ConnectionDescriptor.SyntaxProvider = CreateSyntaxProvider(syntaxType)
		_connection.SyntaxProviderName = syntaxType.ToString()

		RecreateSyntaxFrame()
	End Sub

	Private Function GetSelectedSyntaxType() As Type
		Return Helpers.SyntaxProviderList(cbSyntax.SelectedIndex)
	End Function

	Private Function CreateSyntaxProvider(type As Type) As BaseSyntaxProvider
		Return TryCast(Activator.CreateInstance(type), BaseSyntaxProvider)
	End Function
End Class
