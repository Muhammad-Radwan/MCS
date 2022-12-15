Public Class Form17

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vv1 = Me.ComboBox1.Text
        Dim f As New Form20
        f.ShowDialog()
    End Sub
End Class