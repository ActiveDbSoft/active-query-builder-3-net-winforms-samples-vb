''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2024 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''


Partial Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub cbRightPane_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbRightPane.CheckedChanged
        queryBuilder.PanesConfigurationOptions.DatabaseSchemaViewVisible = cbRightPane.Checked
    End Sub

    Private Sub cbDesignPane_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDesignPane.CheckedChanged
        queryBuilder.PanesConfigurationOptions.DesignPaneVisible = cbDesignPane.Checked

        ' Design Pane and Query Columns Pane can't be invisible both
        If (Not cbDesignPane.Checked) AndAlso (Not cbQueryColumnsPane.Checked) Then
            cbQueryColumnsPane.Checked = True
        End If
    End Sub

    Private Sub cbQueryColumnsPane_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbQueryColumnsPane.CheckedChanged
        queryBuilder.PanesConfigurationOptions.QueryColumnsPaneVisible = cbQueryColumnsPane.Checked

        ' Design Pane and Query Columns Pane can't be invisible both
        If (Not cbDesignPane.Checked) AndAlso (Not cbQueryColumnsPane.Checked) Then
            cbDesignPane.Checked = True
        End If
    End Sub
End Class
