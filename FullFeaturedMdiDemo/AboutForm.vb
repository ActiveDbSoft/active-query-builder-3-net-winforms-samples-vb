'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Diagnostics
Imports System.Reflection
Imports System.Windows.Forms
Imports ActiveQueryBuilder.View.WinForms

Public Partial Class AboutForm
	Inherits Form
	Public Sub New()
		InitializeComponent()

		lblQueryBuilderVersion.Text = "v" & Convert.ToString(GetType(QueryBuilder).Assembly.GetName().Version)
		lblDemoVersion.Text = "v" & Convert.ToString(Assembly.GetExecutingAssembly().GetName().Version)
	End Sub

	Private Sub linkHome_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
		Process.Start("https://www.activequerybuilder.com/")
	End Sub

	Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
		Process.Start("http://www.famfamfam.com/lab/icons/silk/")
	End Sub
End Class
