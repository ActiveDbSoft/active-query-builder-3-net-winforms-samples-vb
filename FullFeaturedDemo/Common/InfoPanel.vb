﻿'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Drawing
Imports System.Windows.Forms

Namespace Common
	Public Partial Class InfoPanel
		Inherits UserControl
		Public Property Message() As String

			Get
				Return label1.Text
			End Get
			Set
				label1.Text = value
				Visible = Not String.IsNullOrEmpty(value)
				If Visible Then
					AdjustLabel()
				End If
			End Set
		End Property

		Private Sub AdjustLabel()
			pictureBox1.Location = New Point(Width - pictureBox1.Width - 5, Height \ 2 - pictureBox1.Height \ 2)
		End Sub

		Public Sub New()
			InitializeComponent()
			Visible = False
		End Sub

		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			AdjustLabel()
		End Sub

		Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
			Message = ""
		End Sub
	End Class
End Namespace
