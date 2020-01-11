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

    Dim driveName As String
    Dim texto As String
    Dim delimitadoresDeCaminhoDePasta() As Char = {"\"c, "/"c}

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

        node = CType(e.Node, TreeNode)
        CarregarDiretorio(node)

        Dim _caminho As New DirectoryInfo(node.Tag)

        If node.Name = "Computador" Then
            TVWFilesAndFolders.LabelEdit = False

        ElseIf node.Parent.Name = "Computador" Then
            If EDrive(node.Tag) = True Then
                TVWFilesAndFolders.LabelEdit = _caminho.Exists

            Else
                TVWFilesAndFolders.LabelEdit = False
            End If

        Else
            TVWFilesAndFolders.LabelEdit = _caminho.Exists
        End If

        '    If TVWFilesAndFolders.LabelEdit = True Then editarNode(node)
        ' TODO: https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.treenode.beginedit?view=netframework-4.8#System_Windows_Forms_TreeNode_BeginEdit
        ' TODO: https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.treenode?view=netframework-4.8
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
                    subNode = node.Nodes.Add(node.Tag & "\" & x, x, "pastaFechada", "pastaFechada")
                    subNode.Tag = node.Tag & "\" & x

                    subNode.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"
                    subNode.ContextMenuStrip = CMItens
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub TVWFilesAndFolders_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVWFilesAndFolders.AfterSelect

        Dim tsNode As TreeNode
        System.Windows.Forms.Application.DoEvents()
        tsNode = TVWFilesAndFolders.SelectedNode
        _caminho = TVWFilesAndFolders.SelectedNode.Tag
        CarregarDiretorio(tsNode)

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
        listaDeDiretorios = SepararPalavras(SpecialDirectories.CurrentUserApplicationData, delimitadoresDeCaminhoDePasta)

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
        listaDeDiretorios = SepararPalavras(SpecialDirectories.CurrentUserApplicationData, delimitadoresDeCaminhoDePasta)

        caminhoDaPastaDoUsuario = listaDeDiretorios(0) & "\" & listaDeDiretorios(1) & "\" & listaDeDiretorios(2)
        Dim dir2 As New DirectoryInfo(caminhoDaPastaDoUsuario & "\Downloads")

        If dir2.Exists = False Then
            MkDir(caminhoDaPastaDoUsuario & "\Downloads")
        End If

        tvRoot = tvNodeDeComputador.Nodes.Add(caminhoDaPastaDoUsuario & "\Downloads", "Downloads", "down", "down")
        tvRoot.Tag = caminhoDaPastaDoUsuario & "\Downloads"
        tvRoot.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"


        'TODO: ( INCOMPLETO ) Encontra SubPastas da Area de trabalho e as adicionar 
        '_________________________________________________________________

        Dim AreaDeTrabalho As String
        Dim NomeDasSubPastasDaAreaDeTrabalho() As String
        Dim nome As String


        AreaDeTrabalho = SpecialDirectories.Desktop
        NomeDasSubPastasDaAreaDeTrabalho = SepararPalavras(AreaDeTrabalho, delimitadoresDeCaminhoDePasta)


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

    Sub CarregarDiretorio(node As TreeNode)

        Try
            ' TODO: Adicionar algoritimo de atualização da media: criar função (OK) 
            ' TODO: Aplicar função criada em um evento de expansão de node ou seleção. (OK)
            ' TODO: http://www.macoratti.net/13/12/vbn_list1.htm
            ' TODO: Adicionar pasta download (OK)
            ' eXCLUIR PASTAS especiais. (OK)

            Select Case node.Name
                Case "Computador"

                Case "Desktop"

                Case Else
                    If node.Tag <> Nothing Then
                        Dim dir As New DirectoryInfo(node.Tag)

                        Select Case EDrive(node.Tag)
                            Case True
                                Dim drive01 As New DriveInfo(node.Name)

                                If drive01.IsReady = True Then
                                    AtualizarDiretorio(node)
                                Else

                                    node.Nodes.Clear()
                                    node.Nodes.Add("Mensagem", "<O dispositivo não está acessível.>", "info", "info").Tag = "Mensagem"
                                    Exit Sub

                                End If

                            Case Else

                                If dir.Exists = True Then
                                    AtualizarDiretorio(node)

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

            subTNode = tNode.Nodes.Add(tNode.Name & "\" & dirAdd.Name, dirAdd.Name, "pastaFechada", "pastaFechada")
            subTNode.Tag = dirAdd.FullName
            subTNode.ContextMenuStrip = Me.CMItens

            subTNode.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"
        Next

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

        If fullName.IndexOf(":") <> -1 And fullName.Count = 3 Then
            Return True

        Else
            Return False

        End If
    End Function

    Sub editarNode(node As TreeNode)
        ' TODO: https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.treenode.beginedit?view=netframework-4.8#System_Windows_Forms_TreeNode_BeginEdit
        ' https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.treenode?view=netframework-4.8
        If EDrive(node.Tag) = True Then
            Dim drive As New DriveInfo(node.Tag)
            driveName = node.Text
            node.Text = drive.VolumeLabel
        End If

        If Not node.IsEditing Then
            node.BeginEdit()
        End If
    End Sub

    Private Sub TVWFilesAndFolders_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles TVWFilesAndFolders.AfterLabelEdit

        Dim _caminho As String()

        texto = e.Node.Text
        If Not (e.Label Is Nothing) Then
            If e.Label.Length > 0 Then

                If e.Label.IndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) = -1 Then
                    e.Node.EndEdit(False)
                Else
                    e.CancelEdit = True

                    MessageBox.Show("Arquivos e pastas não podem conter os seguintes caracteres em seus nomes:" &
                    Microsoft.VisualBasic.ControlChars.Cr &
                    "\ " & "/ " & "| " & ": " & "* " & "? " & """" & " < " & ">",
                    "Nomear/Renomear pasta")
                    e.Node.BeginEdit()
                End If

            Else

                If EDrive(e.Node.Tag) = True Then

                Else
                    MessageBox.Show("O nome da pasta não pode ficar em branco")
                    e.Node.Text = texto
                    e.Node.BeginEdit()
                End If
            End If
        Else
            If e.Node.Text = "" Then
                _caminho = SepararPalavras(e.Node.Tag, delimitadoresDeCaminhoDePasta)
                e.Node.Text = _caminho(_caminho.Count - 1)
            End If
        End If
    End Sub
End Class
