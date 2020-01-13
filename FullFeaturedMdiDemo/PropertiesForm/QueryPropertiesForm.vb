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
Imports System.Text
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.PropertiesEditors
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.ExpressionEditor
Imports ActiveQueryBuilder.View.PropertiesEditors
Imports ActiveQueryBuilder.View.WinForms.DatabaseSchemaView
Imports ActiveQueryBuilder.View.WinForms.ExpressionEditor
Imports ActiveQueryBuilder.View.WinForms.QueryView
Imports Helpers = FullFeaturedMdiDemo.Common.Helpers

Namespace PropertiesForm
	Friend Partial Class QueryPropertiesForm
		Inherits Form
		Private ReadOnly _linkToPage1 As IDictionary(Of Control, UserControl) = New Dictionary(Of Control, UserControl)()
		Private ReadOnly _linkToPage2 As IDictionary(Of Control, UserControl) = New Dictionary(Of Control, UserControl)()

		Private _currentSelectedLink1 As LinkLabel
		Private _currentSelectedLink2 As LinkLabel

		Private ReadOnly _childForm As ChildForm
		Private ReadOnly _dbView As DatabaseSchemaView
		Private ReadOnly _textEditorOptions As New TextEditorOptions()
		Private ReadOnly _textEditorSqlOptions As New SqlTextEditorOptions()

		Private _structureOptionsChanged As Boolean = False

		Private Sub RegisterPropertyPage(link As Control, propertiesObject As ObjectProperties)
			Dim propertiesContainer As IPropertiesContainer = PropertiesFactory.GetPropertiesContainer(propertiesObject)

			' create property page control
			Dim propertyPage As PropertiesBar = New PropertiesBar()
            propertyPage.EditorsOptions.WideEditControlsMaxWidth = 225
            propertyPage.EditorsOptions.WideEditControlsMinWidth = 100
            propertyPage.EditorsOptions.ShowDescriptions = True
			' set properties to property page
			Dim propertiesControl as IPropertiesControl = DirectCast(propertyPage, IPropertiesControl)
			propertiesControl.SetProperties(propertiesContainer)

			' register link -> propertyPage mapping
			_linkToPage1.Add(link, propertyPage)
		End Sub

		Public Sub New(childForm As ChildForm, dbView As DatabaseSchemaView)
			InitializeComponent()
			LocalizeGroups()
			_childForm = childForm
			_dbView = dbView

			_linkToPage1.Add(linkSqlGeneration, New SqlGenerationPage(childForm.SqlGenerationOptions, childForm.SqlFormattingOptions))

			' create and register property pages ==================================
			' BehaviorOptions page
			RegisterPropertyPage(linkBehaviorOptions, New ObjectProperties(childForm.BehaviorOptions))
			' DatabaseSchemaViewOptions page
			RegisterPropertyPage(linkDatabaseSchemaView, New ObjectProperties(dbView.Options))
			' DesignPaneOptions page
			RegisterPropertyPage(linkDesignPane, New ObjectProperties(childForm.DesignPaneOptions))
			' VisualOptions page
			RegisterPropertyPage(linkVisualOptions, New ObjectProperties(childForm.VisualOptions))
			' AddObjectDialogOptions page
			RegisterPropertyPage(linkAddObjectDialog, New ObjectProperties(childForm.AddObjectDialogOptions))
			' DataSourceOptions page
			RegisterPropertyPage(linkDatasourceOptions, New ObjectProperties(childForm.DataSourceOptions))
			' QueryColumnListOptions page
			RegisterPropertyPage(linkQueryColumnList, New ObjectProperties(childForm.QueryColumnListOptions))
			' QueryNavBarOptions
			RegisterPropertyPage(linkQueryNavBar, New ObjectProperties(childForm.QueryNavBarOptions))
			' UserInterfaceOptions
			RegisterPropertyPage(linkQueryView, New ObjectProperties(childForm.UserInterfaceOptions))

			RegisterPropertyPage(lbExpressionEditor, New ObjectProperties(childForm.ExpressionEditorOptions))

			_textEditorOptions.Assign(CType(childForm.TextEditorOptions, ITextEditorOptions))
			AddHandler _textEditorOptions.Updated, AddressOf TextEditorOptionsOnUpdated
			RegisterPropertyPage(lbTextEditor, New ObjectProperties(_textEditorOptions))

			_textEditorSqlOptions.Assign(CType(childForm.TextEditorSqlOptions, ISqlTextEditorOptions))
			AddHandler _textEditorSqlOptions.Updated, AddressOf TextEditorOptionsOnUpdated
			RegisterPropertyPage(lbTextEditorSql, New ObjectProperties(_textEditorSqlOptions))

			AddHandler childForm.MetadataStructureOptions.Updated, AddressOf MetadataStructureOptionsOnUpdated

			' SQL Formatting options ============================
			' main query
			_linkToPage2.Add(linkMain, New MainQueryTab(childForm.SqlFormattingOptions))
			_linkToPage2.Add(linkMainCommon, New CommonTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.MainQueryFormat))
			_linkToPage2.Add(linkMainExpressions, New ExpressionsTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.MainQueryFormat))
			' CTE query
			_linkToPage2.Add(linkCte, New SubQueryTab(childForm.SqlFormattingOptions, SubQueryType.Cte))
			_linkToPage2.Add(linkCteCommon, New CommonTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.CTESubQueryFormat))
			_linkToPage2.Add(linkCteExpressions, New ExpressionsTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.CTESubQueryFormat))
			' Derived table
			_linkToPage2.Add(linkDerived, New SubQueryTab(childForm.SqlFormattingOptions, SubQueryType.Derived))
			_linkToPage2.Add(linkDerivedCommon, New CommonTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.DerivedQueryFormat))
			_linkToPage2.Add(linkDerivedExpressions, New ExpressionsTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.DerivedQueryFormat))
			' expression
			_linkToPage2.Add(linkExpression, New SubQueryTab(childForm.SqlFormattingOptions, SubQueryType.Expression))
			_linkToPage2.Add(linkExpressionCommon, New CommonTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.ExpressionSubQueryFormat))
			_linkToPage2.Add(linkExpressionExpressions, New ExpressionsTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.ExpressionSubQueryFormat))

			' Activate the first page on tab1
			SideMenu1_LinkClicked(linkSqlGeneration, New LinkLabelLinkClickedEventArgs(linkSqlGeneration.Links(0), MouseButtons.Left))
			' Activate the first page on tab2
			SideMenu2_LinkClicked(linkMain, New LinkLabelLinkClickedEventArgs(linkMain.Links(0), MouseButtons.Left))
		End Sub

		Private Sub LocalizeGroups()
			Dim localizer = ActiveQueryBuilder.Core.Helpers.Localizer
			linkBehaviorOptions.Text = localizer.GetString("strBehaviorOptions", LocalizableConstantsInternal.strBehaviorOptions)
			linkDatabaseSchemaView.Text = localizer.GetString("strDatabaseSchemaViewOptions", LocalizableConstantsInternal.strDatabaseSchemaViewOptions)
			linkDesignPane.Text = localizer.GetString("strDesignPaneOptions", LocalizableConstantsInternal.strDesignPaneOptions)
			linkVisualOptions.Text = localizer.GetString("strVisualOptions", LocalizableConstantsInternal.strVisualOptions)
			linkAddObjectDialog.Text = localizer.GetString("strAddObjectDialogOptions", LocalizableConstantsInternal.strAddObjectDialogOptions)
			linkQueryColumnList.Text = localizer.GetString("strQueryColumnListOptions", LocalizableConstantsInternal.strQueryColumnListOptions)
			linkQueryNavBar.Text = localizer.GetString("strQueryNavbarOptions", LocalizableConstantsInternal.strQueryNavbarOptions)
			linkQueryView.Text = localizer.GetString("strUserInterfaceOptions", LocalizableConstantsInternal.strUserInterfaceOptions)
			lbExpressionEditor.Text = localizer.GetString("strExpressionEditorOptions", LocalizableConstantsInternal.strExpressionEditorOptions)
			lbTextEditor.Text = localizer.GetString("strTextEditorOptions", LocalizableConstantsInternal.strTextEditorOptions)
			lbTextEditorSql.Text = localizer.GetString("strTextEditorSqlOptions", LocalizableConstantsInternal.strTextEditorSqlOptions)
		End Sub

		Private Sub MetadataStructureOptionsOnUpdated(sender As Object, eventArgs As EventArgs)
			_structureOptionsChanged = True
		End Sub

		Private Sub TextEditorOptionsOnUpdated(sender As Object, eventArgs As EventArgs)
			_childForm.TextEditorOptions = _textEditorOptions
			_childForm.TextEditorSqlOptions = _textEditorSqlOptions
		End Sub

		Private Sub QueryBuilderPropertiesForm_Paint(sender As Object, e As PaintEventArgs)
			Dim r As Rectangle = Rectangle.Inflate(panelQueryBuilder.Bounds, 1, 1)

			e.Graphics.DrawRectangle(SystemPens.ControlDark, r)
		End Sub

		Private Sub SideMenu1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			If _currentSelectedLink1 IsNot Nothing Then
				_currentSelectedLink1.LinkColor = Color.Black
			End If

			_currentSelectedLink1 = DirectCast(sender, LinkLabel)
			_currentSelectedLink1.LinkColor = Color.Blue

			SwitchPage1(_linkToPage1(_currentSelectedLink1))
		End Sub

		Private Sub SideMenu2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			If _currentSelectedLink2 IsNot Nothing Then
				_currentSelectedLink2.LinkColor = Color.Black
			End If

			_currentSelectedLink2 = DirectCast(sender, LinkLabel)
			_currentSelectedLink2.LinkColor = Color.Blue

			SwitchPage2(_linkToPage2(_currentSelectedLink2))
		End Sub

		Private Sub flowLayoutPanel_Paint(sender As Object, e As PaintEventArgs)
			Dim p As New Pen(SystemColors.ControlDark, 1)
			Dim first As New Point(flowLayoutPanel1.ClientRectangle.Right - 1, flowLayoutPanel1.ClientRectangle.Top + 10)
			Dim second As New Point(flowLayoutPanel1.ClientRectangle.Right - 1, flowLayoutPanel1.ClientRectangle.Bottom - 10)

			e.Graphics.DrawLine(p, first, second)
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

		Private Sub buttonLoad_Click(sender As Object, e As System.EventArgs)
			Using dialog = New OpenFileDialog()
				If dialog.ShowDialog() <> DialogResult.OK Then
					Return
				End If

				Dim options = _childForm.GetOptions()
				options.DeserializeFromFile(dialog.FileName)
			End Using
		End Sub

		Private Sub buttonSave_Click(sender As Object, e As System.EventArgs)
			Using catalog = New SaveFileDialog()
				If catalog.ShowDialog() <> DialogResult.OK Then
					Return
				End If

				Dim options = _childForm.GetOptions()
				options.SerializeToFile(catalog.FileName)
			End Using
		End Sub

		Private Sub QueryPropertiesForm_FormClosing(sender As Object, e As FormClosingEventArgs)
			Program.Settings.Options = _childForm.GetOptions().SerializeToString()
			Program.Settings.Save()

			_childForm.TextEditorOptions = _textEditorOptions
			_childForm.TextEditorSqlOptions = _textEditorSqlOptions
			If _structureOptionsChanged Then
				_dbView.InitializeDatabaseSchemaTree()
			End If
		End Sub
	End Class
End Namespace
