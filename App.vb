
Module App

    ' DECLARATIONS
    Public Interface IDevTool
        ' Display metadata
        ReadOnly Property ToolName As String
        ReadOnly Property ToolDescription As String

        ' Lifecycle hooks
        Sub OnToolLoaded()
        Sub OnToolUnloaded()
    End Interface

    ' METHODS

End Module
