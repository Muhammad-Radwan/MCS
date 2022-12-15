Public Class Form16
    Friend X1 As String
    Friend monaX As String
    Friend notex As String
    Friend kemax As Double
    Friend Esalnox As Integer
    Friend CLIN As String
    Friend TEL As String
    Friend sak As String


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        If String.IsNullOrWhiteSpace(ComboBox1.Text) Then
            ComboBox1.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(ComboBox2.Text) Then
            ComboBox2.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(ComboBox4.Text) Then
            ComboBox4.Text = "/"
        End If
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            TextBox2.Text = "0"
        End If

        Dim s222 As String = "insert into loss(lossna,lossva,lossdate,losstype,lossmo,SANO,MASRAF,hesabno,masrafname) values(@X1,@X2,@x3,@x4,@x5,@SANO,@MASRAF,@hesabno,@masrafname)"
        Dim cm222 As New SqlClient.SqlCommand(s222, cn)
        cm222.Parameters.AddWithValue("@X1", CInt(Me.Label2.Text))
        cm222.Parameters.AddWithValue("@X2", Me.TextBox2.Text)
        cm222.Parameters.AddWithValue("@X3", Me.DateTimePicker2.Value)
        cm222.Parameters.AddWithValue("@X4", Me.ComboBox1.Text)
        cm222.Parameters.AddWithValue("@X5", Me.ComboBox4.Text)
        cm222.Parameters.AddWithValue("@SANO", Me.TextBox10.Text)
        cm222.Parameters.AddWithValue("@MASRAF", Me.TextBox9.Text)
        cm222.Parameters.AddWithValue("@hesabno", Me.TextBox4.Text)
        cm222.Parameters.AddWithValue("@masrafname", CInt(Label7.Text))
        Try
            cm222.ExecuteNonQuery()
            MsgBox("تم إضافة القيد")
            Dim Str1 As String = "SELECT MAX(id) FROM loss "
            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
            monaX = Trim(ComboBox2.Text)
            notex = Trim(ComboBox4.Text)
            kemax = (TextBox2.Text)
            TextBox3.Text = HANY((TextBox2.Text), "IRAQ")
            X1 = Me.TextBox3.Text
            Esalnox = CInt(cmd1.ExecuteScalar)
            If NotifyIcons = False Then
                CLIN = "نسخة تجريبية"
            Else
                CLIN = My.Settings.CLIN
            End If
            TEL = My.Settings.TEL
            'If RadioButton3.Checked = True Then
            '    sak = "صك رقم" & vbNewLine & COMBOBOX40.Text
            'Else
            '    sak = "نقدي"
            'End If
            'Dim Str1 As String = "SELECT MAX(ESALNO) FROM HALA_ESH "
            'Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
            'ESALNO = cmd1.ExecuteScalar + 1
            If RadioButton3.Checked = True Then
                sak = "صك رقم" & vbNewLine & TextBox10.Text
            ElseIf RadioButton1.Checked = True Then
                sak = "بطاقة رقم" & vbNewLine & TextBox4.Text
            Else
                sak = "نقدي"
            End If
#Disable Warning BC42024 ' Unused local variable: 'cri'.
            Dim cr2 As New esalmsrofat, cri As String
#Enable Warning BC42024 ' Unused local variable: 'cri'.
            cr2.SetParameterValue(0, Me.X1)
            cr2.SetParameterValue(1, Me.monaX)
            cr2.SetParameterValue(2, Me.notex)
            cr2.SetParameterValue(3, Me.kemax)
            cr2.SetParameterValue(4, Me.Esalnox)
            cr2.SetParameterValue(5, Me.CLIN)
            cr2.SetParameterValue(6, Me.TEL)
            cr2.SetParameterValue(7, Me.sak)
            'cr2.RecordSelectionFormula = cri
            'cr2.PrintOptions.PrinterName = "PR"
            'cr1.PrintOptions.PrinterName = "LK-TE212"
            'cr2.SetDatabaseLogon("adgh", "13061982", "syslc\sqlexpress", "SCHOOLSQL")
            If CheckBox1.Checked = True Then
                cr2.PrintToPrinter(1, False, 1, 1)
            End If
            Dim ss As String = "select * from LOSS "
            Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
            Dim dss As New DataSet
            dss.Clear()
            aad.Fill(dss, "LOSS")
            Dim vdd As New DataView(dss.Tables("LOSS")) With {
                .RowFilter = " LOSSDATE =" & "'" & Date.Now.Date & "'" & ""
            }
            DataGridView1.DataMember = ""
            DataGridView1.DataSource = vdd
            'Dim sk As String
            'sk = "select * from Bloss"
            'Dim adk As New SqlClient.SqlDataAdapter(sk, cn)
            'Dim dsk As New DataSet
            'adk.Fill(dsk, "Bloss")
            'ComboBox2.DataSource = dsk.Tables(0)
            'ComboBox2.DisplayMember = "lossna"
            'ComboBox2.SelectedIndex = -1
            'Dim skK As String
            'skK = "select * from BlossT"
            'Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
            'Dim dskK As New DataSet
            'adkK.Fill(dskK, "BlossT")
            'ComboBox1.DataSource = dskK.Tables(0)
            'ComboBox1.DisplayMember = "lossTYPE"
            'ComboBox1.SelectedIndex = -1
            Me.ComboBox4.Text = ""
            Me.TextBox2.Text = "0"
            Me.ComboBox1.Text = ""
            Me.ComboBox1.Focus()



        Catch ex As Exception
            'MsgBox("خطأ في الترصيد")
            MsgBox(ex.Message)
        End Try
        Dim sk As String
        sk = "select * from SAREFNAME"
        Dim adk As New SqlClient.SqlDataAdapter(sk, cn)
        Dim dsk As New DataSet
        adk.Fill(dsk, "SAREFNAME")
        ComboBox2.DataSource = dsk.Tables(0)
        ComboBox2.DisplayMember = "SAREFNAME"
        ComboBox2.SelectedIndex = -1
        Dim skK As String
        skK = "select * from BlossT"
        Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
        Dim dskK As New DataSet
        adkK.Fill(dskK, "BlossT")
        ComboBox1.DataSource = dskK.Tables(0)
        ComboBox1.DisplayMember = "lossTYPE"
        ComboBox1.SelectedIndex = -1
        Me.ComboBox2.Text = ""
        Me.TextBox2.Text = "0"


        Dim sss As String = "select * from LOSS "
        Dim aads As New SqlClient.SqlDataAdapter(sss, cn)
        Dim dsss As New DataSet
        dsss.Clear()
        aads.Fill(dsss, "LOSS")
        Dim vdds As New DataView(dsss.Tables("LOSS")) With {
            .RowFilter = " LOSSDATE =" & "'" & Date.Now.Date & "'" & ""
        }
        DataGridView1.DataMember = ""
        DataGridView1.DataSource = vdds
        'Dim s22 As String = "insert into bloss(lossna,lossva) values(X1,X2)"
        'Dim cm22 As New SqlClient.SqlCommand(s22, cn)
        'cm22.Parameters.Add("X1", Me.ComboBox1.Text)
        'cm22.Parameters.Add("X2", Me.TextBox2.Text)
        'Try
        '    cm22.ExecuteNonQuery()
        '    MsgBox("تم إضافة القيد")
        '    Dim sk As String
        '    sk = "select * from Bloss"
        '    Dim adk As New SqlClient.SqlDataAdapter(sk, cn)
        '    Dim dsk As New DataSet
        '    adk.Fill(dsk, "Bloss")
        '    ComboBox1.DataSource = dsk.Tables(0)
        '    ComboBox1.DisplayMember = "lossna"
        '    ComboBox1.SelectedIndex = -1
        '    Me.TextBox2.Text = ""
        '    Me.ComboBox1.Text = ""
        '    Me.ComboBox1.Focus()
        'Catch ex As Exception
        '    MsgBox("خطأ في الترصيد")
        'End Try
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        حذفالتقريرToolStripMenuItem.Visible = t9
        'TODO: This line of code loads data into the 'DataSet1.Loss' table. You can move, or remove it, as needed.
        'Me.LossTableAdapter.Fill(Me.DataSet1.Loss)
        'TODO: This line of code loads data into the 'DbsDataSet4.Loss' table. You can move, or remove it, as needed.
        '  Me.LossTableAdapter.Fill(Me.DbsDataSet4.Loss)
        'Dim sk As String
        'sk = "select * from Bloss"
        'Dim adk As New SqlClient.SqlDataAdapter(sk, cn)
        'Dim dsk As New DataSet
        'adk.Fill(dsk, "Bloss")
        'ComboBox2.DataSource = dsk.Tables(0)
        'ComboBox2.DisplayMember = "lossna"
        'ComboBox2.SelectedIndex = -1
        ''Dim skK As String
        ''skK = "select * from lossT"
        ''Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
        ''Dim dskK As New DataSet
        ''adkK.Fill(dskK, "lossT")
        ''ComboBox1.DataSource = dskK.Tables(0)
        ''ComboBox1.DisplayMember = "lossTYPE"
        ''ComboBox1.SelectedIndex = -1
        'Me.ComboBox2.Text = ""
        'Me.TextBox2.Text = ""


        'Dim ss As String = "select * from LOSS "
        'Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
        'Dim dss As New DataSet
        'dss.Clear()
        'aad.Fill(dss, "LOSS")
        'Dim vdd As New DataView(dss.Tables("LOSS"))
        'vdd.RowFilter = " LOSSDATE =" & "'" & Date.Now.Date & "'" & ""
        'DataGridView1.DataMember = ""
        'DataGridView1.DataSource = vdd
        Dim s7 As String
        s7 = "select * from MASRAFNAME "
        Dim ad7 As New SqlClient.SqlDataAdapter(s7, cn)
        Dim ds7 As New DataSet
        ad7.Fill(ds7, "MASRAFNAME")
        ComboBox3.DataSource = ds7.Tables(0)
        ComboBox3.DisplayMember = "MASRAFNAME"
        ComboBox3.SelectedIndex = -1

        Dim sk As String
        sk = "select * from SAREFNAME"
        Dim adk As New SqlClient.SqlDataAdapter(sk, cn)
        Dim dsk As New DataSet
        adk.Fill(dsk, "SAREFNAME")
        ComboBox2.DataSource = dsk.Tables(0)
        ComboBox2.DisplayMember = "SAREFNAME"
        ComboBox2.SelectedIndex = -1
        Dim skK As String
        skK = "select * from BlossT"
        Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
        Dim dskK As New DataSet
        adkK.Fill(dskK, "BlossT")
        ComboBox1.DataSource = dskK.Tables(0)
        ComboBox1.DisplayMember = "lossTYPE"
        ComboBox1.SelectedIndex = -1
        Me.ComboBox2.Text = ""
        Me.TextBox2.Text = "0"

        Dim skKt As String
        skKt = "select * from loss"
        Dim adkKt As New SqlClient.SqlDataAdapter(skKt, cn)
        Dim dskKt As New DataSet
        adkKt.Fill(dskKt, "loss")
        ComboBox4.DataSource = dskKt.Tables(0)
        ComboBox4.DisplayMember = "lossmo"
        ComboBox4.SelectedIndex = -1

        Dim ss As String = "select * from LOSS "
        Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "LOSS")
        Dim vdd As New DataView(dss.Tables("LOSS")) With {
            .RowFilter = " LOSSDATE =" & "'" & Date.Now.Date & "'" & ""
        }
        DataGridView1.DataMember = ""
        DataGridView1.DataSource = vdd
        'ContextMenuStrip2.Enabled = False
        'حذفالتقريرToolStripMenuItem.Visible = False
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ComboBox1.KeyDown
        If Asc(e.KeyCode) = Keys.Enter Then
            If ComboBox1.Text = "" Then
                MsgBox("ارجو ادخال بيان القيد")
                ComboBox1.Focus()
            Else
                ComboBox2.Focus()
            End If
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Dim sskh1 As String = "select * from Bloss where lossna=xx1"
        'Dim cmmmd1 As New SqlClient.SqlCommand(sskh1, cn)
        'cmmmd1.Parameters.Add(xx1, Me.ComboBox1.Text)
        'Dim RDD As SqlClient.SqlDataReader = cmmmd1.ExecuteReader
        'If RDD.Read = True Then
        '    Me.TextBox2.Text = RDD!lossva
        'End If

    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox2.KeyDown
        If Asc(e.KeyCode) = Keys.Enter Then
            If Me.TextBox2.Text = "" Then
                MsgBox("ارجو ادخال القيمة")
                Me.TextBox2.Focus()
            Else
                Me.RadioButton4.Focus()
            End If
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ComboBox2.KeyDown
        If Asc(e.KeyCode) = Keys.Enter Then
            If Me.ComboBox2.Text = "" Then
                MsgBox("أرجو اختيار نوع القيد")
                Me.ComboBox2.Focus()
            Else
                Me.DateTimePicker2.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sH As String = "select * from SAREFNAME where SAREFNAME=@SAREFNAME "
        Dim cmH As New SqlClient.SqlCommand(sH, cn)
        cmH.Parameters.AddWithValue("@SAREFNAME", Trim(Me.ComboBox2.Text))
        Dim rdH As SqlClient.SqlDataReader
        rdH = cmH.ExecuteReader
        If rdH.Read = True Then
            Me.Label2.Text = CInt(rdH!IDSAREF)
        End If
    End Sub

    Private Sub COMBOBOX4_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles ComboBox4.KeyDown
        If Asc(e.KeyCode) = Keys.Enter Then
            If Me.ComboBox4.Text = "" Then
                ComboBox4.Text = "/"
            End If
            Me.TextBox2.Focus()
        End If
    End Sub

    Private Sub COMBOBOX4_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ComboBox4.TextChanged

    End Sub

    Private Sub DateTimePicker2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles DateTimePicker2.KeyDown
        If Asc(e.KeyCode) = Keys.Enter Then
            Me.ComboBox4.Focus()
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DateTimePicker2.ValueChanged
        Call Class1.CONNIC()
        Dim ss As String = "select * from LOSS"
        Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "LOSS")
        Dim vdd As New DataView(dss.Tables("LOSS")) With {
            .RowFilter = " LOSSDATE =" & "#" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "#" & ""
        }
        DataGridView1.DataMember = ""
        DataGridView1.DataSource = vdd
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub عرضالتقريرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عرضالتقريرToolStripMenuItem.Click
        If ComboBox1.Text = "" And ComboBox2.Text = "" Then
            TextBox3.Text = "تقرير عن المصروفات"
            L = 1
        ElseIf ComboBox1.Text = "" And ComboBox2.Text <> "" Then
            TextBox3.Text = "تقرير عن المصروفات المصروفة من قبل" + " " + ComboBox2.Text
            L = 2
        ElseIf ComboBox1.Text <> "" And ComboBox2.Text = "" Then
            TextBox3.Text = "تقرير عن" + " " + ComboBox1.Text
            L = 3
        ElseIf ComboBox1.Text <> "" And ComboBox2.Text <> "" Then
            TextBox3.Text = "تقرير عن" + " " + ComboBox1.Text + " " + "المصروفة من قبل" + " " + ComboBox2.Text
            L = 4
        End If
        vv1 = ComboBox1.Text
        vv2 = ComboBox2.Text
        mo = TextBox3.Text
        fp = 1
        Dim f As New ByDate
        f.ShowDialog()
    End Sub

    Private Sub حذفالمصروفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفالمصروفToolStripMenuItem.Click
        Select Case num
            Case 0
                dgx = DataGridView1.CurrentCell.Value
                Me.Label1.Text = dgx
                Dim sd As String = "delete from LOSS where id=@xx1"
                Dim cd As New SqlClient.SqlCommand(sd, cn)
                cd.Parameters.AddWithValue("@xx1", CInt(Me.Label1.Text))
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
                        Dim vdd As New DataView(dss.Tables("LOSS")) With {
                            .RowFilter = " LOSSDATE =" & "'" & Date.Now.Date & "'" & ""
                        }
                        DataGridView1.DataMember = ""
                        DataGridView1.DataSource = vdd
                    Catch ex As Exception
                        MsgBox("لم يتم الحذف")
                    End Try
                End If
                Dim sk As String
                sk = "select * from Bloss"
                Dim adk As New SqlClient.SqlDataAdapter(sk, cn)
                Dim dsk As New DataSet
                adk.Fill(dsk, "Bloss")
                ComboBox2.DataSource = dsk.Tables(0)
                ComboBox2.DisplayMember = "lossna"
                ComboBox2.SelectedIndex = -1
                Dim skK As String
                skK = "select * from BlossT"
                Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
                Dim dskK As New DataSet
                adkK.Fill(dskK, "BlossT")
                ComboBox1.DataSource = dskK.Tables(0)
                ComboBox1.DisplayMember = "lossTYPE"
                ComboBox1.SelectedIndex = -1
                Me.ComboBox2.Text = ""
                Me.TextBox2.Text = "0"


                Dim sss As String = "select * from LOSS "
                Dim aads As New SqlClient.SqlDataAdapter(sss, cn)
                Dim dsss As New DataSet
                dsss.Clear()
                aads.Fill(dsss, "LOSS")
                Dim vdds As New DataView(dsss.Tables("LOSS")) With {
                    .RowFilter = " LOSSDATE =" & "'" & Date.Now.Date & "'" & ""
                }
                DataGridView1.DataMember = ""
                DataGridView1.DataSource = vdds

        End Select
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.WindowState = FormWindowState.Maximized
        Button11.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.WindowState = FormWindowState.Normal
        Button11.Visible = True
        Button13.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub عرضالتقريرToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles عرضالتقريرToolStripMenuItem1.Click
        monaX = Trim(ComboBox2.Text)
        notex = Trim(ComboBox4.Text)
        kemax = (TextBox2.Text)
        TextBox3.Text = HANY((TextBox2.Text), "IRAQ")
        X1 = Me.TextBox3.Text
        Esalnox = CInt(Label1.Text)
        If NotifyIcons = False Then
            CLIN = "نسخة تجريبية"
        Else
            CLIN = My.Settings.CLIN
        End If
        TEL = My.Settings.TEL
        If RadioButton3.Checked = True Then
            sak = "صك رقم" & vbNewLine & TextBox10.Text
        ElseIf RadioButton1.Checked = True Then
            sak = "بطاقة رقم" & vbNewLine & TextBox4.Text
        Else
            sak = "نقدي"
        End If
#Disable Warning BC42024 ' Unused local variable: 'cri'.
        Dim cr2 As New esalmsrofat, cri As String
#Enable Warning BC42024 ' Unused local variable: 'cri'.
        cr2.SetParameterValue(0, Me.X1)
        cr2.SetParameterValue(1, Me.monaX)
        cr2.SetParameterValue(2, Me.notex)
        cr2.SetParameterValue(3, Me.kemax)
        cr2.SetParameterValue(4, Me.Esalnox)
        cr2.SetParameterValue(5, Me.CLIN)
        cr2.SetParameterValue(6, Me.TEL)
        cr2.SetParameterValue(7, Me.sak)
        cr2.PrintToPrinter(1, False, 1, 1)

    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If e.ColumnIndex < 0 Then
            Return
        End If
        If e.RowIndex < 0 Then
            Return
        End If
        dgx = DataGridView1.Item(0, e.RowIndex).Value
        Me.Label1.Text = dgx
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDown
        ComboBox1.Text = DataGridView1.Item(1, e.RowIndex).Value
        Label2.Text = DataGridView1.Item(2, e.RowIndex).Value
        Call Class1.CONNIC()
        Dim sH As String = "select * from SAREFNAME where IDSAREF=@IDSAREF "
        Dim cmH As New SqlClient.SqlCommand(sH, cn)
        cmH.Parameters.AddWithValue("@IDSAREF", (Label2.Text))
        Dim rdH As SqlClient.SqlDataReader
        rdH = cmH.ExecuteReader
        If rdH.Read = True Then
            Me.ComboBox2.Text = Trim(rdH!SAREFNAME)
        End If
        Dim sskh3 As String = "select * from LOSS where ID=@xxx1 "
        Dim cmmmd3 As New SqlClient.SqlCommand(sskh3, cn)
        cmmmd3.Parameters.AddWithValue("@xxx1", CInt(Me.Label1.Text))
        Dim RDD3 As SqlClient.SqlDataReader = cmmmd3.ExecuteReader
        If RDD3.Read = True Then
            Me.TextBox9.Text = RDD3!masraf
            Me.Label7.Text = CInt(RDD3!masrafname)
            Call Class1.CONNIC()
            Dim sHH As String = "select * from masrafname where IDMASRAF=@xx1 "
            Dim cmHH As New SqlClient.SqlCommand(sHH, cn)
            cmHH.Parameters.AddWithValue("@xx1", Me.Label7.Text)
            Dim rdHH As SqlClient.SqlDataReader
            rdHH = cmHH.ExecuteReader
            If rdHH.Read = True Then
                Me.ComboBox3.Text = Trim(rdHH!masrafname)
            End If
            Me.TextBox4.Text = RDD3!hesabno
            Me.TextBox10.Text = RDD3!SANO
            If TextBox10.Text = "0" Then
                RadioButton4.Checked = True
            ElseIf TextBox10.Text = "بطاقة" Then
                RadioButton1.Checked = True
            Else
                RadioButton3.Checked = True
            End If

        End If
        DateTimePicker2.Text = DataGridView1.Item(3, e.RowIndex).Value.ToString
        ComboBox4.Text = DataGridView1.Item(4, e.RowIndex).Value
        TextBox2.Text = DataGridView1.Item(5, e.RowIndex).Value
        Button1.Visible = True
        Button3.Visible = t2
        Button2.Visible = False
        ContextMenuStrip2.Enabled = True
        حذفالتقريرToolStripMenuItem.Visible = t9
        حذفالمصروفToolStripMenuItem.Visible = t9


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox4.Text = ""
        TextBox2.Text = "0"
        DateTimePicker2.Value = Date.Now.Date
        Button3.Visible = False
        Button1.Visible = False
        Button2.Visible = True
        'ContextMenuStrip2.Enabled = False
        حذفالتقريرToolStripMenuItem.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrWhiteSpace(ComboBox1.Text) Then
            ComboBox1.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(ComboBox2.Text) Then
            ComboBox2.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(ComboBox4.Text) Then
            ComboBox4.Text = "/"
        End If
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            TextBox2.Text = "0"
        End If
        Dim s222 As String = "update loss set lossna=@x1,lossva=@x2,lossdate=@x3,losstype=@x4,lossmo=@x5,SANO=@SANO,MASRAF=@MASRAF,hesabno=@hesabno,masrafname=@masrafname  where id=@id "
        Dim cm222 As New SqlClient.SqlCommand(s222, cn)
        cm222.Parameters.AddWithValue("@X1", CInt(Label2.Text))
        cm222.Parameters.AddWithValue("@X2", Me.TextBox2.Text)
        cm222.Parameters.AddWithValue("@X3", Format(Me.DateTimePicker2.Value, "yyyy/MM/dd"))
        cm222.Parameters.AddWithValue("@X4", Me.ComboBox1.Text)
        cm222.Parameters.AddWithValue("@X5", Me.ComboBox4.Text)
        cm222.Parameters.AddWithValue("@SANO", Me.TextBox10.Text)
        cm222.Parameters.AddWithValue("@MASRAF", Me.TextBox9.Text)
        cm222.Parameters.AddWithValue("@hesabno", Me.TextBox4.Text)
        cm222.Parameters.AddWithValue("@masrafname", CInt(Label7.Text))
        cm222.Parameters.AddWithValue("@id", CInt(Me.Label1.Text))
        Try
            cm222.ExecuteNonQuery()
            MsgBox("تم تعديل المصروف")
            'Dim Str1 As String = "SELECT MAX(id) FROM loss "
            'Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
            monaX = Trim(ComboBox2.Text)
            notex = Trim(ComboBox4.Text)
            kemax = CDec(TextBox2.Text)
            TextBox3.Text = HANY((TextBox2.Text), "IRAQ")
            X1 = Me.TextBox3.Text
            Esalnox = CInt(Label1.Text)
            If NotifyIcons = False Then
                CLIN = "نسخة تجريبية"
            Else
                CLIN = My.Settings.CLIN
            End If
            TEL = My.Settings.TEL
            'If RadioButton3.Checked = True Then
            '    sak = "صك رقم" & vbNewLine & COMBOBOX40.Text
            'Else
            '    sak = "نقدي"
            'End If
            'Dim Str1 As String = "SELECT MAX(ESALNO) FROM HALA_ESH "
            'Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
            'ESALNO = cmd1.ExecuteScalar + 1
            If RadioButton3.Checked = True Then
                sak = "صك رقم" & vbNewLine & TextBox10.Text
            ElseIf RadioButton1.Checked = True Then
                sak = "بطاقة رقم" & vbNewLine & TextBox4.Text
            Else
                sak = "نقدي"
            End If
#Disable Warning BC42024 ' Unused local variable: 'cri'.
            Dim cr2 As New esalmsrofat, cri As String
#Enable Warning BC42024 ' Unused local variable: 'cri'.
            cr2.SetParameterValue(0, Me.X1)
            cr2.SetParameterValue(1, Me.monaX)
            cr2.SetParameterValue(2, Me.notex)
            cr2.SetParameterValue(3, Me.kemax)
            cr2.SetParameterValue(4, Me.Esalnox)
            cr2.SetParameterValue(5, Me.CLIN)
            cr2.SetParameterValue(6, Me.TEL)
            cr2.SetParameterValue(7, Me.sak)

            If CheckBox1.Checked = True Then
                cr2.PrintToPrinter(1, False, 1, 1)
            End If
            Dim sk As String
            sk = "select * from SAREFNAME"
            Dim adk As New SqlClient.SqlDataAdapter(sk, cn)
            Dim dsk As New DataSet
            adk.Fill(dsk, "SAREFNAME")
            ComboBox2.DataSource = dsk.Tables(0)
            ComboBox2.DisplayMember = "SAREFNAME"
            ComboBox2.SelectedIndex = -1
            Dim skK As String
            skK = "select * from BlossT"
            Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
            Dim dskK As New DataSet
            adkK.Fill(dskK, "BlossT")
            ComboBox1.DataSource = dskK.Tables(0)
            ComboBox1.DisplayMember = "lossTYPE"
            ComboBox1.SelectedIndex = -1
            Me.ComboBox4.Text = ""
            Me.TextBox2.Text = "0"
            Me.ComboBox1.Text = ""
            Me.ComboBox1.Focus()

            Dim ss As String = "select * from loss "
            Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
            Dim dss As New DataSet
            dss.Clear()
            aad.Fill(dss, "loss")
            Dim vdd As New DataView(dss.Tables("loss")) With {
                .RowFilter = " lossdate =" & "#" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "#" & ""
            }
            DataGridView1.DataMember = ""
            DataGridView1.DataSource = vdd
            Button1.Visible = False
            Button3.Visible = False
            Button2.Visible = True

        Catch ex As Exception
            'MsgBox("خطأ في الترصيد")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub حذفالتقريرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفالتقريرToolStripMenuItem.Click
        Dim sd As String = "delete from loss where id=@id"
        Dim cd As New SqlClient.SqlCommand(sd, cn)
        cd.Parameters.AddWithValue("@id", CInt(Me.Label1.Text))
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
                Dim vdd As New DataView(dss.Tables("LOSS")) With {
                    .RowFilter = " LOSSDATE =" & "#" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "#" & ""
                }
                DataGridView1.DataMember = ""
                DataGridView1.DataSource = vdd
            Catch ex As Exception
                MsgBox("لم يتم الحذف")
            End Try
        End If
        Dim sk As String
        sk = "select * from Bloss"
        Dim adk As New SqlClient.SqlDataAdapter(sk, cn)
        Dim dsk As New DataSet
        adk.Fill(dsk, "Bloss")
        ComboBox2.DataSource = dsk.Tables(0)
        ComboBox2.DisplayMember = "lossna"
        ComboBox2.SelectedIndex = -1
        Dim skK As String
        skK = "select * from BlossT"
        Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
        Dim dskK As New DataSet
        adkK.Fill(dskK, "BlossT")
        ComboBox1.DataSource = dskK.Tables(0)
        ComboBox1.DisplayMember = "lossTYPE"
        ComboBox1.SelectedIndex = -1
        Me.ComboBox2.Text = ""
        Me.TextBox2.Text = "0"


        Dim sss As String = "select * from LOSS "
        Dim aads As New SqlClient.SqlDataAdapter(sss, cn)
        Dim dsss As New DataSet
        dsss.Clear()
        aads.Fill(dsss, "LOSS")
        Dim vdds As New DataView(dsss.Tables("LOSS")) With {
            .RowFilter = " LOSSDATE =" & "#" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "#" & ""
        }
        DataGridView1.DataMember = ""
        DataGridView1.DataSource = vdds

    End Sub

    Private Sub عرضالتقريرToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles عرضالتقريرToolStripMenuItem2.Click
        If ComboBox1.Text = "" And ComboBox2.Text = "" Then
            TextBox3.Text = "تقرير عن المصروفات"
            L = 1
        ElseIf ComboBox1.Text = "" And ComboBox2.Text <> "" Then
            TextBox3.Text = "تقرير عن المصروفات المصروفة من قبل" + " " + ComboBox2.Text
            L = 2
        ElseIf ComboBox1.Text <> "" And ComboBox2.Text = "" Then
            TextBox3.Text = "تقرير عن" + " " + ComboBox1.Text
            L = 3
        ElseIf ComboBox1.Text <> "" And ComboBox2.Text <> "" Then
            TextBox3.Text = "تقرير عن" + " " + ComboBox1.Text + " " + "المصروفة من قبل" + " " + ComboBox2.Text
            L = 4
        End If
        vv1 = ComboBox1.Text
        vv2 = ComboBox2.Text
        mo = TextBox3.Text
        fp = 1
        Dim f As New ByDate
        f.ShowDialog()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            GroupBox9.Text = "رقم البطاقة"
            TextBox10.Text = "بطاقة"
        Else
            GroupBox9.Text = "رقم الحساب"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        'If RadioButton4.Checked = True Then
        '    Me.ForeColor = Color.Red
        'Else
        '    Me.ForeColor = Color.Navy
        'End If
    End Sub

    Private Sub RadioButton4_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton4.KeyDown
        If Asc(e.KeyCode) = Keys.Enter Then
            Me.TextBox10.Text = "0"
            Me.TextBox9.Text = "0"
            Me.TextBox4.Text = "0"
            Me.Button2.Focus()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub RadioButton3_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton3.KeyDown
        If Asc(e.KeyCode) = Keys.Enter Then
            Me.TextBox10.Focus()
        End If
    End Sub

    Private Sub TextBox10_Validated(sender As Object, e As EventArgs) Handles TextBox10.Validated
        If String.IsNullOrWhiteSpace(TextBox10.Text) Then
            TextBox10.Text = CDbl(0)
        End If
    End Sub

    Private Sub TextBox10_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox10.KeyDown
        If Asc(e.KeyCode) = Keys.Enter Then
            Me.TextBox9.Focus()
        End If
    End Sub

    Private Sub TextBox10_Enter(sender As Object, e As EventArgs) Handles TextBox10.Enter
        If TextBox10.Text = CDbl(0) Then
            TextBox10.Text = ""
        End If
    End Sub

    Private Sub TextBox9_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown
        If Asc(e.KeyCode) = Keys.Enter Then
            Me.ComboBox3.Focus()
        End If
    End Sub

    Private Sub TextBox9_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles TextBox9.GiveFeedback
        For Each Lng As InputLanguage In InputLanguage.InstalledInputLanguages
            If Lng.Culture.DisplayName.ToUpper.StartsWith("AR") Then
                InputLanguage.CurrentInputLanguage = Lng
                Exit For
            End If
        Next
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sH As String = "select * from masrafname where masrafname=@xx1 "
        Dim cmH As New SqlClient.SqlCommand(sH, cn)
        cmH.Parameters.AddWithValue("@xx1", Me.ComboBox3.Text)
        Dim rdH As SqlClient.SqlDataReader
        rdH = cmH.ExecuteReader
        If rdH.Read = True Then
            Me.Label7.Text = CInt(rdH!IDMASRAF)
        End If
    End Sub

    Private Sub ComboBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox3.KeyDown
        If Asc(e.KeyCode) = Keys.Enter Then
            Me.TextBox4.Focus()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MENUEX = 3
        Dim F As New EDARA With {
            .Text = "اسم المصرف"
        }
        F.ShowDialog()
        Dim s7 As String
        s7 = "select * from MASRAFNAME "
        Dim ad7 As New SqlClient.SqlDataAdapter(s7, cn)
        Dim ds7 As New DataSet
        ad7.Fill(ds7, "MASRAFNAME")
        ComboBox3.DataSource = ds7.Tables(0)
        ComboBox3.DisplayMember = "MASRAFNAME"
        ComboBox3.SelectedIndex = -1
    End Sub

    Private Sub TextBox4_Enter(sender As Object, e As EventArgs) Handles TextBox4.Enter
        If TextBox4.Text = CDbl(0) Then
            TextBox4.Text = ""
        End If
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If Asc(e.KeyCode) = Keys.Enter Then
            Me.Button2.Focus()
        End If
    End Sub

    Private Sub TextBox4_Validated(sender As Object, e As EventArgs) Handles TextBox4.Validated
        If String.IsNullOrWhiteSpace(TextBox4.Text) Then
            TextBox4.Text = CDbl(0)
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MENUEX = 5
        Dim F As New EDARA With {
            .Text = "اسم الصارف"
        }
        F.ShowDialog()
        Dim s7 As String
        s7 = "select * from SAREFNAME "
        Dim ad7 As New SqlClient.SqlDataAdapter(s7, cn)
        Dim ds7 As New DataSet
        ad7.Fill(ds7, "SAREFNAME")
        ComboBox2.DataSource = ds7.Tables(0)
        ComboBox2.DisplayMember = "SAREFNAME"
        ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox1.Text = "" Then
                MsgBox("ارجو ادخال بيان القيد")
                ComboBox1.Focus()
            Else
                ComboBox2.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.ComboBox2.Text = "" Then
                MsgBox("أرجو اختيار نوع القيد")
                Me.ComboBox2.Focus()
            Else
                Me.DateTimePicker2.Focus()
            End If
        End If
    End Sub

    Private Sub DateTimePicker2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DateTimePicker2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.ComboBox4.Focus()
        End If
    End Sub

    Private Sub ComboBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.ComboBox4.Text = "" Then
                ComboBox4.Text = "/"
            End If
            Me.TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.TextBox2.Text = "" Then
                MsgBox("ارجو ادخال القيمة")
                Me.TextBox2.Focus()
            Else
                Me.RadioButton4.Focus()
            End If
        End If
    End Sub

    Private Sub RadioButton4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RadioButton4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox10.Text = "0"
            Me.TextBox9.Text = "0"
            Me.TextBox4.Text = "0"
            Me.Button2.Focus()
        End If
    End Sub

    Private Sub RadioButton3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RadioButton3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox10.Focus()
        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox9.Focus()
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.ComboBox3.Focus()
        End If
    End Sub

    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.Button2.Focus()
        End If
    End Sub

    Private Sub RadioButton1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RadioButton1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TextBox10.Text = "بطاقة"
            Me.TextBox9.Focus()
        End If
    End Sub

    Private Sub RadioButton1_KeyDown(sender As Object, e As KeyEventArgs) Handles RadioButton1.KeyDown
        If Asc(e.KeyCode) = Keys.Enter Then
            TextBox10.Text = "بطاقة"
            Me.TextBox9.Focus()
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub RadioButton4_Enter(sender As Object, e As EventArgs) Handles RadioButton4.Enter

    End Sub

    Private Sub RadioButton4_GotFocus(sender As Object, e As EventArgs) Handles RadioButton4.GotFocus
        RadioButton4.ForeColor = Color.Crimson
        RadioButton3.ForeColor = Color.Navy
        RadioButton1.ForeColor = Color.Navy
    End Sub
    Private Sub RadioButton3_GotFocus(sender As Object, e As EventArgs) Handles RadioButton3.GotFocus
        RadioButton3.ForeColor = Color.Crimson
        RadioButton4.ForeColor = Color.Navy
        RadioButton1.ForeColor = Color.Navy
    End Sub
    Private Sub RadioButton1_GotFocus(sender As Object, e As EventArgs) Handles RadioButton1.GotFocus
        RadioButton1.ForeColor = Color.Crimson
        RadioButton3.ForeColor = Color.Navy
        RadioButton4.ForeColor = Color.Navy
    End Sub

    Private Sub RadioButton4_Validated(sender As Object, e As EventArgs) Handles RadioButton4.Validated
        RadioButton1.ForeColor = Color.Navy
        RadioButton3.ForeColor = Color.Navy
        RadioButton4.ForeColor = Color.Navy
    End Sub
    Private Sub RadioButton3_Validated(sender As Object, e As EventArgs) Handles RadioButton3.Validated
        RadioButton1.ForeColor = Color.Navy
        RadioButton3.ForeColor = Color.Navy
        RadioButton4.ForeColor = Color.Navy
    End Sub
    Private Sub RadioButton1_Validated(sender As Object, e As EventArgs) Handles RadioButton1.Validated
        RadioButton1.ForeColor = Color.Navy
        RadioButton3.ForeColor = Color.Navy
        RadioButton4.ForeColor = Color.Navy
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "0" Then
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox2_Validated(sender As Object, e As EventArgs) Handles TextBox2.Validated
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            TextBox2.Text = "0"
        End If
    End Sub

    Private Sub ComboBox2_Enter(sender As Object, e As EventArgs) Handles ComboBox2.Enter
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub
End Class