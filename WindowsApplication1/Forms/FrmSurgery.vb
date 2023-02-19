Public Class FrmSurgery

    Private Sub AMALEATvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbsbhDataSet8.AMALEAT' table. You can move, or remove it, as needed.
        ' Me.AMALEATTableAdapter.Fill(Me.DbsbhDataSet8.AMALEAT)
        Dim sk1 As String
        sk1 = "select * from AMALEAT"
        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
        Dim dsk1 As New DataSet
        adk1.Fill(dsk1, "AMALEAT")
        ComboBox9.DataSource = dsk1.Tables(0)
        ComboBox9.DisplayMember = "AML_NAME"
        ComboBox9.SelectedIndex = -1
        Dim sk2 As String
        sk2 = "select * from dn " ' WHERE IDD<>'" & 0 & "' " & "and IDD<>'" & 1 & "' "
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        ComboBox2.SelectedIndex = -1
        Dim sk22 As String
        sk22 = "select * from dn WHERE IDK=" & 5
        Dim adk22 As New SqlClient.SqlDataAdapter(sk22, cn)
        Dim dsk22 As New DataSet
        adk22.Fill(dsk22, "dn")
        ComboBox7.DataSource = dsk22.Tables(0)
        ComboBox7.DisplayMember = "dn"
        ComboBox7.SelectedIndex = -1
        Dim skF As String
        skF = "select * from AM_FDOC"
        Dim adkF As New SqlClient.SqlDataAdapter(skF, cn)
        Dim dskF As New DataSet
        adkF.Fill(dskF, "AM_FDOC")
        ComboBox5.DataSource = dskF.Tables(0)
        ComboBox5.DisplayMember = "FDOCN"
        ComboBox5.SelectedIndex = -1
        Dim skM As String
        skM = "select * from AM_MDOC"
        Dim adkM As New SqlClient.SqlDataAdapter(skM, cn)
        Dim dskM As New DataSet
        adkM.Fill(dskM, "AM_MDOC")
        ComboBox1.DataSource = dskM.Tables(0)
        ComboBox1.DisplayMember = "MDOCN"
        ComboBox1.SelectedIndex = -1
        Dim skT As String
        skT = "select * from AM_TDOC"
        Dim adkT As New SqlClient.SqlDataAdapter(skT, cn)
        Dim dskT As New DataSet
        adkT.Fill(dskT, "AM_TDOC")
        ComboBox6.DataSource = dskT.Tables(0)
        ComboBox6.DisplayMember = "TDOCN"
        ComboBox6.SelectedIndex = -1
        Dim skK As String
        skK = "select * from AM_KAB"
        Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
        Dim dskK As New DataSet
        adkK.Fill(dskK, "AM_KAB")
        ComboBox8.DataSource = dskK.Tables(0)
        ComboBox8.DisplayMember = "KABN"
        ComboBox8.SelectedIndex = -1
        Dim skFT As String
        skFT = "select * from AM_FTDOC"
        Dim adkFT As New SqlClient.SqlDataAdapter(skFT, cn)
        Dim dskFT As New DataSet
        adkFT.Fill(dskFT, "AM_FTDOC")
        ComboBox3.DataSource = dskFT.Tables(0)
        ComboBox3.DisplayMember = "FTDOCN"
        ComboBox3.SelectedIndex = -1

        ComboBox2.Text = ""
        TextBox1.Text = 0
        ComboBox6.Text = ""
        TextBox8.Text = 0
        ComboBox1.Text = ""
        TextBox2.Text = 0
        ComboBox5.Text = ""
        TextBox7.Text = 0
        ComboBox3.Text = ""
        TextBox3.Text = 0
        ComboBox4.Text = ""
        TextBox6.Text = 0
        ComboBox8.Text = ""
        TextBox5.Text = 0
        ComboBox7.Text = ""
        TextBox4.Text = 0
        ComboBox9.Text = ""
        TextBox9.Text = 0
        TextBox10.Text = 0
        TextBox11.Text = 0
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If Trim(ComboBox5.Text) = "" Or ComboBox5.SelectedIndex = -1 Then
            ComboBox5.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox5.Text = "لايوجد"
            TextBox7.Text = 0
        End If
        'If Trim(ComboBox2.Text) = "" Or ComboBox2.SelectedIndex = -1 Then
        '    ComboBox2.DropDownStyle = ComboBoxStyle.DropDown
        '    ComboBox2.Text = "لايوجد"
        '    TextBox1.Text = 0
        'End If
        If Trim(ComboBox1.Text) = "" Or ComboBox1.SelectedIndex = -1 Then
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox1.Text = "لايوجد"
            TextBox2.Text = 0
        End If
        If Trim(ComboBox6.Text) = "" Or ComboBox6.SelectedIndex = -1 Then
            ComboBox6.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox6.Text = "لايوجد"
            TextBox8.Text = 0
        End If
        If Trim(ComboBox3.Text) = "" Or ComboBox3.SelectedIndex = -1 Then
            ComboBox3.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox3.Text = "لايوجد"
            TextBox3.Text = 0
        End If
        If Trim(ComboBox7.Text) = "" Or ComboBox7.SelectedIndex = -1 Then
            ComboBox7.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox7.Text = "لايوجد"
            TextBox4.Text = 0
        End If
        If Trim(ComboBox8.Text) = "" Or ComboBox8.SelectedIndex = -1 Then
            ComboBox8.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox8.Text = "لايوجد"
            TextBox5.Text = 0
        End If
        If Trim(TextBox6.Text) = "" Then
            TextBox6.Text = 0
        End If

        TextBox10.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
        TextBox11.Text = Val(TextBox9.Text) - Val(TextBox10.Text)
        Dim s As String = "select * from amaleat where aml_name=@xxx1 "
        Using cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@xxx1", ComboBox9.Text)
            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            If rd.Read = True Then
                If MsgBox("نوع العملية مسجل مسبقا ... هل تود التعديل في البيانات", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim ss As String = "update Amaleat set docn=@docn,dock=@dock,tdocn=@tdocn,tdock=@tdock,mdocn=@mdocn,mdock=@mdock,fdocn=@fdocn,fdock=@fdock,ftdocn=@ftdocn,ftdock=@ftdock,tahn=@tahn,tahk=@tahk,kabn=@kabn,kabk=@kabk,cdocn=@cdocn,cdock=@cdock,aml_name=@aml_name,aml_kema=@aml_kema,C_KEMA=@C_KEMA where aml_name=@aml_namex"
                    Using cmm As New SqlClient.SqlCommand(ss, cn)
                        cmm.Parameters.AddWithValue("@docn", CInt(Label4.Text))
                        cmm.Parameters.AddWithValue("@dock", CDbl(TextBox1.Text))
                        cmm.Parameters.AddWithValue("@tdocn", ComboBox6.Text)
                        cmm.Parameters.AddWithValue("@tdock", CDbl(TextBox8.Text))
                        cmm.Parameters.AddWithValue("@mdocn", ComboBox1.Text)
                        cmm.Parameters.AddWithValue("@mdock", CDbl(TextBox2.Text))
                        cmm.Parameters.AddWithValue("@fdocn", ComboBox5.Text)
                        cmm.Parameters.AddWithValue("@fdock", CDbl(TextBox7.Text))
                        cmm.Parameters.AddWithValue("@ftdocn", ComboBox3.Text)
                        cmm.Parameters.AddWithValue("@ftdock", CDbl(TextBox3.Text))
                        cmm.Parameters.AddWithValue("@tahn", ComboBox4.Text)
                        cmm.Parameters.AddWithValue("@tahk", CDbl(TextBox6.Text))
                        cmm.Parameters.AddWithValue("@kabn", ComboBox8.Text)
                        cmm.Parameters.AddWithValue("@kabk", CDbl(TextBox5.Text))
                        cmm.Parameters.AddWithValue("@cdocn", ComboBox7.Text)
                        cmm.Parameters.AddWithValue("@cdock", CDbl(TextBox4.Text))
                        cmm.Parameters.AddWithValue("@aml_name", ComboBox9.Text)
                        cmm.Parameters.AddWithValue("@aml_kema", CDbl(TextBox9.Text))
                        cmm.Parameters.AddWithValue("@aml_namex", ComboBox9.Text)
                        cmm.Parameters.AddWithValue("@C_KEMA", TextBox11.Text)

                        Try
                            cmm.ExecuteNonQuery()
                            MsgBox("تم التعديل")
                            Dim Str As String = "SELECT MAX(IDA) FROM Amaleat "
                            Using cmd As New SqlClient.SqlCommand(Str, cn)
                                M6 = cmd.ExecuteScalar
                            End Using

                            Dim sl As String = "select * from dn where dn=@dn"
                            Using cml As New SqlClient.SqlCommand(sl, cn)
                                cml.Parameters.AddWithValue("@dn", ComboBox2.Text)
                                Dim rdl As SqlClient.SqlDataReader
                                rdl = cml.ExecuteReader
                                If rdl.Read = True Then
                                    Label2.Text = rdl!idd
                                    rdl.Close()
                                End If
                            End Using

                            Dim sA As String = "select * from Ejraa where Ejraa=@Ejraa"
                            Using cmA As New SqlClient.SqlCommand(sA, cn)
                                cmA.Parameters.AddWithValue("@Ejraa", ComboBox3.Text)
                                Dim rdA As SqlClient.SqlDataReader
                                rdA = cm.ExecuteReader
                                If rdA.Read = True Then
                                    Label1.Text = rdA!idj
                                    rdA.Close()
                                End If
                            End Using

                            Dim ss23 As String = "UPDATE dnkema SET idd=@idd,Ejraa=@Ejraa,Kema=@Kema,kemaej=@kemaej WHERE IDA=@IDA"
                            Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
                            cmm23.Parameters.AddWithValue("@idd", Label2.Text)
                            cmm23.Parameters.AddWithValue("@Ejraa", Label1.Text)
                            cmm23.Parameters.AddWithValue("@Kema", TextBox1.Text)
                            cmm23.Parameters.AddWithValue("@kemaej", TextBox9.Text)
                            cmm23.Parameters.AddWithValue("@IDA", M6)
                            cmm23.ExecuteNonQuery()

                            Dim s16 As String = "select * from Amaleat "
                            Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
                            Dim dss As New DataSet
                            dss.Clear()
                            aad.Fill(dss, "Amaleat")
                            Dim vd As New DataView(dss.Tables("Amaleat"))
                            vd.RowFilter = "aml_name=" & "'" & Me.ComboBox9.Text & "'" & ""
                            Me.DataGridView1.DataMember = ""
                            DataGridView1.DataSource = vd
                        Catch ex As Exception
                            MsgBox("لم يتم الحفظ... راجع مدخلاتك")
                        End Try
                    End Using
                End If
            Else
                Dim ss As String = "insert into Amaleat(docn,dock,tdocn,tdock,mdocn,mdock,fdocn,fdock,ftdocn,ftdock,tahn,tahk,kabn,kabk,cdocn,cdock,aml_name,aml_kema,C_KEMA)values(@docn,@dock,@tdocn,@tdock,@mdocn,@mdock,@fdocn,@fdock,@ftdocn,@ftdock,@tahn,@tahk,@kabn,@kabk,@cdocn,@cdock,@aml_name,@aml_kema,@C_KEMA)"
                Using cmm As New SqlClient.SqlCommand(ss, cn)
                    cmm.Parameters.AddWithValue("@docn", CInt(Label4.Text))
                    cmm.Parameters.AddWithValue("@dock", CDbl(TextBox1.Text))
                    cmm.Parameters.AddWithValue("@tdocn", ComboBox6.Text)
                    cmm.Parameters.AddWithValue("@tdock", CDbl(TextBox8.Text))
                    cmm.Parameters.AddWithValue("@mdocn", ComboBox1.Text)
                    cmm.Parameters.AddWithValue("@mdock", CDbl(TextBox2.Text))
                    cmm.Parameters.AddWithValue("@fdocn", ComboBox5.Text)
                    cmm.Parameters.AddWithValue("@fdock", CDbl(TextBox7.Text))
                    cmm.Parameters.AddWithValue("@ftdocn", ComboBox3.Text)
                    cmm.Parameters.AddWithValue("@ftdock", CDbl(TextBox3.Text))
                    cmm.Parameters.AddWithValue("@tahn", ComboBox4.Text)
                    cmm.Parameters.AddWithValue("@tahk", CDbl(TextBox6.Text))
                    cmm.Parameters.AddWithValue("@kabn", ComboBox8.Text)
                    cmm.Parameters.AddWithValue("@kabk", CDbl(TextBox5.Text))
                    cmm.Parameters.AddWithValue("@cdocn", ComboBox7.Text)
                    cmm.Parameters.AddWithValue("@cdock", CDbl(TextBox4.Text))
                    cmm.Parameters.AddWithValue("@aml_name", ComboBox9.Text)
                    cmm.Parameters.AddWithValue("@C_KEMA", TextBox11.Text)
                    'TextBox9.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
                    cmm.Parameters.AddWithValue("@aml_kema", CDbl(TextBox9.Text))
                    'Try
                    cmm.ExecuteNonQuery()
                    MsgBox("تم الحفظ")
                    Dim Str As String = "SELECT MAX(IDA) FROM Amaleat "
                    Using cmd As New SqlClient.SqlCommand(Str, cn)
                        M6 = cmd.ExecuteScalar
                    End Using
                    Dim sl As String = "select * from dn where dn=@dn"
                    Using cml As New SqlClient.SqlCommand(sl, cn)
                        cml.Parameters.AddWithValue("@dn", ComboBox2.Text)
                        Using rdl As SqlClient.SqlDataReader = cml.ExecuteReader
                            If rdl.Read = True Then
                                Label2.Text = rdl!idd
                                rdl.Close()
                            End If
                        End Using
                    End Using

                    Dim sA As String = "select * from Ejraa where Ejraa=@Ejraa"
                    Using cmA As New SqlClient.SqlCommand(sA, cn)
                        cmA.Parameters.AddWithValue("@Ejraa", "عمليات")
                        Using rdA As SqlClient.SqlDataReader = cmA.ExecuteReader
                            If rdA.Read = True Then
                                Label1.Text = rdA!idj
                                rdA.Close()
                            End If
                        End Using
                    End Using
                    If Val(Label2.Text) <> 0 Then
                        Dim ss23 As String = "insert into dnkema(idd,Ejraa,IDA,Kema,kemaej) VALUES(@idd,@Ejraa,@IDA,@Kema,@kemaej)"
                        Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
                        cmm23.Parameters.AddWithValue("@idd", CInt(Label2.Text))
                        cmm23.Parameters.AddWithValue("@Ejraa", CInt(Label1.Text))
                        cmm23.Parameters.AddWithValue("@IDA", CInt(M6))
                        cmm23.Parameters.AddWithValue("@Kema", CDbl(TextBox1.Text))
                        cmm23.Parameters.AddWithValue("@kemaej", CDbl(TextBox9.Text))
                        cmm23.ExecuteNonQuery()

                    End If

                    Dim s16 As String = "select * from Amaleat "
                    Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
                    Dim dss As New DataSet
                    dss.Clear()
                    aad.Fill(dss, "Amaleat")
                    Dim vd As New DataView(dss.Tables("Amaleat"))
                    vd.RowFilter = "aml_name=" & "'" & Me.ComboBox9.Text & "'" & ""
                    Me.DataGridView1.DataMember = ""
                    DataGridView1.DataSource = vd
                    'Catch ex As Exception
                    '    MsgBox("لم يتم الحفظى... راجع مدخلاتك")
                    'End Try
                End Using
            End If
            'end using
        End Using
        'Dim sM As String = "select * from amaleat_M where aml_name=@xxx1 "
        'Using cmD As New SqlClient.SqlCommand(sM, cn)
        '    cmD.Parameters.AddWithValue("@xxx1", ComboBox9.Text)
        '    Dim rdM As SqlClient.SqlDataReader = cmD.ExecuteReader
        '    If rdM.Read = True Then
        '        Dim ssM As String = "update Amaleat_M set docn=@docn,dock=@dock,tdocn=@tdocn,tdock=@tdock,mdocn=@mdocn,mdock=@mdock,fdocn=@fdocn,fdock=@fdock,ftdocn=@ftdocn,ftdock=@ftdock,tahn=@tahn,tahk=@tahk,kabn=@kabn,kabk=@kabk,cdocn=@cdocn,cdock=@cdock,aml_name=@aml_name,aml_kema=@aml_kema,C_KEMA=@C_KEMA where aml_name=@aml_namex"
        '        Using cmmM As New SqlClient.SqlCommand(ssM, cn)
        '            cmmM.Parameters.AddWithValue("@docn", CInt(Label4.Text))
        '            cmmM.Parameters.AddWithValue("@dock", CDbl(TextBox1.Text))
        '            cmmM.Parameters.AddWithValue("@tdocn", ComboBox6.Text)
        '            cmmM.Parameters.AddWithValue("@tdock", CDbl(TextBox8.Text))
        '            cmmM.Parameters.AddWithValue("@mdocn", ComboBox1.Text)
        '            cmmM.Parameters.AddWithValue("@mdock", CDbl(TextBox2.Text))
        '            cmmM.Parameters.AddWithValue("@fdocn", ComboBox5.Text)
        '            cmmM.Parameters.AddWithValue("@fdock", CDbl(TextBox7.Text))
        '            cmmM.Parameters.AddWithValue("@ftdocn", ComboBox3.Text)
        '            cmmM.Parameters.AddWithValue("@ftdock", CDbl(TextBox3.Text))
        '            cmmM.Parameters.AddWithValue("@tahn", ComboBox4.Text)
        '            cmmM.Parameters.AddWithValue("@tahk", CDbl(TextBox6.Text))
        '            cmmM.Parameters.AddWithValue("@kabn", ComboBox8.Text)
        '            cmmM.Parameters.AddWithValue("@kabk", CDbl(TextBox5.Text))
        '            cmmM.Parameters.AddWithValue("@cdocn", ComboBox7.Text)
        '            cmmM.Parameters.AddWithValue("@cdock", CDbl(TextBox4.Text))
        '            cmmM.Parameters.AddWithValue("@aml_name", ComboBox9.Text)
        '            cmmM.Parameters.AddWithValue("@aml_kema", CDbl(TextBox9.Text))
        '            cmmM.Parameters.AddWithValue("@aml_namex", ComboBox9.Text)
        '            cmmM.Parameters.AddWithValue("@C_KEMA", TextBox11.Text)
        '            Try
        '                cmmM.ExecuteNonQuery()
        '            Catch ex As Exception

        '            End Try
        '        End Using
        '    Else
        '        Dim ssD As String = "insert into Amaleat_M(IDA,docn,dock,tdocn,tdock,mdocn,mdock,fdocn,fdock,ftdocn,ftdock,tahn,tahk,kabn,kabk,cdocn,cdock,aml_name,aml_kema,C_KEMA)values(@IDA,@docn,@dock,@tdocn,@tdock,@mdocn,@mdock,@fdocn,@fdock,@ftdocn,@ftdock,@tahn,@tahk,@kabn,@kabk,@cdocn,@cdock,@aml_name,@aml_kema,@C_KEMA)"
        '        Using cmmD As New SqlClient.SqlCommand(ssD, cn)
        '            cmmD.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
        '            cmmD.Parameters.AddWithValue("@docn", CInt(Label4.Text))
        '            cmmD.Parameters.AddWithValue("@dock", CDbl(TextBox1.Text))
        '            cmmD.Parameters.AddWithValue("@tdocn", ComboBox6.Text)
        '            cmmD.Parameters.AddWithValue("@tdock", CDbl(TextBox8.Text))
        '            cmmD.Parameters.AddWithValue("@mdocn", ComboBox1.Text)
        '            cmmD.Parameters.AddWithValue("@mdock", CDbl(TextBox2.Text))
        '            cmmD.Parameters.AddWithValue("@fdocn", ComboBox5.Text)
        '            cmmD.Parameters.AddWithValue("@fdock", CDbl(TextBox7.Text))
        '            cmmD.Parameters.AddWithValue("@ftdocn", ComboBox3.Text)
        '            cmmD.Parameters.AddWithValue("@ftdock", CDbl(TextBox3.Text))
        '            cmmD.Parameters.AddWithValue("@tahn", ComboBox4.Text)
        '            cmmD.Parameters.AddWithValue("@tahk", CDbl(TextBox6.Text))
        '            cmmD.Parameters.AddWithValue("@kabn", ComboBox8.Text)
        '            cmmD.Parameters.AddWithValue("@kabk", CDbl(TextBox5.Text))
        '            cmmD.Parameters.AddWithValue("@cdocn", ComboBox7.Text)
        '            cmmD.Parameters.AddWithValue("@cdock", CDbl(TextBox4.Text))
        '            cmmD.Parameters.AddWithValue("@aml_name", ComboBox9.Text)
        '            cmmD.Parameters.AddWithValue("@C_KEMA", TextBox11.Text)
        '            'TextBox9.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
        '            cmmD.Parameters.AddWithValue("@aml_kema", CDbl(TextBox9.Text))
        '            Try
        '                cmmD.ExecuteNonQuery()
        '            Catch ex As Exception

        '            End Try
        '        End Using

        '    End If
        'End Using

        Dim sk1 As String
        sk1 = "select * from AMALEAT"
        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
        Dim dsk1 As New DataSet
        adk1.Fill(dsk1, "AMALEAT")
        ComboBox9.DataSource = dsk1.Tables(0)
        ComboBox9.DisplayMember = "AML_NAME"
        ComboBox9.SelectedIndex = -1
        Dim sk2 As String
        sk2 = "select * from dn"
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        ComboBox2.SelectedIndex = -1
        ComboBox2.Text = ""
        TextBox1.Text = 0
        ComboBox6.Text = ""
        TextBox8.Text = 0
        ComboBox1.Text = ""
        TextBox2.Text = 0
        ComboBox5.Text = ""
        TextBox7.Text = 0
        ComboBox3.Text = ""
        TextBox3.Text = 0
        ComboBox4.Text = ""
        TextBox6.Text = 0
        ComboBox8.Text = ""
        TextBox5.Text = 0
        ComboBox7.Text = ""
        TextBox4.Text = 0
        ComboBox9.Text = ""
        TextBox9.Text = 0
        TextBox10.Text = 0
        TextBox11.Text = 0
        ComboBox9.DropDownStyle = ComboBoxStyle.DropDownList
        Button10.Visible = True
    End Sub

    Private Sub ComboBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox9.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox9.Text = "" Then
                MsgBox("يرجى اختيار نوع العملية")
                ComboBox9.Focus()
            Else
                Me.TextBox9.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        If ComboBox9.SelectedIndex <> -1 Then
            Dim s As String = "select * from amaleat where aml_name=@xxx1 "
            Using cm As New SqlClient.SqlCommand(s, cn)
                cm.Parameters.AddWithValue("@xxx1", ComboBox9.Text)
                Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
                If rd.Read = True Then
                    Label5.Text = CInt(rd!IDA)
                    Dim sdoc As String
                    sdoc = "select * from dn"
                    Dim addoc As New SqlClient.SqlDataAdapter(sdoc, cn)
                    Dim dsdoc As New DataSet
                    addoc.Fill(dsdoc, "dn")
                    ComboBox2.DataSource = dsdoc.Tables(0)
                    ComboBox2.DisplayMember = "dn"
                    ComboBox2.SelectedIndex = -1

                    Dim scdoc As String
                    scdoc = "select * from dn where idk='" & 5 & "' "
                    Dim adcdoc As New SqlClient.SqlDataAdapter(scdoc, cn)
                    Dim dscdoc As New DataSet
                    adcdoc.Fill(dscdoc, "dn")
                    ComboBox7.DataSource = dscdoc.Tables(0)
                    ComboBox7.DisplayMember = "dn"
                    ComboBox7.SelectedIndex = -1

                    Dim sfdoc As String
                    sfdoc = "select * from AM_FDOC"
                    Dim adfdoc As New SqlClient.SqlDataAdapter(sfdoc, cn)
                    Dim dsfdoc As New DataSet
                    adfdoc.Fill(dsfdoc, "AM_FDOC")
                    ComboBox5.DataSource = dsfdoc.Tables(0)
                    ComboBox5.DisplayMember = "FDOCN"
                    ComboBox5.SelectedIndex = -1

                    Dim sMdoc As String
                    sMdoc = "select * from AM_MDOC"
                    Dim adMdoc As New SqlClient.SqlDataAdapter(sMdoc, cn)
                    Dim dsMdoc As New DataSet
                    adMdoc.Fill(dsMdoc, "AM_MDOC")
                    ComboBox1.DataSource = dsMdoc.Tables(0)
                    ComboBox1.DisplayMember = "MDOCN"
                    ComboBox1.SelectedIndex = -1

                    Dim sTdoc As String
                    sTdoc = "select * from AM_TDOC"
                    Dim adTdoc As New SqlClient.SqlDataAdapter(sTdoc, cn)
                    Dim dsTdoc As New DataSet
                    adTdoc.Fill(dsTdoc, "AM_TDOC")
                    ComboBox6.DataSource = dsTdoc.Tables(0)
                    ComboBox6.DisplayMember = "TDOCN"
                    ComboBox6.SelectedIndex = -1

                    Dim sfTdoc As String
                    sfTdoc = "select * from AM_FTDOC"
                    Dim adFTdoc As New SqlClient.SqlDataAdapter(sfTdoc, cn)
                    Dim dsfTdoc As New DataSet
                    adFTdoc.Fill(dsfTdoc, "AM_FTDOC")
                    ComboBox3.DataSource = dsfTdoc.Tables(0)
                    ComboBox3.DisplayMember = "FTDOCN"
                    ComboBox3.SelectedIndex = -1

                    Dim SKAB As String
                    SKAB = "select * from AM_KAB"
                    Dim adKAB As New SqlClient.SqlDataAdapter(SKAB, cn)
                    Dim dsKAB As New DataSet
                    adKAB.Fill(dsKAB, "AM_KAB")
                    ComboBox8.DataSource = dsKAB.Tables(0)
                    ComboBox8.DisplayMember = "KABN"
                    ComboBox8.SelectedIndex = -1

                    'ComboBox2.Text = rd!docn
                    'TextBox1.Text = CDbl(rd!Dock)
                    'ComboBox6.Text = rd!tdocn
                    'TextBox8.Text = CDbl(rd!tdock)
                    'ComboBox1.Text = rd!mdocn
                    'TextBox2.Text = CDbl(rd!mdock)
                    'ComboBox5.Text = rd!fdocn
                    'TextBox7.Text = CDbl(rd!fdock)
                    'ComboBox3.Text = rd!ftdocn
                    'TextBox3.Text = CDbl(rd!ftdock)
                    'ComboBox4.Text = rd!tahn
                    'TextBox6.Text = CDbl(rd!tahk)
                    'ComboBox8.Text = rd!kabn
                    'TextBox5.Text = CDbl(rd!kabk)
                    'ComboBox7.Text = rd!cdocn
                    'TextBox4.Text = CDbl(rd!cdock)
                    ComboBox9.Text = rd!aml_name
                    TextBox9.Text = CDbl(rd!aml_kema)
                    TextBox11.Text = CDbl(rd!C_KEMA)
                    TextBox10.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
                    'TextBox11.Text = Val(TextBox9.Text) - Val(TextBox10.Text)
                    Dim s16 As String = "select * from Amaleat "
                    Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
                    Dim dss As New DataSet
                    dss.Clear()
                    aad.Fill(dss, "Amaleat")
                    Dim vd As New DataView(dss.Tables("Amaleat"))
                    vd.RowFilter = "aml_name=" & "'" & Me.ComboBox9.Text & "'" & ""
                    Me.DataGridView1.DataMember = ""
                    DataGridView1.DataSource = vd
                End If
            End Using
            Button18.Visible = True
        Else
            Button18.Visible = False

        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox9.Text = "" Then
                MsgBox("يرجى ادخال القيمة الإجمالية")
                TextBox9.Focus()
            Else
                Me.B3.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox2.Text = "" Then
                ComboBox2.Text = "لا يوجد"
            End If
            Me.TextBox1.Focus()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "" Then
            Button2.Visible = True
            Button11.Visible = False
        Else
            Dim sn2 As String = "select * from dn where dn=@xx1 "
            Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                cmn2.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                If rdn2.Read = True Then
                    Me.Label4.Text = rdn2!idd
                    Dim sn22 As String = "select * from am_doc where idd=@idd AND IDA=@IDA "
                    Using cmn22 As New SqlClient.SqlCommand(sn22, cn)
                        cmn22.Parameters.AddWithValue("@idd", Label4.Text)
                        cmn22.Parameters.AddWithValue("@IDA", Label5.Text)
                        Dim rdn22 As SqlClient.SqlDataReader = cmn22.ExecuteReader
                        If rdn22.Read = True Then
                            Me.Label7.Text = rdn22!iddd
                            Me.TextBox1.Text = CDbl(rdn22!DOCK)
                            Button2.Visible = False
                            Button11.Visible = True
                        Else
                            Button2.Visible = True
                            Button11.Visible = False
                        End If
                    End Using
                End If
                rdn2.Close()
            End Using
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox1.Text = "" Then
                TextBox1.Text = 0
            End If
            Me.ComboBox5.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox5.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox5.Text = "" Then
                ComboBox5.Text = "لا يوجد"
            End If
            Me.TextBox7.Focus()
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        'If ComboBox5.Text = "" Then
        '    Button3.Visible = True
        '    Button12.Visible = False
        'Else
        '    Dim sn2 As String = "select * from AM_FDOC where FDOCN=@FDOCN "
        '    Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
        '        cmn2.Parameters.AddWithValue("@FDOCN", ComboBox5.Text)
        '        Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
        '        If rdn2.Read = True Then
        '            Me.Label8.Text = rdn2!idF
        '            Me.TextBox7.Text = CDbl(rdn2!FDOCK)
        '            Button3.Visible = False
        '            Button12.Visible = True
        '        Else
        '            Button3.Visible = True
        '            Button12.Visible = False
        '        End If
        '        rdn2.Close()
        '    End Using
        'End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox7.Text = "" Then
                TextBox7.Text = 0
            End If
            Me.ComboBox1.Focus()
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox1.Text = "" Then
                ComboBox1.Text = "لا يوجد"
            End If
            Me.TextBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'If ComboBox1.Text = "" Then
        '    Button4.Visible = True
        '    Button13.Visible = False
        'Else
        '    Dim sn2 As String = "select * from AM_MDOC where MDOCN=@MDOCN "
        '    Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
        '        cmn2.Parameters.AddWithValue("@MDOCN", ComboBox1.Text)
        '        Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
        '        If rdn2.Read = True Then
        '            Me.Label9.Text = rdn2!idMD
        '            Me.TextBox2.Text = CDbl(rdn2!MDOCK)
        '            Button4.Visible = False
        '            Button13.Visible = True
        '        Else
        '            Button4.Visible = True
        '            Button13.Visible = False
        '        End If
        '        rdn2.Close()
        '    End Using
        'End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox2.Text = "" Then
                TextBox2.Text = 0
            End If
            Me.ComboBox6.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox6.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox6.Text = "" Then
                ComboBox6.Text = "لا يوجد"
            End If
            Me.TextBox8.Focus()
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.Text = "" Then
            Button7.Visible = True
            Button14.Visible = False
        Else
            Dim sn2 As String = "select * from AM_TDOC where TDOCN=@TDOCN AND IDA=@IDA "
            Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                cmn2.Parameters.AddWithValue("@TDOCN", Trim(ComboBox6.Text))
                cmn2.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
                Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                If rdn2.Read = True Then
                    Me.Label10.Text = rdn2!idT
                    Me.TextBox8.Text = CDbl(rdn2!TDOCK)
                    Button7.Visible = False
                    Button14.Visible = True
                Else
                    Button7.Visible = True
                    Button14.Visible = False
                End If
                rdn2.Close()
            End Using
        End If
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox8.Text = "" Then
                TextBox8.Text = 0
            End If
            Me.ComboBox3.Focus()
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox3.Text = "" Then
                ComboBox3.Text = "لا يوجد"
            End If
            Me.TextBox3.Focus()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        'If ComboBox3.Text = "" Then
        '    Button6.Visible = True
        '    Button15.Visible = False
        'Else
        '    Dim sn2 As String = "select * from AM_FTDOC where FTDOCN=@FTDOCN "
        '    Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
        '        cmn2.Parameters.AddWithValue("@FTDOCN", ComboBox3.Text)
        '        Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
        '        If rdn2.Read = True Then
        '            Me.Label11.Text = rdn2!idFT
        '            Me.TextBox3.Text = CDbl(rdn2!FTDOCK)
        '            Button6.Visible = False
        '            Button15.Visible = True
        '        Else
        '            Button6.Visible = True
        '            Button15.Visible = False
        '        End If
        '        rdn2.Close()
        '    End Using
        'End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox3.Text = "" Then
                TextBox3.Text = 0
            End If
            Me.ComboBox4.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub ComboBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox4.Text = "" Then
                ComboBox4.Text = "لا يوجد"
            End If
            Me.TextBox6.Focus()
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox6.Text = "" Then
                TextBox6.Text = 0
            End If
            Me.ComboBox7.Focus()
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub ComboBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox7.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox7.Text = "" Then
                ComboBox7.Text = "لا يوجد"
            End If
            Me.TextBox4.Focus()
        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        If ComboBox7.Text = "" Then
            Button8.Visible = True
            Button17.Visible = False
        Else
            Dim sn2 As String = "select * from dn where dn=@xx1 "
            Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                cmn2.Parameters.AddWithValue("@xx1", ComboBox7.Text)
                Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                If rdn2.Read = True Then
                    Me.Label6.Text = rdn2!idd
                    Dim sn22 As String = "select * from am_Cdoc where idd=@idd AND IDA=@IDA "
                    Using cmn22 As New SqlClient.SqlCommand(sn22, cn)
                        cmn22.Parameters.AddWithValue("@idd", Label6.Text)
                        cmn22.Parameters.AddWithValue("@IDA", Label5.Text)
                        Dim rdn22 As SqlClient.SqlDataReader = cmn22.ExecuteReader
                        If rdn22.Read = True Then
                            Me.Label13.Text = rdn22!idC
                            Me.TextBox4.Text = CDbl(rdn22!CDOCK)
                            Button8.Visible = False
                            Button17.Visible = True
                        Else
                            Button8.Visible = True
                            Button17.Visible = False
                        End If
                    End Using
                End If
                rdn2.Close()
            End Using
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox4.Text = "" Then
                TextBox4.Text = 0
            End If
            Me.ComboBox8.Focus()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub ComboBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox8.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ComboBox8.Text = "" Then
                ComboBox8.Text = "لا يوجد"
            End If
            Me.TextBox5.Focus()
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        'If ComboBox8.Text = "" Then
        '    Button9.Visible = True
        '    Button16.Visible = False
        'Else
        '    Dim sn2 As String = "select * from AM_KAB where KABN=@KABN "
        '    Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
        '        cmn2.Parameters.AddWithValue("@KABN", ComboBox8.Text)
        '        Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
        '        If rdn2.Read = True Then
        '            Me.Label12.Text = rdn2!idKA
        '            Me.TextBox5.Text = CDbl(rdn2!KABK)
        '            Button9.Visible = False
        '            Button16.Visible = True
        '        Else
        '            Button9.Visible = True
        '            Button16.Visible = False
        '        End If
        '        rdn2.Close()
        '    End Using
        'End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TextBox5.Text = "" Then
                TextBox5.Text = 0
            End If
            Me.B3.Focus()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ss As String = "insert into AM_DOC(IDA,IDD,dock)values(@IDA,@IDD,@dock)"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@IDD", CInt(Label4.Text))
            cmm.Parameters.AddWithValue("@dock", CDbl(TextBox1.Text))
            'Dim ssa As String = "update Amaleat set docn=@docn,dock=@dock where ida=@ida"
            'Using cmma As New SqlClient.SqlCommand(ssa, cn)
            '    cmma.Parameters.AddWithValue("@docn", CInt(Label4.Text))
            '    cmma.Parameters.AddWithValue("@dock", CInt(Label4.Text))
            '    cmma.Parameters.AddWithValue("@ida", CDbl(TextBox1.Text))
            Try
                cmm.ExecuteNonQuery()
                'cmma.ExecuteNonQuery()
                MsgBox("تم الحفظ")
            Catch ex As Exception
                MsgBox("لم يتم الحفظ راجع مدخلك")
            End Try
        End Using
        'End Using
        Dim ss23 As String = "insert into dnkema(idd,Ejraa,IDA,Kema,kemaej) VALUES(@idd,@Ejraa,@IDA,@Kema,@kemaej)"
        Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
        cmm23.Parameters.AddWithValue("@idd", CInt(Label4.Text))
        cmm23.Parameters.AddWithValue("@Ejraa", CInt(1))
        cmm23.Parameters.AddWithValue("@IDA", CInt(M6))
        cmm23.Parameters.AddWithValue("@Kema", CDbl(TextBox1.Text))
        cmm23.Parameters.AddWithValue("@kemaej", CDbl(TextBox9.Text))
        Try
            cmm23.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ComboBox9.DropDownStyle = ComboBoxStyle.DropDown
        Button10.Visible = False
        ComboBox9.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ss As String = "insert into AM_FDOC(IDA,FDOCN,Fdock)values(@IDA,@FDOCN,@Fdock)"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@FDOCN", ComboBox5.Text)
            cmm.Parameters.AddWithValue("@Fdock", CDbl(TextBox7.Text))
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم الحفظ")
                Dim sk2 As String
                sk2 = "select * from AM_FDOC"
                Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "AM_FDOC")
                ComboBox5.DataSource = dsk2.Tables(0)
                ComboBox5.DisplayMember = "FDOCN"
                ComboBox5.SelectedIndex = -1
            Catch ex As Exception
                MsgBox("لم يتم الحفظ راجع مدخلك")
            End Try
        End Using

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ss As String = "insert into AM_MDOC(IDA,MDOCN,Mdock)values(@IDA,@MDOCN,@Mdock)"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@MDOCN", ComboBox1.Text)
            cmm.Parameters.AddWithValue("@Mdock", CDbl(TextBox2.Text))
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم الحفظ")
                Dim skM As String
                skM = "select * from AM_MDOC"
                Dim adkM As New SqlClient.SqlDataAdapter(skM, cn)
                Dim dskM As New DataSet
                adkM.Fill(dskM, "AM_MDOC")
                ComboBox1.DataSource = dskM.Tables(0)
                ComboBox1.DisplayMember = "MDOCN"
                ComboBox1.SelectedIndex = -1
            Catch ex As Exception
                MsgBox("لم يتم الحفظ راجع مدخلك")
            End Try
        End Using

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ss As String = "insert into AM_TDOC(IDA,TDOCN,Tdock)values(@IDA,@TDOCN,@Tdock)"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@TDOCN", ComboBox6.Text)
            cmm.Parameters.AddWithValue("@Tdock", CDbl(TextBox8.Text))
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم الحفظ")
                Dim skT As String
                skT = "select * from AM_TDOC"
                Dim adkT As New SqlClient.SqlDataAdapter(skT, cn)
                Dim dskT As New DataSet
                adkT.Fill(dskT, "AM_TDOC")
                ComboBox6.DataSource = dskT.Tables(0)
                ComboBox6.DisplayMember = "TDOCN"
                ComboBox6.SelectedIndex = -1
            Catch ex As Exception
                MsgBox("لم يتم الحفظ راجع مدخلك")
            End Try
        End Using

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ss As String = "insert into AM_FTDOC(IDA,FTDOCN,FTdock)values(@IDA,@FTDOCN,@FTdock)"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@FTDOCN", ComboBox3.Text)
            cmm.Parameters.AddWithValue("@FTdock", CDbl(TextBox3.Text))
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم الحفظ")
                Dim skFT As String
                skFT = "select * from AM_FTDOC"
                Dim adkFT As New SqlClient.SqlDataAdapter(skFT, cn)
                Dim dskFT As New DataSet
                adkFT.Fill(dskFT, "AM_FTDOC")
                ComboBox3.DataSource = dskFT.Tables(0)
                ComboBox3.DisplayMember = "FTDOCN"
                ComboBox3.SelectedIndex = -1

            Catch ex As Exception
                MsgBox("لم يتم الحفظ راجع مدخلك")
            End Try
        End Using

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim ss As String = "insert into AM_CDOC(IDA,IDD,Cdock)values(@IDA,@IDD,@Cdock)"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@IDD", CInt(Label6.Text))
            cmm.Parameters.AddWithValue("@Cdock", CDbl(TextBox4.Text))
            Try
                cmm.ExecuteNonQuery()
                Dim sk2 As String
                sk2 = "select * from dn WHERE IDK=" & 1
                Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "dn")
                ComboBox7.DataSource = dsk2.Tables(0)
                ComboBox7.DisplayMember = "dn"
                ComboBox7.SelectedIndex = -1
                MsgBox("تم الحفظ")
            Catch ex As Exception
                'MsgBox("لم يتم الحفظ راجع مدخلك")
            End Try
        End Using
        Dim ss23 As String = "INSERT INTO dnkema(idd,Ejraa,Kema,kemaej)VALUES(@idd,@Ejraa,@Kema,@kemaej)"
        Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
        cmm23.Parameters.AddWithValue("@idd", Label6.Text)
        cmm23.Parameters.AddWithValue("@Ejraa", CInt(1))
        cmm23.Parameters.AddWithValue("@Kema", CDbl(TextBox4.Text))
        cmm23.Parameters.AddWithValue("@kemaej", CDbl(TextBox9.Text))
        Try
            cmm23.ExecuteNonQuery()
            'MsgBox("تم التعديل")
        Catch ex As Exception
            'MsgBox("لم يتم الحفظ راجع مدخلك")
        End Try

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim ss As String = "insert into AM_KAB(IDA,KABN,KABK)values(@IDA,@KABN,@KABK)"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@KABN", ComboBox8.Text)
            cmm.Parameters.AddWithValue("@KABK", CDbl(TextBox5.Text))
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم الحفظ")
                Dim skK As String
                skK = "select * from AM_KAB"
                Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
                Dim dskK As New DataSet
                adkK.Fill(dskK, "AM_KAB")
                ComboBox8.DataSource = dskK.Tables(0)
                ComboBox8.DisplayMember = "KABN"
                ComboBox8.SelectedIndex = -1

            Catch ex As Exception
                MsgBox("لم يتم الحفظ راجع مدخلك")
            End Try
        End Using

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ss As String = "insert into TAH(IDA,TAHN,TAHK)values(@IDA,@TAHN,@TAHK)"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@TAHN", ComboBox4.Text)
            cmm.Parameters.AddWithValue("@TAHK", CDbl(TextBox6.Text))
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم الحفظ")
            Catch ex As Exception
                MsgBox("لم يتم الحفظ راجع مدخلك")
            End Try
        End Using
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Call Class1.CONNIC()
        Dim ss As String = "update AM_DOC set IDA=@IDA,IDD=@IDD,dock=@dock where iddd=@iddd"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@IDD", CInt(Label4.Text))
            cmm.Parameters.AddWithValue("@dock", CDbl(TextBox1.Text))
            cmm.Parameters.AddWithValue("@IDDD", CInt(Label7.Text))
            Try
                cmm.ExecuteNonQuery()
                'MsgBox("تم التعديل")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
        Dim sn2 As String = "select * from dnkema where IDA=@IDA "
        Using cmn28 As New SqlClient.SqlCommand(sn2, cn)
            cmn28.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            Dim rdn28 As SqlClient.SqlDataReader = cmn28.ExecuteReader
            If rdn28.Read = True Then
                Dim ss23 As String = "UPDATE dnkema SET idd=@idd,Ejraa=@Ejraa,Kema=@Kema,kemaej=@kemaej WHERE IDA=@IDA"
                Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
                cmm23.Parameters.AddWithValue("@idd", Label4.Text)
                cmm23.Parameters.AddWithValue("@Ejraa", CInt(1))
                cmm23.Parameters.AddWithValue("@Kema", CDbl(TextBox1.Text))
                cmm23.Parameters.AddWithValue("@kemaej", CDbl(TextBox9.Text))
                cmm23.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
                Try
                    cmm23.ExecuteNonQuery()
                    'MsgBox("تم التعديل")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Dim ss231 As String = "insert into dnkema(idd,Ejraa,Kema,kemaej,IDA) values(@idd,@Ejraa,@Kema,@kemaej,@IDA)"
                Dim cmm231 As New SqlClient.SqlCommand(ss231, cn)
                cmm231.Parameters.AddWithValue("@idd", Label4.Text)
                cmm231.Parameters.AddWithValue("@Ejraa", CInt(1))
                cmm231.Parameters.AddWithValue("@Kema", CDbl(TextBox1.Text))
                cmm231.Parameters.AddWithValue("@kemaej", CDbl(TextBox9.Text))
                cmm231.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
                Try
                    cmm231.ExecuteNonQuery()
                    'MsgBox("تم التعديل")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End Using

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim ss As String = "UPDATE AM_FDOC SET IDA=@IDA,FDOCN=@FDOCN,Fdock=@Fdock WHERE IDF=@IDF "
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@FDOCN", ComboBox5.Text)
            cmm.Parameters.AddWithValue("@Fdock", CDbl(TextBox7.Text))
            cmm.Parameters.AddWithValue("@IDF", CInt(Label5.Text))
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم الحفظ")
                Dim sk2 As String
                sk2 = "select * from AM_FDOC"
                Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
                Dim dsk2 As New DataSet
                adk2.Fill(dsk2, "AM_FDOC")
                ComboBox5.DataSource = dsk2.Tables(0)
                ComboBox5.DisplayMember = "FDOCN"
                ComboBox5.SelectedIndex = -1
            Catch ex As Exception
                MsgBox("لم يتم الحفظ راجع مدخلك")
            End Try
        End Using
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim ss As String = "UPDATE AM_MDOC SET IDA=@IDA,MDOCN=@MDOCN,Mdock=@Mdock WHERE IDMD=@IDMD"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@MDOCN", ComboBox1.Text)
            cmm.Parameters.AddWithValue("@Mdock", CDbl(TextBox2.Text))
            cmm.Parameters.AddWithValue("@IDMD", CInt(Label9.Text))
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم التعديل")
                Dim skM As String
                skM = "select * from AM_MDOC"
                Dim adkM As New SqlClient.SqlDataAdapter(skM, cn)
                Dim dskM As New DataSet
                adkM.Fill(dskM, "AM_MDOC")
                ComboBox1.DataSource = dskM.Tables(0)
                ComboBox1.DisplayMember = "MDOCN"
                ComboBox1.SelectedIndex = -1
            Catch ex As Exception
                MsgBox("لم يتم التعديل راجع مدخلك")
            End Try
        End Using

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim ss As String = "UPDATE AM_TDOC SET IDA=@IDA,TDOCN=@TDOCN,Tdock=@Tdock WHERE IDT=@IDT"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@TDOCN", ComboBox6.Text)
            cmm.Parameters.AddWithValue("@Tdock", CDbl(TextBox8.Text))
            cmm.Parameters.AddWithValue("@IDT", CInt(Label10.Text))
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم التعديل")
                Dim skT As String
                skT = "select * from AM_TDOC"
                Dim adkT As New SqlClient.SqlDataAdapter(skT, cn)
                Dim dskT As New DataSet
                adkT.Fill(dskT, "AM_TDOC")
                ComboBox6.DataSource = dskT.Tables(0)
                ComboBox6.DisplayMember = "TDOCN"
                ComboBox6.SelectedIndex = -1
            Catch ex As Exception
                MsgBox("لم يتم الحفظ راجع مدخلك")
            End Try
        End Using

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim ss As String = "UPDATE AM_FTDOC SET IDA=@IDA,FTDOCN=@FTDOCN,FTdock=@FTdock WHERE IDFT=@IDFT"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@FTDOCN", ComboBox3.Text)
            cmm.Parameters.AddWithValue("@FTdock", CDbl(TextBox3.Text))
            cmm.Parameters.AddWithValue("@IDFT", CInt(Label11.Text))
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم الحفظ")
                Dim skFT As String
                skFT = "select * from AM_FTDOC"
                Dim adkFT As New SqlClient.SqlDataAdapter(skFT, cn)
                Dim dskFT As New DataSet
                adkFT.Fill(dskFT, "AM_FTDOC")
                ComboBox3.DataSource = dskFT.Tables(0)
                ComboBox3.DisplayMember = "FTDOCN"
                ComboBox3.SelectedIndex = -1

            Catch ex As Exception
                MsgBox("لم يتم الحفظ راجع مدخلك")
            End Try
        End Using

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim ss As String = "update AM_CDOC set IDA=@IDA,IDD=@IDD,Cdock=@Cdock where idC=@idC"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@IDD", CInt(Label6.Text))
            cmm.Parameters.AddWithValue("@Cdock", CDbl(TextBox4.Text))
            cmm.Parameters.AddWithValue("@IDC", CInt(Label13.Text))
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم التعديل")
            Catch ex As Exception
                'MsgBox("لم يتم الحفظ راجع مدخلك")
            End Try
        End Using
        Dim ss23 As String = "UPDATE dnkema SET idd=@idd,Ejraa=@Ejraa,Kema=@Kema,kemaej=@kemaej WHERE IDA=@IDA"
        Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
        cmm23.Parameters.AddWithValue("@idd", Label6.Text)
        cmm23.Parameters.AddWithValue("@Ejraa", CInt(1))
        cmm23.Parameters.AddWithValue("@Kema", CDbl(TextBox4.Text))
        cmm23.Parameters.AddWithValue("@kemaej", CDbl(TextBox9.Text))
        cmm23.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
        Try
            cmm23.ExecuteNonQuery()
            'MsgBox("تم التعديل")
        Catch ex As Exception
            'MsgBox("لم يتم الحفظ راجع مدخلك")
        End Try

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim ss As String = "UPDATE KAB SET IDA=@IDA,KABN=@KABN,KABK=@KABK WHERE IDKA=@IDKA"
        Using cmm As New SqlClient.SqlCommand(ss, cn)
            cmm.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
            cmm.Parameters.AddWithValue("@KABN", ComboBox8.Text)
            cmm.Parameters.AddWithValue("@KABK", CDbl(TextBox5.Text))
            cmm.Parameters.AddWithValue("@IDKA", CInt(Label12.Text))
            Try
                cmm.ExecuteNonQuery()
                MsgBox("تم التعديل")
                Dim skK As String
                skK = "select * from AM_KAB"
                Dim adkK As New SqlClient.SqlDataAdapter(skK, cn)
                Dim dskK As New DataSet
                adkK.Fill(dskK, "AM_KAB")
                ComboBox8.DataSource = dskK.Tables(0)
                ComboBox8.DisplayMember = "KABN"
                ComboBox8.SelectedIndex = -1

            Catch ex As Exception
                MsgBox("لم يتم التعديل راجع مدخلك")
            End Try
        End Using

    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "" Then

            Button4.Visible = True
            Button13.Visible = False
        Else
            Dim sn2 As String = "select * from AM_MDOC where MDOCN=@MDOCN and ida=@ida "
            Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                cmn2.Parameters.AddWithValue("@MDOCN", ComboBox1.Text)
                cmn2.Parameters.AddWithValue("@ida", Label5.Text)
                Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                If rdn2.Read = True Then
                    Me.Label9.Text = rdn2!idMD
                    Me.TextBox2.Text = CDbl(rdn2!MDOCK)
                    Button4.Visible = False
                    Button13.Visible = True
                Else
                    Button4.Visible = True
                    Button13.Visible = False
                End If
                rdn2.Close()
            End Using
        End If
    End Sub

    Private Sub ComboBox1_TextUpdate(sender As Object, e As EventArgs) Handles ComboBox1.TextUpdate

    End Sub

    Private Sub ComboBox5_TextChanged(sender As Object, e As EventArgs) Handles ComboBox5.TextChanged
        If ComboBox5.Text = "" Then
            Button3.Visible = True
            Button12.Visible = False
        Else
            Dim sn2 As String = "select * from AM_FDOC where FDOCN=@FDOCN and ida=@ida"
            Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                cmn2.Parameters.AddWithValue("@FDOCN", ComboBox5.Text)
                cmn2.Parameters.AddWithValue("@ida", Label5.Text)
                Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                If rdn2.Read = True Then
                    Me.Label8.Text = rdn2!idF
                    Me.TextBox7.Text = CDbl(rdn2!FDOCK)
                    Button3.Visible = False
                    Button12.Visible = True
                Else
                    Button3.Visible = True
                    Button12.Visible = False
                End If
                rdn2.Close()
            End Using
        End If

    End Sub

    Private Sub ComboBox3_TextChanged(sender As Object, e As EventArgs) Handles ComboBox3.TextChanged
        If ComboBox3.Text = "" Then
            Button6.Visible = True
            Button15.Visible = False
        Else
            Dim sn2 As String = "select * from AM_FTDOC where FTDOCN=@FTDOCN and ida=@ida "
            Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                cmn2.Parameters.AddWithValue("@FTDOCN", ComboBox3.Text)
                cmn2.Parameters.AddWithValue("@ida", Label5.Text)
                Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                If rdn2.Read = True Then
                    Me.Label11.Text = rdn2!idFT
                    Me.TextBox3.Text = CDbl(rdn2!FTDOCK)
                    Button6.Visible = False
                    Button15.Visible = True
                Else
                    Button6.Visible = True
                    Button15.Visible = False
                End If
                rdn2.Close()
            End Using
        End If

    End Sub

    Private Sub ComboBox8_TextChanged(sender As Object, e As EventArgs) Handles ComboBox8.TextChanged
        If ComboBox8.Text = "" Then
            Button9.Visible = True
            Button16.Visible = False
        Else
            Dim sn2 As String = "select * from AM_KAB where KABN=@KABN and ida=@ida "
            Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                cmn2.Parameters.AddWithValue("@KABN", ComboBox8.Text)
                cmn2.Parameters.AddWithValue("@ida", Label5.Text)
                Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                If rdn2.Read = True Then
                    Me.Label12.Text = rdn2!idKA
                    Me.TextBox5.Text = CDbl(rdn2!KABK)
                    Button9.Visible = False
                    Button16.Visible = True
                Else
                    Button9.Visible = True
                    Button16.Visible = False
                End If
                rdn2.Close()
            End Using
        End If

    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        If ComboBox2.Text = "" Then
            Button2.Visible = True
            Button11.Visible = False
        Else
            Dim sn2 As String = "select * from dn where dn=@xx1 "
            Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                cmn2.Parameters.AddWithValue("@xx1", ComboBox2.Text)
                Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                If rdn2.Read = True Then
                    Me.Label4.Text = rdn2!idd
                    Dim sn22 As String = "select * from am_doc where idd=@idd "
                    Using cmn22 As New SqlClient.SqlCommand(sn22, cn)
                        cmn22.Parameters.AddWithValue("@idd", Label4.Text)
                        Dim rdn22 As SqlClient.SqlDataReader = cmn22.ExecuteReader
                        If rdn22.Read = True Then
                            Me.Label7.Text = rdn22!iddd
                            Me.TextBox1.Text = CDbl(rdn22!DOCK)
                            Button2.Visible = False
                            Button11.Visible = True
                        Else
                            Button2.Visible = True
                            Button11.Visible = False
                        End If
                    End Using
                End If
                rdn2.Close()
            End Using
        End If
    End Sub

    Private Sub ComboBox6_TextChanged(sender As Object, e As EventArgs) Handles ComboBox6.TextChanged
        If ComboBox6.Text = "" Then
            Button7.Visible = True
            Button14.Visible = False
        Else
            Dim sn2 As String = "select * from AM_TDOC where TDOCN=@TDOCN AND IDA=@IDA "
            Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                cmn2.Parameters.AddWithValue("@TDOCN", Trim(ComboBox6.Text))
                cmn2.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
                Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                If rdn2.Read = True Then
                    Me.Label10.Text = rdn2!idT
                    Me.TextBox8.Text = CDbl(rdn2!TDOCK)
                    Button7.Visible = False
                    Button14.Visible = True
                Else
                    Button7.Visible = True
                    Button14.Visible = False
                End If
                rdn2.Close()
            End Using
        End If
    End Sub

    Private Sub ComboBox7_TextChanged(sender As Object, e As EventArgs) Handles ComboBox7.TextChanged
        If ComboBox7.Text = "" Then
            Button8.Visible = True
            Button17.Visible = False
        Else
            Dim sn2 As String = "select * from dn where dn=@xx1 "
            Using cmn2 As New SqlClient.SqlCommand(sn2, cn)
                cmn2.Parameters.AddWithValue("@xx1", ComboBox7.Text)
                Dim rdn2 As SqlClient.SqlDataReader = cmn2.ExecuteReader
                If rdn2.Read = True Then
                    Me.Label6.Text = rdn2!idd
                    Dim sn22 As String = "select * from am_Cdoc where idd=@idd "
                    Using cmn22 As New SqlClient.SqlCommand(sn22, cn)
                        cmn22.Parameters.AddWithValue("@idd", Label6.Text)
                        Dim rdn22 As SqlClient.SqlDataReader = cmn22.ExecuteReader
                        If rdn22.Read = True Then
                            Me.Label13.Text = rdn22!idC
                            Me.TextBox4.Text = CDbl(rdn22!CDOCK)
                            Button8.Visible = False
                            Button17.Visible = True
                        Else
                            Button8.Visible = True
                            Button17.Visible = False
                        End If
                    End Using
                End If
                rdn2.Close()
            End Using
        End If
    End Sub

    Private Sub B3_ClientSizeChanged(sender As Object, e As EventArgs) Handles B3.ClientSizeChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Trim(ComboBox5.Text) = "" Or ComboBox5.SelectedIndex = -1 Then
            ComboBox5.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox5.Text = "لايوجد"
            TextBox7.Text = 0
        End If
        'If Trim(ComboBox2.Text) = "" Or ComboBox2.SelectedIndex = -1 Then
        '    ComboBox2.DropDownStyle = ComboBoxStyle.DropDown
        '    ComboBox2.Text = "لايوجد"
        '    TextBox1.Text = 0
        'End If
        If Trim(ComboBox1.Text) = "" Or ComboBox1.SelectedIndex = -1 Then
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox1.Text = "لايوجد"
            TextBox2.Text = 0
        End If
        If Trim(ComboBox6.Text) = "" Or ComboBox6.SelectedIndex = -1 Then
            ComboBox6.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox6.Text = "لايوجد"
            TextBox8.Text = 0
        End If
        If Trim(ComboBox3.Text) = "" Or ComboBox3.SelectedIndex = -1 Then
            ComboBox3.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox3.Text = "لايوجد"
            TextBox3.Text = 0
        End If
        If Trim(ComboBox7.Text) = "" Or ComboBox7.SelectedIndex = -1 Then
            ComboBox7.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox7.Text = "لايوجد"
            TextBox4.Text = 0
        End If
        If Trim(ComboBox8.Text) = "" Or ComboBox8.SelectedIndex = -1 Then
            ComboBox8.DropDownStyle = ComboBoxStyle.DropDown
            ComboBox8.Text = "لايوجد"
            TextBox5.Text = 0
        End If
        If Trim(TextBox6.Text) = "" Then
            TextBox6.Text = 0
        End If

        TextBox10.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
        TextBox11.Text = Val(TextBox9.Text) - Val(TextBox10.Text)
        Dim s As String = "select * from amaleat where aml_name=@xxx1 "
        Using cm As New SqlClient.SqlCommand(s, cn)
            cm.Parameters.AddWithValue("@xxx1", ComboBox9.Text)
            Dim rd As SqlClient.SqlDataReader = cm.ExecuteReader
            If rd.Read = True Then
                If MsgBox("نوع العملية مسجل مسبقا ... هل تود التعديل في البيانات", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim ss As String = "update Amaleat set docn=@docn,dock=@dock,tdocn=@tdocn,tdock=@tdock,mdocn=@mdocn,mdock=@mdock,fdocn=@fdocn,fdock=@fdock,ftdocn=@ftdocn,ftdock=@ftdock,tahn=@tahn,tahk=@tahk,kabn=@kabn,kabk=@kabk,cdocn=@cdocn,cdock=@cdock,aml_name=@aml_name,aml_kema=@aml_kema,C_KEMA=@C_KEMA where aml_name=@aml_namex"
                    Using cmm As New SqlClient.SqlCommand(ss, cn)
                        cmm.Parameters.AddWithValue("@docn", CInt(Label4.Text))
                        cmm.Parameters.AddWithValue("@dock", CDbl(TextBox1.Text))
                        cmm.Parameters.AddWithValue("@tdocn", ComboBox6.Text)
                        cmm.Parameters.AddWithValue("@tdock", CDbl(TextBox8.Text))
                        cmm.Parameters.AddWithValue("@mdocn", ComboBox1.Text)
                        cmm.Parameters.AddWithValue("@mdock", CDbl(TextBox2.Text))
                        cmm.Parameters.AddWithValue("@fdocn", ComboBox5.Text)
                        cmm.Parameters.AddWithValue("@fdock", CDbl(TextBox7.Text))
                        cmm.Parameters.AddWithValue("@ftdocn", ComboBox3.Text)
                        cmm.Parameters.AddWithValue("@ftdock", CDbl(TextBox3.Text))
                        cmm.Parameters.AddWithValue("@tahn", ComboBox4.Text)
                        cmm.Parameters.AddWithValue("@tahk", CDbl(TextBox6.Text))
                        cmm.Parameters.AddWithValue("@kabn", ComboBox8.Text)
                        cmm.Parameters.AddWithValue("@kabk", CDbl(TextBox5.Text))
                        cmm.Parameters.AddWithValue("@cdocn", ComboBox7.Text)
                        cmm.Parameters.AddWithValue("@cdock", CDbl(TextBox4.Text))
                        cmm.Parameters.AddWithValue("@aml_name", ComboBox9.Text)
                        cmm.Parameters.AddWithValue("@aml_kema", CDbl(TextBox9.Text))
                        cmm.Parameters.AddWithValue("@aml_namex", ComboBox9.Text)
                        cmm.Parameters.AddWithValue("@C_KEMA", TextBox11.Text)

                        Try
                            cmm.ExecuteNonQuery()
                            MsgBox("تم التعديل")
                            Dim Str As String = "SELECT MAX(IDA) FROM Amaleat "
                            Using cmd As New SqlClient.SqlCommand(Str, cn)
                                M6 = cmd.ExecuteScalar
                            End Using

                            Dim sl As String = "select * from dn where dn=@dn"
                            Using cml As New SqlClient.SqlCommand(sl, cn)
                                cml.Parameters.AddWithValue("@dn", ComboBox2.Text)
                                Dim rdl As SqlClient.SqlDataReader
                                rdl = cml.ExecuteReader
                                If rdl.Read = True Then
                                    Label2.Text = rdl!idd
                                    rdl.Close()
                                End If
                            End Using

                            Dim sA As String = "select * from Ejraa where Ejraa=@Ejraa"
                            Using cmA As New SqlClient.SqlCommand(sA, cn)
                                cmA.Parameters.AddWithValue("@Ejraa", ComboBox3.Text)
                                Dim rdA As SqlClient.SqlDataReader
                                rdA = cm.ExecuteReader
                                If rdA.Read = True Then
                                    Label1.Text = rdA!idj
                                    rdA.Close()
                                End If
                            End Using

                            Dim ss23 As String = "UPDATE dnkema SET idd=@idd,Ejraa=@Ejraa,Kema=@Kema,kemaej=@kemaej WHERE IDA=@IDA"
                            Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
                            cmm23.Parameters.AddWithValue("@idd", Label2.Text)
                            cmm23.Parameters.AddWithValue("@Ejraa", Label1.Text)
                            cmm23.Parameters.AddWithValue("@Kema", TextBox1.Text)
                            cmm23.Parameters.AddWithValue("@kemaej", TextBox9.Text)
                            cmm23.Parameters.AddWithValue("@IDA", Label5.Text)
                            cmm23.ExecuteNonQuery()

                            Dim s16 As String = "select * from Amaleat "
                            Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
                            Dim dss As New DataSet
                            dss.Clear()
                            aad.Fill(dss, "Amaleat")
                            Dim vd As New DataView(dss.Tables("Amaleat"))
                            vd.RowFilter = "aml_name=" & "'" & Me.ComboBox9.Text & "'" & ""
                            Me.DataGridView1.DataMember = ""
                            DataGridView1.DataSource = vd
                        Catch ex As Exception
                            MsgBox("لم يتم الحفظ... راجع مدخلاتك")
                        End Try
                    End Using
                End If
            Else
                Dim ss As String = "insert into Amaleat(docn,dock,tdocn,tdock,mdocn,mdock,fdocn,fdock,ftdocn,ftdock,tahn,tahk,kabn,kabk,cdocn,cdock,aml_name,aml_kema,C_KEMA)values(@docn,@dock,@tdocn,@tdock,@mdocn,@mdock,@fdocn,@fdock,@ftdocn,@ftdock,@tahn,@tahk,@kabn,@kabk,@cdocn,@cdock,@aml_name,@aml_kema,@C_KEMA)"
                Using cmm As New SqlClient.SqlCommand(ss, cn)
                    cmm.Parameters.AddWithValue("@docn", CInt(Label4.Text))
                    cmm.Parameters.AddWithValue("@dock", CDbl(TextBox1.Text))
                    cmm.Parameters.AddWithValue("@tdocn", ComboBox6.Text)
                    cmm.Parameters.AddWithValue("@tdock", CDbl(TextBox8.Text))
                    cmm.Parameters.AddWithValue("@mdocn", ComboBox1.Text)
                    cmm.Parameters.AddWithValue("@mdock", CDbl(TextBox2.Text))
                    cmm.Parameters.AddWithValue("@fdocn", ComboBox5.Text)
                    cmm.Parameters.AddWithValue("@fdock", CDbl(TextBox7.Text))
                    cmm.Parameters.AddWithValue("@ftdocn", ComboBox3.Text)
                    cmm.Parameters.AddWithValue("@ftdock", CDbl(TextBox3.Text))
                    cmm.Parameters.AddWithValue("@tahn", ComboBox4.Text)
                    cmm.Parameters.AddWithValue("@tahk", CDbl(TextBox6.Text))
                    cmm.Parameters.AddWithValue("@kabn", ComboBox8.Text)
                    cmm.Parameters.AddWithValue("@kabk", CDbl(TextBox5.Text))
                    cmm.Parameters.AddWithValue("@cdocn", ComboBox7.Text)
                    cmm.Parameters.AddWithValue("@cdock", CDbl(TextBox4.Text))
                    cmm.Parameters.AddWithValue("@aml_name", ComboBox9.Text)
                    cmm.Parameters.AddWithValue("@C_KEMA", TextBox11.Text)
                    'TextBox9.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
                    cmm.Parameters.AddWithValue("@aml_kema", CDbl(TextBox9.Text))
                    'Try
                    cmm.ExecuteNonQuery()
                    MsgBox("تم الحفظ")
                    Dim Str As String = "SELECT MAX(IDA) FROM Amaleat "
                    Using cmd As New SqlClient.SqlCommand(Str, cn)
                        M6 = cmd.ExecuteScalar
                    End Using
                    Dim sl As String = "select * from dn where dn=@dn"
                    Using cml As New SqlClient.SqlCommand(sl, cn)
                        cml.Parameters.AddWithValue("@dn", ComboBox2.Text)
                        Using rdl As SqlClient.SqlDataReader = cml.ExecuteReader
                            If rdl.Read = True Then
                                Label2.Text = rdl!idd
                                rdl.Close()
                            End If
                        End Using
                    End Using

                    Dim sA As String = "select * from Ejraa where Ejraa=@Ejraa"
                    Using cmA As New SqlClient.SqlCommand(sA, cn)
                        cmA.Parameters.AddWithValue("@Ejraa", "عمليات")
                        Using rdA As SqlClient.SqlDataReader = cmA.ExecuteReader
                            If rdA.Read = True Then
                                Label1.Text = rdA!idj
                                rdA.Close()
                            End If
                        End Using
                    End Using
                    If Val(Label2.Text) <> 0 Then
                        Dim ss23 As String = "insert into dnkema(idd,Ejraa,IDA,Kema,kemaej) VALUES(@idd,@Ejraa,@IDA,@Kema,@kemaej)"
                        Dim cmm23 As New SqlClient.SqlCommand(ss23, cn)
                        cmm23.Parameters.AddWithValue("@idd", CInt(Label2.Text))
                        cmm23.Parameters.AddWithValue("@Ejraa", CInt(Label1.Text))
                        cmm23.Parameters.AddWithValue("@IDA", CInt(M6))
                        cmm23.Parameters.AddWithValue("@Kema", CDbl(TextBox1.Text))
                        cmm23.Parameters.AddWithValue("@kemaej", CDbl(TextBox9.Text))
                        cmm23.ExecuteNonQuery()

                    End If

                    Dim s16 As String = "select * from Amaleat "
                    Dim aad As New SqlClient.SqlDataAdapter(s16, cn)
                    Dim dss As New DataSet
                    dss.Clear()
                    aad.Fill(dss, "Amaleat")
                    Dim vd As New DataView(dss.Tables("Amaleat"))
                    vd.RowFilter = "aml_name=" & "'" & Me.ComboBox9.Text & "'" & ""
                    Me.DataGridView1.DataMember = ""
                    DataGridView1.DataSource = vd
                    'Catch ex As Exception
                    '    MsgBox("لم يتم الحفظى... راجع مدخلاتك")
                    'End Try
                End Using
            End If
            'end using
        End Using
        'Dim sM As String = "select * from amaleat_M where aml_name=@xxx1 "
        'Using cmD As New SqlClient.SqlCommand(sM, cn)
        '    cmD.Parameters.AddWithValue("@xxx1", ComboBox9.Text)
        '    Dim rdM As SqlClient.SqlDataReader = cmD.ExecuteReader
        '    If rdM.Read = True Then
        '        Dim ssM As String = "update Amaleat_M set docn=@docn,dock=@dock,tdocn=@tdocn,tdock=@tdock,mdocn=@mdocn,mdock=@mdock,fdocn=@fdocn,fdock=@fdock,ftdocn=@ftdocn,ftdock=@ftdock,tahn=@tahn,tahk=@tahk,kabn=@kabn,kabk=@kabk,cdocn=@cdocn,cdock=@cdock,aml_name=@aml_name,aml_kema=@aml_kema,C_KEMA=@C_KEMA where aml_name=@aml_namex"
        '        Using cmmM As New SqlClient.SqlCommand(ssM, cn)
        '            cmmM.Parameters.AddWithValue("@docn", CInt(Label4.Text))
        '            cmmM.Parameters.AddWithValue("@dock", CDbl(TextBox1.Text))
        '            cmmM.Parameters.AddWithValue("@tdocn", ComboBox6.Text)
        '            cmmM.Parameters.AddWithValue("@tdock", CDbl(TextBox8.Text))
        '            cmmM.Parameters.AddWithValue("@mdocn", ComboBox1.Text)
        '            cmmM.Parameters.AddWithValue("@mdock", CDbl(TextBox2.Text))
        '            cmmM.Parameters.AddWithValue("@fdocn", ComboBox5.Text)
        '            cmmM.Parameters.AddWithValue("@fdock", CDbl(TextBox7.Text))
        '            cmmM.Parameters.AddWithValue("@ftdocn", ComboBox3.Text)
        '            cmmM.Parameters.AddWithValue("@ftdock", CDbl(TextBox3.Text))
        '            cmmM.Parameters.AddWithValue("@tahn", ComboBox4.Text)
        '            cmmM.Parameters.AddWithValue("@tahk", CDbl(TextBox6.Text))
        '            cmmM.Parameters.AddWithValue("@kabn", ComboBox8.Text)
        '            cmmM.Parameters.AddWithValue("@kabk", CDbl(TextBox5.Text))
        '            cmmM.Parameters.AddWithValue("@cdocn", ComboBox7.Text)
        '            cmmM.Parameters.AddWithValue("@cdock", CDbl(TextBox4.Text))
        '            cmmM.Parameters.AddWithValue("@aml_name", ComboBox9.Text)
        '            cmmM.Parameters.AddWithValue("@aml_kema", CDbl(TextBox9.Text))
        '            cmmM.Parameters.AddWithValue("@aml_namex", ComboBox9.Text)
        '            cmmM.Parameters.AddWithValue("@C_KEMA", TextBox11.Text)
        '            Try
        '                cmmM.ExecuteNonQuery()
        '            Catch ex As Exception

        '            End Try
        '        End Using
        '    Else
        '        Dim ssD As String = "insert into Amaleat_M(IDA,docn,dock,tdocn,tdock,mdocn,mdock,fdocn,fdock,ftdocn,ftdock,tahn,tahk,kabn,kabk,cdocn,cdock,aml_name,aml_kema,C_KEMA)values(@IDA,@docn,@dock,@tdocn,@tdock,@mdocn,@mdock,@fdocn,@fdock,@ftdocn,@ftdock,@tahn,@tahk,@kabn,@kabk,@cdocn,@cdock,@aml_name,@aml_kema,@C_KEMA)"
        '        Using cmmD As New SqlClient.SqlCommand(ssD, cn)
        '            cmmD.Parameters.AddWithValue("@IDA", CInt(Label5.Text))
        '            cmmD.Parameters.AddWithValue("@docn", CInt(Label4.Text))
        '            cmmD.Parameters.AddWithValue("@dock", CDbl(TextBox1.Text))
        '            cmmD.Parameters.AddWithValue("@tdocn", ComboBox6.Text)
        '            cmmD.Parameters.AddWithValue("@tdock", CDbl(TextBox8.Text))
        '            cmmD.Parameters.AddWithValue("@mdocn", ComboBox1.Text)
        '            cmmD.Parameters.AddWithValue("@mdock", CDbl(TextBox2.Text))
        '            cmmD.Parameters.AddWithValue("@fdocn", ComboBox5.Text)
        '            cmmD.Parameters.AddWithValue("@fdock", CDbl(TextBox7.Text))
        '            cmmD.Parameters.AddWithValue("@ftdocn", ComboBox3.Text)
        '            cmmD.Parameters.AddWithValue("@ftdock", CDbl(TextBox3.Text))
        '            cmmD.Parameters.AddWithValue("@tahn", ComboBox4.Text)
        '            cmmD.Parameters.AddWithValue("@tahk", CDbl(TextBox6.Text))
        '            cmmD.Parameters.AddWithValue("@kabn", ComboBox8.Text)
        '            cmmD.Parameters.AddWithValue("@kabk", CDbl(TextBox5.Text))
        '            cmmD.Parameters.AddWithValue("@cdocn", ComboBox7.Text)
        '            cmmD.Parameters.AddWithValue("@cdock", CDbl(TextBox4.Text))
        '            cmmD.Parameters.AddWithValue("@aml_name", ComboBox9.Text)
        '            cmmD.Parameters.AddWithValue("@C_KEMA", TextBox11.Text)
        '            'TextBox9.Text = Val(TextBox1.Text) + Val(TextBox8.Text) + Val(TextBox2.Text) + Val(TextBox7.Text) + Val(TextBox3.Text) + Val(TextBox6.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)
        '            cmmD.Parameters.AddWithValue("@aml_kema", CDbl(TextBox9.Text))
        '            Try
        '                cmmD.ExecuteNonQuery()
        '            Catch ex As Exception

        '            End Try
        '        End Using

        '    End If
        'End Using

        Dim sk1 As String
        sk1 = "select * from AMALEAT"
        Dim adk1 As New SqlClient.SqlDataAdapter(sk1, cn)
        Dim dsk1 As New DataSet
        adk1.Fill(dsk1, "AMALEAT")
        ComboBox9.DataSource = dsk1.Tables(0)
        ComboBox9.DisplayMember = "AML_NAME"
        ComboBox9.SelectedIndex = -1
        Dim sk2 As String
        sk2 = "select * from dn"
        Dim adk2 As New SqlClient.SqlDataAdapter(sk2, cn)
        Dim dsk2 As New DataSet
        adk2.Fill(dsk2, "dn")
        ComboBox2.DataSource = dsk2.Tables(0)
        ComboBox2.DisplayMember = "dn"
        ComboBox2.SelectedIndex = -1
        ComboBox2.Text = ""
        TextBox1.Text = 0
        ComboBox6.Text = ""
        TextBox8.Text = 0
        ComboBox1.Text = ""
        TextBox2.Text = 0
        ComboBox5.Text = ""
        TextBox7.Text = 0
        ComboBox3.Text = ""
        TextBox3.Text = 0
        ComboBox4.Text = ""
        TextBox6.Text = 0
        ComboBox8.Text = ""
        TextBox5.Text = 0
        ComboBox7.Text = ""
        TextBox4.Text = 0
        ComboBox9.Text = ""
        TextBox9.Text = 0
        TextBox10.Text = 0
        TextBox11.Text = 0
        ComboBox9.DropDownStyle = ComboBoxStyle.DropDownList
        Button10.Visible = True

    End Sub
End Class