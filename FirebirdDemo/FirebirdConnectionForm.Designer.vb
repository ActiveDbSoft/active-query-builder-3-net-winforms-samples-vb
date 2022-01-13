
Partial Public Class FirebirdConnectionForm
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
        Me.textboxServer = New TextBox()
        Me.label1 = New Label()
        Me.buttonBrowse = New Button()
        Me.textboxPassword = New TextBox()
        Me.label2 = New Label()
        Me.openFileDialog1 = New OpenFileDialog()
        Me.buttonCancel = New Button()
        Me.buttonConnect = New Button()
        Me.label3 = New Label()
        Me.label4 = New Label()
        Me.textboxUser = New TextBox()
        Me.textboxDatabase = New TextBox()
        Me.SuspendLayout()
        ' 
        ' textboxServer
        ' 
        Me.textboxServer.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxServer.Location = New Point(97, 12)
        Me.textboxServer.Name = "textboxServer"
        Me.textboxServer.Size = New Size(220, 20)
        Me.textboxServer.TabIndex = 0
        Me.textboxServer.Text = "localhost"
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New Point(3, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(41, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Server:"
        ' 
        ' buttonBrowse
        ' 
        Me.buttonBrowse.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
        Me.buttonBrowse.Location = New Point(323, 36)
        Me.buttonBrowse.Name = "buttonBrowse"
        Me.buttonBrowse.Size = New Size(24, 23)
        Me.buttonBrowse.TabIndex = 2
        Me.buttonBrowse.Text = "..."
        Me.buttonBrowse.UseVisualStyleBackColor = True
'            Me.buttonBrowse.Click += New System.EventHandler(Me.buttonBrowse_Click)
        ' 
        ' textboxPassword
        ' 
        Me.textboxPassword.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxPassword.Location = New Point(97, 90)
        Me.textboxPassword.Name = "textboxPassword"
        Me.textboxPassword.Size = New Size(220, 20)
        Me.textboxPassword.TabIndex = 4
        Me.textboxPassword.UseSystemPasswordChar = True
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New Point(3, 93)
        Me.label2.Name = "label2"
        Me.label2.Size = New Size(53, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Password"
        ' 
        ' openFileDialog1
        ' 
        Me.openFileDialog1.DefaultExt = "*.fdb"
        Me.openFileDialog1.Filter = "Firebird Databases (*.fdb)|*.fdb|All Files|*.*"
        ' 
        ' buttonCancel
        ' 
        Me.buttonCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.buttonCancel.DialogResult = DialogResult.Cancel
        Me.buttonCancel.Location = New Point(272, 134)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New Size(75, 23)
        Me.buttonCancel.TabIndex = 6
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        ' 
        ' buttonConnect
        ' 
        Me.buttonConnect.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.buttonConnect.DialogResult = DialogResult.OK
        Me.buttonConnect.Location = New Point(191, 134)
        Me.buttonConnect.Name = "buttonConnect"
        Me.buttonConnect.Size = New Size(75, 23)
        Me.buttonConnect.TabIndex = 5
        Me.buttonConnect.Text = "Connect"
        Me.buttonConnect.UseVisualStyleBackColor = True
'            Me.buttonConnect.Click += New System.EventHandler(Me.buttonConnect_Click)
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New Point(3, 41)
        Me.label3.Name = "label3"
        Me.label3.Size = New Size(56, 13)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Database:"
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New Point(3, 67)
        Me.label4.Name = "label4"
        Me.label4.Size = New Size(32, 13)
        Me.label4.TabIndex = 13
        Me.label4.Text = "User:"
        ' 
        ' textboxUser
        ' 
        Me.textboxUser.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxUser.Location = New Point(97, 64)
        Me.textboxUser.Name = "textboxUser"
        Me.textboxUser.Size = New Size(220, 20)
        Me.textboxUser.TabIndex = 3
        Me.textboxUser.Text = "SYSDBA"
        ' 
        ' textboxDatabase
        ' 
        Me.textboxDatabase.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxDatabase.Location = New Point(97, 38)
        Me.textboxDatabase.Name = "textboxDatabase"
        Me.textboxDatabase.Size = New Size(220, 20)
        Me.textboxDatabase.TabIndex = 1
        ' 
        ' FirebirdConnectionForm
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(359, 169)
        Me.Controls.Add(Me.textboxDatabase)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textboxUser)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonConnect)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textboxPassword)
        Me.Controls.Add(Me.buttonBrowse)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textboxServer)
        Me.Name = "FirebirdConnectionForm"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Connect to Firebird database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private textboxServer As TextBox
    Private label1 As Label
    Private WithEvents buttonBrowse As Button
    Private textboxPassword As TextBox
    Private label2 As Label
    Private openFileDialog1 As OpenFileDialog
    Private buttonCancel As Button
    Private WithEvents buttonConnect As Button
    Private label3 As Label
    Private label4 As Label
    Private textboxUser As TextBox
    Private textboxDatabase As TextBox
End Class
