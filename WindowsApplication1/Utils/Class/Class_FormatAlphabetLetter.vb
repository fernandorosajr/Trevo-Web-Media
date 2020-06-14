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

            qCharParaMenos = numberClass.ArredondarParaMenos(qChar) - 1
            qCharParaMais = qCharParaMenos + 1

            If qCharParaMenos <= 25 Then

                value += Chr(qCharParaMenos + 65)

            Else

                value += TratarEDevolverCaracteresDoAlfabeto(CDbl(qCharParaMenos))

                value += Chr(resto + 65)

                str = value

                Return str

            End If

            value += Chr(resto + 65)

        End If

        str = value

        Return str


    End Function


    Public Overloads Function TratarEDevolverCaracteresDoAlfabeto(_dataStr As String, index As Integer) As String
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer

        Dim a As Integer

        Dim position As Integer

        Dim retonar As String = ""
        Dim listChar As List(Of Char)
        '  Dim listChar_Reverse() As Char

        Dim LASC As Integer
        Dim NewLASC As Integer
        Dim newChar As String
        Dim NewCharString As New List(Of String)

        Dim Letra As String

        Dim _index As Integer


        listChar = StringFunctions.ConverterParaListChar(_dataStr)

        Dim sobeUm As Boolean

        y = listChar.Count - 1
        z = listChar.Count - 1

        For x = 0 To listChar.Count - 1

            Letra = listChar(z).ToString
            LASC = Asc(Letra) + index

            position = LASC - 65

            If position > 25 Then
                sobeUm = True
                newChar = TratarEDevolverCaracteresDoAlfabeto(position - 26)
                NewCharString.Add(newChar)

            ElseIf position < 25 Then
                If sobeUm = True Then
                    newChar = TratarEDevolverCaracteresDoAlfabeto(position + 1)

                Else
                    newChar = TratarEDevolverCaracteresDoAlfabeto(position)

                End If

                sobeUm = False
                NewCharString.Add(newChar)

            ElseIf position = 25 Then
                If sobeUm = True Then
                    newChar = TratarEDevolverCaracteresDoAlfabeto(position - 25)

                Else
                    newChar = TratarEDevolverCaracteresDoAlfabeto(position)
                    sobeUm = True

                End If
                NewCharString.Add(newChar)

            End If

            z = y - x

        Next




        y = NewCharString.Count - 1
        z = NewCharString.Count - 1


        For x = 0 To NewCharString.Count - 1

            retonar += NewCharString(z)
            z = y - x

        Next



        '    If LASC > 90 Then

        '        a = LASC - 26

        '        newChar = (Chr(a))

        '        sobeUm = True
        '        NewCharString.Add(newChar)

        '    Else

        '        If sobeUm = True Then
        '            LASC += 1
        '            sobeUm = False
        '        End If
        '        newChar = TratarEDevolverCaracteresDoAlfabeto(LASC - 65)
        '        NewCharString.Add(newChar)

        '    End If

        '    z = y - x

        'Next

        'If sobeUm = True Then
        '    newChar = (Chr(65))
        '    NewCharString.Add(newChar)
        'End If


        'y = NewCharString.Count - 1
        'z = NewCharString.Count - 1


        'For x = 0 To NewCharString.Count - 1

        '    retonar += NewCharString(z)
        '    z = y - x

        'Next


        ''Letra = _dataStr.Chars(_dataStr.Length - 1) 'listChar(listChar.Count - 1)

        ''LASC = Asc(Letra)

        ''If LASC + index <= 90 Then
        ''    NewLASC = LASC + index
        ''    newChar = Chr((NewLASC))

        ''Else
        ''    x = ((LASC + index)) - 26

        ''    newChar = Chr(65) + TratarEDevolverCaracteresDoAlfabeto(x)
        ''End If

        ''For y = 0 To _dataStr.Length - 1
        ''    If y = _dataStr.Length - 1 Then
        ''        NewCharString.Add(newChar)

        ''    Else
        ''        NewCharString.Add(_dataStr.Chars(y))

        ''    End If
        ''Next

        ''For Each str As String In NewCharString

        ''    retonar = retonar + str
        ''Next



        '''listChar = StringFunctions.ConverterParaListChar(_dataStr)

        '''Letra = listChar(listChar.Count - 1)



        '''If LASC + index <= 90 Then
        '''    NewLASC = LASC + index
        '''    newChar = Chr(NewLASC)

        '''Else
        '''    ' x = (lastCharASC + index) - 65
        '''    x = (LASC + index)

        '''    newChar = TratarEDevolverCaracteresDoAlfabeto(x)

        '''End If

        '''For y = 0 To _dataStr.Length - 1

        '''    If y = _dataStr.Length - 1 Then
        '''        NewCharString.Add(newChar)

        '''    Else
        '''        NewCharString.Add(_dataStr.Chars(y))

        '''    End If

        '''Next

        '''If LASC + index <= 90 Then

        '''End If
        ''''listChar = StringFunctions.ConverterParaListChar(_dataStr)

        ''''lastCharAss = Asc(listChar(listChar.Count - 1).ToString())

        ''''_index = index + lastCharAss

        ''''If _index > 90 Then
        ''''    x = _index - 90
        ''''    str += ChrW(65).ToString()

        ''''    str += TratarEDevolverCaracteresDoAlfabeto(x)

        ''''Else

        ''''    If _index >= 65 Then
        ''''        str += ChrW(_index).ToString()

        ''''    Else
        ''''        str += ChrW(65).ToString()

        ''''    End If

        ''''End If

        Return retonar

    End Function






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

            _dataStr = TratarEDevolverCaracteresDoAlfabeto(_dataStr, index)
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
