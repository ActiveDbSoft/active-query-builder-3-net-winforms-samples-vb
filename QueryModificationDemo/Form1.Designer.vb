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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbOrderDate = New System.Windows.Forms.TextBox()
        Me.cbOrderDate = New System.Windows.Forms.CheckBox()
        Me.cbOrders = New System.Windows.Forms.CheckBox()
        Me.tbCompanyName = New System.Windows.Forms.TextBox()
        Me.cbCompanyName = New System.Windows.Forms.CheckBox()
        Me.cbCustomers = New System.Windows.Forms.CheckBox()
        Me.btnQueryCustomersOrders = New System.Windows.Forms.Button()
        Me.btnQueryOrders = New System.Windows.Forms.Button()
        Me.btnQueryCustomers = New System.Windows.Forms.Button()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.tbSQL = New System.Windows.Forms.TextBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.QueryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.genericSyntaxProvider1 = New ActiveQueryBuilder.Core.GenericSyntaxProvider(Me.components)
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Location = New System.Drawing.Point(5, 5)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(923, 44)
        Me.label1.TabIndex = 0
        Me.label1.Text = resources.GetString("label1.Text")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.btnApply)
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Controls.Add(Me.btnQueryCustomersOrders)
        Me.panel1.Controls.Add(Me.btnQueryOrders)
        Me.panel1.Controls.Add(Me.btnQueryCustomers)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(5, 469)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(923, 160)
        Me.panel1.TabIndex = 2
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnApply.Location = New System.Drawing.Point(782, 137)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(141, 23)
        Me.btnApply.TabIndex = 4
        Me.btnApply.Text = "Apply Changes"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.tbOrderDate)
        Me.groupBox1.Controls.Add(Me.cbOrderDate)
        Me.groupBox1.Controls.Add(Me.cbOrders)
        Me.groupBox1.Controls.Add(Me.tbCompanyName)
        Me.groupBox1.Controls.Add(Me.cbCompanyName)
        Me.groupBox1.Controls.Add(Me.cbCustomers)
        Me.groupBox1.Location = New System.Drawing.Point(0, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBox1.Size = New System.Drawing.Size(776, 154)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Modification Settings:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.DimGray
        Me.label2.Location = New System.Drawing.Point(5, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(208, 26)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Check tables you wish to add to the query." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Check fields you wish to define crite" & _
    "ria for."
        '
        'tbOrderDate
        '
        Me.tbOrderDate.Enabled = False
        Me.tbOrderDate.Location = New System.Drawing.Point(131, 123)
        Me.tbOrderDate.Name = "tbOrderDate"
        Me.tbOrderDate.Size = New System.Drawing.Size(231, 20)
        Me.tbOrderDate.TabIndex = 5
        Me.tbOrderDate.Text = "= '01/01/2007'"
        '
        'cbOrderDate
        '
        Me.cbOrderDate.AutoSize = True
        Me.cbOrderDate.Enabled = False
        Me.cbOrderDate.Location = New System.Drawing.Point(27, 125)
        Me.cbOrderDate.Name = "cbOrderDate"
        Me.cbOrderDate.Size = New System.Drawing.Size(75, 17)
        Me.cbOrderDate.TabIndex = 4
        Me.cbOrderDate.Text = "OrderDate"
        Me.cbOrderDate.UseVisualStyleBackColor = True
        '
        'cbOrders
        '
        Me.cbOrders.AutoSize = True
        Me.cbOrders.Location = New System.Drawing.Point(8, 102)
        Me.cbOrders.Name = "cbOrders"
        Me.cbOrders.Size = New System.Drawing.Size(57, 17)
        Me.cbOrders.TabIndex = 3
        Me.cbOrders.Text = "Orders"
        Me.cbOrders.UseVisualStyleBackColor = True
        '
        'tbCompanyName
        '
        Me.tbCompanyName.Enabled = False
        Me.tbCompanyName.Location = New System.Drawing.Point(131, 77)
        Me.tbCompanyName.Name = "tbCompanyName"
        Me.tbCompanyName.Size = New System.Drawing.Size(231, 20)
        Me.tbCompanyName.TabIndex = 2
        Me.tbCompanyName.Text = "Like 'C%'"
        '
        'cbCompanyName
        '
        Me.cbCompanyName.AutoSize = True
        Me.cbCompanyName.Enabled = False
        Me.cbCompanyName.Location = New System.Drawing.Point(27, 79)
        Me.cbCompanyName.Name = "cbCompanyName"
        Me.cbCompanyName.Size = New System.Drawing.Size(98, 17)
        Me.cbCompanyName.TabIndex = 1
        Me.cbCompanyName.Text = "CompanyName"
        Me.cbCompanyName.UseVisualStyleBackColor = True
        '
        'cbCustomers
        '
        Me.cbCustomers.AutoSize = True
        Me.cbCustomers.Location = New System.Drawing.Point(8, 56)
        Me.cbCustomers.Name = "cbCustomers"
        Me.cbCustomers.Size = New System.Drawing.Size(75, 17)
        Me.cbCustomers.TabIndex = 0
        Me.cbCustomers.Text = "Customers"
        Me.cbCustomers.UseVisualStyleBackColor = True
        '
        'btnQueryCustomersOrders
        '
        Me.btnQueryCustomersOrders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQueryCustomersOrders.Location = New System.Drawing.Point(782, 69)
        Me.btnQueryCustomersOrders.Name = "btnQueryCustomersOrders"
        Me.btnQueryCustomersOrders.Size = New System.Drawing.Size(141, 23)
        Me.btnQueryCustomersOrders.TabIndex = 2
        Me.btnQueryCustomersOrders.Text = "Load Sample Query 3"
        Me.btnQueryCustomersOrders.UseVisualStyleBackColor = True
        '
        'btnQueryOrders
        '
        Me.btnQueryOrders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQueryOrders.Location = New System.Drawing.Point(782, 40)
        Me.btnQueryOrders.Name = "btnQueryOrders"
        Me.btnQueryOrders.Size = New System.Drawing.Size(141, 23)
        Me.btnQueryOrders.TabIndex = 1
        Me.btnQueryOrders.Text = "Load Sample Query 2"
        Me.btnQueryOrders.UseVisualStyleBackColor = True
        '
        'btnQueryCustomers
        '
        Me.btnQueryCustomers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQueryCustomers.Location = New System.Drawing.Point(782, 11)
        Me.btnQueryCustomers.Name = "btnQueryCustomers"
        Me.btnQueryCustomers.Size = New System.Drawing.Size(141, 23)
        Me.btnQueryCustomers.TabIndex = 0
        Me.btnQueryCustomers.Text = "Load Sample Query 1"
        Me.btnQueryCustomers.UseVisualStyleBackColor = True
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Location = New System.Drawing.Point(5, 49)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(923, 420)
        Me.tabControl1.TabIndex = 1
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.tbSQL)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(915, 394)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "SQL Text"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'tbSQL
        '
        Me.tbSQL.AcceptsReturn = True
        Me.tbSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSQL.HideSelection = False
        Me.tbSQL.Location = New System.Drawing.Point(3, 3)
        Me.tbSQL.Multiline = True
        Me.tbSQL.Name = "tbSQL"
        Me.tbSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbSQL.Size = New System.Drawing.Size(909, 388)
        Me.tbSQL.TabIndex = 0
        '
        'tabPage2
        '
        Me.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabPage2.Controls.Add(Me.QueryBuilder1)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(915, 394)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Query Builder"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'QueryBuilder1
        '
        Me.QueryBuilder1.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = False
        Me.QueryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.QueryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueryBuilder1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.QueryBuilder1.Location = New System.Drawing.Point(3, 3)
        Me.QueryBuilder1.MetadataStructureOptions.ProceduresFolderText = "Procedures"
        Me.QueryBuilder1.MetadataStructureOptions.SynonymsFolderText = "Synonyms"
        Me.QueryBuilder1.MetadataStructureOptions.TablesFolderText = "Tables"
        Me.QueryBuilder1.MetadataStructureOptions.ViewsFolderText = "Views"
        Me.QueryBuilder1.Name = "QueryBuilder1"
        Me.QueryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 166       
        Me.QueryBuilder1.Size = New System.Drawing.Size(907, 386)
        '
        '
        '
        Me.QueryBuilder1.SQLFormattingOptions.ExpandVirtualFields = False
        Me.QueryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = False
        Me.QueryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = False
        Me.QueryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = False
        '
        '
        '
        Me.QueryBuilder1.SQLGenerationOptions.ExpandVirtualFields = True
        Me.QueryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = True
        Me.QueryBuilder1.SQLGenerationOptions.UseAltNames = False
        Me.QueryBuilder1.SyntaxProvider = Me.genericSyntaxProvider1
        Me.QueryBuilder1.TabIndex = 0
        '
        'genericSyntaxProvider1
        '
        Me.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
        Me.genericSyntaxProvider1.OnCalcExpressionType = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 634)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Query Modification Demo"
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

	#End Region

	Private label1 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel
	Private tabControl1 As System.Windows.Forms.TabControl
	Private tabPage1 As System.Windows.Forms.TabPage
	Private tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents tbSQL As System.Windows.Forms.TextBox
    Private WithEvents btnApply As System.Windows.Forms.Button
	Private groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnQueryCustomersOrders As System.Windows.Forms.Button
    Private WithEvents btnQueryOrders As System.Windows.Forms.Button
    Private WithEvents btnQueryCustomers As System.Windows.Forms.Button
	Private tbOrderDate As System.Windows.Forms.TextBox
    Private WithEvents cbOrderDate As System.Windows.Forms.CheckBox
    Private WithEvents cbOrders As System.Windows.Forms.CheckBox
	Private tbCompanyName As System.Windows.Forms.TextBox
    Private WithEvents cbCompanyName As System.Windows.Forms.CheckBox
    Private WithEvents cbCustomers As System.Windows.Forms.CheckBox
	Private label2 As System.Windows.Forms.Label
    Private genericSyntaxProvider1 As ActiveQueryBuilder.Core.GenericSyntaxProvider
    Friend WithEvents QueryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder

End Class

