Imports System.Drawing

Public Class ControlPainel_Acoes

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

    Public Property Cor02 As Color

    ' Eventos do controle
    Private Sub ControlPainel_Acoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _colorSelectAndHover = SystemColors.HotTrack

        If CHK_ShowPanelAllProcessosAcoes.CheckState = 1 Then
            CHK_ShowPanelAllProcessosAcoes.Parent.BackColor = _colorSelectAndHover
        Else
            CHK_ShowPanelAllProcessosAcoes.Parent.BackColor = CHK_ShowPanelAllProcessosAcoes.BackColor

        End If

    End Sub


    Private Sub CHK_ShowPanelAllProcessosAcoes_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_ShowPanelAllProcessosAcoes.CheckedChanged
        PanelAllProcessosAcoes.Visible = CHK_ShowPanelAllProcessosAcoes.CheckState
        Splitter4.Visible = PanelAllProcessosAcoes.Visible

        If PanelAllProcessosAcoes.Visible Then
            PanelAllAgrupamentos.Dock = DockStyle.Top
        Else
            PanelAllAgrupamentos.Dock = DockStyle.Fill

        End If

    End Sub

    Private Sub TXTNomeDoGrupo_MouseHover(sender As Object, e As EventArgs) Handles TXTNomeDoGrupo.MouseHover
        TXTNomeDoGrupo.Parent.Parent.BackColor = _colorSelectAndHover
    End Sub

    Private Sub TXTNomeDoGrupo_MouseLeave(sender As Object, e As EventArgs) Handles TXTNomeDoGrupo.MouseLeave
        If TXTNomeDoGrupo.Focused Then
            TXTNomeDoGrupo.Parent.Parent.BackColor = _colorSelectAndHover
        Else
            TXTNomeDoGrupo.Parent.Parent.BackColor = Color.DimGray
        End If
    End Sub

    Private Sub TXTNomeDoGrupo_GotFocus(sender As Object, e As EventArgs) Handles TXTNomeDoGrupo.GotFocus
        TXTNomeDoGrupo.Parent.Parent.BackColor = _colorSelectAndHover
        TXTNomeDoGrupo.Cursor = Cursors.IBeam
        TXTNomeDoGrupo.SelectAll()
        'TXTNomeDoGrupo.SelectionStart = 0
        'TXTNomeDoGrupo.SelectionLength = Len(TXTNomeDoGrupo.Text)

    End Sub
    Private Sub TXTNomeDoGrupo_LostFocus(sender As Object, e As EventArgs) Handles TXTNomeDoGrupo.LostFocus
        TXTNomeDoGrupo.Parent.Parent.BackColor = Color.DimGray
        TXTNomeDoGrupo.Cursor = Cursors.Arrow
    End Sub


    Private Sub TXTNomeDoGrupo_TextChanged(sender As Object, e As EventArgs) Handles TXTNomeDoGrupo.TextChanged
        If TXTNomeDoGrupo.Focus Then
            TXTNomeDoGrupo.Parent.Parent.BackColor = _colorSelectAndHover
        End If
    End Sub

    Private Sub LBLNomeDoGrupo_Click(sender As Object, e As EventArgs) Handles LBLNomeDoGrupo.Click
        TXTNomeDoGrupo.Focus()
    End Sub

    Private Sub PanelFundoDoNomeDoGrupo_MouseHover(sender As Object, e As EventArgs) Handles PanelFundoDoNomeDoGrupo.MouseHover
        TXTNomeDoGrupo.Parent.Parent.BackColor = _colorSelectAndHover
    End Sub

    Private Sub BTNSelectedNewGroupType_MouseHover(sender As Object, e As EventArgs) Handles BTNSelectedNewGroupType.MouseHover
        BTNSelectedNewGroupType.Parent.Parent.BackColor = _colorSelectAndHover

        If TXTNomeDoGrupo.Focused Then
            TXTNomeDoGrupo.Parent.Parent.BackColor = _colorSelectAndHover
        End If

    End Sub

    Private Sub BTNSelectedNewGroupType_MouseLeave(sender As Object, e As EventArgs) Handles BTNSelectedNewGroupType.MouseLeave

        If BTNSelectedNewGroupType.Focused Or BTNSelectNewGroupType.Focused Then
            BTNSelectedNewGroupType.Parent.Parent.BackColor = _colorSelectAndHover
        Else
            BTNSelectedNewGroupType.Parent.Parent.BackColor = Color.DimGray
        End If
    End Sub

    Private Sub Panel_EnvolveBTNSelectedNewGroupType_MouseHover(sender As Object, e As EventArgs) Handles Panel_EnvolveBTNSelectedNewGroupType.MouseHover
        BTNSelectNewGroupType.Parent.Parent.BackColor = _colorSelectAndHover
    End Sub

    Private Sub Panel_EnvolveBTNSelectedNewGroupType_MouseLeave(sender As Object, e As EventArgs) Handles Panel_EnvolveBTNSelectedNewGroupType.MouseLeave
        If BTNSelectedNewGroupType.Focused Or BTNSelectNewGroupType.Focused Then
            BTNSelectedNewGroupType.Parent.Parent.BackColor = _colorSelectAndHover
        Else
            BTNSelectedNewGroupType.Parent.Parent.BackColor = Color.DimGray
        End If
    End Sub

    Private Sub BTNSelectedNewGroupType_GotFocus(sender As Object, e As EventArgs) Handles BTNSelectedNewGroupType.GotFocus
        BTNSelectNewGroupType.Parent.Parent.BackColor = _colorSelectAndHover
    End Sub

    Private Sub BTNSelectedNewGroupType_LostFocus(sender As Object, e As EventArgs) Handles BTNSelectedNewGroupType.LostFocus
        BTNSelectNewGroupType.Parent.Parent.BackColor = Color.DimGray

    End Sub

    Private Sub BTNSelectNewGroupType_MouseHover(sender As Object, e As EventArgs) Handles BTNSelectNewGroupType.MouseHover
        BTNSelectNewGroupType.Parent.Parent.BackColor = _colorSelectAndHover

        If TXTNomeDoGrupo.Focused Then
            TXTNomeDoGrupo.Parent.Parent.BackColor = _colorSelectAndHover
        End If

    End Sub
    Private Sub BTNSelectNewGroupType_MouseLeave(sender As Object, e As EventArgs) Handles BTNSelectNewGroupType.MouseLeave
        If BTNSelectedNewGroupType.Focused Or BTNSelectNewGroupType.Focused Then
            BTNSelectNewGroupType.Parent.Parent.BackColor = _colorSelectAndHover
        Else
            BTNSelectNewGroupType.Parent.Parent.BackColor = Color.DimGray
        End If

    End Sub


    Private Sub BTNSelectNewGroupType_GotFocus(sender As Object, e As EventArgs) Handles BTNSelectNewGroupType.GotFocus
        BTNSelectNewGroupType.Parent.Parent.BackColor = _colorSelectAndHover
    End Sub

    Private Sub BTNSelectNewGroupType_LostFocus(sender As Object, e As EventArgs) Handles BTNSelectNewGroupType.LostFocus
        BTNSelectNewGroupType.Parent.Parent.BackColor = Color.DimGray

    End Sub

    Private Sub BTNAddProcesso_Click(sender As Object, e As EventArgs) Handles BTNAddProcesso.Click
        PanelOpcoesDeProcessos.Visible = True
    End Sub

    Private Sub BTN_FechaPanelOpcoesDeProcessos_Click(sender As Object, e As EventArgs) Handles BTN_FechaPanelOpcoesDeProcessos.Click
        PanelOpcoesDeProcessos.Visible = False
    End Sub

    Private Sub BTNExecutarProcessos_MouseHover(sender As Object, e As EventArgs) Handles BTNExecutarProcessos.MouseHover
        BTNExecutarProcessos.FlatAppearance.BorderColor = _colorSelectAndHover

    End Sub

    Private Sub BTNExecutarProcessos_MouseLeave(sender As Object, e As EventArgs) Handles BTNExecutarProcessos.MouseLeave
        If BTNExecutarProcessos.Focused Then
            BTNExecutarProcessos.FlatAppearance.BorderColor = _colorSelectAndHover
        Else
            BTNExecutarProcessos.FlatAppearance.BorderColor = BTNExecutarProcessos.BackColor
        End If

    End Sub

    Private Sub BTNExecutarProcessos_GotFocus(sender As Object, e As EventArgs) Handles BTNExecutarProcessos.GotFocus
        BTNExecutarProcessos.FlatAppearance.BorderColor = _colorSelectAndHover

    End Sub

    Private Sub BTNExecutarProcessos_LostFocus(sender As Object, e As EventArgs) Handles BTNExecutarProcessos.LostFocus
        BTNExecutarProcessos.FlatAppearance.BorderColor = BTNExecutarProcessos.BackColor

    End Sub

    Private Sub BTNPausarProcessos_Click(sender As Object, e As EventArgs) Handles BTNPausarProcessos.Click

    End Sub

    Private Sub BTNPausarProcessos_MouseHover(sender As Object, e As EventArgs) Handles BTNPausarProcessos.MouseHover
        BTNPausarProcessos.FlatAppearance.BorderColor = _colorSelectAndHover

    End Sub

    Private Sub BTNPausarProcessos_MouseLeave(sender As Object, e As EventArgs) Handles BTNPausarProcessos.MouseLeave
        If BTNPausarProcessos.Focused Then
            BTNPausarProcessos.FlatAppearance.BorderColor = _colorSelectAndHover
        Else
            BTNPausarProcessos.FlatAppearance.BorderColor = BTNPausarProcessos.BackColor
        End If

    End Sub

    Private Sub BTNPausarProcessos_GotFocus(sender As Object, e As EventArgs) Handles BTNPausarProcessos.GotFocus
        BTNPausarProcessos.FlatAppearance.BorderColor = _colorSelectAndHover

    End Sub

    Private Sub BTNPausarProcessos_LostFocus(sender As Object, e As EventArgs) Handles BTNPausarProcessos.LostFocus
        BTNPausarProcessos.FlatAppearance.BorderColor = BTNPausarProcessos.BackColor

    End Sub

    Private Sub BTNPararProcessos_Click(sender As Object, e As EventArgs) Handles BTNPararProcessos.Click

    End Sub

    Private Sub BTNPararProcessos_MouseHover(sender As Object, e As EventArgs) Handles BTNPararProcessos.MouseHover
        BTNPararProcessos.FlatAppearance.BorderColor = _colorSelectAndHover

    End Sub

    Private Sub BTNPararProcessos_MouseLeave(sender As Object, e As EventArgs) Handles BTNPararProcessos.MouseLeave
        If BTNPararProcessos.Focused Then
            BTNPararProcessos.FlatAppearance.BorderColor = _colorSelectAndHover
        Else
            BTNPararProcessos.FlatAppearance.BorderColor = BTNPararProcessos.BackColor
        End If
    End Sub

    Private Sub BTNPararProcessos_GotFocus(sender As Object, e As EventArgs) Handles BTNPararProcessos.GotFocus
        BTNPararProcessos.FlatAppearance.BorderColor = _colorSelectAndHover

    End Sub

    Private Sub BTNPararProcessos_LostFocus(sender As Object, e As EventArgs) Handles BTNPararProcessos.LostFocus
        BTNPararProcessos.FlatAppearance.BorderColor = BTNPararProcessos.BackColor

    End Sub

    Private Sub BTN_NovoProcessoCriar_MouseHover(sender As Object, e As EventArgs) Handles BTN_NovoProcessoCriar.MouseHover
        Color_MouseHover(BTN_NovoProcessoCriar)

    End Sub

    Private Sub BTN_NovoProcessoCriar_MouseLeave(sender As Object, e As EventArgs) Handles BTN_NovoProcessoCriar.MouseLeave
        Color_MouseLeave(BTN_NovoProcessoCriar)

    End Sub

    Private Sub BTN_NovoProcessoCriar_GotFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoCriar.GotFocus
        Color_GotFocus(BTN_NovoProcessoCriar)

    End Sub

    Private Sub BTN_NovoProcessoCriar_LostFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoCriar.LostFocus
        Color_LostFocus(BTN_NovoProcessoCriar)

    End Sub

    Private Sub BTN_NovoProcessoRenomear_MouseHover(sender As Object, e As EventArgs) Handles BTN_NovoProcessoRenomear.MouseHover
        Color_MouseHover(BTN_NovoProcessoRenomear)

    End Sub

    Private Sub BTN_NovoProcessoRenomear_MouseLeave(sender As Object, e As EventArgs) Handles BTN_NovoProcessoRenomear.MouseLeave
        Color_MouseLeave(BTN_NovoProcessoRenomear)

    End Sub

    Private Sub BTN_NovoProcessoRenomear_GotFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoRenomear.GotFocus
        Color_GotFocus(BTN_NovoProcessoRenomear)

    End Sub

    Private Sub BTN_NovoProcessoRenomear_LostFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoRenomear.LostFocus
        Color_LostFocus(BTN_NovoProcessoRenomear)

    End Sub

    Private Sub BTN_NovoProcessoMover_MouseHover(sender As Object, e As EventArgs) Handles BTN_NovoProcessoMover.MouseHover
        Color_MouseHover(BTN_NovoProcessoMover)

    End Sub

    Private Sub BTN_NovoProcessoMover_MouseLeave(sender As Object, e As EventArgs) Handles BTN_NovoProcessoMover.MouseLeave
        Color_MouseLeave(BTN_NovoProcessoMover)
    End Sub

    Private Sub BTN_NovoProcessoMover_GotFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoMover.GotFocus
        Color_GotFocus(BTN_NovoProcessoMover)
    End Sub

    Private Sub BTN_NovoProcessoMover_LostFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoMover.LostFocus
        Color_LostFocus(BTN_NovoProcessoMover)

    End Sub

    Private Sub BTN_NovoProcessoCopiar_MouseHover(sender As Object, e As EventArgs) Handles BTN_NovoProcessoCopiar.MouseHover
        Color_MouseHover(BTN_NovoProcessoCopiar)
    End Sub

    Private Sub BTN_NovoProcessoCopiar_MouseLeave(sender As Object, e As EventArgs) Handles BTN_NovoProcessoCopiar.MouseLeave
        Color_MouseLeave(BTN_NovoProcessoCopiar)
    End Sub

    Private Sub BTN_NovoProcessoCopiar_GotFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoCopiar.GotFocus
        Color_GotFocus(BTN_NovoProcessoCopiar)
    End Sub

    Private Sub BTN_NovoProcessoCopiar_LostFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoCopiar.LostFocus
        Color_LostFocus(BTN_NovoProcessoCopiar)
    End Sub

    ' Funções de Mouse hover e focus

    Public Sub Color_MouseHover(obj As Object)
        obj.Parent.BackColor = _colorSelectAndHover
    End Sub

    Private Sub Color_MouseLeave(obj As Object)
        If obj.Focused Then
            obj.Parent.BackColor = _colorSelectAndHover
        Else
            obj.Parent.BackColor = obj.BackColor
        End If
    End Sub

    Private Sub Color_GotFocus(obj As Object)
        obj.Parent.BackColor = _colorSelectAndHover
    End Sub

    Private Sub Color_LostFocus(obj As Object)
        obj.Parent.BackColor = obj.BackColor
    End Sub

    Private Sub Color_LostFocusForColor(obj As Object)
        obj.Parent.BackColor = obj.Parent.Parent.BackColor
    End Sub
    Private Sub BTN_NovoProcessoExcluir_Click(sender As Object, e As EventArgs) Handles BTN_NovoProcessoExcluir.Click

    End Sub

    Private Sub BTN_NovoProcessoExcluir_MouseHover(sender As Object, e As EventArgs) Handles BTN_NovoProcessoExcluir.MouseHover
        Color_MouseHover(BTN_NovoProcessoExcluir)

    End Sub

    Private Sub BTN_NovoProcessoExcluir_MouseLeave(sender As Object, e As EventArgs) Handles BTN_NovoProcessoExcluir.MouseLeave
        Color_MouseLeave(BTN_NovoProcessoExcluir)

    End Sub

    Private Sub BTN_NovoProcessoExcluir_GotFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoExcluir.GotFocus
        Color_GotFocus(BTN_NovoProcessoExcluir)

    End Sub

    Private Sub BTN_NovoProcessoExcluir_LostFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoExcluir.LostFocus
        Color_LostFocus(BTN_NovoProcessoExcluir)

    End Sub

    Private Sub BTN_NovoProcessoGravar_MouseHover(sender As Object, e As EventArgs) Handles BTN_NovoProcessoGravar.MouseHover
        Color_MouseHover(BTN_NovoProcessoGravar)
    End Sub

    Private Sub BTN_NovoProcessoGravar_MouseLeave(sender As Object, e As EventArgs) Handles BTN_NovoProcessoGravar.MouseLeave
        Color_MouseLeave(BTN_NovoProcessoGravar)
    End Sub

    Private Sub BTN_NovoProcessoGravar_GotFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoGravar.GotFocus
        Color_GotFocus(BTN_NovoProcessoGravar)
    End Sub

    Private Sub BTN_NovoProcessoGravar_LostFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoGravar.LostFocus
        Color_LostFocus(BTN_NovoProcessoGravar)
    End Sub

    Private Sub LBLSelectColorNone_Click(sender As Object, e As EventArgs) Handles LBLSelectColorNone.Click

    End Sub

    Private Sub LBLSelectColorNone_MouseHover(sender As Object, e As EventArgs) Handles LBLSelectColorNone.MouseHover
        Color_MouseHover(LBLSelectColorNone)

    End Sub

    Private Sub LBLSelectColorNone_MouseLeave(sender As Object, e As EventArgs) Handles LBLSelectColorNone.MouseLeave
        Color_MouseLeave(LBLSelectColorNone)

    End Sub

    Private Sub LBLSelectColorNone_GotFocus(sender As Object, e As EventArgs) Handles LBLSelectColorNone.GotFocus
        Color_LostFocus(LBLSelectColorNone)

    End Sub

    Private Sub LBLSelectColorNone_LostFocus(sender As Object, e As EventArgs) Handles LBLSelectColorNone.LostFocus
        Color_LostFocus(LBLSelectColorNone)

    End Sub

    Private Sub Panel_SelectColorWrite_MouseHover(sender As Object, e As EventArgs) Handles Panel_SelectColorWhite.MouseHover
        Color_MouseHover(Panel_SelectColorWhite)
    End Sub

    Private Sub Panel_SelectColorWrite_MouseLeave(sender As Object, e As EventArgs) Handles Panel_SelectColorWhite.MouseLeave
        Color_LostFocusForColor(Panel_SelectColorWhite)
    End Sub

    Private Sub Panel_SelectColorWrite_GotFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorWhite.GotFocus
        Color_GotFocus(Panel_SelectColorWhite)
    End Sub

    Private Sub Panel_SelectColorWrite_LostFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorWhite.LostFocus
        Color_LostFocusForColor(Panel_SelectColorWhite)
    End Sub

    Private Sub Panel_SelectColorGray_Paint(sender As Object, e As PaintEventArgs) Handles Panel_SelectColorGray.Paint

    End Sub

    Private Sub Panel_SelectColorGray_MouseHover(sender As Object, e As EventArgs) Handles Panel_SelectColorGray.MouseHover
        Color_MouseHover(Panel_SelectColorGray)
    End Sub

    Private Sub Panel_SelectColorGray_MouseLeave(sender As Object, e As EventArgs) Handles Panel_SelectColorGray.MouseLeave
        Color_LostFocusForColor(Panel_SelectColorGray)
    End Sub

    Private Sub Panel_SelectColorGray_GotFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorGray.GotFocus
        Color_GotFocus(Panel_SelectColorGray)
    End Sub

    Private Sub Panel_SelectColorGray_LostFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorGray.LostFocus
        Color_LostFocusForColor(Panel_SelectColorGray)

    End Sub

    Private Sub Panel_SelectColorBlack_Paint(sender As Object, e As PaintEventArgs) Handles Panel_SelectColorBlack.Paint

    End Sub

    Private Sub Panel_SelectColorBlack_MouseHover(sender As Object, e As EventArgs) Handles Panel_SelectColorBlack.MouseHover
        Color_MouseHover(Panel_SelectColorBlack)

    End Sub

    Private Sub Panel_SelectColorBlack_MouseLeave(sender As Object, e As EventArgs) Handles Panel_SelectColorBlack.MouseLeave
        Color_LostFocusForColor(Panel_SelectColorBlack)

    End Sub

    Private Sub Panel_SelectColorBlack_GotFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorBlack.GotFocus
        Color_GotFocus(Panel_SelectColorBlack)

    End Sub

    Private Sub Panel_SelectColorBlack_LostFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorBlack.LostFocus
        Color_LostFocusForColor(Panel_SelectColorBlack)

    End Sub

    Private Sub Panel_SelectColorYellow_Paint(sender As Object, e As PaintEventArgs) Handles Panel_SelectColorYellow.Paint

    End Sub

    Private Sub Panel_SelectColorYellow_GotFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorYellow.GotFocus
        Color_GotFocus(Panel_SelectColorYellow)

    End Sub

    Private Sub Panel_SelectColorYellow_LostFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorYellow.LostFocus
        Color_LostFocusForColor(Panel_SelectColorYellow)

    End Sub

    Private Sub Panel_SelectColorYellow_MouseHover(sender As Object, e As EventArgs) Handles Panel_SelectColorYellow.MouseHover
        Color_MouseHover(Panel_SelectColorYellow)

    End Sub

    Private Sub Panel_SelectColorYellow_MouseLeave(sender As Object, e As EventArgs) Handles Panel_SelectColorYellow.MouseLeave
        Color_LostFocusForColor(Panel_SelectColorYellow)

    End Sub

    Private Sub Panel_SelectColorOrange_Paint(sender As Object, e As PaintEventArgs) Handles Panel_SelectColorOrange.Paint

    End Sub

    Private Sub Panel_SelectColorOrange_GotFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorOrange.GotFocus
        Color_GotFocus(Panel_SelectColorOrange)
    End Sub

    Private Sub Panel_SelectColorOrange_LostFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorOrange.LostFocus
        Color_LostFocusForColor(Panel_SelectColorOrange)

    End Sub

    Private Sub Panel_SelectColorOrange_MouseHover(sender As Object, e As EventArgs) Handles Panel_SelectColorOrange.MouseHover
        Color_MouseHover(Panel_SelectColorOrange)

    End Sub

    Private Sub Panel_SelectColorOrange_MouseLeave(sender As Object, e As EventArgs) Handles Panel_SelectColorOrange.MouseLeave
        Color_LostFocusForColor(Panel_SelectColorOrange)

    End Sub

    Private Sub Panel_SelectColorRed_Paint(sender As Object, e As PaintEventArgs) Handles Panel_SelectColorRed.Paint

    End Sub

    Private Sub Panel_SelectColorRed_MouseHover(sender As Object, e As EventArgs) Handles Panel_SelectColorRed.MouseHover
        Color_MouseHover(Panel_SelectColorRed)

    End Sub

    Private Sub Panel_SelectColorRed_MouseLeave(sender As Object, e As EventArgs) Handles Panel_SelectColorRed.MouseLeave
        Color_LostFocusForColor(Panel_SelectColorRed)

    End Sub

    Private Sub Panel_SelectColorRed_GotFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorRed.GotFocus
        Color_GotFocus(Panel_SelectColorRed)
    End Sub

    Private Sub Panel_SelectColorRed_LostFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorRed.LostFocus
        Color_LostFocusForColor(Panel_SelectColorRed)

    End Sub

    Private Sub Panel_SelectColorPurple_Paint(sender As Object, e As PaintEventArgs) Handles Panel_SelectColorPurple.Paint

    End Sub

    Private Sub Panel_SelectColorPurple_MouseHover(sender As Object, e As EventArgs) Handles Panel_SelectColorPurple.MouseHover
        Color_MouseHover(Panel_SelectColorPurple)

    End Sub

    Private Sub Panel_SelectColorPurple_MouseLeave(sender As Object, e As EventArgs) Handles Panel_SelectColorPurple.MouseLeave
        Color_LostFocusForColor(Panel_SelectColorPurple)

    End Sub

    Private Sub Panel_SelectColorPurple_GotFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorPurple.GotFocus
        Color_GotFocus(Panel_SelectColorPurple)
    End Sub

    Private Sub Panel_SelectColorPurple_LostFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorPurple.LostFocus
        Color_LostFocusForColor(Panel_SelectColorPurple)

    End Sub

    Private Sub Panel_SelectColorViolet_Paint(sender As Object, e As PaintEventArgs) Handles Panel_SelectColorViolet.Paint

    End Sub

    Private Sub Panel_SelectColorViolet_MouseHover(sender As Object, e As EventArgs) Handles Panel_SelectColorViolet.MouseHover
        Color_MouseHover(Panel_SelectColorViolet)

    End Sub

    Private Sub Panel_SelectColorViolet_MouseLeave(sender As Object, e As EventArgs) Handles Panel_SelectColorViolet.MouseLeave
        Color_LostFocusForColor(Panel_SelectColorViolet)

    End Sub

    Private Sub Panel_SelectColorViolet_GotFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorViolet.GotFocus
        Color_LostFocus(Panel_SelectColorViolet)

    End Sub

    Private Sub Panel_SelectColorViolet_LostFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorViolet.LostFocus
        Color_LostFocusForColor(Panel_SelectColorViolet)

    End Sub

    Private Sub Panel_SelectColorRoyalBlue_Paint(sender As Object, e As PaintEventArgs) Handles Panel_SelectColorRoyalBlue.Paint

    End Sub

    Private Sub Panel_SelectColorRoyalBlue_MouseHover(sender As Object, e As EventArgs) Handles Panel_SelectColorRoyalBlue.MouseHover
        Color_MouseHover(Panel_SelectColorRoyalBlue)

    End Sub

    Private Sub Panel_SelectColorRoyalBlue_MouseLeave(sender As Object, e As EventArgs) Handles Panel_SelectColorRoyalBlue.MouseLeave
        Color_LostFocusForColor(Panel_SelectColorRoyalBlue)
    End Sub

    Private Sub Panel_SelectColorRoyalBlue_GotFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorRoyalBlue.GotFocus
        Color_GotFocus(Panel_SelectColorRoyalBlue)

    End Sub

    Private Sub Panel_SelectColorRoyalBlue_LostFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorRoyalBlue.LostFocus
        Color_LostFocusForColor(Panel_SelectColorRoyalBlue)
    End Sub

    Private Sub Panel_SelectColorBlue_Paint(sender As Object, e As PaintEventArgs) Handles Panel_SelectColorBlue.Paint

    End Sub

    Private Sub Panel_SelectColorBlue_MouseHover(sender As Object, e As EventArgs) Handles Panel_SelectColorBlue.MouseHover
        Color_MouseHover(Panel_SelectColorBlue)

    End Sub

    Private Sub Panel_SelectColorBlue_MouseLeave(sender As Object, e As EventArgs) Handles Panel_SelectColorBlue.MouseLeave
        Color_LostFocusForColor(Panel_SelectColorBlue)
    End Sub

    Private Sub Panel_SelectColorBlue_GotFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorBlue.GotFocus
        Color_GotFocus(Panel_SelectColorBlue)

    End Sub

    Private Sub Panel_SelectColorBlue_LostFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorBlue.LostFocus
        Color_LostFocusForColor(Panel_SelectColorBlue)
    End Sub

    Private Sub Panel_SelectColorDarkGreen_Paint(sender As Object, e As PaintEventArgs) Handles Panel_SelectColorDarkGreen.Paint

    End Sub

    Private Sub Panel_SelectColorDarkGreen_MouseHover(sender As Object, e As EventArgs) Handles Panel_SelectColorDarkGreen.MouseHover
        Color_MouseHover(Panel_SelectColorDarkGreen)

    End Sub

    Private Sub Panel_SelectColorDarkGreen_MouseLeave(sender As Object, e As EventArgs) Handles Panel_SelectColorDarkGreen.MouseLeave
        Color_LostFocusForColor(Panel_SelectColorDarkGreen)

    End Sub

    Private Sub Panel_SelectColorDarkGreen_GotFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorDarkGreen.GotFocus
        Color_GotFocus(Panel_SelectColorDarkGreen)

    End Sub

    Private Sub Panel_SelectColorDarkGreen_LostFocus(sender As Object, e As EventArgs) Handles Panel_SelectColorDarkGreen.LostFocus
        Color_LostFocusForColor(Panel_SelectColorDarkGreen)

    End Sub

    Private Sub CHK_ShowPanelAllProcessosAcoes_MouseHover(sender As Object, e As EventArgs) Handles CHK_ShowPanelAllProcessosAcoes.MouseHover
        Color_MouseHover(CHK_ShowPanelAllProcessosAcoes)

    End Sub

    Private Sub CHK_ShowPanelAllProcessosAcoes_MouseLeave(sender As Object, e As EventArgs) Handles CHK_ShowPanelAllProcessosAcoes.MouseLeave
        If CHK_ShowPanelAllProcessosAcoes.CheckState = False Then
            Color_MouseLeave(CHK_ShowPanelAllProcessosAcoes)
        End If
    End Sub

    Private Sub CHK_ShowPanelAllProcessosAcoes_GotFocus(sender As Object, e As EventArgs) Handles CHK_ShowPanelAllProcessosAcoes.GotFocus
        Color_GotFocus(CHK_ShowPanelAllProcessosAcoes)

    End Sub

    Private Sub BTN_NewFolder_Click(sender As Object, e As EventArgs) Handles BTN_NewFolder.Click

    End Sub

    Private Sub BTN_NewFolder_GotFocus(sender As Object, e As EventArgs) Handles BTN_NewFolder.GotFocus
        Color_GotFocus(BTN_NewFolder)

    End Sub

    Private Sub BTN_NewFolder_LostFocus(sender As Object, e As EventArgs) Handles BTN_NewFolder.LostFocus
        Color_LostFocus(BTN_NewFolder)

    End Sub

    Private Sub BTN_NewFolder_MouseHover(sender As Object, e As EventArgs) Handles BTN_NewFolder.MouseHover
        Color_MouseHover(BTN_NewFolder)

    End Sub

    Private Sub BTN_NewFolder_MouseLeave(sender As Object, e As EventArgs) Handles BTN_NewFolder.MouseLeave
        Color_MouseLeave(BTN_NewFolder)

    End Sub

    Private Sub BTN_TimeParaAgrupamentos_Click(sender As Object, e As EventArgs) Handles BTN_TimeParaAgrupamentos.Click

    End Sub

    Private Sub BTN_TimeParaAgrupamentos_GotFocus(sender As Object, e As EventArgs) Handles BTN_TimeParaAgrupamentos.GotFocus
        Color_GotFocus(BTN_TimeParaAgrupamentos)

    End Sub

    Private Sub BTN_TimeParaAgrupamentos_LostFocus(sender As Object, e As EventArgs) Handles BTN_TimeParaAgrupamentos.LostFocus
        Color_LostFocus(BTN_TimeParaAgrupamentos)

    End Sub

    Private Sub BTN_TimeParaAgrupamentos_MouseHover(sender As Object, e As EventArgs) Handles BTN_TimeParaAgrupamentos.MouseHover
        Color_MouseHover(BTN_TimeParaAgrupamentos)

    End Sub

    Private Sub BTN_TimeParaAgrupamentos_MouseLeave(sender As Object, e As EventArgs) Handles BTN_TimeParaAgrupamentos.MouseLeave
        Color_MouseLeave(BTN_TimeParaAgrupamentos)

    End Sub

    Private Sub CHK_ShowPanelAllProcessosAcoes_LostFocus(sender As Object, e As EventArgs) Handles CHK_ShowPanelAllProcessosAcoes.LostFocus
        If CHK_ShowPanelAllProcessosAcoes.Checked = False Then
            Color_LostFocus(CHK_ShowPanelAllProcessosAcoes)
        End If

    End Sub

End Class
