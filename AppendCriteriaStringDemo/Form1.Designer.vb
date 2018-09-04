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
		Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
		Me.sql92SyntaxProvider1 = New ActiveQueryBuilder.Core.SQL92SyntaxProvider(Me.components)
		Me.msAccessSyntaxProvider1 = New ActiveQueryBuilder.Core.MSAccessSyntaxProvider(Me.components)
		Me.textBoxQuery = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.textBoxNewWhere = New System.Windows.Forms.TextBox()
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.buttonReplaceWhereAccess = New System.Windows.Forms.Button()
		Me.buttonClearWhere = New System.Windows.Forms.Button()
		Me.buttonReplaceWhereAll = New System.Windows.Forms.Button()
		Me.buttonReplaceWhere = New System.Windows.Forms.Button()
		Me.buttonAppend = New System.Windows.Forms.Button()
		Me.label2 = New System.Windows.Forms.Label()
		Me.textBoxNewWhereAccess = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' queryBuilder1
		' 
		Me.queryBuilder1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
		Me.queryBuilder1.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
		Me.queryBuilder1.Location = New System.Drawing.Point(13, 13)
		Me.queryBuilder1.Name = "queryBuilder1"
		Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 230
		Me.queryBuilder1.Size = New System.Drawing.Size(937, 343)
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
		Me.queryBuilder1.SyntaxProvider = Me.sql92SyntaxProvider1
		Me.queryBuilder1.TabIndex = 0
		AddHandler Me.queryBuilder1.SQLUpdated, New System.EventHandler(AddressOf Me.queryBuilder1_SQLUpdated)
		' 
		' msAccessSyntaxProvider1
		' 
		Me.msAccessSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
		' 
		' textBoxQuery
		' 
		Me.textBoxQuery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBoxQuery.Font = New System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.textBoxQuery.Location = New System.Drawing.Point(98, 464)
		Me.textBoxQuery.Multiline = True
		Me.textBoxQuery.Name = "textBoxQuery"
		Me.textBoxQuery.Size = New System.Drawing.Size(851, 118)
		Me.textBoxQuery.TabIndex = 1
		' 
		' label1
		' 
		Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(10, 366)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(76, 13)
		Me.label1.TabIndex = 2
		Me.label1.Text = "New WHERE:"
		' 
		' textBoxNewWhere
		' 
		Me.textBoxNewWhere.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.textBoxNewWhere.Font = New System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.textBoxNewWhere.Location = New System.Drawing.Point(98, 362)
		Me.textBoxNewWhere.Multiline = True
		Me.textBoxNewWhere.Name = "textBoxNewWhere"
		Me.textBoxNewWhere.Size = New System.Drawing.Size(236, 44)
		Me.textBoxNewWhere.TabIndex = 3
		Me.textBoxNewWhere.Text = "o.""Order Date"" > '01.01.2010'"
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tableLayoutPanel1.ColumnCount = 4
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F))
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F))
		Me.tableLayoutPanel1.Controls.Add(Me.buttonReplaceWhereAccess, 0, 1)
		Me.tableLayoutPanel1.Controls.Add(Me.buttonClearWhere, 0, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.buttonReplaceWhereAll, 3, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.buttonReplaceWhere, 2, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.buttonAppend, 1, 0)
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(340, 362)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.RowCount = 2
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(610, 94)
		Me.tableLayoutPanel1.TabIndex = 4
		' 
		' buttonReplaceWhereAccess
		' 
		Me.buttonReplaceWhereAccess.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonReplaceWhereAccess.Location = New System.Drawing.Point(3, 50)
		Me.buttonReplaceWhereAccess.Name = "buttonReplaceWhereAccess"
		Me.buttonReplaceWhereAccess.Size = New System.Drawing.Size(146, 41)
		Me.buttonReplaceWhereAccess.TabIndex = 4
		Me.buttonReplaceWhereAccess.Text = "Replace first WHERE clause"
		Me.buttonReplaceWhereAccess.UseVisualStyleBackColor = True
		AddHandler Me.buttonReplaceWhereAccess.Click, New System.EventHandler(AddressOf Me.buttonReplaceWhereAccess_Click)
		' 
		' buttonClearWhere
		' 
		Me.buttonClearWhere.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonClearWhere.Location = New System.Drawing.Point(3, 3)
		Me.buttonClearWhere.Name = "buttonClearWhere"
		Me.buttonClearWhere.Size = New System.Drawing.Size(146, 41)
		Me.buttonClearWhere.TabIndex = 0
		Me.buttonClearWhere.Text = "Clear first WHERE clause"
		Me.buttonClearWhere.UseVisualStyleBackColor = True
		AddHandler Me.buttonClearWhere.Click, New System.EventHandler(AddressOf Me.buttonClearWhere_Click)
		' 
		' buttonReplaceWhereAll
		' 
		Me.buttonReplaceWhereAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonReplaceWhereAll.Location = New System.Drawing.Point(459, 3)
		Me.buttonReplaceWhereAll.Name = "buttonReplaceWhereAll"
		Me.buttonReplaceWhereAll.Size = New System.Drawing.Size(148, 41)
		Me.buttonReplaceWhereAll.TabIndex = 3
		Me.buttonReplaceWhereAll.Text = "Replace all WHERE clauses"
		Me.buttonReplaceWhereAll.UseVisualStyleBackColor = True
		AddHandler Me.buttonReplaceWhereAll.Click, New System.EventHandler(AddressOf Me.buttonReplaceWhereAll_Click)
		' 
		' buttonReplaceWhere
		' 
		Me.buttonReplaceWhere.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonReplaceWhere.Location = New System.Drawing.Point(307, 3)
		Me.buttonReplaceWhere.Name = "buttonReplaceWhere"
		Me.buttonReplaceWhere.Size = New System.Drawing.Size(146, 41)
		Me.buttonReplaceWhere.TabIndex = 1
		Me.buttonReplaceWhere.Text = "Replace first WHERE clause"
		Me.buttonReplaceWhere.UseVisualStyleBackColor = True
		AddHandler Me.buttonReplaceWhere.Click, New System.EventHandler(AddressOf Me.buttonReplaceWhere_Click)
		' 
		' buttonAppend
		' 
		Me.buttonAppend.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonAppend.Location = New System.Drawing.Point(155, 3)
		Me.buttonAppend.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
		Me.buttonAppend.Name = "buttonAppend"
		Me.buttonAppend.Size = New System.Drawing.Size(149, 41)
		Me.buttonAppend.TabIndex = 2
		Me.buttonAppend.Text = "Append to first WHERE clause"
		Me.buttonAppend.UseVisualStyleBackColor = True
		AddHandler Me.buttonAppend.Click, New System.EventHandler(AddressOf Me.buttonAppend_Click)
		' 
		' label2
		' 
		Me.label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(10, 468)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(73, 13)
		Me.label2.TabIndex = 5
		Me.label2.Text = "Source query:"
		' 
		' textBoxNewWhereAccess
		' 
		Me.textBoxNewWhereAccess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.textBoxNewWhereAccess.Font = New System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.textBoxNewWhereAccess.Location = New System.Drawing.Point(98, 412)
		Me.textBoxNewWhereAccess.Multiline = True
		Me.textBoxNewWhereAccess.Name = "textBoxNewWhereAccess"
		Me.textBoxNewWhereAccess.Size = New System.Drawing.Size(236, 44)
		Me.textBoxNewWhereAccess.TabIndex = 6
		Me.textBoxNewWhereAccess.Text = "o.[Order Date] > #01.01.2011#"
		' 
		' label3
		' 
		Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.label3.AutoSize = True
		Me.label3.Location = New System.Drawing.Point(10, 416)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(76, 13)
		Me.label3.TabIndex = 7
		Me.label3.Text = "New WHERE:"
		' 
		' label4
		' 
		Me.label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.label4.AutoSize = True
		Me.label4.Location = New System.Drawing.Point(10, 432)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(88, 13)
		Me.label4.TabIndex = 8
		Me.label4.Text = "(ACCESS syntax)"
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(962, 594)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.textBoxNewWhereAccess)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.Controls.Add(Me.textBoxNewWhere)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textBoxQuery)
		Me.Controls.Add(Me.queryBuilder1)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Append Criteria String Demo"
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private textBoxQuery As System.Windows.Forms.TextBox
	Private sql92SyntaxProvider1 As ActiveQueryBuilder.Core.SQL92SyntaxProvider
	Private msAccessSyntaxProvider1 As ActiveQueryBuilder.Core.MSAccessSyntaxProvider
	Private label1 As System.Windows.Forms.Label
	Private textBoxNewWhere As System.Windows.Forms.TextBox
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private buttonAppend As System.Windows.Forms.Button
	Private buttonReplaceWhere As System.Windows.Forms.Button
	Private buttonClearWhere As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private textBoxNewWhereAccess As System.Windows.Forms.TextBox
	Private buttonReplaceWhereAll As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private buttonReplaceWhereAccess As System.Windows.Forms.Button
End Class

