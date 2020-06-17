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

    Public Overloads Function TratarEDevolverCaracteresDoAlfabeto(index As Long) As String
        Dim str As String
        Dim value As String = ""

        Dim qChar As Double

        Dim qCharParaMenos As Long
        Dim qCharParaMais As Long

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

                value += TratarEDevolverCaracteresDoAlfabeto(CLng(qCharParaMenos))

                value += Chr(resto + 65)

                str = value

                Return str

            End If

            value += Chr(resto + 65)

        End If

        str = value

        Return str


    End Function

    Public Overloads Function TratarEDevolverCaracteresDoAlfabeto(_dataStr As String, index As Long) As String
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer

        Dim position As Long

        Dim retonar As String = ""

        Dim charList As List(Of Char)

        Dim LASC As Integer

        Dim newChar As String

        Dim NewCharString As New List(Of String)

        Dim Letra As String

        Dim qChar As Double


        Dim numberChar As Byte

        Dim sequenciaDeCasas As New List(Of Long)

        _dataStr = _dataStr.ToUpper
        charList = StringFunctions.ConverterParaListChar(_dataStr)

        qChar = charList.Count
        y = charList.Count - 1
        z = charList.Count - 1

        If qChar = 1 Then

            Letra = charList(z).ToString
            LASC = Asc(Letra) + index
            position = (LASC - 65)

            If position >= 0 Then

                newChar = TratarEDevolverCaracteresDoAlfabeto(position)
                retonar = newChar

                Return retonar
            End If

        Else

            sequenciaDeCasas.Clear()

            For x = 0 To qChar - 1
                Letra = charList(z).ToString
                LASC = Asc(Letra)
                numberChar = LASC - 64

                If x = 0 Then
                    sequenciaDeCasas.Add(numberChar)

                Else
                    sequenciaDeCasas.Add(numberChar * (26 ^ x))

                End If

                z = y - (x + 1)
            Next

            For x = 0 To sequenciaDeCasas.Count - 1
                position += sequenciaDeCasas(x)
            Next

            position -= 1

            newChar = TratarEDevolverCaracteresDoAlfabeto(position + index)

            retonar = newChar

        End If


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

            Case 0
                _dataStr = _dataStr.ToUpper

            Case 1
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
