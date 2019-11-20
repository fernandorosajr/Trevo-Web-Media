Public Class Control_MenuBar


    ' Propriedades do controle.

    ' Propriedade da cor de quando o mouse solta o botão.
    Private _borderColorSelectAndMouseUp As Color

    Public Property BorderColorSelectAndMouseUp As Color
        Get
            Return _borderColorSelectAndMouseUp
        End Get
        Set(value As Color)
            _borderColorSelectAndMouseUp = value

        End Set
    End Property

    Private _backgroundColorSelectAndMouseUp As Color

    Public Property BackgroundColorSelectAndMouseUp As Color
        Get
            Return _backgroundColorSelectAndMouseUp

        End Get
        Set(value As Color)
            _backgroundColorSelectAndMouseUp = value

        End Set
    End Property







    Private _borderColorSelectAndMouseDown As Color

    Public Property BorderColorSelectAndMouseDown As Color
        Get
            Return _borderColorSelectAndMouseDown
        End Get
        Set(value As Color)
            _borderColorSelectAndMouseDown = value

        End Set
    End Property

    Private _backgroundColorSelectAndMouseDown As Color

    Public Property BackgroundColorSelectAndMouseDown As Color
        Get
            Return _backgroundColorSelectAndMouseDown
        End Get
        Set(value As Color)
            _backgroundColorSelectAndMouseDown = value

        End Set
    End Property


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



    Private Sub Buttons_MouseUp(sender As Object, e As EventArgs) Handles BTNNovaPasta.MouseUp, BTNNovaMidia.MouseUp, BTNMaisProcessos.MouseUp, BTNMover.MouseUp, BTNCopiar.MouseUp, BTNExcluir.MouseUp, BTNRenomear.MouseUp, BTNOpcoes_BTNNovaPasta.MouseUp, BTNOpcoes_BTNNovaMidia.MouseUp, BTNOpcoes_BTNMaisProcessos.MouseUp, BTNOpcoes_BTNMover.MouseUp, BTNOpcoes_BTNCopiar.MouseUp, BTNOpcoes_BTNExcluir.MouseUp, BTNOpcoes_BTNRenomear.MouseUp, CHKExibirPainelAreaDeTranferencia.MouseUp, BTNRecortarParaAreaDeTransferencia.MouseUp, BTNColarDaAreaDeTranferencia.MouseUp, BTNCopiarParaAreaDeTransferencia.MouseUp, BTNLimparSelecao.MouseUp, BTNInverterSelecao.MouseUp, BTNSelecionarTudo.MouseUp

        Dim btn As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            btn = CType(sender, CheckBox)
        Else
            btn = CType(sender, Button)
        End If

        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseUp
        btn.Parent.BackColor = _backgroundColorSelectAndMouseUp
        'btn.FlatAppearance.MouseDownBackColor = _backgroundColorSelectAndMouseUp
        btn.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseUp


        Select Case btn.Name
            Case "BTNNovaPasta"
                BTNOpcoes_BTNNovaPasta.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNNovaMidia"
                BTNOpcoes_BTNNovaMidia.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNMaisProcessos"
                BTNOpcoes_BTNMaisProcessos.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNMover"
                BTNOpcoes_BTNMover.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNCopiar"
                BTNOpcoes_BTNCopiar.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNExcluir"
                BTNOpcoes_BTNExcluir.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNRenomear"
                BTNOpcoes_BTNRenomear.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNOpcoes_BTNNovaPasta"
                BTNNovaPasta.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNOpcoes_BTNNovaMidia"
                BTNNovaMidia.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNOpcoes_BTNMaisProcessos"
                BTNMaisProcessos.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNOpcoes_BTNMover"
                BTNMover.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNOpcoes_BTNCopiar"
                BTNCopiar.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNOpcoes_BTNExcluir"
                BTNExcluir.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNOpcoes_BTNRenomear"
                BTNRenomear.BackColor = _backgroundColorSelectAndMouseUp




            Case "CHKExibirPainelAreaDeTranferencia"
                CHKExibirPainelAreaDeTranferencia.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNRecortarParaAreaDeTransferencia"
                BTNRecortarParaAreaDeTransferencia.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNColarDaAreaDeTranferencia"
                BTNColarDaAreaDeTranferencia.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNCopiarParaAreaDeTransferencia"
                BTNCopiarParaAreaDeTransferencia.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNLimparSelecao"
                BTNLimparSelecao.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNInverterSelecao"
                BTNInverterSelecao.BackColor = _backgroundColorSelectAndMouseUp

            Case "BTNSelecionarTudo"
                BTNSelecionarTudo.BackColor = _backgroundColorSelectAndMouseUp




        End Select
    End Sub



    Private Sub Buttons_MouseDown(sender As Object, e As EventArgs) Handles BTNNovaPasta.MouseDown, BTNNovaMidia.MouseDown, BTNMaisProcessos.MouseDown, BTNMover.MouseDown, BTNCopiar.MouseDown, BTNExcluir.MouseDown, BTNRenomear.MouseDown, BTNOpcoes_BTNNovaPasta.MouseDown, BTNOpcoes_BTNNovaMidia.MouseDown, BTNOpcoes_BTNMaisProcessos.MouseDown, BTNOpcoes_BTNMover.MouseDown, BTNOpcoes_BTNCopiar.MouseDown, BTNOpcoes_BTNExcluir.MouseDown, BTNOpcoes_BTNRenomear.MouseDown, CHKExibirPainelAreaDeTranferencia.MouseDown, BTNRecortarParaAreaDeTransferencia.MouseDown, BTNColarDaAreaDeTranferencia.MouseDown, BTNCopiarParaAreaDeTransferencia.MouseDown, BTNLimparSelecao.MouseDown, BTNInverterSelecao.MouseDown, BTNSelecionarTudo.MouseDown


        Dim btn As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            btn = CType(sender, CheckBox)
        Else
            btn = CType(sender, Button)
        End If

        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseDown
        btn.Parent.BackColor = _backgroundColorSelectAndMouseDown
        btn.FlatAppearance.MouseDownBackColor = _backgroundColorSelectAndMouseDown

        Select Case btn.Name
            Case "BTNNovaPasta"
                BTNOpcoes_BTNNovaPasta.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNNovaMidia"
                BTNOpcoes_BTNNovaMidia.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNMaisProcessos"
                BTNOpcoes_BTNMaisProcessos.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNMover"
                BTNOpcoes_BTNMover.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNCopiar"
                BTNOpcoes_BTNCopiar.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNExcluir"
                BTNOpcoes_BTNExcluir.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNRenomear"
                BTNOpcoes_BTNRenomear.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNOpcoes_BTNNovaPasta"
                BTNNovaPasta.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNOpcoes_BTNNovaMidia"
                BTNNovaMidia.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNOpcoes_BTNMaisProcessos"
                BTNMaisProcessos.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNOpcoes_BTNMover"
                BTNMover.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNOpcoes_BTNCopiar"
                BTNCopiar.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNOpcoes_BTNExcluir"
                BTNExcluir.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNOpcoes_BTNRenomear"
                BTNRenomear.BackColor = _backgroundColorSelectAndMouseDown






            Case "CHKExibirPainelAreaDeTranferencia"
                CHKExibirPainelAreaDeTranferencia.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNRecortarParaAreaDeTransferencia"
                BTNRecortarParaAreaDeTransferencia.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNColarDaAreaDeTranferencia"
                BTNColarDaAreaDeTranferencia.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNCopiarParaAreaDeTransferencia"
                BTNCopiarParaAreaDeTransferencia.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNLimparSelecao"
                BTNLimparSelecao.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNInverterSelecao"
                BTNInverterSelecao.BackColor = _backgroundColorSelectAndMouseDown

            Case "BTNSelecionarTudo"
                BTNSelecionarTudo.BackColor = _backgroundColorSelectAndMouseDown


        End Select
    End Sub



    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles BTNNovaPasta.MouseLeave, BTNNovaMidia.MouseLeave, BTNMaisProcessos.MouseLeave, BTNMover.MouseLeave, BTNCopiar.MouseLeave, BTNExcluir.MouseLeave, BTNRenomear.MouseLeave, BTNOpcoes_BTNNovaPasta.MouseLeave, BTNOpcoes_BTNNovaMidia.MouseLeave, BTNOpcoes_BTNMaisProcessos.MouseLeave, BTNOpcoes_BTNMover.MouseLeave, BTNOpcoes_BTNCopiar.MouseLeave, BTNOpcoes_BTNExcluir.MouseLeave, BTNOpcoes_BTNRenomear.MouseLeave, CHKExibirPainelAreaDeTranferencia.MouseLeave, BTNRecortarParaAreaDeTransferencia.MouseLeave, BTNColarDaAreaDeTranferencia.MouseLeave, BTNCopiarParaAreaDeTransferencia.MouseLeave, BTNLimparSelecao.MouseLeave, BTNInverterSelecao.MouseLeave, BTNSelecionarTudo.MouseLeave

        Dim btn As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            btn = CType(sender, CheckBox)
        Else
            btn = CType(sender, Button)
        End If

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





            Case "CHKExibirPainelAreaDeTranferencia"
                CHKExibirPainelAreaDeTranferencia.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNRecortarParaAreaDeTransferencia"
                BTNRecortarParaAreaDeTransferencia.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNColarDaAreaDeTranferencia"
                BTNColarDaAreaDeTranferencia.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNCopiarParaAreaDeTransferencia"
                BTNCopiarParaAreaDeTransferencia.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNLimparSelecao"
                BTNLimparSelecao.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNInverterSelecao"
                BTNInverterSelecao.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNSelecionarTudo"
                BTNSelecionarTudo.BackColor = _backgroundColorSelectAndMouseLeave


        End Select
    End Sub


    Private Sub Buttons_MouseHover(sender As Object, e As EventArgs) Handles BTNNovaPasta.MouseHover, BTNNovaMidia.MouseHover, BTNMaisProcessos.MouseHover, BTNMover.MouseHover, BTNCopiar.MouseHover, BTNExcluir.MouseHover, BTNRenomear.MouseHover, BTNOpcoes_BTNNovaPasta.MouseHover, BTNOpcoes_BTNNovaMidia.MouseHover, BTNOpcoes_BTNMaisProcessos.MouseHover, BTNOpcoes_BTNMover.MouseHover, BTNOpcoes_BTNCopiar.MouseHover, BTNOpcoes_BTNExcluir.MouseHover, BTNOpcoes_BTNRenomear.MouseHover, CHKExibirPainelAreaDeTranferencia.MouseHover, BTNRecortarParaAreaDeTransferencia.MouseHover, BTNColarDaAreaDeTranferencia.MouseHover, BTNCopiarParaAreaDeTransferencia.MouseHover, BTNLimparSelecao.MouseHover, BTNInverterSelecao.MouseHover, BTNSelecionarTudo.MouseHover

        Dim btn As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            btn = CType(sender, CheckBox)
        Else
            btn = CType(sender, Button)
        End If


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



            Case "CHKExibirPainelAreaDeTranferencia"
                CHKExibirPainelAreaDeTranferencia.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNRecortarParaAreaDeTransferencia"
                BTNRecortarParaAreaDeTransferencia.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNColarDaAreaDeTranferencia"
                BTNColarDaAreaDeTranferencia.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNCopiarParaAreaDeTransferencia"
                BTNCopiarParaAreaDeTransferencia.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNLimparSelecao"
                BTNLimparSelecao.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNInverterSelecao"
                BTNInverterSelecao.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNSelecionarTudo"
                BTNSelecionarTudo.BackColor = _backgroundColorSelectAndMouseHover



        End Select

    End Sub

    Private Sub Control_MenuBar_Load(sender As Object, e As EventArgs) Handles Me.Load
        _borderColorSelectAndMouseHover = Color.RoyalBlue
        _backgroundColorSelectAndMouseHover = Color.PowderBlue

        _borderColorSelectAndMouseLeave = Color.Transparent
        _backgroundColorSelectAndMouseLeave = Color.Transparent

        _borderColorSelectAndMouseDown = Color.RoyalBlue
        _backgroundColorSelectAndMouseDown = Color.LightSkyBlue

        _borderColorSelectAndMouseUp = _borderColorSelectAndMouseHover
        _backgroundColorSelectAndMouseUp = _backgroundColorSelectAndMouseHover

    End Sub

    Private Sub BTNNovaMidia_Click(sender As Object, e As EventArgs) Handles BTNNovaMidia.Click

    End Sub




    '  https://imasters.com.br/dotnet/programacao-orientada-objetos-em-10-licoes-praticas-parte-04
    '  http://www.macoratti.net/vbn_evnt.htm

End Class
