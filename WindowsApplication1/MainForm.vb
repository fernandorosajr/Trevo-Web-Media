Imports System.IO
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Reflection

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

    Public addressBar As New Control_AddressBar
    ' -------------------------------------------------------



    Dim pMouse As Point
    Dim state As Byte
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



    Private Sub BTNMinimize_Click(sender As System.Object, e As System.EventArgs) Handles BTNMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTNRestaureMaximize_Click(sender As System.Object, e As System.EventArgs) Handles BTNRestaureMaximize.Click
        Call winstate()

    End Sub

    Private Sub BTNClose_Click(sender As System.Object, e As System.EventArgs) Handles BTNClose.Click
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

    Private Sub LBLTitle_DoubleClick(sender As Object, e As System.EventArgs) Handles LBLTitle.DoubleClick
        Call winstate()

    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles LBLTitle.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - px, Me.MousePosition.Y - Me.Location.Y - py))

        End If
    End Sub

    Private Sub LBLTitle_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles LBLTitle.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub


    Private Sub LBLTitle_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles LBLTitle.MouseUp
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

        LBLTitle.Text = Me.Text

        ' Controles de Usuário de MainForm
        ' ---------------------------------------------
        Panel_RecebeBiblio.Visible = True

        Panel_RecebeBiblio.Controls.Add(painel_BibliotecaDeMidias)
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

        Panel_RecebeAtividade.Controls.Add(painel_Atividades)
        painel_Atividades.Dock = DockStyle.Fill
        painel_Atividades.Visible = True

        Panel_RecebeDetalhe.Controls.Add(painel_Detalhes)
        painel_Detalhes.Dock = DockStyle.Fill
        painel_Detalhes.Visible = True

        Panel_RecebeAcoes.Controls.Add(painel_Acoes)
        painel_Acoes.Dock = DockStyle.Fill
        painel_Acoes.Visible = True

        PanelMenuBar.Controls.Add(toolBar_Menu)
        toolBar_Menu.Dock = DockStyle.Fill
        toolBar_Menu.Visible = True  'False  '

        PanelMenuBar.Controls.Add(toolBar_ViewMenu)
        toolBar_ViewMenu.Dock = DockStyle.Fill
        toolBar_ViewMenu.Visible = True 'False 

        PanelMenuBar.Controls.Add(toolBar_BurnMenu)
        toolBar_BurnMenu.Dock = DockStyle.Fill
        toolBar_BurnMenu.Visible = True 'False   

        PanelMenuBar.Controls.Add(toolBar_OrganizeMenu02)
        toolBar_OrganizeMenu02.Dock = DockStyle.Fill
        toolBar_OrganizeMenu02.Visible = True  '  False

        PanelLoad_ControlSelectFileAndFoldePanel.Controls.Add(_controlSelectFileAndFolderPanel)
        _controlSelectFileAndFolderPanel.Dock = DockStyle.Fill
        _controlSelectFileAndFolderPanel.Visible = True

        Panel_RecebeClipboad.Controls.Add(painel_Clipboard)
        painel_Clipboard.Dock = DockStyle.Fill
        painel_Clipboard.Visible = True

        'Panel_RecebeSelecao.Controls.Add(_controlSelectFileAndFolderPanel)
        '_controlSelectFileAndFolderPanel.Dock = DockStyle.Top
        '_controlSelectFileAndFolderPanel.Height = 55
        '_controlSelectFileAndFolderPanel.Visible = True

        Panel_RecebeSelecao.Controls.Add(painel_Selected)
        painel_Selected.Dock = DockStyle.Fill
        painel_Selected.BringToFront()
        painel_Selected.Visible = True

        Panel_RecebePastaProcesso.Controls.Add(painel_PastaProcesso)
        painel_PastaProcesso.Dock = DockStyle.Fill
        painel_PastaProcesso.Visible = True

        PanelRecebe_AddressBar.Controls.Add(addressBar)
        addressBar.Dock = DockStyle.Fill
        addressBar.MainNode = painel_Desktop.TVWFilesAndFolders.Nodes.Item(0)

        'Dim listaDeMenus As New List(Of ContextMenuStrip) From {
        '    CMenuParaPastaVazia
        '}

        'addressBar.Menus = listaDeMenus
        addressBar.CMenuToExpandOptionsButton = CMenuParaPastaSemSubPasta

        addressBar.Visible = True
        ' ---------------------------------------------

        AddHandler painel_BibliotecaDeMidias.TVFilesAndFoldersOfTheOpenMedia.AfterSelect, New System.Windows.Forms.TreeViewEventHandler(AddressOf TreeViews_AfterSelect)
        AddHandler painel_MidiasAtivas.TVFilesAndFoldersOfTheOpenMedia.AfterSelect, New System.Windows.Forms.TreeViewEventHandler(AddressOf TreeViews_AfterSelect)
        AddHandler painel_Desktop.TVWFilesAndFolders.AfterSelect, New System.Windows.Forms.TreeViewEventHandler(AddressOf TreeViews_AfterSelect)
        'AddHandler painel_Desktop.TVWFilesAndFolders.AfterSelect, New System.Windows.Forms.TreeViewEventHandler(AddressOf TreeViews_AfterSelect)


        ' Painel_MidiasAtivas.TVMedias_NodeMouseClick(sender, e)

        For fadein = 0.0 To 1.1 Step 0.1
            Me.Opacity = fadein
            Me.Refresh()
            Threading.Thread.Sleep(10)
        Next


        Dim path As String = "C:\Minha Pasta\"
        Dim folder As DirectoryInfo
        Dim folder2 As DirectoryInfo
        Dim folderImpar As DirectoryInfo
        Dim file As FileInfo


        For x = 0 To 1
            folder = New DirectoryInfo(path & "Teste de Pasta " & x)
            SelectedFoldersAndFiles.Add(folder)


            For y = 0 To 1
                file = New FileInfo(folder.FullName & "\foto " & y & ".jpg")
                SelectedFoldersAndFiles.Add(file)
            Next

            For y = 0 To 1
                folder2 = New DirectoryInfo(folder.FullName & "\" & "Outra Pasta " & y)
                SelectedFoldersAndFiles.Add(folder2)
            Next
        Next

        path = "F:\"
        For x = 0 To 1
            folder = New DirectoryInfo(path & "IMAGENS " & x)
            SelectedFoldersAndFiles.Add(folder)

            For y = 0 To 1
                folder2 = New DirectoryInfo(folder.FullName & "\" & "Outra Pasta " & y)
                SelectedFoldersAndFiles.Add(folder2)
            Next


        Next

        folderImpar = New DirectoryInfo("F:\Folder Impar")
        SelectedFoldersAndFiles.Add(folderImpar)

    End Sub

    Sub TreeViews_AfterSelect(sender As Object, e As TreeViewEventArgs)
        Dim tvw As TreeView
        tvw = CType(sender, TreeView)

        If addressBar.SelectedNode IsNot tvw.SelectedNode Then
            addressBar.SelectedNode = tvw.SelectedNode
        End If
        ExibirDados(addressBar.SelectedNode)
        'If addressBar.SelectedNode IsNot painel_Desktop.TVWFilesAndFolders.SelectedNode Then
        '    addressBar.SelectedNode = painel_Desktop.TVWFilesAndFolders.SelectedNode
        'End If

    End Sub

    Sub ExibirDados(node As TreeNode)
        Dim info As String

        info = "TEXT: " & node.Text & Chr(13) &
               "NAME: " & node.Name & Chr(13) &
               "FULLPATH: " & node.FullPath & Chr(13) &
               "TAG :" & node.Tag

        MsgBox(info)
    End Sub

    Public Function AdicionarItemNoView(Drive As DriveInfo, Numero As Integer)
        ' Cria os subobjetos semelhantes a pastas do picasa
        PanelRecebe.Controls.Add(controlPersonalListView)
        controlPersonalListView.Visible = True
        controlPersonalListView.Dock = DockStyle.Fill
    End Function

    Private Sub ClickingMouseRedim()

        me_w = Me.Width
        me_h = Me.Height
        me_redim = True

    End Sub

    Private Sub PanelMDir_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMDir.MouseDown, PanelSubMarginRight.MouseDown
        Call ClickingMouseRedim()

    End Sub

    Private Sub PanelMDir_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMDir.MouseMove, PanelSubMarginRight.MouseMove
        If me_redim Then
            Me.Width = Me.Size.Width + e.X
        End If

    End Sub

    Private Sub PanelMDir_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMDir.MouseUp, PanelSubMarginRight.MouseUp
        me_redim = False

    End Sub

    Private Sub PanelMBase_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMBase.MouseDown, PanelSubMarginBase.MouseDown
        Call ClickingMouseRedim()

    End Sub

    Private Sub PanelMBase_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMBase.MouseMove, PanelSubMarginBase.MouseMove
        If me_redim Then
            Me.Height = Me.Size.Height + e.Y

        End If
    End Sub

    Private Sub PanelMBase_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMBase.MouseUp, PanelSubMarginBase.MouseUp
        me_redim = False

    End Sub

    Private Sub PanelPonta_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelSubMarginBaseRight.MouseDown
        Call ClickingMouseRedim()
    End Sub

    Private Sub PanelPonta_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelSubMarginBaseRight.MouseMove
        If me_redim Then
            Me.Height = Me.Size.Height + e.Y
            Me.Width = Me.Size.Width + e.X
        End If


    End Sub

    Private Sub PanelPonta_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelSubMarginBaseRight.MouseUp
        me_redim = False
    End Sub

    Private Sub PanelMEsq_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMEsq.MouseDown, PanelSubMarginLeft.MouseDown
        me_w = Me.Width
        me_h = Me.Height

        px = e.X
        py = e.Y

        me_redim = True
    End Sub

    Private Sub PanelMEsq_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMEsq.MouseMove, PanelSubMarginLeft.MouseMove
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

    Private Sub PanelMEsq_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PanelMEsq.MouseUp, PanelSubMarginLeft.MouseUp
        me_redim = False
    End Sub

    Private Sub RB_Explorerr_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_Explorer.CheckedChanged

        'Panel_MediasExplorer.Visible = Not (RB_Explorer.Checked)
        'Panel_RecebeExplorer.Visible = RB_Explorer.Checked
        'Panel_Recebe_Filtro.Visible = Not (RB_Explorer.Checked)
        'Panel_RecebeClipboad.Visible = Not (RB_Explorer.Checked)
        'Panel_RecebeSelecao.Visible = Not (RB_Explorer.Checked)
        'Panel_RecebePastaProcesso.Visible = Not (RB_Explorer.Checked)



        ' PanelEnvolveMidiaAberta.Visible = True
        ' SPRedimVisualizarMidia.Visible = True

        If RB_Explorer.Checked = True Then
            RB_Explorer.Image = My.Resources.computer_Hover35
            Panel_RecebeExplorer.BringToFront()
        Else
            RB_Explorer.Image = My.Resources.computer35

        End If

    End Sub

    Private Sub RB_Midias_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB_Midias.CheckedChanged

        'Panel_MediasExplorer.Visible = RB_Midias.Checked
        'Panel_RecebeExplorer.Visible = Not (RB_Midias.Checked)
        'Panel_Recebe_Filtro.Visible = Not (RB_Midias.Checked)
        'Panel_RecebeClipboad.Visible = Not (RB_Midias.Checked)
        'Panel_RecebeSelecao.Visible = Not (RB_Midias.Checked)
        'Panel_RecebePastaProcesso.Visible = Not (RB_Midias.Checked)


        If RB_Midias.Checked = True Then
            RB_Midias.Image = My.Resources.dvd_face6_Hover
            Panel_MediasExplorer.BringToFront()

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

    Private Sub PanelMenuBar_CheckedCheckBoxToShowOrHide()
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

        PanelMenuBar.Visible = _visible

    End Sub



    Private Sub MenuItem_Click(sender As Object, e As System.EventArgs) Handles ChBInicio.Click, ChBOrganizar.Click, ChBGravar.Click, ChBExibir.Click

        Dim chk As Object

        If sender.GetType.Name.ToString = "CheckBox" Then
            chk = CType(sender, CheckBox)

        Else
            MsgBox(sender.name.ToString)
            chk = CType(sender, Object)
        End If


        Dim ChckB As New Object

        For Each ctr As Control In Me.FLPMenu.Controls

            If TypeOf ctr Is CheckBox Then
                ChckB = ctr

                If ChckB.Name <> chk.name Then

                    ChckB.Checked = False

                End If
            End If
        Next

        Call PanelMenuBar_CheckedCheckBoxToShowOrHide()

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

                    'PanelMBase.Visible = False
                    'PanelMEsq.Visible = False
                    'PanelMDir.Visible = False

                    PanelSubMarginBase.Visible = False
                    PanelSubMarginBaseRight.Visible = False
                    PanelSubMarginBaseLeft.Visible = False
                    PanelSubMarginLeft.Visible = False
                    PanelSubMarginRight.Visible = False

                    'Call Form_Resize()
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

                    'PanelMBase.Visible = True
                    'PanelMEsq.Visible = True
                    'PanelMDir.Visible = True
                    ''Call Form_Resize()

                    PanelSubMarginBase.Visible = True
                    PanelSubMarginBaseRight.Visible = True
                    PanelSubMarginBaseLeft.Visible = True
                    PanelSubMarginLeft.Visible = True
                    PanelSubMarginRight.Visible = True
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



    'Sub Form_Resize()

    Private Sub RBAtividade_CheckedChanged(sender As Object, e As EventArgs) Handles RBAtividade.CheckedChanged
        'Panel_RecebeAtividade.Visible = RBAtividade.Checked
        Panel_RecebeAtividade.BringToFront()

    End Sub

    Private Sub RBDetalhe_CheckedChanged(sender As Object, e As EventArgs) Handles RBDetalhe.CheckedChanged
        'Panel_RecebeDetalhe.Visible = RBDetalhe.Checked
        Panel_RecebeDetalhe.BringToFront()

    End Sub




    Private Sub BTNMenu01_Click(sender As Object, e As EventArgs) Handles BTNMenu01.Click

        CTMenuVisualizacao.Show(BTNMenu01, 0, BTNMenu01.Height)

    End Sub

    Private Sub RBAcoes_CheckedChanged(sender As Object, e As EventArgs) Handles RBAcoes.CheckedChanged
        'Panel_RecebeAcoes.Visible = RBAcoes.Checked
        Panel_RecebeAcoes.BringToFront()

        ' PanelSelecao.Visible = Not (RBAcoes.Checked)
    End Sub



    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        ' Form1.Show()
        ' FRMDialogConflictingFolders.ShowDialog()
        FRMDialogFileConflictForm.ShowDialog()

    End Sub

    Private Sub RB_Bibliotecas_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Bibliotecas.CheckedChanged

        'PanelMidiaAtiva.Visible = Not (RB_ExibeDesktopExplorer.Checked)
        Panel_RecebeBiblio.Visible = RB_Bibliotecas.Checked
        Panel_RecebeMidiasAtivas.Visible = Not (RB_Bibliotecas.Checked)

    End Sub

    Private Sub RB_ExibePanelMidiaAtiva_CheckedChanged(sender As Object, e As EventArgs) Handles RB_ExibePanelMidiaAtiva.CheckedChanged
        'PanelMidiaAtiva.Visible = RB_ExibePanelMidiaAtiva.Checked


        Panel_RecebeBiblio.Visible = Not (RB_ExibePanelMidiaAtiva.Checked)
        Panel_RecebeMidiasAtivas.Visible = RB_ExibePanelMidiaAtiva.Checked

        ' PanelEnvolveMidiaAberta.Visible = True
        ' SPRedimVisualizarMidia.Visible = True



    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PanelRecebe.Controls.Remove(controlPersonalListView)
    End Sub

    Private Sub BTNMenu01_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNMenu01.MouseMove

        pMouse = System.Windows.Forms.Cursor.Position
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

        Select Case chk.Name
            Case "ChBInicio"
                If chk.Checked = True Then toolBar_Menu.BringToFront()

            Case "ChBExibir"
                If chk.Checked = True Then toolBar_ViewMenu.BringToFront()

            Case "ChBGravar"
                If chk.Checked = True Then toolBar_BurnMenu.BringToFront()

            Case "ChBOrganizar"
                If chk.Checked = True Then toolBar_OrganizeMenu02.BringToFront()

        End Select

        'toolBar_Menu.Visible = ChBInicio.Checked
        'toolBar_ViewMenu.Visible = ChBExibir.Checked
        'toolBar_BurnMenu.Visible = ChBGravar.Checked
        'toolBar_OrganizeMenu02.Visible = ChBOrganizar.Checked

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
            Panel_RecebePastaProcesso.BringToFront()
        Else
            RB_PastaProcesso.Image = My.Resources.pastaProcesso35

        End If

        'Panel_MediasExplorer.Visible = Not (RB_PastaProcesso.Checked)
        'Panel_RecebeExplorer.Visible = Not (RB_PastaProcesso.Checked)
        'Panel_Recebe_Filtro.Visible = Not (RB_PastaProcesso.Checked)
        'Panel_RecebeClipboad.Visible = Not (RB_PastaProcesso.Checked)
        'Panel_RecebeSelecao.Visible = Not (RB_PastaProcesso.Checked)
        'Panel_RecebePastaProcesso.Visible = (RB_PastaProcesso.Checked)


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
            Panel_Recebe_Filtro.BringToFront()
        Else
            RB_Filter.Image = My.Resources.filter_35

        End If

        'Panel_MediasExplorer.Visible = Not (RB_Filter.Checked)
        'Panel_RecebeExplorer.Visible = Not (RB_Filter.Checked)
        'Panel_Recebe_Filtro.Visible = (RB_Filter.Checked)
        'Panel_RecebeClipboad.Visible = Not (RB_Filter.Checked)
        'Panel_RecebeSelecao.Visible = Not (RB_Filter.Checked)
        'Panel_RecebePastaProcesso.Visible = Not (RB_Filter.Checked)


    End Sub

    Private Sub RB_Selecao_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Selecao.CheckedChanged

        'Panel_MediasExplorer.Visible = Not (RB_Selecao.Checked)
        'Panel_RecebeExplorer.Visible = Not (RB_Selecao.Checked)
        'Panel_Recebe_Filtro.Visible = Not (RB_Selecao.Checked)
        'Panel_RecebeClipboad.Visible = Not (RB_Selecao.Checked)
        'Panel_RecebeSelecao.Visible = (RB_Selecao.Checked)
        'Panel_RecebePastaProcesso.Visible = Not (RB_Selecao.Checked)



        If RB_Selecao.Checked = True Then
            RB_Selecao.Image = My.Resources.selection_cursor01_Hover
            Panel_RecebeSelecao.BringToFront()

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

    Private Sub RB_Filter_MouseMove(sender As Object, e As MouseEventArgs) Handles RB_Filter.MouseMove
        RB_Filter.Image = My.Resources.filter_Hover35

    End Sub

    Private Sub RB_Filter_MouseLeave(sender As Object, e As EventArgs) Handles RB_Filter.MouseLeave
        If RB_Filter.Checked = False Then
            RB_Filter.Image = My.Resources.filter_35

        End If

    End Sub

    Private Sub RB_Clipboard_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Clipboard.CheckedChanged

        'Panel_MediasExplorer.Visible = Not (RB_Clipboard.Checked)
        'Panel_RecebeExplorer.Visible = Not (RB_Clipboard.Checked)
        'Panel_Recebe_Filtro.Visible = Not (RB_Clipboard.Checked)
        'Panel_RecebeClipboad.Visible = (RB_Clipboard.Checked)
        'Panel_RecebeSelecao.Visible = Not (RB_Clipboard.Checked)
        'Panel_RecebePastaProcesso.Visible = Not (RB_Clipboard.Checked)


        If RB_Clipboard.Checked = True Then
            RB_Clipboard.Image = My.Resources.verify_Clipboard_Hover
            Panel_RecebeClipboad.BringToFront()
        Else
            RB_Clipboard.Image = My.Resources.verify_Clipboard01_35

        End If
    End Sub

    Private Sub RB_Clipboard_MouseHover(sender As Object, e As EventArgs) Handles RB_Clipboard.MouseHover
        RB_Clipboard.Image = My.Resources.verify_Clipboard_Hover

    End Sub

    Private Sub RBSelecao_CheckedChanged(sender As Object, e As EventArgs) Handles RBSelecao.CheckedChanged
        Panel_RecebeSelecao.BringToFront()
    End Sub

    Private Sub RB_Clipboard_MouseMove(sender As Object, e As MouseEventArgs) Handles RB_Clipboard.MouseMove
        RB_Clipboard.Image = My.Resources.verify_Clipboard_Hover

    End Sub

    Private Sub RB_Clipboard_MouseLeave(sender As Object, e As EventArgs) Handles RB_Clipboard.MouseLeave
        If RB_Clipboard.Checked = False Then
            RB_Clipboard.Image = My.Resources.verify_Clipboard01_35
        End If
    End Sub

    Private Sub PropriedadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropriedadesToolStripMenuItem.Click
        RBDetalhe.Checked = True
    End Sub

    'Private Sub RB_Midias_MouseDown(sender As Object, e As MouseEventArgs) Handles RB_Midias.MouseDown
    '    Dim radio As RadioButton
    '    radio = CType(sender, RadioButton)
    '    'If radio.Checked = True Then

    '    radio.Checked = Not (radio.Checked)
    '    'End If

    'End Sub

    Private Sub RB_Midias_DoubleClick(sender As Object, e As EventArgs) Handles RB_Midias.DoubleClick, RB_Explorer.DoubleClick, RB_PastaProcesso.DoubleClick, RB_Selecao.DoubleClick, RB_Filter.DoubleClick
        Dim radio As RadioButton
        radio = CType(sender, RadioButton)

        radio.Checked = Not (radio.Checked)
    End Sub

    Private Sub ChBOrganizar_DoubleClick(sender As Object, e As EventArgs) Handles ChBOrganizar.DoubleClick
        MsgBox("sss")

    End Sub
End Class
