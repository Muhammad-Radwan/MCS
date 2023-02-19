Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Text
Imports System.Globalization
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing

Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Data
Imports System.Linq

Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FrmLodging
    Friend KESEM_P As String
    Friend NAMEC As String
    Friend USER_NAME As String
    Friend fnx As String
    Friend namex As String
    Friend agex As String
    Friend sexx As String
    Friend nox As String
    Friend dateex As String
    Friend timex As String
    Friend mox As String
    Friend TEX As String
    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Class1.CONNIC()
            Dim s As String = "select * from main where namex=@xxx1 "
            Using cm As New SqlClient.SqlCommand(s, cn)
                cm.Parameters.AddWithValue("@xxx1", ComboBox1.Text)
                Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    Me.TextBox2.Text = rd!fnumber
                    rd.Close()
                    'CALL CLASS4.CONNIC()
                Else
                    'CALL CLASS4.CONNIC()
                End If
                'end using
            End Using

            cn.Open()
            If Val(Me.ComboBox1.Text) = 0 Then

            End If
            Call Class1.CONNIC()
            Dim sn As String = "select * from main where fnumber=@xxx1 "
            Using cmn As New SqlClient.SqlCommand(sn, cn)
                cmn.Parameters.AddWithValue("@xxx1", Val(ComboBox1.Text))
                Dim rdn As SqlClient.SqlDataReader = cmn.ExecuteReader
                If rdn.Read = True Then
                    Me.ComboBox1.Text = rdn!namex
                    Me.TextBox2.Text = rdn!fnumber
                    rdn.Close()
                    'Else
                    '    m5 = 1
                    '    Dim k As Integer = 0
                    '    Do While k < 100
                    '        Dim i As Integer
                    '        i = m5
                    '        Dim s2 As String = "select * from main where fnumber=@xxx1"
                    '        Dim cm1 As New SqlClient.SqlCommand(s2, cn)
                    '        cm1.Parameters.AddWithValue("@xxx1", i)
                    '        Dim rd1 As SqlClient.SqlDataReader
                    '        rd1 = cm1.ExecuteReader
                    '        Do While rd1.Read = True
                    '            i = i + 1
                    '            Dim ss1 As String = "select * from main where fnumber=@xx1"
                    '            Dim cmm1 As New SqlClient.SqlCommand(ss1, cn)
                    '            cmm1.Parameters.AddWithValue("@xx1", i)
                    '            rd1 = cmm1.ExecuteReader
                    '            m5 = i
                    '        Loop
                    '        rd1.Close()
                    '        k = k + 1
                    '    Loop
                    '    Me.TextBox2.Text = m5
                End If
                'End If
            End Using
            'end using
            'Dim s12 As String = "select * from main "
            'Dim aad2 As New SqlClient.SqlDataAdapter(s12, cn)
            'Dim dss2 As New DataSet
            'dss2.Clear()
            'aad2.Fill(dss2, "main")
            'Dim vd2 As New DataView(dss2.Tables("main"))
            'vd2.RowFilter = "fnumber=" & "'" & TextBox2.Text & "'" & ""
            'Me.DataGridView2.DataMember = ""
            'DataGridView2.DataSource = vd2
            Call Class1.CONNIC()

            Dim s1 As String = "select * from kashef "
            Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            Dim dss As New DataSet
            dss.Clear()
            aad.Fill(dss, "kashef")
            Dim vd As New DataView(dss.Tables("kashef"))
            vd.RowFilter = "fnumber=" & "'" & TextBox2.Text & "'" & ""
            Me.DataGridView1.DataMember = ""
            DataGridView1.DataSource = vd
            Me.ComboBox1.Focus()
            'end using
            'end using
            'end using
            'Call Class4.CONNIC()

        End If

    End Sub

    Private Sub ComboBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox1.MouseClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Try
        If ComboBox1.SelectedIndex = -1 Then
            Return
        End If
        Call Class1.CONNIC()
        Dim s5 As String = "select * from main where namex=@xx1"
        Using cm5 As New SqlClient.SqlCommand(s5, cn)
            cm5.Parameters.AddWithValue("@xx1", Trim(ComboBox1.Text))
            Dim rd5 As SqlClient.SqlDataReader = cm5.ExecuteReader
            If rd5.Read = True Then
                Me.TextBox10.Text = rd5!fnumber
                Dim s16 As String = "select * from kashef "
                Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
                Dim dss As New DataSet
                dss.Clear()
                aad.Fill(dss, "kashef")
                Dim vd As New DataView(dss.Tables("kashef"))
                vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND fnumber=" & "'" & Me.TextBox10.Text & "'" & ""
                'vd.RowFilter = "doctorname=" & "'" & Me.ComboBox2.Text & "'" & ""
                Me.DataGridView1.DataMember = ""
                DataGridView1.DataSource = vd
                Me.ComboBox1.Text = Trim(rd5!namex)
                Me.TextBox11.Text = Trim(rd5!namex)
                Me.ComboBox7.Text = Trim(rd5!SEX)
                Me.ComboBox8.Text = Trim(rd5!GENDER)
                Me.TextBox9.Text = rd5!AGE
                Me.NumericUpDown2.Text = Val(TextBox9.Text)
                Me.ComboBox10.Text = Mid(TextBox9.Text, 3, 5)
                Me.TextBox24.Text = rd5!ADDRESS
                Me.TextBox26.Text = rd5!PHONE
                Me.TextBox15.Text = rd5!IDCARD
                rd5.Close()
                Call Class1.CONNIC()
                Dim skk As String = "select * from EYWAA where fnumber=@fnumber and MOGHADRA=@MOGHADRA "
                Using cmkk As New SqlClient.SqlCommand(skk, cn)
                    cmkk.Parameters.AddWithValue("@fnumber", Trim(TextBox10.Text))
                    cmkk.Parameters.AddWithValue("@MOGHADRA", False)
                    Using rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
                        If rdkk.Read = True Then
                            'While rdkk.Read = True
                            Label17.Text = CInt(rdkk!KESEM)
                            Call Class1.CONNIC()
                            Dim s5Y As String = "select * from KESEM where IDK=@IDK"
                            Using cm5Y As New SqlClient.SqlCommand(s5Y, cn)
                                cm5Y.Parameters.AddWithValue("@IDK", CInt(Label17.Text))
                                Dim rd5Y As SqlClient.SqlDataReader = cm5Y.ExecuteReader
                                If rd5Y.Read = True Then
                                    ComboBox6.Text = rd5Y!KESEM
                                End If
                                rd5Y.Close()
                            End Using
                            NumericUpDown1.Text = CInt(rdkk!NOSAREER)
                            DateTimePicker2.Text = CDate(rdkk!DATEEYWAA)
                            DateTimePicker4.Text = CDate(rdkk!TIMEEYWAA)
                            ComboBox9.Text = Trim(rdkk!EYWAAT)
                            Call Class1.CONNIC()
                            Dim s5YT As String = "select * from TYPEEYWAA where IDEY=@IDEY"
                            Using cm5YT As New SqlClient.SqlCommand(s5YT, cn)
                                cm5YT.Parameters.AddWithValue("@IDEY", CInt(ComboBox9.Text))
                                Dim rd5YT As SqlClient.SqlDataReader = cm5YT.ExecuteReader
                                If rd5YT.Read = True Then
                                    ComboBox9.Text = Trim(rd5YT!EYWAATYPE)
                                End If
                                rd5YT.Close()
                            End Using
                            TextBox22.Text = Trim(rdkk!MASNAME)
                            Label13.Text = CDbl(rdkk!SE3REYWAA)
                            TextBox27.Text = rdkk!ETHBATNO
                            TextBox36.Text = CInt(rdkk!NOFATORA)
                            'Else
                            'Timer2.Stop()
                            'Label21.Text = ""
                            'Label21.BackColor = Color.Transparent
                            'End While

                        End If
                        rdkk.Close()
                    End Using

                End Using
                'Button3.Enabled = False
                Button5.Enabled = True
                Button2.Enabled = True
                Button7.Enabled = True
                Button6.Enabled = True
                Button8.Enabled = True
                Button9.Enabled = True
            Else
                Me.TextBox2.Text = ""
                'Timer2.Stop()
                'Label21.Text = ""
                'Label21.BackColor = Color.Transparent
            End If
            rd5.Close()
        End Using

        'Catch ex As Exception

        'End Try
        'Dim skk As String = "select * from kashef where fnumber=@fnumber and doctorname=@doctorname and baky<>@baky AND CONF=@CONF "

        'Button2.Enabled = True
        'Button2.Visible = True
        'End If
        'Call Class4.CONNIC()

    End Sub

    Private Sub ComboBox1_SizeChanged(sender As Object, e As EventArgs) Handles ComboBox1.SizeChanged

    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        ComboBox1.MaxLength = 32

        'If Trim(ComboBox1.Text) = Trim("") Then
        '    'Button2.Enabled = False
        '    'Timer2.Stop()
        '    TextBox2.Text = ""
        '    'Label21.Text = ""
        '    'Label21.BackColor = Color.Transparent
        'Else
        '    Call Class1.CONNIC()

        '    Dim s5 As String = "select * from main where namex=@xx1"
        '    Using cm5 As New SqlClient.SqlCommand(s5, cn)
        '        cm5.Parameters.AddWithValue("@xx1", Trim(ComboBox1.Text))
        '        Dim rd5 As SqlClient.SqlDataReader = cm5.ExecuteReader
        '        If rd5.Read = True Then
        '            Me.TextBox2.Text = rd5!fnumber
        '            Me.ComboBox1.Text = Trim(rd5!namex)
        '            rd5.Close()
        '            'Dim skk As String = "select * from kashef where fnumber=@fnumber and baky<>@baky AND CONF=@CONF "
        '            'Using cmkk As New SqlClient.SqlCommand(skk, cn)
        '            '    cmkk.Parameters.AddWithValue("@fnumber", Trim(TextBox2.Text))
        '            '    'cmkk.Parameters.AddWithValue("@doctorname", ComboBox2.Text)
        '            '    cmkk.Parameters.AddWithValue("@baky", CDbl(0))
        '            '    cmkk.Parameters.AddWithValue("@CONF", True)
        '            '    Using rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
        '            '        If rdkk.Read = True Then
        '            '            Label18.Text = CInt(rdkk!Esalno)
        '            '            'Label13.Text = CDbl(rdkk!kemat)
        '            '            'TextBox10.Text = CDbl(rdkk!madfoo)
        '            '            'TextBox16.Text = CDbl(rdkk!madfoo)
        '            '            'TextBox11.Text = CDbl(rdkk!baky)
        '            '            Label21.Text = CDbl(rdkk!baky)
        '            '            Timer2.Start()
        '            '        Else
        '            '            'Timer2.Stop()
        '            '            'Label21.Text = ""
        '            '            'Label21.BackColor = Color.Transparent
        '            '        End If
        '            '        rdkk.Close()
        '            '    End Using
        '            'End Using

        '        Else
        '            'Me.TextBox2.Text = ""
        '            'Timer2.Stop()
        '            'Label21.Text = ""
        '            'Label21.BackColor = Color.Transparent
        'End If
        '        rd5.Close()
        '    End Using
        '    'Dim skk As String = "select * from kashef where fnumber=@fnumber and doctorname=@doctorname and baky<>@baky AND CONF=@CONF "

        '    Button2.Enabled = True
        '    Button2.Visible = True
        '    Call Class4.CONNIC()

        'End If

    End Sub

    Private Sub EYWAA_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'If Button4.Enabled = False Then
        '    Dim sd As String = "delete from MAIN where FNUMBER=@FNUMBER"
        '    Using cd As New SqlClient.SqlCommand(sd, cn)
        '        cd.Parameters.AddWithValue("@FNUMBER", fnumberx)
        '        Dim sdk As String = "delete from EYWAA where FNUMBER=@FNUMBER"
        '        Using cdk As New SqlClient.SqlCommand(sdk, cn)
        '            cdk.Parameters.AddWithValue("@FNUMBER", fnumberx)
        '            'If MsgBox("هل تريد الغاء الاجراء", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '            Try
        '                cd.ExecuteNonQuery()
        '                cdk.ExecuteNonQuery()
        '            Catch ex As Exception

        '            End Try
        '            'End If
        '        End Using
        '    End Using
        '    Dim cmM As New SqlClient.SqlCommand("DBCC CHECKIDENT('MAIN', RESEED, 1000)", cn)
        '    Dim cmMY As New SqlClient.SqlCommand("DBCC CHECKIDENT('EYWAA', RESEED, 0)", cn)
        '    cmM.ExecuteNonQuery()
        '    cmMY.ExecuteNonQuery()
        '    CALL CLASS4.CONNIC()
        'End If

    End Sub

    Private Sub EYWAA_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Button4.Enabled = False Then
            Call Class1.CONNIC()
            Dim sd As String = "delete from MAIN where FNUMBER=@FNUMBER"
            Using cd As New SqlClient.SqlCommand(sd, cn)
                cd.Parameters.AddWithValue("@FNUMBER", fnumberx)
                Dim sdk As String = "delete from EYWAA where FNUMBER=@FNUMBER"
                Using cdk As New SqlClient.SqlCommand(sdk, cn)
                    cdk.Parameters.AddWithValue("@FNUMBER", fnumberx)
                    'If MsgBox("هل تريد الغاء الاجراء", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try
                        cd.ExecuteNonQuery()
                        cdk.ExecuteNonQuery()
                    Catch ex As Exception
                    End Try
                    'End If
                End Using
            End Using
            Dim Str As String = "SELECT MAX(FNUMBER) FROM MAIN "
            Dim cmd As New SqlClient.SqlCommand(Str, cn)
            If IsDBNull(cmd.ExecuteScalar) = True Then
                fnumberx = 1000
            Else
                fnumberx = cmd.ExecuteScalar
            End If

            Dim cmM As New SqlClient.SqlCommand("DBCC CHECKIDENT('MAIN', RESEED," & fnumberx & ")", cn)
            Dim cmMY As New SqlClient.SqlCommand("DBCC CHECKIDENT('EYWAA', RESEED, 0)", cn)
            cmM.ExecuteNonQuery()
            cmMY.ExecuteNonQuery()
            'Call Class4.CONNIC()
        End If

    End Sub

    Private Sub EYWAA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Class1.CONNIC()
        ''TODO: This line of code loads data into the 'DbsbhDataSet8.APPOINTMENTVIEW' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTVIEWTableAdapter.Fill(Me.DbsbhDataSet8.APPOINTMENTVIEW)
        ''TODO: This line of code loads data into the 'DbsbhDataSet8.kashef' table. You can move, or remove it, as needed.
        'Me.KashefTableAdapter.Fill(Me.DbsbhDataSet8.kashef)
        ''TODO: This line of code loads data into the 'DbsbhDataSet8.main' table. You can move, or remove it, as needed.
        'Me.MainTableAdapter.Fill(Me.DbsbhDataSet8.main)
        Dim sk1 As String
        sk1 = "select * from EYWAA_V WHERE MOGHADRA=" & "" & 0 & ""
        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
        Dim dsk1 As New DataSet
        adk1.Fill(dsk1, "EYWAA_V")
        ComboBox1.DataSource = dsk1.Tables(0)
        ComboBox1.DisplayMember = "NAMEX"
        ComboBox1.SelectedIndex = -1
        'end using
        'end using

        Dim sk2 As String
        sk2 = "select * from dn"
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        ComboBox2.SelectedIndex = -1
        'end using
        'end using

        Dim sk4 As String
        sk4 = "select * from Mostafeed"
        Dim adk4 As New SqlClient.SqlDataAdapter(sk4, cn)
        Dim dsk4 As New DataSet
        adk4.Fill(dsk4, "Mostafeed")
        ComboBox4.DataSource = dsk4.Tables(0)
        ComboBox4.DisplayMember = "NameM"
        ComboBox4.SelectedIndex = -1
        'end using
        'end using
        Dim sk42 As String
        sk42 = "select * from KESEM"
        Dim adk42 As New SqlClient.SqlDataAdapter(sk42, cn)
        Dim dsk42 As New DataSet
        adk42.Fill(dsk42, "KESEM")
        ComboBox6.DataSource = dsk42.Tables(0)
        ComboBox6.DisplayMember = "KESEM"
        ComboBox6.SelectedIndex = -1

        Dim sk42Y As String
        sk42Y = "select * from TYPEEYWAA"
        Dim adk42Y As New SqlClient.SqlDataAdapter(sk42Y, cn)
        Dim dsk42Y As New DataSet
        adk42Y.Fill(dsk42Y, "TYPEEYWAA")
        ComboBox9.DataSource = dsk42Y.Tables(0)
        ComboBox9.DisplayMember = "EYWAATYPE"
        ComboBox9.SelectedIndex = -1

        Dim sk428 As String
        sk428 = "select * from GENDER_V"
        Dim adk428 As New SqlClient.SqlDataAdapter(sk428, cn)
        Dim dsk428 As New DataSet
        adk428.Fill(dsk428, "GENDER_V")
        ComboBox8.DataSource = dsk428.Tables(0)
        ComboBox8.DisplayMember = "GENDER"
        ComboBox8.SelectedIndex = -1

        Dim sk3 As String
        sk3 = "select * from Ejraa"
        Dim adk3 As New SqlClient.SqlDataAdapter(sk3, cn)
        Dim dsk3 As New DataSet
        adk3.Fill(dsk3, "Ejraa")
        ComboBox3.DataSource = dsk3.Tables(0)
        ComboBox3.DisplayMember = "Ejraa"
        'ComboBox3.SelectedIndex = -1
        ComboBox3.Text = "كشف"
        'end using
        'end using

        'Me.TextBox3.Focus()
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        DataGridView1.DataSource = ""
        'DataGridView2.DataSource = ""
        If ewaa = True Then
            Label12.Text = sano
            GroupBox10.Visible = True
            ComboBox3.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox3.Text = "إيواء"
            ComboBox3.Enabled = False
            ewaa = False
        End If
        Dim k As Integer = 1
        Dim i As Integer = 0
        Do While k < 100
            Call Class1.CONNIC()
            Dim sB As String = "select * from KESEM where IDK=@IDK "
            Dim cmB As New SqlClient.SqlCommand(sB, cn)
            cmB.Parameters.AddWithValue("@IDK", i)
            Dim rdB As SqlClient.SqlDataReader
            rdB = cmB.ExecuteReader
            Do While rdB.Read = True
                If i = 0 Then
                    B0.Visible = True
                    B0.Text = rdB!KESEM
                ElseIf i = 1 Then
                    B1.Visible = True
                    B1.Text = rdB!KESEM
                ElseIf i = 2 Then
                    B2.Visible = True
                    B2.Text = rdB!KESEM
                ElseIf i = 3 Then
                    B3.Visible = True
                    B3.Text = rdB!KESEM
                    'ElseIf i = 4 Then
                    '    B4.Visible = True
                    '    B4.Text = rdB!KESEM
                    'ElseIf i = 5 Then
                    '    B5.Visible = True
                    '    B5.Text = rdB!KESEM
                    'ElseIf i = 6 Then
                    '    B6.Visible = True
                    '    B6.Text = rdB!KESEM
                    'ElseIf i = 7 Then
                    '    B7.Visible = True
                    '    B7.Text = rdB!KESEM
                    'ElseIf i = 8 Then
                    '    B8.Visible = True
                    '    B8.Text = rdB!KESEM
                    'ElseIf i = 9 Then
                    '    B9.Visible = True
                    '    B9.Text = rdB!KESEM
                    'ElseIf i = 10 Then
                    '    B10.Visible = True
                    '    B10.Text = rdB!KESEM
                    'ElseIf i = 11 Then
                    '    B11.Visible = True
                    '    B11.Text = rdB!KESEM
                    'ElseIf i = 12 Then
                    '    B12.Visible = True
                    '    B12.Text = rdB!KESEM
                    'ElseIf i = 13 Then
                    '    B13.Visible = True
                    '    B13.Text = rdB!KESEM
                    'ElseIf i = 14 Then
                    '    B14.Visible = True
                    '    B14.Text = rdB!KESEM
                    'ElseIf i = 15 Then
                    '    B15.Visible = True
                    '    B15.Text = rdB!KESEM
                    'ElseIf i = 16 Then
                    '    B16.Visible = True
                    '    B16.Text = rdB!KESEM
                    'ElseIf i = 17 Then
                    '    B17.Visible = True
                    '    B17.Text = rdB!KESEM
                    'ElseIf i = 18 Then
                    '    B18.Visible = True
                    '    B18.Text = rdB!KESEM
                    'ElseIf i = 19 Then
                    '    B19.Visible = True
                    '    B19.Text = rdB!KESEM
                    'ElseIf i = 20 Then
                    '    B20.Visible = True
                    '    B20.Text = rdB!KESEM
                End If
                i = i + 1
            Loop
            rdB.Close()
            k = k + 1
        Loop
        TextBox10.Text = ""
        TextBox36.Text = ""
        TextBox11.Text = ""
        TextBox9.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        TextBox24.Text = ""
        TextBox26.Text = ""
        TextBox15.Text = ""
        ComboBox6.Text = ""
        NumericUpDown1.Value = 1
        NumericUpDown2.Value = 1
        DateTimePicker2.Value = Date.Today.Date
        DateTimePicker4.Text = TimeString
        ComboBox9.Text = ""
        ComboBox10.Text = ""
        Label13.Text = ""
        TextBox22.Text = ""
        TextBox27.Text = ""
        'TextBox28.Text = ""
        'Button3.Enabled = False
        Button4.Enabled = True
        'Button5.Enabled = False
        'Button2.Enabled = False
        'Button7.Enabled = False
        'Button6.Enabled = False
        'Button8.Enabled = False
        'Button9.Enabled = False
        'Button10.Enabled = False
        TextBox10.ReadOnly = False
        ComboBox1.Enabled = True
        ComboBox4.Enabled = True
        DateTimePicker3.Enabled = True
        'Call Class4.CONNIC()

    End Sub
    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B0.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        'Me.ComboBox1.Text = ""
        'Me.ComboBox3.Text = ""
        'Me.ComboBox4.Text = ""
        'Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B0.Text
        TextBox8.Text = B0.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B0.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label15.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
            GroupBox31.Visible = True
        Else
            GroupBox31.Visible = False
        End If
        'Call Class4.CONNIC()
        TextBox34.Focus()
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        'Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        'Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B1.Text
        TextBox8.Text = B1.Text
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B1.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                'Me.Label13.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        'Call Class4.CONNIC()

    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        'Me.ComboBox1.Text = ""
        'Me.ComboBox3.Text = ""
        'Me.ComboBox4.Text = ""
        'Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B0.Text
        TextBox8.Text = B2.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B2.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label15.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
            GroupBox31.Visible = True
        Else
            GroupBox31.Visible = False
        End If
        'Call Class4.CONNIC()
        TextBox34.Focus()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If String.IsNullOrWhiteSpace(ComboBox1.Text) = True Then
            MsgBox("عفوا .. يرجى اختيار اسم المريض")
            ComboBox1.Focus()
            Return
        End If
        Call Class1.CONNIC()
        Dim s5 As String = "select * from main where namex=@xx1"
        Using cm5 As New SqlClient.SqlCommand(s5, cn)
            cm5.Parameters.AddWithValue("@xx1", Trim(ComboBox1.Text))
            Dim rd5 As SqlClient.SqlDataReader = cm5.ExecuteReader
            If rd5.Read = True Then
                fnumberx = TextBox10.Text
                USER_NAME = user
                fnx = TextBox10.Text
                namex = TextBox11.Text
                agex = CStr(NumericUpDown2.Text) + " " + CStr(ComboBox10.Text)
                sexx = ComboBox7.Text
                nox = CStr(NumericUpDown2.Text)
                dateex = Format(DateTimePicker2.Value, "yyyy-MM-dd")
                timex = CStr(Format(DateTimePicker4.Value, "HH:mm"))
                mox = TextBox22.Text
                TEX = ComboBox9.Text
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
                Dim crReportDocument As New CrystalReport41(), cri As String
                crReportDocument.Load("CrystalReport41.rpt")
                'cri = "{EYWAA.FNUMBER}=" & "" & fnumberx & ""
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
                KESEM_P = ComboBox6.Text
                Dim RM As Resources.ResourceManager
                RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
                NAMEC = RM.GetString("NAMECLINIC")
                crReportDocument.SetParameterValue(0, Me.NAMEC)
                crReportDocument.SetParameterValue(1, Me.KESEM_P)
                crReportDocument.SetParameterValue(2, Me.USER_NAME)
                crReportDocument.SetParameterValue(3, Me.fnx)
                crReportDocument.SetParameterValue(4, Me.namex)
                crReportDocument.SetParameterValue(5, Me.agex)
                crReportDocument.SetParameterValue(6, Me.sexx)
                crReportDocument.SetParameterValue(7, Me.nox)
                crReportDocument.SetParameterValue(8, Me.dateex)
                crReportDocument.SetParameterValue(9, Me.timex)
                crReportDocument.SetParameterValue(10, Me.mox)
                crReportDocument.SetParameterValue(11, Me.TEX)
                crReportDocument.RecordSelectionFormula = cri
                crReportDocument.PrintOptions.PrinterName = My.Settings.printerx2
                crReportDocument.PrintToPrinter(1, True, 0, 0)
                crReportDocument.Close()
                crReportDocument.Dispose()

                '-----------------------------------------------------------------------------------
                reader.Close()



                'Dim cr1 As New CrystalReport41
                ''Dim cr1 As New CrystalReport41, cri As String
                ''cri = "{eywaa.FNUMBER}=" & "" & fnumberx & ""
                'KESEM_P = ComboBox6.Text
                'Dim RM As Resources.ResourceManager
                'RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
                'NAMEC = RM.GetString("NAMECLINIC")
                'cr1.SetParameterValue(0, Me.NAMEC)
                'cr1.SetParameterValue(1, Me.KESEM_P)
                'cr1.SetParameterValue(2, Me.USER_NAME)
                'cr1.SetParameterValue(3, Me.fnx)
                'cr1.SetParameterValue(4, Me.namex)
                'cr1.SetParameterValue(5, Me.agex)
                'cr1.SetParameterValue(6, Me.sexx)
                'cr1.SetParameterValue(7, Me.nox)
                'cr1.SetParameterValue(8, Me.dateex)
                'cr1.SetParameterValue(9, Me.timex)
                'cr1.SetParameterValue(10, Me.mox)
                'cr1.SetParameterValue(11, Me.TEX)
                ''cr1.RecordSelectionFormula = cri
                'cr1.PrintOptions.PrinterName = "PR"
                'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
                ''cr1.PrintOptions.PrinterName = "LK-TE212"
                'cr1.PrintToPrinter(1, False, 1, 1)
                'Call Class4.CONNIC()
            Else
                MsgBox("اسف .. ارجو اختيار اسم المريض")
                Return
            End If
        End Using

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrWhiteSpace(ComboBox1.Text) = False Then
            MsgBox("عفوا .. اضغط جديد")
            ComboBox1.Focus()
            Return
        End If

        If TextBox11.Text = "" Then
            MsgBox("يرجى إدخال اسم المريض")
            TextBox11.Focus()
        ElseIf ComboBox9.Text = "" Then
            MsgBox("يرجى اختيار نوع الايواء")
            ComboBox9.Focus()
        ElseIf ComboBox6.Text = "" Then
            MsgBox("يرجى اختيار القسم")
            ComboBox6.Focus()
        Else
            If ComboBox10.Text = "" Then
                ComboBox10.Text = "سنة"
            End If
            If ComboBox7.Text = "" Then
                ComboBox7.Text = "ذكر"
            End If
            If ComboBox8.Text = "" Then
                ComboBox8.Text = "ليبي"
            End If
            If TextBox24.Text = "" Then
                TextBox24.Text = "البيضاء"
            End If
            If TextBox15.Text = "" Then
                TextBox15.Text = "لا يوجد"
            End If
            If TextBox22.Text = "" Then
                TextBox22.Text = "لايوجد"
            End If
            If TextBox27.Text = "" Then
                TextBox27.Text = "لايوجد"
            End If
            If TextBox26.Text = "" Then
                TextBox26.Text = "لايوجد"
            End If
            Call Class1.CONNIC()

            Dim Str1 As String = "SELECT MAX(FNUMBER) FROM MAIN "
            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
            If IsDBNull(cmd1.ExecuteScalar) = True Then
                fnumberx = 1000
            Else
                fnumberx = cmd1.ExecuteScalar
            End If
            Dim Str2 As String = "SELECT MAX(NOFATORA) FROM EYWAA "
            Dim cmd2 As New SqlClient.SqlCommand(Str2, cn)
            If IsDBNull(cmd2.ExecuteScalar) = True Then
                NOFATORAX = 0
            Else
                NOFATORAX = cmd2.ExecuteScalar
            End If
            Dim cmMM As New SqlClient.SqlCommand("DBCC CHECKIDENT('MAIN', RESEED," & fnumberx & ")", cn)
            Dim cmMY As New SqlClient.SqlCommand("DBCC CHECKIDENT('EYWAA', RESEED," & NOFATORAX & ")", cn)
            Try
                cmMM.ExecuteNonQuery()
                cmMY.ExecuteNonQuery()
            Catch ex As Exception

            End Try

            Dim ss As String = "UPDATE main SET namex=@namex,age=@age,address=@address,husbend=@husbend,phone=@phone,idcard=@idcard,datex=@datex,CITY=@CITY,gender=@gender,sex=@sex WHERE FNUMBER=@FNUMBER"
            Dim cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@namex", TextBox11.Text)
            cmm.Parameters.AddWithValue("@age", Trim(NumericUpDown2.Text) + Trim(ComboBox10.Text))
            cmm.Parameters.AddWithValue("@address", TextBox24.Text)
            cmm.Parameters.AddWithValue("@husbend", "NONE")
            cmm.Parameters.AddWithValue("@phone", TextBox26.Text)
            cmm.Parameters.AddWithValue("@idcard", TextBox15.Text)
            cmm.Parameters.AddWithValue("@datex", Date.Today.Date)
            cmm.Parameters.AddWithValue("@CITY", "NONE")
            cmm.Parameters.AddWithValue("@gender", ComboBox8.Text)
            cmm.Parameters.AddWithValue("@sex", ComboBox7.Text)
            cmm.Parameters.AddWithValue("@FNUMBER", TextBox10.Text)

            Dim sse As String = "insert into EYWAA(FNUMBER,NOSAREER,SE3REYWAA,DAYZ,RASFATORA,MADFOO,BAKY,DISCOUNT,DATEEYWAA,DATEMOGHADRA,MOGHADRA,KESEM,TIMEEYWAA,TIMEMOGHADRA,MASNAME,ETHBATNO,DATEX,eywaat,user_name)values(@FNUMBER,@NOSAREER,@SE3REYWAA,@DAYZ,@RASFATORA,@MADFOO,@BAKY,@DISCOUNT,@DATEEYWAA,@DATEMOGHADRA,@MOGHADRA,@KESEM,@TIMEEYWAA,@TIMEMOGHADRA,@MASNAME,@ETHBATNO,@DATEX,@eywaat,@user_name)"
            Dim cmme As New SqlClient.SqlCommand(sse, cn)
            cmme.Parameters.AddWithValue("@FNUMBER", CInt(TextBox10.Text))
            cmme.Parameters.AddWithValue("@NOSAREER", CInt(NumericUpDown1.Value))
            cmme.Parameters.AddWithValue("@SE3REYWAA", CDbl(Label13.Text))
            cmme.Parameters.AddWithValue("@DAYZ", CInt(1))
            cmme.Parameters.AddWithValue("@RASFATORA", CDbl(Label13.Text))
            cmme.Parameters.AddWithValue("@MADFOO", CDbl(0))
            cmme.Parameters.AddWithValue("@BAKY", CDbl(Label13.Text))
            cmme.Parameters.AddWithValue("@DISCOUNT", CDbl(0))
            cmme.Parameters.AddWithValue("@DATEEYWAA", CDate(DateTimePicker2.Value.Date))
            cmme.Parameters.AddWithValue("@DATEMOGHADRA", CDate(DateTimePicker2.Value.Date))
            cmme.Parameters.AddWithValue("@MOGHADRA", False)
            cmme.Parameters.AddWithValue("@KESEM", CInt(Label17.Text))
            cmme.Parameters.AddWithValue("@TIMEEYWAA", DateTimePicker4.Value.TimeOfDay)
            cmme.Parameters.AddWithValue("@TIMEMOGHADRA", DateTimePicker4.Value.TimeOfDay)
            cmme.Parameters.AddWithValue("@MASNAME", Trim(TextBox22.Text))
            cmme.Parameters.AddWithValue("@ETHBATNO", Trim(TextBox27.Text))
            cmme.Parameters.AddWithValue("@DATEX", Date.Now)
            cmme.Parameters.AddWithValue("@eywaat", CInt(Label18.Text))
            cmme.Parameters.AddWithValue("@USER_NAME", Trim(user))

            Try
                cmm.ExecuteNonQuery()
                cmme.ExecuteNonQuery()
                MsgBox("تمت عملية الحجز")
                Dim sk1 As String
                sk1 = "select * from EYWAA_V WHERE MOGHADRA=" & "" & 0 & ""
                Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                Dim dsk1 As New DataSet
                adk1.Fill(dsk1, "EYWAA_V")
                ComboBox1.DataSource = dsk1.Tables(0)
                ComboBox1.DisplayMember = "NAMEX"
                ComboBox1.SelectedIndex = -1
                Me.TextBox1.Text = ""
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                Me.TextBox4.Text = ""
                Me.TextBox5.Text = ""
                Me.TextBox6.Text = ""
                Me.TextBox7.Text = ""
                Me.TextBox8.Text = ""
                Me.ComboBox1.Text = ""
                Me.TextBox1.Focus()
                Button4.Enabled = True
                EYWAA_Load(Nothing, Nothing)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
        'Call Class4.CONNIC()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox34.Text) Then
            TextBox34.Focus()
            Return
        End If
        If Double.Parse(TextBox34.Text) = 0 Then
            TextBox34.Focus()
            Return
        End If

        'If Me.TextBox3.Text = "" Then
        '    MsgBox("Insert Chair number")
        '    Me.TextBox3.Focus()
        'ElseIf Me.ComboBox1.Text = "" Then
        '    MsgBox("Insert Name")
        '    Me.ComboBox1.Focus()
        'ElseIf Me.ComboBox2.Text = "" Then
        '    Me.ComboBox2.Focus()
        '    MsgBox("Insert The Doctor Name")
        'ElseIf Me.Label13.Text = 0 Then
        '    MsgBox("أدخل قيمة الإجراء")
        '    TextBox15.Focus()
        'Else
        'm5 = 1
        'Dim k As Integer = 0
        'Do While k < 100
        '    Dim i As Integer
        '    i = m5
        '    Dim s1 As String = "select * from main where fnumber=@xx1"
        '    Dim cm1 As New SqlClient.SqlCommand(s1, cn)
        '    cm1.Parameters.AddWithValue("@xx1", i)
        '    Dim rd1 As SqlClient.SqlDataReader
        '    rd1 = cm1.ExecuteReader
        '    Do While rd1.Read = True
        '        i = i + 1
        '        Dim ss1 As String = "select * from main where fnumber=@xx1"
        '        Dim cmm1 As New SqlClient.SqlCommand(ss1, cn)
        '        cmm1.Parameters.AddWithValue("@xx1", i)
        '        rd1 = cmm1.ExecuteReader
        '        m5 = i
        '    Loop
        '    rd1.Close()
        '    k = k + 1
        'Loop
        ' Label6.Text = m5
        Call Class1.CONNIC()
        If TextBox2.Text = Trim("") Then
            Dim ss As String = "insert into main(namex,age,address,husbend,phone,idcard,datex,CITY,gender)values(@xx1,@xx3,@xx4,@xx5,@xx6,@xx7,@xx8,@xx9,@XX10)"
            Using cmm As New SqlClient.SqlCommand(ss, cn)
                cmm.Parameters.AddWithValue("@xx1", ComboBox1.Text)
                'cmm.Parameters.AddWithValue("@xx2", TextBox2.Text)
                cmm.Parameters.AddWithValue("@xx3", "0")
                cmm.Parameters.AddWithValue("@xx4", "لايوجد")
                cmm.Parameters.AddWithValue("@xx5", "لايوجد")
                cmm.Parameters.AddWithValue("@xx6", "لايوجد")
                cmm.Parameters.AddWithValue("@xx7", "لايوجد")
                cmm.Parameters.AddWithValue("@xx8", Date.Now.Date)
                cmm.Parameters.AddWithValue("@xx9", "لايوجد")
                cmm.Parameters.AddWithValue("@xx10", "لايوجد")
                Try
                    cmm.ExecuteNonQuery()

                Catch ex As Exception
                End Try
            End Using
        End If
        Dim s As String = "select * from main where namex=@xx1 "
        Using cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@xx1", ComboBox1.Text)
            Using rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    Me.TextBox2.Text = rd!fnumber
                End If
                rd.Close()
            End Using
        End Using
        'Dim skk As String = "select * from kashef where fnumber=@fnumber and doctorname=@doctorname and baky<>@baky "
        'Using cmkk As New SqlClient.SqlCommand(skk, cn)
        '    cmkk.Parameters.AddWithValue("@fnumber", TextBox2.Text)
        '    cmkk.Parameters.AddWithValue("@doctorname", ComboBox2.Text)
        '    cmkk.Parameters.AddWithValue("@baky", CDbl(0))
        '    Using rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
        '        If rdkk.Read = True Then
        '            Label18.Text = rdkk!Esalno
        '            M6 = rdkk!Esalno
        'Dim ss21k As String = "update kashef set fnumber=@fnumber,CHNO=@CHNO,DATEX=@DATEX,doctorname=@doctorname,KEMA=@KEMA,KEMAT=@KEMAT,MADFOO=@MADFOO,BAKY=@BAKY,conf=@conf,USER_NAME=@USER_NAME,idm=@idm,EJRAA=@EJRAA where Esalno=@Esalno"
        ''    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
        'Using cmm21 As New SqlClient.SqlCommand(ss21k, cn)
        '    cmm21.Parameters.AddWithValue("@fnumber", TextBox2.Text)
        '    cmm21.Parameters.AddWithValue("@CHNO", Me.Label1.Text)
        '    cmm21.Parameters.AddWithValue("@DATEX", Me.DateTimePicker3.Text)
        '    cmm21.Parameters.AddWithValue("@doctorname", Me.ComboBox2.Text)
        '    'cmm21.Parameters.AddWithValue("@X5", M6)
        '    cmm21.Parameters.AddWithValue("@KEMA", TextBox6.Text)
        '    cmm21.Parameters.AddWithValue("@KEMAT", TextBox5.Text)
        '    cmm21.Parameters.AddWithValue("@MADFOO", TextBox10.Text)
        '    cmm21.Parameters.AddWithValue("@BAKY", TextBox11.Text)
        '    If Label8.Text = 0 Then
        '        cmm21.Parameters.AddWithValue("@conf", False)
        '    Else
        '        cmm21.Parameters.AddWithValue("@conf", True)
        '    End If
        '    cmm21.Parameters.AddWithValue("@USER_NAME", user)
        '    cmm21.Parameters.AddWithValue("@idm", Label8.Text)
        '    cmm21.Parameters.AddWithValue("@Ejraa", ComboBox3.Text)
        '    cmm21.Parameters.AddWithValue("@Esalno", Label18.Text)

        '    'Try
        '    cmm21.ExecuteNonQuery()
        '    M6 = CInt(Label18.Text)
        'End Using
        'Else
        Dim ss21 As String = "insert into kashef(NOFATORA,fnumber,CHNO,DATEX,doctorname,KEMA,KEMAT,MADFOO,BAKY,conf,USER_NAME,idm,EJRAA) VALUES(@NOFATORA,@fnumber,@CHNO,@DATEX,@doctorname,@KEMA,@KEMAT,@MADFOO,@BAKY,@conf,@USER_NAME,@idm,@EJRAA)"
        '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
        Using cmm21 As New SqlClient.SqlCommand(ss21, cn)
            cmm21.Parameters.AddWithValue("@NOFATORA", CInt(TextBox36.Text))
            cmm21.Parameters.AddWithValue("@fnumber", CInt(TextBox2.Text))
            cmm21.Parameters.AddWithValue("@CHNO", CInt(Me.Label1.Text))
            cmm21.Parameters.AddWithValue("@DATEX", Me.DateTimePicker3.Value.Date)
            cmm21.Parameters.AddWithValue("@doctorname", Me.Label4.Text)
            'cmm21.Parameters.AddWithValue("@X5", M6)
            If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
                cmm21.Parameters.AddWithValue("@KEMA", CDec(TextBox34.Text))
            Else
                cmm21.Parameters.AddWithValue("@KEMA", CDec(TextBox6.Text))
            End If
            cmm21.Parameters.AddWithValue("@KEMAT", Me.Label15.Text)
            cmm21.Parameters.AddWithValue("@MADFOO", 0)
            cmm21.Parameters.AddWithValue("@BAKY", Me.Label15.Text)
            'If Label8.Text = 0 Then
            cmm21.Parameters.AddWithValue("@conf", False)
            'Else
            'cmm21.Parameters.AddWithValue("@conf", True)
            'End If
            cmm21.Parameters.AddWithValue("@USER_NAME", user)
            cmm21.Parameters.AddWithValue("@idm", Label8.Text)
            cmm21.Parameters.AddWithValue("@Ejraa", ComboBox3.Text)

            'Try
            cmm21.ExecuteNonQuery()

            Dim Str As String = "SELECT MAX(ESALNO) FROM KASHEF "
            Dim cmd As New SqlClient.SqlCommand(Str, cn)
            M6 = cmd.ExecuteScalar
        End Using
        'End If
        'rdkk.Close()
        '        End Using
        '    End Using
        'M6 = 1
        'Dim k1 As Integer = 0
        'Do While k1 < 100
        '    Dim i As Integer
        '    i = M6
        '    Dim s1 As String = "select * from appointment where ESALNO=@xx1"
        '    Dim cm1 As New SqlClient.SqlCommand(s1, cn)
        '    cm1.Parameters.AddWithValue("@xx1", i)
        '    Dim rd1 As SqlClient.SqlDataReader
        '    rd1 = cm1.ExecuteReader
        '    Do While rd1.Read = True
        '        i = i + 1
        '        Dim ss1 As String = "select * from appointment where ESALNO=@xx1"
        '        Dim cmm1 As New SqlClient.SqlCommand(ss1, cn)
        '        cmm1.Parameters.AddWithValue("@xx1", i)
        '        rd1 = cmm1.ExecuteReader
        '        M6 = i
        '    Loop
        '    rd1.Close()
        '    k1 = k1 + 1
        'Loop




        Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,doctorname,IDM,EJRAA,Esalno,USER_NAME)VALUES(@fnumber,@CHNO,@DATEA,@doctorname,@IDM,@EJRAA,@Esalno,@USER_NAME)"
        '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
        Using cmm2 As New SqlClient.SqlCommand(ss2, cn)
            cmm2.Parameters.AddWithValue("@fnumber", TextBox2.Text)
            cmm2.Parameters.AddWithValue("@CHNO", CInt(Me.Label1.Text))
            cmm2.Parameters.AddWithValue("@DATEA", Me.DateTimePicker3.Value.Date)
            cmm2.Parameters.AddWithValue("@doctorname", Me.Label4.Text)
            cmm2.Parameters.AddWithValue("@IDM", Me.Label8.Text)
            cmm2.Parameters.AddWithValue("@EJRAA", Me.ComboBox3.Text)
            cmm2.Parameters.AddWithValue("@Esalno", M6)
            cmm2.Parameters.AddWithValue("@USER_NAME", user)
            Try
                ' cmm.ExecuteNonQuery()
                cmm2.ExecuteNonQuery()


                MsgBox("تم الحفظ ")
                'Me.TextBox3.Enabled = False
                'Me.ComboBox1.Enabled = False
                'Me.ComboBox3.Enabled = False
                'Me.ComboBox4.Enabled = False
                'Me.DateTimePicker3.Enabled = False
                Me.DateTimePicker3.Value = Date.Today
                Me.DateTimePicker1.Value = Date.Today
                Me.DateTimePicker2.Value = Date.Today
                Me.TextBox3.Text = ""
                Me.TextBox4.Text = ""
                Me.Label5.Text = ""
                Me.Label16.Text = ""
                'Me.Label9.Text = ""
                'Me.ComboBox1.Text = ""
                Me.ComboBox3.Text = ""
                'Me.ComboBox4.Text = ""
                Me.ComboBox2.Text = ""
                'Me.ComboBox1.Text = ""
                Me.ComboBox2.Text = ""
                Me.NumericUpDown1.Value = 0
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                'Me.MaskedTextBox1.Text = ""
                'Me.MaskedTextBox2.Text = ""
                'Me.MaskedTextBox3.Text = ""
                Me.DataGridView1.DataSource = ""
                Me.TextBox34.Text = 0
                'Me.TextBox34.Focus()
                'Me.ComboBox1.Enabled = False
                Me.DateTimePicker3.Enabled = False
                ' Me.ComboBox2.Enabled = False
                ComboBox2.SelectedIndex = -1
                ComboBox3.SelectedIndex = -1



                Dim s16 As String = "select * from kashef "
                Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
                Dim dss As New DataSet
                dss.Clear()
                aad.Fill(dss, "kashef")
                Dim vd As New DataView(dss.Tables("kashef"))
                vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND fnumber=" & "'" & Me.TextBox10.Text & "'" & ""
                'vd.RowFilter = "doctorname=" & "'" & Me.ComboBox2.Text & "'" & ""
                Me.DataGridView1.DataMember = ""
                DataGridView1.DataSource = vd


            Catch ex As Exception
                MsgBox(" لايمكن الحفظ ")
            End Try
            'Try
            '    Dim Str1 As String = "SELECT MAX(ESALNO) FROM KASHEF "
            '    Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
            '    M6 = cmd1.ExecuteScalar
            '    If Label8.Text = 0 Then
            '        Dim cr2 As New CrystalReport30, cri2 As String
            '        cri2 = "{KASHEF.ESALNO}=" & "" & M6 & ""
            '        KESEM_P = TextBox8.Text
            '        cr2.SetParameterValue(0, Me.KESEM_P)
            '        cr2.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
            '        cr2.RecordSelectionFormula = cri2
            '        cr2.PrintOptions.PrinterName = "PR"
            '        'cr2.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "c:\customer_status.pdf")
            '        cr2.PrintToPrinter(1, True, 0, 0)
            '        cr2.Close()
            '        cr2.Dispose()
            '    Else
            '        Dim cr1 As New CrystalReport31, cri As String
            '        cri = "{KASHEF.ESALNO}=" & "" & M6 & ""
            '        KESEM_P = TextBox8.Text
            '        cr1.SetParameterValue(0, Me.KESEM_P)
            '        cr1.RecordSelectionFormula = cri
            '        cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
            '        cr1.PrintOptions.PrinterName = "PR"
            '        cr1.PrintToPrinter(1, True, 0, 0)
            '        cr1.Close()
            '        cr1.Dispose()
            '    End If
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            '    'Throw ex
            '    'MsgBox("no print")
            'End Try

        End Using

        'Catch ex As Exception
        '    MsgBox(" لايمكن الحفظ ")
        'End Try
        'GroupBox15.Visible = False
        'End If
        'Call Class4.CONNIC()

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text = "" Then
            Label9.Text = ""
        Else
            Call Class1.CONNIC()
            Dim s As String = "select * from Mostafeed where NameM=@xx1"
            Using cm As New SqlClient.SqlCommand(s, cn)
                cm.Parameters.AddWithValue("@xx1", Me.ComboBox4.Text)
                Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    TextBox4.Text = rd!JehaM
                    Label9.Text = rd!JehaM
                    Label8.Text = rd!IDM
                End If
                rd.Close()
            End Using
            'end using
            'Call Class4.CONNIC()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrWhiteSpace(ComboBox1.Text) = True Then
            MsgBox("عفوا .. يرجى اختيار اسم المريض")
            ComboBox1.Focus()
            Return
        End If
        dgx = Me.TextBox10.Text
        Dim f As New FrmPatientDocs
        Hide()
        f.ShowDialog()
        Show()
    End Sub

    Private Sub TextBox34_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox34.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Button1.Focus()
        End If
    End Sub

    Private Sub TextBox34_TextChanged(sender As Object, e As EventArgs) Handles TextBox34.TextChanged
        Label15.Text = Val(TextBox34.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Class1.CONNIC()
        EYWAA_Load(Nothing, Nothing)
        Button3.Enabled = True
        Button10.Enabled = True
        'Button5.Enabled = False
        TextBox10.Text = ""
        TextBox36.Text = ""
        TextBox11.Text = ""
        TextBox9.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        TextBox24.Text = ""
        TextBox26.Text = ""
        TextBox15.Text = ""
        ComboBox6.Text = ""
        NumericUpDown1.Value = 1
        DateTimePicker2.Value = Date.Today.Date
        DateTimePicker4.Text = TimeString
        ComboBox9.Text = ""
        Label13.Text = ""
        TextBox22.Text = ""
        TextBox27.Text = ""
        'TextBox28.Text = ""
        Call Class1.CONNIC()
        Dim Str1 As String = "SELECT MAX(FNUMBER) FROM MAIN "
        Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
        If IsDBNull(cmd1.ExecuteScalar) = True Then
            fnumberx = 1000
        Else
            fnumberx = cmd1.ExecuteScalar
        End If
        Dim Str2 As String = "SELECT MAX(NOFATORA) FROM EYWAA "
        Dim cmd2 As New SqlClient.SqlCommand(Str2, cn)
        If IsDBNull(cmd2.ExecuteScalar) = True Then
            NOFATORAX = 0
        Else
            NOFATORAX = cmd2.ExecuteScalar
        End If
        Dim cmMM As New SqlClient.SqlCommand("DBCC CHECKIDENT('MAIN', RESEED," & fnumberx & ")", cn)
        Dim cmMY As New SqlClient.SqlCommand("DBCC CHECKIDENT('EYWAA', RESEED," & NOFATORAX & ")", cn)
        cmMM.ExecuteNonQuery()
        cmMY.ExecuteNonQuery()
        Dim ss As String = "INSERT INTO main(namex,age,address,husbend,phone,idcard,datex,CITY,gender,sex) VALUES(@namex,@age,@address,@husbend,@phone,@idcard,@datex,@CITY,@gender,@sex)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("@namex", TextBox11.Text)
        cmm.Parameters.AddWithValue("@age", TextBox9.Text)
        cmm.Parameters.AddWithValue("@address", TextBox24.Text)
        cmm.Parameters.AddWithValue("@husbend", "NONE")
        cmm.Parameters.AddWithValue("@phone", TextBox26.Text)
        cmm.Parameters.AddWithValue("@idcard", TextBox15.Text)
        cmm.Parameters.AddWithValue("@datex", Date.Today.Date)
        cmm.Parameters.AddWithValue("@CITY", "NONE")
        cmm.Parameters.AddWithValue("@gender", ComboBox8.Text)
        cmm.Parameters.AddWithValue("@sex", ComboBox7.Text)
        'Try
        cmm.ExecuteNonQuery()
        Button4.Enabled = False
        Dim Str As String = "SELECT MAX(FNUMBER) FROM MAIN "
        Dim cmd As New SqlClient.SqlCommand(Str, cn)
        fnumberx = cmd.ExecuteScalar
        TextBox10.Text = fnumberx
        TextBox10.ReadOnly = True
        ComboBox1.Enabled = False
        ComboBox4.Enabled = False
        DateTimePicker3.Enabled = False
        TabPage2.Focus()
        TextBox11.Focus()
        'Catch ex As Exception
        'Call Class4.CONNIC()

        'End Try
    End Sub

    Private Sub ComboBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox6.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox6.Text = "" Then
                MsgBox("يرجى اختيار القسم")
                ComboBox6.Focus()
            Else
                NumericUpDown1.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim s As String = "select * from KESEM where KESEM=@KESEM"
        Using cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@KESEM", Me.ComboBox6.Text)
            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            If rd.Read = True Then
                Label17.Text = rd!IDK
            End If
        End Using
        'Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox9.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox9.Text = "" Then
                MsgBox("يرجى اختيار نوع الايواء")
                ComboBox9.Focus()
            Else
                TextBox22.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        If ComboBox9.Text = "" Then
            Label13.Text = CDbl(0)
        Else
            Call Class1.CONNIC()

            Dim s As String = "select * from TYPEEYWAA where EYWAATYPE=@EYWAATYPE"
            Using cm As New SqlClient.SqlCommand(s, cn)
                cm.Parameters.AddWithValue("@EYWAATYPE", Me.ComboBox9.Text)
                Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    Label18.Text = CInt(rd!idey)
                    Label13.Text = CDbl(rd!SE3REYWAA)
                Else
                    Label13.Text = CDbl(0)
                End If
            End Using
            'Call Class4.CONNIC()

        End If
    End Sub

    Private Sub ComboBox9_TextChanged(sender As Object, e As EventArgs) Handles ComboBox9.TextChanged
        If ComboBox9.Text = "" Then
            Label13.Text = CDbl(0)
        Else
            Call Class1.CONNIC()
            Dim s As String = "select * from TYPEEYWAA where EYWAATYPE=@EYWAATYPE"
            Using cm As New SqlClient.SqlCommand(s, cn)
                cm.Parameters.AddWithValue("@EYWAATYPE", Me.ComboBox9.Text)
                Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    Label13.Text = CDbl(rd!SE3REYWAA)
                Else
                    Label13.Text = CDbl(0)
                End If
            End Using
            'Call Class4.CONNIC()

        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If Char.IsDigit(e.KeyChar) = True And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox11.Text = "" Then
                MsgBox("أرجو ادخال اسم المريض")
                TextBox11.Focus()
            Else
                NumericUpDown2.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox9.Text = "" Or Val(TextBox9.Text) = 0 Then
                MsgBox("أرجو ادخال عمر المريض")
                TextBox9.Focus()
            Else
                ComboBox7.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub ComboBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox7.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox7.Text = "" Then
                ComboBox7.Text = "ذكر"
            End If
            ComboBox8.Focus()
        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged

    End Sub

    Private Sub ComboBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox8.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox8.Text = "" Then
                ComboBox8.Text = "ليبي"
            End If
            TextBox24.Focus()
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged

    End Sub

    Private Sub TextBox24_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox24.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox24.Text = "" Then
                TextBox24.Text = "البيضاء"
            End If
            TextBox15.Focus()
        End If
    End Sub

    Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs) Handles TextBox24.TextChanged

    End Sub

    Private Sub TextBox26_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox26.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox26.Text = "" Then
                TextBox26.Text = "لايوجد"
            End If
            Button3.Focus()
        End If
    End Sub

    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs) Handles TextBox26.TextChanged

    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox15.Text = "" Then
                TextBox15.Text = "لا يوجد"
            End If
            ComboBox6.Focus()
        End If
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged

    End Sub

    Private Sub NumericUpDown1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            DateTimePicker2.Focus()
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DateTimePicker2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            DateTimePicker4.Focus()
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub DateTimePicker4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DateTimePicker4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            ComboBox9.Focus()
        End If
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged

    End Sub

    Private Sub TextBox22_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox22.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox22.Text = "" Then
                TextBox22.Text = "لايوجد"
            End If
            TextBox27.Focus()
        End If
    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles TextBox22.TextChanged
    End Sub

    Private Sub TextBox27_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox27.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox27.Text = "" Then
                TextBox27.Text = "لايوجد"
            End If
            TextBox26.Focus()
        End If
    End Sub

    Private Sub TextBox27_Leave(sender As Object, e As EventArgs) Handles TextBox27.Leave

    End Sub

    Private Sub TextBox27_LostFocus(sender As Object, e As EventArgs) Handles TextBox27.LostFocus
    End Sub

    Private Sub TextBox27_TabStopChanged(sender As Object, e As EventArgs) Handles TextBox27.TabStopChanged

    End Sub

    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs) Handles TextBox27.TextChanged

    End Sub

    Private Sub NumericUpDown2_GotFocus(sender As Object, e As EventArgs) Handles NumericUpDown2.GotFocus
        NumericUpDown2.Text = ""
    End Sub

    Private Sub NumericUpDown2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If NumericUpDown2.Text = "" Then
                NumericUpDown2.Text = 1
            End If
            ComboBox10.Focus()
        End If
    End Sub

    Private Sub NumericUpDown2_Leave(sender As Object, e As EventArgs) Handles NumericUpDown2.Leave
        If NumericUpDown2.Text = "" Then
            NumericUpDown2.Text = 1
        End If
    End Sub

    Private Sub NumericUpDown2_LostFocus(sender As Object, e As EventArgs) Handles NumericUpDown2.LostFocus
        If NumericUpDown2.Text = "" Then
            NumericUpDown2.Text = 1
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged

    End Sub

    Private Sub ComboBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox10.KeyPress

        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox10.Text = "" Then
                ComboBox10.Text = "سنة"
            End If
            ComboBox7.Focus()
        End If

    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox10.SelectedIndexChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call Class1.CONNIC()
        If String.IsNullOrWhiteSpace(ComboBox1.Text) = True Then
            MsgBox("عفوا .. يرجى اختيار اسم المريض")
            ComboBox1.Focus()
            Return
        End If
        Dim s5 As String = "select * from main where namex=@xx1"
        Using cm5 As New SqlClient.SqlCommand(s5, cn)
            cm5.Parameters.AddWithValue("@xx1", Trim(ComboBox1.Text))
            Dim rd5 As SqlClient.SqlDataReader = cm5.ExecuteReader
            If rd5.Read = True Then
                fnumberx = TextBox10.Text
                USER_NAME = user
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
                Dim crReportDocument As New CrystalReport44(), cri As String
                crReportDocument.Load("CrystalReport44.rpt")
                cri = "{MAIN.FNUMBER}=" & "" & fnumberx & ""
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
                KESEM_P = ComboBox6.Text
                Dim RM As Resources.ResourceManager
                RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
                NAMEC = RM.GetString("NAMECLINIC")
                crReportDocument.SetParameterValue(0, Me.NAMEC)
                crReportDocument.SetParameterValue(1, Me.KESEM_P)
                crReportDocument.SetParameterValue(2, Me.USER_NAME)
                crReportDocument.RecordSelectionFormula = cri
                crReportDocument.PrintOptions.PrinterName = My.Settings.printerx1
                crReportDocument.PrintToPrinter(1, True, 0, 0)
                crReportDocument.Close()
                crReportDocument.Dispose()

                '-----------------------------------------------------------------------------------
                reader.Close()
            Else
                MsgBox("عفوا .. ارجو اختيار اسم المريض")
                Return
            End If
        End Using

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If String.IsNullOrWhiteSpace(ComboBox1.Text) = True Then
            MsgBox("عفوا .. يرجى اختيار اسم المريض")
            ComboBox1.Focus()
            Return
        End If
        Call Class1.CONNIC()
        Dim s5 As String = "select * from main where namex=@xx1"
        Using cm5 As New SqlClient.SqlCommand(s5, cn)
            cm5.Parameters.AddWithValue("@xx1", Trim(ComboBox1.Text))
            Dim rd5 As SqlClient.SqlDataReader = cm5.ExecuteReader
            If rd5.Read = True Then
                fnumberx = TextBox10.Text
                USER_NAME = user
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
                Dim crReportDocument As New CrystalReport45(), cri As String
                crReportDocument.Load("CrystalReport45.rpt")
                cri = "{MAIN.FNUMBER}=" & "" & fnumberx & ""
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
                KESEM_P = ComboBox6.Text
                Dim RM As Resources.ResourceManager
                RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
                NAMEC = RM.GetString("NAMECLINIC")
                crReportDocument.SetParameterValue(0, Me.NAMEC)
                crReportDocument.SetParameterValue(1, Me.KESEM_P)
                crReportDocument.SetParameterValue(2, Me.USER_NAME)
                crReportDocument.RecordSelectionFormula = cri
                crReportDocument.PrintOptions.PrinterName = My.Settings.printerx1
                crReportDocument.PrintToPrinter(1, True, 0, 0)
                crReportDocument.Close()
                crReportDocument.Dispose()

                '-----------------------------------------------------------------------------------
                reader.Close()



                'Dim cr1 As New CrystalReport45, cri As String
                'cri = "{MAIN.FNUMBER}=" & "" & fnumberx & ""
                'KESEM_P = ComboBox6.Text
                'Dim RM As Resources.ResourceManager
                'RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
                'NAMEC = RM.GetString("NAMECLINIC")
                'cr1.SetParameterValue(0, Me.NAMEC)
                'cr1.SetParameterValue(1, Me.KESEM_P)
                'cr1.SetParameterValue(2, Me.USER_NAME)
                'cr1.RecordSelectionFormula = cri
                ''cr1.PrintOptions.PrinterName = "HP1102"
                'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
                ''cr1.PrintOptions.PrinterName = "LK-TE212"
                'cr1.PrintToPrinter(1, False, 1, 1)
                ''Call Class4.CONNIC()
            Else
                MsgBox("اسف .. ارجو اختيار اسم المريض")
                Return
            End If
        End Using
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If String.IsNullOrWhiteSpace(ComboBox1.Text) = True Then
            MsgBox("عفوا .. يرجى اختيار اسم المريض")
            ComboBox1.Focus()
            Return
        End If
        Call Class1.CONNIC()
        Dim s5 As String = "select * from main where namex=@xx1"
        Using cm5 As New SqlClient.SqlCommand(s5, cn)
            cm5.Parameters.AddWithValue("@xx1", Trim(ComboBox1.Text))
            Dim rd5 As SqlClient.SqlDataReader = cm5.ExecuteReader
            If rd5.Read = True Then
                fnumberx = TextBox10.Text
                USER_NAME = user
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
                Dim crReportDocument As New CrystalReport46(), cri As String
                crReportDocument.Load("CrystalReport46.rpt")
                cri = "{MAIN.FNUMBER}=" & "" & fnumberx & ""
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
                KESEM_P = ComboBox6.Text
                Dim RM As Resources.ResourceManager
                RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
                NAMEC = RM.GetString("NAMECLINIC")
                crReportDocument.SetParameterValue(0, Me.NAMEC)
                crReportDocument.SetParameterValue(1, Me.KESEM_P)
                crReportDocument.SetParameterValue(2, Me.USER_NAME)
                crReportDocument.RecordSelectionFormula = cri
                crReportDocument.PrintOptions.PrinterName = My.Settings.printerx1
                crReportDocument.PrintToPrinter(1, True, 0, 0)
                crReportDocument.Close()
                crReportDocument.Dispose()

                '-----------------------------------------------------------------------------------
                reader.Close()


                'Dim cr1 As New CrystalReport46, cri As String
                'cri = "{MAIN.FNUMBER}=" & "" & fnumberx & ""
                'KESEM_P = ComboBox6.Text
                'Dim RM As Resources.ResourceManager
                'RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
                'NAMEC = RM.GetString("NAMECLINIC")
                'cr1.SetParameterValue(0, Me.NAMEC)
                'cr1.SetParameterValue(1, Me.KESEM_P)
                'cr1.SetParameterValue(2, Me.USER_NAME)
                'cr1.RecordSelectionFormula = cri
                ''cr1.PrintOptions.PrinterName = "HP1102"
                'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
                ''cr1.PrintOptions.PrinterName = "LK-TE212"
                'cr1.PrintToPrinter(1, False, 1, 1)
                ''Call Class4.CONNIC()
            Else
                MsgBox("اسف .. ارجو اختيار اسم المريض")
                Return
            End If
        End Using

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) = False Then
            'MsgBox("اسف .. ارجو اختيار اسم المريض")
            ComboBox1.Focus()
            Return
        End If
        Call Class1.CONNIC()
        Dim sd As String = "delete from MAIN where FNUMBER=@FNUMBER"
        Using cd As New SqlClient.SqlCommand(sd, cn)
            cd.Parameters.AddWithValue("@FNUMBER", fnumberx)
            Dim sdk As String = "delete from EYWAA where FNUMBER=@FNUMBER"
            Using cdk As New SqlClient.SqlCommand(sdk, cn)
                cdk.Parameters.AddWithValue("@FNUMBER", fnumberx)
                'If MsgBox("هل تريد الغاء الاجراء", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    cd.ExecuteNonQuery()
                    cdk.ExecuteNonQuery()
                Catch ex As Exception
                End Try
                'End If
            End Using
        End Using
        Dim Str As String = "SELECT MAX(FNUMBER) FROM MAIN "
        Dim cmd As New SqlClient.SqlCommand(Str, cn)
        If IsDBNull(cmd.ExecuteScalar) = True Then
            fnumberx = 1000
        Else
            fnumberx = cmd.ExecuteScalar
        End If

        Dim cmM As New SqlClient.SqlCommand("DBCC CHECKIDENT('MAIN', RESEED," & fnumberx & ")", cn)
        Dim cmMY As New SqlClient.SqlCommand("DBCC CHECKIDENT('EYWAA', RESEED, 0)", cn)
        cmM.ExecuteNonQuery()
        cmMY.ExecuteNonQuery()
        'CALL CLASS4.CONNIC()
        EYWAA_Load(Nothing, Nothing)
        'Call Class4.CONNIC()
    End Sub

    Private Sub TextBox27_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox27.Validating


    End Sub

    Private Sub TextBox11_Validated(sender As Object, e As EventArgs) Handles TextBox11.Validated
        If TextBox11.Text = String.Empty Then
            ErrorProvider1.SetError(TextBox11, "لا يمكن ترك الحقل فارغ")
            'ErrorProvider1.Icon = New Icon("C:\Users\SYS\Downloads\Awicons-Vista-Artistic-Delete.ico")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If String.IsNullOrWhiteSpace(ComboBox1.Text) = True Then
            MsgBox("عفوا .. يرجى اختيار اسم المريض")
            ComboBox1.Focus()
            Return
        Else
            Call Class1.CONNIC()
            Dim ss As String = "UPDATE main SET namex=@namex,age=@age,address=@address,husbend=@husbend,phone=@phone,idcard=@idcard,datex=@datex,CITY=@CITY,gender=@gender,sex=@sex WHERE FNUMBER=@FNUMBER"
            Dim cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@namex", TextBox11.Text)
            cmm.Parameters.AddWithValue("@age", Trim(NumericUpDown2.Text) + Trim(ComboBox10.Text))
            cmm.Parameters.AddWithValue("@address", TextBox24.Text)
            cmm.Parameters.AddWithValue("@husbend", "NONE")
            cmm.Parameters.AddWithValue("@phone", TextBox26.Text)
            cmm.Parameters.AddWithValue("@idcard", TextBox15.Text)
            cmm.Parameters.AddWithValue("@datex", Date.Today.Date)
            cmm.Parameters.AddWithValue("@CITY", "NONE")
            cmm.Parameters.AddWithValue("@gender", ComboBox8.Text)
            cmm.Parameters.AddWithValue("@sex", ComboBox7.Text)
            cmm.Parameters.AddWithValue("@FNUMBER", TextBox10.Text)

            Dim sse As String = "UPDATE EYWAA set NOSAREER=@NOSAREER,SE3REYWAA=@SE3REYWAA,DAYZ=@DAYZ,RASFATORA=@RASFATORA,MADFOO=@MADFOO,BAKY=@BAKY,DISCOUNT=@DISCOUNT,DATEEYWAA=@DATEEYWAA,DATEMOGHADRA=@DATEMOGHADRA,KESEM=@KESEM,TIMEEYWAA=@TIMEEYWAA,TIMEMOGHADRA=@TIMEMOGHADRA,MASNAME=@MASNAME,ETHBATNO=@ETHBATNO,DATEX=@DATEX,eywaat=@eywaat,user_name=@user_name where FNUMBER=@FNUMBER and MOGHADRA=@MOGHADRA"
            Dim cmme As New SqlClient.SqlCommand(sse, cn)
            cmme.Parameters.AddWithValue("@NOSAREER", CInt(NumericUpDown1.Value))
            cmme.Parameters.AddWithValue("@SE3REYWAA", CDbl(Label13.Text))
            cmme.Parameters.AddWithValue("@DAYZ", CInt(1))
            cmme.Parameters.AddWithValue("@RASFATORA", CDbl(Label13.Text))
            cmme.Parameters.AddWithValue("@MADFOO", CDbl(0))
            cmme.Parameters.AddWithValue("@BAKY", CDbl(Label13.Text))
            cmme.Parameters.AddWithValue("@DISCOUNT", CDbl(0))
            cmme.Parameters.AddWithValue("@DATEEYWAA", CDate(DateTimePicker2.Value.Date))
            cmme.Parameters.AddWithValue("@DATEMOGHADRA", CDate(DateTimePicker2.Value.Date))
            cmme.Parameters.AddWithValue("@KESEM", CInt(Label17.Text))
            cmme.Parameters.AddWithValue("@TIMEEYWAA", DateTimePicker4.Value.TimeOfDay)
            cmme.Parameters.AddWithValue("@TIMEMOGHADRA", DateTimePicker4.Value.TimeOfDay)
            cmme.Parameters.AddWithValue("@MASNAME", Trim(TextBox22.Text))
            cmme.Parameters.AddWithValue("@ETHBATNO", Trim(TextBox27.Text))
            cmme.Parameters.AddWithValue("@DATEX", Date.Now)
            cmme.Parameters.AddWithValue("@eywaat", CInt(Label18.Text))
            cmme.Parameters.AddWithValue("@USER_NAME", Trim(user))
            cmme.Parameters.AddWithValue("@FNUMBER", CInt(TextBox10.Text))
            cmme.Parameters.AddWithValue("@MOGHADRA", False)
            Try
                cmm.ExecuteNonQuery()
                cmme.ExecuteNonQuery()
                MsgBox("تمت عملية التعديل")
                Dim sk1 As String
                sk1 = "select * from EYWAA_V WHERE MOGHADRA=" & "" & 0 & ""
                Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                Dim dsk1 As New DataSet
                adk1.Fill(dsk1, "EYWAA_V")
                ComboBox1.DataSource = dsk1.Tables(0)
                ComboBox1.DisplayMember = "NAMEX"
                ComboBox1.SelectedIndex = -1
                Me.TextBox1.Text = ""
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                Me.TextBox4.Text = ""
                Me.TextBox5.Text = ""
                Me.TextBox6.Text = ""
                Me.TextBox7.Text = ""
                Me.TextBox8.Text = ""
                Me.ComboBox1.Text = ""
                Me.TextBox1.Focus()
                Button4.Enabled = True
                EYWAA_Load(Nothing, Nothing)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub ComboBox10_TextChanged(sender As Object, e As EventArgs) Handles ComboBox10.TextChanged

    End Sub

    Private Sub B10_Click(sender As Object, e As EventArgs) Handles B10.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        'Me.ComboBox1.Text = ""
        'Me.ComboBox3.Text = ""
        'Me.ComboBox4.Text = ""
        'Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B0.Text
        TextBox8.Text = B10.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B10.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label15.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
            GroupBox31.Visible = True
        Else
            GroupBox31.Visible = False
        End If
        'Call Class4.CONNIC()
        TextBox34.Focus()


    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        'Me.ComboBox1.Text = ""
        'Me.ComboBox3.Text = ""
        'Me.ComboBox4.Text = ""
        'Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B0.Text
        TextBox8.Text = B3.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B3.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label15.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
            GroupBox31.Visible = True
        Else
            GroupBox31.Visible = False
        End If
        'Call Class4.CONNIC()
        TextBox34.Focus()

    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        'Me.ComboBox1.Text = ""
        'Me.ComboBox3.Text = ""
        'Me.ComboBox4.Text = ""
        'Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B0.Text
        TextBox8.Text = B4.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B4.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label15.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
            GroupBox31.Visible = True
        Else
            GroupBox31.Visible = False
        End If
        'Call Class4.CONNIC()
        TextBox34.Focus()


    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        'Me.ComboBox1.Text = ""
        'Me.ComboBox3.Text = ""
        'Me.ComboBox4.Text = ""
        'Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B0.Text
        TextBox8.Text = B5.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B5.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label15.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
            GroupBox31.Visible = True
        Else
            GroupBox31.Visible = False
        End If
        'Call Class4.CONNIC()
        TextBox34.Focus()

    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        'Me.ComboBox1.Text = ""
        'Me.ComboBox3.Text = ""
        'Me.ComboBox4.Text = ""
        'Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B0.Text
        TextBox8.Text = B6.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B6.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label15.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
            GroupBox31.Visible = True
        Else
            GroupBox31.Visible = False
        End If
        'Call Class4.CONNIC()
        TextBox34.Focus()


    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        'Me.ComboBox1.Text = ""
        'Me.ComboBox3.Text = ""
        'Me.ComboBox4.Text = ""
        'Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B0.Text
        TextBox8.Text = B7.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B7.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label15.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
            GroupBox31.Visible = True
        Else
            GroupBox31.Visible = False
        End If
        'Call Class4.CONNIC()

        TextBox34.Focus()

    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        'Me.ComboBox1.Text = ""
        'Me.ComboBox3.Text = ""
        'Me.ComboBox4.Text = ""
        'Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B0.Text
        TextBox8.Text = B8.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B8.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label15.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
            GroupBox31.Visible = True
        Else
            GroupBox31.Visible = False
        End If
        'Call Class4.CONNIC()
        TextBox34.Focus()


    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        'Me.ComboBox1.Text = ""
        'Me.ComboBox3.Text = ""
        'Me.ComboBox4.Text = ""
        'Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B0.Text
        TextBox8.Text = B9.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B9.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label15.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
            GroupBox31.Visible = True
        Else
            GroupBox31.Visible = False
        End If
        'Call Class4.CONNIC()

        TextBox34.Focus()

    End Sub

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        'Me.ComboBox1.Text = ""
        'Me.ComboBox3.Text = ""
        'Me.ComboBox4.Text = ""
        'Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B0.Text
        TextBox8.Text = B11.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B11.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                Me.Label15.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        If CInt(TextBox23.Text) = 0 Or CInt(TextBox23.Text) = 2 Or CInt(TextBox23.Text) = 3 Then
            GroupBox31.Visible = True
        Else
            GroupBox31.Visible = False
        End If
        'Call Class4.CONNIC()
        TextBox34.Focus()


    End Sub

    Private Sub B12_Click(sender As Object, e As EventArgs) Handles B12.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B2.Text
        TextBox8.Text = B12.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B12.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                'Me.Label13.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        'Call Class4.CONNIC()

        TextBox34.Focus()

    End Sub

    Private Sub B13_Click(sender As Object, e As EventArgs) Handles B13.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B2.Text
        TextBox8.Text = B13.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B13.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                'Me.Label13.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        'Call Class4.CONNIC()
        TextBox34.Focus()


    End Sub

    Private Sub B14_Click(sender As Object, e As EventArgs) Handles B14.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B2.Text
        TextBox8.Text = B14.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B14.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                'Me.Label13.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        'Call Class4.CONNIC()
        TextBox34.Focus()


    End Sub

    Private Sub B15_Click(sender As Object, e As EventArgs) Handles B15.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B2.Text
        TextBox8.Text = B15.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B15.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                'Me.Label13.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        'Call Class4.CONNIC()

        TextBox34.Focus()

    End Sub

    Private Sub B16_Click(sender As Object, e As EventArgs) Handles B16.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B2.Text
        TextBox8.Text = B16.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B16.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                'Me.Label13.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        'Call Class4.CONNIC()
        TextBox34.Focus()


    End Sub

    Private Sub B17_Click(sender As Object, e As EventArgs) Handles B17.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B2.Text
        TextBox8.Text = B17.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B17.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                'Me.Label13.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        'Call Class4.CONNIC()
        TextBox34.Focus()


    End Sub

    Private Sub B18_Click(sender As Object, e As EventArgs) Handles B18.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B2.Text
        TextBox8.Text = B18.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B18.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                'Me.Label13.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        'Call Class4.CONNIC()

        TextBox34.Focus()

    End Sub

    Private Sub B19_Click(sender As Object, e As EventArgs) Handles B19.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B2.Text
        TextBox8.Text = B19.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B19.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                'Me.Label13.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        'Call Class4.CONNIC()
        TextBox34.Focus()


    End Sub

    Private Sub B20_Click(sender As Object, e As EventArgs) Handles B20.Click
        'GroupBox15.Visible = False
        'Me.TextBox3.Enabled = False
        Call Class1.CONNIC()
        'Me.ComboBox1.Enabled = False
        'Me.ComboBox2.Enabled = True
        'Me.ComboBox3.Enabled = True
        'Me.ComboBox4.Enabled = False
        'Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Value = Date.Today
        'Me.DateTimePicker1.Value = Date.Today
        'Me.DateTimePicker2.Value = Date.Today
        'Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
        Me.ComboBox2.Text = ""
        ComboBox3.Text = "كشف"
        ComboBox4.Text = "نقدا"
        TextBox4.Text = "نقدا"
        Label9.Text = "نقدا"
        'Label5.Text = ""
        Label16.Text = ""
        Dim sk2 As String
        Dim B As Integer
        'B = B2.Text
        TextBox8.Text = B20.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", B20.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label23.Text = B
                TextBox23.Text = B
            End If
            rdG.Close()
        End Using
        'end using

        sk2 = "select * from DN where IDK=" & B
        Using adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "dn")
            ComboBox2.DataSource = dsk2.Tables(0)
            ComboBox2.DisplayMember = "dn"
            ''ComboBox2.SelectedIndex = -1
            'end using
        End Using
        If Trim(ComboBox2.Text) <> "" Then
            Dim sn20 As String = "select * from dn where dn=@xx1 "
            Using cmn20 As New SqlClient.SqlCommand(sn20, cn)
                cmn20.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
                If rdn20.Read = True Then
                    Me.Label4.Text = rdn20!IDD
                End If
                rdn20.Close()
            End Using
        Else
            Me.Label4.Text = 0
        End If

        'end using

        Dim sn0 As String = "select * from Ejraa where Ejraa=@Ejraa and idk=@idk "
        Using cmn0 As New SqlClient.SqlCommand(sn0, cn)
            cmn0.Parameters.AddWithValue("@Ejraa", Trim(ComboBox3.Text))
            cmn0.Parameters.AddWithValue("@idk", CInt(B))
            Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
            If rdn0.Read = True Then
                Me.Label23.Text = rdn0!idJ
            End If
            rdn0.Close()
        End Using
        'end using

        Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        Using cmn10 As New SqlClient.SqlCommand(sn10, cn)
            cmn10.Parameters.AddWithValue("@Xxx1", Label23.Text)
            cmn10.Parameters.AddWithValue("@xxx2", CInt(Label4.Text))
            Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
            If rdn10.Read = True Then
                Me.TextBox6.Text = CDbl(rdn10!kema)
                Me.TextBox5.Text = CDbl(rdn10!kemaej)
                'Me.Label13.Text = CDbl(rdn10!kemaej)
                'Me.TextBox11.Text = CDbl(rdn10!kemaej)
                'Me.TextBox10.Text = CDbl(0)
            End If
            rdn10.Close()
        End Using
        'end using
        Dim sk23 As String
        sk23 = "select * from Ejraa where IDK=" & B
        Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
            Dim dsk23 As New DataSet
            adk23.Fill(dsk23, "Ejraa")
            ComboBox3.DataSource = dsk23.Tables(0)
            ComboBox3.DisplayMember = "Ejraa"
            ComboBox3.Text = "كشف"
        End Using
        'Label21.Text = ""
        'Label21.BackColor = Color.Transparent
        'Timer2.Stop()
        'TextBox15.Text = ""
        'DataGridView2.DataSource = ""
        'If B - 0 Then
        '    TextBox15.ReadOnly = False
        'End If
        'Call Class4.CONNIC()
        TextBox34.Focus()


    End Sub

    Private Sub TextBox34_Validated(sender As Object, e As EventArgs) Handles TextBox34.Validated
        If String.IsNullOrWhiteSpace(TextBox34.Text) Then
            ErrorProvider1.SetError(TextBox34, "لا يمكن ترك الحقل فارغ")
            TextBox34.Text = 0
            TextBox34.Focus()
            'ErrorProvider1.Icon = New Icon("C:\Users\SYS\Downloads\Awicons-Vista-Artistic-Delete.ico")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub TextBox34_Enter(sender As Object, e As EventArgs) Handles TextBox34.Enter
        If Double.Parse(TextBox34.Text) = 0 Then
            TextBox34.Text = String.Empty
        End If
    End Sub
End Class