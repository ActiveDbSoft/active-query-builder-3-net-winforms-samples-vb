'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core

Namespace PropertiesForm
	Public Enum SubQueryType
		Derived
		Cte
		Expression
	End Enum

	Public Partial Class SubQueryTab
		Inherits UserControl
		Public Property FormattingOptions() As SQLFormattingOptions
			Get
				Return m_FormattingOptions
			End Get
			Set
				m_FormattingOptions = Value
			End Set
		End Property
		Private m_FormattingOptions As SQLFormattingOptions
		Public Property SelectFormat() As SQLBuilderSelectFormat
			Get
				Return m_SelectFormat
			End Get
			Set
				m_SelectFormat = Value
			End Set
		End Property
		Private m_SelectFormat As SQLBuilderSelectFormat

		Public Sub New(formattingOptions__1 As SQLFormattingOptions, Optional type As SubQueryType = SubQueryType.Expression)
			InitializeComponent()

			FormattingOptions = formattingOptions__1

			If type = SubQueryType.Expression Then
				SelectFormat = formattingOptions__1.ExpressionSubQueryFormat

			ElseIf type = SubQueryType.Derived Then
				groupBox1.Text = "Derived tables format options"
				label1.Text = "Derived tables indent:"
				chBxSubQueriesFromNewLines.Text = "Start derived tables from new lines"
				label2.Text = "Derived Tables format options" & vbLf & "determine the layout of sub-queries" & vbLf & "used as data sources in the query."

				SelectFormat = formattingOptions__1.DerivedQueryFormat

			ElseIf type = SubQueryType.Cte Then
				groupBox1.Text = "Common table expressions format options"
				label1.Text = "CTE indent:"
				chBxSubQueriesFromNewLines.Text = "Start CTE from new lines"
				label2.Text = "CTE format options" & vbLf & "determine the layout of sub-queries" & vbLf & "used above the main query in the with clause."

				SelectFormat = formattingOptions__1.CTESubQueryFormat
			End If

			LoadOptions()
		End Sub

		Public Sub LoadOptions()
			UpDownSubQueryIndent.Value = SelectFormat.IndentInPart
			chBxSubQueriesFromNewLines.Checked = SelectFormat.SubQueryTextFromNewLine
		End Sub

		Private Sub UpDownSubQueryIndent_ValueChanged(sender As Object, e As EventArgs)
			SelectFormat.IndentInPart = CInt(Math.Truncate(UpDownSubQueryIndent.Value))
		End Sub

		Private Sub chBxSubQueriesFromNewLines_CheckedChanged(sender As Object, e As EventArgs)
			SelectFormat.SubQueryTextFromNewLine = chBxSubQueriesFromNewLines.Checked
		End Sub

		Private Sub chBxSameFormatAsMainQuery_CheckedChanged(sender As Object, e As EventArgs)
			SelectFormat.Assign(FormattingOptions.MainQueryFormat)
		End Sub
	End Class
End Namespace
