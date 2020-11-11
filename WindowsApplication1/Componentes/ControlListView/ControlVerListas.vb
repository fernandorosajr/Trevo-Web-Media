Public Class ControlVerListas
    Public ControlIDePasta As New ControlItenDePasta



    Private Sub ControlVerListas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim NumeroDeItens As Integer

        NumeroDeItens = 5


        AdcionarItemDePasta(NumeroDeItens)

    End Sub

    Sub AdcionarItemDePasta(Quant As Integer)
        For x = 0 To Quant
            ControlIDePasta = New ControlItenDePasta
            FLPanelRecebe.Controls.Add(ControlIDePasta)
            ControlIDePasta.Width = ControlIDePasta.Parent.Width
            ControlIDePasta.Visible = True
        Next
    End Sub

    Private Sub FLPanelRecebe_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles FLPanelRecebe.Paint

    End Sub

    Private Sub ControlVerListas_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

    End Sub

    Private Sub ControlVerListas_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim Controle As ControlItenDePasta

        For X = 1 To FLPanelRecebe.Controls.Count
            Controle = FLPanelRecebe.Controls(X - 1)
            Controle.Width = Controle.Parent.Width - 20

        Next
    End Sub

    Private Sub ControlVerListas_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged

    End Sub
End Class
