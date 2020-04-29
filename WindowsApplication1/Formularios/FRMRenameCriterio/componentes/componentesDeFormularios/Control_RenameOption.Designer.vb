<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_RenameOption
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Control_RenameOption))
        Me.PanelElemento = New System.Windows.Forms.Panel()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.TableLPContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelEnvolve_ComBPMaster = New System.Windows.Forms.Panel()
        Me.PanelEnvolve_ComBPSlave = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelRightButtons = New System.Windows.Forms.Panel()
        Me.TableLPButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.BTNCancelaRenomeDeOrigem = New System.Windows.Forms.Button()
        Me.BTNConfirmarRenomeDeOrigem = New System.Windows.Forms.Button()
        Me.PanelMagemBotton = New System.Windows.Forms.Panel()
        Me.ComBPMaster = New TrevoWebMedia.Control_ComboBoxPerson()
        Me.ComBPSlave = New TrevoWebMedia.Control_ComboBoxPerson()
        Me.Control_TextBoxPerson1 = New TrevoWebMedia.Control_TextBoxPerson()
        Me.PanelElemento.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.TableLPContainer.SuspendLayout()
        Me.PanelEnvolve_ComBPMaster.SuspendLayout()
        Me.PanelEnvolve_ComBPSlave.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.PanelElemento.Size = New System.Drawing.Size(595, 54)
        Me.PanelElemento.TabIndex = 1
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.TableLPContainer)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Padding = New System.Windows.Forms.Padding(13)
        Me.PanelContainer.Size = New System.Drawing.Size(541, 53)
        Me.PanelContainer.TabIndex = 4
        '
        'TableLPContainer
        '
        Me.TableLPContainer.ColumnCount = 5
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199.0!))
        Me.TableLPContainer.Controls.Add(Me.PanelEnvolve_ComBPMaster, 0, 0)
        Me.TableLPContainer.Controls.Add(Me.PanelEnvolve_ComBPSlave, 2, 0)
        Me.TableLPContainer.Controls.Add(Me.Panel1, 4, 0)
        Me.TableLPContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLPContainer.Location = New System.Drawing.Point(13, 13)
        Me.TableLPContainer.Name = "TableLPContainer"
        Me.TableLPContainer.RowCount = 1
        Me.TableLPContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLPContainer.Size = New System.Drawing.Size(515, 27)
        Me.TableLPContainer.TabIndex = 5
        '
        'PanelEnvolve_ComBPMaster
        '
        Me.PanelEnvolve_ComBPMaster.Controls.Add(Me.ComBPMaster)
        Me.PanelEnvolve_ComBPMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_ComBPMaster.Location = New System.Drawing.Point(3, 3)
        Me.PanelEnvolve_ComBPMaster.Name = "PanelEnvolve_ComBPMaster"
        Me.PanelEnvolve_ComBPMaster.Size = New System.Drawing.Size(154, 21)
        Me.PanelEnvolve_ComBPMaster.TabIndex = 4
        '
        'PanelEnvolve_ComBPSlave
        '
        Me.PanelEnvolve_ComBPSlave.Controls.Add(Me.ComBPSlave)
        Me.PanelEnvolve_ComBPSlave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_ComBPSlave.Location = New System.Drawing.Point(171, 3)
        Me.PanelEnvolve_ComBPSlave.Name = "PanelEnvolve_ComBPSlave"
        Me.PanelEnvolve_ComBPSlave.Size = New System.Drawing.Size(154, 21)
        Me.PanelEnvolve_ComBPSlave.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Control_TextBoxPerson1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(339, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 21)
        Me.Panel1.TabIndex = 6
        '
        'PanelRightButtons
        '
        Me.PanelRightButtons.Controls.Add(Me.TableLPButtons)
        Me.PanelRightButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRightButtons.Location = New System.Drawing.Point(541, 0)
        Me.PanelRightButtons.Name = "PanelRightButtons"
        Me.PanelRightButtons.Size = New System.Drawing.Size(54, 53)
        Me.PanelRightButtons.TabIndex = 3
        '
        'TableLPButtons
        '
        Me.TableLPButtons.ColumnCount = 2
        Me.TableLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLPButtons.Controls.Add(Me.BTNCancelaRenomeDeOrigem, 1, 0)
        Me.TableLPButtons.Controls.Add(Me.BTNConfirmarRenomeDeOrigem, 0, 0)
        Me.TableLPButtons.Location = New System.Drawing.Point(0, 15)
        Me.TableLPButtons.Name = "TableLPButtons"
        Me.TableLPButtons.RowCount = 1
        Me.TableLPButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLPButtons.Size = New System.Drawing.Size(42, 21)
        Me.TableLPButtons.TabIndex = 1
        '
        'BTNCancelaRenomeDeOrigem
        '
        Me.BTNCancelaRenomeDeOrigem.BackgroundImage = CType(resources.GetObject("BTNCancelaRenomeDeOrigem.BackgroundImage"), System.Drawing.Image)
        Me.BTNCancelaRenomeDeOrigem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNCancelaRenomeDeOrigem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCancelaRenomeDeOrigem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNCancelaRenomeDeOrigem.FlatAppearance.BorderSize = 0
        Me.BTNCancelaRenomeDeOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCancelaRenomeDeOrigem.Location = New System.Drawing.Point(24, 3)
        Me.BTNCancelaRenomeDeOrigem.Name = "BTNCancelaRenomeDeOrigem"
        Me.BTNCancelaRenomeDeOrigem.Size = New System.Drawing.Size(15, 15)
        Me.BTNCancelaRenomeDeOrigem.TabIndex = 11
        Me.BTNCancelaRenomeDeOrigem.Tag = ""
        '
        'BTNConfirmarRenomeDeOrigem
        '
        Me.BTNConfirmarRenomeDeOrigem.BackgroundImage = CType(resources.GetObject("BTNConfirmarRenomeDeOrigem.BackgroundImage"), System.Drawing.Image)
        Me.BTNConfirmarRenomeDeOrigem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNConfirmarRenomeDeOrigem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNConfirmarRenomeDeOrigem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNConfirmarRenomeDeOrigem.FlatAppearance.BorderSize = 0
        Me.BTNConfirmarRenomeDeOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNConfirmarRenomeDeOrigem.Location = New System.Drawing.Point(3, 3)
        Me.BTNConfirmarRenomeDeOrigem.Name = "BTNConfirmarRenomeDeOrigem"
        Me.BTNConfirmarRenomeDeOrigem.Size = New System.Drawing.Size(15, 15)
        Me.BTNConfirmarRenomeDeOrigem.TabIndex = 10
        Me.BTNConfirmarRenomeDeOrigem.Tag = ""
        '
        'PanelMagemBotton
        '
        Me.PanelMagemBotton.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelMagemBotton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMagemBotton.Location = New System.Drawing.Point(0, 53)
        Me.PanelMagemBotton.Name = "PanelMagemBotton"
        Me.PanelMagemBotton.Size = New System.Drawing.Size(595, 1)
        Me.PanelMagemBotton.TabIndex = 0
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
        Me.ComBPMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComBPMaster.HideWhenEmptyList = False
        Me.ComBPMaster.ListaDeOpçõesPadrão = Nothing
        Me.ComBPMaster.Location = New System.Drawing.Point(0, 0)
        Me.ComBPMaster.Name = "ComBPMaster"
        Me.ComBPMaster.Nivel = 0
        Me.ComBPMaster.OptionsList = CType(resources.GetObject("ComBPMaster.OptionsList"), System.Collections.Specialized.StringCollection)
        Me.ComBPMaster.ReturnStringList = CType(resources.GetObject("ComBPMaster.ReturnStringList"), System.Collections.Specialized.StringCollection)
        Me.ComBPMaster.ReturnType = TrevoWebMedia.Control_ComboBoxPerson.ReturnTypeEnum.MenuItemType
        Me.ComBPMaster.ShortcutKeyDisplay = True
        Me.ComBPMaster.Size = New System.Drawing.Size(154, 21)
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
        Me.ComBPSlave.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.ComBPSlave.Size = New System.Drawing.Size(154, 21)
        Me.ComBPSlave.TabIndex = 0
        Me.ComBPSlave.TextDisplay = "<Selecione>"
        Me.ComBPSlave.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        '
        'Control_TextBoxPerson1
        '
        Me.Control_TextBoxPerson1.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Control_TextBoxPerson1.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Control_TextBoxPerson1.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Control_TextBoxPerson1.BorderColorError = System.Drawing.Color.Red
        Me.Control_TextBoxPerson1.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Control_TextBoxPerson1.ChangeCursorFocus = True
        Me.Control_TextBoxPerson1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Control_TextBoxPerson1.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.Control_TextBoxPerson1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Control_TextBoxPerson1.ErrorDisplay = False
        Me.Control_TextBoxPerson1.ForeColor = System.Drawing.Color.DarkGray
        Me.Control_TextBoxPerson1.ForeColorActive = System.Drawing.Color.DarkGray
        Me.Control_TextBoxPerson1.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.Control_TextBoxPerson1.HideSelection = False
        Me.Control_TextBoxPerson1.LeftIndentation = 6
        Me.Control_TextBoxPerson1.Location = New System.Drawing.Point(0, 0)
        Me.Control_TextBoxPerson1.MaximumSize = New System.Drawing.Size(0, 19)
        Me.Control_TextBoxPerson1.MinimumSize = New System.Drawing.Size(173, 21)
        Me.Control_TextBoxPerson1.MultiLine = False
        Me.Control_TextBoxPerson1.Name = "Control_TextBoxPerson1"
        Me.Control_TextBoxPerson1.PaddingText = New System.Windows.Forms.Padding(2)
        Me.Control_TextBoxPerson1.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.Control_TextBoxPerson1.PersonBorder = New System.Windows.Forms.Padding(1)
        Me.Control_TextBoxPerson1.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.Control_TextBoxPerson1.Placeholder = "Digite algo ..."
        Me.Control_TextBoxPerson1.Read_Only = False
        Me.Control_TextBoxPerson1.RightIndentation = 0
        Me.Control_TextBoxPerson1.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.Control_TextBoxPerson1.Size = New System.Drawing.Size(173, 21)
        Me.Control_TextBoxPerson1.TabIndex = 0
        Me.Control_TextBoxPerson1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Control_TextBoxPerson1.ThisSize = New System.Drawing.Size(173, 21)
        Me.Control_TextBoxPerson1.TXT = Nothing
        Me.Control_TextBoxPerson1.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Control_TextBoxPerson1.UseSystemPasswordChar = False
        Me.Control_TextBoxPerson1.WordWrap = True
        '
        'Control_RenameOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelElemento)
        Me.Name = "Control_RenameOption"
        Me.Size = New System.Drawing.Size(595, 54)
        Me.PanelElemento.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.TableLPContainer.ResumeLayout(False)
        Me.PanelEnvolve_ComBPMaster.ResumeLayout(False)
        Me.PanelEnvolve_ComBPMaster.PerformLayout()
        Me.PanelEnvolve_ComBPSlave.ResumeLayout(False)
        Me.PanelEnvolve_ComBPSlave.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanelRightButtons.ResumeLayout(False)
        Me.TableLPButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelElemento As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents TableLPContainer As TableLayoutPanel
    Friend WithEvents PanelRightButtons As Panel
    Friend WithEvents TableLPButtons As TableLayoutPanel
    Friend WithEvents BTNCancelaRenomeDeOrigem As Button
    Friend WithEvents BTNConfirmarRenomeDeOrigem As Button
    Friend WithEvents PanelMagemBotton As Panel
    Friend WithEvents PanelEnvolve_ComBPMaster As Panel
    Friend WithEvents ComBPMaster As Control_ComboBoxPerson
    Friend WithEvents PanelEnvolve_ComBPSlave As Panel
    Friend WithEvents ComBPSlave As Control_ComboBoxPerson
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Control_TextBoxPerson1 As Control_TextBoxPerson
End Class
