''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Namespace Forms.QueryInformationForms
    Partial Public Class QueryStatisticsForm
        Inherits Form
        Public Sub New(message As String)
            InitializeComponent()
            textBox.Text = message
        End Sub
        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
End Namespace
