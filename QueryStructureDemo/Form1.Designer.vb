
Partial Public Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Global.Form1))
        Me.imageList16 = New ImageList(Me.components)
        Me.imageList32 = New ImageList(Me.components)
        Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.splitContainer1 = New SplitContainer()
        Me.pnlSampleQueries = New Panel()
        Me.btnSampleUnions = New Button()
        Me.btnSampleSelectFromJoinSubqueries = New Button()
        Me.btnSampleSelectFromJoin = New Button()
        Me.btnSampleSelectFromWhere = New Button()
        Me.lblSampleQueries = New Label()
        Me.btnSampleSelect = New Button()
        Me.pageMisc = New TabControl()
        Me.pageSQL = New TabPage()
        Me.tbSQL = New TextBox()
        Me.pageStatistics = New TabPage()
        Me.tbStatistics = New TextBox()
        Me.pageSubQueries = New TabPage()
        Me.tbSubQueries = New TextBox()
        Me.pageSubQueryStructure = New TabPage()
        Me.tbSubQueryStructure = New TextBox()
        Me.pageUnionSubQuery = New TabPage()
        Me.tabctrlSubQueryStructureTabsheet = New TabControl()
        Me.pageSelectedExpressions = New TabPage()
        Me.tbSelectedExpressions = New TextBox()
        Me.pageDataSources = New TabPage()
        Me.tbDataSources = New TextBox()
        Me.pageLinks = New TabPage()
        Me.tbLinks = New TextBox()
        Me.pageWhere = New TabPage()
        Me.tbWhere = New TextBox()
        Me.tabPage6 = New TabPage()
        Me.lblShowUnlinkedDatasourcesLegend = New Label()
        Me.btnShowUnlinkedDatasourcesButton = New Button()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.pnlSampleQueries.SuspendLayout()
        Me.pageMisc.SuspendLayout()
        Me.pageSQL.SuspendLayout()
        Me.pageStatistics.SuspendLayout()
        Me.pageSubQueries.SuspendLayout()
        Me.pageSubQueryStructure.SuspendLayout()
        Me.pageUnionSubQuery.SuspendLayout()
        Me.tabctrlSubQueryStructureTabsheet.SuspendLayout()
        Me.pageSelectedExpressions.SuspendLayout()
        Me.pageDataSources.SuspendLayout()
        Me.pageLinks.SuspendLayout()
        Me.pageWhere.SuspendLayout()
        Me.tabPage6.SuspendLayout()
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
        Me.queryBuilder.BorderStyle = BorderStyle.FixedSingle
        Me.queryBuilder.DataSourceOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = (CType(resources.GetObject("resource.PrimaryKeyIcon"), Bitmap))
        Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder.Dock = DockStyle.Fill
        Me.queryBuilder.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.World)
        Me.queryBuilder.Location = New Point(0, 46)
        Me.queryBuilder.Name = "queryBuilder"
        Me.queryBuilder.QueryColumnListOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder.Size = New Size(924, 381)
        ' 
        ' 
        ' 
        Me.queryBuilder.SQLFormattingOptions.ExpandVirtualFields = False
        Me.queryBuilder.SQLFormattingOptions.ExpandVirtualObjects = False
        ' 
        ' 
        ' 
        Me.queryBuilder.SQLGenerationOptions.ExpandVirtualFields = True
        Me.queryBuilder.SQLGenerationOptions.ExpandVirtualObjects = True
        Me.queryBuilder.TabIndex = 0
'			Me.queryBuilder.ActiveUnionSubQueryChanged += New System.EventHandler(Me.queryBuilder_ActiveUnionSubQueryChanged)
'			Me.queryBuilder.SQLUpdated += New System.EventHandler(Me.queryBuilder_SQLUpdated)
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = DockStyle.Fill
        Me.splitContainer1.Location = New Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
        Me.splitContainer1.Panel1.Controls.Add(Me.pnlSampleQueries)
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.Controls.Add(Me.pageMisc)
        Me.splitContainer1.Size = New Size(924, 604)
        Me.splitContainer1.SplitterDistance = 427
        Me.splitContainer1.TabIndex = 2
        ' 
        ' pnlSampleQueries
        ' 
        Me.pnlSampleQueries.Controls.Add(Me.btnSampleUnions)
        Me.pnlSampleQueries.Controls.Add(Me.btnSampleSelectFromJoinSubqueries)
        Me.pnlSampleQueries.Controls.Add(Me.btnSampleSelectFromJoin)
        Me.pnlSampleQueries.Controls.Add(Me.btnSampleSelectFromWhere)
        Me.pnlSampleQueries.Controls.Add(Me.lblSampleQueries)
        Me.pnlSampleQueries.Controls.Add(Me.btnSampleSelect)
        Me.pnlSampleQueries.Dock = DockStyle.Top
        Me.pnlSampleQueries.Location = New Point(0, 0)
        Me.pnlSampleQueries.Name = "pnlSampleQueries"
        Me.pnlSampleQueries.Size = New Size(924, 46)
        Me.pnlSampleQueries.TabIndex = 1
        ' 
        ' btnSampleUnions
        ' 
        Me.btnSampleUnions.Location = New Point(675, 12)
        Me.btnSampleUnions.Name = "btnSampleUnions"
        Me.btnSampleUnions.Size = New Size(106, 23)
        Me.btnSampleUnions.TabIndex = 5
        Me.btnSampleUnions.Text = "Multiple UNIONs"
        Me.btnSampleUnions.UseVisualStyleBackColor = True
'			Me.btnSampleUnions.Click += New System.EventHandler(Me.btnSampleUnions_Click)
        ' 
        ' btnSampleSelectFromJoinSubqueries
        ' 
        Me.btnSampleSelectFromJoinSubqueries.Location = New Point(490, 12)
        Me.btnSampleSelectFromJoinSubqueries.Name = "btnSampleSelectFromJoinSubqueries"
        Me.btnSampleSelectFromJoinSubqueries.Size = New Size(179, 23)
        Me.btnSampleSelectFromJoinSubqueries.TabIndex = 4
        Me.btnSampleSelectFromJoinSubqueries.Text = "SELECT FROM with subqueries"
        Me.btnSampleSelectFromJoinSubqueries.UseVisualStyleBackColor = True
'			Me.btnSampleSelectFromJoinSubqueries.Click += New System.EventHandler(Me.btnSampleSelectFromJoinSubqueries_Click)
        ' 
        ' btnSampleSelectFromJoin
        ' 
        Me.btnSampleSelectFromJoin.Location = New Point(361, 12)
        Me.btnSampleSelectFromJoin.Name = "btnSampleSelectFromJoin"
        Me.btnSampleSelectFromJoin.Size = New Size(123, 23)
        Me.btnSampleSelectFromJoin.TabIndex = 3
        Me.btnSampleSelectFromJoin.Text = "SELECT FROM JOIN"
        Me.btnSampleSelectFromJoin.UseVisualStyleBackColor = True
'			Me.btnSampleSelectFromJoin.Click += New System.EventHandler(Me.btnSampleSelectFromJoin_Click)
        ' 
        ' btnSampleSelectFromWhere
        ' 
        Me.btnSampleSelectFromWhere.Location = New Point(206, 12)
        Me.btnSampleSelectFromWhere.Name = "btnSampleSelectFromWhere"
        Me.btnSampleSelectFromWhere.Size = New Size(149, 23)
        Me.btnSampleSelectFromWhere.TabIndex = 2
        Me.btnSampleSelectFromWhere.Text = "SELECT FROM WHERE"
        Me.btnSampleSelectFromWhere.UseVisualStyleBackColor = True
'			Me.btnSampleSelectFromWhere.Click += New System.EventHandler(Me.btnSampleSelectFromWhere_Click)
        ' 
        ' lblSampleQueries
        ' 
        Me.lblSampleQueries.AutoSize = True
        Me.lblSampleQueries.Location = New Point(12, 17)
        Me.lblSampleQueries.Name = "lblSampleQueries"
        Me.lblSampleQueries.Size = New Size(107, 13)
        Me.lblSampleQueries.TabIndex = 1
        Me.lblSampleQueries.Text = "Load sample queries:"
        ' 
        ' btnSampleSelect
        ' 
        Me.btnSampleSelect.Location = New Point(125, 12)
        Me.btnSampleSelect.Name = "btnSampleSelect"
        Me.btnSampleSelect.Size = New Size(75, 23)
        Me.btnSampleSelect.TabIndex = 0
        Me.btnSampleSelect.Text = "SELECT"
        Me.btnSampleSelect.UseVisualStyleBackColor = True
'			Me.btnSampleSelect.Click += New System.EventHandler(Me.btnSampleSelect_Click)
        ' 
        ' pageMisc
        ' 
        Me.pageMisc.Controls.Add(Me.pageSQL)
        Me.pageMisc.Controls.Add(Me.pageStatistics)
        Me.pageMisc.Controls.Add(Me.pageSubQueries)
        Me.pageMisc.Controls.Add(Me.pageSubQueryStructure)
        Me.pageMisc.Controls.Add(Me.pageUnionSubQuery)
        Me.pageMisc.Controls.Add(Me.tabPage6)
        Me.pageMisc.Dock = DockStyle.Fill
        Me.pageMisc.Location = New Point(0, 0)
        Me.pageMisc.Name = "pageMisc"
        Me.pageMisc.SelectedIndex = 0
        Me.pageMisc.Size = New Size(924, 173)
        Me.pageMisc.TabIndex = 0
        ' 
        ' pageSQL
        ' 
        Me.pageSQL.Controls.Add(Me.tbSQL)
        Me.pageSQL.Location = New Point(4, 22)
        Me.pageSQL.Name = "pageSQL"
        Me.pageSQL.Padding = New Padding(3)
        Me.pageSQL.Size = New Size(916, 147)
        Me.pageSQL.TabIndex = 0
        Me.pageSQL.Text = "SQL"
        Me.pageSQL.UseVisualStyleBackColor = True
        ' 
        ' tbSQL
        ' 
        Me.tbSQL.Dock = DockStyle.Fill
        Me.tbSQL.HideSelection = False
        Me.tbSQL.Location = New Point(3, 3)
        Me.tbSQL.Multiline = True
        Me.tbSQL.Name = "tbSQL"
        Me.tbSQL.ScrollBars = ScrollBars.Both
        Me.tbSQL.Size = New Size(910, 141)
        Me.tbSQL.TabIndex = 1
'			Me.tbSQL.Validating += New System.ComponentModel.CancelEventHandler(Me.tbSQL_Validating)
        ' 
        ' pageStatistics
        ' 
        Me.pageStatistics.Controls.Add(Me.tbStatistics)
        Me.pageStatistics.Location = New Point(4, 22)
        Me.pageStatistics.Name = "pageStatistics"
        Me.pageStatistics.Padding = New Padding(3)
        Me.pageStatistics.Size = New Size(916, 147)
        Me.pageStatistics.TabIndex = 1
        Me.pageStatistics.Text = "Statistics"
        Me.pageStatistics.UseVisualStyleBackColor = True
        ' 
        ' tbStatistics
        ' 
        Me.tbStatistics.Dock = DockStyle.Fill
        Me.tbStatistics.HideSelection = False
        Me.tbStatistics.Location = New Point(3, 3)
        Me.tbStatistics.Multiline = True
        Me.tbStatistics.Name = "tbStatistics"
        Me.tbStatistics.ScrollBars = ScrollBars.Both
        Me.tbStatistics.Size = New Size(910, 141)
        Me.tbStatistics.TabIndex = 2
        ' 
        ' pageSubQueries
        ' 
        Me.pageSubQueries.Controls.Add(Me.tbSubQueries)
        Me.pageSubQueries.Location = New Point(4, 22)
        Me.pageSubQueries.Name = "pageSubQueries"
        Me.pageSubQueries.Padding = New Padding(3)
        Me.pageSubQueries.Size = New Size(916, 147)
        Me.pageSubQueries.TabIndex = 2
        Me.pageSubQueries.Text = "SubQueries"
        Me.pageSubQueries.UseVisualStyleBackColor = True
        ' 
        ' tbSubQueries
        ' 
        Me.tbSubQueries.Dock = DockStyle.Fill
        Me.tbSubQueries.HideSelection = False
        Me.tbSubQueries.Location = New Point(3, 3)
        Me.tbSubQueries.Multiline = True
        Me.tbSubQueries.Name = "tbSubQueries"
        Me.tbSubQueries.ScrollBars = ScrollBars.Both
        Me.tbSubQueries.Size = New Size(910, 141)
        Me.tbSubQueries.TabIndex = 2
        ' 
        ' pageSubQueryStructure
        ' 
        Me.pageSubQueryStructure.Controls.Add(Me.tbSubQueryStructure)
        Me.pageSubQueryStructure.Location = New Point(4, 22)
        Me.pageSubQueryStructure.Name = "pageSubQueryStructure"
        Me.pageSubQueryStructure.Padding = New Padding(3)
        Me.pageSubQueryStructure.Size = New Size(916, 147)
        Me.pageSubQueryStructure.TabIndex = 3
        Me.pageSubQueryStructure.Text = "SubQuery structure"
        Me.pageSubQueryStructure.UseVisualStyleBackColor = True
        ' 
        ' tbSubQueryStructure
        ' 
        Me.tbSubQueryStructure.Dock = DockStyle.Fill
        Me.tbSubQueryStructure.HideSelection = False
        Me.tbSubQueryStructure.Location = New Point(3, 3)
        Me.tbSubQueryStructure.Multiline = True
        Me.tbSubQueryStructure.Name = "tbSubQueryStructure"
        Me.tbSubQueryStructure.ScrollBars = ScrollBars.Both
        Me.tbSubQueryStructure.Size = New Size(910, 141)
        Me.tbSubQueryStructure.TabIndex = 2
        ' 
        ' pageUnionSubQuery
        ' 
        Me.pageUnionSubQuery.Controls.Add(Me.tabctrlSubQueryStructureTabsheet)
        Me.pageUnionSubQuery.Location = New Point(4, 22)
        Me.pageUnionSubQuery.Name = "pageUnionSubQuery"
        Me.pageUnionSubQuery.Padding = New Padding(3)
        Me.pageUnionSubQuery.Size = New Size(916, 147)
        Me.pageUnionSubQuery.TabIndex = 4
        Me.pageUnionSubQuery.Text = "UnionSubQuery"
        Me.pageUnionSubQuery.UseVisualStyleBackColor = True
        ' 
        ' tabctrlSubQueryStructureTabsheet
        ' 
        Me.tabctrlSubQueryStructureTabsheet.Controls.Add(Me.pageSelectedExpressions)
        Me.tabctrlSubQueryStructureTabsheet.Controls.Add(Me.pageDataSources)
        Me.tabctrlSubQueryStructureTabsheet.Controls.Add(Me.pageLinks)
        Me.tabctrlSubQueryStructureTabsheet.Controls.Add(Me.pageWhere)
        Me.tabctrlSubQueryStructureTabsheet.Dock = DockStyle.Fill
        Me.tabctrlSubQueryStructureTabsheet.Location = New Point(3, 3)
        Me.tabctrlSubQueryStructureTabsheet.Name = "tabctrlSubQueryStructureTabsheet"
        Me.tabctrlSubQueryStructureTabsheet.SelectedIndex = 0
        Me.tabctrlSubQueryStructureTabsheet.Size = New Size(910, 141)
        Me.tabctrlSubQueryStructureTabsheet.TabIndex = 0
        ' 
        ' pageSelectedExpressions
        ' 
        Me.pageSelectedExpressions.Controls.Add(Me.tbSelectedExpressions)
        Me.pageSelectedExpressions.Location = New Point(4, 22)
        Me.pageSelectedExpressions.Name = "pageSelectedExpressions"
        Me.pageSelectedExpressions.Padding = New Padding(3)
        Me.pageSelectedExpressions.Size = New Size(902, 115)
        Me.pageSelectedExpressions.TabIndex = 0
        Me.pageSelectedExpressions.Text = "Selected Expressions"
        Me.pageSelectedExpressions.UseVisualStyleBackColor = True
        ' 
        ' tbSelectedExpressions
        ' 
        Me.tbSelectedExpressions.Dock = DockStyle.Fill
        Me.tbSelectedExpressions.HideSelection = False
        Me.tbSelectedExpressions.Location = New Point(3, 3)
        Me.tbSelectedExpressions.Multiline = True
        Me.tbSelectedExpressions.Name = "tbSelectedExpressions"
        Me.tbSelectedExpressions.ScrollBars = ScrollBars.Both
        Me.tbSelectedExpressions.Size = New Size(896, 109)
        Me.tbSelectedExpressions.TabIndex = 2
        ' 
        ' pageDataSources
        ' 
        Me.pageDataSources.Controls.Add(Me.tbDataSources)
        Me.pageDataSources.Location = New Point(4, 22)
        Me.pageDataSources.Name = "pageDataSources"
        Me.pageDataSources.Padding = New Padding(3)
        Me.pageDataSources.Size = New Size(902, 115)
        Me.pageDataSources.TabIndex = 1
        Me.pageDataSources.Text = "DataSources"
        Me.pageDataSources.UseVisualStyleBackColor = True
        ' 
        ' tbDataSources
        ' 
        Me.tbDataSources.Dock = DockStyle.Fill
        Me.tbDataSources.HideSelection = False
        Me.tbDataSources.Location = New Point(3, 3)
        Me.tbDataSources.Multiline = True
        Me.tbDataSources.Name = "tbDataSources"
        Me.tbDataSources.ScrollBars = ScrollBars.Both
        Me.tbDataSources.Size = New Size(896, 109)
        Me.tbDataSources.TabIndex = 2
        ' 
        ' pageLinks
        ' 
        Me.pageLinks.Controls.Add(Me.tbLinks)
        Me.pageLinks.Location = New Point(4, 22)
        Me.pageLinks.Name = "pageLinks"
        Me.pageLinks.Padding = New Padding(3)
        Me.pageLinks.Size = New Size(902, 115)
        Me.pageLinks.TabIndex = 2
        Me.pageLinks.Text = "Links"
        Me.pageLinks.UseVisualStyleBackColor = True
        ' 
        ' tbLinks
        ' 
        Me.tbLinks.Dock = DockStyle.Fill
        Me.tbLinks.HideSelection = False
        Me.tbLinks.Location = New Point(3, 3)
        Me.tbLinks.Multiline = True
        Me.tbLinks.Name = "tbLinks"
        Me.tbLinks.ScrollBars = ScrollBars.Both
        Me.tbLinks.Size = New Size(896, 109)
        Me.tbLinks.TabIndex = 2
        ' 
        ' pageWhere
        ' 
        Me.pageWhere.Controls.Add(Me.tbWhere)
        Me.pageWhere.Location = New Point(4, 22)
        Me.pageWhere.Name = "pageWhere"
        Me.pageWhere.Padding = New Padding(3)
        Me.pageWhere.Size = New Size(902, 115)
        Me.pageWhere.TabIndex = 3
        Me.pageWhere.Text = "Where"
        Me.pageWhere.UseVisualStyleBackColor = True
        ' 
        ' tbWhere
        ' 
        Me.tbWhere.Dock = DockStyle.Fill
        Me.tbWhere.HideSelection = False
        Me.tbWhere.Location = New Point(3, 3)
        Me.tbWhere.Multiline = True
        Me.tbWhere.Name = "tbWhere"
        Me.tbWhere.ScrollBars = ScrollBars.Both
        Me.tbWhere.Size = New Size(896, 109)
        Me.tbWhere.TabIndex = 2
        ' 
        ' tabPage6
        ' 
        Me.tabPage6.Controls.Add(Me.lblShowUnlinkedDatasourcesLegend)
        Me.tabPage6.Controls.Add(Me.btnShowUnlinkedDatasourcesButton)
        Me.tabPage6.Location = New Point(4, 22)
        Me.tabPage6.Name = "tabPage6"
        Me.tabPage6.Padding = New Padding(3)
        Me.tabPage6.Size = New Size(916, 147)
        Me.tabPage6.TabIndex = 5
        Me.tabPage6.Text = "Misc"
        Me.tabPage6.UseVisualStyleBackColor = True
        ' 
        ' lblShowUnlinkedDatasourcesLegend
        ' 
        Me.lblShowUnlinkedDatasourcesLegend.AutoSize = True
        Me.lblShowUnlinkedDatasourcesLegend.Location = New Point(218, 15)
        Me.lblShowUnlinkedDatasourcesLegend.Name = "lblShowUnlinkedDatasourcesLegend"
        Me.lblShowUnlinkedDatasourcesLegend.Size = New Size(355, 13)
        Me.lblShowUnlinkedDatasourcesLegend.TabIndex = 1
        Me.lblShowUnlinkedDatasourcesLegend.Text = "List DataSources not reachable by links from first DataSource of the query"
        ' 
        ' btnShowUnlinkedDatasourcesButton
        ' 
        Me.btnShowUnlinkedDatasourcesButton.Location = New Point(8, 10)
        Me.btnShowUnlinkedDatasourcesButton.Name = "btnShowUnlinkedDatasourcesButton"
        Me.btnShowUnlinkedDatasourcesButton.Size = New Size(204, 23)
        Me.btnShowUnlinkedDatasourcesButton.TabIndex = 0
        Me.btnShowUnlinkedDatasourcesButton.Text = "List unlinked DataSources"
        Me.btnShowUnlinkedDatasourcesButton.UseVisualStyleBackColor = True
'			Me.btnShowUnlinkedDatasourcesButton.Click += New System.EventHandler(Me.btnShowUnlinkedDatasourcesButton_Click)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(924, 604)
        Me.Controls.Add(Me.splitContainer1)
        Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Query Structure Demo"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        Me.pnlSampleQueries.ResumeLayout(False)
        Me.pnlSampleQueries.PerformLayout()
        Me.pageMisc.ResumeLayout(False)
        Me.pageSQL.ResumeLayout(False)
        Me.pageSQL.PerformLayout()
        Me.pageStatistics.ResumeLayout(False)
        Me.pageStatistics.PerformLayout()
        Me.pageSubQueries.ResumeLayout(False)
        Me.pageSubQueries.PerformLayout()
        Me.pageSubQueryStructure.ResumeLayout(False)
        Me.pageSubQueryStructure.PerformLayout()
        Me.pageUnionSubQuery.ResumeLayout(False)
        Me.tabctrlSubQueryStructureTabsheet.ResumeLayout(False)
        Me.pageSelectedExpressions.ResumeLayout(False)
        Me.pageSelectedExpressions.PerformLayout()
        Me.pageDataSources.ResumeLayout(False)
        Me.pageDataSources.PerformLayout()
        Me.pageLinks.ResumeLayout(False)
        Me.pageLinks.PerformLayout()
        Me.pageWhere.ResumeLayout(False)
        Me.pageWhere.PerformLayout()
        Me.tabPage6.ResumeLayout(False)
        Me.tabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private imageList16 As ImageList
    Private imageList32 As ImageList
    Private splitContainer1 As SplitContainer
    Private WithEvents queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private pageMisc As TabControl
    Private pageSQL As TabPage
    Private WithEvents tbSQL As TextBox
    Private pageStatistics As TabPage
    Private tbStatistics As TextBox
    Private pnlSampleQueries As Panel
    Private WithEvents btnSampleSelectFromWhere As Button
    Private lblSampleQueries As Label
    Private WithEvents btnSampleSelect As Button
    Private WithEvents btnSampleSelectFromJoinSubqueries As Button
    Private WithEvents btnSampleSelectFromJoin As Button
    Private WithEvents btnSampleUnions As Button
    Private pageSubQueries As TabPage
    Private pageSubQueryStructure As TabPage
    Private pageUnionSubQuery As TabPage
    Private tabPage6 As TabPage
    Private tbSubQueries As TextBox
    Private tbSubQueryStructure As TextBox
    Private tabctrlSubQueryStructureTabsheet As TabControl
    Private pageSelectedExpressions As TabPage
    Private pageDataSources As TabPage
    Private pageLinks As TabPage
    Private pageWhere As TabPage
    Private tbSelectedExpressions As TextBox
    Private tbDataSources As TextBox
    Private tbLinks As TextBox
    Private tbWhere As TextBox
    Private WithEvents btnShowUnlinkedDatasourcesButton As Button
    Private lblShowUnlinkedDatasourcesLegend As Label
End Class