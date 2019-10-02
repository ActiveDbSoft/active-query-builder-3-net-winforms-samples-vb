'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.PropertiesEditors
Imports ActiveQueryBuilder.View
Imports ActiveQueryBuilder.View.PropertiesEditors
Imports Helpers = ActiveQueryBuilder.Core.Helpers

Public Partial Class EditXMLConnectionForm
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
		For Each syntax As Type In Helpers.SyntaxProviderList
			Dim instance As BaseSyntaxProvider = TryCast(Activator.CreateInstance(syntax), BaseSyntaxProvider)
			cbSyntax.Items.Add(instance.Description)
		Next
	End Sub

	Private Sub tbXmlPath_TextChanged(sender As Object, e As EventArgs)
		_connection.XMLPath = tbXmlPath.Text
	End Sub

	Private Sub btnOpenDialog_Click(sender As Object, e As EventArgs)
		If openDialog.ShowDialog() = DialogResult.OK Then
			tbXmlPath.Text = openDialog.FileName
		End If
	End Sub

	Private Sub cbSyntax_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim syntaxType As Type = GetSelectedSyntaxType()
		If _connection.ConnectionDescriptor.SyntaxProvider.[GetType]() Is syntaxType Then
			Return
		End If

		_connection.ConnectionDescriptor.SyntaxProvider = CreateSyntaxProvider(syntaxType)
		_connection.SyntaxProviderName = syntaxType.ToString()
		RecreateSyntaxFrame()
	End Sub

	Private Function GetSelectedSyntaxType() As Type
		Return Helpers.SyntaxProviderList(cbSyntax.SelectedIndex)
	End Function

	Private Function CreateSyntaxProvider(type As Type) As BaseSyntaxProvider
		Return TryCast(Activator.CreateInstance(type), BaseSyntaxProvider)
	End Function

	Private Sub RecreateSyntaxFrame()
		RemoveSyntaxFrame()
		Dim syntaxProps As ObjectProperties = _connection.ConnectionDescriptor.SyntaxProperties
		If syntaxProps Is Nothing Then
			pbSyntax.Height = 0
			Return
		End If

		ClearProperties(syntaxProps)
		Dim container As IPropertiesContainer = PropertiesFactory.GetPropertiesContainer(syntaxProps)
		TryCast(pbSyntax, IPropertiesControl).SetProperties(container)

		pbSyntax.Height = pbSyntax.Controls(0).Bottom + 5
	End Sub

	Private Sub ClearProperties(properties As ObjectProperties)
		properties.GroupProperties.Clear()
		properties.PropertiesEditors.Clear()
	End Sub

	Private Sub RemoveSyntaxFrame()
		pbSyntax.Controls.Clear()
	End Sub
End Class
