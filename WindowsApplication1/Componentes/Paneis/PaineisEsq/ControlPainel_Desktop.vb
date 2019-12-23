Imports Microsoft.VisualBasic.FileIO


Public Class ControlPainel_Desktop
    Dim tipoDeArquivo As String
    Dim carregaArquivosNaArvore As Boolean
    Dim caminhoDaPastaSelecionada As String

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




    End Sub

    Function SepararPalavras(ByVal quebrarPalavras As String, ByVal delimitadores() As Char) As String()

        Dim palavras() As String
        palavras = quebrarPalavras.Split(delimitadores)
        Return palavras

    End Function

End Class
