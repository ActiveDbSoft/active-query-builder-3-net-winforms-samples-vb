
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
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.sql92SyntaxProvider1 = New ActiveQueryBuilder.Core.SQL92SyntaxProvider(Me.components)
        Me.msAccessSyntaxProvider1 = New ActiveQueryBuilder.Core.MSAccessSyntaxProvider(Me.components)
        Me.textBoxQuery = New TextBox()
        Me.label1 = New Label()
        Me.textBoxNewWhere = New TextBox()
        Me.tableLayoutPanel1 = New TableLayoutPanel()
        Me.buttonReplaceWhereAccess = New Button()
        Me.buttonClearWhere = New Button()
        Me.buttonReplaceWhereAll = New Button()
        Me.buttonReplaceWhere = New Button()
        Me.buttonAppend = New Button()
        Me.label2 = New Label()
        Me.textBoxNewWhereAccess = New TextBox()
        Me.label3 = New Label()
        Me.label4 = New Label()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' queryBuilder1
        ' 
        Me.queryBuilder1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.queryBuilder1.BorderStyle = BorderStyle.FixedSingle
        Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Me.queryBuilder1.Location = New Point(13, 13)
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 230
        Me.queryBuilder1.Size = New Size(937, 343)
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
'            Me.queryBuilder1.SQLUpdated += New System.EventHandler(Me.queryBuilder1_SQLUpdated)
        ' 
        ' msAccessSyntaxProvider1
        ' 
        Me.msAccessSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
        ' 
        ' textBoxQuery
        ' 
        Me.textBoxQuery.Anchor = (CType(((AnchorStyles.Bottom Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textBoxQuery.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.textBoxQuery.Location = New Point(98, 464)
        Me.textBoxQuery.Multiline = True
        Me.textBoxQuery.Name = "textBoxQuery"
        Me.textBoxQuery.Size = New Size(851, 118)
        Me.textBoxQuery.TabIndex = 1
        ' 
        ' label1
        ' 
        Me.label1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
        Me.label1.AutoSize = True
        Me.label1.Location = New Point(10, 366)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(76, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "New WHERE:"
        ' 
        ' textBoxNewWhere
        ' 
        Me.textBoxNewWhere.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
        Me.textBoxNewWhere.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.textBoxNewWhere.Location = New Point(98, 362)
        Me.textBoxNewWhere.Multiline = True
        Me.textBoxNewWhere.Name = "textBoxNewWhere"
        Me.textBoxNewWhere.Size = New Size(236, 44)
        Me.textBoxNewWhere.TabIndex = 3
        Me.textBoxNewWhere.Text = "o.""Order Date"" > '01.01.2010'"
        ' 
        ' tableLayoutPanel1
        ' 
        Me.tableLayoutPanel1.Anchor = (CType(((AnchorStyles.Bottom Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tableLayoutPanel1.ColumnCount = 4
        Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        Me.tableLayoutPanel1.Controls.Add(Me.buttonReplaceWhereAccess, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.buttonClearWhere, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.buttonReplaceWhereAll, 3, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.buttonReplaceWhere, 2, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.buttonAppend, 1, 0)
        Me.tableLayoutPanel1.Location = New Point(340, 362)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        Me.tableLayoutPanel1.Size = New Size(610, 94)
        Me.tableLayoutPanel1.TabIndex = 4
        ' 
        ' buttonReplaceWhereAccess
        ' 
        Me.buttonReplaceWhereAccess.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.buttonReplaceWhereAccess.Location = New Point(3, 50)
        Me.buttonReplaceWhereAccess.Name = "buttonReplaceWhereAccess"
        Me.buttonReplaceWhereAccess.Size = New Size(146, 41)
        Me.buttonReplaceWhereAccess.TabIndex = 4
        Me.buttonReplaceWhereAccess.Text = "Replace first WHERE clause"
        Me.buttonReplaceWhereAccess.UseVisualStyleBackColor = True
'            Me.buttonReplaceWhereAccess.Click += New System.EventHandler(Me.buttonReplaceWhereAccess_Click)
        ' 
        ' buttonClearWhere
        ' 
        Me.buttonClearWhere.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.buttonClearWhere.Location = New Point(3, 3)
        Me.buttonClearWhere.Name = "buttonClearWhere"
        Me.buttonClearWhere.Size = New Size(146, 41)
        Me.buttonClearWhere.TabIndex = 0
        Me.buttonClearWhere.Text = "Clear first WHERE clause"
        Me.buttonClearWhere.UseVisualStyleBackColor = True
'            Me.buttonClearWhere.Click += New System.EventHandler(Me.buttonClearWhere_Click)
        ' 
        ' buttonReplaceWhereAll
        ' 
        Me.buttonReplaceWhereAll.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.buttonReplaceWhereAll.Location = New Point(459, 3)
        Me.buttonReplaceWhereAll.Name = "buttonReplaceWhereAll"
        Me.buttonReplaceWhereAll.Size = New Size(148, 41)
        Me.buttonReplaceWhereAll.TabIndex = 3
        Me.buttonReplaceWhereAll.Text = "Replace all WHERE clauses"
        Me.buttonReplaceWhereAll.UseVisualStyleBackColor = True
'            Me.buttonReplaceWhereAll.Click += New System.EventHandler(Me.buttonReplaceWhereAll_Click)
        ' 
        ' buttonReplaceWhere
        ' 
        Me.buttonReplaceWhere.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.buttonReplaceWhere.Location = New Point(307, 3)
        Me.buttonReplaceWhere.Name = "buttonReplaceWhere"
        Me.buttonReplaceWhere.Size = New Size(146, 41)
        Me.buttonReplaceWhere.TabIndex = 1
        Me.buttonReplaceWhere.Text = "Replace first WHERE clause"
        Me.buttonReplaceWhere.UseVisualStyleBackColor = True
'            Me.buttonReplaceWhere.Click += New System.EventHandler(Me.buttonReplaceWhere_Click)
        ' 
        ' buttonAppend
        ' 
        Me.buttonAppend.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.buttonAppend.Location = New Point(155, 3)
        Me.buttonAppend.Margin = New Padding(3, 3, 0, 3)
        Me.buttonAppend.Name = "buttonAppend"
        Me.buttonAppend.Size = New Size(149, 41)
        Me.buttonAppend.TabIndex = 2
        Me.buttonAppend.Text = "Append to first WHERE clause"
        Me.buttonAppend.UseVisualStyleBackColor = True
'            Me.buttonAppend.Click += New System.EventHandler(Me.buttonAppend_Click)
        ' 
        ' label2
        ' 
        Me.label2.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
        Me.label2.AutoSize = True
        Me.label2.Location = New Point(10, 468)
        Me.label2.Name = "label2"
        Me.label2.Size = New Size(73, 13)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Source query:"
        ' 
        ' textBoxNewWhereAccess
        ' 
        Me.textBoxNewWhereAccess.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
        Me.textBoxNewWhereAccess.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.textBoxNewWhereAccess.Location = New Point(98, 412)
        Me.textBoxNewWhereAccess.Multiline = True
        Me.textBoxNewWhereAccess.Name = "textBoxNewWhereAccess"
        Me.textBoxNewWhereAccess.Size = New Size(236, 44)
        Me.textBoxNewWhereAccess.TabIndex = 6
        Me.textBoxNewWhereAccess.Text = "o.[Order Date] > #01.01.2011#"
        ' 
        ' label3
        ' 
        Me.label3.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
        Me.label3.AutoSize = True
        Me.label3.Location = New Point(10, 416)
        Me.label3.Name = "label3"
        Me.label3.Size = New Size(76, 13)
        Me.label3.TabIndex = 7
        Me.label3.Text = "New WHERE:"
        ' 
        ' label4
        ' 
        Me.label4.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
        Me.label4.AutoSize = True
        Me.label4.Location = New Point(10, 432)
        Me.label4.Name = "label4"
        Me.label4.Size = New Size(88, 13)
        Me.label4.TabIndex = 8
        Me.label4.Text = "(ACCESS syntax)"
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(962, 594)
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
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Append Criteria String Demo"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private textBoxQuery As TextBox
    Private sql92SyntaxProvider1 As ActiveQueryBuilder.Core.SQL92SyntaxProvider
    Private msAccessSyntaxProvider1 As ActiveQueryBuilder.Core.MSAccessSyntaxProvider
    Private label1 As Label
    Private textBoxNewWhere As TextBox
    Private tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents buttonAppend As Button
    Private WithEvents buttonReplaceWhere As Button
    Private WithEvents buttonClearWhere As Button
    Private label2 As Label
    Private textBoxNewWhereAccess As TextBox
    Private WithEvents buttonReplaceWhereAll As Button
    Private label3 As Label
    Private label4 As Label
    Private WithEvents buttonReplaceWhereAccess As Button
End Class
