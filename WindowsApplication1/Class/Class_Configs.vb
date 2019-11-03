Public Class Class_Configs
    Private _colorSelectAndHover As Color

    Public Property ColorSelectAndHover As Color
        Get
            Return _colorSelectAndHover
        End Get
        Set(value As Color)
            _colorSelectAndHover = value

        End Set
    End Property

    Public Sub Color_MouseHover(obj As Object)
        obj.Parent.BackColor = _colorSelectAndHover
    End Sub

    Private Sub Color_MouseLeave(obj As Object)
        If obj.Focused Then
            obj.Parent.BackColor = _colorSelectAndHover
        Else
            obj.Parent.BackColor = obj.BackColor
        End If
    End Sub

    Private Sub Color_GotFocus(obj As Object)
        obj.Parent.BackColor = _colorSelectAndHover
    End Sub

    Private Sub Color_LostFocus(obj As Object)
        obj.Parent.BackColor = obj.BackColor
    End Sub

    Private Sub Color_LostFocusForColor(obj As Object)
        obj.Parent.BackColor = obj.Parent.Parent.BackColor
    End Sub
End Class
