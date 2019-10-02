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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim LinkPainterAccess1 As ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess = New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.rbQuery = New System.Windows.Forms.RadioButton()
        Me.rbSubQuery = New System.Windows.Forms.RadioButton()
        Me.rbUnionSubQuery = New System.Windows.Forms.RadioButton()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.connectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.connectToMicrosoftSQLServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.connectToOracleServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.connectToMicrosoftAccessDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.connectToDatabaseThroughOLEDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.connectToDatabaseThroughODBCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPageQueryText = New System.Windows.Forms.TabPage()
        Me.ErrorBox1 = New SubQueryResultsPreview.Common.ErrorBox()
        Me.tabPageResultsPreview = New System.Windows.Forms.TabPage()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.label4 = New System.Windows.Forms.Label()
        CType(Me.queryBuilder,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).BeginInit
        Me.menuStrip1.SuspendLayout
        Me.tabControl1.SuspendLayout
        Me.tabPageQueryText.SuspendLayout
        Me.tabPageResultsPreview.SuspendLayout
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'queryBuilder
        '
        Me.queryBuilder.AddObjectDialogOptions.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder.AddObjectDialogOptions.Size = New System.Drawing.Size(430, 430)
        Me.queryBuilder.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.queryBuilder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.queryBuilder.DatabaseSchemaViewOptions.AllowDrop = True
        Me.queryBuilder.DatabaseSchemaViewOptions.BackColor = System.Drawing.SystemColors.Window
        Me.queryBuilder.DatabaseSchemaViewOptions.DrawTreeLines = False
        Me.queryBuilder.DatabaseSchemaViewOptions.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.queryBuilder.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder.DatabaseSchemaViewOptions.TextColor = System.Drawing.SystemColors.WindowText
        Me.queryBuilder.DataSourceOptions.BackgroundColor = System.Drawing.SystemColors.Window
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.DescriptionColumnOptions.Color = System.Drawing.Color.LightBlue
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = CType(resources.GetObject("resource.PrimaryKeyIcon"), System.Drawing.Image)
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.NameColumnOptions.Color = System.Drawing.SystemColors.WindowText
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.NameColumnOptions.PrimaryKeyColor = System.Drawing.SystemColors.WindowText
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.TypeColumnOptions.Color = System.Drawing.SystemColors.GrayText
        Me.queryBuilder.DataSourceOptions.FocusedBackgroundColor = System.Drawing.SystemColors.Window
        Me.queryBuilder.DataSourceOptions.Font = Nothing
        Me.queryBuilder.DesignPaneOptions.BackColor = System.Drawing.SystemColors.Window
        Me.queryBuilder.DesignPaneOptions.Background = System.Drawing.SystemColors.Window
        LinkPainterAccess1.LinkColor = System.Drawing.Color.Black
        LinkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black
        LinkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control
        LinkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark
        LinkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder.DesignPaneOptions.LinkPainterOptions = LinkPainterAccess1
        Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.queryBuilder.Location = New System.Drawing.Point(12, 99)
        Me.queryBuilder.MetadataStructureOptions.ProceduresFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.SynonymsFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.TablesFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.ViewsFolderText = Nothing
        Me.queryBuilder.Name = "queryBuilder"
        Me.queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = True
        Me.queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder.PanesConfigurationOptions.PropertiesBarEnabled = True
        Me.queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = True
        Me.queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = True
        Me.queryBuilder.QueryColumnListOptions.AlternateRowColor = System.Drawing.SystemColors.Highlight
        Me.queryBuilder.QueryColumnListOptions.BackColor = System.Drawing.SystemColors.Window
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90.0R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100.0R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 140.0R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 200.0R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60.0R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 250.0R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 100.0R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55.0R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 100.0R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 60.0R
        Me.queryBuilder.QueryColumnListOptions.EmptySpaceColor = System.Drawing.SystemColors.ControlDark
        Me.queryBuilder.QueryColumnListOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.queryBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder.QueryColumnListOptions.NullOrderingInOrderBy = False
        Me.queryBuilder.QueryColumnListOptions.TextColor = System.Drawing.SystemColors.ControlText
        Me.queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green
        Me.queryBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = false
        Me.queryBuilder.QueryNavBarOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryBuilder.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
        Me.queryBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black
        Me.queryBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue
        Me.queryBuilder.Size = New System.Drawing.Size(926, 392)
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
        Me.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        '
        '
        '
        Me.queryBuilder.SQLGenerationOptions.ExpandVirtualFields = true
        Me.queryBuilder.SQLGenerationOptions.ExpandVirtualObjects = true
        Me.queryBuilder.TabIndex = 3
        Me.queryBuilder.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(242,Byte),Integer), CType(CType(157,Byte),Integer))
        Me.queryBuilder.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black
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
        'textBox1
        '
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.Font = New System.Drawing.Font("Courier New", 9!)
        Me.textBox1.Location = New System.Drawing.Point(3, 3)
        Me.textBox1.Multiline = true
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox1.Size = New System.Drawing.Size(912, 127)
        Me.textBox1.TabIndex = 4
        '
        'rbQuery
        '
        Me.rbQuery.AutoSize = true
        Me.rbQuery.ForeColor = System.Drawing.Color.Maroon
        Me.rbQuery.Location = New System.Drawing.Point(136, 27)
        Me.rbQuery.Name = "rbQuery"
        Me.rbQuery.Size = New System.Drawing.Size(72, 17)
        Me.rbQuery.TabIndex = 0
        Me.rbQuery.TabStop = true
        Me.rbQuery.Text = "Full Query"
        Me.rbQuery.UseVisualStyleBackColor = true
        '
        'rbSubQuery
        '
        Me.rbSubQuery.AutoSize = true
        Me.rbSubQuery.ForeColor = System.Drawing.Color.Maroon
        Me.rbSubQuery.Location = New System.Drawing.Point(136, 50)
        Me.rbSubQuery.Name = "rbSubQuery"
        Me.rbSubQuery.Size = New System.Drawing.Size(73, 17)
        Me.rbSubQuery.TabIndex = 1
        Me.rbSubQuery.TabStop = true
        Me.rbSubQuery.Text = "Sub-query"
        Me.rbSubQuery.UseVisualStyleBackColor = true
        '
        'rbUnionSubQuery
        '
        Me.rbUnionSubQuery.AutoSize = true
        Me.rbUnionSubQuery.ForeColor = System.Drawing.Color.Maroon
        Me.rbUnionSubQuery.Location = New System.Drawing.Point(136, 73)
        Me.rbUnionSubQuery.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.rbUnionSubQuery.Name = "rbUnionSubQuery"
        Me.rbUnionSubQuery.Size = New System.Drawing.Size(102, 17)
        Me.rbUnionSubQuery.TabIndex = 2
        Me.rbUnionSubQuery.TabStop = true
        Me.rbUnionSubQuery.Text = "Union sub-query"
        Me.rbUnionSubQuery.UseVisualStyleBackColor = true
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(244, 75)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(627, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Show only tabs related to selected UNION; show text of selected UNION only. Acts "& _ 
    "like the previous mode if select a sub-query tab."
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(244, 52)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(398, 13)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Show only tabs related to selected sub-query; show text of selected sub-query onl"& _ 
    "y."
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(244, 29)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(223, 13)
        Me.label3.TabIndex = 7
        Me.label3.Text = "Show all subquery tabs and the full query text."
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.connectToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(950, 24)
        Me.menuStrip1.TabIndex = 8
        Me.menuStrip1.Text = "menuStrip1"
        '
        'connectToolStripMenuItem
        '
        Me.connectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.connectToMicrosoftSQLServerToolStripMenuItem, Me.connectToOracleServerToolStripMenuItem, Me.connectToMicrosoftAccessDatabaseToolStripMenuItem, Me.toolStripSeparator1, Me.connectToDatabaseThroughOLEDBToolStripMenuItem, Me.connectToDatabaseThroughODBCToolStripMenuItem})
        Me.connectToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.connectToolStripMenuItem.Name = "connectToolStripMenuItem"
        Me.connectToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.connectToolStripMenuItem.Text = "Connect Database"
        '
        'connectToMicrosoftSQLServerToolStripMenuItem
        '
        Me.connectToMicrosoftSQLServerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.connectToMicrosoftSQLServerToolStripMenuItem.Name = "connectToMicrosoftSQLServerToolStripMenuItem"
        Me.connectToMicrosoftSQLServerToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.connectToMicrosoftSQLServerToolStripMenuItem.Text = "Connect to Microsoft SQL Server"
        '
        'connectToOracleServerToolStripMenuItem
        '
        Me.connectToOracleServerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.connectToOracleServerToolStripMenuItem.Name = "connectToOracleServerToolStripMenuItem"
        Me.connectToOracleServerToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.connectToOracleServerToolStripMenuItem.Text = "Connect to Oracle Server"
        '
        'connectToMicrosoftAccessDatabaseToolStripMenuItem
        '
        Me.connectToMicrosoftAccessDatabaseToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.connectToMicrosoftAccessDatabaseToolStripMenuItem.Name = "connectToMicrosoftAccessDatabaseToolStripMenuItem"
        Me.connectToMicrosoftAccessDatabaseToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.connectToMicrosoftAccessDatabaseToolStripMenuItem.Text = "Connect to Microsoft Access database"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(273, 6)
        '
        'connectToDatabaseThroughOLEDBToolStripMenuItem
        '
        Me.connectToDatabaseThroughOLEDBToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.connectToDatabaseThroughOLEDBToolStripMenuItem.Name = "connectToDatabaseThroughOLEDBToolStripMenuItem"
        Me.connectToDatabaseThroughOLEDBToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.connectToDatabaseThroughOLEDBToolStripMenuItem.Text = "Connect to database through OLE DB"
        '
        'connectToDatabaseThroughODBCToolStripMenuItem
        '
        Me.connectToDatabaseThroughODBCToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.connectToDatabaseThroughODBCToolStripMenuItem.Name = "connectToDatabaseThroughODBCToolStripMenuItem"
        Me.connectToDatabaseThroughODBCToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.connectToDatabaseThroughODBCToolStripMenuItem.Text = "Connect to database through ODBC"
        '
        'tabControl1
        '
        Me.tabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tabControl1.Controls.Add(Me.tabPageQueryText)
        Me.tabControl1.Controls.Add(Me.tabPageResultsPreview)
        Me.tabControl1.Location = New System.Drawing.Point(12, 497)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(926, 159)
        Me.tabControl1.TabIndex = 9
        '
        'tabPageQueryText
        '
        Me.tabPageQueryText.Controls.Add(Me.ErrorBox1)
        Me.tabPageQueryText.Controls.Add(Me.textBox1)
        Me.tabPageQueryText.Location = New System.Drawing.Point(4, 22)
        Me.tabPageQueryText.Name = "tabPageQueryText"
        Me.tabPageQueryText.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageQueryText.Size = New System.Drawing.Size(918, 133)
        Me.tabPageQueryText.TabIndex = 0
        Me.tabPageQueryText.Text = "Selected Query Part Text"
        Me.tabPageQueryText.UseVisualStyleBackColor = true
        '
        'ErrorBox1
        '
        Me.ErrorBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ErrorBox1.AutoSize = true
        Me.ErrorBox1.BackColor = System.Drawing.Color.LightPink
        Me.ErrorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorBox1.CurrentSyntaxProvider = Nothing
        Me.ErrorBox1.IsVisibleCheckSyntaxPanel = false
        Me.ErrorBox1.Location = New System.Drawing.Point(520, 66)
        Me.ErrorBox1.Name = "ErrorBox1"
        Me.ErrorBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.ErrorBox1.Size = New System.Drawing.Size(372, 61)
        Me.ErrorBox1.TabIndex = 5
        Me.ErrorBox1.Visible = false
        '
        'tabPageResultsPreview
        '
        Me.tabPageResultsPreview.Controls.Add(Me.dataGridView1)
        Me.tabPageResultsPreview.Location = New System.Drawing.Point(4, 22)
        Me.tabPageResultsPreview.Name = "tabPageResultsPreview"
        Me.tabPageResultsPreview.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageResultsPreview.Size = New System.Drawing.Size(918, 133)
        Me.tabPageResultsPreview.TabIndex = 1
        Me.tabPageResultsPreview.Text = "---> Results Preview <---"
        Me.tabPageResultsPreview.UseVisualStyleBackColor = true
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(912, 127)
        Me.dataGridView1.TabIndex = 0
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(12, 29)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(106, 13)
        Me.label4.TabIndex = 10
        Me.label4.Text = "Query part to display:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 668)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.rbUnionSubQuery)
        Me.Controls.Add(Me.rbSubQuery)
        Me.Controls.Add(Me.rbQuery)
        Me.Controls.Add(Me.queryBuilder)
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.Text = "Preview Sub-query Results"
        CType(Me.queryBuilder.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder,System.ComponentModel.ISupportInitialize).EndInit
        Me.menuStrip1.ResumeLayout(false)
        Me.menuStrip1.PerformLayout
        Me.tabControl1.ResumeLayout(false)
        Me.tabPageQueryText.ResumeLayout(false)
        Me.tabPageQueryText.PerformLayout
        Me.tabPageResultsPreview.ResumeLayout(false)
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

	#End Region

	Private WithEvents queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private WithEvents textBox1 As System.Windows.Forms.TextBox
	Private WithEvents rbQuery As System.Windows.Forms.RadioButton
	Private WithEvents rbSubQuery As System.Windows.Forms.RadioButton
	Private WithEvents rbUnionSubQuery As System.Windows.Forms.RadioButton
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private WithEvents connectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents connectToMicrosoftSQLServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents connectToOracleServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents connectToMicrosoftAccessDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private WithEvents connectToDatabaseThroughOLEDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents connectToDatabaseThroughODBCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents tabControl1 As System.Windows.Forms.TabControl
	Private tabPageQueryText As System.Windows.Forms.TabPage
	Private tabPageResultsPreview As System.Windows.Forms.TabPage
	Private label4 As System.Windows.Forms.Label
	Private dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorBox1 As Common.ErrorBox
End Class

