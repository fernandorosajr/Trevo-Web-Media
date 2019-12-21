<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPainel_BibliotecaDeMidias
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("<Selecione uma mídia>")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mídia Auxente")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("* Editando")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("[   !  ] Erro de Leitura")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gravando")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pronto para Gravar")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gravação Bem Sucedida")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mídia selecionada")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mídia em branco")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mídia presente")
        Me.PanelBiblioMidia = New System.Windows.Forms.Panel()
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia = New System.Windows.Forms.Panel()
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia = New System.Windows.Forms.Panel()
        Me.TVFilesAndFoldersOfTheOpenMedia = New System.Windows.Forms.TreeView()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PanelEnvolveTVWBiblioMedias = New System.Windows.Forms.Panel()
        Me.TVWBiblioMedias = New System.Windows.Forms.TreeView()
        Me.PanelBiblioMidia.SuspendLayout()
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.SuspendLayout()
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.SuspendLayout()
        Me.PanelEnvolveTVWBiblioMedias.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBiblioMidia
        '
        Me.PanelBiblioMidia.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelBiblioMidia.Controls.Add(Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia)
        Me.PanelBiblioMidia.Controls.Add(Me.Splitter1)
        Me.PanelBiblioMidia.Controls.Add(Me.PanelEnvolveTVWBiblioMedias)
        Me.PanelBiblioMidia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBiblioMidia.Location = New System.Drawing.Point(0, 0)
        Me.PanelBiblioMidia.Name = "PanelBiblioMidia"
        Me.PanelBiblioMidia.Size = New System.Drawing.Size(366, 492)
        Me.PanelBiblioMidia.TabIndex = 17
        '
        'PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia
        '
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.Controls.Add(Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia)
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.Location = New System.Drawing.Point(0, 170)
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.Name = "PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia"
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.Size = New System.Drawing.Size(366, 322)
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.TabIndex = 90
        '
        'PanelBorder_TVFilesAndFoldersOfTheOpenMedia
        '
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.BackColor = System.Drawing.Color.DimGray
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.Controls.Add(Me.TVFilesAndFoldersOfTheOpenMedia)
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.Location = New System.Drawing.Point(0, 0)
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.Name = "PanelBorder_TVFilesAndFoldersOfTheOpenMedia"
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.Size = New System.Drawing.Size(366, 322)
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
        TreeNode1.ImageKey = "CD.ico"
        TreeNode1.Name = "Node1"
        TreeNode1.SelectedImageKey = "CD.ico"
        TreeNode1.Text = "<Selecione uma mídia>"
        Me.TVFilesAndFoldersOfTheOpenMedia.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TVFilesAndFoldersOfTheOpenMedia.ShowLines = False
        Me.TVFilesAndFoldersOfTheOpenMedia.Size = New System.Drawing.Size(364, 320)
        Me.TVFilesAndFoldersOfTheOpenMedia.TabIndex = 87
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 167)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(366, 3)
        Me.Splitter1.TabIndex = 88
        Me.Splitter1.TabStop = False
        '
        'PanelEnvolveTVWBiblioMedias
        '
        Me.PanelEnvolveTVWBiblioMedias.BackColor = System.Drawing.Color.DimGray
        Me.PanelEnvolveTVWBiblioMedias.Controls.Add(Me.TVWBiblioMedias)
        Me.PanelEnvolveTVWBiblioMedias.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEnvolveTVWBiblioMedias.Location = New System.Drawing.Point(0, 0)
        Me.PanelEnvolveTVWBiblioMedias.Name = "PanelEnvolveTVWBiblioMedias"
        Me.PanelEnvolveTVWBiblioMedias.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelEnvolveTVWBiblioMedias.Size = New System.Drawing.Size(366, 167)
        Me.PanelEnvolveTVWBiblioMedias.TabIndex = 89
        '
        'TVWBiblioMedias
        '
        Me.TVWBiblioMedias.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TVWBiblioMedias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVWBiblioMedias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVWBiblioMedias.ForeColor = System.Drawing.Color.Silver
        Me.TVWBiblioMedias.FullRowSelect = True
        Me.TVWBiblioMedias.LabelEdit = True
        Me.TVWBiblioMedias.Location = New System.Drawing.Point(1, 1)
        Me.TVWBiblioMedias.Name = "TVWBiblioMedias"
        TreeNode2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        TreeNode2.ImageKey = "CD-Desconhecido.ico"
        TreeNode2.Name = "Node1"
        TreeNode2.SelectedImageKey = "CD-Desconhecido.ico"
        TreeNode2.Text = "Mídia Auxente"
        TreeNode3.ForeColor = System.Drawing.Color.DodgerBlue
        TreeNode3.ImageKey = "CDEditing.ico"
        TreeNode3.Name = "Node2"
        TreeNode3.SelectedImageKey = "CDEditing.ico"
        TreeNode3.Text = "* Editando"
        TreeNode4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        TreeNode4.Name = "Node0"
        TreeNode4.Text = "[   !  ] Erro de Leitura"
        TreeNode5.ForeColor = System.Drawing.Color.Yellow
        TreeNode5.ImageKey = "rum10.ico"
        TreeNode5.Name = "Node1"
        TreeNode5.SelectedImageKey = "rum30.ico"
        TreeNode5.Text = "Gravando"
        TreeNode6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TreeNode6.Name = "Node0"
        TreeNode6.Text = "Pronto para Gravar"
        TreeNode7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        TreeNode7.Name = "Node1"
        TreeNode7.Text = "Gravação Bem Sucedida"
        TreeNode8.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
        TreeNode8.ForeColor = System.Drawing.Color.White
        TreeNode8.Name = "Node0"
        TreeNode8.Text = "Mídia selecionada"
        TreeNode9.ForeColor = System.Drawing.Color.White
        TreeNode9.Name = "Node1"
        TreeNode9.Text = "Mídia em branco"
        TreeNode10.Name = "Node2"
        TreeNode10.Text = "Mídia presente"
        Me.TVWBiblioMedias.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10})
        Me.TVWBiblioMedias.ShowLines = False
        Me.TVWBiblioMedias.Size = New System.Drawing.Size(364, 165)
        Me.TVWBiblioMedias.TabIndex = 87
        '
        'ControlPainel_BibliotecaDeMidias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.Controls.Add(Me.PanelBiblioMidia)
        Me.Name = "ControlPainel_BibliotecaDeMidias"
        Me.Size = New System.Drawing.Size(366, 492)
        Me.PanelBiblioMidia.ResumeLayout(False)
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.ResumeLayout(False)
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.ResumeLayout(False)
        Me.PanelEnvolveTVWBiblioMedias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBiblioMidia As Panel
    Friend WithEvents PanelEnvolveTVWBiblioMedias As Panel
    Friend WithEvents TVWBiblioMedias As TreeView
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia As Panel
    Friend WithEvents PanelBorder_TVFilesAndFoldersOfTheOpenMedia As Panel
    Friend WithEvents TVFilesAndFoldersOfTheOpenMedia As TreeView
End Class
