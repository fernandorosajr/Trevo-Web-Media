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
        '  MsgBox(ColorSelect.ToString)

        _colorSelectAndHover = SystemColors.HotTrack
        '  ColorSelect = SystemColors.HotTrack
        '   BTNAddProcesso.BackColor = ColorSelect
        '  MsgBox(ColorSelect.ToString)
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

    Private Sub TXTNomeDoGrupo_MouseClick(sender As Object, e As MouseEventArgs) Handles TXTNomeDoGrupo.MouseClick
        'If TXTNomeDoGrupo.SelectedText <> TXTNomeDoGrupo.Text Then
        '    TXTNomeDoGrupo.SelectAll()
        'End If
    End Sub

    Private Sub LBLNomeDoGrupo_Click(sender As Object, e As EventArgs) Handles LBLNomeDoGrupo.Click
        TXTNomeDoGrupo.Focus()

    End Sub

    Private Sub PanelFundoDoNomeDoGrupo_MouseHover(sender As Object, e As EventArgs) Handles PanelFundoDoNomeDoGrupo.MouseHover
        TXTNomeDoGrupo.Parent.Parent.BackColor = _colorSelectAndHover
    End Sub

    Private Sub PanelFundoDoNomeDoGrupo_MouseLeave(sender As Object, e As EventArgs) Handles PanelFundoDoNomeDoGrupo.MouseLeave
        'PanelFundoDoNomeDoGrupo.Parent.BackColor = Color.DimGray
    End Sub


    Private Sub BTNSelectedNewGroupType_MouseHover(sender As Object, e As EventArgs) Handles BTNSelectedNewGroupType.MouseHover
        BTNSelectedNewGroupType.Parent.Parent.BackColor = _colorSelectAndHover

        If TXTNomeDoGrupo.Focused Then
            TXTNomeDoGrupo.Parent.Parent.BackColor = _colorSelectAndHover
        End If

    End Sub

    Private Sub BTNSelectedNewGroupType_MouseLeave(sender As Object, e As EventArgs) Handles BTNSelectedNewGroupType.MouseLeave
        ' BTNSelectedNewGroupType.Parent.Parent.BackColor = Color.DimGray
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
        Color_GotoFocus(BTN_NovoProcessoCriar)

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
        Color_GotoFocus(BTN_NovoProcessoRenomear)

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
        Color_GotoFocus(BTN_NovoProcessoMover)
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
        Color_GotoFocus(BTN_NovoProcessoCopiar)
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

    Private Sub Color_GotoFocus(obj As Object)
        obj.Parent.BackColor = _colorSelectAndHover
    End Sub

    Private Sub Color_LostFocus(obj As Object)
        obj.Parent.BackColor = obj.BackColor
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
        Color_GotoFocus(BTN_NovoProcessoExcluir)

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
        Color_GotoFocus(BTN_NovoProcessoGravar)
    End Sub

    Private Sub BTN_NovoProcessoGravar_LostFocus(sender As Object, e As EventArgs) Handles BTN_NovoProcessoGravar.LostFocus
        Color_LostFocus(BTN_NovoProcessoGravar)
    End Sub

End Class
