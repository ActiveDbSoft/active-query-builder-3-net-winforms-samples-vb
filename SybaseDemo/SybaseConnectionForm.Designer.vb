
Partial Public Class SybaseConnectionForm
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
        Me.openFileDialog1 = New OpenFileDialog()
        Me.buttonCancel = New Button()
        Me.buttonConnect = New Button()
        Me.label5 = New Label()
        Me.textboxDataSourceName = New TextBox()
        Me.buttonBrowse = New Button()
        Me.label4 = New Label()
        Me.textboxUser = New TextBox()
        Me.label3 = New Label()
        Me.textboxServerName = New TextBox()
        Me.label2 = New Label()
        Me.textboxPassword = New TextBox()
        Me.label1 = New Label()
        Me.textboxDatabaseFile = New TextBox()
        Me.SuspendLayout()
        ' 
        ' openFileDialog1
        ' 
        Me.openFileDialog1.DefaultExt = "*.fd"
        Me.openFileDialog1.Filter = "Sybase Database File (*.db)|*.db|All Files|*.*"
        ' 
        ' buttonCancel
        ' 
        Me.buttonCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.buttonCancel.DialogResult = DialogResult.Cancel
        Me.buttonCancel.Location = New Point(210, 153)
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
        Me.buttonConnect.Location = New Point(129, 153)
        Me.buttonConnect.Name = "buttonConnect"
        Me.buttonConnect.Size = New Size(75, 23)
        Me.buttonConnect.TabIndex = 5
        Me.buttonConnect.Text = "Connect"
        Me.buttonConnect.UseVisualStyleBackColor = True
'            Me.buttonConnect.Click += New System.EventHandler(Me.buttonConnect_Click)
        ' 
        ' label5
        ' 
        Me.label5.Location = New Point(13, 41)
        Me.label5.Name = "label5"
        Me.label5.Size = New Size(105, 13)
        Me.label5.TabIndex = 32
        Me.label5.Text = "Data Source Name:"
        ' 
        ' textboxDataSourceName
        ' 
        Me.textboxDataSourceName.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxDataSourceName.Location = New Point(124, 38)
        Me.textboxDataSourceName.Name = "textboxDataSourceName"
        Me.textboxDataSourceName.Size = New Size(131, 20)
        Me.textboxDataSourceName.TabIndex = 31
        ' 
        ' buttonBrowse
        ' 
        Me.buttonBrowse.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
        Me.buttonBrowse.Location = New Point(261, 62)
        Me.buttonBrowse.Name = "buttonBrowse"
        Me.buttonBrowse.Size = New Size(24, 22)
        Me.buttonBrowse.TabIndex = 24
        Me.buttonBrowse.Text = "..."
        Me.buttonBrowse.UseVisualStyleBackColor = True
'            Me.buttonBrowse.Click += New System.EventHandler(Me.buttonBrowse_Click)
        ' 
        ' label4
        ' 
        Me.label4.Location = New Point(13, 93)
        Me.label4.Name = "label4"
        Me.label4.Size = New Size(105, 13)
        Me.label4.TabIndex = 30
        Me.label4.Text = "User:"
        ' 
        ' textboxUser
        ' 
        Me.textboxUser.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxUser.Location = New Point(124, 90)
        Me.textboxUser.Name = "textboxUser"
        Me.textboxUser.Size = New Size(131, 20)
        Me.textboxUser.TabIndex = 25
        Me.textboxUser.Text = "DBA"
        ' 
        ' label3
        ' 
        Me.label3.Location = New Point(13, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New Size(105, 13)
        Me.label3.TabIndex = 29
        Me.label3.Text = "Server Name:"
        ' 
        ' textboxServerName
        ' 
        Me.textboxServerName.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxServerName.Location = New Point(124, 12)
        Me.textboxServerName.Name = "textboxServerName"
        Me.textboxServerName.Size = New Size(131, 20)
        Me.textboxServerName.TabIndex = 22
        ' 
        ' label2
        ' 
        Me.label2.Location = New Point(13, 119)
        Me.label2.Name = "label2"
        Me.label2.Size = New Size(105, 13)
        Me.label2.TabIndex = 28
        Me.label2.Text = "Password:"
        ' 
        ' textboxPassword
        ' 
        Me.textboxPassword.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxPassword.Location = New Point(124, 116)
        Me.textboxPassword.Name = "textboxPassword"
        Me.textboxPassword.Size = New Size(131, 20)
        Me.textboxPassword.TabIndex = 26
        Me.textboxPassword.UseSystemPasswordChar = True
        ' 
        ' label1
        ' 
        Me.label1.Location = New Point(13, 67)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(105, 13)
        Me.label1.TabIndex = 27
        Me.label1.Text = "Database File:"
        ' 
        ' textboxDatabaseFile
        ' 
        Me.textboxDatabaseFile.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textboxDatabaseFile.Location = New Point(124, 64)
        Me.textboxDatabaseFile.Name = "textboxDatabaseFile"
        Me.textboxDatabaseFile.Size = New Size(131, 20)
        Me.textboxDatabaseFile.TabIndex = 23
        ' 
        ' SybaseConnectionForm
        ' 
        Me.AcceptButton = Me.buttonConnect
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New Size(297, 188)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.textboxDataSourceName)
        Me.Controls.Add(Me.buttonBrowse)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textboxUser)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.textboxServerName)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textboxPassword)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textboxDatabaseFile)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonConnect)
        Me.Name = "SybaseConnectionForm"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Connect to Sybase database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private openFileDialog1 As OpenFileDialog
    Private buttonCancel As Button
    Private WithEvents buttonConnect As Button
    Private label5 As Label
    Private textboxDataSourceName As TextBox
    Private WithEvents buttonBrowse As Button
    Private label4 As Label
    Private textboxUser As TextBox
    Private label3 As Label
    Private textboxServerName As TextBox
    Private label2 As Label
    Private textboxPassword As TextBox
    Private label1 As Label
    Private textboxDatabaseFile As TextBox
End Class
