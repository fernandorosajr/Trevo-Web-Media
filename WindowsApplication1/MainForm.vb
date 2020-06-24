Imports System.IO
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.ComponentModel

Public Class MainForm
    Dim DriveMaster As DriveInfo

    Public SelectedFoldersAndFiles As New List(Of Object)


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
    Public toolBar_Menu As New Control_MenuBar
    Public toolBar_ViewMenu As New Control_ViewMenuBar
    Public toolBar_BurnMenu As New Control_BurnMenuBar
    Public toolBar_OrganizeMenu02 As New Control_OrganizeMenuBar

    Public painel_Clipboard As New ControlPainel_Clipboard
    Public painel_PastaProcesso As New ControlPainel_PastasProcesso
    Public painel_Selected As New ControlPainel_Selected

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

    'Private Sub Form1_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
    '    Label1.Text = Me.Text

    'End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For fadeout = 90 To 10 Step -10
            Me.Opacity = (fadeout / 50)
            Me.Refresh()
            Threading.Thread.Sleep(10)

        Next
    End Sub



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' https://www.codeproject.com/Articles/14801/How-to-skin-scrollbars-for-Panels-in-C

        'Panel_Recebe_Filtro.AutoSize = True

        ' TODO: Se um componente construido herdar ...
        ' ...o outro construido ele pode interagir um com o outro.

        Label1.Text = Me.Text

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

        Panel_MenuBar.Controls.Add(toolBar_Menu)
        toolBar_Menu.Dock = DockStyle.Fill
        toolBar_Menu.Visible = False

        Panel_MenuBar.Controls.Add(toolBar_ViewMenu)
        toolBar_ViewMenu.Dock = DockStyle.Fill
        toolBar_ViewMenu.Visible = False

        Panel_MenuBar.Controls.Add(toolBar_BurnMenu)
        toolBar_BurnMenu.Dock = DockStyle.Fill
        toolBar_BurnMenu.Visible = False

        Panel_MenuBar.Controls.Add(toolBar_OrganizeMenu02)
        toolBar_OrganizeMenu02.Dock = DockStyle.Fill
        toolBar_OrganizeMenu02.Visible = False

        PanelLoad_ControlSelectFileAndFoldePanel.Controls.Add(_controlSelectFileAndFolderPanel)
        _controlSelectFileAndFolderPanel.Dock = DockStyle.Fill
        _controlSelectFileAndFolderPanel.Visible = True

        Panel_RecebeClipboad.Controls.Add(painel_Clipboard)
        painel_Clipboard.Dock = DockStyle.Fill
        painel_Clipboard.Visible = True

        Panel_RecebeSelecao.Controls.Add(painel_Selected)
        painel_Selected.Dock = DockStyle.Fill
        painel_Selected.Visible = True

        Panel_RecebePastaProcesso.Controls.Add(painel_PastaProcesso)
        painel_PastaProcesso.Dock = DockStyle.Fill
        painel_PastaProcesso.Visible = True

        ' Painel_MidiasAtivas.TVMedias_NodeMouseClick(sender, e)

        For fadein = 0.0 To 1.1 Step 0.1
            Me.Opacity = fadein
            Me.Refresh()
            Threading.Thread.Sleep(10)
        Next


        Dim path As String = "C:\Minha Pasta\"
        Dim folder As DirectoryInfo
        Dim file As FileInfo
        For x = 0 To 20

            folder = New DirectoryInfo(path & "Nova Pasta " & x)
            SelectedFoldersAndFiles.Add(folder)

            For y = 0 To 20
                file = New FileInfo(folder.FullName & "\" & "Arquivo " & y & ".jpg")
                SelectedFoldersAndFiles.Add(file)
            Next

            For y = 0 To 20
                file = New FileInfo(folder.FullName & "\" & "Documento Trevo Writer " & y & ".docx")
                SelectedFoldersAndFiles.Add(file)
            Next
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

    Private Sub RB_Explorerr_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_Explorer.CheckedChanged

        Panel_MediasExplorer.Visible = Not (RB_Explorer.Checked)
        Panel_RecebeExplorer.Visible = RB_Explorer.Checked
        Panel_Recebe_Filtro.Visible = Not (RB_Explorer.Checked)

        Panel_RecebeClipboad.Visible = Not (RB_Explorer.Checked)
        Panel_RecebeSelecao.Visible = Not (RB_Explorer.Checked)

        Panel_RecebePastaProcesso.Visible = Not (RB_Explorer.Checked)

        ' PanelEnvolveMidiaAberta.Visible = True
        ' SPRedimVisualizarMidia.Visible = True

        If RB_Explorer.Checked = True Then
            RB_Explorer.Image = My.Resources.computer_Hover35
        Else
            RB_Explorer.Image = My.Resources.computer35

        End If

    End Sub

    Private Sub RB_Midias_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_Midias.CheckedChanged
        Panel_MediasExplorer.Visible = RB_Midias.Checked
        Panel_RecebeExplorer.Visible = Not (RB_Midias.Checked)
        Panel_Recebe_Filtro.Visible = Not (RB_Midias.Checked)

        Panel_RecebeClipboad.Visible = Not (RB_Midias.Checked)
        Panel_RecebeSelecao.Visible = Not (RB_Midias.Checked)
        Panel_RecebePastaProcesso.Visible = Not (RB_Midias.Checked)

        If RB_Midias.Checked = True Then
            RB_Midias.Image = My.Resources.dvd_face6_Hover

        Else
            RB_Midias.Image = My.Resources.dvd_face6
        End If


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
        Dim _visible As Boolean


        For Each ctr As Control In Me.FLPMenu.Controls
            If TypeOf ctr Is CheckBox Then
                '  MsgBox(this.Name.ToString)

                ChckB = ctr

                ' Panel_MenuBar.Visible = False
                If ChckB.Checked = True Then
                    _visible = True
                    Exit For
                Else
                    _visible = False
                End If
                'g.DrawRectangle(Pen, New  _
                'Rectangle(ctr.Location, ctr.Size))
            End If
        Next

        Panel_MenuBar.Visible = _visible

    End Sub

    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click
        Call ChecarCheckBoxs()
        If PanelHome.Visible Then
            PanelHome.Visible = False
        Else
            PanelHome.Visible = True
        End If
    End Sub

    Private Sub MenuItem_Click(sender As Object, e As System.EventArgs) Handles ChBInicio.Click, ChBOrganizar.Click, ChBGravar.Click, ChBExibir.Click

        Dim chk As Object

        If sender.GetType.Name.ToString = "CheckBox" Then
            chk = CType(sender, CheckBox)

        Else
            MsgBox(sender.name.ToString)
            chk = CType(sender, Object)
        End If

        'ChBInicio.Checked = False
        'ChBOrganizar.Checked = False
        'ChBGravar.Checked = False
        'ChBExibir.Checked = False

        'If sender.Checked = True Then
        '    chk.Checked = True
        'Else
        '    chk.Checked = False

        'End If
        Dim ChckB As New Object

        For Each ctr As Control In Me.FLPMenu.Controls

            If TypeOf ctr Is CheckBox Then
                ChckB = ctr

                If ChckB.Name <> chk.name Then
                    '    ChckB.Checked = chk.Checked

                    'Else
                    ChckB.Checked = False

                End If
            End If
        Next

        Call ChecarCheckBoxs()

    End Sub

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
        CTMenuVisualizacao.Show(BTNMenu01, 0, BTNMenu01.Height) '(pMouse)


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

    Private Sub PanelRecebe_Paint(sender As Object, e As PaintEventArgs) Handles PanelRecebe.Paint

    End Sub

    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        ' Form1.Show()
        ' FRMDialogConflictingFolders.ShowDialog()
        FRMDialogFileConflictForm.ShowDialog()

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

    Private Sub ChBInicio_CheckedChanged(sender As Object, e As EventArgs) Handles ChBInicio.CheckedChanged, ChBOrganizar.CheckedChanged, ChBGravar.CheckedChanged, ChBExibir.CheckedChanged
        Dim chk As CheckBox

        chk = CType(sender, CheckBox)

        toolBar_Menu.Visible = ChBInicio.Checked
        toolBar_ViewMenu.Visible = ChBExibir.Checked
        toolBar_BurnMenu.Visible = ChBGravar.Checked
        toolBar_OrganizeMenu02.Visible = ChBOrganizar.Checked

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

    Private Sub CheckBox19_Click(sender As Object, e As EventArgs) Handles CheckBox19.Click
        FRMDialogDecide.ShowDialog()

    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged

    End Sub

    Private Sub RadioButton61_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton61.CheckedChanged

    End Sub

    Private Sub CheckBox20_Click(sender As Object, e As EventArgs) Handles CheckBox20.Click

        FRMDialogRenameCriterion.SelectedFoldersAndFiles.Clear()
        FRMDialogRenameCriterion.SelectedFoldersAndFiles.AddRange(SelectedFoldersAndFiles)
        FRMDialogRenameCriterion.FileExemple = "C:\Minha Pasta\Nome Antigo.txt"
        FRMDialogRenameCriterion.ShowDialog()

    End Sub

    Private Sub CheckBox21_Click(sender As Object, e As EventArgs) Handles CheckBox21.Click
        FRMDialogConflictingFolders.ShowDialog()

    End Sub

    Private Sub RB_Midias_MouseHover(sender As Object, e As EventArgs) Handles RB_Midias.MouseHover
        RB_Midias.Image = My.Resources.dvd_face6_Hover
    End Sub

    Private Sub RB_Midias_MouseMove(sender As Object, e As MouseEventArgs) Handles RB_Midias.MouseMove
        RB_Midias.Image = My.Resources.dvd_face6_Hover

    End Sub

    Private Sub RB_Midias_MouseLeave(sender As Object, e As EventArgs) Handles RB_Midias.MouseLeave
        If RB_Midias.Checked = False Then
            RB_Midias.Image = My.Resources.dvd_face6

        End If

    End Sub

    Private Sub RB_Explorer_MouseHover(sender As Object, e As EventArgs) Handles RB_Explorer.MouseHover
        RB_Explorer.Image = My.Resources.computer_Hover35

    End Sub

    Private Sub RB_Explorer_MouseLeave(sender As Object, e As EventArgs) Handles RB_Explorer.MouseLeave
        If RB_Explorer.Checked = False Then
            RB_Explorer.Image = My.Resources.computer35
        End If
    End Sub

    Private Sub RB_Explorer_MouseMove(sender As Object, e As MouseEventArgs) Handles RB_Explorer.MouseMove
        RB_Explorer.Image = My.Resources.computer_Hover35

    End Sub

    Private Sub RB_PastaProcesso_CheckedChanged(sender As Object, e As EventArgs) Handles RB_PastaProcesso.CheckedChanged
        If RB_PastaProcesso.Checked = True Then
            RB_PastaProcesso.Image = My.Resources.pastaProcesso35_Hover
        Else
            RB_PastaProcesso.Image = My.Resources.pastaProcesso35

        End If

        Panel_MediasExplorer.Visible = Not (RB_PastaProcesso.Checked)
        Panel_RecebeExplorer.Visible = Not (RB_PastaProcesso.Checked)
        Panel_Recebe_Filtro.Visible = Not (RB_PastaProcesso.Checked)

        Panel_RecebeClipboad.Visible = Not (RB_PastaProcesso.Checked)
        Panel_RecebeSelecao.Visible = Not (RB_PastaProcesso.Checked)
        Panel_RecebePastaProcesso.Visible = (RB_PastaProcesso.Checked)

    End Sub

    Private Sub RB_PastaProcesso_MouseHover(sender As Object, e As EventArgs) Handles RB_PastaProcesso.MouseHover
        RB_PastaProcesso.Image = My.Resources.pastaProcesso35_Hover

    End Sub


    Private Sub RB_PastaProcesso_MouseMove(sender As Object, e As MouseEventArgs) Handles RB_PastaProcesso.MouseMove
        RB_PastaProcesso.Image = My.Resources.pastaProcesso35_Hover

    End Sub

    Private Sub RB_PastaProcesso_MouseLeave(sender As Object, e As EventArgs) Handles RB_PastaProcesso.MouseLeave
        If RB_PastaProcesso.Checked = False Then
            RB_PastaProcesso.Image = My.Resources.pastaProcesso35

        End If
    End Sub

    Private Sub RB_Filter_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Filter.CheckedChanged
        Panel_Recebe_Filtro.Dock = DockStyle.Fill

        If RB_Filter.Checked = True Then
            RB_Filter.Image = My.Resources.filter_Hover35
        Else
            RB_Filter.Image = My.Resources.filter_35

        End If

        Panel_MediasExplorer.Visible = Not (RB_Filter.Checked)
        Panel_RecebeExplorer.Visible = Not (RB_Filter.Checked)
        Panel_Recebe_Filtro.Visible = (RB_Filter.Checked)

        Panel_RecebeClipboad.Visible = Not (RB_Filter.Checked)
        Panel_RecebeSelecao.Visible = Not (RB_Filter.Checked)
        Panel_RecebePastaProcesso.Visible = Not (RB_Filter.Checked)

    End Sub

    Private Sub RB_Selecao_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Selecao.CheckedChanged

        Panel_MediasExplorer.Visible = Not (RB_Selecao.Checked)
        Panel_RecebeExplorer.Visible = Not (RB_Selecao.Checked)
        Panel_Recebe_Filtro.Visible = Not (RB_Selecao.Checked)

        Panel_RecebeClipboad.Visible = Not (RB_Selecao.Checked)
        Panel_RecebeSelecao.Visible = (RB_Selecao.Checked)

        Panel_RecebePastaProcesso.Visible = Not (RB_Selecao.Checked)

        If RB_Selecao.Checked = True Then
            RB_Selecao.Image = My.Resources.selection_cursor01_Hover

        Else
            RB_Selecao.Image = My.Resources.selection_cursor01

        End If

    End Sub

    Private Sub RB_Selecao_MouseHover(sender As Object, e As EventArgs) Handles RB_Selecao.MouseHover
        RB_Selecao.Image = My.Resources.selection_cursor01_Hover

    End Sub

    Private Sub RB_Selecao_MouseMove(sender As Object, e As MouseEventArgs) Handles RB_Selecao.MouseMove
        RB_Selecao.Image = My.Resources.selection_cursor01_Hover

    End Sub


    Private Sub RB_Selecao_MouseLeave(sender As Object, e As EventArgs) Handles RB_Selecao.MouseLeave

        If RB_Selecao.Checked = False Then
            RB_Selecao.Image = My.Resources.selection_cursor01

        End If

    End Sub

    Private Sub RB_Filter_MouseHover(sender As Object, e As EventArgs) Handles RB_Filter.MouseHover
        RB_Filter.Image = My.Resources.filter_Hover35

    End Sub



    Private Sub SPRedimVisualizarMidia_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SPRedimVisualizarMidia.SplitterMoved

    End Sub

    Private Sub RB_Filter_MouseMove(sender As Object, e As MouseEventArgs) Handles RB_Filter.MouseMove
        RB_Filter.Image = My.Resources.filter_Hover35

    End Sub

    Private Sub RB_Filter_MouseLeave(sender As Object, e As EventArgs) Handles RB_Filter.MouseLeave
        If RB_Filter.Checked = False Then
            RB_Filter.Image = My.Resources.filter_35

        End If

    End Sub

    Private Sub RB_Clipboard_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Clipboard.CheckedChanged

        Panel_MediasExplorer.Visible = Not (RB_Clipboard.Checked)
        Panel_RecebeExplorer.Visible = Not (RB_Clipboard.Checked)
        Panel_Recebe_Filtro.Visible = Not (RB_Clipboard.Checked)

        Panel_RecebeClipboad.Visible = (RB_Clipboard.Checked)
        Panel_RecebeSelecao.Visible = Not (RB_Clipboard.Checked)
        Panel_RecebePastaProcesso.Visible = Not (RB_Clipboard.Checked)


        If RB_Clipboard.Checked = True Then
            RB_Clipboard.Image = My.Resources.verify_Clipboard_Hover
        Else
            RB_Clipboard.Image = My.Resources.verify_Clipboard01_35

        End If
    End Sub

    Private Sub RB_Clipboard_MouseHover(sender As Object, e As EventArgs) Handles RB_Clipboard.MouseHover
        RB_Clipboard.Image = My.Resources.verify_Clipboard_Hover

    End Sub

    Private Sub RB_Clipboard_MouseMove(sender As Object, e As MouseEventArgs) Handles RB_Clipboard.MouseMove
        RB_Clipboard.Image = My.Resources.verify_Clipboard_Hover

    End Sub

    Private Sub RB_Clipboard_MouseLeave(sender As Object, e As EventArgs) Handles RB_Clipboard.MouseLeave
        If RB_Clipboard.Checked = False Then
            RB_Clipboard.Image = My.Resources.verify_Clipboard01_35
        End If
    End Sub
End Class
