Imports System.Drawing.Text
Imports System.ComponentModel

Public Class Control_TextBoxPerson
    Dim DefaultHeight As Integer = 21

    Dim _defaultSize As New Size(100, 21)

    Dim _defaultMargin As New Padding(0, 0, 0, 0)

    Dim _defaultBorder As New Padding(1, 1, 1, 1)


    Dim _minVerticalSize As Integer = 19

    Dim _defaultPaddingText As New Padding(2, 2, 2, 2)
    'Dim DefaultFont As New Font(Me.Font)

    Private _leftIndentation As Integer = 6
    <Category("Aparência")>
    <Description("Determina o valor do recuo do texto a esquerda")>
    Public Property LeftIndentation As Integer
        Get
            Return _leftIndentation
        End Get

        Set(value As Integer)

            'If value = Nothing Or value = "" Then
            '    value = 0
            'End If

            _leftIndentation = value

            AtualizarPaddingText()

        End Set
    End Property

    Private _rightIndentation As Integer = 0
    <Category("Aparência")>
    <Description("Determina o valor do recuo do texto a direita")>
    Public Property RightIndentation As Integer
        Get
            Return _rightIndentation

        End Get
        Set(value As Integer)

            'If value = Nothing Or value = "" Then
            '    value = 0
            'End If

            _rightIndentation = value

            AtualizarPaddingText()

        End Set
    End Property

    Dim _changeCursorFocus As Boolean

    <Category("Comportamento")>
    <Description("Altera o cursor quando o Textbox do componente recebe foco.")>
    Public Property ChangeCursorFocus As Boolean
        Get
            Return _changeCursorFocus
        End Get
        Set(value As Boolean)
            _changeCursorFocus = value

        End Set
    End Property

    Private _paddingText As New Padding
    <Category("Layout")>
    <Description("Especifica o espaçamento interior em relação ao texto.")>
    Public Property PaddingText As Padding
        Get
            Return _defaultPaddingText

        End Get
        Set(value As Padding)

            Dim _left As Integer = (_leftIndentation + value.Left)
            Dim _right As Integer = (_rightIndentation + value.Right)
            Dim _top As Integer = value.Top
            Dim _bottom As Integer = value.Bottom

            _defaultPaddingText = value
            PanelEnvolveTXT.Padding = New Padding(_left, _top, _right, _bottom)

            AtualizarProporcaoDoTxt()

        End Set
    End Property

    Private _errorDisplay As Boolean
    <Category("Aparência")>
    <Description("Mostra aparência da borda com as cores de indicativo  de erro.")>
    Public Property ErrorDisplay As Boolean
        Get
            Return _errorDisplay

        End Get
        Set(value As Boolean)
            _errorDisplay = value

        End Set
    End Property

    Private _txt As String
    <Category("Aparência")>
    <Description("Texto associado ao controle.")>
    Public Property Txt As String
        Get
            Return _txt

        End Get
        Set(value As String)
            _txt = value

            If value = "" Then
                TXTBox.Text = _placeholder

            Else
                TXTBox.Text = value

            End If

            AplicarPassWordChar()

        End Set

    End Property

    Private _cursorTxt As Cursor
    <Category("Aparência")>
    <Description("Cursor exibido quando o ponteiro do mouse está sobre o texto.")>
    Public Property CursorTxt As Cursor
        Get
            Return _cursorTxt

        End Get
        Set(value As Cursor)
            _cursorTxt = value
            TXTBox.Cursor = _cursorTxt

        End Set
    End Property

    Private _scrollBar As ScrollBars
    <Category("Aparência")>
    <Description("Indica, para controles de edição de várias linhas, as barras de rolagens que serão exibidas para este controle.")>
    Public Property ScrollBar As ScrollBars
        Get
            Return _scrollBar
        End Get
        Set(value As ScrollBars)
            _scrollBar = value
            TXTBox.ScrollBars = value

        End Set
    End Property

    Dim _wordWrap As Boolean
    <Category("Comportamento")>
    <Description("Indica se há quebra de linhas para controles de edição de várias linhas.")>
    Public Property WordWrap As Boolean
        Get
            Return _wordWrap
        End Get
        Set(value As Boolean)
            _wordWrap = value
            TXTBox.WordWrap = value

        End Set
    End Property

    Private _read_Only As Boolean
    <Category("Comportamento")>
    <Description("Controla de o texto no controle de edição pode ser alterado ou não.")>
    Public Property Read_Only As Boolean
        Get
            Return _read_Only

        End Get
        Set(value As Boolean)
            _read_Only = value
            TXTBox.ReadOnly = value
        End Set
    End Property

    Private _textAlign As HorizontalAlignment
    <Category("Aparência")>
    <Description("Indica como o texto deve ser alinhado para controle de edição.")>
    Public Property TextAlign As HorizontalAlignment
        Get
            Return _textAlign

        End Get
        Set(value As HorizontalAlignment)
            _textAlign = value
            TXTBox.TextAlign = value
        End Set
    End Property

    Private _placeholder As String
    <Category("Aparência")>
    <Description("Determina um texto de suporte quando a propriedade Txt não contiver nenhum valor.")>
    Public Property Placeholder As String
        Get
            Return _placeholder
        End Get
        Set(value As String)
            _placeholder = value

            If _txt Is Nothing Or _txt = "" Then
                TXTBox.Text = value
            End If

            AplicarPassWordChar()

        End Set
    End Property

    Private _multiLine As Boolean
    <Category("Comportamento")>
    <Description("Controla se o texto no contole de edição pode ser estendido em mais de uma linha.")>
    Public Property MultiLine As Boolean
        Get
            Return _multiLine
        End Get
        Set(value As Boolean)
            _multiLine = value

            TXTBox.Multiline = value

            Select Case value
                Case True
                    PanelTXT.Dock = DockStyle.Fill
                    Me.MaximumSize = New Size(0, 0)
                    Me.MinimumSize = New Size(5, 5)
                   ' Me.Size = New Size(_thisSize.Width, 21)


                Case False
                    PanelTXT.Dock = DockStyle.Fill
                    Me.MaximumSize = New Size(0, _minVerticalSize)
                    Me.MinimumSize = New Size(5, _minVerticalSize)

                    ' Me.Size = New Size(Me.Size.Width, 21)

            End Select

        End Set
    End Property

    Private _personBorder As New Padding
    <Category("Aparência")>
    <Description("Determina a largura das bordas como em um estilo CSS.")>
    Public Property PersonBorder As Padding
        Get
            Return _personBorder
        End Get
        Set(value As Padding)
            _personBorder = value
            PanelBorder.Padding = value

            AtualizarProporcaoDoTxt()

            'Me.MinimumSize = New Size(Me.Width, _minVerticalSize)

        End Set
    End Property

    Private _personCSSMargin As New Padding
    <Category("Layout")>
    <Description("Altera a propriedade padding do componente adicionado uma margem porém, respeitando a altura máxima do componente.")>
    Public Property PersonCSSMargin As Padding
        Get
            Return _personCSSMargin

        End Get
        Set(value As Padding)
            _personCSSMargin = value
            Me.Padding = value

            AtualizarProporcaoDoTxt()

            ' Me.MinimumSize = New Size(Me.Width, _minVerticalSize)
        End Set
    End Property

    Private _h As Integer
    Private _w As Integer

    Private _thisSize As New Size
    Public Property ThisSize As Size
        Get
            Return _thisSize
        End Get
        Set(value As Size)
            _thisSize = value
        End Set
    End Property

    Private _passwordChar As Char
    <Category("Comportamento")>
    <Description("Indica o caractere a ser exibido para entrada de senha para controle de edição de uma linha única.")>
    Public Property PasswordChar As String
        Get
            Return _passwordChar

        End Get
        Set(value As String)
            _passwordChar = value

            AplicarPassWordChar()

        End Set
    End Property

    Private _useSystemPasswordChar As Boolean
    <Category("Comportamento")>
    <Description("Indica se o texto  no controle de edição deve aparecer com caracter de senha padrão.")>
    Public Property UseSystemPasswordChar As Boolean
        Get
            Return _useSystemPasswordChar
        End Get
        Set(value As Boolean)
            _useSystemPasswordChar = value

            TXTBox.UseSystemPasswordChar = _useSystemPasswordChar
            AplicarPassWordChar()

        End Set
    End Property



    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        _thisSize = _defaultSize
        PanelBorder.Padding = _defaultBorder
        Me.Padding = _defaultMargin
        _wordWrap = TXTBox.WordWrap
        _cursorTxt = TXTBox.Cursor
        AtualizarPaddingText()

    End Sub

    Sub AplicarPassWordChar()
        If _txt = "" Or _txt = Nothing Then
            TXTBox.PasswordChar = ""
            ' TXTBox.UseSystemPasswordChar = False

        Else
            TXTBox.PasswordChar = _passwordChar
            'TXTBox.UseSystemPasswordChar = UseSystemPasswordChar

        End If
    End Sub

    Sub AtualizarPaddingText()

        Dim _left As Integer = (_leftIndentation + _defaultPaddingText.Left)
        Dim _right As Integer = (_rightIndentation + _defaultPaddingText.Right)
        Dim _top As Integer = _defaultPaddingText.Top
        Dim _bottom As Integer = _defaultPaddingText.Bottom

        PanelEnvolveTXT.Padding = New Padding(_left, _top, _right, _bottom)

    End Sub

    Sub AtualizarProporcaoDoTxt()

        _minVerticalSize = 19 + (Me.Padding.Top + Me.Padding.Bottom) + (_personBorder.Top + _personBorder.Bottom) + (_paddingText.Top + _paddingText.Bottom)

        If _multiLine = True Then
            Me.MinimumSize = New Size(5, 5)
        Else
            Me.MinimumSize = New Size(Me.Width, _minVerticalSize)

        End If

    End Sub

    Private Sub TXTBox_LostFocus(sender As Object, e As EventArgs) Handles TXTBox.LostFocus
        Txt = TXTBox.Text
        AplicarPassWordChar()
        'If _txt = "" Or _txt = Nothing Then
        '    '  TXTBox.PasswordChar = ""
        '    TXTBox.UseSystemPasswordChar = False
        'End If
    End Sub

    Private Sub TXTBox_GotFocus(sender As Object, e As EventArgs) Handles TXTBox.GotFocus
        TXTBox.Text = _txt
        TXTBox.PasswordChar = PasswordChar
        'TXTBox.UseSystemPasswordChar = UseSystemPasswordChar
    End Sub

    Private Sub Control_TextBoxPerson_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        _thisSize = New Size(Me.Width, Me.Height)
    End Sub
End Class
