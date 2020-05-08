'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.ComponentModel
Imports ActiveQueryBuilder.Core
Imports ActiveQueryBuilder.View.QueryView

Namespace Forms
	Partial Public Class EditUserPredefinedConditionForm
		Inherits Form

		Private _selectedPredefinedCondition As UserConditionVisualItem
		Private _queryView As IQueryView

        Public Sub New()
			InitializeComponent()

'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not handle local variables named the same as class members well:
			For Each name_Renamed As DbType In System.Enum.GetValues(GetType(DbType))
				CheckComboBoxDbTypes.Items.Add(name_Renamed)
			Next name_Renamed
		End Sub

		Public Sub LoadUserConditions(queryView As IQueryView)
			ListBoxConditions.Items.Clear()

			_selectedPredefinedCondition = Nothing

			If _queryView Is Nothing Then
				_queryView = queryView
			End If

			If _queryView Is Nothing Then
				Return
			End If

			For Each expression In _queryView.UserPredefinedConditions
				ListBoxConditions.Items.Add(New UserConditionVisualItem(expression))
			Next expression
		End Sub

		Private Sub RemoveSelectedUserExpression()
			Dim itemForRemove = ListBoxConditions.SelectedItems.OfType(Of UserConditionVisualItem)().ToList()


			For Each item In itemForRemove
				_queryView.UserPredefinedConditions.Remove(item.PredefinedCondition)
			Next item

			LoadUserConditions(Nothing)

			ResetForm()
		End Sub

		Private Sub ResetForm()
			_selectedPredefinedCondition = Nothing
			TextBoxCaption.Text = String.Empty
			TextBoxExpression.Text = String.Empty
			CheckBoxIsNeedEdit.Checked = False
			CheckComboBoxDbTypes.ClearCheckedItems()
		End Sub
        
        Private Function SaveForm() As Boolean
			Try
                Dim token as Token = Nothing
				Dim result = _queryView.Query.SQLContext.ParseLogicalExpression(TextBoxExpression.Text, False, False, token)
				If result Is Nothing AndAlso token IsNot Nothing Then
					Throw New SQLParsingException(String.Format(Helpers.Localizer.GetString(NameOf(LocalizableConstantsUI.strInvalidCondition), LocalizableConstantsUI.strInvalidCondition), TextBoxExpression.Text), token)
				End If
			Catch exception As Exception
				MessageBox.Show(exception.Message, "Invalid SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)

				TextBoxExpression.Focus()
				Return False
			End Try

			Dim listTypes = CheckComboBoxDbTypes.CheckedItems.OfType(Of DbType)().ToList()

			Dim userExpression = New PredefinedCondition(TextBoxCaption.Text, listTypes, TextBoxExpression.Text, CheckBoxIsNeedEdit.Checked)

			Dim index = -1
			If _selectedPredefinedCondition IsNot Nothing Then
				index = _queryView.UserPredefinedConditions.IndexOf(_selectedPredefinedCondition.PredefinedCondition)
				_queryView.UserPredefinedConditions.Remove(_selectedPredefinedCondition.PredefinedCondition)
			End If

			If _queryView.UserPredefinedConditions.Any(Function(x) String.Compare(x.Caption, TextBoxCaption.Text, StringComparison.InvariantCultureIgnoreCase) = 0) Then
				MessageBox.Show($"Condition with caption ""{TextBoxCaption.Text}"" already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

				TextBoxCaption.Focus()

				Return False
			End If

			Try
				If index <> -1 Then
					_queryView.UserPredefinedConditions.Insert(index, userExpression)
				Else
					_queryView.UserPredefinedConditions.Add(userExpression)
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return False
			End Try

			LoadUserConditions(Nothing)

			ResetForm()

			If index >= 0 Then
				ListBoxConditions.SelectedIndex = index
			End If
            Return True
		End Function

		Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
			SaveForm()
		End Sub

		Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click
			ResetForm()
			ListBoxConditions.SelectedItem = Nothing
			TextBoxCaption.Focus()
		End Sub

		Private Sub buttonCopy_Click(sender As Object, e As EventArgs) Handles buttonCopy.Click
			_selectedPredefinedCondition = TryCast(ListBoxConditions.SelectedItem, UserConditionVisualItem)

			If _selectedPredefinedCondition Is Nothing Then
				Return
			End If

			Dim name_Renamed = _selectedPredefinedCondition.Caption

			Dim newName = ""

			If ListBoxConditions.Items.OfType(Of UserConditionVisualItem)().All(Function(x) String.Compare(x.Caption, $"{name_Renamed} Copy", StringComparison.InvariantCultureIgnoreCase) <> 0) Then
				newName = $"{name_Renamed} Copy"
			Else
				For i = 1 To 999
					If ListBoxConditions.Items.OfType(Of UserConditionVisualItem)().Any(Function(x) String.Compare(x.Caption, $"{name_Renamed} Copy ({i})", StringComparison.InvariantCultureIgnoreCase) = 0) Then
						Continue For
					End If

					newName = $"{name_Renamed} Copy ({i})"
					Exit For
				Next i
			End If

			Dim newCopy = _selectedPredefinedCondition.Copy(newName)
			Dim index = ListBoxConditions.Items.IndexOf(_selectedPredefinedCondition)

			_queryView.UserPredefinedConditions.Insert(index + 1, newCopy.PredefinedCondition)

			LoadUserConditions(Nothing)
			ListBoxConditions.SelectedIndex = index + 1
		End Sub

		Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
			RemoveSelectedUserExpression()
		End Sub

		Private Sub buttonMoveUp_Click(sender As Object, e As EventArgs) Handles buttonMoveUp.Click
			Dim selectedItem = TryCast(ListBoxConditions.SelectedItem, UserConditionVisualItem)

			If selectedItem Is Nothing Then
				Return
			End If

			Dim index = ListBoxConditions.SelectedIndex

			If index - 1 < 0 Then
				Return
			End If

			Helpers.IListMove(_queryView.UserPredefinedConditions, index, index - 1)

			LoadUserConditions(Nothing)

			ListBoxConditions.SelectedIndex = index - 1
		End Sub

		Private Sub buttonMoveDown_Click(sender As Object, e As EventArgs) Handles buttonMoveDown.Click
			Dim selectedItem = TryCast(ListBoxConditions.SelectedItem, UserConditionVisualItem)

			If selectedItem Is Nothing Then
				Return
			End If

			Dim index = ListBoxConditions.SelectedIndex

			If index + 1 >= ListBoxConditions.Items.Count Then
				Return
			End If

			Helpers.IListMove(_queryView.UserPredefinedConditions, index, index + 1)

			LoadUserConditions(Nothing)

			ListBoxConditions.SelectedIndex = index + 1
		End Sub

		Private Sub TextBoxCaption_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCaption.TextChanged
			CheckChangingItem()
		End Sub

		Private Sub TextBoxExpression_TextChanged(sender As Object, e As EventArgs) Handles TextBoxExpression.TextChanged
			CheckChangingItem()
		End Sub

		Private Sub CheckBoxIsNeedEdit_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxIsNeedEdit.CheckedChanged
			CheckChangingItem()
		End Sub


		Private Sub CheckChangingItem()
			If _selectedPredefinedCondition Is Nothing Then
				buttonSave.Enabled = Not String.IsNullOrEmpty(TextBoxCaption.Text) AndAlso Not String.IsNullOrEmpty(TextBoxExpression.Text)

				Return
			End If

			Dim dbTypes = CheckComboBoxDbTypes.CheckedItems.OfType(Of DbType)().ToList()

			Dim changed = String.Compare(TextBoxCaption.Text, _selectedPredefinedCondition.Caption, StringComparison.InvariantCulture) <> 0 OrElse String.Compare(TextBoxExpression.Text, _selectedPredefinedCondition.Condition, StringComparison.InvariantCulture) <> 0 OrElse CheckBoxIsNeedEdit.Checked <> _selectedPredefinedCondition.IsNeedEdit OrElse Not ((_selectedPredefinedCondition.ShowOnlyForDbTypes.Count = dbTypes.Count) AndAlso Not _selectedPredefinedCondition.ShowOnlyForDbTypes.Except(dbTypes).Any())

			buttonSave.Enabled = changed
		End Sub

		Private Sub ListBoxExpressions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxConditions.SelectedIndexChanged
			UpdateForm()
		End Sub

		Private Sub CheckComboBoxDbTypes_ItemChecked(sender As Object, e As EventArgs) Handles CheckComboBoxDbTypes.ItemChecked
			CheckChangingItem()
		End Sub

		Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
			Close()
		End Sub

        Protected Overrides Sub OnClosing(e As CancelEventArgs)
            If buttonSave.Enabled Then
                Dim result As DialogResult = MessageBox.Show("Save changes to the current condition?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If Equals(result, DialogResult.Yes) AndAlso Not SaveForm() Then
                    e.Cancel = True
                End If
            End If

            MyBase.OnClosing(e)
        End Sub

        Private Sub buttonSave_EnabledChanged(sender As Object, e As EventArgs) Handles buttonSave.EnabledChanged
            tableLayoutPanel1.BackColor = If(buttonSave.Enabled, SystemColors.Info, SystemColors.Control)
            LabelInformationSave.Visible = buttonSave.Enabled
            ButtonRevert.Enabled = buttonSave.Enabled
        End Sub

        Private Sub ButtonRevert_Click(sender As Object, e As EventArgs) Handles ButtonRevert.Click
            ResetForm()
            UpdateForm()
        End Sub

        Private Sub UpdateForm()
            Dim enable = TypeOf ListBoxConditions.SelectedItem Is UserConditionVisualItem

            buttonCopy.Enabled = enable
            buttonDelete.Enabled = enable
            buttonMoveUp.Enabled = enable
            buttonMoveDown.Enabled = enable

            For i = 0 To CheckComboBoxDbTypes.Items.Count - 1
                CheckComboBoxDbTypes.SetItemChecked(i, False)
            Next i

            If Not enable Then
                Return
            End If

            _selectedPredefinedCondition = DirectCast(ListBoxConditions.SelectedItem, UserConditionVisualItem)

            If _selectedPredefinedCondition Is Nothing Then
                Return
            End If

            TextBoxCaption.Text = _selectedPredefinedCondition.Caption
            TextBoxExpression.Text = _selectedPredefinedCondition.Condition
            CheckBoxIsNeedEdit.Checked = _selectedPredefinedCondition.IsNeedEdit

            For Each item In _selectedPredefinedCondition.ShowOnlyForDbTypes.Select(Function(type) CheckComboBoxDbTypes.Items.OfType(Of DbType)().First(Function(x) x = type))
                CheckComboBoxDbTypes.SetItemChecked(CheckComboBoxDbTypes.Items.OfType(Of DbType)().ToList().IndexOf(item), True)
            Next item

            buttonSave.Enabled = False
        End Sub
	End Class

	Friend Class UserConditionVisualItem
		Public ReadOnly Property ShowOnlyForDbTypes() As List(Of DbType)

		Public ReadOnly Property Caption() As String
		Public ReadOnly Property Condition() As String
		Public ReadOnly Property IsNeedEdit() As Boolean

		Public ReadOnly Property PredefinedCondition() As PredefinedCondition

		Public Sub New(predefinedCondition As PredefinedCondition)
			Me.PredefinedCondition = predefinedCondition
			ShowOnlyForDbTypes = New List(Of DbType)()

			Caption = predefinedCondition.Caption
			Condition = predefinedCondition.Expression
			IsNeedEdit = predefinedCondition.IsNeedEdit

			ShowOnlyForDbTypes.AddRange(predefinedCondition.ShowOnlyFor)
		End Sub

		Public Overrides Function ToString() As String
			Return $"{Caption}"
		End Function

		Public Function Copy(newName As String) As UserConditionVisualItem
			Return New UserConditionVisualItem(New PredefinedCondition(newName, PredefinedCondition.ShowOnlyFor, PredefinedCondition.Expression, PredefinedCondition.IsNeedEdit))
		End Function
	End Class
End Namespace
