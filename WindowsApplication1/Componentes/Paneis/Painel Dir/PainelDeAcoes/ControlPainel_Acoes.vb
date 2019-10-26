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

    Private Sub TXTNomeDoGrupo_TextChanged(sender As Object, e As EventArgs) Handles TXTNomeDoGrupo.TextChanged

    End Sub

    Private Sub TXTNomeDoGrupo_MouseHover(sender As Object, e As EventArgs) Handles TXTNomeDoGrupo.MouseHover
        TXTNomeDoGrupo.Parent.Parent.BackColor = SystemColors.HotTrack
    End Sub

    Private Sub TXTNomeDoGrupo_MouseLeave(sender As Object, e As EventArgs) Handles TXTNomeDoGrupo.MouseLeave
        TXTNomeDoGrupo.Parent.Parent.BackColor = Color.DimGray
    End Sub

    Private Sub PanelFundoDoNomeDoGrupo_MouseHover(sender As Object, e As EventArgs) Handles PanelFundoDoNomeDoGrupo.MouseHover
        TXTNomeDoGrupo.Parent.Parent.BackColor = SystemColors.HotTrack
    End Sub

    Private Sub PanelFundoDoNomeDoGrupo_MouseLeave(sender As Object, e As EventArgs) Handles PanelFundoDoNomeDoGrupo.MouseLeave
        Me.Parent.Parent.BackColor = Color.DimGray
    End Sub

    Private Sub TXTNomeDoGrupo_GotFocus(sender As Object, e As EventArgs) Handles TXTNomeDoGrupo.GotFocus
        TXTNomeDoGrupo.Parent.Parent.BackColor = SystemColors.HotTrack
        TXTNomeDoGrupo.Cursor = Cursors.IBeam
        ' TXTNomeDoGrupo.SelectAll()
        TXTNomeDoGrupo.SelectionStart = 0
        TXTNomeDoGrupo.SelectionLength = Len(TXTNomeDoGrupo.Text)

    End Sub

    Private Sub TXTNomeDoGrupo_LostFocus(sender As Object, e As EventArgs) Handles TXTNomeDoGrupo.LostFocus
        TXTNomeDoGrupo.Parent.Parent.BackColor = Color.DimGray
        TXTNomeDoGrupo.Cursor = Cursors.Arrow
    End Sub

    Private Sub TXTNomeDoGrupo_MouseClick(sender As Object, e As MouseEventArgs) Handles TXTNomeDoGrupo.MouseClick
        'If TXTNomeDoGrupo.SelectedText <> TXTNomeDoGrupo.Text Then
        '    TXTNomeDoGrupo.SelectAll()
        'End If
    End Sub

End Class
