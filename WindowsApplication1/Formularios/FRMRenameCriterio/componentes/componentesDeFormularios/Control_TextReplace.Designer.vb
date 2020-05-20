<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Control_TextReplace
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
        Me.PanelSubstituir = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelEnvolve_TXTPSubstituir = New System.Windows.Forms.Panel()
        Me.TXTPReplacement = New TrevoWebMedia.Control_TextBoxPerson()
        Me.LBL_TXTPSubstituir = New System.Windows.Forms.Label()
        Me.PanelEnvolve_TXTPPesquisar = New System.Windows.Forms.Panel()
        Me.TXTPFind = New TrevoWebMedia.Control_TextBoxPerson()
        Me.LBL_TXTPPesquisar = New System.Windows.Forms.Label()
        Me.CHKIgnoreUpperLower = New System.Windows.Forms.CheckBox()
        Me.CHKReplaceAll = New System.Windows.Forms.CheckBox()
        Me.PanelEnvolve_BTNPesquisar = New System.Windows.Forms.Panel()
        Me.BTNPesquisar = New System.Windows.Forms.Button()
        Me.PanelSubstituir.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelEnvolve_TXTPSubstituir.SuspendLayout()
        Me.PanelEnvolve_TXTPPesquisar.SuspendLayout()
        Me.PanelEnvolve_BTNPesquisar.SuspendLayout()
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelEnvolve_TXTPSubstituir, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelEnvolve_TXTPPesquisar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CHKIgnoreUpperLower, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CHKReplaceAll, 1, 1)
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
        Me.PanelEnvolve_TXTPSubstituir.Controls.Add(Me.TXTPReplacement)
        Me.PanelEnvolve_TXTPSubstituir.Controls.Add(Me.LBL_TXTPSubstituir)
        Me.PanelEnvolve_TXTPSubstituir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_TXTPSubstituir.Location = New System.Drawing.Point(200, 3)
        Me.PanelEnvolve_TXTPSubstituir.Name = "PanelEnvolve_TXTPSubstituir"
        Me.PanelEnvolve_TXTPSubstituir.Size = New System.Drawing.Size(192, 21)
        Me.PanelEnvolve_TXTPSubstituir.TabIndex = 1
        '
        'TXTPReplacement
        '
        Me.TXTPReplacement.ActiveValidate = False
        Me.TXTPReplacement.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTPReplacement.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPReplacement.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.TXTPReplacement.BorderColorError = System.Drawing.Color.Red
        Me.TXTPReplacement.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTPReplacement.ByChar = False
        Me.TXTPReplacement.ByText = False
        Me.TXTPReplacement.ByValue = False
        Me.TXTPReplacement.ChangeCursorFocus = True
        Me.TXTPReplacement.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTPReplacement.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.TXTPReplacement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTPReplacement.ErrorDisplay = False
        Me.TXTPReplacement.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPReplacement.Fonte = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPReplacement.ForeColor = System.Drawing.Color.DarkGray
        Me.TXTPReplacement.ForeColorActive = System.Drawing.Color.DarkGray
        Me.TXTPReplacement.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.TXTPReplacement.HideSelection = True
        Me.TXTPReplacement.LeftIndentation = 6
        Me.TXTPReplacement.Location = New System.Drawing.Point(83, 0)
        Me.TXTPReplacement.MaxLength = 32767
        Me.TXTPReplacement.MultiLine = False
        Me.TXTPReplacement.Name = "TXTPReplacement"
        Me.TXTPReplacement.NoneOfThisChar = ""
        Me.TXTPReplacement.NoneOfThisText = Nothing
        Me.TXTPReplacement.NoneOfThisValue = Nothing
        Me.TXTPReplacement.OnlyAlfaNumber = False
        Me.TXTPReplacement.OnlyCaracterText = False
        Me.TXTPReplacement.OnlyNumber = False
        Me.TXTPReplacement.PaddingText = New System.Windows.Forms.Padding(3)
        Me.TXTPReplacement.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPReplacement.PersonBorder = New System.Windows.Forms.Padding(1)
        Me.TXTPReplacement.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.TXTPReplacement.Placeholder = ""
        Me.TXTPReplacement.Read_Only = False
        Me.TXTPReplacement.RequiredChar = ""
        Me.TXTPReplacement.RequiredText = Nothing
        Me.TXTPReplacement.RequiredValue = Nothing
        Me.TXTPReplacement.RightIndentation = 0
        Me.TXTPReplacement.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.TXTPReplacement.Size = New System.Drawing.Size(109, 21)
        Me.TXTPReplacement.SpaceError = False
        Me.TXTPReplacement.TabIndex = 1
        Me.TXTPReplacement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTPReplacement.ThisSize = New System.Drawing.Size(109, 21)
        Me.TXTPReplacement.TXT = Nothing
        Me.TXTPReplacement.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPReplacement.UseSystemPasswordChar = False
        Me.TXTPReplacement.WordWrap = True
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
        Me.PanelEnvolve_TXTPPesquisar.Controls.Add(Me.TXTPFind)
        Me.PanelEnvolve_TXTPPesquisar.Controls.Add(Me.LBL_TXTPPesquisar)
        Me.PanelEnvolve_TXTPPesquisar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEnvolve_TXTPPesquisar.Location = New System.Drawing.Point(3, 3)
        Me.PanelEnvolve_TXTPPesquisar.Name = "PanelEnvolve_TXTPPesquisar"
        Me.PanelEnvolve_TXTPPesquisar.Size = New System.Drawing.Size(191, 21)
        Me.PanelEnvolve_TXTPPesquisar.TabIndex = 0
        '
        'TXTPFind
        '
        Me.TXTPFind.ActiveValidate = False
        Me.TXTPFind.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTPFind.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPFind.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.TXTPFind.BorderColorError = System.Drawing.Color.Red
        Me.TXTPFind.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTPFind.ByChar = False
        Me.TXTPFind.ByText = False
        Me.TXTPFind.ByValue = False
        Me.TXTPFind.ChangeCursorFocus = True
        Me.TXTPFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTPFind.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.TXTPFind.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTPFind.ErrorDisplay = False
        Me.TXTPFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPFind.Fonte = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPFind.ForeColor = System.Drawing.Color.DarkGray
        Me.TXTPFind.ForeColorActive = System.Drawing.Color.DarkGray
        Me.TXTPFind.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.TXTPFind.HideSelection = True
        Me.TXTPFind.LeftIndentation = 6
        Me.TXTPFind.Location = New System.Drawing.Point(68, 0)
        Me.TXTPFind.MaxLength = 32767
        Me.TXTPFind.MultiLine = False
        Me.TXTPFind.Name = "TXTPFind"
        Me.TXTPFind.NoneOfThisChar = ""
        Me.TXTPFind.NoneOfThisText = Nothing
        Me.TXTPFind.NoneOfThisValue = Nothing
        Me.TXTPFind.OnlyAlfaNumber = False
        Me.TXTPFind.OnlyCaracterText = False
        Me.TXTPFind.OnlyNumber = False
        Me.TXTPFind.PaddingText = New System.Windows.Forms.Padding(3)
        Me.TXTPFind.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTPFind.PersonBorder = New System.Windows.Forms.Padding(1)
        Me.TXTPFind.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.TXTPFind.Placeholder = ""
        Me.TXTPFind.Read_Only = False
        Me.TXTPFind.RequiredChar = ""
        Me.TXTPFind.RequiredText = Nothing
        Me.TXTPFind.RequiredValue = Nothing
        Me.TXTPFind.RightIndentation = 0
        Me.TXTPFind.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.TXTPFind.Size = New System.Drawing.Size(123, 21)
        Me.TXTPFind.SpaceError = False
        Me.TXTPFind.TabIndex = 1
        Me.TXTPFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTPFind.ThisSize = New System.Drawing.Size(123, 21)
        Me.TXTPFind.TXT = Nothing
        Me.TXTPFind.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTPFind.UseSystemPasswordChar = False
        Me.TXTPFind.WordWrap = True
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
        'CHKIgnoreUpperLower
        '
        Me.CHKIgnoreUpperLower.AutoSize = True
        Me.CHKIgnoreUpperLower.Location = New System.Drawing.Point(3, 30)
        Me.CHKIgnoreUpperLower.Name = "CHKIgnoreUpperLower"
        Me.CHKIgnoreUpperLower.Size = New System.Drawing.Size(168, 17)
        Me.CHKIgnoreUpperLower.TabIndex = 2
        Me.CHKIgnoreUpperLower.Text = "Ignorar maiúscula e minúscula"
        Me.CHKIgnoreUpperLower.UseVisualStyleBackColor = True
        '
        'CHKReplaceAll
        '
        Me.CHKReplaceAll.AutoSize = True
        Me.CHKReplaceAll.Checked = True
        Me.CHKReplaceAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKReplaceAll.Location = New System.Drawing.Point(200, 30)
        Me.CHKReplaceAll.Name = "CHKReplaceAll"
        Me.CHKReplaceAll.Size = New System.Drawing.Size(93, 17)
        Me.CHKReplaceAll.TabIndex = 3
        Me.CHKReplaceAll.Text = "Substituir tudo"
        Me.CHKReplaceAll.UseVisualStyleBackColor = True
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
        'Control_TextReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelSubstituir)
        Me.Name = "Control_TextReplace"
        Me.Size = New System.Drawing.Size(472, 54)
        Me.PanelSubstituir.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PanelEnvolve_TXTPSubstituir.ResumeLayout(False)
        Me.PanelEnvolve_TXTPSubstituir.PerformLayout()
        Me.PanelEnvolve_TXTPPesquisar.ResumeLayout(False)
        Me.PanelEnvolve_TXTPPesquisar.PerformLayout()
        Me.PanelEnvolve_BTNPesquisar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSubstituir As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PanelEnvolve_TXTPSubstituir As Panel
    Friend WithEvents TXTPReplacement As Control_TextBoxPerson
    Friend WithEvents LBL_TXTPSubstituir As Label
    Friend WithEvents PanelEnvolve_TXTPPesquisar As Panel
    Friend WithEvents TXTPFind As Control_TextBoxPerson
    Friend WithEvents LBL_TXTPPesquisar As Label
    Friend WithEvents CHKIgnoreUpperLower As CheckBox
    Friend WithEvents CHKReplaceAll As CheckBox
    Friend WithEvents PanelEnvolve_BTNPesquisar As Panel
    Friend WithEvents BTNPesquisar As Button
End Class
