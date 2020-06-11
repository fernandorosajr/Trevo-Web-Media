Public Class Class_FormatAlphabetLetter
    'Importação de Classes
    '--------------------------------------------------
    Public ReadOnly StringFunctions As New StringFunctionsClass
    Public DataRenameOption As New Class_DataRenamingCriterion
    Private numberClass As New Class_Number
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
                If StringFunctions.IsWord(_char) Then numbers.Add(_char)
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

    Public Overloads Function TratarEDevolverCaracteresDoAlfabeto(index As Double) As String
        Dim str As String
        Dim value As String = ""

        Dim qChar As Double

        Dim qCharParaMenos As Integer
        Dim qCharParaMais As Integer

        ' Dim voltaChar As New List(Of Double)

        Dim resto As Integer

        resto = index Mod 26
        qChar = index / 26

        If index >= 0 And index <= 25 Then
            value = Chr(index + 65)

        ElseIf index > 25 Then

            qCharParaMenos = numberClass.ArredondarParaMenos(qChar)
            qCharParaMais = qCharParaMenos + 1
            ' TODO: Testar aqui como 26
            If qCharParaMenos <= 26 Then

                If qCharParaMenos <> 0 Then
                    value += Chr((qCharParaMenos - 1) + 65)

                Else
                    value += Chr(qCharParaMenos + 65)

                End If

            Else
                Dim resto2 As Integer

                resto2 = qCharParaMenos Mod 26

                'If resto2 = 0 Then
                '    value += TratarEDevolverCaracteresDoAlfabeto(CDbl(qCharParaMenos - 1))

                'End If

                value += TratarEDevolverCaracteresDoAlfabeto(CDbl(qCharParaMenos))

                value += Chr(resto + 65)

                str = value

                Return str

            End If

            value += Chr(resto + 65)

        End If

        str = value

        Return str


        'If index >= 1 And index < 25 Then
        '    value = Chr(index + 65)

        'ElseIf index > 25 Then
        '    qChar = index / 25

        '    'MsgBox(index Mod 25)
        '    'MsgBox(qChar)


        '    qCharInt = qChar

        '    ' Arredondar qChar para o menor valor
        '    ' ---------------------------------------
        '    qCharStr = qChar.ToString

        '    position = InStr(qCharStr, ",", CompareMethod.Binary) - 1

        '    If position < 0 Then position = 0

        '    If position = 0 Then
        '        qCharParaMenos = CInt(qCharStr)
        '    Else

        '        qCharParaMenos = CInt(qCharStr.Substring(0, position))
        '    End If
        '    ' ---------------------------------------
        '    ' MsgBox()

        '    ' Arredondar qChar para o Maior valor
        '    qCharParaMais = qCharParaMenos + 1

        '    ' Definir numero de voltas

        '    nDeVoltas = 1


        '    For x = 0 To qCharParaMenos
        '        If x = qCharParaMenos Then
        '            If CDbl(qCharParaMais) > qChar Then
        '                voltaChar.Add(qChar - CDbl(qCharParaMenos))
        '            End If

        '        Else
        '            voltaChar.Add(qCharParaMenos)

        '        End If
        '    Next

        '    For x = 0 To voltaChar.Count - 1
        '        value = value + TratarEDevolverCaracteresDoAlfabeto(voltaChar(x))
        '    Next

        'ElseIf index < 1 Then
        '    Dim i As Integer
        '    i = index * 25
        '    value = TratarEDevolverCaracteresDoAlfabeto(i)

        'End If

        'str = value

        'Return str




        ''If index >= 0 And index < 25 Then
        ''    value = Chr(index + 65)

        ''Else

        ''    If index > 25 Then
        ''        qChar = index / 25

        ''        qCharInt = qChar

        ''        ' Arredondar qChar para o menor valor
        ''        ' ---------------------------------------
        ''        qCharStr = qChar.ToString

        ''        position = InStr(qCharStr, ",", CompareMethod.Binary) - 1

        ''        If position < 0 Then position = 0

        ''        If position = 0 Then
        ''            qCharParaMenos = CInt(qCharStr)
        ''        Else

        ''            qCharParaMenos = CInt(qCharStr.Substring(0, position))
        ''        End If
        ''        ' ---------------------------------------


        ''        ' Arredondar qChar para o Maior valor
        ''        qCharParaMais = qCharParaMenos + 1


        ''        For x = 0 To qCharParaMenos
        ''            If x = qCharParaMenos Then
        ''                If CDbl(qCharParaMais) > qChar Then
        ''                    voltaChar.Add(qChar - CDbl(qCharParaMenos))
        ''                End If

        ''            Else
        ''                voltaChar.Add(0)

        ''            End If
        ''        Next

        ''    End If

        ''    For x = 0 To voltaChar.Count - 1
        ''        value = value + TratarEDevolverCaracteresDoAlfabeto(voltaChar(x))
        ''    Next
        ''End If

        ''If index < 1 Then
        ''    Dim i As Integer
        ''    i = index * 25
        ''    value = TratarEDevolverCaracteresDoAlfabeto(i)
        ''End If

        ''str = value

        ''Return str

        '''Dim x As Integer

        '''If _index > 90 Then
        '''    x = _index - 90
        '''    str += ChrW(65).ToString()

        '''    str += TratarEDevolverCaracteresDoAlfabeto(x)

        '''Else

        '''    x = _index + 65

        '''    If x > 90 Then
        '''        str += TratarEDevolverCaracteresDoAlfabeto(x)


        '''    Else
        '''        str += ChrW(x).ToString()

        '''    End If

        '''    'If _index >= 65 Then
        '''    '    str += ChrW(_index).ToString()

        '''    'Else
        '''    '    str += ChrW(65).ToString()

        '''    'End If

        '''End If


    End Function


    'Public Overloads Function TratarEDevolverCaracteresDoAlfabeto(_dataStr As String, index As Integer) As String
    '    Dim x As Integer
    '    Dim str As String = ""
    '    Dim listChar As List(Of Char)
    '    Dim lastCharAss As Integer

    '    Dim _index As Integer

    '    listChar = StringFunctions.ConverterParaListChar(_dataStr)

    '    lastCharAss = Asc(listChar(listChar.Count - 1).ToString())

    '    _index = index + lastCharAss

    '    If _index > 90 Then
    '        x = _index - 90
    '        str += ChrW(90).ToString()

    '        str += TratarEDevolverCaracteresDoAlfabeto(x)

    '    Else

    '        If _index >= 65 Then
    '            str += ChrW(_index).ToString()

    '        Else
    '            str += ChrW(65).ToString()

    '        End If

    '    End If

    '    Return str

    'End Function






    Public Overloads Function FormatarLetraDoAlfabeto(_criterion As Class_DataRenamingCriterion, index As Integer) As String
        Dim _dataStr As String = Trim(_criterion.RenameTypeData.DadosDeSequenciaDeLetras.SequenciaDeLetra)            'letra)

        'Dim _index As Integer = 65 + index


        If Trim(_dataStr) = "" Then

            _dataStr = TratarEDevolverCaracteresDoAlfabeto(index)

        Else
            _dataStr = StringFunctions.ReplacePhrase(_dataStr, " ", "")

            If StringFunctions.TodosOsCaracteresSaoTexto(_dataStr) = False Then
                ' MsgBox(funcoesDeString.IsWord("a"c))
                _dataStr = SubstituirNumeroPorLetra(_dataStr)
            End If

            _dataStr = TratarEDevolverCaracteresDoAlfabeto(_dataStr)
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
            _dataStr = StringFunctions.ReplacePhrase(_dataStr, " ", "")
        End If

        If StringFunctions.TodosOsCaracteresSaoTexto(_dataStr) = False Then
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
