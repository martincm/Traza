Public Class OrdenarXId : Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) _
    As Integer Implements System.Collections.IComparer.Compare
        Dim item1 As ListViewItem = CType(x, ListViewItem)
        Dim item2 As ListViewItem = CType(y, ListViewItem)
        '   Return (Math.Sign(CLng(item1.SubItems(4).Text) - CLng(item2.SubItems(4).Text)))
        Return (Math.Sign(CLng(item2.SubItems(4).Text) - CLng(item1.SubItems(4).Text)))

    End Function



End Class