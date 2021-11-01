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
	Partial Public Class QueryBuilderPropertiesForm
		Inherits Form
		Private ReadOnly _queryBuilder As QueryBuilder

		Private ReadOnly _sqlSyntaxPage As SqlSyntaxPage
		Private ReadOnly _offlineModePage As OfflineModePage
		Private ReadOnly _panesVisibilityPage As PanesVisibilityPage
		Private ReadOnly _databaseSchemaViewPage As DatabaseSchemaViewPage
		Private ReadOnly _miscellaneousPage As MiscellaneousPage
		Private ReadOnly _generalPage As GeneralPage
		Private ReadOnly _mainQueryPage As SqlFormattingPage
		Private ReadOnly _derievedQueriesPage As SqlFormattingPage
		Private ReadOnly _expressionSubqueriesPage As SqlFormattingPage

		Private _currentSelectedLink As LinkLabel


		<DefaultValue(False), Browsable(False)>
		Public Property Modified() As Boolean
			Get
				Return _sqlSyntaxPage.Modified OrElse _offlineModePage.Modified OrElse _panesVisibilityPage.Modified OrElse _databaseSchemaViewPage.Modified OrElse _miscellaneousPage.Modified OrElse _generalPage.Modified OrElse _mainQueryPage.Modified OrElse _derievedQueriesPage.Modified OrElse _expressionSubqueriesPage.Modified
			End Get
			Set(value As Boolean)
				_sqlSyntaxPage.Modified = value
				_offlineModePage.Modified = value
				_panesVisibilityPage.Modified = value
				_databaseSchemaViewPage.Modified = value
				_miscellaneousPage.Modified = value
				_generalPage.Modified = value
				_mainQueryPage.Modified = value
				_derievedQueriesPage.Modified = value
				_expressionSubqueriesPage.Modified = value
			End Set
		End Property


		Public Sub New(queryBuilder As QueryBuilder)
			Debug.Assert(queryBuilder IsNot Nothing)

			InitializeComponent()

			_queryBuilder = queryBuilder

			Dim syntaxProvider As BaseSyntaxProvider = If(queryBuilder.SyntaxProvider IsNot Nothing, queryBuilder.SyntaxProvider.Clone(), New GenericSyntaxProvider())

			_sqlSyntaxPage = New SqlSyntaxPage(_queryBuilder, syntaxProvider)
			_offlineModePage = New OfflineModePage(_queryBuilder, syntaxProvider)

			_panesVisibilityPage = New PanesVisibilityPage(_queryBuilder)
			_databaseSchemaViewPage = New DatabaseSchemaViewPage(_queryBuilder)
			_miscellaneousPage = New MiscellaneousPage(_queryBuilder)

			_generalPage = New GeneralPage(_queryBuilder.SQLFormattingOptions)
			_mainQueryPage = New SqlFormattingPage(SqlBuilderOptionsPages.MainQuery, _queryBuilder.SQLFormattingOptions)
			_derievedQueriesPage = New SqlFormattingPage(SqlBuilderOptionsPages.DerivedQueries, _queryBuilder.SQLFormattingOptions)
			_expressionSubqueriesPage = New SqlFormattingPage(SqlBuilderOptionsPages.ExpressionSubqueries, _queryBuilder.SQLFormattingOptions)

			' Activate the first page
			SideMenu_LinkClicked(linkSqlSyntax, New LinkLabelLinkClickedEventArgs(linkSqlSyntax.Links(0), MouseButtons.Left))

			AddHandler Application.Idle, AddressOf Application_Idle
		End Sub

		Private Sub Application_Idle(sender As Object, e As EventArgs)
			buttonApply.Enabled = Me.Modified
		End Sub

		Private Sub QueryBuilderPropertiesForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
			Dim r As Rectangle = Rectangle.Inflate(panel1.Bounds, 1, 1)

			e.Graphics.DrawRectangle(SystemPens.ControlDark, r)
		End Sub

		Private Sub SideMenu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSqlSyntax.LinkClicked, linkOfflineMode.LinkClicked, linkPanesVisibility.LinkClicked, linkMetadataTree.LinkClicked, linkMiscellaneous.LinkClicked, linkGeneral.LinkClicked, linkMainQuery.LinkClicked, linkDerievedQueries.LinkClicked, linkExpressionSubqueries.LinkClicked
			If _currentSelectedLink IsNot Nothing Then
				_currentSelectedLink.LinkColor = Color.Black
			End If

			If sender Is linkSqlSyntax Then
				SwitchPage(_sqlSyntaxPage)
			ElseIf sender Is linkOfflineMode Then
				SwitchPage(_offlineModePage)
			ElseIf sender Is linkPanesVisibility Then
				SwitchPage(_panesVisibilityPage)
			ElseIf sender Is linkMetadataTree Then
				SwitchPage(_databaseSchemaViewPage)
			ElseIf sender Is linkMiscellaneous Then
				SwitchPage(_miscellaneousPage)
			ElseIf sender Is linkGeneral Then
				SwitchPage(_generalPage)
			ElseIf sender Is linkMainQuery Then
				SwitchPage(_mainQueryPage)
			ElseIf sender Is linkDerievedQueries Then
				SwitchPage(_derievedQueriesPage)
			ElseIf sender Is linkExpressionSubqueries Then
				SwitchPage(_expressionSubqueriesPage)
			End If

			_currentSelectedLink = CType(sender, LinkLabel)
			_currentSelectedLink.LinkColor = Color.Blue
		End Sub

		Private Sub buttonApply_Click(sender As Object, e As EventArgs) Handles buttonApply.Click
			ApplyChanges()
		End Sub

		Private Sub buttonOk_Click(sender As Object, e As EventArgs) Handles buttonOk.Click
			ApplyChanges()
		End Sub

		Private Sub flowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles flowLayoutPanel1.Paint
			Dim p As New Pen(SystemColors.ControlDark, 1)
			Dim first As New Point(flowLayoutPanel1.ClientRectangle.Right - 1, flowLayoutPanel1.ClientRectangle.Top + 10)
			Dim second As New Point(flowLayoutPanel1.ClientRectangle.Right - 1, flowLayoutPanel1.ClientRectangle.Bottom - 10)

			e.Graphics.DrawLine(p, first, second)
		End Sub

		Private Sub SwitchPage(page As UserControl)
			panelPages.SuspendLayout()
			panelPages.AutoScrollPosition = New Point(0, 0)
			panelPages.Controls.Clear()
			page.Location = New Point(10, 10)
			panelPages.Controls.Add(page)
			panelPages.ResumeLayout()
		End Sub

		Public Sub ApplyChanges()
			_queryBuilder.BeginUpdate()

			Try
				_sqlSyntaxPage.ApplyChanges()
				_offlineModePage.ApplyChanges()
				_panesVisibilityPage.ApplyChanges()
				_databaseSchemaViewPage.ApplyChanges()
				_miscellaneousPage.ApplyChanges()
				_generalPage.ApplyChanges()
				_mainQueryPage.ApplyChanges()
				_derievedQueriesPage.ApplyChanges()
				_expressionSubqueriesPage.ApplyChanges()
			Finally
				_queryBuilder.EndUpdate()
			End Try

			If _databaseSchemaViewPage.Modified OrElse _offlineModePage.Modified Then
				_queryBuilder.InitializeDatabaseSchemaTree()
			End If

			Me.Modified = False
		End Sub
	End Class
End Namespace
