Namespace PropertiesForm
	Partial Class PanesVisibilityPage
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
			Me.cbShowQueryColumnsPane = New System.Windows.Forms.CheckBox()
			Me.cbShowDatabaseSchemaView = New System.Windows.Forms.CheckBox()
			Me.cbShowDesignPane = New System.Windows.Forms.CheckBox()
			Me.cbShowQueryNavigationBar = New System.Windows.Forms.CheckBox()
			Me.SuspendLayout()
			' 
			' cbShowQueryColumnsPane
			' 
			Me.cbShowQueryColumnsPane.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.cbShowQueryColumnsPane.Location = New System.Drawing.Point(3, 27)
			Me.cbShowQueryColumnsPane.Name = "cbShowQueryColumnsPane"
			Me.cbShowQueryColumnsPane.Size = New System.Drawing.Size(312, 17)
			Me.cbShowQueryColumnsPane.TabIndex = 6
			Me.cbShowQueryColumnsPane.Text = "Show Query Columns Pane"
			Me.cbShowQueryColumnsPane.UseVisualStyleBackColor = True
			' 
			' cbShowDatabaseSchemaView
			' 
			Me.cbShowDatabaseSchemaView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.cbShowDatabaseSchemaView.Location = New System.Drawing.Point(3, 50)
			Me.cbShowDatabaseSchemaView.Name = "cbShowDatabaseSchemaView"
			Me.cbShowDatabaseSchemaView.Size = New System.Drawing.Size(312, 17)
			Me.cbShowDatabaseSchemaView.TabIndex = 5
			Me.cbShowDatabaseSchemaView.Text = "Show Database Schema View"
			Me.cbShowDatabaseSchemaView.UseVisualStyleBackColor = True
			' 
			' cbShowDesignPane
			' 
			Me.cbShowDesignPane.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.cbShowDesignPane.Location = New System.Drawing.Point(3, 4)
			Me.cbShowDesignPane.Name = "cbShowDesignPane"
			Me.cbShowDesignPane.Size = New System.Drawing.Size(312, 17)
			Me.cbShowDesignPane.TabIndex = 7
			Me.cbShowDesignPane.Text = "Show Design Pane"
			Me.cbShowDesignPane.UseVisualStyleBackColor = True
			' 
			' cbShowQueryNavigationBar
			' 
			Me.cbShowQueryNavigationBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.cbShowQueryNavigationBar.Location = New System.Drawing.Point(3, 73)
			Me.cbShowQueryNavigationBar.Name = "cbShowQueryNavigationBar"
			Me.cbShowQueryNavigationBar.Size = New System.Drawing.Size(312, 17)
			Me.cbShowQueryNavigationBar.TabIndex = 9
			Me.cbShowQueryNavigationBar.Text = "Show Query Navigation Bar"
			Me.cbShowQueryNavigationBar.UseVisualStyleBackColor = True
			' 
			' PanesVisibilityPage
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.cbShowQueryNavigationBar)
			Me.Controls.Add(Me.cbShowDesignPane)
			Me.Controls.Add(Me.cbShowQueryColumnsPane)
			Me.Controls.Add(Me.cbShowDatabaseSchemaView)
			Me.Name = "PanesVisibilityPage"
			Me.Size = New System.Drawing.Size(318, 98)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private cbShowQueryColumnsPane As System.Windows.Forms.CheckBox
		Private cbShowDatabaseSchemaView As System.Windows.Forms.CheckBox
		Private cbShowDesignPane As System.Windows.Forms.CheckBox
		Private cbShowQueryNavigationBar As System.Windows.Forms.CheckBox
	End Class
End Namespace
