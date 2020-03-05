Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports System.Collections
Imports Microsoft.VisualBasic

'Imports TrevoWebMedia.DriveAnalysisClass

'http://www.andrealveslima.com.br/blog/index.php/2017/04/12/utilizando-api-google-drive-no-c-e-vb-net/
' TODO: Desenhar Menu de contexto
' TODO: Criar Função renomearPasta
' TODO: Criar função renomearVolume (OK)
' TODO: Criar função remover pasta
' TODO: Aperfeiçoar eventos relacionados com a  propriedade LabelEdit.
' Não pode renomear Desktop nem as pastas de virtuais de bibliotecas
' TODO: Adicionar botões excluir, etc.

' TODO:

Public Class ControlPainel_Desktop
    Dim tipoDeArquivo As String
    Dim carregaArquivosNaArvore As Boolean
    Dim caminhoDaPastaSelecionada As String

    Dim usesDirectories As New UsesDirectoriesClass
    Dim driveAnalysis As New DriveAnalysisClass

    Dim delimitadoresDeCaminhoDePasta() As Char = {"\"c, "/"c}

    Dim StringFunctions As New StringFunctionsClass

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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LoadTree()
        'PopulateTreeView()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ControlPainel_Desktop_Load(sender As Object, e As EventArgs) Handles Me.Load

        If CHK_ShowCheck.Checked = 1 Then
            'TVWFilesAndFolders.CheckBoxes = True

        End If
        TVWFilesAndFolders.CheckBoxes = CHK_ShowCheck.Checked

    End Sub

    Private Sub TVWFilesAndFolders_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TVWFilesAndFolders.NodeMouseClick
        Dim node As TreeNode
        '  TODO: E se vc usar  um clone de node 
        node = CType(e.Node, TreeNode)
        Load_MainDirectories(node)

        Dim _path As New DirectoryInfo(node.Tag)

        If node.Name = "Computador" Then
            TVWFilesAndFolders.LabelEdit = False

        ElseIf node.Parent.Name = "Computador" Then

            If driveAnalysis.IsDrive(node.Tag) = True Then
                TVWFilesAndFolders.LabelEdit = _path.Exists
            Else
                TVWFilesAndFolders.LabelEdit = False
            End If

        Else
            TVWFilesAndFolders.LabelEdit = _path.Exists
        End If
        ' MsgBox(node.Level)
        '  If TVWFilesAndFolders.LabelEdit = True Then EditarNode(node)
        ' TODO: https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.treenode.beginedit?view=netframework-4.8#System_Windows_Forms_TreeNode_BeginEdit
        ' TODO: https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.treenode?view=netframework-4.8
    End Sub

    Private Sub CHK_ShowCheck_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_ShowCheck.CheckedChanged
        TVWFilesAndFolders.CheckBoxes = CHK_ShowCheck.Checked
    End Sub

    Private Sub BTN_NewFolder_Click(sender As Object, e As EventArgs) Handles BTN_NewFolder.Click
        Dim node As TreeNode = TVWFilesAndFolders.SelectedNode
        Dim subNode As TreeNode

        Dim folderName As String
        Dim _novaPastaFoiCriada As Boolean

        Dim usesDirectoriesClass As New UsesDirectoriesClass

        Try
            If node.Tag IsNot (Nothing) Then
                Dim prompt As String
                Dim title As String
                Dim defaultResponse As String

                prompt = "Digite o nome da nova pasta que será criada em:" & Chr(13) & node.Tag & "."
                title = "Criar nova pasta"
                defaultResponse = usesDirectoriesClass.ReturnNonExistentFolderName(node.Tag, "Nova pasta")
                folderName = InputBox(prompt, title, defaultResponse)


                _novaPastaFoiCriada = usesDirectories.CreateNewFolder(node.Tag, folderName)
                'TODO: Editar regras de interação com pastas durante a criação
                ' Checar se pasta existe
                ' se existe, perguntar para qual nome renomear ou mesclar.

                If _novaPastaFoiCriada = True Then
                    subNode = node.Nodes.Add(node.Tag & "\" & folderName, folderName, "pastaFechada", "pastaFechada")
                    subNode.Tag = node.Tag & "\" & folderName

                    subNode.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"
                    subNode.ContextMenuStrip = CMItens
                End If

            End If

        Catch ex As Exception

            MsgBox("Erro no Evento" & Chr(13) & "BTN_NewFolder_Click" & Chr(13) & """" & ex.Message & """")

        End Try
    End Sub

    Private Sub TVWFilesAndFolders_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVWFilesAndFolders.AfterSelect

        Dim tsNode As TreeNode

        tsNode = TVWFilesAndFolders.SelectedNode
        _caminho = TVWFilesAndFolders.SelectedNode.Tag
        Load_MainDirectories(tsNode)

    End Sub

    Private Sub TVWFilesAndFolders_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles TVWFilesAndFolders.AfterExpand

        Dim node As TreeNode
        node = CType(e.Node, TreeNode)
        If node.Name = "Computador" Then Exit Sub
        If node.Name <> "Desktop" And node.Parent.Name <> "Computador" Then
            node.ImageKey = "pastaAberta"
            node.SelectedImageKey = "pastaAberta"
        End If

    End Sub

    Private Sub TVWFilesAndFolders_AfterCollapse(sender As Object, e As TreeViewEventArgs) Handles TVWFilesAndFolders.AfterCollapse

        Dim node As TreeNode
        node = CType(e.Node, TreeNode)
        If node.Name = "Computador" Then Exit Sub
        If node.Name <> "Desktop" And node.Parent.Name <> "Computador" Then
            node.ImageKey = "pastaFechada"
            node.SelectedImageKey = "pastaFechada"
        End If

    End Sub

    Private Sub LoadTree()
        Dim tvRoot As TreeNode
        Dim tvNode As TreeNode
        Dim tvNodeDeComputador As TreeNode
        Dim tvNodeDeDesktop As TreeNode

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
        listaDeDiretorios = StringFunctions.SepararPalavras(SpecialDirectories.CurrentUserApplicationData, delimitadoresDeCaminhoDePasta)

        caminhoDaPastaDoUsuario = listaDeDiretorios(0) & "\" & listaDeDiretorios(1) & "\" & listaDeDiretorios(2)
        Dim dir As New DirectoryInfo(caminhoDaPastaDoUsuario & "\Videos")

        If dir.Exists = False Then
            MkDir(caminhoDaPastaDoUsuario & "\Videos")
        End If

        tvRoot = tvNodeDeComputador.Nodes.Add(caminhoDaPastaDoUsuario & "\Videos", "Videos", "Videos", "Videos")
        tvRoot.Tag = caminhoDaPastaDoUsuario & "\Videos"
        tvRoot.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"

        listaDeDiretorios = StringFunctions.SepararPalavras(SpecialDirectories.CurrentUserApplicationData, delimitadoresDeCaminhoDePasta)

        caminhoDaPastaDoUsuario = listaDeDiretorios(0) & "\" & listaDeDiretorios(1) & "\" & listaDeDiretorios(2)
        Dim dir2 As New DirectoryInfo(caminhoDaPastaDoUsuario & "\Downloads")

        If dir2.Exists = False Then
            MkDir(caminhoDaPastaDoUsuario & "\Downloads")
        End If

        tvRoot = tvNodeDeComputador.Nodes.Add(caminhoDaPastaDoUsuario & "\Downloads", "Downloads", "down", "down")
        tvRoot.Tag = caminhoDaPastaDoUsuario & "\Downloads"
        tvRoot.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"

        Dim AreaDeTrabalho As String
        Dim NomeDasSubPastasDaAreaDeTrabalho() As String
        Dim nome As String


        AreaDeTrabalho = SpecialDirectories.Desktop
        NomeDasSubPastasDaAreaDeTrabalho = StringFunctions.SepararPalavras(AreaDeTrabalho, delimitadoresDeCaminhoDePasta)


        Dim dirDir As New IO.DirectoryInfo(AreaDeTrabalho)
        Dim dirDir01 As IO.DirectoryInfo() = dirDir.GetDirectories()
        Dim drD As IO.DirectoryInfo

        For Each drD In dirDir01
            nome = drD.Name
            tvRoot = tvNodeDeDesktop.Nodes.Add("Desktop\" & nome, nome, "pastaFechada", "pastaFechada")
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


        Dim nomeDoDrive As String
        Dim tipoDeDrive As String
        Dim rotuloDoDrive As String
        Dim todoDrive As String
        Dim tamanhoDoDrive As String
        Dim iconeDoDrive As String

        Dim drive_Analys As New DriveAnalysisClass

        For Each drive As DriveInfo In My.Computer.FileSystem.Drives

            nomeDoDrive = drive.Name
            tipoDeDrive = drive.DriveType

            rotuloDoDrive = ""

            drive_Analys.ReturnLabelVolumeDisplay(drive)
            nomeDoDrive = drive_Analys.NomeDoDrive
            todoDrive = drive_Analys.TodoDrive
            iconeDoDrive = drive_Analys.IconeDoDrive

            tvNode = tvNodeDeComputador.Nodes.Add(nomeDoDrive.Substring(0, 2), todoDrive, iconeDoDrive, iconeDoDrive)
            tvNode.ContextMenuStrip = Me.CMItens

            tvNode.Tag = nomeDoDrive
            tvNode.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"

        Next

    End Sub


    Sub Load_MainDirectories(node As TreeNode)

        Try
            ' TODO: http://www.macoratti.net/13/12/vbn_list1.htm

            Select Case node.Name
                Case "Computador"

                Case "Desktop"

                Case Else
                    If node.Tag <> Nothing Then
                        Dim dir As New DirectoryInfo(node.Tag)

                        Select Case driveAnalysis.IsDrive(node.Tag)
                            Case True
                                Dim drive01 As New DriveInfo(node.Name)

                                If drive01.IsReady = True Then
                                    AtualizarDiretorioNoTreeView(node)
                                Else

                                    node.Nodes.Clear()
                                    node.Nodes.Add("Mensagem", "<O dispositivo não está acessível.>", "info", "info").Tag = "Mensagem"
                                    Exit Sub

                                End If

                            Case Else

                                If dir.Exists = True Then
                                    AtualizarDiretorioNoTreeView(node)

                                Else
                                    If node.Tag <> "Mensagem" Then
                                        TVWFilesAndFolders.Nodes.Remove(node)
                                    End If
                                End If
                        End Select

                    End If
            End Select

        Catch ex As Exception

            node.Nodes.Clear()
            node.Nodes.Add(node.Name & "\info", ex.Message, "info", "info").Tag = "Mensagem"
            node.Expand()
            TVWFilesAndFolders.UseWaitCursor = False

        End Try
    End Sub

    Function AtualizarSubNode(node As TreeNode) As TreeNode
        Dim pathSubTNode As String
        Dim cloneSubTNode As TreeNode = CType(node.Clone(), TreeNode)

        Dim subNode As TreeNode

        If node.Parent IsNot Nothing Then

            If driveAnalysis.IsDrive(node.Parent.Tag) Then
                pathSubTNode = node.Parent.Tag & node.Text

            Else
                pathSubTNode = node.Parent.Tag & "\" & node.Text

            End If

            cloneSubTNode.Name = pathSubTNode
            cloneSubTNode.Tag = pathSubTNode
        Else
            If driveAnalysis.IsDrive(node.Tag) Then
                pathSubTNode = node.Tag

                cloneSubTNode.Name = pathSubTNode.Substring(0, (pathSubTNode.Count - 1))
                cloneSubTNode.Tag = pathSubTNode
            End If
        End If

        For Each subNode In cloneSubTNode.Nodes

            'If clonedNode.Nodes.Item(0).Tag <> "carregando" And clonedNode.Nodes.Item(0).Tag <> "Mensagem" Then
            If subNode.Tag <> "carregando" And subNode.Tag <> "Mensagem" Then
                AtualizarSubNode(subNode)

            End If
        Next

        node.Nodes.Clear()

        Dim var As Integer
        For Each subNode In cloneSubTNode.Nodes
            node.Nodes.Insert(var, subNode)
            var += 1
        Next
        ' node.Toggle()

        Return node

    End Function


    Private Sub AtualizarDiretorioNoTreeView(node As TreeNode)
        ' Dim clonedNode As TreeNode = CType(node.Clone(), TreeNode)

        Dim directory As New DirectoryInfo(node.Tag)
        Dim subDirectories As DirectoryInfo() = directory.GetDirectories
        Dim dir As DirectoryInfo

        Dim tNode As TreeNode = node
        Dim subTNode As TreeNode
        ' TODO: Tratar ClonedNode
        Dim clonedNode As TreeNode = CType(node.Clone(), TreeNode)

        Dim adicionarAListaDeDiretorios As New ArrayList

        Dim adicionar As Boolean
        Dim nodeDoble As TreeNode

        If clonedNode.Nodes.Count <> 0 Then
            If clonedNode.Nodes.Item(0).Tag <> "carregando" And clonedNode.Nodes.Item(0).Tag <> "Mensagem" Then
                AtualizarSubNode(clonedNode)
            End If
        End If

        For Each subTNode In clonedNode.Nodes
            ' TODO : Incluir uma condição para checar se existe _
            ' node repetido e exclui lo.

            Dim dirCheck As New DirectoryInfo(subTNode.Tag)




            If nodeDoble IsNot Nothing Then
                If subTNode.Tag = nodeDoble.Tag Then
                    clonedNode.Nodes.Remove(subTNode)
                End If
            End If

            nodeDoble = CType(subTNode.Clone(), TreeNode)

            If dirCheck.Exists = False Then
                clonedNode.Nodes.Remove(subTNode)
            End If
        Next

        'Dim i As Integer
        'For Each subTNode In tNode.Nodes
        '    For Each subTNode2 In tNode.Nodes
        '        If subTNode.Tag = subTNode2.tag Then i += 1
        '        If i >= 2 Then tNode.Nodes.Remove(subTNode2)
        '    Next
        '    i = 0
        'Next

        For Each dir In subDirectories

            For Each subTNode In clonedNode.Nodes
                If dir.FullName = subTNode.Tag Then
                    subTNode.Text = dir.Name
                    adicionar = False
                    Exit For
                Else
                    adicionar = True

                End If
            Next

            If clonedNode.Nodes.Count = 0 Then adicionar = True
            If adicionar = True Then adicionarAListaDeDiretorios.Add(dir)

        Next

        For Each dirAdd As DirectoryInfo In adicionarAListaDeDiretorios

            subTNode = clonedNode.Nodes.Add(clonedNode.Name & "\" & dirAdd.Name, dirAdd.Name, "pastaFechada", "pastaFechada")
            subTNode.Tag = dirAdd.FullName
            subTNode.ContextMenuStrip = Me.CMItens

            subTNode.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"
        Next

        tNode.Nodes.Clear()

        Dim var As Integer
        For Each subNode As TreeNode In clonedNode.Nodes
            tNode.Nodes.Insert(var, subNode)
            var += 1
        Next

    End Sub

    Sub EditeNode(node As TreeNode)

        Dim x As String
        Dim prompt As String
        Dim title As String
        Dim h1 As String
        Dim defaultResponse As String

        Dim FRMInputBox As New FRMDialogInputBox

        ' TODO: https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.treenode.beginedit?view=netframework-4.8#System_Windows_Forms_TreeNode_BeginEdit
        ' https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.treenode?view=netframework-4.8

        Try
            If Not node.IsEditing Then
                If driveAnalysis.IsDrive(node.Tag) = True Then
                    Dim drive As New DriveInfo(node.Tag)

                    prompt = "Editar volume da unidade " & """" & node.Tag & """" &
                        Chr(13) & "Volume atual : " & """" & drive.VolumeLabel & """"

                    title = "Renomear Unidade"
                    h1 = "Editar volume da unidade:"
                    defaultResponse = drive.VolumeLabel

                    FRMInputBox.Prompt = prompt
                    FRMInputBox.Title = title
                    FRMInputBox.H1 = h1
                    FRMInputBox.DefaultResponse = defaultResponse

                    FRMInputBox.ShowDialog()

                    If FRMInputBox.DialogResult = DialogResult.OK Then

                        If drive.VolumeLabel <> FRMInputBox.Result Then
                            drive.VolumeLabel = FRMInputBox.Result
                            node.EndEdit(False)
                        End If

                    ElseIf FRMInputBox.DialogResult = DialogResult.Cancel Then

                    End If

                Else

                    node.BeginEdit()
                End If
            End If
        Catch ex As Exception

            MsgBox("Erro na instrução" & Chr(13) & "EditeNode" & Chr(13) & """" & ex.Message & """")

        End Try

    End Sub

    Private Sub TVWFilesAndFolders_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles TVWFilesAndFolders.AfterLabelEdit

        Dim _path As String()

        Dim node As TreeNode
        node = CType(e.Node, TreeNode)

        ' TODO: Tratar ClonedNode
        Dim clonedNode As TreeNode = CType(node.Clone(), TreeNode)

        Dim rotuloDoDrive As String
        Dim tamanhoDoDrive As String
        Dim letraDaUnidade As String
        Dim allDrive As String

        Dim _caminhosDeRenomeDePastas As FoldersPathsOperations

        Dim _destinationPath As String
        Dim _sourcePath As String
        Dim _destinationNewPath As String
        Dim _sourceNewPath As String
        Dim _destinationOldPath As String
        Dim _sourceOldPath As String

        Try
            Dim drive As DriveInfo
            If e.Node.Tag <> "carregando" Then
                drive = New DriveInfo(e.Node.Tag)
                'e.Node.EndEdit(True)
                'e.CancelEdit = True
            Else
                e.Node.EndEdit(True)
                e.CancelEdit = True
            End If

            If Not (e.Label Is Nothing) Then
                If e.Label.Length > 0 Then

                    If e.Label.IndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) = -1 Then

                        e.Node.EndEdit(False)
                        _caminhosDeRenomeDePastas = usesDirectories.RenameFolder(node.Tag, e.Label)

                        _sourcePath = _caminhosDeRenomeDePastas.sourcePath
                        _destinationPath = _caminhosDeRenomeDePastas.destinationPath

                        _sourceNewPath = _caminhosDeRenomeDePastas.sourceNewPath
                        _sourceOldPath = _caminhosDeRenomeDePastas.sourceOldPath

                        _destinationNewPath = _caminhosDeRenomeDePastas.destinationNewPath
                        _destinationOldPath = _caminhosDeRenomeDePastas.destinationOldPath

                        ' TODO: Programar testes. 
                        ' https://www.youtube.com/watch?v=jOa4u8p2hN0 

                        ' TODO: (OK) Entender pq ele está duplicando as as pastas e pq elas estão com as TAGs erradas.
                        ' TODO: SOLUÇÃO: Excluir a node ao inves de renomeá-la OU Atualizar as Subnodes depois de renomear o node pai.
                        ' TODO: Pode criar uma fução que cria um nodeFolder e substituir as ações.
                        ' TODO: TRATAMENTO DE NODE!: Este bloco pode ir para uma classe a parte?

                        Dim clonedParentNode As TreeNode = CType(node.Parent.Clone(), TreeNode)
                        If _sourceOldPath <> _sourceNewPath Then

                            Dim _sourceNewPath_Exist As Boolean = NodeTagExist(_sourceNewPath, clonedParentNode)

                            If _sourceNewPath_Exist = False Then   'node.Parent) = False Then
                                If My.Computer.FileSystem.DirectoryExists(_sourceNewPath) = True Then ' usesDirectories.FolderExist(_sourceNewPath) = True Then

                                    For Each tnode As TreeNode In clonedParentNode.Nodes   'node.Parent.Nodes
                                        If tnode.Tag = _sourceOldPath Then
                                            Dim dir As New DirectoryInfo(_sourceNewPath)
                                            tnode.Tag = dir.FullName
                                            tnode.Text = dir.Name
                                            tnode.Name = tnode.Tag
                                        End If
                                    Next

                                End If
                            Else
                                SearchAndRemoveTagNode(_sourceOldPath, clonedParentNode)   'node.Parent)
                            End If

                        Else
                            If _sourceOldPath <> _destinationOldPath Then
                                If _destinationNewPath = _destinationOldPath Then

                                    Dim _destinationOldPathNode_Exist As Boolean = NodeTagExist(_destinationOldPath, clonedParentNode)

                                    For Each tnode As TreeNode In clonedParentNode.Nodes 'node.Parent.Nodes
                                        If tnode.Tag = _sourceOldPath Then
                                            If _destinationOldPathNode_Exist = True Then 'node.Parent) = True Then
                                                tnode.Remove()
                                            Else
                                                Dim dir As New DirectoryInfo(_destinationOldPath)
                                                tnode.Tag = dir.FullName
                                                tnode.Text = dir.Name
                                                tnode.Name = tnode.Tag
                                            End If
                                        End If
                                    Next

                                End If
                            End If
                        End If

                        If _destinationOldPath <> _destinationNewPath Then

                            For Each tnode As TreeNode In clonedParentNode.Nodes   'node.Parent.Nodes
                                If NodeTagExist(_destinationNewPath, clonedParentNode) = False Then 'node.Parent) = False Then
                                    If My.Computer.FileSystem.DirectoryExists(_destinationNewPath) = True Then
                                        If tnode.Tag = _destinationOldPath Then
                                            Dim dir As New DirectoryInfo(_destinationOldPath)
                                            tnode.Tag = dir.FullName
                                            tnode.Text = dir.Name
                                            tnode.Name = tnode.Tag
                                        End If
                                    End If
                                Else
                                    If _destinationOldPath = _sourceNewPath Then
                                        SearchAndRemoveTagNode(_sourceOldPath, clonedParentNode) 'node.Parent)
                                    End If
                                End If
                            Next
                        End If

                        Dim nodeParent = node.Parent
                        nodeParent.Nodes.Clear()

                        'nodeParent.Nodes.AddRange(New System.Windows.Forms.TreeNode() {clonedParentNode.Nodes})
                        Dim var As Integer

                        For Each subNode As TreeNode In clonedParentNode.Nodes
                            If My.Computer.FileSystem.DirectoryExists(subNode.Tag) Then
                                nodeParent.Nodes.Insert(var, subNode)
                                var += 1
                            End If

                        Next


                        'If _caminhosDeRenomeDePastas.oldPathDestino = _caminhosDeRenomeDePastas.newPathDestino Then

                        'Else
                        '    For Each tnode As TreeNode In node.Parent.Nodes
                        '        If tnode.Tag = _caminhosDeRenomeDePastas.oldPathDestino Then
                        '            RenameNodeFolder(_caminhosDeRenomeDePastas.newPathDestino, tnode)

                        '        End If
                        '    Next
                        'End If
                        '  node.Tag = usesDirectories.RenomearPasta(node.Tag, e.Label)


                        'AtualizarDiretorioNoTreeView(node.Parent)

                        'If driveAnalysis.EDrive(e.Node.Tag) = True Then

                        '    letraDaUnidade = drive.Name

                        '    If drive.IsReady Then
                        '        rotuloDoDrive = CType(e.Label, String)

                        '        tamanhoDoDrive = CStr(drive.TotalSize.ToString & " Kb")
                        '    End If

                        '    If Not rotuloDoDrive Is Nothing Then
                        '        If rotuloDoDrive = "" Then
                        '            If drive.DriveType = 3 Then
                        '                rotuloDoDrive = "Disco Local"

                        '            ElseIf drive.DriveType = 5 Then
                        '                rotuloDoDrive = "Unidade de Disco Removível"
                        '                ' iconeDoDrive = "UnidadeVazia"
                        '            End If
                        '        End If
                        '        todoDrive = rotuloDoDrive & " (" & letraDaUnidade.Substring(0, 2) & ")"
                        '    Else

                        '        todoDrive = "(" & letraDaUnidade.Substring(0, 2) & ")"
                        '    End If

                        '    'e.Node.Text = e.Label.Insert(3, todoDrive)
                        '    e.Node.Text = todoDrive
                        '    e.Node.EndEdit(False)
                        'Else

                        '    e.Node.EndEdit(False)
                        'End If

                    Else
                        e.CancelEdit = True

                        MessageBox.Show("Arquivos e pastas não podem conter os seguintes caracteres em seus nomes:" &
                    Microsoft.VisualBasic.ControlChars.Cr &
                    "\ " & "/ " & "| " & ": " & "* " & "? " & """" & " < " & ">",
                    "Nomear/Renomear pasta")
                        e.Node.BeginEdit()
                    End If

                Else

                    If driveAnalysis.IsDrive(e.Node.Tag) = True Then

                        letraDaUnidade = drive.Name
                        allDrive = "(" & letraDaUnidade.Substring(0, 2) & ")"
                        e.Node.Text = allDrive
                        'todoDrive = "(" & letraDaUnidade.Substring(0, 2) & ")"
                        e.Node.BeginEdit()
                    Else
                        MessageBox.Show("O nome da pasta não pode ficar em branco")
                        e.Node.BeginEdit()
                    End If
                End If
            Else
                If e.Node.Text = "" Then
                    _path = StringFunctions.SepararPalavras(e.Node.Tag, delimitadoresDeCaminhoDePasta)
                    node.Text = _path(_path.Count - 1)
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro na Evento" & Chr(13) & "TVWFilesAndFolders_AfterLabelEdit" & Chr(13) & """" & ex.Message & """")

        End Try
    End Sub

    Function NodeTagExist(tag As String, nodeParent As TreeNode) As Boolean
        For Each tnode2 As TreeNode In nodeParent.Nodes
            If tnode2.Tag = tag Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    Sub SearchAndRemoveTagNode(tag As String, nodeParent As TreeNode)

        Dim arrayRemove As New ArrayList

        Try
            For Each tnode As TreeNode In nodeParent.Nodes
                If tnode.Tag = tag Then
                    'tnode.Remove()
                    arrayRemove.Add(tnode.Clone())
                End If
            Next

            For Each nodeRemove As TreeNode In arrayRemove
                nodeParent.Nodes.Remove(nodeRemove)
            Next

        Catch ex As Exception
            MsgBox("Erro na instrução" & Chr(13) & "SearchAndRemoveTagNode" & Chr(13) & """" & ex.Message & """")
        End Try
    End Sub

    Sub SearchAndRenameNodeTag(newNodePath_Tag As String, nodeParent As TreeNode)
        Dim dir As New DirectoryInfo(newNodePath_Tag)

        If dir.Exists Then
            For Each tnode As TreeNode In nodeParent.Nodes
                tnode.Tag = dir.FullName
                tnode.Text = dir.Name
                tnode.Name = tnode.Tag
            Next
        End If

    End Sub

    Sub RenameNodeFolder(newNodePath_Tag As String, node As TreeNode)
        Dim dir As New DirectoryInfo(newNodePath_Tag)

        If dir.Exists Then
            node.Tag = dir.FullName
            node.Text = dir.Name
            node.Name = node.Tag
        End If

    End Sub

    Private Sub RenomearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenomearToolStripMenuItem.Click
        If TVWFilesAndFolders.LabelEdit = True Then EditeNode(TVWFilesAndFolders.SelectedNode)
    End Sub

End Class
