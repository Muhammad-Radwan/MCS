Public Class Form25

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form27
        F.ShowDialog()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim sh11 As String = "select * from labdoc where fnumber=xxx1 "
        Dim cmh11 As New SqlClient.SqlCommand(sh11, cn)
        cmh11.Parameters.AddWithValue("xxx1", TextBox1.Text)
        Dim rdh11 As SqlClient.SqlDataReader = cmh11.ExecuteReader
        If rdh11.Read = True Then
            Me.Button2.Enabled = rdh11!L1
            Me.Button3.Enabled = rdh11!L2
            Me.Button5.Enabled = rdh11!L3
            Me.Button6.Enabled = rdh11!L4
            Me.Button7.Enabled = rdh11!L5
            Me.Button8.Enabled = rdh11!L6
            Me.Button9.Enabled = rdh11!L7
            Me.Button10.Enabled = rdh11!L8
            Me.Button11.Enabled = rdh11!L9
            Me.Button13.Enabled = rdh11!L10
            Me.Button12.Enabled = rdh11!L11
            Me.Button14.Enabled = rdh11!L12
            Me.Button15.Enabled = rdh11!L13
            Me.Button17.Enabled = rdh11!L14
            Me.Button16.Enabled = rdh11!L15
            Me.ComboBox4.Enabled = rdh11!L16
            Me.ComboBox3.Enabled = rdh11!L17
            Me.ComboBox1.Enabled = rdh11!L18
            Me.ComboBox2.Enabled = rdh11!L19
            Me.ComboBox5.Enabled = rdh11!L20
        End If

        Dim sh As String = "select * from main where fnumber=xxx1 "
        Dim cmh As New SqlClient.SqlCommand(sh, cn)
        cmh.Parameters.AddWithValue("xxx1", TextBox1.Text)
        Dim rdh As SqlClient.SqlDataReader = cmh.ExecuteReader
        If rdh.Read = True Then
            Me.Label2.Text = rdh!namex
            Me.Label4.Text = rdh!age
            Me.Label6.Text = rdh!phone
            Dim sh1 As String = "select * from LAB where fnumber=xxx1 "
            Dim cmh1 As New SqlClient.SqlCommand(sh1, cn)
            cmh1.Parameters.AddWithValue("xxx1", TextBox1.Text)
            Dim rdh1 As SqlClient.SqlDataReader = cmh1.ExecuteReader
            If rdh1.Read = True Then
                Me.ComboBox4.Text = rdh1!DNA
                Me.ComboBox3.Text = rdh1!HDNA
                Me.ComboBox1.Text = rdh1!Pregnancy_Test
                Me.ComboBox2.Text = rdh1!BHCG
                Me.ComboBox5.Text = rdh1!OTHERS
                Me.Button4.Visible = False
                tc1 = Me.ComboBox4.Text
                tc2 = Me.ComboBox3.Text
                tc3 = Me.ComboBox1.Text
                tc4 = Me.ComboBox2.Text
                tc5 = Me.ComboBox5.Text
            Else
                Me.Button4.Visible = True
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form25_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = Date.Today.Date
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.ComboBox4.Text = "" Then
            Me.ComboBox4.Text = "None"
        End If
        If Me.ComboBox5.Text = "" Then
            Me.ComboBox5.Text = "None"
        End If
        If Me.ComboBox3.Text = "" Then
            Me.ComboBox3.Text = "None"
        End If
        If Me.ComboBox2.Text = "" Then
            Me.ComboBox2.Text = "None"
        End If
        If Me.ComboBox1.Text = "" Then
            Me.ComboBox1.Text = "None"
        End If
        Dim ss As String = "insert into lab(fnumber,DNA,HDNA,OTHERS,PREGNANCY_TEST,BHCG)values(x1,x2,x3,x4,x5,x6)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("x1", TextBox1.Text)
        cmm.Parameters.AddWithValue("x2", Me.ComboBox4.Text)
        cmm.Parameters.AddWithValue("x3", Me.ComboBox3.Text)
        cmm.Parameters.AddWithValue("x4", ComboBox5.Text)
        cmm.Parameters.AddWithValue("x5", ComboBox1.Text)
        cmm.Parameters.AddWithValue("x6", ComboBox2.Text)
        Try
            cmm.ExecuteNonQuery()
            'Me.Button2.Visible = False

            MsgBox("Saved")

        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form28
        F.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim ss As String = "insert into history(fnumber,testtype,datex,resualt)values(xx1,xx2,xx3,xx4)"
        Dim cmm As New SqlClient.SqlCommand(ss, cn)
        cmm.Parameters.AddWithValue("xx1", Me.TextBox1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox9.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc1)
        Try
            Dim sss As String = "update LAB set DNA=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox4.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
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
        cmm.Parameters.AddWithValue("xx1", Me.TextBox1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox8.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc2)
        Try
            Dim sss As String = "update LAB set HDNA=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox3.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
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
        cmm.Parameters.AddWithValue("xx1", Me.TextBox1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox6.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc3)
        Try
            Dim sss As String = "update LAB set Pregnancy_Test=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox1.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
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
        cmm.Parameters.AddWithValue("xx1", Me.TextBox1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox7.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc4)
        Try
            Dim sss As String = "update LAB set BHCG=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox2.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
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
        cmm.Parameters.AddWithValue("xx1", Me.TextBox1.Text)
        cmm.Parameters.AddWithValue("xx2", Me.GroupBox10.Text)
        cmm.Parameters.AddWithValue("xx3", Date.Today.Date)
        cmm.Parameters.AddWithValue("xx4", tc5)
        Try
            Dim sss As String = "update LAB set OTHERS=xxx1 where fnumber=xxx "
            Dim cmmm As New SqlClient.SqlCommand(sss, cn)
            cmmm.Parameters.AddWithValue("xxx1", Me.ComboBox5.Text)
            cmmm.Parameters.AddWithValue("xxx", Me.TextBox1.Text)
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form29
        F.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form30
        F.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form31
        F.ShowDialog()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form32
        F.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form33
        F.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form34
        F.ShowDialog()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form35
        F.ShowDialog()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form36
        F.ShowDialog()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form37
        F.ShowDialog()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form38
        F.ShowDialog()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form39
        F.ShowDialog()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form40
        F.ShowDialog()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        dgx = Me.TextBox1.Text
        Dim F As New Form41
        F.ShowDialog()
    End Sub
End Class