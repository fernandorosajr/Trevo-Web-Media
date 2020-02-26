Imports System.Windows.Forms

Public Class FRMDialogInputBox

    ' Propriedades do configuração
    Private _borderColorError As Color
    Public Property BorderColorError As Color
        Get
            Return _borderColorError
        End Get
        Set(value As Color)
            _borderColorError = value

        End Set
    End Property

    Private _backColorCursoreGotoFocus As Color
    Public Property BackColorCursoreGotoFocus As Color
        Get
            Return _backColorCursoreGotoFocus
        End Get
        Set(value As Color)
            _backColorCursoreGotoFocus = value

        End Set
    End Property

    Private _borderColorGotFocus As Color

    Public Property BorderColorGotFocus As Color
        Get
            Return _borderColorGotFocus
        End Get
        Set(value As Color)
            _borderColorGotFocus = value

        End Set
    End Property

    Private _borderColorLostFocus As Color
    Public Property BordeColorLostFocus As Color
        Get
            Return _borderColorLostFocus
        End Get
        Set(value As Color)
            _borderColorLostFocus = value
        End Set
    End Property

    Private _txtBoxBackColorLostFocus As Color

    Public Property TXTBoxBackColorLostFocus As Color
        Get
            Return _txtBoxBackColorLostFocus
        End Get
        Set(value As Color)
            _txtBoxBackColorLostFocus = value
        End Set
    End Property

    Dim _title As String
    Public Property Title As String
        Get
            Return _title

        End Get
        Set(value As String)
            _title = value
            Me.Text = _title
        End Set
    End Property

    Dim _h1 As String
    Public Property H1 As String
        Get
            Return _h1

        End Get
        Set(value As String)
            _h1 = value
            Me.LBLTitle01.Text = _h1
        End Set
    End Property

    Dim _prompt As String
    Public Property Prompt As String
        Get
            Return _prompt
        End Get
        Set(value As String)
            _prompt = value
            LBLPrompt.Text = value
        End Set
    End Property

    Dim _defaultResponse As String
    Public Property DefaultResponse
        Get
            Return _defaultResponse
        End Get
        Set(value)
            _defaultResponse = value
            TxtResponse.Text = value
        End Set
    End Property

    Dim _result As String
    Public Property Result As String
        Get
            Return _result
        End Get
        Set(value As String)
            _result = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogRenameVolume_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtResponse_TextChanged(sender As Object, e As EventArgs) Handles TxtResponse.TextChanged
        'Dim message As String

        'message = "Arquivos e pastas não podem conter os seguintes caracteres em seus nomes:" &
        '            Microsoft.VisualBasic.ControlChars.Cr &
        '            "\ " & "/ " & "| " & ": " & "* " & "? " & """" & " < " & ">"

        'ErrorProvider1.Clear()

        'If TxtResponse.Text.IndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) = -1 Then
        '    Result = Trim(TxtResponse.Text)
        'Else
        '    ErrorProvider1.SetError(TxtResponse, message)
        'End If

        Result = TxtResponse.Text
    End Sub

    Private Sub TxtResponse_GotFocus(sender As Object, e As EventArgs) Handles TxtResponse.GotFocus
        Dim txt As TextBox
        txt = CType(sender, TextBox)
        Dim _backColorMouseGotoFocus As Color = _backColorCursoreGotoFocus
        Dim _corDaBorda_GotFocus As Color = _borderColorGotFocus
        '  Dim borderColorError As Color = _borderColorError

        'If Trim(txt.Text) = "" Or txt.Text.LastIndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) > -1 Then
        '    txt.Parent.Parent.BackColor = borderColorError
        'Else
        '    txt.Parent.Parent.BackColor = backColor
        'End If

        txt.Parent.Parent.BackColor = _corDaBorda_GotFocus

        txt.Cursor = Cursors.IBeam
        txt.BackColor = _backColorMouseGotoFocus
        txt.Parent.BackColor = _backColorMouseGotoFocus

        TxtResponse.SelectionStart = 0
        TxtResponse.SelectionLength = TxtResponse.Text.Length
    End Sub

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        _borderColorGotFocus = SystemColors.HotTrack
        _borderColorLostFocus = OK_Button.BackColor
        _backColorCursoreGotoFocus = Color.FromArgb(45, 45, 48)
        _borderColorError = Color.Red
        _txtBoxBackColorLostFocus = Color.FromArgb(63, 63, 66)
        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Buttons_LostFocus(sender As Object, e As EventArgs) Handles OK_Button.LostFocus, Cancel_Button.LostFocus
        Dim btn As Button
        btn = CType(sender, Button)

        btn.FlatAppearance.BorderColor = _borderColorLostFocus
    End Sub

    Private Sub Buttons_GotFocus(sender As Object, e As EventArgs) Handles OK_Button.GotFocus, Cancel_Button.GotFocus
        Dim btn As Button
        btn = CType(sender, Button)

        btn.FlatAppearance.BorderColor = _borderColorGotFocus

    End Sub

    Private Sub TxtResponse_MouseLeave(sender As Object, e As EventArgs) Handles TxtResponse.MouseLeave
        Dim txt As TextBox
        txt = CType(sender, TextBox)
        Dim _corDaBorda_LostFocus As Color = _borderColorLostFocus
        Dim _corDaBorda_GotFocus As Color = _borderColorGotFocus

        If txt.Focused = True Then
            ' txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
            txt.Parent.Parent.BackColor = _corDaBorda_GotFocus

            'If Trim(txt.Text) = "" Or txt.Text.LastIndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) > -1 Then
            '    txt.Parent.Parent.BackColor = BorderColorError
            'Else
            '    txt.Parent.Parent.BackColor = corGotFocus
            'End If

        Else
            ' txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
            txt.Parent.Parent.BackColor = _corDaBorda_LostFocus
        End If
    End Sub

    Private Sub TxtResponse_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtResponse.MouseMove
        Dim txt As TextBox
        txt = CType(sender, TextBox)
        Dim _corDaBorda_GotFocus As Color = _borderColorGotFocus
        'Dim BorderColorError As Color = _borderColorError

        txt.Parent.Parent.BackColor = _corDaBorda_GotFocus

        'If Trim(txt.Text) = "" Or txt.Text.LastIndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) > -1 Then
        '    txt.Parent.Parent.BackColor = BorderColorError
        'Else
        '    txt.Parent.Parent.BackColor = cor
        'End If

        'If txt.Focused = True Then
        '    txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
        'Else
        '    txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
        'End If
    End Sub

    Private Sub TxtResponse_LostFocus(sender As Object, e As EventArgs) Handles TxtResponse.LostFocus
        Dim txt As TextBox
        txt = CType(sender, TextBox)
        Dim _corDeFundoDoTXTBoxLostFocus As Color = _txtBoxBackColorLostFocus

        txt.Parent.Parent.BackColor = _borderColorLostFocus
        '  txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
        txt.Cursor = Cursors.Arrow
        txt.BackColor = _corDeFundoDoTXTBoxLostFocus
        txt.Parent.BackColor = _corDeFundoDoTXTBoxLostFocus
    End Sub
End Class
