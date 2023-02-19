Public Class FrmMostafeedEdit

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        Dim ss2 As String = "update MOSTAFEED set NAMEM=@NAMEM where idM=@idM"
        Using cmm2 As New SqlClient.SqlCommand(ss2, cn)
            'cmm2.Parameters.AddWithValue("@idd", TextBox1.Text)
            cmm2.Parameters.AddWithValue("@NAMEM", Trim(ComboBox4.Text))
            cmm2.Parameters.AddWithValue("@idM", CInt(dgxx))
            Try
                cmm2.ExecuteNonQuery()
                MsgBox("تم تعديل اسم المستفيد")
                Me.Close()
            Catch ex As Exception

            End Try
        End Using
    End Sub

    Private Sub TADEELM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TADEELM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox4.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub
End Class