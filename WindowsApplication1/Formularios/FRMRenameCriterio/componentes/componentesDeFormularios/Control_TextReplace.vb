Public Class Control_TextReplace

    ' Variveis públicas
    '--------------------------------------------------------------
    Public PhraseResult As String
    '--------------------------------------------------------------

    'Importação de Classes
    '--------------------------------------------------
    ReadOnly funcoesDeString As New StringFunctionsClass
    Private configs As Class_Configs
    Private usesFile As New UsesFilesClass
    ' -------------------------------------------------

    ' Propriedades
    '_____________________________
    Private _automaticResult As Boolean
    Public Property AutomaticResult As Boolean
        Get
            Return _automaticResult
        End Get
        Set(value As Boolean)
            _automaticResult = value
            PanelEnvolve_BTNPesquisar.Visible = Not (value)
        End Set
    End Property

    Private _ignoreUpperLower As Boolean
    Public Property IgnoreUpperLower As Boolean
        Get
            Return _ignoreUpperLower

        End Get
        Set(value As Boolean)
            _ignoreUpperLower = value

        End Set
    End Property

    Public _replaceAll As Boolean
    Public Property ReplaceAll As Boolean
        Get
            Return _replaceAll
        End Get
        Set(value As Boolean)
            _replaceAll = value

        End Set
    End Property

    Private _phrase As String
    Public Property Phrase As String
        Get
            Return _phrase

        End Get
        Set(value As String)
            _phrase = value
            PhraseResult = TratarPhrase(_phrase)
        End Set
    End Property

    Private _find As String
    Public Property Find As String
        Get
            Return _find

        End Get
        Set(value As String)
            _find = value
            TXTPFind.TXT = value

        End Set
    End Property

    Private _replacement As String
    Public Property Replacement As String
        Get
            Return _replacement

        End Get
        Set(value As String)
            _replacement = value
            TXTPReplacement.TXT = value

        End Set
    End Property
    '--------------------------------------------------------------
    '_____________________________

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        AddHandler TXTPFind.TXTBox.LostFocus, New System.EventHandler(AddressOf TXTsPerson_LostFocus)
        AddHandler TXTPReplacement.TXTBox.LostFocus, New System.EventHandler(AddressOf TXTsPerson_LostFocus)


    End Sub

    Private Sub LBL_TXTPPesquisar_Click(sender As Object, e As EventArgs) Handles LBL_TXTPPesquisar.Click
        TXTPFind.Focus()

    End Sub

    Private Sub LBL_TXTPSubstituir_Click(sender As Object, e As EventArgs) Handles LBL_TXTPSubstituir.Click
        TXTPReplacement.Focus()

    End Sub

    Private Sub BTNPesquisar_Click(sender As Object, e As EventArgs) Handles BTNPesquisar.Click
        PhraseResult = TratarPhrase(_phrase)

        MsgBox(PhraseResult)

    End Sub

    Public Overloads Function TratarPhrase(_phrase As String)
        _find = TXTPFind.TXT
        _replacement = TXTPReplacement.TXT

        ' TODO: https://docs.microsoft.com/pt-br/office/vba/language/reference/user-interface-help/replace-function

        Dim result As String

        'Dim _ignoreUpperLower As Boolean = CHKIgnoreUpperLower.Checked
        'Dim _replaceAll As Boolean = CHKReplaceAll.Checked

        result = funcoesDeString.ReplacePhrase(_phrase, _find, _replacement, _ignoreUpperLower, _replaceAll)

        Return result
    End Function

    Public Overloads Function TratarPhrase()
        _find = TXTPFind.TXT
        _replacement = TXTPReplacement.TXT

        ' TODO: https://docs.microsoft.com/pt-br/office/vba/language/reference/user-interface-help/replace-function

        Dim result As String

        'Dim _ignoreUpperLower As Boolean = CHKIgnoreUpperLower.Checked
        'Dim _replaceAll As Boolean = CHKReplaceAll.Checked

        result = funcoesDeString.ReplacePhrase(_phrase, _find, _replacement, _ignoreUpperLower, _replaceAll)

        Return result
    End Function

    ' Métodos de Eventos 
    ' -------------------------------------------------
    Private Sub Control_TextReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' _phrase = "Maria, Maria é um sol, é uma certa magia, é uma força que nos alerta! Maria é dom é cor é suor. Maria, Maria."
    End Sub

    Private Sub CHKIgnoreUpperLower_CheckedChanged(sender As Object, e As EventArgs) Handles CHKIgnoreUpperLower.CheckedChanged
        _ignoreUpperLower = CHKIgnoreUpperLower.Checked

    End Sub

    Private Sub CHKReplaceAll_CheckedChanged(sender As Object, e As EventArgs) Handles CHKReplaceAll.CheckedChanged
        _replaceAll = CHKReplaceAll.Checked

    End Sub

    Private Sub TXTsPerson_LostFocus()
        _find = TXTPFind.TXT
        _replacement = TXTPReplacement.TXT
    End Sub

    ' -------------------------------------------------
End Class
