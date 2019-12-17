Public Class Control_OrganizeMenuBar
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


    Private _borderColorSelectAndMouseOver As Color

    Public Property BorderColorSelectAndMouseHover As Color
        Get
            Return _borderColorSelectAndMouseOver
        End Get

        Set(value As Color)
            _borderColorSelectAndMouseOver = value

        End Set
    End Property

    Private _backgroundColorSelectAndMouseOver As Color

    Public Property BackgroundColorSelectAndMouseHover As Color
        Get
            Return _backgroundColorSelectAndMouseOver
        End Get

        Set(value As Color)
            _backgroundColorSelectAndMouseOver = value

        End Set
    End Property

    Private _statusGravandoMedia As Boolean
    Public Property StatusGravandoMidia As Boolean
        Get
            Return _statusGravandoMedia

        End Get

        Set(value As Boolean)
            _statusGravandoMedia = value
        End Set
    End Property

    Private Sub Control_OrganizeMenuBar_Load(sender As Object, e As EventArgs) Handles Me.Load
        _borderColorChecked = Color.RoyalBlue
        _backgroundColorChecked = Color.LightSkyBlue

        _borderColorSelectAndMouseOver = Color.SkyBlue ' Color.FromArgb(120, 126, 184, 239) 
        _backgroundColorSelectAndMouseOver = Color.LightCyan 'Color.FromArgb(120, 255, 255, 255) 
        '   126,184,239,0.8)

        _borderColorSelectAndMouseLeave = Color.WhiteSmoke
        _backgroundColorSelectAndMouseLeave = Color.WhiteSmoke

        _borderColorSelectAndMouseDown = Color.CornflowerBlue
        _backgroundColorSelectAndMouseDown = Color.PowderBlue

        _borderColorSelectAndMouseUp = _borderColorSelectAndMouseOver
        _backgroundColorSelectAndMouseUp = _backgroundColorSelectAndMouseOver
    End Sub

    Private Sub Buttons_MouseDown(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNProcurarDuplicados.MouseDown, BTNProcurarDuplicados.MouseDown, BTNRenomearEmLotes.MouseDown, BTNOpcoes_BTNRenomearEmLotes.MouseDown, BTNAgruparExibicao.MouseDown, BTNOpcoes_BTNAgruparExibicao.MouseDown, BTNCompararPastas.MouseDown, BTNOpcoes_BTNCompararPastas.MouseDown
        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.BackColor = _backgroundColorSelectAndMouseDown
        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseDown
        btn.FlatAppearance.MouseDownBackColor = _backgroundColorSelectAndMouseDown

        Select Case btn.Name
            Case "BTNOpcoes_BTNAbortar"
                ' BTNAbortar.b

            Case "BTNAbortar"
                ' BTNAbortar.b

            Case "BTNOpcoes_BTNMaisProcessos"
                ' BTNAbortar.b

            Case "BTNMaisProcessos"
                ' BTNAbortar.b

        End Select

    End Sub

    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNProcurarDuplicados.MouseLeave, BTNProcurarDuplicados.MouseLeave, BTNRenomearEmLotes.MouseLeave, BTNOpcoes_BTNRenomearEmLotes.MouseLeave, BTNAgruparExibicao.MouseLeave, BTNOpcoes_BTNAgruparExibicao.MouseLeave, BTNCompararPastas.MouseLeave, BTNOpcoes_BTNCompararPastas.MouseLeave

        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.BackColor = _backgroundColorSelectAndMouseLeave
        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseLeave
        ' btn.FlatAppearance.MouseDownBackColor = _backgroundColorSelectAndMouseDown

    End Sub

    Private Sub Buttons_MouseMove(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNProcurarDuplicados.MouseMove, BTNProcurarDuplicados.MouseMove, BTNRenomearEmLotes.MouseMove, BTNOpcoes_BTNRenomearEmLotes.MouseMove, BTNAgruparExibicao.MouseMove, BTNOpcoes_BTNAgruparExibicao.MouseMove, BTNCompararPastas.MouseMove, BTNOpcoes_BTNCompararPastas.MouseMove

        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.BackColor = _backgroundColorSelectAndMouseOver
        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseOver
        btn.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseOver
    End Sub

    Private Sub Buttons_MouseOver(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNProcurarDuplicados.MouseHover, BTNProcurarDuplicados.MouseHover, BTNRenomearEmLotes.MouseHover, BTNOpcoes_BTNRenomearEmLotes.MouseHover, BTNAgruparExibicao.MouseHover, BTNOpcoes_BTNAgruparExibicao.MouseHover, BTNCompararPastas.MouseHover, BTNOpcoes_BTNCompararPastas.MouseHover

        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.BackColor = _backgroundColorSelectAndMouseOver
        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseOver
        btn.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseOver

    End Sub


End Class
