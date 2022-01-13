
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

#region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.SqlBox = New TextBox()
        Me.label1 = New Label()
        Me.comboBoxSyntax = New ComboBox()
        Me.label2 = New Label()
        Me.label3 = New Label()
        Me.buttonQueryStatistics = New Button()
        Me.label4 = New Label()
        Me.comboBoxExamples = New ComboBox()
        Me.SuspendLayout()
        ' 
        ' SqlBox
        ' 
        Me.SqlBox.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.SqlBox.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.SqlBox.Location = New Point(74, 68)
        Me.SqlBox.Multiline = True
        Me.SqlBox.Name = "SqlBox"
        Me.SqlBox.ScrollBars = ScrollBars.Both
        Me.SqlBox.Size = New Size(498, 280)
        Me.SqlBox.TabIndex = 2
        ' 
        ' label1
        ' 
        Me.label1.Dock = DockStyle.Bottom
        Me.label1.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.label1.Location = New Point(0, 446)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(584, 66)
        Me.label1.TabIndex = 2
        Me.label1.Text = "See the source code for:" & vbCrLf & "- how to fill the metadata container with custom object" & "s" & vbCrLf & "- how to create a query programmatically" & vbCrLf & "- how to get objects from the metad" & "ata container"
        ' 
        ' comboBoxSyntax
        ' 
        Me.comboBoxSyntax.DropDownStyle = ComboBoxStyle.DropDownList
        Me.comboBoxSyntax.FormattingEnabled = True
        Me.comboBoxSyntax.Items.AddRange(New Object() { "ANSI SQL-2003", "ANSI SQL-89", "ANSI SQL-92", "Firebird", "IBM DB2", "IBM Informix", "MS Access", "MS SQL Server", "MySQL", "Oracle", "PostgreSQL", "SQLite", "Sybase", "VistaDB"})
        Me.comboBoxSyntax.Location = New Point(74, 12)
        Me.comboBoxSyntax.Name = "comboBoxSyntax"
        Me.comboBoxSyntax.Size = New Size(306, 21)
        Me.comboBoxSyntax.TabIndex = 3
'            Me.comboBoxSyntax.SelectedIndexChanged += New System.EventHandler(Me.comboBoxSyntax_SelectedIndexChanged)
        ' 
        ' label2
        ' 
        Me.label2.BackColor = Color.SteelBlue
        Me.label2.ForeColor = Color.White
        Me.label2.Location = New Point(12, 12)
        Me.label2.Name = "label2"
        Me.label2.Size = New Size(56, 21)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Syntax:"
        Me.label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label3
        ' 
        Me.label3.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left), AnchorStyles))
        Me.label3.BackColor = Color.LightSlateGray
        Me.label3.ForeColor = Color.White
        Me.label3.Location = New Point(12, 68)
        Me.label3.Name = "label3"
        Me.label3.Size = New Size(56, 280)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Query:"
        Me.label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' buttonQueryStatistics
        ' 
        Me.buttonQueryStatistics.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Left), AnchorStyles))
        Me.buttonQueryStatistics.Location = New Point(428, 354)
        Me.buttonQueryStatistics.Name = "buttonQueryStatistics"
        Me.buttonQueryStatistics.Size = New Size(144, 33)
        Me.buttonQueryStatistics.TabIndex = 1
        Me.buttonQueryStatistics.Text = "Query statistics"
        Me.buttonQueryStatistics.UseVisualStyleBackColor = True
'            Me.buttonQueryStatistics.Click += New System.EventHandler(Me.buttonQueryStatistics_Click)
        ' 
        ' label4
        ' 
        Me.label4.BackColor = Color.SteelBlue
        Me.label4.ForeColor = Color.White
        Me.label4.Location = New Point(12, 40)
        Me.label4.Name = "label4"
        Me.label4.Size = New Size(56, 21)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Example:"
        Me.label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' comboBoxExamples
        ' 
        Me.comboBoxExamples.DropDownStyle = ComboBoxStyle.DropDownList
        Me.comboBoxExamples.FormattingEnabled = True
        Me.comboBoxExamples.Items.AddRange(New Object() { "Simple query", "Query with Left Join custom expression", "Query with Aggregate and Grouping", "Query with Derived Table and CTE", "Query with Unions", "Query with SubQuery in expression"})
        Me.comboBoxExamples.Location = New Point(74, 39)
        Me.comboBoxExamples.Name = "comboBoxExamples"
        Me.comboBoxExamples.Size = New Size(306, 21)
        Me.comboBoxExamples.TabIndex = 3
'            Me.comboBoxExamples.SelectedIndexChanged += New System.EventHandler(Me.comboBoxExamples_SelectedIndexChanged)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(584, 512)
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
'            Me.Load += New System.EventHandler(Me.Form1_Load)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private SqlBox As TextBox
    Private label1 As Label
    Private WithEvents comboBoxSyntax As ComboBox
    Private label2 As Label
    Private label3 As Label
    Private WithEvents buttonQueryStatistics As Button
    Private label4 As Label
    Private WithEvents comboBoxExamples As ComboBox
End Class
