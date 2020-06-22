Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections.ObjectModel
Imports System.Drawing.Design
Imports System.IO
Imports System.Windows.Forms
'TODO: Remover controle em tenpos de execução : https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-add-to-or-remove-from-a-collection-of-controls-at-run-time

Public Class FRMDialogRenameCriterion

    'Importação de Classes
    '--------------------------------------------------
    ReadOnly funcoesDeString As New StringFunctionsClass
    Private configs As Class_Configs
    Private UsesDirectories As UsesDirectoriesClass
    Private RenameActions As New Class_RenameActions

    ' -------------------------------------------------

    Public SelectedFoldersAndFiles As New List(Of Object)
    Public Renamed_SelectedFoldersAndFiles As New List(Of Object)
    Private resultado As String

    Public fuxoContinuoDeRenome As Boolean
    ' Propriedades de Formulários
    ' ------------------------------------------------

    Private _dirExemple As DirectoryInfo
    Public Property DirExemple As String
        Get
            Return _dirExemple.FullName

        End Get
        Set(value As String)

            _dirExemple = New DirectoryInfo(value)

            If value.Substring(value.Length - 1, 1) = "\" Or value.Substring(value.Length - 1, 1) = "/" Then
                value = value.Substring(0, value.Length - 1)
            End If

            _fileExemple = New FileInfo(value & "\" & _fileExemple.Name)

        End Set
    End Property

    Const _fileExempleDefault As String = "C:\Pasta Teste\Arquivo.txt"
    Private _fileExemple As FileInfo
    Public Property FileExemple As String
        Get
            Return _fileExemple.FullName

        End Get
        Set(value As String)

            If value IsNot Nothing Or Trim(value) = "" Then
                _fileExemple = New FileInfo(value)

            Else
                value = _fileExempleDefault
                _fileExemple = New FileInfo(value)
            End If

            _dirExemple = New DirectoryInfo(_fileExemple.DirectoryName)

            LBL_ValueOrigemDoExemplo.Text = _dirExemple.FullName
            LNKLNomeDoExemplo.Text = _fileExemple.Name

            LoadRenameOptions.FileExemple = value

        End Set
    End Property
    ' ------------------------------------------------

    ' TODO :https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-layer-objects-on-windows-forms
    ' https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-set-the-tab-order-on-windows-forms

    Dim LoadRenameOptions As New Control_LoadRenameOptions

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'Private Sub BTNConfirmarRenomeDeOrigem_Click(sender As Object, e As EventArgs)
    '    'txtFirstName.BringToFront()
    '    PanelElemento.BringToFront()

    'End Sub

    'Private Sub BTNCancelaRenomeDeOrigem_Click(sender As Object, e As EventArgs)
    '    PanelElemento.SendToBack()
    '    ' PanelElemento.GetNextControl()

    'End Sub

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        PanelRecebe.Controls.Add(LoadRenameOptions)
        FileExemple = "C:\Pasta Teste\Meu ArquivO arQUiVado.txt"
        LoadRenameOptions.FileExemple = FileExemple

        LoadRenameOptions.Top = 31
        LoadRenameOptions.Left = 103
        LoadRenameOptions.Width = LBLTitle01.Width
        LoadRenameOptions.Height = 231

        LoadRenameOptions.Dock = DockStyle.Fill
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub FRMDialogRenameCriterio_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'LoadRenameOptions.FileExemple = FileExemple
        'PanelRecebe.Controls.Add(LoadRenameOptions)
        'LoadRenameOptions.Top = 31
        'LoadRenameOptions.Left = 103
        'LoadRenameOptions.Width = LBLTitle01.Width
        'LoadRenameOptions.Height = 231

        'LoadRenameOptions.Dock = DockStyle.Fill

        If SelectedFoldersAndFiles IsNot Nothing Then
            If SelectedFoldersAndFiles.Count > 0 Then

                For Each item In SelectedFoldersAndFiles

                    If TypeOf item Is DirectoryInfo Then

                    ElseIf TypeOf item Is FileInfo Then
                        Dim itemFile As FileInfo = item
                        FileExemple = itemFile.FullName
                        Exit For

                    End If
                Next

            End If


        End If

    End Sub

    Private Sub LNKLNomeDoExemplo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNKLNomeDoExemplo.LinkClicked
        LNKLNomeDoExemplo_Click()
    End Sub

    Private Sub LNKLNomeDoExemplo_Click(sender As Object, e As EventArgs) Handles LNKLNomeDoExemplo.Click
        LNKLNomeDoExemplo_Click()

    End Sub

    Sub LNKLNomeDoExemplo_Click()

        TXTCNovoNome.Filho = LNKLNomeDoExemplo

        TXTCNovoNome.ValueStr = LNKLNomeDoExemplo.Text

        TXTCNovoNome.Focus()

        TXTCNovoNome.Visible = True
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        FileExemple = _dirExemple.FullName & "\" & LNKLNomeDoExemplo.Text

        LBL_ValueOrigemDoExemplo.Text = _fileExemple.DirectoryName
        LNKLNomeDoExemplo.Text = _fileExemple.Name

        resultado = LoadRenameOptions.TextResult

        LBLValue_NovoNome.Text = resultado

        'If Trim(_resultado) = "" Then
        '    LBLValue_NovoNome.Text = _fileExemple.Name

        'Else

        'End If

    End Sub

    Private Sub BTNVisulizar_Click(sender As Object, e As EventArgs) Handles BTNVisulizar.Click

        Timer.Enabled = False
        Me.UseWaitCursor = True

        Dim dataRenameCriteriaList As New List(Of Class_DataRenamingCriterion)

        ' Gerar Lista de comandos de renome

        Dim renameOption As Control_RenameOption
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer = LoadRenameOptions.Itens.Count - 1


        For x = 0 To z
            y = z - x

            renameOption = LoadRenameOptions.Itens.Item(y)
            dataRenameCriteriaList.Add(renameOption.DataRenamingCriterion)

        Next

        Renamed_SelectedFoldersAndFiles.Clear()

        Renamed_SelectedFoldersAndFiles = RenameActions.Rename_SELECTED_LIST_AccordingToCriterion(SelectedFoldersAndFiles, dataRenameCriteriaList)

        FRMDialogVisualizarRenome.Width = Me.Width
        FRMDialogVisualizarRenome.Height = Me.Height
        FRMDialogVisualizarRenome.LBLExplicacao.Text = "Carregando ..."

        FRMDialogVisualizarRenome.SelectedFoldersAndFiles = SelectedFoldersAndFiles
        FRMDialogVisualizarRenome.Renamed_SelectedFoldersAndFiles = Renamed_SelectedFoldersAndFiles

        FRMDialogVisualizarRenome.ShowDialog()

        Me.UseWaitCursor = False
        Timer.Enabled = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
