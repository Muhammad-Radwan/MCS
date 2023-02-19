Public Class FrmReportBySex

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vv1 = Me.ComboBox1.Text
        Dim f As New FrmReportBySexViewer
        f.ShowDialog()
    End Sub
End Class