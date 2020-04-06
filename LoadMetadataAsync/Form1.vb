'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.ComponentModel
Imports System.Data.OleDb
Imports ActiveQueryBuilder.Core


Partial Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()

        ' Disable the control so it will be unusable untill the metadata is loaded
        queryBuilder.Enabled = False

        ' Run metadata loading in separate thread
        Dim backgroundWorker = New BackgroundWorker()
        AddHandler backgroundWorker.DoWork, AddressOf BackgroundWorker_DoWork
        AddHandler backgroundWorker.RunWorkerCompleted, AddressOf BackgroundWorker_RunWorkerCompleted
        backgroundWorker.WorkerReportsProgress = False
        backgroundWorker.RunWorkerAsync()
    End Sub

    Private Shared Sub BackgroundWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        ' Create temporary QueryBuilder instance
        Using sqlContext As New SQLContext()
            ' Create temporary MetadataProvider
            Using oledbMetadataProvider As New OLEDBMetadataProvider()
                ' Create connection to database
                oledbMetadataProvider.Connection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=demo.mdb")
                ' Set up the QueryBuilder
                sqlContext.MetadataProvider = oledbMetadataProvider
                sqlContext.SyntaxProvider = New MSAccessSyntaxProvider()
                ' Load metadata, force fields loading for all metadata objects
                sqlContext.MetadataContainer.LoadAll(True)

                ' Put copy of filled metadata container to worker result
                e.Result = sqlContext.MetadataContainer.Clone(sqlContext)
            End Using
        End Using
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        ' Assign filled metadata container to the main instance of the QueryBuilder
        queryBuilder.MetadataContainer.Assign(CType(e.Result, MetadataItem))
        ' Enable the control
        queryBuilder.Enabled = True
        queryBuilder.InitializeDatabaseSchemaTree()
    End Sub
End Class
