Module StructuresModules

    Public Structure CaminhosDeRenomeDePastas
        Public oldPathOrigem As String
        Public newPathOrigem As String
        Public oldPathDestino As String
        Public newPathDestino As String

        Public oldPath As String
        Public newPath As String
    End Structure

    Public _caminhosDasOperacoesComPastas As CaminhosDeRenomeDePastas

    Public Structure employeem
        Public givenName As String
        Public familyName As String
        Public phoneExtension As Long
        Private salary As Decimal
        Public Sub giveRaise(raise As Double)
            salary *= raise
        End Sub
    End Structure

    Public estrutura2 As employeem

End Module
