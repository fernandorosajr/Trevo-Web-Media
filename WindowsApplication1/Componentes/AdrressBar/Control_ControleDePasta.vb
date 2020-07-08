Imports System.IO

Public Class Control_ControleDePasta
    Dim texto As String
    Dim number1 As Integer = 0

    Private _text As String
    Public Overrides Property Text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
            BTNLabel.Text = value
            BTNLabel.Width = 10

        End Set
    End Property

    Dim _mostrarBTNMenu As Boolean
    Public Property MostrarBTNMenu As Boolean
        Get
            Return _mostrarBTNMenu
        End Get
        Set(value As Boolean)
            _mostrarBTNMenu = value
            BTNMenu.Parent.Visible = value
        End Set
    End Property

    Private _folderInfo As DirectoryInfo
    Public Property FolderInfo As DirectoryInfo
        Get
            Return _folderInfo
        End Get
        Set(value As DirectoryInfo)
            _folderInfo = value

        End Set
    End Property

    Private _driveInfo As DriveInfo
    Public Property DriveInfo As DriveInfo
        Get
            Return _driveInfo
        End Get
        Set(value As DriveInfo)
            _driveInfo = value
        End Set
    End Property

    Private _selectedTreeView As TreeView
    Public Property SelectedTreeView As TreeView
        Get
            Return _selectedTreeView

        End Get
        Set(value As TreeView)
            _selectedTreeView = value

        End Set
    End Property

    Private _selectedNode As TreeNode
    Public Property SelectedNode As TreeNode
        Get
            Return _selectedNode
        End Get

        Set(value As TreeNode)
            _selectedNode = value

            Text = value.Text

            If value IsNot Nothing And value.Tag IsNot Nothing Then
                If TypeOf value.Tag Is String Then
                    Dim caminho As String = value.Tag

                    _folderInfo = New DirectoryInfo(caminho)
                    _driveInfo = New DriveInfo(_folderInfo.Root.FullName)

                End If
            End If
        End Set
    End Property


    ' Propriedades de cores
    ' -----------------------------------------------
    Private _mouseOverBackColor As Color
    Public Property MouseOverBackColor As Color
        Get
            Return _mouseOverBackColor
        End Get
        Set(value As Color)
            _mouseOverBackColor = value
        End Set
    End Property

    Private _borderColorMouseLeave As Color
    Public Property BordeColorMouseLeave As Color
        Get
            Return _borderColorMouseLeave
        End Get
        Set(value As Color)
            _borderColorMouseLeave = value
        End Set
    End Property

    Private _backgroundColorMouseLeave As Color
    Public Property BackgroundColorMouseLeave As Color
        Get
            Return _backgroundColorMouseLeave
        End Get
        Set(value As Color)
            _backgroundColorMouseLeave = value
        End Set
    End Property

    Private _borderColorMouseMove As Color
    Public Property BorderColorMouseMove As Color
        Get
            Return _borderColorMouseMove
        End Get
        Set(value As Color)
            _borderColorMouseMove = value
        End Set
    End Property

    Private _backgroundColorMouseMove As Color
    Public Property BackgroundColorMouseMove As Color
        Get
            Return _backgroundColorMouseMove
        End Get
        Set(value As Color)
            _backgroundColorMouseMove = value

        End Set
    End Property
    ' -----------------------------------------------


    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.BackColor = Color.Transparent

        _borderColorMouseLeave = Color.Transparent
        _backgroundColorMouseLeave = Color.Transparent
        _borderColorMouseMove = Color.SkyBlue
        _backgroundColorMouseMove = Color.LightCyan

        _mouseOverBackColor = Color.LightCyan

        BTNLabel.BackColor = _backgroundColorMouseLeave
        BTNMenu.BackColor = _backgroundColorMouseLeave

        BTNLabel.FlatAppearance.MouseOverBackColor = _mouseOverBackColor
        BTNMenu.FlatAppearance.MouseOverBackColor = _mouseOverBackColor

        PanelBorder_BTNMenu.BackColor = _borderColorMouseLeave
        PanelBorder_ControleDePasta.BackColor = _borderColorMouseLeave


    End Sub

    Private Sub Control_ControleDePasta_Load(sender As Object, e As EventArgs) Handles Me.Load
        'BTNLabel.Width = 10

        Try
            If Me.FolderInfo IsNot Nothing Then

                If Me.FolderInfo.GetDirectories.Length > 0 Then
                    MostrarBTNMenu = True
                    CarregarMenuPersonalizado()
                Else
                    MostrarBTNMenu = False
                End If

            End If

        Catch ex As Exception
            MostrarBTNMenu = True
        End Try

    End Sub

    'Private Overloads Sub CarregarMenuPersonalizado(DriveInfo As DriveInfo)
    '    ContextMenuStrip1.Items.Clear()

    '    For Each folder As DirectoryInfo In DriveInfo.GetDirectories
    '        Dim newMenuItem As New ToolStripMenuItem With {
    '            .Text = folder.Name,
    '            .Tag = folder,
    '            .Image = My.Resources.pasta_1
    '        }

    '        ContextMenuStrip1.Items.Add(newMenuItem)
    '    Next
    'End Sub

    Private Overloads Sub CarregarMenuPersonalizado()
        ContextMenuStrip1.Items.Clear()

        For Each folder As DirectoryInfo In FolderInfo.GetDirectories
            Dim newMenuItem As New ToolStripMenuItem With {
                .Text = folder.Name,
                .Tag = folder,
                .Image = My.Resources.pasta_1
            }

            ContextMenuStrip1.Items.Add(newMenuItem)
        Next
    End Sub

    Private Sub BTNs_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNLabel.MouseMove, BTNMenu.MouseMove

        BTNLabel.BackColor = _backgroundColorMouseMove
        BTNMenu.BackColor = _backgroundColorMouseMove

        PanelBorder_BTNMenu.BackColor = _borderColorMouseMove
        PanelBorder_ControleDePasta.BackColor = _borderColorMouseMove

    End Sub

    Private Sub BTNLabel_MouseLeave(sender As Object, e As EventArgs) Handles BTNLabel.MouseLeave, BTNMenu.MouseLeave
        BTNLabel.BackColor = _backgroundColorMouseLeave
        BTNMenu.BackColor = _backgroundColorMouseLeave

        PanelBorder_BTNMenu.BackColor = _borderColorMouseLeave
        PanelBorder_ControleDePasta.BackColor = _borderColorMouseLeave
    End Sub

    Private Sub BTNLabel_Click(sender As Object, e As EventArgs) Handles BTNLabel.Click

    End Sub

    Private Sub BTNMenu_Click(sender As Object, e As EventArgs) Handles BTNMenu.Click
        Dim btn As Button = CType(sender, Button)

        btn.ContextMenuStrip.Show(btn, -20, btn.Height)
    End Sub
End Class
