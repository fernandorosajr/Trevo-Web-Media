'Imports System.Security.Cryptography.X509Certificates

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



    Private Sub BTNAddRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNAddRenomeDeOrigem.Click
        Dim renameOption As New Control_RenameOption

        Me.Parent.Controls.Add(renameOption)
        renameOption.Dock = DockStyle.Top
        renameOption.ID = ID + 1
        renameOption.Visible = True

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

End Class
