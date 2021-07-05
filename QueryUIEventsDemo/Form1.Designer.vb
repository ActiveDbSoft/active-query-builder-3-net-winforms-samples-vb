
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
        Dim linkPainterAccess1 As New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.tableLayoutPanel1 = New TableLayoutPanel()
        Me.panel1 = New Panel()
        Me.flowLayoutPanel1 = New FlowLayoutPanel()
        Me.flowLayoutPanel2 = New FlowLayoutPanel()
        Me.CbDataSourceAdded = New CheckBox()
        Me.CbDataSourceAdding = New CheckBox()
        Me.CbDataSourceDeleting = New CheckBox()
        Me.flowLayoutPanel3 = New FlowLayoutPanel()
        Me.CbDataSourceFieldAdded = New CheckBox()
        Me.CbDataSourceFieldAdding = New CheckBox()
        Me.CbDatasourceFieldRemoved = New CheckBox()
        Me.flowLayoutPanel4 = New FlowLayoutPanel()
        Me.CbDataSourceFieldRemoving = New CheckBox()
        Me.CbQueryColumnListItemChanged = New CheckBox()
        Me.CbQueryColumnListItemChanging = New CheckBox()
        Me.flowLayoutPanel5 = New FlowLayoutPanel()
        Me.CbLinkChanged = New CheckBox()
        Me.CbLinkChanging = New CheckBox()
        Me.CbLinkCreated = New CheckBox()
        Me.flowLayoutPanel6 = New FlowLayoutPanel()
        Me.CbLinkCreating = New CheckBox()
        Me.CbLinkDeleting = New CheckBox()
        Me.cbQueryColumnListItemRemoving = New CheckBox()
        Me.label1 = New Label()
        Me.splitContainer1 = New SplitContainer()
        Me.QBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.errorBox1 = New Common.SqlErrorBox()
        Me.TextBoxSQL = New RichTextBox()
        Me.TextBoxReport = New RichTextBox()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.flowLayoutPanel2.SuspendLayout()
        Me.flowLayoutPanel3.SuspendLayout()
        Me.flowLayoutPanel4.SuspendLayout()
        Me.flowLayoutPanel5.SuspendLayout()
        Me.flowLayoutPanel6.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.QBuilder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QBuilder.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QBuilder.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' tableLayoutPanel1
        ' 
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.splitContainer1, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.TextBoxReport, 0, 2)
        Me.tableLayoutPanel1.Dock = DockStyle.Fill
        Me.tableLayoutPanel1.Location = New Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel1.Size = New Size(1008, 771)
        Me.tableLayoutPanel1.TabIndex = 0
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = SystemColors.Info
        Me.panel1.BorderStyle = BorderStyle.Fixed3D
        Me.panel1.Controls.Add(Me.flowLayoutPanel1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = DockStyle.Top
        Me.panel1.Location = New Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New Padding(3)
        Me.panel1.Size = New Size(1002, 100)
        Me.panel1.TabIndex = 0
        ' 
        ' flowLayoutPanel1
        ' 
        Me.flowLayoutPanel1.Controls.Add(Me.flowLayoutPanel2)
        Me.flowLayoutPanel1.Controls.Add(Me.flowLayoutPanel3)
        Me.flowLayoutPanel1.Controls.Add(Me.flowLayoutPanel4)
        Me.flowLayoutPanel1.Controls.Add(Me.flowLayoutPanel5)
        Me.flowLayoutPanel1.Controls.Add(Me.flowLayoutPanel6)
        Me.flowLayoutPanel1.Dock = DockStyle.Top
        Me.flowLayoutPanel1.Location = New Point(3, 16)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Padding = New Padding(3)
        Me.flowLayoutPanel1.Size = New Size(992, 78)
        Me.flowLayoutPanel1.TabIndex = 1
        ' 
        ' flowLayoutPanel2
        ' 
        Me.flowLayoutPanel2.Controls.Add(Me.CbDataSourceAdded)
        Me.flowLayoutPanel2.Controls.Add(Me.CbDataSourceAdding)
        Me.flowLayoutPanel2.Controls.Add(Me.CbDataSourceDeleting)
        Me.flowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        Me.flowLayoutPanel2.Location = New Point(6, 6)
        Me.flowLayoutPanel2.Name = "flowLayoutPanel2"
        Me.flowLayoutPanel2.Size = New Size(154, 72)
        Me.flowLayoutPanel2.TabIndex = 0
        ' 
        ' CbDataSourceAdded
        ' 
        Me.CbDataSourceAdded.AutoSize = True
        Me.CbDataSourceAdded.Checked = True
        Me.CbDataSourceAdded.CheckState = CheckState.Checked
        Me.CbDataSourceAdded.Location = New Point(3, 3)
        Me.CbDataSourceAdded.Name = "CbDataSourceAdded"
        Me.CbDataSourceAdded.Size = New Size(114, 17)
        Me.CbDataSourceAdded.TabIndex = 0
        Me.CbDataSourceAdded.Text = "DataSourceAdded"
        Me.CbDataSourceAdded.UseVisualStyleBackColor = True
        ' 
        ' CbDataSourceAdding
        ' 
        Me.CbDataSourceAdding.AutoSize = True
        Me.CbDataSourceAdding.Checked = True
        Me.CbDataSourceAdding.CheckState = CheckState.Checked
        Me.CbDataSourceAdding.Location = New Point(3, 26)
        Me.CbDataSourceAdding.Name = "CbDataSourceAdding"
        Me.CbDataSourceAdding.Size = New Size(116, 17)
        Me.CbDataSourceAdding.TabIndex = 1
        Me.CbDataSourceAdding.Text = "DataSourceAdding"
        Me.CbDataSourceAdding.UseVisualStyleBackColor = True
        ' 
        ' CbDataSourceDeleting
        ' 
        Me.CbDataSourceDeleting.AutoSize = True
        Me.CbDataSourceDeleting.Checked = True
        Me.CbDataSourceDeleting.CheckState = CheckState.Checked
        Me.CbDataSourceDeleting.Location = New Point(3, 49)
        Me.CbDataSourceDeleting.Name = "CbDataSourceDeleting"
        Me.CbDataSourceDeleting.Size = New Size(122, 17)
        Me.CbDataSourceDeleting.TabIndex = 2
        Me.CbDataSourceDeleting.Text = "DataSourceDeleting"
        Me.CbDataSourceDeleting.UseVisualStyleBackColor = True
        ' 
        ' flowLayoutPanel3
        ' 
        Me.flowLayoutPanel3.Controls.Add(Me.CbDataSourceFieldAdded)
        Me.flowLayoutPanel3.Controls.Add(Me.CbDataSourceFieldAdding)
        Me.flowLayoutPanel3.Controls.Add(Me.CbDatasourceFieldRemoved)
        Me.flowLayoutPanel3.FlowDirection = FlowDirection.TopDown
        Me.flowLayoutPanel3.Location = New Point(166, 6)
        Me.flowLayoutPanel3.Name = "flowLayoutPanel3"
        Me.flowLayoutPanel3.Size = New Size(164, 72)
        Me.flowLayoutPanel3.TabIndex = 0
        ' 
        ' CbDataSourceFieldAdded
        ' 
        Me.CbDataSourceFieldAdded.AutoSize = True
        Me.CbDataSourceFieldAdded.Checked = True
        Me.CbDataSourceFieldAdded.CheckState = CheckState.Checked
        Me.CbDataSourceFieldAdded.Location = New Point(3, 3)
        Me.CbDataSourceFieldAdded.Name = "CbDataSourceFieldAdded"
        Me.CbDataSourceFieldAdded.Size = New Size(136, 17)
        Me.CbDataSourceFieldAdded.TabIndex = 0
        Me.CbDataSourceFieldAdded.Text = "DataSourceFieldAdded"
        Me.CbDataSourceFieldAdded.UseVisualStyleBackColor = True
        ' 
        ' CbDataSourceFieldAdding
        ' 
        Me.CbDataSourceFieldAdding.AutoSize = True
        Me.CbDataSourceFieldAdding.Checked = True
        Me.CbDataSourceFieldAdding.CheckState = CheckState.Checked
        Me.CbDataSourceFieldAdding.Location = New Point(3, 26)
        Me.CbDataSourceFieldAdding.Name = "CbDataSourceFieldAdding"
        Me.CbDataSourceFieldAdding.Size = New Size(138, 17)
        Me.CbDataSourceFieldAdding.TabIndex = 1
        Me.CbDataSourceFieldAdding.Text = "DataSourceFieldAdding"
        Me.CbDataSourceFieldAdding.UseVisualStyleBackColor = True
        ' 
        ' CbDatasourceFieldRemoved
        ' 
        Me.CbDatasourceFieldRemoved.AutoSize = True
        Me.CbDatasourceFieldRemoved.Checked = True
        Me.CbDatasourceFieldRemoved.CheckState = CheckState.Checked
        Me.CbDatasourceFieldRemoved.Location = New Point(3, 49)
        Me.CbDatasourceFieldRemoved.Name = "CbDatasourceFieldRemoved"
        Me.CbDatasourceFieldRemoved.Size = New Size(149, 17)
        Me.CbDatasourceFieldRemoved.TabIndex = 2
        Me.CbDatasourceFieldRemoved.Text = "DatasourceFieldRemoved"
        Me.CbDatasourceFieldRemoved.UseVisualStyleBackColor = True
        ' 
        ' flowLayoutPanel4
        ' 
        Me.flowLayoutPanel4.Controls.Add(Me.CbDataSourceFieldRemoving)
        Me.flowLayoutPanel4.Controls.Add(Me.CbQueryColumnListItemChanged)
        Me.flowLayoutPanel4.Controls.Add(Me.CbQueryColumnListItemChanging)
        Me.flowLayoutPanel4.FlowDirection = FlowDirection.TopDown
        Me.flowLayoutPanel4.Location = New Point(336, 6)
        Me.flowLayoutPanel4.Name = "flowLayoutPanel4"
        Me.flowLayoutPanel4.Size = New Size(191, 72)
        Me.flowLayoutPanel4.TabIndex = 0
        ' 
        ' CbDataSourceFieldRemoving
        ' 
        Me.CbDataSourceFieldRemoving.AutoSize = True
        Me.CbDataSourceFieldRemoving.Checked = True
        Me.CbDataSourceFieldRemoving.CheckState = CheckState.Checked
        Me.CbDataSourceFieldRemoving.Location = New Point(3, 3)
        Me.CbDataSourceFieldRemoving.Name = "CbDataSourceFieldRemoving"
        Me.CbDataSourceFieldRemoving.Size = New Size(153, 17)
        Me.CbDataSourceFieldRemoving.TabIndex = 0
        Me.CbDataSourceFieldRemoving.Text = "DataSourceFieldRemoving"
        Me.CbDataSourceFieldRemoving.UseVisualStyleBackColor = True
        ' 
        ' CbQueryColumnListItemChanged
        ' 
        Me.CbQueryColumnListItemChanged.AutoSize = True
        Me.CbQueryColumnListItemChanged.Checked = True
        Me.CbQueryColumnListItemChanged.CheckState = CheckState.Checked
        Me.CbQueryColumnListItemChanged.Location = New Point(3, 26)
        Me.CbQueryColumnListItemChanged.Name = "CbQueryColumnListItemChanged"
        Me.CbQueryColumnListItemChanged.Size = New Size(168, 17)
        Me.CbQueryColumnListItemChanged.TabIndex = 1
        Me.CbQueryColumnListItemChanged.Text = "QueryColumnListItemChanged"
        Me.CbQueryColumnListItemChanged.UseVisualStyleBackColor = True
        ' 
        ' CbQueryColumnListItemChanging
        ' 
        Me.CbQueryColumnListItemChanging.AutoSize = True
        Me.CbQueryColumnListItemChanging.Checked = True
        Me.CbQueryColumnListItemChanging.CheckState = CheckState.Checked
        Me.CbQueryColumnListItemChanging.Location = New Point(3, 49)
        Me.CbQueryColumnListItemChanging.Name = "CbQueryColumnListItemChanging"
        Me.CbQueryColumnListItemChanging.Size = New Size(170, 17)
        Me.CbQueryColumnListItemChanging.TabIndex = 2
        Me.CbQueryColumnListItemChanging.Text = "QueryColumnListItemChanging"
        Me.CbQueryColumnListItemChanging.UseVisualStyleBackColor = True
        ' 
        ' flowLayoutPanel5
        ' 
        Me.flowLayoutPanel5.Controls.Add(Me.CbLinkChanged)
        Me.flowLayoutPanel5.Controls.Add(Me.CbLinkChanging)
        Me.flowLayoutPanel5.Controls.Add(Me.CbLinkCreated)
        Me.flowLayoutPanel5.FlowDirection = FlowDirection.TopDown
        Me.flowLayoutPanel5.Location = New Point(533, 6)
        Me.flowLayoutPanel5.Name = "flowLayoutPanel5"
        Me.flowLayoutPanel5.Size = New Size(108, 72)
        Me.flowLayoutPanel5.TabIndex = 0
        ' 
        ' CbLinkChanged
        ' 
        Me.CbLinkChanged.AutoSize = True
        Me.CbLinkChanged.Checked = True
        Me.CbLinkChanged.CheckState = CheckState.Checked
        Me.CbLinkChanged.Location = New Point(3, 3)
        Me.CbLinkChanged.Name = "CbLinkChanged"
        Me.CbLinkChanged.Size = New Size(89, 17)
        Me.CbLinkChanged.TabIndex = 0
        Me.CbLinkChanged.Text = "LinkChanged"
        Me.CbLinkChanged.UseVisualStyleBackColor = True
        ' 
        ' CbLinkChanging
        ' 
        Me.CbLinkChanging.AutoSize = True
        Me.CbLinkChanging.Checked = True
        Me.CbLinkChanging.CheckState = CheckState.Checked
        Me.CbLinkChanging.Location = New Point(3, 26)
        Me.CbLinkChanging.Name = "CbLinkChanging"
        Me.CbLinkChanging.Size = New Size(91, 17)
        Me.CbLinkChanging.TabIndex = 1
        Me.CbLinkChanging.Text = "LinkChanging"
        Me.CbLinkChanging.UseVisualStyleBackColor = True
        ' 
        ' CbLinkCreated
        ' 
        Me.CbLinkCreated.AutoSize = True
        Me.CbLinkCreated.Checked = True
        Me.CbLinkCreated.CheckState = CheckState.Checked
        Me.CbLinkCreated.Location = New Point(3, 49)
        Me.CbLinkCreated.Name = "CbLinkCreated"
        Me.CbLinkCreated.Size = New Size(83, 17)
        Me.CbLinkCreated.TabIndex = 2
        Me.CbLinkCreated.Text = "LinkCreated"
        Me.CbLinkCreated.UseVisualStyleBackColor = True
        ' 
        ' flowLayoutPanel6
        ' 
        Me.flowLayoutPanel6.Controls.Add(Me.CbLinkCreating)
        Me.flowLayoutPanel6.Controls.Add(Me.CbLinkDeleting)
        Me.flowLayoutPanel6.Controls.Add(Me.cbQueryColumnListItemRemoving)
        Me.flowLayoutPanel6.FlowDirection = FlowDirection.TopDown
        Me.flowLayoutPanel6.Location = New Point(647, 6)
        Me.flowLayoutPanel6.Name = "flowLayoutPanel6"
        Me.flowLayoutPanel6.Size = New Size(175, 72)
        Me.flowLayoutPanel6.TabIndex = 0
        ' 
        ' CbLinkCreating
        ' 
        Me.CbLinkCreating.AutoSize = True
        Me.CbLinkCreating.Checked = True
        Me.CbLinkCreating.CheckState = CheckState.Checked
        Me.CbLinkCreating.Location = New Point(3, 3)
        Me.CbLinkCreating.Name = "CbLinkCreating"
        Me.CbLinkCreating.Size = New Size(85, 17)
        Me.CbLinkCreating.TabIndex = 0
        Me.CbLinkCreating.Text = "LinkCreating"
        Me.CbLinkCreating.UseVisualStyleBackColor = True
        ' 
        ' CbLinkDeleting
        ' 
        Me.CbLinkDeleting.AutoSize = True
        Me.CbLinkDeleting.Checked = True
        Me.CbLinkDeleting.CheckState = CheckState.Checked
        Me.CbLinkDeleting.Location = New Point(3, 26)
        Me.CbLinkDeleting.Name = "CbLinkDeleting"
        Me.CbLinkDeleting.Size = New Size(85, 17)
        Me.CbLinkDeleting.TabIndex = 1
        Me.CbLinkDeleting.Text = "LinkDeleting"
        Me.CbLinkDeleting.UseVisualStyleBackColor = True
        ' 
        ' cbQueryColumnListItemRemoving
        ' 
        Me.cbQueryColumnListItemRemoving.AutoSize = True
        Me.cbQueryColumnListItemRemoving.Checked = True
        Me.cbQueryColumnListItemRemoving.CheckState = CheckState.Checked
        Me.cbQueryColumnListItemRemoving.Location = New Point(3, 49)
        Me.cbQueryColumnListItemRemoving.Name = "cbQueryColumnListItemRemoving"
        Me.cbQueryColumnListItemRemoving.Size = New Size(173, 17)
        Me.cbQueryColumnListItemRemoving.TabIndex = 1
        Me.cbQueryColumnListItemRemoving.Text = "QueryColumnListItemRemoving"
        Me.cbQueryColumnListItemRemoving.UseVisualStyleBackColor = True
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Dock = DockStyle.Top
        Me.label1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.label1.Location = New Point(3, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(55, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Stop on:"
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = DockStyle.Fill
        Me.splitContainer1.FixedPanel = FixedPanel.Panel2
        Me.splitContainer1.Location = New Point(3, 109)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.Controls.Add(Me.QBuilder)
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.Controls.Add(Me.errorBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.TextBoxSQL)
        Me.splitContainer1.Size = New Size(1002, 557)
        Me.splitContainer1.SplitterDistance = 443
        Me.splitContainer1.TabIndex = 1
        ' 
        ' QBuilder
        ' 
        Me.QBuilder.AddObjectDialogOptions.Location = New Point(0, 0)
        Me.QBuilder.AddObjectDialogOptions.Size = New Size(430, 430)
        Me.QBuilder.AddObjectDialogOptions.StartPosition = FormStartPosition.CenterScreen
        Me.QBuilder.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = False
        Me.QBuilder.BorderStyle = BorderStyle.None
        Me.QBuilder.DatabaseSchemaViewOptions.DrawTreeLines = False
        Me.QBuilder.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.QBuilder.DesignPaneOptions.Background = SystemColors.Window
        linkPainterAccess1.LinkColor = Color.Black
        linkPainterAccess1.LinkColorFocused = Color.Black
        linkPainterAccess1.MarkColor = SystemColors.Control
        linkPainterAccess1.MarkColorFocused = SystemColors.ControlDark
        linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.QBuilder.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1
        Me.QBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.QBuilder.Dock = DockStyle.Fill
        Me.QBuilder.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.World)
        Me.QBuilder.Location = New Point(0, 0)
        Me.QBuilder.Name = "QBuilder"
        Me.QBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = True
        Me.QBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.QBuilder.PanesConfigurationOptions.PropertiesBarEnabled = True
        Me.QBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = True
        Me.QBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.QBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = True
        Me.QBuilder.QueryColumnListOptions.Font = Nothing
        Me.QBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.QBuilder.QueryColumnListOptions.NullOrderingInOrderBy = False
        Me.QBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.QBuilder.QueryNavBarOptions.CTEButtonBaseColor = Color.Green
        Me.QBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = False
        Me.QBuilder.QueryNavBarOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.QBuilder.QueryNavBarOptions.OverflowButtonBaseColor = Color.DarkRed
        Me.QBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = Color.Black
        Me.QBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = Color.Blue
        Me.QBuilder.Size = New Size(1002, 443)
        ' 
        ' 
        ' 
        Me.QBuilder.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.DynamicIndents = False
        Me.QBuilder.SQLFormattingOptions.DynamicRightMargin = False
        Me.QBuilder.SQLFormattingOptions.ExpandVirtualFields = False
        Me.QBuilder.SQLFormattingOptions.ExpandVirtualObjects = False
        Me.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = False
        Me.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = False
        Me.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.QBuilder.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        ' 
        ' 
        ' 
        Me.QBuilder.SQLGenerationOptions.ExpandVirtualFields = True
        Me.QBuilder.SQLGenerationOptions.ExpandVirtualObjects = True
        Me.QBuilder.SQLGenerationOptions.UseAltNames = False
        Me.QBuilder.TabIndex = 0
        Me.QBuilder.VisualOptions.ActiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(157))))))
        Me.QBuilder.VisualOptions.ActiveDockPanelCaptionFontColor = Color.Black
        Me.QBuilder.VisualOptions.DockTabColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.QBuilder.VisualOptions.DockTabFontColor = Color.White
        Me.QBuilder.VisualOptions.DockTabFontHoverColor = Color.White
        Me.QBuilder.VisualOptions.DockTabHoverColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.QBuilder.VisualOptions.DockTabIndicatorColor = Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(125))))))
        Me.QBuilder.VisualOptions.DockTabIndicatorHoverColor = Color.FromArgb((CInt(Fix((CByte(155))))), (CInt(Fix((CByte(167))))), (CInt(Fix((CByte(183))))))
        Me.QBuilder.VisualOptions.InactiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(96))))), (CInt(Fix((CByte(130))))))
        Me.QBuilder.VisualOptions.InactiveDockPanelCaptionFontColor = Color.White
        Me.QBuilder.VisualOptions.TabFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Me.QBuilder.VisualOptions.TabsStripBackColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
'			Me.QBuilder.DataSourceAdding += New ActiveQueryBuilder.View.QueryView.DataSourceAddingEventHandler(Me.QBuilder_DataSourceAdding)
'			Me.QBuilder.DataSourceAdded += New ActiveQueryBuilder.Core.DataSourceAddedEventHandler(Me.QBuilder_DataSourceAdded)
'			Me.QBuilder.DataSourceDeleting += New ActiveQueryBuilder.View.QueryView.DataSourceDeletingEventHandler(Me.QBuilder_DataSourceDeleting)
'			Me.QBuilder.LinkDeleting += New ActiveQueryBuilder.View.QueryView.LinkDeletingEventHandler(Me.QBuilder_LinkDeleting)
'			Me.QBuilder.LinkCreated += New ActiveQueryBuilder.Core.LinkCreatedEventhandler(Me.QBuilder_LinkCreated)
'			Me.QBuilder.LinkChanging += New ActiveQueryBuilder.View.QueryView.LinkChangingEventHandler(Me.QBuilder_LinkChanging)
'			Me.QBuilder.LinkChanged += New ActiveQueryBuilder.View.QueryView.LinkChangedEventHandler(Me.QBuilder_LinkChanged)
'			Me.QBuilder.LinkCreating += New ActiveQueryBuilder.View.QueryView.LinkCreatingEventHandler(Me.QBuilder_LinkCreating)
'			Me.QBuilder.QueryColumnListItemChanging += New ActiveQueryBuilder.View.QueryView.QueryColumnListItemChangingEventHandler(Me.QBuilder_QueryColumnListItemChanging)
'			Me.QBuilder.QueryColumnListItemChanged += New ActiveQueryBuilder.View.QueryView.QueryColumnListItemChangedEventHandler(Me.QBuilder_QueryColumnListItemChanged)
'			Me.QBuilder.QueryColumnListItemAdded += New ActiveQueryBuilder.View.QueryView.ItemCollectionChanged(Me.QBuilder_QueryColumnListItemAdded)
'			Me.QBuilder.QueryColumnListItemRemoving += New ActiveQueryBuilder.View.QueryView.ItemCollectionChanging(Me.QBuilder_QueryColumnListItemRemoving)
'			Me.QBuilder.DataSourceFieldAdding += New ActiveQueryBuilder.View.QueryView.DataSourceFieldAddingEventHandler(Me.QBuilder_DataSourceFieldAdding)
'			Me.QBuilder.DataSourceFieldAdded += New ActiveQueryBuilder.View.QueryView.DataSourceFieldAddedEventHandler(Me.QBuilder_DataSourceFieldAdded)
'			Me.QBuilder.DataSourceFieldRemoving += New ActiveQueryBuilder.View.QueryView.DataSourceFieldRemovingEventHandler(Me.QBuilder_DataSourceFieldRemoving)
'			Me.QBuilder.DatasourceFieldRemoved += New ActiveQueryBuilder.View.QueryView.DatasourceFieldRemovedEventHandler(Me.QBuilder_DatasourceFieldRemoved)
'			Me.QBuilder.SQLUpdated += New System.EventHandler(Me.QBuilder_SQLUpdated)
        ' 
        ' errorBox1
        ' 
        Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox1.AutoSize = True
        Me.errorBox1.BackColor = Color.LightPink
        Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = False
        Me.errorBox1.Location = New Point(677, 46)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New Padding(5)
        Me.errorBox1.Size = New Size(316, 61)
        Me.errorBox1.TabIndex = 1
        Me.errorBox1.Visible = False
'			Me.errorBox1.GoToErrorPosition += New System.EventHandler(Me.ErrorBox1_GoToErrorPosition)
'			Me.errorBox1.RevertValidText += New System.EventHandler(Me.ErrorBox1_RevertValidText)
        ' 
        ' TextBoxSQL
        ' 
        Me.TextBoxSQL.Dock = DockStyle.Fill
        Me.TextBoxSQL.Location = New Point(0, 0)
        Me.TextBoxSQL.Name = "TextBoxSQL"
        Me.TextBoxSQL.Size = New Size(1002, 110)
        Me.TextBoxSQL.TabIndex = 0
        Me.TextBoxSQL.Text = ""
'			Me.TextBoxSQL.Validating += New System.ComponentModel.CancelEventHandler(Me.TextBoxSQL_Validating)
        ' 
        ' TextBoxReport
        ' 
        Me.TextBoxReport.BackColor = SystemColors.Info
        Me.TextBoxReport.Dock = DockStyle.Fill
        Me.TextBoxReport.Location = New Point(3, 672)
        Me.TextBoxReport.Name = "TextBoxReport"
        Me.TextBoxReport.Size = New Size(1002, 96)
        Me.TextBoxReport.TabIndex = 2
        Me.TextBoxReport.Text = ""
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1008, 771)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "QueryUIEventsDemo"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.flowLayoutPanel2.ResumeLayout(False)
        Me.flowLayoutPanel2.PerformLayout()
        Me.flowLayoutPanel3.ResumeLayout(False)
        Me.flowLayoutPanel3.PerformLayout()
        Me.flowLayoutPanel4.ResumeLayout(False)
        Me.flowLayoutPanel4.PerformLayout()
        Me.flowLayoutPanel5.ResumeLayout(False)
        Me.flowLayoutPanel5.PerformLayout()
        Me.flowLayoutPanel6.ResumeLayout(False)
        Me.flowLayoutPanel6.PerformLayout()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        CType(Me.QBuilder.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QBuilder.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QBuilder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private tableLayoutPanel1 As TableLayoutPanel
    Private panel1 As Panel
    Private flowLayoutPanel1 As FlowLayoutPanel
    Private label1 As Label
    Private splitContainer1 As SplitContainer
    Private WithEvents QBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private WithEvents TextBoxSQL As RichTextBox
    Private TextBoxReport As RichTextBox
    Private flowLayoutPanel2 As FlowLayoutPanel
    Private CbDataSourceAdded As CheckBox
    Private CbDataSourceAdding As CheckBox
    Private CbDataSourceDeleting As CheckBox
    Private flowLayoutPanel3 As FlowLayoutPanel
    Private CbDataSourceFieldAdded As CheckBox
    Private CbDataSourceFieldAdding As CheckBox
    Private CbDatasourceFieldRemoved As CheckBox
    Private flowLayoutPanel4 As FlowLayoutPanel
    Private CbDataSourceFieldRemoving As CheckBox
    Private CbQueryColumnListItemChanged As CheckBox
    Private CbQueryColumnListItemChanging As CheckBox
    Private flowLayoutPanel5 As FlowLayoutPanel
    Private CbLinkChanged As CheckBox
    Private CbLinkChanging As CheckBox
    Private CbLinkCreated As CheckBox
    Private flowLayoutPanel6 As FlowLayoutPanel
    Private CbLinkCreating As CheckBox
    Private CbLinkDeleting As CheckBox
    Private cbQueryColumnListItemRemoving As CheckBox
    Private WithEvents errorBox1 As Common.SqlErrorBox
End Class