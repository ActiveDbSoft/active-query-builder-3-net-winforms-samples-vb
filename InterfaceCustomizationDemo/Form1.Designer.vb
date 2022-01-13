
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
        Me.TextBoxReport = New RichTextBox()
        Me.splitContainer1 = New SplitContainer()
        Me.QBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.TextBoxSQL = New RichTextBox()
        Me.panel1 = New Panel()
        Me.flowLayoutPanel1 = New FlowLayoutPanel()
        Me.QElementCreated = New CheckBox()
        Me.QElementDestroying = New CheckBox()
        Me.ValidateContextMenu = New CheckBox()
        Me.CustomizeDataSourceCaption = New CheckBox()
        Me.CustomizeDataSourceFieldList = New CheckBox()
        Me.label1 = New Label()
        Me.errorBox1 = New Common.SqlErrorBox()
        Me.tableLayoutPanel1.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.QBuilder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QBuilder.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QBuilder.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' tableLayoutPanel1
        ' 
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel1.Controls.Add(Me.TextBoxReport, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.splitContainer1, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel1.Dock = DockStyle.Fill
        Me.tableLayoutPanel1.Location = New Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 100F))
        Me.tableLayoutPanel1.Size = New Size(1108, 741)
        Me.tableLayoutPanel1.TabIndex = 0
        ' 
        ' TextBoxReport
        ' 
        Me.TextBoxReport.BackColor = SystemColors.Info
        Me.TextBoxReport.Dock = DockStyle.Fill
        Me.TextBoxReport.Location = New Point(3, 644)
        Me.TextBoxReport.Name = "TextBoxReport"
        Me.TextBoxReport.Size = New Size(1102, 94)
        Me.TextBoxReport.TabIndex = 0
        Me.TextBoxReport.Text = ""
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = DockStyle.Fill
        Me.splitContainer1.FixedPanel = FixedPanel.Panel2
        Me.splitContainer1.Location = New Point(3, 71)
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
        Me.splitContainer1.Size = New Size(1102, 567)
        Me.splitContainer1.SplitterDistance = 445
        Me.splitContainer1.TabIndex = 0
        ' 
        ' QBuilder
        ' 
        Me.QBuilder.AddObjectDialogOptions.Location = New Point(0, 0)
        Me.QBuilder.AddObjectDialogOptions.Size = New Size(430, 430)
        Me.QBuilder.AddObjectDialogOptions.StartPosition = FormStartPosition.CenterScreen
        Me.QBuilder.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = False
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
        Me.QBuilder.Font = New Font("Segoe UI", 8.25F)
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
        Me.QBuilder.Size = New Size(1102, 445)
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
        Me.QBuilder.VisualOptions.TabFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.QBuilder.VisualOptions.TabsStripBackColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
'            Me.QBuilder.ValidateContextMenu += New ActiveQueryBuilder.View.QueryView.ContextMenuEventHandler(Me.QBuilder_ValidateContextMenu)
'            Me.QBuilder.CustomizeDataSourceFieldList += New ActiveQueryBuilder.View.QueryView.CustomizeDataSourceFieldListEventHandler(Me.QBuilder_CustomizeDataSourceFieldList)
'            Me.QBuilder.CustomizeDataSourceCaption += New ActiveQueryBuilder.View.QueryView.CustomizeDataSourceCaptionEventHandler(Me.QBuilder_CustomizeDataSourceCaption)
'            Me.QBuilder.SQLUpdated += New System.EventHandler(Me.QBuilder_SQLUpdated)
'            Me.QBuilder.QueryElementControlCreated += New ActiveQueryBuilder.View.QueryView.QueryElementControlCreatedEventHandler(Me.QBuilder_QueryElementControlCreated)
'            Me.QBuilder.QueryElementControlDestroying += New ActiveQueryBuilder.View.QueryView.QueryElementControlDestroyingEventHandler(Me.QBuilder_QueryElementControlDestroying)
        ' 
        ' TextBoxSQL
        ' 
        Me.TextBoxSQL.Dock = DockStyle.Fill
        Me.TextBoxSQL.Location = New Point(0, 0)
        Me.TextBoxSQL.Name = "TextBoxSQL"
        Me.TextBoxSQL.Size = New Size(1102, 118)
        Me.TextBoxSQL.TabIndex = 0
        Me.TextBoxSQL.Text = ""
'            Me.TextBoxSQL.Validating += New System.ComponentModel.CancelEventHandler(Me.TextBoxSQL_Validating)
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = SystemColors.Info
        Me.panel1.Controls.Add(Me.flowLayoutPanel1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = DockStyle.Top
        Me.panel1.Location = New Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New Padding(3)
        Me.panel1.Size = New Size(1102, 62)
        Me.panel1.TabIndex = 1
        ' 
        ' flowLayoutPanel1
        ' 
        Me.flowLayoutPanel1.Controls.Add(Me.QElementCreated)
        Me.flowLayoutPanel1.Controls.Add(Me.QElementDestroying)
        Me.flowLayoutPanel1.Controls.Add(Me.ValidateContextMenu)
        Me.flowLayoutPanel1.Controls.Add(Me.CustomizeDataSourceCaption)
        Me.flowLayoutPanel1.Controls.Add(Me.CustomizeDataSourceFieldList)
        Me.flowLayoutPanel1.Dock = DockStyle.Top
        Me.flowLayoutPanel1.Location = New Point(3, 16)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Padding = New Padding(3)
        Me.flowLayoutPanel1.Size = New Size(1096, 37)
        Me.flowLayoutPanel1.TabIndex = 1
        ' 
        ' QElementCreated
        ' 
        Me.QElementCreated.AutoSize = True
        Me.QElementCreated.Checked = True
        Me.QElementCreated.CheckState = CheckState.Checked
        Me.QElementCreated.Location = New Point(6, 6)
        Me.QElementCreated.Name = "QElementCreated"
        Me.QElementCreated.Size = New Size(162, 17)
        Me.QElementCreated.TabIndex = 0
        Me.QElementCreated.Text = "QueryElementControlCreated"
        Me.QElementCreated.UseVisualStyleBackColor = True
        ' 
        ' QElementDestroying
        ' 
        Me.QElementDestroying.AutoSize = True
        Me.QElementDestroying.Checked = True
        Me.QElementDestroying.CheckState = CheckState.Checked
        Me.QElementDestroying.Location = New Point(174, 6)
        Me.QElementDestroying.Name = "QElementDestroying"
        Me.QElementDestroying.Size = New Size(175, 17)
        Me.QElementDestroying.TabIndex = 0
        Me.QElementDestroying.Text = "QueryElementControlDestroying"
        Me.QElementDestroying.UseVisualStyleBackColor = True
        ' 
        ' ValidateContextMenu
        ' 
        Me.ValidateContextMenu.AutoSize = True
        Me.ValidateContextMenu.Checked = True
        Me.ValidateContextMenu.CheckState = CheckState.Checked
        Me.ValidateContextMenu.Location = New Point(355, 6)
        Me.ValidateContextMenu.Name = "ValidateContextMenu"
        Me.ValidateContextMenu.Size = New Size(127, 17)
        Me.ValidateContextMenu.TabIndex = 0
        Me.ValidateContextMenu.Text = "ValidateContextMenu"
        Me.ValidateContextMenu.UseVisualStyleBackColor = True
        ' 
        ' CustomizeDataSourceCaption
        ' 
        Me.CustomizeDataSourceCaption.AutoSize = True
        Me.CustomizeDataSourceCaption.Checked = True
        Me.CustomizeDataSourceCaption.CheckState = CheckState.Checked
        Me.CustomizeDataSourceCaption.Location = New Point(488, 6)
        Me.CustomizeDataSourceCaption.Name = "CustomizeDataSourceCaption"
        Me.CustomizeDataSourceCaption.Size = New Size(167, 17)
        Me.CustomizeDataSourceCaption.TabIndex = 0
        Me.CustomizeDataSourceCaption.Text = "CustomizeDataSourceCaption"
        Me.CustomizeDataSourceCaption.UseVisualStyleBackColor = True
        ' 
        ' CustomizeDataSourceFieldList
        ' 
        Me.CustomizeDataSourceFieldList.AutoSize = True
        Me.CustomizeDataSourceFieldList.Checked = True
        Me.CustomizeDataSourceFieldList.CheckState = CheckState.Checked
        Me.CustomizeDataSourceFieldList.Location = New Point(661, 6)
        Me.CustomizeDataSourceFieldList.Name = "CustomizeDataSourceFieldList"
        Me.CustomizeDataSourceFieldList.Size = New Size(169, 17)
        Me.CustomizeDataSourceFieldList.TabIndex = 0
        Me.CustomizeDataSourceFieldList.Text = "CustomizeDataSourceFieldList"
        Me.CustomizeDataSourceFieldList.UseVisualStyleBackColor = True
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
        ' errorBox1
        ' 
        Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox1.AutoSize = True
        Me.errorBox1.BackColor = Color.LightPink
        Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = False
        Me.errorBox1.Location = New Point(769, 54)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New Padding(5)
        Me.errorBox1.Size = New Size(324, 61)
        Me.errorBox1.TabIndex = 1
        Me.errorBox1.Visible = False
'            Me.errorBox1.GoToErrorPosition += New System.EventHandler(Me.ErrorBox1_GoToErrorPosition)
'            Me.errorBox1.RevertValidText += New System.EventHandler(Me.ErrorBox1_RevertValidText)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1108, 741)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Interface Customization demo"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        CType(Me.QBuilder.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QBuilder.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QBuilder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.flowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private tableLayoutPanel1 As TableLayoutPanel
    Private TextBoxReport As RichTextBox
    Private splitContainer1 As SplitContainer
    Private WithEvents QBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private WithEvents TextBoxSQL As RichTextBox
    Private panel1 As Panel
    Private flowLayoutPanel1 As FlowLayoutPanel
    Private QElementCreated As CheckBox
    Private QElementDestroying As CheckBox
    Private ValidateContextMenu As CheckBox
    Private CustomizeDataSourceCaption As CheckBox
    Private CustomizeDataSourceFieldList As CheckBox
    Private label1 As Label
    Private WithEvents errorBox1 As Common.SqlErrorBox
End Class
