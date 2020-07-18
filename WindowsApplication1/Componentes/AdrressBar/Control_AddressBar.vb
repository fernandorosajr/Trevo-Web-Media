Public Class Control_AddressBar
    'Public controleDePasta As New Control_ControleDePasta

    Public ControlesDePastas As New List(Of Control_ControleDePasta)
    Const defaultText As String = "Node"

    Private _selectedImage As Image
    Public Property SelectedImage As Image
        Get
            Return _selectedImage
        End Get
        Set(value As Image)
            _selectedImage = value

        End Set
    End Property

    Private _imageList As ImageList
    Public Property ImageList As ImageList
        Get
            Return _imageList

        End Get
        Set(value As ImageList)
            _imageList = value
        End Set
    End Property

    Private _mainNode As TreeNode
    Public Property MainNode As TreeNode
        Get
            Return _mainNode
        End Get
        Set(value As TreeNode)
            _mainNode = value

            If value IsNot Nothing Then
                MainFolderControl.SelectedNode = value

                MainFolderControl.Image = _mainNode.TreeView.ImageList.Images.Item(_mainNode.ImageKey)

                If _selectedTreeView Is Nothing Then
                    _selectedTreeView = _mainNode.TreeView
                    MainFolderControl.SelectedTreeView = _mainNode.TreeView
                End If

            End If
        End Set
    End Property

    Private _selectedTreeView As TreeView
    Public Property SelectedTreeView As TreeView
        Get
            Return _selectedTreeView

        End Get
        Set(value As TreeView)
            _selectedTreeView = value

        End Set
    End Property

    Private _selectedNode As TreeNode
    Public Property SelectedNode As TreeNode
        Get
            Return _selectedNode
        End Get

        Set(value As TreeNode)

            _selectedNode = value

            If value.TreeView IsNot Nothing Then
                _selectedTreeView = value.TreeView
                _selectedTreeView.SelectedNode = value

                If _imageList Is Nothing Then
                    _imageList = SelectedTreeView.ImageList
                End If

                If _imageList IsNot Nothing Then
                    MainFolderControl.Image = _imageList.Images.Item(_selectedNode.ImageKey)

                End If
            End If

            AtualizarSequenciaDeItens(value)

        End Set

    End Property


    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        MainFolderControl.AddressBar = Me
    End Sub


    Private Sub Control_AddressBar_Load(sender As Object, e As EventArgs) Handles Me.Load


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
        'TODO: Talvez funcione se atualizar a sequencia de menu tb aqui.
        ' Onde está sendo atualizada a sequencia de menu?
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
            Dim ControlesDePastasParaExcluir As New List(Of Control_ControleDePasta)
            For x = 0 To qAddressBar
                If x > node.Level Then

                    ControlesDePastasParaExcluir.Add(ControlesDePastas(x))

                Else
                    AtualizarItensExistentes(node)

                End If
            Next

            For Each controleDePasta In ControlesDePastasParaExcluir
                PanelRecebeControlesDePastas.Controls.Remove(controleDePasta)
                ControlesDePastas.Remove(controleDePasta)
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
                    If x - 1 >= 0 Then   controleDePasta.Master = ControlesDePastas(x - 1)
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



    Public Function CriarSequenciaDeItems(node As TreeNode)

        Dim item As Control_ControleDePasta
        Dim parentNode As TreeNode
        item = AdicionarUmItem(node, 0)

        If node.Parent IsNot Nothing Then
            parentNode = node.Parent
            item.Master = CriarSequenciaDeItems(parentNode)

        End If

        Return item
    End Function



    Public Overloads Function AdicionarUmItem()
        Dim controleDePasta As New Control_ControleDePasta With {
            .Dock = DockStyle.Left,
            .SelectedNode = New TreeNode(defaultText),
            .AddressBar = Me
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
            .SelectedNode = node,
            .AddressBar = Me,
            .Level = node.Level
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
            .SelectedNode = node,
             .AddressBar = Me
        }

        ' .Text = node.Text,

        ControlesDePastas.Add(controleDePasta)
        PanelRecebeControlesDePastas.Controls.Add(controleDePasta)

        controleDePasta.Visible = True

        Return controleDePasta
    End Function
End Class
