
Partial Public Class CustomTextWithButtonColumnDemoFrame
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

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomTextWithButtonColumnDemoFrame))
        Me.queryBuilder1 = New ActiveQueryBuilder.View.WinForms.QueryBuilder()
        Me.SuspendLayout()
        ' 
        ' queryBuilder1
        ' 
        Me.queryBuilder1.Dock = DockStyle.Fill
        Me.queryBuilder1.Location = New Point(0, 0)
        Me.queryBuilder1.Name = "queryBuilder1"
        Me.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 230
        Me.queryBuilder1.Size = New Size(640, 340)
        Me.queryBuilder1.TabIndex = 2
'            Me.queryBuilder1.QueryElementControlCreated += New ActiveQueryBuilder.View.QueryView.QueryElementControlCreatedEventHandler(Me.queryBuilder1_QueryElementControlCreated)
'            Me.queryBuilder1.QueryElementControlDestroying += New ActiveQueryBuilder.View.QueryView.QueryElementControlDestroyingEventHandler(Me.queryBuilder1_QueryElementControlDestroying)
        ' 
        ' CustomTextWithButtonColumnDemoFrame
        ' 
        Me.AutoScaleDimensions = New SizeF(6F, 13F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.Controls.Add(Me.queryBuilder1)
        Me.Name = "CustomTextWithButtonColumnDemoFrame"
        Me.Size = New Size(640, 340)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents queryBuilder1 As ActiveQueryBuilder.View.WinForms.QueryBuilder
End Class
