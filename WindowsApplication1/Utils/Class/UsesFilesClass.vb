Imports System.IO

Public Class UsesFilesClass

    Dim StringFunctions As New StringFunctionsClass

    Public Function DevolverNomeDoArquivo(_nomeDoArquivoDeOrigem As String, _nomeDoArquivoDestino As String, Substituir As Boolean) As String
        Dim fileArrayList As New ArrayList
        Dim NomeDoArquivoDeOrigem As New FileInfo(_nomeDoArquivoDeOrigem)
        Dim NomeDoArquivoDestino As New FileInfo(_nomeDoArquivoDestino)

        Dim dir As DirectoryInfo
        dir = NomeDoArquivoDestino.Directory

        Dim pesquisa As String

        If Substituir = False Then
            If NomeDoArquivoDestino.Exists = True Then
                fileArrayList.AddRange(dir.GetFiles())

                For x As Integer = 0 To fileArrayList.Count
                    Dim _nomeDoArquivoSemExtensao As String

                    _nomeDoArquivoSemExtensao = NomeDoArquivoSemExtensao(NomeDoArquivoDestino)

                    pesquisa = _nomeDoArquivoSemExtensao & " (" & x + 2 & ")"


                    Dim query = From file As FileInfo In fileArrayList
                                Where file.Name.IndexOf(pesquisa) = 0
                                Select file

                    If query.Count = 0 Then
                        Return NomeDoArquivoDestino.DirectoryName & "\" & pesquisa & NomeDoArquivoDestino.Extension
                        Exit For
                    End If

                Next

            Else

                Return _nomeDoArquivoDestino
            End If
        End If

        ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/concepts/linq/how-to-query-an-arraylist-with-linq
        ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/strings/how-to-search-within-a-string
    End Function

    Function NomeDoArquivoSemExtensao(nome As FileInfo) As String

        Dim _nomeDoArquivoSemExtensao As String
        _nomeDoArquivoSemExtensao = nome.Name.Substring(0, nome.Name.Count - (nome.Extension.Count))

        Return _nomeDoArquivoSemExtensao
    End Function
End Class
