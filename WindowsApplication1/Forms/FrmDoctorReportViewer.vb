Public Class FrmDoctorReportViewer

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        'Dim cr1 As New CrystalReport4, cri As String
        ''cri = "{APPOINTMENT1.datea}>=" & "#" & d1.Value.Date & "#" & "and {APPOINTMENT1.datea}<=" & "#" & d2.Value.Date & "#" & "and {APPOINTMENT1.doctorname}=" & "'" & vv1 & "'"
        'cri = "{doctor_view.dn}=" & "'" & vv1 & "'"

        ''End If
        ''*******=================================================
        ''Dim t11 As CrystalDecisions.CrystalReports.Engine.Tables
        ''Dim t21 As CrystalDecisions.CrystalReports.Engine.Table
        ''t11 = cr1.Database.Tables
        ''For Each t21 In t11
        ''    't21.Location = Application.StartupPath & "\dbsbh.mdb"
        ''    't21.Location = "\\Server-pc\ÇáãäÙæãÉ ÇáØÈíÉ\dbsbh.mdb"
        ''Next
        ''*******==================================================
        'CrystalReportViewer1.SelectionFormula = cri
        'CrystalReportViewer1.ReportSource = cr1
    End Sub
End Class