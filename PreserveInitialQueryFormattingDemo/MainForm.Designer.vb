<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim LinkPainterAccess1 As ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess = New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonOpenSql = New System.Windows.Forms.Button()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.QBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.textBoxSql = New System.Windows.Forms.TextBox()
        Me.sqlErrorBox1 = New GeneralAssembly.Common.SqlErrorBox()
        Me.tableLayoutPanel1.SuspendLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer1.Panel1.SuspendLayout
        Me.splitContainer1.Panel2.SuspendLayout
        Me.splitContainer1.SuspendLayout
        CType(Me.QBuilder,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.QBuilder.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.QBuilder.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.Controls.Add(Me.buttonOpenSql, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.splitContainer1, 0, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(1063, 607)
        Me.tableLayoutPanel1.TabIndex = 1
        '
        'buttonOpenSql
        '
        Me.buttonOpenSql.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.buttonOpenSql.AutoSize = true
        Me.buttonOpenSql.Location = New System.Drawing.Point(904, 581)
        Me.buttonOpenSql.Name = "buttonOpenSql"
        Me.buttonOpenSql.Size = New System.Drawing.Size(156, 23)
        Me.buttonOpenSql.TabIndex = 0
        Me.buttonOpenSql.Text = "Open file with content sql text"
        Me.buttonOpenSql.UseVisualStyleBackColor = true
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.QBuilder)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.sqlErrorBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.textBoxSql)
        Me.splitContainer1.Size = New System.Drawing.Size(1057, 572)
        Me.splitContainer1.SplitterDistance = 475
        Me.splitContainer1.TabIndex = 1
        '
        'QBuilder
        '
        Me.QBuilder.AddObjectDialogOptions.Location = New System.Drawing.Point(0, 0)
        Me.QBuilder.AddObjectDialogOptions.Size = New System.Drawing.Size(430, 430)
        Me.QBuilder.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.QBuilder.AddObjectDialogOptions.StartWithDefaultNamespaceType = ActiveQueryBuilder.Core.MetadataType.Database
        Me.QBuilder.AddObjectDialogOptions.StartWithMetadataStructurePath = Nothing
        Me.QBuilder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.QBuilder.DatabaseSchemaViewOptions.AllowDrop = true
        Me.QBuilder.DatabaseSchemaViewOptions.DrawTreeLines = false
        Me.QBuilder.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.QBuilder.DataSourceOptions.ColumnsOptions.DescriptionColumnOptions.DrawOrder = 4
        Me.QBuilder.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = System.Drawing.Color.Black
        Me.QBuilder.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.DrawOrder = 3
        Me.QBuilder.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Margin = 5
        Me.QBuilder.DataSourceOptions.ColumnsOptions.NameColumnOptions.DrawOrder = 1
        Me.QBuilder.DataSourceOptions.DefaultWidth = 300
        Me.QBuilder.DataSourceOptions.MaxHeight = 300
        Me.QBuilder.DesignPaneOptions.Background = System.Drawing.SystemColors.Window
        Me.QBuilder.DesignPaneOptions.DesignPaneOverviewWidth = 200
        LinkPainterAccess1.LinkColor = System.Drawing.Color.Black
        LinkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black
        LinkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control
        LinkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark
        LinkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.QBuilder.DesignPaneOptions.LinkPainterOptions = LinkPainterAccess1
        Me.QBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.QBuilder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QBuilder.Location = New System.Drawing.Point(0, 0)
        Me.QBuilder.MetadataLoadingOptions.ExcludeFilter.Types = ActiveQueryBuilder.Core.MetadataType.None
        Me.QBuilder.Name = "QBuilder"
        Me.QBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true
        Me.QBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.QBuilder.PanesConfigurationOptions.PropertiesBarEnabled = true
        Me.QBuilder.PanesConfigurationOptions.QueryColumnsPaneHeight = 69
        Me.QBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true
        Me.QBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.QBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = true
        Me.QBuilder.QueryColumnListOptions.AlternateRowColor = System.Drawing.SystemColors.Highlight
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 0
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 5
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 140R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 6
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 200R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Caption = Nothing
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 250R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.GroupingAndAggregateColumn.Index = 4
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.GroupingAndAggregateColumn.Width = 140R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 0
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 100R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortColumn.Index = 3
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortColumn.Width = 150R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 0
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 100R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 0
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 60R
        Me.QBuilder.QueryColumnListOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254,Byte))
        Me.QBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.QBuilder.QueryColumnListOptions.NullOrderingInOrderBy = false
        Me.QBuilder.QueryColumnListOptions.TextColor = System.Drawing.SystemColors.ControlText
        Me.QBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.QBuilder.QueryNavBarOptions.ActionButtonBackColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.ActionButtonBorderColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.ActiveSubQueryItemBackColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.ActiveSubQueryItemBorderColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.AddCteCircleColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.AddUnionSubQueryCircleColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.BreadcrumbsBackgroundColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green
        Me.QBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = false
        Me.QBuilder.QueryNavBarOptions.DragIndicatorColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.DragIndicatorHoverColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254,Byte))
        Me.QBuilder.QueryNavBarOptions.ForeColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.GraphLineColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.GroupBackColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.GroupTextColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
        Me.QBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black
        Me.QBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue
        Me.QBuilder.QueryNavBarOptions.SubQueryItemBackColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.SubQueryItemBorderColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.SubQueryMarkerColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.SubQueryPopupBackColor = System.Drawing.Color.Empty
        Me.QBuilder.QueryNavBarOptions.TextHoverColor = System.Drawing.Color.Empty
        Me.QBuilder.Size = New System.Drawing.Size(1057, 475)
        '
        '
        '
        Me.QBuilder.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.DynamicIndents = false
        Me.QBuilder.SQLFormattingOptions.DynamicRightMargin = false
        Me.QBuilder.SQLFormattingOptions.ExpandVirtualFields = false
        Me.QBuilder.SQLFormattingOptions.ExpandVirtualObjects = false
        Me.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false
        Me.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = false
        Me.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        '
        '
        '
        Me.QBuilder.SQLGenerationOptions.ExpandVirtualFields = true
        Me.QBuilder.SQLGenerationOptions.ExpandVirtualObjects = true
        Me.QBuilder.SQLGenerationOptions.UseAltNames = false
        Me.QBuilder.TabIndex = 0
        Me.QBuilder.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(242,Byte),Integer), CType(CType(157,Byte),Integer))
        Me.QBuilder.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black
        Me.QBuilder.VisualOptions.DockPanelBackColor = System.Drawing.Color.Empty
        Me.QBuilder.VisualOptions.DockTabColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.QBuilder.VisualOptions.DockTabFontColor = System.Drawing.Color.White
        Me.QBuilder.VisualOptions.DockTabFontHoverColor = System.Drawing.Color.White
        Me.QBuilder.VisualOptions.DockTabHoverColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.QBuilder.VisualOptions.DockTabIndicatorColor = System.Drawing.Color.FromArgb(CType(CType(70,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(125,Byte),Integer))
        Me.QBuilder.VisualOptions.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(CType(CType(155,Byte),Integer), CType(CType(167,Byte),Integer), CType(CType(183,Byte),Integer))
        Me.QBuilder.VisualOptions.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(96,Byte),Integer), CType(CType(130,Byte),Integer))
        Me.QBuilder.VisualOptions.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White
        Me.QBuilder.VisualOptions.TabFont = Nothing
        Me.QBuilder.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        '
        'textBoxSql
        '
        Me.textBoxSql.AcceptsReturn = true
        Me.textBoxSql.AcceptsTab = true
        Me.textBoxSql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBoxSql.Location = New System.Drawing.Point(0, 0)
        Me.textBoxSql.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.textBoxSql.Multiline = true
        Me.textBoxSql.Name = "textBoxSql"
        Me.textBoxSql.Size = New System.Drawing.Size(1057, 93)
        Me.textBoxSql.TabIndex = 0
        '
        'sqlErrorBox1
        '
        Me.sqlErrorBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.sqlErrorBox1.AutoSize = true
        Me.sqlErrorBox1.BackColor = System.Drawing.Color.LightPink
        Me.sqlErrorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sqlErrorBox1.CurrentSyntaxProvider = Nothing
        Me.sqlErrorBox1.IsVisibleActionLinks = false
        Me.sqlErrorBox1.IsVisibleCheckSyntaxPanel = false
        Me.sqlErrorBox1.Location = New System.Drawing.Point(786, 52)
        Me.sqlErrorBox1.Name = "sqlErrorBox1"
        Me.sqlErrorBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.sqlErrorBox1.Size = New System.Drawing.Size(268, 38)
        Me.sqlErrorBox1.TabIndex = 1
        Me.sqlErrorBox1.Visible = false
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 607)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Preserve Initial Query Formatting Demo"
        Me.tableLayoutPanel1.ResumeLayout(false)
        Me.tableLayoutPanel1.PerformLayout
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        Me.splitContainer1.Panel2.PerformLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        CType(Me.QBuilder.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.QBuilder.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.QBuilder,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents buttonOpenSql As Button
    Private WithEvents splitContainer1 As SplitContainer
    Private WithEvents QBuilder As QueryBuilder
    Private WithEvents textBoxSql As TextBox
    Private WithEvents sqlErrorBox1 As GeneralAssembly.Common.SqlErrorBox
End Class
