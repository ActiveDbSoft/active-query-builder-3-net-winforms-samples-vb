
Partial Public Class Form1
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region ""

    Private Sub InitializeComponent()
        Me.label1 = New Label()
        Me.tableLayoutPanel1 = New TableLayoutPanel()
        Me.BoxSourceSql = New RichTextBox()
        Me.ButtonLoad = New Button()
        Me.label2 = New Label()
        Me.label3 = New Label()
        Me.CounterVisibleColumns = New Label()
        Me.button2 = New Button()
        Me.tableLayoutPanel3 = New TableLayoutPanel()
        Me.panel2 = New Panel()
        Me.groupBox3 = New GroupBox()
        Me.panel5 = New Panel()
        Me.tableLayoutPanel6 = New TableLayoutPanel()
        Me.label14 = New Label()
        Me.label15 = New Label()
        Me.ComboBoxWhereColumns = New ComboBox()
        Me.ComboBoxConditions = New ComboBox()
        Me.panel10 = New Panel()
        Me.CounterFilters = New Label()
        Me.label17 = New Label()
        Me.panel11 = New Panel()
        Me.ButtonClearWhere = New Button()
        Me.ButtonAddWhere = New Button()
        Me.label18 = New Label()
        Me.TextBoxWhereValue = New TextBox()
        Me.groupBox2 = New GroupBox()
        Me.panel4 = New Panel()
        Me.tableLayoutPanel5 = New TableLayoutPanel()
        Me.label10 = New Label()
        Me.label11 = New Label()
        Me.ComboBoxAggregateColumns = New ComboBox()
        Me.ComboBoxAggregations = New ComboBox()
        Me.panel8 = New Panel()
        Me.CounterAggregations = New Label()
        Me.label13 = New Label()
        Me.panel9 = New Panel()
        Me.ButtonClearAggregates = New Button()
        Me.ButtonAddAggregate = New Button()
        Me.groupBox1 = New GroupBox()
        Me.panel3 = New Panel()
        Me.tableLayoutPanel4 = New TableLayoutPanel()
        Me.label6 = New Label()
        Me.label7 = New Label()
        Me.ComboBoxSortingColumns = New ComboBox()
        Me.ComboBoxSortings = New ComboBox()
        Me.panel6 = New Panel()
        Me.CounterSortings = New Label()
        Me.label8 = New Label()
        Me.panel7 = New Panel()
        Me.ButtonClearSortings = New Button()
        Me.ButtonAddSorting = New Button()
        Me.panel1 = New Panel()
        Me.ListBoxVisibleFields = New CheckedListBox()
        Me.label5 = New Label()
        Me.tableLayoutPanel2 = New TableLayoutPanel()
        Me.BoxResultSql = New RichTextBox()
        Me.ButtonCodeBehindShow = New Button()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.tableLayoutPanel3.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.panel5.SuspendLayout()
        Me.tableLayoutPanel6.SuspendLayout()
        Me.panel10.SuspendLayout()
        Me.panel11.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.panel4.SuspendLayout()
        Me.tableLayoutPanel5.SuspendLayout()
        Me.panel8.SuspendLayout()
        Me.panel9.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.tableLayoutPanel4.SuspendLayout()
        Me.panel6.SuspendLayout()
        Me.panel7.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Dock = DockStyle.Top
        Me.label1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.label1.Location = New Point(10, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(79, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Source SQL:"
        ' 
        ' tableLayoutPanel1
        ' 
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        Me.tableLayoutPanel1.Controls.Add(Me.BoxSourceSql, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.ButtonLoad, 1, 0)
        Me.tableLayoutPanel1.Dock = DockStyle.Top
        Me.tableLayoutPanel1.Location = New Point(10, 23)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel1.Size = New Size(1081, 100)
        Me.tableLayoutPanel1.TabIndex = 1
        ' 
        ' BoxSourceSql
        ' 
        Me.BoxSourceSql.BorderStyle = BorderStyle.FixedSingle
        Me.BoxSourceSql.Dock = DockStyle.Fill
        Me.BoxSourceSql.Location = New Point(3, 3)
        Me.BoxSourceSql.Name = "BoxSourceSql"
        Me.BoxSourceSql.Size = New Size(994, 94)
        Me.BoxSourceSql.TabIndex = 0
        Me.BoxSourceSql.Text = ""
        ' 
        ' ButtonLoad
        ' 
        Me.ButtonLoad.Location = New Point(1003, 3)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New Size(75, 23)
        Me.ButtonLoad.TabIndex = 1
        Me.ButtonLoad.Text = "Load"
        Me.ButtonLoad.UseVisualStyleBackColor = True
'			Me.ButtonLoad.Click += New System.EventHandler(Me.ButtonLoad_Click)
        ' 
        ' label2
        ' 
        Me.label2.AutoSize = True
        Me.label2.Location = New Point(3, 4)
        Me.label2.Name = "label2"
        Me.label2.Size = New Size(83, 13)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Visible Columns:"
        ' 
        ' label3
        ' 
        Me.label3.AutoSize = True
        Me.label3.Location = New Point(3, 252)
        Me.label3.Margin = New Padding(3, 0, 0, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New Size(73, 13)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Visible count :"
        ' 
        ' CounterVisibleColumns
        ' 
        Me.CounterVisibleColumns.AutoSize = True
        Me.CounterVisibleColumns.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.CounterVisibleColumns.Location = New Point(79, 252)
        Me.CounterVisibleColumns.Name = "CounterVisibleColumns"
        Me.CounterVisibleColumns.Size = New Size(14, 13)
        Me.CounterVisibleColumns.TabIndex = 0
        Me.CounterVisibleColumns.Text = "0"
        ' 
        ' button2
        ' 
        Me.button2.Location = New Point(119, 248)
        Me.button2.Name = "button2"
        Me.button2.Size = New Size(75, 20)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Clear"
        Me.button2.UseVisualStyleBackColor = True
        ' 
        ' tableLayoutPanel3
        ' 
        Me.tableLayoutPanel3.ColumnCount = 2
        Me.tableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        Me.tableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel3.Controls.Add(Me.panel2, 1, 0)
        Me.tableLayoutPanel3.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel3.Dock = DockStyle.Top
        Me.tableLayoutPanel3.Location = New Point(10, 123)
        Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
        Me.tableLayoutPanel3.RowCount = 1
        Me.tableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel3.Size = New Size(1081, 285)
        Me.tableLayoutPanel3.TabIndex = 4
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.groupBox3)
        Me.panel2.Controls.Add(Me.groupBox2)
        Me.panel2.Controls.Add(Me.groupBox1)
        Me.panel2.Dock = DockStyle.Fill
        Me.panel2.Location = New Point(209, 3)
        Me.panel2.Name = "panel2"
        Me.panel2.Padding = New Padding(0, 4, 0, 0)
        Me.panel2.Size = New Size(869, 279)
        Me.panel2.TabIndex = 4
        ' 
        ' groupBox3
        ' 
        Me.groupBox3.Controls.Add(Me.panel5)
        Me.groupBox3.Dock = DockStyle.Top
        Me.groupBox3.Location = New Point(0, 126)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New Size(869, 61)
        Me.groupBox3.TabIndex = 0
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Where"
        ' 
        ' panel5
        ' 
        Me.panel5.Controls.Add(Me.tableLayoutPanel6)
        Me.panel5.Dock = DockStyle.Fill
        Me.panel5.Location = New Point(3, 16)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New Size(863, 42)
        Me.panel5.TabIndex = 0
        ' 
        ' tableLayoutPanel6
        ' 
        Me.tableLayoutPanel6.ColumnCount = 4
        Me.tableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        Me.tableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        Me.tableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        Me.tableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 167F))
        Me.tableLayoutPanel6.Controls.Add(Me.label14, 0, 0)
        Me.tableLayoutPanel6.Controls.Add(Me.label15, 1, 0)
        Me.tableLayoutPanel6.Controls.Add(Me.ComboBoxWhereColumns, 0, 1)
        Me.tableLayoutPanel6.Controls.Add(Me.ComboBoxConditions, 1, 1)
        Me.tableLayoutPanel6.Controls.Add(Me.panel10, 3, 0)
        Me.tableLayoutPanel6.Controls.Add(Me.panel11, 3, 1)
        Me.tableLayoutPanel6.Controls.Add(Me.label18, 2, 0)
        Me.tableLayoutPanel6.Controls.Add(Me.TextBoxWhereValue, 2, 1)
        Me.tableLayoutPanel6.Dock = DockStyle.Fill
        Me.tableLayoutPanel6.Location = New Point(0, 0)
        Me.tableLayoutPanel6.Name = "tableLayoutPanel6"
        Me.tableLayoutPanel6.RowCount = 2
        Me.tableLayoutPanel6.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel6.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel6.Size = New Size(863, 42)
        Me.tableLayoutPanel6.TabIndex = 0
        ' 
        ' label14
        ' 
        Me.label14.AutoSize = True
        Me.label14.Dock = DockStyle.Bottom
        Me.label14.Location = New Point(3, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New Size(226, 13)
        Me.label14.TabIndex = 0
        Me.label14.Text = "Columns:"
        ' 
        ' label15
        ' 
        Me.label15.AutoSize = True
        Me.label15.Dock = DockStyle.Bottom
        Me.label15.Location = New Point(235, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New Size(226, 13)
        Me.label15.TabIndex = 0
        Me.label15.Text = "Conditions:"
        ' 
        ' ComboBoxWhereColumns
        ' 
        Me.ComboBoxWhereColumns.Dock = DockStyle.Top
        Me.ComboBoxWhereColumns.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBoxWhereColumns.FormattingEnabled = True
        Me.ComboBoxWhereColumns.Location = New Point(3, 16)
        Me.ComboBoxWhereColumns.Name = "ComboBoxWhereColumns"
        Me.ComboBoxWhereColumns.Size = New Size(226, 21)
        Me.ComboBoxWhereColumns.TabIndex = 2
        ' 
        ' ComboBoxConditions
        ' 
        Me.ComboBoxConditions.Dock = DockStyle.Top
        Me.ComboBoxConditions.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBoxConditions.FormattingEnabled = True
        Me.ComboBoxConditions.Items.AddRange(New Object() { "Equal", "Not Equal", "Greater", "GreaterEqual", "Not Grater", "Not GreaterEqual", "IsNull", "Not IsNull", "IsNotNull", "Less", "LessEqual", "Not Less", "Not LessEqual", "In", "Not In", "Like", "Not Like"})
        Me.ComboBoxConditions.Location = New Point(235, 16)
        Me.ComboBoxConditions.Name = "ComboBoxConditions"
        Me.ComboBoxConditions.Size = New Size(226, 21)
        Me.ComboBoxConditions.TabIndex = 2
        ' 
        ' panel10
        ' 
        Me.panel10.Controls.Add(Me.CounterFilters)
        Me.panel10.Controls.Add(Me.label17)
        Me.panel10.Dock = DockStyle.Bottom
        Me.panel10.Location = New Point(696, 0)
        Me.panel10.Margin = New Padding(0)
        Me.panel10.Name = "panel10"
        Me.panel10.Size = New Size(167, 13)
        Me.panel10.TabIndex = 3
        ' 
        ' CounterFilters
        ' 
        Me.CounterFilters.AutoSize = True
        Me.CounterFilters.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.CounterFilters.Location = New Point(106, 0)
        Me.CounterFilters.Name = "CounterFilters"
        Me.CounterFilters.Size = New Size(14, 13)
        Me.CounterFilters.TabIndex = 1
        Me.CounterFilters.Text = "0"
        ' 
        ' label17
        ' 
        Me.label17.AutoSize = True
        Me.label17.Location = New Point(4, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New Size(67, 13)
        Me.label17.TabIndex = 0
        Me.label17.Text = "Active filters:"
        ' 
        ' panel11
        ' 
        Me.panel11.Controls.Add(Me.ButtonClearWhere)
        Me.panel11.Controls.Add(Me.ButtonAddWhere)
        Me.panel11.Dock = DockStyle.Top
        Me.panel11.Location = New Point(699, 16)
        Me.panel11.Name = "panel11"
        Me.panel11.Size = New Size(161, 29)
        Me.panel11.TabIndex = 4
        ' 
        ' ButtonClearWhere
        ' 
        Me.ButtonClearWhere.Location = New Point(84, 1)
        Me.ButtonClearWhere.Name = "ButtonClearWhere"
        Me.ButtonClearWhere.Size = New Size(75, 21)
        Me.ButtonClearWhere.TabIndex = 0
        Me.ButtonClearWhere.Text = "Clear"
        Me.ButtonClearWhere.UseVisualStyleBackColor = True
'			Me.ButtonClearWhere.Click += New System.EventHandler(Me.ButtonClearWhere_Click)
        ' 
        ' ButtonAddWhere
        ' 
        Me.ButtonAddWhere.Location = New Point(3, 1)
        Me.ButtonAddWhere.Name = "ButtonAddWhere"
        Me.ButtonAddWhere.Size = New Size(75, 21)
        Me.ButtonAddWhere.TabIndex = 0
        Me.ButtonAddWhere.Text = "Add"
        Me.ButtonAddWhere.UseVisualStyleBackColor = True
'			Me.ButtonAddWhere.Click += New System.EventHandler(Me.ButtonAddWhere_Click)
        ' 
        ' label18
        ' 
        Me.label18.AutoSize = True
        Me.label18.Dock = DockStyle.Bottom
        Me.label18.Location = New Point(467, 0)
        Me.label18.Name = "label18"
        Me.label18.Size = New Size(226, 13)
        Me.label18.TabIndex = 5
        Me.label18.Text = "Value:"
        ' 
        ' TextBoxWhereValue
        ' 
        Me.TextBoxWhereValue.Dock = DockStyle.Top
        Me.TextBoxWhereValue.Location = New Point(467, 16)
        Me.TextBoxWhereValue.Name = "TextBoxWhereValue"
        Me.TextBoxWhereValue.Size = New Size(226, 20)
        Me.TextBoxWhereValue.TabIndex = 6
        ' 
        ' groupBox2
        ' 
        Me.groupBox2.Controls.Add(Me.panel4)
        Me.groupBox2.Dock = DockStyle.Top
        Me.groupBox2.Location = New Point(0, 65)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New Size(869, 61)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Aggregate"
        ' 
        ' panel4
        ' 
        Me.panel4.Controls.Add(Me.tableLayoutPanel5)
        Me.panel4.Dock = DockStyle.Fill
        Me.panel4.Location = New Point(3, 16)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New Size(863, 42)
        Me.panel4.TabIndex = 0
        ' 
        ' tableLayoutPanel5
        ' 
        Me.tableLayoutPanel5.ColumnCount = 3
        Me.tableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        Me.tableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        Me.tableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 165F))
        Me.tableLayoutPanel5.Controls.Add(Me.label10, 0, 0)
        Me.tableLayoutPanel5.Controls.Add(Me.label11, 1, 0)
        Me.tableLayoutPanel5.Controls.Add(Me.ComboBoxAggregateColumns, 0, 1)
        Me.tableLayoutPanel5.Controls.Add(Me.ComboBoxAggregations, 1, 1)
        Me.tableLayoutPanel5.Controls.Add(Me.panel8, 2, 0)
        Me.tableLayoutPanel5.Controls.Add(Me.panel9, 2, 1)
        Me.tableLayoutPanel5.Dock = DockStyle.Fill
        Me.tableLayoutPanel5.Location = New Point(0, 0)
        Me.tableLayoutPanel5.Name = "tableLayoutPanel5"
        Me.tableLayoutPanel5.RowCount = 2
        Me.tableLayoutPanel5.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel5.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel5.Size = New Size(863, 42)
        Me.tableLayoutPanel5.TabIndex = 0
        ' 
        ' label10
        ' 
        Me.label10.AutoSize = True
        Me.label10.Dock = DockStyle.Bottom
        Me.label10.Location = New Point(3, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New Size(343, 13)
        Me.label10.TabIndex = 0
        Me.label10.Text = "Columns:"
        ' 
        ' label11
        ' 
        Me.label11.AutoSize = True
        Me.label11.Dock = DockStyle.Bottom
        Me.label11.Location = New Point(352, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New Size(343, 13)
        Me.label11.TabIndex = 0
        Me.label11.Text = "Functions:"
        ' 
        ' ComboBoxAggregateColumns
        ' 
        Me.ComboBoxAggregateColumns.Dock = DockStyle.Top
        Me.ComboBoxAggregateColumns.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBoxAggregateColumns.FormattingEnabled = True
        Me.ComboBoxAggregateColumns.Location = New Point(3, 16)
        Me.ComboBoxAggregateColumns.Name = "ComboBoxAggregateColumns"
        Me.ComboBoxAggregateColumns.Size = New Size(343, 21)
        Me.ComboBoxAggregateColumns.TabIndex = 2
        ' 
        ' ComboBoxAggregations
        ' 
        Me.ComboBoxAggregations.Dock = DockStyle.Top
        Me.ComboBoxAggregations.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBoxAggregations.FormattingEnabled = True
        Me.ComboBoxAggregations.Items.AddRange(New Object() { "Count", "Avg", "Sum", "Min", "Max"})
        Me.ComboBoxAggregations.Location = New Point(352, 16)
        Me.ComboBoxAggregations.Name = "ComboBoxAggregations"
        Me.ComboBoxAggregations.Size = New Size(343, 21)
        Me.ComboBoxAggregations.TabIndex = 2
        ' 
        ' panel8
        ' 
        Me.panel8.Controls.Add(Me.CounterAggregations)
        Me.panel8.Controls.Add(Me.label13)
        Me.panel8.Dock = DockStyle.Bottom
        Me.panel8.Location = New Point(698, 0)
        Me.panel8.Margin = New Padding(0)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New Size(165, 13)
        Me.panel8.TabIndex = 3
        ' 
        ' CounterAggregations
        ' 
        Me.CounterAggregations.AutoSize = True
        Me.CounterAggregations.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.CounterAggregations.Location = New Point(106, 0)
        Me.CounterAggregations.Name = "CounterAggregations"
        Me.CounterAggregations.Size = New Size(14, 13)
        Me.CounterAggregations.TabIndex = 1
        Me.CounterAggregations.Text = "0"
        ' 
        ' label13
        ' 
        Me.label13.AutoSize = True
        Me.label13.Location = New Point(4, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New Size(104, 13)
        Me.label13.TabIndex = 0
        Me.label13.Text = "Active aggregations:"
        ' 
        ' panel9
        ' 
        Me.panel9.Controls.Add(Me.ButtonClearAggregates)
        Me.panel9.Controls.Add(Me.ButtonAddAggregate)
        Me.panel9.Dock = DockStyle.Top
        Me.panel9.Location = New Point(701, 16)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New Size(159, 29)
        Me.panel9.TabIndex = 4
        ' 
        ' ButtonClearAggregates
        ' 
        Me.ButtonClearAggregates.Location = New Point(84, 1)
        Me.ButtonClearAggregates.Name = "ButtonClearAggregates"
        Me.ButtonClearAggregates.Size = New Size(75, 21)
        Me.ButtonClearAggregates.TabIndex = 0
        Me.ButtonClearAggregates.Text = "Clear"
        Me.ButtonClearAggregates.UseVisualStyleBackColor = True
'			Me.ButtonClearAggregates.Click += New System.EventHandler(Me.ButtonClearAggregates_Click)
        ' 
        ' ButtonAddAggregate
        ' 
        Me.ButtonAddAggregate.Location = New Point(3, 1)
        Me.ButtonAddAggregate.Name = "ButtonAddAggregate"
        Me.ButtonAddAggregate.Size = New Size(75, 21)
        Me.ButtonAddAggregate.TabIndex = 0
        Me.ButtonAddAggregate.Text = "Add"
        Me.ButtonAddAggregate.UseVisualStyleBackColor = True
'			Me.ButtonAddAggregate.Click += New System.EventHandler(Me.ButtonAddAggregate_Click)
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.panel3)
        Me.groupBox1.Dock = DockStyle.Top
        Me.groupBox1.Location = New Point(0, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New Size(869, 61)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Sorting"
        ' 
        ' panel3
        ' 
        Me.panel3.Controls.Add(Me.tableLayoutPanel4)
        Me.panel3.Dock = DockStyle.Fill
        Me.panel3.Location = New Point(3, 16)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New Size(863, 42)
        Me.panel3.TabIndex = 0
        ' 
        ' tableLayoutPanel4
        ' 
        Me.tableLayoutPanel4.ColumnCount = 3
        Me.tableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        Me.tableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        Me.tableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 165F))
        Me.tableLayoutPanel4.Controls.Add(Me.label6, 0, 0)
        Me.tableLayoutPanel4.Controls.Add(Me.label7, 1, 0)
        Me.tableLayoutPanel4.Controls.Add(Me.ComboBoxSortingColumns, 0, 1)
        Me.tableLayoutPanel4.Controls.Add(Me.ComboBoxSortings, 1, 1)
        Me.tableLayoutPanel4.Controls.Add(Me.panel6, 2, 0)
        Me.tableLayoutPanel4.Controls.Add(Me.panel7, 2, 1)
        Me.tableLayoutPanel4.Dock = DockStyle.Fill
        Me.tableLayoutPanel4.Location = New Point(0, 0)
        Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
        Me.tableLayoutPanel4.RowCount = 2
        Me.tableLayoutPanel4.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel4.RowStyles.Add(New RowStyle())
        Me.tableLayoutPanel4.Size = New Size(863, 42)
        Me.tableLayoutPanel4.TabIndex = 0
        ' 
        ' label6
        ' 
        Me.label6.AutoSize = True
        Me.label6.Dock = DockStyle.Bottom
        Me.label6.Location = New Point(3, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New Size(343, 13)
        Me.label6.TabIndex = 0
        Me.label6.Text = "Columns:"
        ' 
        ' label7
        ' 
        Me.label7.AutoSize = True
        Me.label7.Dock = DockStyle.Bottom
        Me.label7.Location = New Point(352, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New Size(343, 13)
        Me.label7.TabIndex = 0
        Me.label7.Text = "Sorting:"
        ' 
        ' ComboBoxSortingColumns
        ' 
        Me.ComboBoxSortingColumns.Dock = DockStyle.Top
        Me.ComboBoxSortingColumns.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBoxSortingColumns.FormattingEnabled = True
        Me.ComboBoxSortingColumns.Location = New Point(3, 16)
        Me.ComboBoxSortingColumns.Name = "ComboBoxSortingColumns"
        Me.ComboBoxSortingColumns.Size = New Size(343, 21)
        Me.ComboBoxSortingColumns.TabIndex = 2
        ' 
        ' ComboBoxSortings
        ' 
        Me.ComboBoxSortings.Dock = DockStyle.Top
        Me.ComboBoxSortings.DropDownStyle = ComboBoxStyle.DropDownList
        Me.ComboBoxSortings.FormattingEnabled = True
        Me.ComboBoxSortings.Items.AddRange(New Object() { "Asc", "Desc"})
        Me.ComboBoxSortings.Location = New Point(352, 16)
        Me.ComboBoxSortings.Name = "ComboBoxSortings"
        Me.ComboBoxSortings.Size = New Size(343, 21)
        Me.ComboBoxSortings.TabIndex = 2
        ' 
        ' panel6
        ' 
        Me.panel6.Controls.Add(Me.CounterSortings)
        Me.panel6.Controls.Add(Me.label8)
        Me.panel6.Dock = DockStyle.Bottom
        Me.panel6.Location = New Point(698, 0)
        Me.panel6.Margin = New Padding(0)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New Size(165, 13)
        Me.panel6.TabIndex = 3
        ' 
        ' CounterSortings
        ' 
        Me.CounterSortings.AutoSize = True
        Me.CounterSortings.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.CounterSortings.Location = New Point(106, 0)
        Me.CounterSortings.Name = "CounterSortings"
        Me.CounterSortings.Size = New Size(14, 13)
        Me.CounterSortings.TabIndex = 1
        Me.CounterSortings.Text = "0"
        ' 
        ' label8
        ' 
        Me.label8.AutoSize = True
        Me.label8.Location = New Point(4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New Size(79, 13)
        Me.label8.TabIndex = 0
        Me.label8.Text = "Active sortings:"
        ' 
        ' panel7
        ' 
        Me.panel7.Controls.Add(Me.ButtonClearSortings)
        Me.panel7.Controls.Add(Me.ButtonAddSorting)
        Me.panel7.Dock = DockStyle.Top
        Me.panel7.Location = New Point(701, 16)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New Size(159, 29)
        Me.panel7.TabIndex = 4
        ' 
        ' ButtonClearSortings
        ' 
        Me.ButtonClearSortings.Location = New Point(84, 1)
        Me.ButtonClearSortings.Name = "ButtonClearSortings"
        Me.ButtonClearSortings.Size = New Size(75, 21)
        Me.ButtonClearSortings.TabIndex = 0
        Me.ButtonClearSortings.Text = "Clear"
        Me.ButtonClearSortings.UseVisualStyleBackColor = True
'			Me.ButtonClearSortings.Click += New System.EventHandler(Me.ButtonClearSortings_Click)
        ' 
        ' ButtonAddSorting
        ' 
        Me.ButtonAddSorting.Location = New Point(3, 1)
        Me.ButtonAddSorting.Name = "ButtonAddSorting"
        Me.ButtonAddSorting.Size = New Size(75, 21)
        Me.ButtonAddSorting.TabIndex = 0
        Me.ButtonAddSorting.Text = "Add"
        Me.ButtonAddSorting.UseVisualStyleBackColor = True
'			Me.ButtonAddSorting.Click += New System.EventHandler(Me.ButtonAddSorting_Click)
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.CounterVisibleColumns)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.ListBoxVisibleFields)
        Me.panel1.Dock = DockStyle.Fill
        Me.panel1.Location = New Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New Size(200, 279)
        Me.panel1.TabIndex = 5
        ' 
        ' ListBoxVisibleFields
        ' 
        Me.ListBoxVisibleFields.CheckOnClick = True
        Me.ListBoxVisibleFields.FormattingEnabled = True
        Me.ListBoxVisibleFields.Location = New Point(0, 20)
        Me.ListBoxVisibleFields.Margin = New Padding(0)
        Me.ListBoxVisibleFields.Name = "ListBoxVisibleFields"
        Me.ListBoxVisibleFields.Size = New Size(194, 214)
        Me.ListBoxVisibleFields.TabIndex = 1
'			Me.ListBoxVisibleFields.ItemCheck += New System.Windows.Forms.ItemCheckEventHandler(Me.ListBoxVisibleFields_ItemCheck)
        ' 
        ' label5
        ' 
        Me.label5.AutoSize = True
        Me.label5.Dock = DockStyle.Top
        Me.label5.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.label5.Location = New Point(10, 408)
        Me.label5.Name = "label5"
        Me.label5.Size = New Size(75, 13)
        Me.label5.TabIndex = 5
        Me.label5.Text = "Result SQL:"
        ' 
        ' tableLayoutPanel2
        ' 
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        Me.tableLayoutPanel2.Controls.Add(Me.BoxResultSql, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.ButtonCodeBehindShow, 1, 0)
        Me.tableLayoutPanel2.Dock = DockStyle.Top
        Me.tableLayoutPanel2.Location = New Point(10, 421)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        Me.tableLayoutPanel2.Size = New Size(1081, 122)
        Me.tableLayoutPanel2.TabIndex = 6
        ' 
        ' BoxResultSql
        ' 
        Me.BoxResultSql.BorderStyle = BorderStyle.FixedSingle
        Me.BoxResultSql.Dock = DockStyle.Fill
        Me.BoxResultSql.Location = New Point(3, 3)
        Me.BoxResultSql.Name = "BoxResultSql"
        Me.BoxResultSql.Size = New Size(994, 116)
        Me.BoxResultSql.TabIndex = 0
        Me.BoxResultSql.Text = ""
        ' 
        ' ButtonCodeBehindShow
        ' 
        Me.ButtonCodeBehindShow.Location = New Point(1003, 3)
        Me.ButtonCodeBehindShow.Name = "ButtonCodeBehindShow"
        Me.ButtonCodeBehindShow.Size = New Size(75, 23)
        Me.ButtonCodeBehindShow.TabIndex = 1
        Me.ButtonCodeBehindShow.Text = "CodeBehind"
        Me.ButtonCodeBehindShow.UseVisualStyleBackColor = True
'			Me.ButtonCodeBehindShow.Click += New System.EventHandler(Me.ButtonCodeBehindShow_Click)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = SystemColors.Control
        Me.ClientSize = New Size(1101, 549)
        Me.Controls.Add(Me.tableLayoutPanel2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.tableLayoutPanel3)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Padding = New Padding(10)
        Me.Text = "QueryTransformerCoreDemo"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel3.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.panel5.ResumeLayout(False)
        Me.tableLayoutPanel6.ResumeLayout(False)
        Me.tableLayoutPanel6.PerformLayout()
        Me.panel10.ResumeLayout(False)
        Me.panel10.PerformLayout()
        Me.panel11.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.panel4.ResumeLayout(False)
        Me.tableLayoutPanel5.ResumeLayout(False)
        Me.tableLayoutPanel5.PerformLayout()
        Me.panel8.ResumeLayout(False)
        Me.panel8.PerformLayout()
        Me.panel9.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.tableLayoutPanel4.ResumeLayout(False)
        Me.tableLayoutPanel4.PerformLayout()
        Me.panel6.ResumeLayout(False)
        Me.panel6.PerformLayout()
        Me.panel7.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private label1 As Label
    Private tableLayoutPanel1 As TableLayoutPanel
    Private BoxSourceSql As RichTextBox
    Private WithEvents ButtonLoad As Button
    Private label2 As Label
    Private button2 As Button
    Private label3 As Label
    Private CounterVisibleColumns As Label
    Private tableLayoutPanel3 As TableLayoutPanel
    Private panel2 As Panel
    Private panel1 As Panel
    Private groupBox3 As GroupBox
    Private groupBox2 As GroupBox
    Private groupBox1 As GroupBox
    Private label5 As Label
    Private tableLayoutPanel2 As TableLayoutPanel
    Private BoxResultSql As RichTextBox
    Private WithEvents ButtonCodeBehindShow As Button
    Private panel5 As Panel
    Private panel4 As Panel
    Private panel3 As Panel
    Private tableLayoutPanel4 As TableLayoutPanel
    Private label6 As Label
    Private label7 As Label
    Private ComboBoxSortingColumns As ComboBox
    Private ComboBoxSortings As ComboBox
    Private panel6 As Panel
    Private CounterSortings As Label
    Private label8 As Label
    Private panel7 As Panel
    Private WithEvents ButtonClearSortings As Button
    Private WithEvents ButtonAddSorting As Button
    Private tableLayoutPanel6 As TableLayoutPanel
    Private label14 As Label
    Private label15 As Label
    Private ComboBoxWhereColumns As ComboBox
    Private ComboBoxConditions As ComboBox
    Private panel10 As Panel
    Private CounterFilters As Label
    Private label17 As Label
    Private panel11 As Panel
    Private WithEvents ButtonClearWhere As Button
    Private WithEvents ButtonAddWhere As Button
    Private tableLayoutPanel5 As TableLayoutPanel
    Private label10 As Label
    Private label11 As Label
    Private ComboBoxAggregateColumns As ComboBox
    Private ComboBoxAggregations As ComboBox
    Private panel8 As Panel
    Private CounterAggregations As Label
    Private label13 As Label
    Private panel9 As Panel
    Private WithEvents ButtonClearAggregates As Button
    Private WithEvents ButtonAddAggregate As Button
    Private label18 As Label
    Private TextBoxWhereValue As TextBox
    Private WithEvents ListBoxVisibleFields As CheckedListBox
End Class