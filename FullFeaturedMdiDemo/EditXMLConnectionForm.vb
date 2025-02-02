''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.PropertiesEditors
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.PropertiesEditors

Partial Public Class EditXMLConnectionForm
    Inherits Form
    Private ReadOnly _connection As ConnectionInfo

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(connection As ConnectionInfo)
        Me.New()
        _connection = connection

        FillSyntaxTypes()

        tbConnectionName.Text = _connection.Name
        tbXmlPath.Text = _connection.XMLPath
        cbSyntax.SelectedItem = _connection.ConnectionDescriptor.SyntaxProvider.Description

        RecreateSyntaxFrame()
    End Sub

    Private Sub FillSyntaxTypes()
        For Each syntax As Type In ActiveQueryBuilder.Core.Helpers.SyntaxProviderList
            Dim instance = TryCast(Activator.CreateInstance(syntax), BaseSyntaxProvider)
            cbSyntax.Items.Add(instance.Description)
        Next syntax
    End Sub

    Private Sub tbXmlPath_TextChanged(sender As Object, e As EventArgs) Handles tbXmlPath.TextChanged
        _connection.XMLPath = tbXmlPath.Text
    End Sub

    Private Sub btnOpenDialog_Click(sender As Object, e As EventArgs) Handles btnOpenDialog.Click
        If openDialog.ShowDialog() = DialogResult.OK Then
            tbXmlPath.Text = openDialog.FileName
        End If
    End Sub

    Private Sub cbSyntax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSyntax.SelectedIndexChanged
        Dim syntaxType = GetSelectedSyntaxType()
        If _connection.ConnectionDescriptor.SyntaxProvider.GetType() Is syntaxType Then
            Return
        End If

        _connection.ConnectionDescriptor.SyntaxProvider = CreateSyntaxProvider(syntaxType)
        _connection.SyntaxProviderName = syntaxType.ToString()
        RecreateSyntaxFrame()
    End Sub

    Private Function GetSelectedSyntaxType() As Type
        Return ActiveQueryBuilder.Core.Helpers.SyntaxProviderList(cbSyntax.SelectedIndex)
    End Function

    Private Function CreateSyntaxProvider(type As Type) As BaseSyntaxProvider
        Return TryCast(Activator.CreateInstance(type), BaseSyntaxProvider)
    End Function

    Private Sub RecreateSyntaxFrame()
        RemoveSyntaxFrame()
        Dim syntxProps = _connection.ConnectionDescriptor.SyntaxProperties
        If syntxProps Is Nothing Then
            pbSyntax.Height = 0
            Return
        End If

        ClearProperties(syntxProps)
        Dim container = PropertiesFactory.GetPropertiesContainer(syntxProps)
        TryCast(pbSyntax, IPropertiesControl).SetProperties(container)

        pbSyntax.Height = pbSyntax.Controls(0).Bottom + 5
        Height = pnlTop.Height + pbSyntax.Height + pnlFilePath.Height + 90
    End Sub

    Private Sub ClearProperties(properties As ObjectProperties)
        properties.GroupProperties.Clear()
        properties.PropertiesEditors.Clear()
    End Sub

    Private Sub RemoveSyntaxFrame()
        pbSyntax.Controls.Clear()
    End Sub
End Class
