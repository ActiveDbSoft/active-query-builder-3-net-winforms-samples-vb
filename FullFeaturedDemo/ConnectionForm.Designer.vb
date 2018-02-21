Partial Class ConnectionForm
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.lvConnections = New System.Windows.Forms.ListView()
		Me.columnHeader1 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.columnHeader2 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.btnConfigure = New System.Windows.Forms.Button()
		Me.btnRemove = New System.Windows.Forms.Button()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.tabPage3 = New System.Windows.Forms.TabPage()
		Me.lvXmlFiles = New System.Windows.Forms.ListView()
		Me.columnHeader5 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.columnHeader6 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.btnConfigureXml = New System.Windows.Forms.Button()
		Me.btnRemoveXml = New System.Windows.Forms.Button()
		Me.btnAddXml = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.columnHeader3 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.columnHeader4 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.tabControl1.SuspendLayout()
		Me.tabPage1.SuspendLayout()
		Me.tabPage3.SuspendLayout()
		Me.SuspendLayout()
		' 
		' tabControl1
		' 
		Me.tabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tabControl1.Controls.Add(Me.tabPage1)
		Me.tabControl1.Controls.Add(Me.tabPage3)
		Me.tabControl1.Location = New System.Drawing.Point(12, 12)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(370, 267)
		Me.tabControl1.TabIndex = 0
		Me.tabControl1.TabStop = False
		' 
		' tabPage1
		' 
		Me.tabPage1.Controls.Add(Me.lvConnections)
		Me.tabPage1.Controls.Add(Me.btnConfigure)
		Me.tabPage1.Controls.Add(Me.btnRemove)
		Me.tabPage1.Controls.Add(Me.btnAdd)
		Me.tabPage1.Location = New System.Drawing.Point(4, 22)
		Me.tabPage1.Name = "tabPage1"
		Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage1.Size = New System.Drawing.Size(362, 241)
		Me.tabPage1.TabIndex = 0
		Me.tabPage1.Text = "Database Connections"
		Me.tabPage1.UseVisualStyleBackColor = True
		' 
		' lvConnections
		' 
		Me.lvConnections.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvConnections.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2})
		Me.lvConnections.FullRowSelect = True
		Me.lvConnections.Location = New System.Drawing.Point(6, 6)
		Me.lvConnections.MultiSelect = False
		Me.lvConnections.Name = "lvConnections"
		Me.lvConnections.Size = New System.Drawing.Size(269, 229)
		Me.lvConnections.TabIndex = 0
		Me.lvConnections.UseCompatibleStateImageBehavior = False
		Me.lvConnections.View = System.Windows.Forms.View.Details
		AddHandler Me.lvConnections.SizeChanged, New System.EventHandler(AddressOf Me.lvConnections_SizeChanged)
		AddHandler Me.lvConnections.MouseDoubleClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.lvConnections_MouseDoubleClick)
		' 
		' columnHeader1
		' 
		Me.columnHeader1.Text = "Name"
		Me.columnHeader1.Width = 150
		' 
		' columnHeader2
		' 
		Me.columnHeader2.Text = "Type"
		Me.columnHeader2.Width = 100
		' 
		' btnConfigure
		' 
		Me.btnConfigure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnConfigure.Location = New System.Drawing.Point(281, 64)
		Me.btnConfigure.Name = "btnConfigure"
		Me.btnConfigure.Size = New System.Drawing.Size(75, 23)
		Me.btnConfigure.TabIndex = 3
		Me.btnConfigure.Text = "Configure..."
		Me.btnConfigure.UseVisualStyleBackColor = True
		AddHandler Me.btnConfigure.Click, New System.EventHandler(AddressOf Me.btnConfigure_Click)
		' 
		' btnRemove
		' 
		Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnRemove.Location = New System.Drawing.Point(281, 35)
		Me.btnRemove.Name = "btnRemove"
		Me.btnRemove.Size = New System.Drawing.Size(75, 23)
		Me.btnRemove.TabIndex = 2
		Me.btnRemove.Text = "Remove"
		Me.btnRemove.UseVisualStyleBackColor = True
		AddHandler Me.btnRemove.Click, New System.EventHandler(AddressOf Me.btnRemove_Click)
		' 
		' btnAdd
		' 
		Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnAdd.Location = New System.Drawing.Point(281, 6)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 1
		Me.btnAdd.Text = "Add..."
		Me.btnAdd.UseVisualStyleBackColor = True
		AddHandler Me.btnAdd.Click, New System.EventHandler(AddressOf Me.btnAdd_Click)
		' 
		' tabPage3
		' 
		Me.tabPage3.Controls.Add(Me.lvXmlFiles)
		Me.tabPage3.Controls.Add(Me.btnConfigureXml)
		Me.tabPage3.Controls.Add(Me.btnRemoveXml)
		Me.tabPage3.Controls.Add(Me.btnAddXml)
		Me.tabPage3.Location = New System.Drawing.Point(4, 22)
		Me.tabPage3.Name = "tabPage3"
		Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage3.Size = New System.Drawing.Size(362, 241)
		Me.tabPage3.TabIndex = 2
		Me.tabPage3.Text = "Saved XML metadata"
		Me.tabPage3.UseVisualStyleBackColor = True
		' 
		' lvXmlFiles
		' 
		Me.lvXmlFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvXmlFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader5, Me.columnHeader6})
		Me.lvXmlFiles.FullRowSelect = True
		Me.lvXmlFiles.Location = New System.Drawing.Point(6, 6)
		Me.lvXmlFiles.MultiSelect = False
		Me.lvXmlFiles.Name = "lvXmlFiles"
		Me.lvXmlFiles.Size = New System.Drawing.Size(269, 229)
		Me.lvXmlFiles.TabIndex = 0
		Me.lvXmlFiles.UseCompatibleStateImageBehavior = False
		Me.lvXmlFiles.View = System.Windows.Forms.View.Details
		AddHandler Me.lvXmlFiles.SizeChanged, New System.EventHandler(AddressOf Me.lvXmlFiles_SizeChanged)
		AddHandler Me.lvXmlFiles.MouseDoubleClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.lvXmlFiles_MouseDoubleClick)
		' 
		' columnHeader5
		' 
		Me.columnHeader5.Text = "Name"
		Me.columnHeader5.Width = 150
		' 
		' columnHeader6
		' 
		Me.columnHeader6.Text = "Type"
		Me.columnHeader6.Width = 100
		' 
		' btnConfigureXml
		' 
		Me.btnConfigureXml.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnConfigureXml.Location = New System.Drawing.Point(281, 64)
		Me.btnConfigureXml.Name = "btnConfigureXml"
		Me.btnConfigureXml.Size = New System.Drawing.Size(75, 23)
		Me.btnConfigureXml.TabIndex = 3
		Me.btnConfigureXml.Text = "Configure..."
		Me.btnConfigureXml.UseVisualStyleBackColor = True
		AddHandler Me.btnConfigureXml.Click, New System.EventHandler(AddressOf Me.btnConfigureXml_Click)
		' 
		' btnRemoveXml
		' 
		Me.btnRemoveXml.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnRemoveXml.Location = New System.Drawing.Point(281, 35)
		Me.btnRemoveXml.Name = "btnRemoveXml"
		Me.btnRemoveXml.Size = New System.Drawing.Size(75, 23)
		Me.btnRemoveXml.TabIndex = 2
		Me.btnRemoveXml.Text = "Remove"
		Me.btnRemoveXml.UseVisualStyleBackColor = True
		AddHandler Me.btnRemoveXml.Click, New System.EventHandler(AddressOf Me.btnRemoveXml_Click)
		' 
		' btnAddXml
		' 
		Me.btnAddXml.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnAddXml.Location = New System.Drawing.Point(281, 6)
		Me.btnAddXml.Name = "btnAddXml"
		Me.btnAddXml.Size = New System.Drawing.Size(75, 23)
		Me.btnAddXml.TabIndex = 1
		Me.btnAddXml.Text = "Add..."
		Me.btnAddXml.UseVisualStyleBackColor = True
		AddHandler Me.btnAddXml.Click, New System.EventHandler(AddressOf Me.btnAddXml_Click)
		' 
		' btnCancel
		' 
		Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(307, 285)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 2
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		' 
		' btnOk
		' 
		Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnOk.Location = New System.Drawing.Point(226, 285)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 23)
		Me.btnOk.TabIndex = 1
		Me.btnOk.Text = "OK"
		Me.btnOk.UseVisualStyleBackColor = True
		' 
		' columnHeader3
		' 
		Me.columnHeader3.Text = "Name"
		Me.columnHeader3.Width = 150
		' 
		' columnHeader4
		' 
		Me.columnHeader4.Text = "Type"
		Me.columnHeader4.Width = 100
		' 
		' ConnectionForm
		' 
		Me.AcceptButton = Me.btnOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(394, 320)
		Me.Controls.Add(Me.btnOk)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.tabControl1)
		Me.MinimumSize = New System.Drawing.Size(200, 200)
		Me.Name = "ConnectionForm"
		Me.ShowIcon = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Database Connection"
		Me.tabControl1.ResumeLayout(False)
		Me.tabPage1.ResumeLayout(False)
		Me.tabPage3.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private tabControl1 As System.Windows.Forms.TabControl
	Private tabPage1 As System.Windows.Forms.TabPage
	Private tabPage3 As System.Windows.Forms.TabPage
	Private btnCancel As System.Windows.Forms.Button
	Private btnOk As System.Windows.Forms.Button
	Private btnConfigure As System.Windows.Forms.Button
	Private btnRemove As System.Windows.Forms.Button
	Private btnAdd As System.Windows.Forms.Button
	Private lvConnections As System.Windows.Forms.ListView
	Private columnHeader1 As System.Windows.Forms.ColumnHeader
	Private columnHeader2 As System.Windows.Forms.ColumnHeader
	Private lvXmlFiles As System.Windows.Forms.ListView
	Private columnHeader5 As System.Windows.Forms.ColumnHeader
	Private columnHeader6 As System.Windows.Forms.ColumnHeader
	Private btnConfigureXml As System.Windows.Forms.Button
	Private btnRemoveXml As System.Windows.Forms.Button
	Private btnAddXml As System.Windows.Forms.Button
	Private columnHeader3 As System.Windows.Forms.ColumnHeader
	Private columnHeader4 As System.Windows.Forms.ColumnHeader


End Class
