''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2024 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.IO
Imports System.Text
Imports ActiveQueryBuilder.Core.Serialization
Imports ActiveQueryBuilder.View.DatabaseSchemaView
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
    End Sub

    Public Function SerializeToString() As String
        InitializeOptionsList()

        Dim result = String.Empty
        Using stream = New MemoryStream()
            Using xmlBuilder = New XmlDescriptionBuilder(stream)
                Dim service = New OptionsSerializationService(xmlBuilder) With {.SerializeDefaultValues = True}
                XmlSerializerExtensions.Builder = xmlBuilder
                Using root = xmlBuilder.BeginObject("Options")
                    For Each [option] In _options
                        Using optionHandle = xmlBuilder.BeginObjectProperty(root, [option].GetType().Name)
                            service.EncodeObject(optionHandle, [option])
                        End Using
                    Next [option]
                End Using
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
                Using root = xmlBuilder.BeginObject("Options")
                    ' Behavior options
                    Using behaviorHandle = xmlBuilder.BeginObjectProperty(root, ActiveQueryBuilder.Core.Constants.BehaviorOptionsTag)
                        service.EncodeObject(behaviorHandle, withOptions.BehaviorOptions)
                    End Using
                    ' Database view options
                    Using dbViewOptionsHandle = xmlBuilder.BeginObjectProperty(root, ActiveQueryBuilder.Core.Constants.DatabaseSchemaViewOptionsTag)
                        service.EncodeObject(dbViewOptionsHandle, dbView.Options)
                    End Using
                    ' DesignPaneOptions
                    Using designPaneOptionsHandle = xmlBuilder.BeginObjectProperty(root, ActiveQueryBuilder.Core.Constants.DesignPaneOptionsTag)
                        service.EncodeObject(designPaneOptionsHandle, withOptions.DesignPaneOptions)
                    End Using
                    ' VisualOptions
                    Using visualOptionsHandle = xmlBuilder.BeginObjectProperty(root, ActiveQueryBuilder.Core.Constants.VisualOptionsTag)
                        service.EncodeObject(visualOptionsHandle, withOptions.VisualOptions)
                    End Using
                    ' AddObjectDialogOptions
                    Using addObjectDialogHandle = xmlBuilder.BeginObjectProperty(root, ActiveQueryBuilder.Core.Constants.AddObjectDialogOptionsTag)
                        service.EncodeObject(addObjectDialogHandle, withOptions.AddObjectDialogOptions)
                    End Using
                    ' DataSourceOptions
                    Using dataSourceOptionsHandle = xmlBuilder.BeginObjectProperty(root, "DataSourceOptions")
                        service.EncodeObject(dataSourceOptionsHandle, withOptions.DataSourceOptions)
                    End Using
                    ' MetadataLoadingOptions
                    Using metadataLoadingOptionsHandle = xmlBuilder.BeginObjectProperty(root, "MetadataLoadingOptions")
                        metadataService.Encode(metadataLoadingOptionsHandle, withOptions.MetadataLoadingOptions)
                    End Using
                    ' MetadataStructureOptions
                    Using metadataStructureOptionsHandle = xmlBuilder.BeginObjectProperty(root, "MetadataStructureOptions")
                        service.EncodeObject(metadataStructureOptionsHandle, withOptions.MetadataStructureOptions)
                    End Using
                    ' QueryColumnListOptions
                    Using queryColumnListOptionsHandle = xmlBuilder.BeginObjectProperty(root, "QueryColumnListOptions")
                        service.EncodeObject(queryColumnListOptionsHandle, withOptions.QueryColumnListOptions)
                    End Using
                    ' QueryNavBarOptions
                    Using queryNavBarOptionsHandle = xmlBuilder.BeginObjectProperty(root, "QueryNavBarOptions")
                        service.EncodeObject(queryNavBarOptionsHandle, withOptions.QueryNavBarOptions)
                    End Using
                    ' UserInterfaceOptions
                    Using userInterfaceOptionsHandle = xmlBuilder.BeginObjectProperty(root, "UserInterfaceOptions")
                        service.EncodeObject(userInterfaceOptionsHandle, withOptions.UserInterfaceOptions)
                    End Using
                    ' SqlFormattingOptions
                    Using sqlFormattingOptionsHandle = xmlBuilder.BeginObjectProperty(root, "SqlFormattingOptions")
                        service.EncodeObject(sqlFormattingOptionsHandle, withOptions.SqlFormattingOptions)
                    End Using
                    ' SqlGenerationOptions
                    Using sqlGenerationOptionsHandle = xmlBuilder.BeginObjectProperty(root, "SqlGenerationOptions")
                        service.EncodeObject(sqlGenerationOptionsHandle, withOptions.SqlGenerationOptions)
                    End Using
                End Using
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

            adapter.Reader.ReadToFollowing(ActiveQueryBuilder.Core.Constants.BehaviorOptionsTag)
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
