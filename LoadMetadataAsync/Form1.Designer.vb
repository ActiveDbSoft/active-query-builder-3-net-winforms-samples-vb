Imports ActiveQueryBuilder.Core

Partial Class Form1
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.queryBuilder = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
		Me.msaccessSyntaxProvider = New MSAccessSyntaxProvider(Me.components)
		Me.SuspendLayout()
		' 
		' queryBuilder
		' 
		Me.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = DirectCast(resources.GetObject("resource.PrimaryKeyIcon"), System.Drawing.Image)
		Me.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill
		Me.queryBuilder.Location = New System.Drawing.Point(0, 0)
		Me.queryBuilder.MetadataStructureOptions.ProceduresFolderText = Nothing
		Me.queryBuilder.MetadataStructureOptions.SynonymsFolderText = Nothing
		Me.queryBuilder.MetadataStructureOptions.TablesFolderText = Nothing
		Me.queryBuilder.MetadataStructureOptions.ViewsFolderText = Nothing
		Me.queryBuilder.Name = "queryBuilder"
		Me.queryBuilder.Size = New System.Drawing.Size(726, 509)
		Me.queryBuilder.SyntaxProvider = Me.msaccessSyntaxProvider
		Me.queryBuilder.TabIndex = 1
		' 
		' msaccessSyntaxProvider
		' 
		Me.msaccessSyntaxProvider.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(726, 509)
		Me.Controls.Add(Me.queryBuilder)
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form1"
		Me.ResumeLayout(False)
	End Sub

	#End Region

	Private queryBuilder As ActiveQueryBuilder.View.WinForms.QueryBuilder
	Private msaccessSyntaxProvider As MSAccessSyntaxProvider

End Class

