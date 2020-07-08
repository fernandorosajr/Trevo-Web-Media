Public Class Control_AddressBar
    'Public controleDePasta As New Control_ControleDePasta

    Public ControlesDePastas As New List(Of Control_ControleDePasta)
    Const defaultText As String = "Node"

    Private _selectedNode As TreeNode
    Public Property SelectedNode As TreeNode
        Get
            Return _selectedNode
        End Get

        Set(value As TreeNode)

            _selectedNode = value
            AdicionarAtualizarSequenciaDeItems(value)
        End Set
    End Property


    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub


    Private Sub Control_AddressBar_Load(sender As Object, e As EventArgs) Handles Me.Load
        'AdicionarUmItem()

    End Sub

    Public Sub AdicionarAtualizarSequenciaDeItems(node As TreeNode)

        Dim parentNode As TreeNode
        AdicionarUmItem(node)

        If node.Parent IsNot Nothing Then
            parentNode = node.Parent
            AdicionarAtualizarSequenciaDeItems(parentNode)

        End If

    End Sub

    Public Sub ConferirItensExistentes(node As TreeNode)
        For Each controleDePasta As Control_ControleDePasta In ControlesDePastas
            '  MsgBox(controleDePasta.SelectedNode.Tag)
        Next
    End Sub

    Public Overloads Sub AdicionarUmItem()
        Dim controleDePasta As New Control_ControleDePasta With {
            .Dock = DockStyle.Left,
            .SelectedNode = New TreeNode(defaultText)
        }

        ' .Text = defaultText,
        controleDePasta.SelectedNode.Tag = controleDePasta.Text

        ControlesDePastas.Add(controleDePasta)
        PanelRecebeControlesDePastas.Controls.Add(controleDePasta)

        controleDePasta.Visible = True
    End Sub



    Public Overloads Sub AdicionarUmItem(node As TreeNode)
        Dim controleDePasta As New Control_ControleDePasta With {
            .Dock = DockStyle.Left,
            .SelectedNode = node
        }
        ' .Text = node.Text,



        ControlesDePastas.Add(controleDePasta)
        PanelRecebeControlesDePastas.Controls.Add(controleDePasta)

        controleDePasta.Visible = True
    End Sub
End Class
