//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

Imports System.Reflection

Namespace Forms
	Partial Public Class AboutForm
		Inherits Form
		Public Sub New()
			InitializeComponent()

			lblQueryBuilderVersion.Text = "v" & GetType(QueryBuilder).Assembly.GetName().Version.ToString()
			lblDemoVersion.Text = "v" & System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
		End Sub

		Private Sub linkHome_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkHome.LinkClicked
			Process.Start("https://www.activequerybuilder.com/")
		End Sub

		Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
			Process.Start("http://www.famfamfam.com/lab/icons/silk/")
		End Sub
	End Class
End Namespace
