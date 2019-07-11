Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
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
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.genericSyntaxProvider1 = New ActiveQueryBuilder.Core.GenericSyntaxProvider(Me.components)
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.ErrorBox1 = New DragDropDemo.Common.ErrorBox()
        CType(Me.queryBuilder1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder1.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder1.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'queryBuilder1
        '
        Me.queryBuilder1.AddObjectDialogOptions.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder1.AddObjectDialogOptions.Size = New System.Drawing.Size(430, 430)
        Me.queryBuilder1.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.queryBuilder1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = false
        Me.queryBuilder1.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder1.DesignPaneOptions.Background = System.Drawing.SystemColors.Window
        LinkPainterAccess1.LinkColor = System.Drawing.Color.Black
        LinkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black
        LinkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control
        LinkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark
        LinkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder1.DesignPaneOptions.LinkPainterOptions = LinkPainterAccess1
        Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder1.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.queryBuilder1.Location = New System.Drawing.Point(12, 12)
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewVisible = false
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = true
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = true
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 140R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 200R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 250R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 100R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 100R
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3
        Me.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 60R
        Me.queryBuilder1.QueryColumnListOptions.Font = Nothing
        Me.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = false
        Me.queryBuilder1.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder1.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green
        Me.queryBuilder1.QueryNavBarOptions.DisableQueryNavigationBarPopup = false
        Me.queryBuilder1.QueryNavBarOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryBuilder1.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
        Me.queryBuilder1.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black
        Me.queryBuilder1.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue
        Me.queryBuilder1.Size = New System.Drawing.Size(721, 468)
        '
        '
        '
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DynamicIndents = false
        Me.queryBuilder1.SQLFormattingOptions.DynamicRightMargin = false
        Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = false
        Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = false
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        '
        '
        '
        Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = true
        Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = true
        Me.queryBuilder1.SyntaxProvider = Me.genericSyntaxProvider1
        Me.queryBuilder1.TabIndex = 0
        Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(242,Byte),Integer), CType(CType(157,Byte),Integer))
        Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black
        Me.queryBuilder1.VisualOptions.DockTabColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.queryBuilder1.VisualOptions.DockTabFontColor = System.Drawing.Color.White
        Me.queryBuilder1.VisualOptions.DockTabFontHoverColor = System.Drawing.Color.White
        Me.queryBuilder1.VisualOptions.DockTabHoverColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.queryBuilder1.VisualOptions.DockTabIndicatorColor = System.Drawing.Color.FromArgb(CType(CType(70,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(125,Byte),Integer))
        Me.queryBuilder1.VisualOptions.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(CType(CType(155,Byte),Integer), CType(CType(167,Byte),Integer), CType(CType(183,Byte),Integer))
        Me.queryBuilder1.VisualOptions.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(96,Byte),Integer), CType(CType(130,Byte),Integer))
        Me.queryBuilder1.VisualOptions.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White
        Me.queryBuilder1.VisualOptions.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryBuilder1.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        '
        'genericSyntaxProvider1
        '
        Me.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
        Me.genericSyntaxProvider1.OnCalcExpressionType = Nothing
        '
        'textBox1
        '
        Me.textBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.textBox1.Location = New System.Drawing.Point(12, 486)
        Me.textBox1.Multiline = true
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(876, 130)
        Me.textBox1.TabIndex = 1
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.label1.ForeColor = System.Drawing.Color.Maroon
        Me.label1.Location = New System.Drawing.Point(739, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(149, 60)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Drag an item from this custom list and drop it to the query builder's diagram pan"& _ 
    "e"
        '
        'listBox1
        '
        Me.listBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.listBox1.FormattingEnabled = true
        Me.listBox1.IntegralHeight = false
        Me.listBox1.Items.AddRange(New Object() {"Orders", "Order Details", "Products", "Customers", "Employees", "Categories"})
        Me.listBox1.Location = New System.Drawing.Point(739, 71)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(149, 409)
        Me.listBox1.TabIndex = 4
        '
        'ErrorBox1
        '
        Me.ErrorBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ErrorBox1.AutoSize = true
        Me.ErrorBox1.BackColor = System.Drawing.Color.LightPink
        Me.ErrorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorBox1.CurrentSyntaxProvider = Nothing
        Me.ErrorBox1.IsVisibleCheckSyntaxPanel = false
        Me.ErrorBox1.Location = New System.Drawing.Point(561, 545)
        Me.ErrorBox1.Name = "ErrorBox1"
        Me.ErrorBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.ErrorBox1.Size = New System.Drawing.Size(314, 61)
        Me.ErrorBox1.TabIndex = 5
        Me.ErrorBox1.Visible = false
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 628)
        Me.Controls.Add(Me.ErrorBox1)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.queryBuilder1)
        Me.Name = "Form1"
        Me.Text = "Drag'n'Drop Demo"
        CType(Me.queryBuilder1.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder1.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

	#End Region

	Private WithEvents queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private WithEvents textBox1 As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private genericSyntaxProvider1 As ActiveQueryBuilder.Core.GenericSyntaxProvider
	Private WithEvents listBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ErrorBox1 As Common.ErrorBox
End Class

