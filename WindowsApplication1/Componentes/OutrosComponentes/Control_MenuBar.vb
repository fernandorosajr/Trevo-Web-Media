Public Class Control_MenuBar


    ' Propriedades do controle
    Private _colorSelectAndHover As Color

    Public Property ColorSelectAndHover As Color
        Get
            Return _colorSelectAndHover
        End Get
        Set(value As Color)
            _colorSelectAndHover = value

        End Set
    End Property

    Private Sub BTNNovaPasta_Click(sender As Object, e As EventArgs) Handles BTNNovaPasta.Click

    End Sub

    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles BTNNovaPasta.MouseLeave, BTNNovaMidia.MouseLeave, BTNMaisProcessos.MouseLeave, BTNMover.MouseLeave, BTNCopiar.MouseLeave, BTNExcluir.MouseLeave, BTNRenomear.MouseLeave, BTNOpcoes_BTNNovaPasta.MouseLeave, BTNOpcoes_BTNNovaMidia.MouseLeave, BTNOpcoes_BTNMaisProcessos.MouseLeave, BTNOpcoes_BTNMover.MouseLeave, BTNOpcoes_BTNCopiar.MouseLeave, BTNOpcoes_BTNExcluir.MouseLeave, BTNOpcoes_BTNRenomear.MouseLeave
        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.BackColor = Color.WhiteSmoke
        Select Case btn.Name
            Case "BTNNovaPasta"
                BTNOpcoes_BTNNovaPasta.BackColor = Color.WhiteSmoke

            Case "BTNNovaMidia"
                BTNOpcoes_BTNNovaMidia.BackColor = Color.WhiteSmoke

            Case "BTNMaisProcessos"
                BTNOpcoes_BTNMaisProcessos.BackColor = Color.WhiteSmoke

            Case "BTNMover"
                BTNOpcoes_BTNMover.BackColor = Color.WhiteSmoke

            Case "BTNCopiar"
                BTNOpcoes_BTNCopiar.BackColor = Color.WhiteSmoke

            Case "BTNExcluir"
                BTNOpcoes_BTNExcluir.BackColor = Color.WhiteSmoke

            Case "BTNRenomear"
                BTNOpcoes_BTNRenomear.BackColor = Color.WhiteSmoke

            Case "BTNOpcoes_BTNNovaPasta"
                BTNNovaPasta.BackColor = Color.WhiteSmoke

            Case "BTNOpcoes_BTNNovaMidia"
                BTNNovaMidia.BackColor = Color.WhiteSmoke

            Case "BTNOpcoes_BTNMaisProcessos"
                BTNMaisProcessos.BackColor = Color.WhiteSmoke

            Case "BTNOpcoes_BTNMover"
                BTNMover.BackColor = Color.WhiteSmoke

            Case "BTNOpcoes_BTNCopiar"
                BTNCopiar.BackColor = Color.WhiteSmoke

            Case "BTNOpcoes_BTNExcluir"
                BTNExcluir.BackColor = Color.WhiteSmoke

            Case "BTNOpcoes_BTNRenomear"
                BTNRenomear.BackColor = Color.WhiteSmoke

        End Select
    End Sub


    Private Sub Buttons_MouseHover(sender As Object, e As EventArgs) Handles BTNNovaPasta.MouseHover, BTNNovaMidia.MouseHover, BTNMaisProcessos.MouseHover, BTNMover.MouseHover, BTNCopiar.MouseHover, BTNExcluir.MouseHover, BTNRenomear.MouseHover, BTNOpcoes_BTNNovaPasta.MouseHover, BTNOpcoes_BTNNovaMidia.MouseHover, BTNOpcoes_BTNMaisProcessos.MouseHover, BTNOpcoes_BTNMover.MouseHover, BTNOpcoes_BTNCopiar.MouseHover, BTNOpcoes_BTNExcluir.MouseHover, BTNOpcoes_BTNRenomear.MouseHover

        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.BackColor = _colorSelectAndHover
        Select Case btn.Name
            Case "BTNNovaPasta"
                BTNOpcoes_BTNNovaPasta.BackColor = Color.PowderBlue

            Case "BTNNovaMidia"
                BTNOpcoes_BTNNovaMidia.BackColor = Color.PowderBlue

            Case "BTNMaisProcessos"
                BTNOpcoes_BTNMaisProcessos.BackColor = Color.PowderBlue

            Case "BTNMover"
                BTNOpcoes_BTNMover.BackColor = Color.PowderBlue

            Case "BTNCopiar"
                BTNOpcoes_BTNCopiar.BackColor = Color.PowderBlue

            Case "BTNExcluir"
                BTNOpcoes_BTNExcluir.BackColor = Color.PowderBlue

            Case "BTNRenomear"
                BTNOpcoes_BTNRenomear.BackColor = Color.PowderBlue

            Case "BTNOpcoes_BTNNovaPasta"
                BTNNovaPasta.BackColor = Color.PowderBlue

            Case "BTNOpcoes_BTNNovaMidia"
                BTNNovaMidia.BackColor = Color.PowderBlue

            Case "BTNOpcoes_BTNMaisProcessos"
                BTNMaisProcessos.BackColor = Color.PowderBlue

            Case "BTNOpcoes_BTNMover"
                BTNMover.BackColor = Color.PowderBlue

            Case "BTNOpcoes_BTNCopiar"
                BTNCopiar.BackColor = Color.PowderBlue

            Case "BTNOpcoes_BTNExcluir"
                BTNExcluir.BackColor = Color.PowderBlue

            Case "BTNOpcoes_BTNRenomear"
                BTNRenomear.BackColor = Color.PowderBlue

        End Select



    End Sub

    Private Sub Control_MenuBar_Load(sender As Object, e As EventArgs) Handles Me.Load
        _colorSelectAndHover = Color.RoyalBlue

    End Sub



    '  https://imasters.com.br/dotnet/programacao-orientada-objetos-em-10-licoes-praticas-parte-04
    '  http://www.macoratti.net/vbn_evnt.htm

End Class
