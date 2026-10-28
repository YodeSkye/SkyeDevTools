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
        PanelSVG = New Panel()
        HScrollBar1 = New HScrollBar()
        BtnLoadSVG = New Button()
        BtnSaveSVG = New Button()
        LblSVG = New Skye.UI.Label()
        BtnExportPNGs = New Button()
        BtnPreview = New Button()
        CLBSizes = New CheckedListBox()
        PBSVGPreview = New PictureBox()
        LblSizes = New Skye.UI.Label()
        PanelBackground = New FlowLayoutPanel()
        BtnBGDark = New Button()
        BtnBGDarkGrey = New Button()
        BtnBGNeutralGrey = New Button()
        BtnBGLightGrey = New Button()
        BtnBGLight = New Button()
        BtnBGTransparent = New Button()
        BtnBGSelect = New Button()
        CType(MainSplitContainer, ComponentModel.ISupportInitialize).BeginInit()
        MainSplitContainer.Panel1.SuspendLayout()
        MainSplitContainer.Panel2.SuspendLayout()
        MainSplitContainer.SuspendLayout()
        PanelSVG.SuspendLayout()
        CType(PBSVGPreview, ComponentModel.ISupportInitialize).BeginInit()
        PanelBackground.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainSplitContainer
        ' 
        MainSplitContainer.Dock = DockStyle.Fill
        MainSplitContainer.Location = New Point(0, 0)
        MainSplitContainer.Margin = New Padding(4)
        MainSplitContainer.Name = "MainSplitContainer"
        ' 
        ' MainSplitContainer.Panel1
        ' 
        MainSplitContainer.Panel1.Controls.Add(RTBSVGInput)
        MainSplitContainer.Panel1.Controls.Add(PanelSVG)
        MainSplitContainer.Panel1.Controls.Add(LblSVG)
        ' 
        ' MainSplitContainer.Panel2
        ' 
        MainSplitContainer.Panel2.Controls.Add(BtnExportPNGs)
        MainSplitContainer.Panel2.Controls.Add(BtnPreview)
        MainSplitContainer.Panel2.Controls.Add(CLBSizes)
        MainSplitContainer.Panel2.Controls.Add(PBSVGPreview)
        MainSplitContainer.Panel2.Controls.Add(LblSizes)
        MainSplitContainer.Panel2.Controls.Add(PanelBackground)
        MainSplitContainer.Size = New Size(1100, 840)
        MainSplitContainer.SplitterDistance = 515
        MainSplitContainer.SplitterWidth = 5
        MainSplitContainer.TabIndex = 0
        ' 
        ' RTBSVGInput
        ' 
        RTBSVGInput.Dock = DockStyle.Fill
        RTBSVGInput.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RTBSVGInput.Location = New Point(0, 38)
        RTBSVGInput.Margin = New Padding(4, 4, 4, 2000)
        RTBSVGInput.Name = "RTBSVGInput"
        RTBSVGInput.ScrollBars = RichTextBoxScrollBars.ForcedBoth
        RTBSVGInput.Size = New Size(515, 746)
        RTBSVGInput.TabIndex = 1
        RTBSVGInput.Text = ""
        RTBSVGInput.WordWrap = False
        ' 
        ' PanelSVG
        ' 
        PanelSVG.Controls.Add(HScrollBar1)
        PanelSVG.Controls.Add(BtnLoadSVG)
        PanelSVG.Controls.Add(BtnSaveSVG)
        PanelSVG.Dock = DockStyle.Bottom
        PanelSVG.Location = New Point(0, 784)
        PanelSVG.Name = "PanelSVG"
        PanelSVG.Size = New Size(515, 56)
        PanelSVG.TabIndex = 2
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.Location = New Point(354, 27)
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(8, 8)
        HScrollBar1.TabIndex = 2
        ' 
        ' BtnLoadSVG
        ' 
        BtnLoadSVG.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BtnLoadSVG.Location = New Point(353, 14)
        BtnLoadSVG.Name = "BtnLoadSVG"
        BtnLoadSVG.Size = New Size(150, 32)
        BtnLoadSVG.TabIndex = 1
        BtnLoadSVG.Text = "Load From File"
        BtnLoadSVG.UseVisualStyleBackColor = True
        ' 
        ' BtnSaveSVG
        ' 
        BtnSaveSVG.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnSaveSVG.Location = New Point(12, 14)
        BtnSaveSVG.Name = "BtnSaveSVG"
        BtnSaveSVG.Size = New Size(150, 32)
        BtnSaveSVG.TabIndex = 0
        BtnSaveSVG.Text = "Save To File"
        BtnSaveSVG.UseVisualStyleBackColor = True
        ' 
        ' LblSVG
        ' 
        LblSVG.Dock = DockStyle.Top
        LblSVG.Location = New Point(0, 0)
        LblSVG.Margin = New Padding(4, 0, 4, 0)
        LblSVG.Name = "LblSVG"
        LblSVG.Size = New Size(515, 38)
        LblSVG.TabIndex = 0
        LblSVG.Text = "Paste SVG Code Here"
        LblSVG.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' BtnExportPNGs
        ' 
        BtnExportPNGs.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnExportPNGs.Location = New Point(412, 178)
        BtnExportPNGs.Margin = New Padding(4)
        BtnExportPNGs.Name = "BtnExportPNGs"
        BtnExportPNGs.Size = New Size(148, 32)
        BtnExportPNGs.TabIndex = 4
        BtnExportPNGs.Text = "Export PNGs"
        BtnExportPNGs.UseVisualStyleBackColor = True
        ' 
        ' BtnPreview
        ' 
        BtnPreview.Location = New Point(4, 38)
        BtnPreview.Margin = New Padding(4)
        BtnPreview.Name = "BtnPreview"
        BtnPreview.Size = New Size(99, 62)
        BtnPreview.TabIndex = 3
        BtnPreview.Text = "Render Preview"
        BtnPreview.UseVisualStyleBackColor = True
        ' 
        ' CLBSizes
        ' 
        CLBSizes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CLBSizes.FormattingEnabled = True
        CLBSizes.Location = New Point(293, 38)
        CLBSizes.Margin = New Padding(4)
        CLBSizes.Name = "CLBSizes"
        CLBSizes.Size = New Size(111, 172)
        CLBSizes.TabIndex = 1
        ' 
        ' PBSVGPreview
        ' 
        PBSVGPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PBSVGPreview.BackColor = Color.White
        PBSVGPreview.BorderStyle = BorderStyle.FixedSingle
        PBSVGPreview.Location = New Point(0, 218)
        PBSVGPreview.Margin = New Padding(4)
        PBSVGPreview.Name = "PBSVGPreview"
        PBSVGPreview.Size = New Size(559, 618)
        PBSVGPreview.SizeMode = PictureBoxSizeMode.CenterImage
        PBSVGPreview.TabIndex = 0
        PBSVGPreview.TabStop = False
        ' 
        ' LblSizes
        ' 
        LblSizes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LblSizes.Location = New Point(292, 13)
        LblSizes.Margin = New Padding(4, 0, 4, 0)
        LblSizes.Name = "LblSizes"
        LblSizes.Size = New Size(112, 25)
        LblSizes.TabIndex = 2
        LblSizes.Text = "Sizes To Export"
        LblSizes.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' PanelBackground
        ' 
        PanelBackground.Controls.Add(BtnBGDark)
        PanelBackground.Controls.Add(BtnBGDarkGrey)
        PanelBackground.Controls.Add(BtnBGNeutralGrey)
        PanelBackground.Controls.Add(BtnBGLightGrey)
        PanelBackground.Controls.Add(BtnBGLight)
        PanelBackground.Controls.Add(BtnBGTransparent)
        PanelBackground.Controls.Add(BtnBGSelect)
        PanelBackground.Location = New Point(0, 181)
        PanelBackground.Name = "PanelBackground"
        PanelBackground.Size = New Size(231, 41)
        PanelBackground.TabIndex = 5
        PanelBackground.WrapContents = False
        ' 
        ' BtnBGDark
        ' 
        BtnBGDark.Location = New Point(0, 3)
        BtnBGDark.Margin = New Padding(0, 3, 0, 3)
        BtnBGDark.Name = "BtnBGDark"
        BtnBGDark.Size = New Size(32, 32)
        BtnBGDark.TabIndex = 0
        BtnBGDark.UseVisualStyleBackColor = True
        ' 
        ' BtnBGDarkGrey
        ' 
        BtnBGDarkGrey.Location = New Point(32, 3)
        BtnBGDarkGrey.Margin = New Padding(0, 3, 0, 3)
        BtnBGDarkGrey.Name = "BtnBGDarkGrey"
        BtnBGDarkGrey.Size = New Size(32, 32)
        BtnBGDarkGrey.TabIndex = 1
        BtnBGDarkGrey.UseVisualStyleBackColor = True
        ' 
        ' BtnBGNeutralGrey
        ' 
        BtnBGNeutralGrey.Location = New Point(64, 3)
        BtnBGNeutralGrey.Margin = New Padding(0, 3, 0, 3)
        BtnBGNeutralGrey.Name = "BtnBGNeutralGrey"
        BtnBGNeutralGrey.Size = New Size(32, 32)
        BtnBGNeutralGrey.TabIndex = 2
        BtnBGNeutralGrey.UseVisualStyleBackColor = True
        ' 
        ' BtnBGLightGrey
        ' 
        BtnBGLightGrey.Location = New Point(96, 3)
        BtnBGLightGrey.Margin = New Padding(0, 3, 0, 3)
        BtnBGLightGrey.Name = "BtnBGLightGrey"
        BtnBGLightGrey.Size = New Size(32, 32)
        BtnBGLightGrey.TabIndex = 3
        BtnBGLightGrey.UseVisualStyleBackColor = True
        ' 
        ' BtnBGLight
        ' 
        BtnBGLight.Location = New Point(128, 3)
        BtnBGLight.Margin = New Padding(0, 3, 0, 3)
        BtnBGLight.Name = "BtnBGLight"
        BtnBGLight.Size = New Size(32, 32)
        BtnBGLight.TabIndex = 4
        BtnBGLight.UseVisualStyleBackColor = True
        ' 
        ' BtnBGTransparent
        ' 
        BtnBGTransparent.Location = New Point(160, 3)
        BtnBGTransparent.Margin = New Padding(0, 3, 0, 3)
        BtnBGTransparent.Name = "BtnBGTransparent"
        BtnBGTransparent.Size = New Size(32, 32)
        BtnBGTransparent.TabIndex = 5
        BtnBGTransparent.UseVisualStyleBackColor = True
        ' 
        ' BtnBGSelect
        ' 
        BtnBGSelect.Location = New Point(192, 3)
        BtnBGSelect.Margin = New Padding(0, 3, 0, 3)
        BtnBGSelect.Name = "BtnBGSelect"
        BtnBGSelect.Size = New Size(32, 32)
        BtnBGSelect.TabIndex = 6
        BtnBGSelect.UseVisualStyleBackColor = True
        ' 
        ' SVGImageGeneratorTool
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MainSplitContainer)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "SVGImageGeneratorTool"
        Size = New Size(1100, 840)
        MainSplitContainer.Panel1.ResumeLayout(False)
        MainSplitContainer.Panel2.ResumeLayout(False)
        CType(MainSplitContainer, ComponentModel.ISupportInitialize).EndInit()
        MainSplitContainer.ResumeLayout(False)
        PanelSVG.ResumeLayout(False)
        CType(PBSVGPreview, ComponentModel.ISupportInitialize).EndInit()
        PanelBackground.ResumeLayout(False)
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
    Friend WithEvents PanelSVG As Panel
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents BtnLoadSVG As Button
    Friend WithEvents BtnSaveSVG As Button
    Friend WithEvents PanelBackground As FlowLayoutPanel
    Friend WithEvents BtnBGDark As Button
    Friend WithEvents BtnBGDarkGrey As Button
    Friend WithEvents BtnBGNeutralGrey As Button
    Friend WithEvents BtnBGLightGrey As Button
    Friend WithEvents BtnBGLight As Button
    Friend WithEvents BtnBGTransparent As Button
    Friend WithEvents BtnBGSelect As Button

End Class
