<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Control_RenameOption
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Control_RenameOption))
        Me.PanelElemento = New System.Windows.Forms.Panel()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.PanelBase = New System.Windows.Forms.Panel()
        Me.PanelDateConfig = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ComBPFormatText = New TrevoWebMedia.Control_ComboBoxPerson()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TXTPSubstituirEspaco = New TrevoWebMedia.Control_TextBoxPerson()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CHKSubstituirEspaco = New System.Windows.Forms.CheckBox()
        Me.PanelNomeDoArquivoAtualConfig = New System.Windows.Forms.Panel()
        Me.TableDoArquivoAtualConfig = New System.Windows.Forms.TableLayoutPanel()
        Me.CKB_RemoveSpace = New System.Windows.Forms.CheckBox()
        Me.CKB_FirstLetterUpper = New System.Windows.Forms.CheckBox()
        Me.PanelSubstituir = New System.Windows.Forms.Panel()
        Me.TableLPContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelEnvolve_ComBPSlave = New System.Windows.Forms.Panel()
        Me.ComBPSlave = New TrevoWebMedia.Control_ComboBoxPerson()
        Me.ComBPMaster = New TrevoWebMedia.Control_ComboBoxPerson()
        Me.PanelEnvolve_ComBPMaster = New System.Windows.Forms.Panel()
        Me.Panel_Right = New System.Windows.Forms.Panel()
        Me.PanelEnvolve_RightTXT = New System.Windows.Forms.Panel()
        Me.TXTPValue = New TrevoWebMedia.Control_TextBoxPerson()
        Me.PanelEnvolve_ComBRight = New System.Windows.Forms.Panel()
        Me.ComBRight = New TrevoWebMedia.Control_ComboBoxPerson()
        Me.PanelRightButtons = New System.Windows.Forms.Panel()
        Me.TableLPButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.BTNAddRenomeDeOrigem = New System.Windows.Forms.Button()
        Me.BTNRemoveRenomeDeOrigem = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelMagemBotton = New System.Windows.Forms.Panel()
        Me.PanelElemento.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.PanelBase.SuspendLayout()
        Me.PanelDateConfig.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelNomeDoArquivoAtualConfig.SuspendLayout()
        Me.TableDoArquivoAtualConfig.SuspendLayout()
        Me.TableLPContainer.SuspendLayout()
        Me.PanelEnvolve_ComBPSlave.SuspendLayout()
        Me.PanelEnvolve_ComBPMaster.SuspendLayout()
        Me.Panel_Right.SuspendLayout()
        Me.PanelEnvolve_RightTXT.SuspendLayout()
        Me.PanelEnvolve_ComBRight.SuspendLayout()
        Me.PanelRightButtons.SuspendLayout()
        Me.TableLPButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelElemento
        '
        Me.PanelElemento.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelElemento.Controls.Add(Me.PanelContainer)
        Me.PanelElemento.Controls.Add(Me.PanelRightButtons)
        Me.PanelElemento.Controls.Add(Me.PanelMagemBotton)
        Me.PanelElemento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelElemento.Location = New System.Drawing.Point(0, 0)
        Me.PanelElemento.Name = "PanelElemento"
        Me.PanelElemento.Size = New System.Drawing.Size(595, 107)
        Me.PanelElemento.TabIndex = 1
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.PanelBase)
        Me.PanelContainer.Controls.Add(Me.TableLPContainer)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Padding = New System.Windows.Forms.Padding(13)
        Me.PanelContainer.Size = New System.Drawing.Size(541, 106)
        Me.PanelContainer.TabIndex = 4
        '
        'PanelBase
        '
        Me.PanelBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelBase.Controls.Add(Me.PanelDateConfig)
        Me.PanelBase.Controls.Add(Me.PanelNomeDoArquivoAtualConfig)
        Me.PanelBase.Controls.Add(Me.PanelSubstituir)
        Me.PanelBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBase.Location = New System.Drawing.Point(13, 41)
        Me.PanelBase.Name = "PanelBase"
        Me.PanelBase.Padding = New System.Windows.Forms.Padding(50, 5, 0, 0)
        Me.PanelBase.Size = New System.Drawing.Size(515, 52)
        Me.PanelBase.TabIndex = 6
        '
        'PanelDateConfig
        '
        Me.PanelDateConfig.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelDateConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDateConfig.Location = New System.Drawing.Point(50, 5)
        Me.PanelDateConfig.Name = "PanelDateConfig"
        Me.PanelDateConfig.Size = New System.Drawing.Size(465, 47)
        Me.PanelDateConfig.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel5, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(465, 47)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ComBPFormatText)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(226, 38)
        Me.Panel4.TabIndex = 4
        '
        'ComBPFormatText
        '
        Me.ComBPFormatText.AutomaticSelect = True
        Me.ComBPFormatText.AutoSize = True
        Me.ComBPFormatText.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ComBPFormatText.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ComBPFormatText.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ComBPFormatText.BorderColorError = System.Drawing.Color.Red
        Me.ComBPFormatText.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ComBPFormatText.ComboBoxPersonMaster = Nothing
        Me.ComBPFormatText.ComboBoxPersonSlave = Nothing
        Me.ComBPFormatText.ComboBoxPersonSlaveLists = CType(resources.GetObject("ComBPFormatText.ComboBoxPersonSlaveLists"), System.Collections.Specialized.StringCollection)
        Me.ComBPFormatText.DataReturn = Nothing
        Me.ComBPFormatText.DefaultOptionsList = CType(resources.GetObject("ComBPFormatText.DefaultOptionsList"), System.Collections.Specialized.StringCollection)
        Me.ComBPFormatText.DefaultOptionsListSlave = CType(resources.GetObject("ComBPFormatText.DefaultOptionsListSlave"), System.Collections.Specialized.StringCollection)
        Me.ComBPFormatText.DisplayAparence = TrevoWebMedia.Control_ComboBoxPerson.DisplayAparenceEnum.None
        Me.ComBPFormatText.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComBPFormatText.ForeColorActive = System.Drawing.Color.DarkGray
        Me.ComBPFormatText.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.ComBPFormatText.HideWhenEmptyList = False
        Me.ComBPFormatText.ListaDeOpçõesPadrão = Nothing
        Me.ComBPFormatText.Location = New System.Drawing.Point(0, 0)
        Me.ComBPFormatText.Name = "ComBPFormatText"
        Me.ComBPFormatText.Nivel = 0
        Me.ComBPFormatText.OptionsList = CType(resources.GetObject("ComBPFormatText.OptionsList"), System.Collections.Specialized.StringCollection)
        Me.ComBPFormatText.ReturnStringList = CType(resources.GetObject("ComBPFormatText.ReturnStringList"), System.Collections.Specialized.StringCollection)
        Me.ComBPFormatText.ReturnType = TrevoWebMedia.Control_ComboBoxPerson.ReturnTypeEnum.None
        Me.ComBPFormatText.ShortcutKeyDisplay = True
        Me.ComBPFormatText.Size = New System.Drawing.Size(226, 21)
        Me.ComBPFormatText.TabIndex = 0
        Me.ComBPFormatText.TextDisplay = "<Selecione>"
        Me.ComBPFormatText.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(235, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(227, 57)
        Me.Panel5.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TXTPSubstituirEspaco)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(105, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(122, 57)
        Me.Panel3.TabIndex = 6
        '
        'TXTPSubstituirEspaco
        '
        Me.TXTPSubstituirEspaco.ActiveValidate = True
        Me.TXTPSubstituirEspaco.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTPSubstituirEspaco.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPSubstituirEspaco.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.TXTPSubstituirEspaco.BorderColorError = System.Drawing.Color.Red
        Me.TXTPSubstituirEspaco.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTPSubstituirEspaco.ByChar = True
        Me.TXTPSubstituirEspaco.ByText = False
        Me.TXTPSubstituirEspaco.ByValue = False
        Me.TXTPSubstituirEspaco.ChangeCursorFocus = True
        Me.TXTPSubstituirEspaco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTPSubstituirEspaco.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.TXTPSubstituirEspaco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTPSubstituirEspaco.Enabled = False
        Me.TXTPSubstituirEspaco.ErrorDisplay = False
        Me.TXTPSubstituirEspaco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPSubstituirEspaco.Fonte = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPSubstituirEspaco.ForeColor = System.Drawing.Color.DarkGray
        Me.TXTPSubstituirEspaco.ForeColorActive = System.Drawing.Color.DarkGray
        Me.TXTPSubstituirEspaco.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.TXTPSubstituirEspaco.HideSelection = True
        Me.TXTPSubstituirEspaco.LeftIndentation = 6
        Me.TXTPSubstituirEspaco.Location = New System.Drawing.Point(0, 0)
        Me.TXTPSubstituirEspaco.MaxLength = 1
        Me.TXTPSubstituirEspaco.MultiLine = False
        Me.TXTPSubstituirEspaco.Name = "TXTPSubstituirEspaco"
        Me.TXTPSubstituirEspaco.NoneOfThisChar = """\/|:*?<>"
        Me.TXTPSubstituirEspaco.NoneOfThisText = Nothing
        Me.TXTPSubstituirEspaco.NoneOfThisValue = Nothing
        Me.TXTPSubstituirEspaco.OnlyAlfaNumber = False
        Me.TXTPSubstituirEspaco.OnlyCaracterText = False
        Me.TXTPSubstituirEspaco.OnlyNumber = False
        Me.TXTPSubstituirEspaco.PaddingText = New System.Windows.Forms.Padding(2, 3, 2, 2)
        Me.TXTPSubstituirEspaco.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPSubstituirEspaco.PersonBorder = New System.Windows.Forms.Padding(1)
        Me.TXTPSubstituirEspaco.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.TXTPSubstituirEspaco.Placeholder = "Digite o caracter..."
        Me.TXTPSubstituirEspaco.Read_Only = False
        Me.TXTPSubstituirEspaco.RequiredChar = ""
        Me.TXTPSubstituirEspaco.RequiredText = Nothing
        Me.TXTPSubstituirEspaco.RequiredValue = Nothing
        Me.TXTPSubstituirEspaco.RightIndentation = 0
        Me.TXTPSubstituirEspaco.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.TXTPSubstituirEspaco.Size = New System.Drawing.Size(122, 21)
        Me.TXTPSubstituirEspaco.SpaceError = False
        Me.TXTPSubstituirEspaco.TabIndex = 4
        Me.TXTPSubstituirEspaco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTPSubstituirEspaco.ThisSize = New System.Drawing.Size(122, 21)
        Me.TXTPSubstituirEspaco.TXT = Nothing
        Me.TXTPSubstituirEspaco.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPSubstituirEspaco.UseSystemPasswordChar = False
        Me.TXTPSubstituirEspaco.WordWrap = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 57)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CHKSubstituirEspaco)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(105, 21)
        Me.Panel2.TabIndex = 4
        '
        'CHKSubstituirEspaco
        '
        Me.CHKSubstituirEspaco.AutoSize = True
        Me.CHKSubstituirEspaco.Dock = System.Windows.Forms.DockStyle.Left
        Me.CHKSubstituirEspaco.Location = New System.Drawing.Point(0, 0)
        Me.CHKSubstituirEspaco.Name = "CHKSubstituirEspaco"
        Me.CHKSubstituirEspaco.Size = New System.Drawing.Size(110, 21)
        Me.CHKSubstituirEspaco.TabIndex = 3
        Me.CHKSubstituirEspaco.Text = "Substituir espaço:"
        Me.CHKSubstituirEspaco.UseVisualStyleBackColor = True
        '
        'PanelNomeDoArquivoAtualConfig
        '
        Me.PanelNomeDoArquivoAtualConfig.Controls.Add(Me.TableDoArquivoAtualConfig)
        Me.PanelNomeDoArquivoAtualConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelNomeDoArquivoAtualConfig.Location = New System.Drawing.Point(50, 5)
        Me.PanelNomeDoArquivoAtualConfig.Name = "PanelNomeDoArquivoAtualConfig"
        Me.PanelNomeDoArquivoAtualConfig.Size = New System.Drawing.Size(465, 47)
        Me.PanelNomeDoArquivoAtualConfig.TabIndex = 2
        '
        'TableDoArquivoAtualConfig
        '
        Me.TableDoArquivoAtualConfig.ColumnCount = 2
        Me.TableDoArquivoAtualConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableDoArquivoAtualConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableDoArquivoAtualConfig.Controls.Add(Me.CKB_RemoveSpace, 1, 0)
        Me.TableDoArquivoAtualConfig.Controls.Add(Me.CKB_FirstLetterUpper, 0, 0)
        Me.TableDoArquivoAtualConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableDoArquivoAtualConfig.Location = New System.Drawing.Point(0, 0)
        Me.TableDoArquivoAtualConfig.Name = "TableDoArquivoAtualConfig"
        Me.TableDoArquivoAtualConfig.RowCount = 1
        Me.TableDoArquivoAtualConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableDoArquivoAtualConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableDoArquivoAtualConfig.Size = New System.Drawing.Size(465, 47)
        Me.TableDoArquivoAtualConfig.TabIndex = 0
        '
        'CKB_RemoveSpace
        '
        Me.CKB_RemoveSpace.AutoSize = True
        Me.CKB_RemoveSpace.Location = New System.Drawing.Point(235, 3)
        Me.CKB_RemoveSpace.Name = "CKB_RemoveSpace"
        Me.CKB_RemoveSpace.Size = New System.Drawing.Size(105, 17)
        Me.CKB_RemoveSpace.TabIndex = 3
        Me.CKB_RemoveSpace.Text = "RemoverEspaço"
        Me.CKB_RemoveSpace.UseVisualStyleBackColor = True
        '
        'CKB_FirstLetterUpper
        '
        Me.CKB_FirstLetterUpper.AutoSize = True
        Me.CKB_FirstLetterUpper.Location = New System.Drawing.Point(3, 3)
        Me.CKB_FirstLetterUpper.Name = "CKB_FirstLetterUpper"
        Me.CKB_FirstLetterUpper.Size = New System.Drawing.Size(140, 17)
        Me.CKB_FirstLetterUpper.TabIndex = 2
        Me.CKB_FirstLetterUpper.Text = "primeira Letra Minúscula"
        Me.CKB_FirstLetterUpper.UseVisualStyleBackColor = True
        '
        'PanelSubstituir
        '
        Me.PanelSubstituir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSubstituir.Location = New System.Drawing.Point(50, 5)
        Me.PanelSubstituir.Name = "PanelSubstituir"
        Me.PanelSubstituir.Size = New System.Drawing.Size(465, 47)
        Me.PanelSubstituir.TabIndex = 1
        '
        'TableLPContainer
        '
        Me.TableLPContainer.ColumnCount = 5
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.46287!))
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.306566!))
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.46288!))
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.306566!))
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.46112!))
        Me.TableLPContainer.Controls.Add(Me.PanelEnvolve_ComBPSlave, 2, 0)
        Me.TableLPContainer.Controls.Add(Me.PanelEnvolve_ComBPMaster, 0, 0)
        Me.TableLPContainer.Controls.Add(Me.Panel_Right, 4, 0)
        Me.TableLPContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLPContainer.Location = New System.Drawing.Point(13, 13)
        Me.TableLPContainer.Name = "TableLPContainer"
        Me.TableLPContainer.RowCount = 1
        Me.TableLPContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLPContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLPContainer.Size = New System.Drawing.Size(515, 28)
        Me.TableLPContainer.TabIndex = 5
        '
        'PanelEnvolve_ComBPSlave
        '
        Me.PanelEnvolve_ComBPSlave.Controls.Add(Me.ComBPSlave)
        Me.PanelEnvolve_ComBPSlave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_ComBPSlave.Location = New System.Drawing.Point(176, 3)
        Me.PanelEnvolve_ComBPSlave.Name = "PanelEnvolve_ComBPSlave"
        Me.PanelEnvolve_ComBPSlave.Size = New System.Drawing.Size(161, 22)
        Me.PanelEnvolve_ComBPSlave.TabIndex = 5
        '
        'ComBPSlave
        '
        Me.ComBPSlave.AutomaticSelect = True
        Me.ComBPSlave.AutoSize = True
        Me.ComBPSlave.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ComBPSlave.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ComBPSlave.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ComBPSlave.BorderColorError = System.Drawing.Color.Red
        Me.ComBPSlave.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ComBPSlave.ComboBoxPersonMaster = Me.ComBPMaster
        Me.ComBPSlave.ComboBoxPersonSlave = Nothing
        Me.ComBPSlave.ComboBoxPersonSlaveLists = CType(resources.GetObject("ComBPSlave.ComboBoxPersonSlaveLists"), System.Collections.Specialized.StringCollection)
        Me.ComBPSlave.DataReturn = Nothing
        Me.ComBPSlave.DefaultOptionsList = CType(resources.GetObject("ComBPSlave.DefaultOptionsList"), System.Collections.Specialized.StringCollection)
        Me.ComBPSlave.DefaultOptionsListSlave = CType(resources.GetObject("ComBPSlave.DefaultOptionsListSlave"), System.Collections.Specialized.StringCollection)
        Me.ComBPSlave.DisplayAparence = TrevoWebMedia.Control_ComboBoxPerson.DisplayAparenceEnum.None
        Me.ComBPSlave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComBPSlave.ForeColorActive = System.Drawing.Color.DarkGray
        Me.ComBPSlave.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.ComBPSlave.HideWhenEmptyList = False
        Me.ComBPSlave.ListaDeOpçõesPadrão = Nothing
        Me.ComBPSlave.Location = New System.Drawing.Point(0, 0)
        Me.ComBPSlave.Name = "ComBPSlave"
        Me.ComBPSlave.Nivel = 1
        Me.ComBPSlave.OptionsList = CType(resources.GetObject("ComBPSlave.OptionsList"), System.Collections.Specialized.StringCollection)
        Me.ComBPSlave.ReturnStringList = CType(resources.GetObject("ComBPSlave.ReturnStringList"), System.Collections.Specialized.StringCollection)
        Me.ComBPSlave.ReturnType = TrevoWebMedia.Control_ComboBoxPerson.ReturnTypeEnum.None
        Me.ComBPSlave.SelectedItem = Nothing
        Me.ComBPSlave.ShortcutKeyDisplay = True
        Me.ComBPSlave.Size = New System.Drawing.Size(161, 22)
        Me.ComBPSlave.TabIndex = 1
        Me.ComBPSlave.TextDisplay = "<Selecione>"
        Me.ComBPSlave.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        '
        'ComBPMaster
        '
        Me.ComBPMaster.AutomaticSelect = True
        Me.ComBPMaster.AutoSize = True
        Me.ComBPMaster.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ComBPMaster.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ComBPMaster.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ComBPMaster.BorderColorError = System.Drawing.Color.Red
        Me.ComBPMaster.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ComBPMaster.ComboBoxPersonMaster = Nothing
        Me.ComBPMaster.ComboBoxPersonSlave = Me.ComBPSlave
        Me.ComBPMaster.ComboBoxPersonSlaveLists = CType(resources.GetObject("ComBPMaster.ComboBoxPersonSlaveLists"), System.Collections.Specialized.StringCollection)
        Me.ComBPMaster.DataReturn = Nothing
        Me.ComBPMaster.DefaultOptionsList = CType(resources.GetObject("ComBPMaster.DefaultOptionsList"), System.Collections.Specialized.StringCollection)
        Me.ComBPMaster.DefaultOptionsListSlave = CType(resources.GetObject("ComBPMaster.DefaultOptionsListSlave"), System.Collections.Specialized.StringCollection)
        Me.ComBPMaster.DisplayAparence = TrevoWebMedia.Control_ComboBoxPerson.DisplayAparenceEnum.None
        Me.ComBPMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComBPMaster.ForeColorActive = System.Drawing.Color.DarkGray
        Me.ComBPMaster.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.ComBPMaster.HideWhenEmptyList = False
        Me.ComBPMaster.ListaDeOpçõesPadrão = Nothing
        Me.ComBPMaster.Location = New System.Drawing.Point(0, 0)
        Me.ComBPMaster.Name = "ComBPMaster"
        Me.ComBPMaster.Nivel = 0
        Me.ComBPMaster.OptionsList = CType(resources.GetObject("ComBPMaster.OptionsList"), System.Collections.Specialized.StringCollection)
        Me.ComBPMaster.ReturnStringList = CType(resources.GetObject("ComBPMaster.ReturnStringList"), System.Collections.Specialized.StringCollection)
        Me.ComBPMaster.ReturnType = TrevoWebMedia.Control_ComboBoxPerson.ReturnTypeEnum.ID
        Me.ComBPMaster.ShortcutKeyDisplay = True
        Me.ComBPMaster.Size = New System.Drawing.Size(161, 22)
        Me.ComBPMaster.TabIndex = 0
        Me.ComBPMaster.TextDisplay = "Texto"
        Me.ComBPMaster.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        '
        'PanelEnvolve_ComBPMaster
        '
        Me.PanelEnvolve_ComBPMaster.Controls.Add(Me.ComBPMaster)
        Me.PanelEnvolve_ComBPMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_ComBPMaster.Location = New System.Drawing.Point(3, 3)
        Me.PanelEnvolve_ComBPMaster.Name = "PanelEnvolve_ComBPMaster"
        Me.PanelEnvolve_ComBPMaster.Size = New System.Drawing.Size(161, 22)
        Me.PanelEnvolve_ComBPMaster.TabIndex = 4
        '
        'Panel_Right
        '
        Me.Panel_Right.Controls.Add(Me.PanelEnvolve_RightTXT)
        Me.Panel_Right.Controls.Add(Me.PanelEnvolve_ComBRight)
        Me.Panel_Right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Right.Location = New System.Drawing.Point(349, 3)
        Me.Panel_Right.Name = "Panel_Right"
        Me.Panel_Right.Size = New System.Drawing.Size(163, 22)
        Me.Panel_Right.TabIndex = 6
        '
        'PanelEnvolve_RightTXT
        '
        Me.PanelEnvolve_RightTXT.Controls.Add(Me.TXTPValue)
        Me.PanelEnvolve_RightTXT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_RightTXT.Location = New System.Drawing.Point(0, 0)
        Me.PanelEnvolve_RightTXT.Name = "PanelEnvolve_RightTXT"
        Me.PanelEnvolve_RightTXT.Size = New System.Drawing.Size(163, 22)
        Me.PanelEnvolve_RightTXT.TabIndex = 3
        '
        'TXTPValue
        '
        Me.TXTPValue.ActiveValidate = False
        Me.TXTPValue.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTPValue.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPValue.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.TXTPValue.BorderColorError = System.Drawing.Color.Red
        Me.TXTPValue.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTPValue.ByChar = False
        Me.TXTPValue.ByText = False
        Me.TXTPValue.ByValue = False
        Me.TXTPValue.ChangeCursorFocus = True
        Me.TXTPValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTPValue.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.TXTPValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTPValue.ErrorDisplay = False
        Me.TXTPValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPValue.Fonte = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPValue.ForeColor = System.Drawing.Color.DarkGray
        Me.TXTPValue.ForeColorActive = System.Drawing.Color.DarkGray
        Me.TXTPValue.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.TXTPValue.HideSelection = True
        Me.TXTPValue.LeftIndentation = 6
        Me.TXTPValue.Location = New System.Drawing.Point(0, 0)
        Me.TXTPValue.MaxLength = 32767
        Me.TXTPValue.MultiLine = False
        Me.TXTPValue.Name = "TXTPValue"
        Me.TXTPValue.NoneOfThisChar = ""
        Me.TXTPValue.NoneOfThisText = Nothing
        Me.TXTPValue.NoneOfThisValue = Nothing
        Me.TXTPValue.OnlyAlfaNumber = False
        Me.TXTPValue.OnlyCaracterText = False
        Me.TXTPValue.OnlyNumber = False
        Me.TXTPValue.PaddingText = New System.Windows.Forms.Padding(2, 3, 2, 2)
        Me.TXTPValue.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPValue.PersonBorder = New System.Windows.Forms.Padding(1)
        Me.TXTPValue.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.TXTPValue.Placeholder = "Digite algo ..."
        Me.TXTPValue.Read_Only = False
        Me.TXTPValue.RequiredChar = ""
        Me.TXTPValue.RequiredText = Nothing
        Me.TXTPValue.RequiredValue = Nothing
        Me.TXTPValue.RightIndentation = 0
        Me.TXTPValue.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.TXTPValue.Size = New System.Drawing.Size(163, 21)
        Me.TXTPValue.SpaceError = False
        Me.TXTPValue.TabIndex = 2
        Me.TXTPValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTPValue.ThisSize = New System.Drawing.Size(163, 21)
        Me.TXTPValue.TXT = Nothing
        Me.TXTPValue.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPValue.UseSystemPasswordChar = False
        Me.TXTPValue.WordWrap = True
        '
        'PanelEnvolve_ComBRight
        '
        Me.PanelEnvolve_ComBRight.Controls.Add(Me.ComBRight)
        Me.PanelEnvolve_ComBRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_ComBRight.Location = New System.Drawing.Point(0, 0)
        Me.PanelEnvolve_ComBRight.Name = "PanelEnvolve_ComBRight"
        Me.PanelEnvolve_ComBRight.Size = New System.Drawing.Size(163, 22)
        Me.PanelEnvolve_ComBRight.TabIndex = 4
        '
        'ComBRight
        '
        Me.ComBRight.AutomaticSelect = True
        Me.ComBRight.AutoSize = True
        Me.ComBRight.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ComBRight.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ComBRight.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ComBRight.BorderColorError = System.Drawing.Color.Red
        Me.ComBRight.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ComBRight.ComboBoxPersonMaster = Nothing
        Me.ComBRight.ComboBoxPersonSlave = Nothing
        Me.ComBRight.ComboBoxPersonSlaveLists = CType(resources.GetObject("ComBRight.ComboBoxPersonSlaveLists"), System.Collections.Specialized.StringCollection)
        Me.ComBRight.DataReturn = Nothing
        Me.ComBRight.DefaultOptionsList = CType(resources.GetObject("ComBRight.DefaultOptionsList"), System.Collections.Specialized.StringCollection)
        Me.ComBRight.DefaultOptionsListSlave = CType(resources.GetObject("ComBRight.DefaultOptionsListSlave"), System.Collections.Specialized.StringCollection)
        Me.ComBRight.DisplayAparence = TrevoWebMedia.Control_ComboBoxPerson.DisplayAparenceEnum.None
        Me.ComBRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComBRight.ForeColorActive = System.Drawing.Color.DarkGray
        Me.ComBRight.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.ComBRight.HideWhenEmptyList = False
        Me.ComBRight.ListaDeOpçõesPadrão = Nothing
        Me.ComBRight.Location = New System.Drawing.Point(0, 0)
        Me.ComBRight.Name = "ComBRight"
        Me.ComBRight.Nivel = 0
        Me.ComBRight.OptionsList = CType(resources.GetObject("ComBRight.OptionsList"), System.Collections.Specialized.StringCollection)
        Me.ComBRight.ReturnStringList = CType(resources.GetObject("ComBRight.ReturnStringList"), System.Collections.Specialized.StringCollection)
        Me.ComBRight.ReturnType = TrevoWebMedia.Control_ComboBoxPerson.ReturnTypeEnum.None
        Me.ComBRight.ShortcutKeyDisplay = True
        Me.ComBRight.Size = New System.Drawing.Size(163, 22)
        Me.ComBRight.TabIndex = 0
        Me.ComBRight.TextDisplay = "<Selecione>"
        Me.ComBRight.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        '
        'PanelRightButtons
        '
        Me.PanelRightButtons.Controls.Add(Me.TableLPButtons)
        Me.PanelRightButtons.Controls.Add(Me.Button1)
        Me.PanelRightButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRightButtons.Location = New System.Drawing.Point(541, 0)
        Me.PanelRightButtons.Name = "PanelRightButtons"
        Me.PanelRightButtons.Size = New System.Drawing.Size(54, 106)
        Me.PanelRightButtons.TabIndex = 3
        '
        'TableLPButtons
        '
        Me.TableLPButtons.ColumnCount = 2
        Me.TableLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLPButtons.Controls.Add(Me.BTNAddRenomeDeOrigem, 1, 0)
        Me.TableLPButtons.Controls.Add(Me.BTNRemoveRenomeDeOrigem, 0, 0)
        Me.TableLPButtons.Location = New System.Drawing.Point(0, 16)
        Me.TableLPButtons.Name = "TableLPButtons"
        Me.TableLPButtons.RowCount = 1
        Me.TableLPButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLPButtons.Size = New System.Drawing.Size(42, 21)
        Me.TableLPButtons.TabIndex = 1
        '
        'BTNAddRenomeDeOrigem
        '
        Me.BTNAddRenomeDeOrigem.BackgroundImage = CType(resources.GetObject("BTNAddRenomeDeOrigem.BackgroundImage"), System.Drawing.Image)
        Me.BTNAddRenomeDeOrigem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNAddRenomeDeOrigem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNAddRenomeDeOrigem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNAddRenomeDeOrigem.FlatAppearance.BorderSize = 0
        Me.BTNAddRenomeDeOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNAddRenomeDeOrigem.Location = New System.Drawing.Point(24, 3)
        Me.BTNAddRenomeDeOrigem.Name = "BTNAddRenomeDeOrigem"
        Me.BTNAddRenomeDeOrigem.Size = New System.Drawing.Size(15, 15)
        Me.BTNAddRenomeDeOrigem.TabIndex = 4
        Me.BTNAddRenomeDeOrigem.Tag = ""
        '
        'BTNRemoveRenomeDeOrigem
        '
        Me.BTNRemoveRenomeDeOrigem.BackgroundImage = CType(resources.GetObject("BTNRemoveRenomeDeOrigem.BackgroundImage"), System.Drawing.Image)
        Me.BTNRemoveRenomeDeOrigem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNRemoveRenomeDeOrigem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNRemoveRenomeDeOrigem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNRemoveRenomeDeOrigem.FlatAppearance.BorderSize = 0
        Me.BTNRemoveRenomeDeOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRemoveRenomeDeOrigem.Location = New System.Drawing.Point(3, 3)
        Me.BTNRemoveRenomeDeOrigem.Name = "BTNRemoveRenomeDeOrigem"
        Me.BTNRemoveRenomeDeOrigem.Size = New System.Drawing.Size(15, 15)
        Me.BTNRemoveRenomeDeOrigem.TabIndex = 3
        Me.BTNRemoveRenomeDeOrigem.Tag = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(37, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(17, 18)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "String"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'PanelMagemBotton
        '
        Me.PanelMagemBotton.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelMagemBotton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMagemBotton.Location = New System.Drawing.Point(0, 106)
        Me.PanelMagemBotton.Name = "PanelMagemBotton"
        Me.PanelMagemBotton.Size = New System.Drawing.Size(595, 1)
        Me.PanelMagemBotton.TabIndex = 0
        '
        'Control_RenameOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelElemento)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.Name = "Control_RenameOption"
        Me.Size = New System.Drawing.Size(595, 107)
        Me.PanelElemento.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelBase.ResumeLayout(False)
        Me.PanelDateConfig.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelNomeDoArquivoAtualConfig.ResumeLayout(False)
        Me.TableDoArquivoAtualConfig.ResumeLayout(False)
        Me.TableDoArquivoAtualConfig.PerformLayout()
        Me.TableLPContainer.ResumeLayout(False)
        Me.PanelEnvolve_ComBPSlave.ResumeLayout(False)
        Me.PanelEnvolve_ComBPSlave.PerformLayout()
        Me.PanelEnvolve_ComBPMaster.ResumeLayout(False)
        Me.PanelEnvolve_ComBPMaster.PerformLayout()
        Me.Panel_Right.ResumeLayout(False)
        Me.PanelEnvolve_RightTXT.ResumeLayout(False)
        Me.PanelEnvolve_ComBRight.ResumeLayout(False)
        Me.PanelEnvolve_ComBRight.PerformLayout()
        Me.PanelRightButtons.ResumeLayout(False)
        Me.TableLPButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelElemento As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents TableLPContainer As TableLayoutPanel
    Friend WithEvents PanelRightButtons As Panel
    Friend WithEvents TableLPButtons As TableLayoutPanel
    Friend WithEvents BTNAddRenomeDeOrigem As Button
    Friend WithEvents BTNRemoveRenomeDeOrigem As Button
    Friend WithEvents PanelMagemBotton As Panel
    Friend WithEvents PanelEnvolve_ComBPMaster As Panel
    Friend WithEvents ComBPMaster As Control_ComboBoxPerson
    Friend WithEvents PanelEnvolve_ComBPSlave As Panel
    Friend WithEvents ComBPSlave As Control_ComboBoxPerson
    Friend WithEvents Panel_Right As Panel
    Friend WithEvents TXTPValue As Control_TextBoxPerson
    Friend WithEvents PanelEnvolve_RightTXT As Panel
    Friend WithEvents PanelEnvolve_ComBRight As Panel
    Friend WithEvents ComBRight As Control_ComboBoxPerson
    Friend WithEvents PanelBase As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelNomeDoArquivoAtualConfig As Panel
    Friend WithEvents TableDoArquivoAtualConfig As TableLayoutPanel
    Friend WithEvents CKB_RemoveSpace As CheckBox
    Friend WithEvents CKB_FirstLetterUpper As CheckBox
    Friend WithEvents PanelDateConfig As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ComBPFormatText As Control_ComboBoxPerson
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TXTPSubstituirEspaco As Control_TextBoxPerson
    Friend WithEvents CHKSubstituirEspaco As CheckBox
    Friend WithEvents PanelSubstituir As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
