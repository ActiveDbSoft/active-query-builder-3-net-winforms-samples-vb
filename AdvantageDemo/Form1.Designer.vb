Imports ActiveQueryBuilder.View.WinForms


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
        Dim linkPainterAccess1 As New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tabControl1 = New TabControl()
        Me.tabPageSQL = New TabPage()
        Me.splitContainer1 = New SplitContainer()
        Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.advantageMetadataProvider1 = New ActiveQueryBuilder.Core.AdvantageMetadataProvider(Me.components)
        Me.advantageSyntaxProvider1 = New ActiveQueryBuilder.Core.AdvantageSyntaxProvider(Me.components)
        Me.errorBox1 = New GeneralAssembly.Common.SqlErrorBox()
        Me.textBox1 = New TextBox()
        Me.tabPageData = New TabPage()
        Me.dataGridView1 = New DataGridView()
        Me.menuStrip1 = New MenuStrip()
        Me.connectMetadataToolStripMenuItem = New ToolStripMenuItem()
        Me.metadataToolStripMenuItem = New ToolStripMenuItem()
        Me.refreshMetadataToolStripMenuItem = New ToolStripMenuItem()
        Me.editMetadataToolStripMenuItem = New ToolStripMenuItem()
        Me.clearMetadataToolStripMenuItem = New ToolStripMenuItem()
        Me.toolStripSeparator1 = New ToolStripSeparator()
        Me.loadFromXMLToolStripMenuItem = New ToolStripMenuItem()
        Me.saveToXMLToolStripMenuItem = New ToolStripMenuItem()
        Me.queryStatisticsMenuItem = New ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New ToolStripMenuItem()
        Me.openMetadataFileDialog = New OpenFileDialog()
        Me.saveMetadataFileDialog = New SaveFileDialog()
        Me.tabControl1.SuspendLayout()
        Me.tabPageSQL.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.queryBuilder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageData.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Controls.Add(Me.tabPageSQL)
        Me.tabControl1.Controls.Add(Me.tabPageData)
        Me.tabControl1.Dock = DockStyle.Fill
        Me.tabControl1.Location = New Point(0, 24)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New Size(793, 506)
        Me.tabControl1.TabIndex = 0
'            Me.tabControl1.Selected += New System.Windows.Forms.TabControlEventHandler(Me.tabControl1_Selected)
        ' 
        ' tabPageSQL
        ' 
        Me.tabPageSQL.Controls.Add(Me.splitContainer1)
        Me.tabPageSQL.Location = New Point(4, 22)
        Me.tabPageSQL.Name = "tabPageSQL"
        Me.tabPageSQL.Padding = New Padding(3)
        Me.tabPageSQL.Size = New Size(785, 480)
        Me.tabPageSQL.TabIndex = 0
        Me.tabPageSQL.Text = "SQL"
        Me.tabPageSQL.UseVisualStyleBackColor = True
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = DockStyle.Fill
        Me.splitContainer1.Location = New Point(3, 3)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.Controls.Add(Me.errorBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.textBox1)
        Me.splitContainer1.Size = New Size(779, 474)
        Me.splitContainer1.SplitterDistance = 364
        Me.splitContainer1.TabIndex = 0
        ' 
        ' queryBuilder
        ' 
        Me.queryBuilder.AddObjectDialogOptions.Location = New Point(0, 0)
        Me.queryBuilder.AddObjectDialogOptions.Size = New Size(430, 430)
        Me.queryBuilder.AddObjectDialogOptions.StartPosition = FormStartPosition.CenterScreen
        Me.queryBuilder.BorderStyle = BorderStyle.None
        Me.queryBuilder.DatabaseSchemaViewOptions.DrawTreeLines = False
        Me.queryBuilder.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder.DesignPaneOptions.Background = SystemColors.Window
        linkPainterAccess1.LinkColor = Color.Black
        linkPainterAccess1.LinkColorFocused = Color.Black
        linkPainterAccess1.MarkColor = SystemColors.Control
        linkPainterAccess1.MarkColorFocused = SystemColors.ControlDark
        linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1
        Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder.Dock = DockStyle.Fill
        Me.queryBuilder.Font = New Font("Segoe UI", 12F)
        Me.queryBuilder.Location = New Point(0, 0)
        Me.queryBuilder.MetadataProvider = Me.advantageMetadataProvider1
        Me.queryBuilder.Name = "queryBuilder"
        Me.queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = True
        Me.queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder.PanesConfigurationOptions.PropertiesBarEnabled = True
        Me.queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = True
        Me.queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = True
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
        Me.queryBuilder.Size = New Size(779, 364)
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
        Me.queryBuilder.SyntaxProvider = Me.advantageSyntaxProvider1
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
'            Me.queryBuilder.SQLUpdated += New System.EventHandler(Me.queryBuilder_SQLUpdated)
        ' 
        ' advantageMetadataProvider1
        ' 
        Me.advantageMetadataProvider1.Connection = Nothing
        ' 
        ' errorBox1
        ' 
        Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox1.AutoSize = True
        Me.errorBox1.BackColor = Color.LightPink
        Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = False
        Me.errorBox1.Location = New Point(465, 40)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New Padding(5)
        Me.errorBox1.Size = New Size(295, 63)
        Me.errorBox1.TabIndex = 1
        Me.errorBox1.Visible = False
'            Me.errorBox1.GoToErrorPosition += New System.EventHandler(Me.ErrorBox1_GoToErrorPosition)
'            Me.errorBox1.RevertValidText += New System.EventHandler(Me.ErrorBox1_RevertValidText)
        ' 
        ' textBox1
        ' 
        Me.textBox1.Dock = DockStyle.Fill
        Me.textBox1.HideSelection = False
        Me.textBox1.Location = New Point(0, 0)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = ScrollBars.Both
        Me.textBox1.Size = New Size(779, 106)
        Me.textBox1.TabIndex = 0
'            Me.textBox1.Validating += New System.ComponentModel.CancelEventHandler(Me.textBox1_Validating)
        ' 
        ' tabPageData
        ' 
        Me.tabPageData.Controls.Add(Me.dataGridView1)
        Me.tabPageData.Location = New Point(4, 22)
        Me.tabPageData.Name = "tabPageData"
        Me.tabPageData.Padding = New Padding(3)
        Me.tabPageData.Size = New Size(785, 480)
        Me.tabPageData.TabIndex = 1
        Me.tabPageData.Text = "Data"
        Me.tabPageData.UseVisualStyleBackColor = True
        ' 
        ' dataGridView1
        ' 
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Dock = DockStyle.Fill
        Me.dataGridView1.Location = New Point(3, 3)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.Size = New Size(779, 474)
        Me.dataGridView1.TabIndex = 0
        ' 
        ' menuStrip1
        ' 
        Me.menuStrip1.Items.AddRange(New ToolStripItem() { Me.connectMetadataToolStripMenuItem, Me.metadataToolStripMenuItem, Me.queryStatisticsMenuItem, Me.aboutToolStripMenuItem})
        Me.menuStrip1.Location = New Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.RenderMode = ToolStripRenderMode.System
        Me.menuStrip1.Size = New Size(793, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        ' 
        ' connectMetadataToolStripMenuItem
        ' 
        Me.connectMetadataToolStripMenuItem.Name = "connectMetadataToolStripMenuItem"
        Me.connectMetadataToolStripMenuItem.Size = New Size(73, 20)
        Me.connectMetadataToolStripMenuItem.Text = "Connect..."
'            Me.connectMetadataToolStripMenuItem.Click += New System.EventHandler(Me.connectMetadataToolStripMenuItem_Click)
        ' 
        ' metadataToolStripMenuItem
        ' 
        Me.metadataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() { Me.refreshMetadataToolStripMenuItem, Me.editMetadataToolStripMenuItem, Me.clearMetadataToolStripMenuItem, Me.toolStripSeparator1, Me.loadFromXMLToolStripMenuItem, Me.saveToXMLToolStripMenuItem})
        Me.metadataToolStripMenuItem.Name = "metadataToolStripMenuItem"
        Me.metadataToolStripMenuItem.Size = New Size(69, 20)
        Me.metadataToolStripMenuItem.Text = "Metadata"
        ' 
        ' refreshMetadataToolStripMenuItem
        ' 
        Me.refreshMetadataToolStripMenuItem.Name = "refreshMetadataToolStripMenuItem"
        Me.refreshMetadataToolStripMenuItem.Size = New Size(166, 22)
        Me.refreshMetadataToolStripMenuItem.Text = "Refresh Metadata"
'            Me.refreshMetadataToolStripMenuItem.Click += New System.EventHandler(Me.refreshMetadataToolStripMenuItem_Click)
        ' 
        ' editMetadataToolStripMenuItem
        ' 
        Me.editMetadataToolStripMenuItem.Name = "editMetadataToolStripMenuItem"
        Me.editMetadataToolStripMenuItem.Size = New Size(166, 22)
        Me.editMetadataToolStripMenuItem.Text = "Edit Metadata..."
'            Me.editMetadataToolStripMenuItem.Click += New System.EventHandler(Me.editMetadataToolStripMenuItem_Click)
        ' 
        ' clearMetadataToolStripMenuItem
        ' 
        Me.clearMetadataToolStripMenuItem.Name = "clearMetadataToolStripMenuItem"
        Me.clearMetadataToolStripMenuItem.Size = New Size(166, 22)
        Me.clearMetadataToolStripMenuItem.Text = "Clear Metadata"
'            Me.clearMetadataToolStripMenuItem.Click += New System.EventHandler(Me.clearMetadataToolStripMenuItem_Click)
        ' 
        ' toolStripSeparator1
        ' 
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New Size(163, 6)
        ' 
        ' loadFromXMLToolStripMenuItem
        ' 
        Me.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem"
        Me.loadFromXMLToolStripMenuItem.Size = New Size(166, 22)
        Me.loadFromXMLToolStripMenuItem.Text = "Load from XML..."
'            Me.loadFromXMLToolStripMenuItem.Click += New System.EventHandler(Me.loadFromXMLToolStripMenuItem_Click)
        ' 
        ' saveToXMLToolStripMenuItem
        ' 
        Me.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem"
        Me.saveToXMLToolStripMenuItem.Size = New Size(166, 22)
        Me.saveToXMLToolStripMenuItem.Text = "Save to XML..."
'            Me.saveToXMLToolStripMenuItem.Click += New System.EventHandler(Me.saveToXMLToolStripMenuItem_Click)
        ' 
        ' queryStatisticsMenuItem
        ' 
        Me.queryStatisticsMenuItem.Name = "queryStatisticsMenuItem"
        Me.queryStatisticsMenuItem.Size = New Size(109, 20)
        Me.queryStatisticsMenuItem.Text = "Query Statistics..."
'            Me.queryStatisticsMenuItem.Click += New System.EventHandler(Me.queryStatisticsMenuItem_Click)
        ' 
        ' aboutToolStripMenuItem
        ' 
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New Size(61, 20)
        Me.aboutToolStripMenuItem.Text = "About..."
'            Me.aboutToolStripMenuItem.Click += New System.EventHandler(Me.aboutToolStripMenuItem_Click)
        ' 
        ' openMetadataFileDialog
        ' 
        Me.openMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        ' 
        ' saveMetadataFileDialog
        ' 
        Me.saveMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(793, 530)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPageSQL.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        CType(Me.queryBuilder.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageData.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents tabControl1 As TabControl
    Private tabPageSQL As TabPage
    Private tabPageData As TabPage
    Private splitContainer1 As SplitContainer
    Private WithEvents textBox1 As TextBox
    Private dataGridView1 As DataGridView
    Private menuStrip1 As MenuStrip
    Private WithEvents connectMetadataToolStripMenuItem As ToolStripMenuItem
    Private metadataToolStripMenuItem As ToolStripMenuItem
    Private WithEvents refreshMetadataToolStripMenuItem As ToolStripMenuItem
    Private WithEvents editMetadataToolStripMenuItem As ToolStripMenuItem
    Private WithEvents clearMetadataToolStripMenuItem As ToolStripMenuItem
    Private toolStripSeparator1 As ToolStripSeparator
    Private WithEvents saveToXMLToolStripMenuItem As ToolStripMenuItem
    Private WithEvents loadFromXMLToolStripMenuItem As ToolStripMenuItem
    Private WithEvents aboutToolStripMenuItem As ToolStripMenuItem
    Private openMetadataFileDialog As OpenFileDialog
    Private saveMetadataFileDialog As SaveFileDialog
    Private WithEvents queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private advantageSyntaxProvider1 As ActiveQueryBuilder.Core.AdvantageSyntaxProvider
    Private advantageMetadataProvider1 As ActiveQueryBuilder.Core.AdvantageMetadataProvider
    Private WithEvents queryStatisticsMenuItem As ToolStripMenuItem
    Private WithEvents errorBox1 As GeneralAssembly.Common.SqlErrorBox
End Class
