Imports System.IO

Public Class UsesFilesClass

    Dim StringFunctions As New StringFunctionsClass

    Public Function ReturnsNonExistentFileName(_sourceFileName As String, _destinationFileName As String) As String
        ' TODO: Reavaliar o nome desta função
        ' Se necessario separar em duas.

        Dim fileArrayList As New ArrayList
        Dim SourceFileName As New FileInfo(_sourceFileName)
        Dim DestinationFileName As New FileInfo(_destinationFileName)

        Dim dir As DirectoryInfo
        dir = DestinationFileName.Directory

        Dim pesquisa As String


        If DestinationFileName.Exists = True Then
            fileArrayList.AddRange(dir.GetFiles())

            For x As Integer = 0 To fileArrayList.Count
                Dim _fileNameWithoutExtension As String

                _fileNameWithoutExtension = FileNameWithoutExtension(DestinationFileName)

                pesquisa = _fileNameWithoutExtension & " (" & x + 2 & ")"

                Dim query = From file As FileInfo In fileArrayList
                            Where file.Name.IndexOf(pesquisa) = 0
                            Select file

                If query.Count = 0 Then
                    Return DestinationFileName.DirectoryName & "\" & pesquisa & DestinationFileName.Extension
                    Exit For
                End If

            Next

        Else

            Return _destinationFileName
        End If

        ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/concepts/linq/how-to-query-an-arraylist-with-linq
        ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/strings/how-to-search-within-a-string
    End Function

    Function FileNameWithoutExtension(fileInfo As FileInfo) As String

        Dim _fileNameWithoutExtension As String
        _fileNameWithoutExtension = fileInfo.Name.Substring(0, fileInfo.Name.Count - (fileInfo.Extension.Count))

        Return _fileNameWithoutExtension
    End Function
End Class
