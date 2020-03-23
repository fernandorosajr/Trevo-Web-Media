Public Class Control_ComboBoxPerson
    'TODO : https://www.w3computing.com/vb2008/manipulating-menus-runtime/

    Private configs As Class_Configs

    ' Dim myColor As Color = Color.Green
    ' Dim iColor As Integer = myColor.ToArgb()
    ' Dim sColor As String = iColor.ToString

    ' 'To restore:

    'sColor = "-16744448" 'from text file
    'iColor = CInt(sColor)
    'myColor = Color.FromArgb(iColor)


    Public Enum TesteDeEnum
        Teste01 = 1
        Teste02 = 2
        Teste03 = 3
        Teste04 = 4
    End Enum

    Public cor As Color = ColorTranslator.FromWin32(Color.Aqua.ToArgb)
    Public cor2 As Color = ColorTranslator.FromWin32(ColorTranslator.ToWin32(Color.FromArgb(83, 83, 86)))
    Public textCor2 As Integer = ColorTranslator.ToWin32(Color.FromArgb(63, 63, 66))

    ' Propriedades de configuração de cores
    Private _borderColorError As Color
    Public Property BorderColorError As Color
        Get
            Return _borderColorError
        End Get
        Set(value As Color)
            _borderColorError = value

        End Set
    End Property

    Private _backColorCursorMouseLeave As Color
    Public Property BackColorCursorMouseLeave As Color
        Get
            Return _backColorCursorMouseLeave
        End Get
        Set(value As Color)
            _backColorCursorMouseLeave = value

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

    Private _bgColorLostFocus As Color
    Public Property BgColorLostFocus As Color
        Get
            Return _bgColorLostFocus
        End Get
        Set(value As Color)
            _bgColorLostFocus = value
        End Set
    End Property

    ' __________________________________________________

    Private _testandoEnum As TesteDeEnum
    Public Property TestandoEnum As TesteDeEnum
        Get
            Return _testandoEnum
        End Get
        Set(value As TesteDeEnum)
            _testandoEnum = value
        End Set
    End Property

    Public Structure TesteDeEstrutura
        Public teste01 As String
        Public teste02 As String
        Public teste03 As TesteDeEnum
    End Structure

    Private _testeDeEstrutura As TesteDeEstrutura
    Public Property TestandoEstrutura As TesteDeEstrutura
        Get
            Return _testeDeEstrutura
        End Get
        Set(value As TesteDeEstrutura)
            _testeDeEstrutura = value
        End Set
    End Property

    Dim funcoesDeString As New StringFunctionsClass

    Private _options As String
    Public Property Options As String
        Get
            Return _options
        End Get
        Set(value As String)
            _options = value
        End Set
    End Property

    Private _shortcutKeyDisplay As Boolean
    Public Property ShortcutKeyDisplay As Boolean
        Get
            Return _shortcutKeyDisplay
        End Get
        Set(value As Boolean)
            _shortcutKeyDisplay = value
        End Set
    End Property

    ReadOnly separador() As Char = {";"c, vbCrLf} ' {vbCrLf}

    Private _lista As New ArrayList()
    Public Property Lista As String

        Get
            Dim listaEmString As String = ""

            For Each str As String In _lista
                listaEmString = listaEmString & str & vbCrLf ' ";" 'vbCrLf

            Next

            Return listaEmString

        End Get
        Set(value As String)

            Dim valueInStringList() As String
            'listaAux.AddRange(value.Split(vbCrLf))
            '_lista = listaAux
            If value Is Nothing Then
                value = "val1;val2"
            End If
            valueInStringList = funcoesDeString.SepararPalavras(value, separador)  ' {vbCrLf})
            _lista.AddRange(valueInStringList)

        End Set
    End Property

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Dim newLine As String
        Dim _value As String = ""

        'Options
        For x = 0 To 5
            newLine = ("Teste " & (x + 1)) & ";" 'vbCrLf
            _value &= newLine

        Next

        ' Carrega as cores do componente
#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        _borderColorGotFocus = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._borderColorGotFocus) 'SystemColors.HotTrack
        _borderColorLostFocus = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._borderColorLostFocus) ' Me.BackColor 
        _backColorCursorMouseLeave = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._backColorCursorMouseLeave) 'Color.FromArgb(45, 45, 48)
        _borderColorError = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._borderColorError)  ' Color.Red
        _txtBoxBackColorLostFocus = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._txtBoxBackColorLostFocus)  'Color.FromArgb(63, 63, 66)
        _bgColorLostFocus = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._bgColorLostFocus)   'Me.BackColor
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância

        Options = _value
        Lista = Options
        ShortcutKeyDisplay = True

        AddMenuItens()

    End Sub
    Private Sub ControlComboBoxPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadShotCutKey()

    End Sub

    Private Function OptionClick(sender As Object, e As EventArgs)
        Dim itemClicked As New ToolStripMenuItem
        itemClicked = CType(sender, ToolStripMenuItem)
        ' MsgBox("You have selected the item " & itemClicked.Text)

        MsgBox(itemClicked.Name)
        LNKLLabelCombo.Text = itemClicked.Text

        Return itemClicked.Text
    End Function

    Sub AddMenuItens()

        For Each labelItem As String In _lista
            If Trim(labelItem) <> "" Then

                Dim Item As New ToolStripMenuItem With {
                    .Text = labelItem,
                    .ForeColor = Color.DarkGray,
                    .Width = Me.Width
                }

                AddHandler Item.Click, New System.EventHandler(AddressOf OptionClick)
                CMS_Menu.Items.Add(Item)

            End If
        Next

    End Sub

    Sub LoadShotCutKey()

        Dim x As Integer = 1
        Dim menuCombo As ContextMenuStrip
        menuCombo = CMS_Menu

        Dim item As ToolStripMenuItem

        If _shortcutKeyDisplay = True Then
            For Each item In menuCombo.Items
                item.ShortcutKeyDisplayString = x 'item.Tag
                item.Width = Me.Width
                x = x + 1
            Next item
        End If

    End Sub

    Private Sub CMS_Menu_Click(sender As Object, e As EventArgs) Handles CMS_Menu.Click
        LNKLLabelCombo.BackColor = _txtBoxBackColorLostFocus
        LNKLLabelCombo.Parent.BackColor = LNKLLabelCombo.BackColor '_bgColorLostFocus

        BTNExpandCombo.Focus()
    End Sub

    Private Sub LNKLLabelCombo_Click(sender As Object, e As EventArgs) Handles LNKLLabelCombo.Click
        Dim link As LinkLabel
        link = CType(sender, LinkLabel)
        link.Focus()

        ExpandCombo()

    End Sub

    Private Sub BTNExpandCombo_Click(sender As Object, e As EventArgs) Handles BTNExpandCombo.Click
        ExpandCombo()

    End Sub

    Public Sub ExpandCombo()
        CMS_Menu.Show(LNKLLabelCombo, 0, LNKLLabelCombo.Height + 3)
    End Sub

    Private Sub LNKLLabelCombo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNKLLabelCombo.LinkClicked
        ' LNKLLabelCombo.BackColor = cor2
        TXT.Text = textCor2
        ExpandCombo()

    End Sub

    Private Sub Objects_MouseMove(sender As Object, e As MouseEventArgs) Handles LNKLLabelCombo.MouseMove, BTNExpandCombo.MouseMove
        Dim obj As Object
        obj = CType(sender, Object)

        obj.Parent.Parent.BackColor = _borderColorGotFocus

        Select Case obj.Name
            Case "LNKLLabelCombo"
                If obj.Focused = True Then
                    obj.BackColor = _backColorCursorMouseLeave
                Else
                    obj.BackColor = _txtBoxBackColorLostFocus
                End If
                obj.Parent.BackColor = obj.BackColor

            Case Else
                If obj.Focused = True Then
                    LNKLLabelCombo.BackColor = _txtBoxBackColorLostFocus
                    LNKLLabelCombo.Parent.BackColor = LNKLLabelCombo.BackColor
                Else
                    LNKLLabelCombo.BackColor = _backColorCursorMouseLeave
                    LNKLLabelCombo.Parent.BackColor = LNKLLabelCombo.BackColor
                End If
                obj.Parent.BackColor = obj.BackColor
        End Select

    End Sub

    Private Sub Objects_MouseLeave(sender As Object, e As EventArgs) Handles LNKLLabelCombo.MouseLeave, BTNExpandCombo.MouseLeave
        Dim obj As Object
        obj = CType(sender, Object)

        If obj.Focused = True Then
            obj.Parent.Parent.BackColor = _borderColorGotFocus

        Else
            obj.Parent.Parent.BackColor = _borderColorLostFocus

        End If

    End Sub

    Private Sub LNKLLabelCombo_MouseLeave(sender As Object, e As EventArgs) Handles LNKLLabelCombo.MouseLeave
        Dim obj As LinkLabel
        obj = CType(sender, LinkLabel)

        If obj.Focused = True Then
            obj.BackColor = _backColorCursorMouseLeave
        Else
            obj.BackColor = _txtBoxBackColorLostFocus
        End If
        obj.Parent.BackColor = obj.BackColor

    End Sub

    Private Sub Objects_GotFocus(sender As Object, e As EventArgs) Handles LNKLLabelCombo.GotFocus, BTNExpandCombo.GotFocus
        Dim obj As Object
        obj = CType(sender, Object)

        obj.Parent.Parent.BackColor = _borderColorGotFocus

        Select Case obj.Name
            Case "LNKLLabelCombo"
                obj.BackColor = _backColorCursorMouseLeave
                obj.Parent.BackColor = obj.BackColor

            Case Else
                LNKLLabelCombo.BackColor = _txtBoxBackColorLostFocus
                LNKLLabelCombo.Parent.BackColor = LNKLLabelCombo.BackColor '_bgColorLostFocus

                obj.BackColor = _txtBoxBackColorLostFocus
                obj.Parent.BackColor = LNKLLabelCombo.BackColor '_bgColorLostFocus

        End Select

    End Sub

    Private Sub Objects_LostFocus(sender As Object, e As EventArgs) Handles LNKLLabelCombo.LostFocus, BTNExpandCombo.LostFocus
        Dim obj As Object
        obj = CType(sender, Object)

        obj.BackColor = _bgColorLostFocus
        obj.Parent.BackColor = obj.BackColor
        obj.Parent.Parent.BackColor = _borderColorLostFocus

    End Sub

    Private Sub Control_ComboBoxPerson_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        BTNExpandCombo.BackColor = _bgColorLostFocus
        BTNExpandCombo.Parent.BackColor = BTNExpandCombo.BackColor

        LNKLLabelCombo.BackColor = _bgColorLostFocus
        LNKLLabelCombo.Parent.BackColor = LNKLLabelCombo.BackColor

        BTNExpandCombo.Parent.Parent.BackColor = _borderColorLostFocus

    End Sub

    Private Sub LNKLLabelCombo_KeyDown(sender As Object, e As KeyEventArgs) Handles LNKLLabelCombo.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.F12 Or e.KeyCode = Keys.LWin Then
            ExpandCombo()

        End If
    End Sub
End Class
