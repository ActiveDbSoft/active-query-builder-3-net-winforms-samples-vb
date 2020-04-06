'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2019 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports ActiveQueryBuilder.View.QueryView

    Public Partial Class EditUserExpressionForm
        Inherits Form
        Implements IDisposable

        Private _editingUserExpression As UserExpressionVisualItem
        Private _predefinedConditions As IList(Of PredefinedCondition)

        Public Sub New()
            InitializeComponent()

            For Each name As DbType In [Enum].GetValues(GetType(DbType))
                CheckComboBoxDbTypes.Items.Add(name)
            Next

            AddHandler Application.Idle, AddressOf Application_Idle
        End Sub

        Private Sub Application_Idle(sender As Object, e As EventArgs)
            ButtonAddExpression.Enabled = Not String.IsNullOrEmpty(TextBoxCaption.Text) AndAlso Not String.IsNullOrEmpty(TextBoxExpression.Text)
            ButtonEditExpression.Enabled = ListBoxExpressions.SelectedItems.Count = 1
            ButtonRemoveExpression.Enabled = ListBoxExpressions.SelectedItems.Count <> 0
        End Sub

        Public Sub LoadUserExpressions(predefinedConditions As IList(Of PredefinedCondition))
            ListBoxExpressions.Items.Clear()
            _editingUserExpression = Nothing
            If Not Equals(_predefinedConditions, predefinedConditions) Then _predefinedConditions = predefinedConditions
            If _predefinedConditions Is Nothing Then Return

            For Each expression In predefinedConditions
                ListBoxExpressions.Items.Add(New UserExpressionVisualItem(expression))
            Next
        End Sub

        Private Sub ButtonEditExpression_Click(sender As Object, e As EventArgs) Handles ButtonEditExpression.Click
            If ListBoxExpressions.SelectedItems.Count <> 1 Then Return
            _editingUserExpression = TryCast(ListBoxExpressions.SelectedItem, UserExpressionVisualItem)
            If _editingUserExpression Is Nothing Then Return
            TextBoxCaption.Text = _editingUserExpression.Caption
            TextBoxExpression.Text = _editingUserExpression.Expression
            CheckBoxIsNeedEdit.Checked = _editingUserExpression.IsNeedEdit

            For Each item In _editingUserExpression.ShowOnlyForDbTypes.[Select](Function(type) CheckComboBoxDbTypes.Items.OfType(Of DbType)().First(Function(x) x = type))
                CheckComboBoxDbTypes.SetItemChecked(CheckComboBoxDbTypes.Items.OfType(Of DbType)().ToList().IndexOf(item), True)
            Next
        End Sub

        Private Sub ButtonRemoveExpression_Click(sender As Object, e As EventArgs) Handles ButtonRemoveExpression.Click
            RemoveSelectedUserExpression()
        End Sub

        Private Sub ButtonClearForm_Click(sender As Object, e As EventArgs) Handles ButtonClearForm.Click
            ResetForm()
        End Sub

        Private Sub ButtonAddExpression_Click(sender As Object, e As EventArgs) Handles ButtonAddExpression.Click
            SaveForm()
        End Sub

        Private Sub RemoveSelectedUserExpression()
            Dim itemForRemove = ListBoxExpressions.SelectedItems.OfType(Of UserExpressionVisualItem)().ToList()

            For Each item In itemForRemove
                _predefinedConditions.Remove(item.ConditionExpression)
            Next

            LoadUserExpressions(Nothing)
        End Sub

        Private Sub ResetForm()
            _editingUserExpression = Nothing
            TextBoxCaption.Text = String.Empty
            TextBoxExpression.Text = String.Empty
            CheckBoxIsNeedEdit.Checked = False
            CheckComboBoxDbTypes.ClearCheckedItems()
        End Sub

        Private Sub SaveForm()
            Try
                Dim listTypes = CheckComboBoxDbTypes.CheckedItems.OfType(Of DbType)().ToList()
                Dim userExpression = New PredefinedCondition(TextBoxCaption.Text, listTypes, TextBoxExpression.Text, CheckBoxIsNeedEdit.Checked)
                If _editingUserExpression IsNot Nothing Then _predefinedConditions.Remove(_editingUserExpression.ConditionExpression)
                _predefinedConditions.Add(userExpression)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.[GetType]().ToString(), MessageBoxButtons.OK)
            Finally
                LoadUserExpressions(_predefinedConditions)
                ResetForm()
            End Try
        End Sub
    End Class

    Friend Class UserExpressionVisualItem
        Public Property ShowOnlyForDbTypes As List(Of DbType)
        Public Property Caption As String
        Public Property Expression As String
        Public Property IsNeedEdit As Boolean
        Public Property ConditionExpression As PredefinedCondition

        Public Sub New(conditionExpression As PredefinedCondition)
            ConditionExpression = conditionExpression
            ShowOnlyForDbTypes = New List(Of DbType)()
            Caption = conditionExpression.Caption
            Expression = conditionExpression.Expression
            IsNeedEdit = conditionExpression.IsNeedEdit
            ShowOnlyForDbTypes.AddRange(conditionExpression.ShowOnlyFor)
        End Sub

        Public Overrides Function ToString() As String
            Dim types = If(ShowOnlyForDbTypes.Count = 0, "For all types", "For types: ")

            For Each dbType In ShowOnlyForDbTypes
                If ShowOnlyForDbTypes.IndexOf(dbType) <> 0 Then types += ", "
                types += dbType
            Next

            Return $"{Caption}, [{Expression}], Is need edit: {IsNeedEdit}, {types}"
        End Function
    End Class
