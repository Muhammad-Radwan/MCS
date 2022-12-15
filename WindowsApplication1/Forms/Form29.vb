Public Class Form29

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
        Dim ss As String = "insert into TORCH(fnumber,TOXOPLASMA_IGG,TOXOPLASMA_IGM,RUBELLA_IGG,RUBELLA_IGM,CMV_IGG,CMV_IGM)values(x1,x2,x3,x4,x5,x6,x7)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("x1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("x2", TextBox1.Text)
        cmm.Parameters.AddWithValue("x3", TextBox2.Text)
        cmm.Parameters.AddWithValue("x4", TextBox3.Text)
        cmm.Parameters.AddWithValue("x5", TextBox4.Text)
        cmm.Parameters.AddWithValue("x6", TextBox5.Text)
        cmm.Parameters.AddWithValue("x7", TextBox6.Text)
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
        cmm.Parameters.AddWithValue("xx1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox1.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc17)
        Try
            Dim sss As String = "update TORCH set TOXOPLASMA_IGG=xxx1 where fnumber=xxx "
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

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox3.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc18)
        Try
            Dim sss As String = "update TORCH set Rubella_IGG=xxx1 where fnumber=xxx "
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

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox5.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc19)
        Try
            Dim sss As String = "update TORCH set CMV_IGG=xxx1 where fnumber=xxx "
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
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox2.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc20)
        Try
            Dim sss As String = "update TORCH set TOXOPLASMA_IGM=xxx1 where fnumber=xxx "
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
        cmm.Parameters.AddWithValue("xx4", tc21)
        Try
            Dim sss As String = "update TORCH set RUBELLA_IGM=xxx1 where fnumber=xxx "
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

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.Label1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox6.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc22)
        Try
            Dim sss As String = "update TORCH set CMV_IGM=xxx1 where fnumber=xxx "
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

    Private Sub Form29_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label2.Text = Date.Today.Date
        Me.Label1.Text = dgx
        Dim sh1 As String = "select * from torch where fnumber=xxx1 "
        Dim cmh1 As New SqlClient.SqlCommand(sh1, cn)
        cmh1.Parameters.AddWithValue("xxx1", Label1.Text)
        Dim rdh1 As SqlClient.SqlDataReader = cmh1.ExecuteReader
        If rdh1.Read = True Then
            Me.TextBox2.Text = rdh1!TOXOPLASMA_IGG
            Me.TextBox1.Text = rdh1!TOXOPLASMA_IGM
            Me.TextBox3.Text = rdh1!RUBELLA_IGG
            Me.TextBox4.Text = rdh1!RUBELLA_IGM
            Me.TextBox5.Text = rdh1!CMV_IGG
            Me.TextBox6.Text = rdh1!CMV_IGM
            tc17 = Me.TextBox2.Text
            tc18 = Me.TextBox1.Text
            tc19 = Me.TextBox3.Text
            tc20 = Me.TextBox4.Text
            tc21 = Me.TextBox5.Text
            tc22 = Me.TextBox6.Text
            Me.Button4.Visible = False
        Else
            Me.Button4.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vv1 = dgx
        Dim F As New FORM46
        F.ShowDialog()
    End Sub
End Class