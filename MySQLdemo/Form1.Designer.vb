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
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPageSQL = New System.Windows.Forms.TabPage()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.mySQLMetadataProvider1 = New ActiveQueryBuilder.Core.MySQLMetadataProvider(Me.components)
        Me.mySQLSyntaxProvider1 = New ActiveQueryBuilder.Core.MySQLSyntaxProvider(Me.components)
        Me.ErrorBox1 = New MySQLdemo.Common.ErrorBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.tabPageData = New System.Windows.Forms.TabPage()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.imageList16 = New System.Windows.Forms.ImageList(Me.components)
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.connectMetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.metadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.refreshMetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editMetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clearMetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.loadFromXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveToXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.queryStatisticsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openMetadataFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.saveMetadataFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.imageList32 = New System.Windows.Forms.ImageList(Me.components)
        Me.tabControl1.SuspendLayout
        Me.tabPageSQL.SuspendLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer1.Panel1.SuspendLayout
        Me.splitContainer1.Panel2.SuspendLayout
        Me.splitContainer1.SuspendLayout
        CType(Me.queryBuilder,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPageData.SuspendLayout
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.menuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPageSQL)
        Me.tabControl1.Controls.Add(Me.tabPageData)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Location = New System.Drawing.Point(0, 24)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(793, 506)
        Me.tabControl1.TabIndex = 0
        '
        'tabPageSQL
        '
        Me.tabPageSQL.Controls.Add(Me.splitContainer1)
        Me.tabPageSQL.Location = New System.Drawing.Point(4, 22)
        Me.tabPageSQL.Name = "tabPageSQL"
        Me.tabPageSQL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageSQL.Size = New System.Drawing.Size(785, 480)
        Me.tabPageSQL.TabIndex = 0
        Me.tabPageSQL.Text = "SQL"
        Me.tabPageSQL.UseVisualStyleBackColor = true
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.ErrorBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.textBox1)
        Me.splitContainer1.Size = New System.Drawing.Size(779, 474)
        Me.splitContainer1.SplitterDistance = 364
        Me.splitContainer1.TabIndex = 0
        '
        'queryBuilder
        '
        Me.queryBuilder.AddObjectDialogOptions.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder.AddObjectDialogOptions.Size = New System.Drawing.Size(430, 430)
        Me.queryBuilder.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.queryBuilder.DatabaseSchemaViewOptions.DrawTreeLines = false
        Me.queryBuilder.DatabaseSchemaViewOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
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
        Me.queryBuilder.MetadataProvider = Me.mySQLMetadataProvider1
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
        Me.queryBuilder.Size = New System.Drawing.Size(779, 364)
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
        Me.queryBuilder.SyntaxProvider = Me.mySQLSyntaxProvider1
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
        'mySQLMetadataProvider1
        '
        Me.mySQLMetadataProvider1.Connection = Nothing
        '
        'mySQLSyntaxProvider1
        '
        Me.mySQLSyntaxProvider1.OnCalcExpressionType = Nothing
        Me.mySQLSyntaxProvider1.ServerVersion = "5.02"
        Me.mySQLSyntaxProvider1.ServerVersionInt = 50200
        '
        'ErrorBox1
        '
        Me.ErrorBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ErrorBox1.AutoSize = true
        Me.ErrorBox1.BackColor = System.Drawing.Color.LightPink
        Me.ErrorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorBox1.CurrentSyntaxProvider = Nothing
        Me.ErrorBox1.IsVisibleCheckSyntaxPanel = false
        Me.ErrorBox1.Location = New System.Drawing.Point(464, 40)
        Me.ErrorBox1.Name = "ErrorBox1"
        Me.ErrorBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.ErrorBox1.Size = New System.Drawing.Size(293, 61)
        Me.ErrorBox1.TabIndex = 1
        Me.ErrorBox1.Visible = false
        '
        'textBox1
        '
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.HideSelection = false
        Me.textBox1.Location = New System.Drawing.Point(0, 0)
        Me.textBox1.Multiline = true
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox1.Size = New System.Drawing.Size(779, 106)
        Me.textBox1.TabIndex = 0
        '
        'tabPageData
        '
        Me.tabPageData.Controls.Add(Me.dataGridView1)
        Me.tabPageData.Location = New System.Drawing.Point(4, 22)
        Me.tabPageData.Name = "tabPageData"
        Me.tabPageData.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageData.Size = New System.Drawing.Size(785, 480)
        Me.tabPageData.TabIndex = 1
        Me.tabPageData.Text = "Data"
        Me.tabPageData.UseVisualStyleBackColor = true
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = false
        Me.dataGridView1.AllowUserToDeleteRows = false
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = true
        Me.dataGridView1.Size = New System.Drawing.Size(779, 474)
        Me.dataGridView1.TabIndex = 0
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
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.connectMetadataToolStripMenuItem, Me.metadataToolStripMenuItem, Me.queryStatisticsMenuItem, Me.aboutToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuStrip1.Size = New System.Drawing.Size(793, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        '
        'connectMetadataToolStripMenuItem
        '
        Me.connectMetadataToolStripMenuItem.Name = "connectMetadataToolStripMenuItem"
        Me.connectMetadataToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.connectMetadataToolStripMenuItem.Text = "Connect..."
        '
        'metadataToolStripMenuItem
        '
        Me.metadataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.refreshMetadataToolStripMenuItem, Me.editMetadataToolStripMenuItem, Me.clearMetadataToolStripMenuItem, Me.toolStripSeparator1, Me.loadFromXMLToolStripMenuItem, Me.saveToXMLToolStripMenuItem})
        Me.metadataToolStripMenuItem.Name = "metadataToolStripMenuItem"
        Me.metadataToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.metadataToolStripMenuItem.Text = "Metadata"
        '
        'refreshMetadataToolStripMenuItem
        '
        Me.refreshMetadataToolStripMenuItem.Name = "refreshMetadataToolStripMenuItem"
        Me.refreshMetadataToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.refreshMetadataToolStripMenuItem.Text = "Refresh Metadata"
        '
        'editMetadataToolStripMenuItem
        '
        Me.editMetadataToolStripMenuItem.Name = "editMetadataToolStripMenuItem"
        Me.editMetadataToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.editMetadataToolStripMenuItem.Text = "Edit Metadata..."
        '
        'clearMetadataToolStripMenuItem
        '
        Me.clearMetadataToolStripMenuItem.Name = "clearMetadataToolStripMenuItem"
        Me.clearMetadataToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.clearMetadataToolStripMenuItem.Text = "Clear Metadata"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'loadFromXMLToolStripMenuItem
        '
        Me.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem"
        Me.loadFromXMLToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.loadFromXMLToolStripMenuItem.Text = "Load from XML..."
        '
        'saveToXMLToolStripMenuItem
        '
        Me.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem"
        Me.saveToXMLToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.saveToXMLToolStripMenuItem.Text = "Save to XML..."
        '
        'queryStatisticsMenuItem
        '
        Me.queryStatisticsMenuItem.Name = "queryStatisticsMenuItem"
        Me.queryStatisticsMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.queryStatisticsMenuItem.Text = "Query Statistics..."
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.aboutToolStripMenuItem.Text = "About..."
        '
        'openMetadataFileDialog
        '
        Me.openMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        '
        'saveMetadataFileDialog
        '
        Me.saveMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        '
        'imageList32
        '
        Me.imageList32.ImageStream = CType(resources.GetObject("imageList32.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.imageList32.TransparentColor = System.Drawing.Color.Magenta
        Me.imageList32.Images.SetKeyName(0, "0.bmp")
        Me.imageList32.Images.SetKeyName(1, "1.bmp")
        Me.imageList32.Images.SetKeyName(2, "2.bmp")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 530)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.tabControl1.ResumeLayout(false)
        Me.tabPageSQL.ResumeLayout(false)
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        Me.splitContainer1.Panel2.PerformLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        CType(Me.queryBuilder.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPageData.ResumeLayout(false)
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.menuStrip1.ResumeLayout(false)
        Me.menuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

#End Region

    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private tabPageSQL As System.Windows.Forms.TabPage
    Private tabPageData As System.Windows.Forms.TabPage
    Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private dataGridView1 As System.Windows.Forms.DataGridView
    Private menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents connectMetadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents metadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents refreshMetadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents editMetadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents clearMetadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents saveToXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents loadFromXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents openMetadataFileDialog As System.Windows.Forms.OpenFileDialog
    Private WithEvents saveMetadataFileDialog As System.Windows.Forms.SaveFileDialog
    Private imageList16 As System.Windows.Forms.ImageList
    Private imageList32 As System.Windows.Forms.ImageList
    Private WithEvents queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private mySQLSyntaxProvider1 As ActiveQueryBuilder.Core.MySQLSyntaxProvider
    Private mySQLMetadataProvider1 As ActiveQueryBuilder.Core.MySQLMetadataProvider
    Private WithEvents queryStatisticsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorBox1 As Common.ErrorBox
End Class

