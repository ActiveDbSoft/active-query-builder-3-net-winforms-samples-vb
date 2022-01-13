Namespace QueryBuilderProperties
    Partial Friend Class DatabaseSchemaViewPage
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
            Me.lblGroupObjectsBy = New Label()
            Me.cbGroupByServers = New CheckBox()
            Me.cbGroupByDatabases = New CheckBox()
            Me.cbGroupBySchemas = New CheckBox()
            Me.cbGroupByTypes = New CheckBox()
            Me.cbShowFields = New CheckBox()
            Me.lblSortObjectsBy = New Label()
            Me.cmbSortObjectsBy = New ComboBox()
            Me.lblDefaultExpandLevel = New Label()
            Me.cbDefaultExpandType = New Common.CheckComboBox()
            Me.SuspendLayout()
            ' 
            ' lblGroupObjectsBy
            ' 
            Me.lblGroupObjectsBy.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.lblGroupObjectsBy.Location = New Point(3, 9)
            Me.lblGroupObjectsBy.Name = "lblGroupObjectsBy"
            Me.lblGroupObjectsBy.Size = New Size(394, 17)
            Me.lblGroupObjectsBy.TabIndex = 13
            Me.lblGroupObjectsBy.Text = "Group objects by:"
            Me.lblGroupObjectsBy.UseCompatibleTextRendering = True
            ' 
            ' cbGroupByServers
            ' 
            Me.cbGroupByServers.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.cbGroupByServers.Location = New Point(27, 29)
            Me.cbGroupByServers.Name = "cbGroupByServers"
            Me.cbGroupByServers.Size = New Size(359, 17)
            Me.cbGroupByServers.TabIndex = 0
            Me.cbGroupByServers.Text = "Servers"
            Me.cbGroupByServers.UseVisualStyleBackColor = True
            ' 
            ' cbGroupByDatabases
            ' 
            Me.cbGroupByDatabases.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.cbGroupByDatabases.Location = New Point(27, 52)
            Me.cbGroupByDatabases.Name = "cbGroupByDatabases"
            Me.cbGroupByDatabases.Size = New Size(359, 17)
            Me.cbGroupByDatabases.TabIndex = 1
            Me.cbGroupByDatabases.Text = "Databases"
            Me.cbGroupByDatabases.UseVisualStyleBackColor = True
            ' 
            ' cbGroupBySchemas
            ' 
            Me.cbGroupBySchemas.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.cbGroupBySchemas.Location = New Point(27, 75)
            Me.cbGroupBySchemas.Name = "cbGroupBySchemas"
            Me.cbGroupBySchemas.Size = New Size(359, 17)
            Me.cbGroupBySchemas.TabIndex = 2
            Me.cbGroupBySchemas.Text = "Schemas"
            Me.cbGroupBySchemas.UseVisualStyleBackColor = True
            ' 
            ' cbGroupByTypes
            ' 
            Me.cbGroupByTypes.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.cbGroupByTypes.Location = New Point(27, 98)
            Me.cbGroupByTypes.Name = "cbGroupByTypes"
            Me.cbGroupByTypes.Size = New Size(359, 17)
            Me.cbGroupByTypes.TabIndex = 3
            Me.cbGroupByTypes.Text = "Types"
            Me.cbGroupByTypes.UseVisualStyleBackColor = True
            ' 
            ' cbShowFields
            ' 
            Me.cbShowFields.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.cbShowFields.Location = New Point(4, 128)
            Me.cbShowFields.Name = "cbShowFields"
            Me.cbShowFields.Size = New Size(382, 17)
            Me.cbShowFields.TabIndex = 4
            Me.cbShowFields.Text = "Show fields"
            Me.cbShowFields.UseVisualStyleBackColor = True
            ' 
            ' lblSortObjectsBy
            ' 
            Me.lblSortObjectsBy.Location = New Point(3, 156)
            Me.lblSortObjectsBy.Name = "lblSortObjectsBy"
            Me.lblSortObjectsBy.Size = New Size(130, 17)
            Me.lblSortObjectsBy.TabIndex = 19
            Me.lblSortObjectsBy.Text = "Sort objects by:"
            Me.lblSortObjectsBy.UseCompatibleTextRendering = True
            ' 
            ' cmbSortObjectsBy
            ' 
            Me.cmbSortObjectsBy.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.cmbSortObjectsBy.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbSortObjectsBy.FormattingEnabled = True
            Me.cmbSortObjectsBy.Location = New Point(186, 153)
            Me.cmbSortObjectsBy.Name = "cmbSortObjectsBy"
            Me.cmbSortObjectsBy.Size = New Size(200, 21)
            Me.cmbSortObjectsBy.TabIndex = 5
            ' 
            ' lblDefaultExpandLevel
            ' 
            Me.lblDefaultExpandLevel.Location = New Point(3, 183)
            Me.lblDefaultExpandLevel.Name = "lblDefaultExpandLevel"
            Me.lblDefaultExpandLevel.Size = New Size(130, 17)
            Me.lblDefaultExpandLevel.TabIndex = 21
            Me.lblDefaultExpandLevel.Text = "Default expand level:"
            Me.lblDefaultExpandLevel.UseCompatibleTextRendering = True
            ' 
            ' cbDefaultExpandType
            ' 
            Me.cbDefaultExpandType.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.cbDefaultExpandType.DropDownHeight = 1
            Me.cbDefaultExpandType.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cbDefaultExpandType.DropDownWidth = 1
            Me.cbDefaultExpandType.FormattingEnabled = True
            Me.cbDefaultExpandType.IntegralHeight = False
            Me.cbDefaultExpandType.Location = New Point(186, 181)
            Me.cbDefaultExpandType.Name = "cbDefaultExpandType"
            Me.cbDefaultExpandType.Size = New Size(200, 21)
            Me.cbDefaultExpandType.TabIndex = 22
            ' 
            ' DatabaseSchemaViewPage
            ' 
            Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.cbDefaultExpandType)
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
            Me.Size = New Size(400, 314)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private lblGroupObjectsBy As Label
        Private cbGroupByServers As CheckBox
        Private cbGroupByDatabases As CheckBox
        Private cbGroupBySchemas As CheckBox
        Private cbGroupByTypes As CheckBox
        Private cbShowFields As CheckBox
        Private lblSortObjectsBy As Label
        Private cmbSortObjectsBy As ComboBox
        Private lblDefaultExpandLevel As Label
        Private cbDefaultExpandType As Common.CheckComboBox
    End Class
End Namespace
