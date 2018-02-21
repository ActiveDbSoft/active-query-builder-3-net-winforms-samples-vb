'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Windows.Forms


Public Partial Class ConnectionForm
	Inherits Form
	Public ReadOnly Property SelectedConnection() As ConnectionInfo
		Get
			If tabControl1.SelectedIndex = 0 Then
				If lvConnections.SelectedItems.Count > 0 Then
					Return DirectCast(lvConnections.SelectedItems(0).Tag, ConnectionInfo)
				End If

				Return Nothing
			Else
				If lvXmlFiles.SelectedItems.Count > 0 Then
					Return DirectCast(lvXmlFiles.SelectedItems(0).Tag, ConnectionInfo)
				End If

				Return Nothing
			End If
		End Get
	End Property

	Public Sub New()
		InitializeComponent()

		' fill connection list
		For i As Integer = 0 To Program.Connections.Count - 1
			Dim lvi As ListViewItem = lvConnections.Items.Add(Program.Connections(i).ConnectionName)
			lvi.SubItems.Add(Program.Connections(i).ConnectionType.ToString())
			lvi.Tag = Program.Connections(i)
		Next

		If lvConnections.Items.Count > 0 Then
			lvConnections.Items(0).Selected = True
		End If

		' add preset

		Dim found As Boolean = False
		Dim northwind As New ConnectionInfo(ConnectionTypes.MSSQL, "Northwind.xml", "Northwind.xml", True, Nothing, "")

		For i As Integer = 0 To Program.XmlFiles.Count - 1
			If Program.XmlFiles(i).Equals(northwind) Then
				found = True
			End If
		Next

		If Not found Then
			Program.XmlFiles.Insert(0, northwind)
		End If

		' fill XML files list
		For i As Integer = 0 To Program.XmlFiles.Count - 1
			Dim lvi As ListViewItem = lvXmlFiles.Items.Add(Program.XmlFiles(i).ConnectionName)
			lvi.SubItems.Add(Program.XmlFiles(i).ConnectionType.ToString())
			lvi.Tag = Program.XmlFiles(i)
		Next

		If lvXmlFiles.Items.Count > 0 Then
			lvXmlFiles.Items(0).Selected = True
		End If

		AddHandler Application.Idle, AddressOf Application_Idle
	End Sub

	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing Then
			RemoveHandler Application.Idle, AddressOf Application_Idle

			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub

	Private Function GetNewConnectionEntryName() As String
		Dim x As Integer = 0
		Dim found As Boolean
		Dim name As String

		Do
			x += 1
			found = False
			name = [String].Format("Connection {0}", x)

			For i As Integer = 0 To Program.Connections.Count - 1
				If Program.Connections(i).ConnectionName = name Then
					found = True
					Exit For
				End If
			Next
		Loop While found

		Return name
	End Function

	Private Function GetNewXmlFileEntryName() As String
		Dim x As Integer = 0
		Dim found As Boolean
		Dim name As String

		Do
			x += 1
			found = False
			name = [String].Format("XML File {0}", x)

			For i As Integer = 0 To Program.XmlFiles.Count - 1
				If Program.XmlFiles(i).ConnectionName = name Then
					found = True
					Exit For
				End If
			Next
		Loop While found

		Return name
	End Function

	Private Sub btnAdd_Click(sender As Object, e As EventArgs)
		Dim ci As New ConnectionInfo(ConnectionTypes.MSSQL, GetNewConnectionEntryName(), Nothing, False, Nothing, "")

		Using cef As New ConnectionEditForm(ci)
			If cef.ShowDialog() = DialogResult.OK Then
				Dim lvi As ListViewItem = lvConnections.Items.Add(ci.ConnectionName)
				lvi.SubItems.Add(ci.ConnectionType.ToString())
				lvi.Tag = ci
				lvi.Selected = True

				Program.Connections.Add(ci)
			End If
		End Using

		lvConnections.Focus()
	End Sub

	Private Sub btnRemove_Click(sender As Object, e As EventArgs)
		Dim ci As ConnectionInfo = DirectCast(lvConnections.SelectedItems(0).Tag, ConnectionInfo)

		lvConnections.Items.Remove(lvConnections.SelectedItems(0))
		Program.Connections.Remove(ci)

		lvConnections.Focus()
	End Sub

	Private Sub btnConfigure_Click(sender As Object, e As EventArgs)
		If lvConnections.SelectedItems.Count > 0 Then
			Dim ci As ConnectionInfo = DirectCast(lvConnections.SelectedItems(0).Tag, ConnectionInfo)

			Using cef As New ConnectionEditForm(ci)
				If cef.ShowDialog() = DialogResult.OK Then
					lvConnections.SelectedItems(0).SubItems(0).Text = ci.ConnectionName
					lvConnections.SelectedItems(0).SubItems(1).Text = ci.ConnectionType.ToString()
				End If
			End Using
		End If

		lvConnections.Focus()
	End Sub

	Private Sub lvConnections_SizeChanged(sender As Object, e As EventArgs)
		lvConnections.Columns(0).Width = lvConnections.Width - lvConnections.Columns(1).Width - SystemInformation.VerticalScrollBarWidth
	End Sub

	Private Sub lvXmlFiles_SizeChanged(sender As Object, e As EventArgs)
		lvXmlFiles.Columns(0).Width = lvXmlFiles.Width - lvXmlFiles.Columns(1).Width - SystemInformation.VerticalScrollBarWidth
	End Sub

	Private Sub Application_Idle(sender As Object, e As EventArgs)
		btnRemove.Enabled = (lvConnections.SelectedItems.Count > 0)
		btnConfigure.Enabled = (lvConnections.SelectedItems.Count > 0)
		btnRemoveXml.Enabled = (lvXmlFiles.SelectedItems.Count > 0)
		btnConfigureXml.Enabled = (lvXmlFiles.SelectedItems.Count > 0)

		If tabControl1.SelectedIndex = 0 Then
			btnOk.Enabled = (lvConnections.SelectedItems.Count > 0)
		Else
			btnOk.Enabled = (lvXmlFiles.SelectedItems.Count > 0)
		End If
	End Sub

	Private Sub lvConnections_MouseDoubleClick(sender As Object, e As MouseEventArgs)
		DialogResult = DialogResult.OK
		Close()
	End Sub

	Private Sub lvXmlFiles_MouseDoubleClick(sender As Object, e As MouseEventArgs)
		DialogResult = DialogResult.OK
		Close()
	End Sub

	Private Sub btnAddXml_Click(sender As Object, e As EventArgs)
		Dim ci As New ConnectionInfo(ConnectionTypes.MSSQL, GetNewXmlFileEntryName(), Nothing, True, Nothing, "")

		Using cef As New ConnectionEditForm(ci)
			If cef.ShowDialog() = DialogResult.OK Then
				Dim lvi As ListViewItem = lvXmlFiles.Items.Add(ci.ConnectionName)
				lvi.SubItems.Add(ci.ConnectionType.ToString())
				lvi.Tag = ci
				lvi.Selected = True

				Program.XmlFiles.Add(ci)
			End If
		End Using

		lvXmlFiles.Focus()
	End Sub

	Private Sub btnRemoveXml_Click(sender As Object, e As EventArgs)
		Dim ci As ConnectionInfo = DirectCast(lvXmlFiles.SelectedItems(0).Tag, ConnectionInfo)

		lvXmlFiles.Items.Remove(lvXmlFiles.SelectedItems(0))
		Program.XmlFiles.Remove(ci)

		lvXmlFiles.Focus()
	End Sub

	Private Sub btnConfigureXml_Click(sender As Object, e As EventArgs)
		If lvXmlFiles.SelectedItems.Count > 0 Then
			Dim ci As ConnectionInfo = DirectCast(lvXmlFiles.SelectedItems(0).Tag, ConnectionInfo)

			Using cef As New ConnectionEditForm(ci)
				If cef.ShowDialog() = DialogResult.OK Then
					lvXmlFiles.SelectedItems(0).SubItems(0).Text = ci.ConnectionName
					lvXmlFiles.SelectedItems(0).SubItems(1).Text = ci.ConnectionType.ToString()
				End If
			End Using
		End If

		lvXmlFiles.Focus()
	End Sub
End Class
