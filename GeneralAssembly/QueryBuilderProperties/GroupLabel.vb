''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2022 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Namespace QueryBuilderProperties
    Friend Class GroupLabel
        Inherits Label
        Public Sub New()
            Me.AutoSize = False
            Me.TextAlign = ContentAlignment.MiddleLeft
            Me.ForeColor = Color.CornflowerBlue
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            Dim textSize As Size = TextRenderer.MeasureText(Me.Text, Me.Font)

            Dim p1 As New Point(Me.ClientRectangle.Left + Me.Padding.Left + textSize.Width + 5, Me.ClientRectangle.Height\2 + 1)
            Dim p2 As New Point(Me.ClientRectangle.Right - 2, Me.ClientRectangle.Height\2 + 1)

            e.Graphics.DrawLine(SystemPens.ControlDark, p1, p2)
        End Sub
    End Class
End Namespace
