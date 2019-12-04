Public Class Control_ViewMenuBar
    Dim pMouse As Point

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

    Private Sub Control_ViewMenuBar_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    Private Sub Buttons_MouseUp(sender As Object, e As EventArgs) Handles CKBExibirMaisDetalhes.MouseUp, CKBOpcoes_CKBExibirMaisDetalhes.MouseUp, CKBPainelEsquedo.MouseUp, CKBOpcoes_CKBPainelEsquedo.MouseUp, CKBPainelDireito.MouseUp, CKBOpcoes_CKBPainelDireito.MouseUp, CKBExibirEstrelas.MouseUp, CKBOpcoes_CKBExibirEstrelas.MouseUp, CKBExibirStatusGravado.MouseUp, CKBOpcoes_CKBExibirStatusGravado.MouseUp, CKBExibirFlag.MouseUp, CKBOpcoes_CKBExibirFlag.MouseUp, CKBEtiquetaDeTitulo_Nome.MouseUp, CKBEtiquetaDeTitulo_NomeEExtencao.MouseUp, CKBEtiquetaDeTitulo_Legenda.MouseUp, CKBEtiquetaDeTitulo_DataDeCriacao.MouseUp, CKBEtiquetaDeTitulo_DatasRecentes.MouseUp, CKBEtiquetaDeTitulo_Tamanho.MouseUp, CKBEtiquetaDeTitulo_Resolucao.MouseUp, CKBEtiquetaDeTitulo_Autor.MouseUp, CKBEtiquetaDeTitulo_Album.MouseUp, CKBEtiquetaDeSubTitulo_Ocultar.MouseUp, CKBEtiquetaDeSubTitulo_Legenda.MouseUp, CKBEtiquetaDeSubTitulo_Resolucao.MouseUp, CKBEtiquetaDeSubTitulo_Autor.MouseUp, CKBEtiquetaDeSubTitulo_Album.MouseUp, CKBEtiquetaDeSubTitulo_Tipo.MouseUp, CKBEtiquetaDeSubTitulo_DataDeCriacao.MouseUp, CKBEtiquetaDeSubTitulo_DatasRecentes.MouseUp, CKBEtiquetaDeSubTitulo_Tamanho.MouseUp

        Dim btn As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            btn = CType(sender, CheckBox)
        Else
            btn = CType(sender, Button)
        End If

        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseUp
        btn.Parent.BackColor = _backgroundColorSelectAndMouseUp

        btn.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseUp


        Select Case btn.Name
            Case "CKBPainelEsquedo"
                CKBOpcoes_CKBPainelEsquedo.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBOpcoes_CKBPainelEsquedo"
                CKBPainelEsquedo.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBOpcoes_CKBExibirEstrelas"
                CKBExibirEstrelas.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBExibirEstrelas"
                CKBOpcoes_CKBExibirEstrelas.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBOpcoes_CKBExibirStatusGravado"
                CKBExibirStatusGravado.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBExibirStatusGravado"
                CKBOpcoes_CKBExibirStatusGravado.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBOpcoes_CKBExibirFlag"
                CKBExibirFlag.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBExibirFlag"
                CKBOpcoes_CKBExibirFlag.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBExibirMaisDetalhes"
                CKBOpcoes_CKBExibirMaisDetalhes.BackColor = _backgroundColorSelectAndMouseUp

            Case "CKBOpcoes_CKBExibirMaisDetalhes"
                CKBExibirMaisDetalhes.BackColor = _backgroundColorSelectAndMouseUp

        End Select

    End Sub



    Private Sub Buttons_MouseDown(sender As Object, e As EventArgs) Handles CKBExibirMaisDetalhes.MouseDown, CKBOpcoes_CKBExibirMaisDetalhes.MouseDown, CKBPainelEsquedo.MouseDown, CKBOpcoes_CKBPainelEsquedo.MouseDown, CKBPainelDireito.MouseDown, CKBOpcoes_CKBPainelDireito.MouseDown, CKBExibirEstrelas.MouseDown, CKBOpcoes_CKBExibirEstrelas.MouseDown, CKBExibirStatusGravado.MouseDown, CKBOpcoes_CKBExibirStatusGravado.MouseDown, CKBExibirFlag.MouseDown, CKBOpcoes_CKBExibirFlag.MouseDown, CKBEtiquetaDeTitulo_Nome.MouseDown, CKBEtiquetaDeTitulo_NomeEExtencao.MouseDown, CKBEtiquetaDeTitulo_Legenda.MouseDown, CKBEtiquetaDeTitulo_DataDeCriacao.MouseDown, CKBEtiquetaDeTitulo_DatasRecentes.MouseDown, CKBEtiquetaDeTitulo_Tamanho.MouseDown, CKBEtiquetaDeTitulo_Resolucao.MouseDown, CKBEtiquetaDeTitulo_Autor.MouseDown, CKBEtiquetaDeTitulo_Album.MouseDown, CKBEtiquetaDeSubTitulo_Ocultar.MouseDown, CKBEtiquetaDeSubTitulo_Legenda.MouseDown, CKBEtiquetaDeSubTitulo_Resolucao.MouseDown, CKBEtiquetaDeSubTitulo_Autor.MouseDown, CKBEtiquetaDeSubTitulo_Album.MouseDown, CKBEtiquetaDeSubTitulo_Tipo.MouseDown, CKBEtiquetaDeSubTitulo_DataDeCriacao.MouseDown, CKBEtiquetaDeSubTitulo_DatasRecentes.MouseDown, CKBEtiquetaDeSubTitulo_Tamanho.MouseDown

        Dim btn As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            btn = CType(sender, CheckBox)
        Else
            btn = CType(sender, Button)
        End If


        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseDown
        btn.Parent.BackColor = _backgroundColorSelectAndMouseDown
        btn.FlatAppearance.MouseDownBackColor = _backgroundColorSelectAndMouseDown


        Select Case btn.Name

            Case "CKBPainelEsquedo"
                CKBOpcoes_CKBPainelEsquedo.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBOpcoes_CKBPainelEsquedo"
                CKBPainelEsquedo.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBOpcoes_CKBExibirEstrelas"
                CKBExibirEstrelas.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBExibirEstrelas"
                CKBOpcoes_CKBExibirEstrelas.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBOpcoes_CKBExibirStatusGravado"
                CKBExibirStatusGravado.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBExibirStatusGravado"
                CKBOpcoes_CKBExibirStatusGravado.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBOpcoes_CKBExibirFlag"
                CKBExibirFlag.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBExibirFlag"
                CKBOpcoes_CKBExibirFlag.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBExibirMaisDetalhes"
                CKBOpcoes_CKBExibirMaisDetalhes.BackColor = _backgroundColorSelectAndMouseDown

            Case "CKBOpcoes_CKBExibirMaisDetalhes"
                CKBExibirMaisDetalhes.BackColor = _backgroundColorSelectAndMouseDown

        End Select

    End Sub

    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles CKBExibirMaisDetalhes.MouseLeave, CKBOpcoes_CKBExibirMaisDetalhes.MouseLeave, CKBPainelEsquedo.MouseLeave, CKBOpcoes_CKBPainelEsquedo.MouseLeave, CKBPainelDireito.MouseLeave, CKBOpcoes_CKBPainelDireito.MouseLeave, CKBExibirEstrelas.MouseLeave, CKBOpcoes_CKBExibirEstrelas.MouseLeave, CKBExibirStatusGravado.MouseLeave, CKBOpcoes_CKBExibirStatusGravado.MouseLeave, CKBExibirFlag.MouseLeave, CKBOpcoes_CKBExibirFlag.MouseLeave, CKBEtiquetaDeTitulo_Nome.MouseLeave, CKBEtiquetaDeTitulo_NomeEExtencao.MouseLeave, CKBEtiquetaDeTitulo_Legenda.MouseLeave, CKBEtiquetaDeTitulo_DataDeCriacao.MouseLeave, CKBEtiquetaDeTitulo_Tamanho.MouseLeave, CKBEtiquetaDeTitulo_Resolucao.MouseLeave, CKBEtiquetaDeTitulo_Autor.MouseLeave, CKBEtiquetaDeTitulo_Album.MouseLeave, CKBEtiquetaDeSubTitulo_Ocultar.MouseLeave, CKBEtiquetaDeSubTitulo_Legenda.MouseLeave, CKBEtiquetaDeSubTitulo_Resolucao.MouseLeave, CKBEtiquetaDeSubTitulo_Autor.MouseLeave, CKBEtiquetaDeSubTitulo_Album.MouseLeave, CKBEtiquetaDeSubTitulo_Tipo.MouseLeave, CKBEtiquetaDeSubTitulo_DataDeCriacao.MouseLeave, CKBEtiquetaDeSubTitulo_DatasRecentes.MouseLeave, CKBEtiquetaDeSubTitulo_Tamanho.MouseLeave, CKBEtiquetaDeTitulo_DatasRecentes.MouseLeave

        Dim btn As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            btn = CType(sender, CheckBox)
        Else
            btn = CType(sender, Button)
        End If

        btn.Parent.Parent.BackColor = _borderColorSelectAndMouseLeave
        btn.Parent.BackColor = _backgroundColorSelectAndMouseLeave


        If btn.Checked = True Then

            btn.Parent.Parent.BackColor = _borderColorChecked
            btn.Parent.BackColor = _backgroundColorChecked
            btn.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

        Else

            btn.Parent.Parent.BackColor = _borderColorSelectAndMouseLeave
            btn.Parent.BackColor = _backgroundColorSelectAndMouseLeave

        End If


        Select Case btn.Name
            Case "CKBPainelEsquedo"
                CKBOpcoes_CKBPainelEsquedo.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBOpcoes_CKBPainelEsquedo"
                CKBPainelEsquedo.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBOpcoes_CKBExibirEstrelas"
                CKBExibirEstrelas.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBExibirEstrelas"
                CKBOpcoes_CKBExibirEstrelas.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBOpcoes_CKBExibirStatusGravado"
                CKBExibirStatusGravado.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBExibirStatusGravado"
                CKBOpcoes_CKBExibirStatusGravado.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBOpcoes_CKBExibirFlag"
                CKBExibirFlag.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBExibirFlag"
                CKBOpcoes_CKBExibirFlag.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBExibirMaisDetalhes"
                CKBOpcoes_CKBExibirMaisDetalhes.BackColor = _backgroundColorSelectAndMouseLeave

            Case "CKBOpcoes_CKBExibirMaisDetalhes"
                CKBExibirMaisDetalhes.BackColor = _backgroundColorSelectAndMouseLeave

        End Select
    End Sub



    Private Sub Buttons_MouseMove(sender As Object, e As EventArgs) Handles CKBExibirMaisDetalhes.MouseMove, CKBOpcoes_CKBExibirMaisDetalhes.MouseMove, CKBPainelEsquedo.MouseMove, CKBOpcoes_CKBPainelEsquedo.MouseMove, CKBPainelDireito.MouseMove, CKBOpcoes_CKBPainelDireito.MouseMove, CKBExibirEstrelas.MouseMove, CKBOpcoes_CKBExibirEstrelas.MouseMove, CKBExibirStatusGravado.MouseMove, CKBOpcoes_CKBExibirStatusGravado.MouseMove, CKBExibirFlag.MouseMove, CKBOpcoes_CKBExibirFlag.MouseMove, CKBEtiquetaDeTitulo_Nome.MouseMove, CKBEtiquetaDeTitulo_NomeEExtencao.MouseMove, CKBEtiquetaDeTitulo_Legenda.MouseMove, CKBEtiquetaDeTitulo_DataDeCriacao.MouseMove, CKBEtiquetaDeTitulo_DatasRecentes.MouseMove, CKBEtiquetaDeTitulo_Tamanho.MouseMove, CKBEtiquetaDeTitulo_Resolucao.MouseMove, CKBEtiquetaDeTitulo_Autor.MouseMove, CKBEtiquetaDeTitulo_Album.MouseMove, CKBEtiquetaDeSubTitulo_Ocultar.MouseMove, CKBEtiquetaDeSubTitulo_Legenda.MouseMove, CKBEtiquetaDeSubTitulo_Resolucao.MouseMove, CKBEtiquetaDeSubTitulo_Autor.MouseMove, CKBEtiquetaDeSubTitulo_Album.MouseMove, CKBEtiquetaDeSubTitulo_Tipo.MouseMove, CKBEtiquetaDeSubTitulo_DataDeCriacao.MouseMove, CKBEtiquetaDeSubTitulo_DatasRecentes.MouseMove, CKBEtiquetaDeSubTitulo_Tamanho.MouseMove

        Dim btn As Object

        If sender.GetType.Name.ToString = "CheckBox" Then
            btn = CType(sender, CheckBox)
        Else
            btn = CType(sender, Button)
        End If

        If btn.Checked = True Then

            btn.Parent.Parent.BackColor = _borderColorChecked
            btn.Parent.BackColor = _backgroundColorChecked
            btn.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

        Else

            btn.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
            btn.Parent.BackColor = _backgroundColorSelectAndMouseHover
            btn.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover

        End If

        Select Case btn.Name
            Case "CKBPainelEsquedo"
                CKBOpcoes_CKBPainelEsquedo.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBPainelEsquedo"
                CKBPainelEsquedo.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBExibirEstrelas"
                CKBExibirEstrelas.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBExibirEstrelas"
                CKBOpcoes_CKBExibirEstrelas.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBExibirStatusGravado"
                CKBExibirStatusGravado.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBExibirStatusGravado"
                CKBOpcoes_CKBExibirStatusGravado.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBExibirFlag"
                CKBExibirFlag.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBExibirFlag"
                CKBOpcoes_CKBExibirFlag.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBExibirMaisDetalhes"
                CKBOpcoes_CKBExibirMaisDetalhes.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBExibirMaisDetalhes"
                CKBExibirMaisDetalhes.BackColor = _backgroundColorSelectAndMouseHover

        End Select
    End Sub




    Private Sub Buttons_MouseHover(sender As Object, e As EventArgs) Handles CKBOpcoes_CKBExibirMaisDetalhes.MouseHover, CKBExibirMaisDetalhes.MouseHover, CKBPainelEsquedo.MouseHover, CKBOpcoes_CKBPainelEsquedo.MouseHover, CKBPainelDireito.MouseHover, CKBOpcoes_CKBPainelDireito.MouseHover, CKBExibirEstrelas.MouseHover, CKBOpcoes_CKBExibirEstrelas.MouseHover, CKBExibirStatusGravado.MouseHover, CKBOpcoes_CKBExibirStatusGravado.MouseHover, CKBExibirFlag.MouseHover, CKBOpcoes_CKBExibirFlag.MouseHover, CKBEtiquetaDeTitulo_Nome.MouseHover, CKBEtiquetaDeTitulo_NomeEExtencao.MouseHover, CKBEtiquetaDeTitulo_Legenda.MouseHover, CKBEtiquetaDeTitulo_DataDeCriacao.MouseHover, CKBEtiquetaDeTitulo_Tamanho.MouseHover, CKBEtiquetaDeTitulo_Resolucao.MouseHover, CKBEtiquetaDeTitulo_Autor.MouseHover, CKBEtiquetaDeTitulo_Album.MouseHover, CKBEtiquetaDeSubTitulo_Ocultar.MouseHover, CKBEtiquetaDeSubTitulo_Legenda.MouseHover, CKBEtiquetaDeSubTitulo_Resolucao.MouseHover, CKBEtiquetaDeSubTitulo_Autor.MouseHover, CKBEtiquetaDeSubTitulo_Album.MouseHover, CKBEtiquetaDeSubTitulo_Tipo.MouseHover, CKBEtiquetaDeSubTitulo_DataDeCriacao.MouseHover, CKBEtiquetaDeSubTitulo_DatasRecentes.MouseHover, CKBEtiquetaDeSubTitulo_Tamanho.MouseHover, CKBEtiquetaDeTitulo_DatasRecentes.MouseHover


        Dim btn As Object

        If sender.GetType.Name.ToString = "CheckBox" Then

            btn = CType(sender, CheckBox)
        Else
            btn = CType(sender, Button)
        End If

        If btn.Checked = True Then

            btn.Parent.Parent.BackColor = _borderColorChecked
            btn.Parent.BackColor = _backgroundColorChecked
            btn.FlatAppearance.MouseOverBackColor = _backgroundColorChecked

        Else

            btn.Parent.Parent.BackColor = _borderColorSelectAndMouseHover
            btn.Parent.BackColor = _backgroundColorSelectAndMouseHover
            btn.FlatAppearance.MouseOverBackColor = _backgroundColorSelectAndMouseHover

        End If


        Select Case btn.Name

            Case "CKBPainelEsquedo"
                CKBOpcoes_CKBPainelEsquedo.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBPainelEsquedo"
                CKBPainelEsquedo.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBExibirEstrelas"
                CKBExibirEstrelas.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBExibirEstrelas"
                CKBOpcoes_CKBExibirEstrelas.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBExibirStatusGravado"
                CKBExibirStatusGravado.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBExibirStatusGravado"
                CKBOpcoes_CKBExibirStatusGravado.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBExibirFlag"
                CKBExibirFlag.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBExibirFlag"
                CKBOpcoes_CKBExibirFlag.BackColor = _backgroundColorSelectAndMouseHover


            Case "CKBExibirMaisDetalhes"
                CKBOpcoes_CKBExibirMaisDetalhes.BackColor = _backgroundColorSelectAndMouseHover

            Case "CKBOpcoes_CKBExibirMaisDetalhes"
                CKBExibirMaisDetalhes.BackColor = _backgroundColorSelectAndMouseHover

        End Select

    End Sub

    Private Sub Buttons_CheckedChanged(sender As Object, e As EventArgs) Handles CKBExibirMaisDetalhes.CheckedChanged, CKBOpcoes_CKBExibirMaisDetalhes.CheckedChanged, CKBPainelEsquedo.CheckedChanged, CKBOpcoes_CKBPainelEsquedo.CheckedChanged, CKBPainelDireito.CheckedChanged, CKBOpcoes_CKBPainelDireito.CheckedChanged, CKBExibirEstrelas.CheckedChanged, CKBOpcoes_CKBExibirEstrelas.CheckedChanged, CKBExibirStatusGravado.CheckedChanged, CKBOpcoes_CKBExibirStatusGravado.CheckedChanged, CKBExibirFlag.CheckedChanged, CKBOpcoes_CKBExibirFlag.CheckedChanged, CKBEtiquetaDeTitulo_Nome.CheckedChanged, CKBEtiquetaDeTitulo_NomeEExtencao.CheckedChanged, CKBEtiquetaDeTitulo_Legenda.CheckedChanged, CKBEtiquetaDeTitulo_DataDeCriacao.CheckedChanged, CKBEtiquetaDeTitulo_DatasRecentes.CheckedChanged, CKBEtiquetaDeTitulo_Tamanho.CheckedChanged, CKBEtiquetaDeTitulo_Resolucao.CheckedChanged, CKBEtiquetaDeTitulo_Autor.CheckedChanged, CKBEtiquetaDeTitulo_Album.CheckedChanged, CKBEtiquetaDeSubTitulo_Ocultar.CheckedChanged, CKBEtiquetaDeSubTitulo_Legenda.CheckedChanged, CKBEtiquetaDeSubTitulo_Resolucao.CheckedChanged, CKBEtiquetaDeSubTitulo_Autor.CheckedChanged, CKBEtiquetaDeSubTitulo_Album.CheckedChanged, CKBEtiquetaDeSubTitulo_Tipo.CheckedChanged, CKBEtiquetaDeSubTitulo_DataDeCriacao.CheckedChanged, CKBEtiquetaDeSubTitulo_DatasRecentes.CheckedChanged, CKBEtiquetaDeSubTitulo_Tamanho.CheckedChanged
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
            Case "CKBPainelEsquedo"
                CKBOpcoes_CKBPainelEsquedo.Checked = CKBPainelEsquedo.Checked

            Case "CKBOpcoes_CKBPainelEsquedo"
                CKBPainelEsquedo.Checked = CKBOpcoes_CKBPainelEsquedo.Checked

            Case "CKBPainelDireito"
                CKBOpcoes_CKBPainelDireito.Checked = CKBPainelDireito.Checked
            Case "CKBOpcoes_CKBPainelDireito"
                CKBPainelDireito.Checked = CKBOpcoes_CKBPainelDireito.Checked

            Case "CKBExibirEstrelas"
                CKBOpcoes_CKBExibirEstrelas.Checked = CKBExibirEstrelas.Checked

            Case "CKBOpcoes_CKBExibirEstrelas"
                CKBExibirEstrelas.Checked = CKBOpcoes_CKBExibirEstrelas.Checked

            Case "CKBExibirStatusGravado"
                CKBOpcoes_CKBExibirStatusGravado.Checked = CKBExibirStatusGravado.Checked

            Case "CKBOpcoes_CKBExibirStatusGravado"
                CKBExibirStatusGravado.Checked = CKBOpcoes_CKBExibirStatusGravado.Checked

            Case "CKBExibirFlag"
                CKBOpcoes_CKBExibirFlag.Checked = CKBExibirFlag.Checked

            Case "CKBOpcoes_CKBExibirFlag"
                CKBExibirFlag.Checked = CKBOpcoes_CKBExibirFlag.Checked

            Case "CKBExibirMaisDetalhes"
                CKBOpcoes_CKBExibirMaisDetalhes.Checked = CKBExibirMaisDetalhes.Checked

            Case "CKBOpcoes_CKBExibirMaisDetalhes"
                CKBExibirMaisDetalhes.Checked = CKBOpcoes_CKBExibirMaisDetalhes.Checked
        End Select

    End Sub


    Private Sub ButtonsContextMenu_Click(sender As Object, e As EventArgs)
        Dim x As Integer = System.Windows.Forms.Cursor.Position.X
        Dim y As Integer = System.Windows.Forms.Cursor.Position.Y

        Dim btn As Button = CType(sender, Button)
        'pMouse = System.Windows.Forms.Cursor.Position

        x -= btn.Width

        btn.ContextMenuStrip.Show(x, y)

    End Sub

    Private Sub ButtonsEtiquetaDeSubTitulo_Click(sender As Object, e As EventArgs) Handles CKBEtiquetaDeSubTitulo_Ocultar.Click, CKBEtiquetaDeSubTitulo_Legenda.Click, CKBEtiquetaDeSubTitulo_Resolucao.Click, CKBEtiquetaDeSubTitulo_Autor.Click, CKBEtiquetaDeSubTitulo_Album.Click, CKBEtiquetaDeSubTitulo_Tipo.Click, CKBEtiquetaDeSubTitulo_DataDeCriacao.Click, CKBEtiquetaDeSubTitulo_DatasRecentes.Click, CKBEtiquetaDeSubTitulo_Tamanho.Click

        Dim chk As CheckBox
        chk = CType(sender, CheckBox)
        Call ChecarEMarcarCheckBoxDeEtiquetas(chk)

    End Sub

    Private Sub ButtonsEtiquetaDeTitulo_Click(sender As Object, e As EventArgs) Handles CKBEtiquetaDeTitulo_Nome.Click, CKBEtiquetaDeTitulo_NomeEExtencao.Click, CKBEtiquetaDeTitulo_Legenda.Click, CKBEtiquetaDeTitulo_DataDeCriacao.Click, CKBEtiquetaDeTitulo_Tamanho.Click, CKBEtiquetaDeTitulo_Resolucao.Click, CKBEtiquetaDeTitulo_Autor.Click, CKBEtiquetaDeTitulo_Album.Click, CKBEtiquetaDeTitulo_DatasRecentes.Click

        Dim chk As CheckBox
        chk = CType(sender, CheckBox)
        Call ChecarEMarcarCheckBoxDeEtiquetas(chk)


    End Sub

    Private Sub ChecarEMarcarCheckBoxDeEtiquetas(chk As CheckBox)

        Dim chk_subcontrol As CheckBox
        For Each control In chk.Parent.Parent.Parent.Parent.Controls

            For Each subControl In control.Controls
                chk_subcontrol = subControl.Controls.Item(0).Controls.Item(0)

                If chk_subcontrol.Name <> chk.Name Then
                    chk_subcontrol.Checked = False
                    chk_subcontrol.Parent.BackColor = Color.Transparent
                    chk_subcontrol.Parent.Parent.BackColor = Color.Transparent
                End If

            Next
        Next

        CKBExibirMaisDetalhes.Checked = False
        CKBOpcoes_CKBExibirMaisDetalhes.Checked = False


    End Sub

    Private Sub ZerarCheckBoxDeEtiquetas(chk As CheckBox)

        Dim chk_subcontrol As CheckBox
        For Each control In chk.Parent.Parent.Parent.Parent.Controls

            For Each subControl In control.Controls
                chk_subcontrol = subControl.Controls.Item(0).Controls.Item(0)


                chk_subcontrol.Checked = False
                chk_subcontrol.Parent.BackColor = Color.Transparent
                chk_subcontrol.Parent.Parent.BackColor = Color.Transparent


            Next
        Next
    End Sub

    Private Sub CKBExibirMaisDetalhesAndCKBOpcoes_CKBExibirMaisDetalhes_Click(sender As Object, e As EventArgs) Handles CKBExibirMaisDetalhes.Click, CKBOpcoes_CKBExibirMaisDetalhes.Click
        ZerarCheckBoxDeEtiquetas(CKBEtiquetaDeTitulo_Nome)
        ZerarCheckBoxDeEtiquetas(CKBEtiquetaDeSubTitulo_Ocultar)
    End Sub

    Private Sub Buttons_MouseDown(sender As Object, e As MouseEventArgs) Handles CKBPainelEsquedo.MouseDown, CKBPainelDireito.MouseDown, CKBOpcoes_CKBPainelEsquedo.MouseDown, CKBOpcoes_CKBPainelDireito.MouseDown, CKBOpcoes_CKBExibirStatusGravado.MouseDown, CKBOpcoes_CKBExibirMaisDetalhes.MouseDown, CKBOpcoes_CKBExibirFlag.MouseDown, CKBOpcoes_CKBExibirEstrelas.MouseDown, CKBExibirStatusGravado.MouseDown, CKBExibirMaisDetalhes.MouseDown, CKBExibirFlag.MouseDown, CKBExibirEstrelas.MouseDown, CKBEtiquetaDeTitulo_Tamanho.MouseDown, CKBEtiquetaDeTitulo_Resolucao.MouseDown, CKBEtiquetaDeTitulo_NomeEExtencao.MouseDown, CKBEtiquetaDeTitulo_Nome.MouseDown, CKBEtiquetaDeTitulo_Legenda.MouseDown, CKBEtiquetaDeTitulo_DatasRecentes.MouseDown, CKBEtiquetaDeTitulo_DataDeCriacao.MouseDown, CKBEtiquetaDeTitulo_Autor.MouseDown, CKBEtiquetaDeTitulo_Album.MouseDown, CKBEtiquetaDeSubTitulo_Tipo.MouseDown, CKBEtiquetaDeSubTitulo_Tamanho.MouseDown, CKBEtiquetaDeSubTitulo_Resolucao.MouseDown, CKBEtiquetaDeSubTitulo_Ocultar.MouseDown, CKBEtiquetaDeSubTitulo_Legenda.MouseDown, CKBEtiquetaDeSubTitulo_DatasRecentes.MouseDown, CKBEtiquetaDeSubTitulo_DataDeCriacao.MouseDown, CKBEtiquetaDeSubTitulo_Autor.MouseDown, CKBEtiquetaDeSubTitulo_Album.MouseDown

    End Sub

    Private Sub Buttons_MouseMove(sender As Object, e As MouseEventArgs) Handles CKBPainelEsquedo.MouseMove, CKBPainelDireito.MouseMove, CKBOpcoes_CKBPainelEsquedo.MouseMove, CKBOpcoes_CKBPainelDireito.MouseMove, CKBOpcoes_CKBExibirStatusGravado.MouseMove, CKBOpcoes_CKBExibirMaisDetalhes.MouseMove, CKBOpcoes_CKBExibirFlag.MouseMove, CKBOpcoes_CKBExibirEstrelas.MouseMove, CKBExibirStatusGravado.MouseMove, CKBExibirMaisDetalhes.MouseMove, CKBExibirFlag.MouseMove, CKBExibirEstrelas.MouseMove, CKBEtiquetaDeTitulo_Tamanho.MouseMove, CKBEtiquetaDeTitulo_Resolucao.MouseMove, CKBEtiquetaDeTitulo_NomeEExtencao.MouseMove, CKBEtiquetaDeTitulo_Nome.MouseMove, CKBEtiquetaDeTitulo_Legenda.MouseMove, CKBEtiquetaDeTitulo_DatasRecentes.MouseMove, CKBEtiquetaDeTitulo_DataDeCriacao.MouseMove, CKBEtiquetaDeTitulo_Autor.MouseMove, CKBEtiquetaDeTitulo_Album.MouseMove, CKBEtiquetaDeSubTitulo_Tipo.MouseMove, CKBEtiquetaDeSubTitulo_Tamanho.MouseMove, CKBEtiquetaDeSubTitulo_Resolucao.MouseMove, CKBEtiquetaDeSubTitulo_Ocultar.MouseMove, CKBEtiquetaDeSubTitulo_Legenda.MouseMove, CKBEtiquetaDeSubTitulo_DatasRecentes.MouseMove, CKBEtiquetaDeSubTitulo_DataDeCriacao.MouseMove, CKBEtiquetaDeSubTitulo_Autor.MouseMove, CKBEtiquetaDeSubTitulo_Album.MouseMove

    End Sub

    Private Sub Buttons_MouseUp(sender As Object, e As MouseEventArgs) Handles CKBPainelEsquedo.MouseUp, CKBPainelDireito.MouseUp, CKBOpcoes_CKBPainelEsquedo.MouseUp, CKBOpcoes_CKBPainelDireito.MouseUp, CKBOpcoes_CKBExibirStatusGravado.MouseUp, CKBOpcoes_CKBExibirMaisDetalhes.MouseUp, CKBOpcoes_CKBExibirFlag.MouseUp, CKBOpcoes_CKBExibirEstrelas.MouseUp, CKBExibirStatusGravado.MouseUp, CKBExibirMaisDetalhes.MouseUp, CKBExibirFlag.MouseUp, CKBExibirEstrelas.MouseUp, CKBEtiquetaDeTitulo_Tamanho.MouseUp, CKBEtiquetaDeTitulo_Resolucao.MouseUp, CKBEtiquetaDeTitulo_NomeEExtencao.MouseUp, CKBEtiquetaDeTitulo_Nome.MouseUp, CKBEtiquetaDeTitulo_Legenda.MouseUp, CKBEtiquetaDeTitulo_DatasRecentes.MouseUp, CKBEtiquetaDeTitulo_DataDeCriacao.MouseUp, CKBEtiquetaDeTitulo_Autor.MouseUp, CKBEtiquetaDeTitulo_Album.MouseUp, CKBEtiquetaDeSubTitulo_Tipo.MouseUp, CKBEtiquetaDeSubTitulo_Tamanho.MouseUp, CKBEtiquetaDeSubTitulo_Resolucao.MouseUp, CKBEtiquetaDeSubTitulo_Ocultar.MouseUp, CKBEtiquetaDeSubTitulo_Legenda.MouseUp, CKBEtiquetaDeSubTitulo_DatasRecentes.MouseUp, CKBEtiquetaDeSubTitulo_DataDeCriacao.MouseUp, CKBEtiquetaDeSubTitulo_Autor.MouseUp, CKBEtiquetaDeSubTitulo_Album.MouseUp

    End Sub




    'Private Sub NovaPastaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaPastaToolStripMenuItem.Click, NovaPastaProcessoToolStripMenuItem.Click
    '    Dim menuItem As ToolStripMenuItem
    '    menuItem = CType(sender, ToolStripMenuItem)

    '    BTNPainelEsquedo.BackgroundImage = menuItem.Image
    'End Sub








    '  https://imasters.com.br/dotnet/programacao-orientada-objetos-em-10-licoes-praticas-parte-04
    '  http://www.macoratti.net/vbn_evnt.htm


    ' https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-inherit-from-existing-windows-forms-controls
    ' https://social.msdn.microsoft.com/Forums/pt-BR/86e1175f-c9bd-4265-8fb1-1a60a28a0edd/eventos-em-um-user-control?forum=vsvbasicpt
    ' https://www.devmedia.com.br/desenvolvimento-de-user-control-com-propriedade-dinamica-parte-1/24197

End Class
