Imports System.IO
Public Class Control_LoadRenameOptions
    Dim CtlRenameOptionPrima As New Control_RenameOption

    ' Propriedades
    ' -------------------------------------------------------------
    Private _text As String
    Public Overrides Property Text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value

        End Set
    End Property

    Private _itens As New List(Of Control)
    Public Property Itens As List(Of Control)
        Get
            Return _itens

        End Get
        Set(value As List(Of Control))
            _itens = value

        End Set
    End Property

    Private _defaultItem As Control
    Public Property DefaultItem As Control
        Get
            Return _defaultItem

        End Get
        Set(value As Control)
            _defaultItem = value

        End Set
    End Property

    Private _fileExemple As FileInfo
    Public Property FileExemple As String
        Get
            Return _fileExemple.FullName

        End Get
        Set(value As String)
            If value IsNot Nothing Or Trim(value) = "" Then
                _fileExemple = New FileInfo(value)

            Else
                value = "C:\Pasta Teste\Arquivo.txt"
                _fileExemple = New FileInfo(value)

            End If

            ' TODO: Aqui entra uma função que...
            '...adiciona as propriedades FileExemple dos subitens...

            For Each item As Control_RenameOption In _itens
                item.FileExemple = value
            Next

        End Set
    End Property
    ' -------------------------------------------------------------

    Private Sub Control_LoadRenameOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' FileExemple = "C:\Pasta Teste\Meu ArquivO arQUiVado.txt"

        If _defaultItem Is Nothing Then
            _defaultItem = CtlRenameOptionPrima
            ' TODO:  Ver se isso pode ficar no load
            If _fileExemple IsNot Nothing Then CtlRenameOptionPrima.FileExemple = _fileExemple.FullName
        End If

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Panel_LoadRenameOption.Controls.Add(_defaultItem)
        _defaultItem.Dock = DockStyle.Top
        _defaultItem.Visible = True
        _defaultItem.TabIndex = 0

        If _defaultItem IsNot Nothing Then
            _itens.Add(_defaultItem)

        End If

    End Sub

    Sub AtualizarItensList()
        Itens.Clear()
        Itens.AddRange(Panel_LoadRenameOption.Controls.OfType(Of Control))
    End Sub

    Function TextResult() As String
        Dim _textResult As String = ""
        Dim item As Control_RenameOption
        Dim temExtensao As Boolean = False
        Dim _nomeDoArquivo As String = ""
        Dim _extDoArquivo As String = ""

        Dim x As Integer = 0
        Dim y As Integer = _itens.Count - 1
        Dim index As Integer = y - x

        For x = 0 To y
            index = y - x

            item = _itens(index)

#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
            If item.SelectDisplayTela = item._selectDisplayTela.NovaExtensao Then
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
                temExtensao = True

            End If

            If temExtensao = False Then
                _nomeDoArquivo += item.Text
            Else

                _extDoArquivo += item.Text
            End If

        Next

        If Trim(_nomeDoArquivo) = "" Then
            _nomeDoArquivo = _fileExemple.Name.Replace(_fileExemple.Extension, "")

        End If

        If Trim(_extDoArquivo) = "" Or Trim(_extDoArquivo) = "." Then
            _extDoArquivo = _fileExemple.Extension

        End If

        _textResult = _nomeDoArquivo + _extDoArquivo


        Return _textResult
    End Function

End Class
