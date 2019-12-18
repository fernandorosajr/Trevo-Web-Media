Public Class ControlPainel_Filtro
    Private Sub BTNLBLTitle_Click(sender As Object, e As EventArgs) Handles BTNLBLTitle.Click, LBLTitle.DoubleClick

        Try
            If Panel_Filtro.AutoSize = False Then

                BTNLBLTitle.Image = My.Resources.seta
                Panel_Filtro.AutoSize = True
                PanelMargin.AutoSize = True
                Panel_Border.AutoSize = True
                Me.AutoSize = True
                Me.Parent.AutoSize = True
                '  Panel_Explorer_Prima.Dock = DockStyle.Top
                Me.Dock = DockStyle.Top
                Panel_Explorer_Prima.Visible = False

            Else

                BTNLBLTitle.Image = My.Resources.seta_para_baixo
                Panel_Filtro.AutoSize = False
                PanelMargin.AutoSize = False
                Panel_Border.AutoSize = False
                Me.AutoSize = False
                Me.Parent.AutoSize = False
                Me.Dock = DockStyle.Fill
                '  Panel_Explorer_Prima.Dock = DockStyle.Fill
                Panel_Explorer_Prima.Visible = True

            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ControlPainel_Filtro_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Panel_Filtro.AutoSize = True Then

            BTNLBLTitle.Image = My.Resources.seta

        Else
            BTNLBLTitle.Image = My.Resources.seta_para_baixo

        End If

    End Sub
End Class
