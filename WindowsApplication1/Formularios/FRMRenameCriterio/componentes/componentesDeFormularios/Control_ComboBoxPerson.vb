﻿Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections.ObjectModel
Imports System.Drawing.Design

Public Class Control_ComboBoxPerson
    'TODO : https://www.w3computing.com/vb2008/manipulating-menus-runtime/

    Private configs As Class_Configs

    Const _textDefault As String = "<Selecione>"

    ' Dim myColor As Color = Color.Green
    ' Dim iColor As Integer = myColor.ToArgb()
    ' Dim sColor As String = iColor.ToString

    ' 'To restore:

    'sColor = "-16744448" 'from text file
    'iColor = CInt(sColor)
    'myColor = Color.FromArgb(iColor)


    Public Enum TesteDeEnum
        TesteDeEnum00 = 0
        TesteDeEnum01 = 1
        TesteDeEnum02 = 2
        TesteDeEnum03 = 3
        TesteDeEnum04 = 4
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
    ' Propriedades de configurações internas
    ' __________________________________________________


    Public _textDisplay As String
    Public Property TextDisplay As String
        Get
            Return _textDisplay
        End Get
        Set(value As String)

            _textDisplay = value
            LNKLLabelCombo.Text = _textDisplay 'value

        End Set
    End Property
    ' __________________________________________________

    'TESTE DE PROPRIEDADES

    Private _testeDeArrayList As New ArrayList
    Public Property TesteDeArrayList As ArrayList
        Get
            Return _testeDeArrayList
        End Get
        Set(value As ArrayList)
            _testeDeArrayList = value

        End Set
    End Property

    Private _testeDeListOfString As New List(Of String)
    Public Property TesteDeListOfString As List(Of String)
        Get
            Return _testeDeListOfString
        End Get
        Set(value As List(Of String))
            _testeDeListOfString = value

        End Set
    End Property

    Private _testeDeListOfTreeNode As New List(Of TreeNode)
    Public Property TesteDeListOfTreeNode As List(Of TreeNode)
        Get
            Return _testeDeListOfTreeNode
        End Get
        Set(value As List(Of TreeNode))
            _testeDeListOfTreeNode = value

        End Set
    End Property

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

    Private _myList As List(Of String) = New List(Of String)()

    '<Editor(GetType(MyStringCollectionEditor), GetType(System.Drawing.Design.UITypeEditor))>
    '<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public Property MyList As List(Of String)
        Get
            Return _myList
        End Get
        Set(ByVal value As List(Of String))
            _myList = value
        End Set
    End Property

    Private Icollection As ICollection
    '<EditorAttribute(GetType(System.ComponentModel.Design.CollectionEditor), GetType(System.Drawing.Design.UITypeEditor))>
    Public Property testCollection() As ICollection
        Get
            Return Icollection
        End Get
        Set
            Icollection = Value
        End Set
    End Property

    ' ________________________________________________________

    '    Public Property Value() As Decimal
    '        Get
    '            Return CDec(GetValue(ValueProperty))
    '        End Get
    '        Set(ByVal value As Decimal)
    '            SetValue(ValueProperty, value)
    '        End Set
    '    End Property

    '    [Category("Appearance")]
    '[Description("The text displayed by the control.")] 
    '[Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]


    Private _options As String
    Public Property Options As String
        Get
            Return _options

        End Get
        Set(value As String)
            Lista = value
            _options = value

        End Set
    End Property

    ' Propriedades de configuração dos Slaves

    Private _comboBoxPersonSlave As Control_ComboBoxPerson
    <Category("Configuração do Slave")>
    <Description("Produz um grupo de listas para os menus do ComboBoxPersonSlave. Introduza ponto e vírgula para separar cada item de cada lista.")>
    Public Property ComboBoxPersonSlave As Control_ComboBoxPerson
        Get
            Return _comboBoxPersonSlave
        End Get
        Set(value As Control_ComboBoxPerson)
            _comboBoxPersonSlave = value
        End Set
    End Property

    Dim _comboBoxPersonSlaveLists As New Collections.Specialized.StringCollection
    <Category("Configuração do Slave")>
    <Description("Produz um grupo de listas para os menus do ComboBoxPersonSlave. Introduza ponto e vírgula para separar cada item de cada lista.")>
    <Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")>
    Public Property ComboBoxPersonSlaveLists() As Collections.Specialized.StringCollection
        'http://www.vbforums.com/showthread.php?862825-Accessing-UI-Type-Editor
        Get
            Return _comboBoxPersonSlaveLists
        End Get
        Set(ByVal value As Collections.Specialized.StringCollection)
            _comboBoxPersonSlaveLists = value
        End Set
    End Property

    '____________________________________________________________________________________

    <Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")>
    Dim _subItems As New List(Of Collections.Specialized.StringCollection)
    <Category("Minha Categoria")>
    <Description("Teste de descrição")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public Property SubItems() As List(Of Collections.Specialized.StringCollection)
        'http://www.vbforums.com/showthread.php?862825-Accessing-UI-Type-Editor
        Get
            Return _subItems
        End Get
        Set(ByVal value As List(Of Collections.Specialized.StringCollection))
            _subItems = value
        End Set
    End Property

    'TODO: https://social.msdn.microsoft.com/Forums/windows/en-US/c285e8a8-61bc-4749-9014-84b0d0bb659e/how-can-implement-a-string-collection-editor-in-a-property-grid?forum=winformsdesigner
    'https://www.google.com/search?sxsrf=ALeKk02rGEBszY8SHCv-eCPi2UVYZyoRqA%3A1585238742647&ei=1tJ8XvubJ-6k5OUPobyH-Ag&q=System.Windows.Forms.Design.StringCollectionEditor+visual+basic&oq=System.Windows.Forms.Design.StringCollectionEditor+visual+basic&gs_l=psy-ab.3...1793.7682..8133...0.0..0.283.2800.0j11j4......0....1..gws-wiz.......35i39j0i10i203j0i10i30j33i160j33i10i160j33i21.WceAM9D1PAw&ved=0ahUKEwj73o7BwrjoAhVuErkGHSHeAY8Q4dUDCAs&uact=5
    'https://www.google.com/search?q=user+control+property+usar+outro+editor+para+cole%C3%A7oes+de+string&oq=user+control+property+usar+outro+editor+para+cole%C3%A7oes+de+string&aqs=chrome..69i57.41799j0j4&sourceid=chrome&ie=UTF-8
    Private _optionsList As List(Of String)

    <Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")>
    Public Property OptionsList As List(Of String)
        Get
            Return _optionsList

        End Get
        Set(value As List(Of String))

            _optionsList = value

        End Set
    End Property

    ReadOnly separador() As Char = {";"c, vbCrLf} ' {vbCrLf}

    ReadOnly funcoesDeString As New StringFunctionsClass

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

            If value Is Nothing Then
                value = " ;"
            End If
            valueInStringList = funcoesDeString.SepararPalavras(value, separador)  ' {vbCrLf})
            _lista.Clear()
            _lista.AddRange(valueInStringList)

            AddMenuItens()

        End Set
    End Property

    '-----------------------------------------------------------------

    Private _shortcutKeyDisplay As Boolean
    Public Property ShortcutKeyDisplay As Boolean
        Get
            Return _shortcutKeyDisplay
        End Get
        Set(value As Boolean)
            _shortcutKeyDisplay = value
        End Set
    End Property

    Private _selected As Object
    Public Property Selected As Object
        Get
            Return _selected

        End Get
        Set(value As Object)
            _selected = value

        End Set
    End Property

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Dim newLine As String
        Dim _value As String = ""

        'Options
        If Options IsNot Nothing Then

            For x = 0 To 5
                newLine = ("Teste " & (x + 1)) & ";" 'vbCrLf
                _value &= newLine

            Next

            Options = _value

        End If

        ShortcutKeyDisplay = True

        ' Carrega as cores do componente
#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        _borderColorGotFocus = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._borderColorGotFocus) 'SystemColors.HotTrack
        _borderColorLostFocus = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._borderColorLostFocus) ' Me.BackColor 
        _backColorCursorMouseLeave = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._backColorCursorMouseLeave) 'Color.FromArgb(45, 45, 48)
        _borderColorError = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._borderColorError)  ' Color.Red
        _txtBoxBackColorLostFocus = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._txtBoxBackColorLostFocus)  'Color.FromArgb(63, 63, 66)
        _bgColorLostFocus = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._bgColorLostFocus)   'Me.BackColor
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância

        AddMenuItens()
        If _textDisplay Is Nothing Then TextDisplay = _textDefault

    End Sub

    Private Sub ControlComboBoxPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadShotCutKey()
        LNKLLabelCombo.Text = _textDisplay
    End Sub

    Private Function OptionClick(sender As Object, e As EventArgs)
        Dim itemClicked As New ToolStripMenuItem
        itemClicked = CType(sender, ToolStripMenuItem)

        MsgBox(itemClicked.Name)
        LNKLLabelCombo.Text = itemClicked.Text
        _selected = itemClicked.Text


        If _comboBoxPersonSlave IsNot Nothing Then
            MsgBox("Quantidade de listas Slave: " & _comboBoxPersonSlaveLists.Count)

            If _comboBoxPersonSlaveLists.Count > 0 Then
                _comboBoxPersonSlave.Lista = Me._comboBoxPersonSlaveLists.Item(0)
            End If

        End If

        Return itemClicked.Text
    End Function

    Sub AddMenuItens()

        CMS_Menu.Items.Clear()
        For Each labelItem As String In _lista
            If labelItem <> "" Then

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

    Sub AddHandlerInMenu(obj As ToolStripMenuItem)

        'CMS_Menu.Items.Clear()
        'For Each labelItem As String In _lista
        'If Trim(labelItem) <> "" Then

        'Dim Item As New ToolStripMenuItem With {
        '.Text = labelItem,
        '.ForeColor = Color.DarkGray,
        '.Width = Me.Width
        '       }

        AddHandler obj.Click, New System.EventHandler(AddressOf OptionClick)
        'CMS_Menu.Items.Add(Item)

        '   End If
        'Next

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

        Dim comboBoxPerson As New Control_ComboBoxPerson

        Me.Controls.Add(comboBoxPerson)
        comboBoxPerson.Dock = DockStyle.Top
        comboBoxPerson.Options = "Q;W;E"
        comboBoxPerson.Visible = True
    End Sub

    Public Sub ExpandCombo()
        CMS_Menu.Show(LNKLLabelCombo, 0, LNKLLabelCombo.Height + 3)
    End Sub

    Private Sub LNKLLabelCombo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNKLLabelCombo.LinkClicked

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
