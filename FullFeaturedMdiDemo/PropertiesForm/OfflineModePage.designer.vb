Namespace PropertiesForm
	Partial Class OfflineModePage
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
			Me.bEditMetadata = New System.Windows.Forms.Button()
			Me.bSaveToXML = New System.Windows.Forms.Button()
			Me.bLoadFromXML = New System.Windows.Forms.Button()
			Me.lMetadataObjectCount = New System.Windows.Forms.Label()
			Me.bLoadMetadata = New System.Windows.Forms.Button()
			Me.cbOfflineMode = New System.Windows.Forms.CheckBox()
			Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
			Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
			Me.SuspendLayout()
			' 
			' bEditMetadata
			' 
			Me.bEditMetadata.Location = New System.Drawing.Point(3, 128)
			Me.bEditMetadata.Name = "bEditMetadata"
			Me.bEditMetadata.Size = New System.Drawing.Size(337, 23)
			Me.bEditMetadata.TabIndex = 12
			Me.bEditMetadata.Text = "Edit Metadata Container..."
			Me.bEditMetadata.UseVisualStyleBackColor = True
			' 
			' bSaveToXML
			' 
			Me.bSaveToXML.Location = New System.Drawing.Point(175, 99)
			Me.bSaveToXML.Name = "bSaveToXML"
			Me.bSaveToXML.Size = New System.Drawing.Size(165, 23)
			Me.bSaveToXML.TabIndex = 13
			Me.bSaveToXML.Text = "Save to XML..."
			Me.bSaveToXML.UseVisualStyleBackColor = True
			' 
			' bLoadFromXML
			' 
			Me.bLoadFromXML.Location = New System.Drawing.Point(3, 99)
			Me.bLoadFromXML.Name = "bLoadFromXML"
			Me.bLoadFromXML.Size = New System.Drawing.Size(166, 23)
			Me.bLoadFromXML.TabIndex = 14
			Me.bLoadFromXML.Text = "Load from XML..."
			Me.bLoadFromXML.UseVisualStyleBackColor = True
			' 
			' lMetadataObjectCount
			' 
			Me.lMetadataObjectCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.lMetadataObjectCount.Location = New System.Drawing.Point(3, 56)
			Me.lMetadataObjectCount.Name = "lMetadataObjectCount"
			Me.lMetadataObjectCount.Size = New System.Drawing.Size(349, 40)
			Me.lMetadataObjectCount.TabIndex = 11
			Me.lMetadataObjectCount.Text = "Loaded Metadata: {0} tables, {1} views, {2} procedures."
			' 
			' bLoadMetadata
			' 
			Me.bLoadMetadata.Location = New System.Drawing.Point(3, 26)
			Me.bLoadMetadata.Name = "bLoadMetadata"
			Me.bLoadMetadata.Size = New System.Drawing.Size(337, 23)
			Me.bLoadMetadata.TabIndex = 10
			Me.bLoadMetadata.Text = "Load metadata to work in Offline mode..."
			Me.bLoadMetadata.UseVisualStyleBackColor = True
			' 
			' cbOfflineMode
			' 
			Me.cbOfflineMode.Location = New System.Drawing.Point(3, 3)
			Me.cbOfflineMode.Name = "cbOfflineMode"
			Me.cbOfflineMode.Size = New System.Drawing.Size(394, 17)
			Me.cbOfflineMode.TabIndex = 9
			Me.cbOfflineMode.Text = "Enable Offline Mode"
			Me.cbOfflineMode.UseVisualStyleBackColor = True
			' 
			' OpenDialog
			' 
			Me.OpenDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
			Me.OpenDialog.Title = "Select XML file to load metadata from"
			' 
			' SaveDialog
			' 
			Me.SaveDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
			Me.SaveDialog.Title = "Select XML file to save metadata to"
			' 
			' OfflineModePage
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.bEditMetadata)
			Me.Controls.Add(Me.bSaveToXML)
			Me.Controls.Add(Me.bLoadFromXML)
			Me.Controls.Add(Me.lMetadataObjectCount)
			Me.Controls.Add(Me.bLoadMetadata)
			Me.Controls.Add(Me.cbOfflineMode)
			Me.Name = "OfflineModePage"
			Me.Size = New System.Drawing.Size(355, 177)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private bEditMetadata As System.Windows.Forms.Button
		Private bSaveToXML As System.Windows.Forms.Button
		Private bLoadFromXML As System.Windows.Forms.Button
		Private lMetadataObjectCount As System.Windows.Forms.Label
		Private bLoadMetadata As System.Windows.Forms.Button
		Private cbOfflineMode As System.Windows.Forms.CheckBox
		Private OpenDialog As System.Windows.Forms.OpenFileDialog
		Private SaveDialog As System.Windows.Forms.SaveFileDialog
	End Class
End Namespace
