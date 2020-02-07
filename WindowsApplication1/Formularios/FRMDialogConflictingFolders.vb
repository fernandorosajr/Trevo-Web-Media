﻿Imports System.Windows.Forms
Imports System.IO

Public Class FRMDialogConflictingFolders
    Dim novoCaminhoDeOrigemModificado As String
    Dim novoNomeDaPastaOrigemModificado As String

    Dim novoCaminhoDeDestinoModificado As String
    Dim novoNomeDaPastaDestinoModificado As String

    Dim rendoOldPathOrigem As String
    Dim rendoNewPathOrigem As String

    Dim rendoOldPathDestino As String
    Dim rendoNewPathDestino As String

    Private EstadoDaTela As Integer

    ' Propriedades do configuração
    Private _borderColorError As Color
    Public Property BorderColorError As Color
        Get
            Return _borderColorError
        End Get
        Set(value As Color)
            _borderColorError = value

        End Set
    End Property

    Private _backColorCursorMouseLeave As Color
    Public Property BackColorCursorMouseLeave As Color
        Get
            Return _backColorCursorMouseLeave
        End Get
        Set(value As Color)
            _backColorCursorMouseLeave = value

        End Set
    End Property

    Private _borderColorGotFocus As Color

    Public Property BorderColorGotFocus As Color
        Get
            Return _borderColorGotFocus
        End Get
        Set(value As Color)
            _borderColorGotFocus = value

        End Set
    End Property

    Private _borderColorLostFocus As Color
    Public Property BordeColorLostFocus As Color
        Get
            Return _borderColorLostFocus
        End Get
        Set(value As Color)
            _borderColorLostFocus = value
        End Set
    End Property

    ' Propriedades 
    Dim _title As String
    Public Property Title As String
        Get
            Return _title
        End Get

        Set(value As String)
            _title = value
            Me.Text = _title
        End Set
    End Property

    Dim _pastaOrigem As String
    Public Property PastaOrigem As String
        Get
            Return _pastaOrigem

        End Get

        Set(value As String)
            _pastaOrigem = value
            LBLValueOrigem.Text = _pastaOrigem

            If _oldPathOrigem <> _newPathOrigem Then
                TelaParaOrigemDiferente()
            Else
                TelaParaOrigemIgual()
            End If
        End Set
    End Property

    Dim _pastaDestino As String
    Public Property PastaDestino As String
        Get
            Return _pastaDestino
        End Get

        Set(value As String)
            _pastaDestino = value

            LBLValueDestino.Text = _pastaDestino
        End Set
    End Property

    Dim _oldPathDestino As String
    Public Property OldPathDestino As String
        Get
            Return _oldPathDestino
        End Get

        Set(value As String)
            _oldPathDestino = value

            If _oldPathDestino <> _newPathDestino Then
                TelaParaDestinoDiferente()
            Else
                TelaParaDestinoIgual()
            End If
        End Set
    End Property

    Dim _newPathDestino As String
    Public Property NewPathDestino As String
        Get
            Return _newPathDestino
        End Get

        Set(value As String)
            _newPathDestino = value

            If _oldPathDestino <> _newPathDestino Then
                TelaParaDestinoDiferente()
            Else
                TelaParaDestinoIgual()
            End If
        End Set
    End Property

    Dim _oldPathOrigem As String
    Public Property OldPathOrigem As String
        Get
            Return _oldPathOrigem
        End Get

        Set(value As String)
            _oldPathOrigem = value

            If _oldPathOrigem <> _newPathOrigem Then
                TelaParaOrigemDiferente()

            Else
                TelaParaOrigemIgual()
            End If
        End Set
    End Property

    Dim _newPathOrigem As String
    Public Property NewPathOrigem As String
        Get
            Return _newPathOrigem
        End Get
        Set(value As String)
            _newPathOrigem = value

            If _oldPathOrigem <> _newPathOrigem Then
                TelaParaOrigemDiferente()
            Else
                TelaParaOrigemIgual()
            End If
        End Set
    End Property

    Sub TelaParaOrigemDiferente()
        PanelEnvolve_TXTNomeDaOrigem.Visible = False
        LNKLRenomeOrigem.Text = _newPathOrigem
        LBLRenameOrigem.Visible = True
        LNKLRenomeOrigem.Visible = True

    End Sub

    Sub TelaParaOrigemIgual()
        PanelEnvolve_TXTNomeDaOrigem.Visible = False
        LNKLRenomeOrigem.Text = "Clique aqui para renomear pasta de origem"
        LBLRenameOrigem.Visible = False
        LNKLRenomeOrigem.Visible = True

    End Sub

    Sub TelaParaDestinoDiferente()
        PanelEnvolve_TXTNomeDoDestino.Visible = False
        LNKLRenomeDestino.Text = _newPathDestino
        LBLRenameDestino.Visible = True
        LNKLRenomeDestino.Visible = True
    End Sub

    Sub TelaParaDestinoIgual()
        PanelEnvolve_TXTNomeDoDestino.Visible = False
        LNKLRenomeDestino.Text = "Clique aqui para renomear pasta de destino"
        LBLRenameDestino.Visible = False
        LNKLRenomeDestino.Visible = True
    End Sub

    Sub TelaDeEdicaoDeOrigem()
        PanelEnvolve_TXTNomeDaOrigem.Left = LBLValueOrigem.Left - 15
        PanelEnvolve_TXTNomeDaOrigem.Width = LBLValueOrigem.Width

        PanelEnvolve_TXTNomeDaOrigem.Visible = Not (PanelBorder_TXTNomeDaOrigem.Visible)
        LNKLRenomeOrigem.Visible = False
        LBLRenameOrigem.Visible = False
    End Sub

    Sub TelaDeEdicaoDeDestino()
        PanelEnvolve_TXTNomeDoDestino.Left = LBLValueDestino.Left - 15
        PanelEnvolve_TXTNomeDoDestino.Width = LBLValueDestino.Width
        LNKLRenomeDestino.Visible = False
        PanelEnvolve_TXTNomeDoDestino.Visible = Not (PanelEnvolve_TXTNomeDoDestino.Visible)
        LBLRenameDestino.Visible = False
    End Sub

    Sub TelaLimpaDeVariaveis()
        LBLRenameOrigem.Visible = False
        LBLRenameDestino.Visible = False
        PanelEnvolve_TXTNomeDaOrigem.Visible = False
        PanelEnvolve_TXTNomeDoDestino.Visible = False
        LNKLRenomeOrigem.Text = "Renomear pasta de origem."
        LNKLRenomeDestino.Text = "Renomear pasta de destino."
        LNKLRenomeOrigem.Visible = True
        LNKLRenomeDestino.Visible = True
    End Sub


    'Dim _defaultResponse As String
    'Public Property DefaultResponse
    '    Get
    '        Return _defaultResponse
    '    End Get
    '    Set(value)
    '        _defaultResponse = value
    '        TxtResponse.Text = value
    '    End Set
    'End Property

    'Dim _prompt As String
    'Public Property Prompt As String
    '    Get
    '        Return _prompt
    '    End Get
    '    Set(value As String)
    '        _prompt = value
    '        LBLPrompt.Text = value
    '    End Set
    'End Property



    Public Sub New()
        If _pastaOrigem <> Nothing Then
            Dim pastaOrigemDirectoryInfo As New DirectoryInfo(_pastaOrigem)

        End If
        If PastaDestino <> Nothing Then
            Dim pastaDestinoDirectoryInfo As New DirectoryInfo(_pastaDestino)
            LBLNomeDaPasta.Text = pastaDestinoDirectoryInfo.Name

        End If
        ' This call is required by the designer.
        InitializeComponent()
        _borderColorGotFocus = SystemColors.HotTrack
        _borderColorLostFocus = BTNMesclar.BackColor
        _backColorCursorMouseLeave = Color.FromArgb(45, 45, 48)
        _borderColorError = Color.Red

        'PopulateTreeView()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FRMDialogConflictingFolders_Load(sender As Object, e As EventArgs) Handles Me.Load
        rendoOldPathOrigem = _oldPathOrigem
        rendoNewPathOrigem = _newPathOrigem

        rendoOldPathDestino = _oldPathDestino
        rendoNewPathDestino = _newPathDestino

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Buttons_MouseMove(sender As Object, e As MouseEventArgs) Handles BTNMesclar.MouseMove, BTNSubstituir.MouseMove, BTNIgnorar.MouseMove, OK_Button.MouseMove, Cancel_Button.MouseMove, BTNRendo.MouseMove
        Dim btn As Button
        btn = CType(sender, Button)

        Select Case btn.Name
            Case "BTNMesclar", "BTNSubstituir", "BTNIgnorar"
                ExibirEAtualizarHelp(btn, New Point(12, 316))

            Case "OK_Button", "Cancel_Button", "BTNRendo"
                ExibirEAtualizarHelp(btn, New Point(12, 170))

            Case Else
                Panel_LBLInfo.Visible = False

        End Select
    End Sub

    Private Sub LNKLRenomeOrigem_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNKLRenomeOrigem.LinkClicked
        Dim _newPathOrigem_DirectoryInfo As New DirectoryInfo(_newPathOrigem)

        TXTNomeDaOrigem.Text = _newPathOrigem_DirectoryInfo.Name

        TelaDeEdicaoDeOrigem()

        TXTNomeDaOrigem.Focus()
    End Sub

    Private Sub BTNConfirmarRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNConfirmarRenomeDeOrigem.Click
        Dim _newPathOrigemDirectoryInfo As New DirectoryInfo(_newPathOrigem)
        If Trim(TXTNomeDaOrigem.Text) = "" Or TXTNomeDaOrigem.Text.LastIndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) > -1 Then

            MsgBox("Nome da pasta inválido")
            TXTNomeDaOrigem.Text = _newPathOrigemDirectoryInfo.Name
            TXTNomeDaOrigem.Focus()
            Exit Sub
        End If

        If _newPathOrigem <> novoCaminhoDeOrigemModificado Then
            BTNRendo.Visible = True
        End If

        _newPathOrigem = novoCaminhoDeOrigemModificado

        If _oldPathOrigem = _newPathOrigem Then
            TelaParaOrigemIgual()
            BTNMesclar.Focus()

        Else
            TelaParaOrigemDiferente()
            OK_Button.Focus()
        End If

    End Sub

    Private Sub BTNCancelaRenomeDeOrigem_Click(sender As Object, e As EventArgs) Handles BTNCancelaRenomeDeOrigem.Click

        If _oldPathOrigem = _newPathOrigem Then
            TelaParaOrigemIgual()
            BTNMesclar.Focus()

        Else
            TelaParaOrigemDiferente()
            OK_Button.Focus()
        End If

    End Sub

    Private Sub BTNConfirmarRenomeDeDestino_Click(sender As Object, e As EventArgs) Handles BTNConfirmarRenomeDeDestino.Click

        Dim _newPathOrigemDirectoryInfo As New DirectoryInfo(_newPathDestino)
        If Trim(TXTNomeDoDestino.Text) = "" Or TXTNomeDoDestino.Text.LastIndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) > -1 Then

            MsgBox("Nome da pasta inválido")
            TXTNomeDoDestino.Text = _newPathOrigemDirectoryInfo.Name
            TXTNomeDoDestino.Focus()
            Exit Sub
        End If

        If _newPathDestino <> novoCaminhoDeDestinoModificado Then
            BTNRendo.Visible = True
        End If

        _newPathDestino = novoCaminhoDeDestinoModificado

        If _oldPathDestino = _newPathDestino Then
            TelaParaDestinoIgual()
            BTNMesclar.Focus()
        Else
            TelaParaDestinoDiferente()
            OK_Button.Focus()
        End If

    End Sub

    Private Sub BTNCancelaRenomeDeDestino_Click(sender As Object, e As EventArgs) Handles BTNCancelaRenomeDeDestino.Click

        If _oldPathDestino = _newPathDestino Then
            TelaParaDestinoIgual()
            BTNMesclar.Focus()
        Else
            TelaParaDestinoDiferente()
            OK_Button.Focus()
        End If

    End Sub

    Private Sub LNKLRenomeDestino_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LNKLRenomeDestino.LinkClicked
        Dim _newPathDestino_DirectoryInfo As New DirectoryInfo(_newPathDestino)

        TXTNomeDoDestino.Text = _newPathDestino_DirectoryInfo.Name

        TelaDeEdicaoDeDestino()

        TXTNomeDaOrigem.Focus()
    End Sub

    Private Sub BTNRendo_Click(sender As Object, e As EventArgs) Handles BTNRendo.Click

        OldPathOrigem = rendoOldPathOrigem
        NewPathOrigem = rendoNewPathOrigem

        OldPathDestino = rendoOldPathDestino
        NewPathDestino = rendoNewPathDestino

        BTNRendo.Visible = False

    End Sub

    Private Sub Buttons_GotFocus(sender As Object, e As EventArgs) _
        Handles OK_Button.GotFocus, Cancel_Button.GotFocus,
        BTNMesclar.GotFocus, BTNSubstituir.GotFocus,
        BTNSubstituir.GotFocus, BTNRendo.GotFocus,
        BTNCancelaRenomeDeDestino.GotFocus, BTNCancelaRenomeDeOrigem.GotFocus,
        BTNConfirmarRenomeDeDestino.GotFocus, BTNCancelaRenomeDeOrigem.GotFocus, BTNIgnorar.GotFocus

        Dim btn As Button
        btn = CType(sender, Button)

        btn.FlatAppearance.BorderColor = _borderColorGotFocus

        Select Case btn.Name
            Case "BTNMesclar", "BTNSubstituir", "BTNIgnorar"
                ExibirEAtualizarHelp(btn, New Point(12, 316))

            Case "OK_Button", "Cancel_Button", "BTNRendo"
                ExibirEAtualizarHelp(btn, New Point(12, 170))

            Case Else
                Panel_LBLInfo.Visible = False

        End Select
    End Sub

    Private Sub OK_Button_MouseLeave(sender As Object, e As EventArgs) Handles _
        OK_Button.MouseLeave, Cancel_Button.MouseLeave,
        BTNMesclar.MouseLeave, BTNSubstituir.MouseLeave,
        BTNSubstituir.MouseLeave, BTNRendo.MouseLeave, BTNIgnorar.MouseLeave

        Panel_LBLInfo.Visible = False
    End Sub


    Private Sub Buttons_LostFocus(sender As Object, e As EventArgs) _
        Handles OK_Button.LostFocus, Cancel_Button.LostFocus,
        BTNMesclar.LostFocus, BTNSubstituir.LostFocus,
        BTNSubstituir.LostFocus, BTNRendo.LostFocus,
        BTNCancelaRenomeDeDestino.LostFocus, BTNCancelaRenomeDeOrigem.LostFocus,
        BTNConfirmarRenomeDeDestino.LostFocus, BTNCancelaRenomeDeOrigem.LostFocus, BTNIgnorar.LostFocus

        Dim btn As Button
        btn = CType(sender, Button)

        btn.FlatAppearance.BorderColor = _borderColorLostFocus
        Panel_LBLInfo.Visible = False
    End Sub

    Sub ExibirEAtualizarHelp(btn As Object, location As Point)
        Panel_LBLInfo.Visible = True
        LBLInfo.Text = btn.Tag
        Panel_LBLInfo.Location = location
    End Sub

    Private Sub TextBoxes_GotFocus(sender As Object, e As EventArgs) Handles TXTNomeDaOrigem.GotFocus, TXTNomeDoDestino.GotFocus
        Dim txt As TextBox
        txt = CType(sender, TextBox)
        Dim backColor As Color = _backColorCursorMouseLeave
        Dim borderColor As Color = _borderColorGotFocus
        Dim borderColorError As Color = _borderColorError

        If Trim(txt.Text) = "" Or txt.Text.LastIndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) > -1 Then
            txt.Parent.BackColor = borderColorError
        Else
            txt.Parent.BackColor = backColor
        End If

        txt.Parent.Parent.BackColor = borderColor
        txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
        txt.Cursor = Cursors.IBeam
        txt.BackColor = backColor

        'Color.FromArgb(120, 45, 45, 48) 'Color.FromArgb(120, 255, 255, 255) 
    End Sub

    Private Sub TextBoxes_LostFocus(sender As Object, e As EventArgs) Handles TXTNomeDoDestino.LostFocus, TXTNomeDaOrigem.LostFocus
        Dim txt As TextBox
        txt = CType(sender, TextBox)
        Dim cor As Color = Color.FromArgb(63, 63, 66)

        txt.Parent.Parent.BackColor = _borderColorLostFocus
        txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
        txt.Cursor = Cursors.Arrow
        txt.BackColor = cor
        txt.Parent.BackColor = cor
    End Sub

    Private Sub TextBoxes_MouseMove(sender As Object, e As MouseEventArgs) Handles TXTNomeDoDestino.MouseMove, TXTNomeDaOrigem.MouseMove
        Dim txt As TextBox
        txt = CType(sender, TextBox)
        Dim cor As Color = _borderColorGotFocus
        Dim BorderColorError As Color = _borderColorError
        '  txt.Parent.Parent.BackColor = cor

        If Trim(txt.Text) = "" Or txt.Text.LastIndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) > -1 Then
            txt.Parent.Parent.BackColor = BorderColorError
        Else
            txt.Parent.Parent.BackColor = cor
        End If

        If txt.Focused = True Then
            txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
        Else
            txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
        End If
    End Sub

    Private Sub TextBoxes_MouseLeave(sender As Object, e As EventArgs) Handles TXTNomeDoDestino.MouseLeave, TXTNomeDaOrigem.MouseLeave
        Dim txt As TextBox
        txt = CType(sender, TextBox)
        Dim corLostFocus As Color = _borderColorLostFocus
        Dim corGotFocus As Color = _borderColorGotFocus

        If txt.Focused = True Then
            txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
            txt.Parent.Parent.BackColor = corGotFocus

            If Trim(txt.Text) = "" Or txt.Text.LastIndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) > -1 Then
                txt.Parent.Parent.BackColor = BorderColorError
            Else
                txt.Parent.Parent.BackColor = corGotFocus
            End If

        Else
            txt.Parent.Parent.Padding = New Padding(0, 0, 0, 1)
            txt.Parent.Parent.BackColor = corLostFocus
        End If
    End Sub

    Private Sub TXTNomeDaOrigem_TextChanged(sender As Object, e As EventArgs) Handles TXTNomeDaOrigem.TextChanged
        Dim txt As TextBox
        txt = CType(sender, TextBox)

        If _newPathOrigem <> Nothing Then
            If txt.Text.LastIndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) = -1 Or Trim(txt.Text) = "" Or txt.Text.Length = 0 Then

                Dim _newPathOrigemDirectoryInfo As New DirectoryInfo(_newPathOrigem)
                novoNomeDaPastaOrigemModificado = Trim(txt.Text)
                novoCaminhoDeOrigemModificado = _newPathOrigemDirectoryInfo.Parent.FullName & "\" & novoNomeDaPastaOrigemModificado

                If txt.Focused = True Then txt.Parent.Parent.BackColor = _borderColorGotFocus
            Else
                If txt.Focused = True Then txt.Parent.Parent.BackColor = _borderColorError
            End If
        End If

    End Sub

    Private Sub TXTNomeDoDestino_TextChanged(sender As Object, e As EventArgs) Handles TXTNomeDoDestino.TextChanged
        Dim txt As TextBox
        txt = CType(sender, TextBox)

        If _newPathDestino <> Nothing Then
            If txt.Text.LastIndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) = -1 Or Trim(txt.Text) = "" Or txt.Text.Length = 0 Then

                Dim _newPathOrigemDirectoryInfo As New DirectoryInfo(_newPathDestino)
                novoNomeDaPastaDestinoModificado = Trim(txt.Text)
                novoCaminhoDeDestinoModificado = _newPathOrigemDirectoryInfo.Parent.FullName & "\" & novoNomeDaPastaDestinoModificado

                If txt.Focused = True Then txt.Parent.Parent.BackColor = _borderColorGotFocus
            Else
                If txt.Focused = True Then txt.Parent.Parent.BackColor = _borderColorError
            End If
        End If
    End Sub
End Class
