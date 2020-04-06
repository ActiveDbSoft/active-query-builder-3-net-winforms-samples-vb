Namespace QueryBuilderProperties
	Partial Friend Class PanesVisibilityPage
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
			Me.cbShowQueryColumnsPane = New CheckBox()
			Me.cbShowDatabaseSchemaView = New CheckBox()
			Me.cbShowDesignPane = New CheckBox()
			Me.cbShowQueryNavigationBar = New CheckBox()
			Me.SuspendLayout()
			'
			' cbShowQueryColumnsPane
			'
			Me.cbShowQueryColumnsPane.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.cbShowQueryColumnsPane.Location = New Point(3, 27)
			Me.cbShowQueryColumnsPane.Name = "cbShowQueryColumnsPane"
			Me.cbShowQueryColumnsPane.Size = New Size(312, 17)
			Me.cbShowQueryColumnsPane.TabIndex = 6
			Me.cbShowQueryColumnsPane.Text = "Show Query Columns Pane"
			Me.cbShowQueryColumnsPane.UseVisualStyleBackColor = True
			'
			' cbShowDatabaseSchemaView
			'
			Me.cbShowDatabaseSchemaView.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.cbShowDatabaseSchemaView.Location = New Point(3, 50)
			Me.cbShowDatabaseSchemaView.Name = "cbShowDatabaseSchemaView"
			Me.cbShowDatabaseSchemaView.Size = New Size(312, 17)
			Me.cbShowDatabaseSchemaView.TabIndex = 5
			Me.cbShowDatabaseSchemaView.Text = "Show Database Schema View"
			Me.cbShowDatabaseSchemaView.UseVisualStyleBackColor = True
			'
			' cbShowDesignPane
			'
			Me.cbShowDesignPane.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.cbShowDesignPane.Location = New Point(3, 4)
			Me.cbShowDesignPane.Name = "cbShowDesignPane"
			Me.cbShowDesignPane.Size = New Size(312, 17)
			Me.cbShowDesignPane.TabIndex = 7
			Me.cbShowDesignPane.Text = "Show Design Pane"
			Me.cbShowDesignPane.UseVisualStyleBackColor = True
			'
			' cbShowQueryNavigationBar
			'
			Me.cbShowQueryNavigationBar.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.cbShowQueryNavigationBar.Location = New Point(3, 73)
			Me.cbShowQueryNavigationBar.Name = "cbShowQueryNavigationBar"
			Me.cbShowQueryNavigationBar.Size = New Size(312, 17)
			Me.cbShowQueryNavigationBar.TabIndex = 9
			Me.cbShowQueryNavigationBar.Text = "Show Query Navigation Bar"
			Me.cbShowQueryNavigationBar.UseVisualStyleBackColor = True
			'
			' PanesVisibilityPage
			'
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.cbShowQueryNavigationBar)
			Me.Controls.Add(Me.cbShowDesignPane)
			Me.Controls.Add(Me.cbShowQueryColumnsPane)
			Me.Controls.Add(Me.cbShowDatabaseSchemaView)
			Me.Name = "PanesVisibilityPage"
			Me.Size = New Size(318, 98)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private cbShowQueryColumnsPane As CheckBox
		Private cbShowDatabaseSchemaView As CheckBox
		Private cbShowDesignPane As CheckBox
		Private cbShowQueryNavigationBar As CheckBox
	End Class
End Namespace
