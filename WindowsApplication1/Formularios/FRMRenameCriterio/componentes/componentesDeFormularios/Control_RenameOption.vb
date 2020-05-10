'Imports System.Security.Cryptography.X509Certificates

Imports System.Reflection

Public Class Control_RenameOption

    Public Enum DisplayTelaEnum

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

    Private _selectDisplayTela As DisplayTelaEnum
    Public Property SelectDisplayTela As DisplayTelaEnum
        Get
            Return _selectDisplayTela

        End Get
        Set(value As DisplayTelaEnum)
            _selectDisplayTela = value
            DisplayInterface()

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

    Private _returnStringData As Object
    Public Property ReturnStringData As String
        Get
            Return _returnStringData

        End Get
        Set(value As String)
            _returnStringData = value

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
        PanelSubstituir.Visible = False

        PanelEnvolve_ComBPSlave.Controls.Add(TXTPerson)
        PanelEnvolve_TXT.Controls.Add(ComBPSlave)

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

    End Sub

    Sub ExibirNovaExtensao()

        Panel_Right.Visible = False
        PanelEnvolve_TXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelSubstituir.Visible = False


        PanelEnvolve_ComBPSlave.Controls.Add(TXTPerson)
        PanelEnvolve_TXT.Controls.Add(ComBPSlave)
        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

    End Sub

    Sub ExibirTelaNomeDoArquivoAtual()

        Panel_Right.Visible = True
        PanelEnvolve_TXT.Visible = False
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelSubstituir.Visible = False


        ComBPMaster.PerformAutomaticSelection(2)

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        Panel_Right.Controls.Add(TXTPerson)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)
        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

        '

        ' Adicionar Nova lista
        ' _____-----------------------------------------------------_____

        Dim listItem As New Collections.Specialized.StringCollection

        listItem.AddRange({" Como o Original", " MAIÚSCULAS", " minúsculas"})

        ComBRight.OptionsList = listItem
        ComBRight.PerformAutomaticSelection(0)

        ' _____-----------------------------------------------------_____


    End Sub

    Sub ExibirTelaNumeroDeSequencia()

        Panel_Right.Visible = True
        PanelEnvolve_TXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = False
        PanelSubstituir.Visible = False

        PanelEnvolve_ComBPSlave.Controls.Add(TXTPerson)
        PanelEnvolve_TXT.Controls.Add(ComBPSlave)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

    End Sub


    Sub ExibirTelaLetraDaSequencia()

        Panel_Right.Visible = False
        PanelEnvolve_TXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelSubstituir.Visible = False

        ComBPMaster.PerformAutomaticSelection(4)

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        PanelEnvolve_TXT.Controls.Add(TXTPerson)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

    End Sub


    Sub ExibirTelaDataEHora()


        Panel_Right.Visible = True
        PanelEnvolve_TXT.Visible = False
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelSubstituir.Visible = False

        ComBPMaster.PerformAutomaticSelection(5)

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        PanelEnvolve_TXT.Controls.Add(TXTPerson)
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
        PanelSubstituir.Visible = False

        PanelEnvolve_ComBPSlave.Controls.Add(ComBRight)
        PanelEnvolve_TXT.Controls.Add(ComBPSlave)
        PanelEnvolve_ComBRight.Controls.Add(TXTPerson)


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
        PanelEnvolve_TXT.Controls.Add(TXTPerson)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)


        Panel_Right.Visible = False
        PanelEnvolve_TXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = True
        PanelEnvolve_ComBRight.Visible = True
        PanelSubstituir.Visible = False

        Me.Height = 54
        TableLPContainer.Dock = DockStyle.Fill

    End Sub

    Sub ExibirTelaSubstituicaoDeString()

        PanelEnvolve_ComBPSlave.Controls.Add(ComBPSlave)
        PanelEnvolve_TXT.Controls.Add(TXTPerson)
        PanelEnvolve_ComBRight.Controls.Add(ComBRight)


        Panel_Right.Visible = False
        PanelEnvolve_TXT.Visible = True
        PanelEnvolve_ComBPSlave.Visible = False
        PanelEnvolve_ComBRight.Visible = True

        PanelSubstituir.Visible = True
        PanelSubstituir.Dock = DockStyle.Fill

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
                item.TXTPerson.TXT = "Saluton" + item.ID.ToString

            End If
        Next

    End Sub

    Sub RemoverIndice(index As Integer)

        For Each item As Control_RenameOption In Me.Parent.Controls
            If item.ID > index Then
                item.ID -= 1
                item.TXTPerson.TXT = "Saluton" + item.ID.ToString

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
        renameOption.TXTPerson.TXT = "Saluton" + renameOption.ID.ToString
        renameOption.Visible = True

        OrdenarRenameOption()

    End Sub

    Sub GravarStringData()

    End Sub

    Private Sub Control_RenameOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTPerson.TXT = ID

        If Me.Parent.Parent.Parent.Parent IsNot Nothing Then
            If TypeOf (Me.Parent.Parent.Parent.Parent) Is Control_LoadRenameOption Then
                LoadRenameOptionsParent = Me.Parent.Parent.Parent.Parent

            End If
        End If

        AplicarEventoNosSubItensDeMenu(ComBPMaster.CMS_Menu)
        ExibirTelaTexto()

    End Sub

    Private Sub Control_RenameOption_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

    End Sub

    Public Sub DisplayInterface()

        If ComBPMaster.SelectedItem IsNot Nothing Then
            Dim indice As Integer = ComBPMaster.SelectedItem.Tag.ID

            Select Case indice

                Case DisplayTelaEnum.Texto
                    ExibirTelaTexto()

                Case DisplayTelaEnum.NovaExtensao
                    ExibirNovaExtensao()

                Case DisplayTelaEnum.NomeDoArquivoAtual
                    ExibirTelaNomeDoArquivoAtual()

                Case DisplayTelaEnum.NumeroDeSequencia
                    ExibirTelaNumeroDeSequencia()

                Case DisplayTelaEnum.LetraDaSequencia
                    ExibirTelaLetraDaSequencia()

                Case DisplayTelaEnum.DataEHora
                    ExibirTelaDataEHora()

                Case DisplayTelaEnum.Metadados
                    ExibirTelaMetadados()

                Case DisplayTelaEnum.NomeDaPasta
                    ExibirTelaNomeDaPasta()

                Case DisplayTelaEnum.SubstituicaoDeString
                    ExibirTelaSubstituicaoDeString()

            End Select

        End If

    End Sub

    Sub AplicarAcaoDeTela()
        Me.SelectDisplayTela = Me.ComBPMaster.SelectedItem.Tag.ID

    End Sub

    Sub AplicarEventoNosSubItensDeMenu(menu As ContextMenuStrip)

        For Each item As ToolStripMenuItem In menu.Items
            AddHandler item.Click, New System.EventHandler(AddressOf AplicarAcaoDeTela)

        Next

    End Sub

End Class
