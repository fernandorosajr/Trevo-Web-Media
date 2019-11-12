Public Class ControlListIcone

    Dim QualModifica As Byte

    Dim CorDoMouseEmCima As Color
    Dim CorDoMouseSelect As Color
    Dim MultSelect As Boolean
    Public MouseSobreCheck As Boolean
    Public MouseSobreIcone As Boolean

    Dim EtiquetaStr As String


    Property Etiqueta() As String
        Get

            EtiquetaStr = LBL_EtiquetaTitolo.Text
            Return EtiquetaStr

        End Get
        Set(value As String)
            EtiquetaStr = value
            LBL_EtiquetaTitolo.Text = EtiquetaStr
        End Set
    End Property

    Dim MaisInforStr As String
    Property MaisInformacoes() As String

        Get
            MaisInforStr = LBL_Labelo_MaisInforStr.Text
            Return MaisInforStr
        End Get
        Set(value As String)

            MaisInforStr = value
            LBL_Labelo_MaisInforStr.Text = MaisInforStr
        End Set
    End Property

    Dim MostrarInfor As Boolean

    Property Mostrar_Informacoes() As Boolean
        Get
            If LBL_Labelo_MaisInforStr.Text <> "" Then
                MostrarInfor = LBL_Labelo_MaisInforStr.Visible

            Else
                LBL_Labelo_MaisInforStr.Visible = False
                MostrarInfor = LBL_Labelo_MaisInforStr.Visible



            End If

            Return MostrarInfor


        End Get
        Set(value As Boolean)
            MostrarInfor = value
            LBL_Labelo_MaisInforStr.Visible = MostrarInfor

        End Set
    End Property

    Private Sub ControlListIcone_Load(sender As Object, e As EventArgs) Handles Me.Load
        PanelImage.BackColor = Me.Parent.BackColor
        CorDoMouseEmCima = Color.FromName("Highlight")
        CorDoMouseSelect = Color.FromName("HotTrack")
        MostrarInfor = True


    End Sub

    Sub MouseEntra()


        CkImage.Visible = True
        Me.PanelBorder.BackColor = CorDoMouseEmCima



    End Sub
    Sub MouseSai()
        If MouseSobreCheck = False And MouseSobreIcone = False Then

            CkImage.Visible = False
            Me.PanelBorder.BackColor = Color.Transparent
        End If

    End Sub

    Sub MouseSelected()

    End Sub


    Private Sub PanelImage_Click(sender As Object, e As EventArgs) Handles PanelImage.Click
        Me.Focus()



    End Sub

    Private Sub PanelImage_MouseEnter(sender As Object, e As EventArgs) Handles PanelImage.MouseEnter
        'If SobreCheck = False Then
        MouseSobreIcone = True
        CkImage.Focus()
        MouseEntra()
        'End If
    End Sub

    Private Sub PanelImage_MouseLeave(sender As Object, e As EventArgs) Handles PanelImage.MouseLeave

        If Not (CkImage.Focused) Then
            MouseSobreIcone = False
            MouseSai()
        End If


    End Sub



    Private Sub CkImage_MouseEnter(sender As Object, e As EventArgs) Handles CkImage.MouseEnter
        MouseSobreCheck = True


    End Sub

    Private Sub CkImage_MouseLeave(sender As Object, e As EventArgs) Handles CkImage.MouseLeave
        MouseSobreCheck = False


    End Sub

    Private Sub CkImage_CheckedChanged(sender As Object, e As EventArgs) Handles CkImage.CheckedChanged

    End Sub

    Private Sub PanelImage_Paint(sender As Object, e As PaintEventArgs) Handles PanelImage.Paint

    End Sub

    Private Sub LBL_EtiquetaTitolo_Click(sender As Object, e As EventArgs) Handles LBL_EtiquetaTitolo.Click

    End Sub

    Private Sub LBL_EtiquetaTitolo_DoubleClick(sender As Object, e As EventArgs) Handles LBL_EtiquetaTitolo.DoubleClick

        QualModifica = 1

        TXT_Renomear.Text = LBL_EtiquetaTitolo.Text
        TXT_Renomear.Font = LBL_EtiquetaTitolo.Font
        LBL_EtiquetaTitolo.Visible = False
        TXT_Renomear.Visible = True
        TXT_Renomear.Focus()



    End Sub

    Private Sub LBL_EtiquetaTitolo_GotFocus(sender As Object, e As EventArgs) Handles LBL_EtiquetaTitolo.GotFocus

    End Sub

    Private Sub LBL_EtiquetaTitolo_LostFocus(sender As Object, e As EventArgs) Handles LBL_EtiquetaTitolo.LostFocus


    End Sub

    Private Sub TXT_Renomear_TextChanged(sender As Object, e As EventArgs) Handles TXT_Renomear.TextChanged

    End Sub

    Private Sub TXT_Renomear_GotFocus(sender As Object, e As EventArgs) Handles TXT_Renomear.GotFocus
        TXT_Renomear.SelectionStart = 0
        TXT_Renomear.SelectionLength = Len(TXT_Renomear.Text)

    End Sub

    Private Sub TXT_Renomear_LostFocus(sender As Object, e As EventArgs) Handles TXT_Renomear.LostFocus
        TXT_Renomear.Visible = False
        LBL_EtiquetaTitolo.Visible = True
        LBL_Labelo_MaisInforStr.Visible = MostrarInfor


    End Sub

    Private Sub TXT_Renomear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Renomear.KeyPress
        If Asc(e.KeyChar) = 13 Then

            If QualModifica = 1 Then
                Etiqueta = TXT_Renomear.Text
                QualModifica = 0

                TXT_Renomear.Visible = False
                LBL_EtiquetaTitolo.Visible = True
                LBL_Labelo_MaisInforStr.Visible = MostrarInfor

                LBL_EtiquetaTitolo.Focus()


            End If



        End If


    End Sub

    Private Sub PanelBorder_MouseLeave(sender As Object, e As EventArgs) Handles PanelBorder.MouseLeave
        If Not (CkImage.Checked) Then
            MouseSobreIcone = False
            MouseSai()
        End If
    End Sub
End Class
