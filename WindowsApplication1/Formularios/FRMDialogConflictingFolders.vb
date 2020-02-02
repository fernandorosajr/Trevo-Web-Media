Imports System.Windows.Forms

Public Class FRMDialogConflictingFolders

    ' Propriedades do controle
    Private _backColorCursorMouseLeave As Color
    Public Property BackColorCursorMouseLeave As Color
        Get
            Return _backColorCursorMouseLeave
        End Get
        Set(value As Color)
            _backColorCursorMouseLeave = value

        End Set
    End Property


    Private _borderColorGotFocus As Color

    Public Property BorderColorGotFocus As Color
        Get
            Return _borderColorGotFocus
        End Get
        Set(value As Color)
            _borderColorGotFocus = value

        End Set
    End Property

    Private _borderColorLostFocus As Color

    Public Property BordeColorLostFocus As Color
        Get
            Return _borderColorLostFocus
        End Get
        Set(value As Color)
            _borderColorLostFocus = value
        End Set
    End Property

    Private Sub FRMDialogConflictingFolders_Load(sender As Object, e As EventArgs) Handles Me.Load
        _borderColorGotFocus = SystemColors.HotTrack
        _borderColorLostFocus = BTNMesclar.BackColor
        _backColorCursorMouseLeave = Color.FromArgb(45, 45, 48)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Buttons_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNMesclar.MouseMove, BTNSubstituir.MouseMove, BTNIgnorar.MouseMove, OK_Button.MouseMove, Cancel_Button.MouseMove, BTNRendo.MouseMove
        Dim btn As Button
        btn = CType(sender, Button)

        Select Case btn.Name
            Case "BTNMesclar", "BTNSubstituir", "BTNIgnorar"
                ExibirEAtualizarHelp(btn, New Point(12, 316))

            Case "OK_Button", "Cancel_Button", "BTNRendo"
                ExibirEAtualizarHelp(btn, New Point(12, 170))

            Case Else
                Panel_LBLInfo.Visible = False

        End Select
    End Sub

    Private Sub LNKLRenomeOrigem_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNKLRenomeOrigem.LinkClicked
        PanelEnvolve_TXTNomeDaOrigem.Left = LBLValueOrigem.Left - 15
        PanelEnvolve_TXTNomeDaOrigem.Width = LBLValueOrigem.Width

        PanelEnvolve_TXTNomeDaOrigem.Visible = Not (PanelBorder_TXTNomeDaOrigem.Visible)
        LNKLRenomeOrigem.Visible = False
        LBLRenameOrigem.Visible = False
        TXTNomeDaOrigem.Focus()

    End Sub

    Private Sub BTNConfirmarRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNConfirmarRenomeDeOrigem.Click
        PanelEnvolve_TXTNomeDaOrigem.Visible = False
        LNKLRenomeOrigem.Text = "Novo nome: {novoNomeDaOrigem}"
        LBLRenameOrigem.Visible = True
        BTNRendo.Visible = True
        LNKLRenomeOrigem.Visible = True

        OK_Button.Focus()

    End Sub

    Private Sub BTNCancelaRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNCancelaRenomeDeOrigem.Click
        PanelEnvolve_TXTNomeDaOrigem.Visible = False
        LNKLRenomeOrigem.Text = "Clique aqui para renomear pasta de origem"
        LBLRenameOrigem.Visible = False
        LNKLRenomeOrigem.Visible = True
        BTNMesclar.Focus()
    End Sub

    Private Sub BTNConfirmarRenomeDeDestino_Click(sender As Object, e As EventArgs) Handles BTNConfirmarRenomeDeDestino.Click
        PanelEnvolve_TXTNomeDoDestino.Visible = False
        LNKLRenomeDestino.Text = "Novo nome: {novoNomeDaDestino}"
        LBLRenameDestino.Visible = True
        BTNRendo.Visible = True
        LNKLRenomeDestino.Visible = True
        OK_Button.Focus()

    End Sub

    Private Sub BTNCancelaRenomeDeDestino_Click(sender As Object, e As EventArgs) Handles BTNCancelaRenomeDeDestino.Click
        PanelEnvolve_TXTNomeDoDestino.Visible = False
        LNKLRenomeDestino.Text = "Clique aqui para renomear pasta de destino"
        LBLRenameDestino.Visible = False
        LNKLRenomeDestino.Visible = True
        BTNMesclar.Focus()

    End Sub

    Private Sub LNKLRenomeDestino_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNKLRenomeDestino.LinkClicked
        PanelEnvolve_TXTNomeDoDestino.Left = LBLValueDestino.Left - 15
        PanelEnvolve_TXTNomeDoDestino.Width = LBLValueDestino.Width
        LNKLRenomeDestino.Visible = False
        PanelEnvolve_TXTNomeDoDestino.Visible = Not (PanelEnvolve_TXTNomeDoDestino.Visible)
        LBLRenameDestino.Visible = False

        TXTNomeDoDestino.Focus()

    End Sub

    Private Sub BTNRendo_Click(sender As Object, e As EventArgs) Handles BTNRendo.Click
        LBLRenameOrigem.Visible = False
        LBLRenameDestino.Visible = False
        PanelEnvolve_TXTNomeDaOrigem.Visible = False
        PanelEnvolve_TXTNomeDoDestino.Visible = False
        LNKLRenomeDestino.Text = "Clique aqui para renomear pasta de destino"
        LNKLRenomeOrigem.Text = "Clique aqui para renomear pasta de origem"
        BTNRendo.Visible = False
        LNKLRenomeOrigem.Visible = True
        LNKLRenomeDestino.Visible = True
    End Sub

    Private Sub Buttons_GotFocus(sender As Object, e As EventArgs) _
        Handles OK_Button.GotFocus, Cancel_Button.GotFocus,
        BTNMesclar.GotFocus, BTNSubstituir.GotFocus,
        BTNSubstituir.GotFocus, BTNRendo.GotFocus,
        BTNCancelaRenomeDeDestino.GotFocus, BTNCancelaRenomeDeOrigem.GotFocus,
        BTNConfirmarRenomeDeDestino.GotFocus, BTNCancelaRenomeDeOrigem.GotFocus, BTNIgnorar.GotFocus

        Dim btn As Button
        btn = CType(sender, Button)

        btn.FlatAppearance.BorderColor = _borderColorGotFocus

        Select Case btn.Name
            Case "BTNMesclar", "BTNSubstituir", "BTNIgnorar"
                ExibirEAtualizarHelp(btn, New Point(12, 316))

            Case "OK_Button", "Cancel_Button", "BTNRendo"
                ExibirEAtualizarHelp(btn, New Point(12, 170))

            Case Else
                Panel_LBLInfo.Visible = False

        End Select
    End Sub

    Private Sub OK_Button_MouseLeave(sender As Object, e As EventArgs) Handles _
        OK_Button.MouseLeave, Cancel_Button.MouseLeave,
        BTNMesclar.MouseLeave, BTNSubstituir.MouseLeave,
        BTNSubstituir.MouseLeave, BTNRendo.MouseLeave, BTNIgnorar.MouseLeave

        Panel_LBLInfo.Visible = False
    End Sub


    Private Sub Buttons_LostFocus(sender As Object, e As EventArgs) _
        Handles OK_Button.LostFocus, Cancel_Button.LostFocus,
        BTNMesclar.LostFocus, BTNSubstituir.LostFocus,
        BTNSubstituir.LostFocus, BTNRendo.LostFocus,
        BTNCancelaRenomeDeDestino.LostFocus, BTNCancelaRenomeDeOrigem.LostFocus,
        BTNConfirmarRenomeDeDestino.LostFocus, BTNCancelaRenomeDeOrigem.LostFocus, BTNIgnorar.LostFocus

        Dim btn As Button
        btn = CType(sender, Button)

        btn.FlatAppearance.BorderColor = _borderColorLostFocus
        Panel_LBLInfo.Visible = False
    End Sub

    Sub ExibirEAtualizarHelp(btn As Object, location As Point)
        Panel_LBLInfo.Visible = True
        LBLInfo.Text = btn.Tag
        Panel_LBLInfo.Location = location
    End Sub

    Private Sub TextBoxes_GotFocus(sender As Object, e As EventArgs) Handles TXTNomeDaOrigem.GotFocus, TXTNomeDoDestino.GotFocus
        Dim txt As TextBox
        txt = CType(sender, TextBox)
        Dim backColor As Color = _backColorCursorMouseLeave
        Dim borderColor As Color = _borderColorGotFocus

        txt.Parent.Parent.BackColor = borderColor
        txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
        txt.Cursor = Cursors.IBeam
        txt.BackColor = backColor
        txt.Parent.BackColor = backColor
        'Color.FromArgb(120, 45, 45, 48) 'Color.FromArgb(120, 255, 255, 255) 
    End Sub

    Private Sub TextBoxes_LostFocus(sender As Object, e As EventArgs) Handles TXTNomeDoDestino.LostFocus, TXTNomeDaOrigem.LostFocus
        Dim txt As TextBox
        txt = CType(sender, TextBox)
        Dim cor As Color = Color.FromArgb(63, 63, 66)

        txt.Parent.Parent.BackColor = _borderColorLostFocus
        txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
        txt.Cursor = Cursors.Arrow
        txt.BackColor = cor
        txt.Parent.BackColor = cor
    End Sub

    Private Sub TextBoxes_MouseMove(sender As Object, e As MouseEventArgs) Handles TXTNomeDoDestino.MouseMove, TXTNomeDaOrigem.MouseMove
        Dim txt As TextBox
        txt = CType(sender, TextBox)
        Dim cor As Color = _borderColorGotFocus

        txt.Parent.Parent.BackColor = cor
        If txt.Focused = True Then
            txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
        Else
            txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
        End If
    End Sub

    Private Sub TextBoxes_MouseLeave(sender As Object, e As EventArgs) Handles TXTNomeDoDestino.MouseLeave, TXTNomeDaOrigem.MouseLeave
        Dim txt As TextBox
        txt = CType(sender, TextBox)
        Dim corLostFocus As Color = _borderColorLostFocus
        Dim corGotFocus As Color = _borderColorGotFocus

        If txt.Focused = True Then
            txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
            txt.Parent.Parent.BackColor = corGotFocus
        Else
            txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
            txt.Parent.Parent.BackColor = corLostFocus
        End If
    End Sub

End Class
