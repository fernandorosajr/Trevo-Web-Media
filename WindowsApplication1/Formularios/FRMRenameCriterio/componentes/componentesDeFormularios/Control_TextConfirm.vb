Public Class Control_TextConfirm
    Private _valueStr As String
    Public Property ValueStr As String
        Get
            Return _valueStr
        End Get
        Set(value As String)
            _valueStr = value
            TXTValue.TXT = value

        End Set
    End Property

    Private _filho As Control
    Public Property Filho As Control
        Get
            Return _filho

        End Get
        Set(value As Control)
            _filho = value
            ValueStr = _filho.Text

        End Set
    End Property

    Private Sub BTNConfirmarAlterarValor_Click(sender As Object, e As EventArgs) Handles BTNConfirmarAlterarValor.Click

        TXTValue.ErrorDisplay = False

        ValueStr = TXTValue.TXT

        If _valueStr <> "" Then

            Me.Visible = False

            If _filho IsNot Nothing Then
                _filho.Text = _valueStr

            End If
        Else
            TXTValue.ErrorDisplay = True

        End If
    End Sub

    Private Sub BTNCancelarAlterarValor_Click(sender As Object, e As EventArgs) Handles BTNCancelarAlterarValor.Click
        Me.Visible = False
        TXTValue.ErrorDisplay = False

    End Sub



    Private Sub Control_TextConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Control_TextConfirm_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        TXTValue.Focus()
    End Sub
End Class
