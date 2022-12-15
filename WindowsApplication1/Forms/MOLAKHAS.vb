Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class MOLAKHAS
    Friend datex1 As Date
    Friend datex2 As Date
    Friend nn As String
    Friend CLIN As String
    Friend NOTES As String
    Private Sub MOLAKHAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '        If sakprint = 0 Then
        '            Dim crtableLogoninfos As New TableLogOnInfos()
        '            Dim crtableLogoninfo As New TableLogOnInfo()
        '            Dim crConnectionInfo As New ConnectionInfo()
        '            Dim CrTables As Tables
        '            Dim CrTable As Table
        '#Disable Warning BC42024 ' Unused local variable: 'TableCounter'.
        '            Dim TableCounter
        '#Enable Warning BC42024 ' Unused local variable: 'TableCounter'.
        '            Dim reader As New IO.StreamReader("server.txt")
        '            Dim allLines As List(Of String) = New List(Of String)
        '            Do While Not reader.EndOfStream
        '                allLines.Add(reader.ReadLine())
        '            Loop
        '            reader.Close()
        '            'If you are using a Strongly Typed report (Imported in 
        '            'your project) named CrystalReport1.rpt use the 
        '            'following: 

        '            Dim crReportDocument As New CrystalReport13()

        '            'If you are using a Non-Typed report, and 
        '            'loading a report outside of the project, use the 
        '            'following: 

        '            'Dim crReportDocument As New ReportDocument()

        '            crReportDocument.Load("CrystalReport13.rpt")

        '            'Set the ConnectionInfo properties for logging on to 
        '            'the Database 


        '            'If you are using ODBC, this should be the DSN name NOT the physical server name. If 
        '            'you are NOT using ODBC, this should be the 
        '            'physical server name 

        '            With crConnectionInfo
        '                .ServerName = ReadLine(2, allLines)

        '                'If you are connecting to Oracle there is no 
        '                'DatabaseName. Use an empty string. 
        '                'For example, .DatabaseName = "" 

        '                .DatabaseName = ReadLine(1, allLines)
        '                .UserID = "AH"
        '                .Password = "123456"
        '            End With

        '            'This code works for both user tables and stored 
        '            'procedures. Set the CrTables to the Tables collection 
        '            'of the report 

        '            CrTables = crReportDocument.Database.Tables

        '            'Loop through each table in the report and apply the 
        '            'LogonInfo information 

        '            For Each CrTable In CrTables
        '                crtableLogoninfo = CrTable.LogOnInfo
        '                crtableLogoninfo.ConnectionInfo =
        '                crConnectionInfo
        '                CrTable.ApplyLogOnInfo(crtableLogoninfo)

        '                'If your DatabaseName is changing at runtime, specify 
        '                'the table location. 
        '                'For example, when you are reporting off of a 
        '                'Northwind database on SQL server you 
        '                'should have the following line of code: 

        '                'CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
        '                'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
        '            Next
        '            'Set the viewer to the report object to be previewed. 
        '            crReportDocument.SetParameterValue(0, Me.datex1)
        '            crReportDocument.SetParameterValue(1, Me.datex2)
        '            crReportDocument.SetParameterValue(2, Me.nn)
        '            crReportDocument.SetParameterValue(3, Me.CLIN)
        '            crReportDocument.SetParameterValue(4, Me.NOTES)
        '            CrystalReportViewer1.ReportSource = crReportDocument
        '        ElseIf sakprint = 1 Then
        '            Dim crtableLogoninfos As New TableLogOnInfos()
        '            Dim crtableLogoninfo As New TableLogOnInfo()
        '            Dim crConnectionInfo As New ConnectionInfo()
        '            Dim CrTables As Tables
        '            Dim CrTable As Table
        '#Disable Warning BC42024 ' Unused local variable: 'TableCounter'.
        '            Dim TableCounter
        '#Enable Warning BC42024 ' Unused local variable: 'TableCounter'.
        '            Dim reader As New IO.StreamReader("server.txt")
        '            Dim allLines As List(Of String) = New List(Of String)
        '            Do While Not reader.EndOfStream
        '                allLines.Add(reader.ReadLine())
        '            Loop
        '            reader.Close()
        '            'If you are using a Strongly Typed report (Imported in 
        '            'your project) named CrystalReport1.rpt use the 
        '            'following: 

        '            Dim crReportDocument As New CrystalReport14()

        '            'If you are using a Non-Typed report, and 
        '            'loading a report outside of the project, use the 
        '            'following: 

        '            'Dim crReportDocument As New ReportDocument()

        '            crReportDocument.Load("CrystalReport14.rpt")

        '            'Set the ConnectionInfo properties for logging on to 
        '            'the Database 


        '            'If you are using ODBC, this should be the DSN name NOT the physical server name. If 
        '            'you are NOT using ODBC, this should be the 
        '            'physical server name 

        '            With crConnectionInfo
        '                .ServerName = ReadLine(2, allLines)

        '                'If you are connecting to Oracle there is no 
        '                'DatabaseName. Use an empty string. 
        '                'For example, .DatabaseName = "" 

        '                .DatabaseName = ReadLine(1, allLines)
        '                .UserID = "AH"
        '                .Password = "123456"
        '            End With

        '            'This code works for both user tables and stored 
        '            'procedures. Set the CrTables to the Tables collection 
        '            'of the report 

        '            CrTables = crReportDocument.Database.Tables

        '            'Loop through each table in the report and apply the 
        '            'LogonInfo information 

        '            For Each CrTable In CrTables
        '                crtableLogoninfo = CrTable.LogOnInfo
        '                crtableLogoninfo.ConnectionInfo =
        '                crConnectionInfo
        '                CrTable.ApplyLogOnInfo(crtableLogoninfo)

        '                'If your DatabaseName is changing .at runtime, specify 
        '                'the table location. 
        '                'For example, when you are reporting off of a 
        '                'Northwind database on SQL server you 
        '                'should have the following line of code: 

        '                'CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
        '                'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
        '            Next
        '            'Set the viewer to the report object to be previewed. 
        '            crReportDocument.SetParameterValue(0, Me.datex1)
        '            crReportDocument.SetParameterValue(1, Me.datex2)
        '            crReportDocument.SetParameterValue(2, Me.nn)
        '            crReportDocument.SetParameterValue(3, Me.CLIN)
        '            crReportDocument.SetParameterValue(4, Me.NOTES)
        '            CrystalReportViewer1.ReportSource = crReportDocument
        '        ElseIf sakprint = 2 Then
        '            Dim crtableLogoninfos As New TableLogOnInfos()
        '            Dim crtableLogoninfo As New TableLogOnInfo()
        '            Dim crConnectionInfo As New ConnectionInfo()
        '            Dim CrTables As Tables
        '            Dim CrTable As Table
        '#Disable Warning BC42024 ' Unused local variable: 'TableCounter'.
        '            Dim TableCounter
        '#Enable Warning BC42024 ' Unused local variable: 'TableCounter'.
        '            Dim reader As New IO.StreamReader("server.txt")
        '            Dim allLines As List(Of String) = New List(Of String)
        '            Do While Not reader.EndOfStream
        '                allLines.Add(reader.ReadLine())
        '            Loop
        '            reader.Close()
        '            'If you are using a Strongly Typed report (Imported in 
        '            'your project) named CrystalReport1.rpt use the 
        '            'following: 

        '            Dim crReportDocument As New CrystalReport15()

        '            'If you are using a Non-Typed report, and 
        '            'loading a report outside of the project, use the 
        '            'following: 

        '            'Dim crReportDocument As New ReportDocument()

        '            crReportDocument.Load("CrystalReport15.rpt")

        '            'Set the ConnectionInfo properties for logging on to 
        '            'the Database 


        '            'If you are using ODBC, this should be the DSN name NOT the physical server name. If 
        '            'you are NOT using ODBC, this should be the 
        '            'physical server name 

        '            With crConnectionInfo
        '                .ServerName = ReadLine(2, allLines)

        '                'If you are connecting to Oracle there is no 
        '                'DatabaseName. Use an empty string. 
        '                'For example, .DatabaseName = "" 

        '                .DatabaseName = ReadLine(1, allLines)
        '                .UserID = "AH"
        '                .Password = "123456"
        '            End With

        '            'This code works for both user tables and stored 
        '            'procedures. Set the CrTables to the Tables collection 
        '            'of the report 

        '            CrTables = crReportDocument.Database.Tables

        '            'Loop through each table in the report and apply the 
        '            'LogonInfo information 

        '            For Each CrTable In CrTables
        '                crtableLogoninfo = CrTable.LogOnInfo
        '                crtableLogoninfo.ConnectionInfo =
        '                crConnectionInfo
        '                CrTable.ApplyLogOnInfo(crtableLogoninfo)

        '                'If your DatabaseName is changing at runtime, specify 
        '                'the table location. 
        '                'For example, when you are reporting off of a 
        '                'Northwind database on SQL server you 
        '                'should have the following line of code: 

        '                'CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
        '                'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
        '            Next
        '            'Set the viewer to the report object to be previewed. 
        '            crReportDocument.SetParameterValue(0, Me.datex1)
        '            crReportDocument.SetParameterValue(1, Me.datex2)
        '            crReportDocument.SetParameterValue(2, Me.nn)
        '            crReportDocument.SetParameterValue(3, Me.CLIN)
        '            crReportDocument.SetParameterValue(4, Me.NOTES)
        '            CrystalReportViewer1.ReportSource = crReportDocument
        '        ElseIf sakprint = 3 Then
        '            Dim crtableLogoninfos As New TableLogOnInfos()
        '            Dim crtableLogoninfo As New TableLogOnInfo()
        '            Dim crConnectionInfo As New ConnectionInfo()
        '            Dim CrTables As Tables
        '            Dim CrTable As Table
        '#Disable Warning BC42024 ' Unused local variable: 'TableCounter'.
        '            Dim TableCounter
        '#Enable Warning BC42024 ' Unused local variable: 'TableCounter'.
        '            Dim reader As New IO.StreamReader("server.txt")
        '            Dim allLines As List(Of String) = New List(Of String)
        '            Do While Not reader.EndOfStream
        '                allLines.Add(reader.ReadLine())
        '            Loop
        '            reader.Close()
        '            'If you are using a Strongly Typed report (Imported in 
        '            'your project) named CrystalReport1.rpt use the 
        '            'following: 

        '            Dim crReportDocument As New CrystalReport24()

        '            'If you are using a Non-Typed report, and 
        '            'loading a report outside of the project, use the 
        '            'following: 

        '            'Dim crReportDocument As New ReportDocument()

        '            crReportDocument.Load("CrystalReport24.rpt")

        '            'Set the ConnectionInfo properties for logging on to 
        '            'the Database 


        '            'If you are using ODBC, this should be the DSN name NOT the physical server name. If 
        '            'you are NOT using ODBC, this should be the 
        '            'physical server name 

        '            With crConnectionInfo
        '                .ServerName = ReadLine(2, allLines)

        '                'If you are connecting to Oracle there is no 
        '                'DatabaseName. Use an empty string. 
        '                'For example, .DatabaseName = "" 

        '                .DatabaseName = ReadLine(1, allLines)
        '                .UserID = "AH"
        '                .Password = "123456"
        '            End With

        '            'This code works for both user tables and stored 
        '            'procedures. Set the CrTables to the Tables collection 
        '            'of the report 

        '            CrTables = crReportDocument.Database.Tables

        '            'Loop through each table in the report and apply the 
        '            'LogonInfo information 

        '            For Each CrTable In CrTables
        '                crtableLogoninfo = CrTable.LogOnInfo
        '                crtableLogoninfo.ConnectionInfo =
        '                crConnectionInfo
        '                CrTable.ApplyLogOnInfo(crtableLogoninfo)

        '                'If your DatabaseName is changing .at runtime, specify 
        '                'the table location. 
        '                'For example, when you are reporting off of a 
        '                'Northwind database on SQL server you 
        '                'should have the following line of code: 

        '                'CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
        '                'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
        '            Next
        '            'Set the viewer to the report object to be previewed. 
        '            crReportDocument.SetParameterValue(0, Me.datex1)
        '            crReportDocument.SetParameterValue(1, Me.datex2)
        '            crReportDocument.SetParameterValue(2, Me.nn)
        '            crReportDocument.SetParameterValue(3, Me.CLIN)
        '            crReportDocument.SetParameterValue(4, Me.NOTES)
        '            CrystalReportViewer1.ReportSource = crReportDocument
        'ElseIf sakprint = 4 Then
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
            'If you are using a Strongly Typed report (Imported in 
            'your project) named CrystalReport1.rpt use the 
            'following: 

            Dim crReportDocument As New kholasareport()

            'If you are using a Non-Typed report, and 
            'loading a report outside of the project, use the 
            'following: 

            'Dim crReportDocument As New ReportDocument()

            crReportDocument.Load("kholasareport.rpt")

            'Set the ConnectionInfo properties for logging on to 
            'the Database 


            'If you are using ODBC, this should be the DSN name NOT the physical server name. If 
            'you are NOT using ODBC, this should be the 
            'physical server name 

            With crConnectionInfo
                .ServerName = ReadLine(2, allLines)

                'If you are connecting to Oracle there is no 
                'DatabaseName. Use an empty string. 
                'For example, .DatabaseName = "" 

                .DatabaseName = ReadLine(1, allLines)
                .UserID = "AH"
                .Password = "123456"
            End With

            'This code works for both user tables and stored 
            'procedures. Set the CrTables to the Tables collection 
            'of the report 

            CrTables = crReportDocument.Database.Tables

            'Loop through each table in the report and apply the 
            'LogonInfo information 

            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo =
                crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)

                'If your DatabaseName is changing .at runtime, specify 
                'the table location. 
                'For example, when you are reporting off of a 
                'Northwind database on SQL server you 
                'should have the following line of code: 

                'CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
                'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
            Next
            'Set the viewer to the report object to be previewed. 
            crReportDocument.SetParameterValue(0, Me.CLIN)
            crReportDocument.SetParameterValue(1, Me.nn)
            crReportDocument.SetParameterValue(2, Me.NOTES)
            crReportDocument.SetParameterValue(3, Me.datex1)
            crReportDocument.SetParameterValue(4, Me.datex2)
            CrystalReportViewer1.ReportSource = crReportDocument

        ''End If
    End Sub


    'Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
    '    If sakprint = 0 Then
    '        Dim cr1 As New CrystalReport13, cri As String
    '        Dim t11 As CrystalDecisions.CrystalReports.Engine.Tables
    '        Dim t21 As CrystalDecisions.CrystalReports.Engine.Table
    '        t11 = cr1.Database.Tables
    '        cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "SchoolSQL")
    '        cr1.SetParameterValue(0, Me.datex1)
    '        cr1.SetParameterValue(1, Me.datex2)
    '        cr1.SetParameterValue(2, Me.nn)
    '        CrystalReportViewer1.SelectionFormula = cri
    '        CrystalReportViewer1.ReportSource = cr1
    '    ElseIf sakprint = 1 Then
    '        Dim cr1 As New CrystalReport14, cri As String
    '        Dim t11 As CrystalDecisions.CrystalReports.Engine.Tables
    '        Dim t21 As CrystalDecisions.CrystalReports.Engine.Table
    '        t11 = cr1.Database.Tables
    '        cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "SchoolSQL")
    '        cr1.SetParameterValue(0, Me.datex1)
    '        cr1.SetParameterValue(1, Me.datex2)
    '        cr1.SetParameterValue(2, Me.nn)
    '        CrystalReportViewer1.SelectionFormula = cri
    '        CrystalReportViewer1.ReportSource = cr1
    '    ElseIf sakprint = 2 Then
    '        Dim cr1 As New CrystalReport15, cri As String
    '        Dim t11 As CrystalDecisions.CrystalReports.Engine.Tables
    '        Dim t21 As CrystalDecisions.CrystalReports.Engine.Table
    '        t11 = cr1.Database.Tables
    '        cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "SchoolSQL")
    '        cr1.SetParameterValue(0, Me.datex1)
    '        cr1.SetParameterValue(1, Me.datex2)
    '        cr1.SetParameterValue(2, Me.nn)
    '        CrystalReportViewer1.SelectionFormula = cri
    '        CrystalReportViewer1.ReportSource = cr1
    '    End If

    '    'cri = "{t1.pname}=  " '" & combobox1.text & "'" 
    '    'cri = "{hala_esh.mono}=" & "" & CInt(vv1) & ""
    '    'cri = "{main.mono}=" & "'" & vv1 & "'"
    '    ' cri = "{hala_esh1.mono}=" & "" & vv2 & ""
    '    '*******=================================================

    '    'For Each t21 In t11
    '    '    t21.Location = serv & "\DBN.mdb"
    '    '    't21.Location = Application.StartupPath & "\DBN.mdb"
    '    'Next.     


    '    '*******==================================================

    'End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class