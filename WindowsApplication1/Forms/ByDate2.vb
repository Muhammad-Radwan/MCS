Public Class ByDate2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value) < 366 Then
            MsgBox("لا يمكن استخراج الزكاة في حالة كانت الفترة أقل من عام", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
    End Sub
End Class