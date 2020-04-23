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
        Me.PanelTXT = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PanelRightButtons = New System.Windows.Forms.Panel()
        Me.TableLPButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelMagemBotton = New System.Windows.Forms.Panel()
        Me.BTNCancelaRenomeDeOrigem = New System.Windows.Forms.Button()
        Me.BTNConfirmarRenomeDeOrigem = New System.Windows.Forms.Button()
        Me.PanelEnvolve_ComBPMaster = New System.Windows.Forms.Panel()
        Me.PanelEnvolve_ComBPSlave = New System.Windows.Forms.Panel()
        Me.ComBPMaster = New TrevoWebMedia.Control_ComboBoxPerson()
        Me.ComBPSlave = New TrevoWebMedia.Control_ComboBoxPerson()
        Me.PanelElemento.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.TableLPContainer.SuspendLayout()
        Me.PanelTXT.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.PanelRightButtons.SuspendLayout()
        Me.TableLPButtons.SuspendLayout()
        Me.PanelEnvolve_ComBPMaster.SuspendLayout()
        Me.PanelEnvolve_ComBPSlave.SuspendLayout()
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
        Me.PanelElemento.Size = New System.Drawing.Size(596, 54)
        Me.PanelElemento.TabIndex = 1
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.TableLPContainer)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Padding = New System.Windows.Forms.Padding(13)
        Me.PanelContainer.Size = New System.Drawing.Size(542, 53)
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
        Me.TableLPContainer.Controls.Add(Me.PanelTXT, 4, 0)
        Me.TableLPContainer.Controls.Add(Me.PanelEnvolve_ComBPMaster, 0, 0)
        Me.TableLPContainer.Controls.Add(Me.PanelEnvolve_ComBPSlave, 2, 0)
        Me.TableLPContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLPContainer.Location = New System.Drawing.Point(13, 13)
        Me.TableLPContainer.Name = "TableLPContainer"
        Me.TableLPContainer.RowCount = 1
        Me.TableLPContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLPContainer.Size = New System.Drawing.Size(516, 27)
        Me.TableLPContainer.TabIndex = 5
        '
        'PanelTXT
        '
        Me.PanelTXT.BackColor = System.Drawing.Color.Transparent
        Me.PanelTXT.Controls.Add(Me.Panel10)
        Me.PanelTXT.Location = New System.Drawing.Point(339, 3)
        Me.PanelTXT.Name = "PanelTXT"
        Me.PanelTXT.Size = New System.Drawing.Size(169, 21)
        Me.PanelTXT.TabIndex = 3
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel10.Size = New System.Drawing.Size(169, 21)
        Me.Panel10.TabIndex = 2
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel11.Controls.Add(Me.TextBox2)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(1, 1)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(8, 2, 2, 2)
        Me.Panel11.Size = New System.Drawing.Size(167, 19)
        Me.Panel11.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBox2.Location = New System.Drawing.Point(8, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(157, 13)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "ooooooooooo"
        '
        'PanelRightButtons
        '
        Me.PanelRightButtons.Controls.Add(Me.TableLPButtons)
        Me.PanelRightButtons.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRightButtons.Location = New System.Drawing.Point(542, 0)
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
        'PanelMagemBotton
        '
        Me.PanelMagemBotton.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.PanelMagemBotton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMagemBotton.Location = New System.Drawing.Point(0, 53)
        Me.PanelMagemBotton.Name = "PanelMagemBotton"
        Me.PanelMagemBotton.Size = New System.Drawing.Size(596, 1)
        Me.PanelMagemBotton.TabIndex = 0
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
        'ComBPMaster
        '
        Me.ComBPMaster.AutoSize = True
        Me.ComBPMaster.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ComBPMaster.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ComBPMaster.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ComBPMaster.BorderColorError = System.Drawing.Color.Red
        Me.ComBPMaster.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ComBPMaster.ComboBoxPersonMaster = Nothing
        Me.ComBPMaster.ComboBoxPersonSlave = Nothing
        Me.ComBPMaster.ComboBoxPersonSlaveLists = CType(resources.GetObject("ComBPMaster.ComboBoxPersonSlaveLists"), System.Collections.Specialized.StringCollection)
        Me.ComBPMaster.DataReturn = Nothing
        Me.ComBPMaster.DefaultOptionsList = Nothing
        Me.ComBPMaster.DefaultOptionsListSlave = CType(resources.GetObject("ComBPMaster.DefaultOptionsListSlave"), System.Collections.Specialized.StringCollection)
        Me.ComBPMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComBPMaster.ListaDeOpçõesPadrão = Nothing
        Me.ComBPMaster.Location = New System.Drawing.Point(0, 0)
        Me.ComBPMaster.Name = "ComBPMaster"
        Me.ComBPMaster.Nivel = 0
        Me.ComBPMaster.OptionsList = CType(resources.GetObject("ComBPMaster.OptionsList"), System.Collections.Specialized.StringCollection)
        Me.ComBPMaster.ReturnStringList = CType(resources.GetObject("ComBPMaster.ReturnStringList"), System.Collections.Specialized.StringCollection)
        Me.ComBPMaster.ReturnType = TrevoWebMedia.Control_ComboBoxPerson.ReturnTypeEnum.None
        Me.ComBPMaster.Selected = Nothing
        Me.ComBPMaster.ShortcutKeyDisplay = True
        Me.ComBPMaster.Size = New System.Drawing.Size(154, 21)
        Me.ComBPMaster.TabIndex = 0
        Me.ComBPMaster.TextDisplay = "<Selecione>"
        Me.ComBPMaster.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        '
        'ComBPSlave
        '
        Me.ComBPSlave.AutoSize = True
        Me.ComBPSlave.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ComBPSlave.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ComBPSlave.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ComBPSlave.BorderColorError = System.Drawing.Color.Red
        Me.ComBPSlave.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ComBPSlave.ComboBoxPersonMaster = Nothing
        Me.ComBPSlave.ComboBoxPersonSlave = Nothing
        Me.ComBPSlave.ComboBoxPersonSlaveLists = CType(resources.GetObject("ComBPSlave.ComboBoxPersonSlaveLists"), System.Collections.Specialized.StringCollection)
        Me.ComBPSlave.DataReturn = Nothing
        Me.ComBPSlave.DefaultOptionsList = Nothing
        Me.ComBPSlave.DefaultOptionsListSlave = CType(resources.GetObject("ComBPSlave.DefaultOptionsListSlave"), System.Collections.Specialized.StringCollection)
        Me.ComBPSlave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComBPSlave.ListaDeOpçõesPadrão = Nothing
        Me.ComBPSlave.Location = New System.Drawing.Point(0, 0)
        Me.ComBPSlave.Name = "ComBPSlave"
        Me.ComBPSlave.Nivel = 0
        Me.ComBPSlave.OptionsList = CType(resources.GetObject("ComBPSlave.OptionsList"), System.Collections.Specialized.StringCollection)
        Me.ComBPSlave.ReturnStringList = CType(resources.GetObject("ComBPSlave.ReturnStringList"), System.Collections.Specialized.StringCollection)
        Me.ComBPSlave.ReturnType = TrevoWebMedia.Control_ComboBoxPerson.ReturnTypeEnum.None
        Me.ComBPSlave.Selected = Nothing
        Me.ComBPSlave.ShortcutKeyDisplay = True
        Me.ComBPSlave.Size = New System.Drawing.Size(154, 21)
        Me.ComBPSlave.TabIndex = 0
        Me.ComBPSlave.TextDisplay = "<Selecione>"
        Me.ComBPSlave.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        '
        'Control_RenameOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelElemento)
        Me.Name = "Control_RenameOption"
        Me.Size = New System.Drawing.Size(596, 54)
        Me.PanelElemento.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.TableLPContainer.ResumeLayout(False)
        Me.PanelTXT.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.PanelRightButtons.ResumeLayout(False)
        Me.TableLPButtons.ResumeLayout(False)
        Me.PanelEnvolve_ComBPMaster.ResumeLayout(False)
        Me.PanelEnvolve_ComBPMaster.PerformLayout()
        Me.PanelEnvolve_ComBPSlave.ResumeLayout(False)
        Me.PanelEnvolve_ComBPSlave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelElemento As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents TableLPContainer As TableLayoutPanel
    Friend WithEvents PanelTXT As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PanelRightButtons As Panel
    Friend WithEvents TableLPButtons As TableLayoutPanel
    Friend WithEvents BTNCancelaRenomeDeOrigem As Button
    Friend WithEvents BTNConfirmarRenomeDeOrigem As Button
    Friend WithEvents PanelMagemBotton As Panel
    Friend WithEvents PanelEnvolve_ComBPMaster As Panel
    Friend WithEvents ComBPMaster As Control_ComboBoxPerson
    Friend WithEvents PanelEnvolve_ComBPSlave As Panel
    Friend WithEvents ComBPSlave As Control_ComboBoxPerson
End Class
