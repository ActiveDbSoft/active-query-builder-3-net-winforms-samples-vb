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
        Me.components = New System.ComponentModel.Container()
        Dim LinkPainterAccess1 As ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess = New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.syntaxProviderSql2003 = New ActiveQueryBuilder.Core.SQL2003SyntaxProvider(Me.components)
        Me.textSql = New System.Windows.Forms.TextBox()
        Me.ButtonStats = New System.Windows.Forms.Button()
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer1.Panel1.SuspendLayout
        Me.splitContainer1.Panel2.SuspendLayout
        Me.splitContainer1.SuspendLayout
        CType(Me.queryBuilder,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.ButtonStats)
        Me.splitContainer1.Panel2.Controls.Add(Me.textSql)
        Me.splitContainer1.Size = New System.Drawing.Size(916, 490)
        Me.splitContainer1.SplitterDistance = 329
        Me.splitContainer1.TabIndex = 0
        '
        'queryBuilder
        '
        Me.queryBuilder.AddObjectDialogOptions.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder.AddObjectDialogOptions.Size = New System.Drawing.Size(430, 430)
        Me.queryBuilder.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.queryBuilder.DatabaseSchemaViewOptions.AllowDrop = true
        Me.queryBuilder.DatabaseSchemaViewOptions.DrawTreeLines = false
        Me.queryBuilder.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = System.Drawing.Color.Black
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.NameColumnOptions.DrawOrder = 1
        Me.queryBuilder.DataSourceOptions.DefaultWidth = 210
        Me.queryBuilder.DesignPaneOptions.Background = System.Drawing.SystemColors.Window
        LinkPainterAccess1.LinkColor = System.Drawing.Color.Black
        LinkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black
        LinkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control
        LinkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark
        LinkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder.DesignPaneOptions.LinkPainterOptions = LinkPainterAccess1
        Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.queryBuilder.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder.MetadataLoadingOptions.ExcludeFilter.Types = ActiveQueryBuilder.Core.MetadataType.None
        Me.queryBuilder.Name = "queryBuilder"
        Me.queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true
        Me.queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder.PanesConfigurationOptions.PropertiesBarEnabled = true
        Me.queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true
        Me.queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = true
        Me.queryBuilder.QueryColumnListOptions.AlternateRowColor = System.Drawing.SystemColors.Highlight
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 140R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 200R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Caption = Nothing
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 250R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 100R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 100R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 60R
        Me.queryBuilder.QueryColumnListOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder.QueryColumnListOptions.NullOrderingInOrderBy = false
        Me.queryBuilder.QueryColumnListOptions.TextColor = System.Drawing.SystemColors.ControlText
        Me.queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder.QueryNavBarOptions.ActionButtonBackColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.ActionButtonBorderColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.ActiveSubQueryItemBackColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.ActiveSubQueryItemBorderColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.AddCteCircleColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.AddUnionSubQueryCircleColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.BreadcrumbsBackgroundColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green
        Me.queryBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = false
        Me.queryBuilder.QueryNavBarOptions.DragIndicatorColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.DragIndicatorHoverColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryBuilder.QueryNavBarOptions.ForeColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.GraphLineColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.GroupBackColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.GroupTextColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
        Me.queryBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black
        Me.queryBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue
        Me.queryBuilder.QueryNavBarOptions.SubQueryItemBackColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.SubQueryItemBorderColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.SubQueryMarkerColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.SubQueryPopupBackColor = System.Drawing.Color.Empty
        Me.queryBuilder.QueryNavBarOptions.TextHoverColor = System.Drawing.Color.Empty
        Me.queryBuilder.Size = New System.Drawing.Size(916, 329)
        '
        '
        '
        Me.queryBuilder.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.DynamicIndents = false
        Me.queryBuilder.SQLFormattingOptions.DynamicRightMargin = false
        Me.queryBuilder.SQLFormattingOptions.ExpandVirtualFields = false
        Me.queryBuilder.SQLFormattingOptions.ExpandVirtualObjects = false
        Me.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false
        Me.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = false
        Me.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        '
        '
        '
        Me.queryBuilder.SQLGenerationOptions.ExpandVirtualFields = true
        Me.queryBuilder.SQLGenerationOptions.ExpandVirtualObjects = true
        Me.queryBuilder.SQLGenerationOptions.UseAltNames = false
        Me.queryBuilder.SyntaxProvider = Me.syntaxProviderSql2003
        Me.queryBuilder.TabIndex = 0
        Me.queryBuilder.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(242,Byte),Integer), CType(CType(157,Byte),Integer))
        Me.queryBuilder.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black
        Me.queryBuilder.VisualOptions.DockPanelBackColor = System.Drawing.Color.Empty
        Me.queryBuilder.VisualOptions.DockTabColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.queryBuilder.VisualOptions.DockTabFontColor = System.Drawing.Color.White
        Me.queryBuilder.VisualOptions.DockTabFontHoverColor = System.Drawing.Color.White
        Me.queryBuilder.VisualOptions.DockTabHoverColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.queryBuilder.VisualOptions.DockTabIndicatorColor = System.Drawing.Color.FromArgb(CType(CType(70,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(125,Byte),Integer))
        Me.queryBuilder.VisualOptions.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(CType(CType(155,Byte),Integer), CType(CType(167,Byte),Integer), CType(CType(183,Byte),Integer))
        Me.queryBuilder.VisualOptions.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(96,Byte),Integer), CType(CType(130,Byte),Integer))
        Me.queryBuilder.VisualOptions.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White
        Me.queryBuilder.VisualOptions.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryBuilder.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        '
        'syntaxProviderSql2003
        '
        Me.syntaxProviderSql2003.DetectServerVersion = false
        Me.syntaxProviderSql2003.OnCalcExpressionType = Nothing
        '
        'textSql
        '
        Me.textSql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textSql.Location = New System.Drawing.Point(0, 0)
        Me.textSql.Multiline = true
        Me.textSql.Name = "textSql"
        Me.textSql.Size = New System.Drawing.Size(916, 157)
        Me.textSql.TabIndex = 0
        '
        'ButtonStats
        '
        Me.ButtonStats.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ButtonStats.Location = New System.Drawing.Point(747, 106)
        Me.ButtonStats.Name = "ButtonStats"
        Me.ButtonStats.Size = New System.Drawing.Size(157, 39)
        Me.ButtonStats.TabIndex = 1
        Me.ButtonStats.Text = "Show DataSources stats"
        Me.ButtonStats.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 490)
        Me.Controls.Add(Me.splitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        Me.splitContainer1.Panel2.PerformLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        CType(Me.queryBuilder.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub


#End Region

        Private splitContainer1 As System.Windows.Forms.SplitContainer
        Private queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
        Private textSql As System.Windows.Forms.TextBox
        Private syntaxProviderSql2003 As ActiveQueryBuilder.Core.SQL2003SyntaxProvider
        Friend WithEvents ButtonStats As Button
    End Class
End Namespace
