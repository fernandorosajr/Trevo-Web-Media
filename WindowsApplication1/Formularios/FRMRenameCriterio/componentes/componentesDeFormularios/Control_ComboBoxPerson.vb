Public Class Control_ComboBoxPerson
    'TODO : https://www.w3computing.com/vb2008/manipulating-menus-runtime/

    Public Enum TesteDeEnum
        Teste01 = 1
        Teste02 = 2
        Teste03 = 3
        Teste04 = 4
    End Enum

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

        For x = 0 To 5
            newLine = ("Teste " & (x + 1)) & ";" 'vbCrLf
            _value = _value & newLine

        Next

        Options = _value
        Lista = Options

        ShortcutKeyDisplay = True

    End Sub
    Private Sub ControlComboBoxPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddMenuItens()
        LoadShotCutKey()

    End Sub

    Private Sub NoneToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CMS_TipoDeProcesso_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CMS_Menu.Opening

    End Sub

    Private Sub OptionClick(sender As Object, e As EventArgs)
        Dim itemClicked As New ToolStripMenuItem
        itemClicked = CType(sender, ToolStripMenuItem)
        ' MsgBox("You have selected the item " & itemClicked.Text)

        LNKLLabelCombo.Text = itemClicked.Text

    End Sub

    Function AddMenuItens()

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

        Return True
    End Function

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

    End Sub

    Private Sub LNKLLabelCombo_Click(sender As Object, e As EventArgs) Handles LNKLLabelCombo.Click
        Dim link As LinkLabel
        link = CType(sender, LinkLabel)

        ExpandCombo()

    End Sub

    Private Sub BTNExpandCombo_Click(sender As Object, e As EventArgs) Handles BTNExpandCombo.Click
        ExpandCombo()

    End Sub

    Public Sub ExpandCombo()
        CMS_Menu.Show(LNKLLabelCombo, 0, LNKLLabelCombo.Height + 3)
    End Sub

End Class
