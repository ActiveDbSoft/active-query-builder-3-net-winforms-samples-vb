Imports ActiveQueryBuilder.View.WinForms

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
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPageSQL = New System.Windows.Forms.TabPage()
		Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
		Me.advantageMetadataProvider1 = New ActiveQueryBuilder.Core.AdvantageMetadataProvider(Me.components)
		Me.advantageSyntaxProvider1 = New ActiveQueryBuilder.Core.AdvantageSyntaxProvider(Me.components)
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.tabPageData = New System.Windows.Forms.TabPage()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.connectMetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.metadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.refreshMetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.editMetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.clearMetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.loadFromXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.saveToXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.queryStatisticsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.openMetadataFileDialog = New System.Windows.Forms.OpenFileDialog()
		Me.saveMetadataFileDialog = New System.Windows.Forms.SaveFileDialog()
		Me.tabControl1.SuspendLayout()
		Me.tabPageSQL.SuspendLayout()
		Me.splitContainer1.Panel1.SuspendLayout()
		Me.splitContainer1.Panel2.SuspendLayout()
		Me.splitContainer1.SuspendLayout()
		Me.tabPageData.SuspendLayout()
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.menuStrip1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tabControl1
		' 
		Me.tabControl1.Controls.Add(Me.tabPageSQL)
		Me.tabControl1.Controls.Add(Me.tabPageData)
		Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabControl1.Location = New System.Drawing.Point(0, 24)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(793, 506)
		Me.tabControl1.TabIndex = 0
		AddHandler Me.tabControl1.Selected, New System.Windows.Forms.TabControlEventHandler(AddressOf Me.tabControl1_Selected)
		' 
		' tabPageSQL
		' 
		Me.tabPageSQL.Controls.Add(Me.splitContainer1)
		Me.tabPageSQL.Location = New System.Drawing.Point(4, 22)
		Me.tabPageSQL.Name = "tabPageSQL"
		Me.tabPageSQL.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageSQL.Size = New System.Drawing.Size(785, 480)
		Me.tabPageSQL.TabIndex = 0
		Me.tabPageSQL.Text = "SQL"
		Me.tabPageSQL.UseVisualStyleBackColor = True
		' 
		' splitContainer1
		' 
		Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.splitContainer1.Location = New System.Drawing.Point(3, 3)
		Me.splitContainer1.Name = "splitContainer1"
		Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		' 
		' splitContainer1.Panel1
		' 
		Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder)
		' 
		' splitContainer1.Panel2
		' 
		Me.splitContainer1.Panel2.Controls.Add(Me.textBox1)
		Me.splitContainer1.Size = New System.Drawing.Size(779, 474)
		Me.splitContainer1.SplitterDistance = 364
		Me.splitContainer1.TabIndex = 0
		' 
		' queryBuilder
		' 
		Me.queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
		Me.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill
		Me.queryBuilder.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
		Me.queryBuilder.Location = New System.Drawing.Point(0, 0)
		Me.queryBuilder.MetadataProvider = Me.advantageMetadataProvider1
		Me.queryBuilder.Name = "queryBuilder"
		Me.queryBuilder.Size = New System.Drawing.Size(779, 364)
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
		Me.queryBuilder.SyntaxProvider = Me.advantageSyntaxProvider1
		Me.queryBuilder.TabIndex = 0
		AddHandler Me.queryBuilder.SQLUpdated, New System.EventHandler(AddressOf Me.queryBuilder_SQLUpdated)
		' 
		' advantageMetadataProvider1
		' 
		Me.advantageMetadataProvider1.Connection = Nothing
		' 
		' advantageSyntaxProvider1
		' 
		Me.advantageSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
		' 
		' textBox1
		' 
		Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.textBox1.HideSelection = False
		Me.textBox1.Location = New System.Drawing.Point(0, 0)
		Me.textBox1.Multiline = True
		Me.textBox1.Name = "textBox1"
		Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox1.Size = New System.Drawing.Size(779, 106)
		Me.textBox1.TabIndex = 0
		AddHandler Me.textBox1.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBox1_Validating)
		' 
		' tabPageData
		' 
		Me.tabPageData.Controls.Add(Me.dataGridView1)
		Me.tabPageData.Location = New System.Drawing.Point(4, 22)
		Me.tabPageData.Name = "tabPageData"
		Me.tabPageData.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageData.Size = New System.Drawing.Size(785, 480)
		Me.tabPageData.TabIndex = 1
		Me.tabPageData.Text = "Data"
		Me.tabPageData.UseVisualStyleBackColor = True
		' 
		' dataGridView1
		' 
		Me.dataGridView1.AllowUserToAddRows = False
		Me.dataGridView1.AllowUserToDeleteRows = False
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dataGridView1.Location = New System.Drawing.Point(3, 3)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.[ReadOnly] = True
		Me.dataGridView1.Size = New System.Drawing.Size(779, 474)
		Me.dataGridView1.TabIndex = 0
		' 
		' menuStrip1
		' 
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.connectMetadataToolStripMenuItem, Me.metadataToolStripMenuItem, Me.queryStatisticsMenuItem, Me.aboutToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
		Me.menuStrip1.Size = New System.Drawing.Size(793, 24)
		Me.menuStrip1.TabIndex = 1
		Me.menuStrip1.Text = "menuStrip1"
		' 
		' connectMetadataToolStripMenuItem
		' 
		Me.connectMetadataToolStripMenuItem.Name = "connectMetadataToolStripMenuItem"
		Me.connectMetadataToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
		Me.connectMetadataToolStripMenuItem.Text = "Connect..."
		AddHandler Me.connectMetadataToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.connectMetadataToolStripMenuItem_Click)
		' 
		' metadataToolStripMenuItem
		' 
		Me.metadataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.refreshMetadataToolStripMenuItem, Me.editMetadataToolStripMenuItem, Me.clearMetadataToolStripMenuItem, Me.toolStripSeparator1, Me.loadFromXMLToolStripMenuItem, Me.saveToXMLToolStripMenuItem})
		Me.metadataToolStripMenuItem.Name = "metadataToolStripMenuItem"
		Me.metadataToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
		Me.metadataToolStripMenuItem.Text = "Metadata"
		' 
		' refreshMetadataToolStripMenuItem
		' 
		Me.refreshMetadataToolStripMenuItem.Name = "refreshMetadataToolStripMenuItem"
		Me.refreshMetadataToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
		Me.refreshMetadataToolStripMenuItem.Text = "Refresh Metadata"
		AddHandler Me.refreshMetadataToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.refreshMetadataToolStripMenuItem_Click)
		' 
		' editMetadataToolStripMenuItem
		' 
		Me.editMetadataToolStripMenuItem.Name = "editMetadataToolStripMenuItem"
		Me.editMetadataToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
		Me.editMetadataToolStripMenuItem.Text = "Edit Metadata..."
		AddHandler Me.editMetadataToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.editMetadataToolStripMenuItem_Click)
		' 
		' clearMetadataToolStripMenuItem
		' 
		Me.clearMetadataToolStripMenuItem.Name = "clearMetadataToolStripMenuItem"
		Me.clearMetadataToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
		Me.clearMetadataToolStripMenuItem.Text = "Clear Metadata"
		AddHandler Me.clearMetadataToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.clearMetadataToolStripMenuItem_Click)
		' 
		' toolStripSeparator1
		' 
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(163, 6)
		' 
		' loadFromXMLToolStripMenuItem
		' 
		Me.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem"
		Me.loadFromXMLToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
		Me.loadFromXMLToolStripMenuItem.Text = "Load from XML..."
		AddHandler Me.loadFromXMLToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.loadFromXMLToolStripMenuItem_Click)
		' 
		' saveToXMLToolStripMenuItem
		' 
		Me.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem"
		Me.saveToXMLToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
		Me.saveToXMLToolStripMenuItem.Text = "Save to XML..."
		AddHandler Me.saveToXMLToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.saveToXMLToolStripMenuItem_Click)
		' 
		' queryStatisticsMenuItem
		' 
		Me.queryStatisticsMenuItem.Name = "queryStatisticsMenuItem"
		Me.queryStatisticsMenuItem.Size = New System.Drawing.Size(109, 20)
		Me.queryStatisticsMenuItem.Text = "Query Statistics..."
		AddHandler Me.queryStatisticsMenuItem.Click, New System.EventHandler(AddressOf Me.queryStatisticsMenuItem_Click)
		' 
		' aboutToolStripMenuItem
		' 
		Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
		Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
		Me.aboutToolStripMenuItem.Text = "About..."
		AddHandler Me.aboutToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.aboutToolStripMenuItem_Click)
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
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(793, 530)
		Me.Controls.Add(Me.tabControl1)
		Me.Controls.Add(Me.menuStrip1)
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.tabControl1.ResumeLayout(False)
		Me.tabPageSQL.ResumeLayout(False)
		Me.splitContainer1.Panel1.ResumeLayout(False)
		Me.splitContainer1.Panel2.ResumeLayout(False)
		Me.splitContainer1.Panel2.PerformLayout()
		Me.splitContainer1.ResumeLayout(False)
		Me.tabPageData.ResumeLayout(False)
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.menuStrip1.ResumeLayout(False)
		Me.menuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private tabControl1 As System.Windows.Forms.TabControl
	Private tabPageSQL As System.Windows.Forms.TabPage
	Private tabPageData As System.Windows.Forms.TabPage
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private textBox1 As System.Windows.Forms.TextBox
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private connectMetadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private metadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private refreshMetadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private editMetadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private clearMetadataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private saveToXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private loadFromXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private openMetadataFileDialog As System.Windows.Forms.OpenFileDialog
	Private saveMetadataFileDialog As System.Windows.Forms.SaveFileDialog
	Private queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private advantageSyntaxProvider1 As ActiveQueryBuilder.Core.AdvantageSyntaxProvider
	Private advantageMetadataProvider1 As ActiveQueryBuilder.Core.AdvantageMetadataProvider
	Private queryStatisticsMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

