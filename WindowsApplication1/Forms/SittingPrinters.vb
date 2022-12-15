Imports System.Drawing.Printing
Public Class SittingPrinters
    Private Sub SittingPrinters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pkInstalledPrinters As String

        ' Find all printers installed
        For Each pkInstalledPrinters In
            PrinterSettings.InstalledPrinters
            ComboBox1.Items.Add(pkInstalledPrinters)
            ComboBox5.Items.Add(pkInstalledPrinters)
        Next pkInstalledPrinters

        ' Set the combo to the first printer in the list
        ComboBox1.Text = My.Settings.printerx1
        ComboBox5.Text = My.Settings.printerx2
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Settings.printerx1 = ComboBox1.Text
        My.Settings.printerx2 = ComboBox5.Text
        Try
            My.Settings.Save()
            MsgBox("تم حفظ الإعدادات", MsgBoxStyle.Information, "منظومة العيادة")
        Catch ex As Exception
            MsgBox("لم يتم الحفظ راجع مدخلاتك", MsgBoxStyle.Exclamation, "منظومة العيادة")
        End Try
    End Sub
End Class