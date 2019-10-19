Public Class Form1

    Public Btn As New Button
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Btn = New Button
        Btn.Location = New Point(0, 900)
        Btn.Text = "testando"
        Btn.Visible = True

        Panel1.Controls.Add(Btn)
    End Sub


End Class
