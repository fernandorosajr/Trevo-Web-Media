﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Control_RenameOption))
        Me.PanelElemento = New System.Windows.Forms.Panel()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.PanelSubstituir = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Control_TextBoxPerson2 = New TrevoWebMedia.Control_TextBoxPerson()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXTPPesquisar = New TrevoWebMedia.Control_TextBoxPerson()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TableLPContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelEnvolve_ComBPMaster = New System.Windows.Forms.Panel()
        Me.ComBPMaster = New TrevoWebMedia.Control_ComboBoxPerson()
        Me.ComBPSlave = New TrevoWebMedia.Control_ComboBoxPerson()
        Me.PanelEnvolve_ComBPSlave = New System.Windows.Forms.Panel()
        Me.Panel_Right = New System.Windows.Forms.Panel()
        Me.PanelEnvolve_ComBRight = New System.Windows.Forms.Panel()
        Me.ComBRight = New TrevoWebMedia.Control_ComboBoxPerson()
        Me.PanelEnvolve_TXT = New System.Windows.Forms.Panel()
        Me.TXTPerson = New TrevoWebMedia.Control_TextBoxPerson()
        Me.PanelRightButtons = New System.Windows.Forms.Panel()
        Me.TableLPButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.BTNAddRenomeDeOrigem = New System.Windows.Forms.Button()
        Me.BTNRemoveRenomeDeOrigem = New System.Windows.Forms.Button()
        Me.PanelMagemBotton = New System.Windows.Forms.Panel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.PanelElemento.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.PanelSubstituir.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLPContainer.SuspendLayout()
        Me.PanelEnvolve_ComBPMaster.SuspendLayout()
        Me.PanelEnvolve_ComBPSlave.SuspendLayout()
        Me.Panel_Right.SuspendLayout()
        Me.PanelEnvolve_ComBRight.SuspendLayout()
        Me.PanelEnvolve_TXT.SuspendLayout()
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
        Me.PanelElemento.Size = New System.Drawing.Size(595, 111)
        Me.PanelElemento.TabIndex = 1
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.PanelSubstituir)
        Me.PanelContainer.Controls.Add(Me.TableLPContainer)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Padding = New System.Windows.Forms.Padding(13)
        Me.PanelContainer.Size = New System.Drawing.Size(541, 110)
        Me.PanelContainer.TabIndex = 4
        '
        'PanelSubstituir
        '
        Me.PanelSubstituir.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelSubstituir.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelSubstituir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSubstituir.Location = New System.Drawing.Point(13, 41)
        Me.PanelSubstituir.Name = "PanelSubstituir"
        Me.PanelSubstituir.Padding = New System.Windows.Forms.Padding(50, 5, 5, 0)
        Me.PanelSubstituir.Size = New System.Drawing.Size(515, 56)
        Me.PanelSubstituir.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(50, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(460, 51)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Control_TextBoxPerson2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(233, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(224, 21)
        Me.Panel2.TabIndex = 1
        '
        'Control_TextBoxPerson2
        '
        Me.Control_TextBoxPerson2.ActiveValidate = False
        Me.Control_TextBoxPerson2.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Control_TextBoxPerson2.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Control_TextBoxPerson2.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Control_TextBoxPerson2.BorderColorError = System.Drawing.Color.Red
        Me.Control_TextBoxPerson2.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Control_TextBoxPerson2.ByChar = False
        Me.Control_TextBoxPerson2.ByText = False
        Me.Control_TextBoxPerson2.ByValue = False
        Me.Control_TextBoxPerson2.ChangeCursorFocus = True
        Me.Control_TextBoxPerson2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Control_TextBoxPerson2.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.Control_TextBoxPerson2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Control_TextBoxPerson2.ErrorDisplay = False
        Me.Control_TextBoxPerson2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Control_TextBoxPerson2.Fonte = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Control_TextBoxPerson2.ForeColor = System.Drawing.Color.DarkGray
        Me.Control_TextBoxPerson2.ForeColorActive = System.Drawing.Color.DarkGray
        Me.Control_TextBoxPerson2.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.Control_TextBoxPerson2.HideSelection = True
        Me.Control_TextBoxPerson2.LeftIndentation = 6
        Me.Control_TextBoxPerson2.Location = New System.Drawing.Point(83, 0)
        Me.Control_TextBoxPerson2.MultiLine = False
        Me.Control_TextBoxPerson2.Name = "Control_TextBoxPerson2"
        Me.Control_TextBoxPerson2.NoneOfThisChar = ""
        Me.Control_TextBoxPerson2.NoneOfThisText = Nothing
        Me.Control_TextBoxPerson2.NoneOfThisValue = Nothing
        Me.Control_TextBoxPerson2.PaddingText = New System.Windows.Forms.Padding(2)
        Me.Control_TextBoxPerson2.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.Control_TextBoxPerson2.PersonBorder = New System.Windows.Forms.Padding(1)
        Me.Control_TextBoxPerson2.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.Control_TextBoxPerson2.Placeholder = Nothing
        Me.Control_TextBoxPerson2.Read_Only = False
        Me.Control_TextBoxPerson2.RequiredChar = ""
        Me.Control_TextBoxPerson2.RequiredText = Nothing
        Me.Control_TextBoxPerson2.RequiredValue = Nothing
        Me.Control_TextBoxPerson2.RightIndentation = 0
        Me.Control_TextBoxPerson2.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.Control_TextBoxPerson2.Size = New System.Drawing.Size(141, 21)
        Me.Control_TextBoxPerson2.SpaceError = False
        Me.Control_TextBoxPerson2.TabIndex = 1
        Me.Control_TextBoxPerson2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Control_TextBoxPerson2.ThisSize = New System.Drawing.Size(141, 21)
        Me.Control_TextBoxPerson2.TXT = Nothing
        Me.Control_TextBoxPerson2.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Control_TextBoxPerson2.UseSystemPasswordChar = False
        Me.Control_TextBoxPerson2.WordWrap = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Substituir por:    "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TXTPPesquisar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 21)
        Me.Panel1.TabIndex = 0
        '
        'TXTPPesquisar
        '
        Me.TXTPPesquisar.ActiveValidate = False
        Me.TXTPPesquisar.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTPPesquisar.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPPesquisar.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.TXTPPesquisar.BorderColorError = System.Drawing.Color.Red
        Me.TXTPPesquisar.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTPPesquisar.ByChar = False
        Me.TXTPPesquisar.ByText = False
        Me.TXTPPesquisar.ByValue = False
        Me.TXTPPesquisar.ChangeCursorFocus = True
        Me.TXTPPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTPPesquisar.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.TXTPPesquisar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTPPesquisar.ErrorDisplay = False
        Me.TXTPPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPPesquisar.Fonte = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPPesquisar.ForeColor = System.Drawing.Color.DarkGray
        Me.TXTPPesquisar.ForeColorActive = System.Drawing.Color.DarkGray
        Me.TXTPPesquisar.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.TXTPPesquisar.HideSelection = True
        Me.TXTPPesquisar.LeftIndentation = 6
        Me.TXTPPesquisar.Location = New System.Drawing.Point(68, 0)
        Me.TXTPPesquisar.MultiLine = False
        Me.TXTPPesquisar.Name = "TXTPPesquisar"
        Me.TXTPPesquisar.NoneOfThisChar = ""
        Me.TXTPPesquisar.NoneOfThisText = Nothing
        Me.TXTPPesquisar.NoneOfThisValue = Nothing
        Me.TXTPPesquisar.PaddingText = New System.Windows.Forms.Padding(2)
        Me.TXTPPesquisar.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPPesquisar.PersonBorder = New System.Windows.Forms.Padding(1)
        Me.TXTPPesquisar.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.TXTPPesquisar.Placeholder = Nothing
        Me.TXTPPesquisar.Read_Only = False
        Me.TXTPPesquisar.RequiredChar = ""
        Me.TXTPPesquisar.RequiredText = Nothing
        Me.TXTPPesquisar.RequiredValue = Nothing
        Me.TXTPPesquisar.RightIndentation = 0
        Me.TXTPPesquisar.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.TXTPPesquisar.Size = New System.Drawing.Size(156, 21)
        Me.TXTPPesquisar.SpaceError = False
        Me.TXTPPesquisar.TabIndex = 1
        Me.TXTPPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTPPesquisar.ThisSize = New System.Drawing.Size(156, 21)
        Me.TXTPPesquisar.TXT = Nothing
        Me.TXTPPesquisar.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPPesquisar.UseSystemPasswordChar = False
        Me.TXTPPesquisar.WordWrap = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pesquisar:    "
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(3, 30)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(168, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Ignorar maiúscula e minúscula"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(233, 30)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "Substituir tudo"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TableLPContainer
        '
        Me.TableLPContainer.ColumnCount = 5
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.46287!))
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.306566!))
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.46288!))
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.306566!))
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.46112!))
        Me.TableLPContainer.Controls.Add(Me.PanelEnvolve_ComBPMaster, 0, 0)
        Me.TableLPContainer.Controls.Add(Me.PanelEnvolve_ComBPSlave, 2, 0)
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
        'PanelEnvolve_ComBPMaster
        '
        Me.PanelEnvolve_ComBPMaster.Controls.Add(Me.ComBPMaster)
        Me.PanelEnvolve_ComBPMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_ComBPMaster.Location = New System.Drawing.Point(3, 3)
        Me.PanelEnvolve_ComBPMaster.Name = "PanelEnvolve_ComBPMaster"
        Me.PanelEnvolve_ComBPMaster.Size = New System.Drawing.Size(161, 22)
        Me.PanelEnvolve_ComBPMaster.TabIndex = 4
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
        Me.ComBPMaster.ReturnType = TrevoWebMedia.Control_ComboBoxPerson.ReturnTypeEnum.MenuItemType
        Me.ComBPMaster.ShortcutKeyDisplay = True
        Me.ComBPMaster.Size = New System.Drawing.Size(161, 22)
        Me.ComBPMaster.TabIndex = 0
        Me.ComBPMaster.TextDisplay = "Texto"
        Me.ComBPMaster.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
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
        'PanelEnvolve_ComBPSlave
        '
        Me.PanelEnvolve_ComBPSlave.Controls.Add(Me.ComBPSlave)
        Me.PanelEnvolve_ComBPSlave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_ComBPSlave.Location = New System.Drawing.Point(176, 3)
        Me.PanelEnvolve_ComBPSlave.Name = "PanelEnvolve_ComBPSlave"
        Me.PanelEnvolve_ComBPSlave.Size = New System.Drawing.Size(161, 22)
        Me.PanelEnvolve_ComBPSlave.TabIndex = 5
        '
        'Panel_Right
        '
        Me.Panel_Right.Controls.Add(Me.PanelEnvolve_ComBRight)
        Me.Panel_Right.Controls.Add(Me.PanelEnvolve_TXT)
        Me.Panel_Right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Right.Location = New System.Drawing.Point(349, 3)
        Me.Panel_Right.Name = "Panel_Right"
        Me.Panel_Right.Size = New System.Drawing.Size(163, 22)
        Me.Panel_Right.TabIndex = 6
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
        'PanelEnvolve_TXT
        '
        Me.PanelEnvolve_TXT.Controls.Add(Me.TXTPerson)
        Me.PanelEnvolve_TXT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_TXT.Location = New System.Drawing.Point(0, 0)
        Me.PanelEnvolve_TXT.Name = "PanelEnvolve_TXT"
        Me.PanelEnvolve_TXT.Size = New System.Drawing.Size(163, 22)
        Me.PanelEnvolve_TXT.TabIndex = 3
        '
        'TXTPerson
        '
        Me.TXTPerson.ActiveValidate = False
        Me.TXTPerson.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTPerson.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPerson.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.TXTPerson.BorderColorError = System.Drawing.Color.Red
        Me.TXTPerson.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTPerson.ByChar = False
        Me.TXTPerson.ByText = False
        Me.TXTPerson.ByValue = False
        Me.TXTPerson.ChangeCursorFocus = True
        Me.TXTPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTPerson.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.TXTPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTPerson.ErrorDisplay = False
        Me.TXTPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPerson.Fonte = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPerson.ForeColor = System.Drawing.Color.DarkGray
        Me.TXTPerson.ForeColorActive = System.Drawing.Color.DarkGray
        Me.TXTPerson.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.TXTPerson.HideSelection = True
        Me.TXTPerson.LeftIndentation = 6
        Me.TXTPerson.Location = New System.Drawing.Point(0, 0)
        Me.TXTPerson.MultiLine = False
        Me.TXTPerson.Name = "TXTPerson"
        Me.TXTPerson.NoneOfThisChar = ""
        Me.TXTPerson.NoneOfThisText = Nothing
        Me.TXTPerson.NoneOfThisValue = Nothing
        Me.TXTPerson.PaddingText = New System.Windows.Forms.Padding(2)
        Me.TXTPerson.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPerson.PersonBorder = New System.Windows.Forms.Padding(1)
        Me.TXTPerson.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.TXTPerson.Placeholder = "Digite algo ..."
        Me.TXTPerson.Read_Only = False
        Me.TXTPerson.RequiredChar = ""
        Me.TXTPerson.RequiredText = Nothing
        Me.TXTPerson.RequiredValue = Nothing
        Me.TXTPerson.RightIndentation = 0
        Me.TXTPerson.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.TXTPerson.Size = New System.Drawing.Size(163, 21)
        Me.TXTPerson.SpaceError = False
        Me.TXTPerson.TabIndex = 2
        Me.TXTPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTPerson.ThisSize = New System.Drawing.Size(163, 21)
        Me.TXTPerson.TXT = Nothing
        Me.TXTPerson.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPerson.UseSystemPasswordChar = False
        Me.TXTPerson.WordWrap = True
        '
        'PanelRightButtons
        '
        Me.PanelRightButtons.Controls.Add(Me.TableLPButtons)
        Me.PanelRightButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRightButtons.Location = New System.Drawing.Point(541, 0)
        Me.PanelRightButtons.Name = "PanelRightButtons"
        Me.PanelRightButtons.Size = New System.Drawing.Size(54, 110)
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
        'PanelMagemBotton
        '
        Me.PanelMagemBotton.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelMagemBotton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMagemBotton.Location = New System.Drawing.Point(0, 110)
        Me.PanelMagemBotton.Name = "PanelMagemBotton"
        Me.PanelMagemBotton.Size = New System.Drawing.Size(595, 1)
        Me.PanelMagemBotton.TabIndex = 0
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'Control_RenameOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelElemento)
        Me.ForeColor = System.Drawing.Color.DarkGray
        Me.Name = "Control_RenameOption"
        Me.Size = New System.Drawing.Size(595, 111)
        Me.PanelElemento.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelSubstituir.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLPContainer.ResumeLayout(False)
        Me.PanelEnvolve_ComBPMaster.ResumeLayout(False)
        Me.PanelEnvolve_ComBPMaster.PerformLayout()
        Me.PanelEnvolve_ComBPSlave.ResumeLayout(False)
        Me.PanelEnvolve_ComBPSlave.PerformLayout()
        Me.Panel_Right.ResumeLayout(False)
        Me.PanelEnvolve_ComBRight.ResumeLayout(False)
        Me.PanelEnvolve_ComBRight.PerformLayout()
        Me.PanelEnvolve_TXT.ResumeLayout(False)
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
    Friend WithEvents TXTPerson As Control_TextBoxPerson
    Friend WithEvents PanelEnvolve_TXT As Panel
    Friend WithEvents PanelEnvolve_ComBRight As Panel
    Friend WithEvents ComBRight As Control_ComboBoxPerson
    Friend WithEvents PanelSubstituir As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TXTPPesquisar As Control_TextBoxPerson
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Control_TextBoxPerson2 As Control_TextBoxPerson
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Timer As Timer
End Class
