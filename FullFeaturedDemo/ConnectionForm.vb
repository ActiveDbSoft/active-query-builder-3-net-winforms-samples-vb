''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports GeneralAssembly.ConnectionFrames

Partial Public Class ConnectionForm
    Inherits Form
    Public ReadOnly Property SelectedConnection() As ConnectionInfo
        Get
            If tabControl1.SelectedIndex = 0 Then
                If lvConnections.SelectedItems.Count > 0 Then
                    Dim connectionInfo = CType(lvConnections.SelectedItems(0).Tag, ConnectionInfo)
                    connectionInfo.CreateConnectionDescriptor()
                    Return connectionInfo
                End If

                Return Nothing
            Else
                If lvXmlFiles.SelectedItems.Count > 0 Then
                    Dim connectionInfo = CType(lvXmlFiles.SelectedItems(0).Tag, ConnectionInfo)
                    connectionInfo.CreateConnectionDescriptor()
                    Return connectionInfo
                End If

                Return Nothing
            End If
        End Get
    End Property

    Public Sub New()
        InitializeComponent()

        ' fill connection list
        For i As Integer = 0 To Program.Connections.Count - 1
            Dim lvi As ListViewItem = lvConnections.Items.Add(Program.Connections(i).Name)
            lvi.SubItems.Add(Program.Connections(i).Type.ToString())
            lvi.Tag = Program.Connections(i)
        Next i

        If lvConnections.Items.Count > 0 Then
            lvConnections.Items(0).Selected = True
        End If

        ' add preset

        Dim found As Boolean = False
        Dim northwind As New ConnectionInfo(ConnectionTypes.MSSQL, "Northwind.xml", "Northwind.xml", True, "")

        For i As Integer = 0 To Program.XmlFiles.Count - 1
            If Program.XmlFiles(i).Equals(northwind) Then
                found = True
            End If
        Next i

        If Not found Then
            Program.XmlFiles.Insert(0, northwind)
        End If

        ' fill XML files list
        For i As Integer = 0 To Program.XmlFiles.Count - 1
            Dim lvi As ListViewItem = lvXmlFiles.Items.Add(Program.XmlFiles(i).Name)
            lvi.SubItems.Add(Program.XmlFiles(i).Type.ToString())
            lvi.Tag = Program.XmlFiles(i)
        Next i

        If lvXmlFiles.Items.Count > 0 Then
            lvXmlFiles.Items(0).Selected = True
        End If

        AddHandler Application.Idle, AddressOf Application_Idle
    End Sub

    Protected Overloads Overrides Sub Dispose(disposing As Boolean)
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
            name = String.Format("Connection {0}", x)

            For i As Integer = 0 To Program.Connections.Count - 1
                If Program.Connections(i).Name = name Then
                    found = True
                    Exit For
                End If
            Next i
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
            name = String.Format("XML File {0}", x)

            For i As Integer = 0 To Program.XmlFiles.Count - 1
                If Program.XmlFiles(i).Name = name Then
                    found = True
                    Exit For
                End If
            Next i
        Loop While found

        Return name
    End Function

    Private Sub SaveData()
        Program.Settings.Connections.SaveData()
        Program.Settings.XmlFiles.SaveData()
        Program.Settings.Save()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ci As New ConnectionInfo(ConnectionTypes.MSSQL, GetNewConnectionEntryName(), Nothing, False, "")

        Using cef As New ConnectionEditForm(ci)
            If cef.ShowDialog() = DialogResult.OK Then
                Dim lvi As ListViewItem = lvConnections.Items.Add(ci.Name)
                lvi.SubItems.Add(ci.Type.ToString())
                lvi.Tag = ci
                lvi.Selected = True

                Program.Connections.Add(ci)
            End If
        End Using

        lvConnections.Focus()

        SaveData()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim ci As ConnectionInfo = CType(lvConnections.SelectedItems(0).Tag, ConnectionInfo)

        lvConnections.Items.Remove(lvConnections.SelectedItems(0))
        Program.Connections.Remove(ci)

        lvConnections.Focus()

        SaveData()
    End Sub

    Private Sub btnConfigure_Click(sender As Object, e As EventArgs) Handles btnConfigure.Click
        If lvConnections.SelectedItems.Count > 0 Then
            Dim ci As ConnectionInfo = CType(lvConnections.SelectedItems(0).Tag, ConnectionInfo)

            Using cef As New ConnectionEditForm(ci)
                If cef.ShowDialog() = DialogResult.OK Then
                    lvConnections.SelectedItems(0).SubItems(0).Text = ci.Name
                    lvConnections.SelectedItems(0).SubItems(1).Text = ci.Type.ToString()
                End If
            End Using
        End If

        lvConnections.Focus()

        SaveData()
    End Sub

    Private Sub lvConnections_SizeChanged(sender As Object, e As EventArgs) Handles lvConnections.SizeChanged
        lvConnections.Columns(0).Width = lvConnections.Width - lvConnections.Columns(1).Width - SystemInformation.VerticalScrollBarWidth
    End Sub

    Private Sub lvXmlFiles_SizeChanged(sender As Object, e As EventArgs) Handles lvXmlFiles.SizeChanged
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

    Private Sub lvConnections_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvConnections.MouseDoubleClick
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub lvXmlFiles_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvXmlFiles.MouseDoubleClick
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btnAddXml_Click(sender As Object, e As EventArgs) Handles btnAddXml.Click
        Dim ci As New ConnectionInfo(ConnectionTypes.MSSQL, GetNewXmlFileEntryName(), Nothing, True, "")

        Using cef As New ConnectionEditForm(ci)
            If cef.ShowDialog() = DialogResult.OK Then
                Dim lvi As ListViewItem = lvXmlFiles.Items.Add(ci.Name)
                lvi.SubItems.Add(ci.Type.ToString())
                lvi.Tag = ci
                lvi.Selected = True

                Program.XmlFiles.Add(ci)
            End If
        End Using

        lvXmlFiles.Focus()

        SaveData()
    End Sub

    Private Sub btnRemoveXml_Click(sender As Object, e As EventArgs) Handles btnRemoveXml.Click
        Dim ci As ConnectionInfo = CType(lvXmlFiles.SelectedItems(0).Tag, ConnectionInfo)

        lvXmlFiles.Items.Remove(lvXmlFiles.SelectedItems(0))
        Program.XmlFiles.Remove(ci)

        lvXmlFiles.Focus()

        SaveData()
    End Sub

    Private Sub btnConfigureXml_Click(sender As Object, e As EventArgs) Handles btnConfigureXml.Click
        If lvXmlFiles.SelectedItems.Count > 0 Then
            Dim ci As ConnectionInfo = CType(lvXmlFiles.SelectedItems(0).Tag, ConnectionInfo)

            Using cef As New ConnectionEditForm(ci)
                If cef.ShowDialog() = DialogResult.OK Then
                    lvXmlFiles.SelectedItems(0).SubItems(0).Text = ci.Name
                    lvXmlFiles.SelectedItems(0).SubItems(1).Text = ci.Type.ToString()
                End If
            End Using
        End If

        lvXmlFiles.Focus()

        SaveData()
    End Sub
End Class
