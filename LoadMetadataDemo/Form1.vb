''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2022 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

'''******************************************************************************
'''This sample demonstrates loading of metadata if the standard way (see GeneralDemo)
'''is not suitable for some reason.
'''********************************************************************
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms

Partial Public Class Form1
    Inherits Form
    Private dbConnection As IDbConnection
    Private _selectedConnection As ConnectionInfo

    Public Sub New()
        InitializeComponent()
    End Sub

    '////////////////////////////////////////////////////////////////////////
    ''' 1st way:
    ''' This method demonstrates the direct access to the internal metadata 
    ''' objects collection (MetadataContainer).
    '////////////////////////////////////////////////////////////////////////
        Private Sub btn1Way_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFourthWay.Click
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

    '////////////////////////////////////////////////////////////////////////
    ''' 2rd way:
    ''' This method demonstrates on-demand manual filling of metadata structure using 
    ''' corresponding MetadataContainer.ItemMetadataLoading event
    '////////////////////////////////////////////////////////////////////////
        Private Sub btn2Way_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnThirdWay.Click
        ' allow QueryBuilder to request metadata
        queryBuilder1.MetadataLoadingOptions.OfflineMode = False

        queryBuilder1.MetadataProvider = Nothing
        AddHandler queryBuilder1.MetadataContainer.ItemMetadataLoading, AddressOf way2ItemMetadataLoading
        queryBuilder1.InitializeDatabaseSchemaTree()
    End Sub

    Private Sub way2ItemMetadataLoading(ByVal sender As Object, ByVal item As MetadataItem, ByVal types As MetadataType)
        Select Case item.Type
            Case MetadataType.Root
                If types.Contains(MetadataType.Schema) Then
                    ' only one "dbo" schema should be at the root level
                    If item.Items.FindItem(Of MetadataNamespace)("dbo", MetadataType.Schema) Is Nothing Then
                        item.AddSchema("dbo")
                    End If
                End If

            Case MetadataType.Schema
                If item.Name = "dbo" AndAlso types.Contains(MetadataType.Table) Then
                    item.AddTable("Orders")
                    item.AddTable("Order Details")
                End If

            Case MetadataType.Table
                If item.Name = "Orders" Then
                    If types.Contains(MetadataType.Field) Then
                        item.AddField("OrderId")
                        item.AddField("CustomerId")
                    End If
                ElseIf item.Name = "Order Details" Then
                    If types.Contains(MetadataType.Field) Then
                        item.AddField("OrderId")
                        item.AddField("ProductId")
                    End If

                    If types.Contains(MetadataType.ForeignKey) Then
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
        End Select

        item.Items.SetLoaded(types, True)
    End Sub

    '////////////////////////////////////////////////////////////////////////
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
    '////////////////////////////////////////////////////////////////////////
        Private Sub btn3Way_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirstWay.Click
        If dbConnection IsNot Nothing Then
            Try
                dbConnection.Close()
                dbConnection.Open()

                ' allow QueryBuilder to request metadata
                queryBuilder1.MetadataLoadingOptions.OfflineMode = False

                ResetQueryBuilderMetadata()

                queryBuilder1.MetadataProvider = way3EventMetadataProvider
                queryBuilder1.InitializeDatabaseSchemaTree()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "btn3Way_Click()")
            End Try
        Else
            MessageBox.Show("Please setup a database connection by clicking on the ""Connect"" menu item before testing this method.")
        End If
    End Sub

    Private Sub way3EventMetadataProvider_ExecSQL(ByVal metadataProvider As BaseMetadataProvider, ByVal sql As String, ByVal schemaOnly As Boolean, <System.Runtime.InteropServices.Out()> ByRef dataReader As IDataReader)
        dataReader = Nothing

        If dbConnection IsNot Nothing Then
            Dim command As IDbCommand = dbConnection.CreateCommand()
            command.CommandText = sql
            dataReader = command.ExecuteReader()
        End If
    End Sub

    '////////////////////////////////////////////////////////////////////////
    ''' 4th way:
    ''' This method demonstrates manual filling of metadata structure from 
    ''' stored DataSet.
    '////////////////////////////////////////////////////////////////////////
        Private Sub btn4Way_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFifthWay.Click
        queryBuilder1.MetadataProvider = Nothing
        queryBuilder1.MetadataLoadingOptions.OfflineMode = True ' prevent QueryBuilder to request metadata from connection

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
                    metadataField.ReadOnly = column.ReadOnly

                    If column.MaxLength <> -1 Then
                        metadataField.Size = column.MaxLength
                    End If

                    ' detect the field is primary key
                    For Each pkColumn As DataColumn In table.PrimaryKey
                        If column Is pkColumn Then
                            metadataField.PrimaryKey = True
                        End If
                    Next pkColumn
                Next column

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
                    Next parentColumn

                    ' set fields
                    For Each childColumn As DataColumn In relation.ChildColumns
                        metadataRelation.Fields.Add(childColumn.ColumnName)
                    Next childColumn
                Next relation
            Next table
        Finally
            queryBuilder1.MetadataContainer.EndUpdate()
        End Try

        queryBuilder1.InitializeDatabaseSchemaTree()
    End Sub


    ' =============================================================================


    Private Sub aboutMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutMenuItem.Click
        QueryBuilder.ShowAboutDialog()
    End Sub

    Private Sub queryBuilder1_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs) Handles queryBuilder1.SQLUpdated
        ' Handle the event raised by SQL builder object that the text of SQL query is changed

        ' Hide error banner if any
        ShowErrorBanner(textBox1, "")

        ' update the text box
        textBox1.Text = queryBuilder1.FormattedSQL
    End Sub

    Private Sub textBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textBox1.Validating
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

    Private Shared Function TypeToDbType(ByVal type As Type) As DbType
        If type Is GetType(String) Then
            Return DbType.String
        End If
        If type Is GetType(Int16) Then
            Return DbType.Int16
        End If
        If type Is GetType(Int32) Then
            Return DbType.Int32
        End If
        If type Is GetType(Int64) Then
            Return DbType.Int64
        End If
        If type Is GetType(UInt16) Then
            Return DbType.UInt16
        End If
        If type Is GetType(UInt32) Then
            Return DbType.UInt32
        End If
        If type Is GetType(UInt64) Then
            Return DbType.UInt64
        End If
        If type Is GetType(Boolean) Then
            Return DbType.Boolean
        End If
        If type Is GetType(Single) Then
            Return DbType.Single
        End If
        If type Is GetType(Double) Then
            Return DbType.Double
        End If
        If type Is GetType(Decimal) Then
            Return DbType.Decimal
        End If
        If type Is GetType(Date) Then
            Return DbType.DateTime
        End If
        If type Is GetType(TimeSpan) Then
            Return DbType.Time
        End If
        If type Is GetType(Byte) Then
            Return DbType.Byte
        End If
        If type Is GetType(SByte) Then
            Return DbType.SByte
        End If
        If type Is GetType(Char) Then
            Return DbType.String
        End If
        If type Is GetType(Byte()) Then
            Return DbType.Binary
        End If
        If type Is GetType(Guid) Then
            Return DbType.Guid
        End If
        Return DbType.Object
    End Function

    Private Sub ResetQueryBuilderMetadata()
        queryBuilder1.MetadataProvider = Nothing
        queryBuilder1.ClearMetadata()
        RemoveHandler queryBuilder1.MetadataContainer.ItemMetadataLoading, AddressOf way2ItemMetadataLoading
    End Sub

    Public Sub ShowErrorBanner(ByVal control As Control, ByVal text As String)
        ' Destory banner if already showing
        Dim existBanner As Boolean = False
        Dim banners() As Control = control.Controls.Find("ErrorBanner", True)

        If banners.Length > 0 Then
            For Each banner As Control In banners
                If Equals(text, banner.Text) Then
                    existBanner = True
                    Continue For
                End If
                banner.Dispose()
            Next banner
        End If

        If existBanner Then
            Return
        End If

        ' Show new banner if text is not empty
        If Not String.IsNullOrEmpty(text) Then
            Dim label As Label = New Label With {.Name = "ErrorBanner", .Text = text, .BorderStyle = BorderStyle.FixedSingle, .BackColor = Color.LightPink, .AutoSize = True, .Visible = True}

            control.Controls.Add(label)
            label.Location = New Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2)
            label.BringToFront()

            control.Focus()
        End If
    End Sub

    Private Sub menuItemConnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuItemConnect.Click
        Dim cf = New ConnectionForm() With {.Owner = Me}

        If cf.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        _selectedConnection = cf.SelectedConnection

        InitializeSqlContext()
    End Sub

    Private Sub InitializeSqlContext()
        Try
            queryBuilder1.Clear()

            Dim metadataProvider As BaseMetadataProvider = Nothing

            If _selectedConnection Is Nothing Then
                Return
            End If

            ' create new SqlConnection object using the connections string from the connection form
            If Not _selectedConnection.IsXmlFile Then
                metadataProvider = _selectedConnection.ConnectionDescriptor?.MetadataProvider
            End If

            ' setup the query builder with metadata and syntax providers
            queryBuilder1.SQLContext.MetadataContainer.Clear()
            queryBuilder1.MetadataProvider = metadataProvider
            queryBuilder1.SyntaxProvider = _selectedConnection.ConnectionDescriptor?.SyntaxProvider
            queryBuilder1.MetadataLoadingOptions.OfflineMode = metadataProvider Is Nothing

            If metadataProvider Is Nothing Then
                queryBuilder1.MetadataContainer.ImportFromXML(_selectedConnection.ConnectionString)
            End If

            ' Instruct the query builder to fill the database schema tree
            queryBuilder1.InitializeDatabaseSchemaTree()

        Finally


        End Try
    End Sub
End Class
