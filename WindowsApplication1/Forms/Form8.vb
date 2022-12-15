Public Class Form8

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub
    '    Public tc2 As String
    '    Public tc3 As String
    '    Public tc4 As String
    '    Public tc5 As String
    '    Public tc6 As String
    '    Public tc7 As String
    '    Public tc8 As String
    '    Public tc9 As String
    '    Public tc10 As String
    '    Public tc11 As String
    '    Public tc12 As String
    '    Public tc13 As String
    '    Public tc14 As String
    '    Public tc15 As String
    '    Public tc16 As String
    '    Public tc17 As String
    '    Public tc18 As String
    '    Public tc19 As String
    '    Public tc20 As String
    '    Public tc21 As String
    '    Public tc22 As String
    '    Public tc23 As String
    '    Public tc24 As String
    '    Public tc25 As String
    '    Public tc26 As String
    '    Public tc27 As String
    '    Public tc28 As String
    '    Public tc29 As String
    '    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    '    End Sub

    '    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    '    End Sub

    '    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '        Me.TextBox1.Text = ""
    '        Me.TextBox2.Text = ""
    '        Me.TextBox3.Text = ""
    '        Me.TextBox4.Text = ""
    '        Me.TextBox5.Text = ""
    '        Me.TextBox6.Text = ""
    '        Me.TextBox7.Text = ""
    '        Me.TextBox8.Text = ""
    '        Me.TextBox9.Text = ""
    '        Me.TextBox10.Text = ""
    '        Me.TextBox11.Text = ""
    '        Me.TextBox12.Text = ""
    '        Me.TextBox13.Text = ""
    '        Me.TextBox14.Text = ""
    '        Me.TextBox15.Text = ""
    '        Me.TextBox16.Text = ""
    '        Me.TextBox17.Text = ""
    '        Me.TextBox18.Text = ""
    '        Me.TextBox19.Text = ""
    '        Me.TextBox20.Text = ""
    '        Me.TextBox21.Text = ""
    '        Me.TextBox22.Text = ""
    '        Me.TextBox23.Text = ""
    '        Me.TextBox24.Text = ""
    '        Me.TextBox25.Text = ""
    '        Me.TextBox26.Text = ""
    '        Me.TextBox27.Text = ""
    '        Me.TextBox28.Text = ""
    '        Me.Label2.Text = ""
    '        Me.Label4.Text = ""
    '        Me.Label6.Text = ""
    '        Me.Label28.Text = ""
    '    End Sub

    '    Private Sub TextBox24_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox24.TextChanged

    '    End Sub

    '    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    '    End Sub

    '    Private Sub GroupBox14_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox14.Enter

    '    End Sub

    '    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '        'Dim sh As String = "select * from main where fnumber=xxx1 "
    '        'Dim cmh As New SqlClient.SqlCommand(sh, cn)
    '        'cmh.Parameters.AddWithValue("xxx1", TextBox1.Text)
    '        'Dim rdh As SqlClient.SqlDataReader = cmh.ExecuteReader
    '        'If rdh.Read = True Then
    '        '    Me.Label2.Text = rdh!namex

    '        '    Me.Label4.Text = rdh!age
    '        '    Me.Label6.Text = rdh!phone
    '        '                'pinm = TextBox6.Text

    '        'Else
    '        '    'Me.Button2.Visible = True
    '        'End If
    '        'Dim shh As String = "select * from lab where fnumber=xxx1 "
    '        'Dim cmhh As New SqlClient.SqlCommand(shh, cn)
    '        'cmhh.Parameters.AddWithValue("xxx1", TextBox1.Text)
    '        'Dim rdhh As SqlClient.SqlDataReader = cmhh.ExecuteReader
    '        'Dim t2 As String

    '        'If rdhh.Read = True Then
    '        '    TextBox2.Text = rdhh!haemoglobin
    '        '    t2 = TextBox2.Text
    '        '    TextBox3.Text = rdhh!platelet
    '        '    TextBox4.Text = rdhh!gue
    '        '    TextBox5.Text = rdhh!rbsugar
    '        '    TextBox6.Text = rdhh!tsh
    '        '    TextBox7.Text = rdhh!t3
    '        '    TextBox8.Text = rdhh!t4
    '        '    TextBox9.Text = rdhh!cholesterol
    '        '    TextBox10.Text = rdhh!tg
    '        '    TextBox11.Text = rdhh!urea
    '        '    TextBox12.Text = rdhh!creatinine
    '        '    TextBox13.Text = rdhh!tsbilirubin
    '        '    TextBox14.Text = rdhh!sgot
    '        '    TextBox15.Text = rdhh!sgpt
    '        '    TextBox16.Text = rdhh!alp
    '        '    TextBox17.Text = rdhh!oestrogen
    '        '    TextBox18.Text = rdhh!progesteron
    '        '    TextBox19.Text = rdhh!fsh
    '        '    TextBox20.Text = rdhh!amh
    '        '    TextBox21.Text = rdhh!lh
    '        '    TextBox22.Text = rdhh!prolactin
    '        '    TextBox23.Text = rdhh!testosterone
    '        '    TextBox24.Text = rdhh!bloodgroup
    '        '    TextBox25.Text = rdhh!dna
    '        '    TextBox26.Text = rdhh!hbgroup
    '        '    TextBox27.Text = rdhh!hdna
    '        '    TextBox28.Text = rdhh!semen
    '        '    TextBox29.Text = rdhh!others
    '        '    Me.DateTimePicker1.Value = rdhh!dfsh
    '        '    Me.DateTimePicker2.Value = rdhh!damh
    '        '    Me.DateTimePicker3.Value = rdhh!dlh
    '        '    Me.DateTimePicker4.Value = rdhh!dprolactin
    '        '    Me.DateTimePicker5.Value = rdhh!doestrogen
    '        '    Me.DateTimePicker6.Value = rdhh!dprogesteron
    '        '    Me.DateTimePicker7.Value = rdhh!dtestosterone
    '        '    Me.DateTimePicker8.Value = rdhh!ddd

    '        '    tc2 = TextBox2.Text
    '        '    tc3 = TextBox3.Text
    '        '    tc4 = TextBox4.Text
    '        '    tc5 = TextBox5.Text
    '        '    tc6 = TextBox6.Text
    '        '    tc7 = TextBox7.Text
    '        '    tc8 = TextBox8.Text
    '        '    tc9 = TextBox9.Text
    '        '    tc10 = TextBox10.Text
    '        '    tc11 = TextBox11.Text
    '        '    tc12 = TextBox12.Text
    '        '    tc13 = TextBox13.Text
    '        '    tc14 = TextBox14.Text
    '        '    tc15 = TextBox15.Text
    '        '    tc16 = TextBox16.Text
    '        '    tc17 = TextBox17.Text
    '        '    tc18 = TextBox18.Text
    '        '    tc19 = TextBox19.Text
    '        '    tc20 = TextBox20.Text
    '        '    tc21 = TextBox21.Text
    '        '    tc22 = TextBox22.Text
    '        '    tc23 = TextBox23.Text
    '        '    tc24 = TextBox24.Text
    '        '    tc25 = TextBox25.Text
    '        '    tc26 = TextBox26.Text
    '        '    tc27 = TextBox27.Text
    '        '    tc28 = TextBox28.Text
    '        '    'Me.Label4.Text = rdhh!age
    '        '    'Me.Label6.Text = rdhh!phone
    '        '    ''pinm = TextBox6.Text

    '        'Else
    '        '    'Me.Button2.Visible = True
    '        'End If

    '        Dim f As New Form23
    '        f.ShowDialog()
    '        Me.Label4.Text = dgx
    '        Dim s As String = "select * from lab where fnumber=xx1 "
    '        Dim cm As New SqlClient.SqlCommand(s, cn)
    '        cm.Parameters.AddWithValue("xx1", Me.Label4.Text)
    '        Dim rdA As SqlClient.SqlDataReader
    '        rdA = cm.ExecuteReader
    '        If rdA.Read = True Then
    '            TextBox1.Text = rdA!fnumber
    '            TextBox2.Text = rdA!haemoglobin
    '            t2 = TextBox2.Text
    '            TextBox3.Text = rdA!platelet
    '            TextBox4.Text = rdA!gue
    '            TextBox5.Text = rdA!rbsugar
    '            TextBox6.Text = rdA!tsh
    '            TextBox7.Text = rdA!t3
    '            TextBox8.Text = rdA!t4
    '            TextBox9.Text = rdA!cholesterol
    '            TextBox10.Text = rdA!tg
    '            TextBox11.Text = rdA!urea
    '            TextBox12.Text = rdA!creatinine
    '            TextBox13.Text = rdA!tsbilirubin
    '            TextBox14.Text = rdA!sgot
    '            TextBox15.Text = rdA!sgpt
    '            TextBox16.Text = rdA!alp
    '            TextBox17.Text = rdA!oestrogen
    '            TextBox18.Text = rdA!progesteron
    '            TextBox19.Text = rdA!fsh
    '            TextBox20.Text = rdA!amh
    '            TextBox21.Text = rdA!lh
    '            TextBox22.Text = rdA!prolactin
    '            TextBox23.Text = rdA!testosterone
    '            TextBox24.Text = rdA!bloodgroup
    '            TextBox25.Text = rdA!dna
    '            TextBox26.Text = rdA!hbgroup
    '            TextBox27.Text = rdA!hdna
    '            TextBox28.Text = rdA!semen
    '            TextBox29.Text = rdA!others
    '            Me.DateTimePicker1.Value = rdA!dfsh
    '            Me.DateTimePicker2.Value = rdA!damh
    '            Me.DateTimePicker3.Value = rdA!dlh
    '            Me.DateTimePicker4.Value = rdA!dprolactin
    '            Me.DateTimePicker5.Value = rdA!doestrogen
    '            Me.DateTimePicker6.Value = rdA!dprogesteron
    '            Me.DateTimePicker7.Value = rdA!dtestosterone
    '            Me.DateTimePicker8.Value = rdA!ddd
    '            Me.TextBox2.Focus()
    '            'Dim sH As String = "select * from khazenaesh where MONO=xx1 "
    '            'Dim cmH As New SqlClient.SqlCommand(sH, cn)
    '            'cmH.Parameters.AddWithValue("xx1", Me.TextBox1.Text)
    '            'Dim rdH As SqlClient.SqlDataReader
    '            'rdH = cmH.ExecuteReader
    '            'If rdH.Read = True Then
    '            '    Me.TextBox8.Text = rdH!EXPR2
    '            'Else
    '            '    Me.TextBox8.Text = "0"
    '            'End If
    '            'Me.Label5.Text = rdA!TASTATE
    '            'If Me.Label5.Text = "1" Then
    '            '    Me.Label3.Visible = True
    '            '    Me.Label2.Visible = False
    '            '    Me.Button8.Visible = True
    '            '    Me.Button7.Visible = False
    '            '    Me.GroupBox12.Visible = False
    '            'Else
    '            '    Me.Label3.Visible = False
    '            '    Me.Label2.Visible = True
    '            '    Me.Button7.Visible = True
    '            '    Me.Button8.Visible = False

    '            'End If

    '        End If
    '        b2 = Me.TextBox1.Text
    '    End Sub

    '    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
    '        'Dim ss As String = "insert into lab(fnumber,haemoglobin,platelet,gue,rbsugar,tsh,t3,t4,cholesterol,tg,urea,creatinine,tsbilirubin,sgot,sgpt,alp,fsh,dfsh,amh,damh,lh,dlh,prolactin,dprolactin,oestrogen,doestrogen,progesteron,dprogesteron,testosterone,dtestosterone,bloodgroup,dna,hbgroup,hdna,semen,others,ddd)values(x1,x2,x3,x4,x5,x6,x7,x8,x9,x10,x11,x12,x13,x14,x15,x16,x17,x18,x19,x20,x21,x22,x23,x24,x25,x26,x27,x28,x29,x30,x31,x32,x33,x34,x35,x36,x37)"
    '        Dim ss As String = "insert into lab(fnumber,haemoglobin,platelet,gue,rbsugar,tsh,t3,t4,cholesterol,tg,urea,creatinine,tsbilirubin,sgot,sgpt,alp,fsh,dfsh,amh,damh,lh,dlh,prolactin,dprolactin,oestrogen,doestrogen,progesteron,dprogesteron,testosterone,dtestosterone,bloodgroup,dna,hbgroup,hdna,semen,others,ddd)values(x1,x2,x3,x4,x5,x6,x7,x8,x9,x10,x11,x12,x13,x14,x15,x16,x17,x18,x19,x20,x21,x22,x23,x24,x25,x26,x27,x28,x29,x30,x31,x32,x33,x34,x35,x36,x37)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("x1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("x2", TextBox2.Text)
    '        cmm.Parameters.AddWithValue("x3", TextBox3.Text)
    '        cmm.Parameters.AddWithValue("x4", TextBox4.Text)
    '        cmm.Parameters.AddWithValue("x5", TextBox5.Text)
    '        cmm.Parameters.AddWithValue("x6", TextBox6.Text)
    '        cmm.Parameters.AddWithValue("x7", TextBox7.Text)
    '        cmm.Parameters.AddWithValue("x8", TextBox8.Text)
    '        cmm.Parameters.AddWithValue("x9", TextBox9.Text)
    '        cmm.Parameters.AddWithValue("x10", TextBox10.Text)
    '        cmm.Parameters.AddWithValue("x11", TextBox11.Text)
    '        cmm.Parameters.AddWithValue("x12", TextBox12.Text)
    '        cmm.Parameters.AddWithValue("x13", TextBox13.Text)
    '        cmm.Parameters.AddWithValue("x14", TextBox14.Text)
    '        cmm.Parameters.AddWithValue("x15", TextBox15.Text)
    '        cmm.Parameters.AddWithValue("x16", TextBox16.Text)
    '        cmm.Parameters.AddWithValue("x17", TextBox19.Text)
    '        cmm.Parameters.AddWithValue("x18", Me.DateTimePicker1.Text)
    '        cmm.Parameters.AddWithValue("x19", TextBox20.Text)
    '        cmm.Parameters.AddWithValue("x20", Me.DateTimePicker2.Text)
    '        cmm.Parameters.AddWithValue("x21", TextBox21.Text)
    '        cmm.Parameters.AddWithValue("x22", Me.DateTimePicker3.Text)
    '        cmm.Parameters.AddWithValue("x23", TextBox22.Text)
    '        cmm.Parameters.AddWithValue("x24", Me.DateTimePicker4.Text)
    '        cmm.Parameters.AddWithValue("x25", TextBox17.Text)
    '        cmm.Parameters.AddWithValue("x26", Me.DateTimePicker5.Text)
    '        cmm.Parameters.AddWithValue("x27", TextBox18.Text)
    '        cmm.Parameters.AddWithValue("x28", Me.DateTimePicker6.Text)
    '        cmm.Parameters.AddWithValue("x29", TextBox23.Text)
    '        cmm.Parameters.AddWithValue("x30", Me.DateTimePicker7.Text)
    '        cmm.Parameters.AddWithValue("x31", TextBox24.Text)
    '        cmm.Parameters.AddWithValue("x32", TextBox25.Text)
    '        cmm.Parameters.AddWithValue("x33", TextBox26.Text)
    '        cmm.Parameters.AddWithValue("x34", TextBox27.Text)
    '        cmm.Parameters.AddWithValue("x35", TextBox28.Text)
    '        cmm.Parameters.AddWithValue("x36", TextBox29.Text)
    '        cmm.Parameters.AddWithValue("x37", Me.DateTimePicker8.Text)

    '        Try
    '            cmm.ExecuteNonQuery()
    '            'Me.Button2.Visible = False

    '            MsgBox("file is create successful")

    '        Catch ex As Exception
    '            MsgBox("error")
    '        End Try

    '    End Sub

    '    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    '    End Sub

    '    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    End Sub

    '    Private Sub TextBox29_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox29.TextChanged

    '    End Sub

    '    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    End Sub

    '    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    '    End Sub

    '    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    End Sub

    '    Private Sub PictureBox15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
    '        If Me.TextBox2.Text = "" Then
    '        Else
    '            Dim ser As String = "select* from history where testtype=xxx1 and datex=xxx2"
    '            Dim cm As New SqlClient.SqlCommand(ser, cn)
    '            cm.Parameters.AddWithValue("xxx1", Me.Label7.Text)
    '            cm.Parameters.AddWithValue("xxx2", Date.Today.Date)
    '            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
    '            If rd.Read = False Then
    '                Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '                Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '                cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '                cmm.Parameters.AddWithValue("xx2", Me.Label7.Text)
    '                cmm.Parameters.AddWithValue("xx3", DateTimePicker1.Value.Date)
    '                cmm.Parameters.AddWithValue("xx4", tc2)
    '                Try
    '                    Dim sss As String = "update lab set haemoglobin=xxx1 where fnumber=xxx "
    '                    Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '                    cmmm.Parameters.AddWithValue("xxx1", Me.TextBox2.Text)
    '                    cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '                    Try
    '                        If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                            cmm.ExecuteNonQuery()
    '                            cmmm.ExecuteNonQuery()
    '                            MsgBox(" „ «· ÕœÌÀ")
    '                        End If
    '                    Catch ex As Exception
    '                        MsgBox("lab")
    '                    End Try

    '                Catch ex As Exception
    '                    MsgBox("history")

    '                End Try
    '            End If
    '        End If
    '    End Sub

    '    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label12.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc7)
    '        Try
    '            Dim sss As String = "update lab set t3=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox7.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    '    End Sub

    '    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label8.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc3)
    '        Try
    '            Dim sss As String = "update lab set platelet=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox3.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try
    '    End Sub

    '    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label3.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc8)
    '        Try
    '            Dim sss As String = "update lab set t4=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox8.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try
    '    End Sub

    '    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label9.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc4)
    '        Try
    '            Dim sss As String = "update lab set gue=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox4.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try
    '    End Sub

    '    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label4.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc9)
    '        Try
    '            Dim sss As String = "update lab set cholesterol=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox9.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try
    '    End Sub

    '    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label10.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc5)
    '        Try
    '            Dim sss As String = "update lab set rbsugar=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox5.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label5.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc10)
    '        Try
    '            Dim sss As String = "update lab set tg=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox10.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label17.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc11)
    '        Try
    '            Dim sss As String = "update lab set urea=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox11.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label18.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc12)
    '        Try
    '            Dim sss As String = "update lab set creatinine=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox12.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label19.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc13)
    '        Try
    '            Dim sss As String = "update lab set tsbilirubin=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox13.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label20.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc14)
    '        Try
    '            Dim sss As String = "update lab set sgot=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox14.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label21.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc15)
    '        Try
    '            Dim sss As String = "update lab set sgot=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox15.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label22.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc16)
    '        Try
    '            Dim sss As String = "update lab set alp=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox16.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label24.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc26)
    '        Try
    '            Dim sss As String = "update lab set hbgroup=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox26.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label25.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc27)
    '        Try
    '            Dim sss As String = "update lab set hdna=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox27.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label23.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc25)
    '        Try
    '            Dim sss As String = "update lab set dna=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox25.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label16.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc24)
    '        Try
    '            Dim sss As String = "update lab set bloodgroup=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox24.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label26.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc28)
    '        Try
    '            Dim sss As String = "update lab set semen=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox28.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.GroupBox7.Text)
    '        cmm.Parameters.AddWithValue("xx3", Me.DateTimePicker1.Text)
    '        cmm.Parameters.AddWithValue("xx4", tc19)
    '        Try
    '            Dim sss As String = "update lab set fsh=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox19.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try
    '    End Sub

    '    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.GroupBox8.Text)
    '        cmm.Parameters.AddWithValue("xx3", Me.DateTimePicker2.Text)
    '        cmm.Parameters.AddWithValue("xx4", tc20)
    '        Try
    '            Dim sss As String = "update lab set amh=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox20.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try
    '    End Sub

    '    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.GroupBox9.Text)
    '        cmm.Parameters.AddWithValue("xx3", Me.DateTimePicker3.Text)
    '        cmm.Parameters.AddWithValue("xx4", tc21)
    '        Try
    '            Dim sss As String = "update lab set lh=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox21.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try
    '    End Sub

    '    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.GroupBox10.Text)
    '        cmm.Parameters.AddWithValue("xx3", Me.DateTimePicker4.Text)
    '        cmm.Parameters.AddWithValue("xx4", tc22)
    '        Try
    '            Dim sss As String = "update lab set prolactin=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox22.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try

    '    End Sub

    '    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.GroupBox11.Text)
    '        cmm.Parameters.AddWithValue("xx3", Me.DateTimePicker5.Text)
    '        cmm.Parameters.AddWithValue("xx4", tc17)
    '        Try
    '            Dim sss As String = "update lab set oestrogen=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox17.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try
    '    End Sub

    '    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.GroupBox12.Text)
    '        cmm.Parameters.AddWithValue("xx3", Me.DateTimePicker6.Text)
    '        cmm.Parameters.AddWithValue("xx4", tc18)
    '        Try
    '            Dim sss As String = "update lab set progesteron=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox18.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try
    '    End Sub

    '    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.GroupBox13.Text)
    '        cmm.Parameters.AddWithValue("xx3", Me.DateTimePicker7.Text)
    '        cmm.Parameters.AddWithValue("xx4", tc23)
    '        Try
    '            Dim sss As String = "update lab set testosterone=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox23.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")

    '        End Try
    '    End Sub

    '    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
    '        Dim sh1 As String = "select * from labdoc where fnumber=xxx1 "
    '        Dim cmh1 As New SqlClient.SqlCommand(sh1, cn)
    '        cmh1.Parameters.AddWithValue("xxx1", TextBox1.Text)
    '        Dim rdh1 As SqlClient.SqlDataReader = cmh1.ExecuteReader
    '        If rdh1.Read = True Then
    '            Me.TextBox2.Visible = rdh1!l1
    '            Me.TextBox7.Visible = rdh1!l2
    '            Me.TextBox3.Visible = rdh1!l4
    '            Me.TextBox8.Visible = rdh1!l3
    '            Me.TextBox4.Visible = rdh1!l5
    '            Me.TextBox9.Visible = rdh1!l6
    '            Me.TextBox5.Visible = rdh1!l7
    '            Me.TextBox10.Visible = rdh1!l8
    '            Me.TextBox6.Visible = rdh1!l9
    '            Me.TextBox11.Visible = rdh1!l10
    '            Me.TextBox12.Visible = rdh1!l11
    '            Me.TextBox13.Visible = rdh1!l12
    '            Me.TextBox14.Visible = rdh1!l13
    '            Me.TextBox15.Visible = rdh1!l14
    '            Me.TextBox16.Visible = rdh1!l15
    '            Me.TextBox19.Visible = rdh1!l16
    '            Me.TextBox20.Visible = rdh1!l17
    '            Me.TextBox21.Visible = rdh1!l18
    '            Me.TextBox22.Visible = rdh1!l19
    '            Me.TextBox17.Visible = rdh1!l20
    '            Me.TextBox18.Visible = rdh1!l21
    '            Me.TextBox23.Visible = rdh1!l22
    '            Me.TextBox24.Visible = rdh1!l23
    '            Me.TextBox25.Visible = rdh1!l24
    '            Me.TextBox27.Visible = rdh1!l25
    '            Me.TextBox28.Visible = rdh1!l27
    '            Me.TextBox29.Visible = rdh1!l28
    '            Me.TextBox26.Visible = rdh1!l26

    '        End If
    '        Dim sh As String = "select * from main where fnumber=xxx1 "
    '        Dim cmh As New SqlClient.SqlCommand(sh, cn)
    '        cmh.Parameters.AddWithValue("xxx1", TextBox1.Text)
    '        Dim rdh As SqlClient.SqlDataReader = cmh.ExecuteReader
    '        If rdh.Read = True Then
    '            Me.Label2.Text = rdh!namex

    '            Me.Label4.Text = rdh!age
    '            Me.Label6.Text = rdh!phone
    '            'pinm = TextBox6.Text

    '        Else
    '            'Me.Button2.Visible = True
    '        End If
    '        Dim shh As String = "select * from lab where fnumber=xxx1 "
    '        Dim cmhh As New SqlClient.SqlCommand(shh, cn)
    '        cmhh.Parameters.AddWithValue("xxx1", TextBox1.Text)
    '        Dim rdhh As SqlClient.SqlDataReader = cmhh.ExecuteReader
    '        Dim t2 As String

    '        If rdhh.Read = True Then
    '            TextBox2.Text = rdhh!haemoglobin
    '            t2 = TextBox2.Text
    '            TextBox3.Text = rdhh!platelet
    '            TextBox4.Text = rdhh!gue
    '            TextBox5.Text = rdhh!rbsugar
    '            TextBox6.Text = rdhh!tsh
    '            TextBox7.Text = rdhh!t3
    '            TextBox8.Text = rdhh!t4
    '            TextBox9.Text = rdhh!cholesterol
    '            TextBox10.Text = rdhh!tg
    '            TextBox11.Text = rdhh!urea
    '            TextBox12.Text = rdhh!creatinine
    '            TextBox13.Text = rdhh!tsbilirubin
    '            TextBox14.Text = rdhh!sgot
    '            TextBox15.Text = rdhh!sgpt
    '            TextBox16.Text = rdhh!alp
    '            TextBox17.Text = rdhh!oestrogen
    '            TextBox18.Text = rdhh!progesteron
    '            TextBox19.Text = rdhh!fsh
    '            TextBox20.Text = rdhh!amh
    '            TextBox21.Text = rdhh!lh
    '            TextBox22.Text = rdhh!prolactin
    '            TextBox23.Text = rdhh!testosterone
    '            TextBox24.Text = rdhh!bloodgroup
    '            TextBox25.Text = rdhh!dna
    '            TextBox26.Text = rdhh!hbgroup
    '            TextBox27.Text = rdhh!hdna
    '            TextBox28.Text = rdhh!semen
    '            TextBox29.Text = rdhh!others
    '            Me.DateTimePicker1.Value = rdhh!dfsh
    '            Me.DateTimePicker2.Value = rdhh!damh
    '            Me.DateTimePicker3.Value = rdhh!dlh
    '            Me.DateTimePicker4.Value = rdhh!dprolactin
    '            Me.DateTimePicker5.Value = rdhh!doestrogen
    '            Me.DateTimePicker6.Value = rdhh!dprogesteron
    '            Me.DateTimePicker7.Value = rdhh!dtestosterone
    '            Me.DateTimePicker8.Value = rdhh!ddd

    '            tc2 = TextBox2.Text
    '            tc3 = TextBox3.Text
    '            tc4 = TextBox4.Text
    '            tc5 = TextBox5.Text
    '            tc6 = TextBox6.Text
    '            tc7 = TextBox7.Text
    '            tc8 = TextBox8.Text
    '            tc9 = TextBox9.Text
    '            tc10 = TextBox10.Text
    '            tc11 = TextBox11.Text
    '            tc12 = TextBox12.Text
    '            tc13 = TextBox13.Text
    '            tc14 = TextBox14.Text
    '            tc15 = TextBox15.Text
    '            tc16 = TextBox16.Text
    '            tc17 = TextBox17.Text
    '            tc18 = TextBox18.Text
    '            tc19 = TextBox19.Text
    '            tc20 = TextBox20.Text
    '            tc21 = TextBox21.Text
    '            tc22 = TextBox22.Text
    '            tc23 = TextBox23.Text
    '            tc24 = TextBox24.Text
    '            tc25 = TextBox25.Text
    '            tc26 = TextBox26.Text
    '            tc27 = TextBox27.Text
    '            tc28 = TextBox28.Text
    '            tc29 = TextBox29.Text
    '            'Me.Label4.Text = rdhh!age
    '            'Me.Label6.Text = rdhh!phone
    '            ''pinm = TextBox6.Text

    '        Else
    '            Me.TextBox2.Text = ""
    '            Me.TextBox3.Text = ""
    '            Me.TextBox4.Text = ""
    '            Me.TextBox5.Text = ""
    '            Me.TextBox6.Text = ""
    '            Me.TextBox7.Text = ""
    '            Me.TextBox8.Text = ""
    '            Me.TextBox9.Text = ""
    '            Me.TextBox10.Text = ""
    '            Me.TextBox11.Text = ""
    '            Me.TextBox12.Text = ""
    '            Me.TextBox13.Text = ""
    '            Me.TextBox14.Text = ""
    '            Me.TextBox15.Text = ""
    '            Me.TextBox16.Text = ""
    '            Me.TextBox17.Text = ""
    '            Me.TextBox18.Text = ""
    '            Me.TextBox19.Text = ""
    '            Me.TextBox20.Text = ""
    '            Me.TextBox21.Text = ""
    '            Me.TextBox22.Text = ""
    '            Me.TextBox23.Text = ""
    '            Me.TextBox24.Text = ""
    '            Me.TextBox25.Text = ""
    '            Me.TextBox26.Text = ""
    '            Me.TextBox27.Text = ""
    '            Me.TextBox28.Text = ""
    '            Me.TextBox29.Text = ""
    '        End If
    '    End Sub

    '    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    '    End Sub

    '    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    End Sub

    '    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label11.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc6)
    '        Try
    '            Dim sss As String = "update lab set tsh=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox6.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try

    '        Catch ex As Exception
    '            MsgBox("history")
    '        End Try
    '    End Sub

    '    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
    '        vv1 = Me.TextBox1.Text
    '        Dim f As New Form21
    '        f.ShowDialog()
    '    End Sub

    '    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
    '        vv1 = Me.TextBox1.Text
    '        Dim f As New Form24
    '        f.ShowDialog()
    '    End Sub

    '    Private Sub PictureBox28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
    '        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
    '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
    '        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
    '        cmm.Parameters.AddWithValue("xx2", Me.Label27.Text)
    '        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
    '        cmm.Parameters.AddWithValue("xx4", tc29)
    '        Try
    '            Dim sss As String = "update lab set others=xxx1 where fnumber=xxx "
    '            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
    '            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox29.Text)
    '            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
    '            Try
    '                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                    cmm.ExecuteNonQuery()
    '                    cmmm.ExecuteNonQuery()
    '                    MsgBox(" „ «· ÕœÌÀ")
    '                End If
    '            Catch ex As Exception
    '                MsgBox("lab")
    '            End Try
    '        Catch ex As Exception
    '            MsgBox("history")
    '        End Try
    '    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click

    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class