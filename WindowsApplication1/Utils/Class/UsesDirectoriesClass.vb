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

    Function RenomearPasta(caminho As String, newName As String) As Object

        Dim _foldersPathsOperations As CaminhosDeRenomeDePastas
        '  Dim oldPath, newPath As String
        Dim caminho_DirectoryInfo As New DirectoryInfo(caminho)

        _foldersPathsOperations.oldPath = Trim(caminho)
        _foldersPathsOperations.newPath = caminho_DirectoryInfo.Parent.FullName & "\" & Trim(newName)

        Try

            If caminho_DirectoryInfo.Exists = True Then

                Dim oldPath_DirectoryInfo As New DirectoryInfo(_foldersPathsOperations.oldPath)
                Dim newPath_DirectoryInfo As New DirectoryInfo(_foldersPathsOperations.newPath)

                'Dim oldPathDestino As String
                'Dim newPathDestino As String

                'Dim oldPathOrigem As String
                'Dim newPathOrigem As String

                If newPath_DirectoryInfo.Exists = True Then
                    ' TODO: Renomear Pastas Antes de Mover
                    ' TODO: Estudar esta função: Fazer Algoritimo.
                    _foldersPathsOperations.oldPathDestino = _foldersPathsOperations.newPath
                    _foldersPathsOperations.newPathDestino = _foldersPathsOperations.newPath

                    _foldersPathsOperations.oldPathOrigem = _foldersPathsOperations.oldPath
                    _foldersPathsOperations.newPathOrigem = _foldersPathsOperations.newPath

                    Dim FRM As New FRMDialogConflictingFolders

                    FRM.Title = "Conflito entre pastas"
                    FRM.PastaOrigem = _foldersPathsOperations.oldPath
                    FRM.PastaDestino = _foldersPathsOperations.newPath

                    FRM.OldPathOrigem = _foldersPathsOperations.oldPath
                    FRM.NewPathOrigem = _foldersPathsOperations.newPath
                    FRM.OldPathDestino = _foldersPathsOperations.newPath
                    FRM.NewPathDestino = _foldersPathsOperations.newPath

                    FRM.LBLNomeDaPasta.Text = """" & newName & """"
                    FRM.ShowDialog()

                    _foldersPathsOperations.oldPathDestino = FRM.OldPathDestino
                    _foldersPathsOperations.newPathDestino = FRM.NewPathDestino

                    _foldersPathsOperations.oldPathOrigem = FRM.OldPathOrigem
                    _foldersPathsOperations.newPathOrigem = FRM.NewPathOrigem

                    Select Case FRM.DialogResult
                        Case DialogResult.OK
                            MoverPasta(_foldersPathsOperations.oldPathOrigem, _foldersPathsOperations.newPathOrigem)
                            MoverPasta(_foldersPathsOperations.oldPathDestino, _foldersPathsOperations.newPathDestino)

                            'If FRM.NewPathDestino <> FRM.OldPathDestino Then
                            '    If FRM.NewPathDestino = FRM.NewPathOrigem Then
                            '        ' RenomearEMesclarPasta(_origem, _destino, _novoNomeDaPasta)

                            '    End If
                            'End If

                    End Select

                    Return _foldersPathsOperations 'newPath
                Else
                    Rename(_foldersPathsOperations.oldPath, _foldersPathsOperations.newPath)
                    Return _foldersPathsOperations 'newPath
                End If
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return _foldersPathsOperations 'oldPath
        End Try

    End Function
    Function MoverPasta(_sourceDirectoryName As String, _destinationDirectoryName As String)

        Try
            My.Computer.FileSystem.CopyDirectory(_sourceDirectoryName, _destinationDirectoryName, False)

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

                Dim fileInfo As FileInfo
                fileInfo = My.Computer.FileSystem.GetFileInfo(strKey)

                If fileInfo.Exists = True Then

                    Dim novoNomeDoArquivo As String
                    Dim manipularArquivo As New UsesFilesClass

                    novoNomeDoArquivo = manipularArquivo.DevolverNomeDoArquivo(fileInfo.FullName, _destinationDirectoryName & "\" & fileInfo.Name, False)

                    My.Computer.FileSystem.MoveFile(fileInfo.FullName.ToString,
                         novoNomeDoArquivo,
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

    Function CompararNomeDasPastasEExecutarAcao(action As String)

    End Function

    Function PodeCriarNovaPasta(caminho As String, nomeDaPasta As String) As Boolean

        Dim excecao As String

        If caminho = Nothing Then
            Return False
            Exit Function
        End If

        nomeDaPasta = LTrim(nomeDaPasta)
        nomeDaPasta = RTrim(nomeDaPasta)

        Dim _caminho As New DirectoryInfo(caminho & "\")
        Dim _destino As New DirectoryInfo(caminho & "\" & nomeDaPasta)

        Try
            If _caminho.Exists = False Then
                excecao = "O caminho não existe."
                MsgBox(excecao)
                Return False

            ElseIf _destino.Exists = True Then
                If _caminho.FullName <> _destino.FullName Then
                    excecao = "A pasta já existe."
                    MsgBox(excecao)
                End If
                Return False

            Else
                If nomeDaPasta <> "" Then
                    MkDir(caminho & "\" & nomeDaPasta)
                    Return True

                Else
                    Return False

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Function DevolverNomeDaPasta(caminho As String, nomeParaPesquisa As String)
        Dim directoryArrayList As New ArrayList
        Dim drive As New DirectoryInfo(caminho)
        Dim driveDestino As New DirectoryInfo(caminho & "\" & nomeParaPesquisa)
        Dim pesquisa As String

        If drive.Exists = True Then
            If driveDestino.Exists = True Then
                directoryArrayList.AddRange(drive.GetDirectories())

                For x As Integer = 0 To directoryArrayList.Count
                    pesquisa = nomeParaPesquisa & " (" & x + 2 & ")"

                    Dim query = From pasta As DirectoryInfo In directoryArrayList
                                Where pasta.Name.IndexOf(pesquisa) = 0
                                Select pasta

                    If query.Count = 0 Then
                        Return pesquisa
                        Exit For
                    End If
                Next

            Else

                Return nomeParaPesquisa
            End If

        Else

            'TODO: Atualizar Pasta
            ' A Pasta Destino não existe
        End If

        ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/concepts/linq/how-to-query-an-arraylist-with-linq
        ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/strings/how-to-search-within-a-string
    End Function

    Function FolderExist(path As String) As Boolean
        Dim _caminho As New DirectoryInfo(path)
        Return _caminho.Exists
    End Function
End Class
