
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

    ' CLASSES
    Public Class SVGIconGeneratorTool
        Inherits UserControl
        Implements IDevTool

        Public ReadOnly Property ToolName As String Implements IDevTool.ToolName
            Get
                Return "Icon & SVG Generator"
            End Get
        End Property

        Public ReadOnly Property ToolDescription As String Implements IDevTool.ToolDescription
            Get
                Return "Renders SVG paths and GDI+ vectors into multi-size PNG/ICO files."
            End Get
        End Property

        Public Sub OnToolLoaded() Implements IDevTool.OnToolLoaded
            ' Initialize tool settings, load default SVG strings into UI, etc.
        End Sub

        Public Sub OnToolUnloaded() Implements IDevTool.OnToolUnloaded
            ' Clean up bitmap buffers or temporary files when switching away
        End Sub

        ' Place your tool UI events here (e.g., btnGenerate_Click)
    End Class

    ' METHODS

End Module
