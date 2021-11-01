
Partial Public Class SaveOptionsDialog
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
        Me.bSave = New Button()
        Me.bCancel = New Button()
        Me.textBox = New TextBox()
        Me.label1 = New Label()
        Me.SuspendLayout()
        ' 
        ' bSave
        ' 
        Me.bSave.Location = New Point(12, 61)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New Size(75, 23)
        Me.bSave.TabIndex = 0
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = True
'			Me.bSave.Click += New System.EventHandler(Me.bSave_Click)
        ' 
        ' bCancel
        ' 
        Me.bCancel.Location = New Point(282, 61)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New Size(75, 23)
        Me.bCancel.TabIndex = 1
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
'			Me.bCancel.Click += New System.EventHandler(Me.bCancel_Click)
        ' 
        ' textBox
        ' 
        Me.textBox.Location = New Point(12, 25)
        Me.textBox.Name = "textBox"
        Me.textBox.Size = New Size(345, 20)
        Me.textBox.TabIndex = 2
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(86, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Save options as:"
        ' 
        ' SaveOptionsDialog
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(369, 104)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bSave)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SaveOptionsDialog"
        Me.Text = "SaveOptionsDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents bSave As Button
    Private WithEvents bCancel As Button
    Private textBox As TextBox
    Private label1 As Label
End Class