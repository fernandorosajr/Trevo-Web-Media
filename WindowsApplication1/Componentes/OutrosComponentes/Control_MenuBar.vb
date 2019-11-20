Public Class Control_MenuBar


    ' Propriedades do controle


    Private _borderColorSelectAndMouseLeave As Color

    Public Property BorderColorSelectAndMouseLeave As Color
        Get
            Return _borderColorSelectAndMouseLeave
        End Get
        Set(value As Color)
            _borderColorSelectAndMouseLeave = value

        End Set
    End Property


    Private _backgroundColorSelectAndMouseLeave As Color

    Public Property BackgroundColorSelectAndMouseLeave As Color
        Get
            Return _backgroundColorSelectAndMouseLeave
        End Get
        Set(value As Color)
            _backgroundColorSelectAndMouseLeave = value

        End Set
    End Property


    Private _borderColorSelectAndMouseHover As Color

    Public Property BorderColorSelectAndMouseHover As Color
        Get
            Return _borderColorSelectAndMouseHover
        End Get
        Set(value As Color)
            _borderColorSelectAndMouseHover = value

        End Set
    End Property

    Private _backgroundColorSelectAndMouseHover As Color

    Public Property BackgroundColorSelectAndMouseHover As Color
        Get
            Return _backgroundColorSelectAndMouseHover
        End Get
        Set(value As Color)
            _backgroundColorSelectAndMouseHover = value

        End Set
    End Property


    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles BTNNovaPasta.MouseLeave, BTNNovaMidia.MouseLeave, BTNMaisProcessos.MouseLeave, BTNMover.MouseLeave, BTNCopiar.MouseLeave, BTNExcluir.MouseLeave, BTNRenomear.MouseLeave, BTNOpcoes_BTNNovaPasta.MouseLeave, BTNOpcoes_BTNNovaMidia.MouseLeave, BTNOpcoes_BTNMaisProcessos.MouseLeave, BTNOpcoes_BTNMover.MouseLeave, BTNOpcoes_BTNCopiar.MouseLeave, BTNOpcoes_BTNExcluir.MouseLeave, BTNOpcoes_BTNRenomear.MouseLeave
        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseLeave
        btn.Parent.BackColor = _backgroundColorSelectAndMouseLeave

        Select Case btn.Name
            Case "BTNNovaPasta"
                BTNOpcoes_BTNNovaPasta.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNNovaMidia"
                BTNOpcoes_BTNNovaMidia.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNMaisProcessos"
                BTNOpcoes_BTNMaisProcessos.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNMover"
                BTNOpcoes_BTNMover.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNCopiar"
                BTNOpcoes_BTNCopiar.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNExcluir"
                BTNOpcoes_BTNExcluir.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNRenomear"
                BTNOpcoes_BTNRenomear.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNOpcoes_BTNNovaPasta"
                BTNNovaPasta.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNOpcoes_BTNNovaMidia"
                BTNNovaMidia.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNOpcoes_BTNMaisProcessos"
                BTNMaisProcessos.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNOpcoes_BTNMover"
                BTNMover.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNOpcoes_BTNCopiar"
                BTNCopiar.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNOpcoes_BTNExcluir"
                BTNExcluir.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNOpcoes_BTNRenomear"
                BTNRenomear.BackColor = _backgroundColorSelectAndMouseLeave

        End Select
    End Sub


    Private Sub Buttons_MouseHover(sender As Object, e As EventArgs) Handles BTNNovaPasta.MouseHover, BTNNovaMidia.MouseHover, BTNMaisProcessos.MouseHover, BTNMover.MouseHover, BTNCopiar.MouseHover, BTNExcluir.MouseHover, BTNRenomear.MouseHover, BTNOpcoes_BTNNovaPasta.MouseHover, BTNOpcoes_BTNNovaMidia.MouseHover, BTNOpcoes_BTNMaisProcessos.MouseHover, BTNOpcoes_BTNMover.MouseHover, BTNOpcoes_BTNCopiar.MouseHover, BTNOpcoes_BTNExcluir.MouseHover, BTNOpcoes_BTNRenomear.MouseHover

        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
        btn.Parent.BackColor = _backgroundColorSelectAndMouseHover
        btn.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover


        Select Case btn.Name
            Case "BTNNovaPasta"
                BTNOpcoes_BTNNovaPasta.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNNovaMidia"
                BTNOpcoes_BTNNovaMidia.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNMaisProcessos"
                BTNOpcoes_BTNMaisProcessos.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNMover"
                BTNOpcoes_BTNMover.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNCopiar"
                BTNOpcoes_BTNCopiar.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNExcluir"
                BTNOpcoes_BTNExcluir.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNRenomear"
                BTNOpcoes_BTNRenomear.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNOpcoes_BTNNovaPasta"
                BTNNovaPasta.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNOpcoes_BTNNovaMidia"
                BTNNovaMidia.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNOpcoes_BTNMaisProcessos"
                BTNMaisProcessos.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNOpcoes_BTNMover"
                BTNMover.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNOpcoes_BTNCopiar"
                BTNCopiar.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNOpcoes_BTNExcluir"
                BTNExcluir.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNOpcoes_BTNRenomear"
                BTNRenomear.BackColor = _backgroundColorSelectAndMouseHover

        End Select

    End Sub

    Private Sub Control_MenuBar_Load(sender As Object, e As EventArgs) Handles Me.Load
        _borderColorSelectAndMouseHover = Color.RoyalBlue
        _backgroundColorSelectAndMouseHover = Color.PowderBlue

        _borderColorSelectAndMouseLeave = Color.Transparent
        _backgroundColorSelectAndMouseLeave = Color.Transparent


    End Sub



    '  https://imasters.com.br/dotnet/programacao-orientada-objetos-em-10-licoes-praticas-parte-04
    '  http://www.macoratti.net/vbn_evnt.htm

End Class
