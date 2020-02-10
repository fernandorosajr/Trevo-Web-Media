Public Class UsesFilesClass
    Public Function DevolverNomeDoArquivo(caminho As String, nomeDoArquivo As String)
        Dim fileArrayList As New ArrayList
        Dim drive As New DirectoryInfo(caminho)
        Dim driveDestino As New DirectoryInfo(caminho & "\" & nomeDoArquivo)
        Dim pesquisa As String

        If drive.Exists = True Then
            If driveDestino.Exists = True Then
                fileArrayList.AddRange(drive.GetDirectories())

                For x As Integer = 0 To fileArrayList.Count
                    pesquisa = nomeDoArquivo & " (" & x + 2 & ")"

                    Dim query = From pasta As DirectoryInfo In fileArrayList
                                Where pasta.Name.IndexOf(pesquisa) = 0
                                Select pasta

                    If query.Count = 0 Then
                        Return pesquisa
                        Exit For
                    End If
                Next

            Else

                Return nomeDoArquivo
            End If

        Else

            'TODO: Atualizar Pasta
            ' A Pasta Destino não existe
        End If

        ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/concepts/linq/how-to-query-an-arraylist-with-linq
        ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/strings/how-to-search-within-a-string
    End Function
End Class
