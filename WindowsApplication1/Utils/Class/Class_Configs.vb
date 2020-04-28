Imports System.Drawing


Public Class Class_Configs

    Public myColor As Color = Color.Green
    Public iColor As Integer = myColor.ToArgb()
    Public sColor As String = iColor.ToString

    Public cor As Color = ColorTranslator.FromWin32(CInt(Color.Aqua.ToArgb))

    Public Structure TrevoSystemColor
        Public _borderColorGotFocus As Color  '= SystemColors.HotTrack
        Public _borderColorLostFocus As Color 'BTNMesclar.BackColor ' Me.BackColor 
        Public _backColorCursorMouseLeave As Color ' Color.FromArgb(45, 45, 48)
        Public _borderColorError As Color  ' = Color.Red
        Public _txtBoxBackColorLostFocus As Color '= Color.FromArgb(63, 63, 66)
        Public _bgColorLostFocus As Color '= Me.BackColor
    End Structure

    Public ColorBiblio As TrevoSystemColorEnum
    Public Enum TrevoSystemColorEnum
        _borderColorGotFocus = 13395456 '= SystemColors.HotTrack
        _borderColorLostFocus = 5657427 'BTNMesclar.BackColor ' Me.BackColor 
        _backColorCursorMouseLeave = 3157293 ' Color.FromArgb(45, 45, 48)
        _borderColorError = 255  ' = Color.Red
        _txtBoxBackColorLostFocus = 4341567  '= Color.FromArgb(63, 63, 66)
        _bgColorLostFocus = 4341567 '= Me.BackColor
        _foreColorActive = 11119017
        _foreColorPlaceholder = 8421504
    End Enum

    Public _TrevoSystemColor As TrevoSystemColor

    Public ColorSelect As Color
    Public ColorNotSelect As Color

    Private _colorSelectAndHover As Color
    Private _colorNotSelectAndHover As Color

    Public Property ColorSelectAndHover As Color
        Get
            Return _colorSelectAndHover

        End Get
        Set(value As Color)
            _colorSelectAndHover = value
        End Set

    End Property

    Public Property ColorNotSelectAndHover As Color
        Get
            Return _colorNotSelectAndHover
        End Get
        Set(value As Color)
            _colorNotSelectAndHover = value

        End Set
    End Property

    Public Sub New()

        ' Inicializa as propriedades de cores padrão
        ColorSelect = SystemColors.HotTrack
        _colorSelectAndHover = ColorSelect

        ColorNotSelect = Color.DimGray
        _colorNotSelectAndHover = ColorNotSelect

    End Sub

    ' Eventos do de comportamentos dos Controles quando interagem com o mouse ...
    ' ... ganha e recebe foco.

    Public Sub Color_MouseHover(obj As Object)
        obj.Parent.BackColor = _colorSelectAndHover
    End Sub

    Public Sub Color_MouseLeave(obj As Object, objMargin As Object)
        If obj.Focused = True Then
            objMargin.BackColor = _colorSelectAndHover
        Else
            objMargin.BackColor = _colorNotSelectAndHover
        End If
    End Sub

    Public Sub Color_GotFocus(obj As Object, objMargin As Object)
        objMargin.BackColor = _colorSelectAndHover
    End Sub

    Public Sub Color_LostFocus(obj As Object, objMargin As Object)
        objMargin.BackColor = ColorNotSelect
    End Sub

    Public Sub Color_LostFocusForColor(obj As Object)
        obj.Parent.BackColor = obj.Parent.Parent.BackColor
    End Sub
End Class
