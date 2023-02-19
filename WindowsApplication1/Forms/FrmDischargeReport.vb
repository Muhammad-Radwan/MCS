Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb

Public Class FrmDischargeReport
    'Dim constr As String = "provider=microsoft.jet.oledb.4.0;data source =" + serv + "\Hotel.mdb;" & "jet OLEDB:Database Password=13061982;"
    'Dim con As New OleDbConnection(constr)
    'Dim sqlstr As String = "select * from fatmogh"
    'Dim DataAdapter1 As New OleDbDataAdapter(sqlstr, con)
    'Dim dataset2 As New DataSet
    Friend a As String
    Friend b As String
    Friend c As String
    Friend d As String
    Friend e As String
    Friend g As String
    Friend h As String
    Friend j As String
    'Friend k As String
    Friend l As Decimal
    Friend nam As String
    Friend jehan As String
    Friend gorfan As String
    Friend gorfat As String
    Friend gorfaad As String
    Friend yedate As Date
    Friend modate As Date
    Friend motime As Date
    Friend d11 As Date
    Friend d22 As Date
    Friend NAMEC As String
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        'cri = "{m1.nofatora}=" & "'" & vv1 & "'" & "and {fatmogh.nofatora}=" & "'" & vv1 & "'"
        'cri = "{m1.nofatora}=" & "'" & vv1 & "'"
        'cri = "{m2.nofatora}=" & "'" & vv1 & "'"
        'cri = "{fatmogh.nofatora}=" & "'" & vv1 & "'"
        '  cri = "{m1.nofatora}=" & "'" & vv1 & "'" & "and {fatmogh.nofatora}=" & "'" & vv1 & "'" & "and {m2.nofatora}=" & "'" & vv1 & "'"

        'cri = "{fatmogh.nofatora}=" & "'" & vv1 & "'"
        'cri = "{khad.nofatora}=" & "'" & vv1 & "'"
        If PRK = 1 Then
            Dim cr2 As New VIEW2, cri2 As String
            'Dim cr2 As New CrystalReport5, cri2 As String
            cri2 = "{fatmogh.DATEX}>=" & "#" & VV3 & "#" & "AND {fatmogh.DATEX}<=" & "#" & VV4 & "#"
            'cr2.SetDatabaseLogon("admin", "13061982")
            cr2.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
            '*******==================================================
            cr2.SetParameterValue(0, Me.a)
            cr2.SetParameterValue(1, Me.b)
            cr2.SetParameterValue(2, Me.c)
            cr2.SetParameterValue(3, Me.d)
            cr2.SetParameterValue(4, Me.e)
            cr2.SetParameterValue(5, Me.g)
            cr2.SetParameterValue(6, Me.h)
            cr2.SetParameterValue(7, Me.j)
            'cr1.SetParameterValue(8, Me.k)
            cr2.SetParameterValue(9, Me.l)
            cr2.SetParameterValue(10, Me.nam)
            cr2.SetParameterValue(11, Me.jehan)
            cr2.SetParameterValue(12, Me.gorfan)
            cr2.SetParameterValue(13, Me.gorfat)
            cr2.SetParameterValue(14, Me.gorfaad)
            cr2.SetParameterValue(15, Me.yedate)
            cr2.SetParameterValue(16, Me.modate)
            cr2.SetParameterValue(17, Me.motime)
            cr2.SetParameterValue(18, Me.d11)
            cr2.SetParameterValue(19, Me.d22)
            CrystalReportViewer1.SelectionFormula = cri2
            CrystalReportViewer1.ReportSource = cr2
        Else
            Dim cr1 As New VIEW1, cri As String
            cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
            '*******==================================================
            Dim RM As Resources.ResourceManager
            RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
            NAMEC = RM.GetString("NAMECLINIC")

            cr1.SetParameterValue(0, Me.a)
            cr1.SetParameterValue(1, Me.b)
            cr1.SetParameterValue(2, Me.c)
            cr1.SetParameterValue(3, Me.d)
            cr1.SetParameterValue(4, Me.e)
            cr1.SetParameterValue(5, Me.g)
            cr1.SetParameterValue(6, Me.h)
            cr1.SetParameterValue(7, Me.j)
            'cr1.SetParameterValue(8, Me.k)
            cr1.SetParameterValue(9, Me.l)
            cr1.SetParameterValue(10, Me.nam)
            cr1.SetParameterValue(11, Me.jehan)
            cr1.SetParameterValue(12, Me.gorfan)
            cr1.SetParameterValue(13, Me.gorfat)
            cr1.SetParameterValue(14, Me.gorfaad)
            cr1.SetParameterValue(15, Me.yedate)
            cr1.SetParameterValue(16, Me.modate)
            cr1.SetParameterValue(17, Me.motime)
            cr1.SetParameterValue(18, Me.NAMEC)
            CrystalReportViewer1.SelectionFormula = cri
            CrystalReportViewer1.ReportSource = cr1
        End If
        '*******=================================================

    End Sub

End Class