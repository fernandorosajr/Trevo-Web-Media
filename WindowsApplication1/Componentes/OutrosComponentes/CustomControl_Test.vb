Public Class CustomControl_Test
    ' https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-inherit-from-existing-windows-forms-controls
    ' https://social.msdn.microsoft.com/Forums/pt-BR/86e1175f-c9bd-4265-8fb1-1a60a28a0edd/eventos-em-um-user-control?forum=vsvbasicpt
    ' https://www.devmedia.com.br/desenvolvimento-de-user-control-com-propriedade-dinamica-parte-1/24197

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Adicione o seu código personalizado aqui
    End Sub

End Class
