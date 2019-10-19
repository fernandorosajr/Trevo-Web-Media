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
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TVMEDIAS")
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("<Selecione uma mídia>")
        Me.PanelMidiaAtiva = New System.Windows.Forms.Panel()
        Me.PanelEnvolveTVMedias = New System.Windows.Forms.Panel()
        Me.TVMedias = New System.Windows.Forms.TreeView()
        Me.PanelEnvolveMidiaAberta = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.TVFiles = New System.Windows.Forms.TreeView()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PanelMidiaAtiva.SuspendLayout()
        Me.PanelEnvolveTVMedias.SuspendLayout()
        Me.PanelEnvolveMidiaAberta.SuspendLayout()
        Me.Panel32.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMidiaAtiva
        '
        Me.PanelMidiaAtiva.Controls.Add(Me.Splitter1)
        Me.PanelMidiaAtiva.Controls.Add(Me.PanelEnvolveMidiaAberta)
        Me.PanelMidiaAtiva.Controls.Add(Me.PanelEnvolveTVMedias)
        Me.PanelMidiaAtiva.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMidiaAtiva.Location = New System.Drawing.Point(0, 0)
        Me.PanelMidiaAtiva.Name = "PanelMidiaAtiva"
        Me.PanelMidiaAtiva.Size = New System.Drawing.Size(284, 435)
        Me.PanelMidiaAtiva.TabIndex = 1
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
        Me.TVMedias.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TVMedias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVMedias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVMedias.ForeColor = System.Drawing.Color.Gainsboro
        Me.TVMedias.FullRowSelect = True
        Me.TVMedias.HideSelection = False
        Me.TVMedias.Location = New System.Drawing.Point(1, 1)
        Me.TVMedias.Name = "TVMedias"
        TreeNode2.Name = "Node0"
        TreeNode2.Text = "TVMEDIAS"
        Me.TVMedias.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.TVMedias.ShowLines = False
        Me.TVMedias.Size = New System.Drawing.Size(282, 104)
        Me.TVMedias.TabIndex = 87
        '
        'PanelEnvolveMidiaAberta
        '
        Me.PanelEnvolveMidiaAberta.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelEnvolveMidiaAberta.Controls.Add(Me.Panel32)
        Me.PanelEnvolveMidiaAberta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolveMidiaAberta.Location = New System.Drawing.Point(0, 106)
        Me.PanelEnvolveMidiaAberta.Name = "PanelEnvolveMidiaAberta"
        Me.PanelEnvolveMidiaAberta.Size = New System.Drawing.Size(284, 329)
        Me.PanelEnvolveMidiaAberta.TabIndex = 91
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel32.Controls.Add(Me.TVFiles)
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel32.Location = New System.Drawing.Point(0, 0)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(284, 329)
        Me.Panel32.TabIndex = 88
        '
        'TVFiles
        '
        Me.TVFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TVFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TVFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVFiles.ForeColor = System.Drawing.Color.Gainsboro
        Me.TVFiles.FullRowSelect = True
        Me.TVFiles.HideSelection = False
        Me.TVFiles.Location = New System.Drawing.Point(0, 0)
        Me.TVFiles.Name = "TVFiles"
        TreeNode1.ImageKey = "CD.ico"
        TreeNode1.Name = "Node1"
        TreeNode1.SelectedImageKey = "CD.ico"
        TreeNode1.Text = "<Selecione uma mídia>"
        Me.TVFiles.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TVFiles.ShowLines = False
        Me.TVFiles.Size = New System.Drawing.Size(284, 329)
        Me.TVFiles.TabIndex = 87
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Gray
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 106)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(284, 3)
        Me.Splitter1.TabIndex = 92
        Me.Splitter1.TabStop = False
        '
        'ControlPainel_MidiasAtivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelMidiaAtiva)
        Me.Name = "ControlPainel_MidiasAtivas"
        Me.Size = New System.Drawing.Size(284, 435)
        Me.PanelMidiaAtiva.ResumeLayout(False)
        Me.PanelEnvolveTVMedias.ResumeLayout(False)
        Me.PanelEnvolveMidiaAberta.ResumeLayout(False)
        Me.Panel32.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMidiaAtiva As Panel
    Friend WithEvents PanelEnvolveTVMedias As Panel
    Friend WithEvents TVMedias As TreeView
    Friend WithEvents PanelEnvolveMidiaAberta As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents TVFiles As TreeView
    Friend WithEvents Splitter1 As Splitter
End Class
