Public Class Doctors

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Me.TextBox1.Text = "" Then
                Dim st As String = "select count(idk) from kesem"
                Dim cmt As New SqlClient.SqlCommand(st, cn)
                Dim b As Integer = cmt.ExecuteScalar
                TextBox1.Text = b + 1
                'Dim k As Integer = 1
                'Do While k < 100
                '    Dim i As Integer
                '    i = 1
                '    m5 = i
                '    Dim s As String = "select * from dn where ID=xx1 "
                '    Dim cm As New SqlClient.SqlCommand(s, cn)
                '    cm.Parameters.AddWithValue("xx1", i)
                '    Dim rd As SqlClient.SqlDataReader
                '    rd = cm.ExecuteReader
                '    Do While rd.Read = True
                '        i = i + 1
                '        Dim ss As String = "select * from dn where ID=xx1"
                '        Dim cmm As New SqlClient.SqlCommand(ss, cn)
                '        cmm.Parameters.AddWithValue("xx1", i)
                '        rd = cmm.ExecuteReader
                '        m5 = i
                '    Loop
                '    rd.Close()
                '    k = k + 1
                'Loop
                Me.ComboBox2.Focus()
                'MsgBox("أرجو إدخال رقم الطبيب")
            Else
                Dim s As String = "select * from dn where ID=xx1 "
                Dim cm As New SqlClient.SqlCommand(s, cn)
                cm.Parameters.AddWithValue("xx1", TextBox1.Text)
                Dim rd As SqlClient.SqlDataReader
                rd = cm.ExecuteReader
                If rd.Read = True Then
                    ComboBox2.Text = rd!dn
                    ComboBox1.Text = rd!IDK
                    Dim sE As String = "select * from KESEM where IDK=xx1 "
                    Dim cmE As New SqlClient.SqlCommand(sE, cn)
                    cmE.Parameters.AddWithValue("xx1", ComboBox1.Text)
                    Dim rdE As SqlClient.SqlDataReader
                    rdE = cmE.ExecuteReader
                    If rdE.Read = True Then
                        ComboBox1.Text = rdE!kesem
                    End If
                    TextBox3.Text = rd!notel
                    Me.DataGridView1.DataSource = ""
                    Dim s1 As String = "select * from tabib "
                    Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                    Dim dss As New DataSet
                    dss.Clear()
                    aad.Fill(dss, "tabib")
                    Dim vd As New DataView(dss.Tables("tabib"))
                    vd.RowFilter = "dn=" & "'" & Me.ComboBox2.Text & "'" & ""
                    Me.DataGridView1.DataMember = ""
                    DataGridView1.DataSource = vd
                    Me.ComboBox3.Focus()
                Else
                    Me.ComboBox2.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox2.Text = "" Then
                MsgBox("يرجى ادخال اسم الطبيب")
            Else
                ComboBox1.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Trim(ComboBox2.Text) <> "" Then
            Dim s As String = "select * from doctor_view where dn=@dn "
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@dn", ComboBox2.Text)
            Using rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    TextBox1.Text = rd!idd
                    ComboBox1.Text = rd!kesem
                    TextBox3.Text = rd!notel
                    Me.DataGridView1.DataSource = ""
                    ComboBox3.Text = rd!ejraa
                    TextBox2.Text = rd!kema
                    TextBox5.Text = rd!kemaej
                Else
                    Dim sg As String = "select * from dn_v where dn=@dn "
                    Dim cmg As New SqlClient.SqlCommand(sg, cn)
                    cmg.Parameters.AddWithValue("@dn", ComboBox2.Text)
                    Using rdg As SqlClient.SqlDataReader = cmg.ExecuteReader
                        If rdg.Read = True Then
                            TextBox1.Text = rdg!idd
                            ComboBox1.Text = rdg!kesem
                            TextBox3.Text = rdg!notel
                            Me.DataGridView1.DataSource = ""
                            ComboBox3.Text = ""
                            TextBox2.Text = ""
                            TextBox5.Text = ""
                        End If
                    End Using
                End If
            End Using
            Dim s1 As String = "select * from tabib "
            Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            Dim dss As New DataSet
            dss.Clear()
            aad.Fill(dss, "tabib")
            Dim vd As New DataView(dss.Tables("tabib"))
            vd.RowFilter = "dn=" & "'" & Me.ComboBox2.Text & "'" & ""
            Me.DataGridView1.DataMember = ""
            DataGridView1.DataSource = vd
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox1.Text = "" Then
                MsgBox("يرجى ادخال القسم")
            Else
                TextBox3.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text <> "" Then
            Dim B As Integer = -1
            Dim sG As String = "select * from KESEM where KESEM=@xx1 "
            Using cmG As New SqlClient.SqlCommand(sG, cn)
                cmG.Parameters.AddWithValue("@xx1", ComboBox1.Text)
                Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
                If rdG.Read = True Then
                    B = rdG!IDK
                End If
                rdG.Close()
            End Using
            Dim sk23 As String
            sk23 = "select * from Ejraa where IDK=" & B
            Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
                Dim dsk23 As New DataSet
                adk23.Fill(dsk23, "Ejraa")
                ComboBox3.DataSource = dsk23.Tables(0)
                ComboBox3.DisplayMember = "Ejraa"
                'ComboBox3.SelectedIndex = -1
            End Using
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox3.Text = "" Then
                TextBox3.Text = "لايوجد"
            End If
            ComboBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox2.Text = "" Then
                TextBox2.Text = 0
            End If
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Doctors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbsbhDataSet8.TABIB' table. You can move, or remove it, as needed.
        Me.TABIBTableAdapter1.Fill(Me.DbsbhDataSet8.TABIB)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.tabib' table. You can move, or remove it, as needed.
        'Me.TabibTableAdapter.Fill(Me.DbsbhDataSet8.tabib)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.dn' table. You can move, or remove it, as needed.
        'Me.DnTableAdapter1.Fill(Me.DbsbhDataSet8.dn)
        'TODO: This line of code loads data into the 'DbsbhDataSet7.dn' table. You can move, or remove it, as needed.
        'Me.DnTableAdapter.Fill(Me.DbsbhDataSet7.dn)
        Dim sk1 As String
        sk1 = "select * from Ejraa"
        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
        Dim dsk1 As New DataSet
        adk1.Fill(dsk1, "Ejraa")
        ComboBox3.DataSource = dsk1.Tables(0)
        ComboBox3.DisplayMember = "Ejraa"
        ComboBox3.SelectedIndex = -1

        Dim skd As String
        skd = "select * from dn"
        Dim adkd As New SqlClient.SqlDataAdapter(skd, cn)
        Dim dskd As New DataSet
        adkd.Fill(dskd, "dn")
        ComboBox2.DataSource = dskd.Tables(0)
        ComboBox2.DisplayMember = "dn"
        ComboBox2.SelectedIndex = -1

        Dim skk As String
        skk = "select * from kesem"
        Dim adkk As New SqlClient.SqlDataAdapter(skk, cn)
        Dim dskk As New DataSet
        adkk.Fill(dskk, "kesem")
        ComboBox1.DataSource = dskk.Tables(0)
        ComboBox1.DisplayMember = "kesem"
        ComboBox1.SelectedIndex = -1


        ComboBox2.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = e.RowIndex
        If Val(i) >= 0 Then
            Dim dgx As Integer
            Dim dgxx As String
            dgx = DataGridView1.Item(0, i).Value()
            dgxx = DataGridView1.Item(2, i).Value()
            'dgx = Me.DataGridView1.CurrentCell.Value
            'Label8.Text = dgx
            Call Class1.CONNIC()
            'Dim s As String = "select * from dn where idd=@idd"
            'Using cm As New SqlClient.SqlCommand(s, cn)
            '    cm.Parameters.AddWithValue("@idd", dgx)
            '    Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            '    If rd.Read = True Then
            '        Me.ComboBox2.Text = rd!dn
            '        Me.Label3.Text = rd!idk
            '        Me.TextBox1.Text = rd!idd
            '        Me.TextBox3.Text = rd!notel
            '    End If
            'End Using
            'Dim sk As String = "select * from dn where idk=@idk"
            'Using cmk As New SqlClient.SqlCommand(sk, cn)
            '    cmk.Parameters.AddWithValue("@idk", dgx)
            '    Dim rdk As SqlClient.SqlDataReader = cmk.ExecuteReader
            '    If rdk.Read = True Then
            '        Me.ComboBox1.Text = rdk!kesem
            '    End If
            'End Using

            'Dim sx As String = "select * from dn where idd=@idd"
            'Using cmx As New SqlClient.SqlCommand(sx, cn)
            '    cmx.Parameters.AddWithValue("@idd", dgx)
            '    Dim rdx As SqlClient.SqlDataReader = cmx.ExecuteReader
            '    If rdx.Read = True Then
            '        Me.ComboBox3.Text = rdx!Ejraa
            '        Me.TextBox5.Text = rdx!kemaj
            '        Me.TextBox2.Text = rdx!kema
            '    End If
            'End Using
            Dim s As String = "select * from doctor_view where idd=@idd and Ejraa=@Ejraa "
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@idd", dgx)
            cm.Parameters.AddWithValue("@Ejraa", dgxx)
            Using rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    TextBox1.Text = rd!idd
                    ComboBox1.Text = rd!kesem
                    TextBox3.Text = rd!notel
                    'Me.DataGridView1.DataSource = ""
                    ComboBox3.Text = rd!ejraa
                    TextBox2.Text = rd!kema
                    TextBox5.Text = rd!kemaej
                End If
            End Using

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = e.RowIndex
        If Val(i) >= 0 Then
            Dim dgx As Integer
            Dim dgxx As String
            dgx = DataGridView1.Item(0, i).Value()
            dgxx = DataGridView1.Item(2, i).Value()
            'dgx = Me.DataGridView1.CurrentCell.Value
            'Label8.Text = dgx
            Call Class1.CONNIC()
            'Dim s As String = "select * from dn where idd=@idd"
            'Using cm As New SqlClient.SqlCommand(s, cn)
            '    cm.Parameters.AddWithValue("@idd", dgx)
            '    Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            '    If rd.Read = True Then
            '        Me.ComboBox2.Text = rd!dn
            '        Me.Label3.Text = rd!idk
            '        Me.TextBox1.Text = rd!idd
            '        Me.TextBox3.Text = rd!notel
            '    End If
            'End Using
            'Dim sk As String = "select * from dn where idk=@idk"
            'Using cmk As New SqlClient.SqlCommand(sk, cn)
            '    cmk.Parameters.AddWithValue("@idk", dgx)
            '    Dim rdk As SqlClient.SqlDataReader = cmk.ExecuteReader
            '    If rdk.Read = True Then
            '        Me.ComboBox1.Text = rdk!kesem
            '    End If
            'End Using

            'Dim sx As String = "select * from dn where idd=@idd"
            'Using cmx As New SqlClient.SqlCommand(sx, cn)
            '    cmx.Parameters.AddWithValue("@idd", dgx)
            '    Dim rdx As SqlClient.SqlDataReader = cmx.ExecuteReader
            '    If rdx.Read = True Then
            '        Me.ComboBox3.Text = rdx!Ejraa
            '        Me.TextBox5.Text = rdx!kemaj
            '        Me.TextBox2.Text = rdx!kema
            '    End If
            'End Using
            Dim s As String = "select * from doctor_view where idd=@idd and Ejraa=@Ejraa "
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@idd", dgx)
            cm.Parameters.AddWithValue("@Ejraa", dgxx)
            Using rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    TextBox1.Text = rd!idd
                    ComboBox1.Text = rd!kesem
                    TextBox3.Text = rd!notel
                    'Me.DataGridView1.DataSource = ""
                    ComboBox3.Text = rd!ejraa
                    TextBox2.Text = rd!kema
                    TextBox5.Text = rd!kemaej
                End If
            End Using

        End If
    End Sub

    Private Sub ComboBox2_Validated(sender As Object, e As EventArgs) Handles ComboBox2.Validated
        Dim r1 As String = Replace(ComboBox2.Text, "أ", "ا")
        Dim r2 As String = Replace(r1, "ى", "ي")
        Dim r3 As String = Replace(r2, "ة", "ه")
        Me.ComboBox2.Text = r3
        Dim sx As String = "select * from dn where dn=@dn"
        Using cmx As New SqlClient.SqlCommand(sx, cn)
            cmx.Parameters.AddWithValue("@dn", Me.ComboBox2.Text)
            Dim rdx As SqlClient.SqlDataReader = cmx.ExecuteReader
            'If rdx.Read = True Then
            '    B11.Enabled = False
            '    Button4.Enabled = True
            'Else
            '    B11.Enabled = True
            '    Button4.Enabled = False
            'End If
        End Using
    End Sub

    Private Sub ComboBox1_Validated(sender As Object, e As EventArgs) Handles ComboBox1.Validated
        Dim r1 As String = Replace(ComboBox1.Text, "أ", "ا")
        Dim r2 As String = Replace(r1, "ى", "ي")
        Dim r3 As String = Replace(r2, "ة", "ه")
        Me.ComboBox1.Text = r3
    End Sub

    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox3.Text = "" Then
                ComboBox3.Text = "كشف"
            End If
            TextBox2.Focus()
        End If

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox5.Text = "" Then
                TextBox5.Text = TextBox2.Text
            End If
            B11.Focus()
        End If

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        If ComboBox2.Text <> "" Then
            Dim st As String = "select count(idk) from kesem"
            Dim cmt As New SqlClient.SqlCommand(st, cn)
            Dim a As Integer = cmt.ExecuteScalar
            Label1.Text = a + 1
            Dim ss2F As String = "insert into KESEM(idk,kesem)VALUES(@idk,@kesem)"
            Dim cmm2F As New SqlClient.SqlCommand(ss2F, cn)
            cmm2F.Parameters.AddWithValue("@idk", Label1.Text)
            cmm2F.Parameters.AddWithValue("@kesem", ComboBox1.Text)
            Try
                cmm2F.ExecuteNonQuery()
            Catch ex As Exception

            End Try

            Dim sK As String = "select * from KESEM where KESEM=@KESEM"
            Dim cmK As New SqlClient.SqlCommand(sK, cn)
            cmK.Parameters.AddWithValue("@KESEM", ComboBox1.Text)
            Dim rdK As SqlClient.SqlDataReader
            rdK = cmK.ExecuteReader
            If rdK.Read = True Then
                TextBox6.Text = rdK!idK
            End If
            rdK.Close()
            Call Class1.CONNIC()
            If TextBox1.Text = "" Then
                Dim ss2 As String = "insert into dn(dn,notel,IDK) VALUES(@dn,@notel,@IDK)"
                Using cmm2 As New SqlClient.SqlCommand(ss2, cn)
                    'cmm2.Parameters.AddWithValue("@idd", TextBox1.Text)
                    cmm2.Parameters.AddWithValue("@dn", ComboBox2.Text)
                    cmm2.Parameters.AddWithValue("@notel", TextBox3.Text)
                    cmm2.Parameters.AddWithValue("@IDK", TextBox6.Text)
                    'Try
                    cmm2.ExecuteNonQuery()
                End Using
            End If
            'Catch ex As Exception
            'End Try
            Dim sl As String = "select * from dn where dn=@dn"
            Dim cml As New SqlClient.SqlCommand(sl, cn)
            cml.Parameters.AddWithValue("@dn", ComboBox2.Text)
            Dim rdl As SqlClient.SqlDataReader
            rdl = cml.ExecuteReader
            If rdl.Read = True Then
                Label2.Text = rdl!idd
            End If
            Dim s As String = "select * from Ejraa where Ejraa=@Ejraa"
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@Ejraa", ComboBox3.Text)
            Dim rd As SqlClient.SqlDataReader
            rd = cm.ExecuteReader
            If rd.Read = True Then
                TextBox4.Text = rd!idj
            End If
            rd.Close()
            Dim sf As String = "select * from dnkema where idd=@idd and Ejraa=@Ejraa"
            Dim cmf As New SqlClient.SqlCommand(sf, cn)
            cmf.Parameters.AddWithValue("@idd", CInt(Val(Label2.Text)))
            cmf.Parameters.AddWithValue("@Ejraa", CInt(Val(TextBox4.Text)))
            Dim rdf As SqlClient.SqlDataReader
            rdf = cmf.ExecuteReader
            If rdf.Read = False Then
                Dim ss23 As String = "insert into dnkema(idd,Ejraa,Kema,kemaej)VALUES(@idd,@Ejraa,@Kema,@kemaej)"
                Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
                cmm23.Parameters.AddWithValue("@idd", CInt(Val(Label2.Text)))
                cmm23.Parameters.AddWithValue("@Ejraa", CInt(Val(TextBox4.Text)))
                cmm23.Parameters.AddWithValue("@Kema", CDbl(TextBox2.Text))
                cmm23.Parameters.AddWithValue("@kemaej", CDbl(TextBox5.Text))
                Try
                    cmm23.ExecuteNonQuery()
                    MsgBox("تم الحفظ ")
                    Me.DataGridView1.DataSource = ""
                    Dim s1 As String = "select * from tabib "
                    Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                    Dim dss As New DataSet
                    dss.Clear()
                    aad.Fill(dss, "tabib")
                    Dim vd As New DataView(dss.Tables("tabib"))
                    vd.RowFilter = "dn=" & "'" & Me.ComboBox2.Text & "'" & ""
                    Me.DataGridView1.DataMember = ""
                    DataGridView1.DataSource = vd
                    Me.ComboBox1.Text = ""
                    Me.ComboBox2.Text = ""
                    Me.TextBox1.Text = ""
                Catch ex As Exception
                    MsgBox(" لايمكن الحفظ ")
                End Try
            Else
                MsgBox("خطأ .. بيانات مكرره")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub طباعةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةToolStripMenuItem.Click
        If ComboBox2.Text = "" Then
            MsgBox("أرجو اختيار اسم الطبيب")
            ComboBox2.Focus()
        Else
            vv1 = ComboBox2.Text
            Dim f As New Form15
            f.ShowDialog()
        End If
    End Sub
End Class