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
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.imageList16 = New System.Windows.Forms.ImageList(Me.components)
		Me.imageList32 = New System.Windows.Forms.ImageList(Me.components)
		Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
		Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.pnlSampleQueries = New System.Windows.Forms.Panel()
		Me.btnSampleUnions = New System.Windows.Forms.Button()
		Me.btnSampleSelectFromJoinSubqueries = New System.Windows.Forms.Button()
		Me.btnSampleSelectFromJoin = New System.Windows.Forms.Button()
		Me.btnSampleSelectFromWhere = New System.Windows.Forms.Button()
		Me.lblSampleQueries = New System.Windows.Forms.Label()
		Me.btnSampleSelect = New System.Windows.Forms.Button()
		Me.pageMisc = New System.Windows.Forms.TabControl()
		Me.pageSQL = New System.Windows.Forms.TabPage()
		Me.tbSQL = New System.Windows.Forms.TextBox()
		Me.pageStatistics = New System.Windows.Forms.TabPage()
		Me.tbStatistics = New System.Windows.Forms.TextBox()
		Me.pageSubQueries = New System.Windows.Forms.TabPage()
		Me.tbSubQueries = New System.Windows.Forms.TextBox()
		Me.pageSubQueryStructure = New System.Windows.Forms.TabPage()
		Me.tbSubQueryStructure = New System.Windows.Forms.TextBox()
		Me.pageUnionSubQuery = New System.Windows.Forms.TabPage()
		Me.tabctrlSubQueryStructureTabsheet = New System.Windows.Forms.TabControl()
		Me.pageSelectedExpressions = New System.Windows.Forms.TabPage()
		Me.tbSelectedExpressions = New System.Windows.Forms.TextBox()
		Me.pageDataSources = New System.Windows.Forms.TabPage()
		Me.tbDataSources = New System.Windows.Forms.TextBox()
		Me.pageLinks = New System.Windows.Forms.TabPage()
		Me.tbLinks = New System.Windows.Forms.TextBox()
		Me.pageWhere = New System.Windows.Forms.TabPage()
		Me.tbWhere = New System.Windows.Forms.TextBox()
		Me.tabPage6 = New System.Windows.Forms.TabPage()
		Me.lblShowUnlinkedDatasourcesLegend = New System.Windows.Forms.Label()
		Me.btnShowUnlinkedDatasourcesButton = New System.Windows.Forms.Button()
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
		Me.imageList16.ImageStream = DirectCast(resources.GetObject("imageList16.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.imageList16.TransparentColor = System.Drawing.Color.Magenta
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
		Me.imageList32.ImageStream = DirectCast(resources.GetObject("imageList32.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.imageList32.TransparentColor = System.Drawing.Color.Magenta
		Me.imageList32.Images.SetKeyName(0, "0.bmp")
		Me.imageList32.Images.SetKeyName(1, "1.bmp")
		Me.imageList32.Images.SetKeyName(2, "2.bmp")
		' 
		' queryBuilder
		' 
		Me.queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.queryBuilder.DataSourceOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = DirectCast(resources.GetObject("resource.PrimaryKeyIcon"), System.Drawing.Bitmap)
		Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
		Me.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill
		Me.queryBuilder.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
		Me.queryBuilder.Location = New System.Drawing.Point(0, 46)
		Me.queryBuilder.Name = "queryBuilder"
		Me.queryBuilder.QueryColumnListOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.queryBuilder.Size = New System.Drawing.Size(924, 381)
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
        AddHandler Me.queryBuilder.ActiveUnionSubQueryChanged, New System.EventHandler(AddressOf Me.queryBuilder_ActiveUnionSubQueryChanged)
        AddHandler Me.queryBuilder.SQLUpdated, New System.EventHandler(AddressOf Me.queryBuilder_SQLUpdated)
		' 
		' splitContainer1
		' 
		Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.splitContainer1.Name = "splitContainer1"
		Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		' 
		' splitContainer1.Panel1
		' 
		Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
		Me.splitContainer1.Panel1.Controls.Add(Me.pnlSampleQueries)
		' 
		' splitContainer1.Panel2
		' 
		Me.splitContainer1.Panel2.Controls.Add(Me.pageMisc)
		Me.splitContainer1.Size = New System.Drawing.Size(924, 604)
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
		Me.pnlSampleQueries.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlSampleQueries.Location = New System.Drawing.Point(0, 0)
		Me.pnlSampleQueries.Name = "pnlSampleQueries"
		Me.pnlSampleQueries.Size = New System.Drawing.Size(924, 46)
		Me.pnlSampleQueries.TabIndex = 1
		' 
		' btnSampleUnions
		' 
		Me.btnSampleUnions.Location = New System.Drawing.Point(675, 12)
		Me.btnSampleUnions.Name = "btnSampleUnions"
		Me.btnSampleUnions.Size = New System.Drawing.Size(106, 23)
		Me.btnSampleUnions.TabIndex = 5
		Me.btnSampleUnions.Text = "Multiple UNIONs"
		Me.btnSampleUnions.UseVisualStyleBackColor = True
		AddHandler Me.btnSampleUnions.Click, New System.EventHandler(AddressOf Me.btnSampleUnions_Click)
		' 
		' btnSampleSelectFromJoinSubqueries
		' 
		Me.btnSampleSelectFromJoinSubqueries.Location = New System.Drawing.Point(490, 12)
		Me.btnSampleSelectFromJoinSubqueries.Name = "btnSampleSelectFromJoinSubqueries"
		Me.btnSampleSelectFromJoinSubqueries.Size = New System.Drawing.Size(179, 23)
		Me.btnSampleSelectFromJoinSubqueries.TabIndex = 4
		Me.btnSampleSelectFromJoinSubqueries.Text = "SELECT FROM with subqueries"
		Me.btnSampleSelectFromJoinSubqueries.UseVisualStyleBackColor = True
		AddHandler Me.btnSampleSelectFromJoinSubqueries.Click, New System.EventHandler(AddressOf Me.btnSampleSelectFromJoinSubqueries_Click)
		' 
		' btnSampleSelectFromJoin
		' 
		Me.btnSampleSelectFromJoin.Location = New System.Drawing.Point(361, 12)
		Me.btnSampleSelectFromJoin.Name = "btnSampleSelectFromJoin"
		Me.btnSampleSelectFromJoin.Size = New System.Drawing.Size(123, 23)
		Me.btnSampleSelectFromJoin.TabIndex = 3
		Me.btnSampleSelectFromJoin.Text = "SELECT FROM JOIN"
		Me.btnSampleSelectFromJoin.UseVisualStyleBackColor = True
		AddHandler Me.btnSampleSelectFromJoin.Click, New System.EventHandler(AddressOf Me.btnSampleSelectFromJoin_Click)
		' 
		' btnSampleSelectFromWhere
		' 
		Me.btnSampleSelectFromWhere.Location = New System.Drawing.Point(206, 12)
		Me.btnSampleSelectFromWhere.Name = "btnSampleSelectFromWhere"
		Me.btnSampleSelectFromWhere.Size = New System.Drawing.Size(149, 23)
		Me.btnSampleSelectFromWhere.TabIndex = 2
		Me.btnSampleSelectFromWhere.Text = "SELECT FROM WHERE"
		Me.btnSampleSelectFromWhere.UseVisualStyleBackColor = True
		AddHandler Me.btnSampleSelectFromWhere.Click, New System.EventHandler(AddressOf Me.btnSampleSelectFromWhere_Click)
		' 
		' lblSampleQueries
		' 
		Me.lblSampleQueries.AutoSize = True
		Me.lblSampleQueries.Location = New System.Drawing.Point(12, 17)
		Me.lblSampleQueries.Name = "lblSampleQueries"
		Me.lblSampleQueries.Size = New System.Drawing.Size(107, 13)
		Me.lblSampleQueries.TabIndex = 1
		Me.lblSampleQueries.Text = "Load sample queries:"
		' 
		' btnSampleSelect
		' 
		Me.btnSampleSelect.Location = New System.Drawing.Point(125, 12)
		Me.btnSampleSelect.Name = "btnSampleSelect"
		Me.btnSampleSelect.Size = New System.Drawing.Size(75, 23)
		Me.btnSampleSelect.TabIndex = 0
		Me.btnSampleSelect.Text = "SELECT"
		Me.btnSampleSelect.UseVisualStyleBackColor = True
		AddHandler Me.btnSampleSelect.Click, New System.EventHandler(AddressOf Me.btnSampleSelect_Click)
		' 
		' pageMisc
		' 
		Me.pageMisc.Controls.Add(Me.pageSQL)
		Me.pageMisc.Controls.Add(Me.pageStatistics)
		Me.pageMisc.Controls.Add(Me.pageSubQueries)
		Me.pageMisc.Controls.Add(Me.pageSubQueryStructure)
		Me.pageMisc.Controls.Add(Me.pageUnionSubQuery)
		Me.pageMisc.Controls.Add(Me.tabPage6)
		Me.pageMisc.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pageMisc.Location = New System.Drawing.Point(0, 0)
		Me.pageMisc.Name = "pageMisc"
		Me.pageMisc.SelectedIndex = 0
		Me.pageMisc.Size = New System.Drawing.Size(924, 173)
		Me.pageMisc.TabIndex = 0
		' 
		' pageSQL
		' 
		Me.pageSQL.Controls.Add(Me.tbSQL)
		Me.pageSQL.Location = New System.Drawing.Point(4, 22)
		Me.pageSQL.Name = "pageSQL"
		Me.pageSQL.Padding = New System.Windows.Forms.Padding(3)
		Me.pageSQL.Size = New System.Drawing.Size(916, 147)
		Me.pageSQL.TabIndex = 0
		Me.pageSQL.Text = "SQL"
		Me.pageSQL.UseVisualStyleBackColor = True
		' 
		' tbSQL
		' 
		Me.tbSQL.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbSQL.HideSelection = False
		Me.tbSQL.Location = New System.Drawing.Point(3, 3)
		Me.tbSQL.Multiline = True
		Me.tbSQL.Name = "tbSQL"
		Me.tbSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.tbSQL.Size = New System.Drawing.Size(910, 141)
		Me.tbSQL.TabIndex = 1
		AddHandler Me.tbSQL.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.tbSQL_Validating)
		' 
		' pageStatistics
		' 
		Me.pageStatistics.Controls.Add(Me.tbStatistics)
		Me.pageStatistics.Location = New System.Drawing.Point(4, 22)
		Me.pageStatistics.Name = "pageStatistics"
		Me.pageStatistics.Padding = New System.Windows.Forms.Padding(3)
		Me.pageStatistics.Size = New System.Drawing.Size(916, 147)
		Me.pageStatistics.TabIndex = 1
		Me.pageStatistics.Text = "Statistics"
		Me.pageStatistics.UseVisualStyleBackColor = True
		' 
		' tbStatistics
		' 
		Me.tbStatistics.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbStatistics.HideSelection = False
		Me.tbStatistics.Location = New System.Drawing.Point(3, 3)
		Me.tbStatistics.Multiline = True
		Me.tbStatistics.Name = "tbStatistics"
		Me.tbStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.tbStatistics.Size = New System.Drawing.Size(910, 141)
		Me.tbStatistics.TabIndex = 2
		' 
		' pageSubQueries
		' 
		Me.pageSubQueries.Controls.Add(Me.tbSubQueries)
		Me.pageSubQueries.Location = New System.Drawing.Point(4, 22)
		Me.pageSubQueries.Name = "pageSubQueries"
		Me.pageSubQueries.Padding = New System.Windows.Forms.Padding(3)
		Me.pageSubQueries.Size = New System.Drawing.Size(916, 147)
		Me.pageSubQueries.TabIndex = 2
		Me.pageSubQueries.Text = "SubQueries"
		Me.pageSubQueries.UseVisualStyleBackColor = True
		' 
		' tbSubQueries
		' 
		Me.tbSubQueries.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbSubQueries.HideSelection = False
		Me.tbSubQueries.Location = New System.Drawing.Point(3, 3)
		Me.tbSubQueries.Multiline = True
		Me.tbSubQueries.Name = "tbSubQueries"
		Me.tbSubQueries.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.tbSubQueries.Size = New System.Drawing.Size(910, 141)
		Me.tbSubQueries.TabIndex = 2
		' 
		' pageSubQueryStructure
		' 
		Me.pageSubQueryStructure.Controls.Add(Me.tbSubQueryStructure)
		Me.pageSubQueryStructure.Location = New System.Drawing.Point(4, 22)
		Me.pageSubQueryStructure.Name = "pageSubQueryStructure"
		Me.pageSubQueryStructure.Padding = New System.Windows.Forms.Padding(3)
		Me.pageSubQueryStructure.Size = New System.Drawing.Size(916, 147)
		Me.pageSubQueryStructure.TabIndex = 3
		Me.pageSubQueryStructure.Text = "SubQuery structure"
		Me.pageSubQueryStructure.UseVisualStyleBackColor = True
		' 
		' tbSubQueryStructure
		' 
		Me.tbSubQueryStructure.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbSubQueryStructure.HideSelection = False
		Me.tbSubQueryStructure.Location = New System.Drawing.Point(3, 3)
		Me.tbSubQueryStructure.Multiline = True
		Me.tbSubQueryStructure.Name = "tbSubQueryStructure"
		Me.tbSubQueryStructure.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.tbSubQueryStructure.Size = New System.Drawing.Size(910, 141)
		Me.tbSubQueryStructure.TabIndex = 2
		' 
		' pageUnionSubQuery
		' 
		Me.pageUnionSubQuery.Controls.Add(Me.tabctrlSubQueryStructureTabsheet)
		Me.pageUnionSubQuery.Location = New System.Drawing.Point(4, 22)
		Me.pageUnionSubQuery.Name = "pageUnionSubQuery"
		Me.pageUnionSubQuery.Padding = New System.Windows.Forms.Padding(3)
		Me.pageUnionSubQuery.Size = New System.Drawing.Size(916, 147)
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
		Me.tabctrlSubQueryStructureTabsheet.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabctrlSubQueryStructureTabsheet.Location = New System.Drawing.Point(3, 3)
		Me.tabctrlSubQueryStructureTabsheet.Name = "tabctrlSubQueryStructureTabsheet"
		Me.tabctrlSubQueryStructureTabsheet.SelectedIndex = 0
		Me.tabctrlSubQueryStructureTabsheet.Size = New System.Drawing.Size(910, 141)
		Me.tabctrlSubQueryStructureTabsheet.TabIndex = 0
		' 
		' pageSelectedExpressions
		' 
		Me.pageSelectedExpressions.Controls.Add(Me.tbSelectedExpressions)
		Me.pageSelectedExpressions.Location = New System.Drawing.Point(4, 22)
		Me.pageSelectedExpressions.Name = "pageSelectedExpressions"
		Me.pageSelectedExpressions.Padding = New System.Windows.Forms.Padding(3)
		Me.pageSelectedExpressions.Size = New System.Drawing.Size(902, 115)
		Me.pageSelectedExpressions.TabIndex = 0
		Me.pageSelectedExpressions.Text = "Selected Expressions"
		Me.pageSelectedExpressions.UseVisualStyleBackColor = True
		' 
		' tbSelectedExpressions
		' 
		Me.tbSelectedExpressions.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbSelectedExpressions.HideSelection = False
		Me.tbSelectedExpressions.Location = New System.Drawing.Point(3, 3)
		Me.tbSelectedExpressions.Multiline = True
		Me.tbSelectedExpressions.Name = "tbSelectedExpressions"
		Me.tbSelectedExpressions.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.tbSelectedExpressions.Size = New System.Drawing.Size(896, 109)
		Me.tbSelectedExpressions.TabIndex = 2
		' 
		' pageDataSources
		' 
		Me.pageDataSources.Controls.Add(Me.tbDataSources)
		Me.pageDataSources.Location = New System.Drawing.Point(4, 22)
		Me.pageDataSources.Name = "pageDataSources"
		Me.pageDataSources.Padding = New System.Windows.Forms.Padding(3)
		Me.pageDataSources.Size = New System.Drawing.Size(902, 115)
		Me.pageDataSources.TabIndex = 1
		Me.pageDataSources.Text = "DataSources"
		Me.pageDataSources.UseVisualStyleBackColor = True
		' 
		' tbDataSources
		' 
		Me.tbDataSources.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbDataSources.HideSelection = False
		Me.tbDataSources.Location = New System.Drawing.Point(3, 3)
		Me.tbDataSources.Multiline = True
		Me.tbDataSources.Name = "tbDataSources"
		Me.tbDataSources.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.tbDataSources.Size = New System.Drawing.Size(896, 109)
		Me.tbDataSources.TabIndex = 2
		' 
		' pageLinks
		' 
		Me.pageLinks.Controls.Add(Me.tbLinks)
		Me.pageLinks.Location = New System.Drawing.Point(4, 22)
		Me.pageLinks.Name = "pageLinks"
		Me.pageLinks.Padding = New System.Windows.Forms.Padding(3)
		Me.pageLinks.Size = New System.Drawing.Size(902, 115)
		Me.pageLinks.TabIndex = 2
		Me.pageLinks.Text = "Links"
		Me.pageLinks.UseVisualStyleBackColor = True
		' 
		' tbLinks
		' 
		Me.tbLinks.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbLinks.HideSelection = False
		Me.tbLinks.Location = New System.Drawing.Point(3, 3)
		Me.tbLinks.Multiline = True
		Me.tbLinks.Name = "tbLinks"
		Me.tbLinks.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.tbLinks.Size = New System.Drawing.Size(896, 109)
		Me.tbLinks.TabIndex = 2
		' 
		' pageWhere
		' 
		Me.pageWhere.Controls.Add(Me.tbWhere)
		Me.pageWhere.Location = New System.Drawing.Point(4, 22)
		Me.pageWhere.Name = "pageWhere"
		Me.pageWhere.Padding = New System.Windows.Forms.Padding(3)
		Me.pageWhere.Size = New System.Drawing.Size(902, 115)
		Me.pageWhere.TabIndex = 3
		Me.pageWhere.Text = "Where"
		Me.pageWhere.UseVisualStyleBackColor = True
		' 
		' tbWhere
		' 
		Me.tbWhere.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tbWhere.HideSelection = False
		Me.tbWhere.Location = New System.Drawing.Point(3, 3)
		Me.tbWhere.Multiline = True
		Me.tbWhere.Name = "tbWhere"
		Me.tbWhere.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.tbWhere.Size = New System.Drawing.Size(896, 109)
		Me.tbWhere.TabIndex = 2
		' 
		' tabPage6
		' 
		Me.tabPage6.Controls.Add(Me.lblShowUnlinkedDatasourcesLegend)
		Me.tabPage6.Controls.Add(Me.btnShowUnlinkedDatasourcesButton)
		Me.tabPage6.Location = New System.Drawing.Point(4, 22)
		Me.tabPage6.Name = "tabPage6"
		Me.tabPage6.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage6.Size = New System.Drawing.Size(916, 147)
		Me.tabPage6.TabIndex = 5
		Me.tabPage6.Text = "Misc"
		Me.tabPage6.UseVisualStyleBackColor = True
		' 
		' lblShowUnlinkedDatasourcesLegend
		' 
		Me.lblShowUnlinkedDatasourcesLegend.AutoSize = True
		Me.lblShowUnlinkedDatasourcesLegend.Location = New System.Drawing.Point(218, 15)
		Me.lblShowUnlinkedDatasourcesLegend.Name = "lblShowUnlinkedDatasourcesLegend"
		Me.lblShowUnlinkedDatasourcesLegend.Size = New System.Drawing.Size(355, 13)
		Me.lblShowUnlinkedDatasourcesLegend.TabIndex = 1
		Me.lblShowUnlinkedDatasourcesLegend.Text = "List DataSources not reachable by links from first DataSource of the query"
		' 
		' btnShowUnlinkedDatasourcesButton
		' 
		Me.btnShowUnlinkedDatasourcesButton.Location = New System.Drawing.Point(8, 10)
		Me.btnShowUnlinkedDatasourcesButton.Name = "btnShowUnlinkedDatasourcesButton"
		Me.btnShowUnlinkedDatasourcesButton.Size = New System.Drawing.Size(204, 23)
		Me.btnShowUnlinkedDatasourcesButton.TabIndex = 0
		Me.btnShowUnlinkedDatasourcesButton.Text = "List unlinked DataSources"
		Me.btnShowUnlinkedDatasourcesButton.UseVisualStyleBackColor = True
		AddHandler Me.btnShowUnlinkedDatasourcesButton.Click, New System.EventHandler(AddressOf Me.btnShowUnlinkedDatasourcesButton_Click)
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(924, 604)
		Me.Controls.Add(Me.splitContainer1)
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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

	Private imageList16 As System.Windows.Forms.ImageList
	Private imageList32 As System.Windows.Forms.ImageList
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private pageMisc As System.Windows.Forms.TabControl
	Private pageSQL As System.Windows.Forms.TabPage
	Private tbSQL As System.Windows.Forms.TextBox
	Private pageStatistics As System.Windows.Forms.TabPage
	Private tbStatistics As System.Windows.Forms.TextBox
	Private pnlSampleQueries As System.Windows.Forms.Panel
	Private btnSampleSelectFromWhere As System.Windows.Forms.Button
	Private lblSampleQueries As System.Windows.Forms.Label
	Private btnSampleSelect As System.Windows.Forms.Button
	Private btnSampleSelectFromJoinSubqueries As System.Windows.Forms.Button
	Private btnSampleSelectFromJoin As System.Windows.Forms.Button
	Private btnSampleUnions As System.Windows.Forms.Button
	Private pageSubQueries As System.Windows.Forms.TabPage
	Private pageSubQueryStructure As System.Windows.Forms.TabPage
	Private pageUnionSubQuery As System.Windows.Forms.TabPage
	Private tabPage6 As System.Windows.Forms.TabPage
	Private tbSubQueries As System.Windows.Forms.TextBox
	Private tbSubQueryStructure As System.Windows.Forms.TextBox
	Private tabctrlSubQueryStructureTabsheet As System.Windows.Forms.TabControl
	Private pageSelectedExpressions As System.Windows.Forms.TabPage
	Private pageDataSources As System.Windows.Forms.TabPage
	Private pageLinks As System.Windows.Forms.TabPage
	Private pageWhere As System.Windows.Forms.TabPage
	Private tbSelectedExpressions As System.Windows.Forms.TextBox
	Private tbDataSources As System.Windows.Forms.TextBox
	Private tbLinks As System.Windows.Forms.TextBox
	Private tbWhere As System.Windows.Forms.TextBox
	Private btnShowUnlinkedDatasourcesButton As System.Windows.Forms.Button
	Private lblShowUnlinkedDatasourcesLegend As System.Windows.Forms.Label
End Class

