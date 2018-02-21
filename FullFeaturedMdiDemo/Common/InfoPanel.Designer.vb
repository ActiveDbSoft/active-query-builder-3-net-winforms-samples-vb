Namespace Common
	Partial Class InfoPanel
		Private components As System.ComponentModel.IContainer = Nothing

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region ""

		Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Padding = New System.Windows.Forms.Padding(12, 12, 23, 12)
        Me.label1.Size = New System.Drawing.Size(35, 37)
        Me.label1.TabIndex = 0
        '
        'pictureBox1
        '
        Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox1.Image = Global.FullFeaturedMdiDemo.Resources.cancel
        Me.pictureBox1.Location = New System.Drawing.Point(45, 11)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = false
        '
        'InfoPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "InfoPanel"
        Me.Size = New System.Drawing.Size(64, 37)
        CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private pictureBox1 As System.Windows.Forms.PictureBox
	End Class
End Namespace
