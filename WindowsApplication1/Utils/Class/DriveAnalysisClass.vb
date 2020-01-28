Imports System.IO
Public Class DriveAnalysisClass

    Dim _nomeDoDrive As String
    Public Property NomeDoDrive As String
        Get
            Return _nomeDoDrive
        End Get
        Set(value As String)
            _nomeDoDrive = value
        End Set
    End Property

    Dim _tipoDeDrive As String
    Public Property TipoDeDrive As String
        Get
            Return _tipoDeDrive
        End Get
        Set(value As String)
            _tipoDeDrive = value
        End Set
    End Property

    Dim _rotuloDoDrive As String
    Public Property RotuloDoDrive As String
        Get
            Return _rotuloDoDrive
        End Get
        Set(value As String)
            _rotuloDoDrive = value
        End Set
    End Property

    Dim _todoDrive As String
    Public Property TodoDrive As String
        Get
            Return _todoDrive
        End Get
        Set(value As String)
            _todoDrive = value
        End Set
    End Property

    Dim _iconeDoDrive As String
    Public Property IconeDoDrive As String
        Get
            Return _iconeDoDrive
        End Get
        Set(value As String)
            _iconeDoDrive = value
        End Set
    End Property

    Function EDrive(caminho As String) As Boolean

        Dim fullName As String
        fullName = caminho

        If fullName.IndexOf(":") <> -1 And fullName.Count = 3 Then
            Return True
        Else
            Return False
        End If

    End Function

    Function ReturnLabelVolumeDisplay(drive As DriveInfo) As String

        NomeDoDrive = drive.Name

        TipoDeDrive = drive.DriveType

        Select Case drive.DriveType
            Case 0
                TipoDeDrive = "Unknown"

            Case 1
                TipoDeDrive = "NoRootDirectory"

            Case 2
                TipoDeDrive = "Removable"
                IconeDoDrive = "Pen.ico"

            Case 3
                TipoDeDrive = "Fixed"
                IconeDoDrive = "hd"

            Case 4
                TipoDeDrive = "Network"

            Case 5
                TipoDeDrive = "CD Rom"
                IconeDoDrive = "DVD"

            Case 6
                TipoDeDrive = "Ram"
        End Select

        RotuloDoDrive = ""

        If drive.IsReady Then
            RotuloDoDrive = CType(drive.VolumeLabel.ToString, String)
        End If

        If Not RotuloDoDrive Is Nothing Then

            If RotuloDoDrive = "" Then
                If TipoDeDrive.ToString = "Fixed" Then
                    RotuloDoDrive = "Disco Local"
                ElseIf TipoDeDrive.ToString = "CD Rom" Then
                    RotuloDoDrive = "Unidade de Disco Removível"
                    IconeDoDrive = "UnidadeVazia"
                End If
            End If

            TodoDrive = RotuloDoDrive & " (" & NomeDoDrive.Substring(0, 2) & ")"
        Else
            TodoDrive = "(" & NomeDoDrive.Substring(0, 2) & ")"
        End If

        Return TodoDrive

    End Function
End Class
