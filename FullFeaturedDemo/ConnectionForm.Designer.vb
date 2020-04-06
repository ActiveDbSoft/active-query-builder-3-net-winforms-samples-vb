	Partial Public Class ConnectionForm
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
			Me.tabControl1 = New TabControl()
			Me.tabPage1 = New TabPage()
			Me.lvConnections = New ListView()
			Me.columnHeader1 = (CType(New ColumnHeader(), ColumnHeader))
			Me.columnHeader2 = (CType(New ColumnHeader(), ColumnHeader))
			Me.btnConfigure = New Button()
			Me.btnRemove = New Button()
			Me.btnAdd = New Button()
			Me.tabPage3 = New TabPage()
			Me.lvXmlFiles = New ListView()
			Me.columnHeader5 = (CType(New ColumnHeader(), ColumnHeader))
			Me.columnHeader6 = (CType(New ColumnHeader(), ColumnHeader))
			Me.btnConfigureXml = New Button()
			Me.btnRemoveXml = New Button()
			Me.btnAddXml = New Button()
			Me.btnCancel = New Button()
			Me.btnOk = New Button()
			Me.columnHeader3 = (CType(New ColumnHeader(), ColumnHeader))
			Me.columnHeader4 = (CType(New ColumnHeader(), ColumnHeader))
			Me.tabControl1.SuspendLayout()
			Me.tabPage1.SuspendLayout()
			Me.tabPage3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' tabControl1
			' 
			Me.tabControl1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.tabControl1.Controls.Add(Me.tabPage1)
			Me.tabControl1.Controls.Add(Me.tabPage3)
			Me.tabControl1.Location = New Point(12, 12)
			Me.tabControl1.Name = "tabControl1"
			Me.tabControl1.SelectedIndex = 0
			Me.tabControl1.Size = New Size(370, 267)
			Me.tabControl1.TabIndex = 0
			Me.tabControl1.TabStop = False
			' 
			' tabPage1
			' 
			Me.tabPage1.Controls.Add(Me.lvConnections)
			Me.tabPage1.Controls.Add(Me.btnConfigure)
			Me.tabPage1.Controls.Add(Me.btnRemove)
			Me.tabPage1.Controls.Add(Me.btnAdd)
			Me.tabPage1.Location = New Point(4, 22)
			Me.tabPage1.Name = "tabPage1"
			Me.tabPage1.Padding = New Padding(3)
			Me.tabPage1.Size = New Size(362, 241)
			Me.tabPage1.TabIndex = 0
			Me.tabPage1.Text = "Database Connections"
			Me.tabPage1.UseVisualStyleBackColor = True
			' 
			' lvConnections
			' 
			Me.lvConnections.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.lvConnections.Columns.AddRange(New ColumnHeader() { Me.columnHeader1, Me.columnHeader2})
			Me.lvConnections.FullRowSelect = True
			Me.lvConnections.Location = New Point(6, 6)
			Me.lvConnections.MultiSelect = False
			Me.lvConnections.Name = "lvConnections"
			Me.lvConnections.Size = New Size(269, 229)
			Me.lvConnections.TabIndex = 0
			Me.lvConnections.UseCompatibleStateImageBehavior = False
			Me.lvConnections.View = View.Details
'			Me.lvConnections.SizeChanged += New System.EventHandler(Me.lvConnections_SizeChanged)
'			Me.lvConnections.MouseDoubleClick += New System.Windows.Forms.MouseEventHandler(Me.lvConnections_MouseDoubleClick)
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
			Me.btnConfigure.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.btnConfigure.Location = New Point(281, 64)
			Me.btnConfigure.Name = "btnConfigure"
			Me.btnConfigure.Size = New Size(75, 23)
			Me.btnConfigure.TabIndex = 3
			Me.btnConfigure.Text = "Configure..."
			Me.btnConfigure.UseVisualStyleBackColor = True
'			Me.btnConfigure.Click += New System.EventHandler(Me.btnConfigure_Click)
			' 
			' btnRemove
			' 
			Me.btnRemove.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.btnRemove.Location = New Point(281, 35)
			Me.btnRemove.Name = "btnRemove"
			Me.btnRemove.Size = New Size(75, 23)
			Me.btnRemove.TabIndex = 2
			Me.btnRemove.Text = "Remove"
			Me.btnRemove.UseVisualStyleBackColor = True
'			Me.btnRemove.Click += New System.EventHandler(Me.btnRemove_Click)
			' 
			' btnAdd
			' 
			Me.btnAdd.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.btnAdd.Location = New Point(281, 6)
			Me.btnAdd.Name = "btnAdd"
			Me.btnAdd.Size = New Size(75, 23)
			Me.btnAdd.TabIndex = 1
			Me.btnAdd.Text = "Add..."
			Me.btnAdd.UseVisualStyleBackColor = True
'			Me.btnAdd.Click += New System.EventHandler(Me.btnAdd_Click)
			' 
			' tabPage3
			' 
			Me.tabPage3.Controls.Add(Me.lvXmlFiles)
			Me.tabPage3.Controls.Add(Me.btnConfigureXml)
			Me.tabPage3.Controls.Add(Me.btnRemoveXml)
			Me.tabPage3.Controls.Add(Me.btnAddXml)
			Me.tabPage3.Location = New Point(4, 22)
			Me.tabPage3.Name = "tabPage3"
			Me.tabPage3.Padding = New Padding(3)
			Me.tabPage3.Size = New Size(362, 241)
			Me.tabPage3.TabIndex = 2
			Me.tabPage3.Text = "Saved XML metadata"
			Me.tabPage3.UseVisualStyleBackColor = True
			' 
			' lvXmlFiles
			' 
			Me.lvXmlFiles.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.lvXmlFiles.Columns.AddRange(New ColumnHeader() { Me.columnHeader5, Me.columnHeader6})
			Me.lvXmlFiles.FullRowSelect = True
			Me.lvXmlFiles.Location = New Point(6, 6)
			Me.lvXmlFiles.MultiSelect = False
			Me.lvXmlFiles.Name = "lvXmlFiles"
			Me.lvXmlFiles.Size = New Size(269, 229)
			Me.lvXmlFiles.TabIndex = 0
			Me.lvXmlFiles.UseCompatibleStateImageBehavior = False
			Me.lvXmlFiles.View = View.Details
'			Me.lvXmlFiles.SizeChanged += New System.EventHandler(Me.lvXmlFiles_SizeChanged)
'			Me.lvXmlFiles.MouseDoubleClick += New System.Windows.Forms.MouseEventHandler(Me.lvXmlFiles_MouseDoubleClick)
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
			Me.btnConfigureXml.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.btnConfigureXml.Location = New Point(281, 64)
			Me.btnConfigureXml.Name = "btnConfigureXml"
			Me.btnConfigureXml.Size = New Size(75, 23)
			Me.btnConfigureXml.TabIndex = 3
			Me.btnConfigureXml.Text = "Configure..."
			Me.btnConfigureXml.UseVisualStyleBackColor = True
'			Me.btnConfigureXml.Click += New System.EventHandler(Me.btnConfigureXml_Click)
			' 
			' btnRemoveXml
			' 
			Me.btnRemoveXml.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.btnRemoveXml.Location = New Point(281, 35)
			Me.btnRemoveXml.Name = "btnRemoveXml"
			Me.btnRemoveXml.Size = New Size(75, 23)
			Me.btnRemoveXml.TabIndex = 2
			Me.btnRemoveXml.Text = "Remove"
			Me.btnRemoveXml.UseVisualStyleBackColor = True
'			Me.btnRemoveXml.Click += New System.EventHandler(Me.btnRemoveXml_Click)
			' 
			' btnAddXml
			' 
			Me.btnAddXml.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.btnAddXml.Location = New Point(281, 6)
			Me.btnAddXml.Name = "btnAddXml"
			Me.btnAddXml.Size = New Size(75, 23)
			Me.btnAddXml.TabIndex = 1
			Me.btnAddXml.Text = "Add..."
			Me.btnAddXml.UseVisualStyleBackColor = True
'			Me.btnAddXml.Click += New System.EventHandler(Me.btnAddXml_Click)
			' 
			' btnCancel
			' 
			Me.btnCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.btnCancel.DialogResult = DialogResult.Cancel
			Me.btnCancel.Location = New Point(307, 285)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(75, 23)
			Me.btnCancel.TabIndex = 2
			Me.btnCancel.Text = "Cancel"
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' btnOk
			' 
			Me.btnOk.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
			Me.btnOk.DialogResult = DialogResult.OK
			Me.btnOk.Location = New Point(226, 285)
			Me.btnOk.Name = "btnOk"
			Me.btnOk.Size = New Size(75, 23)
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
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Size(394, 320)
			Me.Controls.Add(Me.btnOk)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.tabControl1)
			Me.MinimumSize = New Size(200, 200)
			Me.Name = "ConnectionForm"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Database Connection"
			Me.tabControl1.ResumeLayout(False)
			Me.tabPage1.ResumeLayout(False)
			Me.tabPage3.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tabControl1 As TabControl
		Private tabPage1 As TabPage
		Private tabPage3 As TabPage
		Private btnCancel As Button
		Private btnOk As Button
		Private WithEvents btnConfigure As Button
		Private WithEvents btnRemove As Button
		Private WithEvents btnAdd As Button
		Private WithEvents lvConnections As ListView
		Private columnHeader1 As ColumnHeader
		Private columnHeader2 As ColumnHeader
		Private WithEvents lvXmlFiles As ListView
		Private columnHeader5 As ColumnHeader
		Private columnHeader6 As ColumnHeader
		Private WithEvents btnConfigureXml As Button
		Private WithEvents btnRemoveXml As Button
		Private WithEvents btnAddXml As Button
		Private columnHeader3 As ColumnHeader
		Private columnHeader4 As ColumnHeader


	End Class
