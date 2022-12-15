Public Class Form39

    Private Sub Form39_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label6.Text = Date.Today.Date
        Me.Label5.Text = dgx
        Dim sh1 As String = "select * from Virology where fnumber=xxx1 "
        Dim cmh1 As New SqlClient.SqlCommand(sh1, cn)
        cmh1.Parameters.AddWithValue("xxx1", Label5.Text)
        Dim rdh1 As SqlClient.SqlDataReader = cmh1.ExecuteReader
        If rdh1.Read = True Then
            Me.TextBox2.Text = rdh1!hiv
            Me.TextBox1.Text = rdh1!HBSAG
            Me.TextBox3.Text = rdh1!HCV
            tc82 = Me.TextBox2.Text
            tc83 = Me.TextBox1.Text
            tc84 = Me.TextBox3.Text
            Me.Button4.Visible = False
        Else
            Me.Button4.Visible = True
        End If

    End Sub

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
        Dim ss As String = "insert into Virology(fnumber,hiv,HBSAG,HCV)values(x1,x2,x3,X4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("x1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("x2", Me.TextBox2.Text)
        cmm.Parameters.AddWithValue("x3", Me.TextBox1.Text)
        cmm.Parameters.AddWithValue("x4", Me.TextBox3.Text)
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
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox1.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc82)
        Try
            Dim sss As String = "update Virology set hiv=xxx1 where fnumber=xxx "
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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label5.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox3.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc83)
        Try
            Dim sss As String = "update Virology set HBSAG=xxx1 where fnumber=xxx "
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
        cmm.Parameters.AddWithValue("xx4", tc84)
        Try
            Dim sss As String = "update Virology set hcv=xxx1 where fnumber=xxx "
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vv1 = dgx
        Dim f As New Form54
        f.ShowDialog()
    End Sub
End Class