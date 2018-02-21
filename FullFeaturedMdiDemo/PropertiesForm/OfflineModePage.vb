'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms

Namespace PropertiesForm
	<ToolboxItem(False)> _
	Friend Partial Class OfflineModePage
		Inherits UserControl
		Private ReadOnly _metadataContainerCopy As MetadataContainer
		Private ReadOnly _sqlContext As SQLContext

		Public Property Modified() As Boolean
			Get
				Return m_Modified
			End Get
			Set
				m_Modified = Value
			End Set
		End Property
		Private m_Modified As Boolean


		Public Sub New(sqlContext As SQLContext)
			_sqlContext = sqlContext
			Modified = False


			_metadataContainerCopy = New MetadataContainer(_sqlContext)
			_metadataContainerCopy.Assign(_sqlContext.MetadataContainer)

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
			_metadataContainerCopy.Dispose()

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
				_sqlContext.LoadingOptions.OfflineMode = cbOfflineMode.Checked

				If _sqlContext.LoadingOptions.OfflineMode Then
					If _sqlContext.MetadataProvider IsNot Nothing Then
						_sqlContext.MetadataProvider.Disconnect()
					End If

					_sqlContext.MetadataContainer.Assign(_metadataContainerCopy)
				Else
					_sqlContext.MetadataContainer.Items.Clear()
				End If
			End If
		End Sub

		Private Sub checkOfflineMode_CheckedChanged(sender As Object, e As EventArgs)
			Modified = True
			UpdateMode()
		End Sub

		Private Sub buttonLoadMetadata_Click(sender As Object, e As EventArgs)
			_metadataContainerCopy.BeginUpdate()

			Try
				Using f As New MetadataContainerLoadForm(_metadataContainerCopy, False)
					If f.ShowDialog() = DialogResult.OK Then
						Modified = True
						cbOfflineMode.Checked = True
					End If
				End Using
			Finally
				_metadataContainerCopy.EndUpdate()
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
			Dim metadataObjects As List(Of MetadataObject) = _metadataContainerCopy.Items.GetItemsRecursive(Of MetadataObject)(MetadataType.Objects)
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
			Next

			Dim tmp As String = "Loaded Metadata: {0} tables, {1} views, {2} procedures, {3} synonyms."
			lMetadataObjectCount.Text = [String].Format(tmp, t, v, p, s)
		End Sub

		Private Sub buttonLoadFromXML_Click(sender As Object, e As EventArgs)
			If OpenDialog.ShowDialog() = DialogResult.OK Then
				_metadataContainerCopy.ImportFromXML(OpenDialog.FileName)
				Modified = True
				UpdateMetadataStats()
			End If
		End Sub

		Private Sub buttonSaveToXML_Click(sender As Object, e As EventArgs)
			If SaveDialog.ShowDialog() = DialogResult.OK Then
				_metadataContainerCopy.ExportToXML(SaveDialog.FileName)
			End If
		End Sub

		Private Sub buttonEditMetadata_Click(sender As Object, e As EventArgs)
			If QueryBuilder.EditMetadataContainer(_metadataContainerCopy, _sqlContext.MetadataStructure, _sqlContext.LoadingOptions) Then
				Modified = True
			End If
		End Sub
	End Class
End Namespace
