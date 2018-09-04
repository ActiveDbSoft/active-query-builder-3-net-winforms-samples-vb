Partial Class Form1
	''' <summary>
	''' Обязательная переменная конструктора.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Освободить все используемые ресурсы.
	''' </summary>
	''' <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Код, автоматически созданный конструктором форм Windows"

	''' <summary>
	''' Требуемый метод для поддержки конструктора — не изменяйте 
	''' содержимое этого метода с помощью редактора кода.
	''' </summary>
	Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BoxSourceSql = New System.Windows.Forms.RichTextBox()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.CounterVisibleColumns = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.tableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.ComboBoxWhereColumns = New System.Windows.Forms.ComboBox()
        Me.ComboBoxConditions = New System.Windows.Forms.ComboBox()
        Me.panel10 = New System.Windows.Forms.Panel()
        Me.CounterFilters = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.panel11 = New System.Windows.Forms.Panel()
        Me.ButtonClearWhere = New System.Windows.Forms.Button()
        Me.ButtonAddWhere = New System.Windows.Forms.Button()
        Me.label18 = New System.Windows.Forms.Label()
        Me.TextBoxWhereValue = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.tableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.ComboBoxAggregateColumns = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAggregations = New System.Windows.Forms.ComboBox()
        Me.panel8 = New System.Windows.Forms.Panel()
        Me.CounterAggregations = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.panel9 = New System.Windows.Forms.Panel()
        Me.ButtonClearAggregates = New System.Windows.Forms.Button()
        Me.ButtonAddAggregate = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.ComboBoxSortingColumns = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSortings = New System.Windows.Forms.ComboBox()
        Me.panel6 = New System.Windows.Forms.Panel()
        Me.CounterSortings = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.ButtonClearSortings = New System.Windows.Forms.Button()
        Me.ButtonAddSorting = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.ListBoxVisibleFields = New System.Windows.Forms.CheckedListBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BoxResultSql = New System.Windows.Forms.RichTextBox()
        Me.ButtonCodeBehindShow = New System.Windows.Forms.Button()
        Me.tableLayoutPanel1.SuspendLayout
        Me.tableLayoutPanel3.SuspendLayout
        Me.panel2.SuspendLayout
        Me.groupBox3.SuspendLayout
        Me.panel5.SuspendLayout
        Me.tableLayoutPanel6.SuspendLayout
        Me.panel10.SuspendLayout
        Me.panel11.SuspendLayout
        Me.groupBox2.SuspendLayout
        Me.panel4.SuspendLayout
        Me.tableLayoutPanel5.SuspendLayout
        Me.panel8.SuspendLayout
        Me.panel9.SuspendLayout
        Me.groupBox1.SuspendLayout
        Me.panel3.SuspendLayout
        Me.tableLayoutPanel4.SuspendLayout
        Me.panel6.SuspendLayout
        Me.panel7.SuspendLayout
        Me.panel1.SuspendLayout
        Me.tableLayoutPanel2.SuspendLayout
        Me.SuspendLayout
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.label1.Location = New System.Drawing.Point(10, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Source SQL:"
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.Controls.Add(Me.BoxSourceSql, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.ButtonLoad, 1, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(10, 23)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(1081, 100)
        Me.tableLayoutPanel1.TabIndex = 1
        '
        'BoxSourceSql
        '
        Me.BoxSourceSql.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BoxSourceSql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxSourceSql.Location = New System.Drawing.Point(3, 3)
        Me.BoxSourceSql.Name = "BoxSourceSql"
        Me.BoxSourceSql.Size = New System.Drawing.Size(994, 94)
        Me.BoxSourceSql.TabIndex = 0
        Me.BoxSourceSql.Text = ""
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(1003, 3)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLoad.TabIndex = 1
        Me.ButtonLoad.Text = "Load"
        Me.ButtonLoad.UseVisualStyleBackColor = true
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(3, 4)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(83, 13)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Visible Columns:"
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(3, 252)
        Me.label3.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(73, 13)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Visible count :"
        '
        'CounterVisibleColumns
        '
        Me.CounterVisibleColumns.AutoSize = true
        Me.CounterVisibleColumns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CounterVisibleColumns.Location = New System.Drawing.Point(79, 252)
        Me.CounterVisibleColumns.Name = "CounterVisibleColumns"
        Me.CounterVisibleColumns.Size = New System.Drawing.Size(14, 13)
        Me.CounterVisibleColumns.TabIndex = 0
        Me.CounterVisibleColumns.Text = "0"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(119, 248)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 20)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Clear"
        Me.button2.UseVisualStyleBackColor = true
        '
        'tableLayoutPanel3
        '
        Me.tableLayoutPanel3.ColumnCount = 2
        Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel3.Controls.Add(Me.panel2, 1, 0)
        Me.tableLayoutPanel3.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.tableLayoutPanel3.Location = New System.Drawing.Point(10, 123)
        Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
        Me.tableLayoutPanel3.RowCount = 1
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel3.Size = New System.Drawing.Size(1081, 285)
        Me.tableLayoutPanel3.TabIndex = 4
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.groupBox3)
        Me.panel2.Controls.Add(Me.groupBox2)
        Me.panel2.Controls.Add(Me.groupBox1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(209, 3)
        Me.panel2.Name = "panel2"
        Me.panel2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.panel2.Size = New System.Drawing.Size(869, 279)
        Me.panel2.TabIndex = 4
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.panel5)
        Me.groupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupBox3.Location = New System.Drawing.Point(0, 126)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(869, 61)
        Me.groupBox3.TabIndex = 0
        Me.groupBox3.TabStop = false
        Me.groupBox3.Text = "Where"
        '
        'panel5
        '
        Me.panel5.Controls.Add(Me.tableLayoutPanel6)
        Me.panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel5.Location = New System.Drawing.Point(3, 16)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(863, 42)
        Me.panel5.TabIndex = 0
        '
        'tableLayoutPanel6
        '
        Me.tableLayoutPanel6.ColumnCount = 4
        Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167!))
        Me.tableLayoutPanel6.Controls.Add(Me.label14, 0, 0)
        Me.tableLayoutPanel6.Controls.Add(Me.label15, 1, 0)
        Me.tableLayoutPanel6.Controls.Add(Me.ComboBoxWhereColumns, 0, 1)
        Me.tableLayoutPanel6.Controls.Add(Me.ComboBoxConditions, 1, 1)
        Me.tableLayoutPanel6.Controls.Add(Me.panel10, 3, 0)
        Me.tableLayoutPanel6.Controls.Add(Me.panel11, 3, 1)
        Me.tableLayoutPanel6.Controls.Add(Me.label18, 2, 0)
        Me.tableLayoutPanel6.Controls.Add(Me.TextBoxWhereValue, 2, 1)
        Me.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel6.Name = "tableLayoutPanel6"
        Me.tableLayoutPanel6.RowCount = 2
        Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel6.Size = New System.Drawing.Size(863, 42)
        Me.tableLayoutPanel6.TabIndex = 0
        '
        'label14
        '
        Me.label14.AutoSize = true
        Me.label14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.label14.Location = New System.Drawing.Point(3, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(226, 13)
        Me.label14.TabIndex = 0
        Me.label14.Text = "Columns:"
        '
        'label15
        '
        Me.label15.AutoSize = true
        Me.label15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.label15.Location = New System.Drawing.Point(235, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(226, 13)
        Me.label15.TabIndex = 0
        Me.label15.Text = "Conditions:"
        '
        'ComboBoxWhereColumns
        '
        Me.ComboBoxWhereColumns.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboBoxWhereColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxWhereColumns.FormattingEnabled = true
        Me.ComboBoxWhereColumns.Location = New System.Drawing.Point(3, 16)
        Me.ComboBoxWhereColumns.Name = "ComboBoxWhereColumns"
        Me.ComboBoxWhereColumns.Size = New System.Drawing.Size(226, 21)
        Me.ComboBoxWhereColumns.TabIndex = 2
        '
        'ComboBoxConditions
        '
        Me.ComboBoxConditions.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboBoxConditions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxConditions.FormattingEnabled = true
        Me.ComboBoxConditions.Items.AddRange(New Object() {"Equal", "Not Equal", "Greater", "GreaterEqual", "Not Grater", "Not GreaterEqual", "IsNull", "Not IsNull", "IsNotNull", "Less", "LessEqual", "Not Less", "Not LessEqual", "In", "Not In", "Like", "Not Like"})
        Me.ComboBoxConditions.Location = New System.Drawing.Point(235, 16)
        Me.ComboBoxConditions.Name = "ComboBoxConditions"
        Me.ComboBoxConditions.Size = New System.Drawing.Size(226, 21)
        Me.ComboBoxConditions.TabIndex = 2
        '
        'panel10
        '
        Me.panel10.Controls.Add(Me.CounterFilters)
        Me.panel10.Controls.Add(Me.label17)
        Me.panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel10.Location = New System.Drawing.Point(696, 0)
        Me.panel10.Margin = New System.Windows.Forms.Padding(0)
        Me.panel10.Name = "panel10"
        Me.panel10.Size = New System.Drawing.Size(167, 13)
        Me.panel10.TabIndex = 3
        '
        'CounterFilters
        '
        Me.CounterFilters.AutoSize = true
        Me.CounterFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CounterFilters.Location = New System.Drawing.Point(106, 0)
        Me.CounterFilters.Name = "CounterFilters"
        Me.CounterFilters.Size = New System.Drawing.Size(14, 13)
        Me.CounterFilters.TabIndex = 1
        Me.CounterFilters.Text = "0"
        '
        'label17
        '
        Me.label17.AutoSize = true
        Me.label17.Location = New System.Drawing.Point(4, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(67, 13)
        Me.label17.TabIndex = 0
        Me.label17.Text = "Active filters:"
        '
        'panel11
        '
        Me.panel11.Controls.Add(Me.ButtonClearWhere)
        Me.panel11.Controls.Add(Me.ButtonAddWhere)
        Me.panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel11.Location = New System.Drawing.Point(699, 16)
        Me.panel11.Name = "panel11"
        Me.panel11.Size = New System.Drawing.Size(161, 29)
        Me.panel11.TabIndex = 4
        '
        'ButtonClearWhere
        '
        Me.ButtonClearWhere.Location = New System.Drawing.Point(84, 1)
        Me.ButtonClearWhere.Name = "ButtonClearWhere"
        Me.ButtonClearWhere.Size = New System.Drawing.Size(75, 21)
        Me.ButtonClearWhere.TabIndex = 0
        Me.ButtonClearWhere.Text = "Clear"
        Me.ButtonClearWhere.UseVisualStyleBackColor = true
        '
        'ButtonAddWhere
        '
        Me.ButtonAddWhere.Location = New System.Drawing.Point(3, 1)
        Me.ButtonAddWhere.Name = "ButtonAddWhere"
        Me.ButtonAddWhere.Size = New System.Drawing.Size(75, 21)
        Me.ButtonAddWhere.TabIndex = 0
        Me.ButtonAddWhere.Text = "Add"
        Me.ButtonAddWhere.UseVisualStyleBackColor = true
        '
        'label18
        '
        Me.label18.AutoSize = true
        Me.label18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.label18.Location = New System.Drawing.Point(467, 0)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(226, 13)
        Me.label18.TabIndex = 5
        Me.label18.Text = "Value:"
        '
        'TextBoxWhereValue
        '
        Me.TextBoxWhereValue.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxWhereValue.Location = New System.Drawing.Point(467, 16)
        Me.TextBoxWhereValue.Name = "TextBoxWhereValue"
        Me.TextBoxWhereValue.Size = New System.Drawing.Size(226, 20)
        Me.TextBoxWhereValue.TabIndex = 6
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.panel4)
        Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupBox2.Location = New System.Drawing.Point(0, 65)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(869, 61)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = false
        Me.groupBox2.Text = "Aggregate"
        '
        'panel4
        '
        Me.panel4.Controls.Add(Me.tableLayoutPanel5)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel4.Location = New System.Drawing.Point(3, 16)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(863, 42)
        Me.panel4.TabIndex = 0
        '
        'tableLayoutPanel5
        '
        Me.tableLayoutPanel5.ColumnCount = 3
        Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165!))
        Me.tableLayoutPanel5.Controls.Add(Me.label10, 0, 0)
        Me.tableLayoutPanel5.Controls.Add(Me.label11, 1, 0)
        Me.tableLayoutPanel5.Controls.Add(Me.ComboBoxAggregateColumns, 0, 1)
        Me.tableLayoutPanel5.Controls.Add(Me.ComboBoxAggregations, 1, 1)
        Me.tableLayoutPanel5.Controls.Add(Me.panel8, 2, 0)
        Me.tableLayoutPanel5.Controls.Add(Me.panel9, 2, 1)
        Me.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel5.Name = "tableLayoutPanel5"
        Me.tableLayoutPanel5.RowCount = 2
        Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel5.Size = New System.Drawing.Size(863, 42)
        Me.tableLayoutPanel5.TabIndex = 0
        '
        'label10
        '
        Me.label10.AutoSize = true
        Me.label10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.label10.Location = New System.Drawing.Point(3, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(343, 13)
        Me.label10.TabIndex = 0
        Me.label10.Text = "Columns:"
        '
        'label11
        '
        Me.label11.AutoSize = true
        Me.label11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.label11.Location = New System.Drawing.Point(352, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(343, 13)
        Me.label11.TabIndex = 0
        Me.label11.Text = "Functions:"
        '
        'ComboBoxAggregateColumns
        '
        Me.ComboBoxAggregateColumns.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboBoxAggregateColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAggregateColumns.FormattingEnabled = true
        Me.ComboBoxAggregateColumns.Location = New System.Drawing.Point(3, 16)
        Me.ComboBoxAggregateColumns.Name = "ComboBoxAggregateColumns"
        Me.ComboBoxAggregateColumns.Size = New System.Drawing.Size(343, 21)
        Me.ComboBoxAggregateColumns.TabIndex = 2
        '
        'ComboBoxAggregations
        '
        Me.ComboBoxAggregations.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboBoxAggregations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAggregations.FormattingEnabled = true
        Me.ComboBoxAggregations.Items.AddRange(New Object() {"Count", "Avg", "Sum", "Min", "Max"})
        Me.ComboBoxAggregations.Location = New System.Drawing.Point(352, 16)
        Me.ComboBoxAggregations.Name = "ComboBoxAggregations"
        Me.ComboBoxAggregations.Size = New System.Drawing.Size(343, 21)
        Me.ComboBoxAggregations.TabIndex = 2
        '
        'panel8
        '
        Me.panel8.Controls.Add(Me.CounterAggregations)
        Me.panel8.Controls.Add(Me.label13)
        Me.panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel8.Location = New System.Drawing.Point(698, 0)
        Me.panel8.Margin = New System.Windows.Forms.Padding(0)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(165, 13)
        Me.panel8.TabIndex = 3
        '
        'CounterAggregations
        '
        Me.CounterAggregations.AutoSize = true
        Me.CounterAggregations.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CounterAggregations.Location = New System.Drawing.Point(106, 0)
        Me.CounterAggregations.Name = "CounterAggregations"
        Me.CounterAggregations.Size = New System.Drawing.Size(14, 13)
        Me.CounterAggregations.TabIndex = 1
        Me.CounterAggregations.Text = "0"
        '
        'label13
        '
        Me.label13.AutoSize = true
        Me.label13.Location = New System.Drawing.Point(4, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(104, 13)
        Me.label13.TabIndex = 0
        Me.label13.Text = "Active aggregations:"
        '
        'panel9
        '
        Me.panel9.Controls.Add(Me.ButtonClearAggregates)
        Me.panel9.Controls.Add(Me.ButtonAddAggregate)
        Me.panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel9.Location = New System.Drawing.Point(701, 16)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New System.Drawing.Size(159, 29)
        Me.panel9.TabIndex = 4
        '
        'ButtonClearAggregates
        '
        Me.ButtonClearAggregates.Location = New System.Drawing.Point(84, 1)
        Me.ButtonClearAggregates.Name = "ButtonClearAggregates"
        Me.ButtonClearAggregates.Size = New System.Drawing.Size(75, 21)
        Me.ButtonClearAggregates.TabIndex = 0
        Me.ButtonClearAggregates.Text = "Clear"
        Me.ButtonClearAggregates.UseVisualStyleBackColor = true
        '
        'ButtonAddAggregate
        '
        Me.ButtonAddAggregate.Location = New System.Drawing.Point(3, 1)
        Me.ButtonAddAggregate.Name = "ButtonAddAggregate"
        Me.ButtonAddAggregate.Size = New System.Drawing.Size(75, 21)
        Me.ButtonAddAggregate.TabIndex = 0
        Me.ButtonAddAggregate.Text = "Add"
        Me.ButtonAddAggregate.UseVisualStyleBackColor = true
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.panel3)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupBox1.Location = New System.Drawing.Point(0, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(869, 61)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = false
        Me.groupBox1.Text = "Sorting"
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.tableLayoutPanel4)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(3, 16)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(863, 42)
        Me.panel3.TabIndex = 0
        '
        'tableLayoutPanel4
        '
        Me.tableLayoutPanel4.ColumnCount = 3
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165!))
        Me.tableLayoutPanel4.Controls.Add(Me.label6, 0, 0)
        Me.tableLayoutPanel4.Controls.Add(Me.label7, 1, 0)
        Me.tableLayoutPanel4.Controls.Add(Me.ComboBoxSortingColumns, 0, 1)
        Me.tableLayoutPanel4.Controls.Add(Me.ComboBoxSortings, 1, 1)
        Me.tableLayoutPanel4.Controls.Add(Me.panel6, 2, 0)
        Me.tableLayoutPanel4.Controls.Add(Me.panel7, 2, 1)
        Me.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
        Me.tableLayoutPanel4.RowCount = 2
        Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel4.Size = New System.Drawing.Size(863, 42)
        Me.tableLayoutPanel4.TabIndex = 0
        '
        'label6
        '
        Me.label6.AutoSize = true
        Me.label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.label6.Location = New System.Drawing.Point(3, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(343, 13)
        Me.label6.TabIndex = 0
        Me.label6.Text = "Columns:"
        '
        'label7
        '
        Me.label7.AutoSize = true
        Me.label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.label7.Location = New System.Drawing.Point(352, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(343, 13)
        Me.label7.TabIndex = 0
        Me.label7.Text = "Sorting:"
        '
        'ComboBoxSortingColumns
        '
        Me.ComboBoxSortingColumns.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboBoxSortingColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSortingColumns.FormattingEnabled = true
        Me.ComboBoxSortingColumns.Location = New System.Drawing.Point(3, 16)
        Me.ComboBoxSortingColumns.Name = "ComboBoxSortingColumns"
        Me.ComboBoxSortingColumns.Size = New System.Drawing.Size(343, 21)
        Me.ComboBoxSortingColumns.TabIndex = 2
        '
        'ComboBoxSortings
        '
        Me.ComboBoxSortings.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboBoxSortings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSortings.FormattingEnabled = true
        Me.ComboBoxSortings.Items.AddRange(New Object() {"Asc", "Desc"})
        Me.ComboBoxSortings.Location = New System.Drawing.Point(352, 16)
        Me.ComboBoxSortings.Name = "ComboBoxSortings"
        Me.ComboBoxSortings.Size = New System.Drawing.Size(343, 21)
        Me.ComboBoxSortings.TabIndex = 2
        '
        'panel6
        '
        Me.panel6.Controls.Add(Me.CounterSortings)
        Me.panel6.Controls.Add(Me.label8)
        Me.panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel6.Location = New System.Drawing.Point(698, 0)
        Me.panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(165, 13)
        Me.panel6.TabIndex = 3
        '
        'CounterSortings
        '
        Me.CounterSortings.AutoSize = true
        Me.CounterSortings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.CounterSortings.Location = New System.Drawing.Point(106, 0)
        Me.CounterSortings.Name = "CounterSortings"
        Me.CounterSortings.Size = New System.Drawing.Size(14, 13)
        Me.CounterSortings.TabIndex = 1
        Me.CounterSortings.Text = "0"
        '
        'label8
        '
        Me.label8.AutoSize = true
        Me.label8.Location = New System.Drawing.Point(4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(79, 13)
        Me.label8.TabIndex = 0
        Me.label8.Text = "Active sortings:"
        '
        'panel7
        '
        Me.panel7.Controls.Add(Me.ButtonClearSortings)
        Me.panel7.Controls.Add(Me.ButtonAddSorting)
        Me.panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel7.Location = New System.Drawing.Point(701, 16)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(159, 29)
        Me.panel7.TabIndex = 4
        '
        'ButtonClearSortings
        '
        Me.ButtonClearSortings.Location = New System.Drawing.Point(84, 1)
        Me.ButtonClearSortings.Name = "ButtonClearSortings"
        Me.ButtonClearSortings.Size = New System.Drawing.Size(75, 21)
        Me.ButtonClearSortings.TabIndex = 0
        Me.ButtonClearSortings.Text = "Clear"
        Me.ButtonClearSortings.UseVisualStyleBackColor = true
        '
        'ButtonAddSorting
        '
        Me.ButtonAddSorting.Location = New System.Drawing.Point(3, 1)
        Me.ButtonAddSorting.Name = "ButtonAddSorting"
        Me.ButtonAddSorting.Size = New System.Drawing.Size(75, 21)
        Me.ButtonAddSorting.TabIndex = 0
        Me.ButtonAddSorting.Text = "Add"
        Me.ButtonAddSorting.UseVisualStyleBackColor = true
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.CounterVisibleColumns)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.ListBoxVisibleFields)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(200, 279)
        Me.panel1.TabIndex = 5
        '
        'ListBoxVisibleFields
        '
        Me.ListBoxVisibleFields.CheckOnClick = true
        Me.ListBoxVisibleFields.FormattingEnabled = true
        Me.ListBoxVisibleFields.Location = New System.Drawing.Point(0, 20)
        Me.ListBoxVisibleFields.Margin = New System.Windows.Forms.Padding(0)
        Me.ListBoxVisibleFields.Name = "ListBoxVisibleFields"
        Me.ListBoxVisibleFields.Size = New System.Drawing.Size(194, 214)
        Me.ListBoxVisibleFields.TabIndex = 1
        '
        'label5
        '
        Me.label5.AutoSize = true
        Me.label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
        Me.label5.Location = New System.Drawing.Point(10, 408)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(75, 13)
        Me.label5.TabIndex = 5
        Me.label5.Text = "Result SQL:"
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel2.Controls.Add(Me.BoxResultSql, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.ButtonCodeBehindShow, 1, 0)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(10, 421)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(1081, 122)
        Me.tableLayoutPanel2.TabIndex = 6
        '
        'BoxResultSql
        '
        Me.BoxResultSql.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BoxResultSql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxResultSql.Location = New System.Drawing.Point(3, 3)
        Me.BoxResultSql.Name = "BoxResultSql"
        Me.BoxResultSql.Size = New System.Drawing.Size(994, 116)
        Me.BoxResultSql.TabIndex = 0
        Me.BoxResultSql.Text = ""
        '
        'ButtonCodeBehindShow
        '
        Me.ButtonCodeBehindShow.Location = New System.Drawing.Point(1003, 3)
        Me.ButtonCodeBehindShow.Name = "ButtonCodeBehindShow"
        Me.ButtonCodeBehindShow.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCodeBehindShow.TabIndex = 1
        Me.ButtonCodeBehindShow.Text = "CodeBehind"
        Me.ButtonCodeBehindShow.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1101, 549)
        Me.Controls.Add(Me.tableLayoutPanel2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.tableLayoutPanel3)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "QueryTransformerCoreDemo"
        Me.tableLayoutPanel1.ResumeLayout(false)
        Me.tableLayoutPanel3.ResumeLayout(false)
        Me.panel2.ResumeLayout(false)
        Me.groupBox3.ResumeLayout(false)
        Me.panel5.ResumeLayout(false)
        Me.tableLayoutPanel6.ResumeLayout(false)
        Me.tableLayoutPanel6.PerformLayout
        Me.panel10.ResumeLayout(false)
        Me.panel10.PerformLayout
        Me.panel11.ResumeLayout(false)
        Me.groupBox2.ResumeLayout(false)
        Me.panel4.ResumeLayout(false)
        Me.tableLayoutPanel5.ResumeLayout(false)
        Me.tableLayoutPanel5.PerformLayout
        Me.panel8.ResumeLayout(false)
        Me.panel8.PerformLayout
        Me.panel9.ResumeLayout(false)
        Me.groupBox1.ResumeLayout(false)
        Me.panel3.ResumeLayout(false)
        Me.tableLayoutPanel4.ResumeLayout(false)
        Me.tableLayoutPanel4.PerformLayout
        Me.panel6.ResumeLayout(false)
        Me.panel6.PerformLayout
        Me.panel7.ResumeLayout(false)
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        Me.tableLayoutPanel2.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

	#End Region

	Private label1 As System.Windows.Forms.Label
	Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Private BoxSourceSql As System.Windows.Forms.RichTextBox
	Private WithEvents ButtonLoad As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private button2 As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private CounterVisibleColumns As System.Windows.Forms.Label
	Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private label5 As System.Windows.Forms.Label
	Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Private BoxResultSql As System.Windows.Forms.RichTextBox
	Private WithEvents ButtonCodeBehindShow As System.Windows.Forms.Button
	Private panel5 As System.Windows.Forms.Panel
	Private panel4 As System.Windows.Forms.Panel
	Private panel3 As System.Windows.Forms.Panel
	Private tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
	Private label6 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private ComboBoxSortingColumns As System.Windows.Forms.ComboBox
	Private ComboBoxSortings As System.Windows.Forms.ComboBox
	Private panel6 As System.Windows.Forms.Panel
	Private CounterSortings As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private panel7 As System.Windows.Forms.Panel
	Private WithEvents ButtonClearSortings As System.Windows.Forms.Button
	Private WithEvents ButtonAddSorting As System.Windows.Forms.Button
	Private tableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
	Private label14 As System.Windows.Forms.Label
	Private label15 As System.Windows.Forms.Label
	Private ComboBoxWhereColumns As System.Windows.Forms.ComboBox
	Private ComboBoxConditions As System.Windows.Forms.ComboBox
	Private panel10 As System.Windows.Forms.Panel
	Private CounterFilters As System.Windows.Forms.Label
	Private label17 As System.Windows.Forms.Label
	Private panel11 As System.Windows.Forms.Panel
	Private WithEvents ButtonClearWhere As System.Windows.Forms.Button
	Private WithEvents ButtonAddWhere As System.Windows.Forms.Button
	Private tableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
	Private label10 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private ComboBoxAggregateColumns As System.Windows.Forms.ComboBox
	Private ComboBoxAggregations As System.Windows.Forms.ComboBox
	Private panel8 As System.Windows.Forms.Panel
	Private CounterAggregations As System.Windows.Forms.Label
	Private label13 As System.Windows.Forms.Label
	Private panel9 As System.Windows.Forms.Panel
	Private WithEvents ButtonClearAggregates As System.Windows.Forms.Button
	Private WithEvents ButtonAddAggregate As System.Windows.Forms.Button
	Private label18 As System.Windows.Forms.Label
	Private TextBoxWhereValue As System.Windows.Forms.TextBox
	Private WithEvents ListBoxVisibleFields As System.Windows.Forms.CheckedListBox
End Class

