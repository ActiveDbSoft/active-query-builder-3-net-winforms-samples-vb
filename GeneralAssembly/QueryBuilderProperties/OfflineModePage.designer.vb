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
        Me.bEditMetadata = New System.Windows.Forms.Button()
        Me.bSaveToXML = New System.Windows.Forms.Button()
        Me.bLoadFromXML = New System.Windows.Forms.Button()
        Me.lMetadataObjectCount = New System.Windows.Forms.Label()
        Me.cbOfflineMode = New System.Windows.Forms.CheckBox()
        Me.OpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout
        '
        'bEditMetadata
        '
        Me.bEditMetadata.Location = New System.Drawing.Point(3, 79)
        Me.bEditMetadata.Name = "bEditMetadata"
        Me.bEditMetadata.Size = New System.Drawing.Size(337, 23)
        Me.bEditMetadata.TabIndex = 12
        Me.bEditMetadata.Text = "Edit Metadata Container..."
        Me.bEditMetadata.UseVisualStyleBackColor = true
        '
        'bSaveToXML
        '
        Me.bSaveToXML.Location = New System.Drawing.Point(175, 50)
        Me.bSaveToXML.Name = "bSaveToXML"
        Me.bSaveToXML.Size = New System.Drawing.Size(165, 23)
        Me.bSaveToXML.TabIndex = 13
        Me.bSaveToXML.Text = "Save to XML..."
        Me.bSaveToXML.UseVisualStyleBackColor = true
        '
        'bLoadFromXML
        '
        Me.bLoadFromXML.Location = New System.Drawing.Point(3, 50)
        Me.bLoadFromXML.Name = "bLoadFromXML"
        Me.bLoadFromXML.Size = New System.Drawing.Size(166, 23)
        Me.bLoadFromXML.TabIndex = 14
        Me.bLoadFromXML.Text = "Load from XML..."
        Me.bLoadFromXML.UseVisualStyleBackColor = true
        '
        'lMetadataObjectCount
        '
        Me.lMetadataObjectCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lMetadataObjectCount.Location = New System.Drawing.Point(0, 23)
        Me.lMetadataObjectCount.Name = "lMetadataObjectCount"
        Me.lMetadataObjectCount.Size = New System.Drawing.Size(349, 40)
        Me.lMetadataObjectCount.TabIndex = 11
        Me.lMetadataObjectCount.Text = "Loaded Metadata: {0} tables, {1} views, {2} procedures."
        '
        'cbOfflineMode
        '
        Me.cbOfflineMode.Location = New System.Drawing.Point(3, 3)
        Me.cbOfflineMode.Name = "cbOfflineMode"
        Me.cbOfflineMode.Size = New System.Drawing.Size(394, 17)
        Me.cbOfflineMode.TabIndex = 9
        Me.cbOfflineMode.Text = "Enable Offline Mode"
        Me.cbOfflineMode.UseVisualStyleBackColor = true
        '
        'OpenDialog
        '
        Me.OpenDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        Me.OpenDialog.Title = "Select XML file to load metadata from"
        '
        'SaveDialog
        '
        Me.SaveDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"
        Me.SaveDialog.Title = "Select XML file to save metadata to"
        '
        'OfflineModePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.bEditMetadata)
        Me.Controls.Add(Me.bSaveToXML)
        Me.Controls.Add(Me.bLoadFromXML)
        Me.Controls.Add(Me.lMetadataObjectCount)
        Me.Controls.Add(Me.cbOfflineMode)
        Me.Name = "OfflineModePage"
        Me.Size = New System.Drawing.Size(355, 111)
        Me.ResumeLayout(false)

End Sub

		#End Region

		Private bEditMetadata As Button
		Private bSaveToXML As Button
		Private bLoadFromXML As Button
		Private lMetadataObjectCount As Label
		Private cbOfflineMode As CheckBox
		Private OpenDialog As OpenFileDialog
		Private SaveDialog As SaveFileDialog
	End Class
End Namespace
