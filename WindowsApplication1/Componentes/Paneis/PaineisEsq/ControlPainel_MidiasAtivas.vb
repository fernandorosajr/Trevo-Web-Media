Public Class ControlPainel_MidiasAtivas
    Private Sub PanelMidiaAtiva_Paint(sender As Object, e As PaintEventArgs) Handles PanelMidiaAtiva.Paint

    End Sub

    Private Sub ControlPainel_MidiasAtivas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nomeDr As String

        Try
            Me.TVMedias.Nodes.Clear()
            ' Encontra os driveres  de dispositivos existentes.
            Dim node As New TreeNode

            For Each driveMaster In My.Computer.FileSystem.Drives

                nomeDr = driveMaster.Name

                If driveMaster.IsReady Then

                    nomeDr = nomeDr.Substring(0, CInt(nomeDr.Count) - 1)
                    node = Me.TVMedias.Nodes.Add(CStr(driveMaster.Name), driveMaster.VolumeLabel & " (" & nomeDr & ")", "dvd", "dvd")
                    node.Tag = nomeDr

                Else

                    node = Me.TVMedias.Nodes.Add(CStr(driveMaster.Name), CStr(driveMaster.Name), "UnidadeVazia", "UnidadeVazia")
                    node.Tag = nomeDr

                End If
                ' AdcionarItemNoView(DriveMaster, Int(My.Computer.FileSystem.Drives.Count))

                '         PanelRecebe.Controls.Add(ControlPersonalListView)

            Next

            '' Cria os suobjetos semelhantes a pastas do picasa
            ' PanelRecebe.Controls.Add(ControlPersonalListView)
            ' ControlPersonalListView.Visible = True
            '  ControlPersonalListView.Dock = DockStyle.Fill

        Catch ex As Exception
            MsgBox(Err.Description & Chr(13) & nomeDr)

        End Try


    End Sub


    Private Sub TVMedias_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVMedias.AfterSelect

        Dim node As TreeNode
        Dim subNode As TreeNode

        Try
            Dim DriveI As New IO.DriveInfo(TVMedias.SelectedNode.Tag)

            Dim DirDir As New IO.DirectoryInfo(TVMedias.SelectedNode.Tag)

            If Not (DriveI.IsReady) Then
                TVFilesAndFoldersOfTheOpenMedia.Nodes.Clear()
                node = TVFilesAndFoldersOfTheOpenMedia.Nodes.Add(TVMedias.SelectedNode.Tag, Me.TVMedias.SelectedNode.Text)
                node.Nodes.Add("Mensagem", "<O dispositivo não está pronto.>", "info", "info")

                node.ExpandAll()
                Exit Sub

            End If

            Dim DirDir01 As IO.DirectoryInfo() = DirDir.Root.GetDirectories
            Dim DrD As IO.DirectoryInfo

            Dim Nome As String

            TVFilesAndFoldersOfTheOpenMedia.Nodes.Clear()

            node = TVFilesAndFoldersOfTheOpenMedia.Nodes.Add(TVMedias.SelectedNode.Tag, Me.TVMedias.SelectedNode.Text, "dvd", "dvd")

            For Each DrD In DirDir01
                Nome = DrD.Name
                subNode = node.Nodes.Add(TVMedias.SelectedNode.Tag & "\" & Nome, Nome, "pastaFechada", "pastaAberta")
                subNode.Tag = DrD.FullName
                subNode.Nodes.Add("carregando", "Clique na pasta para carregar.", "info", "info").Tag = "carregando"
            Next
            node.Expand()
            ' node.ExpandAll()

        Catch ex As Exception
            node.Nodes.Clear()
            node.Nodes.Add(node.Name & "\info", ex.Message, "info", "info")
            node.Expand()

        End Try


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
