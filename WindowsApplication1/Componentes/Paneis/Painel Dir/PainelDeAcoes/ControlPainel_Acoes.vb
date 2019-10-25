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
End Class
