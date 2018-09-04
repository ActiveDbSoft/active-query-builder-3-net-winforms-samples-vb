﻿'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.ComponentModel
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core

Namespace PropertiesForm
	<ToolboxItem(False)> _
	Friend Partial Class GeneralPage
		Inherits UserControl
		Private ReadOnly _sqlFormattingOptions As SQLFormattingOptions

		Public Property Modified() As Boolean
			Get
				Return m_Modified
			End Get
			Set
				m_Modified = Value
			End Set
		End Property
		Private m_Modified As Boolean


		Public Sub New(sqlFormattingOptions As SQLFormattingOptions)
			Modified = False
			_sqlFormattingOptions = sqlFormattingOptions

			InitializeComponent()

			cbWordWrap.Checked = (_sqlFormattingOptions.RightMargin <> 0)
			updownRightMargin.Enabled = cbWordWrap.Checked

			updownRightMargin.Value = If(_sqlFormattingOptions.RightMargin = 0, 80, _sqlFormattingOptions.RightMargin)

			comboKeywordsCasing.Items.Add("Capitalized")
			comboKeywordsCasing.Items.Add("Uppercase")
			comboKeywordsCasing.Items.Add("Lowercase")

			comboKeywordsCasing.SelectedIndex = CInt(_sqlFormattingOptions.KeywordFormat)

			AddHandler cbWordWrap.CheckedChanged, AddressOf checkWordWrap_CheckedChanged
			AddHandler updownRightMargin.ValueChanged, AddressOf updownRightMargin_ValueChanged
			AddHandler comboKeywordsCasing.SelectedIndexChanged, AddressOf comboKeywordsCasing_SelectedIndexChanged
		End Sub

		Protected Overrides Sub Dispose(disposing As Boolean)
			RemoveHandler cbWordWrap.CheckedChanged, AddressOf checkWordWrap_CheckedChanged
			RemoveHandler updownRightMargin.ValueChanged, AddressOf updownRightMargin_ValueChanged
			RemoveHandler comboKeywordsCasing.SelectedIndexChanged, AddressOf comboKeywordsCasing_SelectedIndexChanged

			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If

			MyBase.Dispose(disposing)
		End Sub

		Private Sub comboKeywordsCasing_SelectedIndexChanged(sender As Object, e As EventArgs)
			Modified = True
		End Sub

		Private Sub checkWordWrap_CheckedChanged(sender As Object, e As EventArgs)
			updownRightMargin.Enabled = cbWordWrap.Checked
			Modified = True
		End Sub

		Private Sub updownRightMargin_ValueChanged(sender As Object, e As EventArgs)
			Modified = True
		End Sub

		Public Sub ApplyChanges()
			If Me.Modified Then
				If cbWordWrap.Checked Then
					_sqlFormattingOptions.RightMargin = CInt(Math.Truncate(updownRightMargin.Value))
				Else
					_sqlFormattingOptions.RightMargin = 0
				End If

				_sqlFormattingOptions.KeywordFormat = CType(comboKeywordsCasing.SelectedIndex, KeywordFormat)
			End If
		End Sub
	End Class
End Namespace
