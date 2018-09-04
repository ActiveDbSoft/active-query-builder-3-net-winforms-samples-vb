'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports System.Text
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.Serialization
Imports ActiveQueryBuilder.View.WinForms.DatabaseSchemaView
Imports ActiveQueryBuilder.View.WinForms.Serialization

Namespace Common
    Public NotInheritable Class Helpers
        Private Sub New()
        End Sub
        Public Shared Function CreateSqlCommand(sqlCommand As String, sqlQuery As SQLQuery) As DbCommand
            Dim command As DbCommand = DirectCast(sqlQuery.SQLContext.MetadataProvider.Connection.CreateCommand(), DbCommand)
            command.CommandText = sqlCommand

            ' handle the query parameters
            If sqlQuery.QueryParameters.Count <= 0 Then
                Return command
            End If

            For Each p As Parameter In sqlQuery.QueryParameters.Where(Function(item) Not command.Parameters.Contains(item.FullName))
                Dim parameter As New SqlParameter() With {
                    .ParameterName = p.FullName,
                    .DbType = p.DataType
                }
                command.Parameters.Add(parameter)
            Next
            Dim qpf As QueryParametersForm = New QueryParametersForm(command)
            qpf.ShowDialog()
            Return command
        End Function

        Public Shared Function ExecuteSql(sqlCommand As String, sqlQuery As SQLQuery) As DataTable
            If String.IsNullOrEmpty(sqlCommand) Then
                Return Nothing
            End If

            If sqlQuery.SQLContext.MetadataProvider Is Nothing Then
                Return Nothing
            End If

            If Not sqlQuery.SQLContext.MetadataProvider.Connected Then
                sqlQuery.SQLContext.MetadataProvider.Connect()
            End If

            If String.IsNullOrEmpty(sqlCommand) Then
                Return Nothing
            End If

            If Not sqlQuery.SQLContext.MetadataProvider.Connected Then
                sqlQuery.SQLContext.MetadataProvider.Connect()
            End If

            Dim command As DbCommand = CreateSqlCommand(sqlCommand, sqlQuery)

            Dim table As New DataTable("result")

            Using dbReader As DbDataReader = command.ExecuteReader()

                For i As Integer = 0 To dbReader.FieldCount - 1
                    table.Columns.Add(dbReader.GetName(i))
                Next

                While dbReader.Read()
                    Dim values As Object() = New Object(dbReader.FieldCount - 1) {}
                    dbReader.GetValues(values)
                    table.Rows.Add(values)
                End While

                Return table
            End Using
        End Function

        Public Shared Sub SerializeOptions(ByVal path As String, ByVal dbView As DatabaseSchemaView, ByVal childForm As ChildForm)
			Using fileStream = New FileStream(path, FileMode.Create, FileAccess.ReadWrite)
			Using xmlBuilder = New XmlDescriptionBuilder(fileStream)
				Dim service = New OptionsSerializationService(xmlBuilder) With {.SerializeDefaultValues = True}
				Dim metadataService = New MetadataSerializationService(xmlBuilder)
				XmlSerializerExtensions.Builder = xmlBuilder
				Dim root = xmlBuilder.BeginObject("Options")
				If True Then
					' Behavior options
					Dim behaviorHandle = xmlBuilder.BeginObjectProperty(root, Constants.BehaviorOptionsTag)
					If True Then
						service.EncodeObject(behaviorHandle, childForm.BehaviorOptions)
					End If
					xmlBuilder.EndObjectProperty(behaviorHandle)
					' Database view options
					Dim dbViewOptionsHandle = xmlBuilder.BeginObjectProperty(root, Constants.DatabaseSchemaViewOptionsTag)
					If True Then
						service.EncodeObject(dbViewOptionsHandle, dbView.Options)
					End If
					xmlBuilder.EndObjectProperty(dbViewOptionsHandle)
					' DesignPaneOptions
					Dim designPaneOptionsHandle = xmlBuilder.BeginObjectProperty(root, Constants.DesignPaneOptionsTag)
					If True Then
						service.EncodeObject(designPaneOptionsHandle, childForm.DesignPaneOptions)
					End If
					xmlBuilder.EndObjectProperty(designPaneOptionsHandle)
					' VisualOptions
					Dim visualOptionsHandle = xmlBuilder.BeginObjectProperty(root, Constants.VisualOptionsTag)
					If True Then
						service.EncodeObject(visualOptionsHandle, childForm.VisualOptions)
					End If
					xmlBuilder.EndObjectProperty(visualOptionsHandle)
					' AddObjectDialogOptions
					Dim addObjectDialogHandle = xmlBuilder.BeginObjectProperty(root, Constants.AddObjectDialogOptionsTag)
					If True Then
						service.EncodeObject(addObjectDialogHandle, childForm.AddObjectDialogOptions)
					End If
					xmlBuilder.EndObjectProperty(addObjectDialogHandle)
					' DataSourceOptions
					Dim dataSourceOptionsHandle = xmlBuilder.BeginObjectProperty(root, "DataSourceOptions")
					If True Then
						service.EncodeObject(dataSourceOptionsHandle, childForm.DataSourceOptions)
					End If
					xmlBuilder.EndObjectProperty(dataSourceOptionsHandle)
					' MetadataLoadingOptions
					Dim metadataLoadingOptionsHandle = xmlBuilder.BeginObjectProperty(root, "MetadataLoadingOptions")
					If True Then
						metadataService.Encode(metadataLoadingOptionsHandle, childForm.MetadataLoadingOptions)
					End If
					xmlBuilder.EndObjectProperty(metadataLoadingOptionsHandle)
					' MetadataStructureOptions
					Dim metadataStructureOptionsHandle = xmlBuilder.BeginObjectProperty(root, "MetadataStructureOptions")
					If True Then
						service.EncodeObject(metadataStructureOptionsHandle, childForm.MetadataStructureOptions)
					End If
					xmlBuilder.EndObjectProperty(metadataStructureOptionsHandle)
					' QueryColumnListOptions
					Dim queryColumnListOptionsHandle = xmlBuilder.BeginObjectProperty(root, "QueryColumnListOptions")
					If True Then
						service.EncodeObject(queryColumnListOptionsHandle, childForm.QueryColumnListOptions)
					End If
					xmlBuilder.EndObjectProperty(queryColumnListOptionsHandle)
					' QueryNavBarOptions
					Dim queryNavBarOptionsHandle = xmlBuilder.BeginObjectProperty(root, "QueryNavBarOptions")
					If True Then
						service.EncodeObject(queryNavBarOptionsHandle, childForm.QueryNavBarOptions)
					End If
					xmlBuilder.EndObjectProperty(queryNavBarOptionsHandle)
					' UserInterfaceOptions
					Dim userInterfaceOptionsHandle = xmlBuilder.BeginObjectProperty(root, "UserInterfaceOptions")
					If True Then
						service.EncodeObject(userInterfaceOptionsHandle, childForm.UserInterfaceOptions)
					End If
					xmlBuilder.EndObjectProperty(userInterfaceOptionsHandle)
					' SqlFormattingOptions
					Dim sqlFormattingOptionsHandle = xmlBuilder.BeginObjectProperty(root, "SqlFormattingOptions")
					If True Then
						service.EncodeObject(sqlFormattingOptionsHandle, childForm.SqlFormattingOptions)
					End If
					xmlBuilder.EndObjectProperty(sqlFormattingOptionsHandle)
					' SqlGenerationOptions
					Dim sqlGenerationOptionsHandle As Object = xmlBuilder.BeginObjectProperty(root, "SqlGenerationOptions")
					If True Then
						service.EncodeObject(sqlGenerationOptionsHandle, childForm.SqlGenerationOptions)
					End If
					xmlBuilder.EndObjectProperty(sqlGenerationOptionsHandle)
				End If
				xmlBuilder.EndObject(root)
			End Using
			End Using
		End Sub
        Public Shared Sub DeserializeOptions(ByVal xml As String, ByVal dbView As DatabaseSchemaView, ByVal childForm As ChildForm)
			Dim buffer As Byte() = Encoding.UTF8.GetBytes(xml)
			Using memoryStream = New MemoryStream(buffer)
				Dim adapter = New XmlAdapter(memoryStream)
				Dim service = New OptionsDeserializationService(adapter)
				XmlSerializerExtensions.Adapter = adapter

				Dim metadataService = New MetadataDeserializationService(adapter)

				adapter.Reader.ReadToFollowing(Constants.BehaviorOptionsTag)
				Dim behaviorOptionsTree = adapter.Reader.ReadSubtree()
				behaviorOptionsTree.Read()
				service.DecodeObject(behaviorOptionsTree, childForm.BehaviorOptions)
				behaviorOptionsTree.Close()
				adapter.Reader.Read()

				Dim dbViewOptionsTree = adapter.Reader.ReadSubtree()
				dbViewOptionsTree.Read()
				service.DecodeObject(dbViewOptionsTree, dbView.Options)
				dbViewOptionsTree.Close()
				adapter.Reader.Read()

				Dim designPaneOptionsTree = adapter.Reader.ReadSubtree()
				designPaneOptionsTree.Read()
				service.DecodeObject(designPaneOptionsTree, childForm.DesignPaneOptions)
				designPaneOptionsTree.Close()
				adapter.Reader.Read()

				Dim visualOptionsTree = adapter.Reader.ReadSubtree()
				visualOptionsTree.Read()
				service.DecodeObject(visualOptionsTree, childForm.VisualOptions)
				visualOptionsTree.Close()
				adapter.Reader.Read()

				Dim addObjectDialogOptionsTree = adapter.Reader.ReadSubtree()
				addObjectDialogOptionsTree.Read()
				service.DecodeObject(addObjectDialogOptionsTree, childForm.AddObjectDialogOptions)
				addObjectDialogOptionsTree.Close()
				adapter.Reader.Read()

				Dim dataSourceOptionsTree = adapter.Reader.ReadSubtree()
				dataSourceOptionsTree.Read()
				service.DecodeObject(dataSourceOptionsTree, childForm.DataSourceOptions)
				dataSourceOptionsTree.Close()
				adapter.Reader.Read()

				Dim metadataLoadingOptionsTree = adapter.Reader.ReadSubtree()
				metadataLoadingOptionsTree.Read()
				metadataService.DecodeMetadataLoadingOptions(metadataLoadingOptionsTree, childForm.MetadataLoadingOptions)
				metadataLoadingOptionsTree.Close()
				adapter.Reader.Read()

				Dim metadataStructureOptionsTree = adapter.Reader.ReadSubtree()
				metadataStructureOptionsTree.Read()
				service.DecodeObject(metadataStructureOptionsTree, childForm.MetadataStructureOptions)
				metadataStructureOptionsTree.Close()
				adapter.Reader.Read()

				Dim queryColumnListTree = adapter.Reader.ReadSubtree()
				queryColumnListTree.Read()
				service.DecodeObject(queryColumnListTree, childForm.QueryColumnListOptions)
				queryColumnListTree.Close()
				adapter.Reader.Read()

				Dim queryNavBarTree = adapter.Reader.ReadSubtree()
				queryNavBarTree.Read()
				service.DecodeObject(queryNavBarTree, childForm.QueryNavBarOptions)
				queryNavBarTree.Close()
				adapter.Reader.Read()

				Dim userInterfaceOptionsTree = adapter.Reader.ReadSubtree()
				userInterfaceOptionsTree.Read()
				service.DecodeObject(userInterfaceOptionsTree, childForm.UserInterfaceOptions)
				userInterfaceOptionsTree.Close()
				adapter.Reader.Read()

				Dim sqlFormattingOptionsTree = adapter.Reader.ReadSubtree()
				sqlFormattingOptionsTree.Read()
				service.DecodeObject(sqlFormattingOptionsTree, childForm.SqlFormattingOptions)
				sqlFormattingOptionsTree.Close()
				adapter.Reader.Read()

				Dim sqlGenerationOptionsTree = adapter.Reader.ReadSubtree()
				sqlGenerationOptionsTree.Read()
				service.DecodeObject(sqlGenerationOptionsTree, childForm.SqlGenerationOptions)
				sqlGenerationOptionsTree.Close()
				adapter.Reader.Read()
			End Using
		End Sub
    End Class
End Namespace
