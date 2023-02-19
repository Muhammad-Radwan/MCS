Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmDoctorPaymentsReport
    Friend DD1 As Date
    Friend DD2 As Date
    Friend CLIN As String
    Friend I As Integer
    'Friend NNN As String
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        If DOCT = 1 Then
            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables
            Dim CrTable As Table
            Dim TableCounter
            Dim reader As New System.IO.StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim crReportDocument As New CrystalReport51(), cri2 As String
            crReportDocument.Load("CrystalReport51.rpt")
            'cri2 = "{HESAB_DO.DOCTORNAME}=" & "'" & vv1 & "'" & " AND {HESAB_DO.TAS_DATE} >=" & "#" & Format(DD1.Date, "yyyy-MM-dd") & "#" & " AND {HESAB_DO.TAS_DATE} <=" & "#" & Format(DD2.Date, "yyyy-MM-dd") & "#"
            With crConnectionInfo
                .ServerName = ReadLine(2, allLines)
                .DatabaseName = ReadLine(1, allLines)
                .UserID = "AH"
                .Password = "123456"
            End With
            CrTables = crReportDocument.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            crReportDocument.RecordSelectionFormula = cri2
            CrystalReportViewer1.SelectionFormula = cri2
            crReportDocument.SetParameterValue(0, DD1)
            crReportDocument.SetParameterValue(1, DD2)
            crReportDocument.SetParameterValue(2, I)
            CrystalReportViewer1.ReportSource = crReportDocument

            'Dim cr1 As New CrystalReport34, cri As String
            'cri = "{HESAB_DO.DOCTORNAME}=" & "'" & vv1 & "'" & "AND{HESAB_DO.TAS_DATE}>=" & "#" & DD1 & "#" & "AND{HESAB_DO.TAS_DATE}<=" & "#" & DD2 & "#"
            'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
            'CrystalReportViewer1.SelectionFormula = cri
            'CrystalReportViewer1.ReportSource = cr1
            DOCT = 0
        End If
        If DOCT = 2 Then
            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables
            Dim CrTable As Table
            Dim TableCounter
            Dim reader As New System.IO.StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim crReportDocument As New CrystalReport57(), cri2 As String
            crReportDocument.Load("CrystalReport57.rpt")
            'cri2 = "{HESAB_DO.TAS_DATE} >=" & "#" & Format(DD1.Date, "yyyy-MM-dd") & "#" & "AND {HESAB_DO.TAS_DATE} <=" & "#" & Format(DD2.Date, "yyyy-MM-dd") & "#"
            With crConnectionInfo
                .ServerName = ReadLine(2, allLines)
                .DatabaseName = ReadLine(1, allLines)
                .UserID = "AH"
                .Password = "123456"
            End With
            CrTables = crReportDocument.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            crReportDocument.RecordSelectionFormula = cri2
            CrystalReportViewer1.SelectionFormula = cri2
            crReportDocument.SetParameterValue(0, DD1)
            crReportDocument.SetParameterValue(1, DD2)
            CrystalReportViewer1.ReportSource = crReportDocument

            'Dim cr1 As New CrystalReport35, cri As String
            'cri = "{HESAB_DO.TAS_DATE}>=" & "#" & DD1 & "#" & "AND{HESAB_DO.TAS_DATE}<=" & "#" & DD2 & "#"
            'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
            'CrystalReportViewer1.SelectionFormula = cri
            'CrystalReportViewer1.ReportSource = cr1
            DOCT = 0
        End If
        If DOCT = 3 Then
            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables
            Dim CrTable As Table
            Dim TableCounter
            Dim reader As New System.IO.StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim crReportDocument As New CrystalReport55(), cri2 As String
            crReportDocument.Load("CrystalReport55.rpt")
            'cri2 = "{KASHEF.DOCTORNAME}=" & "'" & vv1 & "'" & "AND{KASHEF.DATEX}>=" & "#" & DD1.Date & "#" & "AND{KASHEF.DATEX}<=" & "#" & DD2.Date & "#"
            With crConnectionInfo
                .ServerName = ReadLine(2, allLines)
                .DatabaseName = ReadLine(1, allLines)
                .UserID = "AH"
                .Password = "123456"
            End With
            CrTables = crReportDocument.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            crReportDocument.RecordSelectionFormula = cri2
            CrystalReportViewer1.SelectionFormula = cri2
            crReportDocument.SetParameterValue(0, DD1)
            crReportDocument.SetParameterValue(1, DD2)
            crReportDocument.SetParameterValue(2, I)
            CrystalReportViewer1.ReportSource = crReportDocument

            'Dim cr1 As New CrystalReport36, cri As String
            'cri = "{KASHEF.DOCTORNAME}=" & "'" & vv1 & "'" & "AND{KASHEF.DATEX}>=" & "#" & DD1 & "#" & "AND{KASHEF.DATEX}<=" & "#" & DD2 & "#"
            'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
            'CrystalReportViewer1.SelectionFormula = cri
            'CrystalReportViewer1.ReportSource = cr1
            DOCT = 0
        End If
        If DOCT = 4 Then
            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables
            Dim CrTable As Table
            Dim TableCounter
            Dim reader As New System.IO.StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim crReportDocument As New CrystalReport56(), cri2 As String
            crReportDocument.Load("CrystalReport56.rpt")
            'cri2 = "{HESAB_DO.TAS_DATE}>=" & "#" & DD1.Date & "#" & "AND{HESAB_DO.TAS_DATE}<=" & "#" & DD2.Date & "#"
            With crConnectionInfo
                .ServerName = ReadLine(2, allLines)
                .DatabaseName = ReadLine(1, allLines)
                .UserID = "AH"
                .Password = "123456"
            End With
            CrTables = crReportDocument.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            crReportDocument.RecordSelectionFormula = cri2
            CrystalReportViewer1.SelectionFormula = cri2
            crReportDocument.SetParameterValue(0, DD1)
            crReportDocument.SetParameterValue(1, DD2)
            CrystalReportViewer1.ReportSource = crReportDocument

            'Dim cr1 As New CrystalReport35, cri As String
            'cri = "{HESAB_DO.TAS_DATE}>=" & "#" & DD1 & "#" & "AND{HESAB_DO.TAS_DATE}<=" & "#" & DD2 & "#"
            'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
            'CrystalReportViewer1.SelectionFormula = cri
            'CrystalReportViewer1.ReportSource = cr1
            DOCT = 0
        End If
        If DOCT = 5 Then
            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables
            Dim CrTable As Table
            Dim TableCounter
            Dim reader As New System.IO.StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim crReportDocument As New CrystalReport50(), cri2 As String
            crReportDocument.Load("CrystalReport50.rpt")
            'cri2 = "{EIRADAT.DATEX} >=" & "#" & Format(DD1.Date, "yyyy-MM-dd") & "#" & "AND {EIRADAT.DATEX} <=" & "#" & Format(DD2.Date, "yyyy-MM-dd") & "#"
            With crConnectionInfo
                .ServerName = ReadLine(2, allLines)
                .DatabaseName = ReadLine(1, allLines)
                .UserID = "AH"
                .Password = "123456"
            End With
            CrTables = crReportDocument.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo =
            crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
            CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            crReportDocument.RecordSelectionFormula = cri2
            CrystalReportViewer1.SelectionFormula = cri2
            crReportDocument.SetParameterValue(0, DD1)
            crReportDocument.SetParameterValue(1, DD2)
            crReportDocument.SetParameterValue(2, CLIN)
            CrystalReportViewer1.ReportSource = crReportDocument


            'Dim cr1 As New CrystalReport37, cri As String
            ''cri = "select * from EIRADAT where DATEX between" & "#" & DD1 & "#" & " and " & "#" & DD2 & "#"
            'cri = "{EIRADAT.DATEX} >=" & "#" & DD1.Date & "#" & "AND{EIRADAT.DATEX} <=" & "#" & DD2.Date & "#"
            ''cri = "{EIRADAT.DATEX} BETWEEN" & "#" & DD1 & "#" & "AND" & "#" & DD2 & "#"
            'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
            'CrystalReportViewer1.SelectionFormula = cri
            'CrystalReportViewer1.ReportSource = cr1
            DOCT = 0
        End If
    End Sub

    Private Sub Form59_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class