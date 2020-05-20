Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections.ObjectModel
Imports System.Drawing.Design

Imports System.Windows.Forms
'TODO: Remover controle em tenpos de execução : https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-add-to-or-remove-from-a-collection-of-controls-at-run-time

Public Class FRMDialogRenameCriterio
    ' TODO :https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-layer-objects-on-windows-forms
    ' https://docs.microsoft.com/pt-br/dotnet/framework/winforms/controls/how-to-set-the-tab-order-on-windows-forms

    Dim LoadRenameOptions As New Control_LoadRenameOptions

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    'Private Sub BTNConfirmarRenomeDeOrigem_Click(sender As Object, e As EventArgs)
    '    'txtFirstName.BringToFront()
    '    PanelElemento.BringToFront()

    'End Sub

    'Private Sub BTNCancelaRenomeDeOrigem_Click(sender As Object, e As EventArgs)
    '    PanelElemento.SendToBack()
    '    ' PanelElemento.GetNextControl()

    'End Sub

    Private Sub FRMDialogRenameCriterio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelRecebe.Controls.Add(LoadRenameOptions)
        LoadRenameOptions.Top = 31
        LoadRenameOptions.Left = 103
        LoadRenameOptions.Width = LBLTitle01.Width
        LoadRenameOptions.Height = 231

        LoadRenameOptions.Dock = DockStyle.Fill


        'comboBoxPerson01.Width = 150


        'Me.Controls.Add(comboBoxPerson01)
        'comboBoxPerson01.BringToFront()
        'comboBoxPerson01.ComboBoxPersonSlave = comboBoxPerson02

        'comboBoxPerson01.ComboBoxPersonSlave.OptionsList.Add("Eu sou o SubCombo")
        'comboBoxPerson01.ComboBoxPersonSlave.OptionsList.Add("Sou escravo do Combo 1")
        'comboBoxPerson01.ComboBoxPersonSlave.OptionsList.Add("; OK")

        'comboBoxPerson02.Left = comboBoxPerson01.Left + comboBoxPerson01.Width + 8

        'Me.Controls.Add(comboBoxPerson02)

        'comboBoxPerson01.Show()
        'comboBoxPerson02.Show()

        '  CBP_1.ComboBoxPersonSlave = CBP_2

    End Sub

    Private Sub LNKLNomeDoExemplo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNKLNomeDoExemplo.LinkClicked
        LNKLNomeDoExemplo_Click()
    End Sub

    Private Sub LNKLNomeDoExemplo_Click(sender As Object, e As EventArgs) Handles LNKLNomeDoExemplo.Click
        LNKLNomeDoExemplo_Click()

    End Sub

    Sub LNKLNomeDoExemplo_Click()

        TXTCNovoNome.Filho = LNKLNomeDoExemplo

        TXTCNovoNome.ValueStr = LNKLNomeDoExemplo.Text

        TXTCNovoNome.Focus()

        TXTCNovoNome.Visible = True
    End Sub

End Class
