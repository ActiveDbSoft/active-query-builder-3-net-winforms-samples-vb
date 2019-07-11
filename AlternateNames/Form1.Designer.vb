Imports ActiveQueryBuilder.View.WinForms

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
        Dim LinkPainterAccess2 As ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess = New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.imageList16 = New System.Windows.Forms.ImageList(Me.components)
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.editMetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imageList32 = New System.Windows.Forms.ImageList(Me.components)
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.ErrorBox1 = New AlternateNames.Common.ErrorBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.ErrorBoxReal = New AlternateNames.Common.ErrorBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.menuStrip1.SuspendLayout
        CType(Me.queryBuilder1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder1.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryBuilder1.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer1.Panel1.SuspendLayout
        Me.splitContainer1.Panel2.SuspendLayout
        Me.splitContainer1.SuspendLayout
        Me.tabControl1.SuspendLayout
        Me.tabPage1.SuspendLayout
        Me.tabPage2.SuspendLayout
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
        'queryBuilder1
        '
        Me.queryBuilder1.AddObjectDialogOptions.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder1.AddObjectDialogOptions.Size = New System.Drawing.Size(430, 430)
        Me.queryBuilder1.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = false
        Me.queryBuilder1.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder1.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = CType(resources.GetObject("resource.PrimaryKeyIcon"),System.Drawing.Image)
        Me.queryBuilder1.DataSourceOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryBuilder1.DesignPaneOptions.Background = System.Drawing.SystemColors.Window
        LinkPainterAccess2.LinkColor = System.Drawing.Color.Black
        LinkPainterAccess2.LinkColorFocused = System.Drawing.Color.Black
        LinkPainterAccess2.MarkColor = System.Drawing.SystemColors.Control
        LinkPainterAccess2.MarkColorFocused = System.Drawing.SystemColors.ControlDark
        LinkPainterAccess2.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder1.DesignPaneOptions.LinkPainterOptions = LinkPainterAccess2
        Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.queryBuilder1.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.queryBuilder1.Location = New System.Drawing.Point(0, 0)
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 250
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
        Me.queryBuilder1.Size = New System.Drawing.Size(793, 358)
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
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.tabControl1)
        Me.splitContainer1.Size = New System.Drawing.Size(793, 506)
        Me.splitContainer1.SplitterDistance = 358
        Me.splitContainer1.TabIndex = 2
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(793, 144)
        Me.tabControl1.TabIndex = 0
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.ErrorBox1)
        Me.tabPage1.Controls.Add(Me.textBox1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(785, 118)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Query text with alternate object names"
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
        Me.ErrorBox1.Location = New System.Drawing.Point(402, 49)
        Me.ErrorBox1.Name = "ErrorBox1"
        Me.ErrorBox1.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ErrorBox1.Size = New System.Drawing.Size(356, 61)
        Me.ErrorBox1.TabIndex = 2
        Me.ErrorBox1.Visible = false
        '
        'textBox1
        '
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.Font = New System.Drawing.Font("Courier New", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.textBox1.HideSelection = false
        Me.textBox1.Location = New System.Drawing.Point(3, 3)
        Me.textBox1.Multiline = true
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox1.Size = New System.Drawing.Size(779, 112)
        Me.textBox1.TabIndex = 1
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.ErrorBoxReal)
        Me.tabPage2.Controls.Add(Me.textBox2)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(785, 118)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Query text with real object names"
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
        Me.ErrorBoxReal.Location = New System.Drawing.Point(399, 51)
        Me.ErrorBoxReal.Name = "ErrorBoxReal"
        Me.ErrorBoxReal.Padding = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.ErrorBoxReal.Size = New System.Drawing.Size(362, 61)
        Me.ErrorBoxReal.TabIndex = 3
        Me.ErrorBoxReal.Visible = false
        '
        'textBox2
        '
        Me.textBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox2.Font = New System.Drawing.Font("Courier New", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.textBox2.HideSelection = false
        Me.textBox2.Location = New System.Drawing.Point(3, 3)
        Me.textBox2.Multiline = true
        Me.textBox2.Name = "textBox2"
        Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox2.Size = New System.Drawing.Size(779, 112)
        Me.textBox2.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 530)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AlternateNames Demo"
        Me.menuStrip1.ResumeLayout(false)
        Me.menuStrip1.PerformLayout
        CType(Me.queryBuilder1.SQLFormattingOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder1.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryBuilder1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        Me.tabControl1.ResumeLayout(false)
        Me.tabPage1.ResumeLayout(false)
        Me.tabPage1.PerformLayout
        Me.tabPage2.ResumeLayout(false)
        Me.tabPage2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

#End Region

	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private imageList16 As System.Windows.Forms.ImageList
	Private imageList32 As System.Windows.Forms.ImageList
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private WithEvents queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private tabControl1 As System.Windows.Forms.TabControl
	Private tabPage1 As System.Windows.Forms.TabPage
	Private WithEvents textBox1 As System.Windows.Forms.TextBox
	Private tabPage2 As System.Windows.Forms.TabPage
	Private WithEvents textBox2 As System.Windows.Forms.TextBox
	Private WithEvents editMetadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorBox1 As Common.ErrorBox
    Friend WithEvents ErrorBoxReal As Common.ErrorBox
End Class

