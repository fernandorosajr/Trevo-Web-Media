Public Class ControlPainel_Atividades
    Dim Item_Infor As New Control_Infor


    Private Sub ControlPainel_Atividades_Load(sender As Object, e As EventArgs) Handles Me.Load
        For x = 0 To 5
            Item_Infor = New Control_Infor
            PanelLoad_ControlInfor.Controls.Add(Item_Infor)
            Item_Infor.Name = "Item_Infor" & x
            Item_Infor.Visible = True
            Item_Infor.Dock = DockStyle.Top

        Next


    End Sub
End Class
