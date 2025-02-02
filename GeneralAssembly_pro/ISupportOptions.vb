''*******************************************************************''
''       Active Query Builder Component Suite                        ''
''                                                                   ''
''       Copyright © 2006-2025 Active Database Software              ''
''       ALL RIGHTS RESERVED                                         ''
''                                                                   ''
''       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            ''
''       RESTRICTIONS.                                               ''
''*******************************************************************''

Imports ActiveQueryBuilder.Core

Public Interface ISupportOptions
    Property BehaviorOptions() As Object
    Property DesignPaneOptions() As Object
    Property VisualOptions() As Object
    Property AddObjectDialogOptions() As Object
    Property DataSourceOptions() As Object
    Property MetadataLoadingOptions() As MetadataLoadingOptions
    Property MetadataStructureOptions() As Object
    Property QueryColumnListOptions() As Object
    Property QueryNavBarOptions() As Object
    Property UserInterfaceOptions() As Object
    Property SqlGenerationOptions() As Object
    Property SqlFormattingOptions() As Object
End Interface
