Imports System.Windows.Forms

Public Class FRMDialogConflictingFolders
    ' Propriedades do controle
    Private _colorGotFocus As Color

    Public Property ColorGotFocus As Color
        Get
            Return _colorGotFocus
        End Get
        Set(value As Color)
            _colorGotFocus = value

        End Set
    End Property

    Private _colorLostFocus As Color

    Public Property ColorLostFocus As Color
        Get
            Return _colorLostFocus
        End Get
        Set(value As Color)
            _colorLostFocus = value
        End Set
    End Property

    Private Sub FRMDialogConflictingFolders_Load(sender As Object, e As EventArgs) Handles Me.Load
        _colorGotFocus = SystemColors.HotTrack
        _colorLostFocus = BTNMesclar.BackColor

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Buttons_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNMesclar.MouseMove, BTNSubstituir.MouseMove, BTNIgnorar.MouseMove
        Dim btn As Button
        btn = CType(sender, Button)
        ExibirEAtualizarHelp(btn)
    End Sub


    Private Sub FRMDialogConflictingFolders_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Panel_LBLInfo.Visible = False

    End Sub

    Private Sub Panel_LBLOutrasOpcoes_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_LBLOutrasOpcoes.MouseMove
        Panel_LBLInfo.Visible = False
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
        BTNConfirmarRenomeDeDestino.GotFocus, BTNCancelaRenomeDeOrigem.GotFocus,
        BTNIgnorar.GotFocus

        Dim btn As Button
        btn = CType(sender, Button)

        btn.FlatAppearance.BorderColor = _colorGotFocus

        Select Case btn.Name
            Case "BTNMesclar", "BTNSubstituir", "BTNIgnorar"
                ExibirEAtualizarHelp(btn)
            Case Else
                Panel_LBLInfo.Visible = False
        End Select
    End Sub

    Private Sub Buttons_LostFocus(sender As Object, e As EventArgs) _
        Handles OK_Button.LostFocus, Cancel_Button.LostFocus,
        BTNMesclar.LostFocus, BTNSubstituir.LostFocus,
        BTNSubstituir.LostFocus, BTNRendo.LostFocus,
        BTNCancelaRenomeDeDestino.LostFocus, BTNCancelaRenomeDeOrigem.LostFocus,
        BTNConfirmarRenomeDeDestino.LostFocus, BTNCancelaRenomeDeOrigem.LostFocus,
        BTNIgnorar.LostFocus

        Dim btn As Button
        btn = CType(sender, Button)

        btn.FlatAppearance.BorderColor = _colorLostFocus

    End Sub
    Sub ExibirEAtualizarHelp(btn As Object)
        Panel_LBLInfo.Visible = True
        LBLInfo.Text = btn.Tag
    End Sub

    Private Sub BTNSubstituir_Click(sender As Object, e As EventArgs) Handles BTNSubstituir.Click

    End Sub

    Private Sub BTNIgnorar_Click(sender As Object, e As EventArgs) Handles BTNIgnorar.Click

    End Sub
End Class
