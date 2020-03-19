Imports System.Windows.Forms

Public Class FRMDialogRenameCriterio
    ' TODO :https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-layer-objects-on-windows-forms
    ' https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-set-the-tab-order-on-windows-forms

    Dim comboBoxPerson As New Control_ComboBoxPerson

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BTNConfirmarRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNConfirmarRenomeDeOrigem.Click
        'txtFirstName.BringToFront()
        PanelElemento.BringToFront()

    End Sub

    Private Sub BTNCancelaRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNCancelaRenomeDeOrigem.Click
        PanelElemento.SendToBack()
        ' PanelElemento.GetNextControl()

    End Sub

    Private Sub FRMDialogRenameCriterio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        comboBoxPerson.Width = 150

        Me.Controls.Add(comboBoxPerson)
        comboBoxPerson.Show()

    End Sub
End Class
