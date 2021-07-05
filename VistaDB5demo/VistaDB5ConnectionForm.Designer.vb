
Partial Public Class VistaDB5ConnectionForm
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

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.textboxDatabase = New TextBox()
        Me.label1 = New Label()
        Me.buttonBrowse = New Button()
        Me.textboxPassword = New TextBox()
        Me.label2 = New Label()
        Me.openFileDialog1 = New OpenFileDialog()
        Me.buttonCancel = New Button()
        Me.buttonConnect = New Button()
        Me.SuspendLayout()
        ' 
        ' textboxDatabase
        ' 
        Me.textboxDatabase.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxDatabase.Location = New Point(62, 12)
        Me.textboxDatabase.Name = "textboxDatabase"
        Me.textboxDatabase.Size = New Size(218, 20)
        Me.textboxDatabase.TabIndex = 0
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New Point(3, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(53, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Database"
        ' 
        ' buttonBrowse
        ' 
        Me.buttonBrowse.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
        Me.buttonBrowse.Location = New Point(286, 10)
        Me.buttonBrowse.Name = "buttonBrowse"
        Me.buttonBrowse.Size = New Size(24, 23)
        Me.buttonBrowse.TabIndex = 2
        Me.buttonBrowse.Text = "..."
        Me.buttonBrowse.UseVisualStyleBackColor = True
'			Me.buttonBrowse.Click += New System.EventHandler(Me.buttonBrowse_Click)
        ' 
        ' textboxPassword
        ' 
        Me.textboxPassword.Location = New Point(62, 38)
        Me.textboxPassword.Name = "textboxPassword"
        Me.textboxPassword.Size = New Size(129, 20)
        Me.textboxPassword.TabIndex = 3
        Me.textboxPassword.UseSystemPasswordChar = True
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New Point(3, 41)
        Me.label2.Name = "label2"
        Me.label2.Size = New Size(53, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Password"
        ' 
        ' openFileDialog1
        ' 
        Me.openFileDialog1.DefaultExt = "vdb5"
        Me.openFileDialog1.Filter = "VistaDB 5.x files (*.vdb5)|*.vdb5|All files|*.*"
        ' 
        ' buttonCancel
        ' 
        Me.buttonCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.buttonCancel.DialogResult = DialogResult.Cancel
        Me.buttonCancel.Location = New Point(235, 87)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New Size(75, 23)
        Me.buttonCancel.TabIndex = 7
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        ' 
        ' buttonConnect
        ' 
        Me.buttonConnect.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.buttonConnect.DialogResult = DialogResult.OK
        Me.buttonConnect.Location = New Point(154, 87)
        Me.buttonConnect.Name = "buttonConnect"
        Me.buttonConnect.Size = New Size(75, 23)
        Me.buttonConnect.TabIndex = 6
        Me.buttonConnect.Text = "Connect"
        Me.buttonConnect.UseVisualStyleBackColor = True
'			Me.buttonConnect.Click += New System.EventHandler(Me.buttonConnect_Click)
        ' 
        ' VistaDB5ConnectionForm
        ' 
        Me.AcceptButton = Me.buttonConnect
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New Size(322, 122)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonConnect)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textboxPassword)
        Me.Controls.Add(Me.buttonBrowse)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textboxDatabase)
        Me.Name = "VistaDB5ConnectionForm"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Connect to VistaDB database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private textboxDatabase As TextBox
    Private label1 As Label
    Private WithEvents buttonBrowse As Button
    Private textboxPassword As TextBox
    Private label2 As Label
    Private openFileDialog1 As OpenFileDialog
    Private buttonCancel As Button
    Private WithEvents buttonConnect As Button
End Class