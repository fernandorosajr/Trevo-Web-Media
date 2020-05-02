Public Class Control_LoadRenameOption
    Dim CtlRenameOptPrima As New Control_RenameOption

    Private _listControl As New List(Of Control)

    Public Property ListControl As List(Of Control)
        Get
            Return _listControl

        End Get
        Set(value As List(Of Control))
            _listControl = value

        End Set
    End Property


    Private Sub Control_LoadRenameOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Panel_LoadRenameOption.Controls.Add(CtlRenameOptPrima)
        CtlRenameOptPrima.Dock = DockStyle.Top
        CtlRenameOptPrima.Visible = True
        CtlRenameOptPrima.TabIndex = 0

        If CtlRenameOptPrima IsNot Nothing Then
            _listControl.Add(CtlRenameOptPrima)

        End If


    End Sub

End Class
