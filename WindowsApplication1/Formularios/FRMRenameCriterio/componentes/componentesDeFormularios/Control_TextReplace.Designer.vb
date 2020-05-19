<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_TextReplace
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
        Me.PanelSubstituir = New System.Windows.Forms.Panel()
        Me.PanelEnvolve_BTNPesquisar = New System.Windows.Forms.Panel()
        Me.BTNPesquisar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelEnvolve_TXTPSubstituir = New System.Windows.Forms.Panel()
        Me.LBL_TXTPSubstituir = New System.Windows.Forms.Label()
        Me.PanelEnvolve_TXTPPesquisar = New System.Windows.Forms.Panel()
        Me.LBL_TXTPPesquisar = New System.Windows.Forms.Label()
        Me.CHKIgnorarMaiusculaEMinuscula = New System.Windows.Forms.CheckBox()
        Me.CHKSubstituirTudo = New System.Windows.Forms.CheckBox()
        Me.TXTPSubstituir = New TrevoWebMedia.Control_TextBoxPerson()
        Me.TXTPPesquisar = New TrevoWebMedia.Control_TextBoxPerson()
        Me.PanelSubstituir.SuspendLayout()
        Me.PanelEnvolve_BTNPesquisar.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelEnvolve_TXTPSubstituir.SuspendLayout()
        Me.PanelEnvolve_TXTPPesquisar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSubstituir
        '
        Me.PanelSubstituir.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelSubstituir.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelSubstituir.Controls.Add(Me.PanelEnvolve_BTNPesquisar)
        Me.PanelSubstituir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSubstituir.ForeColor = System.Drawing.Color.DarkGray
        Me.PanelSubstituir.Location = New System.Drawing.Point(0, 0)
        Me.PanelSubstituir.Name = "PanelSubstituir"
        Me.PanelSubstituir.Size = New System.Drawing.Size(472, 54)
        Me.PanelSubstituir.TabIndex = 2
        '
        'PanelEnvolve_BTNPesquisar
        '
        Me.PanelEnvolve_BTNPesquisar.Controls.Add(Me.BTNPesquisar)
        Me.PanelEnvolve_BTNPesquisar.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelEnvolve_BTNPesquisar.Location = New System.Drawing.Point(395, 0)
        Me.PanelEnvolve_BTNPesquisar.Name = "PanelEnvolve_BTNPesquisar"
        Me.PanelEnvolve_BTNPesquisar.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelEnvolve_BTNPesquisar.Size = New System.Drawing.Size(77, 54)
        Me.PanelEnvolve_BTNPesquisar.TabIndex = 2
        Me.PanelEnvolve_BTNPesquisar.Visible = False
        '
        'BTNPesquisar
        '
        Me.BTNPesquisar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPesquisar.Location = New System.Drawing.Point(3, 3)
        Me.BTNPesquisar.Name = "BTNPesquisar"
        Me.BTNPesquisar.Size = New System.Drawing.Size(71, 31)
        Me.BTNPesquisar.TabIndex = 16
        Me.BTNPesquisar.Text = "Pesquisar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelEnvolve_TXTPSubstituir, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelEnvolve_TXTPPesquisar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CHKIgnorarMaiusculaEMinuscula, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CHKSubstituirTudo, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(395, 54)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PanelEnvolve_TXTPSubstituir
        '
        Me.PanelEnvolve_TXTPSubstituir.Controls.Add(Me.TXTPSubstituir)
        Me.PanelEnvolve_TXTPSubstituir.Controls.Add(Me.LBL_TXTPSubstituir)
        Me.PanelEnvolve_TXTPSubstituir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_TXTPSubstituir.Location = New System.Drawing.Point(200, 3)
        Me.PanelEnvolve_TXTPSubstituir.Name = "PanelEnvolve_TXTPSubstituir"
        Me.PanelEnvolve_TXTPSubstituir.Size = New System.Drawing.Size(192, 21)
        Me.PanelEnvolve_TXTPSubstituir.TabIndex = 1
        '
        'LBL_TXTPSubstituir
        '
        Me.LBL_TXTPSubstituir.AutoSize = True
        Me.LBL_TXTPSubstituir.Dock = System.Windows.Forms.DockStyle.Left
        Me.LBL_TXTPSubstituir.Location = New System.Drawing.Point(0, 0)
        Me.LBL_TXTPSubstituir.Name = "LBL_TXTPSubstituir"
        Me.LBL_TXTPSubstituir.Size = New System.Drawing.Size(83, 13)
        Me.LBL_TXTPSubstituir.TabIndex = 0
        Me.LBL_TXTPSubstituir.Text = "Substituir por:    "
        '
        'PanelEnvolve_TXTPPesquisar
        '
        Me.PanelEnvolve_TXTPPesquisar.Controls.Add(Me.TXTPPesquisar)
        Me.PanelEnvolve_TXTPPesquisar.Controls.Add(Me.LBL_TXTPPesquisar)
        Me.PanelEnvolve_TXTPPesquisar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_TXTPPesquisar.Location = New System.Drawing.Point(3, 3)
        Me.PanelEnvolve_TXTPPesquisar.Name = "PanelEnvolve_TXTPPesquisar"
        Me.PanelEnvolve_TXTPPesquisar.Size = New System.Drawing.Size(191, 21)
        Me.PanelEnvolve_TXTPPesquisar.TabIndex = 0
        '
        'LBL_TXTPPesquisar
        '
        Me.LBL_TXTPPesquisar.AutoSize = True
        Me.LBL_TXTPPesquisar.Dock = System.Windows.Forms.DockStyle.Left
        Me.LBL_TXTPPesquisar.Location = New System.Drawing.Point(0, 0)
        Me.LBL_TXTPPesquisar.Name = "LBL_TXTPPesquisar"
        Me.LBL_TXTPPesquisar.Size = New System.Drawing.Size(68, 13)
        Me.LBL_TXTPPesquisar.TabIndex = 0
        Me.LBL_TXTPPesquisar.Text = "Pesquisar:    "
        '
        'CHKIgnorarMaiusculaEMinuscula
        '
        Me.CHKIgnorarMaiusculaEMinuscula.AutoSize = True
        Me.CHKIgnorarMaiusculaEMinuscula.Location = New System.Drawing.Point(3, 30)
        Me.CHKIgnorarMaiusculaEMinuscula.Name = "CHKIgnorarMaiusculaEMinuscula"
        Me.CHKIgnorarMaiusculaEMinuscula.Size = New System.Drawing.Size(168, 17)
        Me.CHKIgnorarMaiusculaEMinuscula.TabIndex = 2
        Me.CHKIgnorarMaiusculaEMinuscula.Text = "Ignorar maiúscula e minúscula"
        Me.CHKIgnorarMaiusculaEMinuscula.UseVisualStyleBackColor = True
        '
        'CHKSubstituirTudo
        '
        Me.CHKSubstituirTudo.AutoSize = True
        Me.CHKSubstituirTudo.Location = New System.Drawing.Point(200, 30)
        Me.CHKSubstituirTudo.Name = "CHKSubstituirTudo"
        Me.CHKSubstituirTudo.Size = New System.Drawing.Size(93, 17)
        Me.CHKSubstituirTudo.TabIndex = 3
        Me.CHKSubstituirTudo.Text = "Substituir tudo"
        Me.CHKSubstituirTudo.UseVisualStyleBackColor = True
        '
        'TXTPSubstituir
        '
        Me.TXTPSubstituir.ActiveValidate = False
        Me.TXTPSubstituir.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTPSubstituir.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPSubstituir.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.TXTPSubstituir.BorderColorError = System.Drawing.Color.Red
        Me.TXTPSubstituir.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTPSubstituir.ByChar = False
        Me.TXTPSubstituir.ByText = False
        Me.TXTPSubstituir.ByValue = False
        Me.TXTPSubstituir.ChangeCursorFocus = True
        Me.TXTPSubstituir.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTPSubstituir.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.TXTPSubstituir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTPSubstituir.ErrorDisplay = False
        Me.TXTPSubstituir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPSubstituir.Fonte = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPSubstituir.ForeColor = System.Drawing.Color.DarkGray
        Me.TXTPSubstituir.ForeColorActive = System.Drawing.Color.DarkGray
        Me.TXTPSubstituir.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.TXTPSubstituir.HideSelection = True
        Me.TXTPSubstituir.LeftIndentation = 6
        Me.TXTPSubstituir.Location = New System.Drawing.Point(83, 0)
        Me.TXTPSubstituir.MaxLength = 32767
        Me.TXTPSubstituir.MultiLine = False
        Me.TXTPSubstituir.Name = "TXTPSubstituir"
        Me.TXTPSubstituir.NoneOfThisChar = ""
        Me.TXTPSubstituir.NoneOfThisText = Nothing
        Me.TXTPSubstituir.NoneOfThisValue = Nothing
        Me.TXTPSubstituir.OnlyAlfaNumber = False
        Me.TXTPSubstituir.OnlyCaracterText = False
        Me.TXTPSubstituir.OnlyNumber = False
        Me.TXTPSubstituir.PaddingText = New System.Windows.Forms.Padding(2)
        Me.TXTPSubstituir.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPSubstituir.PersonBorder = New System.Windows.Forms.Padding(1)
        Me.TXTPSubstituir.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.TXTPSubstituir.Placeholder = Nothing
        Me.TXTPSubstituir.Read_Only = False
        Me.TXTPSubstituir.RequiredChar = ""
        Me.TXTPSubstituir.RequiredText = Nothing
        Me.TXTPSubstituir.RequiredValue = Nothing
        Me.TXTPSubstituir.RightIndentation = 0
        Me.TXTPSubstituir.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.TXTPSubstituir.Size = New System.Drawing.Size(109, 21)
        Me.TXTPSubstituir.SpaceError = False
        Me.TXTPSubstituir.TabIndex = 1
        Me.TXTPSubstituir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTPSubstituir.ThisSize = New System.Drawing.Size(109, 21)
        Me.TXTPSubstituir.TXT = Nothing
        Me.TXTPSubstituir.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPSubstituir.UseSystemPasswordChar = False
        Me.TXTPSubstituir.WordWrap = True
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
        Me.TXTPPesquisar.MaxLength = 32767
        Me.TXTPPesquisar.MultiLine = False
        Me.TXTPPesquisar.Name = "TXTPPesquisar"
        Me.TXTPPesquisar.NoneOfThisChar = ""
        Me.TXTPPesquisar.NoneOfThisText = Nothing
        Me.TXTPPesquisar.NoneOfThisValue = Nothing
        Me.TXTPPesquisar.OnlyAlfaNumber = False
        Me.TXTPPesquisar.OnlyCaracterText = False
        Me.TXTPPesquisar.OnlyNumber = False
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
        Me.TXTPPesquisar.Size = New System.Drawing.Size(123, 21)
        Me.TXTPPesquisar.SpaceError = False
        Me.TXTPPesquisar.TabIndex = 1
        Me.TXTPPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTPPesquisar.ThisSize = New System.Drawing.Size(123, 21)
        Me.TXTPPesquisar.TXT = Nothing
        Me.TXTPPesquisar.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPPesquisar.UseSystemPasswordChar = False
        Me.TXTPPesquisar.WordWrap = True
        '
        'Control_TextReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelSubstituir)
        Me.Name = "Control_TextReplace"
        Me.Size = New System.Drawing.Size(472, 54)
        Me.PanelSubstituir.ResumeLayout(False)
        Me.PanelEnvolve_BTNPesquisar.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PanelEnvolve_TXTPSubstituir.ResumeLayout(False)
        Me.PanelEnvolve_TXTPSubstituir.PerformLayout()
        Me.PanelEnvolve_TXTPPesquisar.ResumeLayout(False)
        Me.PanelEnvolve_TXTPPesquisar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSubstituir As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelEnvolve_TXTPSubstituir As Panel
    Friend WithEvents TXTPSubstituir As Control_TextBoxPerson
    Friend WithEvents LBL_TXTPSubstituir As Label
    Friend WithEvents PanelEnvolve_TXTPPesquisar As Panel
    Friend WithEvents TXTPPesquisar As Control_TextBoxPerson
    Friend WithEvents LBL_TXTPPesquisar As Label
    Friend WithEvents CHKIgnorarMaiusculaEMinuscula As CheckBox
    Friend WithEvents CHKSubstituirTudo As CheckBox
    Friend WithEvents PanelEnvolve_BTNPesquisar As Panel
    Friend WithEvents BTNPesquisar As Button
End Class
