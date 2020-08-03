Public Class Class_KeywordsCollections
    ' https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/objects-and-classes/
    ' http://www.macoratti.net/vbn_ams1.htm

    Private Shared Instancias As Integer

    Public Sub New()
        Instancias += 1

    End Sub

    Private _items As New Collection      ' New List(Of Keyword)
    Public Property Items As Collection  ' As List(Of Keyword)
        Get
            Return _items
        End Get
        Set(value As Collection)      'As List(Of Keyword))
            _items = value
        End Set
    End Property


End Class

Public Class Keyword
    Private Shared Instancias As Integer

    Public Sub New()
        Instancias += 1

    End Sub

    Public Sub New(keyword As String, node As TreeNode)
        Instancias += 1

    End Sub

    Public Sub New(node As TreeNode)
        Instancias += 1

    End Sub

    Public Sub New(node As List(Of TreeNode))
        Instancias += 1

    End Sub

    Public Sub New(TreeNodeCollection As TreeNodeCollection)
        Instancias += 1

    End Sub

    Public Sub New(keyword As String, TreeNodeCollection As TreeNodeCollection)
        Instancias += 1

    End Sub

    Private _keyWordDeClass_Keywords As String
    Public Property Keyword As String
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
