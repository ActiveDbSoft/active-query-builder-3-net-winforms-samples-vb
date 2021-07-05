


Partial Public Class EditXMLConnectionForm
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
        Me.pnlTop = New Panel()
        Me.label3 = New Label()
        Me.cbSyntax = New ComboBox()
        Me.label2 = New Label()
        Me.tbConnectionName = New TextBox()
        Me.btnOk = New Button()
        Me.btnCancel = New Button()
        Me.openDialog = New OpenFileDialog()
        Me.pbSyntax = New ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar()
        Me.pnlFilePath = New Panel()
        Me.btnOpenDialog = New Button()
        Me.tbXmlPath = New TextBox()
        Me.label4 = New Label()
        Me.pnlTop.SuspendLayout()
        Me.pnlFilePath.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' pnlTop
        ' 
        Me.pnlTop.BackColor = Color.White
        Me.pnlTop.BorderStyle = BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.label3)
        Me.pnlTop.Controls.Add(Me.cbSyntax)
        Me.pnlTop.Controls.Add(Me.label2)
        Me.pnlTop.Controls.Add(Me.tbConnectionName)
        Me.pnlTop.Dock = DockStyle.Top
        Me.pnlTop.Location = New Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Padding = New Padding(6)
        Me.pnlTop.Size = New Size(509, 68)
        Me.pnlTop.TabIndex = 10
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.label3.Location = New Point(9, 39)
        Me.label3.Name = "label3"
        Me.label3.Size = New Size(47, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Syntax"
        ' 
        ' cbSyntax
        ' 
        Me.cbSyntax.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.cbSyntax.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cbSyntax.FormattingEnabled = True
        Me.cbSyntax.Location = New Point(120, 36)
        Me.cbSyntax.Name = "cbSyntax"
        Me.cbSyntax.Size = New Size(378, 21)
        Me.cbSyntax.TabIndex = 4
'			Me.cbSyntax.SelectedIndexChanged += New System.EventHandler(Me.cbSyntax_SelectedIndexChanged)
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.label2.Location = New Point(9, 12)
        Me.label2.Name = "label2"
        Me.label2.Size = New Size(105, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Connection Name"
        ' 
        ' tbConnectionName
        ' 
        Me.tbConnectionName.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.tbConnectionName.Location = New Point(120, 9)
        Me.tbConnectionName.Name = "tbConnectionName"
        Me.tbConnectionName.Size = New Size(378, 20)
        Me.tbConnectionName.TabIndex = 0
        ' 
        ' btnOk
        ' 
        Me.btnOk.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.btnOk.DialogResult = DialogResult.OK
        Me.btnOk.Location = New Point(338, 169)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New Size(78, 23)
        Me.btnOk.TabIndex = 15
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        Me.btnCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(421, 169)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(78, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        ' 
        ' openDialog
        ' 
        Me.openDialog.Filter = "XML files|*xml|All files|*.*"
        ' 
        ' pbSyntax
        ' 
        Me.pbSyntax.AutoScroll = True
        Me.pbSyntax.Dock = DockStyle.Top
        Me.pbSyntax.InformationMessageHost = Nothing
        Me.pbSyntax.Location = New Point(0, 68)
        Me.pbSyntax.Name = "pbSyntax"
        Me.pbSyntax.Size = New Size(509, 50)
        Me.pbSyntax.TabIndex = 18
        ' 
        ' pnlFilePath
        ' 
        Me.pnlFilePath.Controls.Add(Me.btnOpenDialog)
        Me.pnlFilePath.Controls.Add(Me.tbXmlPath)
        Me.pnlFilePath.Controls.Add(Me.label4)
        Me.pnlFilePath.Dock = DockStyle.Top
        Me.pnlFilePath.Location = New Point(0, 118)
        Me.pnlFilePath.Name = "pnlFilePath"
        Me.pnlFilePath.Size = New Size(509, 30)
        Me.pnlFilePath.TabIndex = 19
        ' 
        ' btnOpenDialog
        ' 
        Me.btnOpenDialog.Location = New Point(474, 5)
        Me.btnOpenDialog.Name = "btnOpenDialog"
        Me.btnOpenDialog.Size = New Size(25, 22)
        Me.btnOpenDialog.TabIndex = 17
        Me.btnOpenDialog.Text = "..."
        Me.btnOpenDialog.UseVisualStyleBackColor = True
'			Me.btnOpenDialog.Click += New System.EventHandler(Me.btnOpenDialog_Click)
        ' 
        ' tbXmlPath
        ' 
        Me.tbXmlPath.Location = New Point(121, 6)
        Me.tbXmlPath.Name = "tbXmlPath"
        Me.tbXmlPath.Size = New Size(350, 20)
        Me.tbXmlPath.TabIndex = 16
'			Me.tbXmlPath.TextChanged += New System.EventHandler(Me.tbXmlPath_TextChanged)
        ' 
        ' label4
        ' 
        Me.label4.AutoSize = True
        Me.label4.Location = New Point(10, 9)
        Me.label4.Name = "label4"
        Me.label4.Size = New Size(72, 13)
        Me.label4.TabIndex = 15
        Me.label4.Text = "XML file path:"
        ' 
        ' EditXMLConnectionForm
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(509, 199)
        Me.Controls.Add(Me.pnlFilePath)
        Me.Controls.Add(Me.pbSyntax)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.Name = "EditXMLConnectionForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Edit XML Connection"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlFilePath.ResumeLayout(False)
        Me.pnlFilePath.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private pnlTop As Panel
    Private label3 As Label
    Private WithEvents cbSyntax As ComboBox
    Private label2 As Label
    Private tbConnectionName As TextBox
    Private btnOk As Button
    Private btnCancel As Button
    Private openDialog As OpenFileDialog
    Private pbSyntax As ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar
    Private pnlFilePath As Panel
    Private WithEvents btnOpenDialog As Button
    Private WithEvents tbXmlPath As TextBox
    Private label4 As Label
End Class