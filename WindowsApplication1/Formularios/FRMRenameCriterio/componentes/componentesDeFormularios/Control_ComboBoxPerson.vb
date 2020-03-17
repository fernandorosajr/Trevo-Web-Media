Public Class Control_ComboBoxPerson

    Dim funcoesDeString As New StringFunctionsClass
    Private _options As String
    Public Property Options As String
        Get
            Return _options
        End Get
        Set(value As String)
            _options = value
        End Set
    End Property

    Dim separador() As Char = {vbCrLf}

    Private _lista As ArrayList
    Public Property Lista As String
        'Dim listaArray As New ArrayList()
        Get
            Dim listaReturn As String = ""
            'Return _lista
            For Each str As String In _lista
                listaReturn = listaReturn & str & vbCrLf
            Next

            Return listaReturn

        End Get
        Set(value As String)
            Dim listaAux As New ArrayList()
            Dim listaReturn() As String
            'listaAux.AddRange(value.Split(vbCrLf))
            '_lista = listaAux

            listaReturn = funcoesDeString.SepararPalavras(value, {vbCrLf})
            _lista.AddRange(listaReturn)

        End Set
    End Property

    Private Sub ControlComboBoxPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim novaLinha As String
        Dim _value As String = ""

        For x = 0 To 5
            novaLinha = ("Teste " & (x + 1)) & vbCrLf
            _value = _value & novaLinha

        Next
        Options = _value

        ' Lista = Options
    End Sub



End Class
