'Imports System.Security.Cryptography.X509Certificates

Imports System.IO
Imports System.Reflection
Imports System.ComponentModel

Public Class Control_RenameOption


    Private Alfabeto As New List(Of Char)

    ReadOnly MonthList() As String = {
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

    'Criar componente
    '--------------------------------------------------
    Public LoadRenameOptionsParent As Control_LoadRenameOptions

    Dim TextReplace As New Control_TextReplace

    '--------------------------------------------------


    'Importação de Classes
    '--------------------------------------------------
    ReadOnly funcoesDeString As New StringFunctionsClass
    Private configs As Class_Configs
    Private usesFile As New UsesFilesClass
    Public DataRenamingCriterion As New Class_DataRenamingCriterion
    Dim FormatAlphabetLetter As New Class_FormatAlphabetLetter
    ' -------------------------------------------------


    ' Propriedades 
    ' _____________________________________________

    ' Propriedades do Formulário
    '--------------------------------------------------
    Private _fileExemple As FileInfo
    Public Property FileExemple As String
        Get
            Return _fileExemple.FullName

        End Get
        Set(value As String)
            If value IsNot Nothing Or Trim(value) = "" Then
                _fileExemple = New FileInfo(value)

            Else
                value = "C:\Pasta Teste\Arquivo.txt"
                _fileExemple = New FileInfo(value)
            End If

            TextReplace.Phrase = _fileExemple.Name
        End Set


    End Property
    '--------------------------------------------------

    Private _activeDelete As Boolean
    Public Property ActiveDelete As Boolean
        Get
            Return _activeDelete

        End Get
        Set(value As Boolean)
            _activeDelete = value

            If _activeDelete = True Then
                BTNRemoveRenomeDeOrigem.BackgroundImage = My.Resources.minus
                BTNRemoveRenomeDeOrigem.Enabled = True

            Else
                BTNRemoveRenomeDeOrigem.BackgroundImage = My.Resources.minus_inativo_50
                BTNRemoveRenomeDeOrigem.Enabled = False

            End If

        End Set
    End Property

    Private _id As Integer
    Public Property ID As Integer
        Get
            Return _id

        End Get
        Set(value As Integer)
            _id = value

        End Set
    End Property

    Private _dataReturn As Object
    Public Property DataReturn As Object
        Get
            Return _dataReturn

        End Get
        Set(value As Object)
            _dataReturn = value

        End Set
    End Property

    Private _stringData As String
    Public Property StringData As String
        Get
            Return _stringData

        End Get
        Set(value As String)
            _stringData = value

        End Set
    End Property

    Public _selectDisplayTela As SelectADataModeEnum
    Public Property SelectDisplayTela As SelectADataModeEnum
        Get
            Return _selectDisplayTela

        End Get
        Set(value As SelectADataModeEnum)
            _selectDisplayTela = value

            DataRenamingCriterion.RenameTypeData.Tela = value
            '  DataRenamingCriterion.RenameTypeData.Tela = ComBPMaster.SelectedItem.Tag.ID
            DisplayScreenOfADataMode()

        End Set
    End Property

    ' Proriedades de dados 
    '----------------------------------------------
    Private _textValue As String
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property TextValue As String
        Get
            Return _textValue

        End Get
        Set(value As String)
            _textValue = value

        End Set
    End Property

    Private _newExttValue As String
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property NewExtValue As String
        Get
            Return _newExttValue

        End Get
        Set(value As String)
            _newExttValue = value

        End Set
    End Property

    Private _fileNametValue As FileInfo
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property FileNametValue As String
        Get
            Return _fileNametValue.FullName

        End Get
        Set(value As String)
            _fileNametValue = New FileInfo(value)

        End Set
    End Property

    Private _nomeOuExtensaoDoArquivoAtual As NomeEExtensaoEnum
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property NomeOuExtensaoDoArquivoAtual As NomeEExtensaoEnum
        Get
            Return _nomeOuExtensaoDoArquivoAtual

        End Get
        Set(value As NomeEExtensaoEnum)
            _nomeOuExtensaoDoArquivoAtual = value
            DataRenamingCriterion.RenameTypeData.DadosDeNomeDeArquivoAtual.NomeOuExtensaoDoArquivoAtual = value

        End Set
    End Property

    Private _opcoesDeFormatacaoDeTextoDoArquivoAtual As OpcoesDeFormatacaoDeTextoEnum
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property OpcoesDeFormatacaoDeTextoDoArquivoAtual As OpcoesDeFormatacaoDeTextoEnum
        Get
            Return _opcoesDeFormatacaoDeTextoDoArquivoAtual

        End Get
        Set(value As OpcoesDeFormatacaoDeTextoEnum)
            _opcoesDeFormatacaoDeTextoDoArquivoAtual = value
            DataRenamingCriterion.RenameTypeData.DadosDeNomeDeArquivoAtual.OpcoesDeFormatacaoDeTexto = _opcoesDeFormatacaoDeTextoDoArquivoAtual

        End Set
    End Property

    Private _primeiraLetraMinusculaDeNomeDeArquivo As Boolean
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property PrimeiraLetraMinusculaDeNomeDeArquivo As Boolean
        Get
            Return _primeiraLetraMinusculaDeNomeDeArquivo
        End Get
        Set(value As Boolean)
            _primeiraLetraMinusculaDeNomeDeArquivo = value
            DataRenamingCriterion.RenameTypeData.DadosDeNomeDeArquivoAtual.PrimeiraLetraMinusculaDeNomeDeArquivo = _primeiraLetraMinusculaDeNomeDeArquivo

        End Set
    End Property

    Private _removerEspacoDeNomeDeArquvo As Boolean
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property RemoverEspacoDeNomeDeArquvo As Boolean
        Get
            Return _removerEspacoDeNomeDeArquvo
        End Get
        Set(value As Boolean)
            _removerEspacoDeNomeDeArquvo = value
            DataRenamingCriterion.RenameTypeData.DadosDeNomeDeArquivoAtual.RemoverEspacoDeNomeDeArquivo = _removerEspacoDeNomeDeArquvo

        End Set
    End Property


    Private _numeroDeSequencia As Integer
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property NumeroDeSequencia As Integer
        Get
            Return _numeroDeSequencia
        End Get
        Set(value As Integer)
            _numeroDeSequencia = value

        End Set
    End Property

    Private _quantidadeDeDigitosDaSequenciaNumerica As Integer
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property QuantidadeDeDigitosDaSequenciaNumerica As Integer
        Get
            Return _quantidadeDeDigitosDaSequenciaNumerica
        End Get
        Set(value As Integer)
            _quantidadeDeDigitosDaSequenciaNumerica = value
            DataRenamingCriterion.RenameTypeData.DadosDeSequenciaNumerica.QuantidadeDeDigitosDaSequenciaNumerica = _quantidadeDeDigitosDaSequenciaNumerica

        End Set
    End Property

    Private _opcoesDeFormatacaoDeSequenciaDeLetras As OpcoesDeFormatacaoDeSequenciaDeLetrasEnum
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property OpcoesDeFormatacaoDeSequenciaDeLetras As OpcoesDeFormatacaoDeSequenciaDeLetrasEnum
        Get
            Return _opcoesDeFormatacaoDeSequenciaDeLetras
        End Get
        Set(value As OpcoesDeFormatacaoDeSequenciaDeLetrasEnum)
            _opcoesDeFormatacaoDeSequenciaDeLetras = value
            DataRenamingCriterion.RenameTypeData.DadosDeSequenciaDeLetras.OpcoesDeFormatacaoDeSequenciaDeLetras = _opcoesDeFormatacaoDeSequenciaDeLetras


        End Set
    End Property

    Private _tempoDaData As TempoDaDataEnum
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property TempoDaData As TempoDaDataEnum
        Get
            Return _tempoDaData
        End Get
        Set(value As TempoDaDataEnum)
            _tempoDaData = value
            DataRenamingCriterion.RenameTypeData.DadosDeTempo.TempoDaData = _tempoDaData
        End Set
    End Property

    ' Public _dateFormat As DateFormatEnum
    Private _dateFormatValue As DateFormatEnum
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property DateFormatValue As DateFormatEnum
        Get
            Return _dateFormatValue
        End Get
        Set(value As DateFormatEnum)
            _dateFormatValue = value
            DataRenamingCriterion.RenameTypeData.DadosDeTempo.DateFormat = _dateFormatValue

        End Set
    End Property

    Private _opcoesDeFormatacaoDeTextoDeDataHora As OpcoesDeFormatacaoDeTextoEnum
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property OpcoesDeFormatacaoDeTextoDeDataHora
        Get
            Return _opcoesDeFormatacaoDeTextoDeDataHora

        End Get
        Set(value)
            _opcoesDeFormatacaoDeTextoDeDataHora = value
            DataRenamingCriterion.RenameTypeData.DadosDeTempo.OpcoesDeFormatacaoDeTextoDeDataHora = _opcoesDeFormatacaoDeTextoDeDataHora

        End Set
    End Property

    Private _substituirEspacoDaData As Boolean
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property SubstituirEspacoDaData As Boolean
        Get
            Return _substituirEspacoDaData

        End Get
        Set(value As Boolean)
            _substituirEspacoDaData = value

        End Set
    End Property

    Private _caracterParaSubstituicaoDoEspaco As Char
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property CaracterParaSubstituicaoDoEspaco As String
        Get
            Return CStr(_caracterParaSubstituicaoDoEspaco)
        End Get
        Set(value As String)
            _caracterParaSubstituicaoDoEspaco = CChar(value.Substring(0, 1))

        End Set
    End Property

    Private _primeiraLetraMinusculaDeNomeDaPasta As Boolean
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property PrimeiraLetraMinusculaDeNomeDaPasta As Boolean
        Get
            Return (_primeiraLetraMinusculaDeNomeDaPasta)
        End Get
        Set(value As Boolean)
            _primeiraLetraMinusculaDeNomeDaPasta = value

        End Set
    End Property


    Private _removerEspacoDeNomeDaPasta As Boolean
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property RemoverEspacoDeNomeDaPasta As Boolean
        Get
            Return (_removerEspacoDeNomeDaPasta)
        End Get
        Set(value As Boolean)
            _removerEspacoDeNomeDaPasta = value

        End Set
    End Property

    Private _removerEspacoDeNomeDeArquivo As Boolean
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property RemoverEspacoDeNomeDeArquivo As Boolean
        Get
            Return (_removerEspacoDeNomeDeArquivo)
        End Get
        Set(value As Boolean)
            _removerEspacoDeNomeDeArquivo = value

        End Set
    End Property

    Private _opcoesDeFormatacaoDeTextoDaPasta As OpcoesDeFormatacaoDeTextoEnum
    <Category("Variáveis de Renome")>
    <Description(".")>
    Public Property OpcoesDeFormatacaoDeTextoDaPasta As OpcoesDeFormatacaoDeTextoEnum
        Get
            Return (_opcoesDeFormatacaoDeTextoDaPasta)
        End Get
        Set(value As OpcoesDeFormatacaoDeTextoEnum)
            _opcoesDeFormatacaoDeTextoDaPasta = value
            DataRenamingCriterion.RenameTypeData.DadosDeNomeDaPasta.OpcoesDeFormatacaoDeTextoDaPasta = _opcoesDeFormatacaoDeTextoDaPasta

        End Set
    End Property

    Private _findValue As String
    Public Property FindValue As String
        Get
            Return _findValue
        End Get
        Set(value As String)
            _findValue = value

            DataRenamingCriterion.RenameTypeData.DadosDeSubstituicao.Find = value
        End Set
    End Property

    Private _replacementValue As String
    Public Property ReplacementValue As String
        Get
            Return _replacementValue
        End Get
        Set(value As String)
            _replacementValue = value
            DataRenamingCriterion.RenameTypeData.DadosDeSubstituicao.Replacement = value

        End Set
    End Property

    Private _ignoreUpperLowerOfReplacementData As Boolean
    Public Property IgnoreUpperLowerOfReplacementData As Boolean
        Get
            Return _ignoreUpperLowerOfReplacementData
        End Get
        Set(value As Boolean)
            _ignoreUpperLowerOfReplacementData = value
            DataRenamingCriterion.RenameTypeData.DadosDeSubstituicao.IgnoreUpperLowerOfReplacementData = value  'TextReplace.CHKIgnoreUpperLower.Checked

        End Set
    End Property

    Private _replaceAllReplacementData As Boolean
    Public Property ReplaceAllReplacementData
        Get
            Return _replaceAllReplacementData
        End Get
        Set(value)
            _replaceAllReplacementData = value
            DataRenamingCriterion.RenameTypeData.DadosDeSubstituicao.ReplaceAllReplacementData = value
        End Set
    End Property



    '----------------------------------------------


    ' _____________________________________________


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

    Public OpcoesDeFormatacaoDeTexto As OpcoesDeFormatacaoDeTextoEnum
    Public Enum OpcoesDeFormatacaoDeTextoEnum

        ComoOOriginal = 0
        TODASMAIUSCULAS = 1
        todasMinusculas = 2
        PrimeirasLetrasMaiusculas = 3
        pRIMEIRASlETRASmINUSCULAS = 4
        primeiraLetraMinúnsculaDemaisPrimeriasMaiúsculas = 5

    End Enum

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

    Public _nomeEExtensao As NomeEExtensaoEnum
    Public Enum NomeEExtensaoEnum
        NomeEExtensao = 0
        Nome = 1
        Extensao = 2
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



    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        _id = 0

        ActiveDelete = False

        TextValue = ""


    End Sub

    ' pROCEDIMENTOS DE Exibçao de tela
    '___________________________________________________________
    Sub ExibirTelaTexto()

        TextValidateConfig()

        Panel_Right.Visible = False
        PanelEnvolve_RightTXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelBase.Visible = False

        PanelSubstituir.Visible = True
        PanelDateConfig.Visible = False
        PanelDateConfig.Visible = False

        TXTPValue.TXT = ""
        _textValue = ""
        TXTPValue.Validar(TXTPValue.TXT)

        PanelEnvolve_ComBPSlave.Controls.Add(TXTPValue)
        PanelEnvolve_RightTXT.Controls.Add(ComBPSlave)

        TXTPValue.Placeholder = "Digite um Texto..."

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill





    End Sub

    Sub ExibirTelaNovaExtensao()
        ExtensionValidateConfig()

        Panel_Right.Visible = False
        PanelEnvolve_RightTXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True

        PanelBase.Visible = False
        PanelSubstituir.Visible = True
        PanelDateConfig.Visible = False

        TXTPValue.TXT = "" '
        _newExttValue = ""

        TXTPValue.Validar(TXTPValue.TXT)

        TXTPValue.Placeholder = "Digite uma extensão..."

        PanelEnvolve_ComBPSlave.Controls.Add(TXTPValue)
        PanelEnvolve_RightTXT.Controls.Add(ComBPSlave)
        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

    End Sub

    Sub ExibirTelaNomeDoArquivoAtual()

        Panel_Right.Visible = True
        PanelEnvolve_RightTXT.Visible = False
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelBase.Visible = False

        PanelSubstituir.Visible = True
        PanelNomeDoArquivoAtualConfig.Visible = True
        PanelDateConfig.Visible = False

        ComBPMaster.PerformAutomaticSelection(2)

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        Panel_Right.Controls.Add(TXTPValue)
        PanelEnvolve_ComBRight.Controls.Add(ComBPRight)
        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        '

        ' Adicionar Nova lista
        ' _____-----------------------------------------------------_____

        Dim listItem As New Collections.Specialized.StringCollection

        listItem.AddRange({" Como o Original", " TODAS MAIÚSCULAS", " todas minúsculas", "Primeiras Letras Maiúsculas", "pRIMEIRAS lETRAS mINÚSCULAS"})

        ComBPRight.OptionsList = listItem
        ComBPRight.PerformAutomaticSelection(0)

        ' _____-----------------------------------------------------_____

        For Each item As ToolStripMenuItem In ComBPRight.CMS_Menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf ExibirSubTelaPrimeiraMaiuscDeNomeDoArquivoAtual)

        Next

        For Each item As ToolStripMenuItem In ComBPSlave.CMS_Menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf ComBPSlave_Clicked)

        Next


        For Each item As ToolStripMenuItem In ComBPRight.CMS_Menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf ComBPRight_Clicked)

        Next
    End Sub

    Sub ExibirSubTelaPrimeiraMaiuscDeNomeDoArquivoAtual()
        If ComBPRight.SelectedItem.Tag.ID = 3 Then

            ExibirSubTelaPrimeiraMinuscula()

        Else

            OcultarSubTelaPrimeiraMinuscula()

        End If

    End Sub

    Sub ComBPSlave_Clicked()

        Dim _selectedMaster As Integer = ComBPMaster.SelectedItem.Tag.ID

        ' TODO: Estas variveis abaixo deveriam ser do tipo BYTE ...
        '... pois assim ocupariam menos espaço na memoria.

        Dim _q As Integer = ComBPMaster.OptionsList.Count
        Dim _id As Integer = ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count

        Select Case _selectedMaster
            Case SelectADataModeEnum.NomeDoArquivoAtual

                NomeOuExtensaoDoArquivoAtual = ComBPSlave.SelectedItem.Tag.ID - _q


            Case SelectADataModeEnum.DataEHora

                _tempoDaData = ComBPSlave.SelectedItem.Tag.ID - _q

            Case SelectADataModeEnum.NomeDaPasta
                OpcoesDeFormatacaoDeTextoDaPasta = ComBPSlave.SelectedItem.Tag.ID - _q

            Case SelectADataModeEnum.LetraDaSequencia

                MsgBox("Slave")
                OpcoesDeFormatacaoDeSequenciaDeLetras = ComBPSlave.SelectedItem.Tag.ID - _q


        End Select


    End Sub

    Sub ComBPRight_Clicked()

        Dim _id As Integer = ComBPMaster.SelectedItem.Tag.ID

        Select Case _id
            Case SelectADataModeEnum.NomeDoArquivoAtual

                OpcoesDeFormatacaoDeTextoDoArquivoAtual = ComBPRight.SelectedItem.Tag.ID   ' ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count


                If ComBPRight.SelectedItem.Tag.ID = 3 Then

                    PrimeiraLetraMinusculaDeNomeDeArquivo = CKB_FirstLetterUpper.Checked

                    RemoverEspacoDeNomeDeArquvo = CKB_RemoveSpace.Checked

                End If


            Case SelectADataModeEnum.SequenciaNumerica

                QuantidadeDeDigitosDaSequenciaNumerica = (ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count) + 1

            Case SelectADataModeEnum.LetraDaSequencia

                MsgBox("ssss")
                OpcoesDeFormatacaoDeSequenciaDeLetras = (ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count) + 1  'ComBPRight.SelectedItem.Tag.ID

            Case SelectADataModeEnum.DataEHora
                DateFormatValue = ComBPRight.SelectedItem.Tag.ID

        End Select
    End Sub

    Sub ComBPFormatText_Clicked()

        OpcoesDeFormatacaoDeTextoDeDataHora = ComBPFormatText.SelectedItem.Tag.ID

    End Sub

    Sub CombPMaster_Clicked()
        DataRenamingCriterion.RenameTypeData.Tela = ComBPMaster.SelectedItem.Tag.ID

    End Sub


    Sub ExibirSubTelaPrimeiraMinuscula()

        TableLPContainer.Dock = DockStyle.Top
        TableLPContainer.Height = 28
        Me.Height = 86
        PanelBase.Visible = True

        PanelSubstituir.Visible = False
        PanelNomeDoArquivoAtualConfig.Visible = True
        PanelDateConfig.Visible = False

    End Sub

    Sub OcultarSubTelaPrimeiraMinuscula()

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill
        PanelBase.Visible = False

        PanelSubstituir.Visible = True
        PanelNomeDoArquivoAtualConfig.Visible = True
        PanelDateConfig.Visible = False

    End Sub

    Sub ExibirTelaNumeroDeSequencia()

        NumeroDaSequenciaValidateConfig()

        Panel_Right.Visible = True
        PanelEnvolve_RightTXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = False

        PanelBase.Visible = False
        PanelSubstituir.Visible = True
        PanelDateConfig.Visible = False

        TXTPValue.Placeholder = "Digite um número para a sequência ..."

        TXTPValue.TXT = "0"
        TXTPValue.Validar(TXTPValue.TXT)

        PanelEnvolve_ComBPSlave.Controls.Add(TXTPValue)
        PanelEnvolve_RightTXT.Controls.Add(ComBPSlave)
        PanelEnvolve_ComBRight.Controls.Add(ComBPRight)

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        AddHandler_TxtValue_Changed_inClick()

    End Sub


    Sub ExibirTelaLetraDaSequencia()

        LetraDaSequenciaValidateConfig()

        Panel_Right.Visible = True
        PanelEnvolve_RightTXT.Visible = True
        PanelEnvolve_ComBRight.Visible = False

        PanelEnvolve_ComBPSlave.Visible = True

        PanelBase.Visible = False
        PanelSubstituir.Visible = True
        PanelNomeDoArquivoAtualConfig.Visible = True
        PanelDateConfig.Visible = False

        TXTPValue.Placeholder = "Digite letra do Alfabeto..."
        TXTPValue.TXT = ChrW(65).ToString
        TXTPValue.Validar(TXTPValue.TXT)


        ComBPMaster.PerformAutomaticSelection(4)

        PanelEnvolve_ComBPSlave.Controls.Add(TXTPValue)
        PanelEnvolve_RightTXT.Controls.Add(ComBPSlave)
        PanelEnvolve_ComBRight.Controls.Add(ComBPRight)

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        PrepararAlfabeto()

        AddHandler_TxtValue_Changed_inClick()

    End Sub

    Sub ExibirTelaDataEHora()

        Panel_Right.Visible = True
        PanelEnvolve_RightTXT.Visible = False
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True

        PanelBase.Visible = False
        PanelSubstituir.Visible = True
        PanelDateConfig.Visible = False

        ComBPMaster.PerformAutomaticSelection(5)

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        PanelEnvolve_RightTXT.Controls.Add(TXTPValue)
        PanelEnvolve_ComBRight.Controls.Add(ComBPRight)

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        ' Adicionar Nova lista
        ' _____-----------------------------------------------------_____

        Dim listItem As New Collections.Specialized.StringCollection

        listItem.AddRange({"DDMMAAAA", "DDMMAA", "MMDDAAAA", "MMDDAA", "AAAAMMDD", "AAMMDD", "AAAA", "DD", "MM", "AA", "HHMMSS", "HHMM", "HH", "MIN", "SS", "Semana, Dia de Mês de Ano", "Mês (escrito)", "Dia da Semana"})

        ComBPRight.OptionsList = listItem
        ComBPRight.PerformAutomaticSelection(0)

        ' _____-----------------------------------------------------_____


        For Each item As ToolStripMenuItem In ComBPRight.CMS_Menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf MostrarOcultarDataEHoraConfig)
            AddHandler item.Click, New System.EventHandler(AddressOf ComBPRight_Clicked)

        Next

        For Each item As ToolStripMenuItem In ComBPSlave.CMS_Menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf ComBPSlave_Clicked)

        Next

    End Sub

    Sub MostrarOcultarDataEHoraConfig()

        Select Case ComBPRight.SelectedItem.Tag.ID
            Case DateFormatEnum.DiaDaSemana, DateFormatEnum.Mes_Escrito, DateFormatEnum.Semana_Dia_de_Mes_De_Ano
                ExibirSubTelaDataEHoraConfig()

            Case Else
                OcultarSubTelaDataEHoraConfig()

        End Select

    End Sub

    Sub ExibirSubTelaDataEHoraConfig()

        PanelBase.Visible = True
        PanelSubstituir.Visible = False
        PanelNomeDoArquivoAtualConfig.Visible = False
        PanelDateConfig.Visible = True

        TableLPContainer.Dock = DockStyle.Top
        TableLPContainer.Height = 28

        PanelBase.Dock = DockStyle.Fill
        Me.Height = 92

    End Sub

    Sub OcultarSubTelaDataEHoraConfig()

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        PanelBase.Visible = False
        PanelSubstituir.Visible = True
        PanelNomeDoArquivoAtualConfig.Visible = True
        PanelDateConfig.Visible = False

    End Sub

    Sub ExibirTelaMetadados()

        Panel_Right.Visible = False
        PanelEnvolve_RightTXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True

        PanelBase.Visible = False
        PanelSubstituir.Visible = True
        PanelDateConfig.Visible = False

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPRight)
        PanelEnvolve_RightTXT.Controls.Add(ComBPSlave)
        PanelEnvolve_ComBRight.Controls.Add(TXTPValue)


        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        ' Adicionar Nova lista
        ' _____-----------------------------------------------------_____

        Dim listItem As New Collections.Specialized.StringCollection

        listItem.AddRange({"Título"})

        ComBPRight.OptionsList = listItem
        ComBPRight.PerformAutomaticSelection(0)

        ' _____-----------------------------------------------------_____
    End Sub


    Sub ExibirTelaNomeDaPasta()

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        PanelEnvolve_RightTXT.Controls.Add(TXTPValue)
        PanelEnvolve_ComBRight.Controls.Add(ComBPRight)


        Panel_Right.Visible = False
        PanelEnvolve_RightTXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True

        PanelBase.Visible = False
        PanelSubstituir.Visible = True
        PanelDateConfig.Visible = False

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        For Each item As ToolStripMenuItem In ComBPSlave.CMS_Menu.Items

            AddHandler item.Click, New System.EventHandler(AddressOf ExibirSubTelaPrimeiraMaiuscDeNomeDaPasta)
            AddHandler item.Click, New System.EventHandler(AddressOf ComBPSlave_Clicked)

        Next

    End Sub

    Sub ExibirSubTelaPrimeiraMaiuscDeNomeDaPasta()
        If ComBPSlave.SelectedItem.Tag.ID = 3 + ComBPMaster.OptionsList.Count Then

            ExibirSubTelaPrimeiraMinuscula()

        Else

            OcultarSubTelaPrimeiraMinuscula()

        End If
    End Sub


    Sub ExibirTelaSubstituicaoDeString()

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        PanelEnvolve_RightTXT.Controls.Add(TXTPValue)
        PanelEnvolve_ComBRight.Controls.Add(ComBPRight)


        Panel_Right.Visible = False
        PanelEnvolve_RightTXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = False
        PanelEnvolve_ComBRight.Visible = True

        PanelBase.Visible = True
        PanelSubstituir.Visible = True
        PanelNomeDoArquivoAtualConfig.Visible = False

        PanelBase.Dock = DockStyle.Fill

        Me.Height = 111

        TableLPContainer.Dock = DockStyle.Top
        TableLPContainer.Height = 28

    End Sub
    '___________________________________________________________

    Sub MostrarOrdem()
        For Each item In Me.Parent.Controls
            MsgBox(item.ID)
        Next
    End Sub

    Sub OrdenarRenameOption()
        'TODO: https://csharp.net-tutorials.com/pt/439/linq/organizando-dados-os-metodos-orderby-thenby/

        Dim listControl(Me.Parent.Controls.Count - 1) As Control

        For Each item As Control_RenameOption In Me.Parent.Controls

            item.TabIndex = item.ID

            listControl(item.ID) = item

        Next

        Me.Parent.Controls.AddRange(listControl.Reverse.ToArray)

    End Sub

    Sub IndexarRenameOption(index As Integer)

        For Each item As Control_RenameOption In Me.Parent.Controls
            If item.ID > index Then
                item.ID += 1

            End If
        Next

    End Sub

    Sub RemoverIndice(index As Integer)

        For Each item As Control_RenameOption In Me.Parent.Controls
            If item.ID > index Then
                item.ID -= 1

            End If
        Next

    End Sub

    Private Sub BTNRemoveRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNRemoveRenomeDeOrigem.Click

        If Me.Parent.Controls.Count > 1 Then

            RemoverIndice(Me.ID)

            Me.Finalize()
            Me.Parent.Controls.Remove(Me)

            If LoadRenameOptionsParent.Panel_LoadRenameOption.Controls.Count = 1 Then
                Dim item As Control_RenameOption
                item = LoadRenameOptionsParent.Panel_LoadRenameOption.Controls.Item(0)

                item.ActiveDelete = False

            End If

        End If

        LoadRenameOptionsParent.AtualizarItensList()

    End Sub

    Private Sub BTNAddRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNAddRenomeDeOrigem.Click

        Dim renameOption As New Control_RenameOption

        Me.Parent.Controls.Add(renameOption)

        Me.ActiveDelete = True

        renameOption.Dock = DockStyle.Top

        IndexarRenameOption(ID)

        renameOption.ID = ID + 1
        renameOption.Width = Me.Parent.Width
        renameOption.ActiveDelete = True
        renameOption.Visible = True

        OrdenarRenameOption()

        ' LoadRenameOptionsParent.Itens.Add(renameOption)
        LoadRenameOptionsParent.AtualizarItensList()


    End Sub

    Private Sub Control_RenameOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Me.Parent.Parent.Parent.Parent IsNot Nothing Then
            If TypeOf (Me.Parent.Parent.Parent.Parent) Is Control_LoadRenameOptions Then
                LoadRenameOptionsParent = Me.Parent.Parent.Parent.Parent

            End If
        End If

        FileExemple = LoadRenameOptionsParent.FileExemple


        TextReplace.Dock = DockStyle.Fill

        PanelSubstituir.Controls.Add(TextReplace)

        TextReplace.AutomaticResult = True

        TextReplace.Visible = True
        ' If _fileExemple IsNot Nothing Then
        TextReplace.Phrase = _fileExemple.Name
        ' End If

        ApplyEventToSubItemsMenu(ComBPMaster.CMS_Menu)

        'TextValidateConfig()
        'ExibirTelaTexto()
        AplicarTela()

        AddHandler TXTPValue.TXTBox.LostFocus, New System.EventHandler(AddressOf TxtValue_Changed)
        AddHandler TXTPCaracterParaSubstituicaoDoEspaco.TXTBox.LostFocus, New System.EventHandler(AddressOf TXTPSubstituirEspaco_Changed)



        For Each item As ToolStripMenuItem In ComBPMaster.CMS_Menu.Items
            If item.Text = "Metadados" Then item.Visible = False

            AddHandler item.Click, New System.EventHandler(AddressOf CombPMaster_Clicked)
        Next

        For Each item As ToolStripMenuItem In ComBPFormatText.CMS_Menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf ComBPFormatText_Clicked)

        Next

        For Each item As ToolStripMenuItem In ComBPSlave.CMS_Menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf ComBPSlave_Clicked)

        Next


        AddHandler TextReplace.TXTPFind.TXTBox.LostFocus, New System.EventHandler(AddressOf TXTPFind_LostFocus)
        AddHandler TextReplace.TXTPFind.TXTBox.TextChanged, New System.EventHandler(AddressOf TXTPFind_LostFocus)

        AddHandler TextReplace.TXTPReplacement.TXTBox.LostFocus, New System.EventHandler(AddressOf TXTPReplacement_LostFocus)
        AddHandler TextReplace.TXTPReplacement.TXTBox.TextChanged, New System.EventHandler(AddressOf TXTPReplacement_LostFocus)

        AddHandler TextReplace.CHKIgnoreUpperLower.CheckedChanged, New System.EventHandler(AddressOf TextReplace_CHKIgnoreUpperLower_CheckedChanged)
        AddHandler TextReplace.CHKReplaceAll.CheckedChanged, New System.EventHandler(AddressOf TextReplace_CHKReplaceAll_CheckedChanged)

        'Dim s As New System.Text.StringBuilder()
        '' For i As Integer = 65 To 90
        'For i As Integer = 1 To 100
        '    If i = 65 Or i = 91 Then
        '        s.Append(Chr(13))

        '    End If

        '    If i < 65 Or i > 91 Then
        '        s.Append(CChar(ChrW(i)).ToString() & " = " & i.ToString() & " ")

        '    Else
        '        s.Append(CChar(ChrW(i)).ToString() & " ")
        '    End If
        '    ' regex
        'Next

        'MsgBox(s.ToString())
        'MsgBox(Chr(65))
        'MsgBox(Chr(90))



        '        DataRenameOption.RenameTypeData.DadosDeNomeDaPasta.PrimeiraLetraMinuscula = True

    End Sub

    Sub TXTPFind_LostFocus()

        FindValue = TextReplace.Find

    End Sub

    Sub TXTPReplacement_LostFocus()

        ReplacementValue = TextReplace.Replacement

    End Sub

    Sub TextReplace_CHKIgnoreUpperLower_CheckedChanged()


        IgnoreUpperLowerOfReplacementData = TextReplace.CHKIgnoreUpperLower.Checked

    End Sub

    Sub TextReplace_CHKReplaceAll_CheckedChanged()
        ReplaceAllReplacementData = TextReplace.CHKReplaceAll.Checked

    End Sub

    Sub PrepararAlfabeto()

        If Alfabeto IsNot Nothing Then Alfabeto.Clear()

        For i As Integer = 65 To 90
            Alfabeto.Add(CChar(ChrW(i)))

        Next
    End Sub

    Private Sub Control_RenameOption_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

    End Sub

    Public Sub DisplayScreenOfADataMode()

        If ComBPMaster.SelectedItem IsNot Nothing Then
            Dim _id As Integer = ComBPMaster.SelectedItem.Tag.ID

            Select Case _id

                Case SelectADataModeEnum.Texto
                    '    TextValidateConfig()
                    ExibirTelaTexto()

                Case SelectADataModeEnum.NovaExtensao

                    ExibirTelaNovaExtensao()

                Case SelectADataModeEnum.NomeDoArquivoAtual
                    ExibirTelaNomeDoArquivoAtual()

                Case SelectADataModeEnum.SequenciaNumerica

                    ExibirTelaNumeroDeSequencia()


                Case SelectADataModeEnum.LetraDaSequencia

                    ExibirTelaLetraDaSequencia()

                Case SelectADataModeEnum.DataEHora
                    ExibirTelaDataEHora()

                Case SelectADataModeEnum.Metadados
                    ExibirTelaMetadados()

                Case SelectADataModeEnum.NomeDaPasta
                    ExibirTelaNomeDaPasta()

                Case SelectADataModeEnum.SubstituicaoDeString
                    'SubstituicaoDeTextoValidateConfig()
                    ExibirTelaSubstituicaoDeString()

            End Select

        End If

    End Sub

    Sub AplicarTela()
        Me.SelectDisplayTela = Me.ComBPMaster.SelectedItem.Tag.ID

    End Sub

    Sub ApplyEventToSubItemsMenu(menu As ContextMenuStrip)

        For Each item As ToolStripMenuItem In menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf AplicarTela)

        Next

    End Sub

    Public Shadows Function Text()

        Try

        Catch ex As Exception

        End Try

        Dim _dataStr As String = ""

        If ComBPMaster.SelectedItem IsNot Nothing Then
            Dim _id As Integer = ComBPMaster.SelectedItem.Tag.ID


            Select Case _id

                Case SelectADataModeEnum.Texto
                    _dataStr = TXTPValue.TXT

                Case SelectADataModeEnum.NovaExtensao

                    Dim ext As String = TXTPValue.TXT

                    _dataStr = usesFile.ReturnExt(ext)

                Case SelectADataModeEnum.NomeDoArquivoAtual

                    Dim _value As String = ""

                    Dim _i As Integer = ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count

                    _value = usesFile.ReturnFileNameOrFolderAndOrExtension(_fileExemple, _i)
                    _dataStr = OpcoesDeFormatacaoDeTextoParaComboPerson(ComBPRight.SelectedItem.Tag.ID, _value)

                Case SelectADataModeEnum.SequenciaNumerica

                    'TODO: https://docs.microsoft.com/pt-br/dotnet/api/microsoft.visualbasic.strings.strdup?view=netcore-3.1#Microsoft_VisualBasic_Strings_StrDup_System_Int32_System_Char_

                    Dim strValue As String

                    Dim qDeRepeticao As Integer = ((ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count) + 1) '- (numberValue.ToString.Length)

                    strValue = TXTPValue.TXT

                    'FormatAlphabetLetter.funcoesDeString
                    _dataStr = FormatAlphabetLetter.StringFunctions.AddCaracterDeRepeticao(strValue, qDeRepeticao)

                Case SelectADataModeEnum.LetraDaSequencia

                    Dim strValue = TXTPValue.TXT
                    _dataStr = FormatarLetraDoAlfabeto(strValue)

                Case SelectADataModeEnum.DataEHora

                    Dim todayDate As Date = Date.Now
                    Dim _dataDate As Date

                    Dim creationTimeDate As Date = _fileExemple.CreationTime
                    Dim lastWriteDate As Date = _fileExemple.LastWriteTime

                    Dim yesterdayDate As Date = todayDate.AddDays(-1)
                    Dim tomorrowDate As Date = todayDate.AddDays(+1)

                    Dim weekDate As String = String.Format("{0:dddd}", Date.Now)


                    Select Case ComBPSlave.SelectedItem.Tag.ID
                        Case 9
                            ' Data de criacao
                            _dataDate = creationTimeDate
                        Case 10
                            ' Data de modificacao
                            _dataDate = lastWriteDate

                        Case 11
                            'Ontem
                            _dataDate = yesterdayDate

                        Case 12
                            'Hoje
                            _dataDate = todayDate

                        Case 13
                            ' Amanha
                            _dataDate = tomorrowDate

                    End Select

                    _dataStr = TrasnformDate(_dataDate)



                    'TODO : https://docs.microsoft.com/pt-br/dotnet/api/microsoft.visualbasic.strings.format?view=netcore-3.1#Microsoft_VisualBasic_Strings_Format_System_Object_System_String_

                Case SelectADataModeEnum.Metadados

                Case SelectADataModeEnum.NomeDaPasta
                    Dim index As Integer
                    Dim folder As New DirectoryInfo(_fileExemple.Directory.FullName)

                    index = ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count

                    _dataStr = OpcoesDeFormatacaoDeTextoParaComboPerson(index, folder.Name)

                Case SelectADataModeEnum.SubstituicaoDeString
                    _dataStr = TextReplace.TratarPhrase()

            End Select

        End If

        _stringData = _dataStr

        Return _dataStr

    End Function

    Function OpcoesDeFormatacaoDeTextoParaComboPerson(index As OpcoesDeFormatacaoDeTextoEnum, _value As String)

        Dim _dataStr As String = _value

        Select Case index

            Case OpcoesDeFormatacaoDeTextoEnum.ComoOOriginal
                _dataStr = _value.ToString()

            Case OpcoesDeFormatacaoDeTextoEnum.TODASMAIUSCULAS
                _dataStr = _value.ToString.ToUpper()

            Case OpcoesDeFormatacaoDeTextoEnum.todasMinusculas
                _dataStr = _value.ToString.ToLower()

            Case OpcoesDeFormatacaoDeTextoEnum.PrimeirasLetrasMaiusculas

                Dim new_value As String = funcoesDeString.ConvertTheFirstLettersToUppercase(_value, Not (CKB_FirstLetterUpper.Checked))

                If CKB_RemoveSpace.Checked = True Then
                    new_value = funcoesDeString.ReplacePhrase(new_value, " ", "")
                End If
                _dataStr = new_value

            Case OpcoesDeFormatacaoDeTextoEnum.pRIMEIRASlETRASmINUSCULAS

                Dim new_value As String = funcoesDeString.ConvertTheFirstLettersToLowercase(_value)

                _dataStr = new_value

        End Select

        Return _dataStr

    End Function

    Function TrasnformDate(_date As Date)

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

        Select Case ComBPRight.SelectedItem.Tag.ID

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
                _strDate = FormatDateText(semana)

                _strDate = SubstituirEspaco(_strDate)

            Case DateFormatEnum.HH
                _strDate = hora

            Case DateFormatEnum.HHMM
                _strDate = hora + minuto

            Case DateFormatEnum.HHMMSS
                _strDate = hora + minuto + segundo

            Case DateFormatEnum.Mes_Escrito
                _strDate = FormatDateText(mesEscrito)

                _strDate = SubstituirEspaco(_strDate)

                'Select Case ComBPFormatText.SelectedItem.Tag.ID

                '    Case OpcoesDeFormatacaoDeTextoEnum.ComoOOriginal
                '        _strDate = funcoesDeString.FirstLetterUpper(_strDate)

                '    Case OpcoesDeFormatacaoDeTextoEnum.PrimeirasLetrasMaiusculas
                '        _strDate = funcoesDeString.ConvertTheFirstLettersToUppercase(_strDate)

                '    Case OpcoesDeFormatacaoDeTextoEnum.pRIMEIRASlETRASmINUSCULAS
                '        _strDate = funcoesDeString.ConvertTheFirstLettersToLowercase(_strDate)

                '    Case OpcoesDeFormatacaoDeTextoEnum.TODASMAIUSCULAS
                '        _strDate = _strDate.ToUpper
                '    Case OpcoesDeFormatacaoDeTextoEnum.todasMinusculas
                '        _strDate = _strDate.ToLower

                '    Case OpcoesDeFormatacaoDeTextoEnum.primeiraLetraMinúnsculaDemaisPrimeriasMaiúsculas
                '        _strDate = funcoesDeString.ConvertTheFirstWordToUppercase(_strDate, False)

                'End Select

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

                _strDate = FormatDateText(_strDate)

                _strDate = SubstituirEspaco(_strDate)

                'Select Case ComBPFormatText.SelectedItem.Tag.ID

                '    Case OpcoesDeFormatacaoDeTextoEnum.ComoOOriginal
                '        _strDate = funcoesDeString.FirstLetterUpper(_strDate)

                '    Case OpcoesDeFormatacaoDeTextoEnum.PrimeirasLetrasMaiusculas
                '        _strDate = funcoesDeString.ConvertTheFirstLettersToUppercase(_strDate)

                '    Case OpcoesDeFormatacaoDeTextoEnum.pRIMEIRASlETRASmINUSCULAS
                '        _strDate = funcoesDeString.ConvertTheFirstLettersToLowercase(_strDate)

                '    Case OpcoesDeFormatacaoDeTextoEnum.TODASMAIUSCULAS
                '        _strDate = _strDate.ToUpper
                '    Case OpcoesDeFormatacaoDeTextoEnum.todasMinusculas
                '        _strDate = _strDate.ToLower

                '    Case OpcoesDeFormatacaoDeTextoEnum.primeiraLetraMinúnsculaDemaisPrimeriasMaiúsculas
                '        _strDate = funcoesDeString.ConvertTheFirstWordToUppercase(_strDate, False)

                'End Select

            Case DateFormatEnum.SS
                _strDate = segundo

        End Select

        Return _strDate

    End Function

    ' TODO : Substituir estas funções pela classe
    Function SubstituirEspaco(_strDate As String) As String
        If CHKSubstituirEspaco.Checked = True Then

            _strDate = funcoesDeString.ReplacePhrase(_strDate, " ", TXTPCaracterParaSubstituicaoDoEspaco.TXT)
            _strDate = funcoesDeString.ReplacePhrase(_strDate, ",", "")

        End If

        Return _strDate
    End Function

    Function FormatDateText(_strDate As String)
        Select Case ComBPFormatText.SelectedItem.Tag.ID

            Case OpcoesDeFormatacaoDeTextoEnum.ComoOOriginal
                _strDate = funcoesDeString.FirstLetterUpper(_strDate)

            Case OpcoesDeFormatacaoDeTextoEnum.PrimeirasLetrasMaiusculas
                _strDate = funcoesDeString.ConvertTheFirstLettersToUppercase(_strDate)

            Case OpcoesDeFormatacaoDeTextoEnum.pRIMEIRASlETRASmINUSCULAS
                _strDate = funcoesDeString.ConvertTheFirstLettersToLowercase(_strDate)

            Case OpcoesDeFormatacaoDeTextoEnum.TODASMAIUSCULAS
                _strDate = _strDate.ToUpper
            Case OpcoesDeFormatacaoDeTextoEnum.todasMinusculas
                _strDate = _strDate.ToLower

            Case OpcoesDeFormatacaoDeTextoEnum.primeiraLetraMinúnsculaDemaisPrimeriasMaiúsculas
                _strDate = funcoesDeString.ConvertTheFirstLettersToUppercase(_strDate, False)

        End Select

        Return _strDate

    End Function


    Sub TxtValue_Changed()

        If ComBPMaster.SelectedItem IsNot Nothing Then
            Dim _id As Integer = ComBPMaster.SelectedItem.Tag.ID

            Select Case _id

                Case SelectADataModeEnum.Texto
                    TXTPValue.TXT = funcoesDeString.RemoveChar(TXTPValue.TXT, "\" & "/" & "|" & ":" & "*" & "?" & """" & "<" & ">")
                    _textValue = TXTPValue.TXT

                    DataRenamingCriterion.RenameTypeData.Text = TXTPValue.TXT

                Case SelectADataModeEnum.NovaExtensao
                    TXTPValue.TXT = funcoesDeString.RemoveChar(TXTPValue.TXT, "\" & "/" & "|" & ":" & "*" & "?" & """" & "<" & ">")
                    _newExttValue = TXTPValue.TXT

                    DataRenamingCriterion.RenameTypeData.Extension = TXTPValue.TXT

                Case SelectADataModeEnum.SequenciaNumerica

                    Dim qDeRepeticao As Integer = ((ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count) + 1) '- (numberValue.ToString.Length)

                    TXTPValue.TXT = FormatAlphabetLetter.StringFunctions.AddCaracterDeRepeticao(TXTPValue.TXT, qDeRepeticao)

                    _numeroDeSequencia = CInt(TXTPValue.TXT)
                    DataRenamingCriterion.RenameTypeData.DadosDeSequenciaNumerica.NumeroDeSequencia = CInt(_numeroDeSequencia)
                    DataRenamingCriterion.RenameTypeData.DadosDeSequenciaNumerica.QuantidadeDeDigitosDaSequenciaNumerica = qDeRepeticao

                Case SelectADataModeEnum.LetraDaSequencia
                    TXTPValue.TXT = FormatarLetraDoAlfabeto(TXTPValue.TXT)
                    DataRenamingCriterion.RenameTypeData.DadosDeSequenciaDeLetras.SequenciaDeLetra = TXTPValue.TXT

                    'MsgBox("Slave")
                    _opcoesDeFormatacaoDeSequenciaDeLetras = ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count
                    DataRenamingCriterion.RenameTypeData.DadosDeSequenciaDeLetras.OpcoesDeFormatacaoDeSequenciaDeLetras = _opcoesDeFormatacaoDeSequenciaDeLetras



            End Select
            TXTPValue.ErrorDisplay = TXTPValue.Validar(TXTPValue.TXT)
        End If

    End Sub

    Sub TXTPSubstituirEspaco_Changed()
        TXTPCaracterParaSubstituicaoDoEspaco.TXT = funcoesDeString.RemoveChar(TXTPCaracterParaSubstituicaoDoEspaco.TXT, "\" & "/" & "|" & ":" & "*" & "?" & """" & "<" & ">")
        TXTPCaracterParaSubstituicaoDoEspaco.ErrorDisplay = TXTPCaracterParaSubstituicaoDoEspaco.Validar(TXTPCaracterParaSubstituicaoDoEspaco.TXT)

        _caracterParaSubstituicaoDoEspaco = CChar(TXTPCaracterParaSubstituicaoDoEspaco.TXT)
        DataRenamingCriterion.RenameTypeData.DadosDeTempo.CaracterParaSubstituicaoDoEspaco = _caracterParaSubstituicaoDoEspaco

    End Sub

    '' TODO :  Remover esta função e substituir pela funcao em StringFunctions
    'Function FormatarNumberToQCaracter(value As String) As String
    '    Dim _dataStr As String
    '    Dim cadeia As String = "0"

    '    Dim _value As String = funcoesDeString.ReplacePhrase(value, " ", "")

    '    Dim numberValue As Integer
    '    Dim qDeRepeticao As Integer

    '    If Trim(_value) <> "" Then
    '        If IsNumeric(_value) = True Then
    '            numberValue = CUInt(_value)

    '        Else
    '            ' MsgBox("Este campo só pode conter números.")
    '        End If
    '    Else
    '        numberValue = 0

    '    End If

    '    qDeRepeticao = ((ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count) + 1) - (numberValue.ToString.Length)

    '    If qDeRepeticao < 0 Then qDeRepeticao = 0

    '    _dataStr = StrDup(qDeRepeticao, cadeia) & numberValue.ToString

    '    Return _dataStr

    '    'InStr()
    '    ' TODO : http://www.macoratti.net/valida.htm
    'End Function

    ' TODO : Remover esta função e substituir por Classe Class_FormatAlphabetLetter
    ' ----------------------------------------------------------------------------
    Function FormatarLetraDoAlfabeto(value As String) As String
        Dim _dataStr As String = Trim(value)

        If Trim(_dataStr) = "" Then
            _dataStr = ChrW(65).ToString

        Else
            _dataStr = funcoesDeString.ReplacePhrase(_dataStr, " ", "")
        End If

        If funcoesDeString.TodosOsCaracteresSaoTexto(_dataStr) = False Then
            ' MsgBox(funcoesDeString.IsWord("a"c))
            _dataStr = FormatAlphabetLetter.SubstituirNumeroPorLetra(_dataStr)
            'Dim FormatAlphabetLetter As New Class_FormatAlphabetLetter

        End If

        Select Case ComBPSlave.SelectedItem.Tag.ID

            Case 9
                _dataStr = _dataStr.ToUpper

            Case 10
                _dataStr = _dataStr.ToLower

        End Select

        Return _dataStr

    End Function
    ' ----------------------------------------------------------------------------

    ' Codigos de validação 
    ' _________________________________________________

    Sub TextValidateConfig()
        ' Nao pode ter caracteres que pastas não suportam
        TXTPValue.ActiveValidate = True
        TXTPValue.ByChar = True
        TXTPValue.NoneOfThisChar = "\" & "/" & "|" & ":" & "*" & "?" & """" & "<" & ">"

        TXTPValue.ByText = False
        TXTPValue.ByValue = False
        TXTPValue.OnlyNumber = False
        TXTPValue.OnlyCaracterText = False

        TXTPValue.SpaceError = False

    End Sub

    Sub ExtensionValidateConfig()
        ' Nao pode ter caracteres que pastas não suportam
        TextValidateConfig()

    End Sub

    Sub NumeroDaSequenciaValidateConfig()
        ' Nao pode ter caracteres que pastas não suportam
        'So pode ter numero
        'Não pode ter Espaco
        'Não pode ter Letras
        TXTPValue.ActiveValidate = True
        TXTPValue.ByChar = False

        TXTPValue.ByText = False
        TXTPValue.ByValue = False
        TXTPValue.OnlyNumber = True
        TXTPValue.SpaceError = True
    End Sub

    Sub LetraDaSequenciaValidateConfig()
        ' Só pode ter letras
        ' não pode ter caracteres especiais
        ' Não pode ter numeros
        TXTPValue.ActiveValidate = True
        TXTPValue.ByChar = False

        TXTPValue.ByText = False
        TXTPValue.ByValue = False
        TXTPValue.SpaceError = True
        TXTPValue.OnlyCaracterText = True

    End Sub

    'Sub SubstituicaoDeTextoValidateConfig()
    '    'Não pode ter caracteres não aceitos pela pasta
    'End Sub

    ' _________________________________________________

    Sub AddHandler_TxtValue_Changed_inClick()
        For Each item As ToolStripMenuItem In ComBPSlave.CMS_Menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf TxtValue_Changed)

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim _dataStr As String = Text()
        MsgBox(_textValue)
        MsgBox(_newExttValue)

    End Sub

    Private Sub CHKSubstituirEspaco_CheckedChanged(sender As Object, e As EventArgs) Handles CHKSubstituirEspaco.CheckedChanged

        TXTPCaracterParaSubstituicaoDoEspaco.Enabled = CHKSubstituirEspaco.Checked

        If CHKSubstituirEspaco.Checked = False Then
            TXTPCaracterParaSubstituicaoDoEspaco.TXT = ""
        Else
            TXTPCaracterParaSubstituicaoDoEspaco.Focus()
        End If

        _substituirEspacoDaData = CHKSubstituirEspaco.Checked


        DataRenamingCriterion.RenameTypeData.DadosDeTempo.SubstituirEspaco = _substituirEspacoDaData

        _caracterParaSubstituicaoDoEspaco = CChar(TXTPCaracterParaSubstituicaoDoEspaco.TXT)

        DataRenamingCriterion.RenameTypeData.DadosDeTempo.CaracterParaSubstituicaoDoEspaco = _caracterParaSubstituicaoDoEspaco

        '  DataRenameOption.RenameTypeData.DadosDeSequenciaNumerica.NumeroDeSequencia

    End Sub

    Private Sub CKB_FirstLetterUpper_CheckedChanged(sender As Object, e As EventArgs) Handles CKB_FirstLetterUpper.CheckedChanged

        Dim _id As Integer = ComBPMaster.SelectedItem.Tag.ID

        Select Case _id
            Case SelectADataModeEnum.NomeDoArquivoAtual

                _primeiraLetraMinusculaDeNomeDeArquivo = CKB_FirstLetterUpper.Checked

                DataRenamingCriterion.RenameTypeData.DadosDeNomeDeArquivoAtual.PrimeiraLetraMinusculaDeNomeDeArquivo = _primeiraLetraMinusculaDeNomeDeArquivo

            Case SelectADataModeEnum.NomeDaPasta

                _primeiraLetraMinusculaDeNomeDaPasta = CKB_FirstLetterUpper.Checked
                DataRenamingCriterion.RenameTypeData.DadosDeNomeDaPasta.PrimeiraLetraMinusculaDeNomeDaPasta = _primeiraLetraMinusculaDeNomeDaPasta

        End Select

    End Sub

    Private Sub CKB_RemoveSpace_CheckedChanged(sender As Object, e As EventArgs) Handles CKB_RemoveSpace.CheckedChanged
        Dim _id As Integer = ComBPMaster.SelectedItem.Tag.ID

        Select Case _id
            Case SelectADataModeEnum.NomeDoArquivoAtual

                _removerEspacoDeNomeDeArquivo = CKB_RemoveSpace.Checked

                DataRenamingCriterion.RenameTypeData.DadosDeNomeDeArquivoAtual.RemoverEspacoDeNomeDeArquivo = _removerEspacoDeNomeDeArquivo

            Case SelectADataModeEnum.NomeDaPasta

                _removerEspacoDeNomeDaPasta = CKB_RemoveSpace.Checked
                DataRenamingCriterion.RenameTypeData.DadosDeNomeDaPasta.RemoverEspacoDeNomeDaPasta = _removerEspacoDeNomeDaPasta


        End Select
    End Sub
End Class
