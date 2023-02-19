Public Class Form56

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        'Dim cr1 As New CrystalReport25, cri As String
        ''If vv = 1 Then
        ''cri = "{PHARMACY.FNUMBER}=" & "'" & vv1 & "'"
        ''    cri = "{appointment.fnumber}=" & "'" & vv1 & "'" & " and {MAIN.FNUMBER}= " & "'" & vv1 & "'"
        'cri = "{MAIN.FNUMBER}= " & "'" & vv1 & "'" & " and {Serology.fnumber}=" & "'" & vv1 & "'"

        ''End If
        ''*******=================================================
        'Dim t11 As CrystalDecisions.CrystalReports.Engine.Tables
        'Dim t21 As CrystalDecisions.CrystalReports.Engine.Table
        't11 = cr1.Database.Tables
        'For Each t21 In t11
        '    t21.Location = Application.StartupPath & "\dbsbh.mdb"
        '    't21.Location = "\\Server-pc\«·„‰ŸÊ„… «·ÿ»Ì…\dbsbh.mdb"
        'Next
        ''*******==================================================
        'CrystalReportViewer1.SelectionFormula = cri
        'CrystalReportViewer1.ReportSource = cr1

    End Sub

    Private Sub Form56_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class