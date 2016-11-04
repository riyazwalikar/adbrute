Public Class PropertyWindow

    Private Sub PropertyWindow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        listuser = ""
        ADBruteFrm.Show()
    End Sub

    Private Sub PropertyWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Domainnamelbl.Text = ADBruteFrm.Domainlbl.Text
        ADBruteFrm.Hide()
    End Sub
End Class