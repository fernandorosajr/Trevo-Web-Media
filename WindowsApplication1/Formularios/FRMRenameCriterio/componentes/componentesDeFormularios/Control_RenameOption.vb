'Imports System.Security.Cryptography.X509Certificates

Imports System.IO
Imports System.Reflection


Public Class Control_RenameOption

    'Importação de Classes
    '--------------------------------------------------
    ReadOnly funcoesDeString As New StringFunctionsClass
    Private configs As Class_Configs
    Private usesFile As New UsesFilesClass
    ' -------------------------------------------------

    ' Propriedades do Formulário
    ' _____________________________________________
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

        End Set
    End Property

    ' _____________________________________________

    Private Alfabeto As New List(Of Char)

    Public OpcoreDeFormatacaoDeTexto As OpcoesDeFormatacaoDeTextoEnum
    Public Enum OpcoesDeFormatacaoDeTextoEnum

        ComoOOriginal = 0
        TODASMAIUSCULAS = 1
        todasMinusculas = 2
        PrimeirasLetrasMaiusculas = 3
        pRIMEIRASlETRASmINUSCULAS = 4

    End Enum


    Public Enum SelectADataModeEnum

        Texto = 0
        NovaExtensao = 1
        NomeDoArquivoAtual = 2
        NumeroDeSequencia = 3
        LetraDaSequencia = 4
        DataEHora = 5
        Metadados = 6
        NomeDaPasta = 7
        SubstituicaoDeString = 8

    End Enum

    Public _DateFormat As DateFormatEnum
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

    Private _selectADataModeEnum As SelectADataModeEnum
    Public Property SelectDisplayTela As SelectADataModeEnum
        Get
            Return _selectADataModeEnum

        End Get
        Set(value As SelectADataModeEnum)
            _selectADataModeEnum = value
            DisplayScreenOfADataMode()

        End Set
    End Property

    Public LoadRenameOptionsParent As Control_LoadRenameOption

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


    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        _id = 0

        ActiveDelete = False

    End Sub

    Sub ExibirTelaTexto()

        TextValidateConfig()

        Panel_Right.Visible = False
        PanelEnvolve_RightTXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelBase.Visible = False
        PanelSubstituir.Visible = True

        TXTPValue.TXT = ""
        TXTPValue.Validar(TXTPValue.TXT)

        PanelEnvolve_ComBPSlave.Controls.Add(TXTPValue)
        PanelEnvolve_RightTXT.Controls.Add(ComBPSlave)

        TXTPValue.Placeholder = "Digite um Texto..."

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill





    End Sub

    Sub ExibirNovaExtensao()
        ExtensionValidateConfig()

        Panel_Right.Visible = False
        PanelEnvolve_RightTXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelBase.Visible = False
        PanelSubstituir.Visible = True

        TXTPValue.TXT = ""
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

        ComBPMaster.PerformAutomaticSelection(2)

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        Panel_Right.Controls.Add(TXTPValue)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)
        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        '

        ' Adicionar Nova lista
        ' _____-----------------------------------------------------_____

        Dim listItem As New Collections.Specialized.StringCollection

        listItem.AddRange({" Como o Original", " TODAS MAIÚSCULAS", " todas minúsculas", "Primeiras Letras Maiúsculas", "pRIMEIRAS lETRAS mINÚSCULAS"})

        ComBRight.OptionsList = listItem
        ComBRight.PerformAutomaticSelection(0)

        ' _____-----------------------------------------------------_____


        For Each item As ToolStripMenuItem In ComBRight.CMS_Menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf ExibirSubTelaPrimeiraMaiuscDeNomeDoArquivoAtual)

        Next

    End Sub

    Sub ExibirSubTelaPrimeiraMaiuscDeNomeDoArquivoAtual()
        If ComBRight.SelectedItem.Tag.ID = 3 Then

            ExibirSubTelaPrimeiraMinuscula()

        Else

            OcultarSubTelaPrimeiraMinuscula()

        End If
    End Sub

    Sub ExibirSubTelaPrimeiraMinuscula()

        TableLPContainer.Dock = DockStyle.Top
        TableLPContainer.Height = 28
        Me.Height = 86
        PanelBase.Visible = True
        PanelSubstituir.Visible = False
        PanelNomeDoArquivoAtualConfig.Visible = True

    End Sub

    Sub OcultarSubTelaPrimeiraMinuscula()

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill
        PanelBase.Visible = False

        PanelSubstituir.Visible = True
        PanelNomeDoArquivoAtualConfig.Visible = True

    End Sub

    Sub ExibirTelaNumeroDeSequencia()

        NumeroDaSequenciaValidateConfig()

        Panel_Right.Visible = True
        PanelEnvolve_RightTXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = False
        PanelBase.Visible = False
        PanelSubstituir.Visible = True

        TXTPValue.Placeholder = "Digite um número para a sequência ..."

        TXTPValue.TXT = "0"
        TXTPValue.Validar(TXTPValue.TXT)

        PanelEnvolve_ComBPSlave.Controls.Add(TXTPValue)
        PanelEnvolve_RightTXT.Controls.Add(ComBPSlave)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)

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

        TXTPValue.Placeholder = "Digite letra do Alfabeto..."
        TXTPValue.TXT = ChrW(65).ToString
        TXTPValue.Validar(TXTPValue.TXT)


        ComBPMaster.PerformAutomaticSelection(4)

        PanelEnvolve_ComBPSlave.Controls.Add(TXTPValue)
        PanelEnvolve_RightTXT.Controls.Add(ComBPSlave)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)

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


        ComBPMaster.PerformAutomaticSelection(5)

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        PanelEnvolve_RightTXT.Controls.Add(TXTPValue)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        ' Adicionar Nova lista
        ' _____-----------------------------------------------------_____

        Dim listItem As New Collections.Specialized.StringCollection

        listItem.AddRange({"DDMMAAAA", "DDMMAA", "MMDDAAAA", "MMDDAA", "AAAAMMDD", "AAMMDD", "AAAA", "DD", "MM", "AA", "HHMMSS", "HHMM", "HH", "MIN", "SS", "Semana, Dia de Mês de Ano", "Mês (escrito)", "Dia da Semana"})

        ComBRight.OptionsList = listItem
        ComBRight.PerformAutomaticSelection(0)

        ' _____-----------------------------------------------------_____

    End Sub

    Sub ExibirTelaMetadados()

        Panel_Right.Visible = False
        PanelEnvolve_RightTXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelBase.Visible = False
        PanelSubstituir.Visible = True

        PanelEnvolve_ComBPSlave.Controls.Add(ComBRight)
        PanelEnvolve_RightTXT.Controls.Add(ComBPSlave)
        PanelEnvolve_ComBRight.Controls.Add(TXTPValue)


        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        ' Adicionar Nova lista
        ' _____-----------------------------------------------------_____

        Dim listItem As New Collections.Specialized.StringCollection

        listItem.AddRange({"Título"})

        ComBRight.OptionsList = listItem
        ComBRight.PerformAutomaticSelection(0)

        ' _____-----------------------------------------------------_____
    End Sub


    Sub ExibirTelaNomeDaPasta()

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        PanelEnvolve_RightTXT.Controls.Add(TXTPValue)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)


        Panel_Right.Visible = False
        PanelEnvolve_RightTXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelBase.Visible = False
        PanelSubstituir.Visible = True

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        For Each item As ToolStripMenuItem In ComBPSlave.CMS_Menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf ExibirSubTelaPrimeiraMaiuscDeNomeDaPasta)

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
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)


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
                ' item.TXTPerson.TXT = "Saluton" + item.ID.ToString

            End If
        Next

    End Sub

    Sub RemoverIndice(index As Integer)

        For Each item As Control_RenameOption In Me.Parent.Controls
            If item.ID > index Then
                item.ID -= 1
                ' item.TXTPerson.TXT = "Saluton" + item.ID.ToString

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
        ' renameOption.TXTPerson.TXT = "Saluton" + renameOption.ID.ToString
        renameOption.Visible = True

        OrdenarRenameOption()

    End Sub

    Sub GravarStringData()

    End Sub

    Private Sub Control_RenameOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TXTPerson.TXT = ID

        If Me.Parent.Parent.Parent.Parent IsNot Nothing Then
            If TypeOf (Me.Parent.Parent.Parent.Parent) Is Control_LoadRenameOption Then
                LoadRenameOptionsParent = Me.Parent.Parent.Parent.Parent

            End If
        End If

        ApplyEventToSubItemsMenu(ComBPMaster.CMS_Menu)

        'TextValidateConfig()
        ExibirTelaTexto()

        FileExemple = "C:\Pasta Teste\Meu ArquivO arQUiVado.txt"

        AddHandler TXTPValue.TXTBox.LostFocus, New System.EventHandler(AddressOf TxtValue_Changed)

        Dim s As New System.Text.StringBuilder()

        For Each item As ToolStripMenuItem In ComBPMaster.CMS_Menu.Items
            If item.Text = "Metadados" Then item.Visible = False
        Next

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

                    ExibirNovaExtensao()

                Case SelectADataModeEnum.NomeDoArquivoAtual
                    ExibirTelaNomeDoArquivoAtual()

                Case SelectADataModeEnum.NumeroDeSequencia

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
                    SubstituicaoDeTextoValidateConfig()
                    ExibirTelaSubstituicaoDeString()

            End Select

        End If

    End Sub

    Sub AplicarAcaoDeTela()
        Me.SelectDisplayTela = Me.ComBPMaster.SelectedItem.Tag.ID

    End Sub

    Sub ApplyEventToSubItemsMenu(menu As ContextMenuStrip)

        For Each item As ToolStripMenuItem In menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf AplicarAcaoDeTela)

        Next

    End Sub

    Public Function ReturnStringData()

        Dim _dataStr As String = ""

        If ComBPMaster.SelectedItem IsNot Nothing Then
            Dim _id As Integer = ComBPMaster.SelectedItem.Tag.ID


            Select Case _id

                Case SelectADataModeEnum.Texto
                    _dataStr = TXTPValue.TXT

                Case SelectADataModeEnum.NovaExtensao

                    Dim ext As String = TXTPValue.TXT
                    'MsgBox(ext.First)
                    If ext.Length > 0 Then
                        If ext.First <> "." Then
                            _dataStr = "." & ext
                        Else
                            _dataStr = ext
                        End If

                    Else
                        _dataStr = "."
                    End If


                Case SelectADataModeEnum.NomeDoArquivoAtual

                    Dim _value As String = ""

                    Select Case ComBPSlave.SelectedItem.Tag.ID

                        Case 9
                            _value = _fileExemple.Name

                        Case 10
                            _value = usesFile.FileNameWithoutExtension(_fileExemple)

                        Case 11
                            _value = _fileExemple.Extension

                    End Select

                    _dataStr = OpcoesDeFormatacaoDeTextoParaComboPerson(ComBRight.SelectedItem.Tag.ID, _value)



                Case SelectADataModeEnum.NumeroDeSequencia

                    Dim strValue As String
                    'TODO: https://docs.microsoft.com/pt-br/dotnet/api/microsoft.visualbasic.strings.strdup?view=netcore-3.1#Microsoft_VisualBasic_Strings_StrDup_System_Int32_System_Char_

                    strValue = TXTPValue.TXT
                    _dataStr = FormatarNumberToQCaracter(strValue)

                Case SelectADataModeEnum.LetraDaSequencia

                    Dim strValue = TXTPValue.TXT
                    _dataStr = FormatarLetraDoAlfabeto(strValue)

                Case SelectADataModeEnum.DataEHora

                    Dim today As Date = Date.Now
                    Dim _dataDete As Date

                    Dim dateCreation As Date = _fileExemple.CreationTime
                    Dim dateLastWrite As Date = _fileExemple.LastWriteTime
                    Dim ontem As Date = today.AddDays(-1)
                    Dim amanha As Date = today.AddDays(+1)

                    Dim semana As String = String.Format("{0:dddd}", Date.Now)


                    Select Case ComBPSlave.SelectedItem.Tag.ID
                        Case 9
                            ' Data de criacao
                            _dataDete = dateCreation
                        Case 10
                            ' Data de modificacao
                            _dataDete = dateLastWrite

                        Case 11
                            'Ontem
                            _dataDete = ontem

                        Case 12
                            'Hoje
                            _dataDete = today

                        Case 13
                            ' Amanha
                            _dataDete = amanha

                    End Select

                    _dataStr = TrasnformDate(_dataDete)

                    'Obtem data e hora atual do sistema
                    'MsgBox(Date.Now)

                    ''Obtendo dia da semana

                    'MsgBox(String.Format("{0:dddd}", Now))


                    'MsgBox(Format(Date.Now, "Dddd, d de mm de aaaa"))
                    ''Soma 20 dias a data atual

                    'MsgBox(Date.Now.AddDays(20))

                    ''Subtrai 15 dias da data atual

                    'MsgBox(Date.Now.AddDays(-15))

                    ''Exibe uma mensagem informando se o ano é bissexto

                    'If Date.IsLeapYear(2007) = True Then

                    '    MsgBox("Ano Bissexto")

                    'Else

                    '    MsgBox("Ano Não Bissexto")

                    'End If

                    ''Exibe o número de dias do mês para  o ano de 2007 e mes 2

                    'MsgBox("O numero de dias do mês é: " & Date.DaysInMonth(2007, 2))



                    'TODO : https://docs.microsoft.com/pt-br/dotnet/api/microsoft.visualbasic.strings.format?view=netcore-3.1#Microsoft_VisualBasic_Strings_Format_System_Object_System_String_

                Case SelectADataModeEnum.Metadados

                Case SelectADataModeEnum.NomeDaPasta
                    Dim index As Integer
                    Dim folder As New DirectoryInfo(_fileExemple.Directory.FullName)

                    index = ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count

                    _dataStr = OpcoesDeFormatacaoDeTextoParaComboPerson(index, folder.Name)

                Case SelectADataModeEnum.SubstituicaoDeString

            End Select

            'TXTPValue.Validar(TXTPValue.TXT)
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

                '  Dim fileName As String = _value

                Dim new_value As String = funcoesDeString.ConvertTheFirstWordToUppercase(_value, Not (CKB_FirstLetterUpper.Checked))

                If CKB_RemoveSpace.Checked = True Then
                    new_value = funcoesDeString.ReplacePhrase(new_value, " ", "")
                End If
                _dataStr = new_value

            Case OpcoesDeFormatacaoDeTextoEnum.pRIMEIRASlETRASmINUSCULAS
                ' Dim fileName As String = _value

                Dim new_value As String = funcoesDeString.ConvertTheFirstLettersToLowercase(_value)

                _dataStr = new_value

        End Select

        Return _dataStr

    End Function

    Function TrasnformDate(_date As Date)

        Dim _strDate As String = _date.ToLongDateString

        Dim ano As String = _date.Year.ToString
        Dim mes As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Month, 2) '_date.Month.ToString
        Dim dia As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Day, 2) '_date.Day.ToString

        Dim semana As String = _date.DayOfWeek.ToString

        Dim hora As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Hour, 2)

        Dim minuto As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Minute, 2)   '_date.Minute.ToString
        Dim segundo As String = funcoesDeString.RetornaStringComNumeroCaracter(_date.Second, 2) '_date.Second.ToString

        'MsgBox(ano.Substring(2, 2))

        Select Case ComBRight.SelectedItem.Tag.ID

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
                _strDate = semana

            Case DateFormatEnum.HH
                _strDate = hora

            Case DateFormatEnum.HHMM
                _strDate = hora + minuto

            Case DateFormatEnum.HHMMSS
                _strDate = hora + minuto + segundo

            Case DateFormatEnum.Mes_Escrito
                _strDate = mes

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

            Case DateFormatEnum.SS
                _strDate = segundo

        End Select

        Return _strDate

    End Function

    Sub TxtValue_Changed()
        If ComBPMaster.SelectedItem IsNot Nothing Then
            Dim _id As Integer = ComBPMaster.SelectedItem.Tag.ID

            Select Case _id

                Case SelectADataModeEnum.Texto
                    TXTPValue.TXT = funcoesDeString.RemoveChar(TXTPValue.TXT, "\" & "/" & "|" & ":" & "*" & "?" & """" & "<" & ">")

                Case SelectADataModeEnum.NovaExtensao
                    TXTPValue.TXT = funcoesDeString.RemoveChar(TXTPValue.TXT, "\" & "/" & "|" & ":" & "*" & "?" & """" & "<" & ">")


                Case SelectADataModeEnum.NumeroDeSequencia

                    TXTPValue.TXT = FormatarNumberToQCaracter(TXTPValue.TXT)


                Case SelectADataModeEnum.LetraDaSequencia
                    TXTPValue.TXT = FormatarLetraDoAlfabeto(TXTPValue.TXT)

            End Select
            TXTPValue.ErrorDisplay = TXTPValue.Validar(TXTPValue.TXT)
        End If

    End Sub

    Function FormatarNumberToQCaracter(value As String) As String
        Dim _dataStr As String
        Dim cadeia As String = "0"

        Dim _value As String = funcoesDeString.ReplacePhrase(value, " ", "")

        Dim numberValue As Integer
        Dim qDeRepeticao As Integer

        If Trim(_value) <> "" Then
            If IsNumeric(_value) = True Then
                numberValue = CUInt(_value)

            Else
                MsgBox("Este campo só pode conter números.")
            End If
        Else
            numberValue = 0

        End If

        qDeRepeticao = ((ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count) + 1) - (numberValue.ToString.Length)

        If qDeRepeticao < 0 Then qDeRepeticao = 0

        _dataStr = StrDup(qDeRepeticao, cadeia) & numberValue.ToString

        Return _dataStr

        'InStr()
        ' TODO : http://www.macoratti.net/valida.htm
    End Function



    Function FormatarLetraDoAlfabeto(value As String) As String
        Dim _dataStr As String = Trim(value)

        If Trim(_dataStr) = "" Then
            _dataStr = ChrW(65).ToString

        Else
            _dataStr = funcoesDeString.ReplacePhrase(_dataStr, " ", "")
        End If

        If funcoesDeString.TodosOsCaracteresSaoTexto(_dataStr) = False Then
            ' MsgBox(funcoesDeString.IsWord("a"c))
            _dataStr = funcoesDeString.SubstituirNumeroPorLetra(_dataStr)
        End If

        Select Case ComBPSlave.SelectedItem.Tag.ID

            Case 9
                _dataStr = _dataStr.ToUpper

            Case 10
                _dataStr = _dataStr.ToLower

        End Select

        Return _dataStr

    End Function

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
        'TXTPValue.NoneOfThisChar = "|"

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

    Sub SubstituicaoDeTextoValidateConfig()
        'Não pode ter caracteres não aceitos pela pasta
    End Sub

    ' _________________________________________________

    Sub AddHandler_TxtValue_Changed_inClick()
        For Each item As ToolStripMenuItem In ComBPSlave.CMS_Menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf TxtValue_Changed)

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim _dataStr As String = ReturnStringData()
        MsgBox(_dataStr)

    End Sub
End Class
