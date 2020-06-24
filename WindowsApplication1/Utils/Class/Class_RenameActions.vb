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
    '-------------------------------------------------

    Public Overloads Function Rename_SELECTED_LIST_AccordingToCriterion(SelectedFoldersAndFiles As List(Of Object), dataRenameCriteriaList As List(Of Class_DataRenamingCriterion), fuxoContinuoDeRenome As Boolean) As List(Of Object)

        ' TODO: (2) Receber valor de index esxternamente.
        ' TODO (3) Estabelecer interação com a variavel fuxoContinuoDeRenome.

        ' Renomeia e devolve a lista de objetos renomedos baseado em critérios

        Dim index As Long = 0
        Dim index2 As Long
        Dim Renamed_SelectedFoldersAndFiles As New List(Of Object)
        Dim _selectedFoldersAndFiles As New List(Of String)

        Dim listFolders As New ArrayList

        ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/arrays/

        Dim dir As DirectoryInfo

        Dim indexfolder As Long

        indexfolder = 0

        Dim file As FileInfo
        Dim folder As DirectoryInfo

        ' Listar todas as pastas da lista SelectedFoldersAndFiles em ListFolder
        '--------------------------------------------------------------------------------------

        _selectedFoldersAndFiles.Clear()

        For Each obj As Object In SelectedFoldersAndFiles

            If TypeOf obj Is FileInfo Then

                file = obj
                _selectedFoldersAndFiles.Add(file.FullName)

            ElseIf TypeOf obj Is DirectoryInfo Then

                folder = obj
                _selectedFoldersAndFiles.Add(folder.FullName)

                If fuxoContinuoDeRenome = False Then

                    ' Criar Lista de pasta renomeada e seus nomes originais
                    ' --------------------------------------------------------------------------
                    listFolders.AddRange(CriarListaDePastasRenomedasEOriginais(obj, dataRenameCriteriaList, indexfolder))

                    indexfolder += 1

                    ' --------------------------------------------------------------------------
                End If

            End If

        Next

        indexfolder = 0

            'End If

            Dim i As Long
        ' Renomeia pastas e pastas pai de um arquivo em uma lista de seleção
        ' ---------------------------------------------------------------------------

        _selectedFoldersAndFiles = RenomearPastasEPastasPaiEmUmaListaDeSelecao(listFolders, SelectedFoldersAndFiles, _selectedFoldersAndFiles, i)


            ' https://docs.microsoft.com/pt-br/dotnet/api/system.array.findindex?view=netcore-3.1
            ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/procedures/lambda-expressions
            ' https://docs.microsoft.com/pt-br/dotnet/api/system.array.exists?view=netcore-3.1#System_Array_Exists__1___0___System_Predicate___0__




            ' Pecorrer SelectedFoldersAndFiles e Renomeia somente os arquivos

            indexfolder = 0

        For Each obj As Object In _selectedFoldersAndFiles
            Dim id As Long
            Dim _obj As Object = obj
            If fuxoContinuoDeRenome = False Then
                If TypeOf SelectedFoldersAndFiles(index) Is DirectoryInfo Then



                    id = Array.FindIndex(listFolders.ToArray, Function(_array)
                                                                  Dim value As Boolean = False
                                                                  dir = New DirectoryInfo(obj)

                                                                  If dir.FullName = _array(1).FullName Then
                                                                      value = True
                                                                  End If

                                                                  Return value

                                                              End Function)

                    If id > -1 Then

                        Dim pastaRenomeda As DirectoryInfo = (listFolders.Item(id)(1))

                        _obj = pastaRenomeda '(listFolders.Item(id)(1))

                        Renamed_SelectedFoldersAndFiles.Add(_obj)

                        index2 = 0
                    Else

                        _obj = New DirectoryInfo(obj)
                        ' se achar pasta adiciona no listFolder o nome original e o nome renomedo
                        Renamed_SelectedFoldersAndFiles.Add(RenameAccordingToCriterion(_obj, dataRenameCriteriaList, index2))

                    End If

                ElseIf TypeOf SelectedFoldersAndFiles(index) Is FileInfo Then
                    _obj = New FileInfo(obj)

                    Renamed_SelectedFoldersAndFiles.Add(RenameAccordingToCriterion(_obj, dataRenameCriteriaList, index2))
                    index2 += 1 'indexFile
                End If

                index += 1

            ElseIf fuxoContinuoDeRenome = True Then


                '_obj = obj
                dir = New DirectoryInfo(obj)

                If TypeOf SelectedFoldersAndFiles(index) Is DirectoryInfo Then


                    listFolders.AddRange(CriarListaDePastasRenomedasEOriginais(_obj, dataRenameCriteriaList, index))
                    Renamed_SelectedFoldersAndFiles.Add(listFolders(listFolders.Count - 1)(1))                '(RenameAccordingToCriterion(_obj, dataRenameCriteriaList, index))


                ElseIf TypeOf SelectedFoldersAndFiles(index) Is FileInfo Then

                    file = New FileInfo(_selectedFoldersAndFiles(index))
                    file = RenomearPastasEPastasPaiEmUmaListaDeSelecao2(file, listFolders)
                    Dim arqAchado As Object = file ' New FileInfo(_obj)

                    Renamed_SelectedFoldersAndFiles.Add(RenameAccordingToCriterion(arqAchado, dataRenameCriteriaList, index))

                    ' Função RenomarPastaOuPastaPai

                    'Dim folderParent As DirectoryInfo


                    'Renamed_SelectedFoldersAndFiles.Add(file)
                    ' Renomear
                    'If subFolder(0).FullName = folderParent.FullName Then
                    '    folderParent = subFolder(1)

                    '    file = New FileInfo(folderParent.FullName & "\" & file.Name)

                    'End If

                End If


                index += 1


            End If



        Next



        ' Renomeia as pastas pai nos arquivos

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
        Dim folder As DirectoryInfo
        Dim folderParent As DirectoryInfo

        Dim ultimoIndexChecado As Long
        Dim indexfolder As Long

        For Each subFolder In listFolders

            Do While index > -1

                If TypeOf SelectedFoldersAndFiles(index) Is FileInfo Then

                    file = New FileInfo(_selectedFoldersAndFiles(index))
                    folderParent = New DirectoryInfo(file.DirectoryName)


                    If subFolder(0).FullName = folderParent.FullName Then
                        folderParent = subFolder(1)

                        file = New FileInfo(folderParent.FullName & "\" & file.Name)

                    End If

                    _selectedFoldersAndFiles(index) = file.FullName


                ElseIf TypeOf SelectedFoldersAndFiles(index) Is DirectoryInfo Then

                    folder = New DirectoryInfo(_selectedFoldersAndFiles(index))


                    If subFolder(0).FullName = folder.FullName Then

                        ' TODO: (3) Aqui acessa a matriz de pastas renomeadas ao inves de renomea-la...
                        ' todas as vezes que passar por aqui.

                        folder = subFolder(1)

                    End If
                    _selectedFoldersAndFiles(index) = folder.FullName

                End If

                If index <> -1 Then index += 1

                index = Array.FindIndex(SelectedFoldersAndFiles.ToArray, index, Function(path)

                                                                                    Dim valor As Boolean = False

                                                                                    If TypeOf path Is FileInfo Then

                                                                                        If path.DirectoryName = subFolder(0).FullName Then
                                                                                            valor = True
                                                                                            'Else
                                                                                            '    valor = False
                                                                                        End If


                                                                                    ElseIf TypeOf path Is DirectoryInfo Then

                                                                                        If path.FullName = subFolder(0).FullName Then
                                                                                            valor = True
                                                                                            'Else
                                                                                            '    valor = False
                                                                                        End If

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
