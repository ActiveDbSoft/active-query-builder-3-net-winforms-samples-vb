
Imports OptionsControls

Partial Public Class FormattedOptionsDemo
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim metadataStructure2 As New ActiveQueryBuilder.Core.MetadataStructure()
        Dim metadataFilter2 As New ActiveQueryBuilder.Core.MetadataFilter()
        Dim metadataStructureOptions2 As New ActiveQueryBuilder.Core.MetadataStructureOptions()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(FormattedOptionsDemo))
        Me.sqlContext1 = New ActiveQueryBuilder.Core.SQLContext(Me.components)
        Me.mssqlSyntaxProvider1 = New ActiveQueryBuilder.Core.MSSQLSyntaxProvider(Me.components)
        Me.buttonSave = New Button()
        Me.cmBxCurrentScheme = New ComboBox()
        Me.buttonDelete = New Button()
        Me.label1 = New Label()
        Me.formattingOptions1 = New FormattingOptions()
        Me.SuspendLayout()
        ' 
        ' sqlContext1
        ' 
        Me.sqlContext1.MetadataProvider = Nothing
        ' 
        ' 
        ' 
        Me.sqlContext1.SQLGenerationOptionsForServer.ExpandVirtualFields = True
        Me.sqlContext1.SQLGenerationOptionsForServer.ExpandVirtualObjects = True
        Me.sqlContext1.SQLGenerationOptionsForServer.UseAltNames = False
        Me.sqlContext1.SyntaxProvider = Me.mssqlSyntaxProvider1
        metadataStructure2.AllowChildAutoItems = True
        metadataStructure2.Caption = Nothing
        metadataStructure2.ImageIndex = -1
        metadataStructure2.IsDynamic = False
        metadataFilter2.OwnObjects = True
        metadataStructure2.MetadataFilter = metadataFilter2
        metadataStructure2.MetadataName = Nothing
        metadataStructureOptions2.ProceduresFolderText = "Procedures"
        metadataStructureOptions2.SynonymsFolderText = "Synonyms"
        metadataStructureOptions2.TablesFolderText = "Tables"
        metadataStructureOptions2.ViewsFolderText = "Views"
        metadataStructure2.Options = metadataStructureOptions2
        metadataStructure2.XML = resources.GetString("metadataStructure2.XML")
        Me.sqlContext1.UserQueriesStructure = metadataStructure2
        ' 
        ' buttonSave
        ' 
        Me.buttonSave.Location = New Point(912, 6)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New Size(127, 23)
        Me.buttonSave.TabIndex = 1
        Me.buttonSave.Text = "Save options"
        Me.buttonSave.UseVisualStyleBackColor = True
'            Me.buttonSave.Click += New System.EventHandler(Me.buttonSave_Click)
        ' 
        ' cmBxCurrentScheme
        ' 
        Me.cmBxCurrentScheme.FormattingEnabled = True
        Me.cmBxCurrentScheme.Items.AddRange(New Object() { "Default"})
        Me.cmBxCurrentScheme.Location = New Point(726, 6)
        Me.cmBxCurrentScheme.Name = "cmBxCurrentScheme"
        Me.cmBxCurrentScheme.Size = New Size(180, 21)
        Me.cmBxCurrentScheme.TabIndex = 3
        Me.cmBxCurrentScheme.Text = "Default"
'            Me.cmBxCurrentScheme.SelectedIndexChanged += New System.EventHandler(Me.cmBxCurrentScheme_SelectedIndexChanged)
        ' 
        ' buttonDelete
        ' 
        Me.buttonDelete.Location = New Point(1045, 6)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New Size(127, 23)
        Me.buttonDelete.TabIndex = 5
        Me.buttonDelete.Text = "Delete"
        Me.buttonDelete.UseVisualStyleBackColor = True
'            Me.buttonDelete.Click += New System.EventHandler(Me.buttonDelete_Click)
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New Point(671, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New Size(49, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Scheme:"
        ' 
        ' formattingOptions1
        ' 
        Me.formattingOptions1.BorderStyle = BorderStyle.FixedSingle
        Me.formattingOptions1.Location = New Point(12, 35)
        Me.formattingOptions1.Name = "formattingOptions1"
        Me.formattingOptions1.Size = New Size(1079, 676)
        Me.formattingOptions1.SqlContext = Me.sqlContext1
        Me.formattingOptions1.TabIndex = 7
        ' 
        ' FormattedOptionsDemo
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1175, 746)
        Me.Controls.Add(Me.formattingOptions1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.cmBxCurrentScheme)
        Me.Controls.Add(Me.buttonSave)
        Me.Name = "FormattedOptionsDemo"
        Me.Text = "FormattedOptions"
'            Me.Load += New System.EventHandler(Me.Form1_Load)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private sqlContext1 As ActiveQueryBuilder.Core.SQLContext
    Private mssqlSyntaxProvider1 As ActiveQueryBuilder.Core.MSSQLSyntaxProvider
    Private WithEvents buttonSave As Button
    Private WithEvents cmBxCurrentScheme As ComboBox
    Private WithEvents buttonDelete As Button
    Private label1 As Label
    Private formattingOptions1 As FormattingOptions
End Class
