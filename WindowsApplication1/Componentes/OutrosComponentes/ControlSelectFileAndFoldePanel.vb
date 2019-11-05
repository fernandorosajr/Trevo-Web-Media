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
        class_Configs.Color_MouseLeave(TXTName.Parent)
        ' TXTName.Parent.Parent.BackColor = Color.DimGray

    End Sub

    Private Sub TXTName_GotFocus(sender As Object, e As EventArgs) Handles TXTName.GotFocus
        class_Configs.Color_GotFocus(TXTName.Parent)

    End Sub

    Private Sub TXTName_LostFocus(sender As Object, e As EventArgs) Handles TXTName.LostFocus
        class_Configs.Color_LostFocus(TXTName.Parent)
        ' TXTName.Parent.Parent.BackColor = Color.DimGray
    End Sub

    Private Sub PanelName_MouseHover(sender As Object, e As EventArgs) Handles PanelName.MouseHover
        class_Configs.Color_MouseHover(PanelName)
    End Sub

    Private Sub PanelName_MouseLeave(sender As Object, e As EventArgs) Handles PanelName.MouseLeave
        class_Configs.Color_MouseLeave(PanelName)
        'PanelName.Parent.BackColor = Color.DimGray
    End Sub

    Private Sub PanelName_GotFocus(sender As Object, e As EventArgs) Handles PanelName.GotFocus
        class_Configs.Color_GotFocus(PanelName)

    End Sub

    Private Sub PanelName_LostFocus(sender As Object, e As EventArgs) Handles PanelName.LostFocus
        class_Configs.Color_LostFocus(PanelName)
        'PanelName.Parent.BackColor = Color.DimGray
    End Sub


End Class
