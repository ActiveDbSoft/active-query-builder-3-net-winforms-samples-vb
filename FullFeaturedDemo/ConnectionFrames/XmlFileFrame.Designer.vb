Namespace ConnectionFrames
	Partial Class XmlFileFrame
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.tbXmlFile = New System.Windows.Forms.TextBox()
			Me.btnBrowse = New System.Windows.Forms.Button()
			Me.btnLoadMetadata = New System.Windows.Forms.Button()
			Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
			Me.label2 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(3, 67)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(51, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "XML File:"
			' 
			' tbXmlFile
			' 
			Me.tbXmlFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.tbXmlFile.Location = New System.Drawing.Point(60, 64)
			Me.tbXmlFile.Name = "tbXmlFile"
			Me.tbXmlFile.Size = New System.Drawing.Size(193, 20)
			Me.tbXmlFile.TabIndex = 1
			' 
			' btnBrowse
			' 
			Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.btnBrowse.Location = New System.Drawing.Point(259, 62)
			Me.btnBrowse.Name = "btnBrowse"
			Me.btnBrowse.Size = New System.Drawing.Size(25, 23)
			Me.btnBrowse.TabIndex = 2
			Me.btnBrowse.Text = "..."
			Me.btnBrowse.UseVisualStyleBackColor = True
			AddHandler Me.btnBrowse.Click, New System.EventHandler(AddressOf Me.btnBrowse_Click)
			' 
			' btnLoadMetadata
			' 
			Me.btnLoadMetadata.Location = New System.Drawing.Point(60, 35)
			Me.btnLoadMetadata.Name = "btnLoadMetadata"
			Me.btnLoadMetadata.Size = New System.Drawing.Size(193, 23)
			Me.btnLoadMetadata.TabIndex = 0
			Me.btnLoadMetadata.Text = "Load Metadata"
			Me.btnLoadMetadata.UseVisualStyleBackColor = True
			AddHandler Me.btnLoadMetadata.Click, New System.EventHandler(AddressOf Me.btnLoadMetadata_Click)
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.DefaultExt = "xml"
			Me.openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files|*.*"
			' 
			' label2
			' 
			Me.label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.label2.Location = New System.Drawing.Point(3, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(281, 32)
			Me.label2.TabIndex = 4
			Me.label2.Text = "Create new XML file using the Load Metadata button or specify previously saved XM" & "L file."
			' 
			' XmlFileFrame
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.btnLoadMetadata)
			Me.Controls.Add(Me.btnBrowse)
			Me.Controls.Add(Me.tbXmlFile)
			Me.Controls.Add(Me.label1)
			Me.Name = "XmlFileFrame"
			Me.Size = New System.Drawing.Size(287, 199)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private tbXmlFile As System.Windows.Forms.TextBox
		Private btnBrowse As System.Windows.Forms.Button
		Private btnLoadMetadata As System.Windows.Forms.Button
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private label2 As System.Windows.Forms.Label


	End Class
End Namespace
