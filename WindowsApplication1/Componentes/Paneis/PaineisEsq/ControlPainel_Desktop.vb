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

        tvRoot = tvNodeDeComputador.Nodes.Add("MyMusic", "Músicas", "Musicas", "Musicas")
        tvRoot.Tag = SpecialDirectories.MyMusic

        tvRoot = tvNodeDeComputador.Nodes.Add("MyPictures", "Imagens", "Imagens", "Imagens")
        tvRoot.Tag = SpecialDirectories.MyPictures

        tvRoot = tvNodeDeComputador.Nodes.Add("ProgramFiles", "ProgramFiles", "pastaFechada", "pastaAberta")
        tvRoot.Tag = SpecialDirectories.ProgramFiles

        tvRoot = tvNodeDeComputador.Nodes.Add("Programs", "Programs", "pastaFechada", "pastaAberta")
        tvRoot.Tag = SpecialDirectories.Programs

        tvRoot = tvNodeDeComputador.Nodes.Add("Temp", "Temp", "pastaFechada", "pastaAberta")
        tvRoot.Tag = SpecialDirectories.Temp

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
            tvNodeDeDesktop.Nodes.Add("Desktop\" & nome, nome, "pastaFechada", "pastaAberta").Tag = drD.FullName


        Next

    End Sub

    Function SepararPalavras(ByVal quebrarPalavras As String, ByVal delimitadores() As Char) As String()

        Dim palavras() As String
        palavras = quebrarPalavras.Split(delimitadores)
        Return palavras

    End Function

End Class
