'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.IO
Imports System.Text
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.Serialization
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.WinForms
Imports ActiveQueryBuilder.View.DatabaseSchemaView
Imports ActiveQueryBuilder.View.WinForms.ExpressionEditor
Imports ActiveQueryBuilder.View.WinForms.QueryView
Imports ActiveQueryBuilder.View.WinForms.Serialization

Public Class Options
    Private ReadOnly DefaultTextEditorPadding As New Padding(5, 5, 0, 0)

    Public Property BehaviorOptions() As BehaviorOptions
    Public Property DatabaseSchemaViewOptions() As DatabaseSchemaViewOptions
    Public Property DesignPaneOptions() As DesignPaneOptions
    Public Property VisualOptions() As VisualOptions
    Public Property AddObjectDialogOptions() As AddObjectDialogOptions
    Public Property DataSourceOptions() As DataSourceOptions
    Public Property QueryNavBarOptions() As QueryNavBarOptions
    Public Property UserInterfaceOptions() As UserInterfaceOptions
    Public Property SqlFormattingOptions() As SQLFormattingOptions
    Public Property SqlGenerationOptions() As SQLGenerationOptions
    Public Property ExpressionEditorOptions() As ExpressionEditorOptions
    Public Property TextEditorOptions() As TextEditorOptions
    Public Property TextEditorSqlOptions() As SqlTextEditorOptions

    Private ReadOnly _options As New List(Of OptionsBase)()

    Public Sub CreateDefaultOptions()
        BehaviorOptions = New BehaviorOptions()
        DatabaseSchemaViewOptions = New DatabaseSchemaViewOptions()
        DesignPaneOptions = New DesignPaneOptions()
        VisualOptions = New VisualOptions()
        AddObjectDialogOptions = New AddObjectDialogOptions()
        DataSourceOptions = New DataSourceOptions()
        QueryNavBarOptions = New QueryNavBarOptions()
        UserInterfaceOptions = New UserInterfaceOptions()
        SqlFormattingOptions = New SQLFormattingOptions()
        SqlGenerationOptions = New SQLGenerationOptions()
        ExpressionEditorOptions = New ExpressionEditorOptions()
        TextEditorOptions = New TextEditorOptions With {.Padding = DefaultTextEditorPadding, .LineHeight = New LengthUnit(90, SizeUnitType.Percent)}
        TextEditorSqlOptions = New SqlTextEditorOptions()
    End Sub

    Private Sub InitializeOptionsList()
        _options.Clear()
        _options.Add(BehaviorOptions)
        _options.Add(DatabaseSchemaViewOptions)
        _options.Add(DesignPaneOptions)
        _options.Add(VisualOptions)
        _options.Add(AddObjectDialogOptions)
        _options.Add(DataSourceOptions)
        _options.Add(QueryNavBarOptions)
        _options.Add(UserInterfaceOptions)
        _options.Add(SqlFormattingOptions)
        _options.Add(SqlGenerationOptions)
        _options.Add(ExpressionEditorOptions)
        _options.Add(TextEditorOptions)
        _options.Add(TextEditorSqlOptions)
    End Sub

    Public Function SerializeToString() As String
        InitializeOptionsList()

        Dim result = String.Empty
        Using stream = New MemoryStream()
            Using xmlBuilder = New XmlDescriptionBuilder(stream)
                Dim service = New OptionsSerializationService(xmlBuilder) With {.SerializeDefaultValues = True}
                XmlSerializerExtensions.Builder = xmlBuilder
                Dim root = xmlBuilder.BeginObject("Options")
                For Each [option] In _options
                    Dim optionHandle = xmlBuilder.BeginObjectProperty(root, [option].GetType().Name)
                    service.EncodeObject(optionHandle, [option])
                    xmlBuilder.EndObjectProperty(optionHandle)
                Next [option]
                xmlBuilder.EndObject(root)
            End Using

            stream.Position = 0
            Using reader = New StreamReader(stream)
                result = reader.ReadToEnd()
            End Using
        End Using

        Return result
    End Function

    Public Sub SerializeToFile(path As String)
        InitializeOptionsList()

        File.WriteAllText(path, SerializeToString())
    End Sub

    Public Sub DeserializeFromFile(path As String)
        InitializeOptionsList()

        DeserializeFromString(File.ReadAllText(path))
    End Sub

    Public Sub DeserializeFromString(xml As String)
        InitializeOptionsList()

        Dim buffer = Encoding.UTF8.GetBytes(xml)
        Using memoryStream = New MemoryStream(buffer)
            Dim adapter = New XmlAdapter(memoryStream)
            Dim service = New OptionsDeserializationService(adapter)
            XmlSerializerExtensions.Adapter = adapter

            adapter.Reader.ReadToFollowing(_options(0).GetType().Name)

            For Each [option] In _options
                Dim optionTree = adapter.Reader.ReadSubtree()
                optionTree.Read()
                service.DecodeObject(optionTree, [option])
                optionTree.Close()
                adapter.Reader.Read()
            Next [option]
        End Using
    End Sub

    Public Shared Sub SerializeOptions(path As String, dbView As IDatabaseSchemaView, withOptions As ISupportOptions)
        Using fileStream = New FileStream(path, FileMode.Create, FileAccess.ReadWrite)
            Using xmlBuilder = New XmlDescriptionBuilder(fileStream)
                Dim service = New OptionsSerializationService(xmlBuilder) With {.SerializeDefaultValues = True}
                Dim metadataService = New MetadataSerializationService(xmlBuilder)
                XmlSerializerExtensions.Builder = xmlBuilder
                Dim root = xmlBuilder.BeginObject("Options")
                ' Behavior options
                Dim behaviorHandle = xmlBuilder.BeginObjectProperty(root, Constants.BehaviorOptionsTag)
                service.EncodeObject(behaviorHandle, withOptions.BehaviorOptions)
                xmlBuilder.EndObjectProperty(behaviorHandle)
                ' Database view options
                Dim dbViewOptionsHandle = xmlBuilder.BeginObjectProperty(root, Constants.DatabaseSchemaViewOptionsTag)
                service.EncodeObject(dbViewOptionsHandle, dbView.Options)
                xmlBuilder.EndObjectProperty(dbViewOptionsHandle)
                ' DesignPaneOptions
                Dim designPaneOptionsHandle = xmlBuilder.BeginObjectProperty(root, Constants.DesignPaneOptionsTag)
                service.EncodeObject(designPaneOptionsHandle, withOptions.DesignPaneOptions)
                xmlBuilder.EndObjectProperty(designPaneOptionsHandle)
                ' VisualOptions
                Dim visualOptionsHandle = xmlBuilder.BeginObjectProperty(root, Constants.VisualOptionsTag)
                service.EncodeObject(visualOptionsHandle, withOptions.VisualOptions)
                xmlBuilder.EndObjectProperty(visualOptionsHandle)
                ' AddObjectDialogOptions
                Dim addObjectDialogHandle = xmlBuilder.BeginObjectProperty(root, Constants.AddObjectDialogOptionsTag)
                service.EncodeObject(addObjectDialogHandle, withOptions.AddObjectDialogOptions)
                xmlBuilder.EndObjectProperty(addObjectDialogHandle)
                ' DataSourceOptions
                Dim dataSourceOptionsHandle = xmlBuilder.BeginObjectProperty(root, "DataSourceOptions")
                service.EncodeObject(dataSourceOptionsHandle, withOptions.DataSourceOptions)
                xmlBuilder.EndObjectProperty(dataSourceOptionsHandle)
                ' MetadataLoadingOptions
                Dim metadataLoadingOptionsHandle = xmlBuilder.BeginObjectProperty(root, "MetadataLoadingOptions")
                metadataService.Encode(metadataLoadingOptionsHandle, withOptions.MetadataLoadingOptions)
                xmlBuilder.EndObjectProperty(metadataLoadingOptionsHandle)
                ' MetadataStructureOptions
                Dim metadataStructureOptionsHandle = xmlBuilder.BeginObjectProperty(root, "MetadataStructureOptions")
                service.EncodeObject(metadataStructureOptionsHandle, withOptions.MetadataStructureOptions)
                xmlBuilder.EndObjectProperty(metadataStructureOptionsHandle)
                ' QueryColumnListOptions
                Dim queryColumnListOptionsHandle = xmlBuilder.BeginObjectProperty(root, "QueryColumnListOptions")
                service.EncodeObject(queryColumnListOptionsHandle, withOptions.QueryColumnListOptions)
                xmlBuilder.EndObjectProperty(queryColumnListOptionsHandle)
                ' QueryNavBarOptions
                Dim queryNavBarOptionsHandle = xmlBuilder.BeginObjectProperty(root, "QueryNavBarOptions")
                service.EncodeObject(queryNavBarOptionsHandle, withOptions.QueryNavBarOptions)
                xmlBuilder.EndObjectProperty(queryNavBarOptionsHandle)
                ' UserInterfaceOptions
                Dim userInterfaceOptionsHandle = xmlBuilder.BeginObjectProperty(root, "UserInterfaceOptions")
                service.EncodeObject(userInterfaceOptionsHandle, withOptions.UserInterfaceOptions)
                xmlBuilder.EndObjectProperty(userInterfaceOptionsHandle)
                ' SqlFormattingOptions
                Dim sqlFormattingOptionsHandle = xmlBuilder.BeginObjectProperty(root, "SqlFormattingOptions")
                service.EncodeObject(sqlFormattingOptionsHandle, withOptions.SqlFormattingOptions)
                xmlBuilder.EndObjectProperty(sqlFormattingOptionsHandle)
                ' SqlGenerationOptions
                Dim sqlGenerationOptionsHandle = xmlBuilder.BeginObjectProperty(root, "SqlGenerationOptions")
                service.EncodeObject(sqlGenerationOptionsHandle, withOptions.SqlGenerationOptions)
                xmlBuilder.EndObjectProperty(sqlGenerationOptionsHandle)
                xmlBuilder.EndObject(root)
            End Using
        End Using
    End Sub

    Public Shared Sub DeserializeOptions(xml As String, dbView As IDatabaseSchemaView, withOptions As ISupportOptions)
        Dim buffer = Encoding.UTF8.GetBytes(xml)
        Using memoryStream = New MemoryStream(buffer)
            Dim adapter = New XmlAdapter(memoryStream)
            Dim service = New OptionsDeserializationService(adapter)
            XmlSerializerExtensions.Adapter = adapter

            Dim metadataService = New MetadataDeserializationService(adapter)

            adapter.Reader.ReadToFollowing(Constants.BehaviorOptionsTag)
            Dim behaviorOptionsTree = adapter.Reader.ReadSubtree()
            behaviorOptionsTree.Read()
            service.DecodeObject(behaviorOptionsTree, withOptions.BehaviorOptions)
            behaviorOptionsTree.Close()
            adapter.Reader.Read()

            Dim dbViewOptionsTree = adapter.Reader.ReadSubtree()
            dbViewOptionsTree.Read()
            service.DecodeObject(dbViewOptionsTree, dbView.Options)
            dbViewOptionsTree.Close()
            adapter.Reader.Read()

            Dim designPaneOptionsTree = adapter.Reader.ReadSubtree()
            designPaneOptionsTree.Read()
            service.DecodeObject(designPaneOptionsTree, withOptions.DesignPaneOptions)
            designPaneOptionsTree.Close()
            adapter.Reader.Read()

            Dim visualOptionsTree = adapter.Reader.ReadSubtree()
            visualOptionsTree.Read()
            service.DecodeObject(visualOptionsTree, withOptions.VisualOptions)
            visualOptionsTree.Close()
            adapter.Reader.Read()

            Dim addObjectDialogOptionsTree = adapter.Reader.ReadSubtree()
            addObjectDialogOptionsTree.Read()
            service.DecodeObject(addObjectDialogOptionsTree, withOptions.AddObjectDialogOptions)
            addObjectDialogOptionsTree.Close()
            adapter.Reader.Read()

            Dim dataSourceOptionsTree = adapter.Reader.ReadSubtree()
            dataSourceOptionsTree.Read()
            service.DecodeObject(dataSourceOptionsTree, withOptions.DataSourceOptions)
            dataSourceOptionsTree.Close()
            adapter.Reader.Read()

            Dim metadataLoadingOptionsTree = adapter.Reader.ReadSubtree()
            metadataLoadingOptionsTree.Read()
            metadataService.DecodeMetadataLoadingOptions(metadataLoadingOptionsTree, withOptions.MetadataLoadingOptions)
            metadataLoadingOptionsTree.Close()
            adapter.Reader.Read()

            Dim metadataStructureOptionsTree = adapter.Reader.ReadSubtree()
            metadataStructureOptionsTree.Read()
            service.DecodeObject(metadataStructureOptionsTree, withOptions.MetadataStructureOptions)
            metadataStructureOptionsTree.Close()
            adapter.Reader.Read()

            Dim queryColumnListTree = adapter.Reader.ReadSubtree()
            queryColumnListTree.Read()
            service.DecodeObject(queryColumnListTree, withOptions.QueryColumnListOptions)
            queryColumnListTree.Close()
            adapter.Reader.Read()

            Dim queryNavBarTree = adapter.Reader.ReadSubtree()
            queryNavBarTree.Read()
            service.DecodeObject(queryNavBarTree, withOptions.QueryNavBarOptions)
            queryNavBarTree.Close()
            adapter.Reader.Read()

            Dim userInterfaceOptionsTree = adapter.Reader.ReadSubtree()
            userInterfaceOptionsTree.Read()
            service.DecodeObject(userInterfaceOptionsTree, withOptions.UserInterfaceOptions)
            userInterfaceOptionsTree.Close()
            adapter.Reader.Read()

            Dim sqlFormattingOptionsTree = adapter.Reader.ReadSubtree()
            sqlFormattingOptionsTree.Read()
            service.DecodeObject(sqlFormattingOptionsTree, withOptions.SqlFormattingOptions)
            sqlFormattingOptionsTree.Close()
            adapter.Reader.Read()

            Dim sqlGenerationOptionsTree = adapter.Reader.ReadSubtree()
            sqlGenerationOptionsTree.Read()
            service.DecodeObject(sqlGenerationOptionsTree, withOptions.SqlGenerationOptions)
            sqlGenerationOptionsTree.Close()
            adapter.Reader.Read()
        End Using
    End Sub
End Class
