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
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms
Imports ActiveQueryBuilder.View.WinForms.DatabaseSchemaView

Namespace PropertiesForm
	<ToolboxItem(False)> _
	Friend Partial Class OfflineModePage
		Inherits UserControl
		Private ReadOnly _sqlContext As SQLContext
		Private ReadOnly _dbView As DatabaseSchemaView

		Public Sub New(sqlContext As SQLContext, dbView As DatabaseSchemaView)
			_sqlContext = sqlContext
		    _dbView = dbView

			InitializeComponent()

			cbOfflineMode.Checked = _sqlContext.LoadingOptions.OfflineMode

			UpdateMode()

			AddHandler cbOfflineMode.CheckedChanged, AddressOf checkOfflineMode_CheckedChanged
			AddHandler bEditMetadata.Click, AddressOf buttonEditMetadata_Click
			AddHandler bSaveToXML.Click, AddressOf buttonSaveToXML_Click
			AddHandler bLoadFromXML.Click, AddressOf buttonLoadFromXML_Click
			AddHandler bLoadMetadata.Click, AddressOf buttonLoadMetadata_Click
		End Sub

		Protected Overrides Sub Dispose(disposing As Boolean)
			RemoveHandler cbOfflineMode.CheckedChanged, AddressOf checkOfflineMode_CheckedChanged
			RemoveHandler bEditMetadata.Click, AddressOf buttonEditMetadata_Click
			RemoveHandler bSaveToXML.Click, AddressOf buttonSaveToXML_Click
			RemoveHandler bLoadFromXML.Click, AddressOf buttonLoadFromXML_Click
			RemoveHandler bLoadMetadata.Click, AddressOf buttonLoadMetadata_Click

			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If

			MyBase.Dispose(disposing)
		End Sub

		Private Sub checkOfflineMode_CheckedChanged(sender As Object, e As EventArgs)
			_sqlContext.LoadingOptions.OfflineMode = cbOfflineMode.Checked
			UpdateMode()
		End Sub

		Private Sub buttonLoadMetadata_Click(sender As Object, e As EventArgs)
			_sqlContext.MetadataContainer.BeginUpdate()

			Try
				Using f As New MetadataContainerLoadForm(_sqlContext.MetadataContainer)
					If f.ShowDialog() Then
						cbOfflineMode.Checked = True
						_dbView.InitializeDatabaseSchemaTree()
					End If
				End Using
			Finally
				_sqlContext.MetadataContainer.EndUpdate()
			End Try
		End Sub

		Private Sub UpdateMode()
			lMetadataObjectCount.Font = New Font(lMetadataObjectCount.Font, If((cbOfflineMode.Checked), FontStyle.Bold, FontStyle.Regular))
			bLoadFromXML.Enabled = cbOfflineMode.Checked
			bSaveToXML.Enabled = cbOfflineMode.Checked
			bEditMetadata.Enabled = cbOfflineMode.Checked

			UpdateMetadataStats()
		End Sub

		Private Sub UpdateMetadataStats()
			Dim metadataObjects As IEnumerable(Of MetadataObject) = _sqlContext.MetadataContainer.Items.GetItemsRecursive(Of MetadataObject)(MetadataType.Objects)

            Dim t As Integer = metadataObjects.Count(Function(i) i.Type = MetadataType.Table)
            Dim v As Integer = metadataObjects.Count(Function(i) i.Type = MetadataType.View)
            Dim p As Integer = metadataObjects.Count(Function(i) i.Type = MetadataType.Procedure)
            Dim s As Integer = metadataObjects.Count(Function(i) i.Type = MetadataType.Synonym)

            Const  tmp As String = "Loaded Metadata: {0} tables, {1} views, {2} procedures, {3} synonyms."
			lMetadataObjectCount.Text = String.Format(tmp, t, v, p, s)
		End Sub

		Private Sub buttonLoadFromXML_Click(sender As Object, e As EventArgs)
			If OpenDialog.ShowDialog() <> DialogResult.OK Then
				Return
			End If

			_sqlContext.MetadataContainer.ImportFromXML(OpenDialog.FileName)
			_dbView.InitializeDatabaseSchemaTree()
			UpdateMetadataStats()
		End Sub

		Private Sub buttonSaveToXML_Click(sender As Object, e As EventArgs)
			If SaveDialog.ShowDialog() <> DialogResult.OK Then
				Return
			End If

			_sqlContext.MetadataContainer.ExportToXML(SaveDialog.FileName)
		End Sub

		Private Sub buttonEditMetadata_Click(sender As Object, e As EventArgs)
            QueryBuilder.EditMetadataContainer(_sqlContext)
        End Sub
	End Class
End Namespace
