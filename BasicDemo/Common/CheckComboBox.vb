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
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Common
    Friend Class CheckComboBox
        Inherits ComboBox

        Private ReadOnly _checkedListBox As CheckedListBox = New CheckedListBox
        Private ReadOnly _popupControlHost As ToolStripControlHost
        Private ReadOnly _dropDownControl As ToolStripDropDown = New ToolStripDropDown
        Private ReadOnly _timer As Timer = New Timer
        Private _dropDownClosing As Boolean
        Private ReadOnly _checkedIndices As List(Of Integer) = New List(Of Integer)
        Private Const WM_REFLECT_WM_COMMAND As Integer = 8465
        Private Const CBN_DROPDOWN As Integer = &H7
        Private Const WM_KILLFOCUS As Integer = &H8

        <DllImport("user32.dll", CharSet:=CharSet.Auto)>
        Private Shared Sub SendMessage(hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
        End Sub
        Public ReadOnly Property CheckedItems As List(Of Object) = New List(Of Object)

        Public Overloads ReadOnly Property Items As CheckedListBox.ObjectCollection
            Get
                Return _checkedListBox.Items
            End Get
        End Property

        Public Event ItemChecked As EventHandler

        Public Overrides Property Text As String
            Get
                Return TryCast(SelectedItem, String)
            End Get
            Set
                If TryCast(SelectedItem, String) Is Value Then Return
                MyBase.Items.Clear()
                MyBase.Items.Add(Value)
                SelectedItem = Value
            End Set
        End Property

        Public Sub SetItemChecked(index As Integer, isChecked As Boolean)
            _checkedListBox.Refresh()
            _checkedListBox.SetItemChecked(index, isChecked)
        End Sub

        Public Sub ClearCheckedItems()
            _checkedListBox.ClearSelected()
        End Sub

        Public Function IsItemChecked(index As Integer) As Boolean
            Return _checkedIndices.Contains(index)
        End Function

        Public Sub New()
            DropDownStyle = ComboBoxStyle.DropDownList
            DropDownHeight = 1
            DropDownWidth = 1
            _checkedListBox.CheckOnClick = True
            _checkedListBox.BorderStyle = BorderStyle.None
            _checkedListBox.Dock = DockStyle.Fill
            AddHandler _checkedListBox.ItemCheck, AddressOf CheckedListBoxOnItemCheck
            _popupControlHost = New ToolStripControlHost(_checkedListBox)
            _dropDownControl.Items.Add(_popupControlHost)
            _dropDownControl.AutoSize = False
            AddHandler _dropDownControl.Closing, AddressOf DropDownControlOnClosing
            AddHandler _timer.Tick, AddressOf TimerOnTick
        End Sub

        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                RemoveHandler _dropDownControl.Closing, AddressOf DropDownControlOnClosing
                RemoveHandler _checkedListBox.ItemCheck, AddressOf CheckedListBoxOnItemCheck
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub CheckedListBoxOnItemCheck(sender As Object, e As ItemCheckEventArgs)
            If e.NewValue = CheckState.Checked Then
                _checkedIndices.Add(e.Index)
                CheckedItems.Add(_checkedListBox.Items(e.Index))
            Else
                _checkedIndices.Remove(e.Index)
                CheckedItems.Remove(_checkedListBox.Items(e.Index))
            End If

            RaiseEvent ItemChecked(Me, EventArgs.Empty)
        End Sub

        Private Sub TimerOnTick(sender As Object, eventArgs As EventArgs)
            _dropDownClosing = False
        End Sub

        Private Sub DropDownControlOnClosing(sender As Object, toolStripDropDownClosingEventArgs As ToolStripDropDownClosingEventArgs)
            _dropDownClosing = True
            SendMessage(Handle, WM_KILLFOCUS, 0, 0)
            _timer.Interval = 250
            _timer.Start()
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)
            If m.Msg = WM_REFLECT_WM_COMMAND Then

                If m.HWnd = Handle AndAlso m.WParam.ToInt32 >> 16 = CBN_DROPDOWN Then
                    Return
                End If
            End If

            MyBase.WndProc(m)
        End Sub

        Protected Overrides Sub OnClick(e As EventArgs)
            If _dropDownClosing Then
                _timer.[Stop]()
                _dropDownClosing = False
                Return
            End If

            ShowDropDown()
        End Sub

        Private Sub ShowDropDown()
            Dim rect As Rectangle = RectangleToScreen(ClientRectangle)
            Dim location As Point = New Point(rect.X, rect.Y + Height)
            _dropDownControl.Size = New Size(rect.Width, _checkedListBox.Items.Count * _checkedListBox.ItemHeight + Helpers.ScaleByCurrentDPI(5))
            _dropDownControl.Show(location)
            _dropDownClosing = True
            _dropDownControl.Focus()
        End Sub
    End Class
End Namespace
