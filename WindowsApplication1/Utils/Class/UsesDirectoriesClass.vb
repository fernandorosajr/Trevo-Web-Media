Imports System.IO


Public Class UsesDirectoriesClass

    Function RenomearPasta(caminho As String, newName As String) As String

        Dim oldPath, newPath As String
        Dim directoryInfo As New DirectoryInfo(caminho)

        oldPath = Trim(caminho)
        newPath = directoryInfo.Parent.FullName & "\" & Trim(newName)

        Try

            If directoryInfo.Exists = True Then
                Rename(oldPath, newPath)
                Return newPath
            End If

        Catch ex As Exception
            Return oldPath
        End Try

    End Function

    Function CriarNovaPasta(caminho As String, nomeDaPasta As String) As Boolean

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
