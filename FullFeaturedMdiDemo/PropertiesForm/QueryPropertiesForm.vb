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
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.PropertiesEditors
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.PropertiesEditors
Imports ActiveQueryBuilder.View.WinForms.DatabaseSchemaView
Imports ActiveQueryBuilder.View.WinForms.QueryView
Imports Helpers = FullFeaturedMdiDemo.Common.Helpers

Namespace PropertiesForm
	Friend Partial Class QueryPropertiesForm
		Inherits Form
		Private ReadOnly _childForm As ChildForm
        Private ReadOnly _dbView As DatabaseSchemaView

		Private ReadOnly _linkToPage1 As IDictionary(Of Control, UserControl) = New Dictionary(Of Control, UserControl)()
		Private ReadOnly _linkToPage2 As IDictionary(Of Control, UserControl) = New Dictionary(Of Control, UserControl)()

		Private _currentSelectedLink1 As LinkLabel
		Private _currentSelectedLink2 As LinkLabel

		Private Sub RegisterPropertyPage(link As Control, propertiesObject As ObjectProperties)
			Dim propertiesContainer As IPropertiesContainer = PropertiesFactory.GetPropertiesContainer(propertiesObject)

			' create property page control
			Dim propertyPage As PropertiesBar = New PropertiesBar()

			' set properties to property page
			Dim propertiesControl As IPropertiesControl = DirectCast(propertyPage, IPropertiesControl)
			propertiesControl.SetProperties(propertiesContainer)

			' register link -> propertyPage mapping
			_linkToPage1.Add(link, propertyPage)
		End Sub

		Public Sub New(sqlContext As SQLContext, childForm As ChildForm, dbView As DatabaseSchemaView)
			InitializeComponent()
			_childForm = childForm
            _dbView = dbView

			' non-visual options =======================
			' syntax page
			_linkToPage1.Add(linkSqlSyntax, New SqlSyntaxPage(sqlContext))
			' offline mode page
			_linkToPage1.Add(linkOfflineMode, New OfflineModePage(sqlContext, _dbView))

			' create and register property pages ==================================
			' BehaviorOptions page
			RegisterPropertyPage(linkBehaviorOptions, New ObjectProperties(_childForm.BehaviorOptions))
			' DatabaseSchemaViewOptions page
			RegisterPropertyPage(linkDatabaseSchemaView, New ObjectProperties(dbView.Options))
			' DesignPaneOptions page
			RegisterPropertyPage(linkDesignPane, New ObjectProperties(_childForm.DesignPaneOptions))
			' VisualOptions page
			RegisterPropertyPage(linkVisualOptions, New ObjectProperties(_childForm.VisualOptions))
			' AddObjectDialogOptions page
			RegisterPropertyPage(linkAddObjectDialog, New ObjectProperties(_childForm.AddObjectDialogOptions))
			' DatasourceOptions page
			RegisterPropertyPage(linkDatasourceOptions, New ObjectProperties(_childForm.DataSourceOptions))
			' MetadataLoadingOptions page
			RegisterPropertyPage(linkMetadataLoadingOptions, New ObjectProperties(_childForm.MetadataLoadingOptions))
			' MetadataStructureOptions page
			RegisterPropertyPage(linkMetadataStructureOptions, New ObjectProperties(_childForm.MetadataStructureOptions))
			' QueryColumnListOptions page
			RegisterPropertyPage(linkQueryColumnList, New ObjectProperties(_childForm.QueryColumnListOptions))
            ' QueryNavigationBarOptions page
            RegisterPropertyPage(LinkQueryNavBar, New ObjectProperties(_childForm.QueryNavBarOptions))
            ' UserInterfaceOptions page
            RegisterPropertyPage(LinkUserInterface, New ObjectProperties(_childForm.UserInterfaceOptions))
			' SQL Formatting options ============================
			' main query
			_linkToPage2.Add(linkMain, New MainQueryTab(_childForm.SQLFormattingOptions))
			_linkToPage2.Add(linkMainCommon, New CommonTab(_childForm.SQLFormattingOptions, _childForm.SQLFormattingOptions.MainQueryFormat))
			_linkToPage2.Add(linkMainExpressions, New ExpressionsTab(_childForm.SQLFormattingOptions, _childForm.SQLFormattingOptions.MainQueryFormat))
			' CTE query
			_linkToPage2.Add(linkCte, New SubQueryTab(_childForm.SQLFormattingOptions, SubQueryType.Cte))
			_linkToPage2.Add(linkCteCommon, New CommonTab(_childForm.SQLFormattingOptions, _childForm.SQLFormattingOptions.CTESubQueryFormat))
			_linkToPage2.Add(linkCteExpressions, New ExpressionsTab(_childForm.SQLFormattingOptions, _childForm.SQLFormattingOptions.CTESubQueryFormat))
			' Derived table
			_linkToPage2.Add(linkDerived, New SubQueryTab(_childForm.SQLFormattingOptions, SubQueryType.Derived))
			_linkToPage2.Add(linkDerivedCommon, New CommonTab(_childForm.SQLFormattingOptions, _childForm.SQLFormattingOptions.DerivedQueryFormat))
			_linkToPage2.Add(linkDerivedExpressions, New ExpressionsTab(_childForm.SQLFormattingOptions, _childForm.SQLFormattingOptions.DerivedQueryFormat))
			' expression
			_linkToPage2.Add(linkExpression, New SubQueryTab(_childForm.SQLFormattingOptions, SubQueryType.Expression))
			_linkToPage2.Add(linkExpressionCommon, New CommonTab(_childForm.SQLFormattingOptions, _childForm.SQLFormattingOptions.ExpressionSubQueryFormat))
			_linkToPage2.Add(linkExpressionExpressions, New ExpressionsTab(_childForm.SQLFormattingOptions, _childForm.SQLFormattingOptions.ExpressionSubQueryFormat))

			' Activate the first page on tab1
			SideMenu1_LinkClicked(linkSqlSyntax, New LinkLabelLinkClickedEventArgs(linkSqlSyntax.Links(0), MouseButtons.Left))
			' Activate the first page on tab2
			SideMenu2_LinkClicked(linkMain, New LinkLabelLinkClickedEventArgs(linkMain.Links(0), MouseButtons.Left))
		End Sub

		Private Sub QueryBuilderPropertiesForm_Paint(sender As Object, e As PaintEventArgs)
			Dim r As Rectangle = Rectangle.Inflate(panelQueryBuilder.Bounds, 1, 1)

			e.Graphics.DrawRectangle(SystemPens.ControlDark, r)
		End Sub

		Private Sub SideMenu1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkVisualOptions.LinkClicked, LinkUserInterface.LinkClicked, linkSqlSyntax.LinkClicked, LinkQueryNavBar.LinkClicked, linkQueryColumnList.LinkClicked, linkOfflineMode.LinkClicked, linkMetadataStructureOptions.LinkClicked, linkMetadataLoadingOptions.LinkClicked, linkDesignPane.LinkClicked, linkDatasourceOptions.LinkClicked, linkDatabaseSchemaView.LinkClicked, linkBehaviorOptions.LinkClicked, linkAddObjectDialog.LinkClicked  
			If _currentSelectedLink1 IsNot Nothing Then
				_currentSelectedLink1.LinkColor = Color.Black
			End If

			_currentSelectedLink1 = DirectCast(sender, LinkLabel)
			_currentSelectedLink1.LinkColor = Color.Blue

			SwitchPage1(_linkToPage1(_currentSelectedLink1))
		End Sub

		Private Sub SideMenu2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) 

        End Sub

		Private Sub flowLayoutPanel_Paint(sender As Object, e As PaintEventArgs) 

        End Sub

		Private Sub SwitchPage1(page As UserControl)
			panelPages1.SuspendLayout()
			panelPages1.AutoScrollPosition = New Point(0, 0)
			panelPages1.Controls.Clear()
			page.Location = New Point(10, 10)
			page.Dock = DockStyle.Fill
			panelPages1.Controls.Add(page)
			panelPages1.ResumeLayout()
		End Sub

		Private Sub SwitchPage2(page As UserControl)
			panelPages2.SuspendLayout()
			panelPages2.AutoScrollPosition = New Point(0, 0)
			panelPages2.Controls.Clear()
			page.Location = New Point(10, 10)
			page.Dock = DockStyle.Fill
			panelPages2.Controls.Add(page)
			panelPages2.ResumeLayout()
		End Sub

		Private Sub buttonLoad_Click(sender As Object, e As System.EventArgs) Handles buttonLoad.Click 
			Using dialog As OpenFileDialog = New OpenFileDialog()
				If dialog.ShowDialog() <> DialogResult.OK Then
					Return
				End If

				Dim queryBuilderOptionsXml As String = File.ReadAllText(dialog.FileName)
                Helpers.DeserializeOptions(queryBuilderOptionsXml,_dbView, _childForm)
			End Using
		End Sub

		Private Sub buttonSave_Click(sender As Object, e As System.EventArgs) Handles buttonSave.Click 
			Using dialog As SaveFileDialog = New SaveFileDialog()
				If dialog.ShowDialog() <> DialogResult.OK Then
					Return
				End If

			    Helpers.SerializeOptions(dialog.FileName, _dbView, _childForm)
			End Using
		End Sub
    End Class
End Namespace
