Namespace System.ComponentModel.Design
    Friend Class CollectionEditor


    End Class

    Public Class MyStringCollectionEditor
        Inherits CollectionEditor

        Public Sub New()
            MyBase.New(type:=GetType(List(Of String)))
        End Sub

        Protected Overrides Function CreateInstance(ByVal itemType As Type) As Object
            Return String.Empty
        End Function
    End Class


End Namespace
