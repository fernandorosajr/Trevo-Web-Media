Public Class Control_BurnMenuBar

    ' Propriedades do controle.

    Private _borderColorChecked As Color

    Public Property BorderColorChecked As Color
        Get
            Return _borderColorChecked
        End Get
        Set(value As Color)
            _borderColorChecked = value

        End Set
    End Property

    Private _backgroundColorChecked As Color

    Public Property BackgroundColorChecked As Color
        Get
            Return _backgroundColorChecked

        End Get
        Set(value As Color)
            _backgroundColorChecked = value

        End Set
    End Property


    ' Propriedade da cor de quando o mouse solta o botão.
    Private _borderColorSelectAndMouseUp As Color

    Public Property BorderColorSelectAndMouseUp As Color
        Get
            Return _borderColorSelectAndMouseUp
        End Get
        Set(value As Color)
            _borderColorSelectAndMouseUp = value

        End Set
    End Property

    Private _backgroundColorSelectAndMouseUp As Color

    Public Property BackgroundColorSelectAndMouseUp As Color
        Get
            Return _backgroundColorSelectAndMouseUp

        End Get
        Set(value As Color)
            _backgroundColorSelectAndMouseUp = value

        End Set
    End Property


    Private _borderColorSelectAndMouseDown As Color

    Public Property BorderColorSelectAndMouseDown As Color
        Get
            Return _borderColorSelectAndMouseDown
        End Get
        Set(value As Color)
            _borderColorSelectAndMouseDown = value

        End Set
    End Property

    Private _backgroundColorSelectAndMouseDown As Color

    Public Property BackgroundColorSelectAndMouseDown As Color
        Get
            Return _backgroundColorSelectAndMouseDown
        End Get
        Set(value As Color)
            _backgroundColorSelectAndMouseDown = value

        End Set
    End Property


    Private _borderColorSelectAndMouseLeave As Color

    Public Property BorderColorSelectAndMouseLeave As Color
        Get
            Return _borderColorSelectAndMouseLeave
        End Get
        Set(value As Color)
            _borderColorSelectAndMouseLeave = value

        End Set
    End Property


    Private _backgroundColorSelectAndMouseLeave As Color

    Public Property BackgroundColorSelectAndMouseLeave As Color
        Get
            Return _backgroundColorSelectAndMouseLeave
        End Get
        Set(value As Color)
            _backgroundColorSelectAndMouseLeave = value

        End Set
    End Property


    Private _borderColorSelectAndMouseHover As Color

    Public Property BorderColorSelectAndMouseHover As Color
        Get
            Return _borderColorSelectAndMouseHover
        End Get
        Set(value As Color)
            _borderColorSelectAndMouseHover = value

        End Set
    End Property

    Private _backgroundColorSelectAndMouseHover As Color

    Public Property BackgroundColorSelectAndMouseHover As Color
        Get
            Return _backgroundColorSelectAndMouseHover
        End Get
        Set(value As Color)
            _backgroundColorSelectAndMouseHover = value

        End Set
    End Property

    Private Sub Control_BurnMenuBar_Load(sender As Object, e As EventArgs) Handles Me.Load
        _borderColorChecked = Color.RoyalBlue
        _backgroundColorChecked = Color.LightSkyBlue

        _borderColorSelectAndMouseHover = Color.SkyBlue ' Color.FromArgb(120, 126, 184, 239) 
        _backgroundColorSelectAndMouseHover = Color.LightCyan 'Color.FromArgb(120, 255, 255, 255) 
        '   126,184,239,0.8)

        _borderColorSelectAndMouseLeave = Color.Transparent
        _backgroundColorSelectAndMouseLeave = Color.Transparent

        _borderColorSelectAndMouseDown = Color.CornflowerBlue
        _backgroundColorSelectAndMouseDown = Color.PowderBlue

        _borderColorSelectAndMouseUp = _borderColorSelectAndMouseHover
        _backgroundColorSelectAndMouseUp = _backgroundColorSelectAndMouseHover

    End Sub

    Private Sub Buttons_CheckedChanged(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.CheckedChanged, CKBNovaMidia.CheckedChanged, CKBGravarCriar.CheckedChanged, CKBOpcoes_CKBGravarCriar.CheckedChanged, CKBAbortar.CheckedChanged, CKBOpcoes_CKBAbortar.CheckedChanged

        Dim chk As CheckBox
        chk = CType(sender, CheckBox)

        If chk.Checked = True Then
            chk.Parent.Parent.BackColor = _borderColorChecked
            chk.FlatAppearance.BorderColor = _borderColorChecked
            '  chk.FlatAppearance.BorderSize = 1

        Else
            chk.Parent.Parent.BackColor = _backgroundColorSelectAndMouseLeave
            chk.Parent.BackColor = _borderColorSelectAndMouseLeave
            'Color.Transparent

            chk.FlatAppearance.BorderSize = 0
        End If
        chk.FlatAppearance.CheckedBackColor = _backgroundColorChecked

        Select Case chk.Name
            Case "CKBNovaMidia"
                CKBOpcoes_CKBNovaMidia.Checked = CKBNovaMidia.Checked

            Case "CKBOpcoes_CKBNovaMidia"
                CKBNovaMidia.Checked = CKBOpcoes_CKBNovaMidia.Checked

            Case "CKBGravarCriar"
                CKBOpcoes_CKBGravarCriar.Checked = CKBGravarCriar.Checked

            Case "CKBOpcoes_CKBGravarCriar"
                CKBGravarCriar.Checked = CKBOpcoes_CKBGravarCriar.Checked

            Case "CKBAbortar"
                CKBOpcoes_CKBAbortar.Checked = CKBAbortar.Checked

            Case "CKBOpcoes_CKBAbortar"
                CKBAbortar.Checked = CKBOpcoes_CKBAbortar.Checked


        End Select

    End Sub


End Class
