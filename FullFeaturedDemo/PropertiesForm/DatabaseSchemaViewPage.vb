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
Imports System.Linq
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.DatabaseSchemaView
Imports ActiveQueryBuilder.View.WinForms

Namespace PropertiesForm


    <ToolboxItem(False)>
    Partial Friend Class DatabaseSchemaViewPage
        Inherits UserControl

        Private ReadOnly _queryBuilder As QueryBuilder
        Private _modified As Boolean = False
        Private _expandMetadataType As MetadataType

        Public Property Modified As Boolean
            Get
                Return _modified
            End Get
            Set
                _modified = Value
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
            AddHandler cbGroupByServers.CheckedChanged, AddressOf Changed
            AddHandler cbGroupByDatabases.CheckedChanged, AddressOf Changed
            AddHandler cbGroupBySchemas.CheckedChanged, AddressOf Changed
            AddHandler cbGroupByTypes.CheckedChanged, AddressOf Changed
            AddHandler cbShowFields.CheckedChanged, AddressOf Changed
            AddHandler cmbSortObjectsBy.SelectedIndexChanged, AddressOf Changed
            AddHandler cbDefaultExpandType.ItemChecked, AddressOf CbDefaultExpandTypeOnItemChecked
            _expandMetadataType = queryBuilder.DatabaseSchemaView.Options.DefaultExpandMetadataType
            FillComboBox(GetType(MetadataType))
            SetExpandType(queryBuilder.DatabaseSchemaView.Options.DefaultExpandMetadataType)
        End Sub

        Private Sub CbDefaultExpandTypeOnItemChecked(sender As Object, eventArgs As EventArgs)
            _expandMetadataType = GetExpandType()
            cbDefaultExpandType.Text = _expandMetadataType.ToString
            Changed(Me, EventArgs.Empty)
        End Sub

        Protected Overrides Sub Dispose(disposing As Boolean)
            RemoveHandler cbGroupByServers.CheckedChanged, AddressOf Changed
            RemoveHandler cbGroupByDatabases.CheckedChanged, AddressOf Changed
            RemoveHandler cbGroupBySchemas.CheckedChanged, AddressOf Changed
            RemoveHandler cbGroupByTypes.CheckedChanged, AddressOf Changed
            RemoveHandler cbShowFields.CheckedChanged, AddressOf Changed
            RemoveHandler cmbSortObjectsBy.SelectedIndexChanged, AddressOf Changed
            RemoveHandler cbDefaultExpandType.ItemChecked, AddressOf CbDefaultExpandTypeOnItemChecked

            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Public Sub ApplyChanges()
            If Modified Then
                Dim metadataStructureOptions As MetadataStructureOptions = _queryBuilder.MetadataStructure.Options
                metadataStructureOptions.BeginUpdate()

                Try
                    metadataStructureOptions.GroupByServers = cbGroupByServers.Checked
                    metadataStructureOptions.GroupByDatabases = cbGroupByDatabases.Checked
                    metadataStructureOptions.GroupBySchemas = cbGroupBySchemas.Checked
                    metadataStructureOptions.GroupByTypes = cbGroupByTypes.Checked
                    metadataStructureOptions.ShowFields = cbShowFields.Checked
                Finally
                    metadataStructureOptions.EndUpdate()
                End Try

                Dim databaseSchemaViewOptions As DatabaseSchemaViewOptions = _queryBuilder.DatabaseSchemaViewOptions
                databaseSchemaViewOptions.BeginUpdate()

                Try
                    databaseSchemaViewOptions.SortingType = CType(cmbSortObjectsBy.SelectedIndex, ObjectsSortingType)
                    databaseSchemaViewOptions.DefaultExpandMetadataType = GetExpandType()
                Finally
                    databaseSchemaViewOptions.EndUpdate()
                End Try
            End If
        End Sub

        Private Sub Changed(sender As Object, e As EventArgs)
            Modified = True
        End Sub

        Private Sub FillComboBox(enumType As Type)
            Dim flags As List(Of [Enum]) = GetFlagsFromType(enumType)

            For Each flag As [Enum] In flags
                cbDefaultExpandType.Items.Add(flag)
            Next
        End Sub

        Private Function GetFlagsFromType(enumType As Type) As List(Of [Enum])
            Dim values As Array = [Enum].GetValues(enumType)
            Dim result As List(Of [Enum]) = New List(Of [Enum])

            For Each value As Object In values
                If IsDegreeOf2(CType(value, Integer)) Then result.Add(CType(value, [Enum]))
            Next

            Return result
        End Function

        Private Function IsDegreeOf2(n As Integer) As Boolean
            Return n <> 0 AndAlso (n And n - 1) = 0
        End Function

        Private Function GetExpandType() As MetadataType
            Dim intValue As Integer = CInt(_expandMetadataType)

            For i As Integer = 0 To cbDefaultExpandType.Items.Count - 1

                If cbDefaultExpandType.IsItemChecked(i) Then
                    intValue = intValue Or CInt(cbDefaultExpandType.Items(i))
                Else
                    intValue = intValue And Not CInt(cbDefaultExpandType.Items(i))
                End If
            Next

            Return CType(intValue, MetadataType)
        End Function

        Private Sub SetExpandType(value As Object)
            cbDefaultExpandType.ClearCheckedItems()
            Dim decomposed As List(Of Integer) = DecomposeEnum(value)

            For i As Integer = 0 To cbDefaultExpandType.Items.Count - 1
                If decomposed.Contains(CInt(cbDefaultExpandType.Items(i))) Then cbDefaultExpandType.SetItemChecked(i, True)
            Next
        End Sub

        Private Function DecomposeEnum(value As Object) As List(Of Integer)
            Dim binary As List(Of Char) = Convert.ToString(CInt(value), 2).Reverse.ToList
            Dim result As List(Of Integer) = New List(Of Integer)

            For i As Integer = 0 To binary.Count - 1
                If binary(i) = "1"c Then result.Add(CType(Math.Pow(2, i), Integer))
            Next

            Return result
        End Function
    End Class
End Namespace
