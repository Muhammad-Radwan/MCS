Public Class setting

    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If KHAZENAXX = True Then
            CheckBox3.CheckState = CheckState.Checked
        Else
            CheckBox3.CheckState = CheckState.Unchecked
        End If
        'TODO: This line of code loads data into the 'DbsbhDataSet8.Mostafeed' table. You can move, or remove it, as needed.
        'Me.MostafeedTableAdapter.Fill(Me.DbsbhDataSet8.Mostafeed)
        Call Class1.CONNIC()
        'TODO: This line of code loads data into the 'DbsbhDataSet8.TYPEEYWAA' table. You can move, or remove it, as needed.
        'Me.TYPEEYWAATableAdapter.Fill(Me.DbsbhDataSet8.TYPEEYWAA)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.EjraaK_v' table. You can move, or remove it, as needed.
        'Me.EjraaK_vTableAdapter.Fill(Me.DbsbhDataSet8.EjraaK_v)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.Ejraa' table. You can move, or remove it, as needed.
        'Me.EjraaTableAdapter.Fill(Me.DbsbhDataSet8.Ejraa)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.TABIB' table. You can move, or remove it, as needed.
        'Me.TABIBTableAdapter.Fill(Me.DbsbhDataSet8.TABIB)
        'TODO: This line of code loads data into the 'DbsbhDataSet8.Doctor_view' table. You can move, or remove it, as needed.
        'Me.Doctor_viewTableAdapter.Fill(Me.DbsbhDataSet8.Doctor_view)
        Dim sk1 As String
        sk1 = "select * from Ejraa"
        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
        Dim dsk1 As New DataSet
        adk1.Fill(dsk1, "Ejraa")
        ComboBox2.DataSource = dsk1.Tables(0)
        ComboBox2.DisplayMember = "Ejraa"
        ComboBox2.SelectedIndex = -1

        Dim skd As String
        skd = "select * from dn"
        Dim adkd As New SqlClient.SqlDataAdapter(skd, cn)
        Dim dskd As New DataSet
        adkd.Fill(dskd, "dn")
        ComboBox5.DataSource = dskd.Tables(0)
        ComboBox5.DisplayMember = "dn"
        ComboBox5.SelectedIndex = -1

        Dim skk As String
        skk = "select * from kesem"
        Dim adkk As New SqlClient.SqlDataAdapter(skk, cn)
        Dim dskk As New DataSet
        adkk.Fill(dskk, "kesem")
        ComboBox4.DataSource = dskk.Tables(0)
        ComboBox4.DisplayMember = "kesem"
        ComboBox4.SelectedIndex = -1

        Dim sk2 As String
        sk2 = "select * from KESEM"
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "KESEM")
        ComboBox3.DataSource = dsk2.Tables(0)
        ComboBox3.DisplayMember = "KESEM"
        ComboBox3.SelectedIndex = -1

        Dim sk2K As String
        sk2K = "select * from KESEM"
        Dim adk2K As New SqlClient.SqlDataAdapter(sk2K, cn)
        Dim dsk2K As New DataSet
        adk2K.Fill(dsk2K, "KESEM")
        ComboBox6.DataSource = dsk2K.Tables(0)
        ComboBox6.DisplayMember = "KESEM"
        ComboBox6.SelectedIndex = -1

        Dim sk2KY As String
        sk2KY = "select * from TYPEEYWAA"
        Dim adk2KY As New SqlClient.SqlDataAdapter(sk2KY, cn)
        Dim dsk2KY As New DataSet
        adk2KY.Fill(dsk2KY, "TYPEEYWAA")
        ComboBox7.DataSource = dsk2KY.Tables(0)
        ComboBox7.DisplayMember = "EYWAATYPE"
        ComboBox7.SelectedIndex = -1
        Dim skkx As String
        skkx = "select * from NAMEM"
        Dim adkkx As New SqlClient.SqlDataAdapter(skkx, cn)
        Dim dskkx As New DataSet
        adkkx.Fill(dskkx, "NAMEM")
        ComboBox9.DataSource = dskkx.Tables(0)
        ComboBox9.DisplayMember = "NAMEM"
        ComboBox9.SelectedIndex = -1
        Dim skkj As String
        skkj = "select * from JEHAM"
        Dim adkkj As New SqlClient.SqlDataAdapter(skkj, cn)
        Dim dskkj As New DataSet
        adkkj.Fill(dskkj, "JEHAM")
        ComboBox8.DataSource = dskkj.Tables(0)
        ComboBox8.DisplayMember = "JEHAM"
        ComboBox8.SelectedIndex = -1

        DataGridView1.Rows.Clear()
        DataGridView2.DataSource = ""
        DataGridView3.DataSource = ""
        DataGridView4.DataSource = ""
        GroupBox10.Text = "اسم الطبيب"
        GroupBox10.ForeColor = Color.Black
        GroupBox9.Text = "القسم"
        GroupBox9.ForeColor = Color.Black
        ComboBox4.Enabled = True
        ComboBox4.Text = ""
        ComboBox7.Text = ""
        ComboBox6.Text = ""
        ComboBox2.Text = ""
        ComboBox4.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox2.Text = 0
        TextBox9.Text = 0
        TextBox3.Text = ""
        TextBox5.Text = 0
        ComboBox3.Text = ""
        ComboBox1.Text = ""
        ComboBox3.SelectedIndex = -1
        ComboBox1.SelectedIndex = -1
        Call Class4.CONNIC()

    End Sub

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        If ComboBox5.Text <> "" Then
            Call Class1.CONNIC()
            'ElseIf ComboBox4.Text <> "" Then
            'ElseIf ComboBox2.Text <> "" Then
            'ElseIf TextBox2.Text <> "" Then
            'ElseIf TextBox5.Text <> "" Then

            'Dim st As String = "select count(idk) from kesem"
            'Dim cmt As New SqlClient.SqlCommand(st, cn)
            'Dim a As Integer = cmt.ExecuteScalar
            'Label1.Text = a + 1
            'Dim ss2F As String = "insert into KESEM(idk,kesem)VALUES(@idk,@kesem)"
            'Dim cmm2F As New SqlClient.SqlCommand(ss2F, cn)
            'cmm2F.Parameters.AddWithValue("@idk", Label1.Text)
            'cmm2F.Parameters.AddWithValue("@kesem", ComboBox4.Text)
            'Try
            '    cmm2F.ExecuteNonQuery()
            'Catch ex As Exception

            'End Try
            Call TXTEMLA.TXTEMLA(ComboBox5.Text)
            Me.ComboBox5.Text = RTXT

            Dim sK As String = "select * from KESEM where KESEM=@KESEM"
            Dim cmK As New SqlClient.SqlCommand(sK, cn)
            cmK.Parameters.AddWithValue("@KESEM", ComboBox4.Text)
            Dim rdK As SqlClient.SqlDataReader
            rdK = cmK.ExecuteReader
            If rdK.Read = True Then
                TextBox6.Text = rdK!idK
            End If
            rdK.Close()
            Call Class1.CONNIC()
            'If TextBox1.Text = "" Then
            Dim sKx As String = "select * from dn where dn=@dn"
            Dim cmKx As New SqlClient.SqlCommand(sKx, cn)
            'cmKx.Parameters.AddWithValue("@idk", TextBox6.Text)
            cmKx.Parameters.AddWithValue("@dn", ComboBox5.Text)
            Dim rdKx As SqlClient.SqlDataReader
            rdKx = cmKx.ExecuteReader
            If rdKx.Read = True Then
                Dim ss2 As String = "update dn set dn=@dn,notel=@notel,IDK=@idk where idd=@idd"
                Using cmm2 As New SqlClient.SqlCommand(ss2, cn)
                    'cmm2.Parameters.AddWithValue("@idd", TextBox1.Text)
                    cmm2.Parameters.AddWithValue("@dn", Trim(ComboBox5.Text))
                    cmm2.Parameters.AddWithValue("@notel", TextBox3.Text)
                    cmm2.Parameters.AddWithValue("@IDK", CInt(TextBox6.Text))
                    cmm2.Parameters.AddWithValue("@idd", CInt(TextBox1.Text))
                    Try
                        cmm2.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("dn>>>>>")
                    End Try
                End Using
            Else
                Dim ss2 As String = "insert into dn(dn,notel,IDK) VALUES(@dn,@notel,@IDK)"
                Using cmm2 As New SqlClient.SqlCommand(ss2, cn)
                    'cmm2.Parameters.AddWithValue("@idd", TextBox1.Text)
                    cmm2.Parameters.AddWithValue("@dn", ComboBox5.Text)
                    cmm2.Parameters.AddWithValue("@notel", TextBox3.Text)
                    cmm2.Parameters.AddWithValue("@IDK", TextBox6.Text)
                    Try
                        cmm2.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("dn>>>>>")
                    End Try
                End Using
            End If
            'Catch ex As Exception
            'End Try
            Dim sl As String = "select * from dn where dn=@dn"
            Dim cml As New SqlClient.SqlCommand(sl, cn)
            cml.Parameters.AddWithValue("@dn", ComboBox5.Text)
            Dim rdl As SqlClient.SqlDataReader
            rdl = cml.ExecuteReader
            If rdl.Read = True Then
                Label2.Text = rdl!idd
            End If
            Dim s As String = "select * from Ejraa where Ejraa=@Ejraa AND IDK=@IDK"
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@Ejraa", ComboBox2.Text)
            cm.Parameters.AddWithValue("@IDK", CInt(TextBox6.Text))
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

                    'Me.ComboBox4.Text = ""
                    'Me.ComboBox5.Text = ""
                    'Me.TextBox1.Text = ""
                Catch ex As Exception
                    MsgBox(" لايمكن الحفظ ")
                End Try
                Dim sld As String = "select * from dn where dn<>@dn"
                Dim cmld As New SqlClient.SqlCommand(sld, cn)
                cmld.Parameters.AddWithValue("@dn", ComboBox5.Text)
                Dim rdld As SqlClient.SqlDataReader
                rdld = cmld.ExecuteReader
                Do While rdld.Read = True
                    Dim sfd As String = "select * from dnkema where idd=@idd and Ejraa=@Ejraa"
                    Dim cmfd As New SqlClient.SqlCommand(sfd, cn)
                    cmfd.Parameters.AddWithValue("@idd", CInt(Val(rdld!idd)))
                    cmfd.Parameters.AddWithValue("@Ejraa", CInt(Val(TextBox4.Text)))
                    Dim rdfd As SqlClient.SqlDataReader
                    rdfd = cmfd.ExecuteReader
                    If rdfd.Read = False Then
                        Dim ss23d As String = "insert into dnkema(idd,Ejraa,Kema,kemaej)VALUES(@idd,@Ejraa,@Kema,@kemaej)"
                        Dim cmm23d As New SqlClient.SqlCommand(ss23d, cn)
                        cmm23d.Parameters.AddWithValue("@idd", CInt(Val(Label2.Text)))
                        cmm23d.Parameters.AddWithValue("@Ejraa", CInt(Val(TextBox4.Text)))
                        cmm23d.Parameters.AddWithValue("@Kema", CDbl(TextBox2.Text))
                        cmm23d.Parameters.AddWithValue("@kemaej", CDbl(TextBox5.Text))
                        Try
                            cmm23d.ExecuteNonQuery()
                            MsgBox("تم الحفظ ")

                            'Me.ComboBox4.Text = ""
                            'Me.ComboBox5.Text = ""
                            'Me.TextBox1.Text = ""
                        Catch ex As Exception
                            MsgBox(" لايمكن الحفظ ")
                        End Try
                    End If
                Loop
                'Else
                '    Dim ss23 As String = "update dnkema set Ejraa=@Ejraa,Kema=@Kema,kemaej=@kemaej where idd=@idd"
                '    Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
                '    cmm23.Parameters.AddWithValue("@Ejraa", CInt(Val(TextBox4.Text)))
                '    cmm23.Parameters.AddWithValue("@Kema", CDbl(TextBox2.Text))
                '    cmm23.Parameters.AddWithValue("@kemaej", CDbl(TextBox5.Text))
                '    cmm23.Parameters.AddWithValue("@idd", CInt(Val(Label2.Text)))
                '    Try
                '        cmm23.ExecuteNonQuery()
                '        MsgBox("تم التعديل ")
                '    Catch ex As Exception
                '        MsgBox(" لايمكن التعديل ")
                '    End Try
            End If
            Me.DataGridView2.DataSource = ""
            Dim s1 As String = "select * from tabib "
            Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            Dim dss As New DataSet
            dss.Clear()
            aad.Fill(dss, "tabib")
            Dim vd As New DataView(dss.Tables("tabib"))
            vd.RowFilter = "dn=" & "'" & Me.ComboBox5.Text & "'" & ""
            Me.DataGridView2.DataMember = ""
            DataGridView2.DataSource = vd
            Dim sk1 As String
            sk1 = "select * from Ejraa"
            Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
            Dim dsk1 As New DataSet
            adk1.Fill(dsk1, "Ejraa")
            ComboBox2.DataSource = dsk1.Tables(0)
            ComboBox2.DisplayMember = "Ejraa"
            ComboBox2.SelectedIndex = -1

            Dim skd As String
            skd = "select * from dn"
            Dim adkd As New SqlClient.SqlDataAdapter(skd, cn)
            Dim dskd As New DataSet
            adkd.Fill(dskd, "dn")
            ComboBox5.DataSource = dskd.Tables(0)
            ComboBox5.DisplayMember = "dn"
            ComboBox5.SelectedIndex = -1

            Dim skk As String
            skk = "select * from kesem"
            Dim adkk As New SqlClient.SqlDataAdapter(skk, cn)
            Dim dskk As New DataSet
            adkk.Fill(dskk, "kesem")
            ComboBox4.DataSource = dskk.Tables(0)
            ComboBox4.DisplayMember = "kesem"
            ComboBox4.SelectedIndex = -1

            Dim sk2 As String
            sk2 = "select * from KESEM"
            Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "KESEM")
            ComboBox3.DataSource = dsk2.Tables(0)
            ComboBox3.DisplayMember = "KESEM"
            ComboBox3.SelectedIndex = -1
            ComboBox5.Focus()
            Call Class4.CONNIC()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(ComboBox3.Text) <> Trim("") Then
            If Trim(ComboBox1.Text) <> Trim("") Then
                'ElseIf ComboBox1.Text <> Trim("") Then
                Call Class1.CONNIC()
                'Dim st As String = "select count(idk) from kesem"
                'Dim cmt As New SqlClient.SqlCommand(st, cn)
                'Dim a As Integer = cmt.ExecuteScalar
                'Label1.Text = a + 1
                'Dim sKDF As String = "select * from KESEM where KESEM=@KESEM"
                'Dim cmKDF As New SqlClient.SqlCommand(sKDF, cn)
                'cmKDF.Parameters.AddWithValue("@KESEM", ComboBox3.Text)
                'Dim rdKDF As SqlClient.SqlDataReader
                'rdKDF = cmKDF.ExecuteReader
                'If rdKDF.Read = True Then
                '    Label1.Text = rdKDF!idK
                Dim ss2F As String = "insert into KESEM(kesem)VALUES(@kesem)"
                Dim cmm2F As New SqlClient.SqlCommand(ss2F, cn)
                'cmm2F.Parameters.AddWithValue("@idk", Label1.Text)
                cmm2F.Parameters.AddWithValue("@kesem", Trim(ComboBox3.Text))
                Try
                    cmm2F.ExecuteNonQuery()
                Catch ex As Exception

                End Try

                'Dim sKD As String = "select * from KESEM where KESEM=@KESEM"
                'Dim cmKD As New SqlClient.SqlCommand(sKD, cn)
                'cmKD.Parameters.AddWithValue("@KESEM", ComboBox3.Text)
                'Dim rdKD As SqlClient.SqlDataReader
                'rdKD = cmKD.ExecuteReader
                'If rdKD.Read = True Then
                '    Label7.Text = rdKD!idK
                'End If
                'rdKD.Close()
                Dim sK As String = "select * from KESEM where KESEM=@KESEM"
                Dim cmK As New SqlClient.SqlCommand(sK, cn)
                cmK.Parameters.AddWithValue("@KESEM", Trim(ComboBox3.Text))
                Dim rdK As SqlClient.SqlDataReader
                rdK = cmK.ExecuteReader
                If rdK.Read = True Then
                    Label1.Text = rdK!idK
                End If
                rdK.Close()
                'Dim sKD5 As String = "select * from EJRAA where EJRAA=@EJRAA"
                'Dim cmKD5 As New SqlClient.SqlCommand(sKD5, cn)
                'cmKD5.Parameters.AddWithValue("@EJRAA", ComboBox1.Text)
                'Dim rdKD5 As SqlClient.SqlDataReader
                'rdKD5 = cmKD5.ExecuteReader
                'If rdKD5.Read = False Then
                'If ComboBox1.Text <> "" Then
                Dim sKE As String = "select * from EJRAA where EJRAA=@EJRAA and idk=@idk"
                Dim cmKE As New SqlClient.SqlCommand(sKE, cn)
                cmKE.Parameters.AddWithValue("@EJRAA", Trim(ComboBox1.Text))
                cmKE.Parameters.AddWithValue("@idk", CInt(Label1.Text))
                Dim rdKE As SqlClient.SqlDataReader
                rdKE = cmKE.ExecuteReader
                If rdKE.Read = False Then
                    Dim ss23 As String = "insert into Ejraa(Ejraa,IDK) VALUES(@Ejraa,@IDK)"
                    ' Dim cmm23 As New OleDb.OleDbCommand(ss23, cn)
                    Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
                    cmm23.Parameters.AddWithValue("@Ejraa", Trim(ComboBox1.Text))
                    cmm23.Parameters.AddWithValue("@IDK", CInt(Label1.Text))
                    Try
                        cmm23.ExecuteNonQuery()
                        MsgBox("تم الحفظ ")
                        Dim Str2 As String = "SELECT MAX(IDJ) FROM Ejraa "
                        Dim cmd2 As New SqlClient.SqlCommand(Str2, cn)
                        If IsDBNull(cmd2.ExecuteScalar) = True Then
                            NOFATORAX = 0
                        Else
                            NOFATORAX = cmd2.ExecuteScalar
                        End If
                        Dim sKED As String = "select * from dn where idk=@idk"
                        Dim cmKED As New SqlClient.SqlCommand(sKED, cn)
                        cmKED.Parameters.AddWithValue("@idk", CInt(Label1.Text))
                        Dim rdKED As SqlClient.SqlDataReader
                        rdKED = cmKED.ExecuteReader
                        Do While rdKED.Read = True
                            'Dim sKEn As String = "select * from dnkema where idd=@idd and idk=@idk"
                            'Dim cmKEn As New SqlClient.SqlCommand(sKEn, cn)
                            'cmKEn.Parameters.AddWithValue("@EJRAA", Trim(ComboBox1.Text))
                            'cmKEn.Parameters.AddWithValue("@idk", CInt(Label1.Text))
                            'Dim rdKEn As SqlClient.SqlDataReader
                            'rdKEn = cmKEn.ExecuteReader
                            'If rdKEn.Read = False Then
                            Dim ss23D As String = "insert into dnkema(idd,Ejraa,Kema,kemaej)VALUES(@idd,@Ejraa,@Kema,@kemaej)"
                            Dim cmm23D As New SqlClient.SqlCommand(ss23D, cn)
                            cmm23D.Parameters.AddWithValue("@idd", CInt(Val(rdKED!idd)))
                            cmm23D.Parameters.AddWithValue("@Ejraa", CInt(Val(NOFATORAX)))
                            cmm23D.Parameters.AddWithValue("@Kema", CDbl(0))
                            cmm23D.Parameters.AddWithValue("@kemaej", CDbl(0))
                            Try
                                cmm23D.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(" لايمكن الحفظ ")
                                End Try
                            'End If
                        Loop
                        'Me.DataGridView1.DataSource = ""
                        'Dim s1 As String = "select * from Ejraa "
                        'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                        'Dim dss As New DataSet
                        'dss.Clear()
                        'aad.Fill(dss, "Ejraa")
                        'Dim vd As New DataView(dss.Tables("Ejraa"))
                        'vd.RowFilter = "Ejraa=" & "'" & Me.ComboBox1.Text & "'" & ""
                        'Me.DataGridView1.DataMember = ""
                        'DataGridView1.DataSource = vd
                        'Dim sk1 As String
                        'sk1 = "select * from Ejraa"
                        'Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                        'Dim dsk1 As New DataSet
                        'adk1.Fill(dsk1, "Ejraa")
                        'ComboBox2.DataSource = dsk1.Tables(0)
                        'ComboBox2.DisplayMember = "Ejraa"
                        'ComboBox2.SelectedIndex = -1

                        'Dim skd As String
                        'skd = "select * from dn"
                        'Dim adkd As New SqlClient.SqlDataAdapter(skd, cn)
                        'Dim dskd As New DataSet
                        'adkd.Fill(dskd, "dn")
                        'ComboBox5.DataSource = dskd.Tables(0)
                        'ComboBox5.DisplayMember = "dn"
                        'ComboBox5.SelectedIndex = -1

                        'Dim skk As String
                        'skk = "select * from kesem"
                        'Dim adkk As New SqlClient.SqlDataAdapter(skk, cn)
                        'Dim dskk As New DataSet
                        'adkk.Fill(dskk, "kesem")
                        'ComboBox4.DataSource = dskk.Tables(0)
                        'ComboBox4.DisplayMember = "kesem"
                        'ComboBox4.SelectedIndex = -1

                        'Dim sk2 As String
                        'sk2 = "select * from KESEM"
                        'Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                        'Dim dsk2 As New DataSet
                        'adk2.Fill(dsk2, "KESEM")
                        'ComboBox3.DataSource = dsk2.Tables(0)
                        'ComboBox3.DisplayMember = "KESEM"
                        'ComboBox3.SelectedIndex = -1

                        'Me.ComboBox3.Text = ""
                        'Me.TextBox3.Text = ""
                    Catch ex As Exception
                        MsgBox(" لايمكن الحفظ ")
                    End Try
                End If

                'Dim ss23S As String = "insert into Ejraa(Ejraa,IDK) VALUES(@Ejraa,@IDK)"
                '' Dim cmm23 As New OleDb.OleDbCommand(ss23, cn)
                'Dim cmm23S As New SqlClient.SqlCommand(ss23S, cn)
                'cmm23S.Parameters.AddWithValue("@Ejraa", "كشف")
                'cmm23S.Parameters.AddWithValue("@IDK", CInt(Label1.Text))
                'Try
                '    cmm23S.ExecuteNonQuery()
                'Catch ex As Exception

                'End Try

                'Catch ex As Exception

                'End Try
                'rdKDF.Close()


                'End If
                'Me.DataGridView1.DataSource = ""
                'Dim s1 As String = "select * from Ejraa "
                'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                'Dim dss As New DataSet
                'dss.Clear()
                'aad.Fill(dss, "Ejraa")
                'Dim vd As New DataView(dss.Tables("Ejraa"))
                'vd.RowFilter = "Ejraa=" & "'" & Me.ComboBox1.Text & "'" & ""
                'Me.DataGridView1.DataMember = ""
                'DataGridView1.DataSource = vd
                Dim sk1 As String
                sk1 = "select * from Ejraa"
                Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
                Dim dsk1 As New DataSet
                adk1.Fill(dsk1, "Ejraa")
                ComboBox2.DataSource = dsk1.Tables(0)
                ComboBox2.DisplayMember = "Ejraa"
                ComboBox2.SelectedIndex = -1

                Dim skd2 As String
                skd2 = "select * from dn"
                Dim adkd As New SqlClient.SqlDataAdapter(skd2, cn)
                Dim dskd As New DataSet
                adkd.Fill(dskd, "dn")
                ComboBox5.DataSource = dskd.Tables(0)
                ComboBox5.DisplayMember = "dn"
                ComboBox5.SelectedIndex = -1

                Dim skk As String
                skk = "select * from kesem"
                Dim adkk As New SqlClient.SqlDataAdapter(skk, cn)
                Dim dskk As New DataSet
                adkk.Fill(dskk, "kesem")
                ComboBox4.DataSource = dskk.Tables(0)
                ComboBox4.DisplayMember = "kesem"
                ComboBox4.SelectedIndex = -1

                Dim skkK As String
                skkK = "select * from kesem"
                Dim adkkK As New SqlClient.SqlDataAdapter(skkK, cn)
                Dim dskkK As New DataSet
                adkkK.Fill(dskkK, "kesem")
                ComboBox6.DataSource = dskkK.Tables(0)
                ComboBox6.DisplayMember = "kesem"
                ComboBox6.SelectedIndex = -1

                Dim sk2 As String
                sk2 = "select * from KESEM"
                Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "KESEM")
                ComboBox3.DataSource = dsk2.Tables(0)
                ComboBox3.DisplayMember = "KESEM"
                ComboBox3.SelectedIndex = -1

                Me.ComboBox3.Text = ""
                Me.TextBox3.Text = ""

                Call Class4.CONNIC()

            Else
                MsgBox("تأكد من الإجراء")
                ComboBox1.Focus()
            End If
        Else
            MsgBox("تأكد من القسم")
            ComboBox3.Focus()
        End If
        'Else
        'MsgBox(" لايمكن الحفظ ")
        ComboBox3.Focus()
        Label7.Text = 0

        'End If
    End Sub

    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox3.Text = "" Then
                ComboBox3.Focus()
            Else
                ComboBox1.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim B As String
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", Trim(ComboBox3.Text))
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label10.Text = rdG!IDK
                Dim sk21 As String
                sk21 = "select * from Ejraa where IDK=" & B
                Using adk21 As New SqlClient.SqlDataAdapter(sk21, cn)
                    Dim dsk21 As New DataSet
                    adk21.Fill(dsk21, "Ejraa")
                    ComboBox1.DataSource = dsk21.Tables(0)
                    ComboBox1.DisplayMember = "Ejraa"
                    ComboBox1.SelectedIndex = -1
                End Using
                dgv1()
            Else
                'ComboBox1.SelectedText = "كشف"

            End If
            Button1.Visible = True
            Button5.Visible = False
            rdG.Close()
            'end using
        End Using
        'Dim s1 As String = "SELECT dbo.Ejraa.IDJ,dbo.KESEM.IDK, dbo.KESEM.KESEM, dbo.Ejraa.Ejraa 
        '                 FROM  dbo.Ejraa INNER JOIN
        '                 dbo.KESEM ON dbo.Ejraa.IDK = dbo.KESEM.IDK "
        'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        'Dim dss As New DataSet
        'dss.Clear()
        'aad.Fill(dss, "dbo.Ejraa INNER JOIN
        '                 dbo.KESEM")
        'Dim vd As New DataView(dss.Tables("dbo.Ejraa INNER JOIN
        '                 dbo.KESEM"))
        'vd.RowFilter = "KESEM=" & "'" & Me.ComboBox3.Text & "'" & ""
        'Me.DataGridView1.DataMember = ""
        'DataGridView1.DataSource = vd
        Call Class4.CONNIC()
    End Sub
    Sub dgv1()
        Try
            Call Class1.CONNIC()
            Dim DAA As New SqlClient.SqlDataAdapter("SELECT dbo.KESEM.KESEM, dbo.Ejraa.Ejraa, dbo.KESEM.IDK, dbo.Ejraa.IDJ
                         FROM dbo.Ejraa INNER JOIN
                         dbo.KESEM ON dbo.Ejraa.IDK = dbo.KESEM.IDK where dbo.KESEM.IDK=" & Label10.Text & "", cn)
            Dim DTA As New DataTable
            DAA.Fill(DTA)
            DataGridView1.Rows.Clear()
            For Each ITEM As DataRow In DTA.Rows
                Dim n As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(n).Cells(0).Value = Trim(ITEM(0).ToString())
                DataGridView1.Rows(n).Cells(1).Value = Trim(ITEM(1).ToString())
                DataGridView1.Rows(n).Cells(2).Value = CInt(ITEM(2).ToString())
                DataGridView1.Rows(n).Cells(3).Value = CInt(ITEM(3).ToString())
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox1.Text = "" Then
                ComboBox1.Focus()
            Else
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_Validated(sender As Object, e As EventArgs) Handles ComboBox1.Validated
        Dim r1 As String = Replace(ComboBox1.Text, "أ", "ا")
        Dim r2 As String = Replace(r1, "ى", "ي")
        Dim r3 As String = Replace(r2, "ة", "ه")
        Me.ComboBox1.Text = r3
    End Sub

    Private Sub ComboBox3_TextChanged(sender As Object, e As EventArgs) Handles ComboBox3.TextChanged
        Call Class1.CONNIC()
        Dim B As String
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Label10.Text = rdG!IDK
                Dim sk21 As String
                sk21 = "select * from Ejraa where IDK=" & B
                Using adk21 As New SqlClient.SqlDataAdapter(sk21, cn)
                    Dim dsk21 As New DataSet
                    adk21.Fill(dsk21, "Ejraa")
                    ComboBox1.DataSource = dsk21.Tables(0)
                    ComboBox1.DisplayMember = "Ejraa"
                    ComboBox1.SelectedIndex = -1
                End Using
                dgv1()
            Else
                'ComboBox1.SelectedText = "كشف"

            End If
            rdG.Close()
            'end using
        End Using
        'Dim s1 As String = "select * from EJRAAK_V "
        'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        'Dim dss As New DataSet
        'dss.Clear()
        'aad.Fill(dss, "EJRAAK_V")
        'Dim vd As New DataView(dss.Tables("EJRAAK_V"))
        'vd.RowFilter = "KESEM=" & "'" & Me.ComboBox3.Text & "'" & ""
        'Me.DataGridView1.DataMember = ""
        'DataGridView1.DataSource = vd
        Call Class4.CONNIC()
    End Sub

    Private Sub ComboBox3_Validated(sender As Object, e As EventArgs) Handles ComboBox3.Validated
        Call Class1.CONNIC()
        Dim r1 As String = Replace(ComboBox3.Text, "أ", "ا")
        Dim r2 As String = Replace(r1, "ى", "ي")
        Dim r3 As String = Replace(r2, "ة", "ه")
        Me.ComboBox3.Text = r3
        Dim B As String
        Dim sG As String = "select * from KESEM where KESEM=@xx1 "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@xx1", ComboBox3.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                B = rdG!IDK
                Dim sk21 As String
                sk21 = "select * from Ejraa where IDK=" & B
                Using adk21 As New SqlClient.SqlDataAdapter(sk21, cn)
                    Dim dsk21 As New DataSet
                    adk21.Fill(dsk21, "Ejraa")
                    ComboBox1.DataSource = dsk21.Tables(0)
                    ComboBox1.DisplayMember = "Ejraa"
                    ComboBox1.SelectedIndex = -1
                End Using
            Else
                ComboBox1.Text = Trim("كشف")

            End If
            rdG.Close()
            'end using
        End Using
        'Dim s1 As String = "select * from EJRAAK_V "
        'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        'Dim dss As New DataSet
        'dss.Clear()
        'aad.Fill(dss, "EJRAAK_V")
        'Dim vd As New DataView(dss.Tables("EJRAAK_V"))
        'vd.RowFilter = "KESEM=" & "'" & Me.ComboBox3.Text & "'" & ""
        'Me.DataGridView1.DataMember = ""
        'DataGridView1.DataSource = vd
        dgv1()
        Call Class4.CONNIC()

    End Sub

    Private Sub ComboBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox5.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox5.Text = "" Then
                ComboBox5.Focus()
            Else
                Dim r1 As String = Replace(ComboBox5.Text, "أ", "ا")
                Dim r2 As String = Replace(r1, "ى", "ي")
                Dim r3 As String = Replace(r2, "ة", "ه")
                Me.ComboBox5.Text = r3

                ComboBox4.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        'If Trim(ComboBox5.Text) <> "" Then
        Try
            Call Class1.CONNIC()
            'Dim r1 As String = Replace(ComboBox5.Text, "أ", "ا")
            'Dim r2 As String = Replace(r1, "ى", "ي")
            'Dim r3 As String = Replace(r2, "ة", "ه")
            'Me.ComboBox5.Text = r3
            Dim s As String = "select * from doctor_view where dn=@dn" ' and ejraa=@ejraa "
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@dn", Trim(ComboBox5.Text))
            'cm.Parameters.AddWithValue("@ejraa", Trim(ComboBox2.Text))
            Using rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    TextBox3.Text = rd!notel
                    TextBox1.Text = rd!idd
                    GroupBox10.Text = "أنقر هنا لتعديل اسم الطبيب"
                    GroupBox10.ForeColor = Color.Blue
                    dgxx = rd!IDD
                    ComboBox4.Text = rd!kesem
                    ComboBox4.Enabled = False
                    GroupBox9.Text = "أنقر لتعديل القسم"
                    DataGridView1.Rows.Clear()
                    ComboBox2.Text = rd!ejraa
                    TextBox2.Text = CDbl(rd!kema)
                    TextBox5.Text = CDbl(rd!kemaej)
                    TextBox3.Text = rd!notel
                    Dim s12 As String = "select * from tabib "
                    Dim aad2 As New SqlClient.SqlDataAdapter(s12, cn)
                    Dim dss2 As New DataSet
                    dss2.Clear()
                    aad2.Fill(dss2, "tabib")
                    Dim vd2 As New DataView(dss2.Tables("tabib"))
                    vd2.RowFilter = "dn=" & "'" & Trim(Me.ComboBox5.Text) & "'" & ""
                    Me.DataGridView2.DataMember = ""
                    DataGridView2.DataSource = vd2


                Else
                    Call Class1.CONNIC()
                    Dim sg As String = "select * from dn_v where dn=@dn "
                    Dim cmg As New SqlClient.SqlCommand(sg, cn)
                    cmg.Parameters.AddWithValue("@dn", Trim(ComboBox5.Text))
                    Using rdg As SqlClient.SqlDataReader = cmg.ExecuteReader
                        If rdg.Read = True Then
                            TextBox3.Text = rdg!notel
                            TextBox1.Text = rdg!idd
                            GroupBox10.Text = "أنقر هنا لتعديل اسم الطبيب"
                            GroupBox10.ForeColor = Color.Blue
                            ComboBox4.Text = rdg!kesem
                            TextBox3.Text = rdg!notel
                            DataGridView1.Rows.Clear()
                            ComboBox2.Text = ""
                            TextBox2.Text = 0
                            TextBox5.Text = 0
                            Dim s11 As String = "select * from tabib "
                            Dim aad1 As New SqlClient.SqlDataAdapter(s11, cn)
                            Dim dss1 As New DataSet
                            dss1.Clear()
                            aad1.Fill(dss1, "tabib")
                            Dim vd1 As New DataView(dss1.Tables("tabib"))
                            vd1.RowFilter = "dn=" & "'" & Trim(Me.ComboBox5.Text) & "'" & ""
                            Me.DataGridView2.DataMember = ""
                            DataGridView2.DataSource = vd1

                        Else
                            GroupBox10.Text = "اسم الطبيب"
                            GroupBox10.ForeColor = Color.Black
                            GroupBox9.Text = "القسم"
                            GroupBox9.ForeColor = Color.Black
                            ComboBox4.Enabled = True
                            ComboBox4.DropDownStyle = ComboBoxStyle.DropDown
                            ComboBox4.Text = ""
                            ComboBox2.Text = ""
                            ComboBox4.SelectedIndex = -1
                            ComboBox2.SelectedIndex = -1
                            TextBox2.Text = 0
                            TextBox3.Text = ""
                            TextBox5.Text = 0
                            TextBox1.Text = 0
                            DataGridView2.DataSource = ""
                        End If
                    End Using
                End If
            End Using
            Call Class1.CONNIC()
            Dim s1 As String = "select * from tabib "
            Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
            Dim dss As New DataSet
            dss.Clear()
            aad.Fill(dss, "tabib")
            Dim vd As New DataView(dss.Tables("tabib"))
            vd.RowFilter = "dn=" & "'" & Trim(Me.ComboBox5.Text) & "'" & ""
            Me.DataGridView2.DataMember = ""
            DataGridView2.DataSource = vd
            Call Class4.CONNIC()

        Catch ex As Exception

        End Try
        'End If
    End Sub

    Private Sub ComboBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox4.Text = "" Then
                ComboBox4.Focus()
            Else
                TextBox3.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedIndex <> -1 Then
            Call Class1.CONNIC()
            Dim B As String
            Dim sG As String = "select * from KESEM where KESEM=@xx1 "
            Using cmG As New SqlClient.SqlCommand(sG, cn)
                cmG.Parameters.AddWithValue("@xx1", ComboBox4.Text)
                Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
                If rdG.Read = True Then
                    B = rdG!IDK
                    Dim sk23 As String
                    sk23 = "select * from Ejraa where IDK=" & B
                    Using adk23 As New SqlClient.SqlDataAdapter(sk23, cn)
                        Dim dsk23 As New DataSet
                        adk23.Fill(dsk23, "Ejraa")
                        ComboBox2.DataSource = dsk23.Tables(0)
                        ComboBox2.DisplayMember = "Ejraa"
                        'ComboBox3.SelectedIndex = -1
                    End Using
                End If
                rdG.Close()
            End Using
            Call Class4.CONNIC()
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox2.Text = "" Then
                ComboBox2.Focus()
            Else
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sJ As String = "select * from EJRAAK_V where ejraa=@ejraa and KESEM=@KESEM "
        Dim cmJ As New SqlClient.SqlCommand(sJ, cn)
        cmJ.Parameters.AddWithValue("@ejraa", ComboBox2.Text)
        cmJ.Parameters.AddWithValue("@KESEM", ComboBox4.Text)
        Using rdJ As SqlClient.SqlDataReader = cmJ.ExecuteReader
            If rdJ.Read = True Then
                Label8.Text = CInt(rdJ!IDJ)
            End If
        End Using

        Dim s As String = "select * from DNKEMA where IDD=@IDD and ejraa=@ejraa"
        Dim cm As New SqlClient.SqlCommand(s, cn)
        cm.Parameters.AddWithValue("@IDD", CInt(TextBox1.Text))
        cm.Parameters.AddWithValue("@ejraa", CInt(Label8.Text))
        Using rd As SqlClient.SqlDataReader = cm.ExecuteReader
            If rd.Read = True Then
                TextBox2.Text = CDbl(rd!kema)
                TextBox5.Text = CDbl(rd!kemaej)
            Else
                TextBox2.Text = 0
                TextBox5.Text = 0
            End If
        End Using

        'Dim s As String = "select * from doctor_view where dn=@dn and ejraa=@ejraa and kesem=@kesem "
        'Dim cm As New SqlClient.SqlCommand(s, cn)
        'cm.Parameters.AddWithValue("@dn", ComboBox5.Text)
        'cm.Parameters.AddWithValue("@ejraa", ComboBox2.Text)
        'cm.Parameters.AddWithValue("@kesem", ComboBox4.Text)
        'Using rd As SqlClient.SqlDataReader = cm.ExecuteReader
        '    If rd.Read = True Then
        '        TextBox2.Text = rd!kema
        '        TextBox5.Text = rd!kemaej
        '    End If
        'End Using
        Call Class4.CONNIC()

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox3.Text = "" Then
                TextBox3.Text = "لايوجد"
            End If
            ComboBox2.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox2.Text = "" Then
                TextBox2.Focus()
            Else
                TextBox5.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        'If TextBox2.Text = "." Or Double.Parse(TextBox2.Text) = 0 Then
        '    TextBox2.Text = String.Empty
        'End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox5.Text = "" Then
                TextBox5.Focus()
            Else
                B11.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub GroupBox9_Click(sender As Object, e As EventArgs) Handles GroupBox9.Click
        If GroupBox9.Text = "أنقر لتعديل القسم" Then
            dgxx = TextBox1.Text
            kemax = CDbl(TextBox2.Text)
            kematx = CDbl(TextBox5.Text)
            Dim F As New TADEELvb
            F.ShowDialog()
            setting_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub GroupBox9_Enter(sender As Object, e As EventArgs) Handles GroupBox9.Enter
    End Sub

    Private Sub حذفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفToolStripMenuItem.Click
        Call Class1.CONNIC()
        Dim sd As String = "delete from EJRAA where idJ=@IDJ"
        Dim cd As New SqlClient.SqlCommand(sd, cn)
        cd.Parameters.AddWithValue("@IDJ", CInt(Label7.Text))
        Dim sd1 As String = "delete from DNKEMA where EJRAA=@IDJ"
        Dim cd1 As New SqlClient.SqlCommand(sd1, cn)
        cd1.Parameters.AddWithValue("@IDJ", CInt(Label7.Text))
        If MsgBox("هل تريد حذف الترصيد", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Call Class1.CONNIC()
                cd.ExecuteNonQuery()
                cd1.ExecuteNonQuery()
                MsgBox("تم الحذف")
                'Call Class1.CONNIC()
                'Dim ss As String = "select * from EJRAAK_V "
                'Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
                'Dim dss As New DataSet
                'dss.Clear()
                'aad.Fill(dss, "EJRAAK_V")
                'Dim vdd As New DataView(dss.Tables("EJRAAK_V"))
                'vdd.RowFilter = " KESEM =" & "'" & Trim(ComboBox3.Text) & "'" & ""
                'DataGridView1.DataMember = ""
                'DataGridView1.DataSource = vdd
                dgv1()
            Catch ex As Exception
                MsgBox("لم يتم الحذف")
            End Try
        End If
        Call Class4.CONNIC()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If e.RowIndex < 0 Then
            Return
        End If
        If e.ColumnIndex < 0 Then
            Return
        End If
        Me.Label7.Text = DataGridView1.Item(3, e.RowIndex).Value
        ComboBox3.Text = DataGridView1.Item(0, e.RowIndex).Value
        ComboBox1.Text = DataGridView1.Item(1, e.RowIndex).Value
        Me.Label1.Text = DataGridView1.Item(2, e.RowIndex).Value
        Button5.Visible = True
        Button1.Visible = False
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDown
        'Select Case e.RowIndex
        '    Case Is >= 0
        If e.RowIndex < 0 Then
            Return
        End If
        If e.ColumnIndex < 0 Then
            Return
        End If
        dgx = DataGridView2.Item(0, e.RowIndex).Value
        dgxx = DataGridView2.Item(1, e.RowIndex).Value
                Ejraax = DataGridView2.Item(3, e.RowIndex).Value
                Me.Label7.Text = CInt(dgxx)
                TextBox1.Text = CInt(dgx)
                Dim s As String = "select * from doctor_view where dn=@dn and ejraa=@ejraa "
                Dim cm As New SqlClient.SqlCommand(s, cn)
                cm.Parameters.AddWithValue("@dn", Trim(ComboBox5.Text))
                cm.Parameters.AddWithValue("@ejraa", Trim(Ejraax))
                Using rd As SqlClient.SqlDataReader = cm.ExecuteReader
                    If rd.Read = True Then
                        TextBox3.Text = rd!notel
                        TextBox1.Text = rd!idd
                        ComboBox2.Text = Trim(Ejraax)
                        TextBox2.Text = CDbl(rd!KEMA)
                        TextBox5.Text = CDbl(rd!KEMAEJ)
                    End If
                End Using

        'End Select

    End Sub

    Private Sub حذفToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles حذفToolStripMenuItem1.Click
        Call Class1.CONNIC()
        Dim sd As String = "delete from DNKEMA where IDD=@IDD AND EJRAA=@EJRAA"
        Dim cd As New SqlClient.SqlCommand(sd, cn)
        cd.Parameters.AddWithValue("@IDD", CInt(TextBox1.Text))
        cd.Parameters.AddWithValue("@EJRAA", CInt(Label7.Text))
        If MsgBox("هل تريد حذف الترصيد", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Call Class1.CONNIC()
                cd.ExecuteNonQuery()
                MsgBox("تم الحذف")
                Call Class1.CONNIC()
                Dim ss As String = "select * from TABIB "
                Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
                Dim dss As New DataSet
                dss.Clear()
                aad.Fill(dss, "TABIB")
                Dim vdd As New DataView(dss.Tables("TABIB"))
                vdd.RowFilter = " DN =" & "'" & Trim(ComboBox5.Text) & "'" & ""
                DataGridView2.DataMember = ""
                DataGridView2.DataSource = vdd
            Catch ex As Exception
                MsgBox("لم يتم الحذف")
            End Try
        End If
        Call Class4.CONNIC()

    End Sub

    Private Sub ComboBox5_StyleChanged(sender As Object, e As EventArgs) Handles ComboBox5.StyleChanged

    End Sub

    Private Sub ComboBox5_TextChanged(sender As Object, e As EventArgs) Handles ComboBox5.TextChanged
        'If (ComboBox5.SelectedIndex) <> -1 Then
        Try
            'Call Class1.CONNIC()
            'Dim r1 As String = Replace(ComboBox5.Text, "أ", "ا")
            'Dim r2 As String = Replace(r1, "ى", "ي")
            'Dim r3 As String = Replace(r2, "ة", "ه")
            'Me.ComboBox5.Text = r3
            Call Class1.CONNIC()

            Dim s As String = "select * from doctor_view where dn=@dn and ejraa=@ejraa "
            Dim cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@dn", Trim(ComboBox5.Text))
            cm.Parameters.AddWithValue("@ejraa", Trim(ComboBox2.Text))
            Using rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    TextBox3.Text = rd!notel
                    TextBox1.Text = rd!idd
                    GroupBox10.Text = "أنقر هنا لتعديل اسم الطبيب"
                    GroupBox10.ForeColor = Color.Blue
                    dgxx = rd!IDD
                    ComboBox4.Text = rd!kesem
                    ComboBox4.Enabled = False
                    GroupBox9.Text = "أنقر لتعديل القسم"
                    DataGridView1.Rows.Clear()
                    ComboBox2.Text = rd!ejraa
                    TextBox2.Text = CDbl(rd!kema)
                    TextBox5.Text = CDbl(rd!kemaej)
                    TextBox3.Text = rd!notel
                    'rd.Close()
                Else
                    Call Class1.CONNIC()
                    Dim sg As String = "select * from dn_v where dn=@dn "
                    Dim cmg As New SqlClient.SqlCommand(sg, cn)
                    cmg.Parameters.AddWithValue("@dn", ComboBox5.Text)
                    Using rdg As SqlClient.SqlDataReader = cmg.ExecuteReader
                        If rdg.Read = True Then
                            TextBox3.Text = rdg!notel
                            TextBox1.Text = rdg!idd
                            GroupBox10.Text = "أنقر هنا لتعديل اسم الطبيب"
                            GroupBox10.ForeColor = Color.Blue
                            ComboBox4.Text = rdg!kesem
                            TextBox3.Text = rdg!notel
                            DataGridView1.Rows.Clear()
                            ComboBox2.Text = ""
                            TextBox2.Text = 0
                            TextBox5.Text = 0
                        Else
                            GroupBox10.Text = "اسم الطبيب"
                            GroupBox10.ForeColor = Color.Black
                            GroupBox9.Text = "القسم"
                            GroupBox9.ForeColor = Color.Black
                            ComboBox4.Enabled = True
                            ComboBox4.DropDownStyle = ComboBoxStyle.DropDown
                            ComboBox4.Text = ""
                            ComboBox2.Text = ""
                            ComboBox4.SelectedIndex = -1
                            ComboBox2.SelectedIndex = -1
                            TextBox2.Text = 0
                            TextBox3.Text = ""
                            TextBox5.Text = 0
                            TextBox1.Text = 0
                            DataGridView2.DataSource = ""
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
            vd.RowFilter = "dn=" & "'" & Trim(Me.ComboBox5.Text) & "'" & ""
            Me.DataGridView2.DataMember = ""
            DataGridView2.DataSource = vd
            Call Class4.CONNIC()
            'Else
            'End If

        Catch ex As Exception
            GroupBox10.Text = "اسم الطبيب"
            GroupBox10.ForeColor = Color.Black
            GroupBox9.Text = "القسم"
            GroupBox9.ForeColor = Color.Black
            ComboBox4.Enabled = True
            ComboBox4.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox4.Text = ""
            ComboBox2.Text = ""
            ComboBox4.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox5.Text = ""
            TextBox1.Text = 0
            DataGridView2.DataSource = ""

        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Panel3.Enabled = False
            Panel5.Enabled = False
            Panel2.Enabled = True
            Panel8.Enabled = False
            DataGridView1.Rows.Clear()
            GroupBox10.Text = "اسم الطبيب"
            GroupBox10.ForeColor = Color.Black
            GroupBox9.Text = "القسم"
            GroupBox9.ForeColor = Color.Black
            ComboBox4.Enabled = True
            ComboBox4.Text = ""
            ComboBox2.Text = ""
            ComboBox4.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            ComboBox6.Text = ""
            ComboBox7.Text = ""
            ComboBox6.SelectedIndex = -1
            ComboBox7.SelectedIndex = -1
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox5.Text = ""
            TextBox9.Text = ""
            ComboBox3.Focus()
        Else
            'Panel2.Enabled = False
            'Panel5.Enabled = False
            'Panel3.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Panel2.Enabled = False
            Panel5.Enabled = False
            Panel3.Enabled = True
            Panel8.Enabled = False
            ComboBox3.Text = ""
            ComboBox1.Text = ""
            ComboBox3.SelectedIndex = -1
            ComboBox1.SelectedIndex = -1
            'DataGridView2.DataSource = ""
            ComboBox5.Focus()
        Else
            'Panel3.Enabled = False
            'Panel2.Enabled = True
        End If

    End Sub

    Private Sub GroupBox10_Click(sender As Object, e As EventArgs) Handles GroupBox10.Click
        If GroupBox10.Text = "أنقر هنا لتعديل اسم الطبيب" Then
            dgxx = TextBox1.Text
            Dim F As New TADEELDN
            F.ShowDialog()
            setting_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub GroupBox10_DockChanged(sender As Object, e As EventArgs) Handles GroupBox10.DockChanged
    End Sub

    Private Sub GroupBox10_Enter(sender As Object, e As EventArgs) Handles GroupBox10.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Trim(ComboBox7.Text) <> Trim("") Then
            If Trim(ComboBox6.Text) <> Trim("") Then
                Call Class1.CONNIC()
                Dim sKDF As String = "select * from TYPEEYWAA where EYWAATYPE=@EYWAATYPE"
                Dim cmKDF As New SqlClient.SqlCommand(sKDF, cn)
                cmKDF.Parameters.AddWithValue("@EYWAATYPE", ComboBox7.Text)
                Dim rdKDF As SqlClient.SqlDataReader
                rdKDF = cmKDF.ExecuteReader
                If rdKDF.Read = True Then
                    Label9.Text = rdKDF!idEY
                    Dim ss2FS As String = "UPDATE TYPEEYWAA SET EYWAATYPE=@EYWAATYPE,IDK=@IDK,SE3REYWAA=@SE3REYWAA WHERE IDEY=@IDEY"
                    Dim cmm2FS As New SqlClient.SqlCommand(ss2FS, cn)
                    'cmm2F.Parameters.AddWithValue("@idk", Label1.Text)
                    cmm2FS.Parameters.AddWithValue("@EYWAATYPE", ComboBox7.Text)
                    cmm2FS.Parameters.AddWithValue("@IDK", CInt(Label1.Text))
                    cmm2FS.Parameters.AddWithValue("@SE3REYWAA", CDbl(TextBox9.Text))
                    cmm2FS.Parameters.AddWithValue("@IDEY", CInt(Label9.Text))
                    Try
                        cmm2FS.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("TYPEEYWAA update")
                    End Try
                    Me.DataGridView3.DataSource = ""
                    Dim s1 As String = "select * from TYPEEYWAA "
                    Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                    Dim dss As New DataSet
                    dss.Clear()
                    aad.Fill(dss, "TYPEEYWAA")
                    Dim vd As New DataView(dss.Tables("TYPEEYWAA"))
                    vd.RowFilter = "EYWAATYPE=" & "'" & Me.ComboBox7.Text & "'" & ""
                    Me.DataGridView3.DataMember = ""
                    DataGridView3.DataSource = vd
                Else
                    Dim ss23S As String = "insert into TYPEEYWAA(EYWAATYPE,IDK,SE3REYWAA) VALUES(@EYWAATYPE,@IDK,@SE3REYWAA)"
                    ' Dim cmm23 As New OleDb.OleDbCommand(ss23, cn)
                    Dim cmm23S As New SqlClient.SqlCommand(ss23S, cn)
                    cmm23S.Parameters.AddWithValue("@EYWAATYPE", Trim(ComboBox7.Text))
                    cmm23S.Parameters.AddWithValue("@IDK", CInt(Label1.Text))
                    cmm23S.Parameters.AddWithValue("@SE3REYWAA", CDbl(TextBox9.Text))
                    Try
                        cmm23S.ExecuteNonQuery()
                        MsgBox("تمت عملية الحفظ")
                    Catch ex As Exception
                        MsgBox("TYPEEYWAA insert")
                    End Try
                    Me.DataGridView3.DataSource = ""
                    Dim s1 As String = "select * from TYPEEYWAA "
                    Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                    Dim dss As New DataSet
                    dss.Clear()
                    aad.Fill(dss, "TYPEEYWAA")
                    Dim vd As New DataView(dss.Tables("TYPEEYWAA"))
                    vd.RowFilter = "EYWAATYPE=" & "'" & Me.ComboBox7.Text & "'" & ""
                    Me.DataGridView3.DataMember = ""
                    DataGridView3.DataSource = vd
                End If
                Call Class4.CONNIC()
            End If
        End If
    End Sub

    Private Sub ComboBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox6.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox6.Text = "" Then
                ComboBox6.Focus()
            Else
                TextBox9.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sG As String = "select * from KESEM where KESEM=@KESEM "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@KESEM", ComboBox6.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                Label1.Text = CInt(rdG!IDK)
            End If
        End Using
        Call Class4.CONNIC()

    End Sub

    Private Sub ComboBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox7.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox7.Text = "" Then
                ComboBox7.Focus()
            Else
                ComboBox6.Focus()
            End If
        End If

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim sG As String = "select * from TYPEEYWAA where EYWAATYPE=@EYWAATYPE "
        Using cmG As New SqlClient.SqlCommand(sG, cn)
            cmG.Parameters.AddWithValue("@EYWAATYPE", ComboBox7.Text)
            Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
            If rdG.Read = True Then
                Label9.Text = CInt(rdG!IDEY)
                Label1.Text = CInt(rdG!IDk)
                TextBox9.Text = CDbl(rdG!se3reywaa)
                Dim sG1 As String = "select * from kesem where idk=@idk "
                Using cmG1 As New SqlClient.SqlCommand(sG1, cn)
                    cmG1.Parameters.AddWithValue("@idk", CInt(Label1.Text))
                    Dim rdG1 As SqlClient.SqlDataReader = cmG1.ExecuteReader
                    If rdG1.Read = True Then
                        ComboBox6.Text = Trim(rdG1!kesem)
                    End If
                End Using
            End If
        End Using
        Me.DataGridView3.DataSource = ""
        Dim s1 As String = "select * from TYPEEYWAA "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "TYPEEYWAA")
        Dim vd As New DataView(dss.Tables("TYPEEYWAA"))
        vd.RowFilter = "EYWAATYPE=" & "'" & Me.ComboBox7.Text & "'" & ""
        Me.DataGridView3.DataMember = ""
        DataGridView3.DataSource = vd
        Call Class4.CONNIC()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Panel2.Enabled = False
            Panel3.Enabled = False
            Panel5.Enabled = True
            Panel8.Enabled = False
            ComboBox3.Text = ""
            ComboBox1.Text = ""
            ComboBox3.SelectedIndex = -1
            ComboBox1.SelectedIndex = -1
            DataGridView2.DataSource = ""
            ComboBox7.Focus()
        Else
            'Panel3.Enabled = False
            'Panel2.Enabled = True
        End If

    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox9.Text = "" Then
                TextBox9.Text = CDbl(0)
            End If
            Button2.Focus()
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If CheckBox1.Checked = True Then
                Dim startwhenwindowsstarts As Microsoft.Win32.RegistryKey
                startwhenwindowsstarts = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                startwhenwindowsstarts.SetValue("MCS", Application.ExecutablePath)
                startwhenwindowsstarts.Close()
            Else
                Dim removefromstartup As Microsoft.Win32.RegistryKey
                removefromstartup = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                removefromstartup.DeleteValue("MCS")
                removefromstartup.Close()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox5_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ComboBox5.Validating
        

    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox5.Enter, TextBox2.Enter
        Try
            Dim txtbx As TextBox = CType(sender, TextBox)
            If Double.Parse(txtbx.Text) = 0 Then
                txtbx.Text = String.Empty
           
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox5.Leave, TextBox2.Leave
        Try
            Dim txtbx As TextBox = CType(sender, TextBox)
            If String.IsNullOrWhiteSpace(txtbx.Text) Or txtbx.Text = "." Then
                txtbx.Text = 0
            Else
                If txtbx.Text = CInt(txtbx.Text) & "." Then
                    txtbx.Text = CInt(txtbx.Text)
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged

    End Sub

    Private Sub TextBox9_Enter(sender As Object, e As EventArgs) Handles TextBox9.Enter
        If Double.Parse(TextBox9.Text) = 0 Then
            TextBox9.Text = String.Empty
        End If
    End Sub

    Private Sub TextBox9_Leave(sender As Object, e As EventArgs) Handles TextBox9.Leave
        If String.IsNullOrWhiteSpace(TextBox9.Text) Or TextBox9.Text = "." Then
            TextBox9.Text = 0
        End If
    End Sub

    Private Sub ComboBox5_Validated(sender As Object, e As EventArgs) Handles ComboBox5.Validated
        Call TXTEMLA.TXTEMLA(ComboBox5.Text)
        Me.ComboBox5.Text = RTXT
    End Sub

    Private Sub حذفالقسمToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفالقسمToolStripMenuItem.Click
        Call Class1.CONNIC()
        'Dim sd11 As String = "delete from dn where idK=@IDK"
        'Dim cd11 As New SqlClient.SqlCommand(sd11, cn)
        'cd11.Parameters.AddWithValue("@IDK", CInt(Label1.Text))
        Dim sd As String = "delete from EJRAA where idK=@IDK"
        Dim cd As New SqlClient.SqlCommand(sd, cn)
        cd.Parameters.AddWithValue("@IDK", CInt(Label1.Text))
        Dim sd1 As String = "delete from KESEM where idK=@IDK"
        Dim cd1 As New SqlClient.SqlCommand(sd1, cn)
        cd1.Parameters.AddWithValue("@IDK", CInt(Label1.Text))
        If MsgBox("هل تريد حذف القسم والاجراءات التابعة له", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'Try
            Call Class1.CONNIC()
            'cd11.ExecuteNonQuery()
            cd.ExecuteNonQuery()
            Try
                cd1.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("لا يمكن حذف القسم")
            End Try
            MsgBox("تم الحذف")
            Call Class1.CONNIC()
            Dim Str1 As String = "SELECT MAX(IDJ) FROM EJRAA "
            Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
            If IsDBNull(cmd1.ExecuteScalar) = True Then
                fnumberx = -1
            Else
                fnumberx = cmd1.ExecuteScalar
            End If
            Dim Str2 As String = "SELECT MAX(IDK) FROM KESEM "
            Dim cmd2 As New SqlClient.SqlCommand(Str2, cn)
            If IsDBNull(cmd2.ExecuteScalar) = True Then
                NOFATORAX = -1
            Else
                NOFATORAX = cmd2.ExecuteScalar
            End If
            Dim cmMM As New SqlClient.SqlCommand("DBCC CHECKIDENT('EJRAA', RESEED," & fnumberx & ")", cn)
            Dim cmMY As New SqlClient.SqlCommand("DBCC CHECKIDENT('KESEM', RESEED," & NOFATORAX & ")", cn)
            cmMM.ExecuteNonQuery()
            cmMY.ExecuteNonQuery()
            'Call Class1.CONNIC()
            'Dim ss As String = "select * from EJRAAK_V "
            'Dim aad As New SqlClient.SqlDataAdapter(ss, cn)
            'Dim dss As New DataSet
            'dss.Clear()
            'aad.Fill(dss, "EJRAAK_V")
            'Dim vdd As New DataView(dss.Tables("EJRAAK_V"))
            'vdd.RowFilter = " KESEM =" & "'" & Trim(ComboBox3.Text) & "'" & ""
            'DataGridView1.DataMember = ""
            'DataGridView1.DataSource = vdd
            dgv1()
            Dim sk2 As String
            sk2 = "select * from KESEM"
            Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
            Dim dsk2 As New DataSet
            adk2.Fill(dsk2, "KESEM")
            ComboBox3.DataSource = dsk2.Tables(0)
            ComboBox3.DisplayMember = "KESEM"
            ComboBox3.SelectedIndex = -1
            'Catch ex As Exception
            '    MsgBox("لم يتم الحذف")
            'End Try
        End If
        Call Class4.CONNIC()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If String.IsNullOrWhiteSpace(ComboBox9.Text) Then
            ComboBox9.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(ComboBox8.Text) Then
            ComboBox8.Text = "لايوجد"
        End If
        If Label11.Text <> 0 Then

            'Dim s As String = "select * from Mostafeed where NAMEM=@NAMEM and jeham=@jeham "
            'Dim cm As New SqlClient.SqlCommand(s, cn)
            'cm.Parameters.AddWithValue("@NAMEM", Trim(ComboBox9.Text))
            'cm.Parameters.AddWithValue("@jeham", Trim(ComboBox8.Text))
            'Dim rd As SqlClient.SqlDataReader
            'rd = cm.ExecuteReader
            'If rd.Read = True Then
            '    Label11.Text = CInt(rd!IDM)
            Dim ss2 As String = "UPDATE Mostafeed SET NameM=@NameM,JehaM=@JehaM,MNO=@MNO,CNO=@CNO WHERE IDM=@IDM"
            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
            cmm2.Parameters.AddWithValue("@NameM", Trim(ComboBox9.Text))
            cmm2.Parameters.AddWithValue("@JehaM", Trim(ComboBox8.Text))
            cmm2.Parameters.AddWithValue("@MNO", "لايوجد")
            cmm2.Parameters.AddWithValue("@CNO", ComboBox8.Text)
            cmm2.Parameters.AddWithValue("@IDM", CInt(Label11.Text))
            Try
                cmm2.ExecuteNonQuery()
                MsgBox("تم التعديل ")
                Me.DataGridView4.DataSource = ""
                ' Me.ComboBox2.Enabled = False
                'Call Class1.CONNIC()
                Dim s1 As String = "select * from Mostafeed "
                Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                Dim dss As New DataSet
                dss.Clear()
                aad.Fill(dss, "Mostafeed")
                Dim vd As New DataView(dss.Tables("Mostafeed"))
                vd.RowFilter = "namem=" & "'" & Me.ComboBox9.Text & "'" & ""
                Me.DataGridView4.DataMember = ""
                DataGridView4.DataSource = vd
                namemx = Trim(ComboBox9.Text)
                jehamx = Trim(ComboBox8.Text)
                Me.ComboBox9.Text = ""
                Me.ComboBox8.Text = ""
                'Me.TextBox1.Text = ""
                Dim skk As String
                skk = "select * from NAMEM"
                Dim adkk As New SqlClient.SqlDataAdapter(skk, cn)
                Dim dskk As New DataSet
                adkk.Fill(dskk, "NAMEM")
                ComboBox9.DataSource = dskk.Tables(0)
                ComboBox9.DisplayMember = "NAMEM"
                ComboBox9.SelectedIndex = -1
                Dim skkj As String
                skkj = "select * from JEHAM"
                Dim adkkj As New SqlClient.SqlDataAdapter(skkj, cn)
                Dim dskkj As New DataSet
                adkkj.Fill(dskkj, "JEHAM")
                ComboBox8.DataSource = dskkj.Tables(0)
                ComboBox8.DisplayMember = "JEHAM"
                ComboBox8.SelectedIndex = -1
            Catch ex As Exception
            End Try
            Label11.Text = 0
        Else
            Dim ss2 As String = "insert into Mostafeed(NameM,JehaM,MNO,CNO)VALUES(@NameM,@JehaM,@MNO,@CNO)"
            '    Dim ss2 As String = "insert into appointment(fnumber,CHNO,DATEA,FROMA,TOA,doctorname)VALUES(XXXX1,XXXX2,XXXX3,XXXX4,XXXX5,xxxx6)"
            Dim cmm2 As New SqlClient.SqlCommand(ss2, cn)
            cmm2.Parameters.AddWithValue("@NameM", ComboBox9.Text)
            cmm2.Parameters.AddWithValue("@JehaM", ComboBox8.Text)
            cmm2.Parameters.AddWithValue("@MNO", "لايوجد")
            cmm2.Parameters.AddWithValue("@CNO", ComboBox8.Text)
            Try
                cmm2.ExecuteNonQuery()
                MsgBox("تم الحفظ ")
                'Me.MaskedTextBox1.Text = ""
                'Me.MaskedTextBox2.Text = ""
                'Me.MaskedTextBox3.Text = ""
                Me.DataGridView4.DataSource = ""
                ' Me.ComboBox2.Enabled = False
                Dim s1 As String = "select * from Mostafeed "
                Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
                Dim dss As New DataSet
                dss.Clear()
                aad.Fill(dss, "Mostafeed")
                Dim vd As New DataView(dss.Tables("Mostafeed"))
                vd.RowFilter = "JehaM=" & "'" & Me.ComboBox8.Text & "'" & ""
                Me.DataGridView4.DataMember = ""
                DataGridView4.DataSource = vd
                namemx = Trim(ComboBox9.Text)
                jehamx = Trim(ComboBox8.Text)
                Me.ComboBox9.Text = ""
                Me.ComboBox8.Text = ""
                'Me.TextBox1.Text = ""
                Dim skk As String
                skk = "select * from NAMEM"
                Dim adkk As New SqlClient.SqlDataAdapter(skk, cn)
                Dim dskk As New DataSet
                adkk.Fill(dskk, "NAMEM")
                ComboBox9.DataSource = dskk.Tables(0)
                ComboBox9.DisplayMember = "NAMEM"
                ComboBox9.SelectedIndex = -1
                Dim skkj As String
                skkj = "select * from JEHAM"
                Dim adkkj As New SqlClient.SqlDataAdapter(skkj, cn)
                Dim dskkj As New DataSet
                adkkj.Fill(dskkj, "JEHAM")
                ComboBox8.DataSource = dskkj.Tables(0)
                ComboBox8.DisplayMember = "JEHAM"
                ComboBox8.SelectedIndex = -1

            Catch ex As Exception
                MsgBox(" لايمكن الحفظ ")
            End Try
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Panel2.Enabled = False
            Panel3.Enabled = False
            Panel5.Enabled = False
            Panel8.Enabled = True
            ComboBox9.Text = ""
            ComboBox8.Text = ""
            ComboBox9.SelectedIndex = -1
            ComboBox8.SelectedIndex = -1
            DataGridView4.DataSource = ""
            ComboBox9.Focus()
        Else
            'Panel3.Enabled = False
            'Panel2.Enabled = True
        End If
    End Sub

    Private Sub ComboBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox9.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If String.IsNullOrWhiteSpace(ComboBox9.Text) Then
                ComboBox9.Focus()
                Return
            End If
            ComboBox8.Focus()
        End If
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        Call Class1.CONNIC()
        Dim s1 As String = "select * from Mostafeed "
        Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        Dim dss As New DataSet
        dss.Clear()
        aad.Fill(dss, "Mostafeed")
        Dim vd As New DataView(dss.Tables("Mostafeed"))
        vd.RowFilter = "namem=" & "'" & Me.ComboBox9.Text & "'" & ""
        Me.DataGridView4.DataMember = ""
        DataGridView4.DataSource = vd
    End Sub

    Private Sub ComboBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox8.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Button4.Focus()
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged

    End Sub

    Private Sub ComboBox8_Validated(sender As Object, e As EventArgs) Handles ComboBox8.Validated
        If String.IsNullOrWhiteSpace(ComboBox8.Text) Then
            ComboBox8.Text = "لايوجد"
            Return
        End If
    End Sub

    Private Sub ComboBox8_Enter(sender As Object, e As EventArgs) Handles ComboBox8.Enter
        If Trim(ComboBox8.Text) = Trim("لايوجد") Then
            ComboBox8.Text = String.Empty
        End If
    End Sub

    Private Sub ComboBox9_TextChanged(sender As Object, e As EventArgs) Handles ComboBox9.TextChanged
        
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Private Sub DataGridView4_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView4.CellMouseDown
        Me.Label11.Text = DataGridView4.Item(0, e.RowIndex).Value
        ComboBox9.Text = DataGridView4.Item(1, e.RowIndex).Value
        ComboBox8.Text = DataGridView4.Item(2, e.RowIndex).Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '****************************
        Dim ss2FS As String = "UPDATE KESEM SET kesem=@kesem WHERE IDK=@IDK"
        Dim cmm2FS As New SqlClient.SqlCommand(ss2FS, cn)
        'cmm2F.Parameters.AddWithValue("@idk", Label1.Text)
        cmm2FS.Parameters.AddWithValue("@kesem", ComboBox3.Text)
        cmm2FS.Parameters.AddWithValue("@IDK", CInt(Label1.Text))
        Try
            cmm2FS.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Dim ss2FS1 As String = "UPDATE EJRAA SET EJRAA=@EJRAA WHERE IDK=@IDK AND IDJ=@IDJ"
        Dim cmm2FS1 As New SqlClient.SqlCommand(ss2FS1, cn)
        'cmm2F.Parameters.AddWithValue("@idk", Label1.Text)
        cmm2FS1.Parameters.AddWithValue("@EJRAA", ComboBox1.Text)
        cmm2FS1.Parameters.AddWithValue("@IDK", CInt(Label1.Text))
        cmm2FS1.Parameters.AddWithValue("@IDJ", CInt(Label7.Text))
        Try
            cmm2FS1.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        'Me.DataGridView1.DataSource = ""
        'Dim s1 As String = "select * from Ejraa "
        'Dim aad As New SqlClient.SqlDataAdapter(s1, cn)
        'Dim dss As New DataSet
        'dss.Clear()
        'aad.Fill(dss, "Ejraa")
        'Dim vd As New DataView(dss.Tables("Ejraa"))
        'vd.RowFilter = "Ejraa=" & "'" & Me.ComboBox1.Text & "'" & ""
        'Me.DataGridView1.DataMember = ""
        'DataGridView1.DataSource = vd
        dgv1()
        Dim sk1 As String

        sk1 = "select * from Ejraa"
        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
        Dim dsk1 As New DataSet
        adk1.Fill(dsk1, "Ejraa")
        ComboBox2.DataSource = dsk1.Tables(0)
        ComboBox2.DisplayMember = "Ejraa"
        ComboBox2.SelectedIndex = -1

        Dim skd2 As String
        skd2 = "select * from dn"
        Dim adkd As New SqlClient.SqlDataAdapter(skd2, cn)
        Dim dskd As New DataSet
        adkd.Fill(dskd, "dn")
        ComboBox5.DataSource = dskd.Tables(0)
        ComboBox5.DisplayMember = "dn"
        ComboBox5.SelectedIndex = -1

        Dim skk As String
        skk = "select * from kesem"
        Dim adkk As New SqlClient.SqlDataAdapter(skk, cn)
        Dim dskk As New DataSet
        adkk.Fill(dskk, "kesem")
        ComboBox4.DataSource = dskk.Tables(0)
        ComboBox4.DisplayMember = "kesem"
        ComboBox4.SelectedIndex = -1

        Dim skkK As String
        skkK = "select * from kesem"
        Dim adkkK As New SqlClient.SqlDataAdapter(skkK, cn)
        Dim dskkK As New DataSet
        adkkK.Fill(dskkK, "kesem")
        ComboBox6.DataSource = dskkK.Tables(0)
        ComboBox6.DisplayMember = "kesem"
        ComboBox6.SelectedIndex = -1

        Dim sk2 As String
        sk2 = "select * from KESEM"
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "KESEM")
        ComboBox3.DataSource = dsk2.Tables(0)
        ComboBox3.DisplayMember = "KESEM"
        ComboBox3.SelectedIndex = -1

        Me.ComboBox3.Text = ""
        Me.TextBox3.Text = ""
        Label7.Text = 0
        Label1.Text = 0

        '*************************

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
    End Sub

    Private Sub CheckBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles CheckBox3.MouseUp
        If CheckBox3.Checked = True Then
            Dim sI As String = "UPDATE users SET KHAZENA=@KHAZENA WHERE KHAZENA=" & 0
            Dim cmI As New SqlClient.SqlCommand(sI, cn)
            cmI.Parameters.AddWithValue("@KHAZENA", True)
            Try
                cmI.ExecuteNonQuery()
                KHAZENAXX = True
                MsgBox("تم اضافة ايصال الخزينة في الاستقبال")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Dim sI As String = "UPDATE users SET KHAZENA=@KHAZENA WHERE KHAZENA=" & 1
            Dim cmI As New SqlClient.SqlCommand(sI, cn)
            cmI.Parameters.AddWithValue("@KHAZENA", False)
            Try
                cmI.ExecuteNonQuery()
                KHAZENAXX = False
                MsgBox("تم الغاء ايصال الخزينة في الاستقبال")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub CheckBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CheckBox3.KeyPress
    End Sub

    Private Sub CheckBox3_KeyUp(sender As Object, e As KeyEventArgs) Handles CheckBox3.KeyUp
        'If Asc(e.KeyChar) = Keys.Space Then
        If CheckBox3.Checked = True Then
            Dim sI As String = "UPDATE users SET KHAZENA=@KHAZENA WHERE KHAZENA=" & 0
            Dim cmI As New SqlClient.SqlCommand(sI, cn)
            cmI.Parameters.AddWithValue("@KHAZENA", True)
            Try
                cmI.ExecuteNonQuery()
                KHAZENAXX = True
                MsgBox("تم اضافة ايصال الخزينة في الاستقبال")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Dim sI As String = "UPDATE users SET KHAZENA=@KHAZENA WHERE KHAZENA=" & 1
            Dim cmI As New SqlClient.SqlCommand(sI, cn)
            cmI.Parameters.AddWithValue("@KHAZENA", False)
            Try
                cmI.ExecuteNonQuery()
                KHAZENAXX = False
                MsgBox("تم الغاء ايصال الخزينة في الاستقبال")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        'End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim fa As New SittingPrinters
        fa.ShowDialog()
    End Sub
End Class