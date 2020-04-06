
Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim linkPainterAccess2 As New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.imageList16 = New ImageList(Me.components)
        Me.menuStrip1 = New MenuStrip()
        Me.editMetadataToolStripMenuItem = New ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New ToolStripMenuItem()
        Me.imageList32 = New ImageList(Me.components)
        Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.splitContainer1 = New SplitContainer()
        Me.tabControl1 = New TabControl()
        Me.tabPage1 = New TabPage()
        Me.textBox1 = New TextBox()
        Me.tabPage2 = New TabPage()
        Me.textBox2 = New TextBox()
        Me.panel1 = New Panel()
        Me.label1 = New Label()
        Me.sqlFormattingOptions1 = New ActiveQueryBuilder.Core.SQLFormattingOptions()
        Me.sqlFormattingOptions2 = New ActiveQueryBuilder.Core.SQLFormattingOptions()
        Me.errorBox1 = New Common.SqlErrorBox()
        Me.errorBoxReal = New Common.SqlErrorBox()
        Me.menuStrip1.SuspendLayout()
        CType(Me.queryBuilder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.sqlFormattingOptions1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sqlFormattingOptions2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' imageList16
        ' 
        Me.imageList16.ImageStream = (CType(resources.GetObject("imageList16.ImageStream"), ImageListStreamer))
        Me.imageList16.TransparentColor = Color.Magenta
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
        ' menuStrip1
        ' 
        Me.menuStrip1.Items.AddRange(New ToolStripItem() { Me.editMetadataToolStripMenuItem, Me.aboutToolStripMenuItem})
        Me.menuStrip1.Location = New Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.RenderMode = ToolStripRenderMode.System
        Me.menuStrip1.Size = New Size(793, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        ' 
        ' editMetadataToolStripMenuItem
        ' 
        Me.editMetadataToolStripMenuItem.Name = "editMetadataToolStripMenuItem"
        Me.editMetadataToolStripMenuItem.Size = New Size(101, 20)
        Me.editMetadataToolStripMenuItem.Text = "Edit Metadata..."
'			Me.editMetadataToolStripMenuItem.Click += New System.EventHandler(Me.editMetadataToolStripMenuItem_Click)
        ' 
        ' aboutToolStripMenuItem
        ' 
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New Size(61, 20)
        Me.aboutToolStripMenuItem.Text = "About..."
'			Me.aboutToolStripMenuItem.Click += New System.EventHandler(Me.aboutToolStripMenuItem_Click)
        ' 
        ' imageList32
        ' 
        Me.imageList32.ImageStream = (CType(resources.GetObject("imageList32.ImageStream"), ImageListStreamer))
        Me.imageList32.TransparentColor = Color.Magenta
        Me.imageList32.Images.SetKeyName(0, "0.bmp")
        Me.imageList32.Images.SetKeyName(1, "1.bmp")
        Me.imageList32.Images.SetKeyName(2, "2.bmp")
        ' 
        ' queryBuilder
        ' 
        Me.queryBuilder.AddObjectDialogOptions.Location = New Point(0, 0)
        Me.queryBuilder.AddObjectDialogOptions.Size = New Size(430, 430)
        Me.queryBuilder.AddObjectDialogOptions.StartPosition = FormStartPosition.CenterScreen
        Me.queryBuilder.DatabaseSchemaViewOptions.DrawTreeLines = False
        Me.queryBuilder.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = (CType(resources.GetObject("resource.PrimaryKeyIcon"), Image))
        Me.queryBuilder.DataSourceOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder.DesignPaneOptions.Background = SystemColors.Window
        linkPainterAccess2.LinkColor = Color.Black
        linkPainterAccess2.LinkColorFocused = Color.Black
        linkPainterAccess2.MarkColor = SystemColors.Control
        linkPainterAccess2.MarkColorFocused = SystemColors.ControlDark
        linkPainterAccess2.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder.DesignPaneOptions.LinkPainterOptions = linkPainterAccess2
        Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder.Dock = DockStyle.Fill
        Me.queryBuilder.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.World)
        Me.queryBuilder.Location = New Point(0, 0)
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
        Me.queryBuilder.QueryColumnListOptions.NullOrderingInOrderBy = False
        Me.queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder.QueryNavBarOptions.CTEButtonBaseColor = Color.Green
        Me.queryBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = False
        Me.queryBuilder.QueryNavBarOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder.QueryNavBarOptions.OverflowButtonBaseColor = Color.DarkRed
        Me.queryBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = Color.Black
        Me.queryBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = Color.Blue
        Me.queryBuilder.Size = New Size(793, 316)
        ' 
        ' 
        ' 
        Me.queryBuilder.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.DynamicIndents = False
        Me.queryBuilder.SQLFormattingOptions.DynamicRightMargin = False
        Me.queryBuilder.SQLFormattingOptions.ExpandVirtualFields = False
        Me.queryBuilder.SQLFormattingOptions.ExpandVirtualObjects = False
        Me.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        ' 
        ' 
        ' 
        Me.queryBuilder.SQLGenerationOptions.ExpandVirtualFields = True
        Me.queryBuilder.SQLGenerationOptions.ExpandVirtualObjects = True
        Me.queryBuilder.TabIndex = 0
        Me.queryBuilder.VisualOptions.ActiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(157))))))
        Me.queryBuilder.VisualOptions.ActiveDockPanelCaptionFontColor = Color.Black
        Me.queryBuilder.VisualOptions.DockTabColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.queryBuilder.VisualOptions.DockTabFontColor = Color.White
        Me.queryBuilder.VisualOptions.DockTabFontHoverColor = Color.White
        Me.queryBuilder.VisualOptions.DockTabHoverColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.queryBuilder.VisualOptions.DockTabIndicatorColor = Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(125))))))
        Me.queryBuilder.VisualOptions.DockTabIndicatorHoverColor = Color.FromArgb((CInt(Fix((CByte(155))))), (CInt(Fix((CByte(167))))), (CInt(Fix((CByte(183))))))
        Me.queryBuilder.VisualOptions.InactiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(96))))), (CInt(Fix((CByte(130))))))
        Me.queryBuilder.VisualOptions.InactiveDockPanelCaptionFontColor = Color.White
        Me.queryBuilder.VisualOptions.TabFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder.VisualOptions.TabsStripBackColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
'			Me.queryBuilder.SQLUpdated += New System.EventHandler(Me.queryBuilder_SQLUpdated)
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = DockStyle.Fill
        Me.splitContainer1.Location = New Point(0, 83)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.Controls.Add(Me.tabControl1)
        Me.splitContainer1.Size = New Size(793, 447)
        Me.splitContainer1.SplitterDistance = 316
        Me.splitContainer1.TabIndex = 2
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Dock = DockStyle.Fill
        Me.tabControl1.Location = New Point(0, 0)
        Me.tabControl1.Multiline = True
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New Size(793, 127)
        Me.tabControl1.TabIndex = 0
        ' 
        ' tabPage1
        ' 
        Me.tabPage1.Controls.Add(Me.errorBox1)
        Me.tabPage1.Controls.Add(Me.textBox1)
        Me.tabPage1.Location = New Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New Padding(3)
        Me.tabPage1.Size = New Size(785, 101)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Query text with virtual objects and fields"
        Me.tabPage1.UseVisualStyleBackColor = True
        ' 
        ' textBox1
        ' 
        Me.textBox1.Dock = DockStyle.Fill
        Me.textBox1.HideSelection = False
        Me.textBox1.Location = New Point(3, 3)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = ScrollBars.Both
        Me.textBox1.Size = New Size(779, 95)
        Me.textBox1.TabIndex = 1
'			Me.textBox1.Validating += New System.ComponentModel.CancelEventHandler(Me.textBox1_Validating)
        ' 
        ' tabPage2
        ' 
        Me.tabPage2.Controls.Add(Me.errorBoxReal)
        Me.tabPage2.Controls.Add(Me.textBox2)
        Me.tabPage2.Location = New Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New Padding(3)
        Me.tabPage2.Size = New Size(785, 101)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Real query text with virtual objects expanded to their expressions"
        Me.tabPage2.UseVisualStyleBackColor = True
        ' 
        ' textBox2
        ' 
        Me.textBox2.Dock = DockStyle.Fill
        Me.textBox2.HideSelection = False
        Me.textBox2.Location = New Point(3, 3)
        Me.textBox2.Multiline = True
        Me.textBox2.Name = "textBox2"
        Me.textBox2.ReadOnly = True
        Me.textBox2.ScrollBars = ScrollBars.Both
        Me.textBox2.Size = New Size(779, 95)
        Me.textBox2.TabIndex = 2
'			Me.textBox2.Validating += New System.ComponentModel.CancelEventHandler(Me.textBox2_Validating)
        ' 
        ' panel1
        ' 
        Me.panel1.AutoSize = True
        Me.panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.panel1.BackColor = SystemColors.Info
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = DockStyle.Top
        Me.panel1.Location = New Point(0, 24)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New Padding(2, 3, 2, 4)
        Me.panel1.Size = New Size(793, 59)
        Me.panel1.TabIndex = 1
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Dock = DockStyle.Fill
        Me.label1.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.label1.Location = New Point(2, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(669, 52)
        Me.label1.TabIndex = 0
        Me.label1.Text = resources.GetString("label1.Text")
        ' 
        ' sqlFormattingOptions1
        ' 
        Me.sqlFormattingOptions1.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.DynamicIndents = False
        Me.sqlFormattingOptions1.DynamicRightMargin = False
        Me.sqlFormattingOptions1.ExpandVirtualFields = False
        Me.sqlFormattingOptions1.ExpandVirtualObjects = False
        Me.sqlFormattingOptions1.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = False
        Me.sqlFormattingOptions1.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.ExpressionSubQueryFormat.MainPartsFromNewLine = False
        Me.sqlFormattingOptions1.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.KeywordFormat = ActiveQueryBuilder.Core.KeywordFormat.UpperCase
        Me.sqlFormattingOptions1.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions1.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        ' 
        ' sqlFormattingOptions2
        ' 
        Me.sqlFormattingOptions2.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.DynamicIndents = False
        Me.sqlFormattingOptions2.DynamicRightMargin = False
        Me.sqlFormattingOptions2.ExpandVirtualFields = True
        Me.sqlFormattingOptions2.ExpandVirtualObjects = True
        Me.sqlFormattingOptions2.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = False
        Me.sqlFormattingOptions2.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.ExpressionSubQueryFormat.MainPartsFromNewLine = False
        Me.sqlFormattingOptions2.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.sqlFormattingOptions2.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        ' 
        ' errorBox1
        ' 
        Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox1.AutoSize = True
        Me.errorBox1.BackColor = Color.LightPink
        Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = False
        Me.errorBox1.Location = New Point(462, 32)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New Padding(5)
        Me.errorBox1.Size = New Size(298, 61)
        Me.errorBox1.TabIndex = 2
        Me.errorBox1.Visible = False
'			Me.errorBox1.GoToErrorPosition += New System.EventHandler(Me.ErrorBox1_GoToErrorPosition)
'			Me.errorBox1.RevertValidText += New System.EventHandler(Me.ErrorBox1_RevertValidText)
        ' 
        ' errorBoxReal
        ' 
        Me.errorBoxReal.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBoxReal.AutoSize = True
        Me.errorBoxReal.BackColor = Color.LightPink
        Me.errorBoxReal.BorderStyle = BorderStyle.FixedSingle
        Me.errorBoxReal.CurrentSyntaxProvider = Nothing
        Me.errorBoxReal.IsVisibleCheckSyntaxPanel = False
        Me.errorBoxReal.Location = New Point(475, 34)
        Me.errorBoxReal.Name = "errorBoxReal"
        Me.errorBoxReal.Padding = New Padding(5)
        Me.errorBoxReal.Size = New Size(282, 61)
        Me.errorBoxReal.TabIndex = 3
        Me.errorBoxReal.Visible = False
'			Me.errorBoxReal.GoToErrorPosition += New System.EventHandler(Me.ErrorBoxReal_GoToErrorPosition)
'			Me.errorBoxReal.RevertValidText += New System.EventHandler(Me.ErrorBoxReal_RevertValidText)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(793, 530)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "VirtualObjectsAndFields Demo"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.queryBuilder.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.sqlFormattingOptions1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sqlFormattingOptions2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private label1 As Label
    Private panel1 As Panel

#End Region

    Private menuStrip1 As MenuStrip
    Private WithEvents aboutToolStripMenuItem As ToolStripMenuItem
    Private imageList16 As ImageList
    Private imageList32 As ImageList
    Private splitContainer1 As SplitContainer
    Private WithEvents queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private tabControl1 As TabControl
    Private tabPage1 As TabPage
    Private WithEvents textBox1 As TextBox
    Private tabPage2 As TabPage
    Private WithEvents textBox2 As TextBox
    Private WithEvents editMetadataToolStripMenuItem As ToolStripMenuItem
    Private sqlFormattingOptions1 As ActiveQueryBuilder.Core.SQLFormattingOptions
    Private sqlFormattingOptions2 As ActiveQueryBuilder.Core.SQLFormattingOptions
    Private WithEvents errorBox1 As Common.SqlErrorBox
    Private WithEvents errorBoxReal As Common.SqlErrorBox
End Class
