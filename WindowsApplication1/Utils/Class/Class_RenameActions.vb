Imports System.IO
Imports System.Collections
Imports System.Collections.Generic
' Trata os as listas de arquivos e pastas e os renomeiam segundo criterios.
Public Class Class_RenameActions
    '  Dim c As New Class_DataRenameOption
    ReadOnly _selectADataModeEnum As New Class_DataRenamingCriterion.SelectADataModeEnum
    ReadOnly _opcoesDeFormatacaoDeTexto As New Class_DataRenamingCriterion.OpcoesDeFormatacaoDeTextoEnum

    'Importação de Classes
    '--------------------------------------------------
    'ReadOnly funcoesDeString As New StringFunctionsClass
    Dim dateFunctions As New Class_Date
    Dim FormatAlphabetLetter As New Class_FormatAlphabetLetter
    Dim UsesFile As New UsesFilesClass
    Dim ManipuladorDeNodos As New Class_NodeManipulator

    '-------------------------------------------------

    Public Overloads Function Rename_SELECTED_LIST_AccordingToCriterion(SelectedFoldersAndFiles As List(Of Object), dataRenameCriteriaList As List(Of Class_DataRenamingCriterion), fuxoContinuoDeRenome As Boolean, reiniciarNoSubItem As Boolean, index As Long) As List(Of Object)

        ' TODO: (2) Receber valor de index esxternamente.
        ' TODO (3) Corrigir erro Minha "Pastinha Livre".

        ' Renomeia e devolve a lista de objetos renomedos baseado em critérios

        'Dim index As Long = 0
        Dim Renamed_SelectedFoldersAndFiles As New List(Of Object)
        Dim _selectedFoldersAndFiles As New List(Of String)

        Dim listFolders As New ArrayList

        ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/arrays/

        Dim dir As DirectoryInfo

        Dim indexFile As Long
        Dim indexFolder As Long

        Dim indexFile_Aux As Long
        Dim indexFolder_Aux As Long

        indexFolder = 0

        Dim file As FileInfo
        Dim folder As DirectoryInfo


        Dim node As New TreeNode
        Dim TreeViewList As New TreeView    'New List(Of TreeNode)
        Dim _nodeTreeList As New TreeNode   'New List(Of TreeNode)

        For Each obj As Object In SelectedFoldersAndFiles
            Dim nodeRoot As New TreeNode
            Dim _node As TreeNode
            Dim addNode As Boolean

            If TreeViewList.Nodes.Count > 0 Then
                For Each _node In TreeViewList.Nodes
                    Dim pathCompare As String = ""

                    If TypeOf obj Is FileInfo Then
                        pathCompare = obj.Directory.Root.FullName.ToString

                    ElseIf TypeOf obj Is DirectoryInfo Then
                        pathCompare = obj.Root.FullName.ToString

                    End If

                    If _node.FullPath.ToString = pathCompare Then
                        nodeRoot = _node
                        addNode = False
                        Exit For

                    Else
                        addNode = True
                    End If
                Next

                If addNode = True Then
                    Dim nome As String = obj.Root.FullName.ToString
                    Dim key As String = obj.Root.FullName.ToString
                    Dim directory As New DirectoryInfo(obj.Root.FullName.ToString)

                    nodeRoot = ManipuladorDeNodos.AdicionarDiretorioNoNodo(key, nome, directory)
                    TreeViewList.Nodes.Add(nodeRoot)

                    addNode = False
                End If

            Else
                Dim nome As String = obj.Root.FullName.ToString
                Dim key As String = obj.Root.FullName.ToString
                Dim directory As New DirectoryInfo(obj.Root.FullName.ToString)

                nodeRoot = ManipuladorDeNodos.AdicionarDiretorioNoNodo(key, nome, directory)
                TreeViewList.Nodes.Add(nodeRoot)
                nodeRoot = TreeViewList.Nodes.Item(nodeRoot.Name)

                addNode = False
            End If

            If TypeOf obj Is FileInfo Then
                file = obj

                ' Separar nomes de pastas e arquivos em ArrayStrings
                ' Em um for pecorrer a arrayString e ...
                ' Pesquisar pelo node igual a array
                '       se nao achar igual criar novo
                '       se achar, selecionar o node e pecorrer para proximo arrayString
                '       ' Use Path.Combine para escrever a key do node:
                '       ' o name da key pai combinando com o nome da pasta filho
                ' file vai ser adicionado no ultimo node criado.

                nodeRoot = (ManipuladorDeNodos.CriarArvoreDeNodo(nodeRoot, file))

            ElseIf TypeOf obj Is DirectoryInfo Then
                folder = obj

                nodeRoot = (ManipuladorDeNodos.CriarArvoreDeNodo(nodeRoot, folder))

            End If
        Next

        If fuxoContinuoDeRenome = True Then
            ' Renomear os ojetos no TreeView na ordem de seleção.
            '--------------------------------------------------------------------------------------
            For Each obj As Object In SelectedFoldersAndFiles

                Dim selectedObj As Object
                Dim selectedNode As TreeNode
                Dim path As String

                Dim newObj As Object

                path = obj.FullName

                selectedNode = ManipuladorDeNodos.PesquisaESelecionarNode(TreeViewList.Nodes, path, 1)

                selectedObj = RenameAccordingToCriterion(obj, dataRenameCriteriaList, index)

                selectedNode.Text = selectedObj.Name

                If TypeOf selectedNode.Tag Is DirectoryInfo Then
                    newObj = New DirectoryInfo(selectedNode.FullPath)

                ElseIf TypeOf selectedNode.Tag Is FileInfo Then
                    newObj = New FileInfo(selectedNode.FullPath)

                ElseIf TypeOf selectedNode.Tag Is DriveInfo Then
                    newObj = New DriveInfo(selectedNode.FullPath)

                End If

                Renamed_SelectedFoldersAndFiles.Add(newObj)

                index += 1

            Next

        Else

            Dim listaDeNodes As New List(Of List(Of TreeNode))
            Dim checarNodoPai As TreeNode
            Dim achouNodoPai As Boolean

            For Each obj As Object In SelectedFoldersAndFiles
                Dim selectedNode As TreeNode

                Dim path As String = obj.FullName

                Dim nodeIrmaos As List(Of TreeNode)



                selectedNode = ManipuladorDeNodos.PesquisaESelecionarNode(TreeViewList.Nodes, path, 1)
                nodeIrmaos = ManipuladorDeNodos.ListarNodosIrmaos(selectedNode, True)

                If listaDeNodes.Count > 0 Then
                    checarNodoPai = listaDeNodes(listaDeNodes.Count - 1)(0).Parent
                    achouNodoPai = False

                    For Each subListNode As List(Of TreeNode) In listaDeNodes
                        checarNodoPai = subListNode(0).Parent

                        If nodeIrmaos.Count > 0 Then

                            If checarNodoPai.FullPath = nodeIrmaos(0).Parent.FullPath Then
                                achouNodoPai = True
                                Exit For
                            End If

                        End If

                    Next
                End If

                If nodeIrmaos.Count > 0 Then

                    If achouNodoPai = False Then
                        listaDeNodes.Add(nodeIrmaos)

                    End If
                End If


            Next

            'TODO: Seria melhor por isto fora do for
            Dim sequnciaDaLetraInicial(dataRenameCriteriaList.Count - 1) As String

            If reiniciarNoSubItem = True Then
                Dim i As Integer = 0
                For Each criterion As Class_DataRenamingCriterion In dataRenameCriteriaList
                    sequnciaDaLetraInicial(i) = criterion.RenameTypeData.DadosDeSequenciaDeLetras.SequenciaDeLetra

                    i += 1
                Next

            End If

            For Each subList As List(Of TreeNode) In listaDeNodes
                indexFile = 0 'index
                indexFolder = 0 'index
                Dim nivel As Integer = 0
                Dim parentCheck As TreeNode
                Dim parentAnterior As TreeNode
                Dim itemAnterior As TreeNode

                Dim reiniciarAgora As Boolean



                If subList.Count > 0 Then
                    nivel = subList(0).Level
                    If subList(0).Parent IsNot Nothing Then parentCheck = subList(0).Parent
                End If

                For Each childNode As TreeNode In subList
                    If TypeOf childNode.Tag Is DirectoryInfo Then

                        Dim newFolder As DirectoryInfo


                        If parentAnterior IsNot Nothing Then

                            If parentAnterior.Tag.FullName <> childNode.Parent.Tag.FullName Then

                                indexFolder_Aux = 0

                                If reiniciarNoSubItem = True Then reiniciarAgora = True

                            Else

                            End If

                            If TypeOf itemAnterior.Tag IsNot DirectoryInfo Then

                                indexFolder_Aux = 0

                                If reiniciarNoSubItem = True Then reiniciarAgora = True
                            End If
                        End If

                        If reiniciarNoSubItem = True Then

                            If reiniciarAgora = True Then
                                'ReiniciarSequenciaDeLetra()

                                For Each criterion As Class_DataRenamingCriterion In dataRenameCriteriaList
                                    criterion.RenameTypeData.DadosDeSequenciaDeLetras.SequenciaDeLetra = "A"
                                Next

                                'reiniciarAgora = False
                            Else

                                For ii = 0 To sequnciaDaLetraInicial.Length - 1
                                    dataRenameCriteriaList(ii).RenameTypeData.DadosDeSequenciaDeLetras.SequenciaDeLetra = sequnciaDaLetraInicial(ii)

                                Next

                            End If

                        End If

                        newFolder = (RenameAccordingToCriterion(childNode.Tag, dataRenameCriteriaList, indexFolder_Aux))

                        childNode.Text = newFolder.Name

                        parentAnterior = parentCheck
                        itemAnterior = childNode

                        If childNode.Level <> nivel Then
                            indexFolder_Aux = indexFolder
                            reiniciarAgora = True

                        Else
                            If parentCheck.FullPath <> childNode.Parent.FullPath Then
                                indexFolder_Aux = indexFolder
                                reiniciarAgora = True
                            Else
                                indexFolder_Aux += 1

                                reiniciarAgora = False

                            End If

                        End If

                    ElseIf TypeOf childNode.Tag Is FileInfo Then
                        Dim newFile As FileInfo


                        If parentAnterior IsNot Nothing Then


                            If parentAnterior.Tag.FullName <> childNode.Parent.Tag.FullName Then
                                indexFile_Aux = 0
                                If reiniciarNoSubItem = True Then reiniciarAgora = True

                            Else
                                If TypeOf itemAnterior.Tag IsNot FileInfo Then
                                    indexFile_Aux = 0
                                    If reiniciarNoSubItem = True Then reiniciarAgora = True
                                End If
                            End If
                        End If

                        If reiniciarNoSubItem = True Then
                            If reiniciarAgora = True Then
                                'ReiniciarSequenciaDeLetra()

                                For Each criterion As Class_DataRenamingCriterion In dataRenameCriteriaList
                                    criterion.RenameTypeData.DadosDeSequenciaDeLetras.SequenciaDeLetra = "A"
                                Next

                                'reiniciarAgora = False
                            Else

                                For ii = 0 To sequnciaDaLetraInicial.Length - 1
                                    dataRenameCriteriaList(ii).RenameTypeData.DadosDeSequenciaDeLetras.SequenciaDeLetra = sequnciaDaLetraInicial(ii)

                                Next

                            End If

                        End If

                        newFile = (RenameAccordingToCriterion(childNode.Tag, dataRenameCriteriaList, indexFile_Aux))

                        childNode.Text = newFile.Name


                        parentAnterior = parentCheck
                        itemAnterior = childNode


                        If childNode.Level <> nivel Then
                            indexFile_Aux = indexFile
                            reiniciarAgora = False

                        Else
                            If parentCheck.FullPath <> childNode.Parent.FullPath Then
                                indexFile_Aux = indexFile
                                reiniciarAgora = True

                            Else
                                indexFile_Aux += 1
                                reiniciarAgora = False

                            End If

                        End If


                        'index2 += 1


                    ElseIf TypeOf childNode.Tag Is DriveInfo Then

                    End If
                Next

                'index += 1

            Next

            For Each obj As Object In SelectedFoldersAndFiles
                Dim path As String
                Dim selectedNode As TreeNode

                path = obj.FullName

                selectedNode = ManipuladorDeNodos.PesquisaESelecionarNode(TreeViewList.Nodes, path, 1)

                If TypeOf obj Is DirectoryInfo Then

                    folder = New DirectoryInfo(selectedNode.FullPath)

                    Renamed_SelectedFoldersAndFiles.Add(folder)

                ElseIf TypeOf obj Is FileInfo Then

                    file = New FileInfo(selectedNode.FullPath)

                    Renamed_SelectedFoldersAndFiles.Add(file)


                ElseIf TypeOf obj Is DriveInfo Then

                End If
            Next


        End If


        ' Renomear os ojetos no TreeView na ordem das pastas;
        '--------------------------------------------------------------------------------------

        ' Procurar pastas na lista de seleção
        ' Se achar entao
        '           ' ExistePasta = True
        '           ' Criar uma lista de pastas na ordem que se apresenta na lista de seleção
        '           ' Criar uma varivel X de nível baseado na maior profundidade de niveis da pasta encontrada
        '           ' Dividir em uma matriz de indice X e salvar a lista de 
        ' Pesquisar correr



        '    ' https://docs.microsoft.com/pt-br/dotnet/api/system.array.findindex?view=netcore-3.1
        '    ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/procedures/lambda-expressions
        '    ' https://docs.microsoft.com/pt-br/dotnet/api/system.array.exists?view=netcore-3.1#System_Array_Exists__1___0___System_Predicate___0__




        Return Renamed_SelectedFoldersAndFiles

    End Function



    Public Function CriarListaDePastasRenomedasEOriginais(obj As Object, dataRenameCriteriaList As List(Of Class_DataRenamingCriterion), indexfolder As Long) As ArrayList
        ' Criar Lista de pasta renomeada e seus nomes originais
        ' --------------------------------------------------------------------------

        Dim listFoldersArray(1) As DirectoryInfo
        Dim dir As Object
        Dim dirRename As DirectoryInfo
        Dim listFolders As New ArrayList

        If TypeOf obj Is String Then
            dir = New DirectoryInfo(obj)
        Else
            dir = obj
        End If


        dirRename = RenameAccordingToCriterion(dir, dataRenameCriteriaList, indexfolder)

        listFoldersArray(0) = New DirectoryInfo(dir.FullName)
        listFoldersArray(1) = New DirectoryInfo(dirRename.FullName)

        listFolders.Add(listFoldersArray)

        Return listFolders

        ' --------------------------------------------------------------------------
    End Function

    Public Overloads Function RenomearPastasEPastasPaiEmUmaListaDeSelecao2(fileSelected As FileInfo, listFolders As ArrayList)
        Dim pathFileRenamed As FileInfo
        Dim folderParent As New DirectoryInfo(fileSelected.DirectoryName)
        Dim newPath As String = fileSelected.FullName

        For Each subFolder In listFolders

            If subFolder(0).FullName = folderParent.FullName Then

                newPath = subFolder(1).FullName & "\" & fileSelected.Name

                Exit For

            End If

        Next

        pathFileRenamed = New FileInfo(newPath)

        Return pathFileRenamed

    End Function

    Public Overloads Function RenomearPastasEPastasPaiEmUmaListaDeSelecao2(folderSelected As DirectoryInfo, listFolders As ArrayList)
        Dim pathRenamed As DirectoryInfo = folderSelected

        For Each subFolder In listFolders

            If subFolder(0).FullName = folderSelected.FullName Then

                pathRenamed = subFolder(1)

                Exit For

            End If

        Next


        Return pathRenamed

    End Function

    Public Overloads Function RenomearPastasEPastasPaiEmUmaListaDeSelecao(listFolders As ArrayList, SelectedFoldersAndFiles As List(Of Object), _selectedFoldersAndFiles As List(Of String), index As Long) As List(Of String)

        ' Renomeia pastas e pastas pai de um arquivo em uma lista de seleção
        ' ---------------------------------------------------------------------------
        ' Dim _selectedFoldersAndFiles As New List(Of String)

        Dim file As FileInfo
        Dim filePath As String '= file.FullName.ToString

        Dim folder As DirectoryInfo
        Dim folderParent As DirectoryInfo
        Dim folderPath As String

        Dim parte1_DoCaminho As String
        Dim parte2_DoCaminho As String
        Dim qDeCharDaParte1_DoCaminho As Integer
        Dim qDeCharDaParte2_DoCaminho As Integer
        Dim caminhoParaConferir As String
        Dim diretorioNoCaminhoDadoAchado As New ArrayList

        Dim ultimoIndexChecado As Long
        Dim indexfolder As Long

        Dim x As Integer
        For Each subFolder In listFolders

            Do While index > -1

                'FormatAlphabetLetter.StringFunctions.

                If TypeOf SelectedFoldersAndFiles(index) Is FileInfo Then
                    diretorioNoCaminhoDadoAchado.Clear()

                    file = New FileInfo(_selectedFoldersAndFiles(index))
                    folderParent = New DirectoryInfo(file.DirectoryName)


                    diretorioNoCaminhoDadoAchado.AddRange(ProcuraDiretorioNoCaminhoDado(folderParent, subFolder(0)))
                    caminhoParaConferir = diretorioNoCaminhoDadoAchado(0)
                    parte2_DoCaminho = diretorioNoCaminhoDadoAchado(1)


                    If subFolder(0).FullName = caminhoParaConferir Then
                        folderParent = New DirectoryInfo(subFolder(1).FullName.ToString & parte2_DoCaminho)

                        file = New FileInfo(folderParent.FullName & "\" & file.Name)

                    End If


                    '' TODO: (3) Subistituir esta condição por :
                    '' if trim(parte2_DoCaminho) = ""  then

                    'If subFolder(0).FullName.ToString.Length = caminhoParaConferir.Length Then
                    '    folder = subFolder(1)

                    'Else
                    '    folder = New DirectoryInfo(subFolder(1).ToString & "\" & parte2_DoCaminho)
                    'End If



                    _selectedFoldersAndFiles(index) = file.FullName


                ElseIf TypeOf SelectedFoldersAndFiles(index) Is DirectoryInfo Then

                    ' Function ProcuraDiretorioNoCaminhoDado

                    diretorioNoCaminhoDadoAchado.Clear()
                    folder = New DirectoryInfo(_selectedFoldersAndFiles(index))


                    diretorioNoCaminhoDadoAchado.AddRange(ProcuraDiretorioNoCaminhoDado(folder, subFolder(0)))
                    caminhoParaConferir = diretorioNoCaminhoDadoAchado(0)
                    parte2_DoCaminho = diretorioNoCaminhoDadoAchado(1)

                    Dim subListFolder As New ArrayList
                    Dim listFoldersArray(1) As DirectoryInfo
                    If subFolder(0).FullName = caminhoParaConferir Then

                        ' TODO: (3) Subistituir esta condição por :
                        ' if trim(parte2_DoCaminho) = ""  then

                        If subFolder(0).FullName.ToString.Length = caminhoParaConferir.Length Then
                            folder = New DirectoryInfo(subFolder(1).ToString & parte2_DoCaminho)


                        Else
                            folder = New DirectoryInfo(subFolder(1).ToString & parte2_DoCaminho)
                        End If

                    End If

                    _selectedFoldersAndFiles(index) = folder.FullName

                End If

                If index <> -1 Then index += 1

                index = Array.FindIndex(SelectedFoldersAndFiles.ToArray, index, Function(path)

                                                                                    Dim valor As Boolean = False

                                                                                    If TypeOf path Is FileInfo Then


                                                                                        valor = ChecarSePastaEhSubPasta(path.Directory, subFolder(0))

                                                                                    ElseIf TypeOf path Is DirectoryInfo Then



                                                                                        valor = ChecarSePastaEhSubPasta(path, subFolder(0))
                                                                                    End If

                                                                                    Return valor

                                                                                End Function)


                If index > -1 Then ultimoIndexChecado = index
            Loop

            index = ultimoIndexChecado

            indexfolder += 1
        Next

        Return _selectedFoldersAndFiles

    End Function

    Public Function ProcuraDiretorioNoCaminhoDado(caminhoDado As DirectoryInfo, diretorioParaPesquisa As DirectoryInfo)

        Dim caminhoDado_str As String
        Dim x As Integer
        Dim qDeCharDaParte1_DoCaminho As Integer
        Dim caminhoParaConferir As String
        Dim value As New ArrayList

        Dim parte2_DoCaminho As String

        caminhoDado_str = caminhoDado.FullName.ToString

        x = caminhoDado_str.IndexOf(diretorioParaPesquisa.FullName)

        If x < 0 Then
            caminhoParaConferir = caminhoDado.FullName
            parte2_DoCaminho = ""

        Else

            qDeCharDaParte1_DoCaminho = diretorioParaPesquisa.FullName.ToString.Length

            caminhoParaConferir = (caminhoDado_str.Substring(x, qDeCharDaParte1_DoCaminho))
            parte2_DoCaminho = caminhoDado_str.Substring(diretorioParaPesquisa.FullName.ToString.Length, caminhoDado_str.Length - diretorioParaPesquisa.FullName.ToString.Length)

        End If

        value.Add(caminhoParaConferir)
        value.Add(parte2_DoCaminho)

        Return value

    End Function

    Public Function ChecarSePastaEhSubPasta(caminhoDaSubPasta As DirectoryInfo, caminhoDaPasta As DirectoryInfo)
        Dim value As Boolean = False
        ' Dim folder As DirectoryInfo
        Dim subFolderPath_Str As String
        Dim x As Integer
        Dim qDeCharDaParte1_DoCaminho As Integer

        Dim caminhoParaConferir As String

        subFolderPath_Str = caminhoDaSubPasta.FullName.ToString

        x = subFolderPath_Str.IndexOf(caminhoDaPasta.FullName)
        If x < 0 Then
            value = False
            caminhoParaConferir = caminhoDaSubPasta.FullName

        Else

            qDeCharDaParte1_DoCaminho = caminhoDaPasta.FullName.ToString.Length

            caminhoParaConferir = subFolderPath_Str.Substring(x, qDeCharDaParte1_DoCaminho)

        End If


        If caminhoParaConferir = caminhoDaPasta.FullName Then
            value = True
        End If

        Return value

    End Function

    Public Overloads Function RenameAccordingToCriterion(file As FileInfo, criteria As List(Of Class_DataRenamingCriterion), index As Long)
        Dim _newName As String '= ""
        Dim _newFile As FileInfo

        Dim _strData As String = ""

        Dim nomeDoArquivo As String = ""
        Dim extDoArquivo As String = ""
        Dim temExtensao As Boolean = False


        For Each _criterion In criteria


            Select Case _criterion.RenameTypeData.Tela

                Case _selectADataModeEnum.Texto

                    _strData = _criterion.RenameTypeData.Text

                    If _criterion.RenameTypeData.Text Is Nothing Then
                        _strData = ""
                    End If

                Case _selectADataModeEnum.DataEHora

                    Dim todayDate As Date = Date.Now
                    Dim _dataDate As Date

                    Dim creationTimeDate As Date = file.CreationTime
                    Dim lastWriteDate As Date = file.LastWriteTime

                    Dim yesterdayDate As Date = todayDate.AddDays(-1)
                    Dim tomorrowDate As Date = todayDate.AddDays(+1)

                    Select Case _criterion.RenameTypeData.DadosDeTempo.TempoDaData

                        Case 9
                            ' Data de criacao
                            _dataDate = creationTimeDate
                        Case 10
                            ' Data de modificacao
                            _dataDate = lastWriteDate

                        Case 11
                            'Ontem
                            _dataDate = yesterdayDate

                        Case 12
                            'Hoje
                            _dataDate = todayDate

                        Case 13
                            ' Amanha
                            _dataDate = tomorrowDate

                    End Select

                    _strData = dateFunctions.TrasnformDate(_dataDate, _criterion)



                Case _selectADataModeEnum.LetraDaSequencia
                    _strData = FormatAlphabetLetter.FormatarLetraDoAlfabeto(_criterion, index)

                Case _selectADataModeEnum.Metadados

                Case _selectADataModeEnum.NomeDaPasta
                    Dim folder As New DirectoryInfo(file.DirectoryName)
                    '     _opcoesDeFormatacaoDeTexto
                    ' FormatAlphabetLetter.funcoesDeString.
                    _strData = folder.Name

                    Select Case _criterion.RenameTypeData.DadosDeNomeDaPasta.OpcoesDeFormatacaoDeTextoDaPasta

                        Case _opcoesDeFormatacaoDeTexto.ComoOOriginal

                        Case _opcoesDeFormatacaoDeTexto.primeiraLetraMinúnsculaDemaisPrimeriasMaiúsculas
                            _strData = FormatAlphabetLetter.StringFunctions.ConvertTheFirstLettersToUppercase(_strData, False)

                        Case _opcoesDeFormatacaoDeTexto.PrimeirasLetrasMaiusculas

                            Dim _firstLetterUpper As Boolean = _criterion.RenameTypeData.DadosDeNomeDaPasta.PrimeiraLetraMinusculaDeNomeDaPasta

                            Dim _removeSpace As Boolean = _criterion.RenameTypeData.DadosDeNomeDaPasta.RemoverEspacoDeNomeDaPasta

                            Dim new_value As String = FormatAlphabetLetter.StringFunctions.ConvertTheFirstLettersToUppercase(_strData, _firstLetterUpper)

                            '_strData = FormatAlphabetLetter.funcoesDeString.ConvertTheFirstLettersToUppercase(_strData)


                            If _removeSpace = True Then
                                new_value = FormatAlphabetLetter.StringFunctions.ReplacePhrase(new_value, " ", "")
                            End If

                            _strData = new_value

                        Case _opcoesDeFormatacaoDeTexto.pRIMEIRASlETRASmINUSCULAS
                            _strData = FormatAlphabetLetter.StringFunctions.ConvertTheFirstLettersToLowercase(_strData)

                        Case _opcoesDeFormatacaoDeTexto.TODASMAIUSCULAS
                            _strData = _strData.ToString.ToUpper

                        Case _opcoesDeFormatacaoDeTexto.todasMinusculas
                            _strData = _strData.ToString.ToLower


                    End Select

                Case _selectADataModeEnum.SequenciaNumerica
                    Dim _qDeCaracteres As Integer = _criterion.DadosDeSequenciaNumerica.QuantidadeDeDigitosDaSequenciaNumerica
                    _strData = FormatAlphabetLetter.StringFunctions.AddCaracterDeRepeticao(_strData, _qDeCaracteres)

                Case _selectADataModeEnum.NomeDoArquivoAtual


                    Dim _value As String = ""

                    _value = UsesFile.ReturnFileNameOrFolderAndOrExtension(file, _criterion.RenameTypeData.DadosDeNomeDeArquivoAtual.OpcoesDeFormatacaoDeTexto)
                    _strData = _value

                Case _selectADataModeEnum.NovaExtensao

                    temExtensao = True

                    _strData = UsesFile.ReturnExt(file)

                Case _selectADataModeEnum.SubstituicaoDeString

                    Dim _find As String = _criterion.RenameTypeData.DadosDeSubstituicao.Find
                    'TXTPFind.TXT
                    Dim _replacement As String = _criterion.RenameTypeData.DadosDeSubstituicao.Replacement
                    'TXTPReplacement.TXT

                    Dim _ignoreUpperLower As Boolean = _criterion.RenameTypeData.DadosDeSubstituicao.IgnoreUpperLowerOfReplacementData
                    Dim _replaceAll As Boolean = _criterion.RenameTypeData.DadosDeSubstituicao.ReplaceAllReplacementData

                    _strData = FormatAlphabetLetter.StringFunctions.ReplacePhrase(file.Name, _find, _replacement, _ignoreUpperLower, _replaceAll)


            End Select


            If temExtensao = False Then
                nomeDoArquivo += _strData

            Else
                extDoArquivo += _strData

            End If
        Next



        _newName = file.DirectoryName & "\" & nomeDoArquivo & extDoArquivo

        _newFile = New FileInfo(_newName)

        Return _newFile

    End Function

    Public Overloads Function RenameAccordingToCriterion(obj As Object, criteria As List(Of Class_DataRenamingCriterion), index As Long)
        Dim newName As String '= ""
        Dim newFullName As String = ""

        Dim aFile As FileInfo
        Dim aFolder As DirectoryInfo

        Dim newObj As Object = obj

        Dim objIsFile As Boolean
        Dim objIsDirectory As Boolean

        Dim _strData As String = ""

        Dim nomeDoArquivo As String = ""
        Dim extDoArquivo As String = ""
        Dim _isExtension As Boolean = False

        ' Define o tipo do obj 
        If TypeOf obj Is FileInfo Then
            objIsFile = True
            objIsDirectory = Not (objIsFile)

        ElseIf TypeOf obj Is DirectoryInfo Then
            objIsDirectory = True
            objIsFile = Not (objIsDirectory)

        Else
            objIsDirectory = False
            objIsFile = objIsDirectory
        End If

        For Each _criterion In criteria


            Select Case _criterion.RenameTypeData.Tela

                Case _selectADataModeEnum.Texto


                    _strData = _criterion.RenameTypeData.Text

                    If _criterion.RenameTypeData.Text Is Nothing Then
                        _strData = ""
                    End If


                Case _selectADataModeEnum.DataEHora

                    Dim todayDate As Date = Date.Now
                    Dim _dataDate As Date



                    Dim creationTimeDate As Date = obj.CreationTime
                    Dim lastWriteDate As Date = obj.LastWriteTime

                    Dim yesterdayDate As Date = todayDate.AddDays(-1)
                    Dim tomorrowDate As Date = todayDate.AddDays(+1)

                    Dim tempoDaData As Class_DataRenamingCriterion.TempoDaDataEnum

                    Select Case _criterion.RenameTypeData.DadosDeTempo.TempoDaData

                        Case tempoDaData.DataDeCriacao
                            ' Data de criacao
                            _dataDate = creationTimeDate

                        Case tempoDaData.DataDeModificacao

                            ' Data de modificacao
                            _dataDate = lastWriteDate

                        Case tempoDaData.Ontem

                            'Ontem
                            _dataDate = yesterdayDate

                        Case tempoDaData.Hoje
                            'Hoje
                            _dataDate = todayDate

                        Case tempoDaData.Amanha
                            ' Amanha
                            _dataDate = tomorrowDate

                    End Select

                    _strData = dateFunctions.TrasnformDate(_dataDate, _criterion)



                Case _selectADataModeEnum.LetraDaSequencia
                    _strData = FormatAlphabetLetter.FormatarLetraDoAlfabeto(_criterion, index)

                Case _selectADataModeEnum.Metadados

                Case _selectADataModeEnum.NomeDaPasta

                    Dim parentPath As DirectoryInfo ' = New DirectoryInfo("")

                    If TypeOf obj Is DirectoryInfo Then
                        aFolder = obj
                        parentPath = New DirectoryInfo(aFolder.Parent.FullName)

                    ElseIf TypeOf obj Is FileInfo Then
                        aFile = obj
                        parentPath = New DirectoryInfo(aFile.DirectoryName)

                    End If

                    Dim folder As New DirectoryInfo(parentPath.FullName)
                    '     _opcoesDeFormatacaoDeTexto
                    ' FormatAlphabetLetter.funcoesDeString.
                    _strData = folder.Name

                    Select Case _criterion.RenameTypeData.DadosDeNomeDaPasta.OpcoesDeFormatacaoDeTextoDaPasta

                        Case _opcoesDeFormatacaoDeTexto.ComoOOriginal

                        Case _opcoesDeFormatacaoDeTexto.primeiraLetraMinúnsculaDemaisPrimeriasMaiúsculas
                            _strData = FormatAlphabetLetter.StringFunctions.ConvertTheFirstLettersToUppercase(_strData, False)

                        Case _opcoesDeFormatacaoDeTexto.PrimeirasLetrasMaiusculas

                            Dim _firstLetterUpper As Boolean = _criterion.RenameTypeData.DadosDeNomeDaPasta.PrimeiraLetraMinusculaDeNomeDaPasta

                            Dim _removeSpace As Boolean = _criterion.RenameTypeData.DadosDeNomeDaPasta.RemoverEspacoDeNomeDaPasta

                            Dim new_value As String = FormatAlphabetLetter.StringFunctions.ConvertTheFirstLettersToUppercase(_strData, _firstLetterUpper)

                            '_strData = FormatAlphabetLetter.funcoesDeString.ConvertTheFirstLettersToUppercase(_strData)


                            If _removeSpace = True Then
                                new_value = FormatAlphabetLetter.StringFunctions.ReplacePhrase(new_value, " ", "")
                            End If

                            _strData = new_value

                        Case _opcoesDeFormatacaoDeTexto.pRIMEIRASlETRASmINUSCULAS
                            _strData = FormatAlphabetLetter.StringFunctions.ConvertTheFirstLettersToLowercase(_strData)

                        Case _opcoesDeFormatacaoDeTexto.TODASMAIUSCULAS
                            _strData = _strData.ToString.ToUpper

                        Case _opcoesDeFormatacaoDeTexto.todasMinusculas
                            _strData = _strData.ToString.ToLower


                    End Select

                Case _selectADataModeEnum.SequenciaNumerica

                    Dim _qDeCaracteres As Integer = _criterion.RenameTypeData.DadosDeSequenciaNumerica.QuantidadeDeDigitosDaSequenciaNumerica

                    _strData = _criterion.RenameTypeData.DadosDeSequenciaNumerica.NumeroDeSequencia

                    Dim value As String = FormatAlphabetLetter.StringFunctions.FormatarNumberToQCaracter(_strData)

                    value = CInt(value) + index

                    _strData = FormatAlphabetLetter.StringFunctions.AddCaracterDeRepeticao(value, _qDeCaracteres)

                Case _selectADataModeEnum.NomeDoArquivoAtual


                    Dim _value As String = ""


                    Dim _nomeOuExtensaoDoArquivoAtual As Integer = _criterion.RenameTypeData.DadosDeNomeDeArquivoAtual.NomeOuExtensaoDoArquivoAtual
                    Dim _opcoesDeFormatacaoDeTexto As Integer = _criterion.RenameTypeData.DadosDeNomeDeArquivoAtual.OpcoesDeFormatacaoDeTexto
                    Dim dadosDeNomeDeArquivoAtual As Class_DataRenamingCriterion.DadosDeNomeDeArquivoStructure
                    dadosDeNomeDeArquivoAtual = _criterion.RenameTypeData.DadosDeNomeDeArquivoAtual

                    _value = UsesFile.ReturnFileNameOrFolderAndOrExtension(obj, _nomeOuExtensaoDoArquivoAtual)

                    _value = OpcoesDeFormatacaoDeTextoParaComboPerson(_opcoesDeFormatacaoDeTexto, _value, dadosDeNomeDeArquivoAtual)

                    _strData = _value

                Case _selectADataModeEnum.NovaExtensao

                    _isExtension = True

                    _strData = UsesFile.ReturnExt(_criterion.RenameTypeData.Extension)

                Case _selectADataModeEnum.SubstituicaoDeString

                    Dim _find As String = _criterion.RenameTypeData.DadosDeSubstituicao.Find
                    'TXTPFind.TXT
                    Dim _replacement As String = _criterion.RenameTypeData.DadosDeSubstituicao.Replacement
                    'TXTPReplacement.TXT

                    Dim _ignoreUpperLower As Boolean = _criterion.RenameTypeData.DadosDeSubstituicao.IgnoreUpperLowerOfReplacementData
                    Dim _replaceAll As Boolean = _criterion.RenameTypeData.DadosDeSubstituicao.ReplaceAllReplacementData

                    _strData = FormatAlphabetLetter.StringFunctions.ReplacePhrase(obj.Name, _find, _replacement, _ignoreUpperLower, _replaceAll)


            End Select


            If _isExtension = False Then
                nomeDoArquivo += _strData

            Else
                extDoArquivo += _strData

            End If
        Next

        ' TODO: Pode transformar em uma Função
        ' ---------------------------------------------------------
        If Trim(nomeDoArquivo) = "" Then
            If obj.Extension <> "" Then
                nomeDoArquivo = obj.Name.Replace(obj.Extension, "")

            Else
                ' If _strData <> "" Then
                nomeDoArquivo = obj.Name

                ' End If

            End If
        End If

        If Trim(extDoArquivo) = "" Or Trim(extDoArquivo) = "." Then
            extDoArquivo = obj.Extension

        End If

        newName = nomeDoArquivo + extDoArquivo
        '--------------------------------------------------------
        If TypeOf obj Is DirectoryInfo Then

            newFullName = obj.Parent.FullName & "\" & newName

        ElseIf TypeOf obj Is FileInfo Then
            newFullName = obj.DirectoryName & "\" & newName

        End If


        ' TODO: Inserir tratamento de tamanho de nome de de arquivo de diretório.

        'System.IO.PathTooLongException
        'O caminho especificado, o nome do arquivo ou ambos são muito longos.
        'O nome de arquivo totalmente qualificado deve ter menos de 260 
        ' caracteres e o nome do diretório menos de 248 caracteres.'

        If objIsDirectory <> objIsFile Then
            If objIsDirectory = True Then
                newObj = New DirectoryInfo(newFullName)

            End If

            If objIsFile = True Then
                newObj = New FileInfo(newFullName)

            End If

        Else
            MsgBox("objeto invalido")
        End If


        Return newObj

    End Function


    Function OpcoesDeFormatacaoDeTextoParaComboPerson(_opcoesDeFormatacaoDeTexto As OpcoesDeFormatacaoDeTextoEnum, _value As String, dadosDeNomeDeArquivo As Class_DataRenamingCriterion.DadosDeNomeDeArquivoStructure)

        '  Dim criterio As Class_DataRenamingCriterion.DadosDeNomeDeArquivoStructure
        Dim _dataStr As String = _value

        Dim removeSpace As Boolean = dadosDeNomeDeArquivo.RemoverEspacoDeNomeDeArquivo
        Dim firstLetterUpper As Boolean = dadosDeNomeDeArquivo.PrimeiraLetraMinusculaDeNomeDeArquivo

        Select Case _opcoesDeFormatacaoDeTexto

            Case OpcoesDeFormatacaoDeTextoEnum.ComoOOriginal
                _dataStr = _value.ToString()

            Case OpcoesDeFormatacaoDeTextoEnum.TODASMAIUSCULAS
                _dataStr = _value.ToString.ToUpper()

            Case OpcoesDeFormatacaoDeTextoEnum.todasMinusculas
                _dataStr = _value.ToString.ToLower()

            Case OpcoesDeFormatacaoDeTextoEnum.PrimeirasLetrasMaiusculas

                Dim new_value As String = FormatAlphabetLetter.StringFunctions.ConvertTheFirstLettersToUppercase(_value, Not (firstLetterUpper))

                If removeSpace = True Then
                    new_value = FormatAlphabetLetter.StringFunctions.ReplacePhrase(new_value, " ", "")
                End If
                _dataStr = new_value

            Case OpcoesDeFormatacaoDeTextoEnum.pRIMEIRASlETRASmINUSCULAS

                Dim new_value As String = FormatAlphabetLetter.StringFunctions.ConvertTheFirstLettersToLowercase(_value)

                _dataStr = new_value

        End Select

        Return _dataStr

    End Function

    Public OpcoesDeFormatacaoDeTexto As OpcoesDeFormatacaoDeTextoEnum
    Public Enum OpcoesDeFormatacaoDeTextoEnum

        ComoOOriginal = 0
        TODASMAIUSCULAS = 1
        todasMinusculas = 2
        PrimeirasLetrasMaiusculas = 3
        pRIMEIRASlETRASmINUSCULAS = 4
        primeiraLetraMinúnsculaDemaisPrimeriasMaiúsculas = 5

    End Enum
End Class




Module Example
    Public Sub Main()
        ' Get an array of n random integers.
        Dim values() As Integer = GetArray(50, 0, 1000)
        Dim lBound As Integer = 300
        Dim uBound As Integer = 600
        Dim matchedItems() As Integer = Array.FindAll(values,
                                            Function(x) x >= lBound And x <= uBound)
        For ctr As Integer = 0 To matchedItems.Length - 1
            Console.Write("{0}  ", matchedItems(ctr))
            If (ctr + 1) Mod 12 = 0 Then Console.WriteLine()
        Next
    End Sub

    Private Function GetArray(n As Integer, lower As Integer,
                             upper As Integer) As Integer()
        Dim rnd As New Random()
        Dim list As New List(Of Integer)
        For ctr As Integer = 1 To n
            list.Add(rnd.Next(lower, upper + 1))
        Next
        Return list.ToArray()
    End Function
End Module
