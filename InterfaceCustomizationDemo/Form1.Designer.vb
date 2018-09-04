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
        Me.TextBoxReport = New System.Windows.Forms.RichTextBox()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.QBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.TextBoxSQL = New System.Windows.Forms.RichTextBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.QElementCreated = New System.Windows.Forms.CheckBox()
        Me.QElementDestroying = New System.Windows.Forms.CheckBox()
        Me.ValidateContextMenu = New System.Windows.Forms.CheckBox()
        Me.CustomizeDataSourceCaption = New System.Windows.Forms.CheckBox()
        Me.CustomizeDataSourceFieldList = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel1.SuspendLayout
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.splitContainer1.Panel1.SuspendLayout
        Me.splitContainer1.Panel2.SuspendLayout
        Me.splitContainer1.SuspendLayout
        CType(Me.QBuilder,System.ComponentModel.ISupportInitialize).BeginInit
        Me.panel1.SuspendLayout
        Me.flowLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.Controls.Add(Me.TextBoxReport, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.splitContainer1, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(1108, 741)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'TextBoxReport
        '
        Me.TextBoxReport.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxReport.Location = New System.Drawing.Point(3, 644)
        Me.TextBoxReport.Name = "TextBoxReport"
        Me.TextBoxReport.Size = New System.Drawing.Size(1102, 94)
        Me.TextBoxReport.TabIndex = 0
        Me.TextBoxReport.Text = ""
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainer1.Location = New System.Drawing.Point(3, 71)
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
        Me.splitContainer1.Size = New System.Drawing.Size(1102, 567)
        Me.splitContainer1.SplitterDistance = 445
        Me.splitContainer1.TabIndex = 0
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
        Me.QBuilder.Size = New System.Drawing.Size(1102, 445)
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
        Me.TextBoxSQL.Size = New System.Drawing.Size(1102, 118)
        Me.TextBoxSQL.TabIndex = 0
        Me.TextBoxSQL.Text = ""
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.Info
        Me.panel1.Controls.Add(Me.flowLayoutPanel1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.panel1.Size = New System.Drawing.Size(1102, 62)
        Me.panel1.TabIndex = 1
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.Controls.Add(Me.QElementCreated)
        Me.flowLayoutPanel1.Controls.Add(Me.QElementDestroying)
        Me.flowLayoutPanel1.Controls.Add(Me.ValidateContextMenu)
        Me.flowLayoutPanel1.Controls.Add(Me.CustomizeDataSourceCaption)
        Me.flowLayoutPanel1.Controls.Add(Me.CustomizeDataSourceFieldList)
        Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(1096, 37)
        Me.flowLayoutPanel1.TabIndex = 1
        '
        'QElementCreated
        '
        Me.QElementCreated.AutoSize = true
        Me.QElementCreated.Checked = true
        Me.QElementCreated.CheckState = System.Windows.Forms.CheckState.Checked
        Me.QElementCreated.Location = New System.Drawing.Point(6, 6)
        Me.QElementCreated.Name = "QElementCreated"
        Me.QElementCreated.Size = New System.Drawing.Size(162, 17)
        Me.QElementCreated.TabIndex = 0
        Me.QElementCreated.Text = "QueryElementControlCreated"
        Me.QElementCreated.UseVisualStyleBackColor = true
        '
        'QElementDestroying
        '
        Me.QElementDestroying.AutoSize = true
        Me.QElementDestroying.Checked = true
        Me.QElementDestroying.CheckState = System.Windows.Forms.CheckState.Checked
        Me.QElementDestroying.Location = New System.Drawing.Point(174, 6)
        Me.QElementDestroying.Name = "QElementDestroying"
        Me.QElementDestroying.Size = New System.Drawing.Size(175, 17)
        Me.QElementDestroying.TabIndex = 0
        Me.QElementDestroying.Text = "QueryElementControlDestroying"
        Me.QElementDestroying.UseVisualStyleBackColor = true
        '
        'ValidateContextMenu
        '
        Me.ValidateContextMenu.AutoSize = true
        Me.ValidateContextMenu.Checked = true
        Me.ValidateContextMenu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ValidateContextMenu.Location = New System.Drawing.Point(355, 6)
        Me.ValidateContextMenu.Name = "ValidateContextMenu"
        Me.ValidateContextMenu.Size = New System.Drawing.Size(127, 17)
        Me.ValidateContextMenu.TabIndex = 0
        Me.ValidateContextMenu.Text = "ValidateContextMenu"
        Me.ValidateContextMenu.UseVisualStyleBackColor = true
        '
        'CustomizeDataSourceCaption
        '
        Me.CustomizeDataSourceCaption.AutoSize = true
        Me.CustomizeDataSourceCaption.Checked = true
        Me.CustomizeDataSourceCaption.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CustomizeDataSourceCaption.Location = New System.Drawing.Point(488, 6)
        Me.CustomizeDataSourceCaption.Name = "CustomizeDataSourceCaption"
        Me.CustomizeDataSourceCaption.Size = New System.Drawing.Size(167, 17)
        Me.CustomizeDataSourceCaption.TabIndex = 0
        Me.CustomizeDataSourceCaption.Text = "CustomizeDataSourceCaption"
        Me.CustomizeDataSourceCaption.UseVisualStyleBackColor = true
        '
        'CustomizeDataSourceFieldList
        '
        Me.CustomizeDataSourceFieldList.AutoSize = true
        Me.CustomizeDataSourceFieldList.Checked = true
        Me.CustomizeDataSourceFieldList.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CustomizeDataSourceFieldList.Location = New System.Drawing.Point(661, 6)
        Me.CustomizeDataSourceFieldList.Name = "CustomizeDataSourceFieldList"
        Me.CustomizeDataSourceFieldList.Size = New System.Drawing.Size(169, 17)
        Me.CustomizeDataSourceFieldList.TabIndex = 0
        Me.CustomizeDataSourceFieldList.Text = "CustomizeDataSourceFieldList"
        Me.CustomizeDataSourceFieldList.UseVisualStyleBackColor = true
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 741)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Interface Customization demo"
        Me.tableLayoutPanel1.ResumeLayout(false)
        Me.splitContainer1.Panel1.ResumeLayout(false)
        Me.splitContainer1.Panel2.ResumeLayout(false)
        CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.splitContainer1.ResumeLayout(false)
        CType(Me.QBuilder,System.ComponentModel.ISupportInitialize).EndInit
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        Me.flowLayoutPanel1.ResumeLayout(false)
        Me.flowLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

	#End Region

	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private TextBoxReport As System.Windows.Forms.RichTextBox
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private WithEvents QBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private WithEvents TextBoxSQL As System.Windows.Forms.RichTextBox
	Private panel1 As System.Windows.Forms.Panel
	Private flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
	Private QElementCreated As System.Windows.Forms.CheckBox
	Private QElementDestroying As System.Windows.Forms.CheckBox
	Private ValidateContextMenu As System.Windows.Forms.CheckBox
	Private CustomizeDataSourceCaption As System.Windows.Forms.CheckBox
	Private CustomizeDataSourceFieldList As System.Windows.Forms.CheckBox
	Private label1 As System.Windows.Forms.Label
End Class

