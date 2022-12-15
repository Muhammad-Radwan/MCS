Public Class ByDate1
    Private Sub DateTimePicker1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles DateTimePicker1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            DateTimePicker2.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles DateTimePicker2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Button1.Focus()
        End If
    End Sub

    Private Sub DateTimePicker2_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles DateTimePicker2.Validated
        'DateTimePicker3.Value = DateAdd("d", 2, DateTimePicker2.Value)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        VV3 = Format(DateTimePicker1.Value, "yyyy/MM/dd")
        vv4 = Format(DateTimePicker2.Value, "yyyy/MM/dd")
        If sakprint = 0 Then
            '    'f.datex1 = DateTimePicker1.Value
            '    'f.datex2 = DateTimePicker2.Value
            '    Dim f As New Form13 With {
            '        .datex1 = Format(DateTimePicker1.Value, "yyyy/MM/dd"),
            '        .datex2 = Format(DateTimePicker2.Value, "yyyy/MM/dd"),
            '        .nn = "كشف المدفوعات من تاريخ" & " " & VV3 & " " & "إلى تاريخ " & " " & vv4
            '    }
            '    If NotifyIcons = False Then
            '        f.CLIN = "نسخة تجريبية"
            '    Else
            '        f.CLIN = My.Settings.CLIN
            '    End If
            '    f.NOTES = My.Settings.NOTES
            '    f.ShowDialog()
            'ElseIf sakprint = 1 Then
            '    Dim f As New Form13 With {
            '        .datex1 = Format(DateTimePicker1.Value, "yyyy/MM/dd"),
            '        .datex2 = Format(DateTimePicker2.Value, "yyyy/MM/dd"),
            '        .nn = "كشف المدفوعات بالصكوك من تاريخ" & " " & VV3 & " " & "إلى تاريخ " & " " & vv4
            '    }
            '    If NotifyIcons = False Then
            '        f.CLIN = "نسخة تجريبية"
            '    Else
            '        f.CLIN = My.Settings.CLIN
            '    End If
            '    f.NOTES = My.Settings.NOTES
            '    f.ShowDialog()
            'ElseIf sakprint = 2 Then
            'Dim f As New Form13 With {
            '        .datex1 = Format(DateTimePicker1.Value, "yyyy/MM/dd"),
            '        .datex2 = Format(DateTimePicker2.Value, "yyyy/MM/dd"),
            '        .nn = "كشف المدفوعات النقدية من تاريخ" & " " & VV3 & " " & "إلى تاريخ " & " " & vv4
            '    }
            '    If NotifyIcons = False Then
            '        f.CLIN = "نسخة تجريبية"
            '    Else
            '        f.CLIN = My.Settings.CLIN
            '    End If
            '    f.NOTES = My.Settings.NOTES
            '    f.ShowDialog()
            'ElseIf sakprint = 3 Then
            '    Dim f As New Form13 With {
            '        .datex1 = Format(DateTimePicker1.Value, "yyyy/MM/dd"),
            '        .datex2 = Format(DateTimePicker2.Value, "yyyy/MM/dd"),
            '        .nn = "كشف المدفوعات بالبطاقة من تاريخ" & " " & VV3 & " " & "إلى تاريخ " & " " & vv4
            '    }
            '    If NotifyIcons = False Then
            '        f.CLIN = "نسخة تجريبية"
            '    Else
            '        f.CLIN = My.Settings.CLIN
            '    End If
            '    f.NOTES = My.Settings.NOTES
            '    f.ShowDialog()
        ElseIf sakprint = 4 Then
            'Call Class1.CONNIC()
            'Dim sH As String = "select * from HALA_ESH where edate=@xx1 "
            'Dim cmH As New SqlClient.SqlCommand(sH, cn)
            'cmH.Parameters.AddWithValue("@xx1", Me.DateTimePicker1.Value)
            'Dim rdH As SqlClient.SqlDataReader
            'rdH = cmH.ExecuteReader
            'If rdH.Read = True Then
            '    Me.Label7.Text = CInt(rdH!IDMASRAF)
            'End If
            Call Class1.CONNIC()
            Dim delfk As String = "delete from Kholasa"
            Dim cmdfk As New SqlClient.SqlCommand(delfk, cn)
            cmdfk.ExecuteNonQuery()
            'Dim smfk As String = "select * from hala_esh where edate>='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' and edate<='" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "'"
            'Dim cmmmfk As New SqlClient.SqlCommand(smfk, cn)
            'Dim rdmfk As SqlClient.SqlDataReader = cmmmfk.ExecuteReader
            Dim EDATEXX As Date = Format(DateTimePicker1.Value, "yyyy-MM-dd")
            Do While EDATEXX <= Format(DateTimePicker2.Value, "yyyy-MM-dd")
                madfoo = 0
                Dim Str1 As String = "SELECT sum(madfoo) FROM kashef where format(datex,'yyyy-MM-dd')='" & Format(CDate(EDATEXX), "yyyy-MM-dd") & "'" & ""
                Dim cmd1 As New SqlClient.SqlCommand(Str1, cn)
                If IsDBNull(cmd1.ExecuteScalar) = True Then
                    madfoo = 0
                Else
                    madfoo = cmd1.ExecuteScalar
                End If
                'Dim Str11 As String = "SELECT sum(madfo) FROM hala_esh where format(edate,'yyyy-MM-dd')='" & Format(CDate(EDATEXX), "yyyy-MM-dd") & "'" & "and SANO<>'0' and SANO<>'بطاقة'"
                'Dim cmd11 As New SqlClient.SqlCommand(Str11, cn)
                'If IsDBNull(cmd11.ExecuteScalar) = True Then
                madfoosak = 0
                'Else
                '    madfoosak = cmd11.ExecuteScalar
                'End If
                'Dim Str12 As String = "SELECT sum(madfo) FROM hala_esh where format(edate,'yyyy-MM-dd')='" & Format(CDate(EDATEXX), "yyyy-MM-dd") & "'" & "and SANO='بطاقة'"
                'Dim cmd12 As New SqlClient.SqlCommand(Str12, cn)
                'If IsDBNull(cmd12.ExecuteScalar) = True Then
                madfoob = 0
                'Else
                '    madfoob = cmd12.ExecuteScalar
                'End If
                'Dim Str2 As String = "SELECT sum(lossva) FROM losse where format(lossdate,'yyyy-MM-dd')='" & Format(CDate(EDATEXX), "yyyy-MM-dd") & "'" & "and SANO='0'"
                'Dim cmd2 As New SqlClient.SqlCommand(Str2, cn)
                'If IsDBNull(cmd2.ExecuteScalar) = True Then
                lossvax = 0
                    'Else
                    '    lossvax = cmd2.ExecuteScalar
                    'End If
                    'Dim Str22 As String = "SELECT sum(lossva) FROM losse where format(lossdate,'yyyy-MM-dd')='" & Format(CDate(EDATEXX), "yyyy-MM-dd") & "'" & "and SANO<>'0' and SANO<>'بطاقة'"
                    'Dim cmd22 As New SqlClient.SqlCommand(Str22, cn)
                    'If IsDBNull(cmd22.ExecuteScalar) = True Then
                    lossvaxSAK = 0
                    'Else
                    '    lossvaxSAK = cmd22.ExecuteScalar
                    'End If
                    'Dim Str23 As String = "SELECT sum(lossva) FROM losse where format(lossdate,'yyyy-MM-dd')='" & Format(CDate(EDATEXX), "yyyy-MM-dd") & "'" & "and SANO='بطاقة'"
                    'Dim cmd23 As New SqlClient.SqlCommand(Str23, cn)
                    'If IsDBNull(cmd23.ExecuteScalar) = True Then
                    lossvaxB = 0
                    'Else
                    '    lossvaxB = cmd23.ExecuteScalar
                    'End If

                    'Dim Str3 As String = "SELECT sum(madfo) FROM hala_esh_em where format(edate,'yyyy-MM-dd')='" & Format(CDate(EDATEXX), "yyyy-MM-dd") & "'" & "and SANO='0'"
                    'Dim cmd3 As New SqlClient.SqlCommand(Str3, cn)
                    'If IsDBNull(cmd3.ExecuteScalar) = True Then
                    madfoo1 = 0
                'Else
                '    madfoo1 = cmd3.ExecuteScalar
                'End If
                'Dim Str31 As String = "SELECT sum(madfo) FROM hala_esh_em where format(edate,'yyyy-MM-dd')='" & Format(CDate(EDATEXX), "yyyy-MM-dd") & "'" & "and SANO<>'0' and SANO<>'بطاقة'"
                'Dim cmd31 As New SqlClient.SqlCommand(Str31, cn)
                'If IsDBNull(cmd31.ExecuteScalar) = True Then
                madfoo1SAK = 0
                'Else
                '    madfoo1SAK = cmd31.ExecuteScalar
                'End If
                'Dim Str32 As String = "SELECT sum(madfo) FROM hala_esh_em where format(edate,'yyyy-MM-dd')='" & Format(CDate(EDATEXX), "yyyy-MM-dd") & "'" & "and SANO='بطاقة'"
                'Dim cmd32 As New SqlClient.SqlCommand(Str32, cn)
                'If IsDBNull(cmd32.ExecuteScalar) = True Then
                madfoo1B = 0
                'Else
                '    madfoo1B = cmd32.ExecuteScalar
                'End If
                Dim Str4 As String = "SELECT sum(lossva) FROM loss where format(lossdate,'yyyy-MM-dd')='" & Format(CDate(EDATEXX), "yyyy-MM-dd") & "'" & "and SANO='0'"
                Dim cmd4 As New SqlClient.SqlCommand(Str4, cn)
                If IsDBNull(cmd4.ExecuteScalar) = True Then
                    lossvax1 = 0
                Else
                    lossvax1 = cmd4.ExecuteScalar
                End If
                Dim Str41 As String = "SELECT sum(lossva) FROM loss where format(lossdate,'yyyy-MM-dd')='" & Format(CDate(EDATEXX), "yyyy-MM-dd") & "'" & "and SANO<>'0' and SANO<>'بطاقة'"
                Dim cmd41 As New SqlClient.SqlCommand(Str41, cn)
                If IsDBNull(cmd41.ExecuteScalar) = True Then
                    lossvax1SAK = 0
                Else
                    lossvax1SAK = cmd41.ExecuteScalar
                End If
                Dim Str42 As String = "SELECT sum(lossva) FROM loss where format(lossdate,'yyyy-MM-dd')='" & Format(CDate(EDATEXX), "yyyy-MM-dd") & "'" & "and SANO='بطاقة'"
                Dim cmd42 As New SqlClient.SqlCommand(Str42, cn)
                If IsDBNull(cmd42.ExecuteScalar) = True Then
                    lossvax1B = 0
                Else
                    lossvax1B = cmd42.ExecuteScalar
                End If
                If madfoo <> 0 Or lossvax <> 0 Or madfoosak <> 0 Or lossvaxSAK <> 0 Or madfoob <> 0 Or lossvaxB <> 0 Or madfoo1 <> 0 Or lossvax1 <> 0 Or madfoo1SAK <> 0 Or lossvax1SAK <> 0 Or madfoo1B <> 0 Or lossvax1B <> 0 Then
                    Dim s20 As String = "insert into Kholasa(datex,Eyrad1,Eyrad2,Eyrad3,Masrof1,Masrof2,Masrof3) values(@datex,@Eyrad1,@Eyrad2,@Eyrad3,@Masrof1,@Masrof2,@Masrof3)"
                    Dim cm20 As New SqlClient.SqlCommand(s20, cn)
                    cm20.Parameters.AddWithValue("@datex", Format(CDate(EDATEXX), "yyyy-MM-dd"))
                    cm20.Parameters.AddWithValue("@Eyrad1", CDec(madfoo) + CDec(lossvax))
                    cm20.Parameters.AddWithValue("@Eyrad2", CDec(madfoosak) + CDec(lossvaxSAK))
                    cm20.Parameters.AddWithValue("@Eyrad3", CDec(madfoob) + CDec(lossvaxB))
                    cm20.Parameters.AddWithValue("@Masrof1", CDec(madfoo1) + CDec(lossvax1))
                    cm20.Parameters.AddWithValue("@Masrof2", CDec(madfoo1SAK) + CDec(lossvax1SAK))
                    cm20.Parameters.AddWithValue("@Masrof3", CDec(madfoo1B) + CDec(lossvax1B))
                    cm20.ExecuteNonQuery()
                End If
                EDATEXX = DateAdd("d", 1, EDATEXX)
            Loop
            'While rdmfk.Read = True
            'End While


            Dim f As New MOLAKHAS With {
                .datex1 = Format(DateTimePicker1.Value, "yyyy/MM/dd"),
                .datex2 = Format(DateTimePicker2.Value, "yyyy/MM/dd"),
                .nn = "تقرير الخلاصه اليوميه من تاريخ" & " " & VV3 & " " & "إلى تاريخ " & " " & VV4
            }
            If NotifyIcons = False Then
                f.CLIN = "نسخة تجريبية"
            Else
                f.CLIN = My.Settings.CLIN
            End If
            f.NOTES = My.Settings.NOTES
            f.ShowDialog()

        End If

        Me.Close()
    End Sub

End Class