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
Imports System.Math
Public Class Alkhazena
    Friend KESEM_P As String
    Friend NAMEC As String
    Friend CLIN As String
    Friend HOR As String
    Friend USER_NAME As String

    Private Sub Alkhazena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CLINICSQLhDataSet.HESAB_DO' table. You can move, or remove it, as needed.
        'Me.HESAB_DOTableAdapter.Fill(Me.CLINICSQLhDataSet.HESAB_DO)
        'TODO: This line of code loads data into the 'CLINICSQLhDataSet.LOSS' table. You can move, or remove it, as needed.
        'Me.LOSSTableAdapter.Fill(Me.CLINICSQLhDataSet.LOSS)
        'TODO: This line of code loads data into the 'CLINICSQLhDataSet.SADAD' table. You can move, or remove it, as needed.
        'Me.SADADTableAdapter.Fill(Me.CLINICSQLhDataSet.SADAD)
        Call Class1.CONNIC()
        Timer1.Start()
        'TODO: This line of code loads data into the 'DbsbhDataSet8.EYWAA_V' table. You can move, or remove it, as needed.
        'Me.EYWAA_VTableAdapter.Fill(Me.DbsbhDataSet8.EYWAA_V)
        ''TODO: This line of code loads data into the 'DbsbhDataSet8.EYWAA' table. You can move, or remove it, as needed.
        'Me.EYWAATableAdapter.Fill(Me.DbsbhDataSet8.EYWAA)
        TabPage1.Visible = t3
        Panel1.Visible = t3
        Panel2.Visible = t3
        TabPage2.Visible = t4
        Panel3.Visible = t4
        Panel6.Visible = t4
        TabPage4.Visible = t5
        DataGridView6.Visible = t5
        Button10.Visible = t5
        Button13.Visible = t5
        Button14.Visible = t5
        GroupBox30.Visible = t5
        GroupBox33.Visible = t5
        GroupBox32.Visible = t5
        GroupBox31.Visible = t5
        TabPage3.Visible = t6
        GroupBox10.Visible = t6
        If t6 = False Then
            Label28.Visible = True
        End If
        TabPage5.Visible = t7
        GroupBox19.Visible = t7
        GroupBox20.Visible = t7
        GroupBox22.Visible = t7
        GroupBox23.Visible = t7
        DataGridView7.Visible = t7
        If t7 = False Then
            Label33.Visible = True
        End If
        TabPage6.Visible = t8
        GroupBox29.Visible = t8
        GroupBox27.Visible = t8
        GroupBox34.Visible = t8
        GroupBox36.Visible = t8
        GroupBox39.Visible = t8
        GroupBox28.Visible = t8
        GroupBox38.Visible = t8
        Button12.Visible = t8
        DataGridView8.Visible = t8
        TabPage7.Visible = T9
        DataGridView11.Visible = T9
        GroupBox40.Visible = T9
        GroupBox37.Visible = T9
        GroupBox45.Visible = T9
        GroupBox42.Visible = T9
        GroupBox41.Visible = T9
        GroupBox43.Visible = T9
        GroupBox44.Visible = T9
        Button15.Visible = T9
        Button16.Visible = T9
        DataGridView10.Visible = T9
        If T9 = False Then
            Label35.Visible = True
        End If
        GroupBox70.Visible = T10
        GroupBox59.Visible = T10
        GroupBox68.Visible = T10
        Button21.Visible = T10
        CheckBox1.Visible = T10
        TabPage8.Visible = T10
        GroupBox72.Visible = T10
        GroupBox71.Visible = T10
        GroupBox77.Visible = T10
        GroupBox78.Visible = T10
        GroupBox83.Visible = T10
        GroupBox81.Visible = T10
        GroupBox84.Visible = T10
        GroupBox80.Visible = T10
        GroupBox75.Visible = T10
        GroupBox73.Visible = T10
        GroupBox88.Visible = T10
        GroupBox86.Visible = T10
        GroupBox76.Visible = T10
        GroupBox74.Visible = T10
        GroupBox82.Visible = T10
        GroupBox79.Visible = T10
        'GroupBox87.Visible = T10
        GroupBox85.Visible = T10
        Button28.Visible = T10
        Panel8.Visible = T10
        If T10 = False Then
            Label40.Visible = True
        End If
        'TODO: This line of code loads data into the 'DbsbhDataSet8.HESAB_AM' table. You can move, or remove it, as needed.
        'Me.HESAB_AMTableAdapter.Fill(Me.DbsbhDataSet8.HESAB_AM)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.AMALEAT_M' table. You can move, or remove it, as needed.
        'Me.AMALEAT_MTableAdapter.Fill(Me.DbsbhDataSet8.AMALEAT_M)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.AMALEAT' table. You can move, or remove it, as needed.
        'Me.AMALEATTableAdapter.Fill(Me.DbsbhDataSet8.AMALEAT)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.SADAD' table. You can move, or remove it, as needed.
        'Me.SADADTableAdapter.Fill(Me.DbsbhDataSet8.SADAD)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.Kashefmain' table. You can move, or remove it, as needed.
        'Me.KashefmainTableAdapter.Fill(Me.DbsbhDataSet8.Kashefmain)
        ''TODO: This line of code loads data into the 'DbsbhDataSet8.Eiradat' table. You can move, or remove it, as needed.
        'Me.EiradatTableAdapter.Fill(Me.DbsbhDataSet8.Eiradat)
        ''TODO: This line of code loads data into the 'DbsbhDataSet8.LOSS' table. You can move, or remove it, as needed.
        'Me.LOSSTableAdapter.Fill(Me.DbsbhDataSet8.LOSS)
        ''TODO: This line of code loads data into the 'DbsbhDataSet8.mostafeed_view' table. You can move, or remove it, as needed.
        'Me.Mostafeed_viewTableAdapter.Fill(Me.DbsbhDataSet8.mostafeed_view)
        ''TODO: This line of code loads data into the 'DbsbhDataSet8.HESAB_DO' table. You can move, or remove it, as needed.
        'Me.HESAB_DOTableAdapter.Fill(Me.DbsbhDataSet8.HESAB_DO)
        ''TODO: This line of code loads data into the 'DbsbhDataSet8.kashef' table. You can move, or remove it, as needed.
        'Me.KashefTableAdapter.Fill(Me.DbsbhDataSet8.kashef)
        TextBox10.Focus()
        Label10.Text = user
        'TODO: This line of code loads data into the 'DbsbhDataSet8.APPOINTMENTVIEW' table. You can move, or remove it, as needed.
        'Me.APPOINTMENTVIEWTableAdapter.Fill(Me.DbsbhDataSet8.APPOINTMENTVIEW)
        Me.DateTimePicker1.Value = Date.Today
        Me.DateTimePicker2.Value = Date.Today
        Dim k As Integer = 1
        Dim i As Integer
        i = 0
        Do While i < 1000
            Call Class1.CONNIC()
            Dim sB As String = "select * from KESEM where IDK=@xx1 "
            Dim cmB As New SqlClient.SqlCommand(sB, cn)
            cmB.Parameters.AddWithValue("@xx1", i)
            Dim rdB As SqlClient.SqlDataReader
            rdB = cmB.ExecuteReader
            If rdB.Read = True Then
                If B0.Visible = False Then
                    B0.Visible = True
                    B0.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = False Then
                    B1.Visible = True
                    B1.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = False Then
                    B2.Visible = True
                    B2.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = False Then
                    B3.Visible = True
                    B3.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = False Then
                    B4.Visible = True
                    B4.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = False Then
                    B5.Visible = True
                    B5.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = False Then
                    B6.Visible = True
                    B6.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = False Then
                    B7.Visible = True
                    B7.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = False Then
                    B8.Visible = True
                    B8.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = False Then
                    B9.Visible = True
                    B9.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = False Then
                    B10.Visible = True
                    B10.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = False Then
                    B11.Visible = True
                    B11.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = False Then
                    B12.Visible = True
                    B12.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = False Then
                    b13.Visible = True
                    b13.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = False Then
                    b14.Visible = True
                    b14.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = True And B15.Visible = False Then
                    B15.Visible = True
                    B15.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = True And B15.Visible = True And B16.Visible = False Then
                    B16.Visible = True
                    B16.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = False Then
                    B17.Visible = True
                    B17.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = False Then
                    B18.Visible = True
                    B18.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = False Then
                    B19.Visible = True
                    B19.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = False Then
                    B20.Visible = True
                    B20.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = True And B21.Visible = False Then
                    B21.Visible = True
                    B21.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = True And B21.Visible = True And B22.Visible = False Then
                    B22.Visible = True
                    B22.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = True And B21.Visible = True And B22.Visible = True And B23.Visible = False Then
                    B23.Visible = True
                    B23.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = True And B21.Visible = True And B22.Visible = True And B23.Visible = True And B24.Visible = False Then
                    B24.Visible = True
                    B24.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = True And B21.Visible = True And B22.Visible = True And B23.Visible = True And B24.Visible = True And B25.Visible = False Then
                    B25.Visible = True
                    B25.Text = rdB!KESEM
                ElseIf B0.Visible = True And B1.Visible = True And B2.Visible = True And B3.Visible = True And B4.Visible = True And B5.Visible = True And B6.Visible = True And B7.Visible = True And B8.Visible = True And B9.Visible = True And B10.Visible = True And B11.Visible = True And B12.Visible = True And b13.Visible = True And b14.Visible = True And B15.Visible = True And B16.Visible = True And B17.Visible = True And B18.Visible = True And B19.Visible = True And B20.Visible = True And B21.Visible = True And B22.Visible = True And B23.Visible = True And B24.Visible = True And B25.Visible = True And B26.Visible = False Then
                    B26.Visible = True
                    B26.Text = rdB!KESEM
                End If
            End If
            'Dim bi As New Button
            'bi.Name = "B" + i
            'bi.visible = True
            'bi.Text = rdB!kesem
            i = i + 1
            rdB.Close()
        Loop
        '    'i = i + 1
        'k = k + 1
        'Loop

        'Dim sB As String = "select * from KESEM where IDK=@xx1 "
        'Dim cmB As New SqlClient.SqlCommand(sB, cn)
        'cmB.Parameters.AddWithValue("@xx1", i)
        'Dim rdB As SqlClient.SqlDataReader
        'rdB = cmB.ExecuteReader
        'Do While rdB.Read = True
        '    If i = 0 Then
        '        B0.Visible = True
        '        B0.Text = rdB!KESEM
        '    ElseIf i = 1 Then
        '        B1.Visible = True
        '        B1.Text = rdB!KESEM
        '    ElseIf i = 2 Then
        '        B2.Visible = True
        '        B2.Text = rdB!KESEM
        '    ElseIf i = 3 Then
        '        B3.Visible = True
        '        B3.Text = rdB!KESEM
        '    ElseIf i = 4 Then
        '        B4.Visible = True
        '        B4.Text = rdB!KESEM
        '    ElseIf i = 5 Then
        '        B5.Visible = True
        '        B5.Text = rdB!KESEM
        '    ElseIf i = 6 Then
        '        B6.Visible = True
        '        B6.Text = rdB!KESEM
        '    ElseIf i = 7 Then
        '        B7.Visible = True
        '        B7.Text = rdB!KESEM
        '    ElseIf i = 8 Then
        '        B8.Visible = True
        '        B8.Text = rdB!KESEM
        '    ElseIf i = 9 Then
        '        B9.Visible = True
        '        B9.Text = rdB!KESEM
        '    ElseIf i = 10 Then
        '        B10.Visible = True
        '        B10.Text = rdB!KESEM
        '    ElseIf i = 11 Then
        '        B11.Visible = True
        '        B11.Text = rdB!KESEM
        '    ElseIf i = 12 Then
        '        B12.Visible = True
        '        B12.Text = rdB!KESEM
        '    ElseIf i = 13 Then
        '        b13.Visible = True
        '        b13.Text = rdB!KESEM
        '    ElseIf i = 14 Then
        '        b14.Visible = True
        '        b14.Text = rdB!KESEM
        '    End If
        '    i = i + 1
        'Loop
        TextBox10.Focus()
        Dim sk1 As String
        sk1 = "select * from jehat"
        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
        Dim dsk1 As New DataSet
        adk1.Fill(dsk1, "jehat")
        ComboBox8.DataSource = dsk1.Tables(0)
        ComboBox8.DisplayMember = "jeham"
        ComboBox8.SelectedIndex = -1
        Dim sk12 As String
        sk12 = "select * from mostafeed"
        Dim adk12 As New SqlClient.SqlDataAdapter(sk12, cn)
        Dim dsk12 As New DataSet
        adk12.Fill(dsk12, "mostafeed")
        ComboBox12.DataSource = dsk12.Tables(0)
        ComboBox12.DisplayMember = "namem"
        ComboBox12.SelectedIndex = -1

        Dim sk As String
        sk = "select * from Bloss"
        Dim adk As New SqlClient.SqlDataAdapter(sk, cn)
        Dim dsk As New DataSet
        adk.Fill(dsk, "Bloss")
        ComboBox3.DataSource = dsk.Tables(0)
        ComboBox3.DisplayMember = "lossna"
        ComboBox3.SelectedIndex = -1
        Dim skK As String
        skK = "select * from BlossT"
        Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
        Dim dskK As New DataSet
        adkK.Fill(dskK, "BlossT")
        ComboBox4.DataSource = dskK.Tables(0)
        ComboBox4.DisplayMember = "lossTYPE"
        ComboBox4.SelectedIndex = -1
        Me.ComboBox3.Text = ""
        Me.TextBox15.Text = ""

        Dim ss As String = "select * from LOSS "
        Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "LOSS")
        Dim vdd As New DataView(dss.Tables("LOSS"))
        vdd.RowFilter = " LOSSDATE =" & "'" & Date.Now.Date & "'" & ""
        DataGridView4.DataMember = ""
        DataGridView4.DataSource = vdd

        Dim ss3 As String = "select * from SADAD "
        Dim aad3 As New SqlClient.SqlDataAdapter(ss3, cn)
        Dim dss3 As New DataSet
        dss3.Clear()
        aad3.Fill(dss3, "SADAD")
        Dim vdd3 As New DataView(dss3.Tables("SADAD"))
        vdd3.RowFilter = " DatexX >=" & "'" & DateTimePicker1.Value & "'" & "and DatexX <=" & "'" & DateTimePicker2.Value & "'" & ""
        DataGridView7.DataMember = ""
        DataGridView7.DataSource = vdd3
        If DataGridView7.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot0 As Integer = 0
            Dim tot1 As Integer = 0
            Dim tot2 As Integer = 0
            Dim tot3 As Integer = 0
            Dim j As Integer = 0
            For j = 0 To DataGridView7.Rows.Count - 1
                tot0 += DataGridView7.Item(2, j).Value
                'tot1 += DataGridView7.Item(2, j).Value
            Next
            TextBox16.Text = tot0
            'TextBox17.Text = tot1
        Else
            TextBox16.Text = 0
            'TextBox17.Text = 0
        End If
        TextBox18.Text = Val(TextBox16.Text) - Val(TextBox17.Text)
        If DataGridView4.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot2 As Integer = 0
            Dim j As Integer = 0
            For j = 0 To DataGridView4.Rows.Count - 1
                tot2 += DataGridView4.Item(2, j).Value
            Next
            TextBox19.Text = tot2
        Else
            TextBox19.Text = 0
        End If
        TextBox20.Text = Val(TextBox18.Text) - Val(TextBox19.Text)
        Dim sk1X As String
        sk1X = "select * from MADENON"
        Dim adk1X As New SqlClient.SqlDataAdapter(sk1X, cn)
        Dim dsk1X As New DataSet
        adk1X.Fill(dsk1X, "MADENON")
        ComboBox5.DataSource = dsk1X.Tables(0)
        ComboBox5.DisplayMember = "NAMEX"
        ComboBox5.SelectedIndex = -1


        Dim sk15 As String
        sk15 = "select * from AMALEAT_M_V where conf='" & False & "' "
        Dim adk15 As New SqlClient.SqlDataAdapter(sk15, cn)
        Dim dsk15 As New DataSet
        adk15.Fill(dsk15, "AMALEAT_M_V")
        ComboBox13.DataSource = dsk15.Tables(0)
        ComboBox13.DisplayMember = "AML_NAME"
        ComboBox13.SelectedIndex = -1
        Dim sk2 As String
        sk2 = "select * from dn"
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox16.DataSource = dsk2.Tables(0)
        ComboBox16.DisplayMember = "dn"
        ComboBox16.SelectedIndex = -1
        Dim sk22 As String
        sk22 = "select * from dn WHERE IDK=" & 1
        Dim adk22 As New SqlClient.SqlDataAdapter(sk22, cn)
        Dim dsk22 As New DataSet
        adk22.Fill(dsk22, "dn")
        ComboBox14.DataSource = dsk22.Tables(0)
        ComboBox14.DisplayMember = "dn"
        ComboBox14.SelectedIndex = -1
        Dim skF As String
        skF = "select * from AM_FDOC"
        Dim adkF As New SqlClient.SqlDataAdapter(skF, cn)
        Dim dskF As New DataSet
        adkF.Fill(dskF, "AM_FDOC")
        ComboBox18.DataSource = dskF.Tables(0)
        ComboBox18.DisplayMember = "FDOCN"
        ComboBox18.SelectedIndex = -1
        Dim skM As String
        skM = "select * from AM_MDOC"
        Dim adkM As New SqlClient.SqlDataAdapter(skM, cn)
        Dim dskM As New DataSet
        adkM.Fill(dskM, "AM_MDOC")
        ComboBox21.DataSource = dskM.Tables(0)
        ComboBox21.DisplayMember = "MDOCN"
        ComboBox21.SelectedIndex = -1
        Dim skT As String
        skT = "select * from AM_TDOC"
        Dim adkT As New SqlClient.SqlDataAdapter(skT, cn)
        Dim dskT As New DataSet
        adkT.Fill(dskT, "AM_TDOC")
        ComboBox15.DataSource = dskT.Tables(0)
        ComboBox15.DisplayMember = "TDOCN"
        ComboBox15.SelectedIndex = -1
        Dim skKs As String
        skKs = "select * from AM_KAB"
        Dim adkKs As New SqlClient.SqlDataAdapter(skKs, cn)
        Dim dskKs As New DataSet
        adkKs.Fill(dskKs, "AM_KAB")
        ComboBox17.DataSource = dskKs.Tables(0)
        ComboBox17.DisplayMember = "KABN"
        ComboBox17.SelectedIndex = -1
        Dim skFT As String
        skFT = "select * from AM_FTDOC"
        Dim adkFT As New SqlClient.SqlDataAdapter(skFT, cn)
        Dim dskFT As New DataSet
        adkFT.Fill(dskFT, "AM_FTDOC")
        ComboBox19.DataSource = dskFT.Tables(0)
        ComboBox19.DisplayMember = "FTDOCN"
        ComboBox19.SelectedIndex = -1
        Call Class4.CONNIC()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call Class1.CONNIC()
        If TextBox10.Text = "" Then
            MsgBox("يرجى ادخال رقم الإيصال")
            TextBox10.Focus()
        Else
            Call Class1.CONNIC()
            Dim s112 As String = "select * from KASHEF where Esalno=@Esalno"
            Dim cm112 As New SqlClient.SqlCommand(s112, cn)
            cm112.Parameters.AddWithValue("@Esalno", CInt(Me.TextBox10.Text))
            Dim rd112 As SqlClient.SqlDataReader = cm112.ExecuteReader
            If rd112.Read = True Then
                doctornamex = rd112!doctorname
                TextBox2.Text = rd112!doctorname
                madfoox = CDec(rd112!MADFOO)
                TextBox1.Text = CDbl(rd112!MADFOO)
                bakyx = CDec(rd112!BAKY)
                TextBox11.Text = CDbl(rd112!BAKY)
                kemax = rd112!kema
                kematx = CDec(rd112!kemat)
                Label13.Text = CDbl(rd112!kemat)
                Label13.Text = Label13.Text & " " & "دينار"
                DATEXX = rd112!datex
                rd112.Close()
                Dim s As String = "select * from APPOINTMENTVIEW where Esalno=@Esalno"
                Dim cm As New SqlClient.SqlCommand(s, cn)
                cm.Parameters.AddWithValue("@Esalno", CInt(Me.TextBox10.Text))
                Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    doctornamex = rd!DN
                    TextBox2.Text = doctornamex
                    Ejraax = rd!Ejraa
                    chnox = rd!chno
                    fnumberx = rd!fnumber
                    chnox = rd!chno
                    M7 = rd!CHNO
                    esalnox = rd!Esalno
                    namemx = rd!NAMEM
                    jehamx = rd!JEHAM
                    namexx = rd!namex
                    dateax = rd!datea
                    rd.Close()
                    Call Class1.CONNIC()
                    rd.Close()
                    Dim sk2 As String = "select * from DN where DN=@DN"
                    Dim cmk2 As New SqlClient.SqlCommand(sk2, cn)
                    cmk2.Parameters.AddWithValue("@DN", doctornamex)
                    Dim rdK2 As SqlClient.SqlDataReader = cmk2.ExecuteReader
                    If rdK2.Read = True Then
                        TextBox38.Text = rdK2!IDD
                    End If
                    '    madfoox = CDec(rdK2!MADFOO)
                    '    TextBox1.Text = CDbl(rdK2!MADFOO)
                    '    bakyx = CDec(rdK2!BAKY)
                    '    TextBox11.Text = CDbl(rdK2!BAKY)
                    '    rdK2.Close()
                    'End If
                End If


                Dim s11 As String = "select * from KASHEF where conf=@conf and Esalno=@Esalno"
                Dim cm11 As New SqlClient.SqlCommand(s11, cn)
                cm11.Parameters.AddWithValue("@conf", True)
                cm11.Parameters.AddWithValue("@Esalno", Me.TextBox10.Text)
                Dim rd11 As SqlClient.SqlDataReader = cm11.ExecuteReader
                If rd11.Read = True Then
                    fnumberx = rd11!FNUMBER
                    kemax = CDec(rd11!kema)
                    Label13.Text = CDbl(rd11!kemat)
                    Label13.Text = Label13.Text & " " & "دينار"
                    'Button4.Visible = True
                    Button5.Visible = True
                    Button6.Visible = False
                    rd11.Close()
                    Dim sk As String = "select * from KASHEFMAIN where fnumber=@fnumber"
                    Dim cmk As New SqlClient.SqlCommand(sk, cn)
                    cmk.Parameters.AddWithValue("@fnumber", fnumberx)
                    Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
                    If rdK.Read = True Then
                        madfoox = CDec(rdK!MADFOO)
                        TextBox1.Text = CDbl(rdK!MADFOO)
                        bakyx = CDec(rdK!BAKY)
                        TextBox11.Text = CDbl(rdK!BAKY)
                        rdK.Close()
                    End If
                Else
                    Button4.Visible = False
                    Button5.Visible = False
                    Button6.Visible = True
                End If
                rd11.Close()
                Dim skk As String = "select * from doctork where dn=@dn"
                Dim cmkk As New SqlClient.SqlCommand(skk, cn)
                cmkk.Parameters.AddWithValue("@dn", doctornamex)
                Dim rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
                If rdkk.Read = True Then
                    kesemx = rdkk!kesem
                    TextBox3.Text = kesemx
                End If
                rdkk.Close()
                Dim s1 As String = "select * from APPOINTMENTVIEW "
                Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                Dim dss As New DataSet
                dss.Clear()
                aad.Fill(dss, "APPOINTMENTVIEW")
                Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
                If TextBox10.Text = "" Then
                    vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'"
                Else
                    vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND Esalno=" & "" & Me.TextBox10.Text & "" & ""
                End If
                Me.DataGridView1.DataMember = ""
                DataGridView1.DataSource = vd
                TextBox1.Focus()
                If DATEXX <> Date.Today.Date Then
                    Label54.Text = "هذا الحجز بتاريخ" & "  " & Format(DATEXX, "yyyy/MM/dd")
                Else
                    Label54.Text = ""
                End If
            Else
                MsgBox("رقم الايصال غير موجود")
                TextBox10.Text = ""
                TextBox10.Focus()
            End If

            'If Asc(e.KeyChar) = Keys.Enter Then
            '    If TextBox10.Text = "" Then
            '        MsgBox("يرجى ادخال رقم الإيصال")
            '        TextBox10.Focus()
            '    Else
            '        Button7.Focus()
        End If


        'Call Class1.CONNIC()
        'Dim s112 As String = "select * from KASHEF where Esalno=@Esalno and chno<>0"
        'Dim cm112 As New SqlClient.SqlCommand(s112, cn)
        'cm112.Parameters.AddWithValue("@Esalno", CInt(Me.TextBox10.Text))
        'Dim rd112 As SqlClient.SqlDataReader = cm112.ExecuteReader
        'If rd112.Read = True Then
        '    doctornamex = rd112!doctorname
        '    TextBox2.Text = rd112!doctorname
        '    madfoox = CDec(rd112!MADFOO)
        '    TextBox1.Text = CDbl(rd112!MADFOO)
        '    bakyx = CDec(rd112!BAKY)
        '    TextBox11.Text = CDbl(rd112!BAKY)
        '    kemax = rd112!kema
        '    kematx = CDec(rd112!kemat)
        '    Label13.Text = CDbl(rd112!kemat)
        '    Label13.Text = Label13.Text & " " & "دينار"
        '    rd112.Close()
        '    'Dim s As String = "select * from APPOINTMENTVIEW where Esalno=@Esalno"
        '    'Dim cm As New SqlClient.SqlCommand(s, cn)
        '    'cm.Parameters.AddWithValue("@Esalno", CInt(Me.TextBox10.Text))
        '    'Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        '    'If rd.Read = True Then
        '    '    doctornamex = rd!doctorname
        '    '    TextBox2.Text = doctornamex
        '    '    Ejraax = rd!Ejraa
        '    '    chnox = rd!chno
        '    '    fnumberx = rd!fnumber
        '    '    chnox = rd!chno
        '    '    M7 = rd!CHNO
        '    '    esalnox = rd!Esalno
        '    '    namemx = rd!NAMEM
        '    '    jehamx = rd!JEHAM
        '    '    namexx = rd!namex
        '    '    dateax = rd!datea
        '    '    rd.Close()
        '    '    Call Class1.CONNIC()
        '    '    rd.Close()
        '    '    Dim sk2 As String = "select * from KASHEFMAIN where fnumber=@fnumber"
        '    '    Dim cmk2 As New SqlClient.SqlCommand(sk2, cn)
        '    '    cmk2.Parameters.AddWithValue("@fnumber", fnumberx)
        '    '    Dim rdK2 As SqlClient.SqlDataReader = cmk2.ExecuteReader
        '    '    If rdK2.Read = True Then
        '    '        madfoox = CDec(rdK2!MADFOO)
        '    '        TextBox1.Text = CDbl(rdK2!MADFOO)
        '    '        bakyx = CDec(rdK2!BAKY)
        '    '        TextBox11.Text = CDbl(rdK2!BAKY)
        '    '        rdK2.Close()
        '    '    End If
        '    'End If


        '    Dim s11 As String = "select * from KASHEF where conf=@conf and Esalno=@Esalno"
        '    Dim cm11 As New SqlClient.SqlCommand(s11, cn)
        '    cm11.Parameters.AddWithValue("@conf", True)
        '    cm11.Parameters.AddWithValue("@Esalno", Me.TextBox10.Text)
        '    Dim rd11 As SqlClient.SqlDataReader = cm11.ExecuteReader
        '    If rd11.Read = True Then
        '        fnumberx = rd11!FNUMBER
        '        kemax = CDec(rd11!kema)
        '        Label13.Text = CDbl(rd11!kemat)
        '        Label13.Text = Label13.Text & " " & "دينار"
        '        'Button4.Visible = True
        '        Button5.Visible = True
        '        Button6.Visible = False
        '        rd11.Close()
        '        Dim sk As String = "select * from KASHEFMAIN where fnumber=@fnumber"
        '        Dim cmk As New SqlClient.SqlCommand(sk, cn)
        '        cmk.Parameters.AddWithValue("@fnumber", fnumberx)
        '        Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
        '        If rdK.Read = True Then
        '            madfoox = CDec(rdK!MADFOO)
        '            TextBox1.Text = CDbl(rdK!MADFOO)
        '            bakyx = CDec(rdK!BAKY)
        '            TextBox11.Text = CDbl(rdK!BAKY)
        '            rdK.Close()
        '        End If
        '    Else
        '        Button4.Visible = False
        '        Button5.Visible = False
        '        Button6.Visible = True
        '    End If
        '    rd11.Close()
        '    Dim skk As String = "select * from doctork where dn=@dn"
        '    Dim cmkk As New SqlClient.SqlCommand(skk, cn)
        '    cmkk.Parameters.AddWithValue("@dn", doctornamex)
        '    Dim rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
        '    If rdkk.Read = True Then
        '        kesemx = rdkk!kesem
        '        TextBox3.Text = kesemx
        '    End If
        '    rdkk.Close()
        '    Dim s1 As String = "select * from APPOINTMENTVIEW "
        '    Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        '    Dim dss As New DataSet
        '    dss.Clear()
        '    aad.Fill(dss, "APPOINTMENTVIEW")
        '    Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
        '    If TextBox10.Text = "" Then
        '        vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'"
        '    Else
        '        vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND Esalno=" & "" & Me.TextBox10.Text & "" & ""
        '    End If
        '    Me.DataGridView1.DataMember = ""
        '    DataGridView1.DataSource = vd
        '    TextBox1.Focus()
        'Else
        '    MsgBox("رقم الايصال غير موجود")
        '    TextBox10.Text = ""
        '    TextBox10.Focus()
        'End If
        Call Class4.CONNIC()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call Class1.CONNIC()
        Dim ss21 As String = "update kashef set fnumber=@fnumber,DATEX=@DATEX,doctorname=@doctorname,KEMA=@KEMA,KEMAT=@KEMAT,MADFOO=@MADFOO,BAKY=@BAKY,conf=@conf,USER_NAME=@USER_NAME" & vbNewLine &
                      "where Esalno=@Esalno"
        '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
        Dim cmm21 As New SqlClient.SqlCommand(ss21, cn)
        cmm21.Parameters.AddWithValue("@fnumber", CInt(fnumberx))
        cmm21.Parameters.AddWithValue("@DATEX", Date.Today.Date)
        cmm21.Parameters.AddWithValue("@doctorname", TextBox38.Text)
        cmm21.Parameters.AddWithValue("@KEMA", CDec(kemax))
        cmm21.Parameters.AddWithValue("@KEMAT", CDec(kematx))
        cmm21.Parameters.AddWithValue("@MADFOO", CDec(0))
        cmm21.Parameters.AddWithValue("@BAKY", CDec(Val(TextBox1.Text) + Val(TextBox11.Text)))
        cmm21.Parameters.AddWithValue("@conf", False)
        cmm21.Parameters.AddWithValue("@USER_NAME", user)
        cmm21.Parameters.AddWithValue("@Esalno", Me.TextBox10.Text)
        Try
            cmm21.ExecuteNonQuery()
            Dim s222 As String = "insert into SADAD(ESALNO,DATEXX,SADAD) values(@ESALNO,@DATEXX,@SADAD)"
            Dim cm222 As New SqlClient.SqlCommand(s222, cn)
            cm222.Parameters.AddWithValue("@ESALNO", TextBox10.Text)
            cm222.Parameters.AddWithValue("@DATEXX", Date.Today.Date)
            cm222.Parameters.AddWithValue("@SADAD", CDbl(-Me.TextBox1.Text))
            Try
                cm222.ExecuteNonQuery()
                MsgBox("تم إرجاع القيمة")
            Catch ex As Exception

            End Try
            'Dim cr1 As New CrystalReport31, cri As String
            'cri = "{KASHEF.ESALNO}=" & "" & esalnox & ""
            'KESEM_P = TextBox3.Text
            'cr1.SetParameterValue(0, Me.KESEM_P)
            'cr1.RecordSelectionFormula = cri
            'cr1.PrintOptions.PrinterName = "PR"
            'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
            ''cr1.PrintOptions.PrinterName = "LK-TE212"
            'cr1.PrintToPrinter(1, False, 1, 1)


        Catch ex As Exception
            'MsgBox("no print")
        End Try
        'Dim ss21 As String = "insert into kashef(fnumber,CHNO,DATEX,doctorname,KEMA,KEMAT,MADFOO,BAKY,conf) VALUES(@fnumber,@CHNO,@DATEX,@doctorname,@KEMA,@KEMAT,@MADFOO,@BAKY,@conf)"
        ''    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
        'Dim cmm21 As New SqlClient.SqlCommand(ss21, cn)
        'cmm21.Parameters.AddWithValue("@fnumber", TextBox2.Text)
        'cmm21.Parameters.AddWithValue("@CHNO", Me.NumericUpDown1.Text)
        'cmm21.Parameters.AddWithValue("@DATEX", Me.DateTimePicker3.Text)
        'cmm21.Parameters.AddWithValue("@doctorname", Me.ComboBox2.Text)
        ''cmm21.Parameters.AddWithValue("@X5", M6)
        'cmm21.Parameters.AddWithValue("@KEMA", TextBox6.Text)
        'cmm21.Parameters.AddWithValue("@KEMAT", TextBox5.Text)
        'TextBox10.Text = Val(TextBox12.Text) - Val(TextBox10.Text)
        'cmm21.Parameters.AddWithValue("@MADFOO", TextBox10.Text)
        'TextBox11.Text = Val(TextBox11.Text) + Val(TextBox10.Text)
        'cmm21.Parameters.AddWithValue("@BAKY", TextBox11.Text)
        'cmm21.Parameters.AddWithValue("@conf", False)
        'If MsgBox("هل تريد إرجاع القيمة", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    Try
        '        cmm21.ExecuteNonQuery()
        '        MsgBox("تم ارجاع القيمة")
        '    Catch ex As Exception

        '    End Try

        'Dim sd As String = "delete from kashef where Esalno=@Esalno"
        'Dim cd As New SqlClient.SqlCommand(sd, cn)
        'cd.Parameters.AddWithValue("@Esalno", CInt(Me.Label10.Text))
        'If MsgBox("هل تريد إرجاع القيمة", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    'Try
        '    cd.ExecuteNonQuery()
        '    Dim sd1 As String = "delete * from appointment where Esalno=@Esalno"
        '    Dim cd1 As New SqlClient.SqlCommand(sd1, cn)
        '    cd1.Parameters.AddWithValue("@Esalno", Me.Label10.Text)
        '    If MsgBox("هل تريد إلغاء الحجز", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '        Try
        '            cd1.ExecuteNonQuery()
        '        Catch ex As Exception

        '        End Try
        '    End If

        'Catch ex As Exception

        'End Try
        Dim s16 As String = "select * from APPOINTMENTVIEW "
        Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "APPOINTMENTVIEW")
        Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
        vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND Esalno=" & "'" & Me.TextBox10.Text & "'" & ""
        Me.DataGridView1.DataMember = ""
        DataGridView1.DataSource = vd
        'End If
        TextBox1.Text = ""
        TextBox11.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox10.Text = ""
        TextBox10.Focus()
        Call Class4.CONNIC()
    End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    Dim ss21 As String = "update kashef set fnumber=@fnumber,DATEX=@DATEX,doctorname=@doctorname,KEMA=@KEMA,KEMAT=@KEMAT,MADFOO=@MADFOO,BAKY=@BAKY,conf=@conf,USER_NAME=@USER_NAME" & vbNewLine &
    '                 "where Esalno=@Esalno"
    '    '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
    '    Dim cmm21 As New SqlClient.SqlCommand(ss21, cn)
    '    cmm21.Parameters.AddWithValue("@fnumber", TextBox2.Text)
    '    ' cmm21.Parameters.AddWithValue("@CHNO", Me.NumericUpDown1.Text)
    '    cmm21.Parameters.AddWithValue("@DATEX", Me.DateTimePicker3.Text)
    '    cmm21.Parameters.AddWithValue("@doctorname", Me.ComboBox2.Text)
    '    'cmm21.Parameters.AddWithValue("@KEMA", M6)
    '    cmm21.Parameters.AddWithValue("@KEMA", TextBox6.Text)
    '    cmm21.Parameters.AddWithValue("@KEMAT", TextBox5.Text)
    '    cmm21.Parameters.AddWithValue("@MADFOO", TextBox10.Text)
    '    cmm21.Parameters.AddWithValue("@BAKY", TextBox11.Text)
    '    cmm21.Parameters.AddWithValue("@conf", True)
    '    cmm21.Parameters.AddWithValue("@USER_NAME", user)
    '    cmm21.Parameters.AddWithValue("@Esalno", Label10.Text)
    '    Try
    '        'Dim sd1 As String = "delete * from appointment where Esalno=xx"
    '        'Dim cd1 As New SqlClient.SqlCommand(sd1, cn)
    '        'cd1.Parameters.AddWithValue("xx", Me.Label10.Text)
    '        'Try
    '        '    cd1.ExecuteNonQuery()
    '        'Catch ex As Exception

    '        'End Try
    '        'Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,doctorname,IDM,EJRAA,Esalno)VALUES(XX@xx1,XXXX2,xxxx3,xxxx6,xxxx7,xxxx8,xxxx9)"
    '        ''    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
    '        'Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
    '        ''cmm2.Parameters.AddWithValue("XX", Label10.Text)
    '        'cmm2.Parameters.AddWithValue("xx@xx1", TextBox2.Text)
    '        'cmm2.Parameters.AddWithValue("xxxx2", M7)
    '        'cmm2.Parameters.AddWithValue("xxxx3", Me.DateTimePicker3.Text)
    '        ''cmm2.Parameters.AddWithValue("xxxx4", Me.MaskedTextBox2.Text)
    '        ''cmm2.Parameters.AddWithValue("xxxx5", Me.MaskedTextBox3.Text)
    '        'cmm2.Parameters.AddWithValue("xxxx6", Me.ComboBox2.Text)
    '        'cmm2.Parameters.AddWithValue("xxxx7", 1)
    '        'cmm2.Parameters.AddWithValue("xxxx8", Me.ComboBox3.Text)
    '        'cmm2.Parameters.AddWithValue("xxxx9", Label10.Text)
    '        ''Try
    '        '' cmm.ExecuteNonQuery()
    '        'cmm2.ExecuteNonQuery()

    '        cmm21.ExecuteNonQuery()
    '        'MsgBox("تم تأكيد الحجز")
    '        vv1 = CInt(Label10.Text)
    '        Dim F As New ESALHAJEZ
    '        F.KESEM_P = Label14.Text
    '        F.ShowDialog()

    'End Sub

    Private Sub ToolStripStatusLabel5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Call Class1.CONNIC()
        Dim i As Integer
        i = e.RowIndex
        If Val(i) >= 0 Then
            Dim dgx As Integer
            dgx = DataGridView1.Item(0, i).Value()
            Call Class1.CONNIC()
            Dim s As String = "select * from APPOINTMENTVIEW where Esalno=@Esalno"
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@Esalno", dgx)
            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            If rd.Read = True Then
                doctornamex = rd!doctorname
                ComboBox2.Text = rd!doctorname
                Ejraax = rd!Ejraa
                chnox = rd!chno
                fnumberx = rd!fnumber
                chnox = rd!chno
                M7 = rd!CHNO
                esalnox = rd!Esalno
                namemx = rd!NAMEM
                jehamx = rd!JEHAM
                namexx = rd!namex
                dateax = rd!datea
                rd.Close()
                Call Class1.CONNIC()
                rd.Close()
                Dim s112 As String = "select * from KASHEF where Esalno=@Esalno"
                Dim cm112 As New SqlClient.SqlCommand(s112, cn)
                cm112.Parameters.AddWithValue("@Esalno", dgx)
                Dim rd112 As SqlClient.SqlDataReader = cm112.ExecuteReader
                If rd112.Read = True Then
                    kemax = CDec(rd112!kema)
                    Label13.Text = CDbl(rd112!kemat)
                    rd112.Close()
                    Dim sk2 As String = "select * from KASHEFMAIN where fnumber=@fnumber"
                    Dim cmk2 As New SqlClient.SqlCommand(sk2, cn)
                    cmk2.Parameters.AddWithValue("@fnumber", fnumberx)
                    Dim rdK2 As SqlClient.SqlDataReader = cmk2.ExecuteReader
                    If rdK2.Read = True Then
                        madfoox = CDec(rdK2!MADFOO)
                        TextBox1.Text = CDbl(rdK2!MADFOO)
                        bakyx = CDec(rdK2!BAKY)
                        TextBox11.Text = CDbl(rdK2!BAKY)
                        rdK2.Close()
                    End If
                End If


                Dim s11 As String = "select * from KASHEF where conf=@conf and Esalno=@Esalno"
                Dim cm11 As New SqlClient.SqlCommand(s11, cn)
                cm11.Parameters.AddWithValue("@conf", True)
                cm11.Parameters.AddWithValue("@Esalno", dgx)
                Dim rd11 As SqlClient.SqlDataReader = cm11.ExecuteReader
                If rd11.Read = True Then
                    kemax = CDec(rd11!kema)
                    Label13.Text = CDbl(rd11!kemat)
                    'Button4.Visible = True
                    Button5.Visible = True
                    Button6.Visible = False
                    rd11.Close()
                    Dim sk As String = "select * from KASHEFMAIN where fnumber=@fnumber"
                    Dim cmk As New SqlClient.SqlCommand(sk, cn)
                    cmk.Parameters.AddWithValue("@fnumber", fnumberx)
                    Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
                    If rdK.Read = True Then
                        madfoox = CDec(rdK!MADFOO)
                        TextBox1.Text = CDbl(rdK!MADFOO)
                        bakyx = CDec(rdK!BAKY)
                        TextBox11.Text = CDbl(rdK!BAKY)
                        rdK.Close()
                    End If
                Else
                    Button4.Visible = False
                    Button5.Visible = False
                    Button6.Visible = True
                End If
                rd11.Close()
                Dim skk As String = "select * from doctork where dn=@dn"
                Dim cmkk As New SqlClient.SqlCommand(skk, cn)
                cmkk.Parameters.AddWithValue("@dn", doctornamex)
                Dim rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
                If rdkk.Read = True Then
                    kesemx = rdkk!kesem
                End If
                rdkk.Close()

            End If

        End If
        Call Class4.CONNIC()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call Class1.CONNIC()
        Dim i As Integer
        i = e.RowIndex
        If Val(i) >= 0 Then
            Dim dgx As Integer
            dgx = DataGridView1.Item(0, i).Value()
            Call Class1.CONNIC()
            Dim s As String = "select * from APPOINTMENTVIEW where Esalno=@Esalno"
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@Esalno", dgx)
            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            If rd.Read = True Then
                doctornamex = rd!doctorname
                ComboBox2.Text = rd!doctorname
                Ejraax = rd!Ejraa
                chnox = rd!chno
                fnumberx = rd!fnumber
                chnox = rd!chno
                M7 = rd!CHNO
                esalnox = rd!Esalno
                TextBox10.Text = rd!Esalno
                namemx = rd!NAMEM
                jehamx = rd!JEHAM
                namexx = rd!namex
                dateax = rd!datea
                rd.Close()
                Call Class1.CONNIC()
                rd.Close()
                Dim s112 As String = "select * from KASHEF where Esalno=@Esalno"
                Dim cm112 As New SqlClient.SqlCommand(s112, cn)
                cm112.Parameters.AddWithValue("@Esalno", dgx)
                Dim rd112 As SqlClient.SqlDataReader = cm112.ExecuteReader
                If rd112.Read = True Then
                    kemax = CDec(rd112!kema)
                    Label13.Text = CDbl(rd112!kemat)
                    rd112.Close()
                    Dim sk2 As String = "select * from KASHEFMAIN where fnumber=@fnumber"
                    Dim cmk2 As New SqlClient.SqlCommand(sk2, cn)
                    cmk2.Parameters.AddWithValue("@fnumber", fnumberx)
                    Dim rdK2 As SqlClient.SqlDataReader = cmk2.ExecuteReader
                    If rdK2.Read = True Then
                        madfoox = CDec(rdK2!MADFOO)
                        TextBox1.Text = CDbl(rdK2!MADFOO)
                        bakyx = CDec(rdK2!BAKY)
                        TextBox11.Text = CDbl(rdK2!BAKY)
                        rdK2.Close()
                    End If
                End If


                Dim s11 As String = "select * from KASHEF where conf=@conf and Esalno=@Esalno"
                Dim cm11 As New SqlClient.SqlCommand(s11, cn)
                cm11.Parameters.AddWithValue("@conf", True)
                cm11.Parameters.AddWithValue("@Esalno", dgx)
                Dim rd11 As SqlClient.SqlDataReader = cm11.ExecuteReader
                If rd11.Read = True Then
                    kemax = CDec(rd11!kema)
                    Label13.Text = CDbl(rd11!kemat)
                    'Button4.Visible = True
                    Button5.Visible = True
                    Button6.Visible = False
                    rd11.Close()
                    Dim sk As String = "select * from KASHEFMAIN where fnumber=@fnumber"
                    Dim cmk As New SqlClient.SqlCommand(sk, cn)
                    cmk.Parameters.AddWithValue("@fnumber", fnumberx)
                    Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
                    If rdK.Read = True Then
                        madfoox = CDec(rdK!MADFOO)
                        TextBox1.Text = CDbl(rdK!MADFOO)
                        bakyx = CDec(rdK!BAKY)
                        TextBox11.Text = CDbl(rdK!BAKY)
                        rdK.Close()
                    End If
                Else
                    Button4.Visible = False
                    Button5.Visible = False
                    Button6.Visible = True
                End If
                rd11.Close()
                Dim skk As String = "select * from doctork where dn=@dn"
                Dim cmkk As New SqlClient.SqlCommand(skk, cn)
                cmkk.Parameters.AddWithValue("@dn", TextBox2.Text)
                Dim rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
                If rdkk.Read = True Then
                    kesemx = rdkk!kesem
                End If
                rdkk.Close()

            End If

        End If
        TextBox1.Focus()
        Call Class4.CONNIC()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call Class1.CONNIC()
        'Dim ss21 As String = "update kashef set fnumber=@fnumber,DATEX=@DATEX,doctorname=@doctorname,KEMA=@KEMA,KEMAT=@KEMAT,MADFOO=@MADFOO,BAKY=@BAKY,conf=@conf,USER_NAME=@USER_NAME" & vbNewLine &
        '                      "where Esalno=@Esalno"
        Dim ss21 As String = "update kashef set MADFOO=@MADFOO,BAKY=@BAKY,conf=@conf,USER_NAME=@USER_NAME" & vbNewLine &
                              "where Esalno=@Esalno"
        '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
        Dim cmm21 As New SqlClient.SqlCommand(ss21, cn)
        'cmm21.Parameters.AddWithValue("@fnumber", CInt(fnumberx))
        'cmm21.Parameters.AddWithValue("@DATEX", Date.Today.Date)
        'cmm21.Parameters.AddWithValue("@doctorname", TextBox2.Text)
        'cmm21.Parameters.AddWithValue("@KEMA", CDec(kemax))
        'cmm21.Parameters.AddWithValue("@KEMAT", CDec(kematx))
        cmm21.Parameters.AddWithValue("@MADFOO", CDec(TextBox1.Text))
        cmm21.Parameters.AddWithValue("@BAKY", CDec(TextBox11.Text))
        cmm21.Parameters.AddWithValue("@conf", True)
        cmm21.Parameters.AddWithValue("@USER_NAME", user)
        cmm21.Parameters.AddWithValue("@Esalno", Me.TextBox10.Text)
        'Try
        cmm21.ExecuteNonQuery()
        Dim s222 As String = "insert into SADAD(ESALNO,DATEXX,SADAD) values(@ESALNO,@DATEXX,@SADAD)"
        Dim cm222 As New SqlClient.SqlCommand(s222, cn)
        cm222.Parameters.AddWithValue("@ESALNO", TextBox10.Text)
        cm222.Parameters.AddWithValue("@DATEXX", Date.Today.Date)
        cm222.Parameters.AddWithValue("@SADAD", CDbl(Me.TextBox1.Text))
        Try
            cm222.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        esalnox = CInt(TextBox10.Text)
        'Dim cr1 As New CrystalReport31, cri As String
        'cri = "{KASHEF.ESALNO}=" & "" & esalnox & ""
        'KESEM_P = TextBox3.Text
        'HOR = HANY(Me.TextBox1.Text, "IRAQ")
        ''Dim RM As Resources.ResourceManager
        ''RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
        ''NAMEC = RM.GetString("NAMECLINIC")
        'NAMEC = My.Settings.CLIN
        'cr1.SetParameterValue(0, Me.KESEM_P)
        'cr1.SetParameterValue(1, Me.NAMEC)
        'cr1.SetParameterValue(2, Me.HOR)
        'cr1.RecordSelectionFormula = cri
        'cr1.PrintOptions.PrinterName = "PR"
        'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
        ''cr1.PrintOptions.PrinterName = "LK-TE212"
        'cr1.PrintToPrinter(1, False, 1, 1)
        'Dim crtableLogoninfos As New TableLogOnInfos()
        'Dim crtableLogoninfo As New TableLogOnInfo()
        'Dim crConnectionInfo As New ConnectionInfo()
        'Dim CrTables As Tables
        'Dim CrTable As Table
        'Dim TableCounter
        'Dim reader As New System.IO.StreamReader("server.txt")
        'Dim allLines As List(Of String) = New List(Of String)
        'Do While Not reader.EndOfStream
        '    allLines.Add(reader.ReadLine())
        'Loop
        'reader.Close()
        'Dim crReportDocument As New CrystalReport31(), cri2 As String
        'crReportDocument.Load("CrystalReport31.rpt")
        'cri2 = "{KASHEF.ESALNO}=" & "" & M6 & ""
        'KESEM_P = TextBox8.Text
        'NAMEC = My.Settings.CLIN
        'With crConnectionInfo
        '    .ServerName = ReadLine(2, allLines)
        '    .DatabaseName = ReadLine(1, allLines)
        '    .UserID = "AH"
        '    .Password = "123456"
        'End With
        'CrTables = crReportDocument.Database.Tables
        'For Each CrTable In CrTables
        '    crtableLogoninfo = CrTable.LogOnInfo
        '    crtableLogoninfo.ConnectionInfo =
        '    crConnectionInfo
        '    CrTable.ApplyLogOnInfo(crtableLogoninfo)
        '    CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
        '    CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
        'Next
        'crReportDocument.SetParameterValue(0, Me.KESEM_P)
        'crReportDocument.SetParameterValue(1, Me.NAMEC)
        'crReportDocument.SetParameterValue(2, Me.HOR)
        'crReportDocument.RecordSelectionFormula = cri2
        'crReportDocument.PrintOptions.PrinterName = My.Settings.printerx2
        'crReportDocument.PrintToPrinter(1, True, 0, 0)
        'crReportDocument.Close()
        'crReportDocument.Dispose()

        'Dim crtableLogoninfos2 As New TableLogOnInfos()
        ''Dim crtableLogoninfo2 As New TableLogOnInfo()
        ''Dim crConnectionInfo2 As New ConnectionInfo()
        ''Dim CrTables2 As Tables
        ''Dim CrTable2 As Table
        ''Dim TableCounter2

        'Dim crReportDocument2 As New CrystalReport34(), cri22 As String
        'crReportDocument2.Load("CrystalReport34.rpt")
        'cri22 = "{KASHEF.ESALNO}=" & "" & M6 & ""
        'KESEM_P = TextBox8.Text
        'NAMEC = My.Settings.CLIN
        'With crConnectionInfo
        '    .ServerName = ReadLine(2, allLines)
        '    .DatabaseName = ReadLine(1, allLines)
        '    .UserID = "AH"
        '    .Password = "123456"
        'End With
        'CrTables = crReportDocument2.Database.Tables
        'For Each CrTable In CrTables
        '    crtableLogoninfo = CrTable.LogOnInfo
        '    crtableLogoninfo.ConnectionInfo =
        '    crConnectionInfo
        '    CrTable.ApplyLogOnInfo(crtableLogoninfo)
        '    CrTable.Location = crConnectionInfo.DatabaseName & ".dbo." &
        '    CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)
        'Next
        'crReportDocument2.SetParameterValue(0, Me.KESEM_P)
        'crReportDocument2.SetParameterValue(1, Me.NAMEC)
        'crReportDocument2.SetParameterValue(2, Me.HOR)
        'crReportDocument2.RecordSelectionFormula = cri22
        'crReportDocument2.PrintOptions.PrinterName = My.Settings.printerx2
        'crReportDocument2.PrintToPrinter(1, True, 0, 0)
        'crReportDocument2.Close()
        'crReportDocument2.Dispose()

        'Dim cr2 As New CrystalReport43, cri2 As String
        'cri2 = "{KASHEF.ESALNO}=" & "" & esalnox & ""
        'KESEM_P = TextBox3.Text
        'USER_NAME = user
        'HOR = HANY(Me.TextBox1.Text, "IRAQ")
        'NAMEC = My.Settings.CLIN
        'cr2.SetParameterValue(0, Me.NAMEC)
        'cr2.SetParameterValue(1, Me.HOR)
        'cr2.SetParameterValue(2, Me.KESEM_P)
        'cr2.SetParameterValue(3, Me.USER_NAME)
        'cr2.RecordSelectionFormula = cri2
        ''cr2.PrintOptions.PrinterName = "HP1102"
        'cr2.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
        'cr2.PrintToPrinter(1, False, 1, 1)

        TextBox1.Text = ""
        TextBox11.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox10.Text = ""
        TextBox10.Focus()

        'Catch ex As Exception
        '    MsgBox("no print")
        'End Try



        Call Class4.CONNIC()

    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B1.Text
        Bk = B1.Text
        TextBox8.Text = B1.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B1.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        'Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 "
        'Dim cmn0 As New SqlClient.SqlCommand(sn0, cn)
        'cmn0.Parameters.AddWithValue("@xx1", Ejraax)
        'Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
        'If rdn0.Read = True Then
        '    Me.Label2.Text = rdn0!idJ
        'End If
        'rdn0.Close()
        'Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        'Dim cmn10 As New SqlClient.SqlCommand(sn10, cn)
        'cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
        'cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
        'Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
        'If rdn10.Read = True Then
        '    kematx = rdn10!kema
        '    kemax = rdn10!kemaej
        '    Me.Label13.Text = rdn10!kemaej
        '    Me.TextBox11.Text = rdn10!kemaej
        'End If
        'rdn10.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B2.Text
        bk = B2.Text
        TextBox8.Text = B2.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B2.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        'Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 "
        'Dim cmn0 As New SqlClient.SqlCommand(sn0, cn)
        'cmn0.Parameters.AddWithValue("@xx1", Ejraax)
        'Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
        'If rdn0.Read = True Then
        '    Me.Label2.Text = rdn0!idJ
        'End If
        'rdn0.Close()
        'Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        'Dim cmn10 As New SqlClient.SqlCommand(sn10, cn)
        'cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
        'cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
        'Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
        'If rdn10.Read = True Then
        '    kematx = rdn10!kema
        '    kemax = rdn10!kemaej
        '    Me.Label13.Text = rdn10!kemaej
        '    Me.TextBox11.Text = rdn10!kemaej
        'End If
        'rdn10.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B3.Text
        bk = B3.Text
        TextBox8.Text = B3.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B3.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        'Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 "
        'Dim cmn0 As New SqlClient.SqlCommand(sn0, cn)
        'cmn0.Parameters.AddWithValue("@xx1", Ejraax)
        'Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
        'If rdn0.Read = True Then
        '    Me.Label2.Text = rdn0!idJ
        'End If
        'rdn0.Close()
        'Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        'Dim cmn10 As New SqlClient.SqlCommand(sn10, cn)
        'cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
        'cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
        'Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
        'If rdn10.Read = True Then
        '    kematx = rdn10!kema
        '    kemax = rdn10!kemaej
        '    Me.Label13.Text = rdn10!kemaej
        '    Me.TextBox11.Text = rdn10!kemaej
        'End If
        'rdn10.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B4.Text
        bk = B4.Text
        TextBox8.Text = B4.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B4.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        'Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 "
        'Dim cmn0 As New SqlClient.SqlCommand(sn0, cn)
        'cmn0.Parameters.AddWithValue("@xx1", Ejraax)
        'Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
        'If rdn0.Read = True Then
        '    Me.Label2.Text = rdn0!idJ
        'End If
        'rdn0.Close()
        'Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        'Dim cmn10 As New SqlClient.SqlCommand(sn10, cn)
        'cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
        'cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
        'Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
        'If rdn10.Read = True Then
        '    kematx = rdn10!kema
        '    kemax = rdn10!kemaej
        '    Me.Label13.Text = rdn10!kemaej
        '    Me.TextBox11.Text = rdn10!kemaej
        'End If
        'rdn10.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B5.Text
        bk = B5.Text
        TextBox8.Text = B5.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B5.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        'Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 "
        'Dim cmn0 As New SqlClient.SqlCommand(sn0, cn)
        'cmn0.Parameters.AddWithValue("@xx1", Ejraax)
        'Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
        'If rdn0.Read = True Then
        '    Me.Label2.Text = rdn0!idJ
        'End If
        'rdn0.Close()
        'Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        'Dim cmn10 As New SqlClient.SqlCommand(sn10, cn)
        'cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
        'cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
        'Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
        'If rdn10.Read = True Then
        '    kematx = rdn10!kema
        '    kemax = rdn10!kemaej
        '    Me.Label13.Text = rdn10!kemaej
        '    Me.TextBox11.Text = rdn10!kemaej
        'End If
        'rdn10.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B6.Text
        bk = B6.Text
        TextBox8.Text = B6.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B6.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        'Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 "
        'Dim cmn0 As New SqlClient.SqlCommand(sn0, cn)
        'cmn0.Parameters.AddWithValue("@xx1", Ejraax)
        'Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
        'If rdn0.Read = True Then
        '    Me.Label2.Text = rdn0!idJ
        'End If
        'rdn0.Close()
        'Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        'Dim cmn10 As New SqlClient.SqlCommand(sn10, cn)
        'cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
        'cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
        'Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
        'If rdn10.Read = True Then
        '    kematx = rdn10!kema
        '    kemax = rdn10!kemaej
        '    Me.Label13.Text = rdn10!kemaej
        '    Me.TextBox11.Text = rdn10!kemaej
        'End If
        'rdn10.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B7.Text
        bk = B7.Text
        TextBox8.Text = B7.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B7.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B8.Text
        bk = B8.Text
        TextBox8.Text = B8.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B8.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        'Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 "
        'Dim cmn0 As New SqlClient.SqlCommand(sn0, cn)
        'cmn0.Parameters.AddWithValue("@xx1", Ejraax)
        'Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
        'If rdn0.Read = True Then
        '    Me.Label2.Text = rdn0!idJ
        'End If
        'rdn0.Close()
        'Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        'Dim cmn10 As New SqlClient.SqlCommand(sn10, cn)
        'cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
        'cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
        'Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
        'If rdn10.Read = True Then
        '    kematx = rdn10!kema
        '    kemax = rdn10!kemaej
        '    Me.Label13.Text = rdn10!kemaej
        '    Me.TextBox11.Text = rdn10!kemaej
        'End If
        'rdn10.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B9.Text
        bk = B9.Text
        TextBox8.Text = B9.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B9.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        'Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 "
        'Dim cmn0 As New SqlClient.SqlCommand(sn0, cn)
        'cmn0.Parameters.AddWithValue("@xx1", Ejraax)
        'Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
        'If rdn0.Read = True Then
        '    Me.Label2.Text = rdn0!idJ
        'End If
        'rdn0.Close()
        'Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        'Dim cmn10 As New SqlClient.SqlCommand(sn10, cn)
        'cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
        'cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
        'Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
        'If rdn10.Read = True Then
        '    kematx = rdn10!kema
        '    kemax = rdn10!kemaej
        '    Me.Label13.Text = rdn10!kemaej
        '    Me.TextBox11.Text = rdn10!kemaej
        'End If
        'rdn10.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B10_Click(sender As Object, e As EventArgs) Handles B10.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B10.Text
        bk = B10.Text
        TextBox8.Text = B10.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B10.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        'Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 "
        'Dim cmn0 As New SqlClient.SqlCommand(sn0, cn)
        'cmn0.Parameters.AddWithValue("@xx1", Ejraax)
        'Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
        'If rdn0.Read = True Then
        '    Me.Label2.Text = rdn0!idJ
        'End If
        'rdn0.Close()
        'Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        'Dim cmn10 As New SqlClient.SqlCommand(sn10, cn)
        'cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
        'cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
        'Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
        'If rdn10.Read = True Then
        '    kematx = rdn10!kema
        '    kemax = rdn10!kemaej
        '    Me.Label13.Text = rdn10!kemaej
        '    Me.TextBox11.Text = rdn10!kemaej
        'End If
        'rdn10.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B11.Text
        bk = B11.Text
        TextBox8.Text = B11.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B11.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        'Dim sn0 As String = "select * from Ejraa where Ejraa=@xx1 "
        'Dim cmn0 As New SqlClient.SqlCommand(sn0, cn)
        'cmn0.Parameters.AddWithValue("@xx1", Ejraax)
        'Dim rdn0 As SqlClient.SqlDataReader = cmn0.ExecuteReader
        'If rdn0.Read = True Then
        '    Me.Label2.Text = rdn0!idJ
        'End If
        'rdn0.Close()
        'Dim sn10 As String = "select * from dnkema where Ejraa=@xxx1 and IDD=@xxx2 "
        'Dim cmn10 As New SqlClient.SqlCommand(sn10, cn)
        'cmn10.Parameters.AddWithValue("@xxx1", Label2.Text)
        'cmn10.Parameters.AddWithValue("@xxx2", Label4.Text)
        'Dim rdn10 As SqlClient.SqlDataReader = cmn10.ExecuteReader
        'If rdn10.Read = True Then
        '    kematx = rdn10!kema
        '    kemax = rdn10!kemaej
        '    Me.Label13.Text = rdn10!kemaej
        '    Me.TextBox11.Text = rdn10!kemaej
        'End If
        'rdn10.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B12_Click(sender As Object, e As EventArgs) Handles B12.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B12.Text
        bk = B12.Text
        TextBox8.Text = B12.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B12.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()
    End Sub

    Private Sub b13_Click(sender As Object, e As EventArgs) Handles b13.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = b13.Text
        bk = b13.Text
        TextBox8.Text = b13.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", b13.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub b14_Click(sender As Object, e As EventArgs) Handles b14.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = b14.Text
        bk = b14.Text
        TextBox8.Text = b14.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", b14.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Class1.CONNIC()
        'Dim ss21 As String = "update kashef set fnumber=@fnumber,DATEX=@DATEX,doctorname=@doctorname,KEMA=@KEMA,KEMAT=@KEMAT,MADFOO=@MADFOO,BAKY=@BAKY,conf=@conf,USER_NAME=@USER_NAME" & vbNewLine &
        '"where Esalno=@Esalno"
        Dim ss21 As String = "update kashef set MADFOO=@MADFOO,BAKY=@BAKY,conf=@conf,USER_NAME=@USER_NAME" & vbNewLine &
                      "where Esalno=@Esalno"
        '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
        Dim cmm21 As New SqlClient.SqlCommand(ss21, cn)
        'cmm21.Parameters.AddWithValue("@fnumber", CInt(fnumberx))
        'cmm21.Parameters.AddWithValue("@DATEX", Date.Today.Date)
        'cmm21.Parameters.AddWithValue("@doctorname", doctornamex)
        'cmm21.Parameters.AddWithValue("@KEMA", CDec(kemax))
        'cmm21.Parameters.AddWithValue("@KEMAT", CDec(kematx))
        cmm21.Parameters.AddWithValue("@MADFOO", CDec(TextBox1.Text))
        cmm21.Parameters.AddWithValue("@BAKY", CDec(TextBox11.Text))
        cmm21.Parameters.AddWithValue("@conf", CBool(True))
        cmm21.Parameters.AddWithValue("@USER_NAME", CChar(user))
        cmm21.Parameters.AddWithValue("@Esalno", CInt(Me.TextBox10.Text))
        Try
            cmm21.ExecuteNonQuery()
            MsgBox("تم تعديل الإيصال ")
            Dim cr1 As New CrystalReport31, cri As String
            cri = "{KASHEF.ESALNO}=" & "" & esalnox & ""
            KESEM_P = TextBox3.Text
            cr1.SetParameterValue(0, Me.KESEM_P)
            cr1.RecordSelectionFormula = cri
            cr1.PrintOptions.PrinterName = "PR"
            cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
            'cr1.PrintOptions.PrinterName = "LK-TE212"
            cr1.PrintToPrinter(1, False, 1, 1)


        Catch ex As Exception
            MsgBox("لم يتم تعديل الإيصال ")
        End Try
        Dim ss2 As String = "update appointment set fnumber=@fnumber,CHNO=@CHNO,doctorname=@doctorname,EJRAA=@EJRAA" & vbNewLine &
                     "where Esalno = @Esalno"
        '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XX@xx1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
        Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
        cmm2.Parameters.AddWithValue("@fnumber", CInt(fnumberx))
        cmm2.Parameters.AddWithValue("@CHNO", CInt(chnox))
        'cmm2.Parameters.AddWithValue("xxxx4", Me.MaskedTextBox2.Text)
        'cmm2.Parameters.AddWithValue("xxxx5", Me.MaskedTextBox3.Text)
        cmm2.Parameters.AddWithValue("@doctorname", CChar(doctornamex))
        cmm2.Parameters.AddWithValue("@EJRAA", CChar(Ejraax))
        cmm2.Parameters.AddWithValue("@Esalno", CInt(TextBox10.Text))
        Try
            cmm2.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        TextBox1.Text = ""
        TextBox11.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox10.Text = ""
        TextBox10.Focus()
        Call Class4.CONNIC()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            If Val(TextBox1.Text) = Val("") Then
                MsgBox("يرجى ادخال القيمة المدفوعة")
                TextBox1.Focus()
            Else
                Button6.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox11.Text = Val(Label13.Text) - Val(TextBox1.Text)
        If TextBox1.Text = Trim("") Then
            Button6.Enabled = False
            Button4.Enabled = False
        Else
            Button6.Enabled = True
            'Button4.Enabled = True
        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox10.Text = "" Then
                MsgBox("يرجى ادخال رقم الإيصال")
                TextBox10.Focus()
            Else
                Call Class1.CONNIC()
                Dim s112 As String = "select * from KASHEF where Esalno=@Esalno"
                Dim cm112 As New SqlClient.SqlCommand(s112, cn)
                cm112.Parameters.AddWithValue("@Esalno", CInt(Me.TextBox10.Text))
                Dim rd112 As SqlClient.SqlDataReader = cm112.ExecuteReader
                If rd112.Read = True Then
                    doctornamex = rd112!doctorname
                    TextBox2.Text = rd112!doctorname
                    madfoox = CDec(rd112!MADFOO)
                    TextBox1.Text = CDbl(rd112!MADFOO)
                    bakyx = CDec(rd112!BAKY)
                    TextBox11.Text = CDbl(rd112!BAKY)
                    kemax = rd112!kema
                    kematx = CDec(rd112!kemat)
                    Label13.Text = CDbl(rd112!kemat)
                    Label13.Text = Label13.Text & " " & "دينار"
                    DATEXX = rd112!datex
                    rd112.Close()
                    Dim s As String = "select * from APPOINTMENTVIEW where Esalno=@Esalno"
                    Dim cm As New SqlClient.SqlCommand(s, cn)
                    cm.Parameters.AddWithValue("@Esalno", CInt(Me.TextBox10.Text))
                    Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                    If rd.Read = True Then
                        doctornamex = rd!DN
                        TextBox2.Text = doctornamex
                        Ejraax = rd!Ejraa
                        chnox = rd!chno
                        fnumberx = rd!fnumber
                        chnox = rd!chno
                        M7 = rd!CHNO
                        esalnox = rd!Esalno
                        namemx = rd!NAMEM
                        jehamx = rd!JEHAM
                        namexx = rd!namex
                        dateax = rd!datea
                        rd.Close()
                        Call Class1.CONNIC()
                        rd.Close()
                        Dim sk2 As String = "select * from DN where DN=@DN"
                        Dim cmk2 As New SqlClient.SqlCommand(sk2, cn)
                        cmk2.Parameters.AddWithValue("@DN", doctornamex)
                        Dim rdK2 As SqlClient.SqlDataReader = cmk2.ExecuteReader
                        If rdK2.Read = True Then
                            TextBox38.Text = rdK2!IDD
                        End If
                        '    madfoox = CDec(rdK2!MADFOO)
                        '    TextBox1.Text = CDbl(rdK2!MADFOO)
                        '    bakyx = CDec(rdK2!BAKY)
                        '    TextBox11.Text = CDbl(rdK2!BAKY)
                        '    rdK2.Close()
                        'End If
                    End If


                    Dim s11 As String = "select * from KASHEF where conf=@conf and Esalno=@Esalno"
                    Dim cm11 As New SqlClient.SqlCommand(s11, cn)
                    cm11.Parameters.AddWithValue("@conf", True)
                    cm11.Parameters.AddWithValue("@Esalno", Me.TextBox10.Text)
                    Dim rd11 As SqlClient.SqlDataReader = cm11.ExecuteReader
                    If rd11.Read = True Then
                        fnumberx = rd11!FNUMBER
                        kemax = CDec(rd11!kema)
                        Label13.Text = CDbl(rd11!kemat)
                        Label13.Text = Label13.Text & " " & "دينار"
                        'Button4.Visible = True
                        Button5.Visible = True
                        Button6.Visible = False
                        rd11.Close()
                        Dim sk As String = "select * from KASHEFMAIN where fnumber=@fnumber"
                        Dim cmk As New SqlClient.SqlCommand(sk, cn)
                        cmk.Parameters.AddWithValue("@fnumber", fnumberx)
                        Dim rdK As SqlClient.SqlDataReader = cmk.ExecuteReader
                        If rdK.Read = True Then
                            madfoox = CDec(rdK!MADFOO)
                            TextBox1.Text = CDbl(rdK!MADFOO)
                            bakyx = CDec(rdK!BAKY)
                            TextBox11.Text = CDbl(rdK!BAKY)
                            rdK.Close()
                        End If
                    Else
                        Button4.Visible = False
                        Button5.Visible = False
                        Button6.Visible = True
                    End If
                    rd11.Close()
                    Dim skk As String = "select * from doctork where dn=@dn"
                    Dim cmkk As New SqlClient.SqlCommand(skk, cn)
                    cmkk.Parameters.AddWithValue("@dn", doctornamex)
                    Dim rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
                    If rdkk.Read = True Then
                        kesemx = rdkk!kesem
                        TextBox3.Text = kesemx
                    End If
                    rdkk.Close()
                    Dim s1 As String = "select * from APPOINTMENTVIEW "
                    Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                    Dim dss As New DataSet
                    dss.Clear()
                    aad.Fill(dss, "APPOINTMENTVIEW")
                    Dim vd As New DataView(dss.Tables("APPOINTMENTVIEW"))
                    If TextBox10.Text = "" Then
                        vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'"
                    Else
                        vd.RowFilter = "DATEA>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEA<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND Esalno=" & "" & Me.TextBox10.Text & "" & ""
                    End If
                    Me.DataGridView1.DataMember = ""
                    DataGridView1.DataSource = vd
                    TextBox1.Focus()
                    If DATEXX <> Date.Today.Date Then
                        Label54.Text = "هذا الحجز بتاريخ" & "  " & Format(DATEXX, "yyyy/MM/dd")
                    Else
                        Label54.Text = ""
                    End If
                Else
                    MsgBox("رقم الايصال غير موجود")
                    TextBox10.Text = ""
                    TextBox10.Focus()
                End If

                'If Asc(e.KeyChar) = Keys.Enter Then
                '    If TextBox10.Text = "" Then
                '        MsgBox("يرجى ادخال رقم الإيصال")
                '        TextBox10.Focus()
                '    Else
                '        Button7.Focus()
                Call Class4.CONNIC()
            End If
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        If TextBox10.Text = Trim("") Then
            Button7.Enabled = False
        Else
            Button7.Enabled = True
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sG As String = "select * from DN where DN=@DN "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@DN", ComboBox2.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        If rdG.Read = True Then
            L = rdG!IDD
        End If

        'If ComboBox2.SelectedIndex = 0 Then
        'Else
        Dim Str As String = "SELECT MIN(TAS_DATE) FROM HESAB_DO "
        Dim cmd As New SqlClient.SqlCommand(Str, cn)
        Try
            DateTimePicker1.Text = cmd.ExecuteScalar
        Catch ex As Exception

        End Try
        Dim s1 As String = "select * from kashef "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "kashef")
        Dim vd As New DataView(dss.Tables("kashef"))
        vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND doctorname=" & "'" & L & "'" & "AND CONF=" & "" & True & "" & ""
        Me.DataGridView2.DataMember = ""
        DataGridView2.DataSource = vd
        If DataGridView2.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView2.Rows.Count - 1
                tot += DataGridView2.Item(2, i).Value
            Next
            Label7.Text = tot
        Else
            Label7.Text = 0
        End If
        Dim s11 As String = "select * from AMALEAT_M "
        Dim aad1 As New SqlClient.SqlDataAdapter(s11, cn)
        Dim dss1 As New DataSet
        dss1.Clear()
        aad1.Fill(dss1, "AMALEAT_M")
        Dim vd1 As New DataView(dss1.Tables("AMALEAT_M"))
        If L = 0 Then
            vd1.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND TAHN=" & "'" & "قيمة التحاليل" & "'" & "AND CONF=" & "" & True & "" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd1
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(12, i).Value
                Next
                Label22.Text = tot
            Else
                Label22.Text = 0
            End If
        Else
            vd1.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND CDOCN=" & "'" & L & "'" & "AND CONF=" & "" & True & "" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd1
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(16, i).Value
                Next
                Label22.Text = tot
            Else
                Label22.Text = 0
            End If
        End If

        'If DataGridView2.Rows.Count <> 0 Then
        '    Dim xc As Integer = 0
        '    Dim tot As Integer = 0
        '    Dim i As Integer = 0
        '    For i = 0 To DataGridView2.Rows.Count - 1
        '        tot += DataGridView2.Item(2, i).Value
        '    Next
        '    Label6.Text = tot
        'End If
        If DataGridView2.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView2.Rows.Count - 1
                tot += 1
            Next
            Label5.Text = tot
        Else
            Label5.Text = 0
        End If
        Dim s16S As String = "select * from HESAB_DO "
        Dim aadS As New SqlClient.SqlDataAdapter(s16S, cn)
        Dim dssS As New DataSet
        dssS.Clear()
        aadS.Fill(dssS, "HESAB_DO")
        Dim vdS As New DataView(dssS.Tables("HESAB_DO"))
        vdS.RowFilter = "TAS_DATE>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND TAS_DATE<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND doctorname=" & "'" & Me.ComboBox2.Text & "'" & ""
        Me.DataGridView3.DataMember = ""
        DataGridView3.DataSource = vdS
        If DataGridView3.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView3.Rows.Count - 1
                tot += DataGridView3.Item(1, i).Value
            Next
            Label9.Text = tot
        Else
            Label9.Text = 0
        End If
        If Label9.Text = "" Then
            Label9.Text = 0
        End If
        Label6.Text = Val(Label22.Text) + Val(Label7.Text) - Val(Label9.Text)
        Dim s15 As String = "select * from kashef "
        Dim aad5 As New SqlClient.SqlDataAdapter(s15, cn)
        Dim dss5 As New DataSet
        dss5.Clear()
        aad5.Fill(dss5, "kashef")
        Dim vd5 As New DataView(dss5.Tables("kashef"))
        vd5.RowFilter = "Ejraa=" & "'" & Label12.Text & "'" & "AND KEMA=" & "" & Label16.Text & "" & "AND Doctorname=" & "'" & ComboBox2.Text & "'" & "AND CONF=" & "" & True & "" & ""
        Me.DataGridView2.DataMember = ""
        DataGridView2.DataSource = vd5
        If DataGridView2.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim tot0 As Integer = 0
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To DataGridView2.Rows.Count - 1
                tot += DataGridView2.Item(3, i).Value
            Next
            For j = 0 To DataGridView2.Rows.Count - 1
                tot0 += DataGridView2.Item(4, j).Value
            Next
            TextBox25.Text = tot
            TextBox26.Text = tot0
            If bk = "اسنان" Then
                GroupBox24.Visible = True
                GroupBox25.Visible = True
                GroupBox26.Visible = True
                Button11.Visible = True
            Else
                GroupBox24.Visible = False
                GroupBox25.Visible = False
                GroupBox26.Visible = False
                Button11.Visible = False
            End If
        Else
            TextBox25.Text = 0
            TextBox26.Text = 0
            GroupBox24.Visible = False
            GroupBox25.Visible = False
            GroupBox26.Visible = False
            Button11.Visible = False

        End If
        TextBox5.Text = ""
        TextBox5.Focus()
        Call Class4.CONNIC()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Class1.CONNIC()
        Dim ss As String = "insert into HESAB_DO(DOCTORNAME,TAS_KEMA,TAS_DATE,user_name,IDD)values(@DOCTORNAME,@TAS_KEMA,@TAS_DATE,@user_name,@IDD)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("@DOCTORNAME", Trim(ComboBox2.Text))
        cmm.Parameters.AddWithValue("@TAS_KEMA", CDbl(TextBox5.Text))
        cmm.Parameters.AddWithValue("@TAS_DATE", Date.Today.Date)
        cmm.Parameters.AddWithValue("@user_name", Trim(user))
        cmm.Parameters.AddWithValue("@IDD", CInt(L))
        'Try
        cmm.ExecuteNonQuery()
        MsgBox("تم تسليم القيمة للطبيب")
        'Try
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
        Dim crReportDocument As New CrystalReport40(), cri As String
        crReportDocument.Load("CrystalReport40.rpt")
        cri = "{HESAB_DO.DOCTORNAME}=" & "'" & ComboBox2.Text & "'"
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
        Dim RM As Resources.ResourceManager
        RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
        NAMEC = RM.GetString("NAMECLINIC")
        NAMEC = My.Settings.CLIN
        crReportDocument.SetParameterValue(0, Me.NAMEC)
        crReportDocument.RecordSelectionFormula = cri
        crReportDocument.PrintOptions.PrinterName = My.Settings.printerx2
        crReportDocument.PrintToPrinter(1, True, 0, 0)
        crReportDocument.Close()
        crReportDocument.Dispose()

        '-----------------------------------------------------------------------------------
        reader.Close()




        'Dim cr1 As New CrystalReport40, cri As String
        'cri = "{HESAB_DO.DOCTORNAME}=" & "'" & ComboBox2.Text & "'"
        ''KESEM_P = TextBox3.Text
        ''cr1.SetParameterValue(0, Me.KESEM_P)
        'cr1.RecordSelectionFormula = cri
        'cr1.PrintOptions.PrinterName = "PR"
        ''cr1.PrintOptions.PrinterName = "LK-TE212"
        'cr1.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
        'cr1.PrintToPrinter(1, True, 1, 1)

        'Catch ex As Exception
        '    MsgBox("No printe")
        'End Try
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        '    'MsgBox("خطأ في التسليم راجع مدخلاتك")
        'End Try
        Dim s16S As String = "select * from HESAB_DO "
        Dim aadS As New SqlClient.SqlDataAdapter(s16S, cn)
        Dim dssS As New DataSet
        dssS.Clear()
        aadS.Fill(dssS, "HESAB_DO")
        Dim vdS As New DataView(dssS.Tables("HESAB_DO"))
        vdS.RowFilter = "TAS_DATE>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND TAS_DATE<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND doctorname=" & "'" & Me.ComboBox2.Text & "'" & ""
        Me.DataGridView3.DataMember = ""
        DataGridView3.DataSource = vdS
        If DataGridView3.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView3.Rows.Count - 1
                tot += DataGridView3.Item(2, i).Value
            Next
            Label9.Text = tot
            Label6.Text = Val(Label7.Text) - Val(Label9.Text)
        End If
        TextBox5.Text = ""
        Call Class4.CONNIC()
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox5.Text = "" Then
                MsgBox("يرجى ادخال القيمة المسلمة للطبيب")
                TextBox5.Focus()
            Else
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = Trim("") Then
            Button1.Enabled = False
            Button3.Enabled = False
        Else
            Button1.Enabled = True
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call Class1.CONNIC()
        Dim ss As String = "insert into HESAB_DO(DOCTORNAME,TAS_KEMA,TAS_DATE,user_name,IDD)values(@DOCTORNAME,@TAS_KEMA,@TAS_DATE,@user_name,@IDD)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("@DOCTORNAME", ComboBox2.Text)
        cmm.Parameters.AddWithValue("@TAS_KEMA", CDbl(-TextBox5.Text))
        cmm.Parameters.AddWithValue("@TAS_DATE", Date.Today.Date)
        cmm.Parameters.AddWithValue("@user_name", CChar(user))
        cmm.Parameters.AddWithValue("@IDD", CInt(L))
        If MsgBox("هل تريد إرجاع القيمة", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم إرجاع القيمة")
            Catch ex As Exception
                MsgBox("خطأ في إرجاع القيمة راجع مدخلاتك")
            End Try
            Dim s16S As String = "select * from HESAB_DO "
            Dim aadS As New SqlClient.SqlDataAdapter(s16S, cn)
            Dim dssS As New DataSet
            dssS.Clear()
            aadS.Fill(dssS, "HESAB_DO")
            Dim vdS As New DataView(dssS.Tables("HESAB_DO"))
            vdS.RowFilter = "TAS_DATE>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND TAS_DATE<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND doctorname=" & "'" & Me.ComboBox2.Text & "'" & ""
            Me.DataGridView3.DataMember = ""
            DataGridView3.DataSource = vdS
            If DataGridView3.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView3.Rows.Count - 1
                    tot += DataGridView3.Item(2, i).Value
                Next
                Label9.Text = tot
                Label6.Text = Val(Label7.Text) - Val(Label9.Text)
            End If
        End If

        TextBox5.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim Str As String = "SELECT MAX(TAS_DATE) FROM HESAB_DO "
        'Dim cmd As New SqlClient.SqlCommand(Str, cn)
        'DateTimePicker1.Text = cmd.ExecuteScalar
        Call Class1.CONNIC()
        Dim s1 As String = "select * from kashef "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "kashef")
        Dim vd As New DataView(dss.Tables("kashef"))
        vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND doctorname=" & "" & L & "" & ""
        'vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & ""
        Me.DataGridView2.DataMember = ""
        DataGridView2.DataSource = vd
        If DataGridView2.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView2.Rows.Count - 1
                tot += DataGridView2.Item(2, i).Value
            Next
            Label7.Text = tot
            TextBox17.Text = tot
        Else
            TextBox17.Text = 0
        End If
        'If DataGridView2.Rows.Count <> 0 Then
        '    Dim xc As Integer = 0
        '    Dim tot As Integer = 0
        '    Dim i As Integer = 0
        '    For i = 0 To DataGridView2.Rows.Count - 1
        '        tot += DataGridView2.Item(2, i).Value
        '    Next
        '    Label6.Text = tot
        'End If
        If DataGridView2.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView2.Rows.Count - 1
                tot += 1
            Next
            Label5.Text = tot
        End If
        Dim s16S As String = "select * from HESAB_DO "
        Dim aadS As New SqlClient.SqlDataAdapter(s16S, cn)
        Dim dssS As New DataSet
        dssS.Clear()
        aadS.Fill(dssS, "HESAB_DO")
        Dim vdS As New DataView(dssS.Tables("HESAB_DO"))
        vdS.RowFilter = "TAS_DATE>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND TAS_DATE<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND doctorname=" & "'" & Me.ComboBox2.Text & "'" & ""
        Me.DataGridView3.DataMember = ""
        DataGridView3.DataSource = vdS
        If DataGridView3.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView3.Rows.Count - 1
                tot += DataGridView3.Item(2, i).Value
            Next
            Label9.Text = tot
            Label6.Text = Val(Label7.Text) - Val(Label9.Text)
        End If
        TextBox5.Text = ""
        TextBox5.Focus()
        Dim ss3 As String = "select * from SADAD "
        Dim aad3 As New SqlClient.SqlDataAdapter(ss3, cn)
        Dim dss3 As New DataSet
        dss3.Clear()
        aad3.Fill(dss3, "SADAD")
        Dim vdd3 As New DataView(dss3.Tables("SADAD"))
        vdd3.RowFilter = " DatexX >=" & "'" & DateTimePicker1.Value & "'" & "and DatexX <=" & "'" & DateTimePicker2.Value & "'" & ""
        DataGridView7.DataMember = ""
        DataGridView7.DataSource = vdd3
        If DataGridView7.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot0 As Integer = 0
            Dim tot1 As Integer = 0
            Dim tot2 As Integer = 0
            Dim tot3 As Integer = 0
            Dim j As Integer = 0
            For j = 0 To DataGridView7.Rows.Count - 1
                tot0 += DataGridView7.Item(2, j).Value
                'tot1 += DataGridView7.Item(2, j).Value
            Next
            TextBox16.Text = tot0
            'TextBox17.Text = tot1
        Else
            TextBox16.Text = 0
            'TextBox17.Text = 0
        End If
        TextBox18.Text = Val(TextBox16.Text) - Val(TextBox17.Text)
        Dim s16SL As String = "select * from LOSS "
        Dim aadSL As New SqlClient.SqlDataAdapter(s16SL, cn)
        Dim dssSL As New DataSet
        dssSL.Clear()
        aadSL.Fill(dssSL, "LOSS")
        Dim vdSL As New DataView(dssSL.Tables("LOSS"))
        vdSL.RowFilter = "LOSSDATE>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND LOSSDATE<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & ""
        Me.DataGridView4.DataMember = ""
        DataGridView4.DataSource = vdSL
        If DataGridView4.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot2 As Integer = 0
            Dim j As Integer = 0
            For j = 0 To DataGridView4.Rows.Count - 1
                tot2 += DataGridView4.Item(2, j).Value
            Next
            TextBox19.Text = tot2
        Else
            TextBox19.Text = 0
        End If
        TextBox20.Text = Val(TextBox18.Text) - Val(TextBox19.Text)
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox12.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox12.Text = "" Then
                MsgBox("يرجى اختيار اسم الجهة")
                ComboBox12.Focus()
            Else
                TextBox23.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox12.SelectedIndexChanged
        Call Class1.CONNIC()
        'Dim Str As String = "SELECT MIN(TAS_DATE) FROM HESAB_DO "
        'Dim cmd As New SqlClient.SqlCommand(Str, cn)
        'DateTimePicker1.Text = cmd.ExecuteScalar
        Dim s1 As String = "select * from mostafeed_view "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "mostafeed_view")
        Dim vd As New DataView(dss.Tables("mostafeed_view"))
        vd.RowFilter = "namem=" & "'" & Me.ComboBox12.Text & "'" & ""
        Me.DataGridView6.DataMember = ""
        DataGridView6.DataSource = vd
        If DataGridView6.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView6.Rows.Count - 1
                tot += DataGridView6.Item(4, i).Value
            Next
            TextBox24.Text = tot
        Else
            TextBox24.Text = 0
        End If
        Button13.Visible = False
        Button14.Visible = True
        Call Class4.CONNIC()

    End Sub

    Private Sub TextBox24_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox24.KeyPress

    End Sub

    Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs) Handles TextBox24.TextChanged

    End Sub

    Private Sub TextBox23_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox23.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox23.Text = "" Then
                MsgBox("يرجى ادخال القيمة المدفوعة")
                ComboBox12.Focus()
            Else
                DateTimePicker3.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged

    End Sub

    Private Sub DateTimePicker3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DateTimePicker3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Button10.Focus()
        End If
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Call Class1.CONNIC()
        Dim sB As String = "select * from mostafeed_view where jeham=@jeham "
        Dim cmB As New SqlClient.SqlCommand(sB, cn)
        cmB.Parameters.AddWithValue("@jeham", Trim(ComboBox12.Text))
        Dim rdB As SqlClient.SqlDataReader
        rdB = cmB.ExecuteReader
        Do While rdB.Read = True
            Esal_no.Text = CInt(rdB!esalno)
            Madfoo_v.Text = CDbl(rdB!madfoo) '0
            Baky_v.Text = CDbl(rdB!baky) '30

            If Val(Baky_v.Text) <> 0 Then
                Dim s222 As String = "insert into SADAD(ESALNO,DATEXX,SADAD) values(@ESALNO,@DATEXX,@SADAD)"
                Dim cm222 As New SqlClient.SqlCommand(s222, cn)
                cm222.Parameters.AddWithValue("@ESALNO", Esal_no.Text)
                cm222.Parameters.AddWithValue("@DATEXX", Date.Today.Date)
                cm222.Parameters.AddWithValue("@SADAD", CDbl(Me.TextBox23.Text))
                Try
                    cm222.ExecuteNonQuery()
                Catch ex As Exception

                End Try
                Dim ss21 As String = "update kashef set MADFOO=@madfoo,BAKY=@baky where esalno=@esalno"
                Dim cmm21 As New SqlClient.SqlCommand(ss21, cn)
                If Val(TextBox23.Text) <= Val(Baky_v.Text) Then
                    Madfoo_v.Text = CDbl(TextBox23.Text) + CDbl(Madfoo_v.Text)
                    cmm21.Parameters.AddWithValue("@MADFOO", CDbl(Madfoo_v.Text))
                    Baky_v.Text = Abs(CDbl(Baky_v.Text) - CDbl(TextBox23.Text))
                    If Val(Baky_v.Text) <> 0 Then
                        TextBox23.Text = 0
                    Else
                        TextBox23.Text = Abs(CDbl(TextBox23.Text) - CDbl(Madfoo_v.Text))
                    End If

                Else
                    Madfoo_v.Text = Abs(CDbl(Baky_v.Text) + CDbl(Madfoo_v.Text))
                    cmm21.Parameters.AddWithValue("@MADFOO", CDbl(Madfoo_v.Text))
                    TextBox23.Text = Abs(CDbl(TextBox23.Text) - CDbl(Baky_v.Text))
                    Baky_v.Text = 0
                End If
                cmm21.Parameters.AddWithValue("@BAKY", CDbl(Baky_v.Text))
                cmm21.Parameters.AddWithValue("@esalno", CInt(Esal_no.Text))
                Try
                    cmm21.ExecuteNonQuery()
                    'MsgBox("تم السداد")
                Catch ex As Exception

                End Try
                'End Using
                'If Val(TextBox23.Text) <= Val(Baky_v.Text) Then
                If Val(TextBox23.Text) = 0 Then
                    'TextBox23.Text = CDbl(Baky_v.Text) - CDbl(TextBox23.Text)
                    Exit Do
                    'Else
                    '    TextBox23.Text = Abs(CDbl(TextBox23.Text) - CDbl(Baky_v.Text))
                End If
            End If
            'End If
            'If Baky_v.Text = 0 Then
            '    Exit Do
            'End If
        Loop
        Dim s1 As String = "select * from mostafeed_view "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "mostafeed_view")
        Dim vd As New DataView(dss.Tables("mostafeed_view"))
        vd.RowFilter = "jeham=" & "'" & Me.ComboBox12.Text & "'" & ""
        Me.DataGridView6.DataMember = ""
        DataGridView6.DataSource = vd
        If DataGridView6.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView6.Rows.Count - 1
                tot += DataGridView6.Item(4, i).Value
            Next
            TextBox24.Text = tot
        Else
            TextBox24.Text = 0
        End If
        Button13.Visible = False
        Button14.Visible = True
        Call Class4.CONNIC()
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call Class1.CONNIC()
        Dim s222 As String = "insert into loss(lossna,lossva,lossdate,losstype,lossmo) values(@lossna,@lossva,@lossdate,@losstype,@lossmo)"
        Dim cm222 As New SqlClient.SqlCommand(s222, cn)
        cm222.Parameters.AddWithValue("@lossna", Me.ComboBox3.Text)
        cm222.Parameters.AddWithValue("@lossva", Me.TextBox15.Text)
        cm222.Parameters.AddWithValue("@lossdate", Me.DateTimePicker4.Text)
        cm222.Parameters.AddWithValue("@losstype", Me.ComboBox4.Text)
        cm222.Parameters.AddWithValue("@lossmo", Me.TextBox14.Text)
        Try
            cm222.ExecuteNonQuery()
            MsgBox("تم إضافة القيد")
            Dim sk As String
            sk = "select * from Bloss"
            Dim adk As New SqlClient.SqlDataAdapter(sk, cn)
            Dim dsk As New DataSet
            adk.Fill(dsk, "Bloss")
            ComboBox3.DataSource = dsk.Tables(0)
            ComboBox3.DisplayMember = "lossna"
            ComboBox3.SelectedIndex = -1
            Dim skK As String
            skK = "select * from BlossT"
            Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
            Dim dskK As New DataSet
            adkK.Fill(dskK, "BlossT")
            ComboBox4.DataSource = dskK.Tables(0)
            ComboBox4.DisplayMember = "lossTYPE"
            ComboBox4.SelectedIndex = -1
            Me.TextBox14.Text = ""
            Me.TextBox15.Text = ""
            Me.ComboBox4.Text = ""
            Me.ComboBox4.Focus()

            Dim ss As String = "select * from LOSS "
            Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
            Dim dss As New DataSet
            dss.Clear()
            aad.Fill(dss, "LOSS")
            Dim vdd As New DataView(dss.Tables("LOSS"))
            vdd.RowFilter = " LOSSDATE =" & "'" & Date.Now.Date & "'" & ""
            DataGridView4.DataMember = ""
            DataGridView4.DataSource = vdd

        Catch ex As Exception
            MsgBox("خطأ في الترصيد")
        End Try
        Call Class4.CONNIC()
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        Call Class1.CONNIC()
        Select Case e.ColumnIndex
            Case 0
                dgx = DataGridView1.CurrentCell.Value
                Me.Label1.Text = dgx
                Dim sd As String = "delete * from LOSS where id=xx1"
                Dim cd As New SqlClient.SqlCommand(sd, cn)
                cd.Parameters.AddWithValue("xx1", Me.Label1.Text)
                If MsgBox("هل تريد حذف الترصيد", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try
                        cd.ExecuteNonQuery()
                        MsgBox("تم الحذف")
                        Call Class1.CONNIC()
                        Dim ss As String = "select * from LOSS "
                        Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
                        Dim dss As New DataSet
                        dss.Clear()
                        aad.Fill(dss, "LOSS")
                        Dim vdd As New DataView(dss.Tables("LOSS"))
                        vdd.RowFilter = " LOSSDATE =" & "'" & Date.Now.Date & "'" & ""
                        DataGridView1.DataMember = ""
                        DataGridView1.DataSource = vdd
                    Catch ex As Exception
                        MsgBox("لم يتم الحذف")
                    End Try
                End If


        End Select
        Call Class4.CONNIC()

    End Sub

    Private Sub عرضالتقريرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عرضالتقريرToolStripMenuItem.Click
        If ComboBox4.Text = "" And ComboBox3.Text = "" Then
            TextBox13.Text = "تقرير عن المصروفات"
            L = 1
        ElseIf ComboBox4.Text = "" And ComboBox3.Text <> "" Then
            TextBox13.Text = "تقرير عن مصروفات" + " " + ComboBox3.Text
            L = 2
        ElseIf ComboBox4.Text <> "" And ComboBox3.Text = "" Then
            TextBox13.Text = "تقرير عن " + " " + ComboBox3.Text
            L = 3
        ElseIf ComboBox4.Text <> "" And ComboBox3.Text <> "" Then
            TextBox13.Text = "تقرير عن " + " " + ComboBox4.Text + " " + ComboBox3.Text
            L = 4
        End If
        vv1 = ComboBox4.Text
        vv2 = ComboBox3.Text
        MO = TextBox13.Text
        VV3 = DateTimePicker1.Text
        VV4 = DateTimePicker2.Text
        Dim f As New lossprint
        f.user = user
        f.nn = MO
        f.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs) Handles TextBox26.TextChanged
        If Val(TextBox26.Text) <> Val(TextBox25.Text) Then
            GroupBox25.Enabled = False
            Button11.Enabled = False
        Else
            If TextBox25.Text <> 0 Then
                GroupBox25.Enabled = True
                Button11.Enabled = True
            Else
                GroupBox25.Enabled = False
                Button11.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Label14.Text = (Val(TextBox25.Text) - Val(TextBox21.Text)) / 2
        TextBox25.Text = dgx
        Call Class1.CONNIC()
        Dim ss21 As String = "update kashef set MAMLK=@MAMLK,KEMA=@KEMA,KEMAT=@KEMAT where esalno=@esalno"
        Dim cmm21 As New SqlClient.SqlCommand(ss21, cn)
        cmm21.Parameters.AddWithValue("@MAMLK", CDbl(Val(TextBox21.Text)))
        cmm21.Parameters.AddWithValue("@KEMA", CDbl(Val(Label14.Text)))
        cmm21.Parameters.AddWithValue("@KEMAT", CDbl(Val(Label14.Text)))
        cmm21.Parameters.AddWithValue("@esalno", CInt(dgx))
        Try
            cmm21.ExecuteNonQuery()
            MsgBox("تم الدفع")
        Catch ex As Exception
            MsgBox("ERORR")
        End Try

        Call Class4.CONNIC()

    End Sub

    'Private Sub DATAGRIDVIEW2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    'End Sub

    Private Sub DATAGRIDVIEW2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        Select Case num
            Case 0
                dgx = DataGridView2.CurrentCell.Value
        End Select
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sB As String = "select * from MAIN where NAMEX=@NAMEX "
        Dim cmB As New SqlClient.SqlCommand(sB, cn)
        cmB.Parameters.AddWithValue("@NAMEX", Trim(ComboBox5.Text))
        Dim rdB As SqlClient.SqlDataReader
        rdB = cmB.ExecuteReader
        If rdB.Read = True Then
            Label15.Text = rdB!FNUMBER
        Else
            Label15.Text = 0
        End If
        rdB.Close()
        Dim skK As String
        skK = "select * from KASHEF WHERE FNUMBER='" & CInt(Label15.Text) & "' "
        Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
        Dim dskK As New DataSet
        adkK.Fill(dskK, "KASHEF")
        ComboBox6.DataSource = dskK.Tables(0)
        ComboBox6.DisplayMember = "ESALNO"
        'ComboBox6.SelectedIndex = -1

        Dim s1 As String = "select * from KASHEF"
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "KASHEF")
        Dim vd As New DataView(dss.Tables("KASHEF"))
        vd.RowFilter = "FNUMBER=" & "'" & Me.Label15.Text & "'" & "AND IDM=" & "'" & Me.Label16.Text & "'" & ""
        Me.DataGridView8.DataMember = ""
        DataGridView8.DataSource = vd
        If DataGridView8.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView8.Rows.Count - 1
                tot += DataGridView8.Item(6, i).Value
            Next
            TextBox27.Text = tot
        Else
            TextBox27.Text = 0
        End If
        Call Class4.CONNIC()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Call Class1.CONNIC()
        Dim sB As String = "select * from KASHEF where FNUMBER=@FNUMBER AND BAKY<>@BAKY"
        Dim cmB As New SqlClient.SqlCommand(sB, cn)
        cmB.Parameters.AddWithValue("@FNUMBER", CInt(Label15.Text))
        cmB.Parameters.AddWithValue("@BAKY", 0)
        Dim rdB As SqlClient.SqlDataReader
        rdB = cmB.ExecuteReader
        Do While rdB.Read = True
            If Val(TextBox28.Text) <> 0 Then
                Esal_no.Text = CInt(rdB!esalno)
                Madfoo_v.Text = CDbl(rdB!madfoo) '0
                Baky_v.Text = CDbl(rdB!baky) '30
                Dim s222 As String = "insert into SADAD(ESALNO,DATEXX,SADAD) values(@ESALNO,@DATEXX,@SADAD)"
                Dim cm222 As New SqlClient.SqlCommand(s222, cn)
                cm222.Parameters.AddWithValue("@ESALNO", Esal_no.Text)
                cm222.Parameters.AddWithValue("@DATEXX", Date.Today.Date)
                cm222.Parameters.AddWithValue("@SADAD", CDbl(Me.TextBox28.Text))
                Try
                    cm222.ExecuteNonQuery()
                Catch ex As Exception

                End Try

                If Val(Baky_v.Text) <> 0 Then
                    Dim ss21 As String = "update kashef set MADFOO=@madfoo,BAKY=@baky where esalno=@esalno"
                    Dim cmm21 As New SqlClient.SqlCommand(ss21, cn)
                    If Val(TextBox28.Text) <= Val(Baky_v.Text) Then
                        Madfoo_v.Text = CDbl(TextBox28.Text) + CDbl(Madfoo_v.Text)
                        cmm21.Parameters.AddWithValue("@MADFOO", CDbl(Madfoo_v.Text))
                        Baky_v.Text = Abs(Val(Baky_v.Text) - Val(TextBox28.Text))
                        If Val(Baky_v.Text) <> 0 Then
                            TextBox28.Text = 0
                        Else
                            TextBox28.Text = Abs(CDbl(TextBox28.Text) - CDbl(Madfoo_v.Text))
                        End If

                    Else
                        Madfoo_v.Text = Abs(CDbl(Baky_v.Text) + CDbl(Madfoo_v.Text))
                        cmm21.Parameters.AddWithValue("@MADFOO", CDbl(Madfoo_v.Text))
                        TextBox28.Text = Abs(CDbl(TextBox28.Text) - CDbl(Baky_v.Text))
                        Baky_v.Text = 0
                    End If
                    cmm21.Parameters.AddWithValue("@BAKY", CDbl(Baky_v.Text))
                    cmm21.Parameters.AddWithValue("@esalno", CInt(Esal_no.Text))
                    Try
                        cmm21.ExecuteNonQuery()
                        'MsgBox("تم السداد")
                    Catch ex As Exception

                    End Try
                    'End Using
                    'If Val(TextBox28.Text) <= Val(Baky_v.Text) Then
                    If Val(TextBox28.Text) = 0 Then
                        'TextBox28.Text = CDbl(Baky_v.Text) - CDbl(TextBox28.Text)
                        Exit Do
                        'Else
                        '    TextBox28.Text = Abs(CDbl(TextBox28.Text) - CDbl(Baky_v.Text))
                    End If
                End If
            End If
        Loop
        Dim s1 As String = "select * from KASHEFMAIN "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "KASHEFMAIN")
        Dim vd As New DataView(dss.Tables("KASHEFMAIN"))
        vd.RowFilter = "FNUMBER=" & "'" & Me.Label15.Text & "'" & "AND IDM=" & "'" & Me.Label16.Text & "'" & ""
        Me.DataGridView8.DataMember = ""
        DataGridView8.DataSource = vd
        If DataGridView8.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView8.Rows.Count - 1
                tot += DataGridView8.Item(2, i).Value
            Next
            TextBox27.Text = tot
        Else
            TextBox27.Text = 0
        End If
        Dim sk1X As String
        sk1X = "select * from MADENON"
        Dim adk1X As New SqlClient.SqlDataAdapter(sk1X, cn)
        Dim dsk1X As New DataSet
        adk1X.Fill(dsk1X, "MADENON")
        ComboBox5.DataSource = dsk1X.Tables(0)
        ComboBox5.DisplayMember = "NAMEX"
        ComboBox5.SelectedIndex = -1
        Call Class4.CONNIC()
    End Sub

    Private Sub TextBox28_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox28.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox28.Text = "" Then
                MsgBox("يرجى ادخال القيمة المدفوعة")
                ComboBox5.Focus()
            Else
                DateTimePicker5.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox28_TextChanged(sender As Object, e As EventArgs) Handles TextBox28.TextChanged

    End Sub

    Private Sub DateTimePicker5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DateTimePicker5.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Button12.Focus()
        End If
    End Sub

    Private Sub DateTimePicker5_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker5.ValueChanged

    End Sub

    Private Sub TextBox21_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox21.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Button11.Focus()
        End If
    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim F As New Form58
        vv1 = Trim(ComboBox12.Text)
        F.ShowDialog()
        Button13.Visible = False
        Button14.Visible = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Call Class1.CONNIC()
        Dim DEL As New SqlClient.SqlCommand("DELETE FROM JEHAKASHEFT ", cn)
        DEL.ExecuteNonQuery()
        Dim sB As String = "select * from KASHEF where EJRAA=@EJRAA "
        Dim cmB As New SqlClient.SqlCommand(sB, cn)
        cmB.Parameters.AddWithValue("@EJRAA", Trim("كشف"))
        Dim rdB As SqlClient.SqlDataReader
        rdB = cmB.ExecuteReader
        Do While rdB.Read = True
            BAKYJK = CDbl(rdB!BAKY)
            BAKYJS = CDbl(0)
            BAKYJT = CDbl(0)
            BAKYJAD = CDbl(0)
            BAKYJET = CDbl(0)
            BAKYJAS = CDbl(0)
            BAKYJSH = CDbl(0)
            BAKYJAM = CDbl(0)
            BAKYJTGH = CDbl(0)
            fnumberx = rdB!FNUMBER
            IDM = rdB!IDM
            Dim sBAK As String = "select * from MAIN where FNUMBER=@FNUMBER "
            Dim cmBAK As New SqlClient.SqlCommand(sBAK, cn)
            cmBAK.Parameters.AddWithValue("@FNUMBER", fnumberx)
            Dim rdBAK As SqlClient.SqlDataReader
            rdBAK = cmBAK.ExecuteReader
            If rdBAK.Read = True Then
                namexx = rdBAK!NAMEX
            End If
            rdBAK.Close()
            Dim sBB As String = "select * from MOSTAFEED where IDM=@IDM "
            Dim cmBB As New SqlClient.SqlCommand(sBB, cn)
            cmBB.Parameters.AddWithValue("@IDM", IDM)
            Dim rdBB As SqlClient.SqlDataReader
            rdBB = cmBB.ExecuteReader
            If rdBB.Read = True Then
                jehamx = rdBB!JEHAM
                namemx = rdBB!NAMEM
            End If
            rdBB.Close()
            Dim ss As String = "insert into JEHAKASHEFT(FNUMBER,NAMEX,NAMEM,JEHAM,KASH,SORA,TAH,ADWEA,ASNAN,ASH,AMAL,TAGH,IDM)values(@FNUMBER,@NAMEX,@NAMEM,@JEHAM,@KASH,@SORA,@TAH,@ADWEA,@ASNAN,@ASH,@AMAL,@TAGH,@IDM)"
            Dim cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@FNUMBER", fnumberx)
            cmm.Parameters.AddWithValue("@NAMEX", namexx)
            cmm.Parameters.AddWithValue("@NAMEM", namemx)
            cmm.Parameters.AddWithValue("@JEHAM", jehamx)
            cmm.Parameters.AddWithValue("@KASH", BAKYJK)
            cmm.Parameters.AddWithValue("@SORA", BAKYJS)
            cmm.Parameters.AddWithValue("@TAH", BAKYJT)
            cmm.Parameters.AddWithValue("@ADWEA", BAKYJAD)
            cmm.Parameters.AddWithValue("@ASNAN", BAKYJAS)
            cmm.Parameters.AddWithValue("@ASH", BAKYJSH)
            cmm.Parameters.AddWithValue("@AMAL", BAKYJAM)
            cmm.Parameters.AddWithValue("@TAGH", BAKYJTGH)
            cmm.Parameters.AddWithValue("@IDM", IDM)
            Try
                cmm.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("لم يتم الإعداد")
            End Try
        Loop
        rdB.Close()
        Dim sBS As String = "select * from KASHEF where EJRAA=@EJRAA "
        Dim cmBS As New SqlClient.SqlCommand(sBS, cn)
        cmBS.Parameters.AddWithValue("@EJRAA", Trim("صوره"))
        Dim rdBS As SqlClient.SqlDataReader
        rdBS = cmBS.ExecuteReader
        Do While rdBS.Read = True
            BAKYJK = CDbl(0)
            BAKYJS = CDbl(rdBS!BAKY)
            BAKYJT = CDbl(0)
            BAKYJAD = CDbl(0)
            BAKYJET = CDbl(0)
            BAKYJAS = CDbl(0)
            BAKYJSH = CDbl(0)
            BAKYJAM = CDbl(0)
            BAKYJTGH = CDbl(0)
            fnumberx = rdB!FNUMBER
            IDM = rdB!IDM
            Dim sBAS4 As String = "select * from MAIN where FNUMBER=@FNUMBER "
            Dim cmBAS4 As New SqlClient.SqlCommand(sBAS4, cn)
            cmBAS4.Parameters.AddWithValue("@FNUMBER", fnumberx)
            Dim rdBAS4 As SqlClient.SqlDataReader
            rdBAS4 = cmBAS4.ExecuteReader
            If rdBAS4.Read = True Then
                namexx = rdBAS4!NAMEX
            End If
            rdBAS4.Close()
            Dim sBB As String = "select * from MOSTAFEED where IDM=@IDM "
            Dim cmBB As New SqlClient.SqlCommand(sBB, cn)
            cmBB.Parameters.AddWithValue("@IDM", IDM)
            Dim rdBB As SqlClient.SqlDataReader
            rdBB = cmBB.ExecuteReader
            If rdBB.Read = True Then
                jehamx = rdBB!JEHAM
                namemx = rdBB!NAMEM
            End If
            rdBB.Close()
            Dim ss As String = "insert into JEHAKASHEFT(FNUMBER,NAMEX,NAMEM,JEHAM,KASH,SORA,TAH,ADWEA,ASNAN,ASH,AMAL,TAGH,IDM)values(@FNUMBER,@NAMEX,@NAMEM,@JEHAM,@KASH,@SORA,@TAH,@ADWEA,@ASNAN,@ASH,@AMAL,@TAGH,@IDM)"
            Dim cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@FNUMBER", fnumberx)
            cmm.Parameters.AddWithValue("@NAMEX", namexx)
            cmm.Parameters.AddWithValue("@NAMEM", namemx)
            cmm.Parameters.AddWithValue("@JEHAM", jehamx)
            cmm.Parameters.AddWithValue("@KASH", BAKYJK)
            cmm.Parameters.AddWithValue("@SORA", BAKYJS)
            cmm.Parameters.AddWithValue("@TAH", BAKYJT)
            cmm.Parameters.AddWithValue("@ADWEA", BAKYJAD)
            cmm.Parameters.AddWithValue("@ASNAN", BAKYJAS)
            cmm.Parameters.AddWithValue("@ASH", BAKYJSH)
            cmm.Parameters.AddWithValue("@AMAL", BAKYJAM)
            cmm.Parameters.AddWithValue("@TAGH", BAKYJTGH)
            cmm.Parameters.AddWithValue("@IDM", IDM)
            Try
                cmm.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("لم يتم الإعداد")
            End Try
        Loop
        rdBS.Close()
        Dim sBT As String = "select * from KASHEF where EJRAA=@EJRAA "
        Dim cmBT As New SqlClient.SqlCommand(sBT, cn)
        cmBT.Parameters.AddWithValue("@EJRAA", Trim("تحاليل"))
        Dim rdBT As SqlClient.SqlDataReader
        rdBT = cmBT.ExecuteReader
        Do While rdBT.Read = True
            BAKYJK = CDbl(0)
            BAKYJS = CDbl(0)
            BAKYJT = CDbl(rdBT!BAKY)
            BAKYJAD = CDbl(0)
            BAKYJET = CDbl(0)
            BAKYJAS = CDbl(0)
            BAKYJSH = CDbl(0)
            BAKYJAM = CDbl(0)
            BAKYJTGH = CDbl(0)
            fnumberx = rdBT!FNUMBER
            IDM = rdBT!IDM
            Dim sBAT As String = "select * from MAIN where FNUMBER=@FNUMBER "
            Dim cmBAT As New SqlClient.SqlCommand(sBAT, cn)
            cmBAT.Parameters.AddWithValue("@FNUMBER", fnumberx)
            Dim rdBAT As SqlClient.SqlDataReader
            rdBAT = cmBAT.ExecuteReader
            If rdBAT.Read = True Then
                namexx = rdBAT!NAMEX
            End If
            rdBAT.Close()
            Dim sBB As String = "select * from MOSTAFEED where IDM=@IDM "
            Dim cmBB As New SqlClient.SqlCommand(sBB, cn)
            cmBB.Parameters.AddWithValue("@IDM", IDM)
            Dim rdBB As SqlClient.SqlDataReader
            rdBB = cmBB.ExecuteReader
            If rdBB.Read = True Then
                jehamx = rdBB!JEHAM
                namemx = rdBB!NAMEM
            End If
            rdBB.Close()
            Dim ss As String = "insert into JEHAKASHEFT(FNUMBER,NAMEX,NAMEM,JEHAM,KASH,SORA,TAH,ADWEA,ASNAN,ASH,AMAL,TAGH,IDM)values(@FNUMBER,@NAMEX,@NAMEM,@JEHAM,@KASH,@SORA,@TAH,@ADWEA,@ASNAN,@ASH,@AMAL,@TAGH,@IDM)"
            Dim cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@FNUMBER", fnumberx)
            cmm.Parameters.AddWithValue("@NAMEX", namexx)
            cmm.Parameters.AddWithValue("@NAMEM", namemx)
            cmm.Parameters.AddWithValue("@JEHAM", jehamx)
            cmm.Parameters.AddWithValue("@KASH", BAKYJK)
            cmm.Parameters.AddWithValue("@SORA", BAKYJS)
            cmm.Parameters.AddWithValue("@TAH", BAKYJT)
            cmm.Parameters.AddWithValue("@ADWEA", BAKYJAD)
            cmm.Parameters.AddWithValue("@ASNAN", BAKYJAS)
            cmm.Parameters.AddWithValue("@ASH", BAKYJSH)
            cmm.Parameters.AddWithValue("@AMAL", BAKYJAM)
            cmm.Parameters.AddWithValue("@TAGH", BAKYJTGH)
            cmm.Parameters.AddWithValue("@IDM", IDM)
            Try
                cmm.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("لم يتم الإعداد")
            End Try
        Loop
        rdBT.Close()
        Dim sBA As String = "select * from KASHEF where EJRAA=@EJRAA "
        Dim cmBA As New SqlClient.SqlCommand(sBA, cn)
        cmBA.Parameters.AddWithValue("@EJRAA", Trim("ادويه"))
        Dim rdBAA As SqlClient.SqlDataReader
        rdBAA = cmBA.ExecuteReader
        Do While rdBAA.Read = True
            BAKYJK = CDbl(0)
            BAKYJS = CDbl(0)
            BAKYJT = CDbl(0)
            BAKYJAD = CDbl(rdBAA!BAKY)
            BAKYJET = CDbl(0)
            BAKYJAS = CDbl(0)
            BAKYJSH = CDbl(0)
            BAKYJAM = CDbl(0)
            BAKYJTGH = CDbl(0)
            fnumberx = rdBAA!FNUMBER
            IDM = rdBAA!IDM
            Dim sBAO As String = "select * from MAIN where FNUMBER=@FNUMBER "
            Dim cmBAO As New SqlClient.SqlCommand(sBAO, cn)
            cmBAO.Parameters.AddWithValue("@FNUMBER", fnumberx)
            Dim rdBAO As SqlClient.SqlDataReader
            rdBAO = cmBAO.ExecuteReader
            If rdBAO.Read = True Then
                namexx = rdBAO!NAMEX
            End If
            rdBAO.Close()
            Dim sBB As String = "select * from MOSTAFEED where IDM=@IDM "
            Dim cmBB As New SqlClient.SqlCommand(sBB, cn)
            cmBB.Parameters.AddWithValue("@IDM", IDM)
            Dim rdBB As SqlClient.SqlDataReader
            rdBB = cmBB.ExecuteReader
            If rdBB.Read = True Then
                jehamx = rdBB!JEHAM
                namemx = rdBB!NAMEM
            End If
            rdBB.Close()
            Dim ss As String = "insert into JEHAKASHEFT(FNUMBER,NAMEX,NAMEM,JEHAM,KASH,SORA,TAH,ADWEA,ASNAN,ASH,AMAL,TAGH,IDM)values(@FNUMBER,@NAMEX,@NAMEM,@JEHAM,@KASH,@SORA,@TAH,@ADWEA,@ASNAN,@ASH,@AMAL,@TAGH,@IDM)"
            Dim cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@FNUMBER", fnumberx)
            cmm.Parameters.AddWithValue("@NAMEX", namexx)
            cmm.Parameters.AddWithValue("@NAMEM", namemx)
            cmm.Parameters.AddWithValue("@JEHAM", jehamx)
            cmm.Parameters.AddWithValue("@KASH", BAKYJK)
            cmm.Parameters.AddWithValue("@SORA", BAKYJS)
            cmm.Parameters.AddWithValue("@TAH", BAKYJT)
            cmm.Parameters.AddWithValue("@ADWEA", BAKYJAD)
            cmm.Parameters.AddWithValue("@ASNAN", BAKYJAS)
            cmm.Parameters.AddWithValue("@ASH", BAKYJSH)
            cmm.Parameters.AddWithValue("@AMAL", BAKYJAM)
            cmm.Parameters.AddWithValue("@TAGH", BAKYJTGH)
            cmm.Parameters.AddWithValue("@IDM", IDM)
            Try
                cmm.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("لم يتم الإعداد")
            End Try
        Loop
        rdBAA.Close()
        Dim sBAS As String = "select * from KASHEF where EJRAA=@EJRAA "
        Dim cmBAS As New SqlClient.SqlCommand(sBAS, cn)
        cmBAS.Parameters.AddWithValue("@EJRAA", Trim("اسنان"))
        Dim rdBAS As SqlClient.SqlDataReader
        rdBAS = cmBS.ExecuteReader
        Do While rdBAS.Read = True
            BAKYJK = CDbl(0)
            BAKYJS = CDbl(0)
            BAKYJT = CDbl(0)
            BAKYJAD = CDbl(0)
            BAKYJET = CDbl(0)
            BAKYJAS = CDbl(rdBAS!BAKY)
            BAKYJSH = CDbl(0)
            BAKYJAM = CDbl(0)
            BAKYJTGH = CDbl(0)
            fnumberx = rdBAS!FNUMBER
            IDM = rdBAS!IDM
            Dim sBAO As String = "select * from MAIN where FNUMBER=@FNUMBER "
            Dim cmBAO As New SqlClient.SqlCommand(sBAO, cn)
            cmBAO.Parameters.AddWithValue("@FNUMBER", fnumberx)
            Dim rdBAO As SqlClient.SqlDataReader
            rdBAO = cmBAO.ExecuteReader
            If rdBAO.Read = True Then
                namexx = rdBAO!NAMEX
            End If
            rdBAO.Close()
            Dim sBB As String = "select * from MOSTAFEED where IDM=@IDM "
            Dim cmBB As New SqlClient.SqlCommand(sBB, cn)
            cmBB.Parameters.AddWithValue("@IDM", IDM)
            Dim rdBB As SqlClient.SqlDataReader
            rdBB = cmBB.ExecuteReader
            If rdBB.Read = True Then
                jehamx = rdBB!JEHAM
                namemx = rdBB!NAMEM
            End If
            rdBB.Close()
            Dim ss As String = "insert into JEHAKASHEFT(FNUMBER,NAMEX,NAMEM,JEHAM,KASH,SORA,TAH,ADWEA,ASNAN,ASH,AMAL,TAGH,IDM)values(@FNUMBER,@NAMEX,@NAMEM,@JEHAM,@KASH,@SORA,@TAH,@ADWEA,@ASNAN,@ASH,@AMAL,@TAGH,@IDM)"
            Dim cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@FNUMBER", fnumberx)
            cmm.Parameters.AddWithValue("@NAMEX", namexx)
            cmm.Parameters.AddWithValue("@NAMEM", namemx)
            cmm.Parameters.AddWithValue("@JEHAM", jehamx)
            cmm.Parameters.AddWithValue("@KASH", BAKYJK)
            cmm.Parameters.AddWithValue("@SORA", BAKYJS)
            cmm.Parameters.AddWithValue("@TAH", BAKYJT)
            cmm.Parameters.AddWithValue("@ADWEA", BAKYJAD)
            cmm.Parameters.AddWithValue("@ASNAN", BAKYJAS)
            cmm.Parameters.AddWithValue("@ASH", BAKYJSH)
            cmm.Parameters.AddWithValue("@AMAL", BAKYJAM)
            cmm.Parameters.AddWithValue("@TAGH", BAKYJTGH)
            cmm.Parameters.AddWithValue("@IDM", IDM)
            Try
                cmm.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("لم يتم الإعداد")
            End Try
        Loop
        rdBAS.Close()
        Dim sBAGH As String = "select * from KASHEF where EJRAA=@EJRAA "
        Dim cmBAGH As New SqlClient.SqlCommand(sBAGH, cn)
        cmBAGH.Parameters.AddWithValue("@EJRAA", Trim("تغذيه"))
        Dim rdBAGH As SqlClient.SqlDataReader
        rdBAGH = cmBAGH.ExecuteReader
        Do While rdBAGH.Read = True
            BAKYJK = CDbl(0)
            BAKYJS = CDbl(0)
            BAKYJT = CDbl(0)
            BAKYJAD = CDbl(0)
            BAKYJET = CDbl(0)
            BAKYJAS = CDbl(0)
            BAKYJSH = CDbl(0)
            BAKYJAM = CDbl(0)
            BAKYJTGH = CDbl(rdBAGH!BAKY)
            fnumberx = rdBAGH!FNUMBER
            IDM = rdBAGH!IDM
            Dim sBAO As String = "select * from MAIN where FNUMBER=@FNUMBER "
            Dim cmBAO As New SqlClient.SqlCommand(sBAO, cn)
            cmBAO.Parameters.AddWithValue("@FNUMBER", fnumberx)
            Dim rdBAO As SqlClient.SqlDataReader
            rdBAO = cmBAO.ExecuteReader
            If rdBAO.Read = True Then
                namexx = rdBAO!NAMEX
            End If
            rdBAO.Close()
            Dim sBB As String = "select * from MOSTAFEED where IDM=@IDM "
            Dim cmBB As New SqlClient.SqlCommand(sBB, cn)
            cmBB.Parameters.AddWithValue("@IDM", IDM)
            Dim rdBB As SqlClient.SqlDataReader
            rdBB = cmBB.ExecuteReader
            If rdBB.Read = True Then
                jehamx = rdBB!JEHAM
                namemx = rdBB!NAMEM
            End If
            rdBB.Close()
            Dim ss As String = "insert into JEHAKASHEFT(FNUMBER,NAMEX,NAMEM,JEHAM,KASH,SORA,TAH,ADWEA,ASNAN,ASH,AMAL,TAGH,IDM)values(@FNUMBER,@NAMEX,@NAMEM,@JEHAM,@KASH,@SORA,@TAH,@ADWEA,@ASNAN,@ASH,@AMAL,@TAGH,@IDM)"
            Dim cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@FNUMBER", fnumberx)
            cmm.Parameters.AddWithValue("@NAMEX", namexx)
            cmm.Parameters.AddWithValue("@NAMEM", namemx)
            cmm.Parameters.AddWithValue("@JEHAM", jehamx)
            cmm.Parameters.AddWithValue("@KASH", BAKYJK)
            cmm.Parameters.AddWithValue("@SORA", BAKYJS)
            cmm.Parameters.AddWithValue("@TAH", BAKYJT)
            cmm.Parameters.AddWithValue("@ADWEA", BAKYJAD)
            cmm.Parameters.AddWithValue("@ASNAN", BAKYJAS)
            cmm.Parameters.AddWithValue("@ASH", BAKYJSH)
            cmm.Parameters.AddWithValue("@AMAL", BAKYJAM)
            cmm.Parameters.AddWithValue("@TAGH", BAKYJTGH)
            cmm.Parameters.AddWithValue("@IDM", IDM)
            Try
                cmm.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("لم يتم الإعداد")
            End Try
        Loop
        rdBAGH.Close()
        Dim sBAM As String = "select * from KASHEF where EJRAA=@EJRAA "
        Dim cmBAM As New SqlClient.SqlCommand(sBAM, cn)
        cmBAM.Parameters.AddWithValue("@EJRAA", Trim("عمليات"))
        Dim rdBAM As SqlClient.SqlDataReader
        rdBAM = cmBAM.ExecuteReader
        Do While rdBAM.Read = True
            BAKYJK = CDbl(0)
            BAKYJS = CDbl(0)
            BAKYJT = CDbl(0)
            BAKYJAD = CDbl(0)
            BAKYJET = CDbl(0)
            BAKYJAS = CDbl(0)
            BAKYJSH = CDbl(0)
            BAKYJAM = CDbl(rdBAM!BAKY)
            BAKYJTGH = CDbl(0)
            fnumberx = rdBAM!FNUMBER
            IDM = rdBAM!IDM
            Dim sBAO As String = "select * from MAIN where FNUMBER=@FNUMBER "
            Dim cmBAO As New SqlClient.SqlCommand(sBAO, cn)
            cmBAO.Parameters.AddWithValue("@FNUMBER", fnumberx)
            Dim rdBAO As SqlClient.SqlDataReader
            rdBAO = cmBAO.ExecuteReader
            If rdBAO.Read = True Then
                namexx = rdBAO!NAMEX
            End If
            rdBAO.Close()
            Dim sBB As String = "select * from MOSTAFEED where IDM=@IDM "
            Dim cmBB As New SqlClient.SqlCommand(sBB, cn)
            cmBB.Parameters.AddWithValue("@IDM", IDM)
            Dim rdBB As SqlClient.SqlDataReader
            rdBB = cmBB.ExecuteReader
            If rdBB.Read = True Then
                jehamx = rdBB!JEHAM
                namemx = rdBB!NAMEM
            End If
            rdBB.Close()
            Dim ss As String = "insert into JEHAKASHEFT(FNUMBER,NAMEX,NAMEM,JEHAM,KASH,SORA,TAH,ADWEA,ASNAN,ASH,AMAL,TAGH,IDM)values(@FNUMBER,@NAMEX,@NAMEM,@JEHAM,@KASH,@SORA,@TAH,@ADWEA,@ASNAN,@ASH,@AMAL,@TAGH,@IDM)"
            Dim cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@FNUMBER", fnumberx)
            cmm.Parameters.AddWithValue("@NAMEX", namexx)
            cmm.Parameters.AddWithValue("@NAMEM", namemx)
            cmm.Parameters.AddWithValue("@JEHAM", jehamx)
            cmm.Parameters.AddWithValue("@KASH", BAKYJK)
            cmm.Parameters.AddWithValue("@SORA", BAKYJS)
            cmm.Parameters.AddWithValue("@TAH", BAKYJT)
            cmm.Parameters.AddWithValue("@ADWEA", BAKYJAD)
            cmm.Parameters.AddWithValue("@ASNAN", BAKYJAS)
            cmm.Parameters.AddWithValue("@ASH", BAKYJSH)
            cmm.Parameters.AddWithValue("@AMAL", BAKYJAM)
            cmm.Parameters.AddWithValue("@TAGH", BAKYJTGH)
            cmm.Parameters.AddWithValue("@IDM", IDM)
            Try
                cmm.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("لم يتم الإعداد")
            End Try
        Loop
        rdBAM.Close()
        Button13.Visible = True
        Button14.Visible = False
        Call Class4.CONNIC()

    End Sub

    Private Sub حسبطبيبToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حسبطبيبToolStripMenuItem.Click
        DOCT = 1
        I = L
        vv1 = Trim(ComboBox2.Text)
        DD1 = DateTimePicker1.Value.Date
        DD2 = DateTimePicker2.Value.Date
        Dim F As New Form59
        F.DD1 = DD1
        F.DD2 = DD2
        F.I = I
        F.ShowDialog()
    End Sub

    Private Sub كلالأطباءToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles كلالأطباءToolStripMenuItem.Click
        DOCT = 2
        DD1 = DateTimePicker1.Value.Date
        DD2 = DateTimePicker2.Value.Date
        Dim F As New Form59
        F.DD1 = DD1
        F.DD2 = DD2
        F.I = I
        F.ShowDialog()
    End Sub

    Private Sub حسبطبيبToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles حسبطبيبToolStripMenuItem1.Click
        DOCT = 3
        I = L
        vv1 = Trim(ComboBox2.Text)
        DD1 = DateTimePicker1.Value.Date
        DD2 = DateTimePicker2.Value.Date
        Dim F As New Form59
        F.DD1 = DD1
        F.DD2 = DD2
        F.I = I
        F.ShowDialog()
    End Sub

    Private Sub كلالأطباءToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles كلالأطباءToolStripMenuItem1.Click
        DOCT = 4
        DD1 = DateTimePicker1.Value.Date
        DD2 = DateTimePicker2.Value.Date
        Dim F As New Form59
        F.DD1 = DD1
        F.DD2 = DD2
        F.ShowDialog()
    End Sub

    Private Sub طباعةالايراداتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةالايراداتToolStripMenuItem.Click
        DOCT = 5
        DD1 = DateTimePicker1.Value.Date
        'DD1 = DateTimePicker1.Value.Date.AddDays(-7D)
        DD2 = DateTimePicker2.Value.Date
        'DD2 = DateTimePicker2.Value.Date.AddDays(7D)
        'If DD1 = Date.Today.Date Then
        '    DD1 = Today.AddDays(-7D)
        'End If
        'If DD2 = Date.Today.Date Then
        '    DD2 = Today.AddDays(7D)
        'End If
        Dim F As New Form59
        F.DD1 = DD1
        F.DD2 = DD2
        F.ShowDialog()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If Trim(ComboBox18.Text) = "" Or ComboBox18.SelectedIndex = -1 Then
            ComboBox18.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox18.Text = "لايوجد"
            TextBox65.Text = 0
        End If
        If Trim(ComboBox16.Text) = "" Or ComboBox16.SelectedIndex = -1 Then
            ComboBox16.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox16.Text = "لايوجد"
            TextBox62.Text = 0
        End If
        If Trim(ComboBox21.Text) = "" Or ComboBox21.SelectedIndex = -1 Then
            ComboBox21.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox21.Text = "لايوجد"
            TextBox67.Text = 0
        End If
        If Trim(ComboBox15.Text) = "" Or ComboBox15.SelectedIndex = -1 Then
            ComboBox15.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox15.Text = "لايوجد"
            TextBox61.Text = 0
        End If
        If Trim(ComboBox19.Text) = "" Or ComboBox19.SelectedIndex = -1 Then
            ComboBox19.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox19.Text = "لايوجد"
            TextBox64.Text = 0
        End If
        If Trim(ComboBox14.Text) = "" Or ComboBox14.SelectedIndex = -1 Then
            ComboBox14.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox14.Text = "لايوجد"
            TextBox60.Text = 0
        End If
        If Trim(ComboBox17.Text) = "" Or ComboBox17.SelectedIndex = -1 Then
            ComboBox17.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox17.Text = "لايوجد"
            TextBox63.Text = 0
        End If
        If Trim(TextBox66.Text) = "" Then
            TextBox66.Text = 0
        End If
        If Trim(TextBox50.Text) = "" Then
            TextBox50.Text = 0
        End If
        If Trim(TextBox48.Text) = "" Then
            TextBox48.Text = 0
        End If
        If Trim(TextBox46.Text) = "" Then
            TextBox46.Text = 0
        End If

        TextBox70.Text = Val(TextBox62.Text) + Val(TextBox61.Text) + Val(TextBox67.Text) + Val(TextBox65.Text) + Val(TextBox64.Text) + Val(TextBox66.Text) + Val(TextBox63.Text) + Val(TextBox60.Text)
        TextBox69.Text = Val(TextBox59.Text) - Val(TextBox70.Text)
        'Dim s As String = "select * from amaleat_M where IDAM=@IDAM "
        'Using cm As New SqlClient.SqlCommand(s, cn)
        '    cm.Parameters.AddWithValue("@IDAM", CInt(L))
        '    Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        '    If rd.Read = True Then
        'If MsgBox("نوع العملية مسجل مسبقا ... هل تود التعديل في البيانات", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        Call Class1.CONNIC()
        Dim ss As String = "update Amaleat_M set CONF=@CONF,dock=@dock,tdocn=@tdocn,tdock=@tdock,mdocn=@mdocn,mdock=@mdock,fdocn=@fdocn,fdock=@fdock,ftdocn=@ftdocn,ftdock=@ftdock,tahn=@tahn,tahk=@tahk,kabn=@kabn,kabk=@kabk,cdocn=@cdocn,cdock=@cdock,aml_kema=@aml_kema,C_KEMA=@C_KEMA,ASH=@ASH,DWAA=@DWAA,EST=@EST where IDAm=@IDAm"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            'cmm.Parameters.AddWithValue("@IDA", CInt(Label42.Text))
            'cmm.Parameters.AddWithValue("@docn", CInt(Label46.Text))
            cmm.Parameters.AddWithValue("@CONF", True)
            cmm.Parameters.AddWithValue("@dock", CDbl(TextBox62.Text))
            cmm.Parameters.AddWithValue("@tdocn", CStr(ComboBox15.Text))
            cmm.Parameters.AddWithValue("@tdock", CDbl(TextBox61.Text))
            cmm.Parameters.AddWithValue("@mdocn", CStr(ComboBox21.Text))
            cmm.Parameters.AddWithValue("@mdock", CDbl(TextBox67.Text))
            cmm.Parameters.AddWithValue("@fdocn", CStr(ComboBox18.Text))
            cmm.Parameters.AddWithValue("@fdock", CDbl(TextBox65.Text))
            cmm.Parameters.AddWithValue("@ftdocn", CStr(ComboBox19.Text))
            cmm.Parameters.AddWithValue("@ftdock", CDbl(TextBox64.Text))
            cmm.Parameters.AddWithValue("@tahn", "تحاليل")
            cmm.Parameters.AddWithValue("@tahk", CDbl(TextBox66.Text))
            cmm.Parameters.AddWithValue("@kabn", CStr(ComboBox17.Text))
            cmm.Parameters.AddWithValue("@kabk", CDbl(TextBox63.Text))
            cmm.Parameters.AddWithValue("@cdocn", CStr(ComboBox14.Text))
            cmm.Parameters.AddWithValue("@cdock", CDbl(TextBox60.Text))
            'cmm.Parameters.AddWithValue("@aml_name", ComboBox13.Text)
            cmm.Parameters.AddWithValue("@aml_kema", CDbl(TextBox59.Text))
            cmm.Parameters.AddWithValue("@C_KEMA", CDbl(TextBox69.Text))
            cmm.Parameters.AddWithValue("@ASH", CDbl(TextBox46.Text))
            cmm.Parameters.AddWithValue("@DWAA", CDbl(TextBox50.Text))
            cmm.Parameters.AddWithValue("@EST", CDbl(TextBox48.Text))
            cmm.Parameters.AddWithValue("@IDAM", CInt(L))
            'cmm.Parameters.AddWithValue("@DOCN", CInt(Label46.Text))

            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم حفظ البيانات")
                Dim Str As String = "SELECT MAX(IDA) FROM Amaleat "
                Using cmd As New SqlClient.SqlCommand(Str, cn)
                    M6 = cmd.ExecuteScalar
                End Using

                Dim sl As String = "select * from dn where dn=@dn"
                Using cml As New SqlClient.SqlCommand(sl, cn)
                    cml.Parameters.AddWithValue("@dn", ComboBox16.Text)
                    Dim rdl As SqlClient.SqlDataReader
                    rdl = cml.ExecuteReader
                    If rdl.Read = True Then
                        Label44.Text = rdl!idd
                        rdl.Close()
                    End If
                End Using

                Dim sAZ As String = "select * from Ejraa where Ejraa=@Ejraa"
                Using cmA As New SqlClient.SqlCommand(sAZ, cn)
                    cmA.Parameters.AddWithValue("@Ejraa", ComboBox19.Text)
                    Dim rdA As SqlClient.SqlDataReader
                    rdA = cmA.ExecuteReader
                    If rdA.Read = True Then
                        Label45.Text = rdA!idj
                        rdA.Close()
                    End If
                End Using

                'Dim ss23 As String = "UPDATE dnkema SET idd=@idd,Ejraa=@Ejraa,Kema=@Kema,kemaej=@kemaej WHERE IDA=@IDA"
                'Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
                'cmm23.Parameters.AddWithValue("@idd", Label44.Text)
                'cmm23.Parameters.AddWithValue("@Ejraa", Label45.Text)
                'cmm23.Parameters.AddWithValue("@Kema", TextBox62.Text)
                'cmm23.Parameters.AddWithValue("@kemaej", TextBox59.Text)
                'cmm23.Parameters.AddWithValue("@IDA", M6)
                'cmm23.ExecuteNonQuery()

                Dim s16 As String = "select * from Amaleat "
                Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
                Dim dss As New DataSet
                dss.Clear()
                aad.Fill(dss, "Amaleat")
                Dim vd As New DataView(dss.Tables("Amaleat"))
                vd.RowFilter = "aml_name=" & "'" & Me.ComboBox13.Text & "'" & ""
                Me.DataGridView9.DataMember = ""
                DataGridView9.DataSource = vd
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("لم يتم الحفظ... راجع مدخلاتك")
            End Try
        End Using
        'End If
        'Else
        '    Dim ss As String = "insert into Amaleat_M(IDA,docn,dock,tdocn,tdock,mdocn,mdock,fdocn,fdock,ftdocn,ftdock,tahn,tahk,kabn,kabk,cdocn,cdock,aml_kema,C_KEMA,CONF)values(@IDA,@docn,@dock,@tdocn,@tdock,@mdocn,@mdock,@fdocn,@fdock,@ftdocn,@ftdock,@tahn,@tahk,@kabn,@kabk,@cdocn,@cdock,@aml_kema,@C_KEMA,@CONF)"
        '    Using cmm As New SqlClient.SqlCommand(ss, cn)
        '        cmm.Parameters.AddWithValue("@IDA", CInt(Label42.Text))
        '        cmm.Parameters.AddWithValue("@docn", CInt(Label46.Text))
        '        cmm.Parameters.AddWithValue("@dock", CDbl(TextBox62.Text))
        '        cmm.Parameters.AddWithValue("@tdocn", ComboBox15.Text)
        '        cmm.Parameters.AddWithValue("@tdock", CDbl(TextBox61.Text))
        '        cmm.Parameters.AddWithValue("@mdocn", ComboBox21.Text)
        '        cmm.Parameters.AddWithValue("@mdock", CDbl(TextBox67.Text))
        '        cmm.Parameters.AddWithValue("@fdocn", ComboBox18.Text)
        '        cmm.Parameters.AddWithValue("@fdock", CDbl(TextBox65.Text))
        '        cmm.Parameters.AddWithValue("@ftdocn", ComboBox19.Text)
        '        cmm.Parameters.AddWithValue("@ftdock", CDbl(TextBox64.Text))
        '        cmm.Parameters.AddWithValue("@tahn", TextBox68.Text)
        '        cmm.Parameters.AddWithValue("@tahk", CDbl(TextBox66.Text))
        '        cmm.Parameters.AddWithValue("@kabn", ComboBox17.Text)
        '        cmm.Parameters.AddWithValue("@kabk", CDbl(TextBox63.Text))
        '        cmm.Parameters.AddWithValue("@cdocn", ComboBox14.Text)
        '        cmm.Parameters.AddWithValue("@cdock", CDbl(TextBox60.Text))
        '        'cmm.Parameters.AddWithValue("@aml_name", ComboBox13.Text)
        '        cmm.Parameters.AddWithValue("@C_KEMA", TextBox69.Text)
        '        'TextBox9.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
        '        cmm.Parameters.AddWithValue("@aml_kema", CDbl(TextBox59.Text))
        '        cmm.Parameters.AddWithValue("@CONF", True)
        '        'Try
        '        cmm.ExecuteNonQuery()
        '        MsgBox("تم الحفظ")
        '        Dim Str As String = "SELECT MAX(IDA) FROM Amaleat "
        '        Using cmd As New SqlClient.SqlCommand(Str, cn)
        '            M6 = cmd.ExecuteScalar
        '        End Using
        '        Dim sl As String = "select * from dn where dn=@dn"
        '        Using cml As New SqlClient.SqlCommand(sl, cn)
        '            cml.Parameters.AddWithValue("@dn", ComboBox16.Text)
        '            Using rdl As SqlClient.SqlDataReader = cml.ExecuteReader
        '                If rdl.Read = True Then
        '                    Label44.Text = rdl!idd
        '                    rdl.Close()
        '                End If
        '            End Using
        '        End Using

        '        Dim sAX As String = "select * from Ejraa where Ejraa=@Ejraa"
        '        Using cmA As New SqlClient.SqlCommand(sAX, cn)
        '            cmA.Parameters.AddWithValue("@Ejraa", "عمليات")
        '            Using rdA As SqlClient.SqlDataReader = cmA.ExecuteReader
        '                If rdA.Read = True Then
        '                    Label45.Text = rdA!idj
        '                    rdA.Close()
        '                End If
        '            End Using
        '        End Using

        '        'Dim ss23 As String = "insert into dnkema(idd,Ejraa,IDA,Kema,kemaej) VALUES(@idd,@Ejraa,@IDA,@Kema,@kemaej)"
        '        'Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
        '        'cmm23.Parameters.AddWithValue("@idd", CInt(Label44.Text))
        '        'cmm23.Parameters.AddWithValue("@Ejraa", CInt(Label45.Text))
        '        'cmm23.Parameters.AddWithValue("@IDA", CInt(M6))
        '        'cmm23.Parameters.AddWithValue("@Kema", CDbl(TextBox62.Text))
        '        'cmm23.Parameters.AddWithValue("@kemaej", CDbl(TextBox59.Text))
        '        'cmm23.ExecuteNonQuery()

        '        Dim s16 As String = "select * from Amaleat "
        '        Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
        '        Dim dss As New DataSet
        '        dss.Clear()
        '        aad.Fill(dss, "Amaleat")
        '        Dim vd As New DataView(dss.Tables("Amaleat"))
        '        vd.RowFilter = "aml_name=" & "'" & Me.ComboBox13.Text & "'" & ""
        '        Me.DataGridView9.DataMember = ""
        '        DataGridView9.DataSource = vd
        '        'Catch ex As Exception
        '        '    MsgBox("لم يتم الحفظى... راجع مدخلاتك")
        '        'End Try
        '    End Using
        'End If
        Dim sA As String = "select * from DNKEMA where IDD=@IDD AND IDA=@IDA"
        Using cmA As New SqlClient.SqlCommand(sA, cn)
            cmA.Parameters.AddWithValue("@IDD", CInt(Label44.Text))
            cmA.Parameters.AddWithValue("@IDA", CInt(Label42.Text))
            Using rdA As SqlClient.SqlDataReader = cmA.ExecuteReader
                If rdA.Read = True Then
                    Dim ID As Integer
                    ID = rdA!id
                    rdA.Close()
                    Dim ss23 As String = "UPDATE dnkema SET idd=@idd,Ejraa=@Ejraa,Kema=@Kema,kemaej=@kemaej WHERE IDA=@IDA"
                    Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
                    cmm23.Parameters.AddWithValue("@idd", Label44.Text)
                    cmm23.Parameters.AddWithValue("@Ejraa", Label45.Text)
                    cmm23.Parameters.AddWithValue("@Kema", TextBox62.Text)
                    cmm23.Parameters.AddWithValue("@kemaej", TextBox59.Text)
                    cmm23.Parameters.AddWithValue("@IDA", M6)
                    cmm23.ExecuteNonQuery()
                    'If Trim(TextBox66.Text) <> "" Then
                    '    Dim ss23t As String = "UPDATE dnkema SET idd=@idd,Ejraa=@Ejraa,Kema=@Kema,kemaej=@kemaej WHERE IDA=@IDA"
                    '    Dim cmm23t As New SqlClient.SqlCommand(ss23t, cn)
                    '    cmm23t.Parameters.AddWithValue("@idd", 0)
                    '    cmm23t.Parameters.AddWithValue("@Ejraa", Label45.Text)
                    '    cmm23t.Parameters.AddWithValue("@Kema", TextBox66.Text)
                    '    cmm23t.Parameters.AddWithValue("@kemaej", TextBox59.Text)
                    '    cmm23t.Parameters.AddWithValue("@IDA", M6)
                    '    cmm23t.ExecuteNonQuery()
                    'End If
                Else
                    Dim ss23 As String = "insert into dnkema(idd,Ejraa,IDA,Kema,kemaej) VALUES(@idd,@Ejraa,@IDA,@Kema,@kemaej)"
                    Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
                    cmm23.Parameters.AddWithValue("@idd", CInt(Label44.Text))
                    cmm23.Parameters.AddWithValue("@Ejraa", CInt(Label45.Text))
                    cmm23.Parameters.AddWithValue("@IDA", CInt(M6))
                    cmm23.Parameters.AddWithValue("@Kema", CDbl(TextBox62.Text))
                    cmm23.Parameters.AddWithValue("@kemaej", CDbl(TextBox59.Text))
                    cmm23.ExecuteNonQuery()
                    'If Trim(TextBox66.Text) <> "" Then
                    '    Dim ss23t As String = "insert into dnkema(idd,Ejraa,IDA,Kema,kemaej) VALUES(@idd,@Ejraa,@IDA,@Kema,@kemaej)"
                    '    Dim cmm23t As New SqlClient.SqlCommand(ss23t, cn)
                    '    cmm23t.Parameters.AddWithValue("@idd", CInt(0))
                    '    cmm23t.Parameters.AddWithValue("@Ejraa", CInt(Label45.Text))
                    '    cmm23t.Parameters.AddWithValue("@IDA", CInt(M6))
                    '    cmm23t.Parameters.AddWithValue("@Kema", CDbl(TextBox66.Text))
                    '    cmm23t.Parameters.AddWithValue("@kemaej", CDbl(TextBox59.Text))
                    '    cmm23t.ExecuteNonQuery()
                    'End If

                End If
            End Using
        End Using


        'end using
        'End Using
        Dim sk15 As String
        sk15 = "select * from AMALEAT_M_V where conf='" & False & "' "
        Dim adk15 As New SqlClient.SqlDataAdapter(sk15, cn)
        Dim dsk15 As New DataSet
        adk15.Fill(dsk15, "AMALEAT_M_V")
        ComboBox13.DataSource = dsk15.Tables(0)
        ComboBox13.DisplayMember = "AML_NAME"
        ComboBox13.SelectedIndex = -1
        DataGridView9.DataSource = ""
        Dim sk2 As String
        sk2 = "select * from dn"
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox16.DataSource = dsk2.Tables(0)
        ComboBox16.DisplayMember = "dn"
        ComboBox16.SelectedIndex = -1
        ComboBox16.Text = ""
        TextBox62.Text = 0
        ComboBox15.Text = ""
        TextBox61.Text = 0
        ComboBox21.Text = ""
        TextBox67.Text = 0
        ComboBox18.Text = ""
        TextBox65.Text = 0
        ComboBox19.Text = ""
        TextBox64.Text = 0
        'TextBox68.Text = ""
        TextBox66.Text = 0
        ComboBox17.Text = ""
        TextBox63.Text = 0
        ComboBox14.Text = ""
        TextBox60.Text = 0
        ComboBox13.Text = ""
        TextBox59.Text = 0
        TextBox70.Text = 0
        TextBox69.Text = 0
        CheckBox1.Checked = False
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox13.SelectedIndexChanged
        If ComboBox13.SelectedIndex <> -1 Then
            If CheckBox1.Checked = False Then
                Call Class1.CONNIC()
                Dim s As String = "select * from AMALEAT_M_VIEW where aml_name=@aml_name and conf=@conf "
                Using cm As New SqlClient.SqlCommand(s, cn)
                    cm.Parameters.AddWithValue("@aml_name", Trim(ComboBox13.Text))
                    cm.Parameters.AddWithValue("@conf", False)
                    Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                    If rd.Read = True Then
                        Label42.Text = CInt(rd!IDA)
                        Dim sH As String = "select * from amaleat_M where IDA=@IDA and conf=@conf"
                        Using cmH As New SqlClient.SqlCommand(sH, cn)
                            cmH.Parameters.AddWithValue("@IDA", Label42.Text)
                            cmH.Parameters.AddWithValue("@conf", False)
                            Dim rdH As SqlClient.SqlDataReader = cmH.ExecuteReader
                            If rdH.Read = True Then
                                Label46.Text = CInt(rdH!DOCN)
                                TextBox62.Text = CDbl(rdH!DOCK)
                                '        Dim sU As String = "select * from DN where IDD=@IDD "
                                '        Using cmU As New SqlClient.SqlCommand(sU, cn)
                                '            cmU.Parameters.AddWithValue("@IDD", CInt(Label46.Text))
                                '            Dim rdU As SqlClient.SqlDataReader = cmU.ExecuteReader
                                '            If rdU.Read = True Then
                                '                ComboBox16.DropDownStyle = ComboBoxStyle.DropDown
                                ComboBox16.Text = rd!DN
                                ComboBox16.Enabled = False
                                TextBox62.Text = CDbl(rd!DOCK)

                                '            End If
                                '        End Using
                                'Dim sdoc As String
                                'sdoc = "select * from DN_V"
                                'Dim addoc As New SqlClient.SqlDataAdapter(sdoc, cn)
                                'Dim dsdoc As New DataSet
                                'addoc.Fill(dsdoc, "DN_V")
                                'ComboBox16.DataSource = dsdoc.Tables(0)
                                'ComboBox16.DisplayMember = "dn"
                                'ComboBox16.SelectedIndex = -1

                                Dim scdoc As String
                                scdoc = "select * from dn where idk='" & 4 & "' "
                                Dim adcdoc As New SqlClient.SqlDataAdapter(scdoc, cn)
                                Dim dscdoc As New DataSet
                                adcdoc.Fill(dscdoc, "dn")
                                ComboBox14.DataSource = dscdoc.Tables(0)
                                ComboBox14.DisplayMember = "dn"
                                ComboBox14.SelectedIndex = -1

                                Dim sfdoc As String
                                sfdoc = "select * from AM_FDOC"
                                Dim adfdoc As New SqlClient.SqlDataAdapter(sfdoc, cn)
                                Dim dsfdoc As New DataSet
                                adfdoc.Fill(dsfdoc, "AM_FDOC")
                                ComboBox18.DataSource = dsfdoc.Tables(0)
                                ComboBox18.DisplayMember = "FDOCN"
                                ComboBox18.SelectedIndex = -1

                                Dim sMdoc As String
                                sMdoc = "select * from AM_MDOC"
                                Dim adMdoc As New SqlClient.SqlDataAdapter(sMdoc, cn)
                                Dim dsMdoc As New DataSet
                                adMdoc.Fill(dsMdoc, "AM_MDOC")
                                ComboBox21.DataSource = dsMdoc.Tables(0)
                                ComboBox21.DisplayMember = "MDOCN"
                                ComboBox21.SelectedIndex = -1

                                Dim sTdoc As String
                                sTdoc = "select * from AM_TDOC"
                                Dim adTdoc As New SqlClient.SqlDataAdapter(sTdoc, cn)
                                Dim dsTdoc As New DataSet
                                adTdoc.Fill(dsTdoc, "AM_TDOC")
                                ComboBox15.DataSource = dsTdoc.Tables(0)
                                ComboBox15.DisplayMember = "TDOCN"
                                ComboBox15.SelectedIndex = -1

                                Dim sfTdoc As String
                                sfTdoc = "select * from AM_FTDOC"
                                Dim adFTdoc As New SqlClient.SqlDataAdapter(sfTdoc, cn)
                                Dim dsfTdoc As New DataSet
                                adFTdoc.Fill(dsfTdoc, "AM_FTDOC")
                                ComboBox19.DataSource = dsfTdoc.Tables(0)
                                ComboBox19.DisplayMember = "FTDOCN"
                                ComboBox19.SelectedIndex = -1

                                Dim SKAB As String
                                SKAB = "select * from AM_KAB"
                                Dim adKAB As New SqlClient.SqlDataAdapter(SKAB, cn)
                                Dim dsKAB As New DataSet
                                adKAB.Fill(dsKAB, "AM_KAB")
                                ComboBox17.DataSource = dsKAB.Tables(0)
                                ComboBox17.DisplayMember = "KABN"
                                ComboBox17.SelectedIndex = -1

                                'Dim sN As String = "select * from DN where IDD=@IDD "
                                'Using cmN As New SqlClient.SqlCommand(sN, cn)
                                '    cmN.Parameters.AddWithValue("@IDD", CInt(ComboBox16.Text))
                                '    Dim rdN As SqlClient.SqlDataReader = cmN.ExecuteReader
                                '    If rdN.Read = True Then
                                '        ComboBox16.Text = rdN!DN
                                '        'ComboBox16.Enabled = False
                                '    End If
                                'End Using
                                TextBox62.Text = CDbl(rd!Dock)
                                ComboBox15.Text = rdH!tdocn
                                TextBox61.Text = CDbl(rdH!tdock)
                                ComboBox21.Text = rdH!mdocn
                                TextBox67.Text = CDbl(rdH!mdock)
                                ComboBox18.Text = rdH!fdocn
                                TextBox65.Text = CDbl(rdH!fdock)
                                ComboBox19.Text = rdH!ftdocn
                                TextBox64.Text = CDbl(rdH!ftdock)
                                'TextBox68.Text = rd!tahn
                                TextBox66.Text = CDbl(rdH!tahk)
                                ComboBox17.Text = rdH!kabn
                                TextBox63.Text = CDbl(rdH!kabk)
                                ComboBox14.Text = rdH!cdocn
                                TextBox60.Text = CDbl(rdH!cdock)
                                ComboBox13.Text = rd!aml_name
                                TextBox59.Text = CDbl(rd!aml_kema)
                                TextBox69.Text = CDbl(rdH!C_KEMA)
                                TextBox70.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
                                'TextBox11.Text = Val(TextBox9.Text) - Val(TextBox10.Text)
                                Dim s16z As String = "select * from Amaleat_M "
                                Dim aadz As New SqlClient.SqlDataAdapter(s16z, cn)
                                Dim dssz As New DataSet
                                dssz.Clear()
                                aadz.Fill(dssz, "Amaleat_M")
                                Dim vdz As New DataView(dssz.Tables("Amaleat_M"))
                                vdz.RowFilter = "IDA=" & "'" & Me.Label42.Text & "'" & "and conf=" & "'" & False & "'" & ""
                                Me.DataGridView9.DataMember = ""
                                DataGridView9.DataSource = vdz
                                GroupBox83.Enabled = False
                                GroupBox81.Enabled = False
                                GroupBox88.Enabled = False
                                GroupBox86.Enabled = False
                                GroupBox84.Enabled = False
                                GroupBox80.Enabled = False
                                GroupBox76.Enabled = False
                                GroupBox74.Enabled = False
                                GroupBox75.Enabled = False
                                GroupBox73.Enabled = False
                                GroupBox82.Enabled = False
                                GroupBox79.Enabled = False
                                'GroupBox87.Enabled = False
                                GroupBox85.Enabled = False
                            End If
                        End Using
                    End If
                End Using
                Call Class4.CONNIC()
            Else
                Call Class1.CONNIC()
                Dim s As String = "select * from AMALEAT_M_VIEW where aml_name=@aml_name "
                Using cm As New SqlClient.SqlCommand(s, cn)
                    cm.Parameters.AddWithValue("@aml_name", ComboBox13.Text)
                    'cm.Parameters.AddWithValue("@conf", False)
                    Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                    If rd.Read = True Then
                        Label42.Text = CInt(rd!IDA)
                        Dim sH As String = "select * from amaleat_M where IDA=@IDA"
                        Using cmH As New SqlClient.SqlCommand(sH, cn)
                            cmH.Parameters.AddWithValue("@IDA", Label42.Text)
                            'cmH.Parameters.AddWithValue("@conf", False)
                            Dim rdH As SqlClient.SqlDataReader = cmH.ExecuteReader
                            If rdH.Read = True Then
                                Label46.Text = CInt(rdH!DOCN)
                                TextBox62.Text = CDbl(rdH!DOCK)
                                '        Dim sU As String = "select * from DN where IDD=@IDD "
                                '        Using cmU As New SqlClient.SqlCommand(sU, cn)
                                '            cmU.Parameters.AddWithValue("@IDD", CInt(Label46.Text))
                                '            Dim rdU As SqlClient.SqlDataReader = cmU.ExecuteReader
                                '            If rdU.Read = True Then
                                '                ComboBox16.DropDownStyle = ComboBoxStyle.DropDown
                                ComboBox16.Text = rd!DN
                                ComboBox16.Enabled = False
                                TextBox62.Text = CDbl(rd!DOCK)

                                '            End If
                                '        End Using
                                'Dim sdoc As String
                                'sdoc = "select * from DN_V"
                                'Dim addoc As New SqlClient.SqlDataAdapter(sdoc, cn)
                                'Dim dsdoc As New DataSet
                                'addoc.Fill(dsdoc, "DN_V")
                                'ComboBox16.DataSource = dsdoc.Tables(0)
                                'ComboBox16.DisplayMember = "dn"
                                'ComboBox16.SelectedIndex = -1

                                Dim scdoc As String
                                scdoc = "select * from dn where idk='" & 4 & "' "
                                Dim adcdoc As New SqlClient.SqlDataAdapter(scdoc, cn)
                                Dim dscdoc As New DataSet
                                adcdoc.Fill(dscdoc, "dn")
                                ComboBox14.DataSource = dscdoc.Tables(0)
                                ComboBox14.DisplayMember = "dn"
                                ComboBox14.SelectedIndex = -1

                                Dim sfdoc As String
                                sfdoc = "select * from AM_FDOC"
                                Dim adfdoc As New SqlClient.SqlDataAdapter(sfdoc, cn)
                                Dim dsfdoc As New DataSet
                                adfdoc.Fill(dsfdoc, "AM_FDOC")
                                ComboBox18.DataSource = dsfdoc.Tables(0)
                                ComboBox18.DisplayMember = "FDOCN"
                                ComboBox18.SelectedIndex = -1

                                Dim sMdoc As String
                                sMdoc = "select * from AM_MDOC"
                                Dim adMdoc As New SqlClient.SqlDataAdapter(sMdoc, cn)
                                Dim dsMdoc As New DataSet
                                adMdoc.Fill(dsMdoc, "AM_MDOC")
                                ComboBox21.DataSource = dsMdoc.Tables(0)
                                ComboBox21.DisplayMember = "MDOCN"
                                ComboBox21.SelectedIndex = -1

                                Dim sTdoc As String
                                sTdoc = "select * from AM_TDOC"
                                Dim adTdoc As New SqlClient.SqlDataAdapter(sTdoc, cn)
                                Dim dsTdoc As New DataSet
                                adTdoc.Fill(dsTdoc, "AM_TDOC")
                                ComboBox15.DataSource = dsTdoc.Tables(0)
                                ComboBox15.DisplayMember = "TDOCN"
                                ComboBox15.SelectedIndex = -1

                                Dim sfTdoc As String
                                sfTdoc = "select * from AM_FTDOC"
                                Dim adFTdoc As New SqlClient.SqlDataAdapter(sfTdoc, cn)
                                Dim dsfTdoc As New DataSet
                                adFTdoc.Fill(dsfTdoc, "AM_FTDOC")
                                ComboBox19.DataSource = dsfTdoc.Tables(0)
                                ComboBox19.DisplayMember = "FTDOCN"
                                ComboBox19.SelectedIndex = -1

                                Dim SKAB As String
                                SKAB = "select * from AM_KAB"
                                Dim adKAB As New SqlClient.SqlDataAdapter(SKAB, cn)
                                Dim dsKAB As New DataSet
                                adKAB.Fill(dsKAB, "AM_KAB")
                                ComboBox17.DataSource = dsKAB.Tables(0)
                                ComboBox17.DisplayMember = "KABN"
                                ComboBox17.SelectedIndex = -1

                                'Dim sN As String = "select * from DN where IDD=@IDD "
                                'Using cmN As New SqlClient.SqlCommand(sN, cn)
                                '    cmN.Parameters.AddWithValue("@IDD", CInt(ComboBox16.Text))
                                '    Dim rdN As SqlClient.SqlDataReader = cmN.ExecuteReader
                                '    If rdN.Read = True Then
                                '        ComboBox16.Text = rdN!DN
                                '        'ComboBox16.Enabled = False
                                '    End If
                                'End Using
                                TextBox62.Text = CDbl(rd!Dock)
                                ComboBox15.Text = rdH!tdocn
                                TextBox61.Text = CDbl(rdH!tdock)
                                ComboBox21.Text = rdH!mdocn
                                TextBox67.Text = CDbl(rdH!mdock)
                                ComboBox18.Text = rdH!fdocn
                                TextBox65.Text = CDbl(rdH!fdock)
                                ComboBox19.Text = rdH!ftdocn
                                TextBox64.Text = CDbl(rdH!ftdock)
                                'TextBox68.Text = rd!tahn
                                TextBox66.Text = CDbl(rdH!tahk)
                                ComboBox17.Text = rdH!kabn
                                TextBox63.Text = CDbl(rdH!kabk)
                                ComboBox14.Text = rdH!cdocn
                                TextBox60.Text = CDbl(rdH!cdock)
                                ComboBox13.Text = rd!aml_name
                                TextBox59.Text = CDbl(rd!aml_kema)
                                TextBox69.Text = CDbl(rdH!C_KEMA)
                                TextBox70.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
                                'TextBox11.Text = Val(TextBox9.Text) - Val(TextBox10.Text)
                                Dim s16z As String = "select * from Amaleat_M "
                                Dim aadz As New SqlClient.SqlDataAdapter(s16z, cn)
                                Dim dssz As New DataSet
                                dssz.Clear()
                                aadz.Fill(dssz, "Amaleat_M")
                                Dim vdz As New DataView(dssz.Tables("Amaleat_M"))
                                vdz.RowFilter = "IDA=" & "'" & Me.Label42.Text & "'" & ""
                                Me.DataGridView9.DataMember = ""
                                DataGridView9.DataSource = vdz
                                GroupBox83.Enabled = False
                                GroupBox81.Enabled = False
                                GroupBox88.Enabled = False
                                GroupBox86.Enabled = False
                                GroupBox84.Enabled = False
                                GroupBox80.Enabled = False
                                GroupBox76.Enabled = False
                                GroupBox74.Enabled = False
                                GroupBox75.Enabled = False
                                GroupBox73.Enabled = False
                                GroupBox82.Enabled = False
                                GroupBox79.Enabled = False
                                'GroupBox87.Enabled = False
                                GroupBox85.Enabled = False
                            End If
                        End Using
                    End If
                End Using
                Call Class4.CONNIC()
            End If
        End If
        '    End Using

        'End If

    End Sub

    Private Sub ComboBox18_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox18.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sn2C As String = "select * from AM_FDOC where FDOCN=@FDOCN "
        Using cmn2C As New SqlClient.SqlCommand(sn2C, cn)
            cmn2C.Parameters.AddWithValue("@FDOCN", ComboBox18.Text)
            Dim rdn2C As SqlClient.SqlDataReader = cmn2C.ExecuteReader
            If rdn2C.Read = True Then
                Me.TextBox65.Text = CDbl(rdn2C!FDOCK)
            End If
        End Using
        Call Class4.CONNIC()

    End Sub

    Private Sub ComboBox18_Validated(sender As Object, e As EventArgs) Handles ComboBox18.Validated
        If Trim(ComboBox18.Text) = "" Then
            ComboBox18.Text = "لايوجد"
            TextBox65.Text = 0
        End If
    End Sub

    Private Sub ComboBox18_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboBox18.Validating
        If Trim(ComboBox18.Text) = "" Or ComboBox18.SelectedIndex = -1 Then
            ComboBox18.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox18.Text = "لايوجد"
            TextBox65.Text = 0
        End If
    End Sub

    Private Sub TextBox65_TextChanged(sender As Object, e As EventArgs) Handles TextBox65.TextChanged

    End Sub

    Private Sub ComboBox21_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox21.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sn2C As String = "select * from AM_MDOC where MDOCN=@MDOCN "
        Using cmn2C As New SqlClient.SqlCommand(sn2C, cn)
            cmn2C.Parameters.AddWithValue("@MDOCN", ComboBox21.Text)
            Dim rdn2C As SqlClient.SqlDataReader = cmn2C.ExecuteReader
            If rdn2C.Read = True Then
                Me.TextBox67.Text = CDbl(rdn2C!MDOCK)
            End If
        End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox21_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboBox21.Validating
        If Trim(ComboBox21.Text) = "" Then
            ComboBox21.Text = "لايوجد"
            TextBox67.Text = 0
        End If
    End Sub

    Private Sub ComboBox15_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox15.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sn2 As String = "select * from AM_TDOC where TDOCN=@TDOCN "
        Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
            cmn2.Parameters.AddWithValue("@TDOCN", ComboBox15.Text)
            Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
            If rdn2.Read = True Then
                Me.TextBox61.Text = CDbl(rdn2!TDOCK)
            End If
        End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox15_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboBox15.Validating
        If Trim(ComboBox15.Text) = "" Then
            ComboBox15.Text = "لايوجد"
            TextBox61.Text = 0
        End If
    End Sub

    Private Sub ComboBox19_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox19.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sn2C As String = "select * from AM_FTDOC where FTDOCN=@FTDOCN "
        Using cmn2C As New SqlClient.SqlCommand(sn2C, cn)
            cmn2C.Parameters.AddWithValue("@FTDOCN", ComboBox19.Text)
            Dim rdn2C As SqlClient.SqlDataReader = cmn2C.ExecuteReader
            If rdn2C.Read = True Then
                Me.TextBox64.Text = CDbl(rdn2C!FTDOCK)
            End If
        End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox19_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboBox19.Validating
        If Trim(ComboBox19.Text) = "" Then
            ComboBox19.Text = "لايوجد"
            TextBox64.Text = 0
        End If
    End Sub

    Private Sub TextBox66_TextChanged(sender As Object, e As EventArgs) Handles TextBox66.TextChanged

    End Sub

    Private Sub TextBox66_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox66.Validating
        If Trim(TextBox66.Text) = "" Then
            TextBox66.Text = 0
        End If
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox14.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sn2 As String = "select * from dn where dn=@xx1 "
        Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
            cmn2.Parameters.AddWithValue("@xx1", ComboBox14.Text)
            Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
            If rdn2.Read = True Then
                Me.Label47.Text = rdn2!idd
            End If
            rdn2.Close()
        End Using
        Dim sn2C As String = "select * from AM_CDOC where IDD=@IDD "
        Using cmn2C As New SqlClient.SqlCommand(sn2C, cn)
            cmn2C.Parameters.AddWithValue("@IDD", Label47.Text)
            Dim rdn2C As SqlClient.SqlDataReader = cmn2C.ExecuteReader
            If rdn2C.Read = True Then
                Me.TextBox60.Text = CDbl(rdn2C!CDOCK)
            End If
        End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox14_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboBox14.Validating
        If Trim(ComboBox14.Text) = "" Then
            ComboBox14.Text = "لايوجد"
            TextBox60.Text = 0
        End If

    End Sub

    Private Sub ComboBox17_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox17.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sn2C As String = "select * from AM_KAB where KABN=@KABN "
        Using cmn2C As New SqlClient.SqlCommand(sn2C, cn)
            cmn2C.Parameters.AddWithValue("@KABN", ComboBox17.Text)
            Dim rdn2C As SqlClient.SqlDataReader = cmn2C.ExecuteReader
            If rdn2C.Read = True Then
                Me.TextBox63.Text = CDbl(rdn2C!KABK)
            End If
        End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox17_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboBox17.Validating
        If Trim(ComboBox17.Text) = "" Then
            ComboBox17.Text = "لايوجد"
            TextBox63.Text = 0
        End If
    End Sub

    Private Sub TextBox62_TextChanged(sender As Object, e As EventArgs) Handles TextBox62.TextChanged

    End Sub

    Private Sub TextBox62_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox62.Validating
        If Trim(TextBox62.Text) = "" Then
            TextBox62.Text = 0
        End If
    End Sub

    Private Sub TextBox65_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox65.Validating
        If Trim(TextBox65.Text) = "" Then
            TextBox65.Text = 0
        End If
    End Sub

    Private Sub TextBox67_TextChanged(sender As Object, e As EventArgs) Handles TextBox67.TextChanged

    End Sub

    Private Sub TextBox67_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox67.Validating
        If Trim(TextBox67.Text) = "" Then
            TextBox67.Text = 0
        End If
    End Sub

    Private Sub TextBox61_TextChanged(sender As Object, e As EventArgs) Handles TextBox61.TextChanged

    End Sub

    Private Sub TextBox61_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox61.Validating
        If Trim(TextBox61.Text) = "" Then
            TextBox61.Text = 0
        End If
    End Sub

    Private Sub TextBox64_TextChanged(sender As Object, e As EventArgs) Handles TextBox64.TextChanged

    End Sub

    Private Sub TextBox64_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox64.Validating
        If Trim(TextBox64.Text) = "" Then
            TextBox64.Text = 0
        End If
    End Sub

    Private Sub TextBox60_TextChanged(sender As Object, e As EventArgs) Handles TextBox60.TextChanged

    End Sub

    Private Sub TextBox60_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox60.Validating
        If Trim(TextBox60.Text) = "" Then
            TextBox60.Text = 0
        End If
    End Sub

    Private Sub TextBox63_TextChanged(sender As Object, e As EventArgs) Handles TextBox63.TextChanged

    End Sub

    Private Sub TextBox63_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox63.Validating
        If Trim(TextBox63.Text) = "" Then
            TextBox63.Text = 0
        End If
    End Sub

    Private Sub TextBox70_TextChanged(sender As Object, e As EventArgs) Handles TextBox70.TextChanged

    End Sub

    Private Sub TextBox70_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox70.Validating
        If Trim(TextBox70.Text) = "" Then
            TextBox70.Text = 0
        End If
    End Sub

    Private Sub TextBox69_TextChanged(sender As Object, e As EventArgs) Handles TextBox69.TextChanged

    End Sub

    Private Sub TextBox69_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox69.Validating
        If Trim(TextBox69.Text) = "" Then
            TextBox69.Text = 0
        End If
    End Sub

    Private Sub ComboBox16_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox16.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sn2 As String = "select * from dn where dn=@xx1 "
        Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
            cmn2.Parameters.AddWithValue("@xx1", ComboBox16.Text)
            Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
            If rdn2.Read = True Then
                Me.Label46.Text = rdn2!idd
                Dim sn22 As String = "select * from am_doc where idd=@idd and ida=@ida "
                Using cmn22 As New SqlClient.SqlCommand(sn22, cn)
                    cmn22.Parameters.AddWithValue("@idd", CInt(Label46.Text))
                    cmn22.Parameters.AddWithValue("@ida", CInt(Label42.Text))
                    Dim rdn22 As SqlClient.SqlDataReader = cmn22.ExecuteReader
                    If rdn22.Read = True Then
                        TextBox62.Text = CDbl(rdn22!dock)
                    End If
                End Using
            End If
            rdn2.Close()
        End Using
        Call Class4.CONNIC()
    End Sub

    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B0.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B0.Text
        bk = B0.Text
        TextBox8.Text = B0.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B0.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Call Class1.CONNIC()
        Dim ss As String = "insert into HESAB_AM(NAMEX,TYPE_H,TAS_KEMA,TAS_DATE,user_name)values(@NAMEX,@TYPE_H,@TAS_KEMA,@TAS_DATE,@user_name)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("@NAMEX", ComboBox7.Text)
        cmm.Parameters.AddWithValue("@TYPE_H", ComboBox11.Text)
        cmm.Parameters.AddWithValue("@TAS_KEMA", CDbl(TextBox32.Text))
        cmm.Parameters.AddWithValue("@TAS_DATE", Date.Today.Date)
        cmm.Parameters.AddWithValue("@user_name", CChar(user))
        Try
            cmm.ExecuteNonQuery()
            MsgBox("تم تسليم القيمة")
            Try
                'Dim cr1 As New DOCPRINT, cri As String
                'cri = "{HESAB_DO.DOCTORNAME}=" & "'" & ComboBox2.Text & "'"
                ''KESEM_P = TextBox3.Text
                ''cr1.SetParameterValue(0, Me.KESEM_P)
                'cr1.RecordSelectionFormula = cri
                'cr1.PrintOptions.PrinterName = "LK-TE212"
                ''cr1.PrintOptions.PrinterName = "LK-TE212"
                'cr1.PrintToPrinter(1, False, 1, 1)

            Catch ex As Exception
                MsgBox("No printe")
            End Try
        Catch ex As Exception
            MsgBox("خطأ في التسليم راجع مدخلاتك")
        End Try
        Dim s16S As String = "select * from HESAB_AM "
        Dim aadS As New SqlClient.SqlDataAdapter(s16S, cn)
        Dim dssS As New DataSet
        dssS.Clear()
        aadS.Fill(dssS, "HESAB_AM")
        Dim vdS As New DataView(dssS.Tables("HESAB_AM"))
        vdS.RowFilter = "TAS_DATE>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND TAS_DATE<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND TYPE_H=" & "'" & Me.ComboBox11.Text & "'" & "AND NAMEX=" & "'" & Me.ComboBox7.Text & "'" & ""
        Me.DataGridView10.DataMember = ""
        DataGridView10.DataSource = vdS
        If DataGridView10.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView10.Rows.Count - 1
                tot += DataGridView10.Item(1, i).Value
            Next
            Label18.Text = tot
            Label20.Text = Val(Label19.Text) - Val(Label18.Text)
        End If
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox11.SelectedIndexChanged
        Call Class1.CONNIC()
        If ComboBox11.Text = "مساعد العمليات" Then
            GroupBox37.Text = "اسم مساعد العمليات"
            Dim skF As String
            skF = "select * from AM_MDOC"
            Dim adkF As New SqlClient.SqlDataAdapter(skF, cn)
            Dim dskF As New DataSet
            adkF.Fill(dskF, "AM_MDOC")
            ComboBox7.DataSource = dskF.Tables(0)
            ComboBox7.DisplayMember = "MDOCN"
            ComboBox7.SelectedIndex = -1
        ElseIf ComboBox11.Text = "فني العمليات" Then
            GroupBox37.Text = "اسم فني العمليات"
            Dim skF As String
            skF = "select * from AM_FDOC"
            Dim adkF As New SqlClient.SqlDataAdapter(skF, cn)
            Dim dskF As New DataSet
            adkF.Fill(dskF, "AM_FDOC")
            ComboBox7.DataSource = dskF.Tables(0)
            ComboBox7.DisplayMember = "FDOCN"
            ComboBox7.SelectedIndex = -1
        ElseIf ComboBox11.Text = "دكتور التخدير" Then
            GroupBox37.Text = "اسم دكتور التخدير"
            Dim skF As String
            skF = "select * from AM_TDOC"
            Dim adkF As New SqlClient.SqlDataAdapter(skF, cn)
            Dim dskF As New DataSet
            adkF.Fill(dskF, "AM_TDOC")
            ComboBox7.DataSource = dskF.Tables(0)
            ComboBox7.DisplayMember = "TDOCN"
            ComboBox7.SelectedIndex = -1
        ElseIf ComboBox11.Text = "فني التخدير" Then
            GroupBox37.Text = "اسم فني التخدير"
            Dim skF As String
            skF = "select * from AM_FTDOC"
            Dim adkF As New SqlClient.SqlDataAdapter(skF, cn)
            Dim dskF As New DataSet
            adkF.Fill(dskF, "AM_FTDOC")
            ComboBox7.DataSource = dskF.Tables(0)
            ComboBox7.DisplayMember = "FTDOCN"
            ComboBox7.SelectedIndex = -1
        ElseIf ComboBox11.Text = "القابلة" Then
            GroupBox37.Text = "اسم القابلة"
            Dim skF As String
            skF = "select * from AM_KAB"
            Dim adkF As New SqlClient.SqlDataAdapter(skF, cn)
            Dim dskF As New DataSet
            adkF.Fill(dskF, "AM_KAB")
            ComboBox7.DataSource = dskF.Tables(0)
            ComboBox7.DisplayMember = "KABN"
            ComboBox7.SelectedIndex = -1
        End If

        'If ComboBox11.Text <> "" Then
        'Dim s1 As String = "select * from AMALEAT_M "
        'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        'Dim dss As New DataSet
        'dss.Clear()
        'aad.Fill(dss, "AMALEAT_M")
        'Dim vd As New DataView(dss.Tables("AMALEAT_M"))
        ''vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND doctorname=" & "'" & Me.ComboBox2.Text & "'" & ""
        'vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & ""
        'Me.DataGridView11.DataMember = ""
        'DataGridView11.DataSource = vd
        'If DataGridView11.Rows.Count <> 0 Then
        '    Dim xc As Integer = 0
        '    Dim tot As Integer = 0
        '    Dim i As Integer = 0
        '    For i = 0 To DataGridView11.Rows.Count - 1
        '        tot += DataGridView11.Item(6, i).Value
        '    Next
        '    'Label7.Text = tot
        '    Label19.Text = tot
        'Else
        '    Label19.Text = 0
        'End If
        ''If DataGridView2.Rows.Count <> 0 Then
        ''    Dim xc As Integer = 0
        ''    Dim tot As Integer = 0
        ''    Dim i As Integer = 0
        ''    For i = 0 To DataGridView2.Rows.Count - 1
        ''        tot += DataGridView2.Item(2, i).Value
        ''    Next
        ''    Label6.Text = tot
        ''End If
        'If DataGridView11.Rows.Count <> 0 Then
        '    Dim xc As Integer = 0
        '    Dim tot As Integer = 0
        '    Dim i As Integer = 0
        '    For i = 0 To DataGridView11.Rows.Count - 1
        '        tot += 1
        '    Next
        '    Label21.Text = tot
        'End If

        TextBox34.Text = ComboBox11.Text
        TextBox35.Text = TextBox9.Text
        Call Class4.CONNIC()
        'End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim s1 As String = "select * from AMALEAT_M "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "AMALEAT_M")
        Dim vd As New DataView(dss.Tables("AMALEAT_M"))
        'vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND doctorname=" & "'" & Me.ComboBox2.Text & "'" & ""
        If ComboBox11.Text = "مساعد العمليات" Then
            vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND MDOCN=" & "'" & Me.ComboBox7.Text & "'" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(6, i).Value
                Next
                Label19.Text = tot
            Else
                Label19.Text = 0
            End If
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += 1
                Next
                Label21.Text = tot
            End If
        ElseIf ComboBox11.Text = "فني العمليات" Then
            vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND FDOCN=" & "'" & Me.ComboBox7.Text & "'" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(8, i).Value
                Next
                Label19.Text = tot
            Else
                Label19.Text = 0
            End If
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += 1
                Next
                Label21.Text = tot
            End If
        ElseIf ComboBox11.Text = "دكتور التخدير" Then
            vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND TDOCN=" & "'" & Me.ComboBox7.Text & "'" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(4, i).Value
                Next
                Label19.Text = tot
            Else
                Label19.Text = 0
            End If
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += 1
                Next
                Label21.Text = tot
            End If
        ElseIf ComboBox11.Text = "فني التخدير" Then
            vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND FTDOCN=" & "'" & Me.ComboBox7.Text & "'" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(10, i).Value
                Next
                Label19.Text = tot
            Else
                Label19.Text = 0
            End If
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += 1
                Next
                Label21.Text = tot
            End If
        ElseIf ComboBox11.Text = "القابلة" Then
            vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND KABN=" & "'" & Me.ComboBox7.Text & "'" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(14, i).Value
                Next
                Label19.Text = tot
            Else
                Label19.Text = 0
            End If
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += 1
                Next
                Label21.Text = tot
            End If
        End If
        If Trim(ComboBox7.Text) <> "" Then
            Dim s16S As String = "select * from HESAB_AM "
            Dim aadS As New SqlClient.SqlDataAdapter(s16S, cn)
            Dim dssS As New DataSet
            dssS.Clear()
            aadS.Fill(dssS, "HESAB_AM")
            Dim vdS As New DataView(dssS.Tables("HESAB_AM"))
            vdS.RowFilter = "TAS_DATE>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND TAS_DATE<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND TYPE_H=" & "'" & Me.ComboBox11.Text & "'" & "AND NAMEX=" & "'" & Me.ComboBox7.Text & "'" & ""
            Me.DataGridView10.DataMember = ""
            DataGridView10.DataSource = vdS
            If DataGridView10.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView10.Rows.Count - 1
                    tot += DataGridView10.Item(1, i).Value
                Next
                Label18.Text = tot
                Label20.Text = Val(Label19.Text) - Val(Label18.Text)
            Else
                Label18.Text = 0
                Label20.Text = Val(Label19.Text)
            End If
        End If
        Call Class4.CONNIC()

    End Sub

    Private Sub ComboBox7_TextChanged(sender As Object, e As EventArgs) Handles ComboBox7.TextChanged
        Call Class1.CONNIC()
        Dim s1 As String = "select * from AMALEAT_M "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "AMALEAT_M")
        Dim vd As New DataView(dss.Tables("AMALEAT_M"))
        'vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND doctorname=" & "'" & Me.ComboBox2.Text & "'" & ""
        If ComboBox11.Text = "مساعد العمليات" Then
            vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND MDOCN=" & "'" & Me.ComboBox7.Text & "'" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(6, i).Value
                Next
                Label19.Text = tot
            Else
                Label19.Text = 0
            End If
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += 1
                Next
                Label21.Text = tot
            End If
        ElseIf ComboBox11.Text = "فني العمليات" Then
            vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND FDOCN=" & "'" & Me.ComboBox7.Text & "'" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(8, i).Value
                Next
                Label19.Text = tot
            Else
                Label19.Text = 0
            End If
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += 1
                Next
                Label21.Text = tot
            End If
        ElseIf ComboBox11.Text = "دكتور التخدير" Then
            vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND TDOCN=" & "'" & Me.ComboBox7.Text & "'" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(4, i).Value
                Next
                Label19.Text = tot
            Else
                Label19.Text = 0
            End If
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += 1
                Next
                Label21.Text = tot
            End If
        ElseIf ComboBox11.Text = "فني التخدير" Then
            vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND FTDOCN=" & "'" & Me.ComboBox7.Text & "'" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(10, i).Value
                Next
                Label19.Text = tot
            Else
                Label19.Text = 0
            End If
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += 1
                Next
                Label21.Text = tot
            End If
        ElseIf ComboBox11.Text = "القابلة" Then
            vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND KABN=" & "'" & Me.ComboBox7.Text & "'" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(14, i).Value
                Next
                Label19.Text = tot
            Else
                Label19.Text = 0
            End If
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += 1
                Next
                Label21.Text = tot
            End If
        End If
        Call Class4.CONNIC()

    End Sub

    Private Sub TabPage7_Click(sender As Object, e As EventArgs) Handles TabPage7.Click

    End Sub

    Private Sub TextBox32_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox32.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox32.Text = "" Then
                MsgBox("يرجى ادخال القيمة المسلمة")
                TextBox32.Focus()
            Else
                Button16.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox32_TextChanged(sender As Object, e As EventArgs) Handles TextBox32.TextChanged
        If TextBox32.Text = Trim("") Then
            Button16.Enabled = False
            Button15.Enabled = False
        Else
            Button16.Enabled = True
            Button15.Enabled = True
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Call Class1.CONNIC()
        Dim ss As String = "insert into HESAB_AM(NAMEX,TYPE_H,TAS_KEMA,TAS_DATE,user_name)values(@NAMEX,@TYPE_H,@TAS_KEMA,@TAS_DATE,@user_name)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("@NAMEX", ComboBox7.Text)
        cmm.Parameters.AddWithValue("@TYPE_H", ComboBox11.Text)
        cmm.Parameters.AddWithValue("@TAS_KEMA", CDbl(-TextBox32.Text))
        cmm.Parameters.AddWithValue("@TAS_DATE", Date.Today.Date)
        cmm.Parameters.AddWithValue("@user_name", CChar(user))
        If MsgBox("هل تريد إرجاع القيمة", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم إرجاع القيمة")
                Try
                    'Dim cr1 As New DOCPRINT, cri As String
                    'cri = "{HESAB_DO.DOCTORNAME}=" & "'" & ComboBox2.Text & "'"
                    ''KESEM_P = TextBox3.Text
                    ''cr1.SetParameterValue(0, Me.KESEM_P)
                    'cr1.RecordSelectionFormula = cri
                    'cr1.PrintOptions.PrinterName = "LK-TE212"
                    ''cr1.PrintOptions.PrinterName = "LK-TE212"
                    'cr1.PrintToPrinter(1, False, 1, 1)

                Catch ex As Exception
                    MsgBox("No printe")
                End Try
            Catch ex As Exception
                MsgBox("خطأ في إرجاع القيمة راجع مدخلاتك")
            End Try
            Dim s16S As String = "select * from HESAB_AM "
            Dim aadS As New SqlClient.SqlDataAdapter(s16S, cn)
            Dim dssS As New DataSet
            dssS.Clear()
            aadS.Fill(dssS, "HESAB_AM")
            Dim vdS As New DataView(dssS.Tables("HESAB_AM"))
            vdS.RowFilter = "TAS_DATE>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND TAS_DATE<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND TYPE_H=" & "'" & Me.ComboBox11.Text & "'" & "AND NAMEX=" & "'" & Me.ComboBox7.Text & "'" & ""
            Me.DataGridView10.DataMember = ""
            DataGridView10.DataSource = vdS
            If DataGridView10.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView10.Rows.Count - 1
                    tot += DataGridView10.Item(1, i).Value
                Next
                Label18.Text = tot
                Label20.Text = Val(Label19.Text) - Val(Label18.Text)
            End If
        End If
        Call Class4.CONNIC()
    End Sub

    Private Sub DataGridView8_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView8.CellContentClick

    End Sub

    Private Sub ComboBox6_DisplayMemberChanged(sender As Object, e As EventArgs) Handles ComboBox6.DisplayMemberChanged

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sBMA As String = "select * from KASHEF_AM where ESALNO=@ESALNO "
        Dim cmBMA As New SqlClient.SqlCommand(sBMA, cn)
        cmBMA.Parameters.AddWithValue("@ESALNO", CInt(Val(ComboBox6.Text)))
        Dim rdBMA As SqlClient.SqlDataReader
        rdBMA = cmBMA.ExecuteReader
        If rdBMA.Read = True Then
            Label23.Text = rdBMA!AML_NAME
            TextBox37.Text = rdBMA!BAKY
        Else
            Dim sBM As String = "select * from KASHEF where ESALNO=@ESALNO "
            Dim cmBM As New SqlClient.SqlCommand(sBM, cn)
            cmBM.Parameters.AddWithValue("@ESALNO", CInt(Val(ComboBox6.Text)))
            Dim rdBM As SqlClient.SqlDataReader
            rdBM = cmBM.ExecuteReader
            If rdBM.Read = True Then
                Label23.Text = rdBM!EJRAA
                TextBox37.Text = rdBM!BAKY
                'If Label24.Text = 1 Then
                'Else
                '    'Dim sBMAJ As String = "select * from EJRAA where IDJ=@IDJ "
                '    'Dim cmBMAJ As New SqlClient.SqlCommand(sBMAJ, cn)
                '    'cmBMAJ.Parameters.AddWithValue("@IDJ", CInt(Label24.Text))
                '    'Dim rdBMAJ As SqlClient.SqlDataReader
                '    'rdBMAJ = cmBMAJ.ExecuteReader
                '    'If rdBMAJ.Read = True Then
                '    '    Label23.Text = rdBMAJ!EJRAA
                '    '    TextBox37.Text = rdBMA!BAKY
                '    'End If
                'End If
            End If
        End If
        Call Class4.CONNIC()

    End Sub

    Private Sub ComboBox6_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedValueChanged

    End Sub

    Private Sub ComboBox6_TextChanged(sender As Object, e As EventArgs) Handles ComboBox6.TextChanged

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub


    Private Sub DataGridView9_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView9.CellMouseClick
        Call Class1.CONNIC()
        'Select Case e.ColumnIndex
        '    Case Is >= 0
        '        L = CInt(DataGridView9.Item(0, e.RowIndex).Value)
        '        Dim s As String = "select * from AMALEAT_M_VIEW where IDAM=@IDAM "
        '        Using cm As New SqlClient.SqlCommand(s, cn)
        '            cm.Parameters.AddWithValue("@IDAM", CInt(L))
        '            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
        '            If rd.Read = True Then
        '                Label42.Text = CInt(rd!IDA)
        '                Dim sH As String = "select * from amaleat_M where IDAM=@IDAM "
        '                Using cmH As New SqlClient.SqlCommand(sH, cn)
        '                    cmH.Parameters.AddWithValue("@IDAM", CInt(L))
        '                    Dim rdH As SqlClient.SqlDataReader = cmH.ExecuteReader
        '                    If rdH.Read = True Then
        '                        Label42.Text = CInt(rd!IDA)
        '                        ComboBox16.Text = rd!DN
        '                        TextBox62.Text = CDbl(rd!DOCK)
        '                        ComboBox15.Text = rdH!tdocn
        '                        TextBox61.Text = CDbl(rdH!tdock)
        '                        ComboBox21.Text = rdH!mdocn
        '                        TextBox67.Text = CDbl(rdH!mdock)
        '                        ComboBox18.Text = rdH!fdocn
        '                        TextBox65.Text = CDbl(rdH!fdock)
        '                        ComboBox19.Text = rdH!ftdocn
        '                        TextBox64.Text = CDbl(rdH!ftdock)
        '                        TextBox66.Text = CDbl(rdH!tahk)
        '                        ComboBox17.Text = rdH!kabn
        '                        TextBox63.Text = CDbl(rdH!kabk)
        '                        ComboBox14.Text = rdH!cdocn
        '                        TextBox60.Text = CDbl(rdH!cdock)
        '                        ComboBox13.Text = rd!aml_name
        '                        TextBox59.Text = CDbl(rdH!aml_kema)
        '                        TextBox69.Text = CDbl(rdH!C_KEMA)
        '                        TextBox70.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
        '                        GroupBox83.Enabled = True
        '                        GroupBox81.Enabled = True
        '                        GroupBox88.Enabled = True
        '                        GroupBox86.Enabled = True
        '                        GroupBox84.Enabled = True
        '                        GroupBox80.Enabled = True
        '                        GroupBox76.Enabled = True
        '                        GroupBox74.Enabled = True
        '                        GroupBox75.Enabled = True
        '                        GroupBox73.Enabled = True
        '                        GroupBox82.Enabled = True
        '                        GroupBox79.Enabled = True
        '                        'GroupBox87.Enabled = True
        '                        GroupBox85.Enabled = True

        '                    End If
        '                End Using
        '            End If
        '        End Using

        'End Select
        Call Class4.CONNIC()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Call Class1.CONNIC()
        If CheckBox1.Checked = True Then
            Dim sk15 As String
            sk15 = "select * from AMALEAT_M_V "
            Dim adk15 As New SqlClient.SqlDataAdapter(sk15, cn)
            Dim dsk15 As New DataSet
            adk15.Fill(dsk15, "AMALEAT_M_V")
            ComboBox13.DataSource = dsk15.Tables(0)
            ComboBox13.DisplayMember = "AML_NAME"
            ComboBox13.SelectedIndex = -1
            DataGridView9.DataSource = ""
        Else
            Dim sk15 As String
            sk15 = "select * from AMALEAT_M_V where conf='" & False & "' "
            Dim adk15 As New SqlClient.SqlDataAdapter(sk15, cn)
            Dim dsk15 As New DataSet
            adk15.Fill(dsk15, "AMALEAT_M_V")
            ComboBox13.DataSource = dsk15.Tables(0)
            ComboBox13.DisplayMember = "AML_NAME"
            ComboBox13.SelectedIndex = -1
            DataGridView9.DataSource = ""
        End If
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        Call Class1.CONNIC()
        Dim sG As String = "select * from DN where DN=@DN "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@DN", ComboBox2.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        If rdG.Read = True Then
            L = rdG!IDD
        End If

        'If ComboBox2.SelectedIndex = 0 Then
        'Else
        Dim Str As String = "SELECT MIN(TAS_DATE) FROM HESAB_DO "
        Dim cmd As New SqlClient.SqlCommand(Str, cn)
        Try
            DateTimePicker1.Text = cmd.ExecuteScalar
        Catch ex As Exception

        End Try
        Dim s1 As String = "select * from kashef "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "kashef")
        Dim vd As New DataView(dss.Tables("kashef"))
        vd.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND doctorname=" & "'" & L & "'" & "AND CONF=" & "" & True & "" & ""
        Me.DataGridView2.DataMember = ""
        DataGridView2.DataSource = vd
        If DataGridView2.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView2.Rows.Count - 1
                tot += DataGridView2.Item(2, i).Value
            Next
            Label7.Text = tot
        Else
            Label7.Text = 0
        End If
        Dim s11 As String = "select * from AMALEAT_M "
        Dim aad1 As New SqlClient.SqlDataAdapter(s11, cn)
        Dim dss1 As New DataSet
        dss1.Clear()
        aad1.Fill(dss1, "AMALEAT_M")
        Dim vd1 As New DataView(dss1.Tables("AMALEAT_M"))
        If L = 0 Then
            vd1.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND TAHN=" & "'" & "قيمة التحاليل" & "'" & "AND CONF=" & "" & True & "" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd1
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(12, i).Value
                Next
                Label22.Text = tot
            Else
                Label22.Text = 0
            End If
        Else
            vd1.RowFilter = "DATEx>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND DATEx<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND CDOCN=" & "'" & L & "'" & "AND CONF=" & "" & True & "" & ""
            Me.DataGridView11.DataMember = ""
            DataGridView11.DataSource = vd1
            If DataGridView11.Rows.Count <> 0 Then
                Dim xc As Integer = 0
                Dim tot As Integer = 0
                Dim i As Integer = 0
                For i = 0 To DataGridView11.Rows.Count - 1
                    tot += DataGridView11.Item(16, i).Value
                Next
                Label22.Text = tot
            Else
                Label22.Text = 0
            End If
        End If

        'If DataGridView2.Rows.Count <> 0 Then
        '    Dim xc As Integer = 0
        '    Dim tot As Integer = 0
        '    Dim i As Integer = 0
        '    For i = 0 To DataGridView2.Rows.Count - 1
        '        tot += DataGridView2.Item(2, i).Value
        '    Next
        '    Label6.Text = tot
        'End If
        If DataGridView2.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView2.Rows.Count - 1
                tot += 1
            Next
            Label5.Text = tot
        Else
            Label5.Text = 0
        End If
        Dim s16S As String = "select * from HESAB_DO "
        Dim aadS As New SqlClient.SqlDataAdapter(s16S, cn)
        Dim dssS As New DataSet
        dssS.Clear()
        aadS.Fill(dssS, "HESAB_DO")
        Dim vdS As New DataView(dssS.Tables("HESAB_DO"))
        vdS.RowFilter = "TAS_DATE>=" & "'" & Me.DateTimePicker1.Value.Date & "'" & "AND TAS_DATE<=" & "'" & Me.DateTimePicker2.Value.Date & "'" & "AND doctorname=" & "'" & Me.ComboBox2.Text & "'" & ""
        Me.DataGridView3.DataMember = ""
        DataGridView3.DataSource = vdS
        If DataGridView3.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim i As Integer = 0
            For i = 0 To DataGridView3.Rows.Count - 1
                tot += DataGridView3.Item(1, i).Value
            Next
            Label9.Text = tot
        Else
            Label9.Text = 0
        End If
        If Label9.Text = "" Then
            Label9.Text = 0
        End If
        Label6.Text = Val(Label22.Text) + Val(Label7.Text) - Val(Label9.Text)
        Dim s15 As String = "select * from kashef "
        Dim aad5 As New SqlClient.SqlDataAdapter(s15, cn)
        Dim dss5 As New DataSet
        dss5.Clear()
        aad5.Fill(dss5, "kashef")
        Dim vd5 As New DataView(dss5.Tables("kashef"))
        vd5.RowFilter = "Ejraa=" & "'" & Label12.Text & "'" & "AND KEMA=" & "" & Label16.Text & "" & "AND Doctorname=" & "'" & ComboBox2.Text & "'" & "AND CONF=" & "" & True & "" & ""
        Me.DataGridView2.DataMember = ""
        DataGridView2.DataSource = vd5
        If DataGridView2.Rows.Count <> 0 Then
            Dim xc As Integer = 0
            Dim tot As Integer = 0
            Dim tot0 As Integer = 0
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To DataGridView2.Rows.Count - 1
                tot += DataGridView2.Item(3, i).Value
            Next
            For j = 0 To DataGridView2.Rows.Count - 1
                tot0 += DataGridView2.Item(4, j).Value
            Next
            TextBox25.Text = tot
            TextBox26.Text = tot0
            If bk = "اسنان" Then
                GroupBox24.Visible = True
                GroupBox25.Visible = True
                GroupBox26.Visible = True
                Button11.Visible = True
            Else
                GroupBox24.Visible = False
                GroupBox25.Visible = False
                GroupBox26.Visible = False
                Button11.Visible = False
            End If
        Else
            TextBox25.Text = 0
            TextBox26.Text = 0
            GroupBox24.Visible = False
            GroupBox25.Visible = False
            GroupBox26.Visible = False
            Button11.Visible = False

        End If
        TextBox5.Text = ""
        TextBox5.Focus()
        Call Class4.CONNIC()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        dgx = TextBox43.Text
        fnumberx = TextBox41.Text
        kesemx = Label32.Text
        Dim f As New sanad
        f.ShowDialog()
        Me.Show()
        TextBox44.Text = dgx
        Label52.Text = Val(Label52.Text) + Val(TextBox44.Text)
        Me.Label53.Text = CDbl(Val(Label51.Text) - Val(Label52.Text))
        'Call Class1.CONNIC()
        'Dim ss2 As String = "select * from EYWAA where nofatora=@nofatora"
        'Dim cms2 As New SqlClient.SqlCommand(ss2, cn)
        'cms2.Parameters.AddWithValue("@nofatora", Me.TextBox43.Text)
        'Dim rds2 As SqlClient.SqlDataReader = cms2.ExecuteReader
        'If rds2.Read = True Then
        '    Me.Label6.Text = rds2!rasfatora
        '    Me.Label7.Text = rds2!madfoo
        '    'TextBox22.Text = rds2!id
        '    Label7.Text = Label52.Text + Label7.Text
        'End If
        'Me.TextBox10.Text = (Val(ComboBox9.Text) * Val(Me.ComboBox1.Text)) + Val(TextBox9.Text)
        'Me.TextBox7.Text = Val(TextBox9.Text) - s3r1 + (Val(ComboBox9.Text) * Val(Me.ComboBox1.Text))
        'Me.TextBox11.Text = Val(Me.TextBox19.Text) + Val(Me.TextBox9.Text)

        'Dim sskh As String = "select * from khad where nofatora=kh"
        'Dim cmkh As New OleDb.OleDbCommand(sskh, cn)
        'cmkh.Parameters.Add("kh", TextBox1.Text)
        'Dim rdkh As OleDb.OleDbDataReader = cmkh.ExecuteReader
        'If rdkh.Read = True Then
        '    jh = 1
        'Else
        '    jh = 0
        '    '    Me.TextBox2.Text = rdkh!talabdate
        '    '    Me.TextBox3.Text = rdkh!talabname
        '    '    Me.TextBox4.Text = rdkh!talabs3r
        '    'Else
        '    '    MsgBox("")
        'End If
        'Dim ss3r As String = "select * from s3rtalab where nofatora=s3r"
        'Dim cms3r As New OleDb.OleDbCommand(ss3r, cn)
        'cms3r.Parameters.Add("s3r", TextBox1.Text)
        'Dim rds3r As OleDb.OleDbDataReader = cms3r.ExecuteReader
        'If rds3r.Read = True Then
        '    TextBox3.Text = rds3r!sumمنtalabs3r
        'End If
        Call Class1.CONNIC()
        Dim sm2 As String = "update EYWAA set dayz=@dayz,rasfatora=@rasfatora,madfoo=@madfoo,baky=@baky where nofatora=@nofatora"
        Dim cm2 As New SqlClient.SqlCommand(sm2, cn)
        cm2.Parameters.AddWithValue("@dayz", Me.Label49.Text)
        cm2.Parameters.AddWithValue("@rasfatora", Me.Label51.Text)
        cm2.Parameters.AddWithValue("@madfoo", Me.Label52.Text)
        cm2.Parameters.AddWithValue("@baky", Me.Label53.Text)
        cm2.Parameters.AddWithValue("@nofatora", Me.TextBox43.Text)
        Try
            cm2.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("EYWAA")
        End Try
        '*************************************************
        'Dim s5550 As String = "insert into jeha(datesadad,sadad,sakno,jehaname,user_name,idm2,nofatora) values(xcx13,xcx14,xcx15,xcx11,xcx16,xcx17,xcx18) "
        'Dim cm5550 As New OleDb.OleDbCommand(s5550, cn)
        '' cm5550.Parameters.Add("xcx12", TextBox1.Text)
        'cm5550.Parameters.Add("xcx13", Date.Now.Date)
        'cm5550.Parameters.Add("xcx14", TextBox20.Text)
        'cm5550.Parameters.Add("xcx15", "none")
        'cm5550.Parameters.Add("xcx11", ComboBox3.Text)
        'cm5550.Parameters.Add("xcx16", user)
        'cm5550.Parameters.Add("xcx17", TextBox22.Text)
        'cm5550.Parameters.Add("xcx18", TextBox1.Text)
        'Try
        '    cm5550.ExecuteNonQuery()
        'Catch ex As Exception

        'End Try
        '*********************************************************
        TextBox44.Text = ""
        Call Class4.CONNIC()

    End Sub

    Private Sub TextBox41_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox41.KeyPress
        Call Class1.CONNIC()
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            Dim s5 As String = "select * from main where FNUMBER=@xx1"
            Using cm5 As New SqlClient.SqlCommand(s5, cn)
                cm5.Parameters.AddWithValue("@xx1", Trim(TextBox41.Text))
                Dim rd5 As SqlClient.SqlDataReader = cm5.ExecuteReader
                If rd5.Read = True Then
                    Me.TextBox41.Text = rd5!fnumber
                    Me.Label29.Text = Trim(rd5!namex)
                    If IsDBNull(rd5!sex) = True Then
                        Me.Label31.Text = "لايوجد"
                    Else
                        Me.Label31.Text = Trim(rd5!SEX)
                    End If
                    If String.IsNullOrEmpty(rd5!GENDER) Then
                        Me.Label26.Text = "لايوجد"
                    Else
                        Me.Label26.Text = Trim(rd5!GENDER)
                    End If

                    Me.Label30.Text = Trim(rd5!AGE)
                    'Me.Label26.Text = Trim(rd5!GENDER)
                    rd5.Close()
                    Dim skk As String = "select * from EYWAA where fnumber=@fnumber and MOGHADRA=@MOGHADRA "
                    Using cmkk As New SqlClient.SqlCommand(skk, cn)
                        cmkk.Parameters.AddWithValue("@fnumber", Trim(TextBox41.Text))
                        cmkk.Parameters.AddWithValue("@MOGHADRA", False)
                        Using rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
                            If rdkk.Read = True Then
                                TextBox43.Text = CInt(rdkk!NOFATORA)
                                Label32.Text = CInt(rdkk!KESEM)
                                Label34.Text = CInt(rdkk!EYWAAT)
                                Dim s5Y As String = "select * from KESEM where IDK=@IDK"
                                Using cm5Y As New SqlClient.SqlCommand(s5Y, cn)
                                    cm5Y.Parameters.AddWithValue("@IDK", CInt(Label32.Text))
                                    Dim rd5Y As SqlClient.SqlDataReader = cm5Y.ExecuteReader
                                    If rd5Y.Read = True Then
                                        Label32.Text = rd5Y!KESEM
                                    End If
                                End Using
                                Dim s5YT As String = "select * from TYPEEYWAA where IDEY=@IDEY"
                                Using cm5YT As New SqlClient.SqlCommand(s5YT, cn)
                                    cm5YT.Parameters.AddWithValue("@IDEY", CInt(Label34.Text))
                                    Dim rd5YT As SqlClient.SqlDataReader = cm5YT.ExecuteReader
                                    If rd5YT.Read = True Then
                                        Label34.Text = rd5YT!EYWAATYPE
                                    End If
                                End Using

                                Label41.Text = CInt(rdkk!NOSAREER)
                                Label36.Text = Format(CDate(rdkk!DATEEYWAA), "yyyy/MM/dd")
                                DateTimePicker6.Text = Label36.Text
                                Label37.Text = Format(CDate(rdkk!TIMEEYWAA), "hh:mm:ss")

                                Label48.Text = CDbl(rdkk!SE3REYWAA)
                                Label49.Text = CInt(rdkk!DAYZ)
                                DateTimePicker8.Value = Format(Date.Today.Date, "yyyy/MM/dd")
                                Label38.Text = Format(Date.Today.Date, "yyyy/MM/dd")
                                Label39.Text = Format(Now, "hh:mm:ss")
                                Me.Label49.Text = Math.Abs(DateDiff(DateInterval.Day, CDate(Me.DateTimePicker6.Value.Date), CDate(Date.Today.Date)))
                                'Me.DateTimePicker4.Text = Format(Me.DateTimePicker3.Text, "HH:mm")
                                'Me.ComboBox7.Text = Math.Ceiling(Val(Me.TextBox5.Text))
                                If Me.Label49.Text = 0 Then
                                    Me.Label49.Text = 0
                                End If
                                If Me.DateTimePicker6.Value = Date.Today.Date Then
                                    Me.Label49.Text = Math.Ceiling(Val(Me.Label49.Text)) + 1
                                Else
                                    If DateTimePicker6.Value <= Date.Today.Date Then
                                        Me.Label49.Text = Math.Ceiling(Val(Me.Label49.Text))
                                    Else
                                        Me.Label49.Text = Math.Ceiling(Val(Me.Label49.Text)) + 1
                                    End If
                                End If

                                Me.TextBox39.Text = 0
                                Call Class1.CONNIC()
                                Dim skd As String = "select * from KASHEF where FNUMBER=@FNUMBER"
                                Dim cmkd As New SqlClient.SqlCommand(skd, cn)
                                cmkd.Parameters.AddWithValue("@FNUMBER", CInt(Me.TextBox41.Text))
                                Dim rdkd11 As SqlClient.SqlDataReader = cmkd.ExecuteReader
                                While rdkd11.Read = True
                                    Me.TextBox39.Text = Val(Me.TextBox39.Text) + rdkd11!KEMAT
                                    Me.Label50.Text = Val(Me.TextBox39.Text)
                                End While
                                Me.Label51.Text = Val(Label48.Text) * Val(Label49.Text) + Val(Label50.Text)
                                'Me.TextBox16.Text = Val(TextBox17.Text) - Val(ComboBox7.Text * ComboBox9.Text)
                                Dim s5E As String = "select * from EYWAA where FNUMBER=@FNUMBER AND MOGHADRA=@MOGHADRA"
                                Using cm5E As New SqlClient.SqlCommand(s5E, cn)
                                    cm5E.Parameters.AddWithValue("@FNUMBER", Trim(TextBox41.Text))
                                    cm5E.Parameters.AddWithValue("@MOGHADRA", False)
                                    Dim rd5E As SqlClient.SqlDataReader = cm5E.ExecuteReader
                                    If rd5E.Read = True Then
                                        Me.Label52.Text = CDbl(rd5E!MADFOO)
                                        Me.Label53.Text = CDbl(Val(Label51.Text) - Val(Label52.Text))
                                    End If
                                End Using

                                TextBox41.Focus()

                            Else
                                MsgBox("هذا النزيل تمت مغادرته")
                                Me.Label29.Text = ""
                                Me.Label31.Text = ""
                                Me.Label30.Text = ""
                                Me.Label26.Text = ""
                                TextBox41.Focus()

                                'Timer2.Stop()
                                'Label21.Text = ""
                                'Label21.BackColor = Color.Transparent
                            End If
                            rdkk.Close()
                        End Using
                    End Using
                    Button17.Enabled = True

                Else
                    'Me.TextBox2.Text = ""
                    'Timer2.Stop()
                    'Label21.Text = ""
                    'Label21.BackColor = Color.Transparent
                End If
                rd5.Close()
            End Using
        End If
        Call Class4.CONNIC()

    End Sub

    Private Sub TextBox41_TextChanged(sender As Object, e As EventArgs) Handles TextBox41.TextChanged



    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox41.Text = "" Then
            Call Class1.CONNIC()
            Dim skk As String = "select * from EYWAA where NOFATORA=@NOFATORA and MOGHADRA=@MOGHADRA "
            Using cmkk As New SqlClient.SqlCommand(skk, cn)
                cmkk.Parameters.AddWithValue("@NOFATORA", Trim(TextBox43.Text))
                cmkk.Parameters.AddWithValue("@MOGHADRA", False)
                Using rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
                    If rdkk.Read = True Then
                        TextBox41.Text = CInt(rdkk!FNUMBER)
                        Label32.Text = CInt(rdkk!KESEM)
                        Label34.Text = CInt(rdkk!EYWAAT)
                        Dim s5Y As String = "select * from KESEM where IDK=@IDK"
                        Using cm5Y As New SqlClient.SqlCommand(s5Y, cn)
                            cm5Y.Parameters.AddWithValue("@IDK", CInt(Label32.Text))
                            Dim rd5Y As SqlClient.SqlDataReader = cm5Y.ExecuteReader
                            If rd5Y.Read = True Then
                                Label32.Text = rd5Y!KESEM
                            End If
                        End Using
                        Dim s5YT As String = "select * from TYPEEYWAA where IDEY=@IDEY"
                        Using cm5YT As New SqlClient.SqlCommand(s5YT, cn)
                            cm5YT.Parameters.AddWithValue("@IDEY", CInt(Label34.Text))
                            Dim rd5YT As SqlClient.SqlDataReader = cm5YT.ExecuteReader
                            If rd5YT.Read = True Then
                                Label34.Text = rd5YT!EYWAATYPE
                            End If
                        End Using

                        Label41.Text = CInt(rdkk!NOSAREER)
                        Label36.Text = CDate(rdkk!DATEEYWAA)
                        DateTimePicker6.Text = Label36.Text
                        Label37.Text = CDate(rdkk!TIMEEYWAA)

                        Label48.Text = CDbl(rdkk!SE3REYWAA)
                        Label49.Text = CInt(rdkk!DAYZ)
                        Label38.Text = Format(Date.Today.Date = "dd/MM/yyyy")
                        Label39.Text = TimeString
                        rdkk.Close()

                        Dim s5 As String = "select * from main where FNUMBER=@xx1"
                        Using cm5 As New SqlClient.SqlCommand(s5, cn)
                            cm5.Parameters.AddWithValue("@xx1", Trim(TextBox41.Text))
                            Dim rd5 As SqlClient.SqlDataReader = cm5.ExecuteReader
                            If rd5.Read = True Then
                                Me.TextBox41.Text = rd5!fnumber
                                Me.Label29.Text = Trim(rd5!namex)
                                Me.Label31.Text = Trim(rd5!SEX)
                                Me.Label30.Text = CInt(rd5!AGE)
                                Me.Label26.Text = Trim(rd5!GENDER)
                                rd5.Close()

                            Else
                                'Timer2.Stop()
                                'Label21.Text = ""
                                'Label21.BackColor = Color.Transparent
                            End If
                        End Using
                        'End Using

                    Else
                        Me.TextBox2.Text = ""
                        'Timer2.Stop()
                        'Label21.Text = ""
                        'Label21.BackColor = Color.Transparent
                    End If
                    'rd5.Close()
                End Using
            End Using
            Me.Label49.Text = Math.Abs(DateDiff(DateInterval.Day, CDate(Me.DateTimePicker6.Value.Date), CDate(Date.Today.Date)))
            'Me.DateTimePicker4.Text = Format(Me.DateTimePicker3.Text, "HH:mm")
            'Me.ComboBox7.Text = Math.Ceiling(Val(Me.TextBox5.Text))
            If Me.Label49.Text = 0 Then
                Me.Label49.Text = 0
            End If
            If Me.DateTimePicker6.Value = Date.Today.Date Then
                Me.Label49.Text = Math.Ceiling(Val(Me.Label49.Text)) + 1
            Else
                If DateTimePicker6.Value <= Date.Today.Date Then
                    Me.Label49.Text = Math.Ceiling(Val(Me.Label49.Text))
                Else
                    Me.Label49.Text = Math.Ceiling(Val(Me.Label49.Text)) + 1
                End If
            End If

            Me.TextBox39.Text = 0
            Call Class1.CONNIC()
            Dim skd As String = "select * from KASHEF where FNUMBER=@FNUMBER"
            Dim cmkd As New SqlClient.SqlCommand(skd, cn)
            cmkd.Parameters.AddWithValue("@FNUMBER", CInt(Me.TextBox41.Text))
            Dim rdkd11 As SqlClient.SqlDataReader = cmkd.ExecuteReader
            While rdkd11.Read = True
                Me.TextBox39.Text = Val(Me.TextBox39.Text) + rdkd11!KEMAT
                Me.Label50.Text = Val(Me.TextBox39.Text)
            End While
            Me.Label51.Text = Val(Label48.Text) * Val(Label49.Text) + Val(Label50.Text)
            'Me.TextBox16.Text = Val(TextBox17.Text) - Val(ComboBox7.Text * ComboBox9.Text)
            Dim s5E As String = "select * from EYWAA where FNUMBER=@FNUMBER AND MOGHADRA=@MOGHADRA"
            Using cm5E As New SqlClient.SqlCommand(s5E, cn)
                cm5E.Parameters.AddWithValue("@FNUMBER", Trim(TextBox41.Text))
                cm5E.Parameters.AddWithValue("@MOGHADRA", False)
                Dim rd5E As SqlClient.SqlDataReader = cm5E.ExecuteReader
                If rd5E.Read = True Then
                    Me.Label52.Text = CDbl(rd5E!MADFOO)
                    Me.Label53.Text = CDbl(Val(Label51.Text) - Val(Label52.Text))
                End If
            End Using
            TextBox43.Focus()
            Call Class4.CONNIC()
        Else
            Call Class1.CONNIC()
            Dim s5 As String = "select * from main where FNUMBER=@xx1"
            Using cm5 As New SqlClient.SqlCommand(s5, cn)
                cm5.Parameters.AddWithValue("@xx1", Trim(TextBox41.Text))
                Dim rd5 As SqlClient.SqlDataReader = cm5.ExecuteReader
                If rd5.Read = True Then
                    Me.TextBox41.Text = rd5!fnumber
                    Me.Label29.Text = Trim(rd5!namex)
                    Me.Label31.Text = Trim(rd5!SEX)
                    Me.Label30.Text = CInt(rd5!AGE)
                    Me.Label26.Text = Trim(rd5!GENDER)
                    rd5.Close()
                    Dim skk As String = "select * from EYWAA where fnumber=@fnumber and MOGHADRA=@MOGHADRA "
                    Using cmkk As New SqlClient.SqlCommand(skk, cn)
                        cmkk.Parameters.AddWithValue("@fnumber", Trim(TextBox41.Text))
                        cmkk.Parameters.AddWithValue("@MOGHADRA", False)
                        Using rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
                            If rdkk.Read = True Then
                                Label32.Text = CInt(rdkk!KESEM)
                                Label34.Text = CInt(rdkk!EYWAAT)
                                Dim s5Y As String = "select * from KESEM where IDK=@IDK"
                                Using cm5Y As New SqlClient.SqlCommand(s5Y, cn)
                                    cm5Y.Parameters.AddWithValue("@IDK", CInt(Label32.Text))
                                    Dim rd5Y As SqlClient.SqlDataReader = cm5Y.ExecuteReader
                                    If rd5Y.Read = True Then
                                        Label32.Text = rd5Y!KESEM
                                    End If
                                End Using
                                Dim s5YT As String = "select * from TYPEEYWAA where IDEY=@IDEY"
                                Using cm5YT As New SqlClient.SqlCommand(s5YT, cn)
                                    cm5YT.Parameters.AddWithValue("@IDEY", CInt(Label34.Text))
                                    Dim rd5YT As SqlClient.SqlDataReader = cm5YT.ExecuteReader
                                    If rd5YT.Read = True Then
                                        Label34.Text = rd5YT!EYWAATYPE
                                    End If
                                End Using

                                Label41.Text = CInt(rdkk!NOSAREER)
                                Label36.Text = CDate(rdkk!DATEEYWAA)
                                Label37.Text = CDate(rdkk!TIMEEYWAA)

                                Label48.Text = CDbl(rdkk!SE3REYWAA)
                                Label49.Text = CInt(rdkk!DAYZ)
                                Label38.Text = Format(Date.Today.Date = "dd/MM/yyyy")
                                Label39.Text = TimeString
                            Else
                                'Timer2.Stop()
                                'Label21.Text = ""
                                'Label21.BackColor = Color.Transparent
                            End If
                            rdkk.Close()
                        End Using
                    End Using

                Else
                    Me.TextBox2.Text = ""
                    'Timer2.Stop()
                    'Label21.Text = ""
                    'Label21.BackColor = Color.Transparent
                End If
                rd5.Close()
            End Using
            Me.Label49.Text = Math.Abs(DateDiff(DateInterval.Day, CDate(Me.DateTimePicker6.Value.Date), CDate(Date.Today.Date)))
            'Me.DateTimePicker4.Text = Format(Me.DateTimePicker3.Text, "HH:mm")
            'Me.ComboBox7.Text = Math.Ceiling(Val(Me.TextBox5.Text))
            If Me.Label49.Text = 0 Then
                Me.Label49.Text = 0
            End If
            If Me.DateTimePicker6.Value = Date.Today.Date Then
                Me.Label49.Text = Math.Ceiling(Val(Me.Label49.Text)) + 1
            Else
                If DateTimePicker6.Value <= Date.Today.Date Then
                    Me.Label49.Text = Math.Ceiling(Val(Me.Label49.Text))
                Else
                    Me.Label49.Text = Math.Ceiling(Val(Me.Label49.Text)) + 1
                End If
            End If

            Me.TextBox39.Text = 0
            Call Class1.CONNIC()
            Dim skd As String = "select * from KASHEF where FNUMBER=@FNUMBER"
            Dim cmkd As New SqlClient.SqlCommand(skd, cn)
            cmkd.Parameters.AddWithValue("@FNUMBER", CInt(Me.TextBox41.Text))
            Dim rdkd11 As SqlClient.SqlDataReader = cmkd.ExecuteReader
            While rdkd11.Read = True
                Me.TextBox39.Text = Val(Me.TextBox39.Text) + rdkd11!KEMAT
                Me.Label50.Text = Val(Me.TextBox39.Text)
            End While
            Me.Label51.Text = Val(Label48.Text) * Val(Label49.Text) + Val(Label50.Text)
            'Me.TextBox16.Text = Val(TextBox17.Text) - Val(ComboBox7.Text * ComboBox9.Text)
            Dim s5E As String = "select * from EYWAA where FNUMBER=@FNUMBER AND MOGHADRA=@MOGHADRA"
            Using cm5E As New SqlClient.SqlCommand(s5E, cn)
                cm5E.Parameters.AddWithValue("@FNUMBER", Trim(TextBox41.Text))
                cm5E.Parameters.AddWithValue("@MOGHADRA", False)
                Dim rd5E As SqlClient.SqlDataReader = cm5E.ExecuteReader
                If rd5E.Read = True Then
                    Me.Label52.Text = CDbl(rd5E!MADFOO)
                    Me.Label53.Text = CDbl(Val(Label51.Text) - Val(Label52.Text))
                End If
            End Using
            TextBox41.Focus()
            Call Class4.CONNIC()
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If CheckBox2.Checked = True Then
            If Val(Label53.Text) <> 0 Then
                If MsgBox("هل ترغب في عمل تخفيض لهذا النزيل؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    dgxx = TextBox19.Text
                    Dim f As New Discount
                    f.ShowDialog()
                    Label52.Text = Val(Label52.Text) + Val(dgxj)
                    Label53.Text = Val(Label51.Text) - Val(Label52.Text)
                End If
            End If
            
        End If
        Call Class1.CONNIC()
        Dim sm2 As String = "update EYWAA set dayz=@dayz,rasfatora=@rasfatora,madfoo=@madfoo,baky=@baky,Discount=@Discount,moghadra=@moghadra,datemoghadra=@datemoghadra,TIMEmoghadra=@TIMEmoghadra where nofatora=@nofatora"
        Dim cm2 As New SqlClient.SqlCommand(sm2, cn)
        cm2.Parameters.AddWithValue("@dayz", CInt(Me.Label49.Text))
        cm2.Parameters.AddWithValue("@rasfatora", CDbl(Me.Label51.Text))
        cm2.Parameters.AddWithValue("@madfoo", CDbl(Me.Label52.Text))
        cm2.Parameters.AddWithValue("@baky", CDbl(Me.Label53.Text))
        cm2.Parameters.AddWithValue("@Discount", CDbl(dgxj))
        cm2.Parameters.AddWithValue("@moghadra", True)
        cm2.Parameters.AddWithValue("@datemoghadra", Date.Today.Date)
        cm2.Parameters.AddWithValue("@TIMEmoghadra", DateTime.Now.TimeOfDay)
        cm2.Parameters.AddWithValue("@nofatora", Me.TextBox43.Text)
        '*************************************************************************************************************************************
        '**********************************************************************************
        Call Class1.CONNIC()
        Dim sD As String = "delete from FATMOGH"
        Dim cmD As New SqlClient.SqlCommand(sD, cn)
        cmD.ExecuteNonQuery()
        '*********************************************
        Label27.Text = "إيواء"
        Dim i As Integer
        For i = 1 To CInt(Label49.Text)
            Dim mydate As Date
            mydate = Me.DateTimePicker6.Value.Date
            DATEXX = mydate.AddDays(i - 1)
            ' Me.DateTimePicker5.Value = Format(Me.MaskedTextBox6.Text + 1, "dd/MM/yyyy")
            Call Class1.CONNIC()
            Dim sf As String = "insert into FATMOGH(NOFATORA,ALBIAN,DATEX,S3R) values(@NOFATORA,@ALBIAN,@DATEX,@S3R)"
            Dim cmmf As New SqlClient.SqlCommand(sf, cn)
            cmmf.Parameters.AddWithValue("@NOFATORA", Me.TextBox43.Text)
            cmmf.Parameters.AddWithValue("@ALBIAN", Trim(Me.Label27.Text))
            cmmf.Parameters.AddWithValue("@DATEX", CDate(DATEXX))
            cmmf.Parameters.AddWithValue("@S3R", CDbl(Me.Label48.Text))
            Try
                cmmf.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("error")
            End Try
        Next
        '************************************************
        Call Class1.CONNIC()
        Dim sskh1 As String = "select * from KASHEF where nofatora=@nofatora"
        Dim cmkh1 As New SqlClient.SqlCommand(sskh1, cn)
        cmkh1.Parameters.AddWithValue("@nofatora", TextBox43.Text)
        Dim rdkh1 As SqlClient.SqlDataReader = cmkh1.ExecuteReader
        Do While rdkh1.Read = True
            DATEXX = CDate(rdkh1!DATEX)
            ALBIAN = Trim(rdkh1!EJRAA)
            S3R = CDbl(rdkh1!KEMAT)
            recno = CInt(rdkh1!ESALNO)
            Call Class1.CONNIC()
            Dim SSKH2 As String = "INSERT INTO FATMOGH(NOFATORA,ALBIAN,DATEX,S3R,recno) VALUES(@NOFATORA,@ALBIAN,@DATEX,@S3R,@recno)"
            Dim CMKH2 As New SqlClient.SqlCommand(SSKH2, cn)
            CMKH2.Parameters.AddWithValue("@NOFATORA", TextBox43.Text)
            CMKH2.Parameters.AddWithValue("@ALBIAN", ALBIAN)
            CMKH2.Parameters.AddWithValue("@DATEX", DATEXX)
            CMKH2.Parameters.AddWithValue("@S3R", S3R)
            CMKH2.Parameters.AddWithValue("@recno", recno)
            CMKH2.ExecuteNonQuery()
        Loop

        '***********************************************************************************************************************************************
        If MsgBox("هل تريد مغادرة النزيل ؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'Try
            If Val(Label53.Text) > 0 Then
                MsgBox("لا يمكن مغادرة النزيل حتي يتم السداد")
                Exit Sub
            End If
            Call Class1.CONNIC()
            If Val(Label53.Text) < 0 Then
                Dim s204 As String = "INSERT INTO sadad(nofatora,sadad,DATEXX,NOTES,SANO,MASRAF,ch,esalno) VALUES(@nofatora,@sadad,@DATEXX,@NOTES,@SANO,@MASRAF,@ch,@esalno)"
                Dim cm204 As New SqlClient.SqlCommand(s204, cn)
                cm204.Parameters.AddWithValue("@nofatora", Me.TextBox43.Text)
                cm204.Parameters.AddWithValue("@sadad", CDbl(Me.Label53.Text))
                cm204.Parameters.AddWithValue("@DATEXX", Date.Today.Date)
                cm204.Parameters.AddWithValue("@NOTES", "قيمة مردوده")
                cm204.Parameters.AddWithValue("@SANO", "لايوجد")
                cm204.Parameters.AddWithValue("@MASRAF", "لايوجد")
                cm204.Parameters.AddWithValue("@ch", "1")
                cm204.Parameters.AddWithValue("@esalno", 0)
                Try
                    cm204.ExecuteNonQuery()
                    If Val(Label53.Text) < 0 Then
                        Me.Label53.Text = CDbl(0)
                    End If
                Catch ex As Exception

                End Try
            End If

            Dim ssm2 As String = "select * from sadad where nofatora=@nofatora"
            Dim cmm2 As New SqlClient.SqlCommand(ssm2, cn)
            cmm2.Parameters.AddWithValue("@nofatora", TextBox43.Text)
            Dim rdm2 As SqlClient.SqlDataReader = cmm2.ExecuteReader
            Do While rdm2.Read = True
                DATEXX = rdm2!DATEXX
                recno = rdm2!Esalno
                credit = rdm2!SADAD
                Dim SSKH2 As String = "INSERT INTO FATMOGH(NOFATORA,ALBIAN,DATEX,credit,recno) VALUES(@NOFATORA,@ALBIAN,@DATEX,@credit,@recno)"
                Dim CMKH2 As New SqlClient.SqlCommand(SSKH2, cn)
                CMKH2.Parameters.AddWithValue("@NOFATORA", TextBox43.Text)
                If credit > 0 Then
                    CMKH2.Parameters.AddWithValue("@ALBIAN", "مدفوع")
                Else
                    CMKH2.Parameters.AddWithValue("@ALBIAN", "قيمة مردودة")
                End If
                CMKH2.Parameters.AddWithValue("@DATEX", DATEXX)
                CMKH2.Parameters.AddWithValue("@credit", credit)
                CMKH2.Parameters.AddWithValue("@recno", recno)
                CMKH2.ExecuteNonQuery()
            Loop
            cm2.ExecuteNonQuery()
            MsgBox("تم مغادرة النزيل")
            Call Class1.CONNIC()
            Dim ssm22 As String = "select * from EYWAA where nofatora=@nofatora"
            Dim cmm22 As New SqlClient.SqlCommand(ssm22, cn)
            cmm22.Parameters.AddWithValue("@nofatora", TextBox43.Text)
            Dim rdm22 As SqlClient.SqlDataReader = cmm22.ExecuteReader
            If rdm22.Read = True Then
                DISCOUNTX = rdm22!Discount
                If DISCOUNTX <> 0 Then
                    Call Class1.CONNIC()
                    Dim SSKH22 As String = "INSERT INTO FATMOGH(NOFATORA,ALBIAN,DATEX,credit) VALUES(@NOFATORA,@ALBIAN,@DATEX,@credit)"
                    Dim CMKH22 As New SqlClient.SqlCommand(SSKH22, cn)
                    CMKH22.Parameters.AddWithValue("@NOFATORA", TextBox43.Text)
                    CMKH22.Parameters.AddWithValue("@ALBIAN", "تخفيض/Discount")
                    CMKH22.Parameters.AddWithValue("@DATEX", Date.Now.Date)
                    CMKH22.Parameters.AddWithValue("@credit", DISCOUNTX)
                    'Try
                    CMKH22.ExecuteNonQuery()
                    'Catch ex As Exception
                    '    MsgBox("DISCOUNT")
                    'End Try
                End If
            End If
            'If Val(Label53.Text) < 0 Then
            '    Dim s204 As String = "INSERT INTO sadad(nofatora,sadad,DATEXX,NOTES,SANO,MASRAF,ch,esalno) VALUES(@nofatora,@sadad,@DATEXX,@NOTES,@SANO,@MASRAF,@ch,@esalno)"
            '    Dim cm204 As New SqlClient.SqlCommand(s204, cn)
            '    cm204.Parameters.AddWithValue("@nofatora", Me.TextBox43.Text)
            '    cm204.Parameters.AddWithValue("@sadad", CDbl(Me.Label53.Text))
            '    cm204.Parameters.AddWithValue("@DATEXX", Date.Today.Date)
            '    cm204.Parameters.AddWithValue("@NOTES", "قيمة مردوده")
            '    cm204.Parameters.AddWithValue("@SANO", "لايوجد")
            '    cm204.Parameters.AddWithValue("@MASRAF", "لايوجد")
            '    cm204.Parameters.AddWithValue("@ch", "1")
            '    cm204.Parameters.AddWithValue("@esalno", 0)
            '    'Try
            '    cm204.ExecuteNonQuery()
            '    'Catch ex As Exception

            '    'End Try
            '    Call Class1.CONNIC()
            '    Dim SSKH22 As String = "INSERT INTO FATMOGH(NOFATORA,ALBIAN,DATEX,S3R) VALUES(@NOFATORA,@ALBIAN,@DATEX,@S3R)"
            '    Dim CMKH22 As New SqlClient.SqlCommand(SSKH22, cn)
            '    CMKH22.Parameters.AddWithValue("@NOFATORA", TextBox43.Text)
            '    CMKH22.Parameters.AddWithValue("@ALBIAN", "المردود")
            '    CMKH22.Parameters.AddWithValue("@DATEX", Date.Now.Date)
            '    CMKH22.Parameters.AddWithValue("@S3R", Abs(CDbl(Label53.Text)))
            '    'Try
            '    CMKH22.ExecuteNonQuery()
            '    'Catch ex As Exception
            '    '    MsgBox("DISCOUNT")
            '    'End Try
            'End If
            'End If

            'TextBox19.Text = Val(TextBox17.Text) - Val(TextBox18.Text)
            Dim sm1 As String = "select * from MAIN where FNUMBER=@FNUMBER"
            Dim cm1 As New SqlClient.SqlCommand(sm1, cn)
            cm1.Parameters.AddWithValue("@FNUMBER", TextBox41.Text)
            Dim rdm1 As SqlClient.SqlDataReader = cm1.ExecuteReader
            If rdm1.Read = True Then
                nam = rdm1!nameX
                jehan = "نقدا"
                Dim sm1E As String = "select * from EYWAA where NOFATORA=@NOFATORA"
                Dim cm1E As New SqlClient.SqlCommand(sm1E, cn)
                cm1E.Parameters.AddWithValue("@NOFATORA", TextBox43.Text)
                Dim rdm1E As SqlClient.SqlDataReader = cm1E.ExecuteReader
                If rdm1E.Read = True Then
                    gorfan = rdm1E!NOSAREER
                    gorfat = rdm1E!EYWAAT
                    gorfaad = 1
                    yedate = rdm1E!DATEEYWAA
                    modate = rdm1E!datemoghadra
                    motime = rdm1E!timemoghadra
                End If
                Dim sm1ET As String = "select * from TYPEEYWAA where IDEY=@IDEY"
                Dim cm1ET As New SqlClient.SqlCommand(sm1ET, cn)
                cm1ET.Parameters.AddWithValue("@IDEY", gorfat)
                Dim rdm1ET As SqlClient.SqlDataReader = cm1ET.ExecuteReader
                If rdm1ET.Read = True Then
                    gorfat = rdm1ET!EYWAATYPE
                End If

            End If
            PRK = 2
            vv1 = Me.TextBox1.Text
            vv2 = Me.TextBox8.Text
            Me.Close()
            'If JH = 1 Then
            '    Dim f As New Form61
            '    f.a = Me.Label49.Text
            '    f.b = CDbl(Me.Label51.Text)
            '    f.c = Me.TextBox3.Text
            '    f.d = Me.TextBox4.Text
            '    f.g = CDbl(Me.Label51.Text)
            '    f.h = Me.Label48.Text
            '    f.j = Me.TextBox43.Text
            '    f.l = Me.Label53.Text
            '    f.e = user
            '    f.nam = nam
            '    f.jehan = jehan
            '    f.gorfan = gorfan
            '    f.gorfat = gorfat
            '    f.gorfaad = gorfaad
            '    f.yedate = yedate
            '    f.modate = modate
            '    f.motime = motime
            '    f.ShowDialog()
            'Else
            Dim f As New Form61
            f.a = Me.Label49.Text
            f.b = CDbl(Me.Label51.Text)
            f.c = Me.TextBox3.Text
            f.d = Me.TextBox4.Text
            f.g = CDbl(Me.Label51.Text)
            f.h = Me.Label48.Text
            f.j = Me.TextBox43.Text
            f.l = Me.Label53.Text
            f.e = user
            f.nam = nam
            f.jehan = jehan
            f.gorfan = gorfan
            f.gorfat = gorfat
            f.gorfaad = gorfaad
            f.yedate = yedate
            f.modate = modate
            f.motime = motime
            f.ShowDialog()
            'End If


            'Catch ex As Exception

            'End Try
        End If
        Call Class4.CONNIC()

    End Sub

    Private Sub TextBox43_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox43.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Class1.CONNIC()
            Dim skk As String = "select * from EYWAA where NOFATORA=@NOFATORA and MOGHADRA=@MOGHADRA "
            Using cmkk As New SqlClient.SqlCommand(skk, cn)
                cmkk.Parameters.AddWithValue("@NOFATORA", Trim(TextBox43.Text))
                cmkk.Parameters.AddWithValue("@MOGHADRA", False)
                Using rdkk As SqlClient.SqlDataReader = cmkk.ExecuteReader
                    If rdkk.Read = True Then
                        TextBox41.Text = CInt(rdkk!FNUMBER)
                        Label32.Text = CInt(rdkk!KESEM)
                        Label34.Text = CInt(rdkk!EYWAAT)
                        Dim s5Y As String = "select * from KESEM where IDK=@IDK"
                        Using cm5Y As New SqlClient.SqlCommand(s5Y, cn)
                            cm5Y.Parameters.AddWithValue("@IDK", CInt(Label32.Text))
                            Dim rd5Y As SqlClient.SqlDataReader = cm5Y.ExecuteReader
                            If rd5Y.Read = True Then
                                Label32.Text = rd5Y!KESEM
                            End If
                        End Using
                        Dim s5YT As String = "select * from TYPEEYWAA where IDEY=@IDEY"
                        Using cm5YT As New SqlClient.SqlCommand(s5YT, cn)
                            cm5YT.Parameters.AddWithValue("@IDEY", CInt(Label34.Text))
                            Dim rd5YT As SqlClient.SqlDataReader = cm5YT.ExecuteReader
                            If rd5YT.Read = True Then
                                Label34.Text = rd5YT!EYWAATYPE
                            End If
                        End Using

                        Label41.Text = CInt(rdkk!NOSAREER)
                        Label36.Text = Format(CDate(rdkk!DATEEYWAA), "dd/MM/yyyy")
                        DateTimePicker6.Text = Label36.Text
                        Label37.Text = Format(CDate(rdkk!TIMEEYWAA), "hh:mm:ss")

                        Label48.Text = CDbl(rdkk!SE3REYWAA)
                        Label49.Text = CInt(rdkk!DAYZ)
                        Label38.Text = Format(Date.Today.Date, "dd/MM/yyyy")
                        Label39.Text = Format(Now, "hh:mm:ss")
                        rdkk.Close()

                        Dim s5 As String = "select * from main where FNUMBER=@xx1"
                        Using cm5 As New SqlClient.SqlCommand(s5, cn)
                            cm5.Parameters.AddWithValue("@xx1", Trim(TextBox41.Text))
                            Dim rd5 As SqlClient.SqlDataReader = cm5.ExecuteReader
                            If rd5.Read = True Then
                                Me.TextBox41.Text = rd5!fnumber
                                Me.Label29.Text = Trim(rd5!namex)
                                Me.Label31.Text = Trim(rd5!SEX)
                                Me.Label30.Text = CInt(rd5!AGE)
                                Me.Label26.Text = Trim(rd5!GENDER)
                                rd5.Close()

                            Else
                                'Timer2.Stop()
                                'Label21.Text = ""
                                'Label21.BackColor = Color.Transparent
                            End If
                        End Using
                        'End Using
                        Me.Label49.Text = Math.Abs(DateDiff(DateInterval.Day, CDate(Me.DateTimePicker6.Value.Date), CDate(Date.Today.Date)))
                        'Me.DateTimePicker4.Text = Format(Me.DateTimePicker3.Text, "HH:mm")
                        'Me.ComboBox7.Text = Math.Ceiling(Val(Me.TextBox5.Text))
                        If Me.Label49.Text = 0 Then
                            Me.Label49.Text = 0
                        End If
                        If Me.DateTimePicker6.Value = Date.Today.Date Then
                            Me.Label49.Text = Math.Ceiling(Val(Me.Label49.Text)) + 1
                        Else
                            If DateTimePicker6.Value <= Date.Today.Date Then
                                Me.Label49.Text = Math.Ceiling(Val(Me.Label49.Text))
                            Else
                                Me.Label49.Text = Math.Ceiling(Val(Me.Label49.Text)) + 1
                            End If
                        End If

                        Me.TextBox39.Text = 0
                        Call Class1.CONNIC()
                        Dim skd As String = "select * from KASHEF where FNUMBER=@FNUMBER"
                        Dim cmkd As New SqlClient.SqlCommand(skd, cn)
                        cmkd.Parameters.AddWithValue("@FNUMBER", CInt(Me.TextBox41.Text))
                        Dim rdkd11 As SqlClient.SqlDataReader = cmkd.ExecuteReader
                        While rdkd11.Read = True
                            Me.TextBox39.Text = Val(Me.TextBox39.Text) + rdkd11!KEMAT
                            Me.Label50.Text = Val(Me.TextBox39.Text)
                        End While
                        Me.Label51.Text = Val(Label48.Text) * Val(Label49.Text) + Val(Label50.Text)
                        'Me.TextBox16.Text = Val(TextBox17.Text) - Val(ComboBox7.Text * ComboBox9.Text)
                        Dim s5E As String = "select * from EYWAA where FNUMBER=@FNUMBER AND MOGHADRA=@MOGHADRA"
                        Using cm5E As New SqlClient.SqlCommand(s5E, cn)
                            cm5E.Parameters.AddWithValue("@FNUMBER", Trim(TextBox41.Text))
                            cm5E.Parameters.AddWithValue("@MOGHADRA", False)
                            Dim rd5E As SqlClient.SqlDataReader = cm5E.ExecuteReader
                            If rd5E.Read = True Then
                                Me.Label52.Text = CDbl(rd5E!MADFOO)
                                Me.Label53.Text = CDbl(Val(Label51.Text) - Val(Label52.Text))
                            End If
                        End Using
                        TextBox43.Focus()
                        Button17.Enabled = True

                    Else
                        MsgBox("هذه الفاتورة مغلقه")
                        TextBox43.Focus()
                        'Me.TextBox2.Text = ""
                        'Timer2.Stop()
                        'Label21.Text = ""
                        'Label21.BackColor = Color.Transparent
                    End If
                    'rd5.Close()
                End Using
            End Using
            Call Class4.CONNIC()
        End If

    End Sub

    Private Sub TextBox43_TextChanged(sender As Object, e As EventArgs) Handles TextBox43.TextChanged



    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call Class1.CONNIC()
        Dim ss3t As String = "select * from eywaa_v "
        Dim aad3t As New SqlClient.SqlDataAdapter(ss3t, cn)
        Dim dss3t As New DataSet
        dss3t.Clear()
        aad3t.Fill(dss3t, "eywaa_v")
        Dim vdd3t As New DataView(dss3t.Tables("eywaa_v"))
        vdd3t.RowFilter = " moghadra =" & "'" & False & "'" & "and baky >=" & "" & 0 & "" & ""
        DataGridView12.DataMember = ""
        DataGridView12.DataSource = vdd3t
        Call Class4.CONNIC()
    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click

    End Sub

    Private Sub Label53_TextChanged(sender As Object, e As EventArgs) Handles Label53.TextChanged
        If Val(Label53.Text) > 0 Then
            Label55.Text = Label53.Text
            GroupBox67.Text = "عليه"
        ElseIf Val(Label53.Text) < 0 Then
            Label55.Text = Abs(Val(Label53.Text))
            GroupBox67.Text = "له"
        ElseIf Val(Label53.Text) = 0 Then
            Label55.Text = 0
            GroupBox67.Text = "الباقي"
        End If
    End Sub

    Private Sub B15_Click(sender As Object, e As EventArgs) Handles B15.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B15.Text
        bk = B15.Text
        TextBox8.Text = B15.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B15.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B16_Click(sender As Object, e As EventArgs) Handles B16.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B16.Text
        bk = B16.Text
        TextBox8.Text = B16.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B16.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B17_Click(sender As Object, e As EventArgs) Handles B17.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B17.Text
        bk = B17.Text
        TextBox8.Text = B17.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B17.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B18_Click(sender As Object, e As EventArgs) Handles B18.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B18.Text
        bk = B18.Text
        TextBox8.Text = B18.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B18.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B19_Click(sender As Object, e As EventArgs) Handles B19.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B19.Text
        bk = B19.Text
        TextBox8.Text = B19.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B19.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B20_Click(sender As Object, e As EventArgs) Handles B20.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B20.Text
        bk = B20.Text
        TextBox8.Text = B20.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B20.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B21_Click(sender As Object, e As EventArgs) Handles B21.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B21.Text
        bk = B21.Text
        TextBox8.Text = B21.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B21.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B22_Click(sender As Object, e As EventArgs) Handles B22.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B22.Text
        bk = B22.Text
        TextBox8.Text = B22.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B22.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B23_Click(sender As Object, e As EventArgs) Handles B23.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B23.Text
        bk = B23.Text
        TextBox8.Text = B23.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B23.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B24_Click(sender As Object, e As EventArgs) Handles B24.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B24.Text
        bk = B24.Text
        TextBox8.Text = B24.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B24.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B25_Click(sender As Object, e As EventArgs) Handles B25.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B25.Text
        bk = B25.Text
        TextBox8.Text = B25.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B25.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub B26_Click(sender As Object, e As EventArgs) Handles B26.Click
        Call Class1.CONNIC()
        Dim sk2 As String
        Dim B As String
        B = B26.Text
        bk = B26.Text
        TextBox8.Text = B26.Text
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Dim cmG As New SqlClient.SqlCommand(sG, cn)
        cmG.Parameters.AddWithValue("@xx1", B26.Text)
        Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
        With rdG.Read = True
            B = rdG!IDK
        End With
        rdG.Close()
        sk2 = "select * from DN where IDK=" & B
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sn20 As String = "select * from dn where dn=@xxxxx1 "
        Dim cmn20 As New SqlClient.SqlCommand(sn20, cn)
        cmn20.Parameters.AddWithValue("@xxxxx1", ComboBox2.Text)
        Dim rdn20 As SqlClient.SqlDataReader = cmn20.ExecuteReader
        If rdn20.Read = True Then
            Me.Label4.Text = rdn20!idD
        End If
        rdn20.Close()
        Call Class4.CONNIC()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub DataGridView9_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView9.CellMouseDown
        If e.ColumnIndex < 0 Then
            Return
        End If
        If e.RowIndex < 0 Then
            Return
        End If
        Call Class1.CONNIC()

        L = CInt(DataGridView9.Item(0, e.RowIndex).Value)
        Dim s As String = "select * from AMALEAT_M_VIEW where IDAM=@IDAM "
        Using cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@IDAM", CInt(L))
            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            If rd.Read = True Then
                Label42.Text = CInt(rd!IDA)
                Dim sH As String = "select * from amaleat_M where IDAM=@IDAM "
                Using cmH As New SqlClient.SqlCommand(sH, cn)
                    cmH.Parameters.AddWithValue("@IDAM", CInt(L))
                    Dim rdH As SqlClient.SqlDataReader = cmH.ExecuteReader
                    If rdH.Read = True Then
                        Label42.Text = CInt(rd!IDA)
                        ComboBox16.Text = rd!DN
                        TextBox62.Text = CDbl(rd!DOCK)
                        ComboBox15.Text = rdH!tdocn
                        TextBox61.Text = CDbl(rdH!tdock)
                        ComboBox21.Text = rdH!mdocn
                        TextBox67.Text = CDbl(rdH!mdock)
                        ComboBox18.Text = rdH!fdocn
                        TextBox65.Text = CDbl(rdH!fdock)
                        ComboBox19.Text = rdH!ftdocn
                        TextBox64.Text = CDbl(rdH!ftdock)
                        TextBox66.Text = CDbl(rdH!tahk)
                        ComboBox17.Text = rdH!kabn
                        TextBox63.Text = CDbl(rdH!kabk)
                        ComboBox14.Text = rdH!cdocn
                        TextBox60.Text = CDbl(rdH!cdock)
                        ComboBox13.Text = rd!aml_name
                        TextBox59.Text = CDbl(rdH!aml_kema)
                        TextBox69.Text = CDbl(rdH!C_KEMA)
                        TextBox70.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
                        GroupBox83.Enabled = True
                        GroupBox81.Enabled = True
                        GroupBox88.Enabled = True
                        GroupBox86.Enabled = True
                        GroupBox84.Enabled = True
                        GroupBox80.Enabled = True
                        GroupBox76.Enabled = True
                        GroupBox74.Enabled = True
                        GroupBox75.Enabled = True
                        GroupBox73.Enabled = True
                        GroupBox82.Enabled = True
                        GroupBox79.Enabled = True
                        'GroupBox87.Enabled = True
                        GroupBox85.Enabled = True

                    End If
                End Using
            End If
        End Using
        Call Class4.CONNIC()

    End Sub

    Private Sub LOSSBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles LOSSBindingSource.CurrentChanged

    End Sub
End Class