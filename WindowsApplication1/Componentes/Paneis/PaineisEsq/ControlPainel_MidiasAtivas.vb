Public Class ControlPainel_MidiasAtivas
    Private Sub PanelMidiaAtiva_Paint(sender As Object, e As PaintEventArgs) Handles PanelMidiaAtiva.Paint

    End Sub

    Private Sub ControlPainel_MidiasAtivas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nomeDoDrive As String
        Dim tipoDeDrive As String
        Dim iconeDoDrive As String
        Dim rotuloDoDrive As String

        Try
            Me.TVMedias.Nodes.Clear()
            ' Encontra os driveres  de dispositivos existentes.
            Dim node As New TreeNode

            For Each drive In My.Computer.FileSystem.Drives

                nomeDoDrive = drive.Name
                tipoDeDrive = drive.DriveType

                Select Case drive.DriveType
                    Case 0
                        tipoDeDrive = "Unknown"

                    Case 1
                        tipoDeDrive = "NoRootDirectory"

                    Case 2
                        tipoDeDrive = "Removable"
                        iconeDoDrive = "Pen.ico"

                    Case 3
                        tipoDeDrive = "Fixed"
                        iconeDoDrive = "hd"

                    Case 4
                        tipoDeDrive = "Network"

                    Case 5
                        tipoDeDrive = "CD Rom"
                        iconeDoDrive = "DVD"

                    Case 6
                        tipoDeDrive = "Ram"

                End Select
                rotuloDoDrive = ""

                If drive.IsReady Then

                    nomeDoDrive = nomeDoDrive.Substring(0, CInt(nomeDoDrive.Count) - 1)
                    node = Me.TVMedias.Nodes.Add(CStr(drive.Name), drive.VolumeLabel & " (" & nomeDoDrive & ")", iconeDoDrive, iconeDoDrive)
                    node.Tag = nomeDoDrive

                Else

                    node = Me.TVMedias.Nodes.Add(CStr(drive.Name), CStr(drive.Name), "UnidadeVazia", "UnidadeVazia")
                    node.Tag = nomeDoDrive

                End If
                ' tvRoot.ContextMenuStrip = Me.CMItens
                ' AdcionarItemNoView(DriveMaster, Int(My.Computer.FileSystem.Drives.Count))

                '         PanelRecebe.Controls.Add(ControlPersonalListView)

            Next

            '' Cria os suobjetos semelhantes a pastas do picasa
            ' PanelRecebe.Controls.Add(ControlPersonalListView)
            ' ControlPersonalListView.Visible = True
            '  ControlPersonalListView.Dock = DockStyle.Fill

        Catch ex As Exception
            MsgBox(Err.Description & Chr(13) & nomeDoDrive)

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
                node = TVFilesAndFoldersOfTheOpenMedia.Nodes.Add(TVMedias.SelectedNode.Tag, Me.TVMedias.SelectedNode.Text, Me.TVMedias.SelectedNode.ImageKey, Me.TVMedias.SelectedNode.SelectedImageKey)
                node.Nodes.Add("Mensagem", "<O dispositivo não está pronto.>", "info", "info")

                node.ExpandAll()
                Exit Sub

            End If

            Dim DirDir01 As IO.DirectoryInfo() = DirDir.Root.GetDirectories
            Dim DrD As IO.DirectoryInfo

            Dim Nome As String

            TVFilesAndFoldersOfTheOpenMedia.Nodes.Clear()

            node = TVFilesAndFoldersOfTheOpenMedia.Nodes.Add(TVMedias.SelectedNode.Tag, Me.TVMedias.SelectedNode.Text, TVMedias.SelectedNode.ImageKey, TVMedias.SelectedNode.SelectedImageKey)
            '"dvd", "dvd")

            For Each DrD In DirDir01
                Nome = DrD.Name
                subNode = node.Nodes.Add(TVMedias.SelectedNode.Tag & "\" & Nome, Nome, "pastaFechada", "pastaAberta")
                subNode.Tag = DrD.FullName
                subNode.ContextMenuStrip = Me.CMItens
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
