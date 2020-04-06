Imports System
Imports System.Windows.Forms

Namespace ConsolidatedMetadataContainer
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing


        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub


#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            Dim linkPainterAccess1 As ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess = New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
            splitContainer1 = New System.Windows.Forms.SplitContainer()
            queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
            syntaxProviderSql2003 = New ActiveQueryBuilder.Core.SQL2003SyntaxProvider(components)
            textSql = New System.Windows.Forms.TextBox()
            CType(splitContainer1, ComponentModel.ISupportInitialize).BeginInit()
            splitContainer1.Panel1.SuspendLayout()
            splitContainer1.Panel2.SuspendLayout()
            splitContainer1.SuspendLayout()
            CType(queryBuilder, ComponentModel.ISupportInitialize).BeginInit()
            CType(queryBuilder.SQLFormattingOptions, ComponentModel.ISupportInitialize).BeginInit()
            CType(queryBuilder.SQLGenerationOptions, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' splitContainer1
            ' 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            splitContainer1.Location = New Drawing.Point(0, 0)
            splitContainer1.Name = "splitContainer1"
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
            ' 
            ' splitContainer1.Panel1
            ' 
            splitContainer1.Panel1.Controls.Add(queryBuilder)
            ' 
            ' splitContainer1.Panel2
            ' 
            splitContainer1.Panel2.Controls.Add(textSql)
            splitContainer1.Size = New Drawing.Size(916, 490)
            splitContainer1.SplitterDistance = 329
            splitContainer1.TabIndex = 0
            ' 
            ' queryBuilder
            ' 
            queryBuilder.AddObjectDialogOptions.Location = New Drawing.Point(0, 0)
            queryBuilder.AddObjectDialogOptions.Size = New Drawing.Size(430, 430)
            queryBuilder.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.None
            queryBuilder.DatabaseSchemaViewOptions.AllowDrop = True
            queryBuilder.DatabaseSchemaViewOptions.DrawTreeLines = False
            queryBuilder.DatabaseSchemaViewOptions.ImageList = Nothing
            queryBuilder.DataSourceOptions.ColumnsOptions.NameColumnOptions.DrawOrder = 1
            queryBuilder.DataSourceOptions.DefaultWidth = 210
            queryBuilder.DesignPaneOptions.Background = Drawing.SystemColors.Window
            linkPainterAccess1.LinkColor = Drawing.Color.Black
            linkPainterAccess1.LinkColorFocused = Drawing.Color.Black
            linkPainterAccess1.MarkColor = Drawing.SystemColors.Control
            linkPainterAccess1.MarkColorFocused = Drawing.SystemColors.ControlDark
            linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
            queryBuilder.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1
            queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
            queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill
            queryBuilder.Location = New Drawing.Point(0, 0)
            queryBuilder.MetadataLoadingOptions.ExcludeFilter.Types = ActiveQueryBuilder.Core.MetadataType.None
            queryBuilder.Name = "queryBuilder"
            queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = True
            queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
            queryBuilder.PanesConfigurationOptions.PropertiesBarEnabled = True
            queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = True
            queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
            queryBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = True
            queryBuilder.QueryColumnListOptions.AlternateRowColor = Drawing.SystemColors.Highlight
            queryBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5
            queryBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90R
            queryBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
            queryBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100R
            queryBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7
            queryBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 140R
            queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8
            queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 200R
            queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Caption = Nothing
            queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0
            queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60R
            queryBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1
            queryBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 250R
            queryBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6
            queryBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 100R
            queryBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0
            queryBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55R
            queryBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4
            queryBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 100R
            queryBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3
            queryBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 60R
            queryBuilder.QueryColumnListOptions.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 204)
            queryBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2
            queryBuilder.QueryColumnListOptions.NullOrderingInOrderBy = False
            queryBuilder.QueryColumnListOptions.TextColor = Drawing.SystemColors.ControlText
            queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
            queryBuilder.QueryNavBarOptions.ActionButtonBackColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.ActionButtonBorderColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.ActiveSubQueryItemBackColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.ActiveSubQueryItemBorderColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.AddCteCircleColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.AddUnionSubQueryCircleColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.BreadcrumbsBackgroundColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.CTEButtonBaseColor = Drawing.Color.Green
            queryBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = False
            queryBuilder.QueryNavBarOptions.DragIndicatorColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.DragIndicatorHoverColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 204)
            queryBuilder.QueryNavBarOptions.ForeColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.GraphLineColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.GroupBackColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.GroupTextColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.OverflowButtonBaseColor = Drawing.Color.DarkRed
            queryBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = Drawing.Color.Black
            queryBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = Drawing.Color.Blue
            queryBuilder.QueryNavBarOptions.SubQueryItemBackColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.SubQueryItemBorderColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.SubQueryMarkerColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.SubQueryPopupBackColor = Drawing.Color.Empty
            queryBuilder.QueryNavBarOptions.TextHoverColor = Drawing.Color.Empty
            queryBuilder.Size = New Drawing.Size(916, 329)
            ' 
            ' 
            ' 
            queryBuilder.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
            queryBuilder.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
            queryBuilder.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
            queryBuilder.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
            queryBuilder.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
            queryBuilder.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
            queryBuilder.SQLFormattingOptions.DynamicIndents = False
            queryBuilder.SQLFormattingOptions.DynamicRightMargin = False
            queryBuilder.SQLFormattingOptions.ExpandVirtualFields = False
            queryBuilder.SQLFormattingOptions.ExpandVirtualObjects = False
            queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
            queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = False
            queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
            queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = False
            queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
            queryBuilder.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
            queryBuilder.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
            queryBuilder.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
            ' 
            ' 
            ' 
            queryBuilder.SQLGenerationOptions.ExpandVirtualFields = True
            queryBuilder.SQLGenerationOptions.ExpandVirtualObjects = True
            queryBuilder.SQLGenerationOptions.UseAltNames = False
            queryBuilder.SyntaxProvider = syntaxProviderSql2003
            queryBuilder.TabIndex = 0
            queryBuilder.VisualOptions.ActiveDockPanelCaptionColor = Drawing.Color.FromArgb(255, 242, 157)
            queryBuilder.VisualOptions.ActiveDockPanelCaptionFontColor = Drawing.Color.Black
            queryBuilder.VisualOptions.DockPanelBackColor = Drawing.Color.Empty
            queryBuilder.VisualOptions.DockTabColor = Drawing.Color.FromArgb(41, 57, 85)
            queryBuilder.VisualOptions.DockTabFontColor = Drawing.Color.White
            queryBuilder.VisualOptions.DockTabFontHoverColor = Drawing.Color.White
            queryBuilder.VisualOptions.DockTabHoverColor = Drawing.Color.FromArgb(41, 57, 85)
            queryBuilder.VisualOptions.DockTabIndicatorColor = Drawing.Color.FromArgb(70, 90, 125)
            queryBuilder.VisualOptions.DockTabIndicatorHoverColor = Drawing.Color.FromArgb(155, 167, 183)
            queryBuilder.VisualOptions.InactiveDockPanelCaptionColor = Drawing.Color.FromArgb(77, 96, 130)
            queryBuilder.VisualOptions.InactiveDockPanelCaptionFontColor = Drawing.Color.White
            queryBuilder.VisualOptions.TabFont = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, 204)
            queryBuilder.VisualOptions.TabsStripBackColor = Drawing.Color.FromArgb(41, 57, 85)
            ' 
            ' syntaxProviderSql2003
            ' 
            syntaxProviderSql2003.DetectServerVersion = False
            syntaxProviderSql2003.OnCalcExpressionType = Nothing
            ' 
            ' textSql
            ' 
            textSql.Dock = System.Windows.Forms.DockStyle.Fill
            textSql.Location = New Drawing.Point(0, 0)
            textSql.Multiline = True
            textSql.Name = "textSql"
            textSql.Size = New Drawing.Size(916, 157)
            textSql.TabIndex = 0
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(916, 490)
            Controls.Add(splitContainer1)
            Name = "Form1"
            Text = "Form1"
            WindowState = System.Windows.Forms.FormWindowState.Maximized
            splitContainer1.Panel1.ResumeLayout(False)
            splitContainer1.Panel2.ResumeLayout(False)
            splitContainer1.Panel2.PerformLayout()
            CType(splitContainer1, ComponentModel.ISupportInitialize).EndInit()
            splitContainer1.ResumeLayout(False)
            CType(queryBuilder.SQLFormattingOptions, ComponentModel.ISupportInitialize).EndInit()
            CType(queryBuilder.SQLGenerationOptions, ComponentModel.ISupportInitialize).EndInit()
            CType(queryBuilder, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub


#End Region

        Private splitContainer1 As System.Windows.Forms.SplitContainer
        Private queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
        Private textSql As System.Windows.Forms.TextBox
        Private syntaxProviderSql2003 As ActiveQueryBuilder.Core.SQL2003SyntaxProvider
    End Class
End Namespace
