<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlPainel_Acoes
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Local")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("nome.arq")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Criar", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Local: (Desktop) - C:/")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Destino: (Documentos) - C:/")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Renome.jpg")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Copiar", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Local: (Desktop) - C:/")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Destino: (Music) - C:/")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Renome.mp3")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mover", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Critério")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Renomear", New System.Windows.Forms.TreeNode() {TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lixeira")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Excluir", New System.Windows.Forms.TreeNode() {TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rótulo")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Local")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gravar", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Processo 01", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode7, TreeNode11, TreeNode13, TreeNode15, TreeNode18})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPainel_Acoes))
        Me.Panel77 = New System.Windows.Forms.Panel()
        Me.PanelAllProcessosAcoes = New System.Windows.Forms.Panel()
        Me.PanelListaDeProcessos = New System.Windows.Forms.Panel()
        Me.PanelTVProcessosAcoes = New System.Windows.Forms.Panel()
        Me.TVW_ListaDeProcessos = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelAddProcesso = New System.Windows.Forms.Panel()
        Me.PanelOpcoesDeProcessos = New System.Windows.Forms.Panel()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.Panel37 = New System.Windows.Forms.Panel()
        Me.BTN_FechaPanelOpcoesDeProcessos = New System.Windows.Forms.Button()
        Me.Panel_NovoProcessoGravar = New System.Windows.Forms.Panel()
        Me.BTN_NovoProcessoGravar = New System.Windows.Forms.Button()
        Me.Panel96 = New System.Windows.Forms.Panel()
        Me.BTN_NovoProcessoExcluir = New System.Windows.Forms.Button()
        Me.Panel97 = New System.Windows.Forms.Panel()
        Me.BTN_NovoProcessoCopiar = New System.Windows.Forms.Button()
        Me.Panel101 = New System.Windows.Forms.Panel()
        Me.BTN_NovoProcessoMover = New System.Windows.Forms.Button()
        Me.Panel102 = New System.Windows.Forms.Panel()
        Me.BTN_NovoProcessoRenomear = New System.Windows.Forms.Button()
        Me.Panel94 = New System.Windows.Forms.Panel()
        Me.BTN_NovoProcessoCriar = New System.Windows.Forms.Button()
        Me.BTNAddProcesso = New System.Windows.Forms.Button()
        Me.Splitter4 = New System.Windows.Forms.Splitter()
        Me.PanelAllAgrupamentos = New System.Windows.Forms.Panel()
        Me.PanelEnvolveAgrupamentos = New System.Windows.Forms.Panel()
        Me.PanelTVAgrupamentos = New System.Windows.Forms.Panel()
        Me.Panel_ItensAGrupados = New System.Windows.Forms.Panel()
        Me.PanelEditorPropriedadesDoGrupo = New System.Windows.Forms.Panel()
        Me.PanelCorDoGrupo = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes = New System.Windows.Forms.Panel()
        Me.CHK_ShowPanelAllProcessosAcoes = New System.Windows.Forms.CheckBox()
        Me.PanelEnvolve_BTN_NewFolder = New System.Windows.Forms.Panel()
        Me.BTN_NewFolder = New System.Windows.Forms.Button()
        Me.PanelEnvolve_BTN_TimeParaAgrupamentos = New System.Windows.Forms.Panel()
        Me.BTN_TimeParaAgrupamentos = New System.Windows.Forms.Button()
        Me.Panel112 = New System.Windows.Forms.Panel()
        Me.Panel113 = New System.Windows.Forms.Panel()
        Me.Panel_SelectColorViolet = New System.Windows.Forms.Panel()
        Me.Panel205 = New System.Windows.Forms.Panel()
        Me.Panel206 = New System.Windows.Forms.Panel()
        Me.Panel_SelectColorPurple = New System.Windows.Forms.Panel()
        Me.Panel208 = New System.Windows.Forms.Panel()
        Me.Panel209 = New System.Windows.Forms.Panel()
        Me.Panel_SelectColorRed = New System.Windows.Forms.Panel()
        Me.Panel211 = New System.Windows.Forms.Panel()
        Me.Panel215 = New System.Windows.Forms.Panel()
        Me.Panel_SelectColorOrange = New System.Windows.Forms.Panel()
        Me.Panel217 = New System.Windows.Forms.Panel()
        Me.Panel218 = New System.Windows.Forms.Panel()
        Me.Panel_SelectColorYellow = New System.Windows.Forms.Panel()
        Me.Panel106 = New System.Windows.Forms.Panel()
        Me.Panel107 = New System.Windows.Forms.Panel()
        Me.Panel_SelectColorDarkGreen = New System.Windows.Forms.Panel()
        Me.Panel103 = New System.Windows.Forms.Panel()
        Me.Panel104 = New System.Windows.Forms.Panel()
        Me.Panel_SelectColorBlue = New System.Windows.Forms.Panel()
        Me.Panel109 = New System.Windows.Forms.Panel()
        Me.Panel110 = New System.Windows.Forms.Panel()
        Me.Panel_SelectColorRoyalBlue = New System.Windows.Forms.Panel()
        Me.Panel238 = New System.Windows.Forms.Panel()
        Me.Panel239 = New System.Windows.Forms.Panel()
        Me.Panel_SelectColorWhite = New System.Windows.Forms.Panel()
        Me.Panel223 = New System.Windows.Forms.Panel()
        Me.Panel232 = New System.Windows.Forms.Panel()
        Me.Panel_SelectColorGray = New System.Windows.Forms.Panel()
        Me.Panel220 = New System.Windows.Forms.Panel()
        Me.Panel221 = New System.Windows.Forms.Panel()
        Me.Panel_SelectColorBlack = New System.Windows.Forms.Panel()
        Me.Panel242 = New System.Windows.Forms.Panel()
        Me.Panel243 = New System.Windows.Forms.Panel()
        Me.LBLSelectColorNone = New System.Windows.Forms.Label()
        Me.PanelNomeDoGrupo = New System.Windows.Forms.Panel()
        Me.PanelMargemDoNomeDoGrupo = New System.Windows.Forms.Panel()
        Me.PanelFundoDoNomeDoGrupo = New System.Windows.Forms.Panel()
        Me.TXTNomeDoGrupo = New System.Windows.Forms.TextBox()
        Me.PanelME = New System.Windows.Forms.Panel()
        Me.LBLNomeDoGrupo = New System.Windows.Forms.Label()
        Me.PanelMarginDoSelectNewGroup = New System.Windows.Forms.Panel()
        Me.Panel_EnvolveBTNSelectedNewGroupType = New System.Windows.Forms.Panel()
        Me.BTNSelectedNewGroupType = New System.Windows.Forms.Button()
        Me.BTNSelectNewGroupType = New System.Windows.Forms.Button()
        Me.Panel246 = New System.Windows.Forms.Panel()
        Me.PanelExecutarProcesso = New System.Windows.Forms.Panel()
        Me.BTNPararProcessos = New System.Windows.Forms.Button()
        Me.BTNPausarProcessos = New System.Windows.Forms.Button()
        Me.BTNExecutarProcessos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelLBLAcoes = New System.Windows.Forms.Panel()
        Me.Panel247 = New System.Windows.Forms.Panel()
        Me.LBLAcoes = New System.Windows.Forms.Label()
        Me.BTNExpandAcoes = New System.Windows.Forms.Button()
        Me.CMS_TipoDeProcesso = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMenuItemTipoComposto = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenuItemSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMenuItemTipoCriacao = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenuItemTipoCopia = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenuItemSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMenuItemTipoMover = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenuItemSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMenuItemTipoRenome = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenuItemTipoGravacao = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenuItemSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSMenuItemTipoExclusao = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlItemDePainelDeAcoes3 = New TrevoWebMedia.ControlItemDePainelDeAcoes()
        Me.ControlItemDePainelDeAcoes2 = New TrevoWebMedia.ControlItemDePainelDeAcoes()
        Me.ControlItemDePainelDeAcoes1 = New TrevoWebMedia.ControlItemDePainelDeAcoes()
        Me.Panel77.SuspendLayout()
        Me.PanelAllProcessosAcoes.SuspendLayout()
        Me.PanelListaDeProcessos.SuspendLayout()
        Me.PanelTVProcessosAcoes.SuspendLayout()
        Me.PanelAddProcesso.SuspendLayout()
        Me.PanelOpcoesDeProcessos.SuspendLayout()
        Me.Panel36.SuspendLayout()
        Me.Panel37.SuspendLayout()
        Me.Panel_NovoProcessoGravar.SuspendLayout()
        Me.Panel96.SuspendLayout()
        Me.Panel97.SuspendLayout()
        Me.Panel101.SuspendLayout()
        Me.Panel102.SuspendLayout()
        Me.Panel94.SuspendLayout()
        Me.PanelAllAgrupamentos.SuspendLayout()
        Me.PanelEnvolveAgrupamentos.SuspendLayout()
        Me.PanelTVAgrupamentos.SuspendLayout()
        Me.PanelEditorPropriedadesDoGrupo.SuspendLayout()
        Me.PanelCorDoGrupo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.SuspendLayout()
        Me.PanelEnvolve_BTN_NewFolder.SuspendLayout()
        Me.PanelEnvolve_BTN_TimeParaAgrupamentos.SuspendLayout()
        Me.Panel112.SuspendLayout()
        Me.Panel113.SuspendLayout()
        Me.Panel205.SuspendLayout()
        Me.Panel206.SuspendLayout()
        Me.Panel208.SuspendLayout()
        Me.Panel209.SuspendLayout()
        Me.Panel211.SuspendLayout()
        Me.Panel215.SuspendLayout()
        Me.Panel217.SuspendLayout()
        Me.Panel218.SuspendLayout()
        Me.Panel106.SuspendLayout()
        Me.Panel107.SuspendLayout()
        Me.Panel103.SuspendLayout()
        Me.Panel104.SuspendLayout()
        Me.Panel109.SuspendLayout()
        Me.Panel110.SuspendLayout()
        Me.Panel238.SuspendLayout()
        Me.Panel239.SuspendLayout()
        Me.Panel223.SuspendLayout()
        Me.Panel232.SuspendLayout()
        Me.Panel220.SuspendLayout()
        Me.Panel221.SuspendLayout()
        Me.Panel242.SuspendLayout()
        Me.Panel243.SuspendLayout()
        Me.PanelNomeDoGrupo.SuspendLayout()
        Me.PanelMargemDoNomeDoGrupo.SuspendLayout()
        Me.PanelFundoDoNomeDoGrupo.SuspendLayout()
        Me.PanelMarginDoSelectNewGroup.SuspendLayout()
        Me.Panel_EnvolveBTNSelectedNewGroupType.SuspendLayout()
        Me.PanelExecutarProcesso.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelLBLAcoes.SuspendLayout()
        Me.Panel247.SuspendLayout()
        Me.CMS_TipoDeProcesso.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel77
        '
        Me.Panel77.BackColor = System.Drawing.Color.Transparent
        Me.Panel77.Controls.Add(Me.PanelAllProcessosAcoes)
        Me.Panel77.Controls.Add(Me.Splitter4)
        Me.Panel77.Controls.Add(Me.PanelAllAgrupamentos)
        Me.Panel77.Controls.Add(Me.PanelExecutarProcesso)
        Me.Panel77.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel77.Location = New System.Drawing.Point(0, 32)
        Me.Panel77.Name = "Panel77"
        Me.Panel77.Size = New System.Drawing.Size(468, 484)
        Me.Panel77.TabIndex = 93
        '
        'PanelAllProcessosAcoes
        '
        Me.PanelAllProcessosAcoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.PanelAllProcessosAcoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAllProcessosAcoes.Controls.Add(Me.PanelListaDeProcessos)
        Me.PanelAllProcessosAcoes.Controls.Add(Me.PanelAddProcesso)
        Me.PanelAllProcessosAcoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAllProcessosAcoes.Location = New System.Drawing.Point(0, 245)
        Me.PanelAllProcessosAcoes.Name = "PanelAllProcessosAcoes"
        Me.PanelAllProcessosAcoes.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelAllProcessosAcoes.Size = New System.Drawing.Size(468, 211)
        Me.PanelAllProcessosAcoes.TabIndex = 98
        '
        'PanelListaDeProcessos
        '
        Me.PanelListaDeProcessos.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelListaDeProcessos.Controls.Add(Me.PanelTVProcessosAcoes)
        Me.PanelListaDeProcessos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelListaDeProcessos.Location = New System.Drawing.Point(3, 52)
        Me.PanelListaDeProcessos.Name = "PanelListaDeProcessos"
        Me.PanelListaDeProcessos.Size = New System.Drawing.Size(460, 154)
        Me.PanelListaDeProcessos.TabIndex = 90
        '
        'PanelTVProcessosAcoes
        '
        Me.PanelTVProcessosAcoes.BackColor = System.Drawing.Color.Transparent
        Me.PanelTVProcessosAcoes.Controls.Add(Me.TVW_ListaDeProcessos)
        Me.PanelTVProcessosAcoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTVProcessosAcoes.Location = New System.Drawing.Point(0, 0)
        Me.PanelTVProcessosAcoes.Name = "PanelTVProcessosAcoes"
        Me.PanelTVProcessosAcoes.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelTVProcessosAcoes.Size = New System.Drawing.Size(460, 154)
        Me.PanelTVProcessosAcoes.TabIndex = 88
        '
        'TVW_ListaDeProcessos
        '
        Me.TVW_ListaDeProcessos.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TVW_ListaDeProcessos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TVW_ListaDeProcessos.CheckBoxes = True
        Me.TVW_ListaDeProcessos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVW_ListaDeProcessos.ForeColor = System.Drawing.Color.Gainsboro
        Me.TVW_ListaDeProcessos.FullRowSelect = True
        Me.TVW_ListaDeProcessos.HideSelection = False
        Me.TVW_ListaDeProcessos.ImageIndex = 0
        Me.TVW_ListaDeProcessos.ImageList = Me.ImageList1
        Me.TVW_ListaDeProcessos.Location = New System.Drawing.Point(5, 5)
        Me.TVW_ListaDeProcessos.Name = "TVW_ListaDeProcessos"
        TreeNode1.Name = "Node3"
        TreeNode1.Text = "Local"
        TreeNode2.Name = "Node0"
        TreeNode2.Text = "nome.arq"
        TreeNode3.ImageIndex = 4
        TreeNode3.Name = "Node1"
        TreeNode3.SelectedImageKey = "novo arquivo 2.png"
        TreeNode3.Text = "Criar"
        TreeNode4.Name = "Node2"
        TreeNode4.Text = "Local: (Desktop) - C:/"
        TreeNode5.Name = "Node3"
        TreeNode5.Text = "Destino: (Documentos) - C:/"
        TreeNode6.Name = "Nó0"
        TreeNode6.Text = "Renome.jpg"
        TreeNode7.ImageKey = "NovoProcessoCopiar.png"
        TreeNode7.Name = "Node1"
        TreeNode7.SelectedImageKey = "NovoProcessoCopiar.png"
        TreeNode7.Text = "Copiar"
        TreeNode8.Name = "Nó1"
        TreeNode8.Text = "Local: (Desktop) - C:/"
        TreeNode9.Name = "Node5"
        TreeNode9.Text = "Destino: (Music) - C:/"
        TreeNode10.Name = "Nó2"
        TreeNode10.Text = "Renome.mp3"
        TreeNode11.ImageKey = "NovoProcessoMover2.png"
        TreeNode11.Name = "Node4"
        TreeNode11.SelectedImageKey = "NovoProcessoMover2.png"
        TreeNode11.Text = "Mover"
        TreeNode12.Name = "Node7"
        TreeNode12.Text = "Critério"
        TreeNode13.ImageKey = "renomear.png"
        TreeNode13.Name = "Node6"
        TreeNode13.SelectedImageKey = "renomear.png"
        TreeNode13.Text = "Renomear"
        TreeNode14.Name = "Nó3"
        TreeNode14.Text = "Lixeira"
        TreeNode15.ImageKey = "excluir.png"
        TreeNode15.Name = "Node8"
        TreeNode15.SelectedImageKey = "excluir.png"
        TreeNode15.Text = "Excluir"
        TreeNode16.Name = "Nó1"
        TreeNode16.Text = "Rótulo"
        TreeNode17.Name = "Nó2"
        TreeNode17.Text = "Local"
        TreeNode18.ImageKey = "dvd.png"
        TreeNode18.Name = "Nó0"
        TreeNode18.SelectedImageKey = "dvd.png"
        TreeNode18.Text = "Gravar"
        TreeNode19.ImageKey = "processo.ico"
        TreeNode19.Name = "Node1"
        TreeNode19.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        TreeNode19.SelectedImageKey = "processo.ico"
        TreeNode19.Text = "Processo 01"
        Me.TVW_ListaDeProcessos.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode19})
        Me.TVW_ListaDeProcessos.SelectedImageIndex = 0
        Me.TVW_ListaDeProcessos.ShowLines = False
        Me.TVW_ListaDeProcessos.ShowNodeToolTips = True
        Me.TVW_ListaDeProcessos.Size = New System.Drawing.Size(450, 144)
        Me.TVW_ListaDeProcessos.TabIndex = 32
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "NovoProcessoMover2.png")
        Me.ImageList1.Images.SetKeyName(1, "NovoProcessoCopiar.png")
        Me.ImageList1.Images.SetKeyName(2, "dvd.png")
        Me.ImageList1.Images.SetKeyName(3, "excluir.png")
        Me.ImageList1.Images.SetKeyName(4, "novo arquivo 2.png")
        Me.ImageList1.Images.SetKeyName(5, "renomear.png")
        '
        'PanelAddProcesso
        '
        Me.PanelAddProcesso.AutoSize = True
        Me.PanelAddProcesso.Controls.Add(Me.PanelOpcoesDeProcessos)
        Me.PanelAddProcesso.Controls.Add(Me.BTNAddProcesso)
        Me.PanelAddProcesso.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAddProcesso.Location = New System.Drawing.Point(3, 3)
        Me.PanelAddProcesso.Name = "PanelAddProcesso"
        Me.PanelAddProcesso.Size = New System.Drawing.Size(460, 49)
        Me.PanelAddProcesso.TabIndex = 106
        '
        'PanelOpcoesDeProcessos
        '
        Me.PanelOpcoesDeProcessos.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelOpcoesDeProcessos.Controls.Add(Me.Panel36)
        Me.PanelOpcoesDeProcessos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpcoesDeProcessos.Location = New System.Drawing.Point(0, 22)
        Me.PanelOpcoesDeProcessos.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelOpcoesDeProcessos.Name = "PanelOpcoesDeProcessos"
        Me.PanelOpcoesDeProcessos.Padding = New System.Windows.Forms.Padding(5, 2, 5, 0)
        Me.PanelOpcoesDeProcessos.Size = New System.Drawing.Size(460, 27)
        Me.PanelOpcoesDeProcessos.TabIndex = 96
        Me.PanelOpcoesDeProcessos.Visible = False
        '
        'Panel36
        '
        Me.Panel36.Controls.Add(Me.Panel37)
        Me.Panel36.Controls.Add(Me.Panel_NovoProcessoGravar)
        Me.Panel36.Controls.Add(Me.Panel96)
        Me.Panel36.Controls.Add(Me.Panel97)
        Me.Panel36.Controls.Add(Me.Panel101)
        Me.Panel36.Controls.Add(Me.Panel102)
        Me.Panel36.Controls.Add(Me.Panel94)
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel36.Location = New System.Drawing.Point(5, 2)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.Panel36.Size = New System.Drawing.Size(450, 25)
        Me.Panel36.TabIndex = 0
        '
        'Panel37
        '
        Me.Panel37.Controls.Add(Me.BTN_FechaPanelOpcoesDeProcessos)
        Me.Panel37.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel37.Location = New System.Drawing.Point(437, 1)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(13, 23)
        Me.Panel37.TabIndex = 114
        '
        'BTN_FechaPanelOpcoesDeProcessos
        '
        Me.BTN_FechaPanelOpcoesDeProcessos.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_FechaPanelOpcoesDeProcessos.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.fechar_cinza
        Me.BTN_FechaPanelOpcoesDeProcessos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_FechaPanelOpcoesDeProcessos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_FechaPanelOpcoesDeProcessos.FlatAppearance.BorderSize = 0
        Me.BTN_FechaPanelOpcoesDeProcessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_FechaPanelOpcoesDeProcessos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_FechaPanelOpcoesDeProcessos.Location = New System.Drawing.Point(0, 0)
        Me.BTN_FechaPanelOpcoesDeProcessos.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_FechaPanelOpcoesDeProcessos.Name = "BTN_FechaPanelOpcoesDeProcessos"
        Me.BTN_FechaPanelOpcoesDeProcessos.Size = New System.Drawing.Size(13, 20)
        Me.BTN_FechaPanelOpcoesDeProcessos.TabIndex = 31
        Me.BTN_FechaPanelOpcoesDeProcessos.UseVisualStyleBackColor = False
        '
        'Panel_NovoProcessoGravar
        '
        Me.Panel_NovoProcessoGravar.Controls.Add(Me.BTN_NovoProcessoGravar)
        Me.Panel_NovoProcessoGravar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_NovoProcessoGravar.Location = New System.Drawing.Point(110, 1)
        Me.Panel_NovoProcessoGravar.Name = "Panel_NovoProcessoGravar"
        Me.Panel_NovoProcessoGravar.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel_NovoProcessoGravar.Size = New System.Drawing.Size(19, 23)
        Me.Panel_NovoProcessoGravar.TabIndex = 112
        '
        'BTN_NovoProcessoGravar
        '
        Me.BTN_NovoProcessoGravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NovoProcessoGravar.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.dvd
        Me.BTN_NovoProcessoGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NovoProcessoGravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NovoProcessoGravar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NovoProcessoGravar.FlatAppearance.BorderSize = 0
        Me.BTN_NovoProcessoGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NovoProcessoGravar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_NovoProcessoGravar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NovoProcessoGravar.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NovoProcessoGravar.Name = "BTN_NovoProcessoGravar"
        Me.BTN_NovoProcessoGravar.Size = New System.Drawing.Size(17, 21)
        Me.BTN_NovoProcessoGravar.TabIndex = 29
        Me.BTN_NovoProcessoGravar.UseVisualStyleBackColor = False
        '
        'Panel96
        '
        Me.Panel96.Controls.Add(Me.BTN_NovoProcessoExcluir)
        Me.Panel96.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel96.Location = New System.Drawing.Point(92, 1)
        Me.Panel96.Name = "Panel96"
        Me.Panel96.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel96.Size = New System.Drawing.Size(18, 23)
        Me.Panel96.TabIndex = 111
        '
        'BTN_NovoProcessoExcluir
        '
        Me.BTN_NovoProcessoExcluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NovoProcessoExcluir.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.excluir
        Me.BTN_NovoProcessoExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NovoProcessoExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NovoProcessoExcluir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NovoProcessoExcluir.FlatAppearance.BorderSize = 0
        Me.BTN_NovoProcessoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NovoProcessoExcluir.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_NovoProcessoExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NovoProcessoExcluir.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NovoProcessoExcluir.Name = "BTN_NovoProcessoExcluir"
        Me.BTN_NovoProcessoExcluir.Size = New System.Drawing.Size(16, 21)
        Me.BTN_NovoProcessoExcluir.TabIndex = 28
        Me.BTN_NovoProcessoExcluir.UseVisualStyleBackColor = False
        '
        'Panel97
        '
        Me.Panel97.Controls.Add(Me.BTN_NovoProcessoCopiar)
        Me.Panel97.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel97.Location = New System.Drawing.Point(69, 1)
        Me.Panel97.Name = "Panel97"
        Me.Panel97.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel97.Size = New System.Drawing.Size(23, 23)
        Me.Panel97.TabIndex = 110
        '
        'BTN_NovoProcessoCopiar
        '
        Me.BTN_NovoProcessoCopiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NovoProcessoCopiar.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.NovoProcessoCopiar
        Me.BTN_NovoProcessoCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NovoProcessoCopiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NovoProcessoCopiar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NovoProcessoCopiar.FlatAppearance.BorderSize = 0
        Me.BTN_NovoProcessoCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NovoProcessoCopiar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_NovoProcessoCopiar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NovoProcessoCopiar.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NovoProcessoCopiar.Name = "BTN_NovoProcessoCopiar"
        Me.BTN_NovoProcessoCopiar.Size = New System.Drawing.Size(21, 21)
        Me.BTN_NovoProcessoCopiar.TabIndex = 27
        Me.BTN_NovoProcessoCopiar.UseVisualStyleBackColor = False
        '
        'Panel101
        '
        Me.Panel101.Controls.Add(Me.BTN_NovoProcessoMover)
        Me.Panel101.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel101.Location = New System.Drawing.Point(46, 1)
        Me.Panel101.Name = "Panel101"
        Me.Panel101.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel101.Size = New System.Drawing.Size(23, 23)
        Me.Panel101.TabIndex = 109
        '
        'BTN_NovoProcessoMover
        '
        Me.BTN_NovoProcessoMover.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NovoProcessoMover.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.NovoProcessoMover2
        Me.BTN_NovoProcessoMover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NovoProcessoMover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NovoProcessoMover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NovoProcessoMover.FlatAppearance.BorderSize = 0
        Me.BTN_NovoProcessoMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NovoProcessoMover.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_NovoProcessoMover.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NovoProcessoMover.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NovoProcessoMover.Name = "BTN_NovoProcessoMover"
        Me.BTN_NovoProcessoMover.Size = New System.Drawing.Size(21, 21)
        Me.BTN_NovoProcessoMover.TabIndex = 26
        Me.BTN_NovoProcessoMover.UseVisualStyleBackColor = False
        '
        'Panel102
        '
        Me.Panel102.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel102.Controls.Add(Me.BTN_NovoProcessoRenomear)
        Me.Panel102.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel102.Location = New System.Drawing.Point(23, 1)
        Me.Panel102.Name = "Panel102"
        Me.Panel102.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel102.Size = New System.Drawing.Size(23, 23)
        Me.Panel102.TabIndex = 108
        '
        'BTN_NovoProcessoRenomear
        '
        Me.BTN_NovoProcessoRenomear.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NovoProcessoRenomear.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.renomear
        Me.BTN_NovoProcessoRenomear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NovoProcessoRenomear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NovoProcessoRenomear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NovoProcessoRenomear.FlatAppearance.BorderSize = 0
        Me.BTN_NovoProcessoRenomear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NovoProcessoRenomear.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_NovoProcessoRenomear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NovoProcessoRenomear.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NovoProcessoRenomear.Name = "BTN_NovoProcessoRenomear"
        Me.BTN_NovoProcessoRenomear.Size = New System.Drawing.Size(21, 21)
        Me.BTN_NovoProcessoRenomear.TabIndex = 25
        Me.BTN_NovoProcessoRenomear.UseVisualStyleBackColor = False
        '
        'Panel94
        '
        Me.Panel94.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel94.Controls.Add(Me.BTN_NovoProcessoCriar)
        Me.Panel94.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel94.Location = New System.Drawing.Point(0, 1)
        Me.Panel94.Name = "Panel94"
        Me.Panel94.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel94.Size = New System.Drawing.Size(23, 23)
        Me.Panel94.TabIndex = 113
        '
        'BTN_NovoProcessoCriar
        '
        Me.BTN_NovoProcessoCriar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_NovoProcessoCriar.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.novo_arquivo_2
        Me.BTN_NovoProcessoCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_NovoProcessoCriar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NovoProcessoCriar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_NovoProcessoCriar.FlatAppearance.BorderSize = 0
        Me.BTN_NovoProcessoCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NovoProcessoCriar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_NovoProcessoCriar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_NovoProcessoCriar.Location = New System.Drawing.Point(1, 1)
        Me.BTN_NovoProcessoCriar.Name = "BTN_NovoProcessoCriar"
        Me.BTN_NovoProcessoCriar.Size = New System.Drawing.Size(21, 21)
        Me.BTN_NovoProcessoCriar.TabIndex = 30
        Me.BTN_NovoProcessoCriar.UseVisualStyleBackColor = False
        '
        'BTNAddProcesso
        '
        Me.BTNAddProcesso.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTNAddProcesso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNAddProcesso.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNAddProcesso.FlatAppearance.BorderSize = 0
        Me.BTNAddProcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNAddProcesso.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTNAddProcesso.Image = Global.TrevoWebMedia.My.Resources.Resources.add5
        Me.BTNAddProcesso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNAddProcesso.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNAddProcesso.Location = New System.Drawing.Point(0, 0)
        Me.BTNAddProcesso.Name = "BTNAddProcesso"
        Me.BTNAddProcesso.Size = New System.Drawing.Size(460, 22)
        Me.BTNAddProcesso.TabIndex = 24
        Me.BTNAddProcesso.Text = "         Adcionar um processo"
        Me.BTNAddProcesso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNAddProcesso.UseVisualStyleBackColor = False
        '
        'Splitter4
        '
        Me.Splitter4.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Splitter4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Splitter4.Location = New System.Drawing.Point(0, 240)
        Me.Splitter4.Name = "Splitter4"
        Me.Splitter4.Size = New System.Drawing.Size(468, 5)
        Me.Splitter4.TabIndex = 23
        Me.Splitter4.TabStop = False
        '
        'PanelAllAgrupamentos
        '
        Me.PanelAllAgrupamentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.PanelAllAgrupamentos.Controls.Add(Me.PanelEnvolveAgrupamentos)
        Me.PanelAllAgrupamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAllAgrupamentos.Location = New System.Drawing.Point(0, 0)
        Me.PanelAllAgrupamentos.Name = "PanelAllAgrupamentos"
        Me.PanelAllAgrupamentos.Padding = New System.Windows.Forms.Padding(2, 0, 2, 2)
        Me.PanelAllAgrupamentos.Size = New System.Drawing.Size(468, 240)
        Me.PanelAllAgrupamentos.TabIndex = 96
        '
        'PanelEnvolveAgrupamentos
        '
        Me.PanelEnvolveAgrupamentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelEnvolveAgrupamentos.Controls.Add(Me.PanelTVAgrupamentos)
        Me.PanelEnvolveAgrupamentos.Controls.Add(Me.PanelEditorPropriedadesDoGrupo)
        Me.PanelEnvolveAgrupamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolveAgrupamentos.Location = New System.Drawing.Point(2, 0)
        Me.PanelEnvolveAgrupamentos.Name = "PanelEnvolveAgrupamentos"
        Me.PanelEnvolveAgrupamentos.Size = New System.Drawing.Size(464, 238)
        Me.PanelEnvolveAgrupamentos.TabIndex = 90
        '
        'PanelTVAgrupamentos
        '
        Me.PanelTVAgrupamentos.BackColor = System.Drawing.Color.Transparent
        Me.PanelTVAgrupamentos.Controls.Add(Me.Panel_ItensAGrupados)
        Me.PanelTVAgrupamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTVAgrupamentos.Location = New System.Drawing.Point(0, 44)
        Me.PanelTVAgrupamentos.Name = "PanelTVAgrupamentos"
        Me.PanelTVAgrupamentos.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelTVAgrupamentos.Size = New System.Drawing.Size(464, 194)
        Me.PanelTVAgrupamentos.TabIndex = 88
        '
        'Panel_ItensAGrupados
        '
        Me.Panel_ItensAGrupados.AutoScroll = True
        Me.Panel_ItensAGrupados.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel_ItensAGrupados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_ItensAGrupados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_ItensAGrupados.Location = New System.Drawing.Point(5, 5)
        Me.Panel_ItensAGrupados.Name = "Panel_ItensAGrupados"
        Me.Panel_ItensAGrupados.Size = New System.Drawing.Size(454, 184)
        Me.Panel_ItensAGrupados.TabIndex = 22
        '
        'PanelEditorPropriedadesDoGrupo
        '
        Me.PanelEditorPropriedadesDoGrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelEditorPropriedadesDoGrupo.Controls.Add(Me.PanelCorDoGrupo)
        Me.PanelEditorPropriedadesDoGrupo.Controls.Add(Me.PanelNomeDoGrupo)
        Me.PanelEditorPropriedadesDoGrupo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEditorPropriedadesDoGrupo.Location = New System.Drawing.Point(0, 0)
        Me.PanelEditorPropriedadesDoGrupo.Name = "PanelEditorPropriedadesDoGrupo"
        Me.PanelEditorPropriedadesDoGrupo.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.PanelEditorPropriedadesDoGrupo.Size = New System.Drawing.Size(464, 44)
        Me.PanelEditorPropriedadesDoGrupo.TabIndex = 98
        '
        'PanelCorDoGrupo
        '
        Me.PanelCorDoGrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel1)
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel112)
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel205)
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel208)
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel211)
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel217)
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel106)
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel103)
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel109)
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel238)
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel223)
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel220)
        Me.PanelCorDoGrupo.Controls.Add(Me.Panel242)
        Me.PanelCorDoGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCorDoGrupo.Location = New System.Drawing.Point(0, 23)
        Me.PanelCorDoGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCorDoGrupo.Name = "PanelCorDoGrupo"
        Me.PanelCorDoGrupo.Padding = New System.Windows.Forms.Padding(6, 2, 5, 0)
        Me.PanelCorDoGrupo.Size = New System.Drawing.Size(464, 21)
        Me.PanelCorDoGrupo.TabIndex = 95
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes)
        Me.Panel1.Controls.Add(Me.PanelEnvolve_BTN_NewFolder)
        Me.Panel1.Controls.Add(Me.PanelEnvolve_BTN_TimeParaAgrupamentos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(357, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(102, 19)
        Me.Panel1.TabIndex = 115
        '
        'PanelEnvolveCHK_ShowPanelAllProcessosAcoes
        '
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Controls.Add(Me.CHK_ShowPanelAllProcessosAcoes)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Location = New System.Drawing.Point(6, 0)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Name = "PanelEnvolveCHK_ShowPanelAllProcessosAcoes"
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.Size = New System.Drawing.Size(32, 19)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.TabIndex = 112
        '
        'CHK_ShowPanelAllProcessosAcoes
        '
        Me.CHK_ShowPanelAllProcessosAcoes.Appearance = System.Windows.Forms.Appearance.Button
        Me.CHK_ShowPanelAllProcessosAcoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CHK_ShowPanelAllProcessosAcoes.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.Exibir_painel_de_processos
        Me.CHK_ShowPanelAllProcessosAcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CHK_ShowPanelAllProcessosAcoes.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CHK_ShowPanelAllProcessosAcoes.Checked = True
        Me.CHK_ShowPanelAllProcessosAcoes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHK_ShowPanelAllProcessosAcoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CHK_ShowPanelAllProcessosAcoes.FlatAppearance.BorderSize = 0
        Me.CHK_ShowPanelAllProcessosAcoes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.CHK_ShowPanelAllProcessosAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CHK_ShowPanelAllProcessosAcoes.Location = New System.Drawing.Point(1, 1)
        Me.CHK_ShowPanelAllProcessosAcoes.Name = "CHK_ShowPanelAllProcessosAcoes"
        Me.CHK_ShowPanelAllProcessosAcoes.Size = New System.Drawing.Size(30, 17)
        Me.CHK_ShowPanelAllProcessosAcoes.TabIndex = 19
        Me.CHK_ShowPanelAllProcessosAcoes.UseVisualStyleBackColor = False
        '
        'PanelEnvolve_BTN_NewFolder
        '
        Me.PanelEnvolve_BTN_NewFolder.Controls.Add(Me.BTN_NewFolder)
        Me.PanelEnvolve_BTN_NewFolder.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelEnvolve_BTN_NewFolder.Location = New System.Drawing.Point(38, 0)
        Me.PanelEnvolve_BTN_NewFolder.Name = "PanelEnvolve_BTN_NewFolder"
        Me.PanelEnvolve_BTN_NewFolder.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelEnvolve_BTN_NewFolder.Size = New System.Drawing.Size(32, 19)
        Me.PanelEnvolve_BTN_NewFolder.TabIndex = 113
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
        Me.BTN_NewFolder.Size = New System.Drawing.Size(30, 17)
        Me.BTN_NewFolder.TabIndex = 20
        Me.BTN_NewFolder.UseVisualStyleBackColor = False
        '
        'PanelEnvolve_BTN_TimeParaAgrupamentos
        '
        Me.PanelEnvolve_BTN_TimeParaAgrupamentos.Controls.Add(Me.BTN_TimeParaAgrupamentos)
        Me.PanelEnvolve_BTN_TimeParaAgrupamentos.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelEnvolve_BTN_TimeParaAgrupamentos.Location = New System.Drawing.Point(70, 0)
        Me.PanelEnvolve_BTN_TimeParaAgrupamentos.Name = "PanelEnvolve_BTN_TimeParaAgrupamentos"
        Me.PanelEnvolve_BTN_TimeParaAgrupamentos.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelEnvolve_BTN_TimeParaAgrupamentos.Size = New System.Drawing.Size(32, 19)
        Me.PanelEnvolve_BTN_TimeParaAgrupamentos.TabIndex = 114
        '
        'BTN_TimeParaAgrupamentos
        '
        Me.BTN_TimeParaAgrupamentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTN_TimeParaAgrupamentos.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.time2
        Me.BTN_TimeParaAgrupamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_TimeParaAgrupamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_TimeParaAgrupamentos.FlatAppearance.BorderSize = 0
        Me.BTN_TimeParaAgrupamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_TimeParaAgrupamentos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_TimeParaAgrupamentos.Location = New System.Drawing.Point(1, 1)
        Me.BTN_TimeParaAgrupamentos.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_TimeParaAgrupamentos.Name = "BTN_TimeParaAgrupamentos"
        Me.BTN_TimeParaAgrupamentos.Size = New System.Drawing.Size(30, 17)
        Me.BTN_TimeParaAgrupamentos.TabIndex = 21
        Me.BTN_TimeParaAgrupamentos.UseVisualStyleBackColor = False
        '
        'Panel112
        '
        Me.Panel112.Controls.Add(Me.Panel113)
        Me.Panel112.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel112.Location = New System.Drawing.Point(171, 2)
        Me.Panel112.Name = "Panel112"
        Me.Panel112.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel112.Size = New System.Drawing.Size(15, 19)
        Me.Panel112.TabIndex = 111
        '
        'Panel113
        '
        Me.Panel113.BackColor = System.Drawing.Color.Transparent
        Me.Panel113.Controls.Add(Me.Panel_SelectColorViolet)
        Me.Panel113.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel113.Location = New System.Drawing.Point(1, 3)
        Me.Panel113.Name = "Panel113"
        Me.Panel113.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel113.Size = New System.Drawing.Size(13, 13)
        Me.Panel113.TabIndex = 104
        '
        'Panel_SelectColorViolet
        '
        Me.Panel_SelectColorViolet.BackColor = System.Drawing.Color.Violet
        Me.Panel_SelectColorViolet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_SelectColorViolet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_SelectColorViolet.Location = New System.Drawing.Point(1, 1)
        Me.Panel_SelectColorViolet.Name = "Panel_SelectColorViolet"
        Me.Panel_SelectColorViolet.Size = New System.Drawing.Size(11, 11)
        Me.Panel_SelectColorViolet.TabIndex = 15
        Me.Panel_SelectColorViolet.Tag = "Violet"
        '
        'Panel205
        '
        Me.Panel205.Controls.Add(Me.Panel206)
        Me.Panel205.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel205.Location = New System.Drawing.Point(156, 2)
        Me.Panel205.Name = "Panel205"
        Me.Panel205.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel205.Size = New System.Drawing.Size(15, 19)
        Me.Panel205.TabIndex = 107
        '
        'Panel206
        '
        Me.Panel206.BackColor = System.Drawing.Color.Transparent
        Me.Panel206.Controls.Add(Me.Panel_SelectColorPurple)
        Me.Panel206.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel206.Location = New System.Drawing.Point(1, 3)
        Me.Panel206.Name = "Panel206"
        Me.Panel206.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel206.Size = New System.Drawing.Size(13, 13)
        Me.Panel206.TabIndex = 103
        '
        'Panel_SelectColorPurple
        '
        Me.Panel_SelectColorPurple.BackColor = System.Drawing.Color.Purple
        Me.Panel_SelectColorPurple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_SelectColorPurple.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_SelectColorPurple.Location = New System.Drawing.Point(1, 1)
        Me.Panel_SelectColorPurple.Name = "Panel_SelectColorPurple"
        Me.Panel_SelectColorPurple.Size = New System.Drawing.Size(11, 11)
        Me.Panel_SelectColorPurple.TabIndex = 14
        '
        'Panel208
        '
        Me.Panel208.Controls.Add(Me.Panel209)
        Me.Panel208.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel208.Location = New System.Drawing.Point(141, 2)
        Me.Panel208.Name = "Panel208"
        Me.Panel208.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel208.Size = New System.Drawing.Size(15, 19)
        Me.Panel208.TabIndex = 106
        '
        'Panel209
        '
        Me.Panel209.BackColor = System.Drawing.Color.Transparent
        Me.Panel209.Controls.Add(Me.Panel_SelectColorRed)
        Me.Panel209.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel209.Location = New System.Drawing.Point(1, 3)
        Me.Panel209.Name = "Panel209"
        Me.Panel209.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel209.Size = New System.Drawing.Size(13, 13)
        Me.Panel209.TabIndex = 103
        '
        'Panel_SelectColorRed
        '
        Me.Panel_SelectColorRed.BackColor = System.Drawing.Color.Red
        Me.Panel_SelectColorRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_SelectColorRed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_SelectColorRed.Location = New System.Drawing.Point(1, 1)
        Me.Panel_SelectColorRed.Name = "Panel_SelectColorRed"
        Me.Panel_SelectColorRed.Size = New System.Drawing.Size(11, 11)
        Me.Panel_SelectColorRed.TabIndex = 13
        '
        'Panel211
        '
        Me.Panel211.Controls.Add(Me.Panel215)
        Me.Panel211.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel211.Location = New System.Drawing.Point(126, 2)
        Me.Panel211.Name = "Panel211"
        Me.Panel211.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel211.Size = New System.Drawing.Size(15, 19)
        Me.Panel211.TabIndex = 105
        '
        'Panel215
        '
        Me.Panel215.BackColor = System.Drawing.Color.Transparent
        Me.Panel215.Controls.Add(Me.Panel_SelectColorOrange)
        Me.Panel215.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel215.Location = New System.Drawing.Point(1, 3)
        Me.Panel215.Name = "Panel215"
        Me.Panel215.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel215.Size = New System.Drawing.Size(13, 13)
        Me.Panel215.TabIndex = 102
        '
        'Panel_SelectColorOrange
        '
        Me.Panel_SelectColorOrange.BackColor = System.Drawing.Color.Orange
        Me.Panel_SelectColorOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_SelectColorOrange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_SelectColorOrange.Location = New System.Drawing.Point(1, 1)
        Me.Panel_SelectColorOrange.Name = "Panel_SelectColorOrange"
        Me.Panel_SelectColorOrange.Size = New System.Drawing.Size(11, 11)
        Me.Panel_SelectColorOrange.TabIndex = 12
        '
        'Panel217
        '
        Me.Panel217.Controls.Add(Me.Panel218)
        Me.Panel217.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel217.Location = New System.Drawing.Point(111, 2)
        Me.Panel217.Name = "Panel217"
        Me.Panel217.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel217.Size = New System.Drawing.Size(15, 19)
        Me.Panel217.TabIndex = 104
        '
        'Panel218
        '
        Me.Panel218.BackColor = System.Drawing.Color.Transparent
        Me.Panel218.Controls.Add(Me.Panel_SelectColorYellow)
        Me.Panel218.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel218.Location = New System.Drawing.Point(1, 3)
        Me.Panel218.Name = "Panel218"
        Me.Panel218.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel218.Size = New System.Drawing.Size(13, 13)
        Me.Panel218.TabIndex = 101
        '
        'Panel_SelectColorYellow
        '
        Me.Panel_SelectColorYellow.BackColor = System.Drawing.Color.Yellow
        Me.Panel_SelectColorYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_SelectColorYellow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_SelectColorYellow.Location = New System.Drawing.Point(1, 1)
        Me.Panel_SelectColorYellow.Name = "Panel_SelectColorYellow"
        Me.Panel_SelectColorYellow.Size = New System.Drawing.Size(11, 11)
        Me.Panel_SelectColorYellow.TabIndex = 11
        '
        'Panel106
        '
        Me.Panel106.Controls.Add(Me.Panel107)
        Me.Panel106.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel106.Location = New System.Drawing.Point(96, 2)
        Me.Panel106.Name = "Panel106"
        Me.Panel106.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel106.Size = New System.Drawing.Size(15, 19)
        Me.Panel106.TabIndex = 109
        '
        'Panel107
        '
        Me.Panel107.BackColor = System.Drawing.Color.Transparent
        Me.Panel107.Controls.Add(Me.Panel_SelectColorDarkGreen)
        Me.Panel107.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel107.Location = New System.Drawing.Point(1, 3)
        Me.Panel107.Name = "Panel107"
        Me.Panel107.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel107.Size = New System.Drawing.Size(13, 13)
        Me.Panel107.TabIndex = 106
        '
        'Panel_SelectColorDarkGreen
        '
        Me.Panel_SelectColorDarkGreen.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel_SelectColorDarkGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_SelectColorDarkGreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_SelectColorDarkGreen.Location = New System.Drawing.Point(1, 1)
        Me.Panel_SelectColorDarkGreen.Name = "Panel_SelectColorDarkGreen"
        Me.Panel_SelectColorDarkGreen.Size = New System.Drawing.Size(11, 11)
        Me.Panel_SelectColorDarkGreen.TabIndex = 17
        '
        'Panel103
        '
        Me.Panel103.Controls.Add(Me.Panel104)
        Me.Panel103.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel103.Location = New System.Drawing.Point(81, 2)
        Me.Panel103.Name = "Panel103"
        Me.Panel103.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel103.Size = New System.Drawing.Size(15, 19)
        Me.Panel103.TabIndex = 108
        '
        'Panel104
        '
        Me.Panel104.BackColor = System.Drawing.Color.Transparent
        Me.Panel104.Controls.Add(Me.Panel_SelectColorBlue)
        Me.Panel104.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel104.Location = New System.Drawing.Point(1, 3)
        Me.Panel104.Name = "Panel104"
        Me.Panel104.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel104.Size = New System.Drawing.Size(13, 13)
        Me.Panel104.TabIndex = 107
        '
        'Panel_SelectColorBlue
        '
        Me.Panel_SelectColorBlue.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel_SelectColorBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_SelectColorBlue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_SelectColorBlue.Location = New System.Drawing.Point(1, 1)
        Me.Panel_SelectColorBlue.Name = "Panel_SelectColorBlue"
        Me.Panel_SelectColorBlue.Size = New System.Drawing.Size(11, 11)
        Me.Panel_SelectColorBlue.TabIndex = 18
        '
        'Panel109
        '
        Me.Panel109.Controls.Add(Me.Panel110)
        Me.Panel109.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel109.Location = New System.Drawing.Point(66, 2)
        Me.Panel109.Name = "Panel109"
        Me.Panel109.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel109.Size = New System.Drawing.Size(15, 19)
        Me.Panel109.TabIndex = 110
        '
        'Panel110
        '
        Me.Panel110.BackColor = System.Drawing.Color.Transparent
        Me.Panel110.Controls.Add(Me.Panel_SelectColorRoyalBlue)
        Me.Panel110.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel110.Location = New System.Drawing.Point(1, 3)
        Me.Panel110.Name = "Panel110"
        Me.Panel110.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel110.Size = New System.Drawing.Size(13, 13)
        Me.Panel110.TabIndex = 105
        '
        'Panel_SelectColorRoyalBlue
        '
        Me.Panel_SelectColorRoyalBlue.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel_SelectColorRoyalBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_SelectColorRoyalBlue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_SelectColorRoyalBlue.Location = New System.Drawing.Point(1, 1)
        Me.Panel_SelectColorRoyalBlue.Name = "Panel_SelectColorRoyalBlue"
        Me.Panel_SelectColorRoyalBlue.Size = New System.Drawing.Size(11, 11)
        Me.Panel_SelectColorRoyalBlue.TabIndex = 16
        '
        'Panel238
        '
        Me.Panel238.Controls.Add(Me.Panel239)
        Me.Panel238.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel238.Location = New System.Drawing.Point(51, 2)
        Me.Panel238.Name = "Panel238"
        Me.Panel238.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel238.Size = New System.Drawing.Size(15, 19)
        Me.Panel238.TabIndex = 102
        '
        'Panel239
        '
        Me.Panel239.BackColor = System.Drawing.Color.Transparent
        Me.Panel239.Controls.Add(Me.Panel_SelectColorWhite)
        Me.Panel239.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel239.Location = New System.Drawing.Point(1, 3)
        Me.Panel239.Name = "Panel239"
        Me.Panel239.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel239.Size = New System.Drawing.Size(13, 13)
        Me.Panel239.TabIndex = 0
        '
        'Panel_SelectColorWhite
        '
        Me.Panel_SelectColorWhite.BackColor = System.Drawing.Color.White
        Me.Panel_SelectColorWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_SelectColorWhite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_SelectColorWhite.Location = New System.Drawing.Point(1, 1)
        Me.Panel_SelectColorWhite.Name = "Panel_SelectColorWhite"
        Me.Panel_SelectColorWhite.Size = New System.Drawing.Size(11, 11)
        Me.Panel_SelectColorWhite.TabIndex = 8
        '
        'Panel223
        '
        Me.Panel223.Controls.Add(Me.Panel232)
        Me.Panel223.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel223.Location = New System.Drawing.Point(36, 2)
        Me.Panel223.Name = "Panel223"
        Me.Panel223.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel223.Size = New System.Drawing.Size(15, 19)
        Me.Panel223.TabIndex = 101
        '
        'Panel232
        '
        Me.Panel232.BackColor = System.Drawing.Color.Transparent
        Me.Panel232.Controls.Add(Me.Panel_SelectColorGray)
        Me.Panel232.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel232.Location = New System.Drawing.Point(1, 3)
        Me.Panel232.Name = "Panel232"
        Me.Panel232.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel232.Size = New System.Drawing.Size(13, 13)
        Me.Panel232.TabIndex = 99
        '
        'Panel_SelectColorGray
        '
        Me.Panel_SelectColorGray.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel_SelectColorGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_SelectColorGray.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_SelectColorGray.Location = New System.Drawing.Point(1, 1)
        Me.Panel_SelectColorGray.Name = "Panel_SelectColorGray"
        Me.Panel_SelectColorGray.Size = New System.Drawing.Size(11, 11)
        Me.Panel_SelectColorGray.TabIndex = 9
        '
        'Panel220
        '
        Me.Panel220.Controls.Add(Me.Panel221)
        Me.Panel220.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel220.Location = New System.Drawing.Point(21, 2)
        Me.Panel220.Name = "Panel220"
        Me.Panel220.Padding = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.Panel220.Size = New System.Drawing.Size(15, 19)
        Me.Panel220.TabIndex = 103
        '
        'Panel221
        '
        Me.Panel221.BackColor = System.Drawing.Color.Transparent
        Me.Panel221.Controls.Add(Me.Panel_SelectColorBlack)
        Me.Panel221.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel221.Location = New System.Drawing.Point(1, 3)
        Me.Panel221.Name = "Panel221"
        Me.Panel221.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel221.Size = New System.Drawing.Size(13, 13)
        Me.Panel221.TabIndex = 100
        '
        'Panel_SelectColorBlack
        '
        Me.Panel_SelectColorBlack.BackColor = System.Drawing.Color.Black
        Me.Panel_SelectColorBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_SelectColorBlack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_SelectColorBlack.Location = New System.Drawing.Point(1, 1)
        Me.Panel_SelectColorBlack.Name = "Panel_SelectColorBlack"
        Me.Panel_SelectColorBlack.Size = New System.Drawing.Size(11, 11)
        Me.Panel_SelectColorBlack.TabIndex = 10
        '
        'Panel242
        '
        Me.Panel242.Controls.Add(Me.Panel243)
        Me.Panel242.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel242.Location = New System.Drawing.Point(6, 2)
        Me.Panel242.Name = "Panel242"
        Me.Panel242.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel242.Size = New System.Drawing.Size(15, 19)
        Me.Panel242.TabIndex = 100
        '
        'Panel243
        '
        Me.Panel243.BackColor = System.Drawing.Color.Transparent
        Me.Panel243.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel243.Controls.Add(Me.LBLSelectColorNone)
        Me.Panel243.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel243.Location = New System.Drawing.Point(1, 1)
        Me.Panel243.Name = "Panel243"
        Me.Panel243.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel243.Size = New System.Drawing.Size(13, 17)
        Me.Panel243.TabIndex = 10
        '
        'LBLSelectColorNone
        '
        Me.LBLSelectColorNone.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LBLSelectColorNone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBLSelectColorNone.Font = New System.Drawing.Font("Microsoft Tai Le", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSelectColorNone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LBLSelectColorNone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LBLSelectColorNone.Location = New System.Drawing.Point(1, 1)
        Me.LBLSelectColorNone.Name = "LBLSelectColorNone"
        Me.LBLSelectColorNone.Size = New System.Drawing.Size(9, 13)
        Me.LBLSelectColorNone.TabIndex = 7
        Me.LBLSelectColorNone.Text = "x"
        '
        'PanelNomeDoGrupo
        '
        Me.PanelNomeDoGrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelNomeDoGrupo.Controls.Add(Me.PanelMargemDoNomeDoGrupo)
        Me.PanelNomeDoGrupo.Controls.Add(Me.PanelME)
        Me.PanelNomeDoGrupo.Controls.Add(Me.LBLNomeDoGrupo)
        Me.PanelNomeDoGrupo.Controls.Add(Me.PanelMarginDoSelectNewGroup)
        Me.PanelNomeDoGrupo.Controls.Add(Me.Panel246)
        Me.PanelNomeDoGrupo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelNomeDoGrupo.Location = New System.Drawing.Point(0, 1)
        Me.PanelNomeDoGrupo.Name = "PanelNomeDoGrupo"
        Me.PanelNomeDoGrupo.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.PanelNomeDoGrupo.Size = New System.Drawing.Size(464, 22)
        Me.PanelNomeDoGrupo.TabIndex = 96
        '
        'PanelMargemDoNomeDoGrupo
        '
        Me.PanelMargemDoNomeDoGrupo.BackColor = System.Drawing.Color.DimGray
        Me.PanelMargemDoNomeDoGrupo.Controls.Add(Me.PanelFundoDoNomeDoGrupo)
        Me.PanelMargemDoNomeDoGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMargemDoNomeDoGrupo.Location = New System.Drawing.Point(45, 3)
        Me.PanelMargemDoNomeDoGrupo.Name = "PanelMargemDoNomeDoGrupo"
        Me.PanelMargemDoNomeDoGrupo.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelMargemDoNomeDoGrupo.Size = New System.Drawing.Size(366, 19)
        Me.PanelMargemDoNomeDoGrupo.TabIndex = 99
        '
        'PanelFundoDoNomeDoGrupo
        '
        Me.PanelFundoDoNomeDoGrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelFundoDoNomeDoGrupo.Controls.Add(Me.TXTNomeDoGrupo)
        Me.PanelFundoDoNomeDoGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFundoDoNomeDoGrupo.Location = New System.Drawing.Point(1, 1)
        Me.PanelFundoDoNomeDoGrupo.Name = "PanelFundoDoNomeDoGrupo"
        Me.PanelFundoDoNomeDoGrupo.Padding = New System.Windows.Forms.Padding(8, 2, 2, 2)
        Me.PanelFundoDoNomeDoGrupo.Size = New System.Drawing.Size(364, 17)
        Me.PanelFundoDoNomeDoGrupo.TabIndex = 6
        '
        'TXTNomeDoGrupo
        '
        Me.TXTNomeDoGrupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTNomeDoGrupo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTNomeDoGrupo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TXTNomeDoGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTNomeDoGrupo.ForeColor = System.Drawing.Color.Gainsboro
        Me.TXTNomeDoGrupo.Location = New System.Drawing.Point(8, 2)
        Me.TXTNomeDoGrupo.Name = "TXTNomeDoGrupo"
        Me.TXTNomeDoGrupo.Size = New System.Drawing.Size(354, 13)
        Me.TXTNomeDoGrupo.TabIndex = 4
        Me.TXTNomeDoGrupo.Text = "Agrupamento 01"
        '
        'PanelME
        '
        Me.PanelME.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelME.Location = New System.Drawing.Point(411, 3)
        Me.PanelME.Name = "PanelME"
        Me.PanelME.Size = New System.Drawing.Size(2, 19)
        Me.PanelME.TabIndex = 112
        '
        'LBLNomeDoGrupo
        '
        Me.LBLNomeDoGrupo.AutoSize = True
        Me.LBLNomeDoGrupo.Dock = System.Windows.Forms.DockStyle.Left
        Me.LBLNomeDoGrupo.ForeColor = System.Drawing.Color.Gainsboro
        Me.LBLNomeDoGrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LBLNomeDoGrupo.Location = New System.Drawing.Point(0, 3)
        Me.LBLNomeDoGrupo.Name = "LBLNomeDoGrupo"
        Me.LBLNomeDoGrupo.Padding = New System.Windows.Forms.Padding(3)
        Me.LBLNomeDoGrupo.Size = New System.Drawing.Size(45, 19)
        Me.LBLNomeDoGrupo.TabIndex = 3
        Me.LBLNomeDoGrupo.Text = "&Grupo:"
        '
        'PanelMarginDoSelectNewGroup
        '
        Me.PanelMarginDoSelectNewGroup.BackColor = System.Drawing.Color.DimGray
        Me.PanelMarginDoSelectNewGroup.Controls.Add(Me.Panel_EnvolveBTNSelectedNewGroupType)
        Me.PanelMarginDoSelectNewGroup.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelMarginDoSelectNewGroup.Location = New System.Drawing.Point(413, 3)
        Me.PanelMarginDoSelectNewGroup.Name = "PanelMarginDoSelectNewGroup"
        Me.PanelMarginDoSelectNewGroup.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelMarginDoSelectNewGroup.Size = New System.Drawing.Size(46, 19)
        Me.PanelMarginDoSelectNewGroup.TabIndex = 102
        '
        'Panel_EnvolveBTNSelectedNewGroupType
        '
        Me.Panel_EnvolveBTNSelectedNewGroupType.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel_EnvolveBTNSelectedNewGroupType.Controls.Add(Me.BTNSelectedNewGroupType)
        Me.Panel_EnvolveBTNSelectedNewGroupType.Controls.Add(Me.BTNSelectNewGroupType)
        Me.Panel_EnvolveBTNSelectedNewGroupType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_EnvolveBTNSelectedNewGroupType.Location = New System.Drawing.Point(1, 1)
        Me.Panel_EnvolveBTNSelectedNewGroupType.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_EnvolveBTNSelectedNewGroupType.Name = "Panel_EnvolveBTNSelectedNewGroupType"
        Me.Panel_EnvolveBTNSelectedNewGroupType.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Panel_EnvolveBTNSelectedNewGroupType.Size = New System.Drawing.Size(44, 17)
        Me.Panel_EnvolveBTNSelectedNewGroupType.TabIndex = 6
        '
        'BTNSelectedNewGroupType
        '
        Me.BTNSelectedNewGroupType.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTNSelectedNewGroupType.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.grupo02
        Me.BTNSelectedNewGroupType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNSelectedNewGroupType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTNSelectedNewGroupType.FlatAppearance.BorderSize = 0
        Me.BTNSelectedNewGroupType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSelectedNewGroupType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNSelectedNewGroupType.Location = New System.Drawing.Point(0, 0)
        Me.BTNSelectedNewGroupType.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNSelectedNewGroupType.Name = "BTNSelectedNewGroupType"
        Me.BTNSelectedNewGroupType.Size = New System.Drawing.Size(29, 15)
        Me.BTNSelectedNewGroupType.TabIndex = 5
        Me.BTNSelectedNewGroupType.UseVisualStyleBackColor = False
        '
        'BTNSelectNewGroupType
        '
        Me.BTNSelectNewGroupType.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTNSelectNewGroupType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNSelectNewGroupType.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTNSelectNewGroupType.FlatAppearance.BorderSize = 0
        Me.BTNSelectNewGroupType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSelectNewGroupType.Image = Global.TrevoWebMedia.My.Resources.Resources.escolha1
        Me.BTNSelectNewGroupType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNSelectNewGroupType.Location = New System.Drawing.Point(29, 0)
        Me.BTNSelectNewGroupType.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNSelectNewGroupType.Name = "BTNSelectNewGroupType"
        Me.BTNSelectNewGroupType.Size = New System.Drawing.Size(15, 15)
        Me.BTNSelectNewGroupType.TabIndex = 6
        Me.BTNSelectNewGroupType.UseVisualStyleBackColor = False
        '
        'Panel246
        '
        Me.Panel246.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel246.Location = New System.Drawing.Point(459, 3)
        Me.Panel246.Name = "Panel246"
        Me.Panel246.Size = New System.Drawing.Size(5, 19)
        Me.Panel246.TabIndex = 113
        '
        'PanelExecutarProcesso
        '
        Me.PanelExecutarProcesso.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelExecutarProcesso.Controls.Add(Me.BTNPararProcessos)
        Me.PanelExecutarProcesso.Controls.Add(Me.BTNPausarProcessos)
        Me.PanelExecutarProcesso.Controls.Add(Me.BTNExecutarProcessos)
        Me.PanelExecutarProcesso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelExecutarProcesso.Location = New System.Drawing.Point(0, 456)
        Me.PanelExecutarProcesso.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelExecutarProcesso.Name = "PanelExecutarProcesso"
        Me.PanelExecutarProcesso.Padding = New System.Windows.Forms.Padding(6, 2, 0, 0)
        Me.PanelExecutarProcesso.Size = New System.Drawing.Size(468, 28)
        Me.PanelExecutarProcesso.TabIndex = 100
        '
        'BTNPararProcessos
        '
        Me.BTNPararProcessos.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTNPararProcessos.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources._stop
        Me.BTNPararProcessos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNPararProcessos.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNPararProcessos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTNPararProcessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPararProcessos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNPararProcessos.Location = New System.Drawing.Point(64, 2)
        Me.BTNPararProcessos.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNPararProcessos.Name = "BTNPararProcessos"
        Me.BTNPararProcessos.Size = New System.Drawing.Size(29, 26)
        Me.BTNPararProcessos.TabIndex = 35
        Me.BTNPararProcessos.UseVisualStyleBackColor = False
        '
        'BTNPausarProcessos
        '
        Me.BTNPausarProcessos.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTNPausarProcessos.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.pause1
        Me.BTNPausarProcessos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNPausarProcessos.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNPausarProcessos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTNPausarProcessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPausarProcessos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNPausarProcessos.Location = New System.Drawing.Point(35, 2)
        Me.BTNPausarProcessos.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNPausarProcessos.Name = "BTNPausarProcessos"
        Me.BTNPausarProcessos.Size = New System.Drawing.Size(29, 26)
        Me.BTNPausarProcessos.TabIndex = 34
        Me.BTNPausarProcessos.UseVisualStyleBackColor = False
        '
        'BTNExecutarProcessos
        '
        Me.BTNExecutarProcessos.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTNExecutarProcessos.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.avancar_1
        Me.BTNExecutarProcessos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNExecutarProcessos.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNExecutarProcessos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BTNExecutarProcessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNExecutarProcessos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNExecutarProcessos.Location = New System.Drawing.Point(6, 2)
        Me.BTNExecutarProcessos.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNExecutarProcessos.Name = "BTNExecutarProcessos"
        Me.BTNExecutarProcessos.Size = New System.Drawing.Size(29, 26)
        Me.BTNExecutarProcessos.TabIndex = 33
        Me.BTNExecutarProcessos.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel77)
        Me.Panel2.Controls.Add(Me.PanelLBLAcoes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(468, 516)
        Me.Panel2.TabIndex = 94
        '
        'PanelLBLAcoes
        '
        Me.PanelLBLAcoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelLBLAcoes.Controls.Add(Me.Panel247)
        Me.PanelLBLAcoes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLBLAcoes.Location = New System.Drawing.Point(0, 0)
        Me.PanelLBLAcoes.Name = "PanelLBLAcoes"
        Me.PanelLBLAcoes.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanelLBLAcoes.Size = New System.Drawing.Size(468, 32)
        Me.PanelLBLAcoes.TabIndex = 98
        '
        'Panel247
        '
        Me.Panel247.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel247.Controls.Add(Me.LBLAcoes)
        Me.Panel247.Controls.Add(Me.BTNExpandAcoes)
        Me.Panel247.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel247.Location = New System.Drawing.Point(0, 0)
        Me.Panel247.Name = "Panel247"
        Me.Panel247.Size = New System.Drawing.Size(468, 31)
        Me.Panel247.TabIndex = 5
        '
        'LBLAcoes
        '
        Me.LBLAcoes.BackColor = System.Drawing.Color.Transparent
        Me.LBLAcoes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBLAcoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LBLAcoes.ForeColor = System.Drawing.Color.Gainsboro
        Me.LBLAcoes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LBLAcoes.Location = New System.Drawing.Point(15, 0)
        Me.LBLAcoes.Name = "LBLAcoes"
        Me.LBLAcoes.Padding = New System.Windows.Forms.Padding(5)
        Me.LBLAcoes.Size = New System.Drawing.Size(453, 31)
        Me.LBLAcoes.TabIndex = 2
        Me.LBLAcoes.Text = "Ações"
        '
        'BTNExpandAcoes
        '
        Me.BTNExpandAcoes.BackColor = System.Drawing.Color.Transparent
        Me.BTNExpandAcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNExpandAcoes.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNExpandAcoes.FlatAppearance.BorderSize = 0
        Me.BTNExpandAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNExpandAcoes.Image = CType(resources.GetObject("BTNExpandAcoes.Image"), System.Drawing.Image)
        Me.BTNExpandAcoes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTNExpandAcoes.Location = New System.Drawing.Point(0, 0)
        Me.BTNExpandAcoes.Margin = New System.Windows.Forms.Padding(0)
        Me.BTNExpandAcoes.Name = "BTNExpandAcoes"
        Me.BTNExpandAcoes.Size = New System.Drawing.Size(15, 31)
        Me.BTNExpandAcoes.TabIndex = 1
        Me.BTNExpandAcoes.UseVisualStyleBackColor = False
        '
        'CMS_TipoDeProcesso
        '
        Me.CMS_TipoDeProcesso.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.CMS_TipoDeProcesso.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMenuItemTipoComposto, Me.TSMenuItemSeparator1, Me.TSMenuItemTipoCriacao, Me.TSMenuItemTipoCopia, Me.TSMenuItemSeparator2, Me.TSMenuItemTipoMover, Me.TSMenuItemSeparator3, Me.TSMenuItemTipoRenome, Me.TSMenuItemTipoGravacao, Me.TSMenuItemSeparator4, Me.TSMenuItemTipoExclusao})
        Me.CMS_TipoDeProcesso.Name = "CMS_TipoDeProcesso"
        Me.CMS_TipoDeProcesso.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.CMS_TipoDeProcesso.Size = New System.Drawing.Size(158, 182)
        Me.CMS_TipoDeProcesso.TabStop = True
        '
        'TSMenuItemTipoComposto
        '
        Me.TSMenuItemTipoComposto.ForeColor = System.Drawing.Color.Silver
        Me.TSMenuItemTipoComposto.Image = Global.TrevoWebMedia.My.Resources.Resources.grupo02
        Me.TSMenuItemTipoComposto.Name = "TSMenuItemTipoComposto"
        Me.TSMenuItemTipoComposto.Size = New System.Drawing.Size(157, 22)
        Me.TSMenuItemTipoComposto.Text = "Tipo c&omposto"
        '
        'TSMenuItemSeparator1
        '
        Me.TSMenuItemSeparator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TSMenuItemSeparator1.ForeColor = System.Drawing.Color.Silver
        Me.TSMenuItemSeparator1.Name = "TSMenuItemSeparator1"
        Me.TSMenuItemSeparator1.Size = New System.Drawing.Size(154, 6)
        '
        'TSMenuItemTipoCriacao
        '
        Me.TSMenuItemTipoCriacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TSMenuItemTipoCriacao.ForeColor = System.Drawing.Color.Silver
        Me.TSMenuItemTipoCriacao.Image = Global.TrevoWebMedia.My.Resources.Resources.grupoTipoCriacao
        Me.TSMenuItemTipoCriacao.Name = "TSMenuItemTipoCriacao"
        Me.TSMenuItemTipoCriacao.Size = New System.Drawing.Size(157, 22)
        Me.TSMenuItemTipoCriacao.Text = "Tipo criação..."
        '
        'TSMenuItemTipoCopia
        '
        Me.TSMenuItemTipoCopia.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TSMenuItemTipoCopia.ForeColor = System.Drawing.Color.Silver
        Me.TSMenuItemTipoCopia.Image = Global.TrevoWebMedia.My.Resources.Resources.NovoProcessoCopiar
        Me.TSMenuItemTipoCopia.Name = "TSMenuItemTipoCopia"
        Me.TSMenuItemTipoCopia.Size = New System.Drawing.Size(157, 22)
        Me.TSMenuItemTipoCopia.Text = "Tipo cópia..."
        '
        'TSMenuItemSeparator2
        '
        Me.TSMenuItemSeparator2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TSMenuItemSeparator2.ForeColor = System.Drawing.Color.Silver
        Me.TSMenuItemSeparator2.Name = "TSMenuItemSeparator2"
        Me.TSMenuItemSeparator2.Size = New System.Drawing.Size(154, 6)
        '
        'TSMenuItemTipoMover
        '
        Me.TSMenuItemTipoMover.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TSMenuItemTipoMover.ForeColor = System.Drawing.Color.Silver
        Me.TSMenuItemTipoMover.Image = Global.TrevoWebMedia.My.Resources.Resources.grupoTipoMover
        Me.TSMenuItemTipoMover.Name = "TSMenuItemTipoMover"
        Me.TSMenuItemTipoMover.Size = New System.Drawing.Size(157, 22)
        Me.TSMenuItemTipoMover.Text = "Tipo mover..."
        '
        'TSMenuItemSeparator3
        '
        Me.TSMenuItemSeparator3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TSMenuItemSeparator3.ForeColor = System.Drawing.Color.Silver
        Me.TSMenuItemSeparator3.Name = "TSMenuItemSeparator3"
        Me.TSMenuItemSeparator3.Size = New System.Drawing.Size(154, 6)
        '
        'TSMenuItemTipoRenome
        '
        Me.TSMenuItemTipoRenome.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TSMenuItemTipoRenome.ForeColor = System.Drawing.Color.Silver
        Me.TSMenuItemTipoRenome.Image = Global.TrevoWebMedia.My.Resources.Resources.renomear
        Me.TSMenuItemTipoRenome.Name = "TSMenuItemTipoRenome"
        Me.TSMenuItemTipoRenome.Size = New System.Drawing.Size(157, 22)
        Me.TSMenuItemTipoRenome.Text = "Tipo renome..."
        '
        'TSMenuItemTipoGravacao
        '
        Me.TSMenuItemTipoGravacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TSMenuItemTipoGravacao.ForeColor = System.Drawing.Color.Silver
        Me.TSMenuItemTipoGravacao.Image = Global.TrevoWebMedia.My.Resources.Resources.grupoTipoGravar1
        Me.TSMenuItemTipoGravacao.Name = "TSMenuItemTipoGravacao"
        Me.TSMenuItemTipoGravacao.Size = New System.Drawing.Size(157, 22)
        Me.TSMenuItemTipoGravacao.Text = "Tipo gravação..."
        '
        'TSMenuItemSeparator4
        '
        Me.TSMenuItemSeparator4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TSMenuItemSeparator4.ForeColor = System.Drawing.Color.Silver
        Me.TSMenuItemSeparator4.Name = "TSMenuItemSeparator4"
        Me.TSMenuItemSeparator4.Size = New System.Drawing.Size(154, 6)
        '
        'TSMenuItemTipoExclusao
        '
        Me.TSMenuItemTipoExclusao.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TSMenuItemTipoExclusao.ForeColor = System.Drawing.Color.Silver
        Me.TSMenuItemTipoExclusao.Image = Global.TrevoWebMedia.My.Resources.Resources.grupoTipoExclusao
        Me.TSMenuItemTipoExclusao.Name = "TSMenuItemTipoExclusao"
        Me.TSMenuItemTipoExclusao.Size = New System.Drawing.Size(157, 22)
        Me.TSMenuItemTipoExclusao.Text = "Tipo exclusão..."
        '
        'ControlItemDePainelDeAcoes3
        '
        Me.ControlItemDePainelDeAcoes3.AutoSize = True
        Me.ControlItemDePainelDeAcoes3.BackColor = System.Drawing.Color.Transparent
        Me.ControlItemDePainelDeAcoes3.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlItemDePainelDeAcoes3.Location = New System.Drawing.Point(0, 138)
        Me.ControlItemDePainelDeAcoes3.Name = "ControlItemDePainelDeAcoes3"
        Me.ControlItemDePainelDeAcoes3.Size = New System.Drawing.Size(315, 69)
        Me.ControlItemDePainelDeAcoes3.TabIndex = 2
        '
        'ControlItemDePainelDeAcoes2
        '
        Me.ControlItemDePainelDeAcoes2.AutoSize = True
        Me.ControlItemDePainelDeAcoes2.BackColor = System.Drawing.Color.Transparent
        Me.ControlItemDePainelDeAcoes2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlItemDePainelDeAcoes2.Location = New System.Drawing.Point(0, 69)
        Me.ControlItemDePainelDeAcoes2.Name = "ControlItemDePainelDeAcoes2"
        Me.ControlItemDePainelDeAcoes2.Size = New System.Drawing.Size(315, 69)
        Me.ControlItemDePainelDeAcoes2.TabIndex = 1
        '
        'ControlItemDePainelDeAcoes1
        '
        Me.ControlItemDePainelDeAcoes1.AutoSize = True
        Me.ControlItemDePainelDeAcoes1.BackColor = System.Drawing.Color.Transparent
        Me.ControlItemDePainelDeAcoes1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlItemDePainelDeAcoes1.Location = New System.Drawing.Point(0, 0)
        Me.ControlItemDePainelDeAcoes1.Name = "ControlItemDePainelDeAcoes1"
        Me.ControlItemDePainelDeAcoes1.Size = New System.Drawing.Size(315, 69)
        Me.ControlItemDePainelDeAcoes1.TabIndex = 0
        '
        'ControlPainel_Acoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ControlPainel_Acoes"
        Me.Size = New System.Drawing.Size(468, 516)
        Me.Panel77.ResumeLayout(False)
        Me.PanelAllProcessosAcoes.ResumeLayout(False)
        Me.PanelAllProcessosAcoes.PerformLayout()
        Me.PanelListaDeProcessos.ResumeLayout(False)
        Me.PanelTVProcessosAcoes.ResumeLayout(False)
        Me.PanelAddProcesso.ResumeLayout(False)
        Me.PanelOpcoesDeProcessos.ResumeLayout(False)
        Me.Panel36.ResumeLayout(False)
        Me.Panel37.ResumeLayout(False)
        Me.Panel_NovoProcessoGravar.ResumeLayout(False)
        Me.Panel96.ResumeLayout(False)
        Me.Panel97.ResumeLayout(False)
        Me.Panel101.ResumeLayout(False)
        Me.Panel102.ResumeLayout(False)
        Me.Panel94.ResumeLayout(False)
        Me.PanelAllAgrupamentos.ResumeLayout(False)
        Me.PanelEnvolveAgrupamentos.ResumeLayout(False)
        Me.PanelTVAgrupamentos.ResumeLayout(False)
        Me.PanelEditorPropriedadesDoGrupo.ResumeLayout(False)
        Me.PanelCorDoGrupo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelEnvolveCHK_ShowPanelAllProcessosAcoes.ResumeLayout(False)
        Me.PanelEnvolve_BTN_NewFolder.ResumeLayout(False)
        Me.PanelEnvolve_BTN_TimeParaAgrupamentos.ResumeLayout(False)
        Me.Panel112.ResumeLayout(False)
        Me.Panel113.ResumeLayout(False)
        Me.Panel205.ResumeLayout(False)
        Me.Panel206.ResumeLayout(False)
        Me.Panel208.ResumeLayout(False)
        Me.Panel209.ResumeLayout(False)
        Me.Panel211.ResumeLayout(False)
        Me.Panel215.ResumeLayout(False)
        Me.Panel217.ResumeLayout(False)
        Me.Panel218.ResumeLayout(False)
        Me.Panel106.ResumeLayout(False)
        Me.Panel107.ResumeLayout(False)
        Me.Panel103.ResumeLayout(False)
        Me.Panel104.ResumeLayout(False)
        Me.Panel109.ResumeLayout(False)
        Me.Panel110.ResumeLayout(False)
        Me.Panel238.ResumeLayout(False)
        Me.Panel239.ResumeLayout(False)
        Me.Panel223.ResumeLayout(False)
        Me.Panel232.ResumeLayout(False)
        Me.Panel220.ResumeLayout(False)
        Me.Panel221.ResumeLayout(False)
        Me.Panel242.ResumeLayout(False)
        Me.Panel243.ResumeLayout(False)
        Me.PanelNomeDoGrupo.ResumeLayout(False)
        Me.PanelNomeDoGrupo.PerformLayout()
        Me.PanelMargemDoNomeDoGrupo.ResumeLayout(False)
        Me.PanelFundoDoNomeDoGrupo.ResumeLayout(False)
        Me.PanelFundoDoNomeDoGrupo.PerformLayout()
        Me.PanelMarginDoSelectNewGroup.ResumeLayout(False)
        Me.Panel_EnvolveBTNSelectedNewGroupType.ResumeLayout(False)
        Me.PanelExecutarProcesso.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelLBLAcoes.ResumeLayout(False)
        Me.Panel247.ResumeLayout(False)
        Me.CMS_TipoDeProcesso.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel77 As Panel
    Friend WithEvents PanelAllProcessosAcoes As Panel
    Friend WithEvents PanelListaDeProcessos As Panel
    Friend WithEvents PanelTVProcessosAcoes As Panel
    Friend WithEvents TVW_ListaDeProcessos As TreeView
    Friend WithEvents PanelAddProcesso As Panel
    Friend WithEvents PanelOpcoesDeProcessos As Panel
    Friend WithEvents BTNAddProcesso As Button
    Friend WithEvents PanelAllAgrupamentos As Panel
    Friend WithEvents PanelEnvolveAgrupamentos As Panel
    Friend WithEvents PanelTVAgrupamentos As Panel
    Friend WithEvents PanelEditorPropriedadesDoGrupo As Panel
    Friend WithEvents PanelCorDoGrupo As Panel
    Friend WithEvents Panel103 As Panel
    Friend WithEvents Panel104 As Panel
    Friend WithEvents Panel_SelectColorBlue As Panel
    Friend WithEvents Panel106 As Panel
    Friend WithEvents Panel107 As Panel
    Friend WithEvents Panel_SelectColorDarkGreen As Panel
    Friend WithEvents Panel109 As Panel
    Friend WithEvents Panel110 As Panel
    Friend WithEvents Panel_SelectColorRoyalBlue As Panel
    Friend WithEvents Panel112 As Panel
    Friend WithEvents Panel113 As Panel
    Friend WithEvents Panel_SelectColorViolet As Panel
    Friend WithEvents Panel205 As Panel
    Friend WithEvents Panel206 As Panel
    Friend WithEvents Panel_SelectColorPurple As Panel
    Friend WithEvents Panel208 As Panel
    Friend WithEvents Panel209 As Panel
    Friend WithEvents Panel_SelectColorRed As Panel
    Friend WithEvents Panel211 As Panel
    Friend WithEvents Panel215 As Panel
    Friend WithEvents Panel_SelectColorOrange As Panel
    Friend WithEvents Panel217 As Panel
    Friend WithEvents Panel218 As Panel
    Friend WithEvents Panel_SelectColorYellow As Panel
    Friend WithEvents Panel220 As Panel
    Friend WithEvents Panel221 As Panel
    Friend WithEvents Panel_SelectColorBlack As Panel
    Friend WithEvents Panel223 As Panel
    Friend WithEvents Panel232 As Panel
    Friend WithEvents Panel_SelectColorGray As Panel
    Friend WithEvents Panel238 As Panel
    Friend WithEvents Panel239 As Panel
    Friend WithEvents Panel_SelectColorWhite As Panel
    Friend WithEvents Panel242 As Panel
    Friend WithEvents Panel243 As Panel
    Friend WithEvents LBLSelectColorNone As Label
    Friend WithEvents PanelNomeDoGrupo As Panel
    Friend WithEvents PanelMargemDoNomeDoGrupo As Panel
    Friend WithEvents PanelFundoDoNomeDoGrupo As Panel
    Friend WithEvents TXTNomeDoGrupo As TextBox
    Friend WithEvents PanelME As Panel
    Friend WithEvents LBLNomeDoGrupo As Label
    Friend WithEvents PanelMarginDoSelectNewGroup As Panel
    Friend WithEvents Panel_EnvolveBTNSelectedNewGroupType As Panel
    Friend WithEvents BTNSelectedNewGroupType As Button
    Friend WithEvents BTNSelectNewGroupType As Button
    Friend WithEvents Panel246 As Panel
    Friend WithEvents Panel_ItensAGrupados As Panel
    Friend WithEvents Splitter4 As Splitter
    Friend WithEvents PanelExecutarProcesso As Panel
    Friend WithEvents BTNExecutarProcessos As Button
    Friend WithEvents BTNPararProcessos As Button
    Friend WithEvents BTNPausarProcessos As Button
    Friend WithEvents BTN_TimeParaAgrupamentos As Button
    Friend WithEvents CHK_ShowPanelAllProcessosAcoes As CheckBox
    Friend WithEvents Panel36 As Panel
    Friend WithEvents Panel37 As Panel
    Friend WithEvents BTN_FechaPanelOpcoesDeProcessos As Button
    Friend WithEvents Panel94 As Panel
    Friend WithEvents Panel_NovoProcessoGravar As Panel
    Friend WithEvents BTN_NovoProcessoGravar As Button
    Friend WithEvents Panel96 As Panel
    Friend WithEvents BTN_NovoProcessoExcluir As Button
    Friend WithEvents Panel97 As Panel
    Friend WithEvents BTN_NovoProcessoCopiar As Button
    Friend WithEvents Panel101 As Panel
    Friend WithEvents BTN_NovoProcessoMover As Button
    Friend WithEvents Panel102 As Panel
    Friend WithEvents BTN_NovoProcessoRenomear As Button
    Friend WithEvents BTN_NewFolder As Button
    Friend WithEvents BTN_NovoProcessoCriar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelLBLAcoes As Panel
    Friend WithEvents Panel247 As Panel
    Friend WithEvents LBLAcoes As Label
    Friend WithEvents BTNExpandAcoes As Button
    Friend WithEvents ControlItemDePainelDeAcoes3 As ControlItemDePainelDeAcoes
    Friend WithEvents ControlItemDePainelDeAcoes2 As ControlItemDePainelDeAcoes
    Friend WithEvents ControlItemDePainelDeAcoes1 As ControlItemDePainelDeAcoes
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PanelEnvolveCHK_ShowPanelAllProcessosAcoes As Panel
    Friend WithEvents PanelEnvolve_BTN_NewFolder As Panel
    Friend WithEvents PanelEnvolve_BTN_TimeParaAgrupamentos As Panel
    Friend WithEvents CMS_TipoDeProcesso As ContextMenuStrip
    Friend WithEvents TSMenuItemTipoCriacao As ToolStripMenuItem
    Friend WithEvents TSMenuItemTipoCopia As ToolStripMenuItem
    Friend WithEvents TSMenuItemTipoMover As ToolStripMenuItem
    Friend WithEvents TSMenuItemTipoRenome As ToolStripMenuItem
    Friend WithEvents TSMenuItemTipoGravacao As ToolStripMenuItem
    Friend WithEvents TSMenuItemTipoExclusao As ToolStripMenuItem
    Friend WithEvents TSMenuItemSeparator1 As ToolStripSeparator
    Friend WithEvents TSMenuItemSeparator2 As ToolStripSeparator
    Friend WithEvents TSMenuItemSeparator3 As ToolStripSeparator
    Friend WithEvents TSMenuItemSeparator4 As ToolStripSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TSMenuItemTipoComposto As ToolStripMenuItem
End Class
