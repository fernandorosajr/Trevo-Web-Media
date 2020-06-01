Imports System.IO
' Trata os as listas de arquivos e pastas e os renomeiam segundo criterios.
Public Class Class_RenameActions
    '  Dim c As New Class_DataRenameOption
    ReadOnly _selectADataModeEnum As New Class_DataRenameOption.SelectADataModeEnum

    ' Importação de classes 
    '-------------------------------------------------
    Dim dateFunctions As New Class_Date
    '-------------------------------------------------

    Public Overloads Function Rename_SELECTED_LIST_AccordingToCriterion(SelectedFoldersAndFiles As List(Of Object), dataRenameCriteriaList As List(Of Class_DataRenameOption))
        Dim index As Integer = 0
        Dim Renamed_SelectedFoldersAndFiles As New List(Of Object)

        '' TODO:  Listar todas as pastas em ListFolder da lista SelectedFoldersAndFiles
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
    End Function


    Public Overloads Function RenameAccordingToCriterion(file As FileInfo, criteria As List(Of Class_DataRenameOption), index As Integer)
        Dim _newName As String = ""
        Dim _newFile As FileInfo

        Dim _strData As String = ""

        Dim _name As String
        Dim _ext As String
        Dim _isExtension As Boolean = False


        For Each _criterion In criteria


            Select Case _criterion.RenameTypeData.Tela

                Case _selectADataModeEnum.Texto


                    _strData = _criterion.RenameTypeData.Text

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

                Case _selectADataModeEnum.Metadados

                Case _selectADataModeEnum.NomeDaPasta

                Case _selectADataModeEnum.NomeDoArquivoAtual

                Case _selectADataModeEnum.NovaExtensao
                    _isExtension = True

                Case _selectADataModeEnum.SequenciaNumerica

                Case _selectADataModeEnum.SubstituicaoDeString



            End Select

            If _isExtension = False Then
                _name = _name + _strData

            Else
                _ext = _ext + _strData

            End If
        Next

        Return _newFile
    End Function

    Public Overloads Function RenameAccordingToCriterion(obj As DirectoryInfo, criterion As List(Of Class_DataRenameOption), index As Integer)
        Dim _newName As String = ""


        Return _newName
    End Function

    Public Overloads Function RenameAccordingToCriterion(obj As Object, criterion As List(Of Class_DataRenameOption), index As Integer)
        Dim _newName As String = ""


        Return _newName
    End Function
End Class
