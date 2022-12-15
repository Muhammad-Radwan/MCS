Public Class Form58

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        'Dim cr1 As New CrystalReport32, cri As String
        Dim cr1 As New CrystalReport33, cri As String
        'If vv = 1 Then
        'cri = "{PHARMACY.FNUMBER}=" & "'" & vv1 & "'"
        '    cri = "{appointment.fnumber}=" & "'" & vv1 & "'" & " and {MAIN.FNUMBER}= " & "'" & vv1 & "'"
        cri = "{JEHAKASHEF.namem}= " & "'" & vv1 & "'"
        cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")

        'End If
        '*******=================================================
        'Dim t11 As CrystalDecisions.CrystalReports.Engine.Tables
        'Dim t21 As CrystalDecisions.CrystalReports.Engine.Table
        't11 = cr1.Database.Tables
        'For Each t21 In t11
        '    t21.Location = Application.StartupPath & "\dbsbh.mdb"
        '    't21.Location = "\\Server-pc\المنظومة الطبية\dbsbh.mdb"
        'Next
        '*******==================================================
        CrystalReportViewer1.SelectionFormula = cri
        CrystalReportViewer1.ReportSource = cr1
    End Sub
End Class