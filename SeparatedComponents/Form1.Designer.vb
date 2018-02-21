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
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
		DirectCast(Me.queryView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.queryView1.SuspendLayout()
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
		Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem3, Me.queryStatisticsMenuItem, Me.aboutMenuItem})
		' 
		' menuItem3
		' 
		Me.menuItem3.Index = 0
		Me.menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.refreshMetadataMenuItem, Me.editMetadataMenuItem, Me.clearMetadataMenuItem, Me.menuItem4, Me.loadMetadataFromXMLMenuItem, Me.saveMetadataToXMLMenuItem})
		Me.menuItem3.Text = "Metadata"
		' 
		' refreshMetadataMenuItem
		' 
		Me.refreshMetadataMenuItem.Index = 0
		Me.refreshMetadataMenuItem.Text = "Refresh Metadata"
		AddHandler Me.refreshMetadataMenuItem.Click, New System.EventHandler(AddressOf Me.refreshMetadataMenuItem_Click)
		' 
		' editMetadataMenuItem
		' 
		Me.editMetadataMenuItem.Index = 1
		Me.editMetadataMenuItem.Text = "Edit Metadata..."
		AddHandler Me.editMetadataMenuItem.Click, New System.EventHandler(AddressOf Me.editMetadataMenuItem_Click)
		' 
		' clearMetadataMenuItem
		' 
		Me.clearMetadataMenuItem.Index = 2
		Me.clearMetadataMenuItem.Text = "Clear Metadata"
		AddHandler Me.clearMetadataMenuItem.Click, New System.EventHandler(AddressOf Me.clearMetadataMenuItem_Click)
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
		AddHandler Me.loadMetadataFromXMLMenuItem.Click, New System.EventHandler(AddressOf Me.loadMetadataFromXMLMenuItem_Click)
		' 
		' saveMetadataToXMLMenuItem
		' 
		Me.saveMetadataToXMLMenuItem.Index = 5
		Me.saveMetadataToXMLMenuItem.Text = "Save Metadata to XML..."
		AddHandler Me.saveMetadataToXMLMenuItem.Click, New System.EventHandler(AddressOf Me.saveMetadataToXMLMenuItem_Click)
		' 
		' queryStatisticsMenuItem
		' 
		Me.queryStatisticsMenuItem.Index = 1
		Me.queryStatisticsMenuItem.Text = "Query Statistics..."
		AddHandler Me.queryStatisticsMenuItem.Click, New System.EventHandler(AddressOf Me.queryStatisticsMenuItem_Click)
		' 
		' aboutMenuItem
		' 
		Me.aboutMenuItem.Index = 2
		Me.aboutMenuItem.Text = "About..."
		AddHandler Me.aboutMenuItem.Click, New System.EventHandler(AddressOf Me.aboutMenuItem_Click)
		' 
		' sqlQuery1
		' 
		Me.sqlQuery1.SQLContext = Me.sqlContext1
        AddHandler Me.sqlQuery1.SQLUpdated, New System.EventHandler(AddressOf Me.sqlQuery_SQLUpdated)
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
		' 
		' queryNavigationBar1
		' 
		Me.queryNavigationBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.queryNavigationBar1.AutoSize = True
		Me.queryNavigationBar1.BackColor = System.Drawing.Color.Cornsilk
		Me.queryNavigationBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.queryNavigationBar1.Location = New System.Drawing.Point(249, 7)
		Me.queryNavigationBar1.Name = "queryNavigationBar1"
		Me.queryNavigationBar1.Query = Me.sqlQuery1
		Me.queryNavigationBar1.QueryView = Me.queryView1
		Me.queryNavigationBar1.Size = New System.Drawing.Size(678, 39)
		Me.queryNavigationBar1.TabIndex = 3
		Me.queryNavigationBar1.TabStop = False
		' 
		' queryView1
		' 
		Me.queryView1.AddObjectDialog = Me.addObjectDialog1
		Me.queryView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
		Me.queryView1.SQLGenerationOptions.ExpandVirtualFields = False
		Me.queryView1.SQLGenerationOptions.ExpandVirtualObjects = False
		Me.queryView1.TabIndex = 1
		' 
		' addObjectDialog1
		' 
		Me.addObjectDialog1.QueryView = Me.queryView1
		' 
		' queryColumnListControl1
		' 
		Me.queryColumnListControl1.AlternateRowColor = System.Drawing.SystemColors.Window
		Me.queryColumnListControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.queryColumnListControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.queryColumnListControl1.CurrentColumn = 0
		Me.queryColumnListControl1.CurrentQueryColumnIndex = 0
		Me.queryColumnListControl1.CurrentRow = 0
		Me.queryColumnListControl1.Location = New System.Drawing.Point(7, 315)
		Me.queryColumnListControl1.Name = "queryColumnListControl1"
		Me.queryColumnListControl1.Size = New System.Drawing.Size(662, 116)
		Me.queryColumnListControl1.TabIndex = 1
		' 
		' designPaneControl1
		' 
		Me.designPaneControl1.AllowDrop = True
		Me.designPaneControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.designPaneControl1.AutoScroll = True
		Me.designPaneControl1.AutoScrollMargin = New System.Drawing.Size(20, 20)
		Me.designPaneControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.designPaneControl1.Location = New System.Drawing.Point(7, 7)
		Me.designPaneControl1.Name = "designPaneControl1"
		Me.designPaneControl1.Size = New System.Drawing.Size(662, 302)
		Me.designPaneControl1.TabIndex = 0
		' 
		' expressionEditor1
		' 
		Me.expressionEditor1.ActiveUnionSubQuery = Nothing
		Me.expressionEditor1.Expression = ""
		Me.expressionEditor1.Height = 531
		Me.expressionEditor1.Query = Me.sqlQuery1
		' 
		' 
		' 
		Me.expressionEditor1.SQLGenerationOptions.ExpandVirtualFields = False
		Me.expressionEditor1.SQLGenerationOptions.ExpandVirtualObjects = False
		Me.expressionEditor1.TextEditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.expressionEditor1.Width = 754
		' 
		' sqlTextEditor1
		' 
		Me.sqlTextEditor1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.sqlTextEditor1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(64)), CInt(CByte(64)), CInt(CByte(64)))
		Me.sqlTextEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.sqlTextEditor1.Font = New System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.sqlTextEditor1.KeywordColor = System.Drawing.Color.LightSkyBlue
		Me.sqlTextEditor1.Location = New System.Drawing.Point(7, 498)
		Me.sqlTextEditor1.Name = "sqlTextEditor1"
		Me.sqlTextEditor1.Query = Me.sqlQuery1
		Me.sqlTextEditor1.QueryProvider = Me.sqlQuery1
		Me.sqlTextEditor1.Size = New System.Drawing.Size(920, 93)
		' 
		' 
		' 
		Me.sqlTextEditor1.SQLGenerationOptions.ExpandVirtualFields = False
		Me.sqlTextEditor1.SQLGenerationOptions.ExpandVirtualObjects = False
		Me.sqlTextEditor1.TabIndex = 2
		Me.sqlTextEditor1.Text = "sqlTextEditor1"
		Me.sqlTextEditor1.TextColor = System.Drawing.Color.White
		Me.sqlTextEditor1.TextPadding = New System.Windows.Forms.Padding(6, 3, 3, 3)
        AddHandler Me.sqlTextEditor1.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.sqlTextEditor1_Validating)
		' 
		' databaseSchemaView1
		' 
		Me.databaseSchemaView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.databaseSchemaView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.databaseSchemaView1.Location = New System.Drawing.Point(7, 7)
		Me.databaseSchemaView1.Name = "databaseSchemaView1"
		Me.databaseSchemaView1.QueryView = Me.queryView1
		Me.databaseSchemaView1.Size = New System.Drawing.Size(236, 485)
		Me.databaseSchemaView1.SQLContext = Me.sqlContext1
		Me.databaseSchemaView1.TabIndex = 0
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(934, 598)
		Me.Controls.Add(Me.queryNavigationBar1)
		Me.Controls.Add(Me.sqlTextEditor1)
		Me.Controls.Add(Me.queryView1)
		Me.Controls.Add(Me.databaseSchemaView1)
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Menu = Me.mainMenu1
		Me.Name = "Form1"
		Me.Padding = New System.Windows.Forms.Padding(4)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		DirectCast(Me.queryView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.queryView1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private openFileDialog As System.Windows.Forms.OpenFileDialog
	Private saveFileDialog As System.Windows.Forms.SaveFileDialog
	Private mssqlSyntaxProvider1 As ActiveQueryBuilder.Core.MSSQLSyntaxProvider
	Private mainMenu1 As System.Windows.Forms.MainMenu
	Private menuItem3 As System.Windows.Forms.MenuItem
	Private refreshMetadataMenuItem As System.Windows.Forms.MenuItem
	Private editMetadataMenuItem As System.Windows.Forms.MenuItem
	Private clearMetadataMenuItem As System.Windows.Forms.MenuItem
	Private menuItem4 As System.Windows.Forms.MenuItem
	Private loadMetadataFromXMLMenuItem As System.Windows.Forms.MenuItem
	Private saveMetadataToXMLMenuItem As System.Windows.Forms.MenuItem
	Private aboutMenuItem As System.Windows.Forms.MenuItem
	Private queryStatisticsMenuItem As System.Windows.Forms.MenuItem
	Private sqlQuery1 As ActiveQueryBuilder.Core.SQLQuery
	Private sqlContext1 As ActiveQueryBuilder.Core.SQLContext
	Private databaseSchemaView1 As ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView
	Private queryView1 As ActiveQueryBuilder.View.WinForms.QueryView.QueryView
	Private sqlTextEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor
	Private queryNavigationBar1 As ActiveQueryBuilder.View.WinForms.NavigationBar.QueryNavigationBar
	Private queryColumnListControl1 As ActiveQueryBuilder.View.WinForms.QueryView.QueryColumnListControl
	Private designPaneControl1 As ActiveQueryBuilder.View.WinForms.QueryView.DesignPaneControl
	Private addObjectDialog1 As ActiveQueryBuilder.View.WinForms.QueryView.AddObjectDialog
	Private expressionEditor1 As ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor
End Class

