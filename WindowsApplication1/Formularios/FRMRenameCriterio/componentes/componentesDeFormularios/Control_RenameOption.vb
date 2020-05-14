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

    ' Propriedades dos Formulário
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

        Panel_Right.Visible = False
        PanelEnvolve_TXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelBase.Visible = False
        PanelSubstituir.Visible = True
        TXTPValue.TXT = ""

        PanelEnvolve_ComBPSlave.Controls.Add(TXTPValue)
        PanelEnvolve_TXT.Controls.Add(ComBPSlave)

        TXTPValue.Placeholder = "Digite um Texto...."

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill



    End Sub

    Sub ExibirNovaExtensao()

        Panel_Right.Visible = False
        PanelEnvolve_TXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelBase.Visible = False
        PanelSubstituir.Visible = True
        TXTPValue.TXT = ""

        TXTPValue.Placeholder = "Digite uma extensão..."

        PanelEnvolve_ComBPSlave.Controls.Add(TXTPValue)
        PanelEnvolve_TXT.Controls.Add(ComBPSlave)
        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

    End Sub

    Sub ExibirTelaNomeDoArquivoAtual()

        Panel_Right.Visible = True
        PanelEnvolve_TXT.Visible = False
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

            TableLPContainer.Dock = DockStyle.Top
            TableLPContainer.Height = 28
            Me.Height = 86
            PanelBase.Visible = True
            PanelSubstituir.Visible = False
            PanelNomeDoArquivoAtualConfig.Visible = True

        Else

            Me.Height = 54
            TableLPContainer.Dock = DockStyle.Fill
            PanelBase.Visible = False

            PanelSubstituir.Visible = True
            PanelNomeDoArquivoAtualConfig.Visible = True

        End If
    End Sub

    Sub ExibirTelaNumeroDeSequencia()

        Panel_Right.Visible = True
        PanelEnvolve_TXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = False
        PanelBase.Visible = False
        PanelSubstituir.Visible = True

        TXTPValue.Placeholder = "Digite um número para a sequência ..."
        TXTPValue.TXT = "0"

        PanelEnvolve_ComBPSlave.Controls.Add(TXTPValue)
        PanelEnvolve_TXT.Controls.Add(ComBPSlave)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        For Each item As ToolStripMenuItem In ComBPSlave.CMS_Menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf TxtValue_Changed)

        Next

    End Sub


    Sub ExibirTelaLetraDaSequencia()

        Panel_Right.Visible = False
        PanelEnvolve_TXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelBase.Visible = False
        PanelSubstituir.Visible = True

        ComBPMaster.PerformAutomaticSelection(4)

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        PanelEnvolve_TXT.Controls.Add(TXTPValue)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill



    End Sub


    Sub ExibirTelaDataEHora()


        Panel_Right.Visible = True
        PanelEnvolve_TXT.Visible = False
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelBase.Visible = False
        PanelSubstituir.Visible = True


        ComBPMaster.PerformAutomaticSelection(5)

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        PanelEnvolve_TXT.Controls.Add(TXTPValue)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        ' Adicionar Nova lista
        ' _____-----------------------------------------------------_____

        Dim listItem As New Collections.Specialized.StringCollection

        listItem.AddRange({"DDMMAAAA", "DDMMAA", "MMDDAAAA", "MMDDAA", "AAAAMMDD", "AAMMDD", "AAAA", "DD", "MM", "AA", "HHMMSS", "HHMM", "HH", "MM", "SS", "Semana, Dia de Mês de Ano", "Mês (escrito)", "Dia da Semana"})

        ComBRight.OptionsList = listItem
        ComBRight.PerformAutomaticSelection(0)

        ' _____-----------------------------------------------------_____

    End Sub

    Sub ExibirTelaMetadados()

        Panel_Right.Visible = False
        PanelEnvolve_TXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelBase.Visible = False
        PanelSubstituir.Visible = True

        PanelEnvolve_ComBPSlave.Controls.Add(ComBRight)
        PanelEnvolve_TXT.Controls.Add(ComBPSlave)
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
        PanelEnvolve_TXT.Controls.Add(TXTPValue)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)


        Panel_Right.Visible = False
        PanelEnvolve_TXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelBase.Visible = False
        PanelSubstituir.Visible = True

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        '    ComBPMaster.PerformAutomaticSelection(7)

    End Sub

    Sub ExibirTelaSubstituicaoDeString()

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        PanelEnvolve_TXT.Controls.Add(TXTPValue)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)


        Panel_Right.Visible = False
        PanelEnvolve_TXT.Visible = True
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
        ExibirTelaTexto()
        FileExemple = "C:\Pasta Teste\Meu ArquivO arQUiVado.txt"

        AddHandler TXTPValue.TXTBox.LostFocus, New System.EventHandler(AddressOf TxtValue_Changed)


    End Sub

    Private Sub Control_RenameOption_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

    End Sub

    Public Sub DisplayScreenOfADataMode()

        If ComBPMaster.SelectedItem IsNot Nothing Then
            Dim _id As Integer = ComBPMaster.SelectedItem.Tag.ID

            Select Case _id

                Case SelectADataModeEnum.Texto
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

                    '_fileExemple


                    Select Case ComBRight.SelectedItem.Tag.ID
                        Case 0

                            _dataStr = _value.ToString()

                        Case 1
                            _dataStr = _value.ToString.ToUpper()

                        Case 2
                            _dataStr = _value.ToString.ToLower()

                        Case 3

                            Dim fileName As String = _value

                            Dim newFileName As String = funcoesDeString.ConvertTheFirstWordToUppercase(fileName, Not (CKB_FirstLetterUpper.Checked))

                            If CKB_RemoveSpace.Checked = True Then
                                newFileName = funcoesDeString.ReplacePhrase(newFileName, " ", "")
                            End If
                            _dataStr = newFileName

                        Case 4
                            Dim fileName As String = _value

                            Dim newFileName As String = funcoesDeString.ConvertTheFirstLettersToLowercase(fileName)

                            _dataStr = newFileName

                    End Select

                Case SelectADataModeEnum.NumeroDeSequencia

                    ' TODO: Substituir por funcao
                    '-------------------------------------------------
                    'Dim numberValue As Integer
                    Dim strValue As String
                    'Dim cadeia As String = "0"
                    'Dim qDeRepeticao As Integer

                    'TODO: https://docs.microsoft.com/pt-br/dotnet/api/microsoft.visualbasic.strings.strdup?view=netcore-3.1#Microsoft_VisualBasic_Strings_StrDup_System_Int32_System_Char_
                    strValue = TXTPValue.TXT

                    'numberValue = CUInt(TXTPValue.TXT)

                    'qDeRepeticao = ((ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count) + 1) - (numberValue.ToString.Length)

                    'If qDeRepeticao < 0 Then qDeRepeticao = 0
                    ''-------------------------------------------------

                    _dataStr = FormatarNumberToQCaracter(strValue)

                  '  _dataStr = StrDup(qDeRepeticao, cadeia) & numberValue.ToString

                  '  MsgBox(ComBPSlave.SelectedItem.Tag.ID)



                Case SelectADataModeEnum.LetraDaSequencia

                Case SelectADataModeEnum.DataEHora

                    'TODO : https://docs.microsoft.com/pt-br/dotnet/api/microsoft.visualbasic.strings.format?view=netcore-3.1#Microsoft_VisualBasic_Strings_Format_System_Object_System_String_

                Case SelectADataModeEnum.Metadados

                Case SelectADataModeEnum.NomeDaPasta

                Case SelectADataModeEnum.SubstituicaoDeString

            End Select
        End If

        _stringData = _dataStr

        Return _dataStr

    End Function
    Sub TxtValue_Changed()
        If ComBPMaster.SelectedItem IsNot Nothing Then
            Dim _id As Integer = ComBPMaster.SelectedItem.Tag.ID

            Select Case _id
                Case SelectADataModeEnum.NumeroDeSequencia

                    TXTPValue.TXT = FormatarNumberToQCaracter(TXTPValue.TXT)

            End Select
        End If

    End Sub

    Function FormatarNumberToQCaracter(value As String)
        Dim _dataStr As String
        Dim strValue As String

        Dim cadeia As String = "0"

        Dim numberValue As Integer
        Dim qDeRepeticao As Integer


        strValue = value

        numberValue = CUInt(value)

        qDeRepeticao = ((ComBPSlave.SelectedItem.Tag.ID - ComBPMaster.OptionsList.Count) + 1) - (numberValue.ToString.Length)

        If qDeRepeticao < 0 Then qDeRepeticao = 0

        _dataStr = StrDup(qDeRepeticao, cadeia) & numberValue.ToString

        Return _dataStr

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim _dataStr As String = ReturnStringData()
        MsgBox(_dataStr)

    End Sub
End Class
