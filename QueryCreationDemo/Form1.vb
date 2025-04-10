''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports GeneralAssembly.Forms.QueryInformationForms

Partial Public Class Form1
    Inherits Form

    Private ReadOnly _query As SQLQuery
    Public Sub New()
        Dim sqlContext As SQLContext = New SQLContext()
        sqlContext.LoadingOptions.OfflineMode = True
        _query = New SQLQuery(sqlContext)
        AddHandler _query.SQLUpdated, AddressOf Query_SQLUpdated
        InitializeComponent()

        comboBoxSyntax.SelectedItem = "MS SQL Server"
    End Sub

    Private Sub Query_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs)
        ' at this stage you can get simple unformatted query text...
        'SqlBox.Text = _query.SQL;

        ' ... or format the query text with SQL formatter
        Dim formattingOptions As SQLFormattingOptions = New SQLFormattingOptions With {.KeywordFormat = KeywordFormat.UpperCase}
        Dim sql As String = FormattedSQLBuilder.GetSQL(_query.QueryRoot, formattingOptions)

        ' put the result SQL query text to the text box
        SqlBox.Text = sql
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        FillMetadataContainer()
        comboBoxExamples.SelectedIndex = 0
    End Sub

    Private Sub buttonQueryStatistics_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonQueryStatistics.Click
        QueryStatistics()
    End Sub

    ' HOWTO: Fill metadata container with custom objects
    Public Sub FillMetadataContainer()
        Dim database As MetadataNamespace = _query.SQLContext.MetadataContainer.AddDatabase("MyDB")
        database.Default = True
        ' hides the default database prefix from object names
        Dim schema As MetadataNamespace = database.AddSchema("MySchema")
        schema.Default = True
        ' hides the default schema prefix from object names
        ' create table
        Dim tableOrders As MetadataObject = schema.AddTable("Orders")
        tableOrders.AddField("OrderID")
        tableOrders.AddField("OrderDate")
        tableOrders.AddField("City")
        tableOrders.AddField("CustomerID")
        tableOrders.AddField("ResellerID")

        ' create another table
        Dim tableCustomers As MetadataObject = schema.AddTable("Customers")
        tableCustomers.AddField("CustomerID")
        tableCustomers.AddField("CustomerName")
        tableCustomers.AddField("CustomerAddress")

        Dim fieldCustValue As MetadataField = tableCustomers.AddField("CustomerValue")
        fieldCustValue.FieldType = DbType.Double

        Dim fieldCustBirthDate As MetadataField = tableCustomers.AddField("CustomerBirthDay")
        fieldCustBirthDate.FieldType = DbType.DateTime

        Dim fieldCustCity As MetadataField = tableCustomers.AddField("City")
        fieldCustCity.FieldType = DbType.String
        fieldCustCity.Size = 50

        ' add a relation between these two tables
        Dim relation As MetadataForeignKey = tableCustomers.AddForeignKey("FK_CustomerID")
        relation.Fields.Add("CustomerID")
        relation.ReferencedObjectName = tableOrders.GetQualifiedName()
        relation.ReferencedFields.Add("CustomerID")

        ' create another table
        Dim salesOrderHeader As MetadataObject = schema.AddTable("SalesOrderHeader")
        salesOrderHeader.AddField("SalesOrderID")
        salesOrderHeader.AddField("OrderDate")

        ' create another table
        Dim salesOrderDetail As MetadataObject = schema.AddTable("SalesOrderDetail")
        salesOrderDetail.AddField("SalesOrderID")
        salesOrderDetail.AddField("UnitPrice")


        'create a view
        Dim viewResellers As MetadataObject = schema.AddView("Resellers")
        viewResellers.AddField("ResellerID")
        viewResellers.AddField("ResellerName")
    End Sub

    ' HOWTO: Get query statistics
    Public Sub QueryStatistics()
        Try
            _query.SQL = SqlBox.Text
        Catch e As Exception
            MessageBox.Show(e.Message, "Parsing error")
            Return
        End Try

        Dim qs As QueryStatistics = _query.QueryStatistics

        Dim stats = "Used Objects (" & qs.UsedDatabaseObjects.Count & "):" & vbCrLf

        For Each statisticsDatabaseObject As StatisticsDatabaseObject In qs.UsedDatabaseObjects
            stats += vbCrLf & statisticsDatabaseObject.ObjectName.QualifiedName
        Next statisticsDatabaseObject

        stats += vbCrLf & vbCrLf & "Used Columns (" & qs.UsedDatabaseObjectFields.Count & "):" & vbCrLf

        For Each statisticsField As StatisticsField In qs.UsedDatabaseObjectFields
            stats += vbCrLf & statisticsField.FullName.QualifiedName
        Next statisticsField

        stats += vbCrLf & vbCrLf & "Output Expressions (" & qs.OutputColumns.Count & "):" & vbCrLf

        For Each statisticsOutputColumn As StatisticsOutputColumn In qs.OutputColumns
            stats += vbCrLf & statisticsOutputColumn.Expression
        Next statisticsOutputColumn

        Dim f = New QueryStatisticsForm(stats)
        f.ShowDialog(Me)
    End Sub

    Private Sub comboBoxSyntax_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxSyntax.SelectedIndexChanged
        Select Case CStr(comboBoxSyntax.SelectedItem)
            Case "Advantage"
                _query.SQLContext.SyntaxProvider = New AdvantageSyntaxProvider()

            Case "ANSI SQL-2003"
                _query.SQLContext.SyntaxProvider = New SQL2003SyntaxProvider()

            Case "ANSI SQL-89"
                _query.SQLContext.SyntaxProvider = New SQL89SyntaxProvider()

            Case "ANSI SQL-92"
                _query.SQLContext.SyntaxProvider = New SQL92SyntaxProvider()

            Case "Firebird"
                _query.SQLContext.SyntaxProvider = New FirebirdSyntaxProvider()

            Case "IBM DB2"
                _query.SQLContext.SyntaxProvider = New DB2SyntaxProvider()

            Case "IBM Informix"
                _query.SQLContext.SyntaxProvider = New InformixSyntaxProvider()

            Case "MS Access"
                _query.SQLContext.SyntaxProvider = New MSAccessSyntaxProvider()

            Case "MS SQL Server"
                _query.SQLContext.SyntaxProvider = New MSSQLSyntaxProvider()

            Case "MySQL"
                _query.SQLContext.SyntaxProvider = New MySQLSyntaxProvider()

            Case "Oracle"
                _query.SQLContext.SyntaxProvider = New OracleSyntaxProvider()

            Case "PostgreSQL"
                _query.SQLContext.SyntaxProvider = New PostgreSQLSyntaxProvider()

            Case "SQLite"
                _query.SQLContext.SyntaxProvider = New SQLiteSyntaxProvider()

            Case "Sybase"
                _query.SQLContext.SyntaxProvider = New SybaseSyntaxProvider()

            Case "Teradata"
                _query.SQLContext.SyntaxProvider = New TeradataSyntaxProvider()

            Case "VistaDB"
                _query.SQLContext.SyntaxProvider = New VistaDBSyntaxProvider()

            Case Else
                _query.SQLContext.SyntaxProvider = New SQL92SyntaxProvider()

        End Select
    End Sub

    Private Sub comboBoxExamples_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxExamples.SelectedIndexChanged
        _query.Clear()

        ' HOWTO: Create a query programmatically
        Select Case comboBoxExamples.SelectedIndex
            Case 0
                LoadQuerySimple()
            Case 1
                LoadQueryWithLeftJoin()
            Case 2
                LoadQueryWithAggregateAndGroup()
            Case 3
                LoadQueryWithDerivedTableAndCte()
            Case 4
                LoadQueryWithUnions()
            Case 5
                LoadQueryWithSubQueryExpression()

            Case Else
                Throw New ArgumentOutOfRangeException()
        End Select
    End Sub

    Private Sub LoadQuerySimple()
        Dim unionSubQuery As UnionSubQuery = _query.QueryRoot.FirstSelect()

        ' add three objects to the query
        Dim ds1 As DataSource = _query.AddObject(unionSubQuery, "MyDB.MySchema.Customers", "c")
        Dim ds2 As DataSource = _query.AddObject(unionSubQuery, "MyDB.MySchema.Orders", "o")
        Dim ds3 As DataSource = _query.AddObject(unionSubQuery, "MyDB.MySchema.Resellers", "r")

        ' create a relation between 'Resellers' and 'Orders'
        _query.AddLink(ds3, "ResellerID", ds2, "ResellerID")

        ' create WHERE condition
        Dim ci2 As QueryColumnListItem = unionSubQuery.QueryColumnList.AddExpression("CustomerID")
        ' do not add this item to the select list
        ci2.Selected = False
        ci2.ConditionStrings(0) = "> 0"

        ' create an output column
        Dim ci3 As QueryColumnListItem = unionSubQuery.QueryColumnList.AddField(ds1, "CustomerName")
        ' add this item to the select list
        ci3.Selected = True
    End Sub

    Private Sub LoadQueryWithLeftJoin()
        Dim unionSubQuery As UnionSubQuery = _query.QueryRoot.FirstSelect()

        ' add data source objects into the query
        Dim ds1 As DataSource = _query.AddObject(unionSubQuery, "MyDB.MySchema.Orders")
        Dim ds2 As DataSource = _query.AddObject(unionSubQuery, "MyDB.MySchema.Resellers")

        ' create a relation between 'Resellers' and 'Orders'
        Dim link As Link = _query.AddLink(ds2, "ResellerID", ds1, "ResellerID")

        If link Is Nothing Then
            Return
        End If

        ' set link type to left outer join
        link.LeftType = LinkSideType.Outer

        ' alter join expression
        link.LinkExpressionString = link.LinkExpressionString & " and Orders.ResellerID IS NOT NULL"
    End Sub

    Private Sub LoadQueryWithAggregateAndGroup()
        Dim unionSubQuery As UnionSubQuery = _query.QueryRoot.FirstSelect()

        ' add an object to the query
        Dim ds1 As DataSource = _query.AddObject(unionSubQuery, "MyDB.MySchema.Customers")

        ' create two output columns
        Dim ci1 As QueryColumnListItem = unionSubQuery.QueryColumnList.AddField(ds1, "CustomerID")
        ci1.Selected = True
        Dim ci2 As QueryColumnListItem = unionSubQuery.QueryColumnList.AddField(ds1, "CustomerValue")
        ci2.Selected = True

        ' add WHERE condition
        ci2.ConditionStrings(0) = "> 100"

        ' specify order by 
        ci2.SortType = ItemSortType.Desc
        ci2.SortOrder = 0

        ' group by
        ci2.Grouping = True

        ' define aggregate function for the first column
        ci1.AggregateString = "Count"

        ' add a HAVING clause
        ci1.ConditionStrings(0) = "> 10"
        ci1.ConditionType = ConditionType.Having
    End Sub

    Private Sub LoadQueryWithDerivedTableAndCte()
        Dim unionSubQuery As UnionSubQuery = _query.QueryRoot.FirstSelect()

        ' Derived Table
        Dim fq As New SQLFromQuery(_query.SQLContext) With {.Alias = New SQLAliasObjectAlias(_query.SQLContext) With {.Alias = _query.QueryRoot.CreateUniqueSubQueryName()}, .SubQuery = New SQLSubSelectStatement(_query.SQLContext)}

        Dim sqse As New SQLSubQuerySelectExpression(_query.SQLContext)
        fq.SubQuery.Add(sqse)
        sqse.SelectItems = New SQLSelectItems(_query.SQLContext)
        sqse.From = New SQLFromClause(_query.SQLContext)

        Dim dataSourceQuery As DataSourceQuery = CType(_query.AddObject(unionSubQuery, fq, GetType(DataSourceQuery)), DataSourceQuery)
        Dim usc As UnionSubQuery = dataSourceQuery.SubQuery.FirstSelect()
        Dim dsDerivedTable As DataSource = _query.AddObject(usc, "MyDB.MySchema.SalesOrderHeader")

        Dim ciDerivedTable1 As QueryColumnListItem = usc.QueryColumnList.AddField(dsDerivedTable, "OrderDate")
        ciDerivedTable1.Selected = True

        Dim ciDerivedTable2 As QueryColumnListItem = usc.QueryColumnList.AddField(dsDerivedTable, "SalesOrderID")
        ciDerivedTable2.ConditionStrings(0) = "> 25"

        ' CTE
        Dim qn As New SQLQualifiedName(_query.SQLContext)
        If Not unionSubQuery.QueryRoot.SQLContext.SyntaxProvider.IsSupportCTE() Then
            Return
        End If

        Dim dataSourceCte As DataSource = Nothing
        Try
            Dim withClauseItemName As AstTokenIdentifier = _query.QueryRoot.CreateUniqueCTEName("CTE")

            qn.Add(withClauseItemName)

            Dim parentSubQuery As SubQuery = If(unionSubQuery.ParentSubQuery, TryCast(unionSubQuery.QueryRoot, SubQuery))

            If parentSubQuery.IsMainQuery Then
                _query.QueryRoot.AddNewCTE(Nothing, withClauseItemName)
            Else
                If parentSubQuery.IsSubQueryCTE() Then
                    Dim index As Integer = parentSubQuery.GetSubQueryCTEIndex()
                    parentSubQuery.InsertNewCTE(index, Nothing, withClauseItemName)
                Else
                    parentSubQuery.AddNewCTE(Nothing, withClauseItemName)
                End If
            End If

            If _query.IsUniqueAlias(unionSubQuery, withClauseItemName) Then
                dataSourceCte = _query.AddObject(unionSubQuery, qn, Nothing)
            Else
                Dim withClauseItemNameStr As String = withClauseItemName.GetSQL(New SQLGenerationOptions())
                Using [alias] As AstTokenIdentifier = _query.CreateUniqueAlias(unionSubQuery, withClauseItemNameStr)
                    dataSourceCte = _query.AddObject(unionSubQuery, qn, [alias])
                End Using
            End If
        Finally
            qn.Dispose()
        End Try

        Dim cte As SubQuery = _query.QueryRoot.GetSubQueryCTEList().FirstOrDefault()

        If cte Is Nothing Then
            Return
        End If


        Dim unionSubQueryCte As UnionSubQuery = cte.FirstSelect()
        Dim ds1 As DataSource = _query.AddObject(unionSubQueryCte, "MyDB.MySchema.Customers")

        ' create output column
        Dim ci1 As QueryColumnListItem = unionSubQueryCte.QueryColumnList.AddField(ds1, "CustomerName")
        ci1.Selected = True

        ' create output column
        Dim ci2 As QueryColumnListItem = unionSubQuery.QueryColumnList.AddField(dataSourceCte, "CustomerName")
        ci2.Selected = True
    End Sub

    Private Sub LoadQueryWithUnions()
        Dim unionSubQuery As UnionSubQuery = _query.QueryRoot.FirstSelect()

        Dim ds1 As DataSource = _query.AddObject(unionSubQuery, "MyDB.MySchema.Customers")

        ' create output column 
        Dim ci1 As QueryColumnListItem = unionSubQuery.QueryColumnList.AddField(ds1, "City")
        ci1.Selected = True

        Dim union1 As UnionSubQuery = unionSubQuery.ParentGroup.Add()

        Dim ds2 As DataSource = _query.AddObject(union1, "MyDB.MySchema.Orders")

        ' create output column with grouping
        Dim ci2 As QueryColumnListItem = union1.QueryColumnList.AddField(ds2, "City")
        ci2.Selected = True
        ci2.Grouping = True

        ' Copy UnionSubQuery

        ' add an empty UnionSubQuery
        Dim usq As UnionSubQuery = unionSubQuery.ParentGroup.Add()

        ' copy the content of existing union sub-query to a new one
        Dim usqAst As SQLSubQuerySelectExpression = unionSubQuery.ResultQueryAST
        usqAst.RestoreColumnPrefixRecursive(True)

        Dim lCte As New List(Of SQLWithClauseItem)()
        Dim lFromObj As New List(Of SQLFromSource)()
        unionSubQuery.GatherPrepareAndFixupContext(lCte, lFromObj, False)
        usqAst.PrepareAndFixupRecursive(lCte, lFromObj)

        usq.LoadFromAST(usqAst)

        Dim ci3 As QueryColumnListItem = usq.QueryColumnList.AddField(ds1, "CustomerAddress")
        ci3.Selected = True
    End Sub

    Private Sub LoadQueryWithSubQueryExpression()
        Dim unionSubQuery As UnionSubQuery = _query.QueryRoot.FirstSelect()

        ' add data source to the query
        Dim ds1 As DataSource = _query.AddObject(unionSubQuery, "MyDB.MySchema.SalesOrderHeader", "Ord")

        ' add SQL expression column
        Dim ci0 As QueryColumnListItem = unionSubQuery.QueryColumnList.AddExpression("GetDate()")
        ci0.Selected = True
        ci0.AliasString = "CurrentDate"

        ' add database field columns
        Dim ci1 As QueryColumnListItem = unionSubQuery.QueryColumnList.AddField(ds1, "SalesOrderID")
        ci1.Selected = True
        Dim ci2 As QueryColumnListItem = unionSubQuery.QueryColumnList.AddField(ds1, "OrderDate")
        ci2.Selected = True

        ' add sub-query in expression 
        Dim ci3 As QueryColumnListItem = unionSubQuery.QueryColumnList.AddExpression("(SELECT *)")
        ci3.AliasString = "MaxUnitPrice"
        ci3.Selected = True

        Dim subQueriesAst As IList(Of SubSelectStatementProxy) = ci3.CollectSubqueryProxiesByRootNode(ci3.Expression)
        Dim unionSubQueryExpression As UnionSubQuery = subQueriesAst(0).SubQuery.FirstSelect()

        Dim dsExpression As DataSource = _query.AddObject(unionSubQueryExpression, "MyDB.MySchema.SalesOrderDetail", "OrdDet")

        Dim ciExpression1 As QueryColumnListItem = unionSubQueryExpression.QueryColumnList.AddField(ds1, "SalesOrderID")
        ciExpression1.ConditionStrings(0) = "= OrdDet.SalesOrderID"

        Dim ciExpression As QueryColumnListItem = unionSubQueryExpression.QueryColumnList.AddField(dsExpression, "UnitPrice")
        ciExpression.AggregateString = "Max"
        ciExpression.Selected = True
    End Sub
End Class
