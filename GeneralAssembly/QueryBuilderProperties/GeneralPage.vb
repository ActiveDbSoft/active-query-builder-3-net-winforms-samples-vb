//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

Namespace QueryBuilderProperties
	<ToolboxItem(False)>
	Partial Friend Class GeneralPage
		Inherits UserControl
		Private _queryBuilder As QueryBuilder = Nothing
		Private _modified As Boolean = False


		Public Property Modified() As Boolean
			Get
				Return _modified
			End Get
			Set(value As Boolean)
				_modified = value
			End Set
		End Property


		Public Sub New(queryBuilder As QueryBuilder)
			_queryBuilder = queryBuilder

			InitializeComponent()

			cbWordWrap.Checked = (_queryBuilder.SQLFormattingOptions.RightMargin <> 0)
			updownRightMargin.Enabled = cbWordWrap.Checked

			updownRightMargin.Value = If(_queryBuilder.SQLFormattingOptions.RightMargin = 0, 80, _queryBuilder.SQLFormattingOptions.RightMargin)

			comboKeywordsCasing.Items.Add("Capitalized")
			comboKeywordsCasing.Items.Add("Uppercase")
			comboKeywordsCasing.Items.Add("Lowercase")

			comboKeywordsCasing.SelectedIndex = CInt(Fix(queryBuilder.SQLFormattingOptions.KeywordFormat))

			AddHandler cbWordWrap.CheckedChanged, AddressOf checkWordWrap_CheckedChanged
			AddHandler updownRightMargin.ValueChanged, AddressOf updownRightMargin_ValueChanged
			AddHandler comboKeywordsCasing.SelectedIndexChanged, AddressOf comboKeywordsCasing_SelectedIndexChanged
		End Sub

		Protected Overrides Overloads Sub Dispose(disposing As Boolean)
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
					_queryBuilder.SQLFormattingOptions.RightMargin = CInt(Fix(updownRightMargin.Value))
				Else
					_queryBuilder.SQLFormattingOptions.RightMargin = 0
				End If

				_queryBuilder.SQLFormattingOptions.KeywordFormat = CType(comboKeywordsCasing.SelectedIndex, KeywordFormat)
			End If
		End Sub
	End Class
End Namespace
