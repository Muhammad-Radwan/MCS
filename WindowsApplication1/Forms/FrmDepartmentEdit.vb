Public Class FrmDepartmentEdit

    Private Sub TADEELvb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TADEELvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Class1.CONNIC()
        Dim skk As String
        skk = "select * from kesem"
        Dim adkk As New SqlClient.SqlDataAdapter(skk, cn)
        Dim dskk As New DataSet
        adkk.Fill(dskk, "kesem")
        ComboBox4.DataSource = dskk.Tables(0)
        ComboBox4.DisplayMember = "kesem"
        ComboBox4.SelectedIndex = -1
    End Sub

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        Call Class1.CONNIC()
        Dim sd As String = "delete from DNKEMA where IDD=@IDD"
        Dim cd As New SqlClient.SqlCommand(sd, cn)
        cd.Parameters.AddWithValue("@IDD", CInt(dgxx))
        If MsgBox("سيترتب عن هذه العمليه الغاء كل قيم اجراءات الطبيب ... اضغط نعم للمتابعة", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                cd.ExecuteNonQuery()
                Call Class1.CONNIC()
                Dim sG As String = "select * from EJRAA where EJRAA=@EJRAA AND IDK=@IDK"
                Using cmG As New SqlClient.SqlCommand(sG, cn)
                    cmG.Parameters.AddWithValue("@EJRAA", Trim("كشف"))
                    cmG.Parameters.AddWithValue("@IDK", CInt(L))
                    Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
                    If rdG.Read = True Then
                        t = rdG!IDJ
                    End If
                    rdG.Close()
                End Using
                Call Class1.CONNIC()
                Dim ss2 As String = "update dn set IDK=@idk where idd=@idd"
                Using cmm2 As New SqlClient.SqlCommand(ss2, cn)
                    'cmm2.Parameters.AddWithValue("@idd", TextBox1.Text)
                    cmm2.Parameters.AddWithValue("@IDK", CInt(L))
                    cmm2.Parameters.AddWithValue("@idd", CInt(dgxx))
                    Try
                        cmm2.ExecuteNonQuery()
                        Dim ss2C As String = "INSERT into dnKEMA(KEMA,KEMAEJ,EJRAA,idd) VALUES(@KEMA,@KEMAEJ,@EJRAA,@idd)"
                        Using cmm2C As New SqlClient.SqlCommand(ss2C, cn)
                            'cmm2.Parameters.AddWithValue("@idd", TextBox1.Text)
                            cmm2C.Parameters.AddWithValue("@KEMA", CDbl(kemax))
                            cmm2C.Parameters.AddWithValue("@KEMAEJ", CDbl(kematx))
                            cmm2C.Parameters.AddWithValue("@EJRAA", CInt(t))
                            cmm2C.Parameters.AddWithValue("@idd", CInt(dgxx))
                            Try
                                cmm2C.ExecuteNonQuery()
                                MsgBox("تم تعديل القسم")
                                Me.Close()
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub ComboBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox4.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedIndex <> -1 Then
            Call Class1.CONNIC()
            Dim sG As String = "select * from KESEM where KESEM=@xx1 "
            Using cmG As New SqlClient.SqlCommand(sG, cn)
                cmG.Parameters.AddWithValue("@xx1", ComboBox4.Text)
                Dim rdG As SqlClient.SqlDataReader = cmG.ExecuteReader
                If rdG.Read = True Then
                    L = rdG!IDK
                End If
                rdG.Close()
            End Using
        End If

    End Sub
End Class