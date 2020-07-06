Public Class Control_AddressBar
    Dim texto As String = "OK "
    Private Sub BTNLabel_Click(sender As Object, e As EventArgs) Handles BTNLabel.Click

        BTNLabel.Text = texto
        BTNLabel.Width = 10

        texto = texto + "OK "
    End Sub
End Class
