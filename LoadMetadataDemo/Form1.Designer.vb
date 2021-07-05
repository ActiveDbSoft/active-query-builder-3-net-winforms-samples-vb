
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
        Dim linkPainterAccess1 As New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.imageList16 = New ImageList(Me.components)
        Me.openMetadataFileDialog = New OpenFileDialog()
        Me.saveMetadataFileDialog = New SaveFileDialog()
        Me.mainMenu1 = New MainMenu(Me.components)
        Me.menuItem1 = New MenuItem()
        Me.aboutMenuItem = New MenuItem()
        Me.splitContainer1 = New SplitContainer()
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.genericSyntaxProvider1 = New ActiveQueryBuilder.Core.GenericSyntaxProvider(Me.components)
        Me.textBox1 = New TextBox()
        Me.tabControl1 = New TabControl()
        Me.tabPageDirect = New TabPage()
        Me.btnFourthWay = New Button()
        Me.textBox5 = New TextBox()
        Me.tabPageOnDemand = New TabPage()
        Me.btnThirdWay = New Button()
        Me.textBox3 = New TextBox()
        Me.tabPageExecSql = New TabPage()
        Me.btnFirstWay = New Button()
        Me.label1 = New Label()
        Me.textBox2 = New TextBox()
        Me.tabPageDataset = New TabPage()
        Me.btnFifthWay = New Button()
        Me.textBox6 = New TextBox()
        Me.way3EventMetadataProvider = New ActiveQueryBuilder.Core.EventMetadataProvider(Me.components)
        Me.menuItemConnect = New MenuItem()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl1.SuspendLayout()
        Me.tabPageDirect.SuspendLayout()
        Me.tabPageOnDemand.SuspendLayout()
        Me.tabPageExecSql.SuspendLayout()
        Me.tabPageDataset.SuspendLayout()
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
        ' openMetadataFileDialog
        ' 
        Me.openMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        ' 
        ' saveMetadataFileDialog
        ' 
        Me.saveMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        ' 
        ' mainMenu1
        ' 
        Me.mainMenu1.MenuItems.AddRange(New MenuItem() { Me.menuItem1, Me.aboutMenuItem})
        ' 
        ' menuItem1
        ' 
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New MenuItem() { Me.menuItemConnect})
        Me.menuItem1.Text = "Connect"
        ' 
        ' aboutMenuItem
        ' 
        Me.aboutMenuItem.Index = 1
        Me.aboutMenuItem.Text = "About..."
'			Me.aboutMenuItem.Click += New System.EventHandler(Me.aboutMenuItem_Click)
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = DockStyle.Fill
        Me.splitContainer1.Location = New Point(0, 149)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder1)
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.Controls.Add(Me.textBox1)
        Me.splitContainer1.Size = New Size(764, 455)
        Me.splitContainer1.SplitterDistance = 346
        Me.splitContainer1.TabIndex = 1
        ' 
        ' queryBuilder1
        ' 
        Me.queryBuilder1.AddObjectDialogOptions.Location = New Point(0, 0)
        Me.queryBuilder1.AddObjectDialogOptions.Size = New Size(430, 430)
        Me.queryBuilder1.AddObjectDialogOptions.StartPosition = FormStartPosition.CenterScreen
        Me.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = False
        Me.queryBuilder1.DatabaseSchemaViewOptions.ImageList = Me.imageList16
        Me.queryBuilder1.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = Color.Black
        Me.queryBuilder1.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = (CType(resources.GetObject("resource.PrimaryKeyIcon"), Image))
        Me.queryBuilder1.DesignPaneOptions.Background = SystemColors.Window
        linkPainterAccess1.LinkColor = Color.Black
        linkPainterAccess1.LinkColorFocused = Color.Black
        linkPainterAccess1.MarkColor = SystemColors.Control
        linkPainterAccess1.MarkColorFocused = SystemColors.ControlDark
        linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder1.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1
        Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder1.Dock = DockStyle.Fill
        Me.queryBuilder1.Font = New Font("Segoe UI", 8.25F)
        Me.queryBuilder1.Location = New Point(0, 0)
        Me.queryBuilder1.Name = "queryBuilder1"
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
        Me.queryBuilder1.QueryNavBarOptions.ActionButtonBackColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.ActionButtonBorderColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.ActiveSubQueryItemBackColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.ActiveSubQueryItemBorderColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.AddCteCircleColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.AddUnionSubQueryCircleColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.BreadcrumbsBackgroundColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.CTEButtonBaseColor = Color.Green
        Me.queryBuilder1.QueryNavBarOptions.DisableQueryNavigationBarPopup = False
        Me.queryBuilder1.QueryNavBarOptions.DragIndicatorColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.DragIndicatorHoverColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder1.QueryNavBarOptions.ForeColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.GraphLineColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.GroupBackColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.GroupTextColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.OverflowButtonBaseColor = Color.DarkRed
        Me.queryBuilder1.QueryNavBarOptions.RootQueryButtonBaseColor = Color.Black
        Me.queryBuilder1.QueryNavBarOptions.SubQueryButtonBaseColor = Color.Blue
        Me.queryBuilder1.QueryNavBarOptions.SubQueryItemBackColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.SubQueryItemBorderColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.SubQueryMarkerColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.SubQueryPopupBackColor = Color.Empty
        Me.queryBuilder1.QueryNavBarOptions.TextHoverColor = Color.Empty
        Me.queryBuilder1.Size = New Size(764, 346)
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
        Me.queryBuilder1.SyntaxProvider = Me.genericSyntaxProvider1
        Me.queryBuilder1.TabIndex = 0
        Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(157))))))
        Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionFontColor = Color.Black
        Me.queryBuilder1.VisualOptions.DockPanelBackColor = Color.Empty
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
'			Me.queryBuilder1.SQLUpdated += New System.EventHandler(Me.queryBuilder1_SQLUpdated)
        ' 
        ' genericSyntaxProvider1
        ' 
        Me.genericSyntaxProvider1.DetectServerVersion = False
        Me.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
        Me.genericSyntaxProvider1.OnCalcExpressionType = Nothing
        ' 
        ' textBox1
        ' 
        Me.textBox1.Dock = DockStyle.Fill
        Me.textBox1.HideSelection = False
        Me.textBox1.Location = New Point(0, 0)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = ScrollBars.Both
        Me.textBox1.Size = New Size(764, 105)
        Me.textBox1.TabIndex = 0
'			Me.textBox1.Validating += New System.ComponentModel.CancelEventHandler(Me.textBox1_Validating)
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Controls.Add(Me.tabPageDirect)
        Me.tabControl1.Controls.Add(Me.tabPageOnDemand)
        Me.tabControl1.Controls.Add(Me.tabPageExecSql)
        Me.tabControl1.Controls.Add(Me.tabPageDataset)
        Me.tabControl1.Dock = DockStyle.Top
        Me.tabControl1.Location = New Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New Size(764, 149)
        Me.tabControl1.TabIndex = 0
        ' 
        ' tabPageDirect
        ' 
        Me.tabPageDirect.Controls.Add(Me.btnFourthWay)
        Me.tabPageDirect.Controls.Add(Me.textBox5)
        Me.tabPageDirect.Location = New Point(4, 22)
        Me.tabPageDirect.Name = "tabPageDirect"
        Me.tabPageDirect.Padding = New Padding(3)
        Me.tabPageDirect.Size = New Size(756, 123)
        Me.tabPageDirect.TabIndex = 3
        Me.tabPageDirect.Text = "Direct filling of MetadataContainer"
        Me.tabPageDirect.UseVisualStyleBackColor = True
        ' 
        ' btnFourthWay
        ' 
        Me.btnFourthWay.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.btnFourthWay.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.btnFourthWay.Location = New Point(613, 94)
        Me.btnFourthWay.Name = "btnFourthWay"
        Me.btnFourthWay.Size = New Size(137, 23)
        Me.btnFourthWay.TabIndex = 6
        Me.btnFourthWay.Text = "Load Metadata"
        Me.btnFourthWay.UseVisualStyleBackColor = True
'			Me.btnFourthWay.Click += New System.EventHandler(Me.btn1Way_Click)
        ' 
        ' textBox5
        ' 
        Me.textBox5.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textBox5.Location = New Point(6, 6)
        Me.textBox5.Multiline = True
        Me.textBox5.Name = "textBox5"
        Me.textBox5.ReadOnly = True
        Me.textBox5.ScrollBars = ScrollBars.Both
        Me.textBox5.Size = New Size(742, 82)
        Me.textBox5.TabIndex = 5
        Me.textBox5.Text = "This method demonstrates the direct access to the internal matadata objects colle" & "ction (MetadataContainer)."
        ' 
        ' tabPageOnDemand
        ' 
        Me.tabPageOnDemand.Controls.Add(Me.btnThirdWay)
        Me.tabPageOnDemand.Controls.Add(Me.textBox3)
        Me.tabPageOnDemand.Location = New Point(4, 22)
        Me.tabPageOnDemand.Name = "tabPageOnDemand"
        Me.tabPageOnDemand.Padding = New Padding(3)
        Me.tabPageOnDemand.Size = New Size(756, 123)
        Me.tabPageOnDemand.TabIndex = 1
        Me.tabPageOnDemand.Text = "On-demand filling using ItemMetadataLoading event"
        Me.tabPageOnDemand.UseVisualStyleBackColor = True
        ' 
        ' btnThirdWay
        ' 
        Me.btnThirdWay.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.btnThirdWay.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.btnThirdWay.Location = New Point(611, 94)
        Me.btnThirdWay.Name = "btnThirdWay"
        Me.btnThirdWay.Size = New Size(137, 23)
        Me.btnThirdWay.TabIndex = 3
        Me.btnThirdWay.Text = "Load Metadata"
        Me.btnThirdWay.UseVisualStyleBackColor = True
'			Me.btnThirdWay.Click += New System.EventHandler(Me.btn2Way_Click)
        ' 
        ' textBox3
        ' 
        Me.textBox3.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textBox3.Location = New Point(6, 6)
        Me.textBox3.Multiline = True
        Me.textBox3.Name = "textBox3"
        Me.textBox3.ReadOnly = True
        Me.textBox3.ScrollBars = ScrollBars.Both
        Me.textBox3.Size = New Size(742, 82)
        Me.textBox3.TabIndex = 2
        Me.textBox3.Text = "This method demonstrates manual filling of metadata structure using MetadataConta" & "iner.ItemMetadataLoading event."
        ' 
        ' tabPageExecSql
        ' 
        Me.tabPageExecSql.Controls.Add(Me.btnFirstWay)
        Me.tabPageExecSql.Controls.Add(Me.label1)
        Me.tabPageExecSql.Controls.Add(Me.textBox2)
        Me.tabPageExecSql.Location = New Point(4, 22)
        Me.tabPageExecSql.Name = "tabPageExecSql"
        Me.tabPageExecSql.Padding = New Padding(3)
        Me.tabPageExecSql.Size = New Size(756, 123)
        Me.tabPageExecSql.TabIndex = 0
        Me.tabPageExecSql.Text = "Using the ExecSQL event"
        Me.tabPageExecSql.UseVisualStyleBackColor = True
        ' 
        ' btnFirstWay
        ' 
        Me.btnFirstWay.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.btnFirstWay.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.btnFirstWay.Location = New Point(611, 94)
        Me.btnFirstWay.Name = "btnFirstWay"
        Me.btnFirstWay.Size = New Size(137, 23)
        Me.btnFirstWay.TabIndex = 1
        Me.btnFirstWay.Text = "Load Metadata"
        Me.btnFirstWay.UseVisualStyleBackColor = True
'			Me.btnFirstWay.Click += New System.EventHandler(Me.btn3Way_Click)
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.ForeColor = Color.OrangeRed
        Me.label1.Location = New Point(3, 99)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(497, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Please setup a database connection by clicking on the ""Connect"" menu item before " & "testing this method."
        ' 
        ' textBox2
        ' 
        Me.textBox2.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textBox2.Location = New Point(6, 6)
        Me.textBox2.Multiline = True
        Me.textBox2.Name = "textBox2"
        Me.textBox2.ReadOnly = True
        Me.textBox2.ScrollBars = ScrollBars.Both
        Me.textBox2.Size = New Size(742, 82)
        Me.textBox2.TabIndex = 0
        Me.textBox2.Text = resources.GetString("textBox2.Text")
        ' 
        ' tabPageDataset
        ' 
        Me.tabPageDataset.Controls.Add(Me.btnFifthWay)
        Me.tabPageDataset.Controls.Add(Me.textBox6)
        Me.tabPageDataset.Location = New Point(4, 22)
        Me.tabPageDataset.Name = "tabPageDataset"
        Me.tabPageDataset.Padding = New Padding(3)
        Me.tabPageDataset.Size = New Size(756, 123)
        Me.tabPageDataset.TabIndex = 4
        Me.tabPageDataset.Text = "Fill from DataSet"
        Me.tabPageDataset.UseVisualStyleBackColor = True
        ' 
        ' btnFifthWay
        ' 
        Me.btnFifthWay.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.btnFifthWay.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.btnFifthWay.Location = New Point(613, 94)
        Me.btnFifthWay.Name = "btnFifthWay"
        Me.btnFifthWay.Size = New Size(137, 23)
        Me.btnFifthWay.TabIndex = 8
        Me.btnFifthWay.Text = "Load Metadata"
        Me.btnFifthWay.UseVisualStyleBackColor = True
'			Me.btnFifthWay.Click += New System.EventHandler(Me.btn4Way_Click)
        ' 
        ' textBox6
        ' 
        Me.textBox6.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textBox6.Location = New Point(6, 6)
        Me.textBox6.Multiline = True
        Me.textBox6.Name = "textBox6"
        Me.textBox6.ReadOnly = True
        Me.textBox6.ScrollBars = ScrollBars.Both
        Me.textBox6.Size = New Size(742, 82)
        Me.textBox6.TabIndex = 7
        Me.textBox6.Text = "This method demonstrates manual filling of metadata structure from stored DataSet" & "."
        ' 
        ' menuItemConnect
        ' 
        Me.menuItemConnect.Index = 0
        Me.menuItemConnect.Text = "Connect to..."
'			Me.menuItemConnect.Click += New System.EventHandler(Me.menuItemConnect_Click)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(764, 604)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.tabControl1)
        Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        CType(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl1.ResumeLayout(False)
        Me.tabPageDirect.ResumeLayout(False)
        Me.tabPageDirect.PerformLayout()
        Me.tabPageOnDemand.ResumeLayout(False)
        Me.tabPageOnDemand.PerformLayout()
        Me.tabPageExecSql.ResumeLayout(False)
        Me.tabPageExecSql.PerformLayout()
        Me.tabPageDataset.ResumeLayout(False)
        Me.tabPageDataset.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private openMetadataFileDialog As OpenFileDialog
    Private saveMetadataFileDialog As SaveFileDialog
    Private imageList16 As ImageList

    Private way3EventMetadataProvider As ActiveQueryBuilder.Core.EventMetadataProvider
    Private mainMenu1 As MainMenu
    Private menuItem1 As MenuItem
    Private WithEvents aboutMenuItem As MenuItem
    Private splitContainer1 As SplitContainer
    Private WithEvents queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private WithEvents textBox1 As TextBox
    Private tabControl1 As TabControl
    Private tabPageExecSql As TabPage
    Private tabPageOnDemand As TabPage
    Private WithEvents btnFirstWay As Button
    Private label1 As Label
    Private textBox2 As TextBox
    Private WithEvents btnThirdWay As Button
    Private textBox3 As TextBox
    Private tabPageDirect As TabPage
    Private WithEvents btnFourthWay As Button
    Private textBox5 As TextBox
    Private genericSyntaxProvider1 As ActiveQueryBuilder.Core.GenericSyntaxProvider
    Private tabPageDataset As TabPage
    Private WithEvents btnFifthWay As Button
    Private textBox6 As TextBox
    Private WithEvents menuItemConnect As MenuItem
End Class