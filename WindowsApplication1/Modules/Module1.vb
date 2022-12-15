Imports System
Imports System.IO
Imports System.Data.SqlClient
Imports System.Management
Imports System.Management.Instrumentation
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text
Module Module1
    'Dim s As String = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\dbsbh.mdb"
    'Public S = My.Settings.test002.ToString
    'Public s As String = "server=.\sqlexpress;initial catalog=CLINICSQL;integrated security=true;"
    'Dim S As String = "Data Source=SYSLC\sqlexpress;Initial Catalog=CLINICSQL;Integrated Security=True ; MultipleActiveResultSets = True ; Uid=sa ; Pwd=13061982 ;"
    'Dim S As String = "Driver={SQLServer};Server=SYSLC\sqlexpress; Database=CLINICSQL;Uid=sa; Pwd=13061982;"
    'Dim s As String = "Server=.\SQLExpress;AttachDbFilename=C:\MyFolder\MyDataFile.mdf;Database=dbname;Trusted_Connection=Yes;"

    'Dim S As String = "Data Source=SYSLC\sqlexpress;Initial Catalog=CLINICSQL; PERSIST Security INFO=TRUE; MultipleActiveResultSets=true; USER id=adgh; PASSWORD=13061982;;Packet Size=4096;"
    'Dim S As String = "Data Source=.\SQLExpress;Integrated Security=true;AttachDbFilename=|DataDirectory|CLINICSQL.mdf;User Instance=true; MultipleActiveResultSets=true; USER id=adgh; PASSWORD=13061982;"

    'Data Source=.\SQLExpress;Integrated Security=true;AttachDbFilename=C:\MyFolder\MyDataFile.mdf;User Instance=true;
    'Dim conStr As String = My.Settings.CLINICSQLConnectionString
    'Dim S As String = "Server=SYSLC\sqlexpress;Database=CLINICSQL; UserID=sa; Password=13061982;"
    'Public cn As New SqlClient.SqlConnection(conStr)
    Public cn As New SqlConnection

    'Public cn As New SqlClient.SqlConnection(S)
    'Function isdbfound(ByVal constr As String, ByVal dbname As String) As Boolean
    '    Dim mc As New SqlConnection(constr)
    '    Dim a As New SqlCommand("select count(name) from master.dbo.sysdatabases where name='" & dbname & "'", mc)
    '    If mc.State = ConnectionState.Closed Then
    '        mc.Open()
    '    End If
    '    If a.ExecuteScalar <= 0 Then
    '        Return False
    '    Else
    '        Return True
    '    End If
    'End Function
    'Public cn As New OleDbConnection(s)
    'Public xx1 As Integer
    Public t1, t2, t3, t4, t5, t6, t7, m_f, r, r1, r2, r3, r4, r5, t8, T9, T10, T11, T12, T13, T14, T15, ewaa, Most, confx, KHAZENAXX, Tkesem As Boolean
    Public b1, b2, vv1, vv2, VV3, VV4, MO, opx, xname, poss, log_date, log_time, user, h1, h2, h3, hh, hhh, hhhh, xxx1, txtm, xx1, nx, RTXT, procedx, KESEM_NAME As String
    Public tim, x, dateax, DD1, DD2, DATEXX, yedate, modate, motime As New Date
    Public xx10, xx2, xx3, xx4, d1, d2, ggb As New DateTimePicker
    Public num, L, FP, IDM, MENUEX, sakprint As Integer
    Public madfoox, bakyx, kemax, kematx, BAKYJK, BAKYJS, BAKYJT, BAKYJAD, BAKYJAS, BAKYJTGH, BAKYJAM, BAKYJET, BAKYJSH, gorfaad, madfoo, madfoo1, safee, lossvax, lossvax1, madfoosak, madfoob, lossvaxSAK, lossvaxB, madfoo1SAK, madfoo1B, lossvax1SAK, lossvax1B, khasemx, ejmalysolaf, ejmalysolafX, KHASMEATX, HNOX, KHASMEATX1 As Double
    Public rb1, pinm1, mem, v, vv, vvv, v2, mn, t, ut, m5, M6, M7, sano, chnox, fnumberx, esalnox, DOCT, s3r1, NOFATORAX, PRK, JH, I As Integer
    Public pinm, stat2, dt, en, doctornamex, Ejraax, namemx, jehamx, namexx, kesemx, A1, A2, A3, A4, A5, A6, A7, A8, dgxj, ALBIAN, S3R, recno, credit, DISCOUNTX, nam, jehan, gorfan, gorfat As String
    Public dgx As String
    Public KESEM As String
    Public dgxx As String
    Public tc1 As String
    Public tc2 As String
    Public tc3 As String
    Public tc4 As String
    Public tc5 As String
    Public tc6 As String
    Public tc7 As String
    Public tc8 As String
    Public tc9 As String
    Public tc10 As String
    Public tc11 As String
    Public tc12 As String
    Public tc13 As String
    Public tc14 As String
    Public tc15 As String
    Public tc16 As String
    Public tc17 As String
    Public tc18 As String
    Public tc19 As String
    Public tc20 As String
    Public tc21 As String
    Public tc22 As String
    Public tc23 As String
    Public tc24 As String
    Public tc25 As String
    Public tc26 As String
    Public tc27 As String
    Public tc28 As String
    Public tc29 As String
    Public tc30 As String
    Public tc31 As String
    Public tc32 As String
    Public tc33 As String
    Public tc34 As String
    Public tc35 As String
    Public tc36 As String
    Public tc37 As String
    Public tc38 As String
    Public tc39 As String
    Public tc40 As String
    Public tc41 As String
    Public tc42 As String
    Public tc43 As String
    Public tc44 As String
    Public tc45 As String
    Public tc46 As String
    Public tc47 As String
    Public tc48 As String
    Public tc49 As String
    Public tc50 As String
    Public tc51 As String
    Public tc52 As String
    Public tc53 As String
    Public tc54 As String
    Public tc55 As String
    Public tc56 As String
    Public tc57 As String
    Public tc58 As String
    Public tc59 As String
    Public tc60 As String
    Public tc61 As String
    Public tc62 As String
    Public tc63 As String
    Public tc64 As String
    Public tc65 As String
    Public tc66 As String
    Public tc67 As String
    Public tc68 As String
    Public tc69 As String
    Public tc70 As String
    Public tc71 As String
    Public tc72 As String
    Public tc73 As String
    Public tc74 As String
    Public tc75 As String
    Public tc76 As String
    Public tc77 As String
    Public tc78 As String
    Public tc79 As String
    Public tc80 As String
    Public tc81 As String
    Public tc82 As String
    Public tc83 As String
    Public tc84 As String
    Public tc85 As String
    Public tc86 As String
    Public tc87 As String
    Public tc88 As String
    Public tc89 As String
    Public tc90 As String
    Public tc91 As String
    Public tc92 As String
    Public tc93 As String
    Public tc94 As String
    Public tc95 As String
    Public tc96 As String
    Public tc97 As String
    Public tc98 As String
    Public tc99 As String
    Public tc100 As String
    Public tc101 As String
    Public tc102 As String
    Public bk As String
    Public B As Integer
    Public NotifyIcons As Boolean
    'Public d As Database
    'Public td As Recordset
    'Private Sub main()
    '    d = DBEngine.Workspaces(0).OpenDatabase(Application.StartupPath & "\dbsbh.mdb")
    '    Form1.Show()
    'End Sub
    Public myd As DriveInfo
    Public path As String = My.Computer.FileSystem.ReadAllText("path.txt")
    Public Function GetVolumeSerial(Optional ByVal strDriveLetter As String = "C") As String
        Dim disk As ManagementObject = New ManagementObject(String.Format("win32_logicaldisk.deviceid=""{0}:""", strDriveLetter))
        disk.Get()
        Return disk("VolumeSerialNumber").ToString()
    End Function
    Public Function GetDriveSerialNumber() As String
        Dim DriveSerial As Long
        Dim fso As Object, Drv As Object
        'Create a FileSystemObject object
        fso = CreateObject("Scripting.FileSystemObject")
        Drv = fso.GetDrive(fso.GetDriveName(AppDomain.CurrentDomain.BaseDirectory))
        With Drv
            If .IsReady Then
                DriveSerial = .SerialNumber
            Else    '"Drive Not Ready!"
                DriveSerial = -1
            End If
        End With
        'Clean up
        Drv = Nothing
        fso = Nothing
        GetDriveSerialNumber = Hex(DriveSerial)
    End Function
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber - 1)
    End Function
    Sub CONN()
        Try
            Dim reader As New StreamReader("server.txt")
            Dim allLines As List(Of String) = New List(Of String)
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
            cn.ConnectionString = "Data Source=" & ReadLine(2, allLines) & ";Initial Catalog=" & ReadLine(1, allLines) & ";Persist Security Info=True;MultipleActiveResultSets=true;User ID=ah;Password=123456"
            'cn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Public Function GetDriveSerialNumber() As String
    '    Dim HDinformation As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
    '    Dim HD As ManagementObject
    '    For Each HD In HDinformation.Get()
    '        GetDriveSerialNumber = HD("SerialNumber").ToString()
    '    Next
    'End Function

    'Function driveser(ByVal model As String) As String
    '    Dim devid As String = ""
    '    driveser = ""
    '    Try
    '        Dim searcher As New ManagementObjectSearcher( _
    '            "root\CIMV2", _
    '            "SELECT * FROM Win32_DiskDrive WHERE Model LIKE '%" + model + "%'")
    '        For Each queryObj As ManagementObject In searcher.Get()
    '            If queryObj("SerialNumber") <> "" Then driveser = queryObj("SerialNumber")
    '            Debug.Print(queryObj("Model") + ":" + driveser)
    '        Next
    '    Catch err As ManagementException
    '        Debug.Print("An error occurred while querying for WMI data: " & err.Message)
    '    End Try
    'End Function


End Module
