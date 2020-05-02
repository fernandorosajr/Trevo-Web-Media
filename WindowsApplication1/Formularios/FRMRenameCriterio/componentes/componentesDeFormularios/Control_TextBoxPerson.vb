﻿Imports System.Drawing.Text
Imports System.ComponentModel

Public Class Control_TextBoxPerson

    Public cor As Color = ColorTranslator.FromWin32(Color.Gray.ToArgb)
    Public cor2 As Color = ColorTranslator.FromWin32(ColorTranslator.ToWin32(Color.FromArgb(83, 83, 86)))
    Public textCor2 As Integer = ColorTranslator.ToWin32(Color.FromArgb(83, 83, 86))
    ' 83; 83; 86

    Dim DefaultHeight As Integer = 21

    Dim _defaultSize As New Size(100, 21)

    Dim _defaultMargin As New Padding(0, 0, 0, 0)

    Dim _defaultBorder As New Padding(1, 1, 1, 1)

    Dim _minVerticalSize As Integer = 19

    Dim _defaultPaddingText As New Padding(2, 2, 2, 2)

    Private configs As Class_Configs

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

            If _errorDisplay = True Then
                PanelBorder.BackColor = _borderColorError

            Else
                PanelBorder.BackColor = _borderColorLostFocus

            End If

        End Set
    End Property

    Private _txt As String
    <Category("Aparência")>
    <Description("Texto associado ao controle.")>
    Public Property TXT As String
        Get
            Return _txt

        End Get
        Set(value As String)
            _txt = value

            If value = "" Then
                TXTBox.Text = _placeholder
                TXTBox.ForeColor = _foreColorPlaceholder

            Else
                TXTBox.Text = value
                TXTBox.ForeColor = _foreColorActive

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

    ' Propriedades de configuração de cores
    '________________________________________________________

    Private _borderColorError As Color
    <Category("Aparência")>
    Public Property BorderColorError As Color
        Get
            Return _borderColorError
        End Get
        Set(value As Color)
            _borderColorError = value

            If _errorDisplay = True Then
                PanelBorder.BackColor = _borderColorError

            Else
                PanelBorder.BackColor = _borderColorLostFocus

            End If

        End Set
    End Property

    Private _backColorCursorMouseLeave As Color
    <Category("Aparência")>
    Public Property BackColorCursorMouseLeave As Color
        Get
            Return _backColorCursorMouseLeave
        End Get
        Set(value As Color)
            _backColorCursorMouseLeave = value

        End Set
    End Property

    Private _borderColorGotFocus As Color
    <Category("Aparência")>
    Public Property BorderColorGotFocus As Color
        Get
            Return _borderColorGotFocus
        End Get
        Set(value As Color)
            _borderColorGotFocus = value

        End Set
    End Property

    Private _borderColorLostFocus As Color
    <Category("Aparência")>
    Public Property BordeColorLostFocus As Color
        Get
            Return _borderColorLostFocus
        End Get
        Set(value As Color)
            _borderColorLostFocus = value
        End Set
    End Property

    Private _txtBoxBackColorLostFocus As Color
    <Category("Aparência")>
    Public Property TXTBoxBackColorLostFocus As Color
        Get
            Return _txtBoxBackColorLostFocus
        End Get
        Set(value As Color)
            _txtBoxBackColorLostFocus = value
        End Set
    End Property

    Private _bgColorLostFocus As Color
    <Category("Aparência")>
    Public Property BgColorLostFocus As Color
        Get
            Return _bgColorLostFocus
        End Get
        Set(value As Color)
            _bgColorLostFocus = value
        End Set
    End Property


    Private _foreColorActive As Color
    Public Property ForeColorActive As Color
        Get
            Return _foreColorActive

        End Get
        Set(value As Color)
            _foreColorActive = value
            Me.ForeColor = value

            AtualizarForeColor()

        End Set
    End Property


    Private Property _foreColorPlaceholder As Color
    Public Property ForeColorPlaceholder As Color
        Get
            Return _foreColorPlaceholder
        End Get
        Set(value As Color)
            _foreColorPlaceholder = value

            AtualizarForeColor()

        End Set
    End Property

    ' __________________________________________________________
    ' Propriedades de TXT
    '____________________________________________________________

    Private _font As Font
    Public Property Fonte As Font
        Get
            Return _font

        End Get
        Set(value As Font)
            _font = value

        End Set
    End Property

    Private _characterCasing As CharacterCasing
    <Category("Comportamento")>
    <Description("Indica se todos os caracteres devem ser mantido, ou convertidos em maiúsculos ou minúsculos.")>
    Public Property CharacterCasing As CharacterCasing
        Get
            Return _characterCasing

        End Get
        Set(value As CharacterCasing)
            _characterCasing = value
            TXTBox.CharacterCasing = _characterCasing

        End Set
    End Property


    Private _hideSelection As Boolean = True
    <Category("Comportamento")>
    <Description("Indica se a seleção deve ser ocultada quando o controle perde foco.")>
    Public Property HideSelection As Boolean
        Get
            Return _hideSelection

        End Get
        Set(value As Boolean)
            _hideSelection = value
            TXTBox.HideSelection = value

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
        _characterCasing = TXTBox.CharacterCasing

        AtualizarPaddingText()

#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        _borderColorGotFocus = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._borderColorGotFocus) 'SystemColors.HotTrack
        _borderColorLostFocus = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._borderColorLostFocus) ' Me.BackColor 
        _backColorCursorMouseLeave = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._backColorCursorMouseLeave) 'Color.FromArgb(45, 45, 48)
        _borderColorError = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._borderColorError)  ' Color.Red
        _txtBoxBackColorLostFocus = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._txtBoxBackColorLostFocus)  'Color.FromArgb(63, 63, 66)
        _bgColorLostFocus = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._bgColorLostFocus)   'Me.BackColor

        _foreColorActive = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._foreColorActive)
        _foreColorPlaceholder = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._foreColorPlaceholder)
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância

        Me.ForeColor = _foreColorActive

        Me.Font = TXTBox.Font
        _font = Me.Font

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

    Sub AtualizarForeColor()
        If _txt = Nothing Or _txt = "" Then
            TXTBox.ForeColor = _foreColorPlaceholder

        Else
            TXTBox.ForeColor = _foreColorActive

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
        TXT = TXTBox.Text
        AplicarPassWordChar()

        Dim obj As Object
        obj = CType(sender, Object)

        obj.BackColor = _bgColorLostFocus
        obj.Parent.BackColor = obj.BackColor

        If _errorDisplay = True Then
            PanelBorder.BackColor = _borderColorError
        Else
            PanelBorder.BackColor = _borderColorLostFocus
        End If

        If _changeCursorFocus = True Then
            TXTBox.Cursor = Me.Cursor
            PanelEnvolveTXT.Cursor = TXTBox.Cursor
        End If

    End Sub

    Private Sub TXTBox_GotFocus(sender As Object, e As EventArgs) Handles TXTBox.GotFocus
        TXTBox.Text = _txt
        TXTBox.PasswordChar = PasswordChar
        TXTBox.ForeColor = _foreColorActive


        Dim obj As Object
        obj = CType(sender, Object)

        '        obj.Parent.Parent.BackColor = _borderColorGotFocus

        If _errorDisplay = True Then
            PanelBorder.BackColor = _borderColorError
        Else
            PanelBorder.BackColor = _borderColorGotFocus
        End If


        Select Case obj.Name
            Case "TXTBox"
                obj.BackColor = _backColorCursorMouseLeave
                obj.Parent.BackColor = obj.BackColor

            Case Else
                TXTBox.BackColor = _txtBoxBackColorLostFocus
                TXTBox.Parent.BackColor = TXTBox.BackColor '_bgColorLostFocus

                obj.BackColor = _txtBoxBackColorLostFocus
                obj.Parent.BackColor = TXTBox.BackColor '_bgColorLostFocus

        End Select

        TXTBox.Cursor = _cursorTxt
        PanelEnvolveTXT.Cursor = TXTBox.Cursor

    End Sub

    Private Sub Control_TextBoxPerson_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        _thisSize = New Size(Me.Width, Me.Height)
    End Sub

    Private Sub Control_TextBoxPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TXTBox.Parent.BackColor = ColorTranslator.FromWin32(textCor2) 'cor
        ''  TXTBox.Text
        'Me.TXT = ColorTranslator.ToWin32(cor) 'textCor2 
    End Sub

    Private Sub Control_TextBoxPerson_ForeColorChanged(sender As Object, e As EventArgs) Handles Me.ForeColorChanged
        _foreColorActive = Me.ForeColor
    End Sub

    Private Sub TXTBox_TextChanged(sender As Object, e As EventArgs) Handles TXTBox.TextChanged

    End Sub

    Private Sub TXTBox_MouseLeave(sender As Object, e As EventArgs) Handles TXTBox.MouseLeave, PanelEnvolveTXT.MouseLeave
        Dim obj As Object
        obj = CType(sender, Object)

        If TXTBox.Focused = True Then
            TXTBox.BackColor = _backColorCursorMouseLeave

            ' AtualizarCursor()

            'If _changeCursorFocus = True Then
            TXTBox.Cursor = _cursorTxt
            PanelEnvolveTXT.Cursor = TXTBox.Cursor

        Else
            TXTBox.BackColor = _txtBoxBackColorLostFocus

            If _errorDisplay = True Then
                PanelBorder.BackColor = _borderColorError
            Else
                PanelBorder.BackColor = _borderColorLostFocus
            End If

            If _changeCursorFocus = True Then
                TXTBox.Cursor = Me.Cursor
                PanelEnvolveTXT.Cursor = TXTBox.Cursor
            Else
                TXTBox.Cursor = _cursorTxt
                PanelEnvolveTXT.Cursor = TXTBox.Cursor
            End If

        End If
            TXTBox.Parent.BackColor = obj.BackColor

    End Sub

    Private Sub TXTBox_MouseMove(sender As Object, e As MouseEventArgs) Handles TXTBox.MouseMove, PanelEnvolveTXT.MouseMove

        If TXTBox.Focused = True Then
            PanelBorder.BackColor = _borderColorGotFocus
            TXTBox.BackColor = _backColorCursorMouseLeave
            TXTBox.Parent.BackColor = TXTBox.BackColor

            TXTBox.Cursor = _cursorTxt
            PanelEnvolveTXT.Cursor = TXTBox.Cursor

        Else
            '  PanelBorder.BackColor = _borderColorLostFocus
            TXTBox.BackColor = _txtBoxBackColorLostFocus
            TXTBox.Parent.BackColor = TXTBox.BackColor

            If _changeCursorFocus = True Then
                TXTBox.Cursor = Me.Cursor
                PanelEnvolveTXT.Cursor = TXTBox.Cursor
            Else
                TXTBox.Cursor = _cursorTxt
                PanelEnvolveTXT.Cursor = TXTBox.Cursor
            End If

        End If
        ' obj.Parent.BackColor = obj.BackColor

        If _errorDisplay = True Then
            PanelBorder.BackColor = _borderColorError
        Else
            PanelBorder.BackColor = _borderColorGotFocus
        End If

    End Sub

    Private Sub PanelEnvolveTXT_Click(sender As Object, e As EventArgs) Handles PanelEnvolveTXT.Click
        TXTBox.Focus()

    End Sub

    Private Sub Control_TextBoxPerson_FontChanged(sender As Object, e As EventArgs) Handles Me.FontChanged
        TXTBox.Font = Me.Font

    End Sub
End Class