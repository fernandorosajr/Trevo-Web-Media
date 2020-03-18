Public Class Control_ComboBoxPerson
    'TODO : https://www.w3computing.com/vb2008/manipulating-menus-runtime/

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

    ReadOnly separador() As Char = {";"c, vbCrLf} ' {vbCrLf}

    Private _lista As New ArrayList()
    Public Property Lista As String
        'Dim listaArray As New ArrayList()
        Get
            Dim listaEmString As String = ""
            'Return _lista
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

    End Sub
    Private Sub ControlComboBoxPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddMenuItens()

    End Sub

    Private Sub NoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoneToolStripMenuItem.Click

    End Sub

    Private Sub CMS_TipoDeProcesso_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CMS_Menu.Opening

    End Sub

    Private Sub OptionClick(sender As Object, e As EventArgs)
        Dim itemClicked As New ToolStripMenuItem
        itemClicked = CType(sender, ToolStripMenuItem)
        MsgBox("You have selected the item " &
            itemClicked.Text)
    End Sub

    Sub AddMenuItens()


        ' Item.Text = "Run Time Option" & RunTimeMenuToolStripMenuItem
        'DropDownItems.Count.ToString
        ' RunTimeMenuToolStripMenuItem.DropDownItems.Add(Item)

        For Each labelItem As String In _lista
            Dim Item As New ToolStripMenuItem

            Item.Text = labelItem

            AddHandler Item.Click, New System.EventHandler(AddressOf OptionClick)

            CMS_Menu.Items.Add(Item)
        Next

    End Sub

    Private Sub CMS_Menu_Click(sender As Object, e As EventArgs) Handles CMS_Menu.Click
        Dim menuO As ContextMenuStrip
        menuO = CType(sender, ContextMenuStrip)
        Dim tsmi As ToolStripMenuItem


        For Each tsmi In menuO.Items
            tsmi.ShortcutKeyDisplayString = "Merged Item"
        Next tsmi
    End Sub
End Class
