//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports ActiveQueryBuilder.Core.QueryTransformer
Imports GeneralAssembly.Forms.QueryInformationForms

Partial Public Class Form1
    Inherits Form
    Private _errorPosition As Integer = -1
    Private _lastValidSql As String
    Private _selectedConnection As ConnectionInfo

    Public Sub New()
        InitializeComponent()

        queryBuilder.SyntaxProvider = New MSSQLSyntaxProvider()

        ' Set a demo query
        queryBuilder.SQL = "Select Orders.OrderID, Orders.CustomerID, Orders.EmployeeID, Query1.Subtotal From Orders Inner Join (Select [Order Subtotals].Subtotal, [Order Subtotals].OrderID From [Order Subtotals]) Query1 On Query1.OrderID = Orders.OrderID Union Select [Orders Qry].OrderID, [Orders Qry].CustomerID, [Orders Qry].EmployeeID, Query2.Quantity * Query2.UnitPrice From [Orders Qry] Inner Join (Select [Order Details].OrderID, [Order Details].Quantity, [Order Details].UnitPrice From [Order Details]) Query2 On Query2.OrderID = [Orders Qry].OrderID Where ([Orders Qry].OrderID > 100) Or ([Orders Qry].OrderID < 1000)"
    End Sub

    Private Sub queryBuilder_SQLUpdated(ByVal sender As Object, ByVal e As EventArgs) Handles queryBuilder.SQLUpdated
        ' Hide error banner if any
        errorBox1.Show(Nothing, queryBuilder.SyntaxProvider)

        QueryPartChanged(sender, e)
        'textBox1.Text =  queryBuilder.FormattedSQL;

        If tabControl1.SelectedTab Is tabPageResultsPreview Then
            UpdateResultsGrid()
        End If
    End Sub

    Private Sub textBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles textBox1.Validating
        Try
            ' Update the target query part with manually edited query text:
            queryBuilder.SQL = textBox1.Text

            ' Hide error banner if any
            errorBox1.Show(Nothing, queryBuilder.SyntaxProvider)
        Catch ex As SQLParsingException
            ' Set caret to error position
            textBox1.SelectionStart = ex.ErrorPos.pos
            _errorPosition = textBox1.SelectionStart

            ' Show banner with error text
            errorBox1.Show(ex.Message, queryBuilder.SyntaxProvider)
        End Try
    End Sub

    Private Sub QueryPartChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbQuery.CheckedChanged, rbSubQuery.CheckedChanged, rbUnionSubQuery.CheckedChanged
        If Disposing OrElse queryBuilder.ActiveUnionSubQuery Is Nothing Then
            Return
        End If

        If rbQuery.Checked Then
            textBox1.Text = New SQLFormattingOptions(New SQLGenerationOptions()).GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot)
            _lastValidSql = textBox1.Text
        ElseIf rbSubQuery.Checked Then
            textBox1.Text = New SQLFormattingOptions(New SQLGenerationOptions()).GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.ParentSubQuery)
            _lastValidSql = textBox1.Text
        ElseIf rbUnionSubQuery.Checked Then
            textBox1.Text = New SQLFormattingOptions(New SQLGenerationOptions()).GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery)
            _lastValidSql = textBox1.Text
        End If
    End Sub

    Public Sub ResetQueryBuilder()
        queryBuilder.Clear()
        queryBuilder.MetadataProvider = Nothing
        queryBuilder.SyntaxProvider = Nothing
        queryBuilder.MetadataLoadingOptions.OfflineMode = False
    End Sub


    Private Sub tabControl1_Selected(ByVal sender As Object, ByVal e As TabControlEventArgs) Handles tabControl1.Selected
        ' Move the input focus to the query builder.
        ' This will cause the validation in the text box and update the query builder with modified query text.
        queryBuilder.Focus()
        Application.DoEvents()

        UpdateResultsGrid()
    End Sub

    Private Sub UpdateResultsGrid()
        ' Check database connection
        If queryBuilder.MetadataProvider Is Nothing OrElse queryBuilder.MetadataProvider.Connection Is Nothing Then
            Dim label As New Label()
            label.Text = "You should connect a database"
            label.TextAlign = ContentAlignment.MiddleCenter
            label.Dock = DockStyle.Fill
            dataGridView1.Controls.Add(label)
        ElseIf queryBuilder.SQL.Length = 0 Then ' check the query text is not empty
            Dim label As New Label()
            label.Text = "No query to execute"
            label.TextAlign = ContentAlignment.MiddleCenter
            label.Dock = DockStyle.Fill
            dataGridView1.Controls.Add(label)
        Else
            dataGridView1.Controls.Clear()
        End If

        Dim queryToExecute = ""

        ' Limit query results to 10 rows for preview purposes

        'queryBuilder.SQLContext.LoadingOptions.OfflineMode = true;
        'queryBuilder.SQLContext.SyntaxProvider = queryBuilder.SyntaxProvider;
        'queryBuilder.SQLContext.MetadataProvider = queryBuilder.MetadataProvider;

        'var query = new SQLQuery(sqlContext) {SQL = queryToExecute};

        'tempQueryBuilder.SQL = queryToExecute;

        Using queryTransformer As New QueryTransformer()
            queryTransformer.Query = queryBuilder.QueryView.Query
            queryTransformer.ResultCount = "10" ' select top 10 rows only
            queryToExecute = queryTransformer.SQL
        End Using

        ' Try to execute the query using current database connection:

        If tabControl1.SelectedTab Is tabPageResultsPreview Then
            dataGridView1.DataSource = Nothing

            If queryBuilder.MetadataProvider IsNot Nothing AndAlso queryBuilder.MetadataProvider.Connected Then
                If TypeOf queryBuilder.MetadataProvider Is MSSQLMetadataProvider Then
                    Dim command As SqlCommand = CType(queryBuilder.MetadataProvider.Connection.CreateCommand(), SqlCommand)
                    command.CommandText = queryToExecute

                    ' handle the query parameters
                    If queryBuilder.Parameters.Count > 0 Then
                        For i As Integer = 0 To queryBuilder.Parameters.Count - 1
                            If Not command.Parameters.Contains(queryBuilder.Parameters(i).FullName) Then
                                Dim parameter As New SqlParameter()
                                parameter.ParameterName = queryBuilder.Parameters(i).FullName
                                parameter.DbType = queryBuilder.Parameters(i).DataType
                                command.Parameters.Add(parameter)
                            End If
                        Next i

                        Using qpf As New QueryParametersForm(command)
                            qpf.ShowDialog()
                        End Using
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataset As New DataSet()

                    Try
                        adapter.Fill(dataset, "QueryResult")
                        dataGridView1.DataSource = dataset.Tables("QueryResult")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "SQL query error")
                    End Try
                ElseIf TypeOf queryBuilder.MetadataProvider Is OLEDBMetadataProvider Then
                    Dim command As OleDbCommand = CType(queryBuilder.MetadataProvider.Connection.CreateCommand(), OleDbCommand)
                    command.CommandText = queryToExecute

                    ' handle the query parameters
                    If queryBuilder.Parameters.Count > 0 Then
                        For i As Integer = 0 To queryBuilder.Parameters.Count - 1
                            If Not command.Parameters.Contains(queryBuilder.Parameters(i).FullName) Then
                                Dim parameter As New OleDbParameter()
                                parameter.ParameterName = queryBuilder.Parameters(i).FullName
                                parameter.DbType = queryBuilder.Parameters(i).DataType
                                command.Parameters.Add(parameter)
                            End If
                        Next i

                        Using qpf As New QueryParametersForm(command)
                            qpf.ShowDialog()
                        End Using
                    End If

                    Dim adapter As New OleDbDataAdapter(command)
                    Dim dataset As New DataSet()

                    Try
                        adapter.Fill(dataset, "QueryResult")
                        dataGridView1.DataSource = dataset.Tables("QueryResult")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "SQL query error")
                    End Try
                ElseIf TypeOf queryBuilder.MetadataProvider Is ODBCMetadataProvider Then
                    Dim command As OdbcCommand = CType(queryBuilder.MetadataProvider.Connection.CreateCommand(), OdbcCommand)
                    command.CommandText = queryToExecute

                    ' handle the query parameters
                    If queryBuilder.Parameters.Count > 0 Then
                        For i As Integer = 0 To queryBuilder.Parameters.Count - 1
                            If Not command.Parameters.Contains(queryBuilder.Parameters(i).FullName) Then
                                Dim parameter As New OdbcParameter()
                                parameter.ParameterName = queryBuilder.Parameters(i).FullName
                                parameter.DbType = queryBuilder.Parameters(i).DataType
                                command.Parameters.Add(parameter)
                            End If
                        Next i

                        Using qpf As New QueryParametersForm(command)
                            qpf.ShowDialog()
                        End Using
                    End If

                    Dim adapter As New OdbcDataAdapter(command)
                    Dim dataset As New DataSet()

                    Try
                        adapter.Fill(dataset, "QueryResult")
                        dataGridView1.DataSource = dataset.Tables("QueryResult")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "SQL query error")
                    End Try
                End If

                ' enable sorting
                For Each column As DataGridViewColumn In dataGridView1.Columns
                    column.SortMode = DataGridViewColumnSortMode.Automatic
                Next column
            End If
        End If
    End Sub

    Private Sub queryBuilder_ActiveUnionSubQueryChanged(ByVal sender As Object, ByVal e As EventArgs) Handles queryBuilder.ActiveUnionSubQueryChanged
        QueryPartChanged(sender, e)
    End Sub

    Private Sub errorBox1_GoToErrorPosition(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.GoToErrorPosition
        If _errorPosition <> -1 Then
            textBox1.SelectionStart = _errorPosition
            textBox1.SelectionLength = 0
            textBox1.ScrollToCaret()
        End If

        textBox1.Focus()
    End Sub

    Private Sub errorBox1_RevertValidText(ByVal sender As Object, ByVal e As EventArgs) Handles errorBox1.RevertValidText
        textBox1.Text = _lastValidSql
        textBox1.Focus()
    End Sub

    Private Sub connectToToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles connectToToolStripMenuItem.Click
        Dim cf = New ConnectionForm() With {.Owner = Me}

        If cf.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        _selectedConnection = cf.SelectedConnection

        InitializeSqlContext()
    End Sub
    Private Sub InitializeSqlContext()
        Try
            queryBuilder.Clear()

            Dim metadataProvider As BaseMetadataProvider = Nothing

            If _selectedConnection Is Nothing Then
                Return
            End If

            ' create new SqlConnection object using the connections string from the connection form
            If Not _selectedConnection.IsXmlFile Then
                metadataProvider = _selectedConnection.ConnectionDescriptor?.MetadataProvider
            End If

            ' setup the query builder with metadata and syntax providers
            queryBuilder.SQLContext.MetadataContainer.Clear()
            queryBuilder.MetadataProvider = metadataProvider
            queryBuilder.SyntaxProvider = _selectedConnection.ConnectionDescriptor?.SyntaxProvider
            queryBuilder.MetadataLoadingOptions.OfflineMode = metadataProvider Is Nothing

            If metadataProvider Is Nothing Then
                queryBuilder.MetadataContainer.ImportFromXML(_selectedConnection.ConnectionString)
            End If

            ' Instruct the query builder to fill the database schema tree
            queryBuilder.InitializeDatabaseSchemaTree()

        Finally

        End Try
    End Sub
End Class
