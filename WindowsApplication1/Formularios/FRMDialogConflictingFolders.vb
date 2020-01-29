Imports System.Windows.Forms

Public Class FRMDialogConflictingFolders

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BTNMesclar_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNMesclar.MouseMove

        Panel_LBLInfo.Visible = True
        LBLInfo.Text = "Mescla pastas no destino. Se houver arquivos de mesmo nome será perguntado o que fazer."
    End Sub


    Private Sub BTNSubstitui_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNSubstitui.MouseMove
        Panel_LBLInfo.Visible = True
        LBLInfo.Text = "Exclui pasta destino e seus conteúdos e a substitui pela pasta de origem."
    End Sub

    Private Sub BTNIgnorar_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNIgnorar.MouseMove
        Panel_LBLInfo.Visible = True
        LBLInfo.Text = "Nada será feito."

    End Sub

    Private Sub FRMDialogConflictingFolders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FRMDialogConflictingFolders_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Panel_LBLInfo.Visible = False
        'LBLInfo.Text = "Exclui pasta destino e seus conteúdos e a substitui pela pasta de origem."

    End Sub
End Class
