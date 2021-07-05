
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
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim linkPainterAccess1 As New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.textBox1 = New TextBox()
        Me.rbQuery = New RadioButton()
        Me.rbSubQuery = New RadioButton()
        Me.rbUnionSubQuery = New RadioButton()
        Me.label1 = New Label()
        Me.label2 = New Label()
        Me.label3 = New Label()
        Me.menuStrip1 = New MenuStrip()
        Me.connectToolStripMenuItem = New ToolStripMenuItem()
        Me.tabControl1 = New TabControl()
        Me.tabPageQueryText = New TabPage()
        Me.errorBox1 = New Common.SqlErrorBox()
        Me.tabPageResultsPreview = New TabPage()
        Me.dataGridView1 = New DataGridView()
        Me.label4 = New Label()
        Me.connectToToolStripMenuItem = New ToolStripMenuItem()
        CType(Me.queryBuilder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPageQueryText.SuspendLayout()
        Me.tabPageResultsPreview.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' queryBuilder
        ' 
        Me.queryBuilder.AddObjectDialogOptions.Location = New Point(0, 0)
        Me.queryBuilder.AddObjectDialogOptions.Size = New Size(430, 430)
        Me.queryBuilder.AddObjectDialogOptions.StartPosition = FormStartPosition.CenterScreen
        Me.queryBuilder.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.queryBuilder.BorderStyle = BorderStyle.None
        Me.queryBuilder.DatabaseSchemaViewOptions.AllowDrop = True
        Me.queryBuilder.DatabaseSchemaViewOptions.DrawTreeLines = False
        Me.queryBuilder.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = Color.Black
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = (CType(resources.GetObject("resource.PrimaryKeyIcon"), Image))
        Me.queryBuilder.DesignPaneOptions.Background = SystemColors.Window
        linkPainterAccess1.LinkColor = Color.Black
        linkPainterAccess1.LinkColorFocused = Color.Black
        linkPainterAccess1.MarkColor = SystemColors.Control
        linkPainterAccess1.MarkColorFocused = SystemColors.ControlDark
        linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1
        Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.World)
        Me.queryBuilder.Location = New Point(12, 99)
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
        Me.queryBuilder.QueryColumnListOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder.QueryColumnListOptions.NullOrderingInOrderBy = False
        Me.queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder.QueryNavBarOptions.ActionButtonBackColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.ActionButtonBorderColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.ActiveSubQueryItemBackColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.ActiveSubQueryItemBorderColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.AddCteCircleColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.AddUnionSubQueryCircleColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.BreadcrumbsBackgroundColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.CTEButtonBaseColor = Color.Green
        Me.queryBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = False
        Me.queryBuilder.QueryNavBarOptions.DragIndicatorColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.DragIndicatorHoverColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder.QueryNavBarOptions.ForeColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.GraphLineColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.GroupBackColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.GroupTextColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.OverflowButtonBaseColor = Color.DarkRed
        Me.queryBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = Color.Black
        Me.queryBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = Color.Blue
        Me.queryBuilder.QueryNavBarOptions.SubQueryItemBackColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.SubQueryItemBorderColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.SubQueryMarkerColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.SubQueryPopupBackColor = Color.Empty
        Me.queryBuilder.QueryNavBarOptions.TextHoverColor = Color.Empty
        Me.queryBuilder.Size = New Size(926, 392)
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
        Me.queryBuilder.TabIndex = 3
        Me.queryBuilder.VisualOptions.ActiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(157))))))
        Me.queryBuilder.VisualOptions.ActiveDockPanelCaptionFontColor = Color.Black
        Me.queryBuilder.VisualOptions.DockPanelBackColor = Color.Empty
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
'			Me.queryBuilder.ActiveUnionSubQueryChanged += New System.EventHandler(Me.queryBuilder_ActiveUnionSubQueryChanged)
'			Me.queryBuilder.SQLUpdated += New System.EventHandler(Me.queryBuilder_SQLUpdated)
        ' 
        ' textBox1
        ' 
        Me.textBox1.Dock = DockStyle.Fill
        Me.textBox1.Font = New Font("Courier New", 9F)
        Me.textBox1.Location = New Point(3, 3)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = ScrollBars.Both
        Me.textBox1.Size = New Size(912, 127)
        Me.textBox1.TabIndex = 4
'			Me.textBox1.Validating += New System.ComponentModel.CancelEventHandler(Me.textBox1_Validating)
        ' 
        ' rbQuery
        ' 
        Me.rbQuery.AutoSize = True
        Me.rbQuery.ForeColor = Color.Maroon
        Me.rbQuery.Location = New Point(136, 27)
        Me.rbQuery.Name = "rbQuery"
        Me.rbQuery.Size = New Size(72, 17)
        Me.rbQuery.TabIndex = 0
        Me.rbQuery.TabStop = True
        Me.rbQuery.Text = "Full Query"
        Me.rbQuery.UseVisualStyleBackColor = True
'			Me.rbQuery.CheckedChanged += New System.EventHandler(Me.QueryPartChanged)
        ' 
        ' rbSubQuery
        ' 
        Me.rbSubQuery.AutoSize = True
        Me.rbSubQuery.ForeColor = Color.Maroon
        Me.rbSubQuery.Location = New Point(136, 50)
        Me.rbSubQuery.Name = "rbSubQuery"
        Me.rbSubQuery.Size = New Size(73, 17)
        Me.rbSubQuery.TabIndex = 1
        Me.rbSubQuery.TabStop = True
        Me.rbSubQuery.Text = "Sub-query"
        Me.rbSubQuery.UseVisualStyleBackColor = True
'			Me.rbSubQuery.CheckedChanged += New System.EventHandler(Me.QueryPartChanged)
        ' 
        ' rbUnionSubQuery
        ' 
        Me.rbUnionSubQuery.AutoSize = True
        Me.rbUnionSubQuery.ForeColor = Color.Maroon
        Me.rbUnionSubQuery.Location = New Point(136, 73)
        Me.rbUnionSubQuery.Margin = New Padding(3, 3, 3, 6)
        Me.rbUnionSubQuery.Name = "rbUnionSubQuery"
        Me.rbUnionSubQuery.Size = New Size(102, 17)
        Me.rbUnionSubQuery.TabIndex = 2
        Me.rbUnionSubQuery.TabStop = True
        Me.rbUnionSubQuery.Text = "Union sub-query"
        Me.rbUnionSubQuery.UseVisualStyleBackColor = True
'			Me.rbUnionSubQuery.CheckedChanged += New System.EventHandler(Me.QueryPartChanged)
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New Point(244, 75)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(627, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Show only tabs related to selected UNION; show text of selected UNION only. Acts " & "like the previous mode if select a sub-query tab."
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New Point(244, 52)
        Me.label2.Name = "label2"
        Me.label2.Size = New Size(398, 13)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Show only tabs related to selected sub-query; show text of selected sub-query onl" & "y."
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New Point(244, 29)
        Me.label3.Name = "label3"
        Me.label3.Size = New Size(223, 13)
        Me.label3.TabIndex = 7
        Me.label3.Text = "Show all subquery tabs and the full query text."
        ' 
        ' menuStrip1
        ' 
        Me.menuStrip1.Items.AddRange(New ToolStripItem() { Me.connectToolStripMenuItem})
        Me.menuStrip1.Location = New Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New Size(950, 24)
        Me.menuStrip1.TabIndex = 8
        Me.menuStrip1.Text = "menuStrip1"
        ' 
        ' connectToolStripMenuItem
        ' 
        Me.connectToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.connectToToolStripMenuItem})
        Me.connectToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.connectToolStripMenuItem.Name = "connectToolStripMenuItem"
        Me.connectToolStripMenuItem.Size = New Size(119, 20)
        Me.connectToolStripMenuItem.Text = "Connect Database"
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tabControl1.Controls.Add(Me.tabPageQueryText)
        Me.tabControl1.Controls.Add(Me.tabPageResultsPreview)
        Me.tabControl1.Location = New Point(12, 497)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New Size(926, 159)
        Me.tabControl1.TabIndex = 9
'			Me.tabControl1.Selected += New System.Windows.Forms.TabControlEventHandler(Me.tabControl1_Selected)
        ' 
        ' tabPageQueryText
        ' 
        Me.tabPageQueryText.Controls.Add(Me.errorBox1)
        Me.tabPageQueryText.Controls.Add(Me.textBox1)
        Me.tabPageQueryText.Location = New Point(4, 22)
        Me.tabPageQueryText.Name = "tabPageQueryText"
        Me.tabPageQueryText.Padding = New Padding(3)
        Me.tabPageQueryText.Size = New Size(918, 133)
        Me.tabPageQueryText.TabIndex = 0
        Me.tabPageQueryText.Text = "Selected Query Part Text"
        Me.tabPageQueryText.UseVisualStyleBackColor = True
        ' 
        ' errorBox1
        ' 
        Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox1.AutoSize = True
        Me.errorBox1.BackColor = Color.LightPink
        Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = False
        Me.errorBox1.Location = New Point(580, 66)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New Padding(5)
        Me.errorBox1.Size = New Size(314, 61)
        Me.errorBox1.TabIndex = 5
        Me.errorBox1.Visible = False
'			Me.errorBox1.GoToErrorPosition += New System.EventHandler(Me.errorBox1_GoToErrorPosition)
'			Me.errorBox1.RevertValidText += New System.EventHandler(Me.errorBox1_RevertValidText)
        ' 
        ' tabPageResultsPreview
        ' 
        Me.tabPageResultsPreview.Controls.Add(Me.dataGridView1)
        Me.tabPageResultsPreview.Location = New Point(4, 22)
        Me.tabPageResultsPreview.Name = "tabPageResultsPreview"
        Me.tabPageResultsPreview.Padding = New Padding(3)
        Me.tabPageResultsPreview.Size = New Size(918, 133)
        Me.tabPageResultsPreview.TabIndex = 1
        Me.tabPageResultsPreview.Text = "---> Results Preview <---"
        Me.tabPageResultsPreview.UseVisualStyleBackColor = True
        ' 
        ' dataGridView1
        ' 
        Me.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Dock = DockStyle.Fill
        Me.dataGridView1.Location = New Point(3, 3)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New Size(912, 127)
        Me.dataGridView1.TabIndex = 0
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New Point(12, 29)
        Me.label4.Name = "label4"
        Me.label4.Size = New Size(106, 13)
        Me.label4.TabIndex = 10
        Me.label4.Text = "Query part to display:"
        ' 
        ' connectToToolStripMenuItem
        ' 
        Me.connectToToolStripMenuItem.Name = "connectToToolStripMenuItem"
        Me.connectToToolStripMenuItem.Size = New Size(180, 22)
        Me.connectToToolStripMenuItem.Text = "Connect to..."
'			Me.connectToToolStripMenuItem.Click += New System.EventHandler(Me.connectToToolStripMenuItem_Click)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(950, 668)
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
        CType(Me.queryBuilder.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.tabControl1.ResumeLayout(False)
        Me.tabPageQueryText.ResumeLayout(False)
        Me.tabPageQueryText.PerformLayout()
        Me.tabPageResultsPreview.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private WithEvents textBox1 As TextBox
    Private WithEvents rbQuery As RadioButton
    Private WithEvents rbSubQuery As RadioButton
    Private WithEvents rbUnionSubQuery As RadioButton
    Private label1 As Label
    Private label2 As Label
    Private label3 As Label
    Private menuStrip1 As MenuStrip
    Private connectToolStripMenuItem As ToolStripMenuItem
    Private WithEvents tabControl1 As TabControl
    Private tabPageQueryText As TabPage
    Private tabPageResultsPreview As TabPage
    Private label4 As Label
    Private dataGridView1 As DataGridView
    Private WithEvents errorBox1 As GeneralAssembly.Common.SqlErrorBox
    Private WithEvents connectToToolStripMenuItem As ToolStripMenuItem
End Class