<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPainel_MidiasAtivas
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
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("<Selecione uma mídia>")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TVMEDIAS")
        Me.PanelMidiaAtiva = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia = New System.Windows.Forms.Panel()
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia = New System.Windows.Forms.Panel()
        Me.TVFilesAndFoldersOfTheOpenMedia = New System.Windows.Forms.TreeView()
        Me.PanelEnvolveTVMedias = New System.Windows.Forms.Panel()
        Me.TVMedias = New System.Windows.Forms.TreeView()
        Me.PanelMidiaAtiva.SuspendLayout()
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.SuspendLayout()
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.SuspendLayout()
        Me.PanelEnvolveTVMedias.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMidiaAtiva
        '
        Me.PanelMidiaAtiva.Controls.Add(Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia)
        Me.PanelMidiaAtiva.Controls.Add(Me.Splitter1)
        Me.PanelMidiaAtiva.Controls.Add(Me.PanelEnvolveTVMedias)
        Me.PanelMidiaAtiva.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMidiaAtiva.Location = New System.Drawing.Point(0, 0)
        Me.PanelMidiaAtiva.Name = "PanelMidiaAtiva"
        Me.PanelMidiaAtiva.Size = New System.Drawing.Size(284, 435)
        Me.PanelMidiaAtiva.TabIndex = 1
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 106)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(284, 3)
        Me.Splitter1.TabIndex = 92
        Me.Splitter1.TabStop = False
        '
        'PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia
        '
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.Controls.Add(Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia)
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.Location = New System.Drawing.Point(0, 109)
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.Name = "PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia"
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.Size = New System.Drawing.Size(284, 326)
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.TabIndex = 91
        '
        'PanelBorder_TVFilesAndFoldersOfTheOpenMedia
        '
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.BackColor = System.Drawing.Color.DimGray
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.Controls.Add(Me.TVFilesAndFoldersOfTheOpenMedia)
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.Location = New System.Drawing.Point(0, 0)
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.Name = "PanelBorder_TVFilesAndFoldersOfTheOpenMedia"
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.Size = New System.Drawing.Size(284, 326)
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.TabIndex = 88
        '
        'TVFilesAndFoldersOfTheOpenMedia
        '
        Me.TVFilesAndFoldersOfTheOpenMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TVFilesAndFoldersOfTheOpenMedia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVFilesAndFoldersOfTheOpenMedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVFilesAndFoldersOfTheOpenMedia.ForeColor = System.Drawing.Color.Gainsboro
        Me.TVFilesAndFoldersOfTheOpenMedia.FullRowSelect = True
        Me.TVFilesAndFoldersOfTheOpenMedia.HideSelection = False
        Me.TVFilesAndFoldersOfTheOpenMedia.Location = New System.Drawing.Point(1, 1)
        Me.TVFilesAndFoldersOfTheOpenMedia.Name = "TVFilesAndFoldersOfTheOpenMedia"
        TreeNode3.ImageKey = "CD.ico"
        TreeNode3.Name = "Node1"
        TreeNode3.SelectedImageKey = "CD.ico"
        TreeNode3.Text = "<Selecione uma mídia>"
        Me.TVFilesAndFoldersOfTheOpenMedia.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.TVFilesAndFoldersOfTheOpenMedia.ShowLines = False
        Me.TVFilesAndFoldersOfTheOpenMedia.Size = New System.Drawing.Size(282, 324)
        Me.TVFilesAndFoldersOfTheOpenMedia.TabIndex = 87
        '
        'PanelEnvolveTVMedias
        '
        Me.PanelEnvolveTVMedias.BackColor = System.Drawing.Color.DimGray
        Me.PanelEnvolveTVMedias.Controls.Add(Me.TVMedias)
        Me.PanelEnvolveTVMedias.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEnvolveTVMedias.Location = New System.Drawing.Point(0, 0)
        Me.PanelEnvolveTVMedias.Name = "PanelEnvolveTVMedias"
        Me.PanelEnvolveTVMedias.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelEnvolveTVMedias.Size = New System.Drawing.Size(284, 106)
        Me.PanelEnvolveTVMedias.TabIndex = 89
        '
        'TVMedias
        '
        Me.TVMedias.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TVMedias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVMedias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVMedias.ForeColor = System.Drawing.Color.Gainsboro
        Me.TVMedias.FullRowSelect = True
        Me.TVMedias.HideSelection = False
        Me.TVMedias.Location = New System.Drawing.Point(1, 1)
        Me.TVMedias.Name = "TVMedias"
        TreeNode4.Name = "Node0"
        TreeNode4.Text = "TVMEDIAS"
        Me.TVMedias.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.TVMedias.ShowLines = False
        Me.TVMedias.Size = New System.Drawing.Size(282, 104)
        Me.TVMedias.TabIndex = 87
        '
        'ControlPainel_MidiasAtivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelMidiaAtiva)
        Me.Name = "ControlPainel_MidiasAtivas"
        Me.Size = New System.Drawing.Size(284, 435)
        Me.PanelMidiaAtiva.ResumeLayout(False)
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.ResumeLayout(False)
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.ResumeLayout(False)
        Me.PanelEnvolveTVMedias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMidiaAtiva As Panel
    Friend WithEvents PanelEnvolveTVMedias As Panel
    Friend WithEvents TVMedias As TreeView
    Friend WithEvents PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia As Panel
    Friend WithEvents PanelBorder_TVFilesAndFoldersOfTheOpenMedia As Panel
    Friend WithEvents TVFilesAndFoldersOfTheOpenMedia As TreeView
    Friend WithEvents Splitter1 As Splitter
End Class
