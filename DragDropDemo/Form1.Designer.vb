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
		Me.genericSyntaxProvider1 = New ActiveQueryBuilder.Core.GenericSyntaxProvider(Me.components)
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.listBox1 = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		' 
		' queryBuilder1
		' 
		Me.queryBuilder1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
		Me.queryBuilder1.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
		Me.queryBuilder1.Location = New System.Drawing.Point(12, 12)
		Me.queryBuilder1.Name = "queryBuilder1"
		Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewVisible = False
		Me.queryBuilder1.Size = New System.Drawing.Size(721, 468)
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
		' 
		' textBox1
		' 
		Me.textBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.textBox1.Location = New System.Drawing.Point(12, 486)
		Me.textBox1.Multiline = True
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(876, 130)
		Me.textBox1.TabIndex = 1
		AddHandler Me.textBox1.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.textBox1_Validating)
		' 
		' label1
		' 
		Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.label1.ForeColor = System.Drawing.Color.Maroon
		Me.label1.Location = New System.Drawing.Point(739, 8)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(149, 60)
		Me.label1.TabIndex = 3
		Me.label1.Text = "Drag an item from this custom list and drop it to the query builder's diagram pan" & "e"
		' 
		' listBox1
		' 
		Me.listBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.listBox1.FormattingEnabled = True
		Me.listBox1.IntegralHeight = False
		Me.listBox1.Items.AddRange(New Object() {"Orders", "Order Details", "Products", "Customers", "Employees", "Categories"})
		Me.listBox1.Location = New System.Drawing.Point(739, 71)
		Me.listBox1.Name = "listBox1"
		Me.listBox1.Size = New System.Drawing.Size(149, 409)
		Me.listBox1.TabIndex = 4
		AddHandler Me.listBox1.DoubleClick, New System.EventHandler(AddressOf Me.listBox1_DoubleClick)
		AddHandler Me.listBox1.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.listBox1_MouseDown)
		AddHandler Me.listBox1.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.listBox1_MouseMove)
		AddHandler Me.listBox1.MouseUp, New System.Windows.Forms.MouseEventHandler(AddressOf Me.listBox1_MouseUp)
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(900, 628)
		Me.Controls.Add(Me.listBox1)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.queryBuilder1)
		Me.Name = "Form1"
		Me.Text = "Drag'n'Drop Demo"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private textBox1 As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private genericSyntaxProvider1 As ActiveQueryBuilder.Core.GenericSyntaxProvider
	Private listBox1 As System.Windows.Forms.ListBox
End Class

