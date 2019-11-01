'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.ComponentModel
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.WinForms

Namespace PropertiesForm
	Friend Enum SqlBuilderOptionsPages
		MainQuery
        DerivedQueries
        ExpressionSubQueries
    End Enum

    <ToolboxItem(False)>
    Partial Friend Class SqlFormattingPage
        Inherits UserControl
        Private ReadOnly _page As SqlBuilderOptionsPages = SqlBuilderOptionsPages.MainQuery
        Private ReadOnly _queryBuilder As QueryBuilder = Nothing
        Private ReadOnly _format As SQLBuilderSelectFormat

        Public Property Modified As Boolean = False

        Public Sub New(page As SqlBuilderOptionsPages, queryBuilder As QueryBuilder)
            _page = page
            _queryBuilder = queryBuilder
            _format = New SQLBuilderSelectFormat(Nothing)

            If _page = SqlBuilderOptionsPages.MainQuery Then
                _format.Assign(_queryBuilder.SQLFormattingOptions.MainQueryFormat)
            ElseIf _page = SqlBuilderOptionsPages.DerivedQueries Then
                _format.Assign(_queryBuilder.SQLFormattingOptions.DerivedQueryFormat)
            ElseIf _page = SqlBuilderOptionsPages.ExpressionSubqueries Then
                _format.Assign(_queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat)
            End If

            InitializeComponent()

            cbPartsOnNewLines.Checked = _format.MainPartsFromNewLine
            cbNewLineAfterKeywords.Checked = _format.NewLineAfterPartKeywords
            updownGlobalIndent.Value = _format.IndentGlobal
            updownPartIndent.Value = _format.IndentInPart

            cbNewLineAfterSelectItem.Checked = _format.SelectListFormat.NewLineAfterItem

            cbNewLineAfterDatasource.Checked = _format.FromClauseFormat.NewLineAfterDatasource
            cbNewLineAfterJoin.Checked = _format.FromClauseFormat.NewLineAfterJoin

            cbNewLineWhereTop.Checked = (_format.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical OrElse _format.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostOr OrElse _format.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical)
            checkNewLineWhereTop_CheckedChanged(Nothing, New EventArgs())
            cbNewLineWhereRest.Checked = (_format.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical)
            checkNewLineWhereRest_CheckedChanged(Nothing, New EventArgs())
            updownWhereIndent.Value = _format.WhereFormat.IndentNestedConditions

            cbNewLineAfterGroupItem.Checked = _format.GroupByFormat.NewLineAfterItem

            cbNewLineHavingTop.Checked = (_format.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical OrElse _format.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostOr OrElse _format.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical)
            checkNewLineHavingTop_CheckedChanged(Nothing, New EventArgs())
            cbNewLineHavingRest.Checked = (_format.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical)
            checkNewLineHavingRest_CheckedChanged(Nothing, New EventArgs())
            updownHavingIndent.Value = _format.HavingFormat.IndentNestedConditions

            AddHandler updownHavingIndent.ValueChanged, AddressOf Changed
            AddHandler updownHavingIndent.TextChanged, AddressOf Changed
            AddHandler cbNewLineHavingRest.CheckedChanged, AddressOf checkNewLineHavingRest_CheckedChanged
            AddHandler cbNewLineHavingTop.CheckedChanged, AddressOf checkNewLineHavingTop_CheckedChanged
            AddHandler cbNewLineAfterGroupItem.CheckedChanged, AddressOf Changed
            AddHandler updownWhereIndent.ValueChanged, AddressOf Changed
            AddHandler updownWhereIndent.TextChanged, AddressOf Changed
            AddHandler cbNewLineWhereRest.CheckedChanged, AddressOf checkNewLineWhereRest_CheckedChanged
            AddHandler cbNewLineWhereTop.CheckedChanged, AddressOf checkNewLineWhereTop_CheckedChanged
            AddHandler cbNewLineAfterJoin.CheckedChanged, AddressOf Changed
            AddHandler cbNewLineAfterDatasource.CheckedChanged, AddressOf Changed
            AddHandler cbNewLineAfterSelectItem.CheckedChanged, AddressOf Changed
            AddHandler updownPartIndent.ValueChanged, AddressOf Changed
            AddHandler updownPartIndent.TextChanged, AddressOf Changed
            AddHandler updownGlobalIndent.ValueChanged, AddressOf Changed
            AddHandler updownGlobalIndent.TextChanged, AddressOf Changed
            AddHandler cbNewLineAfterKeywords.CheckedChanged, AddressOf Changed
            AddHandler cbPartsOnNewLines.CheckedChanged, AddressOf Changed
        End Sub

        Protected Overrides Sub Dispose(disposing As Boolean)
            RemoveHandler updownHavingIndent.ValueChanged, AddressOf Changed
            RemoveHandler updownHavingIndent.TextChanged, AddressOf Changed
            RemoveHandler cbNewLineHavingRest.CheckedChanged, AddressOf checkNewLineHavingRest_CheckedChanged
            RemoveHandler cbNewLineHavingTop.CheckedChanged, AddressOf checkNewLineHavingTop_CheckedChanged
            RemoveHandler cbNewLineAfterGroupItem.CheckedChanged, AddressOf Changed
            RemoveHandler updownWhereIndent.ValueChanged, AddressOf Changed
            RemoveHandler updownWhereIndent.TextChanged, AddressOf Changed
            RemoveHandler cbNewLineWhereRest.CheckedChanged, AddressOf checkNewLineWhereRest_CheckedChanged
            RemoveHandler cbNewLineWhereTop.CheckedChanged, AddressOf checkNewLineWhereTop_CheckedChanged
            RemoveHandler cbNewLineAfterJoin.CheckedChanged, AddressOf Changed
            RemoveHandler cbNewLineAfterDatasource.CheckedChanged, AddressOf Changed
            RemoveHandler cbNewLineAfterSelectItem.CheckedChanged, AddressOf Changed
            RemoveHandler updownPartIndent.ValueChanged, AddressOf Changed
            RemoveHandler updownPartIndent.TextChanged, AddressOf Changed
            RemoveHandler updownGlobalIndent.ValueChanged, AddressOf Changed
            RemoveHandler updownGlobalIndent.TextChanged, AddressOf Changed
            RemoveHandler cbNewLineAfterKeywords.CheckedChanged, AddressOf Changed
            RemoveHandler cbPartsOnNewLines.CheckedChanged, AddressOf Changed

            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub Changed(sender As Object, e As EventArgs)
            Modified = True
        End Sub

        Private Sub checkNewLineWhereTop_CheckedChanged(sender As Object, e As EventArgs)
            cbNewLineWhereRest.Enabled = cbNewLineWhereTop.Checked

            If Not cbNewLineWhereTop.Checked Then
                cbNewLineWhereRest.Checked = False
                checkNewLineWhereRest_CheckedChanged(cbNewLineWhereRest, New EventArgs())
            End If

            If sender IsNot Nothing Then
                Modified = True
            End If
        End Sub

        Private Sub checkNewLineWhereRest_CheckedChanged(sender As Object, e As EventArgs)
            updownWhereIndent.Enabled = cbNewLineWhereRest.Checked

            If sender IsNot Nothing Then
                Modified = True
            End If
        End Sub

        Private Sub checkNewLineHavingTop_CheckedChanged(sender As Object, e As EventArgs)
            cbNewLineHavingRest.Enabled = cbNewLineHavingTop.Checked

            If Not cbNewLineHavingTop.Checked Then
                cbNewLineHavingRest.Checked = False
                checkNewLineHavingRest_CheckedChanged(cbNewLineHavingRest, New EventArgs())
            End If

            If sender IsNot Nothing Then
                Modified = True
            End If
        End Sub

        Private Sub checkNewLineHavingRest_CheckedChanged(sender As Object, e As EventArgs)
            updownHavingIndent.Enabled = cbNewLineHavingRest.Checked

            If sender IsNot Nothing Then
                Modified = True
            End If
        End Sub

        Public Sub ApplyChanges()
            If Modified Then
                _format.MainPartsFromNewLine = cbPartsOnNewLines.Checked
                _format.NewLineAfterPartKeywords = cbNewLineAfterKeywords.Checked
                _format.IndentInPart = CInt(Math.Truncate(updownPartIndent.Value))
                _format.IndentGlobal = CInt(Math.Truncate(updownGlobalIndent.Value))

                _format.SelectListFormat.NewLineAfterItem = cbNewLineAfterSelectItem.Checked

                _format.FromClauseFormat.NewLineAfterDatasource = cbNewLineAfterDatasource.Checked
                _format.FromClauseFormat.NewLineAfterJoin = cbNewLineAfterJoin.Checked

                If cbNewLineWhereRest.Checked Then
                    _format.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical
                ElseIf cbNewLineWhereTop.Checked Then
                    _format.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical
                Else
                    _format.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None
                End If

                _format.WhereFormat.IndentNestedConditions = CInt(Math.Truncate(updownWhereIndent.Value))

                _format.GroupByFormat.NewLineAfterItem = cbNewLineAfterGroupItem.Checked

                If cbNewLineHavingRest.Checked Then
                    _format.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical
                ElseIf cbNewLineHavingTop.Checked Then
                    _format.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical
                Else
                    _format.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None
                End If

                _format.HavingFormat.IndentNestedConditions = CInt(Math.Truncate(updownHavingIndent.Value))


                If _page = SqlBuilderOptionsPages.MainQuery Then
                    _queryBuilder.SQLFormattingOptions.MainQueryFormat.Assign(_format)
                ElseIf _page = SqlBuilderOptionsPages.DerivedQueries Then
                    _queryBuilder.SQLFormattingOptions.DerivedQueryFormat.Assign(_format)
				ElseIf _page = SqlBuilderOptionsPages.ExpressionSubqueries Then
					_queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.Assign(_format)
				End If
			End If
		End Sub
	End Class
End Namespace
