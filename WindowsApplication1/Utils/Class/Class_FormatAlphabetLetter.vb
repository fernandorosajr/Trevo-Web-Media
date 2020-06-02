Public Class Class_FormatAlphabetLetter
    'Importação de Classes
    '--------------------------------------------------
    ReadOnly funcoesDeString As New StringFunctionsClass
    Public DataRenameOption As New Class_DataRenameOption
    '--------------------------------------------------

    Public Overloads Function SubstituirNumeroPorLetra(dataStr As String) As String

        Dim valStr As String = ""
        Dim _char As String
        Dim varChar As Integer

        Dim n As String

        Dim numbers As New List(Of String)
        Dim charsStr As New List(Of String)

        Dim canAddNumber As Boolean

        '  If IsNumeric(dataStr) Then

        '  Else

        ' Funcao RemoverCaracteresNaoNumericos
        For i = 0 To dataStr.Length - 1
            _char = dataStr.Chars(i).ToString

            If IsNumeric(_char) = True Then

                n = n + _char
                canAddNumber = True

            Else

                If canAddNumber = True Then numbers.Add(n)
                If funcoesDeString.IsWord(_char) Then numbers.Add(_char)
                canAddNumber = False
                n = ""

            End If

        Next

        If canAddNumber = True Then numbers.Add(n)

        For Each number In numbers

            If IsNumeric(number) Then

                charsStr.Add(TratarEDevolverCaracteresDoAlfabeto(CInt(number) + 65))

            Else
                charsStr.Add(number)


            End If

        Next

        '  valStr = numbers.ToString()

        For Each str01 In charsStr
            valStr = valStr + str01
        Next
        '  MsgBox()
        ' End If


        'For i = 0 To dataStr.Length - 1
        '    _char = dataStr.Chars(i).ToString

        '    If IsNumeric(_char) = True Then

        '        varChar = CInt(_char) + 65

        '        If varChar > 91 Then varChar = 65

        '        _char = ChrW(varChar)
        '    Else
        '        If IsWord(CChar(_char)) = False Then
        '            _char = ""
        '        End If

        '    End If

        '    valStr += _char

        'Next

        Return valStr

    End Function

    Function TratarEDevolverCaracteresDoAlfabeto(_index As Integer) As String
        Dim x As Integer
        Dim str As String = ""

        If _index > 90 Then
            x = _index - 90
            str += ChrW(90).ToString()

            str += TratarEDevolverCaracteresDoAlfabeto(x)

        Else

            If _index >= 65 Then
                str += ChrW(_index).ToString()

            Else
                str += ChrW(65).ToString()

            End If

        End If

        Return str

    End Function

    Public Overloads Function FormatarLetraDoAlfabeto(_criterion As Class_DataRenameOption, index As Integer) As String
        Dim _dataStr As String = Trim(_criterion.RenameTypeData.DadosDeSequenciaDeLetras.SequenciaDeLetra)            'letra)

        Dim _index As Integer = 65 + index


        If Trim(_dataStr) = "" Then

            _dataStr = TratarEDevolverCaracteresDoAlfabeto(_index)

        Else
            _dataStr = funcoesDeString.ReplacePhrase(_dataStr, " ", "")

            If funcoesDeString.TodosOsCaracteresSaoTexto(_dataStr) = False Then
                ' MsgBox(funcoesDeString.IsWord("a"c))
                _dataStr = SubstituirNumeroPorLetra(_dataStr)
            End If


        End If

        Select Case _criterion.RenameTypeData.DadosDeSequenciaDeLetras.OpcoesDeFormatacaoDeSequenciaDeLetras     'ComBPSlave.SelectedItem.Tag.ID

            Case 9
                _dataStr = _dataStr.ToUpper

            Case 10
                _dataStr = _dataStr.ToLower

        End Select

        Return _dataStr

    End Function

    Public Overloads Function FormatarLetraDoAlfabeto(letra As String, upper As Integer) As String
        Dim _dataStr As String = Trim(letra)

        If Trim(_dataStr) = "" Then
            _dataStr = ChrW(65).ToString

        Else
            _dataStr = funcoesDeString.ReplacePhrase(_dataStr, " ", "")
        End If

        If funcoesDeString.TodosOsCaracteresSaoTexto(_dataStr) = False Then
            ' MsgBox(funcoesDeString.IsWord("a"c))
            _dataStr = SubstituirNumeroPorLetra(_dataStr)
        End If

        Select Case upper ' _criterion.RenameTypeData.DadosDeSequenciaDeLetras.OpcoesDeFormatacaoDeSequenciaDeLetras     'ComBPSlave.SelectedItem.Tag.ID

            Case 9
                _dataStr = _dataStr.ToUpper

            Case 10
                _dataStr = _dataStr.ToLower

        End Select

        Return _dataStr

    End Function
End Class
