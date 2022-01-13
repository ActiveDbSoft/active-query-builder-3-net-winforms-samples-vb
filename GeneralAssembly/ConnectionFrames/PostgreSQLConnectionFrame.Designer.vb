Namespace ConnectionFrames
    Public NotInheritable Partial Class PostgreSQLConnectionFrame
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
            Me.btnEditConnectionString = New Button()
            Me.label5 = New Label()
            Me.tbDatabase = New TextBox()
            Me.label2 = New Label()
            Me.tbPort = New TextBox()
            Me.label3 = New Label()
            Me.label4 = New Label()
            Me.tbPassword = New TextBox()
            Me.tbUserName = New TextBox()
            Me.label1 = New Label()
            Me.tbHost = New TextBox()
            Me.SuspendLayout()
            ' 
            ' btnEditConnectionString
            ' 
            Me.btnEditConnectionString.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
            Me.btnEditConnectionString.Location = New Point(78, 149)
            Me.btnEditConnectionString.Name = "btnEditConnectionString"
            Me.btnEditConnectionString.Size = New Size(133, 23)
            Me.btnEditConnectionString.TabIndex = 5
            Me.btnEditConnectionString.Text = "Edit Connection String"
            Me.btnEditConnectionString.UseVisualStyleBackColor = True
'            Me.btnEditConnectionString.Click += New System.EventHandler(Me.btnEditConnectionString_Click)
            ' 
            ' label5
            ' 
            Me.label5.AutoSize = True
            Me.label5.Location = New Point(3, 58)
            Me.label5.Name = "label5"
            Me.label5.Size = New Size(56, 13)
            Me.label5.TabIndex = 39
            Me.label5.Text = "Database:"
            ' 
            ' tbDatabase
            ' 
            Me.tbDatabase.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.tbDatabase.Location = New Point(65, 55)
            Me.tbDatabase.Name = "tbDatabase"
            Me.tbDatabase.Size = New Size(146, 20)
            Me.tbDatabase.TabIndex = 2
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New Point(3, 32)
            Me.label2.Name = "label2"
            Me.label2.Size = New Size(29, 13)
            Me.label2.TabIndex = 38
            Me.label2.Text = "Port:"
            ' 
            ' tbPort
            ' 
            Me.tbPort.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.tbPort.Location = New Point(65, 29)
            Me.tbPort.Name = "tbPort"
            Me.tbPort.Size = New Size(146, 20)
            Me.tbPort.TabIndex = 1
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Location = New Point(3, 84)
            Me.label3.Name = "label3"
            Me.label3.Size = New Size(36, 13)
            Me.label3.TabIndex = 37
            Me.label3.Text = "Login:"
            ' 
            ' label4
            ' 
            Me.label4.AutoSize = True
            Me.label4.Location = New Point(3, 110)
            Me.label4.Name = "label4"
            Me.label4.Size = New Size(56, 13)
            Me.label4.TabIndex = 36
            Me.label4.Text = "Password:"
            ' 
            ' tbPassword
            ' 
            Me.tbPassword.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.tbPassword.Location = New Point(65, 107)
            Me.tbPassword.Name = "tbPassword"
            Me.tbPassword.Size = New Size(146, 20)
            Me.tbPassword.TabIndex = 4
            Me.tbPassword.UseSystemPasswordChar = True
            ' 
            ' tbUserName
            ' 
            Me.tbUserName.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.tbUserName.Location = New Point(65, 81)
            Me.tbUserName.Name = "tbUserName"
            Me.tbUserName.Size = New Size(146, 20)
            Me.tbUserName.TabIndex = 3
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New Point(3, 6)
            Me.label1.Name = "label1"
            Me.label1.Size = New Size(32, 13)
            Me.label1.TabIndex = 35
            Me.label1.Text = "Host:"
            ' 
            ' tbHost
            ' 
            Me.tbHost.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.tbHost.Location = New Point(65, 3)
            Me.tbHost.Name = "tbHost"
            Me.tbHost.Size = New Size(146, 20)
            Me.tbHost.TabIndex = 0
            ' 
            ' PostgreSQLConnectionFrame
            ' 
            Me.AutoScaleDimensions = New SizeF(6F, 13F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.tbDatabase)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.tbPort)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.tbPassword)
            Me.Controls.Add(Me.tbUserName)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.tbHost)
            Me.Controls.Add(Me.btnEditConnectionString)
            Me.Name = "PostgreSQLConnectionFrame"
            Me.Size = New Size(214, 175)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private WithEvents btnEditConnectionString As Button
        Private label5 As Label
        Private tbDatabase As TextBox
        Private label2 As Label
        Private tbPort As TextBox
        Private label3 As Label
        Private label4 As Label
        Private tbPassword As TextBox
        Private tbUserName As TextBox
        Private label1 As Label
        Private tbHost As TextBox

    End Class
End Namespace
