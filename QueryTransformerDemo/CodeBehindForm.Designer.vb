
Partial Public Class CodeBehindForm
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
        Me.tableLayoutPanel1 = New TableLayoutPanel()
        Me.TextBoxCode = New RichTextBox()
        Me.ButtonClose = New Button()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' tableLayoutPanel1
        ' 
        Me.tableLayoutPanel1.BackColor = Color.White
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel1.Controls.Add(Me.TextBoxCode, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.ButtonClose, 0, 1)
        Me.tableLayoutPanel1.Dock = DockStyle.Fill
        Me.tableLayoutPanel1.Location = New Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.Padding = New Padding(5, 5, 5, 0)
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel1.Size = New Size(526, 259)
        Me.tableLayoutPanel1.TabIndex = 0
        ' 
        ' TextBoxCode
        ' 
        Me.TextBoxCode.BackColor = SystemColors.Info
        Me.TextBoxCode.Dock = DockStyle.Fill
        Me.TextBoxCode.Location = New Point(8, 8)
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New Size(510, 219)
        Me.TextBoxCode.TabIndex = 0
        Me.TextBoxCode.Text = ""
        ' 
        ' ButtonClose
        ' 
        Me.ButtonClose.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
        Me.ButtonClose.Location = New Point(443, 233)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New Size(75, 23)
        Me.ButtonClose.TabIndex = 1
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
'			Me.ButtonClose.Click += New System.EventHandler(Me.ButtonClose_Click)
        ' 
        ' CodeBehindForm
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(526, 259)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.MaximizeBox = False
        Me.Name = "CodeBehindForm"
        Me.Text = "Code Behind"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private tableLayoutPanel1 As TableLayoutPanel
    Private TextBoxCode As RichTextBox
    Private WithEvents ButtonClose As Button
End Class