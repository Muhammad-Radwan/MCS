Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Math
'Imports System.Math
Public Class sanad
    Friend KESEM_P As String
    Friend NAMEC As String
    Friend HOR As String
    Friend USER_NAME As String

    Private Sub sanad_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        dgx = dgxx
    End Sub

    Private Sub sanad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbsbhDataSet8.SADAD' table. You can move, or remove it, as needed.
        'Me.SADADTableAdapter.Fill(Me.DbsbhDataSet8.SADAD)
        'حذفالسدادToolStripMenuItem.Visible = t19
        dgxx = 0
        'TODO: This line of code loads data into the 'DbsDataSet6.sadad' table. You can move, or remove it, as needed.
        'Me.SadadTableAdapter1.Fill(Me.DbsDataSet6.sadad)
        'TODO: This line of code loads data into the 'DbsDataSet5.sadad' table. You can move, or remove it, as needed.
        'Me.SadadTableAdapter.Fill(Me.DbsDataSet5.sadad)
        TextBox1.Text = dgx
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim sras As String = "select * from MAIN where FNUMBER=@FNUMBER"
        Dim cmras As New SqlClient.SqlCommand(sras, cn)
        cmras.Parameters.AddWithValue("@FNUMBER", CInt(fnumberx))
        Dim rdras As SqlClient.SqlDataReader = cmras.ExecuteReader
        If rdras.Read = True Then
            TextBox2.Text = rdras!nameX
            TextBox7.Focus()
        End If
        TextBox7.Focus()
        Call Class4.CONNIC()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dgx = TextBox7.Text
        Call Class1.CONNIC()

        'Dim sd As String = "delete * from hala_esh1"
        'Dim cmd As New SqlClient.SqlCommand(sd, cn)
        'cmd.ExecuteNonQuery()
        'Dim k As Integer = 1
        'Do While k < 10
        '    Dim i As Integer
        '    i = Me.Label3.Text
        '    Dim s As String = "select * from sadad where ESALNO=@ESALNO "
        '    Dim cm As New SqlClient.SqlCommand(s, cn)
        '    cm.Parameters.Add("@ESALNO", i)
        '    Dim rd As OleDb.OleDbDataReader
        '    rd = cm.ExecuteReader
        '    Do While rd.Read = True
        '        rd.Close()
        '        i = i + 1
        '        Dim ss As String = "select * from sadad where ESALNO=@ESALNO "
        '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        '        cmm.Parameters.Add("@ESALNO", i)
        '        ' Dim rdd As OleDb.OleDbDataReader
        '        rd = cmm.ExecuteReader
        '        Me.Label3.Text = i
        '    Loop
        '    rd.Close()
        '    k = k + 1
        'Loop
        Dim d As String = "delete from hala_esh1"
        Dim cmddd As New SqlClient.SqlCommand(d, cn)
        cmddd.ExecuteNonQuery()
        Dim s203 As String = "INSERT INTO HALA_ESH1(MONO,MADFO,EDATE,NOTES,SANO,MASRAF,ch,esalno) VALUES(@MONO,@MADFO,@EDATE,@NOTES,@SANO,@MASRAF,@ch,@esalno)"
        Dim cm203 As New SqlClient.SqlCommand(s203, cn)
        cm203.Parameters.AddWithValue("@MONO", Me.TextBox1.Text)
        cm203.Parameters.AddWithValue("@MADFO", Me.TextBox7.Text)
        cm203.Parameters.AddWithValue("@EDATE", Me.DateTimePicker1.Text)
        cm203.Parameters.AddWithValue("@NOTES", Me.TextBox11.Text)
        cm203.Parameters.AddWithValue("@SANO", Me.TextBox10.Text)
        cm203.Parameters.AddWithValue("@MASRAF", Me.TextBox9.Text)
        cm203.Parameters.AddWithValue("@ch", "1")
        cm203.Parameters.AddWithValue("@esalno", Me.Label3.Text)

        Try
            cm203.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("hala_esh1")
        End Try
        Dim s204 As String = "INSERT INTO sadad(nofatora,sadad,DATEXX,NOTES,SANO,MASRAF,ch,esalno) VALUES(@nofatora,@sadad,@DATEXX,@NOTES,@SANO,@MASRAF,@ch,@esalno)"
        Dim cm204 As New SqlClient.SqlCommand(s204, cn)
        cm204.Parameters.AddWithValue("@nofatora", Me.TextBox1.Text)
        cm204.Parameters.AddWithValue("@sadad", Me.TextBox7.Text)
        cm204.Parameters.AddWithValue("@DATEXX", Me.DateTimePicker1.Text)
        cm204.Parameters.AddWithValue("@NOTES", Me.TextBox11.Text)
        cm204.Parameters.AddWithValue("@SANO", Me.TextBox10.Text)
        cm204.Parameters.AddWithValue("@MASRAF", Me.TextBox9.Text)
        cm204.Parameters.AddWithValue("@ch", "1")
        cm204.Parameters.AddWithValue("@esalno", CInt(0))
        Try
            cm204.ExecuteNonQuery()
            MsgBox("تم السداد")
            Call Class1.CONNIC()
            Dim Str As String = "SELECT MAX(ID) FROM SADAD "
            Using cmd As New SqlClient.SqlCommand(Str, cn)
                M6 = cmd.ExecuteScalar
            End Using
            'Try
            '    Dim cr2 As New CrystalReport43, cri2 As String
            '    cri2 = "{KASHEF.ESALNO}=" & "" & M6 & ""
            '    KESEM_P = kesemx
            '    USER_NAME = user
            '    HOR = HANY(Me.TextBox7.Text, "IRAQ")
            '    'RM = New Resources.ResourceManager("MCS.Resources", System.Reflection.Assembly.GetExecutingAssembly)
            '    NAMEC = "مستشفى التميز التخصصي" 'RM.GetString("NAMECLINIC")
            '    cr2.SetParameterValue(0, Me.NAMEC)
            '    cr2.SetParameterValue(1, Me.HOR)
            '    cr2.SetParameterValue(2, Me.KESEM_P)
            '    cr2.SetParameterValue(3, Me.USER_NAME)
            '    cr2.RecordSelectionFormula = cri2
            '    'cr2.PrintOptions.PrinterName = "HP1102"
            '    cr2.SetDatabaseLogon("adgh", "13061982", "SYSLC\SQLEXPRESS", "clinicsql")
            '    cr2.PrintToPrinter(1, False, 1, 1)
            'Catch ex As Exception
            '    MsgBox(ex)
            'End Try
            dgxx = dgxx + dgx
            Me.Button1.Enabled = True
            Me.Button3.Enabled = False
            Dim ss As String = "select * from sadad "
            Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
            Dim dss As New DataSet
            dss.Clear()
            aad.Fill(dss, "sadad")
            Dim vdd As New DataView(dss.Tables("sadad"))
            vdd.RowFilter = " nofatora =" & "'" & Me.TextBox1.Text & "'" & ""
            DataGridView1.DataMember = ""
            DataGridView1.DataSource = vdd
            '   Dim IX As Integer

            'Dim ser As String = "select * FROM EESAL where mono=xx1 "
            'Dim cm1 As New SqlClient.SqlCommand(ser, cn)
            'cm1.Parameters.Add("xx1", Me.TextBox1.Text)
            'Dim rd1 As OleDb.OleDbDataReader
            'rd1 = cm1.ExecuteReader
            'If rd1.Read = True Then
            '    Me.Label2.Text = rd1!MAXمنID
            'End If
        Catch ex As Exception
            MsgBox("لم يتم التسديد")
        End Try
        ''Dim report2 As New CrystalReport2
        'report2.Load(serv & "CrystalReport2.rpt") 'your report file and path
        ''if you normally setlogon and paramaters and stuff do that here
        ''report.PrintOptions.PrinterName = "Send To OneNote 2010" 'your windows printer name
        'report2.PrintToPrinter(1, False, 0, 0)
        'Me.Dispose()
        'MessageBox.Show("تمت الطباعة", "تنبية")
        'End If
        Call Class4.CONNIC()
        Call Class1.CONNIC()
        Dim ser As String = "select * FROM Hala_Esh1 where mono=@mono "
        Dim cm1 As New SqlClient.SqlCommand(ser, cn)
        cm1.Parameters.AddWithValue("@mono", Me.TextBox1.Text)
        Dim rd1 As SqlClient.SqlDataReader
        rd1 = cm1.ExecuteReader
        If rd1.Read = True Then
            A1 = rd1!madfo
            A2 = rd1!Esalno
        End If
        'Dim ser1 As String = "select * FROM EYWAA where nofatora=@nofatora"
        'Dim cm11 As New SqlClient.SqlCommand(ser1, cn)
        'cm11.Parameters.AddWithValue("@nofatora", Me.TextBox1.Text)
        'Dim rd11 As SqlClient.SqlDataReader
        'rd11 = cm11.ExecuteReader
        'If rd11.Read = True Then
        '    a3 = rd11!namez
        'End If
        vv2 = Me.TextBox1.Text
        vv1 = Me.TextBox1.Text
        'Dim f As New Form38
        'f.x1 = Me.TextBox3.Text
        'f.Madfo = a2
        'f.Esal = a1
        'f.Namez = a3
        'f.e = user
        'f.ShowDialog()
        Call Class4.CONNIC()

    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.TextBox7.Text = "" Then
                MsgBox("أرجو ادخال قيمة الايصال")
                Me.TextBox7.Focus()

            Else
                TextBox3.Text = HANY(Me.TextBox7.Text, "IRAQ")
                Me.DateTimePicker1.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub DateTimePicker1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox11.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.TextBox11.Text = "" Then
                Me.TextBox11.Text = "بلا"
            End If
            Call Class1.CONNIC()
            Dim us As String = "select * from sadad where nofatora=@nofatora "
            Dim cmu As New SqlClient.SqlCommand(us, cn)
            cmu.Parameters.AddWithValue("@nofatora", Me.TextBox1.Text)
            Dim rdu As SqlClient.SqlDataReader = cmu.ExecuteReader
            Do While rdu.Read = True
                Me.Label1.Text = rdu!id
                Dim su As String = "update sadad set ch=@ch where id=@id"
                Dim cmuu As New SqlClient.SqlCommand(su, cn)
                cmuu.Parameters.AddWithValue("@ch", Me.Label1.Text)
                cmuu.Parameters.AddWithValue("@id", "0")
                Try
                    cmuu.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("لا لالالالالالالا")
                End Try
            Loop

            Me.RadioButton4.Focus()
            Call Class4.CONNIC()

        End If
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Class1.CONNIC()
        Dim ser As String = "select * FROM sadad where Esalno=@Esalno "
        Dim cm1 As New SqlClient.SqlCommand(ser, cn)
        cm1.Parameters.AddWithValue("@Esalno", Me.Label2.Text)
        Dim rd1 As SqlClient.SqlDataReader
        rd1 = cm1.ExecuteReader
        If rd1.Read = True Then
            A1 = rd1!madfo
            A2 = rd1!Esalno
        End If
        'Dim ser1 As String = "select * FROM m2 where nofatora=xx1 "
        'Dim cm11 As New SqlClient.SqlCommand(ser1, cn)
        'cm11.Parameters.Add("xx1", Me.TextBox1.Text)
        'Dim rd11 As OleDb.OleDbDataReader
        'rd11 = cm11.ExecuteReader
        'If rd11.Read = True Then
        '    a3 = rd11!namez
        'End If
        vv2 = Me.Label2.Text
        vv1 = Me.TextBox1.Text
        'Dim f As New Form38
        'f.Madfo = a2
        'f.Esal = a1
        'f.Namez = a3
        'f.e = user
        'f.x1 = Me.TextBox3.Text
        'fp = 10
        'f.ShowDialog()
        Call Class4.CONNIC()

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RadioButton4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox10.Text = "بلا"
            Me.TextBox9.Text = "بلا"
            Me.Button3.Focus()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RadioButton3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox10.Focus()
        End If
    End Sub

    Private Sub TextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox9.Focus()
        End If
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.Button3.Focus()
        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'If Asc(e.KeyChar) = Keys.Enter Then
        '    Dim sd As String = "delete * from hala_esh1"
        '    Dim cmd As New SqlClient.SqlCommand(sd, cn)
        '    cmd.ExecuteNonQuery()
        '    Dim s As String = "select * from MAIN_EM where MONO=xx1 "
        '    Dim cm As New SqlClient.SqlCommand(s, cn)
        '    cm.Parameters.Add("xx1", Me.TextBox1.Text)
        '    Dim rd As OleDb.OleDbDataReader
        '    rd = cm.ExecuteReader
        '    If rd.Read = True Then
        '        Me.Label5.Text = rd!id
        '        Me.TextBox2.Text = rd!MONA
        '        Me.TextBox7.Focus()
        '        Dim ss As String = "select * from HALA_ESH_EM "
        '        Dim aad As New OleDb.OleDbDataAdapter(ss, cn)
        '        Dim dss As New DataSet
        '        dss.Clear()
        '        aad.Fill(dss, "HALA_ESH_EM")
        '        Dim vdd As New DataView(dss.Tables("HALA_ESH_EM"))
        '        vdd.RowFilter = " mono =" & "'" & Me.TextBox1.Text & "'" & ""
        '        DataGridView1.DataMember = ""
        '        DataGridView1.DataSource = vdd
        '        Me.Button1.Enabled = False
        '        Me.Button3.Enabled = True
        '        'Me.Label4.Text = rd!TASTATE
        '        'If Me.Label4.Text = "1" Then
        '        '    MsgBox("هذا الطالب منسحب")
        '        '    Me.TextBox1.Text = ""
        '        '    Me.TextBox2.Text = ""
        '        '    Me.TextBox1.Focus()

        '        'End If

        '    Else
        '        MsgBox("رقم الموظف غير موجود")
        '        Me.TextBox1.Focus()
        '    End If
        'End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call Class1.CONNIC()
        Dim ss As String = "select * from sadad "
        Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "sadad")
        Dim vdd As New DataView(dss.Tables("sadad"))
        vdd.RowFilter = " nofatora =" & "'" & Me.TextBox1.Text & "'" & ""
        DataGridView1.DataMember = ""
        DataGridView1.DataSource = vdd
        Call Class4.CONNIC()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Select Case e.ColumnIndex
            Case 0
                Call Class1.CONNIC()
                dgx = DataGridView1.CurrentCell.Value
                Me.Label2.Text = dgx
                Dim sskh3 As String = "select * from sadad where ESALNO=@ESALNO "
                Dim cmmmd3 As New SqlClient.SqlCommand(sskh3, cn)
                cmmmd3.Parameters.AddWithValue("@ESALNO", Me.Label2.Text)
                Dim RDD3 As SqlClient.SqlDataReader = cmmmd3.ExecuteReader
                If RDD3.Read = True Then
                    Me.TextBox7.Text = RDD3!MADFO
                End If
                Dim dds As String = "delete * from sadad where ESALNO=@ESALNO"
                Dim ddcm As New SqlClient.SqlCommand(dds, cn)
                ddcm.Parameters.AddWithValue("@ESALNO", Me.Label2.Text)
                Try
                    If MsgBox("هــل تـريد حذف السداد ؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ddcm.ExecuteNonQuery()
                        MsgBox("تمت عملية حذف السداد")
                        dgxx = dgxx - Val(Me.TextBox7.Text)
                        Me.DataGridView1.DataSource = ""
                        Me.TextBox1.Text = ""
                        Me.TextBox2.Text = ""
                        Me.TextBox3.Text = ""
                        Me.TextBox7.Text = ""
                        Me.TextBox9.Text = ""
                        Me.TextBox10.Text = ""
                        Me.TextBox11.Text = ""
                    End If

                Catch ex As Exception
                    MsgBox("خطأ ...لم يتم الحذف")
                End Try
                Call Class4.CONNIC()
        End Select
    End Sub

    Private Sub GroupBox17_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox17.Enter

    End Sub

    Private Sub حذفوطباعةايصالToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حذفوطباعةايصالToolStripMenuItem.Click

        'Select Case num
        '    Case Is >= 0
        '        dgx = DataGridView1.Item(0, num).Value()
        Call Class1.CONNIC()
        Me.Label2.Text = dgx
        Dim sskh3 As String = "select * from sadad where ID=@ID "
        Dim cmmmd3 As New SqlClient.SqlCommand(sskh3, cn)
        cmmmd3.Parameters.AddWithValue("@ID", CInt(Me.Label2.Text))
        Dim RDD3 As SqlClient.SqlDataReader = cmmmd3.ExecuteReader
        If RDD3.Read = True Then
            Me.TextBox7.Text = RDD3!SADAD
        End If
        Dim s204 As String = "INSERT INTO sadad(nofatora,SADAD,DATEXX,NOTES,SANO,MASRAF,ch,esalno) VALUES(@nofatora,@SADAD,@DATEXX,@NOTES,@SANO,@MASRAF,@ch,@esalno)"
        Dim cm204 As New SqlClient.SqlCommand(s204, cn)
        cm204.Parameters.AddWithValue("@nofatora", Me.TextBox1.Text)
        cm204.Parameters.AddWithValue("@SADAD", -Me.TextBox7.Text)
        cm204.Parameters.AddWithValue("@DATEXX", Date.Now.Date)
        cm204.Parameters.AddWithValue("@NOTES", "استرجاع")
        cm204.Parameters.AddWithValue("@SANO", Me.TextBox10.Text)
        cm204.Parameters.AddWithValue("@MASRAF", Me.TextBox9.Text)
        cm204.Parameters.AddWithValue("@ch", "1")
        cm204.Parameters.AddWithValue("@esalno", Me.Label2.Text)
        Try
            If MsgBox("هــل تـريد استرجاع القيمه ؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cm204.ExecuteNonQuery()
                MsgBox("تمت عملية الاسترجاع ")
                dgxx = dgxx - Val(Me.TextBox7.Text)
                TextBox3.Text = HANY(Me.TextBox7.Text, "IRAQ")
                Dim f As New Form60
                f.x1 = Me.TextBox3.Text
                f.Madfo = TextBox7.Text
                f.Esal = Label2.Text
                f.Namez = TextBox2.Text
                f.e = user
                f.ShowDialog()
                Me.DataGridView1.DataSource = ""
                Me.TextBox1.Text = ""
                Me.TextBox2.Text = ""
                Me.TextBox3.Text = ""
                Me.TextBox7.Text = ""
                Me.TextBox9.Text = ""
                Me.TextBox10.Text = ""
                Me.TextBox11.Text = ""
            End If

        Catch ex As Exception
            MsgBox("خطأ ...لم يتم الحذف")
        End Try
        'End Select
        'Select Case num
        '    Case 0
        '        dgx = DataGridView1.CurrentCell.Value
        '        Me.Label2.Text = dgx
        '        Dim sskh3 As String = "select * from sadad where ESALNO=xxx1 "
        '        Dim cmmmd3 As New SqlClient.SqlCommand(sskh3, cn)
        '        cmmmd3.Parameters.Add(xxx1, Me.Label2.Text)
        '        Dim RDD3 As OleDb.OleDbDataReader = cmmmd3.ExecuteReader
        '        If RDD3.Read = True Then
        '            Me.TextBox7.Text = RDD3!MADFO
        '            a1 = RDD3!madfo
        '            a2 = RDD3!Esalno
        '            TextBox1.Text = RDD3!nofatora
        '            TextBox10.Text = RDD3!sano
        '            TextBox9.Text = RDD3!masraf
        '            Label3.Text = RDD3!esalno
        '        End If
        '        Dim sskh33 As String = "select * from m2 where nofatora=xxx1 "
        '        Dim cmmmd33 As New SqlClient.SqlCommand(sskh33, cn)
        '        cmmmd33.Parameters.Add(xxx1, Me.TextBox1.Text)
        '        Dim RDD33 As OleDb.OleDbDataReader = cmmmd33.ExecuteReader
        '        If RDD33.Read = True Then
        '            a3 = RDD33!Namez
        '        End If
        '        dgxx = dgxx - Val(Me.TextBox7.Text)
        '        TextBox7.Text = 0 - Val(Me.TextBox7.Text)
        '        Dim s204 As String = "INSERT INTO sadad(nofatora,madfo,EDATE,NOTES,SANO,MASRAF,ch,esalno) VALUES(XX1,XX2,XX3,XX4,XX5,XX6,xx7,xx8)"
        '        Dim cm204 As New SqlClient.SqlCommand(s204, cn)
        '        cm204.Parameters.Add("XX1", Me.TextBox1.Text)
        '        cm204.Parameters.Add("XX2", Me.TextBox7.Text)
        '        cm204.Parameters.Add("XX3", Date.Now.Date)
        '        cm204.Parameters.Add("XX4", "استرجاع")
        '        cm204.Parameters.Add("XX5", Me.TextBox10.Text)
        '        cm204.Parameters.Add("XX6", Me.TextBox9.Text)
        '        cm204.Parameters.Add("xx7", "1")
        '        cm204.Parameters.Add("xx8", Me.Label3.Text)
        '        'Try

        '        'Catch ex As Exception

        '        'End Try
        '        ''cm204.ExecuteNonQuery()

        '        'Dim dds As String = "delete * from sadad where ESALNO=xxx"
        '        'Dim ddcm As New SqlClient.SqlCommand(dds, cn)
        '        'ddcm.Parameters.Add("xxx", Me.Label2.Text)
        '        Try
        '            If MsgBox("هــل تـريد ارجاع القيمة؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '                'ddcm.ExecuteNonQuery()
        '                cm204.ExecuteNonQuery()
        '                MsgBox("تمت عملية ارجاع القيمة")
        '                dgxx = dgxx - Abs(Val(Me.TextBox7.Text))
        '                Me.DataGridView1.DataSource = ""
        '                Dim ss As String = "select * from sadad "
        '                Dim aad As New OleDb.OleDbDataAdapter(ss, cn)
        '                Dim dss As New DataSet
        '                dss.Clear()
        '                aad.Fill(dss, "sadad")
        '                Dim vdd As New DataView(dss.Tables("sadad"))
        '                vdd.RowFilter = " nofatora =" & "'" & Me.TextBox1.Text & "'" & ""
        '                DataGridView1.DataMember = ""
        '                DataGridView1.DataSource = vdd
        '            End If
        '            Dim f As New Form39
        '            f.x1 = Me.TextBox3.Text
        '            f.Madfo = a1
        '            f.Esal = a2
        '            f.Namez = a3
        '            f.e = user
        '            f.ShowDialog()
        '        Catch ex As Exception
        '            MsgBox("خطأ ...لم يتم الاسترجاع")
        '        End Try
        'End Select
        Call Class4.CONNIC()

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub حذفالسدادToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حذفالسدادToolStripMenuItem.Click
        Select Case num
            Case 0
                Call Class4.CONNIC()
                dgx = DataGridView1.CurrentCell.Value
                Me.Label2.Text = dgx
                Dim sskh3 As String = "select * from sadad where ESALNO=@ESALNO "
                Dim cmmmd3 As New SqlClient.SqlCommand(sskh3, cn)
                cmmmd3.Parameters.AddWithValue("@ESALNO", Me.Label2.Text)
                Dim RDD3 As SqlClient.SqlDataReader = cmmmd3.ExecuteReader
                If RDD3.Read = True Then
                    Me.TextBox7.Text = RDD3!MADFO
                End If
                Dim dds As String = "delete * from sadad where ESALNO=@ESALNO"
                Dim ddcm As New SqlClient.SqlCommand(dds, cn)
                ddcm.Parameters.AddWithValue("@ESALNO", Me.Label2.Text)
                Try
                    If MsgBox("هــل تـريد الحذف ؟", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ddcm.ExecuteNonQuery()
                        MsgBox("تمت عملية الحذف ")
                        dgxx = dgxx - Val(Me.TextBox7.Text)
                        Me.DataGridView1.DataSource = ""
                        Me.TextBox1.Text = ""
                        Me.TextBox2.Text = ""
                        Me.TextBox3.Text = ""
                        Me.TextBox7.Text = ""
                        Me.TextBox9.Text = ""
                        Me.TextBox10.Text = ""
                        Me.TextBox11.Text = ""
                    End If

                Catch ex As Exception
                    MsgBox("خطأ ...لم يتم الحذف")
                End Try
                Call Class4.CONNIC()
        End Select
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        Select Case e.RowIndex
            Case Is >= 0
                dgx = DataGridView1.Item(0, e.RowIndex).Value()
                Me.Label2.Text = dgx
                'Dim sskh2 As String = "select * from m2 where nofatora=xxx1 "
                'Dim cmmmd2 As New SqlClient.SqlCommand(sskh2, cn)
                'cmmmd2.Parameters.Add(xxx1, Me.TextBox1.Text)
                'Dim RDD2 As SqlClient.SqlDataReader = cmmmd2.ExecuteReader
                'If RDD2.Read = True Then
                '    Me.TextBox1.Text = RDD2!nofatora
                '    Me.TextBox2.Text = RDD2!namez
                'End If
                Call Class1.CONNIC()
                Dim sskh3 As String = "select * from sadad where ID=@ID "
                Dim cmmmd3 As New SqlClient.SqlCommand(sskh3, cn)
                cmmmd3.Parameters.AddWithValue("@ID", CInt(Me.Label2.Text))
                Dim RDD3 As SqlClient.SqlDataReader = cmmmd3.ExecuteReader
                If RDD3.Read = True Then
                    Me.TextBox1.Text = RDD3!nofatora
                    Me.TextBox7.Text = RDD3!SADAD
                    Me.DateTimePicker1.Text = RDD3!DATEXX
                    Me.TextBox11.Text = RDD3!NOTES
                    TextBox3.Text = HANY(Me.TextBox7.Text, "IRAQ")
                End If
                Me.Button1.Enabled = True
                Me.Button3.Enabled = False
                Call Class4.CONNIC()

        End Select

    End Sub
End Class