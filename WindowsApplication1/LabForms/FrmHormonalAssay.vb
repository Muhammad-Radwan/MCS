Public Class FrmHormonalAssay

    Private Sub Form27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = dgx
        Me.Label2.Text = Date.Today.Date
        Dim sh1 As String = "select * from Hormonal_assay where fnumber=xxx1 "
        Dim cmh1 As New SqlClient.SqlCommand(sh1, cn)
        cmh1.Parameters.AddWithValue("xxx1", Me.Label1.Text)
        Dim rdh1 As SqlClient.SqlDataReader = cmh1.ExecuteReader
        If rdh1.Read = True Then
            Me.TextBox2.Text = rdh1!Progestron
            Me.TextBox1.Text = rdh1!Estradiol
            Me.TextBox3.Text = rdh1!Testestron
            Me.TextBox9.Text = rdh1!Prolactin
            Me.TextBox4.Text = rdh1!Oestrogen
            Me.TextBox5.Text = rdh1!FSH
            Me.TextBox6.Text = rdh1!LH
            Me.TextBox7.Text = rdh1!GH
            tc6 = Me.TextBox2.Text
            tc7 = Me.TextBox1.Text
            tc8 = Me.TextBox3.Text
            tc9 = Me.TextBox9.Text
            tc10 = Me.TextBox4.Text
            tc11 = Me.TextBox5.Text
            tc12 = Me.TextBox6.Text
            tc13 = Me.TextBox7.Text

            Me.Button4.Visible = False
        Else
            Me.Button4.Visible = True
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.TextBox1.Text = "" Then
            Me.TextBox1.Text = "None"
        End If
        If Me.TextBox2.Text = "" Then
            Me.TextBox2.Text = "None"
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
        If Me.TextBox9.Text = "" Then
            Me.TextBox9.Text = "None"
        End If
        If Me.TextBox7.Text = "" Then
            Me.TextBox7.Text = "None"
        End If
        Dim ss As String = "insert into Hormonal_assay(fnumber,Progestron,Estradiol,Testestron,Prolactin,Oestrogen,LH,FSH,GH)values(x1,x2,x3,x4,x5,x6,x7,x8,x9)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("x1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("x2", Me.TextBox2.Text)
        cmm.Parameters.AddWithValue("x3", Me.TextBox1.Text)
        cmm.Parameters.AddWithValue("x4", TextBox3.Text)
        cmm.Parameters.AddWithValue("x5", TextBox9.Text)
        cmm.Parameters.AddWithValue("x6", TextBox4.Text)
        cmm.Parameters.AddWithValue("x7", TextBox6.Text)
        cmm.Parameters.AddWithValue("x8", TextBox5.Text)
        cmm.Parameters.AddWithValue("x9", TextBox7.Text)
        Try
            cmm.ExecuteNonQuery()
            'Me.Button2.Visible = False

            MsgBox("Saved")

        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", TextBox1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox1.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc6)
        Try
            Dim sss As String = "update Hormonal_assay set Progestron=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox2.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label1.Text)
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
        cmm.Parameters.AddWithValue("xx1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox2.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc7)
        Try
            Dim sss As String = "update Hormonal_assay set Estradiol=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox1.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label1.Text)
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

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox4.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc8)
        Try
            Dim sss As String = "update Hormonal_assay set Testestron=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox3.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label1.Text)
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
        cmm.Parameters.AddWithValue("xx1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox5.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc9)
        Try
            Dim sss As String = "update Hormonal_assay set Prolactin=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox9.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label1.Text)
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
        cmm.Parameters.AddWithValue("xx1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox6.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc10)
        Try
            Dim sss As String = "update Hormonal_assay set Oestrogen=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox4.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label1.Text)
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
        cmm.Parameters.AddWithValue("xx1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox7.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc11)
        Try
            Dim sss As String = "update Hormonal_assay set FSH=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox5.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label1.Text)
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
        cmm.Parameters.AddWithValue("xx1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox9.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc12)
        Try
            Dim sss As String = "update Hormonal_assay set GH=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox7.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label1.Text)
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
        cmm.Parameters.AddWithValue("xx1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox8.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc13)
        Try
            Dim sss As String = "update Hormonal_assay set LH=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.TextBox6.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.Label1.Text)
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
        Dim F As New FrmLabReportViewer14
        F.ShowDialog()
    End Sub
End Class