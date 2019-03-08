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
		Me.openMetadataFileDialog = New System.Windows.Forms.OpenFileDialog()
		Me.saveMetadataFileDialog = New System.Windows.Forms.SaveFileDialog()
		Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
		Me.menuItem1 = New System.Windows.Forms.MenuItem()
		Me.connectToMSSQLServerMenuItem = New System.Windows.Forms.MenuItem()
		Me.connectToOracleServerMenuItem = New System.Windows.Forms.MenuItem()
		Me.connectToAccessDatabaseMenuItem = New System.Windows.Forms.MenuItem()
		Me.menuItem2 = New System.Windows.Forms.MenuItem()
		Me.connectOleDbMenuItem = New System.Windows.Forms.MenuItem()
		Me.connectODBCMenuItem = New System.Windows.Forms.MenuItem()
		Me.aboutMenuItem = New System.Windows.Forms.MenuItem()
		Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
		Me.genericSyntaxProvider1 = New ActiveQueryBuilder.Core.GenericSyntaxProvider(Me.components)
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPageDirect = New System.Windows.Forms.TabPage()
		Me.btnFourthWay = New System.Windows.Forms.Button()
		Me.textBox5 = New System.Windows.Forms.TextBox()
		Me.tabPageOnDemand = New System.Windows.Forms.TabPage()
		Me.btnThirdWay = New System.Windows.Forms.Button()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		Me.tabPageExecSql = New System.Windows.Forms.TabPage()
		Me.btnFirstWay = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.tabPageDataset = New System.Windows.Forms.TabPage()
		Me.btnFifthWay = New System.Windows.Forms.Button()
		Me.textBox6 = New System.Windows.Forms.TextBox()
		Me.way3EventMetadataProvider = New ActiveQueryBuilder.Core.EventMetadataProvider(Me.components)
		Me.splitContainer1.Panel1.SuspendLayout()
		Me.splitContainer1.Panel2.SuspendLayout()
		Me.splitContainer1.SuspendLayout()
		Me.tabControl1.SuspendLayout()
		Me.tabPageDirect.SuspendLayout()
		Me.tabPageOnDemand.SuspendLayout()
		Me.tabPageExecSql.SuspendLayout()
		Me.tabPageDataset.SuspendLayout()
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
		Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.aboutMenuItem})
		' 
		' menuItem1
		' 
		Me.menuItem1.Index = 0
		Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.connectToMSSQLServerMenuItem, Me.connectToOracleServerMenuItem, Me.connectToAccessDatabaseMenuItem, Me.menuItem2, Me.connectOleDbMenuItem, Me.connectODBCMenuItem})
		Me.menuItem1.Text = "Connect"
		' 
		' connectToMSSQLServerMenuItem
		' 
		Me.connectToMSSQLServerMenuItem.Index = 0
		Me.connectToMSSQLServerMenuItem.Text = "Connect to Microsoft SQL Server"
		AddHandler Me.connectToMSSQLServerMenuItem.Click, New System.EventHandler(AddressOf Me.connectToMSSQLServerMenuItem_Click)
		' 
		' connectToOracleServerMenuItem
		' 
		Me.connectToOracleServerMenuItem.Index = 1
		Me.connectToOracleServerMenuItem.Text = "Connect to Oracle Server"
		AddHandler Me.connectToOracleServerMenuItem.Click, New System.EventHandler(AddressOf Me.connectToOracleServerMenuItem_Click)
		' 
		' connectToAccessDatabaseMenuItem
		' 
		Me.connectToAccessDatabaseMenuItem.Index = 2
		Me.connectToAccessDatabaseMenuItem.Text = "Connect to Microsoft Access database"
		AddHandler Me.connectToAccessDatabaseMenuItem.Click, New System.EventHandler(AddressOf Me.connectToAccessDatabaseMenuItem_Click)
		' 
		' menuItem2
		' 
		Me.menuItem2.Index = 3
		Me.menuItem2.Text = "-"
		' 
		' connectOleDbMenuItem
		' 
		Me.connectOleDbMenuItem.Index = 4
		Me.connectOleDbMenuItem.Text = "Connect to database through OLE DB"
		AddHandler Me.connectOleDbMenuItem.Click, New System.EventHandler(AddressOf Me.connectOleDbMenuItem_Click)
		' 
		' connectODBCMenuItem
		' 
		Me.connectODBCMenuItem.Index = 5
		Me.connectODBCMenuItem.Text = "Connect to database through ODBC"
		AddHandler Me.connectODBCMenuItem.Click, New System.EventHandler(AddressOf Me.connectODBCMenuItem_Click)
		' 
		' aboutMenuItem
		' 
		Me.aboutMenuItem.Index = 1
		Me.aboutMenuItem.Text = "About..."
		AddHandler Me.aboutMenuItem.Click, New System.EventHandler(AddressOf Me.aboutMenuItem_Click)
		' 
		' splitContainer1
		' 
		Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.splitContainer1.Location = New System.Drawing.Point(0, 149)
		Me.splitContainer1.Name = "splitContainer1"
		Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		' 
		' splitContainer1.Panel1
		' 
		Me.splitContainer1.Panel1.Controls.Add(Me.queryBuilder1)
		' 
		' splitContainer1.Panel2
		' 
		Me.splitContainer1.Panel2.Controls.Add(Me.textBox1)
		Me.splitContainer1.Size = New System.Drawing.Size(764, 455)
		Me.splitContainer1.SplitterDistance = 346
		Me.splitContainer1.TabIndex = 1
		' 
		' queryBuilder1
		' 
		Me.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.queryBuilder1.DatabaseSchemaViewOptions.ImageList = Me.imageList16
		Me.queryBuilder1.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = DirectCast(resources.GetObject("resource.PrimaryKeyIcon"), System.Drawing.Bitmap)
		Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
		Me.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.queryBuilder1.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
		Me.queryBuilder1.Location = New System.Drawing.Point(0, 0)
		Me.queryBuilder1.Name = "queryBuilder1"
		Me.queryBuilder1.Size = New System.Drawing.Size(764, 346)
		' 
		' 
		' 
		Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = False
		Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = False
		' 
		' 
		' 
		Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = True
		Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = True
		Me.queryBuilder1.SyntaxProvider = Me.genericSyntaxProvider1
		Me.queryBuilder1.TabIndex = 0
        AddHandler Me.queryBuilder1.SQLUpdated, New System.EventHandler(AddressOf Me.queryBuilder1_SQLUpdated)
		' 
		' genericSyntaxProvider1
		' 
		Me.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
		Me.genericSyntaxProvider1.OnCalcExpressionType = Nothing
		' 
		' textBox1
		' 
		Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.textBox1.HideSelection = False
		Me.textBox1.Location = New System.Drawing.Point(0, 0)
		Me.textBox1.Multiline = True
		Me.textBox1.Name = "textBox1"
		Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox1.Size = New System.Drawing.Size(764, 105)
		Me.textBox1.TabIndex = 0
		AddHandler Me.textBox1.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBox1_Validating)
		' 
		' tabControl1
		' 
		Me.tabControl1.Controls.Add(Me.tabPageDirect)
		Me.tabControl1.Controls.Add(Me.tabPageOnDemand)
		Me.tabControl1.Controls.Add(Me.tabPageExecSql)
		Me.tabControl1.Controls.Add(Me.tabPageDataset)
		Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Top
		Me.tabControl1.Location = New System.Drawing.Point(0, 0)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(764, 149)
		Me.tabControl1.TabIndex = 0
		' 
		' tabPageDirect
		' 
		Me.tabPageDirect.Controls.Add(Me.btnFourthWay)
		Me.tabPageDirect.Controls.Add(Me.textBox5)
		Me.tabPageDirect.Location = New System.Drawing.Point(4, 22)
		Me.tabPageDirect.Name = "tabPageDirect"
		Me.tabPageDirect.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageDirect.Size = New System.Drawing.Size(756, 123)
		Me.tabPageDirect.TabIndex = 3
		Me.tabPageDirect.Text = "Direct filling of MetadataContainer"
		Me.tabPageDirect.UseVisualStyleBackColor = True
		' 
		' btnFourthWay
		' 
		Me.btnFourthWay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnFourthWay.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.btnFourthWay.Location = New System.Drawing.Point(613, 94)
		Me.btnFourthWay.Name = "btnFourthWay"
		Me.btnFourthWay.Size = New System.Drawing.Size(137, 23)
		Me.btnFourthWay.TabIndex = 6
		Me.btnFourthWay.Text = "Load Metadata"
		Me.btnFourthWay.UseVisualStyleBackColor = True
		AddHandler Me.btnFourthWay.Click, New System.EventHandler(AddressOf Me.btn1Way_Click)
		' 
		' textBox5
		' 
		Me.textBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBox5.Location = New System.Drawing.Point(6, 6)
		Me.textBox5.Multiline = True
		Me.textBox5.Name = "textBox5"
		Me.textBox5.[ReadOnly] = True
		Me.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox5.Size = New System.Drawing.Size(742, 82)
		Me.textBox5.TabIndex = 5
		Me.textBox5.Text = "This method demonstrates the direct access to the internal matadata objects colle" & "ction (MetadataContainer)."
		' 
		' tabPageOnDemand
		' 
		Me.tabPageOnDemand.Controls.Add(Me.btnThirdWay)
		Me.tabPageOnDemand.Controls.Add(Me.textBox3)
		Me.tabPageOnDemand.Location = New System.Drawing.Point(4, 22)
		Me.tabPageOnDemand.Name = "tabPageOnDemand"
		Me.tabPageOnDemand.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageOnDemand.Size = New System.Drawing.Size(756, 123)
		Me.tabPageOnDemand.TabIndex = 1
		Me.tabPageOnDemand.Text = "On-demand filling using ItemMetadataLoading event"
		Me.tabPageOnDemand.UseVisualStyleBackColor = True
		' 
		' btnThirdWay
		' 
		Me.btnThirdWay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnThirdWay.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.btnThirdWay.Location = New System.Drawing.Point(611, 94)
		Me.btnThirdWay.Name = "btnThirdWay"
		Me.btnThirdWay.Size = New System.Drawing.Size(137, 23)
		Me.btnThirdWay.TabIndex = 3
		Me.btnThirdWay.Text = "Load Metadata"
		Me.btnThirdWay.UseVisualStyleBackColor = True
		AddHandler Me.btnThirdWay.Click, New System.EventHandler(AddressOf Me.btn2Way_Click)
		' 
		' textBox3
		' 
		Me.textBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBox3.Location = New System.Drawing.Point(6, 6)
		Me.textBox3.Multiline = True
		Me.textBox3.Name = "textBox3"
		Me.textBox3.[ReadOnly] = True
		Me.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox3.Size = New System.Drawing.Size(742, 82)
		Me.textBox3.TabIndex = 2
		Me.textBox3.Text = "This method demonstrates manual filling of metadata structure using MetadataConta" & "iner.ItemMetadataLoading event."
		' 
		' tabPageExecSql
		' 
		Me.tabPageExecSql.Controls.Add(Me.btnFirstWay)
		Me.tabPageExecSql.Controls.Add(Me.label1)
		Me.tabPageExecSql.Controls.Add(Me.textBox2)
		Me.tabPageExecSql.Location = New System.Drawing.Point(4, 22)
		Me.tabPageExecSql.Name = "tabPageExecSql"
		Me.tabPageExecSql.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageExecSql.Size = New System.Drawing.Size(756, 123)
		Me.tabPageExecSql.TabIndex = 0
		Me.tabPageExecSql.Text = "Using the ExecSQL event"
		Me.tabPageExecSql.UseVisualStyleBackColor = True
		' 
		' btnFirstWay
		' 
		Me.btnFirstWay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnFirstWay.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.btnFirstWay.Location = New System.Drawing.Point(611, 94)
		Me.btnFirstWay.Name = "btnFirstWay"
		Me.btnFirstWay.Size = New System.Drawing.Size(137, 23)
		Me.btnFirstWay.TabIndex = 1
		Me.btnFirstWay.Text = "Load Metadata"
		Me.btnFirstWay.UseVisualStyleBackColor = True
		AddHandler Me.btnFirstWay.Click, New System.EventHandler(AddressOf Me.btn3Way_Click)
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.ForeColor = System.Drawing.Color.OrangeRed
		Me.label1.Location = New System.Drawing.Point(3, 99)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(497, 13)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Please setup a database connection by clicking on the ""Connect"" menu item before " & "testing this method."
		' 
		' textBox2
		' 
		Me.textBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBox2.Location = New System.Drawing.Point(6, 6)
		Me.textBox2.Multiline = True
		Me.textBox2.Name = "textBox2"
		Me.textBox2.[ReadOnly] = True
		Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox2.Size = New System.Drawing.Size(742, 82)
		Me.textBox2.TabIndex = 0
		Me.textBox2.Text = resources.GetString("textBox2.Text")
		' 
		' tabPageDataset
		' 
		Me.tabPageDataset.Controls.Add(Me.btnFifthWay)
		Me.tabPageDataset.Controls.Add(Me.textBox6)
		Me.tabPageDataset.Location = New System.Drawing.Point(4, 22)
		Me.tabPageDataset.Name = "tabPageDataset"
		Me.tabPageDataset.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPageDataset.Size = New System.Drawing.Size(756, 123)
		Me.tabPageDataset.TabIndex = 4
		Me.tabPageDataset.Text = "Fill from DataSet"
		Me.tabPageDataset.UseVisualStyleBackColor = True
		' 
		' btnFifthWay
		' 
		Me.btnFifthWay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnFifthWay.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.btnFifthWay.Location = New System.Drawing.Point(613, 94)
		Me.btnFifthWay.Name = "btnFifthWay"
		Me.btnFifthWay.Size = New System.Drawing.Size(137, 23)
		Me.btnFifthWay.TabIndex = 8
		Me.btnFifthWay.Text = "Load Metadata"
		Me.btnFifthWay.UseVisualStyleBackColor = True
		AddHandler Me.btnFifthWay.Click, New System.EventHandler(AddressOf Me.btn4Way_Click)
		' 
		' textBox6
		' 
		Me.textBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBox6.Location = New System.Drawing.Point(6, 6)
		Me.textBox6.Multiline = True
		Me.textBox6.Name = "textBox6"
		Me.textBox6.[ReadOnly] = True
		Me.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.textBox6.Size = New System.Drawing.Size(742, 82)
		Me.textBox6.TabIndex = 7
		Me.textBox6.Text = "This method demonstrates manual filling of metadata structure from stored DataSet" & "."
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(764, 604)
		Me.Controls.Add(Me.splitContainer1)
		Me.Controls.Add(Me.tabControl1)
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Menu = Me.mainMenu1
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.splitContainer1.Panel1.ResumeLayout(False)
		Me.splitContainer1.Panel2.ResumeLayout(False)
		Me.splitContainer1.Panel2.PerformLayout()
		Me.splitContainer1.ResumeLayout(False)
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

	Private openMetadataFileDialog As System.Windows.Forms.OpenFileDialog
	Private saveMetadataFileDialog As System.Windows.Forms.SaveFileDialog
	Private imageList16 As System.Windows.Forms.ImageList

	Private way3EventMetadataProvider As ActiveQueryBuilder.Core.EventMetadataProvider
	Private mainMenu1 As System.Windows.Forms.MainMenu
	Private menuItem1 As System.Windows.Forms.MenuItem
	Private connectToMSSQLServerMenuItem As System.Windows.Forms.MenuItem
	Private connectToOracleServerMenuItem As System.Windows.Forms.MenuItem
	Private connectToAccessDatabaseMenuItem As System.Windows.Forms.MenuItem
	Private menuItem2 As System.Windows.Forms.MenuItem
	Private connectOleDbMenuItem As System.Windows.Forms.MenuItem
	Private connectODBCMenuItem As System.Windows.Forms.MenuItem
	Private aboutMenuItem As System.Windows.Forms.MenuItem
	Private splitContainer1 As System.Windows.Forms.SplitContainer
	Private queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private textBox1 As System.Windows.Forms.TextBox
	Private tabControl1 As System.Windows.Forms.TabControl
	Private tabPageExecSql As System.Windows.Forms.TabPage
	Private tabPageOnDemand As System.Windows.Forms.TabPage
	Private btnFirstWay As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private textBox2 As System.Windows.Forms.TextBox
	Private btnThirdWay As System.Windows.Forms.Button
	Private textBox3 As System.Windows.Forms.TextBox
	Private tabPageDirect As System.Windows.Forms.TabPage
	Private btnFourthWay As System.Windows.Forms.Button
	Private textBox5 As System.Windows.Forms.TextBox
	Private genericSyntaxProvider1 As ActiveQueryBuilder.Core.GenericSyntaxProvider
	Private tabPageDataset As System.Windows.Forms.TabPage
	Private btnFifthWay As System.Windows.Forms.Button
	Private textBox6 As System.Windows.Forms.TextBox
End Class

