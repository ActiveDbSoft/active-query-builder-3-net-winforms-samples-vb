
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
        Me.CheckBoxBeforeDsFieldDrag = New CheckBox()
        Me.CheckBoxLinkDragOver = New CheckBox()
        Me.label1 = New Label()
        Me.splitContainer1 = New SplitContainer()
        Me.QBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.errorBox1 = New Common.SqlErrorBox()
        Me.TextBoxSQL = New RichTextBox()
        Me.TextBoxReport = New RichTextBox()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
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
        Me.tableLayoutPanel1.AutoSize = True
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
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 100F))
        Me.tableLayoutPanel1.Size = New Size(999, 659)
        Me.tableLayoutPanel1.TabIndex = 0
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = SystemColors.Info
        Me.panel1.Controls.Add(Me.flowLayoutPanel1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = DockStyle.Top
        Me.panel1.Location = New Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New Size(993, 50)
        Me.panel1.TabIndex = 0
        ' 
        ' flowLayoutPanel1
        ' 
        Me.flowLayoutPanel1.AutoSize = True
        Me.flowLayoutPanel1.Controls.Add(Me.CheckBoxBeforeDsFieldDrag)
        Me.flowLayoutPanel1.Controls.Add(Me.CheckBoxLinkDragOver)
        Me.flowLayoutPanel1.Dock = DockStyle.Top
        Me.flowLayoutPanel1.Location = New Point(0, 13)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Padding = New Padding(5)
        Me.flowLayoutPanel1.Size = New Size(993, 33)
        Me.flowLayoutPanel1.TabIndex = 1
        ' 
        ' CheckBoxBeforeDsFieldDrag
        ' 
        Me.CheckBoxBeforeDsFieldDrag.AutoSize = True
        Me.CheckBoxBeforeDsFieldDrag.Checked = True
        Me.CheckBoxBeforeDsFieldDrag.CheckState = CheckState.Checked
        Me.CheckBoxBeforeDsFieldDrag.Location = New Point(8, 8)
        Me.CheckBoxBeforeDsFieldDrag.Name = "CheckBoxBeforeDsFieldDrag"
        Me.CheckBoxBeforeDsFieldDrag.Size = New Size(157, 17)
        Me.CheckBoxBeforeDsFieldDrag.TabIndex = 0
        Me.CheckBoxBeforeDsFieldDrag.Text = "BeforeDatasourceFieldDrag"
        Me.CheckBoxBeforeDsFieldDrag.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxLinkDragOver
        ' 
        Me.CheckBoxLinkDragOver.AutoSize = True
        Me.CheckBoxLinkDragOver.Checked = True
        Me.CheckBoxLinkDragOver.CheckState = CheckState.Checked
        Me.CheckBoxLinkDragOver.Location = New Point(171, 8)
        Me.CheckBoxLinkDragOver.Name = "CheckBoxLinkDragOver"
        Me.CheckBoxLinkDragOver.Size = New Size(92, 17)
        Me.CheckBoxLinkDragOver.TabIndex = 0
        Me.CheckBoxLinkDragOver.Text = "LinkDragOver"
        Me.CheckBoxLinkDragOver.UseVisualStyleBackColor = True
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Dock = DockStyle.Top
        Me.label1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.label1.Location = New Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(55, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Stop on:"
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = DockStyle.Fill
        Me.splitContainer1.FixedPanel = FixedPanel.Panel2
        Me.splitContainer1.Location = New Point(3, 59)
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
        Me.splitContainer1.Size = New Size(993, 497)
        Me.splitContainer1.SplitterDistance = 383
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
        Me.QBuilder.Size = New Size(993, 383)
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
        Me.QBuilder.TabIndex = 2
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
'			Me.QBuilder.LinkDragOver += New ActiveQueryBuilder.View.QueryView.LinkDragOverEventhandler(Me.QBuilder_LinkDragOver)
'			Me.QBuilder.BeforeDatasourceFieldDrag += New ActiveQueryBuilder.View.QueryView.BeforeDataSourceFieldDragEventHandler(Me.QBuilder_BeforeDatasourceFieldDrag)
'			Me.QBuilder.SQLUpdated += New System.EventHandler(Me.queryBuilder1_SQLUpdated)
        ' 
        ' errorBox1
        ' 
        Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox1.AutoSize = True
        Me.errorBox1.BackColor = Color.LightPink
        Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = False
        Me.errorBox1.Location = New Point(678, 46)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New Padding(5)
        Me.errorBox1.Size = New Size(306, 61)
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
        Me.TextBoxSQL.Size = New Size(993, 110)
        Me.TextBoxSQL.TabIndex = 0
        Me.TextBoxSQL.Text = ""
'			Me.TextBoxSQL.Validating += New System.ComponentModel.CancelEventHandler(Me.TextBoxSQL_Validating)
        ' 
        ' TextBoxReport
        ' 
        Me.TextBoxReport.BackColor = SystemColors.Info
        Me.TextBoxReport.Dock = DockStyle.Fill
        Me.TextBoxReport.Location = New Point(3, 562)
        Me.TextBoxReport.Name = "TextBoxReport"
        Me.TextBoxReport.Size = New Size(993, 94)
        Me.TextBoxReport.TabIndex = 2
        Me.TextBoxReport.Text = ""
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(999, 659)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Datasource Fields Linking Drag’n’Drop demo"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.flowLayoutPanel1.PerformLayout()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        CType(Me.QBuilder.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QBuilder.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QBuilder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private tableLayoutPanel1 As TableLayoutPanel
    Private panel1 As Panel
    Private flowLayoutPanel1 As FlowLayoutPanel
    Private CheckBoxBeforeDsFieldDrag As CheckBox
    Private CheckBoxLinkDragOver As CheckBox
    Private label1 As Label
    Private splitContainer1 As SplitContainer
    Private WithEvents QBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private WithEvents TextBoxSQL As RichTextBox
    Private TextBoxReport As RichTextBox
    Private WithEvents errorBox1 As Common.SqlErrorBox
End Class