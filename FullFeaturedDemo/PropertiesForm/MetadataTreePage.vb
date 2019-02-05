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
Imports System.Globalization
Imports System.Windows.Forms
Imports ActiveQueryBuilder.View.DatabaseSchemaView
Imports ActiveQueryBuilder.View.WinForms

<ToolboxItem(False)> _
Friend Partial Class MetadataTreePage
	Inherits UserControl
	Private ReadOnly _queryBuilder As QueryBuilder
	Private _modified As Boolean = False


	Public Property Modified() As Boolean
		Get
			Return _modified
		End Get
		Set
			_modified = value
		End Set
	End Property


	Public Sub New(queryBuilder As QueryBuilder)
		_queryBuilder = queryBuilder

		InitializeComponent()

		cbGroupByServers.Checked = queryBuilder.MetadataStructure.Options.GroupByServers
		cbGroupByDatabases.Checked = queryBuilder.MetadataStructure.Options.GroupByDatabases
		cbGroupBySchemas.Checked = queryBuilder.MetadataStructure.Options.GroupBySchemas
		cbGroupByTypes.Checked = queryBuilder.MetadataStructure.Options.GroupByTypes
		cbShowFields.Checked = queryBuilder.MetadataStructure.Options.ShowFields

        cmbSortObjectsBy.Items.Add("Sort by Name")
        cmbSortObjectsBy.Items.Add("Sort by Type, Name")
        cmbSortObjectsBy.Items.Add("No sorting")
        cmbSortObjectsBy.SelectedIndex = CInt(queryBuilder.DatabaseSchemaViewOptions.SortingType)

        cmbDefaultExpandLevel.Text = queryBuilder.DatabaseSchemaViewOptions.DefaultExpandLevel.ToString(CultureInfo.InvariantCulture)

		AddHandler cbGroupByServers.CheckedChanged, AddressOf Changed
		AddHandler cbGroupByDatabases.CheckedChanged, AddressOf Changed
		AddHandler cbGroupBySchemas.CheckedChanged, AddressOf Changed
		AddHandler cbGroupByTypes.CheckedChanged, AddressOf Changed
		AddHandler cbShowFields.CheckedChanged, AddressOf Changed
		AddHandler cmbSortObjectsBy.SelectedIndexChanged, AddressOf Changed
		AddHandler cmbDefaultExpandLevel.SelectedIndexChanged, AddressOf Changed
	End Sub

	Protected Overrides Sub Dispose(disposing As Boolean)
		RemoveHandler cbGroupByServers.CheckedChanged, AddressOf Changed
		RemoveHandler cbGroupByDatabases.CheckedChanged, AddressOf Changed
		RemoveHandler cbGroupBySchemas.CheckedChanged, AddressOf Changed
		RemoveHandler cbGroupByTypes.CheckedChanged, AddressOf Changed
		RemoveHandler cbShowFields.CheckedChanged, AddressOf Changed
		RemoveHandler cmbSortObjectsBy.SelectedIndexChanged, AddressOf Changed
		RemoveHandler cmbDefaultExpandLevel.SelectedIndexChanged, AddressOf Changed

		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If

		MyBase.Dispose(disposing)
	End Sub

	Public Sub ApplyChanges()
		If Modified Then
			_queryBuilder.MetadataStructure.Options.BeginUpdate()

			Try
				_queryBuilder.MetadataStructure.Options.GroupByServers = cbGroupByServers.Checked
				_queryBuilder.MetadataStructure.Options.GroupByDatabases = cbGroupByDatabases.Checked
				_queryBuilder.MetadataStructure.Options.GroupBySchemas = cbGroupBySchemas.Checked
				_queryBuilder.MetadataStructure.Options.GroupByTypes = cbGroupByTypes.Checked
				_queryBuilder.MetadataStructure.Options.ShowFields = cbShowFields.Checked
				_queryBuilder.DatabaseSchemaViewOptions.SortingType = CType(cmbSortObjectsBy.SelectedIndex, ObjectsSortingType)

				Dim defaultExpandLevel As Integer
				If Integer.TryParse(cmbDefaultExpandLevel.Text, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, defaultExpandLevel) Then
                    _queryBuilder.DatabaseSchemaViewOptions.DefaultExpandLevel = defaultExpandLevel
				End If
			Finally
				_queryBuilder.MetadataStructure.Options.EndUpdate()
			End Try
		End If
	End Sub

	Private Sub Changed(sender As Object, e As EventArgs)
		Modified = True
	End Sub
End Class
