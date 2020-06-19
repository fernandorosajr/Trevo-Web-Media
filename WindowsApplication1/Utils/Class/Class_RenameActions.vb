Imports System.IO
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

    Public Overloads Function Rename_SELECTED_LIST_AccordingToCriterion(SelectedFoldersAndFiles As List(Of Object), dataRenameCriteriaList As List(Of Class_DataRenamingCriterion)) As List(Of Object)
        Dim index As Integer = 0 '402882 '92486 '17601 '17575 '18251

        ' caso aquele valoer seja 25 usar 
        'index  = 17575

        Dim Renamed_SelectedFoldersAndFiles As New List(Of Object)

        '' TODO:  Listar todas as pastas da lista SelectedFoldersAndFiles em ListFolder
        'Dim listFolders As New List(Of DirectoryInfo)

        'For Each obj As Object In SelectedFoldersAndFiles
        '    If TypeOf obj Is DirectoryInfo Then
        '        listFolders.Add(obj)
        '    End If
        'Next

        '' TODO: pecorrer ListFolder e dentro deste pecorrer SelectedFoldersAndFiles e ...
        '' ... renomear  as pastas dos arquivos e as pastas de SelectedFoldersAndFiles.
        'Dim folderParent As DirectoryInfo

        'Dim file As FileInfo
        'Dim folder As DirectoryInfo
        'Dim _newfileStr As String

        'Dim indexfolder As Integer

        'For Each subFolder In listFolders

        '    For Each obj In SelectedFoldersAndFiles

        '        If TypeOf obj Is FileInfo Then

        '            file = obj
        '            folderParent = New DirectoryInfo(file.DirectoryName)

        '            If folderParent.FullName = subFolder.FullName Then

        '                ' Function Renomear sub pasta do arquivo
        '                ' -------------------------------------
        '                folderParent = RenameAccordingToCriterion(folderParent, dataRenameCriteriaList, indexfolder)

        '                _newfileStr = folderParent.FullName.ToString & "\" & file.Name.ToString

        '                file = New FileInfo(_newfileStr)

        '                ' -------------------------------------
        '            End If

        '        ElseIf TypeOf obj Is DirectoryInfo Then

        '            folder = obj
        '            ' https://docs.microsoft.com/pt-br/dotnet/api/system.array.findindex?view=netcore-3.1
        '            listFolders.FindIndex(folder)
        '            folder = RenameAccordingToCriterion(folder, dataRenameCriteriaList, indexfolder)

        '            obj = folder

        '        End If

        '    Next

        '    indexfolder += 1

        'Next


        ' TODO: Pecorrer SelectedFoldersAndFiles e Renomear somente os arquivos

        For Each obj As Object In SelectedFoldersAndFiles
            Renamed_SelectedFoldersAndFiles.Add(RenameAccordingToCriterion(obj, dataRenameCriteriaList, index))

            index += 1
        Next

        Return Renamed_SelectedFoldersAndFiles
    End Function


    Public Overloads Function RenameAccordingToCriterion(file As FileInfo, criteria As List(Of Class_DataRenamingCriterion), index As Integer)
        Dim _newName As String = ""
        Dim _newFile As FileInfo

        Dim _strData As String = ""

        Dim nomeDoArquivo As String
        Dim extDoArquivo As String
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
                nomeDoArquivo = nomeDoArquivo + _strData

            Else
                extDoArquivo = extDoArquivo + _strData

            End If
        Next



        _newName = file.DirectoryName & "\" & nomeDoArquivo & extDoArquivo

        _newFile = New FileInfo(_newName)

        Return _newFile

    End Function

    'Public Overloads Function RenameAccordingToCriterion(folder As DirectoryInfo, criterion As List(Of Class_DataRenameOption), index As Integer)
    '    Dim _newName As String = ""


    '    Return _newName
    'End Function

    Public Overloads Function RenameAccordingToCriterion(obj As Object, criteria As List(Of Class_DataRenamingCriterion), index As Integer)
        Dim newName As String = ""
        Dim newFullName As String = ""

        Dim aFile As FileInfo
        Dim aFolder As DirectoryInfo

        Dim newObj As Object = obj

        Dim objIsFile As Boolean
        Dim objIsDirectory As Boolean

        Dim _strData As String = ""

        Dim nomeDoArquivo As String
        Dim extDoArquivo As String
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
                nomeDoArquivo = nomeDoArquivo + _strData

            Else
                extDoArquivo = extDoArquivo + _strData

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


        ' TODO: Aqui tem que retornar newObject e deve ser igual a pasta ou a arquivo 
        ' de acordo com o objeto

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
