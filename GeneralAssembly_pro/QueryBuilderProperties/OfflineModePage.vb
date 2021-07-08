''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2021 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.ComponentModel
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms

Namespace QueryBuilderProperties
	<ToolboxItem(False)>
	Partial Friend Class OfflineModePage
		Inherits UserControl
		Private _queryBuilder As QueryBuilder = Nothing
		Private _sqlContext As SQLContext
		Private _syntaxProvider As BaseSyntaxProvider = Nothing
		Private _modified As Boolean = False


		Public Property Modified() As Boolean
			Get
				Return _modified
			End Get
			Set(value As Boolean)
				_modified = value
			End Set
		End Property


		Public Sub New(queryBuilder As QueryBuilder, syntaxProvider As BaseSyntaxProvider)
			_queryBuilder = queryBuilder
			_syntaxProvider = syntaxProvider

			_sqlContext = New SQLContext()
			_sqlContext.Assign(queryBuilder.SQLContext)

			InitializeComponent()

			cbOfflineMode.Checked = queryBuilder.MetadataLoadingOptions.OfflineMode

			UpdateMode()

			AddHandler cbOfflineMode.CheckedChanged, AddressOf checkOfflineMode_CheckedChanged
			AddHandler bEditMetadata.Click, AddressOf buttonEditMetadata_Click
			AddHandler bSaveToXML.Click, AddressOf buttonSaveToXML_Click
			AddHandler bLoadFromXML.Click, AddressOf buttonLoadFromXML_Click
			AddHandler bLoadMetadata.Click, AddressOf buttonLoadMetadata_Click
		End Sub

		Protected Overrides Overloads Sub Dispose(disposing As Boolean)
			_sqlContext.Dispose()

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

		Public Sub ApplyChanges()
			If Modified Then
				_queryBuilder.MetadataLoadingOptions.OfflineMode = cbOfflineMode.Checked

				If _queryBuilder.MetadataLoadingOptions.OfflineMode Then
					If _queryBuilder.MetadataProvider IsNot Nothing Then
						_queryBuilder.MetadataProvider.Disconnect()
					End If

					_queryBuilder.SQLContext.Assign(_sqlContext)
				Else
					_queryBuilder.MetadataContainer.Items.Clear()
				End If
			End If
		End Sub

		Private Sub checkOfflineMode_CheckedChanged(sender As Object, e As EventArgs)
			Modified = True
			UpdateMode()
		End Sub

		Private Sub buttonLoadMetadata_Click(sender As Object, e As EventArgs)
			_sqlContext.MetadataContainer.BeginUpdate()
			Try
				Using f As New MetadataContainerLoadForm(_sqlContext.MetadataContainer)
					If f.ShowDialog() Then
						Modified = True
						cbOfflineMode.Checked = True
					End If
				End Using
			Finally
				_sqlContext.MetadataContainer.EndUpdate()
			End Try
		End Sub

		Private Sub UpdateMode()
			lMetadataObjectCount.Font = New Font(lMetadataObjectCount.Font,If(cbOfflineMode.Checked, FontStyle.Bold, FontStyle.Regular))
			bLoadFromXML.Enabled = cbOfflineMode.Checked
			bSaveToXML.Enabled = cbOfflineMode.Checked
			bEditMetadata.Enabled = cbOfflineMode.Checked

			UpdateMetadataStats()
		End Sub

		Private Sub UpdateMetadataStats()
			Dim metadataObjects As List(Of MetadataObject) = _sqlContext.MetadataContainer.Items.GetItemsRecursive(Of MetadataObject)(MetadataType.Objects)
			Dim t As Integer = 0, v As Integer = 0, p As Integer = 0, s As Integer = 0

			For i As Integer = 0 To metadataObjects.Count - 1
				Dim mo As MetadataObject = metadataObjects(i)

				If mo.Type = MetadataType.Table Then
					t += 1
				ElseIf mo.Type = MetadataType.View Then
					v += 1
				ElseIf mo.Type = MetadataType.Procedure Then
					p += 1
				ElseIf mo.Type = MetadataType.Synonym Then
					s += 1
				End If
			Next i

			Dim tmp As String = "Loaded Metadata: {0} tables, {1} views, {2} procedures, {3} synonyms."
			lMetadataObjectCount.Text = String.Format(tmp, t, v, p, s)
		End Sub

		Private Sub buttonLoadFromXML_Click(sender As Object, e As EventArgs)
			If OpenDialog.ShowDialog() = DialogResult.OK Then
				_sqlContext.MetadataContainer.ImportFromXML(OpenDialog.FileName)
				Modified = True
				UpdateMetadataStats()
			End If
		End Sub

		Private Sub buttonSaveToXML_Click(sender As Object, e As EventArgs)
			If SaveDialog.ShowDialog() = DialogResult.OK Then
				_sqlContext.MetadataContainer.ExportToXML(SaveDialog.FileName)
			End If
		End Sub

		Private Sub buttonEditMetadata_Click(sender As Object, e As EventArgs)
			If QueryBuilder.EditMetadataContainer(_sqlContext) Then
				Modified = True
			End If
		End Sub
	End Class
End Namespace
