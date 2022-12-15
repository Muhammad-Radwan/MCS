Public Class khazenaprint
    Friend KESEM_P As String

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim cr1 As New CrystalReport29, cri As String
        Me.Hide()
        cri = "{KASHEF.ESALNO}=" & "" & vv1 & ""
        cr1.SetParameterValue(0, Me.KESEM_P)
        cr1.RecordSelectionFormula = cri
        cr1.PrintOptions.PrinterName = "LK-TE212"
        cr1.PrintToPrinter(1, False, 1, 1)
    End Sub
End Class