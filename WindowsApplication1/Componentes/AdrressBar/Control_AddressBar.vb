﻿Imports System.Data.SqlTypes
Imports System.IO
Imports System.Security.Cryptography

Public Class Control_AddressBar

    'Private _structureTeste As Stru_Usu
    'Public Property StructureTeste As Stru_Usu
    '    Get
    '        Return _structureTeste
    '    End Get
    '    Set(value As Stru_Usu)
    '        _structureTeste = value
    '        y
    '    End Set
    'End Property

    'Structure Stru_Usu
    '    Dim Nome As String
    '    Dim Cidade As String
    '    Private LCDataNacimento As Date
    '    Private LcIdade As Integer
    '    Private LcUf As String
    '    Public Property DataNacimento() As Date
    '        Get
    '            Return LCDataNacimento
    '        End Get
    '        Set(ByVal Value As Date)
    '            LCDataNacimento = Value
    '            LcIdade = System.DateTime.Now.Year - LCDataNacimento.Year
    '        End Set
    '    End Property
    '    Public ReadOnly Property Idade() As Integer
    '        Get
    '            Return LcIdade
    '        End Get
    '    End Property
    '    Public Property UF() As String
    '        Get
    '            Return LcUf
    '        End Get
    '        Set(ByVal Value As String)
    '            If Value = "" Then
    '                LcUf = Value
    '            Else
    '                Dim listaUF() As String = {"RJ", "SP"}
    '                Value = Value.ToUpper
    '                If Array.BinarySearch(listaUF, Value) < 0 Then
    '                    RaiseEvent InvalidUF(Value)
    '                Else
    '                    LcUf = Value
    '                End If
    '            End If
    '        End Set
    '    End Property
    '    Public Event InvalidUF(ByVal UF As String)
    'End Structure


    Dim confirmar As Byte
    'Importar Classes
    '------------------------------------------------------
    Dim nodeManipulatior As New Class_NodeManipulator

    Dim ForceTextMode As Boolean

    Public ControlesDePastas As New List(Of Control_ControleDePasta)
    Const defaultText As String = "Node"

    'Public Structure KeywordNode
    '    'Dim keyword As String
    '    'Dim nodeAssociated As TreeNode

    '    Private _keyword As String
    '    Public Property Keyword As String
    '        Get
    '            Return _keyword
    '        End Get
    '        Set(value As String)
    '            _keyword = value

    '        End Set
    '    End Property

    '    Private _nodeAssociated As TreeNodeCollection
    '    Public Property NodeAssociated As TreeNodeCollection
    '        Get
    '            Return _nodeAssociated
    '        End Get
    '        Set(value As TreeNodeCollection)
    '            _nodeAssociated = value

    '            'If value Is Nothing Then
    '            '    value = New TreeNodeCollection
    '            'End If


    '        End Set

    '    End Property

    'End Structure

    'Private _keywordsList As New List(Of KeywordNode)

    'Public Property KeywordsList As List(Of KeywordNode)
    '    Get
    '        Return _keywordsList

    '    End Get
    '    Set(value As List(Of KeywordNode))
    '        _keywordsList = value
    '    End Set
    'End Property


    'Public _keyword As New List(Of Class_Keywords)
    'Public Property Keyword As List(Of Class_Keywords.KeywordNode)
    '    Get
    '        Dim classKey As New List(Of Class_Keywords.KeywordNode)

    '        For Each item As Class_Keywords In _keyword
    '            classKey(x) = item.KeywordNode

    '        Next
    '        classKey.KeywordNode = _keyword
    '        Return _keyword.
    '    End Get
    '    Set(value As List(Of Class_Keywords.KeywordNode))


    '        _keyword = value


    '    End Set
    'End Property


    'Public _keyword As New List(Of Class_Keywords)
    'Public Property Keyword As List(Of Class_Keywords)
    '    Get
    '        Return _keyword

    '    End Get
    '    Set(value As List(Of Class_Keywords))
    '        _keyword = value

    '    End Set
    'End Property

    Private _keyword As New Keyword
    Public Property Keyword() As Keyword
        Get
            Return _keyword

        End Get
        Set(value As Keyword)
            _keyword = value

        End Set
    End Property

    Private _keywords2 As New Keyword
    Public Property Keywords2() As Keyword
        Get
            Return _keywords2

        End Get
        Set(value As Keyword)
            _keyword = value

        End Set
    End Property


    Private _keywords As New Class_KeywordsCollections
    Public Property Keywords() As Class_KeywordsCollections
        Get
            Return _keywords
        End Get
        Set(value As Class_KeywordsCollections)
            _keywords = value

        End Set
    End Property

    'Private _keyword As List(Of Class_KeywordsCollections.KeywordNode)
    'Public Property Keyword() As List(Of Class_KeywordsCollections.KeywordNode)
    '    Get
    '        Return _keyword
    '    End Get
    '    Set(value As List(Of Class_KeywordsCollections.KeywordNode))
    '        _keyword = value
    '    End Set
    'End Property

    'Dim nodeTeste As TreeNode = New TreeNode("Meu Nó")

    'Dim nodeList As New List(Of TreeNode) From {
    '    nodeTeste
    '}


    'Dim teste As Class_Keywords = New Class_Keywords With {
    '    .Keyword = "teste",
    '    .NodeAssociated = nodeList
    '}

    'Private _keywordsList As New Class_KeywordsCollections
    'Public Property KeywordsList() As Class_KeywordsCollections
    '    Get
    '        Return _keywordsList
    '    End Get
    '    Set(value As Class_KeywordsCollections)
    '        _keywordsList = value
    '    End Set
    'End Property



    'Public Structure KeywordNode

    '    Private _keyword As String
    '    Public Property Keyword As String
    '        Get
    '            Return _keyword
    '        End Get
    '        Set(value As String)
    '            _keyword = value
    '        End Set
    '    End Property

    '    Private _nodeAssociated As List(Of TreeNode)
    '    Public Property NodeAssociated() As List(Of TreeNode)
    '        Get

    '            Return _nodeAssociated
    '        End Get
    '        Set(value As List(Of TreeNode))

    '            _nodeAssociated = value

    '        End Set

    '    End Property
    'End Structure

    Private _treeNode As New TreeNode
    Public Property TreeNode As TreeNodeCollection
        Get
            Return _treeNode.Nodes
        End Get
        Set(value As TreeNodeCollection)


            If _treeNode.Nodes.Count > value.Count Then

                For x = 0 To _treeNode.Nodes.Count
                    If x <= _treeNode.Nodes.Count Then
                        _treeNode.Nodes.Item(x) = value(x)
                    Else
                        _treeNode.Nodes.Remove(_treeNode.Nodes.Item(x))
                    End If
                Next

            End If

            If _treeNode.Nodes.Count < value.Count Then

                For x = 0 To value.Count
                    If x <= value.Count Then
                        _treeNode.Nodes.Item(x) = value.Item(x)
                    Else
                        _treeNode.Nodes.Add(value.Item(x))
                    End If
                Next

            End If
        End Set

    End Property

    Public _nodeAssociated2 As New Collection
    Public Property NodeAssociated2() As List(Of TreeNode)
        Get
            Dim listNode As New List(Of TreeNode)
            For Each nodo As TreeNode In _nodeAssociated2
                listNode.Add(nodo)
            Next
            Return listNode

        End Get
        Set(value As List(Of TreeNode))

            Dim x As Integer
            Dim _valueCount As Integer
            Dim _nodeAssociated2Count As Integer
            Dim max As Integer
            Dim min As Integer

            _valueCount = value.Count
            _nodeAssociated2Count = _nodeAssociated2.Count

            max = Math.Max(_valueCount, _nodeAssociated2Count)
            min = Math.Min(_valueCount, _nodeAssociated2Count)
            If max >= 0 Then

                For x = 0 To max
                    If x > min Then

                        If _valueCount > _nodeAssociated2Count Or _valueCount = 0 Then
                            _nodeAssociated2.Add(value.Item(x))
                        End If

                        If _valueCount < _nodeAssociated2Count Then
                            _nodeAssociated2.Remove(x)
                            '(value.Item(x))
                        End If
                    End If
                Next

            End If

        End Set

    End Property

    Public _nodeAssociated As New List(Of TreeNode)
    Public Property NodeAssociated() As List(Of TreeNode)
        Get

            Return _nodeAssociated
        End Get
        Set(value As List(Of TreeNode))

            _nodeAssociated = value

        End Set

    End Property

    Public Enum DisplayModeEnum
        FoldersControlsMode = 0
        TextMode = 1
    End Enum

    Dim colorLostFocus As Color = Color.Gainsboro
    Dim colorFocus As Color = Color.SkyBlue ' ColorTranslator.FromHtml(KnownColor.Highlight)

    'Public SomaDeMenus As New ContextMenuStrip

    Private _cMenuToExpandOptionsButton As ContextMenuStrip
    Public Property CMenuToExpandOptionsButton As ContextMenuStrip

        Get
            Return _cMenuToExpandOptionsButton
        End Get
        Set(value As ContextMenuStrip)
            _cMenuToExpandOptionsButton = value
        End Set
    End Property

    'Private _menus As New List(Of ContextMenuStrip)
    'Public Property Menus As List(Of ContextMenuStrip)
    '    Get
    '        Return _menus

    '    End Get
    '    Set(value As List(Of ContextMenuStrip))

    '        _menus = value

    '        If value IsNot Nothing Then
    '            For Each menuItem As ContextMenuStrip In value

    '                If menuItem.Text IsNot Nothing Then
    '                    If Trim(menuItem.Text) <> "" Then
    '                        Dim itemPrincipal As New ToolStripMenuItem

    '                        itemPrincipal.Text = menuItem.Text
    '                        itemPrincipal.DropDownItems.AddRange(menuItem.Items)

    '                        SomaDeMenus.Items.Add(itemPrincipal)
    '                    Else
    '                        For Each item In menuItem.Items
    '                            Dim obj As New Object
    '                            'Dim click As EventHandler(Of ItemActivation)
    '                            'click = item.Click, AddressOf Me.menuItem1_Click
    '                            obj = New ToolStripMenuItem(item.Text, item.Image)
    '                            SomaDeMenus.Items.Add(obj)

    '                        Next
    '                        'SomaDeMenus.Items.AddRange(menuItem.Items)
    '                    End If
    '                End If

    '            Next
    '        End If

    '    End Set
    'End Property

    Private _displayMode As DisplayModeEnum
    Public Property DisplayMode As DisplayModeEnum
        Get
            Return _displayMode

        End Get
        Set(value As DisplayModeEnum)
            _displayMode = value

            Select Case value

                Case DisplayModeEnum.FoldersControlsMode
                    PanelExibirControlesDePastas.BringToFront()
                    BorderColorChange(colorLostFocus)

                Case DisplayModeEnum.TextMode
                    BorderColorChange(colorFocus)

                    If _selectedNode IsNot Nothing Then
                        'TXTWriteAddress.Text = SelectedNode.Tag

                    ElseIf _mainNode IsNot Nothing Then
                        TXTWriteAddress.Text = MainNode.Tag

                    End If

                    TXTWriteAddress.Focus()
                    Panel_EnvolveTXT.BringToFront()

            End Select
        End Set
    End Property

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

                If TypeOf _mainNode.Tag Is String Then
                    TXTWriteAddress.Text = _mainNode.Tag
                End If

                MainFolderControl.SelectedNode = value

                If _selectedNode Is Nothing Then
                    SelectedNode = value
                End If

                MainFolderControl.Image = value.TreeView.ImageList.Images.Item(_mainNode.ImageKey)

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

            CriarListaDeOpcoesParaAutoCompleteCustomSource()

            If value IsNot Nothing Then
                If TypeOf _selectedNode.Tag Is String Then
                    TXTWriteAddress.Text = _selectedNode.Tag
                End If

                If value.TreeView IsNot Nothing Then
                    _selectedTreeView = value.TreeView
                    '_selectedTreeView.SelectedNode = value

                    If _imageList Is Nothing Then
                        _imageList = SelectedTreeView.ImageList
                    End If

                    If _imageList IsNot Nothing Then
                        MainFolderControl.Image = _imageList.Images.Item(_selectedNode.ImageKey)

                    End If
                End If

                AtualizarSequenciaDeItens(value)
            End If




        End Set

    End Property

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        MainFolderControl.AddressBar = Me
        PanelExibirControlesDePastas.BringToFront()

        'Dim teste As New KeywordNode
        'KeywordsList.Add(teste)


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
        Dim item As Control_ControleDePasta

        Dim qAddressBar As Integer = PanelRecebeControlesDePastas.Controls.Count - 1

        If qAddressBar < 0 Then

            item = CriarSequenciaDeItems(node)

            If node.Name <> "Computador" Then
                'If nodo.GetNodeCount(True) > 0 Then
                If node.GetNodeCount(True) = 0 Then
                    item.DisplayExpandOptionsButton = True

                End If
            End If


        ElseIf qAddressBar = node.Level Then
            ' Atualiza itens
            AtualizarItensExistentes(node)

            If node.GetNodeCount(True) = 0 Then
                ControlesDePastas(node.Level).DisplayExpandOptionsButton = True
            Else
                ControlesDePastas(node.Level).DisplayExpandOptionsButton = False

            End If

        ElseIf qAddressBar > node.Level Then
            ' Remove e atualiza itens 
            Dim ControlesDePastasParaExcluir As New List(Of Control_ControleDePasta)
            For x = 0 To qAddressBar
                If x > node.Level Then

                    ControlesDePastasParaExcluir.Add(ControlesDePastas(x))

                Else
                    AtualizarItensExistentes(node)
                    'item.DisplayExpandOptionsButton = True
                    If node.Name <> "Computador" Then
                        If node.GetNodeCount(True) = 0 Then ControlesDePastas(node.Level).DisplayExpandOptionsButton = True
                    End If
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
                    ControlesDePastas(x).DisplayExpandOptionsButton = False

                Else
                    controleDePasta = AdicionarUmItem(nodeParentList(x))
                    If x - 1 >= 0 Then controleDePasta.Master = ControlesDePastas(x - 1)
                    controleDePasta.BringToFront()

                    If x = node.Level Then
                        If node.GetNodeCount(True) = 0 Then controleDePasta.DisplayExpandOptionsButton = True

                    Else
                        controleDePasta.DisplayExpandOptionsButton = False

                    End If

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

        If node IsNot Nothing Then
            item = AdicionarUmItem(node, 0)

            If node.Parent IsNot Nothing Then
                parentNode = node.Parent
                item.Master = CriarSequenciaDeItems(parentNode)

            End If

        Else
            item = New Control_ControleDePasta

        End If


        Return item
    End Function



    Public Overloads Function AdicionarUmItem()
        Dim controleDePasta As New Control_ControleDePasta With {
            .Dock = DockStyle.Left,
            .SelectedNode = New TreeNode(defaultText),
            .AddressBar = Me,
            .CMenuToExpandOptionsButton = _cMenuToExpandOptionsButton
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
            .CMenuToExpandOptionsButton = _cMenuToExpandOptionsButton
        }
        If node IsNot Nothing Then
            controleDePasta.Level = node.Level
        End If

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
             .AddressBar = Me,
            .CMenuToExpandOptionsButton = _cMenuToExpandOptionsButton
        }

        ' .Text = node.Text,

        ControlesDePastas.Add(controleDePasta)
        PanelRecebeControlesDePastas.Controls.Add(controleDePasta)

        controleDePasta.Visible = True

        Return controleDePasta
    End Function

    Private Sub PanelExibirControlesDePastas_Click(sender As Object, e As EventArgs) Handles PanelExibirControlesDePastas.Click

        DisplayMode = DisplayModeEnum.TextMode

    End Sub



    Private Sub BorderColorChange(color As Color)
        PanelBorder.BackColor = color
        PanelBorderReflesh.BackColor = color
    End Sub

    Private Sub TXTWriteAddress_LostFocus(sender As Object, e As EventArgs) Handles TXTWriteAddress.LostFocus
        If ForceTextMode = False Then
            DisplayMode = DisplayModeEnum.FoldersControlsMode

        End If

    End Sub

    Overloads Function CriarListaDeOpcoesParaAutoCompleteCustomSource()
        TXTWriteAddress.AutoCompleteCustomSource.Clear()

        'ListarAutoCompleteCustomSource(_selectedNode)

        TXTWriteAddress.AutoCompleteCustomSource.AddRange(ListarAutoCompleteCustomSource(_selectedNode))

    End Function

    Overloads Function CriarListaDeOpcoesParaAutoCompleteCustomSource(path As String)
        TXTWriteAddress.AutoCompleteCustomSource.Clear()

        'ListarAutoCompleteCustomSource(_selectedNode)

        TXTWriteAddress.AutoCompleteCustomSource.AddRange(ListarAutoCompleteCustomSource(path))

    End Function

    Overloads Function ListarAutoCompleteCustomSource(node As TreeNode) As String()
        Dim folder As DirectoryInfo
        Dim autoCompleteString As String()
        Dim autoComplete As New List(Of String)


        If node IsNot Nothing Then

            If node.Tag IsNot Nothing Then

            End If

            folder = New DirectoryInfo(node.Tag)

            If folder.Exists Then
                autoCompleteString = ListarArquivosOuPastasParentes(node.Tag)
            End If

            If autoCompleteString IsNot Nothing Then
                autoComplete.AddRange(autoCompleteString)

            End If

        End If


        'Dim irmaos As TreeNodeCollection
        'irmaos = nodeManipulatior.ListarNodosIrmaos(node)

        'If irmaos IsNot Nothing Then
        '    autoCompleteString = ListarNodesFilhos(irmaos)
        'Else
        '    autoCompleteString = ListarNodesFilhos(node)
        'End If

        'For Each str As String In autoCompleteString
        '    autoComplete.Add(str)
        'Next

        Return autoComplete.ToArray

    End Function

    Overloads Function ListarAutoCompleteCustomSource(path As String) As String()
        Dim folder As New DirectoryInfo(path)
        Dim autoCompleteString As String()
        Dim autoComplete As New List(Of String)


        If folder.Exists Then
            autoCompleteString = ListarArquivosOuPastasParentes(path)


        End If

        If autoCompleteString IsNot Nothing Then
            autoComplete.AddRange(autoCompleteString)

        End If

        'Dim irmaos As TreeNodeCollection
        'irmaos = nodeManipulatior.ListarNodosIrmaos(node)

        'If irmaos IsNot Nothing Then
        '    autoCompleteString = ListarNodesFilhos(irmaos)
        'Else
        '    autoCompleteString = ListarNodesFilhos(node)
        'End If

        'For Each str As String In autoCompleteString
        '    autoComplete.Add(str)
        'Next

        Return autoComplete.ToArray

    End Function

    Function ListarItensParentes(path As String)
        Dim listaDeItens As List(Of String)
        ' Lista os arquivos e pastas que são parentes ao item do caminho apresentado
        Dim folder As New DirectoryInfo(path)

        If folder.Exists = True Then
            ' Lista os arquivos e pastas parentes
            ' adiciona na lsita para retornar
        Else
            ' Localizar o node com base no caminho apresentado
            ' Se Existir o node então ...
            '       Lista os nodes parentes
        End If
    End Function

    ' Colocar esta função em uma classe especifica
    Function ListarArquivosOuPastasParentes(path As String)
        Dim folder As New DirectoryInfo(path)
        Dim listaDePastasEArquivos As New List(Of String)

        Dim subPasta As DirectoryInfo

        If folder.Parent IsNot Nothing Then
            If path.Chars(path.Length - 1).ToString = _selectedTreeView.PathSeparator Then
                subPasta = folder

            Else
                subPasta = folder.Parent

            End If



        ElseIf folder.Root.FullName = folder.FullName Then
            'MsgBox("VVV")
            listaDePastasEArquivos.Clear()
            Return listaDePastasEArquivos.ToArray
        End If

        If folder.Exists = True Then
            listaDePastasEArquivos.AddRange(subPasta.GetDirectories().Select(Function(subFolder) subFolder.FullName))
            listaDePastasEArquivos.AddRange(subPasta.GetFiles().Select(Function(file) file.FullName))

            'listaDePastasEArquivos.AddRange(New System.IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).GetFiles.Select(Function(f) f.FullName))


        End If
        Return listaDePastasEArquivos.ToArray

    End Function

    Overloads Function ListarNodesFilhos(node As TreeNode) As String()

        Dim autoComplete As New List(Of String)
        Dim autoCompleteString As String()
        autoComplete.Add(node.Tag)

        If node.GetNodeCount(True) > 0 Then

            For Each item As TreeNode In node.Nodes
                If item.Name <> "carregando" And item.Name <> "info" Then
                    autoCompleteString = ListarNodesFilhos(item)
                End If

                If autoCompleteString IsNot Nothing Then
                    For Each str As String In autoCompleteString
                        autoComplete.Add(str)
                    Next
                End If

            Next

        End If

        Return autoComplete.ToArray

    End Function

    Overloads Function ListarNodesFilhos(nodeCollection As TreeNodeCollection) As String()

        Dim autoComplete As New List(Of String)
        Dim autoCompleteString As String()

        For Each item As TreeNode In nodeCollection
            autoCompleteString = ListarNodesFilhos(item)

            For Each str As String In autoCompleteString
                autoComplete.Add(str)
            Next

        Next

        Return autoComplete.ToArray

    End Function

    Private Sub TXTWriteAddress_TextChanged(sender As Object, e As EventArgs) Handles TXTWriteAddress.TextChanged
        confirmar = 0
    End Sub


    Private Sub TXTWriteAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTWriteAddress.KeyPress

        ''ForceFoldersControlsMode = True

        'Dim pathStr As String
        'pathStr = TXTWriteAddress.Text

        ''MsgBox(Asc(e.KeyChar))

        'If Asc(e.KeyChar) = 13 Then

        '    DisplayMode = DisplayModeEnum.FoldersControlsMode
        '    ForceTextMode = False

        '    'ElseIf e.KeyChar = _selectedTreeView.PathSeparator Then

        '    '    SendKeys.Send((e.KeyChar))
        '    '    CriarListaDeOpcoesParaAutoCompleteCustomSource(pathStr)

        'End If





    End Sub

    Private Sub TXTWriteAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTWriteAddress.KeyDown
        '    'Dim tc As New System.ComponentModel.TypeConverter
        '    'MsgBox()
        '    Dim KeyPress As String = Chr(e.KeyValue)
        '    Dim pathStr As String
        '    pathStr = TXTWriteAddress.Text

        '    MsgBox(e.KeyCode)


        '    'MsgBox(tc.ConvertFromString(_selectedTreeView.PathSeparator).ToString)

        '    If Keys.OemPip = _selectedTreeView.PathSeparator Then
        '        CriarListaDeOpcoesParaAutoCompleteCustomSource(pathStr)
        '    End If
    End Sub

    Private Sub TXTWriteAddress_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTWriteAddress.KeyUp

        ForceTextMode = True

        Dim last As String
        Dim pathStr As String

        pathStr = TXTWriteAddress.Text

        If pathStr.Length > 0 Then
            last = pathStr.Chars(pathStr.Length - 1).ToString

        End If


        If last = _selectedTreeView.PathSeparator Then

            CriarListaDeOpcoesParaAutoCompleteCustomSource(pathStr)
        End If

        If e.KeyCode = Keys.Enter Then
            Dim arquivo As FileInfo
            Dim caminho As DirectoryInfo

            arquivo = New FileInfo(pathStr)

            If arquivo.Exists = True Then
                caminho = New DirectoryInfo(arquivo.DirectoryName)

            Else
                caminho = New DirectoryInfo(pathStr)
            End If


            If caminho.Exists = False And arquivo.Exists = False Then

                DisplayMode = DisplayModeEnum.TextMode
                ForceTextMode = True
                If confirmar <> 1 Then
                    confirmar = MsgBox("O " & My.Application.Info.Title & " não encotrou o caminho " & """" & TXTWriteAddress.Text & """")
                End If

                TXTWriteAddress.Focus()


            Else
                DisplayMode = DisplayModeEnum.FoldersControlsMode
                ForceTextMode = False

            End If


        End If


    End Sub

End Class
