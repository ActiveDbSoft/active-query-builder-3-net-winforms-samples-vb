Imports System.Drawing

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
        Dim BehaviorOptions1 As ActiveQueryBuilder.Core.BehaviorOptions = New ActiveQueryBuilder.Core.BehaviorOptions()
        Dim MetadataStructure1 As ActiveQueryBuilder.Core.MetadataStructure = New ActiveQueryBuilder.Core.MetadataStructure()
        Dim MetadataFilter1 As ActiveQueryBuilder.Core.MetadataFilter = New ActiveQueryBuilder.Core.MetadataFilter()
        Dim MetadataStructureOptions1 As ActiveQueryBuilder.Core.MetadataStructureOptions = New ActiveQueryBuilder.Core.MetadataStructureOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim LinkPainterAccess1 As ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess = New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.mssqlSyntaxProvider1 = New ActiveQueryBuilder.Core.MSSQLSyntaxProvider(Me.components)
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.refreshMetadataMenuItem = New System.Windows.Forms.MenuItem()
        Me.editMetadataMenuItem = New System.Windows.Forms.MenuItem()
        Me.clearMetadataMenuItem = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.loadMetadataFromXMLMenuItem = New System.Windows.Forms.MenuItem()
        Me.saveMetadataToXMLMenuItem = New System.Windows.Forms.MenuItem()
        Me.queryStatisticsMenuItem = New System.Windows.Forms.MenuItem()
        Me.aboutMenuItem = New System.Windows.Forms.MenuItem()
        Me.sqlQuery1 = New ActiveQueryBuilder.Core.SQLQuery(Me.components)
        Me.sqlContext1 = New ActiveQueryBuilder.Core.SQLContext(Me.components)
        Me.queryNavigationBar1 = New ActiveQueryBuilder.View.WinForms.NavigationBar.QueryNavigationBar()
        Me.queryView1 = New ActiveQueryBuilder.View.WinForms.QueryView.QueryView()
        Me.addObjectDialog1 = New ActiveQueryBuilder.View.WinForms.QueryView.AddObjectDialog(Me.components)
        Me.queryColumnListControl1 = New ActiveQueryBuilder.View.WinForms.QueryView.QueryColumnListControl()
        Me.designPaneControl1 = New ActiveQueryBuilder.View.WinForms.QueryView.DesignPaneControl()
        Me.expressionEditor1 = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor(Me.components)
        Me.sqlTextEditor1 = New ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor()
        Me.databaseSchemaView1 = New ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView()
        Me.ErrorBox1 = New SeparatedComponents.Common.ErrorBox()
        CType(Me.sqlContext1.SQLGenerationOptionsForServer,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.queryView1.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).BeginInit
        Me.queryView1.SuspendLayout
        CType(Me.queryColumnListControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.databaseSchemaView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'mssqlSyntaxProvider1
        '
        Me.mssqlSyntaxProvider1.OnCalcExpressionType = Nothing
        '
        'openFileDialog
        '
        Me.openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        '
        'saveFileDialog
        '
        Me.saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem3, Me.queryStatisticsMenuItem, Me.aboutMenuItem})
        '
        'menuItem3
        '
        Me.menuItem3.Index = 0
        Me.menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.refreshMetadataMenuItem, Me.editMetadataMenuItem, Me.clearMetadataMenuItem, Me.menuItem4, Me.loadMetadataFromXMLMenuItem, Me.saveMetadataToXMLMenuItem})
        Me.menuItem3.Text = "Metadata"
        '
        'refreshMetadataMenuItem
        '
        Me.refreshMetadataMenuItem.Index = 0
        Me.refreshMetadataMenuItem.Text = "Refresh Metadata"
        '
        'editMetadataMenuItem
        '
        Me.editMetadataMenuItem.Index = 1
        Me.editMetadataMenuItem.Text = "Edit Metadata..."
        '
        'clearMetadataMenuItem
        '
        Me.clearMetadataMenuItem.Index = 2
        Me.clearMetadataMenuItem.Text = "Clear Metadata"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 3
        Me.menuItem4.Text = "-"
        '
        'loadMetadataFromXMLMenuItem
        '
        Me.loadMetadataFromXMLMenuItem.Index = 4
        Me.loadMetadataFromXMLMenuItem.Text = "Load Metadata from XML..."
        '
        'saveMetadataToXMLMenuItem
        '
        Me.saveMetadataToXMLMenuItem.Index = 5
        Me.saveMetadataToXMLMenuItem.Text = "Save Metadata to XML..."
        '
        'queryStatisticsMenuItem
        '
        Me.queryStatisticsMenuItem.Index = 1
        Me.queryStatisticsMenuItem.Text = "Query Statistics..."
        '
        'aboutMenuItem
        '
        Me.aboutMenuItem.Index = 2
        Me.aboutMenuItem.Text = "About..."
        '
        'sqlQuery1
        '
        Me.sqlQuery1.BehaviorOptions = BehaviorOptions1
        Me.sqlQuery1.SQLContext = Me.sqlContext1
        '
        'sqlContext1
        '
        Me.sqlContext1.MetadataProvider = Nothing
        '
        '
        '
        Me.sqlContext1.SQLGenerationOptionsForServer.ExpandVirtualFields = true
        Me.sqlContext1.SQLGenerationOptionsForServer.ExpandVirtualObjects = true
        Me.sqlContext1.SQLGenerationOptionsForServer.UseAltNames = false
        Me.sqlContext1.SyntaxProvider = Me.mssqlSyntaxProvider1
        MetadataStructure1.AllowChildAutoItems = false
        MetadataStructure1.Caption = Nothing
        MetadataStructure1.ImageIndex = -1
        MetadataStructure1.IsDynamic = false
        MetadataStructure1.LoadDynamicNodes = true
        MetadataFilter1.OwnObjects = true
        MetadataStructure1.MetadataFilter = MetadataFilter1
        MetadataStructure1.MetadataName = Nothing
        MetadataStructure1.Options = MetadataStructureOptions1
        MetadataStructure1.Tag = Nothing
        MetadataStructure1.XML = resources.GetString("MetadataStructure1.XML")
        Me.sqlContext1.UserQueriesStructure = MetadataStructure1
        '
        'queryNavigationBar1
        '
        Me.queryNavigationBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.queryNavigationBar1.AutoSize = true
        Me.queryNavigationBar1.BackColor = System.Drawing.Color.Cornsilk
        Me.queryNavigationBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.queryNavigationBar1.Location = New System.Drawing.Point(249, 7)
        Me.queryNavigationBar1.Name = "queryNavigationBar1"
        Me.queryNavigationBar1.Options.CTEButtonBaseColor = System.Drawing.Color.Green
        Me.queryNavigationBar1.Options.DisableQueryNavigationBarPopup = false
        Me.queryNavigationBar1.Options.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.queryNavigationBar1.Options.OverflowButtonBaseColor = System.Drawing.Color.DarkRed
        Me.queryNavigationBar1.Options.RootQueryButtonBaseColor = System.Drawing.Color.Black
        Me.queryNavigationBar1.Options.SubQueryButtonBaseColor = System.Drawing.Color.Blue
        Me.queryNavigationBar1.Query = Me.sqlQuery1
        Me.queryNavigationBar1.QueryView = Me.queryView1
        Me.queryNavigationBar1.Size = New System.Drawing.Size(678, 39)
        Me.queryNavigationBar1.TabIndex = 3
        Me.queryNavigationBar1.TabStop = false
        '
        'queryView1
        '
        Me.queryView1.AddObjectDialog = Me.addObjectDialog1
        Me.queryView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.queryView1.BackColor = System.Drawing.Color.MistyRose
        Me.queryView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.queryView1.Controls.Add(Me.queryColumnListControl1)
        Me.queryView1.Controls.Add(Me.designPaneControl1)
        Me.queryView1.ExpressionEditor = Me.expressionEditor1
        Me.queryView1.Location = New System.Drawing.Point(249, 52)
        Me.queryView1.Name = "queryView1"
        Me.queryView1.Padding = New System.Windows.Forms.Padding(4)
        Me.queryView1.Query = Me.sqlQuery1
        Me.queryView1.Size = New System.Drawing.Size(678, 440)
        '
        '
        '
        Me.queryView1.SQLGenerationOptions.ExpandVirtualFields = false
        Me.queryView1.SQLGenerationOptions.ExpandVirtualObjects = false
        Me.queryView1.TabIndex = 1
        '
        'addObjectDialog1
        '
        Me.addObjectDialog1.Options.Location = New System.Drawing.Point(0, 0)
        Me.addObjectDialog1.Options.Size = New System.Drawing.Size(430, 430)
        Me.addObjectDialog1.Options.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.addObjectDialog1.QueryView = Me.queryView1
        '
        'queryColumnListControl1
        '
        Me.queryColumnListControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.queryColumnListControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.queryColumnListControl1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.queryColumnListControl1.Location = New System.Drawing.Point(7, 315)
        Me.queryColumnListControl1.Name = "queryColumnListControl1"
        Me.queryColumnListControl1.Options.ColumnsOptions.AggregateColumn.Index = 5
        Me.queryColumnListControl1.Options.ColumnsOptions.AggregateColumn.Width = 90R
        Me.queryColumnListControl1.Options.ColumnsOptions.AliasColumn.Index = 2
        Me.queryColumnListControl1.Options.ColumnsOptions.AliasColumn.Width = 100R
        Me.queryColumnListControl1.Options.ColumnsOptions.ConditionTypeColumn.Index = 7
        Me.queryColumnListControl1.Options.ColumnsOptions.ConditionTypeColumn.Width = 140R
        Me.queryColumnListControl1.Options.ColumnsOptions.CriteriaColumn.Index = 8
        Me.queryColumnListControl1.Options.ColumnsOptions.CriteriaColumn.Width = 200R
        Me.queryColumnListControl1.Options.ColumnsOptions.CriteriaOrColumns.Index = 0
        Me.queryColumnListControl1.Options.ColumnsOptions.CriteriaOrColumns.Width = 60R
        Me.queryColumnListControl1.Options.ColumnsOptions.ExpressionColumn.Index = 1
        Me.queryColumnListControl1.Options.ColumnsOptions.ExpressionColumn.Width = 250R
        Me.queryColumnListControl1.Options.ColumnsOptions.GroupingColumn.Index = 6
        Me.queryColumnListControl1.Options.ColumnsOptions.GroupingColumn.Width = 100R
        Me.queryColumnListControl1.Options.ColumnsOptions.OutputColumn.Index = 0
        Me.queryColumnListControl1.Options.ColumnsOptions.OutputColumn.Width = 55R
        Me.queryColumnListControl1.Options.ColumnsOptions.SortOrderColumn.Index = 4
        Me.queryColumnListControl1.Options.ColumnsOptions.SortOrderColumn.Width = 100R
        Me.queryColumnListControl1.Options.ColumnsOptions.SortTypeColumn.Index = 3
        Me.queryColumnListControl1.Options.ColumnsOptions.SortTypeColumn.Width = 60R
        Me.queryColumnListControl1.Options.Font = Nothing
        Me.queryColumnListControl1.Options.InitialOrColumnsCount = 2
        Me.queryColumnListControl1.Options.NullOrderingInOrderBy = false
        Me.queryColumnListControl1.Options.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryColumnListControl1.Query = Me.sqlQuery1
        Me.queryColumnListControl1.SelectedItems = New Integer(-1) {}
        Me.queryColumnListControl1.Size = New System.Drawing.Size(662, 116)
        Me.queryColumnListControl1.TabIndex = 1
        '
        'designPaneControl1
        '
        Me.designPaneControl1.AllowDrop = true
        Me.designPaneControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.designPaneControl1.AutoScroll = true
        Me.designPaneControl1.AutoScrollMargin = New System.Drawing.Size(20, 20)
        Me.designPaneControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.designPaneControl1.Location = New System.Drawing.Point(7, 7)
        Me.designPaneControl1.Name = "designPaneControl1"
        Me.designPaneControl1.Options.Background = System.Drawing.SystemColors.Window
        LinkPainterAccess1.LinkColor = System.Drawing.Color.Black
        LinkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black
        LinkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control
        LinkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark
        LinkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.designPaneControl1.Options.LinkPainterOptions = LinkPainterAccess1
        Me.designPaneControl1.Options.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.designPaneControl1.Size = New System.Drawing.Size(662, 302)
        Me.designPaneControl1.TabIndex = 0
        '
        'expressionEditor1
        '
        Me.expressionEditor1.ActiveUnionSubQuery = Nothing
        Me.expressionEditor1.Expression = ""
        Me.expressionEditor1.Height = 531
        Me.expressionEditor1.HighlightMatchingParentheses = ActiveQueryBuilder.View.ExpressionEditor.ParenthesesHighlighting.NoHighlight
        Me.expressionEditor1.KeepMetadataObjectsOnTopOfSuggestionList = true
        Me.expressionEditor1.LoadMetadataOnCodeCompletion = true
        Me.expressionEditor1.SearchFields = false
        Me.expressionEditor1.SQLContext = Me.sqlContext1
        Me.expressionEditor1.SQLFormattingOptions = Nothing
        Me.expressionEditor1.TextEditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.expressionEditor1.Width = 754
        '
        'sqlTextEditor1
        '
        Me.sqlTextEditor1.AcceptTabs = false
        Me.sqlTextEditor1.AllowShowSuggestionByMouse = false
        Me.sqlTextEditor1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.sqlTextEditor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.sqlTextEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sqlTextEditor1.CaretOffset = 0
        Me.sqlTextEditor1.ForeColor = System.Drawing.Color.White
        Me.sqlTextEditor1.Location = New System.Drawing.Point(7, 498)
        Me.sqlTextEditor1.Name = "sqlTextEditor1"
        Me.sqlTextEditor1.Options.Font = New System.Drawing.Font("Courier New", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.sqlTextEditor1.Options.Padding = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.sqlTextEditor1.Padding = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.sqlTextEditor1.Query = Me.sqlQuery1
        Me.sqlTextEditor1.QueryProvider = Me.sqlQuery1
        Me.sqlTextEditor1.SelectedText = ""
        Me.sqlTextEditor1.SelectionLength = 0
        Me.sqlTextEditor1.SelectionStart = 0
        Me.sqlTextEditor1.Size = New System.Drawing.Size(920, 93)
        Me.sqlTextEditor1.SQLContext = Me.sqlContext1
        Me.sqlTextEditor1.SqlOptions.KeywordColor = System.Drawing.Color.LightSkyBlue
        Me.sqlTextEditor1.SuggestionWindowSize = New System.Drawing.Size(2147483647, 200)
        Me.sqlTextEditor1.TabIndex = 2
        '
        'databaseSchemaView1
        '
        Me.databaseSchemaView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.databaseSchemaView1.BackColor = System.Drawing.SystemColors.Window
        Me.databaseSchemaView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.databaseSchemaView1.Location = New System.Drawing.Point(7, 7)
        Me.databaseSchemaView1.Name = "databaseSchemaView1"
        Me.databaseSchemaView1.Options.AllowDrop = true
        Me.databaseSchemaView1.Options.DrawTreeLines = false
        Me.databaseSchemaView1.Options.ImageList = Nothing
        Me.databaseSchemaView1.QueryView = Me.queryView1
        Me.databaseSchemaView1.SelectedItems = New ActiveQueryBuilder.Core.MetadataStructureItem(-1) {}
        Me.databaseSchemaView1.Size = New System.Drawing.Size(236, 485)
        Me.databaseSchemaView1.SQLContext = Me.sqlContext1
        Me.databaseSchemaView1.TabIndex = 0
        '
        'ErrorBox1
        '
        Me.ErrorBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.ErrorBox1.AutoSize = true
        Me.ErrorBox1.BackColor = System.Drawing.Color.LightPink
        Me.ErrorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorBox1.CurrentSyntaxProvider = Nothing
        Me.ErrorBox1.IsVisibleCheckSyntaxPanel = false
        Me.ErrorBox1.Location = New System.Drawing.Point(558, 521)
        Me.ErrorBox1.Name = "ErrorBox1"
        Me.ErrorBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.ErrorBox1.Size = New System.Drawing.Size(359, 61)
        Me.ErrorBox1.TabIndex = 4
        Me.ErrorBox1.Visible = false
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 598)
        Me.Controls.Add(Me.ErrorBox1)
        Me.Controls.Add(Me.queryNavigationBar1)
        Me.Controls.Add(Me.sqlTextEditor1)
        Me.Controls.Add(Me.queryView1)
        Me.Controls.Add(Me.databaseSchemaView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.sqlContext1.SQLGenerationOptionsForServer,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryView1.SQLGenerationOptions,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.queryView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.queryView1.ResumeLayout(false)
        Me.queryView1.PerformLayout
        CType(Me.queryColumnListControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.databaseSchemaView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

#End Region

    Private openFileDialog As System.Windows.Forms.OpenFileDialog
    Private saveFileDialog As System.Windows.Forms.SaveFileDialog
    Private mssqlSyntaxProvider1 As ActiveQueryBuilder.Core.MSSQLSyntaxProvider
    Private WithEvents mainMenu1 As System.Windows.Forms.MainMenu
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private WithEvents refreshMetadataMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents editMetadataMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents clearMetadataMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents loadMetadataFromXMLMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents saveMetadataToXMLMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents aboutMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents queryStatisticsMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents sqlQuery1 As ActiveQueryBuilder.Core.SQLQuery
    Private WithEvents sqlContext1 As ActiveQueryBuilder.Core.SQLContext
    Private databaseSchemaView1 As ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView
    Private WithEvents queryView1 As ActiveQueryBuilder.View.WinForms.QueryView.QueryView
    Private WithEvents sqlTextEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor
    Private queryNavigationBar1 As ActiveQueryBuilder.View.WinForms.NavigationBar.QueryNavigationBar
    Private queryColumnListControl1 As ActiveQueryBuilder.View.WinForms.QueryView.QueryColumnListControl
    Private designPaneControl1 As ActiveQueryBuilder.View.WinForms.QueryView.DesignPaneControl
    Private addObjectDialog1 As ActiveQueryBuilder.View.WinForms.QueryView.AddObjectDialog
    Private expressionEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor
    Friend WithEvents ErrorBox1 As Common.ErrorBox
End Class

