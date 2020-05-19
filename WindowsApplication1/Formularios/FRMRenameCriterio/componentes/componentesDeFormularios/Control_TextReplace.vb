Public Class Control_TextReplace

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

    '_____________________________
    Private Sub LBL_TXTPPesquisar_Click(sender As Object, e As EventArgs) Handles LBL_TXTPPesquisar.Click
        TXTPPesquisar.Focus()

    End Sub

    Private Sub LBL_TXTPSubstituir_Click(sender As Object, e As EventArgs) Handles LBL_TXTPSubstituir.Click
        TXTPSubstituir.Focus()

    End Sub

    Private Sub BTNPesquisar_Click(sender As Object, e As EventArgs) Handles BTNPesquisar.Click

        Dim myPhrase As String = "Maria, Maria é um sol, é uma certa magia, é uma força que nos alerta!"
        Dim buscar As String = "Maria"
        Dim substituir As String = "João"

        ' TODO: https://docs.microsoft.com/pt-br/office/vba/language/reference/user-interface-help/replace-function

        Dim resultado As String

        resultado = funcoesDeString.ReplacePhrase(myPhrase, buscar, substituir)
        MsgBox(resultado)

    End Sub


End Class
