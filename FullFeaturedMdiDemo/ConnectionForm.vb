''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2023 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''


Imports ActiveQueryBuilder.Core

Partial Public Class ConnectionForm
    Inherits Form
    Public ReadOnly Property SelectedConnection() As ConnectionInfo
        Get
            If tabControl1.SelectedIndex = 0 Then
                If lvConnections.SelectedItems.Count > 0 Then
                    Return CType(lvConnections.SelectedItems(0).Tag, ConnectionInfo)
                End If

                Return Nothing
            Else
                If lvXmlFiles.SelectedItems.Count > 0 Then
                    Return CType(lvXmlFiles.SelectedItems(0).Tag, ConnectionInfo)
                End If

                Return Nothing
            End If
        End Get
    End Property

    Public Sub New()
        InitializeComponent()
        AddPresets()

        ' fill connection list
        For i As Integer = 0 To Program.Connections.Count - 1
            Dim lvi As ListViewItem = lvConnections.Items.Add(Program.Connections(i).Name)
            lvi.SubItems.Add(Program.Connections(i).ConnectionDescriptor.GetDescription())
            lvi.Tag = Program.Connections(i)
        Next i

        If lvConnections.Items.Count > 0 Then
            lvConnections.Items(0).Selected = True
        End If

        ' fill XML files list
        For i As Integer = 0 To Program.XmlFiles.Count - 1
            Dim lvi As ListViewItem = lvXmlFiles.Items.Add(Program.XmlFiles(i).Name)
            lvi.SubItems.Add(Program.XmlFiles(i).ConnectionDescriptor.SyntaxProvider.Description)
            lvi.Tag = Program.XmlFiles(i)
        Next i

        If lvXmlFiles.Items.Count > 0 Then
            lvXmlFiles.Items(0).Selected = True
        End If

        AddHandler Application.Idle, AddressOf Application_Idle
    End Sub

    Private Sub AddPresets()
        Dim presets = New List(Of ConnectionInfo) From {
                New ConnectionInfo("Northwind.xml", "Northwind.xml", ConnectionTypes.ODBC) With 
                {.IsXmlFile = True}, New ConnectionInfo(New SQLiteConnectionDescriptor(), "SQLite", ConnectionTypes.SQLite, "data source=northwind.sqlite"), New ConnectionInfo(New MSAccessConnectionDescriptor(), "MS Access", ConnectionTypes.MSAccess, "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Nwind.mdb")}

        For Each preset In presets
            If Not FindConnectionInfo(preset) Then
                If preset.IsXmlFile Then
                    Program.XmlFiles.Add(preset)
                Else
                    Program.Connections.Add(preset)
                End If
            End If
        Next preset
    End Sub

    Private Function FindConnectionInfo(connectionInfo As ConnectionInfo) As Boolean
        Dim connectionList As ConnectionList
        If connectionInfo.IsXmlFile Then
            connectionList = Program.XmlFiles
        Else
            connectionList = Program.Connections
        End If

        For i As Integer = 0 To connectionList.Count - 1
            If connectionList(i).Equals(connectionInfo) Then
                Return True
            End If
        Next i

        Return False
    End Function

    Protected Overrides Overloads Sub Dispose(disposing As Boolean)
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ci As New ConnectionInfo(New MSSQLConnectionDescriptor(), GetNewConnectionEntryName(), ConnectionTypes.MSSQL, "")

        Using cef As New EditConnectionForm(ci)
            If cef.ShowDialog() = DialogResult.OK Then
                Dim lvi As ListViewItem = lvConnections.Items.Add(ci.Name)
                lvi.SubItems.Add(ci.ConnectionDescriptor.GetDescription())
                lvi.Tag = ci
                lvi.Selected = True

                Program.Connections.Add(ci)
            End If
        End Using

        lvConnections.Focus()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim ci As ConnectionInfo = CType(lvConnections.SelectedItems(0).Tag, ConnectionInfo)

        lvConnections.Items.Remove(lvConnections.SelectedItems(0))
        Program.Connections.Remove(ci)

        lvConnections.Focus()
    End Sub

    Private Sub btnConfigure_Click(sender As Object, e As EventArgs) Handles btnConfigure.Click
        If lvConnections.SelectedItems.Count > 0 Then
            Dim ci As ConnectionInfo = CType(lvConnections.SelectedItems(0).Tag, ConnectionInfo)

            Using cef As New EditConnectionForm(ci)
                If cef.ShowDialog() = DialogResult.OK Then
                    lvConnections.SelectedItems(0).SubItems(0).Text = ci.Name
                    lvConnections.SelectedItems(0).SubItems(1).Text = ci.ConnectionDescriptor.GetDescription()
                End If
            End Using
        End If

        lvConnections.Focus()
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
        Dim name = GetNewXmlFileEntryName()
        Dim ci As New ConnectionInfo(String.Empty, name, ConnectionTypes.ODBC) With {.IsXmlFile = True}

        Using cef As New EditXMLConnectionForm(ci)
            If cef.ShowDialog() = DialogResult.OK Then
                Dim lvi As ListViewItem = lvXmlFiles.Items.Add(ci.Name)
                lvi.SubItems.Add(ci.ConnectionDescriptor.SyntaxProvider.Description)
                lvi.Tag = ci
                lvi.Selected = True

                Program.XmlFiles.Add(ci)
            End If
        End Using

        lvXmlFiles.Focus()
    End Sub

    Private Sub btnRemoveXml_Click(sender As Object, e As EventArgs) Handles btnRemoveXml.Click
        Dim ci As ConnectionInfo = CType(lvXmlFiles.SelectedItems(0).Tag, ConnectionInfo)

        lvXmlFiles.Items.Remove(lvXmlFiles.SelectedItems(0))
        Program.XmlFiles.Remove(ci)

        lvXmlFiles.Focus()
    End Sub

    Private Sub btnConfigureXml_Click(sender As Object, e As EventArgs) Handles btnConfigureXml.Click
        If lvXmlFiles.SelectedItems.Count > 0 Then
            Dim ci As ConnectionInfo = CType(lvXmlFiles.SelectedItems(0).Tag, ConnectionInfo)

            Using cef As New EditXMLConnectionForm(ci)
                If cef.ShowDialog() = DialogResult.OK Then
                    lvConnections.SelectedItems(0).SubItems(0).Text = ci.Name
                    lvConnections.SelectedItems(0).SubItems(1).Text = ci.ConnectionDescriptor.GetDescription()
                End If
            End Using
        End If

        lvXmlFiles.Focus()
    End Sub
End Class
