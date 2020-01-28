Imports System.Windows.Forms

Public Class FRMDialogInputBox
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

    Dim _defaultResponse As String
    Public Property DefaultResponse
        Get
            Return _defaultResponse
        End Get
        Set(value)
            _defaultResponse = value
            TxtResponse.Text = value
        End Set
    End Property

    Dim _prompt As String
    Public Property Prompt As String
        Get
            Return _prompt
        End Get
        Set(value As String)
            _prompt = value
            LBLPrompt.Text = value
        End Set
    End Property

    Dim _result As String
    Public Property Result As String
        Get
            Return _result
        End Get
        Set(value As String)
            _result = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogRenameVolume_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtResponse_TextChanged(sender As Object, e As EventArgs) Handles TxtResponse.TextChanged
        'Dim message As String

        'message = "Arquivos e pastas não podem conter os seguintes caracteres em seus nomes:" &
        '            Microsoft.VisualBasic.ControlChars.Cr &
        '            "\ " & "/ " & "| " & ": " & "* " & "? " & """" & " < " & ">"

        'ErrorProvider1.Clear()

        'If TxtResponse.Text.IndexOfAny(New Char() {"\"c, "/"c, "|"c, ":"c, "*"c, "?"c, """"c, "<"c, ">"c}) = -1 Then
        '    Result = Trim(TxtResponse.Text)
        'Else
        '    ErrorProvider1.SetError(TxtResponse, message)
        'End If

        Result = TxtResponse.Text
    End Sub

    Private Sub TxtResponse_GotFocus(sender As Object, e As EventArgs) Handles TxtResponse.GotFocus
        TxtResponse.SelectionStart = 0
        TxtResponse.SelectionLength = TxtResponse.Text.Length
    End Sub

End Class
