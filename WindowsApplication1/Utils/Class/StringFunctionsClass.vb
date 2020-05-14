Public Class StringFunctionsClass
    Function SepararPalavras(ByVal quebrarPalavras As String, ByVal delimitadores() As Char) As String()

        Dim palavras() As String
        palavras = quebrarPalavras.Split(delimitadores)
        Return palavras

    End Function

    Function ConverterParaListChar(ByVal Quebra As String, ByVal delimitadores() As Char) As List(Of Char)
        Dim palavras() As String
        Dim caracteres As List(Of Char) = New List(Of Char)

        palavras = SepararPalavras(Quebra, delimitadores)
        '  caracteres =
        For Each x As Char In palavras
            caracteres.Add(x)
        Next
        Return caracteres
    End Function

    Function ConverteStringEmColectionString(ByVal quebraPalavras As String, ByVal delimitatores() As Char) As Collections.Specialized.StringCollection
        Dim list As New Collections.Specialized.StringCollection

        list.AddRange(quebraPalavras.Split(delimitatores))

        Return list
    End Function

    Function ConvertTheFirstWordToUppercase(textToConvert As String, firstLetterUpper As Boolean)
        Dim newPhrase As String = ""
        Dim charStr As String
        Dim convertToUpper As Boolean
        Dim fileName As String = textToConvert

        convertToUpper = firstLetterUpper

        For x = 0 To textToConvert.Length - 1

            charStr = fileName.Substring(x, 1)

            If convertToUpper = True Then
                charStr = StrConv(charStr, vbUpperCase)
                'convertToUpper = False

            Else
                charStr = StrConv(charStr, vbLowerCase)
            End If

            newPhrase += charStr

            If fileName.Chars(x) = " " Then
                convertToUpper = True

            Else
                convertToUpper = False

            End If
        Next

        Return newPhrase
    End Function

    Function ConvertTheFirstLettersToLowercase(tEXTtOcONVERT As String)
        Dim newPhrase As String = ""
        Dim charStr As String
        Dim convertToLower As Boolean
        Dim fileName As String = tEXTtOcONVERT

        convertToLower = True

        For x = 0 To tEXTtOcONVERT.Length - 1

            charStr = fileName.Substring(x, 1)

            If convertToLower = True Then
                charStr = StrConv(charStr, vbLowerCase)
                'convertToUpper = False

            Else
                charStr = StrConv(charStr, vbUpperCase)
            End If

            newPhrase += charStr

            If fileName.Chars(x) = " " Then
                convertToLower = True

            Else
                convertToLower = False

            End If
        Next

        Return newPhrase
    End Function

    Function ReplacePhrase(phrase As String, buscar As String, substituir As String)
        Dim newPhrase As String
        newPhrase = phrase.Replace(buscar, substituir)

        Return newPhrase
    End Function
End Class
