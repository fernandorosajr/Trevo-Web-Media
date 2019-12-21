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

        ' Cria o nódulo "Desktop", seus submódulos e o expande
        tvRoot = TVWDesktop.Nodes.Add("Desktop", "Área de Trabalho", "Desktop", "Desktop")
        tvNodeDeDesktop = tvRoot
        tvNodeDeDesktop.Tag = SpecialDirectories.Desktop

        tvNode = tvRoot.Nodes.Add("Computador", "Computador", "Computador", "Computador")
        tvNodeDeComputador = tvNode


    End Sub
End Class
