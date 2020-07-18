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

    Private Sub Control_BurnMenuBar_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Sub Objects_MouseUp(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseUp, CKBNovaMidia.MouseUp, CKBGravarCriar.MouseUp, CKBOpcoes_CKBGravarCriar.MouseUp, CKBMostrarGruposDeAcoes.MouseUp, ComBSelectAgrupamento.MouseUp, TXTRotulo.MouseUp, CmBTipoDeMidia.MouseUp, CmBLocalDaMidia.MouseUp, LBL_ComBSelectAgrupamento.MouseUp
        'Ocorre qunado o mouse solta o objeto

        Dim obj As Object

        Select Case sender.GetType.Name.ToString
            Case "CheckBox"

                obj = CType(sender, CheckBox)
                If obj.Checked = True Then

                    obj.Parent.Parent.BackColor = _borderColorChecked
                    obj.Parent.BackColor = _backgroundColorChecked
                    obj.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

                Else
                    obj.Parent.Parent.BackColor = _borderColorSelectAndMouseUp
                    obj.Parent.BackColor = _backgroundColorSelectAndMouseUp
                    obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseUp

                End If

            Case Else
                obj = CType(sender, Object)
                obj.Parent.Parent.BackColor = _borderColorSelectAndMouseUp
                obj.Parent.BackColor = _backgroundColorSelectAndMouseUp

        End Select

        Select Case obj.Name
            Case "CKBOpcoes_CKBNovaMidia"
                If obj.Checked = True Then
                    CKBNovaMidia.BackColor = _backgroundColorChecked

                Else

                    CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseUp
                End If

            Case "CKBNovaMidia"
                If obj.Checked = True Then
                    CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorChecked

                Else
                    CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseUp

                End If

            Case "CKBGravarCriar"
                If obj.Checked = True Then
                    CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorChecked

                Else
                    CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseUp

                End If

            Case "CKBOpcoes_CKBGravarCriar"
                If obj.Checked = True Then
                    CKBGravarCriar.BackColor = _backgroundColorChecked

                Else
                    CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseUp

                End If

            Case "ComBSelectAgrupamento"
                PanelBorder_LBL_ComBSelectAgrupamento.BackColor = _borderColorSelectAndMouseUp

        End Select

    End Sub

    Private Sub Buttons_MouseDown(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNAbortar.MouseDown, BTNAbortar.MouseDown
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

    Private Sub Objects_MouseDown(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseDown, CKBNovaMidia.MouseDown, CKBGravarCriar.MouseDown, CKBOpcoes_CKBGravarCriar.MouseDown, CKBMostrarGruposDeAcoes.MouseDown, ComBSelectAgrupamento.MouseDown, TXTRotulo.MouseDown, CmBTipoDeMidia.MouseDown, CmBLocalDaMidia.MouseDown, LBL_ComBSelectAgrupamento.MouseDown

        ' Ocorre quando o usuario preciona o botão do mouse

        Dim obj As Object

        Select Case sender.GetType.Name.ToString
            Case "CheckBox"
                obj = CType(sender, CheckBox)

                If obj.Checked = True Then

                    obj.Parent.Parent.BackColor = _borderColorChecked
                    obj.Parent.BackColor = _backgroundColorChecked
                    obj.FlatAppearance.MouseDownBackColor = _backgroundColorChecked

                Else
                    obj.Parent.Parent.BackColor = _borderColorSelectAndMouseDown
                    obj.Parent.BackColor = _backgroundColorSelectAndMouseDown
                    obj.FlatAppearance.MouseDownBackColor = _backgroundColorSelectAndMouseDown

                    obj.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

                End If

            Case Else
                obj = CType(sender, Object)
                obj.Parent.Parent.BackColor = _borderColorSelectAndMouseDown
                obj.Parent.BackColor = _backgroundColorSelectAndMouseDown

        End Select

        Select Case obj.Name

            Case "CKBNovaMidia"
                If obj.Checked = True Then
                    CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorChecked

                Else
                    CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseDown

                End If

            Case "CKBOpcoes_CKBNovaMidia"

                If obj.Checked = True Then
                    CKBNovaMidia.BackColor = _backgroundColorChecked

                Else
                    CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseDown

                End If

            Case "CKBOpcoes_CKBGravarCriar"
                If obj.Checked = True Then
                    CKBGravarCriar.BackColor = _backgroundColorChecked

                Else
                    CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseDown

                End If

            Case "CKBGravarCriar"
                If obj.Checked = True Then
                    CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorChecked

                Else
                    CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseDown

                End If

        End Select

        Debug.WriteLine("  ")
        Debug.WriteLine(" ________________________________________________________ ")
        Debug.WriteLine("MOUSEDOWN")

        Debug.WriteLine("  ")

    End Sub

    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNAbortar.MouseLeave, BTNAbortar.MouseLeave
        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.BackColor = _backgroundColorSelectAndMouseLeave
        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseLeave
        ' btn.FlatAppearance.MouseDownBackColor = _backgroundColorSelectAndMouseDown

    End Sub

    Private Sub Objects_MouseLeave(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseLeave, CKBNovaMidia.MouseLeave, CKBGravarCriar.MouseLeave, CKBOpcoes_CKBGravarCriar.MouseLeave, CKBMostrarGruposDeAcoes.MouseLeave, ComBSelectAgrupamento.MouseLeave, TXTRotulo.MouseLeave, CmBTipoDeMidia.MouseLeave, CmBLocalDaMidia.MouseLeave, LBL_ComBSelectAgrupamento.MouseLeave

        ' Ocorre quando o mouse sai do objeto
        Dim obj As Object

        Select Case sender.GetType.Name.ToString

            Case "CheckBox"

                obj = CType(sender, CheckBox)
                If obj.Checked = True Then

                    obj.Parent.Parent.BackColor = _borderColorChecked
                    obj.Parent.BackColor = _backgroundColorChecked

                    obj.FlatAppearance.CheckedBackColor = _backgroundColorChecked
                    obj.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

                Else

                    obj.Parent.Parent.BackColor = _borderColorSelectAndMouseLeave
                    obj.Parent.BackColor = _backgroundColorSelectAndMouseLeave
                    obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseLeave

                End If

            Case "Button"
                obj = CType(sender, Button)

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
                If obj.Checked = True Then
                    CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorChecked

                Else
                    CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseLeave

                End If

            Case "CKBOpcoes_CKBNovaMidia"
                If obj.Checked = True Then
                    CKBNovaMidia.BackColor = _backgroundColorChecked

                Else
                    CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseLeave

                End If

            Case "CKBOpcoes_CKBGravarCriar"
                If obj.Checked = True Then
                    CKBGravarCriar.BackColor = _backgroundColorChecked

                Else
                    CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseLeave

                End If

            Case "CKBGravarCriar"
                If obj.Checked = True Then
                    CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorChecked

                Else
                    CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseLeave

                End If

            Case "BTNOpcoes_BTNAbortar"
                If obj.Checked = True Then
                    BTNAbortar.BackColor = _backgroundColorChecked

                Else
                    BTNAbortar.BackColor = _backgroundColorSelectAndMouseLeave

                End If

            Case "BTNAbortar"
                If obj.Checked = True Then
                    BTNOpcoes_BTNAbortar.BackColor = _backgroundColorChecked

                Else
                    BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseLeave

                End If

        End Select

    End Sub

    Private Sub Buttons_MouseMove(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNAbortar.MouseMove, BTNAbortar.MouseMove
        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.BackColor = _backgroundColorSelectAndMouseOver
        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseOver
        btn.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseOver
    End Sub

    Private Sub Objects_MouseMove(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseMove, CKBNovaMidia.MouseMove, CKBGravarCriar.MouseMove, CKBOpcoes_CKBGravarCriar.MouseMove, CKBMostrarGruposDeAcoes.MouseMove, ComBSelectAgrupamento.MouseMove, TXTRotulo.MouseMove, CmBTipoDeMidia.MouseMove, CmBLocalDaMidia.MouseMove, LBL_ComBSelectAgrupamento.MouseMove

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

                    obj.Parent.Parent.BackColor = _borderColorSelectAndMouseOver
                    obj.Parent.BackColor = _backgroundColorSelectAndMouseOver
                    obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseOver

                End If

            Case Else
                obj = CType(sender, Object)

                obj.Parent.Parent.BackColor = _borderColorSelectAndMouseOver
                obj.Parent.BackColor = _backgroundColorSelectAndMouseOver
        End Select

        Select Case obj.Name

            Case "CKBNovaMidia"
                If obj.Checked = True Then
                    CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorChecked

                Else
                    CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseOver

                End If

            Case "CKBOpcoes_CKBNovaMidia"
                If obj.Checked = True Then
                    CKBNovaMidia.BackColor = _backgroundColorChecked

                Else
                    CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseOver

                End If


            Case "CKBOpcoes_CKBGravarCriar"
                If obj.Checked = True Then
                    CKBGravarCriar.BackColor = _backgroundColorChecked

                Else
                    CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseOver

                End If


            Case "CKBGravarCriar"
                If obj.Checked = True Then
                    CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorChecked

                Else
                    CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseOver

                End If

            Case "BTNOpcoes_BTNAbortar"

                If obj.Checked = True Then
                    BTNAbortar.BackColor = _backgroundColorChecked

                Else
                    BTNAbortar.BackColor = _backgroundColorSelectAndMouseOver

                End If

            Case "BTNAbortar"
                If obj.Checked = True Then
                    BTNOpcoes_BTNAbortar.BackColor = _backgroundColorChecked

                Else
                    BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseOver

                End If

        End Select

        Debug.WriteLine("  ")
        Debug.WriteLine(" ________________________________________________________ ")
        Debug.WriteLine("MOUSEMOVE")
        Debug.WriteLine(" ________________________________________________________ ")
    End Sub

    Private Sub Buttons_MouseOver(sender As Object, e As EventArgs) Handles BTNOpcoes_BTNAbortar.MouseHover, BTNAbortar.MouseHover
        Dim btn As Button
        btn = CType(sender, Button)

        btn.Parent.BackColor = _backgroundColorSelectAndMouseOver
        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseOver
        btn.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseOver

    End Sub

    Private Sub Objects_MouseOver(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.MouseHover, CKBNovaMidia.MouseHover, CKBGravarCriar.MouseHover, CKBOpcoes_CKBGravarCriar.MouseHover, CKBMostrarGruposDeAcoes.MouseHover, ComBSelectAgrupamento.MouseHover, TXTRotulo.MouseHover, CmBTipoDeMidia.MouseHover, CmBLocalDaMidia.MouseHover, LBL_ComBSelectAgrupamento.MouseHover

        ' parece ocorrer quando o mouse para sobre um objeto

        Dim obj As Object

        Select Case sender.GetType.Name.ToString
            Case "CheckBox"
                obj = CType(sender, CheckBox)

                If obj.Checked = True Then

                    obj.Parent.Parent.BackColor = _borderColorChecked
                    obj.Parent.BackColor = _backgroundColorChecked
                    obj.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

                Else

                    obj.Parent.Parent.BackColor = _borderColorSelectAndMouseOver
                    obj.Parent.BackColor = _backgroundColorSelectAndMouseOver
                    obj.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseOver

                End If

            Case Else
                obj = CType(sender, Object)

                obj.Parent.Parent.BackColor = _borderColorSelectAndMouseOver
                obj.Parent.BackColor = _backgroundColorSelectAndMouseOver
        End Select

        Select Case obj.Name

            Case "CKBNovaMidia"
                If obj.Checked = True Then
                    CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorChecked

                Else
                    CKBOpcoes_CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseOver

                End If

            Case "CKBOpcoes_CKBNovaMidia"
                If obj.Checked = True Then
                    CKBNovaMidia.BackColor = _backgroundColorChecked

                Else
                    CKBNovaMidia.BackColor = _backgroundColorSelectAndMouseOver

                End If


            Case "CKBOpcoes_CKBGravarCriar"
                If obj.Checked = True Then
                    CKBGravarCriar.BackColor = _backgroundColorChecked

                Else
                    CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseOver

                End If


            Case "CKBGravarCriar"
                If obj.Checked = True Then
                    CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorChecked

                Else
                    CKBOpcoes_CKBGravarCriar.BackColor = _backgroundColorSelectAndMouseOver

                End If


            Case "BTNOpcoes_BTNAbortar"

                If obj.Checked = True Then
                    BTNAbortar.BackColor = _backgroundColorChecked
                Else
                    BTNAbortar.BackColor = _backgroundColorSelectAndMouseOver
                End If

            Case "BTNAbortar"

                If obj.Checked = True Then
                    BTNOpcoes_BTNAbortar.BackColor = _backgroundColorChecked
                Else
                    BTNOpcoes_BTNAbortar.BackColor = _backgroundColorSelectAndMouseOver
                End If

        End Select

        Debug.WriteLine("  ")
        Debug.WriteLine(" ________________________________________________________ ")
        Debug.WriteLine("MOUSEHOVER")
        Debug.WriteLine("  ")

        Debug.WriteLine("  ")

        Debug.WriteLine(" ________________________________________________________ ")
    End Sub

    Private Sub Objects_CheckedChanged(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBNovaMidia.CheckedChanged, CKBNovaMidia.CheckedChanged, CKBGravarCriar.CheckedChanged, CKBOpcoes_CKBGravarCriar.CheckedChanged, CKBMostrarGruposDeAcoes.CheckedChanged

        Dim chk As CheckBox
        chk = CType(sender, CheckBox)

        Select Case chk.Checked
            Case True
                chk.Parent.Parent.BackColor = _borderColorChecked
                chk.FlatAppearance.BorderColor = _borderColorChecked

                '    chk.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

                chk.FlatAppearance.CheckedBackColor = _backgroundColorChecked
            Case Else

                chk.Parent.Parent.BackColor = Color.Transparent '_backgroundColorSelectAndMouseLeave
                chk.Parent.BackColor = Color.Transparent ' _borderColorSelectAndMouseLeave

        End Select

        Select Case chk.Name
            Case "CKBNovaMidia"
                CKBOpcoes_CKBNovaMidia.Checked = CKBNovaMidia.Checked

                PanelEnvolve_PanelAgrupaGerenciar.Visible = chk.Checked
                PanelBorder_CKBGravarCriar.Enabled = chk.Checked

              '  PanelBorder_CKBAbortar.Enabled = Not (PanelBorder_CKBGravarCriar.Enabled)

            Case "CKBOpcoes_CKBNovaMidia"
                CKBNovaMidia.Checked = CKBOpcoes_CKBNovaMidia.Checked

            Case "CKBGravarCriar"

                CKBOpcoes_CKBGravarCriar.Checked = CKBGravarCriar.Checked
                ExibirTelaGravando(chk.Checked)

            Case "CKBOpcoes_CKBGravarCriar"
                CKBGravarCriar.Checked = CKBOpcoes_CKBGravarCriar.Checked

        End Select

    End Sub

    Private Sub ExibirTelaGravando(exibir As Boolean)
        ' Mostra comportamento dos componentes como se estivesse gravando...
        ' ... quando exibir for verdadeiro.

        PanelBorder_CKBGravarCriar.Enabled = Not (exibir)
        CKBGravarCriar.Checked = exibir
        PanelBorder_CKBAbortar.Enabled = exibir

    End Sub

    Private Sub BTNAbortarAndBTNOpcoes_BTNAbortar_Click(sender As Object, e As EventArgs) Handles BTNAbortar.Click, BTNOpcoes_BTNAbortar.Click
        ExibirTelaGravando(ContinueBurningToMedia())

    End Sub

    Private Function ContinueBurningToMedia() As Boolean

        Dim x As Byte
        x = MsgBox("Você está preste a abortar a gravação da mídia. Se continuar a gravação estará perdida.Tem certeza que que continuar?", MsgBoxStyle.YesNo)

        If x = 6 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub TXTRotulo_GotFocus(sender As Object, e As EventArgs) Handles TXTRotulo.GotFocus, ComBSelectAgrupamento.GotFocus, CmBTipoDeMidia.GotFocus, CmBLocalDaMidia.GotFocus

        Dim obj As Object
        obj = CType(sender, Object)

        obj.Parent.Parent.BackColor = _borderColorSelectAndMouseOver

    End Sub

    Private Sub TXTRotulo_LostFocus(sender As Object, e As EventArgs) Handles TXTRotulo.LostFocus, ComBSelectAgrupamento.LostFocus, CmBTipoDeMidia.LostFocus, CmBLocalDaMidia.LostFocus
        Dim obj As Object
        obj = CType(sender, Object)

        obj.Parent.Parent.BackColor = Color.LightGray

    End Sub

End Class
