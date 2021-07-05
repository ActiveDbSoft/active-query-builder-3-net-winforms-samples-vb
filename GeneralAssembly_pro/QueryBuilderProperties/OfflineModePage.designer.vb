Namespace QueryBuilderProperties
	Partial Friend Class OfflineModePage
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
			Me.bEditMetadata = New Button()
			Me.bSaveToXML = New Button()
			Me.bLoadFromXML = New Button()
			Me.lMetadataObjectCount = New Label()
			Me.bLoadMetadata = New Button()
			Me.cbOfflineMode = New CheckBox()
			Me.OpenDialog = New OpenFileDialog()
			Me.SaveDialog = New SaveFileDialog()
			Me.SuspendLayout()
			'
			' bEditMetadata
			'
			Me.bEditMetadata.Location = New Point(3, 128)
			Me.bEditMetadata.Name = "bEditMetadata"
			Me.bEditMetadata.Size = New Size(337, 23)
			Me.bEditMetadata.TabIndex = 12
			Me.bEditMetadata.Text = "Edit Metadata Container..."
			Me.bEditMetadata.UseVisualStyleBackColor = True
			'
			' bSaveToXML
			'
			Me.bSaveToXML.Location = New Point(175, 99)
			Me.bSaveToXML.Name = "bSaveToXML"
			Me.bSaveToXML.Size = New Size(165, 23)
			Me.bSaveToXML.TabIndex = 13
			Me.bSaveToXML.Text = "Save to XML..."
			Me.bSaveToXML.UseVisualStyleBackColor = True
			'
			' bLoadFromXML
			'
			Me.bLoadFromXML.Location = New Point(3, 99)
			Me.bLoadFromXML.Name = "bLoadFromXML"
			Me.bLoadFromXML.Size = New Size(166, 23)
			Me.bLoadFromXML.TabIndex = 14
			Me.bLoadFromXML.Text = "Load from XML..."
			Me.bLoadFromXML.UseVisualStyleBackColor = True
			'
			' lMetadataObjectCount
			'
			Me.lMetadataObjectCount.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.lMetadataObjectCount.Location = New Point(3, 56)
			Me.lMetadataObjectCount.Name = "lMetadataObjectCount"
			Me.lMetadataObjectCount.Size = New Size(349, 40)
			Me.lMetadataObjectCount.TabIndex = 11
			Me.lMetadataObjectCount.Text = "Loaded Metadata: {0} tables, {1} views, {2} procedures."
			'
			' bLoadMetadata
			'
			Me.bLoadMetadata.Location = New Point(3, 26)
			Me.bLoadMetadata.Name = "bLoadMetadata"
			Me.bLoadMetadata.Size = New Size(337, 23)
			Me.bLoadMetadata.TabIndex = 10
			Me.bLoadMetadata.Text = "Load metadata to work in Offline mode..."
			Me.bLoadMetadata.UseVisualStyleBackColor = True
			'
			' cbOfflineMode
			'
			Me.cbOfflineMode.Location = New Point(3, 3)
			Me.cbOfflineMode.Name = "cbOfflineMode"
			Me.cbOfflineMode.Size = New Size(394, 17)
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
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.bEditMetadata)
			Me.Controls.Add(Me.bSaveToXML)
			Me.Controls.Add(Me.bLoadFromXML)
			Me.Controls.Add(Me.lMetadataObjectCount)
			Me.Controls.Add(Me.bLoadMetadata)
			Me.Controls.Add(Me.cbOfflineMode)
			Me.Name = "OfflineModePage"
			Me.Size = New Size(355, 177)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private bEditMetadata As Button
		Private bSaveToXML As Button
		Private bLoadFromXML As Button
		Private lMetadataObjectCount As Label
		Private bLoadMetadata As Button
		Private cbOfflineMode As CheckBox
		Private OpenDialog As OpenFileDialog
		Private SaveDialog As SaveFileDialog
	End Class
End Namespace
