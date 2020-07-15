﻿Imports System.IO

Public Class Control_ControleDePasta
    Dim texto As String
    Dim number1 As Integer = 0

    Public Enum styleEnum
        _Default = 0
        OnlyImage = 1
        ImageAndText = 2
    End Enum

    Private _style As styleEnum
    Public Property Style As styleEnum
        Get
            Return _style

        End Get
        Set(value As styleEnum)
            _style = value

            Select Case value
                Case _style._Default
                    BTNLabel.Visible = True
                    BTNImage.Visible = False

                Case _style.OnlyImage
                    BTNLabel.Visible = False
                    BTNImage.Visible = True

                Case _style.ImageAndText
                    BTNLabel.Visible = True
                    BTNImage.Visible = True

            End Select

        End Set
    End Property

    Private _image As Image
    Public Property Image As Image
        Get
            Return _image

        End Get
        Set(value As Image)
            _image = value

        End Set
    End Property

    Private _master As Control_ControleDePasta
    Public Property Master As Control_ControleDePasta
        Get
            Return _master
        End Get
        Set(value As Control_ControleDePasta)
            _master = value

            If _master IsNot Nothing Then
                If _master.Slave IsNot Me Then
                    _master.Slave = Me
                End If
            End If

        End Set
    End Property

    Private _slave As Control_ControleDePasta
    Public Property Slave As Control_ControleDePasta
        Get
            Return _slave
        End Get
        Set(value As Control_ControleDePasta)
            _slave = value

            If _slave IsNot Nothing Then

                If _slave.Master IsNot Me Then
                    _slave.Master = Me

                End If
            End If

        End Set
    End Property

    Private _level As Integer
    Public Property Level As Integer
        Get
            Return _level

        End Get
        Set(value As Integer)
            _level = value
        End Set
    End Property

    Private _addressBar As Control_AddressBar
    Public Property AddressBar As Control_AddressBar
        Get
            Return _addressBar
        End Get
        Set(value As Control_AddressBar)
            _addressBar = value

        End Set
    End Property

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

    Dim _forceExpandButtonDisplay As Boolean
    Public Property ForceExpandButtonDisplay As Boolean
        Get
            Return _forceExpandButtonDisplay

        End Get
        Set(value As Boolean)
            _forceExpandButtonDisplay = value
            DisplayBTNMenu = value

        End Set
    End Property

    Dim _displayBTNMenu As Boolean
    Public Property DisplayBTNMenu As Boolean
        Get
            Return _displayBTNMenu
        End Get
        Set(value As Boolean)
            _displayBTNMenu = value
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


            If value IsNot Nothing Then

                Text = value.Text
                If value.Tag IsNot Nothing Then
                    If TypeOf value.Tag Is String Then
                        Dim caminho As String = value.Tag

                        _folderInfo = New DirectoryInfo(caminho)
                        _driveInfo = New DriveInfo(_folderInfo.Root.FullName)
                        DisplayBTNMenu = CarregarMenuPersonalizado()
                        'CarregarMenuPersonalizado()

                    End If

                    If value.TreeView IsNot Nothing Then
                        _selectedTreeView = value.TreeView
                    End If

                End If

            Else
                Text = ""
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
        BTNImage.BackColor = _backgroundColorMouseLeave

        BTNLabel.FlatAppearance.MouseOverBackColor = _mouseOverBackColor
        BTNMenu.FlatAppearance.MouseOverBackColor = _mouseOverBackColor
        BTNImage.FlatAppearance.MouseOverBackColor = _mouseOverBackColor


        PanelBorder_BTNMenu.BackColor = _borderColorMouseLeave
        PanelBorder_ControleDePasta.BackColor = _borderColorMouseLeave



    End Sub

    Private Sub Control_ControleDePasta_Load(sender As Object, e As EventArgs) Handles Me.Load
        'BTNLabel.Width = 10

        If ForceExpandButtonDisplay = True Then

        End If
        DisplayBTNMenu = CarregarMenuPersonalizado()

    End Sub

    Function NewSubMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim subMenu As ToolStripMenuItem

        subMenu = CType(sender, ToolStripMenuItem)

        Dim node As TreeNode = subMenu.Tag

        AddressBar.SelectedNode = node

        'If node.Parent Is Nothing Then
        '    MostrarBTNMenu = CarregarMenuPersonalizado()
        'End If

        SelectSubMenu(subMenu)

        BTNMenu.Image = My.Resources.setaQuebradaParaDireita


    End Function

    Sub SelectSubMenu(subMenu As ToolStripMenuItem)

        For Each item As ToolStripMenuItem In ContextMenuStrip1.Items
            If item Is subMenu Then
                item.Checked = True

            Else
                item.Checked = False
            End If
            'MsgBox(item.Tag.Text)
            'MsgBox(item.Name)
            'MsgBox(item.Tag.fullPath)
        Next

    End Sub

    Private Overloads Function CarregarMenuPersonalizado() As Boolean
        Dim mostrarBotaoDeNMenu As Boolean
        Dim recarregar As Boolean = False
        Dim child As TreeNode

        'AddressBar.SelectedNode = SelectedNode

        Try

            If _forceExpandButtonDisplay = False Then

                If _selectedNode Is Nothing Then

                    Exit Function

                Else
                    If _selectedNode.Nodes.Count > 0 Then
                        mostrarBotaoDeNMenu = True

                    Else
                        mostrarBotaoDeNMenu = False
                    End If
                End If


            Else
                mostrarBotaoDeNMenu = True

                Return mostrarBotaoDeNMenu
            End If

            'If _selectedNode Is Nothing Then

            '    Exit Function

            'End If


            ContextMenuStrip1.Items.Clear()
            For Each child In _selectedNode.Nodes
                If child.Name = "carregando" Then
                    SelectedTreeView.SelectedNode = child.Parent
                    mostrarBotaoDeNMenu = False
                    Exit Function
                End If

                'MsgBox(child.Name)
                ' TODO: Se Name = execao entao ?
                ' = carregando
                If child.Level = 0 Then
                    MsgBox(child.Name)
                End If
                Dim newSubMenuItem As New ToolStripMenuItem With {
                     .Text = child.Text,
                     .Tag = child, 'New DirectoryInfo(child.Tag),
                     .Image = My.Resources.pasta_1
                 }

                AddHandler newSubMenuItem.Click, New System.EventHandler(AddressOf NewSubMenuItem_Clicked)

                ContextMenuStrip1.Items.Add(newSubMenuItem)

            Next


            Return mostrarBotaoDeNMenu

        Catch ex As Exception
            ContextMenuStrip1.Items.Clear()
            MsgBox(ex.Message)

            Return False

        End Try

    End Function

    Private Sub BTNs_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNLabel.MouseMove, BTNMenu.MouseMove, BTNImage.MouseMove

        BTNLabel.BackColor = _backgroundColorMouseMove
        BTNMenu.BackColor = _backgroundColorMouseMove
        BTNImage.BackColor = _backgroundColorMouseMove

        PanelBorder_BTNMenu.BackColor = _borderColorMouseMove
        PanelBorder_ControleDePasta.BackColor = _borderColorMouseMove

    End Sub

    Private Sub BTNLabel_MouseLeave(sender As Object, e As EventArgs) Handles BTNLabel.MouseLeave, BTNMenu.MouseLeave, BTNImage.MouseLeave
        BTNLabel.BackColor = _backgroundColorMouseLeave
        BTNMenu.BackColor = _backgroundColorMouseLeave
        BTNImage.BackColor = _backgroundColorMouseLeave

        PanelBorder_BTNMenu.BackColor = _borderColorMouseLeave
        PanelBorder_ControleDePasta.BackColor = _borderColorMouseLeave
    End Sub

    Private Sub BTNLabel_Click(sender As Object, e As EventArgs) Handles BTNLabel.Click, BTNImage.Click

        If SelectedNode IsNot Nothing Then
            If SelectedNode.TreeView IsNot Nothing Then
                SelectedNode.TreeView.SelectedNode = SelectedNode
            End If
        End If
    End Sub

    Private Sub BTNMenu_Click(sender As Object, e As EventArgs) Handles BTNMenu.Click

        Me.ParentForm.UseWaitCursor = True

        DisplayBTNMenu = CarregarMenuPersonalizado()

        Dim btn As Button = CType(sender, Button)
        btn.ContextMenuStrip.Show(btn, -20, btn.Height)
        BTNMenu.Image = My.Resources.setaQuebradaParaBaixo

        'If node.Parent Is Nothing Then
        'End If

        Me.ParentForm.UseWaitCursor = False

    End Sub

    Private Sub ContextMenuStrip1_Closed(sender As Object, e As ToolStripDropDownClosedEventArgs) Handles ContextMenuStrip1.Closed
        BTNMenu.Image = My.Resources.setaQuebradaParaDireita
    End Sub
End Class
