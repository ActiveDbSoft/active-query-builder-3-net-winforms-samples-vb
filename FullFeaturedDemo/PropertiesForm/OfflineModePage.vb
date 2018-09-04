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

<ToolboxItem(False)> _
Friend Partial Class OfflineModePage
	Inherits UserControl
    Private _sqlContext As SQLContext = Nothing
    Private _sqlContextCopy As SQLContext = Nothing
	Private _modified As Boolean = False


	Public Property Modified() As Boolean
		Get
			Return _modified
		End Get
		Set
			_modified = value
		End Set
	End Property


	Public Sub New(sqlContext As SQLContext)
		_sqlContext = sqlContext
        _sqlContextCopy = New SQLContext()
        _sqlContextCopy.Assign(sqlContext)

		InitializeComponent()

		cbOfflineMode.Checked = _sqlContextCopy.LoadingOptions.OfflineMode

		UpdateMode()

		AddHandler cbOfflineMode.CheckedChanged, AddressOf checkOfflineMode_CheckedChanged
		AddHandler bEditMetadata.Click, AddressOf buttonEditMetadata_Click
		AddHandler bSaveToXML.Click, AddressOf buttonSaveToXML_Click
		AddHandler bLoadFromXML.Click, AddressOf buttonLoadFromXML_Click
	End Sub

	Protected Overrides Sub Dispose(disposing As Boolean)
	    _sqlContextCopy.Dispose()

		RemoveHandler cbOfflineMode.CheckedChanged, AddressOf checkOfflineMode_CheckedChanged
		RemoveHandler bEditMetadata.Click, AddressOf buttonEditMetadata_Click
		RemoveHandler bSaveToXML.Click, AddressOf buttonSaveToXML_Click
		RemoveHandler bLoadFromXML.Click, AddressOf buttonLoadFromXML_Click

		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If

		MyBase.Dispose(disposing)
	End Sub

	Public Sub ApplyChanges()
		If Modified Then
		    _sqlContextCopy.LoadingOptions.OfflineMode = cbOfflineMode.Checked

			If _sqlContextCopy.LoadingOptions.OfflineMode Then
				If _sqlContextCopy.MetadataProvider IsNot Nothing Then
				    _sqlContextCopy.MetadataProvider.Disconnect()
				End If

				_sqlContext.Assign(_sqlContextCopy)
			Else
			    _sqlContext.MetadataContainer.Items.Clear()
			End If
		End If
	End Sub

	Private Sub checkOfflineMode_CheckedChanged(sender As Object, e As EventArgs)
		Modified = True
		UpdateMode()
	End Sub

	Private Sub UpdateMode()
		lMetadataObjectCount.Font = New Font(lMetadataObjectCount.Font, If((cbOfflineMode.Checked), FontStyle.Bold, FontStyle.Regular))
		bLoadFromXML.Enabled = cbOfflineMode.Checked
		bSaveToXML.Enabled = cbOfflineMode.Checked
		bEditMetadata.Enabled = cbOfflineMode.Checked

		UpdateMetadataStats()
	End Sub

	Private Sub UpdateMetadataStats()
		Dim metadataObjects As List(Of MetadataObject) = _sqlContextCopy.MetadataContainer.Items.GetItemsRecursive(Of MetadataObject)(MetadataType.Objects)
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
		    _sqlContextCopy.MetadataContainer.ImportFromXML(OpenDialog.FileName)
			Modified = True
			UpdateMetadataStats()
		End If
	End Sub

	Private Sub buttonSaveToXML_Click(sender As Object, e As EventArgs)
		If SaveDialog.ShowDialog() = DialogResult.OK Then
		    _sqlContextCopy.MetadataContainer.ExportToXML(SaveDialog.FileName)
		End If
	End Sub

	Private Sub buttonEditMetadata_Click(sender As Object, e As EventArgs)
		If QueryBuilder.EditMetadataContainer(_sqlContextCopy, _sqlContextCopy.LoadingOptions) Then
			Modified = True
		End If
	End Sub
End Class
