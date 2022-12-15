Public Class Form35

    Private Sub Form35_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label6.Text = Date.Today.Date
        Me.Label5.Text = dgx
        Dim sh1 As String = "select * from Electrolytes where fnumber=xxx1 "
        Dim cmh1 As New SqlClient.SqlCommand(sh1, cn)
        cmh1.Parameters.AddWithValue("xxx1", Label5.Text)
        Dim rdh1 As SqlClient.SqlDataReader = cmh1.ExecuteReader
        If rdh1.Read = True Then
            Me.ComboBox4.Text = rdh1!NA
            Me.ComboBox1.Text = rdh1!CL
            Me.ComboBox2.Text = rdh1!K
            tc53 = Me.ComboBox4.Text
            tc54 = Me.ComboBox1.Text
            tc55 = Me.ComboBox2.Text
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
        Dim ss As String = "insert into Electrolytes(fnumber,NA,CL,K)values(x1,x2,x3,X4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("x1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("x2", Me.ComboBox4.Text)
        cmm.Parameters.AddWithValue("x3", Me.ComboBox1.Text)
        cmm.Parameters.AddWithValue("x4", Me.ComboBox2.Text)
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
        cmm.Parameters.AddWithValue("xx4", tc53)
        Try
            Dim sss As String = "update Electrolytes set NA=xxx1 where fnumber=xxx "
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
        cmm.Parameters.AddWithValue("xx4", tc54)
        Try
            Dim sss As String = "update Electrolytes set CL=xxx1 where fnumber=xxx "
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
        cmm.Parameters.AddWithValue("xx4", tc55)
        Try
            Dim sss As String = "update Electrolytes set K=xxx1 where fnumber=xxx "
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vv1 = dgx
        Dim F As New Form51
        F.ShowDialog()
    End Sub
End Class