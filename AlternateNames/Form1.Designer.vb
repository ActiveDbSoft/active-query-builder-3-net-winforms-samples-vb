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
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.splitContainer1 = New SplitContainer()
        Me.tabControl1 = New TabControl()
        Me.tabPage1 = New TabPage()
        Me.textBox1 = New TextBox()
        Me.tabPage2 = New TabPage()
        Me.textBox2 = New TextBox()
        Me.errorBox1 = New Common.SqlErrorBox()
        Me.errorBox2 = New Common.SqlErrorBox()
        Me.menuStrip1.SuspendLayout()
        CType(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
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
        Me.menuStrip1.Items.AddRange(New ToolStripItem() {Me.editMetadataToolStripMenuItem, Me.aboutToolStripMenuItem})
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
        ' queryBuilder1
        ' 
        Me.queryBuilder1.AddObjectDialogOptions.Location = New Point(0, 0)
        Me.queryBuilder1.AddObjectDialogOptions.Size = New Size(430, 430)
        Me.queryBuilder1.AddObjectDialogOptions.StartPosition = FormStartPosition.CenterScreen
        Me.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = False
        Me.queryBuilder1.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder1.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = (CType(resources.GetObject("resource.PrimaryKeyIcon"), Image))
        Me.queryBuilder1.DataSourceOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder1.DesignPaneOptions.Background = SystemColors.Window
        linkPainterAccess2.LinkColor = Color.Black
        linkPainterAccess2.LinkColorFocused = Color.Black
        linkPainterAccess2.MarkColor = SystemColors.Control
        linkPainterAccess2.MarkColorFocused = SystemColors.ControlDark
        linkPainterAccess2.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder1.DesignPaneOptions.LinkPainterOptions = linkPainterAccess2
        Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder1.Dock = DockStyle.Fill
        Me.queryBuilder1.Font = New Font("Segoe UI", 8.25F)
        Me.queryBuilder1.Location = New Point(0, 0)
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 250
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = True
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = True
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = True
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = True
        Me.queryBuilder1.QueryColumnListOptions.Font = Nothing
        Me.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = False
        Me.queryBuilder1.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder1.QueryNavBarOptions.CTEButtonBaseColor = Color.Green
        Me.queryBuilder1.QueryNavBarOptions.DisableQueryNavigationBarPopup = False
        Me.queryBuilder1.QueryNavBarOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder1.QueryNavBarOptions.OverflowButtonBaseColor = Color.DarkRed
        Me.queryBuilder1.QueryNavBarOptions.RootQueryButtonBaseColor = Color.Black
        Me.queryBuilder1.QueryNavBarOptions.SubQueryButtonBaseColor = Color.Blue
        Me.queryBuilder1.Size = New Size(793, 358)
        ' 
        ' 
        ' 
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DynamicIndents = False
        Me.queryBuilder1.SQLFormattingOptions.DynamicRightMargin = False
        Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = False
        Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = False
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        ' 
        ' 
        ' 
        Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = True
        Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = True
        Me.queryBuilder1.TabIndex = 0
        Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(157))))))
        Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionFontColor = Color.Black
        Me.queryBuilder1.VisualOptions.DockTabColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.queryBuilder1.VisualOptions.DockTabFontColor = Color.White
        Me.queryBuilder1.VisualOptions.DockTabFontHoverColor = Color.White
        Me.queryBuilder1.VisualOptions.DockTabHoverColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.queryBuilder1.VisualOptions.DockTabIndicatorColor = Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(125))))))
        Me.queryBuilder1.VisualOptions.DockTabIndicatorHoverColor = Color.FromArgb((CInt(Fix((CByte(155))))), (CInt(Fix((CByte(167))))), (CInt(Fix((CByte(183))))))
        Me.queryBuilder1.VisualOptions.InactiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(96))))), (CInt(Fix((CByte(130))))))
        Me.queryBuilder1.VisualOptions.InactiveDockPanelCaptionFontColor = Color.White
        Me.queryBuilder1.VisualOptions.TabFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder1.VisualOptions.TabsStripBackColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        '			Me.queryBuilder1.SQLUpdated += New System.EventHandler(Me.queryBuilder_SQLUpdated)
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = DockStyle.Fill
        Me.splitContainer1.Location = New Point(0, 24)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder1)
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.Controls.Add(Me.tabControl1)
        Me.splitContainer1.Size = New Size(793, 506)
        Me.splitContainer1.SplitterDistance = 358
        Me.splitContainer1.TabIndex = 2
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Dock = DockStyle.Fill
        Me.tabControl1.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.tabControl1.Location = New Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New Size(793, 144)
        Me.tabControl1.TabIndex = 0
        ' 
        ' tabPage1
        ' 
        Me.tabPage1.Controls.Add(Me.errorBox1)
        Me.tabPage1.Controls.Add(Me.textBox1)
        Me.tabPage1.Location = New Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New Padding(3)
        Me.tabPage1.Size = New Size(785, 118)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Query text with alternate object names"
        Me.tabPage1.UseVisualStyleBackColor = True
        ' 
        ' textBox1
        ' 
        Me.textBox1.Dock = DockStyle.Fill
        Me.textBox1.Font = New Font("Courier New", 9.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.textBox1.HideSelection = False
        Me.textBox1.Location = New Point(3, 3)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = ScrollBars.Both
        Me.textBox1.Size = New Size(779, 112)
        Me.textBox1.TabIndex = 1
        '			Me.textBox1.Validating += New System.ComponentModel.CancelEventHandler(Me.textBox1_Validating)
        ' 
        ' tabPage2
        ' 
        Me.tabPage2.Controls.Add(Me.errorBox2)
        Me.tabPage2.Controls.Add(Me.textBox2)
        Me.tabPage2.Location = New Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New Padding(3)
        Me.tabPage2.Size = New Size(785, 118)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Query text with real object names"
        Me.tabPage2.UseVisualStyleBackColor = True
        ' 
        ' textBox2
        ' 
        Me.textBox2.Dock = DockStyle.Fill
        Me.textBox2.Font = New Font("Courier New", 9.0F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.textBox2.HideSelection = False
        Me.textBox2.Location = New Point(3, 3)
        Me.textBox2.Multiline = True
        Me.textBox2.Name = "textBox2"
        Me.textBox2.ScrollBars = ScrollBars.Both
        Me.textBox2.Size = New Size(779, 112)
        Me.textBox2.TabIndex = 2
        '			Me.textBox2.Validating += New System.ComponentModel.CancelEventHandler(Me.textBox2_Validating)
        ' 
        ' errorBox1
        ' 
        Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox1.AutoSize = True
        Me.errorBox1.BackColor = Color.LightPink
        Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = False
        Me.errorBox1.Location = New Point(454, 47)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New Padding(6, 5, 6, 5)
        Me.errorBox1.Size = New Size(307, 63)
        Me.errorBox1.TabIndex = 2
        Me.errorBox1.Visible = False
        '			Me.errorBox1.GoToErrorPosition += New System.EventHandler(Me.ErrorBox1_GoToErrorPosition)
        '			Me.errorBox1.RevertValidText += New System.EventHandler(Me.ErrorBox1_RevertValidText)
        ' 
        ' errorBox2
        ' 
        Me.errorBox2.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox2.AutoSize = True
        Me.errorBox2.BackColor = Color.LightPink
        Me.errorBox2.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox2.CurrentSyntaxProvider = Nothing
        Me.errorBox2.IsVisibleCheckSyntaxPanel = False
        Me.errorBox2.Location = New Point(404, 47)
        Me.errorBox2.Name = "errorBox2"
        Me.errorBox2.Padding = New Padding(7, 5, 7, 5)
        Me.errorBox2.Size = New Size(358, 63)
        Me.errorBox2.TabIndex = 3
        Me.errorBox2.Visible = False
        '			Me.errorBox2.GoToErrorPosition += New System.EventHandler(Me.ErrorBox2_GoToErrorPosition)
        '			Me.errorBox2.RevertValidText += New System.EventHandler(Me.ErrorBox2_RevertValidText)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(793, 530)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "AlternateNames Demo"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private menuStrip1 As MenuStrip
    Private WithEvents aboutToolStripMenuItem As ToolStripMenuItem
    Private imageList16 As ImageList
    Private imageList32 As ImageList
    Private splitContainer1 As SplitContainer
    Private WithEvents queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private tabControl1 As TabControl
    Private tabPage1 As TabPage
    Private WithEvents textBox1 As TextBox
    Private tabPage2 As TabPage
    Private WithEvents textBox2 As TextBox
    Private WithEvents editMetadataToolStripMenuItem As ToolStripMenuItem
    Private WithEvents errorBox1 As Global.GeneralAssembly.Common.SqlErrorBox
    Private WithEvents errorBox2 As Common.SqlErrorBox
End Class