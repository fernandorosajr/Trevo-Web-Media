﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMDialogRenameCriterion
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.LBLExplicacao = New System.Windows.Forms.Label()
        Me.LBLTitle01 = New System.Windows.Forms.Label()
        Me.LBLTitle02 = New System.Windows.Forms.Label()
        Me.PanelRecebe = New System.Windows.Forms.Panel()
        Me.PanelBorder_Visualizar = New System.Windows.Forms.Panel()
        Me.PanelVisualizar = New System.Windows.Forms.Panel()
        Me.LBL_ValueOrigemDoExemplo = New System.Windows.Forms.Label()
        Me.LBLNovoNome = New System.Windows.Forms.Label()
        Me.LBLNomeDoExemplo = New System.Windows.Forms.Label()
        Me.LBLTitleOrigem = New System.Windows.Forms.Label()
        Me.LNKLNomeDoExemplo = New System.Windows.Forms.LinkLabel()
        Me.LBLValue_NovoNome = New System.Windows.Forms.Label()
        Me.LBLTitle03 = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.BTNVisulizar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RB_ReiniciarNoSubItem = New System.Windows.Forms.RadioButton()
        Me.RB_FuxoContinuoDeRenome = New System.Windows.Forms.RadioButton()
        Me.RB_InicioDeterminadoParaItemESubitem = New System.Windows.Forms.RadioButton()
        Me.TXTCNovoNome = New TrevoWebMedia.Control_TextConfirm()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelBorder_Visualizar.SuspendLayout()
        Me.PanelVisualizar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(492, 526)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(160, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.OK_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.ForeColor = System.Drawing.Color.LightGray
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(74, 23)
        Me.OK_Button.TabIndex = 14
        Me.OK_Button.Text = "&Renomear"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(86, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 15
        Me.Cancel_Button.Text = "Cancelar"
        '
        'LBLExplicacao
        '
        Me.LBLExplicacao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLExplicacao.AutoEllipsis = True
        Me.LBLExplicacao.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLExplicacao.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLExplicacao.Location = New System.Drawing.Point(31, 50)
        Me.LBLExplicacao.Name = "LBLExplicacao"
        Me.LBLExplicacao.Size = New System.Drawing.Size(612, 24)
        Me.LBLExplicacao.TabIndex = 1
        Me.LBLExplicacao.Text = "Explicação...."
        '
        'LBLTitle01
        '
        Me.LBLTitle01.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLTitle01.AutoEllipsis = True
        Me.LBLTitle01.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle01.ForeColor = System.Drawing.Color.LightGray
        Me.LBLTitle01.Location = New System.Drawing.Point(27, 22)
        Me.LBLTitle01.Name = "LBLTitle01"
        Me.LBLTitle01.Size = New System.Drawing.Size(616, 28)
        Me.LBLTitle01.TabIndex = 0
        Me.LBLTitle01.Text = "Defina os critérios de renome dos arquivos em lote"
        '
        'LBLTitle02
        '
        Me.LBLTitle02.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLTitle02.AutoEllipsis = True
        Me.LBLTitle02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle02.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLTitle02.Location = New System.Drawing.Point(31, 83)
        Me.LBLTitle02.Name = "LBLTitle02"
        Me.LBLTitle02.Size = New System.Drawing.Size(612, 17)
        Me.LBLTitle02.TabIndex = 2
        Me.LBLTitle02.Text = "Lista dos critérios"
        '
        'PanelRecebe
        '
        Me.PanelRecebe.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelRecebe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRecebe.Location = New System.Drawing.Point(0, 0)
        Me.PanelRecebe.Name = "PanelRecebe"
        Me.PanelRecebe.Size = New System.Drawing.Size(614, 221)
        Me.PanelRecebe.TabIndex = 3
        '
        'PanelBorder_Visualizar
        '
        Me.PanelBorder_Visualizar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBorder_Visualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelBorder_Visualizar.Controls.Add(Me.PanelVisualizar)
        Me.PanelBorder_Visualizar.Location = New System.Drawing.Point(31, 418)
        Me.PanelBorder_Visualizar.Name = "PanelBorder_Visualizar"
        Me.PanelBorder_Visualizar.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder_Visualizar.Size = New System.Drawing.Size(614, 94)
        Me.PanelBorder_Visualizar.TabIndex = 5
        '
        'PanelVisualizar
        '
        Me.PanelVisualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelVisualizar.Controls.Add(Me.LBL_ValueOrigemDoExemplo)
        Me.PanelVisualizar.Controls.Add(Me.LBLNovoNome)
        Me.PanelVisualizar.Controls.Add(Me.LBLNomeDoExemplo)
        Me.PanelVisualizar.Controls.Add(Me.LBLTitleOrigem)
        Me.PanelVisualizar.Controls.Add(Me.TXTCNovoNome)
        Me.PanelVisualizar.Controls.Add(Me.LNKLNomeDoExemplo)
        Me.PanelVisualizar.Controls.Add(Me.LBLValue_NovoNome)
        Me.PanelVisualizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVisualizar.Location = New System.Drawing.Point(1, 1)
        Me.PanelVisualizar.Name = "PanelVisualizar"
        Me.PanelVisualizar.Size = New System.Drawing.Size(612, 92)
        Me.PanelVisualizar.TabIndex = 6
        '
        'LBL_ValueOrigemDoExemplo
        '
        Me.LBL_ValueOrigemDoExemplo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_ValueOrigemDoExemplo.AutoEllipsis = True
        Me.LBL_ValueOrigemDoExemplo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ValueOrigemDoExemplo.Location = New System.Drawing.Point(127, 15)
        Me.LBL_ValueOrigemDoExemplo.Name = "LBL_ValueOrigemDoExemplo"
        Me.LBL_ValueOrigemDoExemplo.Size = New System.Drawing.Size(465, 13)
        Me.LBL_ValueOrigemDoExemplo.TabIndex = 8
        Me.LBL_ValueOrigemDoExemplo.Text = "C:/MinhaPasta/"
        '
        'LBLNovoNome
        '
        Me.LBLNovoNome.AutoEllipsis = True
        Me.LBLNovoNome.AutoSize = True
        Me.LBLNovoNome.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLNovoNome.Location = New System.Drawing.Point(56, 57)
        Me.LBLNovoNome.Name = "LBLNovoNome"
        Me.LBLNovoNome.Size = New System.Drawing.Size(65, 13)
        Me.LBLNovoNome.TabIndex = 12
        Me.LBLNovoNome.Text = "Novo nome:"
        '
        'LBLNomeDoExemplo
        '
        Me.LBLNomeDoExemplo.AutoEllipsis = True
        Me.LBLNomeDoExemplo.AutoSize = True
        Me.LBLNomeDoExemplo.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLNomeDoExemplo.Location = New System.Drawing.Point(26, 36)
        Me.LBLNomeDoExemplo.Name = "LBLNomeDoExemplo"
        Me.LBLNomeDoExemplo.Size = New System.Drawing.Size(95, 13)
        Me.LBLNomeDoExemplo.TabIndex = 9
        Me.LBLNomeDoExemplo.Text = "Nome de exemplo:"
        '
        'LBLTitleOrigem
        '
        Me.LBLTitleOrigem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLTitleOrigem.AutoEllipsis = True
        Me.LBLTitleOrigem.AutoSize = True
        Me.LBLTitleOrigem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitleOrigem.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLTitleOrigem.Location = New System.Drawing.Point(21, 15)
        Me.LBLTitleOrigem.Name = "LBLTitleOrigem"
        Me.LBLTitleOrigem.Size = New System.Drawing.Size(100, 13)
        Me.LBLTitleOrigem.TabIndex = 7
        Me.LBLTitleOrigem.Text = "Origem de exemplo:"
        '
        'LNKLNomeDoExemplo
        '
        Me.LNKLNomeDoExemplo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LNKLNomeDoExemplo.AutoEllipsis = True
        Me.LNKLNomeDoExemplo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNKLNomeDoExemplo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LNKLNomeDoExemplo.LinkColor = System.Drawing.Color.Orange
        Me.LNKLNomeDoExemplo.Location = New System.Drawing.Point(128, 36)
        Me.LNKLNomeDoExemplo.Name = "LNKLNomeDoExemplo"
        Me.LNKLNomeDoExemplo.Size = New System.Drawing.Size(464, 13)
        Me.LNKLNomeDoExemplo.TabIndex = 11
        Me.LNKLNomeDoExemplo.TabStop = True
        Me.LNKLNomeDoExemplo.Text = "Meu Arquivo.txt"
        '
        'LBLValue_NovoNome
        '
        Me.LBLValue_NovoNome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLValue_NovoNome.AutoEllipsis = True
        Me.LBLValue_NovoNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLValue_NovoNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLValue_NovoNome.Location = New System.Drawing.Point(127, 57)
        Me.LBLValue_NovoNome.Name = "LBLValue_NovoNome"
        Me.LBLValue_NovoNome.Size = New System.Drawing.Size(467, 13)
        Me.LBLValue_NovoNome.TabIndex = 13
        Me.LBLValue_NovoNome.Text = "Meu Arquivo.txt"
        '
        'LBLTitle03
        '
        Me.LBLTitle03.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLTitle03.AutoEllipsis = True
        Me.LBLTitle03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle03.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLTitle03.Location = New System.Drawing.Point(31, 398)
        Me.LBLTitle03.Name = "LBLTitle03"
        Me.LBLTitle03.Size = New System.Drawing.Size(612, 18)
        Me.LBLTitle03.TabIndex = 4
        Me.LBLTitle03.Text = "Visualizar exemplo"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'BTNVisulizar
        '
        Me.BTNVisulizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNVisulizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNVisulizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNVisulizar.Location = New System.Drawing.Point(31, 529)
        Me.BTNVisulizar.Name = "BTNVisulizar"
        Me.BTNVisulizar.Size = New System.Drawing.Size(80, 23)
        Me.BTNVisulizar.TabIndex = 16
        Me.BTNVisulizar.Text = "Detalhar"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.PanelRecebe)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(31, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 273)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 221)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.Panel2.Size = New System.Drawing.Size(614, 52)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel3.Controls.Add(Me.RB_ReiniciarNoSubItem)
        Me.Panel3.Controls.Add(Me.RB_FuxoContinuoDeRenome)
        Me.Panel3.Controls.Add(Me.RB_InicioDeterminadoParaItemESubitem)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(612, 51)
        Me.Panel3.TabIndex = 0
        '
        'RB_ReiniciarNoSubItem
        '
        Me.RB_ReiniciarNoSubItem.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_ReiniciarNoSubItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.RB_ReiniciarNoSubItem.FlatAppearance.BorderSize = 0
        Me.RB_ReiniciarNoSubItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.RB_ReiniciarNoSubItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_ReiniciarNoSubItem.Image = Global.TrevoWebMedia.My.Resources.Resources.listReiniciarNoSubItem35
        Me.RB_ReiniciarNoSubItem.Location = New System.Drawing.Point(128, 0)
        Me.RB_ReiniciarNoSubItem.Name = "RB_ReiniciarNoSubItem"
        Me.RB_ReiniciarNoSubItem.Size = New System.Drawing.Size(67, 51)
        Me.RB_ReiniciarNoSubItem.TabIndex = 22
        Me.RB_ReiniciarNoSubItem.UseVisualStyleBackColor = True
        Me.RB_ReiniciarNoSubItem.Visible = False
        '
        'RB_FuxoContinuoDeRenome
        '
        Me.RB_FuxoContinuoDeRenome.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_FuxoContinuoDeRenome.Dock = System.Windows.Forms.DockStyle.Left
        Me.RB_FuxoContinuoDeRenome.FlatAppearance.BorderSize = 0
        Me.RB_FuxoContinuoDeRenome.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.RB_FuxoContinuoDeRenome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_FuxoContinuoDeRenome.Image = Global.TrevoWebMedia.My.Resources.Resources.listFluxoContinuo35
        Me.RB_FuxoContinuoDeRenome.Location = New System.Drawing.Point(63, 0)
        Me.RB_FuxoContinuoDeRenome.Name = "RB_FuxoContinuoDeRenome"
        Me.RB_FuxoContinuoDeRenome.Size = New System.Drawing.Size(65, 51)
        Me.RB_FuxoContinuoDeRenome.TabIndex = 21
        Me.RB_FuxoContinuoDeRenome.UseVisualStyleBackColor = True
        '
        'RB_InicioDeterminadoParaItemESubitem
        '
        Me.RB_InicioDeterminadoParaItemESubitem.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_InicioDeterminadoParaItemESubitem.Checked = True
        Me.RB_InicioDeterminadoParaItemESubitem.Dock = System.Windows.Forms.DockStyle.Left
        Me.RB_InicioDeterminadoParaItemESubitem.FlatAppearance.BorderSize = 0
        Me.RB_InicioDeterminadoParaItemESubitem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.RB_InicioDeterminadoParaItemESubitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RB_InicioDeterminadoParaItemESubitem.Image = Global.TrevoWebMedia.My.Resources.Resources.listFluxoIniciodeterminadoParaItemESubIntem35
        Me.RB_InicioDeterminadoParaItemESubitem.Location = New System.Drawing.Point(0, 0)
        Me.RB_InicioDeterminadoParaItemESubitem.Name = "RB_InicioDeterminadoParaItemESubitem"
        Me.RB_InicioDeterminadoParaItemESubitem.Size = New System.Drawing.Size(63, 51)
        Me.RB_InicioDeterminadoParaItemESubitem.TabIndex = 23
        Me.RB_InicioDeterminadoParaItemESubitem.TabStop = True
        Me.RB_InicioDeterminadoParaItemESubitem.UseVisualStyleBackColor = True
        '
        'TXTCNovoNome
        '
        Me.TXTCNovoNome.ActiveValidate = True
        Me.TXTCNovoNome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTCNovoNome.ByChar = False
        Me.TXTCNovoNome.ByText = False
        Me.TXTCNovoNome.ByValue = False
        Me.TXTCNovoNome.Filho = Nothing
        Me.TXTCNovoNome.Location = New System.Drawing.Point(123, 34)
        Me.TXTCNovoNome.Name = "TXTCNovoNome"
        Me.TXTCNovoNome.NoneOfThisChar = ""
        Me.TXTCNovoNome.NoneOfThisText = Nothing
        Me.TXTCNovoNome.NoneOfThisValue = Nothing
        Me.TXTCNovoNome.Placeholder = "Entre com um dado...."
        Me.TXTCNovoNome.RequiredChar = ""
        Me.TXTCNovoNome.RequiredText = Nothing
        Me.TXTCNovoNome.RequiredValue = Nothing
        Me.TXTCNovoNome.Size = New System.Drawing.Size(469, 42)
        Me.TXTCNovoNome.SpaceError = True
        Me.TXTCNovoNome.TabIndex = 10
        Me.TXTCNovoNome.ValueStr = Nothing
        Me.TXTCNovoNome.Visible = False
        '
        'FRMDialogRenameCriterion
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(678, 579)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTNVisulizar)
        Me.Controls.Add(Me.PanelBorder_Visualizar)
        Me.Controls.Add(Me.LBLTitle03)
        Me.Controls.Add(Me.LBLTitle02)
        Me.Controls.Add(Me.LBLExplicacao)
        Me.Controls.Add(Me.LBLTitle01)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMDialogRenameCriterion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FRMDialogRenameCriterio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelBorder_Visualizar.ResumeLayout(False)
        Me.PanelVisualizar.ResumeLayout(False)
        Me.PanelVisualizar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents LBLExplicacao As Label
    Friend WithEvents LBLTitle01 As Label
    Friend WithEvents LBLTitle02 As Label
    Friend WithEvents PanelRecebe As Panel
    Friend WithEvents PanelBorder_Visualizar As Panel
    Friend WithEvents PanelVisualizar As Panel
    Friend WithEvents LBL_ValueOrigemDoExemplo As Label
    Friend WithEvents LBLTitle03 As Label
    Friend WithEvents LBLNovoNome As Label
    Friend WithEvents LBLNomeDoExemplo As Label
    Friend WithEvents LBLValue_NovoNome As Label
    Friend WithEvents LNKLNomeDoExemplo As LinkLabel
    Friend WithEvents LBLTitleOrigem As Label
    Friend WithEvents TXTCNovoNome As Control_TextConfirm
    Friend WithEvents Timer As Timer
    Friend WithEvents BTNVisulizar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RB_InicioDeterminadoParaItemESubitem As RadioButton
    Friend WithEvents RB_ReiniciarNoSubItem As RadioButton
    Friend WithEvents RB_FuxoContinuoDeRenome As RadioButton
End Class
