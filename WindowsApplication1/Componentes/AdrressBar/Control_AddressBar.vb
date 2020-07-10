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
            'AdicionarAtualizarSequenciaDeItems(value)
            AtualizarSequenciaDeItens(value)
            'ModificarLista()

        End Set
    End Property

    Sub ModificarLista()
        For Each item As Control_ControleDePasta In ControlesDePastas
            item.Text = "Teste"
        Next
    End Sub

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub


    Private Sub Control_AddressBar_Load(sender As Object, e As EventArgs) Handles Me.Load
        'AdicionarUmItem()

    End Sub

    Public Sub AtualizarItensExistentes(node As TreeNode)
        Dim parentNode As TreeNode

        If ControlesDePastas(node.Level).SelectedNode IsNot node Then
            ControlesDePastas(node.Level).SelectedNode = node

        End If

        If node.Parent IsNot Nothing Then
            parentNode = node.Parent
            AtualizarItensExistentes(parentNode)
        End If

    End Sub

    Public Overloads Sub AtualizarSequenciaDeItens(node As TreeNode)

        Dim qAddressBar As Integer = PanelRecebeControlesDePastas.Controls.Count - 1

        If qAddressBar < 0 Then
            CriarSequenciaDeItems(node)

        ElseIf qAddressBar = node.Level Then
            ' Atualiza itens
            AtualizarItensExistentes(node)

        ElseIf qAddressBar > node.Level Then
            ' Remove e atualiza itens 

            For x = 0 To qAddressBar
                If x > node.Level Then
                    ' TODO : Pode criar uma função para remover itens
                    Dim controleDePasta As Control_ControleDePasta
                    controleDePasta = ControlesDePastas(x) 'PanelRecebeControlesDePastas.Controls.Item(x)

                    PanelRecebeControlesDePastas.Controls.Remove(controleDePasta)
                    ControlesDePastas.Remove(controleDePasta)

                Else
                    AtualizarItensExistentes(node)

                End If
            Next

        ElseIf qAddressBar < node.Level Then
            ' Adicionar item na lista(na última posição) e no panel.

            Dim controleDePasta As Control_ControleDePasta
            Dim nodeParentList As New List(Of TreeNode)



            nodeParentList = CriarUmaListaDeNodeParent(node)

            For x = 0 To node.Level
                If x <= qAddressBar Then

                    If ControlesDePastas(x).SelectedNode IsNot nodeParentList(x) Then
                        ControlesDePastas(x).SelectedNode = nodeParentList(x)
                    End If

                Else
                    controleDePasta = AdicionarUmItem(nodeParentList(x))
                    controleDePasta.BringToFront()
                End If
            Next

        End If

    End Sub

    Function CriarUmaListaDeNodeParent(node As TreeNode) As List(Of TreeNode)
        Dim nodeParentList As New List(Of TreeNode)
        Dim _nodeParentList As New List(Of TreeNode)


        Dim parentNode As TreeNode


        If node.Parent IsNot Nothing Then
            parentNode = node.Parent

            _nodeParentList = CriarUmaListaDeNodeParent(parentNode)

            For Each item As TreeNode In _nodeParentList

                nodeParentList.Add(item)
            Next

        End If


        nodeParentList.Add(node)

        Return nodeParentList
    End Function



    Public Sub CriarSequenciaDeItems(node As TreeNode)

        Dim parentNode As TreeNode
        AdicionarUmItem(node, 0)

        If node.Parent IsNot Nothing Then
            parentNode = node.Parent
            CriarSequenciaDeItems(parentNode)

        End If

    End Sub



    Public Overloads Function AdicionarUmItem()
        Dim controleDePasta As New Control_ControleDePasta With {
            .Dock = DockStyle.Left,
            .SelectedNode = New TreeNode(defaultText)
        }

        ' .Text = defaultText,

        controleDePasta.SelectedNode.Tag = controleDePasta.Text

        ControlesDePastas.Add(controleDePasta)
        PanelRecebeControlesDePastas.Controls.Add(controleDePasta)

        controleDePasta.Visible = True

        Return controleDePasta

    End Function

    Public Overloads Function AdicionarUmItem(node As TreeNode, pos As Integer)
        Dim controleDePasta As New Control_ControleDePasta With {
            .Dock = DockStyle.Left,
            .SelectedNode = node
        }

        ' .Text = node.Text,

        PanelRecebeControlesDePastas.Controls.Add(controleDePasta)
        ControlesDePastas.Insert(pos, controleDePasta)

        controleDePasta.Visible = True

        Return controleDePasta

    End Function

    Public Overloads Function AdicionarUmItem(node As TreeNode)
        Dim controleDePasta As New Control_ControleDePasta With {
            .Dock = DockStyle.Left,
            .SelectedNode = node
        }

        ' .Text = node.Text,

        ControlesDePastas.Add(controleDePasta)
        PanelRecebeControlesDePastas.Controls.Add(controleDePasta)

        controleDePasta.Visible = True

        Return controleDePasta
    End Function
End Class
