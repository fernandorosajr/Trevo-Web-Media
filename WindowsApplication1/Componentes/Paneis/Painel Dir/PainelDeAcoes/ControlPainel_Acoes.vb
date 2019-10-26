Imports System.Drawing
Public Class ControlPainel_Acoes
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
        TXTNomeDoGrupo.Parent.Parent.BackColor = SystemColors.HotTrack
    End Sub

    Private Sub TXTNomeDoGrupo_MouseLeave(sender As Object, e As EventArgs) Handles TXTNomeDoGrupo.MouseLeave
        TXTNomeDoGrupo.Parent.Parent.BackColor = Color.DimGray
        If TXTNomeDoGrupo.Focused Then
            TXTNomeDoGrupo.Parent.Parent.BackColor = SystemColors.HotTrack
        Else
            TXTNomeDoGrupo.Parent.Parent.BackColor = Color.DimGray
        End If
    End Sub

    Private Sub TXTNomeDoGrupo_GotFocus(sender As Object, e As EventArgs) Handles TXTNomeDoGrupo.GotFocus
        TXTNomeDoGrupo.Parent.Parent.BackColor = SystemColors.HotTrack
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
            TXTNomeDoGrupo.Parent.Parent.BackColor = SystemColors.HotTrack
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
        TXTNomeDoGrupo.Parent.Parent.BackColor = SystemColors.HotTrack
    End Sub

    Private Sub PanelFundoDoNomeDoGrupo_MouseLeave(sender As Object, e As EventArgs) Handles PanelFundoDoNomeDoGrupo.MouseLeave
        Me.Parent.Parent.BackColor = Color.DimGray
    End Sub


    Private Sub BTNSelectedNewGroupType_MouseHover(sender As Object, e As EventArgs) Handles BTNSelectedNewGroupType.MouseHover
        BTNSelectedNewGroupType.Parent.Parent.BackColor = SystemColors.HotTrack

        If TXTNomeDoGrupo.Focused Then
            TXTNomeDoGrupo.Parent.Parent.BackColor = SystemColors.HotTrack
        End If

    End Sub

    Private Sub BTNSelectedNewGroupType_MouseLeave(sender As Object, e As EventArgs) Handles BTNSelectedNewGroupType.MouseLeave
        ' BTNSelectedNewGroupType.Parent.Parent.BackColor = Color.DimGray
        If BTNSelectedNewGroupType.Focused Or BTNSelectNewGroupType.Focused Then
            BTNSelectedNewGroupType.Parent.Parent.BackColor = SystemColors.HotTrack
        Else
            BTNSelectedNewGroupType.Parent.Parent.BackColor = Color.DimGray
        End If
    End Sub

    Private Sub Panel_EnvolveBTNSelectedNewGroupType_MouseHover(sender As Object, e As EventArgs) Handles Panel_EnvolveBTNSelectedNewGroupType.MouseHover
        BTNSelectNewGroupType.Parent.Parent.BackColor = SystemColors.HotTrack
    End Sub

    Private Sub Panel_EnvolveBTNSelectedNewGroupType_MouseLeave(sender As Object, e As EventArgs) Handles Panel_EnvolveBTNSelectedNewGroupType.MouseLeave
        If BTNSelectedNewGroupType.Focused Or BTNSelectNewGroupType.Focused Then
            BTNSelectedNewGroupType.Parent.Parent.BackColor = SystemColors.HotTrack
        Else
            BTNSelectedNewGroupType.Parent.Parent.BackColor = Color.DimGray
        End If
    End Sub

    Private Sub BTNSelectedNewGroupType_GotFocus(sender As Object, e As EventArgs) Handles BTNSelectedNewGroupType.GotFocus
        BTNSelectNewGroupType.Parent.Parent.BackColor = SystemColors.HotTrack
    End Sub

    Private Sub BTNSelectedNewGroupType_LostFocus(sender As Object, e As EventArgs) Handles BTNSelectedNewGroupType.LostFocus
        BTNSelectNewGroupType.Parent.Parent.BackColor = Color.DimGray

    End Sub

    Private Sub BTNSelectNewGroupType_MouseHover(sender As Object, e As EventArgs) Handles BTNSelectNewGroupType.MouseHover
        BTNSelectNewGroupType.Parent.Parent.BackColor = SystemColors.HotTrack

        If TXTNomeDoGrupo.Focused Then
            TXTNomeDoGrupo.Parent.Parent.BackColor = SystemColors.HotTrack
        End If

    End Sub
    Private Sub BTNSelectNewGroupType_MouseLeave(sender As Object, e As EventArgs) Handles BTNSelectNewGroupType.MouseLeave
        If BTNSelectedNewGroupType.Focused Or BTNSelectNewGroupType.Focused Then
            BTNSelectNewGroupType.Parent.Parent.BackColor = SystemColors.HotTrack
        Else
            BTNSelectNewGroupType.Parent.Parent.BackColor = Color.DimGray
        End If

    End Sub


    Private Sub BTNSelectNewGroupType_GotFocus(sender As Object, e As EventArgs) Handles BTNSelectNewGroupType.GotFocus
        BTNSelectNewGroupType.Parent.Parent.BackColor = SystemColors.HotTrack
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
End Class
