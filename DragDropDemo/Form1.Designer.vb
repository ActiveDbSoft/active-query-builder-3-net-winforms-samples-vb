
Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim linkPainterAccess2 As New ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess()
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.genericSyntaxProvider1 = New ActiveQueryBuilder.Core.GenericSyntaxProvider(Me.components)
        Me.textBox1 = New TextBox()
        Me.label1 = New Label()
        Me.listBox1 = New ListBox()
        Me.errorBox1 = New Common.SqlErrorBox()
        CType(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' queryBuilder1
        ' 
        Me.queryBuilder1.AddObjectDialogOptions.Location = New Point(0, 0)
        Me.queryBuilder1.AddObjectDialogOptions.Size = New Size(430, 430)
        Me.queryBuilder1.AddObjectDialogOptions.StartPosition = FormStartPosition.CenterScreen
        Me.queryBuilder1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = False
        Me.queryBuilder1.DatabaseSchemaViewOptions.ImageList = Nothing
        Me.queryBuilder1.DesignPaneOptions.Background = SystemColors.Window
        linkPainterAccess2.LinkColor = Color.Black
        linkPainterAccess2.LinkColorFocused = Color.Black
        linkPainterAccess2.MarkColor = SystemColors.Control
        linkPainterAccess2.MarkColorFocused = SystemColors.ControlDark
        linkPainterAccess2.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access
        Me.queryBuilder1.DesignPaneOptions.LinkPainterOptions = linkPainterAccess2
        Me.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess
        Me.queryBuilder1.Font = New Font("Segoe UI", 8.25F)
        Me.queryBuilder1.Location = New Point(12, 12)
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewVisible = False
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = True
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right
        Me.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = True
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = True
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left
        Me.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = True
        Me.queryBuilder1.QueryColumnListOptions.Font = Nothing
        Me.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2
        Me.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = False
        Me.queryBuilder1.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None
        Me.queryBuilder1.QueryNavBarOptions.CTEButtonBaseColor = Color.Green
        Me.queryBuilder1.QueryNavBarOptions.DisableQueryNavigationBarPopup = False
        Me.queryBuilder1.QueryNavBarOptions.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder1.QueryNavBarOptions.OverflowButtonBaseColor = Color.DarkRed
        Me.queryBuilder1.QueryNavBarOptions.RootQueryButtonBaseColor = Color.Black
        Me.queryBuilder1.QueryNavBarOptions.SubQueryButtonBaseColor = Color.Blue
        Me.queryBuilder1.Size = New Size(721, 468)
        ' 
        ' 
        ' 
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.DynamicIndents = False
        Me.queryBuilder1.SQLFormattingOptions.DynamicRightMargin = False
        Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = False
        Me.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = False
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        Me.queryBuilder1.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None
        ' 
        ' 
        ' 
        Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = True
        Me.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = True
        Me.queryBuilder1.SyntaxProvider = Me.genericSyntaxProvider1
        Me.queryBuilder1.TabIndex = 0
        Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(157))))))
        Me.queryBuilder1.VisualOptions.ActiveDockPanelCaptionFontColor = Color.Black
        Me.queryBuilder1.VisualOptions.DockTabColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.queryBuilder1.VisualOptions.DockTabFontColor = Color.White
        Me.queryBuilder1.VisualOptions.DockTabFontHoverColor = Color.White
        Me.queryBuilder1.VisualOptions.DockTabHoverColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
        Me.queryBuilder1.VisualOptions.DockTabIndicatorColor = Color.FromArgb((CInt(Fix((CByte(70))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(125))))))
        Me.queryBuilder1.VisualOptions.DockTabIndicatorHoverColor = Color.FromArgb((CInt(Fix((CByte(155))))), (CInt(Fix((CByte(167))))), (CInt(Fix((CByte(183))))))
        Me.queryBuilder1.VisualOptions.InactiveDockPanelCaptionColor = Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(96))))), (CInt(Fix((CByte(130))))))
        Me.queryBuilder1.VisualOptions.InactiveDockPanelCaptionFontColor = Color.White
        Me.queryBuilder1.VisualOptions.TabFont = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(204)))
        Me.queryBuilder1.VisualOptions.TabsStripBackColor = Color.FromArgb((CInt(Fix((CByte(41))))), (CInt(Fix((CByte(57))))), (CInt(Fix((CByte(85))))))
'			Me.queryBuilder1.SQLUpdated += New System.EventHandler(Me.queryBuilder1_SQLUpdated)
        ' 
        ' genericSyntaxProvider1
        ' 
        Me.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
        Me.genericSyntaxProvider1.OnCalcExpressionType = Nothing
        ' 
        ' textBox1
        ' 
        Me.textBox1.Anchor = (CType(((AnchorStyles.Bottom Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
        Me.textBox1.Location = New Point(12, 486)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Size(876, 130)
        Me.textBox1.TabIndex = 1
'			Me.textBox1.Validating += New System.ComponentModel.CancelEventHandler(Me.textBox1_Validating)
        ' 
        ' label1
        ' 
        Me.label1.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
        Me.label1.Font = New Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(204)))
        Me.label1.ForeColor = Color.Maroon
        Me.label1.Location = New Point(739, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(149, 60)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Drag an item from this custom list and drop it to the query builder's diagram pan" & "e"
        ' 
        ' listBox1
        ' 
        Me.listBox1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Right), AnchorStyles))
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.IntegralHeight = False
        Me.listBox1.Items.AddRange(New Object() { "Orders", "Order Details", "Products", "Customers", "Employees", "Categories"})
        Me.listBox1.Location = New Point(739, 71)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New Size(149, 409)
        Me.listBox1.TabIndex = 4
'			Me.listBox1.DoubleClick += New System.EventHandler(Me.listBox1_DoubleClick)
'			Me.listBox1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.listBox1_MouseDown)
'			Me.listBox1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.listBox1_MouseMove)
'			Me.listBox1.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.listBox1_MouseUp)
        ' 
        ' errorBox1
        ' 
        Me.errorBox1.Anchor = (CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles))
        Me.errorBox1.AutoSize = True
        Me.errorBox1.BackColor = Color.LightPink
        Me.errorBox1.BorderStyle = BorderStyle.FixedSingle
        Me.errorBox1.CurrentSyntaxProvider = Nothing
        Me.errorBox1.IsVisibleCheckSyntaxPanel = False
        Me.errorBox1.Location = New Point(555, 532)
        Me.errorBox1.Name = "errorBox1"
        Me.errorBox1.Padding = New Padding(5)
        Me.errorBox1.Size = New Size(322, 74)
        Me.errorBox1.TabIndex = 5
        Me.errorBox1.Visible = False
'			Me.errorBox1.GoToErrorPosition += New System.EventHandler(Me.ErrorBox1_GoToErrorPosition)
'			Me.errorBox1.RevertValidText += New System.EventHandler(Me.ErrorBox1_RevertValidText)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(900, 628)
        Me.Controls.Add(Me.errorBox1)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.queryBuilder1)
        Me.Name = "Form1"
        Me.Text = "Drag'n'Drop Demo"
        CType(Me.queryBuilder1.SQLFormattingOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder1.SQLGenerationOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.queryBuilder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
    Private WithEvents textBox1 As TextBox
    Private label1 As Label
    Private genericSyntaxProvider1 As ActiveQueryBuilder.Core.GenericSyntaxProvider
    Private WithEvents listBox1 As ListBox
    Private WithEvents errorBox1 As Common.SqlErrorBox
End Class