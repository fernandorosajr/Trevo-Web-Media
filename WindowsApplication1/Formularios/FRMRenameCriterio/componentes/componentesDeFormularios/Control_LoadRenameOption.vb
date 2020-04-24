Public Class Control_LoadRenameOption
    Dim CtlRenameOptPrima As New Control_RenameOption



    Private Sub Control_LoadRenameOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Panel_LoadRenameOption.Controls.Add(CtlRenameOptPrima)
        CtlRenameOptPrima.Dock = DockStyle.Top
        CtlRenameOptPrima.Visible = True


    End Sub

End Class
