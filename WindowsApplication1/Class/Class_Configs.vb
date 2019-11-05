Imports System.Drawing

Public Class Class_Configs
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

    Public Sub Color_MouseLeave(obj As Object)
        If obj.Focused = True Then
            obj.Parent.BackColor = _colorSelectAndHover
        Else
            obj.Parent.BackColor = _colorNotSelectAndHover
        End If
    End Sub

    Public Sub Color_GotFocus(obj As Object)
        obj.Parent.BackColor = _colorSelectAndHover
    End Sub

    Public Sub Color_LostFocus(obj As Object)
          obj.Parent.BackColor = ColorNotSelect
    End Sub

    Public Sub Color_LostFocusForColor(obj As Object)
        obj.Parent.BackColor = obj.Parent.Parent.BackColor
    End Sub
End Class
