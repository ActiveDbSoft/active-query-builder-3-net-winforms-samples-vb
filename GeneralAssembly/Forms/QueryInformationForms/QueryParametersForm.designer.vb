Namespace Forms.QueryInformationForms
    Partial Public Class QueryParametersForm
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
            Me.buttonCancel = New Button()
            Me.buttonOk = New Button()
            Me.grid = New DataGridView()
            Me.parameterNameColumn = New DataGridViewTextBoxColumn()
            Me.dataTypeColumn = New DataGridViewTextBoxColumn()
            Me.valueColumn = New DataGridViewTextBoxColumn()
            CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' buttonCancel
            ' 
            Me.buttonCancel.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
            Me.buttonCancel.DialogResult = DialogResult.Cancel
            Me.buttonCancel.Location = New Point(337, 184)
            Me.buttonCancel.Name = "buttonCancel"
            Me.buttonCancel.Size = New Size(75, 23)
            Me.buttonCancel.TabIndex = 2
            Me.buttonCancel.Text = "Cancel"
            Me.buttonCancel.UseVisualStyleBackColor = True
            ' 
            ' buttonOk
            ' 
            Me.buttonOk.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
            Me.buttonOk.DialogResult = DialogResult.OK
            Me.buttonOk.Location = New Point(256, 184)
            Me.buttonOk.Name = "buttonOk"
            Me.buttonOk.Size = New Size(75, 23)
            Me.buttonOk.TabIndex = 1
            Me.buttonOk.Text = "OK"
            Me.buttonOk.UseVisualStyleBackColor = True
'            Me.buttonOk.Click += New System.EventHandler(Me.buttonOk_Click)
            ' 
            ' grid
            ' 
            Me.grid.AllowUserToAddRows = False
            Me.grid.AllowUserToDeleteRows = False
            Me.grid.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
            Me.grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.grid.Columns.AddRange(New DataGridViewColumn() { Me.parameterNameColumn, Me.dataTypeColumn, Me.valueColumn})
            Me.grid.Location = New Point(12, 12)
            Me.grid.Name = "grid"
            Me.grid.RowHeadersVisible = False
            Me.grid.Size = New Size(400, 166)
            Me.grid.TabIndex = 0
            ' 
            ' parameterNameColumn
            ' 
            Me.parameterNameColumn.HeaderText = "Parameter Name"
            Me.parameterNameColumn.Name = "parameterNameColumn"
            Me.parameterNameColumn.ReadOnly = True
            Me.parameterNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable
            Me.parameterNameColumn.Width = 120
            ' 
            ' dataTypeColumn
            ' 
            Me.dataTypeColumn.HeaderText = "Data Type"
            Me.dataTypeColumn.Name = "dataTypeColumn"
            Me.dataTypeColumn.ReadOnly = True
            Me.dataTypeColumn.Width = 120
            ' 
            ' valueColumn
            ' 
            Me.valueColumn.HeaderText = "Value"
            Me.valueColumn.Name = "valueColumn"
            Me.valueColumn.SortMode = DataGridViewColumnSortMode.NotSortable
            Me.valueColumn.Width = 120
            ' 
            ' QueryParametersForm
            ' 
            Me.AcceptButton = Me.buttonOk
            Me.AutoScaleDimensions = New SizeF(6F, 13F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.buttonCancel
            Me.ClientSize = New Size(424, 219)
            Me.Controls.Add(Me.grid)
            Me.Controls.Add(Me.buttonCancel)
            Me.Controls.Add(Me.buttonOk)
            Me.Name = "QueryParametersForm"
            Me.StartPosition = FormStartPosition.CenterParent
            Me.Text = "Query Parameters"
            CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private buttonCancel As Button
        Private WithEvents buttonOk As Button
        Private grid As DataGridView
        Private parameterNameColumn As DataGridViewTextBoxColumn
        Private dataTypeColumn As DataGridViewTextBoxColumn
        Private valueColumn As DataGridViewTextBoxColumn
    End Class
End Namespace
