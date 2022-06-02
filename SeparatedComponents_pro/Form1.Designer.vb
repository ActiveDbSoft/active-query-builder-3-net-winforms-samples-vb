
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
        Dim behaviorOptions1 As New ActiveQueryBuilder.Core.BehaviorOptions()
        Dim metadataStructure1 As New ActiveQueryBuilder.Core.MetadataStructure()
        Dim metadataFilter1 As New ActiveQueryBuilder.Core.MetadataFilter()
        Dim metadataStructureOptions1 As New ActiveQueryBuilder.Core.MetadataStructureOptions()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim linkPainterAccess3 As New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.mssqlSyntaxProvider1 = New ActiveQueryBuilder.Core.MSSQLSyntaxProvider(Me.components)
        Me.openFileDialog = New OpenFileDialog()
        Me.saveFileDialog = New SaveFileDialog()
        Me.mainMenu1 = New MainMenu(Me.components)
        Me.menuItem3 = New MenuItem()
        Me.refreshMetadataMenuItem = New MenuItem()
        Me.editMetadataMenuItem = New MenuItem()
        Me.clearMetadataMenuItem = New MenuItem()
        Me.menuItem4 = New MenuItem()
        Me.loadMetadataFromXMLMenuItem = New MenuItem()
        Me.saveMetadataToXMLMenuItem = New MenuItem()
        Me.queryStatisticsMenuItem = New MenuItem()
        Me.aboutMenuItem = New MenuItem()
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
        Me.errorBox1 = New Common.SqlErrorBox()
        CType(Me.sqlContext1.SQLGenerationOptionsForServer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryView1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.queryView1.SuspendLayout()
        CType(Me.queryColumnListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.databaseSchemaView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' openFileDialog
        ' 
        Me.openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        ' 
        ' saveFileDialog
        ' 
        Me.saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        ' 
        ' mainMenu1
        ' 
        Me.mainMenu1.MenuItems.AddRange(New MenuItem() { Me.menuItem3, Me.queryStatisticsMenuItem, Me.aboutMenuItem})
        ' 
        ' menuItem3
        ' 
        Me.menuItem3.Index = 0
        Me.menuItem3.MenuItems.AddRange(New MenuItem() { Me.refreshMetadataMenuItem, Me.editMetadataMenuItem, Me.clearMetadataMenuItem, Me.menuItem4, Me.loadMetadataFromXMLMenuItem, Me.saveMetadataToXMLMenuItem})
        Me.menuItem3.Text = "Metadata"
        ' 
        ' refreshMetadataMenuItem
        ' 
        Me.refreshMetadataMenuItem.Index = 0
        Me.refreshMetadataMenuItem.Text = "Refresh Metadata"
'            Me.refreshMetadataMenuItem.Click += New System.EventHandler(Me.refreshMetadataMenuItem_Click)
        ' 
        ' editMetadataMenuItem
        ' 
        Me.editMetadataMenuItem.Index = 1
        Me.editMetadataMenuItem.Text = "Edit Metadata..."
'            Me.editMetadataMenuItem.Click += New System.EventHandler(Me.editMetadataMenuItem_Click)
        ' 
        ' clearMetadataMenuItem
        ' 
        Me.clearMetadataMenuItem.Index = 2
        Me.clearMetadataMenuItem.Text = "Clear Metadata"
'            Me.clearMetadataMenuItem.Click += New System.EventHandler(Me.clearMetadataMenuItem_Click)
        ' 
        ' menuItem4
        ' 
        Me.menuItem4.Index = 3
        Me.menuItem4.Text = "-"
        ' 
        ' loadMetadataFromXMLMenuItem
        ' 
        Me.loadMetadataFromXMLMenuItem.Index = 4
        Me.loadMetadataFromXMLMenuItem.Text = "Load Metadata from XML..."
'            Me.loadMetadataFromXMLMenuItem.Click += New System.EventHandler(Me.loadMetadataFromXMLMenuItem_Click)
        ' 
        ' saveMetadataToXMLMenuItem
        ' 
        Me.saveMetadataToXMLMenuItem.Index = 5
        Me.saveMetadataToXMLMenuItem.Text = "Save Metadata to XML..."
'            Me.saveMetadataToXMLMenuItem.Click += New System.EventHandler(Me.saveMetadataToXMLMenuItem_Click)
        ' 
        ' queryStatisticsMenuItem
        ' 
        Me.queryStatisticsMenuItem.Index = 1
        Me.queryStatisticsMenuItem.Text = "Query Statistics..."
'            Me.queryStatisticsMenuItem.Click += New System.EventHandler(Me.queryStatisticsMenuItem_Click)
        ' 
        ' aboutMenuItem
        ' 
        Me.aboutMenuItem.Index = 2
        Me.aboutMenuItem.Text = "About..."
'            Me.aboutMenuItem.Click += New System.EventHandler(Me.aboutMenuItem_Click)
        ' 
        ' sqlQuery1
        ' 
        Me.sqlQuery1.BehaviorOptions = behaviorOptions1
        Me.sqlQuery1.SQLContext = Me.sqlContext1
'            Me.sqlQuery1.SQLUpdated += New System.EventHandler(Me.sqlQuery_SQLUpdated)
        ' 
        ' sqlContext1
        ' 
        Me.sqlContext1.MetadataProvider = Nothing
        ' 
        ' 
        ' 
        Me.sqlContext1.SQLGenerationOptionsForServer.ExpandVirtualFields = True
        Me.sqlContext1.SQLGenerationOptionsForServer.ExpandVirtualObjects = True
        Me.sqlContext1.SQLGenerationOptionsForServer.UseAltNames = False
        Me.sqlContext1.SyntaxProvider = Me.mssqlSyntaxProvider1
        metadataStructure1.AllowChildAutoItems = False
        metadataStructure1.Caption = Nothing
        metadataStructure1.ImageIndex = -1
        metadataStructure1.IsDynamic = False
        metadataStructure1.LoadDynamicNodes = True
        metadataFilter1.OwnObjects = True
        metadataStructure1.MetadataFilter = metadataFilter1
        metadataStructure1.MetadataName = Nothing
        metadataStructure1.Options = metadataStructureOptions1
        metadataStructure1.Tag = Nothing
        metadataStructure1.XML = resources.GetString("metadataStructure1.XML")
        Me.sqlContext1.UserQueriesStructure = metadataStructure1
        ' 
        ' queryNavigationBar1
        ' 
        Me.queryNavigationBar1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.queryNavigationBar1.AutoSize = True
        Me.queryNavigationBar1.BackColor = Color.Cornsilk
        Me.queryNavigationBar1.BorderStyle = BorderStyle.FixedSingle
        Me.queryNavigationBar1.Location = New Point(249, 7)
        Me.queryNavigationBar1.Name = "queryNavigationBar1"
        Me.queryNavigationBar1.Options.CTEButtonBaseColor = Color.Green
        Me.queryNavigationBar1.Options.DisableQueryNavigationBarPopup = False
        Me.queryNavigationBar1.Options.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryNavigationBar1.Options.OverflowButtonBaseColor = Color.DarkRed
        Me.queryNavigationBar1.Options.RootQueryButtonBaseColor = Color.Black
        Me.queryNavigationBar1.Options.SubQueryButtonBaseColor = Color.Blue
        Me.queryNavigationBar1.Query = Me.sqlQuery1
        Me.queryNavigationBar1.QueryView = Me.queryView1
        Me.queryNavigationBar1.Size = New Size(1098, 41)
        Me.queryNavigationBar1.TabIndex = 3
        Me.queryNavigationBar1.TabStop = False
        ' 
        ' queryView1
        ' 
        Me.queryView1.AddObjectDialog = Me.addObjectDialog1
        Me.queryView1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.queryView1.BackColor = Color.MistyRose
        Me.queryView1.BorderStyle = BorderStyle.FixedSingle
        Me.queryView1.Controls.Add(Me.queryColumnListControl1)
        Me.queryView1.Controls.Add(Me.designPaneControl1)
        Me.queryView1.ExpressionEditor = Me.expressionEditor1
        Me.queryView1.Location = New Point(249, 52)
        Me.queryView1.Name = "queryView1"
        Me.queryView1.Padding = New Padding(4)
        Me.queryView1.Query = Me.sqlQuery1
        Me.queryView1.Size = New Size(1098, 440)
        ' 
        ' 
        ' 
        Me.queryView1.SQLGenerationOptions.ExpandVirtualFields = False
        Me.queryView1.SQLGenerationOptions.ExpandVirtualObjects = False
        Me.queryView1.TabIndex = 1
        ' 
        ' addObjectDialog1
        ' 
        Me.addObjectDialog1.Options.Location = New Point(0, 0)
        Me.addObjectDialog1.Options.Size = New Size(430, 430)
        Me.addObjectDialog1.Options.StartPosition = FormStartPosition.CenterScreen
        Me.addObjectDialog1.QueryView = Me.queryView1
        ' 
        ' queryColumnListControl1
        ' 
        Me.queryColumnListControl1.Anchor = (CType(((AnchorStyles.Bottom Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.queryColumnListControl1.BorderStyle = BorderStyle.FixedSingle
        Me.queryColumnListControl1.ForeColor = SystemColors.WindowText
        Me.queryColumnListControl1.Location = New Point(7, 315)
        Me.queryColumnListControl1.Name = "queryColumnListControl1"
        Me.queryColumnListControl1.Options.Font = Nothing
        Me.queryColumnListControl1.Options.InitialOrColumnsCount = 2
        Me.queryColumnListControl1.Options.NullOrderingInOrderBy = False
        Me.queryColumnListControl1.Options.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryColumnListControl1.SelectedItems = New Integer(){}
        Me.queryColumnListControl1.Size = New Size(1082, 116)
        Me.queryColumnListControl1.TabIndex = 1
        ' 
        ' designPaneControl1
        ' 
        Me.designPaneControl1.AllowDrop = True
        Me.designPaneControl1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.designPaneControl1.AutoScroll = True
        Me.designPaneControl1.AutoScrollMargin = New Size(20, 20)
        Me.designPaneControl1.BorderStyle = BorderStyle.FixedSingle
        Me.designPaneControl1.Location = New Point(7, 7)
        Me.designPaneControl1.Name = "designPaneControl1"
        Me.designPaneControl1.Options.Background = SystemColors.Window
        linkPainterAccess3.LinkColor = Color.Black
        linkPainterAccess3.LinkColorFocused = Color.Black
        linkPainterAccess3.MarkColor = SystemColors.Control
        linkPainterAccess3.MarkColorFocused = SystemColors.ControlDark
        linkPainterAccess3.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.designPaneControl1.Options.LinkPainterOptions = linkPainterAccess3
        Me.designPaneControl1.Options.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.designPaneControl1.Size = New Size(1082, 302)
        Me.designPaneControl1.TabIndex = 0
        ' 
        ' expressionEditor1
        ' 
        Me.expressionEditor1.ActiveUnionSubQuery = Nothing
        ' 
        ' sqlTextEditor1
        ' 
        Me.sqlTextEditor1.AllowShowSuggestionByMouse = False
        Me.sqlTextEditor1.Anchor = (CType(((AnchorStyles.Bottom Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.sqlTextEditor1.BackColor = Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
        Me.sqlTextEditor1.BorderStyle = BorderStyle.FixedSingle
        Me.sqlTextEditor1.CaretOffset = 0
        Me.sqlTextEditor1.ForeColor = Color.White
        Me.sqlTextEditor1.Location = New Point(7, 498)
        Me.sqlTextEditor1.Name = "sqlTextEditor1"
        Me.sqlTextEditor1.Options.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.sqlTextEditor1.Options.Padding = New Padding(6, 3, 3, 3)
        Me.sqlTextEditor1.Query = Me.sqlQuery1
        Me.sqlTextEditor1.QueryProvider = Me.sqlQuery1
        Me.sqlTextEditor1.SelectedText = ""
        Me.sqlTextEditor1.SelectionLength = 0
        Me.sqlTextEditor1.SelectionStart = 0
        Me.sqlTextEditor1.Size = New Size(1340, 93)
        Me.sqlTextEditor1.SQLContext = Me.sqlContext1
        Me.sqlTextEditor1.SqlOptions.KeywordColor = Color.LightSkyBlue
        Me.sqlTextEditor1.SqlOptions.SuggestionWindowSize = New Size(200, 200)
        Me.sqlTextEditor1.TabIndex = 2
        '            Me.sqlTextEditor1.Validating += New System.ComponentModel.CancelEventHandler(Me.sqlTextEditor1_Validating)
        ' 
        ' databaseSchemaView1
        ' 
        Me.databaseSchemaView1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left), AnchorStyles))
        Me.databaseSchemaView1.BackColor = SystemColors.Window
        Me.databaseSchemaView1.BorderStyle = BorderStyle.FixedSingle
        Me.databaseSchemaView1.Location = New Point(7, 7)
        Me.databaseSchemaView1.Name = "databaseSchemaView1"
        Me.databaseSchemaView1.Options.AllowDrop = True
        Me.databaseSchemaView1.Options.DrawTreeLines = False
        Me.databaseSchemaView1.Options.ImageIndices.FilterImageIndex = 14
        Me.databaseSchemaView1.Options.ImageList = Nothing
        Me.databaseSchemaView1.QueryView = Me.queryView1
        Me.databaseSchemaView1.SelectedItems = New ActiveQueryBuilder.Core.MetadataStructureItem(){}
        Me.databaseSchemaView1.Size = New Size(236, 485)
        Me.databaseSchemaView1.SQLContext = Me.sqlContext1
        Me.databaseSchemaView1.TabIndex = 0
        ' 
        ' errorBox1
        ' 
        Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox1.AutoSize = True
        Me.errorBox1.BackColor = Color.LightPink
        Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = False
        Me.errorBox1.Location = New Point(1024, 530)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New Padding(5)
        Me.errorBox1.Size = New Size(315, 61)
        Me.errorBox1.TabIndex = 4
'            Me.errorBox1.GoToErrorPosition += New System.EventHandler(Me.ErrorBox1_GoToErrorPositionEvent)
'            Me.errorBox1.RevertValidText += New System.EventHandler(Me.ErrorBox1_RevertValidTextEvent)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1354, 598)
        Me.Controls.Add(Me.errorBox1)
        Me.Controls.Add(Me.queryNavigationBar1)
        Me.Controls.Add(Me.sqlTextEditor1)
        Me.Controls.Add(Me.queryView1)
        Me.Controls.Add(Me.databaseSchemaView1)
        Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Padding = New Padding(4)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.sqlContext1.SQLGenerationOptionsForServer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryView1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.queryView1.ResumeLayout(False)
        Me.queryView1.PerformLayout()
        CType(Me.queryColumnListControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.databaseSchemaView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private openFileDialog As OpenFileDialog
    Private saveFileDialog As SaveFileDialog
    Private mssqlSyntaxProvider1 As ActiveQueryBuilder.Core.MSSQLSyntaxProvider
    Private mainMenu1 As MainMenu
    Private menuItem3 As MenuItem
    Private WithEvents refreshMetadataMenuItem As MenuItem
    Private WithEvents editMetadataMenuItem As MenuItem
    Private WithEvents clearMetadataMenuItem As MenuItem
    Private menuItem4 As MenuItem
    Private WithEvents loadMetadataFromXMLMenuItem As MenuItem
    Private WithEvents saveMetadataToXMLMenuItem As MenuItem
    Private WithEvents aboutMenuItem As MenuItem
    Private WithEvents queryStatisticsMenuItem As MenuItem
    Private WithEvents sqlQuery1 As ActiveQueryBuilder.Core.SQLQuery
    Private sqlContext1 As ActiveQueryBuilder.Core.SQLContext
    Private databaseSchemaView1 As ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView
    Private queryView1 As ActiveQueryBuilder.View.WinForms.QueryView.QueryView
    Private WithEvents sqlTextEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor
    Private queryNavigationBar1 As ActiveQueryBuilder.View.WinForms.NavigationBar.QueryNavigationBar
    Private queryColumnListControl1 As ActiveQueryBuilder.View.WinForms.QueryView.QueryColumnListControl
    Private designPaneControl1 As ActiveQueryBuilder.View.WinForms.QueryView.DesignPaneControl
    Private addObjectDialog1 As ActiveQueryBuilder.View.WinForms.QueryView.AddObjectDialog
    Private expressionEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor
    Private WithEvents errorBox1 As Common.SqlErrorBox
End Class
