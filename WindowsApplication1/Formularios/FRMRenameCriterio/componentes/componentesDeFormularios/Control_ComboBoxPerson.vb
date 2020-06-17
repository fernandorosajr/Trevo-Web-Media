Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections.ObjectModel
Imports System.Drawing.Design

Public Class Control_ComboBoxPerson
    'TODO : https://www.w3computing.com/vb2008/manipulating-menus-runtime/


    ReadOnly separador() As Char = {";"c, vbCrLf, vbLf, vbCr} ' {vbCrLf}

    'Importação de Classes
    '--------------------------------------------------
    ReadOnly funcoesDeString As New StringFunctionsClass
    Private configs As Class_Configs
    ' -------------------------------------------------

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
        ID = 1
        [String] = 2
        ItemClickedText = 3
        MenuItemType = 4
        [Structure] = 5

    End Enum

    Public Enum DisplayAparenceEnum
        None = 0

        MouseMoveUnFocus = 1
        MouseMoveFocus = 2

        MouseLeaveUnFocus = 3
        MouseLeaveFocus = 4

    End Enum

    Private _returnType As ReturnTypeEnum
    <Category("Dados")>
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

    Private _displayAparence As DisplayAparenceEnum
    Public Property DisplayAparence As DisplayAparenceEnum
        Get
            Return _displayAparence

        End Get
        Set(value As DisplayAparenceEnum)
            _displayAparence = value
            Display()

        End Set
    End Property

    ' Propriedades de configuração de cores
    Private _borderColorError As Color
    <Category("Aparência")>
    Public Property BorderColorError As Color
        Get
            Return _borderColorError
        End Get
        Set(value As Color)
            _borderColorError = value

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

            LNKLLabelCombo.LinkColor = _foreColorActive

        End Set

    End Property

    Private _foreColorPlaceholder As Color
    Public Property ForeColorPlaceholder As Color
        Get
            Return _foreColorPlaceholder

        End Get
        Set(value As Color)
            _foreColorPlaceholder = value

            If SelectedItem Is Nothing Then
                LNKLLabelCombo.LinkColor = _foreColorPlaceholder

            Else
                LNKLLabelCombo.LinkColor = _foreColorActive

            End If

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

    Private _automaticSelect As Boolean
    Public Property AutomaticSelect As Boolean
        Get
            Return _automaticSelect
        End Get
        Set(value As Boolean)
            _automaticSelect = value

        End Set
    End Property

    Private _hideWhenEmptyList As Boolean
    Public Property HideWhenEmptyList As Boolean
        Get
            Return _hideWhenEmptyList
        End Get
        Set(value As Boolean)
            _hideWhenEmptyList = value

        End Set
    End Property
    ' __________________________________________________

    'TESTE DE PROPRIEDADES



    ' ________________________________________________________


    ' Propriedades de configuração dos Slaves
    Public _comboBoxPersonMaster As Control_ComboBoxPerson

    <Category("Configurações do Slave")>
    <Description("Determina o ComboBoxPerson Pai ou Master.")>
    Public Property ComboBoxPersonMaster As Control_ComboBoxPerson
        Get
            Return _comboBoxPersonMaster
        End Get
        Set(value As Control_ComboBoxPerson)
            _comboBoxPersonMaster = value
            AddMenuItens()
        End Set
    End Property

    Private _comboBoxPersonSlave As Control_ComboBoxPerson
    <Category("Configurações do Slave")>
    <Description("Determina o ComboBoxPerson Filho ou Slave.")>
    Public Property ComboBoxPersonSlave As Control_ComboBoxPerson
        Get
            Return _comboBoxPersonSlave
        End Get
        Set(value As Control_ComboBoxPerson)
            _comboBoxPersonSlave = value

            If value IsNot Nothing Then

                _comboBoxPersonSlave._comboBoxPersonMaster = Me

                If _comboBoxPersonSlave._comboBoxPersonMaster IsNot Nothing Then
                    _comboBoxPersonSlave._nivel = _comboBoxPersonSlave._comboBoxPersonMaster._nivel + 1

                Else
                    _nivel = 0
                End If

                _comboBoxPersonSlave._defaultOptionsList = Me._defaultOptionsListSlave


                'If Me._defaultOptionsListSlave Is Nothing Then

                '    If _comboBoxPersonSlave.DefaultOptionsList Is Nothing Then
                '        Me._defaultOptionsListSlave = _comboBoxPersonSlave.OptionsList
                '        _comboBoxPersonSlave._defaultOptionsList = Me._defaultOptionsListSlave

                '    Else
                '        Me._defaultOptionsListSlave = _comboBoxPersonSlave.DefaultOptionsList
                '    End If

                'Else
                '    _comboBoxPersonSlave._defaultOptionsList = Me._defaultOptionsListSlave
                'End If

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

    Private _defaultOptionsListSlave As New Collections.Specialized.StringCollection
    <Category("Dados")>
    <Description("Determina uma lista de itens de opções padrão para ser aplicado no ComboBoxPersonSlave quando não há uma lista de opções disponíveis.")>
    <Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")>
    Public Property DefaultOptionsListSlave() As Collections.Specialized.StringCollection
        Get
            Return _defaultOptionsListSlave
        End Get
        Set(value As Collections.Specialized.StringCollection)
            _defaultOptionsListSlave = value

            If Me._comboBoxPersonSlave IsNot Nothing Then
                _comboBoxPersonSlave.DefaultOptionsList = value
            End If

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
        Dim [String] As String
    End Structure

    ' Define the property.
    Private _dataReturn As Object
    <Category("Dados")>
    <Description("Retorna dados do componente.")>
    Public Property DataReturn() As Object
        Get
            Return _dataReturn
        End Get
        Set(ByVal value As Object)
            _dataReturn = value
        End Set
    End Property

    Dim _returnStringList As New Collections.Specialized.StringCollection
    <Category("Dados")>
    <Description("Determina uma lista em formato texto para ser retornada na ordem da lista de opções.")>
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


    Private _selectedItem As ToolStripMenuItem
    'Private _selected As List(Of ToolStripMenuItem)
    <Category("Dados")>
    <Description("Seleciona e retorna um item de menu expecífico.")>
    Public Property SelectedItem() As ToolStripMenuItem
        Get
            'ReturnSelected()
            Return _selectedItem

        End Get
        Set(value As ToolStripMenuItem)


            _selectedItem = value

            If value IsNot Nothing Then
                LNKLLabelCombo.Text = value.Text
                SelectItemClicked(value)

            End If

        End Set
    End Property


    'TODO: https://social.msdn.microsoft.com/Forums/windows/en-US/c285e8a8-61bc-4749-9014-84b0d0bb659e/how-can-implement-a-string-collection-editor-in-a-property-grid?forum=winformsdesigner
    'https://www.google.com/search?sxsrf=ALeKk02rGEBszY8SHCv-eCPi2UVYZyoRqA%3A1585238742647&ei=1tJ8XvubJ-6k5OUPobyH-Ag&q=System.Windows.Forms.Design.StringCollectionEditor+visual+basic&oq=System.Windows.Forms.Design.StringCollectionEditor+visual+basic&gs_l=psy-ab.3...1793.7682..8133...0.0..0.283.2800.0j11j4......0....1..gws-wiz.......35i39j0i10i203j0i10i30j33i160j33i10i160j33i21.WceAM9D1PAw&ved=0ahUKEwj73o7BwrjoAhVuErkGHSHeAY8Q4dUDCAs&uact=5
    'https://www.google.com/search?q=user+control+property+usar+outro+editor+para+cole%C3%A7oes+de+string&oq=user+control+property+usar+outro+editor+para+cole%C3%A7oes+de+string&aqs=chrome..69i57.41799j0j4&sourceid=chrome&ie=UTF-8

    Private _optionListCommaSeparated As String
    Private _optionsList As Collections.Specialized.StringCollection
    <Category("Dados")>
    <Description("Determina a lista de itens de menu de opções.")>
    <Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")>
    Public Property OptionsList() As Collections.Specialized.StringCollection
        Get
            Return _optionsList

        End Get
        Set(value As Collections.Specialized.StringCollection)
            _optionsList = (value)

            If _defaultOptionsList Is Nothing Then
                _defaultOptionsList = _optionsList
            End If
            AddMenuItens()

        End Set
    End Property

    Private _listaDeOpçõesPadrão As Collections.Specialized.StringCollection
    <Category("Indeterminado")>
    <Description("Produz um grupo de listas para os menus do ComboBoxPersonSlave. Introduza ponto e vírgula para separar cada item de cada lista.")>
    <Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")>
    Public Property ListaDeOpçõesPadrão() As Collections.Specialized.StringCollection
        Get
            Return _listaDeOpçõesPadrão
        End Get
        Set(value As Collections.Specialized.StringCollection)
            _listaDeOpçõesPadrão = value
        End Set
    End Property

    Private _defaultOptionsListCommaSeparated As String
    Private _defaultOptionsList As Collections.Specialized.StringCollection
    <Category("Dados")>
    <Description("Determina uma lista de opções padrão do componente.")>
    <Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")>
    Public Property DefaultOptionsList() As Collections.Specialized.StringCollection
        Get

            'Return Get_ListOptions(_defaultOptionsList)
            Return (_defaultOptionsList)

        End Get
        Set(value As Collections.Specialized.StringCollection)
            '  _defaultOptionListCommaSeparated = value
            _defaultOptionsList = value

            If _optionsList Is Nothing Then
                _optionsList = _defaultOptionsList
            End If

            If _comboBoxPersonMaster IsNot Nothing Then
                _comboBoxPersonMaster._defaultOptionsListSlave = value
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
        Dim list As New Collections.Specialized.StringCollection

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

        _foreColorActive = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._foreColorActive)
        _foreColorPlaceholder = ColorTranslator.FromWin32(configs.TrevoSystemColorEnum._foreColorPlaceholder)

#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância

        AddMenuItens()
        If _textDisplay Is Nothing Then TextDisplay = _textDefault

        _nivel = 0

        _optionsList = list

        AtualizarForeColor()

    End Sub

    Public Sub AtualizarForeColor()
        If SelectedItem Is Nothing Then
            LNKLLabelCombo.LinkColor = _foreColorPlaceholder

        Else
            LNKLLabelCombo.LinkColor = _foreColorActive

        End If

    End Sub

    Private Sub ControlComboBoxPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadShotCutKey()

        LNKLLabelCombo.Text = _textDisplay

        AddMenuItens()

        If SelectedItem IsNot Nothing Then
            PerformAutomaticSelection(SelectedItem.Tag.ID)

        Else
            PerformAutomaticSelection(0)

        End If

    End Sub

    Public Sub PerformAutomaticSelection(index As Integer)
        'TODO: Pode manter integer para caso o usuari queira criar mais de 255 itens.

        Dim y As Integer = CMS_Menu.Items.Count - 1

        If _automaticSelect = True Then

            Dim _returnItem As New ReturnItem

            If CMS_Menu.Items.Count > 0 Then
                If index > y Then index = y

                For Each i As ToolStripMenuItem In CMS_Menu.Items
                    i.Checked = False
                Next

                _selectedItem = CMS_Menu.Items.Item(index)

                _returnItem = _selectedItem.Tag

                Add_comboBoxPersonSlaveListsIn_comboBoxPersonSlave(_returnItem.ID)

                Me.LNKLLabelCombo.Text = _selectedItem.Text
                _selectedItem.Checked = True

            Else
                Me.LNKLLabelCombo.Text = TextDisplay
                Me.SelectedItem = Nothing
            End If
            ' End If
            AtualizarForeColor()
        End If
    End Sub

    Public Sub PerformHideWhenEmptyList()
        If _comboBoxPersonSlave IsNot Nothing Then

            If _hideWhenEmptyList = True Then

                If _comboBoxPersonSlave.CMS_Menu.Items.Count = 0 Then

                    _comboBoxPersonSlave.Visible = False

                Else

                    _comboBoxPersonSlave.Visible = True

                End If

            Else
                _comboBoxPersonSlave.Visible = True

            End If

        End If

    End Sub

    Public Function OptionClick(sender As Object, e As EventArgs) As Object

        Dim itemClicked As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        Dim checked As Boolean = itemClicked.Checked

        Dim _returnItem As New ReturnItem

        _returnItem = itemClicked.Tag

        ' Aqui injeta no slave a lista de slave criada no master
        If _comboBoxPersonSlave IsNot Nothing Then
            ' MsgBox("Quantidade de listas Slave: " & _comboBoxPersonSlaveLists.Count)

            If _comboBoxPersonSlaveLists.Count > 0 Then

                ' TODO: Talvez isto devesse ser uma função unica
                ' ___________________________________________________________________
                ' ___________________________________________________________________
                If (CInt(_returnItem.ID)) <= (_comboBoxPersonSlaveLists.Count - 1) Then
                    ' TODO: Esta condição é repetida dentro da função em sequeucia

                    ' TODO: Transformar isto em uma FUNÇÃO (OK)
                    Add_comboBoxPersonSlaveListsIn_comboBoxPersonSlave(_returnItem.ID)

                    '_comboBoxPersonSlave.PerformAutomaticSelection(0)

                    PerformHideWhenEmptyList()

                Else
                    If Me.DefaultOptionsList IsNot Nothing Then
                        _comboBoxPersonSlave.OptionsList = Me.DefaultOptionsListSlave
                        '_comboBoxPersonSlave.LNKLLabelCombo.Text = _comboBoxPersonSlave.TextDisplay
                        _comboBoxPersonSlave.LNKLLabelCombo.Text = _comboBoxPersonSlave.TextDisplay

                        _comboBoxPersonSlave.SelectedItem = Nothing
                        _comboBoxPersonSlave.AtualizarForeColor()

                    End If

                    ' ___________________________________________________________________
                    ' ___________________________________________________________________

                End If

            End If

        End If

        '--------------------------------------------

        'Dim Retornar As Object = SelectItemClicked(itemClicked)
        SelectedItem = itemClicked

        AtualizarForeColor()

        Return SelectedItem.Tag

    End Function

    Sub Add_comboBoxPersonSlaveListsIn_comboBoxPersonSlave(_id As Integer)

        If Me._comboBoxPersonSlaveLists.Count > 0 Then
            Dim strSlaveList As String

            If _id <= Me._comboBoxPersonSlaveLists.Count - 1 Then

                strSlaveList = Me._comboBoxPersonSlaveLists.Item(_id)

                _comboBoxPersonSlave.OptionsList = funcoesDeString.ConverteStringEmColectionString(strSlaveList, separador)

                _comboBoxPersonSlave.PerformAutomaticSelection(0)
            End If
        End If

    End Sub

    Public Function SelectItemClicked(itemClicked As ToolStripMenuItem)

        Dim _returnItem As New ReturnItem
        Dim Retornar As Object = ""

        ' LNKLLabelCombo.Text = itemClicked.Text
        ' Selected = itemClicked


        For Each item As ToolStripMenuItem In CMS_Menu.Items
            If itemClicked.Name <> item.Name Then
                item.Checked = False

            Else
                item.Checked = True

            End If
        Next

        _returnItem = itemClicked.Tag

        Select Case _returnType

            Case ReturnTypeEnum.None
                Retornar = Nothing
               ' MsgBox("O retorno é Nothing")

            Case ReturnTypeEnum.ID
                Retornar = _returnItem.ID
             '   MsgBox("ID = " & Retornar)

            Case ReturnTypeEnum.MenuItemType
                Retornar = itemClicked
              '  MsgBox("Retonando intem clicado")

            Case ReturnTypeEnum.Structure
                Retornar = _returnItem
              '  MsgBox("KEY =  " + _returnItem.String + Chr(13) + "ID: " + _returnItem.ID.ToString)


            Case ReturnTypeEnum.String
                Retornar = _returnItem.String
              '  MsgBox("A KEY é " + Retornar)

            Case ReturnTypeEnum.ItemClickedText
                Retornar = itemClicked.Text
                '  MsgBox("O texto é  " + Retornar)

            Case Else

        End Select

        DataReturn = Retornar

        Return Retornar

    End Function

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
                    If _optionsList.Count > _returnStringList.Count And y = _returnStringList.Count Then
                        _returnStringList.Add("")
                        _returnItem.String = _returnStringList.Item(y)

                    Else
                        _returnItem.String = _returnStringList.Item(y)

                    End If
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

    'Function PassarFuncao(OptionClick)
    '    AddHandler SelectedItem.Click, New System.EventHandler(AddressOf OptionClick)
    '    '  CMS_Menu.Items.Add(Item)
    'End Function

    Private Function AddID_InReturnItem(ByVal y As Integer) As Integer
        Dim int As Integer = y

        If _nivel > 0 Then
            int = Me._comboBoxPersonMaster._optionsList.Count + y
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
                x += 1
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
        Me.Focus()
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

        Me.Focus()

    End Sub


    Private Sub Objects_MouseMove(sender As Object, e As MouseEventArgs) Handles LNKLLabelCombo.MouseMove, BTNExpandCombo.MouseMove
        Dim obj As Object
        obj = CType(sender, Object)

        If LNKLLabelCombo.Focused = True Then
            _displayAparence = DisplayAparenceEnum.MouseMoveFocus

        Else
            _displayAparence = DisplayAparenceEnum.MouseMoveUnFocus

        End If

        Display()

    End Sub
    Sub Display()

        Select Case _displayAparence

            Case DisplayAparenceEnum.None

            Case DisplayAparenceEnum.MouseLeaveFocus
                PanelBorder_PanelCombo.BackColor = _borderColorGotFocus

            Case DisplayAparenceEnum.MouseLeaveUnFocus
                LNKLLabelCombo.BackColor = _bgColorLostFocus
                LNKLLabelCombo.Parent.BackColor = LNKLLabelCombo.BackColor
                PanelBorder_PanelCombo.BackColor = _borderColorLostFocus

            Case DisplayAparenceEnum.MouseMoveFocus

                PanelBorder_PanelCombo.BackColor = _borderColorGotFocus
                LNKLLabelCombo.BackColor = _backColorCursorMouseLeave
                LNKLLabelCombo.Parent.BackColor = LNKLLabelCombo.BackColor

            Case DisplayAparenceEnum.MouseMoveUnFocus
                LNKLLabelCombo.BackColor = _txtBoxBackColorLostFocus
                LNKLLabelCombo.Parent.BackColor = LNKLLabelCombo.BackColor
                PanelBorder_PanelCombo.BackColor = _borderColorGotFocus

        End Select
    End Sub

    Private Sub Objects_MouseLeave(sender As Object, e As EventArgs) Handles LNKLLabelCombo.MouseLeave, BTNExpandCombo.MouseLeave
        Dim obj As Object
        obj = CType(sender, Object)

        If LNKLLabelCombo.Focused = True Or BTNExpandCombo.Focused = True Then
            _displayAparence = DisplayAparenceEnum.MouseLeaveFocus

        Else
            _displayAparence = DisplayAparenceEnum.MouseLeaveUnFocus

        End If

        Display()

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


        _displayAparence = DisplayAparenceEnum.MouseMoveFocus

        Display()


    End Sub

    Private Sub Objects_LostFocus(sender As Object, e As EventArgs) Handles LNKLLabelCombo.LostFocus, BTNExpandCombo.LostFocus

        _displayAparence = DisplayAparenceEnum.MouseLeaveUnFocus

        Display()

    End Sub

    Private Sub Control_ComboBoxPerson_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus

        'BTNExpandCombo.BackColor = _bgColorLostFocus
        'BTNExpandCombo.Parent.BackColor = BTNExpandCombo.BackColor

        'LNKLLabelCombo.BackColor = _bgColorLostFocus
        'LNKLLabelCombo.Parent.BackColor = LNKLLabelCombo.BackColor

        'BTNExpandCombo.Parent.Parent.BackColor = _borderColorLostFocus

    End Sub

    Private Sub LNKLLabelCombo_KeyDown(sender As Object, e As KeyEventArgs) Handles LNKLLabelCombo.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Space Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.F12 Or e.KeyCode = Keys.LWin Then
            ExpandCombo()
        End If
    End Sub

    Private Sub TXT_TextChanged(sender As Object, e As EventArgs) Handles TXT.TextChanged

    End Sub
End Class
