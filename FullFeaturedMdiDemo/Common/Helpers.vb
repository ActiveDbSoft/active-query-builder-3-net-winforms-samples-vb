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
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Drawing
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
		Private Const DesignTimeDpi As Integer = 96
		Private Shared _currentDPI As Integer = -1

		Private Shared Function MulDiv(number As Integer, numerator As Integer, denominator As Integer) As Integer
			Return CInt((CLng(number) * numerator) \ denominator)
		End Function

		Public Shared Function GetCurrentDPI() As Integer
			Try
				Dim graphics__1 = Graphics.FromHwnd(IntPtr.Zero)
				Dim result = CInt(Math.Truncate(graphics__1.DpiX))
				graphics__1.Dispose()

				Return result
			Catch
				Return DesignTimeDpi
			End Try
		End Function

		Public Shared Function ScaleByCurrentDPI(value As Integer) As Integer
			If _currentDPI = -1 Then
				_currentDPI = GetCurrentDPI()
			End If

			Return MulDiv(value, _currentDPI, DesignTimeDpi)
		End Function

		Public Shared Function ScaleByCurrentDPI(bounds As Rectangle) As Rectangle
			If _currentDPI = -1 Then
				_currentDPI = GetCurrentDPI()
			End If

			Return New Rectangle(MulDiv(bounds.X, _currentDPI, DesignTimeDpi), MulDiv(bounds.Y, _currentDPI, DesignTimeDpi), MulDiv(bounds.Width, _currentDPI, DesignTimeDpi), MulDiv(bounds.Height, _currentDPI, DesignTimeDpi))
		End Function

		Public Shared ReadOnly ConnectionDescriptorList As New List(Of Type)() From { _
			GetType(MSAccessConnectionDescriptor), _
			GetType(ExcelConnectionDescriptor), _
			GetType(MSSQLConnectionDescriptor), _
			GetType(MSSQLAzureConnectionDescriptor), _
			GetType(MySQLConnectionDescriptor), _
			GetType(OracleNativeConnectionDescriptor), _
			GetType(PostgreSQLConnectionDescriptor), _
			GetType(ODBCConnectionDescriptor), _
			GetType(OLEDBConnectionDescriptor), _
			GetType(SQLiteConnectionDescriptor), _
			GetType(FirebirdConnectionDescriptor) _
		}

		Public Shared ReadOnly ConnectionDescriptorNames As New List(Of String)() From { _
			"MS Access", _
			"Excel", _
			"MS SQL Server", _
			"MS SQL Server Azure", _
			"MySQL", _
			"Oracle Native", _
			"PostgreSQL", _
			"Generic ODBC Connection", _
			"Generic OLEDB Connection", _
			"SQLite", _
			"Firebird" _
		}

		Private Const AtNameParamFormat As String = "@s"
		Private Const ColonNameParamFormat As String = ":s"
		Private Const QuestionParamFormat As String = "?"
		Private Const QuestionNumberParamFormat As String = "?n"
		Private Const QuestionNameParamFormat As String = "?s"

		Public Shared Function GetAcceptableParametersFormats(metadataProvider As BaseMetadataProvider, syntaxProvider As BaseSyntaxProvider) As List(Of String)
			If TypeOf metadataProvider Is MSSQLMetadataProvider Then
				Return New List(Of String)() From { _
					AtNameParamFormat _
				}
			End If

			If TypeOf metadataProvider Is OracleNativeMetadataProvider Then
				Return New List(Of String)() From { _
					ColonNameParamFormat _
				}
			End If

			If TypeOf metadataProvider Is PostgreSQLMetadataProvider Then
				Return New List(Of String)() From { _
					ColonNameParamFormat _
				}
			End If

			If TypeOf metadataProvider Is MySQLMetadataProvider Then
				Return New List(Of String)() From { _
					AtNameParamFormat, _
					QuestionParamFormat, _
					QuestionNumberParamFormat, _
					QuestionNameParamFormat _
				}
			End If

			If TypeOf metadataProvider Is OLEDBMetadataProvider Then
				If TypeOf syntaxProvider Is MSAccessSyntaxProvider Then
					Return New List(Of String)() From { _
						AtNameParamFormat, _
						ColonNameParamFormat, _
						QuestionParamFormat _
					}
				End If

				If TypeOf syntaxProvider Is MSSQLSyntaxProvider Then
					Return New List(Of String)() From { _
						QuestionParamFormat _
					}
				End If

				If TypeOf syntaxProvider Is OracleSyntaxProvider Then
					Return New List(Of String)() From { _
						ColonNameParamFormat, _
						QuestionParamFormat, _
						QuestionNumberParamFormat _
					}
				End If

				If TypeOf syntaxProvider Is DB2SyntaxProvider Then
					Return New List(Of String)() From { _
						QuestionParamFormat _
					}
				End If
			End If

			If TypeOf metadataProvider Is ODBCMetadataProvider Then
				If TypeOf syntaxProvider Is MSAccessSyntaxProvider Then
					Return New List(Of String)() From { _
						QuestionParamFormat _
					}
				End If

				If TypeOf syntaxProvider Is MSSQLSyntaxProvider Then
					Return New List(Of String)() From { _
						QuestionParamFormat _
					}
				End If

				If TypeOf syntaxProvider Is MySQLSyntaxProvider Then
					Return New List(Of String)() From { _
						QuestionParamFormat _
					}
				End If

				If TypeOf syntaxProvider Is PostgreSQLSyntaxProvider Then
					Return New List(Of String)() From { _
						QuestionParamFormat _
					}
				End If

				If TypeOf syntaxProvider Is OracleSyntaxProvider Then
					Return New List(Of String)() From { _
						ColonNameParamFormat, _
						QuestionParamFormat, _
						QuestionNumberParamFormat _
					}
				End If

				If TypeOf syntaxProvider Is DB2SyntaxProvider Then
					Return New List(Of String)() From { _
						QuestionParamFormat _
					}
				End If
			End If

			Return New List(Of String)()
		End Function

		Public Shared Function CheckParameters(metadataProvider As BaseMetadataProvider, syntaxProvider As BaseSyntaxProvider, parameters As ParameterList) As Boolean
			Dim acceptableFormats = GetAcceptableParametersFormats(metadataProvider, syntaxProvider)

			If acceptableFormats.Count = 0 Then
				Return True
			End If

			For Each parameter As Parameter In parameters
				If Not acceptableFormats.Any(Function(x) IsSatisfiesFormat(parameter.FullName, x)) Then
					Return False
				End If
			Next

			Return True
		End Function

		Private Shared Function IsSatisfiesFormat(name As String, format As String) As Boolean
			If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(format) Then
				Return False
			End If

			If format(0) <> name(0) Then
				Return False
			End If

			Dim lastChar = format.Last()
			If lastChar = "?"C Then
				Return name = format
			End If

			If lastChar = "s"C Then
				Return name.Length > 1 AndAlso [Char].IsLetter(name(1))
			End If

			If lastChar = "n"C Then
				If name.Length = 1 Then
					Return False
				End If

				For Each c As Char In name
					If Not [Char].IsDigit(c) Then
						Return False
					End If
				Next

				Return True
			End If

			Return False
		End Function

		Public Shared Function CreateSqlCommand(sqlCommand As String, sqlQuery As SQLQuery) As DbCommand
			Dim command As DbCommand = DirectCast(sqlQuery.SQLContext.MetadataProvider.Connection.CreateCommand(), DbCommand)
			command.CommandText = sqlCommand

			' handle the query parameters
			If sqlQuery.QueryParameters.Count <= 0 Then
				Return command
			End If

			For Each p As Parameter In sqlQuery.QueryParameters.Where(Function(item) Not command.Parameters.Contains(item.FullName))
				Dim parameter = command.CreateParameter()
				parameter.ParameterName = p.FullName
				parameter.DbType = p.DataType
				command.Parameters.Add(parameter)
			Next
			Dim qpf = New QueryParametersForm(command)
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

			Dim command = CreateSqlCommand(sqlCommand, sqlQuery)

			Dim table As New DataTable("result")

			Using dbReader = command.ExecuteReader()

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

		Public Shared Sub SerializeOptions(path As String, dbView As DatabaseSchemaView, childForm As ChildForm)
			Using fileStream = New FileStream(path, FileMode.Create, FileAccess.ReadWrite)
				Using xmlBuilder = New XmlDescriptionBuilder(fileStream)
					Dim service = New OptionsSerializationService(xmlBuilder) With { _
						.SerializeDefaultValues = True _
					}
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
						Dim sqlGenerationOptionsHandle = xmlBuilder.BeginObjectProperty(root, "SqlGenerationOptions")
						If True Then
							service.EncodeObject(sqlGenerationOptionsHandle, childForm.SqlGenerationOptions)
						End If
						xmlBuilder.EndObjectProperty(sqlGenerationOptionsHandle)
					End If
					xmlBuilder.EndObject(root)
				End Using
			End Using
		End Sub

		Public Shared Sub DeserializeOptions(xml As String, dbView As DatabaseSchemaView, childForm As ChildForm)
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
