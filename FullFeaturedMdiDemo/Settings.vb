''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Namespace My
    ' This class allows you to handle specific events on the settings class:
    '  The SettingChanging event is raised before a setting's value is changed.
    '  The PropertyChanged event is raised after a setting's value is changed.
    '  The SettingsLoaded event is raised after the setting values are loaded.
    '  The SettingsSaving event is raised before the setting values are saved.
    Friend NotInheritable Partial Class Settings
        Public Sub New()
            ' // To add event handlers for saving and changing settings, uncomment the lines below:
            '
            AddHandler Me.SettingChanging, AddressOf SettingChangingEventHandler
            '
            AddHandler Me.SettingsSaving, AddressOf SettingsSavingEventHandler
            '
        End Sub

        Private Sub SettingChangingEventHandler(sender As Object, e As System.Configuration.SettingChangingEventArgs)
            ' Add code to handle the SettingChangingEvent event here.
        End Sub

        Private Sub SettingsSavingEventHandler(sender As Object, e As System.ComponentModel.CancelEventArgs)
            ' Add code to handle the SettingsSaving event here.
        End Sub
    End Class
End Namespace
