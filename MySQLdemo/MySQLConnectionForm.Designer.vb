
Partial Public Class MySQLConnectionForm
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
        Me.tbDatabase = New TextBox()
        Me.label1 = New Label()
        Me.tbPassword = New TextBox()
        Me.label2 = New Label()
        Me.openFileDialog1 = New OpenFileDialog()
        Me.buttonCancel = New Button()
        Me.buttonConnect = New Button()
        Me.tbServer = New TextBox()
        Me.label3 = New Label()
        Me.tbUser = New TextBox()
        Me.label4 = New Label()
        Me.SuspendLayout()
        ' 
        ' tbDatabase
        ' 
        Me.tbDatabase.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbDatabase.Location = New Point(62, 41)
        Me.tbDatabase.Name = "tbDatabase"
        Me.tbDatabase.Size = New Size(227, 20)
        Me.tbDatabase.TabIndex = 1
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
        ' tbPassword
        ' 
        Me.tbPassword.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbPassword.Location = New Point(62, 93)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New Size(227, 20)
        Me.tbPassword.TabIndex = 3
        Me.tbPassword.UseSystemPasswordChar = True
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
        ' openFileDialog1
        ' 
        Me.openFileDialog1.DefaultExt = "vdb3"
        Me.openFileDialog1.FileName = "openFileDialog1"
        Me.openFileDialog1.Filter = "MySQL 3.0 files (*.vdb3)|*.vdb3|All files|*.*"
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
'			Me.buttonConnect.Click += New System.EventHandler(Me.buttonConnect_Click)
        ' 
        ' tbServer
        ' 
        Me.tbServer.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbServer.Location = New Point(62, 15)
        Me.tbServer.Name = "tbServer"
        Me.tbServer.Size = New Size(227, 20)
        Me.tbServer.TabIndex = 0
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
        ' tbUser
        ' 
        Me.tbUser.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbUser.Location = New Point(62, 67)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New Size(227, 20)
        Me.tbUser.TabIndex = 2
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
        ' MySQLConnectionForm
        ' 
        Me.AcceptButton = Me.buttonConnect
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New Size(301, 166)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.tbServer)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonConnect)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tbDatabase)
        Me.Name = "MySQLConnectionForm"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Connect to MySQL database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private tbDatabase As TextBox
    Private label1 As Label
    Private tbPassword As TextBox
    Private label2 As Label
    Private openFileDialog1 As OpenFileDialog
    Private buttonCancel As Button
    Private WithEvents buttonConnect As Button
    Private tbServer As TextBox
    Private label3 As Label
    Private tbUser As TextBox
    Private label4 As Label
End Class
