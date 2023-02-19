Public Class FrmWidal

    Private Sub Form38_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label6.Text = Date.Today.Date
        Me.Label5.Text = dgx
        Dim sh1 As String = "select * from Widal_Test where fnumber=xxx1 "
        Dim cmh1 As New SqlClient.SqlCommand(sh1, cn)
        cmh1.Parameters.AddWithValue("xxx1", Label5.Text)
        Dim rdh1 As SqlClient.SqlDataReader = cmh1.ExecuteReader
        If rdh1.Read = True Then
            Me.ComboBox4.Text = rdh1!Salmonella_typhi_H
            Me.ComboBox1.Text = rdh1!Salmonella_H_Paratyphi_A
            Me.ComboBox2.Text = rdh1!Salmonella_H_Paratyphi_B
            Me.ComboBox6.Text = rdh1!Salmonella_typhi_O
            Me.ComboBox5.Text = rdh1!Salmonella_O_Paratyphi_A
            Me.ComboBox3.Text = rdh1!Salmonella_O_Paratyphi_B
            Me.ComboBox9.Text = rdh1!Salmonella_O_Paratyphi_C
            Me.ComboBox8.Text = rdh1!Brucella_Melitensis
            Me.ComboBox7.Text = rdh1!Brucella_Abortus
            tc73 = Me.ComboBox4.Text
            tc74 = Me.ComboBox1.Text
            tc75 = Me.ComboBox2.Text
            tc76 = Me.ComboBox6.Text
            tc77 = Me.ComboBox5.Text
            tc78 = Me.ComboBox3.Text
            tc79 = Me.ComboBox9.Text
            tc80 = Me.ComboBox8.Text
            tc81 = Me.ComboBox7.Text
            Me.Button4.Visible = False
        Else
            Me.Button4.Visible = True
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.ComboBox4.Text = "" Then
            Me.ComboBox4.Text = "None"
        End If
        If Me.ComboBox1.Text = "" Then
            Me.ComboBox1.Text = "None"
        End If
        If Me.ComboBox2.Text = "" Then
            Me.ComboBox2.Text = "None"
        End If
        If Me.ComboBox6.Text = "" Then
            Me.ComboBox6.Text = "None"
        End If
        If Me.ComboBox5.Text = "" Then
            Me.ComboBox5.Text = "None"
        End If
        If Me.ComboBox3.Text = "" Then
            Me.ComboBox3.Text = "None"
        End If
        If Me.ComboBox9.Text = "" Then
            Me.ComboBox9.Text = "None"
        End If
        If Me.ComboBox8.Text = "" Then
            Me.ComboBox8.Text = "None"
        End If
        If Me.ComboBox7.Text = "" Then
            Me.ComboBox7.Text = "None"
        End If
        Dim ss As String = "insert into Widal_Test(fnumber,Salmonella_typhi_H,Salmonella_H_Paratyphi_A,Salmonella_H_Paratyphi_B,Salmonella_typhi_O,Salmonella_O_Paratyphi_A,Salmonella_O_Paratyphi_B,Salmonella_O_Paratyphi_C,Brucella_Melitensis,Brucella_Abortus)values(x1,x2,x3,X4,x5,x6,x7,x8,x9,x10)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("x1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("x2", Me.ComboBox4.Text)
        cmm.Parameters.AddWithValue("x3", Me.ComboBox1.Text)
        cmm.Parameters.AddWithValue("x4", Me.ComboBox2.Text)
        cmm.Parameters.AddWithValue("x5", Me.ComboBox6.Text)
        cmm.Parameters.AddWithValue("x6", Me.ComboBox5.Text)
        cmm.Parameters.AddWithValue("x7", Me.ComboBox3.Text)
        cmm.Parameters.AddWithValue("x8", Me.ComboBox9.Text)
        cmm.Parameters.AddWithValue("x9", Me.ComboBox8.Text)
        cmm.Parameters.AddWithValue("x10", Me.ComboBox7.Text)
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
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox9.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc73)
        Try
            Dim sss As String = "update Widal_Test set Salmonella_typhi_H=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox4.Text)
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
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox2.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc74)
        Try
            Dim sss As String = "update Widal_Test set Salmonella_H_Paratyphi_A=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox1.Text)
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
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox3.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc75)
        Try
            Dim sss As String = "update Widal_Test set Salmonella_H_Paratyphi_B=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox2.Text)
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
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox6.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc76)
        Try
            Dim sss As String = "update Widal_Test set Salmonella_typhi_O=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox6.Text)
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
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox5.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc77)
        Try
            Dim sss As String = "update Widal_Test set Salmonella_O_Paratyphi_A=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox5.Text)
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

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox4.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc78)
        Try
            Dim sss As String = "update Widal_Test set Salmonella_O_Paratyphi_B=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox3.Text)
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
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox10.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc79)
        Try
            Dim sss As String = "update Widal_Test set Salmonella_O_Paratyphi_C=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox9.Text)
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
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox8.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc80)
        Try
            Dim sss As String = "update Widal_Test set Brucella_Melitensis=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox8.Text)
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
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox7.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc81)
        Try
            Dim sss As String = "update Widal_Test set Brucella_Abortus=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox7.Text)
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
        Dim F As New FrmLabReportViewer4
        F.ShowDialog()
    End Sub
End Class