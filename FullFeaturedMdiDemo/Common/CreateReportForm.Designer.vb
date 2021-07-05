Namespace Common
	Partial Public Class CreateReportForm
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.rbActiveReport = New System.Windows.Forms.RadioButton()
        Me.rbStimulsoft = New System.Windows.Forms.RadioButton()
        Me.rbFastReport = New System.Windows.Forms.RadioButton()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.tableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Location = New System.Drawing.Point(10, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(135, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Select one of the reporting:"
        '
        'rbActiveReport
        '
        Me.rbActiveReport.AutoSize = true
        Me.rbActiveReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbActiveReport.Location = New System.Drawing.Point(10, 23)
        Me.rbActiveReport.Name = "rbActiveReport"
        Me.rbActiveReport.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.rbActiveReport.Size = New System.Drawing.Size(255, 27)
        Me.rbActiveReport.TabIndex = 1
        Me.rbActiveReport.TabStop = true
        Me.rbActiveReport.Text = "Active Reports"
        Me.rbActiveReport.UseVisualStyleBackColor = true
        '
        'rbStimulsoft
        '
        Me.rbStimulsoft.AutoSize = true
        Me.rbStimulsoft.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbStimulsoft.Location = New System.Drawing.Point(10, 50)
        Me.rbStimulsoft.Margin = New System.Windows.Forms.Padding(0)
        Me.rbStimulsoft.Name = "rbStimulsoft"
        Me.rbStimulsoft.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.rbStimulsoft.Size = New System.Drawing.Size(255, 22)
        Me.rbStimulsoft.TabIndex = 1
        Me.rbStimulsoft.TabStop = true
        Me.rbStimulsoft.Text = "Stimulsoft Reports"
        Me.rbStimulsoft.UseVisualStyleBackColor = true
        '
        'rbFastReport
        '
        Me.rbFastReport.AutoSize = true
        Me.rbFastReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbFastReport.Location = New System.Drawing.Point(10, 72)
        Me.rbFastReport.Name = "rbFastReport"
        Me.rbFastReport.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.rbFastReport.Size = New System.Drawing.Size(255, 32)
        Me.rbFastReport.TabIndex = 1
        Me.rbFastReport.TabStop = true
        Me.rbFastReport.Text = "FastReport"
        Me.rbFastReport.UseVisualStyleBackColor = true
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tableLayoutPanel1.Controls.Add(Me.button1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.button2, 1, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(10, 104)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(255, 26)
        Me.tableLayoutPanel1.TabIndex = 2
        '
        'button1
        '
        Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button1.Enabled = false
        Me.button1.Location = New System.Drawing.Point(3, 3)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(121, 20)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Generate"
        Me.button1.UseVisualStyleBackColor = true
        '
        'button2
        '
        Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button2.Location = New System.Drawing.Point(130, 3)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(122, 20)
        Me.button2.TabIndex = 0
        Me.button2.Text = "Cancel"
        Me.button2.UseVisualStyleBackColor = true
        '
        'CreateReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 139)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.rbFastReport)
        Me.Controls.Add(Me.rbStimulsoft)
        Me.Controls.Add(Me.rbActiveReport)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CreateReportForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Type reports"
        Me.tableLayoutPanel1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private WithEvents rbActiveReport As System.Windows.Forms.RadioButton
		Private WithEvents rbStimulsoft As System.Windows.Forms.RadioButton
		Private WithEvents rbFastReport As System.Windows.Forms.RadioButton
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private button1 As System.Windows.Forms.Button
		Private button2 As System.Windows.Forms.Button
	End Class
End Namespace