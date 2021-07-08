''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2021 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.Core.Serialization


Partial Public Class FormattedOptionsDemo
    Inherits Form
    Private _tmpName As String = ""
    Private _afterSave As Boolean = False
    Private ReadOnly _namesToOptionsId As New Dictionary(Of String, Integer)()
    Private ReadOnly _savedOptions As New Dictionary(Of Integer, String)()
    Private ReadOnly _xmlSerializer As New XmlSerializer() With {.SerializeDefaultValues = True}

    Public Sub New()
        InitializeComponent()

        Dim fOptions = New SQLFormattingOptions()
        fOptions.MainQueryFormat.NewLineAfterPartKeywords = True
        formattingOptions1.SqlFormattingOptions = fOptions

        AddHandler formattingOptions1.OptionsUpdated, AddressOf FormattingOptions1_OptionsUpdated
    End Sub

    Private Sub FormattingOptions1_OptionsUpdated(sender As Object, e As EventArgs)
        Dim currentOptionsName = cmBxCurrentScheme.Text

        If currentOptionsName.Contains("(Modified)") Then
            Return
        End If

        Dim newValue = currentOptionsName & " (Modified)"

        cmBxCurrentScheme.Items.Add(newValue)
        cmBxCurrentScheme.Text = newValue
        _tmpName = newValue
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlContext1.MetadataContainer.ImportFromXML("Northwind.xml")

        _namesToOptionsId.Add("Default", 0)
        _savedOptions.Add(0, _xmlSerializer.Serialize(formattingOptions1.SqlFormattingOptions))
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Dim xml = _xmlSerializer.Serialize(formattingOptions1.SqlFormattingOptions)
        Dim currentScheme = cmBxCurrentScheme.Text
        Dim index = currentScheme.IndexOf("(Modified)", StringComparison.InvariantCultureIgnoreCase)
        If index <> -1 Then
            currentScheme = currentScheme.Substring(0, index - 1)
        End If

        Using dialog = New SaveOptionsDialog()
            dialog.ShowDialog()

            If _namesToOptionsId.ContainsKey(dialog.OptionsName) Then
                MessageBox.Show("Options with such name already exists")
                Return
            End If

            If dialog.Result Then
                _savedOptions.Add(_namesToOptionsId.Count, xml)
                currentScheme = dialog.OptionsName
                _namesToOptionsId.Add(currentScheme, _namesToOptionsId.Count)
                cmBxCurrentScheme.Items.Add(currentScheme)
                _afterSave = True
            End If
        End Using

        cmBxCurrentScheme.Items.Remove(_tmpName)
        cmBxCurrentScheme.Text = currentScheme
    End Sub

    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
        Dim currentOptionsName = cmBxCurrentScheme.Text

        If currentOptionsName = "Default" Then
            Return
        End If

        Dim optionsId As Integer
        If Not _namesToOptionsId.TryGetValue(currentOptionsName, optionsId) Then
            cmBxCurrentScheme.Items.Remove(currentOptionsName)
            cmBxCurrentScheme.SelectedItem = cmBxCurrentScheme.Items(0)
            Return
        End If

        _savedOptions.Remove(optionsId)
        _namesToOptionsId.Remove(currentOptionsName)
        cmBxCurrentScheme.Items.Remove(currentOptionsName)
        cmBxCurrentScheme.SelectedItem = cmBxCurrentScheme.Items(0)
    End Sub

    Private Sub cmBxCurrentScheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmBxCurrentScheme.SelectedIndexChanged
        Dim selectedIndex = cmBxCurrentScheme.SelectedIndex
        Dim optionsName = CStr(cmBxCurrentScheme.Items(selectedIndex))

        Dim optionsID As Integer
        If (Not _namesToOptionsId.TryGetValue(optionsName, optionsID)) OrElse _afterSave Then
            _afterSave = False
            Return
        End If

        Dim desOptions = New SQLFormattingOptions()
        _xmlSerializer.Deserialize(_savedOptions(optionsID), desOptions)

        RemoveHandler formattingOptions1.OptionsUpdated, AddressOf FormattingOptions1_OptionsUpdated
        formattingOptions1.SqlFormattingOptions = desOptions
        AddHandler formattingOptions1.OptionsUpdated, AddressOf FormattingOptions1_OptionsUpdated
        formattingOptions1.UpdateOptions()
    End Sub
End Class
