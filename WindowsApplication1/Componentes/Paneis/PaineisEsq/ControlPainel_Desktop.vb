﻿Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports System.Collections
' TODO: Menu de contexto
' TODO: O que fazer quando expande a pasta
' TODO: 
' TODO:
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
        '  LoadTree()

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

        ' Filtrar os tipos de arquivos que se deseja ver no Explorer 
        tipoDeArquivo = "*.*"

        ' Cria o nódulo "Computador", seus submódulos e o expande
        tvRoot = TVWFilesAndFolders.Nodes.Add("Computador", "Computador", "Computador", "Computador")
        tvNodeDeComputador = tvRoot

        tvRoot = tvNodeDeComputador.Nodes.Add("Desktop", "Área de Trabalho", "Desktop", "Desktop")
        tvNodeDeDesktop = tvRoot
        tvNodeDeDesktop.Tag = SpecialDirectories.Desktop

        tvRoot = tvNodeDeComputador.Nodes.Add("Documentos", "Documentos", "Documentos", "Documentos")
        tvRoot.Tag = SpecialDirectories.MyDocuments
        tvRoot.Nodes.Add("carregando", "Carregando...", "info", "info").Tag = "carregando"

        tvRoot = tvNodeDeComputador.Nodes.Add("MyMusic", "Músicas", "Musicas", "Musicas")
        tvRoot.Tag = SpecialDirectories.MyMusic
        tvRoot.Nodes.Add("carregando", "Carregando...", "info", "info").Tag = "carregando"

        tvRoot = tvNodeDeComputador.Nodes.Add("MyPictures", "Imagens", "Imagens", "Imagens")
        tvRoot.Tag = SpecialDirectories.MyPictures
        tvRoot.Nodes.Add("carregando", "Carregando...", "info", "info").Tag = "carregando"

        tvRoot = tvNodeDeComputador.Nodes.Add("ProgramFiles", "ProgramFiles", "pastaFechada", "pastaAberta")
        tvRoot.Tag = SpecialDirectories.ProgramFiles
        tvRoot.Nodes.Add("carregando", "Carregando...", "info", "info").Tag = "carregando"

        tvRoot = tvNodeDeComputador.Nodes.Add("Programs", "Programs", "pastaFechada", "pastaAberta")
        tvRoot.Tag = SpecialDirectories.Programs
        tvRoot.Nodes.Add("carregando", "Carregando...", "info", "info").Tag = "carregando"

        tvRoot = tvNodeDeComputador.Nodes.Add("Temp", "Temp", "pastaFechada", "pastaAberta")
        tvRoot.Tag = SpecialDirectories.Temp
        tvRoot.Nodes.Add("carregando", "Carregando...", "info", "info").Tag = "carregando"
        tvNodeDeComputador.Expand()


        'TODO: ( INCOMPLETO ) Encontra SubPastas da Area de trabalho e as adicionar 
        '_________________________________________________________________

        Dim AreaDeTrabalho As String
        Dim SubPastaDaAreaDeTrabalho As String
        Dim NomeDasSubPastasDaAreaDeTrabalho() As String
        Dim nomeDaSubPastaDaAreaDeTrabalho As String
        Dim nome As String
        Dim delimitadores() As Char = {"\"c, "/"c}

        AreaDeTrabalho = SpecialDirectories.Desktop
        NomeDasSubPastasDaAreaDeTrabalho = SepararPalavras(AreaDeTrabalho, delimitadores)


        Dim dirDir As New IO.DirectoryInfo(AreaDeTrabalho)
        Dim dirDir01 As IO.DirectoryInfo() = dirDir.GetDirectories()
        Dim drD As IO.DirectoryInfo

        For Each drD In dirDir01
            nome = drD.Name
            tvRoot = tvNodeDeDesktop.Nodes.Add("Desktop\" & nome, nome, "pastaFechada", "pastaAberta")
            tvRoot.Tag = drD.FullName
            tvRoot.Nodes.Add("carregando", "Carregando...", "info", "info").Tag = "carregando"
        Next

        '###############################################################
        '_______________________________________________________________

        ' TODO: Instruções para carregar os arquivos de Area de Trabalho
        '__________________________________________________________________

        ' se CarregarArquivosNaArvore for verdadeiro entao...
        ' carrega arquivos
        carregaArquivosNaArvore = True

        If carregaArquivosNaArvore = True Then
            caminhoDaPastaSelecionada = tvNodeDeDesktop.Tag

            Dim dirFiles As New IO.DirectoryInfo(caminhoDaPastaSelecionada)
            Dim dirArq01 As IO.FileInfo() = dirFiles.GetFiles()
            Dim dra As IO.FileInfo

            Dim iconImage As String
            Dim ext As String

            For Each dra In dirArq01

                ext = dra.Extension
                Select Case ext.ToLower
                    Case ".jpg", ".jpeg", ".gif"

                        iconImage = "Documentos"

                    Case Else
                        iconImage = "Documentos"

                End Select

                nome = dra.Name
                tvNodeDeDesktop.Nodes.Add("Desktop\" & nome, nome, iconImage, iconImage).Tag = dra.FullName

            Next

        End If

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
            tvNode.Tag = nomeDoDrive
            tvNode.Nodes.Add("carregando", "Carregando...", "info", "info").Tag = "carregando"

        Next

    End Sub

    Function SepararPalavras(ByVal quebrarPalavras As String, ByVal delimitadores() As Char) As String()

        Dim palavras() As String
        palavras = quebrarPalavras.Split(delimitadores)
        Return palavras

    End Function

    Private Sub TVWFilesAndFolders_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVWFilesAndFolders.AfterSelect
        Dim tsNode As TreeNode
        Try
            System.Windows.Forms.Application.DoEvents()

            tsNode = TVWFilesAndFolders.SelectedNode

            _caminho = TVWFilesAndFolders.SelectedNode.Tag

            Select Case tsNode.Name
                Case "Computador"

                Case "Desktop"

                Case Else
                    If tsNode.Tag <> Nothing Then
                        Dim dir As New DirectoryInfo(tsNode.Tag)

                        If dir.Exists = True Then
                            Dim dirSub As DirectoryInfo() = dir.GetDirectories
                            Dim dirArq1 As FileInfo() = dir.GetFiles()

                            '        TODO: Adicionar algoritimo de atualização da media: criar função  
                            '        TODO: Aplicar função criada em um evento de expansção de node ou seleção.
                            '        TODO: http://www.macoratti.net/13/12/vbn_list1.htm

                            AtualizarDiretorio(tsNode)


                            TVWFilesAndFolders.UseWaitCursor = True

                            TVWFilesAndFolders.UseWaitCursor = False

                            If tsNode.Parent.Name = "Computador" Then

                                Dim fullName As String
                                fullName = tsNode.FullPath
                                If fullName.IndexOf(":") = -1 Then Exit Sub

                                Dim drive01 As New DriveInfo(tsNode.Name)

                                If drive01.IsReady = False Then
                                    tsNode.Nodes.Clear()
                                    tsNode.Nodes.Add("O dispositivo não está acessível.")
                                    Exit Sub
                                End If

                                TVWFilesAndFolders.UseWaitCursor = False

                            End If
                        Else

                            TVWFilesAndFolders.UseWaitCursor = False
                            AtualizarDiretorio(tsNode)
                        End If
                    End If
            End Select

        Catch ex As Exception

            tsNode.Nodes.Clear()
            tsNode.Nodes.Add(tsNode.Name & "\info", ex.Message, "info", "info")
            tsNode.Expand()
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
            subTNode.Nodes.Add("carregando", "Carregando...", "info", "info").Tag = "carregando"

        Next


    End Sub
End Class
