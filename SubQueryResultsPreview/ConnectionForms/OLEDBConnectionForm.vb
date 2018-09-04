'*******************************************************************'
'       Active Query Builder Component Suite                        '
'                                                                   '
'       Copyright © 2006-2018 Active Database Software              '
'       ALL RIGHTS RESERVED                                         '
'                                                                   '
'       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            '
'       RESTRICTIONS.                                               '
'*******************************************************************'

Imports System.Data.OleDb
Imports System.Windows.Forms

Public Partial Class OLEDBConnectionForm
	Inherits Form
	Public ConnectionString As String = ""

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub buttonConnect_Click(sender As Object, e As EventArgs)
		Dim builder As New OleDbConnectionStringBuilder()

		Try
			builder.ConnectionString = textBoxConnectionString.Text

			Me.Cursor = Cursors.WaitCursor

			Using connection As New OleDbConnection(builder.ConnectionString)
				Try
					connection.Open()
					ConnectionString = builder.ConnectionString
				Catch ex As System.Exception
					MessageBox.Show(ex.Message, "Failed to connect.")
					Me.DialogResult = DialogResult.None
				Finally
					Me.Cursor = Cursors.[Default]
				End Try
			End Using
		Catch ae As ArgumentException
			MessageBox.Show(ae.Message, "Invalid OLE DB connection string.")
			Me.DialogResult = DialogResult.None
		End Try
	End Sub
End Class
