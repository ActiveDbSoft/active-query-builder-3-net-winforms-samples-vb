Partial Class QueryParametersForm
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
		Me.buttonCancel = New System.Windows.Forms.Button()
		Me.buttonOk = New System.Windows.Forms.Button()
		Me.grid = New System.Windows.Forms.DataGridView()
		Me.parameterNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dataTypeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.valueColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		DirectCast(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' buttonCancel
		' 
		Me.buttonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonCancel.Location = New System.Drawing.Point(337, 184)
		Me.buttonCancel.Name = "buttonCancel"
		Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
		Me.buttonCancel.TabIndex = 2
		Me.buttonCancel.Text = "Cancel"
		Me.buttonCancel.UseVisualStyleBackColor = True
		' 
		' buttonOk
		' 
		Me.buttonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.buttonOk.Location = New System.Drawing.Point(256, 184)
		Me.buttonOk.Name = "buttonOk"
		Me.buttonOk.Size = New System.Drawing.Size(75, 23)
		Me.buttonOk.TabIndex = 1
		Me.buttonOk.Text = "OK"
		Me.buttonOk.UseVisualStyleBackColor = True
		AddHandler Me.buttonOk.Click, New System.EventHandler(AddressOf Me.buttonOk_Click)
		' 
		' grid
		' 
		Me.grid.AllowUserToAddRows = False
		Me.grid.AllowUserToDeleteRows = False
		Me.grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.parameterNameColumn, Me.dataTypeColumn, Me.valueColumn})
		Me.grid.Location = New System.Drawing.Point(12, 12)
		Me.grid.Name = "grid"
		Me.grid.RowHeadersVisible = False
		Me.grid.Size = New System.Drawing.Size(400, 166)
		Me.grid.TabIndex = 0
		' 
		' parameterNameColumn
		' 
		Me.parameterNameColumn.HeaderText = "Parameter Name"
		Me.parameterNameColumn.Name = "parameterNameColumn"
		Me.parameterNameColumn.[ReadOnly] = True
		Me.parameterNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.parameterNameColumn.Width = 120
		' 
		' dataTypeColumn
		' 
		Me.dataTypeColumn.HeaderText = "Data Type"
		Me.dataTypeColumn.Name = "dataTypeColumn"
		Me.dataTypeColumn.[ReadOnly] = True
		Me.dataTypeColumn.Width = 120
		' 
		' valueColumn
		' 
		Me.valueColumn.HeaderText = "Value"
		Me.valueColumn.Name = "valueColumn"
		Me.valueColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.valueColumn.Width = 120
		' 
		' QueryParametersForm
		' 
		Me.AcceptButton = Me.buttonOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.buttonCancel
		Me.ClientSize = New System.Drawing.Size(424, 219)
		Me.Controls.Add(Me.grid)
		Me.Controls.Add(Me.buttonCancel)
		Me.Controls.Add(Me.buttonOk)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "QueryParametersForm"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Query Parameters"
		DirectCast(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private buttonCancel As System.Windows.Forms.Button
	Private buttonOk As System.Windows.Forms.Button
	Private grid As System.Windows.Forms.DataGridView
	Private parameterNameColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Private dataTypeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Private valueColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
