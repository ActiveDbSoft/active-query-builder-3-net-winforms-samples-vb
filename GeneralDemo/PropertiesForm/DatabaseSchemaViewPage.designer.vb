Partial Class DatabaseSchemaViewPage
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
		Me.lblGroupObjectsBy = New System.Windows.Forms.Label()
		Me.cbGroupByServers = New System.Windows.Forms.CheckBox()
		Me.cbGroupByDatabases = New System.Windows.Forms.CheckBox()
		Me.cbGroupBySchemas = New System.Windows.Forms.CheckBox()
		Me.cbGroupByTypes = New System.Windows.Forms.CheckBox()
		Me.cbShowFields = New System.Windows.Forms.CheckBox()
		Me.lblSortObjectsBy = New System.Windows.Forms.Label()
		Me.cmbSortObjectsBy = New System.Windows.Forms.ComboBox()
		Me.cmbDefaultExpandLevel = New System.Windows.Forms.ComboBox()
		Me.lblDefaultExpandLevel = New System.Windows.Forms.Label()
		Me.lblExpandLevelNote = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		' 
		' lblGroupObjectsBy
		' 
		Me.lblGroupObjectsBy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblGroupObjectsBy.Location = New System.Drawing.Point(3, 9)
		Me.lblGroupObjectsBy.Name = "lblGroupObjectsBy"
		Me.lblGroupObjectsBy.Size = New System.Drawing.Size(394, 17)
		Me.lblGroupObjectsBy.TabIndex = 13
		Me.lblGroupObjectsBy.Text = "Group objects by:"
		Me.lblGroupObjectsBy.UseCompatibleTextRendering = True
		' 
		' cbGroupByServers
		' 
		Me.cbGroupByServers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbGroupByServers.Location = New System.Drawing.Point(27, 29)
		Me.cbGroupByServers.Name = "cbGroupByServers"
		Me.cbGroupByServers.Size = New System.Drawing.Size(359, 17)
		Me.cbGroupByServers.TabIndex = 0
		Me.cbGroupByServers.Text = "Servers"
		Me.cbGroupByServers.UseVisualStyleBackColor = True
		' 
		' cbGroupByDatabases
		' 
		Me.cbGroupByDatabases.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbGroupByDatabases.Location = New System.Drawing.Point(27, 52)
		Me.cbGroupByDatabases.Name = "cbGroupByDatabases"
		Me.cbGroupByDatabases.Size = New System.Drawing.Size(359, 17)
		Me.cbGroupByDatabases.TabIndex = 1
		Me.cbGroupByDatabases.Text = "Databases"
		Me.cbGroupByDatabases.UseVisualStyleBackColor = True
		' 
		' cbGroupBySchemas
		' 
		Me.cbGroupBySchemas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbGroupBySchemas.Location = New System.Drawing.Point(27, 75)
		Me.cbGroupBySchemas.Name = "cbGroupBySchemas"
		Me.cbGroupBySchemas.Size = New System.Drawing.Size(359, 17)
		Me.cbGroupBySchemas.TabIndex = 2
		Me.cbGroupBySchemas.Text = "Schemas"
		Me.cbGroupBySchemas.UseVisualStyleBackColor = True
		' 
		' cbGroupByTypes
		' 
		Me.cbGroupByTypes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbGroupByTypes.Location = New System.Drawing.Point(27, 98)
		Me.cbGroupByTypes.Name = "cbGroupByTypes"
		Me.cbGroupByTypes.Size = New System.Drawing.Size(359, 17)
		Me.cbGroupByTypes.TabIndex = 3
		Me.cbGroupByTypes.Text = "Types"
		Me.cbGroupByTypes.UseVisualStyleBackColor = True
		' 
		' cbShowFields
		' 
		Me.cbShowFields.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbShowFields.Location = New System.Drawing.Point(4, 128)
		Me.cbShowFields.Name = "cbShowFields"
		Me.cbShowFields.Size = New System.Drawing.Size(382, 17)
		Me.cbShowFields.TabIndex = 4
		Me.cbShowFields.Text = "Show fields"
		Me.cbShowFields.UseVisualStyleBackColor = True
		' 
		' lblSortObjectsBy
		' 
		Me.lblSortObjectsBy.Location = New System.Drawing.Point(3, 156)
		Me.lblSortObjectsBy.Name = "lblSortObjectsBy"
		Me.lblSortObjectsBy.Size = New System.Drawing.Size(130, 17)
		Me.lblSortObjectsBy.TabIndex = 19
		Me.lblSortObjectsBy.Text = "Sort objects by:"
		Me.lblSortObjectsBy.UseCompatibleTextRendering = True
		' 
		' cmbSortObjectsBy
		' 
		Me.cmbSortObjectsBy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cmbSortObjectsBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbSortObjectsBy.FormattingEnabled = True
		Me.cmbSortObjectsBy.Location = New System.Drawing.Point(186, 153)
		Me.cmbSortObjectsBy.Name = "cmbSortObjectsBy"
		Me.cmbSortObjectsBy.Size = New System.Drawing.Size(200, 21)
		Me.cmbSortObjectsBy.TabIndex = 5
		' 
		' cmbDefaultExpandLevel
		' 
		Me.cmbDefaultExpandLevel.FormattingEnabled = True
		Me.cmbDefaultExpandLevel.Items.AddRange(New Object() {"-1", "0", "1", "2", "3", "4"})
		Me.cmbDefaultExpandLevel.Location = New System.Drawing.Point(186, 180)
		Me.cmbDefaultExpandLevel.Name = "cmbDefaultExpandLevel"
		Me.cmbDefaultExpandLevel.Size = New System.Drawing.Size(42, 21)
		Me.cmbDefaultExpandLevel.TabIndex = 20
		' 
		' lblDefaultExpandLevel
		' 
		Me.lblDefaultExpandLevel.Location = New System.Drawing.Point(3, 183)
		Me.lblDefaultExpandLevel.Name = "lblDefaultExpandLevel"
		Me.lblDefaultExpandLevel.Size = New System.Drawing.Size(130, 17)
		Me.lblDefaultExpandLevel.TabIndex = 21
		Me.lblDefaultExpandLevel.Text = "Default expand level:"
		Me.lblDefaultExpandLevel.UseCompatibleTextRendering = True
		' 
		' lblExpandLevelNote
		' 
		Me.lblExpandLevelNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblExpandLevelNote.Location = New System.Drawing.Point(234, 183)
		Me.lblExpandLevelNote.Name = "lblExpandLevelNote"
		Me.lblExpandLevelNote.Size = New System.Drawing.Size(163, 17)
		Me.lblExpandLevelNote.TabIndex = 22
		Me.lblExpandLevelNote.Text = "(-1 expands all nodes)"
		Me.lblExpandLevelNote.UseCompatibleTextRendering = True
		' 
		' DatabaseSchemaViewPage
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.lblExpandLevelNote)
		Me.Controls.Add(Me.cmbDefaultExpandLevel)
		Me.Controls.Add(Me.lblDefaultExpandLevel)
		Me.Controls.Add(Me.cmbSortObjectsBy)
		Me.Controls.Add(Me.lblSortObjectsBy)
		Me.Controls.Add(Me.cbShowFields)
		Me.Controls.Add(Me.cbGroupByTypes)
		Me.Controls.Add(Me.cbGroupBySchemas)
		Me.Controls.Add(Me.cbGroupByDatabases)
		Me.Controls.Add(Me.cbGroupByServers)
		Me.Controls.Add(Me.lblGroupObjectsBy)
		Me.Name = "DatabaseSchemaViewPage"
		Me.Size = New System.Drawing.Size(400, 314)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private lblGroupObjectsBy As System.Windows.Forms.Label
	Private cbGroupByServers As System.Windows.Forms.CheckBox
	Private cbGroupByDatabases As System.Windows.Forms.CheckBox
	Private cbGroupBySchemas As System.Windows.Forms.CheckBox
	Private cbGroupByTypes As System.Windows.Forms.CheckBox
	Private cbShowFields As System.Windows.Forms.CheckBox
	Private lblSortObjectsBy As System.Windows.Forms.Label
	Private cmbSortObjectsBy As System.Windows.Forms.ComboBox
	Private cmbDefaultExpandLevel As System.Windows.Forms.ComboBox
	Private lblDefaultExpandLevel As System.Windows.Forms.Label
	Private lblExpandLevelNote As System.Windows.Forms.Label
End Class
