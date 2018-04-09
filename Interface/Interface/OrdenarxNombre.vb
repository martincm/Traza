Public Class OrdenarxNombre
    Implements IComparer
    Private Columna As Integer


    Public Sub New(ByVal pcolumna As Integer)
        Me.Columna = pcolumna
    End Sub


    Public Function Compare(ByVal x As Object, ByVal y As Object) _
    As Integer Implements System.Collections.IComparer.Compare
        Dim item1 As ListViewItem = CType(x, ListViewItem)
        Dim item2 As ListViewItem = CType(y, ListViewItem)
        Try
            Return String.Compare(item1.SubItems(Columna).Text, item2.SubItems(Columna).Text)
        Catch ex As Exception

        End Try



    End Function
End Class
