Public Class ControlItenDePasta
    Public IconeList As New ControlListIcone
    Dim NumeroDeItens As Integer


    Private Sub ControlItenDePasta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FLPanelItens.BackColor = Me.BackColor
        NumeroDeItens = 10
        For X = 0 To NumeroDeItens
            IconeList = New ControlListIcone
            FLPanelItens.Controls.Add(IconeList)
            FLPanelItens.Visible = True

            IconeList.LBL_EtiquetaTitolo.Text = IconeList.LBL_EtiquetaTitolo.Text & " " & X

        Next

    End Sub

    Private Sub FLPanelItens_Paint(sender As Object, e As PaintEventArgs) Handles FLPanelItens.Paint

    End Sub
End Class
