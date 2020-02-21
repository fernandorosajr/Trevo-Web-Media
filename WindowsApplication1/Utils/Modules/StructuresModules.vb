Module StructuresModules

    Public Structure FoldersPathsOperations
        Public sourceOldPath As String
        Public sourceNewPath As String
        Public destinationOldPath As String
        Public destinationNewPath As String

        Public sourcePath As String
        Public destinationPath As String
    End Structure

    Public _foldersPathsOperations As FoldersPathsOperations

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
