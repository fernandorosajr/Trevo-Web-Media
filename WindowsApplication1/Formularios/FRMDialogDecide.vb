Imports System.Windows.Forms

Public Class FRMDialogDecide
    Private _menuExpand As Boolean

    Public Property MenuExpand As Boolean
        Get
            Return _menuExpand

        End Get
        Set(value As Boolean)
            _menuExpand = value

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

    Private Sub FRMDialogDecide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        MenuExpand = False

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub BTNMenuExpand_Click(sender As Object, e As EventArgs) Handles BTNMenuExpand.Click
        Dim btn As Button
        btn = CType(sender, Button)

        MenuExpand = Not (MenuExpand)

        Select Case _menuExpand
            Case True
                btn.Text = btn.Tag
                Me.Width = 755

                Me.PanelMenuLateral.Width = 173

            Case Else
                btn.Text = ""
                Me.Width = 582
                Me.PanelMenuLateral.Width = 43
                Me.PanelMenuLateral.Dock = DockStyle.Left


        End Select

    End Sub
End Class
