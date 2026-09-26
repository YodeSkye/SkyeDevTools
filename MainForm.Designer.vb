<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MainSplitContainer = New SplitContainer()
        LBTools = New ListBox()
        PanelHost = New Panel()
        CType(MainSplitContainer, ComponentModel.ISupportInitialize).BeginInit()
        MainSplitContainer.Panel1.SuspendLayout()
        MainSplitContainer.Panel2.SuspendLayout()
        MainSplitContainer.SuspendLayout()
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
        MainSplitContainer.Panel1.Controls.Add(LBTools)
        ' 
        ' MainSplitContainer.Panel2
        ' 
        MainSplitContainer.Panel2.Controls.Add(PanelHost)
        MainSplitContainer.Size = New Size(800, 450)
        MainSplitContainer.SplitterDistance = 207
        MainSplitContainer.TabIndex = 0
        ' 
        ' LBTools
        ' 
        LBTools.Dock = DockStyle.Fill
        LBTools.FormattingEnabled = True
        LBTools.Location = New Point(0, 0)
        LBTools.Name = "LBTools"
        LBTools.Size = New Size(207, 450)
        LBTools.TabIndex = 0
        ' 
        ' PanelHost
        ' 
        PanelHost.Dock = DockStyle.Fill
        PanelHost.Location = New Point(0, 0)
        PanelHost.Name = "PanelHost"
        PanelHost.Size = New Size(589, 450)
        PanelHost.TabIndex = 0
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MainSplitContainer)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Skye's Dev Tools"
        MainSplitContainer.Panel1.ResumeLayout(False)
        MainSplitContainer.Panel2.ResumeLayout(False)
        CType(MainSplitContainer, ComponentModel.ISupportInitialize).EndInit()
        MainSplitContainer.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents MainSplitContainer As SplitContainer
    Friend WithEvents LBTools As ListBox
    Friend WithEvents PanelHost As Panel

End Class
