Public Class Control_LoadRenameOption
    Dim CtlRenameOptionPrima As New Control_RenameOption


    Private _itens As New List(Of Control)
    Public Property Itens As List(Of Control)
        Get
            Return _itens

        End Get
        Set(value As List(Of Control))
            _itens = value

        End Set
    End Property

    Private _defaultItem As Control
    Public Property DefaultItem As Control
        Get
            Return _defaultItem

        End Get
        Set(value As Control)
            _defaultItem = value

        End Set
    End Property

    Private Sub Control_LoadRenameOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        If _defaultItem Is Nothing Then
            _defaultItem = CtlRenameOptionPrima
        End If

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Panel_LoadRenameOption.Controls.Add(_defaultItem)
        _defaultItem.Dock = DockStyle.Top
        _defaultItem.Visible = True
        _defaultItem.TabIndex = 0

        If _defaultItem IsNot Nothing Then
            _itens.Add(_defaultItem)

        End If


    End Sub

End Class
