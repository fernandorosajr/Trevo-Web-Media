Public Class Class_Date

    ' Importação de classes 
    '-------------------------------------------------
    Dim funcoesDeString As New StringFunctionsClass
    '-------------------------------------------------

    'Public Overloads Function TrasnformDate(_date As Date)

    '    Dim _id As Integer = 0 ' ComBPRight.SelectedItem.Tag.ID

    '    Dim _strDate As String = _date.ToLongDateString

    '    Dim ano As String = _date.Year.ToString

    '    Dim mes As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Month, 2) '_date.Month.ToString
    '    Dim mesEscrito As String = MonthList(_date.Month - 1)    ' + " " + funcoesDeString.RetornaStringComNumeroCaracter(_date.Month, 2) '_date.Month.ToString
    '    Dim dia As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Day, 2) '_date.Day.ToString

    '    Dim semana As String = String.Format("{0:dddd}", _date)   ' _date.DayOfWeek.ToString

    '    Dim hora As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Hour, 2)

    '    Dim minuto As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Minute, 2)   '_date.Minute.ToString
    '    Dim segundo As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Second, 2) '_date.Second.ToString

    '    ' MsgBox(String.Format("{0:dddd}", _date))
    '    'MsgBox(Format(_strDate, "dddd"))

    '    Select Case _id

    '        Case DateFormatEnum.AA
    '            _strDate = ano.Substring(2, 2)

    '        Case DateFormatEnum.AAAA
    '            _strDate = _date.Year

    '        Case DateFormatEnum.AAAAMMDD
    '            _strDate = ano + mes + dia
    '        Case DateFormatEnum.AAMMDD
    '            _strDate = ano.Substring(2, 2) + mes + dia

    '        Case DateFormatEnum.DD
    '            _strDate = dia

    '        Case DateFormatEnum.DDMMAA
    '            _strDate = dia + mes + ano.Substring(2, 2)

    '        Case DateFormatEnum.DDMMAAAA
    '            _strDate = dia + mes + ano

    '        Case DateFormatEnum.DiaDaSemana
    '            _strDate = FormatDateText(semana)

    '            _strDate = SubstituirEspaco(_strDate)

    '        Case DateFormatEnum.HH
    '            _strDate = hora

    '        Case DateFormatEnum.HHMM
    '            _strDate = hora + minuto

    '        Case DateFormatEnum.HHMMSS
    '            _strDate = hora + minuto + segundo

    '        Case DateFormatEnum.Mes_Escrito
    '            _strDate = FormatDateText(mesEscrito)

    '            _strDate = SubstituirEspaco(_strDate)

    '            'Select Case ComBPFormatText.SelectedItem.Tag.ID

    '            '    Case OpcoesDeFormatacaoDeTextoEnum.ComoOOriginal
    '            '        _strDate = funcoesDeString.FirstLetterUpper(_strDate)

    '            '    Case OpcoesDeFormatacaoDeTextoEnum.PrimeirasLetrasMaiusculas
    '            '        _strDate = funcoesDeString.ConvertTheFirstLettersToUppercase(_strDate)

    '            '    Case OpcoesDeFormatacaoDeTextoEnum.pRIMEIRASlETRASmINUSCULAS
    '            '        _strDate = funcoesDeString.ConvertTheFirstLettersToLowercase(_strDate)

    '            '    Case OpcoesDeFormatacaoDeTextoEnum.TODASMAIUSCULAS
    '            '        _strDate = _strDate.ToUpper
    '            '    Case OpcoesDeFormatacaoDeTextoEnum.todasMinusculas
    '            '        _strDate = _strDate.ToLower

    '            '    Case OpcoesDeFormatacaoDeTextoEnum.primeiraLetraMinúnsculaDemaisPrimeriasMaiúsculas
    '            '        _strDate = funcoesDeString.ConvertTheFirstWordToUppercase(_strDate, False)

    '            'End Select

    '        Case DateFormatEnum.MinMin
    '            _strDate = minuto

    '        Case DateFormatEnum.MM
    '            _strDate = mes

    '        Case DateFormatEnum.MMDDAA
    '            _strDate = mes + dia + ano.Substring(2, 2)

    '        Case DateFormatEnum.MMDDAAAA
    '            _strDate = mes + dia + ano

    '        Case DateFormatEnum.Semana_Dia_de_Mes_De_Ano

    '            _strDate = _date.ToLongDateString

    '            _strDate = FormatDateText(_strDate)

    '            _strDate = SubstituirEspaco(_strDate)

    '            'Select Case ComBPFormatText.SelectedItem.Tag.ID

    '            '    Case OpcoesDeFormatacaoDeTextoEnum.ComoOOriginal
    '            '        _strDate = funcoesDeString.FirstLetterUpper(_strDate)

    '            '    Case OpcoesDeFormatacaoDeTextoEnum.PrimeirasLetrasMaiusculas
    '            '        _strDate = funcoesDeString.ConvertTheFirstLettersToUppercase(_strDate)

    '            '    Case OpcoesDeFormatacaoDeTextoEnum.pRIMEIRASlETRASmINUSCULAS
    '            '        _strDate = funcoesDeString.ConvertTheFirstLettersToLowercase(_strDate)

    '            '    Case OpcoesDeFormatacaoDeTextoEnum.TODASMAIUSCULAS
    '            '        _strDate = _strDate.ToUpper
    '            '    Case OpcoesDeFormatacaoDeTextoEnum.todasMinusculas
    '            '        _strDate = _strDate.ToLower

    '            '    Case OpcoesDeFormatacaoDeTextoEnum.primeiraLetraMinúnsculaDemaisPrimeriasMaiúsculas
    '            '        _strDate = funcoesDeString.ConvertTheFirstWordToUppercase(_strDate, False)

    '            'End Select

    '        Case DateFormatEnum.SS
    '            _strDate = segundo

    '    End Select

    '    Return _strDate

    'End Function

    Public Overloads Function TrasnformDate(_date As Date, _criterion As Class_DataRenamingCriterion)  ' As DateFormatEnum)

        ' Dim _id As Integer = 0 ' ComBPRight.SelectedItem.Tag.ID

        Dim _strDate As String = _date.ToLongDateString

        Dim ano As String = _date.Year.ToString

        Dim mes As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Month, 2) '_date.Month.ToString
        Dim mesEscrito As String = MonthList(_date.Month - 1)    ' + " " + funcoesDeString.RetornaStringComNumeroCaracter(_date.Month, 2) '_date.Month.ToString
        Dim dia As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Day, 2) '_date.Day.ToString

        Dim semana As String = String.Format("{0:dddd}", _date)   ' _date.DayOfWeek.ToString

        Dim hora As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Hour, 2)

        Dim minuto As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Minute, 2)   '_date.Minute.ToString
        Dim segundo As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Second, 2) '_date.Second.ToString

        ' MsgBox(String.Format("{0:dddd}", _date))
        'MsgBox(Format(_strDate, "dddd"))

        Select Case _criterion.RenameTypeData.DadosDeTempo.DateFormat

            Case DateFormatEnum.AA
                _strDate = ano.Substring(2, 2)

            Case DateFormatEnum.AAAA
                _strDate = _date.Year

            Case DateFormatEnum.AAAAMMDD
                _strDate = ano + mes + dia
            Case DateFormatEnum.AAMMDD
                _strDate = ano.Substring(2, 2) + mes + dia

            Case DateFormatEnum.DD
                _strDate = dia

            Case DateFormatEnum.DDMMAA
                _strDate = dia + mes + ano.Substring(2, 2)

            Case DateFormatEnum.DDMMAAAA
                _strDate = dia + mes + ano

            Case DateFormatEnum.DiaDaSemana
                _strDate = FormatDateText(semana, _criterion)

                If _criterion.RenameTypeData.DadosDeTempo.SubstituirEspaco = True Then
                    _strDate = SubstituirEspaco(_strDate, _criterion.RenameTypeData.DadosDeTempo.CaracterParaSubstituicaoDoEspaco)

                End If

            Case DateFormatEnum.HH
                _strDate = hora

            Case DateFormatEnum.HHMM
                _strDate = hora + minuto

            Case DateFormatEnum.HHMMSS
                _strDate = hora + minuto + segundo

            Case DateFormatEnum.Mes_Escrito
                _strDate = FormatDateText(mesEscrito, _criterion.RenameTypeData.DadosDeTempo.OpcoesDeFormatacaoDeTextoDeDataHora)

                If _criterion.RenameTypeData.DadosDeTempo.SubstituirEspaco = True Then
                    _strDate = SubstituirEspaco(_strDate, _criterion.RenameTypeData.DadosDeTempo.CaracterParaSubstituicaoDoEspaco)
                End If

            Case DateFormatEnum.MinMin
                _strDate = minuto

            Case DateFormatEnum.MM
                _strDate = mes

            Case DateFormatEnum.MMDDAA
                _strDate = mes + dia + ano.Substring(2, 2)

            Case DateFormatEnum.MMDDAAAA
                _strDate = mes + dia + ano

            Case DateFormatEnum.Semana_Dia_de_Mes_De_Ano

                _strDate = _date.ToLongDateString

                _strDate = FormatDateText(_strDate, _criterion)

                If _criterion.RenameTypeData.DadosDeTempo.SubstituirEspaco = True Then
                    _strDate = SubstituirEspaco(_strDate, _criterion.RenameTypeData.DadosDeTempo.CaracterParaSubstituicaoDoEspaco)
                End If


            Case DateFormatEnum.SS
                _strDate = segundo

        End Select

        Return _strDate

    End Function


    Public Overloads Function SubstituirEspaco(_strDate As String, _caracterParaSubstituicaoDoEspaco As String) As String
        '  If CHKSubstituirEspaco.Checked = True Then

        _strDate = funcoesDeString.ReplacePhrase(_strDate, " ", _caracterParaSubstituicaoDoEspaco)
        _strDate = funcoesDeString.ReplacePhrase(_strDate, ",", "")

        ' End If

        Return _strDate
    End Function

    Public Overloads Function SubstituirEspaco(_strDate As String, _criterion As Class_DataRenamingCriterion) As String
        '  If CHKSubstituirEspaco.Checked = True Then

        Dim _caracterParaSubstituicaoDoEspaco As Char = _criterion.DadosDeTempo.CaracterParaSubstituicaoDoEspaco
        _strDate = funcoesDeString.ReplacePhrase(_strDate, " ", _caracterParaSubstituicaoDoEspaco)
        _strDate = funcoesDeString.ReplacePhrase(_strDate, ",", "")

        ' End If

        Return _strDate
    End Function


    Public Overloads Function FormatDateText(_strDate As String, _opcoesDeFormatacaoDeTexto As Integer)

        Dim _opcoesDeFormatacaoDeTextoParaData As Class_DataRenamingCriterion.OpcoesDeFormatacaoDeTextoEnum


        Select Case _opcoesDeFormatacaoDeTexto   '  ComBPFormatText.SelectedItem.Tag.ID

#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
            Case _opcoesDeFormatacaoDeTextoParaData.ComoOOriginal
                _strDate = funcoesDeString.FirstLetterUpper(_strDate)

            Case _opcoesDeFormatacaoDeTextoParaData.PrimeirasLetrasMaiusculas
                _strDate = funcoesDeString.ConvertTheFirstLettersToUppercase(_strDate)

            Case _opcoesDeFormatacaoDeTextoParaData.pRIMEIRASlETRASmINUSCULAS
                _strDate = funcoesDeString.ConvertTheFirstLettersToLowercase(_strDate)

            Case _opcoesDeFormatacaoDeTextoParaData.TODASMAIUSCULAS
                _strDate = _strDate.ToUpper
            Case _opcoesDeFormatacaoDeTextoParaData.todasMinusculas
                _strDate = _strDate.ToLower

            Case _opcoesDeFormatacaoDeTextoParaData.primeiraLetraMinúnsculaDemaisPrimeriasMaiúsculas
                _strDate = funcoesDeString.ConvertTheFirstLettersToUppercase(_strDate, False)
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância

        End Select

        Return _strDate

    End Function

    Public Overloads Function FormatDateText(_strDate As String, _criterion As Class_DataRenamingCriterion)

        'Dim _criterion As Class_DataRenameOption.OpcoesDeFormatacaoDeTextoEnum


        Select Case _criterion.RenameTypeData.DadosDeTempo.OpcoesDeFormatacaoDeTextoDeDataHora   '  ComBPFormatText.SelectedItem.Tag.ID

#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
            Case _criterion.OpcoesDeFormatacaoDeTextoEnum.ComoOOriginal
                _strDate = funcoesDeString.FirstLetterUpper(_strDate)

            Case _criterion.OpcoesDeFormatacaoDeTextoEnum.PrimeirasLetrasMaiusculas
                _strDate = funcoesDeString.ConvertTheFirstLettersToUppercase(_strDate)

            Case _criterion.OpcoesDeFormatacaoDeTextoEnum.pRIMEIRASlETRASmINUSCULAS
                _strDate = funcoesDeString.ConvertTheFirstLettersToLowercase(_strDate)

            Case _criterion.OpcoesDeFormatacaoDeTextoEnum.TODASMAIUSCULAS
                _strDate = _strDate.ToUpper

            Case _criterion.OpcoesDeFormatacaoDeTextoEnum.todasMinusculas
                _strDate = _strDate.ToLower

            Case _criterion.OpcoesDeFormatacaoDeTextoEnum.primeiraLetraMinúnsculaDemaisPrimeriasMaiúsculas
                _strDate = funcoesDeString.ConvertTheFirstLettersToUppercase(_strDate, False)

        End Select
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância

        Return _strDate

    End Function

    Public ReadOnly MonthList() As String = {
          "Janeiro",
          "Fevereiro",
          "Março",
          "Abril",
          "Maio",
          "Junho",
          "Julho",
          "Agosto",
          "Setembro",
          "Outubro",
          "Novembro",
          "Dezembro"
    }

    Public Enum DateFormatEnum

        DDMMAAAA = 0
        DDMMAA = 1
        MMDDAAAA = 2
        MMDDAA = 3
        AAAAMMDD = 4
        AAMMDD = 5
        AAAA = 6
        DD = 7
        MM = 8
        AA = 9
        HHMMSS = 10
        HHMM = 11
        HH = 12
        MinMin = 13
        SS = 14
        Semana_Dia_de_Mes_De_Ano = 15
        Mes_Escrito = 16
        DiaDaSemana = 17

    End Enum


End Class
