Imports System.Windows.Forms

Public Class FRMDialogConflictingFolders

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BTNMesclar_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNMesclar.MouseMove

        Panel_LBLInfo.Visible = True
        LBLInfo.Text = "Mescla pastas no destino. Se houver arquivos de mesmo nome será perguntado o que fazer."
    End Sub


    Private Sub BTNSubstitui_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNSubstituir.MouseMove
        Panel_LBLInfo.Visible = True
        LBLInfo.Text = "Exclui pasta destino e seus conteúdos e a substitui pela pasta de origem."
    End Sub

    Private Sub BTNIgnorar_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNIgnorar.MouseMove
        Panel_LBLInfo.Visible = True
        LBLInfo.Text = "Nada será feito."

    End Sub

    Private Sub FRMDialogConflictingFolders_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Panel_LBLInfo.Visible = False

    End Sub

    Private Sub Panel_LBLOutrasOpcoes_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_LBLOutrasOpcoes.MouseMove
        Panel_LBLInfo.Visible = False
    End Sub

    Private Sub LNKLRenomeOrigem_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNKLRenomeOrigem.LinkClicked
        PanelEnvolve_TXTNomeDaOrigem.Left = LNKLRenomeOrigem.Left
        PanelEnvolve_TXTNomeDaOrigem.Width = LBLValueOrigem.Width

        PanelEnvolve_TXTNomeDaOrigem.Visible = Not (PanelBorder_TXTNomeDaOrigem.Visible)

        TXTNomeDaOrigem.Focus()

    End Sub

    Private Sub BTNConfirmarRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNConfirmarRenomeDeOrigem.Click
        PanelEnvolve_TXTNomeDaOrigem.Visible = False
    End Sub

    Private Sub BTNCancelaRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNCancelaRenomeDeOrigem.Click
        PanelEnvolve_TXTNomeDaOrigem.Visible = False

    End Sub

    Private Sub BTNConfirmarRenomeDeDestino_Click(sender As Object, e As EventArgs) Handles BTNConfirmarRenomeDeDestino.Click
        PanelEnvolve_TXTNomeDoDestino.Visible = False
    End Sub

    Private Sub BTNCancelaRenomeDeDestino_Click(sender As Object, e As EventArgs) Handles BTNCancelaRenomeDeDestino.Click
        PanelEnvolve_TXTNomeDoDestino.Visible = False
    End Sub

    Private Sub LNKLRenomeDestino_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNKLRenomeDestino.LinkClicked
        PanelEnvolve_TXTNomeDoDestino.Left = LNKLRenomeDestino.Left
        PanelEnvolve_TXTNomeDoDestino.Width = LBLValueDestino.Width

        PanelEnvolve_TXTNomeDoDestino.Visible = Not (PanelEnvolve_TXTNomeDoDestino.Visible)

        TXTNomeDoDestino.Focus()

    End Sub
End Class
