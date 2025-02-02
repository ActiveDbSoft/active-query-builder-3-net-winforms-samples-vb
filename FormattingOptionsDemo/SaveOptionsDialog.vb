''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''


Partial Public Class SaveOptionsDialog
    Inherits Form
    Private privateOptionsName As String
    Public Property OptionsName() As String
        Get
            Return privateOptionsName
        End Get
        Private Set(value As String)
            privateOptionsName = value
        End Set
    End Property

    Private privateResult As Boolean
    Public Property Result() As Boolean
        Get
            Return privateResult
        End Get
        Private Set(value As Boolean)
            privateResult = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        If String.IsNullOrEmpty(textBox.Text) Then
            MessageBox.Show(Owner, "The name can't be empty!")
            Return
        End If

        OptionsName = textBox.Text

        Result = True

        Close()
    End Sub

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        Result = False

        Close()
    End Sub
End Class
