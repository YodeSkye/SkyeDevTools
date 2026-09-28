
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms
Imports Svg

Public Class SVGImageGeneratorTool
    Inherits UserControl
    Implements IDevTool

    ' DECLARATIONS
    Private Const DefaultSVG As String =
    "<svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 32 32"">" & vbCrLf &
    "  <path d=""M 14,2 L 18,2 L 19,5 A 11,11 0 0,1 22,6 L 25,4 L 28,7 L 26,10 A 11,11 0 0,1 27,13 L 30,14 L 30,18 L 27,19 A 11,11 0 0,1 26,22 L 28,25 L 25,28 L 22,26 A 11,11 0 0,1 19,27 L 18,30 L 14,30 L 13,27 A 11,11 0 0,1 10,26 L 7,28 L 4,25 L 6,22 A 11,11 0 0,1 5,19 L 2,18 L 2,14 L 5,13 A 11,11 0 0,1 6,10 L 4,7 L 7,4 L 10,6 A 11,11 0 0,1 13,5 Z"" fill=""#343a40"" />" & vbCrLf &
    "  <circle cx=""16"" cy=""16"" r=""9"" fill=""#0d6efd"" />" & vbCrLf &
    "  <circle cx=""16"" cy=""16"" r=""6"" fill=""#ffffff"" />" & vbCrLf &
    "  <polygon points=""16,11 19,18 16,16 13,18"" fill=""#212529"" />" & vbCrLf &
    "</svg>"
    Public ReadOnly Property ToolName As String Implements IDevTool.ToolName
        Get
            Return "Icon & SVG Generator"
        End Get
    End Property
    Public ReadOnly Property ToolDescription As String Implements IDevTool.ToolDescription
        Get
            Return "Renders SVG paths into multi-size transparent PNG files."
        End Get
    End Property

    Public Sub OnToolLoaded() Implements IDevTool.OnToolLoaded
        InitializeSizeList()

        ' Load default sample SVG into the text box if empty
        If String.IsNullOrWhiteSpace(RTBSVGInput.Text) Then
            RTBSVGInput.Text = DefaultSVG
        End If

        ' Render initial preview
        RenderPreview()
    End Sub
    Public Sub OnToolUnloaded() Implements IDevTool.OnToolUnloaded
        If PBSVGPreview.Image IsNot Nothing Then
            PBSVGPreview.Image.Dispose()
            PBSVGPreview.Image = Nothing
        End If
    End Sub

    ' EVENTS
    Private Sub CLBSizes_SelectedValueChanged(sender As Object, e As EventArgs) Handles CLBSizes.SelectedValueChanged
        If CLBSizes.SelectedItem Is Nothing Then Return
        Debug.Print($"Selected size changed to: {CLBSizes.SelectedItem}")
        PBSVGPreview.Image?.Dispose()
        PBSVGPreview.Image = RenderSVGToBitmap(RTBSVGInput.Text, CInt(CLBSizes.SelectedItem))
    End Sub
    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles BtnPreview.Click
        RenderPreview()
    End Sub
    Private Sub BtnExportPNGs_Click(sender As Object, e As EventArgs) Handles BtnExportPNGs.Click
        If String.IsNullOrWhiteSpace(RTBSVGInput.Text) Then Return

        Using fbd As New FolderBrowserDialog()
            fbd.Description = "Select Destination Folder for Image PNGs"
            If fbd.ShowDialog() = DialogResult.OK Then
                Dim outputFolder = fbd.SelectedPath
                Dim exportedCount As Integer = 0

                For Each item In CLBSizes.CheckedItems
                    Dim sz As Integer
                    If Integer.TryParse(item.ToString(), sz) Then
                        Using bmp = RenderSVGToBitmap(RTBSVGInput.Text, sz)
                            If bmp IsNot Nothing Then
                                Dim filePath = Path.Combine(outputFolder, $"image_{sz}x{sz}.png")
                                bmp.Save(filePath, ImageFormat.Png)
                                exportedCount += 1
                            End If
                        End Using
                    End If
                Next

                MessageBox.Show($"Successfully exported {exportedCount} PNG images to:{vbCrLf}{outputFolder}",
                                "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub
    Private Sub BtnSaveSVG_Click(sender As Object, e As EventArgs) Handles BtnSaveSVG.Click
        If String.IsNullOrWhiteSpace(RTBSVGInput.Text) Then
            MessageBox.Show("There is no SVG markup to save.", "Empty Content", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Scalable Vector Graphics (*.svg)|*.svg|Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            sfd.DefaultExt = "svg"
            sfd.Title = "Save SVG Code"
            sfd.FileName = "icon_template.svg"
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    System.IO.File.WriteAllText(sfd.FileName, RTBSVGInput.Text)
                    MessageBox.Show("SVG code saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"Failed to save file: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub
    Private Sub BtnLoadSVG_Click(sender As Object, e As EventArgs) Handles BtnLoadSVG.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Scalable Vector Graphics (*.svg)|*.svg|Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            ofd.Title = "Open SVG File"
            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    ' Read the file contents into the input RichTextBox / TextBox
                    Dim fileText As String = System.IO.File.ReadAllText(ofd.FileName)
                    RTBSVGInput.Text = fileText
                    ' Trigger a preview refresh if a size is currently selected
                    If CLBSizes.SelectedItem IsNot Nothing Then
                        Dim selectedText As String = CLBSizes.SelectedItem.ToString().ToLower().Replace("x", "").Trim()
                        Dim targetSize As Integer
                        If Integer.TryParse(selectedText, targetSize) OrElse Integer.TryParse(CLBSizes.SelectedItem.ToString(), targetSize) Then
                            PBSVGPreview.Image?.Dispose()
                            PBSVGPreview.Image = RenderSVGToBitmap(RTBSVGInput.Text, targetSize)
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show($"Failed to load file: {ex.Message}", "File Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    ' METHODS
    Private Sub InitializeSizeList()
        CLBSizes.Items.Clear()

        ' Add items
        Dim sizes As String() = {"16", "24", "32", "48", "64", "128", "256"}
        CLBSizes.Items.AddRange(sizes)

        ' Check 16, 24, 32, 48, 64, 128, and 256 by default
        For Each defaultSize As String In {"16", "24", "32", "48", "64", "128", "256"}
            Dim idx As Integer = CLBSizes.Items.IndexOf(defaultSize)
            If idx <> -1 Then
                CLBSizes.SetItemChecked(idx, True)
            End If
        Next
    End Sub
    ''' <summary>
    ''' Parses SVG text and renders it to a 32bpp transparent bitmap at target size.
    ''' </summary>
    Private Function RenderSVGToBitmap(svgText As String, targetSize As Integer) As Bitmap
        If String.IsNullOrWhiteSpace(svgText) Then Return Nothing
        Try
            Dim svgDoc = SvgDocument.FromSvg(Of SvgDocument)(svgText)
            If svgDoc Is Nothing Then Return Nothing

            ' Force the internal document viewport to scale to targetSize
            svgDoc.Width = targetSize
            svgDoc.Height = targetSize

            ' Render cleanly to specified pixel dimensions
            Return svgDoc.Draw()
        Catch ex As Exception
            MessageBox.Show($"Error rendering SVG: {ex.Message}", "SVG Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
    Private Sub RenderPreview()
        PBSVGPreview.Image?.Dispose()
        PBSVGPreview.Image = RenderSVGToBitmap(RTBSVGInput.Text, 256)
    End Sub

End Class
