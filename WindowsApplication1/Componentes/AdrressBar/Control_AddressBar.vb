Imports System.Data.SqlTypes
Imports System.IO
Imports System.Security.Cryptography


Public Class Control_AddressBar

    'Inherits UsesDirectoriesClass


    'Dim confirmar As Byte
    'Importação de Classes
    '------------------------------------------------------
    'Dim nodeManipulatior As New Class_NodeManipulator
    ' TODO: Esta classe deveria ser herdada?
    Private ReadOnly usesDirectories As New UsesDirectoriesClass
    '------------------------------------------------------

    Private Shadows keyPress As Char
    Dim keyUpDown As Boolean

    Dim precionadaBarra As Boolean
    Dim ultimoEhBarra As Boolean
    Dim podeBuscarSugestoes As Boolean = True
    ReadOnly caminhoSugerido As String
    Dim backspacePress As Boolean
    Dim lastCharStr As String = ""

    Dim folder As DirectoryInfo
    Dim folderParent As DirectoryInfo

    ' TODO: Vc pode transformar isso em uma propriedade
    Private _autoCompleteCustomSourcePath As New AutoCompleteStringCollection
    Dim autoCompleteCustomSourceParentPath As New AutoCompleteStringCollection

    Dim caminho As String
    Dim caminhoParent As String

    ReadOnly contador As Integer

    Dim ForceTextMode As Boolean

    Public ControlesDePastas As New List(Of Control_ControleDePasta)
    Const defaultText As String = "Node"

    'Private _initialPath As String
    'Private Property InitialPath As String
    '    Get
    '        Return _initialPath
    '    End Get
    '    Set(value As String)
    '        _initialPath = value

    '    End Set
    'End Property

    Private _folderMode As Boolean
    Public Property FolderMode As Boolean
        Get
            Return _folderMode
        End Get
        Set(value As Boolean)
            _folderMode = value
        End Set
    End Property

    Private _keyword As New KeywordsNodeItem
    Public Property Keyword() As KeywordsNodeItem
        Get
            Return _keyword

        End Get
        Set(value As KeywordsNodeItem)
            _keyword = value

        End Set
    End Property

    Private _keywordsNodeCollecions As New Class_KeywordsNodeCollections
    Public Property KeywordsNodeCollections() As Class_KeywordsNodeCollections
        Get
            Return _keywordsNodeCollecions
        End Get
        Set(value As Class_KeywordsNodeCollections)
            _keywordsNodeCollecions = value

        End Set
    End Property

    Private ReadOnly _treeNode As New TreeNode
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

    ReadOnly colorLostFocus As Color = Color.Gainsboro
    ReadOnly colorFocus As Color = Color.SkyBlue ' ColorTranslator.FromHtml(KnownColor.Highlight)

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
                        TXTWriteAddress.Text = MainNode.Tag.ToString

                    End If

                    TXTWriteAddress.Focus()
                    Panel_EnvolveTXT.BringToFront()

            End Select
        End Set
    End Property

    Private _address As String
    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)

            If value Is Nothing Then
                value = TXTWriteAddress.Text

            End If

            _address = value

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
                    TXTWriteAddress.Text = _mainNode.Tag.ToString
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

    Private _pathSeparator As String
    Public Property PathSeparator As String
        Get
            Return _pathSeparator
        End Get
        Set(value As String)
            _pathSeparator = value

            If _selectedTreeView IsNot Nothing Then
                _selectedTreeView.PathSeparator = value

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

            _pathSeparator = _selectedTreeView.PathSeparator

            If value IsNot Nothing Then
                If TypeOf value.Tag Is Class_KeywordsNodeCollections Then
                    _keywordsNodeCollecions = CType(value.Tag, Class_KeywordsNodeCollections)
                End If
            End If

        End Set
    End Property

    Private _selectedNode As TreeNode
    Public Property SelectedNode As TreeNode
        Get
            Return _selectedNode
        End Get

        Set(value As TreeNode)

            _selectedNode = value

            'CriarListaDeOpcoesParaAutoCompleteCustomSource()

            ListarArquivosOuPastasParentes(_selectedNode.Tag)

            If value IsNot Nothing Then
                If TypeOf _selectedNode.Tag Is String Then
                    TXTWriteAddress.Text = _selectedNode.Tag.ToString
                    'caminhoSugerido = (usesDirectories.SubirAteUmNivelValido(New DirectoryInfo(_selectedNode.Tag.ToString))).FullName
                End If

                If value.TreeView IsNot Nothing Then
                    SelectedTreeView = value.TreeView
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

        If _selectedTreeView IsNot Nothing Then
            _pathSeparator = _selectedTreeView.PathSeparator

        End If
        TXTWriteAddress.AutoCompleteCustomSource = _autoCompleteCustomSourcePath
        'AddHandler TXTWriteAddress.KeyPress, AddressOf keyPressed
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

            'Dim unused As New List(Of TreeNode)

            Dim nodeParentList As List(Of TreeNode) = CriarUmaListaDeNodeParent(node)

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
        'Dim unused As New List(Of TreeNode)

        Dim parentNode As TreeNode

        If node.Parent IsNot Nothing Then
            parentNode = node.Parent

            Dim _nodeParentList As List(Of TreeNode) = CriarUmaListaDeNodeParent(parentNode)

            For Each item As TreeNode In _nodeParentList

                nodeParentList.Add(item)
            Next

        End If


        nodeParentList.Add(node)

        Return nodeParentList
    End Function

    Public Function CriarSequenciaDeItems(node As TreeNode) As Control_ControleDePasta

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

    Public Overloads Function AdicionarUmItem() As Control_ControleDePasta
        Dim controleDePasta As New Control_ControleDePasta With {
            .Dock = DockStyle.Left,
            .SelectedNode = New TreeNode(defaultText),
            .AddressBar = Me,
            .CMenuToExpandOptionsButton = _cMenuToExpandOptionsButton
        }

        controleDePasta.SelectedNode.Tag = controleDePasta.Text

        ControlesDePastas.Add(controleDePasta)
        PanelRecebeControlesDePastas.Controls.Add(controleDePasta)

        controleDePasta.Visible = True

        Return controleDePasta

    End Function

    Public Overloads Function AdicionarUmItem(node As TreeNode, pos As Integer) As Control_ControleDePasta

        Dim controleDePasta As New Control_ControleDePasta With {
            .Dock = DockStyle.Left,
            .SelectedNode = node,
            .AddressBar = Me,
            .CMenuToExpandOptionsButton = _cMenuToExpandOptionsButton
        }
        If node IsNot Nothing Then
            controleDePasta.Level = node.Level
        End If

        PanelRecebeControlesDePastas.Controls.Add(controleDePasta)
        ControlesDePastas.Insert(pos, controleDePasta)

        controleDePasta.Visible = True

        Return controleDePasta

    End Function

    Public Overloads Function AdicionarUmItem(node As TreeNode) As Control_ControleDePasta
        Dim controleDePasta As New Control_ControleDePasta With {
            .Dock = DockStyle.Left,
            .SelectedNode = node,
             .AddressBar = Me,
            .CMenuToExpandOptionsButton = _cMenuToExpandOptionsButton
        }

        ControlesDePastas.Add(controleDePasta)
        PanelRecebeControlesDePastas.Controls.Add(controleDePasta)

        controleDePasta.Visible = True

        Return controleDePasta
    End Function

    Private Sub PanelExibirControlesDePastas_Click(sender As Object, e As EventArgs) Handles PanelExibirControlesDePastas.Click

        DisplayMode = DisplayModeEnum.TextMode
        'ForceTextMode = True

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

    'Overloads Sub CriarListaDeOpcoesParaAutoCompleteCustomSource()
    '    TXTWriteAddress.AutoCompleteCustomSource.Clear()

    '    'ListarAutoCompleteCustomSource(_selectedNode)

    '    TXTWriteAddress.AutoCompleteCustomSource.AddRange(ListarAutoCompleteCustomSource(_selectedNode))

    'End Sub

    'Overloads Sub CriarListaDeOpcoesParaAutoCompleteCustomSource(path As String)
    '    TXTWriteAddress.AutoCompleteCustomSource.Clear()

    '    'ListarAutoCompleteCustomSource(_selectedNode)

    '    TXTWriteAddress.AutoCompleteCustomSource.AddRange(ListarAutoCompleteCustomSource(path + " "))
    '    'TXTWriteAddress.AutoCompleteCustomSource

    'End Sub

    'Overloads Function ListarAutoCompleteCustomSource(node As TreeNode) As String()
    '    Dim folder As DirectoryInfo
    '    Dim autoCompleteString As String()
    '    Dim autoComplete As New List(Of String)


    '    If node IsNot Nothing Then

    '        If node.Tag IsNot Nothing Then

    '        End If

    '        folder = New DirectoryInfo(node.Tag)

    '        If folder.Exists Then
    '            autoCompleteString = ListarArquivosOuPastasParentes(node.Tag)
    '        End If

    '        If autoCompleteString IsNot Nothing Then
    '            autoComplete.AddRange(autoCompleteString)

    '        End If

    '    End If


    '    'Dim irmaos As TreeNodeCollection
    '    'irmaos = nodeManipulatior.ListarNodosIrmaos(node)

    '    'If irmaos IsNot Nothing Then
    '    '    autoCompleteString = ListarNodesFilhos(irmaos)
    '    'Else
    '    '    autoCompleteString = ListarNodesFilhos(node)
    '    'End If

    '    'For Each str As String In autoCompleteString
    '    '    autoComplete.Add(str)
    '    'Next

    '    Return autoComplete.ToArray

    'End Function

    'Overloads Function ListarAutoCompleteCustomSource(path As String) As String()
    '    Dim folder As DirectoryInfo
    '    Dim autoCompleteString As String()
    '    'Dim autoComplete As New List(Of String)

    '    'If Trim(path) <> "" Then
    '    folder = New DirectoryInfo(Trim(path))

    '    If folder.Exists Then
    '        autoCompleteString = ListarArquivosOuPastasParentes(path)
    '    End If

    '    'If autoCompleteString IsNot Nothing Then
    '    '    autoComplete.AddRange(autoCompleteString)

    '    'End If
    '    'End If

    '    ' Return autoComplete.ToArray
    '    Return autoCompleteString.ToArray

    'End Function

    Function ListarItensParentes(path As String) As List(Of String)
        Dim listaDeItens As New List(Of String)

        ' Lista os arquivos e pastas que são parentes ao item do caminho apresentado
        Dim folder As New DirectoryInfo(path)

        If folder.Exists = True Then
            ' Lista os arquivos e pastas parentes
            ' adiciona na lista para retornar
            listaDeItens.Add(folder.Parent.FullName.ToString)
        Else
            ' Localizar o node com base no caminho apresentado
            ' Se Existir o node então ...
            '       Lista os nodes parentes
        End If
        Return listaDeItens
    End Function

    ' Colocar esta função em uma classe especifica

    Overloads Function ListarArquivosOuPastasParentes(path As String, forceListParentFolder As Boolean) As String()

        Dim folder As New DirectoryInfo(Trim(path))
        Dim parentFolder As DirectoryInfo
        Dim listaDePastasEArquivos As New List(Of String)

        If forceListParentFolder = True Then
            'If folder.Exists Then

            parentFolder = usesDirectories.SubirAteUmNivelValido(folder)
            listaDePastasEArquivos.AddRange(ListarArquivosOuPastasParentes(parentFolder))

            'End If

        Else
            If folder.Exists Then
                listaDePastasEArquivos.AddRange(ListarArquivosOuPastasParentes(folder))
            Else
                parentFolder = usesDirectories.SubirAteUmNivelValido(folder)
                listaDePastasEArquivos.AddRange(ListarArquivosOuPastasParentes(parentFolder))
            End If

        End If

        Return listaDePastasEArquivos.ToArray
    End Function

    Overloads Function ListarArquivosOuPastasParentes(path As String) As String()

        Dim folder As New DirectoryInfo(Trim(path))
        Dim parentFolder As DirectoryInfo

        Dim listaDePastasEArquivos As New List(Of String)

        If folder.Exists Then
            listaDePastasEArquivos.AddRange(ListarArquivosOuPastasParentes(folder))
        Else
            parentFolder = usesDirectories.SubirAteUmNivelValido(folder)
            listaDePastasEArquivos.AddRange(ListarArquivosOuPastasParentes(parentFolder))
        End If

        Return listaDePastasEArquivos.ToArray

    End Function

    Overloads Function ListarArquivosOuPastasParentes(folder As DirectoryInfo) As String()
        Dim listaDePastasEArquivos As New List(Of String)

        Try
            If folder.Exists = True Then
                listaDePastasEArquivos.AddRange(folder.GetDirectories().Select(Function(subFolder) subFolder.FullName))
                listaDePastasEArquivos.AddRange(folder.GetFiles().Select(Function(file) file.FullName))
                'listaDePastasEArquivos.AddRange(New System.IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).GetFiles.Select(Function(f) f.FullName))
            End If

        Catch ex As Exception
            Return listaDePastasEArquivos.ToArray
        End Try

        Return listaDePastasEArquivos.ToArray
    End Function

    Overloads Function ListarNodesFilhos(node As TreeNode) As String()

        Dim autoComplete As New List(Of String)
        Dim autoCompleteString As String() = {}
        autoComplete.Add(node.Tag.ToString)

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

    Function ChecarSePathEhKeywordESelecionarNodeAssociado(pathStr As String) As Boolean
        ' Procedimento para Função ChecarKeywordInNode
        '------------------------------------------------------------


        Dim selected As Boolean
        For Each nodeWithKeyword As KeywordsNodeItem In _keywordsNodeCollecions.KeywordsNodeItens


            For Each key In nodeWithKeyword.Keywords

                If key = pathStr Then
                    'Dim node As TreeNode
                    If SelectedNode IsNot nodeWithKeyword.NodeAssociated Then
                        SelectedNode = nodeWithKeyword.NodeAssociated
                    End If

                    ForceTextMode = False
                    selected = True
                    DisplayMode = DisplayModeEnum.FoldersControlsMode
                    Return selected

                End If

            Next

        Next
        Return selected
        '------------------------------------------------------------
    End Function

    Private Function ChecarSeUltimoEhBarra(pathStr As String) As Boolean
        If pathStr.Length > 0 Then
            Dim index As Integer = pathStr.Length - 1

            If index >= 0 Then
                lastCharStr = pathStr.Chars(index).ToString
            End If

        End If

        Return (lastCharStr = _pathSeparator)

    End Function

    Private Sub TXTWriteAddress_TextChanged(sender As Object, e As EventArgs) Handles TXTWriteAddress.TextChanged
        _address = TXTWriteAddress.Text
    End Sub

    Private Sub TXTWriteAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTWriteAddress.KeyDown

        'ForceTextMode = Not (e.KeyCode = Keys.Enter)

        'If e.KeyCode = Keys.Enter Then
        '    ForceTextMode = False


        '    ' TODO: ForceTextMode vai ser true quando: 

        '    ' Checar se o caminho é valido:
        '    ' Se ccaminho é valido entao 
        '    '       ForceTextMode = False
        '    'Senao 
        '    '       ForceTextMode = true
        '    '       mensagem de erro

        'Else
        '    ForceTextMode = True
        'End If



        Dim pathStr As String

        pathStr = TXTWriteAddress.Text



        backspacePress = (e.KeyData = Keys.Back)

        'ultimoEhBarra = (lastCharStr = _selectedTreeView.PathSeparator)

    End Sub

    Private Sub TXTWriteAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTWriteAddress.KeyPress

        keyPress = e.KeyChar

        'If Asc(e.KeyChar) = 13 Then

        '    ForceTextMode = False

        '    DisplayMode = DisplayModeEnum.FoldersControlsMode
        '    MsgBox("Enter")
        'End If

        precionadaBarra = (keyPress = _pathSeparator)

    End Sub

    Private Sub TXTWriteAddress_KeyUp(sender As Object, e As KeyEventArgs) Handles TXTWriteAddress.KeyUp

        If _address = "" Then Exit Sub

        folder = New DirectoryInfo(_address)

        Dim _caminhoParent As String = usesDirectories.SubirAteUmNivelValido(folder).FullName

        folderParent = New DirectoryInfo(_caminhoParent)

        If e.KeyCode = Keys.Enter Then


            If folderParent.Exists Then
                If folder.Exists Then
                    ForceTextMode = False

                Else

                    ' TODO:  Opçoes de checagem
                    ' Checar as Chaves
                    ' Se a chaves exixtirem escrever
                    ' Se nao Executar code abaixo

                    Dim keyExists As Boolean = False
                    For Each _kwNItem As KeywordsNodeItem In _keywordsNodeCollecions.KeywordsNodeItens

                        For Each _keyword As String In _kwNItem.Keywords
                            MsgBox(_keyword)
                            If TXTWriteAddress.Text = _keyword Then

                                TXTWriteAddress.Text = _kwNItem.NodeAssociated.Tag
                                ' TODO: Selecionar o node associado 
                                keyExists = True
                                Exit For
                            End If

                        Next

                        If keyExists = True Then Exit For

                    Next


                    If keyExists = False Then
                        ForceTextMode = True
                        MsgBox("O Trevo Web Media não pode encontrar o caminho " + "'" + folder.FullName.ToString + "'" + ". certifique-se de que digitou o caminho corretamente.", MsgBoxStyle.Critical)
                        ForceTextMode = False
                        Exit Sub

                    End If


                End If
                    Else
                ForceTextMode = True

            End If

        Else
            ForceTextMode = True
        End If


        If ForceTextMode = False Then
            DisplayMode = DisplayModeEnum.FoldersControlsMode
            TXTWriteAddress.Text = Trim(_address)
        End If

        ultimoEhBarra = ChecarSeUltimoEhBarra(_address)

        keyUpDown = (e.KeyValue = Keys.Up) Or (e.KeyValue = Keys.Down)

        Try

            If keyUpDown = False Then

                folder = New DirectoryInfo(_address)

                _caminhoParent = usesDirectories.SubirAteUmNivelValido(folder).FullName

                folderParent = New DirectoryInfo(_caminhoParent)

                ' Atualizar listas 

                'autoCompleteCustomSourcePath
                'autoCompleteCustomSourceParentPath

                'autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folder.FullName.ToString))

                'If folder.Exists Then
                '    'Dim _autoCompleteCustomSourcePath As New AutoCompleteStringCollection
                '    '_autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folder.Parent.FullName.ToString))

                'End If


                If backspacePress = False Then
                    If ultimoEhBarra = True Then
                        If folder.Exists Then
                            _autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folder.FullName.ToString))

                        Else
                            If folder.Parent IsNot Nothing Then

                                _autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folder.Parent.FullName.ToString))
                            End If
                        End If
                    End If
                    'Dim result As String

                    'result = "Private Shadows keyPress As Char" & ChrW(13) &
                    'keyPress & ChrW(13) & ChrW(13) &
                    '"Dim keyUpDown As Boolean" & ChrW(13) &
                    ' keyUpDown & ChrW(13) & ChrW(13) &
                    '"Dim precionadaBarra As Boolean" & ChrW(13) &
                    ' precionadaBarra & ChrW(13) & ChrW(13) &
                    '"Dim ultimoEhBarra As Boolean" & ChrW(13) &
                    ' ultimoEhBarra & ChrW(13) & ChrW(13) &
                    '"Dim podeBuscarSugestoes As Boolean" & ChrW(13) &
                    ' podeBuscarSugestoes & ChrW(13) & ChrW(13) &
                    '"Dim caminhoSugerido As String" & ChrW(13) &
                    ' caminhoSugerido & ChrW(13) & ChrW(13) &
                    '"Dim backspacePress As Boolean" & ChrW(13) &
                    ' backspacePress & ChrW(13) & ChrW(13) &
                    '"Dim lastCharStr As String" & ChrW(13) &
                    ' lastCharStr & ChrW(13) & ChrW(13) &
                    '"Dim caminho As String" & ChrW(13) &
                    ' caminho & ChrW(13) & ChrW(13) &
                    '"Dim caminhoParent As String" & ChrW(13) &
                    ' caminhoParent & ChrW(13) & ChrW(13) &
                    ' "Dim _caminhoParent As String" & ChrW(13) &
                    ' _caminhoParent & ChrW(13) & ChrW(13) &
                    '"Dim contador As Integer" & ChrW(13) &
                    ' contador & ChrW(13) & ChrW(13)

                    'MsgBox(result)

                    'Select Case caminho
                    '    Case Nothing

                    '        If precionadaBarra = True Then

                    '        Else

                    '        End If

                    '        If folder.Parent IsNot Nothing Then
                    '            autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folder.Parent.FullName.ToString))

                    '        Else
                    '            autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folder.FullName.ToString))

                    '        End If

                    '    Case _caminhoParent

                    '        If precionadaBarra = False Then

                    '            If folder.Parent IsNot Nothing Then
                    '                autoCompleteCustomSourcePath.Clear()

                    '                autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folder.Parent.FullName.ToString))

                    '            Else
                    '                autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folder.FullName.ToString))

                    '            End If

                    '            TXTWriteAddress.AutoCompleteCustomSource = autoCompleteCustomSourcePath

                    '            'podeBuscarSugestoes = True

                    '        End If
                    '    Case Else

                    '        If folder.Exists Then
                    '            If precionadaBarra = False Then autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folder.FullName.ToString))
                    '        End If

                    'End Select

                Else
                    If ultimoEhBarra = False Then
                        If folder.Exists Then
                            _autoCompleteCustomSourcePath.Clear()
                            If folder.Parent IsNot Nothing Then
                                _autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folder.Parent.FullName.ToString))
                            Else
                                _autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folder.FullName.ToString))

                            End If
                        End If

                    End If
                    'Dim result As String

                    'result = "Private Shadows keyPress As Char" & ChrW(13) &
                    'keyPress & ChrW(13) & ChrW(13) &
                    '"Dim keyUpDown As Boolean" & ChrW(13) &
                    ' keyUpDown & ChrW(13) & ChrW(13) &
                    '"Dim precionadaBarra As Boolean" & ChrW(13) &
                    ' precionadaBarra & ChrW(13) & ChrW(13) &
                    '"Dim ultimoEhBarra As Boolean" & ChrW(13) &
                    ' ultimoEhBarra & ChrW(13) & ChrW(13) &
                    '"Dim podeBuscarSugestoes As Boolean" & ChrW(13) &
                    ' podeBuscarSugestoes & ChrW(13) & ChrW(13) &
                    '"Dim caminhoSugerido As String" & ChrW(13) &
                    ' caminhoSugerido & ChrW(13) & ChrW(13) &
                    '"Dim backspacePress As Boolean" & ChrW(13) &
                    ' backspacePress & ChrW(13) & ChrW(13) &
                    '"Dim lastCharStr As String" & ChrW(13) &
                    ' lastCharStr & ChrW(13) & ChrW(13) &
                    '"Dim caminho As String" & ChrW(13) &
                    ' caminho & ChrW(13) & ChrW(13) &
                    '"Dim caminhoParent As String" & ChrW(13) &
                    ' caminhoParent & ChrW(13) & ChrW(13) &
                    ' "Dim _caminhoParent As String" & ChrW(13) &
                    ' _caminhoParent & ChrW(13) & ChrW(13) &
                    '"Dim contador As Integer" & ChrW(13) &
                    ' contador & ChrW(13) & ChrW(13)

                    'MsgBox(result)

                    'If caminhoParent <> _caminhoParent Then
                    '    caminhoParent = _caminhoParent
                    '    folderParent = New DirectoryInfo(caminhoParent)

                    '    podeBuscarSugestoes = ultimoEhBarra
                    '    ' MsgBox(result)
                    '    If podeBuscarSugestoes = True Then
                    '        autoCompleteCustomSourcePath.Clear()
                    '        autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folder.FullName.ToString, True))

                    '        TXTWriteAddress.AutoCompleteCustomSource = autoCompleteCustomSourcePath
                    '        podeBuscarSugestoes = False
                    '    End If

                    '    'End If

                    'Else
                    '    If ultimoEhBarra = False Then
                    '        If folder.Exists Then
                    '            autoCompleteCustomSourcePath.Clear()
                    '            autoCompleteCustomSourcePath.AddRange(ListarArquivosOuPastasParentes(folderParent.FullName.ToString, True))

                    '            TXTWriteAddress.AutoCompleteCustomSource = autoCompleteCustomSourcePath
                    '        End If
                    '    End If
                    'End If

                End If
            End If

            caminho = TXTWriteAddress.Text
        Catch ex As Exception
            podeBuscarSugestoes = True
        End Try

        'Dim lastChar As New List(Of Char)
        'Dim lastCharStr As String = ""
        'Dim pathStr As String
        ''Dim kc As KeysConverter = New KeysConverter()
        'Dim caminhoValido As Boolean

        'Dim arquivo As FileInfo
        'Dim folder As DirectoryInfo

        'pathStr = TXTWriteAddress.Text

        'Try


        '    ' Programar 3 modos para pesquisa de endereço
        '    ' MODODiretorio
        '    ' MODOKey
        '    ' MODOFullName

        '    ' TODO: Refaturar codigo que adiciona itens nas opçoes

        '    folder = New DirectoryInfo(pathStr)

        '    Dim parentFolder As DirectoryInfo = (usesDirectories.SubirAteUmNivelValido(folder))


        '    If backspacePress = False Then
        '        If ultimoEhBarra = False And precionadaBarra = True Then
        '            podeBuscarSugestoes = (caminhoSugerido <> folder.FullName)

        '            If folder.Exists Then
        '                'If podeBuscarSugestoes = True Then CriarListaDeOpcoesParaAutoCompleteCustomSource(folder.FullName.ToString)
        '                caminhoSugerido = folder.FullName
        '                contador = 0
        '            End If

        '        ElseIf ultimoEhBarra = True And precionadaBarra = False Then
        '            contador += 1

        '        ElseIf ultimoEhBarra = False And precionadaBarra = False Then
        '            podeBuscarSugestoes = (caminhoSugerido <> parentFolder.FullName) And contador = 0

        '            If lastCharStr = ":" Then podeBuscarSugestoes = True
        '            If folder.Exists Then
        '                If keyPress = ":" Then

        '                    CriarListaDeOpcoesParaAutoCompleteCustomSource(folder.Root.FullName.ToString)
        '                Else
        '                    CriarListaDeOpcoesParaAutoCompleteCustomSource(folder.FullName.ToString)

        '                End If
        '                contador += 1
        '            Else
        '                If podeBuscarSugestoes = True Then
        '                    CriarListaDeOpcoesParaAutoCompleteCustomSource(parentFolder.FullName.ToString)
        '                    contador += 1
        '                End If
        '            End If

        '            caminhoSugerido = parentFolder.FullName
        '        End If

        '    Else
        '        If ultimoEhBarra = True Then
        '            If ultimoEhBarra = True Then
        '                'TODO : Reconhecer drive aqui
        '                CriarListaDeOpcoesParaAutoCompleteCustomSource(parentFolder.FullName.ToString)
        '            End If
        '        End If
        '    End If
        '    MsgBox(TXTWriteAddress.Modified)
        'Catch ex As Exception
        '    contador = 0

        'End Try

    End Sub

    Private Sub TXTWriteAddress_ModifiedChanged(sender As Object, e As EventArgs) Handles TXTWriteAddress.ModifiedChanged



    End Sub

    Private Sub BTNExpandir_Click(sender As Object, e As EventArgs) Handles BTNExpandir.Click
        Dim result As String

        result = "Private Shadows keyPress As Char" & ChrW(13) &
                    keyPress & ChrW(13) & ChrW(13) &
                    "Dim keyUpDown As Boolean" & ChrW(13) &
                     keyUpDown & ChrW(13) & ChrW(13) &
                    "Dim precionadaBarra As Boolean" & ChrW(13) &
                     precionadaBarra & ChrW(13) & ChrW(13) &
                    "Dim ultimoEhBarra As Boolean" & ChrW(13) &
                     ultimoEhBarra & ChrW(13) & ChrW(13) &
                    "Dim podeBuscarSugestoes As Boolean" & ChrW(13) &
                     podeBuscarSugestoes & ChrW(13) & ChrW(13) &
                    "Dim caminhoSugerido As String" & ChrW(13) &
                     caminhoSugerido & ChrW(13) & ChrW(13) &
                    "Dim backspacePress As Boolean" & ChrW(13) &
                     backspacePress & ChrW(13) & ChrW(13) &
                    "Dim lastCharStr As String" & ChrW(13) &
                     lastCharStr & ChrW(13) & ChrW(13) &
                    "Dim caminho As String" & ChrW(13) &
                     caminho & ChrW(13) & ChrW(13) &
                    "Dim caminhoParent As String" & ChrW(13) &
                     caminhoParent & ChrW(13) & ChrW(13) &
                    "Dim contador As Integer" & ChrW(13) &
                     contador & ChrW(13) & ChrW(13)

        MsgBox(result)
    End Sub

    'Private Sub keyPressed(ByVal o As [Object], ByVal e As KeyPressEventArgs)
    '    If e.KeyChar = "\" Then
    '        MsgBox("\")
    '    End If
    'End Sub

End Class
