Public Class ControlPainel_MidiasAtivas
    Private Sub PanelMidiaAtiva_Paint(sender As Object, e As PaintEventArgs) Handles PanelMidiaAtiva.Paint

    End Sub

    Private Sub ControlPainel_MidiasAtivas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NomeDr As String

        Try

            ' Encontra os driveres  de dispositivos existentes.
            Dim node As New TreeNode

            For Each DriveMaster In My.Computer.FileSystem.Drives

                NomeDr = DriveMaster.Name


                If DriveMaster.IsReady Then
                    NomeDr = NomeDr.Substring(0, CInt(NomeDr.Count) - 1)
                    node = Me.TVMedias.Nodes.Add(CStr(DriveMaster.Name), DriveMaster.VolumeLabel & " (" & NomeDr & ")")
                    node.Tag = NomeDr

                Else
                    node = Me.TVMedias.Nodes.Add(CStr(DriveMaster.Name), CStr(DriveMaster.Name))
                    node.Tag = NomeDr
                End If
                ' AdcionarItemNoView(DriveMaster, Int(My.Computer.FileSystem.Drives.Count))

                '         PanelRecebe.Controls.Add(ControlPersonalListView)

            Next


            '' Cria os suobjetos semelhantes a pastas do picasa
            ' PanelRecebe.Controls.Add(ControlPersonalListView)
            ' ControlPersonalListView.Visible = True
            '  ControlPersonalListView.Dock = DockStyle.Fill




        Catch ex As Exception
            MsgBox(Err.Description & Chr(13) & NomeDr)

        End Try


    End Sub

    Private Sub TVMedias_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVMedias.AfterSelect

    End Sub

    Public Sub TVMedias_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TVMedias.NodeMouseClick


    End Sub

    Private Sub ControlPainel_MidiasAtivas_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub ControlPainel_MidiasAtivas_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick


    End Sub

    Private Sub TVMedias_GotFocus(sender As Object, e As EventArgs) Handles TVMedias.GotFocus
        ' MsgBox("QQQ") 'Me.TVMedias.SelectedNode.Text)
    End Sub


    'Private Sub TVMedias_AfterSelect(sender As Object, e As TreeViewEventArgs)

    '    Dim DriveI As New IO.DriveInfo(TVMedias.SelectedNode.Tag)

    '    Dim DirDir As New IO.DirectoryInfo(TVMedias.SelectedNode.Tag)
    '    Dim Nodo As TreeNode

    '    If Not (DriveI.IsReady) Then
    '        TVFiles.Nodes.Clear()
    '        Nodo = TVFiles.Nodes.Add(TVMedias.SelectedNode.Tag, Me.TVMedias.SelectedNode.Text)
    '        Nodo.Nodes.Add("<O dispositivo não está pronto.>")

    '        Nodo.ExpandAll()
    '        Exit Sub

    '    End If

    '    Dim DirDir01 As IO.DirectoryInfo() = DirDir.Root.GetDirectories
    '    Dim DrD As IO.DirectoryInfo

    '    Dim Nome As String

    '    TVFiles.Nodes.Clear()

    '    Nodo = TVFiles.Nodes.Add(TVMedias.SelectedNode.Tag, Me.TVMedias.SelectedNode.Text)

    '    For Each DrD In DirDir01
    '        Nome = DrD.Name
    '        Nodo.Nodes.Add(TVMedias.SelectedNode.Tag & "\" & Nome, Nome)

    '    Next
    '    Nodo.ExpandAll()
    'End Sub

End Class
