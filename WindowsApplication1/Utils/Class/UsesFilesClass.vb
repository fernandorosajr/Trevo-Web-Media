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
            ' My.Computer.FileSystem.FileExists()

            fileArrayList.AddRange(dir.GetFiles())

            For x As Integer = 0 To fileArrayList.Count
                Dim _fileNameWithoutExtension As String

                _fileNameWithoutExtension = FileOrFolderNameWithoutExtension(DestinationFileName)

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

    Function FileOrFolderNameWithoutExtension(fileInfo As Object) As String

        'Dim folder As DirectoryInfo

        'folder.Extension.Count
        'fileInfo.Extension.Count

        Dim _fileNameWithoutExtension As String
        _fileNameWithoutExtension = fileInfo.Name.Substring(0, fileInfo.Name.ToString.Length - (fileInfo.Extension.ToString.Length))

        Return _fileNameWithoutExtension
    End Function

    Public Overloads Function ReturnExt(extension As String)
        Dim ext As String = extension

        Dim strData As String

        If ext IsNot Nothing Then
            If ext.Length > 0 Then
                If ext.First <> "." Then
                    strData = "." & ext
                Else
                    strData = ext
                End If

            Else
                strData = "."
            End If

        Else
            strData = "."
        End If

        Return strData
    End Function


    Public Overloads Function ReturnExt(file As FileInfo)
        Dim extension As String = file.Extension

        Dim _strData As String

        If extension IsNot Nothing Then
            If extension.Length > 0 Then
                If extension.First <> "." Then
                    _strData = "." & extension
                Else
                    _strData = extension
                End If

            Else
                _strData = "."
            End If

        Else
            _strData = "."
        End If

        Return _strData
    End Function

    Public Overloads Function ReturnExt(file As Object)
        Dim extension As String = file.Extension

        Dim _strData As String

        If extension IsNot Nothing Then
            If extension.Length > 0 Then
                If extension.First <> "." Then
                    _strData = "." & extension
                Else
                    _strData = extension
                End If

            Else
                _strData = "."
            End If

        Else
            _strData = "."
        End If

        Return _strData
    End Function

    Public Overloads Function ReturnFileNameOrFolderAndOrExtension(file As FileInfo, _i As Integer)

        Dim _value As String = "Null" '  file.Name

        Select Case _i

            Case 0
                _value = file.Name

            Case 1
                _value = FileOrFolderNameWithoutExtension(file)

            Case 2

                If file.Extension.Length > 0 Then
                    _value = file.Extension.Substring(1)
                Else
                    _value = file.Extension
                End If

        End Select

        Return _value

    End Function

    Public Overloads Function ReturnFileNameOrFolderAndOrExtension(obj As Object, _i As Integer)

        Dim _value As String = "Null" '  file.Name

        Select Case _i

            Case 0
                _value = obj.Name

            Case 1
                _value = FileOrFolderNameWithoutExtension(obj)

            Case 2

                If obj.Extension.Length > 0 Then
                    _value = obj.Extension.Substring(1)
                Else
                    _value = obj.Extension
                End If

        End Select

        Return _value

    End Function
End Class
