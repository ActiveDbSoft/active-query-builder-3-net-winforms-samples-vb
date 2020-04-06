

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
        Me.tabControl1 = New TabControl()
        Me.tabPage1 = New TabPage()
        Me.customTextColumnDemoFrame = New CustomTextColumnDemoFrame()
        Me.tabPage2 = New TabPage()
        Me._customComboBoxColumnDemoFrame = New CustomComboBoxColumnDemoFrame()
        Me.tabPage3 = New TabPage()
        Me.customCheckBoxColumnDemoFrame = New CustomCheckBoxColumnDemoFrame()
        Me.tabPage4 = New TabPage()
        Me.customTextWithButtonColumnDemoFrame = New CustomTextWithButtonColumnDemoFrame()
        Me.tabPage5 = New TabPage()
        Me.customComobBoxWithButtonColumnDemoFrame = New CustomComobBoxWithButtonColumnDemoFrame()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.tabPage4.SuspendLayout()
        Me.tabPage5.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Controls.Add(Me.tabPage4)
        Me.tabControl1.Controls.Add(Me.tabPage5)
        Me.tabControl1.Location = New Point(12, 12)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New Size(992, 478)
        Me.tabControl1.TabIndex = 2
        ' 
        ' tabPage1
        ' 
        Me.tabPage1.Controls.Add(Me.customTextColumnDemoFrame)
        Me.tabPage1.Location = New Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New Padding(3)
        Me.tabPage1.Size = New Size(984, 452)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Text Column"
        Me.tabPage1.UseVisualStyleBackColor = True
        ' 
        ' customTextColumnDemoFrame
        ' 
        Me.customTextColumnDemoFrame.Dock = DockStyle.Fill
        Me.customTextColumnDemoFrame.Location = New Point(3, 3)
        Me.customTextColumnDemoFrame.Name = "customTextColumnDemoFrame"
        Me.customTextColumnDemoFrame.Size = New Size(978, 446)
        Me.customTextColumnDemoFrame.TabIndex = 0
        ' 
        ' tabPage2
        ' 
        Me.tabPage2.Controls.Add(Me._customComboBoxColumnDemoFrame)
        Me.tabPage2.Location = New Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New Padding(3)
        Me.tabPage2.Size = New Size(984, 452)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "ComboBox Column"
        Me.tabPage2.UseVisualStyleBackColor = True
        ' 
        ' _customComboBoxColumnDemoFrame
        ' 
        Me._customComboBoxColumnDemoFrame.Dock = DockStyle.Fill
        Me._customComboBoxColumnDemoFrame.Location = New Point(3, 3)
        Me._customComboBoxColumnDemoFrame.Name = "_customComboBoxColumnDemoFrame"
        Me._customComboBoxColumnDemoFrame.Size = New Size(978, 446)
        Me._customComboBoxColumnDemoFrame.TabIndex = 0
        ' 
        ' tabPage3
        ' 
        Me.tabPage3.Controls.Add(Me.customCheckBoxColumnDemoFrame)
        Me.tabPage3.Location = New Point(4, 22)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New Padding(3)
        Me.tabPage3.Size = New Size(984, 452)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "CheckBox Column"
        Me.tabPage3.UseVisualStyleBackColor = True
        ' 
        ' customCheckBoxColumnDemoFrame
        ' 
        Me.customCheckBoxColumnDemoFrame.Dock = DockStyle.Fill
        Me.customCheckBoxColumnDemoFrame.Location = New Point(3, 3)
        Me.customCheckBoxColumnDemoFrame.Name = "customCheckBoxColumnDemoFrame"
        Me.customCheckBoxColumnDemoFrame.Size = New Size(978, 446)
        Me.customCheckBoxColumnDemoFrame.TabIndex = 0
        ' 
        ' tabPage4
        ' 
        Me.tabPage4.Controls.Add(Me.customTextWithButtonColumnDemoFrame)
        Me.tabPage4.Location = New Point(4, 22)
        Me.tabPage4.Name = "tabPage4"
        Me.tabPage4.Padding = New Padding(3)
        Me.tabPage4.Size = New Size(984, 452)
        Me.tabPage4.TabIndex = 3
        Me.tabPage4.Text = "Text With Button Column"
        Me.tabPage4.UseVisualStyleBackColor = True
        ' 
        ' customTextWithButtonColumnDemoFrame
        ' 
        Me.customTextWithButtonColumnDemoFrame.Dock = DockStyle.Fill
        Me.customTextWithButtonColumnDemoFrame.Location = New Point(3, 3)
        Me.customTextWithButtonColumnDemoFrame.Name = "customTextWithButtonColumnDemoFrame"
        Me.customTextWithButtonColumnDemoFrame.Size = New Size(978, 446)
        Me.customTextWithButtonColumnDemoFrame.TabIndex = 0
        ' 
        ' tabPage5
        ' 
        Me.tabPage5.Controls.Add(Me.customComobBoxWithButtonColumnDemoFrame)
        Me.tabPage5.Location = New Point(4, 22)
        Me.tabPage5.Name = "tabPage5"
        Me.tabPage5.Padding = New Padding(3)
        Me.tabPage5.Size = New Size(984, 452)
        Me.tabPage5.TabIndex = 4
        Me.tabPage5.Text = "ComboBox With Button Column"
        Me.tabPage5.UseVisualStyleBackColor = True
        ' 
        ' customComobBoxWithButtonColumnDemoFrame
        ' 
        Me.customComobBoxWithButtonColumnDemoFrame.Dock = DockStyle.Fill
        Me.customComobBoxWithButtonColumnDemoFrame.Location = New Point(3, 3)
        Me.customComobBoxWithButtonColumnDemoFrame.Name = "customComobBoxWithButtonColumnDemoFrame"
        Me.customComobBoxWithButtonColumnDemoFrame.Size = New Size(978, 446)
        Me.customComobBoxWithButtonColumnDemoFrame.TabIndex = 0
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1016, 502)
        Me.Controls.Add(Me.tabControl1)
        Me.Name = "Form1"
        Me.Text = "Cusom Columns Demo"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage3.ResumeLayout(False)
        Me.tabPage4.ResumeLayout(False)
        Me.tabPage5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private tabControl1 As TabControl
    Private tabPage1 As TabPage
    Private tabPage2 As TabPage
    Private tabPage3 As TabPage
    Private customTextColumnDemoFrame As CustomTextColumnDemoFrame
    Private _customComboBoxColumnDemoFrame As CustomComboBoxColumnDemoFrame
    Private customCheckBoxColumnDemoFrame As CustomCheckBoxColumnDemoFrame
    Private tabPage4 As TabPage
    Private customTextWithButtonColumnDemoFrame As CustomTextWithButtonColumnDemoFrame
    Private tabPage5 As TabPage
    Private customComobBoxWithButtonColumnDemoFrame As CustomComobBoxWithButtonColumnDemoFrame
End Class
