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

        _borderColorSelectAndMouseLeave = Color.WhiteSmoke
        _backgroundColorSelectAndMouseLeave = Color.WhiteSmoke

        _borderColorSelectAndMouseDown = Color.CornflowerBlue
        _backgroundColorSelectAndMouseDown = Color.PowderBlue

        _borderColorSelectAndMouseUp = _borderColorSelectAndMouseHover
        _backgroundColorSelectAndMouseUp = _backgroundColorSelectAndMouseHover

    End Sub

    Private Sub Buttons_MouseUp(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseUp, CKBNovaMidia.MouseUp, CKBGravarCriar.MouseUp, CKBOpcoes_CKBGravarCriar.MouseUp, CKBAbortar.MouseUp, CKBOpcoes_CKBAbortar.MouseUp, CKBMostrarAgrupamentos.MouseUp, ComBSelectAgrupamento.MouseUp, TXTRotulo.MouseUp, CmBTipoDeMidia.MouseUp, CmBLocalDaMidia.MouseUp, LBL_ComBSelectAgrupamento.MouseUp
        'Ocorre qunado o mouse solta o objeto

        Dim obj As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            obj = CType(sender, CheckBox)
        Else
            obj = CType(sender, Object)
        End If

        obj.Parent.Parent.BackColor = _borderColorSelectAndMouseUp
        obj.Parent.BackColor = _backgroundColorSelectAndMouseUp

        If sender.GetType.Name.ToString = "CheckBox" Then obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseUp


        Select Case obj.Name
            Case "CKBOpcoes_CKBNovaMidia"
                CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBNovaMidia"
                CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBGravarCriar"
                CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBOpcoes_CKBGravarCriar"
                CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBAbortar"
                CKBOpcoes_CKBAbortar.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBOpcoes_CKBAbortar"
                CKBAbortar.BackColor = _backgroundColorSelectAndMouseUp

            Case "ComBSelectAgrupamento"
                PanelBorder_LBL_ComBSelectAgrupamento.BackColor = _borderColorSelectAndMouseUp

        End Select

    End Sub


    Private Sub Buttons_MouseDown(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseDown, CKBNovaMidia.MouseDown, CKBGravarCriar.MouseDown, CKBOpcoes_CKBGravarCriar.MouseDown, CKBAbortar.MouseDown, CKBOpcoes_CKBAbortar.MouseDown, CKBMostrarAgrupamentos.MouseDown, ComBSelectAgrupamento.MouseDown, TXTRotulo.MouseDown, CmBTipoDeMidia.MouseDown, CmBLocalDaMidia.MouseDown, LBL_ComBSelectAgrupamento.MouseDown
        ' Ocorre quando o usuario presciona o botão do mouse

        Dim btn As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            btn = CType(sender, CheckBox)
        Else
            btn = CType(sender, Object)
        End If


        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseDown
        btn.Parent.BackColor = _backgroundColorSelectAndMouseDown
        If sender.GetType.Name.ToString = "CheckBox" Then btn.FlatAppearance.MouseDownBackColor = _backgroundColorSelectAndMouseDown


        Select Case btn.Name

            Case "CKBNovaMidia"
                CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBOpcoes_CKBNovaMidia"
                CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBOpcoes_CKBGravarCriar"
                CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBGravarCriar"
                CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBOpcoes_CKBAbortar"
                CKBAbortar.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBAbortar"
                CKBOpcoes_CKBAbortar.BackColor = _backgroundColorSelectAndMouseDown


        End Select

    End Sub


    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseLeave, CKBNovaMidia.MouseLeave, CKBGravarCriar.MouseLeave, CKBOpcoes_CKBGravarCriar.MouseLeave, CKBAbortar.MouseLeave, CKBOpcoes_CKBAbortar.MouseLeave, CKBMostrarAgrupamentos.MouseLeave, ComBSelectAgrupamento.MouseLeave, TXTRotulo.MouseLeave, CmBTipoDeMidia.MouseLeave, CmBLocalDaMidia.MouseLeave, LBL_ComBSelectAgrupamento.MouseLeave

        ' Ocorre quando o mouse sai do objeto
        Dim obj As Object

        Select Case sender.GetType.Name.ToString
            Case "CheckBox"
                obj = CType(sender, CheckBox)

                If obj.Checked = True Then

                    obj.Parent.Parent.BackColor = _borderColorChecked
                    obj.Parent.BackColor = _backgroundColorChecked
                    obj.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

                Else

                    obj.Parent.Parent.BackColor = _borderColorSelectAndMouseLeave
                    obj.Parent.BackColor = _backgroundColorSelectAndMouseLeave

                End If

            Case "ComboBox"
                obj = CType(sender, ComboBox)
                obj.parent.parent.backcolor = Color.LightGray

            Case "TextBox"
                obj = CType(sender, TextBox)
                obj.parent.parent.backcolor = Color.LightGray

            Case "Label"
                obj = CType(sender, Label)

                obj.parent.parent.backcolor = Color.LightGray
                obj.Parent.BackColor = _backgroundColorSelectAndMouseLeave

            Case Else

                obj = CType(sender, Object)

                obj.Parent.Parent.BackColor = _borderColorSelectAndMouseLeave
                obj.Parent.BackColor = _backgroundColorSelectAndMouseLeave

        End Select


        Select Case obj.Name
            Case "CKBNovaMidia"
                CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBOpcoes_CKBNovaMidia"
                CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBOpcoes_CKBGravarCriar"
                CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBGravarCriar"
                CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBOpcoes_CKBAbortar"
                CKBAbortar.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBAbortar"
                CKBOpcoes_CKBAbortar.BackColor = _backgroundColorSelectAndMouseLeave

        End Select
    End Sub


    Private Sub Buttons_MouseMove(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseMove, CKBNovaMidia.MouseMove, CKBGravarCriar.MouseMove, CKBOpcoes_CKBGravarCriar.MouseMove, CKBAbortar.MouseMove, CKBOpcoes_CKBAbortar.MouseMove, CKBMostrarAgrupamentos.MouseMove, ComBSelectAgrupamento.MouseMove, TXTRotulo.MouseMove, CmBTipoDeMidia.MouseMove, CmBLocalDaMidia.MouseMove, LBL_ComBSelectAgrupamento.MouseMove

        ' Ocorre quando o mouse passa por cima do elemento
        Dim obj As Object

        If sender.GetType.Name.ToString = "CheckBox" Then
            obj = CType(sender, CheckBox)

            If obj.Checked = True Then

                obj.Parent.Parent.BackColor = _borderColorChecked
                obj.Parent.BackColor = _backgroundColorChecked
                obj.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

            Else

                obj.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
                obj.Parent.BackColor = _backgroundColorSelectAndMouseHover
                obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover

            End If
        Else
            obj = CType(sender, Object)

            obj.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
            obj.Parent.BackColor = _backgroundColorSelectAndMouseHover
            '   obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover

        End If



        Select Case obj.Name
            Case "CKBNovaMidia"
                CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBNovaMidia"
                CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBGravarCriar"
                CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBGravarCriar"
                CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBAbortar"
                CKBAbortar.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBAbortar"
                CKBOpcoes_CKBAbortar.BackColor = _backgroundColorSelectAndMouseHover


        End Select
    End Sub

    Private Sub Buttons_MouseHover(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseHover, CKBNovaMidia.MouseHover, CKBGravarCriar.MouseHover, CKBOpcoes_CKBGravarCriar.MouseHover, CKBAbortar.MouseHover, CKBOpcoes_CKBAbortar.MouseHover, CKBMostrarAgrupamentos.MouseHover, ComBSelectAgrupamento.MouseHover, TXTRotulo.MouseHover, CmBTipoDeMidia.MouseHover, CmBLocalDaMidia.MouseHover, LBL_ComBSelectAgrupamento.MouseHover
        ' parece ocorrer quando o mouse para sobre um objeto

        Dim obj As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            obj = CType(sender, CheckBox)

            If obj.Checked = True Then

                obj.Parent.Parent.BackColor = _borderColorChecked
                obj.Parent.BackColor = _backgroundColorChecked
                obj.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

            Else

                obj.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
                obj.Parent.BackColor = _backgroundColorSelectAndMouseHover
                obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover

            End If
        Else
            obj = CType(sender, Object)

            obj.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
            obj.Parent.BackColor = _backgroundColorSelectAndMouseHover
            '  obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover

        End If




        Select Case obj.Name

            Case "CKBNovaMidia"
                CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBNovaMidia"
                CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBGravarCriar"
                CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBGravarCriar"
                CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBAbortar"
                CKBAbortar.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBAbortar"
                CKBOpcoes_CKBAbortar.BackColor = _backgroundColorSelectAndMouseHover

        End Select

    End Sub

    Private Sub Buttons_CheckedChanged(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.CheckedChanged, CKBNovaMidia.CheckedChanged, CKBGravarCriar.CheckedChanged, CKBOpcoes_CKBGravarCriar.CheckedChanged, CKBAbortar.CheckedChanged, CKBOpcoes_CKBAbortar.CheckedChanged, CKBMostrarAgrupamentos.CheckedChanged

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
