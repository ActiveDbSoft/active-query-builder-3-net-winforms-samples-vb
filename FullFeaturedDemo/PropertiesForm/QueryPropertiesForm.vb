'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core

Namespace PropertiesForm
	Friend Partial Class QueryPropertiesForm
		Inherits Form
		Private ReadOnly _sqlSyntaxPage As SqlSyntaxPage
		Private ReadOnly _offlineModePage As OfflineModePage
		Private ReadOnly _generalPage As GeneralPage
		Private ReadOnly _mainQueryPage As SqlFormattingPage
		Private ReadOnly _derievedQueriesPage As SqlFormattingPage
		Private ReadOnly _expressionSubqueriesPage As SqlFormattingPage

		Private _currentSelectedLink As LinkLabel


		<DefaultValue(False)> _
		<Browsable(False)> _
		Public Property Modified() As Boolean
			Get
				Return _sqlSyntaxPage.Modified OrElse _offlineModePage.Modified OrElse _generalPage.Modified OrElse _mainQueryPage.Modified OrElse _derievedQueriesPage.Modified OrElse _expressionSubqueriesPage.Modified
			End Get
			Set
				_sqlSyntaxPage.Modified = value
				_offlineModePage.Modified = value

				_generalPage.Modified = value
				_mainQueryPage.Modified = value
				_derievedQueriesPage.Modified = value
				_expressionSubqueriesPage.Modified = value
			End Set
		End Property


		Public Sub New(sqlContext As SQLContext, sqlFormattingOptions As SQLFormattingOptions)
			InitializeComponent()

			Dim syntaxProvider = If(sqlContext.SyntaxProvider IsNot Nothing, sqlContext.SyntaxProvider.Clone(), New GenericSyntaxProvider())

			_sqlSyntaxPage = New SqlSyntaxPage(sqlContext, syntaxProvider)
			_offlineModePage = New OfflineModePage(sqlContext)


			_generalPage = New GeneralPage(sqlFormattingOptions)
			_mainQueryPage = New SqlFormattingPage(SqlBuilderOptionsPages.MainQuery, sqlFormattingOptions)
			_derievedQueriesPage = New SqlFormattingPage(SqlBuilderOptionsPages.DerievedQueries, sqlFormattingOptions)
			_expressionSubqueriesPage = New SqlFormattingPage(SqlBuilderOptionsPages.ExpressionSubqueries, sqlFormattingOptions)

			' Activate the first page
			SideMenu_LinkClicked(linkSqlSyntax, New LinkLabelLinkClickedEventArgs(linkSqlSyntax.Links(0), MouseButtons.Left))

			AddHandler Application.Idle, AddressOf Application_Idle
		End Sub

		Private Sub Application_Idle(sender As Object, e As EventArgs)
			buttonApply.Enabled = Modified
		End Sub

		Private Sub QueryBuilderPropertiesForm_Paint(sender As Object, e As PaintEventArgs)
			Dim r As Rectangle = Rectangle.Inflate(panel1.Bounds, 1, 1)

			e.Graphics.DrawRectangle(SystemPens.ControlDark, r)
		End Sub

		Private Sub SideMenu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			If _currentSelectedLink IsNot Nothing Then
				_currentSelectedLink.LinkColor = Color.Black
			End If

			If sender Is linkSqlSyntax Then
				SwitchPage(_sqlSyntaxPage)
			ElseIf sender Is linkOfflineMode Then
				SwitchPage(_offlineModePage)
			ElseIf sender Is linkGeneral Then
				SwitchPage(_generalPage)
			ElseIf sender Is linkMainQuery Then
				SwitchPage(_mainQueryPage)
			ElseIf sender Is linkDerievedQueries Then
				SwitchPage(_derievedQueriesPage)
			ElseIf sender Is linkExpressionSubqueries Then
				SwitchPage(_expressionSubqueriesPage)
			End If

			_currentSelectedLink = DirectCast(sender, LinkLabel)
			_currentSelectedLink.LinkColor = Color.Blue
		End Sub

		Private Sub buttonApply_Click(sender As Object, e As EventArgs)
			ApplyChanges()
		End Sub

		Private Sub buttonOk_Click(sender As Object, e As EventArgs)
			ApplyChanges()
		End Sub

		Private Sub flowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)
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
			_sqlSyntaxPage.ApplyChanges()
			_offlineModePage.ApplyChanges()
			_generalPage.ApplyChanges()
			_mainQueryPage.ApplyChanges()
			_derievedQueriesPage.ApplyChanges()
			_expressionSubqueriesPage.ApplyChanges()

			Modified = False
		End Sub
	End Class
End Namespace
