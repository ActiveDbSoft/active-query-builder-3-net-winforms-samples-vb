Namespace Common
    Partial Public Class InformationPanel
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.pnlMain = New Panel()
            Me.pictureBox1 = New PictureBox()
            Me.lbText = New Label()
            Me.pnlMain.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pnlMain
            ' 
            Me.pnlMain.BackColor = Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))))
            Me.pnlMain.Controls.Add(Me.pictureBox1)
            Me.pnlMain.Controls.Add(Me.lbText)
            Me.pnlMain.Dock = DockStyle.Fill
            Me.pnlMain.Location = New Point(0, 0)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Size = New Size(317, 84)
            Me.pnlMain.TabIndex = 2
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.Anchor = AnchorStyles.Right
            Me.pictureBox1.Image = My.Resources.info
            Me.pictureBox1.Location = New Point(297, 32)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New Size(17, 17)
            Me.pictureBox1.TabIndex = 1
            Me.pictureBox1.TabStop = False
            ' 
            ' lbText
            ' 
            Me.lbText.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.lbText.Location = New Point(3, 3)
            Me.lbText.Name = "lbText"
            Me.lbText.Size = New Size(291, 81)
            Me.lbText.TabIndex = 0
            ' 
            ' InformationPanel
            ' 
            Me.AutoScaleDimensions = New SizeF(6F, 13F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.pnlMain)
            Me.Name = "InformationPanel"
            Me.Size = New Size(317, 84)
            Me.pnlMain.ResumeLayout(False)
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private pnlMain As Panel
        Private lbText As Label
        Private pictureBox1 As PictureBox
    End Class
End Namespace
