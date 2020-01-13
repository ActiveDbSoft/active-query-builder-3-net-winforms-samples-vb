<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InformationPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbText = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout
        CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.pnlMain.Controls.Add(Me.pictureBox1)
        Me.pnlMain.Controls.Add(Me.lbText)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(317, 84)
        Me.pnlMain.TabIndex = 2
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pictureBox1.Image = Global.FullFeaturedMdiDemo.Resources.info
        Me.pictureBox1.Location = New System.Drawing.Point(297, 32)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(17, 17)
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = false
        '
        'lbText
        '
        Me.lbText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lbText.Location = New System.Drawing.Point(3, 3)
        Me.lbText.Name = "lbText"
        Me.lbText.Size = New System.Drawing.Size(291, 81)
        Me.lbText.TabIndex = 0
        '
        'InformationPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "InformationPanel"
        Me.Size = New System.Drawing.Size(317, 84)
        Me.pnlMain.ResumeLayout(false)
        CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Private pnlMain As System.Windows.Forms.Panel
    Private lbText As System.Windows.Forms.Label
    Private pictureBox1 As System.Windows.Forms.PictureBox
End Class
