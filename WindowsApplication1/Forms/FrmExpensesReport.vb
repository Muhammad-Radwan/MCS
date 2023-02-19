Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmExpensesReport
    Friend nn As String
    Friend user As String
    Friend datex1 As Date
    Friend datex2 As Date
    Friend clin As String
    Friend notes As String
    Friend vv1 As String
    Friend vv2 As String
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles CrystalReportViewer1.Load
        'Dim cr1 As New CrystalReport8, cri As String
        'If L = 1 Then
        '    'cri = "{loss.lossdate}>=" & "#" & VV3 & "#" & "and {loss.lossdate}<=" & "#" & vv4 & "#"

        'ElseIf L = 2 Then
        '    'cri = "{loss.lossna}=" & "'" & vv2 & "'"
        '    cri = "{loss.lossna}=" & "'" & vv2 & "'" & "and {loss.lossdate}>=" & "#" & VV3 & "#" & "and {loss.lossdate}<=" & "#" & vv4 & "#"
        'ElseIf L = 3 Then
        '    'cri = "{loss.losstype}=" & "'" & vv1 & "'"
        '    cri = "{loss.losstype}=" & "'" & vv1 & "'" & "and {loss.lossdate}>=" & "#" & VV3 & "#" & "and {loss.lossdate}<=" & "#" & vv4 & "#"
        'ElseIf L = 4 Then
        '    cri = "{loss.losstype}=" & "'" & vv1 & "'" & "and {loss.lossna}=" & "'" & vv2 & "'" & "and {loss.lossdate}>=" & "#" & VV3 & "#" & "and {loss.lossdate}<=" & "#" & vv4 & "#"
        '    'cri = "{loss.losstype}=" & "'" & vv1 & "'" & "and {loss.lossna}=" & "'" & vv2 & "'"
        'End If
        'cri = "{loss.losstype}=" & "'" & vv1 & "'" & "and {loss.lossna}=" & "'" & vv2 & "'"
        'cri = "{loss.losstype}=" & "'" & vv1 & "'"
        'cri = "{loss.lossna}=" & "'" & vv2 & "'"
        'cri = "{loss.lossdate}>" & "'" & vv3 & "'" & "and {loss.lossna}<" & "'" & vv4 & "'"
        '*******=================================================
        'cr1.SetDatabaseLogon("admin", "13061982")
        'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "SchoolSQL")

        ''*******==================================================
        'cr1.SetParameterValue(0, Me.nn)
        'cr1.SetParameterValue(1, Me.user)
        'cr1.SetParameterValue(2, Me.datex1)
        'cr1.SetParameterValue(3, Me.datex2)
        ''cr1.SetParameterValue(2, Me.c)
        ''cr1.SetParameterValue(3, Me.d)
        ''cr1.SetParameterValue(4, Me.e)
        ''cr1.SetParameterValue(5, Me.g)
        ''cr1.SetParameterValue(6, Me.h)
        ''cr1.SetParameterValue(7, Me.j)
        ''cr1.SetParameterValue(8, Me.k)
        ''cr1.SetParameterValue(9, Me.l)
        'CrystalReportViewer1.SelectionFormula = cri
        'CrystalReportViewer1.ReportSource = cr1
    End Sub

    Private Sub lossprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If L = 1 Then
            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables
            Dim CrTable As Table
#Disable Warning BC42024 ' Unused local variable: 'TableCounter'.
            Dim TableCounter
#Enable Warning BC42024 ' Unused local variable: 'TableCounter'.
            Dim reader As New IO.StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim crReportDocument As New loss1()
            crReportDocument.Load("loss1.rpt")
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
                'CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
                'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            'Set the viewer to the report object to be previewed. 
            crReportDocument.SetParameterValue(0, Me.nn)
            crReportDocument.SetParameterValue(1, Me.user)
            crReportDocument.SetParameterValue(2, Me.datex1)
            crReportDocument.SetParameterValue(3, Me.datex2)
            crReportDocument.SetParameterValue(4, Me.CLIN)
            crReportDocument.SetParameterValue(5, Me.NOTES)
            CrystalReportViewer1.ReportSource = crReportDocument
        ElseIf L = 2 Then
            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables
            Dim CrTable As Table
#Disable Warning BC42024 ' Unused local variable: 'TableCounter'.
            Dim TableCounter
#Enable Warning BC42024 ' Unused local variable: 'TableCounter'.
            Dim reader As New IO.StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim crReportDocument As New loss2()
            crReportDocument.Load("loss2.rpt")
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
                'CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
                'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            'Set the viewer to the report object to be previewed. 
            crReportDocument.SetParameterValue(0, Me.nn)
            crReportDocument.SetParameterValue(1, Me.user)
            crReportDocument.SetParameterValue(2, Me.datex1)
            crReportDocument.SetParameterValue(3, Me.datex2)
            crReportDocument.SetParameterValue(4, Me.vv2)
            crReportDocument.SetParameterValue(5, Me.clin)
            crReportDocument.SetParameterValue(6, Me.notes)
            CrystalReportViewer1.ReportSource = crReportDocument
        ElseIf L = 3 Then
            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables
            Dim CrTable As Table
#Disable Warning BC42024 ' Unused local variable: 'TableCounter'.
            Dim TableCounter
#Enable Warning BC42024 ' Unused local variable: 'TableCounter'.
            Dim reader As New IO.StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim crReportDocument As New loss3()
            crReportDocument.Load("loss3.rpt")
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
                'CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
                'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            'Set the viewer to the report object to be previewed. 
            crReportDocument.SetParameterValue(0, Me.nn)
            crReportDocument.SetParameterValue(1, Me.user)
            crReportDocument.SetParameterValue(2, Me.datex1)
            crReportDocument.SetParameterValue(3, Me.datex2)
            crReportDocument.SetParameterValue(4, Me.vv1)
            crReportDocument.SetParameterValue(5, Me.clin)
            crReportDocument.SetParameterValue(6, Me.notes)
            CrystalReportViewer1.ReportSource = crReportDocument

        ElseIf L = 4 Then
            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables
            Dim CrTable As Table
#Disable Warning BC42024 ' Unused local variable: 'TableCounter'.
            Dim TableCounter
#Enable Warning BC42024 ' Unused local variable: 'TableCounter'.
            Dim reader As New IO.StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            Dim crReportDocument As New loss4()
            crReportDocument.Load("loss4.rpt")
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
                'CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
                'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            'Set the viewer to the report object to be previewed. 
            crReportDocument.SetParameterValue(0, Me.nn)
            crReportDocument.SetParameterValue(1, Me.user)
            crReportDocument.SetParameterValue(2, Me.datex1)
            crReportDocument.SetParameterValue(3, Me.datex2)
            crReportDocument.SetParameterValue(4, Me.vv1)
            crReportDocument.SetParameterValue(5, Me.vv2)
            crReportDocument.SetParameterValue(6, Me.clin)
            crReportDocument.SetParameterValue(7, Me.notes)
            CrystalReportViewer1.ReportSource = crReportDocument
        End If

    End Sub
End Class