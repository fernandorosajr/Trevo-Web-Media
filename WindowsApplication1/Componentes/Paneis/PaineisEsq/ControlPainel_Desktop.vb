Imports Microsoft.VisualBasic.FileIO

Public Class ControlPainel_Desktop
    Dim tipoDeArquivo As String

    Private Sub ControlPainel_Desktop_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadTree()

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
        ' MsgBox(tvRoot.Tag)

        tvRoot = tvNodeDeComputador.Nodes.Add("MyMusic", "Músicas", "Musicas", "Musicas")
        tvRoot.Tag = SpecialDirectories.MyMusic
        '  MsgBox(tvRoot.Tag)

        tvRoot = tvNodeDeComputador.Nodes.Add("MyPictures", "Imagens", "Imagens", "Imagens")
        tvRoot.Tag = SpecialDirectories.MyPictures
        ' MsgBox(tvRoot.Tag)

        tvRoot = tvNodeDeComputador.Nodes.Add("ProgramFiles", "ProgramFiles", "pastaFechada", "pastaAberta")
        tvRoot.Tag = SpecialDirectories.ProgramFiles
        ' MsgBox(tvRoot.Tag)

        tvRoot = tvNodeDeComputador.Nodes.Add("Programs", "Programs", "pastaFechada", "pastaAberta")
        tvRoot.Tag = SpecialDirectories.Programs
        ' MsgBox(tvRoot.Tag)

        tvRoot = tvNodeDeComputador.Nodes.Add("Temp", "Temp", "pastaFechada", "pastaAberta")
        tvRoot.Tag = SpecialDirectories.Temp
        ' MsgBox(tvRoot.Tag)

        'tvRoot = TVWFilesAndFolders.Nodes.Add("Desktop", "Área de Trabalho", "Desktop", "Desktop")
        'tvNodeDeDesktop = tvRoot

        'tvNode = tvRoot.Nodes.Add("Computador", "Computador", "Computador", "Computador")




    End Sub
End Class
