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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("<Selecione uma mídia>")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPainel_MidiasAtivas))
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TVMEDIAS")
        Me.PanelMidiaAtiva = New System.Windows.Forms.Panel()
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia = New System.Windows.Forms.Panel()
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia = New System.Windows.Forms.Panel()
        Me.TVFilesAndFoldersOfTheOpenMedia = New System.Windows.Forms.TreeView()
        Me.IMGList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PanelEnvolveTVMedias = New System.Windows.Forms.Panel()
        Me.TVMedias = New System.Windows.Forms.TreeView()
        Me.CMItens = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExpamdirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NovaPastaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarParaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarParaÁreaDeTranferênciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenomearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverParaProcessoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoAgrupamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgrupamentoSelecionadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverParaPastaProcessoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaPastaProcessoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropriedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelMidiaAtiva.SuspendLayout()
        Me.PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia.SuspendLayout()
        Me.PanelBorder_TVFilesAndFoldersOfTheOpenMedia.SuspendLayout()
        Me.PanelEnvolveTVMedias.SuspendLayout()
        Me.CMItens.SuspendLayout()
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
        Me.TVFilesAndFoldersOfTheOpenMedia.ImageIndex = 0
        Me.TVFilesAndFoldersOfTheOpenMedia.ImageList = Me.IMGList1
        Me.TVFilesAndFoldersOfTheOpenMedia.Location = New System.Drawing.Point(1, 1)
        Me.TVFilesAndFoldersOfTheOpenMedia.Name = "TVFilesAndFoldersOfTheOpenMedia"
        TreeNode1.ImageKey = "DVD"
        TreeNode1.Name = "Node1"
        TreeNode1.SelectedImageKey = "DVD"
        TreeNode1.Text = "<Selecione uma mídia>"
        Me.TVFilesAndFoldersOfTheOpenMedia.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TVFilesAndFoldersOfTheOpenMedia.SelectedImageIndex = 0
        Me.TVFilesAndFoldersOfTheOpenMedia.ShowLines = False
        Me.TVFilesAndFoldersOfTheOpenMedia.Size = New System.Drawing.Size(282, 324)
        Me.TVFilesAndFoldersOfTheOpenMedia.TabIndex = 87
        '
        'IMGList1
        '
        Me.IMGList1.ImageStream = CType(resources.GetObject("IMGList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IMGList1.TransparentColor = System.Drawing.Color.Transparent
        Me.IMGList1.Images.SetKeyName(0, "Desktop")
        Me.IMGList1.Images.SetKeyName(1, "Computador")
        Me.IMGList1.Images.SetKeyName(2, "Imagens")
        Me.IMGList1.Images.SetKeyName(3, "Documentos")
        Me.IMGList1.Images.SetKeyName(4, "Musicas")
        Me.IMGList1.Images.SetKeyName(5, "pastaAberta")
        Me.IMGList1.Images.SetKeyName(6, "pastaFechada")
        Me.IMGList1.Images.SetKeyName(7, "hd")
        Me.IMGList1.Images.SetKeyName(8, "DVD")
        Me.IMGList1.Images.SetKeyName(9, "UnidadeVazia")
        Me.IMGList1.Images.SetKeyName(10, "info")
        Me.IMGList1.Images.SetKeyName(11, "Videos")
        Me.IMGList1.Images.SetKeyName(12, "down")
        Me.IMGList1.Images.SetKeyName(13, "Pen.ico")
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
        Me.TVMedias.ImageIndex = 0
        Me.TVMedias.ImageList = Me.IMGList1
        Me.TVMedias.Location = New System.Drawing.Point(1, 1)
        Me.TVMedias.Name = "TVMedias"
        TreeNode2.Name = "Node0"
        TreeNode2.Text = "TVMEDIAS"
        Me.TVMedias.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.TVMedias.SelectedImageIndex = 0
        Me.TVMedias.ShowLines = False
        Me.TVMedias.Size = New System.Drawing.Size(282, 104)
        Me.TVMedias.TabIndex = 87
        '
        'CMItens
        '
        Me.CMItens.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExpamdirToolStripMenuItem, Me.ToolStripSeparator1, Me.NovaPastaToolStripMenuItem, Me.CopiarComoToolStripMenuItem, Me.CopiarParaToolStripMenuItem, Me.CopiarParaÁreaDeTranferênciaToolStripMenuItem, Me.RenomearToolStripMenuItem, Me.ToolStripSeparator2, Me.ExcluirToolStripMenuItem, Me.MoverParaProcessoToolStripMenuItem, Me.MoverParaPastaProcessoToolStripMenuItem, Me.ProcessarToolStripMenuItem, Me.ToolStripSeparator3, Me.PropriedadesToolStripMenuItem})
        Me.CMItens.Name = "CMItens"
        Me.CMItens.Size = New System.Drawing.Size(243, 264)
        '
        'ExpamdirToolStripMenuItem
        '
        Me.ExpamdirToolStripMenuItem.Name = "ExpamdirToolStripMenuItem"
        Me.ExpamdirToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.ExpamdirToolStripMenuItem.Text = "Expandir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(239, 6)
        '
        'NovaPastaToolStripMenuItem
        '
        Me.NovaPastaToolStripMenuItem.Name = "NovaPastaToolStripMenuItem"
        Me.NovaPastaToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.NovaPastaToolStripMenuItem.Text = "Nova Pasta"
        '
        'CopiarComoToolStripMenuItem
        '
        Me.CopiarComoToolStripMenuItem.Name = "CopiarComoToolStripMenuItem"
        Me.CopiarComoToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.CopiarComoToolStripMenuItem.Text = "Copiar como..."
        '
        'CopiarParaToolStripMenuItem
        '
        Me.CopiarParaToolStripMenuItem.Name = "CopiarParaToolStripMenuItem"
        Me.CopiarParaToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.CopiarParaToolStripMenuItem.Text = "Copiar para..."
        '
        'CopiarParaÁreaDeTranferênciaToolStripMenuItem
        '
        Me.CopiarParaÁreaDeTranferênciaToolStripMenuItem.Name = "CopiarParaÁreaDeTranferênciaToolStripMenuItem"
        Me.CopiarParaÁreaDeTranferênciaToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.CopiarParaÁreaDeTranferênciaToolStripMenuItem.Text = "Copiar para área de tranferência"
        '
        'RenomearToolStripMenuItem
        '
        Me.RenomearToolStripMenuItem.Name = "RenomearToolStripMenuItem"
        Me.RenomearToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.RenomearToolStripMenuItem.Text = "Renomear"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(239, 6)
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'MoverParaProcessoToolStripMenuItem
        '
        Me.MoverParaProcessoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoAgrupamentoToolStripMenuItem, Me.AgrupamentoSelecionadoToolStripMenuItem})
        Me.MoverParaProcessoToolStripMenuItem.Name = "MoverParaProcessoToolStripMenuItem"
        Me.MoverParaProcessoToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.MoverParaProcessoToolStripMenuItem.Text = "Mover para agrupamento..."
        '
        'NovoAgrupamentoToolStripMenuItem
        '
        Me.NovoAgrupamentoToolStripMenuItem.Name = "NovoAgrupamentoToolStripMenuItem"
        Me.NovoAgrupamentoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.NovoAgrupamentoToolStripMenuItem.Text = "Novo agrupamento"
        '
        'AgrupamentoSelecionadoToolStripMenuItem
        '
        Me.AgrupamentoSelecionadoToolStripMenuItem.Name = "AgrupamentoSelecionadoToolStripMenuItem"
        Me.AgrupamentoSelecionadoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.AgrupamentoSelecionadoToolStripMenuItem.Text = "Agrupamento selecionado"
        '
        'MoverParaPastaProcessoToolStripMenuItem
        '
        Me.MoverParaPastaProcessoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaPastaProcessoToolStripMenuItem, Me.ToolStripSeparator4, Me.ToolStripMenuItem2})
        Me.MoverParaPastaProcessoToolStripMenuItem.Name = "MoverParaPastaProcessoToolStripMenuItem"
        Me.MoverParaPastaProcessoToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.MoverParaPastaProcessoToolStripMenuItem.Text = "Mover para Pasta Processo"
        '
        'NovaPastaProcessoToolStripMenuItem
        '
        Me.NovaPastaProcessoToolStripMenuItem.Name = "NovaPastaProcessoToolStripMenuItem"
        Me.NovaPastaProcessoToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.NovaPastaProcessoToolStripMenuItem.Text = "Nova Pasta Processo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(180, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem2.Text = "..."
        '
        'ProcessarToolStripMenuItem
        '
        Me.ProcessarToolStripMenuItem.Name = "ProcessarToolStripMenuItem"
        Me.ProcessarToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.ProcessarToolStripMenuItem.Text = "Processar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(239, 6)
        '
        'PropriedadesToolStripMenuItem
        '
        Me.PropriedadesToolStripMenuItem.Name = "PropriedadesToolStripMenuItem"
        Me.PropriedadesToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.PropriedadesToolStripMenuItem.Text = "Mostrar detalhes"
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
        Me.CMItens.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMidiaAtiva As Panel
    Friend WithEvents PanelEnvolveTVMedias As Panel
    Friend WithEvents TVMedias As TreeView
    Friend WithEvents PanelEnvolve_TVFilesAndFoldersOfTheOpenMedia As Panel
    Friend WithEvents PanelBorder_TVFilesAndFoldersOfTheOpenMedia As Panel
    Friend WithEvents TVFilesAndFoldersOfTheOpenMedia As TreeView
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents CMItens As ContextMenuStrip
    Friend WithEvents ExpamdirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NovaPastaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarParaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarParaÁreaDeTranferênciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenomearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoverParaProcessoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoAgrupamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgrupamentoSelecionadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoverParaPastaProcessoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaPastaProcessoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ProcessarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents PropriedadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IMGList1 As ImageList
End Class
