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
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.flowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CbDataSourceAdded = New System.Windows.Forms.CheckBox()
        Me.CbDataSourceAdding = New System.Windows.Forms.CheckBox()
        Me.CbDataSourceDeleting = New System.Windows.Forms.CheckBox()
        Me.flowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CbDataSourceFieldAdded = New System.Windows.Forms.CheckBox()
        Me.CbDataSourceFieldAdding = New System.Windows.Forms.CheckBox()
        Me.CbDatasourceFieldRemoved = New System.Windows.Forms.CheckBox()
        Me.flowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CbDataSourceFieldRemoving = New System.Windows.Forms.CheckBox()
        Me.CbQueryColumnListItemChanged = New System.Windows.Forms.CheckBox()
        Me.CbQueryColumnListItemChanging = New System.Windows.Forms.CheckBox()
        Me.flowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CbLinkChanged = New System.Windows.Forms.CheckBox()
        Me.CbLinkChanging = New System.Windows.Forms.CheckBox()
        Me.CbLinkCreated = New System.Windows.Forms.CheckBox()
        Me.flowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CbLinkCreating = New System.Windows.Forms.CheckBox()
        Me.CbLinkDeleting = New System.Windows.Forms.CheckBox()
        Me.cbQueryColumnListItemRemoving = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.QBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.TextBoxSQL = New System.Windows.Forms.RichTextBox()
        Me.TextBoxReport = New System.Windows.Forms.RichTextBox()
        Me.tableLayoutPanel1.SuspendLayout
        Me.panel1.SuspendLayout
        Me.flowLayoutPanel1.SuspendLayout
        Me.flowLayoutPanel2.SuspendLayout
        Me.flowLayoutPanel3.SuspendLayout
        Me.flowLayoutPanel4.SuspendLayout
        Me.flowLayoutPanel5.SuspendLayout
        Me.flowLayoutPanel6.SuspendLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer1.Panel1.SuspendLayout
        Me.splitContainer1.Panel2.SuspendLayout
        Me.splitContainer1.SuspendLayout
        CType(Me.QBuilder,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'tableLayoutPanel1
        '
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
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(1008, 771)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.Info
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel1.Controls.Add(Me.flowLayoutPanel1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.panel1.Size = New System.Drawing.Size(1002, 100)
        Me.panel1.TabIndex = 0
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.Controls.Add(Me.flowLayoutPanel2)
        Me.flowLayoutPanel1.Controls.Add(Me.flowLayoutPanel3)
        Me.flowLayoutPanel1.Controls.Add(Me.flowLayoutPanel4)
        Me.flowLayoutPanel1.Controls.Add(Me.flowLayoutPanel5)
        Me.flowLayoutPanel1.Controls.Add(Me.flowLayoutPanel6)
        Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(992, 78)
        Me.flowLayoutPanel1.TabIndex = 1
        '
        'flowLayoutPanel2
        '
        Me.flowLayoutPanel2.Controls.Add(Me.CbDataSourceAdded)
        Me.flowLayoutPanel2.Controls.Add(Me.CbDataSourceAdding)
        Me.flowLayoutPanel2.Controls.Add(Me.CbDataSourceDeleting)
        Me.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowLayoutPanel2.Location = New System.Drawing.Point(6, 6)
        Me.flowLayoutPanel2.Name = "flowLayoutPanel2"
        Me.flowLayoutPanel2.Size = New System.Drawing.Size(154, 72)
        Me.flowLayoutPanel2.TabIndex = 0
        '
        'CbDataSourceAdded
        '
        Me.CbDataSourceAdded.AutoSize = true
        Me.CbDataSourceAdded.Checked = true
        Me.CbDataSourceAdded.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDataSourceAdded.Location = New System.Drawing.Point(3, 3)
        Me.CbDataSourceAdded.Name = "CbDataSourceAdded"
        Me.CbDataSourceAdded.Size = New System.Drawing.Size(114, 17)
        Me.CbDataSourceAdded.TabIndex = 0
        Me.CbDataSourceAdded.Text = "DataSourceAdded"
        Me.CbDataSourceAdded.UseVisualStyleBackColor = true
        '
        'CbDataSourceAdding
        '
        Me.CbDataSourceAdding.AutoSize = true
        Me.CbDataSourceAdding.Checked = true
        Me.CbDataSourceAdding.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDataSourceAdding.Location = New System.Drawing.Point(3, 26)
        Me.CbDataSourceAdding.Name = "CbDataSourceAdding"
        Me.CbDataSourceAdding.Size = New System.Drawing.Size(116, 17)
        Me.CbDataSourceAdding.TabIndex = 1
        Me.CbDataSourceAdding.Text = "DataSourceAdding"
        Me.CbDataSourceAdding.UseVisualStyleBackColor = true
        '
        'CbDataSourceDeleting
        '
        Me.CbDataSourceDeleting.AutoSize = true
        Me.CbDataSourceDeleting.Checked = true
        Me.CbDataSourceDeleting.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDataSourceDeleting.Location = New System.Drawing.Point(3, 49)
        Me.CbDataSourceDeleting.Name = "CbDataSourceDeleting"
        Me.CbDataSourceDeleting.Size = New System.Drawing.Size(122, 17)
        Me.CbDataSourceDeleting.TabIndex = 2
        Me.CbDataSourceDeleting.Text = "DataSourceDeleting"
        Me.CbDataSourceDeleting.UseVisualStyleBackColor = true
        '
        'flowLayoutPanel3
        '
        Me.flowLayoutPanel3.Controls.Add(Me.CbDataSourceFieldAdded)
        Me.flowLayoutPanel3.Controls.Add(Me.CbDataSourceFieldAdding)
        Me.flowLayoutPanel3.Controls.Add(Me.CbDatasourceFieldRemoved)
        Me.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowLayoutPanel3.Location = New System.Drawing.Point(166, 6)
        Me.flowLayoutPanel3.Name = "flowLayoutPanel3"
        Me.flowLayoutPanel3.Size = New System.Drawing.Size(164, 72)
        Me.flowLayoutPanel3.TabIndex = 0
        '
        'CbDataSourceFieldAdded
        '
        Me.CbDataSourceFieldAdded.AutoSize = true
        Me.CbDataSourceFieldAdded.Checked = true
        Me.CbDataSourceFieldAdded.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDataSourceFieldAdded.Location = New System.Drawing.Point(3, 3)
        Me.CbDataSourceFieldAdded.Name = "CbDataSourceFieldAdded"
        Me.CbDataSourceFieldAdded.Size = New System.Drawing.Size(136, 17)
        Me.CbDataSourceFieldAdded.TabIndex = 0
        Me.CbDataSourceFieldAdded.Text = "DataSourceFieldAdded"
        Me.CbDataSourceFieldAdded.UseVisualStyleBackColor = true
        '
        'CbDataSourceFieldAdding
        '
        Me.CbDataSourceFieldAdding.AutoSize = true
        Me.CbDataSourceFieldAdding.Checked = true
        Me.CbDataSourceFieldAdding.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDataSourceFieldAdding.Location = New System.Drawing.Point(3, 26)
        Me.CbDataSourceFieldAdding.Name = "CbDataSourceFieldAdding"
        Me.CbDataSourceFieldAdding.Size = New System.Drawing.Size(138, 17)
        Me.CbDataSourceFieldAdding.TabIndex = 1
        Me.CbDataSourceFieldAdding.Text = "DataSourceFieldAdding"
        Me.CbDataSourceFieldAdding.UseVisualStyleBackColor = true
        '
        'CbDatasourceFieldRemoved
        '
        Me.CbDatasourceFieldRemoved.AutoSize = true
        Me.CbDatasourceFieldRemoved.Checked = true
        Me.CbDatasourceFieldRemoved.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDatasourceFieldRemoved.Location = New System.Drawing.Point(3, 49)
        Me.CbDatasourceFieldRemoved.Name = "CbDatasourceFieldRemoved"
        Me.CbDatasourceFieldRemoved.Size = New System.Drawing.Size(149, 17)
        Me.CbDatasourceFieldRemoved.TabIndex = 2
        Me.CbDatasourceFieldRemoved.Text = "DatasourceFieldRemoved"
        Me.CbDatasourceFieldRemoved.UseVisualStyleBackColor = true
        '
        'flowLayoutPanel4
        '
        Me.flowLayoutPanel4.Controls.Add(Me.CbDataSourceFieldRemoving)
        Me.flowLayoutPanel4.Controls.Add(Me.CbQueryColumnListItemChanged)
        Me.flowLayoutPanel4.Controls.Add(Me.CbQueryColumnListItemChanging)
        Me.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowLayoutPanel4.Location = New System.Drawing.Point(336, 6)
        Me.flowLayoutPanel4.Name = "flowLayoutPanel4"
        Me.flowLayoutPanel4.Size = New System.Drawing.Size(191, 72)
        Me.flowLayoutPanel4.TabIndex = 0
        '
        'CbDataSourceFieldRemoving
        '
        Me.CbDataSourceFieldRemoving.AutoSize = true
        Me.CbDataSourceFieldRemoving.Checked = true
        Me.CbDataSourceFieldRemoving.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbDataSourceFieldRemoving.Location = New System.Drawing.Point(3, 3)
        Me.CbDataSourceFieldRemoving.Name = "CbDataSourceFieldRemoving"
        Me.CbDataSourceFieldRemoving.Size = New System.Drawing.Size(153, 17)
        Me.CbDataSourceFieldRemoving.TabIndex = 0
        Me.CbDataSourceFieldRemoving.Text = "DataSourceFieldRemoving"
        Me.CbDataSourceFieldRemoving.UseVisualStyleBackColor = true
        '
        'CbQueryColumnListItemChanged
        '
        Me.CbQueryColumnListItemChanged.AutoSize = true
        Me.CbQueryColumnListItemChanged.Checked = true
        Me.CbQueryColumnListItemChanged.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbQueryColumnListItemChanged.Location = New System.Drawing.Point(3, 26)
        Me.CbQueryColumnListItemChanged.Name = "CbQueryColumnListItemChanged"
        Me.CbQueryColumnListItemChanged.Size = New System.Drawing.Size(168, 17)
        Me.CbQueryColumnListItemChanged.TabIndex = 1
        Me.CbQueryColumnListItemChanged.Text = "QueryColumnListItemChanged"
        Me.CbQueryColumnListItemChanged.UseVisualStyleBackColor = true
        '
        'CbQueryColumnListItemChanging
        '
        Me.CbQueryColumnListItemChanging.AutoSize = true
        Me.CbQueryColumnListItemChanging.Checked = true
        Me.CbQueryColumnListItemChanging.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbQueryColumnListItemChanging.Location = New System.Drawing.Point(3, 49)
        Me.CbQueryColumnListItemChanging.Name = "CbQueryColumnListItemChanging"
        Me.CbQueryColumnListItemChanging.Size = New System.Drawing.Size(170, 17)
        Me.CbQueryColumnListItemChanging.TabIndex = 2
        Me.CbQueryColumnListItemChanging.Text = "QueryColumnListItemChanging"
        Me.CbQueryColumnListItemChanging.UseVisualStyleBackColor = true
        '
        'flowLayoutPanel5
        '
        Me.flowLayoutPanel5.Controls.Add(Me.CbLinkChanged)
        Me.flowLayoutPanel5.Controls.Add(Me.CbLinkChanging)
        Me.flowLayoutPanel5.Controls.Add(Me.CbLinkCreated)
        Me.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowLayoutPanel5.Location = New System.Drawing.Point(533, 6)
        Me.flowLayoutPanel5.Name = "flowLayoutPanel5"
        Me.flowLayoutPanel5.Size = New System.Drawing.Size(108, 72)
        Me.flowLayoutPanel5.TabIndex = 0
        '
        'CbLinkChanged
        '
        Me.CbLinkChanged.AutoSize = true
        Me.CbLinkChanged.Checked = true
        Me.CbLinkChanged.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbLinkChanged.Location = New System.Drawing.Point(3, 3)
        Me.CbLinkChanged.Name = "CbLinkChanged"
        Me.CbLinkChanged.Size = New System.Drawing.Size(89, 17)
        Me.CbLinkChanged.TabIndex = 0
        Me.CbLinkChanged.Text = "LinkChanged"
        Me.CbLinkChanged.UseVisualStyleBackColor = true
        '
        'CbLinkChanging
        '
        Me.CbLinkChanging.AutoSize = true
        Me.CbLinkChanging.Checked = true
        Me.CbLinkChanging.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbLinkChanging.Location = New System.Drawing.Point(3, 26)
        Me.CbLinkChanging.Name = "CbLinkChanging"
        Me.CbLinkChanging.Size = New System.Drawing.Size(91, 17)
        Me.CbLinkChanging.TabIndex = 1
        Me.CbLinkChanging.Text = "LinkChanging"
        Me.CbLinkChanging.UseVisualStyleBackColor = true
        '
        'CbLinkCreated
        '
        Me.CbLinkCreated.AutoSize = true
        Me.CbLinkCreated.Checked = true
        Me.CbLinkCreated.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbLinkCreated.Location = New System.Drawing.Point(3, 49)
        Me.CbLinkCreated.Name = "CbLinkCreated"
        Me.CbLinkCreated.Size = New System.Drawing.Size(83, 17)
        Me.CbLinkCreated.TabIndex = 2
        Me.CbLinkCreated.Text = "LinkCreated"
        Me.CbLinkCreated.UseVisualStyleBackColor = true
        '
        'flowLayoutPanel6
        '
        Me.flowLayoutPanel6.Controls.Add(Me.CbLinkCreating)
        Me.flowLayoutPanel6.Controls.Add(Me.CbLinkDeleting)
        Me.flowLayoutPanel6.Controls.Add(Me.cbQueryColumnListItemRemoving)
        Me.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowLayoutPanel6.Location = New System.Drawing.Point(647, 6)
        Me.flowLayoutPanel6.Name = "flowLayoutPanel6"
        Me.flowLayoutPanel6.Size = New System.Drawing.Size(184, 72)
        Me.flowLayoutPanel6.TabIndex = 0
        '
        'CbLinkCreating
        '
        Me.CbLinkCreating.AutoSize = true
        Me.CbLinkCreating.Checked = true
        Me.CbLinkCreating.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbLinkCreating.Location = New System.Drawing.Point(3, 3)
        Me.CbLinkCreating.Name = "CbLinkCreating"
        Me.CbLinkCreating.Size = New System.Drawing.Size(85, 17)
        Me.CbLinkCreating.TabIndex = 0
        Me.CbLinkCreating.Text = "LinkCreating"
        Me.CbLinkCreating.UseVisualStyleBackColor = true
        '
        'CbLinkDeleting
        '
        Me.CbLinkDeleting.AutoSize = true
        Me.CbLinkDeleting.Checked = true
        Me.CbLinkDeleting.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CbLinkDeleting.Location = New System.Drawing.Point(3, 26)
        Me.CbLinkDeleting.Name = "CbLinkDeleting"
        Me.CbLinkDeleting.Size = New System.Drawing.Size(85, 17)
        Me.CbLinkDeleting.TabIndex = 1
        Me.CbLinkDeleting.Text = "LinkDeleting"
        Me.CbLinkDeleting.UseVisualStyleBackColor = true
        '
        'cbQueryColumnListItemRemoving
        '
        Me.cbQueryColumnListItemRemoving.AutoSize = true
        Me.cbQueryColumnListItemRemoving.Checked = true
        Me.cbQueryColumnListItemRemoving.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbQueryColumnListItemRemoving.Location = New System.Drawing.Point(3, 49)
        Me.cbQueryColumnListItemRemoving.Name = "cbQueryColumnListItemRemoving"
        Me.cbQueryColumnListItemRemoving.Size = New System.Drawing.Size(173, 17)
        Me.cbQueryColumnListItemRemoving.TabIndex = 2
        Me.cbQueryColumnListItemRemoving.Text = "QueryColumnListItemRemoving"
        Me.cbQueryColumnListItemRemoving.UseVisualStyleBackColor = true
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.label1.Location = New System.Drawing.Point(3, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(55, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Stop on:"
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainer1.Location = New System.Drawing.Point(3, 109)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.QBuilder)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.TextBoxSQL)
        Me.splitContainer1.Size = New System.Drawing.Size(1002, 557)
        Me.splitContainer1.SplitterDistance = 443
        Me.splitContainer1.TabIndex = 1
        '
        'QBuilder
        '
        Me.QBuilder.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = false
        Me.QBuilder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.QBuilder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QBuilder.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.QBuilder.Location = New System.Drawing.Point(0, 0)
        Me.QBuilder.MetadataStructureOptions.ProceduresFolderText = "Procedures"
        Me.QBuilder.MetadataStructureOptions.SynonymsFolderText = "Synonyms"
        Me.QBuilder.MetadataStructureOptions.TablesFolderText = "Tables"
        Me.QBuilder.MetadataStructureOptions.ViewsFolderText = "Views"
        Me.QBuilder.Name = "QBuilder"
        Me.QBuilder.PanesConfigurationOptions.DisableQueryNavigationBarPopup = false
        Me.QBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true
        Me.QBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.QBuilder.PanesConfigurationOptions.PropertiesBarEnabled = true
        Me.QBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true
        Me.QBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.QBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = true
        Me.QBuilder.QueryColumnListOptions.AutoSizeColumns = false
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 70
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 60
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 150
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 80
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 90
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3
        Me.QBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 80
        Me.QBuilder.QueryColumnListOptions.DisableDirectEditingIn = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.QBuilder.QueryColumnListOptions.HideAsteriskItem = false
        Me.QBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.QBuilder.QueryColumnListOptions.NullOrderingInOrderBy = false
        Me.QBuilder.QueryColumnListOptions.RowHeadersWidth = 15
        Me.QBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.QBuilder.Size = New System.Drawing.Size(1002, 443)
        '
        '
        '
        Me.QBuilder.SQLFormattingOptions.ExpandVirtualFields = false
        Me.QBuilder.SQLFormattingOptions.ExpandVirtualObjects = false
        Me.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false
        Me.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = false
        '
        '
        '
        Me.QBuilder.SQLGenerationOptions.ExpandVirtualFields = true
        Me.QBuilder.SQLGenerationOptions.ExpandVirtualObjects = true
        Me.QBuilder.SQLGenerationOptions.UseAltNames = false
        Me.QBuilder.TabIndex = 0
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
        Me.TextBoxSQL.Size = New System.Drawing.Size(1002, 110)
        Me.TextBoxSQL.TabIndex = 0
        Me.TextBoxSQL.Text = ""
        '
        'TextBoxReport
        '
        Me.TextBoxReport.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxReport.Location = New System.Drawing.Point(3, 672)
        Me.TextBoxReport.Name = "TextBoxReport"
        Me.TextBoxReport.Size = New System.Drawing.Size(1002, 96)
        Me.TextBoxReport.TabIndex = 2
        Me.TextBoxReport.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 771)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "QueryUIEventsDemo"
        Me.tableLayoutPanel1.ResumeLayout(false)
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        Me.flowLayoutPanel1.ResumeLayout(false)
        Me.flowLayoutPanel2.ResumeLayout(false)
        Me.flowLayoutPanel2.PerformLayout
        Me.flowLayoutPanel3.ResumeLayout(false)
        Me.flowLayoutPanel3.PerformLayout
        Me.flowLayoutPanel4.ResumeLayout(false)
        Me.flowLayoutPanel4.PerformLayout
        Me.flowLayoutPanel5.ResumeLayout(false)
        Me.flowLayoutPanel5.PerformLayout
        Me.flowLayoutPanel6.ResumeLayout(false)
        Me.flowLayoutPanel6.PerformLayout
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        CType(Me.QBuilder,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

	#End Region

	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private panel1 As System.Windows.Forms.Panel
	Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
	Private label1 As System.Windows.Forms.Label
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private WithEvents QBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private WithEvents TextBoxSQL As System.Windows.Forms.RichTextBox
	Private TextBoxReport As System.Windows.Forms.RichTextBox
	Private flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
	Private CbDataSourceAdded As System.Windows.Forms.CheckBox
	Private CbDataSourceAdding As System.Windows.Forms.CheckBox
	Private CbDataSourceDeleting As System.Windows.Forms.CheckBox
	Private flowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
	Private CbDataSourceFieldAdded As System.Windows.Forms.CheckBox
	Private CbDataSourceFieldAdding As System.Windows.Forms.CheckBox
	Private CbDatasourceFieldRemoved As System.Windows.Forms.CheckBox
	Private flowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
	Private CbDataSourceFieldRemoving As System.Windows.Forms.CheckBox
	Private CbQueryColumnListItemChanged As System.Windows.Forms.CheckBox
	Private CbQueryColumnListItemChanging As System.Windows.Forms.CheckBox
	Private flowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel
	Private CbLinkChanged As System.Windows.Forms.CheckBox
	Private CbLinkChanging As System.Windows.Forms.CheckBox
	Private CbLinkCreated As System.Windows.Forms.CheckBox
	Private flowLayoutPanel6 As System.Windows.Forms.FlowLayoutPanel
	Private CbLinkCreating As System.Windows.Forms.CheckBox
	Private CbLinkDeleting As System.Windows.Forms.CheckBox
    Private WithEvents cbQueryColumnListItemRemoving As Windows.Forms.CheckBox
End Class

