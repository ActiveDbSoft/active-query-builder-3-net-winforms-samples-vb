Imports ActiveQueryBuilder.View.WinForms.DatabaseSchemaView
Imports ActiveQueryBuilder.View.WinForms.QueryView

Partial Public Class ConnectionForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose( disposing As Boolean)
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
        Me.btnOk = New Button()
        Me.btnCancel = New Button()
        Me.lbMenu = New ListBox()
        Me.tcProperties = New TabControl()
        Me.tpConnection = New TabPage()
        Me.pbConnection = New ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar()
        Me.cbLoadFromDefaultDatabase = New CheckBox()
        Me.pbSyntax = New ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar()
        Me.pnlTop = New Panel()
        Me.label3 = New Label()
        Me.cbSyntax = New ComboBox()
        Me.label1 = New Label()
        Me.cbConnectionType = New ComboBox()
        Me.tpFilter = New TabPage()
        Me.tcFilters = New TabControl()
        Me.tpInclude = New TabPage()
        Me.lvInclude = New ListView()
        Me.imageList = New ImageList(Me.components)
        Me.tpExclude = New TabPage()
        Me.lvExclude = New ListView()
        Me.databaseSchemaView1 = New ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView()
        Me.panel1 = New Panel()
        Me.btnDeleteFilter = New Button()
        Me.btnAddFilter = New Button()
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
        Me.btnOk.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.btnOk.DialogResult = DialogResult.OK
        Me.btnOk.Location = New Point(382, 378)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New Size(78, 23)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        Me.btnCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.btnCancel.DialogResult = DialogResult.Cancel
        Me.btnCancel.Location = New Point(463, 378)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(78, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        ' 
        ' lbMenu
        ' 
        Me.lbMenu.Font = New Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
        Me.lbMenu.FormattingEnabled = True
        Me.lbMenu.ItemHeight = 16
        Me.lbMenu.Items.AddRange(New Object() { "Connection", "Filter"})
        Me.lbMenu.Location = New Point(8, 13)
        Me.lbMenu.Name = "lbMenu"
        Me.lbMenu.Size = New Size(120, 356)
        Me.lbMenu.TabIndex = 7
'			Me.lbMenu.SelectedIndexChanged += New System.EventHandler(Me.lbMenu_SelectedIndexChanged)
        ' 
        ' tcProperties
        ' 
        Me.tcProperties.Appearance = TabAppearance.FlatButtons
        Me.tcProperties.Controls.Add(Me.tpConnection)
        Me.tcProperties.Controls.Add(Me.tpFilter)
        Me.tcProperties.ItemSize = New Size(0, 1)
        Me.tcProperties.Location = New Point(134, 8)
        Me.tcProperties.Margin = New Padding(0)
        Me.tcProperties.Name = "tcProperties"
        Me.tcProperties.Padding = New Point(0, 0)
        Me.tcProperties.SelectedIndex = 0
        Me.tcProperties.Size = New Size(410, 368)
        Me.tcProperties.SizeMode = TabSizeMode.Fixed
        Me.tcProperties.TabIndex = 9
        ' 
        ' tpConnection
        ' 
        Me.tpConnection.Controls.Add(Me.pbConnection)
        Me.tpConnection.Controls.Add(Me.pbSyntax)
        Me.tpConnection.Controls.Add(Me.pnlTop)
        Me.tpConnection.Location = New Point(4, 5)
        Me.tpConnection.Margin = New Padding(0)
        Me.tpConnection.Name = "tpConnection"
        Me.tpConnection.Size = New Size(402, 359)
        Me.tpConnection.TabIndex = 0
        Me.tpConnection.Text = "tabPage1"
        Me.tpConnection.UseVisualStyleBackColor = True
        ' 
        ' pbConnection
        ' 
        Me.pbConnection.Controls.Add(Me.cbLoadFromDefaultDatabase)
        Me.pbConnection.Dock = DockStyle.Fill
        Me.pbConnection.EditorsOptions.CaptionsMaxWidth = 100
        Me.pbConnection.EditorsOptions.CaptionsMinWidth = 100
        Me.pbConnection.InformationMessageHost = Nothing
        Me.pbConnection.Location = New Point(0, 96)
        Me.pbConnection.Name = "pbConnection"
        Me.pbConnection.Size = New Size(402, 263)
        Me.pbConnection.TabIndex = 0
        ' 
        ' cbLoadFromDefaultDatabase
        ' 
        Me.cbLoadFromDefaultDatabase.AutoSize = True
        Me.cbLoadFromDefaultDatabase.Checked = True
        Me.cbLoadFromDefaultDatabase.CheckState = CheckState.Checked
        Me.cbLoadFromDefaultDatabase.Location = New Point(11, 200)
        Me.cbLoadFromDefaultDatabase.Name = "cbLoadFromDefaultDatabase"
        Me.cbLoadFromDefaultDatabase.Size = New Size(155, 17)
        Me.cbLoadFromDefaultDatabase.TabIndex = 0
        Me.cbLoadFromDefaultDatabase.Text = "Load from default database"
        Me.cbLoadFromDefaultDatabase.UseVisualStyleBackColor = True
'			Me.cbLoadFromDefaultDatabase.CheckedChanged += New System.EventHandler(Me.cbLoadFromDefaultDatabase_CheckedChanged)
        ' 
        ' pbSyntax
        ' 
        Me.pbSyntax.Dock = DockStyle.Top
        Me.pbSyntax.EditorsOptions.CaptionsMaxWidth = 100
        Me.pbSyntax.EditorsOptions.CaptionsMinWidth = 100
        Me.pbSyntax.InformationMessageHost = Nothing
        Me.pbSyntax.Location = New Point(0, 31)
        Me.pbSyntax.Name = "pbSyntax"
        Me.pbSyntax.Size = New Size(402, 65)
        Me.pbSyntax.TabIndex = 2
        ' 
        ' pnlTop
        ' 
        Me.pnlTop.BackColor = Color.White
        Me.pnlTop.BorderStyle = BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.label3)
        Me.pnlTop.Controls.Add(Me.cbSyntax)
        Me.pnlTop.Controls.Add(Me.label1)
        Me.pnlTop.Controls.Add(Me.cbConnectionType)
        Me.pnlTop.Dock = DockStyle.Top
        Me.pnlTop.Location = New Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Padding = New Padding(6)
        Me.pnlTop.Size = New Size(402, 31)
        Me.pnlTop.TabIndex = 9
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.label3.Location = New Point(9, 33)
        Me.label3.Name = "label3"
        Me.label3.Size = New Size(47, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Syntax"
        ' 
        ' cbSyntax
        ' 
        Me.cbSyntax.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.cbSyntax.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cbSyntax.FormattingEnabled = True
        Me.cbSyntax.Location = New Point(120, 30)
        Me.cbSyntax.Name = "cbSyntax"
        Me.cbSyntax.Size = New Size(271, 21)
        Me.cbSyntax.TabIndex = 4
'			Me.cbSyntax.SelectedIndexChanged += New System.EventHandler(Me.cbSyntax_SelectedIndexChanged)
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.label1.Location = New Point(9, 6)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(101, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Connection Type"
        ' 
        ' cbConnectionType
        ' 
        Me.cbConnectionType.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.cbConnectionType.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cbConnectionType.FormattingEnabled = True
        Me.cbConnectionType.Location = New Point(120, 3)
        Me.cbConnectionType.Name = "cbConnectionType"
        Me.cbConnectionType.Size = New Size(271, 21)
        Me.cbConnectionType.TabIndex = 2
'			Me.cbConnectionType.SelectedIndexChanged += New System.EventHandler(Me.cbConnectionType_SelectedIndexChanged)
        ' 
        ' tpFilter
        ' 
        Me.tpFilter.Controls.Add(Me.tcFilters)
        Me.tpFilter.Controls.Add(Me.databaseSchemaView1)
        Me.tpFilter.Controls.Add(Me.panel1)
        Me.tpFilter.Location = New Point(4, 5)
        Me.tpFilter.Name = "tpFilter"
        Me.tpFilter.Padding = New Padding(3)
        Me.tpFilter.Size = New Size(402, 359)
        Me.tpFilter.TabIndex = 1
        Me.tpFilter.Text = "tabPage2"
        Me.tpFilter.UseVisualStyleBackColor = True
        ' 
        ' tcFilters
        ' 
        Me.tcFilters.Controls.Add(Me.tpInclude)
        Me.tcFilters.Controls.Add(Me.tpExclude)
        Me.tcFilters.Dock = DockStyle.Fill
        Me.tcFilters.Location = New Point(180, 3)
        Me.tcFilters.Name = "tcFilters"
        Me.tcFilters.SelectedIndex = 0
        Me.tcFilters.Size = New Size(219, 331)
        Me.tcFilters.TabIndex = 1
        ' 
        ' tpInclude
        ' 
        Me.tpInclude.Controls.Add(Me.lvInclude)
        Me.tpInclude.Location = New Point(4, 22)
        Me.tpInclude.Name = "tpInclude"
        Me.tpInclude.Padding = New Padding(3)
        Me.tpInclude.Size = New Size(211, 305)
        Me.tpInclude.TabIndex = 0
        Me.tpInclude.Text = "Include"
        Me.tpInclude.UseVisualStyleBackColor = True
        ' 
        ' lvInclude
        ' 
        Me.lvInclude.AllowDrop = True
        Me.lvInclude.Dock = DockStyle.Fill
        Me.lvInclude.Location = New Point(3, 3)
        Me.lvInclude.Name = "lvInclude"
        Me.lvInclude.Size = New Size(205, 299)
        Me.lvInclude.SmallImageList = Me.imageList
        Me.lvInclude.TabIndex = 6
        Me.lvInclude.UseCompatibleStateImageBehavior = False
        Me.lvInclude.View = View.List
'			Me.lvInclude.DragDrop += New System.Windows.Forms.DragEventHandler(Me.lbInclude_DragDrop)
'			Me.lvInclude.DragOver += New System.Windows.Forms.DragEventHandler(Me.lbInclude_DragOver)
        ' 
        ' imageList
        ' 
        Me.imageList.ColorDepth = ColorDepth.Depth8Bit
        Me.imageList.ImageSize = New Size(16, 16)
        Me.imageList.TransparentColor = Color.Transparent
        ' 
        ' tpExclude
        ' 
        Me.tpExclude.Controls.Add(Me.lvExclude)
        Me.tpExclude.Location = New Point(4, 22)
        Me.tpExclude.Name = "tpExclude"
        Me.tpExclude.Padding = New Padding(3)
        Me.tpExclude.Size = New Size(211, 305)
        Me.tpExclude.TabIndex = 1
        Me.tpExclude.Text = "Exclude"
        Me.tpExclude.UseVisualStyleBackColor = True
        ' 
        ' lvExclude
        ' 
        Me.lvExclude.AllowDrop = True
        Me.lvExclude.Dock = DockStyle.Fill
        Me.lvExclude.Location = New Point(3, 3)
        Me.lvExclude.Name = "lvExclude"
        Me.lvExclude.Size = New Size(205, 299)
        Me.lvExclude.SmallImageList = Me.imageList
        Me.lvExclude.TabIndex = 7
        Me.lvExclude.UseCompatibleStateImageBehavior = False
        Me.lvExclude.View = View.List
'			Me.lvExclude.DragDrop += New System.Windows.Forms.DragEventHandler(Me.lbExclude_DragDrop)
'			Me.lvExclude.DragOver += New System.Windows.Forms.DragEventHandler(Me.lbExclude_DragOver)
        ' 
        ' databaseSchemaView1
        ' 
        Me.databaseSchemaView1.BackColor = SystemColors.Window
        Me.databaseSchemaView1.Dock = DockStyle.Left
        Me.databaseSchemaView1.Location = New Point(3, 3)
        Me.databaseSchemaView1.Name = "databaseSchemaView1"
        Me.databaseSchemaView1.Options.DrawTreeLines = False
        Me.databaseSchemaView1.Options.ImageList = Nothing
        Me.databaseSchemaView1.QueryView = Nothing
        Me.databaseSchemaView1.SelectedItems = New ActiveQueryBuilder.Core.MetadataStructureItem(){}
        Me.databaseSchemaView1.Size = New Size(177, 331)
        Me.databaseSchemaView1.SQLContext = Nothing
        Me.databaseSchemaView1.TabIndex = 4
'			Me.databaseSchemaView1.ItemDoubleClick += New ActiveQueryBuilder.View.MetadataStructureView.MetadataStructureItemEventHandler(Me.databaseSchemaView1_ItemDoubleClick)
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.btnDeleteFilter)
        Me.panel1.Controls.Add(Me.btnAddFilter)
        Me.panel1.Dock = DockStyle.Bottom
        Me.panel1.Location = New Point(3, 334)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New Size(396, 22)
        Me.panel1.TabIndex = 3
        ' 
        ' btnDeleteFilter
        ' 
        Me.btnDeleteFilter.Dock = DockStyle.Fill
        Me.btnDeleteFilter.Location = New Point(177, 0)
        Me.btnDeleteFilter.Name = "btnDeleteFilter"
        Me.btnDeleteFilter.Size = New Size(219, 22)
        Me.btnDeleteFilter.TabIndex = 1
        Me.btnDeleteFilter.Text = "Remove"
        Me.btnDeleteFilter.UseVisualStyleBackColor = True
'			Me.btnDeleteFilter.Click += New System.EventHandler(Me.btnDeleteFilter_Click)
        ' 
        ' btnAddFilter
        ' 
        Me.btnAddFilter.Dock = DockStyle.Left
        Me.btnAddFilter.Location = New Point(0, 0)
        Me.btnAddFilter.Name = "btnAddFilter"
        Me.btnAddFilter.Size = New Size(177, 22)
        Me.btnAddFilter.TabIndex = 0
        Me.btnAddFilter.Text = "Add"
        Me.btnAddFilter.UseVisualStyleBackColor = True
'			Me.btnAddFilter.Click += New System.EventHandler(Me.btnAddFilter_Click)
        ' 
        ' ConnectionForm
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(550, 409)
        Me.Controls.Add(Me.tcProperties)
        Me.Controls.Add(Me.lbMenu)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.Name = "ConnectionForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.CenterParent
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

    Private btnOk As Button
    Private btnCancel As Button
    Private WithEvents lbMenu As ListBox
    Private tcProperties As TabControl
    Private tpConnection As TabPage
    Private tpFilter As TabPage
    Private pbConnection As PropertiesBar
    Private WithEvents cbLoadFromDefaultDatabase As CheckBox
    Private tcFilters As TabControl
    Private tpInclude As TabPage
    Private tpExclude As TabPage
    Private pnlTop As Panel
    Private label1 As Label
    Private WithEvents cbConnectionType As ComboBox
    Private panel1 As Panel
    Private WithEvents btnDeleteFilter As Button
    Private WithEvents btnAddFilter As Button
    Private WithEvents databaseSchemaView1 As DatabaseSchemaView
    Private WithEvents lvInclude As ListView
    Private WithEvents lvExclude As ListView
    Private imageList As ImageList
    Private pbSyntax As PropertiesBar
    Private label3 As Label
    Private WithEvents cbSyntax As ComboBox
End Class
