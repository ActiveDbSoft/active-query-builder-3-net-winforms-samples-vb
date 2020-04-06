
Partial Public Class PostgreSQLConnectionForm
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
        Me.label2 = New Label()
        Me.tbPort = New TextBox()
        Me.label3 = New Label()
        Me.label4 = New Label()
        Me.tbPassword = New TextBox()
        Me.tbLogin = New TextBox()
        Me.label1 = New Label()
        Me.tbServer = New TextBox()
        Me.label5 = New Label()
        Me.tbDatabase = New TextBox()
        Me.SuspendLayout()
        ' 
        ' buttonCancel
        ' 
        Me.buttonCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.buttonCancel.DialogResult = DialogResult.Cancel
        Me.buttonCancel.Location = New Point(167, 154)
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
        Me.buttonConnect.Location = New Point(86, 154)
        Me.buttonConnect.Name = "buttonConnect"
        Me.buttonConnect.Size = New Size(75, 23)
        Me.buttonConnect.TabIndex = 5
        Me.buttonConnect.Text = "Connect"
        Me.buttonConnect.UseVisualStyleBackColor = True
'			Me.buttonConnect.Click += New System.EventHandler(Me.buttonConnect_Click)
        ' 
        ' label2
        ' 
        Me.label2.Location = New Point(12, 41)
        Me.label2.Name = "label2"
        Me.label2.Size = New Size(80, 13)
        Me.label2.TabIndex = 27
        Me.label2.Text = "Port:"
        ' 
        ' tbPort
        ' 
        Me.tbPort.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbPort.Location = New Point(98, 38)
        Me.tbPort.Name = "tbPort"
        Me.tbPort.Size = New Size(144, 20)
        Me.tbPort.TabIndex = 1
        Me.tbPort.Text = "5432"
        ' 
        ' label3
        ' 
        Me.label3.Location = New Point(12, 93)
        Me.label3.Name = "label3"
        Me.label3.Size = New Size(80, 13)
        Me.label3.TabIndex = 25
        Me.label3.Text = "Login:"
        ' 
        ' label4
        ' 
        Me.label4.Location = New Point(12, 119)
        Me.label4.Name = "label4"
        Me.label4.Size = New Size(80, 13)
        Me.label4.TabIndex = 24
        Me.label4.Text = "Password:"
        ' 
        ' tbPassword
        ' 
        Me.tbPassword.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbPassword.Location = New Point(98, 116)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New Size(144, 20)
        Me.tbPassword.TabIndex = 4
        Me.tbPassword.UseSystemPasswordChar = True
        ' 
        ' tbLogin
        ' 
        Me.tbLogin.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbLogin.Location = New Point(98, 90)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Size = New Size(144, 20)
        Me.tbLogin.TabIndex = 3
        Me.tbLogin.Text = "postgres"
        ' 
        ' label1
        ' 
        Me.label1.Location = New Point(12, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(80, 13)
        Me.label1.TabIndex = 21
        Me.label1.Text = "Server:"
        ' 
        ' tbServer
        ' 
        Me.tbServer.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbServer.Location = New Point(98, 12)
        Me.tbServer.Name = "tbServer"
        Me.tbServer.Size = New Size(144, 20)
        Me.tbServer.TabIndex = 0
        Me.tbServer.Text = "localhost"
        ' 
        ' label5
        ' 
        Me.label5.Location = New Point(12, 67)
        Me.label5.Name = "label5"
        Me.label5.Size = New Size(80, 13)
        Me.label5.TabIndex = 29
        Me.label5.Text = "Database:"
        ' 
        ' tbDatabase
        ' 
        Me.tbDatabase.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbDatabase.Location = New Point(98, 64)
        Me.tbDatabase.Name = "tbDatabase"
        Me.tbDatabase.Size = New Size(144, 20)
        Me.tbDatabase.TabIndex = 2
        ' 
        ' PostgreSQLConnectionForm
        ' 
        Me.AcceptButton = Me.buttonConnect
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New Size(254, 189)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.tbDatabase)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.tbPort)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbLogin)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tbServer)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonConnect)
        Me.Name = "PostgreSQLConnectionForm"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Connect to PostgreSQL database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private buttonCancel As Button
    Private WithEvents buttonConnect As Button
    Private label2 As Label
    Private tbPort As TextBox
    Private label3 As Label
    Private label4 As Label
    Private tbPassword As TextBox
    Private tbLogin As TextBox
    Private label1 As Label
    Private tbServer As TextBox
    Private label5 As Label
    Private tbDatabase As TextBox
End Class
