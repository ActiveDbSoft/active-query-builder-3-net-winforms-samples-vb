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
		Me.SqlBox = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.comboBoxSyntax = New System.Windows.Forms.ComboBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.buttonQueryStatistics = New System.Windows.Forms.Button()
		Me.label4 = New System.Windows.Forms.Label()
		Me.comboBoxExamples = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		' 
		' SqlBox
		' 
		Me.SqlBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SqlBox.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.SqlBox.Location = New System.Drawing.Point(74, 68)
		Me.SqlBox.Multiline = True
		Me.SqlBox.Name = "SqlBox"
		Me.SqlBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.SqlBox.Size = New System.Drawing.Size(498, 281)
		Me.SqlBox.TabIndex = 2
		' 
		' label1
		' 
		Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.label1.Location = New System.Drawing.Point(82, 411)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(393, 66)
		Me.label1.TabIndex = 2
		Me.label1.Text = "See the source code for:" & vbCr & vbLf &  "- how to fill the metadata co" & "ntainer with custom objects" & vbCr & vbLf & "- how to create a query programmatically" & vbCr & vbLf & "- how to " & "get objects from the metadata container"
		' 
		' comboBoxSyntax
		' 
		Me.comboBoxSyntax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxSyntax.FormattingEnabled = True
		Me.comboBoxSyntax.Items.AddRange(New Object() {"ANSI SQL-2003", "ANSI SQL-89", "ANSI SQL-92", "Firebird", "IBM DB2", "IBM Informix", _
			"MS Access", "MS SQL Server", "MySQL", "Oracle", "PostgreSQL", "SQLite", _
			"Sybase", "VistaDB"})
		Me.comboBoxSyntax.Location = New System.Drawing.Point(74, 12)
		Me.comboBoxSyntax.Name = "comboBoxSyntax"
		Me.comboBoxSyntax.Size = New System.Drawing.Size(306, 21)
		Me.comboBoxSyntax.TabIndex = 3
		AddHandler Me.comboBoxSyntax.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxSyntax_SelectedIndexChanged)
		' 
		' label2
		' 
		Me.label2.BackColor = System.Drawing.Color.SteelBlue
		Me.label2.ForeColor = System.Drawing.Color.White
		Me.label2.Location = New System.Drawing.Point(12, 12)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(56, 21)
		Me.label2.TabIndex = 4
		Me.label2.Text = "Syntax:"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' label3
		' 
		Me.label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.label3.BackColor = System.Drawing.Color.LightSlateGray
		Me.label3.ForeColor = System.Drawing.Color.White
		Me.label3.Location = New System.Drawing.Point(12, 68)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(56, 281)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Query:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' buttonQueryStatistics
		' 
		Me.buttonQueryStatistics.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.buttonQueryStatistics.Location = New System.Drawing.Point(428, 355)
		Me.buttonQueryStatistics.Name = "buttonQueryStatistics"
		Me.buttonQueryStatistics.Size = New System.Drawing.Size(144, 33)
		Me.buttonQueryStatistics.TabIndex = 1
		Me.buttonQueryStatistics.Text = "Query statistics"
		Me.buttonQueryStatistics.UseVisualStyleBackColor = True
		AddHandler Me.buttonQueryStatistics.Click, New System.EventHandler(AddressOf Me.buttonQueryStatistics_Click)
		' 
		' label4
		' 
		Me.label4.BackColor = System.Drawing.Color.SteelBlue
		Me.label4.ForeColor = System.Drawing.Color.White
		Me.label4.Location = New System.Drawing.Point(12, 40)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(56, 21)
		Me.label4.TabIndex = 4
		Me.label4.Text = "Example:"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		' 
		' comboBoxExamples
		' 
		Me.comboBoxExamples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxExamples.FormattingEnabled = True
		Me.comboBoxExamples.Items.AddRange(New Object() {"Simple query", "Query with Left Join custom expression", "Query with Aggregate and Grouping", "Query with Derived Table and CTE", "Query with Unions", "Query with SubQuery in expression"})
		Me.comboBoxExamples.Location = New System.Drawing.Point(74, 39)
		Me.comboBoxExamples.Name = "comboBoxExamples"
		Me.comboBoxExamples.Size = New System.Drawing.Size(306, 21)
		Me.comboBoxExamples.TabIndex = 3
		AddHandler Me.comboBoxExamples.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxExamples_SelectedIndexChanged)
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(584, 513)
		Me.Controls.Add(Me.buttonQueryStatistics)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.comboBoxExamples)
		Me.Controls.Add(Me.comboBoxSyntax)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.SqlBox)
		Me.Name = "Form1"
		Me.Text = "Query Creation Demo"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private SqlBox As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private comboBoxSyntax As System.Windows.Forms.ComboBox
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private buttonQueryStatistics As System.Windows.Forms.Button
	Private label4 As System.Windows.Forms.Label
	Private comboBoxExamples As System.Windows.Forms.ComboBox
End Class

