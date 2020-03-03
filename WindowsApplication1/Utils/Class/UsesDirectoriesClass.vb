Imports System.IO

Imports TrevoWebMedia.StructuresModules


Public Enum Actions As Byte
    None = 0
    Copy = 1
    Delete = 2
    MoveToTrash = 3
    Move = 4
    Rename = 5
    Merge = 6
    Open = 7
End Enum

Public Class UsesDirectoriesClass

    'Public Structure CaminhosDeRenomeDePastas
    '    Public oldPathOrigem As String
    '    Public newPathOrigem As String
    '    Public oldPathDestino As String
    '    Public newPathDestino As String

    '    Public oldPath As String
    '    Public newPath As String
    'End Structure

    'Public _foldersPathsOperations As CaminhosDeRenomeDePastas

    Function RenameFolder(path As String, newName As String) As Object


        ' Renomeia a pasta apresentando o seu caminho completo e um novo nome.

        Dim _foldersPathsOperations As FoldersPathsOperations

        Dim path_DirectoryInfo As New DirectoryInfo(path)

        _foldersPathsOperations.sourcePath = Trim(path)
        _foldersPathsOperations.destinationPath = path_DirectoryInfo.Parent.FullName & "\" & Trim(newName)

        _foldersPathsOperations.sourceOldPath = _foldersPathsOperations.sourcePath
        _foldersPathsOperations.sourceNewPath = _foldersPathsOperations.sourcePath

        _foldersPathsOperations.destinationOldPath = _foldersPathsOperations.destinationPath
        _foldersPathsOperations.destinationNewPath = _foldersPathsOperations.destinationPath

        Try

            If path_DirectoryInfo.Exists = True Then

                Dim sourcePath_DirectoryInfo As New DirectoryInfo(_foldersPathsOperations.sourcePath)
                Dim destinationPath_DirectoryInfo As New DirectoryInfo(_foldersPathsOperations.destinationPath)


                If destinationPath_DirectoryInfo.Exists = True Then
                    ' TODO: Renomear Pastas Antes de Mover
                    ' TODO: Estudar esta função: Fazer Algoritimo.
                    Dim title As String = "Conflito entre pastas"
                    Dim resultadoDeCarregarFormDeConflitoDePasta As New ArrayList()

                    _foldersPathsOperations.sourceOldPath = _foldersPathsOperations.sourcePath
                    _foldersPathsOperations.sourceNewPath = _foldersPathsOperations.destinationPath

                    _foldersPathsOperations.destinationOldPath = _foldersPathsOperations.destinationPath
                    _foldersPathsOperations.destinationNewPath = _foldersPathsOperations.destinationPath

                    resultadoDeCarregarFormDeConflitoDePasta = CarregarFormDeConflitoDePasta(_foldersPathsOperations, newName, title)
                    _foldersPathsOperations = resultadoDeCarregarFormDeConflitoDePasta(0)




                    Select Case resultadoDeCarregarFormDeConflitoDePasta(1)
                        Case DialogResult.OK
                            MoveFolder(_foldersPathsOperations.sourceOldPath, _foldersPathsOperations.sourceNewPath, False)
                            MoveFolder(_foldersPathsOperations.destinationOldPath, _foldersPathsOperations.destinationNewPath, False)

                            'If FRM.NewPathDestino <> FRM.OldPathDestino Then
                            '    If FRM.NewPathDestino = FRM.NewPathOrigem Then
                            '        ' RenomearEMesclarPasta(_origem, _destino, _novoNomeDaPasta)

                            '    End If
                            'End If

                    End Select

                    Return _foldersPathsOperations 'newPath
                Else
                    Rename(_foldersPathsOperations.sourcePath, _foldersPathsOperations.destinationPath)
                    Return _foldersPathsOperations 'newPath
                End If
            End If

        Catch ex As Exception

            MsgBox("Erro na função" & Chr(13) & "RenameFolder" & Chr(13) & """" & ex.Message & """")
            Return _foldersPathsOperations 'oldPath
        End Try

    End Function

    Function CarregarFormDeConflitoDePasta(_foldersPathsOperations As Object, newName As String, title As String) As ArrayList

        Dim FRM As New FRMDialogConflictingFolders
        Dim resultado As New ArrayList()


        FRM.Title = title
        FRM.SourcePath = _foldersPathsOperations.sourcePath
        FRM.DestinationPath = _foldersPathsOperations.destinationPath

        FRM.SourceOldPath = _foldersPathsOperations.sourceOldPath                       '_foldersPathsOperations.sourcePath
        FRM.SourceNewPath = _foldersPathsOperations.sourceNewPath   '_foldersPathsOperations.destinationPath
        FRM.DestinationOldPath = _foldersPathsOperations.destinationOldPath '.destinationPath
        FRM.DestinationNewPath = _foldersPathsOperations.destinationNewPath '.destinationPath

        FRM.LBLFolderName.Text = """" & newName & """"
        FRM.ShowDialog()

        _foldersPathsOperations.destinationOldPath = FRM.DestinationOldPath
        _foldersPathsOperations.destinationNewPath = FRM.DestinationNewPath

        _foldersPathsOperations.sourceOldPath = FRM.SourceOldPath
        _foldersPathsOperations.sourceNewPath = FRM.SourceNewPath

        resultado.Add(_foldersPathsOperations)
        resultado.Add(FRM.DialogResult)

        Return resultado
    End Function

    Function MoveFolder(_sourceDirectoryName As String, _destinationDirectoryName As String, overwrite As Boolean)

        Dim ListaDeArquivos As New ArrayList()

        Dim newFileName As String
        Dim usesFiles As New UsesFilesClass

        Try

            ListaDeArquivos.AddRange(AddFolderInList(_sourceDirectoryName))
            'My.Computer.FileSystem.MoveDirectory(_sourceDirectoryName, _destinationDirectoryName, overwrite)

            If My.Computer.FileSystem.DirectoryExists(_destinationDirectoryName) = False Then MkDir(_destinationDirectoryName)

            ' TODO: Continuar Editando a função
            Dim caminhoDeOrigemDoArquivo As String
            Dim subCaminhoDeDestinoDoArquivo As String

            For Each file As FileInfo In ListaDeArquivos

                If _sourceDirectoryName <> file.DirectoryName Then
                    subCaminhoDeDestinoDoArquivo = _destinationDirectoryName & "\" & DevolveNomeDaPasta(file.DirectoryName)
                    ' TODO: Se a pasta já existe, faz o que?

                Else
                    subCaminhoDeDestinoDoArquivo = _destinationDirectoryName '& "\" & file.DirectoryName

                End If

                If overwrite = False Then
                    newFileName = usesFiles.ReturnsNonExistentFileName(file.FullName, subCaminhoDeDestinoDoArquivo & "\" & file.Name)
                Else
                    'TODO: Tratar este destino. Ele deve mudar de acordo com as subPastas.
                    newFileName = subCaminhoDeDestinoDoArquivo & "\" & file.Name
                End If

                My.Computer.FileSystem.MoveFile(file.FullName.ToString,
                         newFileName,
                        FileIO.UIOption.AllDialogs,
                        FileIO.UICancelOption.ThrowException)

            Next

            If _sourceDirectoryName <> _destinationDirectoryName Then
                'TODO: deletar _sourceDirectoryName
            End If

        Catch ex As Exception
            Dim info As String

            'For Each dado As String In ex.Data.Values
            '    MsgBox(dado)
            'Next

            For Each strKey In ex.Data.Keys
                info = (ex.Data(strKey))

                Dim sourceFileInfo As FileInfo
                sourceFileInfo = My.Computer.FileSystem.GetFileInfo(strKey)

                If sourceFileInfo.Exists = True Then

                    If overwrite = False Then
                        newFileName = usesFiles.ReturnsNonExistentFileName(sourceFileInfo.FullName, _destinationDirectoryName & "\" & sourceFileInfo.Name)
                    Else
                        newFileName = _destinationDirectoryName & "\" & sourceFileInfo.Name
                    End If

                    My.Computer.FileSystem.MoveFile(sourceFileInfo.FullName.ToString,
                         newFileName,
                        FileIO.UIOption.AllDialogs,
                        FileIO.UICancelOption.ThrowException)

                    Dim dir As DirectoryInfo
                    dir = New DirectoryInfo(_sourceDirectoryName)

                    If dir.Exists = True Then
                        If _sourceDirectoryName <> _destinationDirectoryName Then
                            'TODO: deletar _sourceDirectoryName
                        End If
                    End If

                    ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-parse-file-paths
                End If

            Next

        End Try

        ' https://docs.microsoft.com/pt-br/dotnet/api/system.collections.idictionary?view=netframework-4.8
        'https://docs.microsoft.com/pt-br/dotnet/api/microsoft.visualbasic.fileio.filesystem.copydirectory?view=netframework-4.8

    End Function

    Function AddFolderInList(path As String) As ArrayList
        Dim ListaDeArquivos As New ArrayList()
        Dim directoryInfo As New DirectoryInfo(path)

        ListaDeArquivos.AddRange(directoryInfo.GetFiles)

        For Each subDir As DirectoryInfo In directoryInfo.GetDirectories()
            ListaDeArquivos.AddRange(AddFolderInList(subDir.FullName))
        Next

        Return ListaDeArquivos
    End Function

    Function CreateNewFolder(path As String, folderName As String) As Boolean

        Dim exception As String

        If path = Nothing Then
            Return False
            Exit Function
        End If

        folderName = Trim(folderName)

        Dim _path As New DirectoryInfo(path & "\")
        Dim _destination As New DirectoryInfo(path & "\" & folderName)

        Try
            If _path.Exists = False Then
                exception = "O caminho não existe."
                MsgBox(exception)
                Return False

            ElseIf _destination.Exists = True Then
                If _path.FullName <> _destination.FullName Then
                    exception = "A pasta já existe."
                    MsgBox(exception)
                End If
                Return False

            Else
                If folderName <> "" Then
                    MkDir(path & "\" & folderName)
                    Return True

                Else
                    Return False

                End If
            End If

        Catch ex As Exception
            MsgBox("Erro na função" & Chr(13) & "CreateNewFolder" & Chr(13) & """" & ex.Message & """")

            Return False
        End Try

    End Function

    Public Function ReturnNonExistentFolderName(path As String, folderNameForSearch As String)
        Dim directoryArrayList As New ArrayList
        Dim drive As New DirectoryInfo(path)
        Dim destinationDrive As New DirectoryInfo(path & "\" & folderNameForSearch)
        Dim search As String

        If drive.Exists = True Then
            If destinationDrive.Exists = True Then
                directoryArrayList.AddRange(drive.GetDirectories())

                For x As Integer = 0 To directoryArrayList.Count
                    search = folderNameForSearch & " (" & x + 2 & ")"

                    Dim query = From folder As DirectoryInfo In directoryArrayList
                                Where folder.Name.IndexOf(search) = 0
                                Select folder

                    If query.Count = 0 Then
                        Return search
                        Exit For
                    End If
                Next

            Else

                Return folderNameForSearch
            End If

        Else

            'TODO: Atualizar Pasta
            ' A Pasta Destino não existe
            Return folderNameForSearch

        End If

        ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/concepts/linq/how-to-query-an-arraylist-with-linq
        ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/strings/how-to-search-within-a-string
    End Function

    Public Function DevolveNomeDaPasta(path As String) As String

        Dim dir As New DirectoryInfo(path)
        Return dir.Name
    End Function

    Public Function GetPathFolder(path As String) As String

        Dim dir As New DirectoryInfo(path)
        Return dir.Parent.FullName
    End Function

End Class
