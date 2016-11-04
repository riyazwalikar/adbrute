Public Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Private order As SortOrder

    Public Shared stat As Long

    Public Sub New()
        col = 0
        order = SortOrder.Ascending
        stat = 1
    End Sub

    Public Sub New(ByVal column As Integer, ByVal order As SortOrder)
        col = column
        Me.order = order
        stat = 2
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        If stat = 0 Then Exit Function
        Dim returnVal As Integer = -1
        returnVal = [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        If order = SortOrder.Descending Then
            returnVal *= -1
        End If
        Return returnVal
    End Function
End Class
