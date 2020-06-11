Public Class Class_Number
    Public Function ArredondarParaMenos(value As Double)
        Dim pMenos As Integer
        Dim valueString As String

        Dim position As Integer

        valueString = value.ToString

        position = InStr(valueString, ",", CompareMethod.Binary) - 1

        If position < 0 Then position = 0

        If position = 0 Then
            pMenos = CInt(valueString)
        Else

            pMenos = CInt(valueString.Substring(0, position))
        End If


        Return pMenos

    End Function

    Public Function ArredondarParaMais(value As Double)
        Dim pMenos As Integer
        Dim pMais As Integer

        pMenos = ArredondarParaMenos(value)
        pMais = pMenos + 1

        Return pMais

    End Function
End Class
