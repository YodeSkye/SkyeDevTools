
Public Class MainForm

    ' DECLARATIONS
    Private ReadOnly _toolRegistry As New Dictionary(Of String, Type)()
    Private _currentToolControl As UserControl

    ' FORM EVENTS
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.Title & " " & My.Application.Info.Description & " v" & My.Application.Info.Version.ToString(3)

        ' Register your available tools here
        RegisterTool("SVG Image Generator", GetType(SVGImageGeneratorTool))

        ' Populate the menu listbox
        LBTools.Items.Clear()
        For Each toolName In _toolRegistry.Keys
            LBTools.Items.Add(toolName)
        Next

        ' Select the first tool by default
        If LBTools.Items.Count > 0 Then
            LBTools.SelectedIndex = 0
        End If
    End Sub

    ' CONTROL EVENTS
    Private Sub LBTools_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBTools.SelectedIndexChanged
        If LBTools.SelectedItem Is Nothing Then Return
        Dim selectedName As String = LBTools.SelectedItem.ToString()
        Dim toolType As Type = Nothing
        If Not _toolRegistry.TryGetValue(selectedName, toolType) Then Return

        ' Teardown previous tool module
        If _currentToolControl IsNot Nothing Then
            DirectCast(_currentToolControl, IDevTool).OnToolUnloaded()
            PanelHost.Controls.Remove(_currentToolControl)
            _currentToolControl.Dispose()
            _currentToolControl = Nothing
        End If

        _currentToolControl = DirectCast(Activator.CreateInstance(toolType), UserControl)
        _currentToolControl.Dock = DockStyle.Fill

        ' Host and initialize
        PanelHost.Controls.Add(_currentToolControl)
        DirectCast(_currentToolControl, IDevTool).OnToolLoaded()

    End Sub

    ' METHODS
    Private Sub RegisterTool(name As String, toolType As Type)
        If GetType(UserControl).IsAssignableFrom(toolType) AndAlso GetType(IDevTool).IsAssignableFrom(toolType) Then
            _toolRegistry(name) = toolType
        End If
    End Sub

End Class
