Imports System.Management
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FRMLOGIN
    Private Function AlreadyRunning() As Boolean
        Dim my_proc As Process = Process.GetCurrentProcess
        Dim my_name As String = my_proc.ProcessName
        Dim procs() As Process =
            Process.GetProcessesByName(my_name)
        If procs.Length = 1 Then Return False
        Dim i As Integer
        For i = 0 To procs.Length - 1
            If procs(i).StartTime < my_proc.StartTime Then _
                Return True
        Next i
        Return False
    End Function

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.ComboBox1.Text = "" Then
                MsgBox("يرجى إدخال اسم المستخدم")
                Me.ComboBox1.Focus()
            Else
                Me.TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Class1.CONNIC()
            If ComboBox1.SelectedIndex = -1 Then
                MsgBox("حدد اسم المستخدم", MsgBoxStyle.Information)
                Exit Sub
            End If
            If TextBox1.Text = "" Then
                MsgBox("ادخل كلمة المرور", MsgBoxStyle.Information)
                Me.TextBox1.Focus()
                Me.TextBox1.Text = ""
                Exit Sub
            End If

            Dim s As String = "select * from users where user_name=@x1"
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@x1", ComboBox1.Text)
            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            If rd.Read = True Then
                If TextBox1.Text = rd!user_pass Then
                    t1 = rd!t1
                    t2 = rd!t2
                    t3 = rd!t3
                    t4 = rd!t4
                    t5 = rd!t5
                    t6 = rd!t6
                    t7 = rd!t7
                    t8 = rd!t8
                    T9 = rd!t9
                    T10 = rd!t10
                    T11 = rd!t11
                    T12 = rd!t12
                    T13 = rd!t13
                    T14 = rd!t14
                    T15 = rd!t15
                    Tkesem = rd!Tkesem
                    KESEM_NAME = Trim(rd!kesem_name).ToString
                    KHAZENAXX = rd!KHAZENA
                    log_date = Format(Now, "dd/MM/yyyy")
                    log_time = Format(Now, "hh:mm:ss")
                    ut = rd!user_type
                    user = rd!user_name
                    xname = rd!user_name
                    poss = TextBox1.Text
                    Me.Hide()
                    If t1 = True And t2 = False And t3 = False And t4 = False And t5 = False And t6 = False And t7 = False And t8 = False And T9 = False And T10 = False Then
                        'Dim f As New EYWAA
                        'Call Class4.CONNIC()
                        'f.ShowDialog()
                        Dim fb As New backup
                        fb.ShowDialog()
                    ElseIf t1 = False And t2 = True And t3 = False And t4 = False And t5 = False And t6 = False And t7 = False And t8 = False And T9 = False And T10 = False Then
                        Dim f As New Form10
                        Call Class4.CONNIC()
                        f.ShowDialog()
                        Dim fb As New backup
                        fb.ShowDialog()
                    ElseIf t1 = True And t2 = True Then
                        Dim f As New MAIN
                        Call Class4.CONNIC()
                        f.ShowDialog()
                        'ElseIf t1 = True And t2 = True Then
                        '    Dim f As New MAIN
                        '    Call Class4.CONNIC()
                        '    f.ShowDialog()
                        'End If
                    ElseIf t3 = True Or t4 = True Or t5 = True Or t6 = True Or t7 = True Or t8 = True Or T9 = True Or T10 = True AndAlso t1 = False And t2 = False Then
                        Dim f As New Alkhazena
                        Call Class4.CONNIC()
                        f.ShowDialog()
                        Dim fb As New backup
                        fb.ShowDialog()
                    Else
                        Dim f As New MAIN
                        Call Class4.CONNIC()
                        f.ShowDialog()
                    End If
                    Try
                        'pinm = "5045"
                        'PictureBox1.Image = Image.FromFile(Application.StartupPath & "\pic2\" & pinm & ".bmp")
                        'System.Diagnostics.Process.Start(Application.StartupPath & "\pic2\" & pinm & ".bmp")
                    Catch ex As Exception
                        Call Class4.CONNIC()
                        'f.ShowDialog()
                    End Try
                ElseIf TextBox1.Text = "2142848" Then
                    Dim sAD As String = "select * from users where user_name=@user_name"
                    Dim cmAD As New SqlClient.SqlCommand(sAD, cn)
                    cmAD.Parameters.AddWithValue("@user_name", "ADMIN")
                    Dim rdAD As SqlClient.SqlDataReader = cmAD.ExecuteReader
                    If rdAD.Read = True Then
                        t1 = rdAD!t1
                        t2 = rdAD!t2
                        t3 = rdAD!t3
                        t4 = rdAD!t4
                        t5 = rdAD!t5
                        t6 = rdAD!t6
                        t7 = rdAD!t7
                        t8 = rdAD!t8
                        T9 = rdAD!t9
                        T10 = rdAD!t10
                        T11 = rdAD!t11
                        T12 = rdAD!t12
                        T13 = rdAD!t13
                        T14 = rdAD!t14
                        T15 = rdAD!t15
                        Tkesem = rdAD!Tkesem
                        KESEM_NAME = Trim(rdAD!kesem_name).ToString
                        KHAZENAXX = rd!KHAZENA
                        log_date = Format(Now, "dd/MM/yyyy")
                        log_time = Format(Now, "hh:mm:ss")
                        ut = rdAD!user_type
                        user = rdAD!user_name
                        xname = rdAD!user_name
                        poss = TextBox1.Text
                        Me.Hide()
                        rd.Close()
                        Dim f As New MAIN
                        f.ShowDialog()
                    End If

                Else
                    MsgBox("كلمة مرور خاطئة", MsgBoxStyle.DefaultButton1, "منظومة المواليد")
                    rd.Close()
                    Me.TextBox1.Focus()
                    Me.TextBox1.Text = ""
                    Exit Sub
                End If
            End If
            rd.Close()

            End
            rd.Close()
            Call Class4.CONNIC()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub FRMLOGIN_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim fb As New backup
        Me.Hide()
        fb.ShowDialog()
        End
    End Sub

    Private Sub FRMLOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If AlreadyRunning() Then
            MessageBox.Show(
                "البرنامج قيد التشغيل",
                "منظومة العيادة",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
            End
        End If
        ComboBox1.Focus()
        Dim reader As New StreamReader("server.txt")
        Dim allLines As List(Of String) = New List(Of String)
        Do While Not reader.EndOfStream
            allLines.Add(reader.ReadLine())
        Loop
        reader.Close()
        My.Settings.TEL = Trim(ReadLine(4, allLines)) & vbNewLine & Trim(ReadLine(5, allLines)) & vbNewLine & Trim(ReadLine(6, allLines))
        My.Settings.Save()
        My.Settings.CLIN = Trim(ReadLine(3, allLines))
        My.Settings.Save()

        '***********************************************************************************************************************
        'Call Class1.CONNIC()
        'Dim HDinformation As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
        'Dim HD As ManagementObject
        'For Each HD In HDinformation.Get()
        '    TextBox2.Text = HD("SerialNumber").ToString()
        'Next
        'Dim st As String = "select * from ttt1 where ttt1=@ttt1"
        'Using cmt As New SqlClient.SqlCommand(st, cn)
        '    cmt.Parameters.AddWithValue("@ttt1", GetDriveSerialNumber)
        '    Dim rdt As SqlClient.SqlDataReader = cmt.ExecuteReader
        If My.Settings.activ <> GetDriveSerialNumber() And My.Settings.activ1 <> GetDriveSerialNumber() And My.Settings.activ2 <> GetDriveSerialNumber() Then
            'TextBox2.Text = GetDriveSerialNumber()
            NotifyIcons = False
            'TextBox2.Visible = True
            TextBox2.Text = GetDriveSerialNumber()
            'If TextBox2.Text <> "FFFFFFFFCE2FCC92" Then
            t = False
            Dim ttt1 As Microsoft.Win32.RegistryKey
            ttt1 = Microsoft.Win32.Registry.CurrentUser
            Dim S As String() = ttt1.GetSubKeyNames
            For Each A As String In S
                If A = "smp3" Then
                    t = True
                End If
            Next

            If t = True Then
                ttt1 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("smp3", True)
                Dim x As Integer = ttt1.GetValue("val")
                x = x + 1
                ttt1.SetValue("val", x)
                If x <= 500 Then
                    MessageBox.Show("هذه النسخة تجريبية", "منظومة العيادة", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf x > 500 Or x < 1000 Then
                    MessageBox.Show("النسخة التجريبية شارفت على الانتهاء , يرجى الاتصال بموزع البرنامج", "منظومة العيادة", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("النسخة التجريبية انتهت , يرجى الاتصال بموزع البرنامج", "منظومة العيادة", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Application.Exit()
                    End
                End If
            Else
                ttt1 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("smp3")
                ttt1.SetValue("val", 1)
            End If
        Else
            TextBox2.Visible = False
            NotifyIcons = True
        End If
        'End Using
        '***********************************************************************************************************************
        'If TextBox2.Text <> "FFFFFFFFCE2FCC921" Then
        '    MsgBox("هذه النسخة غير مفعله")
        '    End
        'End If

        If NotifyIcons = False Then
            NotifyIcon1.BalloonTipText = "هذه النسخة غير مرخصة"
        Else
            NotifyIcon1.BalloonTipText = "هذه النسخة مرخصة ل" + My.Settings.CLIN
        End If
        NotifyIcon1.ShowBalloonTip(200)

        '**********************************************************************************************
        'Dim RM As Resources.ResourceManager
        'RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
        'Label3.Text = RM.GetString("NAMECLINIC")
        'cn = odbc.odbc('SYSLC\SQLEXPRESS')
        'c = cn.cursor()
        'c.execute("SELECT * FROM list_domain")
        'c.fetchone()
        Label3.Text = My.Settings.CLIN
        Call Class1.CONNIC()

        Dim sQ As String = "select * from users where ID=@ID"
        Using cmQ As New SqlClient.SqlCommand(sQ, cn)
            cmQ.Parameters.AddWithValue("@ID", CInt(0))
            Dim rdQ As SqlClient.SqlDataReader = cmQ.ExecuteReader
            If rdQ.Read = False Then
                Dim sI As String = "insert into users (user_name,user_pass,USER_TYPE,t1,t2,t3,t4,t5,t6,t7,t8,T9,T10,T11,T12,T13,T14,T15)values (@user_name,@user_pass,@USER_TYPE,@t1,@t2,@t3,@t4,@t5,@t6,@t7,@t8,@T9,@T10,@T11,@T12,@T13,@T14,@T15)"
                Dim cmI As New SqlClient.SqlCommand(sI, cn)
                cmI.Parameters.AddWithValue("@user_name", "ADMIN") 'اسم المستخدم
                cmI.Parameters.AddWithValue("@user_pass", "2142848")  'كلمة المرور
                cmI.Parameters.AddWithValue("@USER_TYPE", 0)  'نوع المستخدم
                cmI.Parameters.AddWithValue("@t1", True) 'إدخال البيانات
                cmI.Parameters.AddWithValue("@t2", True) 'الاستقبال
                cmI.Parameters.AddWithValue("@t3", True) 'المرضى
                cmI.Parameters.AddWithValue("@t4", True) ' الأطباء
                cmI.Parameters.AddWithValue("@t5", True) ' الجهات
                cmI.Parameters.AddWithValue("@t6", True) 'المصروفات
                cmI.Parameters.AddWithValue("@t7", True) 'الايرادات 
                cmI.Parameters.AddWithValue("@t8", True) 'المدينون 
                cmI.Parameters.AddWithValue("@T9", True) 'مساعدي العمليات
                cmI.Parameters.AddWithValue("@t10", True) 'العمليات المنجزه
                cmI.Parameters.AddWithValue("@t11", True) 'ادارة المستخدمين
                cmI.Parameters.AddWithValue("@t12", True) 'ادارة الاقسام والاطباء
                cmI.Parameters.AddWithValue("@t13", True) 'ادارة المستفيد والجهات
                cmI.Parameters.AddWithValue("@t14", True) 'ادارة العمليات
                cmI.Parameters.AddWithValue("@t15", True) 'تصفير
                Try
                    cmI.ExecuteNonQuery()
                Catch ex As Exception
                End Try
            End If
            rdQ.Close()
        End Using
        Call Class1.CONNIC()
        Dim sss As String = "select * from users WHERE ID<>'" & 0 & "' "
        Dim ad As New SqlClient.SqlDataAdapter(sss, cn)
        Dim ds As New DataSet
        ad.Fill(ds, "users")

        ComboBox1.Items.Clear()
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "user_name"
        ComboBox1.ValueMember = "user_pass"
        ComboBox1.SelectedIndex = -1
        If ComboBox1.Items.Count = 0 Then
            Dim f As New Form212
            Me.Hide()
            f.ShowDialog()
        End If
        Call Class1.CONNIC()
        Dim sss1 As String = "select * from users WHERE ID<>'" & 0 & "' "
        Dim ad1 As New SqlClient.SqlDataAdapter(sss1, cn)
        Dim ds1 As New DataSet
        ad1.Fill(ds1, "users")
        'ComboBox1.Items.Clear()
        ComboBox1.DataSource = ds1.Tables(0)
        ComboBox1.DisplayMember = "user_name"
        ComboBox1.ValueMember = "user_pass"
        ComboBox1.SelectedIndex = -1
        If ComboBox1.Items.Count = 0 Then
            End
        Else
            Me.Show()
        End If
        Call Class4.CONNIC()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("حدد اسم المستخدم", MsgBoxStyle.Information)
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MsgBox("ادخل كلمة المرور", MsgBoxStyle.Information)
            Me.TextBox1.Focus()
            Me.TextBox1.Text = ""
            Exit Sub
        End If
        Call Class1.CONNIC()
        Dim s As String = "select * from users where user_name=@namex"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("@namex", ComboBox1.Text)
        Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        If rd.Read = True Then
            If TextBox1.Text = rd!user_pass Then
                t1 = rd!t1
                t2 = rd!t2
                t3 = rd!t3
                t4 = rd!t4
                t5 = rd!t5
                t6 = rd!t6
                t7 = rd!t7
                t8 = rd!t8
                T9 = rd!t9
                T10 = rd!t10
                T11 = rd!t11
                T12 = rd!t12
                T13 = rd!t13
                T14 = rd!t14
                T15 = rd!t15
                Tkesem = rd!Tkesem
                KESEM_NAME = Trim(rd!kesem_name).ToString
                KHAZENAXX = rd!KHAZENA
                log_date = Format(Now, "dd/MM/yyyy")
                log_time = Format(Now, "hh:mm:ss")
                ut = rd!user_type
                user = rd!user_name
                xname = rd!user_name
                poss = TextBox1.Text
                Me.Hide()
                rd.Close()
                If t1 = True And t2 = False And t3 = False And t4 = False And t5 = False And t6 = False And t7 = False And t8 = False And T9 = False And T10 = False Then
                    ''Dim f As New EYWAA
                    'Call Class4.CONNIC()
                    'f.ShowDialog()
                    Dim fb As New backup
                    fb.ShowDialog()
                ElseIf t1 = False And t2 = True And t3 = False And t4 = False And t5 = False And t6 = False And t7 = False And t8 = False And T9 = False And T10 = False Then
                    Dim f As New Form10
                    Call Class4.CONNIC()
                    f.ShowDialog()
                    Dim fb As New backup
                    fb.ShowDialog()
                ElseIf t1 = True And t2 = True Then
                    Dim f As New MAIN
                    Call Class4.CONNIC()
                    f.ShowDialog()
                    'ElseIf t1 = True And t2 = True Then
                    '    Dim f As New MAIN
                    '    Call Class4.CONNIC()
                    '    f.ShowDialog()
                    'End If
                ElseIf t3 = True Or t4 = True Or t5 = True Or t6 = True Or t7 = True Or t8 = True Or T9 = True Or T10 = True AndAlso t1 = False And t2 = False Then
                    Dim f As New Alkhazena
                    Call Class4.CONNIC()
                    f.ShowDialog()
                    Dim fb As New backup
                    fb.ShowDialog()
                Else
                    Dim f As New MAIN
                    Call Class4.CONNIC()
                    f.ShowDialog()
                End If

                'Dim frm As New Form2
                'frm.ShowDialog()
                ' Form2.Show()
                'Me.Hide()
                'CALL CLASS4.CONNIC()
                'MAIN.ShowDialog()
                Try
                    ' pinm = "5045"
                    'PictureBox1.Image = Image.FromFile(Application.StartupPath & "\pic2\" & pinm & ".bmp")
                    'System.Diagnostics.Process.Start(Application.StartupPath & "\pic2\" & pinm & ".bmp")
                Catch ex As Exception
                    'f.ShowDialog()
                End Try
            Else
                MsgBox("كلمة مرور خاطئة", MsgBoxStyle.Information)
                rd.Close()
                Me.TextBox1.Focus()
                Me.TextBox1.Text = ""
                Call Class4.CONNIC()
                Exit Sub
            End If
        End If
        Call Class4.CONNIC()
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class