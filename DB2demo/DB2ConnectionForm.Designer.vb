
Partial Public Class DB2ConnectionForm
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

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.textboxDatabase = New TextBox()
        Me.label1 = New Label()
        Me.textboxPassword = New TextBox()
        Me.label2 = New Label()
        Me.openFileDialog1 = New OpenFileDialog()
        Me.buttonCancel = New Button()
        Me.buttonConnect = New Button()
        Me.textboxServer = New TextBox()
        Me.label3 = New Label()
        Me.textboxUser = New TextBox()
        Me.label4 = New Label()
        Me.SuspendLayout()
        ' 
        ' textboxDatabase
        ' 
        Me.textboxDatabase.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxDatabase.Location = New Point(62, 41)
        Me.textboxDatabase.Name = "textboxDatabase"
        Me.textboxDatabase.Size = New Size(227, 20)
        Me.textboxDatabase.TabIndex = 1
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New Point(3, 44)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(53, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Database"
        ' 
        ' textboxPassword
        ' 
        Me.textboxPassword.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxPassword.Location = New Point(62, 93)
        Me.textboxPassword.Name = "textboxPassword"
        Me.textboxPassword.Size = New Size(227, 20)
        Me.textboxPassword.TabIndex = 3
        Me.textboxPassword.UseSystemPasswordChar = True
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New Point(3, 96)
        Me.label2.Name = "label2"
        Me.label2.Size = New Size(53, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Password"
        '
        ' buttonCancel
        ' 
        Me.buttonCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.buttonCancel.DialogResult = DialogResult.Cancel
        Me.buttonCancel.Location = New Point(214, 131)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New Size(75, 23)
        Me.buttonCancel.TabIndex = 5
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        ' 
        ' buttonConnect
        ' 
        Me.buttonConnect.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.buttonConnect.DialogResult = DialogResult.OK
        Me.buttonConnect.Location = New Point(133, 131)
        Me.buttonConnect.Name = "buttonConnect"
        Me.buttonConnect.Size = New Size(75, 23)
        Me.buttonConnect.TabIndex = 4
        Me.buttonConnect.Text = "Connect"
        Me.buttonConnect.UseVisualStyleBackColor = True
'            Me.buttonConnect.Click += New System.EventHandler(Me.buttonConnect_Click)
        ' 
        ' textboxServer
        ' 
        Me.textboxServer.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxServer.Location = New Point(62, 15)
        Me.textboxServer.Name = "textboxServer"
        Me.textboxServer.Size = New Size(227, 20)
        Me.textboxServer.TabIndex = 0
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New Point(3, 18)
        Me.label3.Name = "label3"
        Me.label3.Size = New Size(38, 13)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Server"
        ' 
        ' textboxUser
        ' 
        Me.textboxUser.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxUser.Location = New Point(62, 67)
        Me.textboxUser.Name = "textboxUser"
        Me.textboxUser.Size = New Size(227, 20)
        Me.textboxUser.TabIndex = 2
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New Point(3, 70)
        Me.label4.Name = "label4"
        Me.label4.Size = New Size(29, 13)
        Me.label4.TabIndex = 11
        Me.label4.Text = "User"
        ' 
        ' DB2ConnectionForm
        ' 
        Me.AcceptButton = Me.buttonConnect
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New Size(301, 166)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textboxUser)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.textboxServer)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonConnect)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textboxPassword)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textboxDatabase)
        Me.Name = "DB2ConnectionForm"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Connect to DB2 database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private textboxDatabase As TextBox
    Private label1 As Label
    Private textboxPassword As TextBox
    Private label2 As Label
    Private openFileDialog1 As OpenFileDialog
    Private buttonCancel As Button
    Private WithEvents buttonConnect As Button
    Private textboxServer As TextBox
    Private label3 As Label
    Private textboxUser As TextBox
    Private label4 As Label
End Class
