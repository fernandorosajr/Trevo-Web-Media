Imports System.ComponentModel

Public Class Class_NodesCollectionWithKeywords
    ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/objects-and-classes/
    ' http://www.macoratti.net/vbn_ams1.htm

    Private Shared Instancias As Integer


    Private _items As New Collection
    Public Property Items As Collection
        Get
            Return _items
        End Get
        Set(value As Collection)
            _items = value
        End Set
    End Property


    Public Sub New()
        Instancias += 1

    End Sub

    Public Sub New(keywordText As String, node As TreeNode)

        Dim keywordItem As New NodeWithKeywordsItem(keywordText, node)
        Items.Add(keywordItem)

    End Sub

    Public Sub New(keywordsCollections As Collections.Specialized.StringCollection, node As TreeNode)

        Dim keywordItem As New NodeWithKeywordsItem(keywordsCollections, node)
        Items.Add(keywordItem)

    End Sub

    Public Sub New(keywordItem As NodeWithKeywordsItem)
        Dim keyText As Collections.Specialized.StringCollection = keywordItem.Keywords
        Dim nodeAssociated As New TreeNode

        nodeAssociated = keywordItem.NodeAssociated
        Dim keyItem As New NodeWithKeywordsItem(keyText, nodeAssociated)

        Items.Add(keywordItem)

        Instancias += 1
    End Sub

    Public Overloads Sub Add(keywordItem As NodeWithKeywordsItem)
        Items.Add(keywordItem)
        Instancias += 1

    End Sub

    Public Overloads Sub Add(keyword As String, treeNode As TreeNode)
        Dim keywordItem As New NodeWithKeywordsItem(keyword, treeNode)
        Items.Add(keywordItem)
    End Sub

    Public Overloads Sub Add(keywords As Collections.Specialized.StringCollection, treeNode As TreeNode)
        Dim keywordItem As New NodeWithKeywordsItem(keywords, treeNode)
        Items.Add(keywordItem)
    End Sub
End Class

Public Class NodeWithKeywordsItem
    Public Shared Property Instancias As Integer
    Private Const titulo As String = "Keyword"

    Public Sub New()
        Dim title As String = titulo + " " + Instancias.ToString

        Me.Keywords.Add(title)

        Me.NodeAssociated = (New TreeNode("Node Associated " + Instancias.ToString))

        Instancias += 1

    End Sub

    Public Sub New(keywordText As String)
        Dim title As String = "Node Associated " + Instancias.ToString

        Me.Keywords.Add(keywordText)
        Me.NodeAssociated = New TreeNode(title)

        Instancias += 1

    End Sub

    Public Sub New(keywordText As String, node As TreeNode)

        Me.Keywords.Add(keywordText)
        Me.NodeAssociated = (node)

        Instancias += 1

    End Sub

    Public Sub New(node As TreeNode)

        Me.Keywords.Add(node.Text)
        Me.NodeAssociated = (node)

        Instancias += 1

    End Sub

    Public Sub New(keywords As Collections.Specialized.StringCollection)
        Dim title As String = "Node Associated " + Instancias.ToString

        Me.Keywords = keywords

        Me.NodeAssociated = New TreeNode(title)

        Instancias += 1

    End Sub

    Public Sub New(keywords As Collections.Specialized.StringCollection, node As TreeNode)

        Dim keys As Specialized.StringCollection = (keywords)
        Me.Keywords = keys

        Me.NodeAssociated = (node)

        Instancias += 1

    End Sub

    Dim _keywords As New Collections.Specialized.StringCollection
    <Category("Dados")>
    <Description("Determina uma lista em formato texto para ser retornada na ordem da lista de opções.")>
    <Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")>
    Public Property Keywords() As Collections.Specialized.StringCollection
        'http://www.vbforums.com/showthread.php?862825-Accessing-UI-Type-Editor
        Get
            Return _keywords
        End Get
        Set(ByVal value As Collections.Specialized.StringCollection)
            _keywords = value
        End Set
    End Property

    'Private _keyWordDeClass_Keywords As String
    'Public Property KeywordText As String
    '    Get
    '        Return _keyWordDeClass_Keywords

    '    End Get
    '    Set(value As String)
    '        _keyWordDeClass_Keywords = value
    '    End Set
    'End Property


    Public _nodeAssociated As New TreeNode
    Public Property NodeAssociated() As TreeNode
        Get

            Return _nodeAssociated
        End Get
        Set(value As TreeNode)

            _nodeAssociated = value

        End Set

    End Property

    Overloads Sub Relembrar()

    End Sub

    Public Overloads Sub Relembrar(memoria As Boolean)

    End Sub

    Public Structure KeywordNode

        Dim _keywords As Collections.Specialized.StringCollection
        <Category("Dados")>
        <Description("Determina uma lista em formato texto para ser retornada na ordem da lista de opções.")>
        <Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")>
        Public Property Keywords() As Collections.Specialized.StringCollection
            'http://www.vbforums.com/showthread.php?862825-Accessing-UI-Type-Editor
            Get
                Return _keywords
            End Get
            Set(ByVal value As Collections.Specialized.StringCollection)
                _keywords = value
            End Set
        End Property

        Private _keyword As String
        Public Property Keyword As String
            Get
                Return _keyword
            End Get
            Set(value As String)
                _keyword = value
            End Set
        End Property

        Private _nodeAssociated As TreeNode
        Public Property NodeAssociated() As TreeNode
            Get

                Return _nodeAssociated
            End Get
            Set(value As TreeNode)

                _nodeAssociated = value

            End Set

        End Property
    End Structure

End Class
