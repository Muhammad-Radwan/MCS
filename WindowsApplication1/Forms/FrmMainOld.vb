Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class FrmMainOld

    Private Sub MDIParent1_FontChanged(sender As Object, e As EventArgs) Handles Me.FontChanged

    End Sub

    Private Sub MDIParent1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'Dim cmd As New SqlCommand
        'cmd.CommandType = CommandType.Text
        ''cmd.CommandText = "BACKUP DATABASE C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\clinicsql TO DISK='d:\clinicsql.BAK'"
        'cmd.CommandText = "BACKUP DATABASE clinicsql TO DISK='e:\" & Date.Today.Day & Date.Today.Month & Date.Today.Year & "\CLINICSQL.bak' WITH FORMAT, MEDIANAME = 'SQLServerBackups', NAME = 'Full Backup of clinicsql';"
        'cmd.Connection = cn
        'cmd.ExecuteNonQuery()
    End Sub

    Private Sub MDIParent1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim f As New FrmBackup
        Me.Hide()
        FRMLOGIN.Close()
        f.ShowDialog()
        End
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CLINICSQLhDataSet.APPOINTMENTVIEW' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTVIEWTableAdapter.Fill(Me.CLINICSQLhDataSet.APPOINTMENTVIEW)
        If My.Settings.CLIN = "النسخة تجريبية" Then
            NotifyIcon1.BalloonTipText = "هذه " + My.Settings.CLIN
        Else
            NotifyIcon1.BalloonTipText = "هذه النسخة مرخصة ل" + My.Settings.CLIN
        End If
        NotifyIcon1.ShowBalloonTip(200)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.APPOINTMENTVIEW3' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTVIEW3TableAdapter.Fill(Me.DbsbhDataSet8.APPOINTMENTVIEW3)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.APPOINTMENTVIEW2' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTVIEW2TableAdapter.Fill(Me.DbsbhDataSet8.APPOINTMENTVIEW2)
        Call Class1.CONNIC()
        Me.Text = My.Settings.CLIN
        'Dim RM As Resources.ResourceManager
        'RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
        'Me.Text = RM.GetString("NAMECLINIC")
        Dim sk1h As String
        sk1h = "select * from Ejraa"
        Dim adk1h As New SqlClient.SqlDataAdapter(sk1h, cn)
        Dim dsk1h As New DataSet
        adk1h.Fill(dsk1h, "Ejraa")
        ComboBox2.DataSource = dsk1h.Tables(0)
        ComboBox2.DisplayMember = "Ejraa"
        ComboBox2.SelectedIndex = -1

        Dim skdh As String
        skdh = "select * from dn"
        Dim adkdh As New SqlClient.SqlDataAdapter(skdh, cn)
        Dim dskdh As New DataSet
        adkdh.Fill(dskdh, "dn")
        ComboBox5.DataSource = dskdh.Tables(0)
        ComboBox5.DisplayMember = "dn"
        ComboBox5.SelectedIndex = -1

        Dim skkh As String
        skkh = "select * from kesem"
        Dim adkkh As New SqlClient.SqlDataAdapter(skkh, cn)
        Dim dskkh As New DataSet
        adkkh.Fill(dskkh, "kesem")
        ComboBox4.DataSource = dskkh.Tables(0)
        ComboBox4.DisplayMember = "kesem"
        ComboBox4.SelectedIndex = -1
        Dim skkhO As String
        skkhO = "select * from MOSTAFEED"
        Dim adkkhO As New SqlClient.SqlDataAdapter(skkhO, cn)
        Dim dskkhO As New DataSet
        adkkhO.Fill(dskkhO, "MOSTAFEED")
        ComboBox1.DataSource = dskkhO.Tables(0)
        ComboBox1.DisplayMember = "NAMEM"
        ComboBox1.SelectedIndex = -1
        If ComboBox2.Items.Count = 0 Or ComboBox4.Items.Count = 0 Then
            Dim ss2 As String = "insert into KESEM(KESEM)VALUES(@KESEM)"
            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
            cmm2.Parameters.AddWithValue("@KESEM", "تحاليل")
            Try
                cmm2.ExecuteNonQuery()
                Dim ss2E As String = "insert into EJRAA(EJRAA,IDK)VALUES(@EJRAA,@IDK)"
                '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
                Dim cmm2E As New SqlClient.SqlCommand(ss2E, cn)
                cmm2E.Parameters.AddWithValue("@EJRAA", "تحاليل")
                cmm2E.Parameters.AddWithValue("@IDK", CInt(0))
                Try
                    cmm2E.ExecuteNonQuery()
                    Dim ss2ES As String = "insert into DN(DN,IDK)VALUES(@DN,@IDK)"
                    '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
                    Dim cmm2ES As New SqlClient.SqlCommand(ss2ES, cn)
                    cmm2ES.Parameters.AddWithValue("@DN", "معمل التحاليل")
                    cmm2ES.Parameters.AddWithValue("@IDK", CInt(0))
                    Try
                        cmm2ES.ExecuteNonQuery()
                        Dim ss2EN As String = "insert into DNKEMA(IDD,EJRAA)VALUES(@IDD,@EJRAA)"
                        '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
                        Dim cmm2EN As New SqlClient.SqlCommand(ss2EN, cn)
                        cmm2EN.Parameters.AddWithValue("@IDD", CInt(0))
                        cmm2EN.Parameters.AddWithValue("@EJRAA", CInt(0))
                        Try
                            cmm2EN.ExecuteNonQuery()
                        Catch ex As Exception
                        End Try
                    Catch ex As Exception
                    End Try
                Catch ex As Exception
                End Try
            Catch ex As Exception
            End Try
            Dim ss2S As String = "insert into KESEM(KESEM)VALUES(@KESEM)"
            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            Dim cmm2S As New SqlClient.SqlCommand(ss2S, cn)
            cmm2S.Parameters.AddWithValue("@KESEM", "عمليات")
            Try
                cmm2S.ExecuteNonQuery()
                Dim ss2E As String = "insert into EJRAA(EJRAA,IDK)VALUES(@EJRAA,@IDK)"
                '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
                Dim cmm2E As New SqlClient.SqlCommand(ss2E, cn)
                cmm2E.Parameters.AddWithValue("@EJRAA", "عمليات")
                cmm2E.Parameters.AddWithValue("@IDK", CInt(1))
                Try
                    cmm2E.ExecuteNonQuery()
                Catch ex As Exception
                End Try
            Catch ex As Exception
            End Try

            Dim ss2a As String = "insert into KESEM(KESEM)VALUES(@KESEM)"
            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            Dim cmm2a As New SqlClient.SqlCommand(ss2a, cn)
            cmm2a.Parameters.AddWithValue("@KESEM", "ادويه")
            Try
                cmm2a.ExecuteNonQuery()
                Dim ss2Ea As String = "insert into EJRAA(EJRAA,IDK)VALUES(@EJRAA,@IDK)"
                '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
                Dim cmm2Ea As New SqlClient.SqlCommand(ss2Ea, cn)
                cmm2Ea.Parameters.AddWithValue("@EJRAA", "ادويه")
                cmm2Ea.Parameters.AddWithValue("@IDK", CInt(2))
                Try
                    cmm2Ea.ExecuteNonQuery()
                    Dim ss2ESa As String = "insert into DN(DN,IDK)VALUES(@DN,@IDK)"
                    '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
                    Dim cmm2ESa As New SqlClient.SqlCommand(ss2ESa, cn)
                    cmm2ESa.Parameters.AddWithValue("@DN", "الصيديه")
                    cmm2ESa.Parameters.AddWithValue("@IDK", CInt(2))
                    Try
                        cmm2ESa.ExecuteNonQuery()
                        Dim ss2ENa As String = "insert into DNKEMA(IDD,EJRAA)VALUES(@IDD,@EJRAA)"
                        '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
                        Dim cmm2ENa As New SqlClient.SqlCommand(ss2ENa, cn)
                        cmm2ENa.Parameters.AddWithValue("@IDD", CInt(1))
                        cmm2ENa.Parameters.AddWithValue("@EJRAA", CInt(2))
                        Try
                            cmm2ENa.ExecuteNonQuery()
                        Catch ex As Exception
                        End Try
                    Catch ex As Exception
                    End Try
                Catch ex As Exception
                End Try
            Catch ex As Exception
            End Try
            'Dim ss2aK As String = "insert into KESEM(KESEM)VALUES(@KESEM)"
            ''    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            'Dim cmm2aK As New SqlClient.SqlCommand(ss2aK, cn)
            'cmm2aK.Parameters.AddWithValue("@KESEM", "تغذيه")
            'Try
            '    cmm2aK.ExecuteNonQuery()
            '    Dim ss2Ea As String = "insert into EJRAA(EJRAA,IDK)VALUES(@EJRAA,@IDK)"
            '    '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            '    Dim cmm2Ea As New SqlClient.SqlCommand(ss2Ea, cn)
            '    cmm2Ea.Parameters.AddWithValue("@EJRAA", "تغذيه")
            '    cmm2Ea.Parameters.AddWithValue("@IDK", CInt(2))
            '    Try
            '        cmm2Ea.ExecuteNonQuery()
            '        Dim ss2ESa As String = "insert into DN(DN,IDK)VALUES(@DN,@IDK)"
            '        '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            '        Dim cmm2ESa As New SqlClient.SqlCommand(ss2ESa, cn)
            '        cmm2ESa.Parameters.AddWithValue("@DN", "تغذيه")
            '        cmm2ESa.Parameters.AddWithValue("@IDK", CInt(2))
            '        Try
            '            cmm2ESa.ExecuteNonQuery()
            '            Dim ss2ENa As String = "insert into DNKEMA(IDD,EJRAA)VALUES(@IDD,@EJRAA)"
            '            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            '            Dim cmm2ENa As New SqlClient.SqlCommand(ss2ENa, cn)
            '            cmm2ENa.Parameters.AddWithValue("@IDD", CInt(1))
            '            cmm2ENa.Parameters.AddWithValue("@EJRAA", CInt(2))
            '            Try
            '                cmm2ENa.ExecuteNonQuery()
            '            Catch ex As Exception
            '            End Try
            '        Catch ex As Exception
            '        End Try
            '    Catch ex As Exception
            '    End Try
            'Catch ex As Exception
            'End Try
            'Dim ss2aKC As String = "insert into KESEM(KESEM)VALUES(@KESEM)"
            ''    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            'Dim cmm2aKC As New SqlClient.SqlCommand(ss2aKC, cn)
            'cmm2aKC.Parameters.AddWithValue("@KESEM", "خرم")
            'Try
            '    cmm2aKC.ExecuteNonQuery()
            '    Dim ss2Ea As String = "insert into EJRAA(EJRAA,IDK)VALUES(@EJRAA,@IDK)"
            '    '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            '    Dim cmm2Ea As New SqlClient.SqlCommand(ss2Ea, cn)
            '    cmm2Ea.Parameters.AddWithValue("@EJRAA", "خرم")
            '    cmm2Ea.Parameters.AddWithValue("@IDK", CInt(3))
            '    Try
            '        cmm2Ea.ExecuteNonQuery()
            '        Dim ss2ESa As String = "insert into DN(DN,IDK)VALUES(@DN,@IDK)"
            '        '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            '        Dim cmm2ESa As New SqlClient.SqlCommand(ss2ESa, cn)
            '        cmm2ESa.Parameters.AddWithValue("@DN", "خرم")
            '        cmm2ESa.Parameters.AddWithValue("@IDK", CInt(3))
            '        Try
            '            cmm2ESa.ExecuteNonQuery()
            '            Dim ss2ENa As String = "insert into DNKEMA(IDD,EJRAA)VALUES(@IDD,@EJRAA)"
            '            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            '            Dim cmm2ENa As New SqlClient.SqlCommand(ss2ENa, cn)
            '            cmm2ENa.Parameters.AddWithValue("@IDD", CInt(2))
            '            cmm2ENa.Parameters.AddWithValue("@EJRAA", CInt(3))
            '            Try
            '                cmm2ENa.ExecuteNonQuery()
            '            Catch ex As Exception
            '            End Try
            '        Catch ex As Exception
            '        End Try
            '    Catch ex As Exception
            '    End Try
            'Catch ex As Exception
            'End Try


        End If
        'If ComboBox2.Items.Count = 0 Or ComboBox4.Items.Count = 0 Or ComboBox5.Items.Count = 0 Then
        '    Dim f As New setting
        '    Me.Hide()
        '    f.ShowDialog()
        '    If ComboBox2.Items.Count = 0 Or ComboBox4.Items.Count = 0 Or ComboBox5.Items.Count = 0 Then
        '        End
        '    Else
        '        Me.Show()
        '    End If
        'End If
        If ComboBox1.Items.Count = 0 Then
            Dim ss2 As String = "insert into Mostafeed(NameM,JehaM)VALUES(@NameM,@JehaM)"
            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
            cmm2.Parameters.AddWithValue("@NameM", "نقدا")
            cmm2.Parameters.AddWithValue("@JehaM", "نقدا")
            Try
                cmm2.ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End If
        'الإيواءToolStripMenuItem.Visible = t1
        'ReceptionToolStripMenuItem.Visible = t1
        AppointmentToolStripMenuItem1.Visible = t2
        If t3 = True Or t4 = True Or t5 = True Or t6 = True Or t7 = True Or t8 = True Or T9 = True Or T10 = True Then
            الخزينةToolStripMenuItem.Visible = True
        Else
            الخزينةToolStripMenuItem.Visible = False
        End If
        ManageUsersToolStripMenuItem.Visible = T11
        إدارةالنظامToolStripMenuItem.Visible = T12
        'إدارةالمستفيدوالجهاتToolStripMenuItem.Visible = T13
        إدارةالعملياتToolStripMenuItem.Visible = T14
        تصفيرToolStripMenuItem.Visible = T15
        ToolStripMenuItem1.Visible = T15
        تسجيلالنظامToolStripMenuItem.Visible = T15
        If T11 = True Or T12 = True Or T13 = True Or T14 = True Or T15 = True Then
            SystemToolsToolStripMenuItem.Visible = True
        Else
            SystemToolsToolStripMenuItem.Visible = False
        End If
        'TODO: This line of code loads data into the 'DbsbhDataSet8.APPOINTMENTVIEW1' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTVIEW1TableAdapter.Fill(Me.DbsbhDataSet8.APPOINTMENTVIEW1)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.APPOINTMENTVIEW' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTVIEWTableAdapter.Fill(Me.DbsbhDataSet8.APPOINTMENTVIEW)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.APPOINTMENT' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTTableAdapter1.Fill(Me.DbsbhDataSet8.APPOINTMENT)
        'PharmacyToolStripMenuItem.Visible = t1
        'ReportsToolStripMenuItem.Visible = t2
        'PharmacyToolStripMenuItem.Visible = False
        'ReportsToolStripMenuItem.Visible = False
        'LapToolStripMenuItem.Visible = False
        ''LapToolStripMenuItem.Visible = t3
        ''DoctorRoomToolStripMenuItem.Visible = t4
        'DoctorRoomToolStripMenuItem.Visible = False
        'SystemToolsToolStripMenuItem.Visible = t5
        'AppointmentToolStripMenuItem1.Visible = t7
        ''ReceptionToolStripMenuItem.Visible = T9
        ''الطبيبToolStripMenuItem.Visible = T9
        'الطبيبToolStripMenuItem.Visible = False
        ''المستفيدToolStripMenuItem.Visible = T9
        'المستفيدToolStripMenuItem.Visible = False
        'العملياتToolStripMenuItem1.Visible = False
        'العملياتToolStripMenuItem1.Visible = T9
        Me.Label5.Text = t7
        Dim sk1 As String
        sk1 = "select * from dn"
        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
        Dim dsk1 As New DataSet
        adk1.Fill(dsk1, "dn")
        'Me.CheckedListBox1.DataSource = dsk1.Tables(0)
        'CheckedListBox1.DisplayMember = "doctorname"
        Me.ListBox1.DataSource = dsk1.Tables(0)
        ListBox1.DisplayMember = "dn"
        'ComboBox1.SelectedIndex = -1

        'TODO: This line of code loads data into the 'DbsbhDataSet2.APPOINTMENT' table. You can move, or remove it, as needed.
        ' Me.APPOINTMENTTableAdapter.Fill(Me.DbsbhDataSet2.APPOINTMENT)
        'TODO: This line of code loads data into the 'DBASEDataSet.MAIN_TABLE' table. You can move, or remove it, as needed.
        'Me.MAIN_TABLETableAdapter.Fill(Me.DBASEDataSet.MAIN_TABLE)
        'TODO: This line of code loads data into the 'DBASEDataSet.APPOINTMENT' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTTableAdapter.Fill(Me.DBASEDataSet.APPOINTMENT)
        If ut = 2 Then
            Me.ListBox1.Visible = True
            Me.ListBox1.Text = user
            Me.TextBox2.Text = Me.ListBox1.Text
            Me.CheckBox1.Checked = True
            Me.GroupBox2.Visible = False
            Me.Panel6.Visible = True

        Else
            Me.CheckBox1.Enabled = True
        End If

        t = 0
        Me.Label3.Text = My.Settings.CLIN
        Call Class4.CONNIC()
        Me.Timer1.Start()
        'Me.Timer2.Start()
    End Sub

    Private Sub سجلاتالمرضToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub المواعيدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub المعـــــــــاملToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub المصروفـــــاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub الإيـــــــــراداتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ملاحضــــــــاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim f As New FrmReception
        If f.IsDisposed = True Then
            Me.Panel1.Visible = True
            Me.GroupBox1.Visible = True
            Me.GroupBox2.Visible = True
        End If
        ToolStripStatusLabel2.Text = user
        ToolStripStatusLabel4.Text = log_date
        ToolStripStatusLabel6.Text = log_time
        Me.Label4.Text = Format(Now, "hh:mm:ss")
        'Dim da2 As New SqlClient.SqlDataAdapter
        'Dim ds2 As DataSet
        ''Dim dr2 As DataRow
        'Dim dt2 As DataTable
        'Dim x As String = "select * from MAIN_TABLE"
        'da2 = New SqlClient.SqlDataAdapter(x, cn)
        'ds2 = New DataSet
        'da2.Fill(ds2, x)
        'dt2 = ds2.Tables(x)
        ''TextBox1.Text = dt2.Rows.Count
        ''ToolStripStatusLabel9.Text = dt2.Rows.Count
        'ToolStripStatusLabel2.Text = user
        'ToolStripStatusLabel4.Text = log_date
        'ToolStripStatusLabel6.Text = log_time
        Me.Label2.Text = Format(Now, "yyyy/MM/dd")
        If FrmReception.Simulator.IsDisposed = True Then
            Me.Panel1.Visible = True
            Me.GroupBox1.Visible = True
            Me.GroupBox2.Visible = True
        End If

    End Sub

    Private Sub ToolStripStatusLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel5.Click

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Call Class1.CONNIC()
        Dim s1 As String = "select * from APPOINTMENTVIEW "
        Dim aad12 As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad12.Fill(dss, "APPOINTMENTVIEW")
        DataGridView1.DataSource = dss.Tables("APPOINTMENTVIEW")
        Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
        If Me.CheckBox1.Checked = True Then
            vd.RowFilter = "datea=" & "'" & Date.Today.Date & "'" & "and visit=" & "'" & "0" & "'" & "and DN=" & "'" & Me.ListBox1.Text & "'" & "and CHNO<>" & "'" & "0" & "'" & ""
        Else
            vd.RowFilter = "datea=" & "'" & Date.Today.Date & "'" & "and visit=" & "'" & "0" & "'" & "and CHNO<>" & "'" & "0" & "'" & ""
        End If
        Me.DataGridView1.DataMember = ""
        DataGridView1.DataSource = vd
        Call Class4.CONNIC()
    End Sub

    Private Sub MenuStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    'Private Sub MODFIYFILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODFIYFILEToolStripMenuItem.Click
    '    Form3.ShowDialog()
    'End Sub

    Private Sub ByFileNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ByNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ByDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub NewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub AppointmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        'Select Case e.ColumnIndex
        '    Case 0
        '        If t4 = True Then
        '            Dim dgx As String
        '            dgx = Me.DataGridView1.CurrentCell.Value
        '            'Dim dgx As Integer
        '            If dgx <> "" Then
        '                'dgx = Me.DataGridView1.CurrentCell.Value
        '                TextBox1.Text = dgx
        '                t = 1
        '                dgxx = TextBox1.Text
        '                Form1.ShowDialog()
        '            End If
        '        End If

        'End Select
    End Sub

    Private Sub ReceptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceptionToolStripMenuItem.Click

    End Sub

    Private Sub NewToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem2.Click
        ''Form2.ShowDialog()
    End Sub

    Private Sub ByFileNumberToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByFileNumberToolStripMenuItem1.Click
        ''Form4.ShowDialog()
    End Sub

    Private Sub ByNameToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByNameToolStripMenuItem1.Click
        ''Form5.ShowDialog()
    End Sub

    Private Sub ByDateToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDateToolStripMenuItem1.Click
        ''Form7.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        ''Form6.ShowDialog()
    End Sub

    Private Sub AppointmentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentToolStripMenuItem1.Click
        'Panel1.Visible = False
        'GroupBox1.Visible = False
        'GroupBox2.Visible = False
        'Form10.Simulator.MdiParent = Me
        'Form10.Simulator.WindowState = FormWindowState.Maximized
        'Form10.Simulator.ShowDialog()
        Call Class4.CONNIC()
        Dim f As New FrmReception
        'Timer1.Stop()
        'Timer2.Stop()
        Me.Hide()
        f.ShowDialog()
        Me.Show()
        'Timer1.Start()
        'Timer2.Start()
    End Sub

    Private Sub NewToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub DoctorRoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorRoomToolStripMenuItem.Click
        Form1.ShowDialog()
    End Sub

    Private Sub PharmacyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PharmacyToolStripMenuItem.Click
        'PHARMACY.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MsgBox("*******Good luck*********")
        Close()
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignOutToolStripMenuItem.Click
        Me.Hide()
        Call Class4.CONNIC()
        Dim f As New FrmLogin
        f.ShowDialog()
    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUsersToolStripMenuItem.Click
        Dim f As New FrmUserManagement
        f.ShowDialog()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.ListBox1.Visible = True
        Else
            Me.ListBox1.Visible = False
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim s1 As String = "select * from APPOINTMENTVIEW "
        Dim aad12 As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad12.Fill(dss, "APPOINTMENTVIEW")
        DataGridView1.DataSource = dss.Tables("APPOINTMENTVIEW")
        Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
        If Me.CheckBox1.Checked = True Then
            vd.RowFilter = "datea=" & "'" & Date.Today.Date & "'" & "and visit=" & "'" & "0" & "'" & "and DN=" & "'" & Me.ListBox1.Text & "'" & "and CHNO<>" & "'" & "0" & "'" & ""
        Else
            vd.RowFilter = "datea=" & "'" & Date.Today.Date & "'" & "and visit=" & "'" & "0" & "'" & "and CHNO<>" & "'" & "0" & "'" & ""
        End If
        Me.DataGridView1.DataMember = ""
        DataGridView1.DataSource = vd
        Call Class4.CONNIC()
    End Sub

    Private Sub LapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapToolStripMenuItem.Click
        Dim F As New FrmGeneralLab
        F.ShowDialog()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click

    End Sub

    Private Sub SystemToolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemToolsToolStripMenuItem.Click

    End Sub

    Private Sub GeneralReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralReportToolStripMenuItem.Click
        Dim f As New FrmReportDateSelector
        f.ShowDialog()
    End Sub

    Private Sub ByDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDToolStripMenuItem.Click
        Dim f As New FrmDoctorReport
        f.ShowDialog()
    End Sub

    Private Sub ByCityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByCityToolStripMenuItem.Click
        Dim f As New FrmReportByCity
        f.ShowDialog()
    End Sub

    Private Sub ReportBySexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportBySexToolStripMenuItem.Click
        Dim f As New FrmReportBySex
        f.ShowDialog()
    End Sub

    Private Sub DocumentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentsToolStripMenuItem.Click
        Dim f As New FrmPatientDocs
        f.ShowDialog()
    End Sub

    Private Sub بياناتالطبيبToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub بياناتالمستفيدToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub الاجراءاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الاجراءاتToolStripMenuItem.Click
        Dim f As New FrmProcedure
        f.ShowDialog()
    End Sub



    Private Sub الخزينةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الخزينةToolStripMenuItem.Click
        Call Class4.CONNIC()
        Dim f As New FrmTreasuryReport
        'Timer1.Stop()
        'Timer2.Stop()
        Me.Hide()
        f.ShowDialog()
        Me.Show()
        'Timer1.Start()
        'Timer2.Start()
    End Sub

    Private Sub الإيواءToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الإيواءToolStripMenuItem.Click
        Dim f As New FrmLodging
        'Timer1.Stop()
        'Timer2.Stop()
        Me.Hide()
        f.ShowDialog()
        Me.Show()
        ''Timer1.Start()
        'Timer2.Start()
    End Sub

    Private Sub العملياتToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub الطبيبToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الطبيبToolStripMenuItem.Click
        'Dim f As New Doctors
        'f.ShowDialog()
    End Sub

    Private Sub المستفيدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles المستفيدToolStripMenuItem.Click
        Dim f As New FrmMostafeed
        f.ShowDialog()
    End Sub

    Private Sub العملياتToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles العملياتToolStripMenuItem1.Click
        Dim f As New FrmSurgery
        f.ShowDialog()
    End Sub


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub إدارةالنظامToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إدارةالنظامToolStripMenuItem.Click
        Dim f As New FrmSettings
        f.ShowDialog()
    End Sub

    Private Sub تصفيرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تصفيرToolStripMenuItem.Click
        Call Class1.CONNIC()
        'TRUNCATE FROM USERS 
        'Dim sK As String = "DELETE FROM KESEM"
        'Dim cmK As New SqlClient.SqlCommand(sK, cn)
        'Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('KESEM', RESEED, -1)", cn)
        Dim sY As String = "DELETE FROM EYWAA"
        Dim cmY As New SqlClient.SqlCommand(sY, cn)
        Dim cmMY As New SqlClient.SqlCommand("DBCC CHECKIDENT('EYWAA', RESEED, 0)", cn)
        'Dim sJ As String = "DELETE FROM EJRAA"
        'Dim cmJ As New SqlClient.SqlCommand(sJ, cn)
        'Dim cmj1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Ejraa', RESEED, -1)", cn)
        Dim sCDOC As String = "DELETE FROM AM_CDOC"
        Dim cmCDOC As New SqlClient.SqlCommand(sCDOC, cn)
        Dim cmCDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_CDOC', RESEED, 0)", cn)
        Dim sDOC As String = "DELETE FROM AM_DOC"
        Dim cmDOC As New SqlClient.SqlCommand(sDOC, cn)
        Dim cmDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_DOC', RESEED, 0)", cn)
        Dim sFDOC As String = "DELETE FROM AM_FDOC"
        Dim cmFDOC As New SqlClient.SqlCommand(sFDOC, cn)
        Dim cmfDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_fDOC', RESEED, 0)", cn)
        Dim sFTDOC As String = "DELETE FROM AM_FTDOC"
        Dim cmFTDOC As New SqlClient.SqlCommand(sFTDOC, cn)
        Dim cmftDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_ftDOC', RESEED, 0)", cn)
        Dim sKAB As String = "DELETE FROM AM_KAB"
        Dim cmKAB As New SqlClient.SqlCommand(sKAB, cn)
        Dim cmKAB1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_KAB', RESEED, 0)", cn)
        Dim sMDOC As String = "DELETE FROM AM_MDOC"
        Dim cmMDOC As New SqlClient.SqlCommand(sMDOC, cn)
        Dim cmMDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_MDOC', RESEED, 0)", cn)
        Dim sTAH As String = "DELETE FROM AM_TAH"
        Dim cmTAH As New SqlClient.SqlCommand(sTAH, cn)
        Dim cmTAH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_TAH', RESEED, 0)", cn)
        Dim sTDOC As String = "DELETE FROM AM_TDOC"
        Dim cmTDOC As New SqlClient.SqlCommand(sTDOC, cn)
        Dim cmTDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_TDOC', RESEED, 0)", cn)
        Dim sAMA As String = "DELETE FROM AMALEAT"
        Dim cmAMA As New SqlClient.SqlCommand(sAMA, cn)
        Dim cmAMA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AMALEAT', RESEED, 0)", cn)
        Dim sAMAM As String = "DELETE FROM AMALEAT_M"
        Dim cmAMAM As New SqlClient.SqlCommand(sAMAM, cn)
        Dim cmAMAM1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AMALEAT_M', RESEED, 0)", cn)
        Dim sAP As String = "DELETE FROM APPOINTMENT"
        Dim cmAP As New SqlClient.SqlCommand(sAP, cn)
        Dim cmAP1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('APPOINTMENT', RESEED, 0)", cn)
        Dim sBIO As String = "DELETE FROM BIO_CHEMISTRY"
        Dim cmBIO As New SqlClient.SqlCommand(sBIO, cn)
        Dim cmBIO1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('BIO_CHEMISTRY', RESEED, 0)", cn)
        Dim sCBC As String = "DELETE FROM CBC"
        Dim cmCBC As New SqlClient.SqlCommand(sCBC, cn)
        Dim cmCBC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('CBC', RESEED, 0)", cn)
        'Dim sDN As String = "DELETE FROM DN"
        'Dim cmDN As New SqlClient.SqlCommand(sDN, cn)
        'Dim cmDN1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DN', RESEED, -1)", cn)
        'Dim sDNK As String = "DELETE FROM DNKEMA"
        'Dim cmDNK As New SqlClient.SqlCommand(sDNK, cn)
        'Dim cmDNK1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DNKEMA', RESEED, 0)", cn)
        Dim sDR As String = "DELETE FROM DOCTORR"
        Dim cmDR As New SqlClient.SqlCommand(sDR, cn)
        Dim cmDR1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DOCTORR', RESEED, 0)", cn)
        Dim sD As String = "DELETE FROM DOCUMENT"
        Dim cmD As New SqlClient.SqlCommand(sD, cn)
        Dim cmD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DOCUMENT', RESEED, 0)", cn)
        Dim sEH As String = "DELETE FROM EIA_HORMONAL"
        Dim cmEH As New SqlClient.SqlCommand(sEH, cn)
        Dim cmEH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('EIA_HORMONAL', RESEED, 0)", cn)
        Dim sEL As String = "DELETE FROM ELECTROLYTES"
        Dim cmEL As New SqlClient.SqlCommand(sEL, cn)
        Dim cmEL1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('ELECTROLYTES', RESEED, 0)", cn)
        Dim sHA As String = "DELETE FROM HESAB_AM"
        Dim cmHA As New SqlClient.SqlCommand(sHA, cn)
        Dim cmHA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HESAB_AM', RESEED, 0)", cn)
        Dim sHD As String = "DELETE FROM HESAB_DO"
        Dim cmHD As New SqlClient.SqlCommand(sHD, cn)
        Dim cmHD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HESAB_DO', RESEED, 0)", cn)
        Dim sH As String = "DELETE FROM HISTORY"
        Dim cmH As New SqlClient.SqlCommand(sH, cn)
        Dim cmH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HISTORY', RESEED, 0)", cn)
        Dim sHAS As String = "DELETE FROM HORMONAL_ASSAY"
        Dim cmHAS As New SqlClient.SqlCommand(sHAS, cn)
        Dim cmHAS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HORMONAL_ASSAY', RESEED, 0)", cn)
        Dim sJAD As String = "DELETE FROM JAD"
        Dim cmJAD As New SqlClient.SqlCommand(sJAD, cn)
        Dim cmJAD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JAD', RESEED, 0)", cn)
        Dim sJAM As String = "DELETE FROM JAM"
        Dim cmJAM As New SqlClient.SqlCommand(sJAM, cn)
        Dim cmJAM1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JAM', RESEED, 0)", cn)
        Dim sJAS As String = "DELETE FROM JAS"
        Dim cmJAS As New SqlClient.SqlCommand(sJAS, cn)
        Dim cmJAS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JAS', RESEED, 0)", cn)
        Dim sJKT As String = "DELETE FROM JEHAKASHEFT"
        Dim cmJKT As New SqlClient.SqlCommand(sJKT, cn)
        Dim cmJKT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JEHAKASHEFT', RESEED, 0)", cn)
        Dim sJK As String = "DELETE FROM JK"
        Dim cmJK As New SqlClient.SqlCommand(sJK, cn)
        Dim cmJK1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JK', RESEED, 0)", cn)
        Dim sJS As String = "DELETE FROM JS"
        Dim cmJS As New SqlClient.SqlCommand(sJS, cn)
        Dim cmJS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JS', RESEED, 0)", cn)
        Dim sJSH As String = "DELETE FROM JSH"
        Dim cmJSH As New SqlClient.SqlCommand(sJSH, cn)
        Dim cmJSH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JSH', RESEED, 0)", cn)
        Dim sJT As String = "DELETE FROM JT"
        Dim cmJT As New SqlClient.SqlCommand(sJT, cn)
        Dim cmJT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JT', RESEED, 0)", cn)
        Dim sJTGH As String = "DELETE FROM JTGH"
        Dim cmJTGH As New SqlClient.SqlCommand(sJTGH, cn)
        Dim cmJTGH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JTGH', RESEED, 0)", cn)
        Dim sKA As String = "DELETE FROM KASHEF"
        Dim cmKA As New SqlClient.SqlCommand(sKA, cn)
        Dim cmKA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('KASHEF', RESEED, 0)", cn)
        Dim sLAB As String = "DELETE FROM LAB"
        Dim cmLAB As New SqlClient.SqlCommand(sLAB, cn)
        Dim cmLAB1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LAB', RESEED, 0)", cn)
        Dim sLABD As String = "DELETE FROM LABDOC"
        Dim cmLABD As New SqlClient.SqlCommand(sLABD, cn)
        Dim cmLABD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LABDOC', RESEED, 0)", cn)
        Dim sLFT As String = "DELETE FROM LFT"
        Dim cmLFT As New SqlClient.SqlCommand(sLFT, cn)
        Dim cmLFT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LFT', RESEED, 0)", cn)
        Dim sLOSS As String = "DELETE FROM LOSS"
        Dim cmLOSS As New SqlClient.SqlCommand(sLOSS, cn)
        Dim cmLOSS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LOSS', RESEED, 0)", cn)
        Dim sM As String = "DELETE FROM MAIN"
        Dim cmM As New SqlClient.SqlCommand(sM, cn)
        Dim cmM1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('MAIN', RESEED, 1000)", cn)
        Dim sMO As String = "DELETE FROM MOSTAFEED"
        Dim cmMO As New SqlClient.SqlCommand(sMO, cn)
        Dim cmMO1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('MOSTAFEED', RESEED, -1)", cn)
        Dim sPH As String = "DELETE FROM PHARMACY"
        Dim cmPH As New SqlClient.SqlCommand(sPH, cn)
        Dim cmPH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('PHARMACY', RESEED, 0)", cn)
        Dim sPRT As String = "DELETE FROM PROTHONBIN_TEST"
        Dim cmPRT As New SqlClient.SqlCommand(sPRT, cn)
        Dim cmPRT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('PROTHONBIN_TEST', RESEED, 0)", cn)
        Dim sR As String = "DELETE FROM REPORT"
        Dim cmR As New SqlClient.SqlCommand(sR, cn)
        Dim cmR1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('REPORT', RESEED, 0)", cn)
        Dim sRFT As String = "DELETE FROM LAB"
        Dim cmRFT As New SqlClient.SqlCommand(sRFT, cn)
        Dim cmRFT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LAB', RESEED, 0)", cn)
        Dim sSAD As String = "DELETE FROM SADAD"
        Dim cmSAD As New SqlClient.SqlCommand(sSAD, cn)
        Dim cmSAD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('SADAD', RESEED, 0)", cn)
        Dim sSA As String = "DELETE FROM SEMEN_ANALYSIS"
        Dim cmSA As New SqlClient.SqlCommand(sSA, cn)
        Dim cmSA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('SEMEN_ANALYSIS', RESEED, 0)", cn)
        Dim sSER As String = "DELETE FROM SEROLOGY"
        Dim cmSER As New SqlClient.SqlCommand(sSER, cn)
        Dim cmSER1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('SEROLOGY', RESEED, 0)", cn)
        Dim sTOR As String = "DELETE FROM TIROID"
        Dim cmTOR As New SqlClient.SqlCommand(sTOR, cn)
        Dim cmTOR1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TIROID', RESEED, 0)", cn)
        Dim sTORCH As String = "DELETE FROM TORCH"
        Dim cmTORCH As New SqlClient.SqlCommand(sTORCH, cn)
        Dim cmTORCH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TORCH', RESEED, 0)", cn)
        Dim sTP As String = "DELETE FROM TREATMENT_PLANING"
        Dim cmTP As New SqlClient.SqlCommand(sTP, cn)
        Dim cmTP1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TREATMENT_PLANING', RESEED, 0)", cn)
        Dim sTV As String = "DELETE FROM TREATMENT_VISITS"
        Dim cmTV As New SqlClient.SqlCommand(sTV, cn)
        Dim cmTV1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TREATMENT_VISITS', RESEED, 0)", cn)
        Dim sU As String = "DELETE FROM URINE"
        Dim cmU As New SqlClient.SqlCommand(sU, cn)
        Dim cmU1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('URINE', RESEED, 0)", cn)
        'Dim sUS As String = "DELETE FROM USERS"
        'Dim cmUS As New SqlClient.SqlCommand(sUS, cn)
        'Dim cmUS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('USERS', RESEED, -1)", cn)
        Dim sV As String = "DELETE FROM VIROLOGY"
        Dim cmV As New SqlClient.SqlCommand(sV, cn)
        Dim cmV1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('VIROLOGY', RESEED, 0)", cn)
        Dim sW As String = "DELETE FROM WIDAL_TEST"
        Dim cmW As New SqlClient.SqlCommand(sW, cn)
        Dim cmW1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('WIDAL_TEST', RESEED, 0)", cn)
        'Dim sWTY As String = "DELETE FROM TYPEEYWAA"
        'Dim cmWTY As New SqlClient.SqlCommand(sWTY, cn)
        'Dim cmW1TY As New SqlClient.SqlCommand("DBCC CHECKIDENT('TYPEEYWAA', RESEED, 0)", cn)
        'Try
        cmY.ExecuteNonQuery()
        cmM.ExecuteNonQuery()
        'cmK.ExecuteNonQuery()
        'cmk1.ExecuteNonQuery()
        'cmJ.ExecuteNonQuery()
        'cmj1.ExecuteNonQuery()
        cmDOC.ExecuteNonQuery()
        cmDOC1.ExecuteNonQuery()
        cmCDOC.ExecuteNonQuery()
        cmCDOC1.ExecuteNonQuery()
        cmFDOC.ExecuteNonQuery()
        cmfDOC1.ExecuteNonQuery()
        cmFTDOC.ExecuteNonQuery()
        cmftDOC1.ExecuteNonQuery()
        cmKAB.ExecuteNonQuery()
        cmKAB1.ExecuteNonQuery()
        cmMDOC.ExecuteNonQuery()
        cmMDOC1.ExecuteNonQuery()
        cmTAH.ExecuteNonQuery()
        cmTDOC.ExecuteNonQuery()
        cmAMA.ExecuteNonQuery()
        cmAMAM.ExecuteNonQuery()
        cmAP.ExecuteNonQuery()
        cmBIO.ExecuteNonQuery()
        cmCBC.ExecuteNonQuery()
        'cmDNK.ExecuteNonQuery()
        cmDR.ExecuteNonQuery()
        cmD.ExecuteNonQuery()
        cmEH.ExecuteNonQuery()
        cmEL.ExecuteNonQuery()
        cmHA.ExecuteNonQuery()
        cmHD.ExecuteNonQuery()
        cmH.ExecuteNonQuery()
        cmHAS.ExecuteNonQuery()
        cmJAD.ExecuteNonQuery()
        cmJAM.ExecuteNonQuery()
        cmJAS.ExecuteNonQuery()
        cmJKT.ExecuteNonQuery()
        cmJK.ExecuteNonQuery()
        cmJS.ExecuteNonQuery()
        cmJSH.ExecuteNonQuery()
        cmJT.ExecuteNonQuery()
        cmJTGH.ExecuteNonQuery()
        cmKA.ExecuteNonQuery()
        cmLAB.ExecuteNonQuery()
        cmLABD.ExecuteNonQuery()
        cmLFT.ExecuteNonQuery()
        cmLOSS.ExecuteNonQuery()
        cmMO.ExecuteNonQuery()
        cmPH.ExecuteNonQuery()
        cmPRT.ExecuteNonQuery()
        cmR.ExecuteNonQuery()
        cmRFT.ExecuteNonQuery()
        cmSAD.ExecuteNonQuery()
        cmSA.ExecuteNonQuery()
        cmSER.ExecuteNonQuery()
        cmTOR.ExecuteNonQuery()
        cmTORCH.ExecuteNonQuery()
        cmTP.ExecuteNonQuery()
        cmTV.ExecuteNonQuery()
        cmU.ExecuteNonQuery()
        'cmUS.ExecuteNonQuery()
        cmV.ExecuteNonQuery()
        cmW.ExecuteNonQuery()
        'cmDN.ExecuteNonQuery()
        'cmWTY.ExecuteNonQuery()


        cmMY.ExecuteNonQuery()
        cmTAH1.ExecuteNonQuery()
        cmTDOC1.ExecuteNonQuery()
        cmAMA1.ExecuteNonQuery()
        cmAMAM1.ExecuteNonQuery()
        cmAP1.ExecuteNonQuery()
        cmBIO1.ExecuteNonQuery()
        cmCBC1.ExecuteNonQuery()
        'cmDN1.ExecuteNonQuery()
        'cmDNK1.ExecuteNonQuery()
        cmDR1.ExecuteNonQuery()
        cmD1.ExecuteNonQuery()
        cmEH1.ExecuteNonQuery()
        cmEL1.ExecuteNonQuery()
        cmHA1.ExecuteNonQuery()
        cmHD1.ExecuteNonQuery()
        cmH1.ExecuteNonQuery()
        cmHAS1.ExecuteNonQuery()
        cmJAD1.ExecuteNonQuery()
        cmJAM1.ExecuteNonQuery()
        cmJAS1.ExecuteNonQuery()
        cmJKT1.ExecuteNonQuery()
        cmJK1.ExecuteNonQuery()
        cmJS1.ExecuteNonQuery()
        cmJSH1.ExecuteNonQuery()
        cmJT1.ExecuteNonQuery()
        cmJTGH1.ExecuteNonQuery()
        cmKA1.ExecuteNonQuery()
        cmLAB1.ExecuteNonQuery()
        cmLABD1.ExecuteNonQuery()
        cmLFT1.ExecuteNonQuery()
        cmLOSS1.ExecuteNonQuery()
        cmM1.ExecuteNonQuery()
        cmMO1.ExecuteNonQuery()
        cmPH1.ExecuteNonQuery()
        cmPRT1.ExecuteNonQuery()
        cmR1.ExecuteNonQuery()
        cmRFT1.ExecuteNonQuery()
        cmSAD1.ExecuteNonQuery()
        cmSA1.ExecuteNonQuery()
        cmSER1.ExecuteNonQuery()
        cmTOR1.ExecuteNonQuery()
        cmTORCH1.ExecuteNonQuery()
        cmTP1.ExecuteNonQuery()
        cmTV1.ExecuteNonQuery()
        cmU1.ExecuteNonQuery()
        'cmUS1.ExecuteNonQuery()
        cmV1.ExecuteNonQuery()
        cmW1.ExecuteNonQuery()
        'cmW1TY.ExecuteNonQuery()
        Call Class4.CONNIC()
        MsgBox("تم تصفير قاعدة البيانات")
        End
        'Catch ex As Exception
        '    MsgBox("لم تتم عملية التصفير")
        'End Try
        'Dim sB As String = "DELETE FROM KESEM"
        'Dim cmB As New SqlClient.SqlCommand(sB, cn)
        'Try
        '    cmB.ExecuteNonQuery()
        '    MsgBox("تم تصفير الأقسام")
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub إدارةالمستفيدوالجهاتToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f As New FrmMostafeed
        f.ShowDialog()
    End Sub

    Private Sub إدارةالعملياتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إدارةالعملياتToolStripMenuItem.Click
        'Dim f As New AMALEATvb
        'f.ShowDialog()
    End Sub

    Private Sub إدارةالبياناتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إدارةالبياناتToolStripMenuItem.Click
        Dim f As New FrmBackupRestore
        f.ShowDialog()
    End Sub

    Private Sub MDIParent1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'TRUNCATE FROM USERS 
        Call Class1.CONNIC()
        Dim sK As String = "DELETE FROM KESEM"
        Dim cmK As New SqlClient.SqlCommand(sK, cn)
        Dim cmk1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('KESEM', RESEED, -1)", cn)
        Dim sY As String = "DELETE FROM EYWAA"
        Dim cmY As New SqlClient.SqlCommand(sY, cn)
        Dim cmMY As New SqlClient.SqlCommand("DBCC CHECKIDENT('EYWAA', RESEED, 0)", cn)
        Dim sJ As String = "DELETE FROM EJRAA"
        Dim cmJ As New SqlClient.SqlCommand(sJ, cn)
        Dim cmj1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('Ejraa', RESEED, -1)", cn)
        Dim sCDOC As String = "DELETE FROM AM_CDOC"
        Dim cmCDOC As New SqlClient.SqlCommand(sCDOC, cn)
        Dim cmCDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_CDOC', RESEED, 0)", cn)
        Dim sDOC As String = "DELETE FROM AM_DOC"
        Dim cmDOC As New SqlClient.SqlCommand(sDOC, cn)
        Dim cmDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_DOC', RESEED, 0)", cn)
        Dim sFDOC As String = "DELETE FROM AM_FDOC"
        Dim cmFDOC As New SqlClient.SqlCommand(sFDOC, cn)
        Dim cmfDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_fDOC', RESEED, 0)", cn)
        Dim sFTDOC As String = "DELETE FROM AM_FTDOC"
        Dim cmFTDOC As New SqlClient.SqlCommand(sFTDOC, cn)
        Dim cmftDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_ftDOC', RESEED, 0)", cn)
        Dim sKAB As String = "DELETE FROM AM_KAB"
        Dim cmKAB As New SqlClient.SqlCommand(sKAB, cn)
        Dim cmKAB1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_KAB', RESEED, 0)", cn)
        Dim sMDOC As String = "DELETE FROM AM_MDOC"
        Dim cmMDOC As New SqlClient.SqlCommand(sMDOC, cn)
        Dim cmMDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_MDOC', RESEED, 0)", cn)
        Dim sTAH As String = "DELETE FROM AM_TAH"
        Dim cmTAH As New SqlClient.SqlCommand(sTAH, cn)
        Dim cmTAH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_TAH', RESEED, 0)", cn)
        Dim sTDOC As String = "DELETE FROM AM_TDOC"
        Dim cmTDOC As New SqlClient.SqlCommand(sTDOC, cn)
        Dim cmTDOC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AM_TDOC', RESEED, 0)", cn)
        Dim sAMA As String = "DELETE FROM AMALEAT"
        Dim cmAMA As New SqlClient.SqlCommand(sAMA, cn)
        Dim cmAMA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AMALEAT', RESEED, 0)", cn)
        Dim sAMAM As String = "DELETE FROM AMALEAT_M"
        Dim cmAMAM As New SqlClient.SqlCommand(sAMAM, cn)
        Dim cmAMAM1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('AMALEAT_M', RESEED, 0)", cn)
        Dim sAP As String = "DELETE FROM APPOINTMENT"
        Dim cmAP As New SqlClient.SqlCommand(sAP, cn)
        Dim cmAP1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('APPOINTMENT', RESEED, 0)", cn)
        Dim sBIO As String = "DELETE FROM BIO_CHEMISTRY"
        Dim cmBIO As New SqlClient.SqlCommand(sBIO, cn)
        Dim cmBIO1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('BIO_CHEMISTRY', RESEED, 0)", cn)
        Dim sCBC As String = "DELETE FROM CBC"
        Dim cmCBC As New SqlClient.SqlCommand(sCBC, cn)
        Dim cmCBC1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('CBC', RESEED, 0)", cn)
        Dim sDN As String = "DELETE FROM DN"
        Dim cmDN As New SqlClient.SqlCommand(sDN, cn)
        Dim cmDN1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DN', RESEED, -1)", cn)
        Dim sDNK As String = "DELETE FROM DNKEMA"
        Dim cmDNK As New SqlClient.SqlCommand(sDNK, cn)
        Dim cmDNK1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DNKEMA', RESEED, 0)", cn)
        Dim sDR As String = "DELETE FROM DOCTORR"
        Dim cmDR As New SqlClient.SqlCommand(sDR, cn)
        Dim cmDR1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DOCTORR', RESEED, 0)", cn)
        Dim sD As String = "DELETE FROM DOCUMENT"
        Dim cmD As New SqlClient.SqlCommand(sD, cn)
        Dim cmD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('DOCUMENT', RESEED, 0)", cn)
        Dim sEH As String = "DELETE FROM EIA_HORMONAL"
        Dim cmEH As New SqlClient.SqlCommand(sEH, cn)
        Dim cmEH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('EIA_HORMONAL', RESEED, 0)", cn)
        Dim sEL As String = "DELETE FROM ELECTROLYTES"
        Dim cmEL As New SqlClient.SqlCommand(sEL, cn)
        Dim cmEL1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('ELECTROLYTES', RESEED, 0)", cn)
        Dim sHA As String = "DELETE FROM HESAB_AM"
        Dim cmHA As New SqlClient.SqlCommand(sHA, cn)
        Dim cmHA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HESAB_AM', RESEED, 0)", cn)
        Dim sHD As String = "DELETE FROM HESAB_DO"
        Dim cmHD As New SqlClient.SqlCommand(sHD, cn)
        Dim cmHD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HESAB_DO', RESEED, 0)", cn)
        Dim sH As String = "DELETE FROM HISTORY"
        Dim cmH As New SqlClient.SqlCommand(sH, cn)
        Dim cmH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HISTORY', RESEED, 0)", cn)
        Dim sHAS As String = "DELETE FROM HORMONAL_ASSAY"
        Dim cmHAS As New SqlClient.SqlCommand(sHAS, cn)
        Dim cmHAS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('HORMONAL_ASSAY', RESEED, 0)", cn)
        Dim sJAD As String = "DELETE FROM JAD"
        Dim cmJAD As New SqlClient.SqlCommand(sJAD, cn)
        Dim cmJAD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JAD', RESEED, 0)", cn)
        Dim sJAM As String = "DELETE FROM JAM"
        Dim cmJAM As New SqlClient.SqlCommand(sJAM, cn)
        Dim cmJAM1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JAM', RESEED, 0)", cn)
        Dim sJAS As String = "DELETE FROM JAS"
        Dim cmJAS As New SqlClient.SqlCommand(sJAS, cn)
        Dim cmJAS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JAS', RESEED, 0)", cn)
        Dim sJKT As String = "DELETE FROM JEHAKASHEFT"
        Dim cmJKT As New SqlClient.SqlCommand(sJKT, cn)
        Dim cmJKT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JEHAKASHEFT', RESEED, 0)", cn)
        Dim sJK As String = "DELETE FROM JK"
        Dim cmJK As New SqlClient.SqlCommand(sJK, cn)
        Dim cmJK1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JK', RESEED, 0)", cn)
        Dim sJS As String = "DELETE FROM JS"
        Dim cmJS As New SqlClient.SqlCommand(sJS, cn)
        Dim cmJS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JS', RESEED, 0)", cn)
        Dim sJSH As String = "DELETE FROM JSH"
        Dim cmJSH As New SqlClient.SqlCommand(sJSH, cn)
        Dim cmJSH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JSH', RESEED, 0)", cn)
        Dim sJT As String = "DELETE FROM JT"
        Dim cmJT As New SqlClient.SqlCommand(sJT, cn)
        Dim cmJT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JT', RESEED, 0)", cn)
        Dim sJTGH As String = "DELETE FROM JTGH"
        Dim cmJTGH As New SqlClient.SqlCommand(sJTGH, cn)
        Dim cmJTGH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('JTGH', RESEED, 0)", cn)
        Dim sKA As String = "DELETE FROM KASHEF"
        Dim cmKA As New SqlClient.SqlCommand(sKA, cn)
        Dim cmKA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('KASHEF', RESEED, 0)", cn)
        Dim sLAB As String = "DELETE FROM LAB"
        Dim cmLAB As New SqlClient.SqlCommand(sLAB, cn)
        Dim cmLAB1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LAB', RESEED, 0)", cn)
        Dim sLABD As String = "DELETE FROM LABDOC"
        Dim cmLABD As New SqlClient.SqlCommand(sLABD, cn)
        Dim cmLABD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LABDOC', RESEED, 0)", cn)
        Dim sLFT As String = "DELETE FROM LFT"
        Dim cmLFT As New SqlClient.SqlCommand(sLFT, cn)
        Dim cmLFT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LFT', RESEED, 0)", cn)
        Dim sLOSS As String = "DELETE FROM LOSS"
        Dim cmLOSS As New SqlClient.SqlCommand(sLOSS, cn)
        Dim cmLOSS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LOSS', RESEED, 0)", cn)
        Dim sM As String = "DELETE FROM MAIN"
        Dim cmM As New SqlClient.SqlCommand(sM, cn)
        Dim cmM1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('MAIN', RESEED, 0)", cn)
        Dim sMO As String = "DELETE FROM MOSTAFEED"
        Dim cmMO As New SqlClient.SqlCommand(sMO, cn)
        Dim cmMO1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('MOSTAFEED', RESEED, -1)", cn)
        Dim sPH As String = "DELETE FROM PHARMACY"
        Dim cmPH As New SqlClient.SqlCommand(sPH, cn)
        Dim cmPH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('PHARMACY', RESEED, 0)", cn)
        Dim sPRT As String = "DELETE FROM PROTHONBIN_TEST"
        Dim cmPRT As New SqlClient.SqlCommand(sPRT, cn)
        Dim cmPRT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('PROTHONBIN_TEST', RESEED, 0)", cn)
        Dim sR As String = "DELETE FROM REPORT"
        Dim cmR As New SqlClient.SqlCommand(sR, cn)
        Dim cmR1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('REPORT', RESEED, 0)", cn)
        Dim sRFT As String = "DELETE FROM LAB"
        Dim cmRFT As New SqlClient.SqlCommand(sRFT, cn)
        Dim cmRFT1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('LAB', RESEED, 0)", cn)
        Dim sSAD As String = "DELETE FROM SADAD"
        Dim cmSAD As New SqlClient.SqlCommand(sSAD, cn)
        Dim cmSAD1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('SADAD', RESEED, 0)", cn)
        Dim sSA As String = "DELETE FROM SEMEN_ANALYSIS"
        Dim cmSA As New SqlClient.SqlCommand(sSA, cn)
        Dim cmSA1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('SEMEN_ANALYSIS', RESEED, 0)", cn)
        Dim sSER As String = "DELETE FROM SEROLOGY"
        Dim cmSER As New SqlClient.SqlCommand(sSER, cn)
        Dim cmSER1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('SEROLOGY', RESEED, 0)", cn)
        Dim sTOR As String = "DELETE FROM TIROID"
        Dim cmTOR As New SqlClient.SqlCommand(sTOR, cn)
        Dim cmTOR1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TIROID', RESEED, 0)", cn)
        Dim sTORCH As String = "DELETE FROM TORCH"
        Dim cmTORCH As New SqlClient.SqlCommand(sTORCH, cn)
        Dim cmTORCH1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TORCH', RESEED, 0)", cn)
        Dim sTP As String = "DELETE FROM TREATMENT_PLANING"
        Dim cmTP As New SqlClient.SqlCommand(sTP, cn)
        Dim cmTP1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TREATMENT_PLANING', RESEED, 0)", cn)
        Dim sTV As String = "DELETE FROM TREATMENT_VISITS"
        Dim cmTV As New SqlClient.SqlCommand(sTV, cn)
        Dim cmTV1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('TREATMENT_VISITS', RESEED, 0)", cn)
        Dim sU As String = "DELETE FROM URINE"
        Dim cmU As New SqlClient.SqlCommand(sU, cn)
        Dim cmU1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('URINE', RESEED, 0)", cn)
        Dim sUS As String = "DELETE FROM USERS"
        Dim cmUS As New SqlClient.SqlCommand(sUS, cn)
        Dim cmUS1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('USERS', RESEED, -1)", cn)
        Dim sV As String = "DELETE FROM VIROLOGY"
        Dim cmV As New SqlClient.SqlCommand(sV, cn)
        Dim cmV1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('VIROLOGY', RESEED, 0)", cn)
        Dim sW As String = "DELETE FROM WIDAL_TEST"
        Dim cmW As New SqlClient.SqlCommand(sW, cn)
        Dim cmW1 As New SqlClient.SqlCommand("DBCC CHECKIDENT('WIDAL_TEST', RESEED, 0)", cn)
        Dim sWTY As String = "DELETE FROM TYPEEYWAA"
        Dim cmWTY As New SqlClient.SqlCommand(sWTY, cn)
        Dim cmW1TY As New SqlClient.SqlCommand("DBCC CHECKIDENT('TYPEEYWAA', RESEED, 0)", cn)
        'Try
        cmY.ExecuteNonQuery()
        cmM.ExecuteNonQuery()
        cmK.ExecuteNonQuery()
        cmk1.ExecuteNonQuery()
        cmJ.ExecuteNonQuery()
        cmj1.ExecuteNonQuery()
        cmDOC.ExecuteNonQuery()
        cmDOC1.ExecuteNonQuery()
        cmCDOC.ExecuteNonQuery()
        cmCDOC1.ExecuteNonQuery()
        cmFDOC.ExecuteNonQuery()
        cmfDOC1.ExecuteNonQuery()
        cmFTDOC.ExecuteNonQuery()
        cmftDOC1.ExecuteNonQuery()
        cmKAB.ExecuteNonQuery()
        cmKAB1.ExecuteNonQuery()
        cmMDOC.ExecuteNonQuery()
        cmMDOC1.ExecuteNonQuery()
        cmTAH.ExecuteNonQuery()
        cmTDOC.ExecuteNonQuery()
        cmAMA.ExecuteNonQuery()
        cmAMAM.ExecuteNonQuery()
        cmAP.ExecuteNonQuery()
        cmBIO.ExecuteNonQuery()
        cmCBC.ExecuteNonQuery()
        cmDNK.ExecuteNonQuery()
        cmDR.ExecuteNonQuery()
        cmD.ExecuteNonQuery()
        cmEH.ExecuteNonQuery()
        cmEL.ExecuteNonQuery()
        cmHA.ExecuteNonQuery()
        cmHD.ExecuteNonQuery()
        cmH.ExecuteNonQuery()
        cmHAS.ExecuteNonQuery()
        cmJAD.ExecuteNonQuery()
        cmJAM.ExecuteNonQuery()
        cmJAS.ExecuteNonQuery()
        cmJKT.ExecuteNonQuery()
        cmJK.ExecuteNonQuery()
        cmJS.ExecuteNonQuery()
        cmJSH.ExecuteNonQuery()
        cmJT.ExecuteNonQuery()
        cmJTGH.ExecuteNonQuery()
        cmKA.ExecuteNonQuery()
        cmLAB.ExecuteNonQuery()
        cmLABD.ExecuteNonQuery()
        cmLFT.ExecuteNonQuery()
        cmLOSS.ExecuteNonQuery()
        cmMO.ExecuteNonQuery()
        cmPH.ExecuteNonQuery()
        cmPRT.ExecuteNonQuery()
        cmR.ExecuteNonQuery()
        cmRFT.ExecuteNonQuery()
        cmSAD.ExecuteNonQuery()
        cmSA.ExecuteNonQuery()
        cmSER.ExecuteNonQuery()
        cmTOR.ExecuteNonQuery()
        cmTORCH.ExecuteNonQuery()
        cmTP.ExecuteNonQuery()
        cmTV.ExecuteNonQuery()
        cmU.ExecuteNonQuery()
        cmUS.ExecuteNonQuery()
        cmV.ExecuteNonQuery()
        cmW.ExecuteNonQuery()
        cmDN.ExecuteNonQuery()
        cmWTY.ExecuteNonQuery()


        cmMY.ExecuteNonQuery()
        cmTAH1.ExecuteNonQuery()
        cmTDOC1.ExecuteNonQuery()
        cmAMA1.ExecuteNonQuery()
        cmAMAM1.ExecuteNonQuery()
        cmAP1.ExecuteNonQuery()
        cmBIO1.ExecuteNonQuery()
        cmCBC1.ExecuteNonQuery()
        cmDN1.ExecuteNonQuery()
        cmDNK1.ExecuteNonQuery()
        cmDR1.ExecuteNonQuery()
        cmD1.ExecuteNonQuery()
        cmEH1.ExecuteNonQuery()
        cmEL1.ExecuteNonQuery()
        cmHA1.ExecuteNonQuery()
        cmHD1.ExecuteNonQuery()
        cmH1.ExecuteNonQuery()
        cmHAS1.ExecuteNonQuery()
        cmJAD1.ExecuteNonQuery()
        cmJAM1.ExecuteNonQuery()
        cmJAS1.ExecuteNonQuery()
        cmJKT1.ExecuteNonQuery()
        cmJK1.ExecuteNonQuery()
        cmJS1.ExecuteNonQuery()
        cmJSH1.ExecuteNonQuery()
        cmJT1.ExecuteNonQuery()
        cmJTGH1.ExecuteNonQuery()
        cmKA1.ExecuteNonQuery()
        cmLAB1.ExecuteNonQuery()
        cmLABD1.ExecuteNonQuery()
        cmLFT1.ExecuteNonQuery()
        cmLOSS1.ExecuteNonQuery()
        cmM1.ExecuteNonQuery()
        cmMO1.ExecuteNonQuery()
        cmPH1.ExecuteNonQuery()
        cmPRT1.ExecuteNonQuery()
        cmR1.ExecuteNonQuery()
        cmRFT1.ExecuteNonQuery()
        cmSAD1.ExecuteNonQuery()
        cmSA1.ExecuteNonQuery()
        cmSER1.ExecuteNonQuery()
        cmTOR1.ExecuteNonQuery()
        cmTORCH1.ExecuteNonQuery()
        cmTP1.ExecuteNonQuery()
        cmTV1.ExecuteNonQuery()
        cmU1.ExecuteNonQuery()
        cmUS1.ExecuteNonQuery()
        cmV1.ExecuteNonQuery()
        cmW1.ExecuteNonQuery()
        cmW1TY.ExecuteNonQuery()
        Call Class4.CONNIC()
        MsgBox("تم تصفير قاعدة البيانات")
        End

    End Sub

    Private Sub تسجيلالنظامToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تسجيلالنظامToolStripMenuItem.Click
        Dim f As New FrmActivation
        f.ShowDialog()
    End Sub

    Private Sub المصروفاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles المصروفاتToolStripMenuItem.Click
        procedx = "المصروفات"
        Call Class1.proced()
        Me.Hide()
        Dim F As New FrmExpenses
        F.ShowDialog()
        Me.Show()
    End Sub

    Private Sub تقريرالحركةاليوميةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تقريرالحركةاليوميةToolStripMenuItem.Click
        FP = 2
        Dim F As New FrmDateSelector1
        F.ShowDialog()
    End Sub

    Private Sub الملخصاليوميللعيادةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الملخصاليوميللعيادةToolStripMenuItem.Click
        procedx = "تقرير الخلاصه اليوميه"
        Call Class1.proced()
        sakprint = 4
        Dim frm As New FrmDateSelector2
        frm.ShowDialog()
    End Sub
End Class
