﻿Public Class StringFunctionsClass
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

    Overloads Function RemoveChar(phrase As String, charStr As String)

        Dim newPhrase As String = phrase
        Dim charList() As Char = charStr.ToCharArray()

        For Each _char As Char In charList
            newPhrase = ReplacePhrase(newPhrase, _char.ToString, "")
        Next

        Return newPhrase

    End Function

    Overloads Function RemoveChar(phrase As String, _chars() As Char)

        Dim newPhrase As String = phrase

        For Each _char As Char In _chars
            newPhrase = ReplacePhrase(newPhrase, _char.ToString, "")
        Next

        Return newPhrase

    End Function

    Function ReplacePhrase(phrase As String, buscar As String, substituir As String)
        Dim newPhrase As String
        newPhrase = phrase.Replace(buscar, substituir)

        Return newPhrase
    End Function

    Function NumberCharExist(dataStr As String)

        Dim _charStr As String

        Dim _numberCharExist As Boolean

        For i As Integer = 0 To dataStr.Length - 1

            _charStr = dataStr.Chars(i).ToString()

            _numberCharExist = IsNumeric(_charStr) = True
        Next

        Return _numberCharExist

    End Function

    Function TodosOsCaracteresSaoTexto(dataStr As String) As Boolean

        Dim _charStr As String
        Dim _charUpper As String
        Dim _charLower As String

        Dim _isCharText As Boolean = False

        For i As Integer = 0 To dataStr.Length - 1

            _charStr = dataStr.Chars(i).ToString()
            _charUpper = _charStr.ToUpper.ToString()
            _charLower = _charStr.ToLower.ToString()

            If _charUpper <> _charLower Then

                _isCharText = True

            Else
                _isCharText = False
                Exit For

            End If
        Next

        Return _isCharText

    End Function

    Function SubstituirNumeroPorLetra(dataStr As String) As String

        Dim valStr As String = ""
        Dim _char As String
        Dim varChar As Integer

        For i = 0 To dataStr.Length - 1
            _char = dataStr.Chars(i).ToString

            If IsNumeric(_char) = True Then

                varChar = CInt(_char) + 65
                If varChar > 91 Then varChar = 65

                _char = ChrW(varChar)
            Else
                If IsWord(CChar(_char)) = False Then
                    _char = ""
                End If

            End If

                valStr += _char

        Next

        Return valStr

    End Function

    Function IsWord(_char As Char) As Boolean

        Dim charUpper As String
        Dim charLower As String

        Dim _isWord As Boolean

        charUpper = _char.ToString.ToUpper
        charLower = _char.ToString.ToLower

        _isWord = Not (charUpper = charLower)

        Return _isWord
    End Function

    Function RetornaStringComNumeroCaracter(numberValue As Integer, qDeCaracteres As Integer) As String

        Dim _return As String
        Dim cadeia As String = "0"
        Dim qDeRepeticao As Integer

        qDeRepeticao = qDeCaracteres - numberValue.ToString.Length

        If qDeRepeticao < 0 Then qDeRepeticao = 0

        _return = StrDup(qDeRepeticao, cadeia) + numberValue.ToString
        Return _return

    End Function

End Class
