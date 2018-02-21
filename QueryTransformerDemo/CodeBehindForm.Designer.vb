Partial Class CodeBehindForm
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
		Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.TextBoxCode = New System.Windows.Forms.RichTextBox()
		Me.ButtonClose = New System.Windows.Forms.Button()
		Me.tableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tableLayoutPanel1
		' 
		Me.tableLayoutPanel1.BackColor = System.Drawing.Color.White
		Me.tableLayoutPanel1.ColumnCount = 1
		Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel1.Controls.Add(Me.TextBoxCode, 0, 0)
		Me.tableLayoutPanel1.Controls.Add(Me.ButtonClose, 0, 1)
		Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
		Me.tableLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
		Me.tableLayoutPanel1.RowCount = 2
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
		Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.tableLayoutPanel1.Size = New System.Drawing.Size(526, 259)
		Me.tableLayoutPanel1.TabIndex = 0
		' 
		' TextBoxCode
		' 
		Me.TextBoxCode.BackColor = System.Drawing.SystemColors.Info
		Me.TextBoxCode.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TextBoxCode.Location = New System.Drawing.Point(8, 8)
		Me.TextBoxCode.Name = "TextBoxCode"
		Me.TextBoxCode.Size = New System.Drawing.Size(510, 219)
		Me.TextBoxCode.TabIndex = 0
		Me.TextBoxCode.Text = ""
		' 
		' ButtonClose
		' 
		Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonClose.Location = New System.Drawing.Point(443, 233)
		Me.ButtonClose.Name = "ButtonClose"
		Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
		Me.ButtonClose.TabIndex = 1
		Me.ButtonClose.Text = "Close"
		Me.ButtonClose.UseVisualStyleBackColor = True
		AddHandler Me.ButtonClose.Click, New System.EventHandler(AddressOf Me.ButtonClose_Click)
		' 
		' CodeBehindForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(526, 259)
		Me.Controls.Add(Me.tableLayoutPanel1)
		Me.MaximizeBox = False
		Me.Name = "CodeBehindForm"
		Me.Text = "Code Behind"
		Me.tableLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private TextBoxCode As System.Windows.Forms.RichTextBox
	Private ButtonClose As System.Windows.Forms.Button
End Class
