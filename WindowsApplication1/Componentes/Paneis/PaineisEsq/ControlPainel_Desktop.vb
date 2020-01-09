Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports System.Collections
Imports Microsoft.VisualBasic

'http://www.andrealveslima.com.br/blog/index.php/2017/04/12/utilizando-api-google-drive-no-c-e-vb-net/
' TODO: Desenhar Menu de contexto
' TODO: Criar Função renomearPasta
' TODO: Criar função renomearVolume
' TODO: Criar função remover pasta
' TODO: Aperfeiçoar eventos relacionados com a  propriedade LabelEdit.
' Não pode renomear Desktop nem as pastas de virtuais de bibliotecas
' TODO: Adicionar botões excluir, etc.

' TODO:

Public Class ControlPainel_Desktop
    Dim tipoDeArquivo As String
    Dim carregaArquivosNaArvore As Boolean
    Dim caminhoDaPastaSelecionada As String

    ' Propriedade de caminho
    Private _caminho As String
    Public Property Caminho As String
        Get
            Return _caminho

        End Get
        Set(value As String)
            _caminho = value

        End Set
    End Property

    Private Sub ControlPainel_Desktop_Load(sender As Object, e As EventArgs) Handles Me.Load

        If CHK_ShowCheck.Checked = 1 Then
            'TVWFilesAndFolders.CheckBoxes = True

        End If
        TVWFilesAndFolders.CheckBoxes = CHK_ShowCheck.Checked

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LoadTree()
        'PopulateTreeView()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub LoadTree()
        Dim tvRoot As TreeNode
        Dim tvNode As TreeNode
        Dim tvNodeDeComputador As TreeNode
        Dim tvNodeDeDesktop As TreeNode

        Dim delimitadores() As Char = {"\"c, "/"c}

        ' Filtrar os tipos de arquivos que se deseja ver no Explorer 
        tipoDeArquivo = "*.*"

        ' Cria o nódulo "Computador", seus submódulos e o expande
        tvRoot = TVWFilesAndFolders.Nodes.Add("Computador", "Computador", "Computador", "Computador")
        tvNodeDeComputador = tvRoot
        tvNodeDeComputador.Tag = "Computador"

        tvRoot = tvNodeDeComputador.Nodes.Add("Desktop", "Área de Trabalho", "Desktop", "Desktop")
        tvNodeDeDesktop = tvRoot
        tvNodeDeDesktop.Tag = SpecialDirectories.Desktop

        tvRoot = tvNodeDeComputador.Nodes.Add("Documentos", "Documentos", "Documentos", "Documentos")
        tvRoot.Tag = SpecialDirectories.MyDocuments
        tvRoot.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"

        tvRoot = tvNodeDeComputador.Nodes.Add("MyMusic", "Músicas", "Musicas", "Musicas")
        tvRoot.Tag = SpecialDirectories.MyMusic
        tvRoot.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"

        tvRoot = tvNodeDeComputador.Nodes.Add("MyPictures", "Imagens", "Imagens", "Imagens")
        tvRoot.Tag = SpecialDirectories.MyPictures
        tvRoot.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"


        Dim listaDeDiretorios As String()
        Dim caminhoDaPastaDoUsuario As String
        listaDeDiretorios = SepararPalavras(SpecialDirectories.CurrentUserApplicationData, delimitadores)

        caminhoDaPastaDoUsuario = listaDeDiretorios(0) & "\" & listaDeDiretorios(1) & "\" & listaDeDiretorios(2)
        Dim dir As New DirectoryInfo(caminhoDaPastaDoUsuario & "\Videos")

        If dir.Exists = False Then
            MkDir(caminhoDaPastaDoUsuario & "\Videos")
        End If

        tvRoot = tvNodeDeComputador.Nodes.Add(caminhoDaPastaDoUsuario & "\Videos", "Videos", "Videos", "Videos")
        tvRoot.Tag = caminhoDaPastaDoUsuario & "\Videos"
        tvRoot.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"

        'Dim listaDeDiretorios As String()
        'Dim caminhoDaPastaDoUsuario As String
        listaDeDiretorios = SepararPalavras(SpecialDirectories.CurrentUserApplicationData, delimitadores)

        caminhoDaPastaDoUsuario = listaDeDiretorios(0) & "\" & listaDeDiretorios(1) & "\" & listaDeDiretorios(2)
        Dim dir2 As New DirectoryInfo(caminhoDaPastaDoUsuario & "\Downloads")

        If dir2.Exists = False Then
            MkDir(caminhoDaPastaDoUsuario & "\Downloads")
        End If

        tvRoot = tvNodeDeComputador.Nodes.Add(caminhoDaPastaDoUsuario & "\Downloads", "Downloads", "down", "down")
        tvRoot.Tag = caminhoDaPastaDoUsuario & "\Downloads"
        tvRoot.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"

        'tvRoot = tvNodeDeComputador.Nodes.Add("ProgramFiles", "ProgramFiles", "pastaFechada", "pastaAberta")
        'tvRoot.Tag = SpecialDirectories.ProgramFiles
        'tvRoot.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"

        'tvRoot = tvNodeDeComputador.Nodes.Add("Programs", "Programs", "pastaFechada", "pastaAberta")
        'tvRoot.Tag = SpecialDirectories.Programs
        'tvRoot.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"

        'tvRoot = tvNodeDeComputador.Nodes.Add("Temp", "Temp", "pastaFechada", "pastaAberta")
        'tvRoot.Tag = SpecialDirectories.Temp
        'tvRoot.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"
        'tvNodeDeComputador.Expand()

        ' MsgBox(SpecialDirectories.AllUsersApplicationData)


        'TODO: ( INCOMPLETO ) Encontra SubPastas da Area de trabalho e as adicionar 
        '_________________________________________________________________

        Dim AreaDeTrabalho As String
        'Dim SubPastaDaAreaDeTrabalho As String
        Dim NomeDasSubPastasDaAreaDeTrabalho() As String
        ' Dim nomeDaSubPastaDaAreaDeTrabalho As String
        Dim nome As String


        AreaDeTrabalho = SpecialDirectories.Desktop
        NomeDasSubPastasDaAreaDeTrabalho = SepararPalavras(AreaDeTrabalho, delimitadores)


        Dim dirDir As New IO.DirectoryInfo(AreaDeTrabalho)
        Dim dirDir01 As IO.DirectoryInfo() = dirDir.GetDirectories()
        Dim drD As IO.DirectoryInfo

        For Each drD In dirDir01
            nome = drD.Name
            tvRoot = tvNodeDeDesktop.Nodes.Add("Desktop\" & nome, nome, "pastaFechada", "pastaAberta")
            tvRoot.Tag = drD.FullName
            tvRoot.ContextMenuStrip = Me.CMItens

            tvRoot.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"
        Next

        ''###############################################################
        ''_______________________________________________________________

        '' TODO: Instruções para carregar os arquivos de Area de Trabalho
        ''__________________________________________________________________

        '' se CarregarArquivosNaArvore for verdadeiro entao...
        '' carrega arquivos
        'carregaArquivosNaArvore = True

        'If carregaArquivosNaArvore = True Then
        '    caminhoDaPastaSelecionada = tvNodeDeDesktop.Tag

        '    Dim dirFiles As New IO.DirectoryInfo(caminhoDaPastaSelecionada)
        '    Dim dirArq01 As IO.FileInfo() = dirFiles.GetFiles()
        '    Dim dra As IO.FileInfo

        '    Dim iconImage As String
        '    Dim ext As String

        '    For Each dra In dirArq01

        '        ext = dra.Extension
        '        Select Case ext.ToLower
        '            Case ".jpg", ".jpeg", ".gif"

        '                iconImage = "Documentos"

        '            Case Else
        '                iconImage = "Documentos"

        '        End Select

        '        nome = dra.Name
        '        tvNodeDeDesktop.Nodes.Add("Desktop\" & nome, nome, iconImage, iconImage).Tag = dra.FullName

        '    Next

        'End If

        '###############################################################
        '_______________________________________________________________
        ' TODO: Tratar e adicionar driveres em Meu Computador
        '__________________________________________________________________

        Dim nomeDoDrive As String
        Dim tipoDeDrive As String
        Dim rotuloDoDrive As String
        Dim todoDrive As String
        Dim tamanhoDoDrive As String
        Dim iconeDoDrive As String

        For Each drive As DriveInfo In My.Computer.FileSystem.Drives

            nomeDoDrive = drive.Name
            tipoDeDrive = drive.DriveType

            ' Escolhe o tipo de icone de acordo com o drive 
            Select Case drive.DriveType

                Case 0
                    tipoDeDrive = "Unknown"

                Case 1
                    tipoDeDrive = "NoRootDirectory"

                Case 2
                    tipoDeDrive = "Removable"
                    iconeDoDrive = "Pen.ico"

                Case 3
                    tipoDeDrive = "Fixed"
                    iconeDoDrive = "hd"

                Case 4
                    tipoDeDrive = "Network"

                Case 5
                    tipoDeDrive = "CD Rom"
                    iconeDoDrive = "DVD"

                Case 6
                    tipoDeDrive = "Ram"

            End Select

            rotuloDoDrive = ""

            If drive.IsReady Then
                rotuloDoDrive = CType(drive.VolumeLabel.ToString, String)
                tamanhoDoDrive = CStr(drive.TotalSize.ToString & " Kb")

            End If

            If Not rotuloDoDrive Is Nothing Then
                'drive.VolumeLabel = "WWW"

                If rotuloDoDrive = "" Then
                    If tipoDeDrive.ToString = "Fixed" Then
                        rotuloDoDrive = "Disco Local"
                    ElseIf tipoDeDrive.ToString = "CD Rom" Then
                        rotuloDoDrive = "Unidade de Disco Removível"
                        iconeDoDrive = "UnidadeVazia"
                    End If
                End If

                todoDrive = rotuloDoDrive & " (" & nomeDoDrive.Substring(0, 2) & ")"
            Else
                todoDrive = "(" & nomeDoDrive.Substring(0, 2) & ")"
            End If

            tvNode = tvNodeDeComputador.Nodes.Add(nomeDoDrive.Substring(0, 2), todoDrive, iconeDoDrive, iconeDoDrive)
            tvRoot.ContextMenuStrip = Me.CMItens

            tvNode.Tag = nomeDoDrive
            tvNode.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"

        Next

    End Sub

    Function SepararPalavras(ByVal quebrarPalavras As String, ByVal delimitadores() As Char) As String()

        Dim palavras() As String
        palavras = quebrarPalavras.Split(delimitadores)
        Return palavras

    End Function

    Private Sub TVWFilesAndFolders_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVWFilesAndFolders.AfterSelect

        Dim tsNode As TreeNode
        System.Windows.Forms.Application.DoEvents()
        tsNode = TVWFilesAndFolders.SelectedNode
        _caminho = TVWFilesAndFolders.SelectedNode.Tag
        CarregarDiretorio(tsNode)

    End Sub

    Sub CarregarDiretorio(node As TreeNode)

        Try
            Select Case node.Name
                Case "Computador"

                Case "Desktop"

                Case Else
                    If node.Tag <> Nothing Then
                        Dim dir As New DirectoryInfo(node.Tag)

                        If dir.Exists = True Then
                            Dim dirSub As DirectoryInfo() = dir.GetDirectories
                            Dim dirArq1 As FileInfo() = dir.GetFiles()

                            '        TODO: Adicionar algoritimo de atualização da media: criar função (OK) 
                            '        TODO: Aplicar função criada em um evento de expansão de node ou seleção. (OK)
                            '        TODO: http://www.macoratti.net/13/12/vbn_list1.htm
                            '        TODO: Adicionar pasta download (OK)
                            '        eXCLUIR PASTAS especiais. (OK)

                            AtualizarDiretorio(node)


                            TVWFilesAndFolders.UseWaitCursor = True

                            TVWFilesAndFolders.UseWaitCursor = False

                            If node.Parent.Name = "Computador" Then

                                Dim fullName As String
                                fullName = node.FullPath
                                If EDrive(fullName) = False Then Exit Sub
                                '  If fullName.IndexOf(":") = -1 Then

                                Dim drive01 As New DriveInfo(node.Name)

                                If drive01.IsReady = False Then
                                    node.Nodes.Clear()
                                    node.Nodes.Add("O dispositivo não está acessível.")
                                    Exit Sub
                                End If

                                TVWFilesAndFolders.UseWaitCursor = False

                            End If

                        Else
                            If EDrive(node.Tag) = False And node.Tag <> "Mensagem" Then
                                TVWFilesAndFolders.Nodes.Remove(node)
                            End If
                            ' AtualizarDiretorio(node)
                            TVWFilesAndFolders.UseWaitCursor = False

                        End If
                    End If
            End Select

        Catch ex As Exception

            node.Nodes.Clear()
            node.Nodes.Add(node.Name & "\info", ex.Message, "info", "info").Tag = "Mensagem"
            node.Expand()
            TVWFilesAndFolders.UseWaitCursor = False

        End Try
    End Sub
    Private Sub AtualizarDiretorio(node As TreeNode)
        Dim directory As New DirectoryInfo(node.Tag)
        Dim subDirectories As DirectoryInfo() = directory.GetDirectories
        Dim dir As DirectoryInfo

        Dim tNode As TreeNode = node
        Dim subTNode As TreeNode
        Dim adicionarAListaDeDiretorios As New ArrayList

        Dim adicionar As Boolean

        For Each subTNode In tNode.Nodes
            Dim dirCheck As New DirectoryInfo(subTNode.Tag)
            If dirCheck.Exists = False Then
                tNode.Nodes.Remove(subTNode)
            End If
        Next

        For Each dir In subDirectories

            For Each subTNode In tNode.Nodes
                If dir.FullName = subTNode.Tag Then
                    adicionar = False
                    Exit For
                Else
                    adicionar = True

                End If
            Next

            If tNode.Nodes.Count = 0 Then adicionar = True
            If adicionar = True Then adicionarAListaDeDiretorios.Add(dir)

        Next

        For Each dirAdd As DirectoryInfo In adicionarAListaDeDiretorios

            subTNode = tNode.Nodes.Add(tNode.Name & "\" & dirAdd.Name, dirAdd.Name, "pastaFechada", "pastaAberta")
            subTNode.Tag = dirAdd.FullName
            subTNode.ContextMenuStrip = Me.CMItens

            subTNode.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"
        Next

    End Sub

    Private Sub TVWFilesAndFolders_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TVWFilesAndFolders.NodeMouseClick
        Dim node As TreeNode

        node = CType(e.Node, TreeNode)
        CarregarDiretorio(node)

        Dim _caminho As New DirectoryInfo(node.Tag)
        TVWFilesAndFolders.LabelEdit = _caminho.Exists
        If TVWFilesAndFolders.LabelEdit = True Then editarNode(node)
        ' TODO: https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.treenode.beginedit?view=netframework-4.8#System_Windows_Forms_TreeNode_BeginEdit
        ' TODO:https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.treenode?view=netframework-4.8
    End Sub

    Private Sub CHK_ShowCheck_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_ShowCheck.CheckedChanged
        TVWFilesAndFolders.CheckBoxes = CHK_ShowCheck.Checked
    End Sub

    Private Sub BTN_NewFolder_Click(sender As Object, e As EventArgs) Handles BTN_NewFolder.Click
        Dim node As TreeNode = TVWFilesAndFolders.SelectedNode
        Dim subNode As TreeNode

        Dim x As String
        Dim criadaPasta As Boolean

        Try
            If node.Tag IsNot (Nothing) Then
                Dim prompt As String
                Dim title As String
                Dim defaultResponse As String

                prompt = "Digite o nome da nova pasta que será criada em:" & Chr(13) & node.Tag & "."
                title = "Criar nova pasta"
                defaultResponse = "Nova Pasta"
                x = InputBox(prompt, title, defaultResponse)
                ' MsgBox(x)

                criadaPasta = CriarNovaPasta(node.Tag, x)
                If criadaPasta = True Then
                    subNode = node.Nodes.Add(node.Tag & "\" & x, x, "pastaFechada", "pastaAberta")
                    subNode.Tag = node.Tag & "\" & x

                    subNode.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"
                    subNode.ContextMenuStrip = CMItens


                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Function CriarNovaPasta(caminho As String, nomeDaPasta As String) As Boolean

        Dim excecao As String

        If caminho = Nothing Then
            Return False
            Exit Function
        End If

        nomeDaPasta = LTrim(nomeDaPasta)
        nomeDaPasta = RTrim(nomeDaPasta)

        Dim _caminho As New DirectoryInfo(caminho & "\")
        Dim _destino As New DirectoryInfo(caminho & "\" & nomeDaPasta)


        Try
            If _caminho.Exists = False Then
                excecao = "O caminho não existe."
                MsgBox(excecao)
                Return False

            ElseIf _destino.Exists = True Then
                If _caminho.FullName <> _destino.FullName Then
                    excecao = "A pasta já existe."
                    MsgBox(excecao)
                End If
                Return False

            Else
                If nomeDaPasta <> "" Then
                    MkDir(caminho & "\" & nomeDaPasta)
                    Return True

                Else
                    Return False

                End If
                ' Return True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Function EDrive(caminho As String) As Boolean
        Dim fullName As String
        fullName = caminho
        If fullName.IndexOf(":") = -1 Then
            Return False

        Else
            Return True

        End If
    End Function

    Sub editarNode(node As TreeNode)
        If Not node.IsEditing Then
            node.BeginEdit()
        End If
    End Sub

End Class
