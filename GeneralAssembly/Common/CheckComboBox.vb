''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2024 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports System.Runtime.InteropServices

Namespace Common
    Friend Class CheckComboBox
        Inherits ComboBox

        Private ReadOnly _checkedListBox As New CheckedListBox()
        Private ReadOnly _popupControlHost As ToolStripControlHost
        Private ReadOnly _dropDownControl As New ToolStripDropDown()
        Private ReadOnly _timer As New Timer()
        Private _dropDownClosing As Boolean
        Private ReadOnly _checkedIndices As New List(Of Integer)()

        Private Const WM_REFLECT_WM_COMMAND As Integer = 8465
        Private Const CBN_DROPDOWN As Integer = &H7
        Private Const WM_KILLFOCUS As Integer = &H8

        <DllImport("user32.dll", CharSet := CharSet.Auto)>
        Private Shared Function SendMessage(hwnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer) As Integer
        End Function

        Public ReadOnly Property CheckedItems() As New List(Of Object)()

        Public Shadows ReadOnly Property Items() As CheckedListBox.ObjectCollection
            Get
                Return _checkedListBox.Items
            End Get
        End Property

        Public Event ItemChecked As EventHandler

        Public Overrides Property Text() As String
            Get
                Dim list = New List(Of String)()
                For Each item In _checkedListBox.CheckedItems
                    list.Add(item.ToString())
                Next item
                Return String.Join(", ", list)
            End Get
            Set(value As String)
                If TryCast(SelectedItem, String) = value Then
                    Return
                End If

                MyBase.Items.Clear()
                MyBase.Items.Add(value)
                SelectedItem = value

                Invalidate()
            End Set
        End Property

        Public Sub SetItemChecked(index As Integer, isChecked As Boolean)
            _checkedListBox.Refresh()
            _checkedListBox.SetItemChecked(index, isChecked)

            Invalidate()
        End Sub

        Public Sub ClearCheckedItems()
            _checkedListBox.ClearSelected()
            For i As Integer = 0 To _checkedListBox.Items.Count - 1
                _checkedListBox.SetItemChecked(i, False)
            Next i

            Invalidate()
        End Sub

        Public Function IsItemChecked(index As Integer) As Boolean
            Return _checkedIndices.Contains(index)
        End Function

        Public Sub New()
            DropDownStyle = ComboBoxStyle.DropDown
            DropDownWidth = 1
            DropDownHeight = DropDownWidth

            _checkedListBox.CheckOnClick = True
            _checkedListBox.BorderStyle = BorderStyle.None
            _checkedListBox.Dock = DockStyle.Fill
            AddHandler _checkedListBox.ItemCheck, AddressOf CheckedListBoxOnItemCheck

            _popupControlHost = New ToolStripControlHost(_checkedListBox)
            _dropDownControl.Items.Add(_popupControlHost)
            _dropDownControl.AutoSize = False
            AddHandler _dropDownControl.Closing, AddressOf DropDownControlOnClosing

            AddHandler _timer.Tick, AddressOf TimerOnTick
            DrawMode = DrawMode.OwnerDrawFixed
        End Sub

        Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
            MyBase.OnDrawItem(e)

            e.DrawBackground()
            TextRenderer.DrawText(e.Graphics, Text, Font, e.Bounds, e.ForeColor, TextFormatFlags.TextBoxControl)
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

            ItemCheckedEvent?.Invoke(Me, EventArgs.Empty)

            Invalidate()
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
                ' prevent native dropdown opening
                If m.HWnd = Handle AndAlso m.WParam.ToInt32() >> 16 = CBN_DROPDOWN Then
                    Return
                End If
            End If
            MyBase.WndProc(m)
        End Sub

        Protected Overrides Sub OnClick(e As EventArgs)
            If _dropDownClosing Then
                _timer.Stop()
                _dropDownClosing = False
                Return
            End If

            ShowDropDown()
        End Sub

        Private Sub ShowDropDown()
            Dim rect = RectangleToScreen(ClientRectangle)
'INSTANT VB NOTE: The variable location was renamed since Visual Basic does not handle local variables named the same as class members well:
            Dim location_Renamed = New Point(rect.X, rect.Y + Height)

            _dropDownControl.Size = New Size(rect.Width, _checkedListBox.Items.Count * _checkedListBox.ItemHeight + ScreenHelpers.ScaleByCurrentDPI(5))
            _dropDownControl.Show(location_Renamed)

            _dropDownClosing = True
            _dropDownControl.Focus()
        End Sub
    End Class
End Namespace
