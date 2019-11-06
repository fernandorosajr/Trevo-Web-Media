Public Class ControlSelectFileAndFoldePanel

    Private class_Configs As New Class_Configs
    Private _colorSelectAndHover As New Color
    Private _colorNotSelectAndHover As New Color


    Private Sub ControlSelectFileAndFoldePanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        _colorSelectAndHover = class_Configs.ColorSelect
        _colorNotSelectAndHover = class_Configs.ColorNotSelect

    End Sub


    Private Sub TXTName_MouseHover(sender As Object, e As EventArgs) Handles TXTName.MouseHover
        class_Configs.Color_MouseHover(TXTName.Parent)
    End Sub

    Private Sub TXTName_MouseLeave(sender As Object, e As EventArgs) Handles TXTName.MouseLeave
        class_Configs.Color_MouseLeave(TXTName, TXTName.Parent.Parent)
        ' TXTName.Parent.Parent.BackColor = Color.DimGray

    End Sub

    Private Sub TXTName_GotFocus(sender As Object, e As EventArgs) Handles TXTName.GotFocus
        class_Configs.Color_GotFocus(TXTName, TXTName.Parent.Parent)

    End Sub

    Private Sub TXTName_LostFocus(sender As Object, e As EventArgs) Handles TXTName.LostFocus
        class_Configs.Color_LostFocus(TXTName, TXTName.Parent.Parent)
        ' TXTName.Parent.Parent.BackColor = Color.DimGray
    End Sub

    Private Sub BTN_TXTName_Click(sender As Object, e As EventArgs) Handles BTN_TXTName.Click

    End Sub

    Private Sub BTN_TXTName_GotFocus(sender As Object, e As EventArgs) Handles BTN_TXTName.GotFocus
        class_Configs.Color_GotFocus(BTN_TXTName, BTN_TXTName.Parent.Parent)

    End Sub

    Private Sub BTN_TXTName_LostFocus(sender As Object, e As EventArgs) Handles BTN_TXTName.LostFocus
        class_Configs.Color_LostFocus(BTN_TXTName, BTN_TXTName.Parent.Parent)
    End Sub

    Private Sub BTN_TXTName_MouseHover(sender As Object, e As EventArgs) Handles BTN_TXTName.MouseHover
        class_Configs.Color_MouseHover(BTN_TXTName.Parent)
    End Sub

    Private Sub BTN_TXTName_MouseLeave(sender As Object, e As EventArgs) Handles BTN_TXTName.MouseLeave
        class_Configs.Color_MouseLeave(BTN_TXTName, BTN_TXTName.Parent.Parent)

    End Sub
End Class
