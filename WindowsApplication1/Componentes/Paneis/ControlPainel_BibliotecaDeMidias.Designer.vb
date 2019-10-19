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
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mídia Auxente")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("* Editando")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("[   !  ] Erro de Leitura")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gravando")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pronto para Gravar")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gravação Bem Sucedida")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mídia selecionada")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mídia em branco")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mídia presente")
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("<Selecione uma mídia>")
        Me.PanelBiblioMidia = New System.Windows.Forms.Panel()
        Me.PanelEnvolveTVWBiblioMedias = New System.Windows.Forms.Panel()
        Me.TVWBiblioMedias = New System.Windows.Forms.TreeView()
        Me.PanelEnvolveMidiaAberta = New System.Windows.Forms.Panel()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.TVFiles = New System.Windows.Forms.TreeView()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PanelBiblioMidia.SuspendLayout()
        Me.PanelEnvolveTVWBiblioMedias.SuspendLayout()
        Me.PanelEnvolveMidiaAberta.SuspendLayout()
        Me.Panel32.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBiblioMidia
        '
        Me.PanelBiblioMidia.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelBiblioMidia.Controls.Add(Me.Splitter1)
        Me.PanelBiblioMidia.Controls.Add(Me.PanelEnvolveMidiaAberta)
        Me.PanelBiblioMidia.Controls.Add(Me.PanelEnvolveTVWBiblioMedias)
        Me.PanelBiblioMidia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBiblioMidia.Location = New System.Drawing.Point(0, 0)
        Me.PanelBiblioMidia.Name = "PanelBiblioMidia"
        Me.PanelBiblioMidia.Size = New System.Drawing.Size(366, 492)
        Me.PanelBiblioMidia.TabIndex = 17
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
        Me.TVWBiblioMedias.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
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
        'PanelEnvolveMidiaAberta
        '
        Me.PanelEnvolveMidiaAberta.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelEnvolveMidiaAberta.Controls.Add(Me.Panel32)
        Me.PanelEnvolveMidiaAberta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolveMidiaAberta.Location = New System.Drawing.Point(0, 167)
        Me.PanelEnvolveMidiaAberta.Name = "PanelEnvolveMidiaAberta"
        Me.PanelEnvolveMidiaAberta.Size = New System.Drawing.Size(366, 325)
        Me.PanelEnvolveMidiaAberta.TabIndex = 90
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel32.Controls.Add(Me.TVFiles)
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel32.Location = New System.Drawing.Point(0, 0)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(366, 325)
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
        Me.TVFiles.Size = New System.Drawing.Size(366, 325)
        Me.TVFiles.TabIndex = 87
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Gray
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 167)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(366, 3)
        Me.Splitter1.TabIndex = 88
        Me.Splitter1.TabStop = False
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
        Me.PanelEnvolveTVWBiblioMedias.ResumeLayout(False)
        Me.PanelEnvolveMidiaAberta.ResumeLayout(False)
        Me.Panel32.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBiblioMidia As Panel
    Friend WithEvents PanelEnvolveTVWBiblioMedias As Panel
    Friend WithEvents TVWBiblioMedias As TreeView
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents PanelEnvolveMidiaAberta As Panel
    Friend WithEvents Panel32 As Panel
    Friend WithEvents TVFiles As TreeView
End Class
