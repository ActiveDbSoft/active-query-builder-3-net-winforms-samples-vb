Imports ActiveQueryBuilder.View.WinForms.QueryView
Imports ActiveQueryBuilder.View.WinForms.DatabaseSchemaView
Partial Class ConnectionForm
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
		Me.components = New System.ComponentModel.Container()
		Dim propertiesEditorsOptions1 As New ActiveQueryBuilder.Core.PropertiesEditors.PropertiesEditorsOptions()
		Dim propertiesEditorsOptions2 As New ActiveQueryBuilder.Core.PropertiesEditors.PropertiesEditorsOptions()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.lbMenu = New System.Windows.Forms.ListBox()
		Me.tcProperties = New System.Windows.Forms.TabControl()
		Me.tpConnection = New System.Windows.Forms.TabPage()
		Me.pbConnection = New ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar()
		Me.cbLoadFromDefaultDatabase = New System.Windows.Forms.CheckBox()
		Me.pbSyntax = New ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar()
		Me.pnlTop = New System.Windows.Forms.Panel()
		Me.label3 = New System.Windows.Forms.Label()
		Me.cbSyntax = New System.Windows.Forms.ComboBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.cbConnectionType = New System.Windows.Forms.ComboBox()
		Me.tpFilter = New System.Windows.Forms.TabPage()
		Me.tcFilters = New System.Windows.Forms.TabControl()
		Me.tpInclude = New System.Windows.Forms.TabPage()
		Me.lvInclude = New System.Windows.Forms.ListView()
		Me.imageList = New System.Windows.Forms.ImageList(Me.components)
		Me.tpExclude = New System.Windows.Forms.TabPage()
		Me.lvExclude = New System.Windows.Forms.ListView()
		Me.databaseSchemaView1 = New ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.btnDeleteFilter = New System.Windows.Forms.Button()
		Me.btnAddFilter = New System.Windows.Forms.Button()
		Me.tcProperties.SuspendLayout()
		Me.tpConnection.SuspendLayout()
		Me.pbConnection.SuspendLayout()
		Me.pnlTop.SuspendLayout()
		Me.tpFilter.SuspendLayout()
		Me.tcFilters.SuspendLayout()
		Me.tpInclude.SuspendLayout()
		Me.tpExclude.SuspendLayout()
		Me.panel1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' btnOk
		' 
		Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnOk.Location = New System.Drawing.Point(382, 378)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(78, 23)
		Me.btnOk.TabIndex = 5
		Me.btnOk.Text = "OK"
		Me.btnOk.UseVisualStyleBackColor = True
		' 
		' btnCancel
		' 
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(463, 378)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(78, 23)
		Me.btnCancel.TabIndex = 6
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		' 
		' lbMenu
		' 
		Me.lbMenu.Font = New System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.lbMenu.FormattingEnabled = True
		Me.lbMenu.ItemHeight = 16
		Me.lbMenu.Items.AddRange(New Object() {"Connection", "Filter"})
		Me.lbMenu.Location = New System.Drawing.Point(8, 13)
		Me.lbMenu.Name = "lbMenu"
		Me.lbMenu.Size = New System.Drawing.Size(120, 356)
		Me.lbMenu.TabIndex = 7
		AddHandler Me.lbMenu.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lbMenu_SelectedIndexChanged)
		' 
		' tcProperties
		' 
		Me.tcProperties.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
		Me.tcProperties.Controls.Add(Me.tpConnection)
		Me.tcProperties.Controls.Add(Me.tpFilter)
		Me.tcProperties.ItemSize = New System.Drawing.Size(0, 1)
		Me.tcProperties.Location = New System.Drawing.Point(134, 8)
		Me.tcProperties.Margin = New System.Windows.Forms.Padding(0)
		Me.tcProperties.Name = "tcProperties"
		Me.tcProperties.Padding = New System.Drawing.Point(0, 0)
		Me.tcProperties.SelectedIndex = 0
		Me.tcProperties.Size = New System.Drawing.Size(410, 368)
		Me.tcProperties.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
		Me.tcProperties.TabIndex = 9
		' 
		' tpConnection
		' 
		Me.tpConnection.Controls.Add(Me.pbConnection)
		Me.tpConnection.Controls.Add(Me.pbSyntax)
		Me.tpConnection.Controls.Add(Me.pnlTop)
		Me.tpConnection.Location = New System.Drawing.Point(4, 5)
		Me.tpConnection.Margin = New System.Windows.Forms.Padding(0)
		Me.tpConnection.Name = "tpConnection"
		Me.tpConnection.Size = New System.Drawing.Size(402, 359)
		Me.tpConnection.TabIndex = 0
		Me.tpConnection.Text = "tabPage1"
		Me.tpConnection.UseVisualStyleBackColor = True
		' 
		' pbConnection
		' 
		Me.pbConnection.Controls.Add(Me.cbLoadFromDefaultDatabase)
		Me.pbConnection.Dock = System.Windows.Forms.DockStyle.Fill
		propertiesEditorsOptions1.CaptionsMaxWidth = 120
		propertiesEditorsOptions1.DescriptionMaxHeight = 200
		propertiesEditorsOptions1.DescriptionMaxWidth = 200
		propertiesEditorsOptions1.DescriptionMinWidth = 150
		propertiesEditorsOptions1.MultiLineEditorsCaptionPosition = ActiveQueryBuilder.Core.PropertiesEditors.MultiLineEditorCaptionPosition.Above
		propertiesEditorsOptions1.MultiLineEditorsMaxWidth = 500
		propertiesEditorsOptions1.MultiLineEditorsMinWidth = 120
		propertiesEditorsOptions1.NarrowEditControlsMaxWidth = 80
		propertiesEditorsOptions1.NarrowEditControlsMinWidth = 80
		propertiesEditorsOptions1.ShowDescriptions = False
		propertiesEditorsOptions1.WideEditControlsMaxWidth = 500
		propertiesEditorsOptions1.WideEditControlsMinWidth = 120
		Me.pbConnection.EditorsOptions = propertiesEditorsOptions1
		Me.pbConnection.InformationMessageHost = Nothing
		Me.pbConnection.Location = New System.Drawing.Point(0, 96)
		Me.pbConnection.Name = "pbConnection"
		Me.pbConnection.Size = New System.Drawing.Size(402, 263)
		Me.pbConnection.TabIndex = 0
		' 
		' cbLoadFromDefaultDatabase
		' 
		Me.cbLoadFromDefaultDatabase.AutoSize = True
		Me.cbLoadFromDefaultDatabase.Checked = True
		Me.cbLoadFromDefaultDatabase.CheckState = System.Windows.Forms.CheckState.Checked
		Me.cbLoadFromDefaultDatabase.Location = New System.Drawing.Point(11, 200)
		Me.cbLoadFromDefaultDatabase.Name = "cbLoadFromDefaultDatabase"
		Me.cbLoadFromDefaultDatabase.Size = New System.Drawing.Size(155, 17)
		Me.cbLoadFromDefaultDatabase.TabIndex = 0
		Me.cbLoadFromDefaultDatabase.Text = "Load from default database"
		Me.cbLoadFromDefaultDatabase.UseVisualStyleBackColor = True
		AddHandler Me.cbLoadFromDefaultDatabase.CheckedChanged, New System.EventHandler(AddressOf Me.cbLoadFromDefaultDatabase_CheckedChanged)
		' 
		' pbSyntax
		' 
		Me.pbSyntax.Dock = System.Windows.Forms.DockStyle.Top
		propertiesEditorsOptions2.CaptionsMaxWidth = 120
		propertiesEditorsOptions2.DescriptionMaxHeight = 200
		propertiesEditorsOptions2.DescriptionMaxWidth = 200
		propertiesEditorsOptions2.DescriptionMinWidth = 150
		propertiesEditorsOptions2.MultiLineEditorsCaptionPosition = ActiveQueryBuilder.Core.PropertiesEditors.MultiLineEditorCaptionPosition.Above
		propertiesEditorsOptions2.MultiLineEditorsMaxWidth = 500
		propertiesEditorsOptions2.MultiLineEditorsMinWidth = 120
		propertiesEditorsOptions2.NarrowEditControlsMaxWidth = 80
		propertiesEditorsOptions2.NarrowEditControlsMinWidth = 80
		propertiesEditorsOptions2.ShowDescriptions = False
		propertiesEditorsOptions2.WideEditControlsMaxWidth = 500
		propertiesEditorsOptions2.WideEditControlsMinWidth = 120
		Me.pbSyntax.EditorsOptions = propertiesEditorsOptions2
		Me.pbSyntax.InformationMessageHost = Nothing
		Me.pbSyntax.Location = New System.Drawing.Point(0, 31)
		Me.pbSyntax.Name = "pbSyntax"
		Me.pbSyntax.Size = New System.Drawing.Size(402, 65)
		Me.pbSyntax.TabIndex = 2
		' 
		' pnlTop
		' 
		Me.pnlTop.BackColor = System.Drawing.Color.White
		Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlTop.Controls.Add(Me.label3)
		Me.pnlTop.Controls.Add(Me.cbSyntax)
		Me.pnlTop.Controls.Add(Me.label1)
		Me.pnlTop.Controls.Add(Me.cbConnectionType)
		Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlTop.Location = New System.Drawing.Point(0, 0)
		Me.pnlTop.Name = "pnlTop"
		Me.pnlTop.Padding = New System.Windows.Forms.Padding(6)
		Me.pnlTop.Size = New System.Drawing.Size(402, 31)
		Me.pnlTop.TabIndex = 9
		' 
		' label3
		' 
		Me.label3.AutoSize = True
		Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.label3.Location = New System.Drawing.Point(9, 33)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(47, 13)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Syntax"
		' 
		' cbSyntax
		' 
		Me.cbSyntax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbSyntax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbSyntax.FormattingEnabled = True
		Me.cbSyntax.Location = New System.Drawing.Point(120, 30)
		Me.cbSyntax.Name = "cbSyntax"
		Me.cbSyntax.Size = New System.Drawing.Size(271, 21)
		Me.cbSyntax.TabIndex = 4
		AddHandler Me.cbSyntax.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbSyntax_SelectedIndexChanged)
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(204))
		Me.label1.Location = New System.Drawing.Point(9, 6)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(101, 13)
		Me.label1.TabIndex = 3
		Me.label1.Text = "Connection Type"
		' 
		' cbConnectionType
		' 
		Me.cbConnectionType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.cbConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbConnectionType.FormattingEnabled = True
		Me.cbConnectionType.Location = New System.Drawing.Point(120, 3)
		Me.cbConnectionType.Name = "cbConnectionType"
		Me.cbConnectionType.Size = New System.Drawing.Size(271, 21)
		Me.cbConnectionType.TabIndex = 2
		AddHandler Me.cbConnectionType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbConnectionType_SelectedIndexChanged)
		' 
		' tpFilter
		' 
		Me.tpFilter.Controls.Add(Me.tcFilters)
		Me.tpFilter.Controls.Add(Me.databaseSchemaView1)
		Me.tpFilter.Controls.Add(Me.panel1)
		Me.tpFilter.Location = New System.Drawing.Point(4, 5)
		Me.tpFilter.Name = "tpFilter"
		Me.tpFilter.Padding = New System.Windows.Forms.Padding(3)
		Me.tpFilter.Size = New System.Drawing.Size(402, 359)
		Me.tpFilter.TabIndex = 1
		Me.tpFilter.Text = "tabPage2"
		Me.tpFilter.UseVisualStyleBackColor = True
		' 
		' tcFilters
		' 
		Me.tcFilters.Controls.Add(Me.tpInclude)
		Me.tcFilters.Controls.Add(Me.tpExclude)
		Me.tcFilters.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tcFilters.Location = New System.Drawing.Point(180, 3)
		Me.tcFilters.Name = "tcFilters"
		Me.tcFilters.SelectedIndex = 0
		Me.tcFilters.Size = New System.Drawing.Size(219, 331)
		Me.tcFilters.TabIndex = 1
		' 
		' tpInclude
		' 
		Me.tpInclude.Controls.Add(Me.lvInclude)
		Me.tpInclude.Location = New System.Drawing.Point(4, 22)
		Me.tpInclude.Name = "tpInclude"
		Me.tpInclude.Padding = New System.Windows.Forms.Padding(3)
		Me.tpInclude.Size = New System.Drawing.Size(211, 305)
		Me.tpInclude.TabIndex = 0
		Me.tpInclude.Text = "Include"
		Me.tpInclude.UseVisualStyleBackColor = True
		' 
		' lvInclude
		' 
		Me.lvInclude.AllowDrop = True
		Me.lvInclude.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lvInclude.Location = New System.Drawing.Point(3, 3)
		Me.lvInclude.Name = "lvInclude"
		Me.lvInclude.Size = New System.Drawing.Size(205, 299)
		Me.lvInclude.SmallImageList = Me.imageList
		Me.lvInclude.TabIndex = 6
		Me.lvInclude.UseCompatibleStateImageBehavior = False
		Me.lvInclude.View = System.Windows.Forms.View.List
		AddHandler Me.lvInclude.DragDrop, New System.Windows.Forms.DragEventHandler(AddressOf Me.lbInclude_DragDrop)
		AddHandler Me.lvInclude.DragOver, New System.Windows.Forms.DragEventHandler(AddressOf Me.lbInclude_DragOver)
		' 
		' imageList
		' 
		Me.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
		Me.imageList.ImageSize = New System.Drawing.Size(16, 16)
		Me.imageList.TransparentColor = System.Drawing.Color.Transparent
		' 
		' tpExclude
		' 
		Me.tpExclude.Controls.Add(Me.lvExclude)
		Me.tpExclude.Location = New System.Drawing.Point(4, 22)
		Me.tpExclude.Name = "tpExclude"
		Me.tpExclude.Padding = New System.Windows.Forms.Padding(3)
		Me.tpExclude.Size = New System.Drawing.Size(211, 305)
		Me.tpExclude.TabIndex = 1
		Me.tpExclude.Text = "Exclude"
		Me.tpExclude.UseVisualStyleBackColor = True
		' 
		' lvExclude
		' 
		Me.lvExclude.AllowDrop = True
		Me.lvExclude.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lvExclude.Location = New System.Drawing.Point(3, 3)
		Me.lvExclude.Name = "lvExclude"
		Me.lvExclude.Size = New System.Drawing.Size(205, 299)
		Me.lvExclude.SmallImageList = Me.imageList
		Me.lvExclude.TabIndex = 7
		Me.lvExclude.UseCompatibleStateImageBehavior = False
		Me.lvExclude.View = System.Windows.Forms.View.List
		AddHandler Me.lvExclude.DragDrop, New System.Windows.Forms.DragEventHandler(AddressOf Me.lbExclude_DragDrop)
		AddHandler Me.lvExclude.DragOver, New System.Windows.Forms.DragEventHandler(AddressOf Me.lbExclude_DragOver)
		' 
		' databaseSchemaView1
		' 
		Me.databaseSchemaView1.BackColor = System.Drawing.SystemColors.Window
		Me.databaseSchemaView1.Dock = System.Windows.Forms.DockStyle.Left
		Me.databaseSchemaView1.Location = New System.Drawing.Point(3, 3)
		Me.databaseSchemaView1.Name = "databaseSchemaView1"
		Me.databaseSchemaView1.Options.DrawTreeLines = False
		Me.databaseSchemaView1.Options.ImageList = Nothing
		Me.databaseSchemaView1.QueryView = Nothing
		Me.databaseSchemaView1.SelectedItems = New ActiveQueryBuilder.Core.MetadataStructureItem(-1) {}
		Me.databaseSchemaView1.Size = New System.Drawing.Size(177, 331)
		Me.databaseSchemaView1.SQLContext = Nothing
		Me.databaseSchemaView1.TabIndex = 4
		AddHandler Me.databaseSchemaView1.ItemDoubleClick, New ActiveQueryBuilder.View.MetadataStructureView.MetadataStructureItemEventHandler(AddressOf Me.databaseSchemaView1_ItemDoubleClick)
		' 
		' panel1
		' 
		Me.panel1.Controls.Add(Me.btnDeleteFilter)
		Me.panel1.Controls.Add(Me.btnAddFilter)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.panel1.Location = New System.Drawing.Point(3, 334)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(396, 22)
		Me.panel1.TabIndex = 3
		' 
		' btnDeleteFilter
		' 
		Me.btnDeleteFilter.Dock = System.Windows.Forms.DockStyle.Fill
		Me.btnDeleteFilter.Location = New System.Drawing.Point(177, 0)
		Me.btnDeleteFilter.Name = "btnDeleteFilter"
		Me.btnDeleteFilter.Size = New System.Drawing.Size(219, 22)
		Me.btnDeleteFilter.TabIndex = 1
		Me.btnDeleteFilter.Text = "Remove"
		Me.btnDeleteFilter.UseVisualStyleBackColor = True
		AddHandler Me.btnDeleteFilter.Click, New System.EventHandler(AddressOf Me.btnDeleteFilter_Click)
		' 
		' btnAddFilter
		' 
		Me.btnAddFilter.Dock = System.Windows.Forms.DockStyle.Left
		Me.btnAddFilter.Location = New System.Drawing.Point(0, 0)
		Me.btnAddFilter.Name = "btnAddFilter"
		Me.btnAddFilter.Size = New System.Drawing.Size(177, 22)
		Me.btnAddFilter.TabIndex = 0
		Me.btnAddFilter.Text = "Add"
		Me.btnAddFilter.UseVisualStyleBackColor = True
		AddHandler Me.btnAddFilter.Click, New System.EventHandler(AddressOf Me.btnAddFilter_Click)
		' 
		' ConnectionForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(550, 409)
		Me.Controls.Add(Me.tcProperties)
		Me.Controls.Add(Me.lbMenu)
		Me.Controls.Add(Me.btnOk)
		Me.Controls.Add(Me.btnCancel)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "ConnectionForm"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Edit Connection"
		Me.tcProperties.ResumeLayout(False)
		Me.tpConnection.ResumeLayout(False)
		Me.pbConnection.ResumeLayout(False)
		Me.pbConnection.PerformLayout()
		Me.pnlTop.ResumeLayout(False)
		Me.pnlTop.PerformLayout()
		Me.tpFilter.ResumeLayout(False)
		Me.tcFilters.ResumeLayout(False)
		Me.tpInclude.ResumeLayout(False)
		Me.tpExclude.ResumeLayout(False)
		Me.panel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private btnOk As System.Windows.Forms.Button
	Private btnCancel As System.Windows.Forms.Button
	Private lbMenu As System.Windows.Forms.ListBox
	Private tcProperties As System.Windows.Forms.TabControl
	Private tpConnection As System.Windows.Forms.TabPage
	Private tpFilter As System.Windows.Forms.TabPage
	Private pbConnection As PropertiesBar
	Private cbLoadFromDefaultDatabase As System.Windows.Forms.CheckBox
	Private tcFilters As System.Windows.Forms.TabControl
	Private tpInclude As System.Windows.Forms.TabPage
	Private tpExclude As System.Windows.Forms.TabPage
	Private pnlTop As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private cbConnectionType As System.Windows.Forms.ComboBox
	Private panel1 As System.Windows.Forms.Panel
	Private btnDeleteFilter As System.Windows.Forms.Button
	Private btnAddFilter As System.Windows.Forms.Button
	Private databaseSchemaView1 As DatabaseSchemaView
	Private lvInclude As System.Windows.Forms.ListView
	Private lvExclude As System.Windows.Forms.ListView
	Private imageList As System.Windows.Forms.ImageList
	Private pbSyntax As PropertiesBar
	Private label3 As System.Windows.Forms.Label
	Private cbSyntax As System.Windows.Forms.ComboBox
End Class
