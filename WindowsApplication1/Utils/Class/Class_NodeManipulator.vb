Imports System.IO
Imports System.IO.Path
Imports System.Security.Policy

Public Class Class_NodeManipulator

    'Importação de Classes
    '--------------------------------------------------
    Public ReadOnly stringFunctions As New StringFunctionsClass
    'Public renameActions As New Class_RenameActions
    '--------------------------------------------------

    Public Function AdicionarDiretorioNoNodo(key As String, name As String, tag As Object) As TreeNode

        Dim nodeAdiciondo As TreeNode
        Dim _nodeTreeList As New TreeNode

        nodeAdiciondo = _nodeTreeList.Nodes.Add(key, name)
        nodeAdiciondo.Tag = tag

        Return nodeAdiciondo

    End Function

    Public Overloads Function ListarNodosIrmaos(node As TreeNode, selected As Boolean) As List(Of TreeNode)

        Dim nodeListChecked As New List(Of TreeNode)
        Dim nodeListUnChecked As New List(Of TreeNode)
        Dim nodeListReturn As List(Of TreeNode)

        Dim nodeParent As TreeNode

        nodeParent = node.Parent

        For Each childNode As TreeNode In nodeParent.Nodes

            If childNode.Checked = True Then
                nodeListChecked.Add(childNode)
            Else
                nodeListUnChecked.Add(childNode)
            End If

        Next

        If selected = True Then
            nodeListReturn = nodeListChecked
        Else
            nodeListReturn = nodeListUnChecked
        End If

        Return nodeListReturn

    End Function

    Public Overloads Function ListarNodosIrmaos(node As TreeNode) As TreeNodeCollection
        Dim nodeParent As TreeNode
        Dim nodeIrmaos As TreeNodeCollection

        nodeParent = node.Parent

        If nodeParent IsNot Nothing Then
            nodeIrmaos = nodeParent.Nodes
        Else
            nodeIrmaos = Nothing
        End If

        Return nodeIrmaos

    End Function

    Public Function ListarNodosFilhos(selectedNode As TreeNode, dataRenameCriteriaList As List(Of Class_DataRenamingCriterion), Renamed_SelectedFoldersAndFiles As List(Of Object), index As Long)
        Dim file As FileInfo

        Dim indexFile As Long = index
        Dim indexFolder As Long = index
        If selectedNode.GetNodeCount(True) > 0 Then

        End If

        For Each child As TreeNode In selectedNode.Nodes
            If TypeOf child.Tag Is DirectoryInfo Then

                For Each selected In Renamed_SelectedFoldersAndFiles

                Next

            ElseIf TypeOf child.Tag Is FileInfo Then
                'file = renameActions.RenameAccordingToCriterion(child, dataRenameCriteriaList, indexFile)
                child.Text = file.Name
                indexFile = +1
            End If
        Next


    End Function

    Public Overloads Function PesquisaESelecionarNode(nodeAPesquisar As TreeNodeCollection, _path As String, nivel As Integer)
        Dim montagemDeNome As New List(Of String)
        Dim key As String

        Dim node As New TreeNode

        Dim delimitadoresSeCaminhoDePasta() As Char = {"\"c, "/"c}

        Dim nomesDasPastas() As String

        ' Separar nomes de pastas e arquivos em ArrayStrings
        nomesDasPastas = stringFunctions.SepararPalavras(_path, delimitadoresSeCaminhoDePasta)
        nomesDasPastas(0) = nomesDasPastas(0) + "\"

        If nivel < nomesDasPastas.Length Then

            For x = 0 To nivel
                montagemDeNome.Add(nomesDasPastas(x))

                key = Path.Combine(montagemDeNome.ToArray)

                For Each nodo As TreeNode In nodeAPesquisar
                    If nodo.Name = key Then

                        If nodo.GetNodeCount(True) > 0 Then
                            If x < nomesDasPastas.Length - 1 Then
                                node = PesquisaESelecionarNode(nodo.Nodes, nomesDasPastas, x + 1)

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

        End If
        Return node

    End Function

    Public Overloads Function PesquisaESelecionarNode(nodeAPesquisar As TreeNodeCollection, nomesDasPastas As Array, nivel As Integer)
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
                                node = PesquisaESelecionarNode(nodo.Nodes, nomesDasPastas, x + 1)

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

        End If
        Return node

    End Function

    Public Overloads Function CriarArvoreDeNodo(nodeRoot As TreeNode, folder As DirectoryInfo)
        Dim delimitadoresSeCaminhoDePasta() As Char = {"\"c, "/"c}

        Dim selected As Boolean
        Dim nomesDasPastas() As String

        Dim _path As String = folder.FullName
        Dim folderTest As DirectoryInfo

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

            folderTest = New DirectoryInfo(key)

            If folderTest.FullName = folder.FullName Then
                selected = True
            Else
                selected = False

            End If

            If node.GetNodeCount(True) > 0 Then


                If node.Nodes.Item(key) IsNot Nothing Then

                    subNode = node.Nodes.Item(key)

                    CriarArvoreDeNodo2(subNode, nomesDasPastas, x + 1, selected)

                    Exit For

                Else

                    subNode = nodeAtual.Nodes.Add(key, texto) 'node.Nodes.Add(key, texto)
                    subNode.Tag = New DirectoryInfo(key)

                    node.Nodes.Add(CriarArvoreDeNodo2(subNode, nomesDasPastas, x + 1, selected))
                    Exit For

                End If

            Else
                subNode = nodeAtual.Nodes.Add(key, texto).Clone
                subNode.Tag = New DirectoryInfo(key)
                node.Nodes.Add(CriarArvoreDeNodo2(subNode, nomesDasPastas, x + 1, selected))

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
        Dim changeNode As TreeNode
        nodo = PesquisaESelecionarNode(node.Nodes, nomesDasPastas, 1)

        'nodo.Checked = False

        changeNode = nodo.Nodes.Add(file.FullName, file.Name)
        changeNode.Tag = New FileInfo(file.FullName)
        changeNode.Checked = True

        Return node

    End Function

    Public Function CriarArvoreDeNodo2(nodeRoot As TreeNode, nomesDasPastas As Array, nivel As Integer, selected As Boolean)

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

            nodeRoot.Checked = selected
            node = nodeRoot
        End If

        For x = nivel To nomesDasPastas.Length - 1
            node = nodeRoot
            key = Path.Combine(montagemDeNome.ToArray)
            texto = nomesDasPastas(x)

            If nomesDasPastas(nomesDasPastas.Length - 1) = montagemDeNome(montagemDeNome.Count - 1) Then
                selected = True
            Else
                selected = False

            End If

            If node.GetNodeCount(True) > 0 Then


                If node.Nodes.Item(key) IsNot Nothing Then

                    subNode = node.Nodes.Item(key)

                    CriarArvoreDeNodo2(subNode, nomesDasPastas, x + 1, selected)

                    Exit For
                Else

                    subNode = nodeAtual.Nodes.Add(key, texto)
                    subNode.Tag = New DirectoryInfo(key)

                    node.Nodes.Add(CriarArvoreDeNodo2(subNode, nomesDasPastas, x + 1, selected))

                    Exit For
                End If

            Else

                subNode = nodeAtual.Nodes.Add(key, texto).Clone
                subNode.Tag = New DirectoryInfo(key)
                node.Nodes.Add(CriarArvoreDeNodo2(subNode, nomesDasPastas, x + 1, selected))

                Exit For

            End If
        Next

        Return node

    End Function

End Class
