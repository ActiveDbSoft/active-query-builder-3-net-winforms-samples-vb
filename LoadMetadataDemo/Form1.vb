'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

'*******************************************************************************
'This sample demonstrates loading of metadata if the standard way (see GeneralDemo)
'is not suitable for some reason.
'********************************************************************


Imports System.Data
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Data.OracleClient
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms

Public Partial Class Form1
	Inherits Form
	Private dbConnection As IDbConnection

	Public Sub New()
		InitializeComponent()
	End Sub

	'''///////////////////////////////////////////////////////////////////////
	''' 1st way:
	''' This method demonstrates the direct access to the internal metadata 
	''' objects collection (MetadataContainer).
	'''///////////////////////////////////////////////////////////////////////
	Private Sub btn1Way_Click(sender As Object, e As EventArgs)
		' prevent QueryBuilder to request metadata
		queryBuilder1.MetadataLoadingOptions.OfflineMode = True

		queryBuilder1.MetadataProvider = Nothing

		Dim metadataContainer As MetadataContainer = queryBuilder1.MetadataContainer
		metadataContainer.BeginUpdate()

		Try
			metadataContainer.Clear()

			Dim schemaDbo As MetadataNamespace = metadataContainer.AddSchema("dbo")

			' prepare metadata for table "Orders"
			Dim orders As MetadataObject = schemaDbo.AddTable("Orders")
			' fields
			orders.AddField("OrderId")
			orders.AddField("CustomerId")

			' prepare metadata for table "Order Details"
			Dim orderDetails As MetadataObject = schemaDbo.AddTable("Order Details")
			' fields
			orderDetails.AddField("OrderId")
			orderDetails.AddField("ProductId")
			' foreign keys
			Dim foreignKey As MetadataForeignKey = orderDetails.AddForeignKey("OrderDetailsToOrders")

			Using referencedName As New MetadataQualifiedName()
				referencedName.Add("Orders")
				referencedName.Add("dbo")

				foreignKey.ReferencedObjectName = referencedName
			End Using

			foreignKey.Fields.Add("OrderId")
			foreignKey.ReferencedFields.Add("OrderId")
		Finally
			metadataContainer.EndUpdate()
		End Try

		queryBuilder1.InitializeDatabaseSchemaTree()
	End Sub

	'''///////////////////////////////////////////////////////////////////////
	''' 2rd way:
	''' This method demonstrates on-demand manual filling of metadata structure using 
	''' corresponding MetadataContainer.ItemMetadataLoading event
	'''///////////////////////////////////////////////////////////////////////
	Private Sub btn2Way_Click(sender As Object, e As EventArgs)
		' allow QueryBuilder to request metadata
		queryBuilder1.MetadataLoadingOptions.OfflineMode = False

		queryBuilder1.MetadataProvider = Nothing
		AddHandler queryBuilder1.MetadataContainer.ItemMetadataLoading, AddressOf way2ItemMetadataLoading
		queryBuilder1.InitializeDatabaseSchemaTree()
	End Sub

	Private Sub way2ItemMetadataLoading(sender As Object, item As MetadataItem, types As MetadataType)
		Select Case item.Type
			Case MetadataType.Root
				If (types And MetadataType.Schema) > 0 Then
					item.AddSchema("dbo")
				End If
				Exit Select

			Case MetadataType.Schema
				If (item.Name = "dbo") AndAlso (types And MetadataType.Table) > 0 Then
					item.AddTable("Orders")
					item.AddTable("Order Details")
				End If
				Exit Select

			Case MetadataType.Table
				If item.Name = "Orders" Then
					If (types And MetadataType.Field) > 0 Then
						item.AddField("OrderId")
						item.AddField("CustomerId")
					End If
				ElseIf item.Name = "Order Details" Then
					If (types And MetadataType.Field) > 0 Then
						item.AddField("OrderId")
						item.AddField("ProductId")
					End If

					If (types And MetadataType.ForeignKey) > 0 Then
						Dim foreignKey As MetadataForeignKey = item.AddForeignKey("OrderDetailsToOrder")
						foreignKey.Fields.Add("OrderId")
						foreignKey.ReferencedFields.Add("OrderId")
						Using name As New MetadataQualifiedName()
							name.Add("Orders")
							name.Add("dbo")

							foreignKey.ReferencedObjectName = name
						End Using
					End If
				End If
				Exit Select
		End Select

		item.Items.SetLoaded(types, True)
	End Sub

	'''///////////////////////////////////////////////////////////////////////
	''' 3rd way:
	'''
	''' This method demonstrates loading of metadata through .NET data providers 
	''' unsupported by our QueryBuilder component. If such data provider is able 
	''' to execute SQL queries, you can use our EventMetadataProvider with handling 
	''' it's ExecSQL event. In this event the EventMetadataProvider will provide 
	''' you SQL queries it use for the metadata retrieval. You have to execute 
	''' a query and return resulting data reader object.
	'''
	''' Note: In this sample we are using GenericSyntaxProvider that tries 
	''' to detect the the server type automatically. In some conditions it's unable 
	''' to detect the server type and it also has limited syntax parsing abilities. 
	''' For this reason you have to use specific syntax providers in your application, 
	''' e.g. MySQLSyntaxProver, OracleSyntaxProvider, etc.
	'''///////////////////////////////////////////////////////////////////////
	Private Sub btn3Way_Click(sender As Object, e As EventArgs)
		If dbConnection IsNot Nothing Then
			Try
				dbConnection.Close()
				dbConnection.Open()

				' allow QueryBuilder to request metadata
				queryBuilder1.MetadataLoadingOptions.OfflineMode = False

				ResetQueryBuilderMetadata()

				queryBuilder1.MetadataProvider = way3EventMetadataProvider
				queryBuilder1.InitializeDatabaseSchemaTree()
			Catch ex As System.Exception
				MessageBox.Show(ex.Message, "btn3Way_Click()")
			End Try
		Else
			MessageBox.Show("Please setup a database connection by clicking on the ""Connect"" menu item before testing this method.")
		End If
	End Sub

	Private Sub way3EventMetadataProvider_ExecSQL(metadataProvider As BaseMetadataProvider, sql As String, schemaOnly As Boolean, ByRef dataReader As IDataReader)
		dataReader = Nothing

		If dbConnection IsNot Nothing Then
			Dim command As IDbCommand = dbConnection.CreateCommand()
			command.CommandText = sql
			dataReader = command.ExecuteReader()
		End If
	End Sub

	'''///////////////////////////////////////////////////////////////////////
	''' 4th way:
	''' This method demonstrates manual filling of metadata structure from 
	''' stored DataSet.
	'''///////////////////////////////////////////////////////////////////////
	Private Sub btn4Way_Click(sender As Object, e As EventArgs)
		queryBuilder1.MetadataProvider = Nothing
		queryBuilder1.MetadataLoadingOptions.OfflineMode = True
		' prevent QueryBuilder to request metadata from connection
		Dim dataSet As New DataSet()

		' Load sample dataset created in the Visual Studio with Dataset Designer
		' and exported to XML using WriteXmlSchema() method.
		dataSet.ReadXmlSchema("StoredDataSetSchema.xml")

		queryBuilder1.MetadataContainer.BeginUpdate()

		Try
			queryBuilder1.ClearMetadata()

			' add tables
			For Each table As DataTable In dataSet.Tables
				' add new metadata table
				Dim metadataTable As MetadataObject = queryBuilder1.MetadataContainer.AddTable(table.TableName)

				' add metadata fields (columns)
				For Each column As DataColumn In table.Columns
					' create new field
					Dim metadataField As MetadataField = metadataTable.AddField(column.ColumnName)
					' setup field
					metadataField.FieldType = TypeToDbType(column.DataType)
					metadataField.Nullable = column.AllowDBNull
					metadataField.[ReadOnly] = column.[ReadOnly]

					If column.MaxLength <> -1 Then
						metadataField.Size = column.MaxLength
					End If

					' detect the field is primary key
					For Each pkColumn As DataColumn In table.PrimaryKey
						If column Is pkColumn Then
							metadataField.PrimaryKey = True
						End If
					Next
				Next

				' add relations
				For Each relation As DataRelation In table.ParentRelations
					' create new relation on the parent table
					Dim metadataRelation As MetadataForeignKey = metadataTable.AddForeignKey(relation.RelationName)

					' set referenced table
					Using referencedName As New MetadataQualifiedName()
						referencedName.Add(relation.ParentTable.TableName)

						metadataRelation.ReferencedObjectName = referencedName
					End Using

					' set referenced fields
					For Each parentColumn As DataColumn In relation.ParentColumns
						metadataRelation.ReferencedFields.Add(parentColumn.ColumnName)
					Next

					' set fields
					For Each childColumn As DataColumn In relation.ChildColumns
						metadataRelation.Fields.Add(childColumn.ColumnName)
					Next
				Next
			Next
		Finally
			queryBuilder1.MetadataContainer.EndUpdate()
		End Try

		queryBuilder1.InitializeDatabaseSchemaTree()
	End Sub


	' =============================================================================


	Private Sub aboutMenuItem_Click(sender As Object, e As EventArgs)
		QueryBuilder.ShowAboutDialog()
	End Sub

	Private Sub queryBuilder1_SQLUpdated(sender As Object, e As EventArgs)
		' Handle the event raised by SQL builder object that the text of SQL query is changed

		' Hide error banner if any
		ShowErrorBanner(textBox1, "")

		' update the text box
		textBox1.Text = queryBuilder1.FormattedSQL
	End Sub

	Private Sub connectToMSSQLServerMenuItem_Click(sender As Object, e As EventArgs)
		' Connect to MS SQL Server

		Using f As New MSSQLConnectionForm()
			If f.ShowDialog() = DialogResult.OK Then
				If dbConnection IsNot Nothing Then
					dbConnection.Close()
					dbConnection.Dispose()
				End If

				dbConnection = New SqlConnection(f.ConnectionString)
			End If
		End Using
	End Sub

	Private Sub connectToOracleServerMenuItem_Click(sender As Object, e As EventArgs)
		' Connect to Oracle Server

		Using f As New OracleConnectionForm()
			If f.ShowDialog() = DialogResult.OK Then
				If dbConnection IsNot Nothing Then
					dbConnection.Close()
					dbConnection.Dispose()
				End If

				dbConnection = New OracleConnection(f.ConnectionString)
			End If
		End Using
	End Sub

	Private Sub connectToAccessDatabaseMenuItem_Click(sender As Object, e As EventArgs)
		' Connect to MS Access database using OLE DB provider

		Using f As New AccessConnectionForm()
			If f.ShowDialog() = DialogResult.OK Then
				If dbConnection IsNot Nothing Then
					dbConnection.Close()
					dbConnection.Dispose()
				End If

				dbConnection = New OleDbConnection(f.ConnectionString)
			End If
		End Using
	End Sub

	Private Sub connectOleDbMenuItem_Click(sender As Object, e As EventArgs)
		' Connect to a database through the OLE DB provider

		Using f As New OLEDBConnectionForm()
			If f.ShowDialog() = DialogResult.OK Then
				If dbConnection IsNot Nothing Then
					dbConnection.Close()
					dbConnection.Dispose()
				End If

				dbConnection = New OleDbConnection(f.ConnectionString)
			End If
		End Using
	End Sub

	Private Sub connectODBCMenuItem_Click(sender As Object, e As EventArgs)
		' Connect to a database through the ODBC provider

		Using f As New ODBCConnectionForm()
			If f.ShowDialog() = DialogResult.OK Then
				If dbConnection IsNot Nothing Then
					dbConnection.Close()
					dbConnection.Dispose()
				End If

				dbConnection = New OdbcConnection(f.ConnectionString)
			End If
		End Using
	End Sub

	Private Sub textBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
		Try
			' Update the query builder with manually edited query text:
			queryBuilder1.SQL = textBox1.Text

			' Hide error banner if any
			ShowErrorBanner(textBox1, "")
		Catch ex As SQLParsingException
			' Set caret to error position
			textBox1.SelectionStart = ex.ErrorPos.pos

			' Show banner with error text
			ShowErrorBanner(textBox1, ex.Message)
		End Try
	End Sub

	Private Shared Function TypeToDbType(type As Type) As DbType
		If type Is GetType(System.String) Then
			Return DbType.[String]
		End If
		If type Is GetType(System.Int16) Then
			Return DbType.Int16
		End If
		If type Is GetType(System.Int32) Then
			Return DbType.Int32
		End If
		If type Is GetType(System.Int64) Then
			Return DbType.Int64
		End If
		If type Is GetType(System.UInt16) Then
			Return DbType.UInt16
		End If
		If type Is GetType(System.UInt32) Then
			Return DbType.UInt32
		End If
		If type Is GetType(System.UInt64) Then
			Return DbType.UInt64
		End If
		If type Is GetType(System.Boolean) Then
			Return DbType.[Boolean]
		End If
		If type Is GetType(System.Single) Then
			Return DbType.[Single]
		End If
		If type Is GetType(System.Double) Then
			Return DbType.[Double]
		End If
		If type Is GetType(System.Decimal) Then
			Return DbType.[Decimal]
		End If
		If type Is GetType(System.DateTime) Then
			Return DbType.DateTime
		End If
		If type Is GetType(System.TimeSpan) Then
			Return DbType.Time
		End If
		If type Is GetType(System.Byte) Then
			Return DbType.[Byte]
		End If
		If type Is GetType(System.SByte) Then
			Return DbType.[SByte]
		End If
		If type Is GetType(System.Char) Then
			Return DbType.[String]
		End If
		If type Is GetType(System.Byte()) Then
			Return DbType.Binary
		End If
		If type Is GetType(System.Guid) Then
			Return DbType.Guid
		End If
		Return DbType.[Object]
	End Function

	Private Sub ResetQueryBuilderMetadata()
		queryBuilder1.MetadataProvider = Nothing
		queryBuilder1.ClearMetadata()
		RemoveHandler queryBuilder1.MetadataContainer.ItemMetadataLoading, AddressOf way2ItemMetadataLoading
	End Sub

	Public Sub ShowErrorBanner(ByVal control As Control, ByVal text As String)
		' Display error banner if passed text is not empty
        ' Destory banner if already showing
		If True Then
			Dim existBanner As Boolean = False
			Dim banners As Control() = control.Controls.Find("ErrorBanner", True)

			If banners.Length > 0 Then

				For Each banner As Control In banners

					If Equals(text, banner.Text) Then
						existBanner = True
						Continue For
					End If

					banner.Dispose()
				Next
			End If

			If existBanner Then Return
		End If

		' Show new banner if text is not empty
		If Not String.IsNullOrEmpty(text) Then
			Dim label As Label = New Label With {
				.Name = "ErrorBanner",
				.Text = text,
				.BorderStyle = BorderStyle.FixedSingle,
				.BackColor = Color.LightPink,
				.AutoSize = True,
				.Visible = True
			}
			control.Controls.Add(label)
			label.Location = New Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2)
			label.BringToFront()
			control.Focus()
		End If
	End Sub


End Class
