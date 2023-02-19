Public Class FrmEIA
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.TextBox2.Text = "" Then
            Me.TextBox2.Text = "None"
        End If
        If Me.TextBox1.Text = "" Then
            Me.TextBox1.Text = "None"
        End If
        If Me.TextBox3.Text = "" Then
            Me.TextBox3.Text = "None"
        End If
        If Me.TextBox4.Text = "" Then
            Me.TextBox4.Text = "None"
        End If
        If Me.TextBox5.Text = "" Then
            Me.TextBox5.Text = "None"
        End If
        If Me.TextBox6.Text = "" Then
            Me.TextBox6.Text = "None"
        End If
        If Me.TextBox7.Text = "" Then
            Me.TextBox7.Text = "None"
        End If
        If Me.TextBox8.Text = "" Then
            Me.TextBox8.Text = "None"
        End If
        If Me.TextBox9.Text = "" Then
            Me.TextBox9.Text = "None"
        End If
        If Me.TextBox10.Text = "" Then
            Me.TextBox10.Text = "None"
        End If
        If Me.TextBox11.Text = "" Then
            Me.TextBox11.Text = "None"
        End If
        If Me.TextBox12.Text = "" Then
            Me.TextBox12.Text = "None"
        End If
        If Me.TextBox13.Text = "" Then
            Me.TextBox13.Text = "None"
        End If
        If Me.TextBox14.Text = "" Then
            Me.TextBox14.Text = "None"
        End If
        If Me.TextBox15.Text = "" Then
            Me.TextBox15.Text = "None"
        End If
        Dim ss As String = "insert into EIA_HORMONAL(fnumber,EIA_BETA_HCG,EIA_ESTRADIOL,EIA_FSH,EIA_FT3,EIA_FT4,EIA_HBSAG,EIA_HCV,EIA_HIV12,EIA_LH,EIA_PROLACTIN,EIA_T3,EIA_T4,EIA_TESTESTERONE,EIA_TSH,EIA_PROGESTERON)values(x1,x2,x3,X4,x5,x6,x7,x8,x9,x10,x11,x12,x13,X14,X15,X16)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("x1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("x2", Me.TextBox2.Text)
        cmm.Parameters.AddWithValue("x3", Me.TextBox1.Text)
        cmm.Parameters.AddWithValue("x4", Me.TextBox3.Text)
        cmm.Parameters.AddWithValue("x5", Me.TextBox4.Text)
        cmm.Parameters.AddWithValue("x6", Me.TextBox5.Text)
        cmm.Parameters.AddWithValue("x7", Me.TextBox6.Text)
        cmm.Parameters.AddWithValue("x8", Me.TextBox7.Text)
        cmm.Parameters.AddWithValue("x9", Me.TextBox8.Text)
        cmm.Parameters.AddWithValue("x10", Me.TextBox9.Text)
        cmm.Parameters.AddWithValue("x11", Me.TextBox10.Text)
        cmm.Parameters.AddWithValue("x12", Me.TextBox11.Text)
        cmm.Parameters.AddWithValue("x13", Me.TextBox12.Text)
        cmm.Parameters.AddWithValue("x14", Me.TextBox13.Text)
        cmm.Parameters.AddWithValue("x15", Me.TextBox14.Text)
        cmm.Parameters.AddWithValue("x16", Me.TextBox15.Text)
        Try
            cmm.ExecuteNonQuery()
            'Me.Button2.Visible = False

            MsgBox("Saved")

        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox5.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc91)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_FT3=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox4.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox3.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc89)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_ESTRADIOL=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox1.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox4.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc90)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_FSH=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox3.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox12.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc98)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_T3=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox11.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox8.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc94)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_HCV=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox7.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox7.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc93)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_HBSAG=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox6.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox6.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc92)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_FT4=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox5.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox11.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc97)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_PROLACTIN=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox10.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox10.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc96)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_LH=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox9.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox9.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc95)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_HIV1+2=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox8.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox14.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc100)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_TESTESTERONE=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox13.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox13.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc99)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_T4=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox12.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub Form41_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label6.Text = Date.Today.Date
        Me.Label5.Text = dgx
        Dim sh1 As String = "select * from EIA_Hormonal where fnumber=xxx1 "
        Dim cmh1 As New SqlClient.SqlCommand(sh1, cn)
        cmh1.Parameters.AddWithValue("xxx1", Label5.Text)
        Dim rdh1 As SqlClient.SqlDataReader = cmh1.ExecuteReader
        If rdh1.Read = True Then
            Me.TextBox2.Text = rdh1!EIA_BETA_HCG
            Me.TextBox1.Text = rdh1!EIA_ESTRADIOL
            Me.TextBox3.Text = rdh1!EIA_FSH
            Me.TextBox4.Text = rdh1!EIA_FT3
            Me.TextBox5.Text = rdh1!EIA_FT4
            Me.TextBox6.Text = rdh1!EIA_HBSAG
            Me.TextBox7.Text = rdh1!EIA_HCV
            Me.TextBox8.Text = rdh1!EIA_HIV12
            Me.TextBox9.Text = rdh1!EIA_LH
            Me.TextBox10.Text = rdh1!EIA_PROLACTIN
            Me.TextBox11.Text = rdh1!EIA_T3
            Me.TextBox12.Text = rdh1!EIA_T4
            Me.TextBox13.Text = rdh1!EIA_TESTESTERONE
            Me.TextBox14.Text = rdh1!EIA_TSH
            Me.TextBox15.Text = rdh1!EIA_PROGESTERON
            tc88 = Me.TextBox2.Text
            tc89 = Me.TextBox1.Text
            tc90 = Me.TextBox3.Text
            tc91 = Me.TextBox4.Text
            tc92 = Me.TextBox5.Text
            tc93 = Me.TextBox6.Text
            tc94 = Me.TextBox7.Text
            tc95 = Me.TextBox8.Text
            tc96 = Me.TextBox9.Text
            tc97 = Me.TextBox10.Text
            tc98 = Me.TextBox11.Text
            tc99 = Me.TextBox12.Text
            tc100 = Me.TextBox13.Text
            tc101 = Me.TextBox14.Text
            tc102 = Me.TextBox15.Text
            Me.Button4.Visible = False
        Else
            Me.Button4.Visible = True
        End If

    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox2.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc88)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_BETA_HCG=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox2.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox15.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc101)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_TSH=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox14.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox16.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc102)
        Try
            Dim sss As String = "update EIA_Hormonal set EIA_PROGESTERON=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox15.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label5.Text)
            Try
                If MsgBox("Â·  —Ìœ «· ÕœÌÀø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    cmm.ExecuteNonQuery()
                    cmmm.ExecuteNonQuery()
                    MsgBox(" „ «· ÕœÌÀ")
                End If
            Catch ex As Exception
                MsgBox("lab")
            End Try
        Catch ex As Exception
            MsgBox("history")
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vv1 = dgx
        Dim F As New FrmLabReportViewer2
        F.ShowDialog()
    End Sub
End Class