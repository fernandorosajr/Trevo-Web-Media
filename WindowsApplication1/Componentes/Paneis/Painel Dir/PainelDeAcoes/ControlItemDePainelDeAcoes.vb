Public Class ControlItemDePainelDeAcoes
    Public IconeList As New ControlListIcone
    'Public teste As New ControlItemDePainelDeAcoes

    Private Sub ControlItemDePainelDeAcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Me.Container.Add(Painel_BibliotecaDeMidias)
        IconeList = New ControlListIcone
        PanelEnvolveSubItensDeAcoes.Controls.Add(IconeList)
        IconeList.Dock = DockStyle.Top
        IconeList.Visible = True

    End Sub
End Class
