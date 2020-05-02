'Imports System.Security.Cryptography.X509Certificates

Imports System.Reflection

Public Class Control_RenameOption


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

    Private Sub BTNRemoveRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNRemoveRenomeDeOrigem.Click

        If Me._id > 0 Then
            MsgBox("Excluir " + Me.Name + " ID: " + Me._id.ToString)

            Me.Finalize()
            Me.Parent.Controls.Remove(Me)

        Else
            MsgBox(Me.Name + " não pode ser excluído.")
        End If


    End Sub

    Private Sub BTNAddRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNAddRenomeDeOrigem.Click
        Dim renameOption As New Control_RenameOption

        Me.Parent.Controls.Add(renameOption)
        renameOption.Dock = DockStyle.Top

        IndexarRenameOption(ID)


        renameOption.ID = ID + 1  'Me.Parent.Controls.Count - 1  '

        renameOption.Width = Me.Parent.Width

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

    End Sub

End Class
