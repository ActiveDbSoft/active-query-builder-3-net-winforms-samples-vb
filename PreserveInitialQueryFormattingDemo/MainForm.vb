''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2023 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.IO
Imports GeneralAssembly.Common

Public Class MainForm
    Private _isCanUpdateSqlText As Boolean = True
    Private _defaultSql As StringBuilder = New StringBuilder()

    Public Sub New()
        _defaultSql.AppendLine("-- Any text for comment")
        _defaultSql.AppendLine("Select Categories.CategoryName,")
        _defaultSql.AppendLine("  Products.UnitPrice")
        _defaultSql.AppendLine("From Categories")
        _defaultSql.AppendLine("  Inner Join Products On Categories.CategoryID = Products.CategoryID")

        InitializeComponent()
        InitializeQueryBuilder()

        AddHandler Load, AddressOf OnLoaded
    End Sub

    Private Sub OnLoaded(sender As Object, e As EventArgs)
        TextBoxSql.Text = _defaultSql.ToString()
    End Sub

    Private Sub InitializeQueryBuilder()
        QBuilder.MetadataContainer.LoadingOptions.OfflineMode = True
        QBuilder.SyntaxProvider = New MSSQLSyntaxProvider()
        QBuilder.MetadataContainer.ImportFromXML("Northwind.xml")
        QBuilder.InitializeDatabaseSchemaTree()
        QBuilder.SQL = _defaultSql.ToString()
    End Sub

    Private Sub AssignSqlText(text As String)
        _isCanUpdateSqlText = False
        sqlErrorBox1.Show("", QBuilder.SyntaxProvider)

        Try
            QBuilder.SQL = text
        Catch ex As Exception
            sqlErrorBox1.Show(ex.Message, QBuilder.SyntaxProvider)
        End Try
        _isCanUpdateSqlText = True
    End Sub
    
    Private Sub buttonOpenSql_Click(sender As Object, e As EventArgs) Handles buttonOpenSql.Click
        Dim openDialog = New OpenFileDialog()

        If openDialog.ShowDialog(Me) = Dialogresult.Ok Then
            If File.Exists(openDialog.FileName) Then
                Dim sqlText = String.Empty
                Using reader = New StreamReader(openDialog.FileName)
                    sqlText = reader.ReadToEnd()
                End Using

                TextBoxSql.Text = sqlText
                AssignSqlText(sqlText)
            End If
        End If
    End Sub

    Private Sub queryBuilder1_SQLUpdated(sender As Object, e As EventArgs) Handles QBuilder.SQLUpdated
        If Not _isCanUpdateSqlText Then Return
        TextBoxSql.Text = QBuilder.FormattedSQL
    End Sub

    Private Sub TextBoxSql_Validating(sender As Object, e As CancelEventArgs) Handles textBoxSql.Validating
        AssignSqlText(TextBoxSql.Text)
    End Sub
End Class
