<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlPainel_Desktop
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPainel_Desktop))
        Me.TVWFilesAndFolders = New System.Windows.Forms.TreeView()
        Me.IMGList = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelBorder_TVWDesktop = New System.Windows.Forms.Panel()
        Me.PanelBorderTVW = New System.Windows.Forms.Panel()
        Me.PanelBackgroundTVW = New System.Windows.Forms.Panel()
        Me.PanelBorder_OpcoesDeProcessos = New System.Windows.Forms.Panel()
        Me.PanelBaseLuzLeft = New System.Windows.Forms.Panel()
        Me.PanelSombra = New System.Windows.Forms.Panel()
        Me.PanelOpcoesDeProcessos = New System.Windows.Forms.Panel()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes = New System.Windows.Forms.Panel()
        Me.CHK_ShowCheck = New System.Windows.Forms.CheckBox()
        Me.PanelEnvolve_BTN_NewFolder = New System.Windows.Forms.Panel()
        Me.BTN_NewFolder = New System.Windows.Forms.Button()
        Me.CMItens = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExpandirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NovaPastaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarParaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarParaÁreaDeTranferênciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenomearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.AbrirComExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripSeparator()
        Me.AdicionarAcoesAEstaPastaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverParaUmGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoAgrupamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgrupamentoSelecionadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverParaUmaPastaComAcoesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaPastaComAcoesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExecutarAcoesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropriedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PanelBorder_TVWDesktop.SuspendLayout()
        Me.PanelBorderTVW.SuspendLayout()
        Me.PanelBackgroundTVW.SuspendLayout()
        Me.PanelBorder_OpcoesDeProcessos.SuspendLayout()
        Me.PanelBaseLuzLeft.SuspendLayout()
        Me.PanelOpcoesDeProcessos.SuspendLayout()
        Me.Panel36.SuspendLayout()
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.SuspendLayout()
        Me.PanelEnvolve_BTN_NewFolder.SuspendLayout()
        Me.CMItens.SuspendLayout()
        Me.SuspendLayout()
        '
        'TVWFilesAndFolders
        '
        Me.TVWFilesAndFolders.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TVWFilesAndFolders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVWFilesAndFolders.CheckBoxes = True
        Me.TVWFilesAndFolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVWFilesAndFolders.ForeColor = System.Drawing.Color.Gainsboro
        Me.TVWFilesAndFolders.FullRowSelect = True
        Me.TVWFilesAndFolders.HideSelection = False
        Me.TVWFilesAndFolders.ImageIndex = 0
        Me.TVWFilesAndFolders.ImageList = Me.IMGList
        Me.TVWFilesAndFolders.Location = New System.Drawing.Point(0, 3)
        Me.TVWFilesAndFolders.Name = "TVWFilesAndFolders"
        Me.TVWFilesAndFolders.SelectedImageIndex = 0
        Me.TVWFilesAndFolders.ShowLines = False
        Me.TVWFilesAndFolders.Size = New System.Drawing.Size(322, 404)
        Me.TVWFilesAndFolders.TabIndex = 3
        '
        'IMGList
        '
        Me.IMGList.ImageStream = CType(resources.GetObject("IMGList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IMGList.TransparentColor = System.Drawing.Color.Transparent
        Me.IMGList.Images.SetKeyName(0, "Desktop")
        Me.IMGList.Images.SetKeyName(1, "Computador")
        Me.IMGList.Images.SetKeyName(2, "Imagens")
        Me.IMGList.Images.SetKeyName(3, "Documentos")
        Me.IMGList.Images.SetKeyName(4, "Musicas")
        Me.IMGList.Images.SetKeyName(5, "pastaAberta")
        Me.IMGList.Images.SetKeyName(6, "pastaFechada")
        Me.IMGList.Images.SetKeyName(7, "hd")
        Me.IMGList.Images.SetKeyName(8, "DVD")
        Me.IMGList.Images.SetKeyName(9, "UnidadeVazia")
        Me.IMGList.Images.SetKeyName(10, "info")
        Me.IMGList.Images.SetKeyName(11, "Videos")
        Me.IMGList.Images.SetKeyName(12, "down")
        Me.IMGList.Images.SetKeyName(13, "Pen.ico")
        '
        'PanelBorder_TVWDesktop
        '
        Me.PanelBorder_TVWDesktop.BackColor = System.Drawing.Color.DimGray
        Me.PanelBorder_TVWDesktop.Controls.Add(Me.PanelBorderTVW)
        Me.PanelBorder_TVWDesktop.Controls.Add(Me.PanelBorder_OpcoesDeProcessos)
        Me.PanelBorder_TVWDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorder_TVWDesktop.Location = New System.Drawing.Point(0, 0)
        Me.PanelBorder_TVWDesktop.Name = "PanelBorder_TVWDesktop"
        Me.PanelBorder_TVWDesktop.Size = New System.Drawing.Size(324, 436)
        Me.PanelBorder_TVWDesktop.TabIndex = 4
        '
        'PanelBorderTVW
        '
        Me.PanelBorderTVW.Controls.Add(Me.PanelBackgroundTVW)
        Me.PanelBorderTVW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBorderTVW.Location = New System.Drawing.Point(0, 27)
        Me.PanelBorderTVW.Name = "PanelBorderTVW"
        Me.PanelBorderTVW.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorderTVW.Size = New System.Drawing.Size(324, 409)
        Me.PanelBorderTVW.TabIndex = 99
        '
        'PanelBackgroundTVW
        '
        Me.PanelBackgroundTVW.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelBackgroundTVW.Controls.Add(Me.TVWFilesAndFolders)
        Me.PanelBackgroundTVW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBackgroundTVW.Location = New System.Drawing.Point(1, 1)
        Me.PanelBackgroundTVW.Name = "PanelBackgroundTVW"
        Me.PanelBackgroundTVW.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.PanelBackgroundTVW.Size = New System.Drawing.Size(322, 407)
        Me.PanelBackgroundTVW.TabIndex = 4
        '
        'PanelBorder_OpcoesDeProcessos
        '
        Me.PanelBorder_OpcoesDeProcessos.BackColor = System.Drawing.Color.DimGray
        Me.PanelBorder_OpcoesDeProcessos.Controls.Add(Me.PanelBaseLuzLeft)
        Me.PanelBorder_OpcoesDeProcessos.Controls.Add(Me.PanelOpcoesDeProcessos)
        Me.PanelBorder_OpcoesDeProcessos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBorder_OpcoesDeProcessos.Location = New System.Drawing.Point(0, 0)
        Me.PanelBorder_OpcoesDeProcessos.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelBorder_OpcoesDeProcessos.Name = "PanelBorder_OpcoesDeProcessos"
        Me.PanelBorder_OpcoesDeProcessos.Padding = New System.Windows.Forms.Padding(1, 1, 1, 0)
        Me.PanelBorder_OpcoesDeProcessos.Size = New System.Drawing.Size(324, 27)
        Me.PanelBorder_OpcoesDeProcessos.TabIndex = 97
        '
        'PanelBaseLuzLeft
        '
        Me.PanelBaseLuzLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelBaseLuzLeft.Controls.Add(Me.PanelSombra)
        Me.PanelBaseLuzLeft.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBaseLuzLeft.Location = New System.Drawing.Point(1, 25)
        Me.PanelBaseLuzLeft.Name = "PanelBaseLuzLeft"
        Me.PanelBaseLuzLeft.Size = New System.Drawing.Size(322, 2)
        Me.PanelBaseLuzLeft.TabIndex = 98
        '
        'PanelSombra
        '
        Me.PanelSombra.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.PanelSombra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelSombra.Location = New System.Drawing.Point(0, 1)
        Me.PanelSombra.Name = "PanelSombra"
        Me.PanelSombra.Size = New System.Drawing.Size(322, 1)
        Me.PanelSombra.TabIndex = 95
        '
        'PanelOpcoesDeProcessos
        '
        Me.PanelOpcoesDeProcessos.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelOpcoesDeProcessos.Controls.Add(Me.Panel36)
        Me.PanelOpcoesDeProcessos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelOpcoesDeProcessos.Location = New System.Drawing.Point(1, 1)
        Me.PanelOpcoesDeProcessos.Name = "PanelOpcoesDeProcessos"
        Me.PanelOpcoesDeProcessos.Padding = New System.Windows.Forms.Padding(5, 2, 5, 0)
        Me.PanelOpcoesDeProcessos.Size = New System.Drawing.Size(322, 26)
        Me.PanelOpcoesDeProcessos.TabIndex = 1
        '
        'Panel36
        '
        Me.Panel36.Controls.Add(Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes)
        Me.Panel36.Controls.Add(Me.PanelEnvolve_BTN_NewFolder)
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel36.Location = New System.Drawing.Point(5, 2)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.Panel36.Size = New System.Drawing.Size(312, 24)
        Me.Panel36.TabIndex = 0
        '
        'PanelEnvolveCHK_ShowPanelAllProcessosAcoes
        '
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Controls.Add(Me.CHK_ShowCheck)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Location = New System.Drawing.Point(32, 1)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Name = "PanelEnvolveCHK_ShowPanelAllProcessosAcoes"
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Size = New System.Drawing.Size(32, 22)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.TabIndex = 115
        '
        'CHK_ShowCheck
        '
        Me.CHK_ShowCheck.Appearance = System.Windows.Forms.Appearance.Button
        Me.CHK_ShowCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CHK_ShowCheck.BackgroundImage = CType(resources.GetObject("CHK_ShowCheck.BackgroundImage"), System.Drawing.Image)
        Me.CHK_ShowCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CHK_ShowCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CHK_ShowCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CHK_ShowCheck.FlatAppearance.BorderSize = 0
        Me.CHK_ShowCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.CHK_ShowCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CHK_ShowCheck.Location = New System.Drawing.Point(1, 1)
        Me.CHK_ShowCheck.Name = "CHK_ShowCheck"
        Me.CHK_ShowCheck.Size = New System.Drawing.Size(30, 20)
        Me.CHK_ShowCheck.TabIndex = 19
        Me.CHK_ShowCheck.UseVisualStyleBackColor = False
        '
        'PanelEnvolve_BTN_NewFolder
        '
        Me.PanelEnvolve_BTN_NewFolder.Controls.Add(Me.BTN_NewFolder)
        Me.PanelEnvolve_BTN_NewFolder.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEnvolve_BTN_NewFolder.Location = New System.Drawing.Point(0, 1)
        Me.PanelEnvolve_BTN_NewFolder.Name = "PanelEnvolve_BTN_NewFolder"
        Me.PanelEnvolve_BTN_NewFolder.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelEnvolve_BTN_NewFolder.Size = New System.Drawing.Size(32, 22)
        Me.PanelEnvolve_BTN_NewFolder.TabIndex = 114
        '
        'BTN_NewFolder
        '
        Me.BTN_NewFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NewFolder.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.Nova_pasta_em_agrupamentos
        Me.BTN_NewFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NewFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NewFolder.FlatAppearance.BorderSize = 0
        Me.BTN_NewFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NewFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NewFolder.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NewFolder.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_NewFolder.Name = "BTN_NewFolder"
        Me.BTN_NewFolder.Size = New System.Drawing.Size(30, 20)
        Me.BTN_NewFolder.TabIndex = 20
        Me.BTN_NewFolder.UseVisualStyleBackColor = False
        '
        'CMItens
        '
        Me.CMItens.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExpandirToolStripMenuItem, Me.ToolStripSeparator1, Me.NovaPastaToolStripMenuItem, Me.AdicionarAcoesAEstaPastaToolStripMenuItem, Me.ToolStripMenuItem3, Me.CopiarComoToolStripMenuItem, Me.CopiarParaToolStripMenuItem, Me.CopiarParaÁreaDeTranferênciaToolStripMenuItem, Me.RenomearToolStripMenuItem, Me.ToolStripSeparator2, Me.ExcluirToolStripMenuItem, Me.ToolStripSeparator9, Me.AbrirComExplorerToolStripMenuItem, Me.ToolStripMenuItem18, Me.MoverParaUmGrupoToolStripMenuItem, Me.MoverParaUmaPastaComAcoesToolStripMenuItem, Me.ExecutarAcoesToolStripMenuItem, Me.ToolStripSeparator3, Me.PropriedadesToolStripMenuItem})
        Me.CMItens.Name = "CMItens"
        Me.CMItens.Size = New System.Drawing.Size(253, 348)
        '
        'ExpandirToolStripMenuItem
        '
        Me.ExpandirToolStripMenuItem.Name = "ExpandirToolStripMenuItem"
        Me.ExpandirToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.ExpandirToolStripMenuItem.Text = "Expandir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(249, 6)
        '
        'NovaPastaToolStripMenuItem
        '
        Me.NovaPastaToolStripMenuItem.Name = "NovaPastaToolStripMenuItem"
        Me.NovaPastaToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.NovaPastaToolStripMenuItem.Text = "Nova Pasta...."
        '
        'CopiarComoToolStripMenuItem
        '
        Me.CopiarComoToolStripMenuItem.Name = "CopiarComoToolStripMenuItem"
        Me.CopiarComoToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.CopiarComoToolStripMenuItem.Text = "Copiar como..."
        '
        'CopiarParaToolStripMenuItem
        '
        Me.CopiarParaToolStripMenuItem.Name = "CopiarParaToolStripMenuItem"
        Me.CopiarParaToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.CopiarParaToolStripMenuItem.Text = "Copiar para..."
        '
        'CopiarParaÁreaDeTranferênciaToolStripMenuItem
        '
        Me.CopiarParaÁreaDeTranferênciaToolStripMenuItem.Name = "CopiarParaÁreaDeTranferênciaToolStripMenuItem"
        Me.CopiarParaÁreaDeTranferênciaToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.CopiarParaÁreaDeTranferênciaToolStripMenuItem.Text = "Copiar para área de tranferência"
        '
        'RenomearToolStripMenuItem
        '
        Me.RenomearToolStripMenuItem.Name = "RenomearToolStripMenuItem"
        Me.RenomearToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.RenomearToolStripMenuItem.Text = "Renomear..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(249, 6)
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(249, 6)
        '
        'AbrirComExplorerToolStripMenuItem
        '
        Me.AbrirComExplorerToolStripMenuItem.Name = "AbrirComExplorerToolStripMenuItem"
        Me.AbrirComExplorerToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.AbrirComExplorerToolStripMenuItem.Text = "Abrir com Explorer"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(249, 6)
        '
        'AdicionarAcoesAEstaPastaToolStripMenuItem
        '
        Me.AdicionarAcoesAEstaPastaToolStripMenuItem.Name = "AdicionarAcoesAEstaPastaToolStripMenuItem"
        Me.AdicionarAcoesAEstaPastaToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.AdicionarAcoesAEstaPastaToolStripMenuItem.Text = "Adicionar ações a esta pasta..."
        '
        'MoverParaUmGrupoToolStripMenuItem
        '
        Me.MoverParaUmGrupoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoAgrupamentoToolStripMenuItem, Me.AgrupamentoSelecionadoToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MoverParaUmGrupoToolStripMenuItem.Name = "MoverParaUmGrupoToolStripMenuItem"
        Me.MoverParaUmGrupoToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.MoverParaUmGrupoToolStripMenuItem.Text = "Mover para um grupo de ações"
        '
        'NovoAgrupamentoToolStripMenuItem
        '
        Me.NovoAgrupamentoToolStripMenuItem.Name = "NovoAgrupamentoToolStripMenuItem"
        Me.NovoAgrupamentoToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.NovoAgrupamentoToolStripMenuItem.Text = "Novo grupo de ações"
        '
        'AgrupamentoSelecionadoToolStripMenuItem
        '
        Me.AgrupamentoSelecionadoToolStripMenuItem.Name = "AgrupamentoSelecionadoToolStripMenuItem"
        Me.AgrupamentoSelecionadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgrupamentoSelecionadoToolStripMenuItem.Text = "Grupo selecionado"
        '
        'MoverParaUmaPastaComAcoesToolStripMenuItem
        '
        Me.MoverParaUmaPastaComAcoesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaPastaComAcoesToolStripMenuItem, Me.ToolStripSeparator4, Me.ToolStripMenuItem2})
        Me.MoverParaUmaPastaComAcoesToolStripMenuItem.Name = "MoverParaUmaPastaComAcoesToolStripMenuItem"
        Me.MoverParaUmaPastaComAcoesToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.MoverParaUmaPastaComAcoesToolStripMenuItem.Text = "Mover para uma pasta com ações"
        '
        'NovaPastaComAcoesToolStripMenuItem
        '
        Me.NovaPastaComAcoesToolStripMenuItem.Name = "NovaPastaComAcoesToolStripMenuItem"
        Me.NovaPastaComAcoesToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.NovaPastaComAcoesToolStripMenuItem.Text = "Nova Pasta com ações"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(190, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(193, 22)
        Me.ToolStripMenuItem2.Text = "..."
        '
        'ExecutarAcoesToolStripMenuItem
        '
        Me.ExecutarAcoesToolStripMenuItem.Image = Global.TrevoWebMedia.My.Resources.Resources.avancar_1
        Me.ExecutarAcoesToolStripMenuItem.Name = "ExecutarAcoesToolStripMenuItem"
        Me.ExecutarAcoesToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.ExecutarAcoesToolStripMenuItem.Text = "Executar ações"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(249, 6)
        '
        'PropriedadesToolStripMenuItem
        '
        Me.PropriedadesToolStripMenuItem.Name = "PropriedadesToolStripMenuItem"
        Me.PropriedadesToolStripMenuItem.Size = New System.Drawing.Size(252, 22)
        Me.PropriedadesToolStripMenuItem.Text = "Mostrar detalhes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(249, 6)
        '
        'ControlPainel_Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelBorder_TVWDesktop)
        Me.Name = "ControlPainel_Desktop"
        Me.Size = New System.Drawing.Size(324, 436)
        Me.PanelBorder_TVWDesktop.ResumeLayout(False)
        Me.PanelBorderTVW.ResumeLayout(False)
        Me.PanelBackgroundTVW.ResumeLayout(False)
        Me.PanelBorder_OpcoesDeProcessos.ResumeLayout(False)
        Me.PanelBaseLuzLeft.ResumeLayout(False)
        Me.PanelOpcoesDeProcessos.ResumeLayout(False)
        Me.Panel36.ResumeLayout(False)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.ResumeLayout(False)
        Me.PanelEnvolve_BTN_NewFolder.ResumeLayout(False)
        Me.CMItens.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TVWFilesAndFolders As TreeView
    Friend WithEvents PanelBorder_TVWDesktop As Panel
    Friend WithEvents IMGList As ImageList
    Friend WithEvents PanelBorder_OpcoesDeProcessos As Panel
    Friend WithEvents Panel36 As Panel
    Friend WithEvents PanelBorderTVW As Panel
    Friend WithEvents PanelBaseLuzLeft As Panel
    Friend WithEvents PanelEnvolve_BTN_NewFolder As Panel
    Friend WithEvents BTN_NewFolder As Button
    Friend WithEvents PanelEnvolveCHK_ShowPanelAllProcessosAcoes As Panel
    Friend WithEvents CHK_ShowCheck As CheckBox
    Friend WithEvents CMItens As ContextMenuStrip
    Friend WithEvents ExpandirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NovaPastaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarParaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarParaÁreaDeTranferênciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenomearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoverParaUmGrupoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoAgrupamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgrupamentoSelecionadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExecutarAcoesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents PropriedadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoverParaUmaPastaComAcoesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaPastaComAcoesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AdicionarAcoesAEstaPastaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents AbrirComExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As ToolStripSeparator
    Friend WithEvents PanelOpcoesDeProcessos As Panel
    Friend WithEvents PanelSombra As Panel
    Friend WithEvents PanelBackgroundTVW As Panel
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
End Class
