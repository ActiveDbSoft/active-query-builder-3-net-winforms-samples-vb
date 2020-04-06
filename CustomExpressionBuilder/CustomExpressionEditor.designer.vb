
Partial Public Class CustomExpressionEditor
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
        Me.panel1 = New Panel()
        Me.btnOk = New Button()
        Me.btnCancel = New Button()
        Me.textBox = New TextBox()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.btnOk)
        Me.panel1.Controls.Add(Me.btnCancel)
        Me.panel1.Dock = DockStyle.Bottom
        Me.panel1.Location = New Point(12, 260)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New Padding(0, 5, 0, 0)
        Me.panel1.Size = New Size(364, 28)
        Me.panel1.TabIndex = 1
        ' 
        ' btnOk
        ' 
        Me.btnOk.DialogResult = DialogResult.OK
        Me.btnOk.Location = New Point(208, 5)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New Size(75, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(289, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        ' 
        ' textBox
        ' 
        Me.textBox.Dock = DockStyle.Fill
        Me.textBox.Location = New Point(12, 12)
        Me.textBox.Multiline = True
        Me.textBox.Name = "textBox"
        Me.textBox.ScrollBars = ScrollBars.Both
        Me.textBox.Size = New Size(364, 248)
        Me.textBox.TabIndex = 0
        ' 
        ' CustomExpressionEditor
        ' 
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New Size(388, 300)
        Me.Controls.Add(Me.textBox)
        Me.Controls.Add(Me.panel1)
        Me.Name = "CustomExpressionEditor"
        Me.Padding = New Padding(12)
        Me.Text = "Expression Editor"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private panel1 As Panel
    Private btnOk As Button
    Private btnCancel As Button
    Public textBox As TextBox
End Class
