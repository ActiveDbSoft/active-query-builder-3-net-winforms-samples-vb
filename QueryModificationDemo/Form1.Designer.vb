


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
        Me.label1 = New Label()
        Me.panel1 = New Panel()
        Me.btnApply = New Button()
        Me.groupBox1 = New GroupBox()
        Me.label2 = New Label()
        Me.tbOrderDate = New TextBox()
        Me.cbOrderDate = New CheckBox()
        Me.cbOrders = New CheckBox()
        Me.tbCompanyName = New TextBox()
        Me.cbCompanyName = New CheckBox()
        Me.cbCustomers = New CheckBox()
        Me.btnQueryCustomersOrders = New Button()
        Me.btnQueryOrders = New Button()
        Me.btnQueryCustomers = New Button()
        Me.tabControl1 = New TabControl()
        Me.tabPage1 = New TabPage()
        Me.tbSQL = New TextBox()
        Me.tabPage2 = New TabPage()
        Me.genericSyntaxProvider1 = New ActiveQueryBuilder.Core.GenericSyntaxProvider(Me.components)
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' label1
        ' 
        Me.label1.Dock = DockStyle.Top
        Me.label1.Location = New Point(5, 5)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(923, 44)
        Me.label1.TabIndex = 0
        Me.label1.Text = resources.GetString("label1.Text")
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.btnApply)
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Controls.Add(Me.btnQueryCustomersOrders)
        Me.panel1.Controls.Add(Me.btnQueryOrders)
        Me.panel1.Controls.Add(Me.btnQueryCustomers)
        Me.panel1.Dock = DockStyle.Bottom
        Me.panel1.Location = New Point(5, 469)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New Size(923, 160)
        Me.panel1.TabIndex = 2
        ' 
        ' btnApply
        ' 
        Me.btnApply.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.btnApply.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.btnApply.Location = New Point(782, 137)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New Size(141, 23)
        Me.btnApply.TabIndex = 4
        Me.btnApply.Text = "Apply Changes"
        Me.btnApply.UseVisualStyleBackColor = True
'			Me.btnApply.Click += New System.EventHandler(Me.btnApply_Click)
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.tbOrderDate)
        Me.groupBox1.Controls.Add(Me.cbOrderDate)
        Me.groupBox1.Controls.Add(Me.cbOrders)
        Me.groupBox1.Controls.Add(Me.tbCompanyName)
        Me.groupBox1.Controls.Add(Me.cbCompanyName)
        Me.groupBox1.Controls.Add(Me.cbCustomers)
        Me.groupBox1.Location = New Point(0, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New Padding(5)
        Me.groupBox1.Size = New Size(776, 154)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Modification Settings:"
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.ForeColor = Color.DimGray
        Me.label2.Location = New Point(5, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New Size(208, 26)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Check tables you wish to add to the query." & vbCrLf & "Check fields you wish to define crite" & "ria for."
        ' 
        ' tbOrderDate
        ' 
        Me.tbOrderDate.Enabled = False
        Me.tbOrderDate.Location = New Point(131, 123)
        Me.tbOrderDate.Name = "tbOrderDate"
        Me.tbOrderDate.Size = New Size(231, 20)
        Me.tbOrderDate.TabIndex = 5
        Me.tbOrderDate.Text = "= '01/01/2007'"
        ' 
        ' cbOrderDate
        ' 
        Me.cbOrderDate.AutoSize = True
        Me.cbOrderDate.Enabled = False
        Me.cbOrderDate.Location = New Point(27, 125)
        Me.cbOrderDate.Name = "cbOrderDate"
        Me.cbOrderDate.Size = New Size(75, 17)
        Me.cbOrderDate.TabIndex = 4
        Me.cbOrderDate.Text = "OrderDate"
        Me.cbOrderDate.UseVisualStyleBackColor = True
'			Me.cbOrderDate.CheckedChanged += New System.EventHandler(Me.cbOrderDate_CheckedChanged)
        ' 
        ' cbOrders
        ' 
        Me.cbOrders.AutoSize = True
        Me.cbOrders.Location = New Point(8, 102)
        Me.cbOrders.Name = "cbOrders"
        Me.cbOrders.Size = New Size(57, 17)
        Me.cbOrders.TabIndex = 3
        Me.cbOrders.Text = "Orders"
        Me.cbOrders.UseVisualStyleBackColor = True
'			Me.cbOrders.CheckedChanged += New System.EventHandler(Me.cbOrders_CheckedChanged)
        ' 
        ' tbCompanyName
        ' 
        Me.tbCompanyName.Enabled = False
        Me.tbCompanyName.Location = New Point(131, 77)
        Me.tbCompanyName.Name = "tbCompanyName"
        Me.tbCompanyName.Size = New Size(231, 20)
        Me.tbCompanyName.TabIndex = 2
        Me.tbCompanyName.Text = "Like 'C%'"
        ' 
        ' cbCompanyName
        ' 
        Me.cbCompanyName.AutoSize = True
        Me.cbCompanyName.Enabled = False
        Me.cbCompanyName.Location = New Point(27, 79)
        Me.cbCompanyName.Name = "cbCompanyName"
        Me.cbCompanyName.Size = New Size(98, 17)
        Me.cbCompanyName.TabIndex = 1
        Me.cbCompanyName.Text = "CompanyName"
        Me.cbCompanyName.UseVisualStyleBackColor = True
'			Me.cbCompanyName.CheckedChanged += New System.EventHandler(Me.cbCompanyName_CheckedChanged)
        ' 
        ' cbCustomers
        ' 
        Me.cbCustomers.AutoSize = True
        Me.cbCustomers.Location = New Point(8, 56)
        Me.cbCustomers.Name = "cbCustomers"
        Me.cbCustomers.Size = New Size(75, 17)
        Me.cbCustomers.TabIndex = 0
        Me.cbCustomers.Text = "Customers"
        Me.cbCustomers.UseVisualStyleBackColor = True
'			Me.cbCustomers.CheckedChanged += New System.EventHandler(Me.cbCustomers_CheckedChanged)
        ' 
        ' btnQueryCustomersOrders
        ' 
        Me.btnQueryCustomersOrders.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
        Me.btnQueryCustomersOrders.Location = New Point(782, 69)
        Me.btnQueryCustomersOrders.Name = "btnQueryCustomersOrders"
        Me.btnQueryCustomersOrders.Size = New Size(141, 23)
        Me.btnQueryCustomersOrders.TabIndex = 2
        Me.btnQueryCustomersOrders.Text = "Load Sample Query 3"
        Me.btnQueryCustomersOrders.UseVisualStyleBackColor = True
'			Me.btnQueryCustomersOrders.Click += New System.EventHandler(Me.btnQueryCustomersOrders_Click)
        ' 
        ' btnQueryOrders
        ' 
        Me.btnQueryOrders.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
        Me.btnQueryOrders.Location = New Point(782, 40)
        Me.btnQueryOrders.Name = "btnQueryOrders"
        Me.btnQueryOrders.Size = New Size(141, 23)
        Me.btnQueryOrders.TabIndex = 1
        Me.btnQueryOrders.Text = "Load Sample Query 2"
        Me.btnQueryOrders.UseVisualStyleBackColor = True
'			Me.btnQueryOrders.Click += New System.EventHandler(Me.btnQueryOrders_Click)
        ' 
        ' btnQueryCustomers
        ' 
        Me.btnQueryCustomers.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
        Me.btnQueryCustomers.Location = New Point(782, 11)
        Me.btnQueryCustomers.Name = "btnQueryCustomers"
        Me.btnQueryCustomers.Size = New Size(141, 23)
        Me.btnQueryCustomers.TabIndex = 0
        Me.btnQueryCustomers.Text = "Load Sample Query 1"
        Me.btnQueryCustomers.UseVisualStyleBackColor = True
'			Me.btnQueryCustomers.Click += New System.EventHandler(Me.btnQueryCustomers_Click)
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Dock = DockStyle.Fill
        Me.tabControl1.Location = New Point(5, 49)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New Size(923, 420)
        Me.tabControl1.TabIndex = 1
        ' 
        ' tabPage1
        ' 
        Me.tabPage1.Controls.Add(Me.tbSQL)
        Me.tabPage1.Location = New Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New Padding(3)
        Me.tabPage1.Size = New Size(915, 394)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "SQL Text"
        Me.tabPage1.UseVisualStyleBackColor = True
        ' 
        ' tbSQL
        ' 
        Me.tbSQL.AcceptsReturn = True
        Me.tbSQL.Dock = DockStyle.Fill
        Me.tbSQL.HideSelection = False
        Me.tbSQL.Location = New Point(3, 3)
        Me.tbSQL.Multiline = True
        Me.tbSQL.Name = "tbSQL"
        Me.tbSQL.ScrollBars = ScrollBars.Both
        Me.tbSQL.Size = New Size(909, 388)
        Me.tbSQL.TabIndex = 0
'			Me.tbSQL.Validating += New System.ComponentModel.CancelEventHandler(Me.tbSQL_Validating)
        ' 
        ' tabPage2
        ' 
        Me.tabPage2.BorderStyle = BorderStyle.FixedSingle
        Me.tabPage2.Controls.Add(Me.queryBuilder1)
        Me.tabPage2.Location = New Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New Padding(3)
        Me.tabPage2.Size = New Size(915, 394)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Query Builder"
        Me.tabPage2.UseVisualStyleBackColor = True
        ' 
        ' genericSyntaxProvider1
        ' 
        Me.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
        Me.genericSyntaxProvider1.OnCalcExpressionType = Nothing
        ' 
        ' queryBuilder1
        ' 
        Me.queryBuilder1.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = False
        Me.queryBuilder1.BorderStyle = BorderStyle.FixedSingle
        Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder1.Dock = DockStyle.Fill
        Me.queryBuilder1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.World)
        Me.queryBuilder1.Location = New Point(3, 3)
        Me.queryBuilder1.MetadataStructureOptions.ProceduresFolderText = "Procedures"
        Me.queryBuilder1.MetadataStructureOptions.SynonymsFolderText = "Synonyms"
        Me.queryBuilder1.MetadataStructureOptions.TablesFolderText = "Tables"
        Me.queryBuilder1.MetadataStructureOptions.ViewsFolderText = "Views"
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.Size = New Size(907, 386)
        ' 
        ' 
        ' 
        Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = False
        Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = False
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = False
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = False
        ' 
        ' 
        ' 
        Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = True
        Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = True
        Me.queryBuilder1.SQLGenerationOptions.UseAltNames = False
        Me.queryBuilder1.SyntaxProvider = Me.genericSyntaxProvider1
        Me.queryBuilder1.TabIndex = 3
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(933, 634)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Padding = New Padding(5)
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

    Private label1 As Label
    Private panel1 As Panel
    Private tabControl1 As TabControl
    Private tabPage1 As TabPage
    Private tabPage2 As TabPage
    Private WithEvents tbSQL As TextBox
    Private WithEvents btnApply As Button
    Private groupBox1 As GroupBox
    Private WithEvents btnQueryCustomersOrders As Button
    Private WithEvents btnQueryOrders As Button
    Private WithEvents btnQueryCustomers As Button
    Private tbOrderDate As TextBox
    Private WithEvents cbOrderDate As CheckBox
    Private WithEvents cbOrders As CheckBox
    Private tbCompanyName As TextBox
    Private WithEvents cbCompanyName As CheckBox
    Private WithEvents cbCustomers As CheckBox
    Private label2 As Label
    Private genericSyntaxProvider1 As ActiveQueryBuilder.Core.GenericSyntaxProvider
    Private queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder

End Class