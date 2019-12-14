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



    Private Sub Objects_MouseUp(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseUp, CKBNovaMidia.MouseUp, CKBGravarCriar.MouseUp, CKBOpcoes_CKBGravarCriar.MouseUp, CKBMostrarAgrupamentos.MouseUp, ComBSelectAgrupamento.MouseUp, TXTRotulo.MouseUp, CmBTipoDeMidia.MouseUp, CmBLocalDaMidia.MouseUp, LBL_ComBSelectAgrupamento.MouseUp
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

            'Case "BTNAbortar"
            '    BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseUp
            '    BTNAbortar.BackColor = _backgroundColorSelectAndMouseUp

            'Case "BTNOpcoes_BTNAbortar"
            '    BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseUp
            '    BTNAbortar.BackColor = _backgroundColorSelectAndMouseUp

            Case "ComBSelectAgrupamento"
                PanelBorder_LBL_ComBSelectAgrupamento.BackColor = _borderColorSelectAndMouseUp

        End Select

        Debug.WriteLine("  ")
        Debug.WriteLine(" ________________________________________________________ ")
        Debug.WriteLine("MOUSEUP")
        'Debug.WriteLine("  ")

        'Debug.WriteLine(obj.Name & obj.BackColor.ToString)
        'Debug.WriteLine(obj.Name & obj.BackColor.ToString)

        'Debug.WriteLine("  ")
        'Debug.WriteLine(obj.Parent.Name & obj.Parent.BackColor.ToString)
        'Debug.WriteLine(obj.Parent.Parent.Name & obj.Parent.Parent.BackColor.ToString)

        Debug.WriteLine("  ")
        Debug.WriteLine(BTNMaisProcessos.Name & BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine(BTNMaisProcessos.Parent.Name & BTNMaisProcessos.Parent.BackColor.ToString)
        Debug.WriteLine(BTNMaisProcessos.Parent.Parent.Name & BTNMaisProcessos.Parent.Parent.BackColor.ToString)

        Debug.WriteLine("  ")
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Name & BTNOpcoes_BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Parent.Name & BTNOpcoes_BTNMaisProcessos.Parent.BackColor.ToString)
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Parent.Parent.Name & BTNOpcoes_BTNMaisProcessos.Parent.Parent.BackColor.ToString)

        Debug.WriteLine(" ________________________________________________________ ")

    End Sub

    Private Sub Buttons_MouseDown(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNAbortar.MouseDown, BTNAbortar.MouseDown, BTNOpcoes_BTNMaisProcessos.MouseDown, BTNMaisProcessos.MouseDown
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

    Private Sub Objects_MouseDown(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseDown, CKBNovaMidia.MouseDown, CKBGravarCriar.MouseDown, CKBOpcoes_CKBGravarCriar.MouseDown, CKBMostrarAgrupamentos.MouseDown, ComBSelectAgrupamento.MouseDown, TXTRotulo.MouseDown, CmBTipoDeMidia.MouseDown, CmBLocalDaMidia.MouseDown, LBL_ComBSelectAgrupamento.MouseDown

        ' Ocorre quando o usuario presciona o botão do mouse

        Dim obj As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            obj = CType(sender, CheckBox)
        Else
            obj = CType(sender, Object)
        End If


        obj.Parent.Parent.BackColor = _borderColorSelectAndMouseDown
        obj.Parent.BackColor = _backgroundColorSelectAndMouseDown

        If sender.GetType.Name.ToString = "CheckBox" Then
            If obj.Checked = True Then
                obj.FlatAppearance.MouseDownBackColor = _backgroundColorChecked

            Else
                obj.FlatAppearance.MouseDownBackColor = _backgroundColorSelectAndMouseDown

            End If
        End If

        Select Case obj.Name

            Case "CKBNovaMidia"
                CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBOpcoes_CKBNovaMidia"
                CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBOpcoes_CKBGravarCriar"
                CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBGravarCriar"
                CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseDown

                'Case "BTNOpcoes_BTNAbortar"
                '    BTNAbortar.BackColor = _backgroundColorSelectAndMouseDown
                '    BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseDown

                'Case "BTNAbortar"
                '    BTNAbortar.BackColor = _backgroundColorSelectAndMouseDown
                '    BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseDown


        End Select

        Debug.WriteLine("  ")
        Debug.WriteLine(" ________________________________________________________ ")
        Debug.WriteLine("MOUSEDOWN")

        'Debug.WriteLine("  ")

        'Debug.WriteLine(obj.Name & obj.BackColor.ToString)
        'Debug.WriteLine(obj.Name & obj.BackColor.ToString)

        'Debug.WriteLine("  ")
        'Debug.WriteLine(obj.Parent.Name & obj.Parent.BackColor.ToString)
        'Debug.WriteLine(obj.Parent.Parent.Name & obj.Parent.Parent.BackColor.ToString)

        Debug.WriteLine("  ")
        Debug.WriteLine(BTNMaisProcessos.Name & BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine(BTNMaisProcessos.Parent.Name & BTNMaisProcessos.Parent.BackColor.ToString)
        Debug.WriteLine(BTNMaisProcessos.Parent.Parent.Name & BTNMaisProcessos.Parent.Parent.BackColor.ToString)

        Debug.WriteLine("  ")
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Name & BTNOpcoes_BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Parent.Name & BTNOpcoes_BTNMaisProcessos.Parent.BackColor.ToString)
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Parent.Parent.Name & BTNOpcoes_BTNMaisProcessos.Parent.Parent.BackColor.ToString)

        Debug.WriteLine(" ________________________________________________________ ")

    End Sub

    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNAbortar.MouseLeave, BTNAbortar.MouseLeave, BTNOpcoes_BTNMaisProcessos.MouseLeave, BTNMaisProcessos.MouseLeave
        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.BackColor = _backgroundColorSelectAndMouseLeave
        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseLeave
        ' btn.FlatAppearance.MouseDownBackColor = _backgroundColorSelectAndMouseDown

    End Sub

    Private Sub Objects_MouseLeave(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseLeave, CKBNovaMidia.MouseLeave, CKBGravarCriar.MouseLeave, CKBOpcoes_CKBGravarCriar.MouseLeave, CKBMostrarAgrupamentos.MouseLeave, ComBSelectAgrupamento.MouseLeave, TXTRotulo.MouseLeave, CmBTipoDeMidia.MouseLeave, CmBLocalDaMidia.MouseLeave, LBL_ComBSelectAgrupamento.MouseLeave

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
                    '  obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseLeave

                End If

            Case "Button"
                obj = CType(sender, Button)
                ' If Not (obj.Focused) Then obj.parent.parent.backcolor = Color.LightGray
                obj.Parent.Parent.BackColor = _borderColorSelectAndMouseLeave
                obj.Parent.BackColor = _backgroundColorSelectAndMouseLeave


            Case "ComboBox"
                obj = CType(sender, ComboBox)
                If Not (obj.Focused) Then obj.parent.parent.backcolor = Color.LightGray

            Case "TextBox"
                obj = CType(sender, TextBox)
                If Not (obj.Focused) Then obj.parent.parent.backcolor = Color.LightGray

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

            Case "BTNOpcoes_BTNAbortar"
                BTNAbortar.BackColor = _backgroundColorSelectAndMouseLeave
                BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseLeave

            Case "BTNAbortar"
                BTNAbortar.BackColor = _backgroundColorSelectAndMouseLeave
                BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseLeave

        End Select

        Debug.WriteLine("  ")
        Debug.WriteLine(" ________________________________________________________ ")
        Debug.WriteLine("MOUSLEAVE")
        'Debug.WriteLine("  ")

        'Debug.WriteLine(obj.Name & obj.BackColor.ToString)
        'Debug.WriteLine(obj.Name & obj.BackColor.ToString)

        'Debug.WriteLine("  ")
        'Debug.WriteLine(obj.Parent.Name & obj.Parent.BackColor.ToString)
        'Debug.WriteLine(obj.Parent.Parent.Name & obj.Parent.Parent.BackColor.ToString)

        Debug.WriteLine("  ")
        Debug.WriteLine(BTNMaisProcessos.Name & BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine(BTNMaisProcessos.Parent.Name & BTNMaisProcessos.Parent.BackColor.ToString)
        Debug.WriteLine(BTNMaisProcessos.Parent.Parent.Name & BTNMaisProcessos.Parent.Parent.BackColor.ToString)

        Debug.WriteLine("  ")
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Name & BTNOpcoes_BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Parent.Name & BTNOpcoes_BTNMaisProcessos.Parent.BackColor.ToString)
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Parent.Parent.Name & BTNOpcoes_BTNMaisProcessos.Parent.Parent.BackColor.ToString)

        Debug.WriteLine(" ________________________________________________________ ")
    End Sub

    Private Sub Buttons_MouseMove(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNAbortar.MouseMove, BTNAbortar.MouseMove, BTNOpcoes_BTNMaisProcessos.MouseMove, BTNMaisProcessos.MouseMove
        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.BackColor = _backgroundColorSelectAndMouseHover
        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
        btn.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover
    End Sub

    Private Sub Objects_MouseMove(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseMove, CKBNovaMidia.MouseMove, CKBGravarCriar.MouseMove, CKBOpcoes_CKBGravarCriar.MouseMove, CKBMostrarAgrupamentos.MouseMove, ComBSelectAgrupamento.MouseMove, TXTRotulo.MouseMove, CmBTipoDeMidia.MouseMove, CmBLocalDaMidia.MouseMove, LBL_ComBSelectAgrupamento.MouseMove


        ' Ocorre quando o mouse passa por cima do elemento
        Dim obj As Object

        Select Case sender.GetType.Name.ToString
            Case "CheckBox"
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

            Case Else
                obj = CType(sender, Object)

                obj.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
                obj.Parent.BackColor = _backgroundColorSelectAndMouseHover
        End Select

        Select Case obj.Name

            Case "CKBNovaMidia"
                CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBNovaMidia"
                CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBGravarCriar"
                CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBGravarCriar"
                CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNOpcoes_BTNAbortar"
                BTNAbortar.BackColor = _backgroundColorSelectAndMouseHover
                BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNAbortar"
                BTNAbortar.BackColor = _backgroundColorSelectAndMouseHover
                BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseHover

        End Select

        Debug.WriteLine("  ")
        Debug.WriteLine(" ________________________________________________________ ")
        Debug.WriteLine("MOUSEMOVE")

        'Debug.WriteLine("  ")

        'Debug.WriteLine(obj.Name & obj.BackColor.ToString)
        'Debug.WriteLine(obj.Name & obj.BackColor.ToString)

        'Debug.WriteLine("  ")
        'Debug.WriteLine(obj.Parent.Name & obj.Parent.BackColor.ToString)
        'Debug.WriteLine(obj.Parent.Parent.Name & obj.Parent.Parent.BackColor.ToString)

        Debug.WriteLine("  ")
        Debug.WriteLine(BTNMaisProcessos.Name & BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine(BTNMaisProcessos.Parent.Name & BTNMaisProcessos.Parent.BackColor.ToString)
        Debug.WriteLine(BTNMaisProcessos.Parent.Parent.Name & BTNMaisProcessos.Parent.Parent.BackColor.ToString)

        Debug.WriteLine("  ")
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Name & BTNOpcoes_BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Parent.Name & BTNOpcoes_BTNMaisProcessos.Parent.BackColor.ToString)
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Parent.Parent.Name & BTNOpcoes_BTNMaisProcessos.Parent.Parent.BackColor.ToString)

        Debug.WriteLine(" ________________________________________________________ ")
    End Sub

    Private Sub Buttons_MouseHover(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNAbortar.MouseHover, BTNAbortar.MouseHover, BTNOpcoes_BTNMaisProcessos.MouseHover, BTNMaisProcessos.MouseHover
        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.BackColor = _backgroundColorSelectAndMouseHover
        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
        btn.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover

    End Sub

    Private Sub Objects_MouseHover(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseHover, CKBNovaMidia.MouseHover, CKBGravarCriar.MouseHover, CKBOpcoes_CKBGravarCriar.MouseHover, CKBMostrarAgrupamentos.MouseHover, ComBSelectAgrupamento.MouseHover, TXTRotulo.MouseHover, CmBTipoDeMidia.MouseHover, CmBLocalDaMidia.MouseHover, LBL_ComBSelectAgrupamento.MouseHover

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

            Case "BTNOpcoes_BTNAbortar"
                BTNAbortar.BackColor = _backgroundColorSelectAndMouseHover
                BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseHover

            Case "BTNAbortar"
                BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseHover
                BTNAbortar.BackColor = _backgroundColorSelectAndMouseHover

        End Select
        Debug.WriteLine("  ")
        Debug.WriteLine(" ________________________________________________________ ")
        Debug.WriteLine("MOUSEHOVER")
        Debug.WriteLine("  ")

        'Debug.WriteLine("  ")

        'Debug.WriteLine(obj.Name & obj.BackColor.ToString)
        'Debug.WriteLine(obj.Name & obj.BackColor.ToString)

        'Debug.WriteLine("  ")
        'Debug.WriteLine(obj.Parent.Name & obj.Parent.BackColor.ToString)
        'Debug.WriteLine(obj.Parent.Parent.Name & obj.Parent.Parent.BackColor.ToString)

        Debug.WriteLine("  ")
        Debug.WriteLine(BTNMaisProcessos.Name & BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine(BTNMaisProcessos.Parent.Name & BTNMaisProcessos.Parent.BackColor.ToString)
        Debug.WriteLine(BTNMaisProcessos.Parent.Parent.Name & BTNMaisProcessos.Parent.Parent.BackColor.ToString)

        Debug.WriteLine("  ")
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Name & BTNOpcoes_BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Parent.Name & BTNOpcoes_BTNMaisProcessos.Parent.BackColor.ToString)
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Parent.Parent.Name & BTNOpcoes_BTNMaisProcessos.Parent.Parent.BackColor.ToString)


        Debug.WriteLine(" ________________________________________________________ ")
    End Sub

    Private Sub Objects_CheckedChanged(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.CheckedChanged, CKBNovaMidia.CheckedChanged, CKBGravarCriar.CheckedChanged, CKBOpcoes_CKBGravarCriar.CheckedChanged, CKBMostrarAgrupamentos.CheckedChanged

        Dim chk As CheckBox
        chk = CType(sender, CheckBox)

        If chk.Checked = True Then
            chk.Parent.Parent.BackColor = _borderColorChecked
            chk.FlatAppearance.BorderColor = _borderColorChecked
            chk.FlatAppearance.CheckedBackColor = _backgroundColorChecked

            '  chk.FlatAppearance.BorderSize = 1

        Else
            chk.Parent.Parent.BackColor = _backgroundColorSelectAndMouseLeave
            chk.Parent.BackColor = _borderColorSelectAndMouseLeave
            chk.FlatAppearance.CheckedBackColor = _backgroundColorSelectAndMouseLeave

            'Color.Transparent

            chk.FlatAppearance.BorderSize = 0
        End If

        Select Case chk.Name
            Case "CKBNovaMidia"
                CKBOpcoes_CKBNovaMidia.Checked = CKBNovaMidia.Checked

                PanelEnvolve_PanelAgrupaGerenciar.Visible = chk.CheckState
                PanelBorder_CKBGravarCriar.Enabled = chk.CheckState

              '  PanelBorder_CKBAbortar.Enabled = Not (PanelBorder_CKBGravarCriar.Enabled)

            Case "CKBOpcoes_CKBNovaMidia"
                CKBNovaMidia.Checked = CKBOpcoes_CKBNovaMidia.Checked

            Case "CKBGravarCriar"
                CKBOpcoes_CKBGravarCriar.Checked = CKBGravarCriar.Checked
                PanelBorder_CKBGravarCriar.Enabled = False

                PanelBorder_CKBAbortar.Enabled = chk.Checked

            Case "CKBOpcoes_CKBGravarCriar"
                CKBGravarCriar.Checked = CKBOpcoes_CKBGravarCriar.Checked

            Case "CKBAbortar"
                Dim podeAbortar As Boolean = AbortBurnMedia(chk)

                If podeAbortar = True Then
                    CKBGravarCriar.Checked = False
                    PanelBorder_CKBGravarCriar.Enabled = True
                    ' CKBOpcoes_BTNAbortar.Checked = BTNAbortar.Checked

                Else
                    chk.Checked = True

                End If

            Case "BTNOpcoes_BTNAbortar"
                MsgBox(chk.Checked)

                Dim podeAbortar As Boolean = AbortBurnMedia(chk)

                If podeAbortar = True Then
                    CKBGravarCriar.Checked = False
                    PanelBorder_CKBGravarCriar.Enabled = True
                    '  BTNAbortar.Checked = CKBOpcoes_BTNAbortar.Checked
                    ' BTNAbortar.Checked = False
                    PanelBorder_CKBAbortar.Enabled = False

                Else
                    chk.Checked = True

                End If
        End Select

    End Sub

    Private Function AbortBurnMedia(chk As CheckBox) As Boolean

        Dim x As Byte
        x = MsgBox("Você está preste a abortar a gravação da mídia. Se continuar a gravação estará perdida.Tem certeza que que continuar?", MsgBoxStyle.YesNo)

        If x = 6 Then
            Return True

        Else
            Return False

        End If

    End Function


    Private Sub TXTRotulo_GotFocus(sender As Object, e As EventArgs) Handles TXTRotulo.GotFocus, ComBSelectAgrupamento.GotFocus, CmBTipoDeMidia.GotFocus, CmBLocalDaMidia.GotFocus

        Dim obj As Object
        obj = CType(sender, Object)

        obj.Parent.Parent.BackColor = _borderColorSelectAndMouseHover

    End Sub

    Private Sub TXTRotulo_LostFocus(sender As Object, e As EventArgs) Handles TXTRotulo.LostFocus, ComBSelectAgrupamento.LostFocus, CmBTipoDeMidia.LostFocus, CmBLocalDaMidia.LostFocus
        Dim obj As Object
        obj = CType(sender, Object)

        obj.Parent.Parent.BackColor = Color.LightGray


    End Sub



    Private Sub BTNMaisProcessos_Click(sender As Object, e As EventArgs) Handles BTNMaisProcessos.Click

        'MsgBox(BTNOpcoes_BTNMaisProcessos.BackColor.ToString)
        'MsgBox(BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine("  ")
        Debug.WriteLine(" ________________________________________________________ ")
        Debug.WriteLine("CLICK")
        'Debug.WriteLine("  ")

        'Debug.WriteLine(obj.Name & obj.BackColor.ToString)
        'Debug.WriteLine(obj.Name & obj.BackColor.ToString)

        'Debug.WriteLine("  ")
        'Debug.WriteLine(obj.Parent.Name & obj.Parent.BackColor.ToString)
        'Debug.WriteLine(obj.Parent.Parent.Name & obj.Parent.Parent.BackColor.ToString)

        Debug.WriteLine("  ")
        Debug.WriteLine(BTNMaisProcessos.Name & BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine(BTNMaisProcessos.Parent.Name & BTNMaisProcessos.Parent.BackColor.ToString)
        Debug.WriteLine(BTNMaisProcessos.Parent.Parent.Name & BTNMaisProcessos.Parent.Parent.BackColor.ToString)

        Debug.WriteLine("  ")
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Name & BTNOpcoes_BTNMaisProcessos.BackColor.ToString)
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Parent.Name & BTNOpcoes_BTNMaisProcessos.Parent.BackColor.ToString)
        Debug.WriteLine(BTNOpcoes_BTNMaisProcessos.Parent.Parent.Name & BTNOpcoes_BTNMaisProcessos.Parent.Parent.BackColor.ToString)

        Debug.WriteLine(" ________________________________________________________ ")

    End Sub
End Class
