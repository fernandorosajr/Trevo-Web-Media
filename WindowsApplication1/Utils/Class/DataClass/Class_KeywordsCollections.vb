Public Class Class_KeywordsCollections
    ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/objects-and-classes/
    ' http://www.macoratti.net/vbn_ams1.htm

    Private Shared Instancias As Integer


    Private _items As New Collection      ' New List(Of Keyword)
    Public Property Items As Collection  ' As List(Of Keyword)
        Get
            Return _items
        End Get
        Set(value As Collection)      'As List(Of Keyword))
            _items = value
        End Set
    End Property


    Public Sub New()
        Instancias += 1

    End Sub

    Public Sub New(keywordText As String, node As TreeNode)

        Dim keywordItem As New KeywordItem(keywordText, node)
        Items.Add(keywordItem)

    End Sub

    Public Sub New(keywordItem As KeywordItem)
        Dim keyText As String = keywordItem.KeywordText
        Dim list As New List(Of TreeNode)

        list = keywordItem.NodeAssociated
        Dim keyItem As New KeywordItem(keyText, list)

        Items.Add(keywordItem)

        Instancias += 1
    End Sub

    Public Overloads Sub Add(keywordItem As KeywordItem)
        Items.Add(keywordItem)
        Instancias += 1

    End Sub

    Public Overloads Sub Add(keyword As String, treeNode As TreeNode)
        Dim keywordItem As New KeywordItem(keyword, treeNode)
        Items.Add(keywordItem)
    End Sub

End Class

Public Class KeywordItem
    Public Shared Property Instancias As Integer
    Private Const titulo As String = "Keyword"

    Public Sub New()
        Dim title As String = titulo + " " + Instancias.ToString
        Me.KeywordText = title

        Me.NodeAssociated.Add(New TreeNode("Node Associated " + Instancias.ToString))

        Instancias += 1

    End Sub

    Public Sub New(keywordText As String, node As TreeNode)

        Me.KeywordText = keywordText
        Me.NodeAssociated.Add(node)

        Instancias += 1

    End Sub

    Public Sub New(node As TreeNode)

        Me.KeywordText = node.Text
        Me.NodeAssociated.Add(node)

        Instancias += 1

    End Sub

    Public Sub New(treeNodeList As List(Of TreeNode))
        Dim title As String = titulo + " " + Instancias.ToString

        Me.KeywordText = title

        For Each node As TreeNode In treeNodeList
            Me.NodeAssociated.Add(node)
        Next

        Instancias += 1

    End Sub

    Public Sub New(keywordText As String, treeNodeList As List(Of TreeNode))

        Me.KeywordText = keywordText

        For Each node As TreeNode In treeNodeList
            Me.NodeAssociated.Add(node)
        Next

        Instancias += 1

    End Sub


    Public Sub New(TreeNodeCollection As TreeNodeCollection)

        Dim title As String = titulo + " " + Instancias

        Me.KeywordText = title

        For Each node As TreeNode In TreeNodeCollection
            Me.NodeAssociated.Add(node)
        Next

        Instancias += 1

    End Sub

    Public Sub New(keywordText As String, TreeNodeCollection As TreeNodeCollection)

        Me.KeywordText = keywordText

        For Each node As TreeNode In TreeNodeCollection
            Me.NodeAssociated.Add(node)
        Next

        Instancias += 1

    End Sub

    Private _keyWordDeClass_Keywords As String
    Public Property KeywordText As String
        Get
            Return _keyWordDeClass_Keywords

        End Get
        Set(value As String)
            _keyWordDeClass_Keywords = value
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

    Overloads Sub Relembrar()

    End Sub

    Public Overloads Sub Relembrar(memoria As Boolean)

    End Sub

    Public Structure KeywordNode

        Private _keyword As String
        Public Property Keyword As String
            Get
                Return _keyword
            End Get
            Set(value As String)
                _keyword = value
            End Set
        End Property

        Private _nodeAssociated As List(Of TreeNode)
        Public Property NodeAssociated() As List(Of TreeNode)
            Get

                Return _nodeAssociated
            End Get
            Set(value As List(Of TreeNode))

                _nodeAssociated = value

            End Set

        End Property
    End Structure

End Class
