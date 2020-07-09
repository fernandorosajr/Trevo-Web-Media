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

    Public Overloads Sub AtualizarSequenciaDeItens(node As TreeNode)

        Dim nivel As Integer = node.Level
        Dim controleDePasta As Control_ControleDePasta
        Dim parentNode As TreeNode = node.Parent

        Dim nivelDosItens As Integer = PanelRecebeControlesDePastas.Controls.Count - 1
        Dim nivelDoNodo As Integer = node.Level

        If nivelDosItens < 0 Then
            AdicionarAtualizarSequenciaDeItems(node)

        ElseIf nivelDoNodo > nivelDosItens Then
            controleDePasta = AdicionarUmItem(node)
            controleDePasta.BringToFront()

            AtualizarSequenciaDeItens(parentNode, nivel)
        ElseIf nivelDoNodo = nivelDosItens Then
            'ControlesDePastas
            controleDePasta = ControlesDePastas(nivelDoNodo)

            If controleDePasta.SelectedNode.Name <> node.Name Then
                controleDePasta.SelectedNode.Name = node.Name
                ' TODO: Atualizar ControlesDePastas
            End If

            AtualizarSequenciaDeItens(parentNode, nivel)

        ElseIf nivelDoNodo < nivelDosItens Then

            For x = 0 To PanelRecebeControlesDePastas.Controls.Count - 1

                controleDePasta = PanelRecebeControlesDePastas.Controls(x)

                If controleDePasta.SelectedNode.Level < nivelDoNodo Then
                    PanelRecebeControlesDePastas.Controls.Remove(controleDePasta)
                    ControlesDePastas.Remove(controleDePasta)
                End If

            Next

            AtualizarSequenciaDeItens(parentNode, nivel)
        End If




    End Sub

    Public Overloads Sub AtualizarSequenciaDeItens(node As TreeNode, nivel As Integer)

        Dim controleDePasta As Control_ControleDePasta
        Dim parentNode As TreeNode = node.Parent

        Dim nivelDosItens As Integer = PanelRecebeControlesDePastas.Controls.Count - 1
        Dim nivelDoNodo As Integer = node.Level

        If nivelDosItens < 0 Then
            AdicionarAtualizarSequenciaDeItems(node)

        ElseIf nivelDoNodo > nivelDosItens Then
            controleDePasta = AdicionarUmItem(node)
            controleDePasta.BringToFront()

            AtualizarSequenciaDeItens(parentNode, nivel)
        ElseIf nivelDoNodo = nivelDosItens Then
            'ControlesDePastas
            controleDePasta = ControlesDePastas(nivelDoNodo)

            If controleDePasta.SelectedNode.Name <> node.Name Then
                controleDePasta.SelectedNode.Name = node.Name
                ' TODO: Atualizar ControlesDePastas
            End If

            AtualizarSequenciaDeItens(parentNode, nivel)

        ElseIf nivelDoNodo < nivelDosItens Then

            For x = 0 To PanelRecebeControlesDePastas.Controls.Count - 1

                controleDePasta = PanelRecebeControlesDePastas.Controls(x)

                If controleDePasta.SelectedNode.Level > nivelDoNodo Then
                    If nivel = nivelDoNodo Then
                        PanelRecebeControlesDePastas.Controls.Remove(controleDePasta)
                        ControlesDePastas.Remove(controleDePasta)
                    End If
                End If

            Next

            AtualizarSequenciaDeItens(parentNode, nivel)
        End If


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

    Public Overloads Function AdicionarUmItem(node As TreeNode)
        Dim controleDePasta As New Control_ControleDePasta With {
            .Dock = DockStyle.Left,
            .SelectedNode = node
        }

        ' .Text = node.Text,

        'ControlesDePastas.Add(controleDePasta)
        PanelRecebeControlesDePastas.Controls.Add(controleDePasta)
        ControlesDePastas.Insert(0, controleDePasta)

        controleDePasta.Visible = True

        Return controleDePasta
    End Function
End Class
