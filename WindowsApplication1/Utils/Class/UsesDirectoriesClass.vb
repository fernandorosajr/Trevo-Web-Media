Imports System.IO

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

                Dim newPath_DirectoryInfo As New DirectoryInfo(newPath)

                If newPath_DirectoryInfo.Exists = True Then
                    ' TODO: Carregar form de Conflito de pasta

                Else
                    Rename(oldPath, newPath)
                    Return newPath
                End If
            End If

        Catch ex As Exception
            Return oldPath
        End Try

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
