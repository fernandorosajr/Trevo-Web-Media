<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_TextConfirm
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
        Me.PanelEnvolve_TXTNomeDoDestino = New System.Windows.Forms.Panel()
        Me.TXTValue = New TrevoWebMedia.Control_TextBoxPerson()
        Me.BTNCancelarAlterarValor = New System.Windows.Forms.Button()
        Me.BTNConfirmarAlterarValor = New System.Windows.Forms.Button()
        Me.PanelEnvolve_TXTNomeDoDestino.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEnvolve_TXTNomeDoDestino
        '
        Me.PanelEnvolve_TXTNomeDoDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelEnvolve_TXTNomeDoDestino.Controls.Add(Me.TXTValue)
        Me.PanelEnvolve_TXTNomeDoDestino.Controls.Add(Me.BTNCancelarAlterarValor)
        Me.PanelEnvolve_TXTNomeDoDestino.Controls.Add(Me.BTNConfirmarAlterarValor)
        Me.PanelEnvolve_TXTNomeDoDestino.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEnvolve_TXTNomeDoDestino.Location = New System.Drawing.Point(0, 0)
        Me.PanelEnvolve_TXTNomeDoDestino.Name = "PanelEnvolve_TXTNomeDoDestino"
        Me.PanelEnvolve_TXTNomeDoDestino.Size = New System.Drawing.Size(332, 41)
        Me.PanelEnvolve_TXTNomeDoDestino.TabIndex = 14
        '
        'TXTValue
        '
        Me.TXTValue.ActiveValidate = False
        Me.TXTValue.BackColorCursorMouseLeave = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TXTValue.BgColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTValue.BordeColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.TXTValue.BorderColorError = System.Drawing.Color.Red
        Me.TXTValue.BorderColorGotFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTValue.ByChar = False
        Me.TXTValue.ByText = False
        Me.TXTValue.ByValue = False
        Me.TXTValue.ChangeCursorFocus = False
        Me.TXTValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTValue.CursorTxt = System.Windows.Forms.Cursors.IBeam
        Me.TXTValue.Dock = System.Windows.Forms.DockStyle.Top
        Me.TXTValue.ErrorDisplay = False
        Me.TXTValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTValue.Fonte = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTValue.ForeColor = System.Drawing.Color.DarkGray
        Me.TXTValue.ForeColorActive = System.Drawing.Color.DarkGray
        Me.TXTValue.ForeColorPlaceholder = System.Drawing.Color.Gray
        Me.TXTValue.HideSelection = True
        Me.TXTValue.LeftIndentation = 6
        Me.TXTValue.Location = New System.Drawing.Point(0, 0)
        Me.TXTValue.MultiLine = False
        Me.TXTValue.Name = "TXTValue"
        Me.TXTValue.NoneOfThisChar = ""
        Me.TXTValue.NoneOfThisText = Nothing
        Me.TXTValue.NoneOfThisValue = Nothing
        Me.TXTValue.PaddingText = New System.Windows.Forms.Padding(2)
        Me.TXTValue.PasswordChar = "" & Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTValue.PersonBorder = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.TXTValue.PersonCSSMargin = New System.Windows.Forms.Padding(0)
        Me.TXTValue.Placeholder = "Entre com um dado...."
        Me.TXTValue.Read_Only = False
        Me.TXTValue.RequiredChar = ""
        Me.TXTValue.RequiredText = Nothing
        Me.TXTValue.RequiredValue = Nothing
        Me.TXTValue.RightIndentation = 0
        Me.TXTValue.ScrollBar = System.Windows.Forms.ScrollBars.None
        Me.TXTValue.Size = New System.Drawing.Size(332, 20)
        Me.TXTValue.SpaceError = False
        Me.TXTValue.TabIndex = 0
        Me.TXTValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTValue.ThisSize = New System.Drawing.Size(332, 20)
        Me.TXTValue.TXT = Nothing
        Me.TXTValue.TXTBoxBackColorLostFocus = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TXTValue.UseSystemPasswordChar = False
        Me.TXTValue.WordWrap = True
        '
        'BTNCancelarAlterarValor
        '
        Me.BTNCancelarAlterarValor.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.remove
        Me.BTNCancelarAlterarValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNCancelarAlterarValor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCancelarAlterarValor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNCancelarAlterarValor.FlatAppearance.BorderSize = 0
        Me.BTNCancelarAlterarValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCancelarAlterarValor.Location = New System.Drawing.Point(28, 22)
        Me.BTNCancelarAlterarValor.Name = "BTNCancelarAlterarValor"
        Me.BTNCancelarAlterarValor.Size = New System.Drawing.Size(15, 15)
        Me.BTNCancelarAlterarValor.TabIndex = 2
        Me.BTNCancelarAlterarValor.Tag = ""
        '
        'BTNConfirmarAlterarValor
        '
        Me.BTNConfirmarAlterarValor.BackgroundImage = Global.TrevoWebMedia.My.Resources.Resources.check
        Me.BTNConfirmarAlterarValor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNConfirmarAlterarValor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNConfirmarAlterarValor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.BTNConfirmarAlterarValor.FlatAppearance.BorderSize = 0
        Me.BTNConfirmarAlterarValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNConfirmarAlterarValor.Location = New System.Drawing.Point(9, 22)
        Me.BTNConfirmarAlterarValor.Name = "BTNConfirmarAlterarValor"
        Me.BTNConfirmarAlterarValor.Size = New System.Drawing.Size(15, 15)
        Me.BTNConfirmarAlterarValor.TabIndex = 1
        Me.BTNConfirmarAlterarValor.Tag = ""
        '
        'Control_TextConfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEnvolve_TXTNomeDoDestino)
        Me.Name = "Control_TextConfirm"
        Me.Size = New System.Drawing.Size(332, 222)
        Me.PanelEnvolve_TXTNomeDoDestino.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEnvolve_TXTNomeDoDestino As Panel
    Friend WithEvents BTNCancelarAlterarValor As Button
    Friend WithEvents BTNConfirmarAlterarValor As Button
    Friend WithEvents TXTValue As Control_TextBoxPerson
End Class
