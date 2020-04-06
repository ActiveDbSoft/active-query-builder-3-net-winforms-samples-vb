
Partial Public Class InformixConnectionForm
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
        Me.buttonCancel = New Button()
        Me.buttonConnect = New Button()
        Me.label8 = New Label()
        Me.label7 = New Label()
        Me.tbService = New TextBox()
        Me.label6 = New Label()
        Me.tbProtocol = New TextBox()
        Me.label5 = New Label()
        Me.tbHost = New TextBox()
        Me.label4 = New Label()
        Me.openFileDialog1 = New OpenFileDialog()
        Me.tbDatabaseLocale = New TextBox()
        Me.tbUser = New TextBox()
        Me.label3 = New Label()
        Me.tbServer = New TextBox()
        Me.label2 = New Label()
        Me.tbPassword = New TextBox()
        Me.label1 = New Label()
        Me.tbDatabase = New TextBox()
        Me.SuspendLayout()
        ' 
        ' buttonCancel
        ' 
        Me.buttonCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.buttonCancel.DialogResult = DialogResult.Cancel
        Me.buttonCancel.Location = New Point(202, 232)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New Size(75, 23)
        Me.buttonCancel.TabIndex = 9
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        ' 
        ' buttonConnect
        ' 
        Me.buttonConnect.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.buttonConnect.DialogResult = DialogResult.OK
        Me.buttonConnect.Location = New Point(121, 232)
        Me.buttonConnect.Name = "buttonConnect"
        Me.buttonConnect.Size = New Size(75, 23)
        Me.buttonConnect.TabIndex = 8
        Me.buttonConnect.Text = "Connect"
        Me.buttonConnect.UseVisualStyleBackColor = True
'			Me.buttonConnect.Click += New System.EventHandler(Me.buttonConnect_Click)
        ' 
        ' label8
        ' 
        Me.label8.Location = New Point(7, 145)
        Me.label8.Name = "label8"
        Me.label8.Size = New Size(95, 13)
        Me.label8.TabIndex = 43
        Me.label8.Text = "Database Locale:"
        ' 
        ' label7
        ' 
        Me.label7.Location = New Point(7, 93)
        Me.label7.Name = "label7"
        Me.label7.Size = New Size(95, 13)
        Me.label7.TabIndex = 42
        Me.label7.Text = "Service:"
        ' 
        ' tbService
        ' 
        Me.tbService.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbService.Location = New Point(108, 90)
        Me.tbService.Name = "tbService"
        Me.tbService.Size = New Size(169, 20)
        Me.tbService.TabIndex = 3
        ' 
        ' label6
        ' 
        Me.label6.Location = New Point(7, 67)
        Me.label6.Name = "label6"
        Me.label6.Size = New Size(95, 13)
        Me.label6.TabIndex = 41
        Me.label6.Text = "Protocol:"
        ' 
        ' tbProtocol
        ' 
        Me.tbProtocol.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbProtocol.Location = New Point(108, 64)
        Me.tbProtocol.Name = "tbProtocol"
        Me.tbProtocol.Size = New Size(169, 20)
        Me.tbProtocol.TabIndex = 2
        ' 
        ' label5
        ' 
        Me.label5.Location = New Point(7, 41)
        Me.label5.Name = "label5"
        Me.label5.Size = New Size(95, 13)
        Me.label5.TabIndex = 40
        Me.label5.Text = "Host:"
        ' 
        ' tbHost
        ' 
        Me.tbHost.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbHost.Location = New Point(108, 38)
        Me.tbHost.Name = "tbHost"
        Me.tbHost.Size = New Size(169, 20)
        Me.tbHost.TabIndex = 1
        ' 
        ' label4
        ' 
        Me.label4.Location = New Point(7, 171)
        Me.label4.Name = "label4"
        Me.label4.Size = New Size(95, 13)
        Me.label4.TabIndex = 39
        Me.label4.Text = "User:"
        ' 
        ' openFileDialog1
        ' 
        Me.openFileDialog1.DefaultExt = "*.fdb"
        Me.openFileDialog1.Filter = "Firebird Databases (*.fdb)|*.fdb|All files|*.*"
        ' 
        ' tbDatabaseLocale
        ' 
        Me.tbDatabaseLocale.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbDatabaseLocale.Location = New Point(108, 142)
        Me.tbDatabaseLocale.Name = "tbDatabaseLocale"
        Me.tbDatabaseLocale.Size = New Size(169, 20)
        Me.tbDatabaseLocale.TabIndex = 5
        ' 
        ' tbUser
        ' 
        Me.tbUser.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbUser.Location = New Point(108, 168)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New Size(169, 20)
        Me.tbUser.TabIndex = 6
        ' 
        ' label3
        ' 
        Me.label3.Location = New Point(7, 15)
        Me.label3.Name = "label3"
        Me.label3.Size = New Size(95, 13)
        Me.label3.TabIndex = 38
        Me.label3.Text = "Server:"
        ' 
        ' tbServer
        ' 
        Me.tbServer.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbServer.Location = New Point(108, 12)
        Me.tbServer.Name = "tbServer"
        Me.tbServer.Size = New Size(169, 20)
        Me.tbServer.TabIndex = 0
        ' 
        ' label2
        ' 
        Me.label2.Location = New Point(7, 197)
        Me.label2.Name = "label2"
        Me.label2.Size = New Size(95, 13)
        Me.label2.TabIndex = 37
        Me.label2.Text = "Password:"
        ' 
        ' tbPassword
        ' 
        Me.tbPassword.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbPassword.Location = New Point(108, 194)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New Size(169, 20)
        Me.tbPassword.TabIndex = 7
        Me.tbPassword.UseSystemPasswordChar = True
        ' 
        ' label1
        ' 
        Me.label1.Location = New Point(7, 119)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(95, 13)
        Me.label1.TabIndex = 36
        Me.label1.Text = "Database:"
        ' 
        ' tbDatabase
        ' 
        Me.tbDatabase.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbDatabase.Location = New Point(108, 116)
        Me.tbDatabase.Name = "tbDatabase"
        Me.tbDatabase.Size = New Size(169, 20)
        Me.tbDatabase.TabIndex = 4
        ' 
        ' InformixConnectionForm
        ' 
        Me.AcceptButton = Me.buttonConnect
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New Size(289, 267)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.tbService)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.tbProtocol)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.tbHost)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.tbDatabaseLocale)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.tbServer)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tbDatabase)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonConnect)
        Me.Name = "InformixConnectionForm"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Connect to Informix database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private buttonCancel As Button
    Private WithEvents buttonConnect As Button
    Private label8 As Label
    Private label7 As Label
    Private tbService As TextBox
    Private label6 As Label
    Private tbProtocol As TextBox
    Private label5 As Label
    Private tbHost As TextBox
    Private label4 As Label
    Private openFileDialog1 As OpenFileDialog
    Private tbDatabaseLocale As TextBox
    Private tbUser As TextBox
    Private label3 As Label
    Private tbServer As TextBox
    Private label2 As Label
    Private tbPassword As TextBox
    Private label1 As Label
    Private tbDatabase As TextBox
End Class
