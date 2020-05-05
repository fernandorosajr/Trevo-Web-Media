Imports System.Drawing.Text
Imports System.ComponentModel

Public Class Control_TextConfirm

    Private _placeholder As String
    <Category("Aparência")>
    <Description("Determina um texto de suporte quando a propriedade Txt não contiver nenhum valor.")>
    Public Property Placeholder As String
        Get
            Return _placeholder
        End Get
        Set(value As String)
            _placeholder = value

            TXTValue.Placeholder = _placeholder

        End Set
    End Property

    ' Propriedades de Validação
    '------------------------------------------------


    Private _activeValidate As Boolean
    <Category("Validação")>
    <Description("Recebe caracteres .")>
    Public Property ActiveValidate As Boolean
        Get
            Return _activeValidate

        End Get
        Set(value As Boolean)
            _activeValidate = value

            TXTValue.ActiveValidate = _activeValidate

        End Set
    End Property

    Private _requiredText As String
    <Category("Validação")>
    <Description("Recebe caracteres .")>
    Public Property RequiredText As String
        Get
            Return _requiredText

        End Get
        Set(value As String)
            _requiredText = value
            TXTValue.RequiredText = _requiredText

        End Set
    End Property

    Private _noneOfThisText As String
    <Category("Validação")>
    <Description("Recebe caracteres .")>
    Public Property NoneOfThisText As String
        Get
            Return _noneOfThisText

        End Get
        Set(value As String)
            _noneOfThisText = value
            TXTValue.NoneOfThisChar = _noneOfThisText

        End Set
    End Property

    Private _byText As Boolean
    <Category("Validação")>
    <Description("Recebe caracteres .")>
    Public Property ByText As Boolean
        Get
            Return _byText

        End Get
        Set(value As Boolean)
            _byText = value
            TXTValue.ByText = _byText

        End Set
    End Property


    Private _noneOfThisChar() As Char
    Private _noneOfThisChar_STRING As String
    <Category("Validação")>
    <Description("Recebe caracteres .")>
    Public Property NoneOfThisChar As String
        Get
            Dim texto As String = ""

            If _noneOfThisChar IsNot Nothing Then
                For Each x In _noneOfThisChar
                    texto += x

                Next

            End If

            Return texto

        End Get
        Set(value As String)

            If value IsNot Nothing Then

                Dim _char() As Char = value.ToCharArray
                _noneOfThisChar = value.ToCharArray
                _noneOfThisChar_STRING = value

                TXTValue.NoneOfThisChar = _noneOfThisChar

            End If

        End Set
    End Property

    Private _requiredChar() As Char
    Private _requiredChar_STRING As String
    <Category("Validação")>
    <Description("Recebe caracteres .")>
    Public Property RequiredChar As String
        Get
            Dim texto As String = ""

            If _requiredChar IsNot Nothing Then
                For Each x In _requiredChar
                    texto += x

                Next

            End If

            Return texto

        End Get
        Set(value As String)

            If value IsNot Nothing Then

                Dim _char() As Char = value.ToCharArray
                _requiredChar = value.ToCharArray
                _requiredChar_STRING = value

                TXTValue.RequiredChar = _requiredChar
            End If

        End Set
    End Property

    Private _byChar As Boolean
    <Category("Validação")>
    <Description("Recebe caracteres .")>
    Public Property ByChar As Boolean
        Get
            Return _byChar

        End Get
        Set(value As Boolean)
            _byChar = value
            TXTValue.ByChar = _byChar
        End Set
    End Property

    Private _requiredValue As String
    <Category("Validação")>
    <Description("Recebe caracteres .")>
    Public Property RequiredValue As String
        Get
            Return _requiredValue

        End Get
        Set(value As String)
            _requiredValue = value

            TXTValue.RequiredValue = _requiredValue

        End Set
    End Property

    Private _noneOfThisValue As String
    <Category("Validação")>
    <Description("Recebe caracteres .")>
    Public Property NoneOfThisValue As String
        Get
            Return _noneOfThisValue

        End Get
        Set(value As String)
            _noneOfThisValue = value

            TXTValue.NoneOfThisValue = _noneOfThisValue

        End Set
    End Property


    Private _byValue As Boolean
    <Category("Validação")>
    <Description("Recebe caracteres .")>
    Public Property ByValue As Boolean
        Get
            Return _byValue

        End Get
        Set(value As Boolean)
            _byValue = value
            TXTValue.ByValue = _byValue

        End Set
    End Property

    Private _spaceError As Boolean
    <Category("Validação")>
    <Description("Recebe caracteres .")>
    Public Property SpaceError As Boolean
        Get
            Return _spaceError

        End Get
        Set(value As Boolean)
            _spaceError = value

            TXTValue.SpaceError = _spaceError
        End Set
    End Property



    '---------------------------------------------------------



    Private _valueStr As String
    Public Property ValueStr As String
        Get
            Return _valueStr
        End Get
        Set(value As String)
            _valueStr = value
            TXTValue.TXT = value

        End Set
    End Property

    Private _filho As Control
    Public Property Filho As Control
        Get
            Return _filho

        End Get
        Set(value As Control)

            _filho = value
            If Filho IsNot Nothing Then
                ValueStr = _filho.Text

            End If

        End Set
    End Property

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        _placeholder = TXTValue.Placeholder
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
    Private Sub BTNConfirmarAlterarValor_Click(sender As Object, e As EventArgs) Handles BTNConfirmarAlterarValor.Click


        If TXTValue.ErrorDisplay = True Then
            Me.Visible = True


        Else

            ValueStr = TXTValue.TXT
            If _filho IsNot Nothing Then
                _filho.Text = _valueStr

                Me.Visible = False
            End If

        End If

    End Sub

    Private Sub BTNCancelarAlterarValor_Click(sender As Object, e As EventArgs) Handles BTNCancelarAlterarValor.Click
        Me.Visible = False
        TXTValue.ErrorDisplay = False

    End Sub

    Private Sub Control_TextConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Control_TextConfirm_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        TXTValue.Focus()
    End Sub
End Class
