Public Class FrmReceiptReport
    Friend KESEM_P As String

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim cr1 As New CrystalReport29, cri As String
        Me.Hide()
        cri = "{KASHEF.ESALNO}=" & "" & vv1 & ""
        cr1.SetParameterValue(0, Me.KESEM_P)
        cr1.RecordSelectionFormula = cri
        cr1.PrintOptions.PrinterName = "LK-TE212"
        cr1.PrintToPrinter(1, False, 1, 1)




        'If vv = 1 Then
        'cri = "{PHARMACY.FNUMBER}=" & "'" & vv1 & "'"

        'End If
        '*******=================================================
        'Dim t11 As CrystalDecisions.CrystalReports.Engine.Tables
        'Dim t21 As CrystalDecisions.CrystalReports.Engine.Table
        't11 = cr1.Database.Tables
        'For Each t21 In t11
        '    t21.Location = Application.StartupPath & "SYSLC\SQLEXPRESS;Initial Catalog=CLINICSQL;Integrated Security=True"
        'Next
        '*******==================================================
        'CrystalReportViewer1.SelectionFormula = cri
        'CrystalReportViewer1.ReportSource = cr1
        'cr1.PrintToPrinter("{KASHEF.ESALNO}=", True, 0, 0)
    End Sub
End Class