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
        '  class_Configs.Color_MouseLeave(TXTName, TXTName.Parent.Parent)
        PanelNameAndExtencao_MouseLeave()


    End Sub

    Private Sub TXTName_GotFocus(sender As Object, e As EventArgs) Handles TXTName.GotFocus
        class_Configs.Color_GotFocus(TXTName, TXTName.Parent.Parent)
        TXTName.ForeColor = Color.Gainsboro

    End Sub

    Private Sub TXTName_LostFocus(sender As Object, e As EventArgs) Handles TXTName.LostFocus
        class_Configs.Color_LostFocus(TXTName, TXTName.Parent.Parent)
        TXTName.Cursor = Cursors.Default
        TXTName.ForeColor = Color.DarkGray


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
        '  class_Configs.Color_MouseLeave(BTN_TXTName, BTN_TXTName.Parent.Parent)
        PanelNameAndExtencao_MouseLeave()
    End Sub

    Private Sub TXTExetencao_TextChanged(sender As Object, e As EventArgs) Handles TXTExetencao.TextChanged

    End Sub

    Private Sub TXTExetencao_MouseHover(sender As Object, e As EventArgs) Handles TXTExetencao.MouseHover
        PanelNameAndExtencao.BackColor = _colorSelectAndHover

    End Sub

    Private Sub TXTExetencao_MouseLeave(sender As Object, e As EventArgs) Handles TXTExetencao.MouseLeave
        PanelNameAndExtencao_MouseLeave()

    End Sub

    Private Sub TXTExetencao_GotFocus(sender As Object, e As EventArgs) Handles TXTExetencao.GotFocus
        PanelNameAndExtencao.BackColor = _colorSelectAndHover
        TXTExetencao.ForeColor = Color.Gainsboro

    End Sub

    Private Sub TXTExetencao_LostFocus(sender As Object, e As EventArgs) Handles TXTExetencao.LostFocus
        ' class_Configs.Color_LostFocus(TXTExetencao, PanelNameAndExtencao)
        TXTExetencao.Cursor = Cursors.Default
        PanelNameAndExtencao_MouseLeave()
        TXTExetencao.ForeColor = Color.DarkGray

    End Sub

    Private Sub BTN_TXTExetencao_GotFocus(sender As Object, e As EventArgs) Handles BTN_TXTExetencao.GotFocus
        PanelNameAndExtencao.BackColor = _colorSelectAndHover

    End Sub

    Private Sub BTN_TXTExetencao_LostFocus(sender As Object, e As EventArgs) Handles BTN_TXTExetencao.LostFocus
        PanelNameAndExtencao.BackColor = _colorNotSelectAndHover

    End Sub

    Private Sub BTN_TXTExetencao_MouseLeave(sender As Object, e As EventArgs) Handles BTN_TXTExetencao.MouseLeave
        PanelNameAndExtencao_MouseLeave()
    End Sub

    Private Sub BTN_TXTExetencao_MouseHover(sender As Object, e As EventArgs) Handles BTN_TXTExetencao.MouseHover
        PanelNameAndExtencao.BackColor = _colorSelectAndHover


    End Sub

    Sub PanelNameAndExtencao_MouseLeave()
        If TXTExetencao.Focused = True Or BTN_TXTExetencao.Focused = True Or TXTName.Focused = True Or BTN_TXTName.Focused = True Then
            PanelNameAndExtencao.BackColor = _colorSelectAndHover
        Else
            PanelNameAndExtencao.BackColor = _colorNotSelectAndHover
        End If
    End Sub

    Sub PanelPath_MouseLeave()
        If BTNIconPath.Focused = True Or BTNExpandiPath.Focused = True Or TXTPath.Focused = True Or BTN_TXTPath.Focused = True Then
            PanelBorderPath.BackColor = _colorSelectAndHover
        Else
            PanelBorderPath.BackColor = _colorNotSelectAndHover
        End If
    End Sub

    Private Sub TXTPath_TextChanged(sender As Object, e As EventArgs) Handles TXTPath.TextChanged

    End Sub

    Private Sub TXTPath_MouseHover(sender As Object, e As EventArgs) Handles TXTPath.MouseHover
        PanelBorderPath.BackColor = _colorSelectAndHover
        TXTPath.ForeColor = Color.DarkGray

    End Sub

    Private Sub TXTPath_MouseLeave(sender As Object, e As EventArgs) Handles TXTPath.MouseLeave
        '  class_Configs.Color_MouseLeave(BTN_TXTPath, PanelBorderPath)
        PanelPath_MouseLeave()

    End Sub

    Private Sub TXTPath_LostFocus(sender As Object, e As EventArgs) Handles TXTPath.LostFocus
        PanelBorderPath.BackColor = _colorNotSelectAndHover
        TXTPath.Cursor = Cursors.Default

    End Sub

    Private Sub TXTPath_GotFocus(sender As Object, e As EventArgs) Handles TXTPath.GotFocus
        PanelBorderPath.BackColor = _colorSelectAndHover
        TXTPath.ForeColor = Color.Gainsboro

    End Sub

    Private Sub BTNIconPath_Click(sender As Object, e As EventArgs) Handles BTNIconPath.Click

    End Sub

    Private Sub BTNIconPath_GotFocus(sender As Object, e As EventArgs) Handles BTNIconPath.GotFocus
        PanelBorderPath.BackColor = _colorSelectAndHover
    End Sub

    Private Sub BTNIconPath_LostFocus(sender As Object, e As EventArgs) Handles BTNIconPath.LostFocus
        PanelBorderPath.BackColor = _colorNotSelectAndHover
    End Sub

    Private Sub BTNIconPath_MouseHover(sender As Object, e As EventArgs) Handles BTNIconPath.MouseHover
        PanelBorderPath.BackColor = _colorSelectAndHover
    End Sub

    Private Sub BTNIconPath_MouseLeave(sender As Object, e As EventArgs) Handles BTNIconPath.MouseLeave
        PanelPath_MouseLeave()
    End Sub

    Private Sub BTNExpandiPath_Click(sender As Object, e As EventArgs) Handles BTNExpandiPath.Click

    End Sub

    Private Sub BTNExpandiPath_GotFocus(sender As Object, e As EventArgs) Handles BTNExpandiPath.GotFocus
        PanelBorderPath.BackColor = _colorSelectAndHover
    End Sub

    Private Sub BTNExpandiPath_LostFocus(sender As Object, e As EventArgs) Handles BTNExpandiPath.LostFocus
        PanelBorderPath.BackColor = _colorNotSelectAndHover
    End Sub

    Private Sub BTNExpandiPath_MouseHover(sender As Object, e As EventArgs) Handles BTNExpandiPath.MouseHover
        PanelBorderPath.BackColor = _colorSelectAndHover
    End Sub

    Private Sub BTNExpandiPath_MouseLeave(sender As Object, e As EventArgs) Handles BTNExpandiPath.MouseLeave
        PanelPath_MouseLeave()

    End Sub

    Private Sub BTN_TXTPath_Click(sender As Object, e As EventArgs) Handles BTN_TXTPath.Click

    End Sub

    Private Sub BTN_TXTPath_GotFocus(sender As Object, e As EventArgs) Handles BTN_TXTPath.GotFocus
        PanelBorderPath.BackColor = _colorSelectAndHover
    End Sub

    Private Sub BTN_TXTPath_LostFocus(sender As Object, e As EventArgs) Handles BTN_TXTPath.LostFocus
        PanelBorderPath.BackColor = _colorNotSelectAndHover
    End Sub

    Private Sub BTN_TXTPath_MouseHover(sender As Object, e As EventArgs) Handles BTN_TXTPath.MouseHover
        PanelBorderPath.BackColor = _colorSelectAndHover
    End Sub

    Private Sub BTN_TXTPath_MouseLeave(sender As Object, e As EventArgs) Handles BTN_TXTPath.MouseLeave
        PanelPath_MouseLeave()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click

    End Sub

    Private Sub PictureBox16_MouseHover(sender As Object, e As EventArgs) Handles PictureBox16.MouseHover
        PanelEnvolveControl.BackColor = _colorSelectAndHover

    End Sub

    Private Sub PictureBox16_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox16.MouseLeave
        PanelEnvolveControl.BackColor = _colorNotSelectAndHover

    End Sub

    Private Sub TXTPath_Click(sender As Object, e As EventArgs) Handles TXTPath.Click
        TXTPath.Cursor = Cursors.IBeam

    End Sub

    Private Sub TXTName_TextChanged(sender As Object, e As EventArgs) Handles TXTName.TextChanged

    End Sub

    Private Sub TXTName_Click(sender As Object, e As EventArgs) Handles TXTName.Click
        TXTName.Cursor = Cursors.IBeam
    End Sub

    Private Sub TXTExetencao_Click(sender As Object, e As EventArgs) Handles TXTExetencao.Click
        TXTExetencao.Cursor = Cursors.IBeam
    End Sub
End Class
