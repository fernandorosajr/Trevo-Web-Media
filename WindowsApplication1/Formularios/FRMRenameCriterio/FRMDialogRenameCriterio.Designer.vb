<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMDialogRenameCriterio
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
        Me.LBLValue_NovoNome = New System.Windows.Forms.Label()
        Me.LNKLNomeDoExemplo = New System.Windows.Forms.LinkLabel()
        Me.LBLTitleOrigem = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBLTitle03 = New System.Windows.Forms.Label()
        Me.Control_TextBoxPerson3 = New TrevoWebMedia.Control_TextBoxPerson()
        Me.Control_TextBoxPerson1 = New TrevoWebMedia.Control_TextBoxPerson()
        Me.Control_TextBoxPerson2 = New TrevoWebMedia.Control_TextBoxPerson()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelBorder_Visualizar.SuspendLayout()
        Me.PanelVisualizar.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(486, 429)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
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
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
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
        Me.LBLExplicacao.Size = New System.Drawing.Size(596, 24)
        Me.LBLExplicacao.TabIndex = 8
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
        Me.LBLTitle01.Size = New System.Drawing.Size(600, 28)
        Me.LBLTitle01.TabIndex = 7
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
        Me.LBLTitle02.Size = New System.Drawing.Size(596, 29)
        Me.LBLTitle02.TabIndex = 110
        Me.LBLTitle02.Text = "Lista dos critérios"
        '
        'PanelRecebe
        '
        Me.PanelRecebe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelRecebe.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelRecebe.Location = New System.Drawing.Point(31, 103)
        Me.PanelRecebe.Name = "PanelRecebe"
        Me.PanelRecebe.Size = New System.Drawing.Size(598, 190)
        Me.PanelRecebe.TabIndex = 111
        '
        'PanelBorder_Visualizar
        '
        Me.PanelBorder_Visualizar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBorder_Visualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelBorder_Visualizar.Controls.Add(Me.PanelVisualizar)
        Me.PanelBorder_Visualizar.Location = New System.Drawing.Point(31, 329)
        Me.PanelBorder_Visualizar.Name = "PanelBorder_Visualizar"
        Me.PanelBorder_Visualizar.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelBorder_Visualizar.Size = New System.Drawing.Size(598, 88)
        Me.PanelBorder_Visualizar.TabIndex = 113
        '
        'PanelVisualizar
        '
        Me.PanelVisualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelVisualizar.Controls.Add(Me.Control_TextBoxPerson2)
        Me.PanelVisualizar.Controls.Add(Me.LBL_ValueOrigemDoExemplo)
        Me.PanelVisualizar.Controls.Add(Me.LBLNovoNome)
        Me.PanelVisualizar.Controls.Add(Me.LBLNomeDoExemplo)
        Me.PanelVisualizar.Controls.Add(Me.LBLValue_NovoNome)
        Me.PanelVisualizar.Controls.Add(Me.LNKLNomeDoExemplo)
        Me.PanelVisualizar.Controls.Add(Me.LBLTitleOrigem)
        Me.PanelVisualizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVisualizar.Location = New System.Drawing.Point(1, 1)
        Me.PanelVisualizar.Name = "PanelVisualizar"
        Me.PanelVisualizar.Size = New System.Drawing.Size(596, 86)
        Me.PanelVisualizar.TabIndex = 0
        '
        'LBL_ValueOrigemDoExemplo
        '
        Me.LBL_ValueOrigemDoExemplo.AutoSize = True
        Me.LBL_ValueOrigemDoExemplo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ValueOrigemDoExemplo.Location = New System.Drawing.Point(122, 15)
        Me.LBL_ValueOrigemDoExemplo.Name = "LBL_ValueOrigemDoExemplo"
        Me.LBL_ValueOrigemDoExemplo.Size = New System.Drawing.Size(97, 13)
        Me.LBL_ValueOrigemDoExemplo.TabIndex = 113
        Me.LBL_ValueOrigemDoExemplo.Text = "C:/MinhaPasta/"
        '
        'LBLNovoNome
        '
        Me.LBLNovoNome.AutoEllipsis = True
        Me.LBLNovoNome.AutoSize = True
        Me.LBLNovoNome.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLNovoNome.Location = New System.Drawing.Point(51, 57)
        Me.LBLNovoNome.Name = "LBLNovoNome"
        Me.LBLNovoNome.Size = New System.Drawing.Size(65, 13)
        Me.LBLNovoNome.TabIndex = 10
        Me.LBLNovoNome.Text = "Novo nome:"
        '
        'LBLNomeDoExemplo
        '
        Me.LBLNomeDoExemplo.AutoEllipsis = True
        Me.LBLNomeDoExemplo.AutoSize = True
        Me.LBLNomeDoExemplo.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLNomeDoExemplo.Location = New System.Drawing.Point(21, 36)
        Me.LBLNomeDoExemplo.Name = "LBLNomeDoExemplo"
        Me.LBLNomeDoExemplo.Size = New System.Drawing.Size(95, 13)
        Me.LBLNomeDoExemplo.TabIndex = 8
        Me.LBLNomeDoExemplo.Text = "Nome de exemplo:"
        '
        'LBLValue_NovoNome
        '
        Me.LBLValue_NovoNome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLValue_NovoNome.AutoEllipsis = True
        Me.LBLValue_NovoNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBLValue_NovoNome.Location = New System.Drawing.Point(128, 57)
        Me.LBLValue_NovoNome.Name = "LBLValue_NovoNome"
        Me.LBLValue_NovoNome.Size = New System.Drawing.Size(450, 13)
        Me.LBLValue_NovoNome.TabIndex = 7
        Me.LBLValue_NovoNome.Text = "Meu Arquivo.txt"
        '
        'LNKLNomeDoExemplo
        '
        Me.LNKLNomeDoExemplo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LNKLNomeDoExemplo.AutoEllipsis = True
        Me.LNKLNomeDoExemplo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LNKLNomeDoExemplo.LinkColor = System.Drawing.Color.Orange
        Me.LNKLNomeDoExemplo.Location = New System.Drawing.Point(125, 36)
        Me.LNKLNomeDoExemplo.Name = "LNKLNomeDoExemplo"
        Me.LNKLNomeDoExemplo.Size = New System.Drawing.Size(453, 13)
        Me.LNKLNomeDoExemplo.TabIndex = 9
        Me.LNKLNomeDoExemplo.TabStop = True
        Me.LNKLNomeDoExemplo.Text = "Meu Arquivo.txt"
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
        Me.LBLTitleOrigem.Location = New System.Drawing.Point(16, 15)
        Me.LBLTitleOrigem.Name = "LBLTitleOrigem"
        Me.LBLTitleOrigem.Size = New System.Drawing.Size(100, 13)
        Me.LBLTitleOrigem.TabIndex = 6
        Me.LBLTitleOrigem.Text = "Origem de exemplo:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Control_TextBoxPerson3)
        Me.Panel1.Controls.Add(Me.Control_TextBoxPerson1)
        Me.Panel1.Location = New System.Drawing.Point(56, 423)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 47)
        Me.Panel1.TabIndex = 117
        '
        'LBLTitle03
        '
        Me.LBLTitle03.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLTitle03.AutoEllipsis = True
        Me.LBLTitle03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle03.ForeColor = System.Drawing.Color.DarkGray
        Me.LBLTitle03.Location = New System.Drawing.Point(31, 309)
        Me.LBLTitle03.Name = "LBLTitle03"
        Me.LBLTitle03.Size = New System.Drawing.Size(596, 30)
        Me.LBLTitle03.TabIndex = 111
        Me.LBLTitle03.Text = "Visualizar exemplo"
        '
        'Control_TextBoxPerson3
        '
        Me.Control_TextBoxPerson3.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Control_TextBoxPerson3.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Control_TextBoxPerson3.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Control_TextBoxPerson3.BorderColorError = System.Drawing.Color.Red
        Me.Control_TextBoxPerson3.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Control_TextBoxPerson3.ChangeCursorFocus = False
        Me.Control_TextBoxPerson3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Control_TextBoxPerson3.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.Control_TextBoxPerson3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Control_TextBoxPerson3.ErrorDisplay = False
        Me.Control_TextBoxPerson3.Font = New System.Drawing.Font("Lucida Console", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Control_TextBoxPerson3.Fonte = Nothing
        Me.Control_TextBoxPerson3.ForeColor = System.Drawing.Color.DarkGray
        Me.Control_TextBoxPerson3.ForeColorActive = System.Drawing.Color.DarkGray
        Me.Control_TextBoxPerson3.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.Control_TextBoxPerson3.HideSelection = True
        Me.Control_TextBoxPerson3.LeftIndentation = 6
        Me.Control_TextBoxPerson3.Location = New System.Drawing.Point(0, 26)
        Me.Control_TextBoxPerson3.MaximumSize = New System.Drawing.Size(0, 19)
        Me.Control_TextBoxPerson3.MinimumSize = New System.Drawing.Size(248, 21)
        Me.Control_TextBoxPerson3.MultiLine = False
        Me.Control_TextBoxPerson3.Name = "Control_TextBoxPerson3"
        Me.Control_TextBoxPerson3.PaddingText = New System.Windows.Forms.Padding(2, 5, 2, 2)
        Me.Control_TextBoxPerson3.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.Control_TextBoxPerson3.PersonBorder = New System.Windows.Forms.Padding(1)
        Me.Control_TextBoxPerson3.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.Control_TextBoxPerson3.Placeholder = Nothing
        Me.Control_TextBoxPerson3.Read_Only = False
        Me.Control_TextBoxPerson3.RightIndentation = 0
        Me.Control_TextBoxPerson3.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.Control_TextBoxPerson3.Size = New System.Drawing.Size(248, 21)
        Me.Control_TextBoxPerson3.TabIndex = 118
        Me.Control_TextBoxPerson3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Control_TextBoxPerson3.ThisSize = New System.Drawing.Size(248, 21)
        Me.Control_TextBoxPerson3.TXT = "Alô, Olá!"
        Me.Control_TextBoxPerson3.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Control_TextBoxPerson3.UseSystemPasswordChar = False
        Me.Control_TextBoxPerson3.WordWrap = True
        '
        'Control_TextBoxPerson1
        '
        Me.Control_TextBoxPerson1.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Control_TextBoxPerson1.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Control_TextBoxPerson1.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Control_TextBoxPerson1.BorderColorError = System.Drawing.Color.Red
        Me.Control_TextBoxPerson1.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Control_TextBoxPerson1.ChangeCursorFocus = False
        Me.Control_TextBoxPerson1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Control_TextBoxPerson1.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.Control_TextBoxPerson1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Control_TextBoxPerson1.ErrorDisplay = False
        Me.Control_TextBoxPerson1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Control_TextBoxPerson1.Fonte = Nothing
        Me.Control_TextBoxPerson1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Control_TextBoxPerson1.ForeColorActive = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Control_TextBoxPerson1.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.Control_TextBoxPerson1.HideSelection = True
        Me.Control_TextBoxPerson1.LeftIndentation = 6
        Me.Control_TextBoxPerson1.Location = New System.Drawing.Point(0, 0)
        Me.Control_TextBoxPerson1.MaximumSize = New System.Drawing.Size(0, 19)
        Me.Control_TextBoxPerson1.MinimumSize = New System.Drawing.Size(248, 21)
        Me.Control_TextBoxPerson1.MultiLine = False
        Me.Control_TextBoxPerson1.Name = "Control_TextBoxPerson1"
        Me.Control_TextBoxPerson1.PaddingText = New System.Windows.Forms.Padding(2)
        Me.Control_TextBoxPerson1.PasswordChar = "+"
        Me.Control_TextBoxPerson1.PersonBorder = New System.Windows.Forms.Padding(1)
        Me.Control_TextBoxPerson1.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.Control_TextBoxPerson1.Placeholder = "Digite sua senha..."
        Me.Control_TextBoxPerson1.Read_Only = False
        Me.Control_TextBoxPerson1.RightIndentation = 0
        Me.Control_TextBoxPerson1.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.Control_TextBoxPerson1.Size = New System.Drawing.Size(248, 21)
        Me.Control_TextBoxPerson1.TabIndex = 116
        Me.Control_TextBoxPerson1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Control_TextBoxPerson1.ThisSize = New System.Drawing.Size(248, 21)
        Me.Control_TextBoxPerson1.TXT = ""
        Me.Control_TextBoxPerson1.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Control_TextBoxPerson1.UseSystemPasswordChar = False
        Me.Control_TextBoxPerson1.WordWrap = False
        '
        'Control_TextBoxPerson2
        '
        Me.Control_TextBoxPerson2.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Control_TextBoxPerson2.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Control_TextBoxPerson2.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Control_TextBoxPerson2.BorderColorError = System.Drawing.Color.Red
        Me.Control_TextBoxPerson2.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Control_TextBoxPerson2.ChangeCursorFocus = False
        Me.Control_TextBoxPerson2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Control_TextBoxPerson2.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.Control_TextBoxPerson2.ErrorDisplay = False
        Me.Control_TextBoxPerson2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Control_TextBoxPerson2.Fonte = Nothing
        Me.Control_TextBoxPerson2.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Control_TextBoxPerson2.ForeColorActive = System.Drawing.Color.MediumAquamarine
        Me.Control_TextBoxPerson2.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.Control_TextBoxPerson2.HideSelection = True
        Me.Control_TextBoxPerson2.LeftIndentation = 6
        Me.Control_TextBoxPerson2.Location = New System.Drawing.Point(394, 52)
        Me.Control_TextBoxPerson2.MaximumSize = New System.Drawing.Size(0, 19)
        Me.Control_TextBoxPerson2.MinimumSize = New System.Drawing.Size(184, 20)
        Me.Control_TextBoxPerson2.MultiLine = False
        Me.Control_TextBoxPerson2.Name = "Control_TextBoxPerson2"
        Me.Control_TextBoxPerson2.PaddingText = New System.Windows.Forms.Padding(2)
        Me.Control_TextBoxPerson2.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.Control_TextBoxPerson2.PersonBorder = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Control_TextBoxPerson2.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.Control_TextBoxPerson2.Placeholder = "Digite aqui ..."
        Me.Control_TextBoxPerson2.Read_Only = False
        Me.Control_TextBoxPerson2.RightIndentation = 0
        Me.Control_TextBoxPerson2.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.Control_TextBoxPerson2.Size = New System.Drawing.Size(184, 20)
        Me.Control_TextBoxPerson2.TabIndex = 116
        Me.Control_TextBoxPerson2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Control_TextBoxPerson2.ThisSize = New System.Drawing.Size(184, 20)
        Me.Control_TextBoxPerson2.TXT = ""
        Me.Control_TextBoxPerson2.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Control_TextBoxPerson2.UseSystemPasswordChar = False
        Me.Control_TextBoxPerson2.WordWrap = True
        '
        'FRMDialogRenameCriterio
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(662, 482)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelBorder_Visualizar)
        Me.Controls.Add(Me.PanelRecebe)
        Me.Controls.Add(Me.LBLTitle02)
        Me.Controls.Add(Me.LBLExplicacao)
        Me.Controls.Add(Me.LBLTitle01)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LBLTitle03)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMDialogRenameCriterio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FRMDialogRenameCriterio"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelBorder_Visualizar.ResumeLayout(False)
        Me.PanelVisualizar.ResumeLayout(False)
        Me.PanelVisualizar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents Control_TextBoxPerson1 As Control_TextBoxPerson
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Control_TextBoxPerson2 As Control_TextBoxPerson
    Friend WithEvents Control_TextBoxPerson3 As Control_TextBoxPerson
End Class
