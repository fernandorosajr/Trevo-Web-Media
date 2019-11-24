Imports System.IO
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.ComponentModel

Public Class MainForm
    Dim DriveMaster As DriveInfo

    ' Carregar Controles acessorios
    ' -------------------------------------------------------
    Public controlPersonalListView As New ControlVerListas
    Public painel_BibliotecaDeMidias As New ControlPainel_BibliotecaDeMidias
    Public painel_Desktop As New ControlPainel_Desktop
    Public painel_Filtro As New ControlPainel_Filtro
    Public painel_MidiaAberta As New ControlPainel_MidiaAberta
    Public painel_MidiasAtivas As New ControlPainel_MidiasAtivas
    Public painel_PastaIsolada As New ControlPainel_PastaIsolada
    Public painel_Atividades As New ControlPainel_Atividades
    Public painel_Detalhes As New ControlPainel_Detalhes
    Public painel_Acoes As New ControlPainel_Acoes
    Public TooBarMenu As New Control_MenuBar
    Public _controlSelectFileAndFolderPanel As New ControlSelectFileAndFoldePanel





    ' -------------------------------------------------------

    Dim pMouse As Point
    Dim state As Integer
    Dim px, py As Integer
    Dim mover As Boolean

    Dim me_w, me_h As Integer
    Dim me_redim As Boolean

    Declare Function SetSysColors Lib "user32" Alias _
"SetSysColors" (ByVal nChanges As Long, lpSysColor As _
Long, lpColorValues As Long) As Long

    Const COLOR_ACTIVEBORDER = 10 'o moldura da janela ativa

    'Taken from newsgroup with Jacob Grass a little bit changed for VS2003
    Private Sub form1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
        'Dim g As Graphics = e.Graphics
        'Dim pen As New Pen(Color.Gainsboro, 2.0)

        'For Each ctr As Control In Me.Controls
        '    If TypeOf ctr Is TextBox Then
        '        g.DrawRectangle(pen, New _
        '        Rectangle(ctr.Location, ctr.Size))
        '    End If
        'Next

        'pen.Dispose()
    End Sub



    Private Sub Button38_Click(sender As System.Object, e As System.EventArgs) Handles Button38.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button37_Click(sender As System.Object, e As System.EventArgs) Handles Button37.Click
        Call winstate()

    End Sub

    Private Sub Button36_Click(sender As System.Object, e As System.EventArgs) Handles Button36.Click
        Me.Close()
    End Sub

    Private Sub winstate()
        If state = 0 Then
            Me.WindowState = FormWindowState.Maximized
            state = 1

        ElseIf state = 1 Then
            Me.WindowState = FormWindowState.Normal
            state = 0

        End If

    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As System.EventArgs) Handles Label1.DoubleClick
        Call winstate()

    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - px, Me.MousePosition.Y - Me.Location.Y - py))

        End If
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub


    Private Sub Label1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseUp
        mover = False

    End Sub

    Private Sub Form1_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Label1.Text = Me.Text


    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For fadeout = 90 To 10 Step -10
            Me.Opacity = (fadeout / 50)
            Me.Refresh()
            Threading.Thread.Sleep(10)

        Next
    End Sub



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' TODO: Se um componente construido herdar ...
        ' ...o outro construido ele pode interagir um com o outro.

        PanelRecebeBiblio.Controls.Add(painel_BibliotecaDeMidias)
        painel_BibliotecaDeMidias.Dock = DockStyle.Fill
        painel_BibliotecaDeMidias.Visible = True

        Panel_Recebe_Filtro.Controls.Add(painel_Filtro)
        painel_Filtro.Dock = DockStyle.Fill
        painel_Filtro.Visible = True

        Panel_RecebeExplorer.Controls.Add(painel_Desktop)
        painel_Desktop.Dock = DockStyle.Fill
        painel_Desktop.Visible = True

        Panel_RecebeMidiasAtivas.Controls.Add(painel_MidiasAtivas)
        painel_MidiasAtivas.Dock = DockStyle.Fill
        painel_MidiasAtivas.Visible = True

        PanelAtividade.Controls.Add(painel_Atividades)
        painel_Atividades.Dock = DockStyle.Fill
        painel_Atividades.Visible = True

        PanelDetalhe.Controls.Add(painel_Detalhes)
        painel_Detalhes.Dock = DockStyle.Fill
        painel_Detalhes.Visible = True

        PanelAcoes.Controls.Add(painel_Acoes)
        painel_Acoes.Dock = DockStyle.Fill
        painel_Acoes.Visible = True

        Panel_MenuBar.Controls.Add(TooBarMenu)
        TooBarMenu.Dock = DockStyle.Fill
        TooBarMenu.Visible = True

        PanelLoad_ControlSelectFileAndFoldePanel.Controls.Add(_controlSelectFileAndFolderPanel)
        _controlSelectFileAndFolderPanel.Dock = DockStyle.Fill
        _controlSelectFileAndFolderPanel.Visible = True

        ' Painel_MidiasAtivas.TVMedias_NodeMouseClick(sender, e)

        For fadein = 0.0 To 1.1 Step 0.1
            Me.Opacity = fadein
            Me.Refresh()
            Threading.Thread.Sleep(10)
        Next
    End Sub
    Public Function AdcionarItemNoView(Drive As DriveInfo, Numero As Integer)
        ' Cria os suobjetos semelhantes a pastas do picasa
        PanelRecebe.Controls.Add(controlPersonalListView)
        controlPersonalListView.Visible = True
        controlPersonalListView.Dock = DockStyle.Fill
    End Function

    Private Sub ClickingMouseRedim()
        me_w = Me.Width
        me_h = Me.Height
        me_redim = True
    End Sub
    Private Sub PanelMDir_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMDir.MouseDown
        Call ClickingMouseRedim()


    End Sub

    Private Sub PanelMDir_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMDir.MouseMove
        If me_redim Then
            Me.Width = Me.Size.Width + e.X

        End If

    End Sub

    Private Sub PanelMDir_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMDir.MouseUp
        me_redim = False

    End Sub

    Private Sub PanelMBase_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMBase.MouseDown
        Call ClickingMouseRedim()

    End Sub

    Private Sub PanelMBase_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMBase.MouseMove
        If me_redim Then
            Me.Height = Me.Size.Height + e.Y

        End If
    End Sub

    Private Sub PanelMBase_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMBase.MouseUp
        me_redim = False

    End Sub

    Private Sub PanelPonta_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelPonta.MouseDown
        Call ClickingMouseRedim()
    End Sub

    Private Sub PanelPonta_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelPonta.MouseMove
        If me_redim Then
            Me.Height = Me.Size.Height + e.Y
            Me.Width = Me.Size.Width + e.X
        End If


    End Sub

    Private Sub PanelPonta_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelPonta.MouseUp
        me_redim = False
    End Sub

    Private Sub PanelMEsq_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMEsq.MouseDown
        me_w = Me.Width
        me_h = Me.Height

        px = e.X
        py = e.Y

        me_redim = True
    End Sub

    Private Sub PanelMEsq_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMEsq.MouseMove
        If me_redim Then

            'Me.Size = New Point(Me.Size.Width - e.X, me_h)

            If e.X < px Then
                ' Label1.Text = px - e.X
            Else

            End If
            Me.Size = New Point(me_w - e.X, me_h)


            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - px, Me.MousePosition.Y - Me.Location.Y - py))


            '  Label1.Text = e.X

        End If
    End Sub

    Private Sub PanelMEsq_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMEsq.MouseUp
        me_redim = False
    End Sub

    Private Sub RB_Explorerr_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_Explorerr.CheckedChanged

        Panel_MediasExplorer.Visible = Not (RB_Explorerr.Checked)

        Panel_RecebeExplorer.Visible = RB_Explorerr.Checked
        ' PanelEnvolveMidiaAberta.Visible = True
        ' SPRedimVisualizarMidia.Visible = True



    End Sub

    Private Sub RB_Midias_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_Midias.CheckedChanged
        Panel_MediasExplorer.Visible = RB_Midias.Checked
        Panel_RecebeExplorer.Visible = Not (RB_Midias.Checked)

        'If RB_Bibliotecas.Checked Then
        '    PanelEnvolveMidiaAberta.Visible = False
        '    SPRedimVisualizarMidia.Visible = False

        'Else
        '    PanelEnvolveMidiaAberta.Visible = True
        '    SPRedimVisualizarMidia.Visible = True
        'End If
    End Sub

    Private Sub ChecarCheckBoxs()
        Dim ChckB As New CheckBox



        For Each ctr As Control In Me.FLPMenu.Controls
            If TypeOf ctr Is CheckBox Then
                '  MsgBox(this.Name.ToString)

                ChckB = ctr
                If ChckB.Checked = True Then
                    Panel_MenuBar.Visible = True
                    Exit For
                Else
                    Panel_MenuBar.Visible = False
                End If
                'g.DrawRectangle(Pen, New  _
                'Rectangle(ctr.Location, ctr.Size))
            End If


        Next
    End Sub

    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click
        Call ChecarCheckBoxs()
        If PanelHome.Visible Then
            PanelHome.Visible = False
        Else
            PanelHome.Visible = True
        End If
    End Sub

    Private Sub ChBExplorar_Click(sender As Object, e As System.EventArgs) Handles ChBExplorar.Click

        If sender.Checked = True Then
            ChBInicio.Checked = False
            ChBExplorar.Checked = True
            ChBOrganizar.Checked = False
            ChBGravar.Checked = False
            ChbPesquisar.Checked = False
            ChBExibir.Checked = False
            ChBAjuda.Checked = False

        Else

            ChBInicio.Checked = False
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = False
            ChBGravar.Checked = False
            ChbPesquisar.Checked = False
            ChBExibir.Checked = False
            ChBAjuda.Checked = False
        End If

        Call ChecarCheckBoxs()
    End Sub

    Private Sub ChBInicio_Click(sender As Object, e As System.EventArgs) Handles ChBInicio.Click

        'MsgBox(e)
        'ChBInicio.Checked

        If sender.Checked = True Then

            ChBInicio.Checked = True
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = False
            ChBGravar.Checked = False
            ChbPesquisar.Checked = False
            ChBExibir.Checked = False
            ChBAjuda.Checked = False

        Else
            ChBInicio.Checked = False
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = False
            ChBGravar.Checked = False
            ChbPesquisar.Checked = False
            ChBExibir.Checked = False
            ChBAjuda.Checked = False




        End If
        Call ChecarCheckBoxs()
    End Sub

    Private Sub ChBOrganizar_Click(sender As Object, e As System.EventArgs) Handles ChBOrganizar.Click


        If sender.Checked = True Then
            ChBInicio.Checked = False
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = True
            ChBGravar.Checked = False
            ChbPesquisar.Checked = False
            ChBExibir.Checked = False
            ChBAjuda.Checked = False

        Else
            ChBInicio.Checked = False
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = False
            ChBGravar.Checked = False
            ChbPesquisar.Checked = False
            ChBExibir.Checked = False
            ChBAjuda.Checked = False
        End If
        Call ChecarCheckBoxs()

    End Sub

    Private Sub ChBGravar_Click(sender As Object, e As System.EventArgs) Handles ChBGravar.Click


        If sender.Checked = True Then
            ChBInicio.Checked = False
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = False
            ChBGravar.Checked = True
            ChbPesquisar.Checked = False
            ChBExibir.Checked = False
            ChBAjuda.Checked = False
        Else

            ChBInicio.Checked = False
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = False
            ChBGravar.Checked = False
            ChbPesquisar.Checked = False
            ChBExibir.Checked = False
            ChBAjuda.Checked = False
        End If
        Call ChecarCheckBoxs()

    End Sub

    Private Sub ChbPesquisar_Click(sender As Object, e As System.EventArgs) Handles ChbPesquisar.Click


        If sender.Checked = True Then
            ChBInicio.Checked = False
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = False
            ChBGravar.Checked = False
            ChbPesquisar.Checked = True
            ChBExibir.Checked = False
            ChBAjuda.Checked = False
        Else
            ChBInicio.Checked = False
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = False
            ChBGravar.Checked = False
            ChbPesquisar.Checked = False
            ChBExibir.Checked = False
            ChBAjuda.Checked = False
        End If

        Call ChecarCheckBoxs()

    End Sub



    Private Sub ChBExibir_Click(sender As Object, e As System.EventArgs) Handles ChBExibir.Click


        If sender.Checked = True Then
            ChBInicio.Checked = False
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = False
            ChBGravar.Checked = False
            ChbPesquisar.Checked = False
            ChBExibir.Checked = True
            ChBAjuda.Checked = False
        Else
            ChBInicio.Checked = False
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = False
            ChBGravar.Checked = False
            ChbPesquisar.Checked = False
            ChBExibir.Checked = False
            ChBAjuda.Checked = False
        End If

        Call ChecarCheckBoxs()

    End Sub



    Private Sub ChBAjuda_Click(sender As Object, e As System.EventArgs) Handles ChBAjuda.Click

        If sender.Checked = True Then
            ChBInicio.Checked = False
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = False
            ChBGravar.Checked = False
            ChbPesquisar.Checked = False
            ChBExibir.Checked = False
            ChBAjuda.Checked = True
        Else
            ChBInicio.Checked = False
            ChBExplorar.Checked = False
            ChBOrganizar.Checked = False
            ChBGravar.Checked = False
            ChbPesquisar.Checked = False
            ChBExibir.Checked = False
            ChBAjuda.Checked = False
        End If

        Call ChecarCheckBoxs()

    End Sub





    'Private Sub CHKExibirArvores_CheckedChanged(sender As Object, e As EventArgs)

    '    'Panel_Recebe_Filtro.Visible = CHKExibirArvores.Checked
    '    PanelMedia.Visible = Not (Panel_Recebe_Filtro.Visible)

    'End Sub




    Private Sub ChkWinStyle_CheckStateChanged(sender As Object, e As EventArgs) Handles ChkWinStyle.CheckStateChanged
        If ChkWinStyle.Checked Then

            For fadeout = 90 To 10 Step -10
                Me.Opacity = (fadeout / 50)
                Me.Refresh()
                Threading.Thread.Sleep(10)

                If fadeout = 10 Then
                    Me.Opacity = 0

                    Me.FormBorderStyle = FormBorderStyle.Sizable
                    Me.MaximizeBox = True
                    Me.MinimizeBox = True
                    Me.ShowIcon = True
                    PanelTitleBar.Visible = False
                    PanelFormMargDir.Visible = False
                    PanelMBase.Visible = False
                    PanelMEsq.Visible = False
                    PanelMDir.Visible = False

                    Call Form_Resize()
                End If
            Next

            For fadein = 0.0 To 1.1 Step 0.1
                Me.Opacity = fadein
                Me.Refresh()
                Threading.Thread.Sleep(10)
            Next

        Else

            For fadeout = 90 To 10 Step -10
                Me.Opacity = (fadeout / 50)
                Me.Refresh()
                Threading.Thread.Sleep(10)

                If fadeout = 10 Then
                    Me.Opacity = 0

                    PanelTitleBar.Visible = True
                    PanelFormMargDir.Visible = True
                    PanelMBase.Visible = True
                    PanelMEsq.Visible = True
                    PanelMDir.Visible = True
                    Call Form_Resize()
                End If

            Next

            Me.FormBorderStyle = FormBorderStyle.None
            For fadein = 0.0 To 1.1 Step 0.1
                Me.Opacity = fadein
                Me.Refresh()
                Threading.Thread.Sleep(10)
            Next

        End If

    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Call Form_Resize()

    End Sub
    Sub Form_Resize()
        If Me.FormBorderStyle = FormBorderStyle.None Then
            PanelHome.Top = PanelMainMenu.Top + PanelMainMenu.Height + 1
            PanelHome.Width = Me.Width - 4
            PanelHome.Height = (Me.Height - (PanelMainMenu.Top + PanelMainMenu.Height + 1)) - 2
            PanelHome.Left = 2
        Else

            PanelHome.Top = PanelMainMenu.Top + PanelMainMenu.Height + 1
            PanelHome.Width = Me.Width - 16
            PanelHome.Height = (Me.Height - (PanelMainMenu.Top + PanelMainMenu.Height + 1)) - 39
            PanelHome.Left = 0
        End If

    End Sub

    Private Sub RBAtividade_CheckedChanged(sender As Object, e As EventArgs) Handles RBAtividade.CheckedChanged
        PanelAtividade.Visible = RBAtividade.Checked

    End Sub

    Private Sub RBDetalhe_CheckedChanged(sender As Object, e As EventArgs) Handles RBDetalhe.CheckedChanged
        PanelDetalhe.Visible = RBDetalhe.Checked

    End Sub

    Private Sub Button39_MouseLeave(sender As Object, e As EventArgs) Handles Button39.MouseLeave
        PanelHome.BackColor = Button39.BackColor
    End Sub

    Private Sub RBTNWelcome_CheckedChanged(sender As Object, e As EventArgs) Handles RBTNWelcome.CheckedChanged

        PanelWelcome.Visible = RBTNWelcome.Checked

    End Sub

    Private Sub RBTNSofts_CheckedChanged(sender As Object, e As EventArgs) Handles RBTNSofts.CheckedChanged
        PanelSofts.Visible = RBTNSofts.Checked

    End Sub

    Private Sub RBTNEnd_CheckedChanged(sender As Object, e As EventArgs) Handles RBTNEnd.CheckedChanged

        If RBTNEnd.Checked = True Then
            Dim Q = MsgBox("Tem certeza que deseja sair?", MsgBoxStyle.YesNo, Me.Text)
            If Q = 6 Then
                Me.Close()
                End
            ElseIf Q = 7 Then
                RBTNWelcome.Checked = True
                RBTNWelcome.Checked = False
            End If


        End If


    End Sub

    Private Sub Button39_MouseEnter(sender As Object, e As EventArgs) Handles Button39.MouseEnter
        PanelHome.BackColor = Color.FromName("Highlight")
    End Sub

    Private Sub RBTNSkin_CheckedChanged(sender As Object, e As EventArgs) Handles RBTNSkin.CheckedChanged
        PanelSkin.Visible = RBTNSkin.Checked
    End Sub

    Private Sub ControlInterruptor1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub BTNMenu01_Click(sender As Object, e As EventArgs) Handles BTNMenu01.Click



        'CTMenuVisualizacao.Top = Int(pMouse.Y)  ' + BTNMenu01.Height
        'CTMenuVisualizacao.Left = Int(pMouse.X)
        CTMenuVisualizacao.Show(pMouse)


    End Sub

    Private Sub RBAcoes_CheckedChanged(sender As Object, e As EventArgs) Handles RBAcoes.CheckedChanged
        PanelAcoes.Visible = RBAcoes.Checked
        ' PanelSelecao.Visible = Not (RBAcoes.Checked)
    End Sub

    Private Sub Panel225_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub Panel226_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub RBMidiaAtiva_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub RBBiblioteca_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChBFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles ChBFiltro.CheckedChanged
        Panel_Recebe_Filtro.Visible = ChBFiltro.Checked
        Splitter7.Visible = ChBFiltro.Checked


    End Sub

    Private Sub PanelRecebe_Paint(sender As Object, e As PaintEventArgs) Handles PanelRecebe.Paint

    End Sub

    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        Form1.Show()

    End Sub

    Private Sub RB_Por_Arquivos_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RB_Bibliotecas_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Bibliotecas.CheckedChanged

        'PanelMidiaAtiva.Visible = Not (RB_ExibeDesktopExplorer.Checked)
        PanelRecebeBiblio.Visible = RB_Bibliotecas.Checked
        Panel_RecebeMidiasAtivas.Visible = Not (RB_Bibliotecas.Checked)

        ' PanelEnvolveMidiaAberta.Visible = False
        ' SPRedimVisualizarMidia.Visible = False




    End Sub

    Private Sub RB_ExibePanelMidiaAtiva_CheckedChanged(sender As Object, e As EventArgs) Handles RB_ExibePanelMidiaAtiva.CheckedChanged
        'PanelMidiaAtiva.Visible = RB_ExibePanelMidiaAtiva.Checked


        PanelRecebeBiblio.Visible = Not (RB_ExibePanelMidiaAtiva.Checked)
        Panel_RecebeMidiasAtivas.Visible = RB_ExibePanelMidiaAtiva.Checked

        ' PanelEnvolveMidiaAberta.Visible = True
        ' SPRedimVisualizarMidia.Visible = True



    End Sub

    Private Sub TVFiles_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PanelRecebe.Controls.Remove(controlPersonalListView)
    End Sub



    Private Sub BTNMenu01_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNMenu01.MouseMove

        pMouse = System.Windows.Forms.Cursor.Position
    End Sub

    Private Sub RB_Fechar_Modo_Isolamento_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RB_Modo_Isolamento_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub TVFiles_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    '    RB_Modo_Isolamento.Visible = True
    '    RB_Fechar_Modo_Isolamento.Visible = True
    '    PanelModo_Isolamento.Visible = True
    '    SPRedimVisualizarMidia.Visible = False
    '    PanelEnvolveMidiaAberta.Visible = False






    'End Sub

    Private Sub RBArquivos_CheckedChanged(sender As Object, e As EventArgs) Handles RBArquivos.CheckedChanged
        If sender.checked Then

            PanelArquivos.Visible = True
            PanelLivros.Visible = False
            PanelFoto.Visible = False
            PanelVideos.Visible = False
            PanelMusica.Visible = False
            PanelMidia.Visible = False

        Else

            PanelArquivos.Visible = False


        End If

    End Sub

    Private Sub RBMidias_CheckedChanged(sender As Object, e As EventArgs) Handles RBMidias.CheckedChanged
        If sender.checked Then

            PanelArquivos.Visible = False

            PanelLivros.Visible = False
            PanelFoto.Visible = False
            PanelVideos.Visible = False
            PanelMusica.Visible = False
            PanelMidia.Visible = True

        Else

            PanelMidia.Visible = False


        End If

    End Sub

    Private Sub RBMusicas_CheckedChanged(sender As Object, e As EventArgs) Handles RBMusicas.CheckedChanged
        If sender.checked Then

            PanelArquivos.Visible = False

            PanelLivros.Visible = False
            PanelFoto.Visible = False
            PanelVideos.Visible = False
            PanelMusica.Visible = True
            PanelMidia.Visible = False

        Else

            PanelMusica.Visible = False


        End If
    End Sub

    Private Sub RBDocumentos_CheckedChanged(sender As Object, e As EventArgs) Handles RBDocumentos.CheckedChanged
        If sender.checked Then

            PanelArquivos.Visible = False

            PanelLivros.Visible = True
            PanelFoto.Visible = False
            PanelVideos.Visible = False
            PanelMusica.Visible = False
            PanelMidia.Visible = False

        Else

            PanelLivros.Visible = False


        End If

    End Sub

    Private Sub RBImagens_CheckedChanged(sender As Object, e As EventArgs) Handles RBImagens.CheckedChanged
        If sender.checked Then

            PanelArquivos.Visible = False

            PanelLivros.Visible = False
            PanelFoto.Visible = True
            PanelVideos.Visible = False
            PanelMusica.Visible = False
            PanelMidia.Visible = False

        Else

            PanelFoto.Visible = False


        End If
    End Sub

    Private Sub RBVideos_CheckedChanged(sender As Object, e As EventArgs) Handles RBVideos.CheckedChanged
        If sender.checked Then

            PanelArquivos.Visible = False

            PanelLivros.Visible = False
            PanelFoto.Visible = False
            PanelVideos.Visible = True
            PanelMusica.Visible = False
            PanelMidia.Visible = False

        Else

            PanelVideos.Visible = False


        End If
    End Sub

    'Private Sub RB_Explorer_GotFocus(sender As Object, e As EventArgs) Handles RB_Explorer.GotFocus
    '    RB_Modo_Isolamento.Visible = False
    '    RB_Fechar_Modo_Isolamento.Visible = False
    '    PanelModo_Isolamento.Visible = False
    'End Sub

    'Private Sub RB_Fechar_Modo_Isolamento_Click(sender As Object, e As EventArgs)
    '    RB_Modo_Isolamento.Visible = False
    '    RB_Fechar_Modo_Isolamento.Visible = False
    '    PanelModo_Isolamento.Visible = False

    '    SPRedimVisualizarMidia.Visible = True
    '    PanelEnvolveMidiaAberta.Visible = True
    'End Sub
End Class
