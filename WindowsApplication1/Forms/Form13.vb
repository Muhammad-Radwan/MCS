Public Class Form13

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        xx2 = Me.DateTimePicker1
        xx3 = Me.DateTimePicker2
        Dim f As New Form12
        f.ShowDialog()
    End Sub
End Class