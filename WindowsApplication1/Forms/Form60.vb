Public Class Form60
    Friend a As String
    Friend b As String
    Friend c As String
    Friend d As String
    Friend e As String
    Friend g As String
    Friend h As String
    Friend j As String
    Friend k As String
    Friend l As String
    Friend x1 As String
    Friend Esal As String
    Friend Madfo As String
    Friend Namez As String
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        Dim cr1 As New CrystalReport42, cri As String
        'cri = "{m2.nofatora}=" & "'" & vv1 & "'" & "and {sadad.ID}=" & "'" & vv2 & "'"
        'cri = "{m1.nofatora}=" & "'" & vv1 & "'"
        'cri = "{m2.nofatora}=" & "'" & vv1 & "'"
        'cri = "{fatmogh.nofatora}=" & "'" & vv1 & "'"
        '  cri = "{m1.nofatora}=" & "'" & vv1 & "'" & "and {fatmogh.nofatora}=" & "'" & vv1 & "'" & "and {m2.nofatora}=" & "'" & vv1 & "'"

        'cri = "{fatmogh.nofatora}=" & "'" & vv1 & "'"
        'cri = "{khad.nofatora}=" & "'" & vv1 & "'"

        '*******=================================================
        cr1.SetDatabaseLogon("admin", "13061982")

        '*******==================================================
        ' cr1.SetParameterValue(0, Me.e)
        'cr1.SetParameterValue(1, Me.l)
        cr1.SetParameterValue(0, Me.x1)
        cr1.SetParameterValue(1, Me.e)
        cr1.SetParameterValue(2, Me.Esal)
        cr1.SetParameterValue(3, Me.Madfo)
        cr1.SetParameterValue(4, Me.Namez)
        CrystalReportViewer1.SelectionFormula = cri
        CrystalReportViewer1.ReportSource = cr1
    End Sub
End Class