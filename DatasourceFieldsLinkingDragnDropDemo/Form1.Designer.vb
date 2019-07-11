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
        Dim LinkPainterAccess1 As ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess = New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CheckBoxBeforeDsFieldDrag = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLinkDragOver = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.QBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.TextBoxSQL = New System.Windows.Forms.RichTextBox()
        Me.TextBoxReport = New System.Windows.Forms.RichTextBox()
        Me.ErrorBox1 = New DatasourceFieldsLinkingDragnDropDemo.Common.ErrorBox()
        Me.tableLayoutPanel1.SuspendLayout
        Me.panel1.SuspendLayout
        Me.flowLayoutPanel1.SuspendLayout
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
        Me.tableLayoutPanel1.AutoSize = true
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.splitContainer1, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.TextBoxReport, 0, 2)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(999, 659)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.Info
        Me.panel1.Controls.Add(Me.flowLayoutPanel1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(993, 50)
        Me.panel1.TabIndex = 0
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.AutoSize = true
        Me.flowLayoutPanel1.Controls.Add(Me.CheckBoxBeforeDsFieldDrag)
        Me.flowLayoutPanel1.Controls.Add(Me.CheckBoxLinkDragOver)
        Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(0, 13)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(993, 33)
        Me.flowLayoutPanel1.TabIndex = 1
        '
        'CheckBoxBeforeDsFieldDrag
        '
        Me.CheckBoxBeforeDsFieldDrag.AutoSize = true
        Me.CheckBoxBeforeDsFieldDrag.Checked = true
        Me.CheckBoxBeforeDsFieldDrag.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxBeforeDsFieldDrag.Location = New System.Drawing.Point(8, 8)
        Me.CheckBoxBeforeDsFieldDrag.Name = "CheckBoxBeforeDsFieldDrag"
        Me.CheckBoxBeforeDsFieldDrag.Size = New System.Drawing.Size(157, 17)
        Me.CheckBoxBeforeDsFieldDrag.TabIndex = 0
        Me.CheckBoxBeforeDsFieldDrag.Text = "BeforeDatasourceFieldDrag"
        Me.CheckBoxBeforeDsFieldDrag.UseVisualStyleBackColor = true
        '
        'CheckBoxLinkDragOver
        '
        Me.CheckBoxLinkDragOver.AutoSize = true
        Me.CheckBoxLinkDragOver.Checked = true
        Me.CheckBoxLinkDragOver.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxLinkDragOver.Location = New System.Drawing.Point(171, 8)
        Me.CheckBoxLinkDragOver.Name = "CheckBoxLinkDragOver"
        Me.CheckBoxLinkDragOver.Size = New System.Drawing.Size(92, 17)
        Me.CheckBoxLinkDragOver.TabIndex = 0
        Me.CheckBoxLinkDragOver.Text = "LinkDragOver"
        Me.CheckBoxLinkDragOver.UseVisualStyleBackColor = true
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(55, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Stop on:"
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainer1.Location = New System.Drawing.Point(3, 59)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.QBuilder)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.ErrorBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.TextBoxSQL)
        Me.splitContainer1.Size = New System.Drawing.Size(993, 497)
        Me.splitContainer1.SplitterDistance = 383
        Me.splitContainer1.TabIndex = 1
        '
        'QBuilder
        '
        Me.QBuilder.AddObjectDialogOptions.Location = New System.Drawing.Point(0, 0)
        Me.QBuilder.AddObjectDialogOptions.Size = New System.Drawing.Size(430, 430)
        Me.QBuilder.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.QBuilder.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = false
        Me.QBuilder.DatabaseSchemaViewOptions.DrawTreeLines = false
        Me.QBuilder.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.QBuilder.DesignPaneOptions.Background = System.Drawing.SystemColors.Window
        LinkPainterAccess1.LinkColor = System.Drawing.Color.Black
        LinkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black
        LinkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control
        LinkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark
        LinkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.QBuilder.DesignPaneOptions.LinkPainterOptions = LinkPainterAccess1
        Me.QBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.QBuilder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QBuilder.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.QBuilder.Location = New System.Drawing.Point(0, 0)
        Me.QBuilder.Name = "QBuilder"
        Me.QBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true
        Me.QBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.QBuilder.PanesConfigurationOptions.PropertiesBarEnabled = true
        Me.QBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true
        Me.QBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.QBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = true
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 70R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 60R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 150R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 80R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 90R
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 80R
        Me.QBuilder.QueryColumnListOptions.Font = Nothing
        Me.QBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.QBuilder.QueryColumnListOptions.NullOrderingInOrderBy = false
        Me.QBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.QBuilder.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green
        Me.QBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = false
        Me.QBuilder.QueryNavBarOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.QBuilder.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
        Me.QBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black
        Me.QBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue
        Me.QBuilder.Size = New System.Drawing.Size(993, 383)
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
        Me.QBuilder.TabIndex = 2
        Me.QBuilder.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(242,Byte),Integer), CType(CType(157,Byte),Integer))
        Me.QBuilder.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black
        Me.QBuilder.VisualOptions.DockTabColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.QBuilder.VisualOptions.DockTabFontColor = System.Drawing.Color.White
        Me.QBuilder.VisualOptions.DockTabFontHoverColor = System.Drawing.Color.White
        Me.QBuilder.VisualOptions.DockTabHoverColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        Me.QBuilder.VisualOptions.DockTabIndicatorColor = System.Drawing.Color.FromArgb(CType(CType(70,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(125,Byte),Integer))
        Me.QBuilder.VisualOptions.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(CType(CType(155,Byte),Integer), CType(CType(167,Byte),Integer), CType(CType(183,Byte),Integer))
        Me.QBuilder.VisualOptions.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(77,Byte),Integer), CType(CType(96,Byte),Integer), CType(CType(130,Byte),Integer))
        Me.QBuilder.VisualOptions.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White
        Me.QBuilder.VisualOptions.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.QBuilder.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(CType(CType(41,Byte),Integer), CType(CType(57,Byte),Integer), CType(CType(85,Byte),Integer))
        '
        'TextBoxSQL
        '
        Me.TextBoxSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSQL.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxSQL.Name = "TextBoxSQL"
        Me.TextBoxSQL.Size = New System.Drawing.Size(993, 110)
        Me.TextBoxSQL.TabIndex = 0
        Me.TextBoxSQL.Text = ""
        '
        'TextBoxReport
        '
        Me.TextBoxReport.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxReport.Location = New System.Drawing.Point(3, 562)
        Me.TextBoxReport.Name = "TextBoxReport"
        Me.TextBoxReport.Size = New System.Drawing.Size(993, 94)
        Me.TextBoxReport.TabIndex = 2
        Me.TextBoxReport.Text = ""
        '
        'ErrorBox1
        '
        Me.ErrorBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ErrorBox1.AutoSize = true
        Me.ErrorBox1.BackColor = System.Drawing.Color.LightPink
        Me.ErrorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorBox1.CurrentSyntaxProvider = Nothing
        Me.ErrorBox1.IsVisibleCheckSyntaxPanel = false
        Me.ErrorBox1.Location = New System.Drawing.Point(671, 46)
        Me.ErrorBox1.Name = "ErrorBox1"
        Me.ErrorBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.ErrorBox1.Size = New System.Drawing.Size(319, 61)
        Me.ErrorBox1.TabIndex = 1
        Me.ErrorBox1.Visible = false
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 659)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Datasource Fields Linking Drag’n’Drop demo"
        Me.tableLayoutPanel1.ResumeLayout(false)
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        Me.flowLayoutPanel1.ResumeLayout(false)
        Me.flowLayoutPanel1.PerformLayout
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        Me.splitContainer1.Panel2.PerformLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        CType(Me.QBuilder.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.QBuilder.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.QBuilder,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

	#End Region

	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private panel1 As System.Windows.Forms.Panel
	Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
	Private CheckBoxBeforeDsFieldDrag As System.Windows.Forms.CheckBox
	Private CheckBoxLinkDragOver As System.Windows.Forms.CheckBox
	Private label1 As System.Windows.Forms.Label
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private WithEvents QBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private WithEvents TextBoxSQL As System.Windows.Forms.RichTextBox
	Private WithEvents TextBoxReport As System.Windows.Forms.RichTextBox
    Friend WithEvents ErrorBox1 As Common.ErrorBox
End Class

