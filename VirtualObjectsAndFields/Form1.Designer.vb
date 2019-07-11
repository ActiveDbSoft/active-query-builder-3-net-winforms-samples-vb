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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim LinkPainterAccess1 As ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess = New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.imageList16 = New System.Windows.Forms.ImageList(Me.components)
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.editMetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imageList32 = New System.Windows.Forms.ImageList(Me.components)
        Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.ErrorBox1 = New VirtualObjectsAndFields.Common.ErrorBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.ErrorBoxReal = New VirtualObjectsAndFields.Common.ErrorBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.sqlFormattingOptions1 = New ActiveQueryBuilder.Core.SQLFormattingOptions()
        Me.sqlFormattingOptions2 = New ActiveQueryBuilder.Core.SQLFormattingOptions()
        Me.menuStrip1.SuspendLayout
        CType(Me.queryBuilder,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer1.Panel1.SuspendLayout
        Me.splitContainer1.Panel2.SuspendLayout
        Me.splitContainer1.SuspendLayout
        Me.tabControl1.SuspendLayout
        Me.tabPage1.SuspendLayout
        Me.tabPage2.SuspendLayout
        Me.panel1.SuspendLayout
        CType(Me.sqlFormattingOptions1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sqlFormattingOptions2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'imageList16
        '
        Me.imageList16.ImageStream = CType(resources.GetObject("imageList16.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.imageList16.TransparentColor = System.Drawing.Color.Magenta
        Me.imageList16.Images.SetKeyName(0, "0.bmp")
        Me.imageList16.Images.SetKeyName(1, "1.bmp")
        Me.imageList16.Images.SetKeyName(2, "2.bmp")
        Me.imageList16.Images.SetKeyName(3, "3.bmp")
        Me.imageList16.Images.SetKeyName(4, "4.bmp")
        Me.imageList16.Images.SetKeyName(5, "5.bmp")
        Me.imageList16.Images.SetKeyName(6, "6.bmp")
        Me.imageList16.Images.SetKeyName(7, "7.bmp")
        Me.imageList16.Images.SetKeyName(8, "8.bmp")
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.editMetadataToolStripMenuItem, Me.aboutToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuStrip1.Size = New System.Drawing.Size(793, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        '
        'editMetadataToolStripMenuItem
        '
        Me.editMetadataToolStripMenuItem.Name = "editMetadataToolStripMenuItem"
        Me.editMetadataToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.editMetadataToolStripMenuItem.Text = "Edit Metadata..."
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.aboutToolStripMenuItem.Text = "About..."
        '
        'imageList32
        '
        Me.imageList32.ImageStream = CType(resources.GetObject("imageList32.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.imageList32.TransparentColor = System.Drawing.Color.Magenta
        Me.imageList32.Images.SetKeyName(0, "0.bmp")
        Me.imageList32.Images.SetKeyName(1, "1.bmp")
        Me.imageList32.Images.SetKeyName(2, "2.bmp")
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
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = CType(resources.GetObject("resource.PrimaryKeyIcon"),System.Drawing.Image)
        Me.queryBuilder.DataSourceOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryBuilder.DesignPaneOptions.Background = System.Drawing.SystemColors.Window
        LinkPainterAccess1.LinkColor = System.Drawing.Color.Black
        LinkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black
        LinkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control
        LinkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark
        LinkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder.DesignPaneOptions.LinkPainterOptions = LinkPainterAccess1
        Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.queryBuilder.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.queryBuilder.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder.MetadataStructureOptions.ProceduresFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.SynonymsFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.TablesFolderText = Nothing
        Me.queryBuilder.MetadataStructureOptions.ViewsFolderText = Nothing
        Me.queryBuilder.Name = "queryBuilder"
        Me.queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true
        Me.queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder.PanesConfigurationOptions.PropertiesBarEnabled = true
        Me.queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true
        Me.queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = true
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 140R
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8
        Me.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 200R
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
        Me.queryBuilder.QueryColumnListOptions.Font = Nothing
        Me.queryBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder.QueryColumnListOptions.NullOrderingInOrderBy = false
        Me.queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green
        Me.queryBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = false
        Me.queryBuilder.QueryNavBarOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryBuilder.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
        Me.queryBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black
        Me.queryBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue
        Me.queryBuilder.Size = New System.Drawing.Size(793, 316)
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
        Me.queryBuilder.TabIndex = 0
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
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 83)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.tabControl1)
        Me.splitContainer1.Size = New System.Drawing.Size(793, 447)
        Me.splitContainer1.SplitterDistance = 316
        Me.splitContainer1.TabIndex = 2
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Multiline = true
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(793, 127)
        Me.tabControl1.TabIndex = 0
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.ErrorBox1)
        Me.tabPage1.Controls.Add(Me.textBox1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(785, 101)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Query text with virtual objects and fields"
        Me.tabPage1.UseVisualStyleBackColor = true
        '
        'ErrorBox1
        '
        Me.ErrorBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ErrorBox1.AutoSize = true
        Me.ErrorBox1.BackColor = System.Drawing.Color.LightPink
        Me.ErrorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorBox1.CurrentSyntaxProvider = Nothing
        Me.ErrorBox1.IsVisibleCheckSyntaxPanel = false
        Me.ErrorBox1.Location = New System.Drawing.Point(430, 32)
        Me.ErrorBox1.Name = "ErrorBox1"
        Me.ErrorBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.ErrorBox1.Size = New System.Drawing.Size(332, 61)
        Me.ErrorBox1.TabIndex = 2
        Me.ErrorBox1.Visible = false
        '
        'textBox1
        '
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.HideSelection = false
        Me.textBox1.Location = New System.Drawing.Point(3, 3)
        Me.textBox1.Multiline = true
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox1.Size = New System.Drawing.Size(779, 95)
        Me.textBox1.TabIndex = 1
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.ErrorBoxReal)
        Me.tabPage2.Controls.Add(Me.textBox2)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(785, 101)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Real query text with virtual objects expanded to their expressions"
        Me.tabPage2.UseVisualStyleBackColor = true
        '
        'ErrorBoxReal
        '
        Me.ErrorBoxReal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ErrorBoxReal.AutoSize = true
        Me.ErrorBoxReal.BackColor = System.Drawing.Color.LightPink
        Me.ErrorBoxReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorBoxReal.CurrentSyntaxProvider = Nothing
        Me.ErrorBoxReal.IsVisibleCheckSyntaxPanel = false
        Me.ErrorBoxReal.Location = New System.Drawing.Point(385, 32)
        Me.ErrorBoxReal.Name = "ErrorBoxReal"
        Me.ErrorBoxReal.Padding = New System.Windows.Forms.Padding(5)
        Me.ErrorBoxReal.Size = New System.Drawing.Size(374, 61)
        Me.ErrorBoxReal.TabIndex = 3
        Me.ErrorBoxReal.Visible = false
        '
        'textBox2
        '
        Me.textBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox2.HideSelection = false
        Me.textBox2.Location = New System.Drawing.Point(3, 3)
        Me.textBox2.Multiline = true
        Me.textBox2.Name = "textBox2"
        Me.textBox2.ReadOnly = true
        Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox2.Size = New System.Drawing.Size(779, 95)
        Me.textBox2.TabIndex = 2
        '
        'panel1
        '
        Me.panel1.AutoSize = true
        Me.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel1.BackColor = System.Drawing.SystemColors.Info
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 24)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 4)
        Me.panel1.Size = New System.Drawing.Size(793, 59)
        Me.panel1.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.label1.Location = New System.Drawing.Point(2, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(669, 52)
        Me.label1.TabIndex = 0
        Me.label1.Text = resources.GetString("label1.Text")
        '
        'sqlFormattingOptions1
        '
        Me.sqlFormattingOptions1.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.DynamicIndents = false
        Me.sqlFormattingOptions1.DynamicRightMargin = false
        Me.sqlFormattingOptions1.ExpandVirtualFields = false
        Me.sqlFormattingOptions1.ExpandVirtualObjects = false
        Me.sqlFormattingOptions1.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false
        Me.sqlFormattingOptions1.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.ExpressionSubQueryFormat.MainPartsFromNewLine = false
        Me.sqlFormattingOptions1.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.KeywordFormat = ActiveQueryBuilder.Core.KeywordFormat.UpperCase
        Me.sqlFormattingOptions1.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        '
        'sqlFormattingOptions2
        '
        Me.sqlFormattingOptions2.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.DynamicIndents = false
        Me.sqlFormattingOptions2.DynamicRightMargin = false
        Me.sqlFormattingOptions2.ExpandVirtualFields = true
        Me.sqlFormattingOptions2.ExpandVirtualObjects = true
        Me.sqlFormattingOptions2.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false
        Me.sqlFormattingOptions2.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.ExpressionSubQueryFormat.MainPartsFromNewLine = false
        Me.sqlFormattingOptions2.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 530)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VirtualObjectsAndFields Demo"
        Me.menuStrip1.ResumeLayout(false)
        Me.menuStrip1.PerformLayout
        CType(Me.queryBuilder.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        Me.tabControl1.ResumeLayout(false)
        Me.tabPage1.ResumeLayout(false)
        Me.tabPage1.PerformLayout
        Me.tabPage2.ResumeLayout(false)
        Me.tabPage2.PerformLayout
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        CType(Me.sqlFormattingOptions1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sqlFormattingOptions2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private label1 As System.Windows.Forms.Label
    Private panel1 As System.Windows.Forms.Panel

#End Region

    Private menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private imageList16 As System.Windows.Forms.ImageList
    Private imageList32 As System.Windows.Forms.ImageList
    Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private tabControl1 As System.Windows.Forms.TabControl
    Private tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents editMetadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private sqlFormattingOptions1 As ActiveQueryBuilder.Core.SQLFormattingOptions
    Private sqlFormattingOptions2 As ActiveQueryBuilder.Core.SQLFormattingOptions
    Friend WithEvents ErrorBox1 As Common.ErrorBox
    Friend WithEvents ErrorBoxReal As Common.ErrorBox
End Class

