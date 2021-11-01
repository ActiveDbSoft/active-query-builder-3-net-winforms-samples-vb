Namespace OptionsControls
	Partial Public Class FormattingOptions
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.currentTabPanel = New Panel()
			Me.sqlTextEditor1 = New RichTextBox()
			Me.listBox1 = New ListBox()
			Me.SuspendLayout()
			' 
			' currentTabPanel
			' 
			Me.currentTabPanel.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.currentTabPanel.ImeMode = ImeMode.On
			Me.currentTabPanel.Location = New Point(220, 3)
			Me.currentTabPanel.Name = "currentTabPanel"
			Me.currentTabPanel.Size = New Size(856, 329)
			Me.currentTabPanel.TabIndex = 2
			' 
			' sqlTextEditor1
			' 
		   ' this.sqlTextEditor1.AcceptTabs = true;
			Me.sqlTextEditor1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.sqlTextEditor1.BackColor = SystemColors.HighlightText
			Me.sqlTextEditor1.Font = New Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.sqlTextEditor1.Location = New Point(220, 338)
			Me.sqlTextEditor1.Name = "sqlTextEditor1"
			Me.sqlTextEditor1.Size = New Size(856, 332)
			Me.sqlTextEditor1.TabIndex = 3
			Me.sqlTextEditor1.Text = "Select * From Orders"
'			Me.sqlTextEditor1.Validating += New System.ComponentModel.CancelEventHandler(Me.sqlTextEditor1_Validating)
			' 
			' listBox1
			' 
			Me.listBox1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left), AnchorStyles))
			Me.listBox1.DrawMode = DrawMode.OwnerDrawFixed
			Me.listBox1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.IntegralHeight = False
			Me.listBox1.ItemHeight = 15
			Me.listBox1.Items.AddRange(New Object() { "Main Query", "    Common", "    Expression", "Sub - Queries in expression", "    Common", "    Expression", "Derived Tables", "    Common", "    Expression", "Common Table Expression", "    Common", "    Expression"})
			Me.listBox1.Location = New Point(3, 3)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New Size(214, 667)
			Me.listBox1.TabIndex = 4
'			Me.listBox1.DrawItem += New System.Windows.Forms.DrawItemEventHandler(Me.listBox1_DrawItem)
'			Me.listBox1.SelectedValueChanged += New System.EventHandler(Me.listBox1_SelectedValueChanged)
			' 
			' FormattingOptions
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BorderStyle = BorderStyle.FixedSingle
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.sqlTextEditor1)
			Me.Controls.Add(Me.currentTabPanel)
			Me.Name = "FormattingOptions"
			Me.Size = New Size(1079, 676)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private currentTabPanel As Panel
		Private WithEvents sqlTextEditor1 As RichTextBox
		Private WithEvents listBox1 As ListBox
	End Class
End Namespace
