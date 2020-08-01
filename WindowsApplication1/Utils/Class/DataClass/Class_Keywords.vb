Public Class Class_Keywords

    Private _teste As String
    Public Property Teste As String
        Get
            Return _teste

        End Get
        Set(value As String)
            _teste = value
        End Set
    End Property


    Public _nodeAssociated As List(Of TreeNode)
    Public Property NodeAssociated() As List(Of TreeNode)
        Get

            Return _nodeAssociated
        End Get
        Set(value As List(Of TreeNode))

            _nodeAssociated = value

        End Set

    End Property

    Public teste2 As Integer
    'Public key As KeywordNode

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

End Class
