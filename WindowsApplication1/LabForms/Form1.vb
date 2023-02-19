Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Public Class Form1

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Timer1.Start()
        Me.Label7.Text = user
        Me.TabControl1.SelectedTab = TabPage2
        Me.TextBox1.Focus()
        Me.DateTimePicker1.Text = Date.Today
        ' Me.TabControl1.SelectTab(0)
        Me.DataGridView1.DataSource = ""
        Me.DataGridView2.DataSource = ""
        Me.DataGridView3.DataSource = ""
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        PictureBox1.Image = Nothing
        PictureBox1.Refresh()
        Me.ComboBox8.Text = ""
        Me.ComboBox4.Text = ""
        MaskedTextBox1.Text = ""
        NumericUpDown1.Value = 0
        Me.ComboBox2.Text = ""
        Me.ComboBox3.Text = ""
        ComboBox10.Text = ""
        Me.RichTextBox1.Text = ""
        Me.RichTextBox2.Text = ""
        Me.RichTextBox3.Text = ""
        Me.RichTextBox4.Text = ""
        Me.RichTextBox5.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        TextBox2.Text = ""
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Me.TextBox1.Focus()
        If t = 1 Then
            t = 0
            Me.TextBox1.Text = dgxx
            Call Class1.CONNIC()
            Dim s As String = "select * from main where fnumber=@xx1 "
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@xx1", TextBox1.Text)
            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            If rd.Read = True Then
                Me.ComboBox8.Text = rd!NAMEX
                Me.NumericUpDown1.Value = rd!AGE
                Me.ComboBox2.Text = rd!GENDER
                Me.TextBox3.Text = rd!FNUMBER
                Me.ComboBox4.Text = rd!NAMEX
                TabPage3.Enabled = True
                TabPage4.Enabled = True
                Me.TextBox1.Enabled = False
                Me.ComboBox8.Enabled = False
                Me.NumericUpDown1.Enabled = False
                Me.ComboBox2.Enabled = False
                Dim sdu As String = "select * from main "
                Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
                Dim dssdu As New DataSet
                dssdu.Clear()
                aaddu.Fill(dssdu, "main")
                Dim vddu As New DataView(dssdu.Tables("main"))
                vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & ""
                Me.DataGridView3.DataMember = ""
                DataGridView3.DataSource = vddu

                ComboBox10.Focus()
            Else

                Me.ComboBox8.Focus()

            End If
            Call Class1.CONNIC()
            Call Class1.CONNIC()
            Dim sd1 As String = "select * from doctorr where fnumber=@fnumber AND UP=@UP "
            Dim cmd1 As New SqlClient.SqlCommand(sd1, cn)
            cmd1.Parameters.AddWithValue("@fnumber", TextBox1.Text)
            cmd1.Parameters.AddWithValue("@UP", "1")
            Dim rdd As SqlClient.SqlDataReader = cmd1.ExecuteReader
            If rdd.Read = True Then
                Me.Label7.Text = rdd!doctorna
                Me.ComboBox10.Text = rdd!mast
                Me.MaskedTextBox2.Text = rdd!datema
                Me.NumericUpDown2.Value = rdd!parity
                Me.NumericUpDown3.Value = rdd!abortion
                Me.RichTextBox1.Text = rdd!obhis
                Me.RichTextBox2.Text = rdd!gynhis
                Me.RichTextBox3.Text = rdd!PMASHIS
                Me.RichTextBox4.Text = rdd!GENEX
                Me.TextBox2.Text = rdd!BP
                Me.TextBox15.Text = rdd!RESRAT
                Me.TextBox4.Text = rdd!PULSE
                Me.TextBox14.Text = rdd!BW
                Me.TextBox12.Text = rdd!TEMP
                Me.TextBox13.Text = rdd!HEIGHT
                Me.RichTextBox5.Text = rdd!ABDEX
                Me.RichTextBox6.Text = rdd!CHEX
                Me.RichTextBox7.Text = rdd!HEEX
                Me.RichTextBox8.Text = rdd!SPEX
                Me.RichTextBox9.Text = rdd!PUSG
                Me.RichTextBox10.Text = rdd!OTHERS

            End If

            Dim s1 As String = "select * from TREATMENT_PLANING "
            Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            Dim dss As New DataSet
            dss.Clear()
            aad.Fill(dss, "TREATMENT_PLANING")
            Dim vd As New DataView(dss.Tables("TREATMENT_PLANING"))
            vd.RowFilter = "IDPAT=" & "'" & TextBox1.Text & "'" & ""
            Me.DataGridView1.DataMember = ""
            DataGridView1.DataSource = vd

            Dim s12 As String = "select * from Treatment_Visits "
            Dim aad2 As New SqlClient.SqlDataAdapter(s12, cn)
            Dim dss2 As New DataSet
            dss2.Clear()
            aad2.Fill(dss2, "Treatment_Visits")
            Dim vd2 As New DataView(dss2.Tables("Treatment_Visits"))
            vd2.RowFilter = "IDPAT=" & "'" & TextBox1.Text & "'" & ""
            Me.DataGridView2.DataMember = ""
            DataGridView2.DataSource = vd2

            Dim s11 As String = "select * from pharmacy "
            Dim aad1 As New SqlClient.SqlDataAdapter(s11, cn)
            Dim dss1 As New DataSet
            dss1.Clear()
            aad1.Fill(dss1, "pharmacy")
            Dim vd1 As New DataView(dss1.Tables("pharmacy"))
            vd1.RowFilter = "fnumber=" & "'" & TextBox1.Text & "'" & ""
            Me.DataGridView4.DataMember = ""
            DataGridView4.DataSource = vd1



            Dim sd As String = "select * from document where fnumber=@fnumber "
            Dim cmd As New SqlClient.SqlCommand(sd, cn)
            cmd.Parameters.AddWithValue("@fnumber", TextBox1.Text)
            Dim rdd2 As SqlClient.SqlDataReader = cmd.ExecuteReader
            If rdd2.Read = True Then
                TextBox17.Text = rdd2!pathpic

                pinm = TextBox17.Text
            End If
            Try
                PictureBox1.Image = Image.FromFile(Application.StartupPath & "\pic\" & pinm & ".bmp")
            Catch ex As Exception
            End Try
        Else
            Me.TextBox1.Enabled = True
            Me.ComboBox8.Enabled = True
            Me.NumericUpDown1.Enabled = True
            Me.ComboBox2.Enabled = True

        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TabControl1.SelectTab(0)
        Me.DataGridView1.DataSource = ""
        Me.DataGridView2.DataSource = ""
        Me.DataGridView3.DataSource = ""
        TabPage3.Enabled = False
        TabPage4.Enabled = False
        PictureBox1.Image = Nothing
        PictureBox1.Refresh()
        Me.ComboBox8.Text = ""
        Me.ComboBox4.Text = ""
        MaskedTextBox1.Text = ""
        NumericUpDown1.Value = 0
        Me.ComboBox2.Text = ""
        Me.ComboBox3.Text = ""
        ComboBox10.Text = ""
        Me.RichTextBox1.Text = ""
        Me.RichTextBox2.Text = ""
        Me.RichTextBox3.Text = ""
        Me.RichTextBox4.Text = ""
        Me.RichTextBox5.Text = ""
        CheckBox1.Checked = True
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        TextBox2.Text = ""
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        Me.TextBox1.Enabled = True
        Me.ComboBox8.Enabled = True
        Me.NumericUpDown1.Enabled = True
        Me.ComboBox2.Enabled = True
    End Sub



    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.TextBox1.Text = "" Then
                MsgBox("Ì—ÃÏ ≈œŒ«· —ﬁ„ «·„—Ì÷")
                Me.TextBox1.Focus()
            Else
                Dim s As String = "select * from main where fnumber=xx1 "
                Dim cm As New SqlClient.SqlCommand(s, cn)
                cm.Parameters.AddWithValue("xx1", TextBox1.Text)
                Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    Me.TextBox6.Text = rd!FNUMBER
                    Me.ComboBox8.Text = rd!NAMEX
                    Me.ComboBox14.Text = rd!NAMEX
                    Me.ComboBox15.Text = rd!husbend
                    Me.Label12.Text = Me.ComboBox8.Text
                    Me.NumericUpDown1.Value = rd!AGE
                    Me.TextBox9.Text = rd!AGE
                    Me.Label11.Text = NumericUpDown1.Value
                    Me.ComboBox2.Text = rd!GENDER
                    Me.TextBox3.Text = rd!FNUMBER
                    Me.ComboBox4.Text = rd!NAMEX
                    TabPage3.Enabled = True
                    TabPage4.Enabled = True
                    Me.ComboBox8.Focus()
                    nx = Me.ComboBox8.Text
                    Me.Label10.Text = Date.Today.Date

                    Dim sdu As String = "select * from main "
                    Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
                    Dim dssdu As New DataSet
                    dssdu.Clear()
                    aaddu.Fill(dssdu, "main")
                    Dim vddu As New DataView(dssdu.Tables("main"))
                    vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & ""
                    Me.DataGridView3.DataMember = ""
                    DataGridView3.DataSource = vddu


                Else
                    Me.ComboBox8.Focus()
                End If
                Dim sd1 As String = "select * from doctorr where fnumber=xx1 AND UP=XXXX "
                Dim cmd1 As New SqlClient.SqlCommand(sd1, cn)
                cmd1.Parameters.AddWithValue("xx1", TextBox1.Text)
                cmd1.Parameters.AddWithValue("XXXX", "1")
                Dim rdd As SqlClient.SqlDataReader = cmd1.ExecuteReader
                If rdd.Read = True Then
                    Me.Label7.Text = rdd!doctorna
                    Me.ComboBox10.Text = rdd!mast
                    Me.MaskedTextBox2.Text = rdd!datema
                    Me.DateTimePicker3.Text = rdd!DATEMA
                    Me.DateTimePicker1.Text = Me.MaskedTextBox2.Text
                    Me.NumericUpDown2.Value = rdd!parity
                    Me.NumericUpDown3.Value = rdd!abortion
                    Me.RichTextBox1.Text = rdd!obhis
                    Me.RichTextBox2.Text = rdd!gynhis
                    Me.RichTextBox3.Text = rdd!PMASHIS
                    Me.RichTextBox4.Text = rdd!GENEX
                    Me.TextBox12.Text = rdd!BP
                    Me.TextBox15.Text = rdd!RESRAT
                    Me.TextBox4.Text = rdd!PULSE
                    Me.TextBox14.Text = rdd!BW
                    Me.TextBox12.Text = rdd!TEMP
                    Me.TextBox13.Text = rdd!HEIGHT
                    Me.RichTextBox5.Text = rdd!ABDEX
                    Me.RichTextBox6.Text = rdd!CHEX
                    Me.RichTextBox7.Text = rdd!HEEX
                    Me.RichTextBox8.Text = rdd!SPEX
                    Me.RichTextBox9.Text = rdd!PUSG
                    Me.RichTextBox10.Text = rdd!OTHERS

                    Dim s1 As String = "select * from TREATMENT_PLANING "
                    Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                    Dim dss As New DataSet
                    dss.Clear()
                    aad.Fill(dss, "TREATMENT_PLANING")
                    Dim vd As New DataView(dss.Tables("TREATMENT_PLANING"))
                    vd.RowFilter = "IDPAT=" & "'" & TextBox1.Text & "'" & ""
                    Me.DataGridView1.DataMember = ""
                    DataGridView1.DataSource = vd

                    Dim s12 As String = "select * from Treatment_Visits "
                    Dim aad2 As New SqlClient.SqlDataAdapter(s12, cn)
                    Dim dss2 As New DataSet
                    dss2.Clear()
                    aad2.Fill(dss2, "Treatment_Visits")
                    Dim vd2 As New DataView(dss2.Tables("Treatment_Visits"))
                    vd2.RowFilter = "IDPAT=" & "'" & TextBox1.Text & "'" & ""
                    Me.DataGridView2.DataMember = ""
                    DataGridView2.DataSource = vd2

                    Dim s11 As String = "select * from pharmacy "
                    Dim aad1 As New SqlClient.SqlDataAdapter(s11, cn)
                    Dim dss1 As New DataSet
                    dss1.Clear()
                    aad1.Fill(dss1, "pharmacy")
                    Dim vd1 As New DataView(dss1.Tables("pharmacy"))
                    vd1.RowFilter = "fnumber=" & "'" & TextBox1.Text & "'" & ""
                    Me.DataGridView4.DataMember = ""
                    DataGridView4.DataSource = vd1


                End If
                Dim sd As String = "select * from document where fnumber=xx1 "
                Dim cmd As New SqlClient.SqlCommand(sd, cn)
                cmd.Parameters.AddWithValue("xx1", TextBox1.Text)
                Dim rdd2 As SqlClient.SqlDataReader = cmd.ExecuteReader
                If rdd2.Read = True Then
                    TextBox17.Text = rdd2!pathpic

                    pinm = TextBox17.Text
                End If
                Try
                    PictureBox1.Image = Image.FromFile(Application.StartupPath & "\pic\" & pinm & ".bmp")
                Catch ex As Exception
                End Try
                Dim shh As String = "select * from lab where fnumber=xxx1 "
                Dim cmhh As New SqlClient.SqlCommand(shh, cn)
                cmhh.Parameters.AddWithValue("xxx1", TextBox1.Text)
                Dim rdhh As SqlClient.SqlDataReader = cmhh.ExecuteReader

                If rdhh.Read = True Then
                    Me.ComboBox9.Text = rdhh!DNA
                    Me.ComboBox7.Text = rdhh!HDNA
                    Me.ComboBox12.Text = rdhh!pregnancy_test
                    Me.ComboBox11.Text = rdhh!BHCG
                    Me.ComboBox6.Text = rdhh!OTHERS

                End If
            End If

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TabPage3.Enabled = False Then
            'Dim ss As String = "insert into MAIN(FNUMBER,NAMEX,AGE,SEX)VALUES(XX4,XX1,XX2,XX3)"
            'Dim cmm As New SqlClient.SqlCommand(ss, cn)
            'cmm.Parameters.AddWithValue("xx4", Me.TextBox1.Text)
            'cmm.Parameters.AddWithValue("xx1", Me.ComboBox8.Text)
            'cmm.Parameters.AddWithValue("xx2", NumericUpDown1.Value)
            'cmm.Parameters.AddWithValue("xx3", Me.ComboBox2.Text)
            'Try
            '    cmm.ExecuteNonQuery()
            '    'cmmd.ExecuteNonQuery()
            '    MsgBox(" „  ≈÷«›… «·„—Ì÷")
            '    Me.TabControl1.SelectTab(0)
            '    Me.DataGridView1.DataSource = ""
            '    Me.DataGridView2.DataSource = ""
            '    Me.DataGridView3.DataSource = ""
            '    TabPage3.Enabled = False
            '    TabPage4.Enabled = False
            '    PictureBox1.Image = Nothing
            '    PictureBox1.Refresh()
            '    Me.ComboBox8.Text = ""
            '    Me.ComboBox4.Text = ""
            '    MaskedTextBox1.Text = ""
            '    NumericUpDown1.Value = 0
            '    Me.ComboBox2.Text = ""
            '    Me.ComboBox3.Text = ""
            '    ComboBox10.Text = ""
            '    Me.RichTextBox1.Text = ""
            '    Me.RichTextBox2.Text = ""
            '    Me.RichTextBox3.Text = ""
            '    Me.RichTextBox4.Text = ""
            '    Me.RichTextBox5.Text = ""
            '    CheckBox1.Checked = True
            '    CheckBox2.Checked = False
            '    CheckBox3.Checked = False
            '    CheckBox4.Checked = False
            '    TextBox2.Text = ""
            '    TextBox1.Text = ""
            '    TextBox3.Text = ""
            '    TextBox4.Text = ""
            '    TextBox5.Text = ""
            '    TextBox7.Text = ""
            '    TextBox1.Focus()
            'Catch ex As Exception
            '    MsgBox(" ·«Ì„ﬂ‰ «·Õ›Ÿ ")
            'End Try
        Else
            Dim sskh1 As String = "select * from DoctorR where fnumber=xx1"
            Dim cmmmd1 As New SqlClient.SqlCommand(sskh1, cn)
            cmmmd1.Parameters.AddWithValue(xx1, Me.TextBox1.Text)
            Dim RDD As SqlClient.SqlDataReader = cmmmd1.ExecuteReader
            Do While RDD.Read = True
                Dim SSSD As String = "UPDATE DoctorR set up=xxx1 where fnumber=xx1"
                Dim cmmmd As New SqlClient.SqlCommand(SSSD, cn)
                cmmmd.Parameters.AddWithValue(xxx1, "0")
                cmmmd.Parameters.AddWithValue(xx1, Me.TextBox1.Text)
                cmmmd.ExecuteNonQuery()
            Loop
            '----------------------------------------------------------------------------------------------------------

            ' Dim ssd As String = "insert into DoctorR(DoctorNa,fnumber,UP)VALUES(XX4,XX1,XX24)"
            ' Dim ssd As String = "insert into DoctorR(DoctorNa,fnumber,MaSt,DateMa,Parity,Abortion,ObHis,GynHis,PMASHis,GenEx,BP,ResRat,Pulse,BW,Temp,Height,AbdEx,ChEx,HeEx,SpEx,PUSG,HSG,Others,UP)VALUES(XX4,XX1,XX2,XX3,XX5,XX6,XX7,XX8,XX9,XX10,XX11,XX12,XX13,XX14,XX15,XX16,XX17,XX18,XX19,XX20,XX21,XX22,XX23,XX24)"
            Dim ssd As String = "insert into DoctorR(DoctorNa,MaSt,DateMa,Parity,Abortion,ObHis,GynHis,PMASHis,GenEx,BP,ResRat,Pulse,BW,Temp,Height,AbdEx,ChEx,HeEx,SpEx,PUSG,HSG,Others,UP,fnumber)VALUES(XX4,XX2,XX3,XX5,XX6,XX7,XX8,XX9,XX10,XX11,XX12,XX13,XX14,XX15,XX16,XX17,XX18,XX19,XX20,XX21,XX22,XX23,XX24,XX25)"
            Dim cmmd As New SqlClient.SqlCommand(ssd, cn)
            cmmd.Parameters.AddWithValue("xx4", Me.Label7.Text)
            'cmmd.Parameters.AddWithValue("xx25", Me.TextBox1.Text)
            cmmd.Parameters.AddWithValue("xx2", Me.ComboBox10.Text)
            cmmd.Parameters.AddWithValue("xx3", Me.DateTimePicker1.Text)
            cmmd.Parameters.AddWithValue("xx5", Me.NumericUpDown2.Text)
            cmmd.Parameters.AddWithValue("xx6", Me.NumericUpDown3.Text)
            cmmd.Parameters.AddWithValue("xx7", Me.RichTextBox1.Text)
            cmmd.Parameters.AddWithValue("xx8", Me.RichTextBox2.Text)
            cmmd.Parameters.AddWithValue("xx9", Me.RichTextBox3.Text)
            cmmd.Parameters.AddWithValue("xx10", Me.RichTextBox4.Text)
            cmmd.Parameters.AddWithValue("xx11", Me.TextBox2.Text)
            cmmd.Parameters.AddWithValue("xx12", Me.TextBox15.Text)
            cmmd.Parameters.AddWithValue("xx13", Me.TextBox4.Text)
            cmmd.Parameters.AddWithValue("xx14", Me.TextBox14.Text)
            cmmd.Parameters.AddWithValue("xx15", Me.TextBox12.Text)
            cmmd.Parameters.AddWithValue("xx16", Me.TextBox13.Text)
            cmmd.Parameters.AddWithValue("xx17", Me.RichTextBox5.Text)
            cmmd.Parameters.AddWithValue("xx18", Me.RichTextBox6.Text)
            cmmd.Parameters.AddWithValue("xx19", Me.RichTextBox7.Text)
            cmmd.Parameters.AddWithValue("xx20", Me.RichTextBox8.Text)
            cmmd.Parameters.AddWithValue("xx21", Me.RichTextBox9.Text)
            cmmd.Parameters.AddWithValue("xx22", Me.RichTextBox10.Text)
            cmmd.Parameters.AddWithValue("xx23", Me.RichTextBox11.Text)
            cmmd.Parameters.AddWithValue("xx24", "1")
            cmmd.Parameters.AddWithValue("XX25", Me.TextBox1.Text)
            Try
                cmmd.ExecuteNonQuery()
                MsgBox(" „ «·Õ›Ÿ")
            Catch ex As Exception
                MsgBox("Œÿ√")
            End Try
            If Me.PictureBox1.Enabled = False Then
            Else
                '    Dim k As Bitmap = PictureBox1.Image
                '    k.Save(Application.StartupPath & "\pic\" & pinm & ".bmp")
                '    Dim fs As FileStream
                '    Dim br As BinaryReader
                '    Dim ggg As String
                '    ggg = TextBox2.Text
                '    fs = New FileStream(Application.StartupPath & "\pic\" & TextBox2.Text & ".bmp", FileMode.Open)
                '    'fs = New FileStream(Application.StartupPath & "pic\" & ggg &, FileMode.Open)
                '    br = New BinaryReader(fs)
                '    Dim imgbyte(fs.Length) As Byte
                '    imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length)))
                '    Dim ss As String = "insert into DOCUMENT(FNUMBER,ANALYSIS,XRAY,PHOTOGRAPH,MXPORTS,PATHPIC,IMG,DATED)VALUES(XXX1,XXX2,XXX3,XXX4,XXX5,XXX6,XXX7,XXX8)"
                '    Dim cmm As New SqlClient.SqlCommand(ss, cn)
                '    cmm.Parameters.AddWithValue("xx1", Me.TextBox1.Text)
                '    cmm.Parameters.AddWithValue("xx2", Me.CheckBox1.Checked)
                '    cmm.Parameters.AddWithValue("xx3", Me.CheckBox2.Checked)
                '    cmm.Parameters.AddWithValue("xx4", Me.CheckBox3.Checked)
                '    cmm.Parameters.AddWithValue("xx5", Me.CheckBox4.Checked)
                '    cmm.Parameters.AddWithValue("xx6", Me.TextBox2.Text)
                '    cmm.Parameters.AddWithValue("xx7", imgbyte)
                '    cmm.Parameters.AddWithValue("xx8", Date.Today)

                '    Try
                '        cmm.ExecuteNonQuery()
                '        MsgBox(" „ «·Õ›Ÿ ")
                '    Catch ex As Exception
                '        MsgBox(" ·«Ì„ﬂ‰ «·Õ›Ÿ ")
                '    End Try
            End If
            If Me.TextBox5.Text <> "" Then
                'Dim ss1 As String = "insert into Treatment_planing(IDPAT,Proucedure)VALUES(XXX1,XXX2)"
                'Dim cmm1 As New SqlClient.SqlCommand(ss1, cn)
                'cmm1.Parameters.AddWithValue("xxx1", Me.TextBox1.Text)
                'cmm1.Parameters.AddWithValue("xxx2", Me.TextBox5.Text)
                'Try
                '    cmm1.ExecuteNonQuery()
                '    MsgBox(" „ «·Õ›Ÿ ")
                '    Me.TextBox5.Text = ""
                '    Dim s1 As String = "select * from TREATMENT_PLANING "
                '    Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                '    Dim dss As New DataSet
                '    dss.Clear()
                '    aad.Fill(dss, "TREATMENT_PLANING")
                '    Dim vd As New DataView(dss.Tables("TREATMENT_PLANING"))
                '    vd.RowFilter = "IDPAT=" & "'" & TextBox1.Text & "'" & ""
                '    Me.DataGridView1.DataMember = ""
                '    DataGridView1.DataSource = vd
                'Catch ex As Exception
                '    MsgBox(" ·«Ì„ﬂ‰ «·Õ›Ÿ ")
                'End Try
            End If
            If Me.TextBox7.Text <> "" Then
                'Dim ss2 As String = "insert into Treatment_Visits(IDPAT,Visit,Datet)VALUES(XXXX1,XXXX2,XXXX3)"
                'Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
                'cmm2.Parameters.AddWithValue("xxxx1", Me.TextBox1.Text)
                'cmm2.Parameters.AddWithValue("xxxx2", Me.TextBox7.Text)
                'cmm2.Parameters.AddWithValue("xxxx3", Me.MaskedTextBox1.Text)
                'Try
                '    cmm2.ExecuteNonQuery()
                '    MsgBox(" „ «·Õ›Ÿ ")
                '    Me.TextBox7.Text = ""
                '    Me.MaskedTextBox1.Text = ""

                'Catch ex As Exception
                '    MsgBox(" ·«Ì„ﬂ‰ «·Õ›Ÿ ")
                'End Try
            End If
            If Me.ComboBox3.Text <> "" Then
                '    Dim ss22 As String = "insert into Pharmacy(fnumber,Medicine,Dosage,Dateph,doctorna)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5)"
                '    Dim cmm22 As New SqlClient.SqlCommand(ss22, cn)
                '    cmm22.Parameters.AddWithValue("xxxx1", Me.TextBox1.Text)
                '    cmm22.Parameters.AddWithValue("xxxx2", Me.ComboBox3.Text)
                '    cmm22.Parameters.AddWithValue("xxxx3", Me.ComboBox5.Text)
                '    cmm22.Parameters.AddWithValue("xxxx4", Me.DateTimePicker1.Text)
                '    cmm22.Parameters.AddWithValue("xxxx5", Me.Label7.Text)
                '    Try
                '        cmm22.ExecuteNonQuery()
                '        MsgBox(" „ «·Õ›Ÿ ")
                '        Me.TextBox7.Text = ""
                '        Me.MaskedTextBox1.Text = ""

                '    Catch ex As Exception
                '        MsgBox(" PHARMACY ·«Ì„ﬂ‰ «·Õ›Ÿ ")
                '    End Try
            End If
        End If

    End Sub

    Private Sub GroupBox30_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox30.Enter

    End Sub


    Private Sub DataGridView5_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        Select Case e.ColumnIndex
            Case 0
                dgxx = Val(Me.DataGridView5.CurrentCell.Value.ToString)
                If dgxx <> 0 Then
                    dgx = dgxx
                End If
                TextBox12.Text = dgx
                Dim ss As String = "select * from document where id=dgx"
                Dim cmmmm As New SqlClient.SqlCommand(ss, cn)
                cmmmm.Parameters.AddWithValue("dgx", TextBox12.Text)
                Dim rd As SqlClient.SqlDataReader = cmmmm.ExecuteReader
                If rd.Read = True Then
                    Me.TextBox17.Text = rd!pathpic
                End If
                Try
                    pinm = Me.TextBox17.Text

                    PictureBox1.Image = Image.FromFile(Application.StartupPath & "\pic\" & pinm & ".bmp")
                    Me.ComboBox1.Text = rd!notex
                Catch ex As Exception

                End Try


        End Select
    End Sub

    Private Sub ComboBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox8.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.ComboBox8.Text = "" Then
                MsgBox("sorry...insert the Name")
                Me.ComboBox8.Text = nx
                Me.ComboBox8.Focus()
            Else
                Me.NumericUpDown1.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged

    End Sub

    Private Sub NumericUpDown1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumericUpDown1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.NumericUpDown1.Value < 15 Then
                MsgBox("sorry...The Age must be biger then 15 years old")
                '   Me.ComboBox8.Text = nx
                Me.NumericUpDown1.Focus()
            Else
                Me.ComboBox2.Focus()
            End If
        End If

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.ComboBox2.Text = "" Then
                Me.ComboBox2.Text = "Male"
            End If
            Me.ComboBox10.Focus()
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox10.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.ComboBox10.Text = "" Then
                Me.ComboBox10.Text = "Non"
            End If
            Me.DateTimePicker1.Focus()
        End If

    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.NumericUpDown2.Focus()
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub NumericUpDown2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumericUpDown2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.NumericUpDown3.Focus()
        End If

    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged

    End Sub

    Private Sub NumericUpDown3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumericUpDown3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TabControl1.SelectedTab = TabPage1
            Me.RichTextBox1.Focus()
        End If

    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TabPage2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.GotFocus
        Me.TextBox1.Focus()
    End Sub

    Private Sub RichTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.RichTextBox2.Focus()
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub RichTextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.RichTextBox3.Focus()
        End If
    End Sub

    Private Sub RichTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub RichTextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.RichTextBox4.Focus()
        End If

    End Sub

    Private Sub RichTextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox3.TextChanged

    End Sub

    Private Sub RichTextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TabControl1.SelectedTab = TabPage5
            Me.TextBox2.Focus()
        End If

    End Sub

    Private Sub RichTextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox4.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox15.Focus()
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox15_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox15.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox4.Focus()
        End If

    End Sub

    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox14.Focus()
        End If

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox14_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox14.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox12.Focus()
        End If

    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox12.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox13.Focus()
        End If

    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox13.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.RichTextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub RichTextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox5.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.RichTextBox6.Focus()
        End If

    End Sub

    Private Sub RichTextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox5.TextChanged

    End Sub

    Private Sub RichTextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox6.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.RichTextBox7.Focus()
        End If

    End Sub

    Private Sub RichTextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox6.TextChanged

    End Sub

    Private Sub RichTextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox7.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.RichTextBox8.Focus()
        End If

    End Sub

    Private Sub RichTextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox7.TextChanged

    End Sub

    Private Sub RichTextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox8.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.RichTextBox9.Focus()
        End If

    End Sub

    Private Sub RichTextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox8.TextChanged

    End Sub

    Private Sub RichTextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox9.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.RichTextBox10.Focus()
        End If

    End Sub

    Private Sub RichTextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox9.TextChanged

    End Sub

    Private Sub RichTextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox10.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.RichTextBox11.Focus()
        End If

    End Sub

    Private Sub RichTextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox10.TextChanged

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Focus()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Me.RichTextBox2.Text = ""
        Me.RichTextBox2.Focus()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Me.RichTextBox3.Text = ""
        Me.RichTextBox3.Focus()
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TextBox2.Text = ""
        Me.TextBox2.Focus()
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TextBox15.Text = ""
        Me.TextBox15.Focus()
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TextBox4.Text = ""
        Me.TextBox4.Focus()
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TextBox14.Text = ""
        Me.TextBox14.Focus()
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TextBox12.Text = ""
        Me.TextBox12.Focus()
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.TextBox13.Text = ""
        Me.TextBox13.Focus()
    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.RichTextBox5.Text = ""
        Me.RichTextBox5.Focus()
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.RichTextBox6.Text = ""
        Me.RichTextBox6.Focus()
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.RichTextBox7.Text = ""
        Me.RichTextBox7.Focus()
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.RichTextBox8.Text = ""
        Me.RichTextBox8.Focus()
    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.RichTextBox9.Text = ""
        Me.RichTextBox9.Focus()
    End Sub

    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.RichTextBox10.Text = ""
        Me.RichTextBox10.Focus()
    End Sub

    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.RichTextBox11.Text = ""
        Me.RichTextBox11.Focus()
    End Sub

    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        Dim k As Bitmap = PictureBox1.Image
        k.Save(Application.StartupPath & "\pic\" & pinm & ".bmp")
        Dim fs As FileStream
        Dim br As BinaryReader
        Dim ggg As String
        ggg = TextBox2.Text
        fs = New FileStream(Application.StartupPath & "\pic\" & TextBox2.Text & ".bmp", FileMode.Open)
        'fs = New FileStream(Application.StartupPath & "pic\" & ggg &, FileMode.Open)
        br = New BinaryReader(fs)
        Dim imgbyte(fs.Length) As Byte
        imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length)))
        If Me.ComboBox1.Text = "" Then
            Me.ComboBox1.Text = "Non"
        End If
        Dim ss As String = "insert into DOCUMENT(FNUMBER,ANALYSIS,XRAY,PHOTOGRAPH,MXPORTS,PATHPIC,IMG,DATED,notex)VALUES(XXX1,XXX2,XXX3,XXX4,XXX5,XXX6,XXX7,XXX8,xxx9)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.TextBox1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.CheckBox1.Checked)
        cmm.Parameters.AddWithValue("xx3", Me.CheckBox2.Checked)
        cmm.Parameters.AddWithValue("xx4", Me.CheckBox3.Checked)
        cmm.Parameters.AddWithValue("xx5", Me.CheckBox4.Checked)
        cmm.Parameters.AddWithValue("xx6", Me.TextBox2.Text)
        cmm.Parameters.AddWithValue("xx7", imgbyte)
        cmm.Parameters.AddWithValue("xx8", Date.Today)
        cmm.Parameters.AddWithValue("xx9", Me.ComboBox1.Text)

        Try
            cmm.ExecuteNonQuery()
            MsgBox(" „ «·Õ›Ÿ ")
        Catch ex As Exception
            MsgBox(" ·«Ì„ﬂ‰ «·Õ›Ÿ ")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim s As String = "update appointment set visit=xx1 where fnumber=x1 and datea=x2"
        'Dim cm As New SqlClient.SqlCommand(s, cn)
        'cm.Parameters.AddWithValue("x1", TextBox1.Text)
        'cm.Parameters.AddWithValue("x2", Date.Today)
        'cm.Parameters.AddWithValue("xx1", "1")

        Dim s20 As String = "update Appointment set visit=XX2 where fnumber=XXX"
        Dim cm20 As New SqlClient.SqlCommand(s20, cn)
        ' cm20.Parameters.AddWithValue("XX3", Me.DateTimePicker1.Text)
        cm20.Parameters.AddWithValue("XX2", Me.Label9.Text)
        cm20.Parameters.AddWithValue("XXX", Me.TextBox1.Text)

        Try
            cm20.ExecuteNonQuery()
            MsgBox("VISIT")
        Catch ex As Exception
            MsgBox("")
        End Try
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim ss1 As String = "insert into Treatment_planing(IDPAT,Proucedure)VALUES(XXX1,XXX2)"
        Dim cmm1 As New SqlClient.SqlCommand(ss1, cn)
        cmm1.Parameters.AddWithValue("xxx1", Me.TextBox1.Text)
        cmm1.Parameters.AddWithValue("xxx2", Me.TextBox5.Text)
        Try
            cmm1.ExecuteNonQuery()
            ' MsgBox(" „ «·Õ›Ÿ ")
            Me.TextBox5.Text = ""
            Dim s1 As String = "select * from TREATMENT_PLANING "
            Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            Dim dss As New DataSet
            dss.Clear()
            aad.Fill(dss, "TREATMENT_PLANING")
            Dim vd As New DataView(dss.Tables("TREATMENT_PLANING"))
            vd.RowFilter = "IDPAT=" & "'" & TextBox1.Text & "'" & ""
            Me.DataGridView1.DataMember = ""
            DataGridView1.DataSource = vd
        Catch ex As Exception
            MsgBox(" ·«Ì„ﬂ‰ «·Õ›Ÿ ")
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Select Case e.ColumnIndex
            Case 0
                dgxx = Val(Me.DataGridView1.CurrentCell.Value.ToString)
                If dgxx <> "" Then
                    Me.Label8.Text = dgxx
                    Dim del As String = "delete * from TREATMENT_PLANING where id=xxx"
                    Dim delcm As New SqlClient.SqlCommand(del, cn)
                    delcm.Parameters.AddWithValue("xxx", Me.Label8.Text)
                    If MsgBox("are you sure ... delete Planing", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        delcm.ExecuteNonQuery()
                    End If
                End If
        End Select
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Me.MaskedTextBox1.Text = Me.DateTimePicker2.Text
        Dim ss2 As String = "insert into Treatment_Visits(IDPAT,Visit,Datet)VALUES(XXXX1,XXXX2,XXXX3)"
        Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
        cmm2.Parameters.AddWithValue("xxxx1", Me.TextBox1.Text)
        cmm2.Parameters.AddWithValue("xxxx2", Me.TextBox7.Text)
        cmm2.Parameters.AddWithValue("xxxx3", Me.MaskedTextBox1.Text)
        Try
            cmm2.ExecuteNonQuery()
            ' MsgBox(" „ «·Õ›Ÿ ")
            Me.TextBox7.Text = ""
            Me.MaskedTextBox1.Text = ""
            Dim s1 As String = "select * from Treatment_Visits "
            Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            Dim dss As New DataSet
            dss.Clear()
            aad.Fill(dss, "Treatment_Visits")
            Dim vd As New DataView(dss.Tables("Treatment_Visits"))
            vd.RowFilter = "IDPAT=" & "'" & TextBox1.Text & "'" & ""
            Me.DataGridView2.DataMember = ""
            DataGridView2.DataSource = vd

        Catch ex As Exception
            MsgBox(" ·«Ì„ﬂ‰ «·Õ›Ÿ ")
        End Try

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Dim ss22 As String = "insert into Pharmacy(fnumber,Medicine,Dosage,Dateph,doctorna)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5)"
        Dim cmm22 As New SqlClient.SqlCommand(ss22, cn)
        cmm22.Parameters.AddWithValue("xxxx1", Me.TextBox1.Text)
        cmm22.Parameters.AddWithValue("xxxx2", Me.ComboBox3.Text)
        cmm22.Parameters.AddWithValue("xxxx3", Me.ComboBox5.Text)
        cmm22.Parameters.AddWithValue("xxxx4", Me.DateTimePicker1.Text)
        cmm22.Parameters.AddWithValue("xxxx5", Me.Label7.Text)
        Try
            cmm22.ExecuteNonQuery()
            '  MsgBox(" „ «·Õ›Ÿ ")
            Me.ComboBox3.Text = ""
            Me.ComboBox5.Text = ""
            Dim s11 As String = "select * from pharmacy "
            Dim aad1 As New SqlClient.SqlDataAdapter(s11, cn)
            Dim dss1 As New DataSet
            dss1.Clear()
            aad1.Fill(dss1, "pharmacy")
            Dim vd1 As New DataView(dss1.Tables("pharmacy"))
            vd1.RowFilter = "fnumber=" & "'" & TextBox1.Text & "'" & ""
            Me.DataGridView4.DataMember = ""
            DataGridView4.DataSource = vd1

        Catch ex As Exception
            MsgBox(" PHARMACY ·«Ì„ﬂ‰ «·Õ›Ÿ ")
        End Try

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Select Case e.ColumnIndex
            Case 0
                dgxx = Val(Me.DataGridView2.CurrentCell.Value.ToString)
                If dgxx <> "" Then
                    Me.Label8.Text = dgxx
                    Dim del As String = "delete * from Treatment_Visits where id=xxx"
                    Dim delcm As New SqlClient.SqlCommand(del, cn)
                    delcm.Parameters.AddWithValue("xxx", Me.Label8.Text)
                    If MsgBox("are you sure ... delete Visit", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        delcm.ExecuteNonQuery()
                    End If
                End If
        End Select
    End Sub

    Private Sub DataGridView4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        Select Case e.ColumnIndex
            Case 0
                dgxx = Val(Me.DataGridView4.CurrentCell.Value.ToString)
                If dgxx <> "" Then
                    Me.Label8.Text = dgxx
                    Dim del As String = "delete * from Pharmacy where id=xxx"
                    Dim delcm As New SqlClient.SqlCommand(del, cn)
                    delcm.Parameters.AddWithValue("xxx", Me.Label8.Text)
                    If MsgBox("are you sure ... delete Medicine", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        delcm.ExecuteNonQuery()
                    End If
                End If
        End Select
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.DateTimePicker2.Focus()
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub DateTimePicker2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.PictureBox5.Focus()
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.ComboBox5.Focus()
        End If

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub ComboBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox5.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.PictureBox7.Focus()
        End If

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.TabPage3.Focus() Then
            Me.Button2.Enabled = False
        End If
    End Sub

    Private Sub PictureBox29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox29.Click
        Me.TextBox2.Text = ""
        Me.TextBox2.Focus()
    End Sub

    Private Sub PictureBox15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Me.TextBox15.Text = ""
        Me.TextBox15.Focus()
    End Sub

    Private Sub PictureBox16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        Me.TextBox4.Text = ""
        Me.TextBox4.Focus()
    End Sub

    Private Sub PictureBox30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        Me.TextBox14.Text = ""
        Me.TextBox14.Focus()
    End Sub

    Private Sub PictureBox31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox31.Click
        Me.TextBox12.Text = ""
        Me.TextBox12.Focus()
    End Sub

    Private Sub PictureBox32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox32.Click
        Me.TextBox13.Text = ""
        Me.TextBox13.Focus()
    End Sub

    Private Sub PictureBox33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox33.Click
        Me.RichTextBox5.Text = ""
        Me.RichTextBox5.Focus()
    End Sub

    Private Sub PictureBox34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox34.Click
        Me.RichTextBox6.Text = ""
        Me.RichTextBox6.Focus()
    End Sub

    Private Sub PictureBox35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox35.Click
        Me.RichTextBox7.Text = ""
        Me.RichTextBox7.Focus()
    End Sub

    Private Sub PictureBox36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox36.Click
        Me.RichTextBox8.Text = ""
        Me.RichTextBox8.Focus()
    End Sub

    Private Sub PictureBox37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox37.Click
        Me.RichTextBox9.Text = ""
        Me.RichTextBox9.Focus()
    End Sub

    Private Sub PictureBox38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox38.Click
        Me.RichTextBox10.Text = ""
        Me.RichTextBox10.Focus()
    End Sub

    Private Sub PictureBox39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox39.Click
        Me.RichTextBox11.Text = ""
        Me.RichTextBox11.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        OpenFileDialog1.Filter = "Images|*.BMP;*.GIF;*.TIF;*.JPG"
        OpenFileDialog1.ShowDialog()
        Try
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Me.PictureBox1.Enabled = True
        Catch ex As Exception
            MsgBox("Ì—ÃÏ «Œ Ì«— „·› «··ÊÕ… «·„—«œ Õ›ŸÂ«")
        End Try
        pinm = (System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName) + (TextBox1.Text))
        TextBox2.Text = pinm
        Me.PictureBox28.Enabled = True
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.Filter = "Images|*.BMP;*.GIF;*.TIF;*.JPG"
        OpenFileDialog1.ShowDialog()
        Try
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Me.PictureBox1.Enabled = True
        Catch ex As Exception
            MsgBox("Ì—ÃÏ «Œ Ì«— „·› «··ÊÕ… «·„—«œ Õ›ŸÂ«")
        End Try
        pinm = (System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName) + (TextBox1.Text))
        TextBox2.Text = pinm
        Me.PictureBox28.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim serlab As String = "delete * from labdoc where fnumber=xx"
        Dim cmlab As New SqlClient.SqlCommand(serlab, cn)
        cmlab.Parameters.AddWithValue("xx", Me.TextBox1.Text)
        Dim rd As SqlClient.SqlDataReader = cmlab.ExecuteReader
        If rd.Read = True Then
            cmlab.ExecuteNonQuery()
        End If

        Dim s As String = "insert into labdoc(fnumber,L1,L2,L3,L4,L5,L6,L7,L8,L9,L10,L11,L12,L13,L14,L15,L16,L17,L18,L19,L20,L21,L22,L23,L24,L25,L26,L27,L28) values(xx1,x1,x2,x3,x4,x5,x6,x7,x8,x9,x10,x11,x12,x13,x14,x15,x16,x17,x18,x19,x20,x21,x22,x23,x24,x25,x26,x27,x28)"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("xx1", Me.TextBox1.Text)
        cm.Parameters.AddWithValue("x1", Me.CheckBox5.Checked)
        cm.Parameters.AddWithValue("x2", Me.CheckBox6.Checked)
        cm.Parameters.AddWithValue("x3", Me.CheckBox7.Checked)
        cm.Parameters.AddWithValue("x4", Me.CheckBox8.Checked)
        cm.Parameters.AddWithValue("x5", Me.CheckBox9.Checked)
        cm.Parameters.AddWithValue("x6", Me.CheckBox10.Checked)
        cm.Parameters.AddWithValue("x7", Me.CheckBox11.Checked)
        cm.Parameters.AddWithValue("x8", Me.CheckBox12.Checked)
        cm.Parameters.AddWithValue("x9", Me.CheckBox13.Checked)
        cm.Parameters.AddWithValue("x10", Me.CheckBox14.Checked)
        cm.Parameters.AddWithValue("x11", Me.CheckBox15.Checked)
        cm.Parameters.AddWithValue("x12", Me.CheckBox16.Checked)
        cm.Parameters.AddWithValue("x13", Me.CheckBox17.Checked)
        cm.Parameters.AddWithValue("x14", Me.CheckBox18.Checked)
        cm.Parameters.AddWithValue("x15", Me.CheckBox19.Checked)
        Try
            cm.ExecuteNonQuery()
            MsgBox("Done")
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub CheckBox33_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click

    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click

    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click

    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub CheckBox32_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox31_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox30_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox29_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox28_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox27_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox26_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox25_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox21_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox24_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox25_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox26_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox27_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox28_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox29_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim serlab As String = "delete * from labdoc where fnumber=xx"
        Dim cmlab As New SqlClient.SqlCommand(serlab, cn)
        cmlab.Parameters.AddWithValue("xx", Me.TextBox1.Text)
        Dim rd As SqlClient.SqlDataReader = cmlab.ExecuteReader
        If rd.Read = True Then
            cmlab.ExecuteNonQuery()
        End If

        Dim s As String = "insert into labdoc(fnumber,L1,L2,L3,L4,L5,L6,L7,L8,L9,L10,L11,L12,L13,L14,L15,L16,L17,L18,L19,L20) values(xx1,x1,x2,x3,x4,x5,x6,x7,x8,x9,x10,x11,x12,x13,x14,x15,X16,X17,X18,X19,X20)"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("xx1", Me.TextBox1.Text)
        cm.Parameters.AddWithValue("x1", Me.CheckBox5.Checked)
        cm.Parameters.AddWithValue("x2", Me.CheckBox6.Checked)
        cm.Parameters.AddWithValue("x3", Me.CheckBox7.Checked)
        cm.Parameters.AddWithValue("x4", Me.CheckBox8.Checked)
        cm.Parameters.AddWithValue("x5", Me.CheckBox9.Checked)
        cm.Parameters.AddWithValue("x6", Me.CheckBox10.Checked)
        cm.Parameters.AddWithValue("x7", Me.CheckBox11.Checked)
        cm.Parameters.AddWithValue("x8", Me.CheckBox12.Checked)
        cm.Parameters.AddWithValue("x9", Me.CheckBox13.Checked)
        cm.Parameters.AddWithValue("x10", Me.CheckBox14.Checked)
        cm.Parameters.AddWithValue("x11", Me.CheckBox15.Checked)
        cm.Parameters.AddWithValue("x12", Me.CheckBox16.Checked)
        cm.Parameters.AddWithValue("x13", Me.CheckBox17.Checked)
        cm.Parameters.AddWithValue("x14", Me.CheckBox18.Checked)
        cm.Parameters.AddWithValue("x15", Me.CheckBox19.Checked)
        cm.Parameters.AddWithValue("x16", Me.CheckBox20.Checked)
        cm.Parameters.AddWithValue("x17", Me.CheckBox21.Checked)
        cm.Parameters.AddWithValue("x18", Me.CheckBox22.Checked)
        cm.Parameters.AddWithValue("x19", Me.CheckBox23.Checked)
        cm.Parameters.AddWithValue("x20", Me.CheckBox24.Checked)
        Try
            cm.ExecuteNonQuery()
            MsgBox("Done")
        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub

    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub TextBox39_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox38_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox37_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox36_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox35_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox34_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox33_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox32_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox31_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox51_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox30_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox50_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox49_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox48_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox47_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox46_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox45_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox44_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox23_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox43_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox42_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox41_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage6.Click

    End Sub

    Private Sub DocumentBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentBindingSource.CurrentChanged

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub GroupBox19_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox19.Enter

    End Sub

    Private Sub TREATMENTPLANINGBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TREATMENTPLANINGBindingSource.CurrentChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub GroupBox17_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox17.Enter

    End Sub

    Private Sub GroupBox21_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox21.Enter

    End Sub

    Private Sub GroupBox22_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox22.Enter

    End Sub

    Private Sub TREATMENTVISITSBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TREATMENTVISITSBindingSource.CurrentChanged

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub GroupBox18_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox18.Enter

    End Sub

    Private Sub GroupBox24_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox24.Enter

    End Sub

    Private Sub DbsbhDataSet6BindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DbsbhDataSet6BindingSource.CurrentChanged

    End Sub

    Private Sub PharmacyBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PharmacyBindingSource.CurrentChanged

    End Sub

    Private Sub GroupBox23_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox23.Enter

    End Sub

    Private Sub GroupBox20_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox20.Enter

    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GroupBox12_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub GroupBox15_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox15.Enter

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub GroupBox11_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox11.Enter

    End Sub

    Private Sub TextBox17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub GroupBox25_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox25.Enter

    End Sub

    Private Sub DocumentBindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentBindingSource1.CurrentChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox10_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox10.Enter

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox27_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox27.Enter

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox31_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox31.Enter

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub GroupBox28_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox28.Enter

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub GroupBox29_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox29.Enter

    End Sub

    Private Sub GroupBox32_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox32.Enter

    End Sub

    Private Sub GroupBox33_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox33.Enter

    End Sub

    Private Sub GroupBox34_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox34.Enter

    End Sub

    Private Sub GroupBox35_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox35.Enter

    End Sub

    Private Sub GroupBox36_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox36.Enter

    End Sub

    Private Sub GroupBox37_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox37.Enter

    End Sub

    Private Sub RichTextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox11.TextChanged

    End Sub

    Private Sub GroupBox38_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox38.Enter

    End Sub

    Private Sub TabPage5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub GroupBox8_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox8.Enter

    End Sub

    Private Sub GroupBox9_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox9.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox13_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox13.Enter

    End Sub

    Private Sub GroupBox14_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox14.Enter

    End Sub

    Private Sub MainBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainBindingSource.CurrentChanged

    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub GroupBox16_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox16.Enter

    End Sub

    Private Sub GroupBox26_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox26.Enter

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub GroupBox39_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox39.Enter

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub CheckBox33_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.CheckBox33.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND ANALYSIS=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox33.Checked = True
            Me.CheckBox4.Checked = False
            Me.CheckBox1.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False Then
                Me.CheckBox33.Checked = True
            End If

        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.CheckBox2.Checked = True Then
            Dim sdX As String = "select * from DOCUMENT "
            Dim aaddX As New SqlClient.SqlDataAdapter(sdX, cn)
            Dim dssdX As New DataSet
            dssdX.Clear()
            aaddX.Fill(dssdX, "DOCUMENT")
            Dim vddX As New DataView(dssdX.Tables("DOCUMENT"))
            vddX.RowFilter = "FNUMBER=" & "'" & TextBox3.Text & "'" & "AND XRAY=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddX

            Me.CheckBox2.Checked = True
            Me.CheckBox3.Checked = False
            Me.CheckBox33.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox1.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox33.Checked = False Then
                Me.CheckBox2.Checked = True
            End If
            ' Me.CheckBox1.Checked = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.CheckBox3.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND PHOTOGRAPH=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = True
            Me.CheckBox33.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox1.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox33.Checked = False Then
                Me.CheckBox3.Checked = True
            End If
            'Me.CheckBox1.Checked = True
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.CheckBox4.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND MXPORTS=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox33.Checked = False
            Me.CheckBox4.Checked = True
            Me.CheckBox1.Checked = False

        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox33.Checked = False Then
                Me.CheckBox4.Checked = True
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.CheckBox1.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND others=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox33.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox1.Checked = True

        Else
            If Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox33.Checked = False Then
                Me.CheckBox1.Checked = True
            End If
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND ANALYSIS=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox5.Checked = False Then
                Me.CheckBox1.Checked = True
            End If

        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If Me.CheckBox2.Checked = True Then
            Dim sdX As String = "select * from DOCUMENT "
            Dim aaddX As New SqlClient.SqlDataAdapter(sdX, cn)
            Dim dssdX As New DataSet
            dssdX.Clear()
            aaddX.Fill(dssdX, "DOCUMENT")
            Dim vddX As New DataView(dssdX.Tables("DOCUMENT"))
            vddX.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND XRAY=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddX

            Me.CheckBox1.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox5.Checked = False Then
                Me.CheckBox2.Checked = True
            End If
            ' Me.CheckBox1.Checked = True
        End If


    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If Me.CheckBox3.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND PHOTOGRAPH=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.CheckBox4.Checked = False
            Me.CheckBox5.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox5.Checked = False Then
                Me.CheckBox3.Checked = True
            End If
            'Me.CheckBox1.Checked = True
        End If


    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If Me.CheckBox4.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND MXPORTS=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox5.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox5.Checked = False Then
                Me.CheckBox4.Checked = True
            End If
            'Me.CheckBox1.Checked = True

        End If

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.CheckBox5.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND others=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox1.Checked = False
            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox4.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False And Me.CheckBox5.Checked = False Then
                Me.CheckBox5.Checked = True
            End If
            'Me.CheckBox1.Checked = True

        End If


    End Sub

    Private Sub CheckBox33_CheckedChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox33.CheckedChanged
        If Me.CheckBox33.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND ANALYSIS=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox2.Checked = False
            Me.CheckBox3.Checked = False
            Me.CheckBox33.Checked = True
            Me.CheckBox4.Checked = False
            Me.CheckBox1.Checked = False
        Else
            If Me.CheckBox1.Checked = False And Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False And Me.CheckBox4.Checked = False Then
                Me.CheckBox33.Checked = True
            End If
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmCBC
        F.ShowDialog()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmHormonalAssay
        F.ShowDialog()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmTiriod
        F.ShowDialog()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmTorch
        F.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmProthonbin
        F.ShowDialog()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmLFT
        F.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmRFT
        F.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmBioChem
        F.ShowDialog()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmElectrolytes
        F.ShowDialog()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmUrine
        F.ShowDialog()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmSemen
        F.ShowDialog()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmWidal
        F.ShowDialog()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmVirology
        F.ShowDialog()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmSerology
        F.ShowDialog()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        dgx = Me.TextBox1.Text
        Dim F As New FrmEIA
        F.ShowDialog()
    End Sub

    Private Sub CheckBox25_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox25.CheckedChanged
        If Me.CheckBox25.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND ANALYSIS=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox26.Checked = False
            Me.CheckBox27.Checked = False
            Me.CheckBox28.Checked = False
            Me.CheckBox29.Checked = False
        Else
            If Me.CheckBox26.Checked = False And Me.CheckBox27.Checked = False And Me.CheckBox28.Checked = False And Me.CheckBox29.Checked = False Then
                Me.CheckBox25.Checked = True
            End If
        End If

    End Sub

    Private Sub CheckBox26_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox26.CheckedChanged
        If Me.CheckBox26.Checked = True Then
            Dim sdX As String = "select * from DOCUMENT "
            Dim aaddX As New SqlClient.SqlDataAdapter(sdX, cn)
            Dim dssdX As New DataSet
            dssdX.Clear()
            aaddX.Fill(dssdX, "DOCUMENT")
            Dim vddX As New DataView(dssdX.Tables("DOCUMENT"))
            vddX.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND XRAY=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddX

            Me.CheckBox25.Checked = False
            Me.CheckBox27.Checked = False
            Me.CheckBox28.Checked = False
            Me.CheckBox29.Checked = False
        Else
            If Me.CheckBox25.Checked = False And Me.CheckBox27.Checked = False And Me.CheckBox28.Checked = False And Me.CheckBox29.Checked = False Then
                Me.CheckBox26.Checked = True
            End If
            ' Me.CheckBox1.Checked = True
        End If

    End Sub

    Private Sub CheckBox27_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox27.CheckedChanged
        If Me.CheckBox27.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND PHOTOGRAPH=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox25.Checked = False
            Me.CheckBox26.Checked = False
            Me.CheckBox28.Checked = False
            Me.CheckBox29.Checked = False
        Else
            If Me.CheckBox25.Checked = False And Me.CheckBox26.Checked = False And Me.CheckBox28.Checked = False And Me.CheckBox29.Checked = False Then
                Me.CheckBox27.Checked = True
            End If
            'Me.CheckBox1.Checked = True
        End If

    End Sub

    Private Sub CheckBox28_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox28.CheckedChanged
        If Me.CheckBox28.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND MXPORTS=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox25.Checked = False
            Me.CheckBox26.Checked = False
            Me.CheckBox27.Checked = False
            Me.CheckBox29.Checked = False
        Else
            If Me.CheckBox25.Checked = False And Me.CheckBox26.Checked = False And Me.CheckBox27.Checked = False And Me.CheckBox29.Checked = False Then
                Me.CheckBox28.Checked = True
            End If
            'Me.CheckBox1.Checked = True

        End If

    End Sub

    Private Sub CheckBox29_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox29.CheckedChanged
        If Me.CheckBox29.Checked = True Then
            Dim sdu As String = "select * from DOCUMENT "
            Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
            Dim dssdu As New DataSet
            dssdu.Clear()
            aaddu.Fill(dssdu, "DOCUMENT")
            Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
            vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND ANALYSIS=" & "'" & True & "'" & ""
            Me.DataGridView5.DataMember = ""
            DataGridView5.DataSource = vddu

            Me.CheckBox25.Checked = False
            Me.CheckBox26.Checked = False
            Me.CheckBox27.Checked = False
            Me.CheckBox28.Checked = False
        Else
            If Me.CheckBox25.Checked = False And Me.CheckBox26.Checked = False And Me.CheckBox27.Checked = False And Me.CheckBox28.Checked = False Then
                Me.CheckBox29.Checked = True
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Dim sdu As String = "select * from DOCUMENT "
        Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
        Dim dssdu As New DataSet
        dssdu.Clear()
        aaddu.Fill(dssdu, "DOCUMENT")
        Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
        vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND ANALYSIS=" & "'" & True & "'" & ""
        Me.DataGridView5.DataMember = ""
        DataGridView5.DataSource = vddu
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Dim sdX As String = "select * from DOCUMENT "
        Dim aaddX As New SqlClient.SqlDataAdapter(sdX, cn)
        Dim dssdX As New DataSet
        dssdX.Clear()
        aaddX.Fill(dssdX, "DOCUMENT")
        Dim vddX As New DataView(dssdX.Tables("DOCUMENT"))
        vddX.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND XRAY=" & "'" & True & "'" & ""
        Me.DataGridView5.DataMember = ""
        DataGridView5.DataSource = vddX
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Dim sdu As String = "select * from DOCUMENT "
        Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
        Dim dssdu As New DataSet
        dssdu.Clear()
        aaddu.Fill(dssdu, "DOCUMENT")
        Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
        vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND PHOTOGRAPH=" & "'" & True & "'" & ""
        Me.DataGridView5.DataMember = ""
        DataGridView5.DataSource = vddu
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Dim sdu As String = "select * from DOCUMENT "
        Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
        Dim dssdu As New DataSet
        dssdu.Clear()
        aaddu.Fill(dssdu, "DOCUMENT")
        Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
        vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND MXPORTS=" & "'" & True & "'" & ""
        Me.DataGridView5.DataMember = ""
        DataGridView5.DataSource = vddu
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Dim sdu As String = "select * from DOCUMENT "
        Dim aaddu As New SqlClient.SqlDataAdapter(sdu, cn)
        Dim dssdu As New DataSet
        dssdu.Clear()
        aaddu.Fill(dssdu, "DOCUMENT")
        Dim vddu As New DataView(dssdu.Tables("DOCUMENT"))
        vddu.RowFilter = "FNUMBER=" & "'" & TextBox1.Text & "'" & "AND ANALYSIS=" & "'" & True & "'" & ""
        Me.DataGridView5.DataMember = ""
        DataGridView5.DataSource = vddu
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Dim serlab As String = "delete * from REPORT where fnumber=xx"
        Dim cmlab As New SqlClient.SqlCommand(serlab, cn)
        cmlab.Parameters.AddWithValue("xx", Me.TextBox6.Text)
        Dim rd As SqlClient.SqlDataReader = cmlab.ExecuteReader
        If rd.Read = True Then
            cmlab.ExecuteNonQuery()
        End If

        Dim s As String = "insert into REPORT(fnumber,NAMEH,NAMEW,AGEH,AGEW,DATEMA,FEMALE,MALE) values(xx1,x1,x2,x3,x4,x5,x6,X7)"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("xx1", Me.TextBox6.Text)
        cm.Parameters.AddWithValue("x1", Me.ComboBox14.Text)
        cm.Parameters.AddWithValue("x2", Me.ComboBox15.Text)
        cm.Parameters.AddWithValue("x3", Me.TextBox9.Text)
        cm.Parameters.AddWithValue("x4", Me.TextBox16.Text)
        cm.Parameters.AddWithValue("x5", Me.DateTimePicker3.Text)
        cm.Parameters.AddWithValue("x6", Me.TextBox10.Text)
        cm.Parameters.AddWithValue("x7", Me.TextBox11.Text)
        Try
            cm.ExecuteNonQuery()
            vv1 = Me.TextBox6.Text
            Dim F As New FrmReportViewer2
            F.ShowDialog()
        Catch ex As Exception
            MsgBox("·« Ì„ﬂ‰ ⁄—÷ «· ﬁ—Ì—")
        End Try

    End Sub
End Class
