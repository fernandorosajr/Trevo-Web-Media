Imports System.Windows.Forms


Public Class FRMDialogVisualizarRenome
    Public SelectedFoldersAndFiles As New List(Of Object)
    Public Renamed_SelectedFoldersAndFiles As New List(Of Object)


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FRMDialogVisualizarRenome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim x As Integer
        Dim numeroDeItens As Integer = Renamed_SelectedFoldersAndFiles.Count

        FRM_Load.ProgressBar1.Value = 0
        FRM_Load.ProgressBar1.Minimum = 0
        FRM_Load.ProgressBar1.Maximum = Renamed_SelectedFoldersAndFiles.Count
        FRM_Load.Width = Me.Width - 20

        FRM_Load.Show()

        LBRenomeados.Items.Clear()

        For Each Renamed_selectedItem In Renamed_SelectedFoldersAndFiles
            FRM_Load.ProgressBar1.Value = x

            If SelectedFoldersAndFiles(x).FullName <> Renamed_selectedItem.FullName Then

                LBRenomeados.Items.Add("[" & x & "]   " & SelectedFoldersAndFiles(x).FullName & "        =>      " & Renamed_selectedItem.FullName)
                LBRenomeados.Items.Add("")

            End If

            ' strDataRenameList = strDataRenameList + str
            x += 1
        Next


        If LBRenomeados.Items.Count > 0 Then
            LBLExplicacao.Text = "Veja abaixo a previsão de renome de " & numeroDeItens & " item (s)."
        Else
            LBLExplicacao.Text = "Nenhuma previsão de renome."
        End If

        FRM_Load.Close()

    End Sub

    'Postada em 9/9/2003 por The Matrix            

    Declare Function SetSysColors Lib "user32" (ByVal nChanges As Long, lpSysColor As Long, lpColorValues As Long) As Long
    Public Const COLOR_SCROLLBAR = 0 'The Scrollbar colour
    Public Const COLOR_BACKGROUND = 1 'Colour of the background with no wallpaper
    Public Const COLOR_ACTIVECAPTION = 2 'Caption of Active Window
    Public Const COLOR_INACTIVECAPTION = 3 'Caption of Inactive window
    Public Const COLOR_MENU = 4 'Menu
    Public Const COLOR_WINDOW = 5 'Windows background
    Public Const COLOR_WINDOWFRAME = 6 'Window frame
    Public Const COLOR_MENUTEXT = 7 'Window Text
    Public Const COLOR_WINDOWTEXT = 8 '3D dark shadow (Win95)
    Public Const COLOR_CAPTIONTEXT = 9 'Text in window caption
    Public Const COLOR_ACTIVEBORDER = 10 'Border of active window
    Public Const COLOR_INACTIVEBORDER = 11 'Border of inactive window
    Public Const COLOR_APPWORKSPACE = 12 'Background of MDI desktop
    Public Const COLOR_HIGHLIGHT = 13 'Selected item background
    Public Const COLOR_HIGHLIGHTTEXT = 14 'Selected menu item
    Public Const COLOR_BTNFACE = 15 'Button
    Public Const COLOR_BTNSHADOW = 16 '3D shading of button
    Public Const COLOR_GRAYTEXT = 17 'Grey text, of zero if dithering is used.
    Public Const COLOR_BTNTEXT = 18 'Button text
    Public Const COLOR_INACTIVECAPTIONTEXT = 19 'Text of inactive window
    Public Const COLOR_BTNHIGHLIGHT = 20 '3D highlight of button
    'Form




    'Renato Sanches
End Class
