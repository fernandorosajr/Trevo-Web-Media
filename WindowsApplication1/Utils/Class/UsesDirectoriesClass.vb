﻿Imports System.IO

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

    Function RenomearPasta(caminho As String, newName As String) As String

        Dim oldPath, newPath As String
        Dim caminho_DirectoryInfo As New DirectoryInfo(caminho)

        oldPath = Trim(caminho)
        newPath = caminho_DirectoryInfo.Parent.FullName & "\" & Trim(newName)

        Try

            If caminho_DirectoryInfo.Exists = True Then

                Dim oldPath_DirectoryInfo As New DirectoryInfo(oldPath)
                Dim newPath_DirectoryInfo As New DirectoryInfo(newPath)

                Dim oldPathDestino As String
                Dim newPathDestino As String

                Dim oldPathOrigem As String
                Dim newPathOrigem As String

                If newPath_DirectoryInfo.Exists = True Then
                    ' TODO: Carregar form de Conflito de pasta
                    ' TODO: Estudar esta função: Fazer Algoritimo.
                    oldPathDestino = newPath
                    newPathDestino = newPath

                    oldPathOrigem = oldPath
                    newPathOrigem = newPath

                    Dim FRM As New FRMDialogConflictingFolders

                    FRM.Title = "Conflito entre pastas"
                    FRM.PastaOrigem = oldPath
                    FRM.PastaDestino = newPath

                    FRM.OldPathOrigem = oldPath
                    FRM.NewPathOrigem = newPath
                    FRM.OldPathDestino = newPath
                    FRM.NewPathDestino = newPath

                    FRM.LBLNomeDaPasta.Text = """" & newName & """"
                    FRM.ShowDialog()

                    oldPathDestino = FRM.OldPathDestino
                    newPathDestino = FRM.NewPathDestino

                    oldPathOrigem = FRM.OldPathOrigem
                    newPathOrigem = FRM.NewPathOrigem

                    Select Case FRM.DialogResult
                        Case DialogResult.OK
                            MoverPasta(oldPathOrigem, newPathOrigem)
                            MoverPasta(oldPathDestino, newPathDestino)

                            'If FRM.NewPathDestino <> FRM.OldPathDestino Then
                            '    If FRM.NewPathDestino = FRM.NewPathOrigem Then
                            '        ' RenomearEMesclarPasta(_origem, _destino, _novoNomeDaPasta)

                            '    End If
                            'End If

                    End Select

                    Return oldPath
                Else
                    Rename(oldPath, newPath)
                    Return newPath
                End If
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return oldPath
        End Try

    End Function
    Function MoverPasta(_sourceDirectoryName As String, _destinationDirectoryName As String)
        My.Computer.FileSystem.CopyDirectory(_sourceDirectoryName, _destinationDirectoryName, False)
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
End Class
