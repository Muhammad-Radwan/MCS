Public Class FrmDateSelector3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim repo As New SQLOperations()

        If DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value) < 366 Then
            MsgBox("لا يمكن استخراج الزكاة في حالة كانت الفترة أقل من عام", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim TotalNetIncome As Decimal = repo.GetValueFromDB("Sum", "KEMAT - KEMA", "Kashef", $"Where DateX >='{DateTimePicker1.Value.ToString("yyyy-MM-dd")}' and DateX <= '{DateTimePicker2.Value.ToString("yyyy-MM-dd")}'")
        Dim TotalExpences As Decimal = repo.GetValueFromDB("Sum", "Lossva", "Loss", $"Where LossDate >='{DateTimePicker1.Value.ToString("yyyy-MM-dd")}' and LossDate <= '{DateTimePicker2.Value.ToString("yyyy-MM-dd")}'")
        Dim Net As Decimal = TotalNetIncome - TotalExpences

        Label1.Text = $"إجمالي إيراد العيادة: {TotalNetIncome}"
        Label2.Text = $"إجمالي المصاريف: {TotalExpences}"
        Label3.Text = $"صافي الإيرادات: {Net}"
        Label4.Text = $"قيمة الزكاة: {Net * 0.025}"
    End Sub
End Class