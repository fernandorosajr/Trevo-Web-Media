Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections.ObjectModel
Imports System.Drawing.Design

Public Class Control_ComboBoxPerson
    'TODO : https://www.w3computing.com/vb2008/manipulating-menus-runtime/

    Private configs As Class_Configs

    Const _textDefault As String = "<Selecione>"
    Const LabelMenuItem As String = "MenuItem_"

    Private _nivel As Integer
    <Category("Configurações do Slave")>
    <Description("Produz um grupo de listas para os menus do ComboBoxPersonSlave. Introduza ponto e vírgula para separar cada item de cada lista.")>
    Public Property Nivel As Integer
        Get
            Return _nivel

        End Get
        Set(value As Integer)
            _nivel = value
        End Set
    End Property

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

    Public Enum ReturnTypeEnum

        None = 0
        IntegerType = 1
        StringType = 2
        Text = 3
        MenuItemType = 4
        StructureType = 5

    End Enum

    Private _returnType As ReturnTypeEnum
    <Category("Lista de Opções")>
    <Description("Define uma lista de opções para este objeto separada por vírgula.")>
    Public Property ReturnType As ReturnTypeEnum
        Get
            Return _returnType
        End Get
        Set(value As ReturnTypeEnum)
            _returnType = value
        End Set
    End Property

    Public returnValue As Object

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


    ' Propriedades de configuração dos Slaves
    <Category("Configurações do Slave")>
    <Description("Produz um grupo de listas para os menus do ComboBoxPersonSlave. Introduza ponto e vírgula para separar cada item de cada lista.")>
    Public Property ComboBoxPersonMasterProp As Control_ComboBoxPerson
        Get
            Return ComboBoxPersonMaster
        End Get
        Set(value As Control_ComboBoxPerson)
            ComboBoxPersonMaster = value
        End Set
    End Property

    Public ComboBoxPersonMaster As Control_ComboBoxPerson
    Private _comboBoxPersonSlave As Control_ComboBoxPerson
    <Category("Configurações do Slave")>
    <Description("Produz um grupo de listas para os menus do ComboBoxPersonSlave. Introduza ponto e vírgula para separar cada item de cada lista.")>
    Public Property ComboBoxPersonSlave As Control_ComboBoxPerson
        Get
            Return _comboBoxPersonSlave
        End Get
        Set(value As Control_ComboBoxPerson)
            _comboBoxPersonSlave = value

            If value IsNot Nothing Then

                _comboBoxPersonSlave.ComboBoxPersonMaster = Me

                If _comboBoxPersonSlave.ComboBoxPersonMaster IsNot Nothing Then
                    _comboBoxPersonSlave._nivel = _comboBoxPersonSlave.ComboBoxPersonMaster._nivel + 1

                Else
                    _nivel = 0
                End If

            End If

            If Me._defaultOptionsListSlave Is Nothing Then
                If value IsNot Nothing Then
                    If _comboBoxPersonSlave.DefaultOptionsList Is Nothing Then
                        Me._defaultOptionsListSlave = _comboBoxPersonSlave.OptionsList
                    End If

                End If
            End If

        End Set
    End Property

    ' TODO : Estudar manipulação de eventos https://docs.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/events/

    Dim _comboBoxPersonSlaveLists As New Collections.Specialized.StringCollection
    <Category("Configurações do Slave")>
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


    Private _defaultOptionsListSlave As Collections.Specialized.StringCollection
    <Category("Configurações do Slave")>
    <Description("Define uma lista de opções para este objeto separada por vírgula.")>
    Public Property DefaultOptionsListSlave As Collections.Specialized.StringCollection
        Get
            Return _defaultOptionsListSlave
        End Get

        Set(value As Collections.Specialized.StringCollection)
            _defaultOptionsListSlave = value

        End Set
    End Property
    ' -------------------------------------------------------------------------

    'Private _comboBoxPersonSlave As Control_ComboBoxPerson
    '<Category("Configurações do Slave")>
    '<Description("Produz um grupo de listas para os menus do ComboBoxPersonSlave. Introduza ponto e vírgula para separar cada item de cada lista.")>
    'Public Property ComboBoxPersonSlave As Control_ComboBoxPerson
    '    Get
    '        Return _comboBoxPersonSlave
    '    End Get
    '    Set(value As Control_ComboBoxPerson)
    '        _comboBoxPersonSlave = value

    '        If Me._defaultOptionsListSlave Is Nothing Then
    '            If value IsNot Nothing Then
    '                If _comboBoxPersonSlave.DefaultOptionsList Is Nothing Or _comboBoxPersonSlave.DefaultOptionsList = "" Then
    '                    Me._defaultOptionsListSlave = _comboBoxPersonSlave.OptionsList
    '                End If

    '            End If
    '        End If

    '    End Set
    'End Property

    ' ---------------------------------------------------
    ' Propriedade se dados 
    Public Structure ReturnItem
        Dim ID As Integer
        Dim key As String
    End Structure

    <Category("Dados")>
    <Description("Define uma estrutura de retorno de dados.")>
    Private _dataReturn As ReturnItem
    ' Define the property.
    Public Property DataReturn() As ReturnItem
        Get
            Return _dataReturn
        End Get
        Set(ByVal value As ReturnItem)
            _dataReturn = value
        End Set
    End Property

    Dim _returnStringList As New Collections.Specialized.StringCollection
    <Category("Configurações do Slave")>
    <Description("Produz um grupo de listas para os menus do ComboBoxPersonSlave. Introduza ponto e vírgula para separar cada item de cada lista.")>
    <Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")>
    Public Property ReturnStringList() As Collections.Specialized.StringCollection
        'http://www.vbforums.com/showthread.php?862825-Accessing-UI-Type-Editor
        Get
            Return _returnStringList
        End Get
        Set(ByVal value As Collections.Specialized.StringCollection)
            _returnStringList = value
        End Set
    End Property

    '------------------------------------------------------------


    Private SelectedItem As ToolStripMenuItem
    Private _selected As List(Of ToolStripMenuItem)
    <Category("Configurações do Slave")>
    <Description("Seleciona item de menu expecífico.")>
    Public Property Selected() As ToolStripMenuItem
        Get
            ReturnSelected()
            Return SelectedItem

        End Get
        Set(value As ToolStripMenuItem)
            If _selected IsNot Nothing Then
                For Each item As ToolStripMenuItem In _selected
                    If item.Name <> value.Name Then
                        item.Checked = False
                    Else
                        item.Checked = True
                    End If
                Next

            End If
            SelectedItem = value

        End Set
    End Property
    Function ReturnSelected()
        ' Dim _selectedItem As ToolStripMenuItem = Nothing
        If _selected IsNot Nothing Then
            For Each item As ToolStripMenuItem In _selected
                If item.Checked = True Then
                    SelectedItem = item
                    Exit For
                Else
                    SelectedItem = Nothing
                End If
            Next

        End If
        Return SelectedItem
    End Function
    'TODO: https://social.msdn.microsoft.com/Forums/windows/en-US/c285e8a8-61bc-4749-9014-84b0d0bb659e/how-can-implement-a-string-collection-editor-in-a-property-grid?forum=winformsdesigner
    'https://www.google.com/search?sxsrf=ALeKk02rGEBszY8SHCv-eCPi2UVYZyoRqA%3A1585238742647&ei=1tJ8XvubJ-6k5OUPobyH-Ag&q=System.Windows.Forms.Design.StringCollectionEditor+visual+basic&oq=System.Windows.Forms.Design.StringCollectionEditor+visual+basic&gs_l=psy-ab.3...1793.7682..8133...0.0..0.283.2800.0j11j4......0....1..gws-wiz.......35i39j0i10i203j0i10i30j33i160j33i10i160j33i21.WceAM9D1PAw&ved=0ahUKEwj73o7BwrjoAhVuErkGHSHeAY8Q4dUDCAs&uact=5
    'https://www.google.com/search?q=user+control+property+usar+outro+editor+para+cole%C3%A7oes+de+string&oq=user+control+property+usar+outro+editor+para+cole%C3%A7oes+de+string&aqs=chrome..69i57.41799j0j4&sourceid=chrome&ie=UTF-8


    ReadOnly separador() As Char = {";"c, vbCrLf, vbLf, vbCr} ' {vbCrLf}

    ReadOnly funcoesDeString As New StringFunctionsClass

    Private _optionListCommaSeparated As String
    Private _optionsList As Collections.Specialized.StringCollection
    <Category("Configurações do Slave")>
    <Description("Produz um grupo de listas para os menus do ComboBoxPersonSlave. Introduza ponto e vírgula para separar cada item de cada lista.")>
    <Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")>
    Public Property OptionsList() As Collections.Specialized.StringCollection
        Get

            ' Return Get_ListOptions(_optionsList)
            Return _optionsList

        End Get
        Set(value As Collections.Specialized.StringCollection)

            ' _optionListCommaSeparated = value
            _optionsList = (value)
            AddMenuItens()

        End Set
    End Property

    Private _defaultOptionListCommaSeparated As String
    Private _defaultOptionsList As Collections.Specialized.StringCollection
    <Category("Configurações do Slave")>
    <Description("Produz um grupo de listas para os menus do ComboBoxPersonSlave. Introduza ponto e vírgula para separar cada item de cada lista.")>
    <Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")>
    Public Property DefaultOptionsList() As Collections.Specialized.StringCollection
        Get

            'Return Get_ListOptions(_defaultOptionsList)
            Return (_defaultOptionsList)

        End Get
        Set(value As Collections.Specialized.StringCollection)
            '  _defaultOptionListCommaSeparated = value
            _defaultOptionsList = (value)

            If _optionsList Is Nothing Then
                _optionsList = _defaultOptionsList
            End If

            AddMenuItens()
        End Set
    End Property

    Private Function Get_ListOptions(_optsList As ArrayList) As String

        Dim StringList As String = ""

        Dim x As Integer = 0
        For Each str As String In _optsList
            If _optsList.Count = x Then
                StringList = StringList & str
            Else
                StringList = StringList & str & ";" 'vbCrLf
            End If
            x += 1
        Next
        Return StringList
    End Function

    Private Function Set_ListOptions(value As String) As ArrayList
        Dim valueInStringList As New ArrayList

        valueInStringList.Clear()
        valueInStringList.AddRange(funcoesDeString.SepararPalavras(value, separador))

        Return valueInStringList
    End Function
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



    Public Sub New()
        Dim list As New Collections.Specialized.StringCollection From {
            ""
        }

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        'Dim newLine As String
        'Dim _value As String = ""

        'Options
        'If OptionsList IsNot Nothing Then

        '    For x = 0 To 5
        '        newLine = ("Teste " & (x + 1)) & ";" 'vbCrLf
        '        _value &= newLine

        '    Next

        '    OptionsList = _value

        'End If

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


        If _selected IsNot Nothing Then _selected.Clear()

        For Each MenuItem As ToolStripMenuItem In CMS_Menu.Items
            _selected.Add(MenuItem)
        Next

        _nivel = 0

        _optionsList = list

    End Sub

    Private Sub ControlComboBoxPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadShotCutKey()
        LNKLLabelCombo.Text = _textDisplay
        AddMenuItens()
    End Sub

    Private Function OptionClick(sender As Object, e As EventArgs) As Object
        Dim itemClicked As New ToolStripMenuItem

        itemClicked = CType(sender, ToolStripMenuItem)

        Dim checked As Boolean = itemClicked.Checked

        Dim _returnItem As New ReturnItem

        Dim Retornar As Object = ""

        MsgBox(itemClicked.Name)

        'ReturnSelected()
        LNKLLabelCombo.Text = itemClicked.Text
        Selected = itemClicked

        If Selected IsNot Nothing Then

            MsgBox("Selecionado : " + Selected.Text)
        Else

            MsgBox("Nao Selecionado : ")
        End If

        For Each item As ToolStripMenuItem In CMS_Menu.Items
            If itemClicked.Name <> item.Name Then
                item.Checked = False
            End If
        Next

        ' Aqui injeta no slave a lista de slave criada no master
        If _comboBoxPersonSlave IsNot Nothing Then
            MsgBox("Quantidade de listas Slave: " & _comboBoxPersonSlaveLists.Count)

            If _comboBoxPersonSlaveLists.Count > 0 Then
                ' _comboBoxPersonSlave.OptionsList = Me._comboBoxPersonSlaveLists.Item(0)
                ' TODO : Converter o item separado por virgula em  As Collections.Specialized.StringCollection
            End If

        End If

        '--------------------------------------------

        _returnItem = itemClicked.Tag

        Select Case _returnType

            Case ReturnTypeEnum.None
                Retornar = Nothing
                MsgBox("O retorno é Nothing")

            Case ReturnTypeEnum.IntegerType
                Retornar = _returnItem.ID
                MsgBox(VarType(Retornar))

            Case ReturnTypeEnum.MenuItemType
                Retornar = itemClicked

            Case ReturnTypeEnum.StructureType
                Retornar = _returnItem
                MsgBox("Text =  " + _returnItem.key + Chr(13) + "ID: " + _returnItem.ID.ToString)


            Case ReturnTypeEnum.StringType
                Retornar = _returnItem.key
                MsgBox("A KEY é " + Retornar)

            Case ReturnTypeEnum.Text
                Retornar = itemClicked.Text
                MsgBox("O texto é  " + Retornar)


            Case Else

        End Select

        Return Retornar

    End Function

    Sub SelectItemClicked(itemClicked As ToolStripMenuItem)

    End Sub

    Sub AddMenuItens()

        CMS_Menu.Items.Clear()

        Dim x As Integer = CMS_Menu.Items.Count
        Dim y As Integer = 0
        Dim name As String

        If _optionsList IsNot Nothing Then
            For Each labelItem As String In _optionsList

                Dim _returnItem As New ReturnItem

                If _returnStringList.Count > 0 Then
                    'MsgBox(_returnStringList.Item(y).ToString)
                    _returnItem.key = _returnStringList.Item(y)
                End If

                _returnItem.ID = AddID_InReturnItem(y)

                If labelItem <> "" Then

                    name = LabelMenuItem.ToString + x.ToString
                    Dim Item As New ToolStripMenuItem With {
                    .Text = labelItem,
                    .Name = name,
                    .ForeColor = Color.DarkGray,
                    .Width = Me.Width,
                    .Tag = _returnItem,
                    .CheckOnClick = True
                }

                    y += 1
                    x += 1
                    AddHandler Item.Click, New System.EventHandler(AddressOf OptionClick)
                    CMS_Menu.Items.Add(Item)

                End If
            Next

        End If

    End Sub

    Private Function AddID_InReturnItem(y As Integer) As Integer
        Dim int As Integer

        If _nivel > 0 Then
            int = Me.ComboBoxPersonMaster._optionsList.Count + y

        Else
            int = y
        End If

        Return int

    End Function

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
