Imports System.IO
Imports System.IO.Path
Imports System.Security.Policy

Public Class Class_NodeManipulator

    'Importação de Classes
    '--------------------------------------------------
    ReadOnly stringFunctions As New StringFunctionsClass
    '--------------------------------------------------

    Public Function AdicionarDiretorioNoNodo(key As String, name As String, tag As Object) As TreeNode

        Dim nodeAdiciondo As TreeNode
        Dim _nodeTreeList As New TreeNode

        nodeAdiciondo = _nodeTreeList.Nodes.Add(key, name)
        nodeAdiciondo.Tag = tag

        Return nodeAdiciondo

    End Function

    Public Function PesquisaNode(nodeAPesquisar As TreeNodeCollection, nomesDasPastas As Array, nivel As Integer)
        Dim montagemDeNome As New List(Of String)
        Dim key As String

        Dim node As New TreeNode

        If nivel < nomesDasPastas.Length Then

            For x = 0 To nivel
                montagemDeNome.Add(nomesDasPastas(x))

                key = Path.Combine(montagemDeNome.ToArray)

                For Each nodo As TreeNode In nodeAPesquisar
                    If nodo.Name = key Then

                        If nodo.GetNodeCount(True) > 0 Then
                            If x < nomesDasPastas.Length - 1 Then
                                node = PesquisaNode(nodo.Nodes, nomesDasPastas, x + 1)

                            Else
                                node = nodo
                            End If
                        Else
                            node = nodo
                        End If

                        Exit For

                    End If
                Next


            Next

        Else
            'node = nodeAPesquisar
        End If
        Return node

    End Function

    Public Overloads Function CriarArvoreDeNodo(nodeRoot As TreeNode, folder As DirectoryInfo)
        Dim delimitadoresSeCaminhoDePasta() As Char = {"\"c, "/"c}

        Dim _path As String = folder.FullName

        Dim nomesDasPastas() As String

        Dim montagemDeNome As New List(Of String)
        Dim key As String
        Dim texto As String

        Dim x As Integer

        Dim node As New TreeNode
        Dim subNode As New TreeNode
        Dim nodeAtual As New TreeNode

        ' Separar nomes de pastas e arquivos em ArrayStrings
        nomesDasPastas = stringFunctions.SepararPalavras(_path, delimitadoresSeCaminhoDePasta)
        nomesDasPastas(0) = nomesDasPastas(0) + "\"

        ' Pesquisar pelo node igual a array
        '       se nao achar igual criar novo
        '       se achar, selecionar o node e pecorrer para proximo arrayString
        '      

        montagemDeNome.Add(nomesDasPastas(0))

        node = nodeRoot

        For x = 1 To nomesDasPastas.Length - 1

            montagemDeNome.Add(nomesDasPastas(x))

            key = Path.Combine(montagemDeNome.ToArray)

            texto = nomesDasPastas(x)

            If node.GetNodeCount(True) > 0 Then

                If node.Nodes.Item(key) IsNot Nothing Then

                    subNode = node.Nodes.Item(key)
                    CriarArvoreDeNodo2(subNode, nomesDasPastas, x + 1)

                    Exit For

                Else

                    subNode = node.Nodes.Add(key, texto).Clone
                    subNode.Tag = New DirectoryInfo(key)

                    node.Nodes.Add(CriarArvoreDeNodo2(subNode, nomesDasPastas, x + 1))
                    Exit For

                End If

            Else
                subNode = nodeAtual.Nodes.Add(key, texto).Clone
                subNode.Tag = New DirectoryInfo(key)
                node.Nodes.Add(CriarArvoreDeNodo2(subNode, nomesDasPastas, x + 1))

                Exit For
            End If
        Next

        Return node

    End Function

    Public Overloads Function CriarArvoreDeNodo(nodeRoot As TreeNode, file As FileInfo)

        Dim delimitadoresSeCaminhoDePasta() As Char = {"\"c, "/"c}
        Dim _path As String = file.DirectoryName
        Dim _directory As New DirectoryInfo(_path)

        Dim nomesDasPastas() As String

        Dim node As New TreeNode
        Dim subNode As New TreeNode
        Dim nodeAtual As New TreeNode

        node = CriarArvoreDeNodo(nodeRoot, _directory)

        ' Separar nomes de pastas e arquivos em ArrayStrings
        nomesDasPastas = stringFunctions.SepararPalavras(_path, delimitadoresSeCaminhoDePasta)
        nomesDasPastas(0) = nomesDasPastas(0) + "\"

        Dim nodo As TreeNode
        nodo = PesquisaNode(node.Nodes, nomesDasPastas, 1)

        nodo.Nodes.Add(file.FullName, file.Name).Tag = New FileInfo(file.FullName)

        Return node

    End Function

    Public Function CriarArvoreDeNodo2(nodeRoot As TreeNode, nomesDasPastas As Array, nivel As Integer)

        Dim montagemDeNome As New List(Of String)
        Dim key As String
        Dim texto As String

        Dim node As New TreeNode
        Dim subNode As TreeNode
        Dim nodeAtual As New TreeNode

        If nivel < nomesDasPastas.Length Then

            For x = 0 To nivel
                montagemDeNome.Add(nomesDasPastas(x))
            Next

        Else

            node = nodeRoot
        End If

        For x = nivel To nomesDasPastas.Length - 1
            node = nodeRoot
            key = Path.Combine(montagemDeNome.ToArray)
            texto = nomesDasPastas(x)

            If node.GetNodeCount(True) > 0 Then

                If node.Nodes.Item(key) IsNot Nothing Then

                    subNode = node.Nodes.Item(key)

                    CriarArvoreDeNodo2(subNode, nomesDasPastas, x + 1)

                    Exit For
                Else

                    subNode = nodeAtual.Nodes.Add(key, texto)
                    subNode.Tag = New DirectoryInfo(key)

                    node.Nodes.Add(CriarArvoreDeNodo2(subNode, nomesDasPastas, x + 1))

                    Exit For
                End If

            Else

                subNode = nodeAtual.Nodes.Add(key, texto).Clone
                subNode.Tag = New DirectoryInfo(key)
                node.Nodes.Add(CriarArvoreDeNodo2(subNode, nomesDasPastas, x + 1))

                Exit For

            End If
        Next

        Return node

    End Function

End Class
