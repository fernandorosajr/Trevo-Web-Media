'Imports System.Security.Cryptography.X509Certificates

Imports System.Reflection

Public Class Control_RenameOption



    Private _pai As Control_LoadRenameOption

    Private _activeDelete As Boolean
    Public Property ActiveDelete As Boolean
        Get
            Return _activeDelete

        End Get
        Set(value As Boolean)
            _activeDelete = value

            If _activeDelete = True Then
                BTNRemoveRenomeDeOrigem.BackgroundImage = My.Resources.minus
                BTNRemoveRenomeDeOrigem.Enabled = True

            Else
                BTNRemoveRenomeDeOrigem.BackgroundImage = My.Resources.minus_inativo_50
                BTNRemoveRenomeDeOrigem.Enabled = False

            End If

        End Set
    End Property

    Private _id As Integer
    Public Property ID As Integer
        Get
            Return _id

        End Get
        Set(value As Integer)
            _id = value

        End Set
    End Property

    Private _dataReturn As Object
    Public Property DataReturn As Object
        Get
            Return _dataReturn

        End Get
        Set(value As Object)
            _dataReturn = value

        End Set
    End Property

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        _id = 0

        'Dim pai As Control_LoadRenameOption =
        ActiveDelete = False



    End Sub

    'Public Sub Finalize()

    'End Sub

    Sub MostrarOrdem()
        For Each item In Me.Parent.Controls
            MsgBox(item.ID)
        Next
    End Sub

    Sub OrdenarRenameOption()
        'TODO: https://csharp.net-tutorials.com/pt/439/linq/organizando-dados-os-metodos-orderby-thenby/


        Dim listControl(Me.Parent.Controls.Count - 1) As Control

        ' Me.Parent.Visible = False

        For Each item As Control_RenameOption In Me.Parent.Controls

            item.TabIndex = item.ID
            ' item.Width = Me.Parent.Width

            listControl(item.ID) = item

        Next

        Me.Parent.Controls.AddRange(listControl.Reverse.ToArray)

        'Me.Parent.Visible = True
        ' Me.Parent.Refresh()

        'For x As Integer = 0 To Me.Parent.Controls.Count - 1
        '    For Each item As Control_RenameOption In Me.Parent.Controls
        '        If item.ID = x Then
        '            item.BringToFront()

        '            Exit For
        '        End If
        '    Next
        'Next



    End Sub

    Sub IndexarRenameOption(index As Integer)

        For Each item As Control_RenameOption In Me.Parent.Controls
            If item.ID > index Then
                item.ID += 1
                item.TXTPerson.TXT = "Saluton" + item.ID.ToString

            End If
        Next

    End Sub

    Sub RemoverIndice(index As Integer)

        For Each item As Control_RenameOption In Me.Parent.Controls
            If item.ID > index Then
                item.ID -= 1
                item.TXTPerson.TXT = "Saluton" + item.ID.ToString

            End If
        Next

    End Sub


    Private Sub BTNRemoveRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNRemoveRenomeDeOrigem.Click

        '  Dim pai As Control_LoadRenameOption = Me.Parent.Parent.Parent.Parent


        If Me.Parent.Controls.Count > 1 Then


            RemoverIndice(Me.ID)

            Me.Finalize()
            Me.Parent.Controls.Remove(Me)


            'OrdenarRenameOption()

            If _pai.Panel_LoadRenameOption.Controls.Count = 1 Then
                Dim item As Control_RenameOption
                item = _pai.Panel_LoadRenameOption.Controls.Item(0)

                'item.BTNRemoveRenomeDeOrigem.BackgroundImage = My.Resources.minus_inativo_50
                item.ActiveDelete = False

            End If



        End If


    End Sub


    Private Sub BTNAddRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNAddRenomeDeOrigem.Click
        Dim renameOption As New Control_RenameOption

        Me.Parent.Controls.Add(renameOption)


        ' Me.BTNRemoveRenomeDeOrigem.BackgroundImage = My.Resources.minus

        Me.ActiveDelete = True

        renameOption.Dock = DockStyle.Top

        IndexarRenameOption(ID)


        renameOption.ID = ID + 1  'Me.Parent.Controls.Count - 1  '

        renameOption.Width = Me.Parent.Width

        'renameOption.BTNRemoveRenomeDeOrigem.BackgroundImage = My.Resources.minus

        renameOption.ActiveDelete = True

        renameOption.TXTPerson.TXT = "Saluton" + renameOption.ID.ToString

        renameOption.Visible = True

        OrdenarRenameOption()
        'Dim ord As Byte
        'Dim b As New MsgBoxStyle

        '#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        '        ord = MsgBox("Mostrar ordem?", b.YesNo, "Ordem")
        '        If ord = 6 Then
        '            MostrarOrdem
        '        End If
        '#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância

    End Sub

    Private Sub Control_RenameOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTPerson.TXT = ID

        If Me.Parent.Parent.Parent.Parent IsNot Nothing Then
            If TypeOf (Me.Parent.Parent.Parent.Parent) Is Control_LoadRenameOption Then
                _pai = Me.Parent.Parent.Parent.Parent

            End If
        End If

    End Sub

End Class
