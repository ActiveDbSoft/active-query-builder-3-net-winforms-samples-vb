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
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.rbQuery = New System.Windows.Forms.RadioButton()
		Me.rbSubQuery = New System.Windows.Forms.RadioButton()
		Me.rbUnionSubQuery = New System.Windows.Forms.RadioButton()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.connectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.connectToMicrosoftSQLServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.connectToOracleServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.connectToMicrosoftAccessDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.connectToDatabaseThroughOLEDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.connectToDatabaseThroughODBCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPageQueryText = New System.Windows.Forms.TabPage()
		Me.tabPageResultsPreview = New System.Windows.Forms.TabPage()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.label4 = New System.Windows.Forms.Label()
		Me.menuStrip1.SuspendLayout()
		Me.tabControl1.SuspendLayout()
		Me.tabPageQueryText.SuspendLayout()
		Me.tabPageResultsPreview.SuspendLayout()
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' queryBuilder
		' 
		Me.queryBuilder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = DirectCast(resources.GetObject("resource.PrimaryKeyIcon"), System.Drawing.Bitmap)
		Me.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
		Me.queryBuilder.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
		Me.queryBuilder.Location = New System.Drawing.Point(12, 99)
		Me.queryBuilder.MetadataStructureOptions.ProceduresFolderText = Nothing
		Me.queryBuilder.MetadataStructureOptions.SynonymsFolderText = Nothing
		Me.queryBuilder.MetadataStructureOptions.TablesFolderText = Nothing
		Me.queryBuilder.MetadataStructureOptions.ViewsFolderText = Nothing
		Me.queryBuilder.Name = "queryBuilder"
		Me.queryBuilder.QueryColumnListOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.queryBuilder.Size = New System.Drawing.Size(926, 392)
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
		Me.queryBuilder.TabIndex = 3
        AddHandler Me.queryBuilder.ActiveUnionSubQueryChanged, New System.EventHandler(AddressOf Me.queryBuilder_ActiveUnionSubQueryChanged)
        AddHandler Me.queryBuilder.SQLUpdated, New System.EventHandler(AddressOf Me.queryBuilder_SQLUpdated)
		' 
		' textBox1
		' 
		Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.textBox1.Font = New System.Drawing.Font("Courier New", 9F)
		Me.textBox1.Location = New System.Drawing.Point(3, 3)
		Me.textBox1.Multiline = True
		Me.textBox1.Name = "textBox1"
		Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox1.Size = New System.Drawing.Size(912, 127)
		Me.textBox1.TabIndex = 4
		AddHandler Me.textBox1.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBox1_Validating)
		' 
		' rbQuery
		' 
		Me.rbQuery.AutoSize = True
		Me.rbQuery.ForeColor = System.Drawing.Color.Maroon
		Me.rbQuery.Location = New System.Drawing.Point(136, 27)
		Me.rbQuery.Name = "rbQuery"
		Me.rbQuery.Size = New System.Drawing.Size(72, 17)
		Me.rbQuery.TabIndex = 0
		Me.rbQuery.TabStop = True
		Me.rbQuery.Text = "Full Query"
		Me.rbQuery.UseVisualStyleBackColor = True
		AddHandler Me.rbQuery.CheckedChanged, New System.EventHandler(AddressOf Me.QueryPartChanged)
		' 
		' rbSubQuery
		' 
		Me.rbSubQuery.AutoSize = True
		Me.rbSubQuery.ForeColor = System.Drawing.Color.Maroon
		Me.rbSubQuery.Location = New System.Drawing.Point(136, 50)
		Me.rbSubQuery.Name = "rbSubQuery"
		Me.rbSubQuery.Size = New System.Drawing.Size(73, 17)
		Me.rbSubQuery.TabIndex = 1
		Me.rbSubQuery.TabStop = True
		Me.rbSubQuery.Text = "Sub-query"
		Me.rbSubQuery.UseVisualStyleBackColor = True
		AddHandler Me.rbSubQuery.CheckedChanged, New System.EventHandler(AddressOf Me.QueryPartChanged)
		' 
		' rbUnionSubQuery
		' 
		Me.rbUnionSubQuery.AutoSize = True
		Me.rbUnionSubQuery.ForeColor = System.Drawing.Color.Maroon
		Me.rbUnionSubQuery.Location = New System.Drawing.Point(136, 73)
		Me.rbUnionSubQuery.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
		Me.rbUnionSubQuery.Name = "rbUnionSubQuery"
		Me.rbUnionSubQuery.Size = New System.Drawing.Size(102, 17)
		Me.rbUnionSubQuery.TabIndex = 2
		Me.rbUnionSubQuery.TabStop = True
		Me.rbUnionSubQuery.Text = "Union sub-query"
		Me.rbUnionSubQuery.UseVisualStyleBackColor = True
		AddHandler Me.rbUnionSubQuery.CheckedChanged, New System.EventHandler(AddressOf Me.QueryPartChanged)
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(244, 75)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(627, 13)
		Me.label1.TabIndex = 5
		Me.label1.Text = "Show only tabs related to selected UNION; show text of selected UNION only. Acts " & "like the previous mode if select a sub-query tab."
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(244, 52)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(398, 13)
		Me.label2.TabIndex = 6
		Me.label2.Text = "Show only tabs related to selected sub-query; show text of selected sub-query onl" & "y."
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(244, 29)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(223, 13)
		Me.label3.TabIndex = 7
		Me.label3.Text = "Show all subquery tabs and the full query text."
		' 
		' menuStrip1
		' 
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.connectToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(950, 24)
		Me.menuStrip1.TabIndex = 8
		Me.menuStrip1.Text = "menuStrip1"
		' 
		' connectToolStripMenuItem
		' 
		Me.connectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.connectToMicrosoftSQLServerToolStripMenuItem, Me.connectToOracleServerToolStripMenuItem, Me.connectToMicrosoftAccessDatabaseToolStripMenuItem, Me.toolStripSeparator1, Me.connectToDatabaseThroughOLEDBToolStripMenuItem, Me.connectToDatabaseThroughODBCToolStripMenuItem})
		Me.connectToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.connectToolStripMenuItem.Name = "connectToolStripMenuItem"
		Me.connectToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
		Me.connectToolStripMenuItem.Text = "Connect Database"
		' 
		' connectToMicrosoftSQLServerToolStripMenuItem
		' 
		Me.connectToMicrosoftSQLServerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9F)
		Me.connectToMicrosoftSQLServerToolStripMenuItem.Name = "connectToMicrosoftSQLServerToolStripMenuItem"
		Me.connectToMicrosoftSQLServerToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
		Me.connectToMicrosoftSQLServerToolStripMenuItem.Text = "Connect to Microsoft SQL Server"
		AddHandler Me.connectToMicrosoftSQLServerToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.connectToMicrosoftSQLServerToolStripMenuItem_Click)
		' 
		' connectToOracleServerToolStripMenuItem
		' 
		Me.connectToOracleServerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9F)
		Me.connectToOracleServerToolStripMenuItem.Name = "connectToOracleServerToolStripMenuItem"
		Me.connectToOracleServerToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
		Me.connectToOracleServerToolStripMenuItem.Text = "Connect to Oracle Server"
		AddHandler Me.connectToOracleServerToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.connectToOracleServerToolStripMenuItem_Click)
		' 
		' connectToMicrosoftAccessDatabaseToolStripMenuItem
		' 
		Me.connectToMicrosoftAccessDatabaseToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9F)
		Me.connectToMicrosoftAccessDatabaseToolStripMenuItem.Name = "connectToMicrosoftAccessDatabaseToolStripMenuItem"
		Me.connectToMicrosoftAccessDatabaseToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
		Me.connectToMicrosoftAccessDatabaseToolStripMenuItem.Text = "Connect to Microsoft Access database"
		AddHandler Me.connectToMicrosoftAccessDatabaseToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.connectToMicrosoftAccessDatabaseToolStripMenuItem_Click)
		' 
		' toolStripSeparator1
		' 
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(273, 6)
		' 
		' connectToDatabaseThroughOLEDBToolStripMenuItem
		' 
		Me.connectToDatabaseThroughOLEDBToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9F)
		Me.connectToDatabaseThroughOLEDBToolStripMenuItem.Name = "connectToDatabaseThroughOLEDBToolStripMenuItem"
		Me.connectToDatabaseThroughOLEDBToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
		Me.connectToDatabaseThroughOLEDBToolStripMenuItem.Text = "Connect to database through OLE DB"
		AddHandler Me.connectToDatabaseThroughOLEDBToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.connectToDatabaseThroughOLEDBToolStripMenuItem_Click)
		' 
		' connectToDatabaseThroughODBCToolStripMenuItem
		' 
		Me.connectToDatabaseThroughODBCToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9F)
		Me.connectToDatabaseThroughODBCToolStripMenuItem.Name = "connectToDatabaseThroughODBCToolStripMenuItem"
		Me.connectToDatabaseThroughODBCToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
		Me.connectToDatabaseThroughODBCToolStripMenuItem.Text = "Connect to database through ODBC"
		AddHandler Me.connectToDatabaseThroughODBCToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.connectToDatabaseThroughODBCToolStripMenuItem_Click)
		' 
		' tabControl1
		' 
		Me.tabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tabControl1.Controls.Add(Me.tabPageQueryText)
		Me.tabControl1.Controls.Add(Me.tabPageResultsPreview)
		Me.tabControl1.Location = New System.Drawing.Point(12, 497)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(926, 159)
		Me.tabControl1.TabIndex = 9
		AddHandler Me.tabControl1.Selected, New System.Windows.Forms.TabControlEventHandler(AddressOf Me.tabControl1_Selected)
		' 
		' tabPageQueryText
		' 
		Me.tabPageQueryText.Controls.Add(Me.textBox1)
		Me.tabPageQueryText.Location = New System.Drawing.Point(4, 22)
		Me.tabPageQueryText.Name = "tabPageQueryText"
		Me.tabPageQueryText.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageQueryText.Size = New System.Drawing.Size(918, 133)
		Me.tabPageQueryText.TabIndex = 0
		Me.tabPageQueryText.Text = "Selected Query Part Text"
		Me.tabPageQueryText.UseVisualStyleBackColor = True
		' 
		' tabPageResultsPreview
		' 
		Me.tabPageResultsPreview.Controls.Add(Me.dataGridView1)
		Me.tabPageResultsPreview.Location = New System.Drawing.Point(4, 22)
		Me.tabPageResultsPreview.Name = "tabPageResultsPreview"
		Me.tabPageResultsPreview.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageResultsPreview.Size = New System.Drawing.Size(918, 133)
		Me.tabPageResultsPreview.TabIndex = 1
		Me.tabPageResultsPreview.Text = "---> Results Preview <---"
		Me.tabPageResultsPreview.UseVisualStyleBackColor = True
		' 
		' dataGridView1
		' 
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dataGridView1.Location = New System.Drawing.Point(3, 3)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(912, 127)
		Me.dataGridView1.TabIndex = 0
		' 
		' label4
		' 
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(12, 29)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(106, 13)
		Me.label4.TabIndex = 10
		Me.label4.Text = "Query part to display:"
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(950, 668)
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
		Me.menuStrip1.ResumeLayout(False)
		Me.menuStrip1.PerformLayout()
		Me.tabControl1.ResumeLayout(False)
		Me.tabPageQueryText.ResumeLayout(False)
		Me.tabPageQueryText.PerformLayout()
		Me.tabPageResultsPreview.ResumeLayout(False)
		DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private textBox1 As System.Windows.Forms.TextBox
	Private rbQuery As System.Windows.Forms.RadioButton
	Private rbSubQuery As System.Windows.Forms.RadioButton
	Private rbUnionSubQuery As System.Windows.Forms.RadioButton
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private connectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private connectToMicrosoftSQLServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private connectToOracleServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private connectToMicrosoftAccessDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private connectToDatabaseThroughOLEDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private connectToDatabaseThroughODBCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private tabControl1 As System.Windows.Forms.TabControl
	Private tabPageQueryText As System.Windows.Forms.TabPage
	Private tabPageResultsPreview As System.Windows.Forms.TabPage
	Private label4 As System.Windows.Forms.Label
	Private dataGridView1 As System.Windows.Forms.DataGridView
End Class

