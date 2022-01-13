Namespace DataViewerControl
    Partial Public Class InfoPanel
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region ""

        Private Sub InitializeComponent()
            Me.label1 = New Label()
            Me.pictureBox1 = New PictureBox()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Dock = DockStyle.Fill
            Me.label1.Location = New Point(0, 0)
            Me.label1.Name = "label1"
            Me.label1.Padding = New Padding(12, 12, 23, 12)
            Me.label1.Size = New Size(35, 37)
            Me.label1.TabIndex = 0
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.Cursor = Cursors.Hand
            Me.pictureBox1.Image = My.Resources.cancel
            Me.pictureBox1.Location = New Point(45, 11)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New Size(16, 16)
            Me.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            Me.pictureBox1.TabIndex = 1
            Me.pictureBox1.TabStop = False
'            Me.pictureBox1.Click += New System.EventHandler(Me.pictureBox1_Click)
            ' 
            ' InfoPanel
            ' 
            Me.AutoScaleDimensions = New SizeF(6F, 13F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.AutoSize = True
            Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
            Me.BackColor = Color.LightCoral
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.label1)
            Me.Name = "InfoPanel"
            Me.Size = New Size(64, 37)
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private label1 As Label
        Private WithEvents pictureBox1 As PictureBox
    End Class
End Namespace
