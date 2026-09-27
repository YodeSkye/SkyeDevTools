<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SVGImageGeneratorTool
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MainSplitContainer = New SplitContainer()
        RTBSVGInput = New Skye.UI.RichTextBox()
        LblSVG = New Skye.UI.Label()
        BtnExportPNGs = New Button()
        BtnPreview = New Button()
        CLBSizes = New CheckedListBox()
        PBSVGPreview = New PictureBox()
        LblSizes = New Skye.UI.Label()
        CType(MainSplitContainer, ComponentModel.ISupportInitialize).BeginInit()
        MainSplitContainer.Panel1.SuspendLayout()
        MainSplitContainer.Panel2.SuspendLayout()
        MainSplitContainer.SuspendLayout()
        CType(PBSVGPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MainSplitContainer
        ' 
        MainSplitContainer.Dock = DockStyle.Fill
        MainSplitContainer.Location = New Point(0, 0)
        MainSplitContainer.Name = "MainSplitContainer"
        ' 
        ' MainSplitContainer.Panel1
        ' 
        MainSplitContainer.Panel1.Controls.Add(RTBSVGInput)
        MainSplitContainer.Panel1.Controls.Add(LblSVG)
        ' 
        ' MainSplitContainer.Panel2
        ' 
        MainSplitContainer.Panel2.Controls.Add(BtnExportPNGs)
        MainSplitContainer.Panel2.Controls.Add(BtnPreview)
        MainSplitContainer.Panel2.Controls.Add(CLBSizes)
        MainSplitContainer.Panel2.Controls.Add(PBSVGPreview)
        MainSplitContainer.Panel2.Controls.Add(LblSizes)
        MainSplitContainer.Size = New Size(600, 600)
        MainSplitContainer.SplitterDistance = 200
        MainSplitContainer.TabIndex = 0
        ' 
        ' RTBSVGInput
        ' 
        RTBSVGInput.Dock = DockStyle.Fill
        RTBSVGInput.Font = New Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RTBSVGInput.Location = New Point(0, 27)
        RTBSVGInput.Name = "RTBSVGInput"
        RTBSVGInput.Size = New Size(200, 573)
        RTBSVGInput.TabIndex = 1
        RTBSVGInput.Text = ""
        ' 
        ' LblSVG
        ' 
        LblSVG.Dock = DockStyle.Top
        LblSVG.Location = New Point(0, 0)
        LblSVG.Name = "LblSVG"
        LblSVG.Size = New Size(200, 27)
        LblSVG.TabIndex = 0
        LblSVG.Text = "Paste SVG Code Here:"
        LblSVG.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BtnExportPNGs
        ' 
        BtnExportPNGs.Location = New Point(96, 26)
        BtnExportPNGs.Name = "BtnExportPNGs"
        BtnExportPNGs.Size = New Size(115, 23)
        BtnExportPNGs.TabIndex = 4
        BtnExportPNGs.Text = "Export PNGs"
        BtnExportPNGs.UseVisualStyleBackColor = True
        ' 
        ' BtnPreview
        ' 
        BtnPreview.Location = New Point(96, 135)
        BtnPreview.Name = "BtnPreview"
        BtnPreview.Size = New Size(297, 23)
        BtnPreview.TabIndex = 3
        BtnPreview.Text = "Render Preview"
        BtnPreview.UseVisualStyleBackColor = True
        ' 
        ' CLBSizes
        ' 
        CLBSizes.CheckOnClick = True
        CLBSizes.FormattingEnabled = True
        CLBSizes.Location = New Point(3, 27)
        CLBSizes.Name = "CLBSizes"
        CLBSizes.Size = New Size(87, 130)
        CLBSizes.TabIndex = 1
        ' 
        ' PBSVGPreview
        ' 
        PBSVGPreview.Dock = DockStyle.Bottom
        PBSVGPreview.Location = New Point(0, 164)
        PBSVGPreview.Name = "PBSVGPreview"
        PBSVGPreview.Size = New Size(396, 436)
        PBSVGPreview.SizeMode = PictureBoxSizeMode.CenterImage
        PBSVGPreview.TabIndex = 0
        PBSVGPreview.TabStop = False
        ' 
        ' LblSizes
        ' 
        LblSizes.Location = New Point(3, 8)
        LblSizes.Name = "LblSizes"
        LblSizes.Size = New Size(87, 18)
        LblSizes.TabIndex = 2
        LblSizes.Text = "Sizes To Export"
        LblSizes.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' SVGIconGeneratorTool
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MainSplitContainer)
        Name = "SVGIconGeneratorTool"
        Size = New Size(600, 600)
        MainSplitContainer.Panel1.ResumeLayout(False)
        MainSplitContainer.Panel2.ResumeLayout(False)
        CType(MainSplitContainer, ComponentModel.ISupportInitialize).EndInit()
        MainSplitContainer.ResumeLayout(False)
        CType(PBSVGPreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MainSplitContainer As SplitContainer
    Friend WithEvents LblSVG As Skye.UI.Label
    Friend WithEvents RTBSVGInput As Skye.UI.RichTextBox
    Friend WithEvents PBSVGPreview As PictureBox
    Friend WithEvents CLBSizes As CheckedListBox
    Friend WithEvents LblSizes As Skye.UI.Label
    Friend WithEvents BtnExportPNGs As Button
    Friend WithEvents BtnPreview As Button

End Class
