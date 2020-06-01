Imports System.IO


Public Class Class_DataRenameOption

    ' Enums 

    ' --------------------------------------------------

    Public Enum SelectADataModeEnum

        Texto = 0
        NovaExtensao = 1
        NomeDoArquivoAtual = 2
        SequenciaNumerica = 3
        LetraDaSequencia = 4
        DataEHora = 5
        Metadados = 6
        NomeDaPasta = 7
        SubstituicaoDeString = 8

    End Enum

    Public ListNomeOuExtensaoDoArquivoAtual As NomeOuExtensaoDoArquivoAtualEnum
    Public Enum NomeOuExtensaoDoArquivoAtualEnum
        NomeEExtensao = 0
        Nome = 1
        Extensao = 2
    End Enum

    Public Enum OpcoesDeFormatacaoDeTextoEnum

        ComoOOriginal = 0
        TODASMAIUSCULAS = 1
        todasMinusculas = 2
        PrimeirasLetrasMaiusculas = 3
        pRIMEIRASlETRASmINUSCULAS = 4
        primeiraLetraMinúnsculaDemaisPrimeriasMaiúsculas = 5

    End Enum

    Public Enum OpcoesDeFormatacaoDeSequenciaDeLetrasEnum

        TODASMAIUSCULAS = 0
        todasMinusculas = 1

    End Enum

    Public Enum TempoDaDataEnum

        DataDeCriacao = 0
        DataDeModificacao = 1
        Ontem = 2
        Hoje = 3
        Amanha = 4

    End Enum

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


    ' Estruturas 
    ' -------------------------------------------------------
    Public Structure RenameTypeDataStructure

        ' Tipo de tela
        Public Tela As Integer

        ' Para tela Tipo Texto
        Public Text As String

        ' Para Tela Tipo Extensao
        Public Extensao As String

        ' Para Tela Nome de Arquivo
        Public DadosDeNomeDeArquivoAtual As DadosDeNomeDeArquivoStructure

        ' Para Tela de Numero de sequencia
        Public DadosDeSequenciaNumerica As DadosDeSequenciaNumericaStructure

        ' Para Tela de Sequencia de Letras
        Public DadosDeSequenciaDeLetras As DadosDeSequenciaDeLetrasStructure

        ' Para Tela de Data
        Public DadosDeTempo As DadosDeTempoStructure

        ' Para tela de Nome de Pasta
        Public DadosDeNomeDaPasta As DadosDeNomeDaPastaStructure

        ' para tela de pesquisa e substituição

        Public DadosDeSubstituicao As DadosDeSubstituicaoStructure

    End Structure

    Public Structure DadosDeNomeDeArquivoStructure

        Public NomeDoArquivo As FileInfo
        Public NomeOuExtensaoDoArquivoAtual As NomeOuExtensaoDoArquivoAtualEnum
        Public OpcoesDeFormatacaoDeTexto As OpcoesDeFormatacaoDeTextoEnum
        Public PrimeiraLetraMinusculaDeNomeDeArquivo As Boolean
        Public RemoverEspacoDeNomeDeArquivo As Boolean

    End Structure

    Public Structure DadosDeSequenciaNumericaStructure
        Public NumeroDeSequencia As Integer
        Public QuantidadeDeDigitosDaSequenciaNumerica As Integer
    End Structure

    Public Structure DadosDeSequenciaDeLetrasStructure
        Public SequenciaDeLetra As String
        Public OpcoesDeFormatacaoDeSequenciaDeLetras As OpcoesDeFormatacaoDeSequenciaDeLetrasEnum
    End Structure

    Public Structure DadosDeTempoStructure
        Public TempoDaData As TempoDaDataEnum
        Public DateFormat As DateFormatEnum
        Public OpcoesDeFormatacaoDeTextoDeDataHora As OpcoesDeFormatacaoDeTextoEnum
        Public SubstituirEspaco As Boolean
        Public CaracterParaSubstituicaoDoEspaco As Char
    End Structure

    Public Structure DadosDeNomeDaPastaStructure
        Public PrimeiraLetraMinuscula As Boolean
        Public RemoverEspaco As Boolean
        Public PrimeiraLetraMinusculaDeNomeDaPasta As Boolean
        Public RemoverEspacoDeNomeDaPasta As Boolean

        Public OpcoesDeFormatacaoDeTextoDaPasta As OpcoesDeFormatacaoDeTextoEnum
    End Structure

    Public Structure DadosDeSubstituicaoStructure
        Public Find As String
        Public Substituir As String
        Public IgnorarMaiusculasEMinusculas As Boolean
        Public SubstituirTudo As Boolean
    End Structure

    Public RenameTypeData As RenameTypeDataStructure

    Public DadosDeNomeDeArquivo As DadosDeNomeDeArquivoStructure
    Public DadosDeSequenciaNumerica As DadosDeSequenciaNumericaStructure

    ' Para Tela de Sequencia de Letras
    Public DadosDeSequenciaDeLetras As DadosDeSequenciaDeLetrasStructure

    ' Para Tela de Data
    Public DadosDeTempo As DadosDeTempoStructure

    ' Para tela de Nome de Pasta
    Public DadosDeNomeDaPasta As DadosDeNomeDaPastaStructure

    ' para tela de pesquisa e substituição
    Public DadosDeSubstituicao As DadosDeSubstituicaoStructure

End Class
