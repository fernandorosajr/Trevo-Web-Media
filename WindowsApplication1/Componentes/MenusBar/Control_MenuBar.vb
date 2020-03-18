Public Class Control_MenuBar

    Dim pMouse As Point

    ' Propriedades do controle.


    Private _borderColorChecked As Color

    Public Property BorderColorChecked As Color
        Get
            Return _borderColorChecked
        End Get
        Set(value As Color)
            _borderColorChecked = value

        End Set
    End Property

    Private _backgroundColorChecked As Color

    Public Property BackgroundColorChecked As Color
        Get
            Return _backgroundColorChecked

        End Get
        Set(value As Color)
            _backgroundColorChecked = value

        End Set
    End Property


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

        Dim obj As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            obj = CType(sender, CheckBox)
        Else
            obj = CType(sender, Button)
        End If

        obj.Parent.Parent.BackColor = _borderColorSelectAndMouseUp
        obj.Parent.BackColor = _backgroundColorSelectAndMouseUp

        obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseUp


        Select Case obj.Name
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

        Dim obj As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            obj = CType(sender, CheckBox)
        Else
            obj = CType(sender, Button)
        End If


        If TypeOf obj Is CheckBox Then
            If obj.Checked = True Then

                obj.Parent.Parent.BackColor = _borderColorChecked
                obj.Parent.BackColor = _backgroundColorChecked
                obj.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

            Else

                obj.Parent.Parent.BackColor = _borderColorSelectAndMouseLeave
                obj.Parent.BackColor = _backgroundColorSelectAndMouseLeave

            End If

        Else
            obj.Parent.Parent.BackColor = _borderColorSelectAndMouseLeave
            obj.Parent.BackColor = _backgroundColorSelectAndMouseLeave
        End If



        Select Case obj.Name
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

    Private Sub Buttons_MouseMove(sender As Object, e As EventArgs) Handles BTNNovaPasta.MouseMove, BTNNovaMidia.MouseMove, BTNMaisProcessos.MouseMove, BTNMover.MouseMove, BTNCopiar.MouseMove, BTNExcluir.MouseMove, BTNRenomear.MouseMove, BTNOpcoes_BTNNovaPasta.MouseMove, BTNOpcoes_BTNNovaMidia.MouseMove, BTNOpcoes_BTNMaisProcessos.MouseMove, BTNOpcoes_BTNMover.MouseMove, BTNOpcoes_BTNCopiar.MouseMove, BTNOpcoes_BTNExcluir.MouseMove, BTNOpcoes_BTNRenomear.MouseMove, CHKExibirPainelAreaDeTranferencia.MouseMove, BTNRecortarParaAreaDeTransferencia.MouseMove, BTNColarDaAreaDeTranferencia.MouseMove, BTNCopiarParaAreaDeTransferencia.MouseMove, BTNLimparSelecao.MouseMove, BTNInverterSelecao.MouseMove, BTNSelecionarTudo.MouseMove

        Dim obj As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            obj = CType(sender, CheckBox)
        Else
            obj = CType(sender, Button)
        End If


        If TypeOf obj Is CheckBox Then
            If obj.Checked = True Then

                obj.Parent.Parent.BackColor = _borderColorChecked
                obj.Parent.BackColor = _backgroundColorChecked
                obj.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

            Else

                obj.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
                obj.Parent.BackColor = _backgroundColorSelectAndMouseHover
                obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover

            End If

        Else
            obj.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
            obj.Parent.BackColor = _backgroundColorSelectAndMouseHover
            obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover
        End If





        Select Case obj.Name
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



    Private Sub Buttons_MouseHover(sender As Object, e As EventArgs) Handles BTNNovaPasta.MouseHover, BTNNovaMidia.MouseHover, BTNMaisProcessos.MouseHover, BTNMover.MouseHover, BTNCopiar.MouseHover, BTNExcluir.MouseHover, BTNRenomear.MouseHover, BTNOpcoes_BTNNovaPasta.MouseHover, BTNOpcoes_BTNNovaMidia.MouseHover, BTNOpcoes_BTNMaisProcessos.MouseHover, BTNOpcoes_BTNMover.MouseHover, BTNOpcoes_BTNCopiar.MouseHover, BTNOpcoes_BTNExcluir.MouseHover, BTNOpcoes_BTNRenomear.MouseHover, CHKExibirPainelAreaDeTranferencia.MouseHover, BTNRecortarParaAreaDeTransferencia.MouseHover, BTNColarDaAreaDeTranferencia.MouseHover, BTNCopiarParaAreaDeTransferencia.MouseHover, BTNLimparSelecao.MouseHover, BTNInverterSelecao.MouseHover, BTNSelecionarTudo.MouseHover

        Dim obj As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            obj = CType(sender, CheckBox)
        Else
            obj = CType(sender, Button)
        End If


        If TypeOf obj Is CheckBox Then
            If obj.Checked = True Then

                obj.Parent.Parent.BackColor = _borderColorChecked
                obj.Parent.BackColor = _backgroundColorChecked
                obj.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

            Else

                obj.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
                obj.Parent.BackColor = _backgroundColorSelectAndMouseHover
                obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover

            End If

        Else
            obj.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
            obj.Parent.BackColor = _backgroundColorSelectAndMouseHover
            obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover
        End If



        Select Case obj.Name
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

        _borderColorChecked = Color.RoyalBlue
        _backgroundColorChecked = Color.LightSkyBlue

        _borderColorSelectAndMouseHover = Color.SkyBlue
        _backgroundColorSelectAndMouseHover = Color.LightCyan

        _borderColorSelectAndMouseLeave = Color.Transparent
        _backgroundColorSelectAndMouseLeave = Color.Transparent

        _borderColorSelectAndMouseDown = Color.CornflowerBlue
        _backgroundColorSelectAndMouseDown = Color.PowderBlue

        _borderColorSelectAndMouseUp = _borderColorSelectAndMouseHover
        _backgroundColorSelectAndMouseUp = _backgroundColorSelectAndMouseHover

    End Sub

    Private Sub ButtonsContextMenu_Click(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNNovaPasta.Click, BTNOpcoes_BTNMaisProcessos.Click, BTNOpcoes_BTNMover.Click, BTNOpcoes_BTNCopiar.Click, BTNOpcoes_BTNExcluir.Click, BTNOpcoes_BTNRenomear.Click


        Dim btn As Button = CType(sender, Button)

        btn.ContextMenuStrip.Show(btn, 0, btn.Height)

    End Sub

    Private Sub CMenuS_BTNOpcoes_BTNMaisProcessos_SubItens_Click(sender As Object, e As EventArgs) Handles TSMenuItemTipoComposto.Click, TSMenuItemTipoCriacao.Click, TSMenuItemTipoCopia.Click, TSMenuItemTipoMover.Click, TSMenuItemTipoRenome.Click, TSMenuItemTipoExclusao.Click
        Dim menuItem As ToolStripMenuItem
        menuItem = CType(sender, ToolStripMenuItem)

        BTNMaisProcessos.BackgroundImage = menuItem.Image

    End Sub



    Private Sub NovaPastaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaPastaToolStripMenuItem.Click, NovaPastaProcessoToolStripMenuItem.Click
        Dim menuItem As ToolStripMenuItem
        menuItem = CType(sender, ToolStripMenuItem)

        BTNNovaPasta.BackgroundImage = menuItem.Image
    End Sub

    Private Sub ExcluirParaLixeiraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirParaLixeiraToolStripMenuItem.Click, ExcluirPermanentementeToolStripMenuItem.Click
        Dim menuItem As ToolStripMenuItem
        menuItem = CType(sender, ToolStripMenuItem)

        BTNExcluir.BackgroundImage = menuItem.Image

    End Sub

    Private Sub CHKExibirPainelAreaDeTranferencia_CheckedChanged(sender As Object, e As EventArgs) Handles CHKExibirPainelAreaDeTranferencia.CheckedChanged
        Dim chk As CheckBox
        chk = CType(sender, CheckBox)

        If chk.Checked = True Then
            chk.Parent.Parent.BackColor = _borderColorChecked
            chk.FlatAppearance.BorderColor = _borderColorChecked

        Else
            chk.Parent.Parent.BackColor = Color.Transparent
            chk.FlatAppearance.BorderSize = 0
        End If
        chk.FlatAppearance.CheckedBackColor = _backgroundColorChecked

    End Sub

    Private Sub Buttons_MouseDown(sender As Object, e As MouseEventArgs) Handles CHKExibirPainelAreaDeTranferencia.MouseDown, BTNSelecionarTudo.MouseDown, BTNRenomear.MouseDown, BTNRecortarParaAreaDeTransferencia.MouseDown, BTNOpcoes_BTNRenomear.MouseDown, BTNOpcoes_BTNNovaPasta.MouseDown, BTNOpcoes_BTNNovaMidia.MouseDown, BTNOpcoes_BTNMover.MouseDown, BTNOpcoes_BTNMaisProcessos.MouseDown, BTNOpcoes_BTNExcluir.MouseDown, BTNOpcoes_BTNCopiar.MouseDown, BTNNovaPasta.MouseDown, BTNNovaMidia.MouseDown, BTNMover.MouseDown, BTNMaisProcessos.MouseDown, BTNLimparSelecao.MouseDown, BTNInverterSelecao.MouseDown, BTNExcluir.MouseDown, BTNCopiarParaAreaDeTransferencia.MouseDown, BTNCopiar.MouseDown, BTNColarDaAreaDeTranferencia.MouseDown

    End Sub

    Private Sub Buttons_MouseMove(sender As Object, e As MouseEventArgs) Handles CHKExibirPainelAreaDeTranferencia.MouseMove, BTNSelecionarTudo.MouseMove, BTNRenomear.MouseMove, BTNRecortarParaAreaDeTransferencia.MouseMove, BTNOpcoes_BTNRenomear.MouseMove, BTNOpcoes_BTNNovaPasta.MouseMove, BTNOpcoes_BTNNovaMidia.MouseMove, BTNOpcoes_BTNMover.MouseMove, BTNOpcoes_BTNMaisProcessos.MouseMove, BTNOpcoes_BTNExcluir.MouseMove, BTNOpcoes_BTNCopiar.MouseMove, BTNNovaPasta.MouseMove, BTNNovaMidia.MouseMove, BTNMover.MouseMove, BTNMaisProcessos.MouseMove, BTNLimparSelecao.MouseMove, BTNInverterSelecao.MouseMove, BTNExcluir.MouseMove, BTNCopiarParaAreaDeTransferencia.MouseMove, BTNCopiar.MouseMove, BTNColarDaAreaDeTranferencia.MouseMove

    End Sub

    Private Sub Buttons_MouseUp(sender As Object, e As MouseEventArgs) Handles CHKExibirPainelAreaDeTranferencia.MouseUp, BTNSelecionarTudo.MouseUp, BTNRenomear.MouseUp, BTNRecortarParaAreaDeTransferencia.MouseUp, BTNOpcoes_BTNRenomear.MouseUp, BTNOpcoes_BTNNovaPasta.MouseUp, BTNOpcoes_BTNNovaMidia.MouseUp, BTNOpcoes_BTNMover.MouseUp, BTNOpcoes_BTNMaisProcessos.MouseUp, BTNOpcoes_BTNExcluir.MouseUp, BTNOpcoes_BTNCopiar.MouseUp, BTNNovaPasta.MouseUp, BTNNovaMidia.MouseUp, BTNMover.MouseUp, BTNMaisProcessos.MouseUp, BTNLimparSelecao.MouseUp, BTNInverterSelecao.MouseUp, BTNExcluir.MouseUp, BTNCopiarParaAreaDeTransferencia.MouseUp, BTNCopiar.MouseUp, BTNColarDaAreaDeTranferencia.MouseUp

    End Sub

    Private Sub BTNNovaPasta_Click(sender As Object, e As EventArgs) Handles BTNNovaPasta.Click

    End Sub

    Private Sub BTNOpcoes_BTNNovaMidia_Click(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNNovaMidia.Click

    End Sub


    '  https://imasters.com.br/dotnet/programacao-orientada-objetos-em-10-licoes-praticas-parte-04
    '  http://www.macoratti.net/vbn_evnt.htm


    ' https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-inherit-from-existing-windows-forms-controls
    ' https://social.msdn.microsoft.com/Forums/pt-BR/86e1175f-c9bd-4265-8fb1-1a60a28a0edd/eventos-em-um-user-control?forum=vsvbasicpt
    ' https://www.devmedia.com.br/desenvolvimento-de-user-control-com-propriedade-dinamica-parte-1/24197

End Class
