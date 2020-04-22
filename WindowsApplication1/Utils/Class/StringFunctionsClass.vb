Public Class StringFunctionsClass
    Function SepararPalavras(ByVal quebrarPalavras As String, ByVal delimitadores() As Char) As String()

        Dim palavras() As String
        palavras = quebrarPalavras.Split(delimitadores)
        Return palavras

    End Function


    Function ConverteStringEmColectionString(ByVal quebraPalavras As String, ByVal delimitatores() As Char) As Collections.Specialized.StringCollection
        Dim list As New Collections.Specialized.StringCollection

        list.AddRange(quebraPalavras.Split(delimitatores))

        Return list
    End Function

End Class
